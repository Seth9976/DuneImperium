using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x0200032B RID: 811
	[Serializable]
	public class FixupHolder : Object
	{
		// Token: 0x060031BF RID: 12735 RVA: 0x000FC794 File Offset: 0x000FA994
		// Note: this type is marked as 'beforefieldinit'.
		static FixupHolder()
		{
			Il2CppClassPointerStore<FixupHolder>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "FixupHolder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FixupHolder>.NativeClassPtr);
			FixupHolder.NativeFieldInfoPtr_m_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FixupHolder>.NativeClassPtr, "m_id");
			FixupHolder.NativeFieldInfoPtr_m_fixupInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FixupHolder>.NativeClassPtr, "m_fixupInfo");
			FixupHolder.NativeFieldInfoPtr_m_fixupType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FixupHolder>.NativeClassPtr, "m_fixupType");
			FixupHolder.NativeMethodInfoPtr__ctor_Internal_Void_Int64_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixupHolder>.NativeClassPtr, 100671115);
		}

		// Token: 0x060031C0 RID: 12736 RVA: 0x000FC814 File Offset: 0x000FAA14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1385856, RefRangeEnd = 1385857, XrefRangeStart = 1385854, XrefRangeEnd = 1385856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FixupHolder(long id, Object fixupInfo, int fixupType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FixupHolder>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fixupInfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fixupType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FixupHolder.NativeMethodInfoPtr__ctor_Internal_Void_Int64_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031C1 RID: 12737 RVA: 0x0001125D File Offset: 0x0000F45D
		public FixupHolder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B38 RID: 2872
		// (get) Token: 0x060031C2 RID: 12738 RVA: 0x000FC87C File Offset: 0x000FAA7C
		// (set) Token: 0x060031C3 RID: 12739 RVA: 0x00011266 File Offset: 0x0000F466
		public unsafe long m_id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FixupHolder.NativeFieldInfoPtr_m_id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FixupHolder.NativeFieldInfoPtr_m_id)) = value;
			}
		}

		// Token: 0x17000B39 RID: 2873
		// (get) Token: 0x060031C4 RID: 12740 RVA: 0x000FC8A4 File Offset: 0x000FAAA4
		// (set) Token: 0x060031C5 RID: 12741 RVA: 0x00011281 File Offset: 0x0000F481
		public unsafe Object m_fixupInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FixupHolder.NativeFieldInfoPtr_m_fixupInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FixupHolder.NativeFieldInfoPtr_m_fixupInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B3A RID: 2874
		// (get) Token: 0x060031C6 RID: 12742 RVA: 0x000FC8D4 File Offset: 0x000FAAD4
		// (set) Token: 0x060031C7 RID: 12743 RVA: 0x000112A0 File Offset: 0x0000F4A0
		public unsafe int m_fixupType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FixupHolder.NativeFieldInfoPtr_m_fixupType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FixupHolder.NativeFieldInfoPtr_m_fixupType)) = value;
			}
		}

		// Token: 0x040028E9 RID: 10473
		private static readonly IntPtr NativeFieldInfoPtr_m_id;

		// Token: 0x040028EA RID: 10474
		private static readonly IntPtr NativeFieldInfoPtr_m_fixupInfo;

		// Token: 0x040028EB RID: 10475
		private static readonly IntPtr NativeFieldInfoPtr_m_fixupType;

		// Token: 0x040028EC RID: 10476
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int64_Object_Int32_0;
	}
}
