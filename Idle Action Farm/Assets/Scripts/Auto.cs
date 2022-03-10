using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Auto : MonoBehaviour
{
    [SerializeField] private Transform[] _target;
    private int maxTargetId;
    private const int minTargetId = -1;
    private int queueTargetId;
    private int QueueTargetId {
        get {
            queueTargetId += 1;
            if (queueTargetId < maxTargetId) return queueTargetId;
            queueTargetId = minTargetId;
            return QueueTargetId;
        }
        set => queueTargetId = value;
    }

    private void Start() {
        maxTargetId = _target.Length;
        queueTargetId = minTargetId;
    }

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")){
            foreach (Crop crop in Resources.FindObjectsOfTypeAll(typeof(Crop)) as Crop[])
            {
                crop.target = _target[QueueTargetId];
            }
            FindObjectOfType<GameManager>().ResetCrop();
            QueueTargetId = minTargetId;
        }
    }
}
