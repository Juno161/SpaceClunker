using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 10.0f;
    public float border = 15.0f;
    public float moveX;
    private PlayerControls playerControls;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerControls = new PlayerControls();
        playerControls.Player.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(playerControls.Player.Move.ReadValue<float>() * moveSpeed * Time.deltaTime, 0, 0);
    }
}
