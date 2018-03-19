using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProgram.Objects
{
    class Phong            //Đối tượng class biểu diễn cho thực thể Phòng
    {
        private string maphong;       //Mã phòng
        private int dientich;         //Diện tích phòng
        private string loai;          //Loại phòng
        private string tinhtrang;     //Tình trạng
        private int gia;              //Giá phòng
        private string dodac;         //Đồ đạc có sẵn

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
        public int Dientich
        {
            get
            {
                return dientich;
            }
            set
            {
                dientich = value;
            }
        }
        public string Loai
        {
            get
            {
                return loai;
            }
            set
            {
                loai = value;
            }
        }
        public string Tinhtrang
        {
            get
            {
                return tinhtrang;
            }
            set
            {
                tinhtrang = value;
            }
        }
        public int Gia
        {
            get
            {
                return gia;
            }
            set
            {
                gia = value;
            }
        }
        public string Dodac
        {
            get
            {
                return dodac;
            }
            set
            {
                dodac = value;
            }
        }
    }
}
