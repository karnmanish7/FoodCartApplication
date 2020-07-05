using CrikAnalyser.Service.Models;
using CrikAnalyser.Service.Repositories;
using CrikAnalyser.Service.Services;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace test
{
    [TestFixture]
    public class CricketMatchRepositoryTest
    {
        readonly CricketMatchRepository repository;
        readonly ScoreBoardService service;
        public CricketMatchRepositoryTest()
        {
            repository = new CricketMatchRepository(new CricketMatchResults());
            service = new ScoreBoardService(repository);

            List<CricketMatch> results = new List<CricketMatch>
            {
                new CricketMatch
                {
                    Team = "SA",
                    RunsScored = 250,
                    WicketsTaken = 7,
                    Result = "Lost By 10 Runs",
                    Venue = "Mumbai"
                },
                new CricketMatch
                {
                    Team = "Pakistan",
                    RunsScored = 350,
                    WicketsTaken = 7,
                    Result = "Won By 5 Wickets",
                    Venue = "Delhi"
                },
                new CricketMatch
                {
                    Team = "England",
                    RunsScored = 220,
                    WicketsTaken = 3,
                    Result = "Won By 10 Runs",
                    Venue = "Bangaluru"
                },
                new CricketMatch
                {
                    Team = "West Indies",
                    RunsScored = 280,
                    WicketsTaken = 4,
                    Result = "Lost By 20 Runs",
                    Venue = "Chandigarh"
                },
                new CricketMatch
                {
                    Team = "Australia",
                    RunsScored = 310,
                    WicketsTaken = 7,
                    Result = "Won By 1 Run",
                    Venue = "Mumbai"
                }
            };

            repository.AddResults(results);
        }

        [TestCase("SA", ExpectedResult = "Lost By 10 Runs")]
        [TestCase("Pakistan", ExpectedResult = "Won By 5 Wickets")]
        public string ShouldGetResultByTeam(string opponent)
        {
            var (_, _, _, result, _) = repository.GetResults()[opponent];

            return result;
        }

        [TestCase("West Indies", ExpectedResult = "Chandigarh")]
        [TestCase("England", ExpectedResult = "Bangaluru")]
        public string ShouldGetVenue(string opponent)
        {

            var (_, _, _, _, venue) = repository.GetResults()[opponent];

            return venue;
        }

        [Test]
        public void ShouldCalculateScoreStatisticsReturnDelegate()
        {
            var result = service.GenerateStatistics(true, false);
            result();
            Assert.That(result, Is.TypeOf<ScoreBoardAnalyser>());
        }

        [Test]
        public void ShouldGetRunsAnalysis()
        {
            var result = service.GenerateStatistics(true, false);
            result();

            Assert.That(service.RunsSummary.count, Is.EqualTo(5));
            Assert.That(service.RunsSummary.total, Is.EqualTo(1410));
            Assert.That(service.RunsSummary.max, Is.EqualTo(350));
            Assert.That(service.RunsSummary.min, Is.EqualTo(220));
            Assert.That(service.RunsSummary.avg, Is.EqualTo(282));
        }

        [Test]
        public void ShouldGetWicketsAnalysis()
        {
            var result = service.GenerateStatistics(false, true);
            result();
            Assert.That(service.WicketsSummary.count, Is.EqualTo(5));
            Assert.That(service.WicketsSummary.total, Is.EqualTo(28));
            Assert.That(service.WicketsSummary.max, Is.EqualTo(7));
            Assert.That(service.WicketsSummary.min, Is.EqualTo(3));
            Assert.That(service.WicketsSummary.avg, Is.EqualTo(5.6));
        }

        [Test]
        public void ShouldGetRunsAndWicketsAnalysis()
        {
            var result = service.GenerateStatistics(true, true);
            result();
            Assert.That(service.RunsSummary.count, Is.EqualTo(5));
            Assert.That(service.RunsSummary.total, Is.EqualTo(1410));
            Assert.That(service.RunsSummary.max, Is.EqualTo(350));
            Assert.That(service.RunsSummary.min, Is.EqualTo(220));
            Assert.That(service.RunsSummary.avg, Is.EqualTo(282));

            Assert.That(service.WicketsSummary.count, Is.EqualTo(5));
            Assert.That(service.WicketsSummary.total, Is.EqualTo(28));
            Assert.That(service.WicketsSummary.max, Is.EqualTo(7));
            Assert.That(service.WicketsSummary.min, Is.EqualTo(3));
            Assert.That(service.WicketsSummary.avg, Is.EqualTo(5.6));
        }

        [Test]
        public void ShouldGetListOfLosingOpponents()
        {
            List<string> teams = new List<string>();
            repository.GetMatchDetails(m =>
            {
                if (m.Result.Contains("Won"))
                    teams.Add(m.Team);
            });

            Assert.That(teams, Does.Contain("Pakistan"));
        }

        [Test]
        public void ShouldGetListOfWinningOpponents()
        {
            List<string> teams = new List<string>();
            repository.GetMatchDetails(m =>
            {
                if (m.Result.Contains("Lost"))
                    teams.Add(m.Team);
            });

            Assert.That(teams, Does.Contain("SA"));
            Assert.That(teams, Does.Contain("West Indies"));
        }

    }
}
