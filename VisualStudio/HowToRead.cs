using HowToRead.Utilities;
using HowToRead.Utilities.Logger;

namespace HowToRead
{
    public class Main : MelonMod
    {
        public static ComplexLogger Logger { get; } = new();
        public override void OnInitializeMelon()
        {
            Logger.AddLevel(Utilities.Enums.FlaggedLoggingLevel.None);
            Logger.AddLevel(Utilities.Enums.FlaggedLoggingLevel.Critical);
            Logger.Log(Utilities.Enums.FlaggedLoggingLevel.Critical, "HowToRead was started, user is not reading readme's", parameters: Color.red);
        }

        // used to do things when a scene is Initialized. This is called every time this happens, so use this method NOT OnSceneWasLoaded
        public override void OnSceneWasInitialized(int buildIndex, string sceneName)
        {
            base.OnSceneWasInitialized(buildIndex, sceneName);

            if (SceneUtilities.IsScenePlayable(sceneName))
            {
                GearMessageUtilities.AddGearMessage("ico_warning", "How To Read", "You have installed the \"How To Read\" mod. This indicates that you have not read a mods readme.", 15f);
            }
        }
    }
}
