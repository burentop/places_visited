using Nancy;
using PlacesVisited.Objects;
using System.Collections.Generic;

namespace PlacesVisited
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Get["/places/new"] = _ => {
        return View["place_form.cshtml"];
      };
      Get["/places"] = _ => {
        List<Place> allPlaces = Place.GetAll();
        return View["places.cshtml", allPlaces];
      };

      Post["/places"] = _ => {
        Place newPlace = new Place(Request.Form["place-name"], Request.Form["new-place"], int.Parse(Request.Form["duration"]));
        List<Place> allPlaces = Place.GetAll();
        return View["places.cshtml", allPlaces];
      };

      Get["/places/{id}"] = parameters => {
        Place place = Place.Find(parameters.id);
        return View["place.cshtml", place];
      };
    }
  }
}
