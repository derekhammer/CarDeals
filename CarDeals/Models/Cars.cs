using System.Collections.Generic;


namespace CarDeals.Models
  {
    public class Car
    {
    private string _makeModel;
    private string _color;
    private string _year;
    private string _price;
    private static List<Car> _instances = new List<Car> {};

    public Car (string MakeModel, string Color, string Year, string Price)
    {
      _makeModel = MakeModel;
      _color = Color;
      _year = Year;
      _price = Price;
    }

    public string GetMakeModel()
    {
      return _makeModel;
    }

    public string GetColor()
    {
      return _color;
    }

    public string GetYear()
    {
      return _year;
    }
    public string GetPrice()
    {
      return _price;
    }
    public static List<Car> GetAll()
    {
      return _instances;
    }
    public void Save()
    {
      _instances.Add(this);
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}
