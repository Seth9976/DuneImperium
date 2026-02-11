using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x02000081 RID: 129
	public sealed class RegexFC : Object
	{
		// Token: 0x06000924 RID: 2340 RVA: 0x0003EF40 File Offset: 0x0003D140
		// Note: this type is marked as 'beforefieldinit'.
		static RegexFC()
		{
			Il2CppClassPointerStore<RegexFC>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "RegexFC");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegexFC>.NativeClassPtr);
			RegexFC.NativeFieldInfoPtr__cc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexFC>.NativeClassPtr, "_cc");
			RegexFC.NativeFieldInfoPtr__nullable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexFC>.NativeClassPtr, "_nullable");
			RegexFC.NativeFieldInfoPtr__CaseInsensitive_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexFC>.NativeClassPtr, "<CaseInsensitive>k__BackingField");
			RegexFC.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexFC>.NativeClassPtr, 100664703);
			RegexFC.NativeMethodInfoPtr__ctor_Public_Void_Char_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexFC>.NativeClassPtr, 100664704);
			RegexFC.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexFC>.NativeClassPtr, 100664705);
			RegexFC.NativeMethodInfoPtr_AddFC_Public_Boolean_RegexFC_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexFC>.NativeClassPtr, 100664706);
			RegexFC.NativeMethodInfoPtr_get_CaseInsensitive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexFC>.NativeClassPtr, 100664707);
			RegexFC.NativeMethodInfoPtr_set_CaseInsensitive_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexFC>.NativeClassPtr, 100664708);
			RegexFC.NativeMethodInfoPtr_GetFirstChars_Public_String_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexFC>.NativeClassPtr, 100664709);
		}

		// Token: 0x06000925 RID: 2341 RVA: 0x0003F038 File Offset: 0x0003D238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440650, XrefRangeEnd = 440656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexFC(bool nullable)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexFC>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nullable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexFC.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000926 RID: 2342 RVA: 0x0003F080 File Offset: 0x0003D280
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 440663, RefRangeEnd = 440665, XrefRangeStart = 440656, XrefRangeEnd = 440663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexFC(char ch, bool not, bool nullable, bool caseInsensitive)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexFC>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref not;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nullable;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref caseInsensitive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexFC.NativeMethodInfoPtr__ctor_Public_Void_Char_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000927 RID: 2343 RVA: 0x0003F0F4 File Offset: 0x0003D2F4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 440674, RefRangeEnd = 440677, XrefRangeStart = 440665, XrefRangeEnd = 440674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexFC(string charClass, bool nullable, bool caseInsensitive)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexFC>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(charClass);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nullable;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref caseInsensitive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexFC.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000928 RID: 2344 RVA: 0x0003F15C File Offset: 0x0003D35C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440677, XrefRangeEnd = 440679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AddFC(RegexFC fc, bool concatenate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fc);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref concatenate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexFC.NativeMethodInfoPtr_AddFC_Public_Boolean_RegexFC_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06000929 RID: 2345 RVA: 0x0003F1B8 File Offset: 0x0003D3B8
		// (set) Token: 0x0600092A RID: 2346 RVA: 0x0003F1F4 File Offset: 0x0003D3F4
		public unsafe bool CaseInsensitive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexFC.NativeMethodInfoPtr_get_CaseInsensitive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexFC.NativeMethodInfoPtr_set_CaseInsensitive_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600092B RID: 2347 RVA: 0x0003F234 File Offset: 0x0003D434
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440679, XrefRangeEnd = 440690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetFirstChars(CultureInfo culture)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(culture);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexFC.NativeMethodInfoPtr_GetFirstChars_Public_String_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600092C RID: 2348 RVA: 0x000051AB File Offset: 0x000033AB
		public RegexFC(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x0600092D RID: 2349 RVA: 0x0003F27C File Offset: 0x0003D47C
		// (set) Token: 0x0600092E RID: 2350 RVA: 0x000051B4 File Offset: 0x000033B4
		public unsafe RegexCharClass _cc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexFC.NativeFieldInfoPtr__cc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegexCharClass>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexFC.NativeFieldInfoPtr__cc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x0600092F RID: 2351 RVA: 0x0003F2AC File Offset: 0x0003D4AC
		// (set) Token: 0x06000930 RID: 2352 RVA: 0x000051D3 File Offset: 0x000033D3
		public unsafe bool _nullable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexFC.NativeFieldInfoPtr__nullable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexFC.NativeFieldInfoPtr__nullable)) = value;
			}
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06000931 RID: 2353 RVA: 0x0003F2D4 File Offset: 0x0003D4D4
		// (set) Token: 0x06000932 RID: 2354 RVA: 0x000051EE File Offset: 0x000033EE
		public unsafe bool _CaseInsensitive_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexFC.NativeFieldInfoPtr__CaseInsensitive_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexFC.NativeFieldInfoPtr__CaseInsensitive_k__BackingField)) = value;
			}
		}

		// Token: 0x04000764 RID: 1892
		private static readonly IntPtr NativeFieldInfoPtr__cc;

		// Token: 0x04000765 RID: 1893
		private static readonly IntPtr NativeFieldInfoPtr__nullable;

		// Token: 0x04000766 RID: 1894
		private static readonly IntPtr NativeFieldInfoPtr__CaseInsensitive_k__BackingField;

		// Token: 0x04000767 RID: 1895
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x04000768 RID: 1896
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Char_Boolean_Boolean_Boolean_0;

		// Token: 0x04000769 RID: 1897
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Boolean_0;

		// Token: 0x0400076A RID: 1898
		private static readonly IntPtr NativeMethodInfoPtr_AddFC_Public_Boolean_RegexFC_Boolean_0;

		// Token: 0x0400076B RID: 1899
		private static readonly IntPtr NativeMethodInfoPtr_get_CaseInsensitive_Public_get_Boolean_0;

		// Token: 0x0400076C RID: 1900
		private static readonly IntPtr NativeMethodInfoPtr_set_CaseInsensitive_Private_set_Void_Boolean_0;

		// Token: 0x0400076D RID: 1901
		private static readonly IntPtr NativeMethodInfoPtr_GetFirstChars_Public_String_CultureInfo_0;
	}
}
