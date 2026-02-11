using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;

namespace Il2CppSystem
{
	// Token: 0x020000C5 RID: 197
	public static class MemoryExtensions : Object
	{
		// Token: 0x06000CE3 RID: 3299 RVA: 0x000616E0 File Offset: 0x0005F8E0
		// Note: this type is marked as 'beforefieldinit'.
		static MemoryExtensions()
		{
			Il2CppClassPointerStore<MemoryExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "MemoryExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MemoryExtensions>.NativeClassPtr);
			MemoryExtensions.NativeMethodInfoPtr_EqualsOrdinal_Internal_Static_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryExtensions>.NativeClassPtr, 100665552);
			MemoryExtensions.NativeMethodInfoPtr_EqualsOrdinalIgnoreCase_Internal_Static_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryExtensions>.NativeClassPtr, 100665553);
			MemoryExtensions.NativeMethodInfoPtr_Contains_Internal_Static_Boolean_ReadOnlySpan_1_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryExtensions>.NativeClassPtr, 100665554);
			MemoryExtensions.NativeMethodInfoPtr_ToUpperInvariant_Public_Static_Int32_ReadOnlySpan_1_Char_Span_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryExtensions>.NativeClassPtr, 100665555);
			MemoryExtensions.NativeMethodInfoPtr_EndsWith_Public_Static_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_StringComparison_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryExtensions>.NativeClassPtr, 100665556);
			MemoryExtensions.NativeMethodInfoPtr_StartsWith_Public_Static_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_StringComparison_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryExtensions>.NativeClassPtr, 100665557);
			MemoryExtensions.NativeMethodInfoPtr_AsSpan_Public_Static_Span_1_T_Il2CppArrayBase_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryExtensions>.NativeClassPtr, 100665558);
			MemoryExtensions.NativeMethodInfoPtr_AsSpan_Public_Static_ReadOnlySpan_1_Char_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryExtensions>.NativeClassPtr, 100665559);
			MemoryExtensions.NativeMethodInfoPtr_AsSpan_Public_Static_ReadOnlySpan_1_Char_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryExtensions>.NativeClassPtr, 100665560);
			MemoryExtensions.NativeMethodInfoPtr_AsSpan_Public_Static_ReadOnlySpan_1_Char_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryExtensions>.NativeClassPtr, 100665561);
			MemoryExtensions.NativeMethodInfoPtr_Trim_Public_Static_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryExtensions>.NativeClassPtr, 100665562);
			MemoryExtensions.NativeMethodInfoPtr_TrimStart_Public_Static_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryExtensions>.NativeClassPtr, 100665563);
			MemoryExtensions.NativeMethodInfoPtr_TrimEnd_Public_Static_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryExtensions>.NativeClassPtr, 100665564);
			MemoryExtensions.NativeMethodInfoPtr_IndexOf_Public_Static_Int32_ReadOnlySpan_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryExtensions>.NativeClassPtr, 100665565);
			MemoryExtensions.NativeMethodInfoPtr_IndexOfAny_Public_Static_Int32_ReadOnlySpan_1_T_ReadOnlySpan_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryExtensions>.NativeClassPtr, 100665566);
			MemoryExtensions.NativeMethodInfoPtr_SequenceEqual_Public_Static_Boolean_ReadOnlySpan_1_T_ReadOnlySpan_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryExtensions>.NativeClassPtr, 100665567);
			MemoryExtensions.NativeMethodInfoPtr_StartsWith_Public_Static_Boolean_ReadOnlySpan_1_T_ReadOnlySpan_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryExtensions>.NativeClassPtr, 100665568);
			MemoryExtensions.NativeMethodInfoPtr_EndsWith_Public_Static_Boolean_ReadOnlySpan_1_T_ReadOnlySpan_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryExtensions>.NativeClassPtr, 100665569);
			MemoryExtensions.NativeMethodInfoPtr_AsSpan_Public_Static_Span_1_T_Il2CppArrayBase_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryExtensions>.NativeClassPtr, 100665570);
			MemoryExtensions.NativeMethodInfoPtr_CopyTo_Public_Static_Void_Il2CppArrayBase_1_T_Span_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryExtensions>.NativeClassPtr, 100665571);
			MemoryExtensions.NativeMethodInfoPtr_IsTypeComparableAsBytes_Private_Static_Boolean_byref_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryExtensions>.NativeClassPtr, 100665572);
		}

		// Token: 0x06000CE4 RID: 3300 RVA: 0x000618B4 File Offset: 0x0005FAB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1311209, XrefRangeEnd = 1311213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool EqualsOrdinal(this ReadOnlySpan<char> span, ReadOnlySpan<char> value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(span));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryExtensions.NativeMethodInfoPtr_EqualsOrdinal_Internal_Static_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CE5 RID: 3301 RVA: 0x00061914 File Offset: 0x0005FB14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1311213, XrefRangeEnd = 1311218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool EqualsOrdinalIgnoreCase(this ReadOnlySpan<char> span, ReadOnlySpan<char> value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(span));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryExtensions.NativeMethodInfoPtr_EqualsOrdinalIgnoreCase_Internal_Static_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CE6 RID: 3302 RVA: 0x00061974 File Offset: 0x0005FB74
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1311219, RefRangeEnd = 1311221, XrefRangeStart = 1311218, XrefRangeEnd = 1311219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Contains(this ReadOnlySpan<char> source, char value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(source));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryExtensions.NativeMethodInfoPtr_Contains_Internal_Static_Boolean_ReadOnlySpan_1_Char_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CE7 RID: 3303 RVA: 0x000619C8 File Offset: 0x0005FBC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1311235, RefRangeEnd = 1311236, XrefRangeStart = 1311221, XrefRangeEnd = 1311235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ToUpperInvariant(this ReadOnlySpan<char> source, Span<char> destination)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(source));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(destination));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryExtensions.NativeMethodInfoPtr_ToUpperInvariant_Public_Static_Int32_ReadOnlySpan_1_Char_Span_1_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CE8 RID: 3304 RVA: 0x00061A28 File Offset: 0x0005FC28
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1311244, RefRangeEnd = 1311246, XrefRangeStart = 1311236, XrefRangeEnd = 1311244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool EndsWith(this ReadOnlySpan<char> span, ReadOnlySpan<char> value, StringComparison comparisonType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(span));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref comparisonType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryExtensions.NativeMethodInfoPtr_EndsWith_Public_Static_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_StringComparison_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CE9 RID: 3305 RVA: 0x00061A94 File Offset: 0x0005FC94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1311276, RefRangeEnd = 1311277, XrefRangeStart = 1311246, XrefRangeEnd = 1311276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool StartsWith(this ReadOnlySpan<char> span, ReadOnlySpan<char> value, StringComparison comparisonType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(span));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref comparisonType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryExtensions.NativeMethodInfoPtr_StartsWith_Public_Static_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_StringComparison_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CEA RID: 3306 RVA: 0x00061B00 File Offset: 0x0005FD00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1311277, XrefRangeEnd = 1311281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Span<T> AsSpan<T>(this Il2CppArrayBase<T> array, int start)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryExtensions.MethodInfoStoreGeneric_AsSpan_Public_Static_Span_1_T_Il2CppArrayBase_1_T_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Span<T>(intPtr);
		}

		// Token: 0x06000CEB RID: 3307 RVA: 0x00061B4C File Offset: 0x0005FD4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1311281, XrefRangeEnd = 1311283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ReadOnlySpan<char> AsSpan(this string text)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryExtensions.NativeMethodInfoPtr_AsSpan_Public_Static_ReadOnlySpan_1_Char_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ReadOnlySpan<char>(intPtr);
			}
		}

		// Token: 0x06000CEC RID: 3308 RVA: 0x00061B88 File Offset: 0x0005FD88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1311283, XrefRangeEnd = 1311288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ReadOnlySpan<char> AsSpan(this string text, int start)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryExtensions.NativeMethodInfoPtr_AsSpan_Public_Static_ReadOnlySpan_1_Char_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ReadOnlySpan<char>(intPtr);
		}

		// Token: 0x06000CED RID: 3309 RVA: 0x00061BD4 File Offset: 0x0005FDD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1311288, XrefRangeEnd = 1311293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ReadOnlySpan<char> AsSpan(this string text, int start, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryExtensions.NativeMethodInfoPtr_AsSpan_Public_Static_ReadOnlySpan_1_Char_String_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ReadOnlySpan<char>(intPtr);
		}

		// Token: 0x06000CEE RID: 3310 RVA: 0x00061C2C File Offset: 0x0005FE2C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1311311, RefRangeEnd = 1311317, XrefRangeStart = 1311293, XrefRangeEnd = 1311311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ReadOnlySpan<char> Trim(this ReadOnlySpan<char> span)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(span));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryExtensions.NativeMethodInfoPtr_Trim_Public_Static_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ReadOnlySpan<char>(intPtr);
			}
		}

		// Token: 0x06000CEF RID: 3311 RVA: 0x00061C70 File Offset: 0x0005FE70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1311317, XrefRangeEnd = 1311326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ReadOnlySpan<char> TrimStart(this ReadOnlySpan<char> span)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(span));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryExtensions.NativeMethodInfoPtr_TrimStart_Public_Static_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ReadOnlySpan<char>(intPtr);
			}
		}

		// Token: 0x06000CF0 RID: 3312 RVA: 0x00061CB4 File Offset: 0x0005FEB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1311326, XrefRangeEnd = 1311335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ReadOnlySpan<char> TrimEnd(this ReadOnlySpan<char> span)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(span));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryExtensions.NativeMethodInfoPtr_TrimEnd_Public_Static_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ReadOnlySpan<char>(intPtr);
			}
		}

		// Token: 0x06000CF1 RID: 3313 RVA: 0x00061CF8 File Offset: 0x0005FEF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1311335, XrefRangeEnd = 1311352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int IndexOf<T>(this ReadOnlySpan<T> span, T value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(span));
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = value;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref value;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MemoryExtensions.MethodInfoStoreGeneric_IndexOf_Public_Static_Int32_ReadOnlySpan_1_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000CF2 RID: 3314 RVA: 0x00061D88 File Offset: 0x0005FF88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1311352, XrefRangeEnd = 1311364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int IndexOfAny<T>(this ReadOnlySpan<T> span, ReadOnlySpan<T> values)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(span));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(values));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryExtensions.MethodInfoStoreGeneric_IndexOfAny_Public_Static_Int32_ReadOnlySpan_1_T_ReadOnlySpan_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CF3 RID: 3315 RVA: 0x00061DE8 File Offset: 0x0005FFE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1311364, XrefRangeEnd = 1311370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SequenceEqual<T>(this ReadOnlySpan<T> span, ReadOnlySpan<T> other)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(span));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryExtensions.MethodInfoStoreGeneric_SequenceEqual_Public_Static_Boolean_ReadOnlySpan_1_T_ReadOnlySpan_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CF4 RID: 3316 RVA: 0x00061E48 File Offset: 0x00060048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1311370, XrefRangeEnd = 1311376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool StartsWith<T>(this ReadOnlySpan<T> span, ReadOnlySpan<T> value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(span));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryExtensions.MethodInfoStoreGeneric_StartsWith_Public_Static_Boolean_ReadOnlySpan_1_T_ReadOnlySpan_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CF5 RID: 3317 RVA: 0x00061EA8 File Offset: 0x000600A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1311376, XrefRangeEnd = 1311382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool EndsWith<T>(this ReadOnlySpan<T> span, ReadOnlySpan<T> value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(span));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryExtensions.MethodInfoStoreGeneric_EndsWith_Public_Static_Boolean_ReadOnlySpan_1_T_ReadOnlySpan_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CF6 RID: 3318 RVA: 0x00061F08 File Offset: 0x00060108
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1311382, XrefRangeEnd = 1311386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Span<T> AsSpan<T>(this Il2CppArrayBase<T> array, int start, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryExtensions.MethodInfoStoreGeneric_AsSpan_Public_Static_Span_1_T_Il2CppArrayBase_1_T_Int32_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Span<T>(intPtr);
		}

		// Token: 0x06000CF7 RID: 3319 RVA: 0x00061F60 File Offset: 0x00060160
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1311386, XrefRangeEnd = 1311389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CopyTo<T>(this Il2CppArrayBase<T> source, Span<T> destination)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(destination));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryExtensions.MethodInfoStoreGeneric_CopyTo_Public_Static_Void_Il2CppArrayBase_1_T_Span_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CF8 RID: 3320 RVA: 0x00061FB0 File Offset: 0x000601B0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1311454, RefRangeEnd = 1311457, XrefRangeStart = 1311389, XrefRangeEnd = 1311454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsTypeComparableAsBytes<T>(out ulong size)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &size;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryExtensions.MethodInfoStoreGeneric_IsTypeComparableAsBytes_Private_Static_Boolean_byref_UInt64_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CF9 RID: 3321 RVA: 0x00005280 File Offset: 0x00003480
		public MemoryExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000A97 RID: 2711
		private static readonly IntPtr NativeMethodInfoPtr_EqualsOrdinal_Internal_Static_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_0;

		// Token: 0x04000A98 RID: 2712
		private static readonly IntPtr NativeMethodInfoPtr_EqualsOrdinalIgnoreCase_Internal_Static_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_0;

		// Token: 0x04000A99 RID: 2713
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Internal_Static_Boolean_ReadOnlySpan_1_Char_Char_0;

		// Token: 0x04000A9A RID: 2714
		private static readonly IntPtr NativeMethodInfoPtr_ToUpperInvariant_Public_Static_Int32_ReadOnlySpan_1_Char_Span_1_Char_0;

		// Token: 0x04000A9B RID: 2715
		private static readonly IntPtr NativeMethodInfoPtr_EndsWith_Public_Static_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_StringComparison_0;

		// Token: 0x04000A9C RID: 2716
		private static readonly IntPtr NativeMethodInfoPtr_StartsWith_Public_Static_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_StringComparison_0;

		// Token: 0x04000A9D RID: 2717
		private static readonly IntPtr NativeMethodInfoPtr_AsSpan_Public_Static_Span_1_T_Il2CppArrayBase_1_T_Int32_0;

		// Token: 0x04000A9E RID: 2718
		private static readonly IntPtr NativeMethodInfoPtr_AsSpan_Public_Static_ReadOnlySpan_1_Char_String_0;

		// Token: 0x04000A9F RID: 2719
		private static readonly IntPtr NativeMethodInfoPtr_AsSpan_Public_Static_ReadOnlySpan_1_Char_String_Int32_0;

		// Token: 0x04000AA0 RID: 2720
		private static readonly IntPtr NativeMethodInfoPtr_AsSpan_Public_Static_ReadOnlySpan_1_Char_String_Int32_Int32_0;

		// Token: 0x04000AA1 RID: 2721
		private static readonly IntPtr NativeMethodInfoPtr_Trim_Public_Static_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_0;

		// Token: 0x04000AA2 RID: 2722
		private static readonly IntPtr NativeMethodInfoPtr_TrimStart_Public_Static_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_0;

		// Token: 0x04000AA3 RID: 2723
		private static readonly IntPtr NativeMethodInfoPtr_TrimEnd_Public_Static_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_0;

		// Token: 0x04000AA4 RID: 2724
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Static_Int32_ReadOnlySpan_1_T_T_0;

		// Token: 0x04000AA5 RID: 2725
		private static readonly IntPtr NativeMethodInfoPtr_IndexOfAny_Public_Static_Int32_ReadOnlySpan_1_T_ReadOnlySpan_1_T_0;

		// Token: 0x04000AA6 RID: 2726
		private static readonly IntPtr NativeMethodInfoPtr_SequenceEqual_Public_Static_Boolean_ReadOnlySpan_1_T_ReadOnlySpan_1_T_0;

		// Token: 0x04000AA7 RID: 2727
		private static readonly IntPtr NativeMethodInfoPtr_StartsWith_Public_Static_Boolean_ReadOnlySpan_1_T_ReadOnlySpan_1_T_0;

		// Token: 0x04000AA8 RID: 2728
		private static readonly IntPtr NativeMethodInfoPtr_EndsWith_Public_Static_Boolean_ReadOnlySpan_1_T_ReadOnlySpan_1_T_0;

		// Token: 0x04000AA9 RID: 2729
		private static readonly IntPtr NativeMethodInfoPtr_AsSpan_Public_Static_Span_1_T_Il2CppArrayBase_1_T_Int32_Int32_0;

		// Token: 0x04000AAA RID: 2730
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Static_Void_Il2CppArrayBase_1_T_Span_1_T_0;

		// Token: 0x04000AAB RID: 2731
		private static readonly IntPtr NativeMethodInfoPtr_IsTypeComparableAsBytes_Private_Static_Boolean_byref_UInt64_0;

		// Token: 0x02000594 RID: 1428
		private sealed class MethodInfoStoreGeneric_AsSpan_Public_Static_Span_1_T_Il2CppArrayBase_1_T_Int32_0<T>
		{
			// Token: 0x04004714 RID: 18196
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(MemoryExtensions.NativeMethodInfoPtr_AsSpan_Public_Static_Span_1_T_Il2CppArrayBase_1_T_Int32_0, Il2CppClassPointerStore<MemoryExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000595 RID: 1429
		private sealed class MethodInfoStoreGeneric_IndexOf_Public_Static_Int32_ReadOnlySpan_1_T_T_0<T>
		{
			// Token: 0x04004715 RID: 18197
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(MemoryExtensions.NativeMethodInfoPtr_IndexOf_Public_Static_Int32_ReadOnlySpan_1_T_T_0, Il2CppClassPointerStore<MemoryExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000596 RID: 1430
		private sealed class MethodInfoStoreGeneric_IndexOfAny_Public_Static_Int32_ReadOnlySpan_1_T_ReadOnlySpan_1_T_0<T>
		{
			// Token: 0x04004716 RID: 18198
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(MemoryExtensions.NativeMethodInfoPtr_IndexOfAny_Public_Static_Int32_ReadOnlySpan_1_T_ReadOnlySpan_1_T_0, Il2CppClassPointerStore<MemoryExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000597 RID: 1431
		private sealed class MethodInfoStoreGeneric_SequenceEqual_Public_Static_Boolean_ReadOnlySpan_1_T_ReadOnlySpan_1_T_0<T>
		{
			// Token: 0x04004717 RID: 18199
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(MemoryExtensions.NativeMethodInfoPtr_SequenceEqual_Public_Static_Boolean_ReadOnlySpan_1_T_ReadOnlySpan_1_T_0, Il2CppClassPointerStore<MemoryExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000598 RID: 1432
		private sealed class MethodInfoStoreGeneric_StartsWith_Public_Static_Boolean_ReadOnlySpan_1_T_ReadOnlySpan_1_T_0<T>
		{
			// Token: 0x04004718 RID: 18200
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(MemoryExtensions.NativeMethodInfoPtr_StartsWith_Public_Static_Boolean_ReadOnlySpan_1_T_ReadOnlySpan_1_T_0, Il2CppClassPointerStore<MemoryExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000599 RID: 1433
		private sealed class MethodInfoStoreGeneric_EndsWith_Public_Static_Boolean_ReadOnlySpan_1_T_ReadOnlySpan_1_T_0<T>
		{
			// Token: 0x04004719 RID: 18201
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(MemoryExtensions.NativeMethodInfoPtr_EndsWith_Public_Static_Boolean_ReadOnlySpan_1_T_ReadOnlySpan_1_T_0, Il2CppClassPointerStore<MemoryExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200059A RID: 1434
		private sealed class MethodInfoStoreGeneric_AsSpan_Public_Static_Span_1_T_Il2CppArrayBase_1_T_Int32_Int32_0<T>
		{
			// Token: 0x0400471A RID: 18202
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(MemoryExtensions.NativeMethodInfoPtr_AsSpan_Public_Static_Span_1_T_Il2CppArrayBase_1_T_Int32_Int32_0, Il2CppClassPointerStore<MemoryExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200059B RID: 1435
		private sealed class MethodInfoStoreGeneric_CopyTo_Public_Static_Void_Il2CppArrayBase_1_T_Span_1_T_0<T>
		{
			// Token: 0x0400471B RID: 18203
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(MemoryExtensions.NativeMethodInfoPtr_CopyTo_Public_Static_Void_Il2CppArrayBase_1_T_Span_1_T_0, Il2CppClassPointerStore<MemoryExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200059C RID: 1436
		private sealed class MethodInfoStoreGeneric_IsTypeComparableAsBytes_Private_Static_Boolean_byref_UInt64_0<T>
		{
			// Token: 0x0400471C RID: 18204
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(MemoryExtensions.NativeMethodInfoPtr_IsTypeComparableAsBytes_Private_Static_Boolean_byref_UInt64_0, Il2CppClassPointerStore<MemoryExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
