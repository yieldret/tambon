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
    [System.Xml.Serialization.XmlRootAttribute("entity", Namespace = "http://hoerstemeier.com/tambon/", IsNullable = false)]
    [System.Runtime.Serialization.DataContractAttribute(Name = "Entity", Namespace = "http://hoerstemeier.com/tambon/", IsReference = true)]
    public partial class Entity
    {

        private string sloganField;

        private string symboltreeField;

        private string symbolflowerField;

        private List<Office> officeField;

        private List<AreaData> areaField;

        private HistoryList historyField;

        private List<PopulationData> populationField;

        private List<Entity> entityField;

        private EntityType typeField;

        private string nameField;

        private string englishField;

        private uint geocodeField;

        private string newgeocodeField;

        private bool obsoleteField;

        private bool obsoleteFieldSpecified;

        private string parentField;

        private string commentField;

        private uint tambonField;

        private bool tambonFieldSpecified;

        private uint mubanField;

        private bool mubanFieldSpecified;

        /// <summary>
        /// Creates a new instance of Entity.
        /// </summary>
        public Entity()
        {
            this.entityField = new List<Entity>();
            this.populationField = new List<PopulationData>();
            this.historyField = new HistoryList();
            this.areaField = new List<AreaData>();
            this.officeField = new List<Office>();
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string slogan
        {
            get
            {
                return this.sloganField;
            }
            set
            {
                this.sloganField = value;
            }
        }

        /// <summary>
        /// Botanical name of the symbol tree, only applicable for provinces (ต้นไม้ประจำจังหวัด).
        /// </summary>
        /// <value>
        /// The symboltree.
        /// </value>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string symboltree
        {
            get
            {
                return this.symboltreeField;
            }
            set
            {
                this.symboltreeField = value;
            }
        }

        /// <summary>
        /// Botanical name of the symbol flower, only applicable for provinces (ดอกไม้ประจำจังหวัด).
        /// </summary>
        /// <value>
        /// The symbolflower.
        /// </value>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string symbolflower
        {
            get
            {
                return this.symbolflowerField;
            }
            set
            {
                this.symbolflowerField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("office", Order = 3)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<Office> office
        {
            get
            {
                return this.officeField;
            }
            set
            {
                this.officeField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayAttribute(Order = 4)]
        [System.Xml.Serialization.XmlArrayItemAttribute("data", typeof(AreaData), IsNullable = false)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<AreaData> area
        {
            get
            {
                return this.areaField;
            }
            set
            {
                this.areaField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HistoryList history
        {
            get
            {
                return this.historyField;
            }
            set
            {
                this.historyField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("population", Order = 6)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<PopulationData> population
        {
            get
            {
                return this.populationField;
            }
            set
            {
                this.populationField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("entity", Order = 7)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<Entity> entity
        {
            get
            {
                return this.entityField;
            }
            set
            {
                this.entityField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        public string newgeocode
        {
            get
            {
                return this.newgeocodeField;
            }
            set
            {
                this.newgeocodeField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool obsolete
        {
            get
            {
                return this.obsoleteField;
            }
            set
            {
                this.obsoleteField = value;
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
        public bool obsoleteSpecified
        {
            get
            {
                return this.obsoleteFieldSpecified;
            }
            set
            {
                this.obsoleteFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string parent
        {
            get
            {
                return this.parentField;
            }
            set
            {
                this.parentField = value;
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

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public uint tambon
        {
            get
            {
                return this.tambonField;
            }
            set
            {
                this.tambonField = value;
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
        public bool tambonSpecified
        {
            get
            {
                return this.tambonFieldSpecified;
            }
            set
            {
                this.tambonFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public uint muban
        {
            get
            {
                return this.mubanField;
            }
            set
            {
                this.mubanField = value;
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
        public bool mubanSpecified
        {
            get
            {
                return this.mubanFieldSpecified;
            }
            set
            {
                this.mubanFieldSpecified = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://hoerstemeier.com/tambon/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://hoerstemeier.com/tambon/", IsNullable = true)]
    [System.Runtime.Serialization.DataContractAttribute(Name = "AreaData", Namespace = "http://hoerstemeier.com/tambon/", IsReference = true)]
    public partial class AreaData
    {

        private decimal valueField;

        private AreaUnit unitField;

        private string sourceField;

        private ushort dateField;

        private bool dateFieldSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal value
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

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AreaUnit unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string source
        {
            get
            {
                return this.sourceField;
            }
            set
            {
                this.sourceField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ushort date
        {
            get
            {
                return this.dateField;
            }
            set
            {
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
        public bool dateSpecified
        {
            get
            {
                return this.dateFieldSpecified;
            }
            set
            {
                this.dateFieldSpecified = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://hoerstemeier.com/tambon/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://hoerstemeier.com/tambon/", IsNullable = false)]
    public enum AreaUnit
    {

        [System.Xml.Serialization.XmlEnumAttribute("km²")]
        km,

        rai,
    }

    /// <summary>
    /// List of historical changes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://hoerstemeier.com/tambon/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://hoerstemeier.com/tambon/", IsNullable = true)]
    [System.Runtime.Serialization.DataContractAttribute(Name = "HistoryList", Namespace = "http://hoerstemeier.com/tambon/", IsReference = true)]
    public partial class HistoryList
    {

        private List<HistoryEntryBase> itemsField;

        /// <summary>
        /// Creates a new instance of HistoryList.
        /// </summary>
        public HistoryList()
        {
            this.itemsField = new List<HistoryEntryBase>();
        }

        /// <summary>
        /// Auto generated comment tag to suppress XML code documentation warning.
        /// </summary>
        /// <value>
        /// Auto generated value tag to suppress XML code documentation warning.
        /// </value>
        [System.Xml.Serialization.XmlElementAttribute("abolished", typeof(HistoryAbolish), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("alternativename", typeof(HistoryAlternativeName), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("create", typeof(HistoryCreate), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("misspelling", typeof(HistorySpelling), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("reformedspelling", typeof(HistoryReformSpelling), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("rename", typeof(HistoryRename), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("statuschange", typeof(HistoryStatus), Order = 0)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<HistoryEntryBase> Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://hoerstemeier.com/tambon/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://hoerstemeier.com/tambon/", IsNullable = true)]
    [System.Runtime.Serialization.DataContractAttribute(Name = "HistoryAbolish", Namespace = "http://hoerstemeier.com/tambon/", IsReference = true)]
    public partial class HistoryAbolish : HistoryEntryBase
    {

        private EntityType typeField;

        private uint mergetoField;

        private bool mergetoFieldSpecified;

        /// <summary>
        /// Auto generated comment tag to suppress XML code documentation warning.
        /// </summary>
        /// <value>
        /// Auto generated value tag to suppress XML code documentation warning.
        /// </value>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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

        /// <summary>
        /// Auto generated comment tag to suppress XML code documentation warning.
        /// </summary>
        /// <value>
        /// Auto generated value tag to suppress XML code documentation warning.
        /// </value>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public uint mergeto
        {
            get
            {
                return this.mergetoField;
            }
            set
            {
                this.mergetoField = value;
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
        public bool mergetoSpecified
        {
            get
            {
                return this.mergetoFieldSpecified;
            }
            set
            {
                this.mergetoFieldSpecified = value;
            }
        }
    }

    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HistoryAbolish))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HistoryCreate))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HistorySpellingBase))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HistoryAlternativeName))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HistoryReformSpelling))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HistorySpelling))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HistoryRename))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HistoryStatus))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://hoerstemeier.com/tambon/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://hoerstemeier.com/tambon/", IsNullable = true)]
    [System.Runtime.Serialization.DataContractAttribute(Name = "HistoryEntryBase", Namespace = "http://hoerstemeier.com/tambon/", IsReference = true)]
    public abstract partial class HistoryEntryBase
    {

        private List<GazetteRelated> gazetteField;

        private List<MyUri> urlField;

        private System.DateTime effectiveField;

        private bool effectiveFieldSpecified;

        private string commentField;

        /// <summary>
        /// Creates a new instance of HistoryEntryBase.
        /// </summary>
        public HistoryEntryBase()
        {
            this.urlField = new List<MyUri>();
            this.gazetteField = new List<GazetteRelated>();
        }

        /// <summary>
        /// Gazette announcement which deals with the given change.
        /// </summary>
        /// <value>
        /// The gazette.
        /// </value>
        [System.Xml.Serialization.XmlElementAttribute("gazette", Order = 0)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<GazetteRelated> gazette
        {
            get
            {
                return this.gazetteField;
            }
            set
            {
                this.gazetteField = value;
            }
        }

        /// <summary>
        /// Internet resource which explains the change.
        /// </summary>
        /// <value>
        /// The url.
        /// </value>
        [System.Xml.Serialization.XmlElementAttribute("url", Order = 1)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<MyUri> url
        {
            get
            {
                return this.urlField;
            }
            set
            {
                this.urlField = value;
            }
        }

        /// <summary>
        /// Date the change became officially effective.
        /// </summary>
        /// <value>
        /// The effective.
        /// </value>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime effective
        {
            get
            {
                return this.effectiveField;
            }
            set
            {
                this.effectiveField = value;
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
        public bool effectiveSpecified
        {
            get
            {
                return this.effectiveFieldSpecified;
            }
            set
            {
                this.effectiveFieldSpecified = value;
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://hoerstemeier.com/tambon/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://hoerstemeier.com/tambon/", IsNullable = true)]
    [System.Runtime.Serialization.DataContractAttribute(Name = "HistoryCreate", Namespace = "http://hoerstemeier.com/tambon/", IsReference = true)]
    public partial class HistoryCreate : HistoryEntryBase
    {

        private EntityType typeField;

        /// <summary>
        /// Auto generated comment tag to suppress XML code documentation warning.
        /// </summary>
        /// <value>
        /// Auto generated value tag to suppress XML code documentation warning.
        /// </value>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    }

    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HistoryAlternativeName))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HistoryReformSpelling))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HistorySpelling))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://hoerstemeier.com/tambon/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://hoerstemeier.com/tambon/", IsNullable = true)]
    [System.Runtime.Serialization.DataContractAttribute(Name = "HistorySpellingBase", Namespace = "http://hoerstemeier.com/tambon/", IsReference = true)]
    public abstract partial class HistorySpellingBase : HistoryEntryBase
    {

        private string nameField;

        /// <summary>
        /// Auto generated comment tag to suppress XML code documentation warning.
        /// </summary>
        /// <value>
        /// Auto generated value tag to suppress XML code documentation warning.
        /// </value>
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
    }

    /// <summary>
    /// Alternative name or spelling, which is more than a plain misspelling.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://hoerstemeier.com/tambon/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://hoerstemeier.com/tambon/", IsNullable = true)]
    [System.Runtime.Serialization.DataContractAttribute(Name = "HistoryAlternativeName", Namespace = "http://hoerstemeier.com/tambon/", IsReference = true)]
    public partial class HistoryAlternativeName : HistorySpellingBase
    {

        private string englishField;

        private string typeField;

        /// <summary>
        /// Auto generated comment tag to suppress XML code documentation warning.
        /// </summary>
        /// <value>
        /// Auto generated value tag to suppress XML code documentation warning.
        /// </value>
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

        /// <summary>
        /// Auto generated comment tag to suppress XML code documentation warning.
        /// </summary>
        /// <value>
        /// Auto generated value tag to suppress XML code documentation warning.
        /// </value>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "gYear")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string type
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
    }

    /// <summary>
    /// Alternative spelling during the Thai spelling reform 1942-1945.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://hoerstemeier.com/tambon/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://hoerstemeier.com/tambon/", IsNullable = true)]
    [System.Runtime.Serialization.DataContractAttribute(Name = "HistoryReformSpelling", Namespace = "http://hoerstemeier.com/tambon/", IsReference = true)]
    public partial class HistoryReformSpelling : HistorySpellingBase
    {
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://hoerstemeier.com/tambon/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://hoerstemeier.com/tambon/", IsNullable = true)]
    [System.Runtime.Serialization.DataContractAttribute(Name = "HistorySpelling", Namespace = "http://hoerstemeier.com/tambon/", IsReference = true)]
    public partial class HistorySpelling : HistorySpellingBase
    {
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://hoerstemeier.com/tambon/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://hoerstemeier.com/tambon/", IsNullable = true)]
    [System.Runtime.Serialization.DataContractAttribute(Name = "HistoryRename", Namespace = "http://hoerstemeier.com/tambon/", IsReference = true)]
    public partial class HistoryRename : HistoryEntryBase
    {

        private string nameField;

        private string oldnameField;

        private string oldenglishField;

        private string englishField;

        /// <summary>
        /// Auto generated comment tag to suppress XML code documentation warning.
        /// </summary>
        /// <value>
        /// Auto generated value tag to suppress XML code documentation warning.
        /// </value>
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

        /// <summary>
        /// Auto generated comment tag to suppress XML code documentation warning.
        /// </summary>
        /// <value>
        /// Auto generated value tag to suppress XML code documentation warning.
        /// </value>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string oldname
        {
            get
            {
                return this.oldnameField;
            }
            set
            {
                this.oldnameField = value;
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
        public string oldenglish
        {
            get
            {
                return this.oldenglishField;
            }
            set
            {
                this.oldenglishField = value;
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
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://hoerstemeier.com/tambon/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://hoerstemeier.com/tambon/", IsNullable = true)]
    [System.Runtime.Serialization.DataContractAttribute(Name = "HistoryStatus", Namespace = "http://hoerstemeier.com/tambon/", IsReference = true)]
    public partial class HistoryStatus : HistoryEntryBase
    {

        private EntityType oldField;

        private EntityType newField;

        /// <summary>
        /// Auto generated comment tag to suppress XML code documentation warning.
        /// </summary>
        /// <value>
        /// Auto generated value tag to suppress XML code documentation warning.
        /// </value>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public EntityType old
        {
            get
            {
                return this.oldField;
            }
            set
            {
                this.oldField = value;
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
        public EntityType @new
        {
            get
            {
                return this.newField;
            }
            set
            {
                this.newField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://hoerstemeier.com/tambon/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://hoerstemeier.com/tambon/", IsNullable = true)]
    [System.Runtime.Serialization.DataContractAttribute(Name = "Area", Namespace = "http://hoerstemeier.com/tambon/", IsReference = true)]
    public partial class Area
    {

        private List<AreaData> dataField;

        /// <summary>
        /// Creates a new instance of Area.
        /// </summary>
        public Area()
        {
            this.dataField = new List<AreaData>();
        }

        [System.Xml.Serialization.XmlElementAttribute("data", Order = 0)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<AreaData> data
        {
            get
            {
                return this.dataField;
            }
            set
            {
                this.dataField = value;
            }
        }
    }
}