#pragma checksum "C:\Users\Jaime A&B\source\repos\Ads\Ads\Views\Anuncios\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c93f4958c2a589660431f487ae79b7f175dad17c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Anuncios_Index), @"mvc.1.0.view", @"/Views/Anuncios/Index.cshtml")]
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
#nullable restore
#line 2 "C:\Users\Jaime A&B\source\repos\Ads\Ads\Views\Anuncios\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c93f4958c2a589660431f487ae79b7f175dad17c", @"/Views/Anuncios/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d603ed97586dc806ef4fd72d47b4bec2faf9c3af", @"/Views/_ViewImports.cshtml")]
    public class Views_Anuncios_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Ads.Models.Anuncio>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("float:left;margin-bottom: 1%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("float:right;margin-bottom: 1%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-group-lg "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css\">\r\n");
            WriteLiteral("    <style>\r\n                ");
            WriteLiteral(@"@import url('https://fonts.googleapis.com/css2?family=Bebas+Neue&family=Bree+Serif&family=EB+Garamond:ital,wght@0,500;1,800&display=swap');


                body {
                    background: #DFC2F2;
                    background-image: linear-gradient( to right, #ffffb3,#ffe6e6);
                    background-attachment: fixed;
                    background-size: cover;
                }

                #container {
                    box-shadow: 0 15px 30px 1px grey;
                    background: rgba(255, 255, 255, 0.90);
                    text-align: center;
                    border-radius: 5px;
                    overflow: hidden;
                    margin: 5em auto;
                    height: 350px;
                    width: 700px;
                }



                .product-details {
                    position: relative;
                    text-align: left;
                    overflow: hidden;
                    padding: 30px;
                    ");
            WriteLiteral(@"height: 100%;
                    float: left;
                    width: 40%;
                }

                #container .product-details h1 {
                    font-family: 'Bebas Neue', cursive;
                    display: inline-block;
                    position: relative;
                    font-size: 30px;
                    color: #344055;
                    margin: 0;
                }

                    #container .product-details h1:before {
                        position: absolute;
                        content: '';
                        right: 0%;
                        top: 0%;
                        transform: translate(25px, -15px);
                        font-family: 'Bree Serif', serif;
                        display: inline-block;
                        background: #ffe6e6;
                        border-radius: 5px;
                        font-size: 14px;
                        padding: 5px;
                        color: white;
         ");
            WriteLiteral(@"               margin: 0;
                        animation: chan-sh 6s ease infinite;
                    }






                .hint-star {
                    display: inline-block;
                    margin-left: 0.5em;
                    color: gold;
                    width: 50%;
                }


                #container .product-details > p {
                    font-family: 'EB Garamond', serif;
                    text-align: center;
                    font-size: 18px;
                    color: #7d7d7d;
                }

                .control {
                    position: absolute;
                    bottom: 20%;
                    left: 22.8%;
                }

                .btn {
                    transform: translateY(0px);
                    transition: 0.3s linear;
                    background: #809fff;
                    border-radius: 5px;
                    position: relative;
                    overflow: hidden;
           ");
            WriteLiteral(@"         cursor: pointer;
                    outline: none;
                    border: none;
                    color: #eee;
                    padding: 0;
                    margin: 0;
                }

                    .btn:hover {
                        transform: translateY(-6px);
                        background: #1a66ff;
                    }

                    .btn span {
                        font-family: 'Farsan', cursive;
                        transition: transform 0.3s;
                        display: inline-block;
                        padding: 10px 20px;
                        font-size: 1.2em;
                        margin: 0;
                    }

                    .btn .price, .shopping-cart {
                        background: #333;
                        border: 0;
                        margin: 0;
                    }

                    .btn .price {
                        transform: translateX(-10%);
                        pad");
            WriteLiteral(@"ding-right: 15px;
                    }

                    .btn .shopping-cart {
                        transform: translateX(-100%);
                        position: absolute;
                        background: #333;
                        z-index: 1;
                        left: 0;
                        top: 0;
                    }

                    .btn .buy {
                        z-index: 3;
                        font-weight: bolder;
                    }

                    .btn:hover .price {
                        transform: translateX(-110%);
                    }

                    .btn:hover .shopping-cart {
                        transform: translateX(0%);
                    }



                .product-image {
                    transition: all 0.3s ease-out;
                    display: inline-block;
                    position: relative;
                    overflow: hidden;
                    height: 100%;
                    float: r");
            WriteLiteral(@"ight;
                    width: 45%;
                    display: inline-block;
                }

                #container img {
                    width: 100%;
                    height: 100%;
                }

                .info {
                    background: rgba(27, 26, 26, 0.9);
                    font-family: 'Bree Serif', serif;
                    transition: all 0.3s ease-out;
                    transform: translateX(-100%);
                    position: absolute;
                    line-height: 1.8;
                    text-align: left;
                    font-size: 105%;
                    cursor: no-drop;
                    color: #FFF;
                    height: 100%;
                    width: 100%;
                    left: 0;
                    top: 0;
                }

                    .info h2 {
                        text-align: center
                    }

                .product-image:hover .info {
                    transform: ");
            WriteLiteral(@"translateX(0);
                }

                .info ul li {
                    transition: 0.3s ease;
                }

                    .info ul li:hover {
                        transform: translateX(50px) scale(1.3);
                    }

                .product-image:hover img {
                    transition: all 0.3s ease-out;
                }

                .product-image:hover img {
                    transform: scale(1.2, 1.2);
                }

                .stars {
                    display: inline-block;
                    width: auto;
                    position: relative;
                    font-size: 28px;
                    border: 2px outset #FC0;
                    border-radius: 5px;
                    background-color: navy;
                    margin: 5px;
                }
                    /*
        the BEFORE:pseudo element. This will represent the number of stars in the actual rating.
        it floats above the AFTER eleme");
            WriteLiteral(@"nt.
        */
                    .stars:BEFORE {
                        content: ""★★★★★"";
                        position: absolute;
                        overflow: hidden;
                        z-index: 1;
                        left: 0px;
                        top: 0px;
                        /* everything below here is optional. */
                        color: #FC0;
                        text-shadow: 0px 1px 0 #000, 0 -1px 0 #fff;
                    }
                    /*
        the AFTER:pseudo element. This will represent the total possible  stars available. It is set to relative to ensure it takes up the proper amount of space.
        */
                    .stars:AFTER {
                        content: ""★★★★★"";
                        position: relative;
                        color: #fff;
                    }
                    /*
        if including user rating controls, float the AFTER element.
        */
                    .stars.rate:AFTER {
    ");
            WriteLiteral(@"                    position: absolute;
                        left: 0px;
                    }
                    /*
        default state for the  user rating controls. invisible, but floating above the BEFORE and AFTER elements
        */
                    .stars.rate > A {
                        color: transparent;
                        text-decoration: none;
                        position: relative;
                        z-index: 2;
                    }
                    /*
        if the user is floating thier mouse above the rating, hide the display stars.
        */
                    .stars.rate:HOVER:BEFORE,
                    .stars.rate:HOVER:AFTER {
                        display: none;
                    }
                    /*
        turn all sthe start ""ON"" by default.
        */
                    .stars.rate:HOVER > A {
                        color: #FC0;
                        text-shadow: 0px 1px 0 #000, 0 -1px 0 #fff;
                    }
");
            WriteLiteral(@"                        /*
        optional style for the specific star control a user is directly above.
        */
                        .stars.rate:HOVER > A:HOVER {
                            color: #FC0;
                            text-shadow: 0px 2px 0 #000, 0 -1px 0 #fff;
                            top: -1px;
                        }
                    /*
        turn ""OFF"" all stars after the one the user is hovering over.
        */
                    .stars.rate > A:HOVER ~ A {
                        color: #fff;
                        text-shadow: none;
                    }
                    /*
          all the styles below are used to display the apropriate portion of the BEFORE element based on percentage rating. unfortunately you will need to create a specific rule for each level of granularity you wish to display.


          if the CSS3 attr() function proposal ever gets implimented
          the remaining rules could all be replaced with the following:
     ");
            WriteLiteral(@"     .stars[data-percent]:BEFORE {
            width:attr(data-percent,%,0);
          }

        */
                    .stars:NOT([data-percent]):BEFORE,
                    .stars[data-percent=""0""]:BEFORE {
                        display: none;
                    }
                    /* 1/2 a star */
                    .stars[data-percent=""10""]:BEFORE {
                        width: 10%;
                    }
                    /* 1 star */
                    .stars[data-percent=""20""]:BEFORE {
                        width: 20%;
                    }
                    /* 1 & 1/2 stars */
                    .stars[data-percent=""30""]:BEFORE {
                        width: 30%;
                    }
                    /* etc. */
                    .stars[data-percent=""40""]:BEFORE {
                        width: 40%;
                    }

                    .stars[data-percent=""50""]:BEFORE {
                        width: 50%;
                    }

               ");
            WriteLiteral(@"     .stars[data-percent=""60""]:BEFORE {
                        width: 60%;
                    }

                    .stars[data-percent=""70""]:BEFORE {
                        width: 70%;
                    }

                    .stars[data-percent=""80""]:BEFORE {
                        width: 80%;
                    }

                    .stars[data-percent=""90""]:BEFORE {
                        width: 90%;
                    }

                    .stars[data-percent=""100""]:BEFORE {
                        width: 100%;
                    }
    </style>
");
#nullable restore
#line 346 "C:\Users\Jaime A&B\source\repos\Ads\Ads\Views\Anuncios\Index.cshtml"





    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h3 class=\"text-black-50\">Anuncios de la semana</h3>\r\n\r\n");
#nullable restore
#line 394 "C:\Users\Jaime A&B\source\repos\Ads\Ads\Views\Anuncios\Index.cshtml"
 if (Context.Session.GetString("roluser") == "2")
{

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c93f4958c2a589660431f487ae79b7f175dad17c18149", async() => {
                WriteLiteral("\r\n    <div class=\"input-group \">\r\n        <div class=\"input-group-append\">\r\n            <input type=\"submit\" class=\"btn btn-outline-secondary\" value=\"Crear Anuncios\" />\r\n\r\n        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 396 "C:\Users\Jaime A&B\source\repos\Ads\Ads\Views\Anuncios\Index.cshtml"
AddHtmlAttributeValue("", 13256, Url.Action("Create", "Anuncios"), 13256, 33, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 404 "C:\Users\Jaime A&B\source\repos\Ads\Ads\Views\Anuncios\Index.cshtml"

}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <b>-</b>\r\n");
#nullable restore
#line 409 "C:\Users\Jaime A&B\source\repos\Ads\Ads\Views\Anuncios\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c93f4958c2a589660431f487ae79b7f175dad17c20565", async() => {
                WriteLiteral(@"
    <div class=""input-group "">
        <input type=""text"" class=""form-control-sm "" name=""buscador"" aria-label=""Text input with segmented dropdown button"">
        <div class=""input-group-append"">
            <input type=""submit"" class=""btn btn-outline-secondary"" value=""Buscar"" />
            <button type=""button"" class=""btn btn-outline-secondary dropdown-toggle dropdown-toggle-split"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                <span class=""sr-only"">Toggle Dropdown</span>
            </button>
            <div class=""dropdown-menu"">
                <label class=""disabled"" style=""margin-left:4%;"">Ordenar por...<i class=""fa fa-arrow-down""></i></label>
                <input class=""dropdown-item"" name=""opcion"" type=""submit"" value=""A - Z"" title=""Ordenar por Nombre"" />
                <input class=""dropdown-item"" name=""opcion"" type=""submit"" value=""Categoria"" title=""Categoria"" />
                <input class=""dropdown-item"" name=""opcion"" type=""submit"" value=""Mayor ");
                WriteLiteral("votado\" title=\"Mayor votacion\" />\r\n                <input class=\"dropdown-item\" name=\"opcion\" type=\"submit\" value=\"Menor votado\" title=\"Menor votacion\" />\r\n\r\n");
                WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 413 "C:\Users\Jaime A&B\source\repos\Ads\Ads\Views\Anuncios\Index.cshtml"
AddHtmlAttributeValue("", 13588, Url.Action("Index", "Anuncios"), 13588, 32, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n\r\n");
#nullable restore
#line 437 "C:\Users\Jaime A&B\source\repos\Ads\Ads\Views\Anuncios\Index.cshtml"
 foreach (var item in Model)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div id=\"container\">\r\n\r\n        <div class=\"product-details\">\r\n\r\n            <h1>");
#nullable restore
#line 444 "C:\Users\Jaime A&B\source\repos\Ads\Ads\Views\Anuncios\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NombreAd));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n\r\n            <p class=\"information\">");
#nullable restore
#line 447 "C:\Users\Jaime A&B\source\repos\Ads\Ads\Views\Anuncios\Index.cshtml"
                              Write(Html.DisplayFor(modelItem => item.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c93f4958c2a589660431f487ae79b7f175dad17c24851", async() => {
                WriteLiteral("\r\n\r\n                <input type=\"submit\" name=\"em\" class=\"btn btn-outline-secondary\" hidden");
                BeginWriteAttribute("value", " value=\"", 15533, "\"", 15604, 1);
#nullable restore
#line 450 "C:\Users\Jaime A&B\source\repos\Ads\Ads\Views\Anuncios\Index.cshtml"
WriteAttributeValue("", 15541, Html.DisplayFor(modelItem => item.IdTipoadNavigation.IdTipoad), 15541, 63, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                <input type=\"submit\" name=\"btnfiltro\" class=\"btn btn-outline-secondary\"");
                BeginWriteAttribute("value", " value=\"", 15697, "\"", 15773, 1);
#nullable restore
#line 451 "C:\Users\Jaime A&B\source\repos\Ads\Ads\Views\Anuncios\Index.cshtml"
WriteAttributeValue("", 15705, Html.DisplayFor(modelItem => item.IdTipoadNavigation.CategoriaName), 15705, 68, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 448 "C:\Users\Jaime A&B\source\repos\Ads\Ads\Views\Anuncios\Index.cshtml"
AddHtmlAttributeValue("", 15357, Url.Action("Index", "Anuncios"), 15357, 32, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n");
            WriteLiteral("\r\n            <div class=\"container-fluid\">\r\n\r\n");
#nullable restore
#line 461 "C:\Users\Jaime A&B\source\repos\Ads\Ads\Views\Anuncios\Index.cshtml"
                  

                    var puntajerel = Model.Where(x => x.IdTipoadNavigation.CategoriaName.Contains(item.IdTipoadNavigation.CategoriaName)).Count();

                    double p = 0.05;
                    

                    ViewBag.prom = Convert.ToInt32(item.Calificacion * p);
                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"stars\" data-percent=\"");
#nullable restore
#line 471 "C:\Users\Jaime A&B\source\repos\Ads\Ads\Views\Anuncios\Index.cshtml"
                                            Write(item.Calificacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"> </div> - <b>");
#nullable restore
#line 471 "C:\Users\Jaime A&B\source\repos\Ads\Ads\Views\Anuncios\Index.cshtml"
                                                                             Write(ViewBag.prom);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</b> <br>




            </div>



            <div class=""card-body"">
                <button class=""btn btn-primary btn-lg btn-block"">
                    <span class=""price"">➥</span>
                    <span class=""shopping-cart""><i class=""fa fa-shopping-cart"" aria-hidden=""true""></i></span>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c93f4958c2a589660431f487ae79b7f175dad17c29460", async() => {
                WriteLiteral("MAS DETALLES!");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 484 "C:\Users\Jaime A&B\source\repos\Ads\Ads\Views\Anuncios\Index.cshtml"
                                                                        WriteLiteral(item.IdAd);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </button>\r\n            </div>\r\n\r\n\r\n\r\n            <div class=\"control\">\r\n\r\n\r\n\r\n            </div>\r\n\r\n        </div>\r\n\r\n        <div class=\"product-image\">\r\n\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 16996, "\"", 17079, 1);
#nullable restore
#line 500 "C:\Users\Jaime A&B\source\repos\Ads\Ads\Views\Anuncios\Index.cshtml"
WriteAttributeValue("", 17002, Url.Action("convertirImagen","Anuncios",new { codigo = item.IdAd, img = 1 }), 17002, 77, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 17080, "\"", 17086, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n\r\n            <div class=\"info\">\r\n                <h2> Description</h2>\r\n                <ul>\r\n");
            WriteLiteral("\r\n                </ul>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n");
            WriteLiteral("    <!--<div class=\"row\">-->\r\n");
            WriteLiteral("    <!-- Card deck -->\r\n    <!--<div class=\"\">\r\n\r\n        <div class=\"col-sm-6 col-md-4\">-->\r\n    <!-- Card -->\r\n    <!--<div class=\"card\">-->\r\n");
            WriteLiteral("    <!--Card image-->\r\n    <!--<div class=\"view overlay\">\r\n        <img class=\"card-img-top\" src=\"\" alt=\"Card image cap\">\r\n        <a href=\"#!\">\r\n            <div class=\"mask rgba-white-slight\"></div>\r\n        </a>\r\n    </div>-->\r\n");
            WriteLiteral("    <!--Card content-->\r\n    <!--<div class=\"card-body\">-->\r\n");
            WriteLiteral(@"    <!--Title-->
    <!--<h4 class=""card-title""></h4>-->
    <!--Text-->
    <!--<p class=""card-text""></p>-->
    <!-- Provides extra visual weight and identifies the primary action in a set of buttons -->
    <!--<button type=""button"" class=""btn btn-light-blue btn-md"">MAS INFORMACION</button>
            <a class=""badge ba"">");
#nullable restore
#line 545 "C:\Users\Jaime A&B\source\repos\Ads\Ads\Views\Anuncios\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.IdTipoadNavigation.CategoriaName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\r\n\r\n\r\n        </div>\r\n\r\n    </div>-->\r\n    <!-- Card -->\r\n    <!--</div>\r\n    </div>-->\r\n    <!-- Card deck -->\r\n");
            WriteLiteral("    <!--</div>-->\r\n");
#nullable restore
#line 581 "C:\Users\Jaime A&B\source\repos\Ads\Ads\Views\Anuncios\Index.cshtml"
               
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Ads.Models.Anuncio>> Html { get; private set; }
    }
}
#pragma warning restore 1591