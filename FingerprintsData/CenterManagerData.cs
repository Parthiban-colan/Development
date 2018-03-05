using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using FingerprintsModel;
using System.Web.Mvc;
using System.Web;
using System.IO;

namespace FingerprintsData
{
    public class CenterManagerData
    {
        SqlConnection Connection = connection.returnConnection();
        SqlCommand command = new SqlCommand();
        SqlDataAdapter DataAdapter = null;
        DataSet _dataset = null;

        public List<DailySaftyCheckImages> GetDailySaftyCheckImages(Guid? UserId)
        {
            List<DailySaftyCheckImages> listImage = new List<DailySaftyCheckImages>();
            try
            {
                command.Connection = Connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "SP_GetCenterManagerDailySafetyCheckImages";
                command.Parameters.Add(new SqlParameter("@UserId", UserId));
                DataAdapter = new SqlDataAdapter(command);
                _dataset = new DataSet();
                DataAdapter.Fill(_dataset);
                if (_dataset.Tables[0] != null)
                {
                    if (_dataset.Tables[0].Rows.Count > 0)
                    {
                        DailySaftyCheckImages images = null;
                        foreach (DataRow dr in _dataset.Tables[0].Rows)
                        {
                            images = new DailySaftyCheckImages();
                            images.Id = new Guid(dr["Id"].ToString());
                            images.ImageDescription = dr["ImageDescription"].ToString();
                            images.ImagePath = dr["ImagePath"].ToString();
                            if (!string.IsNullOrEmpty(dr["PassFailCode"].ToString()))
                            {
                                bool PassFailCode = Convert.ToBoolean(dr["PassFailCode"].ToString());
                                images.PassFailCode = PassFailCode;
                            }
                            if (!string.IsNullOrEmpty(dr["ToStaffId"].ToString()))
                                images.ToStaffId = new Guid(dr["ToStaffId"].ToString());
                            images.RouteCode = dr["RouteCode"].ToString();
                            listImage.Add(images);
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
                if (Connection != null)
                    Connection.Close();
            }
            return listImage;

        }
    }
}
