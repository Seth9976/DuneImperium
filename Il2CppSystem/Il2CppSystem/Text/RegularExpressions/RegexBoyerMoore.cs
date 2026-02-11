using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x0200007D RID: 125
	public sealed class RegexBoyerMoore : Object
	{
		// Token: 0x0600082B RID: 2091 RVA: 0x0003C42C File Offset: 0x0003A62C
		// Note: this type is marked as 'beforefieldinit'.
		static RegexBoyerMoore()
		{
			Il2CppClassPointerStore<RegexBoyerMoore>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "RegexBoyerMoore");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegexBoyerMoore>.NativeClassPtr);
			RegexBoyerMoore.NativeFieldInfoPtr_Positive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexBoyerMoore>.NativeClassPtr, "Positive");
			RegexBoyerMoore.NativeFieldInfoPtr_NegativeASCII = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexBoyerMoore>.NativeClassPtr, "NegativeASCII");
			RegexBoyerMoore.NativeFieldInfoPtr_NegativeUnicode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexBoyerMoore>.NativeClassPtr, "NegativeUnicode");
			RegexBoyerMoore.NativeFieldInfoPtr_Pattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexBoyerMoore>.NativeClassPtr, "Pattern");
			RegexBoyerMoore.NativeFieldInfoPtr_LowASCII = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexBoyerMoore>.NativeClassPtr, "LowASCII");
			RegexBoyerMoore.NativeFieldInfoPtr_HighASCII = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexBoyerMoore>.NativeClassPtr, "HighASCII");
			RegexBoyerMoore.NativeFieldInfoPtr_RightToLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexBoyerMoore>.NativeClassPtr, "RightToLeft");
			RegexBoyerMoore.NativeFieldInfoPtr_CaseInsensitive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexBoyerMoore>.NativeClassPtr, "CaseInsensitive");
			RegexBoyerMoore.NativeFieldInfoPtr__culture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexBoyerMoore>.NativeClassPtr, "_culture");
			RegexBoyerMoore.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Boolean_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexBoyerMoore>.NativeClassPtr, 100664637);
			RegexBoyerMoore.NativeMethodInfoPtr_MatchPattern_Private_Boolean_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexBoyerMoore>.NativeClassPtr, 100664638);
			RegexBoyerMoore.NativeMethodInfoPtr_IsMatch_Public_Boolean_String_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexBoyerMoore>.NativeClassPtr, 100664639);
			RegexBoyerMoore.NativeMethodInfoPtr_Scan_Public_Int32_String_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexBoyerMoore>.NativeClassPtr, 100664640);
		}

		// Token: 0x0600082C RID: 2092 RVA: 0x0003C560 File Offset: 0x0003A760
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 438669, RefRangeEnd = 438670, XrefRangeStart = 438636, XrefRangeEnd = 438669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexBoyerMoore(string pattern, bool caseInsensitive, bool rightToLeft, CultureInfo culture)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexBoyerMoore>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pattern);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref caseInsensitive;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rightToLeft;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(culture);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexBoyerMoore.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Boolean_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600082D RID: 2093 RVA: 0x0003C5DC File Offset: 0x0003A7DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 438671, RefRangeEnd = 438673, XrefRangeStart = 438670, XrefRangeEnd = 438671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MatchPattern(string text, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexBoyerMoore.NativeMethodInfoPtr_MatchPattern_Private_Boolean_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600082E RID: 2094 RVA: 0x0003C638 File Offset: 0x0003A838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438673, XrefRangeEnd = 438675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsMatch(string text, int index, int beglimit, int endlimit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref beglimit;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endlimit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexBoyerMoore.NativeMethodInfoPtr_IsMatch_Public_Boolean_String_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600082F RID: 2095 RVA: 0x0003C6B0 File Offset: 0x0003A8B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438675, XrefRangeEnd = 438687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Scan(string text, int index, int beglimit, int endlimit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref beglimit;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endlimit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexBoyerMoore.NativeMethodInfoPtr_Scan_Public_Int32_String_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x00004A8B File Offset: 0x00002C8B
		public RegexBoyerMoore(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06000831 RID: 2097 RVA: 0x0003C728 File Offset: 0x0003A928
		// (set) Token: 0x06000832 RID: 2098 RVA: 0x00004A94 File Offset: 0x00002C94
		public unsafe Il2CppStructArray<int> Positive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexBoyerMoore.NativeFieldInfoPtr_Positive);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexBoyerMoore.NativeFieldInfoPtr_Positive), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06000833 RID: 2099 RVA: 0x0003C758 File Offset: 0x0003A958
		// (set) Token: 0x06000834 RID: 2100 RVA: 0x00004AB3 File Offset: 0x00002CB3
		public unsafe Il2CppStructArray<int> NegativeASCII
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexBoyerMoore.NativeFieldInfoPtr_NegativeASCII);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexBoyerMoore.NativeFieldInfoPtr_NegativeASCII), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06000835 RID: 2101 RVA: 0x0003C788 File Offset: 0x0003A988
		// (set) Token: 0x06000836 RID: 2102 RVA: 0x00004AD2 File Offset: 0x00002CD2
		public unsafe Il2CppReferenceArray<Il2CppStructArray<int>> NegativeUnicode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexBoyerMoore.NativeFieldInfoPtr_NegativeUnicode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexBoyerMoore.NativeFieldInfoPtr_NegativeUnicode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06000837 RID: 2103 RVA: 0x0003C7B8 File Offset: 0x0003A9B8
		// (set) Token: 0x06000838 RID: 2104 RVA: 0x00004AF1 File Offset: 0x00002CF1
		public unsafe string Pattern
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexBoyerMoore.NativeFieldInfoPtr_Pattern);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexBoyerMoore.NativeFieldInfoPtr_Pattern), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06000839 RID: 2105 RVA: 0x0003C7E0 File Offset: 0x0003A9E0
		// (set) Token: 0x0600083A RID: 2106 RVA: 0x00004B10 File Offset: 0x00002D10
		public unsafe int LowASCII
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexBoyerMoore.NativeFieldInfoPtr_LowASCII);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexBoyerMoore.NativeFieldInfoPtr_LowASCII)) = value;
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x0600083B RID: 2107 RVA: 0x0003C808 File Offset: 0x0003AA08
		// (set) Token: 0x0600083C RID: 2108 RVA: 0x00004B2B File Offset: 0x00002D2B
		public unsafe int HighASCII
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexBoyerMoore.NativeFieldInfoPtr_HighASCII);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexBoyerMoore.NativeFieldInfoPtr_HighASCII)) = value;
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x0600083D RID: 2109 RVA: 0x0003C830 File Offset: 0x0003AA30
		// (set) Token: 0x0600083E RID: 2110 RVA: 0x00004B46 File Offset: 0x00002D46
		public unsafe bool RightToLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexBoyerMoore.NativeFieldInfoPtr_RightToLeft);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexBoyerMoore.NativeFieldInfoPtr_RightToLeft)) = value;
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x0600083F RID: 2111 RVA: 0x0003C858 File Offset: 0x0003AA58
		// (set) Token: 0x06000840 RID: 2112 RVA: 0x00004B61 File Offset: 0x00002D61
		public unsafe bool CaseInsensitive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexBoyerMoore.NativeFieldInfoPtr_CaseInsensitive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexBoyerMoore.NativeFieldInfoPtr_CaseInsensitive)) = value;
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06000841 RID: 2113 RVA: 0x0003C880 File Offset: 0x0003AA80
		// (set) Token: 0x06000842 RID: 2114 RVA: 0x00004B7C File Offset: 0x00002D7C
		public unsafe CultureInfo _culture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexBoyerMoore.NativeFieldInfoPtr__culture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexBoyerMoore.NativeFieldInfoPtr__culture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040006CE RID: 1742
		private static readonly IntPtr NativeFieldInfoPtr_Positive;

		// Token: 0x040006CF RID: 1743
		private static readonly IntPtr NativeFieldInfoPtr_NegativeASCII;

		// Token: 0x040006D0 RID: 1744
		private static readonly IntPtr NativeFieldInfoPtr_NegativeUnicode;

		// Token: 0x040006D1 RID: 1745
		private static readonly IntPtr NativeFieldInfoPtr_Pattern;

		// Token: 0x040006D2 RID: 1746
		private static readonly IntPtr NativeFieldInfoPtr_LowASCII;

		// Token: 0x040006D3 RID: 1747
		private static readonly IntPtr NativeFieldInfoPtr_HighASCII;

		// Token: 0x040006D4 RID: 1748
		private static readonly IntPtr NativeFieldInfoPtr_RightToLeft;

		// Token: 0x040006D5 RID: 1749
		private static readonly IntPtr NativeFieldInfoPtr_CaseInsensitive;

		// Token: 0x040006D6 RID: 1750
		private static readonly IntPtr NativeFieldInfoPtr__culture;

		// Token: 0x040006D7 RID: 1751
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Boolean_CultureInfo_0;

		// Token: 0x040006D8 RID: 1752
		private static readonly IntPtr NativeMethodInfoPtr_MatchPattern_Private_Boolean_String_Int32_0;

		// Token: 0x040006D9 RID: 1753
		private static readonly IntPtr NativeMethodInfoPtr_IsMatch_Public_Boolean_String_Int32_Int32_Int32_0;

		// Token: 0x040006DA RID: 1754
		private static readonly IntPtr NativeMethodInfoPtr_Scan_Public_Int32_String_Int32_Int32_Int32_0;
	}
}
