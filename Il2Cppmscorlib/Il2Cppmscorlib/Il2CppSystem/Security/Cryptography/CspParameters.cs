using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x0200023D RID: 573
	public sealed class CspParameters : Object
	{
		// Token: 0x0600259E RID: 9630 RVA: 0x000CFB28 File Offset: 0x000CDD28
		// Note: this type is marked as 'beforefieldinit'.
		static CspParameters()
		{
			Il2CppClassPointerStore<CspParameters>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "CspParameters");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CspParameters>.NativeClassPtr);
			CspParameters.NativeFieldInfoPtr_ProviderType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CspParameters>.NativeClassPtr, "ProviderType");
			CspParameters.NativeFieldInfoPtr_ProviderName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CspParameters>.NativeClassPtr, "ProviderName");
			CspParameters.NativeFieldInfoPtr_KeyContainerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CspParameters>.NativeClassPtr, "KeyContainerName");
			CspParameters.NativeFieldInfoPtr_KeyNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CspParameters>.NativeClassPtr, "KeyNumber");
			CspParameters.NativeFieldInfoPtr_m_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CspParameters>.NativeClassPtr, "m_flags");
			CspParameters.NativeMethodInfoPtr_get_Flags_Public_get_CspProviderFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CspParameters>.NativeClassPtr, 100669597);
			CspParameters.NativeMethodInfoPtr_set_Flags_Public_set_Void_CspProviderFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CspParameters>.NativeClassPtr, 100669598);
			CspParameters.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CspParameters>.NativeClassPtr, 100669599);
			CspParameters.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CspParameters>.NativeClassPtr, 100669600);
			CspParameters.NativeMethodInfoPtr__ctor_Public_Void_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CspParameters>.NativeClassPtr, 100669601);
			CspParameters.NativeMethodInfoPtr__ctor_Internal_Void_Int32_String_String_CspProviderFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CspParameters>.NativeClassPtr, 100669602);
		}

		// Token: 0x17000798 RID: 1944
		// (get) Token: 0x0600259F RID: 9631 RVA: 0x000CFC34 File Offset: 0x000CDE34
		// (set) Token: 0x060025A0 RID: 9632 RVA: 0x000CFC70 File Offset: 0x000CDE70
		public unsafe CspProviderFlags Flags
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CspParameters.NativeMethodInfoPtr_get_Flags_Public_get_CspProviderFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1371655, RefRangeEnd = 1371661, XrefRangeStart = 1371655, XrefRangeEnd = 1371655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CspParameters.NativeMethodInfoPtr_set_Flags_Public_set_Void_CspProviderFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060025A1 RID: 9633 RVA: 0x000CFCB0 File Offset: 0x000CDEB0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1371664, RefRangeEnd = 1371666, XrefRangeStart = 1371661, XrefRangeEnd = 1371664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CspParameters()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CspParameters>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CspParameters.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025A2 RID: 9634 RVA: 0x000CFCEC File Offset: 0x000CDEEC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1371669, RefRangeEnd = 1371672, XrefRangeStart = 1371666, XrefRangeEnd = 1371669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CspParameters(int dwTypeIn)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CspParameters>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dwTypeIn;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CspParameters.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060025A3 RID: 9635 RVA: 0x000CFD34 File Offset: 0x000CDF34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1371675, RefRangeEnd = 1371676, XrefRangeStart = 1371672, XrefRangeEnd = 1371675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CspParameters(int dwTypeIn, string strProviderNameIn, string strContainerNameIn)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CspParameters>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dwTypeIn;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(strProviderNameIn);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(strContainerNameIn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CspParameters.NativeMethodInfoPtr__ctor_Public_Void_Int32_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025A4 RID: 9636 RVA: 0x000CFDA0 File Offset: 0x000CDFA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1371676, XrefRangeEnd = 1371679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CspParameters(int providerType, string providerName, string keyContainerName, CspProviderFlags flags)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CspParameters>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref providerType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(providerName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(keyContainerName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CspParameters.NativeMethodInfoPtr__ctor_Internal_Void_Int32_String_String_CspProviderFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025A5 RID: 9637 RVA: 0x0000C2AA File Offset: 0x0000A4AA
		public CspParameters(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000793 RID: 1939
		// (get) Token: 0x060025A6 RID: 9638 RVA: 0x000CFE1C File Offset: 0x000CE01C
		// (set) Token: 0x060025A7 RID: 9639 RVA: 0x0000C2B3 File Offset: 0x0000A4B3
		public unsafe int ProviderType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CspParameters.NativeFieldInfoPtr_ProviderType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CspParameters.NativeFieldInfoPtr_ProviderType)) = value;
			}
		}

		// Token: 0x17000794 RID: 1940
		// (get) Token: 0x060025A8 RID: 9640 RVA: 0x000CFE44 File Offset: 0x000CE044
		// (set) Token: 0x060025A9 RID: 9641 RVA: 0x0000C2CE File Offset: 0x0000A4CE
		public unsafe string ProviderName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CspParameters.NativeFieldInfoPtr_ProviderName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CspParameters.NativeFieldInfoPtr_ProviderName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000795 RID: 1941
		// (get) Token: 0x060025AA RID: 9642 RVA: 0x000CFE6C File Offset: 0x000CE06C
		// (set) Token: 0x060025AB RID: 9643 RVA: 0x0000C2ED File Offset: 0x0000A4ED
		public unsafe string KeyContainerName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CspParameters.NativeFieldInfoPtr_KeyContainerName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CspParameters.NativeFieldInfoPtr_KeyContainerName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000796 RID: 1942
		// (get) Token: 0x060025AC RID: 9644 RVA: 0x000CFE94 File Offset: 0x000CE094
		// (set) Token: 0x060025AD RID: 9645 RVA: 0x0000C30C File Offset: 0x0000A50C
		public unsafe int KeyNumber
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CspParameters.NativeFieldInfoPtr_KeyNumber);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CspParameters.NativeFieldInfoPtr_KeyNumber)) = value;
			}
		}

		// Token: 0x17000797 RID: 1943
		// (get) Token: 0x060025AE RID: 9646 RVA: 0x000CFEBC File Offset: 0x000CE0BC
		// (set) Token: 0x060025AF RID: 9647 RVA: 0x0000C327 File Offset: 0x0000A527
		public unsafe int m_flags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CspParameters.NativeFieldInfoPtr_m_flags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CspParameters.NativeFieldInfoPtr_m_flags)) = value;
			}
		}

		// Token: 0x040020C0 RID: 8384
		private static readonly IntPtr NativeFieldInfoPtr_ProviderType;

		// Token: 0x040020C1 RID: 8385
		private static readonly IntPtr NativeFieldInfoPtr_ProviderName;

		// Token: 0x040020C2 RID: 8386
		private static readonly IntPtr NativeFieldInfoPtr_KeyContainerName;

		// Token: 0x040020C3 RID: 8387
		private static readonly IntPtr NativeFieldInfoPtr_KeyNumber;

		// Token: 0x040020C4 RID: 8388
		private static readonly IntPtr NativeFieldInfoPtr_m_flags;

		// Token: 0x040020C5 RID: 8389
		private static readonly IntPtr NativeMethodInfoPtr_get_Flags_Public_get_CspProviderFlags_0;

		// Token: 0x040020C6 RID: 8390
		private static readonly IntPtr NativeMethodInfoPtr_set_Flags_Public_set_Void_CspProviderFlags_0;

		// Token: 0x040020C7 RID: 8391
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040020C8 RID: 8392
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040020C9 RID: 8393
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_String_String_0;

		// Token: 0x040020CA RID: 8394
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_String_String_CspProviderFlags_0;
	}
}
