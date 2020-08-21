using System;
namespace ChristmasWithTypes
{
    public class Christmas
    {
        public string[] Presents;
        public string Santa { get; set; }
        public int? TreeHeight { get; set; } //DONE Make the Height proper nullable
        //DONE Make the property, "Day", type enum
        public enum Day { Sunday, Monday, Tuesday, Wednday, Thursday, Friday, Saturday };

    }
}
