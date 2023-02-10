using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TransportDataLib;

namespace TransportService
{
    public partial class Service : System.Web.UI.Page
    {
        public static ITransData repo = new TransRepo();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                var routeData = repo.GetAllRoutes();
                dpRoute.DataSource = routeData;
                dpRoute.DataTextField = "RouteName";
                dpRoute.DataValueField = "RouteId";
                dpRoute.DataBind();
            }
        }
        
        protected void dpRoute_SelectedIndexChanged(object sender, EventArgs e)
        {
           

            var id = int.Parse(dpRoute.SelectedItem.Value);
          
            var pickpoints = repo.GetPickups(id);
            dpStart.DataSource = pickpoints;
            dpStart.DataTextField = "PickupName";
            dpStart.DataValueField = "PickupNo";
            dpStart.DataBind();
           
        }
        
       
        protected void dpStart_SelectedIndexChanged(object sender, EventArgs e)
        {

            var pickupNo = int.Parse(dpStart.SelectedItem.Value);
            // start = pickupNo;

            int rtid = int.Parse(dpRoute.SelectedItem.Value);
            var pickpoints = repo.GetPickups(rtid);
            var pickuplist = pickpoints.ToList();
            var foundEndPickups = EndPickPoint(pickuplist, pickupNo);
            dpEnd.DataSource = foundEndPickups;
            dpEnd.DataTextField = "PickupName";
            dpEnd.DataValueField = "PickupNo";
            dpEnd.DataBind();


        }
        public List<PickupTable> EndPickPoint(List<PickupTable> pickpoints,int pickupNo)
        {
            int start = int.Parse(dpStart.SelectedItem.Value);
           
            var endpickups = pickpoints.FindAll((e) => e.PickupNo > pickupNo);
            return endpickups;
        }

        protected void dpEnd_SelectedIndexChanged(object sender, EventArgs e)
        {
             
            var pickupNo = int.Parse(dpEnd.SelectedItem.Value);
           // end = pickupNo;
        }

        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            int start = int.Parse(dpStart.SelectedItem.Value);
            int end = int.Parse(dpEnd.SelectedItem.Value);
            int travelledPoints = end - start;
            var route = repo.GetAllRoutes();
            var routeList = route.ToList();
            int rtid = int.Parse(dpRoute.SelectedItem.Value);
            var found = routeList.FirstOrDefault((r) => r.RouteId == rtid);
            //if(found ==null)
            //{
            //    throw new Exception("Route not found");
            //}
            //else
            //{ 
            var pickups = found.NoOfPickPoints;
            var amount = found.Amount;
            var totalAmount = (amount / pickups) * travelledPoints;
                txtAmount.Text = totalAmount.ToString();
           // }



            var context = new TransportEntities();
            var bill = new BillTable
            {
                BillAmount = totalAmount,
                EmpId = int.Parse(txtEmpId.Text)
            };

            repo.AddBill(bill);
           
        }
    }
}