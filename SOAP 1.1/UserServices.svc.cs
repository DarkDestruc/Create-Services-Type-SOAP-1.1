using SOAP_1._1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SOAP_1._1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class UserServices : IUserServices
    {
        List<Fruit> fruits = new List<Fruit>();
        public List<Fruit> GetFruit()
        {
            return fruits;
        }

        public Fruit CreateFruit(Fruit fruit)
        {
            if (fruit == null)
            {
                throw new ArgumentNullException("fruit");
            }
            if (fruit.NameFruit.Length == 0)
            {
                throw new ArgumentNullException("Fruit.Name");
            }
            if (fruit.ColorFruit.Length == 0)
            {
                throw new ArgumentNullException("Fruit.ColorFruit");
            }
            fruits.Add(fruit);
            return fruit;
        }

    }
}
    