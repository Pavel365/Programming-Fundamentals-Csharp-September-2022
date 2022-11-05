using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace P._05.Teamwork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();    

            InitializeTeams(teams);

            Jointeams(teams);

            PrintValidTeams(teams);

            PrintTeamToDisband (teams);
        }

        static bool TeamAlreadyExist(List<Team> teams, string teamName)
        {
            return teams.Any(t => t.Name == teamName);
        }

        static bool AraedyCreatedATeam(List<Team> teams, string creator)
        {
            return teams.Any(t => t.Creator == creator);
        }

        static void InitializeTeams(List<Team> teams)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string[] cmdArgs = Console.ReadLine()
                    .Split('-', StringSplitOptions.RemoveEmptyEntries);

                string creator = cmdArgs[0];
                string teamName = cmdArgs[1];

                if (TeamAlreadyExist(teams, teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (AraedyCreatedATeam(teams,creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else
                {
                    Team team = new Team(teamName, creator);
                    teams.Add(team);
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }
            }
        }

        static bool AlreadyAMemberOfATeam(List<Team> teams, string user)
        {
            return teams.Any(t => t.Members.Contains(user)) ||
                teams.Any(t => t.Creator == user);
        }


        static void Jointeams(List<Team> teams)
        {
            string command;
            while ((command = Console.ReadLine()) != "end of assignment")
            {
                string[] cmdArgs = command
                    .Split("->", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string user = cmdArgs[0];
                string teamName = cmdArgs[1];

                if (!TeamAlreadyExist(teams, teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (AlreadyAMemberOfATeam(teams, user))
                {
                    Console.WriteLine($"Member {user} cannot join team {teamName}!");
                }
                else
                {
                    Team teamToJoin = teams
                        .First(t => t.Name == teamName);
                    teamToJoin.AddMember(user);
                }
            }
        }

        static void PrintTeamToDisband(List<Team> teams)
        {
            List<Team> teamsToThisBand = teams
                .Where(t => t.Members.Count == 0)
                .OrderBy(t => t.Name)
                .ToList();

            Console.WriteLine("Teams to disband:");
            foreach (Team disbandTeam in teamsToThisBand)
            {
                Console.WriteLine($"{disbandTeam.Name}");
            }
        }

        static void PrintValidTeams(List<Team> teams)
        {
            List<Team> teamsWithMembers = teams
                .Where(t => t.Members.Count > 0)
                .OrderByDescending(t => t.Members.Count)
                .ThenBy(t => t.Name)
                .ToList();

            foreach (Team team in teamsWithMembers)
            {
                Console.WriteLine($"{team.Name}");
                Console.WriteLine($"- {team.Creator}");
                foreach (string member in team.Members.OrderBy(m => m))
                {
                    Console.WriteLine($"-- {member}");
                }
            }
        }
    }

    public class Team
    {
        private readonly List<string> members;
        public Team(string name, string creator)
        {
            this.Name = name;
            this.Creator = creator;

            this.members = new List<string>();
        }
        public string Name { get; private set; }
        public string Creator { get; private set; }
        public List<string> Members
            => this.members;

        public void AddMember(string memberName)
        {
            this.members.Add(memberName);
        }
    }

}
