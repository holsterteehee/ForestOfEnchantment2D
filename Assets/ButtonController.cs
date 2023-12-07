using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public BossController bossController; // Drag the boss GameObject with the BossController script here
    public GameObject animatedObject; // Drag the GameObject with the Animator component here
    private Animator objectAnimator;
    public GameObject portal;

    void Start()
    {
        // Get the Animator component attached to the animated GameObject
        objectAnimator = animatedObject.GetComponent<Animator>();
    }

    void Update()
    {
        // Check if the player presses the 'E' key
        if (Input.GetKeyDown(KeyCode.E))
        {
            animatedObject.SetActive(true);
            objectAnimator.SetTrigger("PressButton");
            // Call the KillBoss method
            bossController.KillBoss();

            // Trigger the animation on the separate GameObject
            portal.SetActive(true);
        }
    }
}