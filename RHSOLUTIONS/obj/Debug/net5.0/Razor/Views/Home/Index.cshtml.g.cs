#pragma checksum "D:\PIM IV\PIMIV\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd550c349a8f30e1e2f5b69432a01c258924521c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\PIM IV\PIMIV\Views\_ViewImports.cshtml"
using PIMIVRH;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\PIM IV\PIMIV\Views\_ViewImports.cshtml"
using PIMIVRH.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd550c349a8f30e1e2f5b69432a01c258924521c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18fb6545804a03f42f55d4b947ce7fc7a4e176fe", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\PIM IV\PIMIV\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd550c349a8f30e1e2f5b69432a01c258924521c3111", async() => {
                WriteLiteral(@"
        <div class=""container-fluid"">
            <div class=""row flex-nowrap"">
                <div class=""col-auto col-md-2 bg-dark min-vh-100"">
                    <div class=""d-flex flex-column align-items-center align-items-sm-start px-3 pt-2 text-white min-vh-100"">
                        <a href=""/"" class=""d-flex align-items-center pb-3 mb-md-0 me-md-auto text-white text-decoration-none"">
                            <span class=""fs-5 d-none d-sm-inline"">Bem vindo funcionario</span>
                        </a>
                        <ul class=""nav nav-pills flex-column mb-sm-auto mb-0 align-items-center align-items-sm-start"" id=""menu"">
                            <li class=""nav-item"">
                                <a href=""#"" class=""nav-link align-middle px-0"">
                                    <i class=""fs-4 bi-house""></i> <span class=""ms-1 d-none d-sm-inline"">Home</span>
                                </a>
                            </li>
                            <li>
      ");
                WriteLiteral(@"                          <a href=""#submenu1"" data-bs-toggle=""collapse"" class=""nav-link px-0 align-middle"">
                                    <i class=""fs-4 bi-speedometer2""></i> <span class=""ms-1 d-none d-sm-inline"">Ponto eletrônico</span>
                                </a>
                            </li>
                            <li>
                                <a href=""#"" class=""nav-link px-0 align-middle"">
                                    <i class=""fs-4 bi-table""></i> <span class=""ms-1 d-none d-sm-inline"">Orders</span>
                                </a>
                            </li>
                            <li>
                                <a href=""#submenu2"" data-bs-toggle=""collapse"" class=""nav-link px-0 align-middle "">
                                    <i class=""fs-4 bi-bootstrap""></i> <span class=""ms-1 d-none d-sm-inline"">Bootstrap</span>
                                </a>
                                <ul class=""collapse nav flex-column ms-1"" id=""submenu");
                WriteLiteral(@"2"" data-bs-parent=""#menu"">
                                    <li class=""w-100"">
                                        <a href=""#"" class=""nav-link px-0""> <span class=""d-none d-sm-inline"">Item</span> 1</a>
                                    </li>
                                    <li>
                                        <a href=""#"" class=""nav-link px-0""> <span class=""d-none d-sm-inline"">Item</span> 2</a>
                                    </li>
                                </ul>
                            </li>
                            <li>
                                <a href=""#submenu3"" data-bs-toggle=""collapse"" class=""nav-link px-0 align-middle"">
                                    <i class=""fs-4 bi-grid""></i> <span class=""ms-1 d-none d-sm-inline"">Products</span>
                                </a>
                                <ul class=""collapse nav flex-column ms-1"" id=""submenu3"" data-bs-parent=""#menu"">
                                    <li class=""w-100"">
        ");
                WriteLiteral(@"                                <a href=""#"" class=""nav-link px-0""> <span class=""d-none d-sm-inline"">Product</span> 1</a>
                                    </li>
                                    <li>
                                        <a href=""#"" class=""nav-link px-0""> <span class=""d-none d-sm-inline"">Product</span> 2</a>
                                    </li>
                                    <li>
                                        <a href=""#"" class=""nav-link px-0""> <span class=""d-none d-sm-inline"">Product</span> 3</a>
                                    </li>
                                    <li>
                                        <a href=""#"" class=""nav-link px-0""> <span class=""d-none d-sm-inline"">Product</span> 4</a>
                                    </li>
                                </ul>
                            </li>
                            <li>
                                <a href=""#"" class=""nav-link px-0 align-middle"">
                         ");
                WriteLiteral(@"           <i class=""fs-4 bi-people""></i> <span class=""ms-1 d-none d-sm-inline"">Customers</span>
                                </a>
                            </li>
                        </ul>
                        <hr>
                        <div class=""dropdown pb-4"">
                            <a href=""#"" class=""d-flex align-items-center text-white text-decoration-none dropdown-toggle"" id=""dropdownUser1"" data-bs-toggle=""dropdown"" aria-expanded=""false"">
                                <i class=""bi bi-person-fill""></i>
                                <span class=""d-none d-sm-inline mx-1"">Usuário</span>
                            </a>
                            <ul class=""dropdown-menu dropdown-menu-dark text-small shadow"">
                                <li><a class=""dropdown-item"" href=""#"">New project...</a></li>
                                <li><a class=""dropdown-item"" href=""#"">Settings</a></li>
                                <li><a class=""dropdown-item"" href=""#"">Profile</a></l");
                WriteLiteral(@"i>
                                <li>
                                    <hr class=""dropdown-divider"">
                                </li>
                                <li><a class=""dropdown-item"" href=""#"">Sign out</a></li>
                            </ul>
                        </div>
                    </div>
                </div>
                <div class=""col py-3"">
                    Content area...
                </div>
            </div>
        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
    }
}
#pragma warning restore 1591
