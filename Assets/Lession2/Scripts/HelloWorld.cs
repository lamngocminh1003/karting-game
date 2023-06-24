using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lession2.Scripts
{
    public class HelloWorld : MonoBehaviour
    {
        [Range(-0.01f, 0.01f)]
        [SerializeField]
        private float speed =10;
        public string playerName = "Amie";
        void Awake()
        {
            
            Debug.Log($"Hello {playerName}");
        }
        void Start()
        {
            Debug.Log("Example1.Start() was called");
        }
        void Update()
        {
            transform.Translate(Vector3.forward*speed);
        }
        void OnDisable()
        {
            Debug.Log("PrintOnDisable: script was disabled");
        }
        void OnEnable()
        {
            Debug.Log("PrintOnEnable: script was enabled");
        }
        void OnDestroy()
        {
            Debug.Log("OnDestroy1");
        }
    }
}
