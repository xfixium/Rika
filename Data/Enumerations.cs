// 
// Rika
// Copyright (C) 2020 xfixium | xfixium@yahoo.com
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//

using System.ComponentModel;

namespace Rika.Data
{
    /// <summary>
    /// Sort type enumeration
    /// </summary>
    public enum SortType
    {
        [Description("None")]
        None = 0,
        [Description("Asc")]
        Asc = 1,
        [Description("Desc")]
        Desc = 2
    }

    /// <summary>
    /// Scale type enumeration
    /// </summary>
    public enum ScaleType : int
    {
        [Description("1x")]
        OneTimes = 1,
        [Description("2x")]
        TwoTimes = 2,
        [Description("3x")]
        ThreeTimes = 3,
        [Description("4x")]
        FourTimes = 4
    }

    /// <summary>
    /// Save type enumeration
    /// </summary>
    public enum SaveType
    {
        [Description("Palette Group")]
        PaletteGroup = 0,
        [Description("Sprite")]
        Sprite = 1,
        [Description("Sprite Tileset")]
        SpriteTileset = 2,
        [Description("Sprite Tile Map")]
        SpriteTileMap = 3,
        [Description("Tileset")]
        Tileset = 4,
        [Description("Tile Map")]
        TileMap = 5
    }

    /// <summary>
    /// Save as type enumeration
    /// </summary>
    public enum SaveAsType
    {
        [Description("Uncompressed Binary")]
        Binary = 0,
        [Description("Compressed Binary")]
        CompressedBinary = 1,
        [Description("Image")]
        Image = 2
    }

    /// <summary>
    /// Compression type enumeration
    /// </summary>
    public enum CompressionType : int
    {
        [Description("None")]
        None = 0,
        [Description("Kosinski")]
        Kosinski = 1,
        [Description("Kosinski Plus")]
        KosinskiPlus = 2,
        [Description("Enigma")]
        Enigma = 3,
        [Description("Nemesis")]
        Nemesis = 4,
        [Description("Saxman")]
        Saxman = 5
    }

    /// <summary>
    /// Pixel format type enumeration
    /// </summary>
    public enum PixelFormatType : int
    {
        [Description("2bpp Planar")]
        TwoPlanar = 0,
        [Description("4bpp Linear")]
        FourLinear = 1
    }

    /// <summary>
    /// Treasure chest type enumeration
    /// </summary>
    public enum MapChestType
    {
        [Description("Yellow")]
        Yellow = 0,
        [Description("White")]
        White = 1
    }

    /// <summary>
    /// Treasure chest contents type enumeration
    /// </summary>
    public enum MapChestContentType
    {
        [Description("Item")]
        Item = 0,
        [Description("Meseta")]
        Meseta = 1
    }

    /// <summary>
    /// Map area event type enumeration
    /// </summary>
    public enum MapAreaEventType
    {
        [Description("Story")]
        Story = 0,
        [Description("Treasure Chest")]
        Chest = 1,
        [Description("Temporary Event")]
        TemporaryEvent = 2
    }

    /// <summary>
    /// Character dialog type
    /// </summary>
    public enum CharacterDialogType : int
    {
        [Description("NPC")]
        NPC = 0,
        [Description("Chaz")]
        Chaz = 1,
        [Description("Alys")]
        Alys = 2,
        [Description("Hahn")]
        Hahn = 3,
        [Description("Rune")]
        Rune = 4,
        [Description("Gryz")]
        Gryz = 5,
        [Description("Rika")]
        Rika = 6,
        [Description("Demi")]
        Demi = 7,
        [Description("Wren")]
        Wren = 8,
        [Description("Raja")]
        Raja = 9,
        [Description("Kyra")]
        Kyra = 10,
        [Description("Seth")]
        Seth = 11
    }

    /// <summary>
    /// Dialog code type neumeration
    /// </summary>
    public enum DialogCodeType : byte
    {
        Count = 218, // $DA
        Action = 242, // $F2
        KeepFacingDirection = 243, // $F3
        Portrait = 244, // $F4 byte after holds portrait index, an extra byte for talk option: 0 = left, 1 = center, 2 = right
        Confirmation = 245, // $F5 byte after is the dialog index to bring up next, if 0, keep with current dialog
        LoadEvent = 246, // $F6 byte after is the event index
        CloseWindow1 = 247, // $F7
        Pause = 249, // $F9
        Open = 250, // $FA byte after is a flag, if set, the next byte is the index of the next dialog
        NewLine = 252,  // $FC
        PageEnd = 253, // $FD
        CloseWindow2 = 254, // $FE
        Close = 255 // $FF
    }

    /// <summary>
    /// Dialog action type enumeration
    /// </summary>
    public enum DialogActionType : byte
    {
        LoadPanel = 0,  // bytes after this is the panel index
        DestroyLastPanel = 1,
        DestroyAllPanels = 2,
        LoadSound1 = 3, // byte after this is the sound index
        LoadSound2 = 4, // byte after this is the sound index
        UpdatePalettes = 6,
        ZioRedEyes = 7, // change Zio's eyes in dialog
        PauseMusic = 8,
        ResumeMusic = 9,
        SpaceSabotage = 10, // For the spaceship sabotage, plays alarm sound and turns the screen red
        SetEventFlag = 11,
        GameEndUpdate = 13 // After the Profound Darkness battle, it updates things when Elsydeon breaks
    }

    /// <summary>
    /// Character type enumeration
    /// </summary>
    public enum CharacterType : int
    {
        [Description("Chaz")]
        Chaz = 0,
        [Description("Alys")]
        Alys = 1,
        [Description("Hahn")]
        Hahn = 2,
        [Description("Rune")]
        Rune = 3,
        [Description("Gryz")]
        Gryz = 4,
        [Description("Rika")]
        Rika = 5,
        [Description("Demi")]
        Demi = 6,
        [Description("Wren")]
        Wren = 7,
        [Description("Raja")]
        Raja = 8,
        [Description("Kyra")]
        Kyra = 9,
        [Description("Seth")]
        Seth = 10
    }

    /// <summary>
    /// Profession type enumeration
    /// </summary>
    public enum CharacterProfessionType : int
    {
        [Description("Hunter")]
        Hunter = 0,
        [Description("Scholar")]
        Scholar = 1,
        [Description("Wizard")]
        Wizard = 2,
        [Description("Motavian")]
        Motavian = 3,
        [Description("Numan")]
        Numan = 4,
        [Description("Android")]
        Android = 5,
        [Description("Priest")]
        Priest = 6,
        [Description("Esper")]
        Esper = 7
    }

    /// <summary>
    /// Character graphics type enumeration
    /// </summary>
    public enum CharacterGraphicsType : int
    {
        [Description("Portrait")]
        Portrait = 0,
        [Description("Field")]
        Field = 1,
        [Description("Battle")]
        Battle = 2
    }

    /// <summary>
    /// Character equipment type enumeration
    /// </summary>
    public enum CharacterEquipmentType : int
    {
        [Description("All")]
        All = 0,
        [Description("Weapons")]
        Weapons = 1,
        [Description("Shields")]
        Shields = 2,
        [Description("Head")]
        Head = 3,
        [Description("Body")]
        Body = 4
    }

    /// <summary>
    /// Stat type enumeration
    /// </summary>
    public enum StatType : int
    {
        [Description("None")]
        None = 0,
        [Description("HP")]
        HP = 1,
        [Description("Exp")]
        Exp = 2,
        [Description("Meseta")]
        Meseta = 3,
        [Description("Attack")]
        Attack = 4,
        [Description("Defense")]
        Defense = 5,
        [Description("Strength")]
        Strength = 6,
        [Description("Mental")]
        Mental = 7,
        [Description("Agility")]
        Agility = 8,
        [Description("Dexterity")]
        Dexterity = 9,
        [Description("Magic Defense")]
        MagicDefense = 10,
        [Description("Physical Resistance")]
        PhysicalResistance = 11,
        [Description("Radiation Resistance")]
        RadiationResistance = 12,
        [Description("Fire Resistance")]
        FireResistance = 13,
        [Description("Gravity Resistance")]
        GravityResistance = 14,
        [Description("Water Resistance")]
        WaterResistance = 15,
        [Description("Energy Resistance")]
        EnergyResistance = 16,
        [Description("Eelectric Resistance")]
        ElectricResistance = 17,
        [Description("Holy Resistance")]
        HolyResistance = 18,
        [Description("Death Resistance")]
        DeathResistance = 19,
        [Description("Biological Resistance")]
        BiologicalResistance = 20,
        [Description("Psychic Resistance")]
        PsychicResistance = 21,
        [Description("Mechanical Resistance")]
        MechanicalResistance = 22,
        [Description("Light Resistance")]
        LightResistance = 23,
        [Description("Destroy Resistance")]
        DestroyResistance = 24,
        [Description("Resistance Score")]
        ResistanceGrade = 25
    }

    /// <summary>
    /// Element resistance type
    /// </summary>
    public enum ResistanceType : int
    {
        [Description("Immune")]
        Immune = 0,
        [Description("Resistant")]
        Resistant = 1,
        [Description("Normal")]
        Normal = 2,
        [Description("Weak")]
        Weak = 3,
        [Description("Very Weak")]
        VeryWeak = 4
    }

    /// <summary>
    /// Element type enumeration
    /// </summary>
    public enum ElementType : int
    {
        [Description("None")]
        None = 0,
        [Description("Physical")]
        Physical = 1,
        [Description("Radiation")]
        Radiation = 2,
        [Description("Fire")]
        Fire = 3,
        [Description("Gravity")]
        Gravity = 4,
        [Description("Water")]
        Water = 5,
        [Description("Energy")]
        Energy = 6,
        [Description("Electric")]
        Electric = 7,
        [Description("Holy")]
        Holy = 8,
        [Description("Death")]
        Death = 9,
        [Description("Biological")]
        Biological = 10,
        [Description("Psychic")]
        Psychic = 11,
        [Description("Mechanical")]
        Mechanical = 12,
        [Description("Light")]
        Light = 13,
        [Description("Destroy")]
        Destroy = 14
    }

    /// <summary>
    /// Enemy graphics type enumeration
    /// </summary>
    public enum EnemyGraphicsType : int
    {
        [Description("Idle")]
        Idle = 0
    }

    /// <summary>
    /// Enemy trigger type enumeration
    /// </summary>
    public enum TriggerType : int
    {
        [Description("None")]
        None = 0,
        [Description("If next to empty space")]
        EmptyAdjacentSpace = 1,
        [Description("If HP less than half")]
        HPLessThanHalf = 2,
        [Description("If next to Wiredine")]
        AdjacentToEnemy25 = 3,
        [Description("If next to Arthro Pod")]
        AdjacentToEnemy23 = 4,
        [Description("If C-Ray Tube is next to Satellite Minion")]
        AdjacentToEnemy40And42 = 5,
        [Description("If next to Zol Slug")]
        AdjacentToZolSlug = 6,
        [Description("If attacked physically")]
        PhysicalAttack = 7,
        [Description("If attacked magically")]
        MagicalAttack = 8,
        [Description("If alone")]
        Alone = 9,
        [Description("If attacked with techiques")]
        TechAttack = 10,
        [Description("If surprise attack on player")]
        SurpriseAttack = 11,
        [Description("If techiques sealed")]
        Sealed = 12,
        [Description("If next to Haken Left")]
        AdjacentToHakenLeft = 13,
        [Description("If next to Blade Right")]
        AdjacentToBladeRight = 14,
        [Description("If anyone is damaged")]
        AnyDamage = 15,
        [Description("Unknown")]
        Unused = 16,
        [Description("If HP less than quater")]
        HPLessThanQuarter = 17,
        [Description("If there are three Xe-A-Thoul")]
        ThreeOfXeAThoul = 18,
        [Description("If Psycho Wand was used on Zio")]
        PsychoWandUsed = 19
    }

    /// <summary>
    /// Effect type enumeration
    /// </summary>
    public enum EffectType : int
    {
        [Description("None")]
        None = 0,
        [Description("Damage")]
        Damage = 1,
        [Description("Death")]
        Death = 2,
        [Description("Attack down")]
        AttackDown = 3,
        [Description("Defense Down")]
        DefenseDown = 4,
        [Description("Agility down")]
        AgilityDown = 6,
        [Description("Sleep")]
        Sleep = 7,
        [Description("Silence")]
        Silence = 8,
        [Description("Attack Up")]
        AttackUp = 9,
        [Description("Defense Up")]
        DefenseUp = 10,
        [Description("Magic Defense Up")]
        MagicDefenseUp = 11,
        [Description("Agility Up")]
        AgilityUp = 12,
        [Description("Resistance Up")]
        ResistanceUp = 13,
        [Description("Wake Up")]
        WakeUp = 14,
        [Description("TP Up")]
        TechniquePointsUp = 15,
        [Description("HP Up")]
        HealthPointsUp = 18,
        [Description("Cure Poison")]
        CurePoison = 19,
        [Description("Cure Paralysis")]
        CureParalysis = 20,
        [Description("Revive")]
        Revive = 21,
        [Description("Heal Fully")]
        HealFully = 22,
        [Description("Android HP Up")]
        DemiHealthPointsUp = 23,
        [Description("Town Warp")]
        TownWarp = 25,
        [Description("Dungeon Warp")]
        DungeonWarp = 26,
        [Description("Poison")]
        Poison = 27,
        [Description("Paralyze")]
        Paralyze = 28,
        [Description("Android Death")]
        AndroidDeath = 29,
        [Description("Fission")]
        Fission1 = 30,
        [Description("Combine")]
        Combine = 31,
        [Description("Combined Attack")]
        CombinedAttack = 32,
        [Description("Dexterity Down")]
        DexterityDown = 33,
        [Description("Waiting")]
        Waiting = 34,
        [Description("Self Destruct")]
        SelfDestruct = 35,
        [Description("Combined Self Destruct")]
        CombinedSelfDestruct = 36,
        [Description("Fission")]
        Fission2 = 37,
        [Description("Dexterity Up")]
        DexterityUp = 38,
        [Description("Remove Stats")]
        StatusEffectRemoval = 39,
        [Description("Map")]
        Map = 40,
        [Description("Black Wave (Enable)")]
        EnableBlackWave = 41,
        [Description("Black Wave (Triggered)")]
        BlackWave1 = 42,
        [Description("All Stats Up")]
        AllStatsUp = 43,
        [Description("Black Wave")]
        BlackWave2 = 44
    }

    /// <summary>
    /// Effect stat type enumeration
    /// </summary>
    public enum EffectStatType : int
    {
        [Description("None")]
        None = 0,
        [Description("Strength")]
        Strength = 1,
        [Description("Mental")]
        Mental = 2,
        [Description("Agility")]
        Agility = 3,
        [Description("Dexterity")]
        Dexterity = 4,
        [Description("Attack")]
        Attack = 5,
        [Description("Defense")]
        Defense = 6,
        [Description("Magic Defense")]
        MagicDefense = 7,
        [Description("Disabled, If Sealed")]
        DisabledIfSealed = 130,
        [Description("Strength (Requires Weapon)")]
        StrengthWithWeapon = 9,
        [Description("Mental (Requires Weapon)")]
        MentalWithWeapon = 10,
        [Description("Agility (Requires Weapon)")]
        AgilityWithWeapon = 11,
        [Description("Dexterity (Requires Weapon)")]
        DexterityWithWeapon = 12,
        [Description("Attack (Requires Weapon)")]
        AttackWithWeapon = 13,
    }

    /// <summary>
    /// Effect target type enumeration
    /// </summary>
    public enum EffectTargetType : int
    {
        [Description("None")]
        None = 0,
        [Description("Single Enemy")]
        SingleEnemy = 1,
        [Description("All Enemies")]
        AllEnemies = 2,
        [Description("Self")]
        Self = 3,
        [Description("Single Human")]
        SingleHuman = 4,
        [Description("All Humans")]
        AllHumans = 5,
        [Description("Single Android")]
        SingleAndroid = 6,
        [Description("All Androids")]
        AllAndroids = 7,
        [Description("Single")]
        SingleAny = 8,
        [Description("All")]
        AllAny = 9
    }

    /// <summary>
    /// Effect area type enumeration
    /// </summary>
    public enum EffectAreaType : int
    {
        [Description("None")]
        None = 0,
        [Description("Use only in battle")]
        OnlyInBattle = 1,
        [Description("Use only out of battle")]
        OnlyOutBattle = 2,
        [Description("Use in or out of battle")]
        Anywhere = 3
    }

    /// <summary>
    /// Status effect type enumeration
    /// </summary>
    public enum StatusEffectType : int
    {
        [Description("None")]
        None = 0,
        [Description("Poison")]
        Poison = 27,
        [Description("Paralysis")]
        Paralysis = 28
    }

    /// <summary>
    /// Combo part type enumeration
    /// </summary>
    public enum ComboPartType : int
    {
        [Description("Technique")]
        Technique = 0,
        [Description("Skill")]
        Skill = 1
    }

    /// <summary>
    /// Item area type enumeration
    /// </summary>
    public enum ItemAreaType : int
    {
        [Description("None")]
        None = 0,
        [Description("One Handed Single")]
        OneHandedOneTarget = 1,
        [Description("One Handed Multiple")]
        OneHandedMultiTarget = 2,
        [Description("Two Handed Single")]
        TwoHandedOneTarget = 3,
        [Description("Two Handed Multiple")]
        TwoHandedMultiTarget = 4,
        [Description("Shield")]
        Shield = 5,
        [Description("Head")]
        Head = 6,
        [Description("Body")]
        Body = 7,
        [Description("Useable")]
        Useable = 8,
        [Description("Story")]
        Story = 9,
        [Description("Non-Battle")]
        NonBattle = 10
    }

    /// <summary>
    /// Item character filter type enumeration
    /// </summary>
    public enum ItemCharacterFilterType : int
    {
        [Description("All")]
        All = 0,
        [Description("Androids")]
        Androids = 1,
        [Description("Humans")]
        Humans = 2,
        [Description("Chaz")]
        Chaz = 3,
        [Description("Alys")]
        Alys = 4,
        [Description("Hahn")]
        Hahn = 5,
        [Description("Rune")]
        Rune = 6,
        [Description("Gryz")]
        Gryz = 7,
        [Description("Rika")]
        Rika = 8,
        [Description("Demi")]
        Demi = 9,
        [Description("Wren")]
        Wren = 10,
        [Description("Raja")]
        Raja = 11,
        [Description("Kyra")]
        Kyra = 12,
        [Description("Seth")]
        Seth = 13
    }

    /// <summary>
    /// Item type filter type enumeration
    /// </summary>
    public enum ItemTypeFilterType : int
    {
        [Description("All")]
        All = 0,
        [Description("Equipment")]
        Battle = 1,
        [Description("Weapon")]
        Weapon = 2,
        [Description("Shield")]
        Shield = 3,
        [Description("Head")]
        Head = 4,
        [Description("Body")]
        Body = 5,
        [Description("Useable")]
        Useable = 6,
        [Description("Story")]
        Story = 7,
        [Description("Non-Battle")]
        NonBattle = 8
    }

    /// <summary>
    /// Element type enumeration
    /// </summary>
    public enum ItemElementFilterType : int
    {
        [Description("All")]
        None = 0,
        [Description("Physical")]
        Physical = 1,
        [Description("Radiation")]
        Radiation = 2,
        [Description("Fire")]
        Fire = 3,
        [Description("Gravity")]
        Gravity = 4,
        [Description("Water")]
        Water = 5,
        [Description("Energy")]
        Energy = 6,
        [Description("Electric")]
        Electric = 7,
        [Description("Holy")]
        Holy = 8,
        [Description("Death")]
        Death = 9,
        [Description("Biological")]
        Biological = 10,
        [Description("Psychic")]
        Psychic = 11,
        [Description("Mechanical")]
        Mechanical = 12,
        [Description("Light")]
        Light = 13,
        [Description("Destroy")]
        Destroy = 14
    }

    /// <summary>
    /// Character technique type enumeration
    /// </summary>
    public enum TechniqueType
    {
        [Description("None")]
        None = 0,
        [Description("Foi")]
        Foi = 1,
        [Description("Gi-Foi")]
        GiFoi = 2,
        [Description("Na-Foi")]
        NaFoi = 3,
        [Description("Wat")]
        Wat = 4,
        [Description("Gi-Wat")]
        GiWat = 5,
        [Description("Na-Wat")]
        NaWat = 6,
        [Description("Tsu")]
        Tsu = 7,
        [Description("Gi-Thu")]
        GiThu = 8,
        [Description("Na-Thu")]
        NaThu = 9,
        [Description("Zan")]
        Zan = 10,
        [Description("Gi-Zan")]
        GiZan = 11,
        [Description("Na-Zan")]
        NaZan = 12,
        [Description("Gra")]
        Gra = 13,
        [Description("Gi-Gra")]
        GiGra = 14,
        [Description("Na-Gra")]
        NaGra = 15,
        [Description("Megid")]
        Megid = 16,
        [Description("Brose")]
        Brose = 17,
        [Description("Vol")]
        Vol = 18,
        [Description("Sa-Vol")]
        SaVol = 19,
        [Description("Gelun")]
        Gelun = 20,
        [Description("Doran")]
        Doran = 21,
        [Description("Seals")]
        Seals = 22,
        [Description("Rimit")]
        Rimit = 23,
        [Description("Res")]
        Res = 24,
        [Description("Gi-Res")]
        GiRes = 25,
        [Description("Na-Res")]
        NaRes = 26,
        [Description("Sar")]
        Sar = 27,
        [Description("Gi-Sar")]
        GiSar = 28,
        [Description("Na-Sar")]
        NaSar = 29,
        [Description("Shift")]
        Shift = 30,
        [Description("Saner")]
        Saner = 31,
        [Description("Deban")]
        Deban = 32,
        [Description("Feeve")]
        Feeve = 33,
        [Description("Anti")]
        Anti = 34,
        [Description("Rimpa")]
        Rimpa = 35,
        [Description("Rever")]
        Rever = 36,
        [Description("Regen")]
        Regen = 37,
        [Description("Arows")]
        Arows = 38,
        [Description("Ryuka")]
        Ryuka = 39,
        [Description("Hinas")]
        Hinas = 40
    }

    /// <summary>
    /// Character skill type enumeration
    /// </summary>
    public enum CharacterSkillType
    {
        [Description("None")]
        None = 0,
        [Description("Cross Cut")]
        CrossCut = 1,
        [Description("Ray Blade")]
        RayBlade = 2,
        [Description("Double Slash")]
        DoubleSlash = 3,
        [Description("Flaeli")]
        Flaeli1 = 4,
        [Description("Flare")]
        Flare = 5,
        [Description("Vortex")]
        Vortex = 6,
        [Description("Astral")]
        Astral = 7,
        [Description("Air Slash")]
        AirSlash = 8,
        [Description("Disrupt")]
        Disrupt = 9,
        [Description("Hewn")]
        Hewn1 = 10,
        [Description("Tandle")]
        Tandle1 = 11,
        [Description("Efess")]
        Efess = 12,
        [Description("Legeon")]
        Legeon = 13,
        [Description("Burst Rocket")]
        BurstRocket = 14,
        [Description("Posibolt")]
        Posibolt = 15,
        [Description("Sweeping")]
        Sweeping = 16,
        [Description("Phonon")]
        Phonon = 17,
        [Description("St. Fire")]
        StFire = 18,
        [Description("Corrosion")]
        Corrosion = 19,
        [Description("Explode")]
        Explode = 20,
        [Description("Eliminate")]
        Eliminate1 = 21,
        [Description("Diem")]
        Diem = 22,
        [Description("Spark")]
        Spark1 = 23,
        [Description("Death")]
        Death = 24,
        [Description("Holy Word")]
        HolyWord = 25,
        [Description("Death Spell")]
        DeathSpell = 26,
        [Description("Negatis")]
        Negatis = 27,
        [Description("Illusion")]
        Illusion = 28,
        [Description("Telele")]
        Telele = 29,
        [Description("Shadow")]
        Shadow = 30,
        [Description("Earth")]
        Earth = 31,
        [Description("Hi-Jammer")]
        HiJammer = 32,
        [Description("Moonshade")]
        Moonshade = 33,
        [Description("Crash")]
        Crash = 34,
        [Description("Stasis Beam")]
        StasisBeam = 35,
        [Description("Bindwa")]
        Bindwa = 36,
        [Description("Mind Blast")]
        MindBlast = 37,
        [Description("Barrier")]
        Barrier1 = 38,
        [Description("War Cry")]
        WarCry = 39,
        [Description("Blessing")]
        Blessing = 40,
        [Description("Warla")]
        Warla = 41,
        [Description("Recover")]
        Recover1 = 42,
        [Description("Medice")]
        Medice = 43,
        [Description("Miracle")]
        Miracle = 44,
        [Description("Medic Power")]
        MedicPower = 45,
        [Description("Ataraxia")]
        Ataraxia = 46,
        [Description("Vision")]
        Vision = 47,
        [Description("Eliminate")]
        Eliminate2 = 48,
        [Description("Flaeli")]
        Flaeli2 = 49,
        [Description("Hewn")]
        Hewn2 = 50,
        [Description("Tandle")]
        Tandle2 = 51,
        [Description("Spark")]
        Spark2 = 52,
        [Description("Barrier")]
        Barrier2 = 53,
        [Description("Recover")]
        Recover2 = 54
    }

    /// <summary>
    /// Enemy type enumeration
    /// </summary>
    public enum EnemyType
    {
        [Description("Helex")]
        Helex = 0,
        [Description("Monster Fly")]
        MonsterFly = 1,
        [Description("Gunner Bit")]
        GunnerBit = 2,
        [Description("Sensor Bit")]
        SensorBit = 3,
        [Description("Protect Bit")]
        ProtectBit = 4,
        [Description("Forced Fly")]
        ForcedFly = 5,
        [Description("Neo Whistle")]
        NeoWhistle = 6,
        [Description("Seeker")]
        Seeker = 7,
        [Description("Sweeper")]
        Sweeper = 8,
        [Description("Xanafalgue")]
        Xanafalgue = 9,
        [Description("Zoran Bult")]
        ZoranBult = 10,
        [Description("Gicefalgue")]
        Gicefalgue = 11,
        [Description("Igglanova")]
        Igglanova = 12,
        [Description("Guilgenova")]
        Guilgenova = 13,
        [Description("Locusta")]
        Locusta = 14,
        [Description("Fanbite")]
        Fanbite = 15,
        [Description("Grass Hound")]
        GrassHound = 16,
        [Description("Slave")]
        Slave = 17,
        [Description("Servant")]
        Servant = 18,
        [Description("Blauzen")]
        Blauzen = 19,
        [Description("Silvalt")]
        Silvalt = 20,
        [Description("Goldine")]
        Goldine = 21,
        [Description("Tarantella")]
        Tarantella = 22,
        [Description("Arthropod")]
        Arthropod = 23,
        [Description("Worker Pod")]
        WorkerPod = 24,
        [Description("Wiredine")]
        Wiredine = 25,
        [Description("Life Deleter")]
        LifeDeleter = 26,
        [Description("Balduel")]
        Balduel = 27,
        [Description("Dragerduel")]
        Dragerduel = 28,
        [Description("Jurafaduel")]
        Jurafaduel = 29,
        [Description("Crawler")]
        Crawler = 30,
        [Description("Carrion Cr")]
        CarrionCr = 31,
        [Description("Caterpillar")]
        Caterpillar = 32,
        [Description("Blob")]
        Blob = 33,
        [Description("Zol Slug")]
        ZolSlug = 34,
        [Description("Jr. Ooze")]
        JrOoze = 35,
        [Description("Meta Slug")]
        MetaSlug = 36,
        [Description("Snow Slug")]
        SnowSlug = 37,
        [Description("Fract Ooze")]
        FractOoze = 38,
        [Description("Tower")]
        Tower = 39,
        [Description("C-Ray Tube")]
        CRayTube = 40,
        [Description("Arm Drone")]
        ArmDrone = 41,
        [Description("Satellite Minion")]
        SatelliteMinion = 42,
        [Description("Star Drone")]
        StarDrone = 43,
        [Description("Float Mine 1")]
        FloatMine1 = 44,
        [Description("Command Ball")]
        CommandBall = 45,
        [Description("Vorpal Sphere")]
        VorpalSphere = 46,
        [Description("Warren 286")]
        Warren286 = 47,
        [Description("Siren 386")]
        Siren386 = 48,
        [Description("Browren 486")]
        Browren486 = 49,
        [Description("Float Mine 2")]
        FloatMine2 = 50,
        [Description("Loader")]
        Loader = 51,
        [Description("Debugger")]
        Debugger = 52,
        [Description("Dominator")]
        Dominator = 53,
        [Description("Whistle")]
        Whistle = 54,
        [Description("Tracer")]
        Tracer = 55,
        [Description("Sand Newt")]
        SandNewt = 56,
        [Description("Mistral Gecko")]
        MistralGecko = 57,
        [Description("Flame Newt")]
        FlameNewt = 58,
        [Description("Stone Heads")]
        StoneHeads = 59,
        [Description("Crimson Heads")]
        CrimsonHeads = 60,
        [Description("Blind Heads")]
        BlindHeads = 61,
        [Description("Abe Frog")]
        AbeFrog = 62,
        [Description("Gerotlux")]
        Gerotlux = 63,
        [Description("Dark Marauder")]
        DarkMarauder = 64,
        [Description("Death Bearer")]
        DeathBearer = 65,
        [Description("Chaos Bringer")]
        ChaosBringer = 66,
        [Description("Scorpirus")]
        Scorpirus = 67,
        [Description("Rajago")]
        Rajago = 68,
        [Description("Biter Fly")]
        BiterFly = 69,
        [Description("Shadow Saber")]
        ShadowSaber = 70,
        [Description("Frost Saber")]
        FrostSaber = 71,
        [Description("Blood Saber")]
        BloodSaber = 72,
        [Description("Dimension Worm")]
        DimensionWorm = 73,
        [Description("Outer Beast")]
        OuterBeast = 74,
        [Description("Flatter Plant")]
        FlatterPlant = 75,
        [Description("Fly Screamer")]
        FlyScreamer = 76,
        [Description("Technique Plant")]
        TechniquePlant = 77,
        [Description("Toadstool")]
        Toadstool = 78,
        [Description("Shrieker")]
        Shrieker = 79,
        [Description("Sand Worm")]
        SandWorm = 80,
        [Description("Desert Leech")]
        DesertLeech = 81,
        [Description("Leviathan")]
        Leviathan = 82,
        [Description("Ripper")]
        Ripper = 83,
        [Description("Blade Right")]
        BladeRight = 84,
        [Description("Piercer")]
        Piercer = 85,
        [Description("Haken Left")]
        HakenLeft = 86,
        [Description("Twin Arms")]
        TwinArms = 87,
        [Description("Soldier Fiend")]
        SoldierFiend = 88,
        [Description("Ismounos")]
        Ismounos = 89,
        [Description("Depcen")]
        Depcen = 90,
        [Description("Hewgilla")]
        Hewgilla = 91,
        [Description("Elmelew")]
        Elmelew = 92,
        [Description("Mini Worm")]
        MiniWorm = 93,
        [Description("Infant Worm 1")]
        InfantWorm1 = 94,
        [Description("Snow Worm")]
        SnowWorm = 95,
        [Description("Centaur")]
        Centaur = 96,
        [Description("King Saber")]
        KingSaber = 97,
        [Description("Dark Rider")]
        DarkRider = 98,
        [Description("Technique User")]
        TechniqueUser = 99,
        [Description("Technique Master")]
        TechniqueMaster = 100,
        [Description("Dark Witch")]
        DarkWitch = 101,
        [Description("Speard")]
        Speard = 102,
        [Description("Zios Guard")]
        ZiosGuard = 103,
        [Description("Acacia")]
        Acacia = 104,
        [Description("Shadow Mirage")]
        ShadowMirage = 105,
        [Description("Haunt")]
        Haunt = 106,
        [Description("Spector")]
        Spector = 107,
        [Description("Phantom")]
        Phantom = 108,
        [Description("Zombie")]
        Zombie = 109,
        [Description("Ghoul")]
        Ghoul = 110,
        [Description("Chaos Sorcerer")]
        ChaosSorcerer = 111,
        [Description("Illusionist")]
        Illusionist = 112,
        [Description("Imagio Mage")]
        ImagioMage = 113,
        [Description("Juza")]
        Juza = 114,
        [Description("Greneris")]
        Greneris = 115,
        [Description("Radhin")]
        Radhin = 116,
        [Description("Gy-Laguiah")]
        GyLaguiah = 117,
        [Description("Lw-Addmer")]
        LwAddmer = 118,
        [Description("Cula-Bellr")]
        CulaBellr = 119,
        [Description("De-Vars")]
        DeVars = 120,
        [Description("Sa-Lews")]
        SaLews = 121,
        [Description("D-Elm-Lars")]
        DElmLars = 122,
        [Description("Xe-A-Thoul")]
        XeAThoul = 123,
        [Description("Le-Faw-Gan")]
        LeFawGan = 124,
        [Description("Gi-Le-Farg")]
        GiLeFarg = 125,
        [Description("Alys (Boss)")]
        AlysBoss = 126,
        [Description("Re-Faze")]
        ReFaze = 127,
        [Description("Lashiec")]
        Lashiec = 128,
        [Description("Carnivorous Tree")]
        CarnivorousTree = 129,
        [Description("Dark Force 1")]
        DarkForce1 = 130,
        [Description("Dark Force 2")]
        DarkForce2 = 131,
        [Description("Dark Force 3")]
        DarkForce3 = 132,
        [Description("Profound Darkness 1")]
        ProfoundDarkness1 = 133,
        [Description("Profound Darkness 2")]
        ProfoundDarkness2 = 134,
        [Description("Profound Darkness 3")]
        ProfoundDarkness3 = 135,
        [Description("Sand Worm (Guild Job)")]
        SandWormGuildJob = 136,
        [Description("Fract Ooze (Boss)")]
        FractOozeBoss = 137,
        [Description("Chaos Sorcerer (Boss)")]
        ChaosSorcererBoss = 138,
        [Description("Zio 3")]
        Zio3 = 139,
        [Description("Zio 2")]
        Zio2 = 140,
        [Description("Dezo Owl")]
        DezoOwl = 141,
        [Description("Sky Tiara")]
        SkyTiara = 142,
        [Description("Owl Talon")]
        OwlTalon = 143,
        [Description("Snow Mole")]
        SnowMole = 144,
        [Description("Red Mole")]
        RedMole = 145,
        [Description("Hungry Mole")]
        HungryMole = 146,
        [Description("Rappy")]
        Rappy = 147,
        [Description("Blue Rappy")]
        BlueRappy = 148,
        [Description("King Rappy")]
        KingRappy = 149,
        [Description("Infant Worm 2")]
        InfantWorm2 = 150,
        [Description("Prophallus")]
        Prophallus = 151,
        [Description("Zio 1")]
        Zio1 = 152
    }

    /// <summary>
    /// Eenemy skill type enumeration
    /// </summary>
    public enum EnemySkillType
    {
        [Description("None")]
        None = 0,
        [Description("Normal Attack")]
        NormalAttack = 1,
        [Description("Flame Bolt")]
        FlameBolt = 2,
        [Description("Rail Gun")]
        RailGun = 3,
        [Description("Laser Cannon")]
        LaserCannon = 4,
        [Description("Lightning")]
        Lightning = 5,
        [Description("Fission")]
        Fission = 6,
        [Description("Fission")]
        Fission1 = 7,
        [Description("Spiral Blade")]
        SpiralBlade = 8,
        [Description("Motor Cannon")]
        MotorCannon = 9,
        [Description("Twin Claw")]
        TwinClaw = 10,
        [Description("Stasis Ball")]
        StasisBall = 11,
        [Description("Combine")]
        Combine = 12,
        [Description("Combine")]
        Combine1 = 13,
        [Description("Micro Missles")]
        MicroMissles = 14,
        [Description("Flame Launcher")]
        FlameLauncher = 15,
        [Description("Thread")]
        Thread = 16,
        [Description("Poison")]
        Poison = 17,
        [Description("Fusion")]
        Fusion = 18,
        [Description("Cell Split")]
        CellSplit = 19,
        [Description("Warning")]
        Warning = 20,
        [Description("Charge Cannon")]
        ChargeCannon = 21,
        [Description("Flash")]
        Flash = 22,
        [Description("Waiting")]
        Waiting = 23,
        [Description("Explosion")]
        Explosion = 24,
        [Description("Detonation")]
        Detonation = 25,
        [Description("Cyanic Bomb")]
        CyanicBomb = 26,
        [Description("Fission")]
        Fission2 = 27,
        [Description("Flare Shot")]
        FlareShot = 28,
        [Description("Barrier")]
        Barrier = 29,
        [Description("Spark")]
        Spark = 30,
        [Description("Double Slash")]
        DoubleSlash = 31,
        [Description("Phonon Smasher")]
        PhononSmasher = 32,
        [Description("Fire Breath")]
        FireBreath = 33,
        [Description("Ray Breath")]
        RayBreath = 34,
        [Description("Super Sonic")]
        SuperSonic = 35,
        [Description("Poison Mist")]
        PoisonMist = 36,
        [Description("Sleep Gas")]
        SleepGas = 37,
        [Description("Shift")]
        Shift = 38,
        [Description("Saner")]
        Saner = 39,
        [Description("Doran")]
        Doran = 40,
        [Description("Seals")]
        Seals = 41,
        [Description("Rimit")]
        Rimit = 42,
        [Description("Needle")]
        Needle = 43,
        [Description("Air Slash")]
        AirSlash = 44,
        [Description("Deban")]
        Deban = 45,
        [Description("Gi-Wat")]
        GiWat = 46,
        [Description("Vol")]
        Vol = 47,
        [Description("Distortion")]
        Distortion = 48,
        [Description("Gra")]
        Gra = 49,
        [Description("Gi-Gra")]
        GiGra = 50,
        [Description("Acid Breath")]
        AcidBreath = 51,
        [Description("Voice")]
        Voice = 52,
        [Description("Gi-Zan")]
        GiZan = 53,
        [Description("Strange Light")]
        StrangeLight = 54,
        [Description("Sand Storm")]
        SandStorm = 55,
        [Description("Earthquake")]
        Earthquake = 56,
        [Description("Maelstrom")]
        Maelstrom = 57,
        [Description("Combine")]
        Combine2 = 58,
        [Description("Combine")]
        Combine3 = 59,
        [Description("Blade Shine")]
        BladeShine = 60,
        [Description("Haken Bolt")]
        HakenBolt = 61,
        [Description("Gi-Res")]
        GiRes = 62,
        [Description("Flood Breath")]
        FloodBreath = 63,
        [Description("Wat")]
        Wat = 64,
        [Description("Nothing")]
        Nothing = 65,
        [Description("Ray-Spear")]
        RaySpear = 66,
        [Description("Throw Lance")]
        ThrowLance = 67,
        [Description("Foi")]
        Foi = 68,
        [Description("Res")]
        Res = 69,
        [Description("Sar")]
        Sar = 70,
        [Description("Zan")]
        Zan = 71,
        [Description("Gi-Foi")]
        GiFoi = 72,
        [Description("Gi-Sar")]
        GiSar = 73,
        [Description("Stardust")]
        Stardust = 74,
        [Description("Shadow Bind")]
        ShadowBind = 75,
        [Description("Evil Eye")]
        EvilEye = 76,
        [Description("Corrosion")]
        Corrosion = 77,
        [Description("Death Spell")]
        DeathSpell = 78,
        [Description("Hewn")]
        Hewn = 79,
        [Description("Bad Smell")]
        BadSmell = 80,
        [Description("Mind Blast")]
        MindBlast = 81,
        [Description("Tandle")]
        Tandle = 82,
        [Description("Nightmare")]
        Nightmare = 83,
        [Description("Black Wave")]
        BlackWave = 84,
        [Description("Legeon")]
        Legeon = 85,
        [Description("Force Flash")]
        ForceFlash = 86,
        [Description("Gelun")]
        Gelun = 87,
        [Description("Light Breath")]
        LightBreath = 88,
        [Description("Disrupt Arm")]
        DisruptArm = 89,
        [Description("Flaeli")]
        Flaeli = 90,
        [Description("Bindwa")]
        Bindwa = 91,
        [Description("Thunder Blast")]
        ThunderBlast = 92,
        [Description("Tandil")]
        Tandil = 93,
        [Description("Megid")]
        Megid = 94,
        [Description("Thunder Halberd")]
        ThunderHalberd = 95,
        [Description("Possession")]
        Possession = 96,
        [Description("Another Gate")]
        AnotherGate = 97,
        [Description("Reinforce")]
        Reinforce = 98,
        [Description("Burst Rocket")]
        BurstRocket = 99,
        [Description("Shadow Breath")]
        ShadowBreath = 100,
        [Description("Light Shower")]
        LightShower = 101,
        [Description("Destro Cray")]
        DestroCray = 102,
        [Description("Nothing")]
        Nothing1 = 103,
        [Description("Nothing")]
        Nothing2 = 104,
        [Description("Cancelling")]
        Cancelling = 105,
        [Description("Wind Storm")]
        WindStorm = 106,
        [Description("Magic Barrier")]
        MagicBarrier = 107,
        [Description("Black Wave (Triggered)")]
        BlackWaveTriggered = 108,
        [Description("Round Eyes")]
        RoundEyes = 109,
        [Description("Lovel Eyes")]
        LovelEyes = 110,
        [Description("Casting")]
        Casting = 111,
        [Description("Black Wave (Normal)")]
        BlackWaveNormal = 112
    }

    /// <summary>
    /// Item type enumeration
    /// </summary>
    public enum ItemType : int
    {
        [Description("None")]
        None = 0,
        [Description("Dagger")]
        Dagger = 1,
        [Description("Hunting Knife")]
        HuntingKnife = 2,
        [Description("Boomerang")]
        Boomerang = 3,
        [Description("Leather Clothes")]
        LeatherClothes = 4,
        [Description("Leather Helmet")]
        LeatherHelmet = 5,
        [Description("Leather Crown")]
        LeatherCrown = 6,
        [Description("Leather Band")]
        LeatherBand = 7,
        [Description("Steel Sword")]
        SteelSword = 8,
        [Description("Slasher")]
        Slasher = 9,
        [Description("Leather Shield")]
        LeatherShield = 10,
        [Description("Carbon Fiber Suit")]
        CarbonFiberSuit = 11,
        [Description("Carbon Fiber Shield")]
        CarbonFiberShield = 12,
        [Description("Carbon Fiber Helmet")]
        CarbonFiberHelmet = 13,
        [Description("Carbon Fiber Crown")]
        CarbonFiberCrown = 14,
        [Description("Circlet")]
        Circlet = 15,
        [Description("Wood Cane")]
        WoodCane = 16,
        [Description("White Mantle")]
        WhiteMantle = 17,
        [Description("Titanium Sword")]
        TitaniumSword = 18,
        [Description("Titanium Dagger")]
        TitaniumDagger = 19,
        [Description("Titanium Slasher")]
        TitaniumSlasher = 20,
        [Description("Titanium Axe")]
        TitaniumAxe = 21,
        [Description("Broad Axe")]
        BroadAxe = 22,
        [Description("Titanium Mail")]
        TitaniumMail = 23,
        [Description("Titanium Shield")]
        TitaniumShield = 24,
        [Description("Titanium Helm")]
        TitaniumHelm = 25,
        [Description("Titanium Crown")]
        TitaniumCrown = 26,
        [Description("Blood Axe")]
        BloodAxe = 27,
        [Description("Graphite Suit")]
        GraphiteSuit = 28,
        [Description("Graphite Shield")]
        GraphiteShield = 29,
        [Description("Ceramic Sword")]
        CeramicSword = 30,
        [Description("Graphite Crown")]
        GraphiteCrown = 31,
        [Description("Claw")]
        Claw = 32,
        [Description("Ceramic Knife")]
        CeramicKnife = 33,
        [Description("Ceramic Shield")]
        CeramicShield = 34,
        [Description("Laser Slasher")]
        LaserSlasher = 35,
        [Description("Saber Claw")]
        SaberClaw = 36,
        [Description("Struggle Axe")]
        StruggleAxe = 37,
        [Description("Ceramic Mail")]
        CeramicMail = 38,
        [Description("Ceramic Helmet")]
        CeramicHelmet = 39,
        [Description("Laser Sword")]
        LaserSword = 40,
        [Description("Laser Claw")]
        LaserClaw = 41,
        [Description("Laser Barrier")]
        LaserBarrier = 42,
        [Description("Impactor")]
        Impactor = 43,
        [Description("Titanium Armor")]
        TitaniumArmor = 44,
        [Description("Head Gear")]
        HeadGear = 45,
        [Description("Stun Shot")]
        StunShot = 46,
        [Description("Laser Axe")]
        LaserAxe = 47,
        [Description("Laser Knife")]
        LaserKnife = 48,
        [Description("Ceramic Armor")]
        CeramicArmor = 49,
        [Description("Titanium Gear")]
        TitaniumGear = 50,
        [Description("Psychic Mail")]
        PsychicMail = 51,
        [Description("Psychic Shield")]
        PsychicShield = 52,
        [Description("Psychic Crown")]
        PsychicCrown = 53,
        [Description("Psychic Circlet")]
        PsychicCirclet = 54,
        [Description("Force Cane")]
        ForceCane = 55,
        [Description("Psychic Robe")]
        PsychicRobe = 56,
        [Description("Psycho Wand")]
        PsychoWand = 57,
        [Description("Frade Mantle")]
        FradeMantle = 58,
        [Description("Wave Shot")]
        WaveShot = 59,
        [Description("Space Armor")]
        SpaceArmor = 60,
        [Description("Ceramic Gear")]
        CeramicGear = 61,
        [Description("Plasma Rifle")]
        PlasmaRifle = 62,
        [Description("Pulse Laser")]
        PulseLaser = 63,
        [Description("Plasma Sword")]
        PlasmaSword = 64,
        [Description("Plasma Claw")]
        PlasmaClaw = 65,
        [Description("Plasma Dagger")]
        PlasmaDagger = 66,
        [Description("Plasma Field")]
        PlasmaField = 67,
        [Description("Silver Rod")]
        SilverRod = 68,
        [Description("Silver Mantle")]
        SilverMantle = 69,
        [Description("Silver Circlet")]
        SilverCirclet = 70,
        [Description("Silver Mail")]
        SilverMail = 71,
        [Description("Silver Shield")]
        SilverShield = 72,
        [Description("Silver Helmet")]
        SilverHelmet = 73,
        [Description("Silver Crown")]
        SilverCrown = 74,
        [Description("Zirconian Gear")]
        ZirconianGear = 75,
        [Description("Napalm Shot")]
        NapalmShot = 76,
        [Description("Zirconian Armor")]
        ZirconianArmor = 77,
        [Description("Flame Sword")]
        FlameSword = 78,
        [Description("Thunder Claw")]
        ThunderClaw = 79,
        [Description("Tornado Dagger")]
        TornadoDagger = 80,
        [Description("Dream Rod")]
        DreamRod = 81,
        [Description("Phantom Robe")]
        PhantomRobe = 82,
        [Description("Silver Tusk")]
        SilverTusk = 83,
        [Description("Pulse Vulcan")]
        PulseVulcan = 84,
        [Description("Composite Armor")]
        CompositeArmor = 85,
        [Description("Composite Gear")]
        CompositeGear = 86,
        [Description("Reflect Mail")]
        ReflectMail = 87,
        [Description("Reflect Shield")]
        ReflectShield = 88,
        [Description("Reflect Robe")]
        ReflectRobe = 89,
        [Description("Laconian Sword")]
        LaconianSword = 90,
        [Description("Laconian Dagger")]
        LaconianDagger = 91,
        [Description("Laconian Claw")]
        LaconianClaw = 92,
        [Description("Laconian Slasher")]
        LaconianSlasher = 93,
        [Description("Guardian Rod")]
        GuardianRod = 94,
        [Description("Plasma Launcher")]
        PlasmaLauncher = 95,
        [Description("Elastic Armor")]
        ElasticArmor = 96,
        [Description("Elastic Gear")]
        ElasticGear = 97,
        [Description("Laconian Rod")]
        LaconianRod = 98,
        [Description("Genocyde Claw")]
        GenocydeClaw = 99,
        [Description("Swift Helmet")]
        SwiftHelmet = 100,
        [Description("Moon Slasher")]
        MoonSlasher = 101,
        [Description("Power Shield")]
        PowerShield = 102,
        [Description("Laconian Mail")]
        LaconianMail = 103,
        [Description("Laconian Helmet")]
        LaconianHelmet = 104,
        [Description("Laconian Crown")]
        LaconianCrown = 105,
        [Description("Laconian Circlet")]
        LaconianCirclet = 106,
        [Description("Laconian Shield")]
        LaconianShield = 107,
        [Description("Cybernetic Suit")]
        CyberneticSuit = 108,
        [Description("Guardian Sword")]
        GuardianSword = 109,
        [Description("Photon Eraser")]
        PhotonEraser = 110,
        [Description("Laconian Armor")]
        LaconianArmor = 111,
        [Description("Laconian Gear")]
        LaconianGear = 112,
        [Description("Mahlay Dagger")]
        MahlayDagger = 113,
        [Description("Guardian Claw")]
        GuardianClaw = 114,
        [Description("Guardian Armor")]
        GuardianArmor = 115,
        [Description("Guardian Robe")]
        GuardianRobe = 116,
        [Description("Guardian Mail")]
        GuardianMail = 117,
        [Description("Unknown Ring")]
        UnknownRing = 118,
        [Description("Elsydeon")]
        Elsydeon = 119,
        [Description("Laconian Axe")]
        LaconianAxe = 120,
        [Description("Sonic Buster")]
        SonicBuster = 121,
        [Description("Defeat Axe")]
        DefeatAxe = 122,
        [Description("Spiral Slasher")]
        SpiralSlasher = 123,
        [Description("Mahlay Mail")]
        MahlayMail = 124,
        [Description("Monomate")]
        Monomate = 125,
        [Description("Dimate")]
        Dimate = 126,
        [Description("Trimate")]
        Trimate = 127,
        [Description("Antidote")]
        Antidote = 128,
        [Description("Cure Paralysis")]
        CureParalysis = 129,
        [Description("Moon Dew")]
        MoonDew = 130,
        [Description("Star Dew")]
        StarDew = 131,
        [Description("Telepipe")]
        Telepipe = 132,
        [Description("Escapipe")]
        Escapipe = 133,
        [Description("Sol Dew")]
        SolDew = 134,
        [Description("Guardian Shield")]
        GuardianShield = 135,
        [Description("Mahlay Shield")]
        MahlayShield = 136,
        [Description("Shadow Blade")]
        ShadowBlade = 137,
        [Description("Alis Sword")]
        AlisSword = 138,
        [Description("Dynamite")]
        Dynamite = 139,
        [Description("Map")]
        Map = 140,
        [Description("Alshline")]
        Alshline = 141,
        [Description("Eclipse Torch")]
        EclipseTorch = 142,
        [Description("Aero Prism")]
        AeroPrism = 143,
        [Description("Repair Kit")]
        RepairKit = 144,
        [Description("Shortcake")]
        Shortcake = 145,
        [Description("Pengu Feed")]
        PenguFeed = 146,
        [Description("Perolymate")]
        Perolymate = 147,
        [Description("Pennant")]
        Pennant = 148,
        [Description("Wood Carving")]
        WoodCarving = 149,
        [Description("Landrover")]
        Landrover = 150,
        [Description("Ice Digger")]
        IceDigger = 151,
        [Description("Hydrofoil")]
        Hydrofoil = 152,
        [Description("Control Key")]
        ControlKey = 153,
        [Description("Canceller")]
        Canceller = 154,
        [Description("Palma Ring")]
        PalmaRing = 155,
        [Description("Motavia Ring")]
        MotaviaRing = 156,
        [Description("Dezolis Ring")]
        DezolisRing = 157,
        [Description("Rykros Ring")]
        RykrosRing = 158,
        [Description("Algo Ring")]
        AlgoRing = 159,
        [Description("Mahlay Ring")]
        MahlayRing = 160
    }

    /// <summary>
    /// Map type enumeration
    /// </summary>
    public enum MapType : int
    {
        [Description("Motavia")]
        Motavia = 0,
        [Description("Dezolis")]
        Dezolis = 1,
        [Description("Rykros")]
        Rykros = 2,
        [Description("Piata")]
        Piata = 16,
        [Description("Piata Academy 1")]
        PiataAcademy1 = 17,
        [Description("Piata Academy 2")]
        PiataAcademy2 = 18,
        [Description("Piata Academy F1 1")]
        PiataAcademyF1Area1 = 19,
        [Description("Piata Academy F1 2")]
        PiataAcademyF1Area2 = 20,
        [Description("Piata Academy B1")]
        PiataAcademyB1 = 21,
        [Description("Piata Academy B2")]
        PiataAcademyB2 = 22,
        [Description("Piata Academy B3")]
        PiataAcademyB3 = 23,
        [Description("Piata Dorm")]
        PiataDorm = 24,
        [Description("Piata Inn")]
        PiataInn = 25,
        [Description("Piata House 1")]
        PiataHouse1 = 26,
        [Description("Piata Item Shop")]
        PiataItemShop = 27,
        [Description("Piata House 2")]
        PiataHouse2 = 28,
        [Description("Mile")]
        Mile = 29,
        [Description("Mile Destroyed")]
        MileDestroyed = 30,
        [Description("Mile Weapon Shop")]
        MileWeaponShop = 31,
        [Description("Mile House 1")]
        MileHouse1 = 32,
        [Description("Mile Item Shop")]
        MileItemShop = 33,
        [Description("Mile House 2")]
        MileHouse2 = 34,
        [Description("Mile Inn")]
        MileInn = 35,
        [Description("Zema")]
        Zema = 36,
        [Description("Zema House 1")]
        ZemaHouse1 = 37,
        [Description("Zema Weapon Shop")]
        ZemaWeaponShop = 38,
        [Description("Zema Inn")]
        ZemaInn = 39,
        [Description("Zema House 2")]
        ZemaHouse2 = 40,
        [Description("Zema House 2 B1")]
        ZemaHouse2B1 = 41,
        [Description("Zema Item Shop")]
        ZemaItemShop = 42,
        [Description("Birth Valley")]
        BirthValley = 43,
        [Description("Birth Valley B1")]
        BirthValleyB1 = 44,
        [Description("Valley Maze Unused")]
        ValleyMazeUnused = 45,
        [Description("Krup")]
        Krup = 57,
        [Description("Krup Kindergarten")]
        KrupKindergarten = 58,
        [Description("Krup Weapon Shop")]
        KrupWeaponShop = 59,
        [Description("Krup Item Shop")]
        KrupItemShop = 60,
        [Description("Krup House")]
        KrupHouse = 61,
        [Description("Krup Inn")]
        KrupInn = 62,
        [Description("Krup Inn F1")]
        KrupInnF1 = 63,
        [Description("Molcum")]
        Molcum = 64,
        [Description("Tonoe")]
        Tonoe = 65,
        [Description("Tonoe Storage Room")]
        TonoeStorageRoom = 66,
        [Description("Tonoe Gryz House")]
        TonoeGryzHouse = 67,
        [Description("Tonoe House 1")]
        TonoeHouse1 = 68,
        [Description("Tonoe House 2")]
        TonoeHouse2 = 69,
        [Description("Tonoe Inn")]
        TonoeInn = 70,
        [Description("Tonoe B1")]
        TonoeBasementB1 = 71,
        [Description("Tonoe Basement B2")]
        TonoeBasementB2 = 72,
        [Description("Tonoe Basement B3")]
        TonoeBasementB3 = 73,
        [Description("Tonoe Basement B4")]
        TonoeBasementB4 = 74,
        [Description("Nalya")]
        Nalya = 75,
        [Description("Nalya House 1")]
        NalyaHouse1 = 76,
        [Description("Nalya House 2")]
        NalyaHouse2 = 77,
        [Description("Nalya Item Shop")]
        NalyaItemShop = 78,
        [Description("Nalya House 3")]
        NalyaHouse3 = 79,
        [Description("Nalya House 4")]
        NalyaHouse4 = 80,
        [Description("Nalya House 5")]
        NalyaHouse5 = 81,
        [Description("Nalya Inn")]
        NalyaInn = 82,
        [Description("Nalya Inn F1")]
        NalyaInnF1 = 83,
        [Description("Aiedo")]
        Aiedo = 84,
        [Description("Aiedo Bakery")]
        AiedoBakery = 85,
        [Description("Aiedo Bakery B1")]
        AiedoBakeryB1 = 86,
        [Description("Hunters Guild")]
        HuntersGuild = 87,
        [Description("Hunters Guild Storage")]
        HuntersGuildStorage = 88,
        [Description("Strip Club Dressing Room")]
        StripClubDressingRoom = 89,
        [Description("Strip Club")]
        StripClub = 90,
        [Description("Aiedo Weapon Shop")]
        AiedoWeaponShop = 91,
        [Description("Aiedo Prison")]
        AiedoPrison = 92,
        [Description("Aiedo House 1")]
        AiedoHouse1 = 93,
        [Description("Chaz House")]
        ChazHouse = 94,
        [Description("Aiedo House 2")]
        AiedoHouse2 = 95,
        [Description("Aiedo House 3")]
        AiedoHouse3 = 96,
        [Description("Aiedo House 4")]
        AiedoHouse4 = 97,
        [Description("Aiedo House 5")]
        AiedoHouse5 = 98,
        [Description("Aiedo Supermarket")]
        AiedoSupermarket = 99,
        [Description("Aiedo Pub")]
        AiedoPub = 100,
        [Description("Rocky House")]
        RockyHouse = 101,
        [Description("Aiedo House 6")]
        AiedoHouse6 = 102,
        [Description("Aiedo House 7")]
        AiedoHouse7 = 103,
        [Description("Kadary")]
        Kadary = 104,
        [Description("Kadary Church")]
        KadaryChurch = 105,
        [Description("Kadary Pub")]
        KadaryPub = 106,
        [Description("Kadary Pub F1")]
        KadaryPubF1 = 107,
        [Description("Kadary Storage Room")]
        KadaryStorageRoom = 108,
        [Description("Kadary House 1")]
        KadaryHouse1 = 109,
        [Description("Kadary House 2")]
        KadaryHouse2 = 110,
        [Description("Kadary House 3")]
        KadaryHouse3 = 111,
        [Description("Kadary Item Shop")]
        KadaryItemShop = 112,
        [Description("Kadary Inn")]
        KadaryInn = 113,
        [Description("Kadary Inn F1")]
        KadaryInnF1 = 114,
        [Description("Monsen")]
        Monsen = 115,
        [Description("Monsen Inn")]
        MonsenInn = 116,
        [Description("Monsen House 1")]
        MonsenHouse1 = 117,
        [Description("Monsen House 2")]
        MonsenHouse2 = 118,
        [Description("Monsen House 3")]
        MonsenHouse3 = 119,
        [Description("Monsen House 4")]
        MonsenHouse4 = 120,
        [Description("Monsen House 5")]
        MonsenHouse5 = 121,
        [Description("Monsen Item Shop")]
        MonsenItemShop = 122,
        [Description("Termi")]
        Termi = 123,
        [Description("Termi Item Shop")]
        TermiItemShop = 124,
        [Description("Termi House 1")]
        TermiHouse1 = 125,
        [Description("Termi Weapon Shop")]
        TermiWeaponShop = 126,
        [Description("Termi Inn")]
        TermiInn = 127,
        [Description("Termi House 2")]
        TermiHouse2 = 128,
        [Description("Passageway")]
        Passageway = 129,
        [Description("Zio Fort Area 1")]
        ZioFortArea1 = 130,
        [Description("Zio Fort Area 2")]
        ZioFortArea2 = 131,
        [Description("Zio Fort F1")]
        ZioFortF1 = 132,
        [Description("Zio Fort F2 West")]
        ZioFortF2West = 133,
        [Description("Zio Fort West Tunnel")]
        ZioFortWestTunnel = 134,
        [Description("Zio Fort Juza Room")]
        ZioFortJuzaRoom = 135,
        [Description("Zio Fort East Tunnel")]
        ZioFortEastTunnel = 136,
        [Description("Zio Fort F2 East")]
        ZioFortF2East = 137,
        [Description("Zio Fort F3")]
        ZioFortF3 = 138,
        [Description("Zio Fort F4")]
        ZioFortF4 = 139,
        [Description("Ladea Tower")]
        LadeaTower = 140,
        [Description("Ladea Tower F1")]
        LadeaTowerF1 = 141,
        [Description("Ladea Tower F2")]
        LadeaTowerF2 = 142,
        [Description("Ladea Tower F3")]
        LadeaTowerF3 = 143,
        [Description("Ladea Tower F4")]
        LadeaTowerF4 = 144,
        [Description("Ladea Tower F5")]
        LadeaTowerF5 = 145,
        [Description("Island Cave 1")]
        IslandCave1 = 146,
        [Description("Island Cave F1")]
        IslandCaveF1 = 147,
        [Description("Island Cave F1 2")]
        IslandCaveF1Area2 = 148,
        [Description("Island Cave 2")]
        IslandCave2 = 149,
        [Description("Island Cave B1")]
        IslandCaveB1 = 150,
        [Description("Island Cave F2")]
        IslandCaveF2 = 151,
        [Description("Island Cave F3")]
        IslandCaveF3 = 152,
        [Description("Soldiers Temple Outside")]
        SoldiersTempleOutside = 153,
        [Description("Soldiers Temple")]
        SoldiersTemple = 154,
        [Description("Valley Maze 1")]
        ValleyMaze1 = 155,
        [Description("Valley Maze 2")]
        ValleyMaze2 = 156,
        [Description("Valley Maze 3")]
        ValleyMaze3 = 157,
        [Description("Valley Maze 4")]
        ValleyMaze4 = 158,
        [Description("Valley Maze 5")]
        ValleyMaze5 = 159,
        [Description("Valley Maze 6")]
        ValleyMaze6 = 160,
        [Description("Valley Maze 7")]
        ValleyMaze7 = 161,
        [Description("Bio Plant 1")]
        BioPlant1 = 162,
        [Description("Bio Plant 2")]
        BioPlant2 = 163,
        [Description("Bio Plant 3")]
        BioPlant3 = 164,
        [Description("Bio Plant B1")]
        BioPlantB1 = 166,
        [Description("Bio Plant B2 1")]
        BioPlantB2Area1 = 167,
        [Description("Bio Plant B2 2")]
        BioPlantB2Area2 = 168,
        [Description("Bio Plant B3 1")]
        BioPlantB3Area1 = 169,
        [Description("Bio Plant B3 2")]
        BioPlantB3Area2 = 170,
        [Description("Bio Plant B4 1")]
        BioPlantB4Area1 = 171,
        [Description("Bio Plant B4 2")]
        BioPlantB4Area2 = 172,
        [Description("Bio Plant B4 3")]
        BioPlantB4Area3 = 173,
        [Description("Wreckage 1")]
        Wreckage1 = 174,
        [Description("Wreckage 2")]
        Wreckage2 = 175,
        [Description("Wreckage 3")]
        Wreckage3 = 176,
        [Description("Wreckage F1 1")]
        WreckageF1Area1 = 177,
        [Description("Wreckage F1 2")]
        WreckageF1Area2 = 178,
        [Description("Wreckage F2 1")]
        WreckageF2Area1 = 179,
        [Description("Wreckage F2 2")]
        WreckageF2Area2 = 180,
        [Description("Wreckage F2 3")]
        WreckageF2Area3 = 181,
        [Description("Wreckage F2 4")]
        WreckageF2Area4 = 182,
        [Description("Machine Center")]
        MachineCenter = 183,
        [Description("Machine Center B1 1")]
        MachineCenterB1Area1 = 184,
        [Description("Machine Center B1 2")]
        MachineCenterB1Area2 = 185,
        [Description("Plate System")]
        PlateSystem = 186,
        [Description("Plate System F1")]
        PlateSystemF1 = 187,
        [Description("Plate System F2")]
        PlateSystemF2 = 188,
        [Description("Plate System F3")]
        PlateSystemF3 = 189,
        [Description("Plate System F4")]
        PlateSystemF4 = 190,
        [Description("Mota Spaceport")]
        MotaSpaceport = 191,
        [Description("Climate Center")]
        ClimateCenter = 192,
        [Description("Clim Center F1")]
        ClimateCenterF1 = 193,
        [Description("Clim Center F2")]
        ClimateCenterF2 = 194,
        [Description("Clim Center F3")]
        ClimateCenterF3 = 195,
        [Description("Weapon Plant")]
        WeaponPlant = 196,
        [Description("Weapon Plant F1")]
        WeaponPlantF1 = 197,
        [Description("Weapon Plant F2")]
        WeaponPlantF2 = 198,
        [Description("Weapon Plant F3")]
        WeaponPlantF3 = 199,
        [Description("Vahal Fort")]
        VahalFort = 200,
        [Description("Vahal Fort F1")]
        VahalFortF1 = 201,
        [Description("Vahal Fort F2")]
        VahalFortF2 = 202,
        [Description("Vahal Fort F3")]
        VahalFortF3 = 203,
        [Description("Nurvus 2")]
        Nurvus2 = 204,
        [Description("Nurvus 3")]
        Nurvus3 = 205,
        [Description("Nurvus B1 1")]
        NurvusB1Area1 = 206,
        [Description("Nurvus B2")]
        NurvusB2 = 207,
        [Description("Nurvus B3")]
        NurvusB3 = 208,
        [Description("Nurvus B1 2")]
        NurvusB1Area2 = 209,
        [Description("Nurvus B4 1")]
        NurvusB4Area1 = 210,
        [Description("Nurvus B4 2")]
        NurvusB4Area2 = 211,
        [Description("Dezo Spaceport")]
        DezoSpaceport = 212,
        [Description("Nurvus B5")]
        NurvusB5 = 213,
        [Description("Nurvus B3")]
        NurvusB3Tunnel = 214,
        [Description("Nurvus 1")]
        Nurvus1 = 215,
        [Description("Valley Maze Outside 1")]
        ValleyMazeOutside = 216,
        [Description("Valley Maze Outside 2")]
        ValleyMazeOutside2 = 217,
        [Description("Passageway Near Aiedo")]
        PassagewayNearAiedo = 218,
        [Description("Passageway Near Kadary")]
        PassagewayNearKadary = 219,
        [Description("Uzo")]
        Uzo = 224,
        [Description("Uzo House 1")]
        UzoHouse1 = 225,
        [Description("Uzo House 2")]
        UzoHouse2 = 226,
        [Description("Uzo Inn")]
        UzoInn = 227,
        [Description("Uzo House 3")]
        UzoHouse3 = 228,
        [Description("Uzo Item Shop")]
        UzoItemShop = 229,
        [Description("Torinco")]
        Torinco = 230,
        [Description("Culvers House")]
        CulversHouse = 231,
        [Description("Torinco House 1")]
        TorincoHouse1 = 232,
        [Description("Torinco House 2")]
        TorincoHouse2 = 233,
        [Description("Torinco Item Shop")]
        TorincoItemShop = 234,
        [Description("Torinco Inn")]
        TorincoInn = 235,
        [Description("Monsen Cave")]
        MonsenCave = 236,
        [Description("Rappy Cave")]
        RappyCave = 237,
        [Description("Le Roof Room")]
        LeRoofRoom = 240,
        [Description("Silence Tm")]
        SilenceTm = 241,
        [Description("Strength Tower")]
        StrengthTower = 242,
        [Description("Strength Tower F1")]
        StrengthTowerF1 = 243,
        [Description("Strength Tower F2")]
        StrengthTowerF2 = 244,
        [Description("Strength Tower F3")]
        StrengthTowerF3 = 245,
        [Description("Strength Tower F4")]
        StrengthTowerF4 = 246,
        [Description("Courage Tower")]
        CourageTower = 247,
        [Description("Courage Tower F1")]
        CourageTowerF1 = 248,
        [Description("Courage Tower F2")]
        CourageTowerF2 = 249,
        [Description("Courage Tower F3")]
        CourageTowerF3 = 250,
        [Description("Courage Tower F4")]
        CourageTowerF4 = 251,
        [Description("Anger Tower")]
        AngerTower = 252,
        [Description("Anger Tower F1")]
        AngerTowerF1 = 253,
        [Description("Anger Tower F2")]
        AngerTowerF2 = 254,
        [Description("The Edge 1")]
        TheEdge1 = 256,
        [Description("The Edge 2")]
        TheEdge2 = 257,
        [Description("The Edge 3")]
        TheEdge3 = 258,
        [Description("The Edge 4")]
        TheEdge4 = 259,
        [Description("The Edge 5")]
        TheEdge5 = 260,
        [Description("The Edge 6")]
        TheEdge6 = 261,
        [Description("The Edge 7")]
        TheEdge7 = 262,
        [Description("The Edge 8")]
        TheEdge8 = 263,
        [Description("The Edge 9")]
        TheEdge9 = 264,
        [Description("Tyler")]
        Tyler = 288,
        [Description("Tyler House 1")]
        TylerHouse1 = 289,
        [Description("Tyler Weapon Shop")]
        TylerWeaponShop = 290,
        [Description("Tyler Item Shop")]
        TylerItemShop = 291,
        [Description("Tyler House 2")]
        TylerHouse2 = 292,
        [Description("Tyler Inn")]
        TylerInn = 293,
        [Description("Zosa")]
        Zosa = 294,
        [Description("Zosa House 1")]
        ZosaHouse1 = 295,
        [Description("Zosa House 2")]
        ZosaHouse2 = 296,
        [Description("Zosa Weapon Shop")]
        ZosaWeaponShop = 297,
        [Description("Zosa Item Shop")]
        ZosaItemShop = 298,
        [Description("Zosa Inn")]
        ZosaInn = 299,
        [Description("Zosa House 3")]
        ZosaHouse3 = 300,
        [Description("Meese")]
        Meese = 301,
        [Description("Meese House 1")]
        MeeseHouse1 = 302,
        [Description("Meese Item Shop 2")]
        MeeseItemShop2 = 303,
        [Description("Meese Item Shop 1")]
        MeeseItemShop1 = 304,
        [Description("Meese Weapon Shop")]
        MeeseWeaponShop = 305,
        [Description("Meese Inn")]
        MeeseInn = 306,
        [Description("Meese Clinic")]
        MeeseClinic = 307,
        [Description("Meese Clinic F1")]
        MeeseClinicF1 = 308,
        [Description("Jut")]
        Jut = 310,
        [Description("Jut House 1")]
        JutHouse1 = 311,
        [Description("Jut House 2")]
        JutHouse2 = 312,
        [Description("Jut House 3")]
        JutHouse3 = 313,
        [Description("Jut House 4")]
        JutHouse4 = 314,
        [Description("Jut House 5")]
        JutHouse5 = 315,
        [Description("Jut Weapon Shop")]
        JutWeaponShop = 316,
        [Description("Jut Item Shop")]
        JutItemShop = 317,
        [Description("Jut House 6")]
        JutHouse6 = 318,
        [Description("Jut House6 F1")]
        JutHouse6F1 = 319,
        [Description("Jut House 7")]
        JutHouse7 = 320,
        [Description("Jut House 8")]
        JutHouse8 = 321,
        [Description("Jut Inn")]
        JutInn = 322,
        [Description("Jut Church")]
        JutChurch = 323,
        [Description("Ryuon")]
        Ryuon = 324,
        [Description("Ryuon Item Shop")]
        RyuonItemShop = 325,
        [Description("Ryuon Weapon Shop")]
        RyuonWeaponShop = 326,
        [Description("Ryuon House 1")]
        RyuonHouse1 = 327,
        [Description("Ryuon House 2")]
        RyuonHouse2 = 328,
        [Description("Ryuon House 3")]
        RyuonHouse3 = 329,
        [Description("Ryuon Pub")]
        RyuonPub = 330,
        [Description("Ryuon Inn")]
        RyuonInn = 331,
        [Description("Raja Temple")]
        RajaTemple = 332,
        [Description("Reshel 1")]
        Reshel1 = 333,
        [Description("Reshel 2")]
        Reshel2 = 334,
        [Description("Reshel 3")]
        Reshel3 = 335,
        [Description("Reshel 2 House")]
        Reshel2House = 336,
        [Description("Reshel 2 Weapon Shop")]
        Reshel2WeaponShop = 337,
        [Description("Reshel 3 House 1")]
        Reshel3House1 = 338,
        [Description("Reshel3Item Shop")]
        Reshel3ItemShop = 339,
        [Description("Reshel 3 House 2")]
        Reshel3House2 = 340,
        [Description("Reshel 3 Weapon Shop")]
        Reshel3WeaponShop = 341,
        [Description("Reshel 3 Inn")]
        Reshel3Inn = 342,
        [Description("Reshel 3 House 3")]
        Reshel3House3 = 343,
        [Description("Myst Vale 1")]
        MystVale1 = 344,
        [Description("Myst Vale 2")]
        MystVale2 = 345,
        [Description("Myst Vale 3")]
        MystVale3 = 346,
        [Description("Myst Vale 4")]
        MystVale4 = 347,
        [Description("Myst Vale 5")]
        MystVale5 = 348,
        [Description("Elsydeon Cave")]
        ElsydeonCave = 349,
        [Description("Elsydeon Cave B1")]
        ElsydeonCaveB1 = 350,
        [Description("Hangar")]
        Hangar = 351,
        [Description("Gumbious Entrance")]
        GumbiousEntrance = 352,
        [Description("Gumbious")]
        Gumbious = 353,
        [Description("Gumbious F1")]
        GumbiousF1 = 354,
        [Description("Gumbious B1")]
        GumbiousB1 = 355,
        [Description("Gumbious B2 1")]
        GumbiousB2Area1 = 356,
        [Description("Gumbious B2 2")]
        GumbiousB2Area2 = 357,
        [Description("Esp Mansion Entrance")]
        EspMansionEntrance = 358,
        [Description("Esp Mansion")]
        EspMansion = 359,
        [Description("Esp Mansion West Room")]
        EspMansionWestRoom = 360,
        [Description("Esp Mansion East Room")]
        EspMansionEastRoom = 361,
        [Description("Esp Mansion North")]
        EspMansionNorth = 362,
        [Description("Esp Mansion North East Room")]
        EspMansionNorthEastRoom = 363,
        [Description("Esp Mansion North West Room")]
        EspMansionNorthWestRoom = 364,
        [Description("Esp Mansion Courtyard")]
        EspMansionCourtyard = 365,
        [Description("Inner Sanctuary")]
        InnerSanctuary = 366,
        [Description("Inner Sanctuary B1")]
        InnerSanctuaryB1 = 367,
        [Description("Air Castle 6")]
        AirCastle6 = 368,
        [Description("Air Castle 1")]
        AirCastle1 = 369,
        [Description("Air Castle 2")]
        AirCastle2 = 370,
        [Description("Air Castle 3")]
        AirCastle3 = 371,
        [Description("Air Castle 4")]
        AirCastle4 = 372,
        [Description("Air Castle 5")]
        AirCastle5 = 373,
        [Description("Air Castle F1 9")]
        AirCastleF1Area9 = 374,
        [Description("Air Castle F1 5")]
        AirCastleF1Area5 = 375,
        [Description("Air Castle F1 2")]
        AirCastleF1Area2 = 376,
        [Description("Air Castle F1 10")]
        AirCastleF1Area10 = 377,
        [Description("Air Castle Inner")]
        AirCastleInner = 378,
        [Description("Air Castle F1 11")]
        AirCastleF1Area11 = 379,
        [Description("Air Castle F1 12")]
        AirCastleF1Area12 = 380,
        [Description("Air Castle F1 13")]
        AirCastleF1Area13 = 381,
        [Description("Air Castle 8")]
        AirCastleArea8 = 382,
        [Description("Air Castle 7")]
        AirCastleArea7 = 383,
        [Description("Air Castle F1 4")]
        AirCastleF1Area4 = 384,
        [Description("Air Castle F1 1")]
        AirCastleF1Area1 = 385,
        [Description("Air Castle F1 3")]
        AirCastleF1Area3 = 386,
        [Description("Air Castle F2")]
        AirCastleF2 = 387,
        [Description("Air Castle Boss Room")]
        AirCastleBosslRoom = 388,
        [Description("Air Castle Inner B1 1")]
        AirCastleInnerB1Area1 = 389,
        [Description("Air Castle Inner B1 2")]
        AirCastleInnerB1Area2 = 390,
        [Description("Air Castle Inner B1 3")]
        AirCastleInnerB1Area3 = 391,
        [Description("Air Castle Inner B2")]
        AirCastleInnerB2 = 392,
        [Description("Air Castle Inner B3")]
        AirCastleInnerB3 = 393,
        [Description("Air Castle Inner B4")]
        AirCastleInnerB4 = 394,
        [Description("Air Castle Inner B5")]
        AirCastleInnerB5 = 395,
        [Description("Zelan Space")]
        ZelanSpace = 396,
        [Description("Zelan")]
        Zelan = 397,
        [Description("Zelan F1")]
        ZelanF1 = 398,
        [Description("Kuran Space")]
        KuranSpace = 399,
        [Description("Kuran")]
        Kuran = 400,
        [Description("Kuran F1 1")]
        KuranF1Area1 = 401,
        [Description("Kuran F2 1")]
        KuranF2Area1 = 402,
        [Description("Kuran F1 2")]
        KuranF1Area2 = 403,
        [Description("Kuran F1 3")]
        KuranF1Area3 = 404,
        [Description("Kuran F1 5")]
        KuranF1Area5 = 405,
        [Description("Kuran F2 2")]
        KuranF2Area2 = 406,
        [Description("Kuran F1 4")]
        KuranF1Area4 = 407,
        [Description("Kuran F3")]
        KuranF3 = 408,
        [Description("Garuberk Tower")]
        GaruberkTower1 = 409,
        [Description("Garuberk Tower 2")]
        GaruberkTower2 = 410,
        [Description("Garuberk Tower 3")]
        GaruberkTower3 = 411,
        [Description("Garuberk Tower 4")]
        GaruberkTower4 = 412,
        [Description("Garuberk Tower 5")]
        GaruberkTower5 = 413,
        [Description("Garuberk Tower 6")]
        GaruberkTower6 = 414,
        [Description("Garuberk Tower 7")]
        GaruberkTower7 = 415,
        [Description("Air Castle Space")]
        AirCastleSpace = 416
    }

    /// <summary>
    /// Item effect filter type enumeration
    /// </summary>
    public enum ItemEffectFilterType : int
    {
        [Description("All")]
        All = 0,
        [Description("Damage")]
        Damage = 1,
        [Description("Death")]
        Death = 2,
        [Description("Attack down")]
        AttackDown = 3,
        [Description("Defense Down")]
        DefenseDown = 4,
        [Description("Agility down")]
        AgilityDown = 6,
        [Description("Sleep")]
        Sleep = 7,
        [Description("Silence")]
        Silence = 8,
        [Description("Attack Up")]
        AttackUp = 9,
        [Description("Defense Up")]
        DefenseUp = 10,
        [Description("Magic Defense Up")]
        MagicDefenseUp = 11,
        [Description("Agility Up")]
        AgilityUp = 12,
        [Description("Resistance Up")]
        ResistanceUp = 13,
        [Description("Wake Up")]
        WakeUp = 14,
        [Description("TP Up")]
        TechniquePointsUp = 15,
        [Description("HP Up")]
        HealthPointsUp = 18,
        [Description("Cure Poison")]
        CurePoison = 19,
        [Description("Cure Paralysis")]
        CureParalysis = 20,
        [Description("Revive")]
        Revive = 21,
        [Description("Heal Fully")]
        HealFully = 22,
        [Description("Android HP Up")]
        DemiHealthPointsUp = 23,
        [Description("Town Warp")]
        TownWarp = 25,
        [Description("Dungeon Warp")]
        DungeonWarp = 26,
        [Description("Poison")]
        Poison = 27,
        [Description("Paralyze")]
        Paralyze = 28,
        [Description("Android Death")]
        AndroidDeath = 29,
        [Description("Fission")]
        Fission1 = 30,
        [Description("Combine")]
        Combine = 31,
        [Description("Combined Attack")]
        CombinedAttack = 32,
        [Description("Dexterity Down")]
        DexterityDown = 33,
        [Description("Waiting")]
        Waiting = 34,
        [Description("Self Destruct")]
        SelfDestruct = 35,
        [Description("Combined Self Destruct")]
        CombinedSelfDestruct = 36,
        [Description("Fission")]
        Fission2 = 37,
        [Description("Dexterity Up")]
        DexterityUp = 38,
        [Description("Remove Stats")]
        StatusEffectRemoval = 39,
        [Description("Map")]
        Map = 40,
        [Description("Black Wave (Enable)")]
        EnableBlackWave = 41,
        [Description("Black Wave (Triggered)")]
        BlackWave1 = 42,
        [Description("All Stats Up")]
        AllStatsUp = 43,
        [Description("Black Wave")]
        BlackWave2 = 44
    }

    /// <summary>
    /// Object section type enumeration
    /// </summary>
    public enum SectionType : int
    {
        None = 0,
        Field = 1,
        Battle = 2,
        CutScene = 3,
        Window = 4,
        Unknown = 5
    }

    /// <summary>
    /// Object sub-section type enumeration
    /// </summary>
    public enum SubSectionType : int
    {
        None = 0,
        Map = 1,
        NPCs = 2,
        Background = 3,
        Foreground = 4,
        Effect = 5,
        UI = 6
    }

    /// <summary>
    /// Dialog group type enumeration (value(ID) = byte location in ROM)
    /// </summary>
    public enum DialogGroupType
    {
        [Description("Piata 1")]
        [Length(2960)]
        Dialog1 = 1963520,
        [Description("Piata 2")]
        [Length(2576)]
        Dialog2 = 1966480,
        [Description("Piata, Birth Valley")]
        [Length(3552)]
        Dialog3 = 1969056,
        [Description("Mile, Zema")]
        [Length(3328)]
        Dialog4 = 1972608,
        [Description("Krup")]
        [Length(3104)]
        Dialog5 = 1975936,
        [Description("Alys Cutscene")]
        [Length(3232)]
        Dialog6 = 1979040,
        [Description("Molcum, Tonoe, Valley Maze")]
        [Length(3808)]
        Dialog7 = 1982272,
        [Description("Nalya, Wreckage")]
        [Length(2336)]
        Dialog8 = 1986080,
        [Description("Kadary")]
        [Length(3136)]
        Dialog9 = 1988416,
        [Description("Aiedo 1")]
        [Length(3168)]
        Dialog10 = 1991552,
        [Description("Aiedo 2")]
        [Length(3440)]
        Dialog11 = 1994720,
        [Description("Monsen")]
        [Length(3216)]
        Dialog12 = 1998160,
        [Description("Termi, Zio's Fort, Plate System")]
        [Length(4112)]
        Dialog13 = 2001376,
        [Description("Tyler, Raja Temple, Hangar")]
        [Length(3792)]
        Dialog14 = 2005488,
        [Description("Ryuon 1")]
        [Length(2272)]
        Dialog15 = 2009280,
        [Description("Ryuon 2")]
        [Length(2288)]
        Dialog16 = 2011552,
        [Description("Climate Center, Zosa, Myst Vale")]
        [Length(3552)]
        Dialog17 = 2013840,
        [Description("Meese")]
        [Length(2800)]
        Dialog18 = 2017392,
        [Description("Meese, Reshel")]
        [Length(2368)]
        Dialog19 = 2020192,
        [Description("Elsydeon Cave, Inner Sanctuary")]
        [Length(3344)]
        Dialog20 = 2022560,
        [Description("Esper Mansion")]
        [Length(1920)]
        Dialog21 = 2025904,
        [Description("Air Castle, Garuberk Tower")]
        [Length(2384)]
        Dialog22 = 2027824,
        [Description("Jut")]
        [Length(2976)]
        Dialog23 = 2030208,
        [Description("Torinco")]
        [Length(2720)]
        Dialog24 = 2033184,
        [Description("Uzo, Rappy Cave")]
        [Length(2576)]
        Dialog25 = 2035904,
        [Description("Hunter's Guild 1")]
        [Length(2352)]
        Dialog26 = 2038480,
        [Description("Hunter's Guild 2")]
        [Length(2544)]
        Dialog27 = 2040832,
        [Description("Dialog 28")]
        [Length(3232)]
        Dialog28 = 2043376,
        [Description("Dialog 29")]
        [Length(2784)]
        Dialog29 = 2046608,
        [Description("Dialog 30")]
        [Length(2560)]
        Dialog30 = 2049392,
        [Description("Dialog 31")]
        [Length(2816)]
        Dialog31 = 2051952,
        [Description("Dialog 32")]
        [Length(2224)]
        Dialog32 = 2054768,
        [Description("Piata Academy")]
        [Length(3696)]
        Dialog33 = 2056992,
        [Description("Ladea Tower, Bio Plant, Machine Center")]
        [Length(4128)]
        Dialog34 = 2060688,
        [Description("Nurvus, Zelan, Kuran, Air Castle")]
        [Length(3696)]
        Dialog35 = 2064816,
        [Description("Nurvus")]
        [Length(1376)]
        Dialog36 = 2068512,
        [Description("Gumbious 1")]
        [Length(3840)]
        Dialog37 = 2069888,
        [Description("Gumbious 2")]
        [Length(1600)]
        Dialog38 = 2073728,
        [Description("Motavia Spaceport")]
        [Length(2896)]
        Dialog39 = 2075328,
        [Description("Silence Tower, Courage Tower")]
        [Length(3488)]
        Dialog40 = 2078224,
        [Description("Strength Tower, Anger Tower")]
        [Length(1392)]
        Dialog41 = 2081712,
        [Description("Island Cave, Soldier's Temple, The Edge")]
        [Length(3712)]
        Dialog42 = 2083104,
        [Description("Motavia, Dezolis, Rykros, Mile Destroyed, Weapon Plant, Vahal Fort")]
        [Length(3776)]
        Dialog43 = 2086816
    }

    /// <summary>
    /// Palette group enumeration (value(ID) = byte location in ROM)
    /// </summary>
    public enum PaletteType : int
    {
        [Description("Motavia Desert BG")]
        [Length(26)]
        [PaddedColors(new int[] { 0 })]
        MotaviaDesertBG = 28756,
        [Description("Motavia Beach BG")]
        [Length(26)]
        [PaddedColors(new int[] { 0 })]
        MotaviaBeachBG = 28782,
        [Description("Motavia Grass BG")]
        [Length(26)]
        [PaddedColors(new int[] { 0 })]
        MotaviaGrassBG = 28808,
        [Description("Motavia Sea BG")]
        [Length(26)]
        [PaddedColors(new int[] { 0 })]
        MotaviaSeaBG = 28834,
        [Description("Dezolis Dark BG")]
        [Length(26)]
        [PaddedColors(new int[] { 0 })]
        DezolisDarkBG = 28860,
        [Description("Dezolis Light BG")]
        [Length(26)]
        [PaddedColors(new int[] { 0 })]
        DezolisLightBG = 28886,
        [Description("Bio Plant BG")]
        [Length(26)]
        [PaddedColors(new int[] { 0 })]
        BioPlantBG = 28912,
        [Description("Wreckage BG")]
        [Length(26)]
        [PaddedColors(new int[] { 0 })]
        WreckageBG = 28938,
        [Description("Plate System BG")]
        [Length(26)]
        [PaddedColors(new int[] { 0 })]
        PlateSystemBG = 28964,
        [Description("Climate Center BG")]
        [Length(26)]
        [PaddedColors(new int[] { 0 })]
        ClimateCenterBG = 28990,
        [Description("Weapon Plant BG")]
        [Length(26)]
        [PaddedColors(new int[] { 0 })]
        WeaponPlantBG = 29016,
        [Description("Vahal Fort BG")]
        [Length(26)]
        [PaddedColors(new int[] { 0 })]
        VahalFortBG = 29042,
        [Description("Plate System F1 BG")]
        [Length(26)]
        [PaddedColors(new int[] { 0 })]
        PlateSystemF1BG = 29068,
        [Description("Academy Basement BG")]
        [Length(26)]
        [PaddedColors(new int[] { 0 })]
        AcademyBasementBG = 29094,
        [Description("Ladea Tower BG")]
        [Length(26)]
        [PaddedColors(new int[] { 0 })]
        LadeaTowerBG = 29120,
        [Description("Zio Fort BG")]
        [Length(26)]
        [PaddedColors(new int[] { 0 })]
        ZioFortBG = 29146,
        [Description("Air Castle BG")]
        [Length(26)]
        [PaddedColors(new int[] { 0 })]
        AirCastleBG = 29172,
        [Description("Garuberk Tower BG")]
        [Length(26)]
        [PaddedColors(new int[] { 0 })]
        GaruberkTowerBG = 29198,
        [Description("Tonoe Basement BG")]
        [Length(26)]
        [PaddedColors(new int[] { 0 })]
        TonoeBasementBG = 29224,
        [Description("Soldier Island BG")]
        [Length(26)]
        [PaddedColors(new int[] { 0 })]
        SoldierIslandBG = 29250,
        [Description("Monsen Cave BG")]
        [Length(26)]
        [PaddedColors(new int[] { 0 })]
        MonsenCaveBG = 29276,
        [Description("Elsydeon Cave BG")]
        [Length(26)]
        [PaddedColors(new int[] { 0 })]
        ElsydeonCaveBG = 29302,
        [Description("Rykros BG")]
        [Length(26)]
        [PaddedColors(new int[] { 0 })]
        RykrosBG = 29328,
        [Description("Zema BG")]
        [Length(26)]
        [PaddedColors(new int[] { 0 })]
        ZemaBG = 29354,
        [Description("Reshel BG")]
        [Length(26)]
        [PaddedColors(new int[] { 0 })]
        ReshelBG = 29380,
        [Description("Courage Tower BG")]
        [Length(26)]
        [PaddedColors(new int[] { 0 })]
        CourageTowerBG = 29406,
        [Description("Strength Tower BG")]
        [Length(26)]
        [PaddedColors(new int[] { 0 })]
        StrengthTowerBG = 29432,
        [Description("Anger Tower BG")]
        [Length(26)]
        [PaddedColors(new int[] { 0 })]
        AngerTowerBG = 29458,
        [Description("The Edge BG")]
        [Length(26)]
        [PaddedColors(new int[] { 0 })]
        TheEdgeBG = 29484,
        [Description("Carnivorous Trees BG")]
        [Length(26)]
        [PaddedColors(new int[] { 0 })]
        CarnivorousTreesBG = 29510,
        [Description("Dark Force BG")]
        [Length(26)]
        [PaddedColors(new int[] { 0 })]
        DarkForceBG = 29536,
        [Description("Unknown 219998")]
        [Length(26)]
        [PaddedColors(new int[] { 1, 0 })]
        Unknown219998 = 219998,
        [Description("Unknown 220092")]
        [Length(16)]
        [PaddedColors(new int[] { 0, 1, 0 })]
        Unknown220092 = 220092,
        [Description("Unknown 220146")]
        [Length(16)]
        Unknown220146 = 220146,
        [Description("Unknown 220208")]
        [Length(12)]
        Unknown220208 = 220208,
        [Description("Unknown 220266")]
        [Length(12)]
        Unknown220266 = 220266,
        [Description("Unknown 220324")]
        [Length(12)]
        Unknown220324 = 220324,
        [Description("Unknown 220412")]
        [Length(10)]
        Unknown220412 = 220412,
        [Description("Unknown 220464")]
        [Length(20)]
        Unknown220464 = 220464,
        [Description("Unknown 220526")]
        [Length(20)]
        Unknown220526 = 220526,
        [Description("Unknown 220586")]
        [Length(18)]
        [PaddedColors(new int[] { 1, 0 })]
        Unknown220586 = 220586,
        [Description("Unknown 220644")]
        [Length(18)]
        Unknown220644 = 220644,
        [Description("Unknown 220706")]
        [Length(10)]
        Unknown220706 = 220706,
        [Description("Unknown 220754")]
        [Length(20)]
        Unknown220754 = 220754,
        [Description("Unknown 220812")]
        [Length(20)]
        Unknown220812 = 220812,
        [Description("Unknown 220870")]
        [Length(20)]
        Unknown220870 = 220870,
        [Description("Unknown 220932")]
        [Length(20)]
        Unknown220932 = 220932,
        [Description("Unknown 220992")]
        [Length(6)]
        Unknown220992 = 220992,
        [Description("Unknown 221038")]
        [Length(6)]
        Unknown221038 = 221038,
        [Description("Unknown 221114")]
        [Length(10)]
        Unknown221114 = 221114,
        [Description("Unknown 221164")]
        [Length(6)]
        Unknown221164 = 221164,
        [Description("Unknown 221218")]
        [Length(16)]
        Unknown221218 = 221218,
        [Description("Unknown 221272")]
        [Length(26)]
        Unknown221272 = 221272,
        [Description("Unknown 221282")]
        [Length(16)]
        Unknown221282 = 221282,
        [Description("Unknown 221346")]
        [Length(16)]
        Unknown221346 = 221346,
        [Description("Unknown 221410")]
        [Length(16)]
        Unknown221410 = 221410,
        [Description("Unknown 221466")]
        [Length(10)]
        Unknown221466 = 221466,
        [Description("Unknown 221518")]
        [Length(18)]
        Unknown221518 = 221518,
        [Description("Unknown 221574")]
        [Length(18)]
        Unknown221574 = 221574,
        [Description("Unknown 221662")]
        [Length(10)]
        Unknown221662 = 221662,
        [Description("Unknown 221742")]
        [Length(10)]
        Unknown221742 = 221742,
        [Description("Unknown 221798")]
        [Length(20)]
        Unknown221798 = 221798,
        [Description("Unknown 221864")]
        [Length(20)]
        Unknown221864 = 221864,
        [Description("Unknown 221932")]
        [Length(74)]
        Unknown221932 = 221932,
        [Description("Unknown 222128")]
        [Length(74)]
        Unknown222128 = 222128,
        [Description("Unknown 222244")]
        [Length(74)]
        Unknown222244 = 222244,
        [Description("Unknown 222362")]
        [Length(10)]
        Unknown222362 = 222362,
        [Description("Unknown 222416")]
        [Length(26)]
        Unknown222416 = 222416,
        [Description("Unknown 222498")]
        [Length(32)]
        Unknown222498 = 222498,
        [Description("Unknown 222530")]
        [Length(32)]
        Unknown222530 = 222530,
        [Description("Unknown 222562")]
        [Length(32)]
        Unknown222562 = 222562,
        [Description("Unknown 222594")]
        [Length(32)]
        Unknown222594 = 222594,
        [Description("Unknown 222626")]
        [Length(32)]
        Unknown222626 = 222626,
        [Description("Unknown 222658")]
        [Length(32)]
        Unknown222658 = 222658,
        [Description("Unknown 222690")]
        [Length(32)]
        Unknown222690 = 222690,
        [Description("Unknown 222722")]
        [Length(32)]
        Unknown222722 = 222722,
        [Description("Unknown 222754")]
        [Length(32)]
        Unknown222754 = 222754,
        [Description("Unknown 222786")]
        [Length(32)]
        Unknown222786 = 222786,
        [Description("Unknown 222818")]
        [Length(20)]
        Unknown222818 = 222818,
        [Description("Motavia")]
        [Length(192)]
        Motavia = 1113666,
        [Description("Dezolis")]
        [Length(192)]
        Dezolis = 1152516,
        [Description("Rykros")]
        [Length(192)]
        Rykros = 1164848,
        [Description("Piata")]
        [Length(192)]
        Piata = 1194384,
        [Description("Piata Academy")]
        [Length(192)]
        PiataAcademy = 1211466,
        [Description("Piata Academy Basement")]
        [Length(192)]
        PiataAcademyBasement = 1217164,
        [Description("Motavia Town")]
        [Length(192)]
        MotaviaTown = 1242384,
        [Description("Mile")]
        [Length(192)]
        Mile = 1250568,
        [Description("Zema")]
        [Length(192)]
        Zema = 1250568,
        [Description("Birth Valley")]
        [Length(192)]
        BirthValley = 1276022,
        [Description("Krup Uzo")]
        [Length(192)]
        KrupUzo = 1285642,
        [Description("Molcum")]
        [Length(192)]
        Molcum = 1302462,
        [Description("Tonoe")]
        [Length(192)]
        Tonoe = 1308108,
        [Description("Tonoe Basement")]
        [Length(192)]
        TonoeBasement = 1324708,
        [Description("Nalya")]
        [Length(192)]
        Nalya = 1332236,
        [Description("Aiedo")]
        [Length(192)]
        Aiedo = 1345020,
        [Description("Kadary")]
        [Length(192)]
        Kadary = 1371522,
        [Description("Monsen")]
        [Length(192)]
        Monsen = 1397900,
        [Description("Termi Torinco")]
        [Length(192)]
        TermiTorinco = 1407942,
        [Description("Passageway")]
        [Length(192)]
        Passageway = 1415780,
        [Description("Zio Fort 1")]
        [Length(192)]
        ZioFort1 = 1438174,
        [Description("Zio Fort 2")]
        [Length(192)]
        ZioFort2 = 1440160,
        [Description("Ladea Tower")]
        [Length(192)]
        LadeaTower = 1456478,
        [Description("Island Cave 1")]
        [Length(192)]
        IslandCave1 = 1476464,
        [Description("Island Cave 2")]
        [Length(192)]
        IslandCave2 = 1477300,
        [Description("Soldiers Temple")]
        [Length(192)]
        SoldiersTemple = 1494632,
        [Description("Valley Maze")]
        [Length(192)]
        ValleyMaze = 1495626,
        [Description("Bio Plant")]
        [Length(192)]
        BioPlant = 1511930,
        [Description("Wreckage")]
        [Length(192)]
        Wreckage = 1524164,
        [Description("Machine Center")]
        [Length(192)]
        MachineCenter = 1534936,
        [Description("Plate System 1")]
        [Length(192)]
        PlateSystem1 = 1539388,
        [Description("Plate System 2")]
        [Length(192)]
        PlateSystem2 = 1540242,
        [Description("Motavia Spaceport")]
        [Length(192)]
        MotaviaSpaceport = 1541876,
        [Description("Climate Center 1")]
        [Length(192)]
        ClimateCenter1 = 1542772,
        [Description("Climate Center 2")]
        [Length(192)]
        ClimateCenter2 = 1543876,
        [Description("Weapons Plant")]
        [Length(192)]
        WeaponsPlant = 1550068,
        [Description("Vahal Fort")]
        [Length(192)]
        VahalFort = 1553088,
        [Description("Nurvus 1")]
        [Length(192)]
        Nurvus1 = 1563856,
        [Description("Nurvus 2")]
        [Length(192)]
        Nurvus2 = 1565622,
        [Description("Dezolis Spaceport")]
        [Length(192)]
        DezolisSpaceport = 1567354,
        [Description("Nurvus 3")]
        [Length(192)]
        Nurvus3 = 1567966,
        [Description("Motovia Passageway")]
        [Length(192)]
        MotoviaPassageway = 1574860,
        [Description("Rappy Cave")]
        [Length(192)]
        RappyCave = 1585622,
        [Description("Silence Tower")]
        [Length(192)]
        SilenceTower = 1601818,
        [Description("Strength Tower")]
        [Length(192)]
        StrengthTower = 1603428,
        [Description("Courage Tower")]
        [Length(192)]
        CourageTower = 1608806,
        [Description("Anger Tower")]
        [Length(192)]
        AngerTower = 1613328,
        [Description("The Edge 1")]
        [Length(192)]
        TheEdge1 = 1631130,
        [Description("The Edge 2")]
        [Length(192)]
        TheEdge2 = 1632422,
        [Description("The Edge 3")]
        [Length(192)]
        TheEdge3 = 1633024,
        [Description("The Edge 4")]
        [Length(192)]
        TheEdge4 = 1633858,
        [Description("The Edge 5")]
        [Length(192)]
        TheEdge5 = 1634180,
        [Description("Dezolis Town")]
        [Length(192)]
        DezolisTown = 1672648,
        [Description("Zosa")]
        [Length(192)]
        Zosa = 1686932,
        [Description("Meese")]
        [Length(192)]
        Meese = 1694962,
        [Description("Jut")]
        [Length(192)]
        Jut = 1711342,
        [Description("Gumbious Temple 1")]
        [Length(192)]
        GumbiousTemple1 = 1734546,
        [Description("Ryuon")]
        [Length(192)]
        Ryuon = 1739936,
        [Description("Raja Temple")]
        [Length(192)]
        RajaTemple = 1754952,
        [Description("Reshel")]
        [Length(192)]
        Reshel = 1759998,
        [Description("Elsydeon Cave")]
        [Length(192)]
        ElsydeonCave = 1773892,
        [Description("Hangar")]
        [Length(192)]
        Hangar = 1775112,
        [Description("Gumbious Temple 2")]
        [Length(192)]
        GumbiousTemple2 = 1778860,
        [Description("Esper Mansion")]
        [Length(192)]
        EsperMansion = 1791654,
        [Description("Air Castle 1")]
        [Length(192)]
        AirCastle1 = 1824536,
        [Description("Air Castle 2")]
        [Length(192)]
        AirCastle2 = 1836982,
        [Description("Zelan")]
        [Length(192)]
        Zelan = 1847692,
        [Description("Kuran 1")]
        [Length(192)]
        Kuran1 = 1848336,
        [Description("Kuran 2")]
        [Length(192)]
        Kuran2 = 1850246,
        [Description("Garuberk Tower")]
        [Length(192)]
        GaruberkTower = 1871504,
        [Description("Air Castle 3")]
        [Length(192)]
        AirCastle3 = 1885210,
        [Description("Intro 1")]
        [Length(128)]
        Intro1 = 1911228,
        [Description("Intro 2")]
        [Length(128)]
        Intro2 = 1911356,
        [Description("Unknown 2102896")]
        [Length(50)]
        Unknown2102896 = 2102896,
        [Description("Unknown 2102946")]
        [Length(50)]
        Unknown2102946 = 2102946,
        [Description("Unknown 2102996")]
        [Length(62)]
        Unknown2102996 = 2102996,
        [Description("Unknown 2103058")]
        [Length(8)]
        Unknown2103058 = 2103058,
        [Description("Unknown 2103066")]
        [Length(14)]
        Unknown2103066 = 2103066,
        [Description("Unknown 2103080")]
        [Length(20)]
        Unknown2103080 = 2103080,
        [Description("Unknown 2103100")]
        [Length(20)]
        Unknown2103100 = 2103100,
        [Description("Unknown 2103120")]
        [Length(20)]
        Unknown2103120 = 2103120,
        [Description("Unknown 2103140")]
        [Length(14)]
        Unknown2103140 = 2103140,
        [Description("Unknown 2103154")]
        [Length(8)]
        Unknown2103154 = 2103154,
        [Description("Unknown 2108752")]
        [Length(134)]
        Unknown2108752 = 2108752,
        [Description("Unknown 2108886")]
        [Length(116)]
        Unknown2108886 = 2108886,
        [Description("Unknown 2109002")]
        [Length(122)]
        Unknown2109002 = 2109002,
        [Description("Unknown 2109124")]
        [Length(110)]
        Unknown2109124 = 2109124,
        [Description("Unknown 2109234")]
        [Length(122)]
        Unknown2109234 = 2109234,
        [Description("Unknown 2109356")]
        [Length(20)]
        Unknown2109356 = 2109356,
        [Description("Unknown 2109376")]
        [Length(20)]
        Unknown2109376 = 2109376,
        [Description("Unknown 2109396")]
        [Length(14)]
        Unknown2109396 = 2109396,
        [Description("Unknown 2109410")]
        [Length(14)]
        Unknown2109410 = 2109410,
        [Description("Unknown 2109424")]
        [Length(14)]
        Unknown2109424 = 2109424,
        [Description("Unknown 2109432")]
        [Length(8)]
        Unknown2109432 = 2109432,
        [Description("Unknown 2109440")]
        [Length(8)]
        Unknown2109440 = 2109440,
        [Description("Unknown 2109448")]
        [Length(8)]
        Unknown2109448 = 2109448,
        [Description("Unknown 2109462")]
        [Length(14)]
        Unknown2109462 = 2109462,
        [Description("Unknown 2109476")]
        [Length(14)]
        Unknown2109476 = 2109476,
        [Description("Unknown 2109490")]
        [Length(14)]
        Unknown2109490 = 2109490,
        [Description("Unknown 2115714")]
        [Length(14)]
        Unknown2115714 = 2115714,
        [Description("Unknown 2115728")]
        [Length(14)]
        Unknown2115728 = 2115728,
        [Description("Unknown 2115742")]
        [Length(26)]
        Unknown2115742 = 2115742,
        [Description("Unknown 2115768")]
        [Length(26)]
        Unknown2115768 = 2115768,
        [Description("Unknown 2115794")]
        [Length(38)]
        Unknown2115794 = 2115794,
        [Description("Unknown 2115832")]
        [Length(38)]
        Unknown2115832 = 2115832,
        [Description("Unknown 2115870")]
        [Length(38)]
        Unknown2115870 = 2115870,
        [Description("Unknown 2115908")]
        [Length(8)]
        Unknown2115908 = 2115908,
        [Description("Unknown 2115916")]
        [Length(14)]
        Unknown2115916 = 2115916,
        [Description("Unknown 2115930")]
        [Length(14)]
        Unknown2115930 = 2115930,
        [Description("Unknown 2115944")]
        [Length(14)]
        Unknown2115944 = 2115944,
        [Description("Unknown 2115958")]
        [Length(26)]
        Unknown2115958 = 2115958,
        [Description("Unknown 2115984")]
        [Length(26)]
        Unknown2115984 = 2115984,
        [Description("Unknown 2119860")]
        [Length(8)]
        Unknown2119860 = 2119860,
        [Description("Unknown 2119868")]
        [Length(20)]
        Unknown2119868 = 2119868,
        [Description("Unknown 2119888")]
        [Length(20)]
        Unknown2119888 = 2119888,
        [Description("Unknown 2119908")]
        [Length(14)]
        Unknown2119908 = 2119908,
        [Description("Unknown 2119922")]
        [Length(14)]
        Unknown2119922 = 2119922,
        [Description("Unknown 2119936")]
        [Length(20)]
        Unknown2119936 = 2119936,
        [Description("Unknown 2119956")]
        [Length(8)]
        Unknown2119956 = 2119956,
        [Description("Unknown 2119964")]
        [Length(8)]
        Unknown2119964 = 2119964,
        [Description("Unknown 2119972")]
        [Length(8)]
        Unknown2119972 = 2119972,
        [Description("Unknown 2119980")]
        [Length(14)]
        Unknown2119980 = 2119980,
        [Description("Unknown 2119994")]
        [Length(14)]
        Unknown2119994 = 2119994,
        [Description("Unknown 2120008")]
        [Length(8)]
        Unknown2120008 = 2120008,
        [Description("Unknown 2120016")]
        [Length(8)]
        Unknown2120016 = 2120016,
        [Description("Unknown 2120024")]
        [Length(14)]
        Unknown2120024 = 2120024,
        [Description("Unknown 2120038")]
        [Length(14)]
        Unknown2120038 = 2120038,
        [Description("Unknown 2120052")]
        [Length(14)]
        Unknown2120052 = 2120052,
        [Description("Unknown 2120066")]
        [Length(20)]
        Unknown2120066 = 2120066,
        [Description("General")]
        [Length(32)]
        General = 2712320,
        [Description("Land Rover")]
        [Length(32)]
        LandRover = 2717006,
        [Description("Ice Digger")][Length(32)]
        IceDigger = 2717038,
        [Description("Hydrofoil")][Length(32)]
        Hydrofoil = 2717070,
        [Description("Characters Intro")][Length(128)]
        CharactersIntro = 3099028
    }

    /// <summary>
    /// Tile map type enumerator (value(ID) = byte location in ROM)
    /// </summary>
    public enum TileMapType : int
    {
        [Description("Character Down 1")]
        [Length(8)]
        [Columns(2)]
        [Rows(4)]
        [Offset(0)]
        [Compression(CompressionType.None)]
        CharacterDown1 = 295588,
        [Description("Character Down 2")]
        [Length(8)]
        [Columns(2)]
        [Rows(4)]
        [Offset(0)]
        [Compression(CompressionType.None)]
        CharacterDown2 = 295596,
        [Description("Character Down 3")]
        [Length(8)]
        [Columns(2)]
        [Rows(4)]
        [Offset(0)]
        [Compression(CompressionType.None)]
        CharacterDown3 = 295604,
        [Description("Character Left 1")]
        [Length(8)]
        [Columns(2)]
        [Rows(4)]
        [Offset(0)]
        [Compression(CompressionType.None)]
        CharacterLeft1 = 295612,
        [Description("Character Left 2")]
        [Length(8)]
        [Columns(2)]
        [Rows(4)]
        [Offset(0)]
        [Compression(CompressionType.None)]
        CharacterLeft2 = 295620,
        [Description("Character Left 3")]
        [Length(8)]
        [Columns(2)]
        [Rows(4)]
        [Offset(0)]
        [Compression(CompressionType.None)]
        CharacterLeft3 = 295628,
        [Description("Character Up 1")]
        [Length(8)]
        [Columns(2)]
        [Rows(4)]
        [Offset(0)]
        [Compression(CompressionType.None)]
        CharacterUp1 = 295636,
        [Description("Character Up 2")]
        [Length(8)]
        [Columns(2)]
        [Rows(4)]
        [Offset(0)]
        [Compression(CompressionType.None)]
        CharacterUp2 = 295644,
        [Description("Character Up 3")]
        [Length(8)]
        [Columns(2)]
        [Rows(4)]
        [Offset(0)]
        [Compression(CompressionType.None)]
        CharacterUp3 = 295652,
        [Description("Character Right 1")]
        [Length(8)]
        [Columns(2)]
        [Rows(4)]
        [Offset(0)]
        [Compression(CompressionType.None)]
        CharacterRight1 = 295660,
        [Description("Character Right 2")]
        [Length(8)]
        [Columns(2)]
        [Rows(4)]
        [Offset(0)]
        [Compression(CompressionType.None)]
        CharacterRight2 = 295668,
        [Description("Character Right 3")]
        [Length(8)]
        [Columns(2)]
        [Rows(4)]
        [Offset(0)]
        [Compression(CompressionType.None)]
        CharacterRight3 = 295676,
        [Description("Vehicle Down 1")]
        [Length(8)]
        [Columns(2)]
        [Rows(4)]
        [Offset(0)]
        [Compression(CompressionType.None)]
        VehicleDown1 = 295676,
        [Description("Vehicle Down 2")]
        [Length(8)]
        [Columns(2)]
        [Rows(4)]
        [Offset(0)]
        [Compression(CompressionType.None)]
        VehicleDown2 = 295676,
        [Description("Vehicle Left 1")]
        [Length(14)]
        [Columns(2)]
        [Rows(4)]
        [Offset(0)]
        [Compression(CompressionType.None)]
        VehicleLeft1 = 295676,
        [Description("Vehicle Left 2")]
        [Length(14)]
        [Columns(2)]
        [Rows(4)]
        [Offset(0)]
        [Compression(CompressionType.None)]
        VehicleLeft2 = 295676,
        [Description("Vehicle Up 1")]
        [Length(8)]
        [Columns(2)]
        [Rows(4)]
        [Offset(0)]
        [Compression(CompressionType.None)]
        VehicleUp1 = 295676,
        [Description("Vehicle Up 2")]
        [Length(8)]
        [Columns(2)]
        [Rows(4)]
        [Offset(0)]
        [Compression(CompressionType.None)]
        VehicleUp2 = 295676,
        [Description("Vehicle Right 1")]
        [Length(14)]
        [Columns(2)]
        [Rows(4)]
        [Offset(0)]
        [Compression(CompressionType.None)]
        VehicleRight1 = 295676,
        [Description("Vehicle Right 2")]
        [Length(14)]
        [Columns(2)]
        [Rows(4)]
        [Offset(0)]
        [Compression(CompressionType.None)]
        VehicleRight2 = 295676,
        [Description("Hydrofoil Down 1")]
        [Length(8)]
        [Columns(2)]
        [Rows(4)]
        [Offset(0)]
        [Compression(CompressionType.None)]
        HydrofoilDown1 = 295676,
        [Description("Hydrofoil Left 1")]
        [Length(14)]
        [Columns(2)]
        [Rows(4)]
        [Offset(0)]
        [Compression(CompressionType.None)]
        HydrofoilLeft1 = 295676,
        [Description("Hydrofoil Up 1")]
        [Length(8)]
        [Columns(2)]
        [Rows(4)]
        [Offset(0)]
        [Compression(CompressionType.None)]
        HydrofoilUp1 = 295676,
        [Description("Hydrofoil Right 1")]
        [Length(14)]
        [Columns(2)]
        [Rows(4)]
        [Offset(0)]
        [Compression(CompressionType.None)]
        HydrofoilRight1 = 295676,
        [Description("Motavia")]
        [Length(6176)]
        [Columns(10)]
        [Rows(10)]
        [Offset(0)]
        [Compression(CompressionType.Kosinski)]
        Motavia = 1074594,
        [Description("Rykros 1")]
        [Length(1344)]
        [Columns(10)]
        [Rows(10)]
        [Offset(0)]
        [Compression(CompressionType.Kosinski)]
        Rykros1 = 1162560,
        [Description("Rykros 2")]
        [Length(64)]
        [Columns(10)]
        [Rows(10)]
        [Offset(0)]
        [Compression(CompressionType.Kosinski)]
        Rykros2 = 1163904,
        [Description("Rykros 3")]
        [Length(880)]
        [Columns(10)]
        [Rows(10)]
        [Offset(0)]
        [Compression(CompressionType.Kosinski)]
        Rykros3 = 1163968,
        [Description("Piata 1")]
        [Length(2288)]
        [Columns(10)]
        [Rows(10)]
        [Offset(0)]
        [Compression(CompressionType.Kosinski)]
        Piata1 = 1190544,
        [Description("Piata 2")]
        [Length(912)]
        [Columns(10)]
        [Rows(10)]
        [Offset(0)]
        [Compression(CompressionType.Kosinski)]
        Piata2 = 1192832,
        [Description("Piata 3")]
        [Length(160)]
        [Columns(10)]
        [Rows(10)]
        [Offset(0)]
        [Compression(CompressionType.Kosinski)]
        Piata3 = 1193744,
        [Description("Piata 4")]
        [Length(480)]
        [Columns(10)]
        [Rows(10)]
        [Offset(0)]
        [Compression(CompressionType.Kosinski)]
        Piata4 = 1193904,
        [Description("Piata Academy 4")]
        [Length(2656)]
        [Columns(10)]
        [Rows(10)]
        [Offset(0)]
        [Compression(CompressionType.Kosinski)]
        PiataAcademy4 = 1208378,
        [Description("Academy Basement B1 1")]
        [Length(80)]
        [Columns(10)]
        [Rows(10)]
        [Offset(0)]
        [Compression(CompressionType.Kosinski)]
        AcademyBasementB11 = 1217386,
        [Description("Academy Basement B1 2")]
        [Length(128)]
        [Columns(10)]
        [Rows(10)]
        [Offset(0)]
        [Compression(CompressionType.Kosinski)]
        AcademyBasementB12 = 1217466,
        [Description("Academy Basement B2 2")]
        [Length(64)]
        [Columns(10)]
        [Rows(10)]
        [Offset(0)]
        [Compression(CompressionType.Kosinski)]
        AcademyBasementB22 = 1218268,
        [Description("Academy Basement B2 3")]
        [Length(80)]
        [Columns(10)]
        [Rows(10)]
        [Offset(0)]
        [Compression(CompressionType.Kosinski)]
        AcademyBasementB23 = 1218332,
        [Description("Piata Item Shop 1")]
        [Length(64)]
        [Columns(10)]
        [Rows(10)]
        [Offset(0)]
        [Compression(CompressionType.Kosinski)]
        PiataItemShop1 = 1245428,
        [Description("Piata Item Shop 2")]
        [Length(144)]
        [Columns(10)]
        [Rows(10)]
        [Offset(0)]
        [Compression(CompressionType.Kosinski)]
        PiataItemShop2 = 1245492,
        [Description("Intro PSIV Title 1")]
        [Length(52)]
        [Columns(17)]
        [Rows(13)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        IntroPSIVTitle1 = 1908978,
        [Description("Sub Title Intro 1")]
        [Length(44)]
        [Columns(29)]
        [Rows(3)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        SubTitleIntro1 = 1909030,
        [Description("Copyright Intro")]
        [Length(14)]
        [Columns(16)]
        [Rows(1)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        CopyrightIntro = 1909074,
        [Description("Press Start Intro")]
        [Length(18)]
        [Columns(18)]
        [Rows(1)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        PressStartIntro = 1909088,
        [Description("Scroll Background Intro 1")]
        [Length(204)]
        [Columns(8)]
        [Rows(28)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        ScrollBackgroundIntro1 = 1909106,
        [Description("Left Background Intro")]
        [Length(140)]
        [Columns(8)]
        [Rows(28)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        LeftBackgroundIntro = 1909310,
        [Description("Scroll Background Intro 2")]
        [Length(162)]
        [Columns(6)]
        [Rows(28)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        ScrollBackgroundIntro2 = 1909450,
        [Description("Right Background Intro")]
        [Length(594)]
        [Columns(26)]
        [Rows(28)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        RightBackgroundIntro = 1909612,
        [Description("Prologue Motavia 1")]
        [Length(338)]
        [Columns(40)]
        [Rows(16)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        PrologueMotavia1 = 1910206,
        [Description("Asteroids Intro 1")]
        [Length(684)]
        [Columns(40)]
        [Rows(16)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        AsteroidsIntro1 = 1910544,
        [Description("Unknown 1956130")]
        [Length(614)]
        [Columns(10)]
        [Rows(10)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        Unknown1956130 = 1956130,
        [Description("Unknown 1956744")]
        [Length(106)]
        [Columns(10)]
        [Rows(10)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        Unknown1956744 = 1956744,
        [Description("Unknown 1956850")]
        [Length(12)]
        [Columns(10)]
        [Rows(10)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        Unknown1956850 = 1956850,
        [Description("Unknown 1956862")]
        [Length(8)]
        [Columns(10)]
        [Rows(10)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        Unknown1956862 = 1956862,
        [Description("Unknown 1956870")]
        [Length(12)]
        [Columns(10)]
        [Rows(10)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        Unknown1956870 = 1956870,
        [Description("Unknown 1956882")]
        [Length(14)]
        [Columns(10)]
        [Rows(10)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        Unknown1956882 = 1956882,
        [Description("Unknown 1956896")]
        [Length(10)]
        [Columns(10)]
        [Rows(10)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        Unknown1956896 = 1956896,
        [Description("Unknown 1956906")]
        [Length(480)]
        [Columns(10)]
        [Rows(10)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        Unknown1956906 = 1956906,
        [Description("Unknown 1957386")]
        [Length(560)]
        [Columns(10)]
        [Rows(10)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        Unknown1957386 = 1957386,
        [Description("Unknown 1957946")]
        [Length(94)]
        [Columns(10)]
        [Rows(10)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        Unknown1957946 = 1957946,
        [Description("Shadow Saber 1")]
        [Length(30)]
        [Columns(8)]
        [Rows(7)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        ShadowSaber1 = 2097616,
        [Description("Scorpirus 1")]
        [Length(60)]
        [Columns(10)]
        [Rows(10)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        Scorpirus1 = 2102180,
        [Description("Dark Marauder 1")]
        [Length(48)]
        [Columns(10)]
        [Rows(10)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        DarkMarauder1 = 2104798,
        [Description("Abe Frog 1")]
        [Length(26)]
        [Columns(10)]
        [Rows(6)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        AbeFrog1 = 2113944,
        [Description("Sand Newt 1")]
        [Length(30)]
        [Columns(8)]
        [Rows(6)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        SandNewt1 = 2117796,
        [Description("Stone Heads 1")]
        [Length(38)]
        [Columns(10)]
        [Rows(8)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        StoneHeads1 = 2120794,
        [Description("Whistle 1")]
        [Length(22)]
        [Columns(4)]
        [Rows(6)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        Whistle1 = 2121456,
        [Description("Loader 1")]
        [Length(44)]
        [Columns(10)]
        [Rows(10)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        Loader1 = 2125418,
        [Description("Unknown 2127024")]
        [Length(42)]
        [Columns(10)]
        [Rows(8)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        Unknown2127024 = 2127024,
        [Description("Unknown 2127066")]
        [Length(50)]
        [Columns(10)]
        [Rows(8)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        Unknown2127066 = 2127066,
        [Description("Unknown 2127116")]
        [Length(50)]
        [Columns(10)]
        [Rows(8)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        Unknown2127116 = 2127116,
        [Description("Unknown 2127166")]
        [Length(42)]
        [Columns(10)]
        [Rows(8)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        Unknown2127166 = 2127166,
        [Description("Unknown 2127208")]
        [Length(50)]
        [Columns(10)]
        [Rows(8)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        Unknown2127208 = 2127208,
        [Description("Unknown 2127258")]
        [Length(50)]
        [Columns(10)]
        [Rows(8)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        Unknown2127258 = 2127258,
        [Description("Warren 286 1")]
        [Length(16)]
        [Columns(4)]
        [Rows(8)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        Warren2861 = 2128758,
        [Description("Arm Drone 1")]
        [Length(34)]
        [Columns(6)]
        [Rows(8)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        ArmDrone1 = 2131012,
        [Description("Float Mine 1")]
        [Length(30)]
        [Columns(6)]
        [Rows(8)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        FloatMine1 = 2132366,
        [Description("C-Ray Tube 1")]
        [Length(46)]
        [Columns(8)]
        [Rows(10)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        CRayTube1 = 2134498,
        [Description("Unknown 2134544")]
        [Length(48)]
        [Columns(8)]
        [Rows(8)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        Unknown2134544 = 2134544,
        [Description("Blob 1")]
        [Length(26)]
        [Columns(6)]
        [Rows(5)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        Blob1 = 2137710,
        [Description("Meta Slug 1")]
        [Length(62)]
        [Columns(10)]
        [Rows(8)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        MetaSlug1 = 2140764,
        [Description("Crawler 1")]
        [Length(18)]
        [Columns(6)]
        [Rows(6)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        Crawler1 = 2143274,
        [Description("Life Deleter 1")]
        [Length(54)]
        [Columns(10)]
        [Rows(10)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        LifeDeleter1 = 2145718,
        [Description("Worker Pod 1")]
        [Length(42)]
        [Columns(6)]
        [Rows(7)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        WorkerPod1 = 2148312,
        [Description("Tarantella 1")]
        [Length(26)]
        [Columns(6)]
        [Rows(6)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        Tarantella1 = 2151052,
        [Description("Monster Fly 1")]
        [Length(32)]
        [Columns(8)]
        [Rows(8)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        MonsterFly1 = 2152528,
        [Description("Sensor Bit 1")]
        [Length(34)]
        [Columns(6)]
        [Rows(9)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        SensorBit1 = 2154258,
        [Description("Neo Whistle 1")]
        [Length(28)]
        [Columns(8)]
        [Rows(6)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        NeoWhistle1 = 2156748,
        [Description("Xanafalgue 1")]
        [Length(30)]
        [Columns(6)]
        [Rows(6)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        Xanafalgue1 = 2157770,
        [Description("Zoran Bult 1")]
        [Length(30)]
        [Columns(6)]
        [Rows(8)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        ZoranBult1 = 2159064,
        [Description("Igglanova 1")]
        [Length(50)]
        [Columns(10)]
        [Rows(10)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        Igglanova1 = 2163508,
        [Description("Locusta 1")]
        [Length(30)]
        [Columns(10)]
        [Rows(11)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        Locusta1 = 2167698,
        [Description("Slave 1")]
        [Length(40)]
        [Columns(12)]
        [Rows(10)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        Slave1 = 2170210,
        [Description("Unknown 2170250")]
        [Length(62)]
        [Columns(12)]
        [Rows(10)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        Unknown2170250 = 2170250,
        [Description("Unknown 2170312")]
        [Length(60)]
        [Columns(12)]
        [Rows(10)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        Unknown2170312 = 2170312,
        [Description("Unknown 2170372")]
        [Length(40)]
        [Columns(12)]
        [Rows(10)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        Unknown2170372 = 2170372,
        [Description("Unknown 2170412")]
        [Length(56)]
        [Columns(6)]
        [Rows(10)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        Unknown2170412 = 2170412,
        [Description("Unknown 2170468")]
        [Length(62)]
        [Columns(6)]
        [Rows(10)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        Unknown2170468 = 2170468,
        [Description("Unknown 2170530")]
        [Length(62)]
        [Columns(6)]
        [Rows(10)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        Unknown2170530 = 2170530,
        [Description("Unknown 2170592")]
        [Length(62)]
        [Columns(6)]
        [Rows(10)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        Unknown2170592 = 2170592,
        [Description("Unknown 2170654")]
        [Length(62)]
        [Columns(6)]
        [Rows(10)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        Unknown2170654 = 2170654,
        [Description("Blauzen 1")]
        [Length(42)]
        [Columns(10)]
        [Rows(8)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        Blauzen1 = 2172170,
        [Description("Balduel 1")]
        [Length(56)]
        [Columns(10)]
        [Rows(8)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        Balduel1 = 2177724,
        [Description("Haunt 1")]
        [Length(26)]
        [Columns(6)]
        [Rows(8)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        Haunt1 = 2177788,
        [Description("Acacia 1")]
        [Length(46)]
        [Columns(6)]
        [Rows(8)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        Acacia1 = 2179272,
        [Description("Speard 1")]
        [Length(20)]
        [Columns(6)]
        [Rows(7)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        Speard1 = 2181776,
        [Description("Technique User 1")]
        [Length(10)]
        [Columns(4)]
        [Rows(7)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        TechniqueUser1 = 2183488,
        [Description("Elmelew 1")]
        [Length(42)]
        [Columns(8)]
        [Rows(8)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        Elmelew1 = 2184738,
        [Description("Centaur 1")]
        [Length(26)]
        [Columns(8)]
        [Rows(10)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        Centaur1 = 2187896,
        [Description("Ismounos 1")]
        [Length(40)]
        [Columns(8)]
        [Rows(9)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        Ismounos1 = 2190430,
        [Description("Soldier Fiend 1")]
        [Length(30)]
        [Columns(10)]
        [Rows(10)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        SoldierFiend1 = 2195366,
        [Description("Piercer 1")]
        [Length(26)]
        [Columns(6)]
        [Rows(8)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        Piercer1 = 2198182,
        [Description("Ripper 1")]
        [Length(24)]
        [Columns(6)]
        [Rows(8)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        Ripper1 = 2200040,
        [Description("Sand Worm 1")]
        [Length(28)]
        [Columns(10)]
        [Rows(8)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        SandWorm1 = 2206182,
        [Description("Toadstool 1")]
        [Length(22)]
        [Columns(6)]
        [Rows(6)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        Toadstool1 = 2209054,
        [Description("Mini Worm 1")]
        [Length(10)]
        [Columns(4)]
        [Rows(6)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        MiniWorm1 = 2210984,
        [Description("Flatter Plant 1")]
        [Length(38)]
        [Columns(8)]
        [Rows(8)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        FlatterPlant1 = 2213706,
        [Description("Dimension Worm 1")]
        [Length(10)]
        [Columns(3)]
        [Rows(6)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        DimensionWorm1 = 2216104,
        [Description("BG Zio 1")]
        [Length(236)]
        [Columns(64)]
        [Rows(24)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        BGZio1 = 2221654,
        [Description("Zio 1")]
        [Length(58)]
        [Columns(12)]
        [Rows(15)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        Zio1 = 2223326,
        [Description("Zio 2")]
        [Length(56)]
        [Columns(12)]
        [Rows(7)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        Zio2 = 2223384,
        [Description("King Rappy 1")]
        [Length(22)]
        [Columns(10)]
        [Rows(9)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        KingRappy1 = 2229090,
        [Description("Rappy 1")]
        [Length(10)]
        [Columns(6)]
        [Rows(5)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        Rappy1 = 2234706,
        [Description("Prophallus 1")]
        [Length(52)]
        [Columns(12)]
        [Rows(12)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        Prophallus1 = 2241344,
        [Description("Snow Mole 1")]
        [Length(28)]
        [Columns(6)]
        [Rows(6)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        SnowMole1 = 2244672,
        [Description("Dezo Owl 1")]
        [Length(34)]
        [Columns(6)]
        [Rows(7)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        DezoOwl1 = 2249460,
        [Description("Profound Darkness 3 1")]
        [Length(1200)]
        [Columns(40)]
        [Rows(8)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        ProfoundDarkness31 = 2256898,
        [Description("Profound Darkness 3 2")]
        [Length(3072)]
        [Columns(64)]
        [Rows(21)]
        [Offset(0)]
        [Compression(CompressionType.None)]
        ProfoundDarkness32 = 2261812,
        [Description("Profound Darkness 1 1")]
        [Length(672)]
        [Columns(64)]
        [Rows(21)]
        [Offset(0)]
        [Compression(CompressionType.Kosinski)]
        ProfoundDarkness11 = 2291756,
        [Description("Dark Force 3 1")]
        [Length(106)]
        [Columns(36)]
        [Rows(15)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        DarkForce31 = 2304418,
        [Description("Dark Force 2 1")]
        [Length(162)]
        [Columns(40)]
        [Rows(15)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        DarkForce21 = 2314962,
        [Description("Dark Force 1 1")]
        [Length(196)]
        [Columns(40)]
        [Rows(15)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        DarkForce11 = 2322108,
        [Description("Dark Force 1 BG 1")]
        [Length(454)]
        [Columns(64)]
        [Rows(24)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        DarkForce1BG1 = 2324634,
        [Description("Carnivorous Tree 1")]
        [Length(26)]
        [Columns(8)]
        [Rows(7)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        CarnivorousTree1 = 2330090,
        [Description("Carnivorous Trees BG 1")]
        [Length(522)]
        [Columns(64)]
        [Rows(24)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        CarnivorousTreesBG1 = 2334748,
        [Description("Lashiec 1")]
        [Length(78)]
        [Columns(12)]
        [Rows(12)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        Lashiec1 = 2338652,
        [Description("Re-Faze 1")]
        [Length(28)]
        [Columns(8)]
        [Rows(8)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        ReFaze = 2346146,
        [Description("Alys (Boss) 1")]
        [Length(20)]
        [Columns(6)]
        [Rows(8)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        AlysBoss1 = 2347888,
        [Description("D-Elm-Lars 1")]
        [Length(46)]
        [Columns(10)]
        [Rows(10)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        DElmLars1 = 2351764,
        [Description("Sa-Lews 1")]
        [Length(66)]
        [Columns(12)]
        [Rows(12)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        SaLews1 = 2356128,
        [Description("De-Vars")]
        [Length(40)]
        [Columns(12)]
        [Rows(12)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        DeVars1 = 2358954,
        [Description("Gy-Laguiah 1")]
        [Length(60)]
        [Columns(10)]
        [Rows(10)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        GyLaguiah1 = 2365106,
        [Description("Juza 1")]
        [Length(28)]
        [Columns(6)]
        [Rows(7)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        Juza1 = 2368486,
        [Description("Chaos Sorcerer 1")]
        [Length(28)]
        [Columns(8)]
        [Rows(10)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        ChaosSorcerer = 2370188,
        [Description("Zombie 1")]
        [Length(10)]
        [Columns(4)]
        [Rows(7)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        Zombie1 = 2372632,
        [Description("Motavia Desert BG 1")]
        [Length(778)]
        [Columns(64)]
        [Rows(24)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        MotaviaDesertBG1 = 2500448,
        [Description("Motavia Beach BG 1")]
        [Length(784)]
        [Columns(64)]
        [Rows(24)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        MotaviaBeachBG1 = 2506726,
        [Description("Motavia Sea BG 1")]
        [Length(822)]
        [Columns(64)]
        [Rows(24)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        MotaviaSeaBG1 = 2513522,
        [Description("Motavia Grass BG 1")]
        [Length(1022)]
        [Columns(64)]
        [Rows(24)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        MotaviaGrassBG1 = 2521740,
        [Description("Dezolis BG 1")]
        [Length(700)]
        [Columns(64)]
        [Rows(24)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        DezolisBG1 = 2529170,
        [Description("Bio Plant BG 1")]
        [Length(442)]
        [Columns(64)]
        [Rows(24)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        BioPlantBG1 = 2532556,
        [Description("Academy Basement BG 1")]
        [Length(716)]
        [Columns(64)]
        [Rows(24)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        AcademyBasementBG1 = 2534024,
        [Description("Ladea Tower BG 1")]
        [Length(460)]
        [Columns(64)]
        [Rows(24)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        LadeaTowerBG1 = 2539110,
        [Description("Air Castle BG 1")]
        [Length(528)]
        [Columns(64)]
        [Rows(24)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        AirCastleBG1 = 2544150,
        [Description("Garuberk Tower BG 1")]
        [Length(482)]
        [Columns(64)]
        [Rows(24)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        GaruberkTowerBG1 = 2551186,
        [Description("Tonoe Basement BG 1")]
        [Length(810)]
        [Columns(64)]
        [Rows(24)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        TonoeBasementBG1 = 2556622,
        [Description("Monsen Cave BG 1")]
        [Length(638)]
        [Columns(64)]
        [Rows(24)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        MonsenCaveBG1 = 2561566,
        [Description("Soldier Island BG 1")]
        [Length(784)]
        [Columns(64)]
        [Rows(24)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        SoldierIslandBG1 = 2566050,
        [Description("Rykros BG 1")]
        [Length(918)]
        [Columns(64)]
        [Rows(24)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        RykrosBG1 = 2574508,
        [Description("Zema BG 1")]
        [Length(630)]
        [Columns(64)]
        [Rows(24)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        ZemaBG1 = 2580832,
        [Description("Reshel BG 1")]
        [Length(584)]
        [Columns(64)]
        [Rows(24)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        ReshelBG1 = 2588102,
        [Description("Rykros Tower BG 1")]
        [Length(496)]
        [Columns(64)]
        [Rows(24)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        RykrosTowerBG1 = 2591804,
        [Description("The Edge Map BG 1")]
        [Length(300)]
        [Columns(64)]
        [Rows(24)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        TheEdgeMapBG1 = 2600148,
        [Description("Landrover FG 1")]
        [Length(264)]
        [Columns(40)]
        [Rows(13)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        LandroverFG1 = 2602942,
        [Description("Ice Digger FG 1")]
        [Length(250)]
        [Columns(40)]
        [Rows(13)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        IceDiggerFG1 = 2605790,
        [Description("Hydrofoil FG 1")]
        [Length(232)]
        [Columns(40)]
        [Rows(13)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        HydrofoilFG1 = 2608998,
        [Description("N-Sphere 1")]
        [Length(130)]
        [Columns(64)]
        [Rows(24)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        NSphere1 = 2610910,
        [Description("Unknown 2718008")]
        [Length(40)]
        [Columns(5)]
        [Rows(4)]
        [Offset(0)]
        [Compression(CompressionType.None)]
        Unknown2718008 = 2718008,
        [Description("Chaz Status")]
        [Length(200)]
        [Columns(10)]
        [Rows(10)]
        [Offset(128)]
        [Compression(CompressionType.None)]
        ChazStatus = 2733508,
        [Description("Alys Status")]
        [Length(200)]
        [Columns(10)]
        [Rows(10)]
        [Offset(128)]
        [Compression(CompressionType.None)]
        AlysStatus = 2733708,
        [Description("Hahn Status")]
        [Length(200)]
        [Columns(10)]
        [Rows(10)]
        [Offset(128)]
        [Compression(CompressionType.None)]
        HahnStatus = 2733908,
        [Description("Rune Status")]
        [Length(200)]
        [Columns(10)]
        [Rows(10)]
        [Offset(128)]
        [Compression(CompressionType.None)]
        RuneStatus = 2734108,
        [Description("Gryz Status")]
        [Length(200)]
        [Columns(10)]
        [Rows(10)]
        [Offset(128)]
        [Compression(CompressionType.None)]
        GryzStatus = 2734308,
        [Description("Rika Status")]
        [Length(200)]
        [Columns(10)]
        [Rows(10)]
        [Offset(128)]
        [Compression(CompressionType.None)]
        RikaStatus = 2734508,
        [Description("Demi Status")]
        [Length(200)]
        [Columns(10)]
        [Rows(10)]
        [Offset(128)]
        [Compression(CompressionType.None)]
        DemiStatus = 2734708,
        [Description("Wren Status")]
        [Length(200)]
        [Columns(10)]
        [Rows(10)]
        [Offset(128)]
        [Compression(CompressionType.None)]
        WrenStatus = 2734908,
        [Description("Raja Status")]
        [Length(200)]
        [Columns(10)]
        [Rows(10)]
        [Offset(128)]
        [Compression(CompressionType.None)]
        RajaStatus = 2735108,
        [Description("Kyra Status")]
        [Length(200)]
        [Columns(10)]
        [Rows(10)]
        [Offset(128)]
        [Compression(CompressionType.None)]
        KyraStatus = 2735308,
        [Description("Seth Status")]
        [Length(200)]
        [Columns(10)]
        [Rows(10)]
        [Offset(128)]
        [Compression(CompressionType.None)]
        SethStatus = 2735508,
        [Description("Dialog 1")]
        [Length(72)]
        [Columns(6)]
        [Rows(6)]
        [Offset(92)]
        [Compression(CompressionType.None)]
        Dialog1 = 2763574,
        [Description("Rune Intro 1")]
        [Length(142)]
        [Columns(40)]
        [Rows(11)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        RuneIntro1 = 3098510,
        [Description("Rika Intro 1")]
        [Length(84)]
        [Columns(40)]
        [Rows(11)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        RikaIntro1 = 3098652,
        [Description("Wren Intro 1")]
        [Length(134)]
        [Columns(14)]
        [Rows(28)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        WrenIntro1 = 3098736,
        [Description("Chaz Intro 1")]
        [Length(158)]
        [Columns(14)]
        [Rows(28)]
        [Offset(0)]
        [Compression(CompressionType.Enigma)]
        ChazIntro1 = 3098870
    }

    /// <summary>
    /// Sprite type enumeration
    /// </summary>
    public enum SpriteType
    {
        [Description("PSIV Title Intro")]
        [PaletteGroupID(1911228)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 1885306 })]
        [TileMapIDs(new int[] { 1908978 })]
        PSIVTitleIntro = 0,
        [Description("Sub Title Intro")]
        [PaletteGroupID(1911228)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 1887914 })]
        [TileMapIDs(new int[] { 1909030 })]
        SubTitleIntro = 1,
        [Description("Copyright Intro")]
        [PaletteGroupID(1911228)]
        [PaletteIndex(1)]
        [TilesetIDs(new int[] { 1889136 })]
        [TileMapIDs(new int[] { 1909074 })]
        CopyrightIntro = 2,
        [Description("Press Start Intro")]
        [PaletteGroupID(1911228)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 1888934 })]
        [TileMapIDs(new int[] { 1909088 })]
        PressStartIntro = 3,
        [Description("Scroll Background Intro 1")]
        [PaletteGroupID(1911228)]
        [PaletteIndex(3)]
        [TilesetIDs(new int[] { 1889378 })]
        [TileMapIDs(new int[] { 1909106 })]
        ScrollBackgroundIntro1 = 4,
        [Description("Left Background Intro")]
        [PaletteGroupID(1911228)]
        [PaletteIndex(3)]
        [TilesetIDs(new int[] { 1889378 })]
        [TileMapIDs(new int[] { 1909310 })]
        LeftBackgroundIntro = 5,
        [Description("Scroll Background Intro 2")]
        [PaletteGroupID(1911228)]
        [PaletteIndex(3)]
        [TilesetIDs(new int[] { 1889378 })]
        [TileMapIDs(new int[] { 1909450 })]
        ScrollBackgroundIntro2 = 6,
        [Description("Right Background Intro")]
        [PaletteGroupID(1911228)]
        [PaletteIndex(3)]
        [TilesetIDs(new int[] { 1889378 })]
        [TileMapIDs(new int[] { 1909612 })]
        RightBackgroundIntro = 7,
        [Description("Motavia Prologue")]
        [PaletteGroupID(1911356)]
        [PaletteIndex(1)]
        [TilesetIDs(new int[] { 1896946 })]
        [TileMapIDs(new int[] { 1910206 })]
        MotaviaPrologue = 8,
        [Description("Asteroids Intro")]
        [PaletteGroupID(1911356)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 1902626 })]
        [TileMapIDs(new int[] { 1910544 })]
        AsteroidsIntro = 9,
        [Description("Helex")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2151078, 2151112, 2151920, 2152316 })]
        [TileMapIDs(new int[] { 2152528 })]
        Helex = 10,
        [Description("Monster Fly")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2151078, 2151112, 2151920, 2152316 })]
        [TileMapIDs(new int[] { 2152528 })]
        MonsterFly = 11,
        [Description("Gunner Bit")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2152620, 2152560, 2153584, 2153702, 2154096 })]
        [TileMapIDs(new int[] { 2154258 })]
        GunnerBit = 12,
        [Description("Sensor Bit")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2152620, 2152560, 2153584, 2153702, 2154096 })]
        [TileMapIDs(new int[] { 2154258 })]
        SensorBit = 13,
        [Description("Protect Bit")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2152620, 2152560, 2153584, 2153702, 2154096 })]
        [TileMapIDs(new int[] { 2154258 })]
        ProtectBit = 14,
        [Description("Forced Fly")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2151078, 2151112, 2151920, 2152316 })]
        [TileMapIDs(new int[] { 2152528 })]
        ForcedFly = 15,
        [Description("Neo Whistle")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2154292, 2154590, 2155518, 2155666, 2155828 })]
        [TileMapIDs(new int[] { 2156748 })]
        NeoWhistle = 16,
        [Description("Seeker")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2154292, 2154590, 2155518, 2155666, 2155828 })]
        [TileMapIDs(new int[] { 2156748 })]
        Seeker = 17,
        [Description("Sweeper")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2154292, 2154590, 2155518, 2155666, 2155828 })]
        [TileMapIDs(new int[] { 2156748 })]
        Sweeper = 18,
        [Description("Xanafalgue")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2156776, 2156932, 2157610 })]
        [TileMapIDs(new int[] { 2157770 })]
        Xanafalgue = 19,
        [Description("Zoran Bult")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2157800, 2157888, 2158686 })]
        [TileMapIDs(new int[] { 2159064 })]
        ZoranBult = 20,
        [Description("Gicefalgue")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2157800, 2157888, 2158686 })]
        [TileMapIDs(new int[] { 2159064 })]
        Gicefalgue = 21,
        [Description("Igglanova")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2159094, 2159516, 2162892 })]
        [TileMapIDs(new int[] { 2163508 })]
        Igglanova = 22,
        [Description("Guilgenova")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2159094, 2159516, 2162892 })]
        [TileMapIDs(new int[] { 2163508 })]
        Guilgenova = 23,
        [Description("Locusta")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2163558, 2165152, 2166144, 2166524 })]
        [TileMapIDs(new int[] { 2167698 })]
        Locusta = 24,
        [Description("Fanbite")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2163558, 2165152, 2166144, 2166524 })]
        [TileMapIDs(new int[] { 2167698 })]
        Fanbite = 25,
        [Description("Grass Hound")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2163558, 2165152, 2166144, 2166524 })]
        [TileMapIDs(new int[] { 2167698 })]
        GrassHound = 26,
        [Description("Slave")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2167902, 2168374, 2169858 })]
        [TileMapIDs(new int[] { 2170210 })]
        Slave = 27,
        [Description("Servant")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2167902, 2168374, 2169858 })]
        [TileMapIDs(new int[] { 2170210 })]
        Servant = 28,
        [Description("Blauzen")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2170716, 2171020, 2172212, 2172644, 2173596, 2173974, 2174366 })]
        [TileMapIDs(new int[] { 2172170 })]
        Blauzen = 29,
        [Description("Silvalt")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2170716, 2171020, 2172212, 2172644, 2173596, 2173974, 2174366 })]
        [TileMapIDs(new int[] { 2172170 })]
        Silvalt = 30,
        [Description("Goldine")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2170716, 2171020, 2172212, 2172644, 2173596, 2173974, 2174366 })]
        [TileMapIDs(new int[] { 2172170 })]
        Goldine = 31,
        [Description("Tarantella")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2148354, 2148432, 2149368 })]
        [TileMapIDs(new int[] { 2151052 })]
        Tarantella = 32,
        [Description("Arthropod")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2148354, 2148432, 2149368 })]
        [TileMapIDs(new int[] { 2151052 })]
        Arthropod = 33,
        [Description("Worker Pod")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2145772, 2146028, 2146696, 2147690 })]
        [TileMapIDs(new int[] { 2148312 })]
        WorkerPod = 34,
        [Description("Wiredine")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2145772, 2146028, 2146696, 2147690 })]
        [TileMapIDs(new int[] { 2148312 })]
        Wiredine = 35,
        [Description("Life Deleter")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2143292, 2144102, 2144256, 2144674 })]
        [TileMapIDs(new int[] { 2145718 })]
        LifeDeleter = 36,
        [Description("Balduel")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2174650, 2174784, 2176870, 2175916, 2177026, 2177460 })]
        [TileMapIDs(new int[] { 2177724 })]
        Balduel = 37,
        [Description("Dragerduel")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2174650, 2174784, 2176870, 2175916, 2177026, 2177460 })]
        [TileMapIDs(new int[] { 2177724 })]
        Dragerduel = 38,
        [Description("Jurafaduel")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2174650, 2174784, 2176870, 2175916, 2177026, 2177460 })]
        [TileMapIDs(new int[] { 2177724 })]
        Jurafaduel = 39,
        [Description("Crawler")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2140826, 2140834, 2142422 })]
        [TileMapIDs(new int[] { 2143274 })]
        Crawler = 40,
        [Description("Carrion Cr")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2140826, 2140834, 2142422 })]
        [TileMapIDs(new int[] { 2143274 })]
        CarrionCr = 41,
        [Description("Caterpillar")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2140826, 2140834, 2142422 })]
        [TileMapIDs(new int[] { 2143274 })]
        Caterpillar = 42,
        [Description("Blob")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2135910, 2134592, 2134600, 2135542 })]
        [TileMapIDs(new int[] { 2137710 })]
        Blob = 43,
        [Description("Zol Slug")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2135910, 2134592, 2134600, 2135542 })]
        [TileMapIDs(new int[] { 2137710 })]
        ZolSlug = 44,
        [Description("Jr. Ooze")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2135910, 2134592, 2134600, 2135542 })]
        [TileMapIDs(new int[] { 2137710 })]
        JrOoze = 45,
        [Description("Meta Slug")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2137782, 2139272 })]
        [TileMapIDs(new int[] { 2140764 })]
        MetaSlug = 46,
        [Description("Snow Slug")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2137782, 2139272 })]
        [TileMapIDs(new int[] { 2140764 })]
        SnowSlug = 47,
        [Description("Fract Ooze")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2137782, 2139272 })]
        [TileMapIDs(new int[] { 2140764 })]
        FractOoze = 48,
        [Description("Tower")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2132396, 2133286, 2132994, 2133710, 2133830, 2134306 })]
        [TileMapIDs(new int[] { 2134498 })]
        Tower = 49,
        [Description("C-Ray Tube")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2132396, 2133286, 2132994, 2133710, 2133830, 2134306 })]
        [TileMapIDs(new int[] { 2134498 })]
        CRayTube = 50,
        [Description("Arm Drone")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2128774, 2128824, 2129388 })]
        [TileMapIDs(new int[] { 2131012 })]
        ArmDrone = 51,
        [Description("Satellite Minion")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2128774, 2128824, 2129388 })]
        [TileMapIDs(new int[] { 2131012 })]
        SatelliteMinion = 52,
        [Description("Star Drone")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2128774, 2128824, 2129388 })]
        [TileMapIDs(new int[] { 2131012 })]
        StarDrone = 53,
        [Description("Float Mine 1")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2131046, 2131244, 2131840 })]
        [TileMapIDs(new int[] { 2132366 })]
        FloatMine1 = 54,
        [Description("Command Ball")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2131046, 2131244, 2131840 })]
        [TileMapIDs(new int[] { 2132366 })]
        CommandBall = 55,
        [Description("Vorpal Sphere")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2131046, 2131244, 2131840 })]
        [TileMapIDs(new int[] { 2132366 })]
        VorpalSphere = 56,
        [Description("Warren 286")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2127308, 2127834, 2127952, 2128614 })]
        [TileMapIDs(new int[] { 2128758 })]
        Warren286 = 57,
        [Description("Siren 386")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2127308, 2127834, 2127952, 2128614 })]
        [TileMapIDs(new int[] { 2128758 })]
        Siren386 = 58,
        [Description("Browren 486")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2127308, 2127834, 2127952, 2128614 })]
        [TileMapIDs(new int[] { 2128758 })]
        Browren486 = 59,
        [Description("Float Mine 2")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2131046, 2131244, 2131840 })]
        [TileMapIDs(new int[] { 2132366 })]
        FloatMine2 = 60,
        [Description("Loader")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2124320, 2125080, 2125260, 2125462 })]
        [TileMapIDs(new int[] { 2125418 })]
        Loader = 61,
        [Description("Debugger")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2124320, 2125080, 2125260, 2125462 })]
        [TileMapIDs(new int[] { 2125418 })]
        Debugger = 62,
        [Description("Dominator")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2124320, 2125080, 2125260, 2125462 })]
        [TileMapIDs(new int[] { 2125418 })]
        Dominator = 63,
        [Description("Whistle")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2120832, 2121096 })]
        [TileMapIDs(new int[] { 2121456 })]
        Whistle = 64,
        [Description("Tracer")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2120832, 2121096 })]
        [TileMapIDs(new int[] { 2121456 })]
        Tracer = 65,
        [Description("Sand Newt")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2116010, 2116356, 2117826 })]
        [TileMapIDs(new int[] { 2117796 })]
        SandNewt = 66,
        [Description("Mistral Gecko")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2116010, 2116356, 2117826 })]
        [TileMapIDs(new int[] { 2117796 })]
        MistralGecko = 67,
        [Description("Flame Newt")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2116010, 2116356, 2117826 })]
        [TileMapIDs(new int[] { 2117796 })]
        FlameNewt = 68,
        [Description("Stone Heads")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2120086, 2120568 })]
        [TileMapIDs(new int[] { 2120794 })]
        StoneHeads = 69,
        [Description("Crimson Heads")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2120086, 2120568 })]
        [TileMapIDs(new int[] { 2120794 })]
        CrimsonHeads = 70,
        [Description("Blind Heads")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2120086, 2120568 })]
        [TileMapIDs(new int[] { 2120794 })]
        BlindHeads = 71,
        [Description("Abe Frog")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2109504, 2109874, 2113970 })]
        [TileMapIDs(new int[] { 2113944 })]
        AbeFrog = 72,
        [Description("Gerotlux")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2109504, 2109874, 2113970 })]
        [TileMapIDs(new int[] { 2113944 })]
        Gerotlux = 73,
        [Description("Dark Marauder")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2103162, 2104594, 2104846, 2108570 })]
        [TileMapIDs(new int[] { 2104798 })]
        DarkMarauder = 74,
        [Description("Death Bearer")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2103162, 2104594, 2104846, 2108570 })]
        [TileMapIDs(new int[] { 2104798 })]
        DeathBearer = 75,
        [Description("Chaos Bringer")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2103162, 2104594, 2104846, 2108570 })]
        [TileMapIDs(new int[] { 2104798 })]
        ChaosBringer = 76,
        [Description("Scorpirus")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2100136, 2100518, 2102240 })]
        [TileMapIDs(new int[] { 2102180 })]
        Scorpirus = 77,
        [Description("Rajago")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2100136, 2100518, 2102240 })]
        [TileMapIDs(new int[] { 2102180 })]
        Rajago = 78,
        [Description("Biter Fly")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2100136, 2100518, 2102240 })]
        [TileMapIDs(new int[] { 2102180 })]
        BiterFly = 79,
        [Description("Shadow Saber")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2097152, 2097646, 2099594 })]
        [TileMapIDs(new int[] { 2097616 })]
        ShadowSaber = 80,
        [Description("Frost Saber")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2097152, 2097646, 2099594 })]
        [TileMapIDs(new int[] { 2097616 })]
        FrostSaber = 81,
        [Description("Blood Saber")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2097152, 2097646, 2099594 })]
        [TileMapIDs(new int[] { 2097616 })]
        BloodSaber = 82,
        [Description("Dimension Worm")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2215642, 2215650, 2216114 })]
        [TileMapIDs(new int[] { 2216104 })]
        DimensionWorm = 83,
        [Description("Outer Beast")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2215642, 2215650, 2216114 })]
        [TileMapIDs(new int[] { 2216104 })]
        OuterBeast = 84,
        [Description("Flatter Plant")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2213010, 2213180, 2213744, 2214256, 2214484, 2215560 })]
        [TileMapIDs(new int[] { 2213706 })]
        FlatterPlant = 85,
        [Description("Fly Screamer")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2213010, 2213180, 2213744, 2214256, 2214484, 2215560 })]
        [TileMapIDs(new int[] { 2213706 })]
        FlyScreamer = 86,
        [Description("Technique Plant")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2213010, 2213180, 2213744, 2214256, 2214484, 2215560 })]
        [TileMapIDs(new int[] { 2213706 })]
        TechniquePlant = 87,
        [Description("Toadstool")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2207482, 2207742, 2209076 })]
        [TileMapIDs(new int[] { 2209054 })]
        Toadstool = 88,
        [Description("Shrieker")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2207482, 2207742, 2209076 })]
        [TileMapIDs(new int[] { 2209054 })]
        Shrieker = 89,
        [Description("Sand Worm")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2202284, 2202292, 2206210, 2206876 })]
        [TileMapIDs(new int[] { 2206182 })]
        SandWorm = 90,
        [Description("Desert Leech")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2202284, 2202292, 2206210, 2206876 })]
        [TileMapIDs(new int[] { 2206182 })]
        DesertLeech = 91,
        [Description("Leviathan")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2202284, 2202292, 2206210, 2206876 })]
        [TileMapIDs(new int[] { 2206182 })]
        Leviathan = 92,
        [Description("Ripper")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2198854, 2199524, 2200064, 2201338, 2201616, 2201980 })]
        [TileMapIDs(new int[] { 2200040 })]
        Ripper = 93,
        [Description("Blade Right")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2198854, 2199524, 2200064, 2201338, 2201616, 2201980 })]
        [TileMapIDs(new int[] { 2200040 })]
        BladeRight = 94,
        [Description("Piercer")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2197508, 2198208, 2198618 })]
        [TileMapIDs(new int[] { 2198182 })]
        Piercer = 95,
        [Description("Haken Left")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2197508, 2198208, 2198618 })]
        [TileMapIDs(new int[] { 2198182 })]
        HakenLeft = 96,
        [Description("Twin Arms")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2193974, 2195396, 2195972, 2196472, 2196554, 2197088, 2197194 })]
        [TileMapIDs(new int[] { 2195366 })]
        TwinArms = 97,
        [Description("Soldier Fiend")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2193974, 2195396, 2195972, 2196472, 2196554, 2197088, 2197194 })]
        [TileMapIDs(new int[] { 2195366 })]
        SoldierFiend = 98,
        [Description("Ismounos")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2190074, 2190470, 2191686, 2192072, 2192772 })]
        [TileMapIDs(new int[] { 2190430 })]
        Ismounos = 99,
        [Description("Depcen")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2190074, 2190470, 2191686, 2192072, 2192772 })]
        [TileMapIDs(new int[] { 2190430 })]
        Depcen = 100,
        [Description("Hewgilla")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2184550, 2184780 })]
        [TileMapIDs(new int[] { 2184738 })]
        Hewgilla = 101,
        [Description("Elmelew")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2184550, 2184780 })]
        [TileMapIDs(new int[] { 2184738 })]
        Elmelew = 102,
        [Description("Mini Worm")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2209818, 2209826, 2210994, 2211582 })]
        [TileMapIDs(new int[] { 2210984 })]
        MiniWorm = 103,
        [Description("Infant Worm 1")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2209818, 2209826, 2210994, 2211582 })]
        [TileMapIDs(new int[] { 2210984 })]
        InfantWorm1 = 104,
        [Description("Snow Worm")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2209818, 2209826, 2210994, 2211582 })]
        [TileMapIDs(new int[] { 2210984 })]
        SnowWorm = 105,
        [Description("Centaur")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2186886, 2187922 })]
        [TileMapIDs(new int[] { 2187896 })]
        Centaur = 106,
        [Description("King Saber")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2186886, 2187922 })]
        [TileMapIDs(new int[] { 2187896 })]
        KingSaber = 107,
        [Description("Dark Rider")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2186886, 2187922 })]
        [TileMapIDs(new int[] { 2187896 })]
        DarkRider = 108,
        [Description("Technique User")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2183006, 2183498, 2181940, 2183890 })]
        [TileMapIDs(new int[] { 2183488 })]
        TechniqueUser = 109,
        [Description("Technique Master")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2183006, 2183498, 2181940, 2183890 })]
        [TileMapIDs(new int[] { 2183488 })]
        TechniqueMaster = 110,
        [Description("Dark Witch")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2183006, 2183498, 2181940, 2183890 })]
        [TileMapIDs(new int[] { 2183488 })]
        DarkWitch = 111,
        [Description("Speard")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2181278, 2181796 })]
        [TileMapIDs(new int[] { 2181776 })]
        Speard = 112,
        [Description("Zios Guard")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2181278, 2181796 })]
        [TileMapIDs(new int[] { 2181776 })]
        ZiosGuard = 113,
        [Description("Acacia")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2179114, 2179318, 2180232, 2180540, 2180786 })]
        [TileMapIDs(new int[] { 2179272 })]
        Acacia = 114,
        [Description("Shadow Mirage")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2179114, 2179318, 2180232, 2180540, 2180786 })]
        [TileMapIDs(new int[] { 2179272 })]
        ShadowMirage = 115,
        [Description("Haunt")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2177780, 2177814, 2178926, 2179010 })]
        [TileMapIDs(new int[] { 2177788 })]
        Haunt = 116,
        [Description("Spector")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2177780, 2177814, 2178926, 2179010 })]
        [TileMapIDs(new int[] { 2177788 })]
        Spector = 117,
        [Description("Phantom")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2177780, 2177814, 2178926, 2179010 })]
        [TileMapIDs(new int[] { 2177788 })]
        Phantom = 118,
        [Description("Zombie")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2372624, 2372642 })]
        [TileMapIDs(new int[] { 2372632 })]
        Zombie = 119,
        [Description("Ghoul")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2372624, 2372642 })]
        [TileMapIDs(new int[] { 2372632 })]
        Ghoul = 120,
        [Description("Chaos Sorcerer")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2369040, 2370216, 2370460, 2372284 })]
        [TileMapIDs(new int[] { 2370188 })]
        ChaosSorcerer = 121,
        [Description("Illusionist")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2369040, 2370216, 2370460, 2372284 })]
        [TileMapIDs(new int[] { 2370188 })]
        Illusionist = 122,
        [Description("Imagio Mage")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2369040, 2370216, 2370460, 2372284 })]
        [TileMapIDs(new int[] { 2370188 })]
        ImagioMage = 123,
        [Description("Juza")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2368114, 2368514, 2368946 })]
        [TileMapIDs(new int[] { 2368486 })]
        Juza = 124,
        [Description("Greneris")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2368114, 2368514, 2368946 })]
        [TileMapIDs(new int[] { 2368486 })]
        Greneris = 125,
        [Description("Radhin")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2368114, 2368514, 2368946 })]
        [TileMapIDs(new int[] { 2368486 })]
        Radhin = 126,
        [Description("Gy-Laguiah")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2364772, 2365166, 2366554, 2367308 })]
        [TileMapIDs(new int[] { 2365106 })]
        GyLaguiah = 127,
        [Description("Lw-Addmer")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2364772, 2365166, 2366554, 2367308 })]
        [TileMapIDs(new int[] { 2365106 })]
        LwAddmer = 128,
        [Description("Cula-Bellr")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2364772, 2365166, 2366554, 2367308 })]
        [TileMapIDs(new int[] { 2365106 })]
        CulaBellr = 129,
        [Description("De-Vars")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2358946, 2358994, 2362786 })]
        [TileMapIDs(new int[] { 2358954 })]
        DeVars = 130,
        [Description("Sa-Lews")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2355926, 2356194, 2358836 })]
        [TileMapIDs(new int[] { 2356128 })]
        SaLews = 131,
        [Description("D-Elm-Lars")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2351164, 2351810, 2352560, 2354430, 2354872, 2355262, 2355590 })]
        [TileMapIDs(new int[] { 2351764 })]
        DElmLars = 132,
        [Description("Xe-A-Thoul")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2351164, 2351810, 2352560, 2354430, 2354872, 2355262, 2355590 })]
        [TileMapIDs(new int[] { 2351764 })]
        XeAThoul = 133,
        [Description("Le-Faw-Gan")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2351164, 2351810, 2352560, 2354430, 2354872, 2355262, 2355590 })]
        [TileMapIDs(new int[] { 2351764 })]
        LeFawGan = 134,
        [Description("Gi-Le-Farg")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2351164, 2351810, 2352560, 2354430, 2354872, 2355262, 2355590 })]
        [TileMapIDs(new int[] { 2351764 })]
        GiLeFarg = 135,
        [Description("Alys (Boss)")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2347880, 2347908, 2349288 })]
        [TileMapIDs(new int[] { 2347888 })]
        AlysBoss = 136,
        [Description("Re-Faze")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2346138, 2346174 })]
        [TileMapIDs(new int[] { 2346146 })]
        ReFaze = 137,
        [Description("Lashiec")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2337594, 2338730, 2341290, 2342322, 2342934, 2344494, 2344736 })]
        [TileMapIDs(new int[] { 2338652 })]
        Lashiec = 138,
        [Description("Carnivorous Tree")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2330082, 2335270 })]
        [TileMapIDs(new int[] { 2330090 })]
        CarnivorousTree = 139,
        [Description("Dark Force 1")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2319284, 2325088, 2327798 })]
        [TileMapIDs(new int[] { 2322108 })]
        DarkForce1 = 140,
        [Description("Dark Force 2")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2310988, 2315124, 2316294, 2316518, 2317922, 2318532 })]
        [TileMapIDs(new int[] { 2314962 })]
        DarkForce2 = 141,
        [Description("Dark Force 3")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2300004, 2304524, 2305908, 2310918 })]
        [TileMapIDs(new int[] { 2304418 })]
        DarkForce3 = 142,
        [Description("Profound Darkness 1")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2289110 })]
        [TileMapIDs(new int[] { 2291756 })]
        ProfoundDarkness1 = 143,
        [Description("Profound Darkness 2")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2258098 })]
        [TileMapIDs(new int[] { 2261812 })]
        ProfoundDarkness2 = 144,
        [Description("Profound Darkness 3")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2251590 })]
        [TileMapIDs(new int[] { 2256898 })]
        ProfoundDarkness3 = 145,
        [Description("Sand Worm (Guild Job)")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2202284, 2202292, 2206210, 2206876 })]
        [TileMapIDs(new int[] { 2206182 })]
        SandWormGuildJob = 146,
        [Description("Fract Ooze (Boss)")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2137782, 2139272 })]
        [TileMapIDs(new int[] { 2140764 })]
        FractOozeBoss = 147,
        [Description("Chaos Sorcerer (Boss)")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2369040, 2370216, 2370460, 2372284 })]
        [TileMapIDs(new int[] { 2370188 })]
        ChaosSorcererBoss = 148,
        [Description("Zio 3")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2221890 })]
        [TileMapIDs(new int[] { 2223326 })]
        Zio3 = 149,
        [Description("Zio 2")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2221890, 2223440, 2223568, 2225080, 2225522, 2225876, 2226208, 2227642 })]
        [TileMapIDs(new int[] { 2223384 })]
        Zio2 = 150,
        [Description("Dezo Owl")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2249158, 2249494, 2249648 })]
        [TileMapIDs(new int[] { 2249460 })]
        DezoOwl = 151,
        [Description("Sky Tiara")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2249158, 2249494, 2249648 })]
        [TileMapIDs(new int[] { 2249460 })]
        SkyTiara = 152,
        [Description("Owl Talon")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2249158, 2249494, 2249648 })]
        [TileMapIDs(new int[] { 2249460 })]
        OwlTalon = 153,
        [Description("Snow Mole")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2244454, 2244700, 2245396, 2246046, 2248296 })]
        [TileMapIDs(new int[] { 2244672 })]
        SnowMole = 154,
        [Description("Red Mole")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2244454, 2244700, 2245396, 2246046, 2248296 })]
        [TileMapIDs(new int[] { 2244672 })]
        RedMole = 155,
        [Description("Hungry Mole")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2244454, 2244700, 2245396, 2246046, 2248296 })]
        [TileMapIDs(new int[] { 2244672 })]
        HungryMole = 156,
        [Description("Rappy")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2234698, 2234716, 2236338, 2237996 })]
        [TileMapIDs(new int[] { 2234706 })]
        Rappy = 157,
        [Description("Blue Rappy")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2234698, 2234716, 2236338, 2237996 })]
        [TileMapIDs(new int[] { 2234706 })]
        BlueRappy = 158,
        [Description("King Rappy")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2227796, 2229112, 2229612 })]
        [TileMapIDs(new int[] { 2229090 })]
        KingRappy = 159,
        [Description("Infant Worm 2")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2209818, 2209826, 2210994, 2211582 })]
        [TileMapIDs(new int[] { 2210984 })]
        InfantWorm2 = 160,
        [Description("Prophallus")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2240016, 2241396, 2241476 })]
        [TileMapIDs(new int[] { 2241344 })]
        Prophallus = 161,
        [Description("Zio 1")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2221890 })]
        [TileMapIDs(new int[] { 2223326 })]
        Zio1 = 162,
        [Description("Unknown2121478")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2121478, 2122010, 2122526, 2123520 })]
        [TileMapIDs(new int[] { 2127024 })]
        Unknown2121478 = 163,
        [Description("Zio BG")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2217558 })]
        [TileMapIDs(new int[] { 2221654 })]
        ZioBG = 164,
        [Description("Dark Force 1 BG")]
        [PaletteGroupID(29536)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2322304 })]
        [TileMapIDs(new int[] { 2324634 })]
        DarkForce1BG = 165,
        [Description("Carnivorous Trees BG")]
        [PaletteGroupID(29510)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2330116 })]
        [TileMapIDs(new int[] { 2334748 })]
        CarnivorousTreesBG = 166,
        [Description("Motavia Desert BG")]
        [PaletteGroupID(28756)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2492864 })]
        [TileMapIDs(new int[] { 2500448 })]
        MotaviaDesertBG = 167,
        [Description("Motavia Beach BG")]
        [PaletteGroupID(28782)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2501226 })]
        [TileMapIDs(new int[] { 2506726 })]
        MotaviaBeachBG = 168,
        [Description("Motavia Sea BG")]
        [PaletteGroupID(28834)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2507510 })]
        [TileMapIDs(new int[] { 2513522 })]
        MotaviaSeaBG = 169,
        [Description("Motavia Grass BG")]
        [PaletteGroupID(28808)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2514344 })]
        [TileMapIDs(new int[] { 2521740 })]
        MotaviaGrassBG = 170,
        [Description("Dezolis BG")]
        [PaletteGroupID(28860)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2522762 })]
        [TileMapIDs(new int[] { 2529170 })]
        DezolisBG = 171,
        [Description("Bio Plant BG")]
        [PaletteGroupID(28912)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2529870 })]
        [TileMapIDs(new int[] { 2532556 })]
        BioPlantBG = 172,
        [Description("Academy Basement BG")]
        [PaletteGroupID(29094)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2532998 })]
        [TileMapIDs(new int[] { 2534024 })]
        AcademyBasementBG = 173,
        [Description("Ladea Tower BG")]
        [PaletteGroupID(29120)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2534740 })]
        [TileMapIDs(new int[] { 2539110 })]
        LadeaTowerBG = 174,
        [Description("Air Castle BG")]
        [PaletteGroupID(29172)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2539570 })]
        [TileMapIDs(new int[] { 2544150 })]
        AirCastleBG = 175,
        [Description("Garuberk Tower BG")]
        [PaletteGroupID(29198)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2544678 })]
        [TileMapIDs(new int[] { 2551186 })]
        GaruberkTowerBG = 176,
        [Description("Tonoe Basement BG")]
        [PaletteGroupID(29224)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2551668 })]
        [TileMapIDs(new int[] { 2556622 })]
        TonoeBasementBG = 177,
        [Description("Monsen Cave BG")]
        [PaletteGroupID(29276)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2557432 })]
        [TileMapIDs(new int[] { 2561566 })]
        MonsenCaveBG = 178,
        [Description("Soldier Island BG")]
        [PaletteGroupID(29250)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2562204 })]
        [TileMapIDs(new int[] { 2566050 })]
        SoldierIslandBG = 179,
        [Description("Rykros BG")]
        [PaletteGroupID(29328)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2566834 })]
        [TileMapIDs(new int[] { 2574508 })]
        RykrosBG = 180,
        [Description("Zema BG")]
        [PaletteGroupID(29354)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2575426 })]
        [TileMapIDs(new int[] { 2580832 })]
        ZemaBG = 181,
        [Description("Reshel BG")]
        [PaletteGroupID(29380)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2581462 })]
        [TileMapIDs(new int[] { 2588102 })]
        ReshelBG = 182,
        [Description("Rykros Tower BG")]
        [PaletteGroupID(29432)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2588686 })]
        [TileMapIDs(new int[] { 2591804 })]
        RykrosTowerBG = 183,
        [Description("The Edge BG")]
        [PaletteGroupID(29484)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2592300 })]
        [TileMapIDs(new int[] { 2600148 })]
        TheEdgeBG = 184,
        [Description("Landrover FG")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2600448 })]
        [TileMapIDs(new int[] { 2602942 })]
        LandroverFG = 185,
        [Description("Ice Digger FG")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2603206 })]
        [TileMapIDs(new int[] { 2605790 })]
        IceDiggerFG = 186,
        [Description("Hydrofoil FG")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2606040 })]
        [TileMapIDs(new int[] { 2608998 })]
        HydrofoilFG = 187,
        [Description("Vehicle HUD")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2609490, 2609230 })]
        [TileMapIDs(new int[] { 2610910 })]
        VehicleHUD = 188,
        [Description("N-Sphere Effect")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2609584 })]
        [TileMapIDs(new int[] { 2610910 })]
        NSphereEffect = 189,
        [Description("Numbers HUD")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2611040, 2611064 })]
        [TileMapIDs(new int[] { 2610910 })]
        NumbersHUD = 190,
        [Description("Icons HUD")]
        [PaletteGroupID(219998)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2611296, 2611824 })]
        [TileMapIDs(new int[] { 2610910 })]
        IconsHUD = 191,
        [Description("Chaz Field")]
        [PaletteGroupID(2712320)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2686976 })]
        [TileMapIDs(new int[] { 295588 })]
        ChazField = 192,
        [Description("Alys Field")]
        [PaletteGroupID(2712320)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2689280 })]
        [TileMapIDs(new int[] { 295588 })]
        AlysField = 193,
        [Description("Hahn Field")]
        [PaletteGroupID(2712320)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2691584 })]
        [TileMapIDs(new int[] { 295588 })]
        HahnField = 194,
        [Description("Rune Field")]
        [PaletteGroupID(2712320)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2693888 })]
        [TileMapIDs(new int[] { 295588 })]
        RuneField = 195,
        [Description("Gryz Field")]
        [PaletteGroupID(2712320)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2696192 })]
        [TileMapIDs(new int[] { 295588 })]
        GryzField = 196,
        [Description("Rika Field")]
        [PaletteGroupID(2712320)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2698496 })]
        [TileMapIDs(new int[] { 295588 })]
        RikaField = 197,
        [Description("Demi Field")]
        [PaletteGroupID(2712320)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2700800 })]
        [TileMapIDs(new int[] { 295588 })]
        DemiField = 198,
        [Description("Wren Field")]
        [PaletteGroupID(2712320)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2703104 })]
        [TileMapIDs(new int[] { 295588 })]
        WrenField = 199,
        [Description("Raja Field")]
        [PaletteGroupID(2712320)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2705408 })]
        [TileMapIDs(new int[] { 295588 })]
        RajaField = 200,
        [Description("Kyra Field")]
        [PaletteGroupID(2712320)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2707712 })]
        [TileMapIDs(new int[] { 295588 })]
        KyraField = 201,
        [Description("Seth Field")]
        [PaletteGroupID(2712320)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2710016 })]
        [TileMapIDs(new int[] { 295588 })]
        SethField = 202,
        [Description("Land Rover Field")]
        [PaletteGroupID(2717006)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2712352 })]
        [TileMapIDs(new int[] { 2718008 })]
        LandRoverField = 203,
        [Description("Ice Digger Field")]
        [PaletteGroupID(2717038)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2714196 })]
        [TileMapIDs(new int[] { 2718008 })]
        IceDiggerField = 204,
        [Description("Hydrofoil Field")]
        [PaletteGroupID(2717070)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2716068 })]
        [TileMapIDs(new int[] { 2718008 })]
        HydrofoilField = 205,
        [Description("Treasure Chest 1")]
        [PaletteGroupID(2712320)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2717102 })]
        [TileMapIDs(new int[] { 2718008 })]
        TreasureChest1 = 206,
        [Description("Treasure Chest 2")]
        [PaletteGroupID(2712320)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2717300 })]
        [TileMapIDs(new int[] { 2718008 })]
        TreasureChest2 = 207,
        [Description("Chaz Status")]
        [PaletteGroupID(2712320)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2718048 })]
        [TileMapIDs(new int[] { 2733508 })]
        ChazStatus = 208,
        [Description("Alys Status")]
        [PaletteGroupID(2712320)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2719410 })]
        [TileMapIDs(new int[] { 2733708 })]
        AlysStatus = 209,
        [Description("Hahn Status")]
        [PaletteGroupID(2712320)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2720872 })]
        [TileMapIDs(new int[] { 2733908 })]
        HahnStatus = 210,
        [Description("Rune Status")]
        [PaletteGroupID(2712320)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2721938 })]
        [TileMapIDs(new int[] { 2734108 })]
        RuneStatus = 211,
        [Description("Gryz Status")]
        [PaletteGroupID(2712320)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2723328 })]
        [TileMapIDs(new int[] { 2734308 })]
        GryzStatus = 212,
        [Description("Rika Status")]
        [PaletteGroupID(2712320)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2724664 })]
        [TileMapIDs(new int[] { 2734508 })]
        RikaStatus = 213,
        [Description("Demi Status")]
        [PaletteGroupID(2712320)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2726104 })]
        [TileMapIDs(new int[] { 2734708 })]
        DemiStatus = 214,
        [Description("Wren Status")]
        [PaletteGroupID(2712320)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2727832 })]
        [TileMapIDs(new int[] { 2734908 })]
        WrenStatus = 215,
        [Description("Raja Status")]
        [PaletteGroupID(2712320)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2729240 })]
        [TileMapIDs(new int[] { 2735108 })]
        RajaStatus = 216,
        [Description("Kyra Status")]
        [PaletteGroupID(2712320)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2730710 })]
        [TileMapIDs(new int[] { 2735308 })]
        KyraStatus = 217,
        [Description("Seth Status")]
        [PaletteGroupID(2712320)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2732326 })]
        [TileMapIDs(new int[] { 2735508 })]
        SethStatus = 218,
        [Description("Chaz Dialog")]
        [PaletteGroupID(2712320)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2735708 })]
        [TileMapIDs(new int[] { 2763574 })]
        ChazDialog = 219,
        [Description("Alys Dialog")]
        [PaletteGroupID(2712320)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2736396 })]
        [TileMapIDs(new int[] { 2763574 })]
        AlysDialog = 220,
        [Description("Hahn Dialog")]
        [PaletteGroupID(2712320)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2737100 })]
        [TileMapIDs(new int[] { 2763574 })]
        HahnDialog = 221,
        [Description("Rune Dialog")]
        [PaletteGroupID(2712320)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2737696 })]
        [TileMapIDs(new int[] { 2763574 })]
        RuneDialog = 222,
        [Description("Gryz Dialog")]
        [PaletteGroupID(2712320)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2738464 })]
        [TileMapIDs(new int[] { 2763574 })]
        GryzDialog = 223,
        [Description("Rika Dialog")]
        [PaletteGroupID(2712320)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2739136 })]
        [TileMapIDs(new int[] { 2763574 })]
        RikaDialog = 224,
        [Description("Demi Dialog")]
        [PaletteGroupID(2712320)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2739832 })]
        [TileMapIDs(new int[] { 2763574 })]
        DemiDialog = 225,
        [Description("Wren Dialog")]
        [PaletteGroupID(2712320)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2740580 })]
        [TileMapIDs(new int[] { 2763574 })]
        WrenDialog = 226,
        [Description("Raja Dialog")]
        [PaletteGroupID(2712320)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2741212 })]
        [TileMapIDs(new int[] { 2763574 })]
        RajaDialog = 227,
        [Description("Kyra Dialog")]
        [PaletteGroupID(2712320)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2741910 })]
        [TileMapIDs(new int[] { 2763574 })]
        KyraDialog = 228,
        [Description("Seth Dialog")]
        [PaletteGroupID(2712320)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 2742640 })]
        [TileMapIDs(new int[] { 2763574 })]
        SethDialog = 229,
        [Description("Rune Intro")]
        [PaletteGroupID(3099028)]
        [PaletteIndex(0)]
        [TilesetIDs(new int[] { 3084622 })]
        [TileMapIDs(new int[] { 3098510 })]
        RuneIntro = 230,
        [Description("Rika Intro")]
        [PaletteGroupID(3099028)]
        [PaletteIndex(1)]
        [TilesetIDs(new int[] { 3087982 })]
        [TileMapIDs(new int[] { 3098652 })]
        RikaIntro = 231,
        [Description("Wren Intro")]
        [PaletteGroupID(3099028)]
        [PaletteIndex(2)]
        [TilesetIDs(new int[] { 3091102 })]
        [TileMapIDs(new int[] { 3098736 })]
        WrenIntro = 232,
        [Description("Chaz Intro")]
        [PaletteGroupID(3099028)]
        [PaletteIndex(3)]
        [TilesetIDs(new int[] { 3095214 })]
        [TileMapIDs(new int[] { 3098870 })]
        ChazIntro = 233
    }

    /// <summary>
    /// Tileset type enumeration (value(ID) = byte location in ROM)
    /// </summary>
    public enum TilesetType
    {
        //[Description("Motavia 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Motavia1 = 1050626,
        //[Description("Motavia 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Motavia2 = 1056002,
        //[Description("Motavia 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Motavia3 = 1060786,
        //[Description("Motavia 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Motavia4 = 1066210,
        //[Description("Motavia 5")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Motavia5 = 1071538,
        //[Description("Dezolis 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Dezolis1 = 1113992,
        //[Description("Dezolis 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Dezolis2 = 1119528,
        //[Description("Dezolis 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Dezolis3 = 1125432,
        //[Description("Dezolis 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Dezolis4 = 1130328,
        //[Description("Dezolis NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //DezolisNPCs1 = 1132552,
        //[Description("Rykros 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Rykros1 = 1152720,
        //[Description("Piata 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Piata1 = 1165320,
        //[Description("Piata 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Piata2 = 1171048,
        //[Description("Piata 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Piata3 = 1176744,
        //[Description("Piata NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //PiataNPCs1 = 1180760,
        //[Description("Piata NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //PiataNPCs2 = 1182060,
        //[Description("Piata NPCs 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //PiataNPCs3 = 1183116,
        //[Description("Piata NPCs 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //PiataNPCs4 = 1184138,
        //[Description("Piata NPCs 5")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //PiataNPCs5 = 1185280,
        //[Description("Piata NPCs 6")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //PiataNPCs6 = 1186368,
        //[Description("Piata NPCs 7")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //PiataNPCs7 = 1187500,
        //[Description("Piata Academy 1 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //PiataAcademy11 = 1194800,
        //[Description("Piata Academy 1 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //PiataAcademy12 = 1200112,
        //[Description("Piata Academy 1 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //PiataAcademy13 = 1204960,
        //[Description("Piata Academy 1 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //PiataAcademy1NPCs1 = 1182060,
        //[Description("Piata Academy 1 NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //PiataAcademy1NPCs2 = 1183116,
        //[Description("Piata Academy 1 NPCs 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //PiataAcademy1NPCs3 = 1186368,
        //[Description("Piata Academy 1 NPCs 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //PiataAcademy1NPCs4 = 1207328,
        //[Description("Piata Academy 1 NPCs 5")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //PiataAcademy1NPCs5 = 1187500,
        //[Description("Piata Academy 2 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //PiataAcademy21 = 1194800,
        //[Description("Piata Academy 2 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //PiataAcademy22 = 1200112,
        //[Description("Piata Academy 2 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //PiataAcademy23 = 1204960,
        //[Description("Piata Academy F1 1 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //PiataAcademyF111 = 1194800,
        //[Description("Piata Academy F1 1 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //PiataAcademyF112 = 1200112,
        //[Description("Piata Academy F1 1 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //PiataAcademyF113 = 1204960,
        //[Description("Piata Academy F1 1 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //PiataAcademyF11NPCs1 = 1182060,
        //[Description("Piata Academy F1 1 NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //PiataAcademyF11NPCs2 = 1212342,
        //[Description("Piata Academy F1 1 NPCs 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //PiataAcademyF11NPCs3 = 1186368,
        //[Description("Piata Academy F1 1 NPCs 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //PiataAcademyF11NPCs4 = 1187500,
        //[Description("Piata Academy F1 1 NPCs 5")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //PiataAcademyF11NPCs5 = 1207328,
        //[Description("Piata Academy F1 2 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //PiataAcademyF121 = 1194800,
        //[Description("Piata Academy F1 2 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //PiataAcademyF122 = 1200112,
        //[Description("Piata Academy F1 2 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //PiataAcademyF123 = 1204960,
        //[Description("Piata Academy F1 2 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //PiataAcademyF12NPCs1 = 1213928,
        //[Description("Piata Academy F1 2 NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //PiataAcademyF12NPCs2 = 1214970,
        //[Description("Piata Academy B1 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //PiataAcademyB11 = 1194800,
        //[Description("Piata Academy B1 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //PiataAcademyB12 = 1200112,
        //[Description("Piata Academy B1 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //PiataAcademyB13 = 1204960,
        //[Description("Piata Academy B1 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //PiataAcademyB1NPCs1 = 1216580,
        //[Description("Piata Academy B2 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //PiataAcademyB21 = 1194800,
        //[Description("Piata Academy B2 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //PiataAcademyB22 = 1200112,
        //[Description("Piata Academy B2 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //PiataAcademyB23 = 1204960,
        //[Description("Piata Academy B3 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //PiataAcademyB31 = 1194800,
        //[Description("Piata Academy B3 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //PiataAcademyB32 = 1200112,
        //[Description("Piata Academy B3 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //PiataAcademyB33 = 1204960,
        //[Description("Piata Academy B3 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //PiataAcademyB3NPCs1 = 1217818,
        //[Description("Piata Dorm 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //PiataDorm1 = 1218660,
        //[Description("Piata Dorm 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //PiataDorm2 = 1223412,
        //[Description("Piata Dorm 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //PiataDorm3 = 1228372,
        //[Description("Piata Dorm 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //PiataDorm4 = 1233732,
        //[Description("Piata Dorm NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //PiataDormNPCs1 = 1187500,
        //[Description("Piata Dorm NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //PiataDormNPCs2 = 1182060,
        //[Description("Piata Dorm NPCs 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //PiataDormNPCs3 = 1183116,
        //[Description("Piata Dorm NPCs 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //PiataDormNPCs4 = 1185280,
        //[Description("Piata Dorm NPCs 5")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //PiataDormNPCs5 = 1237000,
        //[Description("Piata Inn 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //PiataInn1 = 1218660,
        //[Description("Piata Inn 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //PiataInn2 = 1223412,
        //[Description("Piata Inn 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //PiataInn3 = 1228372,
        //[Description("Piata Inn 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //PiataInn4 = 1233732,
        //[Description("Piata Inn NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //PiataInnNPCs1 = 1242644,
        //[Description("Piata House 1 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //PiataHouse11 = 1218660,
        //[Description("Piata House 1 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //PiataHouse12 = 1223412,
        //[Description("Piata House 1 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //PiataHouse13 = 1228372,
        //[Description("Piata House 1 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //PiataHouse14 = 1233732,
        //[Description("Piata House 1 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //PiataHouse1NPCs1 = 1242644,
        //[Description("Piata House 1 NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //PiataHouse1NPCs2 = 1244208,
        //[Description("Piata Item Shop 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //PiataItemShop1 = 1218660,
        //[Description("Piata Item Shop 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //PiataItemShop2 = 1223412,
        //[Description("Piata Item Shop 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //PiataItemShop3 = 1228372,
        //[Description("Piata Item Shop 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //PiataItemShop4 = 1233732,
        //[Description("Piata Item Shop NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //PiataItemShopNPCs1 = 1185280,
        //[Description("Piata House 2 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //PiataHouse21 = 1218660,
        //[Description("Piata House 2 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //PiataHouse22 = 1223412,
        //[Description("Piata House 2 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //PiataHouse23 = 1228372,
        //[Description("Piata House 2 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //PiataHouse24 = 1233732,
        //[Description("Piata House 2 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //PiataHouse2NPCs1 = 1184138,
        //[Description("Mile 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Mile1 = 1165320,
        //[Description("Mile 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Mile2 = 1171048,
        //[Description("Mile 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Mile3 = 1246422,
        //[Description("Mile NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MileNPCs1 = 1183116,
        //[Description("Mile NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MileNPCs2 = 1182060,
        //[Description("Mile NPCs 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MileNPCs3 = 1184138,
        //[Description("Mile NPCs 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MileNPCs4 = 1187500,
        //[Description("Mile NPCs 5")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MileNPCs5 = 1180760,
        //[Description("Mile NPCs 6")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MileNPCs6 = 1247990,
        //[Description("Mile NPCs 7")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MileNPCs7 = 1248548,
        //[Description("Mile Destroyed 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MileDestroyed1 = 1165320,
        //[Description("Mile Destroyed 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MileDestroyed2 = 1171048,
        //[Description("Mile Destroyed 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MileDestroyed3 = 1246422,
        //[Description("Mile Destroyed NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MileDestroyedNPCs1 = 1277616,
        //[Description("Mile Destroyed NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MileDestroyedNPCs2 = 1251468,
        //[Description("Mile Destroyed NPCs 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MileDestroyedNPCs3 = 1251326,
        //[Description("Mile Destroyed NPCs 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MileDestroyedNPCs4 = 1251114,
        //[Description("Mile Weapon Shop 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MileWeaponShop1 = 1218660,
        //[Description("Mile Weapon Shop 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MileWeaponShop2 = 1223412,
        //[Description("Mile Weapon Shop 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MileWeaponShop3 = 1228372,
        //[Description("Mile Weapon Shop 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MileWeaponShop4 = 1233732,
        //[Description("Mile Weapon Shop NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MileWeaponShopNPCs1 = 1183116,
        //[Description("Mile Weapon Shop NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MileWeaponShopNPCs2 = 1235908,
        //[Description("Mile Weapon Shop NPCs 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MileWeaponShopNPCs3 = 1277616,
        //[Description("Mile Weapon Shop NPCs 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MileWeaponShopNPCs4 = 1251114,
        //[Description("Mile House 1 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MileHouse11 = 1218660,
        //[Description("Mile House 1 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MileHouse12 = 1223412,
        //[Description("Mile House 1 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MileHouse13 = 1228372,
        //[Description("Mile House 1 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MileHouse14 = 1233732,
        //[Description("Mile House 1 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MileHouse1NPCs1 = 1184138,
        //[Description("Mile House 1 NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MileHouse1NPCs2 = 1252250,
        //[Description("Mile House 1 NPCs 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MileHouse1NPCs3 = 1277616,
        //[Description("Mile House 1 NPCs 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MileHouse1NPCs4 = 1251326,
        //[Description("Mile Item Shop 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MileItemShop1 = 1218660,
        //[Description("Mile Item Shop 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MileItemShop2 = 1223412,
        //[Description("Mile Item Shop 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MileItemShop3 = 1228372,
        //[Description("Mile Item Shop 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MileItemShop4 = 1233732,
        //[Description("Mile Item Shop NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MileItemShopNPCs1 = 1242644,
        //[Description("Mile House 2 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MileHouse21 = 1218660,
        //[Description("Mile House 2 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MileHouse22 = 1223412,
        //[Description("Mile House 2 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MileHouse23 = 1228372,
        //[Description("Mile House 2 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MileHouse24 = 1233732,
        //[Description("Mile House 2 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MileHouse2NPCs1 = 1182060,
        //[Description("Mile House 2 NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MileHouse2NPCs2 = 1242644,
        //[Description("Mile House 2 NPCs 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MileHouse2NPCs3 = 1277616,
        //[Description("Mile House 2 NPCs 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MileHouse2NPCs4 = 1251468,
        //[Description("Mile Inn 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MileInn1 = 1218660,
        //[Description("Mile Inn 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MileInn2 = 1223412,
        //[Description("Mile Inn 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MileInn3 = 1228372,
        //[Description("Mile Inn 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MileInn4 = 1233732,
        //[Description("Mile Inn NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MileInnNPCs1 = 1184138,
        //[Description("Mile Inn NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MileInnNPCs2 = 1185280,
        //[Description("Mile Inn NPCs 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MileInnNPCs3 = 1277616,
        //[Description("Mile Inn NPCs 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MileInnNPCs4 = 1251114,
        //[Description("Zema 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Zema1 = 1165320,
        //[Description("Zema 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Zema2 = 1171048,
        //[Description("Zema 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Zema3 = 1255416,
        //[Description("Zema NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //ZemaNPCs1 = 1182060,
        //[Description("Zema NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //ZemaNPCs2 = 1183116,
        //[Description("Zema NPCs 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //ZemaNPCs3 = 1184138,
        //[Description("Zema NPCs 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //ZemaNPCs4 = 1187500,
        //[Description("Zema NPCs 5")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //ZemaNPCs5 = 1252250,
        //[Description("Zema NPCs 6")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //ZemaNPCs6 = 1258104,
        //[Description("Zema House 1 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZemaHouse11 = 1218660,
        //[Description("Zema House 1 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZemaHouse12 = 1223412,
        //[Description("Zema House 1 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZemaHouse13 = 1228372,
        //[Description("Zema House 1 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZemaHouse14 = 1233732,
        //[Description("Zema House 1 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //ZemaHouse1NPCs1 = 1242644,
        //[Description("Zema House 1 NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //ZemaHouse1NPCs2 = 1261324,
        //[Description("Zema House 1 NPCs 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //ZemaHouse1NPCs3 = 1262200,
        //[Description("Zema Weapon Shop 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZemaWeaponShop1 = 1218660,
        //[Description("Zema Weapon Shop 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZemaWeaponShop2 = 1223412,
        //[Description("Zema Weapon Shop 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZemaWeaponShop3 = 1228372,
        //[Description("Zema Weapon Shop 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZemaWeaponShop4 = 1233732,
        //[Description("Zema Weapon Shop NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //ZemaWeaponShopNPCs1 = 1185280,
        //[Description("Zema Weapon Shop NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //ZemaWeaponShopNPCs2 = 1235908,
        //[Description("Zema Inn 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZemaInn1 = 1218660,
        //[Description("Zema Inn 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZemaInn2 = 1223412,
        //[Description("Zema Inn 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZemaInn3 = 1228372,
        //[Description("Zema Inn 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZemaInn4 = 1233732,
        //[Description("Zema Inn NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //ZemaInnNPCs1 = 1264070,
        //[Description("Zema House 2 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZemaHouse21 = 1218660,
        //[Description("Zema House 2 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZemaHouse22 = 1223412,
        //[Description("Zema House 2 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZemaHouse23 = 1228372,
        //[Description("Zema House 2 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZemaHouse24 = 1233732,
        //[Description("Zema House 2 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //ZemaHouse2NPCs1 = 1242644,
        //[Description("Zema House 2 NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //ZemaHouse2NPCs2 = 1182060,
        //[Description("Zema House 2 NPCs 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //ZemaHouse2NPCs3 = 1244208,
        //[Description("Zema House 2 NPCs 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //ZemaHouse2NPCs4 = 1265652,
        //[Description("Zema House 2 B1 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZemaHouse2B11 = 1218660,
        //[Description("Zema House 2 B1 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZemaHouse2B12 = 1223412,
        //[Description("Zema House 2 B1 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZemaHouse2B13 = 1228372,
        //[Description("Zema House 2 B1 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZemaHouse2B14 = 1233732,
        //[Description("Zema House 2 B1 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //ZemaHouse2B1NPCs1 = 1244208,
        //[Description("Zema House 2 B1 NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //ZemaHouse2B1NPCs2 = 1265652,
        //[Description("Zema Item Shop 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZemaItemShop1 = 1218660,
        //[Description("Zema Item Shop 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZemaItemShop2 = 1223412,
        //[Description("Zema Item Shop 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZemaItemShop3 = 1228372,
        //[Description("Zema Item Shop 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZemaItemShop4 = 1233732,
        //[Description("Zema Item Shop NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //ZemaItemShopNPCs1 = 1264070,
        //[Description("Birth Valley 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //BirthValley1 = 1267750,
        //[Description("Birth Valley 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //BirthValley2 = 1272758,
        //[Description("Birth Valley B1 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //BirthValleyB11 = 1267750,
        //[Description("Birth Valley B1 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //BirthValleyB12 = 1272758,
        //[Description("Birth Valley B1 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //BirthValleyB1NPCs1 = 1276328,
        //[Description("Birth Valley B1 NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //BirthValleyB1NPCs2 = 1182060,
        //[Description("Birth Valley B1 NPCs 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //BirthValleyB1NPCs3 = 1187500,
        //[Description("Birth Valley B1 NPCs 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //BirthValleyB1NPCs4 = 1214970,
        //[Description("Birth Valley B1 NPCs 5")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //BirthValleyB1NPCs5 = 1277616,
        //[Description("Valley Maze Unused 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ValleyMazeUnused1 = 1462116,
        //[Description("Valley Maze Unused 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ValleyMazeUnused2 = 1466964,
        //[Description("Krup 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Krup1 = 1165320,
        //[Description("Krup 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Krup2 = 1171048,
        //[Description("Krup 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Krup3 = 1279556,
        //[Description("Krup NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //KrupNPCs1 = 1187500,
        //[Description("Krup NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //KrupNPCs2 = 1184138,
        //[Description("Krup NPCs 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //KrupNPCs3 = 1182060,
        //[Description("Krup NPCs 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //KrupNPCs4 = 1183116,
        //[Description("Krup NPCs 5")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //KrupNPCs5 = 1262200,
        //[Description("Krup NPCs 6")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //KrupNPCs6 = 1242644,
        //[Description("Krup NPCs 7")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //KrupNPCs7 = 1283204,
        //[Description("Krup NPCs 8")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //KrupNPCs8 = 1299530,
        //[Description("Krup Kindergarten 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KrupKindergarten1 = 1218660,
        //[Description("Krup Kindergarten 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KrupKindergarten2 = 1223412,
        //[Description("Krup Kindergarten 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KrupKindergarten3 = 1228372,
        //[Description("Krup Kindergarten 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KrupKindergarten4 = 1233732,
        //[Description("Krup Kindergarten NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //KrupKindergartenNPCs1 = 1286136,
        //[Description("Krup Kindergarten NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //KrupKindergartenNPCs2 = 1287234,
        //[Description("Krup Kindergarten NPCs 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //KrupKindergartenNPCs3 = 1244208,
        //[Description("Krup Kindergarten NPCs 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //KrupKindergartenNPCs4 = 1261324,
        //[Description("Krup Kindergarten NPCs 5")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //KrupKindergartenNPCs5 = 1265652,
        //[Description("Krup Weapon Shop 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KrupWeaponShop1 = 1218660,
        //[Description("Krup Weapon Shop 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KrupWeaponShop2 = 1223412,
        //[Description("Krup Weapon Shop 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KrupWeaponShop3 = 1228372,
        //[Description("Krup Weapon Shop 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KrupWeaponShop4 = 1233732,
        //[Description("Krup Weapon Shop NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //KrupWeaponShopNPCs1 = 1183116,
        //[Description("Krup Weapon Shop NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //KrupWeaponShopNPCs2 = 1184138,
        //[Description("Krup Weapon Shop NPCs 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //KrupWeaponShopNPCs3 = 1242644,
        //[Description("Krup Item Shop 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KrupItemShop1 = 1218660,
        //[Description("Krup Item Shop 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KrupItemShop2 = 1223412,
        //[Description("Krup Item Shop 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KrupItemShop3 = 1228372,
        //[Description("Krup Item Shop 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KrupItemShop4 = 1233732,
        //[Description("Krup Item Shop NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //KrupItemShopNPCs1 = 1184138,
        //[Description("Krup Item Shop NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //KrupItemShopNPCs2 = 1187500,
        //[Description("Krup House 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KrupHouse1 = 1218660,
        //[Description("Krup House 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KrupHouse2 = 1223412,
        //[Description("Krup House 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KrupHouse3 = 1228372,
        //[Description("Krup House 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KrupHouse4 = 1233732,
        //[Description("Krup House NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //KrupHouseNPCs1 = 1242644,
        //[Description("Krup Inn 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KrupInn1 = 1218660,
        //[Description("Krup Inn 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KrupInn2 = 1223412,
        //[Description("Krup Inn 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KrupInn3 = 1228372,
        //[Description("Krup Inn 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KrupInn4 = 1233732,
        //[Description("Krup Inn NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //KrupInnNPCs1 = 1289984,
        //[Description("Krup Inn F1 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KrupInnF11 = 1218660,
        //[Description("Krup Inn F1 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KrupInnF12 = 1223412,
        //[Description("Krup Inn F1 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KrupInnF13 = 1228372,
        //[Description("Krup Inn F1 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KrupInnF14 = 1233732,
        //[Description("Krup Inn F1 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //KrupInnF1NPCs1 = 1286136,
        //[Description("Krup Inn F1 NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //KrupInnF1NPCs2 = 1291548,
        //[Description("Molcum 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Molcum1 = 1165320,
        //[Description("Molcum 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Molcum2 = 1171048,
        //[Description("Molcum 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Molcum3 = 1292112,
        //[Description("Molcum NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MolcumNPCs1 = 1295520,
        //[Description("Molcum NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MolcumNPCs2 = 1296826,
        //[Description("Molcum NPCs 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MolcumNPCs3 = 1298004,
        //[Description("Tonoe 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Tonoe1 = 1165320,
        //[Description("Tonoe 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Tonoe2 = 1171048,
        //[Description("Tonoe 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Tonoe3 = 1302940,
        //[Description("Tonoe NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //TonoeNPCs1 = 1295520,
        //[Description("Tonoe NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //TonoeNPCs2 = 1296826,
        //[Description("Tonoe NPCs 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //TonoeNPCs3 = 1298004,
        //[Description("Tonoe Storage Room 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TonoeStorageRoom1 = 1218660,
        //[Description("Tonoe Storage Room 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TonoeStorageRoom2 = 1223412,
        //[Description("Tonoe Storage Room 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TonoeStorageRoom3 = 1228372,
        //[Description("Tonoe Storage Room 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TonoeStorageRoom4 = 1233732,
        //[Description("Tonoe Storage Room 5")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TonoeStorageRoom5 = 1308354,
        //[Description("Tonoe Storage Room NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //TonoeStorageRoomNPCs1 = 1311218,
        //[Description("Tonoe Gryz House 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TonoeGryzHouse1 = 1218660,
        //[Description("Tonoe Gryz House 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TonoeGryzHouse2 = 1223412,
        //[Description("Tonoe Gryz House 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TonoeGryzHouse3 = 1228372,
        //[Description("Tonoe Gryz House 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TonoeGryzHouse4 = 1233732,
        //[Description("Tonoe Gryz House 5")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TonoeGryzHouse5 = 1308354,
        //[Description("Tonoe Gryz House NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //TonoeGryzHouseNPCs1 = 1313006,
        //[Description("Tonoe Gryz House NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //TonoeGryzHouseNPCs2 = 1314122,
        //[Description("Tonoe Gryz House NPCs 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //TonoeGryzHouseNPCs3 = 1314510,
        //[Description("Tonoe House 1 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TonoeHouse11 = 1218660,
        //[Description("Tonoe House 1 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TonoeHouse12 = 1223412,
        //[Description("Tonoe House 1 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TonoeHouse13 = 1228372,
        //[Description("Tonoe House 1 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TonoeHouse14 = 1233732,
        //[Description("Tonoe House 1 5")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TonoeHouse15 = 1308354,
        //[Description("Tonoe House 1 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //TonoeHouse1NPCs1 = 1295520,
        //[Description("Tonoe House 2 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TonoeHouse21 = 1218660,
        //[Description("Tonoe House 2 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TonoeHouse22 = 1223412,
        //[Description("Tonoe House 2 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TonoeHouse23 = 1228372,
        //[Description("Tonoe House 2 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TonoeHouse24 = 1233732,
        //[Description("Tonoe House 2 5")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TonoeHouse25 = 1308354,
        //[Description("Tonoe House 2 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //TonoeHouse2NPCs1 = 1296826,
        //[Description("Tonoe Inn 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TonoeInn1 = 1218660,
        //[Description("Tonoe Inn 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TonoeInn2 = 1223412,
        //[Description("Tonoe Inn 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TonoeInn3 = 1228372,
        //[Description("Tonoe Inn 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TonoeInn4 = 1233732,
        //[Description("Tonoe Inn 5")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TonoeInn5 = 1308354,
        //[Description("Tonoe Inn NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //TonoeInnNPCs1 = 1295520,
        //[Description("Tonoe B1 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TonoeB11 = 1316644,
        //[Description("Tonoe B1 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TonoeB12 = 1321188,
        //[Description("Tonoe Basement B2 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TonoeBasementB21 = 1316644,
        //[Description("Tonoe Basement B2 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TonoeBasementB22 = 1321188,
        //[Description("Tonoe Basement B2 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //TonoeBasementB2NPCs1 = 1300780,
        //[Description("Tonoe Basement B3 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TonoeBasementB31 = 1316644,
        //[Description("Tonoe Basement B3 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TonoeBasementB32 = 1321188,
        //[Description("Tonoe Basement B3 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //TonoeBasementB3NPCs1 = 1300780,
        //[Description("Tonoe Basement B4 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TonoeBasementB41 = 1316644,
        //[Description("Tonoe Basement B4 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TonoeBasementB42 = 1321188,
        //[Description("Tonoe Basement B4 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //TonoeBasementB4NPCs1 = 1300780,
        //[Description("Nalya 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Nalya1 = 1165320,
        //[Description("Nalya 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Nalya2 = 1171048,
        //[Description("Nalya 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Nalya3 = 1326908,
        //[Description("Nalya NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //NalyaNPCs1 = 1235908,
        //[Description("Nalya NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //NalyaNPCs2 = 1252250,
        //[Description("Nalya NPCs 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //NalyaNPCs3 = 1183116,
        //[Description("Nalya NPCs 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //NalyaNPCs4 = 1264070,
        //[Description("Nalya NPCs 5")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //NalyaNPCs5 = 1182060,
        //[Description("Nalya House 1 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //NalyaHouse11 = 1218660,
        //[Description("Nalya House 1 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //NalyaHouse12 = 1223412,
        //[Description("Nalya House 1 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //NalyaHouse13 = 1228372,
        //[Description("Nalya House 1 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //NalyaHouse14 = 1233732,
        //[Description("Nalya House 1 5")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //NalyaHouse15 = 1308354,
        //[Description("Nalya House 1 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //NalyaHouse1NPCs1 = 1184138,
        //[Description("Nalya House 1 NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //NalyaHouse1NPCs2 = 1244208,
        //[Description("Nalya House 1 NPCs 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //NalyaHouse1NPCs3 = 18,
        //[Description("Nalya House 1 NPCs 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //NalyaHouse1NPCs4 = -1,
        //[Description("Nalya House 1 NPCs 5")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //NalyaHouse1NPCs5 = 522125568,
        //[Description("Nalya House 1 NPCs 6")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //NalyaHouse1NPCs6 = 65554,
        //[Description("Nalya House 1 NPCs 7")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //NalyaHouse1NPCs7 = -65281,
        //[Description("Nalya House 1 NPCs 8")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //NalyaHouse1NPCs8 = 589899,
        //[Description("Nalya House 1 NPCs 9")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //NalyaHouse1NPCs9 = 65535,
        //[Description("Nalya House 2 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //NalyaHouse21 = 1218660,
        //[Description("Nalya House 2 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //NalyaHouse22 = 1223412,
        //[Description("Nalya House 2 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //NalyaHouse23 = 1228372,
        //[Description("Nalya House 2 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //NalyaHouse24 = 1233732,
        //[Description("Nalya House 2 5")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //NalyaHouse25 = 1308354,
        //[Description("Nalya House 2 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //NalyaHouse2NPCs1 = 1182060,
        //[Description("Nalya House 2 NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //NalyaHouse2NPCs2 = 1185280,
        //[Description("Nalya Item Shop 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //NalyaItemShop1 = 1218660,
        //[Description("Nalya Item Shop 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //NalyaItemShop2 = 1223412,
        //[Description("Nalya Item Shop 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //NalyaItemShop3 = 1228372,
        //[Description("Nalya Item Shop 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //NalyaItemShop4 = 1233732,
        //[Description("Nalya Item Shop 5")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //NalyaItemShop5 = 1308354,
        //[Description("Nalya Item Shop NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //NalyaItemShopNPCs1 = 1183116,
        //[Description("Nalya House 3 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //NalyaHouse31 = 1218660,
        //[Description("Nalya House 3 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //NalyaHouse32 = 1223412,
        //[Description("Nalya House 3 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //NalyaHouse33 = 1228372,
        //[Description("Nalya House 3 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //NalyaHouse34 = 1233732,
        //[Description("Nalya House 3 5")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //NalyaHouse35 = 1308354,
        //[Description("Nalya House 3 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //NalyaHouse3NPCs1 = 1187500,
        //[Description("Nalya House 3 NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //NalyaHouse3NPCs2 = 1244208,
        //[Description("Nalya House 3 NPCs 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //NalyaHouse3NPCs3 = 18,
        //[Description("Nalya House 3 NPCs 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //NalyaHouse3NPCs4 = -1,
        //[Description("Nalya House 3 NPCs 5")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //NalyaHouse3NPCs5 = 522125568,
        //[Description("Nalya House 3 NPCs 6")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //NalyaHouse3NPCs6 = 65554,
        //[Description("Nalya House 3 NPCs 7")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //NalyaHouse3NPCs7 = -65281,
        //[Description("Nalya House 3 NPCs 8")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //NalyaHouse3NPCs8 = 589899,
        //[Description("Nalya House 3 NPCs 9")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //NalyaHouse3NPCs9 = 65535,
        //[Description("Nalya House 4 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //NalyaHouse41 = 1218660,
        //[Description("Nalya House 4 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //NalyaHouse42 = 1223412,
        //[Description("Nalya House 4 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //NalyaHouse43 = 1228372,
        //[Description("Nalya House 4 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //NalyaHouse44 = 1233732,
        //[Description("Nalya House 4 5")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //NalyaHouse45 = 1308354,
        //[Description("Nalya House 4 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //NalyaHouse4NPCs1 = 1183116,
        //[Description("Nalya House 4 NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //NalyaHouse4NPCs2 = 1242644,
        //[Description("Nalya House 4 NPCs 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //NalyaHouse4NPCs3 = 18,
        //[Description("Nalya House 4 NPCs 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //NalyaHouse4NPCs4 = -1,
        //[Description("Nalya House 4 NPCs 5")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //NalyaHouse4NPCs5 = 522125568,
        //[Description("Nalya House 4 NPCs 6")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //NalyaHouse4NPCs6 = 65554,
        //[Description("Nalya House 4 NPCs 7")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //NalyaHouse4NPCs7 = -65281,
        //[Description("Nalya House 4 NPCs 8")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //NalyaHouse4NPCs8 = 589899,
        //[Description("Nalya House 4 NPCs 9")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //NalyaHouse4NPCs9 = 65535,
        //[Description("Nalya House 5 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //NalyaHouse51 = 1218660,
        //[Description("Nalya House 5 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //NalyaHouse52 = 1223412,
        //[Description("Nalya House 5 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //NalyaHouse53 = 1228372,
        //[Description("Nalya House 5 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //NalyaHouse54 = 1233732,
        //[Description("Nalya House 5 5")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //NalyaHouse55 = 1308354,
        //[Description("Nalya House 5 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //NalyaHouse5NPCs1 = 1182060,
        //[Description("Nalya House 5 NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //NalyaHouse5NPCs2 = 1185280,
        //[Description("Nalya Inn 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //NalyaInn1 = 1218660,
        //[Description("Nalya Inn 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //NalyaInn2 = 1223412,
        //[Description("Nalya Inn 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //NalyaInn3 = 1228372,
        //[Description("Nalya Inn 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //NalyaInn4 = 1233732,
        //[Description("Nalya Inn 5")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //NalyaInn5 = 1308354,
        //[Description("Nalya Inn NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //NalyaInnNPCs1 = 1184138,
        //[Description("Nalya Inn F1 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //NalyaInnF11 = 1218660,
        //[Description("Nalya Inn F1 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //NalyaInnF12 = 1223412,
        //[Description("Nalya Inn F1 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //NalyaInnF13 = 1228372,
        //[Description("Nalya Inn F1 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //NalyaInnF14 = 1233732,
        //[Description("Nalya Inn F1 5")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //NalyaInnF15 = 1308354,
        //[Description("Nalya Inn F1 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //NalyaInnF1NPCs1 = 1183116,
        //[Description("Nalya Inn F1 NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //NalyaInnF1NPCs2 = 1184138,
        //[Description("Nalya Inn F1 NPCs 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //NalyaInnF1NPCs3 = 1335496,
        //[Description("Aiedo 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Aiedo1 = 1165320,
        //[Description("Aiedo 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Aiedo2 = 1171048,
        //[Description("Aiedo 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Aiedo3 = 1336408,
        //[Description("Aiedo NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //AiedoNPCs1 = 1180760,
        //[Description("Aiedo NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //AiedoNPCs2 = 1184138,
        //[Description("Aiedo NPCs 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //AiedoNPCs3 = 1182060,
        //[Description("Aiedo NPCs 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //AiedoNPCs4 = 1262200,
        //[Description("Aiedo NPCs 5")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //AiedoNPCs5 = 1185280,
        //[Description("Aiedo NPCs 6")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //AiedoNPCs6 = 1340094,
        //[Description("Aiedo NPCs 7")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //AiedoNPCs7 = 1341354,
        //[Description("Aiedo NPCs 8")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //AiedoNPCs8 = 1339272,
        //[Description("Aiedo Bakery 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AiedoBakery1 = 1218660,
        //[Description("Aiedo Bakery 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AiedoBakery2 = 1223412,
        //[Description("Aiedo Bakery 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AiedoBakery3 = 1228372,
        //[Description("Aiedo Bakery 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AiedoBakery4 = 1233732,
        //[Description("Aiedo Bakery B1 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AiedoBakeryB11 = 1218660,
        //[Description("Aiedo Bakery B1 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AiedoBakeryB12 = 1223412,
        //[Description("Aiedo Bakery B1 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AiedoBakeryB13 = 1228372,
        //[Description("Aiedo Bakery B1 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AiedoBakeryB14 = 1233732,
        //[Description("Aiedo Bakery B1 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //AiedoBakeryB1NPCs1 = 1235908,
        //[Description("Aiedo Bakery B1 NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //AiedoBakeryB1NPCs2 = 1345556,
        //[Description("Hunters Guild 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //HuntersGuild1 = 1218660,
        //[Description("Hunters Guild 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //HuntersGuild2 = 1223412,
        //[Description("Hunters Guild 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //HuntersGuild3 = 1228372,
        //[Description("Hunters Guild 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //HuntersGuild4 = 1233732,
        //[Description("Hunters Guild NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //HuntersGuildNPCs1 = 1340094,
        //[Description("Hunters Guild NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //HuntersGuildNPCs2 = 1341354,
        //[Description("Hunters Guild NPCs 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //HuntersGuildNPCs3 = 1180760,
        //[Description("Hunters Guild NPCs 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //HuntersGuildNPCs4 = 1183116,
        //[Description("Hunters Guild NPCs 5")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //HuntersGuildNPCs5 = 1346478,
        //[Description("Hunters Guild NPCs 6")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //HuntersGuildNPCs6 = 1346478,
        //[Description("Hunters Guild Storage 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //HuntersGuildStorage1 = 1218660,
        //[Description("Hunters Guild Storage 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //HuntersGuildStorage2 = 1223412,
        //[Description("Hunters Guild Storage 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //HuntersGuildStorage3 = 1228372,
        //[Description("Hunters Guild Storage 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //HuntersGuildStorage4 = 1233732,
        //[Description("Strip Club Dressing Room 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //StripClubDressingRoom1 = 1218660,
        //[Description("Strip Club Dressing Room 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //StripClubDressingRoom2 = 1223412,
        //[Description("Strip Club Dressing Room 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //StripClubDressingRoom3 = 1228372,
        //[Description("Strip Club Dressing Room 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //StripClubDressingRoom4 = 1233732,
        //[Description("Strip Club Dressing Room NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //StripClubDressingRoomNPCs1 = 1347614,
        //[Description("Strip Club 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //StripClub1 = 1218660,
        //[Description("Strip Club 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //StripClub2 = 1223412,
        //[Description("Strip Club 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //StripClub3 = 1228372,
        //[Description("Strip Club 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //StripClub4 = 1233732,
        //[Description("Strip Club NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //StripClubNPCs1 = 1180760,
        //[Description("Strip Club NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //StripClubNPCs2 = 1349132,
        //[Description("Aiedo Weapon Shop 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AiedoWeaponShop1 = 1218660,
        //[Description("Aiedo Weapon Shop 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AiedoWeaponShop2 = 1223412,
        //[Description("Aiedo Weapon Shop 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AiedoWeaponShop3 = 1228372,
        //[Description("Aiedo Weapon Shop 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AiedoWeaponShop4 = 1233732,
        //[Description("Aiedo Weapon Shop NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //AiedoWeaponShopNPCs1 = 1340094,
        //[Description("Aiedo Weapon Shop NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //AiedoWeaponShopNPCs2 = 1341354,
        //[Description("Aiedo Weapon Shop NPCs 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //AiedoWeaponShopNPCs3 = 1183116,
        //[Description("Aiedo Prison 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AiedoPrison1 = 1218660,
        //[Description("Aiedo Prison 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AiedoPrison2 = 1223412,
        //[Description("Aiedo Prison 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AiedoPrison3 = 1228372,
        //[Description("Aiedo Prison 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AiedoPrison4 = 1233732,
        //[Description("Aiedo Prison NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //AiedoPrisonNPCs1 = 1180760,
        //[Description("Aiedo Prison NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //AiedoPrisonNPCs2 = 1185280,
        //[Description("Aiedo Prison NPCs 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //AiedoPrisonNPCs3 = 1235908,
        //[Description("Aiedo Prison NPCs 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //AiedoPrisonNPCs4 = 1353216,
        //[Description("Aiedo Prison NPCs 5")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //AiedoPrisonNPCs5 = 1353928,
        //[Description("Aiedo House 1 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AiedoHouse11 = 1218660,
        //[Description("Aiedo House 1 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AiedoHouse12 = 1223412,
        //[Description("Aiedo House 1 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AiedoHouse13 = 1228372,
        //[Description("Aiedo House 1 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AiedoHouse14 = 1233732,
        //[Description("Aiedo House 1 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //AiedoHouse1NPCs1 = 1354590,
        //[Description("Chaz House 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ChazHouse1 = 1218660,
        //[Description("Chaz House 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ChazHouse2 = 1223412,
        //[Description("Chaz House 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ChazHouse3 = 1228372,
        //[Description("Chaz House 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ChazHouse4 = 1233732,
        //[Description("Chaz House NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //ChazHouseNPCs1 = 1356184,
        //[Description("Chaz House NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //ChazHouseNPCs2 = 1356392,
        //[Description("Aiedo House 2 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AiedoHouse21 = 1218660,
        //[Description("Aiedo House 2 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AiedoHouse22 = 1223412,
        //[Description("Aiedo House 2 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AiedoHouse23 = 1228372,
        //[Description("Aiedo House 2 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AiedoHouse24 = 1233732,
        //[Description("Aiedo House 2 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //AiedoHouse2NPCs1 = 1289984,
        //[Description("Aiedo House 3 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AiedoHouse31 = 1218660,
        //[Description("Aiedo House 3 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AiedoHouse32 = 1223412,
        //[Description("Aiedo House 3 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AiedoHouse33 = 1228372,
        //[Description("Aiedo House 3 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AiedoHouse34 = 1233732,
        //[Description("Aiedo House 3 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //AiedoHouse3NPCs1 = 1183116,
        //[Description("Aiedo House 4 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AiedoHouse41 = 1218660,
        //[Description("Aiedo House 4 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AiedoHouse42 = 1223412,
        //[Description("Aiedo House 4 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AiedoHouse43 = 1228372,
        //[Description("Aiedo House 4 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AiedoHouse44 = 1233732,
        //[Description("Aiedo House 4 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //AiedoHouse4NPCs1 = 1184138,
        //[Description("Aiedo House 4 NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //AiedoHouse4NPCs2 = 1261324,
        //[Description("Aiedo House 4 NPCs 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //AiedoHouse4NPCs3 = 1287234,
        //[Description("Aiedo House 5 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AiedoHouse51 = 1218660,
        //[Description("Aiedo House 5 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AiedoHouse52 = 1223412,
        //[Description("Aiedo House 5 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AiedoHouse53 = 1228372,
        //[Description("Aiedo House 5 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AiedoHouse54 = 1233732,
        //[Description("Aiedo House 5 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //AiedoHouse5NPCs1 = 1252250,
        //[Description("Aiedo House 5 NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //AiedoHouse5NPCs2 = 1289984,
        //[Description("Aiedo Supermarket 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AiedoSupermarket1 = 1218660,
        //[Description("Aiedo Supermarket 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AiedoSupermarket2 = 1223412,
        //[Description("Aiedo Supermarket 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AiedoSupermarket3 = 1228372,
        //[Description("Aiedo Supermarket 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AiedoSupermarket4 = 1233732,
        //[Description("Aiedo Supermarket NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //AiedoSupermarketNPCs1 = 1187500,
        //[Description("Aiedo Supermarket NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //AiedoSupermarketNPCs2 = 1180760,
        //[Description("Aiedo Supermarket NPCs 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //AiedoSupermarketNPCs3 = 1185280,
        //[Description("Aiedo Supermarket NPCs 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //AiedoSupermarketNPCs4 = 1235908,
        //[Description("Aiedo Supermarket NPCs 5")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //AiedoSupermarketNPCs5 = 1242644,
        //[Description("Aiedo Supermarket NPCs 6")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //AiedoSupermarketNPCs6 = 1184138,
        //[Description("Aiedo Supermarket NPCs 7")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //AiedoSupermarketNPCs7 = 1244208,
        //[Description("Aiedo Supermarket NPCs 8")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //AiedoSupermarketNPCs8 = 20,
        //[Description("Aiedo Supermarket NPCs 9")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //AiedoSupermarketNPCs9 = -131000,
        //[Description("Aiedo Supermarket NPCs 10")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //AiedoSupermarketNPCs10 = -1138819073,
        //[Description("Aiedo Pub 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AiedoPub1 = 1218660,
        //[Description("Aiedo Pub 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AiedoPub2 = 1223412,
        //[Description("Aiedo Pub 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AiedoPub3 = 1228372,
        //[Description("Aiedo Pub 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AiedoPub4 = 1233732,
        //[Description("Aiedo Pub NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //AiedoPubNPCs1 = 1264070,
        //[Description("Aiedo Pub NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //AiedoPubNPCs2 = 1187500,
        //[Description("Aiedo Pub NPCs 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //AiedoPubNPCs3 = 1182060,
        //[Description("Aiedo Pub NPCs 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //AiedoPubNPCs4 = 1183116,
        //[Description("Aiedo Pub NPCs 5")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //AiedoPubNPCs5 = 1347614,
        //[Description("Rocky House 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //RockyHouse1 = 1218660,
        //[Description("Rocky House 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //RockyHouse2 = 1223412,
        //[Description("Rocky House 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //RockyHouse3 = 1228372,
        //[Description("Rocky House 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //RockyHouse4 = 1233732,
        //[Description("Rocky House NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //RockyHouseNPCs1 = 1242644,
        //[Description("Rocky House NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //RockyHouseNPCs2 = 1187500,
        //[Description("Rocky House NPCs 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //RockyHouseNPCs3 = 1287234,
        //[Description("Rocky House NPCs 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //RockyHouseNPCs4 = 1299530,
        //[Description("Aiedo House 6 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AiedoHouse61 = 1218660,
        //[Description("Aiedo House 6 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AiedoHouse62 = 1223412,
        //[Description("Aiedo House 6 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AiedoHouse63 = 1228372,
        //[Description("Aiedo House 6 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AiedoHouse64 = 1233732,
        //[Description("Aiedo House 6 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //AiedoHouse6NPCs1 = 1289984,
        //[Description("Aiedo House 7 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AiedoHouse71 = 1218660,
        //[Description("Aiedo House 7 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AiedoHouse72 = 1223412,
        //[Description("Aiedo House 7 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AiedoHouse73 = 1228372,
        //[Description("Aiedo House 7 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AiedoHouse74 = 1233732,
        //[Description("Aiedo House 7 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //AiedoHouse7NPCs1 = 1183116,
        //[Description("Kadary 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Kadary1 = 1165320,
        //[Description("Kadary 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Kadary2 = 1171048,
        //[Description("Kadary 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Kadary3 = 1363722,
        //[Description("Kadary NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //KadaryNPCs1 = 1183116,
        //[Description("Kadary NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //KadaryNPCs2 = 1264070,
        //[Description("Kadary NPCs 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //KadaryNPCs3 = 1184138,
        //[Description("Kadary NPCs 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //KadaryNPCs4 = 1367770,
        //[Description("Kadary NPCs 5")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //KadaryNPCs5 = 1368826,
        //[Description("Kadary NPCs 6")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //KadaryNPCs6 = 1185280,
        //[Description("Kadary NPCs 7")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //KadaryNPCs7 = 1369836,
        //[Description("Kadary Church 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KadaryChurch1 = 1371874,
        //[Description("Kadary Church 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KadaryChurch2 = 1377234,
        //[Description("Kadary Church 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KadaryChurch3 = 1381634,
        //[Description("Kadary Church NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //KadaryChurchNPCs1 = 1367770,
        //[Description("Kadary Church NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //KadaryChurchNPCs2 = 1368826,
        //[Description("Kadary Church NPCs 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //KadaryChurchNPCs3 = 1252250,
        //[Description("Kadary Church NPCs 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //KadaryChurchNPCs4 = 1354590,
        //[Description("Kadary Church NPCs 5")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //KadaryChurchNPCs5 = 1262200,
        //[Description("Kadary Church NPCs 6")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //KadaryChurchNPCs6 = 1382386,
        //[Description("Kadary Church NPCs 7")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //KadaryChurchNPCs7 = 1382788,
        //[Description("Kadary Pub 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KadaryPub1 = 1218660,
        //[Description("Kadary Pub 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KadaryPub2 = 1223412,
        //[Description("Kadary Pub 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KadaryPub3 = 1228372,
        //[Description("Kadary Pub 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KadaryPub4 = 1233732,
        //[Description("Kadary Pub NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //KadaryPubNPCs1 = 1340094,
        //[Description("Kadary Pub NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //KadaryPubNPCs2 = 1180760,
        //[Description("Kadary Pub NPCs 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //KadaryPubNPCs3 = 1341354,
        //[Description("Kadary Pub NPCs 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //KadaryPubNPCs4 = 1183116,
        //[Description("Kadary Pub F1 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KadaryPubF11 = 1218660,
        //[Description("Kadary Pub F1 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KadaryPubF12 = 1223412,
        //[Description("Kadary Pub F1 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KadaryPubF13 = 1228372,
        //[Description("Kadary Pub F1 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KadaryPubF14 = 1233732,
        //[Description("Kadary Pub F1 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //KadaryPubF1NPCs1 = 1347614,
        //[Description("Kadary Storage Room 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KadaryStorageRoom1 = 1218660,
        //[Description("Kadary Storage Room 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KadaryStorageRoom2 = 1223412,
        //[Description("Kadary Storage Room 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KadaryStorageRoom3 = 1228372,
        //[Description("Kadary Storage Room 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KadaryStorageRoom4 = 1233732,
        //[Description("Kadary House 1 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KadaryHouse11 = 1218660,
        //[Description("Kadary House 1 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KadaryHouse12 = 1223412,
        //[Description("Kadary House 1 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KadaryHouse13 = 1228372,
        //[Description("Kadary House 1 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KadaryHouse14 = 1233732,
        //[Description("Kadary House 1 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //KadaryHouse1NPCs1 = 1185280,
        //[Description("Kadary House 2 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KadaryHouse21 = 1218660,
        //[Description("Kadary House 2 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KadaryHouse22 = 1223412,
        //[Description("Kadary House 2 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KadaryHouse23 = 1228372,
        //[Description("Kadary House 2 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KadaryHouse24 = 1233732,
        //[Description("Kadary House 2 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //KadaryHouse2NPCs1 = 1242644,
        //[Description("Kadary House 3 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KadaryHouse31 = 1218660,
        //[Description("Kadary House 3 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KadaryHouse32 = 1223412,
        //[Description("Kadary House 3 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KadaryHouse33 = 1228372,
        //[Description("Kadary House 3 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KadaryHouse34 = 1233732,
        //[Description("Kadary House 3 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //KadaryHouse3NPCs1 = 1264070,
        //[Description("Kadary House 3 NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //KadaryHouse3NPCs2 = 1184138,
        //[Description("Kadary Item Shop 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KadaryItemShop1 = 1218660,
        //[Description("Kadary Item Shop 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KadaryItemShop2 = 1223412,
        //[Description("Kadary Item Shop 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KadaryItemShop3 = 1228372,
        //[Description("Kadary Item Shop 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KadaryItemShop4 = 1233732,
        //[Description("Kadary Item Shop NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //KadaryItemShopNPCs1 = 1242644,
        //[Description("Kadary Inn 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KadaryInn1 = 1218660,
        //[Description("Kadary Inn 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KadaryInn2 = 1223412,
        //[Description("Kadary Inn 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KadaryInn3 = 1228372,
        //[Description("Kadary Inn 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KadaryInn4 = 1233732,
        //[Description("Kadary Inn NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //KadaryInnNPCs1 = 1183116,
        //[Description("Kadary Inn NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //KadaryInnNPCs2 = 1252250,
        //[Description("Kadary Inn NPCs 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //KadaryInnNPCs3 = 1391374,
        //[Description("Kadary Inn F1 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KadaryInnF11 = 1218660,
        //[Description("Kadary Inn F1 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KadaryInnF12 = 1223412,
        //[Description("Kadary Inn F1 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KadaryInnF13 = 1228372,
        //[Description("Kadary Inn F1 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KadaryInnF14 = 1233732,
        //[Description("Kadary Inn F1 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //KadaryInnF1NPCs1 = 1242644,
        //[Description("Monsen 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Monsen1 = 1165320,
        //[Description("Monsen 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Monsen2 = 1171048,
        //[Description("Monsen 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Monsen3 = 1392524,
        //[Description("Monsen NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MonsenNPCs1 = 1354590,
        //[Description("Monsen NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MonsenNPCs2 = 1184138,
        //[Description("Monsen NPCs 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MonsenNPCs3 = 1252250,
        //[Description("Monsen NPCs 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MonsenNPCs4 = 1183116,
        //[Description("Monsen NPCs 5")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MonsenNPCs5 = 1185280,
        //[Description("Monsen NPCs 6")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MonsenNPCs6 = 1182060,
        //[Description("Monsen NPCs 7")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MonsenNPCs7 = 1299530,
        //[Description("Monsen NPCs 8")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MonsenNPCs8 = 18,
        //[Description("Monsen NPCs 9")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MonsenNPCs9 = -1,
        //[Description("Monsen NPCs 10")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MonsenNPCs10 = 522125568,
        //[Description("Monsen NPCs 11")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MonsenNPCs11 = 65554,
        //[Description("Monsen NPCs 12")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MonsenNPCs12 = 1396284,
        //[Description("Monsen Inn 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MonsenInn1 = 1218660,
        //[Description("Monsen Inn 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MonsenInn2 = 1223412,
        //[Description("Monsen Inn 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MonsenInn3 = 1228372,
        //[Description("Monsen Inn 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MonsenInn4 = 1233732,
        //[Description("Monsen Inn NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MonsenInnNPCs1 = 1264070,
        //[Description("Monsen Inn NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MonsenInnNPCs2 = 1184138,
        //[Description("Monsen Inn NPCs 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MonsenInnNPCs3 = 1340094,
        //[Description("Monsen Inn NPCs 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MonsenInnNPCs4 = 1341354,
        //[Description("Monsen House 1 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MonsenHouse11 = 1218660,
        //[Description("Monsen House 1 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MonsenHouse12 = 1223412,
        //[Description("Monsen House 1 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MonsenHouse13 = 1228372,
        //[Description("Monsen House 1 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MonsenHouse14 = 1233732,
        //[Description("Monsen House 2 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MonsenHouse21 = 1218660,
        //[Description("Monsen House 2 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MonsenHouse22 = 1223412,
        //[Description("Monsen House 2 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MonsenHouse23 = 1228372,
        //[Description("Monsen House 2 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MonsenHouse24 = 1233732,
        //[Description("Monsen House 2 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MonsenHouse2NPCs1 = 1242644,
        //[Description("Monsen House 3 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MonsenHouse31 = 1218660,
        //[Description("Monsen House 3 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MonsenHouse32 = 1223412,
        //[Description("Monsen House 3 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MonsenHouse33 = 1228372,
        //[Description("Monsen House 3 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MonsenHouse34 = 1233732,
        //[Description("Monsen House 3 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MonsenHouse3NPCs1 = 1252250,
        //[Description("Monsen House 3 NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MonsenHouse3NPCs2 = 1354590,
        //[Description("Monsen House 4 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MonsenHouse41 = 1218660,
        //[Description("Monsen House 4 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MonsenHouse42 = 1223412,
        //[Description("Monsen House 4 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MonsenHouse43 = 1228372,
        //[Description("Monsen House 4 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MonsenHouse44 = 1233732,
        //[Description("Monsen House 4 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MonsenHouse4NPCs1 = 1242644,
        //[Description("Monsen House 4 NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MonsenHouse4NPCs2 = 1261324,
        //[Description("Monsen House 5 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MonsenHouse51 = 1218660,
        //[Description("Monsen House 5 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MonsenHouse52 = 1223412,
        //[Description("Monsen House 5 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MonsenHouse53 = 1228372,
        //[Description("Monsen House 5 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MonsenHouse54 = 1233732,
        //[Description("Monsen House 5 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MonsenHouse5NPCs1 = 1185280,
        //[Description("Monsen Item Shop 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MonsenItemShop1 = 1218660,
        //[Description("Monsen Item Shop 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MonsenItemShop2 = 1223412,
        //[Description("Monsen Item Shop 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MonsenItemShop3 = 1228372,
        //[Description("Monsen Item Shop 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MonsenItemShop4 = 1233732,
        //[Description("Monsen Item Shop NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MonsenItemShopNPCs1 = 1183116,
        //[Description("Monsen Item Shop NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MonsenItemShopNPCs2 = 1184138,
        //[Description("Termi 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Termi1 = 1165320,
        //[Description("Termi 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Termi2 = 1171048,
        //[Description("Termi 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Termi3 = 1401062,
        //[Description("Termi NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //TermiNPCs1 = 1185280,
        //[Description("Termi NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //TermiNPCs2 = 1289984,
        //[Description("Termi NPCs 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //TermiNPCs3 = 1252250,
        //[Description("Termi NPCs 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //TermiNPCs4 = 1182060,
        //[Description("Termi NPCs 5")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //TermiNPCs5 = 1235908,
        //[Description("Termi NPCs 6")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //TermiNPCs6 = 1183116,
        //[Description("Termi NPCs 7")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //TermiNPCs7 = 1300984,
        //[Description("Termi NPCs 8")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //TermiNPCs8 = 1299530,
        //[Description("Termi Item Shop 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TermiItemShop1 = 1218660,
        //[Description("Termi Item Shop 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TermiItemShop2 = 1223412,
        //[Description("Termi Item Shop 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TermiItemShop3 = 1228372,
        //[Description("Termi Item Shop 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TermiItemShop4 = 1233732,
        //[Description("Termi Item Shop NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //TermiItemShopNPCs1 = 1187500,
        //[Description("Termi Item Shop NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //TermiItemShopNPCs2 = 1182060,
        //[Description("Termi House 1 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TermiHouse11 = 1218660,
        //[Description("Termi House 1 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TermiHouse12 = 1223412,
        //[Description("Termi House 1 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TermiHouse13 = 1228372,
        //[Description("Termi House 1 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TermiHouse14 = 1233732,
        //[Description("Termi House 1 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //TermiHouse1NPCs1 = 1185280,
        //[Description("Termi Weapon Shop 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TermiWeaponShop1 = 1218660,
        //[Description("Termi Weapon Shop 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TermiWeaponShop2 = 1223412,
        //[Description("Termi Weapon Shop 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TermiWeaponShop3 = 1228372,
        //[Description("Termi Weapon Shop 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TermiWeaponShop4 = 1233732,
        //[Description("Termi Weapon Shop NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //TermiWeaponShopNPCs1 = 1182060,
        //[Description("Termi Weapon Shop NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //TermiWeaponShopNPCs2 = 1187500,
        //[Description("Termi Weapon Shop NPCs 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //TermiWeaponShopNPCs3 = 1242644,
        //[Description("Termi Inn 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TermiInn1 = 1218660,
        //[Description("Termi Inn 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TermiInn2 = 1223412,
        //[Description("Termi Inn 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TermiInn3 = 1228372,
        //[Description("Termi Inn 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TermiInn4 = 1233732,
        //[Description("Termi Inn NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //TermiInnNPCs1 = 1183116,
        //[Description("Termi Inn NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //TermiInnNPCs2 = 1184138,
        //[Description("Termi House 2 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TermiHouse21 = 1218660,
        //[Description("Termi House 2 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TermiHouse22 = 1223412,
        //[Description("Termi House 2 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TermiHouse23 = 1228372,
        //[Description("Termi House 2 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TermiHouse24 = 1233732,
        //[Description("Termi House 2 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //TermiHouse2NPCs1 = 1242644,
        //[Description("Termi House 2 NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //TermiHouse2NPCs2 = 1183116,
        //[Description("Passageway 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Passageway1 = 1267750,
        //[Description("Passageway 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Passageway2 = 1272758,
        //[Description("Zio Fort Area 1 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZioFortArea11 = 1416212,
        //[Description("Zio Fort Area 1 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZioFortArea12 = 1422052,
        //[Description("Zio Fort Area 1 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZioFortArea13 = 1425348,
        //[Description("Zio Fort Area 1 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZioFortArea14 = 1430420,
        //[Description("Zio Fort Area 1 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //ZioFortArea1NPCs1 = 1433022,
        //[Description("Zio Fort Area 1 NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //ZioFortArea1NPCs2 = 1432420,
        //[Description("Zio Fort Area 2 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZioFortArea21 = 1416212,
        //[Description("Zio Fort Area 2 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZioFortArea22 = 1422052,
        //[Description("Zio Fort Area 2 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZioFortArea23 = 1425348,
        //[Description("Zio Fort Area 2 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZioFortArea24 = 1430420,
        //[Description("Zio Fort F1 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZioFortF11 = 1416212,
        //[Description("Zio Fort F1 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZioFortF12 = 1422052,
        //[Description("Zio Fort F1 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZioFortF13 = 1425348,
        //[Description("Zio Fort F1 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZioFortF14 = 1430420,
        //[Description("Zio Fort F1 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //ZioFortF1NPCs1 = 1432420,
        //[Description("Zio Fort F2 West 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZioFortF2West1 = 1416212,
        //[Description("Zio Fort F2 West 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZioFortF2West2 = 1422052,
        //[Description("Zio Fort F2 West 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZioFortF2West3 = 1425348,
        //[Description("Zio Fort F2 West 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZioFortF2West4 = 1430420,
        //[Description("Zio Fort West Tunnel 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZioFortWestTunnel1 = 1416212,
        //[Description("Zio Fort West Tunnel 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZioFortWestTunnel2 = 1422052,
        //[Description("Zio Fort West Tunnel 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZioFortWestTunnel3 = 1425348,
        //[Description("Zio Fort West Tunnel 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZioFortWestTunnel4 = 1430420,
        //[Description("Zio Fort Juza Room 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZioFortJuzaRoom1 = 1416212,
        //[Description("Zio Fort Juza Room 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZioFortJuzaRoom2 = 1422052,
        //[Description("Zio Fort Juza Room 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZioFortJuzaRoom3 = 1425348,
        //[Description("Zio Fort Juza Room 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZioFortJuzaRoom4 = 1430420,
        //[Description("Zio Fort Juza Room NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //ZioFortJuzaRoomNPCs1 = 1432420,
        //[Description("Zio Fort Juza Room NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //ZioFortJuzaRoomNPCs2 = 1441022,
        //[Description("Zio Fort East Tunnel 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZioFortEastTunnel1 = 1416212,
        //[Description("Zio Fort East Tunnel 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZioFortEastTunnel2 = 1422052,
        //[Description("Zio Fort East Tunnel 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZioFortEastTunnel3 = 1425348,
        //[Description("Zio Fort East Tunnel 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZioFortEastTunnel4 = 1430420,
        //[Description("Zio Fort F2 East 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZioFortF2East1 = 1416212,
        //[Description("Zio Fort F2 East 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZioFortF2East2 = 1422052,
        //[Description("Zio Fort F2 East 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZioFortF2East3 = 1425348,
        //[Description("Zio Fort F2 East 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZioFortF2East4 = 1430420,
        //[Description("Zio Fort F3 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZioFortF31 = 1416212,
        //[Description("Zio Fort F3 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZioFortF32 = 1422052,
        //[Description("Zio Fort F3 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZioFortF33 = 1425348,
        //[Description("Zio Fort F3 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZioFortF34 = 1430420,
        //[Description("Zio Fort F3 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //ZioFortF3NPCs1 = 1432420,
        //[Description("Zio Fort F4 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZioFortF41 = 1416212,
        //[Description("Zio Fort F4 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZioFortF42 = 1422052,
        //[Description("Zio Fort F4 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZioFortF43 = 1425348,
        //[Description("Zio Fort F4 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZioFortF44 = 1430420,
        //[Description("Zio Fort F4 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //ZioFortF4NPCs1 = 1442888,
        //[Description("Ladea Tower 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //LadeaTower1 = 1443598,
        //[Description("Ladea Tower 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //LadeaTower2 = 1449310,
        //[Description("Ladea Tower 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //LadeaTower3 = 1425348,
        //[Description("Ladea Tower 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //LadeaTower4 = 1430420,
        //[Description("Ladea Tower F1 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //LadeaTowerF11 = 1443598,
        //[Description("Ladea Tower F1 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //LadeaTowerF12 = 1449310,
        //[Description("Ladea Tower F1 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //LadeaTowerF13 = 1425348,
        //[Description("Ladea Tower F1 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //LadeaTowerF14 = 1430420,
        //[Description("Ladea Tower F2 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //LadeaTowerF21 = 1443598,
        //[Description("Ladea Tower F2 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //LadeaTowerF22 = 1449310,
        //[Description("Ladea Tower F2 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //LadeaTowerF23 = 1425348,
        //[Description("Ladea Tower F2 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //LadeaTowerF24 = 1430420,
        //[Description("Ladea Tower F3 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //LadeaTowerF31 = 1443598,
        //[Description("Ladea Tower F3 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //LadeaTowerF32 = 1449310,
        //[Description("Ladea Tower F3 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //LadeaTowerF33 = 1425348,
        //[Description("Ladea Tower F3 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //LadeaTowerF34 = 1430420,
        //[Description("Ladea Tower F4 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //LadeaTowerF41 = 1443598,
        //[Description("Ladea Tower F4 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //LadeaTowerF42 = 1449310,
        //[Description("Ladea Tower F4 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //LadeaTowerF43 = 1425348,
        //[Description("Ladea Tower F4 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //LadeaTowerF44 = 1430420,
        //[Description("Ladea Tower F5 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //LadeaTowerF51 = 1443598,
        //[Description("Ladea Tower F5 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //LadeaTowerF52 = 1449310,
        //[Description("Ladea Tower F5 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //LadeaTowerF53 = 1425348,
        //[Description("Ladea Tower F5 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //LadeaTowerF54 = 1430420,
        //[Description("Ladea Tower F5 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //LadeaTowerF5NPCs1 = 1460072,
        //[Description("Island Cave 1 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //IslandCave11 = 1462116,
        //[Description("Island Cave 1 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //IslandCave12 = 1466964,
        //[Description("Island Cave 1 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //IslandCave1NPCs1 = 1469636,
        //[Description("Island Cave F1 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //IslandCaveF11 = 1462116,
        //[Description("Island Cave F1 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //IslandCaveF12 = 1466964,
        //[Description("Island Cave F1 2 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //IslandCaveF121 = 1462116,
        //[Description("Island Cave F1 2 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //IslandCaveF122 = 1466964,
        //[Description("Island Cave 2 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //IslandCave21 = 1462116,
        //[Description("Island Cave 2 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //IslandCave22 = 1466964,
        //[Description("Island Cave B1 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //IslandCaveB11 = 1462116,
        //[Description("Island Cave B1 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //IslandCaveB12 = 1466964,
        //[Description("Island Cave F2 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //IslandCaveF21 = 1462116,
        //[Description("Island Cave F2 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //IslandCaveF22 = 1466964,
        //[Description("Island Cave F3 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //IslandCaveF31 = 1462116,
        //[Description("Island Cave F3 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //IslandCaveF32 = 1466964,
        //[Description("Soldiers Temple Outside 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //SoldiersTempleOutside1 = 1479112,
        //[Description("Soldiers Temple Outside 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //SoldiersTempleOutside2 = 1484360,
        //[Description("Soldiers Temple 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //SoldiersTemple1 = 1479112,
        //[Description("Soldiers Temple 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //SoldiersTemple2 = 1484360,
        //[Description("Valley Maze 1 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ValleyMaze11 = 1462116,
        //[Description("Valley Maze 1 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ValleyMaze12 = 1466964,
        //[Description("Valley Maze 2 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ValleyMaze21 = 1462116,
        //[Description("Valley Maze 2 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ValleyMaze22 = 1466964,
        //[Description("Valley Maze 3 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ValleyMaze31 = 1462116,
        //[Description("Valley Maze 3 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ValleyMaze32 = 1466964,
        //[Description("Valley Maze 4 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ValleyMaze41 = 1462116,
        //[Description("Valley Maze 4 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ValleyMaze42 = 1466964,
        //[Description("Valley Maze 5 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ValleyMaze51 = 1462116,
        //[Description("Valley Maze 5 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ValleyMaze52 = 1466964,
        //[Description("Valley Maze 6 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ValleyMaze61 = 1462116,
        //[Description("Valley Maze 6 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ValleyMaze62 = 1466964,
        //[Description("Valley Maze 7 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ValleyMaze71 = 1462116,
        //[Description("Valley Maze 7 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ValleyMaze72 = 1466964,
        //[Description("Bio Plant 1 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //BioPlant11 = 1497994,
        //[Description("Bio Plant 1 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //BioPlant12 = 1502138,
        //[Description("Bio Plant 1 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //BioPlant13 = 1504506,
        //[Description("Bio Plant 2 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //BioPlant21 = 1497994,
        //[Description("Bio Plant 2 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //BioPlant22 = 1502138,
        //[Description("Bio Plant 2 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //BioPlant23 = 1504506,
        //[Description("Bio Plant 3 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //BioPlant31 = 1497994,
        //[Description("Bio Plant 3 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //BioPlant32 = 1502138,
        //[Description("Bio Plant 3 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //BioPlant33 = 1504506,
        //[Description("Bio Plant B1 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //BioPlantB11 = 1497994,
        //[Description("Bio Plant B1 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //BioPlantB12 = 1502138,
        //[Description("Bio Plant B1 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //BioPlantB13 = 1504506,
        //[Description("Bio Plant B2 1 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //BioPlantB211 = 1497994,
        //[Description("Bio Plant B2 1 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //BioPlantB212 = 1502138,
        //[Description("Bio Plant B2 1 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //BioPlantB213 = 1504506,
        //[Description("Bio Plant B2 2 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //BioPlantB221 = 1497994,
        //[Description("Bio Plant B2 2 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //BioPlantB222 = 1502138,
        //[Description("Bio Plant B2 2 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //BioPlantB223 = 1504506,
        //[Description("Bio Plant B3 1 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //BioPlantB311 = 1497994,
        //[Description("Bio Plant B3 1 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //BioPlantB312 = 1502138,
        //[Description("Bio Plant B3 1 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //BioPlantB313 = 1504506,
        //[Description("Bio Plant B3 2 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //BioPlantB321 = 1497994,
        //[Description("Bio Plant B3 2 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //BioPlantB322 = 1502138,
        //[Description("Bio Plant B3 2 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //BioPlantB323 = 1504506,
        //[Description("Bio Plant B4 1 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //BioPlantB411 = 1497994,
        //[Description("Bio Plant B4 1 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //BioPlantB412 = 1502138,
        //[Description("Bio Plant B4 1 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //BioPlantB413 = 1504506,
        //[Description("Bio Plant B4 2 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //BioPlantB421 = 1497994,
        //[Description("Bio Plant B4 2 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //BioPlantB422 = 1502138,
        //[Description("Bio Plant B4 2 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //BioPlantB423 = 1504506,
        //[Description("Bio Plant B4 2 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //BioPlantB42NPCs1 = 1214970,
        //[Description("Bio Plant B4 3 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //BioPlantB431 = 1497994,
        //[Description("Bio Plant B4 3 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //BioPlantB432 = 1502138,
        //[Description("Bio Plant B4 3 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //BioPlantB433 = 1504506,
        //[Description("Bio Plant B4 3 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //BioPlantB43NPCs1 = 1214970,
        //[Description("Wreckage 1 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Wreckage11 = 1497994,
        //[Description("Wreckage 1 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Wreckage12 = 1515572,
        //[Description("Wreckage 1 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Wreckage13 = 1516212,
        //[Description("Wreckage 2 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Wreckage21 = 1497994,
        //[Description("Wreckage 2 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Wreckage22 = 1515572,
        //[Description("Wreckage 2 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Wreckage23 = 1516212,
        //[Description("Wreckage 3 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Wreckage31 = 1497994,
        //[Description("Wreckage 3 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Wreckage32 = 1515572,
        //[Description("Wreckage 3 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Wreckage33 = 1516212,
        //[Description("Wreckage F1 1 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //WreckageF111 = 1497994,
        //[Description("Wreckage F1 1 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //WreckageF112 = 1515572,
        //[Description("Wreckage F1 1 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //WreckageF113 = 1516212,
        //[Description("Wreckage F1 2 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //WreckageF121 = 1497994,
        //[Description("Wreckage F1 2 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //WreckageF122 = 1515572,
        //[Description("Wreckage F1 2 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //WreckageF123 = 1516212,
        //[Description("Wreckage F2 1 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //WreckageF211 = 1497994,
        //[Description("Wreckage F2 1 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //WreckageF212 = 1515572,
        //[Description("Wreckage F2 1 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //WreckageF213 = 1516212,
        //[Description("Wreckage F2 2 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //WreckageF221 = 1497994,
        //[Description("Wreckage F2 2 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //WreckageF222 = 1515572,
        //[Description("Wreckage F2 2 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //WreckageF223 = 1516212,
        //[Description("Wreckage F2 3 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //WreckageF231 = 1497994,
        //[Description("Wreckage F2 3 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //WreckageF232 = 1515572,
        //[Description("Wreckage F2 3 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //WreckageF233 = 1516212,
        //[Description("Wreckage F2 4 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //WreckageF241 = 1497994,
        //[Description("Wreckage F2 4 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //WreckageF242 = 1515572,
        //[Description("Wreckage F2 4 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //WreckageF243 = 1516212,
        //[Description("Machine Center 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MachineCenter1 = 1497994,
        //[Description("Machine Center 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MachineCenter2 = 1526600,
        //[Description("Machine Center 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MachineCenter3 = 1529656,
        //[Description("Machine Center B1 1 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MachineCenterB111 = 1497994,
        //[Description("Machine Center B1 1 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MachineCenterB112 = 1526600,
        //[Description("Machine Center B1 1 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MachineCenterB113 = 1529656,
        //[Description("Machine Center B1 2 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MachineCenterB121 = 1497994,
        //[Description("Machine Center B1 2 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MachineCenterB122 = 1526600,
        //[Description("Machine Center B1 2 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MachineCenterB123 = 1529656,
        //[Description("Plate System 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //PlateSystem1 = 1497994,
        //[Description("Plate System 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //PlateSystem2 = 1504506,
        //[Description("Plate System 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //PlateSystem3 = 1529656,
        //[Description("Plate System 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //PlateSystem4 = 1515572,
        //[Description("Plate System NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //PlateSystemNPCs1 = 1552558,
        //[Description("Plate System F1 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //PlateSystemF11 = 1497994,
        //[Description("Plate System F1 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //PlateSystemF12 = 1504506,
        //[Description("Plate System F1 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //PlateSystemF13 = 1529656,
        //[Description("Plate System F1 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //PlateSystemF14 = 1515572,
        //[Description("Plate System F2 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //PlateSystemF21 = 1497994,
        //[Description("Plate System F2 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //PlateSystemF22 = 1504506,
        //[Description("Plate System F2 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //PlateSystemF23 = 1529656,
        //[Description("Plate System F2 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //PlateSystemF24 = 1515572,
        //[Description("Plate System F3 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //PlateSystemF31 = 1497994,
        //[Description("Plate System F3 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //PlateSystemF32 = 1504506,
        //[Description("Plate System F3 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //PlateSystemF33 = 1529656,
        //[Description("Plate System F3 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //PlateSystemF34 = 1515572,
        //[Description("Plate System F4 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //PlateSystemF41 = 1497994,
        //[Description("Plate System F4 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //PlateSystemF42 = 1504506,
        //[Description("Plate System F4 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //PlateSystemF43 = 1529656,
        //[Description("Plate System F4 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //PlateSystemF44 = 1515572,
        //[Description("Mota Spaceport 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MotaSpaceport1 = 1497994,
        //[Description("Mota Spaceport 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MotaSpaceport2 = 1526600,
        //[Description("Mota Spaceport 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MotaSpaceport3 = 1529656,
        //[Description("Climate Center 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ClimateCenter1 = 1497994,
        //[Description("Climate Center 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ClimateCenter2 = 1504506,
        //[Description("Climate Center 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ClimateCenter3 = 1529656,
        //[Description("Climate Center 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ClimateCenter4 = 1515572,
        //[Description("Clim Center F1 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ClimCenterF11 = 1497994,
        //[Description("Clim Center F1 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ClimCenterF12 = 1504506,
        //[Description("Clim Center F1 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ClimCenterF13 = 1529656,
        //[Description("Clim Center F1 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ClimCenterF14 = 1515572,
        //[Description("Clim Center F2 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ClimCenterF21 = 1497994,
        //[Description("Clim Center F2 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ClimCenterF22 = 1504506,
        //[Description("Clim Center F2 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ClimCenterF23 = 1529656,
        //[Description("Clim Center F2 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ClimCenterF24 = 1515572,
        //[Description("Clim Center F3 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ClimCenterF31 = 1497994,
        //[Description("Clim Center F3 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ClimCenterF32 = 1504506,
        //[Description("Clim Center F3 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ClimCenterF33 = 1529656,
        //[Description("Clim Center F3 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ClimCenterF34 = 1515572,
        //[Description("Clim Center F3 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //ClimCenterF3NPCs1 = 1544304,
        //[Description("Weapon Plant 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //WeaponPlant1 = 1497994,
        //[Description("Weapon Plant 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //WeaponPlant2 = 1504506,
        //[Description("Weapon Plant 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //WeaponPlant3 = 1529656,
        //[Description("Weapon Plant 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //WeaponPlant4 = 1515572,
        //[Description("Weapon Plant 5")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //WeaponPlant5 = 1545012,
        //[Description("Weapon Plant F1 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //WeaponPlantF11 = 1497994,
        //[Description("Weapon Plant F1 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //WeaponPlantF12 = 1504506,
        //[Description("Weapon Plant F1 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //WeaponPlantF13 = 1529656,
        //[Description("Weapon Plant F1 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //WeaponPlantF14 = 1515572,
        //[Description("Weapon Plant F1 5")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //WeaponPlantF15 = 1545012,
        //[Description("Weapon Plant F2 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //WeaponPlantF21 = 1497994,
        //[Description("Weapon Plant F2 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //WeaponPlantF22 = 1504506,
        //[Description("Weapon Plant F2 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //WeaponPlantF23 = 1529656,
        //[Description("Weapon Plant F2 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //WeaponPlantF24 = 1515572,
        //[Description("Weapon Plant F2 5")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //WeaponPlantF25 = 1545012,
        //[Description("Weapon Plant F3 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //WeaponPlantF31 = 1497994,
        //[Description("Weapon Plant F3 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //WeaponPlantF32 = 1504506,
        //[Description("Weapon Plant F3 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //WeaponPlantF33 = 1529656,
        //[Description("Weapon Plant F3 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //WeaponPlantF34 = 1515572,
        //[Description("Weapon Plant F3 5")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //WeaponPlantF35 = 1545012,
        //[Description("Vahal Fort 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //VahalFort1 = 1497994,
        //[Description("Vahal Fort 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //VahalFort2 = 1504506,
        //[Description("Vahal Fort 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //VahalFort3 = 1529656,
        //[Description("Vahal Fort 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //VahalFort4 = 1515572,
        //[Description("Vahal Fort 5")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //VahalFort5 = 1545012,
        //[Description("Vahal Fort NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //VahalFortNPCs1 = 1552558,
        //[Description("Vahal Fort F1 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //VahalFortF11 = 1497994,
        //[Description("Vahal Fort F1 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //VahalFortF12 = 1504506,
        //[Description("Vahal Fort F1 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //VahalFortF13 = 1529656,
        //[Description("Vahal Fort F1 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //VahalFortF14 = 1515572,
        //[Description("Vahal Fort F1 5")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //VahalFortF15 = 1545012,
        //[Description("Vahal Fort F2 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //VahalFortF21 = 1497994,
        //[Description("Vahal Fort F2 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //VahalFortF22 = 1504506,
        //[Description("Vahal Fort F2 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //VahalFortF23 = 1529656,
        //[Description("Vahal Fort F2 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //VahalFortF24 = 1515572,
        //[Description("Vahal Fort F2 5")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //VahalFortF25 = 1545012,
        //[Description("Vahal Fort F3 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //VahalFortF31 = 1497994,
        //[Description("Vahal Fort F3 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //VahalFortF32 = 1504506,
        //[Description("Vahal Fort F3 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //VahalFortF33 = 1529656,
        //[Description("Vahal Fort F3 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //VahalFortF34 = 1515572,
        //[Description("Vahal Fort F3 5")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //VahalFortF35 = 1545012,
        //[Description("Nurvus 2 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Nurvus21 = 1497994,
        //[Description("Nurvus 2 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Nurvus22 = 1504506,
        //[Description("Nurvus 2 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Nurvus23 = 1555138,
        //[Description("Nurvus 2 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Nurvus24 = 1556610,
        //[Description("Nurvus 3 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Nurvus31 = 1497994,
        //[Description("Nurvus 3 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Nurvus32 = 1504506,
        //[Description("Nurvus 3 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Nurvus33 = 1555138,
        //[Description("Nurvus 3 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Nurvus34 = 1556610,
        //[Description("Nurvus B1 1 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //NurvusB111 = 1497994,
        //[Description("Nurvus B1 1 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //NurvusB112 = 1504506,
        //[Description("Nurvus B1 1 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //NurvusB113 = 1555138,
        //[Description("Nurvus B1 1 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //NurvusB114 = 1556610,
        //[Description("Nurvus B2 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //NurvusB21 = 1497994,
        //[Description("Nurvus B2 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //NurvusB22 = 1504506,
        //[Description("Nurvus B2 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //NurvusB23 = 1555138,
        //[Description("Nurvus B2 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //NurvusB24 = 1556610,
        //[Description("Nurvus B3 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //NurvusB31 = 1497994,
        //[Description("Nurvus B3 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //NurvusB32 = 1504506,
        //[Description("Nurvus B3 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //NurvusB33 = 1555138,
        //[Description("Nurvus B3 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //NurvusB34 = 1556610,
        //[Description("Nurvus B1 2 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //NurvusB121 = 1497994,
        //[Description("Nurvus B1 2 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //NurvusB122 = 1504506,
        //[Description("Nurvus B1 2 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //NurvusB123 = 1555138,
        //[Description("Nurvus B1 2 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //NurvusB124 = 1556610,
        //[Description("Nurvus B4 1 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //NurvusB411 = 1497994,
        //[Description("Nurvus B4 1 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //NurvusB412 = 1504506,
        //[Description("Nurvus B4 1 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //NurvusB413 = 1555138,
        //[Description("Nurvus B4 1 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //NurvusB414 = 1556610,
        //[Description("Nurvus B4 2 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //NurvusB421 = 1497994,
        //[Description("Nurvus B4 2 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //NurvusB422 = 1504506,
        //[Description("Nurvus B4 2 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //NurvusB423 = 1555138,
        //[Description("Nurvus B4 2 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //NurvusB424 = 1556610,
        //[Description("Dezo Spaceport 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //DezoSpaceport1 = 1497994,
        //[Description("Dezo Spaceport 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //DezoSpaceport2 = 1526600,
        //[Description("Dezo Spaceport 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //DezoSpaceport3 = 1529656,
        //[Description("Nurvus B5 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //NurvusB51 = 1497994,
        //[Description("Nurvus B5 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //NurvusB52 = 1504506,
        //[Description("Nurvus B5 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //NurvusB53 = 1555138,
        //[Description("Nurvus B5 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //NurvusB54 = 1556610,
        //[Description("Nurvus 1 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Nurvus11 = 1802172,
        //[Description("Nurvus 1 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Nurvus12 = 1811628,
        //[Description("Valley Maze Outside 1 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ValleyMazeOutside11 = 1568172,
        //[Description("Valley Maze Outside 2 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ValleyMazeOutside21 = 1568172,
        //[Description("Passageway Near Aiedo 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //PassagewayNearAiedo1 = 1568172,
        //[Description("Passageway Near Kadary 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //PassagewayNearKadary1 = 1568172,
        //[Description("Uzo 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Uzo1 = 1165320,
        //[Description("Uzo 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Uzo2 = 1171048,
        //[Description("Uzo 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Uzo3 = 1279556,
        //[Description("Uzo NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //UzoNPCs1 = 1242644,
        //[Description("Uzo NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //UzoNPCs2 = 1183116,
        //[Description("Uzo NPCs 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //UzoNPCs3 = 1184138,
        //[Description("Uzo NPCs 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //UzoNPCs4 = 1252250,
        //[Description("Uzo House 1 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //UzoHouse11 = 1218660,
        //[Description("Uzo House 1 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //UzoHouse12 = 1223412,
        //[Description("Uzo House 1 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //UzoHouse13 = 1228372,
        //[Description("Uzo House 1 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //UzoHouse14 = 1233732,
        //[Description("Uzo House 1 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //UzoHouse1NPCs1 = 1182060,
        //[Description("Uzo House 2 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //UzoHouse21 = 1218660,
        //[Description("Uzo House 2 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //UzoHouse22 = 1223412,
        //[Description("Uzo House 2 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //UzoHouse23 = 1228372,
        //[Description("Uzo House 2 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //UzoHouse24 = 1233732,
        //[Description("Uzo House 2 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //UzoHouse2NPCs1 = 1340094,
        //[Description("Uzo Inn 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //UzoInn1 = 1218660,
        //[Description("Uzo Inn 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //UzoInn2 = 1223412,
        //[Description("Uzo Inn 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //UzoInn3 = 1228372,
        //[Description("Uzo Inn 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //UzoInn4 = 1233732,
        //[Description("Uzo Inn NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //UzoInnNPCs1 = 1242644,
        //[Description("Uzo House 3 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //UzoHouse31 = 1218660,
        //[Description("Uzo House 3 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //UzoHouse32 = 1223412,
        //[Description("Uzo House 3 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //UzoHouse33 = 1228372,
        //[Description("Uzo House 3 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //UzoHouse34 = 1233732,
        //[Description("Uzo House 3 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //UzoHouse3NPCs1 = 1183116,
        //[Description("Uzo House 3 NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //UzoHouse3NPCs2 = 1184138,
        //[Description("Uzo House 3 NPCs 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //UzoHouse3NPCs3 = 1185280,
        //[Description("Uzo House 3 NPCs 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //UzoHouse3NPCs4 = 1235908,
        //[Description("Uzo Item Shop 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //UzoItemShop1 = 1218660,
        //[Description("Uzo Item Shop 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //UzoItemShop2 = 1223412,
        //[Description("Uzo Item Shop 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //UzoItemShop3 = 1228372,
        //[Description("Uzo Item Shop 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //UzoItemShop4 = 1233732,
        //[Description("Uzo Item Shop NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //UzoItemShopNPCs1 = 1264070,
        //[Description("Torinco 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Torinco1 = 1165320,
        //[Description("Torinco 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Torinco2 = 1171048,
        //[Description("Torinco 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Torinco3 = 1401062,
        //[Description("Torinco NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //TorincoNPCs1 = 1242644,
        //[Description("Torinco NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //TorincoNPCs2 = 1183116,
        //[Description("Torinco NPCs 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //TorincoNPCs3 = 1185280,
        //[Description("Torinco NPCs 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //TorincoNPCs4 = 1289984,
        //[Description("Torinco NPCs 5")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //TorincoNPCs5 = 1187500,
        //[Description("Torinco NPCs 6")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //TorincoNPCs6 = 18,
        //[Description("Torinco NPCs 7")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //TorincoNPCs7 = -1,
        //[Description("Torinco NPCs 8")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //TorincoNPCs8 = 522125568,
        //[Description("Torinco NPCs 9")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //TorincoNPCs9 = 65554,
        //[Description("Torinco NPCs 10")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //TorincoNPCs10 = 1406070,
        //[Description("Culvers House 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //CulversHouse1 = 1218660,
        //[Description("Culvers House 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //CulversHouse2 = 1223412,
        //[Description("Culvers House 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //CulversHouse3 = 1228372,
        //[Description("Culvers House 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //CulversHouse4 = 1233732,
        //[Description("Culvers House NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //CulversHouseNPCs1 = 1183116,
        //[Description("Culvers House NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //CulversHouseNPCs2 = 1184138,
        //[Description("Culvers House NPCs 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //CulversHouseNPCs3 = 1578980,
        //[Description("Culvers House NPCs 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //CulversHouseNPCs4 = 1244208,
        //[Description("Culvers House NPCs 5")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //CulversHouseNPCs5 = 1579048,
        //[Description("Torinco House 1 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TorincoHouse11 = 1218660,
        //[Description("Torinco House 1 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TorincoHouse12 = 1223412,
        //[Description("Torinco House 1 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TorincoHouse13 = 1228372,
        //[Description("Torinco House 1 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TorincoHouse14 = 1233732,
        //[Description("Torinco House 1 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //TorincoHouse1NPCs1 = 1252250,
        //[Description("Torinco House 2 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TorincoHouse21 = 1218660,
        //[Description("Torinco House 2 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TorincoHouse22 = 1223412,
        //[Description("Torinco House 2 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TorincoHouse23 = 1228372,
        //[Description("Torinco House 2 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TorincoHouse24 = 1233732,
        //[Description("Torinco House 2 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //TorincoHouse2NPCs1 = 1183116,
        //[Description("Torinco Item Shop 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TorincoItemShop1 = 1218660,
        //[Description("Torinco Item Shop 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TorincoItemShop2 = 1223412,
        //[Description("Torinco Item Shop 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TorincoItemShop3 = 1228372,
        //[Description("Torinco Item Shop 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TorincoItemShop4 = 1233732,
        //[Description("Torinco Item Shop NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //TorincoItemShopNPCs1 = 1264070,
        //[Description("Torinco Inn 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TorincoInn1 = 1218660,
        //[Description("Torinco Inn 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TorincoInn2 = 1223412,
        //[Description("Torinco Inn 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TorincoInn3 = 1228372,
        //[Description("Torinco Inn 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TorincoInn4 = 1233732,
        //[Description("Torinco Inn NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //TorincoInnNPCs1 = 1184138,
        //[Description("Monsen Cave 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MonsenCave1 = 1267750,
        //[Description("Monsen Cave 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MonsenCave2 = 1272758,
        //[Description("Monsen Cave NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MonsenCaveNPCs1 = 1582466,
        //[Description("Monsen Cave NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MonsenCaveNPCs2 = 1261324,
        //[Description("Monsen Cave NPCs 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MonsenCaveNPCs3 = 1582926,
        //[Description("Rappy Cave 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //RappyCave1 = 1462116,
        //[Description("Rappy Cave 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //RappyCave2 = 1466964,
        //[Description("Rappy Cave 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //RappyCave3 = 1764702,
        //[Description("Rappy Cave NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //RappyCaveNPCs1 = 1183116,
        //[Description("Rappy Cave NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //RappyCaveNPCs2 = 1583888,
        //[Description("Le Roof Room 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //LeRoofRoom1 = 1585818,
        //[Description("Le Roof Room 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //LeRoofRoom2 = 1597498,
        //[Description("Silence Tm 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //SilenceTm1 = 1585818,
        //[Description("Silence Tm 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //SilenceTm2 = 1597498,
        //[Description("Strength Tower 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //StrengthTower1 = 1585818,
        //[Description("Strength Tower 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //StrengthTower2 = 1597498,
        //[Description("Strength Tower F1 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //StrengthTowerF11 = 1585818,
        //[Description("Strength Tower F1 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //StrengthTowerF12 = 1597498,
        //[Description("Strength Tower F2 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //StrengthTowerF21 = 1585818,
        //[Description("Strength Tower F2 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //StrengthTowerF22 = 1597498,
        //[Description("Strength Tower F3 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //StrengthTowerF31 = 1585818,
        //[Description("Strength Tower F3 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //StrengthTowerF32 = 1597498,
        //[Description("Strength Tower F4 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //StrengthTowerF41 = 1585818,
        //[Description("Strength Tower F4 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //StrengthTowerF42 = 1597498,
        //[Description("Strength Tower F4 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //StrengthTowerF4NPCs1 = 1605660,
        //[Description("Strength Tower F4 NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //StrengthTowerF4NPCs2 = 1607058,
        //[Description("Courage Tower 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //CourageTower1 = 1585818,
        //[Description("Courage Tower 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //CourageTower2 = 1597498,
        //[Description("Courage Tower F1 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //CourageTowerF11 = 1585818,
        //[Description("Courage Tower F1 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //CourageTowerF12 = 1597498,
        //[Description("Courage Tower F2 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //CourageTowerF21 = 1585818,
        //[Description("Courage Tower F2 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //CourageTowerF22 = 1597498,
        //[Description("Courage Tower F3 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //CourageTowerF31 = 1585818,
        //[Description("Courage Tower F3 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //CourageTowerF32 = 1597498,
        //[Description("Courage Tower F4 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //CourageTowerF41 = 1585818,
        //[Description("Courage Tower F4 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //CourageTowerF42 = 1597498,
        //[Description("Courage Tower F4 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //CourageTowerF4NPCs1 = 1611090,
        //[Description("Courage Tower F4 NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //CourageTowerF4NPCs2 = 1611998,
        //[Description("Anger Tower 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AngerTower1 = 1585818,
        //[Description("Anger Tower 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AngerTower2 = 1597498,
        //[Description("Anger Tower F1 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AngerTowerF11 = 1585818,
        //[Description("Anger Tower F1 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AngerTowerF12 = 1597498,
        //[Description("Anger Tower F2 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AngerTowerF21 = 1585818,
        //[Description("Anger Tower F2 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AngerTowerF22 = 1597498,
        //[Description("Anger Tower F2 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //AngerTowerF2NPCs1 = 1614168,
        //[Description("The Edge 1 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TheEdge11 = 1615546,
        //[Description("The Edge 2 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TheEdge21 = 1615546,
        //[Description("The Edge 3 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TheEdge31 = 1615546,
        //[Description("The Edge 4 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TheEdge41 = 1615546,
        //[Description("The Edge 5 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TheEdge51 = 1615546,
        //[Description("The Edge 6 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TheEdge61 = 1615546,
        //[Description("The Edge 7 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TheEdge71 = 1615546,
        //[Description("The Edge 8 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TheEdge81 = 1615546,
        //[Description("The Edge 9 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TheEdge91 = 1615546,
        //[Description("Tyler 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Tyler1 = 1634762,
        //[Description("Tyler 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Tyler2 = 1642874,
        //[Description("Tyler NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //TylerNPCs1 = 1644426,
        //[Description("Tyler NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //TylerNPCs2 = 1644756,
        //[Description("Tyler NPCs 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //TylerNPCs3 = 1645550,
        //[Description("Tyler NPCs 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //TylerNPCs4 = 1646476,
        //[Description("Tyler NPCs 5")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //TylerNPCs5 = 1647484,
        //[Description("Tyler NPCs 6")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //TylerNPCs6 = 1648528,
        //[Description("Tyler NPCs 7")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //TylerNPCs7 = 1649708,
        //[Description("Tyler House 1 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TylerHouse11 = 1653750,
        //[Description("Tyler House 1 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TylerHouse12 = 1663958,
        //[Description("Tyler House 1 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //TylerHouse1NPCs1 = 1668694,
        //[Description("Tyler House 1 NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //TylerHouse1NPCs2 = 1262200,
        //[Description("Tyler House 1 NPCs 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //TylerHouse1NPCs3 = 1187500,
        //[Description("Tyler House 1 NPCs 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //TylerHouse1NPCs4 = 1242644,
        //[Description("Tyler Weapon Shop 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TylerWeaponShop1 = 1653750,
        //[Description("Tyler Weapon Shop 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TylerWeaponShop2 = 1663958,
        //[Description("Tyler Weapon Shop NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //TylerWeaponShopNPCs1 = 1668694,
        //[Description("Tyler Weapon Shop NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //TylerWeaponShopNPCs2 = 1183116,
        //[Description("Tyler Weapon Shop NPCs 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //TylerWeaponShopNPCs3 = 1264070,
        //[Description("Tyler Item Shop 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TylerItemShop1 = 1653750,
        //[Description("Tyler Item Shop 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TylerItemShop2 = 1663958,
        //[Description("Tyler Item Shop NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //TylerItemShopNPCs1 = 1668694,
        //[Description("Tyler Item Shop NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //TylerItemShopNPCs2 = 1183116,
        //[Description("Tyler House 2 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TylerHouse21 = 1653750,
        //[Description("Tyler House 2 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TylerHouse22 = 1663958,
        //[Description("Tyler House 2 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //TylerHouse2NPCs1 = 1668694,
        //[Description("Tyler House 2 NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //TylerHouse2NPCs2 = 1668102,
        //[Description("Tyler House 2 NPCs 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //TylerHouse2NPCs3 = 1184138,
        //[Description("Tyler House 2 NPCs 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //TylerHouse2NPCs4 = 1235908,
        //[Description("Tyler House 2 NPCs 5")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //TylerHouse2NPCs5 = 1261324,
        //[Description("Tyler Inn 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TylerInn1 = 1653750,
        //[Description("Tyler Inn 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //TylerInn2 = 1663958,
        //[Description("Tyler Inn NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //TylerInnNPCs1 = 1668694,
        //[Description("Tyler Inn NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //TylerInnNPCs2 = 1185280,
        //[Description("Zosa 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Zosa1 = 1634762,
        //[Description("Zosa 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Zosa2 = 1674704,
        //[Description("Zosa NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //ZosaNPCs1 = 1644426,
        //[Description("Zosa NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //ZosaNPCs2 = 1678528,
        //[Description("Zosa NPCs 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //ZosaNPCs3 = 1679818,
        //[Description("Zosa NPCs 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //ZosaNPCs4 = 1681028,
        //[Description("Zosa NPCs 5")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //ZosaNPCs5 = 1682438,
        //[Description("Zosa House 1 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZosaHouse11 = 1653750,
        //[Description("Zosa House 1 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZosaHouse12 = 1663958,
        //[Description("Zosa House 1 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //ZosaHouse1NPCs1 = 1668694,
        //[Description("Zosa House 1 NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //ZosaHouse1NPCs2 = 1678528,
        //[Description("Zosa House 2 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZosaHouse21 = 1653750,
        //[Description("Zosa House 2 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZosaHouse22 = 1663958,
        //[Description("Zosa House 2 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //ZosaHouse2NPCs1 = 1668694,
        //[Description("Zosa House 2 NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //ZosaHouse2NPCs2 = 1679818,
        //[Description("Zosa House 2 NPCs 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //ZosaHouse2NPCs3 = 1678528,
        //[Description("Zosa Weapon Shop 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZosaWeaponShop1 = 1653750,
        //[Description("Zosa Weapon Shop 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZosaWeaponShop2 = 1663958,
        //[Description("Zosa Weapon Shop NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //ZosaWeaponShopNPCs1 = 1668694,
        //[Description("Zosa Weapon Shop NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //ZosaWeaponShopNPCs2 = 1679818,
        //[Description("Zosa Item Shop 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZosaItemShop1 = 1653750,
        //[Description("Zosa Item Shop 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZosaItemShop2 = 1663958,
        //[Description("Zosa Item Shop NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //ZosaItemShopNPCs1 = 1668694,
        //[Description("Zosa Item Shop NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //ZosaItemShopNPCs2 = 1679818,
        //[Description("Zosa Item Shop NPCs 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //ZosaItemShopNPCs3 = 1682438,
        //[Description("Zosa Inn 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZosaInn1 = 1653750,
        //[Description("Zosa Inn 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZosaInn2 = 1663958,
        //[Description("Zosa Inn NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //ZosaInnNPCs1 = 1668694,
        //[Description("Zosa Inn NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //ZosaInnNPCs2 = 1679818,
        //[Description("Zosa House 3 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZosaHouse31 = 1653750,
        //[Description("Zosa House 3 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZosaHouse32 = 1663958,
        //[Description("Zosa House 3 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //ZosaHouse3NPCs1 = 1668694,
        //[Description("Zosa House 3 NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //ZosaHouse3NPCs2 = 1678528,
        //[Description("Meese 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Meese1 = 1634762,
        //[Description("Meese 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Meese2 = 1689796,
        //[Description("Meese NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MeeseNPCs1 = 1644426,
        //[Description("Meese NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MeeseNPCs2 = 1648528,
        //[Description("Meese NPCs 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MeeseNPCs3 = 1649708,
        //[Description("Meese NPCs 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MeeseNPCs4 = 1690996,
        //[Description("Meese NPCs 5")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MeeseNPCs5 = 1692142,
        //[Description("Meese House 1 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MeeseHouse11 = 1653750,
        //[Description("Meese House 1 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MeeseHouse12 = 1663958,
        //[Description("Meese House 1 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MeeseHouse1NPCs1 = 1668694,
        //[Description("Meese House 1 NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MeeseHouse1NPCs2 = 1242644,
        //[Description("Meese House 1 NPCs 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MeeseHouse1NPCs3 = 1261324,
        //[Description("Meese Item Shop 2 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MeeseItemShop21 = 1653750,
        //[Description("Meese Item Shop 2 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MeeseItemShop22 = 1663958,
        //[Description("Meese Item Shop 2 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MeeseItemShop2NPCs1 = 1668694,
        //[Description("Meese Item Shop 2 NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MeeseItemShop2NPCs2 = 1183116,
        //[Description("Meese Item Shop 1 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MeeseItemShop11 = 1653750,
        //[Description("Meese Item Shop 1 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MeeseItemShop12 = 1663958,
        //[Description("Meese Item Shop 1 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MeeseItemShop1NPCs1 = 1668694,
        //[Description("Meese Item Shop 1 NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MeeseItemShop1NPCs2 = 1185280,
        //[Description("Meese Weapon Shop 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MeeseWeaponShop1 = 1653750,
        //[Description("Meese Weapon Shop 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MeeseWeaponShop2 = 1663958,
        //[Description("Meese Weapon Shop NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MeeseWeaponShopNPCs1 = 1668694,
        //[Description("Meese Weapon Shop NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MeeseWeaponShopNPCs2 = 1264070,
        //[Description("Meese Weapon Shop NPCs 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MeeseWeaponShopNPCs3 = 1235908,
        //[Description("Meese Inn 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MeeseInn1 = 1653750,
        //[Description("Meese Inn 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MeeseInn2 = 1663958,
        //[Description("Meese Inn NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MeeseInnNPCs1 = 1668694,
        //[Description("Meese Inn NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MeeseInnNPCs2 = 1183116,
        //[Description("Meese Inn NPCs 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MeeseInnNPCs3 = 1264070,
        //[Description("Meese Inn NPCs 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MeeseInnNPCs4 = 1187500,
        //[Description("Meese Inn NPCs 5")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MeeseInnNPCs5 = 1242644,
        //[Description("Meese Clinic 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MeeseClinic1 = 1653750,
        //[Description("Meese Clinic 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MeeseClinic2 = 1663958,
        //[Description("Meese Clinic NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MeeseClinicNPCs1 = 1668694,
        //[Description("Meese Clinic NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MeeseClinicNPCs2 = 1187500,
        //[Description("Meese Clinic NPCs 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MeeseClinicNPCs3 = 1182060,
        //[Description("Meese Clinic NPCs 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MeeseClinicNPCs4 = 1697574,
        //[Description("Meese Clinic NPCs 5")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MeeseClinicNPCs5 = 1698784,
        //[Description("Meese Clinic NPCs 6")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MeeseClinicNPCs6 = 1183116,
        //[Description("Meese Clinic NPCs 7")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MeeseClinicNPCs7 = 1184138,
        //[Description("Meese Clinic NPCs 8")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MeeseClinicNPCs8 = 1700036,
        //[Description("Meese Clinic NPCs 9")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MeeseClinicNPCs9 = 1391374,
        //[Description("Meese Clinic F1 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MeeseClinicF11 = 1653750,
        //[Description("Meese Clinic F1 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MeeseClinicF12 = 1663958,
        //[Description("Meese Clinic F1 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MeeseClinicF1NPCs1 = 1698784,
        //[Description("Meese Clinic F1 NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MeeseClinicF1NPCs2 = 1697574,
        //[Description("Meese Clinic F1 NPCs 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MeeseClinicF1NPCs3 = 1700772,
        //[Description("Jut 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Jut1 = 1634762,
        //[Description("Jut 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Jut2 = 1701646,
        //[Description("Jut NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //JutNPCs1 = 1644426,
        //[Description("Jut NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //JutNPCs2 = 1678528,
        //[Description("Jut NPCs 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //JutNPCs3 = 1679818,
        //[Description("Jut House 1 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //JutHouse11 = 1653750,
        //[Description("Jut House 1 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //JutHouse12 = 1663958,
        //[Description("Jut House 1 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //JutHouse1NPCs1 = 1668694,
        //[Description("Jut House 1 NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //JutHouse1NPCs2 = 1678528,
        //[Description("Jut House 2 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //JutHouse21 = 1653750,
        //[Description("Jut House 2 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //JutHouse22 = 1663958,
        //[Description("Jut House 2 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //JutHouse2NPCs1 = 1668694,
        //[Description("Jut House 2 NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //JutHouse2NPCs2 = 1678528,
        //[Description("Jut House 3 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //JutHouse31 = 1653750,
        //[Description("Jut House 3 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //JutHouse32 = 1663958,
        //[Description("Jut House 3 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //JutHouse3NPCs1 = 1668694,
        //[Description("Jut House 3 NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //JutHouse3NPCs2 = 1668102,
        //[Description("Jut House 3 NPCs 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //JutHouse3NPCs3 = 1678528,
        //[Description("Jut House 3 NPCs 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //JutHouse3NPCs4 = 1679818,
        //[Description("Jut House 4 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //JutHouse41 = 1653750,
        //[Description("Jut House 4 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //JutHouse42 = 1663958,
        //[Description("Jut House 4 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //JutHouse4NPCs1 = 1668694,
        //[Description("Jut House 4 NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //JutHouse4NPCs2 = 1678528,
        //[Description("Jut House 4 NPCs 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //JutHouse4NPCs3 = 1679818,
        //[Description("Jut House 5 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //JutHouse51 = 1653750,
        //[Description("Jut House 5 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //JutHouse52 = 1663958,
        //[Description("Jut House 5 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //JutHouse5NPCs1 = 1668694,
        //[Description("Jut House 5 NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //JutHouse5NPCs2 = 1679818,
        //[Description("Jut Weapon Shop 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //JutWeaponShop1 = 1653750,
        //[Description("Jut Weapon Shop 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //JutWeaponShop2 = 1663958,
        //[Description("Jut Weapon Shop NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //JutWeaponShopNPCs1 = 1668694,
        //[Description("Jut Weapon Shop NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //JutWeaponShopNPCs2 = 1679818,
        //[Description("Jut Weapon Shop NPCs 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //JutWeaponShopNPCs3 = 1678528,
        //[Description("Jut Item Shop 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //JutItemShop1 = 1653750,
        //[Description("Jut Item Shop 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //JutItemShop2 = 1663958,
        //[Description("Jut Item Shop NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //JutItemShopNPCs1 = 1668694,
        //[Description("Jut Item Shop NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //JutItemShopNPCs2 = 1678528,
        //[Description("Jut Item Shop NPCs 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //JutItemShopNPCs3 = 1679818,
        //[Description("Jut House 6 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //JutHouse61 = 1653750,
        //[Description("Jut House 6 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //JutHouse62 = 1663958,
        //[Description("Jut House 6 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //JutHouse6NPCs1 = 1668694,
        //[Description("Jut House 6 NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //JutHouse6NPCs2 = 1679818,
        //[Description("Jut House6 F1 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //JutHouse6F11 = 1653750,
        //[Description("Jut House6 F1 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //JutHouse6F12 = 1663958,
        //[Description("Jut House6 F1 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //JutHouse6F1NPCs1 = 1678528,
        //[Description("Jut House 7 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //JutHouse71 = 1653750,
        //[Description("Jut House 7 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //JutHouse72 = 1663958,
        //[Description("Jut House 7 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //JutHouse7NPCs1 = 1668694,
        //[Description("Jut House 7 NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //JutHouse7NPCs2 = 1679818,
        //[Description("Jut House 7 NPCs 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //JutHouse7NPCs3 = 1678528,
        //[Description("Jut House 8 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //JutHouse81 = 1653750,
        //[Description("Jut House 8 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //JutHouse82 = 1663958,
        //[Description("Jut House 8 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //JutHouse8NPCs1 = 1668694,
        //[Description("Jut House 8 NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //JutHouse8NPCs2 = 1678528,
        //[Description("Jut Inn 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //JutInn1 = 1653750,
        //[Description("Jut Inn 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //JutInn2 = 1663958,
        //[Description("Jut Inn NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //JutInnNPCs1 = 1668694,
        //[Description("Jut Inn NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //JutInnNPCs2 = 1679818,
        //[Description("Jut Church 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //JutChurch1 = 1715976,
        //[Description("Jut Church 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //JutChurch2 = 1725448,
        //[Description("Jut Church NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //JutChurchNPCs1 = 1728312,
        //[Description("Jut Church NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //JutChurchNPCs2 = 1678528,
        //[Description("Jut Church NPCs 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //JutChurchNPCs3 = 1679818,
        //[Description("Ryuon 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Ryuon1 = 1634762,
        //[Description("Ryuon 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Ryuon2 = 1735022,
        //[Description("Ryuon NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //RyuonNPCs1 = 1644426,
        //[Description("Ryuon NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //RyuonNPCs2 = 1678528,
        //[Description("Ryuon NPCs 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //RyuonNPCs3 = 1679818,
        //[Description("Ryuon NPCs 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //RyuonNPCs4 = 1737294,
        //[Description("Ryuon Item Shop 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //RyuonItemShop1 = 1653750,
        //[Description("Ryuon Item Shop 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //RyuonItemShop2 = 1663958,
        //[Description("Ryuon Item Shop NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //RyuonItemShopNPCs1 = 1668694,
        //[Description("Ryuon Item Shop NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //RyuonItemShopNPCs2 = 1679818,
        //[Description("Ryuon Weapon Shop 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //RyuonWeaponShop1 = 1653750,
        //[Description("Ryuon Weapon Shop 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //RyuonWeaponShop2 = 1663958,
        //[Description("Ryuon Weapon Shop NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //RyuonWeaponShopNPCs1 = 1668694,
        //[Description("Ryuon Weapon Shop NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //RyuonWeaponShopNPCs2 = 1678528,
        //[Description("Ryuon House 1 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //RyuonHouse11 = 1653750,
        //[Description("Ryuon House 1 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //RyuonHouse12 = 1663958,
        //[Description("Ryuon House 1 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //RyuonHouse1NPCs1 = 1668694,
        //[Description("Ryuon House 1 NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //RyuonHouse1NPCs2 = 1679818,
        //[Description("Ryuon House 2 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //RyuonHouse21 = 1653750,
        //[Description("Ryuon House 2 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //RyuonHouse22 = 1663958,
        //[Description("Ryuon House 2 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //RyuonHouse2NPCs1 = 1668694,
        //[Description("Ryuon House 2 NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //RyuonHouse2NPCs2 = 1668102,
        //[Description("Ryuon House 2 NPCs 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //RyuonHouse2NPCs3 = 1679818,
        //[Description("Ryuon House 3 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //RyuonHouse31 = 1653750,
        //[Description("Ryuon House 3 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //RyuonHouse32 = 1663958,
        //[Description("Ryuon House 3 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //RyuonHouse3NPCs1 = 1668694,
        //[Description("Ryuon House 3 NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //RyuonHouse3NPCs2 = 1678528,
        //[Description("Ryuon Pub 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //RyuonPub1 = 1653750,
        //[Description("Ryuon Pub 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //RyuonPub2 = 1663958,
        //[Description("Ryuon Pub NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //RyuonPubNPCs1 = 1668694,
        //[Description("Ryuon Pub NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //RyuonPubNPCs2 = 1668102,
        //[Description("Ryuon Pub NPCs 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //RyuonPubNPCs3 = 1678528,
        //[Description("Ryuon Pub NPCs 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //RyuonPubNPCs4 = 1742338,
        //[Description("Ryuon Inn 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //RyuonInn1 = 1653750,
        //[Description("Ryuon Inn 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //RyuonInn2 = 1663958,
        //[Description("Ryuon Inn NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //RyuonInnNPCs1 = 1668694,
        //[Description("Ryuon Inn NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //RyuonInnNPCs2 = 1678528,
        //[Description("Raja Temple 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //RajaTemple1 = 1743502,
        //[Description("Raja Temple NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //RajaTempleNPCs1 = 1751278,
        //[Description("Reshel 1 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Reshel11 = 1634762,
        //[Description("Reshel 1 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Reshel12 = 1755134,
        //[Description("Reshel 2 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Reshel21 = 1634762,
        //[Description("Reshel 2 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Reshel22 = 1755134,
        //[Description("Reshel 2 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //Reshel2NPCs1 = 1648528,
        //[Description("Reshel 2 NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //Reshel2NPCs2 = 1690996,
        //[Description("Reshel 3 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Reshel31 = 1634762,
        //[Description("Reshel 3 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Reshel32 = 1755134,
        //[Description("Reshel 3 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //Reshel3NPCs1 = 1644426,
        //[Description("Reshel 3 NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //Reshel3NPCs2 = 1648528,
        //[Description("Reshel 3 NPCs 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //Reshel3NPCs3 = 1690996,
        //[Description("Reshel 3 NPCs 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //Reshel3NPCs4 = 1649708,
        //[Description("Reshel 2 House 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Reshel2House1 = 1653750,
        //[Description("Reshel 2 House 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Reshel2House2 = 1663958,
        //[Description("Reshel 2 House NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //Reshel2HouseNPCs1 = 1668694,
        //[Description("Reshel 2 House NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //Reshel2HouseNPCs2 = 1287234,
        //[Description("Reshel 2 Weapon Shop 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Reshel2WeaponShop1 = 1653750,
        //[Description("Reshel 2 Weapon Shop 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Reshel2WeaponShop2 = 1663958,
        //[Description("Reshel 2 Weapon Shop NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //Reshel2WeaponShopNPCs1 = 1183116,
        //[Description("Reshel 2 Weapon Shop NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //Reshel2WeaponShopNPCs2 = 1242644,
        //[Description("Reshel 3 House 1 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Reshel3House11 = 1653750,
        //[Description("Reshel 3 House 1 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Reshel3House12 = 1663958,
        //[Description("Reshel 3 House 1 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //Reshel3House1NPCs1 = 1668694,
        //[Description("Reshel 3 House 1 NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //Reshel3House1NPCs2 = 1287234,
        //[Description("Reshel3Item Shop 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Reshel3ItemShop1 = 1653750,
        //[Description("Reshel3Item Shop 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Reshel3ItemShop2 = 1663958,
        //[Description("Reshel3Item Shop NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //Reshel3ItemShopNPCs1 = 1668694,
        //[Description("Reshel3Item Shop NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //Reshel3ItemShopNPCs2 = 1183116,
        //[Description("Reshel 3 House 2 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Reshel3House21 = 1653750,
        //[Description("Reshel 3 House 2 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Reshel3House22 = 1663958,
        //[Description("Reshel 3 House 2 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //Reshel3House2NPCs1 = 1668694,
        //[Description("Reshel 3 House 2 NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //Reshel3House2NPCs2 = 1242644,
        //[Description("Reshel 3 House 2 NPCs 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //Reshel3House2NPCs3 = 1244208,
        //[Description("Reshel 3 Weapon Shop 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Reshel3WeaponShop1 = 1653750,
        //[Description("Reshel 3 Weapon Shop 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Reshel3WeaponShop2 = 1663958,
        //[Description("Reshel 3 Weapon Shop NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //Reshel3WeaponShopNPCs1 = 1183116,
        //[Description("Reshel 3 Weapon Shop NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //Reshel3WeaponShopNPCs2 = 1242644,
        //[Description("Reshel 3 Inn 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Reshel3Inn1 = 1653750,
        //[Description("Reshel 3 Inn 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Reshel3Inn2 = 1663958,
        //[Description("Reshel 3 Inn NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //Reshel3InnNPCs1 = 1668694,
        //[Description("Reshel 3 Inn NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //Reshel3InnNPCs2 = 1235908,
        //[Description("Reshel 3 House 3 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Reshel3House31 = 1653750,
        //[Description("Reshel 3 House 3 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Reshel3House32 = 1663958,
        //[Description("Reshel 3 House 3 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //Reshel3House3NPCs1 = 1668694,
        //[Description("Reshel 3 House 3 NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //Reshel3House3NPCs2 = 1183116,
        //[Description("Reshel 3 House 3 NPCs 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //Reshel3House3NPCs3 = 1184138,
        //[Description("Myst Vale 1 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MystVale11 = 1462116,
        //[Description("Myst Vale 1 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MystVale12 = 1466964,
        //[Description("Myst Vale 1 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MystVale13 = 1764702,
        //[Description("Myst Vale 2 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MystVale21 = 1462116,
        //[Description("Myst Vale 2 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MystVale22 = 1466964,
        //[Description("Myst Vale 2 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MystVale23 = 1764702,
        //[Description("Myst Vale 2 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MystVale2NPCs1 = 1769922,
        //[Description("Myst Vale 3 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MystVale31 = 1462116,
        //[Description("Myst Vale 3 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MystVale32 = 1466964,
        //[Description("Myst Vale 3 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MystVale33 = 1764702,
        //[Description("Myst Vale 4 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MystVale41 = 1462116,
        //[Description("Myst Vale 4 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MystVale42 = 1466964,
        //[Description("Myst Vale 4 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MystVale43 = 1764702,
        //[Description("Myst Vale 4 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MystVale4NPCs1 = 1769922,
        //[Description("Myst Vale 5 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MystVale51 = 1462116,
        //[Description("Myst Vale 5 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MystVale52 = 1466964,
        //[Description("Myst Vale 5 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //MystVale53 = 1764702,
        //[Description("Myst Vale 5 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MystVale5NPCs1 = 1769922,
        //[Description("Myst Vale 5 NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //MystVale5NPCs2 = 1771862,
        //[Description("Elsydeon Cave 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ElsydeonCave1 = 1462116,
        //[Description("Elsydeon Cave 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ElsydeonCave2 = 1466964,
        //[Description("Elsydeon Cave 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ElsydeonCave3 = 1764702,
        //[Description("Elsydeon Cave B1 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ElsydeonCaveB11 = 1462116,
        //[Description("Elsydeon Cave B1 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ElsydeonCaveB12 = 1466964,
        //[Description("Elsydeon Cave B1 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ElsydeonCaveB13 = 1764702,
        //[Description("Hangar 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Hangar1 = 1462116,
        //[Description("Hangar 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Hangar2 = 1466964,
        //[Description("Hangar 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Hangar3 = 1764702,
        //[Description("Gumbious Entrance 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //GumbiousEntrance1 = 1715976,
        //[Description("Gumbious Entrance 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //GumbiousEntrance2 = 1725448,
        //[Description("Gumbious 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Gumbious1 = 1715976,
        //[Description("Gumbious 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Gumbious2 = 1725448,
        //[Description("Gumbious NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //GumbiousNPCs1 = 1751278,
        //[Description("Gumbious NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //GumbiousNPCs2 = 1678528,
        //[Description("Gumbious NPCs 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //GumbiousNPCs3 = 1679818,
        //[Description("Gumbious F1 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //GumbiousF11 = 1715976,
        //[Description("Gumbious F1 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //GumbiousF12 = 1725448,
        //[Description("Gumbious F1 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //GumbiousF1NPCs1 = 1776584,
        //[Description("Gumbious F1 NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //GumbiousF1NPCs2 = 1678528,
        //[Description("Gumbious F1 NPCs 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //GumbiousF1NPCs3 = 1751278,
        //[Description("Gumbious F1 NPCs 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //GumbiousF1NPCs4 = 1728312,
        //[Description("Gumbious B1 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //GumbiousB11 = 1715976,
        //[Description("Gumbious B1 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //GumbiousB12 = 1725448,
        //[Description("Gumbious B1 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //GumbiousB1NPCs1 = 1751278,
        //[Description("Gumbious B2 1 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //GumbiousB211 = 1715976,
        //[Description("Gumbious B2 1 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //GumbiousB212 = 1725448,
        //[Description("Gumbious B2 2 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //GumbiousB221 = 1715976,
        //[Description("Gumbious B2 2 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //GumbiousB222 = 1725448,
        //[Description("Gumbious B2 2 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //GumbiousB22NPCs1 = 1751278,
        //[Description("Gumbious B2 2 NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //GumbiousB22NPCs2 = 1728312,
        //[Description("Gumbious B2 2 NPCs 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //GumbiousB22NPCs3 = 1779376,
        //[Description("Esp Mansion Entrance 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //EspMansionEntrance1 = 1779878,
        //[Description("Esp Mansion Entrance NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //EspMansionEntranceNPCs1 = 1697574,
        //[Description("Esp Mansion 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //EspMansion1 = 1779878,
        //[Description("Esp Mansion NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //EspMansionNPCs1 = 1791996,
        //[Description("Esp Mansion NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //EspMansionNPCs2 = 1793194,
        //[Description("Esp Mansion NPCs 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //EspMansionNPCs3 = 1794432,
        //[Description("Esp Mansion West Room 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //EspMansionWestRoom1 = 1779878,
        //[Description("Esp Mansion West Room NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //EspMansionWestRoomNPCs1 = 1796336,
        //[Description("Esp Mansion East Room 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //EspMansionEastRoom1 = 1779878,
        //[Description("Esp Mansion North 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //EspMansionNorth1 = 1779878,
        //[Description("Esp Mansion North NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //EspMansionNorthNPCs1 = 1791996,
        //[Description("Esp Mansion North NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //EspMansionNorthNPCs2 = 1797410,
        //[Description("Esp Mansion North NPCs 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //EspMansionNorthNPCs3 = 1697574,
        //[Description("Esp Mansion North East Room 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //EspMansionNorthEastRoom1 = 1779878,
        //[Description("Esp Mansion North East Room NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //EspMansionNorthEastRoomNPCs1 = 1793194,
        //[Description("Esp Mansion North West Room 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //EspMansionNorthWestRoom1 = 1779878,
        //[Description("Esp Mansion North West Room NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //EspMansionNorthWestRoomNPCs1 = 1794432,
        //[Description("Esp Mansion North West Room NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //EspMansionNorthWestRoomNPCs2 = 1797410,
        //[Description("Esp Mansion Courtyard 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //EspMansionCourtyard1 = 1779878,
        //[Description("Esp Mansion Courtyard NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //EspMansionCourtyardNPCs1 = 1697574,
        //[Description("Inner Sanctuary 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //InnerSanctuary1 = 1779878,
        //[Description("Inner Sanctuary NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //InnerSanctuaryNPCs1 = 1800560,
        //[Description("Inner Sanctuary B1 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //InnerSanctuaryB11 = 1779878,
        //[Description("Inner Sanctuary B1 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //InnerSanctuaryB1NPCs1 = 1800560,
        //[Description("Inner Sanctuary B1 NPCs 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //InnerSanctuaryB1NPCs2 = 1801520,
        //[Description("Air Castle 6 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastle61 = 1802172,
        //[Description("Air Castle 6 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastle62 = 1811628,
        //[Description("Air Castle 6 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastle63 = 1812188,
        //[Description("Air Castle 1 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastle11 = 1802172,
        //[Description("Air Castle 1 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastle12 = 1811628,
        //[Description("Air Castle 1 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastle13 = 1812188,
        //[Description("Air Castle 2 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastle21 = 1802172,
        //[Description("Air Castle 2 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastle22 = 1811628,
        //[Description("Air Castle 2 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastle23 = 1812188,
        //[Description("Air Castle 3 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastle31 = 1802172,
        //[Description("Air Castle 3 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastle32 = 1811628,
        //[Description("Air Castle 3 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastle33 = 1812188,
        //[Description("Air Castle 3 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //AirCastle3NPCs1 = 1776902,
        //[Description("Air Castle 4 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastle41 = 1802172,
        //[Description("Air Castle 4 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastle42 = 1811628,
        //[Description("Air Castle 4 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastle43 = 1812188,
        //[Description("Air Castle 5 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastle51 = 1802172,
        //[Description("Air Castle 5 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastle52 = 1811628,
        //[Description("Air Castle 5 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastle53 = 1812188,
        //[Description("Air Castle F1 9 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastleF191 = 1802172,
        //[Description("Air Castle F1 9 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastleF192 = 1811628,
        //[Description("Air Castle F1 9 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastleF193 = 1812188,
        //[Description("Air Castle F1 5 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastleF151 = 1802172,
        //[Description("Air Castle F1 5 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastleF152 = 1811628,
        //[Description("Air Castle F1 5 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastleF153 = 1812188,
        //[Description("Air Castle F1 2 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastleF121 = 1802172,
        //[Description("Air Castle F1 2 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastleF122 = 1811628,
        //[Description("Air Castle F1 2 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastleF123 = 1812188,
        //[Description("Air Castle F1 10 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastleF1101 = 1802172,
        //[Description("Air Castle F1 10 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastleF1102 = 1811628,
        //[Description("Air Castle F1 10 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastleF1103 = 1812188,
        //[Description("Air Castle F1 10 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //AirCastleF110NPCs1 = 1776902,
        //[Description("Air Castle Inner 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastleInner1 = 1802172,
        //[Description("Air Castle Inner 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastleInner2 = 1811628,
        //[Description("Air Castle Inner 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastleInner3 = 1812188,
        //[Description("Air Castle F1 11 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastleF1111 = 1802172,
        //[Description("Air Castle F1 11 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastleF1112 = 1811628,
        //[Description("Air Castle F1 11 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastleF1113 = 1812188,
        //[Description("Air Castle F1 12 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastleF1121 = 1802172,
        //[Description("Air Castle F1 12 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastleF1122 = 1811628,
        //[Description("Air Castle F1 12 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastleF1123 = 1812188,
        //[Description("Air Castle F1 13 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastleF1131 = 1802172,
        //[Description("Air Castle F1 13 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastleF1132 = 1811628,
        //[Description("Air Castle F1 13 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastleF1133 = 1812188,
        //[Description("Air Castle 8 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastle81 = 1802172,
        //[Description("Air Castle 8 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastle82 = 1811628,
        //[Description("Air Castle 8 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastle83 = 1812188,
        //[Description("Air Castle 7 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastle71 = 1802172,
        //[Description("Air Castle 7 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastle72 = 1811628,
        //[Description("Air Castle 7 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastle73 = 1812188,
        //[Description("Air Castle F1 4 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastleF141 = 1802172,
        //[Description("Air Castle F1 4 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastleF142 = 1811628,
        //[Description("Air Castle F1 4 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastleF143 = 1812188,
        //[Description("Air Castle F1 1 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastleF111 = 1802172,
        //[Description("Air Castle F1 1 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastleF112 = 1811628,
        //[Description("Air Castle F1 1 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastleF113 = 1812188,
        //[Description("Air Castle F1 3 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastleF131 = 1802172,
        //[Description("Air Castle F1 3 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastleF132 = 1811628,
        //[Description("Air Castle F1 3 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastleF133 = 1812188,
        //[Description("Air Castle F2 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastleF21 = 1802172,
        //[Description("Air Castle F2 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastleF22 = 1811628,
        //[Description("Air Castle F2 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastleF23 = 1812188,
        //[Description("Air Castle Boss Room 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastleBossRoom1 = 1802172,
        //[Description("Air Castle Boss Room 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastleBossRoom2 = 1811628,
        //[Description("Air Castle Boss Room 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastleBossRoom3 = 1812188,
        //[Description("Air Castle Boss Room NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //AirCastleBossRoomNPCs1 = 1776902,
        //[Description("Air Castle Inner B1 1 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastleInnerB111 = 1802172,
        //[Description("Air Castle Inner B1 1 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastleInnerB112 = 1811628,
        //[Description("Air Castle Inner B1 1 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastleInnerB113 = 1812188,
        //[Description("Air Castle Inner B1 2 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastleInnerB121 = 1802172,
        //[Description("Air Castle Inner B1 2 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastleInnerB122 = 1811628,
        //[Description("Air Castle Inner B1 2 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastleInnerB123 = 1812188,
        //[Description("Air Castle Inner B1 3 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastleInnerB131 = 1802172,
        //[Description("Air Castle Inner B1 3 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastleInnerB132 = 1811628,
        //[Description("Air Castle Inner B1 3 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastleInnerB133 = 1812188,
        //[Description("Air Castle Inner B2 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastleInnerB21 = 1802172,
        //[Description("Air Castle Inner B2 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastleInnerB22 = 1811628,
        //[Description("Air Castle Inner B2 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastleInnerB23 = 1812188,
        //[Description("Air Castle Inner B3 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastleInnerB31 = 1802172,
        //[Description("Air Castle Inner B3 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastleInnerB32 = 1811628,
        //[Description("Air Castle Inner B3 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastleInnerB33 = 1812188,
        //[Description("Air Castle Inner B4 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastleInnerB41 = 1802172,
        //[Description("Air Castle Inner B4 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastleInnerB42 = 1811628,
        //[Description("Air Castle Inner B4 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastleInnerB43 = 1812188,
        //[Description("Air Castle Inner B5 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastleInnerB51 = 1802172,
        //[Description("Air Castle Inner B5 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastleInnerB52 = 1811628,
        //[Description("Air Castle Inner B5 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastleInnerB53 = 1812188,
        //[Description("Zelan Space 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZelanSpace1 = 1839530,
        //[Description("Zelan Space 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZelanSpace2 = 1812188,
        //[Description("Zelan 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Zelan1 = 1497994,
        //[Description("Zelan 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Zelan2 = 1504506,
        //[Description("Zelan 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Zelan3 = 1515572,
        //[Description("Zelan 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Zelan4 = 1555138,
        //[Description("Zelan 5")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Zelan5 = 1842412,
        //[Description("Zelan 6")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Zelan6 = 1812188,
        //[Description("Zelan F1 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZelanF11 = 1497994,
        //[Description("Zelan F1 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZelanF12 = 1504506,
        //[Description("Zelan F1 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZelanF13 = 1515572,
        //[Description("Zelan F1 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZelanF14 = 1555138,
        //[Description("Zelan F1 5")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZelanF15 = 1842412,
        //[Description("Zelan F1 6")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //ZelanF16 = 1812188,
        //[Description("Kuran Space 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KuranSpace1 = 1839530,
        //[Description("Kuran Space 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KuranSpace2 = 1812188,
        //[Description("Kuran 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Kuran1 = 1497994,
        //[Description("Kuran 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Kuran2 = 1504506,
        //[Description("Kuran 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Kuran3 = 1515572,
        //[Description("Kuran 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Kuran4 = 1555138,
        //[Description("Kuran 5")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Kuran5 = 1842412,
        //[Description("Kuran 6")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //Kuran6 = 1812188,
        //[Description("Kuran F1 1 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KuranF111 = 1497994,
        //[Description("Kuran F1 1 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KuranF112 = 1504506,
        //[Description("Kuran F1 1 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KuranF113 = 1515572,
        //[Description("Kuran F1 1 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KuranF114 = 1555138,
        //[Description("Kuran F1 1 5")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KuranF115 = 1842412,
        //[Description("Kuran F1 1 6")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KuranF116 = 1812188,
        //[Description("Kuran F2 1 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KuranF211 = 1497994,
        //[Description("Kuran F2 1 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KuranF212 = 1504506,
        //[Description("Kuran F2 1 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KuranF213 = 1515572,
        //[Description("Kuran F2 1 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KuranF214 = 1555138,
        //[Description("Kuran F2 1 5")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KuranF215 = 1842412,
        //[Description("Kuran F2 1 6")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KuranF216 = 1812188,
        //[Description("Kuran F1 2 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KuranF121 = 1497994,
        //[Description("Kuran F1 2 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KuranF122 = 1504506,
        //[Description("Kuran F1 2 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KuranF123 = 1515572,
        //[Description("Kuran F1 2 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KuranF124 = 1555138,
        //[Description("Kuran F1 2 5")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KuranF125 = 1842412,
        //[Description("Kuran F1 2 6")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KuranF126 = 1812188,
        //[Description("Kuran F1 3 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KuranF131 = 1497994,
        //[Description("Kuran F1 3 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KuranF132 = 1504506,
        //[Description("Kuran F1 3 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KuranF133 = 1515572,
        //[Description("Kuran F1 3 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KuranF134 = 1555138,
        //[Description("Kuran F1 3 5")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KuranF135 = 1842412,
        //[Description("Kuran F1 3 6")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KuranF136 = 1812188,
        //[Description("Kuran F1 5 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KuranF151 = 1497994,
        //[Description("Kuran F1 5 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KuranF152 = 1504506,
        //[Description("Kuran F1 5 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KuranF153 = 1515572,
        //[Description("Kuran F1 5 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KuranF154 = 1555138,
        //[Description("Kuran F1 5 5")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KuranF155 = 1842412,
        //[Description("Kuran F1 5 6")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KuranF156 = 1812188,
        //[Description("Kuran F2 2 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KuranF221 = 1497994,
        //[Description("Kuran F2 2 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KuranF222 = 1504506,
        //[Description("Kuran F2 2 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KuranF223 = 1515572,
        //[Description("Kuran F2 2 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KuranF224 = 1555138,
        //[Description("Kuran F2 2 5")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KuranF225 = 1842412,
        //[Description("Kuran F2 2 6")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KuranF226 = 1812188,
        //[Description("Kuran F1 4 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KuranF141 = 1497994,
        //[Description("Kuran F1 4 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KuranF142 = 1504506,
        //[Description("Kuran F1 4 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KuranF143 = 1515572,
        //[Description("Kuran F1 4 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KuranF144 = 1555138,
        //[Description("Kuran F1 4 5")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KuranF145 = 1842412,
        //[Description("Kuran F1 4 6")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KuranF146 = 1812188,
        //[Description("Kuran F3 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KuranF31 = 1497994,
        //[Description("Kuran F3 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KuranF32 = 1504506,
        //[Description("Kuran F3 3")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KuranF33 = 1515572,
        //[Description("Kuran F3 4")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KuranF34 = 1555138,
        //[Description("Kuran F3 5")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KuranF35 = 1842412,
        //[Description("Kuran F3 6")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //KuranF36 = 1812188,
        //[Description("Kuran F3 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //KuranF3NPCs1 = 1852260,
        //[Description("Garuberk Tower 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //GaruberkTower1 = 1853920,
        //[Description("Garuberk Tower 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //GaruberkTower2 = 1864800,
        //[Description("Garuberk Tower 2 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //GaruberkTower21 = 1853920,
        //[Description("Garuberk Tower 2 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //GaruberkTower22 = 1864800,
        //[Description("Garuberk Tower 3 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //GaruberkTower31 = 1853920,
        //[Description("Garuberk Tower 3 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //GaruberkTower32 = 1864800,
        //[Description("Garuberk Tower 4 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //GaruberkTower41 = 1853920,
        //[Description("Garuberk Tower 4 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //GaruberkTower42 = 1864800,
        //[Description("Garuberk Tower 5 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //GaruberkTower51 = 1853920,
        //[Description("Garuberk Tower 5 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //GaruberkTower52 = 1864800,
        //[Description("Garuberk Tower 6 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //GaruberkTower61 = 1853920,
        //[Description("Garuberk Tower 6 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //GaruberkTower62 = 1864800,
        //[Description("Garuberk Tower 7 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //GaruberkTower71 = 1853920,
        //[Description("Garuberk Tower 7 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //GaruberkTower72 = 1864800,
        //[Description("Garuberk Tower 7 NPCs 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.NPCs)]
        //[Compression(CompressionType.Nemesis)]
        //GaruberkTower7NPCs1 = 1878142,
        //[Description("Air Castle Space 1")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastleSpace1 = 1880090,
        //[Description("Air Castle Space 2")]
        //[Bytes(0)]
        //[Section(SectionType.Field)]
        //[SubSection(SubSectionType.Map)]
        //[Compression(CompressionType.Kosinski)]
        //AirCastleSpace2 = 1812188,
        [Description("PSIV Title Intro 1")]
        [Length(2608)]
        [Section(SectionType.CutScene)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        PSIVTitleIntro1 = 1885306,
        [Description("Sub Title Intro 1")]
        [Length(1020)]
        [Section(SectionType.CutScene)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        SubTitleIntro1 = 1887914,
        [Description("Press Start Intro 1")]
        [Length(202)]
        [Section(SectionType.CutScene)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        PressStartIntro1 = 1888934,
        [Description("Copyright Intro 1")]
        [Length(242)]
        [Section(SectionType.CutScene)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        CopyrightIntro1 = 1889136,
        [Description("Background Intro 1")]
        [Length(7568)]
        [Section(SectionType.CutScene)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        BackgroundIntro1 = 1889378,
        [Description("Motavia Prologue 1")]
        [Length(5680)]
        [Section(SectionType.CutScene)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        MotaviaPrologue1 = 1896946,
        [Description("Asteroids Intro 1")]
        [Length(6260)]
        [Section(SectionType.CutScene)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        AsteroidsIntro1 = 1902626,
        [Description("Save Cursor Intro 1")]
        [Length(92)]
        [Section(SectionType.CutScene)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        SaveCursorIntro1 = 1908886,
        [Description("Shadow Saber 1")]
        [Length(464)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        ShadowSaber1 = 2097152,
        [Description("Shadow Saber 2")]
        [Length(1948)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        ShadowSaber2 = 2097646,
        [Description("Shadow Saber 3")]
        [Length(542)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        ShadowSaber3 = 2099594,
        [Description("Scorpirus 1")]
        [Length(382)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Scorpirus1 = 2100136,
        [Description("Scorpirus 2")]
        [Length(1662)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Scorpirus2 = 2100518,
        [Description("Scorpirus 3")]
        [Length(656)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Scorpirus3 = 2102240,
        [Description("Dark Marauder 1")]
        [Length(1432)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        DarkMarauder1 = 2103162,
        [Description("Dark Marauder 2")]
        [Length(204)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        DarkMarauder2 = 2104594,
        [Description("Dark Marauder 3")]
        [Length(3724)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        DarkMarauder3 = 2104846,
        [Description("Dark Marauder 4")]
        [Length(3724)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        DarkMarauder4 = 2108570,
        [Description("Abe Frog 1")]
        [Length(370)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        AbeFrog1 = 2109504,
        [Description("Abe Frog 2")]
        [Length(4070)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        AbeFrog2 = 2109874,
        [Description("Abe Frog 3")]
        [Length(1744)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        AbeFrog3 = 2113970,
        [Description("Sand Newt 1")]
        [Length(346)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        SandNewt1 = 2116010,
        [Description("Sand Newt 2")]
        [Length(1440)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        SandNewt2 = 2116356,
        [Description("Sand Newt 3")]
        [Length(2034)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        SandNewt3 = 2117826,
        [Description("Stone Heads 1")]
        [Length(482)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        StoneHeads1 = 2120086,
        [Description("Stone Heads 2")]
        [Length(226)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        StoneHeads2 = 2120568,
        [Description("Whistle 1")]
        [Length(264)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Whistle1 = 2120832,
        [Description("Whistle 2")]
        [Length(360)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Whistle2 = 2121096,
        [Description("Unknown 2121478")]
        [Length(532)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2121478 = 2121478,
        [Description("Unknown 2122010")]
        [Length(516)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2122010 = 2122010,
        [Description("Unknown 2122526")]
        [Length(994)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2122526 = 2122526,
        [Description("Unknown 2123520")]
        [Length(800)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2123520 = 2123520,
        [Description("Loader 1")]
        [Length(760)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Loader1 = 2124320,
        [Description("Loader 2")]
        [Length(180)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Loader2 = 2125080,
        [Description("Loader 3")]
        [Length(158)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Loader3 = 2125260,
        [Description("Loader 4")]
        [Length(1562)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Loader4 = 2125462,
        [Description("Warren 286 1")]
        [Length(526)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Warren2861 = 2127308,
        [Description("Warren 286 2")]
        [Length(118)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Warren2862 = 2127834,
        [Description("Warren 286 3")]
        [Length(662)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Warren2863 = 2127952,
        [Description("Warren 286 4")]
        [Length(144)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Warren2864 = 2128614,
        [Description("Arm Drone 1")]
        [Length(50)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        ArmDrone1 = 2128774,
        [Description("Arm Drone 2")]
        [Length(564)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        ArmDrone2 = 2128824,
        [Description("Arm Drone 3")]
        [Length(1624)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        ArmDrone3 = 2129388,
        [Description("Float Mine 1")]
        [Length(198)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        FloatMine1 = 2131046,
        [Description("Float Mine 2")]
        [Length(596)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        FloatMine2 = 2131244,
        [Description("Float Mine 3")]
        [Length(526)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        FloatMine3 = 2131840,
        [Description("C-Ray Tube 1")]
        [Length(598)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        CRayTube1 = 2132396,
        [Description("C-Ray Tube 2")]
        [Length(292)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        CRayTube2 = 2132994,
        [Description("C-Ray Tube 3")]
        [Length(424)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        CRayTube3 = 2133286,
        [Description("C-Ray Tube 4")]
        [Length(120)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        CRayTube4 = 2133710,
        [Description("C-Ray Tube 5")]
        [Length(476)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        CRayTube5 = 2133830,
        [Description("C-Ray Tube 6")]
        [Length(192)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        CRayTube6 = 2134306,
        [Description("Blob 1")]
        [Length(8)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Blob1 = 2134592,
        [Description("Blob 2")]
        [Length(942)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Blob2 = 2134600,
        [Description("Blob 3")]
        [Length(368)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Blob3 = 2135542,
        [Description("Blob 4")]
        [Length(1800)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Blob4 = 2135910,
        [Description("Meta Slug 1")]
        [Length(46)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        MetaSlug1 = 2137736,
        [Description("Meta Slug 2")]
        [Length(1490)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        MetaSlug2 = 2137782,
        [Description("Meta Slug 3")]
        [Length(1492)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        MetaSlug3 = 2139272,
        [Description("Crawler 1")]
        [Length(8)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Crawler1 = 2140826,
        [Description("Crawler 2")]
        [Length(1588)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Crawler2 = 2140834,
        [Description("Crawler 3")]
        [Length(852)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Crawler3 = 2142422,
        [Description("Life Deleter 1")]
        [Length(810)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        LifeDeleter1 = 2143292,
        [Description("Life Deleter 2")]
        [Length(154)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        LifeDeleter2 = 2144102,
        [Description("Life Deleter 3")]
        [Length(418)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        LifeDeleter3 = 2144256,
        [Description("Life Deleter 4")]
        [Length(1044)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        LifeDeleter4 = 2144674,
        [Description("Worker Pod 1")]
        [Length(256)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        WorkerPod1 = 2145772,
        [Description("Worker Pod 2")]
        [Length(668)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        WorkerPod2 = 2146028,
        [Description("Worker Pod 3")]
        [Length(994)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        WorkerPod3 = 2146696,
        [Description("Worker Pod 4")]
        [Length(622)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        WorkerPod4 = 2147690,
        [Description("Tarantella 1")]
        [Length(78)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Tarantella1 = 2148354,
        [Description("Tarantella 2")]
        [Length(936)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Tarantella2 = 2148432,
        [Description("Tarantella 3")]
        [Length(1684)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Tarantella3 = 2149368,
        [Description("Monster Fly 1")]
        [Length(34)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        MonsterFly1 = 2151078,
        [Description("Monster Fly 2")]
        [Length(808)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        MonsterFly2 = 2151112,
        [Description("Monster Fly 3")]
        [Length(396)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        MonsterFly3 = 2151920,
        [Description("Monster Fly 4")]
        [Length(212)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        MonsterFly4 = 2152316,
        [Description("Sensor Bit 1")]
        [Length(964)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        SensorBit1 = 2152620,
        [Description("Sensor Bit 2")]
        [Length(60)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        SensorBit2 = 2152560,
        [Description("Sensor Bit 3")]
        [Length(118)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        SensorBit3 = 2153584,
        [Description("Sensor Bit 4")]
        [Length(394)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        SensorBit4 = 2153702,
        [Description("Sensor Bit 5")]
        [Length(162)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        SensorBit5 = 2154096,
        [Description("Neo Whistle 1")]
        [Length(298)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        NeoWhistle1 = 2154292,
        [Description("Neo Whistle 2")]
        [Length(928)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        NeoWhistle2 = 2154590,
        [Description("Neo Whistle 3")]
        [Length(148)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        NeoWhistle3 = 2155518,
        [Description("Neo Whistle 4")]
        [Length(162)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        NeoWhistle4 = 2155666,
        [Description("Neo Whistle 5")]
        [Length(920)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        NeoWhistle5 = 2155828,
        [Description("Xanafalgue 1")]
        [Length(156)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Xanafalgue1 = 2156776,
        [Description("Xanafalgue 2")]
        [Length(678)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Xanafalgue2 = 2156932,
        [Description("Xanafalgue 3")]
        [Length(160)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Xanafalgue3 = 2157610,
        [Description("Zoran Bult 1")]
        [Length(88)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        ZoranBult1 = 2157800,
        [Description("Zoran Bult 2")]
        [Length(798)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        ZoranBult2 = 2157888,
        [Description("Zoran Bult 3")]
        [Length(378)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        ZoranBult3 = 2158686,
        [Description("Igglanova 1")]
        [Length(422)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Igglanova1 = 2159094,
        [Description("Igglanova 2")]
        [Length(3376)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Igglanova2 = 2159516,
        [Description("Igglanova 3")]
        [Length(616)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Igglanova3 = 2162892,
        [Description("Locusta 1")]
        [Length(1594)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Locusta1 = 2163558,
        [Description("Locusta 2")]
        [Length(992)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Locusta2 = 2165152,
        [Description("Locusta 3")]
        [Length(380)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Locusta3 = 2166144,
        [Description("Locusta 4")]
        [Length(1174)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Locusta4 = 2166524,
        [Description("Slave 1")]
        [Length(472)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Slave1 = 2167902,
        [Description("Slave 2")]
        [Length(1484)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Slave2 = 2168374,
        [Description("Slave 3")]
        [Length(352)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Slave3 = 2169858,
        [Description("Blauzen 1")]
        [Length(304)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Blauzen1 = 2170716,
        [Description("Blauzen 2")]
        [Length(1150)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Blauzen2 = 2171020,
        [Description("Blauzen 3")]
        [Length(432)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Blauzen3 = 2172212,
        [Description("Blauzen 4")]
        [Length(952)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Blauzen4 = 2172644,
        [Description("Blauzen 5")]
        [Length(378)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Blauzen5 = 2173596,
        [Description("Blauzen 6")]
        [Length(392)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Blauzen6 = 2173974,
        [Description("Blauzen 7")]
        [Length(284)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Blauzen7 = 2174366,
        [Description("Balduel 1")]
        [Length(134)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Balduel1 = 2174650,
        [Description("Balduel 2")]
        [Length(1132)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Balduel2 = 2174784,
        [Description("Balduel 3")]
        [Length(954)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Balduel3 = 2175916,
        [Description("Balduel 4")]
        [Length(156)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Balduel4 = 2176870,
        [Description("Balduel 5")]
        [Length(434)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Balduel5 = 2177026,
        [Description("Balduel 6")]
        [Length(264)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Balduel6 = 2177460,
        [Description("Haunt 1")]
        [Length(8)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Haunt1 = 2177780,
        [Description("Haunt 2")]
        [Length(1112)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Haunt2 = 2177814,
        [Description("Haunt 3")]
        [Length(84)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Haunt3 = 2178926,
        [Description("Haunt 4")]
        [Length(104)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Haunt4 = 2179010,
        [Description("Acacia 1")]
        [Length(158)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Acacia1 = 2179114,
        [Description("Acacia 2")]
        [Length(914)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Acacia2 = 2179318,
        [Description("Acacia 3")]
        [Length(308)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Acacia3 = 2180232,
        [Description("Acacia 4")]
        [Length(246)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Acacia4 = 2180540,
        [Description("Acacia 5")]
        [Length(492)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Acacia5 = 2180786,
        [Description("Speard 1")]
        [Length(498)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Speard1 = 2181278,
        [Description("Speard 2")]
        [Length(144)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Speard2 = 2181796,
        [Description("Technique User 1")]
        [Length(1066)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        TechniqueUser1 = 2181940,
        [Description("Technique User 2")]
        [Length(482)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        TechniqueUser2 = 2183006,
        [Description("Technique User 3")]
        [Length(392)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        TechniqueUser3 = 2183498,
        [Description("Technique User 4")]
        [Length(660)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        TechniqueUser4 = 2183890,
        [Description("Elmelew 1")]
        [Length(188)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Elmelew1 = 2184550,
        [Description("Elmelew 2")]
        [Length(1652)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Elmelew2 = 2184780,
        [Description("Elmelew 3")]
        [Length(454)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Elmelew3 = 2186432,
        [Description("Centaur 1")]
        [Length(1010)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Centaur1 = 2186886,
        [Description("Centaur 2")]
        [Length(146)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Centaur2 = 2187922,
        [Description("Centaur 3")]
        [Length(728)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Centaur3 = 2188068,
        [Description("Centaur 4")]
        [Length(204)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Centaur4 = 2188796,
        [Description("Centaur 5")]
        [Length(266)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Centaur5 = 2189000,
        [Description("Centaur 6")]
        [Length(484)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Centaur6 = 2189266,
        [Description("Centaur 7")]
        [Length(324)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Centaur7 = 2189750,
        [Description("Ismounos 1")]
        [Length(356)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Ismounos1 = 2190074,
        [Description("Ismounos 2")]
        [Length(1216)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Ismounos2 = 2190470,
        [Description("Ismounos 3")]
        [Length(386)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Ismounos3 = 2191686,
        [Description("Ismounos 4")]
        [Length(700)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Ismounos4 = 2192072,
        [Description("Ismounos 5")]
        [Length(1202)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Ismounos5 = 2192772,
        [Description("Soldier Fiend 1")]
        [Length(1392)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        SoldierFiend1 = 2193974,
        [Description("Soldier Fiend 2")]
        [Length(576)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        SoldierFiend2 = 2195396,
        [Description("Soldier Fiend 3")]
        [Length(500)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        SoldierFiend3 = 2195972,
        [Description("Soldier Fiend 4")]
        [Length(82)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        SoldierFiend4 = 2196472,
        [Description("Soldier Fiend 5")]
        [Length(534)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        SoldierFiend5 = 2196554,
        [Description("Soldier Fiend 6")]
        [Length(106)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        SoldierFiend6 = 2197088,
        [Description("Soldier Fiend 7")]
        [Length(314)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        SoldierFiend7 = 2197194,
        [Description("Piercer 1")]
        [Length(674)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Piercer1 = 2197508,
        [Description("Piercer 2")]
        [Length(410)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Piercer2 = 2198208,
        [Description("Piercer 3")]
        [Length(236)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Piercer3 = 2198618,
        [Description("Ripper 1")]
        [Length(670)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Ripper1 = 2198854,
        [Description("Ripper 2")]
        [Length(516)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Ripper2 = 2199524,
        [Description("Ripper 3")]
        [Length(1274)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Ripper3 = 2200064,
        [Description("Ripper 4")]
        [Length(278)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Ripper4 = 2201338,
        [Description("Ripper 5")]
        [Length(364)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Ripper5 = 2201616,
        [Description("Ripper 6")]
        [Length(304)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Ripper6 = 2201980,
        [Description("Sand Worm 1")]
        [Length(8)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        SandWorm1 = 2202284,
        [Description("Sand Worm 2")]
        [Length(3890)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        SandWorm2 = 2202292,
        [Description("Sand Worm 3")]
        [Length(666)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        SandWorm3 = 2206210,
        [Description("Sand Worm 4")]
        [Length(606)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        SandWorm4 = 2206876,
        [Description("Toadstool 1")]
        [Length(260)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Toadstool1 = 2207482,
        [Description("Toadstool 2")]
        [Length(1312)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Toadstool2 = 2207742,
        [Description("Toadstool 3")]
        [Length(742)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Toadstool3 = 2209076,
        [Description("Mini Worm 1")]
        [Length(8)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        MiniWorm1 = 2209818,
        [Description("Mini Worm 2")]
        [Length(1158)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        MiniWorm2 = 2209826,
        [Description("Mini Worm 3")]
        [Length(588)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        MiniWorm3 = 2210994,
        [Description("Mini Worm 4")]
        [Length(1428)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        MiniWorm4 = 2211582,
        [Description("Flatter Plant 1")]
        [Length(170)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        FlatterPlant1 = 2213010,
        [Description("Flatter Plant 2")]
        [Length(526)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        FlatterPlant2 = 2213180,
        [Description("Flatter Plant 3")]
        [Length(512)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        FlatterPlant3 = 2213744,
        [Description("Flatter Plant 4")]
        [Length(228)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        FlatterPlant4 = 2214256,
        [Description("Flatter Plant 5")]
        [Length(1076)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        FlatterPlant5 = 2214484,
        [Description("Flatter Plant 6")]
        [Length(82)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        FlatterPlant6 = 2215560,
        [Description("Dimension Worm 1")]
        [Length(8)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        DimensionWorm1 = 2215642,
        [Description("Dimension Worm 2")]
        [Length(454)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        DimensionWorm2 = 2215650,
        [Description("Dimension Worm 3")]
        [Length(1444)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        DimensionWorm3 = 2216114,
        [Description("Zio BG 1")]
        [Length(4096)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        ZioBG1 = 2217558,
        [Description("Zio 1")]
        [Length(1436)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Zio1 = 2221890,
        [Description("Zio 2")]
        [Length(128)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Zio2 = 2223440,
        [Description("Zio 3")]
        [Length(1512)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Zio3 = 2223568,
        [Description("Zio 4")]
        [Length(442)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Zio4 = 2225080,
        [Description("Zio 5")]
        [Length(354)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Zio5 = 2225522,
        [Description("Zio 6")]
        [Length(332)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Zio6 = 2225876,
        [Description("Zio 7")]
        [Length(1434)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Zio7 = 2226208,
        [Description("Zio 8")]
        [Length(154)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Zio8 = 2227642,
        [Description("King Rappy 1")]
        [Length(1294)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        KingRappy1 = 2227796,
        [Description("King Rappy 2")]
        [Length(500)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        KingRappy2 = 2229112,
        [Description("King Rappy 3")]
        [Length(5086)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        KingRappy3 = 2229612,
        [Description("Rappy 1")]
        [Length(8)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Rappy1 = 2234698,
        [Description("Rappy 2")]
        [Length(1622)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Rappy2 = 2234716,
        [Description("Rappy 3")]
        [Length(1658)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Rappy3 = 2236338,
        [Description("Rappy 4")]
        [Length(2020)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Rappy4 = 2237996,
        [Description("Prophallus 1")]
        [Length(13288)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Prophallus1 = 2240016,
        [Description("Prophallus 2")]
        [Length(80)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Prophallus2 = 2241396,
        [Description("Prophallus 3")]
        [Length(2978)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Prophallus3 = 2241476,
        [Description("Snow Mole 1")]
        [Length(218)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        SnowMole1 = 2244454,
        [Description("Snow Mole 2")]
        [Length(696)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        SnowMole2 = 2244700,
        [Description("Snow Mole 3")]
        [Length(650)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        SnowMole3 = 2245396,
        [Description("Snow Mole 4")]
        [Length(2250)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        SnowMole4 = 2246046,
        [Description("Snow Mole 5")]
        [Length(862)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        SnowMole5 = 2248296,
        [Description("Dezo Owl 1")]
        [Length(302)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        DezoOwl1 = 2249158,
        [Description("Dezo Owl 2")]
        [Length(154)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        DezoOwl2 = 2249494,
        [Description("Dezo Owl 3")]
        [Length(1942)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        DezoOwl3 = 2249648,
        [Description("Profound Darkness 3 1")]
        [Length(5308)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        ProfoundDarkness31 = 2251590,
        [Description("Profound Darkness 3 2")]
        [Length(3714)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        ProfoundDarkness32 = 2258098,
        [Description("Unknown 2264884")]
        [Length(2178)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2264884 = 2264884,
        [Description("Unknown 2267062")]
        [Length(934)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2267062 = 2267062,
        [Description("Unknown 2267996")]
        [Length(354)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2267996 = 2267996,
        [Description("Unknown 2268350")]
        [Length(614)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2268350 = 2268350,
        [Description("Unknown 2268964")]
        [Length(4030)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2268964 = 2268964,
        [Description("Unknown 2274194")]
        [Length(3078)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2274194 = 2274194,
        [Description("Unknown 2280344")]
        [Length(4398)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2280344 = 2280344,
        [Description("Unknown 2284742")]
        [Length(572)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2284742 = 2284742,
        [Description("Unknown 2285314")]
        [Length(3600)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2285314 = 2285314,
        [Description("Profound Darkness 1 1")]
        [Length(2646)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        ProfoundDarkness11 = 2289110,
        [Description("Unknown 2292428")]
        [Length(5484)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2292428 = 2292428,
        [Description("Unknown 2297912")]
        [Length(42)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2297912 = 2297912,
        [Description("Unknown 2297954")]
        [Length(2050)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2297954 = 2297954,
        [Description("Dark Force 3 1")]
        [Length(4414)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        DarkForce31 = 2300004,
        [Description("Dark Force 3 2")]
        [Length(1384)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        DarkForce32 = 2304524,
        [Description("Dark Force 3 3")]
        [Length(5010)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        DarkForce33 = 2305908,
        [Description("Dark Force 3 4")]
        [Length(70)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        DarkForce34 = 2310918,
        [Description("Dark Force 2 1")]
        [Length(3974)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        DarkForce21 = 2310988,
        [Description("Dark Force 2 2")]
        [Length(1170)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        DarkForce22 = 2315124,
        [Description("Dark Force 2 3")]
        [Length(224)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        DarkForce23 = 2316294,
        [Description("Dark Force 2 4")]
        [Length(1404)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        DarkForce24 = 2316518,
        [Description("Dark Force 2 5")]
        [Length(610)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        DarkForce25 = 2317922,
        [Description("Dark Force 2 6")]
        [Length(752)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        DarkForce26 = 2318532,
        [Description("Dark Force 1 1")]
        [Length(2824)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        DarkForce11 = 2319284,
        [Description("Dark Force 1 BG 1")]
        [Length(2330)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        DarkForce1BG1 = 2322304,
        [Description("Dark Force 1 2")]
        [Length(2710)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        DarkForce12 = 2325088,
        [Description("Dark Force 1 3")]
        [Length(2284)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        DarkForce13 = 2327798,
        [Description("Carnivorous Tree 1")]
        [Length(8)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        CarnivorousTree1 = 2330082,
        [Description("Carnivorous Tree BG 1")]
        [Length(4632)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        CarnivorousTreeBG1 = 2330116,
        [Description("Carnivorous Tree 2")]
        [Length(832)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        CarnivorousTree2 = 2335270,
        [Description("Unknown 2336102")]
        [Length(960)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2336102 = 2336102,
        [Description("Unknown 2337062")]
        [Length(532)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2337062 = 2337062,
        [Description("Unknown 2337594")]
        [Length(1058)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2337594 = 2337594,
        [Description("Unknown 2338730")]
        [Length(2560)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2338730 = 2338730,
        [Description("Unknown 2341290")]
        [Length(1032)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2341290 = 2341290,
        [Description("Unknown 2342322")]
        [Length(612)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2342322 = 2342322,
        [Description("Unknown 2342934")]
        [Length(1560)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2342934 = 2342934,
        [Description("Unknown 2344494")]
        [Length(242)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2344494 = 2344494,
        [Description("Unknown 2344736")]
        [Length(1402)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2344736 = 2344736,
        [Description("Unknown 2346138")]
        [Length(8)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2346138 = 2346138,
        [Description("Unknown 2346174")]
        [Length(1706)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2346174 = 2346174,
        [Description("Unknown 2347880")]
        [Length(8)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2347880 = 2347880,
        [Description("Unknown 2347908")]
        [Length(1380)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2347908 = 2347908,
        [Description("Unknown 2349288")]
        [Length(1876)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2349288 = 2349288,
        [Description("Unknown 2351164")]
        [Length(600)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2351164 = 2351164,
        [Description("Unknown 2351810")]
        [Length(750)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2351810 = 2351810,
        [Description("Unknown 2352560")]
        [Length(1870)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2352560 = 2352560,
        [Description("Unknown 2354430")]
        [Length(442)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2354430 = 2354430,
        [Description("Unknown 2354872")]
        [Length(390)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2354872 = 2354872,
        [Description("Unknown 2355262")]
        [Length(328)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2355262 = 2355262,
        [Description("Unknown 2355590")]
        [Length(336)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2355590 = 2355590,
        [Description("Unknown 2355926")]
        [Length(202)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2355926 = 2355926,
        [Description("Unknown 2356194")]
        [Length(2642)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2356194 = 2356194,
        [Description("Unknown 2358836")]
        [Length(110)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2358836 = 2358836,
        [Description("Unknown 2358946")]
        [Length(8)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2358946 = 2358946,
        [Description("Unknown 2358994")]
        [Length(3792)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2358994 = 2358994,
        [Description("Unknown 2362786")]
        [Length(1986)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2362786 = 2362786,
        [Description("Unknown 2364772")]
        [Length(334)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2364772 = 2364772,
        [Description("Unknown 2365166")]
        [Length(1388)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2365166 = 2365166,
        [Description("Unknown 2366554")]
        [Length(754)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2366554 = 2366554,
        [Description("Unknown 2367308")]
        [Length(806)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2367308 = 2367308,
        [Description("Unknown 2368114")]
        [Length(372)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2368114 = 2368114,
        [Description("Unknown 2368514")]
        [Length(432)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2368514 = 2368514,
        [Description("Unknown 2368946")]
        [Length(94)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2368946 = 2368946,
        [Description("Unknown 2369040")]
        [Length(1148)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2369040 = 2369040,
        [Description("Unknown 2370216")]
        [Length(244)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2370216 = 2370216,
        [Description("Unknown 2370460")]
        [Length(1824)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2370460 = 2370460,
        [Description("Unknown 2372284")]
        [Length(340)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2372284 = 2372284,
        [Description("Unknown 2372624")]
        [Length(8)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2372624 = 2372624,
        [Description("Unknown 2372642")]
        [Length(1860)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2372642 = 2372642,
        [Description("Unknown 2374502")]
        [Length(266)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2374502 = 2374502,
        [Description("Unknown 2374768")]
        [Length(212)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2374768 = 2374768,
        [Description("Unknown 2374980")]
        [Length(150)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2374980 = 2374980,
        [Description("Unknown 2375130")]
        [Length(634)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2375130 = 2375130,
        [Description("Unknown 2375764")]
        [Length(312)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2375764 = 2375764,
        [Description("Unknown 2376076")]
        [Length(102)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2376076 = 2376076,
        [Description("Unknown 2376178")]
        [Length(210)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2376178 = 2376178,
        [Description("Unknown 2376388")]
        [Length(180)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2376388 = 2376388,
        [Description("Unknown 2376568")]
        [Length(24)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2376568 = 2376568,
        [Description("Unknown 2376592")]
        [Length(396)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2376592 = 2376592,
        [Description("Unknown 2376988")]
        [Length(366)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2376988 = 2376988,
        [Description("Unknown 2377354")]
        [Length(260)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2377354 = 2377354,
        [Description("Unknown 2377614")]
        [Length(580)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2377614 = 2377614,
        [Description("Unknown 2378194")]
        [Length(800)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2378194 = 2378194,
        [Description("Unknown 2378994")]
        [Length(186)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2378994 = 2378994,
        [Description("Unknown 2379180")]
        [Length(326)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2379180 = 2379180,
        [Description("Unknown 2379506")]
        [Length(736)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2379506 = 2379506,
        [Description("Unknown 2380242")]
        [Length(426)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2380242 = 2380242,
        [Description("Unknown 2380668")]
        [Length(336)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2380668 = 2380668,
        [Description("Unknown 2381004")]
        [Length(664)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2381004 = 2381004,
        [Description("Unknown 2381668")]
        [Length(874)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2381668 = 2381668,
        [Description("Unknown 2382542")]
        [Length(292)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2382542 = 2382542,
        [Description("Unknown 2382834")]
        [Length(254)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2382834 = 2382834,
        [Description("Unknown 2383088")]
        [Length(942)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2383088 = 2383088,
        [Description("Unknown 2384030")]
        [Length(544)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2384030 = 2384030,
        [Description("Unknown 2384574")]
        [Length(424)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2384574 = 2384574,
        [Description("Unknown 2384998")]
        [Length(182)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2384998 = 2384998,
        [Description("Unknown 2385180")]
        [Length(264)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2385180 = 2385180,
        [Description("Unknown 2385444")]
        [Length(398)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2385444 = 2385444,
        [Description("Unknown 2385842")]
        [Length(158)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2385842 = 2385842,
        [Description("Unknown 2386000")]
        [Length(1904)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2386000 = 2386000,
        [Description("Motavia Desert BG 1")]
        [Length(7584)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        MotaviaDesertBG1 = 2492864,
        [Description("Motavia Beach BG 1")]
        [Length(5500)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        MotaviaBeachBG1 = 2501226,
        [Description("Motavia Sea BG 1")]
        [Length(6012)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        MotaviaSeaBG1 = 2507510,
        [Description("Motavia Grass BG 1")]
        [Length(7396)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        MotaviaGrassBG1 = 2514344,
        [Description("Dezolis BG 1")]
        [Length(6408)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        DezolisBG1 = 2522762,
        [Description("Bio Plant BG 1")]
        [Length(2686)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        BioPlantBG1 = 2529870,
        [Description("Academy Basement BG 1")]
        [Length(1026)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        AcademyBasementBG1 = 2532998,
        [Description("Ladea Tower BG 1")]
        [Length(4370)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        LadeaTowerBG1 = 2534740,
        [Description("Air Castle BG 1")]
        [Length(4580)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        AirCastleBG1 = 2539570,
        [Description("Garuberk Tower BG 1")]
        [Length(6508)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        GaruberkTowerBG1 = 2544678,
        [Description("Tonoe Basement BG 1")]
        [Length(4954)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        TonoeBasementBG1 = 2551668,
        [Description("Monsen Cave BG 1")]
        [Length(4134)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        MonsenCaveBG1 = 2557432,
        [Description("Soldier Island BG 1")]
        [Length(3846)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        SoldierIslandBG1 = 2562204,
        [Description("Rykros BG 1")]
        [Length(7674)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        RykrosBG1 = 2566834,
        [Description("Zema BG 1")]
        [Length(5406)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        ZemaBG1 = 2575426,
        [Description("Reshel BG 1")]
        [Length(6640)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        ReshelBG1 = 2581462,
        [Description("Rykros Tower BG 1")]
        [Length(3118)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        RykrosTowerBG1 = 2588686,
        [Description("The Edge BG 1")]
        [Length(7848)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        TheEdgeBG1 = 2592300,
        [Description("Landrover FG 1")]
        [Length(2494)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        LandroverFG1 = 2600448,
        [Description("Ice Digger FG 1")]
        [Length(2584)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        IceDiggerFG1 = 2603206,
        [Description("Hydrofoil FG 1")]
        [Length(2958)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        HydrofoilFG1 = 2606040,
        [Description("Vehicle HUD FG 1")]
        [Length(260)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        VehicleHUDFG1 = 2609230,
        [Description("Vehicle HUD FG 2")]
        [Length(94)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        VehicleHUDFG2 = 2609490,
        [Description("N-Sphere 1")]
        [Length(1326)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        NSphere1 = 2609584,
        [Description("Numbers 1")]
        [Length(24)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Numbers1 = 2611040,
        [Description("Numbers 2")]
        [Length(232)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Numbers2 = 2611064,
        [Description("HUD 1")]
        [Length(528)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        HUD1 = 2611296,
        [Description("HUD 2")]
        [Length(134)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        HUD2 = 2611824,
        [Description("Chaz Field 1")]
        [Length(2304)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.None)]
        ChazField1 = 2686976,
        [Description("Alys Field 1")]
        [Length(2304)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.None)]
        AlysField1 = 2689280,
        [Description("Hahn Field 1")]
        [Length(2304)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.None)]
        HahnField1 = 2691584,
        [Description("Rune Field 1")]
        [Length(2304)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.None)]
        RuneField1 = 2693888,
        [Description("Gryz Field 1")]
        [Length(2304)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.None)]
        GryzField1 = 2696192,
        [Description("Rika Field 1")]
        [Length(2304)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.None)]
        RikaField1 = 2698496,
        [Description("Demi Field 1")]
        [Length(2304)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.None)]
        DemiField1 = 2700800,
        [Description("Wren Field 1")]
        [Length(2304)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.None)]
        WrenField1 = 2703104,
        [Description("Raja Field 1")]
        [Length(2304)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.None)]
        RajaField1 = 2705408,
        [Description("Kyra Field 1")]
        [Length(2304)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.None)]
        KyraField1 = 2707712,
        [Description("Seth Field 1")]
        [Length(2304)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.None)]
        SethField1 = 2710016,
        [Description("Land Rover Field 1")]
        [Length(1844)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        LandRoverField1 = 2712352,
        [Description("Ice Digger Field 1")]
        [Length(1872)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        IceDiggerField1 = 2714196,
        [Description("Hydrofoil Field 1")]
        [Length(938)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        HydrofoilField1 = 2716068,
        [Description("Treasure Chest 1")]
        [Length(198)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        TreasureChest1 = 2717102,
        [Description("Treasure Chest 2")]
        [Length(134)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        TreasureChest2 = 2717300,
        [Description("Unknown 2717434")]
        [Length(252)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Unknown2717434 = 2717434,
        [Description("HUD 3")]
        [Length(322)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        HUD3 = 2717686,
        [Description("Chaz Status 1")]
        [Length(1362)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        ChazStatus1 = 2718048,
        [Description("Alys Status 1")]
        [Length(1462)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        AlysStatus1 = 2719410,
        [Description("Hahn Status 1")]
        [Length(1066)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        HahnStatus1 = 2720872,
        [Description("Rune Status 1")]
        [Length(1390)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        RuneStatus1 = 2721938,
        [Description("Gryz Status 1")]
        [Length(1336)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        GryzStatus1 = 2723328,
        [Description("Rika Status 1")]
        [Length(1440)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        RikaStatus1 = 2724664,
        [Description("Demi Status 1")]
        [Length(1728)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        DemiStatus1 = 2726104,
        [Description("Wren Status 1")]
        [Length(1408)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        WrenStatus1 = 2727832,
        [Description("Raja Status 1")]
        [Length(1470)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        RajaStatus1 = 2729240,
        [Description("Kyra Status 1")]
        [Length(1616)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        KyraStatus1 = 2730710,
        [Description("Seth Status 1")]
        [Length(1182)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        SethStatus1 = 2732326,
        [Description("Chaz Dialog 1")]
        [Length(688)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        ChazDialog1 = 2735708,
        [Description("Alys Dialog 1")]
        [Length(704)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        AlysDialog1 = 2736396,
        [Description("Hahn Dialog 1")]
        [Length(596)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        HahnDialog1 = 2737100,
        [Description("Rune Dialog 1")]
        [Length(768)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        RuneDialog1 = 2737696,
        [Description("Gryz Dialog 1")]
        [Length(672)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        GryzDialog1 = 2738464,
        [Description("Rika Dialog 1")]
        [Length(696)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        RikaDialog1 = 2739136,
        [Description("Demi Dialog 1")]
        [Length(748)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        DemiDialog1 = 2739832,
        [Description("Wren Dialog 1")]
        [Length(632)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        WrenDialog1 = 2740580,
        [Description("Raja Dialog 1")]
        [Length(698)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        RajaDialog1 = 2741212,
        [Description("Kyra Dialog 1")]
        [Length(730)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        KyraDialog1 = 2741910,
        [Description("Seth Dialog 1")]
        [Length(590)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        SethDialog1 = 2742640,
        [Description("Shopkeeper Dialog 1")]
        [Length(608)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        ShopkeeperDialog1 = 2743230,
        [Description("Shopkeeper Dialog 2")]
        [Length(646)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        ShopkeeperDialog2 = 2743838,
        [Description("Shopkeeper Dialog 3")]
        [Length(668)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        ShopkeeperDialog3 = 2744484,
        [Description("Shopkeeper Dialog 4")]
        [Length(566)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        ShopkeeperDialog4 = 2745152,
        [Description("Shopkeeper Dialog 5")]
        [Length(560)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        ShopkeeperDialog5 = 2745718,
        [Description("Shopkeeper Dialog 6")]
        [Length(694)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        ShopkeeperDialog6 = 2746278,
        [Description("Shopkeeper Dialog 7")]
        [Length(714)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        ShopkeeperDialog7 = 2746972,
        [Description("Saya Dialog 1")]
        [Length(664)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        SayaDialog1 = 2747686,
        [Description("Professor Holt Dialog 1")]
        [Length(658)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        ProfessorHoltDialog1 = 2748350,
        [Description("Principal Dialog 1")]
        [Length(644)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        PrincipalDialog1 = 2749008,
        [Description("Dorin Dialog 1")]
        [Length(760)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        DorinDialog1 = 2749652,
        [Description("Pana Dialog 1")]
        [Length(634)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        PanaDialog1 = 2750412,
        [Description("Guild Receptionist Dialog 1")]
        [Length(544)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        GuildReceptionistDialog1 = 2751046,
        [Description("Baker Dialog 1")]
        [Length(662)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        BakerDialog1 = 2751590,
        [Description("Zio Dialog 1")]
        [Length(508)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        ZioDialog1 = 2752252,
        [Description("Juza Dialog 1")]
        [Length(586)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        JuzaDialog1 = 2752760,
        [Description("Gyuna Dialog 1")]
        [Length(636)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        GyunaDialog1 = 2753346,
        [Description("Esper Dialog 1")]
        [Length(638)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        EsperDialog1 = 2753982,
        [Description("Esper Dialog 2")]
        [Length(642)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        EsperDialog2 = 2754620,
        [Description("Priest Dialog 1")]
        [Length(640)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        PriestDialog1 = 2755262,
        [Description("Bishop Dialog 1")]
        [Length(658)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        BishopDialog1 = 2755902,
        [Description("Lashiec Dialog 1")]
        [Length(790)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        LashiecDialog1 = 2756560,
        [Description("Xe-A-Thoul Dialog 1")]
        [Length(422)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        XeAThoulDialog1 = 2757350,
        [Description("Xe-A-Thoul Dialog 2")]
        [Length(442)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        XeAThoulDialog2 = 2757772,
        [Description("Fortune Teller Dialog 1")]
        [Length(700)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        FortuneTellerDialog1 = 2758214,
        [Description("D-Elm-Lars Dialog 1")]
        [Length(498)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        DElmLarsDialog1 = 2758914,
        [Description("Alys Dying Dialog 1")]
        [Length(734)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        AlysDyingDialog1 = 2759412,
        [Description("Re-Faze Dialog 1")]
        [Length(932)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        ReFazeDialog1 = 2760146,
        [Description("Missing Student Dialog 1")]
        [Length(636)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        MissingStudentDialog1 = 2761078,
        [Description("Tallas Dialog 1")]
        [Length(590)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        TallasDialog1 = 2761714,
        [Description("Dying Boy Dialog 1")]
        [Length(666)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        DyingBoyDialog1 = 2762304,
        [Description("Unknown Dialog 1")]
        [Length(604)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        UnknownDialog1 = 2762970,
        [Description("Dialog Tiles 1")]
        [Length(1212)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        DialogTiles1 = 2763646,
        [Description("Dialog Cursor 1")]
        [Length(790)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        DialogCursor1 = 2764858,
        [Description("Font 1")]
        [Length(498)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Nemesis)]
        Font1 = 2765648,
        [Description("Font 2")]
        [Length(1280)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.None)]
        Font2 = 2766146,
        [Description("Rune Intro 1")]
        [Length(3360)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Kosinski)]
        RuneIntro1 = 3084622,
        [Description("Rika Intro 1")]
        [Length(3120)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Kosinski)]
        RikaIntro1 = 3087982,
        [Description("Wren Intro 1")]
        [Length(4112)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Kosinski)]
        WrenIntro1 = 3091102,
        [Description("Chaz Intro 1")]
        [Length(3296)]
        [Section(SectionType.None)]
        [SubSection(SubSectionType.None)]
        [Compression(CompressionType.Kosinski)]
        ChazIntro1 = 3095214
    }
}
