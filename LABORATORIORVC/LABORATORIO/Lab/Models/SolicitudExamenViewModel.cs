using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAO;

namespace Lab.Models
{
    public class SolicitudExamenViewModel
    {
        public decimal Total { get; set; }
        public List<tbExamen>Examenes { get; set; }
}
}