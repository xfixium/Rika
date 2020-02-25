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
using System.Text;
using System.Linq;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Collections.Generic;

namespace Rika.Data
{
    /// <summary>
    /// Base class all game objects inherit from 
    /// </summary>
    public class ObjectID
    {
        /// <summary>
        /// Properties
        /// </summary>
        public int ID { get; set; } = -1;
        public string Name { get; set; } = "";
        public string CustomName { get; set; } = "";
        public int SpriteID { get; set; } = -1;
        public int DataStart { get; set; } = 0;
        public int DataEnd { get; set; } = 0;
        public int Length { get; set; } = 0;
        public int DecompressedLength { get; set; } = 0;
        public string DataStartString { get { return DataStart.ToString("X") + " (" + DataStart + ")"; } }
        public string DataEndString { get { return DataEnd.ToString("X") + " (" + DataEnd + ")"; } }
        public CompressionType Compression { get; set; } = CompressionType.None;
        public SectionType Section { get; set; } = SectionType.None;
        public SubSectionType SubSection { get; set; } = SubSectionType.None;

        /// <summary>
        /// Constructors
        /// </summary>
        public ObjectID() { }
        public ObjectID(int id, string customName) { ID = id; Name = customName; CustomName = customName;  }

        /// <summary>
        /// Creates a deep copy of the object
        /// </summary>
        /// <returns>A deep copy of the object</returns>
        public ObjectID Clone()
        {
            ObjectID clone = new ObjectID
            {
                ID = ID,
                Name = Name,
                CustomName = CustomName,
                SpriteID = SpriteID,
                DataStart = DataStart,
                DataEnd = DataEnd,
                Length = Length,
                DecompressedLength = DecompressedLength,
                Compression = Compression
            };
            return clone;
        }

        /// <summary>
        /// Overrides
        /// </summary>
        /// <returns>Custom name for this object</returns>
        public override string ToString()
        {
            return string.IsNullOrEmpty(Name) ? CustomName : Name;
        }
    }

    /// <summary>
    /// Sprite object (A combination of tile maps and tilesets to draw a graphic with a set palette)
    /// </summary>
    public class Sprite : ObjectID
    {
        /// <summary>
        /// Properties
        /// </summary>
        public int PaletteIndex { get; set; } = 0;
        public int PaletteGroupID { get; set; } = 0;
        public List<int> TilesetIDs { get; set; } = new List<int>();
        public List<int> TileMapIDs { get; set; } = new List<int>();

        /// <summary>
        /// Consrtuctors
        /// </summary>
        public Sprite() { }
        public Sprite(SpriteType type)
        {
            ID = (int)type;
            Name = EnumMethods.GetDescription(typeof(SpriteType), ID);
            CustomName = Name;
            PaletteGroupID = EnumMethods.GetPaletteGroupID(typeof(SpriteType), ID);
            PaletteIndex = EnumMethods.GetPaletteIndex(typeof(SpriteType), ID);
            TilesetIDs = EnumMethods.GetTilesetIDs(typeof(SpriteType), ID);
            TileMapIDs = EnumMethods.GetTileMapIDs(typeof(SpriteType), ID);
        }

        /// <summary>
        /// Gets an image of the sprite
        /// </summary>
        /// <param name="tileset">The tileset to draw tiles from (Most likely a combined tileset)</param>
        /// <param name="tileMap">The tilemap for the layout of the tiles</param>
        /// <param name="palette">The palette colors to use</param>
        /// <returns>An image of the sprite</returns>
        public static Bitmap GetImage(Tileset tileset, TileMap tileMap, List<Color> palette)
        {
            int tileSize = 8;
            Bitmap tiles = tileset.GetImageInline(palette);
            Bitmap bmp = new Bitmap(tileMap.Columns * tileSize, tileMap.Rows * tileSize);
            using (Graphics gfx = Graphics.FromImage(bmp))
            {
                gfx.SmoothingMode = SmoothingMode.None;
                gfx.InterpolationMode = InterpolationMode.NearestNeighbor;
                for (int row = 0; row < tileMap.Rows; row++)
                {
                    for (int col = 0; col < tileMap.Columns; col++)
                    {
                        int index = (tileMap.Columns * row) + col;
                        if (index >= tileMap.Tiles.Count)
                            break;
                        int tileID = tileMap.Tiles[index].TileID;
                        if (tileMap.Tiles[index].Offset && tileMap.Tiles[index].Mask != 197)
                            tileID += 256;
                        if (tileMap.Tiles[index].Mask == 197)
                            tileID -= tileMap.Offset;
                        Point dest = new Point(col * tileSize, row * tileSize);
                        Rectangle src = new Rectangle(tileID * tileSize, 0, tileSize, tileSize);
                        if (src.X + tileSize > tiles.Width || src.X < 0)
                            break;
                        using (Bitmap tile = tiles.Clone(src, tiles.PixelFormat))
                        {
                            if (tileMap.Tiles[index].FlipX)
                                tile.RotateFlip(RotateFlipType.RotateNoneFlipX);
                            if (tileMap.Tiles[index].FlipY)
                                tile.RotateFlip(RotateFlipType.RotateNoneFlipY);
                            gfx.DrawImageUnscaled(tile, dest);
                        }
                    }
                }
            }
            tiles.Dispose();
            return bmp;
        }
    }

    /// <summary>
    /// Tileset object
    /// </summary>
    public class Tileset : ObjectID
    {
        /// <summary>
        /// Properties
        /// </summary>
        public int TileCount { get { return Pixels.Count <= 0 ? 0 : Pixels.Count / 64; } }
        public List<byte> Pixels { get; set; } = new List<byte>();
        public PixelFormatType PixelFormat { get; set; } = PixelFormatType.FourLinear;

        /// <summary>
        /// Constructors
        /// </summary>
        public Tileset() { }
        public Tileset(TilesetType type)
        {
            ID = (int)type;
            Name = EnumMethods.GetDescription(typeof(TilesetType), (int)type);
            DataStart = ID;
            Length = EnumMethods.GetBytes(typeof(TilesetType), (int)type);
            DataEnd = DataStart + Length;
            Section = EnumMethods.GetSection(typeof(TilesetType), (int)type);
            SubSection = EnumMethods.GetSubSection(typeof(TilesetType), (int)type);
            Compression = EnumMethods.GetCompression(typeof(TilesetType), (int)type);
        }

        /// <summary>
        /// Gets the tileset as an image
        /// </summary>
        /// <param name="scale">Scaling of the image</param>
        /// <param name="palette">The palette colors to use</param>
        /// <returns>An image of the tileset data</returns>
        public Bitmap GetImage(int scale, List<Color> palette)
        {
            int tileID = 0;
            int tileSize = 8;
            int tilesX = 16;
            int tilesY = (TileCount / tilesX) + 1;
            Bitmap tiles = GetImageInline(palette);
            Bitmap bmp = new Bitmap(tilesX * tileSize * scale, tilesY * tileSize * scale);
            using (Graphics gfx = Graphics.FromImage(bmp))
            {
                gfx.ScaleTransform(scale, scale);
                gfx.PixelOffsetMode = PixelOffsetMode.Half;
                gfx.SmoothingMode = SmoothingMode.None;
                gfx.InterpolationMode = InterpolationMode.NearestNeighbor;
                using (SolidBrush brush = new SolidBrush(Color.Empty))
                {
                    for (int row = 0; row < tilesY; row++)
                    {
                        for (int col = 0; col < tilesX; col++)
                        {
                            Rectangle dest = new Rectangle(col * tileSize, row * tileSize, tileSize, tileSize);
                            Rectangle src = new Rectangle(tileID * tileSize, 0, tileSize, tileSize);
                            if (src.X + tileSize > tiles.Width)
                                break;

                            gfx.DrawImage(tiles, dest, src, GraphicsUnit.Pixel);
                            tileID++;
                        }
                    }
                }
            }
            tiles.Dispose();
            return bmp;
        }

        /// <summary>
        /// Gets the tileset as an image, with the tile IDs overlayed
        /// </summary>
        /// <param name="palette">The palette colors to use</param>
        /// <returns>An image of the tileset data</returns>
        public Bitmap GetImageWithIDs(List<Color> palette)
        {
            int tileID = 0;
            int scale = 3;
            int tileSize = 8;
            int tilesX = 16;
            int tilesY = (TileCount / tilesX) + 1;
            Font font = new Font("Segoe UI", 8);
            StringFormat format = new StringFormat();
            format.LineAlignment = StringAlignment.Center;
            format.Alignment = StringAlignment.Center;
            Bitmap tiles = GetImageInline(128, palette);
            Bitmap bmp = new Bitmap(tilesX * tileSize * scale, tilesY * tileSize * scale);
            using (Graphics gfx = Graphics.FromImage(bmp))
            {
                gfx.ScaleTransform(scale, scale);
                gfx.PixelOffsetMode = PixelOffsetMode.Half;
                gfx.SmoothingMode = SmoothingMode.None;
                gfx.InterpolationMode = InterpolationMode.NearestNeighbor;
                for (int row = 0; row < tilesY; row++)
                {
                    for (int col = 0; col < tilesX; col++)
                    {
                        Rectangle dest = new Rectangle(col * tileSize, row * tileSize, tileSize, tileSize);
                        Rectangle src = new Rectangle(tileID * tileSize, 0, tileSize, tileSize);
                        if (src.X + tileSize > tiles.Width)
                            break;

                        gfx.DrawImage(tiles, dest, src, GraphicsUnit.Pixel);
                        tileID++;
                    }
                }
                gfx.ResetTransform(); // Loop redundancy because switching tranforms was causing issues for font drawing
                tileID = 0;
                for (int row = 0; row < tilesY; row++)
                {
                    for (int col = 0; col < tilesX; col++)
                    {
                        if (tileID >= TileCount)
                            break;
                        int x = col * tileSize * scale;
                        int y = row * tileSize * scale;
                        RectangleF rect = new RectangleF(x, y, tileSize * scale, tileSize * scale);
                        gfx.DrawString(tileID.ToString(), font, Brushes.Black, rect, format);
                        tileID++;
                    }
                }
            }
            tiles.Dispose();
            return bmp;
        }

        /// <summary>
        /// Gets a tileset image, formatted in a single strip, with no alpha
        /// </summary>
        /// <param name="palette">The palette colors to use</param>
        /// <returns>An image of the tileset data</returns>
        public Bitmap GetImageInline(List<Color> palette)
        {
            return GetImageInline(255, palette);
        }

        /// <summary>
        /// Gets the tileset as an image, formatted in a single strip
        /// </summary>
        /// <param name="palette">The palette colors to use</param>
        /// <returns>An image of the tileset data</returns>
        public Bitmap GetImageInline(int alpha, List<Color> palette)
        {
            int tileID = 0;
            int pixel = 0;
            int tileSize = 8;
            int tilesX = TileCount;
            Bitmap bmp = new Bitmap(tilesX * tileSize, tileSize);
            using (Graphics gfx = Graphics.FromImage(bmp))
            {
                using (SolidBrush brush = new SolidBrush(Color.Empty))
                {
                    for (int col = 0; col < tilesX; col++)
                    {
                        for (int y = 0; y < tileSize; y++)
                        {
                            for (int x = 0; x < tileSize; x++)
                            {
                                if (pixel >= Pixels.Count)
                                    break;
                                if (Pixels[pixel] != 0 && Pixels[pixel] < palette.Count)
                                {
                                    brush.Color = Color.FromArgb(alpha, palette[Pixels[pixel]]);
                                    gfx.FillRectangle(brush, (col * tileSize) + x, y, 1, 1);
                                }
                                pixel++;
                            }
                        }
                        if (tileID >= Pixels.Count / 64)
                            break;

                        int x2 = col * tileSize;
                        int size = tileSize;
                        tileID++;
                    }
                }
            }
            return bmp;
        }
    }

    /// <summary>
    /// Tilemap object
    /// </summary>
    public class TileMap : ObjectID
    {
        /// <summary>
        /// Properties
        /// </summary>
        public int Columns { get; set; } = 8;
        public int Rows { get; set; } = 8;
        public int Offset { get; set; } = 0;
        public bool UseFlags { get; set; } = true;
        public List<Tile> Tiles { get; set; } = new List<Tile>();

        /// <summary>
        /// Constructors
        /// </summary>
        public TileMap() { }
        public TileMap(TileMapType type)
        {
            ID = (int)type;
            Name = EnumMethods.GetDescription(typeof(TileMapType), ID);
            Length = EnumMethods.GetBytes(typeof(TileMapType), ID);
            DataStart = ID;
            DataEnd = DataStart + Length;
            Columns = EnumMethods.GetColumns(typeof(TileMapType), ID);
            Rows = EnumMethods.GetRows(typeof(TileMapType), ID);
            Offset = EnumMethods.GetOffset(typeof(TileMapType), ID);
            Compression = EnumMethods.GetCompression(typeof(TileMapType), ID);
        }

        /// <summary>
        /// Gets the tile map as an image, with no tileset reference
        /// </summary>
        /// <param name="columns">The width of the image, in tiles</param>
        /// <param name="rows">The height of the image, in tiles</param>
        /// <param name="ignoreIdZero">Whether or not to draw tiles with a tile id of zero (Helps visualize the map if empty tiles are not drawn)</param>
        /// <returns>An image of the tile map</returns>
        public Bitmap GetImage(int columns, int rows, bool ignoreIdZero)
        {
            int scale = 4;
            int tileSize = 8;
            Font font = new Font("Segoe UI", 8);
            StringFormat format = new StringFormat();
            format.LineAlignment = StringAlignment.Center;
            format.Alignment = StringAlignment.Center;
            Bitmap bmp = new Bitmap((columns * tileSize) * scale + 1, (rows * tileSize) * scale + 1);
            using (Graphics gfx = Graphics.FromImage(bmp))
            {
                gfx.ScaleTransform(scale, scale);
                gfx.SmoothingMode = SmoothingMode.None;
                gfx.InterpolationMode = InterpolationMode.NearestNeighbor;
                for (int row = 0; row < rows; row++)
                {
                    for (int col = 0; col < columns; col++)
                    {
                        int index = (columns * row) + col;
                        int tileID = 0;
                        if (index < Tiles.Count)
                            tileID = Tiles[index].TileID;
                        if (ignoreIdZero && tileID == 0)
                            continue;
                        Rectangle dest = new Rectangle(col * tileSize, row * tileSize, tileSize, tileSize);
                        gfx.DrawRectangle(Pens.Black, dest);
                    }
                }
                gfx.ResetTransform(); // Loop redundancy because switching tranforms was causing issues for font drawing
                for (int row = 0; row < rows; row++)
                {
                    for (int col = 0; col < columns; col++)
                    {
                        int index = (columns * row) + col;
                        if (index >= Tiles.Count)
                            break;
                        int tileID = Tiles[index].TileID;
                        if (ignoreIdZero && tileID == 0)
                            continue;
                        int x = col * tileSize * scale;
                        int y = row * tileSize * scale;
                        RectangleF rect = new RectangleF(x, y, tileSize * scale, tileSize * scale);
                        string text = tileID.ToString() + Environment.NewLine + Tiles[index].Mask;
                        gfx.DrawString(text, font, Brushes.Black, rect, format);
                    }
                }
            }
            return bmp;
        }

        /// <summary>
        /// Gets the tile map as an image, with a tileset reference
        /// </summary>
        /// <param name="columns">The width of the image, in tiles</param>
        /// <param name="rows">The height of the image, in tiles</param>
        /// <param name="tileset">The tileset to use as the background image (50% opacity)</param>
        /// <param name="palette">The palette used for the tileset</param>
        /// <returns>An image of the tile map, with numerics for each tile, representing the tile id and flag values</returns>
        public Bitmap GetImageWithTileset(int columns, int rows, Tileset tileset, List<Color> palette, bool ignoreIdZero)
        {
            int scale = 4;
            int tileSize = 8;
            Font font = new Font("Segoe UI", 8);
            StringFormat format = new StringFormat();
            format.LineAlignment = StringAlignment.Center;
            format.Alignment = StringAlignment.Center;
            Bitmap tiles = tileset.GetImageInline(128, palette);
            Bitmap bmp = new Bitmap((columns * tileSize) * scale + 1, (rows * tileSize) * scale + 1);
            using (Graphics gfx = Graphics.FromImage(bmp))
            {
                gfx.ScaleTransform(scale, scale);
                gfx.SmoothingMode = SmoothingMode.None;
                gfx.InterpolationMode = InterpolationMode.NearestNeighbor;
                for (int row = 0; row < rows; row++)
                {
                    for (int col = 0; col < columns; col++)
                    {
                        int index = (columns * row) + col;
                        if (index >= Tiles.Count)
                            break;
                        int tileID = Tiles[index].TileID;
                        if (ignoreIdZero && tileID == 0)
                            continue;
                        if (Tiles[index].Offset && Tiles[index].Mask != 197)
                            tileID += 256;
                        if (Tiles[index].Mask == 197)
                            tileID -= Offset;
                        Rectangle dest = new Rectangle(col * tileSize, row * tileSize, tileSize, tileSize);
                        Rectangle src = new Rectangle(tileID * tileSize, 0, tileSize, tileSize);
                        if (src.X + tileSize > tiles.Width)
                            break;

                        using (Bitmap tile = tiles.Clone(src, tiles.PixelFormat))
                        {
                            if (Tiles[index].FlipX)
                                tile.RotateFlip(RotateFlipType.RotateNoneFlipX);
                            if (Tiles[index].FlipY)
                                tile.RotateFlip(RotateFlipType.RotateNoneFlipY);
                            gfx.DrawImageUnscaled(tile, dest);
                        }
                    }
                }
                gfx.ResetTransform();  // Loop redundancy because switching tranforms was causing issues for font drawing
                for (int row = 0; row < rows; row++)
                {
                    for (int col = 0; col < columns; col++)
                    {
                        int index = (columns * row) + col;
                        if (index >= Tiles.Count)
                            break;
                        int tileID = Tiles[index].TileID;
                        if (ignoreIdZero && tileID == 0)
                            continue;
                        if (Tiles[index].Mask == 197)
                            tileID -= 128;
                        int x = col * tileSize * scale;
                        int y = row * tileSize * scale;
                        RectangleF rect = new RectangleF(x, y, tileSize * scale, tileSize * scale);
                        string text = tileID.ToString() + Environment.NewLine + Tiles[index].Mask;
                        gfx.DrawString(text, font, Brushes.Black, rect, format);
                    }
                }
            }
            tiles.Dispose();
            return bmp;
        }
    }

    /// <summary>
    /// Tile of a tile map
    /// </summary>
    public class Tile
    {
        /// <summary>
        /// Properties
        /// </summary>
        public int TileID { get; set; }
        public int PaletteIndex { get; set; } = 0;
        public int Mask { get; set; }
        public bool Offset { get; set; }
        public bool Offset2 { get; set; }
        public bool FlipX { get; set; }
        public bool FlipY { get; set; }
        public string Bits { get; set; }

        /// <summary>
        /// Overrides
        /// </summary>
        /// <returns>A custom name for this object</returns>
        public override string ToString()
        {
            return TileID + ", " + Mask;
        }
    }

    /// <summary>
    /// Collection of palettes object
    /// </summary>
    public class PaletteGroup : ObjectID
    {
        /// <summary>
        /// Properties
        /// </summary>
        public List<Color> PaddedColors { get; set; } = new List<Color>();
        public List<Palette> Palettes { get; set; } = new List<Palette>();

        /// <summary>
        /// Constructors
        /// </summary>
        public PaletteGroup() { }
        public PaletteGroup(PaletteType type)
        {
            ID = (int)type;
            Name = EnumMethods.GetDescription(typeof(PaletteType), ID);
            CustomName = Name;
            DataStart = ID;
            Length = EnumMethods.GetBytes(typeof(PaletteType), ID);
            PaddedColors = EnumMethods.GetColors(typeof(PaletteType), ID);
        }

        /// <summary>
        /// Inserts the padded colors to the beginning of every palette under the group
        /// </summary>
        public void SetPaddedColors()
        {
            foreach (Palette palette in Palettes)
                foreach (Color color in PaddedColors)
                    palette.Colors.Insert(0, color);
        }

        /// <summary>
        /// Gets an image of all the palettes the group contains
        /// </summary>
        /// <returns>Palette colors image</returns>
        public Bitmap GetPaletteGroupImage()
        {
            int yOffset = 0;
            Bitmap bmp = new Bitmap(232, 16 * Palettes.Count);
            bmp.SetResolution(72, 72);
            using (Graphics gfx = Graphics.FromImage(bmp))
            {
                gfx.InterpolationMode = InterpolationMode.NearestNeighbor;
                using (SolidBrush brush = new SolidBrush(Color.Black))
                {
                    foreach (Palette palette in Palettes)
                    {
                        using (Bitmap image = palette.GetPaletteImage())
                        {
                            gfx.DrawImageUnscaled(image, 0, yOffset);
                        }
                        yOffset += 16;
                    }
                }
            }
            return bmp;
        }
    }

    /// <summary>
    /// Palette object
    /// </summary>
    public class Palette : ObjectID
    {
        /// <summary>
        /// Properties
        /// </summary>
        public List<Color> Colors { get; set; } = new List<Color>();
        public Bitmap PaletteImage { get { return GetPaletteImage(); } }

        /// <summary>
        /// Constructors
        /// </summary>
        public Palette() { }
        public Palette(string name, List<Color> colors)
        {
            Name = name;
            CustomName = Name;
            Colors = colors;
        }

        /// <summary>
        /// Gets an image of palette colors
        /// </summary>
        /// <returns>Palette colors image</returns>
        public Bitmap GetPaletteImage()
        {
            Bitmap bmp = new Bitmap(232, 16);
            int xOffset = 4;
            bmp.SetResolution(72, 72);
            using (Graphics gfx = Graphics.FromImage(bmp))
            {
                gfx.InterpolationMode = InterpolationMode.NearestNeighbor;
                using (SolidBrush brush = new SolidBrush(Color.Black))
                {
                    foreach (Color color in Colors)
                    {
                        brush.Color = color;
                        gfx.FillRectangle(Brushes.Black, xOffset + 1, 2, 12, 12);
                        gfx.FillRectangle(Brushes.White, xOffset + 2, 3, 10, 10);
                        gfx.FillRectangle(brush, xOffset + 3, 4, 8, 8);
                        xOffset += 14;
                    }
                }
            }
            return bmp;
        }
    }

    /// <summary>
    /// Map object
    /// </summary>
    public class Map : ObjectID
    {
        /// <summary>
        /// Properties
        /// </summary>
        public int ParentMapID { get; set; }
        public int MusicID { get; set; }
        public int DialogGroupID { get; set; }
        public int PaletteGroupID { get; set; }
        public List<int> EventIDs { get; set; } = new List<int>();
        public List<int> TilesetIDs { get; set; } = new List<int>();
        public List<int> TileMapIDs { get; set; } = new List<int>();
        public List<int> Updates { get; set; } = new List<int>();
        public List<int> AnimatedTileIDs { get; set; } = new List<int>();
        public List<int> MapMethodIDs { get; set; } = new List<int>();
        public List<MapTransition> Transitions { get; set; } = new List<MapTransition>();
        public List<MapObject> Objects { get; set; } = new List<MapObject>();
        public List<MapChest> Chests { get; set; } = new List<MapChest>();
        public List<MapArea> Areas { get; set; } = new List<MapArea>();
        public List<int> UnknownBytes { get; set; } = new List<int>();

        /// <summary>
        /// Constructors
        /// </summary>
        public Map() { }
        public Map(string name, int id, int dataStart)
        {
            Name = name; ID = id;
            DataStart = dataStart;
        }
    }

    /// <summary>
    /// Map transition object
    /// </summary>
    public class MapTransition : ObjectID
    {
        /// <summary>
        /// Properties
        /// </summary>
        public int X { get; set; }
        public int Y { get; set; }
        public int Size { get; set; }
        public int TargetMapID { get; set; }
        public int TileX { get; set; }
        public int TileY { get; set; }
        public int Facing { get; set; }
        public int CharacterAlignment { get; set; }
    }

    /// <summary>
    /// Map object object
    /// </summary>
    public class MapObject : ObjectID
    {
        /// <summary>
        /// Properties
        /// </summary>
        public int TableID { get; set; }
        public int Facing { get; set; }
        public int DialogID { get; set; }
        public int TileID { get; set; }
        public int TileX { get; set; }
        public int TileY { get; set; }
    }

    /// <summary>
    /// Map treasure chest object
    /// </summary>
    public class MapChest : ObjectID
    {
        /// <summary>
        /// Properties
        /// </summary>
        public int X { get; set; }
        public int Y { get; set; }
        public int ItemID { get; set; }
        public int FlagConstentID { get; set; }
        public int Content { get; set; }
        public MapChestType Type { get; set; }
        public MapChestContentType ContentType { get; set; }
    }

    /// <summary>
    /// Map interactive area object
    /// </summary>
    public class MapArea : ObjectID
    {
        /// <summary>
        /// Properties
        /// </summary>
        public int X { get; set; }
        public int Y { get; set; }
        public int Size { get; set; }
        public MapAreaEventType EventType { get; set; }
        public int FlagConstentID { get; set; }
        public int MethodIndex { get; set; }
        public int MethodValue { get; set; }
    }

    /// <summary>
    /// A collection of dialogs
    /// </summary>
    public class DialogGroup : ObjectID
    {
        /// <summary>
        /// Properties
        /// </summary>
        public int Owner { get; set; }
        public List<Dialog> Conversations { get; set; } = new List<Dialog>();

        /// <summary>
        /// Constructors
        /// </summary>
        public DialogGroup() { }
        public DialogGroup(DialogGroupType type)
        {
            ID = (int)type;
            Name = EnumMethods.GetDescription(typeof(DialogGroupType), ID);
            CustomName = Name;
            DataStart = ID;
            Length = EnumMethods.GetBytes(typeof(DialogGroupType), ID);
        }

        /// <summary>
        /// To string override
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Dialog conversation in Conversations)
            {
                foreach (DialogLine line in conversation.Lines)
                    sb.AppendLine((CharacterDialogType)line.ID + ": " + line.Text);
                sb.AppendLine("");
            }
            return sb.ToString().Trim();
        }
    }

    /// <summary>
    /// A dialog of lines
    /// </summary>
    public class Dialog : ObjectID
    {
        /// <summary>
        /// Properties
        /// </summary>
        public List<DialogLine> Lines { get; set; } = new List<DialogLine>();

        /// <summary>
        /// Constructors
        /// </summary>
        public Dialog(int id) { ID = id; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (DialogLine line in Lines)
                sb.AppendLine(line.Text);
            return sb.ToString();
        }
    }

    /// <summary>
    /// A line of a dialog
    /// </summary>
    public class DialogLine : ObjectID
    {
        /// <summary>
        /// Properties
        /// </summary>
        public string Text { get; set; } = "";
        public int Terminator { get; set; }

        /// <summary>
        /// Constructors
        /// </summary>
        public DialogLine() { }
        public DialogLine(int id, string line, int terminator) { ID = id; Text = line; Terminator = terminator; }

        /// <summary>
        /// Overrides
        /// </summary>
        /// <returns>A custom name for the object</returns>
        public override string ToString()
        {
            return Text;
        }
    }

    /// <summary>
    /// Character object
    /// </summary>
    public class Character : ObjectID
    {
        /// <summary>
        /// Properties
        /// </summary>
        public List<CharacterLevel> Levels { get; set; } = new List<CharacterLevel>();
        public int FirstLevel { get; set; }
        public CharacterProfessionType Profession { get; set; }
        public List<int> EquipmentIDs { get; set; } = Enumerable.Range(0, 4).Select(i => new int()).ToList();  // right hand, left hand, head, body
        public List<ResistanceType> Resistances { get; set; } = Enumerable.Range(0, 14).Select(i => new ResistanceType()).ToList();
        public List<int> TechniqueIDs { get; set; } = Enumerable.Range(0, 16).Select(i => new int()).ToList();
        public List<int> SkillIDs { get; set; } = Enumerable.Range(0, 8).Select(i => new int()).ToList();
        public ResistanceType PhysicalResistance { get { return Resistances[0]; } }
        public ResistanceType RadiationResistance { get { return Resistances[1]; } }
        public ResistanceType FireResistance { get { return Resistances[2]; } }
        public ResistanceType GravityResistance { get { return Resistances[3]; } }
        public ResistanceType WaterResistance { get { return Resistances[4]; } }
        public ResistanceType EnergyResistance { get { return Resistances[5]; } }
        public ResistanceType ElectricResistance { get { return Resistances[6]; } }
        public ResistanceType HolyResistance { get { return Resistances[7]; } }
        public ResistanceType DeathResistance { get { return Resistances[8]; } }
        public ResistanceType BiologicalResistance { get { return Resistances[9]; } }
        public ResistanceType PsychicResistance { get { return Resistances[10]; } }
        public ResistanceType MechanicalResistance { get { return Resistances[11]; } }
        public ResistanceType LightResistance { get { return Resistances[12]; } }
        public ResistanceType DestroyResistance { get { return Resistances[13]; } }
    }

    /// <summary>
    /// Character level object
    /// </summary>
    public class CharacterLevel : ObjectID
    {
        /// <summary>
        /// Properties
        /// </summary>
        public int Exp { get; set; }
        public int HP { get; set; }
        public int TP { get; set; }
        public int Strength { get; set; }
        public int Mental { get; set; }
        public int Agility { get; set; }
        public int Dexterity { get; set; }
        public int TechniqueID { get; set; }
        public string TechniqueName { get; set; }
        public int SkillID { get; set; }
        public string SkillName { get; set; }
        public int SkillCount1 { get; set; } = 0;
        public int SkillCount2 { get; set; } = 0;
        public int SkillCount3 { get; set; } = 0;
        public int SkillCount4 { get; set; } = 0;
        public int SkillCount5 { get; set; } = 0;
        public int SkillCount6 { get; set; } = 0;
        public int SkillCount7 { get; set; } = 0;
        public int SkillCount8 { get; set; } = 0;
    }

    /// <summary>
    /// Technique object
    /// </summary>
    public class Technique : ObjectID
    {
        /// <summary>
        /// Properties
        /// </summary>
        public EffectType Effect { get; set; }
        public int TPCost { get; set; }
        public EffectTargetType Target { get; set; }
        public int EffectAmount { get; set; }
        public EffectAreaType EffectArea { get; set; }
        public EffectStatType Defense { get; set; }
        public ElementType Element { get; set; }

        /// <summary>
        /// Constructors
        /// </summary>
        public Technique() { }
        public Technique(int id, string name) { ID = id; CustomName = name; Name = name; }
    }

    /// <summary>
    /// Skill object
    /// </summary>
    public class Skill : ObjectID
    {
        /// <summary>
        /// Properties
        /// </summary>
        public EffectType Effect { get; set; }
        public EffectStatType Offense { get; set; }
        public EffectTargetType Target { get; set; }
        public EffectAreaType EffectArea { get; set; }
        public int EffectAmount { get; set; }
        public EffectStatType Defense { get; set; }
        public ElementType Element { get; set; }

        /// <summary>
        /// Constructors
        /// </summary>
        public Skill() { }
        public Skill(int id, string name) { ID = id; CustomName = name; Name = name; }
    }

    /// <summary>
    /// Combination collection object
    /// </summary>
    public class CombinationCollection : ObjectID
    {
        /// <summary>
        /// Properties
        /// </summary>
        public EffectType Effect { get; set; }
        public EffectTargetType Target { get; set; }
        public int EffectChance { get; set; }
        public int PartCount { get; set; }
        public bool OrderSensitive { get; set; }
        public EffectStatType Defense { get; set; }
        public ElementType Element { get; set; }
        public List<Combination> Combination { get; set; } = new List<Combination>();
    }

    /// <summary>
    /// Combination object
    /// </summary>
    public class Combination : ObjectID
    {
        /// <summary>
        /// Properties
        /// </summary>
        public List<CombinationPart> PartIDs { get; set; } = new List<CombinationPart>();

        public override string ToString()
        {
            string name = "";
            foreach (CombinationPart part in PartIDs)
                name += part.Name + ", ";
            return name.Trim().Trim(',');
        }
    }

    /// <summary>
    /// Combination part object
    /// </summary>
    public class CombinationPart : ObjectID
    {
        /// <summary>
        /// Properties
        /// </summary>
        public ComboPartType Type { get; set; }
    }

    /// <summary>
    /// Enemy object
    /// </summary>
    public class Enemy : ObjectID
    {
        /// <summary>
        /// Properties
        /// </summary>
        public int HP { get; set; }
        public ElementType AttackElement { get; set; }
        public StatusEffectType StatusEffect { get; set; }
        public int Strength { get; set; }
        public int Mental { get; set; }
        public int Agility { get; set; }
        public int Dexterity { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int MagicDefense { get; set; }
        public int Exp { get; set; }
        public int Meseta { get; set; }
        public List<int> ActionIDs { get; set; } = Enumerable.Range(0, 8).Select(i => new int()).ToList();
        public List<ResistanceType> Resistances { get; set; } = Enumerable.Range(0, 14).Select(i => new ResistanceType()).ToList();
        public List<Condition> Conditions { get; set; } = Enumerable.Range(0, 4).Select(i => new Condition()).ToList();
        public ResistanceType PhysicalResistance { get { return Resistances[0]; } }
        public ResistanceType RadiationResistance { get { return Resistances[1]; } }
        public ResistanceType FireResistance { get { return Resistances[2]; } }
        public ResistanceType GravityResistance { get { return Resistances[3]; } }
        public ResistanceType WaterResistance { get { return Resistances[4]; } }
        public ResistanceType EnergyResistance { get { return Resistances[5]; } }
        public ResistanceType ElectricResistance { get { return Resistances[6]; } }
        public ResistanceType HolyResistance { get { return Resistances[7]; } }
        public ResistanceType DeathResistance { get { return Resistances[8]; } }
        public ResistanceType BiologicalResistance { get { return Resistances[9]; } }
        public ResistanceType PsychicResistance { get { return Resistances[10]; } }
        public ResistanceType MechanicalResistance { get { return Resistances[11]; } }
        public ResistanceType LightResistance { get { return Resistances[12]; } }
        public ResistanceType DestroyResistance { get { return Resistances[13]; } }
        public int ResistanceScore { get; set; }
        public string ResistanceGrade { get; set; }
    }

    /// <summary>
    /// Enemy condition object
    /// </summary>
    public class Condition
    {
        /// <summary>
        /// Properties
        /// </summary>
        public TriggerType Trigger;
        public int ActionID;

        /// <summary>
        /// Constructors
        /// </summary>
        public Condition() { }
        public Condition(TriggerType trigger) { Trigger = trigger; }
    }

    /// <summary>
    /// Enemy formation object
    /// </summary>
    public class Formation : ObjectID
    {
        /// <summary>
        /// Properties
        /// </summary>
        public int SurpriseRate { get; set; }  // ([Highest Party Agility]-SurpriseRate) + Random(64) (<= 12) = Ambush, (12 and <= 116) = Normal,  (> 116) = Surprise
        public int EscapeRate { get; set; }    // (> 40) = Escape
        public int ItemDropRate { get; set; }
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public int EnemyCount { get; set; }
        public int Group1Mask { get; set; }
        public int Group2Mask { get; set; }
        public List<FormationEnemy> Enemies { get; set; } = new List<FormationEnemy>();
    }

    /// <summary>
    /// Enemy battle position object
    /// </summary>
    public class FormationEnemy
    {
        /// <summary>
        /// Properties
        /// </summary>
        public int ID { get; set; }
        public int X { get; set; }  // Pixel position: (X * 8) + 128
    }

    /// <summary>
    /// Item object
    /// </summary>
    public class Item : ObjectID
    {
        /// <summary>
        /// Properties
        /// </summary>
        public string Description { get; set; }
        public EffectType Effect { get; set; }
        public string EffectName { get { return EnumMethods.GetDescription(typeof(EffectType), GetEffect()); } }
        public int EffectAmount { get; set; }
        public EffectTargetType EffectTarget { get; set; }
        public string EffectTargetName { get { return EnumMethods.GetDescription(typeof(EffectTargetType), EffectTarget); } }
        public int EffectChance { get; set; }
        public EffectStatType ResistanceStat { get; set; }
        public ElementType Element { get; set; }
        public string ElementName { get { return EnumMethods.GetDescription(typeof(ElementType), Element); } }
        public bool[] EligibleCharacters { get; set; } = new bool[11];
        public List<CharacterType> EligibleCharactersByID { get { return GetEligibleCharacters(); } }
        public Bitmap EligibleCharactersImage { get { return GetEligibleImage(); } }
        public ItemAreaType Type { get; set; }
        public string TypeName { get { return EnumMethods.GetDescription(typeof(ItemAreaType), (ItemAreaType)Type); } }
        public int Strength { get; set; }
        public int Mental { get; set; }
        public int Agility { get; set; }
        public int Dexterity { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int MagicDefense { get; set; }
        public ElementType AppliedElement { get; set; }
        public EffectType SecondaryEffect { get; set; }
        public int Meseta { get; set; }

        /// <summary>
        /// Constructors
        /// </summary>
        public Item() { }
        public Item(int id, string name, string customName) { ID = id; Name = name; CustomName = customName; }

        /// <summary>
        /// Gets the effect based on if the primary or secondary effect has data
        /// </summary>
        /// <returns>The active effect</returns>
        private EffectType GetEffect()
        {
            return Effect != EffectType.None ? Effect : SecondaryEffect != EffectType.None ? SecondaryEffect : EffectType.None;
        }

        /// <summary>
        /// Gets the characters that are eligible to use the item
        /// </summary>
        /// <returns>Eligible characters</returns>
        private List<CharacterType> GetEligibleCharacters()
        {
            List<CharacterType> ids = new List<CharacterType>();
            for (int i = 0; i < EligibleCharacters.Length; i++)
                if (EligibleCharacters[i])
                    ids.Add((CharacterType)i);
            return ids;
        }

        /// <summary>
        /// Gets an icon image of characters that are eligible to use the item
        /// </summary>
        /// <returns>Eligible characters icon image</returns>
        private Bitmap GetEligibleImage()
        {
            int width = 0;
            List<Bitmap> characters = new List<Bitmap>();
            foreach (CharacterType character in Enum.GetValues(typeof(CharacterType)))
            {
                if (EligibleCharacters[(int)character])
                {
                    switch (character)
                    {
                        case CharacterType.Chaz: characters.Add(Properties.Resources.chaz); break;
                        case CharacterType.Alys: characters.Add(Properties.Resources.alys); break;
                        case CharacterType.Hahn: characters.Add(Properties.Resources.hahn); break;
                        case CharacterType.Rune: characters.Add(Properties.Resources.rune); break;
                        case CharacterType.Gryz: characters.Add(Properties.Resources.gryz); break;
                        case CharacterType.Rika: characters.Add(Properties.Resources.rika); break;
                        case CharacterType.Demi: characters.Add(Properties.Resources.demi); break;
                        case CharacterType.Wren: characters.Add(Properties.Resources.wren); break;
                        case CharacterType.Raja: characters.Add(Properties.Resources.raja); break;
                        case CharacterType.Kyra: characters.Add(Properties.Resources.kyra); break;
                        case CharacterType.Seth: characters.Add(Properties.Resources.seth); break;
                    }
                }
            }

            foreach (Bitmap b in characters)
                width += b.Width;

            if (width == 0)
                return Properties.Resources.empty;

            int xOffset = 1;
            Bitmap bmp = new Bitmap(width + (characters.Count * xOffset), 12);
            bmp.SetResolution(72, 72);
            using (Graphics gfx = Graphics.FromImage(bmp))
            {
                gfx.InterpolationMode = InterpolationMode.NearestNeighbor;
                int x = 0;
                foreach (Bitmap b2 in characters)
                {
                    gfx.DrawImageUnscaled(b2, x, 0);
                    x += b2.Width + xOffset;
                }
            }
            return bmp;
        }
    }
}
