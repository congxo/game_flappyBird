
using UnityEngine;
public class SpawnPipe : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pipe;
    public float spawnRate = 2;
    private float time = 0;
    public float offsetHeight = 1;

    void Start()
    {
        spawnPipe(pipe);
    }

    // Update is called once per frame
    void Update()
    {
        if (time < spawnRate)
        {
            time += Time.deltaTime;
        }
        else
        {
            spawnPipe(pipe);
            time = 0;
        }
    }
   void spawnPipe(GameObject gameObject)
{
    float highest = transform.position.y + offsetHeight;
    float lowest = transform.position.y - offsetHeight;
    float randomY = Random.Range(lowest, highest);

    Vector3 spawPosition = new Vector3(transform.position.x, randomY, 0);

    Instantiate(gameObject, spawPosition, transform.rotation);
}

}
