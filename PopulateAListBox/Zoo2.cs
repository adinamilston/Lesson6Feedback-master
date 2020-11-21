using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopulateAListBox
{
    public enum ZType { caged, safari, petting };
    public class AZoo
    {
        //name of the zoo
        public string ZooName { get; set; }
        //type of zoo: caged, safari, petting, etc
        public ZType ZooType { get; set; }
        public List<Animal> AnimalList { get; set; }// = new List<Animal>();

        public override string ToString()
        {
            string str = "";
            foreach (var animal in AnimalList)
            {
                str += animal.Name + " " + animal.Species;
            }
            return str;
        }//end tostring

    }//end class
}//end namespace
