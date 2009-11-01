using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace De.AHoerstemeier.Tambon
{
    class PopulationDataEntry : ICloneable, IGeocode
    {
        public delegate void PopulationDataEntryEvent(PopulationDataEntry data);

        #region variables
        private List<Int32> mGeocodeParent = new List<Int32>(); // for former King Amphoe or Thesaban
        private List<Int32> mNewGeocode = new List<Int32>();
        private List<PopulationDataEntry> mSubEntities = new List<PopulationDataEntry>();
        private List<String> mOldNames = new List<String>();
        private List<EntityOffice> mOffices = new List<EntityOffice>();
        #endregion

        #region properties
        public String Name { get; set; }
        public String English { get; set; }
        public Int32 Male { get; set; }
        public Int32 Female { get; set; }
        public Int32 Total { get; set; }
        public Int32 Households { get; set; }
        public Int32 Geocode { get; set; }
        public Boolean Obsolete { get; set; }
        public String Comment { get; set; }
        public List<EntityOffice> Offices { get { return mOffices; } }
        public List<PopulationDataEntry> SubEntities
        {
            get { return mSubEntities; }
        }
        public List<String> OldNames
        {
            get { return mOldNames; }
        }
        public EntityType Type { get; set; }
        public List<Int32> GeocodeParent
        { get { return mGeocodeParent; } }
        public List<Int32> NewGeocode
        {
            get { return mNewGeocode; }
        }
        #endregion

        #region constructor
        public PopulationDataEntry()
        {
            Type = EntityType.Unknown;
            Total = 0;
            Male = 0;
            Female = 0;
            Households = 0;
            English = string.Empty;
            Geocode = 0;
            Obsolete = false;
        }
        public PopulationDataEntry(PopulationDataEntry value)
        {
            Type = value.Type;
            Total = value.Total;
            Male = value.Male;
            Female = value.Female;
            Households = value.Households;
            English = value.English;
            Geocode = value.Geocode;
            Obsolete = value.Obsolete;
            Name = value.Name;
            Comment = value.Comment;

            foreach (Int32 lGeocode in value.mNewGeocode)
            {
                mNewGeocode.Add(lGeocode);
            }
            foreach (Int32 lGeocode in value.mGeocodeParent)
            {
                mGeocodeParent.Add(lGeocode);
            }
            foreach (PopulationDataEntry lSubEntity in value.SubEntities)
            {
                SubEntities.Add((PopulationDataEntry)lSubEntity.Clone());
            }
            foreach (EntityOffice lOffice in value.Offices)
            {
                Offices.Add((EntityOffice)lOffice.Clone());
            }
            foreach (String lOldName in mOldNames)
            {
                mOldNames.Add(lOldName);
            }
        }
        public PopulationDataEntry(String iName, OfficeType iType, EntityLeaderList iLeaderList)
        {
            Name = iName;
            EntityOffice lOffice = new EntityOffice();
            lOffice.Type = iType;
            lOffice.OfficialsList = iLeaderList;
            Offices.Add(lOffice);
        }
        #endregion

        #region methods
        public override string ToString()
        {
            return English;
        }
        internal void ParseName(string iValue)
        {
            if (!String.IsNullOrEmpty(iValue))
            {
                iValue = iValue.Replace("ทต.", Helper.EntityNames[EntityType.ThesabanTambon]);
                Type = Helper.ParseEntityType(iValue);
                if ((Type == EntityType.Unknown) | (Type == EntityType.Bangkok))
                {
                    Name = iValue;
                }
                else
                {
                    Name = iValue.Replace(Helper.EntityNames[Type], "");
                }
                if (Helper.Sakha.Contains(Type))
                {
                    // Some pages have the syntax "Name AmphoeName" with the word อำเภอ, others without
                    //Int32 pos = Name.IndexOf(Helper.EntityNames[EntityType.Amphoe]);
                    //if (pos > 0)
                    //{
                    //    mName = mName.Remove(pos - 1);
                    //}
                    Int32 pos = Name.IndexOf(" ");
                    if (pos > 0)
                    {
                        Name = Name.Remove(pos);
                    }

                }
                Obsolete = Name.Contains("*");
                Name = Name.Replace("*", "");
                if (Name.StartsWith("."))
                {
                    // Mistake in DOPA population statistic for Buriram 2005, a leading "."
                    Name = Name.Substring(1, Name.Length - 1);
                }
                Name = Name.Trim();
            }
        }
        internal virtual void WriteToXMLNode(XmlElement iNode)
        {
            iNode.SetAttribute("name", Name);
            if (!String.IsNullOrEmpty(English))
            {
                iNode.SetAttribute("english", English);
            }
            if (Geocode != 0)
            {
                iNode.SetAttribute("geocode", Geocode.ToString());
            }
            if (NewGeocode.Count > 0)
            {
                string s = "";
                foreach (Int32 i in NewGeocode)
                {
                    s = s + i.ToString() + ",";
                }
                s = s.Remove(s.Length - 1);
                iNode.SetAttribute("newgeocode", s);
            }

            if (Type != EntityType.Unknown)
            {
                iNode.SetAttribute("type", Type.ToString());
            }
            if (Total > 0)
            {
                iNode.SetAttribute("total", Total.ToString());
            }
            if (Female > 0)
            {
                iNode.SetAttribute("female", Female.ToString());
            }
            if (Male > 0)
            {
                iNode.SetAttribute("male", Male.ToString());
            }
            if (Households > 0)
            {
                iNode.SetAttribute("households", Households.ToString());
            }
            if (GeocodeParent.Count > 0)
            {
                string s = "";
                foreach (Int32 i in GeocodeParent)
                {
                    s = s + i.ToString() + ",";
                }
                s = s.Remove(s.Length - 1);
                iNode.SetAttribute("parent", s);
            }
            if (!String.IsNullOrEmpty(Comment))
            {
                iNode.SetAttribute("comment", Comment);
            }
            foreach (EntityOffice lOffice in Offices)
            {
                lOffice.ExportToXML(iNode);
            }
            foreach (PopulationDataEntry lEntity in SubEntities)
            {
                lEntity.ExportToXML(iNode);
            }
        }
        public void ExportToXML(XmlNode iNode)
        {
            XmlDocument lXmlDocument = Helper.XmlDocumentFromNode(iNode);
            var lNewElement = (XmlElement)lXmlDocument.CreateNode("element", "entity", "");
            iNode.AppendChild(lNewElement);
            WriteToXMLNode(lNewElement);
        }
        internal static PopulationDataEntry Load(XmlNode iNode)
        {
            PopulationDataEntry RetVal = null;

            if (iNode != null && iNode.Name.Equals("entity"))
            {
                RetVal = new PopulationDataEntry();
                RetVal.Name = Helper.GetAttribute(iNode, "name").Trim();
                RetVal.English = Helper.GetAttributeOptionalString(iNode, "english").Trim();
                RetVal.Total = Helper.GetAttributeOptionalInt(iNode, "total", 0);
                RetVal.Obsolete = Helper.GetAttributeOptionalBool(iNode, "obsolete", false);
                RetVal.Male = Helper.GetAttributeOptionalInt(iNode, "male", 0);
                RetVal.Female = Helper.GetAttributeOptionalInt(iNode, "female", 0);
                RetVal.Households = Helper.GetAttributeOptionalInt(iNode, "households", 0);
                RetVal.Geocode = Helper.GetAttributeOptionalInt(iNode, "geocode", 0);
                RetVal.Comment = Helper.GetAttributeOptionalString(iNode, "comment");
                string lNewGeocode = Helper.GetAttributeOptionalString(iNode, "newgeocode");
                foreach (string lSubString in lNewGeocode.Split(new Char[] { ',' }))
                {
                    if (!string.IsNullOrEmpty(lSubString))
                    {
                        RetVal.NewGeocode.Add(Convert.ToInt32(lSubString));
                    }
                }
                string s = Helper.GetAttributeOptionalString(iNode, "type");
                if (!String.IsNullOrEmpty(s))
                {
                    RetVal.Type = (EntityType)Enum.Parse(typeof(EntityType), s);
                }
                string lGeocodeParent = Helper.GetAttributeOptionalString(iNode, "parent");
                foreach (string lSubString in lGeocodeParent.Split(new Char[] { ',' }))
                {
                    if (!string.IsNullOrEmpty(lSubString))
                    {
                        RetVal.GeocodeParent.Add(Convert.ToInt32(lSubString));
                    }
                }
                if (iNode.HasChildNodes)
                {
                    foreach (XmlNode lChildNode in iNode.ChildNodes)
                    {
                        if (lChildNode.Name == "office")
                        {
                            EntityOffice lOffice = EntityOffice.Load(lChildNode);
                            RetVal.Offices.Add(lOffice);
                        }
                        if (lChildNode.Name == "history")
                        {
                            RetVal.ParseHistory(lChildNode);
                        }
                        if (lChildNode.Name == "entity")
                        {
                            RetVal.SubEntities.Add(PopulationDataEntry.Load(lChildNode));
                        }
                    }
                }
            }
            return RetVal;

        }

        private void ParseHistory(XmlNode iNode)
        {
            if (iNode != null && iNode.Name.Equals("history"))
            {
                if (iNode.HasChildNodes)
                {
                    foreach (XmlNode lChildNode in iNode.ChildNodes)
                    {
                        if (lChildNode.Name == "misspelling")
                        {
                            OldNames.Add(Helper.GetAttribute(lChildNode, "name").Trim());
                        }
                        if (lChildNode.Name == "rename")
                        {
                            OldNames.Add(Helper.GetAttribute(lChildNode, "oldname").Trim());
                        }
                    }
                }
            }
        }
        protected void CopyStaticDataFrom(PopulationDataEntry iValue)
        {
            Geocode = iValue.Geocode;
            if (!String.IsNullOrEmpty(iValue.English))
            {
                English = iValue.English;
            }
            foreach (Int32 i in iValue.GeocodeParent)
            {
                GeocodeParent.Add(i);
            }
            if (Helper.IsCompatibleEntityType(Type, EntityType.Tambon))
            {
                var lVillageList = new List<EntityType>() { EntityType.Muban };
                if ((iValue.NrOfEntities(lVillageList) > 0) &
                    (this.NrOfEntities(lVillageList) == 0))
                {
                    foreach (PopulationDataEntry lVillage in iValue.SubEntities)
                    {
                        if (Helper.IsCompatibleEntityType(lVillage.Type, EntityType.Muban))
                        {
                            this.SubEntities.Add((PopulationDataEntry)lVillage.Clone());
                        }
                    }
                }
            }
        }
        internal void GetCodes(PopulationDataEntry iValue)
        {
            List<PopulationDataEntry> lMissedEntities = new List<PopulationDataEntry>();
            if (iValue != null)
            {
                if (((Name == iValue.Name) | (iValue.OldNames.Contains(Name))) & (Helper.IsCompatibleEntityType(Type, iValue.Type)))
                {
                    CopyStaticDataFrom(iValue);
                }
                foreach (PopulationDataEntry lSubEntity in SubEntities)
                {
                    PopulationDataEntry lSourceEntity = null;
                    if (lSubEntity.Type == EntityType.Muban)
                    {
                        lSourceEntity = iValue.FindByCode(lSubEntity.Geocode);
                    }
                    else
                    {
                        lSourceEntity = iValue.FindByNameAndType(lSubEntity.Name, lSubEntity.Type, false);
                        if (lSourceEntity == null)
                        {
                            lSourceEntity = iValue.FindByNameAndType(lSubEntity.Name, lSubEntity.Type, true);
                        }
                    }
                    if (lSourceEntity != null)
                    {
                        lSubEntity.GetCodes(lSourceEntity);
                    }
                    else
                    {
                    }
                    if (Helper.Thesaban.Contains(lSubEntity.Type) | (Helper.Sakha.Contains(lSubEntity.Type)))
                    {
                        foreach (Int32 lCode in lSubEntity.GeocodeParent)
                        {
                            PopulationDataEntry lValue = iValue.FindByCode(lCode);
                            if (lValue != null)
                            {
                                lSubEntity.GetCodes(lValue);
                                PopulationDataEntry lSourceValue = this.FindByCode(lCode);
                                if (lSourceValue == null)
                                {
                                    PopulationDataEntry lNewEntry = (PopulationDataEntry)lValue.Clone();
                                    lNewEntry.SubEntities.Clear();
                                    lMissedEntities.Add(lNewEntry);
                                }
                            }
                        }
                    }
                }
            }
            foreach (PopulationDataEntry lNewEntry in lMissedEntities)
            {
                PopulationDataEntry lParent = this.FindByCode(lNewEntry.Geocode / 100);
                if (lParent != null)
                {
                    lParent.SubEntities.Add(lNewEntry);
                }
                lParent.SortSubEntities();
            }
        }

        private PopulationDataEntry FindByNameAndType(String iValue, EntityType iEntityType, Boolean iAllowOldNames)
        {
            PopulationDataEntry retval = null;
            foreach (PopulationDataEntry lEntity in SubEntities)
            {
                if ((lEntity.Name == iValue) & (Helper.IsCompatibleEntityType(lEntity.Type, iEntityType)))
                {
                    retval = lEntity;
                }
                if (iAllowOldNames & (lEntity.OldNames.Contains(iValue)) & (Helper.IsCompatibleEntityType(lEntity.Type, iEntityType)))
                {
                    retval = lEntity;
                }
            }
            return retval;
        }
        private PopulationDataEntry FindByName(string iValue)
        {
            PopulationDataEntry retval = null;
            foreach (PopulationDataEntry lEntity in SubEntities)
            {
                if (lEntity.Name == iValue)
                {
                    retval = lEntity;
                }
            }
            return retval;
        }
        internal PopulationDataEntry FindByCode(Int32 iCode)
        {
            PopulationDataEntry retval = null;
            if (this.Geocode == iCode)
            {
                retval = this;
            }
            else
            {
                foreach (PopulationDataEntry lEntity in SubEntities)
                {
                    retval = lEntity.FindByCode(iCode);
                    if (retval != null)
                        break;
                }
            }
            return retval;
        }
        private PopulationDataEntry FindByCodeAndType(Int32 iCode, EntityType iEntityType)
        {
            PopulationDataEntry retval = null;
            if ((this.Geocode == iCode) & (this.Type == iEntityType))
            {
                retval = this;
            }
            else
            {
                foreach (PopulationDataEntry entry in this.SubEntities)
                {
                    retval = entry.FindByCodeAndType(iCode, iEntityType);
                    if (retval != null)
                        break;
                }
            }
            return retval;
        }

        internal void AddTambonInThesabanToAmphoe(PopulationDataEntry iTambon, PopulationDataEntry iThesaban)
        {
            PopulationDataEntry lMainTambon = FindByCodeAndType(iTambon.Geocode, EntityType.Tambon);
            PopulationDataEntry lMainAmphoe = FindByCode(iTambon.Geocode / 100);
            if (lMainTambon == null)
            {
                if (lMainAmphoe != null)
                {
                    lMainTambon = (PopulationDataEntry)iTambon.Clone();
                    lMainAmphoe.SubEntities.Add(lMainTambon);
                }
            }
            else
            {
                lMainTambon.Total = lMainTambon.Total + iTambon.Total;
                lMainTambon.Male = lMainTambon.Male + iTambon.Male;
                lMainTambon.Female = lMainTambon.Female + iTambon.Female;
                lMainTambon.Households = lMainTambon.Households + iTambon.Households;

            }
            if (lMainAmphoe != null)
            {
                lMainAmphoe.Total = lMainAmphoe.Total + iTambon.Total;
                lMainAmphoe.Male = lMainAmphoe.Male + iTambon.Male;
                lMainAmphoe.Female = lMainAmphoe.Female + iTambon.Female;
                lMainAmphoe.Households = lMainAmphoe.Households + iTambon.Households;
            }
            if (lMainTambon != null)
            {
                PopulationDataEntry lNewEntity = new PopulationDataEntry()
                {
                    Geocode = iThesaban.Geocode,
                    Name = iThesaban.Name,
                    English = iThesaban.English,
                    Type = iThesaban.Type,
                    Total = iTambon.Total,
                    Male = iTambon.Male,
                    Female = iTambon.Female,
                    Households = iTambon.Households
                };
                lMainTambon.SubEntities.Add(lNewEntity);
            }
        }
        internal Boolean IsObsolete()
        {
            Boolean retval = (Obsolete) | (NewGeocode.Count > 0);
            return retval;
        }

        public Int32 NrOfEntities(List<EntityType> iRequestedType)
        {
            Int32 retval = 0;
            foreach (PopulationDataEntry lEntity in SubEntities)
            {
                if ((iRequestedType.Contains(lEntity.Type)) & (!lEntity.IsObsolete()))
                {
                    retval++;
                }
                retval = retval + lEntity.NrOfEntities(iRequestedType);
            }
            return retval;
        }
        public string WriteForWikipedia(String iPopulationReference)
        {
            Int32 lVillageNumberTotal = NrOfEntities(new List<EntityType>() { EntityType.Muban });
            Boolean lShowVillages = (lVillageNumberTotal > 0) & (Helper.IsCompatibleEntityType(this.Type, EntityType.Amphoe));
            StringWriter lWriter = new StringWriter();
            lWriter.WriteLine("{|");

            lWriter.WriteLine("! No.");
            lWriter.WriteLine("! Name");
            lWriter.WriteLine("! Thai");
            if (lShowVillages)
            {
                lWriter.WriteLine("! Villages");
            }
            lWriter.WriteLine("! [[Population|Inh.]]" + iPopulationReference);
            Int32 lMaxGeocode = 0;
            Int32 lMaxVillageCount = 0;
            Int32 lMaxPopulation = 0;
            foreach (PopulationDataEntry lEntity in this.SubEntities)
            {
                lMaxGeocode = Math.Max(lMaxGeocode, lEntity.Geocode % 100);
                lMaxPopulation = Math.Max(lMaxPopulation, lEntity.Total);
                lMaxVillageCount = Math.Max(lMaxVillageCount, lEntity.NrOfEntities(new List<EntityType>() { EntityType.Muban }));
            }
            foreach (PopulationDataEntry lEntity in this.SubEntities)
            {
                lWriter.WriteLine("|-");
                Int32 lGeocode = lEntity.Geocode % 100;
                lWriter.Write("||");
                String lGeocodeString = lGeocode.ToString() + ".";
                if ((lGeocode < 10) & (lMaxGeocode >= 10))
                {
                    lGeocodeString = "{{0}}" + lGeocodeString;
                }
                lWriter.Write(lGeocodeString);
                lWriter.Write("||");
                lWriter.Write(lEntity.English);
                lWriter.Write("||");
                lWriter.Write(lEntity.Name);
                lWriter.Write("||");
                if (lShowVillages)
                {
                    Int32 lVillageCount = lEntity.NrOfEntities(new List<EntityType>() { EntityType.Muban });
                    if (lVillageCount == 0)
                    {
                        lWriter.Write("-");
                    }
                    else
                    {
                        String lVillages = lVillageCount.ToString();
                        if (lVillageCount < 10)
                        {
                            lVillages = "{{0}}" + lVillages;
                        }
                        lWriter.Write(lVillages);
                    }
                    lWriter.Write("||");
                }
                String lPopulation = lEntity.Total.ToString("###,##0", Helper.CultureInfoUS);
                for (int i = lPopulation.Length; i < lMaxPopulation.ToString("###,##0").Length; i++)
                {
                    lPopulation = "{{0}}" + lPopulation;
                }
                lWriter.Write(lPopulation);
                lWriter.WriteLine();
            }
            lWriter.WriteLine("|}");

            return lWriter.ToString();
        }
        public string SubNames(List<EntityType> iRequestedType)
        {
            var lSubNamesList = SubNamesList(iRequestedType);
            string retval = "";
            foreach (string s in lSubNamesList)
            {
                retval = retval + s + ", ";
            }
            if (!string.IsNullOrEmpty(retval))
            {
                retval = retval.Remove(retval.Length - 2);
            }
            return retval;
        }
        public void SortSubEntities()
        {
            SubEntities.Sort(delegate(PopulationDataEntry p1, PopulationDataEntry p2) { return p1.Geocode.CompareTo(p2.Geocode); });
        }
        internal void IterateEntitiesWithoutGeocode(PopulationDataEntryEvent iCallback)
        {
            if (this.Geocode == 0)
            {
                iCallback(this);
            }
            foreach (PopulationDataEntry lSubEntity in SubEntities)
            {
                lSubEntity.IterateEntitiesWithoutGeocode(iCallback);
            }
        }

        protected List<string> SubNamesList(List<EntityType> iRequestedType)
        {
            List<string> RetVal = new List<string>();
            foreach (PopulationDataEntry subelement in this.SubEntities)
            {
                if (iRequestedType.Contains(subelement.Type))
                {
                    if (!RetVal.Contains(subelement.English))
                    {
                        RetVal.Add(subelement.English);
                    }
                }
                var lSubNamesList = subelement.SubNamesList(iRequestedType);
                foreach (string s in lSubNamesList)
                {
                    if (!RetVal.Contains(s))
                    {
                        RetVal.Add(s);
                    }
                }
            }
            RetVal.Sort();
            return RetVal;
        }

        internal List<PopulationDataEntry> FlatList(List<EntityType> iEntityTypeFilter)
        {
            var RetVal = new List<PopulationDataEntry>();

            foreach (PopulationDataEntry lEntry in SubEntities)
            {
                if (iEntityTypeFilter.Contains(lEntry.Type))
                {
                    RetVal.Add(lEntry);
                }
                RetVal.AddRange(lEntry.FlatList(iEntityTypeFilter));
            }
            return RetVal;
        }

        public Boolean LeaderAlreadyInList(EntityLeader iLeader)
        {
            Boolean RetVal = false;
            foreach (EntityOffice lOffice in Offices)
            {
                if (lOffice.OfficialsList != null)
                {
                    foreach (EntityLeader lLeader in lOffice.OfficialsList)
                    {
                        RetVal = RetVal | ((lLeader.Name == iLeader.Name) && (lLeader.Position == iLeader.Position));
                    }
                }
            }
            return RetVal;
        }

        internal void ExportToKml(String iFilename)
        {
            KmlHelper lKmlWriter = new KmlHelper();
            EntityOffice.AddKmlStyles(lKmlWriter);
            WriteToKml(lKmlWriter, lKmlWriter.DocumentNode);
            lKmlWriter.SaveToFile(iFilename);
        }

        private void WriteToKml(KmlHelper lKmlWriter, XmlNode iNode)
        {
            XmlNode lNode = iNode;
            String lDescription = "Geocode: " + Geocode.ToString();
            if ((Type == EntityType.Changwat) | (Type == EntityType.Bangkok))
            {
                lNode = lKmlWriter.AddFolder(lNode, English, false);
            }
            String lName = English;
            if (Type == EntityType.Muban)
            {
                lName = "Mu " + (Geocode % 100).ToString();
                if (!String.IsNullOrEmpty(English))
                {
                    lName = lName + ' ' + English;
                }
            }
            foreach (EntityOffice lOffice in Offices)
            {
                lOffice.AddToKml(lKmlWriter, lNode, lName, lDescription);
            }
            foreach (PopulationDataEntry lEntity in SubEntities)
            {
                lEntity.WriteToKml(lKmlWriter, lNode);
            }
        }
        #endregion

        #region ICloneable Members

        public object Clone()
        {
            return new PopulationDataEntry(this);
        }

        #endregion

        #region IGeocode Members

        public bool IsAboutGeocode(int iGeocode, bool iIncludeSubEntities)
        {
            Boolean retval = Helper.IsSameGeocode(iGeocode, Geocode, iIncludeSubEntities);
            return retval;
        }

        #endregion
    }
}