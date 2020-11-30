using System;
using System.Linq;
using System.Web.UI.WebControls;
using WebApp3.DataAccess;

namespace WebApp3.Pages
{
    public partial class Students : System.Web.UI.Page
    {
        private readonly ISchoolDbContext _schoolDbContext;

        public Students(ISchoolDbContext schoolDbContext)
        {
            _schoolDbContext = schoolDbContext;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var students = _schoolDbContext.Students.ToList();
                StudentsGridview.DataSource = students;
                StudentsGridview.DataBind();
            }
        }
    }
}