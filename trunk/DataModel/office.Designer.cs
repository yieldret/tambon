// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.38967
//    <NameSpace>De.AHoerstemeier.Tambon</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>True</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>False</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>True</GenerateDataContracts><CodeBaseTag>Net40</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>True</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace De.AHoerstemeier.Tambon {
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://hoerstemeier.com/tambon/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://hoerstemeier.com/tambon/", IsNullable=true)]
    [System.Runtime.Serialization.DataContractAttribute(Name="OfficialEntry", Namespace="http://hoerstemeier.com/tambon/")]
    public partial class OfficialEntry {
        
        private OfficialType titleField;
        
        private int indexField;
        
        private bool indexFieldSpecified;
        
        private string nameField;
        
        private string englishField;
        
        private System.DateTime beginField;
        
        private bool beginFieldSpecified;
        
        private string endyearField;
        
        private string beginyearField;
        
        private System.DateTime endField;
        
        private bool endFieldSpecified;
        
        private bool actingField;
        
        private bool actingFieldSpecified;
        
        private string inofficeField;
        
        private string commentField;
        
        private OfficialEndType endreasonField;
        
        public OfficialEntry() {
            this.endreasonField = OfficialEndType.Unknown;
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public OfficialType title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int index {
            get {
                return this.indexField;
            }
            set {
                this.indexField = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool indexSpecified {
            get {
                return this.indexFieldSpecified;
            }
            set {
                this.indexFieldSpecified = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string english {
            get {
                return this.englishField;
            }
            set {
                this.englishField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="date")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime begin {
            get {
                return this.beginField;
            }
            set {
                this.beginField = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool beginSpecified {
            get {
                return this.beginFieldSpecified;
            }
            set {
                this.beginFieldSpecified = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="gYear")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string endyear {
            get {
                return this.endyearField;
            }
            set {
                this.endyearField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="gYear")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string beginyear {
            get {
                return this.beginyearField;
            }
            set {
                this.beginyearField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="date")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime end {
            get {
                return this.endField;
            }
            set {
                this.endField = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool endSpecified {
            get {
                return this.endFieldSpecified;
            }
            set {
                this.endFieldSpecified = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool acting {
            get {
                return this.actingField;
            }
            set {
                this.actingField = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool actingSpecified {
            get {
                return this.actingFieldSpecified;
            }
            set {
                this.actingFieldSpecified = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="gYear")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string inoffice {
            get {
                return this.inofficeField;
            }
            set {
                this.inofficeField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string comment {
            get {
                return this.commentField;
            }
            set {
                this.commentField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(OfficialEndType.Unknown)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public OfficialEndType endreason {
            get {
                return this.endreasonField;
            }
            set {
                this.endreasonField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://hoerstemeier.com/tambon/")]
    public enum OfficialType {
        
        /// <remarks/>
        Governor,
        
        /// <remarks/>
        BangkokGovernor,
        
        /// <remarks/>
        ViceGovernor,
        
        /// <remarks/>
        DeputyGovernor,
        
        /// <remarks/>
        DistrictOfficer,
        
        /// <remarks/>
        MinorDistrictOfficer,
        
        /// <remarks/>
        AssistantDistrictOfficer,
        
        /// <remarks/>
        DistrictOfficerBangkok,
        
        /// <remarks/>
        DeputyDistrictOfficerBangkok,
        
        /// <remarks/>
        Kamnan,
        
        /// <remarks/>
        PhuYaiBan,
        
        /// <remarks/>
        PAOChairman,
        
        /// <remarks/>
        Mayor,
        
        /// <remarks/>
        DeputyMayor,
        
        /// <remarks/>
        MunicipalClerk,
        
        /// <remarks/>
        TAOMayor,
        
        /// <remarks/>
        TAOChairman,
        
        /// <remarks/>
        TAOCouncilChairman,
        
        /// <remarks/>
        SanitaryDistrictChairman,
        
        /// <remarks/>
        ChumchonChairman,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://hoerstemeier.com/tambon/")]
    public enum OfficialEndType {
        
        /// <remarks/>
        EndOfTerm,
        
        /// <remarks/>
        Transfer,
        
        /// <remarks/>
        Retired,
        
        /// <remarks/>
        Resigned,
        
        /// <remarks/>
        Death,
        
        /// <remarks/>
        Removed,
        
        /// <remarks/>
        Unknown,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://hoerstemeier.com/tambon/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://hoerstemeier.com/tambon/", IsNullable=true)]
    [System.Runtime.Serialization.DataContractAttribute(Name="OfficialList", Namespace="http://hoerstemeier.com/tambon/")]
    public partial class OfficialList {
        
        private List<OfficialEntry> officialField;
        
        private string sourceField;
        
        /// <summary>
        /// OfficialList class constructor
        /// </summary>
        public OfficialList() {
            this.officialField = new List<OfficialEntry>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("official", Order=0)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<OfficialEntry> official {
            get {
                return this.officialField;
            }
            set {
                this.officialField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string source {
            get {
                return this.sourceField;
            }
            set {
                this.sourceField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://hoerstemeier.com/tambon/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://hoerstemeier.com/tambon/", IsNullable=true)]
    [System.Runtime.Serialization.DataContractAttribute(Name="MyUri", Namespace="http://hoerstemeier.com/tambon/")]
    public partial class MyUri {
        
        private string commentField;
        
        private MyUriStatus statusField;
        
        private string valueField;
        
        public MyUri() {
            this.statusField = MyUriStatus.unknown;
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string comment {
            get {
                return this.commentField;
            }
            set {
                this.commentField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(MyUriStatus.unknown)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MyUriStatus status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }
        
        [System.Xml.Serialization.XmlTextAttribute(DataType="anyURI")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://hoerstemeier.com/tambon/")]
    public enum MyUriStatus {
        
        /// <remarks/>
        unknown,
        
        /// <remarks/>
        online,
        
        /// <remarks/>
        offline,
        
        /// <remarks/>
        obsolete,
        
        /// <remarks/>
        expired,
        
        /// <remarks/>
        broken,
        
        /// <remarks/>
        hacked,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://hoerstemeier.com/tambon/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://hoerstemeier.com/tambon/", IsNullable=true)]
    [System.Runtime.Serialization.DataContractAttribute(Name="ThaiAddressVillage", Namespace="http://hoerstemeier.com/tambon/")]
    public partial class ThaiAddressVillage {
        
        private string nameField;
        
        private uint numberField;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public uint number {
            get {
                return this.numberField;
            }
            set {
                this.numberField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://hoerstemeier.com/tambon/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://hoerstemeier.com/tambon/", IsNullable=true)]
    [System.Runtime.Serialization.DataContractAttribute(Name="ThaiAddressTambon", Namespace="http://hoerstemeier.com/tambon/")]
    public partial class ThaiAddressTambon {
        
        private string nameField;
        
        private uint geocodeField;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public uint geocode {
            get {
                return this.geocodeField;
            }
            set {
                this.geocodeField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://hoerstemeier.com/tambon/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://hoerstemeier.com/tambon/", IsNullable=true)]
    [System.Runtime.Serialization.DataContractAttribute(Name="ThaiAddress", Namespace="http://hoerstemeier.com/tambon/")]
    public partial class ThaiAddress {
        
        private ThaiAddressVillage villageField;
        
        private string plotField;
        
        private ThaiAddressTambon tambonField;
        
        private string streetField;
        
        private uint postcodeField;
        
        private bool postcodeFieldSpecified;
        
        /// <summary>
        /// ThaiAddress class constructor
        /// </summary>
        public ThaiAddress() {
            this.tambonField = new ThaiAddressTambon();
            this.villageField = new ThaiAddressVillage();
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ThaiAddressVillage village {
            get {
                return this.villageField;
            }
            set {
                this.villageField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string plot {
            get {
                return this.plotField;
            }
            set {
                this.plotField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ThaiAddressTambon tambon {
            get {
                return this.tambonField;
            }
            set {
                this.tambonField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string street {
            get {
                return this.streetField;
            }
            set {
                this.streetField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public uint postcode {
            get {
                return this.postcodeField;
            }
            set {
                this.postcodeField = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool postcodeSpecified {
            get {
                return this.postcodeFieldSpecified;
            }
            set {
                this.postcodeFieldSpecified = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://hoerstemeier.com/tambon/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://hoerstemeier.com/tambon/", IsNullable=true)]
    [System.Runtime.Serialization.DataContractAttribute(Name="OldLocation", Namespace="http://hoerstemeier.com/tambon/")]
    public partial class OldLocation {
        
        private Point pointField;
        
        private ThaiAddress addressField;
        
        private System.DateTime endField;
        
        private bool endFieldSpecified;
        
        private string commentField;
        
        /// <summary>
        /// OldLocation class constructor
        /// </summary>
        public OldLocation() {
            this.addressField = new ThaiAddress();
            this.pointField = new Point();
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.w3.org/2003/01/geo/wgs84_pos#", Order=0)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Point Point {
            get {
                return this.pointField;
            }
            set {
                this.pointField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ThaiAddress address {
            get {
                return this.addressField;
            }
            set {
                this.addressField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="date")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime end {
            get {
                return this.endField;
            }
            set {
                this.endField = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool endSpecified {
            get {
                return this.endFieldSpecified;
            }
            set {
                this.endFieldSpecified = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string comment {
            get {
                return this.commentField;
            }
            set {
                this.commentField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://hoerstemeier.com/tambon/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://hoerstemeier.com/tambon/", IsNullable=true)]
    [System.Runtime.Serialization.DataContractAttribute(Name="Office", Namespace="http://hoerstemeier.com/tambon/")]
    public partial class Office {
        
        private string sloganField;
        
        private string visionField;
        
        private Point pointField;
        
        private ThaiAddress addressField;
        
        private List<MyUri> urlField;
        
        private OfficialList officialsField;
        
        private List<OldLocation> oldlocationsField;
        
        private OfficeType typeField;
        
        private bool obsoleteField;
        
        private bool obsoleteFieldSpecified;
        
        private string commentField;
        
        /// <summary>
        /// Office class constructor
        /// </summary>
        public Office() {
            this.oldlocationsField = new List<OldLocation>();
            this.officialsField = new OfficialList();
            this.urlField = new List<MyUri>();
            this.addressField = new ThaiAddress();
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string slogan {
            get {
                return this.sloganField;
            }
            set {
                this.sloganField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string vision {
            get {
                return this.visionField;
            }
            set {
                this.visionField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.w3.org/2003/01/geo/wgs84_pos#", Order=2)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Point Point {
            get {
                return this.pointField;
            }
            set {
                this.pointField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ThaiAddress address {
            get {
                return this.addressField;
            }
            set {
                this.addressField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("url", Order=4)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<MyUri> url {
            get {
                return this.urlField;
            }
            set {
                this.urlField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public OfficialList officials {
            get {
                return this.officialsField;
            }
            set {
                this.officialsField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("oldlocations", Order=6)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<OldLocation> oldlocations {
            get {
                return this.oldlocationsField;
            }
            set {
                this.oldlocationsField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public OfficeType type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool obsolete {
            get {
                return this.obsoleteField;
            }
            set {
                this.obsoleteField = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool obsoleteSpecified {
            get {
                return this.obsoleteFieldSpecified;
            }
            set {
                this.obsoleteFieldSpecified = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string comment {
            get {
                return this.commentField;
            }
            set {
                this.commentField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://hoerstemeier.com/tambon/")]
    public enum OfficeType {
        
        /// <remarks/>
        ProvinceHall,
        
        /// <remarks/>
        PAOOffice,
        
        /// <remarks/>
        DistrictOffice,
        
        /// <remarks/>
        MunicipalityOffice,
        
        /// <remarks/>
        TAOOffice,
        
        /// <remarks/>
        VillageHeadmanOffice,
        
        /// <remarks/>
        ChumchonOffice,
        
        /// <remarks/>
        SubdistrictHeadmanOffice,
    }
}
