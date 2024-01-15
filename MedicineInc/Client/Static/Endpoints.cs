using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicineInc.Client.Static
{
    public static class Endpoints
    {
        private static readonly string Prefix = "api";

        public static readonly string MedicinesEndPoint = $"{Prefix}/medicines";
        public static readonly string StaffsEndPoint = $"{Prefix}/staffs";
        public static readonly string BranchesEndPoint = $"{Prefix}/branches";
        public static readonly string OrdersEndPoint = $"{Prefix}/orders";
        public static readonly string CustomersEndPoint = $"{Prefix}/customers";
    }
}
