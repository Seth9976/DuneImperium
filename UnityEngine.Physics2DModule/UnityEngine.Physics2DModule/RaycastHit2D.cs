using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000007 RID: 7
	[StructLayout(2)]
	public struct RaycastHit2D
	{
		// Token: 0x0600021F RID: 543 RVA: 0x00009FE0 File Offset: 0x000081E0
		// Note: this type is marked as 'beforefieldinit'.
		static RaycastHit2D()
		{
			Il2CppClassPointerStore<RaycastHit2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Physics2DModule.dll", "UnityEngine", "RaycastHit2D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RaycastHit2D>.NativeClassPtr);
			RaycastHit2D.NativeFieldInfoPtr_m_Centroid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastHit2D>.NativeClassPtr, "m_Centroid");
			RaycastHit2D.NativeFieldInfoPtr_m_Point = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastHit2D>.NativeClassPtr, "m_Point");
			RaycastHit2D.NativeFieldInfoPtr_m_Normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastHit2D>.NativeClassPtr, "m_Normal");
			RaycastHit2D.NativeFieldInfoPtr_m_Distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastHit2D>.NativeClassPtr, "m_Distance");
			RaycastHit2D.NativeFieldInfoPtr_m_Fraction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastHit2D>.NativeClassPtr, "m_Fraction");
			RaycastHit2D.NativeFieldInfoPtr_m_Collider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastHit2D>.NativeClassPtr, "m_Collider");
			RaycastHit2D.NativeMethodInfoPtr_get_point_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaycastHit2D>.NativeClassPtr, 100663338);
			RaycastHit2D.NativeMethodInfoPtr_get_normal_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaycastHit2D>.NativeClassPtr, 100663339);
			RaycastHit2D.NativeMethodInfoPtr_get_distance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaycastHit2D>.NativeClassPtr, 100663340);
			RaycastHit2D.NativeMethodInfoPtr_get_collider_Public_get_Collider2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaycastHit2D>.NativeClassPtr, 100663341);
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000220 RID: 544 RVA: 0x0000A0D8 File Offset: 0x000082D8
		// (set) Token: 0x06000227 RID: 551 RVA: 0x00002B5A File Offset: 0x00000D5A
		public unsafe Vector2 point
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 648747, RefRangeEnd = 648748, XrefRangeStart = 648747, XrefRangeEnd = 648748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaycastHit2D.NativeMethodInfoPtr_get_point_Public_get_Vector2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Point = value;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000221 RID: 545 RVA: 0x0000A108 File Offset: 0x00008308
		// (set) Token: 0x06000228 RID: 552 RVA: 0x00002B64 File Offset: 0x00000D64
		public unsafe Vector2 normal
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 1253368, RefRangeEnd = 1253380, XrefRangeStart = 1253368, XrefRangeEnd = 1253380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaycastHit2D.NativeMethodInfoPtr_get_normal_Public_get_Vector2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Normal = value;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000222 RID: 546 RVA: 0x0000A138 File Offset: 0x00008338
		// (set) Token: 0x06000229 RID: 553 RVA: 0x00002B6E File Offset: 0x00000D6E
		public unsafe float distance
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 644459, RefRangeEnd = 644463, XrefRangeStart = 644459, XrefRangeEnd = 644463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaycastHit2D.NativeMethodInfoPtr_get_distance_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Distance = value;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000223 RID: 547 RVA: 0x0000A168 File Offset: 0x00008368
		public unsafe Collider2D collider
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1268410, RefRangeEnd = 1268412, XrefRangeStart = 1268405, XrefRangeEnd = 1268410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaycastHit2D.NativeMethodInfoPtr_get_collider_Public_get_Collider2D_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Collider2D>(intPtr3) : null;
			}
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00002B3E File Offset: 0x00000D3E
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RaycastHit2D>.NativeClassPtr, ref this));
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000225 RID: 549 RVA: 0x0000A19C File Offset: 0x0000839C
		// (set) Token: 0x06000226 RID: 550 RVA: 0x00002B50 File Offset: 0x00000D50
		public Vector2 centroid
		{
			get
			{
				return this.m_Centroid;
			}
			set
			{
				this.m_Centroid = value;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600022A RID: 554 RVA: 0x0000A1B4 File Offset: 0x000083B4
		// (set) Token: 0x0600022B RID: 555 RVA: 0x00002B78 File Offset: 0x00000D78
		public float fraction
		{
			get
			{
				return this.m_Fraction;
			}
			set
			{
				this.m_Fraction = value;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600022C RID: 556 RVA: 0x0000A1CC File Offset: 0x000083CC
		public Rigidbody2D rigidbody
		{
			get
			{
				return (this.collider != null) ? this.collider.attachedRigidbody : null;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600022D RID: 557 RVA: 0x0000A1FC File Offset: 0x000083FC
		public Transform transform
		{
			get
			{
				Rigidbody2D rigidbody = this.rigidbody;
				bool flag = rigidbody != null;
				Transform transform;
				if (flag)
				{
					transform = rigidbody.transform;
				}
				else
				{
					bool flag2 = this.collider != null;
					if (flag2)
					{
						transform = this.collider.transform;
					}
					else
					{
						transform = null;
					}
				}
				return transform;
			}
		}

		// Token: 0x0600022E RID: 558 RVA: 0x0000A248 File Offset: 0x00008448
		public static implicit operator bool(RaycastHit2D hit)
		{
			return hit.collider != null;
		}

		// Token: 0x0600022F RID: 559 RVA: 0x0000A268 File Offset: 0x00008468
		public int CompareTo(RaycastHit2D other)
		{
			bool flag = this.collider == null;
			int num;
			if (flag)
			{
				num = 1;
			}
			else
			{
				bool flag2 = other.collider == null;
				if (flag2)
				{
					num = -1;
				}
				else
				{
					num = this.fraction.CompareTo(other.fraction);
				}
			}
			return num;
		}

		// Token: 0x040000CE RID: 206
		private static readonly IntPtr NativeFieldInfoPtr_m_Centroid;

		// Token: 0x040000CF RID: 207
		private static readonly IntPtr NativeFieldInfoPtr_m_Point;

		// Token: 0x040000D0 RID: 208
		private static readonly IntPtr NativeFieldInfoPtr_m_Normal;

		// Token: 0x040000D1 RID: 209
		private static readonly IntPtr NativeFieldInfoPtr_m_Distance;

		// Token: 0x040000D2 RID: 210
		private static readonly IntPtr NativeFieldInfoPtr_m_Fraction;

		// Token: 0x040000D3 RID: 211
		private static readonly IntPtr NativeFieldInfoPtr_m_Collider;

		// Token: 0x040000D4 RID: 212
		private static readonly IntPtr NativeMethodInfoPtr_get_point_Public_get_Vector2_0;

		// Token: 0x040000D5 RID: 213
		private static readonly IntPtr NativeMethodInfoPtr_get_normal_Public_get_Vector2_0;

		// Token: 0x040000D6 RID: 214
		private static readonly IntPtr NativeMethodInfoPtr_get_distance_Public_get_Single_0;

		// Token: 0x040000D7 RID: 215
		private static readonly IntPtr NativeMethodInfoPtr_get_collider_Public_get_Collider2D_0;

		// Token: 0x040000D8 RID: 216
		[FieldOffset(0)]
		public Vector2 m_Centroid;

		// Token: 0x040000D9 RID: 217
		[FieldOffset(8)]
		public Vector2 m_Point;

		// Token: 0x040000DA RID: 218
		[FieldOffset(16)]
		public Vector2 m_Normal;

		// Token: 0x040000DB RID: 219
		[FieldOffset(24)]
		public float m_Distance;

		// Token: 0x040000DC RID: 220
		[FieldOffset(28)]
		public float m_Fraction;

		// Token: 0x040000DD RID: 221
		[FieldOffset(32)]
		public int m_Collider;
	}
}
