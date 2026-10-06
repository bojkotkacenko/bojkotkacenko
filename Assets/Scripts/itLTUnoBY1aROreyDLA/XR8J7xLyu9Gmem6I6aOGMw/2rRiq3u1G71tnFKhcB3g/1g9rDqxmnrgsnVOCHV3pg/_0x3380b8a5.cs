using UnityEngine;
using UnityEngine.UI;

public class _0x3380b8a5 : MonoBehaviour
{
    private Button _0xb21ee5bb;
    private void Awake()
    {
        if (this._0xb21ee5bb == null)
            if (!this.TryGetComponent(out this._0xb21ee5bb))
                this._0xb21ee5bb = this.GetComponentInChildren<Button>();
    }

    private bool _0xe0916848;
    private void Start()
    {
        if (this._0xe0916848)
            this._0xb21ee5bb.onClick.AddListener(() => _0x3e36db7a.Instance._0x79c57b79());
        else
            this._0xb21ee5bb.onClick.AddListener(() => _0x3e36db7a.Instance._0xa72c9de0(this._0x1dab2b00));
    }

    private int _0x1dab2b00;
}