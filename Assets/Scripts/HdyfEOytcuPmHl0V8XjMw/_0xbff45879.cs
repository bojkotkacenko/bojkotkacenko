using UnityEngine;

/// One garden (one day of sorting). Difficulty numbers come from the design table;
/// the LAYOUT that uses them is generated per attempt (rule C.11).
/// Counts are stored as separate fields rather than an int array so the serialized
/// form stays plain readable YAML.
[System.Serializable]
public class _0xbff45879
{
    public string _0x351be776
    {
        get
        {
            return this._title;
        }
    }

    public int _0x1a9063e7
    {
        get
        {
            return Mathf.Clamp(this._fruitKinds, 3, 5);
        }
    }

    [SerializeField]
    private int _fruitKinds = 3;
    public int _0x0290bbf1
    {
        get
        {
            return Mathf.Max(0, this._jokerCount);
        }
    }

    [SerializeField]
    private int _orderLeft = 3;
    [SerializeField]
    private int _orderRight = 3;
    [SerializeField]
    private float _daySeconds = 110f;
    [SerializeField]
    private int _jokerCount;
    public float _0xfd6c7e14
    {
        get
        {
            return Mathf.Max(30f, this._daySeconds);
        }
    }

    public int _0xa9e2ab7d(int _0x5e2cd9d1)
    {
        if (_0x5e2cd9d1 <= 0)
            return Mathf.Max(1, this._orderLeft);
        if (_0x5e2cd9d1 == 1)
            return Mathf.Max(1, this._orderMiddle);
        return Mathf.Max(1, this._orderRight);
    }

    [SerializeField]
    private string _title = _0xbefb7790._0xc8d442c2(new byte[13] { 94, 88, 67, 67, 84, 45, 66, 95, 78, 69, 76, 95, 73 }, 13);
    [SerializeField]
    private int _orderMiddle = 3;
    public int _0x2e59e1a7
    {
        get
        {
            return this._0xa9e2ab7d(0) + this._0xa9e2ab7d(1) + this._0xa9e2ab7d(2);
        }
    }
}

internal static class _0xbefb7790
{
    internal static string _0xc8d442c2(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}