#pragma checksum "C:\Users\ASUS\Desktop\Final layihesi\WebApplication1\WebApplication1\Views\Page\RecipeMenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f58aa16c02b8367a6a24904ae389630f99ca79f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Page_RecipeMenu), @"mvc.1.0.view", @"/Views/Page/RecipeMenu.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\ASUS\Desktop\Final layihesi\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\Final layihesi\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f58aa16c02b8367a6a24904ae389630f99ca79f7", @"/Views/Page/RecipeMenu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05709865ab4979dadf0ebc2d759e512fe456a304", @"/Views/_ViewImports.cshtml")]
    public class Views_Page_RecipeMenu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::AspNetCore.Views_Page_RecipeMenu.__Generated__MenuCategoryViewComponentTagHelper __MenuCategoryViewComponentTagHelper;
        private global::AspNetCore.Views_Page_RecipeMenu.__Generated__CafeMenuViewComponentTagHelper __CafeMenuViewComponentTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\Final layihesi\WebApplication1\WebApplication1\Views\Page\RecipeMenu.cshtml"
  
    ViewData["Title"] = "RecipeMenu";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- breadcrumb_section - start
     ================================================== -->
<section class=""breadcrumb_section text-uppercase"" style=""background-image: url(/images/breadcrumb/breadcrumb_bg_01.jpg);"">
    <div class=""container"">
        <h1 class=""page_title text-white wow fadeInUp"" data-wow-delay="".1s"">Our Menu</h1>
        <ul class=""breadcrumb_nav ul_li wow fadeInUp"" data-wow-delay="".2s"">
            <li><a href=""index_1.html""><i class=""fas fa-home""></i> Home</a></li>
            <li>Our Menu</li>
        </ul>
    </div>
    <div class=""breadcrumb_icon_wrap"">
        <div class=""container"">
            <div class=""breadcrumb_icon wow fadeInUp"" data-wow-delay="".3s"">
                <img src=""/images/feature/icon_01.png"" alt=""icon_not_found"">
                <span class=""bg_shape""></span>
            </div>
        </div>
    </div>
</section>
<!-- breadcrumb_section - end
================================================== -->
<!-- recipe_menu_section - start
=========");
            WriteLiteral("========================================= -->\r\n<section class=\"recipe_menu_section sec_ptb_120 bg_gray deco_wrap\">\r\n    <div class=\"container\">\r\n       ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:menu-category", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f58aa16c02b8367a6a24904ae389630f99ca79f74791", async() => {
            }
            );
            __MenuCategoryViewComponentTagHelper = CreateTagHelper<global::AspNetCore.Views_Page_RecipeMenu.__Generated__MenuCategoryViewComponentTagHelper>();
            __tagHelperExecutionContext.Add(__MenuCategoryViewComponentTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n       ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:cafe-menu", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f58aa16c02b8367a6a24904ae389630f99ca79f75724", async() => {
            }
            );
            __CafeMenuViewComponentTagHelper = CreateTagHelper<global::AspNetCore.Views_Page_RecipeMenu.__Generated__CafeMenuViewComponentTagHelper>();
            __tagHelperExecutionContext.Add(__CafeMenuViewComponentTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>

    <div class=""deco_item shape_1"">
        <img src=""/images/menu/shape_01.png"" alt=""image_not_found"">
    </div>
    <div class=""deco_item shape_2"">
        <img src=""/images/menu/shape_02.png"" alt=""image_not_found"">
    </div>
</section>
<!-- recipe_menu_section - end
================================================== -->
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("vc:menu-category")]
        public class __Generated__MenuCategoryViewComponentTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
        {
            private readonly global::Microsoft.AspNetCore.Mvc.IViewComponentHelper __helper = null;
            public __Generated__MenuCategoryViewComponentTagHelper(global::Microsoft.AspNetCore.Mvc.IViewComponentHelper helper)
            {
                __helper = helper;
            }
            [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute, global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
            public global::Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get; set; }
            public override async global::System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext __context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput __output)
            {
                (__helper as global::Microsoft.AspNetCore.Mvc.ViewFeatures.IViewContextAware)?.Contextualize(ViewContext);
                var __helperContent = await __helper.InvokeAsync("MenuCategory", new {  });
                __output.TagName = null;
                __output.Content.SetHtmlContent(__helperContent);
            }
        }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("vc:cafe-menu")]
        public class __Generated__CafeMenuViewComponentTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
        {
            private readonly global::Microsoft.AspNetCore.Mvc.IViewComponentHelper __helper = null;
            public __Generated__CafeMenuViewComponentTagHelper(global::Microsoft.AspNetCore.Mvc.IViewComponentHelper helper)
            {
                __helper = helper;
            }
            [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute, global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
            public global::Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get; set; }
            public override async global::System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext __context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput __output)
            {
                (__helper as global::Microsoft.AspNetCore.Mvc.ViewFeatures.IViewContextAware)?.Contextualize(ViewContext);
                var __helperContent = await __helper.InvokeAsync("CafeMenu", new {  });
                __output.TagName = null;
                __output.Content.SetHtmlContent(__helperContent);
            }
        }
    }
}
#pragma warning restore 1591
