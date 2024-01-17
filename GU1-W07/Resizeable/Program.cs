using System;
using System.Collections.Generic;

namespace Shape
{
  class Program
  {
    static void Main(string[] args)
    {
      Irezisesable MyCicle = new Circle();
      Irezisesable MyRectangle = new Rectangle();
      MyCicle.Resize();
      MyRectangle.Resize();
    }
  }
}
