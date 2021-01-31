using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new appleSO", menuName = "Apple", order = 51)]
public class AppleSO : ScriptableObject
{
    [SerializeField] private float _chance;

    public float Chacne => _chance;
}
