using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000004 RID: 4
	public class ControllerColliderHit : Object
	{
		// Token: 0x06000001 RID: 1 RVA: 0x000048B4 File Offset: 0x00002AB4
		// Note: this type is marked as 'beforefieldinit'.
		static ControllerColliderHit()
		{
			Il2CppClassPointerStore<ControllerColliderHit>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.PhysicsModule.dll", "UnityEngine", "ControllerColliderHit");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerColliderHit>.NativeClassPtr);
			ControllerColliderHit.NativeFieldInfoPtr_m_Controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerColliderHit>.NativeClassPtr, "m_Controller");
			ControllerColliderHit.NativeFieldInfoPtr_m_Collider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerColliderHit>.NativeClassPtr, "m_Collider");
			ControllerColliderHit.NativeFieldInfoPtr_m_Point = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerColliderHit>.NativeClassPtr, "m_Point");
			ControllerColliderHit.NativeFieldInfoPtr_m_Normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerColliderHit>.NativeClassPtr, "m_Normal");
			ControllerColliderHit.NativeFieldInfoPtr_m_MoveDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerColliderHit>.NativeClassPtr, "m_MoveDirection");
			ControllerColliderHit.NativeFieldInfoPtr_m_MoveLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerColliderHit>.NativeClassPtr, "m_MoveLength");
			ControllerColliderHit.NativeFieldInfoPtr_m_Push = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerColliderHit>.NativeClassPtr, "m_Push");
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002050 File Offset: 0x00000250
		public ControllerColliderHit(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000003 RID: 3 RVA: 0x00004970 File Offset: 0x00002B70
		// (set) Token: 0x06000004 RID: 4 RVA: 0x00002059 File Offset: 0x00000259
		public unsafe CharacterController m_Controller
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerColliderHit.NativeFieldInfoPtr_m_Controller);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerColliderHit.NativeFieldInfoPtr_m_Controller), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000005 RID: 5 RVA: 0x000049A0 File Offset: 0x00002BA0
		// (set) Token: 0x06000006 RID: 6 RVA: 0x00002078 File Offset: 0x00000278
		public unsafe Collider m_Collider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerColliderHit.NativeFieldInfoPtr_m_Collider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerColliderHit.NativeFieldInfoPtr_m_Collider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000007 RID: 7 RVA: 0x000049D0 File Offset: 0x00002BD0
		// (set) Token: 0x06000008 RID: 8 RVA: 0x00002097 File Offset: 0x00000297
		public unsafe Vector3 m_Point
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerColliderHit.NativeFieldInfoPtr_m_Point);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerColliderHit.NativeFieldInfoPtr_m_Point)) = value;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000009 RID: 9 RVA: 0x000049F8 File Offset: 0x00002BF8
		// (set) Token: 0x0600000A RID: 10 RVA: 0x000020B2 File Offset: 0x000002B2
		public unsafe Vector3 m_Normal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerColliderHit.NativeFieldInfoPtr_m_Normal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerColliderHit.NativeFieldInfoPtr_m_Normal)) = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000B RID: 11 RVA: 0x00004A20 File Offset: 0x00002C20
		// (set) Token: 0x0600000C RID: 12 RVA: 0x000020CD File Offset: 0x000002CD
		public unsafe Vector3 m_MoveDirection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerColliderHit.NativeFieldInfoPtr_m_MoveDirection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerColliderHit.NativeFieldInfoPtr_m_MoveDirection)) = value;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000D RID: 13 RVA: 0x00004A48 File Offset: 0x00002C48
		// (set) Token: 0x0600000E RID: 14 RVA: 0x000020E8 File Offset: 0x000002E8
		public unsafe float m_MoveLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerColliderHit.NativeFieldInfoPtr_m_MoveLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerColliderHit.NativeFieldInfoPtr_m_MoveLength)) = value;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000F RID: 15 RVA: 0x00004A70 File Offset: 0x00002C70
		// (set) Token: 0x06000010 RID: 16 RVA: 0x00002103 File Offset: 0x00000303
		public unsafe int m_Push
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerColliderHit.NativeFieldInfoPtr_m_Push);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerColliderHit.NativeFieldInfoPtr_m_Push)) = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000011 RID: 17 RVA: 0x00004A98 File Offset: 0x00002C98
		public CharacterController controller
		{
			get
			{
				return this.m_Controller;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000012 RID: 18 RVA: 0x00004AB0 File Offset: 0x00002CB0
		public Collider collider
		{
			get
			{
				return this.m_Collider;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000013 RID: 19 RVA: 0x00004AC8 File Offset: 0x00002CC8
		public Rigidbody rigidbody
		{
			get
			{
				return this.m_Collider.attachedRigidbody;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000014 RID: 20 RVA: 0x00004AE8 File Offset: 0x00002CE8
		public GameObject gameObject
		{
			get
			{
				return this.m_Collider.gameObject;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000015 RID: 21 RVA: 0x00004B08 File Offset: 0x00002D08
		public Transform transform
		{
			get
			{
				return this.m_Collider.transform;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000016 RID: 22 RVA: 0x00004B28 File Offset: 0x00002D28
		public Vector3 point
		{
			get
			{
				return this.m_Point;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00004B40 File Offset: 0x00002D40
		public Vector3 normal
		{
			get
			{
				return this.m_Normal;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000018 RID: 24 RVA: 0x00004B58 File Offset: 0x00002D58
		public Vector3 moveDirection
		{
			get
			{
				return this.m_MoveDirection;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000019 RID: 25 RVA: 0x00004B70 File Offset: 0x00002D70
		public float moveLength
		{
			get
			{
				return this.m_MoveLength;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600001A RID: 26 RVA: 0x00004B88 File Offset: 0x00002D88
		// (set) Token: 0x0600001B RID: 27 RVA: 0x0000211E File Offset: 0x0000031E
		public bool push
		{
			get
			{
				return this.m_Push != 0;
			}
			set
			{
				this.m_Push = (value ? 1 : 0);
			}
		}

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeFieldInfoPtr_m_Controller;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeFieldInfoPtr_m_Collider;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeFieldInfoPtr_m_Point;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeFieldInfoPtr_m_Normal;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeFieldInfoPtr_m_MoveDirection;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeFieldInfoPtr_m_MoveLength;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeFieldInfoPtr_m_Push;
	}
}
