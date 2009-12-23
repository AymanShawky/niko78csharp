//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Devart Entity Developer tool.
// Code is generated on: 23/12/2009 3:08:03
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

namespace TutorialEntities
{

    /// <summary>
    /// Pallet del Almacen
    /// </summary>
    /// <LongDescription>
    /// Representa un pallet del Almacen
    /// </LongDescription>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName="TutorialEntities", Name="Pallet")]
    [global::System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    [global::System.Serializable()]
    public partial class Pallet : global::System.Data.Objects.DataClasses.EntityObject
    {
        #region Factory Method

        /// <summary>
        /// Create a new Pallet object.
        /// </summary>
        /// <param name="id">Initial value of Id.</param>
        /// <param name="lote">Initial value of Lote.</param>
        /// <param name="bloqueado">Initial value of Bloqueado.</param>
        public static Pallet CreatePallet(long id, string lote, string bloqueado)
        {
            Pallet pallet = new Pallet();
            pallet.Id = id;
            pallet.Lote = lote;
            pallet.Bloqueado = bloqueado;
            return pallet;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// Id del pallet
        /// </summary>
        /// <LongDescription>
        /// Id del pallet, debe ser de 7 digitos
        /// </LongDescription>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public long Id
        {
            get
            {
                long value = this._Id;
                OnGetId(ref value);
                return value;
            }
            set
            {
                this.OnIdChanging(ref value);
                this.ReportPropertyChanging("Id");
                this._Id = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("Id");
                this.OnIdChanged();
            }
        }
        private long _Id;
        partial void OnGetId(ref long value);
        partial void OnIdChanging(ref long value);
        partial void OnIdChanged();
    
        /// <summary>
        /// There are no comments for Lote in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string Lote
        {
            get
            {
                string value = this._Lote;
                OnGetLote(ref value);
                return value;
            }
            set
            {
                this.OnLoteChanging(ref value);
                this.ReportPropertyChanging("Lote");
                this._Lote = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("Lote");
                this.OnLoteChanged();
            }
        }
        private string _Lote;
        partial void OnGetLote(ref string value);
        partial void OnLoteChanging(ref string value);
        partial void OnLoteChanged();
    
        /// <summary>
        /// There are no comments for FechaEntrada in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Nullable<System.DateTime> FechaEntrada
        {
            get
            {
                global::System.Nullable<System.DateTime> value = this._FechaEntrada;
                OnGetFechaEntrada(ref value);
                return value;
            }
            set
            {
                this.OnFechaEntradaChanging(ref value);
                this.ReportPropertyChanging("FechaEntrada");
                this._FechaEntrada = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("FechaEntrada");
                this.OnFechaEntradaChanged();
            }
        }
        private global::System.Nullable<System.DateTime> _FechaEntrada;
        partial void OnGetFechaEntrada(ref global::System.Nullable<System.DateTime> value);
        partial void OnFechaEntradaChanging(ref global::System.Nullable<System.DateTime> value);
        partial void OnFechaEntradaChanged();
    
        /// <summary>
        /// There are no comments for Bloqueado in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string Bloqueado
        {
            get
            {
                string value = this._Bloqueado;
                OnGetBloqueado(ref value);
                return value;
            }
            set
            {
                this.OnBloqueadoChanging(ref value);
                this.ReportPropertyChanging("Bloqueado");
                this._Bloqueado = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("Bloqueado");
                this.OnBloqueadoChanged();
            }
        }
        private string _Bloqueado;
        partial void OnGetBloqueado(ref string value);
        partial void OnBloqueadoChanging(ref string value);
        partial void OnBloqueadoChanged();

        #endregion

        #region Navigation Properties

        /// <summary>
        /// There are no comments for Articulo in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmRelationshipNavigationPropertyAttribute("TutorialEntities", "Articulo_Pallet", "Articulo")]
        [global::System.Xml.Serialization.XmlIgnoreAttribute()]
        [global::System.Xml.Serialization.SoapIgnoreAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public Articulo Articulo
        {
            get
            {
                return ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Articulo>("TutorialEntities.Articulo_Pallet", "Articulo").Value;
            }
            set
            {
                ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Articulo>("TutorialEntities.Articulo_Pallet", "Articulo").Value = value;
            }
        }

        /// <summary>
        /// There are no comments for Articulo in the schema.
        /// </summary>
        [global::System.ComponentModel.BrowsableAttribute(false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Data.Objects.DataClasses.EntityReference<Articulo> ArticuloReference
        {
            get
            {
                return ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Articulo>("TutorialEntities.Articulo_Pallet", "Articulo");
            }
            set
            {
                if (value != null)
                {
                    ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedReference<Articulo>("TutorialEntities.Articulo_Pallet", "Articulo", value);
                }
                else 
                {
                    ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Articulo>("TutorialEntities.Articulo_Pallet", "Articulo").Value = null;
                }
            }
        }

        #endregion
    }

}
