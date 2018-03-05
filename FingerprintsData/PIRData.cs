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
using System.IO;
using System.Web;

namespace FingerprintsData
{
    public class PIRData
    {
        SqlConnection Connection = connection.returnConnection();
        SqlCommand command = new SqlCommand();
        SqlDataAdapter DataAdapter = null;
        DataSet _dataset = null;

        readonly string c_27_a = "Health impairment";
        readonly string c_27_b = "Emotional disturbance";
        readonly string c_27_c = "Speech or language impairments";
        readonly string c_27_d = "Intellectual disabilities";
        readonly string c_27_e = "Hearing impairment, including deafness";
        readonly string c_27_f = "Orthopedic impairment";
        readonly string c_27_g = "Visual impairment, including blindness";
        readonly string c_27_h = "Specific learning disability";
        readonly string c_27_i = "Autism";
        readonly string c_27_j = "Traumatic brain injury";
        readonly string c_27_k = "Non-categorical/developmental delay";
        readonly string c_27_l = "Multiple disabilities (excluding deaf-blind)";
        readonly string c_27_m = "Deaf-blind";
        public void GetPIRSummary(DataSet _dataset, PIRModel _PIR)
        {
            if (_dataset != null)
            {
                if (_dataset.Tables[0].Rows.Count > 0)
                {

                    foreach (DataRow dr in _dataset.Tables[0].Rows)
                    {


                        _PIR.Gen_Agency = dr["AgencyName"].ToString();
                        _PIR.Gen_Address = dr["Address1"].ToString();
                        _PIR.Gen_Delegate = dr["Delegate"].ToString();
                        _PIR.Gen_Grantee = dr["GranteeNo"].ToString();
                        _PIR.Gen_FName = dr["Firstname"].ToString();
                        _PIR.Gen_LName = dr["Lastname"].ToString();
                        _PIR.Gen_Phone1 = dr["Phone1"].ToString();
                        _PIR.Gen_Fax = dr["Fax"].ToString();
                        _PIR.Gen_Zip = dr["ZipCode"].ToString();
                        _PIR.Gen_Email = dr["EmailAddress"].ToString();
                        _PIR.A_ProgramStartDate = dr["ProgramStartDate"].ToString();
                        _PIR.A_ProgramEndDate = dr["ProgramEndDate"].ToString();
                        _PIR.A_Slots = dr["ServiceQty"].ToString();
                        _PIR.A_SlotsOther = dr["ServiceQtyOther"].ToString();
                        _PIR.A_FundQ1 = dr["FundQ1"].ToString();
                        _PIR.A_FundQ2 = dr["FundQ2"].ToString();
                        _PIR.A_FundQ3 = dr["FundQ3"].ToString();
                        _PIR.A_FundQ4 = dr["FundQ4"].ToString();
                        _PIR.A_FundQ5 = dr["FundQ5"].ToString();
                        _PIR.A_FundQ6 = dr["FundQ6"].ToString();
                        _PIR.A_FundQ7 = dr["FundQ7"].ToString();
                        _PIR.A_FundQ8 = dr["FundQ8"].ToString();
                        _PIR.A_FundQ9 = dr["FundQ9"].ToString();
                        _PIR.A_FundQ10 = dr["FundQ10"].ToString();
                        _PIR.A_FundQ11 = dr["FundQ11"].ToString();
                        _PIR.A_FundQ12 = dr["FundQ12"].ToString();
                        _PIR.A_FundQ13 = dr["FundQ13"].ToString();
                        _PIR.A_FundQ14 = dr["FundQ14"].ToString();
                        _PIR.A_FundQ15 = dr["FundQ15"].ToString();
                        _PIR.A_FundQ16 = dr["FundQ16"].ToString();
                        _PIR.A_11 = dr["A11"].ToString();
                        _PIR.A_12 = dr["A12"].ToString();
                        _PIR.A_12a = dr["A12a"].ToString();
                        _PIR.A_13_0 = dr["A13_0"].ToString();
                        _PIR.A_13_1 = dr["A13_1"].ToString();
                        _PIR.A_13_2 = dr["A13_2"].ToString();
                        _PIR.A_13_3 = dr["A13_3"].ToString();
                        _PIR.A_13_4 = dr["A13_4"].ToString();
                        _PIR.A_13_5 = dr["A13_5"].ToString();

                        _PIR.A_14_Preg = dr["A14_Preg"].ToString();
                        _PIR.A_15 = dr["A15Total"].ToString();
                        _PIR.A_16A = dr["A16A"].ToString();
                        _PIR.A_16B = dr["A16B"].ToString();
                        _PIR.A_16C = dr["A16C"].ToString();
                        _PIR.A_16D = dr["A16D"].ToString();
                        _PIR.A_16E = dr["A16E"].ToString();
                        _PIR.A_16F = dr["A16F"].ToString();
                        _PIR.A_18A = dr["A18_SECOND"].ToString();
                        _PIR.A_18B = dr["A18_THREE"].ToString();
                        _PIR.A_19 = dr["A19_LEFT"].ToString();
                        _PIR.A_19A = dr["A19A_45DAYS"].ToString();
                        _PIR.A_19B = dr["A19_KINDERGARTEN"].ToString();
                        _PIR.A_20 = dr["A20"].ToString();
                        _PIR.A_20A = dr["A20A_45DAYS"].ToString();
                        _PIR.A_25a1 = dr["A25a1"].ToString();
                        _PIR.A_25a2 = dr["A25a2"].ToString();
                        _PIR.A_25b1 = dr["A25b1"].ToString();
                        _PIR.A_25b2 = dr["A25b2"].ToString();
                        _PIR.A_25c1 = dr["A25c1"].ToString();
                        _PIR.A_25c2 = dr["A25c2"].ToString();
                        _PIR.A_25d1 = dr["A25d1"].ToString();
                        _PIR.A_25d2 = dr["A25d2"].ToString();
                        _PIR.A_25e1 = dr["A25e1"].ToString();
                        _PIR.A_25e2 = dr["A25e2"].ToString();
                        _PIR.A_25f1 = dr["A25f1"].ToString();
                        _PIR.A_25f2 = dr["A25f2"].ToString();
                        _PIR.A_25g1 = dr["A25g1"].ToString();
                        _PIR.A_25g2 = dr["A25g2"].ToString();
                        _PIR.A_25h1 = dr["A25h1"].ToString();
                        _PIR.A_25h2 = dr["A25h2"].ToString();
                        _PIR.A_26a = dr["A26a"].ToString();
                        _PIR.A_26b = dr["A26b"].ToString();
                        _PIR.A_26c = dr["A26c"].ToString();
                        _PIR.A_26d = dr["A26d"].ToString();
                        _PIR.A_26e = dr["A26e"].ToString();
                        _PIR.A_26f = dr["A26f"].ToString();
                        _PIR.A_26g = dr["A26g"].ToString();
                        _PIR.A_26h = dr["A26h"].ToString();
                        _PIR.A_26i = dr["A26i"].ToString();
                        _PIR.A_26j = dr["A26j"].ToString();
                        _PIR.A_26k = dr["A26k"].ToString();
                        _PIR.A_27 = dr["ChildTransport"].ToString();
                        _PIR.C_1_1 = dr["C1_AtEnroll"].ToString();
                        _PIR.C_1_2 = dr["C1_EndEnroll"].ToString();
                        _PIR.C_A_1 = dr["C1A_AtEnroll"].ToString();
                        _PIR.C_A_2 = dr["C1A_EndEnroll"].ToString();
                        _PIR.C_B_1 = dr["C1B_AtEnroll"].ToString();
                        _PIR.C_B_2 = dr["C1B_EndEnroll"].ToString();
                        _PIR.C_C_1 = dr["C1C_AtEnroll"].ToString();
                        _PIR.C_C_2 = dr["C1C_EndEnroll"].ToString();
                        _PIR.C_D_1 = dr["C1D_AtEnroll"].ToString();
                        _PIR.C_D_2 = dr["C1D_EndEnroll"].ToString();
                        _PIR.C_2_1 = dr["C2_AtEnroll"].ToString();
                        _PIR.C_2_2 = dr["C2_EndEnroll"].ToString();
                        _PIR.C_3_1 = dr["C3_AtEnroll"].ToString();
                        _PIR.C_3_2 = dr["C3_EndEnroll"].ToString();
                        _PIR.C_3A_1 = dr["C3A_AtEnroll"].ToString();
                        _PIR.C_3A_2 = dr["C3A_EndEnroll"].ToString();
                        _PIR.C_3B_1 = dr["C3B_AtEnroll"].ToString();
                        _PIR.C_3B_2 = dr["C3B_EndEnroll"].ToString();
                        _PIR.C_3C_1 = dr["C3C_AtEnroll"].ToString();
                        _PIR.C_3C_2 = dr["C3C_EndEnroll"].ToString();
                        _PIR.C_3D_1 = dr["C3D_AtEnroll"].ToString();
                        _PIR.C_3D_2 = dr["C3D_EndEnroll"].ToString();
                        /*   _PIR.C_4_1 = dr["C4_AtEnroll"].ToString();
                           _PIR.C_4_2 = dr["C4_EndEnroll"].ToString();
                           _PIR.C_5_1 = dr["C5_AtEnroll"].ToString();
                           _PIR.C_5_2 = dr["C5_EndEnroll"].ToString();
                           _PIR.C_6_1 = dr["C6_AtEnroll"].ToString();
                           _PIR.C_6_2 = dr["C6_EndEnroll"].ToString();
                           _PIR.C_8_1 = dr["C8_AtEnroll"].ToString();
                           _PIR.C_8_2 = dr["C8_EndEnroll"].ToString();
                           **/

                    }

                }
                if (_dataset.Tables[1].Rows.Count > 0)
                {
                    _PIR.C52A = _dataset.Tables[1].Rows[0]["C52A"].ToString();
                    _PIR.C52B = _dataset.Tables[1].Rows[0]["C52B"].ToString();
                    _PIR.C52C = _dataset.Tables[1].Rows[0]["C52C"].ToString();
                    _PIR.C52D = _dataset.Tables[1].Rows[0]["C52D"].ToString();
                    _PIR.C52E = _dataset.Tables[1].Rows[0]["C52E"].ToString();

                }

                if (_dataset.Tables[2].Rows.Count > 0)
                {
                    _PIR.C52A1 = _dataset.Tables[2].Rows[0]["C52A"].ToString();
                    _PIR.C52B1 = _dataset.Tables[2].Rows[0]["C52B"].ToString();
                    _PIR.C52C1 = _dataset.Tables[2].Rows[0]["C52C"].ToString();
                    _PIR.C52D1 = _dataset.Tables[2].Rows[0]["C52D"].ToString();
                    _PIR.C52E1 = _dataset.Tables[2].Rows[0]["C52E"].ToString();

                }
            }


        }


        public void GetDisabilityChildren(string AgencyId, string UserId, PIRModel _disPIR)
        {

            List<DisabilityPIR> pirDisability = new List<DisabilityPIR>();
            DisabilityPIR pirchild = new DisabilityPIR();
            List<DisabilitiesType> disTypeList = new List<DisabilitiesType>();
            DisabilitiesType type = new DisabilitiesType();
            try
            {
                if (Connection.State == ConnectionState.Open)
                    Connection.Close();
                Connection.Open();
                command.Parameters.Clear();
                command.Parameters.Add(new SqlParameter("@AgencyID", AgencyId));
                command.Parameters.Add(new SqlParameter("@UserID", UserId));
                command.Connection = Connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "USP_GetDisabilityChildrenPIR";
                DataAdapter = new SqlDataAdapter(command);
                _dataset = new DataSet();
                DataAdapter.Fill(_dataset);
                if (_dataset != null)
                {
                    if (_dataset.Tables[0] != null)
                    {

                        disTypeList = (from DataRow dr in _dataset.Tables[0].Rows
                                       select new DisabilitiesType
                                       {
                                           ID = dr["ID"].ToString(),
                                           DisabilityType = dr["DisablitiesType"].ToString(),
                                           QualifiedChildrenCount = dr["QualifiedChildrenCount"].ToString(),
                                           ServiceReceivedChildrenCount = dr["ServiceReceivedChildrenCount"].ToString()
                                       }
                                     ).ToList();
                       
                        _disPIR.C_27_a_1 = disTypeList.Where(x => x.DisabilityType == c_27_a).Select(x => x.QualifiedChildrenCount).FirstOrDefault().ToString();
                        _disPIR.C_27_a_2 = disTypeList.Where(x => x.DisabilityType == c_27_a).Select(x => x.ServiceReceivedChildrenCount).FirstOrDefault().ToString();

                        _disPIR.C_27_b_1 = disTypeList.Where(x => x.DisabilityType == c_27_b).Select(x => x.QualifiedChildrenCount).FirstOrDefault().ToString();
                        _disPIR.C_27_b_2 = disTypeList.Where(x => x.DisabilityType == c_27_b).Select(x => x.ServiceReceivedChildrenCount).FirstOrDefault().ToString();

                        _disPIR.C_27_c_1 = disTypeList.Where(x => x.DisabilityType == c_27_c).Select(x => x.QualifiedChildrenCount).FirstOrDefault().ToString();
                        _disPIR.C_27_c_2 = disTypeList.Where(x => x.DisabilityType == c_27_c).Select(x => x.ServiceReceivedChildrenCount).FirstOrDefault().ToString();

                        _disPIR.C_27_d_1 = disTypeList.Where(x => x.DisabilityType == c_27_d).Select(x => x.QualifiedChildrenCount).FirstOrDefault().ToString();
                        _disPIR.C_27_d_2 = disTypeList.Where(x => x.DisabilityType == c_27_d).Select(x => x.ServiceReceivedChildrenCount).FirstOrDefault().ToString();

                        _disPIR.C_27_e_1 = disTypeList.Where(x => x.DisabilityType == c_27_e).Select(x => x.QualifiedChildrenCount).FirstOrDefault().ToString();
                        _disPIR.C_27_e_2 = disTypeList.Where(x => x.DisabilityType == c_27_e).Select(x => x.ServiceReceivedChildrenCount).FirstOrDefault().ToString();

                        _disPIR.C_27_f_1 = disTypeList.Where(x => x.DisabilityType == c_27_f).Select(x => x.QualifiedChildrenCount).FirstOrDefault().ToString();
                        _disPIR.C_27_f_2 = disTypeList.Where(x => x.DisabilityType == c_27_f).Select(x => x.ServiceReceivedChildrenCount).FirstOrDefault().ToString();

                        _disPIR.C_27_g_1 = disTypeList.Where(x => x.DisabilityType == c_27_g).Select(x => x.QualifiedChildrenCount).FirstOrDefault().ToString();
                        _disPIR.C_27_g_2 = disTypeList.Where(x => x.DisabilityType == c_27_g).Select(x => x.ServiceReceivedChildrenCount).FirstOrDefault().ToString();

                        _disPIR.C_27_h_1 = disTypeList.Where(x => x.DisabilityType == c_27_h).Select(x => x.QualifiedChildrenCount).FirstOrDefault().ToString();
                        _disPIR.C_27_h_2 = disTypeList.Where(x => x.DisabilityType == c_27_h).Select(x => x.ServiceReceivedChildrenCount).FirstOrDefault().ToString();

                        _disPIR.C_27_i_1 = disTypeList.Where(x => x.DisabilityType == c_27_i).Select(x => x.QualifiedChildrenCount).FirstOrDefault().ToString();
                        _disPIR.C_27_i_2 = disTypeList.Where(x => x.DisabilityType == c_27_i).Select(x => x.ServiceReceivedChildrenCount).FirstOrDefault().ToString();

                        _disPIR.C_27_j_1 = disTypeList.Where(x => x.DisabilityType == c_27_j).Select(x => x.QualifiedChildrenCount).FirstOrDefault().ToString();
                        _disPIR.C_27_j_2 = disTypeList.Where(x => x.DisabilityType == c_27_j).Select(x => x.ServiceReceivedChildrenCount).FirstOrDefault().ToString();

                        _disPIR.C_27_k_1 = disTypeList.Where(x => x.DisabilityType == c_27_k).Select(x => x.QualifiedChildrenCount).FirstOrDefault().ToString();
                        _disPIR.C_27_k_2 = disTypeList.Where(x => x.DisabilityType == c_27_k).Select(x => x.ServiceReceivedChildrenCount).FirstOrDefault().ToString();

                        _disPIR.C_27_l_1 = disTypeList.Where(x => x.DisabilityType == c_27_l).Select(x => x.QualifiedChildrenCount).FirstOrDefault().ToString();
                        _disPIR.C_27_l_2 = disTypeList.Where(x => x.DisabilityType == c_27_l).Select(x => x.ServiceReceivedChildrenCount).FirstOrDefault().ToString();

                        _disPIR.C_27_m_1 = disTypeList.Where(x => x.DisabilityType == c_27_m).Select(x => x.QualifiedChildrenCount).FirstOrDefault().ToString();
                        _disPIR.C_27_m_2 = disTypeList.Where(x => x.DisabilityType == c_27_m).Select(x => x.ServiceReceivedChildrenCount).FirstOrDefault().ToString();

                        _disPIR.C_27_ChildDisabilityCount = disTypeList.Sum(x => int.Parse(x.QualifiedChildrenCount)).ToString();
                        _disPIR.C_27_ReceivedServiceCount = disTypeList.Sum(x => int.Parse(x.ServiceReceivedChildrenCount)).ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                clsError.WriteException(ex);
            }

        }

        public PIRModel GetPIR(string UserID, string AgencyID)
        {
            PIRModel _PIR = new PIRModel();

            command.Parameters.Add(new SqlParameter("@AgencyID", AgencyID));
            command.Parameters.Add(new SqlParameter("@UserID", UserID));
            command.Parameters.Add(new SqlParameter("@ProgramType", "HS"));

            command.Connection = Connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "SP_getPIR";
            DataAdapter = new SqlDataAdapter(command);
            _dataset = new DataSet();
            DataAdapter.Fill(_dataset);

            GetPIRSummary(_dataset, _PIR);
            GetDisabilityChildren(AgencyID, UserID, _PIR);
            return _PIR;

        }



    }
}
