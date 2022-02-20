/***
 * @brief   this is the file that runs the pubs application form logic
 * 
 * @author  Josh Bussis
 * @author  Bryan Fowler
 * @author  Bryce Allen
 * @author  Charlie Newton
 * @date    2020/12/13
 * @project CS 342 final project
 * @where   Calvin University
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PubsApplication
{
    public partial class pubsAppForm : Form
    {
        private static String connString = "Data Source=localhost;" +
                    "Initial Catalog=pubs;Integrated Security=true ";
        private SqlConnection mConn;

        public pubsAppForm()
        {
            InitializeComponent();
            // Initialize the sql connection
            mConn = new SqlConnection(connString);
            // populate the author list box
            getAllAuthors();
            // indicate that the list box is showing authors
            listBoxLabel.Text = "Authors";
        }

        /// <summary>
        /// viewBooksButton_Click() gets the current author's books
        ///     and displays them in the list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void viewBooksButton_Click(object sender, EventArgs e)
        {
            // get the raw string from the selected author text box
            string currentAuthorRaw = selectedAuthor.Text;
            // define the query to get all the author-books pairs
            string queryString = "select * from  vAuthorTitles;";
            // split the raw author string into first and last names
            string authorFirst = currentAuthorRaw.Split(' ')[0];
            string authorLast = currentAuthorRaw.Split(' ')[1];

            // check that an author is selected
            if (selectedAuthor.Text != "")
            {
                // open the sql connection
                mConn.Open();
                // get rid of what is in the list box so that books can be displayed
                authorListBox.Items.Clear();
                // send the query to the sql server and get the results
                SqlDataAdapter adapter = new SqlDataAdapter(queryString, mConn);
                // make a dataset to hold the titles
                DataSet titles = new DataSet();
                // populate the dataset with the query results
                adapter.Fill(titles, "titles");
                // loop through all the titles, and make sure we only display those of the
                // current author
                foreach (DataRow tr in titles.Tables["titles"].Rows)
                {
                    // make sure first and last name are the same as the selected author
                    if ((string)tr["au_fname"] == authorFirst && (string)tr["au_lname"] == authorLast)
                        authorListBox.Items.Add(tr["title"]);
               
                }
                // close the sql connection
                mConn.Close();
            }
            // indicate that the list box is showing books
            listBoxLabel.Text = "Books";

        }

        /// <summary>
        /// updateAddressButton_Click() handles sending the contents of the
        ///     new address text boxes to the sql server and updates the 
        ///     selected author's address info
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updateAddressButton_Click(object sender, EventArgs e)
        {
            // get all of the new address info from the text boxes
            string newAddr = newAddressText.Text;
            string newCity = newCityText.Text;
            string newState = newStateText.Text;
            string newZIP = newZIPText.Text;
            // get the current author's name in raw form
            string currentAuthorRaw = selectedAuthor.Text;
            // make sure an author has been selected
            if (currentAuthorRaw != "")
            {
                // split the author's name into first and last names
                string authorFirst = currentAuthorRaw.Split(' ')[0];
                string authorLast = currentAuthorRaw.Split(' ')[1];
                // initialize auhtID to NO AUTHOR to make sure we have a 
                // valid ID later
                string authID = "NO AUTHOR";
                // define query to get all the authors
                string queryStringGetAuthID = "select * from authors;";
                // make sure there's entered data in the new address text boxes
                if (newAddr != "" && newCity != "" && newState != "" & newZIP != "")
                {
                    // open the sql connection
                    mConn.Open();
                    // send the query to get all the auhtors
                    SqlDataAdapter adapter = new SqlDataAdapter(queryStringGetAuthID, mConn);
                    // make new data set to hold the authors
                    DataSet authors = new DataSet();
                    // populate the dataset with the results from the query
                    adapter.Fill(authors, "authors");
                    // loop through the authers to get the selected author's au_id
                    foreach (DataRow tr in authors.Tables["authors"].Rows)
                    {
                        // make sure the first and last name are the same
                        if ((string)tr["au_fname"] == authorFirst && (string)tr["au_lname"] == authorLast)
                            authID = tr["au_id"].ToString();

                    }
                    
                    // make sure that we have a valid au_id
                    if (authID != "NO AUTHOR")
                    {
                        // sql command to update the address info of the selected author
                        // with the stored procedure proc_ainfo
                        string stringUpdate = "EXEC proc_ainfo '" + authID +
                                                    "', '" + newAddr +
                                                    "', '" + newCity +
                                                    "', '" + newState +
                                                    "', '" + newZIP + "';";
                        // make a new sql command object
                        SqlCommand updateCmd = new SqlCommand(stringUpdate, mConn);
                        // execute the command
                        updateCmd.ExecuteNonQuery();
                    }
                    // close the connection
                    mConn.Close();
                }
            }
        }

        /// <summary>
        /// viewAllButton_Click() calls getAllAuthors() to populate
        ///     the list box with all of the authors so the user can
        ///     select a new author
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void viewAllButton_Click(object sender, EventArgs e)
        {
            getAllAuthors();
            // indicate that the list box is showing authors
            listBoxLabel.Text = "Authors";
        }

        /// <summary>
        /// getAllAuthors() gets all of the auhtors from the sql server
        ///     and displays them in the list box
        /// </summary>
        private void getAllAuthors()
        {
            // clear the list box so that the authors can be added
            authorListBox.Items.Clear();
            // indicate that no author is selected
            selectedAuthor.Text = "";
            // open the sql connection
            mConn.Open();
            // query to get all the authors
            string queryString = "select * from  authors;";
            // send the query and get the results
            SqlDataAdapter adapter = new SqlDataAdapter(queryString, mConn);
            // make a dataset to hold the authors
            DataSet authors = new DataSet();
            // populate the dataset with the results from the query
            adapter.Fill(authors, "authors");
            // loop through the authors and display their full name
            // to the list box in a nicely formatted way
            foreach (DataRow tr in authors.Tables["authors"].Rows)
            {
                authorListBox.Items.Add(tr["au_fname"] + " " + tr["au_lname"]);
            }
            // close the sql connection
            mConn.Close();
        }

        /// <summary>
        /// authorListBox_SelectedIndexChanged() updates the selectedAuthor
        ///     text box with the author that the user selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void authorListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // make sure that authors, and not books, are being displayed
            if (listBoxLabel.Text == "Authors")
            {
                // get the selected author and display it in the text box
                selectedAuthor.Text = authorListBox.SelectedItem.ToString();
            }
        }
    }
}
