using BepInEx;
using System;
using UnityEngine;
using Utilla;

namespace anticrash
{
    /// <summary>
    /// This is your mod's main class.
    /// </summary>

    /* This attribute tells Utilla to look for [ModdedGameJoin] and [ModdedGameLeave] */
    [ModdedGamemode]
    [BepInDependency("org.legoandmars.gorillatag.utilla", "1.5.0")]
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class Plugin : BaseUnityPlugin
    {
        bool inRoom;
        static bool WantsToQuit()
        {
            Debug.Log("Stinky cheater I prevented kick :)");
            return false;
        }

        void Start()
        {
            /* A lot of Gorilla Tag systems will not be set up when start is called /*
			/* Put code in OnGameInitialized to avoid null references */

            Utilla.Events.GameInitialized += OnGameInitialized;
            Application.wantsToQuit += WantsToQuit;
        }
        void OnGameInitialized(object sender, EventArgs e)
        {

        }
    }
}
