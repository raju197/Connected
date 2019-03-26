using AddressBookConnectedPractical;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
  public  class Bussiness
    {
        DataAccess d = new DataAccess();
        public int InsertAddress(Address address) {

            return (d.InsertAddress(address));
        }
        public int UpdataAddress(int addressid, Address addres) {

            return (d.UpdataAddress(addressid, addres));

        }
        public int DeleteAddress(int addressid) {

            return (d.DeleteAddress(addressid));

        }
        public Address Searchaddress(string LastName) {

            return (d.Searchaddress(LastName));
        }
        public DataSet returndataset()
        {


            return d.returndataset();

        }
    }
}
