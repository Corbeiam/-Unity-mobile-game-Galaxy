using UnityEngine;

public class FallDown : MonoBehaviour
{

    [SerializeField]
    private float fallSpeed;

    void Start()
    {
        int random = Random.Range(2, 6);
        fallSpeed = random;
    }

    void Update()
    {
        if (transform.position.y < -5.7f)
            Destroy(gameObject);

        transform.position -= new Vector3(0, fallSpeed * Time.deltaTime);
    }
}