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
	public partial class DetalleColeccion
	{
		private int idDetalleColeccion;
		public virtual int IdDetalleColeccion
		{
			get
			{
				return this.idDetalleColeccion;
			}
			set
			{
				this.idDetalleColeccion = value;
			}
		}
		
		private int? idColeccion;
		public virtual int? IdColeccion
		{
			get
			{
				return this.idColeccion;
			}
			set
			{
				this.idColeccion = value;
			}
		}
		
		private int? capitulo;
		public virtual int? Capitulo
		{
			get
			{
				return this.capitulo;
			}
			set
			{
				this.capitulo = value;
			}
		}
		
		private string nombre;
		public virtual string Nombre
		{
			get
			{
				return this.nombre;
			}
			set
			{
				this.nombre = value;
			}
		}
		
		private Coleccion coleccion;
		public virtual Coleccion Coleccion
		{
			get
			{
				return this.coleccion;
			}
			set
			{
				this.coleccion = value;
			}
		}
		
	}
}
#pragma warning restore 1591
