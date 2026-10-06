using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public static class _0xb0135da5
{
    public static class _0x0c1629aa
    {
        public static int _0x2d6060af
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0x6efa2ada._0x7f7a2c54(new byte[5] { 69, 105, 111, 104, 117 }, 6)))
                    PlayerPrefs.SetInt(_0x6efa2ada._0x7f7a2c54(new byte[5] { 128, 172, 170, 173, 176 }, 195), 0);
                return PlayerPrefs.GetInt(_0x6efa2ada._0x7f7a2c54(new byte[5] { 38, 10, 12, 11, 22 }, 101));
            }

            set
            {
                PlayerPrefs.SetInt(_0x6efa2ada._0x7f7a2c54(new byte[5] { 44, 0, 6, 1, 28 }, 111), value);
                _0x24245b46.Instance._0x528bd5d1();
            }
        }
    }

    public static class _0x73d482f8
    {
        public static readonly int SCENE_0 = 0;
        public static readonly int SCENE_1 = 1;
    }

    public static class _0x9123adc7
    {
        public static readonly int PAUSE = 6;
        public static readonly int WIN = 7;
        public static readonly int LOSE = 8;
    }

    public static class _0xe76dff38
    {
        public static readonly int SPLASH = 0;
        public static readonly int DEFAULT = 1;
        public static readonly int EMPTY = 2;
        public static readonly int TUTORIAL0 = 13;
        public static readonly int TUTORIAL1 = 14;
        public static readonly int TUTORIAL2 = 15;
        public static readonly int TUTORIAL3 = 16;
        public static readonly int TUTORIAL4 = 17;
        public static readonly int TUTORIAL5 = 18;
        public static readonly int TUTORIAL6 = 19;
    }

    public class _0xf58daef7
    {
        private static readonly _0xf58daef7 _0xd975f74a = new();
        public static readonly _0xf58daef7[] ALL_SCENES_SETTING_SINGLETONS =
        {
            _0xd975f74a,
            _0xd975f74a,
            _0xd975f74a,
        };
        private int _0x748ad5f9 => 0;
        private int _0x3fadcfed => 10;
        private string _0x51fbe613 => _0x6efa2ada._0x7f7a2c54(new byte[4] { 254, 214, 221, 198 }, 179);
        private string _0xe8a31eb7 => _0x6efa2ada._0x7f7a2c54(new byte[8] { 121, 112, 99, 112, 121, 78, 5, 72 }, 53);

        private int _0x7a12ab82
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0x6efa2ada._0x7f7a2c54(new byte[25] { 193, 247, 240, 240, 231, 236, 246, 197, 238, 237, 224, 227, 238, 193, 234, 227, 242, 246, 231, 240, 203, 236, 230, 231, 250 }, 130)))
                    PlayerPrefs.SetInt(_0x6efa2ada._0x7f7a2c54(new byte[25] { 165, 147, 148, 148, 131, 136, 146, 161, 138, 137, 132, 135, 138, 165, 142, 135, 150, 146, 131, 148, 175, 136, 130, 131, 158 }, 230), 0);
                return PlayerPrefs.GetInt(_0x6efa2ada._0x7f7a2c54(new byte[25] { 111, 89, 94, 94, 73, 66, 88, 107, 64, 67, 78, 77, 64, 111, 68, 77, 92, 88, 73, 94, 101, 66, 72, 73, 84 }, 44));
            }

            set => PlayerPrefs.SetInt(_0x6efa2ada._0x7f7a2c54(new byte[25] { 98, 84, 83, 83, 68, 79, 85, 102, 77, 78, 67, 64, 77, 98, 73, 64, 81, 85, 68, 83, 104, 79, 69, 68, 89 }, 33), value);
        }

        public int _0x0dd2a96e
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x51fbe613}CurrentLevelIndex"))
                    PlayerPrefs.SetInt($"{this._0x51fbe613}CurrentLevelIndex", 0);
                return PlayerPrefs.GetInt($"{this._0x51fbe613}CurrentLevelIndex");
            }

            set => PlayerPrefs.SetInt($"{this._0x51fbe613}CurrentLevelIndex", value);
        }

        public int _0xb15da8ca
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x51fbe613}BestScore"))
                    this._0xb15da8ca = 0;
                return PlayerPrefs.GetInt($"{this._0x51fbe613}BestScore");
            }

            set => PlayerPrefs.SetInt($"{this._0x51fbe613}BestScore", value);
        }

        public bool _0xcd60561f
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x51fbe613}IsGameTutorPassed"))
                    PlayerPrefs.SetInt($"{this._0x51fbe613}IsGameTutorPassed", Convert.ToInt32(false));
                return PlayerPrefs.GetInt($"{this._0x51fbe613}IsGameTutorPassed") == 1;
            }

            set => PlayerPrefs.SetInt($"{this._0x51fbe613}IsGameTutorPassed", Convert.ToInt32(value));
        }
    }
}

internal static class _0x6efa2ada
{
    internal static string _0x7f7a2c54(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}