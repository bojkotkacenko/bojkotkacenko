using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class _0xa5b58a51 : MonoBehaviour
{
    private TMP_Text _0xfeadfa4f;
    private float _0x7cbaf771 = 0.6f;
    private float _0x72da357e = 1.5f;
    private AspectRatioFitter _0x17a00f6b;
    private float _0xb82f45dd;
    private float _0xff978c9e = 4;
    private void Update()
    {
        int _0x82ec7d55 = 1;
        if (this._0x8bba239d.Count > 0)
        {
            string _0xef58ad4a = this._0xfeadfa4f.text;
            foreach (string _0x97cae874 in this._0x8bba239d)
                while (_0xef58ad4a.Contains(_0x97cae874))
                    _0xef58ad4a = _0xef58ad4a.Replace(_0x97cae874, "");
            _0x82ec7d55 = _0xef58ad4a.Length;
        }
        else
        {
            _0x82ec7d55 = this._0xfeadfa4f.text.Length;
        }

        float _0xe6926b4d = Mathf.Clamp(this._0xb82f45dd + this._0x7cbaf771 * _0x82ec7d55, this._0x72da357e, this._0xff978c9e);
        if (!Mathf.Approximately(this._0x17a00f6b.aspectRatio, _0xe6926b4d))
            this._0x17a00f6b.aspectRatio = _0xe6926b4d;
    }

    private List<string> _0x8bba239d = new();
}