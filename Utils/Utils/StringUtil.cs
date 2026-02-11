using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Text;

namespace Utils
{
	// Token: 0x02000037 RID: 55
	public static class StringUtil : Object
	{
		// Token: 0x06000240 RID: 576 RVA: 0x0000DDD0 File Offset: 0x0000BFD0
		// Note: this type is marked as 'beforefieldinit'.
		static StringUtil()
		{
			Il2CppClassPointerStore<StringUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("Utils.dll", "Utils", "StringUtil");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringUtil>.NativeClassPtr);
			StringUtil.NativeFieldInfoPtr_cachedSb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringUtil>.NativeClassPtr, "cachedSb");
			StringUtil.NativeFieldInfoPtr_maxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringUtil>.NativeClassPtr, "maxValue");
			StringUtil.NativeFieldInfoPtr_cachedStrings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringUtil>.NativeClassPtr, "cachedStrings");
			StringUtil.NativeMethodInfoPtr_mkString_Public_Static_String_IEnumerable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtil>.NativeClassPtr, 100663845);
			StringUtil.NativeMethodInfoPtr_mkString_Public_Static_String_IEnumerable_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtil>.NativeClassPtr, 100663846);
			StringUtil.NativeMethodInfoPtr_mkString_Public_Static_String_IEnumerable_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtil>.NativeClassPtr, 100663847);
			StringUtil.NativeMethodInfoPtr_mkString_Public_Static_String_IEnumerable_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtil>.NativeClassPtr, 100663848);
			StringUtil.NativeMethodInfoPtr_JoinString_Public_Static_String_IEnumerable_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtil>.NativeClassPtr, 100663849);
			StringUtil.NativeMethodInfoPtr_IsEmpty_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtil>.NativeClassPtr, 100663850);
			StringUtil.NativeMethodInfoPtr_BuildLogString_Public_Static_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtil>.NativeClassPtr, 100663851);
			StringUtil.NativeMethodInfoPtr_SetBold_Public_Static_StringBuilder_StringBuilder_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtil>.NativeClassPtr, 100663852);
			StringUtil.NativeMethodInfoPtr_SetItalic_Public_Static_StringBuilder_StringBuilder_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtil>.NativeClassPtr, 100663853);
			StringUtil.NativeMethodInfoPtr_Bold_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtil>.NativeClassPtr, 100663854);
			StringUtil.NativeMethodInfoPtr_RemoveDiacritics_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtil>.NativeClassPtr, 100663855);
			StringUtil.NativeMethodInfoPtr_RemoveUnicodeFormatting_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtil>.NativeClassPtr, 100663856);
			StringUtil.NativeMethodInfoPtr_GetLocalizedListSeparator_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtil>.NativeClassPtr, 100663857);
			StringUtil.NativeMethodInfoPtr_Ellipsify_Public_Static_String_String_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtil>.NativeClassPtr, 100663858);
			StringUtil.NativeMethodInfoPtr_GetBytes_Public_Static_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtil>.NativeClassPtr, 100663859);
			StringUtil.NativeMethodInfoPtr_GetString_Public_Static_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtil>.NativeClassPtr, 100663860);
			StringUtil.NativeMethodInfoPtr_HexStringToBytes_Public_Static_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtil>.NativeClassPtr, 100663861);
			StringUtil.NativeMethodInfoPtr_ParseNewLines_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtil>.NativeClassPtr, 100663862);
			StringUtil.NativeMethodInfoPtr_FastStartsWith_Public_Static_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtil>.NativeClassPtr, 100663863);
			StringUtil.NativeMethodInfoPtr_FastEndsWith_Public_Static_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtil>.NativeClassPtr, 100663864);
			StringUtil.NativeMethodInfoPtr_IntToString_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtil>.NativeClassPtr, 100663865);
			StringUtil.NativeMethodInfoPtr_IntToString_Public_Static_String_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtil>.NativeClassPtr, 100663866);
			StringUtil.NativeMethodInfoPtr_CompareStringToLong_Public_Static_Boolean_String_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtil>.NativeClassPtr, 100663867);
			StringUtil.NativeMethodInfoPtr_Without_Public_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtil>.NativeClassPtr, 100663868);
			StringUtil.NativeMethodInfoPtr_LimitLength_Public_Static_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtil>.NativeClassPtr, 100663869);
		}

		// Token: 0x06000241 RID: 577 RVA: 0x0000E030 File Offset: 0x0000C230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1183846, XrefRangeEnd = 1183850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string mkString(this IEnumerable array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringUtil.NativeMethodInfoPtr_mkString_Public_Static_String_IEnumerable_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000242 RID: 578 RVA: 0x0000E06C File Offset: 0x0000C26C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1183850, XrefRangeEnd = 1183854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string mkString(this IEnumerable array, string start)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(start);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringUtil.NativeMethodInfoPtr_mkString_Public_Static_String_IEnumerable_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000243 RID: 579 RVA: 0x0000E0BC File Offset: 0x0000C2BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1183854, XrefRangeEnd = 1183858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string mkString(this IEnumerable array, string start, string sep)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(start);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sep);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringUtil.NativeMethodInfoPtr_mkString_Public_Static_String_IEnumerable_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000244 RID: 580 RVA: 0x0000E11C File Offset: 0x0000C31C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1183888, RefRangeEnd = 1183891, XrefRangeStart = 1183858, XrefRangeEnd = 1183888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string mkString(this IEnumerable array, string start, string sep, string end)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(start);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sep);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(end);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringUtil.NativeMethodInfoPtr_mkString_Public_Static_String_IEnumerable_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000245 RID: 581 RVA: 0x0000E190 File Offset: 0x0000C390
		[CallerCount(158)]
		[CachedScanResults(RefRangeStart = 1183912, RefRangeEnd = 1184070, XrefRangeStart = 1183891, XrefRangeEnd = 1183912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string JoinString(this IEnumerable strings, string seperator = ", ")
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(strings);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(seperator);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringUtil.NativeMethodInfoPtr_JoinString_Public_Static_String_IEnumerable_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000246 RID: 582 RVA: 0x0000E1E0 File Offset: 0x0000C3E0
		[CallerCount(52)]
		[CachedScanResults(RefRangeStart = 745973, RefRangeEnd = 746025, XrefRangeStart = 745973, XrefRangeEnd = 746025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsEmpty(this string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringUtil.NativeMethodInfoPtr_IsEmpty_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000247 RID: 583 RVA: 0x0000E224 File Offset: 0x0000C424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184070, XrefRangeEnd = 1184082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string BuildLogString([Optional] Il2CppReferenceArray<Object> values)
		{
			if (values == null)
			{
				values = new Il2CppReferenceArray<Object>(0L);
			}
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(values);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringUtil.NativeMethodInfoPtr_BuildLogString_Public_Static_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000248 RID: 584 RVA: 0x0000E270 File Offset: 0x0000C470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184082, XrefRangeEnd = 1184087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static StringBuilder SetBold(this StringBuilder stringBuilder, bool isBold)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stringBuilder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isBold;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringUtil.NativeMethodInfoPtr_SetBold_Public_Static_StringBuilder_StringBuilder_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
		}

		// Token: 0x06000249 RID: 585 RVA: 0x0000E2C4 File Offset: 0x0000C4C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184087, XrefRangeEnd = 1184092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static StringBuilder SetItalic(this StringBuilder stringBuilder, bool isItalic)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stringBuilder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isItalic;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringUtil.NativeMethodInfoPtr_SetItalic_Public_Static_StringBuilder_StringBuilder_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
		}

		// Token: 0x0600024A RID: 586 RVA: 0x0000E318 File Offset: 0x0000C518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184092, XrefRangeEnd = 1184095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Bold(this string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringUtil.NativeMethodInfoPtr_Bold_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600024B RID: 587 RVA: 0x0000E354 File Offset: 0x0000C554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184095, XrefRangeEnd = 1184114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string RemoveDiacritics(this string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringUtil.NativeMethodInfoPtr_RemoveDiacritics_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600024C RID: 588 RVA: 0x0000E390 File Offset: 0x0000C590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184114, XrefRangeEnd = 1184121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string RemoveUnicodeFormatting(string formattedString)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(formattedString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringUtil.NativeMethodInfoPtr_RemoveUnicodeFormatting_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600024D RID: 589 RVA: 0x0000E3CC File Offset: 0x0000C5CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184121, XrefRangeEnd = 1184129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetLocalizedListSeparator()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringUtil.NativeMethodInfoPtr_GetLocalizedListSeparator_Public_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600024E RID: 590 RVA: 0x0000E3F8 File Offset: 0x0000C5F8
		[CallerCount(0)]
		public unsafe static string Ellipsify(string input, int charCount, string ellipsisChar = "...")
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ellipsisChar);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringUtil.NativeMethodInfoPtr_Ellipsify_Public_Static_String_String_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600024F RID: 591 RVA: 0x0000E454 File Offset: 0x0000C654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184129, XrefRangeEnd = 1184134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> GetBytes(string str)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringUtil.NativeMethodInfoPtr_GetBytes_Public_Static_Il2CppStructArray_1_Byte_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06000250 RID: 592 RVA: 0x0000E498 File Offset: 0x0000C698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184134, XrefRangeEnd = 1184140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetString(Il2CppStructArray<byte> bytes)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringUtil.NativeMethodInfoPtr_GetString_Public_Static_String_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000251 RID: 593 RVA: 0x0000E4D4 File Offset: 0x0000C6D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184140, XrefRangeEnd = 1184150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> HexStringToBytes(string hex)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(hex);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringUtil.NativeMethodInfoPtr_HexStringToBytes_Public_Static_Il2CppStructArray_1_Byte_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06000252 RID: 594 RVA: 0x0000E518 File Offset: 0x0000C718
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1184160, RefRangeEnd = 1184162, XrefRangeStart = 1184150, XrefRangeEnd = 1184160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ParseNewLines(string str)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringUtil.NativeMethodInfoPtr_ParseNewLines_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000253 RID: 595 RVA: 0x0000E554 File Offset: 0x0000C754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184162, XrefRangeEnd = 1184164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool FastStartsWith(string a, string b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringUtil.NativeMethodInfoPtr_FastStartsWith_Public_Static_Boolean_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000254 RID: 596 RVA: 0x0000E5A8 File Offset: 0x0000C7A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184164, XrefRangeEnd = 1184166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool FastEndsWith(string a, string b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringUtil.NativeMethodInfoPtr_FastEndsWith_Public_Static_Boolean_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000255 RID: 597 RVA: 0x0000E5FC File Offset: 0x0000C7FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184166, XrefRangeEnd = 1184186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string IntToString(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringUtil.NativeMethodInfoPtr_IntToString_Public_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000256 RID: 598 RVA: 0x0000E634 File Offset: 0x0000C834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184186, XrefRangeEnd = 1184207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string IntToString(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringUtil.NativeMethodInfoPtr_IntToString_Public_Static_String_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000257 RID: 599 RVA: 0x0000E66C File Offset: 0x0000C86C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184207, XrefRangeEnd = 1184212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CompareStringToLong(string s, long l)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref l;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringUtil.NativeMethodInfoPtr_CompareStringToLong_Public_Static_Boolean_String_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000258 RID: 600 RVA: 0x0000E6BC File Offset: 0x0000C8BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1184224, RefRangeEnd = 1184225, XrefRangeStart = 1184212, XrefRangeEnd = 1184224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Without(this string s, string replace)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(replace);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringUtil.NativeMethodInfoPtr_Without_Public_Static_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000259 RID: 601 RVA: 0x0000E70C File Offset: 0x0000C90C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184225, XrefRangeEnd = 1184232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string LimitLength(this string x, int maxLength)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringUtil.NativeMethodInfoPtr_LimitLength_Public_Static_String_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00002A2C File Offset: 0x00000C2C
		public static string BuildLogString(params Object[] values)
		{
			return StringUtil.BuildLogString(new Il2CppReferenceArray<Object>(values));
		}

		// Token: 0x0600025B RID: 603 RVA: 0x00002A39 File Offset: 0x00000C39
		public StringUtil(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600025C RID: 604 RVA: 0x0000E758 File Offset: 0x0000C958
		// (set) Token: 0x0600025D RID: 605 RVA: 0x00002A42 File Offset: 0x00000C42
		public unsafe static StringBuilder cachedSb
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StringUtil.NativeFieldInfoPtr_cachedSb, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StringUtil.NativeFieldInfoPtr_cachedSb, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600025E RID: 606 RVA: 0x0000E780 File Offset: 0x0000C980
		// (set) Token: 0x0600025F RID: 607 RVA: 0x00002A54 File Offset: 0x00000C54
		public unsafe static int maxValue
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(StringUtil.NativeFieldInfoPtr_maxValue, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StringUtil.NativeFieldInfoPtr_maxValue, (void*)(&value));
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000260 RID: 608 RVA: 0x0000E79C File Offset: 0x0000C99C
		// (set) Token: 0x06000261 RID: 609 RVA: 0x00002A62 File Offset: 0x00000C62
		public unsafe static Il2CppStringArray cachedStrings
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StringUtil.NativeFieldInfoPtr_cachedStrings, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StringUtil.NativeFieldInfoPtr_cachedStrings, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400018A RID: 394
		private static readonly IntPtr NativeFieldInfoPtr_cachedSb;

		// Token: 0x0400018B RID: 395
		private static readonly IntPtr NativeFieldInfoPtr_maxValue;

		// Token: 0x0400018C RID: 396
		private static readonly IntPtr NativeFieldInfoPtr_cachedStrings;

		// Token: 0x0400018D RID: 397
		private static readonly IntPtr NativeMethodInfoPtr_mkString_Public_Static_String_IEnumerable_0;

		// Token: 0x0400018E RID: 398
		private static readonly IntPtr NativeMethodInfoPtr_mkString_Public_Static_String_IEnumerable_String_0;

		// Token: 0x0400018F RID: 399
		private static readonly IntPtr NativeMethodInfoPtr_mkString_Public_Static_String_IEnumerable_String_String_0;

		// Token: 0x04000190 RID: 400
		private static readonly IntPtr NativeMethodInfoPtr_mkString_Public_Static_String_IEnumerable_String_String_String_0;

		// Token: 0x04000191 RID: 401
		private static readonly IntPtr NativeMethodInfoPtr_JoinString_Public_Static_String_IEnumerable_String_0;

		// Token: 0x04000192 RID: 402
		private static readonly IntPtr NativeMethodInfoPtr_IsEmpty_Public_Static_Boolean_String_0;

		// Token: 0x04000193 RID: 403
		private static readonly IntPtr NativeMethodInfoPtr_BuildLogString_Public_Static_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000194 RID: 404
		private static readonly IntPtr NativeMethodInfoPtr_SetBold_Public_Static_StringBuilder_StringBuilder_Boolean_0;

		// Token: 0x04000195 RID: 405
		private static readonly IntPtr NativeMethodInfoPtr_SetItalic_Public_Static_StringBuilder_StringBuilder_Boolean_0;

		// Token: 0x04000196 RID: 406
		private static readonly IntPtr NativeMethodInfoPtr_Bold_Public_Static_String_String_0;

		// Token: 0x04000197 RID: 407
		private static readonly IntPtr NativeMethodInfoPtr_RemoveDiacritics_Public_Static_String_String_0;

		// Token: 0x04000198 RID: 408
		private static readonly IntPtr NativeMethodInfoPtr_RemoveUnicodeFormatting_Public_Static_String_String_0;

		// Token: 0x04000199 RID: 409
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalizedListSeparator_Public_Static_String_0;

		// Token: 0x0400019A RID: 410
		private static readonly IntPtr NativeMethodInfoPtr_Ellipsify_Public_Static_String_String_Int32_String_0;

		// Token: 0x0400019B RID: 411
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Static_Il2CppStructArray_1_Byte_String_0;

		// Token: 0x0400019C RID: 412
		private static readonly IntPtr NativeMethodInfoPtr_GetString_Public_Static_String_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400019D RID: 413
		private static readonly IntPtr NativeMethodInfoPtr_HexStringToBytes_Public_Static_Il2CppStructArray_1_Byte_String_0;

		// Token: 0x0400019E RID: 414
		private static readonly IntPtr NativeMethodInfoPtr_ParseNewLines_Public_Static_String_String_0;

		// Token: 0x0400019F RID: 415
		private static readonly IntPtr NativeMethodInfoPtr_FastStartsWith_Public_Static_Boolean_String_String_0;

		// Token: 0x040001A0 RID: 416
		private static readonly IntPtr NativeMethodInfoPtr_FastEndsWith_Public_Static_Boolean_String_String_0;

		// Token: 0x040001A1 RID: 417
		private static readonly IntPtr NativeMethodInfoPtr_IntToString_Public_Static_String_Int32_0;

		// Token: 0x040001A2 RID: 418
		private static readonly IntPtr NativeMethodInfoPtr_IntToString_Public_Static_String_UInt64_0;

		// Token: 0x040001A3 RID: 419
		private static readonly IntPtr NativeMethodInfoPtr_CompareStringToLong_Public_Static_Boolean_String_Int64_0;

		// Token: 0x040001A4 RID: 420
		private static readonly IntPtr NativeMethodInfoPtr_Without_Public_Static_String_String_String_0;

		// Token: 0x040001A5 RID: 421
		private static readonly IntPtr NativeMethodInfoPtr_LimitLength_Public_Static_String_String_Int32_0;

		// Token: 0x020000B3 RID: 179
		public class NonSortArticleComparer : Object
		{
			// Token: 0x06000585 RID: 1413 RVA: 0x000198A0 File Offset: 0x00017AA0
			// Note: this type is marked as 'beforefieldinit'.
			static NonSortArticleComparer()
			{
				Il2CppClassPointerStore<StringUtil.NonSortArticleComparer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StringUtil>.NativeClassPtr, "NonSortArticleComparer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringUtil.NonSortArticleComparer>.NativeClassPtr);
				StringUtil.NonSortArticleComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtil.NonSortArticleComparer>.NativeClassPtr, 100663871);
				StringUtil.NonSortArticleComparer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtil.NonSortArticleComparer>.NativeClassPtr, 100663872);
			}

			// Token: 0x06000586 RID: 1414 RVA: 0x000198F4 File Offset: 0x00017AF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1183813, XrefRangeEnd = 1183846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual int Compare(string x, string y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringUtil.NonSortArticleComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000587 RID: 1415 RVA: 0x00019954 File Offset: 0x00017B54
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NonSortArticleComparer()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringUtil.NonSortArticleComparer>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringUtil.NonSortArticleComparer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000588 RID: 1416 RVA: 0x0000422E File Offset: 0x0000242E
			public NonSortArticleComparer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040003A1 RID: 929
			private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_String_String_0;

			// Token: 0x040003A2 RID: 930
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
