using System;



namespace igra

{

    public class MorganFreeman : Hero

    {

        private bool invisible;



        public MorganFreeman(string name) : base(name)

        {

            invisible = false;

        }



        public override int Attack()

        {

            int baseAttack = 40; 

            return baseAttack;

        }



        public override void TakeDamage(int incomingDamage)

        {

            if (invisible)

            {

                incomingDamage = 0; 

                invisible = false; 

            }

            base.TakeDamage(incomingDamage);

        }



        public void BecomeInvisible()

        {

            invisible = true;

        }

    }

}