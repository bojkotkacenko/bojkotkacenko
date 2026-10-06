using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class _0x325a3e51 : MonoBehaviour
{
    private Vector3 _0x780b2017 { get; set; }
    private float _0x8e96d900 { get; set; }
    private Vector3 _0xae5df039 { get; set; }
    private Vector3 _0x9d4f134e { get; set; }
    private Vector3 _0x55ddb929 { get; set; }
    private Vector3 _0x5a8f3d74 { get; set; }
    private Vector3 _0x3518f472 { get; set; }

    private void Awake()
    {
        this._0x3b75344e = this.GetComponent<Camera>();
        _0x4adae5d0 = this;
        this._0xd93db366();
    }

    private Color _0xe5aef6ce = Color.white;
    private Vector3 _0xb60b29b3 { get; set; }

    private void OnDrawGizmos()
    {
        Gizmos.color = this._0xe5aef6ce;
        Matrix4x4 _0xb3941f6c = Gizmos.matrix;
        Gizmos.matrix = Matrix4x4.TRS(this.transform.position, this.transform.rotation, Vector3.one);
        if (this._0x3b75344e.orthographic)
        {
            float _0xf0850d3e = this._0x3b75344e.farClipPlane - this._0x3b75344e.nearClipPlane;
            float _0x1f940ea9 = (this._0x3b75344e.farClipPlane + this._0x3b75344e.nearClipPlane) * 0.5f;
            Gizmos.DrawWireCube(new Vector3(0, 0, _0x1f940ea9), new Vector3(this._0x3b75344e.orthographicSize * 2 * this._0x3b75344e.aspect, this._0x3b75344e.orthographicSize * 2, _0xf0850d3e));
        }
        else
        {
            Gizmos.DrawFrustum(Vector3.zero, this._0x3b75344e.fieldOfView, this._0x3b75344e.farClipPlane, this._0x3b75344e.nearClipPlane, this._0x3b75344e.aspect);
        }

        Gizmos.matrix = _0xb3941f6c;
    }

    private static _0x325a3e51 _0x4adae5d0;
    private Vector3 _0xd3ea19bc { get; set; }

    private _0x23e914a9 _0x8bf413a6 = _0x23e914a9.Portrait;
    private new Camera _0x3b75344e;
    //public bool executeInUpdate;
    private float _0x1c71a345 { get; set; }

    private float _0x83d6c5b8 = 1;
    public enum _0x23e914a9
    {
        Landscape,
        Portrait
    }

    private void _0xd93db366()
    {
        float _0x007bd3ce, _0x535ef9be, _0x992c5f28, _0x2a0251a5;
        if (this._0x8bf413a6 == _0x23e914a9.Landscape)
            this._0x3b75344e.orthographicSize = 1f / this._0x3b75344e.aspect * this._0x83d6c5b8 / 2f;
        else
            this._0x3b75344e.orthographicSize = this._0x83d6c5b8 / 2f;
        this._0x8e96d900 = 2f * this._0x3b75344e.orthographicSize;
        this._0x1c71a345 = this._0x8e96d900 * this._0x3b75344e.aspect;
        float _0x3bda1197 = this._0x3b75344e.transform.position.x;
        float _0xc597174d = this._0x3b75344e.transform.position.y;
        _0x007bd3ce = _0x3bda1197 - this._0x1c71a345 / 2;
        _0x535ef9be = _0x3bda1197 + this._0x1c71a345 / 2;
        _0x992c5f28 = _0xc597174d + this._0x8e96d900 / 2;
        _0x2a0251a5 = _0xc597174d - this._0x8e96d900 / 2;
        this._0xb60b29b3 = new Vector3(_0x007bd3ce, _0x2a0251a5, 0);
        this._0x55ddb929 = new Vector3(_0x3bda1197, _0x2a0251a5, 0);
        this._0x780b2017 = new Vector3(_0x535ef9be, _0x2a0251a5, 0);
        this._0x711b2369 = new Vector3(_0x007bd3ce, _0xc597174d, 0);
        this._0x3518f472 = new Vector3(_0x3bda1197, _0xc597174d, 0);
        this._0xae5df039 = new Vector3(_0x535ef9be, _0xc597174d, 0);
        this._0x5a8f3d74 = new Vector3(_0x007bd3ce, _0x992c5f28, 0);
        this._0xd3ea19bc = new Vector3(_0x3bda1197, _0x992c5f28, 0);
        this._0x9d4f134e = new Vector3(_0x535ef9be, _0x992c5f28, 0);
    }

    private Vector3 _0x711b2369 { get; set; }
}