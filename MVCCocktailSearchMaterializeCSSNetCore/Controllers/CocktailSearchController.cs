using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using System.Net.Http;

using MVCCocktailSearchMaterializeCSSNetCore.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Dynamic;
using System.Reflection;

namespace MVCCocktailSearchMaterializeCSSNetCore.Controllers
{
    //[Route("CocktailSearch")]
    public class CocktailSearchController : Controller
    {
        //[Route("")]
        //[Route("Index")]
        ////[Route("Cotizaciones")]
        //[Route("~/")]
        public IActionResult Index()
        {
            return View();
        }

        //No se puede usar,hay que pagar, hubiera diso bueno, que se cargaran al principio
        //[Route("ObtenerCocktelesPopulares")]
        public async Task<IActionResult> ObtenerCocktelesPopulares()
        {
            string apiResponse = string.Empty;
            List<Drink> listDrinks = new List<Drink>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https//:www.thecocktaildb.com/api/json/v1/1/popular.php"))
                {
                    apiResponse = await response.Content.ReadAsStringAsync();
                    //apiResponse = response.Result.Content.ToString();
                    listDrinks = JsonConvert.DeserializeObject<List<Drink>>(apiResponse);

                    //return Json(new { data = listaMarcas }, JsonRequestBehavior.AllowGet);
                    return Json(new { data = listDrinks });
                }
            }

        }

        //[Route("~/BuscarCocktelesPorTexto")]
        public async Task<IActionResult> BuscarCocktelesPorTexto(string texto)
        {
            string apiResponse = string.Empty;
            List<Drink> listDrinks = new List<Drink>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://www.thecocktaildb.com/api/json/v1/1/search.php?s=" + texto))
                {
                    apiResponse = await response.Content.ReadAsStringAsync();
                    //apiResponse = response.Result.Content.ToString();
                    //no fiuncionó este:
                    //listDrinks = JsonConvert.DeserializeObject<List<Drink>>(apiResponse);

                    dynamic stuff = JsonConvert.DeserializeObject(apiResponse);

                    //var drinks = stuff.Drinks;

                    //var drinks = ((Newtonsoft.Json.Linq.JProperty)(new System.Collections.Generic.ICollectionDebugView<Newtonsoft.Json.Linq.JToken>(((Newtonsoft.Json.Linq.JObject)stuff).ChildrenTokens).Items[0])).Value;

                     
                    foreach(dynamic drinksArray in stuff)
                    {
                        //var drinksInternal = ((Newtonsoft.Json.Linq.JProperty)drinks).Value;

                        foreach (dynamic drinks in drinksArray)
                        {
                            var drinksArraySerializado = JsonConvert.SerializeObject(drinks);

                            listDrinks = JsonConvert.DeserializeObject<List<Drink>>(drinksArraySerializado);

                            ////Ya no se requiere todo el codigo de abajo, para ir transversando bebida por bedida
                            ////y propiedad por propiedad
                            //List<Drink> listaDrinks = new List<Drink>();
                            ////var drinkInternal = ((Newtonsoft.Json.Linq.JProperty)drink).Value;
                            //foreach (dynamic drink in drinks)
                            //{
                            //    Drink objDrink = new Drink();
                            //    foreach (dynamic propertyDrink in drink)
                            //    {
                            //        //objDrink.IdDrink = propertyDrink.idDrink;

                            //        //aqui si tienen que coincidir mayusculas o con minusculas, o se hace un lower
                            //        PropertyInfo prop = typeof(Drink).GetProperty(propertyDrink.Name);

                            //        object value = prop.GetValue(objDrink);
                            //        //hay que determinar el tipo de valor, si es string, int, etc
                            //        string strValue = propertyDrink.Value;

                            //        int intValue = propertyDrink.Value;

                            //        prop.SetValue(objDrink, strValue);

                            //    }

                            //    listaDrinks.Add(objDrink);
                            //}

                            
                        }
                    }
                    //return Json(new { data = listaMarcas }, JsonRequestBehavior.AllowGet);
                    return Json(new { data = listDrinks });
                }
            }

        }

        public IActionResult Drink(string IdDrink)
        {
           ViewBag.IdDrink = IdDrink;
           return View();
        }

        //[Route("ObtenerCocktelesPopulares")]
        public async Task<IActionResult> ObtenerDetallesCocktailById(int IdDrink)
        {
            //no se requiere consumir este metodo, es el mismo retorno, de la busqueda, pero solo una benbida
            string apiResponse = string.Empty;
            List<Drink> listDrinks = new List<Drink>();
            Drink objDrink = new Drink();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://www.thecocktaildb.com/api/json/v1/1/lookup.php?i=" + IdDrink))
                {
                    apiResponse = await response.Content.ReadAsStringAsync();

                    dynamic stuff = JsonConvert.DeserializeObject(apiResponse);

                    //var drinks = stuff.Drinks;

                    //var drinks = ((Newtonsoft.Json.Linq.JProperty)(new System.Collections.Generic.ICollectionDebugView<Newtonsoft.Json.Linq.JToken>(((Newtonsoft.Json.Linq.JObject)stuff).ChildrenTokens).Items[0])).Value;


                    foreach (dynamic drinksArray in stuff)
                    {
                        //var drinksInternal = ((Newtonsoft.Json.Linq.JProperty)drinks).Value;

                        foreach (dynamic drinks in drinksArray)
                        {
                            var drinksArraySerializado = JsonConvert.SerializeObject(drinks);

                            listDrinks = JsonConvert.DeserializeObject<List<Drink>>(drinksArraySerializado);
                        }
                    }

                    if (listDrinks.Count > 0)
                    {
                        objDrink = listDrinks[0];
                    }

                    return Json(new { data = objDrink });
                }
            }

        }


        //[Route("")]
        //[Route("Index")]
        //[Route("Favoritos")]
        //[Route("~/")]
        public IActionResult Favoritos()
        {
            return View();
        }
    }
}