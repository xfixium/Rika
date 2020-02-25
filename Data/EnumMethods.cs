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
using System.Linq;
using System.Drawing;
using System.ComponentModel;
using System.Collections.Generic;

namespace Rika.Data
{
    /// <summary>
    /// Static enumeration methods
    /// </summary>
    public static class EnumMethods
    {
        public static string[] GetEnumDescriptions(Type enumType)
        {
            List<string> descriptions = new List<string>();
            foreach (object value in Enum.GetValues(enumType))
            {
                object[] attributes = enumType.GetMember(value.ToString()).First().GetCustomAttributes(typeof(DescriptionAttribute), false);
                descriptions.Add((attributes[0] as DescriptionAttribute).Description);
            }
            return descriptions.ToArray();
        }

        public static string GetDescription(Type enumType, object value)
        {
            string name = value is int ? Enum.GetName(enumType, value) : value.ToString();
            if (enumType.GetMember(name).First().GetCustomAttributes(typeof(DescriptionAttribute), false).Length <= 0)
                return "";
            return (enumType.GetMember(name).First().GetCustomAttributes(typeof(DescriptionAttribute), false)[0] as DescriptionAttribute).Description;
        }

        public static int GetBytes(Type enumType, object value)
        {
            string name = value is int ? Enum.GetName(enumType, value) : value.ToString();
            if (enumType.GetMember(name).First().GetCustomAttributes(typeof(LengthAttribute), false).Length <= 0)
                return 0;
            return (enumType.GetMember(name).First().GetCustomAttributes(typeof(LengthAttribute), false)[0] as LengthAttribute).Length;
        }

        public static int GetColumns(Type enumType, object value)
        {
            string name = value is int ? Enum.GetName(enumType, value) : value.ToString();
            if (enumType.GetMember(name).First().GetCustomAttributes(typeof(ColumnsAttribute), false).Length <= 0)
                return 0;
            return (enumType.GetMember(name).First().GetCustomAttributes(typeof(ColumnsAttribute), false)[0] as ColumnsAttribute).Columns;
        }

        public static int GetRows(Type enumType, object value)
        {
            string name = value is int ? Enum.GetName(enumType, value) : value.ToString();
            if (enumType.GetMember(name).First().GetCustomAttributes(typeof(RowsAttribute), false).Length <= 0)
                return 0;
            return (enumType.GetMember(name).First().GetCustomAttributes(typeof(RowsAttribute), false)[0] as RowsAttribute).Rows;
        }

        public static int GetOffset(Type enumType, object value)
        {
            string name = value is int ? Enum.GetName(enumType, value) : value.ToString();
            if (enumType.GetMember(name).First().GetCustomAttributes(typeof(OffsetAttribute), false).Length <= 0)
                return 0;
            return (enumType.GetMember(name).First().GetCustomAttributes(typeof(OffsetAttribute), false)[0] as OffsetAttribute).Offset;
        }

        public static SectionType GetSection(Type enumType, object value)
        {
            string name = value is int ? Enum.GetName(enumType, value) : value.ToString();
            if (enumType.GetMember(name).First().GetCustomAttributes(typeof(SectionAttribute), false).Length <= 0)
                return SectionType.None;
            return (enumType.GetMember(name).First().GetCustomAttributes(typeof(SectionAttribute), false)[0] as SectionAttribute).Section;
        }

        public static SubSectionType GetSubSection(Type enumType, object value)
        {
            string name = value is int ? Enum.GetName(enumType, value) : value.ToString();
            if (enumType.GetMember(name).First().GetCustomAttributes(typeof(SubSectionAttribute), false).Length <= 0)
                return SubSectionType.None;
            return (enumType.GetMember(name).First().GetCustomAttributes(typeof(SubSectionAttribute), false)[0] as SubSectionAttribute).SubSection;
        }

        public static CompressionType GetCompression(Type enumType, object value)
        {
            string name = value is int ? Enum.GetName(enumType, value) : value.ToString();
            if (enumType.GetMember(name).First().GetCustomAttributes(typeof(CompressionAttribute), false).Length <= 0)
                return CompressionType.None;
            return (enumType.GetMember(name).First().GetCustomAttributes(typeof(CompressionAttribute), false)[0] as CompressionAttribute).Compression;
        }

        public static List<Color> GetColors(Type enumType, object value)
        {
            string name = value is int ? Enum.GetName(enumType, value) : value.ToString();
            if (enumType.GetMember(name).First().GetCustomAttributes(typeof(PaddedColorsAttribute), false).Length <= 0)
                return new List<Color>();
            return (enumType.GetMember(name).First().GetCustomAttributes(typeof(PaddedColorsAttribute), false)[0] as PaddedColorsAttribute).Colors;
        }

        public static int GetPaletteGroupID(Type enumType, object value)
        {
            string name = value is int ? Enum.GetName(enumType, value) : value.ToString();
            if (enumType.GetMember(name).First().GetCustomAttributes(typeof(PaletteGroupIDAttribute), false).Length <= 0)
                return 0;
            return (enumType.GetMember(name).First().GetCustomAttributes(typeof(PaletteGroupIDAttribute), false)[0] as PaletteGroupIDAttribute).ID;
        }

        public static int GetPaletteIndex(Type enumType, object value)
        {
            string name = value is int ? Enum.GetName(enumType, value) : value.ToString();
            if (enumType.GetMember(name).First().GetCustomAttributes(typeof(PaletteIndexAttribute), false).Length <= 0)
                return 0;
            return (enumType.GetMember(name).First().GetCustomAttributes(typeof(PaletteIndexAttribute), false)[0] as PaletteIndexAttribute).Index;
        }

        public static List<int> GetTilesetIDs(Type enumType, object value)
        {
            string name = value is int ? Enum.GetName(enumType, value) : value.ToString();
            if (enumType.GetMember(name).First().GetCustomAttributes(typeof(TilesetIDsAttribute), false).Length <= 0)
                return new List<int>();
            return (enumType.GetMember(name).First().GetCustomAttributes(typeof(TilesetIDsAttribute), false)[0] as TilesetIDsAttribute).IDs;
        }

        public static List<int> GetTileMapIDs(Type enumType, object value)
        {
            string name = value is int ? Enum.GetName(enumType, value) : value.ToString();
            if (enumType.GetMember(name).First().GetCustomAttributes(typeof(TileMapIDsAttribute), false).Length <= 0)
                return new List<int>();
            return (enumType.GetMember(name).First().GetCustomAttributes(typeof(TileMapIDsAttribute), false)[0] as TileMapIDsAttribute).IDs;
        }
    }

    /// <summary>
    /// Bytes attribute
    /// </summary>
    public sealed class LengthAttribute : Attribute
    {
        public int Length { get; set; }

        public LengthAttribute(int length)
        {
            Length = length;
        }
    }

    /// <summary>
    /// Columns attribute
    /// </summary>
    public sealed class ColumnsAttribute : Attribute
    {
        public int Columns { get; set; }

        public ColumnsAttribute(int columns)
        {
            Columns = columns;
        }
    }

    /// <summary>
    /// Columns attribute
    /// </summary>
    public sealed class RowsAttribute : Attribute
    {
        public int Rows { get; set; }

        public RowsAttribute(int rows)
        {
            Rows = rows;
        }
    }

    /// <summary>
    /// Columns attribute
    /// </summary>
    public sealed class OffsetAttribute : Attribute
    {
        public int Offset { get; set; }

        public OffsetAttribute(int offset)
        {
            Offset = offset;
        }
    }

    /// <summary>
    /// Section attribute
    /// </summary>
    public sealed class SectionAttribute : Attribute
    {
        public SectionType Section { get; set; }

        public SectionAttribute(SectionType section)
        {
            Section = section;
        }
    }

    /// <summary>
    /// Sub section attribute
    /// </summary>
    public sealed class SubSectionAttribute : Attribute
    {
        public SubSectionType SubSection { get; set; }

        public SubSectionAttribute(SubSectionType subSection)
        {
            SubSection = subSection;
        }
    }

    /// <summary>
    /// Columns attribute
    /// </summary>
    public sealed class CompressionAttribute : Attribute
    {
        public CompressionType Compression { get; set; }

        public CompressionAttribute(CompressionType compression)
        {
            Compression = compression;
        }
    }

    /// <summary>
    /// Colors attribute
    /// </summary>
    public sealed class PaddedColorsAttribute : Attribute
    {
        public List<Color> Colors { get; set; } = new List<Color>();

        public PaddedColorsAttribute(int[] colors)
        {
            foreach (int color in colors)
                Colors.Add(color == 0 ? Color.Black : Color.White);
        }
    }

    /// <summary>
    /// Pelette ID attribute
    /// </summary>
    public sealed class PaletteGroupIDAttribute : Attribute
    {
        public int ID { get; set; }

        public PaletteGroupIDAttribute(int id)
        {
            ID = id;
        }
    }

    /// <summary>
    /// Pelette index attribute
    /// </summary>
    public sealed class PaletteIndexAttribute : Attribute
    {
        public int Index { get; set; }

        public PaletteIndexAttribute(int index)
        {
            Index = index;
        }
    }

    /// <summary>
    /// Tileset IDs attribute
    /// </summary>
    public sealed class TilesetIDsAttribute : Attribute
    {
        public List<int> IDs { get; set; } = new List<int>();

        public TilesetIDsAttribute(int[] ids)
        {
            IDs.AddRange(ids);
        }
    }

    /// <summary>
    /// Tile map IDs attribute
    /// </summary>
    public sealed class TileMapIDsAttribute : Attribute
    {
        public List<int> IDs { get; set; } = new List<int>();

        public TileMapIDsAttribute(int[] ids)
        {
            IDs.AddRange(ids);
        }
    }
}
