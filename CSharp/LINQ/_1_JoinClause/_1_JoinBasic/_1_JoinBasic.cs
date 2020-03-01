using System;
using System.Linq;
using System.Collections.Generic;

namespace _1_JoinBasic{
	public class _1_JoinBasic{
		public static void Main(string [] args){
			// array1
			var array1 = new int [3] {4, 3, 0};
			var array2 = new int [3] {5, 4, 2};
			// Join with query expression
			var result1 = from x in array1
						join y in array2 on x + 1 equals y
						select y;
			foreach(int i in result1){
				Console.Write(i + " ");
			}
			Console.WriteLine();
			// Join with query method
			var result2 = array1.Join(array2, x=> x+1, y => y, (x, y) => x);
			foreach (int i in result2)
            {
                Console.Write(i + " ");
            }
		}
	}
}