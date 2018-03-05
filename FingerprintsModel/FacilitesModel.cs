using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FingerprintsModel
{
    public class FacilitesModel
    {
        public List<FacilitiesManagerDashboard> FacilitiesDashboardList { get; set; }
        public FacilitesModel()
        {
            //this.FacilitiesDashboardList = new List<FacilitiesManagerDashboard>();
          //new FacilitesModel();
            this.FacilitiesDashboardList = new List<FacilitiesManagerDashboard>();
        }
       public static FacilitesModel GetInstance()
        {
            return new FacilitesModel();
        }

    }



    public class FacilitiesManagerDashboard
    {
        public string CenterName { get; set; }
        public string Enc_CenterId { get; set; }
        public long CenterId { get; set; }
        public long OpenedWorkOrders { get; set; }
        public long AssignedWorkOrders { get; set; }
        public long CompletedWorkOrders { get; set; }
        public long TemporarilyFixedWorkOrders { get; set; }
       
    }

   
}

