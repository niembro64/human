using System;
using System.Collections.Generic;

namespace human
{
  class Human
  {
    // Fields for Human
    public string Name;
    public int Strength;
    public int Intelligence;
    public int Dexterity;
    private int health;
    // add a public "getter" property to access health
    public int Health { get { return this.health; } }


    // Add a constructor that takes a value to set Name, and set the remaining fields to default values
    public Human(string n)
    {
      Name = n;
      Strength = 3;
      Intelligence = 3;
      Dexterity = 3;
      health = 100;
    }
    // Add a constructor to assign custom values to all fields
    public Human(string n, int s, int i, int d, int h)
    {
      Name = n;
      Strength = s;
      Intelligence = i;
      Dexterity = d;
      health = h;
    }

    // Build Attack method
    public int Attack(Human target)
    {
      int damage = this.Strength * 5;
      target.health -= damage;
      if (target.health < 0)
      {
        target.health = 0;
        damage = 0;
      }
      return damage;
    }
  }
}
