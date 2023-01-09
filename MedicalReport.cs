using System;


namespace Assessment
{

class Disease
    {
        public string DiseaseName { get; set; }
        public string Severity { get; set; }
        public string Description { get; set; }
        public string Symptom { get; set; }

    }
    class DetailsRepository
    {
        private Disease[] _diseases = null;
        private readonly int _size = 0;
        public DetailsRepository(int size)
        {
            this._size = size;
           _diseases = new Disease[_size];
        }

        public void AddDisease(Disease dis)
        {
            for(int i=0; i< _size; i++)
            {
                if(_diseases[i] == null)
                {
                    _diseases[i] = new Disease { DiseaseName = dis.DiseaseName, Description = dis.Description, Severity = dis.Severity };
                    //Console.WriteLine("Added Succesfully");
                    return;
                  
                }
            }

        }
        public void AddSymptoms(Disease dis)
        {
            for (int i = 0; i < _size; i++)
            {
                if(_diseases[i] != null && _diseases[i].DiseaseName == dis.DiseaseName)
                {
                    _diseases[i] = new Disease { Symptom = dis.Symptom, Description = dis.Description };
                    //Console.WriteLine("Symptoms added successfully");
                    return;
                }

            }
            throw new Exception("Disease not found");
        }



    }
    class UIComponent
    {
        public const string menu = "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~MEDICAL REPORT APP~~~~~~~~~~~~~~~~~~~\nTO ADD DISEASE DETAILS------------------------>PRESS 1" +
            "\nADD SYMPTOMS---------------->PRESS 2\nCHECK PATIENT----------------->PRESS 3" +
            "\nPS: ANY OTHER KEY IS CONSIDERED AS EXIT.....................................";

        private static DetailsRepository repository = null;
        public static void Run()
        {

            
           
               


        }

    }

    internal class Utilities
    {

    }

    class MedicalReport
    {
        static void Main(string[] args)
        {
           
            

            
            
            
           
           
           
            

        }
    }
}
