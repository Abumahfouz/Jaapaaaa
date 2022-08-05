using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jaapaaaa
{
    internal interface ImmigrationRules
    {
        public string PassportEntry(int idNum, string placeOfIssue, DateTime issueDate, DateTime expDate);
        public bool PoliceReport( string report );
        public bool ReferenceLetter( string docUpload );

        public string Visa( string duration);

        public int Physical { get; set; }
    }
}
