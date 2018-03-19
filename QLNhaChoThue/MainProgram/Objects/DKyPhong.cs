using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProgram.Objects
{
    class DKyPhong           //Đối tượng class biểu diễn cho bảng quan hệ Đăng ký phòng
    {
        private string mahdp;           //Mã hợp đồng thuê phòng
        private string makhach;         //Mã khách đăng ký
        private string maphong;         //Mã phòng
        private int songuoi;            //Số người ở
        private string ngaythue;        //Ngày thuê phòng
        private string ngaytra;         //Ngày trả phòng
        private int datcoc;             //Tiền đặt cọc
        private string htthanhtoan;     //Hình thức thanh toán

        public string Mahdp
        {
            get
            {
                return mahdp;
            }
            set
            {
                mahdp = value;
            }
        }
        public string Makhach
        {
            get
            {
                return makhach;
            }
            set
            {
                makhach = value;
            }
        }
        public string Maphong
        {
            get
            {
                return maphong;
            }
            set
            {
                maphong = value;
            }
        }
        public int Songuoi
        {
            get
            {
                return songuoi;
            }
            set
            {
                songuoi = value;
            }
        }
        public string Ngaythue
        {
            get
            {
                return ngaythue;
            }
            set
            {
                ngaythue = value;
            }
        }
        public string Ngaytra
        {
            get
            {
                return ngaytra;
            }
            set
            {
                ngaytra = value;
            }
        }
        public int Datcoc
        {
            get
            {
                return datcoc;
            }
            set
            {
                datcoc = value;
            }
        }
        public string Htthanhtoan
        {
            get
            {
                return htthanhtoan;
            }
            set
            {
                htthanhtoan = value;
            }
        }
    }
}
