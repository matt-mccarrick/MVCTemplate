using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetaPoco;

namespace MVCTemplate.Domain.Sample
{
    //Petapoco should default to using the class name as the table name, but in case you need to specify
    [TableName("Sample")]
    [PrimaryKey("SampleID", AutoIncrement = true)]

    public class Sample
    {
        //Poco mapping documentation: https://github.com/CollaboratingPlatypus/PetaPoco/wiki/Mapping-Pocos 

        public int SampleID { get; set; }
        public string Foo { get; set; }
        public DateTime Birthday { get; set; }
    }
}
