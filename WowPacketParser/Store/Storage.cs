﻿using System;
using System.Collections.Generic;
using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.Store.Objects;

namespace WowPacketParser.Store
{
    public static class Storage
    {
        // Stores opcodes read, npc/GOs/spell/item/etc IDs found in sniffs
        // and other miscellaneous stuff
        public static readonly DataBag<SniffData> SniffData = new DataBag<SniffData>(new List<SQLOutput> { SQLOutput.SniffData, SQLOutput.SniffDataOpcodes });

        /* Key: Guid */

        // Units, GameObjects, Players, Items
        public static readonly StoreDictionary<WowGuid, WoWObject> Objects = new StoreDictionary<WowGuid, WoWObject>(new List<SQLOutput>());

        /* Key: Entry */

        // Templates
        public static readonly DataBag<GameObjectTemplate> GameObjectTemplates = new DataBag<GameObjectTemplate>(new List<SQLOutput> { SQLOutput.gameobject_template });
        public static readonly DataBag<GameObjectTemplateQuestItem> GameObjectTemplateQuestItems = new DataBag<GameObjectTemplateQuestItem>(new List<SQLOutput> { SQLOutput.gameobject_template });
        public static readonly DataBag<ItemTemplate> ItemTemplates = new DataBag<ItemTemplate>(new List<SQLOutput> { SQLOutput.item_template });
        public static readonly DataBag<QuestTemplate> QuestTemplates = new DataBag<QuestTemplate>(new List<SQLOutput> { SQLOutput.quest_template });
        public static readonly DataBag<QuestObjective> QuestObjectives = new DataBag<QuestObjective>(new List<SQLOutput> { SQLOutput.quest_template });
        public static readonly DataBag<QuestVisualEffect> QuestVisualEffects = new DataBag<QuestVisualEffect>(new List<SQLOutput> { SQLOutput.quest_template });
        public static readonly DataBag<CreatureTemplate> CreatureTemplates = new DataBag<CreatureTemplate>(new List<SQLOutput> { SQLOutput.creature_template });
        public static readonly DataBag<CreatureTemplateQuestItem> CreatureTemplateQuestItems = new DataBag<CreatureTemplateQuestItem>(new List<SQLOutput> { SQLOutput.creature_template });

        // Vendor & trainer
        public static readonly DataBag<NpcTrainer> NpcTrainers = new DataBag<NpcTrainer>(new List<SQLOutput> { SQLOutput.npc_trainer });
        public static readonly DataBag<NpcVendor> NpcVendors = new DataBag<NpcVendor>(new List<SQLOutput> { SQLOutput.npc_vendor });

        // Page & npc text
        public static readonly DataBag<PageText> PageTexts = new DataBag<PageText>(new List<SQLOutput> { SQLOutput.page_text });
        public static readonly DataBag<NpcText> NpcTexts = new DataBag<NpcText>(new List<SQLOutput> { SQLOutput.npc_text });
        public static readonly DataBag<NpcTextMop> NpcTextsMop = new DataBag<NpcTextMop>(new List<SQLOutput> { SQLOutput.npc_text });

        // Creature text (says, yells, etc.)
        public static readonly StoreMulti<uint, CreatureText> CreatureTexts = new StoreMulti<uint, CreatureText>(new List<SQLOutput> { SQLOutput.creature_text });

        // Points of Interest
        public static readonly DataBag<PointsOfInterest> GossipPOIs = new DataBag<PointsOfInterest>(new List<SQLOutput> { SQLOutput.points_of_interest });

        // "Helper" stores, do not match a specific table
        public static readonly StoreMulti<WowGuid, EmoteType> Emotes = new StoreMulti<WowGuid, EmoteType>(new List<SQLOutput> { SQLOutput.creature_text });
        public static readonly StoreBag<uint> Sounds = new StoreBag<uint>(new List<SQLOutput> { SQLOutput.creature_text });
        public static readonly StoreDictionary<uint, List<uint?>> SpellsX = new StoreDictionary<uint, List<uint?>>(new List<SQLOutput> { SQLOutput.creature_template }); // `creature_template`.`spellsX`
        public static readonly DataBag<QuestOfferReward> QuestOfferRewards = new DataBag<QuestOfferReward>(new List<SQLOutput> { SQLOutput.quest_template });
        public static readonly StoreDictionary<Tuple<uint, uint>, object> GossipSelects = new StoreDictionary<Tuple<uint, uint>, object>(new List<SQLOutput> { SQLOutput.points_of_interest, SQLOutput.gossip_menu, SQLOutput.gossip_menu_option });

        /* Key: Misc */

        // Start info (Race, Class)
        public static readonly DataBag<PlayerCreateInfoAction> StartActions = new DataBag<PlayerCreateInfoAction>(new List<SQLOutput> { SQLOutput.playercreateinfo_action });
        public static readonly DataBag<PlayerCreateInfo>StartPositions = new DataBag<PlayerCreateInfo>(new List<SQLOutput> { SQLOutput.playercreateinfo });

        // Gossips (MenuId, TextId)
        public static readonly DataBag<GossipMenu> Gossips = new DataBag<GossipMenu>(new List<SQLOutput> { SQLOutput.gossip_menu });
        public static readonly DataBag<GossipMenuOption> GossipMenuOptions = new DataBag<GossipMenuOption>(new List<SQLOutput> { SQLOutput.gossip_menu_option });

        // Quest POI (QuestId, Id)
        public static readonly DataBag<QuestPOI> QuestPOIs = new DataBag<QuestPOI>(new List<SQLOutput> { SQLOutput.quest_poi_points });
        public static readonly DataBag<QuestPOIPoint> QuestPOIPoints = new DataBag<QuestPOIPoint>(new List<SQLOutput> { SQLOutput.quest_poi_points }); // WoD

        // Quest Misc
        public static readonly DataBag<QuestGreeting> QuestGreetings = new DataBag<QuestGreeting>(new List<SQLOutput> { SQLOutput.quest_template });
        public static readonly DataBag<QuestDetails> QuestDetails = new DataBag<QuestDetails>(new List<SQLOutput> { SQLOutput.quest_template });
        public static readonly DataBag<QuestRequestItems> QuestRequestItems = new DataBag<QuestRequestItems>(new List<SQLOutput> { SQLOutput.quest_template });

        // Names
        public static readonly DataBag<ObjectName> ObjectNames = new DataBag<ObjectName>();

        // Vehicle Template Accessory
        public static readonly DataBag<VehicleTemplateAccessory> VehicleTemplateAccessories = new DataBag<VehicleTemplateAccessory>(new List<SQLOutput> { SQLOutput.vehicle_template_accessory });

        // Weather updates
        public static readonly DataBag<WeatherUpdate> WeatherUpdates = new DataBag<WeatherUpdate>(new List<SQLOutput> { SQLOutput.weather_updates });

        // Npc Spell Click
        public static readonly StoreBag<WowGuid> NpcSpellClicks = new StoreBag<WowGuid>(new List<SQLOutput> { SQLOutput.npc_spellclick_spells });
        public static readonly DataBag<NpcSpellClick> SpellClicks = new DataBag<NpcSpellClick>(new List<SQLOutput> { SQLOutput.npc_spellclick_spells });

        // Quest Misc
        public static readonly DataBag<LocalesQuest> LocalesQuests = new DataBag<LocalesQuest>(new List<SQLOutput> { SQLOutput.locales_quest });
        public static readonly DataBag<QuestObjectivesLocale> LocalesQuestObjectives = new DataBag<QuestObjectivesLocale>(new List<SQLOutput> { SQLOutput.locales_quest_objectives });

        public static readonly DataBag<HotfixData> HotfixDatas = new DataBag<HotfixData>(new List<SQLOutput> { SQLOutput.hotfix_data });

        public static void ClearContainers()
        {
            SniffData.Clear();

            Objects.Clear();

            GameObjectTemplates.Clear();
            GameObjectTemplateQuestItems.Clear();
            ItemTemplates.Clear();
            QuestTemplates.Clear();
            QuestObjectives.Clear();
            CreatureTemplates.Clear();
            CreatureTemplateQuestItems.Clear();

            NpcTrainers.Clear();
            NpcVendors.Clear();

            PageTexts.Clear();
            NpcTexts.Clear();
            NpcTextsMop.Clear();

            CreatureTexts.Clear();

            GossipPOIs.Clear();

            Emotes.Clear();
            Sounds.Clear();
            SpellsX.Clear();

            GossipSelects.Clear();

            StartActions.Clear();
            StartPositions.Clear();

            Gossips.Clear();

            QuestPOIs.Clear();

            QuestGreetings.Clear();
            QuestDetails.Clear();
            QuestRequestItems.Clear();
            QuestOfferRewards.Clear();

            ObjectNames.Clear();

            VehicleTemplateAccessories.Clear();

            WeatherUpdates.Clear();

            NpcSpellClicks.Clear();
            SpellClicks.Clear();

            HotfixDatas.Clear();
        }

        public static void AddHotfixData(int entry, DB2Hash type, bool deleted, uint timeStamp)
        {
            HotfixDatas.Add(new HotfixData
            {
                RecordID = entry,
                TableHash = type,
                Deleted = deleted,
                Timestamp = timeStamp
            });
        }
    }
}
