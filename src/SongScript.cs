using RWF;
using RWF.Swagshit.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rwf_sighting
{
    public class SightingSongScript : SongScript
    {

        private List<float> events_time = new()
        {
            17903f,
            52663f,
            64024f,
            75385f,

        };
        private List<float> events_scrollspeed = new()
        {
            1.2f,
            0.8f,
            1.1f,
            1.2f,

        };

        public void onCameraUpdate(CameraMoveEvent e)
        {
            e.cancelled = true;
            e.position = new(680, 350);
        }

        public void onCreatePost()
        {
            FunkinMenu.instance.dad.sprite.isVisible = FunkinMenu.instance.hpIconP1.sprite.isVisible = false;
        }

        public void onUpdatePost()
        {
            if (Conductor.songPosition > 4645 && !FunkinMenu.instance.dad.sprite.isVisible && !FunkinMenu.instance.hpIconP1.sprite.isVisible)
            {
                FunkinMenu.instance.dad.sprite.isVisible = FunkinMenu.instance.hpIconP1.sprite.isVisible = true;
            }

            if (events_time.Count > 0 && events_time[0] < Conductor.songPosition)
            {
                FunkinMenu.instance.noteSpeed = 2.8f * events_scrollspeed[0];

                events_time.RemoveAt(0);
                events_scrollspeed.RemoveAt(0);

            }
        }

        public void oNNoteHit(NoteEvent e)
        {
            if (!e.Note.mustPress)
            {
                var healthLoss = 0.023f;

                if (FunkinMenu.instance.health > healthLoss * 2) FunkinMenu.instance.health -= healthLoss;
            }
        }

    }
}
