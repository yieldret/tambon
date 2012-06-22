// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.3.27461
//    <NameSpace>De.AHoerstemeier.Tambon</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>True</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>False</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>True</GenerateDataContracts><CodeBaseTag>Net40</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>True</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace De.AHoerstemeier.Tambon
{
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.Runtime.Serialization;


    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://hoerstemeier.com/tambon/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://hoerstemeier.com/tambon/", IsNullable = true)]
    [System.Runtime.Serialization.DataContractAttribute(Name = "EntityBase", Namespace = "http://hoerstemeier.com/tambon/", IsReference = true)]
    public partial class EntityBase
    {

        private EntityType typeField;

        private string nameField;

        private string englishField;

        private uint geocodeField;

        private string commentField;

        /// <summary>
        /// Creates a new instance of EntityBase.
        /// </summary>
        public EntityBase()
        {
            this.typeField = EntityType.Unknown;
            this.geocodeField = ((uint)(0));
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(EntityType.Unknown)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public EntityType type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string english
        {
            get
            {
                return this.englishField;
            }
            set
            {
                this.englishField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(uint), "0")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public uint geocode
        {
            get
            {
                return this.geocodeField;
            }
            set
            {
                this.geocodeField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string comment
        {
            get
            {
                return this.commentField;
            }
            set
            {
                this.commentField = value;
            }
        }
    }

    /// <summary>
    /// Types of administrative entities.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://hoerstemeier.com/tambon/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://hoerstemeier.com/tambon/", IsNullable = false)]
    public enum EntityType
    {

        /// <summary>
        /// Province (จังหวัด, changwat).
        /// </summary>
        Changwat,

        /// <summary>
        /// Special administrative unit of Krung Thep (องค์กรปกครองส่วนท้องถิ่นรูปแบบพิเศษกรุงเทพมหานคร).
        /// </summary>
        Bangkok,

        /// <summary>
        /// District (อำเภอ, amphoe), subdivision of provinces.
        /// </summary>
        Amphoe,

        /// <summary>
        /// Minor district (กิ่งอำเภอ, King Amphoe), subdivision of provinces.
        /// </summary>
        KingAmphoe,

        /// <summary>
        /// Subdistrict (ตำบล, tambon), subdivision of districts.
        /// </summary>
        Tambon,

        /// <summary>
        /// Districts of Bangkok (เขต, khet).
        /// </summary>
        Khet,

        /// <summary>
        /// Subdistrict of Bangkok (แขวง, Khwaeng).
        /// </summary>
        Khwaeng,

        /// <summary>
        /// Administrative village (หมู่บ้าน, Muban), subdivision of subdistricts.
        /// </summary>
        Muban,

        /// <summary>
        /// Special administrative municipality (i.e. Pattaya)
        /// </summary>
        Mueang,

        /// <summary>
        /// Circles (มณฑล or มณฑลเทศาภิบาล, monthon)
        /// </summary>
        Monthon,

        /// <summary>
        /// Region (ภาค, phak)
        /// </summary>
        Phak,

        /// <summary>
        /// Subdistrict administrative organization (องค์การบริหารส่วนตำบล, อบต TAO or SAO).
        /// </summary>
        TAO,

        /// <summary>
        /// Subdistrict Council (สภาตำบล, Sapha Tambon)
        /// </summary>
        SaphaTambon,

        /// <summary>
        /// Subdistrict municipality (เทศบาลตำบล, Thesaban Tambon).
        /// </summary>
        ThesabanTambon,

        /// <summary>
        /// Town municipality (เทศบาลเมือง, Thesaban Mueang)
        /// </summary>
        ThesabanMueang,

        /// <summary>
        /// City municipality (เทศบาลนคร, Thesaban Nakhon)
        /// </summary>
        ThesabanNakhon,

        /// <summary>
        /// Sanitary district (สุขาภิบาล, Sukhaphiban).
        /// </summary>
        Sukhaphiban,

        /// <summary>
        /// Rural sanitary district (สุขาภิบาลตำบล, Sukhaphiban Tambon).
        /// </summary>
        SukhaphibanTambon,

        /// <summary>
        /// Urban sanitary district (สุขาภิบาลเมือง, Sukhaphiban Mueang).
        /// </summary>
        SukhaphibanMueang,

        /// <summary>
        /// Borough (ชุมชน, chumchon), subdivision of municipalities.
        /// </summary>
        Chumchon,

        /// <summary>
        /// Provincial administrative organization (องค์การบริหารส่วนจังหวัด, อบจ).
        /// </summary>
        PAO,

        /// <summary>
        /// Province cluster (กลุ่มจังหวัด, Klum Changwat)
        /// </summary>
        KlumChangwat,

        /// <summary>
        /// Constituency (เขตเลือกตั้ง, Khet Lueak Tang), either for local or general elections.
        /// </summary>
        Constituency,

        /// <summary>
        /// Electoral region as defined in the 2007 constitution.
        /// </summary>
        ElectoralRegion,

        /// <summary>
        /// Whole of Thailand (ประเทศไทย).
        /// </summary>
        Country,

        /// <summary>
        /// Generic entry for other types.
        /// </summary>
        Unknown,

        /// <summary>
        /// Branch subdistrict (สาขาตำบล, Sakha Tambon)
        /// </summary>
        SakhaTambon,

        /// <summary>
        /// Branch subdistrict (สาขาแขวง, Sakha Khwaeng)
        /// </summary>
        SakhaKhwaeng,

        /// <summary>
        /// Municipality of undefined type (เทศบาล, Thesaban).
        /// </summary>
        Thesaban,

        /// <summary>
        /// Branch of undefined type (สาขา, Sakha).
        /// </summary>
        Sakha,
    }

    /// <summary>
    /// URL with an optional comment and status.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://hoerstemeier.com/tambon/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://hoerstemeier.com/tambon/", IsNullable = true)]
    [System.Runtime.Serialization.DataContractAttribute(Name = "MyUri", Namespace = "http://hoerstemeier.com/tambon/", IsReference = true)]
    public partial class MyUri
    {

        private string commentField;

        private MyUriStatus statusField;

        private System.DateTime lastcheckedField;

        private bool lastcheckedFieldSpecified;

        private string valueField;

        /// <summary>
        /// Creates a new instance of MyUri.
        /// </summary>
        public MyUri()
        {
            this.statusField = MyUriStatus.unknown;
        }

        /// <summary>
        /// Auto generated comment tag to suppress XML code documentation warning.
        /// </summary>
        /// <value>
        /// Auto generated value tag to suppress XML code documentation warning.
        /// </value>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string comment
        {
            get
            {
                return this.commentField;
            }
            set
            {
                this.commentField = value;
            }
        }

        /// <summary>
        /// Auto generated comment tag to suppress XML code documentation warning.
        /// </summary>
        /// <value>
        /// Auto generated value tag to suppress XML code documentation warning.
        /// </value>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(MyUriStatus.unknown)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MyUriStatus status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }

        /// <summary>
        /// Auto generated comment tag to suppress XML code documentation warning.
        /// </summary>
        /// <value>
        /// Auto generated value tag to suppress XML code documentation warning.
        /// </value>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime lastchecked
        {
            get
            {
                return this.lastcheckedField;
            }
            set
            {
                this.lastcheckedField = value;
            }
        }

        /// <summary>
        /// Auto generated comment tag to suppress XML code documentation warning.
        /// </summary>
        /// <value>
        /// Auto generated value tag to suppress XML code documentation warning.
        /// </value>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool lastcheckedSpecified
        {
            get
            {
                return this.lastcheckedFieldSpecified;
            }
            set
            {
                this.lastcheckedFieldSpecified = value;
            }
        }

        /// <summary>
        /// Auto generated comment tag to suppress XML code documentation warning.
        /// </summary>
        /// <value>
        /// Auto generated value tag to suppress XML code documentation warning.
        /// </value>
        [System.Xml.Serialization.XmlTextAttribute(DataType = "anyURI")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <summary>
    /// Status of a web link.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://hoerstemeier.com/tambon/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://hoerstemeier.com/tambon/", IsNullable = false)]
    public enum MyUriStatus
    {

        /// <summary>
        /// Status unknown.
        /// </summary>
        unknown,

        /// <summary>
        /// Website up and running.
        /// </summary>
        online,

        /// <summary>
        /// Website unreachable due to server problems.
        /// </summary>
        offline,

        /// <summary>
        /// Discontinued but still online website.
        /// </summary>
        obsolete,

        /// <summary>
        /// Domain registration has expired.
        /// </summary>
        expired,

        /// <summary>
        /// Server alive, but returns no valid webpage, e.g. 404.
        /// </summary>
        broken,

        /// <summary>
        /// Defaced or spreading malware and blocked by Google safe browsing.
        /// </summary>
        hacked,
    }

    /// <summary>
    /// Types of leaders or deputy leaders for the administrative entities.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://hoerstemeier.com/tambon/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://hoerstemeier.com/tambon/", IsNullable = false)]
    public enum OfficialType
    {

        /// <summary>
        /// Province governor (ผู้ว่าราชการจังหวัด, Phu Wa Rachakan Changwat, earlier also ข้าหลวงประจำจังหวัด Kha Luang Pracham Changwat and ผู้ว่าราชการเมือง Phu Wa Rachakan Mueng).
        /// </summary>
        Governor,

        /// <summary>
        /// Governor of Bangkok (ผู้ว่าราชการกรุงเทพมหานคร, Phu Wa Rachakan Krung Thep Maha Nakhon).
        /// </summary>
        BangkokGovernor,

        /// <summary>
        /// Vice province governor (รองผู้ว่าราชการจังหวัด, Rong Phu Wachakan Changwat).
        /// </summary>
        ViceGovernor,

        /// <summary>
        /// Deputy province governor (ปลัดจังหวัด , Palat Changwat).
        /// </summary>
        DeputyGovernor,

        /// <summary>
        /// District (head) officer (นายอำเภอ, Nai Amphoe).
        /// </summary>
        DistrictOfficer,

        /// <summary>
        /// Minor District (head) officer (หัวหน้ากิ่งอำเภอ, Hua Na King Amphoe).
        /// </summary>
        MinorDistrictOfficer,

        /// <summary>
        /// Assistant distict officer (ปลัดอำเภอ , Palat Amphoe).
        /// </summary>
        AssistantDistrictOfficer,

        /// <summary>
        /// District officer in Bangkok (ผู้อำนวยการเขต, Phu Amnuai Kan Khet).
        /// </summary>
        DistrictOfficerBangkok,

        /// <summary>
        /// Deputy district officer in Bangkok (ผู้ช่วยผู้อำนวยการเขต, Phu Chuai Amnuai Kan Khet).
        /// </summary>
        DeputyDistrictOfficerBangkok,

        /// <summary>
        /// Subdistrict headman (กำนัน, Kamnan), leader of Tambon.
        /// </summary>
        Kamnan,

        /// <summary>
        /// Village headman (ผู้ใหญ่บ้าน [ผญบ], Phu Yai Ban), leader of Muban.
        /// </summary>
        PhuYaiBan,

        /// <summary>
        /// Chief Executive of PAO (นายกองค์การบริหารส่วนจังหวัด, Nayok Ongkanborihansuan Changwat), directly elected.
        /// </summary>
        PAOChairman,

        /// <summary>
        /// Mayor (นายกเทศมนตรี, Nayok Thesamontri), leader of Thesaban.
        /// </summary>
        Mayor,

        /// <summary>
        /// Deputy Mayor (รองนายกเทศมนตรี, Rong Nayok Thesamontri).
        /// </summary>
        DeputyMayor,

        /// <summary>
        /// Chairman of the municipal council (ประธานสภาเทศบาล, Prathan Sapha Thesaban).
        /// </summary>
        MunicipalityCouncilChairman,

        /// <summary>
        /// Municipal clerk (ปลัดเทศบาล, Palat Thesaban).
        /// </summary>
        MunicipalClerk,

        /// <summary>
        /// TAO clerk (ปลัดองค์การบริหารส่วนตำบล, Palat O.Bo.To.).
        /// </summary>
        TAOClerk,

        /// <summary>
        /// PAO clerk (ปลัดองค์การบริหารส่วนจังหวัด, Palat O.Bo.Cho.).
        /// </summary>
        PAOClerk,

        /// <summary>
        /// Mayor of TAO (นายกองค์การบริหารส่วนตำบล, Nayok Ongkanborihansuan Tambon), directly elected.
        /// </summary>
        TAOMayor,

        /// <summary>
        /// Chairman of TAO (ประธานกรรมการบริหารองค์การบริหารส่วนตำบล, Prathan Kromkanborihan Ongkanborihansuan Tambon), chosen by council.
        /// </summary>
        TAOChairman,

        /// <summary>
        /// Chairman of the TAO council (ประธานสภาองค์การบริหารส่วนตำบล, Prathan Sapha Ongkanborihansuan Tambon).
        /// </summary>
        TAOCouncilChairman,

        /// <summary>
        /// Chairman of the Tambon Council (ประธานสภาตำบล, Prathan Sapha Tambon).
        /// </summary>
        TambonCouncilChairman,

        /// <summary>
        /// Chairman of the PAO Council (ประธานสภาองค์การบริหารส่วนจังหวัด, Prathan Sapha Ongkanborihansuan Changwat).
        /// </summary>
        PAOCouncilChairman,

        /// <summary>
        /// Sanitary district chairman (ประธานกรรมการสุขาภิบาล, Prathan Kromkan Sukhaphiban).
        /// </summary>
        SanitaryDistrictChairman,

        /// <summary>
        /// Borough headman (ประธานชุมชน, Prathan Chumchon).
        /// </summary>
        ChumchonChairman,

        /// <summary>
        /// Monthon commissioner (ข้าหลวงเทศาภิบาล, Kha Luang Thesaphiban).
        /// </summary>
        MonthonCommissioner,

        /// <summary>
        /// Monthon clerk (ปลัดมณฑล, Palat Monthon).
        /// </summary>
        MonthonClerk,

        /// <summary>
        /// Governor of Mueang (เจ้าเมือง, Chao Mueang).
        /// </summary>
        MueangGovernor,
    }
}