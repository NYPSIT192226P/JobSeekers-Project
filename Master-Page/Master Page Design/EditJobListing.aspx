<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditJobListing.aspx.cs" Inherits="Master_Page_Design.EditJobListing1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link rel="stylesheet" href="AddJobListing.css">
    <h2 style="margin-left: 40%">Editing Job Listing</h2>
    <table style="width: 100%">
        <tr>
            <td>
                <div class="ProgressBar">
                    <%--<a href="#Basic" class="ProgessColor">Job title, Location, Job type</a>--%>
                    <asp:Button ID="BasicLink" class="ButtonLink" runat="server" Text="1" OnClick="EditBasicLink_Click" />
                    <%--<a href="#AdvanceInfo" class="ProgessColor">Experience, Salary, Overview</a>--%>
                    <asp:Button ID="AdvanceLink" class="ButtonLink" runat="server" Text="2" OnClick="EditAdvanceLink_Click" />
                    <%--<a href="#AdvanceInfo" class="ProgessColor">Resposibilities</a>--%>
                    <asp:Button ID="ResponsibilitiesLink" class="ButtonLink" runat="server" Text="3" OnClick="EditResponsibilitiesLink_Click" />
                    <%--<a href="#AdvanceInfo" class="ProgessColor">Requirements</a>--%>
                    <asp:Button ID="RequirementLink" class="ButtonLink" runat="server" Text="4" OnClick="EditRequirementLink_Click" />
                    <%--<a href="#AdvanceInfo" class="ProgessColor">Job level, Qualifications, Categories, Listing Expiry Date</a>--%>
                    <asp:Button ID="FinalLink" class="ButtonLink" runat="server" Text="5" OnClick="EditFinalLink_Click" />
                </div>
            </td>
        </tr>
        <tr class="InputRow">
            <td>
                <asp:Panel class="ListingBox" id="BasicBox" runat="server">
                    <p id="jobTitle">Job title</p>
                    <asp:TextBox ID="JobTitleTB" runat="server"></asp:TextBox>
                    <br />
                    <p id="JobDesc">Location</p>
                    &nbsp;<asp:TextBox ID="JobLocationTB" runat="server"></asp:TextBox>
                    <br />
                    &nbsp;<p id="NoOfJobs">Jobs available</p>
                        &nbsp;<asp:TextBox ID="NoOfJobsTB" runat="server" TextMode="Number"></asp:TextBox>
                        <br />
                </asp:Panel>
                <asp:Panel class="ListingBox" id="AdvanceInfoBox" runat="server" Visible="False">
                    <p id="jobExperience">Experience</p>
                    <asp:TextBox ID="ExperienceTB" runat="server"></asp:TextBox>
                    <br />
                    <p id="jobSalary">Salary Range</p>
                    <asp:Label id="bold2" runat="server">$</asp:Label>
                    <asp:TextBox ID="SalaryStartTB" runat="server" TextMode="Number"></asp:TextBox>
                    <asp:Label id="bold" runat="server">to</asp:Label>
                    <asp:TextBox ID="SalaryEndTB" runat="server" TextMode="Number"></asp:TextBox>
                    <br />
                    <p id="jobOverview">Overview</p>
                    <asp:TextBox ID="OverviewTB" runat="server"></asp:TextBox>
                    <br />
                </asp:Panel>
                <asp:Panel class="ListingBox" id="RespobsibilitiesBox" runat="server" Visible="False">
                    <p id="JobResponsibility" style="font-weight: bold;">Responsibilities</p>
                    <asp:TextBox ID="ResponsibilityTB" runat="server"></asp:TextBox>
                    <br />
                </asp:Panel>
                <asp:Panel class="ListingBox" id="RequirementsBox" runat="server" Visible="False">
                    <p id="jobRequirements" style="font-weight: bold;">Requirements</p>
                    <asp:TextBox ID="RequirementTB" runat="server"></asp:TextBox>
                    <br />
                </asp:Panel>
                <asp:Panel class="ListingBox" id="FinalInfoBox" runat="server" Visible="False">
                    <p id="JobLevel" style="font-weight: bold;">Job Level</p>
                    <asp:TextBox ID="LevelTB" runat="server"></asp:TextBox>
                    <br />
                    <p id="JobQualifications" style="font-weight: bold;">Qualifications</p>
                    <asp:TextBox ID="QualificationTB" runat="server"></asp:TextBox>
                    <br />
                    <p id="JobCategories" style="font-weight: bold;">Categories</p>
                    <asp:TextBox ID="CategoriesTB" runat="server"></asp:TextBox>
                    <br />
                    <p id="JobOrganisation" style="font-weight: bold;">Organisation</p>
                    <asp:TextBox ID="OrganisationTB" runat="server"></asp:TextBox>
                    <br />
                    <p id="JobExipry" style="font-weight: bold;">Listing Expiry Date</p>
                    <asp:TextBox ID="ExipryTB" runat="server" TextMode="Date"></asp:TextBox>
                    <br />
                    <asp:Button ID="AddBtn" runat="server" Text="Edit Job" OnClick="EditBtn_Click" />
                    <br />
                    <asp:Label ID="ErrorMsg" runat="server"></asp:Label>
                </asp:Panel>
            </td>
        </tr>
    </table>



</asp:Content>
