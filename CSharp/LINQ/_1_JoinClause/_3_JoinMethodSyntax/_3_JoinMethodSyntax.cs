using System;
using System.Linq;
using System.Collections.Generic;

namespace _3_JoinMethodSyntax{
	public class _3_JoinMethodSyntax{
		public static void Main(string [] args){
			 // Example animals in veterinarian office.
			Animal[] animals = new Animal[]{
				new Animal{ID = 1, Breed = "cat"},
				new Animal{ID = 2, Breed = "dog"}
			};

			// Example medications (prescriptions).
			var medications = new Medication[]{
				new Medication{ID = 1, Type = "antibiotic"},
				new Medication{ID = 2, Type = "sedative"},
				new Medication{ID = 2, Type = "antihistimine"}
			};
			
			// Use fluent join syntax on ID.
			var query = animals.Join(
									medications, 
									a => a.ID, 
									m => m.ID, 
									(a, m) => new { a.Breed, m.Type });
			foreach(var item in query){
				Console.WriteLine("Breed: {0} ---- Type: {1}", item.Breed, item.Type);
			}
		}
	}
}