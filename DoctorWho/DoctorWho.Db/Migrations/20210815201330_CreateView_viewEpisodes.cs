using Microsoft.EntityFrameworkCore.Migrations;

namespace DoctorWho.Db.Migrations
{
    public partial class CreateView_viewEpisodes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"CREATE VIEW viewEpisodes AS
                                   SELECT E.SeriesNumber AS Series_Number, 
	                                      E.EpisodeNumber AS Episode_Number, 
	                                      E.Title AS Title, 
	                                      A.AuthorName AS Author_Name, 
	                                      D.DoctorName AS Doctor_Name,
	                                      dbo.fnCompanions(E.EpisodeId) AS Companions,
	                                      dbo.fnEnemies(E.EpisodeId) AS Enemies

                                   FROM Episodes E
	                                            LEFT JOIN Authors A ON E.AuthorId = A.AuthorId
	                                            LEFT JOIN Doctors D ON E.DoctorId = D.DoctorId 
                                   GO");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP VIEW IF EXISTS viewEpisodes");
        }
    }
}
