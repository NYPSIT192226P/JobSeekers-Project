using MyDBService.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MyDBService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
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

        public List<Listing> GetAllListing()
        {
            Listing list = new Listing();
            return list.SelectAll();
        }

        public Listing GetListingById(int id)
        {
            Listing list = new Listing();
            return list.SelectById(id);
        }

        public int CreateListing(int id, string title, string location, string type, string experienceRequired, double salaryRangeStart, double salaryRangeEnd, string overview, string responsibilities, string requirements, string level, string qualificationsRequired, string catergories, DateTime expiration, int vacancy, string hideOrganisation, DateTime createdDate, int active)
        {
            Listing list = new Listing(id, title, location, type, experienceRequired, salaryRangeStart, salaryRangeEnd, overview, responsibilities, requirements, level, qualificationsRequired, catergories, expiration, vacancy, hideOrganisation, createdDate, active);
            return list.Insert();
        }
    }
}
