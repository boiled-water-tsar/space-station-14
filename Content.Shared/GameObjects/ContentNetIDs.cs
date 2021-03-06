﻿namespace Content.Shared.GameObjects
{
    // Starting from 1000 to avoid crossover with engine.
    public static class ContentNetIDs
    {
        public const uint DAMAGEABLE = 1000;
        public const uint DESTRUCTIBLE = 1001;
        public const uint MAGAZINE_BARREL = 1002;
        public const uint HANDS = 1003;
        public const uint SOLUTION = 1004;
        public const uint STORAGE = 1005;
        public const uint INVENTORY = 1006;
        public const uint POWER_DEBUG_TOOL = 1007;
        // 1008
        // 1009
        public const uint RANGED_WEAPON = 1010;
        public const uint CAMERA_RECOIL = 1011;
        public const uint SOUND = 1012;
        public const uint ITEM = 1013;
        public const uint CLOTHING = 1014;
        public const uint ENTITYSTORAGE = 1015;
        public const uint LATHE = 1016;
        public const uint LATHE_DATABASE = 1017;
        public const uint MATERIAL_STORAGE = 1018;
        public const uint HAND_TELEPORTER = 1019;
        public const uint VENDING_MACHINE = 1020;
        public const uint PROTOLATHE_DATABASE = 1021;
        public const uint TECHNOLOGY_DATABASE = 1022;
        public const uint RESEARCH_CONSOLE = 1023;
        public const uint WIRES = 1024;
        public const uint COMBATMODE = 1025;
        public const uint STATUSEFFECTS = 1026;
        public const uint OVERLAYEFFECTS = 1027;
        public const uint STOMACH = 1028;
        public const uint ITEMCOOLDOWN = 1029;
        public const uint CARGO_ORDER_DATABASE = 1030;
        public const uint GALACTIC_MARKET = 1031;
        public const uint HUMANOID_APPEARANCE = 1032;
        public const uint INSTRUMENTS = 1033;
        public const uint WELDER = 1034;
        public const uint STACK = 1035;
        public const uint HANDHELD_LIGHT = 1036;
        public const uint PAPER = 1037;
        public const uint REAGENT_INJECTOR = 1038;
        public const uint GHOST = 1039;
        public const uint MICROWAVE = 1040;
        public const uint GRAVITY_GENERATOR = 1041;
        public const uint SURGERY = 1042;
        public const uint MULTITOOLS = 1043;
        public const uint PDA = 1044;
        public const uint PATHFINDER_DEBUG = 1045;
        public const uint AI_DEBUG = 1046;
        public const uint PLAYER_INPUT_MOVER = 1047;
        public const uint STUNNABLE = 1048;
        public const uint HUNGER = 1049;
        public const uint THIRST = 1050;

        public const uint FLASHABLE = 1051;

        // Net IDs for integration tests.
        public const uint PREDICTION_TEST = 10001;
    }
}
