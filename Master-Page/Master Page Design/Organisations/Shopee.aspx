<%@ Page Title="Shopee" Language="C#" MasterPageFile="~/Employer.Master" AutoEventWireup="true" CodeBehind="Shopee.aspx.cs" Inherits="Master_Page_Design.Organisations.Shopee" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <!-- Aspect Ratio: 228 : 47 -->
    <asp:Image ID="im_organisation_profile_headerimage" runat="server" ImageUrl="/Assets/images/shopee_banner.jpg" />
    <div class="di_profilecard">
        <asp:Image ID="im_organisation_profilecard_logo" runat="server" ImageUrl="/Assets/images/shopee.jpg" />
        <div class="di_profilecard_namerow">
            <asp:Label ID="lb_organisation_profilecard_name" runat="server" Text="Shopee Singapore Private Limited<span class='lb_profilecard_idverified'><i class='fas fa-check'></i>&nbsp;&nbsp;Verified Organisation</span>"></asp:Label>
        </div>
        <div class="di_profilecard_headlinerow">
            <asp:Label ID="lb_organisation_profilecard_headline" runat="server" Text="Internet Company"></asp:Label>
        </div>
        <asp:Label ID="lb_organisation_profilecard_website" runat="server" Text="Website"></asp:Label>
        <a href="https://careers.shopee.sg/" class="ah_organisation_profilecard_website_link">careers.shopee.sg <i class="fas fa-external-link-alt"></i></a>
        <asp:Label ID="lb_organisation_profilecard_employees" runat="server" Text="Employees"></asp:Label>
        <asp:Label ID="lb_organisation_profilecard_employees_count" runat="server" Text="8,000+"></asp:Label>
        <asp:Label ID="lb_organisation_profilecard_headquarters" runat="server" Text="Headquarters"></asp:Label>
        <asp:Label ID="lb_organisation_profilecard_headquarters_location" runat="server" Text="Queenstown, Singapore"></asp:Label>
    </div>
    <div class="di_organisation_profile_nav">
        <div class="di_organisation_profile_nav_about">
            <span>About</span>
        </div>
        <div class="di_organisation_profile_nav_reviews" id="di_organisation_profile_nav_selected">
            <span>Reviews</span>
        </div>
        <div class="di_organisation_profile_nav_lifehere">
            <span>Life Here</span>
        </div>
        <div class="di_organisation_profile_nav_gallery">
            <span>Gallery</span>
        </div>
        <div class="di_organisation_profile_nav_jobs">
            <span>Jobs</span>
        </div>
        <div class="di_organisation_profile_nav_salaryandbenefits">
            <span>Salary & Benefits</span>
        </div>
        <div class="di_organisation_profile_nav_interviews">
            <span>Interviews</span>
        </div>
    </div>
    <div class="di_organisation_profile_reviewcontrols">
        <div class="lb_organisation_profile_reviewcontrols_search">
            <asp:TextBox ID="lb_organisation_profile_reviewcontrols_searchbar" placeholder="Search by job titles, keywords" runat="server"></asp:TextBox>
            <asp:Button ID="bt_organisation_profile_reviewcontrols_searchbutton" runat="server" Text="Search" />
            <asp:Button ID="bt_organisation_profile_reviewcontrols_writereview" runat="server" Text="Write Review" />
        </div>
        <div class="di_organisation_profile_reviewcontrols_filter">
            <span class="lb_organisation_profile_reviewcontrols_filter">Filter: </span>
            <asp:DropDownList ID="dd_organisation_profile_reviewcontrols_filter_jobstatus" runat="server">
                <asp:ListItem Enabled="True" Selected="True">Job Status</asp:ListItem>
            </asp:DropDownList>
            <asp:DropDownList ID="dd_organisation_profile_reviewcontrols_filter_location" runat="server">
                <asp:ListItem Enabled="True" Selected="True">Location</asp:ListItem>
            </asp:DropDownList>
            <asp:DropDownList ID="dd_organisation_profile_reviewcontrols_filter_rating" runat="server">
                <asp:ListItem Enabled="True" Selected="True">Rating</asp:ListItem>
            </asp:DropDownList>
        </div>
        <div class="di_organisation_profile_reviewcontrols_sort">
            <span class="lb_organisation_profile_reviewcontrols_sort">Sort: </span>
            <asp:DropDownList ID="dd_organisation_profile_reviewcontrols_sort" runat="server">
                <asp:ListItem Enabled="True" Selected="True">Popular</asp:ListItem>
            </asp:DropDownList>
        </div>
    </div>
    <div class="di_organisation_profile_reviews">
        <div class="di_organisation_profile_reviews_item">
            <div class="di_organisation_profile_reviews_item_general">
                <div class="di_organisation_profile_reviews_item_stars">
                    <i class="fas fa-star"></i><i class="fas fa-star"></i><i class="fas fa-star"></i><i class="fas fa-star"></i><i class="far fa-star"></i>&nbsp;&nbsp;<span class="di_organisation_profile_reviews_item_stars_count">4.0</span><span class="di_organisation_profile_reviews_item_stars_dropdown">&nbsp;<i class="fas fa-chevron-down"></i></span>
                </div>
                <div class="di_organisation_profile_reviews_item_summary">
                    <span class="lb_organisation_profile_reviews_item_summary_status">Status</span>
                    <span class="lb_organisation_profile_reviews_item_summary_status_status">Current Employee</span>
                    <span class="lb_organisation_profile_reviews_item_summary_location">Location</span>
                    <span class="lb_organisation_profile_reviews_item_summary_location_location">Singapore, Singapore</span>
                </div>
            </div>
            <div class="di_organisation_profile_reviews_item_main">
                <span class="lb_organisation_profile_reviews_item_main_title">Full of learning opportunities and fast paced.</span>
                <div class="di_organisation_profile_reviews_item_main_detailed">
                    <span class="lb_organisation_profile_reviews_item_main_detailed_pros">Pros</span>
                    <span class="lb_organisation_profile_reviews_item_main_detailed_pros_passage">Team mates are all very diligent.<br />
                        Company pantries is well stocked with drinks and snacks.<br />
                        Exciting and full of learning opportunities as the company is growing very fast.
                    </span>
                    <span class="lb_organisation_profile_reviews_item_main_detailed_cons">Cons</span>
                    <span class="lb_organisation_profile_reviews_item_main_detailed_cons_passage">Pace is very fast, OT hard to avoid.</span>
                    <span class="lb_organisation_profile_reviews_item_main_detailed_advice">Advice</span>
                    <span class="lb_organisation_profile_reviews_item_main_detailed_cons_passage">Management should make salary more competitive, if not staff will jump ship easily</span>
                </div>
            </div>
        </div>
    </div>
    <div class="padding30">&nbsp;</div>
    <script src="/JobSeekersMyProfile.js"></script>
    <script>showEmployerNavAccountDropdown();</script>
</asp:Content>
