﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FerieFravaerIndberetning.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="FeriefravaerDB")]
	public partial class FerieFravaerDBClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertIndberetningstype(Indberetningstype instance);
    partial void UpdateIndberetningstype(Indberetningstype instance);
    partial void DeleteIndberetningstype(Indberetningstype instance);
    partial void InsertArbejdsugeTimer(ArbejdsugeTimer instance);
    partial void UpdateArbejdsugeTimer(ArbejdsugeTimer instance);
    partial void DeleteArbejdsugeTimer(ArbejdsugeTimer instance);
    partial void InsertFravaer(Fravaer instance);
    partial void UpdateFravaer(Fravaer instance);
    partial void DeleteFravaer(Fravaer instance);
    partial void InsertFerie(Ferie instance);
    partial void UpdateFerie(Ferie instance);
    partial void DeleteFerie(Ferie instance);
    #endregion
		
		public FerieFravaerDBClassesDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["FeriefravaerDBConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public FerieFravaerDBClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public FerieFravaerDBClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public FerieFravaerDBClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public FerieFravaerDBClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Indberetningstype> Indberetningstypes
		{
			get
			{
				return this.GetTable<Indberetningstype>();
			}
		}
		
		public System.Data.Linq.Table<ArbejdsugeTimer> ArbejdsugeTimers
		{
			get
			{
				return this.GetTable<ArbejdsugeTimer>();
			}
		}
		
		public System.Data.Linq.Table<Fravaer> Fravaers
		{
			get
			{
				return this.GetTable<Fravaer>();
			}
		}
		
		public System.Data.Linq.Table<Ferie> Feries
		{
			get
			{
				return this.GetTable<Ferie>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Indberetningstype")]
	public partial class Indberetningstype : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Id;
		
		private string _Navn;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(string value);
    partial void OnIdChanged();
    partial void OnNavnChanging(string value);
    partial void OnNavnChanged();
    #endregion
		
		public Indberetningstype()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="NChar(5) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Navn", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string Navn
		{
			get
			{
				return this._Navn;
			}
			set
			{
				if ((this._Navn != value))
				{
					this.OnNavnChanging(value);
					this.SendPropertyChanging();
					this._Navn = value;
					this.SendPropertyChanged("Navn");
					this.OnNavnChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ArbejdsugeTimer")]
	public partial class ArbejdsugeTimer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _WeekId;
		
		private double _Mandag;
		
		private double _Tirsdag;
		
		private double _Onsdag;
		
		private double _Torsdag;
		
		private double _Fredag;
		
		private System.Nullable<double> _Loerdag;
		
		private System.Nullable<double> _Soendag;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnWeekIdChanging(int value);
    partial void OnWeekIdChanged();
    partial void OnMandagChanging(double value);
    partial void OnMandagChanged();
    partial void OnTirsdagChanging(double value);
    partial void OnTirsdagChanged();
    partial void OnOnsdagChanging(double value);
    partial void OnOnsdagChanged();
    partial void OnTorsdagChanging(double value);
    partial void OnTorsdagChanged();
    partial void OnFredagChanging(double value);
    partial void OnFredagChanged();
    partial void OnLoerdagChanging(System.Nullable<double> value);
    partial void OnLoerdagChanged();
    partial void OnSoendagChanging(System.Nullable<double> value);
    partial void OnSoendagChanged();
    #endregion
		
		public ArbejdsugeTimer()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WeekId", DbType="Int NOT NULL")]
		public int WeekId
		{
			get
			{
				return this._WeekId;
			}
			set
			{
				if ((this._WeekId != value))
				{
					this.OnWeekIdChanging(value);
					this.SendPropertyChanging();
					this._WeekId = value;
					this.SendPropertyChanged("WeekId");
					this.OnWeekIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mandag", DbType="Float NOT NULL")]
		public double Mandag
		{
			get
			{
				return this._Mandag;
			}
			set
			{
				if ((this._Mandag != value))
				{
					this.OnMandagChanging(value);
					this.SendPropertyChanging();
					this._Mandag = value;
					this.SendPropertyChanged("Mandag");
					this.OnMandagChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tirsdag", DbType="Float NOT NULL")]
		public double Tirsdag
		{
			get
			{
				return this._Tirsdag;
			}
			set
			{
				if ((this._Tirsdag != value))
				{
					this.OnTirsdagChanging(value);
					this.SendPropertyChanging();
					this._Tirsdag = value;
					this.SendPropertyChanged("Tirsdag");
					this.OnTirsdagChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Onsdag", DbType="Float NOT NULL")]
		public double Onsdag
		{
			get
			{
				return this._Onsdag;
			}
			set
			{
				if ((this._Onsdag != value))
				{
					this.OnOnsdagChanging(value);
					this.SendPropertyChanging();
					this._Onsdag = value;
					this.SendPropertyChanged("Onsdag");
					this.OnOnsdagChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Torsdag", DbType="Float NOT NULL")]
		public double Torsdag
		{
			get
			{
				return this._Torsdag;
			}
			set
			{
				if ((this._Torsdag != value))
				{
					this.OnTorsdagChanging(value);
					this.SendPropertyChanging();
					this._Torsdag = value;
					this.SendPropertyChanged("Torsdag");
					this.OnTorsdagChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fredag", DbType="Float NOT NULL")]
		public double Fredag
		{
			get
			{
				return this._Fredag;
			}
			set
			{
				if ((this._Fredag != value))
				{
					this.OnFredagChanging(value);
					this.SendPropertyChanging();
					this._Fredag = value;
					this.SendPropertyChanged("Fredag");
					this.OnFredagChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Loerdag", DbType="Float")]
		public System.Nullable<double> Loerdag
		{
			get
			{
				return this._Loerdag;
			}
			set
			{
				if ((this._Loerdag != value))
				{
					this.OnLoerdagChanging(value);
					this.SendPropertyChanging();
					this._Loerdag = value;
					this.SendPropertyChanged("Loerdag");
					this.OnLoerdagChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Soendag", DbType="Float")]
		public System.Nullable<double> Soendag
		{
			get
			{
				return this._Soendag;
			}
			set
			{
				if ((this._Soendag != value))
				{
					this.OnSoendagChanging(value);
					this.SendPropertyChanging();
					this._Soendag = value;
					this.SendPropertyChanged("Soendag");
					this.OnSoendagChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Fravaer")]
	public partial class Fravaer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _MedarbejderId;
		
		private System.Nullable<System.DateTime> _FoersteFravaersdag;
		
		private System.Nullable<System.DateTime> _SidsteFravaersdag;
		
		private bool _Godkendt;
		
		private bool _Afvist;
		
		private bool _Indberettet;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnMedarbejderIdChanging(int value);
    partial void OnMedarbejderIdChanged();
    partial void OnFoersteFravaersdagChanging(System.Nullable<System.DateTime> value);
    partial void OnFoersteFravaersdagChanged();
    partial void OnSidsteFravaersdagChanging(System.Nullable<System.DateTime> value);
    partial void OnSidsteFravaersdagChanged();
    partial void OnGodkendtChanging(bool value);
    partial void OnGodkendtChanged();
    partial void OnAfvistChanging(bool value);
    partial void OnAfvistChanged();
    partial void OnIndberettetChanging(bool value);
    partial void OnIndberettetChanged();
    #endregion
		
		public Fravaer()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MedarbejderId", DbType="Int NOT NULL")]
		public int MedarbejderId
		{
			get
			{
				return this._MedarbejderId;
			}
			set
			{
				if ((this._MedarbejderId != value))
				{
					this.OnMedarbejderIdChanging(value);
					this.SendPropertyChanging();
					this._MedarbejderId = value;
					this.SendPropertyChanged("MedarbejderId");
					this.OnMedarbejderIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FoersteFravaersdag", DbType="DateTime2")]
		public System.Nullable<System.DateTime> FoersteFravaersdag
		{
			get
			{
				return this._FoersteFravaersdag;
			}
			set
			{
				if ((this._FoersteFravaersdag != value))
				{
					this.OnFoersteFravaersdagChanging(value);
					this.SendPropertyChanging();
					this._FoersteFravaersdag = value;
					this.SendPropertyChanged("FoersteFravaersdag");
					this.OnFoersteFravaersdagChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SidsteFravaersdag", DbType="DateTime2")]
		public System.Nullable<System.DateTime> SidsteFravaersdag
		{
			get
			{
				return this._SidsteFravaersdag;
			}
			set
			{
				if ((this._SidsteFravaersdag != value))
				{
					this.OnSidsteFravaersdagChanging(value);
					this.SendPropertyChanging();
					this._SidsteFravaersdag = value;
					this.SendPropertyChanged("SidsteFravaersdag");
					this.OnSidsteFravaersdagChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Godkendt", DbType="Bit NOT NULL")]
		public bool Godkendt
		{
			get
			{
				return this._Godkendt;
			}
			set
			{
				if ((this._Godkendt != value))
				{
					this.OnGodkendtChanging(value);
					this.SendPropertyChanging();
					this._Godkendt = value;
					this.SendPropertyChanged("Godkendt");
					this.OnGodkendtChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Afvist", DbType="Bit NOT NULL")]
		public bool Afvist
		{
			get
			{
				return this._Afvist;
			}
			set
			{
				if ((this._Afvist != value))
				{
					this.OnAfvistChanging(value);
					this.SendPropertyChanging();
					this._Afvist = value;
					this.SendPropertyChanged("Afvist");
					this.OnAfvistChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Indberettet", DbType="Bit NOT NULL")]
		public bool Indberettet
		{
			get
			{
				return this._Indberettet;
			}
			set
			{
				if ((this._Indberettet != value))
				{
					this.OnIndberettetChanging(value);
					this.SendPropertyChanging();
					this._Indberettet = value;
					this.SendPropertyChanged("Indberettet");
					this.OnIndberettetChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Ferie")]
	public partial class Ferie : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _MedarbejderId;
		
		private System.DateTime _FoersteFeriedag;
		
		private System.DateTime _SidsteFeriedag;
		
		private bool _FerieLoen;
		
		private bool _Godkendt;
		
		private bool _Afvist;
		
		private bool _Indberettet;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnMedarbejderIdChanging(int value);
    partial void OnMedarbejderIdChanged();
    partial void OnFoersteFeriedagChanging(System.DateTime value);
    partial void OnFoersteFeriedagChanged();
    partial void OnSidsteFeriedagChanging(System.DateTime value);
    partial void OnSidsteFeriedagChanged();
    partial void OnFerieLoenChanging(bool value);
    partial void OnFerieLoenChanged();
    partial void OnGodkendtChanging(bool value);
    partial void OnGodkendtChanged();
    partial void OnAfvistChanging(bool value);
    partial void OnAfvistChanged();
    partial void OnIndberettetChanging(bool value);
    partial void OnIndberettetChanged();
    #endregion
		
		public Ferie()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MedarbejderId", DbType="Int NOT NULL")]
		public int MedarbejderId
		{
			get
			{
				return this._MedarbejderId;
			}
			set
			{
				if ((this._MedarbejderId != value))
				{
					this.OnMedarbejderIdChanging(value);
					this.SendPropertyChanging();
					this._MedarbejderId = value;
					this.SendPropertyChanged("MedarbejderId");
					this.OnMedarbejderIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FoersteFeriedag", DbType="Date NOT NULL")]
		public System.DateTime FoersteFeriedag
		{
			get
			{
				return this._FoersteFeriedag;
			}
			set
			{
				if ((this._FoersteFeriedag != value))
				{
					this.OnFoersteFeriedagChanging(value);
					this.SendPropertyChanging();
					this._FoersteFeriedag = value;
					this.SendPropertyChanged("FoersteFeriedag");
					this.OnFoersteFeriedagChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SidsteFeriedag", DbType="Date NOT NULL")]
		public System.DateTime SidsteFeriedag
		{
			get
			{
				return this._SidsteFeriedag;
			}
			set
			{
				if ((this._SidsteFeriedag != value))
				{
					this.OnSidsteFeriedagChanging(value);
					this.SendPropertyChanging();
					this._SidsteFeriedag = value;
					this.SendPropertyChanged("SidsteFeriedag");
					this.OnSidsteFeriedagChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FerieLoen", DbType="Bit NOT NULL")]
		public bool FerieLoen
		{
			get
			{
				return this._FerieLoen;
			}
			set
			{
				if ((this._FerieLoen != value))
				{
					this.OnFerieLoenChanging(value);
					this.SendPropertyChanging();
					this._FerieLoen = value;
					this.SendPropertyChanged("FerieLoen");
					this.OnFerieLoenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Godkendt", DbType="Bit NOT NULL")]
		public bool Godkendt
		{
			get
			{
				return this._Godkendt;
			}
			set
			{
				if ((this._Godkendt != value))
				{
					this.OnGodkendtChanging(value);
					this.SendPropertyChanging();
					this._Godkendt = value;
					this.SendPropertyChanged("Godkendt");
					this.OnGodkendtChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Afvist", DbType="Bit NOT NULL")]
		public bool Afvist
		{
			get
			{
				return this._Afvist;
			}
			set
			{
				if ((this._Afvist != value))
				{
					this.OnAfvistChanging(value);
					this.SendPropertyChanging();
					this._Afvist = value;
					this.SendPropertyChanged("Afvist");
					this.OnAfvistChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Indberettet", DbType="Bit NOT NULL")]
		public bool Indberettet
		{
			get
			{
				return this._Indberettet;
			}
			set
			{
				if ((this._Indberettet != value))
				{
					this.OnIndberettetChanging(value);
					this.SendPropertyChanging();
					this._Indberettet = value;
					this.SendPropertyChanged("Indberettet");
					this.OnIndberettetChanged();
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
}
#pragma warning restore 1591
