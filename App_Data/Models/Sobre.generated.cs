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
	/// <summary>Sobre</summary>
	[PublishedContentModel("sobre")]
	public partial class Sobre : UmbMaster
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "sobre";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Sobre(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Sobre, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Galeria de Imagens
		///</summary>
		[ImplementPropertyType("aboutGallery")]
		public IEnumerable<IPublishedContent> AboutGallery
		{
			get { return this.GetPropertyValue<IEnumerable<IPublishedContent>>("aboutGallery"); }
		}

		///<summary>
		/// Cabeçalho - Imagem
		///</summary>
		[ImplementPropertyType("aboutHeader")]
		public IPublishedContent AboutHeader
		{
			get { return this.GetPropertyValue<IPublishedContent>("aboutHeader"); }
		}

		///<summary>
		/// Texto
		///</summary>
		[ImplementPropertyType("aboutText")]
		public IHtmlString AboutText
		{
			get { return this.GetPropertyValue<IHtmlString>("aboutText"); }
		}

		///<summary>
		/// Título do Texto
		///</summary>
		[ImplementPropertyType("aboutTextTitle")]
		public string AboutTextTitle
		{
			get { return this.GetPropertyValue<string>("aboutTextTitle"); }
		}

		///<summary>
		/// Título
		///</summary>
		[ImplementPropertyType("aboutTitle")]
		public string AboutTitle
		{
			get { return this.GetPropertyValue<string>("aboutTitle"); }
		}
	}
}
