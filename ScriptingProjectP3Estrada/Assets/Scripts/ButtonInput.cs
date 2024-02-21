using UnityEngine;
using UnityEngine.UI;

public class ButtonInput : MonoBehaviour
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
        bool down = Input.GetButtonDown("Jump");
        bool held = Input.GetButton("Jump");
        bool up = Input.GetButtonUp("Jump");

        boolDisplay1.text = " " + down;
        boolDisplay2.text = " " + held;
        boolDisplay3.text = " " + held;
    }
}
