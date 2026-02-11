using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using Il2CppSystem.Reflection;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200006B RID: 107
	public static class StringUtils : Object
	{
		// Token: 0x0600094A RID: 2378 RVA: 0x0003D604 File Offset: 0x0003B804
		// Note: this type is marked as 'beforefieldinit'.
		static StringUtils()
		{
			Il2CppClassPointerStore<StringUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Utilities", "StringUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringUtils>.NativeClassPtr);
			StringUtils.NativeFieldInfoPtr_CarriageReturnLineFeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, "CarriageReturnLineFeed");
			StringUtils.NativeFieldInfoPtr_Empty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, "Empty");
			StringUtils.NativeFieldInfoPtr_CarriageReturn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, "CarriageReturn");
			StringUtils.NativeFieldInfoPtr_LineFeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, "LineFeed");
			StringUtils.NativeFieldInfoPtr_Tab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, "Tab");
			StringUtils.NativeMethodInfoPtr_IsNullOrEmpty_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100665089);
			StringUtils.NativeMethodInfoPtr_FormatWith_Public_Static_String_String_IFormatProvider_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100665090);
			StringUtils.NativeMethodInfoPtr_FormatWith_Public_Static_String_String_IFormatProvider_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100665091);
			StringUtils.NativeMethodInfoPtr_FormatWith_Public_Static_String_String_IFormatProvider_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100665092);
			StringUtils.NativeMethodInfoPtr_FormatWith_Public_Static_String_String_IFormatProvider_Object_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100665093);
			StringUtils.NativeMethodInfoPtr_FormatWith_Private_Static_String_String_IFormatProvider_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100665094);
			StringUtils.NativeMethodInfoPtr_IsWhiteSpace_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100665095);
			StringUtils.NativeMethodInfoPtr_CreateStringWriter_Public_Static_StringWriter_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100665096);
			StringUtils.NativeMethodInfoPtr_ToCharAsUnicode_Public_Static_Void_Char_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100665097);
			StringUtils.NativeMethodInfoPtr_ForgivingCaseSensitiveFind_Public_Static_TSource_IEnumerable_1_TSource_Func_2_TSource_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100665098);
			StringUtils.NativeMethodInfoPtr_ToCamelCase_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100665099);
			StringUtils.NativeMethodInfoPtr_ToLower_Private_Static_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100665100);
			StringUtils.NativeMethodInfoPtr_ToSnakeCase_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100665101);
			StringUtils.NativeMethodInfoPtr_ToKebabCase_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100665102);
			StringUtils.NativeMethodInfoPtr_ToSeparatedCase_Private_Static_String_String_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100665103);
			StringUtils.NativeMethodInfoPtr_IsHighSurrogate_Public_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100665104);
			StringUtils.NativeMethodInfoPtr_IsLowSurrogate_Public_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100665105);
			StringUtils.NativeMethodInfoPtr_IndexOf_Public_Static_Int32_String_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100665106);
			StringUtils.NativeMethodInfoPtr_Replace_Public_Static_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100665107);
			StringUtils.NativeMethodInfoPtr_StartsWith_Public_Static_Boolean_String_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100665108);
			StringUtils.NativeMethodInfoPtr_EndsWith_Public_Static_Boolean_String_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100665109);
			StringUtils.NativeMethodInfoPtr_Trim_Public_Static_String_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100665110);
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x0003D850 File Offset: 0x0003BA50
		[CallerCount(52)]
		[CachedScanResults(RefRangeStart = 745973, RefRangeEnd = 746025, XrefRangeStart = 745972, XrefRangeEnd = 745973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsNullOrEmpty(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_IsNullOrEmpty_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x0003D894 File Offset: 0x0003BA94
		[CallerCount(44)]
		[CachedScanResults(RefRangeStart = 746042, RefRangeEnd = 746086, XrefRangeStart = 746025, XrefRangeEnd = 746042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatWith(this string format, IFormatProvider provider, Object arg0)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg0);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_FormatWith_Public_Static_String_String_IFormatProvider_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x0003D8F4 File Offset: 0x0003BAF4
		[CallerCount(33)]
		[CachedScanResults(RefRangeStart = 746107, RefRangeEnd = 746140, XrefRangeStart = 746086, XrefRangeEnd = 746107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatWith(this string format, IFormatProvider provider, Object arg0, Object arg1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg0);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_FormatWith_Public_Static_String_String_IFormatProvider_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600094E RID: 2382 RVA: 0x0003D968 File Offset: 0x0003BB68
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 746165, RefRangeEnd = 746171, XrefRangeStart = 746140, XrefRangeEnd = 746165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatWith(this string format, IFormatProvider provider, Object arg0, Object arg1, Object arg2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg0);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg1);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_FormatWith_Public_Static_String_String_IFormatProvider_Object_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600094F RID: 2383 RVA: 0x0003D9F0 File Offset: 0x0003BBF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 746171, XrefRangeEnd = 746200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatWith(this string format, IFormatProvider provider, Object arg0, Object arg1, Object arg2, Object arg3)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg0);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg1);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg2);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg3);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_FormatWith_Public_Static_String_String_IFormatProvider_Object_Object_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000950 RID: 2384 RVA: 0x0003DA88 File Offset: 0x0003BC88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 746200, XrefRangeEnd = 746208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatWith(this string format, IFormatProvider provider, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_FormatWith_Private_Static_String_String_IFormatProvider_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x0003DAF8 File Offset: 0x0003BCF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 746214, RefRangeEnd = 746216, XrefRangeStart = 746208, XrefRangeEnd = 746214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsWhiteSpace(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_IsWhiteSpace_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x0003DB3C File Offset: 0x0003BD3C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 746228, RefRangeEnd = 746231, XrefRangeStart = 746216, XrefRangeEnd = 746228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static StringWriter CreateStringWriter(int capacity)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_CreateStringWriter_Public_Static_StringWriter_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringWriter>(intPtr3) : null;
			}
		}

		// Token: 0x06000953 RID: 2387 RVA: 0x0003DB7C File Offset: 0x0003BD7C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 746235, RefRangeEnd = 746237, XrefRangeStart = 746231, XrefRangeEnd = 746235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ToCharAsUnicode(char c, Il2CppStructArray<char> buffer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_ToCharAsUnicode_Public_Static_Void_Char_Il2CppStructArray_1_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000954 RID: 2388 RVA: 0x0003DBC0 File Offset: 0x0003BDC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 746265, RefRangeEnd = 746266, XrefRangeStart = 746237, XrefRangeEnd = 746265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TSource ForgivingCaseSensitiveFind<TSource>(this IEnumerable<TSource> source, Func<TSource, string> valueSelector, string testValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(valueSelector);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(testValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringUtils.MethodInfoStoreGeneric_ForgivingCaseSensitiveFind_Public_Static_TSource_IEnumerable_1_TSource_Func_2_TSource_String_String_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TSource>(intPtr, false, true);
		}

		// Token: 0x06000955 RID: 2389 RVA: 0x0003DC24 File Offset: 0x0003BE24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 746286, RefRangeEnd = 746287, XrefRangeStart = 746266, XrefRangeEnd = 746286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToCamelCase(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_ToCamelCase_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000956 RID: 2390 RVA: 0x0003DC60 File Offset: 0x0003BE60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 746295, RefRangeEnd = 746297, XrefRangeStart = 746287, XrefRangeEnd = 746295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char ToLower(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_ToLower_Private_Static_Char_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000957 RID: 2391 RVA: 0x0003DCA0 File Offset: 0x0003BEA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 746298, RefRangeEnd = 746299, XrefRangeStart = 746297, XrefRangeEnd = 746298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToSnakeCase(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_ToSnakeCase_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x0003DCDC File Offset: 0x0003BEDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 746300, RefRangeEnd = 746301, XrefRangeStart = 746299, XrefRangeEnd = 746300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToKebabCase(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_ToKebabCase_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x0003DD18 File Offset: 0x0003BF18
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 746338, RefRangeEnd = 746340, XrefRangeStart = 746301, XrefRangeEnd = 746338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToSeparatedCase(string s, char separator)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref separator;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_ToSeparatedCase_Private_Static_String_String_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x0003DD64 File Offset: 0x0003BF64
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 746344, RefRangeEnd = 746348, XrefRangeStart = 746340, XrefRangeEnd = 746344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsHighSurrogate(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_IsHighSurrogate_Public_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600095B RID: 2395 RVA: 0x0003DDA4 File Offset: 0x0003BFA4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 746352, RefRangeEnd = 746356, XrefRangeStart = 746348, XrefRangeEnd = 746352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsLowSurrogate(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_IsLowSurrogate_Public_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600095C RID: 2396 RVA: 0x0003DDE4 File Offset: 0x0003BFE4
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 746358, RefRangeEnd = 746366, XrefRangeStart = 746356, XrefRangeEnd = 746358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int IndexOf(string s, char c)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_IndexOf_Public_Static_Int32_String_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600095D RID: 2397 RVA: 0x0003DE34 File Offset: 0x0003C034
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 746368, RefRangeEnd = 746373, XrefRangeStart = 746366, XrefRangeEnd = 746368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Replace(string s, string oldValue, string newValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(oldValue);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(newValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_Replace_Public_Static_String_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600095E RID: 2398 RVA: 0x0003DE94 File Offset: 0x0003C094
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 746373, RefRangeEnd = 746374, XrefRangeStart = 746373, XrefRangeEnd = 746373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool StartsWith(this string source, char value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_StartsWith_Public_Static_Boolean_String_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600095F RID: 2399 RVA: 0x0003DEE4 File Offset: 0x0003C0E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 746374, RefRangeEnd = 746375, XrefRangeStart = 746374, XrefRangeEnd = 746374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool EndsWith(this string source, char value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_EndsWith_Public_Static_Boolean_String_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000960 RID: 2400 RVA: 0x0003DF34 File Offset: 0x0003C134
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 746408, RefRangeEnd = 746410, XrefRangeStart = 746375, XrefRangeEnd = 746408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Trim(this string s, int start, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_Trim_Public_Static_String_String_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000961 RID: 2401 RVA: 0x00004DE5 File Offset: 0x00002FE5
		public static string FormatWith(string format, IFormatProvider provider, params Object[] args)
		{
			return format.FormatWith(provider, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x06000962 RID: 2402 RVA: 0x00004DF4 File Offset: 0x00002FF4
		public StringUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06000963 RID: 2403 RVA: 0x0003DF8C File Offset: 0x0003C18C
		// (set) Token: 0x06000964 RID: 2404 RVA: 0x00004DFD File Offset: 0x00002FFD
		public unsafe static string CarriageReturnLineFeed
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StringUtils.NativeFieldInfoPtr_CarriageReturnLineFeed, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StringUtils.NativeFieldInfoPtr_CarriageReturnLineFeed, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x06000965 RID: 2405 RVA: 0x0003DFAC File Offset: 0x0003C1AC
		// (set) Token: 0x06000966 RID: 2406 RVA: 0x00004E0F File Offset: 0x0000300F
		public unsafe static string Empty
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StringUtils.NativeFieldInfoPtr_Empty, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StringUtils.NativeFieldInfoPtr_Empty, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06000967 RID: 2407 RVA: 0x0003DFCC File Offset: 0x0003C1CC
		// (set) Token: 0x06000968 RID: 2408 RVA: 0x00004E21 File Offset: 0x00003021
		public unsafe static char CarriageReturn
		{
			get
			{
				char c;
				IL2CPP.il2cpp_field_static_get_value(StringUtils.NativeFieldInfoPtr_CarriageReturn, (void*)(&c));
				return c;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StringUtils.NativeFieldInfoPtr_CarriageReturn, (void*)(&value));
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06000969 RID: 2409 RVA: 0x0003DFE8 File Offset: 0x0003C1E8
		// (set) Token: 0x0600096A RID: 2410 RVA: 0x00004E2F File Offset: 0x0000302F
		public unsafe static char LineFeed
		{
			get
			{
				char c;
				IL2CPP.il2cpp_field_static_get_value(StringUtils.NativeFieldInfoPtr_LineFeed, (void*)(&c));
				return c;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StringUtils.NativeFieldInfoPtr_LineFeed, (void*)(&value));
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x0600096B RID: 2411 RVA: 0x0003E004 File Offset: 0x0003C204
		// (set) Token: 0x0600096C RID: 2412 RVA: 0x00004E3D File Offset: 0x0000303D
		public unsafe static char Tab
		{
			get
			{
				char c;
				IL2CPP.il2cpp_field_static_get_value(StringUtils.NativeFieldInfoPtr_Tab, (void*)(&c));
				return c;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StringUtils.NativeFieldInfoPtr_Tab, (void*)(&value));
			}
		}

		// Token: 0x040007D1 RID: 2001
		private static readonly IntPtr NativeFieldInfoPtr_CarriageReturnLineFeed;

		// Token: 0x040007D2 RID: 2002
		private static readonly IntPtr NativeFieldInfoPtr_Empty;

		// Token: 0x040007D3 RID: 2003
		private static readonly IntPtr NativeFieldInfoPtr_CarriageReturn;

		// Token: 0x040007D4 RID: 2004
		private static readonly IntPtr NativeFieldInfoPtr_LineFeed;

		// Token: 0x040007D5 RID: 2005
		private static readonly IntPtr NativeFieldInfoPtr_Tab;

		// Token: 0x040007D6 RID: 2006
		private static readonly IntPtr NativeMethodInfoPtr_IsNullOrEmpty_Public_Static_Boolean_String_0;

		// Token: 0x040007D7 RID: 2007
		private static readonly IntPtr NativeMethodInfoPtr_FormatWith_Public_Static_String_String_IFormatProvider_Object_0;

		// Token: 0x040007D8 RID: 2008
		private static readonly IntPtr NativeMethodInfoPtr_FormatWith_Public_Static_String_String_IFormatProvider_Object_Object_0;

		// Token: 0x040007D9 RID: 2009
		private static readonly IntPtr NativeMethodInfoPtr_FormatWith_Public_Static_String_String_IFormatProvider_Object_Object_Object_0;

		// Token: 0x040007DA RID: 2010
		private static readonly IntPtr NativeMethodInfoPtr_FormatWith_Public_Static_String_String_IFormatProvider_Object_Object_Object_Object_0;

		// Token: 0x040007DB RID: 2011
		private static readonly IntPtr NativeMethodInfoPtr_FormatWith_Private_Static_String_String_IFormatProvider_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040007DC RID: 2012
		private static readonly IntPtr NativeMethodInfoPtr_IsWhiteSpace_Public_Static_Boolean_String_0;

		// Token: 0x040007DD RID: 2013
		private static readonly IntPtr NativeMethodInfoPtr_CreateStringWriter_Public_Static_StringWriter_Int32_0;

		// Token: 0x040007DE RID: 2014
		private static readonly IntPtr NativeMethodInfoPtr_ToCharAsUnicode_Public_Static_Void_Char_Il2CppStructArray_1_Char_0;

		// Token: 0x040007DF RID: 2015
		private static readonly IntPtr NativeMethodInfoPtr_ForgivingCaseSensitiveFind_Public_Static_TSource_IEnumerable_1_TSource_Func_2_TSource_String_String_0;

		// Token: 0x040007E0 RID: 2016
		private static readonly IntPtr NativeMethodInfoPtr_ToCamelCase_Public_Static_String_String_0;

		// Token: 0x040007E1 RID: 2017
		private static readonly IntPtr NativeMethodInfoPtr_ToLower_Private_Static_Char_Char_0;

		// Token: 0x040007E2 RID: 2018
		private static readonly IntPtr NativeMethodInfoPtr_ToSnakeCase_Public_Static_String_String_0;

		// Token: 0x040007E3 RID: 2019
		private static readonly IntPtr NativeMethodInfoPtr_ToKebabCase_Public_Static_String_String_0;

		// Token: 0x040007E4 RID: 2020
		private static readonly IntPtr NativeMethodInfoPtr_ToSeparatedCase_Private_Static_String_String_Char_0;

		// Token: 0x040007E5 RID: 2021
		private static readonly IntPtr NativeMethodInfoPtr_IsHighSurrogate_Public_Static_Boolean_Char_0;

		// Token: 0x040007E6 RID: 2022
		private static readonly IntPtr NativeMethodInfoPtr_IsLowSurrogate_Public_Static_Boolean_Char_0;

		// Token: 0x040007E7 RID: 2023
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Static_Int32_String_Char_0;

		// Token: 0x040007E8 RID: 2024
		private static readonly IntPtr NativeMethodInfoPtr_Replace_Public_Static_String_String_String_String_0;

		// Token: 0x040007E9 RID: 2025
		private static readonly IntPtr NativeMethodInfoPtr_StartsWith_Public_Static_Boolean_String_Char_0;

		// Token: 0x040007EA RID: 2026
		private static readonly IntPtr NativeMethodInfoPtr_EndsWith_Public_Static_Boolean_String_Char_0;

		// Token: 0x040007EB RID: 2027
		private static readonly IntPtr NativeMethodInfoPtr_Trim_Public_Static_String_String_Int32_Int32_0;

		// Token: 0x020001BF RID: 447
		public enum SeparatedCaseState
		{
			// Token: 0x04001610 RID: 5648
			Start,
			// Token: 0x04001611 RID: 5649
			Lower,
			// Token: 0x04001612 RID: 5650
			Upper,
			// Token: 0x04001613 RID: 5651
			NewWord
		}

		// Token: 0x020001C0 RID: 448
		[ObfuscatedName("Newtonsoft.Json.Utilities.StringUtils+<>c__DisplayClass14_0`1")]
		public sealed class __c__DisplayClass14_0<TSource> : Object
		{
			// Token: 0x06001E25 RID: 7717 RVA: 0x0008B934 File Offset: 0x00089B34
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass14_0()
			{
				Il2CppClassPointerStore<StringUtils.__c__DisplayClass14_0<TSource>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, "<>c__DisplayClass14_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringUtils.__c__DisplayClass14_0<TSource>>.NativeClassPtr);
				StringUtils.__c__DisplayClass14_0<TSource>.NativeFieldInfoPtr_valueSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringUtils.__c__DisplayClass14_0<TSource>>.NativeClassPtr, "valueSelector");
				StringUtils.__c__DisplayClass14_0<TSource>.NativeFieldInfoPtr_testValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringUtils.__c__DisplayClass14_0<TSource>>.NativeClassPtr, "testValue");
				StringUtils.__c__DisplayClass14_0<TSource>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils.__c__DisplayClass14_0<TSource>>.NativeClassPtr, 100665111);
				StringUtils.__c__DisplayClass14_0<TSource>.NativeMethodInfoPtr__ForgivingCaseSensitiveFind_b__0_Internal_Boolean_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils.__c__DisplayClass14_0<TSource>>.NativeClassPtr, 100665112);
				StringUtils.__c__DisplayClass14_0<TSource>.NativeMethodInfoPtr__ForgivingCaseSensitiveFind_b__1_Internal_Boolean_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils.__c__DisplayClass14_0<TSource>>.NativeClassPtr, 100665113);
			}

			// Token: 0x06001E26 RID: 7718 RVA: 0x0008BA00 File Offset: 0x00089C00
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass14_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringUtils.__c__DisplayClass14_0<TSource>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringUtils.__c__DisplayClass14_0<TSource>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E27 RID: 7719 RVA: 0x0008BA3C File Offset: 0x00089C3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 745962, XrefRangeEnd = 745967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ForgivingCaseSensitiveFind_b__0(TSource s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TSource).IsValueType)
					{
						TSource tsource = s;
						intPtr = ((tsource is string) ? IL2CPP.ManagedStringToIl2Cpp(tsource as string) : IL2CPP.Il2CppObjectBaseToPtr(tsource as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref s;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(StringUtils.__c__DisplayClass14_0<TSource>.NativeMethodInfoPtr__ForgivingCaseSensitiveFind_b__0_Internal_Boolean_TSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return *IL2CPP.il2cpp_object_unbox(intPtr2);
				}
			}

			// Token: 0x06001E28 RID: 7720 RVA: 0x0008BAC0 File Offset: 0x00089CC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 745967, XrefRangeEnd = 745972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ForgivingCaseSensitiveFind_b__1(TSource s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TSource).IsValueType)
					{
						TSource tsource = s;
						intPtr = ((tsource is string) ? IL2CPP.ManagedStringToIl2Cpp(tsource as string) : IL2CPP.Il2CppObjectBaseToPtr(tsource as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref s;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(StringUtils.__c__DisplayClass14_0<TSource>.NativeMethodInfoPtr__ForgivingCaseSensitiveFind_b__1_Internal_Boolean_TSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return *IL2CPP.il2cpp_object_unbox(intPtr2);
				}
			}

			// Token: 0x06001E29 RID: 7721 RVA: 0x0000EE8E File Offset: 0x0000D08E
			public __c__DisplayClass14_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700087B RID: 2171
			// (get) Token: 0x06001E2A RID: 7722 RVA: 0x0008BB44 File Offset: 0x00089D44
			// (set) Token: 0x06001E2B RID: 7723 RVA: 0x0000EE97 File Offset: 0x0000D097
			public unsafe Func<TSource, string> valueSelector
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringUtils.__c__DisplayClass14_0<TSource>.NativeFieldInfoPtr_valueSelector);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TSource, string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringUtils.__c__DisplayClass14_0<TSource>.NativeFieldInfoPtr_valueSelector), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700087C RID: 2172
			// (get) Token: 0x06001E2C RID: 7724 RVA: 0x0008BB74 File Offset: 0x00089D74
			// (set) Token: 0x06001E2D RID: 7725 RVA: 0x0000EEB6 File Offset: 0x0000D0B6
			public unsafe string testValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringUtils.__c__DisplayClass14_0<TSource>.NativeFieldInfoPtr_testValue);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringUtils.__c__DisplayClass14_0<TSource>.NativeFieldInfoPtr_testValue), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04001614 RID: 5652
			private static readonly IntPtr NativeFieldInfoPtr_valueSelector;

			// Token: 0x04001615 RID: 5653
			private static readonly IntPtr NativeFieldInfoPtr_testValue;

			// Token: 0x04001616 RID: 5654
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001617 RID: 5655
			private static readonly IntPtr NativeMethodInfoPtr__ForgivingCaseSensitiveFind_b__0_Internal_Boolean_TSource_0;

			// Token: 0x04001618 RID: 5656
			private static readonly IntPtr NativeMethodInfoPtr__ForgivingCaseSensitiveFind_b__1_Internal_Boolean_TSource_0;
		}

		// Token: 0x020001C1 RID: 449
		private sealed class MethodInfoStoreGeneric_ForgivingCaseSensitiveFind_Public_Static_TSource_IEnumerable_1_TSource_Func_2_TSource_String_String_0<TSource>
		{
			// Token: 0x04001619 RID: 5657
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(StringUtils.NativeMethodInfoPtr_ForgivingCaseSensitiveFind_Public_Static_TSource_IEnumerable_1_TSource_Func_2_TSource_String_String_0, Il2CppClassPointerStore<StringUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}
	}
}
