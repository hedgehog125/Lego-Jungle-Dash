using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Environment {
	[CreateAssetMenu]
	public class ObstacleData : ScriptableObject {
		public GameObject prefab;
		public Vector3 offset;
	}
}