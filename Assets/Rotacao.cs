using UnityEngine;

public class Rotacao : MonoBehaviour

{
    public GameObject target;
    void Update()
    {
        transform.RotateAround(target.transform.position, Vector3.up, 90 * Time.deltaTime);

    }
}
