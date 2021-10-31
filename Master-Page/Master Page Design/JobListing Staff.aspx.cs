using Master_Page_Design.JobSeekerServiceReference;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Master_Page_Design
{
    public partial class JobListing_Staff : System.Web.UI.Page
    {
        string ErrorString = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            GetNoOfListing();
        }

        private void GetNoOfListing()
        {
            List<Listing> eList = new List<Listing>();
            JobSeekerServiceReference.Service1Client client = new JobSeekerServiceReference.Service1Client();
            eList = client.GetAllListing().ToList<Listing>();
            // using gridview to bind to the list of employee objects
            gvListing.Visible = true;
            gvListing.DataSource = eList;
            gvListing.DataBind();
            //foreach (var i in eList)
            //{
            //    ErrorString += i.Title.ToString();
            //    HtmlGenericControl newDiv = new HtmlGenericControl("div");
            //    newDiv.Attributes.Add("class", "JobListingBox");
            //    //TestLabel.InnerHtml = newDiv.ToString();
            //}
            //ErrorMsg.Text = ErrorString.ToString();
        }

        protected void CreateListingBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddNewListing.aspx", false);
        }
        protected void gridview_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.Equals("Modify_Listing"))
            {
                GridViewRow selected = (GridViewRow)((Control)(e.CommandSource)).Parent.Parent;
                int id = Int32.Parse(selected.Cells[0].Text);

                Session["ListingId"] = id;

                Response.Redirect("EditJobListing.aspx");
            }
            if (e.CommandName.Equals("Inactive_Listing"))
            {
                GridViewRow selected = (GridViewRow)((Control)(e.CommandSource)).Parent.Parent;
                int id = Int32.Parse(selected.Cells[0].Text);
                string DBConnect = ConfigurationManager.ConnectionStrings["JobSeekers"].ConnectionString;
                SqlConnection myConn = new SqlConnection(DBConnect);
                string sqlq = "UPDATE Listing SET Active = 0 WHERE id=@Id";
                SqlCommand command = new SqlCommand(sqlq, myConn);
                command.Parameters.AddWithValue("@Id", id);
                try
                {
                    myConn.Open();
                    command.ExecuteNonQuery();
                    myConn.Close();
                }
                catch (SqlException ex)
                {

                    throw new Exception(ex.ToString());
                }
            }

        }
    }
}