﻿
using NextGenSoftware.Holochain.HoloNET.Client;
using NextGenSoftware.Holochain.HoloNET.Client.TestHarness;
using NextGenSoftware.OASIS.API.Core.Enums;
using NextGenSoftware.OASIS.API.Core.Interfaces;
using NextGenSoftware.OASIS.API.Core.Interfaces.STAR;
using NextGenSoftware.OASIS.API.Core.Objects;
using System;
using System.Collections.Generic;

namespace NextGenSoftware.OASIS.API.Providers.HoloOASIS
{
    public class HcAvatarDetail : HoloNETAuditEntryBaseClass, IHcAvatarDetail
    {
        public HcAvatarDetail() : base("oasis", "get_entry_avatar_detail", "create_entry_avatar_detail", "update_entry_avatar_detail", "delete_entry_avatar_detail") { }
        public HcAvatarDetail(HoloNETClient holoNETClient) : base("oasis", "get_entry_avatar_detail", "create_entry_avatar_detail", "update_entry_avatar_detail", "delete_entry_avatar_detail", holoNETClient) { }

        [HolochainFieldName("id")]
        public Guid Id { get; set; }

        [HolochainFieldName("username")]
        public string Username { get; set; }

        [HolochainFieldName("email")]
        public string Email { get; set; }

        [HolochainFieldName("karma")]
        public int Karma { get; set; } //TODO: This really needs to have a private setter but in the HoloOASIS provider it needs to copy the object along with each property... would prefer another work around if possible?

        [HolochainFieldName("level")]
        public int Level { get; set; }

        [HolochainFieldName("xp")]
        public int XP { get; set; }

        [HolochainFieldName("model_3d")]
        public string Model3D { get; set; }

        [HolochainFieldName("uma_json")]
        public string UmaJson { get; set; }

        [HolochainFieldName("portrait")]
        public string Portrait { get; set; }

        [HolochainFieldName("dob")]
        public string DOB { get; set; }

        [HolochainFieldName("address")]
        public string Address { get; set; }

        [HolochainFieldName("town")]
        public string Town { get; set; }

        [HolochainFieldName("county")]
        public string County { get; set; }

        [HolochainFieldName("country")]
        public string Country { get; set; }

        [HolochainFieldName("post_code")]
        public string Postcode { get; set; }

        [HolochainFieldName("landline")]
        public string Landline { get; set; }

        [HolochainFieldName("mobile")]
        public string Mobile { get; set; }

        [HolochainFieldName("achievements")]
        public IList<IAchievement> Achievements { get; set; }
        public IAvatarAttributes Attributes { get; set; }
        public IAvatarAura Aura { get; set; }
        //EnumValue<AvatarType> AvatarType { get; set; }
        public IAvatarChakras Chakras { get; set; }
        //EnumValue<OASISType> CreatedOASISType { get; set; }
        public IDictionary<DimensionLevel, Guid> DimensionLevelIds { get; set; }
        public IDictionary<DimensionLevel, IHolon> DimensionLevels { get; set; }
        public ConsoleColor FavouriteColour { get; set; }
        public IList<IGeneKey> GeneKeys { get; set; }
        public IList<IAvatarGift> Gifts { get; set; }
        public IList<HeartRateEntry> HeartRateData { get; set; }
        public IHumanDesign HumanDesign { get; set; }
        public IList<IInventoryItem> Inventory { get; set; }
        public IList<KarmaAkashicRecord> KarmaAkashicRecords { get; set; }
        public IOmiverse Omniverse { get; set; }
        public IAvatarSkills Skills { get; set; }
        public IList<ISpell> Spells { get; set; }
        public ConsoleColor STARCLIColour { get; set; }
        public IAvatarStats Stats { get; set; }
        public IAvatarSuperPowers SuperPowers { get; set; }
    }
}