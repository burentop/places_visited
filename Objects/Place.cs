using System.Collections.Generic;

namespace PlacesVisited.Objects
{
  public class Place
  {
    private string _city;
    private static List<Place> _places = new List<Place>{};
    private int _id;

    public Place(string city)
    {
      _city = city;
      _places.Add(this);
      _id = _places.Count;
    }

    public string GetCity()
    {
      return _city;
    }

    public void SetCity(string newCity)
    {
      _city = newCity;
    }

    public static List<Place> GetAll()
    {
      return _places;
    }

    public void ClearAll()
    {
      _places.Clear();
    }

    public int GetId()
    {
      return _id;
    }

    public static Place Find(int searchId)
    {
      return _places[searchId - 1];
    }
  }
}
