using System;
using System.Collections.Generic;

namespace human
{
  class Program
  {
    static void Main(string[] args)
    {


      Human jack = new Human("Jack");
      Human jill = new Human("Jill");

      h.p($"Name: {jack.Name} Health: {jack.Health} | Name: {jill.Name} Health: {jill.Health} \n");

      jack.Attack(jill);

      h.p($"Name: {jack.Name} Health: {jack.Health} | Name: {jill.Name} Health: {jill.Health} \n");




    }
  }
}
