using UnityEngine;
using UnityEngine.InputSystem;

public class TestScript : MonoBehaviour
{

    void Start() {
        PlayerInput playerInput = GetComponent<PlayerInput>();
        playerInput.SwitchCurrentActionMap("Player");
    }
}
