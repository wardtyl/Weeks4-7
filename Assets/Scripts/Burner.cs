using UnityEngine;
using UnityEngine.UI;
public class Burner : MonoBehaviour
{
    public GameObject spawningPrefab;

    public float waitDuration;
    private float waitProgress = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        waitProgress += Time.deltaTime;
        if (waitProgress > waitDuration)
        {
            GameObject spawnedObject = Instantiate(spawningPrefab, transform.position, Quaternion.identity);

            Burner spawnedBurner = spawnedObject.GetComponent<Burner>();
        }
    }
}
