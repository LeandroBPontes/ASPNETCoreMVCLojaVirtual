#pragma checksum "C:\Users\leand\Desktop\PROJETOS\ASPNETCoreMVCLojaVirtual\Seção 07\LojaVirtual\Views\Home\CarrinhoCompras.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2f5cbd4546a7b3596e6973bc84d4b21b339cb89"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CarrinhoCompras), @"mvc.1.0.view", @"/Views/Home/CarrinhoCompras.cshtml")]
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
#line 2 "C:\Users\leand\Desktop\PROJETOS\ASPNETCoreMVCLojaVirtual\Seção 07\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2f5cbd4546a7b3596e6973bc84d4b21b339cb89", @"/Views/Home/CarrinhoCompras.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbe432dc0fde64388285e47294a860c879dd4e8c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CarrinhoCompras : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"    <main role=""main"">

        <section class=""container"" id=""order"" style=""margin-top: 50px"">

            <h2 class=""title-doc""># Order </h2>


            <h4 class=""subtitle-doc"">
                # Shopping cart
                <a href=""#"" data-html=""code_cart"" class=""showcode"">[code]</a>
            </h4>
            <div id=""code_cart"">
                <div class=""card"">
                    <table class=""table table-hover shopping-cart-wrap"">
                        <thead class=""text-muted"">
                            <tr>
                                <th scope=""col"">Product</th>
                                <th scope=""col"" width=""120"">Quantity</th>
                                <th scope=""col"" width=""120"">Price</th>
                                <th scope=""col"" width=""200"" class=""text-right"">Action</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <");
            WriteLiteral(@"td>
                                    <figure class=""media"">
                                        <div class=""img-wrap""><img src=""images/items/1.jpg"" class=""img-thumbnail img-sm""></div>
                                        <figcaption class=""media-body"">
                                            <h6 class=""title text-truncate"">Product name goes here </h6>
                                            <dl class=""dlist-inline small"">
                                                <dt>Size: </dt>
                                                <dd>XXL</dd>
                                            </dl>
                                            <dl class=""dlist-inline small"">
                                                <dt>Color: </dt>
                                                <dd>Orange color</dd>
                                            </dl>
                                        </figcaption>
                                    </figure>
                             ");
            WriteLiteral("   </td>\r\n                                <td>\r\n                                    <select class=\"form-control\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2f5cbd4546a7b3596e6973bc84d4b21b339cb895345", async() => {
                WriteLiteral("1");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2f5cbd4546a7b3596e6973bc84d4b21b339cb896338", async() => {
                WriteLiteral("2");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2f5cbd4546a7b3596e6973bc84d4b21b339cb897331", async() => {
                WriteLiteral("3");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2f5cbd4546a7b3596e6973bc84d4b21b339cb898324", async() => {
                WriteLiteral("4");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    </select>
                                </td>
                                <td>
                                    <div class=""price-wrap"">
                                        <var class=""price"">USD 145</var>
                                        <small class=""text-muted"">(USD5 each)</small>
                                    </div> <!-- price-wrap .// -->
                                </td>
                                <td class=""text-right"">
                                    <a");
            BeginWriteAttribute("title", " title=\"", 2958, "\"", 2966, 0);
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 2967, "\"", 2974, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\" data-toggle=\"tooltip\"\r\n                                       data-original-title=\"Save to Wishlist\"> <i class=\"fa fa-heart\"></i></a>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 3181, "\"", 3188, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-outline-danger""> × Remove</a>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <figure class=""media"">
                                        <div class=""img-wrap""><img src=""images/items/2.jpg"" class=""img-thumbnail img-sm""></div>
                                        <figcaption class=""media-body"">
                                            <h6 class=""title text-truncate"">Product name goes here </h6>
                                            <dl class=""dlist-inline small"">
                                                <dt>Size: </dt>
                                                <dd>XXL</dd>
                                            </dl>
                                            <dl class=""dlist-inline small"">
                                                <dt>Color: </dt>
                                                <dd>Orange color<");
            WriteLiteral(@"/dd>
                                            </dl>
                                        </figcaption>
                                    </figure>
                                </td>
                                <td>
                                    <select class=""form-control"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2f5cbd4546a7b3596e6973bc84d4b21b339cb8911862", async() => {
                WriteLiteral("1");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2f5cbd4546a7b3596e6973bc84d4b21b339cb8912856", async() => {
                WriteLiteral("2");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2f5cbd4546a7b3596e6973bc84d4b21b339cb8913850", async() => {
                WriteLiteral("3");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2f5cbd4546a7b3596e6973bc84d4b21b339cb8914844", async() => {
                WriteLiteral("4");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    </select>
                                </td>
                                <td>
                                    <div class=""price-wrap"">
                                        <var class=""price"">USD 35</var>
                                        <small class=""text-muted"">(USD10 each)</small>
                                    </div> <!-- price-wrap .// -->
                                </td>
                                <td class=""text-right"">
                                    <a");
            BeginWriteAttribute("title", " title=\"", 5305, "\"", 5313, 0);
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 5314, "\"", 5321, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\" data-toggle=\"tooltip\"\r\n                                       data-original-title=\"Save to Wishlist\"> <i class=\"fa fa-heart\"></i></a>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 5528, "\"", 5535, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-outline-danger btn-round""> × Remove</a>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <figure class=""media"">
                                        <div class=""img-wrap""><img src=""images/items/3.jpg"" class=""img-thumbnail img-sm""></div>
                                        <figcaption class=""media-body"">
                                            <h6 class=""title text-truncate"">Product name goes here </h6>
                                            <dl class=""dlist-inline small"">
                                                <dt>Size: </dt>
                                                <dd>XXL</dd>
                                            </dl>
                                            <dl class=""dlist-inline small"">
                                                <dt>Color: </dt>
                                                <dd>Ora");
            WriteLiteral(@"nge color</dd>
                                            </dl>
                                        </figcaption>
                                    </figure>
                                </td>
                                <td>
                                    <select class=""form-control"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2f5cbd4546a7b3596e6973bc84d4b21b339cb8918393", async() => {
                WriteLiteral("1");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2f5cbd4546a7b3596e6973bc84d4b21b339cb8919387", async() => {
                WriteLiteral("2");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2f5cbd4546a7b3596e6973bc84d4b21b339cb8920381", async() => {
                WriteLiteral("3");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2f5cbd4546a7b3596e6973bc84d4b21b339cb8921375", async() => {
                WriteLiteral("4");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    </select>
                                </td>
                                <td>
                                    <div class=""price-wrap"">
                                        <var class=""price"">USD 45</var>
                                        <small class=""text-muted"">(USD15 each)</small>
                                    </div> <!-- price-wrap .// -->
                                </td>
                                <td class=""text-right"">
                                    <a");
            BeginWriteAttribute("title", " title=\"", 7662, "\"", 7670, 0);
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 7671, "\"", 7678, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\" data-toggle=\"tooltip\"\r\n                                       data-original-title=\"Save to Wishlist\"> <i class=\"fa fa-heart\"></i></a>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 7885, "\"", 7892, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-outline-danger btn-round""> × Remove</a>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </div> <!-- card.// -->
            </div> <!-- code-wrap.// -->
        </section>
        <br />
        <br />
        <section class=""container"">
            <div class=""row"">
                <aside class=""col-md-4"">
                    <h4 class=""subtitle-doc"">
                        # Cálculo de frete
                        <a href=""#"" data-html=""code_desc_simple"" class=""showcode"">[code]</a>
                    </h4>
                    <div id=""code_desc_simple"">
                        <div class=""box"">
                            <dl>
                                <dt>Some info: </dt>
                                <dd>
                                    Dolor sit amet, consectetur adipisicing elit do eiusmod
                                    tempor incididunt
      ");
            WriteLiteral(@"                          </dd>
                            </dl>
                            <dl>
                                <dt>Parameter: </dt>
                                <dd>Value name</dd>
                            </dl>
                            <dl>
                                <dt>Discount:</dt>
                                <dd>USD 658</dd>
                            </dl>
                        </div> <!-- box.// -->
                    </div> <!-- code-wrap.// -->
                </aside>
                <aside class=""col-md-4"">
                    <h4 class=""subtitle-doc"">
                        # Cupom desconto
                        <a href=""#"" data-html=""code_desc_align"" class=""showcode"">[code]</a>
                    </h4>
                    <div id=""code_desc_align"">
                        <div class=""box"">
                            <dl class=""dlist-align"">
                                <dt>Some info: </dt>
                                <dd");
            WriteLiteral(@"> Everything in this life is always tempporary</dd>
                            </dl>
                            <dl class=""dlist-align"">
                                <dt>Parameter: </dt>
                                <dd>Value name</dd>
                            </dl>
                            <dl class=""dlist-align"">
                                <dt>Color:</dt>
                                <dd>Orange and Black</dd>
                            </dl>
                            <dl class=""dlist-align"">
                                <dt>Material:</dt>
                                <dd>Leather</dd>
                            </dl>
                        </div> <!-- box.// -->
                    </div> <!-- code-wrap.// -->
                </aside>
                <aside class=""col-md-4"">
                    <h4 class=""subtitle-doc"">
                        # Total a pagar
                        <a href=""#"" data-html=""code_desc_right"" class=""showcode"">[code]</a>
     ");
            WriteLiteral(@"               </h4>
                    <div id=""code_desc_right"">
                        <div class=""box"">
                            <dl class=""dlist-align"">
                                <dt>Parameter: </dt>
                                <dd class=""text-right"">Value name</dd>
                            </dl>
                            <dl class=""dlist-align"">
                                <dt>Color:</dt>
                                <dd class=""text-right"">Orange and Black</dd>
                            </dl>
                            <dl class=""dlist-align"">
                                <dt>Material:</dt>
                                <dd class=""text-right"">Leather</dd>
                            </dl>
                            <dl class=""dlist-align"">
                                <dt>Total cost: </dt>
                                <dd class=""text-right h5 b""> USD195 </dd>
                            </dl>
                        </div> <!-- box.// -->
   ");
            WriteLiteral("                 </div> <!-- code-wrap.// -->\r\n                </aside>\r\n            </div>\r\n        </section>\r\n    </main>\r\n");
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
