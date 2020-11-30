using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApp2.DataAccess;

namespace WebApp2.Pages
{
    public partial class Students : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                using (var ctx = new SchoolDbContext())
                {
                    var students = ctx.Students.ToList();
                    StudentsGridview.DataSource = students;
                    StudentsGridview.DataBind();
                }
            }
        }
    }
}