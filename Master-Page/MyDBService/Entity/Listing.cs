using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDBService.Entity
{
    public class Listing
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Location { get; set; }

        public string Type { get; set; }

        public string ExperienceRequried { get; set; }

        public double SalaryRangeStart { get; set; }

        public double SalaryRangeEnd { get; set; }

        public string Overview { get; set; }

        public string Responsibilities { get; set; }

        public string Requirements { get; set; }

        public string Level { get; set; }

        public string QualificationsRequired { get; set; }

        public string Catergories { get; set; }

        public DateTime Expiration { get; set; }

        public int Vacancy { get; set; }

        public string HideOrganisation { get; set; }

        public DateTime CreatedDate { get; set; }

        public int Active { get; set; }

        public Listing()
        {

        }
        // Define a constructor to initialize all the properties
        public Listing(int id, string title, string location, string type, string experienceRequired, double salaryRangeStart, double salaryRangeEnd, string overview, string responsibilities, string requirements, string level, string qualificationsRequired, string catergories, DateTime expiration, int vacancy, string hideOrganisation, DateTime createdDate, int active)
        {
            Id = id;
            Title = title;
            Location = location;
            Type = type;
            ExperienceRequried = experienceRequired;
            SalaryRangeStart = salaryRangeStart;
            SalaryRangeEnd = salaryRangeEnd;
            Overview = overview;
            Responsibilities = responsibilities;
            Requirements = requirements;
            Level = level;
            QualificationsRequired = qualificationsRequired;
            Catergories = catergories;
            Expiration = expiration;
            Vacancy = vacancy;
            HideOrganisation = hideOrganisation;
            CreatedDate = createdDate;
            Active = active;
        }
        public int Insert()
        {
            //Step 1 -  Define a connection to the database by getting
            //          the connection string from App.config
            string DBConnect = ConfigurationManager.ConnectionStrings["JobSeekers"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            // Step 2 - Create a SqlCommand object to add record with INSERT statement
            string sqlStmt = "set identity_insert Listing ON; INSERT INTO Listing (id, title, location, type, experienceRequired, salaryRangeStart, salaryRangeEnd, overview, responsibilities, requirements, level, qualificationsRequired, catergories, expiration, vacancy, hideOrganisation, createdDate, Active) " +
                "VALUES (@paraId,@paraTitle, @paraLocation, @paraType, @paraExperienceRequried, @paraSalaryStart, @paraSalaryEnd, @paraOverview, @paraResponsibilities, @paraRequirements, @paraLevel, @paraQualificationsRequired, @paraCategories, @paraExpiration, @paraVacancy, @paraHideOrganisation, @paraCreatedDate, @paraActivate)";
            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);

            // Step 3 : Add each parameterised variable with value
            sqlCmd.Parameters.AddWithValue("@paraId", Id);
            sqlCmd.Parameters.AddWithValue("@paraTitle", Title);
            sqlCmd.Parameters.AddWithValue("@paraLocation", Location);
            sqlCmd.Parameters.AddWithValue("@paraType", Type);
            sqlCmd.Parameters.AddWithValue("@paraExperienceRequried", ExperienceRequried);
            sqlCmd.Parameters.AddWithValue("@paraSalaryStart", SalaryRangeStart);
            sqlCmd.Parameters.AddWithValue("@paraSalaryEnd", SalaryRangeEnd);
            sqlCmd.Parameters.AddWithValue("@paraOverview", Overview);
            sqlCmd.Parameters.AddWithValue("@paraResponsibilities", Responsibilities);
            sqlCmd.Parameters.AddWithValue("@paraRequirements", Requirements);
            sqlCmd.Parameters.AddWithValue("@paraLevel", Level);
            sqlCmd.Parameters.AddWithValue("@paraQualificationsRequired", QualificationsRequired);
            sqlCmd.Parameters.AddWithValue("@paraCategories", Catergories);
            sqlCmd.Parameters.AddWithValue("@paraExpiration", Expiration);
            sqlCmd.Parameters.AddWithValue("@paraVacancy", Vacancy);
            sqlCmd.Parameters.AddWithValue("@paraActivate", Active);
            sqlCmd.Parameters.AddWithValue("@paraHideOrganisation", HideOrganisation);
            sqlCmd.Parameters.AddWithValue("@paraCreatedDate", CreatedDate);

            // Step 4 Open connection the execute NonQuery of sql command   
            myConn.Open();
            int result = sqlCmd.ExecuteNonQuery();

            // Step 5 :Close connection
            myConn.Close();

            return result;
        }
        public List<Listing> SelectAll()
        {
            //Step 1 -  Define a connection to the database by getting
            //          the connection string from App.config
            string DBConnect = ConfigurationManager.ConnectionStrings["JobSeekers"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            //Step 2 -  Create a DataAdapter object to retrieve data from the database table
            string sqlStmt = "Select * from Listing";
            SqlDataAdapter da = new SqlDataAdapter(sqlStmt, myConn);

            //Step 3 -  Create a DataSet to store the data to be retrieved
            DataSet ds = new DataSet();

            //Step 4 -  Use the DataAdapter to fill the DataSet with data retrieved
            da.Fill(ds);

            //Step 5 -  Read data from DataSet to List
            List<Listing> JobList = new List<Listing>();
            int rec_cnt = ds.Tables[0].Rows.Count;
            for (int i = 0; i < rec_cnt; i++)
            {
                DataRow row = ds.Tables[0].Rows[i];  // Sql command returns only one record
                int id = Convert.ToInt32(row["id"]);
                string title = row["title"].ToString();
                string location = row["location"].ToString();
                string type = row["type"].ToString();
                string experienceRequired = row["experienceRequired"].ToString();
                double salaryRangeStart = Convert.ToDouble(row["salaryRangeStart"]);
                double salaryRangeEnd = Convert.ToDouble(row["salaryRangeEnd"]);
                string overview = row["overview"].ToString();
                string responsibilities = row["responsibilities"].ToString();
                string requirements = row["requirements"].ToString();
                string level = row["level"].ToString();
                string qualificationsRequired = row["qualificationsRequired"].ToString();
                string catergories = row["catergories"].ToString();
                int vacancy = Convert.ToInt32(row["vacancy"]);
                DateTime expiration = Convert.ToDateTime(row["expiration"]);
                string hideOrganisation = row["hideOrganisation"].ToString();
                DateTime createdDate = Convert.ToDateTime(row["createdDate"]);
                int Active = Convert.ToInt32(row["Active"]);
                Listing obj = new Listing(id, title, location, type, experienceRequired, salaryRangeStart, salaryRangeEnd, overview, responsibilities, requirements, level, qualificationsRequired, catergories, expiration, vacancy, hideOrganisation, createdDate, Active);
                JobList.Add(obj);
            }
            return JobList;
        }
        public Listing SelectById(int Id)
        {
            //Step 1 -  Define a connection to the database by getting
            //          the connection string from App.config
            string DBConnect = ConfigurationManager.ConnectionStrings["JobSeekers"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            //Step 2 -  Create a DataAdapter object to retrieve data from the database table
            string sqlStmt = "Select * from Listing WHERE id = @paraId";
            SqlDataAdapter da = new SqlDataAdapter(sqlStmt, myConn);
            da.SelectCommand.Parameters.AddWithValue("@paraId", Id);

            //Step 3 -  Create a DataSet to store the data to be retrieved
            DataSet ds = new DataSet();

            //Step 4 -  Use the DataAdapter to fill the DataSet with data retrieved
            da.Fill(ds);

            //Step 5 -  Read data from DataSet to List
            Listing list = null;
            int rec_cnt = ds.Tables[0].Rows.Count;
            if (rec_cnt == 1)
            {
                DataRow row = ds.Tables[0].Rows[0];  // Sql command returns only one record
                int id = Convert.ToInt32(row["id"]);
                string title = row["title"].ToString();
                string location = row["location"].ToString();
                string type = row["type"].ToString();
                string experienceRequired = row["experienceRequired"].ToString();
                double salaryRangeStart = Convert.ToDouble(row["salaryRangeStart"]);
                double salaryRangeEnd = Convert.ToDouble(row["salaryRangeEnd"]);
                string overview = row["overview"].ToString();
                string responsibilities = row["responsibilities"].ToString();
                string requirements = row["requirements"].ToString();
                string level = row["level"].ToString();
                string qualificationsRequired = row["qualificationsRequired"].ToString();
                string catergories = row["catergories"].ToString();
                int vacancy = Convert.ToInt32(row["vacancy"]);
                DateTime expiration = Convert.ToDateTime(row["expiration"]);
                string hideOrganisation = row["hideOrganisation"].ToString();
                DateTime createdDate = Convert.ToDateTime(row["createdDate"]);
                int Active = Convert.ToInt32(row["Active"]);
                list = new Listing(id, title, location, type, experienceRequired, salaryRangeStart, salaryRangeEnd, overview, responsibilities, requirements, level, qualificationsRequired, catergories, expiration, vacancy, hideOrganisation, createdDate, Active);
            }
            return list;
        }
    }
}
