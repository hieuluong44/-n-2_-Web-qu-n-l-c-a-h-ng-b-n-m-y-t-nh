﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL.Interfaces
{
    public interface IMatHangDAL
    {
        List<Get_MatHang_DanhMuc> get_MatHang_DanhMuc();
        List<List_MatHang> list_MatHang();
        List<Tim_MatHang_Gia> tim_MatHang_Gia(float GiaMin, float GiaMax);
    }
}
