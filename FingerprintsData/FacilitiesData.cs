using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FingerprintsModel;
namespace FingerprintsData
{
    public class FacilitiesData
    {
        SqlConnection _connection { get; set; }
        SqlCommand command { get; set; }

      //  SqlTransaction transaction { get; set; }
        SqlDataAdapter dataAdapter { get; set; }
        DataSet _dataset { get; set; }

        public FacilitiesData()
        {
            this._connection = connection.returnConnection();
            this.command = new SqlCommand();
          //  this.transaction = null;
            this.dataAdapter = new SqlDataAdapter();
            this. _dataset = new DataSet();
        }

        public FacilitesModel GetFacilitiesModelDashboard(StaffDetails details)
        {

            FacilitesModel facilitiesModel = new FacilitesModel();
            facilitiesModel.FacilitiesDashboardList = new List<FacilitiesManagerDashboard>();
            try
            {
                using (_connection)
                {
                    if (_connection.State == ConnectionState.Open)
                        _connection.Close();

                    command.Parameters.Clear();
                    command.Parameters.Add(new SqlParameter("@AgencyId", details.AgencyId));
                    command.Parameters.Add(new SqlParameter("@userId", details.UserId));
                    command.Parameters.Add(new SqlParameter("@RoleId", details.RoleId));
                    command.Connection = _connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "USP_FacilitiesManagerDashboard";
                    dataAdapter = new SqlDataAdapter(command);
                    _dataset = new DataSet();
                    dataAdapter.Fill(_dataset);
                    if (_dataset.Tables[0] != null)
                    {
                        if (_dataset.Tables[0].Rows.Count > 0)
                        {
                            facilitiesModel.FacilitiesDashboardList = (from DataRow dr in _dataset.Tables[0].Rows

                                                                       select new FacilitiesManagerDashboard
                                                                       {
                                                                           CenterId = Convert.ToInt64(dr["CenterId"]),
                                                                           Enc_CenterId = EncryptDecrypt.Encrypt64(dr["CenterId"].ToString()),
                                                                           CenterName = dr["CenterName"].ToString(),
                                                                           OpenedWorkOrders = Convert.ToInt64(dr["OpenedWorkOrders"]),
                                                                           AssignedWorkOrders = Convert.ToInt64(dr["AssignedWorkOrders"]),
                                                                           CompletedWorkOrders = Convert.ToInt64(dr["CompletedWorkOrders"]),
                                                                           TemporarilyFixedWorkOrders = Convert.ToInt64(dr["TemporarilyFixed"])
                                                                       }).ToList();

                        }

                    }
                }
            }
            catch (Exception ex)
            {
                clsError.WriteException(ex);
            }
            finally
            {
                dataAdapter.Dispose();
                command.Dispose();
                _dataset.Dispose();
            }
            return facilitiesModel;
        }



    }
}
