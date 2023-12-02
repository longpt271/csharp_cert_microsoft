using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Solution {
    public class Team {
        public string teamName;
        public int noOfPlayers;
        
        // start
        public Team() {}
        
        public Team(string name, int num)
        {
            teamName = name;
            noOfPlayers = num;
        }
        
        public void AddPlayer(int count)
        {
            noOfPlayers += count;
        }
        
        public bool RemovePlayer(int count)
        {
            noOfPlayers -= count;
            if (noOfPlayers < 0)
                return false;
            return true;
        }
        
    }

    public class Subteam: Team
    {
        public Subteam(string name, int num)
        {
            teamName = name;
            noOfPlayers = num;
        }
        
        public void ChangeTeamName(string name)
        {
            teamName = name;
        }
    }
    // end

    class Solution {
         static void Main(string[] args) {

            if (!typeof(Subteam).IsSubclassOf(typeof(Team))) {
                throw new Exception("Subteam class should inherit from Team class");
            }
            
            String str = Console.ReadLine();
            String[] strArr = str.Split();
            string initialName = strArr[0];
            int count = Convert.ToInt32(strArr[1]);
            Subteam teamObj = new Subteam(initialName, count);
            Console.WriteLine("Team " + teamObj.teamName + " created");
            
            str = Console.ReadLine();
            count = Convert.ToInt32(str);
            Console.WriteLine("Current number of players in team " + teamObj.teamName + " is " + teamObj.noOfPlayers);
            teamObj.AddPlayer(count);
            Console.WriteLine("New number of players in team " + teamObj.teamName + " is " + teamObj.noOfPlayers);
            
            
            str = Console.ReadLine();
            count = Convert.ToInt32(str);
            Console.WriteLine("Current number of players in team " + teamObj.teamName + " is " + teamObj.noOfPlayers);
            var res = teamObj.RemovePlayer(count);
            if (res) {
                Console.WriteLine("New number of players in team " + teamObj.teamName + " is " + teamObj.noOfPlayers);
            } else {
                Console.WriteLine("Number of players in team " + teamObj.teamName + " remains same");
            }
            
            str = Console.ReadLine();
            teamObj.ChangeTeamName(str);
            Console.WriteLine("Team name of team " + initialName + " changed to " + teamObj.teamName);
        }
    }
}