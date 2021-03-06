﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApplication1
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="ReportServer")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region 可扩展性方法定义
    partial void OnCreated();
    partial void InsertUsers(Users instance);
    partial void UpdateUsers(Users instance);
    partial void DeleteUsers(Users instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::ConsoleApplication1.Properties.Settings.Default.ReportServerConnectionString, mappingSource)
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
		
		public System.Data.Linq.Table<Users> Users
		{
			get
			{
				return this.GetTable<Users>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Users")]
	public partial class Users : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _UserID;
		
		private System.Data.Linq.Binary _Sid;
		
		private int _UserType;
		
		private int _AuthType;
		
		private string _UserName;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserIDChanging(System.Guid value);
    partial void OnUserIDChanged();
    partial void OnSidChanging(System.Data.Linq.Binary value);
    partial void OnSidChanged();
    partial void OnUserTypeChanging(int value);
    partial void OnUserTypeChanged();
    partial void OnAuthTypeChanging(int value);
    partial void OnAuthTypeChanged();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    #endregion
		
		public Users()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid UserID
		{
			get
			{
				return this._UserID;
			}
			set
			{
				if ((this._UserID != value))
				{
					this.OnUserIDChanging(value);
					this.SendPropertyChanging();
					this._UserID = value;
					this.SendPropertyChanged("UserID");
					this.OnUserIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sid", DbType="VarBinary(85)", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary Sid
		{
			get
			{
				return this._Sid;
			}
			set
			{
				if ((this._Sid != value))
				{
					this.OnSidChanging(value);
					this.SendPropertyChanging();
					this._Sid = value;
					this.SendPropertyChanged("Sid");
					this.OnSidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserType", DbType="Int NOT NULL")]
		public int UserType
		{
			get
			{
				return this._UserType;
			}
			set
			{
				if ((this._UserType != value))
				{
					this.OnUserTypeChanging(value);
					this.SendPropertyChanging();
					this._UserType = value;
					this.SendPropertyChanged("UserType");
					this.OnUserTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AuthType", DbType="Int NOT NULL")]
		public int AuthType
		{
			get
			{
				return this._AuthType;
			}
			set
			{
				if ((this._AuthType != value))
				{
					this.OnAuthTypeChanging(value);
					this.SendPropertyChanging();
					this._AuthType = value;
					this.SendPropertyChanged("AuthType");
					this.OnAuthTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="NVarChar(260)")]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				if ((this._UserName != value))
				{
					this.OnUserNameChanging(value);
					this.SendPropertyChanging();
					this._UserName = value;
					this.SendPropertyChanged("UserName");
					this.OnUserNameChanged();
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
	
	public partial class History : Users
	{
		
		private System.Guid _HistoryID;
		
		private System.Guid _ReportID;
		
		private System.Guid _SnapshotDataID;
		
		private System.DateTime _SnapshotDate;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnHistoryIDChanging(System.Guid value);
    partial void OnHistoryIDChanged();
    partial void OnReportIDChanging(System.Guid value);
    partial void OnReportIDChanged();
    partial void OnSnapshotDataIDChanging(System.Guid value);
    partial void OnSnapshotDataIDChanged();
    partial void OnSnapshotDateChanging(System.DateTime value);
    partial void OnSnapshotDateChanged();
    #endregion
		
		public History()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HistoryID", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid HistoryID
		{
			get
			{
				return this._HistoryID;
			}
			set
			{
				if ((this._HistoryID != value))
				{
					this.OnHistoryIDChanging(value);
					this.SendPropertyChanging();
					this._HistoryID = value;
					this.SendPropertyChanged("HistoryID");
					this.OnHistoryIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReportID", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid ReportID
		{
			get
			{
				return this._ReportID;
			}
			set
			{
				if ((this._ReportID != value))
				{
					this.OnReportIDChanging(value);
					this.SendPropertyChanging();
					this._ReportID = value;
					this.SendPropertyChanged("ReportID");
					this.OnReportIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SnapshotDataID", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid SnapshotDataID
		{
			get
			{
				return this._SnapshotDataID;
			}
			set
			{
				if ((this._SnapshotDataID != value))
				{
					this.OnSnapshotDataIDChanging(value);
					this.SendPropertyChanging();
					this._SnapshotDataID = value;
					this.SendPropertyChanged("SnapshotDataID");
					this.OnSnapshotDataIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SnapshotDate", DbType="DateTime NOT NULL")]
		public System.DateTime SnapshotDate
		{
			get
			{
				return this._SnapshotDate;
			}
			set
			{
				if ((this._SnapshotDate != value))
				{
					this.OnSnapshotDateChanging(value);
					this.SendPropertyChanging();
					this._SnapshotDate = value;
					this.SendPropertyChanged("SnapshotDate");
					this.OnSnapshotDateChanged();
				}
			}
		}
	}
	
	public partial class Batch : History
	{
		
		private System.Guid _BatchID;
		
		private System.DateTime _AddedOn;
		
		private string _Action;
		
		private string _Item;
		
		private string _Parent;
		
		private string _Param;
		
		private System.Nullable<bool> _BoolParam;
		
		private System.Data.Linq.Binary _Content;
		
		private string _Properties;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnBatchIDChanging(System.Guid value);
    partial void OnBatchIDChanged();
    partial void OnAddedOnChanging(System.DateTime value);
    partial void OnAddedOnChanged();
    partial void OnActionChanging(string value);
    partial void OnActionChanged();
    partial void OnItemChanging(string value);
    partial void OnItemChanged();
    partial void OnParentChanging(string value);
    partial void OnParentChanged();
    partial void OnParamChanging(string value);
    partial void OnParamChanged();
    partial void OnBoolParamChanging(System.Nullable<bool> value);
    partial void OnBoolParamChanged();
    partial void OnContentChanging(System.Data.Linq.Binary value);
    partial void OnContentChanged();
    partial void OnPropertiesChanging(string value);
    partial void OnPropertiesChanged();
    #endregion
		
		public Batch()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BatchID", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid BatchID
		{
			get
			{
				return this._BatchID;
			}
			set
			{
				if ((this._BatchID != value))
				{
					this.OnBatchIDChanging(value);
					this.SendPropertyChanging();
					this._BatchID = value;
					this.SendPropertyChanged("BatchID");
					this.OnBatchIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AddedOn", DbType="DateTime NOT NULL")]
		public System.DateTime AddedOn
		{
			get
			{
				return this._AddedOn;
			}
			set
			{
				if ((this._AddedOn != value))
				{
					this.OnAddedOnChanging(value);
					this.SendPropertyChanging();
					this._AddedOn = value;
					this.SendPropertyChanged("AddedOn");
					this.OnAddedOnChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Action", DbType="VarChar(32) NOT NULL", CanBeNull=false)]
		public string Action
		{
			get
			{
				return this._Action;
			}
			set
			{
				if ((this._Action != value))
				{
					this.OnActionChanging(value);
					this.SendPropertyChanging();
					this._Action = value;
					this.SendPropertyChanged("Action");
					this.OnActionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Item", DbType="NVarChar(425)")]
		public string Item
		{
			get
			{
				return this._Item;
			}
			set
			{
				if ((this._Item != value))
				{
					this.OnItemChanging(value);
					this.SendPropertyChanging();
					this._Item = value;
					this.SendPropertyChanged("Item");
					this.OnItemChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Parent", DbType="NVarChar(425)")]
		public string Parent
		{
			get
			{
				return this._Parent;
			}
			set
			{
				if ((this._Parent != value))
				{
					this.OnParentChanging(value);
					this.SendPropertyChanging();
					this._Parent = value;
					this.SendPropertyChanged("Parent");
					this.OnParentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Param", DbType="NVarChar(425)")]
		public string Param
		{
			get
			{
				return this._Param;
			}
			set
			{
				if ((this._Param != value))
				{
					this.OnParamChanging(value);
					this.SendPropertyChanging();
					this._Param = value;
					this.SendPropertyChanged("Param");
					this.OnParamChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BoolParam", DbType="Bit")]
		public System.Nullable<bool> BoolParam
		{
			get
			{
				return this._BoolParam;
			}
			set
			{
				if ((this._BoolParam != value))
				{
					this.OnBoolParamChanging(value);
					this.SendPropertyChanging();
					this._BoolParam = value;
					this.SendPropertyChanged("BoolParam");
					this.OnBoolParamChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Content", DbType="Image", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary Content
		{
			get
			{
				return this._Content;
			}
			set
			{
				if ((this._Content != value))
				{
					this.OnContentChanging(value);
					this.SendPropertyChanging();
					this._Content = value;
					this.SendPropertyChanged("Content");
					this.OnContentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Properties", DbType="NText", UpdateCheck=UpdateCheck.Never)]
		public string Properties
		{
			get
			{
				return this._Properties;
			}
			set
			{
				if ((this._Properties != value))
				{
					this.OnPropertiesChanging(value);
					this.SendPropertyChanging();
					this._Properties = value;
					this.SendPropertyChanged("Properties");
					this.OnPropertiesChanged();
				}
			}
		}
	}
	
	public partial class Class1 : Batch
	{
		
		protected int _id;
		
		protected System.Data.Linq.Link<string> _text;
		
		private EntityRef<Class2> _Class2;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OntextChanging(string value);
    partial void OntextChanged();
    #endregion
		
		public Class1()
		{
			this._Class2 = default(EntityRef<Class2>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					if (this._Class2.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_text", CanBeNull=false)]
		public string Text
		{
			get
			{
				return this._text.Value;
			}
			set
			{
				if ((this._text.Value != value))
				{
					if (this._Class2.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OntextChanging(value);
					this.SendPropertyChanging();
					this._text.Value = value;
					this.SendPropertyChanged("text");
					this.OntextChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Class2_Class1", Storage="_Class2", ThisKey="id,text", OtherKey="id,text", IsForeignKey=true)]
		public Class2 Class2
		{
			get
			{
				return this._Class2.Entity;
			}
			set
			{
				Class2 previousValue = this._Class2.Entity;
				if (((previousValue != value) 
							|| (this._Class2.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Class2.Entity = null;
						previousValue.Class1.Remove(this);
					}
					this._Class2.Entity = value;
					if ((value != null))
					{
						value.Class1.Add(this);
						this._id = value.id;
						this._text.Value = value.text;
					}
					else
					{
						this._id = default(int);
						this._text.Value = default(string);
					}
					this.SendPropertyChanged("Class2");
				}
			}
		}
	}
	
	public partial class Class2 : Class1
	{

        private new int _id;

        private new System.Data.Linq.Link<string> _text;

        private EntitySet<Class1> _Class1;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OntextChanging(string value);
    partial void OntextChanged();
    #endregion
		
		public Class2()
		{
			this._Class1 = new EntitySet<Class1>(new Action<Class1>(this.attach_Class1), new Action<Class1>(this.detach_Class1));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnUpdate, IsDbGenerated=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_text", CanBeNull=false)]
		public string text
		{
			get
			{
				return this._text.Value;
			}
			set
			{
				if ((this._text.Value != value))
				{
					this.OntextChanging(value);
					this.SendPropertyChanging();
					this._text.Value = value;
					this.SendPropertyChanged("text");
					this.OntextChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Class2_Class1", Storage="_Class1", ThisKey="id,text", OtherKey="id,text")]
		public EntitySet<Class1> Class1
		{
			get
			{
				return this._Class1;
			}
			set
			{
				this._Class1.Assign(value);
			}
		}
		
		private void attach_Class1(Class1 entity)
		{
			this.SendPropertyChanging();
			entity.Class2 = this;
		}
		
		private void detach_Class1(Class1 entity)
		{
			this.SendPropertyChanging();
			entity.Class2 = null;
		}
	}
}
#pragma warning restore 1591
