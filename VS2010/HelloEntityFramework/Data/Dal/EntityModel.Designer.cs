﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("HelloEntityFramework.Data.Dal", "FK_Pallet_Pallet", "StorageUnit", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(HelloEntityFramework.Data.Dal.StorageUnit), "Pallet", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(HelloEntityFramework.Data.Dal.Pallet), true)]
[assembly: EdmRelationshipAttribute("HelloEntityFramework.Data.Dal", "FK_UnitItem_Products", "Product", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(HelloEntityFramework.Data.Dal.Product), "UnitItem", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(HelloEntityFramework.Data.Dal.UnitItem), true)]
[assembly: EdmRelationshipAttribute("HelloEntityFramework.Data.Dal", "FK_UnitItem_StorageUnit", "StorageUnit", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(HelloEntityFramework.Data.Dal.StorageUnit), "UnitItem", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(HelloEntityFramework.Data.Dal.UnitItem), true)]

#endregion

namespace HelloEntityFramework.Data.Dal
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class TutorialEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new TutorialEntities object using the connection string found in the 'TutorialEntities' section of the application configuration file.
        /// </summary>
        public TutorialEntities() : base("name=TutorialEntities", "TutorialEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new TutorialEntities object.
        /// </summary>
        public TutorialEntities(string connectionString) : base(connectionString, "TutorialEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new TutorialEntities object.
        /// </summary>
        public TutorialEntities(EntityConnection connection) : base(connection, "TutorialEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Pallet> Pallets
        {
            get
            {
                if ((_Pallets == null))
                {
                    _Pallets = base.CreateObjectSet<Pallet>("Pallets");
                }
                return _Pallets;
            }
        }
        private ObjectSet<Pallet> _Pallets;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Product> Products
        {
            get
            {
                if ((_Products == null))
                {
                    _Products = base.CreateObjectSet<Product>("Products");
                }
                return _Products;
            }
        }
        private ObjectSet<Product> _Products;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<StorageUnit> StorageUnits
        {
            get
            {
                if ((_StorageUnits == null))
                {
                    _StorageUnits = base.CreateObjectSet<StorageUnit>("StorageUnits");
                }
                return _StorageUnits;
            }
        }
        private ObjectSet<StorageUnit> _StorageUnits;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<UnitItem> UnitItems
        {
            get
            {
                if ((_UnitItems == null))
                {
                    _UnitItems = base.CreateObjectSet<UnitItem>("UnitItems");
                }
                return _UnitItems;
            }
        }
        private ObjectSet<UnitItem> _UnitItems;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Pallets EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToPallets(Pallet pallet)
        {
            base.AddObject("Pallets", pallet);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Products EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToProducts(Product product)
        {
            base.AddObject("Products", product);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the StorageUnits EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToStorageUnits(StorageUnit storageUnit)
        {
            base.AddObject("StorageUnits", storageUnit);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the UnitItems EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToUnitItems(UnitItem unitItem)
        {
            base.AddObject("UnitItems", unitItem);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="HelloEntityFramework.Data.Dal", Name="Pallet")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Pallet : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Pallet object.
        /// </summary>
        /// <param name="idStorageUnit">Initial value of the IdStorageUnit property.</param>
        /// <param name="quantity">Initial value of the Quantity property.</param>
        /// <param name="quantityReserved">Initial value of the QuantityReserved property.</param>
        public static Pallet CreatePallet(global::System.Int32 idStorageUnit, global::System.Int32 quantity, global::System.Int32 quantityReserved)
        {
            Pallet pallet = new Pallet();
            pallet.IdStorageUnit = idStorageUnit;
            pallet.Quantity = quantity;
            pallet.QuantityReserved = quantityReserved;
            return pallet;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 IdStorageUnit
        {
            get
            {
                return _IdStorageUnit;
            }
            set
            {
                if (_IdStorageUnit != value)
                {
                    OnIdStorageUnitChanging(value);
                    ReportPropertyChanging("IdStorageUnit");
                    _IdStorageUnit = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("IdStorageUnit");
                    OnIdStorageUnitChanged();
                }
            }
        }
        private global::System.Int32 _IdStorageUnit;
        partial void OnIdStorageUnitChanging(global::System.Int32 value);
        partial void OnIdStorageUnitChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Quantity
        {
            get
            {
                return _Quantity;
            }
            set
            {
                OnQuantityChanging(value);
                ReportPropertyChanging("Quantity");
                _Quantity = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Quantity");
                OnQuantityChanged();
            }
        }
        private global::System.Int32 _Quantity;
        partial void OnQuantityChanging(global::System.Int32 value);
        partial void OnQuantityChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 QuantityReserved
        {
            get
            {
                return _QuantityReserved;
            }
            set
            {
                OnQuantityReservedChanging(value);
                ReportPropertyChanging("QuantityReserved");
                _QuantityReserved = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("QuantityReserved");
                OnQuantityReservedChanged();
            }
        }
        private global::System.Int32 _QuantityReserved;
        partial void OnQuantityReservedChanging(global::System.Int32 value);
        partial void OnQuantityReservedChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("HelloEntityFramework.Data.Dal", "FK_Pallet_Pallet", "StorageUnit")]
        public StorageUnit StorageUnit
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<StorageUnit>("HelloEntityFramework.Data.Dal.FK_Pallet_Pallet", "StorageUnit").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<StorageUnit>("HelloEntityFramework.Data.Dal.FK_Pallet_Pallet", "StorageUnit").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<StorageUnit> StorageUnitReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<StorageUnit>("HelloEntityFramework.Data.Dal.FK_Pallet_Pallet", "StorageUnit");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<StorageUnit>("HelloEntityFramework.Data.Dal.FK_Pallet_Pallet", "StorageUnit", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="HelloEntityFramework.Data.Dal", Name="Product")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Product : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Product object.
        /// </summary>
        /// <param name="idProduct">Initial value of the IdProduct property.</param>
        public static Product CreateProduct(global::System.String idProduct)
        {
            Product product = new Product();
            product.IdProduct = idProduct;
            return product;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String IdProduct
        {
            get
            {
                return _IdProduct;
            }
            set
            {
                if (_IdProduct != value)
                {
                    OnIdProductChanging(value);
                    ReportPropertyChanging("IdProduct");
                    _IdProduct = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("IdProduct");
                    OnIdProductChanged();
                }
            }
        }
        private global::System.String _IdProduct;
        partial void OnIdProductChanging(global::System.String value);
        partial void OnIdProductChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("HelloEntityFramework.Data.Dal", "FK_UnitItem_Products", "UnitItem")]
        public EntityCollection<UnitItem> UnitItems
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<UnitItem>("HelloEntityFramework.Data.Dal.FK_UnitItem_Products", "UnitItem");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<UnitItem>("HelloEntityFramework.Data.Dal.FK_UnitItem_Products", "UnitItem", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="HelloEntityFramework.Data.Dal", Name="StorageUnit")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class StorageUnit : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new StorageUnit object.
        /// </summary>
        /// <param name="idStorageUnit">Initial value of the IdStorageUnit property.</param>
        public static StorageUnit CreateStorageUnit(global::System.Int32 idStorageUnit)
        {
            StorageUnit storageUnit = new StorageUnit();
            storageUnit.IdStorageUnit = idStorageUnit;
            return storageUnit;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 IdStorageUnit
        {
            get
            {
                return _IdStorageUnit;
            }
            set
            {
                if (_IdStorageUnit != value)
                {
                    OnIdStorageUnitChanging(value);
                    ReportPropertyChanging("IdStorageUnit");
                    _IdStorageUnit = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("IdStorageUnit");
                    OnIdStorageUnitChanged();
                }
            }
        }
        private global::System.Int32 _IdStorageUnit;
        partial void OnIdStorageUnitChanging(global::System.Int32 value);
        partial void OnIdStorageUnitChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("HelloEntityFramework.Data.Dal", "FK_Pallet_Pallet", "Pallet")]
        public Pallet Pallet
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Pallet>("HelloEntityFramework.Data.Dal.FK_Pallet_Pallet", "Pallet").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Pallet>("HelloEntityFramework.Data.Dal.FK_Pallet_Pallet", "Pallet").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Pallet> PalletReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Pallet>("HelloEntityFramework.Data.Dal.FK_Pallet_Pallet", "Pallet");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Pallet>("HelloEntityFramework.Data.Dal.FK_Pallet_Pallet", "Pallet", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("HelloEntityFramework.Data.Dal", "FK_UnitItem_StorageUnit", "UnitItem")]
        public UnitItem UnitItem
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<UnitItem>("HelloEntityFramework.Data.Dal.FK_UnitItem_StorageUnit", "UnitItem").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<UnitItem>("HelloEntityFramework.Data.Dal.FK_UnitItem_StorageUnit", "UnitItem").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<UnitItem> UnitItemReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<UnitItem>("HelloEntityFramework.Data.Dal.FK_UnitItem_StorageUnit", "UnitItem");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<UnitItem>("HelloEntityFramework.Data.Dal.FK_UnitItem_StorageUnit", "UnitItem", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="HelloEntityFramework.Data.Dal", Name="UnitItem")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class UnitItem : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new UnitItem object.
        /// </summary>
        /// <param name="idItem">Initial value of the IdItem property.</param>
        /// <param name="idStorageUnit">Initial value of the IdStorageUnit property.</param>
        /// <param name="idProduct">Initial value of the IdProduct property.</param>
        public static UnitItem CreateUnitItem(global::System.Int32 idItem, global::System.Int32 idStorageUnit, global::System.String idProduct)
        {
            UnitItem unitItem = new UnitItem();
            unitItem.IdItem = idItem;
            unitItem.IdStorageUnit = idStorageUnit;
            unitItem.IdProduct = idProduct;
            return unitItem;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 IdItem
        {
            get
            {
                return _IdItem;
            }
            set
            {
                if (_IdItem != value)
                {
                    OnIdItemChanging(value);
                    ReportPropertyChanging("IdItem");
                    _IdItem = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("IdItem");
                    OnIdItemChanged();
                }
            }
        }
        private global::System.Int32 _IdItem;
        partial void OnIdItemChanging(global::System.Int32 value);
        partial void OnIdItemChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 IdStorageUnit
        {
            get
            {
                return _IdStorageUnit;
            }
            set
            {
                OnIdStorageUnitChanging(value);
                ReportPropertyChanging("IdStorageUnit");
                _IdStorageUnit = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("IdStorageUnit");
                OnIdStorageUnitChanged();
            }
        }
        private global::System.Int32 _IdStorageUnit;
        partial void OnIdStorageUnitChanging(global::System.Int32 value);
        partial void OnIdStorageUnitChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String IdProduct
        {
            get
            {
                return _IdProduct;
            }
            set
            {
                OnIdProductChanging(value);
                ReportPropertyChanging("IdProduct");
                _IdProduct = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("IdProduct");
                OnIdProductChanged();
            }
        }
        private global::System.String _IdProduct;
        partial void OnIdProductChanging(global::System.String value);
        partial void OnIdProductChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("HelloEntityFramework.Data.Dal", "FK_UnitItem_Products", "Product")]
        public Product Product
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Product>("HelloEntityFramework.Data.Dal.FK_UnitItem_Products", "Product").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Product>("HelloEntityFramework.Data.Dal.FK_UnitItem_Products", "Product").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Product> ProductReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Product>("HelloEntityFramework.Data.Dal.FK_UnitItem_Products", "Product");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Product>("HelloEntityFramework.Data.Dal.FK_UnitItem_Products", "Product", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("HelloEntityFramework.Data.Dal", "FK_UnitItem_StorageUnit", "StorageUnit")]
        public StorageUnit StorageUnit
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<StorageUnit>("HelloEntityFramework.Data.Dal.FK_UnitItem_StorageUnit", "StorageUnit").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<StorageUnit>("HelloEntityFramework.Data.Dal.FK_UnitItem_StorageUnit", "StorageUnit").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<StorageUnit> StorageUnitReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<StorageUnit>("HelloEntityFramework.Data.Dal.FK_UnitItem_StorageUnit", "StorageUnit");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<StorageUnit>("HelloEntityFramework.Data.Dal.FK_UnitItem_StorageUnit", "StorageUnit", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}