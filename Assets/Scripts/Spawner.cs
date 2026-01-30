using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject spawningPrefab;

    private float waitProgress = 0f;

    public float waitDuration;
    public float destroyDuration;
    private float destroyProgress;

    public Color pacerColour;
    public float pacerSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Destroy(gameObject, destroyDuration);

        ////EMPTY VECTOR3
        //Vector3 originPosition = Vector3.zero;

        ////EMPTY ROTATION
        //Quaternion originRotation = Quaternion.identity;

        //Instantiate(spawningPrefab, transform.position, Quaternion.identity);

        ////SPAWNING AT THE POSITION OF THE SPAWNER (WITH THE SPAWNER'S ROTATION)
        //Instantiate(spawningPrefab, transform.position, transform.rotation);

        ////SPAWNING AT THE ORIGIN
        ////Instantiate(spawningPrefab);
    }

    // Update is called once per frame
    void Update()
    {
        waitProgress += Time.deltaTime;
        if (waitProgress > waitDuration)
        {
            GameObject spawnedObject = Instantiate(spawningPrefab, transform.position, Quaternion.identity);

            //TypeOfComponent variableName = variableOfObject.GetComponent<TypeOfComponent>();

            Pacer spawnedPacer = spawnedObject.GetComponent<Pacer>();
            spawnedPacer.speed = 4;

            //set the colour of our pacer spawner to be pacerColour
            //SpriteRenderer of the pacer
            SpriteRenderer spawnedRenderer = spawnedObject.GetComponent<SpriteRenderer>();
            spawnedRenderer.color = pacerColour;

            //Destroy(spawnedObject, destroyDuration);

            waitProgress = 0f;
        }

        
    }
public void IncreasePacerSpeed()
{
    pacerSpeed++;
    //same as pacerSpeed += 1;
}
}
