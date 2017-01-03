using System.Collections.Generic;

namespace PlacesVisited.Objects
{
  public class Place
  {
    private string _description;
    private string _city;
    private int _duration;
    private static List<Place> _places = new List<Place>{};
    private int _id;

    public Place(string description, string city, int duration)
    {
      _description = description;
      _city = city;
      _duration = duration;
      _places.Add(this);
      _id = _places.Count;
    }

    public string GetDescription()
    {
      return _description;
    }

    public void SetDescription(string newDescription)
    {
      _description = newDescription;
    }

    public string GetCity()
    {
      return _city;
    }

    public void SetCity(string newCity)
    {
      _city = newCity;
    }

    public int GetDuration()
    {
      return _duration;
    }

    public void SetDuration(int newDuration)
    {
      _duration = newDuration;
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
