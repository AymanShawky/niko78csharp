//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Devart Entity Developer tool.
// Code is generated on: 11/12/2009 05:17:56
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

namespace TutorialEntities
{

    /// <summary>
    /// There are no comments for TutorialEntities.Persona in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName="TutorialEntities", Name="Persona")]
    [global::System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    [global::System.Serializable()]
    public partial class Persona : global::System.Data.Objects.DataClasses.EntityObject
    {
        #region Factory Method

        /// <summary>
        /// Create a new Persona object.
        /// </summary>
        /// <param name="id">Initial value of Id.</param>
        public static Persona CreatePersona(long id)
        {
            Persona persona = new Persona();
            persona.Id = id;
            return persona;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for Id in the schema.
        /// </summary>
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
        /// There are no comments for Nombre in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre
        {
            get
            {
                string value = this._Nombre;
                OnGetNombre(ref value);
                return value;
            }
            set
            {
                this.OnNombreChanging(ref value);
                this.ReportPropertyChanging("Nombre");
                this._Nombre = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true);
                this.ReportPropertyChanged("Nombre");
                this.OnNombreChanged();
            }
        }
        private string _Nombre;
        partial void OnGetNombre(ref string value);
        partial void OnNombreChanging(ref string value);
        partial void OnNombreChanged();
    
        /// <summary>
        /// There are no comments for Apellido in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string Apellido
        {
            get
            {
                string value = this._Apellido;
                OnGetApellido(ref value);
                return value;
            }
            set
            {
                this.OnApellidoChanging(ref value);
                this.ReportPropertyChanging("Apellido");
                this._Apellido = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true);
                this.ReportPropertyChanged("Apellido");
                this.OnApellidoChanged();
            }
        }
        private string _Apellido;
        partial void OnGetApellido(ref string value);
        partial void OnApellidoChanging(ref string value);
        partial void OnApellidoChanged();

        #endregion
    }

}
