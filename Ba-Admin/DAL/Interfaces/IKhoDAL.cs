﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Model;


namespace DAL.Interfaces
{
    public partial interface IKhoDAL
    {
        List<GetKho> GetALL();
        bool Create(KhoModel khoModel);
        bool Update(KhoModel khoModel);
        bool Delete(string IDKho);
        GetKho Search_ID(string IDMatHang);
        List<GetKho> Search_Name(string TenMatHang);
    }
}
