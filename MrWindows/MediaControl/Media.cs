﻿using MrWindows.KeyboardControl;

namespace MrWindows.MediaControl {
    public class Media {
        public void VolumeUp() {
            new Keyboard().Type(VirtualKey.VolumeUp);
        }

        public void VolumeDown() {
            new Keyboard().Type(VirtualKey.VolumeDown);
        }

        public void VolumeMute() {
            new Keyboard().Type(VirtualKey.VolumeMute);
        }
    }
}