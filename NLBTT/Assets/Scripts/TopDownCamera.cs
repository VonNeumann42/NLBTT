using UnityEngine;

public class TopDownCamera : MonoBehaviour
{
    public Transform player;   // Referenz zum Spieler
    public float height = 10f; // Kamera-Höhe
    public float followSpeed = 5f; // Wie schnell folgt die Kamera
    public float orthographicSize = 6f; // Zoom

    private Camera cam;

    void Start()
    {
        cam = GetComponent<Camera>();
        cam.orthographic = true;
        cam.orthographicSize = orthographicSize;
        cam.clearFlags = CameraClearFlags.SolidColor;
        cam.backgroundColor = Color.gray;

        if (player == null)
        {
            GameObject p = GameObject.FindWithTag("Player");
            if (p != null)
                player = p.transform;
        }

        // Anfangsposition auf den Spieler ausrichten
        if (player != null)
        {
            transform.position = new Vector3(player.position.x, height, player.position.z);
            transform.rotation = Quaternion.Euler(90f, 0f, 0f);
        }
    }

    void LateUpdate()
    {
        if (player != null)
            transform.position = new Vector3(player.position.x, height, player.position.z);
    }
}
