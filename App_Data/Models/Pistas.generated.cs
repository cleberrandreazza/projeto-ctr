//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.7.99
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

namespace Umbraco.Web.PublishedContentModels
{
	/// <summary>Pistas</summary>
	[PublishedContentModel("pistas")]
	public partial class Pistas : UmbMaster
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "pistas";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Pistas(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Pistas, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Item 01
		///</summary>
		[ImplementPropertyType("pistaMark01")]
		public string PistaMark01
		{
			get { return this.GetPropertyValue<string>("pistaMark01"); }
		}

		///<summary>
		/// Item 02
		///</summary>
		[ImplementPropertyType("pistaMark02")]
		public string PistaMark02
		{
			get { return this.GetPropertyValue<string>("pistaMark02"); }
		}

		///<summary>
		/// Item 03
		///</summary>
		[ImplementPropertyType("pistaMark03")]
		public string PistaMark03
		{
			get { return this.GetPropertyValue<string>("pistaMark03"); }
		}

		///<summary>
		/// Item 04
		///</summary>
		[ImplementPropertyType("pistaMark04")]
		public string PistaMark04
		{
			get { return this.GetPropertyValue<string>("pistaMark04"); }
		}

		///<summary>
		/// Item 05
		///</summary>
		[ImplementPropertyType("pistaMark05")]
		public string PistaMark05
		{
			get { return this.GetPropertyValue<string>("pistaMark05"); }
		}

		///<summary>
		/// Item 06
		///</summary>
		[ImplementPropertyType("pistaMark06")]
		public string PistaMark06
		{
			get { return this.GetPropertyValue<string>("pistaMark06"); }
		}

		///<summary>
		/// Item 07
		///</summary>
		[ImplementPropertyType("pistaMark07")]
		public string PistaMark07
		{
			get { return this.GetPropertyValue<string>("pistaMark07"); }
		}

		///<summary>
		/// Item 08
		///</summary>
		[ImplementPropertyType("pistaMark08")]
		public string PistaMark08
		{
			get { return this.GetPropertyValue<string>("pistaMark08"); }
		}

		///<summary>
		/// Item 09
		///</summary>
		[ImplementPropertyType("pistaMark09")]
		public string PistaMark09
		{
			get { return this.GetPropertyValue<string>("pistaMark09"); }
		}

		///<summary>
		/// Item 10
		///</summary>
		[ImplementPropertyType("pistaMark10")]
		public string PistaMark10
		{
			get { return this.GetPropertyValue<string>("pistaMark10"); }
		}

		///<summary>
		/// Item 11
		///</summary>
		[ImplementPropertyType("pistaMark11")]
		public string PistaMark11
		{
			get { return this.GetPropertyValue<string>("pistaMark11"); }
		}

		///<summary>
		/// Item 12
		///</summary>
		[ImplementPropertyType("pistaMark12")]
		public string PistaMark12
		{
			get { return this.GetPropertyValue<string>("pistaMark12"); }
		}

		///<summary>
		/// Item 13
		///</summary>
		[ImplementPropertyType("pistaMark13")]
		public string PistaMark13
		{
			get { return this.GetPropertyValue<string>("pistaMark13"); }
		}

		///<summary>
		/// Item 14
		///</summary>
		[ImplementPropertyType("pistaMark14")]
		public string PistaMark14
		{
			get { return this.GetPropertyValue<string>("pistaMark14"); }
		}

		///<summary>
		/// Item 15
		///</summary>
		[ImplementPropertyType("pistaMark15")]
		public string PistaMark15
		{
			get { return this.GetPropertyValue<string>("pistaMark15"); }
		}

		///<summary>
		/// Item 16
		///</summary>
		[ImplementPropertyType("pistaMark16")]
		public string PistaMark16
		{
			get { return this.GetPropertyValue<string>("pistaMark16"); }
		}

		///<summary>
		/// Item 17
		///</summary>
		[ImplementPropertyType("pistaMark17")]
		public string PistaMark17
		{
			get { return this.GetPropertyValue<string>("pistaMark17"); }
		}

		///<summary>
		/// Item 18
		///</summary>
		[ImplementPropertyType("pistaMark18")]
		public string PistaMark18
		{
			get { return this.GetPropertyValue<string>("pistaMark18"); }
		}
	}
}
