/*
using UnityEngine;
using UnityEngine.InputSystem;

public class HandAnimation : MonoBehaviour
{

    [SerializeField] private InputActionReference gripActionReference;
    [SerializeField] private InputActionReference triggerActionReference;

    private Animator animator;

    private string gripActionName = "Grip";
    private string triggerActionName = "Pinch";

    private void Awake()
    {
        animator = GetComponent<Animator>();
        if (animator == null)
        {
            Debug.LogError("Animator component not found on the GameObject");
        }
    }
    void Update()
    {
        if (animator == null) 
        {
            float gripValue = gripActionReference.action.readValue<float>();
            float triggerValue = triggerActionReference.action.readValue<float>();
            animator.SetFloat("Grip", gripValue);
            animator.SetFloat("Pinch", triggerValue);
        }

    }
}
*/