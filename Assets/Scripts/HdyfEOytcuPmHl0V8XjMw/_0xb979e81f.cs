using UnityEngine;
using UnityEngine.UI;

/// One button that opens one overlay and optionally closes another.
/// The click is subscribed with a LAMBDA: a method group survives compilation here
/// and dies in the obfuscated cloud build (rule C.1).
public sealed class _0xb979e81f : MonoBehaviour
{
    [SerializeField]
    private Button _button;
    [SerializeField]
    private _0xe2863a9e _target;
    public void _0x85ee218d(Button _0x01bc9001, _0xe2863a9e _0x9ae18ef9, _0xe2863a9e _0x8e6b1638, bool _0x88aadf5b)
    {
        this._button = _0x01bc9001;
        this._target = _0x9ae18ef9;
        this._alsoClose = _0x8e6b1638;
        this._closeTarget = _0x88aadf5b;
        if (this._button != null)
            this._button.onClick.AddListener(() => this._0x99eb9734());
    }

    [SerializeField]
    private bool _closeTarget;
    private void _0x99eb9734()
    {
        if (this._alsoClose != null)
            this._alsoClose._0xf5b3e926();
        if (this._target == null)
            return;
        if (this._closeTarget)
            this._target._0xf5b3e926();
        else
            this._target._0xf7e30ac2();
    }

    [SerializeField]
    private _0xe2863a9e _alsoClose;
}