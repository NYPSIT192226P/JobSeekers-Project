<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="JobListing.aspx.cs" Inherits="Master_Page_Design.JobListing" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link rel="stylesheet" href="JobListingStaff.css">
    <div id="ListingBox">
        <h3>Job Listings</h3>
        <input id="JobSearchBar" type="text" placeholder="Search by job title" />
        <button id="Searchbtn">Search</button>
        <p id="SortText">Sort:</p>
        <asp:DropDownList ID="DropDownList1" runat="server" BackColor="White" ForeColor="#3399FF">
            <asp:ListItem Value="1">Newest</asp:ListItem>
            <asp:ListItem Value="2">Oldest</asp:ListItem>
        </asp:DropDownList>
    </div>
    <div id="JobListingBox">
        <h3>Job 1</h3>
        <table style="width: 100%;">
            <tr>
                <td>
                    <p>Expires on </p>
                </td>
                <td>
                    <p>Number1</p>
                </td>
                <td>
                    <p>Number2</p>
                </td>
                <td>
                    <p>Number3</p>
                </td>
            </tr>
            <tr>
                <td>
                    <p>Posted on </p>
                </td>
                <td>
                    <p>Applications</p>
                </td>
                <td>
                    <p>Impressions</p>
                </td>
                <td>
                    <p>Clicks</p>
                </td>
                <td>
                    <a>More Details</a>
                </td>
                <td>
                    <a>Save to favourites</a>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
