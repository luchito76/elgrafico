#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the ClassGenerator.ttinclude code generation file.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Common;
using System.Collections.Generic;
using Telerik.OpenAccess;
using Telerik.OpenAccess.Metadata;
using Telerik.OpenAccess.Data.Common;
using Telerik.OpenAccess.Metadata.Fluent;
using Telerik.OpenAccess.Metadata.Fluent.Advanced;

namespace Dominio	
{
	public partial class ListadoDeRevistasResultSet0
	{
		private int _idRevista;
		public virtual int idRevista
		{
			get
			{
				return this._idRevista;
			}
			set
			{
				this._idRevista = value;
			}
		}
		
		private int? _edicion;
		public virtual int? Edicion
		{
			get
			{
				return this._edicion;
			}
			set
			{
				this._edicion = value;
			}
		}
		
		private DateTime? _fecha;
		public virtual DateTime? Fecha
		{
			get
			{
				return this._fecha;
			}
			set
			{
				this._fecha = value;
			}
		}
		
		private string _titulo;
		public virtual string Titulo
		{
			get
			{
				return this._titulo;
			}
			set
			{
				this._titulo = value;
			}
		}
		
		private string _deporte;
		public virtual string Deporte
		{
			get
			{
				return this._deporte;
			}
			set
			{
				this._deporte = value;
			}
		}
		
		private int? _cantidad;
		public virtual int? Cantidad
		{
			get
			{
				return this._cantidad;
			}
			set
			{
				this._cantidad = value;
			}
		}
		
		private string _nombreImagen;
		public virtual string NombreImagen
		{
			get
			{
				return this._nombreImagen;
			}
			set
			{
				this._nombreImagen = value;
			}
		}
		
		private int? _largo;
		public virtual int? Largo
		{
			get
			{
				return this._largo;
			}
			set
			{
				this._largo = value;
			}
		}
		
		private byte[] _imagen;
		public virtual byte[] Imagen
		{
			get
			{
				return this._imagen;
			}
			set
			{
				this._imagen = value;
			}
		}
		
	}
}
#pragma warning restore 1591
