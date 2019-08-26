﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Trombinoscope
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Trombinoscope")]
	public partial class TrombiDataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Définitions de méthodes d'extensibilité
    partial void OnCreated();
    #endregion
		
		public TrombiDataClasses1DataContext() : 
				base(global::Trombinoscope.Properties.Settings.Default.TrombinoscopeConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public TrombiDataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TrombiDataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TrombiDataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TrombiDataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetAllContacts")]
		public ISingleResult<GetAllContactsResult> GetAllContacts()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<GetAllContactsResult>)(result.ReturnValue));
		}
	}
	
	public partial class GetAllContactsResult
	{
		
		private string _Nom;
		
		private string _Prenom;
		
		private string _Adresse;
		
		private string _Localite;
		
		private string _TelFixe;
		
		private string _Gsm;
		
		private System.Data.Linq.Binary _Photo;
		
		public GetAllContactsResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nom", DbType="NVarChar(50)")]
		public string Nom
		{
			get
			{
				return this._Nom;
			}
			set
			{
				if ((this._Nom != value))
				{
					this._Nom = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Prenom", DbType="NVarChar(50)")]
		public string Prenom
		{
			get
			{
				return this._Prenom;
			}
			set
			{
				if ((this._Prenom != value))
				{
					this._Prenom = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Adresse", DbType="NVarChar(50)")]
		public string Adresse
		{
			get
			{
				return this._Adresse;
			}
			set
			{
				if ((this._Adresse != value))
				{
					this._Adresse = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Localite", DbType="NVarChar(50)")]
		public string Localite
		{
			get
			{
				return this._Localite;
			}
			set
			{
				if ((this._Localite != value))
				{
					this._Localite = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TelFixe", DbType="NVarChar(50)")]
		public string TelFixe
		{
			get
			{
				return this._TelFixe;
			}
			set
			{
				if ((this._TelFixe != value))
				{
					this._TelFixe = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gsm", DbType="NVarChar(50)")]
		public string Gsm
		{
			get
			{
				return this._Gsm;
			}
			set
			{
				if ((this._Gsm != value))
				{
					this._Gsm = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Photo", DbType="Image")]
		public System.Data.Linq.Binary Photo
		{
			get
			{
				return this._Photo;
			}
			set
			{
				if ((this._Photo != value))
				{
					this._Photo = value;
				}
			}
		}
	}
}
#pragma warning restore 1591