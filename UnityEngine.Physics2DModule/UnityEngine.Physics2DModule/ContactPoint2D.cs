using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000006 RID: 6
	[StructLayout(2)]
	public struct ContactPoint2D
	{
		// Token: 0x06000212 RID: 530 RVA: 0x00009D98 File Offset: 0x00007F98
		// Note: this type is marked as 'beforefieldinit'.
		static ContactPoint2D()
		{
			Il2CppClassPointerStore<ContactPoint2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Physics2DModule.dll", "UnityEngine", "ContactPoint2D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContactPoint2D>.NativeClassPtr);
			ContactPoint2D.NativeFieldInfoPtr_m_Point = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPoint2D>.NativeClassPtr, "m_Point");
			ContactPoint2D.NativeFieldInfoPtr_m_Normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPoint2D>.NativeClassPtr, "m_Normal");
			ContactPoint2D.NativeFieldInfoPtr_m_RelativeVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPoint2D>.NativeClassPtr, "m_RelativeVelocity");
			ContactPoint2D.NativeFieldInfoPtr_m_Separation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPoint2D>.NativeClassPtr, "m_Separation");
			ContactPoint2D.NativeFieldInfoPtr_m_NormalImpulse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPoint2D>.NativeClassPtr, "m_NormalImpulse");
			ContactPoint2D.NativeFieldInfoPtr_m_TangentImpulse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPoint2D>.NativeClassPtr, "m_TangentImpulse");
			ContactPoint2D.NativeFieldInfoPtr_m_Collider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPoint2D>.NativeClassPtr, "m_Collider");
			ContactPoint2D.NativeFieldInfoPtr_m_OtherCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPoint2D>.NativeClassPtr, "m_OtherCollider");
			ContactPoint2D.NativeFieldInfoPtr_m_Rigidbody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPoint2D>.NativeClassPtr, "m_Rigidbody");
			ContactPoint2D.NativeFieldInfoPtr_m_OtherRigidbody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPoint2D>.NativeClassPtr, "m_OtherRigidbody");
			ContactPoint2D.NativeFieldInfoPtr_m_Enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPoint2D>.NativeClassPtr, "m_Enabled");
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00002B2C File Offset: 0x00000D2C
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ContactPoint2D>.NativeClassPtr, ref this));
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000214 RID: 532 RVA: 0x00009EA4 File Offset: 0x000080A4
		public Vector2 point
		{
			get
			{
				return this.m_Point;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000215 RID: 533 RVA: 0x00009EBC File Offset: 0x000080BC
		public Vector2 normal
		{
			get
			{
				return this.m_Normal;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000216 RID: 534 RVA: 0x00009ED4 File Offset: 0x000080D4
		public float separation
		{
			get
			{
				return this.m_Separation;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000217 RID: 535 RVA: 0x00009EEC File Offset: 0x000080EC
		public float normalImpulse
		{
			get
			{
				return this.m_NormalImpulse;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000218 RID: 536 RVA: 0x00009F04 File Offset: 0x00008104
		public float tangentImpulse
		{
			get
			{
				return this.m_TangentImpulse;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000219 RID: 537 RVA: 0x00009F1C File Offset: 0x0000811C
		public Vector2 relativeVelocity
		{
			get
			{
				return this.m_RelativeVelocity;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600021A RID: 538 RVA: 0x00009F34 File Offset: 0x00008134
		public Collider2D collider
		{
			get
			{
				return Object.FindObjectFromInstanceID(this.m_Collider).TryCast<Collider2D>();
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x0600021B RID: 539 RVA: 0x00009F58 File Offset: 0x00008158
		public Collider2D otherCollider
		{
			get
			{
				return Object.FindObjectFromInstanceID(this.m_OtherCollider).TryCast<Collider2D>();
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600021C RID: 540 RVA: 0x00009F7C File Offset: 0x0000817C
		public Rigidbody2D rigidbody
		{
			get
			{
				return Object.FindObjectFromInstanceID(this.m_Rigidbody).TryCast<Rigidbody2D>();
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600021D RID: 541 RVA: 0x00009FA0 File Offset: 0x000081A0
		public Rigidbody2D otherRigidbody
		{
			get
			{
				return Object.FindObjectFromInstanceID(this.m_OtherRigidbody).TryCast<Rigidbody2D>();
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600021E RID: 542 RVA: 0x00009FC4 File Offset: 0x000081C4
		public bool enabled
		{
			get
			{
				return this.m_Enabled == 1;
			}
		}

		// Token: 0x040000B8 RID: 184
		private static readonly IntPtr NativeFieldInfoPtr_m_Point;

		// Token: 0x040000B9 RID: 185
		private static readonly IntPtr NativeFieldInfoPtr_m_Normal;

		// Token: 0x040000BA RID: 186
		private static readonly IntPtr NativeFieldInfoPtr_m_RelativeVelocity;

		// Token: 0x040000BB RID: 187
		private static readonly IntPtr NativeFieldInfoPtr_m_Separation;

		// Token: 0x040000BC RID: 188
		private static readonly IntPtr NativeFieldInfoPtr_m_NormalImpulse;

		// Token: 0x040000BD RID: 189
		private static readonly IntPtr NativeFieldInfoPtr_m_TangentImpulse;

		// Token: 0x040000BE RID: 190
		private static readonly IntPtr NativeFieldInfoPtr_m_Collider;

		// Token: 0x040000BF RID: 191
		private static readonly IntPtr NativeFieldInfoPtr_m_OtherCollider;

		// Token: 0x040000C0 RID: 192
		private static readonly IntPtr NativeFieldInfoPtr_m_Rigidbody;

		// Token: 0x040000C1 RID: 193
		private static readonly IntPtr NativeFieldInfoPtr_m_OtherRigidbody;

		// Token: 0x040000C2 RID: 194
		private static readonly IntPtr NativeFieldInfoPtr_m_Enabled;

		// Token: 0x040000C3 RID: 195
		[FieldOffset(0)]
		public Vector2 m_Point;

		// Token: 0x040000C4 RID: 196
		[FieldOffset(8)]
		public Vector2 m_Normal;

		// Token: 0x040000C5 RID: 197
		[FieldOffset(16)]
		public Vector2 m_RelativeVelocity;

		// Token: 0x040000C6 RID: 198
		[FieldOffset(24)]
		public float m_Separation;

		// Token: 0x040000C7 RID: 199
		[FieldOffset(28)]
		public float m_NormalImpulse;

		// Token: 0x040000C8 RID: 200
		[FieldOffset(32)]
		public float m_TangentImpulse;

		// Token: 0x040000C9 RID: 201
		[FieldOffset(36)]
		public int m_Collider;

		// Token: 0x040000CA RID: 202
		[FieldOffset(40)]
		public int m_OtherCollider;

		// Token: 0x040000CB RID: 203
		[FieldOffset(44)]
		public int m_Rigidbody;

		// Token: 0x040000CC RID: 204
		[FieldOffset(48)]
		public int m_OtherRigidbody;

		// Token: 0x040000CD RID: 205
		[FieldOffset(52)]
		public int m_Enabled;
	}
}
