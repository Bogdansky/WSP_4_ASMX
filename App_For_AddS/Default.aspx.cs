using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace App_For_AddS
{
    [EnableCors(origins: "http://localhost:4040", headers: "*", methods: "*")]
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}