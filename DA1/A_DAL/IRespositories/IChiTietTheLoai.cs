﻿using A_DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.IRespositories
{
    public interface IChiTietTheLoai
    {
        public string? GetTheLoaiByID(string id);
        public bool AddTLCT(ChiTietTheLoai chiTietTheLoai);
    }
}
