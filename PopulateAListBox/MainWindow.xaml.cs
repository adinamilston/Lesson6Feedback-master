using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PopulateAListBox
{
   /// <summary>
   /// Interaction logic for MainWindow.xaml
   /// </summary>
   public partial class MainWindow : Window
   {
      //create a collection of zoos
      private List<AZoo> zooList;
      //save the current selected zoo
      private AZoo currentZoo; 
      public MainWindow()
      {
         FillZooList();
         InitializeComponent();

         //link the collection to the combo box
         CBzooName.ItemsSource = zooList;
         CBzooName.DisplayMemberPath = "ZooName";
         CBzooName.SelectedIndex = 0;
       // ShowZoo();


      }

      //method used to fill the list of zoos
      private void FillZooList()
      {
            zooList = new List<AZoo>
         {
             new AZoo
             {ZooName = "ramat gan", ZooType= ZType.safari,
                 AnimalList = new List<Animal>
                 {new Animal{Name = "simba",Age =  10,Species =  "lion" },
                  new Animal {Name ="dumbo",Age =2,Species = "elephant" },
                  new Animal {Name ="goldi",Age = 5,Species = "giraffe" } } },

            new AZoo
            {ZooName = "Tanachi", ZooType =ZType.caged,
                AnimalList = new List<Animal>
                { new Animal{Name ="yogi",Age = 10, Species ="bear" },
                              new Animal {Name ="george",Age = 2,Species = "monkey" },
                              new Animal {Name ="otto",Age = 5,Species = "ostrich" } } },
            new AZoo
            {ZooName = "Chavayot", ZooType =ZType.petting,
                AnimalList = new List<Animal>
                { new Animal{Name ="elsa",Age = 10, Species ="calf" },
                              new Animal {Name ="baba",Age = 2,Species = "sheep" },
                              new Animal {Name ="gadya",Age = 5,Species = "goat" } } }
        };

         //have an animal array that will used for the zoos

    
      }//end of FillZooList

      private void CBzooName_SelectionChanged(object sender, SelectionChangedEventArgs e)
      {
         ShowZoo((CBzooName.SelectedValue as AZoo).ZooName); //get the selected zoo, and call method to display it
      }

      //method to display the animals in the selected zoo
      //parameter is the name of the zoo you want to display
      private void ShowZoo (string zooName)
      {
          currentZoo =  zooList.Find(z => z.ZooName == zooName);
        
         if (currentZoo != null)
         {
            UpGrid.DataContext = currentZoo; // have the data for upper grid come from selected zoo
            LBAnimalList.DataContext = currentZoo.AnimalList;  //have the listbox display the animals in the zoo
         }
         else
            throw new KeyNotFoundException();

      }


   }//end of class
}
