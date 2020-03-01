using System;
using System.Linq;
using System.Collections.Generic;

namespace _4_JoinMethodSyntaxMultiKey{
	public class _4_JoinMethodSyntaxMultiKey{
		public static void Main(string [] args){
			Customer[] customer = new Customer[] {
				new Customer{ID1 = 1, ID2 = 1,Name = "Sam"},
				new Customer{ID1 = 2, ID2 = 2,Name = "Dave"},
				new Customer{ID1 = 3, ID2 = 3,Name = "Julia"},
				new Customer{ID1 = 4, ID2 = 4,Name = "Sue"}
			};
			
			Order [] order = new Order[]{
				new Order{ID1 = 1, ID2 = 1,Product = "Book"},
				new Order{ID1 = 2, ID2 = 2,Product = "Game"},
				new Order{ID1 = 3, ID2 = 3,Product = "Computer"},
				new Order{ID1 = 8, ID2 = 8,Product = "Shirt"}
			};
			
			// Join on the ID1, ID2 properties.
			var query = customer.Join(
									order,
									c => new {ID1 = c.ID1 * 2, ID2 = c.ID2 * 2},
									o => new {ID1 = o.ID1, ID2 = o.ID2},
									(c, o) => new {c_ID1 = c.ID1, o_ID1 = o.ID1}
								);
			
			foreach(var item in query){
				Console.WriteLine("C.ID1: {0} ---- o.ID1: {1}", item.c_ID1, item.o_ID1);
			}
		}
	}
}