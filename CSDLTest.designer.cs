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

namespace FindAndSort04
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="LinQToSQL")]
	public partial class CSDLTestDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertDanhMuc(DanhMuc instance);
    partial void UpdateDanhMuc(DanhMuc instance);
    partial void DeleteDanhMuc(DanhMuc instance);
    partial void InsertSanPham(SanPham instance);
    partial void UpdateSanPham(SanPham instance);
    partial void DeleteSanPham(SanPham instance);
    #endregion
		
		public CSDLTestDataContext() : 
				base(global::FindAndSort04.Properties.Settings.Default.LinQToSQLConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public CSDLTestDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CSDLTestDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CSDLTestDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CSDLTestDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<DanhMuc> DanhMucs
		{
			get
			{
				return this.GetTable<DanhMuc>();
			}
		}
		
		public System.Data.Linq.Table<SanPham> SanPhams
		{
			get
			{
				return this.GetTable<SanPham>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.DeleteProduct")]
		public int DeleteProduct([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="TinyInt")] System.Nullable<byte> maSP)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), maSP);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.UpdateCostProduct")]
		public int UpdateCostProduct([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="TinyInt")] System.Nullable<byte> maSP, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Float")] System.Nullable<double> donGia)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), maSP, donGia);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.DetailProduct")]
		public ISingleResult<DetailProductResult> DetailProduct([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="TinyInt")] System.Nullable<byte> maSP)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), maSP);
			return ((ISingleResult<DetailProductResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.InsertProduct")]
		public int InsertProduct([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="TinyInt")] System.Nullable<byte> maSP, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(255)")] string tenSP, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Float")] System.Nullable<double> donGia, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="TinyInt")] System.Nullable<byte> maDanhMuc)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), maSP, tenSP, donGia, maDanhMuc);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.TakeAllProduct")]
		public ISingleResult<TakeAllProductResult> TakeAllProduct()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<TakeAllProductResult>)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DanhMuc")]
	public partial class DanhMuc : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private byte _MaDanhMuc;
		
		private string _TenDanhMuc;
		
		private EntitySet<SanPham> _SanPhams;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaDanhMucChanging(byte value);
    partial void OnMaDanhMucChanged();
    partial void OnTenDanhMucChanging(string value);
    partial void OnTenDanhMucChanged();
    #endregion
		
		public DanhMuc()
		{
			this._SanPhams = new EntitySet<SanPham>(new Action<SanPham>(this.attach_SanPhams), new Action<SanPham>(this.detach_SanPhams));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDanhMuc", DbType="TinyInt NOT NULL", IsPrimaryKey=true)]
		public byte MaDanhMuc
		{
			get
			{
				return this._MaDanhMuc;
			}
			set
			{
				if ((this._MaDanhMuc != value))
				{
					this.OnMaDanhMucChanging(value);
					this.SendPropertyChanging();
					this._MaDanhMuc = value;
					this.SendPropertyChanged("MaDanhMuc");
					this.OnMaDanhMucChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenDanhMuc", DbType="NVarChar(255)")]
		public string TenDanhMuc
		{
			get
			{
				return this._TenDanhMuc;
			}
			set
			{
				if ((this._TenDanhMuc != value))
				{
					this.OnTenDanhMucChanging(value);
					this.SendPropertyChanging();
					this._TenDanhMuc = value;
					this.SendPropertyChanged("TenDanhMuc");
					this.OnTenDanhMucChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DanhMuc_SanPham", Storage="_SanPhams", ThisKey="MaDanhMuc", OtherKey="MaDanhMuc")]
		public EntitySet<SanPham> SanPhams
		{
			get
			{
				return this._SanPhams;
			}
			set
			{
				this._SanPhams.Assign(value);
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
		
		private void attach_SanPhams(SanPham entity)
		{
			this.SendPropertyChanging();
			entity.DanhMuc = this;
		}
		
		private void detach_SanPhams(SanPham entity)
		{
			this.SendPropertyChanging();
			entity.DanhMuc = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SanPham")]
	public partial class SanPham : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private byte _MaSP;
		
		private string _TenSP;
		
		private System.Nullable<double> _DonGia;
		
		private byte _MaDanhMuc;
		
		private EntityRef<DanhMuc> _DanhMuc;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaSPChanging(byte value);
    partial void OnMaSPChanged();
    partial void OnTenSPChanging(string value);
    partial void OnTenSPChanged();
    partial void OnDonGiaChanging(System.Nullable<double> value);
    partial void OnDonGiaChanged();
    partial void OnMaDanhMucChanging(byte value);
    partial void OnMaDanhMucChanged();
    #endregion
		
		public SanPham()
		{
			this._DanhMuc = default(EntityRef<DanhMuc>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSP", DbType="TinyInt NOT NULL", IsPrimaryKey=true)]
		public byte MaSP
		{
			get
			{
				return this._MaSP;
			}
			set
			{
				if ((this._MaSP != value))
				{
					this.OnMaSPChanging(value);
					this.SendPropertyChanging();
					this._MaSP = value;
					this.SendPropertyChanged("MaSP");
					this.OnMaSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenSP", DbType="NVarChar(255)")]
		public string TenSP
		{
			get
			{
				return this._TenSP;
			}
			set
			{
				if ((this._TenSP != value))
				{
					this.OnTenSPChanging(value);
					this.SendPropertyChanging();
					this._TenSP = value;
					this.SendPropertyChanged("TenSP");
					this.OnTenSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DonGia", DbType="Float")]
		public System.Nullable<double> DonGia
		{
			get
			{
				return this._DonGia;
			}
			set
			{
				if ((this._DonGia != value))
				{
					this.OnDonGiaChanging(value);
					this.SendPropertyChanging();
					this._DonGia = value;
					this.SendPropertyChanged("DonGia");
					this.OnDonGiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDanhMuc", DbType="TinyInt NOT NULL")]
		public byte MaDanhMuc
		{
			get
			{
				return this._MaDanhMuc;
			}
			set
			{
				if ((this._MaDanhMuc != value))
				{
					if (this._DanhMuc.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaDanhMucChanging(value);
					this.SendPropertyChanging();
					this._MaDanhMuc = value;
					this.SendPropertyChanged("MaDanhMuc");
					this.OnMaDanhMucChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DanhMuc_SanPham", Storage="_DanhMuc", ThisKey="MaDanhMuc", OtherKey="MaDanhMuc", IsForeignKey=true)]
		public DanhMuc DanhMuc
		{
			get
			{
				return this._DanhMuc.Entity;
			}
			set
			{
				DanhMuc previousValue = this._DanhMuc.Entity;
				if (((previousValue != value) 
							|| (this._DanhMuc.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._DanhMuc.Entity = null;
						previousValue.SanPhams.Remove(this);
					}
					this._DanhMuc.Entity = value;
					if ((value != null))
					{
						value.SanPhams.Add(this);
						this._MaDanhMuc = value.MaDanhMuc;
					}
					else
					{
						this._MaDanhMuc = default(byte);
					}
					this.SendPropertyChanged("DanhMuc");
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
	
	public partial class DetailProductResult
	{
		
		private byte _MaSP;
		
		private string _TenSP;
		
		private System.Nullable<double> _DonGia;
		
		private byte _MaDanhMuc;
		
		private string _TenDanhMuc;
		
		public DetailProductResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSP", DbType="TinyInt NOT NULL")]
		public byte MaSP
		{
			get
			{
				return this._MaSP;
			}
			set
			{
				if ((this._MaSP != value))
				{
					this._MaSP = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenSP", DbType="NVarChar(255)")]
		public string TenSP
		{
			get
			{
				return this._TenSP;
			}
			set
			{
				if ((this._TenSP != value))
				{
					this._TenSP = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DonGia", DbType="Float")]
		public System.Nullable<double> DonGia
		{
			get
			{
				return this._DonGia;
			}
			set
			{
				if ((this._DonGia != value))
				{
					this._DonGia = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDanhMuc", DbType="TinyInt NOT NULL")]
		public byte MaDanhMuc
		{
			get
			{
				return this._MaDanhMuc;
			}
			set
			{
				if ((this._MaDanhMuc != value))
				{
					this._MaDanhMuc = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenDanhMuc", DbType="NVarChar(255)")]
		public string TenDanhMuc
		{
			get
			{
				return this._TenDanhMuc;
			}
			set
			{
				if ((this._TenDanhMuc != value))
				{
					this._TenDanhMuc = value;
				}
			}
		}
	}
	
	public partial class TakeAllProductResult
	{
		
		private byte _MaSP;
		
		private string _TenSP;
		
		private System.Nullable<double> _DonGia;
		
		private byte _MaDanhMuc;
		
		public TakeAllProductResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSP", DbType="TinyInt NOT NULL")]
		public byte MaSP
		{
			get
			{
				return this._MaSP;
			}
			set
			{
				if ((this._MaSP != value))
				{
					this._MaSP = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenSP", DbType="NVarChar(255)")]
		public string TenSP
		{
			get
			{
				return this._TenSP;
			}
			set
			{
				if ((this._TenSP != value))
				{
					this._TenSP = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DonGia", DbType="Float")]
		public System.Nullable<double> DonGia
		{
			get
			{
				return this._DonGia;
			}
			set
			{
				if ((this._DonGia != value))
				{
					this._DonGia = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDanhMuc", DbType="TinyInt NOT NULL")]
		public byte MaDanhMuc
		{
			get
			{
				return this._MaDanhMuc;
			}
			set
			{
				if ((this._MaDanhMuc != value))
				{
					this._MaDanhMuc = value;
				}
			}
		}
	}
}
#pragma warning restore 1591