﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AlexBotonePrj
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Fotbal")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertEchipa(Echipa instance);
    partial void UpdateEchipa(Echipa instance);
    partial void DeleteEchipa(Echipa instance);
    partial void InsertJucator(Jucator instance);
    partial void UpdateJucator(Jucator instance);
    partial void DeleteJucator(Jucator instance);
    partial void InsertLiga(Liga instance);
    partial void UpdateLiga(Liga instance);
    partial void DeleteLiga(Liga instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["FotbalConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Echipa> Echipas
		{
			get
			{
				return this.GetTable<Echipa>();
			}
		}
		
		public System.Data.Linq.Table<Jucator> Jucators
		{
			get
			{
				return this.GetTable<Jucator>();
			}
		}
		
		public System.Data.Linq.Table<Liga> Ligas
		{
			get
			{
				return this.GetTable<Liga>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Echipa")]
	public partial class Echipa : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _EchipaId;
		
		private string _Denumire;
		
		private int _Liga;
		
		private EntitySet<Jucator> _Jucators;
		
		private EntityRef<Liga> _Liga1;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnEchipaIdChanging(int value);
    partial void OnEchipaIdChanged();
    partial void OnDenumireChanging(string value);
    partial void OnDenumireChanged();
    partial void OnLigaChanging(int value);
    partial void OnLigaChanged();
    #endregion
		
		public Echipa()
		{
			this._Jucators = new EntitySet<Jucator>(new Action<Jucator>(this.attach_Jucators), new Action<Jucator>(this.detach_Jucators));
			this._Liga1 = default(EntityRef<Liga>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EchipaId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int EchipaId
		{
			get
			{
				return this._EchipaId;
			}
			set
			{
				if ((this._EchipaId != value))
				{
					this.OnEchipaIdChanging(value);
					this.SendPropertyChanging();
					this._EchipaId = value;
					this.SendPropertyChanged("EchipaId");
					this.OnEchipaIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Denumire", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Denumire
		{
			get
			{
				return this._Denumire;
			}
			set
			{
				if ((this._Denumire != value))
				{
					this.OnDenumireChanging(value);
					this.SendPropertyChanging();
					this._Denumire = value;
					this.SendPropertyChanged("Denumire");
					this.OnDenumireChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Liga", DbType="Int NOT NULL")]
		public int Liga
		{
			get
			{
				return this._Liga;
			}
			set
			{
				if ((this._Liga != value))
				{
					if (this._Liga1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnLigaChanging(value);
					this.SendPropertyChanging();
					this._Liga = value;
					this.SendPropertyChanged("Liga");
					this.OnLigaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Echipa_Jucator", Storage="_Jucators", ThisKey="EchipaId", OtherKey="EchipaID")]
		public EntitySet<Jucator> Jucators
		{
			get
			{
				return this._Jucators;
			}
			set
			{
				this._Jucators.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Liga_Echipa", Storage="_Liga1", ThisKey="Liga", OtherKey="LigaId", IsForeignKey=true)]
		public Liga Liga1
		{
			get
			{
				return this._Liga1.Entity;
			}
			set
			{
				Liga previousValue = this._Liga1.Entity;
				if (((previousValue != value) 
							|| (this._Liga1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Liga1.Entity = null;
						previousValue.Echipas.Remove(this);
					}
					this._Liga1.Entity = value;
					if ((value != null))
					{
						value.Echipas.Add(this);
						this._Liga = value.LigaId;
					}
					else
					{
						this._Liga = default(int);
					}
					this.SendPropertyChanged("Liga1");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Jucators(Jucator entity)
		{
			this.SendPropertyChanging();
			entity.Echipa = this;
		}
		
		private void detach_Jucators(Jucator entity)
		{
			this.SendPropertyChanging();
			entity.Echipa = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Jucator")]
	public partial class Jucator : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _JucatorId;
		
		private string _Nume;
		
		private string _Prenume;
		
		private System.Nullable<int> _Varsta;
		
		private int _EchipaID;
		
		private EntityRef<Echipa> _Echipa;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnJucatorIdChanging(int value);
    partial void OnJucatorIdChanged();
    partial void OnNumeChanging(string value);
    partial void OnNumeChanged();
    partial void OnPrenumeChanging(string value);
    partial void OnPrenumeChanged();
    partial void OnVarstaChanging(System.Nullable<int> value);
    partial void OnVarstaChanged();
    partial void OnEchipaIDChanging(int value);
    partial void OnEchipaIDChanged();
    #endregion
		
		public Jucator()
		{
			this._Echipa = default(EntityRef<Echipa>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_JucatorId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int JucatorId
		{
			get
			{
				return this._JucatorId;
			}
			set
			{
				if ((this._JucatorId != value))
				{
					this.OnJucatorIdChanging(value);
					this.SendPropertyChanging();
					this._JucatorId = value;
					this.SendPropertyChanged("JucatorId");
					this.OnJucatorIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nume", DbType="NVarChar(50)")]
		public string Nume
		{
			get
			{
				return this._Nume;
			}
			set
			{
				if ((this._Nume != value))
				{
					this.OnNumeChanging(value);
					this.SendPropertyChanging();
					this._Nume = value;
					this.SendPropertyChanged("Nume");
					this.OnNumeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Prenume", DbType="NVarChar(50)")]
		public string Prenume
		{
			get
			{
				return this._Prenume;
			}
			set
			{
				if ((this._Prenume != value))
				{
					this.OnPrenumeChanging(value);
					this.SendPropertyChanging();
					this._Prenume = value;
					this.SendPropertyChanged("Prenume");
					this.OnPrenumeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Varsta", DbType="Int")]
		public System.Nullable<int> Varsta
		{
			get
			{
				return this._Varsta;
			}
			set
			{
				if ((this._Varsta != value))
				{
					this.OnVarstaChanging(value);
					this.SendPropertyChanging();
					this._Varsta = value;
					this.SendPropertyChanged("Varsta");
					this.OnVarstaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EchipaID", DbType="Int NOT NULL")]
		public int EchipaID
		{
			get
			{
				return this._EchipaID;
			}
			set
			{
				if ((this._EchipaID != value))
				{
					if (this._Echipa.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnEchipaIDChanging(value);
					this.SendPropertyChanging();
					this._EchipaID = value;
					this.SendPropertyChanged("EchipaID");
					this.OnEchipaIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Echipa_Jucator", Storage="_Echipa", ThisKey="EchipaID", OtherKey="EchipaId", IsForeignKey=true)]
		public Echipa Echipa
		{
			get
			{
				return this._Echipa.Entity;
			}
			set
			{
				Echipa previousValue = this._Echipa.Entity;
				if (((previousValue != value) 
							|| (this._Echipa.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Echipa.Entity = null;
						previousValue.Jucators.Remove(this);
					}
					this._Echipa.Entity = value;
					if ((value != null))
					{
						value.Jucators.Add(this);
						this._EchipaID = value.EchipaId;
					}
					else
					{
						this._EchipaID = default(int);
					}
					this.SendPropertyChanged("Echipa");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Liga")]
	public partial class Liga : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _LigaId;
		
		private string _NumeLiga;
		
		private EntitySet<Echipa> _Echipas;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnLigaIdChanging(int value);
    partial void OnLigaIdChanged();
    partial void OnNumeLigaChanging(string value);
    partial void OnNumeLigaChanged();
    #endregion
		
		public Liga()
		{
			this._Echipas = new EntitySet<Echipa>(new Action<Echipa>(this.attach_Echipas), new Action<Echipa>(this.detach_Echipas));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LigaId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int LigaId
		{
			get
			{
				return this._LigaId;
			}
			set
			{
				if ((this._LigaId != value))
				{
					this.OnLigaIdChanging(value);
					this.SendPropertyChanging();
					this._LigaId = value;
					this.SendPropertyChanged("LigaId");
					this.OnLigaIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NumeLiga", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string NumeLiga
		{
			get
			{
				return this._NumeLiga;
			}
			set
			{
				if ((this._NumeLiga != value))
				{
					this.OnNumeLigaChanging(value);
					this.SendPropertyChanging();
					this._NumeLiga = value;
					this.SendPropertyChanged("NumeLiga");
					this.OnNumeLigaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Liga_Echipa", Storage="_Echipas", ThisKey="LigaId", OtherKey="Liga")]
		public EntitySet<Echipa> Echipas
		{
			get
			{
				return this._Echipas;
			}
			set
			{
				this._Echipas.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Echipas(Echipa entity)
		{
			this.SendPropertyChanging();
			entity.Liga1 = this;
		}
		
		private void detach_Echipas(Echipa entity)
		{
			this.SendPropertyChanging();
			entity.Liga1 = null;
		}
	}
}
#pragma warning restore 1591
