using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine
{
	// Token: 0x02000005 RID: 5
	public class Collision2D : Object
	{
		// Token: 0x060001F0 RID: 496 RVA: 0x000098C8 File Offset: 0x00007AC8
		// Note: this type is marked as 'beforefieldinit'.
		static Collision2D()
		{
			Il2CppClassPointerStore<Collision2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Physics2DModule.dll", "UnityEngine", "Collision2D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Collision2D>.NativeClassPtr);
			Collision2D.NativeFieldInfoPtr_m_Collider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Collision2D>.NativeClassPtr, "m_Collider");
			Collision2D.NativeFieldInfoPtr_m_OtherCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Collision2D>.NativeClassPtr, "m_OtherCollider");
			Collision2D.NativeFieldInfoPtr_m_Rigidbody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Collision2D>.NativeClassPtr, "m_Rigidbody");
			Collision2D.NativeFieldInfoPtr_m_OtherRigidbody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Collision2D>.NativeClassPtr, "m_OtherRigidbody");
			Collision2D.NativeFieldInfoPtr_m_RelativeVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Collision2D>.NativeClassPtr, "m_RelativeVelocity");
			Collision2D.NativeFieldInfoPtr_m_Enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Collision2D>.NativeClassPtr, "m_Enabled");
			Collision2D.NativeFieldInfoPtr_m_ContactCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Collision2D>.NativeClassPtr, "m_ContactCount");
			Collision2D.NativeFieldInfoPtr_m_ReusedContacts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Collision2D>.NativeClassPtr, "m_ReusedContacts");
			Collision2D.NativeFieldInfoPtr_m_LegacyContacts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Collision2D>.NativeClassPtr, "m_LegacyContacts");
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00002A1B File Offset: 0x00000C1B
		public Collision2D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060001F2 RID: 498 RVA: 0x000099AC File Offset: 0x00007BAC
		// (set) Token: 0x060001F3 RID: 499 RVA: 0x00002A24 File Offset: 0x00000C24
		public unsafe int m_Collider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collision2D.NativeFieldInfoPtr_m_Collider);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collision2D.NativeFieldInfoPtr_m_Collider)) = value;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060001F4 RID: 500 RVA: 0x000099D4 File Offset: 0x00007BD4
		// (set) Token: 0x060001F5 RID: 501 RVA: 0x00002A3F File Offset: 0x00000C3F
		public unsafe int m_OtherCollider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collision2D.NativeFieldInfoPtr_m_OtherCollider);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collision2D.NativeFieldInfoPtr_m_OtherCollider)) = value;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060001F6 RID: 502 RVA: 0x000099FC File Offset: 0x00007BFC
		// (set) Token: 0x060001F7 RID: 503 RVA: 0x00002A5A File Offset: 0x00000C5A
		public unsafe int m_Rigidbody
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collision2D.NativeFieldInfoPtr_m_Rigidbody);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collision2D.NativeFieldInfoPtr_m_Rigidbody)) = value;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x00009A24 File Offset: 0x00007C24
		// (set) Token: 0x060001F9 RID: 505 RVA: 0x00002A75 File Offset: 0x00000C75
		public unsafe int m_OtherRigidbody
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collision2D.NativeFieldInfoPtr_m_OtherRigidbody);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collision2D.NativeFieldInfoPtr_m_OtherRigidbody)) = value;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060001FA RID: 506 RVA: 0x00009A4C File Offset: 0x00007C4C
		// (set) Token: 0x060001FB RID: 507 RVA: 0x00002A90 File Offset: 0x00000C90
		public unsafe Vector2 m_RelativeVelocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collision2D.NativeFieldInfoPtr_m_RelativeVelocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collision2D.NativeFieldInfoPtr_m_RelativeVelocity)) = value;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060001FC RID: 508 RVA: 0x00009A74 File Offset: 0x00007C74
		// (set) Token: 0x060001FD RID: 509 RVA: 0x00002AAB File Offset: 0x00000CAB
		public unsafe int m_Enabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collision2D.NativeFieldInfoPtr_m_Enabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collision2D.NativeFieldInfoPtr_m_Enabled)) = value;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060001FE RID: 510 RVA: 0x00009A9C File Offset: 0x00007C9C
		// (set) Token: 0x060001FF RID: 511 RVA: 0x00002AC6 File Offset: 0x00000CC6
		public unsafe int m_ContactCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collision2D.NativeFieldInfoPtr_m_ContactCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collision2D.NativeFieldInfoPtr_m_ContactCount)) = value;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000200 RID: 512 RVA: 0x00009AC4 File Offset: 0x00007CC4
		// (set) Token: 0x06000201 RID: 513 RVA: 0x00002AE1 File Offset: 0x00000CE1
		public unsafe Il2CppStructArray<ContactPoint2D> m_ReusedContacts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collision2D.NativeFieldInfoPtr_m_ReusedContacts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ContactPoint2D>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collision2D.NativeFieldInfoPtr_m_ReusedContacts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000202 RID: 514 RVA: 0x00009AF4 File Offset: 0x00007CF4
		// (set) Token: 0x06000203 RID: 515 RVA: 0x00002B00 File Offset: 0x00000D00
		public unsafe Il2CppStructArray<ContactPoint2D> m_LegacyContacts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collision2D.NativeFieldInfoPtr_m_LegacyContacts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ContactPoint2D>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collision2D.NativeFieldInfoPtr_m_LegacyContacts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00009B24 File Offset: 0x00007D24
		public Il2CppStructArray<ContactPoint2D> GetContacts_Internal()
		{
			return (this.m_LegacyContacts == null) ? this.m_ReusedContacts : this.m_LegacyContacts;
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000205 RID: 517 RVA: 0x00009B4C File Offset: 0x00007D4C
		public Collider2D collider
		{
			get
			{
				return Object.FindObjectFromInstanceID(this.m_Collider).TryCast<Collider2D>();
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000206 RID: 518 RVA: 0x00009B70 File Offset: 0x00007D70
		public Collider2D otherCollider
		{
			get
			{
				return Object.FindObjectFromInstanceID(this.m_OtherCollider).TryCast<Collider2D>();
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000207 RID: 519 RVA: 0x00009B94 File Offset: 0x00007D94
		public Rigidbody2D rigidbody
		{
			get
			{
				return Object.FindObjectFromInstanceID(this.m_Rigidbody).TryCast<Rigidbody2D>();
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000208 RID: 520 RVA: 0x00009BB8 File Offset: 0x00007DB8
		public Rigidbody2D otherRigidbody
		{
			get
			{
				return Object.FindObjectFromInstanceID(this.m_OtherRigidbody).TryCast<Rigidbody2D>();
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000209 RID: 521 RVA: 0x00009BDC File Offset: 0x00007DDC
		public Transform transform
		{
			get
			{
				return (this.rigidbody != null) ? this.rigidbody.transform : this.collider.transform;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600020A RID: 522 RVA: 0x00009C14 File Offset: 0x00007E14
		public GameObject gameObject
		{
			get
			{
				return (this.rigidbody != null) ? this.rigidbody.gameObject : this.collider.gameObject;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600020B RID: 523 RVA: 0x00009C4C File Offset: 0x00007E4C
		public Vector2 relativeVelocity
		{
			get
			{
				return this.m_RelativeVelocity;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600020C RID: 524 RVA: 0x00009C64 File Offset: 0x00007E64
		public bool enabled
		{
			get
			{
				return this.m_Enabled == 1;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600020D RID: 525 RVA: 0x00002B1F File Offset: 0x00000D1F
		public Il2CppStructArray<ContactPoint2D> contacts
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600020E RID: 526 RVA: 0x00009C80 File Offset: 0x00007E80
		public int contactCount
		{
			get
			{
				return this.m_ContactCount;
			}
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00009C98 File Offset: 0x00007E98
		public ContactPoint2D GetContact(int index)
		{
			bool flag = index < 0 || index >= this.m_ContactCount;
			if (flag)
			{
				throw new ArgumentOutOfRangeException(String.Format("Cannot get contact at index {0}. There are {1} contact(s).", index, this.m_ContactCount));
			}
			return this.GetContacts_Internal()[index];
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00009CF0 File Offset: 0x00007EF0
		public int GetContacts(Il2CppStructArray<ContactPoint2D> contacts)
		{
			bool flag = contacts == null;
			if (flag)
			{
				throw new NullReferenceException("Cannot get contacts as the provided array is NULL.");
			}
			int num = Mathf.Min(this.m_ContactCount, contacts.Length);
			Array.Copy(this.GetContacts_Internal(), contacts, num);
			return num;
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00009D38 File Offset: 0x00007F38
		public int GetContacts(List<ContactPoint2D> contacts)
		{
			bool flag = contacts == null;
			if (flag)
			{
				throw new NullReferenceException("Cannot get contacts as the provided list is NULL.");
			}
			contacts.Clear();
			Il2CppStructArray<ContactPoint2D> contacts_Internal = this.GetContacts_Internal();
			for (int i = 0; i < this.m_ContactCount; i++)
			{
				contacts.Add(contacts_Internal[i]);
			}
			return this.m_ContactCount;
		}

		// Token: 0x040000AF RID: 175
		private static readonly IntPtr NativeFieldInfoPtr_m_Collider;

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeFieldInfoPtr_m_OtherCollider;

		// Token: 0x040000B1 RID: 177
		private static readonly IntPtr NativeFieldInfoPtr_m_Rigidbody;

		// Token: 0x040000B2 RID: 178
		private static readonly IntPtr NativeFieldInfoPtr_m_OtherRigidbody;

		// Token: 0x040000B3 RID: 179
		private static readonly IntPtr NativeFieldInfoPtr_m_RelativeVelocity;

		// Token: 0x040000B4 RID: 180
		private static readonly IntPtr NativeFieldInfoPtr_m_Enabled;

		// Token: 0x040000B5 RID: 181
		private static readonly IntPtr NativeFieldInfoPtr_m_ContactCount;

		// Token: 0x040000B6 RID: 182
		private static readonly IntPtr NativeFieldInfoPtr_m_ReusedContacts;

		// Token: 0x040000B7 RID: 183
		private static readonly IntPtr NativeFieldInfoPtr_m_LegacyContacts;
	}
}
