using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000013 RID: 19
	[StructLayout(2)]
	public struct ContactPairHeader
	{
		// Token: 0x060002D5 RID: 725 RVA: 0x0000AF28 File Offset: 0x00009128
		// Note: this type is marked as 'beforefieldinit'.
		static ContactPairHeader()
		{
			Il2CppClassPointerStore<ContactPairHeader>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.PhysicsModule.dll", "UnityEngine", "ContactPairHeader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContactPairHeader>.NativeClassPtr);
			ContactPairHeader.NativeFieldInfoPtr_m_BodyID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPairHeader>.NativeClassPtr, "m_BodyID");
			ContactPairHeader.NativeFieldInfoPtr_m_OtherBodyID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPairHeader>.NativeClassPtr, "m_OtherBodyID");
			ContactPairHeader.NativeFieldInfoPtr_m_StartPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPairHeader>.NativeClassPtr, "m_StartPtr");
			ContactPairHeader.NativeFieldInfoPtr_m_NbPairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPairHeader>.NativeClassPtr, "m_NbPairs");
			ContactPairHeader.NativeFieldInfoPtr_m_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPairHeader>.NativeClassPtr, "m_Flags");
			ContactPairHeader.NativeFieldInfoPtr_m_RelativeVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPairHeader>.NativeClassPtr, "m_RelativeVelocity");
			ContactPairHeader.NativeMethodInfoPtr_get_Body_Public_get_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactPairHeader>.NativeClassPtr, 100663430);
			ContactPairHeader.NativeMethodInfoPtr_get_OtherBody_Public_get_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactPairHeader>.NativeClassPtr, 100663431);
			ContactPairHeader.NativeMethodInfoPtr_get_HasRemovedBody_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactPairHeader>.NativeClassPtr, 100663432);
			ContactPairHeader.NativeMethodInfoPtr_GetContactPair_Public_byref_ContactPair_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactPairHeader>.NativeClassPtr, 100663433);
			ContactPairHeader.NativeMethodInfoPtr_GetContactPair_Internal_Internal_ptr_ContactPair_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactPairHeader>.NativeClassPtr, 100663434);
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060002D6 RID: 726 RVA: 0x0000B034 File Offset: 0x00009234
		public unsafe Component Body
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255255, XrefRangeEnd = 1255260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactPairHeader.NativeMethodInfoPtr_get_Body_Public_get_Component_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Component>(intPtr3) : null;
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060002D7 RID: 727 RVA: 0x0000B068 File Offset: 0x00009268
		public unsafe Component OtherBody
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255260, XrefRangeEnd = 1255265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactPairHeader.NativeMethodInfoPtr_get_OtherBody_Public_get_Component_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Component>(intPtr3) : null;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060002D8 RID: 728 RVA: 0x0000B09C File Offset: 0x0000929C
		public unsafe bool HasRemovedBody
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactPairHeader.NativeMethodInfoPtr_get_HasRemovedBody_Internal_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x0000B0CC File Offset: 0x000092CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255265, XrefRangeEnd = 1255266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ref ContactPair GetContactPair(int index)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactPairHeader.NativeMethodInfoPtr_GetContactPair_Public_byref_ContactPair_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x060002DA RID: 730 RVA: 0x0000B100 File Offset: 0x00009300
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1255267, RefRangeEnd = 1255269, XrefRangeStart = 1255266, XrefRangeEnd = 1255267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContactPair* GetContactPair_Internal(int index)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactPairHeader.NativeMethodInfoPtr_GetContactPair_Internal_Internal_ptr_ContactPair_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x060002DB RID: 731 RVA: 0x0000353C File Offset: 0x0000173C
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ContactPairHeader>.NativeClassPtr, ref this));
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060002DC RID: 732 RVA: 0x0000354E File Offset: 0x0000174E
		public int BodyInstanceID
		{
			get
			{
				return this.m_BodyID;
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060002DD RID: 733 RVA: 0x00003556 File Offset: 0x00001756
		public int OtherBodyInstanceID
		{
			get
			{
				return this.m_OtherBodyID;
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060002DE RID: 734 RVA: 0x0000355E File Offset: 0x0000175E
		public int PairCount
		{
			get
			{
				return (int)this.m_NbPairs;
			}
		}

		// Token: 0x0400019F RID: 415
		private static readonly IntPtr NativeFieldInfoPtr_m_BodyID;

		// Token: 0x040001A0 RID: 416
		private static readonly IntPtr NativeFieldInfoPtr_m_OtherBodyID;

		// Token: 0x040001A1 RID: 417
		private static readonly IntPtr NativeFieldInfoPtr_m_StartPtr;

		// Token: 0x040001A2 RID: 418
		private static readonly IntPtr NativeFieldInfoPtr_m_NbPairs;

		// Token: 0x040001A3 RID: 419
		private static readonly IntPtr NativeFieldInfoPtr_m_Flags;

		// Token: 0x040001A4 RID: 420
		private static readonly IntPtr NativeFieldInfoPtr_m_RelativeVelocity;

		// Token: 0x040001A5 RID: 421
		private static readonly IntPtr NativeMethodInfoPtr_get_Body_Public_get_Component_0;

		// Token: 0x040001A6 RID: 422
		private static readonly IntPtr NativeMethodInfoPtr_get_OtherBody_Public_get_Component_0;

		// Token: 0x040001A7 RID: 423
		private static readonly IntPtr NativeMethodInfoPtr_get_HasRemovedBody_Internal_get_Boolean_0;

		// Token: 0x040001A8 RID: 424
		private static readonly IntPtr NativeMethodInfoPtr_GetContactPair_Public_byref_ContactPair_Int32_0;

		// Token: 0x040001A9 RID: 425
		private static readonly IntPtr NativeMethodInfoPtr_GetContactPair_Internal_Internal_ptr_ContactPair_Int32_0;

		// Token: 0x040001AA RID: 426
		[FieldOffset(0)]
		public readonly int m_BodyID;

		// Token: 0x040001AB RID: 427
		[FieldOffset(4)]
		public readonly int m_OtherBodyID;

		// Token: 0x040001AC RID: 428
		[FieldOffset(8)]
		public readonly IntPtr m_StartPtr;

		// Token: 0x040001AD RID: 429
		[FieldOffset(16)]
		public readonly uint m_NbPairs;

		// Token: 0x040001AE RID: 430
		[FieldOffset(20)]
		public readonly CollisionPairHeaderFlags m_Flags;

		// Token: 0x040001AF RID: 431
		[FieldOffset(24)]
		public readonly Vector3 m_RelativeVelocity;
	}
}
