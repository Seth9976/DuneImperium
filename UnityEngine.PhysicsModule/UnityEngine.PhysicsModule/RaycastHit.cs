using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000009 RID: 9
	[StructLayout(2)]
	public struct RaycastHit
	{
		// Token: 0x0600016C RID: 364 RVA: 0x00007B14 File Offset: 0x00005D14
		// Note: this type is marked as 'beforefieldinit'.
		static RaycastHit()
		{
			Il2CppClassPointerStore<RaycastHit>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.PhysicsModule.dll", "UnityEngine", "RaycastHit");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RaycastHit>.NativeClassPtr);
			RaycastHit.NativeFieldInfoPtr_m_Point = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastHit>.NativeClassPtr, "m_Point");
			RaycastHit.NativeFieldInfoPtr_m_Normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastHit>.NativeClassPtr, "m_Normal");
			RaycastHit.NativeFieldInfoPtr_m_FaceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastHit>.NativeClassPtr, "m_FaceID");
			RaycastHit.NativeFieldInfoPtr_m_Distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastHit>.NativeClassPtr, "m_Distance");
			RaycastHit.NativeFieldInfoPtr_m_UV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastHit>.NativeClassPtr, "m_UV");
			RaycastHit.NativeFieldInfoPtr_m_Collider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastHit>.NativeClassPtr, "m_Collider");
			RaycastHit.NativeMethodInfoPtr_get_collider_Public_get_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaycastHit>.NativeClassPtr, 100663351);
			RaycastHit.NativeMethodInfoPtr_get_point_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaycastHit>.NativeClassPtr, 100663352);
			RaycastHit.NativeMethodInfoPtr_get_normal_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaycastHit>.NativeClassPtr, 100663353);
			RaycastHit.NativeMethodInfoPtr_get_distance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaycastHit>.NativeClassPtr, 100663354);
			RaycastHit.NativeMethodInfoPtr_get_transform_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaycastHit>.NativeClassPtr, 100663355);
			RaycastHit.NativeMethodInfoPtr_get_rigidbody_Public_get_Rigidbody_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaycastHit>.NativeClassPtr, 100663356);
			RaycastHit.CalculateRaycastTexCoord_InjectedDelegateField = IL2CPP.ResolveICall<RaycastHit.CalculateRaycastTexCoord_InjectedDelegate>("UnityEngine.RaycastHit::CalculateRaycastTexCoord_Injected");
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600016D RID: 365 RVA: 0x00007C44 File Offset: 0x00005E44
		public unsafe Collider collider
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 1255024, RefRangeEnd = 1255036, XrefRangeStart = 1255019, XrefRangeEnd = 1255024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaycastHit.NativeMethodInfoPtr_get_collider_Public_get_Collider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr3) : null;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600016E RID: 366 RVA: 0x00007C78 File Offset: 0x00005E78
		// (set) Token: 0x06000175 RID: 373 RVA: 0x000028E9 File Offset: 0x00000AE9
		public unsafe Vector3 point
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 648521, RefRangeEnd = 648525, XrefRangeStart = 648521, XrefRangeEnd = 648525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaycastHit.NativeMethodInfoPtr_get_point_Public_get_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Point = value;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600016F RID: 367 RVA: 0x00007CA8 File Offset: 0x00005EA8
		// (set) Token: 0x06000176 RID: 374 RVA: 0x000028F3 File Offset: 0x00000AF3
		public unsafe Vector3 normal
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 648525, RefRangeEnd = 648526, XrefRangeStart = 648525, XrefRangeEnd = 648526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaycastHit.NativeMethodInfoPtr_get_normal_Public_get_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Normal = value;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000170 RID: 368 RVA: 0x00007CD8 File Offset: 0x00005ED8
		// (set) Token: 0x06000179 RID: 377 RVA: 0x0000290C File Offset: 0x00000B0C
		public unsafe float distance
		{
			[CallerCount(53)]
			[CachedScanResults(RefRangeStart = 1252657, RefRangeEnd = 1252710, XrefRangeStart = 1252657, XrefRangeEnd = 1252710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaycastHit.NativeMethodInfoPtr_get_distance_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Distance = value;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000171 RID: 369 RVA: 0x00007D08 File Offset: 0x00005F08
		public unsafe Transform transform
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1255045, RefRangeEnd = 1255049, XrefRangeStart = 1255036, XrefRangeEnd = 1255045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaycastHit.NativeMethodInfoPtr_get_transform_Public_get_Transform_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000172 RID: 370 RVA: 0x00007D3C File Offset: 0x00005F3C
		public unsafe Rigidbody rigidbody
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1255057, RefRangeEnd = 1255058, XrefRangeStart = 1255049, XrefRangeEnd = 1255057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaycastHit.NativeMethodInfoPtr_get_rigidbody_Public_get_Rigidbody_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr3) : null;
			}
		}

		// Token: 0x06000173 RID: 371 RVA: 0x000028D7 File Offset: 0x00000AD7
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RaycastHit>.NativeClassPtr, ref this));
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000174 RID: 372 RVA: 0x00007D70 File Offset: 0x00005F70
		public int colliderInstanceID
		{
			get
			{
				return this.m_Collider;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000177 RID: 375 RVA: 0x00007D88 File Offset: 0x00005F88
		// (set) Token: 0x06000178 RID: 376 RVA: 0x000028FD File Offset: 0x00000AFD
		public Vector3 barycentricCoordinate
		{
			get
			{
				return new Vector3(1f - (this.m_UV.y + this.m_UV.x), this.m_UV.x, this.m_UV.y);
			}
			set
			{
				this.m_UV = value;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600017A RID: 378 RVA: 0x00007DD4 File Offset: 0x00005FD4
		public int triangleIndex
		{
			get
			{
				return (int)this.m_FaceID;
			}
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00007DEC File Offset: 0x00005FEC
		public static Vector2 CalculateRaycastTexCoord(int colliderInstanceID, Vector2 uv, Vector3 pos, uint face, int textcoord)
		{
			Vector2 vector;
			RaycastHit.CalculateRaycastTexCoord_Injected(colliderInstanceID, ref uv, ref pos, face, textcoord, out vector);
			return vector;
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600017C RID: 380 RVA: 0x00007E0C File Offset: 0x0000600C
		public Vector2 textureCoord
		{
			get
			{
				return RaycastHit.CalculateRaycastTexCoord(this.m_Collider, this.m_UV, this.m_Point, this.m_FaceID, 0);
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600017D RID: 381 RVA: 0x00007E3C File Offset: 0x0000603C
		public Vector2 textureCoord2
		{
			get
			{
				return RaycastHit.CalculateRaycastTexCoord(this.m_Collider, this.m_UV, this.m_Point, this.m_FaceID, 1);
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600017E RID: 382 RVA: 0x00007E6C File Offset: 0x0000606C
		public ArticulationBody articulationBody
		{
			get
			{
				return (this.collider != null) ? this.collider.attachedArticulationBody : null;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x0600017F RID: 383 RVA: 0x00007E9C File Offset: 0x0000609C
		public Vector2 lightmapCoord
		{
			get
			{
				Vector2 vector = RaycastHit.CalculateRaycastTexCoord(this.m_Collider, this.m_UV, this.m_Point, this.m_FaceID, 1);
				bool flag = this.collider.GetComponent<Renderer>() != null;
				if (flag)
				{
					Vector4 lightmapScaleOffset = this.collider.GetComponent<Renderer>().lightmapScaleOffset;
					vector.x = vector.x * lightmapScaleOffset.x + lightmapScaleOffset.z;
					vector.y = vector.y * lightmapScaleOffset.y + lightmapScaleOffset.w;
				}
				return vector;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000180 RID: 384 RVA: 0x00007F2C File Offset: 0x0000612C
		public Vector2 textureCoord1
		{
			get
			{
				return this.textureCoord2;
			}
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00002916 File Offset: 0x00000B16
		public static void CalculateRaycastTexCoord_Injected(int colliderInstanceID, ref Vector2 uv, ref Vector3 pos, uint face, int textcoord, out Vector2 ret)
		{
			RaycastHit.CalculateRaycastTexCoord_InjectedDelegateField(colliderInstanceID, ref uv, ref pos, face, textcoord, out ret);
		}

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeFieldInfoPtr_m_Point;

		// Token: 0x040000B1 RID: 177
		private static readonly IntPtr NativeFieldInfoPtr_m_Normal;

		// Token: 0x040000B2 RID: 178
		private static readonly IntPtr NativeFieldInfoPtr_m_FaceID;

		// Token: 0x040000B3 RID: 179
		private static readonly IntPtr NativeFieldInfoPtr_m_Distance;

		// Token: 0x040000B4 RID: 180
		private static readonly IntPtr NativeFieldInfoPtr_m_UV;

		// Token: 0x040000B5 RID: 181
		private static readonly IntPtr NativeFieldInfoPtr_m_Collider;

		// Token: 0x040000B6 RID: 182
		private static readonly IntPtr NativeMethodInfoPtr_get_collider_Public_get_Collider_0;

		// Token: 0x040000B7 RID: 183
		private static readonly IntPtr NativeMethodInfoPtr_get_point_Public_get_Vector3_0;

		// Token: 0x040000B8 RID: 184
		private static readonly IntPtr NativeMethodInfoPtr_get_normal_Public_get_Vector3_0;

		// Token: 0x040000B9 RID: 185
		private static readonly IntPtr NativeMethodInfoPtr_get_distance_Public_get_Single_0;

		// Token: 0x040000BA RID: 186
		private static readonly IntPtr NativeMethodInfoPtr_get_transform_Public_get_Transform_0;

		// Token: 0x040000BB RID: 187
		private static readonly IntPtr NativeMethodInfoPtr_get_rigidbody_Public_get_Rigidbody_0;

		// Token: 0x040000BC RID: 188
		[FieldOffset(0)]
		public Vector3 m_Point;

		// Token: 0x040000BD RID: 189
		[FieldOffset(12)]
		public Vector3 m_Normal;

		// Token: 0x040000BE RID: 190
		[FieldOffset(24)]
		public uint m_FaceID;

		// Token: 0x040000BF RID: 191
		[FieldOffset(28)]
		public float m_Distance;

		// Token: 0x040000C0 RID: 192
		[FieldOffset(32)]
		public Vector2 m_UV;

		// Token: 0x040000C1 RID: 193
		[FieldOffset(40)]
		public int m_Collider;

		// Token: 0x040000C2 RID: 194
		private static readonly RaycastHit.CalculateRaycastTexCoord_InjectedDelegate CalculateRaycastTexCoord_InjectedDelegateField;

		// Token: 0x02000075 RID: 117
		// (Invoke) Token: 0x060004C2 RID: 1218
		private delegate void CalculateRaycastTexCoord_InjectedDelegate(int colliderInstanceID, IntPtr uv, IntPtr pos, uint face, int textcoord, [Out] IntPtr ret);
	}
}
