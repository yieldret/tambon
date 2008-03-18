using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using System.Threading;
using De.AHoerstemeier.Tambon;

namespace Tambon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AHGlobalSettings.LoadSettings();
        }

        private void btnGazetteMirror_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(Helper.GlobalGazetteList.MirrorAllToCache);
            t.Name = "Worker Thread Gazette Mirror";
            t.Start();
        }
        private void PopulationDataReadyShow(PopulationData iData)
        {
            Invoke(new PopulationData.ProcessingFinished(ShowPopulationDialog), new object[] { iData });
        }
        private void PopulationDataReadyCheck(PopulationData iData)
        {
            Invoke(new PopulationData.ProcessingFinished(CheckPopulationData), new object[] { iData });
        }
        private void ShowPopulationDialog(PopulationData iData)
        {
            var lDataForm = new PopulationDataView();
            lDataForm.OnShowGazette += ShowGazetteDialog;
            lDataForm.Data = iData;
            lDataForm.Show();
        }
        private void CheckPopulationData(PopulationData iData)
        {
            iData.SaveXML();
            var EntitiesWithoutGeocode = iData.EntitiesWithoutGeocode();
            if (EntitiesWithoutGeocode.Count > 0)
            {
                String lMessage = "";

                foreach (PopulationDataEntry lEntry in EntitiesWithoutGeocode)
                {
                    lMessage = lMessage + lEntry.Name + "\n";
                }

                MessageBox.Show(EntitiesWithoutGeocode.Count.ToString() + " entities without geocode in " + iData.year.ToString() + "\n" + lMessage);
            }
        }
        private void btnPopulation_Click(object sender, EventArgs e)
        {
            PopulationData lDownloader = new PopulationData(Convert.ToInt32(edt_year.Value), GetCurrentChangwat().Geocode);
            Thread lThread = new Thread(lDownloader.Process);

            lDownloader.OnProcessingFinished += PopulationDataReadyShow;

            lThread.Name = "Worker Thread Population " + GetCurrentChangwat().English + " " + lDownloader.year.ToString();
            lThread.Start();
        }

        private void FillChangwatCombobox(ComboBox cbx_changwat)
        {
            XElement lGeocodeXML = XElement.Load("geocode.xml");

            var lQuery = from c in lGeocodeXML.Descendants("entity")
                         orderby (string)c.Attribute("english")
                         select new PopulationDataEntry
                           {
                               Name = (string)c.Attribute("name"),
                               English = (string)c.Attribute("english"),
                               Type = (EntityType)Enum.Parse(typeof(EntityType), (string)c.Attribute("type")),
                               Geocode = (Int32)c.Attribute("geocode")
                           };

            cbx_changwat.Items.Clear();
            foreach (PopulationDataEntry lEntry in lQuery)
            {
                cbx_changwat.Items.Add(lEntry);
                if (lEntry.Geocode == 84)
                {
                    cbx_changwat.SelectedItem = lEntry;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillChangwatCombobox(cbx_changwat);
        }

        private void btnPopulationDownloadAll_click(object sender, EventArgs e)
        {
            var lChangwat = (PopulationDataEntry)cbx_changwat.SelectedItem;
            Int32 lGeocode = lChangwat.Geocode;
            for (int lYear = 1993; lYear <= 2007; lYear++)
            {

                PopulationData lDownloader = new PopulationData(lYear, lGeocode);
                lDownloader.OnProcessingFinished += PopulationDataReadyCheck;
                Thread t = new Thread(lDownloader.Process);
                t.Name = "Worker Thread Population " + lChangwat.English + " " + lDownloader.year.ToString();
                t.Start();
            }
        }
        private PopulationDataEntry GetCurrentChangwat()
        {
            var lChangwat = (PopulationDataEntry)cbx_changwat.SelectedItem;
            return lChangwat;
        }

        private void btn_GazetteShow_Click(object sender, EventArgs e)
        {
            RoyalGazetteList lGazetteList = Helper.GlobalGazetteList.AllAboutEntity(GetCurrentChangwat().Geocode, true);
            RoyalGazetteViewer.ShowGazetteDialog(lGazetteList);
        }

        private void btn_GazetteLoad_Click(object sender, EventArgs e)
        {
            // DirectoryInfo lDirInfo = new DirectoryInfo("e:\\thailand\\dopa\\tambon\\gazette\\");

            string lDir = Path.Combine(Application.StartupPath, "gazette");
            if (Directory.Exists(lDir))
            {
                foreach (string lFilename in Directory.GetFiles(lDir, "Gazette*.XML"))
                {
                    RoyalGazetteList lCurrentGazetteList = RoyalGazetteList.Load(lFilename);
                    Helper.GlobalGazetteList.AddRange(lCurrentGazetteList);
                }
                Boolean lHasEntries = (Helper.GlobalGazetteList.Count > 0);
                btn_GazetteMirror.Enabled = lHasEntries;
                btn_GazetteShow.Enabled = lHasEntries;
                btn_GazetteShowAll.Enabled = lHasEntries;
            }
            else
            {
                MessageBox.Show(this, "Fatal error: Directory " + lDir + " is not existing.\nApplication will be terminated.", "Directory error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void cbx_changwat_SelectedValueChanged(object sender, EventArgs e)
        {
            Int32 lGeocode = GetCurrentChangwat().Geocode;
            Boolean lHasData = (File.Exists(PopulationData.GeocodeSourceFile(lGeocode)));
            btn_Population.Enabled = lHasData;
            btn_PopulationAll.Enabled = lHasData;
        }

        private void GazetteNewsReady(RoyalGazetteList data)
        {
            Invoke(new RoyalGazetteList.ProcessingFinished(RoyalGazetteViewer.ShowGazetteNewsDialog), new object[] { data });
        }
        private void ShowGazetteDialog(RoyalGazetteList data)
        {
            Invoke(new RoyalGazetteList.ProcessingFinished(RoyalGazetteViewer.ShowGazetteDialog), new object[] { data });
        }
        private void btn_CheckForNews_Click(object sender, EventArgs e)
        {
            RoyalGazetteOnlineSearch lSearcher = new RoyalGazetteOnlineSearch();
            lSearcher.OnProcessingFinished += GazetteNewsReady;
            Thread t = new Thread(lSearcher.SearchNewsNow);
            t.Name = "Worker Thread Gazette News";
            t.Start();
        }

        private void btn_GazetteShowAll_Click(object sender, EventArgs e)
        {
            ShowGazetteDialog(Helper.GlobalGazetteList);
        }

        private void btn_GazetteSearchYear_Click(object sender, EventArgs e)
        {
            RoyalGazetteOnlineSearch lSearcher = new RoyalGazetteOnlineSearch();
            var lGazetteList = lSearcher.SearchNews(new DateTime((Int32)edt_year.Value, 1, 1));
            GazetteNewsReady(lGazetteList);
        }

        private void btn_LoadCcaatt_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"e:\Thailand\geocode\";
            openFileDialog1.Filter = "Text files (*.txt)|*.txt";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            openFileDialog1.ShowDialog();

        }
        private void openFileDialog1_FileOk(object sender,
                System.ComponentModel.CancelEventArgs e)
        {
            this.Activate();
            String[] lFiles = openFileDialog1.FileNames;
            foreach (String lFileName in lFiles)
            {
                var lData = new AHDopaGeocodeList(lFileName);
                lData.RemoveAllKnownGeocodes();
                lData.ExportToXML(AHGlobalSettings.XMLOutputDir + "unknowngeocodes.xml");
            }
        }

        private void btn_DownloadCcaatt_Click(object sender, EventArgs e)
        {
            var lData = AHDopaGeocodeList.CreateFromOnline();
        }

        private void btn_GazetteSearch_Click(object sender, EventArgs e)
        {
            RoyalGazetteSearch lSearchWindow = new RoyalGazetteSearch();
            lSearchWindow.OnSearchFinished += GazetteNewsReady;
            lSearchWindow.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AHAmphoeComDownloader lDownloader = new AHAmphoeComDownloader();
            Int32 lGeocode = GetCurrentChangwat().Geocode;
            var lData = lDownloader.DoItAll(lGeocode);
            XmlDocument lXmlDocument = new XmlDocument();
            var lElement = (XmlElement)lXmlDocument.CreateNode("element", "mirror", "");
            lElement.SetAttribute("date", DateTime.Now.ToString("yyyy-MM-dd"));
            lXmlDocument.AppendChild(lElement);
            foreach (var lDataEntry in lData)
            {
                lDataEntry.ExportToXML(lElement);
            }
            Directory.CreateDirectory(OutputDir());
            lXmlDocument.Save(OutputDir() + "amphoe" + lGeocode.ToString() + ".xml");

        }
        private String OutputDir()
        {
            String retval = AHGlobalSettings.XMLOutputDir + "amphoe\\";
            return retval;
        }

        private void ButtonThesaban_Click(object sender, EventArgs e)
        {
            var lDownloader = new KontessabanDownloader();
            var lData = lDownloader.DoIt();

            XmlDocument lXmlDocumentAll = new XmlDocument();
            var lNodeAll = (XmlElement)lXmlDocumentAll.CreateNode("element", "country", "");
            lXmlDocumentAll.AppendChild(lNodeAll);
            XmlDocument lXmlDocumentNew = new XmlDocument();
            var lNodeNew = (XmlElement)lXmlDocumentNew.CreateNode("element", "country", "");
            lXmlDocumentNew.AppendChild(lNodeNew);
            foreach (KontessabanDataEntry entity in lData)
            {
                entity.ExportToXML(lNodeAll);
                if (entity.Geocode == 0)
                {
                    entity.ExportToXML(lNodeNew);
                }
            }
            lXmlDocumentAll.Save(AHGlobalSettings.XMLOutputDir + "Tessaban.xml");
            lXmlDocumentNew.Save(AHGlobalSettings.XMLOutputDir + "NewTessaban.xml");
        }

        private void btnSetup_Click(object sender, EventArgs e)
        {
            Setup lSetupForm = new Setup();
            lSetupForm.ShowDialog();
        }

        private void btnNumerals_Click(object sender, EventArgs e)
        {
            NumeralsHelper lNumeralsHelperForm = new NumeralsHelper();
            lNumeralsHelperForm.Show();
        }
    }
}