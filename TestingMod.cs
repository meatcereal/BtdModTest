using MelonLoader;
using BTD_Mod_Helper;
using TestingMod;

[assembly: MelonInfo(typeof(TestingMod.TestingMod), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace TestingMod;

public class TestingMod : BloonsTD6Mod
{
    public override void OnApplicationStart()
    {
        ModHelper.Msg<TestingMod>("TestingMod loaded!");
    }
}