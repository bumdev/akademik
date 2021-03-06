﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;
using DAO;
using Entities;

/// <summary>
/// Summary description for CustomRetrieverDO
/// </summary>
namespace DomainObjects
{
    public class CustomRetrieverDO : UniversalDO
    {
        public UniversalEntity RetrieveDiameters()
        {
            sc = new SqlCommand("RetrieveVodomerDiameters");
            sc.CommandType = CommandType.StoredProcedure;
            CustomRetrieverDAO cDAO = new CustomRetrieverDAO();
            return cDAO.RetrieveDiameters(sc);
        }
        
        public UniversalEntity RetrieveDistricts()
        {
            sc = new SqlCommand("RetrieveDistricts");
            sc.CommandType = CommandType.StoredProcedure;
            CustomRetrieverDAO cDAO = new CustomRetrieverDAO();
            return cDAO.RetrieveDistricts(sc);
        }

        public UniversalEntity RetrieveGroups()
        {
            sc = new SqlCommand("RetrieveGroups");
            sc.CommandType = CommandType.StoredProcedure;
            CustomRetrieverDAO cDAO = new CustomRetrieverDAO();
            return cDAO.RetrieveGroups(sc);
        }

        public UniversalEntity RetrieveServices()
        {
            sc = new SqlCommand("RetrieveServices");
            sc.CommandType = CommandType.StoredProcedure;
            CustomRetrieverDAO cDAO = new CustomRetrieverDAO();
            return cDAO.RetrieveServices(sc);
        }
        public UniversalEntity RetrieveFActByOrderID5Low(int OrderID)
        {
            sc = new SqlCommand("RetrieveFActByOrderID5Low");
            sc.CommandType = CommandType.StoredProcedure;
            sc.Parameters.Add("@orderid", OrderID);
            CustomRetrieverDAO cDAO = new CustomRetrieverDAO();
            return cDAO.RetrieveFActByOrderID5Low(sc);
        }

        public UniversalEntity RetrieveWithdrawalActByOrderID5LowSpecial(int OrderID)
        {
            sc = new SqlCommand("RetrieveFActByOrderID5LowSpecial");
            sc.CommandType = CommandType.StoredProcedure;
            sc.Parameters.Add("@orderid", OrderID);
            CustomRetrieverDAO cDAO = new CustomRetrieverDAO();
            return cDAO.RetrieveWithdrawalActByOrderID5LowSpecial(sc);
        }

        public UniversalEntity RetrieveWithdrawalActBySOrderID5LowWithdrawalSpecial(int OrderID)
        {
            sc = new SqlCommand("RetrieveSActByOrderID5LowWithdrawal");
            sc.CommandType = CommandType.StoredProcedure;
            sc.Parameters.Add("@orderid", OrderID);
            CustomRetrieverDAO cDAO = new CustomRetrieverDAO();
            return cDAO.RetrieveWithdrawalActBySOrderID5LowWithdrawalSpecial(sc);
        }

        public UniversalEntity RetrieveReplacementActBySOrderID5Low(int OrderID)
        {
            sc = new SqlCommand("RetrieveReplacementActBySOrderLow");
            sc.CommandType = CommandType.StoredProcedure;
            sc.Parameters.Add("@orderid", OrderID);
            CustomRetrieverDAO cDAO = new CustomRetrieverDAO();
            return cDAO.RetrieveReplacementActBySOrderID5LowStored(sc);
        }

        public UniversalEntity RetrieveFActByOrderID5LowRub(int OrderID)
        {
            sc = new SqlCommand("RetrieveFActByOrderID5LowRub");
            sc.CommandType = CommandType.StoredProcedure;
            sc.Parameters.Add("@orderid", OrderID);
            CustomRetrieverDAO cDAO = new CustomRetrieverDAO();
            return cDAO.RetrieveFActByOrderID5LowRub(sc);
        }
        public UniversalEntity RetrieveFActByOrderID5High(int OrderID)
        {
            sc = new SqlCommand("RetrieveFActByOrderID5High");
            sc.CommandType = CommandType.StoredProcedure;
            sc.Parameters.Add("@orderid", OrderID);
            CustomRetrieverDAO cDAO = new CustomRetrieverDAO();
            return cDAO.RetrieveFActByOrderID5High(sc);
        }
        public UniversalEntity RetrieveFActByOrderID5HighRub(int OrderID)
        {
            sc = new SqlCommand("RetrieveFActByOrderID5HighRub");
            sc.CommandType = CommandType.StoredProcedure;
            sc.Parameters.Add("@orderid", OrderID);
            CustomRetrieverDAO cDAO = new CustomRetrieverDAO();
            return cDAO.RetrieveFActByOrderID5HighRub(sc);
        }
        public UniversalEntity RetrieveWithdrawalActByOrderID5HighSpecial(int OrderID)
        {
            sc = new SqlCommand("RetrieveFActByOrderID5HighSpecial");
            sc.CommandType = CommandType.StoredProcedure;
            sc.Parameters.Add("@orderid", OrderID);
            CustomRetrieverDAO cDAO = new CustomRetrieverDAO();
            return cDAO.RetrieveWithdrawalActByOrderID5High(sc);
        }

        public UniversalEntity RetrieveWithdrawalActBySOrderID5HighWithdrawalSpecial(int OrderID)
        {
            sc = new SqlCommand("RetrieveSActByOrderID5HighWithdrawal");
            sc.CommandType = CommandType.StoredProcedure;
            sc.Parameters.Add("@orderid", OrderID);
            CustomRetrieverDAO cDAO = new CustomRetrieverDAO();
            return cDAO.RetrieveWithdrawalActBySOrderID5HighWithdrawalSpecial(sc);
        }

        public UniversalEntity RetrieveReplacementActBySOrderID5High(int OrderID)
        {
            sc = new SqlCommand("RetrieveReplacementActBySOrderIDHigh");
            sc.CommandType = CommandType.StoredProcedure;
            sc.Parameters.Add("@orderid", OrderID);
            CustomRetrieverDAO cDAO = new CustomRetrieverDAO();
            return cDAO.RetrieveReplacementActBySOrderID5HighStored(sc);
        }


        public UniversalEntity RetrieveUActByOrderID5Low(int OrderID)
        {
            sc = new SqlCommand("RetrieveUActByOrderID5Low");
            sc.CommandType = CommandType.StoredProcedure;
            sc.Parameters.Add("@orderid", OrderID);
            CustomRetrieverDAO cDAO = new CustomRetrieverDAO();
            return cDAO.RetrieveFActByOrderID5Low(sc);
        }
        public UniversalEntity RetrieveUActByOrderID5LowRub(int OrderID)
        {
            sc = new SqlCommand("RetrieveUActByOrderID5LowRub");
            sc.CommandType = CommandType.StoredProcedure;
            sc.Parameters.Add("@orderid", OrderID);
            CustomRetrieverDAO cDAO = new CustomRetrieverDAO();
            return cDAO.RetrieveFActByOrderID5LowRub(sc);
        }
        public UniversalEntity RetrieveUActByOrderID5High(int OrderID)
        {
            sc = new SqlCommand("RetrieveUActByOrderID5High");
            sc.CommandType = CommandType.StoredProcedure;
            sc.Parameters.Add("@orderid", OrderID);
            CustomRetrieverDAO cDAO = new CustomRetrieverDAO();
            return cDAO.RetrieveFActByOrderID5High(sc);
        }
        public UniversalEntity RetrieveUActByOrderID5HighRub(int OrderID)
        {
            sc = new SqlCommand("RetrieveUActByOrderID5HighRub");
            sc.CommandType = CommandType.StoredProcedure;
            sc.Parameters.Add("@orderid", OrderID);
            CustomRetrieverDAO cDAO = new CustomRetrieverDAO();
            return cDAO.RetrieveFActByOrderID5HighRub(sc);
        }
        public UniversalEntity GetRateByDateAndWP(int wp,int type, DateTime sd,DateTime ed)
        {
            sc = new SqlCommand("GetRateByDateAndWP");
            sc.CommandType = CommandType.StoredProcedure;
            sc.Parameters.Add("@WPID", wp);
            sc.Parameters.Add("@type", type);
            sc.Parameters.Add("@DateLow", sd);
            sc.Parameters.Add("@DateHigh", ed);
            CustomRetrieverDAO cDAO = new CustomRetrieverDAO();
            return cDAO.GetRateByDateAndWP(sc);
        }

        public UniversalEntity RetrieveUserLocation(int id)
        {
            sc = new SqlCommand("RetrieveUserLocation");
            sc.CommandType = CommandType.StoredProcedure;
            sc.Parameters.Add("@id", id);
            CustomRetrieverDAO cDAO = new CustomRetrieverDAO();
            return cDAO.RetrieveUserLocation(sc);
        }

        public UniversalEntity RetrieveUserLocationByFOrder(int id)
        {
            sc = new SqlCommand("RetrieveUserLocationByFOrder");
            sc.CommandType = CommandType.StoredProcedure;
            sc.Parameters.Add("@id", id);
            CustomRetrieverDAO cDAO = new CustomRetrieverDAO();
            return cDAO.RetrieveUserLocationByFOrder(sc);
        }
        public UniversalEntity RetrieveUserLocationBySurname(string surname)
        {
            sc = new SqlCommand("RetrieveUserLocationBySurname");
            sc.CommandType = CommandType.StoredProcedure;
            sc.Parameters.Add("@surname", surname);
            CustomRetrieverDAO cDAO = new CustomRetrieverDAO();
            return cDAO.RetrieveUserLocationBySurname(sc);
        }


        /*
        public UniversalEntity RetrieveContractors()
        {
            sc = new SqlCommand("RetrieveContactors");
            sc.CommandType = CommandType.StoredProcedure;
            CustomRetrieverDAO cDAO = new CustomRetrieverDAO();
            return cDAO.RetrieveContractors(sc);
        }
       

        public UniversalEntity RetrieveContracts()
        {
            sc = new SqlCommand("RetrieveContracts");
            sc.CommandType = CommandType.StoredProcedure;
            CustomRetrieverDAO cDAO = new CustomRetrieverDAO();
            return cDAO.RetrieveContracts(sc);
        }

        public UniversalEntity RetrieveTransporters()
        {
            sc = new SqlCommand("RetrieveTransporters");
            sc.CommandType = CommandType.StoredProcedure;
            CustomRetrieverDAO cDAO = new CustomRetrieverDAO();
            return cDAO.RetrieveTransporters(sc);
        }

        public UniversalEntity RetrieveMarksbyName(int id, string name)
        {
            sc = new SqlCommand("RetrieveMarksByName");
            sc.CommandType = CommandType.StoredProcedure;
            sc.Parameters.Add("@ContractID", id);
            sc.Parameters.Add("@Name", name);
            CustomRetrieverDAO cDAO = new CustomRetrieverDAO();
            return (cDAO.RetrieveMarksbyName(sc));
        }*/

       
    }
}