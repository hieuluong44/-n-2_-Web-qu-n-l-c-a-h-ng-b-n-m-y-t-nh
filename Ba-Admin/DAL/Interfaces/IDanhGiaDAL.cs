﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL.Interfaces
{
    public interface IDanhGiaDAL
    {
        List<GetDanhGia> GetALL();
        bool Delete(string IDDanhGia);
    }
}