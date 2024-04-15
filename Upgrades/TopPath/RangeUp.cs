using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingMod.Upgrades.TopPath
{
    internal class RangeUp : ModUpgrade<TestMonkey>
    {
        public override int Path => TOP;
        public override int Tier => 1;
        public override int Cost => 300;

        public override string Description => "This adds range... as a test!";
        public override void ApplyUpgrade(TowerModel towerModel)
        {
            towerModel.range += 10;
        }
    }
}
