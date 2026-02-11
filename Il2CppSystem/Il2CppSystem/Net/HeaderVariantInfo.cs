using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x020001DC RID: 476
	public sealed class HeaderVariantInfo : ValueType
	{
		// Token: 0x06001D8B RID: 7563 RVA: 0x0008ECB8 File Offset: 0x0008CEB8
		// Note: this type is marked as 'beforefieldinit'.
		static HeaderVariantInfo()
		{
			Il2CppClassPointerStore<HeaderVariantInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "HeaderVariantInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HeaderVariantInfo>.NativeClassPtr);
			HeaderVariantInfo.NativeFieldInfoPtr_m_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeaderVariantInfo>.NativeClassPtr, "m_name");
			HeaderVariantInfo.NativeFieldInfoPtr_m_variant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeaderVariantInfo>.NativeClassPtr, "m_variant");
			HeaderVariantInfo.NativeMethodInfoPtr__ctor_Internal_Void_String_CookieVariant_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeaderVariantInfo>.NativeClassPtr, 100667819);
			HeaderVariantInfo.NativeMethodInfoPtr_get_Name_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeaderVariantInfo>.NativeClassPtr, 100667820);
			HeaderVariantInfo.NativeMethodInfoPtr_get_Variant_Internal_get_CookieVariant_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeaderVariantInfo>.NativeClassPtr, 100667821);
		}

		// Token: 0x06001D8C RID: 7564 RVA: 0x0008ED4C File Offset: 0x0008CF4C
		[CallerCount(40)]
		[CachedScanResults(RefRangeStart = 336243, RefRangeEnd = 336283, XrefRangeStart = 336243, XrefRangeEnd = 336283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HeaderVariantInfo(string name, CookieVariant variant)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HeaderVariantInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref variant;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeaderVariantInfo.NativeMethodInfoPtr__ctor_Internal_Void_String_CookieVariant_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170008FC RID: 2300
		// (get) Token: 0x06001D8D RID: 7565 RVA: 0x0008EDAC File Offset: 0x0008CFAC
		public unsafe string Name
		{
			[CallerCount(99)]
			[CachedScanResults(RefRangeStart = 306117, RefRangeEnd = 306216, XrefRangeStart = 306117, XrefRangeEnd = 306216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeaderVariantInfo.NativeMethodInfoPtr_get_Name_Internal_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170008FD RID: 2301
		// (get) Token: 0x06001D8E RID: 7566 RVA: 0x0008EDE8 File Offset: 0x0008CFE8
		public unsafe CookieVariant Variant
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeaderVariantInfo.NativeMethodInfoPtr_get_Variant_Internal_get_CookieVariant_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D8F RID: 7567 RVA: 0x0000C92C File Offset: 0x0000AB2C
		public HeaderVariantInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001D90 RID: 7568 RVA: 0x0000C935 File Offset: 0x0000AB35
		public HeaderVariantInfo()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HeaderVariantInfo>.NativeClassPtr))
		{
		}

		// Token: 0x170008FA RID: 2298
		// (get) Token: 0x06001D91 RID: 7569 RVA: 0x0008EE2C File Offset: 0x0008D02C
		// (set) Token: 0x06001D92 RID: 7570 RVA: 0x0000C947 File Offset: 0x0000AB47
		public unsafe string m_name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeaderVariantInfo.NativeFieldInfoPtr_m_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeaderVariantInfo.NativeFieldInfoPtr_m_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170008FB RID: 2299
		// (get) Token: 0x06001D93 RID: 7571 RVA: 0x0008EE54 File Offset: 0x0008D054
		// (set) Token: 0x06001D94 RID: 7572 RVA: 0x0000C966 File Offset: 0x0000AB66
		public unsafe CookieVariant m_variant
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeaderVariantInfo.NativeFieldInfoPtr_m_variant);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeaderVariantInfo.NativeFieldInfoPtr_m_variant)) = value;
			}
		}

		// Token: 0x0400177C RID: 6012
		private static readonly IntPtr NativeFieldInfoPtr_m_name;

		// Token: 0x0400177D RID: 6013
		private static readonly IntPtr NativeFieldInfoPtr_m_variant;

		// Token: 0x0400177E RID: 6014
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_CookieVariant_0;

		// Token: 0x0400177F RID: 6015
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Internal_get_String_0;

		// Token: 0x04001780 RID: 6016
		private static readonly IntPtr NativeMethodInfoPtr_get_Variant_Internal_get_CookieVariant_0;
	}
}
