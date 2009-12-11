//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Devart Entity Developer tool.
// Code is generated on: 11/12/2009 05:17:56
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

#region Entity Data Model Attributes
[assembly: global::System.Data.Objects.DataClasses.EdmSchemaAttribute()]
[assembly: global::System.Data.Objects.DataClasses.EdmRelationshipAttribute("TutorialEntities", "Articulo_Pallet", "Articulo", global::System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(TutorialEntities.Articulo), "Pallets", global::System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(TutorialEntities.Pallet))]
#endregion

namespace TutorialEntities
{

    public partial class TutorialObjectContext : global::System.Data.Objects.ObjectContext
    {
        #region Constructors

        /// <summary>
        /// Initialize a new TutorialObjectContext object.
        /// </summary>
        public TutorialObjectContext() : 
                base(@"metadata=res://*/TutorialDataSourceModel.csdl|res://*/TutorialDataSourceModel.ssdl|res://*/TutorialDataSourceModel.msl;provider=Devart.Data.Oracle;provider connection string=""User Id=ENTITY_TUTORIAL;Password=ENTITY_TUTORIAL;Server=ALMACENVM25;Home=oraclient10g_home1;Persist Security Info=True""", "TutorialObjectContext")
        {
            this.OnContextCreated();
        }

        /// <summary>
        /// Initializes a new TutorialObjectContext object using the connection string found in the 'TutorialObjectContext' section of the application configuration file.
        /// </summary>
        public TutorialObjectContext(string connectionString) : 
                base(connectionString, "TutorialObjectContext")
        {
            this.OnContextCreated();
        }

        /// <summary>
        /// Initialize a new TutorialObjectContext object.
        /// </summary>
        public TutorialObjectContext(global::System.Data.EntityClient.EntityConnection connection) : 
                base(connection, "TutorialObjectContext")
        {
            this.OnContextCreated();
        }

        #endregion

        #region Partial Methods

        partial void OnContextCreated();

        #endregion

        #region ObjectQuery Properties

        public global::System.Data.Objects.ObjectQuery<Pallet> Pallets
        {
            get
            {
                if ((this._Pallets == null))
                {
                    this._Pallets = base.CreateQuery<Pallet>("Pallets");
                }
                return this._Pallets;
            }
        }
        private global::System.Data.Objects.ObjectQuery<Pallet> _Pallets;

        public global::System.Data.Objects.ObjectQuery<Articulo> Articulos
        {
            get
            {
                if ((this._Articulos == null))
                {
                    this._Articulos = base.CreateQuery<Articulo>("Articulos");
                }
                return this._Articulos;
            }
        }
        private global::System.Data.Objects.ObjectQuery<Articulo> _Articulos;

        public global::System.Data.Objects.ObjectQuery<Persona> Personas
        {
            get
            {
                if ((this._Personas == null))
                {
                    this._Personas = base.CreateQuery<Persona>("Personas");
                }
                return this._Personas;
            }
        }
        private global::System.Data.Objects.ObjectQuery<Persona> _Personas;

        public global::System.Data.Objects.ObjectQuery<Vehiculo> Vehiculos
        {
            get
            {
                if ((this._Vehiculos == null))
                {
                    this._Vehiculos = base.CreateQuery<Vehiculo>("Vehiculos");
                }
                return this._Vehiculos;
            }
        }
        private global::System.Data.Objects.ObjectQuery<Vehiculo> _Vehiculos;
        #endregion

        #region AddTo Methods

        public void AddToPallets(Pallet pallet)
        {
            base.AddObject("Pallets", pallet);
        }

        public void AddToArticulos(Articulo articulo)
        {
            base.AddObject("Articulos", articulo);
        }

        public void AddToPersonas(Persona persona)
        {
            base.AddObject("Personas", persona);
        }

        public void AddToVehiculos(Vehiculo vehiculo)
        {
            base.AddObject("Vehiculos", vehiculo);
        }

        #endregion
    }
}
