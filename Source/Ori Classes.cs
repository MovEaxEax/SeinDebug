using System;
using UnityEngine;

public class xNyuDebugEnemyData : MonoBehaviour
{
	public xNyuDebugEnemyData(Vector3 _CurrentPosition, Vector3 _StartPosition, float _Damage, bool _DamagePlayerOnly, bool _InsideFrustum, bool _FrustumOptimized, bool _IsInWater, Rect _Hitbox, CameraController _Cam)
	{
		this.CurrentPosition = "Current Position: " + _CurrentPosition.ToString();
		this.StartPosition = "Start Position: " + _StartPosition.ToString();
		this.Damage = "Damage: " + _Damage.ToString();
		this.DamagePlayerOnly = "Damage Only Player: " + _DamagePlayerOnly.ToString();
		this.InsideFrustum = "Inside Frustum: " + _InsideFrustum.ToString();
		this.FrustumOptimized = "Frustum Optimized: " + _FrustumOptimized.ToString();
		this.IsInWater = "Is In Water: " + _IsInWater.ToString();
		this.Hitbox = _Hitbox;
		this.DrawPosition = _Cam.Camera.WorldToScreenPoint(_CurrentPosition);
	}

	public string CurrentPosition;

	public string StartPosition;

	public string Damage;

	public string DamagePlayerOnly;

	public string InsideFrustum;

	public string FrustumOptimized;

	public string IsInWater;

	public Rect Hitbox;

	public Vector3 DrawPosition;
}





using System;
using UnityEngine;

public class xNyuDebugDoorData : MonoBehaviour
{
	public xNyuDebugDoorData(Vector3 _Position, string _val1, string _val2, string _val3, string _val4, string _val5, CameraController _Cam)
	{
		this.Position = "Position: " + _Position.ToString();
		this.val1 = _val1;
		this.val2 = _val2;
		this.val3 = _val3;
		this.val4 = _val4;
		this.val5 = _val5;
		this.DrawPosition = _Cam.Camera.WorldToScreenPoint(_Position);
	}

	public string Position;

	public string val1;

	public string val2;

	public string val3;

	public string val4;

	public string val5;

	public Vector3 DrawPosition;
}





using System;
using UnityEngine;

public class xNyuDebugDoorData : MonoBehaviour
{
	public xNyuDebugTeleporterData(Vector3 _Position, string _val1, string _val2, string _val3, string _val4, string _val5, CameraController _Cam)
	{
		this.Position = "Position: " + _Position.ToString();
		this.val1 = _val1;
		this.val2 = _val2;
		this.val3 = _val3;
		this.val4 = _val4;
		this.DrawPosition = _Cam.Camera.WorldToScreenPoint(_Position);
	}

	public string Position;

	public string val1;

	public string val2;

	public string val3;

	public string val4;

	public Vector3 DrawPosition;
}





using System;
using UnityEngine;

public class xNyuDebugCollectableData : MonoBehaviour
{
	public xNyuDebugCollectableData(Vector3 _Position, string _val1, string _val2, string _val3, string _val4, string _val5, CameraController _Cam)
	{
		this.Position = "Position: " + _Position.ToString();
		this.val1 = _val1;
		this.val2 = _val2;
		this.val3 = _val3;
		this.val4 = _val4;
		this.val5 = _val5;
		this.DrawPosition = _Cam.Camera.WorldToScreenPoint(_Position);
	}

	public string Position;

	public string val1;

	public string val2;

	public string val3;

	public string val4;

	public string val5;

	public Vector3 DrawPosition;
}































