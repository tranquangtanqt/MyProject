using System;
using System.Linq;
using System.Collections.Generic;

namespace _2_JoinQuerySyntax{
	public class _2_JoinQuerySyntax{
		public static void Main(string [] args){
			Customer[] customer = new Customer[] {
				new Customer{ID = 1, Name = "Sam"},
				new Customer{ID = 2, Name = "Dave"},
				new Customer{ID = 3, Name = "Julia"},
				new Customer{ID = 4, Name = "Sue"}
			};
			
			Order [] order = new Order[]{
				new Order{ID = 1, Product = "Book"},
				new Order{ID = 2, Product = "Game"},
				new Order{ID = 3, Product = "Computer"},
				new Order{ID = 8, Product = "Shirt"}
			};
			
			// Join on the ID properties.
			var query = from c in customer
						join o in order on c.ID equals o.ID
						select new {c.Name, o.Product};
			
			foreach(var item in query){
				Console.WriteLine("Name: {0} ---- Product: {1}", item.Name, item.Product);
			}
		}
	}
}