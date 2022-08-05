namespace Jaapaaaa
{
    internal class Jaapaaing
    {
        internal class NewTrip : ImmigrationRules
        {
            public int Physical { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public string PassportEntry(int idNum, string placeOfIssue, DateTime issueDate, DateTime expDate)
            {
                Console.WriteLine("Please enter Expiry Date");
                DateTime expiryDate = Convert.ToDateTime(Console.ReadLine());
                if (expiryDate > DateTime.Now)
                {
                   Console.WriteLine("Your Passport is Expired!");
                    return "Passport Expired";
                }
                else
                {
                    Console.WriteLine("Passport is active!");
                    return "Passport Active";
                }


            }

            public bool PoliceReport(string report)
            {
                throw new NotImplementedException();
            }

            public bool ReferenceLetter(bool docUpload)
            {
                bool referenceEntry;
                Console.WriteLine("Please have you got a reference y/n?");
                referenceEntry = false;
                string newEntry = Console.ReadLine();
                if (referenceEntry == true)
                {
                    return true;
                }
                else if (referenceEntry == false)
                {
                    referenceEntry = false;
                }
                return referenceEntry;
            }

            public bool ReferenceLetter(string docUpload)
            {
                throw new NotImplementedException();
            }

            public string Visa(string duration)
            {
                string lenghtOfStay="__ years";
                Console.WriteLine("Enter duration of stay");
                lenghtOfStay = Console.ReadLine();
                
                duration = lenghtOfStay;

                return duration;
                
            }
        }
        static void Main(string[] args)
        {

            NewTrip Traveller = new NewTrip();
            bool NewTrip = Traveller.ReferenceLetter(false);
            Console.WriteLine(NewTrip);
            
        }
    }
}