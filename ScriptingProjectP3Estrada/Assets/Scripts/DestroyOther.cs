using UnityEngine;

public class DestroyOther : MonoBehaviour
{
    public GameObject other;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            Destroy(other);
        }
    }
}
