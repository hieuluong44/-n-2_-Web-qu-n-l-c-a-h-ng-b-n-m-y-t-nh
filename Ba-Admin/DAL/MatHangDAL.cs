﻿using DAL.Helper;
using DAL.Helper.Interfaces;
using DAL.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    public partial class MatHangDAL : IMatHangDAL
    {
        private IDatabaseHelper databaseHelper;
        public MatHangDAL(IDatabaseHelper database)
        {
            databaseHelper = database;
        }
        public List<GetMatHang> GetALL()
        {
            string msgError = "";
            try
            {
                var result = databaseHelper.ExecuteSProcedureReturnDataTable(out msgError, "Get_ALL_MatHang");
                if (!string.IsNullOrEmpty(msgError))
                {
                    throw new Exception(msgError);
                }
                return result.ConvertTo<GetMatHang>().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

        public bool Create(MatHangModel matHangModel)
        {
            try
            {
                var result = databaseHelper.ExecuteSProcedure("Them_MatHang",
                   "@IDMatHang", matHangModel.IDMatHang,
                   "@IDLoaiMatHang", matHangModel.IDLoaiMatHang,
                   "@TenMatHang", matHangModel.TenMatHang,
                    "@DonGia", matHangModel.DonGia,
                    "@BaoHanh", matHangModel.BaoHanh,
                    "@HinhAnh1", matHangModel.HinhAnh1,
                    "@TrangThai",matHangModel.TrangThai);
                if (result != null && !string.IsNullOrEmpty(result.ToString()))
                {
                    throw new Exception(result.ToString());
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Update(MatHangModel matHangModel)
        {
            try
            {
                var result = databaseHelper.ExecuteSProcedure("Sua_ThongTin_MatHang",
                     "@IDMatHang", matHangModel.IDMatHang,
                   "@IDLoaiMatHang", matHangModel.IDLoaiMatHang,
                   "@TenMatHang", matHangModel.TenMatHang,
                    "@DonGia", matHangModel.DonGia,
                    "@BaoHanh", matHangModel.BaoHanh,
                    "@HinhAnh1", matHangModel.HinhAnh1,
                    "@TrangThai", matHangModel.TrangThai);
                if (result != null && !string.IsNullOrEmpty(result.ToString()))
                {
                    throw new Exception(result.ToString());
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Delete(string IDMatHang)
        {
            try
            {
                var result = databaseHelper.ExecuteSProcedure("Xoa_MatHang",
                    "@IDMatHang", IDMatHang);
                if (result != null && !string.IsNullOrEmpty(result.ToString()))
                {
                    throw new Exception(result.ToString());
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}