using System;
using System.Linq;
using System.Collections.Generic;

namespace _4_PerformingOperationsOnSourceElements{
	public class FormatQuery{
		public static void Main(string [] args){
			// Data source
			double[] radii = {1, 2, 3};
			
			// Query
			IEnumerable<string> query = from r in radii
										select String.Format("Area = {0}", r * r * 3.14);
										
			// Query execution.
			foreach(string item in query){
				Console.WriteLine(item);	
			}
		}
	}
}

/***************** OUTPUT **********************
Area = 3.14
Area = 12.56
Area = 28.26
***********************************************/