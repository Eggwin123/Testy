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

namespace UmbracoWebsites.Data
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="UmbracoCms")]
	public partial class UmbracoDevDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertcmsContentNu(cmsContentNu instance);
    partial void UpdatecmsContentNu(cmsContentNu instance);
    partial void DeletecmsContentNu(cmsContentNu instance);
    #endregion
		
		public UmbracoDevDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["UmbracoDbDSN"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public UmbracoDevDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public UmbracoDevDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public UmbracoDevDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public UmbracoDevDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<cmsContentNu> cmsContentNus
		{
			get
			{
				return this.GetTable<cmsContentNu>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.cmsContentNu")]
	public partial class cmsContentNu : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _nodeId;
		
		private bool _published;
		
		private string _data;
		
		private long _rv;
		
		private System.Data.Linq.Binary _dataRaw;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnnodeIdChanging(int value);
    partial void OnnodeIdChanged();
    partial void OnpublishedChanging(bool value);
    partial void OnpublishedChanged();
    partial void OndataChanging(string value);
    partial void OndataChanged();
    partial void OnrvChanging(long value);
    partial void OnrvChanged();
    partial void OndataRawChanging(System.Data.Linq.Binary value);
    partial void OndataRawChanged();
    #endregion
		
		public cmsContentNu()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nodeId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int nodeId
		{
			get
			{
				return this._nodeId;
			}
			set
			{
				if ((this._nodeId != value))
				{
					this.OnnodeIdChanging(value);
					this.SendPropertyChanging();
					this._nodeId = value;
					this.SendPropertyChanged("nodeId");
					this.OnnodeIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_published", DbType="Bit NOT NULL", IsPrimaryKey=true)]
		public bool published
		{
			get
			{
				return this._published;
			}
			set
			{
				if ((this._published != value))
				{
					this.OnpublishedChanging(value);
					this.SendPropertyChanging();
					this._published = value;
					this.SendPropertyChanged("published");
					this.OnpublishedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_data", DbType="NText", UpdateCheck=UpdateCheck.Never)]
		public string data
		{
			get
			{
				return this._data;
			}
			set
			{
				if ((this._data != value))
				{
					this.OndataChanging(value);
					this.SendPropertyChanging();
					this._data = value;
					this.SendPropertyChanged("data");
					this.OndataChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_rv", DbType="BigInt NOT NULL")]
		public long rv
		{
			get
			{
				return this._rv;
			}
			set
			{
				if ((this._rv != value))
				{
					this.OnrvChanging(value);
					this.SendPropertyChanging();
					this._rv = value;
					this.SendPropertyChanged("rv");
					this.OnrvChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dataRaw", DbType="VarBinary(MAX)", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary dataRaw
		{
			get
			{
				return this._dataRaw;
			}
			set
			{
				if ((this._dataRaw != value))
				{
					this.OndataRawChanging(value);
					this.SendPropertyChanging();
					this._dataRaw = value;
					this.SendPropertyChanged("dataRaw");
					this.OndataRawChanged();
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
