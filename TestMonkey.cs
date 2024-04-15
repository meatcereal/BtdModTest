using BTD_Mod_Helper.Api.Enums;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.TowerSets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingMod
{
    public class TestMonkey : ModTower
    {
        public override TowerSet TowerSet => TowerSet.Magic;
        public override string BaseTower => TowerType.Alchemist;
        public override int Cost => 500;

        public override int TopPathUpgrades => 1;
        public override int MiddlePathUpgrades => 0;
        public override int BottomPathUpgrades => 0;
        public override string Description => "This is a test monkey! Or a monkey that does tests?";

        public override void ModifyBaseTowerModel(TowerModel towerModel)
        {
            
        }
    }
}
