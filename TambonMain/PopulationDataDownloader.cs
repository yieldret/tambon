﻿using MinimalJson;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Serialization;

namespace De.AHoerstemeier.Tambon
{
    // http://stat.dopa.go.th/stat/statnew/statTDD/datasource/showStatZone.php?statType=1&year=56&rcode=1001
    // {"aaData":[["00","ท้องถิ่นเขตพระนคร","27,279","29,405","56,684","19,257"],["10010100","แขวงพระบรมมหาราชวัง","2,695","1,921","4,616","1,304"],...
    // http://stat.dopa.go.th/stat/statnew/statTDD/views/showDistrictData.php?rcode=10&statType=1&year=56

    // http://stat.dopa.go.th/stat/statnew/statTDD/datasource/showStatDistrict.php?statType=1&year=56&rcode=10
    // {"aaData":[["00","กรุงเทพมหานคร","2,694,921","2,991,331","5,686,252","2,593,827"],["1001","ท้องถิ่นเขตพระนคร","27,279","29,405","56,684","19,257"],...
    // http://stat.dopa.go.th/stat/statnew/statTDD/views/showZoneData.php?rcode=1001&statType=1&year=56

    public class PopulationDataDownloader
    {
        #region fields

        /// <summary>
        /// Geocode for which the data is to be downloaded.
        /// </summary>
        private UInt32 _geocode = 0;
        /// <summary>
        /// Year in Buddhist era, shortened to two digits.
        /// </summary>
        private Int32 _yearShort = 0;

        #endregion fields

        #region properties

        /// <summary>
        /// Gets the population data.
        /// </summary>
        /// <value>The data.</value>
        public Entity Data
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the year (common era) for which is population data is done.
        /// </summary>
        /// <value>The year.</value>
        public Int32 Year
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets or sets the directory to write the processed data as XML files.
        /// </summary>
        /// <value>The output directory.</value>
        public static String OutputDirectory
        {
            get;
            set;
        }
        #endregion properties

        #region constructor

        /// <summary>
        /// Creates a new instance of <see cref="PopulationDataDownloader"/>.
        /// </summary>
        /// <param name="year">Year (common era), must be between 1957 (BE 2500) and 2056 (BE 2599).</param>
        /// <param name="geocode">Province geocode. 0 means to download all of country.</param>
        public PopulationDataDownloader(Int32 year, UInt32 geocode)
        {
            Year = year;
            _geocode = geocode;
            _yearShort = Year + 543 - 2500;
            if ( (_yearShort < 0) | (_yearShort > 99) )
            {
                throw new ArgumentOutOfRangeException();
            }
            if ( (_geocode < 0) | (_geocode > 99) )
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        private PopulationDataDownloader()
        {
        }

        #endregion constructor

        #region constants

        // 0 -> year - 2500
        // 1 -> geocode, 4 digits
        private const String _urlShowAmphoe = "http://stat.dopa.go.th/stat/statnew/statTDD/views/showDistrictData.php?statType=1&year={0}&rcode={1}";
        private const String _urlDataAmphoe = "http://stat.dopa.go.th/stat/statnew/statTDD/datasource/showStatZone.php?statType=1&year={0}&rcode={1}";

        // 0 -> year - 2500
        // 1 -> geocode, 2 digits
        private const String _urlShowChangwat = "http://stat.dopa.go.th/stat/statnew/statTDD/views/showZoneData.php?statType=1&year={0}&rcode={1}";
        private const String _urlDataChangwat = "http://stat.dopa.go.th/stat/statnew/statTDD/datasource/showStatDistrict.php?statType=1&year={0}&rcode={1}";

        #endregion constants

        #region events

        public EventHandler<EventArgs> ProcessingFinished;

        private void OnProcessingFinished(EventArgs e)
        {
            if ( ProcessingFinished != null )
            {
                ProcessingFinished(this, e);
            }
        }

        #endregion events

        #region public methods
        /// <summary>
        /// Gets the (english) Wikipedia citation string for the current data element.
        /// </summary>
        /// <returns></returns>
        public String WikipediaReference()
        {
            String result = String.Format(CultureInfo.InvariantCulture,
                "<ref>{{cite web|url={0}|publisher=Department of Provincial Administration|title=Population statistics {1}}}</ref>",
                String.Format(CultureInfo.InvariantCulture,_urlShowChangwat,_yearShort,_geocode), Year);
            return result;
        }
        
        /// <summary>
        /// Loads population data from a XML file.
        /// </summary>
        /// <param name="fromFile">File name.</param>
        /// <returns>Population data.</returns>
                public static PopulationData Load(String fromFile)
        {
            PopulationData result = null;
            using ( var fileStream = new FileStream(fromFile, FileMode.Open, FileAccess.Read) )
            {
                result = XmlManager.XmlToEntity<PopulationData>(fileStream, new XmlSerializer(typeof(PopulationData)));
            }

            return result;
        }

        /// <summary>
        /// Gets the filename to which the data would be written.
        /// </summary>
        /// <returns>File name of generated file.</returns>
                public String XmlExportFileName()
        {
            String result = String.Empty;
            if ( Data != null )
            {
                String outputDirectory = Path.Combine(OutputDirectory, "DOPA");
                Directory.CreateDirectory(outputDirectory);
                result = Path.Combine(outputDirectory, String.Format("population{0:D2} {1}.XML", Data.geocode, Year));
            }
            return result;
        }

#endregion

        #region private methods

        private JsonObject GetDataFromDopa(UInt32 geocode)
        {
            String url;
            if (geocode < 100)
            {
                url = String.Format(CultureInfo.InvariantCulture,_urlDataChangwat,_yearShort,geocode);
            }
            else
            {
                url = String.Format(CultureInfo.InvariantCulture,_urlDataAmphoe,_yearShort,geocode);
            }
                WebClient webClient = new System.Net.WebClient();
                Stream inputStream = webClient.OpenRead(url);
            String response = StreamToString(inputStream);

            JsonValue result = JsonValue.readFrom(response);
            if (!result.isObject())
            {
                return null;
            }
            JsonObject obj = result.asObject();
            return obj;
        }
        /// <summary>
        /// Reads a stream into a string.
        /// </summary>
        /// <param name="stream">Input stream.</param>
        /// <returns>Content of stream as string.</returns>
        private static String StreamToString(Stream stream)
        {
            using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
            {
                return reader.ReadToEnd();
            }
        }


        public static Uri GetDisplayUrl(Int32 year, UInt32 geocode)
        {
            UInt32 changwatGeocode = GeocodeHelper.ProvinceCode(geocode);
            String url = String.Format(CultureInfo.InvariantCulture, _urlShowChangwat, year + 543 - 2500, geocode);
            return new Uri(url);
        }

        private IEnumerable<Entity> ParseJson(JsonObject data)
        {
            var result = new List<Entity>();
            var actualData = data.get("aaData");
            if (actualData != null)
            {
                var array = actualData.asArray();
                foreach (JsonArray item in array)
                {
                    var parsedData = new List<String>();
                    foreach (JsonValue dataPoint in item)
                    {
                        var strippedText = Regex.Replace(dataPoint.asString(), "<.*?>", string.Empty).Replace(",", String.Empty);
                        if (strippedText == "-")
                        {
                            strippedText = "0";
                        }
                        parsedData.Add(strippedText);
                    }
                    if (parsedData.First() != "00")
                    {
                        Entity entity = new Entity();
                        entity.ParseName(parsedData.ElementAt(1));
                        entity.geocode = Convert.ToUInt32(parsedData.First(), CultureInfo.InvariantCulture);

                        PopulationData population = new PopulationData();
                        entity.population.Add(population);
                        population.source = PopulationDataSourceType.DOPA;
                        population.referencedate = new DateTime(Year, 12, 31);
                        HouseholdDataPoint householdDataPoint = new HouseholdDataPoint();
                        householdDataPoint.male = Convert.ToInt32(parsedData.ElementAt(2), CultureInfo.InvariantCulture);
                        householdDataPoint.female = Convert.ToInt32(parsedData.ElementAt(3), CultureInfo.InvariantCulture);
                        householdDataPoint.total = Convert.ToInt32(parsedData.ElementAt(4), CultureInfo.InvariantCulture);
                        householdDataPoint.households = Convert.ToInt32(parsedData.ElementAt(5), CultureInfo.InvariantCulture);
                        population.data.Add(householdDataPoint);
                        result.Add(entity);
                    }
                }
            }
            return result;
        }

        protected void GetData()
        {
            Data = new Entity();
            var data = GetDataFromDopa(_geocode);
            Data.entity.AddRange(ParseJson(data));
            foreach (var entity in Data.entity)
            {
                var subData = GetDataFromDopa(entity.geocode);
                entity.entity.AddRange(ParseJson(subData)); 
            }
            if ( Data != null )
            {
                Data.geocode = _geocode;
            }
        }

        /// <summary>
        /// Synchronizes the calculated data with the global geocode list.
        /// </summary>
        private void GetGeocodes()
        {
            if ( Data != null )
            {
                var geocodes = GlobalData.GetGeocodeList(Data.geocode);
                // _invalidGeocodes = geocodes.InvalidGeocodeEntries();
                Data.SynchronizeGeocodes(geocodes);
            }
        }

        /// <summary>
        /// Exports the data to a XML in the <see cref="OutputDirectory"/>.
        /// </summary>
        public void SaveXml()
        {
            var data = XmlManager.EntityToXml<Entity>(Data);
            using ( var fileStream = new StreamWriter(XmlExportFileName()) )
            {
                fileStream.WriteLine(data);
            }
        }

        private void ReOrderThesaban()
        {
            if ( Data != null )
            {
                Data.ReorderThesaban();
            }
        }

        /// <summary>
        /// Gets the data for all provinces, used if <see cref="_geocode"/> is 0.
        /// </summary>
        private void ProcessAllProvinces()
        {
            var data = new Entity();
            foreach ( var entry in GlobalData.Provinces )
            {
                var tempCalculator = new PopulationDataDownloader(Year, entry.geocode);
                tempCalculator.Process();
                data.entity.Add(tempCalculator.Data);
            }
            // data.ConsolidatePopulationData();
            Data = data;
        }

        private void ProcessProvince(UInt32 geocode)
        {
            GetData();
            GetGeocodes();
            ReOrderThesaban();
            foreach ( var entity in Data.FlatList() )
            {
                entity.population.First().CalculateTotal();
            }
        }

        /// <summary>
        /// Starts the download of the data.
        /// </summary>
        public void Process()
        {
            if ( _geocode == 0 )
            {
                ProcessAllProvinces();
            }
            else
            {
                ProcessProvince(_geocode);
            }

            OnProcessingFinished(new EventArgs());
        }

        #endregion methods

    }
}