﻿using System;
using NextGenSoftware.OASIS.API.Core.Holons;
using NextGenSoftware.OASIS.API.Core.Enums;
using NextGenSoftware.OASIS.API.Core.Interfaces.STAR;
using NextGenSoftware.OASIS.API.ONode.Core.Interfaces.Holons;
using NextGenSoftware.OASIS.API.Core.CustomAttrbiutes;

namespace NextGenSoftware.OASIS.API.ONode.Core.Holons
{
    public class OAPP : Holon, IOAPP
    //public class OAPP : HolonBase, IOAPP
    {
        public OAPP()
        {
            this.HolonType = HolonType.OAPP;
        }

        [CustomOASISProperty]
        public OAPPType OAPPType { get; set; }

        [CustomOASISProperty]
        public GenesisType GenesisType { get; set; }
        //public ICelestialHolon CelestialHolon { get; set; } //The base CelestialHolon that represents this OAPP (planet, moon, star, solar system, galaxy etc).

        [CustomOASISProperty]
        public Guid CelestialBodyId { get; set; }

        [CustomOASISProperty]
        public ICelestialBody CelestialBody { get; set; } //The base CelestialBody that represents this OAPP (planet, moon, star, super star, grand super star, etc).

        [CustomOASISProperty]
        public DateTime PublishedOn { get; set; }

        [CustomOASISProperty]
        public Guid PublishedByAvatarId { get; set; }

        [CustomOASISProperty]
        public byte[] PublishedOAPP { get; set; }

        [CustomOASISProperty]
        public string CreatedByAvatarUsername { get; set; }

        [CustomOASISProperty]
        public string PublishedByAvatarUsername { get; set; }

        //TODO:More to come! ;-)
    }
}
