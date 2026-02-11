using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000011 RID: 17
	[StructLayout(2)]
	public struct ContactPoint
	{
		// Token: 0x06000292 RID: 658 RVA: 0x0000A028 File Offset: 0x00008228
		// Note: this type is marked as 'beforefieldinit'.
		static ContactPoint()
		{
			Il2CppClassPointerStore<ContactPoint>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.PhysicsModule.dll", "UnityEngine", "ContactPoint");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContactPoint>.NativeClassPtr);
			ContactPoint.NativeFieldInfoPtr_m_Point = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPoint>.NativeClassPtr, "m_Point");
			ContactPoint.NativeFieldInfoPtr_m_Normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPoint>.NativeClassPtr, "m_Normal");
			ContactPoint.NativeFieldInfoPtr_m_Impulse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPoint>.NativeClassPtr, "m_Impulse");
			ContactPoint.NativeFieldInfoPtr_m_ThisColliderInstanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPoint>.NativeClassPtr, "m_ThisColliderInstanceID");
			ContactPoint.NativeFieldInfoPtr_m_OtherColliderInstanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPoint>.NativeClassPtr, "m_OtherColliderInstanceID");
			ContactPoint.NativeFieldInfoPtr_m_Separation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPoint>.NativeClassPtr, "m_Separation");
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00003438 File Offset: 0x00001638
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ContactPoint>.NativeClassPtr, ref this));
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000294 RID: 660 RVA: 0x0000A0D0 File Offset: 0x000082D0
		public Vector3 point
		{
			get
			{
				return this.m_Point;
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000295 RID: 661 RVA: 0x0000A0E8 File Offset: 0x000082E8
		public Vector3 normal
		{
			get
			{
				return this.m_Normal;
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000296 RID: 662 RVA: 0x0000A100 File Offset: 0x00008300
		public Vector3 impulse
		{
			get
			{
				return this.m_Impulse;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000297 RID: 663 RVA: 0x0000A118 File Offset: 0x00008318
		public Collider thisCollider
		{
			get
			{
				return Physics.GetColliderByInstanceID(this.m_ThisColliderInstanceID);
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000298 RID: 664 RVA: 0x0000A138 File Offset: 0x00008338
		public Collider otherCollider
		{
			get
			{
				return Physics.GetColliderByInstanceID(this.m_OtherColliderInstanceID);
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000299 RID: 665 RVA: 0x0000A158 File Offset: 0x00008358
		public float separation
		{
			get
			{
				return this.m_Separation;
			}
		}

		// Token: 0x04000179 RID: 377
		private static readonly IntPtr NativeFieldInfoPtr_m_Point;

		// Token: 0x0400017A RID: 378
		private static readonly IntPtr NativeFieldInfoPtr_m_Normal;

		// Token: 0x0400017B RID: 379
		private static readonly IntPtr NativeFieldInfoPtr_m_Impulse;

		// Token: 0x0400017C RID: 380
		private static readonly IntPtr NativeFieldInfoPtr_m_ThisColliderInstanceID;

		// Token: 0x0400017D RID: 381
		private static readonly IntPtr NativeFieldInfoPtr_m_OtherColliderInstanceID;

		// Token: 0x0400017E RID: 382
		private static readonly IntPtr NativeFieldInfoPtr_m_Separation;

		// Token: 0x0400017F RID: 383
		[FieldOffset(0)]
		public Vector3 m_Point;

		// Token: 0x04000180 RID: 384
		[FieldOffset(12)]
		public Vector3 m_Normal;

		// Token: 0x04000181 RID: 385
		[FieldOffset(24)]
		public Vector3 m_Impulse;

		// Token: 0x04000182 RID: 386
		[FieldOffset(36)]
		public int m_ThisColliderInstanceID;

		// Token: 0x04000183 RID: 387
		[FieldOffset(40)]
		public int m_OtherColliderInstanceID;

		// Token: 0x04000184 RID: 388
		[FieldOffset(44)]
		public float m_Separation;
	}
}
