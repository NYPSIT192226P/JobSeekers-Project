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
    public partial class EditJobListing1 : System.Web.UI.Page
    {
        string Error2 = "";
        string ErrorField = "";
        int NoOfListing = 0;
        int ListingId = 0;

        string eTitle = "";
        string eLocation = "";
        string eType = "";
        string eExperienceRequired = "";
        double eSalaryRangeStart = 0;
        double eSalaryRangeEnd = 0;
        string eOverview = "";
        string eResponsibilities = "";
        string eRequirements = "";
        string eLevel = "";
        string eQualificationsRequired = "";
        string eCategories = "";
        DateTime eExpiration = DateTime.Now;
        int eVacancy = 0;
        string eHideOrganisation = "";
        DateTime eCreatedDate = DateTime.Now;
        int eActive = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            GetNoOfListing();
            ListingId = Convert.ToInt32(Session["ListingId"]);
            JobSeekerServiceReference.Service1Client client = new JobSeekerServiceReference.Service1Client();
            Listing SelectedList = client.GetListingById(ListingId);
            eTitle = SelectedList.Title;
            eLocation = SelectedList.Location;
            eType = SelectedList.Type;
            eExperienceRequired = SelectedList.ExperienceRequried;
            eSalaryRangeStart = SelectedList.SalaryRangeStart;
            eSalaryRangeEnd = SelectedList.SalaryRangeEnd;
            eOverview = SelectedList.Overview;
            eResponsibilities = SelectedList.Responsibilities;
            eRequirements = SelectedList.Requirements;
            eLevel = SelectedList.Level;
            eQualificationsRequired = SelectedList.QualificationsRequired;
            eCategories = SelectedList.Catergories;
            eExpiration = SelectedList.Expiration;
            eVacancy = SelectedList.Vacancy;
            eHideOrganisation = SelectedList.HideOrganisation;
            eCreatedDate = SelectedList.CreatedDate;
            eActive = SelectedList.Active;
            JobTitleTB.Text = eTitle;
            JobLocationTB.Text = eLocation;
            NoOfJobsTB.Text = eVacancy.ToString();
            ExperienceTB.Text = eExperienceRequired;
            SalaryStartTB.Text = eSalaryRangeStart.ToString();
            SalaryEndTB.Text = eSalaryRangeEnd.ToString();
            OverviewTB.Text = eOverview;
            ResponsibilityTB.Text = eResponsibilities;
            RequirementTB.Text = eRequirements;
            LevelTB.Text = eLevel;
            QualificationTB.Text = eQualificationsRequired;
            CategoriesTB.Text = eCategories;
            OrganisationTB.Text = eHideOrganisation;
            ExipryTB.Text = eExpiration.ToString();

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
            Error2 += "No of Listing = " + NoOfListing.ToString();
        }

        protected void EditBtn_Click(object sender, EventArgs e)
        {
            if (ValidateEdit() == true)
            {
                DateTime Exipry = Convert.ToDateTime(ExipryTB.Text);
                DateTime Created = DateTime.Now;
                double SalaryStart = Convert.ToDouble(SalaryStartTB.Text);
                double SalaryEnd = Convert.ToDouble(SalaryEndTB.Text);
                int Vacancy = Convert.ToInt32(NoOfJobsTB.Text);
                JobSeekerServiceReference.Service1Client client = new JobSeekerServiceReference.Service1Client();
                //int result = client.CreateListing(NoOfListing, JobTitleTB.Text, JobLocationTB.Text, NoOfJobsTB.Text, ExperienceTB.Text, SalaryStart, SalaryEnd, OverviewTB.Text, ResponsibilityTB.Text, RequirementTB.Text, LevelTB.Text, QualificationTB.Text, CategoriesTB.Text, Exipry, Vacancy, OrganisationTB.Text, Created, 1);
                //if (result == 1)
                //{
                //    ErrorMsg.ForeColor = Color.Green;
                //    ErrorMsg.Text = "Employee Record Inserted Successfully!";
                //}
                //else
                //    ErrorMsg.Text = "SQL Error. Insert Unsuccessful!";
            }
            else
            {
                ErrorMsg.Text = "Missing inputs in pages " + ErrorField + ".";
                ErrorMsg.ForeColor = Color.Red;
            }
        }
        protected Boolean ValidateEdit()
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
                if (basicCount != 0)
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
                    else if (RequirementCount != 0)
                    {
                        ErrorField += ", ";
                    }
                    else if (FinalInfoCount != 0)
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
                    else if (RequirementCount != 0)
                    {
                        ErrorField += ", ";
                    }
                    else if (FinalInfoCount != 0)
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
                    else if (FinalInfoCount != 0)
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

        protected void EditBasicLink_Click(object sender, EventArgs e)
        {
            BasicBox.Visible = true;
            AdvanceInfoBox.Visible = false;
            RespobsibilitiesBox.Visible = false;
            RequirementsBox.Visible = false;
            FinalInfoBox.Visible = false;
        }

        protected void EditAdvanceLink_Click(object sender, EventArgs e)
        {
            BasicBox.Visible = false;
            AdvanceInfoBox.Visible = true;
            RespobsibilitiesBox.Visible = false;
            RequirementsBox.Visible = false;
            FinalInfoBox.Visible = false;
        }

        protected void EditResponsibilitiesLink_Click(object sender, EventArgs e)
        {
            BasicBox.Visible = false;
            AdvanceInfoBox.Visible = false;
            RespobsibilitiesBox.Visible = true;
            RequirementsBox.Visible = false;
            FinalInfoBox.Visible = false;
        }

        protected void EditRequirementLink_Click(object sender, EventArgs e)
        {
            BasicBox.Visible = false;
            AdvanceInfoBox.Visible = false;
            RespobsibilitiesBox.Visible = false;
            RequirementsBox.Visible = true;
            FinalInfoBox.Visible = false;
        }

        protected void EditFinalLink_Click(object sender, EventArgs e)
        {
            BasicBox.Visible = false;
            AdvanceInfoBox.Visible = false;
            RespobsibilitiesBox.Visible = false;
            RequirementsBox.Visible = false;
            FinalInfoBox.Visible = true;
        }
    }
}