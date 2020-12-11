/*
 * Description: The Default Page acts as our home page. It is here, where Members
 *              and Staff will be able to access their respective pages. Staff 
 *              Members will have access to Members Services in addition to having
 *              certain privelleges like "Registering New Staff" & "Searching" for
 *              Staff Members or Members. Both Members and Staff will have access to
 *              our Member Page. This page is the home to our services, which include
 *              a Weather Data Service (Jessica), a zipcode convertor and Earthquake 
 *              Index Service (Bradley) and a Wind Danger Level Service (Gabriel). These
 *              services are meant to allow our user to search particular information about
 *              a given terrority related to weather/natural hazards.
 *              
 *              The default page is responsible for keeping track of cookies/sessions per user
 *              along with redirecting to specific login pages, registration pages, member 
 *              and staff pages, and our service directory.
 * 
 * Project 5 (Assignments 8 & 9)
 * Team 61
 * CSE 445/598 Distributed Software Development
 * Session C Fall 2020
 * Dr. Yinong Chen
 * 
 * Authors: Bradley McGarvin
 *          Gabriel Anderson
 *          Jessica Wood
 * 
 */



using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DefaultPage
{
    public partial class _Default : Page
    {
        string memberName;
        int memberID;
        protected void Page_Load(object sender, EventArgs e)
        {
            serviceDirectoryPanel.Visible = false;
            try {
                memberName = (string)Session["MemberName"];
                memberID = (int)Session["MemberID"];
            } catch (Exception ex) {
                Session["MemberID"] = 0;
                Session["MemberName"] = "";
            }
        }

        /*
         *  Member Login Button Click Event Handler
         *  
         *  
         */
        protected void mLoginBtn_Click(object sender, EventArgs e) {
            if (memberID > 0) {
                Response.Redirect("Account/MemberPage.aspx"); //member is already logged in
            } else {
                Response.Redirect("Account/MemberLogin.aspx"); //assume member already exists, redirect to login
            }
            
        }


        /*
         *  Member Home Page Button Click Event Handler
         *  
         *  Check first to see if the member is already logged in,
         *  if so, then it goes right to the Member Home Page.
         *  Otherwise, go to Member Login.
         */
        protected void mHomePageBtn_Click(object sender, EventArgs e)
        {
            if (memberID > 0) {
                Response.Redirect("Account/MemberPage.aspx"); //member is already logged in/registered
            } else {
                Response.Redirect("Account/MemberRegistration.aspx");
                //Response.Redirect("Account/MemberRegistration.aspx"); //if not, you must be new
            }

        }


        /*
         *  Staff Login Button Click Event Handler
         */
        protected void sLoginBtn_Click(object sender, EventArgs e)
        {
            if (memberID > 1) {
                Response.Redirect("Protected/StaffPage.aspx"); //staff is already logged in/registered; definitely cant be member
            } else {
                Response.Redirect("Login.aspx");        // need to create separate login for staff
            }

        }


        /*
         *  Staff Home Page Button Click Event Handler
         *  
         *  Check first to see if the staff is already logged in, 
         *  if so, then it goes righ to the Staff Home Page. 
         *  Otherwise, go to the Staff Login.
         */
        protected void sHomePageBtn_Click(object sender, EventArgs e)
        {
            if (memberID > 1)
            {
                Response.Redirect("Protected/StaffPage.aspx"); //staff is already logged in/registered; definitely cant be member
                /*
                Response.Redirect("http://webstrar61.fulton.asu.edu/page3/Protected/StaffPage");
                */
            } else {
                Response.Redirect("Login.aspx");        // re-direct to the staff page if already logged in
            }
        }


        /*
         * Redirect to our Service Directory (or just display in panel on default page when button is pressed
         */
        protected void btnServDirectory_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://webstrar61.fulton.asu.edu/");
        }
    }
}