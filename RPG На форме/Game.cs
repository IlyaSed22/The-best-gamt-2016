using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class Game
    {
        public List<Hero> YourTeam;
        public List<Hero> EnemyTeam;
        public Game()
        {
            YourTeam = new List<Hero>();
            EnemyTeam = new List<Hero>();
            
        }
        public void AddPersonage( Hero jj)
        {
            YourTeam.Add(jj);
        }
        public void AddEnemy(Hero jj)
        {
            EnemyTeam.Add(jj);
        }
        public void Attack(Hero DAMGER, Hero PRINIMATEL)
        {
            DAMGER.Attack(PRINIMATEL);
        }
    }
}
