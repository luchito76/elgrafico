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
	public partial class Tapa
	{
		private int idTapa;
		public virtual int IdTapa
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
		
		private int? largo;
		public virtual int? Largo
		{
			get
			{
				return this.largo;
			}
			set
			{
				this.largo = value;
			}
		}
		
		private byte[] imagen;
		public virtual byte[] Imagen
		{
			get
			{
				return this.imagen;
			}
			set
			{
				this.imagen = value;
			}
		}
		
		private IList<Revista> revistas = new List<Revista>();
		public virtual IList<Revista> Revistas
		{
			get
			{
				return this.revistas;
			}
		}
		
	}
}
#pragma warning restore 1591
