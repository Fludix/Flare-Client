﻿using Flare_Sharp.ClientBase.Categories;
using Flare_Sharp.Memory;
using Flare_Sharp.Memory.FlameSDK;

namespace Flare_Sharp.ClientBase.Modules.Modules
{
    public class Coordinates : Module
    {
        public Coordinates() : base("Coords", CategoryHandler.registry.categories[2], (char)0x07, false)
        {
        }

        public override void onEnable()
        {
            base.onEnable();
            byte[] write = { 0x90, 0x90, 0x90, 0x90, 0x74, 0x07 };
            MCM.writeBaseBytes(Statics.showCoordinates, write);
        }
        public override void onDisable()
        {
            base.onDisable();
            byte[] write = { 0x80, 0x78, 0x04, 0x00, 0x74, 0x07 };
            MCM.writeBaseBytes(Statics.showCoordinates, write);
        }
    }
}
