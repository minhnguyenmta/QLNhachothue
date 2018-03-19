using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProgram.Objects
{
    class Khach          //Đối tượng class biểu diễn cho thực thể Khách
    {
        private string makhach;       //Mã khách
        private string hoten;         //Họ và tên khách
        private int namsinh;          //Năm sinh
        private bool gioitinh;        //Giới tính
        private string cmnd;          //Số CMND của khách
        private string quequan;       //Quê quán
        private string sdt;           //Số điện thoại của khách

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
        public string Hoten
        {
            get
            {
                return hoten;
            }
            set
            {
                hoten = value;
            }
        }
        public int Namsinh
        {
            get
            {
                return namsinh;
            }
            set
            {
                namsinh = value;
            }
        }
        public bool Gioitinh
        {
            get
            {
                return gioitinh;
            }
            set
            {
                gioitinh = value;
            }
        }
        public string Cmnd
        {
            get
            {
                return cmnd;
            }
            set
            {
                cmnd = value;
            }
        }
        public string Quequan
        {
            get
            {
                return quequan;
            }
            set
            {
                quequan = value;
            }
        }
        public string Sdt
        {
            get
            {
                return sdt;
            }
            set
            {
                sdt = value;
            }
        }
    }
}
