<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="JobListing Staff.aspx.cs" Inherits="Master_Page_Design.JobListing_Staff" %>

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
        <asp:Button ID="CreateListingBtn" runat="server" Text="Create Listing" OnClick="CreateListingBtn_Click" BackColor="#3399FF" ForeColor="white" BorderColor="#3399FF" Style="float: right; margin-right: 63px;" />
    </div>

    <asp:GridView ID="gvListing" runat="server" AutoGenerateColumns="False" style=" width:80%; margin-left: auto; margin-right: auto; margin-top: 25px;" OnRowCommand="gridview_RowCommand">
        <Columns>
            <asp:BoundField DataField="id" HeaderText="Id" />
            <asp:BoundField DataField="title" HeaderText="Title" ReadOnly="True" />
            <asp:BoundField DataField="createdDate" HeaderText="Created on" DataFormatString="{0:dd/MM/yyyy}" />
            <asp:BoundField DataField="expiration" HeaderText="Expires on" DataFormatString="{0:dd/MM/yyyy}" />
            <asp:BoundField DataField="vacancy" HeaderText="Vacancy" />
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:LinkButton runat="server" CommandName="Modify_Listing">Modify</asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:LinkButton ID="ActiveBtn" runat="server" ForeColor="Red" CommandName="Inactive_Listing">Inactivate</asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <EditRowStyle BackColor="#6BB9FF" />
        <SortedAscendingCellStyle BackColor="#6D95E1" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
    </asp:GridView>


    <%--<div id="JobListingBox">
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
                    <a>Modify</a>
                </td>
                <td>
                    <a>Inactivate</a>
                </td>
            </tr>
        </table>
    </div>--%>

    <asp:Label ID="ErrorMsg" runat="server"></asp:Label>
    <div id="TestLabel"></div>
</asp:Content>
