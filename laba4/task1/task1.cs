using System;

public class task1 {
  public class Car {
    public string Model;
    public int YearOfProduction;
  }
  
  static void Main(string[] args) {
    int total = 3;
    Car[] car = new Car[total];
  
    for (int i = 0; i < total; i++) {
      car[i] = new Car()
      {
        Model = Convert.ToString(Console.ReadLine()),
        YearOfProduction = int.Parse(Console.ReadLine()),
      };
    }

    for (int i = 0; i < total - 1; i++) {
      for (int j = i+1; j < total; j++) {
        car temp = car[i];
        car[i] = car[j];
        car[j] = temp;
      }
    }

    for (int i = 0; i < total; i++) {
      Console.WriteLine("Model: {0}, YearOfProduction: {1}", car[i].Model, car[i].YearOfProduction);
    }
  }
}
