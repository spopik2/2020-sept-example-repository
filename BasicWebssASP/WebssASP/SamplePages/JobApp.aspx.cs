using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebssASP.SamplePages
{
    public partial class JobApp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MessageLabel.Text = "";
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            string msg = "";
            msg += " Name: " + FullName.Text;
            msg += " Email Address: " + EmailAddress.Text;
            msg += " Phone number: " + Phone.Text;
            msg += " Time: " + (FullOrPartTime.Text == "1" ? "Full-time" :
                                FullOrPartTime.Text=="2" ? "Part-time": "Either");

            // handle checkboxlist
            //Traverse the checkbox list, review one item
            //  at a time and add those items selected to the message
            //if no items were chosen, then add an appropriate message 
            /// stating that no items were chosen
            msg += " Jobs: ";
            //set found flag to nothing found "false"
            bool found = false;
            //loop processing, if somehting is found then 
            //      set the found flag to true
            foreach(ListItem jobrow in Jobs.Items)
            {
                //for each item in the collection 
                if (jobrow.Selected)
                {
                    msg += jobrow.Text + " ";
                    found = true;
                }
            }
            //check if somethign was found
            if (!found)
            {
                msg += "You did not select a job. Application rejected";
            }
            MessageLabel.Text = msg;
        }

        protected void Clear_Click(object sender, EventArgs e)
        {
            FullName.Text = "";
            EmailAddress.Text = "";
            Phone.Text = "";
            //For list there are a couple of way to reset
            //a) manuall reset the control SelectIdex to -1
            FullOrPartTime.SelectedIndex = -1;
            //b) use a control method to reset(Don prefers)
            Jobs.ClearSelection();
        }
    }
}