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

namespace MVCCocktailSearchMaterializeCSSNetCore.Controllers
{
    [Route("CocktailSearch")]
    public class CatalogosController : Controller
    {
        [Route("Catalogos")]
        public IActionResult Index()
        {
            return View();
        }

        //No se puede usar,hay que pagar, hubiera diso bueno, que se cargaran al principio
        [Route("Catalogos/ObtenerCoctelesPopulares")]
        public async Task<IActionResult> ObtenerCoctelesPopulares()
        {
            string apiResponse = string.Empty;
            List<Drink> listDrinks = new List<Drink>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https//:www.thecocktaildb.com/api/json/v1/1/popular.php"))
                {
                    apiResponse = await response.Content.ReadAsStringAsync();
                    //apiResponse = response.Result.Content.ToString();

                    //listDrinks = JsonConvert.DeserializeObject<List<Drink>>(apiResponse);

                    dynamic stuff = JsonConvert.DeserializeObject(apiResponse);

                    //return Json(new { data = listaMarcas }, JsonRequestBehavior.AllowGet);
                    return Json(new { data = listDrinks });
                }
            }
            
        }

        [Route("Catalogos/BuscarCocktelesPorTexto")]
        public async Task<IActionResult> BuscarCocktelesPorTexto(string texto)
        {
            string apiResponse = string.Empty;
            List<Drink> listDrinks = new List<Drink>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("www.thecocktaildb.com/api/json/v1/1/search.php?s=" + texto ))
                {
                    apiResponse = await response.Content.ReadAsStringAsync();

                    listDrinks = JsonConvert.DeserializeObject<List<Drink>>(apiResponse);

                    //return Json(new { data = listaMarcas }, JsonRequestBehavior.AllowGet);
                    return Json(new { data = listDrinks });
                }
            }

        }
    }
}