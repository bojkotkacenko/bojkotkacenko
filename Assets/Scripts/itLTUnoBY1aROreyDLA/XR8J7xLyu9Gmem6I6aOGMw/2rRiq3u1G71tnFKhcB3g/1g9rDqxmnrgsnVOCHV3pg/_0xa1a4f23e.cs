using UnityEngine;
using UnityEngine.UI;

public class _0xa1a4f23e : MonoBehaviour
{
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    public bool IsPhysicsRunOnClick;
    public Button Button;
    private void Start()
    {
        this.Button.onClick.AddListener(() => _0x24245b46.Instance._0x11e6a30d(this.IsPhysicsRunOnClick));
    }
}