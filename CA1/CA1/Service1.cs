using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CA1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public string GetData(string fname, string lname, string email, string username, string password)
        {
            return string.Format("First name: {0}", fname);
            return string.Format("Last name: {0}", lname);
            return string.Format("Email: {0}", email);
            return string.Format("Username: {0}", username);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public string GetPssw(string password)
        {
            return string.Format("Password: {0}", password);
        }
    }
}
