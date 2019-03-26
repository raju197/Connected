using AddressBookConnectedPractical;
using BussinessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentationLayer
{
    public partial class Presentation : System.Web.UI.Page
    {
       Bussiness b = new Bussiness();
        DataSet data = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInsertAddress_Click(object sender, EventArgs e)
        {
           
            Address a = new Address();
            a.FistName = txtFirstname.Text;
            a.LastName = TxtLastName.Text;
            a.EmailId = txtEmailId.Text;
            a.PhoneNo = txtPhoneNo.Text;
            
            int flag = b.InsertAddress(a);
            if (flag > 0)
            {
                meslabel.Text = "Record inserted in AddressBook table";
            }
        }

        protected void btnUpdateAddress_Click(object sender, EventArgs e)
        {
            Address a = new Address();
            int result = 0;
            a.FistName = txtFirstname.Text;
            a.LastName = TxtLastName.Text;
            a.EmailId = txtEmailId.Text;
            a.PhoneNo = txtPhoneNo.Text;
            int addressid = Convert.ToInt16(txtAddressId.Text);
            result = b.UpdataAddress(addressid , a);
            if(result > 0) {
                meslabel.Text = "Record updated successfully";
            }
        }

        protected void btndelete_Click(object sender, EventArgs e)
        {
            int result = b.DeleteAddress(Convert.ToInt16(txtAddressId.Text));
            if(result > 0)
            {
                meslabel.Text = "Record deleted successfully";

            }
        }

        protected void btndelete0_Click(object sender, EventArgs e)
        {
            data = b.returndataset();
            GridViewAddressBook.DataSource = data;
            GridViewAddressBook.DataBind();
            meslabel.Text = "data is being displayed";
        }

        protected void btnfind_Click(object sender, EventArgs e)
        {
            Address add = b.Searchaddress(txtlastnamefind.Text);
            if (add != null)
            {
                txtAddressId.Text = add.AddressId.ToString();
                txtFirstname.Text = add.FistName.ToString();
                TxtLastName.Text = add.LastName.ToString();
                txtEmailId.Text = add.EmailId.ToString();
                txtPhoneNo.Text = add.PhoneNo.ToString();
                meslabel.Text = "data found";


            }
            else
                meslabel.Text = "Data not found";

        }

        //protected void btnUpdateAddress_Click(object sender, EventArgs e)
        //{

        //}
    }
}