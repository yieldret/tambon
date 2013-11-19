// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.3.29394
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
    
    
    /// <summary>
    /// Types of administrative entities.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18058")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://hoerstemeier.com/tambon/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://hoerstemeier.com/tambon/", IsNullable=false)]
    public enum EntityType {
        
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
        /// Special administrative municipality (องค์กรปกครองส่วนท้องถิ่นรูปแบบพิเศษ, i.e. Pattaya)
        /// </summary>
        Mueang,
        
        /// <summary>
        /// Circles (มณฑล or มณฑลเทศาภิบาล, monthon)
        /// </summary>
        Monthon,
        
        /// <summary>
        /// Vice royal area (อุปราชมณทล, Uparat Monthon)
        /// </summary>
        ViceRoyality,
        
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
        /// Borough (ชุมชน, Chumchon), subdivision of municipalities.
        /// </summary>
        Chumchon,
        
        /// <summary>
        /// Provincial administrative organization (องค์การบริหารส่วนจังหวัด, อบจ).
        /// </summary>
        PAO,
        
        /// <summary>
        /// Provincial council (สภาจังหวัด, Sapha Changwat), the precursor of the PAO.
        /// </summary>
        ProvinceCouncil,
        
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
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityIncludeSub))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityInExclude))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityInclude))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConstituencyEntity))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18058")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://hoerstemeier.com/tambon/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://hoerstemeier.com/tambon/", IsNullable=true)]
    [System.Runtime.Serialization.DataContractAttribute(Name="EntityBase", Namespace="http://hoerstemeier.com/tambon/", IsReference=true)]
    public partial class EntityBase {
        
        private EntityType typeField;
        
        private string nameField;
        
        private string englishField;
        
        private uint geocodeField;
        
        private string commentField;
        
        /// <summary>
        /// Creates a new instance of EntityBase.
        /// </summary>
        public EntityBase() {
            this.typeField = EntityType.Unknown;
            this.geocodeField = ((uint)(0));
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(EntityType.Unknown)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public EntityType type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(uint), "0")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public uint geocode {
            get {
                return this.geocodeField;
            }
            set {
                this.geocodeField = value;
            }
        }
        
        /// <summary>
        /// Auto generated comment tag to suppress XML code documentation warning.
        /// </summary>
        /// <value>
        /// Auto generated value tag to suppress XML code documentation warning.
        /// </value>
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
    
    /// <summary>
    /// URL with an optional comment and status.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18058")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://hoerstemeier.com/tambon/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://hoerstemeier.com/tambon/", IsNullable=true)]
    [System.Runtime.Serialization.DataContractAttribute(Name="MyUri", Namespace="http://hoerstemeier.com/tambon/", IsReference=true)]
    public partial class MyUri {
        
        private string commentField;
        
        private MyUriStatus statusField;
        
        private System.DateTime lastcheckedField;
        
        private bool lastcheckedFieldSpecified;
        
        private System.DateTime lastonlineField;
        
        private bool lastonlineFieldSpecified;
        
        private string valueField;
        
        /// <summary>
        /// Creates a new instance of MyUri.
        /// </summary>
        public MyUri() {
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
        public string comment {
            get {
                return this.commentField;
            }
            set {
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
        public MyUriStatus status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }
        
        /// <summary>
        /// Auto generated comment tag to suppress XML code documentation warning.
        /// </summary>
        /// <value>
        /// Auto generated value tag to suppress XML code documentation warning.
        /// </value>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="date")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime lastchecked {
            get {
                return this.lastcheckedField;
            }
            set {
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
        public bool lastcheckedSpecified {
            get {
                return this.lastcheckedFieldSpecified;
            }
            set {
                this.lastcheckedFieldSpecified = value;
            }
        }
        
        /// <summary>
        /// Auto generated comment tag to suppress XML code documentation warning.
        /// </summary>
        /// <value>
        /// Auto generated value tag to suppress XML code documentation warning.
        /// </value>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="date")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime lastonline {
            get {
                return this.lastonlineField;
            }
            set {
                this.lastonlineField = value;
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
        public bool lastonlineSpecified {
            get {
                return this.lastonlineFieldSpecified;
            }
            set {
                this.lastonlineFieldSpecified = value;
            }
        }
        
        /// <summary>
        /// Auto generated comment tag to suppress XML code documentation warning.
        /// </summary>
        /// <value>
        /// Auto generated value tag to suppress XML code documentation warning.
        /// </value>
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
    
    /// <summary>
    /// Status of a web link.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18058")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://hoerstemeier.com/tambon/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://hoerstemeier.com/tambon/", IsNullable=false)]
    public enum MyUriStatus {
        
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
        
        /// <summary>
        /// Website removed from free web hosting service.
        /// </summary>
        removed,
    }
    
    /// <summary>
    /// Reference to a book.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18058")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://hoerstemeier.com/tambon/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://hoerstemeier.com/tambon/", IsNullable=true)]
    [System.Runtime.Serialization.DataContractAttribute(Name="BookReference", Namespace="http://hoerstemeier.com/tambon/", IsReference=true)]
    public partial class BookReference {
        
        private string titleField;
        
        private string authorField;
        
        private string publicationField;
        
        private string isbnField;
        
        /// <summary>
        /// Title of the book.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
            }
        }
        
        /// <summary>
        /// Main author or editor of the book.
        /// </summary>
        /// <value>
        /// The author.
        /// </value>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string author {
            get {
                return this.authorField;
            }
            set {
                this.authorField = value;
            }
        }
        
        /// <summary>
        /// Publication year.
        /// </summary>
        /// <value>
        /// The publication.
        /// </value>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="gYear")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string publication {
            get {
                return this.publicationField;
            }
            set {
                this.publicationField = value;
            }
        }
        
        /// <summary>
        /// ISBN of the book.
        /// </summary>
        /// <value>
        /// The isbn.
        /// </value>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string isbn {
            get {
                return this.isbnField;
            }
            set {
                this.isbnField = value;
            }
        }
    }
    
    /// <summary>
    /// Reference to a ministerial order.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18058")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://hoerstemeier.com/tambon/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://hoerstemeier.com/tambon/", IsNullable=true)]
    [System.Runtime.Serialization.DataContractAttribute(Name="MinisterialOrder", Namespace="http://hoerstemeier.com/tambon/", IsReference=true)]
    public partial class MinisterialOrder {
        
        private Ministry ministryField;
        
        private bool ministryFieldSpecified;
        
        private System.DateTime dateField;
        
        private bool dateFieldSpecified;
        
        private string titleField;
        
        /// <summary>
        /// Ministry which issued the order.
        /// </summary>
        /// <value>
        /// The ministry.
        /// </value>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Ministry ministry {
            get {
                return this.ministryField;
            }
            set {
                this.ministryField = value;
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
        public bool ministrySpecified {
            get {
                return this.ministryFieldSpecified;
            }
            set {
                this.ministryFieldSpecified = value;
            }
        }
        
        /// <summary>
        /// Date the order was issued.
        /// </summary>
        /// <value>
        /// The date.
        /// </value>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="date")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime date {
            get {
                return this.dateField;
            }
            set {
                this.dateField = value;
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
        public bool dateSpecified {
            get {
                return this.dateFieldSpecified;
            }
            set {
                this.dateFieldSpecified = value;
            }
        }
        
        /// <summary>
        /// Title or reference number of the order.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
            }
        }
    }
    
    /// <summary>
    /// Ministries in Thailand.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18058")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://hoerstemeier.com/tambon/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://hoerstemeier.com/tambon/", IsNullable=false)]
    public enum Ministry {
        
        /// <summary>
        /// Ministry of Interior (กระทรวงมหาดไทย, มท).
        /// </summary>
        MOI,
    }
    
    /// <summary>
    /// Types of leaders or deputy leaders for the administrative entities.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18058")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://hoerstemeier.com/tambon/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://hoerstemeier.com/tambon/", IsNullable=false)]
    public enum OfficialType {
        
        /// <summary>
        /// Province governor (ผู้ว่าราชการจังหวัด [ผวจ], Phu Wa Rachakan Changwat, earlier also ข้าหลวงประจำจังหวัด Kha Luang Pracham Changwat and ผู้ว่าราชการเมือง Phu Wa Rachakan Mueng).
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
        /// District (head) officer (นายอำเภอ [นอภ], Nai Amphoe).
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
        /// Chief Executive of PAO (นายกองค์การบริหารส่วนจังหวัด, Nayok Ongkanborihansuan Changwat), since 2004 directly elected.
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
        /// Monthon commissioner (ข้าหลวงเทศาภิบาล, Kha Luang Thesaphiban or สมุหเทศาภิบาล, Samut Thesaphiban).
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
        
        /// <summary>
        /// Chairman of the province council (ประธาน สภาจังหวัด, Prathan Sapha Changwat).
        /// </summary>
        ProvinceCouncilChairman,
        
        /// <summary>
        /// Vice royal (อุปราชมณทล, Uparat Monthon).
        /// </summary>
        ViceRoyal,
        
        /// <summary>
        /// Region governor (ข้าหลวงภาค, Kha Luang Phak or ผู้ว่าราชการภาค, Phu Waratchakan Phak).
        /// </summary>
        RegionGovernor,
        
        /// <summary>
        /// Region vice governor (รองผู้ว่าราชการภาค, Rong Phu Waratchakan Phak).
        /// </summary>
        RegionViceGovernor,
    }
    
    /// <summary>
    /// List of references.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18058")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://hoerstemeier.com/tambon/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://hoerstemeier.com/tambon/", IsNullable=true)]
    [System.Runtime.Serialization.DataContractAttribute(Name="ReferenceList", Namespace="http://hoerstemeier.com/tambon/", IsReference=true)]
    public partial class ReferenceList {
        
        private List<object> itemsField;
        
        /// <summary>
        /// Creates a new instance of ReferenceList.
        /// </summary>
        public ReferenceList() {
            this.itemsField = new List<object>();
        }
        
        /// <summary>
        /// Auto generated comment tag to suppress XML code documentation warning.
        /// </summary>
        /// <value>
        /// Auto generated value tag to suppress XML code documentation warning.
        /// </value>
        [System.Xml.Serialization.XmlElementAttribute("book", typeof(BookReference), Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("gazetteref", typeof(GazetteRelated), Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("meetingreference", typeof(MeetingReference), Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("ministerialorder", typeof(MinisterialOrder), Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("url", typeof(MyUri), Order=0)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<object> Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
    }
    
    /// <summary>
    /// Link to wikidata.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Wiki))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18058")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://hoerstemeier.com/tambon/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://hoerstemeier.com/tambon/", IsNullable=true)]
    [System.Runtime.Serialization.DataContractAttribute(Name="WikiBase", Namespace="http://hoerstemeier.com/tambon/", IsReference=true)]
    public partial class WikiBase {
        
        private string wikidataField;
        
        /// <summary>
        /// Wikidata item id, always starting with the letter Q followed by a number. Full URL to the item Q123 is https://www.wikidata.org/wiki/Q123
        /// </summary>
        /// <value>
        /// The wikidata.
        /// </value>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string wikidata {
            get {
                return this.wikidataField;
            }
            set {
                this.wikidataField = value;
            }
        }
    }
    
    /// <summary>
    /// Links to various wikis information.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18058")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://hoerstemeier.com/tambon/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://hoerstemeier.com/tambon/", IsNullable=true)]
    [System.Runtime.Serialization.DataContractAttribute(Name="Wiki", Namespace="http://hoerstemeier.com/tambon/", IsReference=true)]
    public partial class Wiki : WikiBase {
        
        private int openstreetmapField;
        
        private bool openstreetmapFieldSpecified;
        
        private int wikimapiaField;
        
        private bool wikimapiaFieldSpecified;
        
        /// <summary>
        /// Auto generated comment tag to suppress XML code documentation warning.
        /// </summary>
        /// <value>
        /// Auto generated value tag to suppress XML code documentation warning.
        /// </value>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int openstreetmap {
            get {
                return this.openstreetmapField;
            }
            set {
                this.openstreetmapField = value;
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
        public bool openstreetmapSpecified {
            get {
                return this.openstreetmapFieldSpecified;
            }
            set {
                this.openstreetmapFieldSpecified = value;
            }
        }
        
        /// <summary>
        /// Auto generated comment tag to suppress XML code documentation warning.
        /// </summary>
        /// <value>
        /// Auto generated value tag to suppress XML code documentation warning.
        /// </value>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int wikimapia {
            get {
                return this.wikimapiaField;
            }
            set {
                this.wikimapiaField = value;
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
        public bool wikimapiaSpecified {
            get {
                return this.wikimapiaFieldSpecified;
            }
            set {
                this.wikimapiaFieldSpecified = value;
            }
        }
    }
    
    /// <summary>
    /// Status of a change request.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18058")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://hoerstemeier.com/tambon/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://hoerstemeier.com/tambon/", IsNullable=false)]
    public enum ChangeStatus {
        
        /// <summary>
        /// Change announced in Royal Gazette.
        /// </summary>
        Gazette,
        
        /// <summary>
        /// Change approved and done.
        /// </summary>
        Done,
        
        /// <summary>
        /// Change waiting for final approval.
        /// </summary>
        Pending,
        
        /// <summary>
        /// Change not done though originally approved.
        /// </summary>
        Withdrawn,
        
        /// <summary>
        /// Change not approved.
        /// </summary>
        Denied,
    }
}
