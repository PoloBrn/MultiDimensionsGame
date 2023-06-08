using UnityEngine;

public class CameraChange : MonoBehaviour
{
    public static CameraChange Instance;
    public bool orthographic;
    public string changeDimention;

    public enum Mode
    {
        prem, //2D
        second //3D
    };

    public Mode currentmode;

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        Camera.main.orthographic = true;
        currentmode = Mode.prem;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            Camera.main.orthographic = !Camera.main.orthographic;
            this.currentmode = this.currentmode == Mode.prem ? Mode.second : Mode.prem;
        }
    }
}