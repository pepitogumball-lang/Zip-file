using Modding;

namespace InfiniteCharmsMod
{
    public class InfiniteCharmsMod : Mod
    {
        public override string GetVersion() => "1.0.0";

        public override void Initialize()
        {
            Log("InfiniteCharmsMod loaded.");
            ModHooks.GetPlayerIntHook += OnGetPlayerInt;
        }

        private int OnGetPlayerInt(string name, int orig)
        {
            // Hollow Knight stores available notches in the player data field "charmSlots".
            // Returning a large number here lets the game think you have plenty of slots,
            // while still requiring you to own the charms normally.
            if (name == "charmSlots")
                return 99;

            return orig;
        }
    }
}
