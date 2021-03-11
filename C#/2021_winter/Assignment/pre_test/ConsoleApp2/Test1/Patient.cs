using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Test1
{
    class Patient
    {
        // Field
        private List<Prescription> prescriptions = new List<Prescription>();

        // Properties
        public string Name { get; private set; }
        public int Yob { get; private set; }

        // Constructor
        public Patient(string name, int yob) {
            Name = name;
            Yob = yob;
        }

        // Methods
        public void AddPrescription(Prescription prescription) {
            prescriptions.Add(prescription);
        }

        public void RemovePrescription(string id) {
            bool found = false;
            try {
                for (int index = 0; index < prescriptions.Count; index++)
                {
                    if (prescriptions[index].ID.ToString() == id)
                    {
                        found = true;
                        prescriptions.RemoveAt(index);
                    }
                }
            }
            catch(Exception e) {
                if (!found)
                {
                    Console.WriteLine($"Exception:" + e.Message);
                }
            }  
        }

        private string GetPrescriptions() {
            string result = "";
            for (int index = 0; index < prescriptions.Count; index++) {
                result += prescriptions[index].ToString() + "\n";
            }
            return result;
        }

        public override string ToString() {
            string result = $"{Name} yob {Yob}";
            result += $"List of prescription \n {GetPrescriptions()}";
            return result;
        }

        public void SaveAsText(string filename) {
            using (StreamWriter outputFile = new StreamWriter(filename)) {
                outputFile.WriteLine(ToString());
            }
        }
    }
}
