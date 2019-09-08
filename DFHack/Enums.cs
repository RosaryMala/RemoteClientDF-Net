namespace DF.Enums
{
    public enum BuildingType
    {
        None = -1,
        Chair,
        Bed,
        Table,
        Coffin,
        FarmPlot,
        Furnace,
        TradeDepot,
        Shop,
        Door,
        Floodgate,
        Box,
        Weaponrack,
        Armorstand,
        Workshop,
        Cabinet,
        Statue,
        WindowGlass,
        WindowGem,
        Well,
        Bridge,
        RoadDirt,
        RoadPaved,
        SiegeEngine,
        Trap,
        AnimalTrap,
        Support,
        ArcheryTarget,
        Chain,
        Cage,
        Stockpile,
        Civzone,
        Weapon,
        Wagon,
        ScrewPump,
        Construction,
        Hatch,
        GrateWall,
        GrateFloor,
        BarsVertical,
        BarsFloor,
        GearAssembly,
        AxleHorizontal,
        AxleVertical,
        WaterWheel,
        Windmill,
        TractionBench,
        Slab,
        Nest,
        NestBox,
        Hive,
        Rollers,
        Instrument,
        Bookcase
    }

    public enum Profession
    {
        None = -1,
        Miner,
        Woodworker,
        Carpenter,
        Bowyer,
        Woodcutter,
        Stoneworker,
        Engraver,
        Mason,
        Ranger,
        AnimalCaretaker,
        AnimalTrainer,
        Hunter,
        Trapper,
        AnimalDissector,
        Metalsmith,
        FurnaceOperator,
        Weaponsmith,
        Armorer,
        Blacksmith,
        Metalcrafter,
        Jeweler,
        GemCutter,
        GemSetter,
        Craftsman,
        Woodcrafter,
        Stonecrafter,
        Leatherworker,
        BoneCarver,
        Weaver,
        Clothier,
        Glassmaker,
        Potter,
        Glazer,
        WaxWorker,
        StrandExtractor,
        FisheryWorker,
        Fisherman,
        FishDissector,
        FishCleaner,
        Farmer,
        CheeseMaker,
        Milker,
        Cook,
        Thresher,
        Miller,
        Butcher,
        Tanner,
        Dyer,
        Planter,
        Herbalist,
        Brewer,
        SoapMaker,
        PotashMaker,
        LyeMaker,
        WoodBurner,
        Shearer,
        Spinner,
        Presser,
        Beekeeper,
        Engineer,
        Mechanic,
        SiegeEngineer,
        SiegeOperator,
        PumpOperator,
        Clerk,
        Administrator,
        Trader,
        Architect,
        Alchemist,
        Doctor,
        Diagnoser,
        BoneSetter,
        Suturer,
        Surgeon,
        Merchant,
        Hammerman,
        MasterHammerman,
        Spearman,
        MasterSpearman,
        Crossbowman,
        MasterCrossbowman,
        Wrestler,
        MasterWrestler,
        Axeman,
        MasterAxeman,
        Swordsman,
        MasterSwordsman,
        Maceman,
        MasterMaceman,
        Pikeman,
        MasterPikeman,
        Bowman,
        MasterBowman,
        Blowgunman,
        MasterBlowgunman,
        Lasher,
        MasterLasher,
        Recruit,
        TrainedHunter,
        TrainedWar,
        MasterThief,
        Thief,
        Standard,
        Child,
        Baby,
        Drunk,
        MonsterSlayer,
        Scout,
        BeastHunter,
        Snatcher,
        Mercenary,
        Gelder,
        Performer,
        Poet,
        Bard,
        Dancer,
        Sage,
        Scholar,
        Philosopher,
        Mathematician,
        Historian,
        Astronomer,
        Naturalist,
        Chemist,
        Geographer,
        Scribe,
        Papermaker,
        Bookbinder,
        TavernKeeper
    }

    public enum ItemType
    {
        None = -1,
        /**
         * Bars, such as metal, fuel, or soap.
         */
        Bar,
        /**
         * Cut gemstones usable in jewelers workshop
         */
        Smallgem,
        /**
         * Blocks of any kind.
         */
        Blocks,
        /**
         * Rough gemstones.
         */
        Rough,
        /**
         * Raw mined stone.
         */
        Boulder,
        /**
         * Wooden logs.
         */
        Wood,
        /**
         * Doors.
         */
        Door,
        /**
         * Floodgates.
         */
        Floodgate,
        /**
         * Beds.
         */
        Bed,
        /**
         * Chairs and thrones.
         */
        Chair,
        /**
         * Restraints.
         */
        Chain,
        /**
         * Flasks.
         */
        Flask,
        /**
         * Goblets.
         */
        Goblet,
        /**
         * Musical instruments.
         */
        Instrument,
        /**
         * Toys.
         */
        Toy,
        /**
         * Glass windows.
         */
        Window,
        /**
         * Cages.
         */
        Cage,
        /**
         * Barrels.
         */
        Barrel,
        /**
         * Buckets.
         */
        Bucket,
        /**
         * Animal traps.
         */
        Animaltrap,
        /**
         * Tables.
         */
        Table,
        /**
         * Coffins.
         */
        Coffin,
        /**
         * Statues.
         */
        Statue,
        /**
         * Corpses. Does not have a material.
         */
        Corpse,
        /**
         * Weapons.
         */
        Weapon,
        /**
         * Armor and clothing worn on the upper body.
         */
        Armor,
        /**
         * Armor and clothing worn on the feet.
         */
        Shoes,
        /**
         * Shields and bucklers.
         */
        Shield,
        /**
         * Armor and clothing worn on the head.
         */
        Helm,
        /**
         * Armor and clothing worn on the hands.
         */
        Gloves,
        /**
         * Chests (wood), coffers (stone), boxes (glass), and bags (cloth or leather).
         */
        Box,
        /**
         * Bins.
         */
        Bin,
        /**
         * Armor stands.
         */
        Armorstand,
        /**
         * Weapon racks.
         */
        Weaponrack,
        /**
         * Cabinets.
         */
        Cabinet,
        /**
         * Figurines.
         */
        Figurine,
        /**
         * Amulets.
         */
        Amulet,
        /**
         * Scepters.
         */
        Scepter,
        /**
         * Ammunition for hand-held weapons.
         */
        Ammo,
        /**
         * Crowns.
         */
        Crown,
        /**
         * Rings.
         */
        Ring,
        /**
         * Earrings.
         */
        Earring,
        /**
         * Bracelets.
         */
        Bracelet,
        /**
         * Large gems.
         */
        Gem,
        /**
         * Anvils.
         */
        Anvil,
        /**
         * Body parts. Does not have a material.
         */
        Corpsepiece,
        /**
         * Dead vermin bodies. Material is CREATURE_ID:CASTE.
         */
        Remains,
        /**
         * Butchered meat.
         */
        Meat,
        /**
         * Prepared fish. Material is CREATURE_ID:CASTE.
         */
        Fish,
        /**
         * Unprepared fish. Material is CREATURE_ID:CASTE.
         */
        FishRaw,
        /**
         * Live vermin. Material is CREATURE_ID:CASTE.
         */
        Vermin,
        /**
         * Tame vermin. Material is CREATURE_ID:CASTE.
         */
        Pet,
        /**
         * Seeds from plants.
         */
        Seeds,
        /**
         * Plants.
         */
        Plant,
        /**
         * Tanned skins.
         */
        SkinTanned,
        /**
         * Assorted plant growths, including leaves and berries
         */
        PlantGrowth,
        /**
         * Thread gathered from webs or made at the farmers workshop.
         */
        Thread,
        /**
         * Cloth made at the loom.
         */
        Cloth,
        /**
         * Skull totems.
         */
        Totem,
        /**
         * Armor and clothing worn on the legs.
         */
        Pants,
        /**
         * Backpacks.
         */
        Backpack,
        /**
         * Quivers.
         */
        Quiver,
        /**
         * Catapult parts.
         */
        Catapultparts,
        /**
         * Ballista parts.
         */
        Ballistaparts,
        /**
         * Siege engine ammunition.
         */
        Siegeammo,
        /**
         * Ballista arrow heads.
         */
        Ballistaarrowhead,
        /**
         * Mechanisms.
         */
        Trapparts,
        /**
         * Trap components.
         */
        Trapcomp,
        /**
         * Alcoholic drinks.
         */
        Drink,
        /**
         * Powders such as flour, gypsum plaster, dye, or sand.
         */
        PowderMisc,
        /**
         * Pieces of cheese.
         */
        Cheese,
        /**
         * Prepared meals. Subtypes come from item_food.txt
         */
        Food,
        /**
         * Liquids such as water, lye, and extracts.
         */
        LiquidMisc,
        /**
         * Coins.
         */
        Coin,
        /**
         * Fat, tallow, pastes/pressed objects, and small bits of molten rock/metal.
         */
        Glob,
        /**
         * Small rocks (usually sharpened and/or thrown in adventurer mode)
         */
        Rock,
        /**
         * Pipe sections.
         */
        PipeSection,
        /**
         * Hatch covers.
         */
        HatchCover,
        /**
         * Grates.
         */
        Grate,
        /**
         * Querns.
         */
        Quern,
        /**
         * Millstones.
         */
        Millstone,
        /**
         * Splints.
         */
        Splint,
        /**
         * Crutches.
         */
        Crutch,
        /**
         * Traction benches.
         */
        TractionBench,
        /**
         * Casts
         */
        OrthopedicCast,
        /**
         * Tools.
         */
        Tool,
        /**
         * Slabs.
         */
        Slab,
        /**
         * Eggs. Material is CREATURE_ID:CASTE.
         */
        Egg,
        /**
         * Books.
         */
        Book,
        /**
         * Sheets of paper
         */
        Sheet,
        /**
         * Tree branches
         */
        Branch
    }
}
