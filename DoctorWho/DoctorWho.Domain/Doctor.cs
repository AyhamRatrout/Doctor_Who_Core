using System;
using System.Collections.Generic;

namespace DoctorWho.Domain
{
    public class Doctor
    {
        public Doctor()
        {
            this.Episodes = new List<Episode>();
        }
        public Doctor(DoctorIdEnum DoctorId, int DoctorNumber, string DoctorName, DateTime? BirthDate, DateTime? FirstEpisodeDate, DateTime? LastEpisodeDate) : this()
        {
            this.DoctorId = DoctorId;
            this.DoctorNumber = DoctorNumber;
            this.DoctorName = DoctorName;
            this.BirthDate = BirthDate;
            this.FirstEpisodeDate = FirstEpisodeDate;
            this.LastEpisodeDate = LastEpisodeDate;
        }
        public DoctorIdEnum DoctorId { get; set; }

        public int DoctorNumber { get; set; }

        public string DoctorName { get; set; }

        public DateTime? BirthDate { get; set; }

        public DateTime? FirstEpisodeDate { get; set; }

        public DateTime? LastEpisodeDate { get; set; }

        public List<Episode> Episodes { get; set; }
    }
}
