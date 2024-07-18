using System;
using BepInEx;
using UnityEngine;
using RWF;
using RWF.Swagshit;
using System.IO;
using System.Collections.Generic;
using RWF.FNFJSON;
using System.Linq;
using System.Collections;
using System.Runtime.InteropServices;
using Rewired.UI.ControlMapper;

namespace faznews_mewmix
{
    [BepInPlugin(MOD_ID, "RWF: SIGHTING", "1.0.0")]
    class Plugin : BaseUnityPlugin
    {
        private const string MOD_ID = "silky.rwf.sighting.herobrine.silkyver";

        // Add hooks
        public void OnEnable()
        {

            Debug.Log("RWF: SIGHITNG: PLUGIN LOADED ENABLED");

            On.RainWorld.OnModsInit += Extras.WrapInit(LoadResources);

        }

        /*

        private void FunkinMenu_UpdateCameraTarget(FunkinMenu self)
        {

            if (self.SONG.Name != "brine") return;

            self.cameraTarget = new(680, 350);

        }

        private void FunkinMenu_OnCreate(FunkinMenu self)
        {
            if (self.SONG.Name != "brine") return;

            events_time = new()
            {
                17903f,
                52663f,
                64024f,
                75385f,

            };
            events_scrollspeed = new()
            {
                1.2f,
                0.8f,
                1.1f,
                1.2f,

            };

            self.dad.sprite.isVisible = self.hpIconP1.sprite.isVisible = false;

    }

        private void FunkinMenu_OnUpdatePost(FunkinMenu self)
        {
            if (self.SONG.Name != "brine") return;

            if (Conductor.songPosition > 4645 && !self.dad.sprite.isVisible && !self.hpIconP1.sprite.isVisible)
            {
                self.dad.sprite.isVisible = self.hpIconP1.sprite.isVisible = true;
            }

            if (events_time.Count > 0 && events_time[0] < Conductor.songPosition)
            {
                self.noteSpeed = 2.8f * events_scrollspeed[0];

                events_time.RemoveAt(0);
                events_scrollspeed.RemoveAt(0);

            }

        }

        private void FunkinMenu_OnEnemyHit(FunkinMenu self, RWF.Swagshit.Note daNote)
        {

            var healthLoss = 0.023f;

            if (self.SONG.Name != "brine") return;
            if (self.health > healthLoss * 2) self.health -= healthLoss;
        }

        */

        // Load any resources, such as sprites or sounds
        private void LoadResources(RainWorld rainWorld)
        {
            //Futile.atlasManager.LogAllElementNames();
            Futile.atlasManager.LoadImage("funkin/images/sh_e05");

            RWF_Plugin.songsMetaData.Add("brine", new("rwf_sighting.SightingSongScript", "SIGHTING", 9));
        }
        
    }
}