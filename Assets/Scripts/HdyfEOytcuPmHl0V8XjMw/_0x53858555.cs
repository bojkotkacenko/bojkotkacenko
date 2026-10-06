using UnityEngine;

/// Which gardens are open and the best score in each. Keys are constant strings, so
/// the obfuscator's string encryption keeps their VALUES and nothing is addressed by
/// a C# symbol name.
public sealed class _0x53858555 : MonoBehaviour
{
    public void _0xe242de08(int _0x189a84d5, int _0x5e8e4426)
    {
        if (_0x5e8e4426 > this._0x64bacb1c(_0x189a84d5))
            PlayerPrefs.SetInt(BestKeyPrefix + _0x189a84d5, _0x5e8e4426);
        PlayerPrefs.Save();
    }

    public int _0x0b16c68d(int _0x96317777)
    {
        int _0xe5ae1bc7 = 0;
        for (int _0x5a978d16 = 0; _0x5a978d16 < _0x96317777; _0x5a978d16++)
            if (this._0x64bacb1c(_0x5a978d16) > _0xe5ae1bc7)
                _0xe5ae1bc7 = this._0x64bacb1c(_0x5a978d16);
        return _0xe5ae1bc7;
    }

    public void _0x72738754(int _0xcea3c974)
    {
        PlayerPrefs.SetInt(ChosenKey, Mathf.Max(0, _0xcea3c974));
        PlayerPrefs.Save();
    }

    public int _0xeeedc340
    {
        get
        {
            return Mathf.Max(0, PlayerPrefs.GetInt(ChosenKey, 0));
        }
    }

    private static readonly string BestKeyPrefix = _0xed51f7df._0x4ec82356(new byte[8] { 16, 3, 93, 17, 22, 0, 7, 93 }, 115);
    /// A fresh, rising number for every load, so the day generator draws a new
    /// layout each attempt while staying reproducible from its seed.
    public int _0xd89ed500()
    {
        int _0x7f91be44 = PlayerPrefs.GetInt(AttemptKey, 0) + 1;
        PlayerPrefs.SetInt(AttemptKey, _0x7f91be44);
        PlayerPrefs.Save();
        return _0x7f91be44;
    }

    private static readonly string ChosenKey = _0xed51f7df._0x4ec82356(new byte[9] { 194, 209, 143, 194, 201, 206, 210, 196, 207 }, 161);
    public bool _0x2c16c753(int _0xa7135098)
    {
        return _0xa7135098 < this._0x62a32cde;
    }

    private static readonly string AttemptKey = _0xed51f7df._0x4ec82356(new byte[6] { 24, 11, 85, 15, 9, 2 }, 123);
    public int _0x62a32cde
    {
        get
        {
            return Mathf.Max(1, PlayerPrefs.GetInt(UnlockedKey, 1));
        }
    }

    private static readonly string UnlockedKey = _0xed51f7df._0x4ec82356(new byte[11] { 27, 8, 86, 13, 22, 20, 23, 27, 19, 29, 28 }, 120);
    public int _0x64bacb1c(int _0xb78cabbf)
    {
        return PlayerPrefs.GetInt(BestKeyPrefix + _0xb78cabbf, 0);
    }

    public void _0xa42a833b(int _0xb5f3ff03)
    {
        int _0xde3db0d0 = Mathf.Max(this._0x62a32cde, _0xb5f3ff03 + 2);
        PlayerPrefs.SetInt(UnlockedKey, _0xde3db0d0);
        PlayerPrefs.Save();
    }
}

internal static class _0xed51f7df
{
    internal static string _0x4ec82356(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}