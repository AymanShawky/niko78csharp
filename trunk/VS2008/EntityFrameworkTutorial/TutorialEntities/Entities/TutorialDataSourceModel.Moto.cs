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
    /// There are no comments for TutorialEntities.Moto in the schema.
    /// </summary>
    /// <KeyProperties>
    /// </KeyProperties>
    [global::System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName="TutorialEntities", Name="Moto")]
    [global::System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    [global::System.Serializable()]
    public partial class Moto : Vehiculo
    {
        #region Factory Method

        /// <summary>
        /// Create a new Moto object.
        /// </summary>
        /// <param name="peso">Initial value of Peso.</param>
        /// <param name="id">Initial value of Id.</param>
        /// <param name="encPedal">Initial value of EncPedal.</param>
        public static Moto CreateMoto(int peso, long id, string encPedal)
        {
            Moto moto = new Moto();
            moto.Peso = peso;
            moto.Id = id;
            moto.EncPedal = encPedal;
            return moto;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for EncPedal in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string EncPedal
        {
            get
            {
                string value = this._EncPedal;
                OnGetEncPedal(ref value);
                return value;
            }
            set
            {
                this.OnEncPedalChanging(ref value);
                this.ReportPropertyChanging("EncPedal");
                this._EncPedal = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("EncPedal");
                this.OnEncPedalChanged();
            }
        }
        private string _EncPedal;
        partial void OnGetEncPedal(ref string value);
        partial void OnEncPedalChanging(ref string value);
        partial void OnEncPedalChanged();

        #endregion
    }

}
