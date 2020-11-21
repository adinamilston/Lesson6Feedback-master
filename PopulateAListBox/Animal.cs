﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopulateAListBox
{
   public class Animal
   {
      #region properties
      public string Name { get; set; }
      public int Age { get; set; }
      public string Species { get; set; }
      #endregion

      //public Animal(string name, int age, string species)
      //{
      //   Name = name;
      //   Age = age;
      //   Species = species;
      //}

      public override string ToString()
      {
            return this.ToStringProperty<Animal>();
      }//end tostring
   }//end class
}
