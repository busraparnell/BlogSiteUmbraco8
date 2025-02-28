//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v8.1.0
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

namespace Umbraco.Web.PublishedModels
{
	// Mixin Content Type with alias "visibilityControl"
	/// <summary>Visibility Control</summary>
	public partial interface IVisibilityControl : IPublishedContent
	{
		/// <summary>Hide From XML Site Map</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		bool HideFromXmlsiteMap { get; }

		/// <summary>Umbraco Navi Hide</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		bool UmbracoNaviHide { get; }
	}

	/// <summary>Visibility Control</summary>
	[PublishedModel("visibilityControl")]
	public partial class VisibilityControl : PublishedContentModel, IVisibilityControl
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new const string ModelTypeAlias = "visibilityControl";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<VisibilityControl, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public VisibilityControl(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Hide From XML Site Map: Tick this if you want to hide this page from XML Sitemap
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("hideFromXMLSiteMap")]
		public bool HideFromXmlsiteMap => GetHideFromXmlsiteMap(this);

		/// <summary>Static getter for Hide From XML Site Map</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public static bool GetHideFromXmlsiteMap(IVisibilityControl that) => that.Value<bool>("hideFromXMLSiteMap");

		///<summary>
		/// Umbraco Navi Hide: Tick this box if you want to hide this page from the navigation and from search results
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide => GetUmbracoNaviHide(this);

		/// <summary>Static getter for Umbraco Navi Hide</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public static bool GetUmbracoNaviHide(IVisibilityControl that) => that.Value<bool>("umbracoNaviHide");
	}
}
