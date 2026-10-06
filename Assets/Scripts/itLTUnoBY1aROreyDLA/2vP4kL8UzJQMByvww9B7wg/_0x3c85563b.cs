using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;
using TouchPhase = UnityEngine.InputSystem.TouchPhase;

public class _0x3c85563b : MonoBehaviour
{
    private static _0x3c85563b _0x13ce3de9;
    private bool _0x9d0093e4(Touch? _0xc9ac8bba)
    {
        if (!_0xc9ac8bba.HasValue)
            return false;
        Vector3 _0xf4b4fb0e = Camera.main.ScreenToWorldPoint(_0xc9ac8bba.Value.screenPosition);
        Vector3 _0x0d78101e = _0xf4b4fb0e;
        _0x0d78101e.z = this.CameraTouchBounds.transform.position.z;
        if (this.CameraTouchBounds.bounds.Contains(_0x0d78101e))
            return true;
        _0xc9ac8bba = null;
        return false;
    }

    private void _0xeee3663c(Touch? _0x0492b417)
    {
        if (!_0x24245b46.Instance._0x2748193d)
        {
            _0x0492b417 = null;
            return;
        }

        int _0x3d76aa68 = _0x0492b417.Value.touchId;
        _0x0492b417 = Touch.activeTouches.FirstOrDefault(_0x68dc5ea5 => _0x68dc5ea5.touchId == _0x3d76aa68);
        if (!this._0x9d0093e4(_0x0492b417.Value))
            _0x0492b417 = null;
    }

    private bool _0xfd3707fb(Touch? _0x96de2c12, Bounds _0x60baae89, TouchPhase _0x87643cca)
    {
        if (!_0x24245b46.Instance._0x2748193d)
        {
            _0x96de2c12 = null;
            return false;
        }

        if (_0x96de2c12 != null)
            if (_0x96de2c12.Value.phase == _0x87643cca)
            {
                Vector3 _0x06c0674e = Camera.main.ScreenToWorldPoint(_0x96de2c12.Value.screenPosition);
                Vector3 _0x57158c81 = new(_0x06c0674e.x, _0x06c0674e.y, _0x60baae89.center.z);
                if (_0x60baae89.Contains(_0x57158c81) && this._0x9d0093e4(_0x96de2c12.Value))
                    return true;
            }

        return false;
    }

    private Touch? _0x9cf57cd4(Bounds _0xdb229374, TouchPhase _0x46d31e09)
    {
        if (!_0x24245b46.Instance._0x2748193d)
            return null;
        foreach (Touch _0x9236e15e in Touch.activeTouches)
            if (_0x9236e15e.phase == _0x46d31e09)
            {
                Vector3 _0x3eed37de = Camera.main.ScreenToWorldPoint(_0x9236e15e.screenPosition);
                Vector3 _0x84b45db2 = new(_0x3eed37de.x, _0x3eed37de.y, _0xdb229374.center.z);
                if (_0xdb229374.Contains(_0x84b45db2) && this._0x9d0093e4(_0x9236e15e))
                    return _0x9236e15e;
            }

        return null;
    }

    private Touch? _0x6aa720e6(Bounds _0x6f6f3117)
    {
        if (!_0x24245b46.Instance._0x2748193d)
            return null;
        foreach (Touch _0xfd8502b7 in Touch.activeTouches)
            if (_0xfd8502b7.ended)
            {
                Vector3 _0x2a57b5d5 = Camera.main.ScreenToWorldPoint(_0xfd8502b7.screenPosition);
                Vector3 _0x0bae084e = new(_0x2a57b5d5.x, _0x2a57b5d5.y, _0x6f6f3117.center.z);
                if (_0x6f6f3117.Contains(_0x0bae084e) && this._0x9d0093e4(_0xfd8502b7))
                    return _0xfd8502b7;
            }

        return null;
    }

    private void Awake()
    {
        EnhancedTouchSupport.Enable();
        _0x13ce3de9 = this.gameObject.GetComponent<_0x3c85563b>();
    }

    public BoxCollider2D CameraTouchBounds;
    private Touch? _0xe52508cf()
    {
        if (!_0x24245b46.Instance._0x2748193d)
            return null;
        foreach (Touch _0xa39c182c in Touch.activeTouches)
            if (!_0xa39c182c.ended)
                if (this._0x9d0093e4(_0xa39c182c))
                    return _0xa39c182c;
        return null;
    }

    private Touch? _0x0cd05e6a()
    {
        if (!_0x24245b46.Instance._0x2748193d)
            return null;
        foreach (Touch _0xb4444795 in Touch.activeTouches)
            if (_0xb4444795.ended)
                if (this._0x9d0093e4(_0xb4444795))
                    return _0xb4444795;
        return null;
    }

    private Touch? _0x902eb840(Bounds _0xedd0ffbe)
    {
        if (!_0x24245b46.Instance._0x2748193d)
            return null;
        foreach (Touch _0x8ef2504b in Touch.activeTouches)
            if (!_0x8ef2504b.ended)
            {
                Vector3 _0xba811e01 = Camera.main.ScreenToWorldPoint(_0x8ef2504b.screenPosition);
                Vector3 _0x4569a863 = new(_0xba811e01.x, _0xba811e01.y, _0xedd0ffbe.center.z);
                if (_0xedd0ffbe.Contains(_0x4569a863) && this._0x9d0093e4(_0x8ef2504b))
                    return _0x8ef2504b;
            }

        return null;
    }
}