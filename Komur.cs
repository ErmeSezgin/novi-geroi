using System;



namespace igra

{

    public class Komur : Hero

    {

        public Komur(string name) : base(name)

        {

        }



        public override int Attack()

        {

            int baseAttack = base.Attack();

            int coalDamage = 30; // Damage from thrown coal

            return baseAttack + coalDamage;

        }



        public override void TakeDamage(int incomingDamage)

        {

            base.TakeDamage(incomingDamage);

        }



        public void IgniteCoal(Hero target)

        {

            int burnDamage = 10; // Additional burn damage over time

            target.TakeDamage(burnDamage);

        }

    }

}