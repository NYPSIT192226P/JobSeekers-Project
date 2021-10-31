using Master_Page_Design.JobSeekerServiceReference;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Master_Page_Design
{
    public partial class AddNewListing : System.Web.UI.Page
    {
        string ErrorField = "";
        int NoOfListing = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            GetNoOfListing();
        }

        private void GetNoOfListing()
        {
            List<Listing> eList = new List<Listing>();
            JobSeekerServiceReference.Service1Client client = new JobSeekerServiceReference.Service1Client();
            eList = client.GetAllListing().ToList<Listing>();
            foreach (var i in eList)
            {
                NoOfListing += 1;
            }
        }

        protected Boolean Validate()
        {
            int invalidCount = 0;
            int basicCount = 0;
            int AdvanceCount = 0;
            int ResponsibilitiesCount = 0;
            int RequirementCount = 0;
            int FinalInfoCount = 0;
            bool validation = false;

            if (String.IsNullOrEmpty(JobTitleTB.Text))
            {
                basicCount += 1;
                invalidCount += 1;
            }
            if (String.IsNullOrEmpty(JobLocationTB.Text))
            {
                basicCount += 1;
                invalidCount += 1;
            }
            if (String.IsNullOrEmpty(NoOfJobsTB.Text))
            {
                basicCount += 1;
                invalidCount += 1;
            }
            if (String.IsNullOrEmpty(ExperienceTB.Text))
            {
                AdvanceCount += 1;
                invalidCount += 1;
            }
            if (String.IsNullOrEmpty(SalaryStartTB.Text))
            {
                AdvanceCount += 1;
                invalidCount += 1;
            }
            if (String.IsNullOrEmpty(SalaryEndTB.Text))
            {
                AdvanceCount += 1;
                invalidCount += 1;
            }
            if (String.IsNullOrEmpty(OverviewTB.Text))
            {
                AdvanceCount += 1;
                invalidCount += 1;
            }
            if (String.IsNullOrEmpty(ResponsibilityTB.Text))
            {
                ResponsibilitiesCount += 1;
                invalidCount += 1;
            }
            if (String.IsNullOrEmpty(RequirementTB.Text))
            {
                RequirementCount += 1;
                invalidCount += 1;
            }
            if (String.IsNullOrEmpty(LevelTB.Text))
            {
                FinalInfoCount += 1;
                invalidCount += 1;
            }
            if (String.IsNullOrEmpty(QualificationTB.Text))
            {
                FinalInfoCount += 1;
                invalidCount += 1;
            }
            if (String.IsNullOrEmpty(CategoriesTB.Text))
            {
                FinalInfoCount += 1;
                invalidCount += 1;
            }
            if (String.IsNullOrEmpty(OrganisationTB.Text))
            {
                FinalInfoCount += 1;
                invalidCount += 1;
            }
            if (String.IsNullOrEmpty(ExipryTB.Text))
            {
                FinalInfoCount += 1;
                invalidCount += 1;
            }
            if (invalidCount != 0)
            {
                validation = false;
                if(basicCount != 0)
                {
                    ErrorField += "1";
                    if (AdvanceCount != 0)
                    {
                        ErrorField += ", ";
                    }
                    else if (ResponsibilitiesCount != 0)
                    {
                        ErrorField += ", ";
                    }
                    else if(RequirementCount != 0)
                    {
                        ErrorField += ", ";
                    }
                    else if(FinalInfoCount != 0)
                    {
                        ErrorField += ", ";
                    }
                }
                if (AdvanceCount != 0)
                {
                    ErrorField += "2";
                    if (ResponsibilitiesCount != 0)
                    {
                        ErrorField += ", ";
                    }
                    else if(RequirementCount != 0)
                    {
                        ErrorField += ", ";
                    }
                    else if(FinalInfoCount != 0)
                    {
                        ErrorField += ", ";
                    }
                }
                if (ResponsibilitiesCount != 0)
                {
                    ErrorField += "3";
                    if (RequirementCount != 0)
                    {
                        ErrorField += ", ";
                    }
                    else if(FinalInfoCount != 0)
                    {
                        ErrorField += ", ";
                    }
                }
                if (RequirementCount != 0)
                {
                    ErrorField += "4";
                    if (FinalInfoCount != 0)
                    {
                        ErrorField += ", ";
                    }
                }
                if (FinalInfoCount != 0)
                {
                    ErrorField += "5";
                }
            }
            else if (invalidCount == 0)
            {
                validation = true;
            }
            return validation;
        }

        protected void AddBtn_Click(object sender, EventArgs e)
        {
            if (Validate() == true)
            {
                DateTime Exipry = Convert.ToDateTime(ExipryTB.Text);
                DateTime Created = DateTime.Now;
                double SalaryStart = Convert.ToDouble(SalaryStartTB.Text);
                double SalaryEnd = Convert.ToDouble(SalaryEndTB.Text);
                int Vacancy = Convert.ToInt32(NoOfJobsTB.Text);
                JobSeekerServiceReference.Service1Client client = new JobSeekerServiceReference.Service1Client();
                int result = client.CreateListing(NoOfListing, JobTitleTB.Text, JobLocationTB.Text, NoOfJobsTB.Text, ExperienceTB.Text, SalaryStart, SalaryEnd, OverviewTB.Text, ResponsibilityTB.Text, RequirementTB.Text, LevelTB.Text, QualificationTB.Text, CategoriesTB.Text, Exipry, Vacancy, OrganisationTB.Text, Created, 1);
                if (result == 1)
                {
                    ErrorMsg.ForeColor = Color.Green;
                    ErrorMsg.Text = "Employee Record Inserted Successfully!";
                    Response.Redirect("JobListing Staff.aspx", false);
                }
                else
                    ErrorMsg.Text = "SQL Error. Insert Unsuccessful!";
            }
            else
            {
                ErrorMsg.Text = "Missing inputs in pages " + ErrorField + ".";
                ErrorMsg.ForeColor = Color.Red;
            }
        }

        protected void BasicLink_Click(object sender, EventArgs e)
        {
            BasicBox.Visible = true;
            AdvanceInfoBox.Visible = false;
            RespobsibilitiesBox.Visible = false;
            RequirementsBox.Visible = false;
            FinalInfoBox.Visible = false;
        }

        protected void AdvanceLink_Click(object sender, EventArgs e)
        {
            BasicBox.Visible = false;
            AdvanceInfoBox.Visible = true;
            RespobsibilitiesBox.Visible = false;
            RequirementsBox.Visible = false;
            FinalInfoBox.Visible = false;
        }

        protected void ResponsibilitiesLink_Click(object sender, EventArgs e)
        {
            BasicBox.Visible = false;
            AdvanceInfoBox.Visible = false;
            RespobsibilitiesBox.Visible = true;
            RequirementsBox.Visible = false;
            FinalInfoBox.Visible = false;
        }

        protected void RequirementLink_Click(object sender, EventArgs e)
        {
            BasicBox.Visible = false;
            AdvanceInfoBox.Visible = false;
            RespobsibilitiesBox.Visible = false;
            RequirementsBox.Visible = true;
            FinalInfoBox.Visible = false;
        }

        protected void FinalLink_Click(object sender, EventArgs e)
        {
            BasicBox.Visible = false;
            AdvanceInfoBox.Visible = false;
            RespobsibilitiesBox.Visible = false;
            RequirementsBox.Visible = false;
            FinalInfoBox.Visible = true;
        }
    }
}