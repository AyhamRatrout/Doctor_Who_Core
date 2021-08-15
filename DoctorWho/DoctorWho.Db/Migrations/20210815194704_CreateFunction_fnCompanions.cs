using Microsoft.EntityFrameworkCore.Migrations;

namespace DoctorWho.Db.Migrations
{
    public partial class CreateFunction_fnCompanions : Migration
    {
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.Sql(@"CREATE FUNCTION fnRetrieveListOfCompanionIds (@EpisodeId INT)
	                               RETURNS TABLE AS
                                   RETURN
										SELECT DISTINCT CompanionId
										FROM EpisodeCompanions EC
										WHERE @EpisodeId = EC.EpisodeId
								   GO

                                   CREATE FUNCTION fnRetrieveListOfCompanionNames (@EpisodeId INT)
                                   RETURNS TABLE AS
                                   RETURN
										SELECT DISTINCT CompanionName
										FROM Companions C JOIN fnRetrieveListOfCompanionIds(@EpisodeId) fn 
										ON C.CompanionId = fn.CompanionId
                                   GO

                                   CREATE FUNCTION fnRetrieveCompanions (@EpisodeId INT)
                                   RETURNS VARCHAR(MAX) AS
                                   BEGIN
										DECLARE @List_Of_Companions AS VARCHAR(MAX)
										DECLARE @name AS VARCHAR(MAX)
										DECLARE companion_cursor CURSOR FOR 
																			SELECT * FROM fnRetrieveListOfCompanionNames(@EpisodeId)

										OPEN companion_cursor
										FETCH NEXT FROM companion_cursor
										INTO @name

										WHILE @@FETCH_STATUS = 0
											BEGIN
											SET @List_Of_Companions = CONCAT(@List_Of_Companions, ', ', @name)

											FETCH NEXT FROM companion_cursor
											INTO @name
										END

										CLOSE companion_cursor
										DEALLOCATE companion_cursor
										RETURN @List_Of_Companions
								   END;
                                   GO

                                   CREATE FUNCTION fnCompanions (@EpisodeId INT)
                                   RETURNS VARCHAR(MAX) AS
                                   BEGIN
										DECLARE @Max_Episode_Id AS INT
										SET @Max_Episode_Id = (SELECT MAX(EpisodeId) FROM Episodes)
										DECLARE @result AS VARCHAR(MAX)

										IF @EpisodeId <= 0 OR @EpisodeId > @Max_Episode_Id
											BEGIN
												SET @result = 'Invalid Episode Id! No Episodes exist for the Episode Id you have entered...'
											END

										ELSE
											BEGIN
												SET @result = SUBSTRING(dbo.fnRetrieveCompanions(@EpisodeId), 3, LEN(dbo.fnRetrieveCompanions(@EpisodeId)) - 2)
											END

										RETURN (CASE WHEN LEN(@result) > 0 THEN @result 
										ELSE 'No companions appear on this episode' END);
                                   END;
                                   GO");
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.Sql(@"DROP FUNCTION IF EXISTS fnRetrieveListOfCompanionIds;
                                   DROP FUNCTION IF EXISTS fnRetrieveListOfCompanionNames;
                                   DROP FUNCTION IF EXISTS fnRetrieveCompanions;
                                   DROP FUNCTION IF EXISTS fnCompanions;");
		}
	}
}
