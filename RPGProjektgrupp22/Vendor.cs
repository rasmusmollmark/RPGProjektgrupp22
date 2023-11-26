using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGProjektgrupp22
{
    public interface Vendor
    {
        string Name { get; }


        public void AddLore();

        public void GenerateInventory();

        public void TellGossip();

        public void TellWelcome();

        public void GreetPlayer();

        public void OptionForPlayerMeeting();

        public void SellItems(Player player);

        public void BuyItems(Player player);





    }
}
