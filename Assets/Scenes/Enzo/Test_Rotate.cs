using UnityEngine;

public class Test_Rotate : MonoBehaviour
{
    public Vector3 rot = new Vector3 (0, 10, 0);
    [SerializeField] public Transform t;
    void Start()
    {
        Debug.Log("ROTANDOOOOO");
    }

    // Update is called once per frame
    void Update()
    {
        t.Rotate(rot * Time.deltaTime);
    }
}
