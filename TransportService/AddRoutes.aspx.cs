using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TransportDataLib;
namespace TransportService
{
    public partial class AddRoutes : System.Web.UI.Page
    {
        public static ITransData repo = new TransRepo();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                var context = new TransportEntities();
                var routes = context.RoutesTables.ToList();
                dpRoutes.DataSource = routes;

                dpRoutes.DataTextField = "RouteName";
                dpRoutes.DataValueField = "RouteId";
                dpRoutes.DataBind();
            }
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {

            var context = new TransportEntities();
            int id = int.Parse(dpRoutes.SelectedValue);
            var pickup = new PickupTable
            {
                PickupName = txtPickupPoint.Text.ToString(),
                PickupNo = int.Parse(txtNoOfStops.Text),
                RouteId=id
            };
            repo.AddPickup(pickup);
        }

        protected void dpRoutes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = int.Parse(dpRoutes.SelectedValue);
        }

        protected void btnRoute_Click(object sender, EventArgs e)
        {
            var context = new TransportEntities();
            var route = new RoutesTable
            {
                RouteName = txtRoute.Text.ToString(),
                NoOfPickPoints = int.Parse(txtNoOfStops.Text),
                Amount=decimal.Parse(txtAmount.Text)
            };
            repo.AddRoute(route);
        }
    }
}