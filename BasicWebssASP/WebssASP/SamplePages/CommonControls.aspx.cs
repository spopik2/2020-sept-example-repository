using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebssASP.SamplePages
{
    public partial class CommonControls : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //this method executes BEFORE any event method on EACH processing of this webpage
            //this is a great place to do common code that is required on Each process of the page
            //example: empty out old messages
            MessageLabel.Text = "";
            //this is an exellent place to do page initialization of controls for
            //      the first time
            //checking the first time for this page uses the post back flag
            // IsPostBack is a boolean value
            if (!Page.IsPostBack)
            {
                // if the page is not postback, it means that this is the 
                //first time the page has been displayed
                //you can fo page initialization

                // create a collection of instances (class objects)
                //  that will be used to load the dropdown list
                // this will simulate the loading of the control 
                //  as if the data came from the database table 
                //each instance would represent a record of the 
                // database dataset.

                //to accomplish this simulation, we will create a class and use it with the List<T>
                // the <T> in this example is the class DDLData 
                List<DDLData> DDLCollection = new List<DDLData>();
                DDLCollection.Add(new DDLData(1, "COMP1008"));
                DDLCollection.Add(new DDLData(3, "DMIT1508")); 
                DDLCollection.Add(new DDLData(4, "DMIT2018")); 
                DDLCollection.Add(new DDLData(2, "CPSC1517"));

                //sorting a List<T>
                //(x,y) are placeholders representing any 2 records at any given time during the sort
                // => (lamda symbol) is part of the delegate syntax, I suggest 
                //      to you read this symbol as  "do the following"
                //comparing x to y is ascending 
                //comparing y to x is descending 
                DDLCollection.Sort((x,y) => x.DisplayText.CompareTo(y.DisplayText));

                //place the data into the dropdownlist control
                // 4 steps to this process

                //a) assign the data collection to the control
                CollectionList.DataSource = DDLCollection;

                //b) in this step you will assign the value that will 
                //      be displayed to the user and the value that will
                //      be associatied and retruned fromt the control 
                //      when the user picks a perticular selection
                //in the <select> control, this data was setup using the <option>
                //          <option value="xxx">display string</option>

                //2 styles in setting up the control values
                //a) physical string of field name
                CollectionList.DataValueField = "ValueID";
                //b)OOP style coding
                CollectionList.DataTextField = nameof(DDLData.DisplayText);

                //3 bind your data source to your control
                CollectionList.DataBind();

                //4 optional is to add a prompt line to your dropdownlist
                CollectionList.Items.Insert(0, new ListItem("Select ...", "0"));


            }

        }

        protected void SubmitNumberChoice_Click(object sender, EventArgs e)
        {
            int numberchoice = 0;
            //validation checking that i have good data for my choice
            if (string.IsNullOrEmpty(NumberChoice.Text))
            {
                MessageLabel.Text = "Enter a number from 1 to 4";
            }
            else if(!int.TryParse(NumberChoice.Text, out numberchoice))
            {
                MessageLabel.Text = "Invalid number. Enter a number from 1 to 4";
            }
            else if(numberchoice < 1 || numberchoice > 4)
            {
                MessageLabel.Text = "Number is out of range. Enter a number from 1 to 4";
            }
            else
            {
                //good input data
                //RadioButtonList
                //assign a value to the RadioButtonList to indicate the item choice 
                //  based on the input data value
                //this can be done using either: .SelectedValue or .SelectIndex
                //.SelectedValue will match the control item value to the argument (BEST TO USE)
                //.SelectedIndex select the control item to show based on the numerical
                //      index value (for PHYSICAL POSITIONING ONLY)
                RadioButtonListChoice.SelectedValue = NumberChoice.Text;
                //RadioButtonListChoice.SelectedValue = numberchoice.ToString();

                //set the checkbox
                if(numberchoice == 2 || numberchoice == 4)
                {
                    CheckBoxChoice.Checked = true;
                }
                else
                {
                    CheckBoxChoice.Checked = false;
                }

                //position in CollectionList on the selected item row
                //this can be done using either: .SelectedValue or .SelectIndex
                //.SelectedValue will match the control item value to the argument (BEST TO USE)
                //.SelectedIndex select the control item to show based on the numerical
                //      index value (for PHYSICAL POSITIONING ONLY)
                CollectionList.SelectedValue = numberchoice.ToString();

                //access data from the CollectionList and display in teh 
                // ReadOnly label
                //this can be done using either: .SelectedValue or .SelectIndex or .SelectedItem
                //.SelectedValue will return the value associated with the select item 
                //from the dropdownlist
                //.SelectedIndex will return the index of the row selected in the dropdownlist (physical index position of the row)
                // .SelectedItem will return the display text associated with the selected item from the dropdownlist (is the displaytext)
                DisplayReadOnly.Text = CollectionList.SelectedItem.Text + " at index " + CollectionList.SelectedIndex +
                                            " having a value of " + CollectionList.SelectedValue
                                            + ". This matches the radio button choice item "
                                            + RadioButtonListChoice.SelectedValue;
            }
        }
    }
}