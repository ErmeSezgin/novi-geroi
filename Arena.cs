using igra;
using System;

using System.Collections.Generic;



namespace igra

{

    public class Arena

    {

        public List<Hero> Heroes { get; private set; }



        public GameEventListener EventListener { get; set; }



        public Arena(params Hero[] heroes)

        {

            Heroes = new List<Hero>(heroes);

        }



        public Hero Battle()

        {

            while (Heroes.Count > 1)

            {

                for (int i = 0; i < Heroes.Count; i++)

                {

                    Hero attacker = Heroes[i];

                    Hero defender = Heroes[(i + 1) % Heroes.Count];



                    int damage = attacker.Attack();

                    defender.TakeDamage(damage);



                    if (EventListener != null)

                    {

                        EventListener.GameRound(attacker, defender, damage);

                    }



                    if (defender.IsDead)

                    {

                        Heroes.Remove(defender);

                        i--; // Adjust index after removal

                    }



                    if (Heroes.Count == 1)

                    {

                        break;

                    }

                }

            }



            return Heroes[0]; // The last remaining hero is the winner

        }

    }

}