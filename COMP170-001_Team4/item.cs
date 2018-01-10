using System;
using System.IO;
using System.Collections.Generic;



namespace IntroCS
{

	/// A class that maintains information on an item 
	public class Item
	{
		private String title;
		private String description;


		public Item(String title, String description)
		{ //code
			this.title = title;
			this.description = description;

		}

		/// Return the title of an item.
		public String GetTitle()
		{  

			return title; //just so skeleton compiles
		}

		/// Return the description.
		public String GetDescription()
		{  
			return description;
		}
			
		/// Return a multi-line String labeling all Item information.
		public override string ToString()
		{  
			return string.Format ("Title: {0}\nDescription: {1}", title, description);
		}
	}
}
