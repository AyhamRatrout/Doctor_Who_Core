using System;
using System.Collections.Generic;

namespace DoctorWho.Domain
{
    public class Episode
    {
        public Episode()
        {
            this.EpisodeCompanions = new List<EpisodeCompanion>();
            this.EpisodeEnemies = new List<EpisodeEnemy>();
        }
        public Episode(int? SeriesNumber, int? EpisodeNumber, string EpisodeType, string Title, DateTime? EpisodeDate, int AuthorId, DoctorIdEnum DoctorId, string Notes) : this()
        {
            this.SeriesNumber = SeriesNumber;
            this.EpisodeNumber = EpisodeNumber;
            this.EpisodeType = EpisodeType;
            this.Title = Title;
            this.EpisodeDate = EpisodeDate;
            this.AuthorId = AuthorId;
            this.DoctorId = DoctorId;
            this.Notes = Notes;
        }
        public int EpisodeId { get; set; }

        public int? SeriesNumber { get; set; }

        public int? EpisodeNumber { get; set; }

        public string EpisodeType { get; set; }

        public string Title { get; set; }

        public DateTime? EpisodeDate { get; set; }

        public int AuthorId { get; set; }

        public DoctorIdEnum DoctorId { get; set; }

        public string Notes { get; set; }
        public List<EpisodeCompanion> EpisodeCompanions { get; set; }
        public List<EpisodeEnemy> EpisodeEnemies { get; set; }
    }
}
