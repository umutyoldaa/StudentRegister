using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StudentRegister.classes;

namespace StudentRegister
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnectionClass.checkedconnection();
            SqlCommand commandinfo = new SqlCommand("insert into tablomusicogrenci(ADSOYAD,telefon,mail,enstruman,gun)values(@pad,@ptel,@pmail,@pens,@pgun)", SqlConnectionClass.connection);
            commandinfo.Parameters.AddWithValue("@pad", tboxname.Text);
            commandinfo.Parameters.AddWithValue("@ptel", tboxphone.Text);
            commandinfo.Parameters.AddWithValue("@pmail", tboxmail.Text);
            commandinfo.Parameters.AddWithValue("@pens", DropDownList1.SelectedValue);
            commandinfo.Parameters.AddWithValue("@pgun", DropDownList2.SelectedValue);
            commandinfo.ExecuteNonQuery();

        }
    }
}