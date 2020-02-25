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

using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Collections.Generic;

namespace Rika.Data
{
    public class RomData
    {
        /// <summary>
        /// Constants
        /// </summary>
        public static int MAP_COUNT = 417;
        public static int ENEMY_COUNT = 153;
        public static int ENEMY_SKILL_COUNT = 111;
        public static int CHARACTER_TECH_COUNT = 40;
        public static int CHARACTER_SKILL_COUNT = 54;
        public static int CHARACTER_COUNT = 11;
        public static int CHARACTER_COMBO_COUNT = 14;
        public static int CHARACTER_SPRITE_OFFSET = 153;
        public static int ITEM_COUNT = 160;
        public static int DIALOG_COUNT = 43;
        public static int FORMATION_INDEX_COUNT = 128;
        public static int FORMATION_COUNT = 502;
        public static int TERMINATOR1 = 254;
        public static int TERMINATOR2 = 255;

        /// <summary>
        /// Fields
        /// </summary>
        private Dictionary<byte, string> _charMap1 = GetCharacterMap(0);
        private Dictionary<byte, string> _charMap2 = GetCharacterMap(1);
        private Dictionary<byte, byte> _colorValues = GetColorValues();

        /// <summary>
        /// Properties
        /// </summary>
        public byte[] Data;
        public List<Map> Maps = new List<Map>();
        public List<Character> Characters = Enumerable.Range(0, CHARACTER_COUNT).Select(i => new Character()).ToList();
        public List<Technique> Techniques = Enumerable.Range(0, CHARACTER_TECH_COUNT).Select(i => new Technique()).ToList();
        public List<Skill> CharacterSkills = Enumerable.Range(0, CHARACTER_SKILL_COUNT).Select(i => new Skill()).ToList();
        public List<CombinationCollection> Combinations = Enumerable.Range(0, CHARACTER_COMBO_COUNT).Select(i => new CombinationCollection()).ToList();
        public List<Enemy> Enemies = Enumerable.Range(0, ENEMY_COUNT).Select(i => new Enemy()).ToList();
        public List<Skill> EnemySkills = Enumerable.Range(0, ENEMY_SKILL_COUNT).Select(i => new Skill()).ToList();
        public List<Item> Items = Enumerable.Range(0, ITEM_COUNT).Select(i => new Item()).ToList();
        public List<DialogGroup> DialogGroups = new List<DialogGroup>();
        public List<PaletteGroup> PaletteGroups = new List<PaletteGroup>();
        public List<Formation> Formations = new List<Formation>();
        public List<Sprite> Sprites = new List<Sprite>();
        public List<Tileset> Tilesets = new List<Tileset>();
        public List<TileMap> TileMaps = new List<TileMap>();

        /// <summary>
        /// Constructors
        /// </summary>
        /// <param name="path">Path to the ROM file</param>
        public RomData(string path)
        {
            Data = File.ReadAllBytes(path);
            SetSprites();
            LoadPaletteData();
            LoadTilesetData();
            LoadTileMapData();
            LoadMapData();
            LoadDialogData();
            LoadCharacterTechSkillData();
            LoadCharacterData();
            LoadCharacterLevelData();
            LoadEnemyData();
            LoadEnemySkillData();
            LoadItems();
            LoadEnemyFormationData();
            LoadCombinationData();
        }

        /// <summary>
        /// Loads palette data
        /// </summary>
        private void LoadPaletteData()
        {
            foreach (PaletteType e in Enum.GetValues(typeof(PaletteType)))
                PaletteGroups.Add(new PaletteGroup(e));

            foreach (PaletteGroup group in PaletteGroups)
            {
                int id = 0;
                int index = 0;
                int byteIndex = group.ID;
                List<Color> colors = GetColors(GetBytes(group.ID, group.Length, Data));
                for (int i = 0; i < colors.Count / 16 + 1; i++)
                {
                    if (index >= colors.Count)
                        break;

                    Palette palette = new Palette();
                    palette.Name = group + " [" + (i + 1) + "]";
                    palette.CustomName = palette.Name;
                    palette.DataStart = byteIndex;
                    for (int j = 0; j < 16; j++)
                    {
                        if (index >= colors.Count)
                            break;
                        palette.Colors.Add(colors[index]);
                        byteIndex += 2;
                        index++;
                    }
                    palette.DataEnd = byteIndex;
                    palette.Length = palette.DataEnd - palette.DataStart;
                    group.Palettes.Add(palette);
                    id++;
                }
                group.SetPaddedColors();
            }
        }

        /// <summary>
        /// Loads tileset data
        /// </summary>
        private void LoadTilesetData()
        {
            foreach (TilesetType e in Enum.GetValues(typeof(TilesetType)))
                Tilesets.Add(new Tileset(e));
            foreach (Tileset tileset in Tilesets)
            {
                byte[] data = GetBytes(tileset.ID, tileset.Length, Data);
                List<byte> decompressed = Decompress(tileset.Compression, data).ToList();
                tileset.DecompressedLength = decompressed.Count;
                List<byte> pixels = new List<byte>();
                foreach (byte b in decompressed)
                {
                    if (tileset.PixelFormat == PixelFormatType.FourLinear)
                    {
                        pixels.Add((byte)((b & 0xF0) >> 4));
                        pixels.Add((byte)(b & 0x0F));
                    }
                    else  // TODO: Implement 2bpp planar correctly (Very few, maybe only 1 font tileset uses this)
                    {
                        pixels.Add((byte)((b >> 6) & 3));
                        pixels.Add((byte)((b >> 4) & 3));
                        pixels.Add((byte)((b >> 2) & 3));
                        pixels.Add((byte)((b >> 0) & 3));
                    }
                }
                tileset.Pixels = pixels;
            }
        }

        /// <summary>
        /// Loads tilemap data
        /// </summary>
        private void LoadTileMapData()
        {
            foreach (TileMapType e in Enum.GetValues(typeof(TileMapType)))
                TileMaps.Add(new TileMap(e));
            foreach (TileMap tilemap in TileMaps)
            {
                int index = 0;
                byte[] data = GetBytes(tilemap.ID, tilemap.Length, Data);
                data = tilemap.Compression == CompressionType.None ? data : Decompress(tilemap.Compression, data);
                tilemap.DecompressedLength = data.Length;
                if (tilemap.UseFlags)
                {
                    for (int i = 0; i < data.Length; i += 2)
                    {
                        byte b1 = data[i];
                        byte b2 = data[i + 1];
                        Tile tile = new Tile();
                        tile.Offset = (b1 & (1 << 0)) != 0;
                        tile.PaletteIndex = (b1 & (1 << 1)) | (b1 & (1 << 2));
                        tile.FlipX = (b1 & (1 << 3)) != 0;
                        tile.FlipY = (b1 & (1 << 4)) != 0;
                        tile.Offset2 = (b1 & (1 << 6)) != 0 && (b1 & (1 << 7)) != 0;
                        tile.Mask = data[i];
                        tile.TileID = data[i + 1];
                        tile.Bits = GetTileMask(b1, b2);
                        tilemap.Tiles.Add(tile);
                        index++;
                    }
                }
                else
                {
                    for (int i = 0; i < data.Length; i++)
                    {
                        Tile tile = new Tile();
                        tile.TileID = data[i];
                        tilemap.Tiles.Add(tile);
                        index++;
                    }
                }
            }
        }

        /// <summary>
        /// Loads map data
        /// </summary>
        private void LoadMapData()
        {
            int dataIndex = 1048576;
            for (int i = 0; i < MAP_COUNT * 4; i += 4)
            {
                int index = ReadInt(ref dataIndex, 4, Data);
                if (index != 512)
                    Maps.Add(new Map(EnumMethods.GetDescription(typeof(MapType), i / 4), i / 4, index));
            }
            //StringBuilder sb = new StringBuilder();
            foreach (Map map in Maps)
            {
                //int index1 = 1;
                dataIndex = map.DataStart;
                map.ParentMapID = ReadInt(ref dataIndex, 1, Data);
                map.MusicID = ReadInt(ref dataIndex, 1, Data);
                // Tilesets (Map)
                while (SeekInt(dataIndex, 2, Data) != 65535)
                {
                    ReadInt(ref dataIndex, 2, Data);
                    int id = ReadInt(ref dataIndex, 4, Data);
                    map.TilesetIDs.Add(id);
                    //sb.AppendLine("[Description(\"" + map.Name + " " + (index1) + "\")]");
                    //sb.AppendLine("[Bytes(0)]");
                    //sb.AppendLine("[Section(SectionType.Field)]");
                    //sb.AppendLine("[SubSection(SubSectionType.Map)]");
                    //sb.AppendLine("[Compression(CompressionType.Kosinski)]");
                    //sb.AppendLine((map.Name + index1).Replace(" ", "") + " = " + id + ",");
                    //index1++;
                }
                ReadInt(ref dataIndex, 2, Data);
                //index1 = 1;
                // Tilesets (NPCs)?
                while (SeekInt(dataIndex, 2, Data) != 65535)
                {
                    ReadInt(ref dataIndex, 2, Data);
                    int id = ReadInt(ref dataIndex, 4, Data);
                    map.TilesetIDs.Add(id);
                    //sb.AppendLine("[Description(\"" + map.Name + " NPCs " + (index1) + "\")]");
                    //sb.AppendLine("[Bytes(0)]");
                    //sb.AppendLine("[Section(SectionType.Field)]");
                    //sb.AppendLine("[SubSection(SubSectionType.NPCs)]");
                    //sb.AppendLine("[Compression(CompressionType.Nemesis)]");
                    //sb.AppendLine((map.Name + "NPCs" + index1).Replace(" ", "") + " = " + id + ",");
                    //index1++;
                }
                ReadInt(ref dataIndex, 2, Data);
                // ???
                while (SeekInt(dataIndex, 2, Data) != 65535)
                    map.TilesetIDs.Add(ReadInt(ref dataIndex, 4, Data));
                ReadInt(ref dataIndex, 2, Data);
                // ??? Chunk sizes and flags? eg: 1216430: 31, 15, 31, 15, 1, 0, 0, 1, 0, 1
                // Seems the first 4 numbers are always zero indexed power of 2 values eg: 15, 31, 127 etc.. etc..
                for (int i = 0; i < 10; i++)
                    map.UnknownBytes.Add(ReadInt(ref dataIndex, 1, Data));
                // Tile maps? (Although the data seems incomplete after decompressing?) Most likely in a plane map format of some sort)
                while (SeekInt(dataIndex, 2, Data) != 65535)
                    map.TileMapIDs.Add(ReadInt(ref dataIndex, 4, Data));
                ReadInt(ref dataIndex, 2, Data);
                // Updates
                while (SeekInt(dataIndex, 1, Data) != 255)
                    map.Updates.Add(ReadInt(ref dataIndex, 1, Data));
                ReadInt(ref dataIndex, 1, Data);
                // Transitions
                while (SeekInt(dataIndex, 2, Data) != 65535)
                {
                    MapTransition transition = new MapTransition();
                    transition.X = ReadInt(ref dataIndex, 1, Data);
                    transition.Y = ReadInt(ref dataIndex, 1, Data);
                    transition.Size = ReadInt(ref dataIndex, 1, Data);
                    transition.TargetMapID = ReadInt(ref dataIndex, 1, Data);
                    transition.TileX = ReadInt(ref dataIndex, 1, Data);
                    transition.TileY = ReadInt(ref dataIndex, 1, Data);
                    transition.Facing = ReadInt(ref dataIndex, 1, Data);
                    transition.CharacterAlignment = ReadInt(ref dataIndex, 1, Data);
                    ReadInt(ref dataIndex, 2, Data);
                    map.Transitions.Add(transition);
                }
                ReadInt(ref dataIndex, 2, Data);
                // Transitions
                while (SeekInt(dataIndex, 2, Data) != 65535)
                {
                    MapTransition transition = new MapTransition();
                    transition.X = ReadInt(ref dataIndex, 1, Data);
                    transition.Y = ReadInt(ref dataIndex, 1, Data);
                    transition.Size = ReadInt(ref dataIndex, 2, Data);
                    transition.TargetMapID = ReadInt(ref dataIndex, 2, Data);
                    transition.TileX = ReadInt(ref dataIndex, 1, Data);
                    transition.TileY = ReadInt(ref dataIndex, 1, Data);
                    transition.Facing = ReadInt(ref dataIndex, 1, Data);
                    transition.CharacterAlignment = ReadInt(ref dataIndex, 1, Data);
                    map.Transitions.Add(transition);
                }
                ReadInt(ref dataIndex, 2, Data);
                // Objects
                while (SeekInt(dataIndex, 2, Data) != 65535)
                {
                    MapObject obj = new MapObject();
                    obj.TableID = ReadInt(ref dataIndex, 2, Data);
                    obj.Facing = ReadInt(ref dataIndex, 1, Data);
                    obj.DialogID = ReadInt(ref dataIndex, 1, Data);
                    obj.TileID = ReadInt(ref dataIndex, 2, Data); 
                    obj.TileX = ReadInt(ref dataIndex, 2, Data) / 8;
                    obj.TileY = ReadInt(ref dataIndex, 2, Data) / 8;
                    map.Objects.Add(obj);
                }
                ReadInt(ref dataIndex, 2, Data);
                // Treasure Chests
                while (SeekInt(dataIndex, 2, Data) != 65535)
                {
                    MapChest chest = new MapChest();
                    chest.Type = (MapChestType)ReadInt(ref dataIndex, 1, Data);
                    chest.ContentType = (MapChestContentType)ReadInt(ref dataIndex, 1, Data);
                    chest.FlagConstentID = ReadInt(ref dataIndex, 1, Data);
                    chest.Content = ReadInt(ref dataIndex, 1, Data);
                    chest.X = ReadInt(ref dataIndex, 1, Data);
                    chest.Y = ReadInt(ref dataIndex, 1, Data);
                    map.Chests.Add(chest);
                }
                ReadInt(ref dataIndex, 2, Data);
                // Animated tiles
                while (SeekInt(dataIndex, 2, Data) != 65535)
                    map.AnimatedTileIDs.Add(ReadInt(ref dataIndex, 1, Data));
                ReadInt(ref dataIndex, 2, Data);
                // Tile maps? (These aren't always present, haven't found the indicator when they will, and will not be?) and dialog group id
                if (map.ID != (int)MapType.Motavia && map.ID != (int)MapType.Dezolis)
                {
                    map.TileMapIDs.Add(ReadInt(ref dataIndex, 4, Data));
                    map.TileMapIDs.Add(ReadInt(ref dataIndex, 4, Data));
                }
                map.DialogGroupID = ReadInt(ref dataIndex, 4, Data);
                // Areas
                while (SeekInt(dataIndex, 2, Data) != 65535)
                {
                    MapArea area = new MapArea();
                    area.X = ReadInt(ref dataIndex, 2, Data);
                    area.Y = ReadInt(ref dataIndex, 2, Data);
                    area.Size = ReadInt(ref dataIndex, 2, Data);
                    area.EventType = (MapAreaEventType)ReadInt(ref dataIndex, 1, Data);
                    area.FlagConstentID = ReadInt(ref dataIndex, 1, Data);
                    area.MethodIndex = ReadInt(ref dataIndex, 1, Data);
                    area.MethodValue = ReadInt(ref dataIndex, 1, Data);
                    map.Areas.Add(area);
                }
                ReadInt(ref dataIndex, 2, Data);
                // Events
                while (SeekInt(dataIndex, 1, Data) != 255)
                    map.EventIDs.Add(ReadInt(ref dataIndex, 1, Data));
                ReadInt(ref dataIndex, 1, Data);
                // Palette address
                map.PaletteGroupID = ReadInt(ref dataIndex, 4, Data);
                // Unknown bytes
                for (int i = 0; i < 4; i++)
                    map.UnknownBytes.Add(ReadInt(ref dataIndex, 1, Data));
                // Map Manager data
                while (SeekInt(dataIndex, 2, Data) != 65535)
                    map.MapMethodIDs.Add(ReadInt(ref dataIndex, 1, Data));
            }
        }

        /// <summary>
        /// Loads dialog data
        /// </summary>
        private void LoadDialogData()
        {
            foreach (DialogGroupType e in Enum.GetValues(typeof(DialogGroupType)))
                DialogGroups.Add(new DialogGroup(e));
            foreach (DialogGroup dialog in DialogGroups)
            {
                int id = 0;
                int index = 0;
                int dataIndex = dialog.DataStart;
                List<byte> buffer = new List<byte>();
                for (int i = 0; i < dialog.Length; i++)
                    buffer.Add(Data[dataIndex + i]);
                if (buffer.Count <= 0)
                    continue;
                dataIndex += buffer.Count;
                byte[] uncompressed = Kosinski.Decompress(buffer.ToArray());
                while (index < uncompressed.Length)
                {
                    int value = uncompressed[index];
                    Dialog conversation = new Dialog(id);
                    if (value == (int)DialogCodeType.Close)
                    {
                        index++;
                        continue;
                    }
                    else if (value == (int)DialogCodeType.Open || value == (int)DialogCodeType.Portrait)
                    {
                        if (value == (int)DialogCodeType.Open)
                            index++;
                        
                        if (uncompressed[index] == (int)DialogCodeType.Count)
                        {
                            index++;
                            index += ((uncompressed[index] - 1) * 3) + 1;
                        }

                        int speaker = 0;
                        List<byte> str = new List<byte>();
                        while (uncompressed[index] != (int)DialogCodeType.Close)
                        {
                            if (uncompressed[index] == (int)DialogCodeType.NewLine || uncompressed[index] == (int)DialogCodeType.PageEnd)
                            {
                                conversation.Lines.Add(new DialogLine(speaker, GetString(str.ToArray(), _charMap2), (uncompressed[index] == (int)DialogCodeType.NewLine ? 0 : 1)));
                                str.Clear();
                            }
                            else if (uncompressed[index] == (int)DialogCodeType.Portrait)
                            {
                                index++;
                                speaker = uncompressed[index];
                            }
                            else
                                str.Add(uncompressed[index]);
                            index++;
                        }
                        conversation.Lines.Add(new DialogLine(speaker, GetString(str.ToArray(), _charMap2), 2));
                        dialog.Conversations.Add(conversation);
                        id++;
                    }
                    index++;
                }
            }
        }

        /// <summary>
        /// Loads character technique and skill data
        /// </summary>
        private void LoadCharacterTechSkillData()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            int id = 1;
            int nameIndex = 2799138;
            int dataIndex = 2792424;
            foreach (Technique technique in Techniques)
            {
                List<byte> str = new List<byte>();
                while (Data[nameIndex] != 254)
                    str.Add((byte)ReadInt(ref nameIndex, 1, Data));
                ReadInt(ref nameIndex, 1, Data);
                technique.ID = id++;
                technique.Name = GetString(str.ToArray(), _charMap1);
                technique.CustomName = EnumMethods.GetDescription(typeof(TechniqueType), technique.ID);
                technique.DataStart = dataIndex;
                technique.Effect = (EffectType)ReadInt(ref dataIndex, 1, Data);
                technique.TPCost = ReadInt(ref dataIndex, 1, Data);
                byte b = (byte)ReadInt(ref dataIndex, 1, Data);
                technique.Target = (EffectTargetType)(byte)(b & 0x0F);
                technique.EffectArea = (EffectAreaType)(byte)((b & 0xF0) >> 4);
                technique.EffectAmount = ReadInt(ref dataIndex, 1, Data);
                technique.Defense = (EffectStatType)ReadInt(ref dataIndex, 1, Data);
                technique.Element = (ElementType)ReadInt(ref dataIndex, 1, Data);
                ReadInt(ref dataIndex, 2, Data);
                technique.Length = dataIndex - technique.DataStart;
                technique.DataEnd = dataIndex;
            }
            ReadInt(ref nameIndex, 1, Data);
            id = 1;
            foreach (Skill skill in CharacterSkills)
            {
                List<byte> str = new List<byte>();
                while (Data[nameIndex] != 254)
                    str.Add((byte)ReadInt(ref nameIndex, 1, Data));
                ReadInt(ref nameIndex, 1, Data);
                skill.ID = id++;
                skill.Name = GetString(str.ToArray(), _charMap1);
                skill.CustomName = EnumMethods.GetDescription(typeof(CharacterSkillType), skill.ID);
                skill.DataStart = dataIndex;
                skill.Effect = (EffectType)ReadInt(ref dataIndex, 1, Data);
                skill.Offense = (EffectStatType)ReadInt(ref dataIndex, 1, Data);
                byte b = (byte)ReadInt(ref dataIndex, 1, Data);
                skill.Target = (EffectTargetType)(byte)(b & 0x0F);
                skill.EffectArea = (EffectAreaType)(byte)((b & 0xF0) >> 4);
                skill.EffectAmount = ReadInt(ref dataIndex, 1, Data);
                skill.Defense = (EffectStatType)ReadInt(ref dataIndex, 1, Data);
                skill.Element = (ElementType)ReadInt(ref dataIndex, 1, Data);
                ReadInt(ref dataIndex, 2, Data);
                skill.Length = dataIndex - skill.DataStart;
                skill.DataEnd = dataIndex;
            }
            Techniques.Insert(0, new Technique(0, "None"));
            CharacterSkills.Insert(0, new Skill(0, "None"));
        }

        /// <summary>
        /// Loads character data
        /// </summary>
        private void LoadCharacterData()
        {
            int id = 0;
            int nameIndex = 2788768;
            int dataIndex = 2788042;
            foreach (Character character in Characters)
            {
                List<byte> str = new List<byte>();
                while (Data[nameIndex] != 255)
                    str.Add((byte)ReadInt(ref nameIndex, 1, Data));
                ReadInt(ref nameIndex, 1, Data);
                character.Name = GetString(str.ToArray(), _charMap1);
                character.CustomName = character.Name;
                character.ID = id++;
                character.SpriteID = (int)SpriteType.ChazStatus + character.ID;
                character.DataStart = dataIndex;
                character.Profession = (CharacterProfessionType)ReadInt(ref dataIndex, 2, Data);
                character.FirstLevel = ReadInt(ref dataIndex, 2, Data);
                CharacterLevel level = new CharacterLevel() { ID = 0, Name = character.FirstLevel.ToString() };
                level.Exp = ReadInt(ref dataIndex, 4, Data);
                level.HP = ReadInt(ref dataIndex, 2, Data);
                level.TP = ReadInt(ref dataIndex, 2, Data);
                level.Strength = ReadInt(ref dataIndex, 1, Data);
                level.Mental = ReadInt(ref dataIndex, 1, Data);
                level.Agility = ReadInt(ref dataIndex, 1, Data);
                level.Dexterity = ReadInt(ref dataIndex, 1, Data);
                for (int i = 0; i < 14; i++)
                    character.Resistances[i] = (ResistanceType)ReadInt(ref dataIndex, 1, Data);
                for (int i = 0; i < 4; i++)
                    character.EquipmentIDs[i] = ReadInt(ref dataIndex, 1, Data);
                for (int i = 0; i < 16; i++)
                    character.TechniqueIDs[i] = ReadInt(ref dataIndex, 1, Data);
                for (int i = 0; i < 8; i++)
                    character.SkillIDs[i] = ReadInt(ref dataIndex, 1, Data);
                level.SkillCount1 = ReadInt(ref dataIndex, 1, Data);
                level.SkillCount2 = ReadInt(ref dataIndex, 1, Data);
                level.SkillCount3 = ReadInt(ref dataIndex, 1, Data);
                level.SkillCount4 = ReadInt(ref dataIndex, 1, Data);
                level.SkillCount5 = ReadInt(ref dataIndex, 1, Data);
                level.SkillCount6 = ReadInt(ref dataIndex, 1, Data);
                level.SkillCount7 = ReadInt(ref dataIndex, 1, Data);
                level.SkillCount8 = ReadInt(ref dataIndex, 1, Data);
                character.Length = dataIndex - character.DataStart;
                character.DataEnd = dataIndex;
                foreach (int technique in character.TechniqueIDs)
                    level.TechniqueName += technique <= 0 || technique >= Techniques.Count ? "" : Techniques[technique].CustomName + Environment.NewLine;
                foreach (int skill in character.SkillIDs)
                    level.SkillName += skill <= 0 || skill >= CharacterSkills.Count ? "" : CharacterSkills[skill].CustomName + Environment.NewLine;
                level.TechniqueName = level.TechniqueName.TrimEnd(Environment.NewLine.ToCharArray());
                level.SkillName = level.SkillName.TrimEnd(Environment.NewLine.ToCharArray());
                character.Levels.Add(level);
            }
        }

        /// <summary>
        /// Loads character level data
        /// </summary>
        private void LoadCharacterLevelData()
        {
            int dataIndex = 2643632;
            foreach (Character character in Characters)
            {
                int id = 0;
                int index = character.FirstLevel + 1;
                while (index != 100)
                {
                    CharacterLevel level = new CharacterLevel();
                    level.ID = id++;
                    level.Name = index.ToString();
                    level.Exp = ReadInt(ref dataIndex, 4, Data);
                    level.HP = ReadInt(ref dataIndex, 2, Data);
                    level.TP = ReadInt(ref dataIndex, 2, Data);
                    level.Strength = ReadInt(ref dataIndex, 1, Data);
                    level.Mental = ReadInt(ref dataIndex, 1, Data);
                    level.Agility = ReadInt(ref dataIndex, 1, Data);
                    level.Dexterity = ReadInt(ref dataIndex, 1, Data);
                    level.TechniqueID = ReadInt(ref dataIndex, 1, Data);
                    level.TechniqueName = level.TechniqueID <= 0 || level.TechniqueID >= Techniques.Count ? "" : Techniques[level.TechniqueID].CustomName;
                    level.SkillID = ReadInt(ref dataIndex, 1, Data);
                    level.SkillName = level.SkillID <= 0 || level.SkillID >= CharacterSkills.Count ? "" : CharacterSkills[level.SkillID].CustomName;
                    level.SkillCount1 = ReadInt(ref dataIndex, 1, Data);
                    level.SkillCount2 = ReadInt(ref dataIndex, 1, Data);
                    level.SkillCount3 = ReadInt(ref dataIndex, 1, Data);
                    level.SkillCount4 = ReadInt(ref dataIndex, 1, Data);
                    level.SkillCount5 = ReadInt(ref dataIndex, 1, Data);
                    level.SkillCount6 = ReadInt(ref dataIndex, 1, Data);
                    level.SkillCount7 = ReadInt(ref dataIndex, 1, Data);
                    level.SkillCount8 = ReadInt(ref dataIndex, 1, Data);
                    character.Levels.Add(level);
                    index++;
                }
                id = 0;
                index = 0;
            }
            SetCharacterTechAndSkills();
        }

        /// <summary>
        /// Loads enemy data
        /// </summary>
        private void LoadEnemyData()
        {
            int id = 0;
            int nameIndex = 2624834;
            int dataIndex = 2627260;
            foreach (Enemy enemy in Enemies)
            {
                List<byte> str = new List<byte>();
                while (Data[nameIndex] != 255)
                    str.Add((byte)ReadInt(ref nameIndex, 1, Data));
                ReadInt(ref nameIndex, 1, Data);
                enemy.ID = id++;
                enemy.SpriteID = (int)SpriteType.Helex + enemy.ID;
                enemy.Name = GetString(str.ToArray(), _charMap1);
                enemy.CustomName = EnumMethods.GetDescription(typeof(EnemyType), enemy.ID);
                enemy.DataStart = dataIndex;
                enemy.HP = ReadInt(ref dataIndex, 2, Data);
                enemy.AttackElement = (ElementType)ReadInt(ref dataIndex, 1, Data);
                enemy.StatusEffect = (StatusEffectType)ReadInt(ref dataIndex, 1, Data);
                enemy.Strength = ReadInt(ref dataIndex, 1, Data);
                enemy.Mental = ReadInt(ref dataIndex, 1, Data);
                enemy.Agility = ReadInt(ref dataIndex, 1, Data);
                enemy.Dexterity = ReadInt(ref dataIndex, 1, Data);
                enemy.Attack = ReadInt(ref dataIndex, 2, Data);
                enemy.Defense = ReadInt(ref dataIndex, 1, Data);
                enemy.MagicDefense = ReadInt(ref dataIndex, 1, Data);
                for (int i = 0; i < 14; i++)
                    enemy.Resistances[i] = (ResistanceType)ReadInt(ref dataIndex, 1, Data);
                ReadInt(ref dataIndex, 2, Data);
                for (int i = 0; i < 4; i++)
                    enemy.Conditions[i].Trigger = (TriggerType)ReadInt(ref dataIndex, 1, Data);
                for (int i = 0; i < 4; i++)
                    enemy.Conditions[i].ActionID = ReadInt(ref dataIndex, 1, Data);
                for (int i = 0; i < 8; i++)
                    enemy.ActionIDs[i] = ReadInt(ref dataIndex, 1, Data);
                enemy.Exp = ReadInt(ref dataIndex, 2, Data);
                enemy.Meseta = ReadInt(ref dataIndex, 2, Data);
                enemy.Length = dataIndex - enemy.DataStart;
                enemy.DataEnd = dataIndex;
                double score = 0;
                foreach (ResistanceType resistance in enemy.Resistances)
                    score += (int)resistance;
                score = Math.Floor((score / 70) * 100);
                enemy.ResistanceScore = (int)score;
                enemy.ResistanceGrade = score <= 25 ? "Great" : score <= 36 ? "Good" : "Average ";
            }
        }

        /// <summary>
        /// Loads enemy skill data
        /// </summary>
        private void LoadEnemySkillData()
        {
            int id = 2;
            int nameIndex = 2626284;
            int dataIndex = 2634612;
            foreach (Skill skill in EnemySkills)
            {
                List<byte> str = new List<byte>();
                while (Data[nameIndex] != 255)
                    str.Add((byte)ReadInt(ref nameIndex, 1, Data));
                ReadInt(ref nameIndex, 1, Data);
                skill.ID = id++;
                skill.Name = GetString(str.ToArray(), _charMap1);
                skill.CustomName = EnumMethods.GetDescription(typeof(EnemySkillType), skill.ID);
                skill.DataStart = dataIndex;
                skill.Effect = (EffectType)ReadInt(ref dataIndex, 1, Data);
                skill.Offense = (EffectStatType)ReadInt(ref dataIndex, 1, Data);
                skill.Target = (EffectTargetType)ReadInt(ref dataIndex, 1, Data);
                skill.EffectAmount = ReadInt(ref dataIndex, 1, Data);
                skill.Defense = (EffectStatType)ReadInt(ref dataIndex, 1, Data);
                skill.Element = (ElementType)ReadInt(ref dataIndex, 1, Data);
                ReadInt(ref dataIndex, 2, Data);
                skill.Length = dataIndex - skill.DataStart;
                skill.DataEnd = dataIndex;
            }
            EnemySkills.Insert(0, new Skill(0, "Normal Attack"));
        }

        /// <summary>
        /// Loads item data
        /// </summary>
        private void LoadItems()
        {

            int id = 1;
            int nameIndex = 2797492;
            int dataIndex = 2788904;
            int descriptionIndex = 2810308;
            foreach (Item item in Items)
            {
                List<byte> name = new List<byte>();
                while (Data[nameIndex] != TERMINATOR1)
                    name.Add((byte)ReadInt(ref nameIndex, 1, Data));
                ReadInt(ref nameIndex, 1, Data);
                item.ID = id++;
                item.Name = GetString(name.ToArray(), _charMap1);
                item.CustomName = EnumMethods.GetDescription(typeof(ItemType), item.ID);
                item.DataStart = dataIndex;
                item.Effect = (EffectType)ReadInt(ref dataIndex, 1, Data);
                item.EffectAmount = ReadInt(ref dataIndex, 1, Data);
                item.EffectTarget = (EffectTargetType)ReadInt(ref dataIndex, 1, Data);
                item.EffectChance = ReadInt(ref dataIndex, 1, Data);
                item.ResistanceStat = (EffectStatType)ReadInt(ref dataIndex, 1, Data);
                item.Element = (ElementType)ReadInt(ref dataIndex, 1, Data);
                ReadInt(ref dataIndex, 2, Data);
                item.EligibleCharacters = GetCharacterMask((byte)ReadInt(ref dataIndex, 1, Data), (byte)ReadInt(ref dataIndex, 1, Data));
                item.Type = (ItemAreaType)ReadInt(ref dataIndex, 1, Data);
                item.Strength = ReadInt(ref dataIndex, 1, Data);
                item.Mental = ReadInt(ref dataIndex, 1, Data);
                item.Agility = ReadInt(ref dataIndex, 1, Data);
                item.Dexterity = ReadInt(ref dataIndex, 1, Data);
                item.Attack = ReadInt(ref dataIndex, 1, Data);
                item.Defense = ReadInt(ref dataIndex, 1, Data);
                item.MagicDefense = ReadInt(ref dataIndex, 1, Data);
                item.AppliedElement = (ElementType)ReadInt(ref dataIndex, 1, Data);
                item.SecondaryEffect = (EffectType)ReadInt(ref dataIndex, 1, Data);
                item.Meseta = ReadInt(ref dataIndex, 2, Data);
                item.Length = dataIndex - item.DataStart;
                item.DataEnd = dataIndex;
                List<byte> description = new List<byte>();
                while (Data[descriptionIndex] != TERMINATOR1)
                    description.Add((byte)ReadInt(ref descriptionIndex, 1, Data));
                item.Description = GetString(description.ToArray(), _charMap1);
                ReadInt(ref descriptionIndex, 1, Data);
            }
            Items.Insert(0, new Item(0, "None", "None"));
        }

        /// <summary>
        /// Loads enemy formation data
        /// </summary>
        private void LoadEnemyFormationData()
        {
            //; =================================================================
            //; Formation data can take up 16 bytes max, including the delimiter $FF.
            //; Each formation is variable-length, so number of bytes depends on how many enemies there are
            //;
            //; Byte 1 = Surprise rate; used in the calculation for normal attack, surprise attack and ambush logic; formula is
            //;
            //;		2((Agi-Surp)+RNG)
            //;
            //;	where Agi is the agility of the fastest character in the party, Surp the Surprise rate, and RNG a random number between 0 and 63.
            //;	If the result is <= 12, it's an ambush.
            //;	If the result is > 12 and <= 116, it's a normal attack.
            //;	If the result is > 116, it's a surprise attack.
            //; Byte 2 = Escape rate; used in the calculation for running away; formula is
            //;
            //;		2((Agi-Esc)+RNG)
            //;
            //;	where Agi is the agility of the fastest character in the party, Esc the Escape rate, and RNG a random number between 0 and 63.
            //;	If the result is > 40, you manage to escape 
            //; Byte 3 = Item drop rate
            //; Byte 4 = Item dropped
            //; Byte 5 = Total number of enemies
            //; Byte 6 = bitfield; applies to the first enemy group; each bit corresponds to the position each enemy appears in bytes 8, 10, 12 and 14;
            //;			for example, if a Crawler shows up in the 3rd spot (Byte 12) and you want it to be on the first group, you should set this value
            //;			to $04 (3rd bit set). The same types of enemies should belong to the same group.
            //; Byte 7 = bitfield; same as Byte 6, but applies to the second enemy group.
            //; Byte 8 = Enemy 1
            //; Byte 9 = enemy 1 X pos base value; to get the actual X position, multiply base value by 8 and add 128, so
            //;
            //;		X pos = (base*8)+128
            //;
            //; Byte 10 = Enemy 2; if not present, it's $FF
            //; Byte 11 = Enemy 2 X pos base value; see Byte 9
            //; Byte 12 = Enemy 3; if not present, it's $FF
            //; Byte 13 = Enemy 3 X pos base value; see Byte 9
            //; Byte 14 = Enemy 4; if not present, it's $FF
            //; Byte 15 = Enemy 4 X pos base value; see Byte 9
            //; Byte 16 = $FF if all 4 enemies are present
            //; =================================================================
            int id = 0;
            int dataIndex = 2637420;
            int[] lengths = new int[5] { 1104, 1120, 1136, 1008, 160 };
            foreach (int length in lengths)
            {
                int uncompressedIndex = 0;
                byte[] buffer = GetBytes(dataIndex, length, Data);
                byte[] uncompressed = Kosinski.Decompress(buffer);
                dataIndex += buffer.Length;
                while (uncompressedIndex < uncompressed.Length)
                {
                    Formation formation = new Formation();
                    formation.ID = id++;
                    formation.SurpriseRate = ReadInt(ref uncompressedIndex, 1, uncompressed);
                    formation.EscapeRate = ReadInt(ref uncompressedIndex, 1, uncompressed);
                    formation.ItemDropRate = ReadInt(ref uncompressedIndex, 1, uncompressed);
                    formation.ItemID = ReadInt(ref uncompressedIndex, 1, uncompressed);
                    formation.ItemName = Items.Find(x => x.ID == formation.ItemID).CustomName;
                    formation.EnemyCount = ReadInt(ref uncompressedIndex, 1, uncompressed);
                    formation.Group1Mask = ReadInt(ref uncompressedIndex, 1, uncompressed);
                    formation.Group2Mask = ReadInt(ref uncompressedIndex, 1, uncompressed);
                    string name = "";
                    string customName = "";
                    while (uncompressed[uncompressedIndex] != 255)
                    {
                        FormationEnemy enemy = new FormationEnemy();
                        enemy.ID = ReadInt(ref uncompressedIndex, 1, uncompressed);
                        enemy.X = ReadInt(ref uncompressedIndex, 1, uncompressed);
                        formation.Enemies.Add(enemy);
                        name += Enemies.Find(x => x.ID == enemy.ID).Name + ", ";
                        customName += Enemies.Find(x => x.ID == enemy.ID).CustomName + ", ";
                    }
                    formation.Name = name.Trim().Trim(',');
                    formation.CustomName = customName.Trim().Trim(',');
                    Formations.Add(formation);
                    ReadInt(ref uncompressedIndex, 1, uncompressed);
                }
            }
        }

        /// <summary>
        /// Loads character combination data
        /// </summary>
        private void LoadCombinationData()
        {
            int id = 0;
            int nameIndex = 2643276;
            int dataIndex = 2642988;
            foreach (CombinationCollection combo in Combinations)
            {
                List<byte> str = new List<byte>();
                while (Data[nameIndex] != 255)
                    str.Add((byte)ReadInt(ref nameIndex, 1, Data));
                ReadInt(ref nameIndex, 1, Data);
                combo.ID = id++;
                combo.Name = GetString(str.ToArray(), _charMap2);
                combo.Effect = (EffectType)ReadInt(ref dataIndex, 1, Data);
                ReadInt(ref dataIndex, 1, Data);
                combo.Target = (EffectTargetType)ReadInt(ref dataIndex, 1, Data);
                combo.EffectChance = ReadInt(ref dataIndex, 1, Data);
                combo.Defense = (EffectStatType)ReadInt(ref dataIndex, 1, Data);
                combo.Element = (ElementType)ReadInt(ref dataIndex, 1, Data);
                ReadInt(ref dataIndex, 2, Data);
            }
            foreach (CombinationCollection combo in Combinations)
            {
                combo.PartCount = ReadInt(ref dataIndex, 1, Data);
                combo.OrderSensitive = combo.PartCount >= 128;
                combo.PartCount = combo.PartCount >= 128 ? combo.PartCount - 128 : combo.PartCount;
                while (Data[dataIndex] != 255)
                {
                    Combination group = new Combination();
                    for (int i = 0; i < combo.PartCount; i++)
                    {
                        CombinationPart part = new CombinationPart();
                        part.ID = ReadInt(ref dataIndex, 1, Data);
                        if (part.ID >= 128)
                        {
                            part.ID -= 128;
                            part.Type = ComboPartType.Skill;
                            part.Name = CharacterSkills.Find(x => x.ID == part.ID).Name;
                            part.CustomName = CharacterSkills.Find(x => x.ID == part.ID).Name;
                        }
                        else
                        {
                            part.Type = ComboPartType.Technique;
                            part.Name = Techniques.Find(x => x.ID == part.ID).Name;
                            part.CustomName = Techniques.Find(x => x.ID == part.ID).Name;
                        }
                        group.PartIDs.Add(part);
                    }
                    combo.Combination.Add(group);
                }
                ReadInt(ref dataIndex, 1, Data);
            }
        }

        /// <summary>
        /// Sets sprite static data
        /// </summary>
        private void SetSprites()
        {
            foreach (SpriteType e in Enum.GetValues(typeof(SpriteType)))
                Sprites.Add(new Sprite(e));
        }

        /// <summary>
        /// Sets all character techniques and skills from initial levels and level data
        /// </summary>
        private void SetCharacterTechAndSkills()
        {
            int chazIndex = 0;
            int wrenIndex = 0;
            int demiIndex = 0;
            foreach (Character character in Characters)
            {
                // Get existing techniques and skills first
                int techIndex = 0;
                int skillIndex = 0;
                int[] techniques = new int[16] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                int[] skills = new int[8] { 0, 0, 0, 0, 0, 0, 0, 0 };
                foreach (int technique in character.TechniqueIDs)
                {
                    if (technique == 0)
                        break;

                    techniques[techIndex] = technique;
                    techIndex++;
                }
                foreach (int skill in character.SkillIDs)
                {
                    if (skill == 0)
                        continue;
                    skills[skillIndex] = skill;
                    skillIndex++;
                }

                // Set skills that the character will obtain from level gain
                foreach (CharacterLevel level in character.Levels)
                {
                    if (level.TechniqueID > 0 && level.TechniqueID < 99)
                    {
                        techniques[techIndex] = level.TechniqueID;
                        techIndex++;
                    }

                    if (level.SkillID > 0 && level.SkillID < 99)
                    {
                        skills[skillIndex] = level.SkillID;
                        skillIndex++;
                    }
                }

                if (character.ID == (int)CharacterType.Chaz)
                    chazIndex = techIndex;
                if (character.ID == (int)CharacterType.Wren)
                    wrenIndex = skillIndex;
                if (character.ID == (int)CharacterType.Demi)
                    demiIndex = skillIndex;

                character.TechniqueIDs = techniques.ToList();
                character.SkillIDs = skills.ToList();
            }

            // Add android skills that are later installed
            Characters[(int)CharacterType.Wren].SkillIDs[wrenIndex] = 32;
            Characters[(int)CharacterType.Wren].SkillIDs[wrenIndex + 1] = 14;
            Characters[(int)CharacterType.Wren].SkillIDs[wrenIndex + 2] = 15;
            Characters[(int)CharacterType.Demi].SkillIDs[demiIndex] = 17;
            Characters[(int)CharacterType.Chaz].TechniqueIDs[chazIndex] = 16;
        }

        private int SeekInt(int index,int length, byte[] data)
        {
            return ReadInt(ref index, length, data);
        }

        /// <summary>
        /// Reads an integer from the given data
        /// </summary>
        /// <param name="index">The index of the data to read</param>
        /// <param name="length">The size of the integer (1, 2, 4 supported)</param>
        /// <param name="data">The data to read</param>
        /// <returns>An integer value</returns>
        private int ReadInt(ref int index, int length, byte[] data)
        {
            byte[] val = new byte[length];
            Array.Copy(data, index, val, 0, length);
            index += length;
            switch (length)
            {
                case 1: return val[0];
                case 2: return (val[0] << 8) | val[1];
                case 4: return (val[0] << 24) | (val[1] << 16) | (val[2] << 8) | val[3];
                default: return 0;
            }
        }

        /// <summary>
        /// Gets a string based on the key mapping, from the given character map
        /// </summary>
        /// <param name="bytes">The character array</param>
        /// <param name="charMap">The character mapping to use for conversion</param>
        /// <returns>A converted character array</returns>
        private string GetString(byte[] bytes, Dictionary<byte, string> charMap)
        {
            string str = "";
            foreach (byte b in bytes)
            {
                charMap.TryGetValue(b, out string val);
                str += val;
            }
            return str;
        }

        /// <summary>
        /// Reads a chunk of bytes from rom data
        /// </summary>
        /// <param name="index">The starting point to read bytes</param>
        /// <param name="length">The amount of bytes to read</param>
        /// <returns>The read byte chunk</returns>
        public byte[] GetBytes(int index, int length)
        {
            byte[] bytes = new byte[length];
            for (int i = 0; i < length; i++)
                bytes[i] = Data[index + i];
            return bytes;
        }

        /// <summary>
        /// Reads a chunk of bytes from the given data source
        /// </summary>
        /// <param name="index">The starting point to read bytes</param>
        /// <param name="length">The amount of bytes to read</param>
        /// <param name="data">The data source to read from</param>
        /// <returns>The read byte chunk</returns>
        private byte[] GetBytes(int index, int length, byte[] data)
        {
            byte[] bytes = new byte[length];
            for (int i = 0; i < length; i++)
                bytes[i] = data[index + i];
            return bytes;
        }

        /// <summary>
        /// Decompresses the given range of bytes from the rom data
        /// </summary>
        /// <param name="type">Type of compression used</param>
        /// <param name="startAddress">The starting byte address of the data</param>
        /// <param name="length">The amount of bytes to decompress</param>
        /// <returns></returns>
        public byte[] Decompress(CompressionType type, int startAddress, int length)
        {
            return Decompress(type, GetBytes(startAddress, length, Data));
        }

        /// <summary>
        /// Decompresses the given bytes using the given decompression type
        /// </summary>
        /// <param name="type">The type of decompression algorithm to use</param>
        /// <param name="data">The data to decompress</param>
        /// <returns>Decompressed bytes</returns>
        private byte[] Decompress(CompressionType type, byte[] data)
        {
            switch (type)
            {
                case CompressionType.Kosinski: return Kosinski.Decompress(data);
                case CompressionType.KosinskiPlus: return KosinskiPlus.Decompress(data);
                case CompressionType.Nemesis: return Nemesis.Decompress(data);
                case CompressionType.Enigma: return Enigma.Decompress(data, Endianness.BigEndian);
                case CompressionType.Saxman: return Saxman.Decompress(data, data.Length);
                default: return data;
            }
        }

        /// <summary>
        /// Combines the given tileset ids into one tileset
        /// </summary>
        /// <param name="tilesetIDs">The tilesets to combine data for</param>
        /// <param name="name">Name of the combined tileset</param>
        /// <returns>A combined tileset</returns>
        public Tileset GetCombinedTileset(List<int> tilesetIDs, string name)
        {
            List<Tileset> tilesets = new List<Tileset>();
            Tileset combined = new Tileset();
            combined.Name = name;
            foreach (int id in tilesetIDs)
                tilesets.Add(Tilesets.Find(x => x.ID == id));

            foreach (Tileset tileset in tilesets)
            {
                if (tileset == null)
                    continue;
                combined.Pixels.AddRange(tileset.Pixels.ToArray());
                combined.Length += tileset.Length;
            }
            return combined.Pixels.Count <= 0 ? null : combined;
        }

        /// <summary>
        /// Gets a list of individual palettes (Broken out of the palette groups)
        /// </summary>
        /// <returns>A list of palettes</returns>
        public List<Palette> GetPalettes()
        {
            List<Palette> palettes = new List<Palette>();
            foreach (PaletteGroup group in PaletteGroups)
                foreach (Palette palette in group.Palettes)
                    palettes.Add(palette);
            return palettes;
        }

        /// <summary>
        /// Gets a list of tilesets from a list of tileset ids
        /// </summary>
        /// <param name="tilesetIDs">The tileser ids to get a list of</param>
        /// <returns>A list of tilesets</returns>
        public List<Tileset> GetTilesets(List<int> tilesetIDs)
        {
            List<Tileset> tilesets = new List<Tileset>();
            foreach (int id in tilesetIDs)
                tilesets.Add(Tilesets.Find(x => x.ID == id));
            return tilesets;
        }

        /// <summary>
        /// Gets a list of tile maps from a list of tile map ids
        /// </summary>
        /// <param name="tileMapIDs">The tile map ids to get a list of</param>
        /// <returns>A list of tile maps</returns>
        public List<TileMap> GetTileMaps(List<int> tileMapIDs)
        {
            List<TileMap> tileMaps = new List<TileMap>();
            foreach (int id in tileMapIDs)
                tileMaps.Add(TileMaps.Find(x => x.ID == id));
            return tileMaps;
        }

        /// <summary>
        /// Gets an enemy sprite image by enemy id
        /// </summary>
        /// <param name="id">Enemy id</param>
        /// <param name="frame">The frame to draw</param>
        /// <returns>An image of the given enemy</returns>
        public Bitmap GetSpriteImageByEnemyID(int id, int frame)
        {
            Enemy enemy = Enemies.Find(x => x.ID == id);
            if (enemy == null)
                return null;
            return GetSpriteImageByID(enemy.SpriteID, frame);
        }

        /// <summary>
        /// Gets an image of a sprite
        /// </summary>
        /// <param name="spriteID"></param>
        /// <param name="frame">The tile map index</param>
        /// <returns>An image of the given sprite</returns>
        public Bitmap GetSpriteImageByID(int spriteID, int frame)
        {
            Sprite sprite = Sprites.Find(x => x.ID == spriteID);
            if (sprite == null)
                return null;
            Tileset tileset = GetCombinedTileset(sprite.TilesetIDs, string.Empty);
            if (tileset == null)
                return null;
            TileMap tileMap = TileMaps.Find(x => x.ID == sprite.TileMapIDs[frame]);
            if (tileMap == null)
                return null;
            PaletteGroup group = PaletteGroups.Find(x => x.ID == sprite.PaletteGroupID);
            List<Color> colors = group == null ? PaletteGroups[0].Palettes[0].Colors : group.Palettes[sprite.PaletteIndex].Colors;
            return Sprite.GetImage(tileset, tileMap, colors);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="background"></param>
        /// <param name="formation"></param>
        /// <returns></returns>
        public Bitmap GetFormationImage(SpriteType background, Formation formation)
        {
            Bitmap bmp = new Bitmap(320, 224);
            using (Graphics gfx = Graphics.FromImage(bmp))
            {
                gfx.DrawImageUnscaled(GetSpriteImageByID((int)background, 0), Point.Empty);
                foreach (FormationEnemy enemy in formation.Enemies)
                {
                    using (Bitmap sprite = GetSpriteImageByEnemyID(enemy.ID, 0))
                    {
                        gfx.DrawImageUnscaled(sprite, new Point(enemy.X * 8 - (sprite.Width / 2), (bmp.Height / 2) - (sprite.Height / 2)));
                    }
                }
            }
            return bmp;
        }

        /// <summary>
        /// Gets a bool array of characters that are eligible to use certain equipment (TODO: Convert into enumeration)
        /// </summary>
        /// <param name="byte1">The first byte to read bit data from</param>
        /// <param name="byte2">The second byte to read bit data from</param>
        /// <returns>An array of character flags and if they're eligible for certain equipment</returns>
        private bool[] GetCharacterMask(byte byte1, byte byte2)
        {
            // TODO: Enumnerate this
            bool[] mask = new bool[11];
            mask[0] = (byte2 & (1 << 0)) != 0;
            mask[1] = (byte2 & (1 << 1)) != 0;
            mask[2] = (byte2 & (1 << 2)) != 0;
            mask[3] = (byte2 & (1 << 3)) != 0;
            mask[4] = (byte2 & (1 << 4)) != 0;
            mask[5] = (byte2 & (1 << 5)) != 0;
            mask[6] = (byte2 & (1 << 6)) != 0;
            mask[7] = (byte2 & (1 << 7)) != 0;
            mask[8] = (byte1 & (1 << 0)) != 0;
            mask[9] = (byte1 & (1 << 1)) != 0;
            mask[10] = (byte1 & (1 << 2)) != 0;
            return mask;
        }

        /// <summary>
        /// Gets colors from byte data
        /// </summary>
        private List<Color> GetColors(byte[] data)
        {
            int index = 0;
            List<Color> colors = new List<Color>();
            for (int i = 0; i < data.Length / 2; i++)
            {
                colors.Add(GetColor(data[index], data[index + 1]));
                index += 2;
            }
            return colors;
        }

        /// <summary>
        /// Gets a color from the given two bytes 0000BB0 GG0RR0 9 bit
        /// </summary>
        /// <param name="byte1">The lower byte</param>
        /// <param name="byte2">The upper byte</param>
        /// <returns>A .net color</returns>
        private Color GetColor(byte byte1, byte byte2)
        {
            byte r = (byte)((byte2 & (1 << 3)) | (byte2 & (1 << 2)) | (byte2 & (1 << 1)));
            byte g = (byte)(((byte2 & (1 << 7)) / 16) | ((byte2 & (1 << 6)) / 16) | ((byte2 & (1 << 5)) / 16));
            byte b = (byte)((byte1 & (1 << 3)) | (byte1 & (1 << 2)) | (byte1 & (1 << 1)));
            return Color.FromArgb(_colorValues[r], _colorValues[g], _colorValues[b]);
        }

        /// <summary>
        /// Bit test
        /// </summary>
        /// <param name="byte1">The lower byte</param>
        /// <param name="byte2">The upper byte</param>
        /// <returns>A string representation of the tile data</returns>
        private string GetTileMask(byte byte1, byte byte2)
        {
            string mask = "";
            mask += (byte1 & (1 << 0)) != 0 ? "1" : "0"; // Priority/ID + 256? (Seems like a flag to indicate tile ids that are larger than 255 eg: tileid = 7 + 256)
            mask += (byte1 & (1 << 1)) != 0 ? "1" : "0"; // Palette index?
            mask += (byte1 & (1 << 2)) != 0 ? "1" : "0"; // Palette index?
            mask += (byte1 & (1 << 3)) != 0 ? "1" : "0"; // X flip
            mask += (byte1 & (1 << 4)) != 0 ? "1" : "0"; // Y flip
            mask += (byte1 & (1 << 5)) != 0 ? "1" : "0"; // Part of tile ID?
            mask += (byte1 & (1 << 6)) != 0 ? "1" : "0"; // Part of tile ID?
            mask += (byte1 & (1 << 7)) != 0 ? "1" : "0"; // Part of tile ID?
            mask += " ";
            mask += (byte2 & (1 << 0)) != 0 ? "1" : "0"; // Tile ID
            mask += (byte2 & (1 << 1)) != 0 ? "1" : "0"; // Tile ID
            mask += (byte2 & (1 << 2)) != 0 ? "1" : "0"; // Tile ID
            mask += (byte2 & (1 << 3)) != 0 ? "1" : "0"; // Tile ID
            mask += (byte2 & (1 << 4)) != 0 ? "1" : "0"; // Tile ID
            mask += (byte2 & (1 << 5)) != 0 ? "1" : "0"; // Tile ID
            mask += (byte2 & (1 << 6)) != 0 ? "1" : "0"; // Tile ID
            mask += (byte2 & (1 << 7)) != 0 ? "1" : "0"; // Tile ID
            return mask;
        }

        /// <summary>
        /// Gets char key mappings
        /// </summary>
        /// <param name="type">Which type of char map</param>
        /// <returns>Character mapping dictionary</returns>
        public static Dictionary<byte, string> GetCharacterMap(int type)
        {
            Dictionary<byte, string> charMap = new Dictionary<byte, string>();
            switch (type)
            {
                case 0:
                    charMap.Add(0, " ");
                    for (byte i = 1; i < 27; i++)
                        charMap.Add(i, Encoding.ASCII.GetString(new byte[] { (byte)(i + 64) }));

                    for (byte i = 27; i < 37; i++)
                        charMap.Add(i, Encoding.ASCII.GetString(new byte[] { (byte)(i - 27 + 48) }));

                    for (byte i = 37; i < 47; i++)
                        charMap.Add(i, Encoding.ASCII.GetString(new byte[] { (byte)(i - 37 + 48) }));

                    charMap.Add(47, ".");
                    charMap.Add(48, "o");
                    charMap.Add(49, "-");
                    charMap.Add(50, "!");
                    charMap.Add(51, "?");

                    for (byte i = 57; i < 83; i++)
                        charMap.Add(i, Encoding.ASCII.GetString(new byte[] { (byte)(i - 57 + 97) }));

                    charMap.Add(83, ".");
                    charMap.Add(84, "'");
                    charMap.Add(85, ",");
                    charMap.Add(86, " ");
                    charMap.Add(87, "·");
                    charMap.Add(88, " ");
                    charMap.Add(89, " ");
                    break;

                case 1:
                    charMap.Add(0, " ");
                    for (byte i = 1; i < 27; i++)
                        charMap.Add(i, Encoding.ASCII.GetString(new byte[] { (byte)(i + 64) }));

                    for (byte i = 27; i < 53; i++)
                        charMap.Add(i, Encoding.ASCII.GetString(new byte[] { (byte)(i + 70) }));

                    charMap.Add(53, ".");
                    charMap.Add(54, "'");
                    charMap.Add(55, ",");
                    charMap.Add(56, "·");
                    charMap.Add(57, ":");
                    charMap.Add(58, "!");
                    charMap.Add(59, "?");
                    charMap.Add(60, "-");
                    charMap.Add(61, "«");
                    charMap.Add(62, "»");
                    charMap.Add(63, "%");

                    for (byte i = 64; i < 74; i++)
                        charMap.Add(i, Encoding.ASCII.GetString(new byte[] { (byte)(i - 16) }));
                    break;
            }

            charMap.Add((byte)DialogCodeType.NewLine, " ");
            return charMap;
        }

        /// <summary>
        /// Gets a mapping of valid RGB color values to 3bit color value
        /// </summary>
        /// <returns>A mapping of color values</returns>
        public static Dictionary<byte, byte> GetColorValues()
        {
            Dictionary<byte, byte> colorValues = new Dictionary<byte, byte>();
            colorValues.Add(0, 0);
            colorValues.Add(2, 52);
            colorValues.Add(4, 87);
            colorValues.Add(6, 116);
            colorValues.Add(8, 144);
            colorValues.Add(10, 172);
            colorValues.Add(12, 206);
            colorValues.Add(14, 255);
            return colorValues;
        }
    }
}
