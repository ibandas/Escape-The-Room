using System;
using System.IO;
using System.Collections.Generic;


namespace IntroCS
{
	/// A class that maintains a list of items. 
	public class Inventory
	{
		private List<Item> InventoryList;

		/// Create an empty list of room items. 
		public Inventory()
		{
			InventoryList = new List<Item>();
		}

		// Add item to the list.
		// The regular assignment version always returns true. 
		public bool Additem(Item item)
		{   // code
			InventoryList.Add (item);
			return true; 
		}
		//PrintList chunk
		/// List the full descriptions of each item,
		/// with each item separated by a blank line. 

		public bool CheckInventory(string title){
			foreach (Item i in InventoryList) {
				if (i.GetTitle () == title) {
					return true;
				}
			}
			return false;
		}

		public void PrintInventory() // 
		{  
			InventoryList.ForEach(Console.WriteLine);
		}

		public void ExamineItem(string title){
			foreach (Item i in InventoryList) {
				if (i.GetTitle () == title) {
					Console.WriteLine (i.GetDescription ());
				}
			}
		}

		public void AddMagic(string title){
			for (int j = 0; j < InventoryList.Count; j++) {
				if (InventoryList [j].GetTitle () == title) {
					InventoryList.RemoveAt (j);
					break;
				}
			}
		}
	}
}
