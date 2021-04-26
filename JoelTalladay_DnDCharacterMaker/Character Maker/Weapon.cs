using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Maker
{
    class Weapon
    {
        public int bonDam;
        public int attackBon;
        public int diceNum;
        public int rolledDamage;
        public int rolledAttack;
        public bool noWeapon;

        public void doAttack()
        {
            Random random = new Random();
            if(noWeapon)
            {
                rolledAttack = random.Next(1, 21) + attackBon;
                rolledDamage = 1 + bonDam;
                System.Windows.Forms.MessageBox.Show("To Hit: " + rolledAttack + "\n" + "Damage on Hit: " + rolledDamage, "Attack");
            }
            else
            {
                rolledAttack = random.Next(1, 21) + attackBon;
                rolledDamage = random.Next(1, (diceNum + 1)) + bonDam;
                System.Windows.Forms.MessageBox.Show("To Hit: " + rolledAttack + "\n" + "Damage on Hit: " + rolledDamage, "Attack");
            }
        }
    }
}
