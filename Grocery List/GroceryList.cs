using Grocery_List;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryList
{
    class GroceryList

    {
        public string StoreName { get; set; }
        public string CatagoryOfItems { get; set; }
        public int GroceryStoreBudget { get; set; }
        public List<Item> ListOfItems{ get; set; } // this is the list of items 
        public GroceryList()
        {
            ListOfItems = new List<Item>();

        }



        public void addItemToList(Item itemToAdd) // adds a string to our grocery list
        {
            ListOfItems.Add(itemToAdd);
        }

        public void displayList() // prints out our grocery list
        {
            double sum = 0;
            foreach (Item item in ListOfItems)
            {
                Console.WriteLine(item.Name);
                sum += item.Cost;
            }
            Console.WriteLine("your total is " + sum);
        }

        public void SetBudget(int budget) // this sets the budget of the grocery list (SetBudget(30) would mean our grocery list has a budget of $30)
        {
            GroceryStoreBudget = budget;
            {

            }
        }




    }
}
