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
    
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HouseholdDataPoint))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AgeTableEntry))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18058")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://hoerstemeier.com/tambon/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://hoerstemeier.com/tambon/", IsNullable=true)]
    [System.Runtime.Serialization.DataContractAttribute(Name="PopulationDataPoint", Namespace="http://hoerstemeier.com/tambon/", IsReference=true)]
    public partial class PopulationDataPoint {
        
        private int totalField;
        
        private int maleField;
        
        private int femaleField;
        
        private string commentField;
        
        /// <summary>
        /// Creates a new instance of PopulationDataPoint.
        /// </summary>
        public PopulationDataPoint() {
            this.totalField = 0;
            this.maleField = 0;
            this.femaleField = 0;
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(0)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int total {
            get {
                return this.totalField;
            }
            set {
                this.totalField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(0)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int male {
            get {
                return this.maleField;
            }
            set {
                this.maleField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(0)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int female {
            get {
                return this.femaleField;
            }
            set {
                this.femaleField = value;
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18058")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://hoerstemeier.com/tambon/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://hoerstemeier.com/tambon/", IsNullable=true)]
    [System.Runtime.Serialization.DataContractAttribute(Name="HouseholdDataPoint", Namespace="http://hoerstemeier.com/tambon/", IsReference=true)]
    public partial class HouseholdDataPoint : PopulationDataPoint {
        
        private List<HouseholdDataPoint> dataField;
        
        private AgeTable agetableField;
        
        private PopulationDataType typeField;
        
        private int householdsField;

        private int geocodeField;
        
        /// <summary>
        /// Creates a new instance of HouseholdDataPoint.
        /// </summary>
        public HouseholdDataPoint() {
            this.agetableField = new AgeTable();
            this.dataField = new List<HouseholdDataPoint>();
            this.typeField = PopulationDataType.total;
            this.householdsField = 0;
            this.geocodeField = 0;
        }
        
        [System.Xml.Serialization.XmlElementAttribute("data", Order=0)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<HouseholdDataPoint> data {
            get {
                return this.dataField;
            }
            set {
                this.dataField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AgeTable agetable {
            get {
                return this.agetableField;
            }
            set {
                this.agetableField = value;
            }
        }
        
        /// <summary>
        /// Auto generated comment tag to suppress XML code documentation warning.
        /// </summary>
        /// <value>
        /// Auto generated value tag to suppress XML code documentation warning.
        /// </value>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(PopulationDataType.total)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public PopulationDataType type {
            get {
                return this.typeField;
            }
            set {
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
        [System.ComponentModel.DefaultValueAttribute(0)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int households {
            get {
                return this.householdsField;
            }
            set {
                this.householdsField = value;
            }
        }

        /// <summary>
        /// Auto generated comment tag to suppress XML code documentation warning.
        /// </summary>
        /// <value>
        /// Auto generated value tag to suppress XML code documentation warning.
        /// </value>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(0)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int geocode
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
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18058")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://hoerstemeier.com/tambon/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://hoerstemeier.com/tambon/", IsNullable=true)]
    [System.Runtime.Serialization.DataContractAttribute(Name="AgeTable", Namespace="http://hoerstemeier.com/tambon/", IsReference=true)]
    public partial class AgeTable {
        
        private List<AgeTableEntry> ageField;
        
        private PopulationDataPoint unknownField;
        
        /// <summary>
        /// Creates a new instance of AgeTable.
        /// </summary>
        public AgeTable() {
            this.unknownField = new PopulationDataPoint();
            this.ageField = new List<AgeTableEntry>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("age", Order=0)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<AgeTableEntry> age {
            get {
                return this.ageField;
            }
            set {
                this.ageField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public PopulationDataPoint unknown {
            get {
                return this.unknownField;
            }
            set {
                this.unknownField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18058")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://hoerstemeier.com/tambon/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://hoerstemeier.com/tambon/", IsNullable=true)]
    [System.Runtime.Serialization.DataContractAttribute(Name="AgeTableEntry", Namespace="http://hoerstemeier.com/tambon/", IsReference=true)]
    public partial class AgeTableEntry : PopulationDataPoint {
        
        private uint beginField;
        
        private uint endField;
        
        /// <summary>
        /// Auto generated comment tag to suppress XML code documentation warning.
        /// </summary>
        /// <value>
        /// Auto generated value tag to suppress XML code documentation warning.
        /// </value>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public uint begin {
            get {
                return this.beginField;
            }
            set {
                this.beginField = value;
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
        public uint end {
            get {
                return this.endField;
            }
            set {
                this.endField = value;
            }
        }
    }
    
    /// <summary>
    /// Type of population data.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18058")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://hoerstemeier.com/tambon/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://hoerstemeier.com/tambon/", IsNullable=false)]
    public enum PopulationDataType {
        
        /// <summary>
        /// Total population.
        /// </summary>
        total,
        
        /// <summary>
        /// Municipal population, i.e. population within Thesaban.
        /// </summary>
        municipal,
        
        /// <summary>
        /// Non-municipal population, i.e. population outside the Thesaban.
        /// </summary>
        nonmunicipal,
        
        /// <summary>
        /// Agricultural population, i.e. population having at least ... rai of agricultural land.
        /// </summary>
        agricultural,
        
        /// <summary>
        /// Non-Agricultural population, i.e. population having none or only little agricultural land.
        /// </summary>
        nonagricultural,
        
        /// <summary>
        /// Private households, i.e. ....
        /// </summary>
        privatehouseholds,
        
        /// <summary>
        /// Collective households, i.e. ....
        /// </summary>
        collectivehouseholds,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18058")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://hoerstemeier.com/tambon/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://hoerstemeier.com/tambon/", IsNullable=true)]
    [System.Runtime.Serialization.DataContractAttribute(Name="PopulationData", Namespace="http://hoerstemeier.com/tambon/", IsReference=true)]
    public partial class PopulationData {
        
        private List<HouseholdDataPoint> dataField;
        
        private PopulationDataSourceType sourceField;
        
        private System.DateTime referencedateField;
        
        private bool referencedateFieldSpecified;
        
        private string yearField;
        
        private string commentField;
        
        /// <summary>
        /// Creates a new instance of PopulationData.
        /// </summary>
        public PopulationData() {
            this.dataField = new List<HouseholdDataPoint>();
            this.sourceField = PopulationDataSourceType.Unknown;
        }
        
        [System.Xml.Serialization.XmlElementAttribute("data", Order=0)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<HouseholdDataPoint> data {
            get {
                return this.dataField;
            }
            set {
                this.dataField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(PopulationDataSourceType.Unknown)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public PopulationDataSourceType source {
            get {
                return this.sourceField;
            }
            set {
                this.sourceField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="date")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime referencedate {
            get {
                return this.referencedateField;
            }
            set {
                this.referencedateField = value;
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
        public bool referencedateSpecified {
            get {
                return this.referencedateFieldSpecified;
            }
            set {
                this.referencedateFieldSpecified = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="gYear")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string year {
            get {
                return this.yearField;
            }
            set {
                this.yearField = value;
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
    /// Sources of population data.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18058")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://hoerstemeier.com/tambon/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://hoerstemeier.com/tambon/", IsNullable=false)]
    public enum PopulationDataSourceType {
        
        /// <summary>
        /// Actual source not know.
        /// </summary>
        Unknown,
        
        /// <summary>
        /// Official population census.
        /// </summary>
        Census,
        
        /// <summary>
        /// Registration data.
        /// </summary>
        DOPA,
    }
}
