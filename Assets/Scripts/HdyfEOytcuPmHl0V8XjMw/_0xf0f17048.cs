using TMPro;
using UnityEngine;

/// The template ships more tutorial boards than this game dresses, and every one it
/// does not dress still carries the template's filler copy. This game uses none of
/// them, so all seven get their TMP text emptied at startup (rule C.15). The panels
/// themselves stay in place: the controller addresses panels by index and a removed
/// entry breaks its navigation.
public sealed class _0xf0f17048 : MonoBehaviour
{
    private void _0x6ae1ca08(int _0xb6e0f5ef)
    {
        if (_0x3e36db7a.Instance == null || _0x3e36db7a.Instance.Panels == null)
            return;
        if (_0xb6e0f5ef < 0 || _0xb6e0f5ef >= _0x3e36db7a.Instance.Panels.Count)
            return;
        _0xbb55021e _0xb9d3c107 = _0x3e36db7a.Instance.Panels[_0xb6e0f5ef];
        if (_0xb9d3c107 == null)
            return;
        TMP_Text[] _0x1e280ed8 = _0xb9d3c107.GetComponentsInChildren<TMP_Text>(true);
        for (int _0xc2a95adf = 0; _0xc2a95adf < _0x1e280ed8.Length; _0xc2a95adf++)
            if (_0x1e280ed8[_0xc2a95adf] != null)
                _0x1e280ed8[_0xc2a95adf].text = string.Empty;
    }

    private void Start()
    {
        this._0x6ae1ca08(_0xb0135da5._0xe76dff38.TUTORIAL0);
        this._0x6ae1ca08(_0xb0135da5._0xe76dff38.TUTORIAL1);
        this._0x6ae1ca08(_0xb0135da5._0xe76dff38.TUTORIAL2);
        this._0x6ae1ca08(_0xb0135da5._0xe76dff38.TUTORIAL3);
        this._0x6ae1ca08(_0xb0135da5._0xe76dff38.TUTORIAL4);
        this._0x6ae1ca08(_0xb0135da5._0xe76dff38.TUTORIAL5);
        this._0x6ae1ca08(_0xb0135da5._0xe76dff38.TUTORIAL6);
    }
}