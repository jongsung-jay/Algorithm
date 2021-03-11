using System;
using System.Collections.Generic;
using System.Text;

namespace Test1
{
    class Prescription
    {
        //Field
        private static int CURRENT_NUMBER = 100;
        public string ID { get; private set; }

        // properties
        public bool ForRepeat { get; private set; }
        public string Doctor { get; private set; }
        public string Name { get; private set; }
        public int Length { get; private set; }

        // constructor
        public Prescription(string doctor, string name, int length, bool forRepeat = false) {
            Doctor = doctor;
            Name = name;
            Length = length;
            ForRepeat = forRepeat;
            ID = CURRENT_NUMBER.ToString();
            CURRENT_NUMBER++;
        }

        // Methods
        public override string ToString() {
            string result = $"#{ID} {Name} prescribed by {Doctor} for {Length} days \n";
            if (ForRepeat)
            {
                result += "{Repeat}";
            }
            else {
                result += "(No repeat)";
            }
            return result;
        }
    }
}
