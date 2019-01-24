using  System;
using  System.Collections.Generic;
using  System.Linq.Expressions;
using  System.Web;
using  Umbraco.Core.Models;
using  Umbraco.Core.Models.PublishedContent;
using  Umbraco.Web;
using  Umbraco.ModelsBuilder;
using  Umbraco.ModelsBuilder.Umbraco;
[assembly: PureLiveAssembly]
[assembly:ModelsBuilderAssembly(PureLive = true, SourceHash = "145c1ec0d25cc50c")]
[assembly:System.Reflection.AssemblyVersion("0.0.0.1")]


// FILE: models.generated.cs

//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.7.99
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------















namespace Umbraco.Web.PublishedContentModels
{
	/// <summary>Master</summary>
	[PublishedContentModel("umbMaster")]
	public partial class UmbMaster : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "umbMaster";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public UmbMaster(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<UmbMaster, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Página interna?
		///</summary>
		[ImplementPropertyType("isInternal")]
		public bool IsInternal
		{
			get { return this.GetPropertyValue<bool>("isInternal"); }
		}

		///<summary>
		/// Título da Página
		///</summary>
		[ImplementPropertyType("title")]
		public string Title
		{
			get { return this.GetPropertyValue<string>("title"); }
		}

		///<summary>
		/// Esconder na navegação?
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide
		{
			get { return this.GetPropertyValue<bool>("umbracoNaviHide"); }
		}
	}

	/// <summary>Home</summary>
	[PublishedContentModel("umbHomePage")]
	public partial class UmbHomePage : UmbMaster
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "umbHomePage";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public UmbHomePage(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<UmbHomePage, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// E-mail
		///</summary>
		[ImplementPropertyType("eMail")]
		public string EMail
		{
			get { return this.GetPropertyValue<string>("eMail"); }
		}

		///<summary>
		/// Endereço - Linha 1
		///</summary>
		[ImplementPropertyType("enderecoLinha1")]
		public string EnderecoLinha1
		{
			get { return this.GetPropertyValue<string>("enderecoLinha1"); }
		}

		///<summary>
		/// Endereço - Linha 2
		///</summary>
		[ImplementPropertyType("enderecoLinha2")]
		public string EnderecoLinha2
		{
			get { return this.GetPropertyValue<string>("enderecoLinha2"); }
		}

		///<summary>
		/// Hectares
		///</summary>
		[ImplementPropertyType("hectares")]
		public string Hectares
		{
			get { return this.GetPropertyValue<string>("hectares"); }
		}

		///<summary>
		/// Imagem
		///</summary>
		[ImplementPropertyType("homeBanner1Image")]
		public IPublishedContent HomeBanner1Image
		{
			get { return this.GetPropertyValue<IPublishedContent>("homeBanner1Image"); }
		}

		///<summary>
		/// Link
		///</summary>
		[ImplementPropertyType("homeBanner1Link")]
		public string HomeBanner1Link
		{
			get { return this.GetPropertyValue<string>("homeBanner1Link"); }
		}

		///<summary>
		/// Sub-título
		///</summary>
		[ImplementPropertyType("homeBanner1SubTitulo")]
		public string HomeBanner1SubTitulo
		{
			get { return this.GetPropertyValue<string>("homeBanner1SubTitulo"); }
		}

		///<summary>
		/// Texto do link
		///</summary>
		[ImplementPropertyType("homeBanner1TextoDoLink")]
		public string HomeBanner1TextoDoLink
		{
			get { return this.GetPropertyValue<string>("homeBanner1TextoDoLink"); }
		}

		///<summary>
		/// Título
		///</summary>
		[ImplementPropertyType("homeBanner1Titulo")]
		public string HomeBanner1Titulo
		{
			get { return this.GetPropertyValue<string>("homeBanner1Titulo"); }
		}

		///<summary>
		/// Imagem
		///</summary>
		[ImplementPropertyType("homeBanner2Imagem")]
		public IPublishedContent HomeBanner2Imagem
		{
			get { return this.GetPropertyValue<IPublishedContent>("homeBanner2Imagem"); }
		}

		///<summary>
		/// Link
		///</summary>
		[ImplementPropertyType("homeBanner2Link")]
		public string HomeBanner2Link
		{
			get { return this.GetPropertyValue<string>("homeBanner2Link"); }
		}

		///<summary>
		/// Sub-título
		///</summary>
		[ImplementPropertyType("homeBanner2SubTitulo")]
		public string HomeBanner2SubTitulo
		{
			get { return this.GetPropertyValue<string>("homeBanner2SubTitulo"); }
		}

		///<summary>
		/// Texto do Link
		///</summary>
		[ImplementPropertyType("homeBanner2TextoDoLink")]
		public string HomeBanner2TextoDoLink
		{
			get { return this.GetPropertyValue<string>("homeBanner2TextoDoLink"); }
		}

		///<summary>
		/// Título
		///</summary>
		[ImplementPropertyType("homeBanner2Titulo")]
		public string HomeBanner2Titulo
		{
			get { return this.GetPropertyValue<string>("homeBanner2Titulo"); }
		}

		///<summary>
		/// Box 1 - Texto
		///</summary>
		[ImplementPropertyType("homeBox1Titulo")]
		public IHtmlString HomeBox1Titulo
		{
			get { return this.GetPropertyValue<IHtmlString>("homeBox1Titulo"); }
		}

		///<summary>
		/// Box 2 - Link
		///</summary>
		[ImplementPropertyType("homeBox2Link")]
		public string HomeBox2Link
		{
			get { return this.GetPropertyValue<string>("homeBox2Link"); }
		}

		///<summary>
		/// Box 2 - Texto
		///</summary>
		[ImplementPropertyType("homeBox2Texto")]
		public string HomeBox2Texto
		{
			get { return this.GetPropertyValue<string>("homeBox2Texto"); }
		}

		///<summary>
		/// Box 2 - Título
		///</summary>
		[ImplementPropertyType("homeBox2Titulo")]
		public string HomeBox2Titulo
		{
			get { return this.GetPropertyValue<string>("homeBox2Titulo"); }
		}

		///<summary>
		/// Box 3 - Link
		///</summary>
		[ImplementPropertyType("homeBox3Link")]
		public string HomeBox3Link
		{
			get { return this.GetPropertyValue<string>("homeBox3Link"); }
		}

		///<summary>
		/// Box 3 - Texto
		///</summary>
		[ImplementPropertyType("homeBox3Texto")]
		public string HomeBox3Texto
		{
			get { return this.GetPropertyValue<string>("homeBox3Texto"); }
		}

		///<summary>
		/// Box 3 - Título
		///</summary>
		[ImplementPropertyType("homeBox3Titulo")]
		public string HomeBox3Titulo
		{
			get { return this.GetPropertyValue<string>("homeBox3Titulo"); }
		}

		///<summary>
		/// Box 4 - Imagem
		///</summary>
		[ImplementPropertyType("homeBox4Imagem")]
		public IPublishedContent HomeBox4Imagem
		{
			get { return this.GetPropertyValue<IPublishedContent>("homeBox4Imagem"); }
		}

		///<summary>
		/// Link
		///</summary>
		[ImplementPropertyType("homePistasLink")]
		public string HomePistasLink
		{
			get { return this.GetPropertyValue<string>("homePistasLink"); }
		}

		///<summary>
		/// Texto do Link
		///</summary>
		[ImplementPropertyType("homePistasTextoDoLink")]
		public string HomePistasTextoDoLink
		{
			get { return this.GetPropertyValue<string>("homePistasTextoDoLink"); }
		}

		///<summary>
		/// Vídeo
		///</summary>
		[ImplementPropertyType("homeVideo")]
		public Newtonsoft.Json.Linq.JToken HomeVideo
		{
			get { return this.GetPropertyValue<Newtonsoft.Json.Linq.JToken>("homeVideo"); }
		}

		///<summary>
		/// Imagem
		///</summary>
		[ImplementPropertyType("imagem")]
		public IPublishedContent Imagem
		{
			get { return this.GetPropertyValue<IPublishedContent>("imagem"); }
		}

		///<summary>
		/// Latitude
		///</summary>
		[ImplementPropertyType("latitude")]
		public string Latitude
		{
			get { return this.GetPropertyValue<string>("latitude"); }
		}

		///<summary>
		/// Link Google Maps
		///</summary>
		[ImplementPropertyType("linkGoogleMaps")]
		public string LinkGoogleMaps
		{
			get { return this.GetPropertyValue<string>("linkGoogleMaps"); }
		}

		///<summary>
		/// Longitude
		///</summary>
		[ImplementPropertyType("longitude")]
		public string Longitude
		{
			get { return this.GetPropertyValue<string>("longitude"); }
		}

		///<summary>
		/// Metros Quadrados
		///</summary>
		[ImplementPropertyType("metrosQuadrados")]
		public string MetrosQuadrados
		{
			get { return this.GetPropertyValue<string>("metrosQuadrados"); }
		}

		///<summary>
		/// Metros Quadrados - Sub-título
		///</summary>
		[ImplementPropertyType("metrosQuadradosSubTitulo")]
		public string MetrosQuadradosSubTitulo
		{
			get { return this.GetPropertyValue<string>("metrosQuadradosSubTitulo"); }
		}

		///<summary>
		/// Quilômetros
		///</summary>
		[ImplementPropertyType("quilometros")]
		public string Quilometros
		{
			get { return this.GetPropertyValue<string>("quilometros"); }
		}

		///<summary>
		/// Título do Site
		///</summary>
		[ImplementPropertyType("siteName")]
		public string SiteName
		{
			get { return this.GetPropertyValue<string>("siteName"); }
		}

		///<summary>
		/// Telefone
		///</summary>
		[ImplementPropertyType("telefone")]
		public string Telefone
		{
			get { return this.GetPropertyValue<string>("telefone"); }
		}

		///<summary>
		/// Texto
		///</summary>
		[ImplementPropertyType("textoIntrodutorio")]
		public string TextoIntrodutorio
		{
			get { return this.GetPropertyValue<string>("textoIntrodutorio"); }
		}

		///<summary>
		/// Tipos de Pista
		///</summary>
		[ImplementPropertyType("tiposDePista")]
		public string TiposDePista
		{
			get { return this.GetPropertyValue<string>("tiposDePista"); }
		}
	}

	/// <summary>Laboratório</summary>
	[PublishedContentModel("laboratorio")]
	public partial class Laboratorio : UmbMaster
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "laboratorio";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Laboratorio(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Laboratorio, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Header
		///</summary>
		[ImplementPropertyType("laboratorioHeader")]
		public IPublishedContent LaboratorioHeader
		{
			get { return this.GetPropertyValue<IPublishedContent>("laboratorioHeader"); }
		}

		///<summary>
		/// Texto
		///</summary>
		[ImplementPropertyType("laboratorioTexto")]
		public string LaboratorioTexto
		{
			get { return this.GetPropertyValue<string>("laboratorioTexto"); }
		}

		///<summary>
		/// Título do Texto
		///</summary>
		[ImplementPropertyType("laboratorioTextoTitulo")]
		public string LaboratorioTextoTitulo
		{
			get { return this.GetPropertyValue<string>("laboratorioTextoTitulo"); }
		}

		///<summary>
		/// Chamada
		///</summary>
		[ImplementPropertyType("laboratorioTitulo")]
		public string LaboratorioTitulo
		{
			get { return this.GetPropertyValue<string>("laboratorioTitulo"); }
		}

		///<summary>
		/// Título das Imagens
		///</summary>
		[ImplementPropertyType("laboratorioTituloDasImagens")]
		public string LaboratorioTituloDasImagens
		{
			get { return this.GetPropertyValue<string>("laboratorioTituloDasImagens"); }
		}
	}

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

	/// <summary>Serviços</summary>
	[PublishedContentModel("servicos")]
	public partial class Servicos : UmbMaster
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "servicos";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Servicos(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Servicos, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Header
		///</summary>
		[ImplementPropertyType("servicosHeader")]
		public IPublishedContent ServicosHeader
		{
			get { return this.GetPropertyValue<IPublishedContent>("servicosHeader"); }
		}

		///<summary>
		/// Título
		///</summary>
		[ImplementPropertyType("servicosTitulo")]
		public string ServicosTitulo
		{
			get { return this.GetPropertyValue<string>("servicosTitulo"); }
		}
	}

	/// <summary>Como Chegar</summary>
	[PublishedContentModel("comoChegar")]
	public partial class ComoChegar : UmbMaster
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "comoChegar";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public ComoChegar(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ComoChegar, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>Fale Conosco</summary>
	[PublishedContentModel("faleConosco")]
	public partial class FaleConosco : UmbMaster
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "faleConosco";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public FaleConosco(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<FaleConosco, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Header
		///</summary>
		[ImplementPropertyType("faleImagem")]
		public IPublishedContent FaleImagem
		{
			get { return this.GetPropertyValue<IPublishedContent>("faleImagem"); }
		}

		///<summary>
		/// Título
		///</summary>
		[ImplementPropertyType("faleTitulo")]
		public string FaleTitulo
		{
			get { return this.GetPropertyValue<string>("faleTitulo"); }
		}
	}

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

	/// <summary>Laboratório Item</summary>
	[PublishedContentModel("laboratorioItem")]
	public partial class LaboratorioItem : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "laboratorioItem";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public LaboratorioItem(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<LaboratorioItem, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Imagem
		///</summary>
		[ImplementPropertyType("laboratorioItemImagem")]
		public IPublishedContent LaboratorioItemImagem
		{
			get { return this.GetPropertyValue<IPublishedContent>("laboratorioItemImagem"); }
		}

		///<summary>
		/// Legenda
		///</summary>
		[ImplementPropertyType("laboratorioItemLegenda")]
		public string LaboratorioItemLegenda
		{
			get { return this.GetPropertyValue<string>("laboratorioItemLegenda"); }
		}
	}

	/// <summary>Pistas Item</summary>
	[PublishedContentModel("pistasItem")]
	public partial class PistasItem : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "pistasItem";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public PistasItem(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<PistasItem, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Header
		///</summary>
		[ImplementPropertyType("pistaItemHeader")]
		public IPublishedContent PistaItemHeader
		{
			get { return this.GetPropertyValue<IPublishedContent>("pistaItemHeader"); }
		}

		///<summary>
		/// Imagem da Pista
		///</summary>
		[ImplementPropertyType("pistaItemImage")]
		public IPublishedContent PistaItemImage
		{
			get { return this.GetPropertyValue<IPublishedContent>("pistaItemImage"); }
		}

		///<summary>
		/// Imagens
		///</summary>
		[ImplementPropertyType("pistaItemImagens")]
		public IEnumerable<IPublishedContent> PistaItemImagens
		{
			get { return this.GetPropertyValue<IEnumerable<IPublishedContent>>("pistaItemImagens"); }
		}

		///<summary>
		/// Número
		///</summary>
		[ImplementPropertyType("pistaItemNumero")]
		public string PistaItemNumero
		{
			get { return this.GetPropertyValue<string>("pistaItemNumero"); }
		}

		///<summary>
		/// Texto
		///</summary>
		[ImplementPropertyType("pistaItemTexto")]
		public IHtmlString PistaItemTexto
		{
			get { return this.GetPropertyValue<IHtmlString>("pistaItemTexto"); }
		}

		///<summary>
		/// Título
		///</summary>
		[ImplementPropertyType("pistaItemTitulo")]
		public string PistaItemTitulo
		{
			get { return this.GetPropertyValue<string>("pistaItemTitulo"); }
		}

		///<summary>
		/// Vídeo
		///</summary>
		[ImplementPropertyType("pistaItemVideo")]
		public Newtonsoft.Json.Linq.JToken PistaItemVideo
		{
			get { return this.GetPropertyValue<Newtonsoft.Json.Linq.JToken>("pistaItemVideo"); }
		}
	}

	/// <summary>Serviços Item</summary>
	[PublishedContentModel("servicosItem")]
	public partial class ServicosItem : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "servicosItem";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public ServicosItem(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ServicosItem, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Ícone
		///</summary>
		[ImplementPropertyType("icone")]
		public IPublishedContent Icone
		{
			get { return this.GetPropertyValue<IPublishedContent>("icone"); }
		}

		///<summary>
		/// Imagem
		///</summary>
		[ImplementPropertyType("itemServicoImagem")]
		public IPublishedContent ItemServicoImagem
		{
			get { return this.GetPropertyValue<IPublishedContent>("itemServicoImagem"); }
		}

		///<summary>
		/// Texto
		///</summary>
		[ImplementPropertyType("itemServicoTexto")]
		public string ItemServicoTexto
		{
			get { return this.GetPropertyValue<string>("itemServicoTexto"); }
		}

		///<summary>
		/// Título
		///</summary>
		[ImplementPropertyType("itemServicoTitulo")]
		public string ItemServicoTitulo
		{
			get { return this.GetPropertyValue<string>("itemServicoTitulo"); }
		}
	}

	/// <summary>Folder</summary>
	[PublishedContentModel("Folder")]
	public partial class Folder : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Folder";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Folder(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Folder, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Contents:
		///</summary>
		[ImplementPropertyType("contents")]
		public object Contents
		{
			get { return this.GetPropertyValue("contents"); }
		}
	}

	/// <summary>Image</summary>
	[PublishedContentModel("Image")]
	public partial class Image : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Image";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Image(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Image, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload image
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public Umbraco.Web.Models.ImageCropDataSet UmbracoFile
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("umbracoFile"); }
		}

		///<summary>
		/// Height
		///</summary>
		[ImplementPropertyType("umbracoHeight")]
		public string UmbracoHeight
		{
			get { return this.GetPropertyValue<string>("umbracoHeight"); }
		}

		///<summary>
		/// Width
		///</summary>
		[ImplementPropertyType("umbracoWidth")]
		public string UmbracoWidth
		{
			get { return this.GetPropertyValue<string>("umbracoWidth"); }
		}
	}

	/// <summary>File</summary>
	[PublishedContentModel("File")]
	public partial class File : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "File";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public File(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<File, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload file
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public string UmbracoFile
		{
			get { return this.GetPropertyValue<string>("umbracoFile"); }
		}
	}

	/// <summary>Member</summary>
	[PublishedContentModel("Member")]
	public partial class Member : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Member";
		public new const PublishedItemType ModelItemType = PublishedItemType.Member;
#pragma warning restore 0109

		public Member(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Member, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Is Approved
		///</summary>
		[ImplementPropertyType("umbracoMemberApproved")]
		public bool UmbracoMemberApproved
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberApproved"); }
		}

		///<summary>
		/// Comments
		///</summary>
		[ImplementPropertyType("umbracoMemberComments")]
		public string UmbracoMemberComments
		{
			get { return this.GetPropertyValue<string>("umbracoMemberComments"); }
		}

		///<summary>
		/// Failed Password Attempts
		///</summary>
		[ImplementPropertyType("umbracoMemberFailedPasswordAttempts")]
		public string UmbracoMemberFailedPasswordAttempts
		{
			get { return this.GetPropertyValue<string>("umbracoMemberFailedPasswordAttempts"); }
		}

		///<summary>
		/// Last Lockout Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLockoutDate")]
		public string UmbracoMemberLastLockoutDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLockoutDate"); }
		}

		///<summary>
		/// Last Login Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLogin")]
		public string UmbracoMemberLastLogin
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLogin"); }
		}

		///<summary>
		/// Last Password Change Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastPasswordChangeDate")]
		public string UmbracoMemberLastPasswordChangeDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastPasswordChangeDate"); }
		}

		///<summary>
		/// Is Locked Out
		///</summary>
		[ImplementPropertyType("umbracoMemberLockedOut")]
		public bool UmbracoMemberLockedOut
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberLockedOut"); }
		}

		///<summary>
		/// Password Answer
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalAnswer")]
		public string UmbracoMemberPasswordRetrievalAnswer
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalAnswer"); }
		}

		///<summary>
		/// Password Question
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalQuestion")]
		public string UmbracoMemberPasswordRetrievalQuestion
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalQuestion"); }
		}
	}

}



// EOF