#pragma checksum "C:\Users\Jaime A&B\source\repos\Ads\Ads\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "012569794c491b4aaeb67f0ca760b78cabab0915"
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
#line 1 "C:\Users\Jaime A&B\source\repos\Ads\Ads\Views\_ViewImports.cshtml"
using Ads;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jaime A&B\source\repos\Ads\Ads\Views\_ViewImports.cshtml"
using Ads.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"012569794c491b4aaeb67f0ca760b78cabab0915", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d603ed97586dc806ef4fd72d47b4bec2faf9c3af", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Tusers/Iniciar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Tusers/Registrar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"    <style>
        body {
            margin: 0;
            color: #6a6f8c;
            background: #c8c8c8;
            font: 600 16px/18px 'Open Sans',sans-serif;
        }

        *, :after, :before {
            box-sizing: border-box
        }

        .clearfix:after, .clearfix:before {
            content: '';
            display: table
        }

        .clearfix:after {
            clear: both;
            display: block
        }

        a {
            color: inherit;
            text-decoration: none
        }

        .login-wrap {
            width: 100%;
            margin: auto;
            max-width: 525px;
            min-height: 670px;
            position: relative;
            background: url(https://raw.githubusercontent.com/khadkamhn/day-01-login-form/master/img/bg.jpg) no-repeat center;
            box-shadow: 0 12px 15px 0 rgba(0,0,0,.24),0 17px 50px 0 rgba(0,0,0,.19);
        }

        .login-html {
            width: 100%;
            hei");
            WriteLiteral(@"ght: 100%;
            position: absolute;
            padding: 90px 70px 50px 70px;
            background: rgba(40,57,101,.9);
        }

            .login-html .sign-in-htm,
            .login-html .sign-up-htm {
                top: 0;
                left: 0;
                right: 0;
                bottom: 0;
                position: absolute;
                transform: rotateY(180deg);
                backface-visibility: hidden;
                transition: all .4s linear;
            }

            .login-html .sign-in,
            .login-html .sign-up,
            .login-form .group .check {
                display: none;
            }

            .login-html .tab,
            .login-form .group .label,
            .login-form .group .button {
                text-transform: uppercase;
            }

            .login-html .tab {
                font-size: 22px;
                margin-right: 15px;
                padding-bottom: 5px;
                margin: 0 15");
            WriteLiteral(@"px 10px 0;
                display: inline-block;
                border-bottom: 2px solid transparent;
            }

            .login-html .sign-in:checked + .tab,
            .login-html .sign-up:checked + .tab {
                color: #fff;
                border-color: #1161ee;
            }

        .login-form {
            min-height: 345px;
            position: relative;
            perspective: 1000px;
            transform-style: preserve-3d;
        }

            .login-form .group {
                margin-bottom: 15px;
            }

                .login-form .group .label,
                .login-form .group .input,
                .login-form .group .button {
                    width: 100%;
                    color: #fff;
                    display: block;
                }

                .login-form .group .input,
                .login-form .group .button {
                    border: none;
                    padding: 15px 20px;
                   ");
            WriteLiteral(@" border-radius: 25px;
                    background: rgba(255,255,255,.1);
                }

                .login-form .group input[data-type=""password""] {
                    text-security: circle;
                    -webkit-text-security: circle;
                }

                .login-form .group .label {
                    color: #aaa;
                    font-size: 12px;
                }

                .login-form .group .button {
                    background: #1161ee;
                }

                .login-form .group label .icon {
                    width: 15px;
                    height: 15px;
                    border-radius: 2px;
                    position: relative;
                    display: inline-block;
                    background: rgba(255,255,255,.1);
                }

                    .login-form .group label .icon:before,
                    .login-form .group label .icon:after {
                        content: '';
                ");
            WriteLiteral(@"        width: 10px;
                        height: 2px;
                        background: #fff;
                        position: absolute;
                        transition: all .2s ease-in-out 0s;
                    }

                    .login-form .group label .icon:before {
                        left: 3px;
                        width: 5px;
                        bottom: 6px;
                        transform: scale(0) rotate(0);
                    }

                    .login-form .group label .icon:after {
                        top: 6px;
                        right: 0;
                        transform: scale(0) rotate(0);
                    }

                .login-form .group .check:checked + label {
                    color: #fff;
                }

                    .login-form .group .check:checked + label .icon {
                        background: #1161ee;
                    }

                        .login-form .group .check:checked + label .i");
            WriteLiteral(@"con:before {
                            transform: scale(1) rotate(45deg);
                        }

                        .login-form .group .check:checked + label .icon:after {
                            transform: scale(1) rotate(-45deg);
                        }

        .login-html .sign-in:checked + .tab + .sign-up + .tab + .login-form .sign-in-htm {
            transform: rotate(0);
        }

        .login-html .sign-up:checked + .tab + .login-form .sign-up-htm {
            transform: rotate(0);
        }

        .hr {
            height: 2px;
            margin: 60px 0 50px 0;
            background: rgba(255,255,255,.2);
        }

        .foot-lnk {
            text-align: center;
        }
    </style>
");
            WriteLiteral(@"

<div class=""login-wrap"">
    <div class=""login-html"">
        <input id=""tab-1"" type=""radio"" name=""tab"" class=""sign-in"" checked><label for=""tab-1"" class=""tab"">Iniciar Sesion</label>
        <input id=""tab-2"" type=""radio"" name=""tab"" class=""sign-up""><label for=""tab-2"" class=""tab"">Registrar</label>
        
                                                                  <div class=""login-form"">
                                                                      ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "012569794c491b4aaeb67f0ca760b78cabab091511138", async() => {
                WriteLiteral(@"
                                                                          <div class=""sign-in-htm"">
                                                                              <div class=""group"">
                                                                                  <label for=""user"" class=""label"">Usuario</label>
                                                                                  <input id=""user"" type=""text"" class=""input"" name=""usuario"">
                                                                              </div>
                                                                              <div class=""group"">
                                                                                  <label for=""pass"" class=""label"">Contraseña</label>
                                                                                  <input id=""pass"" type=""password"" class=""input"" data-type=""password"" name=""contra"">
                                                                ");
                WriteLiteral("              </div>\r\n                                                                              <div class=\"group\">\r\n");
                WriteLiteral(@"                                                                              </div>
                                                                              <div class=""group"">
                                                                                  <input type=""submit"" class=""button"" value=""Iniciar Sesion"">
                                                                              </div>
                                                                              <div class=""hr""></div>
                                                                              <div class=""foot-lnk"">
");
                WriteLiteral("                                                                              </div>\r\n                                                                          </div>\r\n                                                                      ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                                                                      ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "012569794c491b4aaeb67f0ca760b78cabab091514968", async() => {
                WriteLiteral(@"

                                                                          <div class=""sign-up-htm"">
                                                                              <div class=""group"">
                                                                                  <label for=""user"" class=""label"">Usuario</label>
                                                                                  <input id=""user"" type=""text"" name=""usernew"" class=""input"">
                                                                              </div>
                                                                              <div class=""group"">
                                                                                  <label for=""pass"" class=""label"">Contraseña</label>
                                                                                  <input id=""pass"" type=""password"" class=""input"" name=""passnew"" data-type=""password"">
                                                             ");
                WriteLiteral(@"                 </div>
                                                                              <div class=""group"">
                                                                                  <input type=""submit"" class=""button"" value=""Registrarse"">
                                                                              </div>
                                                                              <div class=""hr""></div>
                                                                              <div class=""foot-lnk"">
                                                                                  <label for=""tab-1"">Ya estas registrado</label>
                                                                              </div>
                                                                          </div>
                                                                      ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                                          \r\n                                                                  </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
