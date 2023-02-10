using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TransportDataLib;
namespace TransportService
{
    public partial class Bill : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                var context = new TransportEntities();
                var bill=context.BillTables.ToList();
                double totalBill = 0;
                foreach(var amount in bill)
                {
                    totalBill +=(double) amount.BillAmount;
                }
                txtTotalbill.Text = totalBill.ToString();
            }
            
        }
    }
}