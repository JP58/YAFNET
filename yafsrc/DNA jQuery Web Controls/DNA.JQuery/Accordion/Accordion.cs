﻿///  Copyright (c) 2009 Ray Liang (http://www.dotnetage.com)
///  Dual licensed under the MIT and GPL licenses:
///  http://www.opensource.org/licenses/mit-license.php
///  http://www.gnu.org/licenses/gpl.html

using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing.Design;
using System.Security.Permissions;
using System.Web;
using System.Web.UI;

namespace DNA.UI.JQuery
{
    /// <summary>
    /// The Accordion is a web control encapsulated the jQuery UI drappable plugin that
    /// allows you to provide multiple views and display them one at a time. It is like having
    /// several CollapsiblePanels where only one can be expanded at a
    /// time. The Accordion is implemented as a web control that contains View web controls.
    /// Each View control has a template for its Content.
    /// </summary>
    /// <remarks>
    /// 	<para></para>
    /// 	<para>You can place to kind of view inside the Accordion</para>
    /// 	<list type="bullet">
    /// 		<item></item>
    /// 		<item>View: contain the server controls or html controls</item>
    /// 		<item>NavView:this view can reparsent the nav view controls.</item>
    /// 	</list>
    /// </remarks>
    /// <seealso cref="NavView">NavView Class</seealso>
    /// <seealso cref="View">View Class</seealso>
    /// <example>
    /// 	<code lang="ASP.NET" title="Accordion Control's Properties">
    /// 		<![CDATA[
    /// <DotNetAge:Accordion ID="MyAccordion"
    ///           AllowCollapseAllSections="false"
    ///           AutoPostBack="false"
    ///           AutoSizeMode="None"
    ///           CollapseAnimation="BounceSlide"
    ///           ContentCssClass="ui-widget-content"
    ///           ContentStyle=""
    ///           HeaderCssClass=""
    ///           HeaderIconCssClass=""
    ///           HeaderSelectedIconCssClass=""
    ///           HeaderStyle=""
    ///           IsClearStyle="false"
    ///           OnClientViewChange=""
    ///           SelectedIndex="0"
    ///           OpenSectionEvent="Click"
    /// >
    ///    <Views>
    ///       <DotNetAge:View Text=""
    ///             ID="View1"
    ///             NavigateUrl=""
    ///             HeaderCssClass=""
    ///             HeaderStyle=""
    ///             Target="_blank">
    ///             <p>View is content is here</p>
    ///       </DotNetAge:View>
    ///       ...
    ///       <DotNetAge:View />
    ///    </Views>
    /// </DotNetAge:Accordion>]]>
    /// 	</code>
    /// </example>
    [JQuery(Name = "accordion", Assembly = "jQueryNet", DisposeMethod = "destroy", ScriptResources = new[] { "ui.core.js", "effects.core.js", "ui.accordion.js", "plugins.easing.1.3.js" }, StartEvent = ClientRegisterEvents.ApplicationLoad)]
    [AspNetHostingPermission(SecurityAction.Demand, Level = AspNetHostingPermissionLevel.Minimal)]
    [AspNetHostingPermission(SecurityAction.InheritanceDemand, Level = AspNetHostingPermissionLevel.Minimal)]
    [ToolboxData("<{0}:Accordion runat=\"server\" id=\"Accordion1\"></{0}:Accordion>")]
    [Designer(typeof(Design.AccordionDesigner))]
    [System.Drawing.ToolboxBitmap(typeof(Accordion), "Accordion.Accordion.ico")]
    [ParseChildren(true)]
    public class Accordion : JQueryMultiViewControl
    {
        #region [Properties]

        /// <summary>
        /// Gets/Sets the growth of the Accordion
        /// </summary>
        /// <remarks>
        ///     It also supports three AutoSize modes so it can fit in a variety of layouts.
        ///     <list type="bullet">
        /// 		<item></item>
        /// 		<item><b>None</b> - The Accordion grows/shrinks without restriction. This can
        ///         cause other elements on your page to move up and down with it.</item>
        /// 		<item><b>Limit</b> - The Accordion never grows larger than the value specified
        ///         by its Height property. This will cause the content to scroll if it is too
        ///         large to be displayed.</item>
        /// 		<item><b>Fill</b> - The Accordion always stays the exact same size as its
        ///         Height property. This will cause the content to be expanded or shrunk if it
        ///         isn't the right size.</item>
        /// 	</list>
        /// </remarks>
        [Category("Layout")]
        [Description("Gets/Sets the growth of the Accordion")]
        [Themeable(true)]
        [Bindable(true)]
        public AccordionSizeModes AutoSizeMode
        {
            get
            {
                Object obj = ViewState["AutoSizeMode"];
                return (obj == null) ? AccordionSizeModes.None : (AccordionSizeModes)obj;
            }
            set
            {
                ViewState["AutoSizeMode"] = value;
            }
        }

        /// <summary>
        /// Gets/Sets your favorite animation of accrodion In addition to the default,
        /// 'BounceSlide' and 'EaseSlide' are supported
        /// </summary>
        [Category("Behavior")]
        [Description("Gets/Sets your favorite animation of accrodion.In addition to the default, 'BounceSlide' and 'EaseSlide' are supported.")]
        [Themeable(true)]
        [Bindable(true)]
        [JQueryOption(Name = "animated")]
        public CollapseAnimations CollapseAnimation
        {
            get
            {
                Object obj = ViewState["CollapseAnimation"];
                return (obj == null) ? CollapseAnimations.BounceSlide : (CollapseAnimations)obj;
            }
            set
            {
                ViewState["CollapseAnimation"] = value;
            }
        }

        /// <summary>
        /// Gets/Sets the clears height and overflow styles after finishing animations. 
        /// This enables accordions to work with dynamic content. Won't work together with AutoHeight.
        /// </summary>
        [JQueryOption(Name = "clearStyle", IgnoreValue = false)]
        [Description("Gets/Sets the clears height and overflow styles after finishing animations. This enables accordions to work with dynamic content. Won't work together with AutoHeight.")]
        [Themeable(true)]
        [PersistenceMode(PersistenceMode.Attribute)]
        [Category("Appearance")]
        [Browsable(true)]
        [Bindable(true)]
        public bool IsClearStyle
        {
            get
            {
                Object obj = ViewState["ClearStyle"];
                return (obj == null) ? false : (bool)obj;
            }
            set
            {
                ViewState["ClearStyle"] = value;
            }
        }

        /// <summary>
        /// Gets/Sets whether all the sections can be closed at once. Allows collapsing the active section by the triggering event (click is the default).
        /// </summary>
        [JQueryOption(Name = "collapsible", DefaultValue = true, IgnoreValue = false)]
        [Themeable(true)]
        [Category("Behavior")]
        [PersistenceMode(PersistenceMode.Attribute)]
        [Bindable(true)]
        [Description("Gets/Sets whether all the sections can be closed at once. Allows collapsing the active section by the triggering event (click is the default).")]
        public bool AllowCollapseAllSections
        {
            get
            {
                Object obj = ViewState["Collapsible"];
                return (obj == null) ? false : (bool)obj;
            }
            set
            {
                ViewState["Collapsible"] = value;
            }
        }

        /// <summary>
        /// Gets/Sets the client event on which to trigger the accordion.
        /// </summary>
        [JQueryOption(Name = "event")]
        [Category("Behavior")]
        [Description("Gets/Sets the client event on which to trigger the accordion.")]
        [Themeable(true)]
        [Bindable(true)]
        [PersistenceMode(PersistenceMode.Attribute)]
        public DomEvents OpenSectionEvent
        {
            get
            {
                Object obj = ViewState["Event"];
                return (obj == null) ? DomEvents.Click : (DomEvents)obj;
            }
            set
            {
                ViewState["Event"] = value;
            }
        }

        /// <summary>
        /// Gets/Sets Accordion looks for the anchor that matches location.href and activates it. 
        /// Great for href-based state-saving. Use navigationFilter to implement your own matcher.
        /// </summary>
        [JQueryOption(Name = "navigation", IgnoreValue = false)]
        [Category("Behavior")]
        [Description("Gets/Sets Accordion looks for the anchor that matches location.href and activates it. Great for href-based state-saving. Use navigationFilter to implement your own matcher.")]
        [Themeable(true)]
        [Bindable(true)]
        [PersistenceMode(PersistenceMode.Attribute)]
        public bool Navigation
        {
            get
            {
                Object obj = ViewState["Navigation"];
                return (obj == null) ? false : (bool)obj;
            }
            set
            {
                ViewState["Navigation"] = value;
            }
        }

        /// <summary>
        /// Gets/Sets the client function that overwrite the default location.href-matching with your own matcher.(from jquery).
        /// </summary>
        [Description("Gets/Sets the client function that overwrite the default location.href-matching with your own matcher.")]
        [Category("Behavior")]
        [JQueryOption(Name = "navigationFilter", Type = JQueryOptionTypes.Function)]
        [Themeable(true)]
        [Bindable(true)]
        [PersistenceMode(PersistenceMode.Attribute)]
        public string NavigationFilter
        {
            get
            {
                Object obj = ViewState["NavigationFilter"];
                return (obj == null) ? null : (string)obj;
            }
            set
            {
                ViewState["NavigationFilter"] = value;
            }
        }

        /// <summary>
        /// Gets/Sets the header icon style class.
        /// </summary>
        [Description("Gets/Sets the header icon style class.")]
        [Category("Appearance")]
        [Themeable(true)]
        [Bindable(true)]
        public string HeaderIconCssClass
        {
            get
            {
                Object obj = ViewState["HeaderIconCssClass"];
                return (obj == null) ? null : (string)obj;
            }
            set
            {
                ViewState["HeaderIconCssClass"] = value;
            }
        }

        /// <summary>
        /// Gets/Sets the header selected icon style class.
        /// </summary>
        [Description("Gets/Sets the header selected icon style class.")]
        [Category("Appearance")]
        [Themeable(true)]
        [Bindable(true)]
        public string HeaderSelectedIconCssClass
        {
            get
            {
                Object obj = ViewState["HeaderSelectedIconCssClass"];
                return (obj == null) ? null : (string)obj;
            }
            set
            {
                ViewState["HeaderSelectedIconCssClass"] = value;
            }
        }

        /// <summary>
        /// Gets/Sets the client event handler for accordion's changes event
        /// </summary>
        /// <remarks>
        ///   This event's has two params for client function.
        ///   event: jquery object
        ///   ui:jquery object
        /// </remarks>
        [Description("Gets/Sets the client event handler for accordion's changes event")]
        [Category("ClientEvents")]
        [Bindable(true)]
        [PersistenceMode(PersistenceMode.Attribute)]
        [TypeConverter(typeof(MultilineStringConverter))]
        [Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
        [JQueryOption(Name = "change", Type = JQueryOptionTypes.Function, FunctionParams = new[] { "event", "ui" })]
        public string OnClientViewChange { get; set; }
        #endregion

        /// <summary>
        /// Gets/Sets the active view control's index
        /// </summary>
        [Description("Gets/Sets the active view control's index")]
        [JQueryOption(Name = "active")]
        public override int SelectedIndex
        {
            get
            {
                return base.SelectedIndex;
            }
            set
            {
                base.SelectedIndex = value;
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override string ToolTip
        {
            get
            {
                return base.ToolTip;
            }
            set
            {
                base.ToolTip = value;
            }
        }

        /// <summary>
        /// When Accordion is Changed this event will be trigged.
        /// </summary>
        /// <remarks>
        /// The AutoPostBack Must be set to true for handling this server event
        /// </remarks>
        public event EventHandler ActiveViewChanged;

        protected override void OnActiveViewChanged()
        {
            if (ActiveViewChanged != null)
                ActiveViewChanged(this, EventArgs.Empty);
        }

        /// <summary>
        /// Initizialize the Accordion
        /// </summary>
        /// <param name="e"></param>
        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);

            if (!DesignMode)
            {
                Page.RegisterRequiresPostBack(this);
                // ScriptManager.GetCurrent(Page).RegisterPostBackControl(this);
            }
            else
            {
                if (string.IsNullOrEmpty(CssClass))
                    CssClass = "ui-accordion ui-widget ui-helper-reset";
            }
        }

        /// <summary>
        /// Register thie additional options for Accordion
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPreRender(EventArgs e)
        {
            if (!DesignMode)
            {
                string hiddenFieldValue = "";
                if (Views[SelectedIndex] != null)
                    hiddenFieldValue = Views[SelectedIndex].ClientID;
                Page.ClientScript.RegisterHiddenField(HiddenKey, hiddenFieldValue);

                JQueryScriptBuilder builder = new JQueryScriptBuilder(this);

                if ((!string.IsNullOrEmpty(HeaderIconCssClass)) && (!string.IsNullOrEmpty(HeaderSelectedIconCssClass)))
                   builder.AddOption("icons", "{'header':'" + HeaderIconCssClass + "','headerSelected':'" + HeaderSelectedIconCssClass + "'}");

                switch (AutoSizeMode)
                {
                    case AccordionSizeModes.Fill:
                        builder.AddOption("fillSpace",true);
                        break;
                    case AccordionSizeModes.Limit:
                        break;
                    case AccordionSizeModes.None:
                        builder.AddOption("autoHeight", false);
                        break;
                }
                builder.Prepare();
                builder.Build();

                //v1.1.15
               
                string onchange = "if (ui.newHeader.context) {$('#" + HiddenKey + "').attr('value',ui.newHeader.context.nextSibling.id);}";
                if (AutoPostBack)
                {
                    if (Views.Count > 0)
                    {
                        foreach (View view in Views)
                        {
                            if (view.Index == SelectedIndex)
                                view.SetVisible(true);
                            else
                                view.SetVisible(false);
                        }

                         onchange+= Page.ClientScript.GetPostBackEventReference(this, "viewChange") + ";";
                    }
                }

                builder.AppendBindFunction("accordionchange", new[] { "event", "ui" }, onchange);
                if (AutoSizeMode == AccordionSizeModes.None)
                {
                    Style.Add("display", "none");
                    builder.AppendCssStyle("'display':'block'");
                }

               ClientScriptManager.RegisterJQueryControl(this,builder);
            }
        }

        /// <summary>
        /// Override the LoadPostData to handling the ActiveViewChanged event
        /// </summary>
        /// <param name="postDataKey"></param>
        /// <param name="postCollection"></param>
        /// <returns></returns>
        protected override bool LoadPostData(string postDataKey, System.Collections.Specialized.NameValueCollection postCollection)
        {
            EnsureChildControls();
            if (!string.IsNullOrEmpty(postCollection[HiddenKey]))
            {
                string viewId = postCollection[HiddenKey];
                int index = Views[viewId].Index;
                if (index == SelectedIndex)
                    return false;

                newIndex = index;
                return true;
            }
            return false;
        }

    }

}