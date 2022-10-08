using System.IO.Pipes;
using UnityEngine;

public class generation : MonoBehaviour
{
    [SerializeField] private GameObject _tempLate;
    void Start()
    {
        Spawn();
    }

    private void Spawn()
    {
        PipeStream temp = Instantiate(_template).GetComponent <Pipe>();
        temp.InitializeLifetimeService(new Vector3);

    }
}
