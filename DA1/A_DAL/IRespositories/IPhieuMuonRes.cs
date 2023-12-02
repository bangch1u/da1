﻿using A_DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.IRespositories
{
    public interface IPhieuMuonRes
    {
        public string? GetPhieuMuonById(string id);
        List<PhieuMuon?> GetAllPhieuMuon(string id);
        public bool AddPhieuMuon(PhieuMuon phieuMuon);
        public bool UpdatePhieuMuon(PhieuMuon phieuMuon);
    }
}
