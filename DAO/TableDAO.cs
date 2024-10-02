﻿using QLQuanAn.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLQuanAn.DAO
{
    public class TableDAO
    {
        private static TableDAO instance;
        public static TableDAO Instance
        {
            get { if (instance == null) instance = new TableDAO(); return instance; }
            private set => instance = value;
        }
        public static int TableChieuRong = 90;
        public static int TableChieuDai = 90;
        private TableDAO() { }
        public List<Table> LoadTableList()
        {
            List<Table> list = new List<Table>();
            DataTable data =  DataProvider.Instance.ExcuteQuery("USP_GetTableList");
            foreach (DataRow row in data.Rows) { 
                Table table = new Table(row);
                list.Add(table);
            }
            return list;
        }
    }
}
