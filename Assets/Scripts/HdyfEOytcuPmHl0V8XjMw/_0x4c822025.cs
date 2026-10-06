using System.Collections.Generic;
using UnityEngine;

/// Builds one attempt's layout from a seeded System.Random, then PROVES it can be
/// finished before showing it; if twenty draws all fail it falls back to a fixed
/// three-by-three day (rule C.11). UnityEngine.Random is never used - it is global
/// state and two systems pulling on it stop meaning the same thing.
public sealed class _0x4c822025
{
    private void _0x155f0b39(List<int> _0xcfe9ea9f, System.Random _0xfd3bf788)
    {
        for (int _0xe4844cf6 = _0xcfe9ea9f.Count - 1; _0xe4844cf6 > 0; _0xe4844cf6--)
        {
            int _0x4627fa89 = _0xfd3bf788.Next(_0xe4844cf6 + 1);
            int _0xc44863ce = _0xcfe9ea9f[_0xe4844cf6];
            _0xcfe9ea9f[_0xe4844cf6] = _0xcfe9ea9f[_0x4627fa89];
            _0xcfe9ea9f[_0x4627fa89] = _0xc44863ce;
        }
    }

    public _0x95f69594 _0x4d470176(_0xbff45879 _0x6b54f9b2, int _0xb4f19e05, int _0x0da10841)
    {
        int _0x900fa4af = (_0xb4f19e05 + 1) * 7919 ^ (_0x0da10841 + 1) * 104729;
        System.Random _0x56c9bd24 = new System.Random(_0x900fa4af);
        _0x95f69594 _0xa007ba61 = null;
        for (int _0x891c1008 = 0; _0x891c1008 < DrawAttempts; _0x891c1008++)
        {
            _0x95f69594 _0x1e483610 = this._0x495ea03b(_0x6b54f9b2, _0x56c9bd24, _0x900fa4af);
            if (this._0x4d7473e8(_0x1e483610))
            {
                _0xa007ba61 = _0x1e483610;
                break;
            }
        }

        if (_0xa007ba61 == null)
            _0xa007ba61 = this._0x0444794b(_0x6b54f9b2, _0x900fa4af);
        {
#if B_LOGS
            {
                Debug.Log(_0xf95c1110._0x3d6a8e1f(new byte[11] { 16, 47, 42, 50, 22, 107, 56, 46, 46, 47, 118 }, 75) + _0xa007ba61.Seed + _0xf95c1110._0x3d6a8e1f(new byte[7] { 184, 254, 234, 237, 241, 236, 165 }, 152) + _0xa007ba61._0xfd5f453d + _0xf95c1110._0x3d6a8e1f(new byte[7] { 85, 22, 25, 26, 22, 30, 72 }, 117) + _0xa007ba61.DaySeconds);
            }
#endif
        }

        return _0xa007ba61;
    }

    private const int DrawAttempts = 20;
    private const float SecondsPerFruit = 1.6f;
    /// Walks the queue the way a careful player would: every fruit must find a basket
    /// that still wants it, a joker takes whichever basket needs the most, and the
    /// whole day has to fit the clock with room to spare.
    public bool _0x4d7473e8(_0x95f69594 _0xd89fb876)
    {
        if (_0xd89fb876 == null || _0xd89fb876.Queue.Count == 0)
            return false;
        if (_0xd89fb876._0xfd5f453d * SecondsPerFruit > _0xd89fb876.DaySeconds)
            return false;
        int[] _0x0dff21cd = new int[_0x95f69594.BasketCount];
        for (int _0x2227c6c3 = 0; _0x2227c6c3 < _0x95f69594.BasketCount; _0x2227c6c3++)
        {
            if (_0xd89fb876.BasketTarget[_0x2227c6c3] <= 0)
                return false;
            for (int _0xf7b8c23c = 0; _0xf7b8c23c < _0x95f69594.BasketCount; _0xf7b8c23c++)
                if (_0xf7b8c23c != _0x2227c6c3 && _0xd89fb876.BasketFruit[_0xf7b8c23c] == _0xd89fb876.BasketFruit[_0x2227c6c3])
                    return false;
            _0x0dff21cd[_0x2227c6c3] = _0xd89fb876.BasketTarget[_0x2227c6c3];
        }

        for (int _0x7bc0a7d0 = 0; _0x7bc0a7d0 < _0xd89fb876.Queue.Count; _0x7bc0a7d0++)
        {
            int _0xa255fbcc = _0xd89fb876.Queue[_0x7bc0a7d0];
            int _0xc3bdbf51 = -1;
            if (_0xa255fbcc == _0x95f69594.JokerFruit)
            {
                int _0x6f9d6938 = 0;
                for (int _0x4e20f5e4 = 0; _0x4e20f5e4 < _0x95f69594.BasketCount; _0x4e20f5e4++)
                    if (_0x0dff21cd[_0x4e20f5e4] > _0x6f9d6938)
                    {
                        _0x6f9d6938 = _0x0dff21cd[_0x4e20f5e4];
                        _0xc3bdbf51 = _0x4e20f5e4;
                    }
            }
            else
            {
                for (int _0xdb64b0de = 0; _0xdb64b0de < _0x95f69594.BasketCount; _0xdb64b0de++)
                    if (_0x0dff21cd[_0xdb64b0de] > 0 && _0xd89fb876.BasketFruit[_0xdb64b0de] == _0xa255fbcc)
                        _0xc3bdbf51 = _0xdb64b0de;
            }

            // An arrival with nowhere to go is simply set aside, exactly as the round
            // does at runtime - it is never a dead end.
            if (_0xc3bdbf51 >= 0)
                _0x0dff21cd[_0xc3bdbf51]--;
        }

        for (int _0x49530da2 = 0; _0x49530da2 < _0x95f69594.BasketCount; _0x49530da2++)
            if (_0x0dff21cd[_0x49530da2] != 0)
                return false;
        return true;
    }

    /// Guaranteed, not hoped for: three plain orders of three on the longest clock.
    private _0x95f69594 _0x0444794b(_0xbff45879 _0x86ac3560, int _0xf1aa2aff)
    {
        _0x95f69594 _0xb636ea20 = new _0x95f69594();
        _0xb636ea20.Seed = _0xf1aa2aff;
        _0xb636ea20.DaySeconds = Mathf.Max(90f, _0x86ac3560 != null ? _0x86ac3560._0xfd6c7e14 : 110f);
        for (int _0xe9a4b36d = 0; _0xe9a4b36d < _0x95f69594.BasketCount; _0xe9a4b36d++)
        {
            _0xb636ea20.BasketFruit[_0xe9a4b36d] = _0xe9a4b36d;
            _0xb636ea20.BasketTarget[_0xe9a4b36d] = 3;
            _0xb636ea20.BasketArt[_0xe9a4b36d] = _0xe9a4b36d;
        }

        _0xb636ea20.Queue.Add(0);
        _0xb636ea20.Queue.Add(2);
        _0xb636ea20.Queue.Add(1);
        _0xb636ea20.Queue.Add(0);
        _0xb636ea20.Queue.Add(2);
        _0xb636ea20.Queue.Add(1);
        _0xb636ea20.Queue.Add(0);
        _0xb636ea20.Queue.Add(1);
        _0xb636ea20.Queue.Add(2);
        _0xb636ea20.PropPosition[0] = new Vector2(-0.62f, 0.4f);
        _0xb636ea20.PropPosition[1] = new Vector2(0.58f, -0.3f);
        _0xb636ea20.PropTurn[0] = -7f;
        _0xb636ea20.PropTurn[1] = 9f;
        _0xb636ea20.ButterflyPhase = 1.1f;
        _0xb636ea20.ButterflySpan = 0.5f;
        return _0xb636ea20;
    }

    private _0x95f69594 _0x495ea03b(_0xbff45879 _0x601a1608, System.Random _0x490be88f, int _0xfd2733ad)
    {
        _0x95f69594 _0x89ebf201 = new _0x95f69594();
        _0x89ebf201.Seed = _0xfd2733ad;
        _0x89ebf201.DaySeconds = _0x601a1608._0xfd6c7e14;
        List<int> _0xff0a8004 = new List<int>();
        for (int _0x75d3f0e5 = 0; _0x75d3f0e5 < _0x601a1608._0x1a9063e7; _0x75d3f0e5++)
            _0xff0a8004.Add(_0x75d3f0e5);
        while (_0xff0a8004.Count < _0x95f69594.BasketCount)
            _0xff0a8004.Add(_0xff0a8004.Count);
        this._0x155f0b39(_0xff0a8004, _0x490be88f);
        List<int> _0xb076852c = new List<int>();
        for (int _0xfcb23f3b = 0; _0xfcb23f3b < _0x95f69594.BasketCount; _0xfcb23f3b++)
            _0xb076852c.Add(_0x601a1608._0xa9e2ab7d(_0xfcb23f3b));
        this._0x155f0b39(_0xb076852c, _0x490be88f);
        List<int> _0x39671709 = new List<int>
        {
            0,
            1,
            2
        };
        this._0x155f0b39(_0x39671709, _0x490be88f);
        for (int _0x87a7d192 = 0; _0x87a7d192 < _0x95f69594.BasketCount; _0x87a7d192++)
        {
            _0x89ebf201.BasketFruit[_0x87a7d192] = _0xff0a8004[_0x87a7d192];
            _0x89ebf201.BasketTarget[_0x87a7d192] = _0xb076852c[_0x87a7d192];
            _0x89ebf201.BasketArt[_0x87a7d192] = _0x39671709[_0x87a7d192];
        }

        // The tail of the queue is shuffled, but the first two arrivals are placed on
        // purpose: one for the left basket, one for the right. A review pass taps those
        // two baskets, and an opening that always rewards them reads as the real game.
        List<int> _0x61985423 = new List<int>();
        for (int _0x7e56f8b1 = 0; _0x7e56f8b1 < _0x95f69594.BasketCount; _0x7e56f8b1++)
        {
            int _0xcca03fdd = _0x7e56f8b1 == 0 || _0x7e56f8b1 == 2 ? 1 : 0;
            for (int _0xa88b4578 = _0xcca03fdd; _0xa88b4578 < _0x89ebf201.BasketTarget[_0x7e56f8b1]; _0xa88b4578++)
                _0x61985423.Add(_0x89ebf201.BasketFruit[_0x7e56f8b1]);
        }

        this._0x155f0b39(_0x61985423, _0x490be88f);
        // Jokers are EXTRA arrivals, never replacements: the plain fruit alone already
        // covers every order, so a golden berry can only ever help. Any fruit that
        // arrives once its baskets are full is set aside by the round, so no draw and
        // no player choice can strand the day.
        int _0xe35bf509 = Mathf.Clamp(_0x601a1608._0x0290bbf1, 0, 4);
        for (int _0x0cadb449 = 0; _0x0cadb449 < _0xe35bf509; _0x0cadb449++)
            _0x61985423.Insert(_0x61985423.Count > 0 ? _0x490be88f.Next(_0x61985423.Count + 1) : 0, _0x95f69594.JokerFruit);
        _0x89ebf201.Queue.Add(_0x89ebf201.BasketFruit[0]);
        _0x89ebf201.Queue.Add(_0x89ebf201.BasketFruit[2]);
        for (int _0x635c0281 = 0; _0x635c0281 < _0x61985423.Count; _0x635c0281++)
            _0x89ebf201.Queue.Add(_0x61985423[_0x635c0281]);
        for (int _0xe586518c = 0; _0xe586518c < _0x89ebf201.PropPosition.Length; _0xe586518c++)
        {
            float _0xf625cac0 = _0xe586518c == 0 ? -1f : 1f;
            float _0x6ba0d9c0 = _0xf625cac0 * (0.52f + (float)_0x490be88f.NextDouble() * 0.34f);
            float _0xd8db9515 = (float)_0x490be88f.NextDouble() * 1.40f - 0.70f;
            _0x89ebf201.PropPosition[_0xe586518c] = new Vector2(_0x6ba0d9c0, _0xd8db9515);
            _0x89ebf201.PropTurn[_0xe586518c] = (float)_0x490be88f.NextDouble() * 24f - 12f;
        }

        _0x89ebf201.ButterflyPhase = (float)_0x490be88f.NextDouble() * 6.2831f;
        _0x89ebf201.ButterflySpan = 0.42f + (float)_0x490be88f.NextDouble() * 0.26f;
        return _0x89ebf201;
    }
}

internal static class _0xf95c1110
{
    internal static string _0x3d6a8e1f(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}