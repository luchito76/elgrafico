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
using Dominio;

namespace Dominio	
{
	public partial class Revista
	{
		private int idRevista;
		public virtual int IdRevista
		{
			get
			{
				return this.idRevista;
			}
			set
			{
				this.idRevista = value;
			}
		}
		
		private DateTime? fecha;
		public virtual DateTime? Fecha
		{
			get
			{
				return this.fecha;
			}
			set
			{
				this.fecha = value;
			}
		}
		
		private string titulo;
		public virtual string Titulo
		{
			get
			{
				return this.titulo;
			}
			set
			{
				this.titulo = value;
			}
		}
		
		private int? idDeporte;
		public virtual int? IdDeporte
		{
			get
			{
				return this.idDeporte;
			}
			set
			{
				this.idDeporte = value;
			}
		}
		
		private int? numeroDeEdicion;
		public virtual int? NumeroDeEdicion
		{
			get
			{
				return this.numeroDeEdicion;
			}
			set
			{
				this.numeroDeEdicion = value;
			}
		}
		
		private int? cantidad;
		public virtual int? Cantidad
		{
			get
			{
				return this.cantidad;
			}
			set
			{
				this.cantidad = value;
			}
		}
		
		private int? idTapa;
		public virtual int? IdTapa
		{
			get
			{
				return this.idTapa;
			}
			set
			{
				this.idTapa = value;
			}
		}
		
		private int? idEstado;
		public virtual int? IdEstado
		{
			get
			{
				return this.idEstado;
			}
			set
			{
				this.idEstado = value;
			}
		}
		
		private Tapa tapa;
		public virtual Tapa Tapa
		{
			get
			{
				return this.tapa;
			}
			set
			{
				this.tapa = value;
			}
		}
		
		private Deporte deporte;
		public virtual Deporte Deporte
		{
			get
			{
				return this.deporte;
			}
			set
			{
				this.deporte = value;
			}
		}
		
		private Estado estado;
		public virtual Estado Estado
		{
			get
			{
				return this.estado;
			}
			set
			{
				this.estado = value;
			}
		}
		
	}
}
#pragma warning restore 1591
