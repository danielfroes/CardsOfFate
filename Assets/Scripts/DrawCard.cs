using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawCard : MonoBehaviour
{

    [SerializeField] private float drawSpeed;
    [SerializeField] private Transform deckTransform;
    private Vector3 _targetPosition;

    private void Awake() 
    {
        _targetPosition = transform.position;
    }

    private void OnEnable()
    {
        transform.position = deckTransform.position;
    }
 
    private void Update()
    {
        transform.position = Vector3.Lerp(transform.position, _targetPosition, drawSpeed*Time.deltaTime);
    }

    

}
