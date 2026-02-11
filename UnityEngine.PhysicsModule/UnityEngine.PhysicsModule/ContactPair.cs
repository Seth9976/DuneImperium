using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine
{
	// Token: 0x02000014 RID: 20
	[StructLayout(2)]
	public struct ContactPair
	{
		// Token: 0x060002DF RID: 735 RVA: 0x0000B134 File Offset: 0x00009334
		// Note: this type is marked as 'beforefieldinit'.
		static ContactPair()
		{
			Il2CppClassPointerStore<ContactPair>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.PhysicsModule.dll", "UnityEngine", "ContactPair");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContactPair>.NativeClassPtr);
			ContactPair.NativeFieldInfoPtr_m_ColliderID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPair>.NativeClassPtr, "m_ColliderID");
			ContactPair.NativeFieldInfoPtr_m_OtherColliderID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPair>.NativeClassPtr, "m_OtherColliderID");
			ContactPair.NativeFieldInfoPtr_m_StartPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPair>.NativeClassPtr, "m_StartPtr");
			ContactPair.NativeFieldInfoPtr_m_NbPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPair>.NativeClassPtr, "m_NbPoints");
			ContactPair.NativeFieldInfoPtr_m_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPair>.NativeClassPtr, "m_Flags");
			ContactPair.NativeFieldInfoPtr_m_Events = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPair>.NativeClassPtr, "m_Events");
			ContactPair.NativeFieldInfoPtr_m_ImpulseSum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPair>.NativeClassPtr, "m_ImpulseSum");
			ContactPair.NativeMethodInfoPtr_get_Collider_Public_get_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactPair>.NativeClassPtr, 100663435);
			ContactPair.NativeMethodInfoPtr_get_OtherCollider_Public_get_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactPair>.NativeClassPtr, 100663436);
			ContactPair.NativeMethodInfoPtr_get_IsCollisionEnter_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactPair>.NativeClassPtr, 100663437);
			ContactPair.NativeMethodInfoPtr_get_IsCollisionExit_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactPair>.NativeClassPtr, 100663438);
			ContactPair.NativeMethodInfoPtr_get_IsCollisionStay_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactPair>.NativeClassPtr, 100663439);
			ContactPair.NativeMethodInfoPtr_get_HasRemovedCollider_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactPair>.NativeClassPtr, 100663440);
			ContactPair.NativeMethodInfoPtr_ExtractContactsArray_Internal_Int32_Il2CppStructArray_1_ContactPoint_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactPair>.NativeClassPtr, 100663441);
			ContactPair.NativeMethodInfoPtr_ExtractContactsArray_Injected_Private_Static_Int32_byref_ContactPair_Il2CppStructArray_1_ContactPoint_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactPair>.NativeClassPtr, 100663442);
			ContactPair.ExtractContacts_InjectedDelegateField = IL2CPP.ResolveICall<ContactPair.ExtractContacts_InjectedDelegate>("UnityEngine.ContactPair::ExtractContacts_Injected");
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060002E0 RID: 736 RVA: 0x0000B2A0 File Offset: 0x000094A0
		public unsafe Collider Collider
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1255270, RefRangeEnd = 1255271, XrefRangeStart = 1255269, XrefRangeEnd = 1255270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactPair.NativeMethodInfoPtr_get_Collider_Public_get_Collider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr3) : null;
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060002E1 RID: 737 RVA: 0x0000B2D4 File Offset: 0x000094D4
		public unsafe Collider OtherCollider
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1255272, RefRangeEnd = 1255273, XrefRangeStart = 1255271, XrefRangeEnd = 1255272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactPair.NativeMethodInfoPtr_get_OtherCollider_Public_get_Collider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr3) : null;
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060002E2 RID: 738 RVA: 0x0000B308 File Offset: 0x00009508
		public unsafe bool IsCollisionEnter
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactPair.NativeMethodInfoPtr_get_IsCollisionEnter_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060002E3 RID: 739 RVA: 0x0000B338 File Offset: 0x00009538
		public unsafe bool IsCollisionExit
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactPair.NativeMethodInfoPtr_get_IsCollisionExit_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060002E4 RID: 740 RVA: 0x0000B368 File Offset: 0x00009568
		public unsafe bool IsCollisionStay
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactPair.NativeMethodInfoPtr_get_IsCollisionStay_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060002E5 RID: 741 RVA: 0x0000B398 File Offset: 0x00009598
		public unsafe bool HasRemovedCollider
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactPair.NativeMethodInfoPtr_get_HasRemovedCollider_Internal_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x0000B3C8 File Offset: 0x000095C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255273, XrefRangeEnd = 1255275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ExtractContactsArray(Il2CppStructArray<ContactPoint> managedContainer, bool flipped)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(managedContainer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flipped;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactPair.NativeMethodInfoPtr_ExtractContactsArray_Internal_Int32_Il2CppStructArray_1_ContactPoint_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x0000B418 File Offset: 0x00009618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ExtractContactsArray_Injected(ref ContactPair _unity_self, Il2CppStructArray<ContactPoint> managedContainer, bool flipped)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &_unity_self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(managedContainer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flipped;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactPair.NativeMethodInfoPtr_ExtractContactsArray_Injected_Private_Static_Int32_byref_ContactPair_Il2CppStructArray_1_ContactPoint_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x00003566 File Offset: 0x00001766
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ContactPair>.NativeClassPtr, ref this));
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060002E9 RID: 745 RVA: 0x00003578 File Offset: 0x00001778
		public int ColliderInstanceID
		{
			get
			{
				return this.m_ColliderID;
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060002EA RID: 746 RVA: 0x00003580 File Offset: 0x00001780
		public int OtherColliderInstanceID
		{
			get
			{
				return this.m_OtherColliderID;
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060002EB RID: 747 RVA: 0x00003588 File Offset: 0x00001788
		public int ContactCount
		{
			get
			{
				return (int)this.m_NbPoints;
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060002EC RID: 748 RVA: 0x00003590 File Offset: 0x00001790
		public Vector3 ImpulseSum
		{
			get
			{
				return this.m_ImpulseSum;
			}
		}

		// Token: 0x060002ED RID: 749 RVA: 0x00003598 File Offset: 0x00001798
		public int ExtractContacts(List<ContactPoint> managedContainer, bool flipped)
		{
			return ContactPair.ExtractContacts_Injected(ref this, managedContainer, flipped);
		}

		// Token: 0x060002EE RID: 750 RVA: 0x000035A2 File Offset: 0x000017A2
		public uint GetContactPointFaceIndex(int contactIndex)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060002EF RID: 751 RVA: 0x000035AF File Offset: 0x000017AF
		public static int ExtractContacts_Injected(ref ContactPair _unity_self, List<ContactPoint> managedContainer, bool flipped)
		{
			return ContactPair.ExtractContacts_InjectedDelegateField(ref _unity_self, IL2CPP.Il2CppObjectBaseToPtr(managedContainer), flipped);
		}

		// Token: 0x040001B0 RID: 432
		private static readonly IntPtr NativeFieldInfoPtr_m_ColliderID;

		// Token: 0x040001B1 RID: 433
		private static readonly IntPtr NativeFieldInfoPtr_m_OtherColliderID;

		// Token: 0x040001B2 RID: 434
		private static readonly IntPtr NativeFieldInfoPtr_m_StartPtr;

		// Token: 0x040001B3 RID: 435
		private static readonly IntPtr NativeFieldInfoPtr_m_NbPoints;

		// Token: 0x040001B4 RID: 436
		private static readonly IntPtr NativeFieldInfoPtr_m_Flags;

		// Token: 0x040001B5 RID: 437
		private static readonly IntPtr NativeFieldInfoPtr_m_Events;

		// Token: 0x040001B6 RID: 438
		private static readonly IntPtr NativeFieldInfoPtr_m_ImpulseSum;

		// Token: 0x040001B7 RID: 439
		private static readonly IntPtr NativeMethodInfoPtr_get_Collider_Public_get_Collider_0;

		// Token: 0x040001B8 RID: 440
		private static readonly IntPtr NativeMethodInfoPtr_get_OtherCollider_Public_get_Collider_0;

		// Token: 0x040001B9 RID: 441
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCollisionEnter_Public_get_Boolean_0;

		// Token: 0x040001BA RID: 442
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCollisionExit_Public_get_Boolean_0;

		// Token: 0x040001BB RID: 443
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCollisionStay_Public_get_Boolean_0;

		// Token: 0x040001BC RID: 444
		private static readonly IntPtr NativeMethodInfoPtr_get_HasRemovedCollider_Internal_get_Boolean_0;

		// Token: 0x040001BD RID: 445
		private static readonly IntPtr NativeMethodInfoPtr_ExtractContactsArray_Internal_Int32_Il2CppStructArray_1_ContactPoint_Boolean_0;

		// Token: 0x040001BE RID: 446
		private static readonly IntPtr NativeMethodInfoPtr_ExtractContactsArray_Injected_Private_Static_Int32_byref_ContactPair_Il2CppStructArray_1_ContactPoint_Boolean_0;

		// Token: 0x040001BF RID: 447
		[FieldOffset(0)]
		public readonly int m_ColliderID;

		// Token: 0x040001C0 RID: 448
		[FieldOffset(4)]
		public readonly int m_OtherColliderID;

		// Token: 0x040001C1 RID: 449
		[FieldOffset(8)]
		public readonly IntPtr m_StartPtr;

		// Token: 0x040001C2 RID: 450
		[FieldOffset(16)]
		public readonly uint m_NbPoints;

		// Token: 0x040001C3 RID: 451
		[FieldOffset(20)]
		public readonly CollisionPairFlags m_Flags;

		// Token: 0x040001C4 RID: 452
		[FieldOffset(22)]
		public readonly CollisionPairEventFlags m_Events;

		// Token: 0x040001C5 RID: 453
		[FieldOffset(24)]
		public readonly Vector3 m_ImpulseSum;

		// Token: 0x040001C6 RID: 454
		public const uint c_InvalidFaceIndex = 4294967295U;

		// Token: 0x040001C7 RID: 455
		private static readonly ContactPair.ExtractContacts_InjectedDelegate ExtractContacts_InjectedDelegateField;

		// Token: 0x020000FB RID: 251
		// (Invoke) Token: 0x060005CE RID: 1486
		private delegate int ExtractContacts_InjectedDelegate(IntPtr _unity_self, IntPtr managedContainer, bool flipped);
	}
}
