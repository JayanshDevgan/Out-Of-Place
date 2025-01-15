using Unity.VisualScripting;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] public float roomWidth = 10.0f;
    [SerializeField] public float roomLength = 10.0f;
    [SerializeField] public float roomHeight = 4f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CreateRoom();
    }

    void CreateRoom()
    {
        GameObject floor = GameObject.CreatePrimitive(PrimitiveType.Cube);
        floor.transform.localScale = new Vector3(roomWidth, 0.1f, roomLength);
        floor.transform.position = new Vector3(0f, 0f, 0f);

        GameObject ceiling = GameObject.CreatePrimitive(PrimitiveType.Cube);
        ceiling.transform.localScale = new Vector3(roomWidth, 0.1f, roomLength);
        ceiling.transform.position = new Vector3(0, roomHeight, 0);

        GameObject frontWall = GameObject.CreatePrimitive(PrimitiveType.Cube);
        frontWall.transform.localScale = new Vector3( roomWidth, roomHeight, 0.1f);
        frontWall.transform.position = new Vector3(0, roomHeight /2, roomLength /2);

        GameObject backWall = GameObject.CreatePrimitive(PrimitiveType.Cube);
        backWall.transform.localScale = new Vector3(roomWidth, roomHeight, 0.1f);
        backWall.transform.position = new Vector3(0, roomHeight / 2, roomLength / 2);

        GameObject leftWall = GameObject.CreatePrimitive(PrimitiveType.Cube);
        leftWall.transform.localScale = new Vector3(0.1f, roomHeight, roomLength);
        leftWall.transform.position = new Vector3(-roomWidth / 2, roomHeight / 2, 0);

        GameObject rightWall = GameObject.CreatePrimitive(PrimitiveType.Cube);
        rightWall.transform.localScale = new Vector3(0.1f, roomHeight, roomLength);
        rightWall.transform.position = new Vector3(roomWidth / 2, roomHeight / 2, 0);
    }
}
