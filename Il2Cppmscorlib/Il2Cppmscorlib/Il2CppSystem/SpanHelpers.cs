using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Globalization;
using Il2CppSystem.Numerics;
using Il2CppSystem.Reflection;

namespace Il2CppSystem
{
	// Token: 0x020000E4 RID: 228
	public static class SpanHelpers : Object
	{
		// Token: 0x06000ED5 RID: 3797 RVA: 0x0006B090 File Offset: 0x00069290
		// Note: this type is marked as 'beforefieldinit'.
		static SpanHelpers()
		{
			Il2CppClassPointerStore<SpanHelpers>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "SpanHelpers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpanHelpers>.NativeClassPtr);
			SpanHelpers.NativeMethodInfoPtr_IndexOfAny_Public_Static_Int32_byref_Byte_Int32_byref_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpanHelpers>.NativeClassPtr, 100665890);
			SpanHelpers.NativeMethodInfoPtr_IndexOf_Public_Static_Int32_byref_Byte_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpanHelpers>.NativeClassPtr, 100665891);
			SpanHelpers.NativeMethodInfoPtr_SequenceEqual_Public_Static_Boolean_byref_Byte_byref_Byte_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpanHelpers>.NativeClassPtr, 100665892);
			SpanHelpers.NativeMethodInfoPtr_SequenceCompareTo_Public_Static_Int32_byref_Char_Int32_byref_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpanHelpers>.NativeClassPtr, 100665893);
			SpanHelpers.NativeMethodInfoPtr_IndexOf_Public_Static_Int32_byref_Char_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpanHelpers>.NativeClassPtr, 100665894);
			SpanHelpers.NativeMethodInfoPtr_LastIndexOf_Public_Static_Int32_byref_Char_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpanHelpers>.NativeClassPtr, 100665895);
			SpanHelpers.NativeMethodInfoPtr_LocateFirstFoundChar_Private_Static_Int32_Vector_1_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpanHelpers>.NativeClassPtr, 100665896);
			SpanHelpers.NativeMethodInfoPtr_LocateFirstFoundChar_Private_Static_Int32_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpanHelpers>.NativeClassPtr, 100665897);
			SpanHelpers.NativeMethodInfoPtr_LocateLastFoundChar_Private_Static_Int32_Vector_1_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpanHelpers>.NativeClassPtr, 100665898);
			SpanHelpers.NativeMethodInfoPtr_LocateLastFoundChar_Private_Static_Int32_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpanHelpers>.NativeClassPtr, 100665899);
			SpanHelpers.NativeMethodInfoPtr_IndexOf_Public_Static_Int32_byref_T_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpanHelpers>.NativeClassPtr, 100665900);
			SpanHelpers.NativeMethodInfoPtr_IndexOfAny_Public_Static_Int32_byref_T_Int32_byref_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpanHelpers>.NativeClassPtr, 100665901);
			SpanHelpers.NativeMethodInfoPtr_SequenceEqual_Public_Static_Boolean_byref_T_byref_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpanHelpers>.NativeClassPtr, 100665902);
			SpanHelpers.NativeMethodInfoPtr_StartsWithCultureHelper_Public_Static_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_CompareInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpanHelpers>.NativeClassPtr, 100665903);
			SpanHelpers.NativeMethodInfoPtr_StartsWithCultureIgnoreCaseHelper_Public_Static_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_CompareInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpanHelpers>.NativeClassPtr, 100665904);
			SpanHelpers.NativeMethodInfoPtr_StartsWithOrdinalIgnoreCaseHelper_Public_Static_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpanHelpers>.NativeClassPtr, 100665905);
			SpanHelpers.NativeMethodInfoPtr_EndsWithCultureHelper_Public_Static_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_CompareInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpanHelpers>.NativeClassPtr, 100665906);
			SpanHelpers.NativeMethodInfoPtr_EndsWithCultureIgnoreCaseHelper_Public_Static_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_CompareInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpanHelpers>.NativeClassPtr, 100665907);
			SpanHelpers.NativeMethodInfoPtr_EndsWithOrdinalIgnoreCaseHelper_Public_Static_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpanHelpers>.NativeClassPtr, 100665908);
			SpanHelpers.NativeMethodInfoPtr_ClearWithoutReferences_Public_Static_Void_byref_Byte_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpanHelpers>.NativeClassPtr, 100665909);
			SpanHelpers.NativeMethodInfoPtr_ClearWithReferences_Public_Static_Void_byref_IntPtr_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpanHelpers>.NativeClassPtr, 100665910);
		}

		// Token: 0x06000ED6 RID: 3798 RVA: 0x0006B264 File Offset: 0x00069464
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1320188, RefRangeEnd = 1320190, XrefRangeStart = 1320187, XrefRangeEnd = 1320188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int IndexOfAny(ref byte searchSpace, int searchSpaceLength, ref byte value, int valueLength)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &searchSpace;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref searchSpaceLength;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref valueLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpanHelpers.NativeMethodInfoPtr_IndexOfAny_Public_Static_Int32_byref_Byte_Int32_byref_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000ED7 RID: 3799 RVA: 0x0006B2CC File Offset: 0x000694CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1320222, RefRangeEnd = 1320223, XrefRangeStart = 1320190, XrefRangeEnd = 1320222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int IndexOf(ref byte searchSpace, byte value, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &searchSpace;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpanHelpers.NativeMethodInfoPtr_IndexOf_Public_Static_Int32_byref_Byte_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000ED8 RID: 3800 RVA: 0x0006B328 File Offset: 0x00069528
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1320231, RefRangeEnd = 1320245, XrefRangeStart = 1320223, XrefRangeEnd = 1320231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SequenceEqual(ref byte first, ref byte second, ulong length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &first;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &second;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpanHelpers.NativeMethodInfoPtr_SequenceEqual_Public_Static_Boolean_byref_Byte_byref_Byte_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000ED9 RID: 3801 RVA: 0x0006B384 File Offset: 0x00069584
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1320302, RefRangeEnd = 1320308, XrefRangeStart = 1320245, XrefRangeEnd = 1320302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int SequenceCompareTo(ref char first, int firstLength, ref char second, int secondLength)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &first;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref firstLength;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &second;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref secondLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpanHelpers.NativeMethodInfoPtr_SequenceCompareTo_Public_Static_Int32_byref_Char_Int32_byref_Char_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EDA RID: 3802 RVA: 0x0006B3EC File Offset: 0x000695EC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1320358, RefRangeEnd = 1320362, XrefRangeStart = 1320308, XrefRangeEnd = 1320358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int IndexOf(ref char searchSpace, char value, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &searchSpace;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpanHelpers.NativeMethodInfoPtr_IndexOf_Public_Static_Int32_byref_Char_Char_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EDB RID: 3803 RVA: 0x0006B448 File Offset: 0x00069648
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1320410, RefRangeEnd = 1320412, XrefRangeStart = 1320362, XrefRangeEnd = 1320410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int LastIndexOf(ref char searchSpace, char value, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &searchSpace;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpanHelpers.NativeMethodInfoPtr_LastIndexOf_Public_Static_Int32_byref_Char_Char_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EDC RID: 3804 RVA: 0x0006B4A4 File Offset: 0x000696A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1320412, XrefRangeEnd = 1320430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int LocateFirstFoundChar(Vector<ushort> match)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(match));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpanHelpers.NativeMethodInfoPtr_LocateFirstFoundChar_Private_Static_Int32_Vector_1_UInt16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EDD RID: 3805 RVA: 0x0006B4EC File Offset: 0x000696EC
		[CallerCount(0)]
		public unsafe static int LocateFirstFoundChar(ulong match)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref match;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpanHelpers.NativeMethodInfoPtr_LocateFirstFoundChar_Private_Static_Int32_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EDE RID: 3806 RVA: 0x0006B52C File Offset: 0x0006972C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1320430, XrefRangeEnd = 1320447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int LocateLastFoundChar(Vector<ushort> match)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(match));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpanHelpers.NativeMethodInfoPtr_LocateLastFoundChar_Private_Static_Int32_Vector_1_UInt16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EDF RID: 3807 RVA: 0x0006B574 File Offset: 0x00069774
		[CallerCount(0)]
		public unsafe static int LocateLastFoundChar(ulong match)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref match;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpanHelpers.NativeMethodInfoPtr_LocateLastFoundChar_Private_Static_Int32_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EE0 RID: 3808 RVA: 0x0006B5B4 File Offset: 0x000697B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1320511, RefRangeEnd = 1320513, XrefRangeStart = 1320447, XrefRangeEnd = 1320511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int IndexOf<T>(ref T searchSpace, T value, int length)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(searchSpace);
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				T t = value;
				intPtr2 = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref value;
			}
			ptr3 = intPtr2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(SpanHelpers.MethodInfoStoreGeneric_IndexOf_Public_Static_Int32_byref_T_T_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			searchSpace = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06000EE1 RID: 3809 RVA: 0x0006B664 File Offset: 0x00069864
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1320516, RefRangeEnd = 1320518, XrefRangeStart = 1320513, XrefRangeEnd = 1320516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int IndexOfAny<T>(ref T searchSpace, int searchSpaceLength, ref T value, int valueLength)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(searchSpace);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref searchSpaceLength;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref valueLength;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(SpanHelpers.MethodInfoStoreGeneric_IndexOfAny_Public_Static_Int32_byref_T_Int32_byref_T_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			searchSpace = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			IntPtr intPtr6 = intPtr2;
			value = ((intPtr6 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr6, false, false));
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06000EE2 RID: 3810 RVA: 0x0006B708 File Offset: 0x00069908
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1320583, RefRangeEnd = 1320586, XrefRangeStart = 1320518, XrefRangeEnd = 1320583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SequenceEqual<T>(ref T first, ref T second, int length)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(first);
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(second);
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(SpanHelpers.MethodInfoStoreGeneric_SequenceEqual_Public_Static_Boolean_byref_T_byref_T_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			first = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			IntPtr intPtr6 = intPtr2;
			second = ((intPtr6 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr6, false, false));
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06000EE3 RID: 3811 RVA: 0x0006B79C File Offset: 0x0006999C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1320596, RefRangeEnd = 1320598, XrefRangeStart = 1320586, XrefRangeEnd = 1320596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool StartsWithCultureHelper(ReadOnlySpan<char> span, ReadOnlySpan<char> value, CompareInfo compareInfo)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(span));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(compareInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpanHelpers.NativeMethodInfoPtr_StartsWithCultureHelper_Public_Static_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_CompareInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EE4 RID: 3812 RVA: 0x0006B80C File Offset: 0x00069A0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1320607, RefRangeEnd = 1320609, XrefRangeStart = 1320598, XrefRangeEnd = 1320607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool StartsWithCultureIgnoreCaseHelper(ReadOnlySpan<char> span, ReadOnlySpan<char> value, CompareInfo compareInfo)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(span));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(compareInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpanHelpers.NativeMethodInfoPtr_StartsWithCultureIgnoreCaseHelper_Public_Static_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_CompareInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EE5 RID: 3813 RVA: 0x0006B87C File Offset: 0x00069A7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1320617, RefRangeEnd = 1320618, XrefRangeStart = 1320609, XrefRangeEnd = 1320617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool StartsWithOrdinalIgnoreCaseHelper(ReadOnlySpan<char> span, ReadOnlySpan<char> value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(span));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpanHelpers.NativeMethodInfoPtr_StartsWithOrdinalIgnoreCaseHelper_Public_Static_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EE6 RID: 3814 RVA: 0x0006B8DC File Offset: 0x00069ADC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1320628, RefRangeEnd = 1320629, XrefRangeStart = 1320618, XrefRangeEnd = 1320628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool EndsWithCultureHelper(ReadOnlySpan<char> span, ReadOnlySpan<char> value, CompareInfo compareInfo)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(span));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(compareInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpanHelpers.NativeMethodInfoPtr_EndsWithCultureHelper_Public_Static_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_CompareInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EE7 RID: 3815 RVA: 0x0006B94C File Offset: 0x00069B4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1320629, XrefRangeEnd = 1320638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool EndsWithCultureIgnoreCaseHelper(ReadOnlySpan<char> span, ReadOnlySpan<char> value, CompareInfo compareInfo)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(span));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(compareInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpanHelpers.NativeMethodInfoPtr_EndsWithCultureIgnoreCaseHelper_Public_Static_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_CompareInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EE8 RID: 3816 RVA: 0x0006B9BC File Offset: 0x00069BBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1320638, XrefRangeEnd = 1320646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool EndsWithOrdinalIgnoreCaseHelper(ReadOnlySpan<char> span, ReadOnlySpan<char> value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(span));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpanHelpers.NativeMethodInfoPtr_EndsWithOrdinalIgnoreCaseHelper_Public_Static_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EE9 RID: 3817 RVA: 0x0006BA1C File Offset: 0x00069C1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1320646, RefRangeEnd = 1320647, XrefRangeStart = 1320646, XrefRangeEnd = 1320646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClearWithoutReferences(ref byte b, ulong byteLength)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &b;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpanHelpers.NativeMethodInfoPtr_ClearWithoutReferences_Public_Static_Void_byref_Byte_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EEA RID: 3818 RVA: 0x0006BA5C File Offset: 0x00069C5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1320659, RefRangeEnd = 1320660, XrefRangeStart = 1320647, XrefRangeEnd = 1320659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClearWithReferences(ref IntPtr ip, ulong pointerSizeLength)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ip;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointerSizeLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpanHelpers.NativeMethodInfoPtr_ClearWithReferences_Public_Static_Void_byref_IntPtr_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EEB RID: 3819 RVA: 0x00005953 File Offset: 0x00003B53
		public SpanHelpers(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C1B RID: 3099
		private static readonly IntPtr NativeMethodInfoPtr_IndexOfAny_Public_Static_Int32_byref_Byte_Int32_byref_Byte_Int32_0;

		// Token: 0x04000C1C RID: 3100
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Static_Int32_byref_Byte_Byte_Int32_0;

		// Token: 0x04000C1D RID: 3101
		private static readonly IntPtr NativeMethodInfoPtr_SequenceEqual_Public_Static_Boolean_byref_Byte_byref_Byte_UInt64_0;

		// Token: 0x04000C1E RID: 3102
		private static readonly IntPtr NativeMethodInfoPtr_SequenceCompareTo_Public_Static_Int32_byref_Char_Int32_byref_Char_Int32_0;

		// Token: 0x04000C1F RID: 3103
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Static_Int32_byref_Char_Char_Int32_0;

		// Token: 0x04000C20 RID: 3104
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOf_Public_Static_Int32_byref_Char_Char_Int32_0;

		// Token: 0x04000C21 RID: 3105
		private static readonly IntPtr NativeMethodInfoPtr_LocateFirstFoundChar_Private_Static_Int32_Vector_1_UInt16_0;

		// Token: 0x04000C22 RID: 3106
		private static readonly IntPtr NativeMethodInfoPtr_LocateFirstFoundChar_Private_Static_Int32_UInt64_0;

		// Token: 0x04000C23 RID: 3107
		private static readonly IntPtr NativeMethodInfoPtr_LocateLastFoundChar_Private_Static_Int32_Vector_1_UInt16_0;

		// Token: 0x04000C24 RID: 3108
		private static readonly IntPtr NativeMethodInfoPtr_LocateLastFoundChar_Private_Static_Int32_UInt64_0;

		// Token: 0x04000C25 RID: 3109
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Static_Int32_byref_T_T_Int32_0;

		// Token: 0x04000C26 RID: 3110
		private static readonly IntPtr NativeMethodInfoPtr_IndexOfAny_Public_Static_Int32_byref_T_Int32_byref_T_Int32_0;

		// Token: 0x04000C27 RID: 3111
		private static readonly IntPtr NativeMethodInfoPtr_SequenceEqual_Public_Static_Boolean_byref_T_byref_T_Int32_0;

		// Token: 0x04000C28 RID: 3112
		private static readonly IntPtr NativeMethodInfoPtr_StartsWithCultureHelper_Public_Static_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_CompareInfo_0;

		// Token: 0x04000C29 RID: 3113
		private static readonly IntPtr NativeMethodInfoPtr_StartsWithCultureIgnoreCaseHelper_Public_Static_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_CompareInfo_0;

		// Token: 0x04000C2A RID: 3114
		private static readonly IntPtr NativeMethodInfoPtr_StartsWithOrdinalIgnoreCaseHelper_Public_Static_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_0;

		// Token: 0x04000C2B RID: 3115
		private static readonly IntPtr NativeMethodInfoPtr_EndsWithCultureHelper_Public_Static_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_CompareInfo_0;

		// Token: 0x04000C2C RID: 3116
		private static readonly IntPtr NativeMethodInfoPtr_EndsWithCultureIgnoreCaseHelper_Public_Static_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_CompareInfo_0;

		// Token: 0x04000C2D RID: 3117
		private static readonly IntPtr NativeMethodInfoPtr_EndsWithOrdinalIgnoreCaseHelper_Public_Static_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_0;

		// Token: 0x04000C2E RID: 3118
		private static readonly IntPtr NativeMethodInfoPtr_ClearWithoutReferences_Public_Static_Void_byref_Byte_UInt64_0;

		// Token: 0x04000C2F RID: 3119
		private static readonly IntPtr NativeMethodInfoPtr_ClearWithReferences_Public_Static_Void_byref_IntPtr_UInt64_0;

		// Token: 0x0200059E RID: 1438
		private sealed class MethodInfoStoreGeneric_IndexOf_Public_Static_Int32_byref_T_T_Int32_0<T>
		{
			// Token: 0x0400472A RID: 18218
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SpanHelpers.NativeMethodInfoPtr_IndexOf_Public_Static_Int32_byref_T_T_Int32_0, Il2CppClassPointerStore<SpanHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200059F RID: 1439
		private sealed class MethodInfoStoreGeneric_IndexOfAny_Public_Static_Int32_byref_T_Int32_byref_T_Int32_0<T>
		{
			// Token: 0x0400472B RID: 18219
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SpanHelpers.NativeMethodInfoPtr_IndexOfAny_Public_Static_Int32_byref_T_Int32_byref_T_Int32_0, Il2CppClassPointerStore<SpanHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020005A0 RID: 1440
		private sealed class MethodInfoStoreGeneric_SequenceEqual_Public_Static_Boolean_byref_T_byref_T_Int32_0<T>
		{
			// Token: 0x0400472C RID: 18220
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SpanHelpers.NativeMethodInfoPtr_SequenceEqual_Public_Static_Boolean_byref_T_byref_T_Int32_0, Il2CppClassPointerStore<SpanHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
