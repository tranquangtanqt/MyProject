using System;
using System.Linq;
using System.Collections.Generic;
using System.Xml.Linq;

namespace _3_TransformingInMemoryObjectsIntoXML{
	public class XMLTransform{
		public static void Main(string [] args){
			// Create the data source by using a collection initializer.
			// The Student class was defined previously in this topic.
			List<Student> students = new List<Student>() {
				new Student {First="Svetlana", Last="Omelchenko", ID=111, Scores = new List<int>{97, 92, 81, 60}},
				new Student {First="Claire", Last="O’Donnell", ID=112, Scores = new List<int>{75, 84, 91, 39}},
				new Student {First="Sven", Last="Mortensen", ID=113, Scores = new List<int>{88, 94, 65, 91}},
			};

			// Create the query.
			var studentsToXML = new XElement(
								"Root",
								from st in students
								let x = String.Format("{0}, {1}, {2}, {3}", st.Scores[0], st.Scores[1], st.Scores[2], st.Scores[3])
								select new XElement(
											"student",
											new XElement("First", st.First),
											new XElement("Last", st.Last),
											new XElement("Scores", x)
										) //End "Root"
			);
			
			// Execute the query.
			Console.WriteLine(studentsToXML);		
		}
	}
}

/***************** OUTPUT **********************
<Root>
  <student>
    <First>Svetlana</First>
    <Last>Omelchenko</Last>
    <Scores>97, 92, 81, 60</Scores>
  </student>
  <student>
    <First>Claire</First>
    <Last>O'Donnell</Last>
    <Scores>75, 84, 91, 39</Scores>
  </student>
  <student>
    <First>Sven</First>
    <Last>Mortensen</Last>
    <Scores>88, 94, 65, 91</Scores>
  </student>
</Root>
***********************************************/