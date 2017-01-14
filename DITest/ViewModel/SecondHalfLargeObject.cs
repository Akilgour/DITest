using System;
using System.Collections.Generic;

namespace DITest.ViewModel
{
    public class SecondHalfLargeObject
    {
        public int LargeObjectId { get; set; }

        public string PropertySix { get; set; }
        public string PropertySeven { get; set; }
        public int PropertyEight { get; set; }
        public bool PropertyNine { get; set; }
        public Guid PropertyTen { get; set; }

        public List<String> TheList
        {
            get
            {
                var list = new List<string>();
                list.Add("foo");
                list.Add("bar");
                list.Add("foo bar");

                return list;
            }

        }
    }
}