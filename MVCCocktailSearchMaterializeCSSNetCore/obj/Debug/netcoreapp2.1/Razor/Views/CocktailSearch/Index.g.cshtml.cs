#pragma checksum "C:\Users\casti\source\repos\MVCCocktailSearchMaterializeCSSNetCore\MVCCocktailSearchMaterializeCSSNetCore\Views\CocktailSearch\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f255896f0abe297773e0dfaab6c927a0f866a55"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CocktailSearch_Index), @"mvc.1.0.view", @"/Views/CocktailSearch/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CocktailSearch/Index.cshtml", typeof(AspNetCore.Views_CocktailSearch_Index))]
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
#line 1 "C:\Users\casti\source\repos\MVCCocktailSearchMaterializeCSSNetCore\MVCCocktailSearchMaterializeCSSNetCore\Views\_ViewImports.cshtml"
using MVCCocktailSearchMaterializeCSSNetCore;

#line default
#line hidden
#line 2 "C:\Users\casti\source\repos\MVCCocktailSearchMaterializeCSSNetCore\MVCCocktailSearchMaterializeCSSNetCore\Views\_ViewImports.cshtml"
using MVCCocktailSearchMaterializeCSSNetCore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f255896f0abe297773e0dfaab6c927a0f866a55", @"/Views/CocktailSearch/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04fd53cc1c3272ea5bc9cb531cf09688846ecc44", @"/Views/_ViewImports.cshtml")]
    public class Views_CocktailSearch_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("autocomplete", new global::Microsoft.AspNetCore.Html.HtmlString("off"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\casti\source\repos\MVCCocktailSearchMaterializeCSSNetCore\MVCCocktailSearchMaterializeCSSNetCore\Views\CocktailSearch\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(90, 127, true);
            WriteLiteral("\r\n<h2>Cocktail Search</h2>\r\n\r\n<table width=\"350\" align=\"center\">\r\n    <tbody>\r\n        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(217, 559, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d302aa8670b54d24a6e7f8044858fb27", async() => {
                BeginContext(262, 507, true);
                WriteLiteral(@"
                    <div class=""input-group"">
                        <input type=""text"" name=""s"" id=""txtCocktailToSearch"" class=""form-control"" autocomplete=""off"" placeholder=""Search for a Cocktail..."">
                        <div class=""input-group-btn"">
                            <button type=""button"" class=""btn btn-default"" onclick=""BuscarCocktelesPorTexto()""><span class=""glyphicon glyphicon-search""></span></button>
                        </div>
                    </div>
                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(776, 62, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n    </tbody>\r\n</table>\r\n\r\n");
            EndContext();
            BeginContext(996, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(1071, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(3718, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(3945, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(4625, 12, true);
            WriteLiteral("<!--col-->\r\n");
            EndContext();
            BeginContext(7251, 14, true);
            WriteLiteral("\r\n<!--col-->\r\n");
            EndContext();
            BeginContext(8130, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(8156, 8884, true);
            WriteLiteral(@"
<!--Import Google Icon Font-->
<link href=""https://fonts.googleapis.com/icon?family=Material+Icons"" rel=""stylesheet"">

<!-- Compiled and minified CSS -->
<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/materialize/1.0.0/css/materialize.min.css"">


<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js""></script>
<!-- Compiled and minified JavaScript -->
<script src=""https://cdnjs.cloudflare.com/ajax/libs/materialize/1.0.0/js/materialize.min.js""></script>

<script type=""text/javascript"">

    $(document).ready(function () {


        //$.ajax({
        //    type: 'GET',
        //    url: '/CocktailSearch/ObtenerCoctelesPopulares',
        //    success: function (result) {
        //        console.log(result.data);
        //    }
        //});

    });

    function BuscarCocktelesPorTexto() {

        var texto = $(""#txtCocktailToSearch"").val();
        if (texto.length > 0) {

            $(""div"").remove("".row"");

            $");
            WriteLiteral(@".ajax({
                type: 'GET',
                url: '/CocktailSearch/BuscarCocktelesPorTexto',
                data: { texto: texto },
                success: function (result) {
                    console.log(result.data);

                    //localStorage.clear();

                    var Favoritos = [];

                    if (localStorage.Favoritos) {
                        //Si existe en el storage
                        //convert json string to javascript object
                        Favoritos = JSON.parse(localStorage.getItem(""Favoritos""))
                    }

                    //console.log('Ya existen, estos favoritos');
                    //console.log(Favoritos);

                    var filas = Math.floor(result.data.length / 4);
                    var residuo = result.data.length % 4;

                    for (fila = 1; fila <= filas; fila++) {

                        jQuery('<div>', {
                            id: 'row' + fila,
                 ");
            WriteLiteral(@"           class: 'row',
                            //title: 'now this div has a title!'
                            //   }).appendTo('#containerBodyFromLayout');
                        }).insertBefore('#footer');


                        for (imagen = 1; imagen <= 4; imagen++) {

                            var imagenActual = (fila - 1) * 4 + imagen;

                            jQuery('<div>', {
                                id: 'cocktail' + imagenActual,
                                class: 'col s12 m3'
                            }).appendTo('#row' + fila);

                            jQuery('<div>', {
                                id: 'card' + imagenActual,
                                class: 'card small'
                            }).appendTo('#cocktail' + imagenActual);
                            //$(""#center"").append(txt1, txt2, txt3);

                            //var div = $(""#card"" + imagenActual);

                            //div.attr(""style"", ""height:200px");
            WriteLiteral(@";"");

                            jQuery('<div>', {
                                id: 'card-image' + imagenActual,
                                class: 'card-image'
                            }).appendTo('#card' + imagenActual);

                            //<a class=""waves-effect waves-light btn"">button</a>

                            //jQuery('<a>', {
                            //    id: 'AgregaAFavoritos' + imagenActual,
                            //    class: 'waves-effect waves-light btn tooltipped',
                            //    style: 'margin-top: 10%;',
                            //    text: 'Agregar A Favoritos'
                            //    //onclick: function()
                            //}).appendTo('#card' + imagenActual);

                            var idDrink = result.data[imagenActual - 1].idDrink;
                            var strDrink = result.data[imagenActual - 1].strDrink
                            var strDrinkThumb = result.data[imagenActual - ");
            WriteLiteral(@"1].strDrinkThumb;


                            var parametrosParaAgregarAFavoritos = ""'"" + imagenActual + "","" + idDrink + "","" + strDrink.replace(""'"", """") + "","" + strDrinkThumb + ""'"";
                            var parametrosParaEliminarDeFavoritos = ""'"" + imagenActual + "","" + idDrink + "","" + strDrink.replace(""'"", """") + "","" + strDrinkThumb + ""'"";
                            console.log(parametrosParaAgregarAFavoritos);

                            if (Favoritos.length > 0) {
                                if (Favoritos.some(e => e.idDrink == idDrink)) {
                                    /* Favoritos contiene el elemento buscado */

                                    jQuery('<button>', {
                                        id: 'EliminarDeFavoritos' + imagenActual,
                                        class: 'waves-effect waves-light btn tooltipped',
                                        style: 'margin-top: 10%; margin-left: 5%',
                                        text: 'Elimin");
            WriteLiteral(@"ar De Favoritos',
                                        onclick: 'EliminarDeFavoritos(' + parametrosParaEliminarDeFavoritos + ')'
                                    }).appendTo('#card' + imagenActual);

                                }
                                else {

                                    jQuery('<button>', {
                                        id: 'AgregarAFavoritos' + imagenActual,
                                        class: 'waves-effect waves-light btn tooltipped',
                                        style: 'margin-top: 10%; margin-left: 5%',
                                        text: 'Agregar A Favoritos',
                                        onclick: ""AgregarAFavoritos("" + parametrosParaAgregarAFavoritos + "")""
                                    }).appendTo('#card' + imagenActual);
                                }
                            }
                            else {
                                jQuery('<button>', {
            ");
            WriteLiteral(@"                        id: 'AgregarAFavoritos' + imagenActual,
                                    class: 'waves-effect waves-light btn tooltipped',
                                    style: 'margin-top: 10%; margin-left: 5%',
                                    text: 'Agregar A Favoritos',
                                    onclick: ""AgregarAFavoritos("" + parametrosParaAgregarAFavoritos + "")""
                                }).appendTo('#card' + imagenActual);
                            }

                            //$('<a class=""waves-effect waves-light btn>Agrega a favoritos</a>').appendTo(""#card"" + imagenActual);

                            //<button class=""btn waves-effect waves-light"" type=""submit"" name=""action"">Submit

                            //$(""#center"").append(txt1, txt2, txt3);

                            //jQuery('<image>', {
                            //    id: 'image' + i,
                            //    src: 'https://static.pexels.com/photos/5741/nature-sunset-cl");
            WriteLiteral(@"ouds-lake-large.jpg'
                            //}).appendTo('#card-image1');


                            var imagenActual = (fila - 1) * 4 + imagen;

                            //var img = $('<img id=""image"" + imagen>'); //Equivalent: $(document.createElement('img'))
                            var img = $('<img>'); //Equivalent: $(document.createElement('img'))
                            img.attr('src', strDrinkThumb);
                            img.appendTo('#card-image' + imagenActual);


                            //jQuery('<div>', {
                            //    id: 'card-content' + imagenActual,
                            //    class: 'card-content'
                            //}).appendTo('#card' + imagenActual);


                            //var parrafoStrDrink = $(""<p></p>"").text(strDrink);

                            ////se puede hacer de cualquier forma
                            ////$(""#card-content"" + imagenActual).append(parrafoStrDrink);
                ");
            WriteLiteral(@"            //$('<p>' + strDrink + '</p>').appendTo(""#card-content"" + imagenActual);


                            jQuery('<div>', {
                                id: 'card-action' + imagenActual,
                                class: 'card-action'
                            }).appendTo('#card' + imagenActual);


                            //var Drink = result.data[imagenActual - 1];

                            //console.log(result.data[imagenActual - 1]);

                            //console.log(idDrink);

                            //<a href=""#"">This is a link</a>

                            //este es el b??sico:
                            //$('<a href=""");
            EndContext();
            BeginContext(17041, 37, false);
#line 362 "C:\Users\casti\source\repos\MVCCocktailSearchMaterializeCSSNetCore\MVCCocktailSearchMaterializeCSSNetCore\Views\CocktailSearch\Index.cshtml"
                                     Write(Url.Action("Drink", "CocktailSearch"));

#line default
#line hidden
            EndContext();
            BeginContext(17078, 109, true);
            WriteLiteral("\">\' + strDrink + \'</a>\').appendTo(\"#card-action\" + imagenActual);\r\n                            //$(\'<a href=\"");
            EndContext();
            BeginContext(17188, 64, false);
#line 363 "C:\Users\casti\source\repos\MVCCocktailSearchMaterializeCSSNetCore\MVCCocktailSearchMaterializeCSSNetCore\Views\CocktailSearch\Index.cshtml"
                                     Write(Url.Action("Drink", "CocktailSearch", new { IdDrink = "10007" }));

#line default
#line hidden
            EndContext();
            BeginContext(17252, 109, true);
            WriteLiteral("\">\' + strDrink + \'</a>\').appendTo(\"#card-action\" + imagenActual);\r\n                            //$(\'<a href=\"");
            EndContext();
            BeginContext(17362, 61, false);
#line 364 "C:\Users\casti\source\repos\MVCCocktailSearchMaterializeCSSNetCore\MVCCocktailSearchMaterializeCSSNetCore\Views\CocktailSearch\Index.cshtml"
                                     Write(Url.Action("Drink", "CocktailSearch", new { Drink = "Hola" }));

#line default
#line hidden
            EndContext();
            BeginContext(17423, 110, true);
            WriteLiteral("\">\' + strDrink + \'</a>\').appendTo(\"#card-action\" + imagenActual);\r\n\r\n                            //var url = \"");
            EndContext();
            BeginContext(17534, 37, false);
#line 366 "C:\Users\casti\source\repos\MVCCocktailSearchMaterializeCSSNetCore\MVCCocktailSearchMaterializeCSSNetCore\Views\CocktailSearch\Index.cshtml"
                                    Write(Url.Action("Drink", "CocktailSearch"));

#line default
#line hidden
            EndContext();
            BeginContext(17571, 124, true);
            WriteLiteral("/\" + idDrink + \">\' + strDrink + \'</a>\').appendTo(\'#card-action\'\" + imagenActual);\r\n\r\n                            var url = \"");
            EndContext();
            BeginContext(17696, 37, false);
#line 368 "C:\Users\casti\source\repos\MVCCocktailSearchMaterializeCSSNetCore\MVCCocktailSearchMaterializeCSSNetCore\Views\CocktailSearch\Index.cshtml"
                                  Write(Url.Action("Drink", "CocktailSearch"));

#line default
#line hidden
            EndContext();
            BeginContext(17733, 381, true);
            WriteLiteral(@"/?IdDrink="" + idDrink;

                            $('<a href=' + url + '>' + strDrink + '</a>').appendTo(""#card-action"" + imagenActual);

                            //var peticionIdDrink = ""?/IdDrink="" + idDrink;

                            //url = url.replace(""param-id"", id)
                            //    .replace(""param-name"", name);

            //$('<a href=""");
            EndContext();
            BeginContext(18115, 37, false);
#line 377 "C:\Users\casti\source\repos\MVCCocktailSearchMaterializeCSSNetCore\MVCCocktailSearchMaterializeCSSNetCore\Views\CocktailSearch\Index.cshtml"
                     Write(Url.Action("Drink", "CocktailSearch"));

#line default
#line hidden
            EndContext();
            BeginContext(18152, 117, true);
            WriteLiteral("/\" +  + \">\' + strDrink + \'</a>\').appendTo(\"#card-action\" + imagenActual);\r\n                            //$(\'<a href=\"");
            EndContext();
            BeginContext(18270, 37, false);
#line 378 "C:\Users\casti\source\repos\MVCCocktailSearchMaterializeCSSNetCore\MVCCocktailSearchMaterializeCSSNetCore\Views\CocktailSearch\Index.cshtml"
                                     Write(Url.Action("Drink", "CocktailSearch"));

#line default
#line hidden
            EndContext();
            BeginContext(18307, 6452, true);
            WriteLiteral(@"/"" + idDrink + "">' + strDrink + '</a>').appendTo(""#card-action"" + imagenActual);
        }
        }



                    if (residuo > 0) {

                        var ultimaFila = filas + 1;

                        jQuery('<div>', {
                            id: 'row' + ultimaFila,
                            class: 'row',
                            //title: 'now this div has a title!'
                        //}).appendTo('#containerBodyFromLayout');
                        }).insertBefore('#footer');


                        for (imagen = 1; imagen <= residuo; imagen++) {

                            var imagenActual = (ultimaFila - 1) * 4 + imagen;

                            jQuery('<div>', {
                                id: 'cocktail' + imagenActual,
                                class: 'col s12 m3'
                            }).appendTo('#row' + fila);

                            jQuery('<div>', {
                                id: 'card' + imagenActual,
 ");
            WriteLiteral(@"                               class: 'card small'
                            }).appendTo('#cocktail' + imagenActual);

                            //var div = $(""#card"" + imagenActual);

                            //div.attr(""style"", ""height:200px;"");

                            jQuery('<div>', {
                                id: 'card-image' + imagenActual,
                                class: 'card-image'
                            }).appendTo('#card' + imagenActual);

                            var idDrink = result.data[imagenActual - 1].idDrink;
                            var strDrink = result.data[imagenActual - 1].strDrink
                            var strDrinkThumb = result.data[imagenActual - 1].strDrinkThumb;


                            var parametrosParaAgregarAFavoritos = ""'"" + imagenActual + "","" + idDrink + "","" + strDrink.replace(""'"", """") + "","" + strDrinkThumb + ""'"";
                            var parametrosParaEliminarDeFavoritos = ""'"" + imagenActual + "","" + idDr");
            WriteLiteral(@"ink + "","" + strDrink.replace(""'"", """") + "","" + strDrinkThumb + ""'"";
                            console.log(parametrosParaAgregarAFavoritos);

                            if (Favoritos.length > 0) {
                                if (Favoritos.some(e => e.idDrink == idDrink)) {
                                    /* Favoritos contiene el elemento buscado */

                                    jQuery('<button>', {
                                        id: 'EliminarDeFavoritos' + imagenActual,
                                        class: 'waves-effect waves-light btn tooltipped',
                                        style: 'margin-top: 10%; margin-left: 5%',
                                        text: 'Eliminar De Favoritos',
                                        onclick: 'EliminarDeFavoritos(' + parametrosParaEliminarDeFavoritos + ')'
                                    }).appendTo('#card' + imagenActual);

                                }
                                else {

");
            WriteLiteral(@"                                    jQuery('<button>', {
                                        id: 'AgregarAFavoritos' + imagenActual,
                                        class: 'waves-effect waves-light btn tooltipped',
                                        style: 'margin-top: 10%; margin-left: 5%',
                                        text: 'Agregar A Favoritos',
                                        onclick: ""AgregarAFavoritos("" + parametrosParaAgregarAFavoritos + "")""
                                    }).appendTo('#card' + imagenActual);
                                }
                            }
                            else {
                                jQuery('<button>', {
                                    id: 'AgregarAFavoritos' + imagenActual,
                                    class: 'waves-effect waves-light btn tooltipped',
                                    style: 'margin-top: 10%; margin-left: 5%',
                                    text: 'Agregar A Fa");
            WriteLiteral(@"voritos',
                                    onclick: ""AgregarAFavoritos("" + parametrosParaAgregarAFavoritos + "")""
                                }).appendTo('#card' + imagenActual);
                            }

                            //$('<a class=""waves-effect waves-light btn>Agrega a favoritos</a>').appendTo(""#card"" + imagenActual);

                            //<button class=""btn waves-effect waves-light"" type=""submit"" name=""action"">Submit

                            //$(""#center"").append(txt1, txt2, txt3);

                            //jQuery('<image>', {
                            //    id: 'image' + i,
                            //    src: 'https://static.pexels.com/photos/5741/nature-sunset-clouds-lake-large.jpg'
                            //}).appendTo('#card-image1');

                            var imagenActual = (ultimaFila - 1) * 4 + imagen;


                            //var strImagenThumb = result.data[imagenActual - 1].strDrinkThumb;
                       ");
            WriteLiteral(@"     //var img = $('<img id=""image"" + imagen>'); //Equivalent: $(document.createElement('img'))
                            var img = $('<img>'); //Equivalent: $(document.createElement('img'))
                            img.attr('src', strDrinkThumb);
                            img.appendTo('#card-image' + imagenActual);


                            //jQuery('<div>', {
                            //    id: 'card-content' + imagenActual,
                            //    class: 'card-content'
                            //}).appendTo('#card' + imagenActual);

                            //var parrafoStrDrink = $(""<p></p>"").text(strDrink);

                            //se puede hacer de cualquier forma
                            //$(""#card-content"" + imagenActual).append(parrafoStrDrink);
                            //$('<p>' + strDrink + '</p>').appendTo(""#card-content"" + imagenActual);


                            jQuery('<div>', {
                                id: 'card-action' + i");
            WriteLiteral(@"magenActual,
                                class: 'card-action'
                            }).appendTo('#card' + imagenActual);


                            //$('<a href=""https://www.yahoo.com"">This is a link</a>').appendTo(""#card-action"" + imagenActual);
                            //$('<a href=""");
            EndContext();
            BeginContext(24760, 37, false);
#line 502 "C:\Users\casti\source\repos\MVCCocktailSearchMaterializeCSSNetCore\MVCCocktailSearchMaterializeCSSNetCore\Views\CocktailSearch\Index.cshtml"
                                     Write(Url.Action("Drink", "CocktailSearch"));

#line default
#line hidden
            EndContext();
            BeginContext(24797, 109, true);
            WriteLiteral("\">\' + strDrink + \'</a>\').appendTo(\"#card-action\" + imagenActual);\r\n\r\n                             var url = \"");
            EndContext();
            BeginContext(24907, 37, false);
#line 504 "C:\Users\casti\source\repos\MVCCocktailSearchMaterializeCSSNetCore\MVCCocktailSearchMaterializeCSSNetCore\Views\CocktailSearch\Index.cshtml"
                                   Write(Url.Action("Drink", "CocktailSearch"));

#line default
#line hidden
            EndContext();
            BeginContext(24944, 3958, true);
            WriteLiteral(@"/?IdDrink="" + idDrink;

                            $('<a href=' + url + '>' + strDrink + '</a>').appendTo(""#card-action"" + imagenActual);

                        }

                    }

                }
            });
        }
    }

    function AgregarAFavoritos(parametrosParaAgregarAFavoritos) {
        console.log(parametrosParaAgregarAFavoritos);
        var parametrosArray = parametrosParaAgregarAFavoritos.split("","");
        console.log(parametrosArray);

        var Drink = new Object();

        var imagenActual = parametrosArray[0];

        Drink.idDrink = parametrosArray[1];
        Drink.strDrink = parametrosArray[2];
        Drink.strDrinkThumb = parametrosArray[3];

        if (localStorage.Favoritos) {
            //Si existe en el storage
            //convert json string to javascript object
            Favoritos = JSON.parse(localStorage.getItem(""Favoritos""))

        } else {
            var Favoritos = [];
        }

        Favoritos.push(Drink);");
            WriteLiteral(@"

        //converts javascript value to a JSON String
        localStorage.setItem('Favoritos', JSON.stringify(Favoritos));


        $(""#AgregarAFavoritos"" + imagenActual).text(""Eliminar De Favoritos"");
        //$(""#AgregarAFavoritos"" + imagenActual).html('Eliminar De Favoritos');

        $(""#AgregarAFavoritos"" + imagenActual).attr(""id"", ""EliminarDeFavoritos"" + imagenActual);
        var parametrosParaEliminarDeFavoritos = ""'"" + imagenActual + "","" + Drink.idDrink + "","" + Drink.strDrink.replace(""'"", """") + "","" + Drink.strDrinkThumb + ""'"";

        $(""#EliminarDeFavoritos"" + imagenActual).attr(""onclick"", ""EliminarDeFavoritos("" + parametrosParaEliminarDeFavoritos + "")"");
       


        //$.ajax({
        //    type: 'GET',
        //    url: '/CocktailSearch/ObtenerDetallesCocktailById',
        //    data: { IdDrink: idDrink },
        //    success: function (result) {
        //        console.log(result.data);
        //    }
        //});

    }

    function EliminarDeFavor");
            WriteLiteral(@"itos(parametrosParaEliminarDeFavoritos) {

        var parametrosArray = parametrosParaEliminarDeFavoritos.split("","");
        console.log(parametrosArray);

        var imagenActual = parametrosArray[0];

        var idDrink = parametrosArray[1];
        var strDrink = parametrosArray[2];
        var strDrinkThumb = parametrosArray[3];

        //convert json string to javascript object
        var Favoritos = JSON.parse(localStorage.getItem(""Favoritos""))

        Favoritos = Favoritos.filter(function (obj) {
            return obj.idDrink != idDrink;
        });

        //converts javascript value to a JSON String
        localStorage.setItem('Favoritos', JSON.stringify(Favoritos));

        var nuevosFavoritos = JSON.parse(localStorage.getItem(""Favoritos""))
        //console.log('Nuevos Favoritos');
        //console.log(nuevosFavoritos);

        //Pendiente esta instrucci??n:
        $(""#EliminarDeFavoritos"" + imagenActual).text(""Agregar A Favoritos"");

        $(""#EliminarDeF");
            WriteLiteral(@"avoritos"" + imagenActual).attr(""id"", ""AgregarAFavoritos"" + imagenActual);

        var parametrosParaAgregarAFavoritos = ""'"" + imagenActual + "","" + idDrink + "","" + strDrink.replace(""'"", """") + "","" + strDrinkThumb + ""'"";
        $(""#AgregarAFavoritos"" + imagenActual).attr(""onclick"", ""AgregarAFavoritos("" + parametrosParaAgregarAFavoritos + "")"");

        //$(""#AgregarAFavoritos"" + imagenActual).html('Eliminar De Favoritos');


        //$.ajax({
        //    type: 'GET',
        //    url: '/CocktailSearch/ObtenerDetallesCocktailById',
        //    data: { IdDrink: idDrink },
        //    success: function (result) {
        //        console.log(result.data);
        //    }
        //});

    }

    $('.tooltipped-click').click(function () {
        alert('hola');
       // $(this).tooltip();
        //$(this).tooltip('open');
    });

</script>
");
            EndContext();
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
