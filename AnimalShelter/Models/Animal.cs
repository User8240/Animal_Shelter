using System;
using System.Collections.Generic;


namespace AnimalShelter.Models
{
  public class Animal
  {
    public int AnimalId { get; set; }
    public string Name { get; set; }  
    public string Gender { get; set; }
    public string Type { get; set; }
    public DateTime Date { get; set; }
  }
}
