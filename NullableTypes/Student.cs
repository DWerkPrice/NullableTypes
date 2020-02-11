using System;
using System.Collections.Generic;
using System.Text;

namespace NullableTypes
{
    public class Student {
        public int Id { get; set; }
        public string Name { get; set; }
        public double GPA { get; set; }
        public int? SAT { get; set; }

      puclic int? MajorId { get; set; }
      public Major major { get; set; }  
    }
}
