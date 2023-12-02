﻿using A_DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.IRespositories
{
    public interface ISachRes
    {
        List<Sach?> getAll();
        int getCountById(string Id);
        public bool AddSach(Sach sach);
        public string? GetTenSachById(string Id);
        public bool UpdateSach(Sach sach);
    }
}
