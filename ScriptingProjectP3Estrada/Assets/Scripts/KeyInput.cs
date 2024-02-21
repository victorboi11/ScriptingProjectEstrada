using UnityEngine;
using UnityEngine.UI;

public class KeyInput : MonoBehaviour
{
    public Text boolDisplay1;
    public Text boolDisplay2;
    public Text boolDisplay3;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        bool down = Input.GetKeyDown(KeyCode.DownArrow);
        bool held = Input.GetKey(KeyCode.Space);
        bool up = Input.GetKeyUp(KeyCode.UpArrow);

        boolDisplay1.text = " " + down;
        boolDisplay2.text = " " + held;
        boolDisplay3.text = " " + held;
    }

}
