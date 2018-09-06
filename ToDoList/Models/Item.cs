using System;
using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Item
  {
    private string _description;
    private static List<Item> _instances = new List<Item> {};

    public Item (string description)
    {
      _description = description;
    }
    public string GetDescription()
    {
      return _description;
    }
    public void SetDescription(string newDescription)
    {
      _description = newDescription;
    }
    public static List<Item> GetAll()
    {
      return _instances;
    }
    public void Save()
    {
      _instances.Add(this);
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }

  class Program
  {
    static void Main()
    {
      Console.WriteLine("Welcome to the To-Do List program.");
      Flow();
    }

    public static void Flow()
    {
      Console.WriteLine("Would you like to add an item or view your list? (Add/View/Quit)");
      string input = Console.ReadLine();
      if (input == "Add" || input == "add")
      {
        Console.WriteLine("Please enter a description for your item.");
        string description = Console.ReadLine();
        Item newItem = new Item(description);
        newItem.Save();
        Console.WriteLine(newItem.GetDescription() + " has been added to your list.");
        Flow();
      }
      else if (input == "View" || input == "view")
      {
        List<Item> viewList = Item.GetAll();
        int number = 1;
        foreach (Item todo in viewList)
        {
          Console.WriteLine(number + ". " + todo.GetDescription());
          number++;
        }
        Flow();
      }
      else if (input == "Quit" || input == "quit")
      {
        Console.WriteLine("Goodbye.");
      }
      else
      {
        Console.WriteLine("Please enter a valid option.");
        Flow();
      }
    }
  }
}