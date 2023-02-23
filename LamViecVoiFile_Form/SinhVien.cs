﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class SinhVien
    {
        private string name;
        private int mssv;
        private DIEM diem;
        private double gpa;

        public SinhVien()
        {
            //throw new System.NotImplementedException();
            name = "NULL";
            mssv = 0;
            diem = new DIEM(0, 0, 0);
            gpa = diem.TinhDTB();
        }
        public string Name
        {
            get => name;
            set
            {
                name = value;
            }
        }
        public int Mssv
        {
            get => mssv;
            set
            {
                mssv = value;
            }
        }
        public DIEM Diem
        {
            get => diem;
            set
            {
                diem = value;
            }
        }
        public double Gpa
        {
            get => diem.TinhDTB();
        }
        public static string ToStringGpa(double grade)
        {
            return ($"{grade:F2}");
        }
    }
}
