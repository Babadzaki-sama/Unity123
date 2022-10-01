using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTracked : MonoBehaviour
{
    [SerializeField] Transform _birdTransform;
    [SerializeField] Vector2 _cameraOffset;


    private void Awake()
    {
        if (_birdTransform == null)
        {
            gameObject.SetActive(false);    
        }

    }

    private void LateUpdate()
    {
        transform.position = _birdTransform.position + _cameraOffset;
    }

}
