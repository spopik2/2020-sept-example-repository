using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebssASP;

namespace WebApp.SamplePages
{
    public partial class ContestEntry : System.Web.UI.Page
    {
        //Due to the fact, that this example is NOT using a database
        //to retain data, the following List<T> will serve as a collection
        // dataset
        // The List<T> is declared static
        // the List<T> will remain active as long a the web appllication is running
        // the List<T> is created on the 1st presentation of this web page
        //WARNING: all users would have acces to this List<T>
        static List<Entry> entries = new List<Entry>();
        protected void Page_Load(object sender, EventArgs e)
        {
            Message.Text = "";
            // on the first presentation of the page 
            if (!Page.IsPostBack)
            {
                if (entries.Count > 0)
                {
                    EntryList.DataSource = entries;
                    EntryList.DataBind();
                }
            }
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            //re-execute the validation controls on the server side
            if (Page.IsValid)
            {
                if (Terms.Checked)
                {
                    Entry theEntry = new Entry();

                    theEntry.FirstName = FirstName.Text;
                    theEntry.LastName = LastName.Text;
                    theEntry.StreetAddress1 = StreetAddress1.Text;
                    theEntry.StreetAddress2 = string.IsNullOrEmpty(StreetAddress2.Text) ?
                        null : StreetAddress2.Text;
                    theEntry.City = City.Text;
                    theEntry.Province = Province.Text;
                    theEntry.PostalCode = PostalCode.Text;
                    theEntry.EmailAddress = EmailAddress.Text;
                    //add the new instance to a collection of entries
                    entries.Add(theEntry);
                    //display the collection
                    //use a collection display control that displays multiple 
                    //      seperate columns: GridView
                    //requirements
                    //a)data source(collection)
                    //b)bind the data to the control
                    EntryList.DataSource = entries;
                    EntryList.DataBind();

                }
                else
                {
                    Message.Text = "You did not agree to the contest terms. Entry rejected.";
                }
            }
        }

        protected void Clear_Click(object sender, EventArgs e)
        {
            FirstName.Text = "";
            LastName.Text = "";
            StreetAddress1.Text = "";
            StreetAddress2.Text = "";
            City.Text = "";
            PostalCode.Text = "";
            EmailAddress.Text = "";
            CheckAnswer.Text = "";
            Province.SelectedIndex = 0;
            Terms.Checked = false;
        }
    }
}