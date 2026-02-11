using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine
{
	// Token: 0x02000005 RID: 5
	public class Collision : Object
	{
		// Token: 0x0600001C RID: 28 RVA: 0x00004BA4 File Offset: 0x00002DA4
		// Note: this type is marked as 'beforefieldinit'.
		static Collision()
		{
			Il2CppClassPointerStore<Collision>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.PhysicsModule.dll", "UnityEngine", "Collision");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Collision>.NativeClassPtr);
			Collision.NativeFieldInfoPtr_m_Header = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Collision>.NativeClassPtr, "m_Header");
			Collision.NativeFieldInfoPtr_m_Pair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Collision>.NativeClassPtr, "m_Pair");
			Collision.NativeFieldInfoPtr_m_Flipped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Collision>.NativeClassPtr, "m_Flipped");
			Collision.NativeFieldInfoPtr_m_LegacyContacts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Collision>.NativeClassPtr, "m_LegacyContacts");
			Collision.NativeMethodInfoPtr_set_Flipped_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collision>.NativeClassPtr, 100663297);
			Collision.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collision>.NativeClassPtr, 100663298);
			Collision.NativeMethodInfoPtr__ctor_Internal_Void_byref_ContactPairHeader_byref_ContactPair_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collision>.NativeClassPtr, 100663299);
			Collision.NativeMethodInfoPtr_Reuse_Internal_Void_byref_ContactPairHeader_byref_ContactPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collision>.NativeClassPtr, 100663300);
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000032 RID: 50 RVA: 0x00004EB8 File Offset: 0x000030B8
		// (set) Token: 0x0600001D RID: 29 RVA: 0x00004C74 File Offset: 0x00002E74
		public unsafe bool Flipped
		{
			get
			{
				return this.m_Flipped;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Collision.NativeMethodInfoPtr_set_Flipped_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00004CB4 File Offset: 0x00002EB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254588, XrefRangeEnd = 1254591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Collision()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Collision>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Collision.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00004CF0 File Offset: 0x00002EF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254591, XrefRangeEnd = 1254599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Collision([In] ref ContactPairHeader header, [In] ref ContactPair pair, bool flipped)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Collision>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &header;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pair;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flipped;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Collision.NativeMethodInfoPtr__ctor_Internal_Void_byref_ContactPairHeader_byref_ContactPair_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00004D54 File Offset: 0x00002F54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254599, XrefRangeEnd = 1254600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reuse([In] ref ContactPairHeader header, [In] ref ContactPair pair)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &header;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pair;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Collision.NativeMethodInfoPtr_Reuse_Internal_Void_byref_ContactPairHeader_byref_ContactPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x0000212E File Offset: 0x0000032E
		public Collision(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000022 RID: 34 RVA: 0x00004DA0 File Offset: 0x00002FA0
		// (set) Token: 0x06000023 RID: 35 RVA: 0x00002137 File Offset: 0x00000337
		public unsafe ContactPairHeader m_Header
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collision.NativeFieldInfoPtr_m_Header);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collision.NativeFieldInfoPtr_m_Header)) = value;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000024 RID: 36 RVA: 0x00004DC8 File Offset: 0x00002FC8
		// (set) Token: 0x06000025 RID: 37 RVA: 0x00002152 File Offset: 0x00000352
		public unsafe ContactPair m_Pair
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collision.NativeFieldInfoPtr_m_Pair);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collision.NativeFieldInfoPtr_m_Pair)) = value;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000026 RID: 38 RVA: 0x00004DF0 File Offset: 0x00002FF0
		// (set) Token: 0x06000027 RID: 39 RVA: 0x0000216D File Offset: 0x0000036D
		public unsafe bool m_Flipped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collision.NativeFieldInfoPtr_m_Flipped);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collision.NativeFieldInfoPtr_m_Flipped)) = value;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00004E18 File Offset: 0x00003018
		// (set) Token: 0x06000029 RID: 41 RVA: 0x00002188 File Offset: 0x00000388
		public unsafe Il2CppStructArray<ContactPoint> m_LegacyContacts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collision.NativeFieldInfoPtr_m_LegacyContacts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ContactPoint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collision.NativeFieldInfoPtr_m_LegacyContacts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600002A RID: 42 RVA: 0x000021A7 File Offset: 0x000003A7
		public Vector3 impulse
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600002B RID: 43 RVA: 0x000021B4 File Offset: 0x000003B4
		public Vector3 relativeVelocity
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600002C RID: 44 RVA: 0x000021C1 File Offset: 0x000003C1
		public Rigidbody rigidbody
		{
			get
			{
				return this.body.TryCast<Rigidbody>();
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600002D RID: 45 RVA: 0x000021CE File Offset: 0x000003CE
		public ArticulationBody articulationBody
		{
			get
			{
				return this.body.TryCast<ArticulationBody>();
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600002E RID: 46 RVA: 0x000021DB File Offset: 0x000003DB
		public Component body
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600002F RID: 47 RVA: 0x000021E8 File Offset: 0x000003E8
		public Collider collider
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000030 RID: 48 RVA: 0x00004E48 File Offset: 0x00003048
		public Transform transform
		{
			get
			{
				return (this.rigidbody != null) ? this.rigidbody.transform : this.collider.transform;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000031 RID: 49 RVA: 0x00004E80 File Offset: 0x00003080
		public GameObject gameObject
		{
			get
			{
				return (this.body != null) ? this.body.gameObject : this.collider.gameObject;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000033 RID: 51 RVA: 0x000021F5 File Offset: 0x000003F5
		public int contactCount
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000034 RID: 52 RVA: 0x00002202 File Offset: 0x00000402
		public Il2CppStructArray<ContactPoint> contacts
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x0000220F File Offset: 0x0000040F
		public ContactPoint GetContact(int index)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000036 RID: 54 RVA: 0x0000221C File Offset: 0x0000041C
		public int GetContacts(Il2CppStructArray<ContactPoint> contacts)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002229 File Offset: 0x00000429
		public int GetContacts(List<ContactPoint> contacts)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00004ED0 File Offset: 0x000030D0
		public virtual IEnumerator GetEnumerator()
		{
			return this.contacts.GetEnumerator();
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000039 RID: 57 RVA: 0x00004EF0 File Offset: 0x000030F0
		public Vector3 impactForceSum
		{
			get
			{
				return Vector3.zero;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600003A RID: 58 RVA: 0x00004F08 File Offset: 0x00003108
		public Vector3 frictionForceSum
		{
			get
			{
				return Vector3.zero;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600003B RID: 59 RVA: 0x00004F20 File Offset: 0x00003120
		public Component other
		{
			get
			{
				return (this.body != null) ? this.body : this.collider;
			}
		}

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeFieldInfoPtr_m_Header;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeFieldInfoPtr_m_Pair;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeFieldInfoPtr_m_Flipped;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeFieldInfoPtr_m_LegacyContacts;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeMethodInfoPtr_set_Flipped_Internal_set_Void_Boolean_0;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_byref_ContactPairHeader_byref_ContactPair_Boolean_0;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeMethodInfoPtr_Reuse_Internal_Void_byref_ContactPairHeader_byref_ContactPair_0;
	}
}
