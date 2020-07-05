using CrikAnalyser.Service.Models;
using CrikAnalyser.Service.Repositories;
using CrikAnalyser.Service.Services;
using NUnit.Framework;
using System.Collections.Generic;

namespace test
{
    [TestFixture]
    public class CricketMatchRepositoryTest
    {
        readonly CricketMatchRepository repository;
        readonly ScoreBoardManager manager;

        public CricketMatchRepositoryTest()
        {
            repository = new CricketMatchRepository(new CricketMatchResults());
            manager = new ScoreBoardManager(repository);

            List<CricketMatch> matches = new List<CricketMatch>
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

            repository.AddResults(matches);
        }

        [TestCase("SA", ExpectedResult = "Lost By 10 Runs")]
        [TestCase("Pakistan", ExpectedResult = "Won By 5 Wickets")]
        public string ShouldGetResultByTeam(string opponent)
        {
            var (team, _, _, result, _) = repository.GetResultDetails(opponent);

            return result;
        }

        [TestCase("West Indies", ExpectedResult = "Chandigarh")]
        [TestCase("England", ExpectedResult = "Bangaluru")]
        public string ShouldGetVenu(string opponent)
        {
            var (_, _, _, _, venue) = repository.GetResultDetails(opponent);

            return venue;
        }


        [Test]
        public void ShouldGetRunsAnalysis()
        {
            var result = manager.GetRunsAnalysis();

            Assert.That(result.count, Is.EqualTo(5));
            Assert.That(result.totalRuns, Is.EqualTo(1410));
            Assert.That(result.maxRuns, Is.EqualTo(350));
            Assert.That(result.minRuns, Is.EqualTo(220));
            Assert.That(result.avgRuns, Is.EqualTo(282));
        }

        [Test]
        public void ShouldGetWicketsAnalysis()
        {
            manager.GetWicketsAnalysis(out int count, out int totalWickets, out int maxWickets, out int minWickets, out double avgWickets);

            Assert.That(count, Is.EqualTo(5));
            Assert.That(totalWickets, Is.EqualTo(28));
            Assert.That(maxWickets, Is.EqualTo(7));
            Assert.That(minWickets, Is.EqualTo(3));
            Assert.That(avgWickets, Is.EqualTo(5.6));
        }
    }
}
