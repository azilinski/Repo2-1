using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

#region
using eRestaurantSystem.BLL.Security;
using eRestaurantSystem.BLL;
using eRestaurantSystem.Entities;
using eRestaurantSystem.Entities.Security;
using eRestaurantSystem.POCOs;
using Microsoft.AspNet.Identity;
#endregion

public partial class DemoPages_Security_DefaultSecurity : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DataBindUserList();
            DataBindRoleList();
        }

        //sample to check security authentication
        //check the Request object that is part of every
        // internet trip
        //must have the this
        if (Request.IsAuthenticated)
        {
            string msg = "";
            msg += this.User.Identity.Name;
            UserManager um = new UserManager();
            var theUser = um.FindByName(this.User.Identity.Name);
            msg += " has the folloing data: ID: " + theUser.WaiterID.ToString() + " Email: "
                + theUser.Email;
            bob.Text = msg;
        }
    }
    private void DataBindRoleList()
    {
        // Populate the Roles Info
        RoleListView.DataSource = new RoleManager().Roles.ToList();
        RoleListView.DataBind();
    }
    private void DataBindUserList()
    {
        // Populate the Users Info
        UserListView.DataSource = new UserManager().Users.ToList();
        UserListView.DataBind();
    }

    protected void DataPagerUser_PreRender(object sender, EventArgs e)
    {
        //used for embedding paging on the ListView
        //call the method that binds your data to your ListView
        DataBindUserList();
    }
    protected void DataPagerRoles_PreRender(object sender, EventArgs e)
    {
        //call the method that binds your data to your ListView
        DataBindRoleList();
    }
    protected void UserListView_ItemCommand(object sender, ListViewCommandEventArgs e)
    {
        switch (e.CommandName)
        {
            case "AddWaiters":
                new UserManager().AddDefaultUsers();
                DataBindUserList();
                break;
            default:
                break;
        }
    }
    protected void RoleListView_ItemCommand(object sender, ListViewCommandEventArgs e)
    {
        switch (e.CommandName)
        {
            case "AddDefaultRoles":
                new RoleManager().AddDefaultRoles();
                DataBindRoleList();
                break;
            default:
                break;
        }
    }
}