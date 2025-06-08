using UnityEngine;

public class LInput : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            this.transform.position = new Vector3(2.4f, 3.7f, -46f);
        }       
    }
}
