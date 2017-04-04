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

namespace attica_gold.DatabaseContext
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="AtticagoldDB")]
	public partial class BranchDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InserttblBranch(tblBranch instance);
    partial void UpdatetblBranch(tblBranch instance);
    partial void DeletetblBranch(tblBranch instance);
    #endregion
		
		public BranchDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["AtticagoldDB"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public BranchDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BranchDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BranchDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BranchDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<tblBranch> tblBranches
		{
			get
			{
				return this.GetTable<tblBranch>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblBranches")]
	public partial class tblBranch : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _branch_id;
		
		private string _branch_name;
		
		private string _branch_manager_id;
		
		private string _mobile_number;
		
		private string _alter_mobile_number;
		
		private string _street;
		
		private string _state;
		
		private string _city;
		
		private string _pincode;
		
		private System.Nullable<System.DateTime> _createdat;
		
		private System.Nullable<System.DateTime> _modifiedat;
		
		private System.Nullable<System.DateTime> _deletedat;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void Onbranch_idChanging(string value);
    partial void Onbranch_idChanged();
    partial void Onbranch_nameChanging(string value);
    partial void Onbranch_nameChanged();
    partial void Onbranch_manager_idChanging(string value);
    partial void Onbranch_manager_idChanged();
    partial void Onmobile_numberChanging(string value);
    partial void Onmobile_numberChanged();
    partial void Onalter_mobile_numberChanging(string value);
    partial void Onalter_mobile_numberChanged();
    partial void OnstreetChanging(string value);
    partial void OnstreetChanged();
    partial void OnstateChanging(string value);
    partial void OnstateChanged();
    partial void OncityChanging(string value);
    partial void OncityChanged();
    partial void OnpincodeChanging(string value);
    partial void OnpincodeChanged();
    partial void OncreatedatChanging(System.Nullable<System.DateTime> value);
    partial void OncreatedatChanged();
    partial void OnmodifiedatChanging(System.Nullable<System.DateTime> value);
    partial void OnmodifiedatChanged();
    partial void OndeletedatChanging(System.Nullable<System.DateTime> value);
    partial void OndeletedatChanged();
    #endregion
		
		public tblBranch()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_branch_id", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string branch_id
		{
			get
			{
				return this._branch_id;
			}
			set
			{
				if ((this._branch_id != value))
				{
					this.Onbranch_idChanging(value);
					this.SendPropertyChanging();
					this._branch_id = value;
					this.SendPropertyChanged("branch_id");
					this.Onbranch_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_branch_name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string branch_name
		{
			get
			{
				return this._branch_name;
			}
			set
			{
				if ((this._branch_name != value))
				{
					this.Onbranch_nameChanging(value);
					this.SendPropertyChanging();
					this._branch_name = value;
					this.SendPropertyChanged("branch_name");
					this.Onbranch_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_branch_manager_id", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string branch_manager_id
		{
			get
			{
				return this._branch_manager_id;
			}
			set
			{
				if ((this._branch_manager_id != value))
				{
					this.Onbranch_manager_idChanging(value);
					this.SendPropertyChanging();
					this._branch_manager_id = value;
					this.SendPropertyChanged("branch_manager_id");
					this.Onbranch_manager_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mobile_number", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string mobile_number
		{
			get
			{
				return this._mobile_number;
			}
			set
			{
				if ((this._mobile_number != value))
				{
					this.Onmobile_numberChanging(value);
					this.SendPropertyChanging();
					this._mobile_number = value;
					this.SendPropertyChanged("mobile_number");
					this.Onmobile_numberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_alter_mobile_number", DbType="VarChar(10)")]
		public string alter_mobile_number
		{
			get
			{
				return this._alter_mobile_number;
			}
			set
			{
				if ((this._alter_mobile_number != value))
				{
					this.Onalter_mobile_numberChanging(value);
					this.SendPropertyChanging();
					this._alter_mobile_number = value;
					this.SendPropertyChanged("alter_mobile_number");
					this.Onalter_mobile_numberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_street", DbType="NVarChar(50)")]
		public string street
		{
			get
			{
				return this._street;
			}
			set
			{
				if ((this._street != value))
				{
					this.OnstreetChanging(value);
					this.SendPropertyChanging();
					this._street = value;
					this.SendPropertyChanged("street");
					this.OnstreetChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_state", DbType="NVarChar(50)")]
		public string state
		{
			get
			{
				return this._state;
			}
			set
			{
				if ((this._state != value))
				{
					this.OnstateChanging(value);
					this.SendPropertyChanging();
					this._state = value;
					this.SendPropertyChanged("state");
					this.OnstateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_city", DbType="NVarChar(50)")]
		public string city
		{
			get
			{
				return this._city;
			}
			set
			{
				if ((this._city != value))
				{
					this.OncityChanging(value);
					this.SendPropertyChanging();
					this._city = value;
					this.SendPropertyChanged("city");
					this.OncityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pincode", DbType="NVarChar(50)")]
		public string pincode
		{
			get
			{
				return this._pincode;
			}
			set
			{
				if ((this._pincode != value))
				{
					this.OnpincodeChanging(value);
					this.SendPropertyChanging();
					this._pincode = value;
					this.SendPropertyChanged("pincode");
					this.OnpincodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_createdat", DbType="DateTime")]
		public System.Nullable<System.DateTime> createdat
		{
			get
			{
				return this._createdat;
			}
			set
			{
				if ((this._createdat != value))
				{
					this.OncreatedatChanging(value);
					this.SendPropertyChanging();
					this._createdat = value;
					this.SendPropertyChanged("createdat");
					this.OncreatedatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_modifiedat", DbType="DateTime")]
		public System.Nullable<System.DateTime> modifiedat
		{
			get
			{
				return this._modifiedat;
			}
			set
			{
				if ((this._modifiedat != value))
				{
					this.OnmodifiedatChanging(value);
					this.SendPropertyChanging();
					this._modifiedat = value;
					this.SendPropertyChanged("modifiedat");
					this.OnmodifiedatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_deletedat", DbType="DateTime")]
		public System.Nullable<System.DateTime> deletedat
		{
			get
			{
				return this._deletedat;
			}
			set
			{
				if ((this._deletedat != value))
				{
					this.OndeletedatChanging(value);
					this.SendPropertyChanging();
					this._deletedat = value;
					this.SendPropertyChanged("deletedat");
					this.OndeletedatChanged();
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
