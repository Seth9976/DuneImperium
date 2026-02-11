using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace UnityEngine.AI
{
	// Token: 0x0200000A RID: 10
	public sealed class NavMeshObstacle : Behaviour
	{
		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000084 RID: 132 RVA: 0x0000277F File Offset: 0x0000097F
		// (set) Token: 0x06000085 RID: 133 RVA: 0x00002791 File Offset: 0x00000991
		public float height
		{
			get
			{
				return NavMeshObstacle.get_heightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				NavMeshObstacle.set_heightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000086 RID: 134 RVA: 0x000027A4 File Offset: 0x000009A4
		// (set) Token: 0x06000087 RID: 135 RVA: 0x000027B6 File Offset: 0x000009B6
		public float radius
		{
			get
			{
				return NavMeshObstacle.get_radiusDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				NavMeshObstacle.set_radiusDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000088 RID: 136 RVA: 0x00003524 File Offset: 0x00001724
		// (set) Token: 0x06000089 RID: 137 RVA: 0x000027C9 File Offset: 0x000009C9
		public Vector3 velocity
		{
			get
			{
				Vector3 vector;
				this.get_velocity_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_velocity_Injected(ref value);
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600008A RID: 138 RVA: 0x000027D3 File Offset: 0x000009D3
		// (set) Token: 0x0600008B RID: 139 RVA: 0x000027E5 File Offset: 0x000009E5
		public bool carving
		{
			get
			{
				return NavMeshObstacle.get_carvingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				NavMeshObstacle.set_carvingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600008C RID: 140 RVA: 0x000027F8 File Offset: 0x000009F8
		// (set) Token: 0x0600008D RID: 141 RVA: 0x0000280A File Offset: 0x00000A0A
		public bool carveOnlyStationary
		{
			get
			{
				return NavMeshObstacle.get_carveOnlyStationaryDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				NavMeshObstacle.set_carveOnlyStationaryDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600008E RID: 142 RVA: 0x0000281D File Offset: 0x00000A1D
		// (set) Token: 0x0600008F RID: 143 RVA: 0x0000282F File Offset: 0x00000A2F
		public float carvingMoveThreshold
		{
			get
			{
				return NavMeshObstacle.get_carvingMoveThresholdDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				NavMeshObstacle.set_carvingMoveThresholdDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000090 RID: 144 RVA: 0x00002842 File Offset: 0x00000A42
		// (set) Token: 0x06000091 RID: 145 RVA: 0x00002854 File Offset: 0x00000A54
		public float carvingTimeToStationary
		{
			get
			{
				return NavMeshObstacle.get_carvingTimeToStationaryDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				NavMeshObstacle.set_carvingTimeToStationaryDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000092 RID: 146 RVA: 0x00002867 File Offset: 0x00000A67
		// (set) Token: 0x06000093 RID: 147 RVA: 0x00002879 File Offset: 0x00000A79
		public NavMeshObstacleShape shape
		{
			get
			{
				return NavMeshObstacle.get_shapeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				NavMeshObstacle.set_shapeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000094 RID: 148 RVA: 0x0000353C File Offset: 0x0000173C
		// (set) Token: 0x06000095 RID: 149 RVA: 0x0000288C File Offset: 0x00000A8C
		public Vector3 center
		{
			get
			{
				Vector3 vector;
				this.get_center_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_center_Injected(ref value);
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000096 RID: 150 RVA: 0x00003554 File Offset: 0x00001754
		// (set) Token: 0x06000097 RID: 151 RVA: 0x00002896 File Offset: 0x00000A96
		public Vector3 size
		{
			get
			{
				Vector3 vector;
				this.get_size_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_size_Injected(ref value);
			}
		}

		// Token: 0x06000098 RID: 152 RVA: 0x000028A0 File Offset: 0x00000AA0
		public void FitExtents()
		{
			NavMeshObstacle.FitExtentsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000099 RID: 153 RVA: 0x000028B2 File Offset: 0x00000AB2
		public void get_velocity_Injected(out Vector3 ret)
		{
			NavMeshObstacle.get_velocity_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x000028C5 File Offset: 0x00000AC5
		public void set_velocity_Injected(ref Vector3 value)
		{
			NavMeshObstacle.set_velocity_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x0600009B RID: 155 RVA: 0x000028D8 File Offset: 0x00000AD8
		public void get_center_Injected(out Vector3 ret)
		{
			NavMeshObstacle.get_center_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x000028EB File Offset: 0x00000AEB
		public void set_center_Injected(ref Vector3 value)
		{
			NavMeshObstacle.set_center_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x0600009D RID: 157 RVA: 0x000028FE File Offset: 0x00000AFE
		public void get_size_Injected(out Vector3 ret)
		{
			NavMeshObstacle.get_size_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00002911 File Offset: 0x00000B11
		public void set_size_Injected(ref Vector3 value)
		{
			NavMeshObstacle.set_size_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x0400007C RID: 124
		private static readonly NavMeshObstacle.get_heightDelegate get_heightDelegateField = IL2CPP.ResolveICall<NavMeshObstacle.get_heightDelegate>("UnityEngine.AI.NavMeshObstacle::get_height");

		// Token: 0x0400007D RID: 125
		private static readonly NavMeshObstacle.set_heightDelegate set_heightDelegateField = IL2CPP.ResolveICall<NavMeshObstacle.set_heightDelegate>("UnityEngine.AI.NavMeshObstacle::set_height");

		// Token: 0x0400007E RID: 126
		private static readonly NavMeshObstacle.get_radiusDelegate get_radiusDelegateField = IL2CPP.ResolveICall<NavMeshObstacle.get_radiusDelegate>("UnityEngine.AI.NavMeshObstacle::get_radius");

		// Token: 0x0400007F RID: 127
		private static readonly NavMeshObstacle.set_radiusDelegate set_radiusDelegateField = IL2CPP.ResolveICall<NavMeshObstacle.set_radiusDelegate>("UnityEngine.AI.NavMeshObstacle::set_radius");

		// Token: 0x04000080 RID: 128
		private static readonly NavMeshObstacle.get_carvingDelegate get_carvingDelegateField = IL2CPP.ResolveICall<NavMeshObstacle.get_carvingDelegate>("UnityEngine.AI.NavMeshObstacle::get_carving");

		// Token: 0x04000081 RID: 129
		private static readonly NavMeshObstacle.set_carvingDelegate set_carvingDelegateField = IL2CPP.ResolveICall<NavMeshObstacle.set_carvingDelegate>("UnityEngine.AI.NavMeshObstacle::set_carving");

		// Token: 0x04000082 RID: 130
		private static readonly NavMeshObstacle.get_carveOnlyStationaryDelegate get_carveOnlyStationaryDelegateField = IL2CPP.ResolveICall<NavMeshObstacle.get_carveOnlyStationaryDelegate>("UnityEngine.AI.NavMeshObstacle::get_carveOnlyStationary");

		// Token: 0x04000083 RID: 131
		private static readonly NavMeshObstacle.set_carveOnlyStationaryDelegate set_carveOnlyStationaryDelegateField = IL2CPP.ResolveICall<NavMeshObstacle.set_carveOnlyStationaryDelegate>("UnityEngine.AI.NavMeshObstacle::set_carveOnlyStationary");

		// Token: 0x04000084 RID: 132
		private static readonly NavMeshObstacle.get_carvingMoveThresholdDelegate get_carvingMoveThresholdDelegateField = IL2CPP.ResolveICall<NavMeshObstacle.get_carvingMoveThresholdDelegate>("UnityEngine.AI.NavMeshObstacle::get_carvingMoveThreshold");

		// Token: 0x04000085 RID: 133
		private static readonly NavMeshObstacle.set_carvingMoveThresholdDelegate set_carvingMoveThresholdDelegateField = IL2CPP.ResolveICall<NavMeshObstacle.set_carvingMoveThresholdDelegate>("UnityEngine.AI.NavMeshObstacle::set_carvingMoveThreshold");

		// Token: 0x04000086 RID: 134
		private static readonly NavMeshObstacle.get_carvingTimeToStationaryDelegate get_carvingTimeToStationaryDelegateField = IL2CPP.ResolveICall<NavMeshObstacle.get_carvingTimeToStationaryDelegate>("UnityEngine.AI.NavMeshObstacle::get_carvingTimeToStationary");

		// Token: 0x04000087 RID: 135
		private static readonly NavMeshObstacle.set_carvingTimeToStationaryDelegate set_carvingTimeToStationaryDelegateField = IL2CPP.ResolveICall<NavMeshObstacle.set_carvingTimeToStationaryDelegate>("UnityEngine.AI.NavMeshObstacle::set_carvingTimeToStationary");

		// Token: 0x04000088 RID: 136
		private static readonly NavMeshObstacle.get_shapeDelegate get_shapeDelegateField = IL2CPP.ResolveICall<NavMeshObstacle.get_shapeDelegate>("UnityEngine.AI.NavMeshObstacle::get_shape");

		// Token: 0x04000089 RID: 137
		private static readonly NavMeshObstacle.set_shapeDelegate set_shapeDelegateField = IL2CPP.ResolveICall<NavMeshObstacle.set_shapeDelegate>("UnityEngine.AI.NavMeshObstacle::set_shape");

		// Token: 0x0400008A RID: 138
		private static readonly NavMeshObstacle.FitExtentsDelegate FitExtentsDelegateField = IL2CPP.ResolveICall<NavMeshObstacle.FitExtentsDelegate>("UnityEngine.AI.NavMeshObstacle::FitExtents");

		// Token: 0x0400008B RID: 139
		private static readonly NavMeshObstacle.get_velocity_InjectedDelegate get_velocity_InjectedDelegateField = IL2CPP.ResolveICall<NavMeshObstacle.get_velocity_InjectedDelegate>("UnityEngine.AI.NavMeshObstacle::get_velocity_Injected");

		// Token: 0x0400008C RID: 140
		private static readonly NavMeshObstacle.set_velocity_InjectedDelegate set_velocity_InjectedDelegateField = IL2CPP.ResolveICall<NavMeshObstacle.set_velocity_InjectedDelegate>("UnityEngine.AI.NavMeshObstacle::set_velocity_Injected");

		// Token: 0x0400008D RID: 141
		private static readonly NavMeshObstacle.get_center_InjectedDelegate get_center_InjectedDelegateField = IL2CPP.ResolveICall<NavMeshObstacle.get_center_InjectedDelegate>("UnityEngine.AI.NavMeshObstacle::get_center_Injected");

		// Token: 0x0400008E RID: 142
		private static readonly NavMeshObstacle.set_center_InjectedDelegate set_center_InjectedDelegateField = IL2CPP.ResolveICall<NavMeshObstacle.set_center_InjectedDelegate>("UnityEngine.AI.NavMeshObstacle::set_center_Injected");

		// Token: 0x0400008F RID: 143
		private static readonly NavMeshObstacle.get_size_InjectedDelegate get_size_InjectedDelegateField = IL2CPP.ResolveICall<NavMeshObstacle.get_size_InjectedDelegate>("UnityEngine.AI.NavMeshObstacle::get_size_Injected");

		// Token: 0x04000090 RID: 144
		private static readonly NavMeshObstacle.set_size_InjectedDelegate set_size_InjectedDelegateField = IL2CPP.ResolveICall<NavMeshObstacle.set_size_InjectedDelegate>("UnityEngine.AI.NavMeshObstacle::set_size_Injected");

		// Token: 0x02000073 RID: 115
		// (Invoke) Token: 0x06000190 RID: 400
		private delegate float get_heightDelegate(IntPtr @this);

		// Token: 0x02000074 RID: 116
		// (Invoke) Token: 0x06000192 RID: 402
		private delegate void set_heightDelegate(IntPtr @this, float value);

		// Token: 0x02000075 RID: 117
		// (Invoke) Token: 0x06000194 RID: 404
		private delegate float get_radiusDelegate(IntPtr @this);

		// Token: 0x02000076 RID: 118
		// (Invoke) Token: 0x06000196 RID: 406
		private delegate void set_radiusDelegate(IntPtr @this, float value);

		// Token: 0x02000077 RID: 119
		// (Invoke) Token: 0x06000198 RID: 408
		private delegate bool get_carvingDelegate(IntPtr @this);

		// Token: 0x02000078 RID: 120
		// (Invoke) Token: 0x0600019A RID: 410
		private delegate void set_carvingDelegate(IntPtr @this, bool value);

		// Token: 0x02000079 RID: 121
		// (Invoke) Token: 0x0600019C RID: 412
		private delegate bool get_carveOnlyStationaryDelegate(IntPtr @this);

		// Token: 0x0200007A RID: 122
		// (Invoke) Token: 0x0600019E RID: 414
		private delegate void set_carveOnlyStationaryDelegate(IntPtr @this, bool value);

		// Token: 0x0200007B RID: 123
		// (Invoke) Token: 0x060001A0 RID: 416
		private delegate float get_carvingMoveThresholdDelegate(IntPtr @this);

		// Token: 0x0200007C RID: 124
		// (Invoke) Token: 0x060001A2 RID: 418
		private delegate void set_carvingMoveThresholdDelegate(IntPtr @this, float value);

		// Token: 0x0200007D RID: 125
		// (Invoke) Token: 0x060001A4 RID: 420
		private delegate float get_carvingTimeToStationaryDelegate(IntPtr @this);

		// Token: 0x0200007E RID: 126
		// (Invoke) Token: 0x060001A6 RID: 422
		private delegate void set_carvingTimeToStationaryDelegate(IntPtr @this, float value);

		// Token: 0x0200007F RID: 127
		// (Invoke) Token: 0x060001A8 RID: 424
		private delegate NavMeshObstacleShape get_shapeDelegate(IntPtr @this);

		// Token: 0x02000080 RID: 128
		// (Invoke) Token: 0x060001AA RID: 426
		private delegate void set_shapeDelegate(IntPtr @this, NavMeshObstacleShape value);

		// Token: 0x02000081 RID: 129
		// (Invoke) Token: 0x060001AC RID: 428
		private delegate void FitExtentsDelegate(IntPtr @this);

		// Token: 0x02000082 RID: 130
		// (Invoke) Token: 0x060001AE RID: 430
		private delegate void get_velocity_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000083 RID: 131
		// (Invoke) Token: 0x060001B0 RID: 432
		private delegate void set_velocity_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000084 RID: 132
		// (Invoke) Token: 0x060001B2 RID: 434
		private delegate void get_center_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000085 RID: 133
		// (Invoke) Token: 0x060001B4 RID: 436
		private delegate void set_center_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000086 RID: 134
		// (Invoke) Token: 0x060001B6 RID: 438
		private delegate void get_size_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000087 RID: 135
		// (Invoke) Token: 0x060001B8 RID: 440
		private delegate void set_size_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
