using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportDataLib
{
    public interface ITransData
    {
        
        List<RoutesTable> GetAllRoutes();
        List<PickupTable> GetPickups(int routeId);
        void AddRoute(RoutesTable routes);
        void AddPickup(PickupTable pickup);
        void AddBill(BillTable bill);
    }
   public class TransRepo : ITransData
    {
        public void AddBill(BillTable bill)
        {
            var context = new TransportEntities();
            context.BillTables.Add(bill);
            context.SaveChanges();
        }

        public void AddPickup(PickupTable pickup)
        {
            var context = new TransportEntities();
            context.PickupTables.Add(pickup);
            context.SaveChanges();
        }

        public void AddRoute(RoutesTable routes)
        {
            var context = new TransportEntities();
            context.RoutesTables.Add(routes);
            context.SaveChanges();
        }

        public List<RoutesTable> GetAllRoutes()
        {
            var context = new TransportEntities();
            var routes = context.RoutesTables.ToList();
            return routes;
        }

        public List<PickupTable> GetPickups(int routeId)
        {
            var context = new TransportEntities();
            var pickuList = context.PickupTables.ToList();
            var foundPickpus = pickuList.FindAll(e => e.RouteId == routeId);
            return foundPickpus;
        }
    }
}
