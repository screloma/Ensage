﻿namespace GoldSpender
{
    using System.Linq;

    using Ensage;
    using Ensage.Common;

    internal class GoldSpender
    {
        #region Public Methods and Operators

        public void OnUpdate()
        {
            if (!Utils.SleepCheck("GoldSpender.Sleep"))
            {
                return;
            }

            Utils.Sleep(200 + Game.Ping, "GoldSpender.Sleep");

            if (Game.IsPaused || !Variables.Hero.IsAlive)
            {
                return;
            }

            var module = Variables.Modules.FirstOrDefault(x => x.ShouldSpendGold());
            module?.BuyItems();
        }

        #endregion
    }
}