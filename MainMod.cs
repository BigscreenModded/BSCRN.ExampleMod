using MelonLoader;

namespace BSCRN.ExampleMod
{
    // The main mod class, most of the core hooks,
    // such as ApplicationStart, Update and other
    // stuff are automatically handled by MelonLoader.
    public class MainMod : MelonMod
    {
        // Will run after all mods are loaded.
        public override void OnApplicationStart()
        {
            // Logs to modloader console (Console.WriteLine() doesn't work in mods!)
            LoggerInstance.Msg("Hello World from OnApplicationStart");
        }

        public override void OnUpdate()
        {
            // If the X button was pressed down on an Oculus Quest 1/2 controller this frame, run this:
            // Note: This would probably only work on the Oculus Store version of the game.
            // Checkout the SteamVR documentation for the Steam version
            // of the game, or use keyboard keys instead.
            if(OVRInput.GetDown(OVRInput.RawButton.X))
            {
                LoggerInstance.Msg("X was pressed! Neat :)");
            }
        }
    }
}
