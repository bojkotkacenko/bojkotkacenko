using System.Collections.Generic;
using UnityEngine;

/// The serving tray: the fruit the player is holding plus a peek at the next three.
public sealed class _0x67b6c9da : MonoBehaviour
{
    public Sprite _0x00489e5c(int _0x5e09994a)
    {
        if (_0x5e09994a == _0x95f69594.JokerFruit)
            return this._goldenArt;
        if (this._fruitArt == null || this._fruitArt.Length == 0)
            return null;
        int _0xb212a10c = Mathf.Clamp(_0x5e09994a, 0, this._fruitArt.Length - 1);
        return this._fruitArt[_0xb212a10c];
    }

    private float _0x4fe9847d;
    public Vector3 _0x53d2323a
    {
        get
        {
            return this._0x64a385a5;
        }
    }

    private float _0x8540c353;
    [SerializeField]
    private Sprite _goldenArt;
    private readonly List<_0x02b14df7> _0x5c282864 = new List<_0x02b14df7>();
    private Color _0x19004970 = Color.white;
    [SerializeField]
    private _0x02b14df7 _queuePrefab;
    [SerializeField]
    private _0x02b14df7 _fruitPrefab;
    public _0x02b14df7 _0xeeb767f3(int _0x9db5a176)
    {
        if (this._fruitPrefab == null || this._0xe0322370 == null)
            return null;
        _0x02b14df7 _0xcba7bc21 = Instantiate(this._fruitPrefab, this._0xe0322370);
        _0xcba7bc21._0xcdf4e174(this._0x00489e5c(_0x9db5a176), this._0x4fe9847d, _0x065c3466.FruitOrder, _0x9db5a176 == _0x95f69594.JokerFruit, this._0x19004970);
        _0xcba7bc21._0x4e0e6413(this._0x64a385a5);
        _0xcba7bc21._0x27f37bda();
        return _0xcba7bc21;
    }

    private Vector3 _0x64a385a5;
    private Transform _0xe0322370;
    private const int PreviewCount = 3;
    public void _0x5e9ec745()
    {
        for (int _0x454c8a30 = 0; _0x454c8a30 < this._0x5c282864.Count; _0x454c8a30++)
            if (this._0x5c282864[_0x454c8a30] != null)
                Destroy(this._0x5c282864[_0x454c8a30].gameObject);
        this._0x5c282864.Clear();
    }

    private Vector3[] _0x0cccabb5 = new Vector3[PreviewCount];
    [SerializeField]
    private Sprite[] _fruitArt = new Sprite[0];
    public void _0x440f7d99(List<int> _0xa246b707, int _0x879478a4)
    {
        this._0x5e9ec745();
        if (_0xa246b707 == null || this._queuePrefab == null || this._0xe0322370 == null || this._0x0cccabb5 == null)
            return;
        for (int _0x550903bb = 0; _0x550903bb < PreviewCount; _0x550903bb++)
        {
            int _0x54cb1a55 = _0x879478a4 + _0x550903bb;
            if (_0x54cb1a55 >= _0xa246b707.Count || _0x550903bb >= this._0x0cccabb5.Length)
                break;
            _0x02b14df7 _0xfc526a4d = Instantiate(this._queuePrefab, this._0xe0322370);
            _0xfc526a4d._0xcdf4e174(this._0x00489e5c(_0xa246b707[_0x54cb1a55]), this._0x8540c353, _0x065c3466.QueueOrder, _0xa246b707[_0x54cb1a55] == _0x95f69594.JokerFruit, this._0x19004970);
            _0xfc526a4d._0x4e0e6413(this._0x0cccabb5[_0x550903bb]);
            this._0x5c282864.Add(_0xfc526a4d);
        }
    }

    public void _0x91d11cad(_0x02b14df7 _0xf494cab4, _0x02b14df7 _0x15496268, Transform _0x68a19c6c, Sprite[] _0xf48fd467, Sprite _0x5a1d6d16, float _0x61d1ffe1, float _0x4052b2fe, Vector3 _0x86f2c5f6, Vector3[] _0x97d6b1c1, Color _0x0d517f6a)
    {
        this._fruitPrefab = _0xf494cab4;
        this._queuePrefab = _0x15496268;
        this._0xe0322370 = _0x68a19c6c;
        this._fruitArt = _0xf48fd467;
        this._goldenArt = _0x5a1d6d16;
        this._0x4fe9847d = _0x61d1ffe1;
        this._0x8540c353 = _0x4052b2fe;
        this._0x64a385a5 = _0x86f2c5f6;
        this._0x0cccabb5 = _0x97d6b1c1;
        this._0x19004970 = _0x0d517f6a;
    }
}