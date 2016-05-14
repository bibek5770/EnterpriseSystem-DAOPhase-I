﻿using System;

namespace EnterpriseSystems.Infrastructure.Model.Entities
{
    public class AppointmentVO
    {
        public AppointmentVO()
        {
            this.CreatedDate = DateTime.UtcNow;
            this.LastUpdatedDate = DateTime.UtcNow;
            this.Status = "PENDING";
        }
        public int Identity { get; set; }
        public string EntityName { get; set; }
        public int EntityIdentity { get; set; }

        public int SequenceNumber { get; set; }
        public string FunctionType { get; set; }
        public DateTime? AppointmentBegin { get; set; }
        public DateTime? AppointmentEnd{ get; set; }
        public string TimezoneDescription { get; set; }      



        public string Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedUserId { get; set; }
        public string CreatedProgramCode { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public string LastUpdatedUserId { get; set; }
        public string LastUpdatedProgramCode { get; set; }


    }
}
