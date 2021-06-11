using System;

namespace GroceryList
{
    class Program
    {
        static void Main(string[] args)
        {

            GroceryList groceryList = new GroceryList(); // "creates" our grocery list object
            bool isrunning = true;
            while (isrunning)
            {
                Console.WriteLine("Welcome To The Grocery Store!\n");

                Console.WriteLine("1. Enter a Grocery Shopping Budget"); // add a monthly budget amount

                Console.WriteLine("2. Enter a Store Name"); //add a grocery store
                Console.WriteLine("3. Enter Spending Amount"); // current cash on hand
                Console.WriteLine("4. Print Grocery Shopping List");// print shopping list
                Console.WriteLine("5. Enter grocery item");
                Console.WriteLine("6. Exit");

                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Enter a Shopping Budget");

                        string shoppingBudget = Console.ReadLine(); // this is the number we want to set our budget to
                        int budget = Int32.Parse(shoppingBudget);
                        groceryList.SetBudget(budget);
                        Console.WriteLine(budget);
                        break;

                    case "2":
                        Console.WriteLine("Enter a Store Name");
                        string storename = Console.ReadLine();
                        groceryList.StoreName = storename;
                        break;

                    case "3":
                        Console.WriteLine("Enter a Spending Amount");

                        string cash = Console.ReadLine();
                        int spending = Int32.Parse(cash);
                        groceryList.SetBudget(spending);
                        Console.WriteLine(spending);
                        break;

                    case "4":
                        Console.WriteLine("Print Grocery Shopping List");
                        groceryList.displayList();                                                
                        break;

                    case "5":
                        Console.WriteLine("Enter a product name");
                        string item = Console.ReadLine();
                        Console.WriteLine("Enter a cost");
                        double cost = Convert.ToDouble(Console.ReadLine());
                        groceryList.ListOfItems.Add(new Grocery_List.Item(item,cost));
                        break;

                    case "6":
                        isrunning = false;
                        break;

                }
            }



        }




    }
}

