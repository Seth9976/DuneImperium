using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Il2CppMono.Options
{
	// Token: 0x02000008 RID: 8
	public static class StringCoda : Object
	{
		// Token: 0x06000047 RID: 71 RVA: 0x00005748 File Offset: 0x00003948
		// Note: this type is marked as 'beforefieldinit'.
		static StringCoda()
		{
			Il2CppClassPointerStore<StringCoda>.NativeClassPtr = IL2CPP.GetIl2CppClass("platform.dll", "Mono.Options", "StringCoda");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringCoda>.NativeClassPtr);
			StringCoda.NativeMethodInfoPtr_WrappedLines_Public_Static_IEnumerable_1_String_String_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringCoda>.NativeClassPtr, 100663343);
			StringCoda.NativeMethodInfoPtr_WrappedLines_Public_Static_IEnumerable_1_String_String_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringCoda>.NativeClassPtr, 100663344);
			StringCoda.NativeMethodInfoPtr_CreateWrappedLinesIterator_Private_Static_IEnumerable_1_String_String_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringCoda>.NativeClassPtr, 100663345);
			StringCoda.NativeMethodInfoPtr_GetNextWidth_Private_Static_Int32_IEnumerator_1_Int32_Int32_byref_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringCoda>.NativeClassPtr, 100663346);
			StringCoda.NativeMethodInfoPtr_IsEolChar_Private_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringCoda>.NativeClassPtr, 100663347);
			StringCoda.NativeMethodInfoPtr_GetLineEnd_Private_Static_Int32_Int32_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringCoda>.NativeClassPtr, 100663348);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x000057F0 File Offset: 0x000039F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1165854, XrefRangeEnd = 1165861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<string> WrappedLines(string self, [Optional] Il2CppStructArray<int> widths)
		{
			if (widths == null)
			{
				widths = new Il2CppStructArray<int>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(self);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(widths);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringCoda.NativeMethodInfoPtr_WrappedLines_Public_Static_IEnumerable_1_String_String_Il2CppStructArray_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00005854 File Offset: 0x00003A54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<string> WrappedLines(string self, IEnumerable<int> widths)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(self);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(widths);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringCoda.NativeMethodInfoPtr_WrappedLines_Public_Static_IEnumerable_1_String_String_IEnumerable_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000058AC File Offset: 0x00003AAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1165861, XrefRangeEnd = 1165868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<string> CreateWrappedLinesIterator(string self, IEnumerable<int> widths)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(self);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(widths);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringCoda.NativeMethodInfoPtr_CreateWrappedLinesIterator_Private_Static_IEnumerable_1_String_String_IEnumerable_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00005904 File Offset: 0x00003B04
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1165885, RefRangeEnd = 1165887, XrefRangeStart = 1165868, XrefRangeEnd = 1165885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetNextWidth(IEnumerator<int> ewidths, int curWidth, ref Nullable<bool> eValid)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ewidths);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref curWidth;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(eValid);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringCoda.NativeMethodInfoPtr_GetNextWidth_Private_Static_Int32_IEnumerator_1_Int32_Int32_byref_Nullable_1_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00005968 File Offset: 0x00003B68
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1165891, RefRangeEnd = 1165894, XrefRangeStart = 1165887, XrefRangeEnd = 1165891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsEolChar(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringCoda.NativeMethodInfoPtr_IsEolChar_Private_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x000059A8 File Offset: 0x00003BA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1165894, XrefRangeEnd = 1165901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetLineEnd(int start, int length, string description)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(description);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringCoda.NativeMethodInfoPtr_GetLineEnd_Private_Static_Int32_Int32_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002249 File Offset: 0x00000449
		public static IEnumerable<string> WrappedLines(string self, params int[] widths)
		{
			return StringCoda.WrappedLines(self, new Il2CppStructArray<int>(widths));
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002257 File Offset: 0x00000457
		public StringCoda(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeMethodInfoPtr_WrappedLines_Public_Static_IEnumerable_1_String_String_Il2CppStructArray_1_Int32_0;

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeMethodInfoPtr_WrappedLines_Public_Static_IEnumerable_1_String_String_IEnumerable_1_Int32_0;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeMethodInfoPtr_CreateWrappedLinesIterator_Private_Static_IEnumerable_1_String_String_IEnumerable_1_Int32_0;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeMethodInfoPtr_GetNextWidth_Private_Static_Int32_IEnumerator_1_Int32_Int32_byref_Nullable_1_Boolean_0;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeMethodInfoPtr_IsEolChar_Private_Static_Boolean_Char_0;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeMethodInfoPtr_GetLineEnd_Private_Static_Int32_Int32_Int32_String_0;

		// Token: 0x0200005E RID: 94
		[ObfuscatedName("Mono.Options.StringCoda+<CreateWrappedLinesIterator>d__2")]
		public sealed class _CreateWrappedLinesIterator_d__2 : Object
		{
			// Token: 0x060003C2 RID: 962 RVA: 0x00011924 File Offset: 0x0000FB24
			// Note: this type is marked as 'beforefieldinit'.
			static _CreateWrappedLinesIterator_d__2()
			{
				Il2CppClassPointerStore<StringCoda._CreateWrappedLinesIterator_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StringCoda>.NativeClassPtr, "<CreateWrappedLinesIterator>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringCoda._CreateWrappedLinesIterator_d__2>.NativeClassPtr);
				StringCoda._CreateWrappedLinesIterator_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringCoda._CreateWrappedLinesIterator_d__2>.NativeClassPtr, "<>1__state");
				StringCoda._CreateWrappedLinesIterator_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringCoda._CreateWrappedLinesIterator_d__2>.NativeClassPtr, "<>2__current");
				StringCoda._CreateWrappedLinesIterator_d__2.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringCoda._CreateWrappedLinesIterator_d__2>.NativeClassPtr, "<>l__initialThreadId");
				StringCoda._CreateWrappedLinesIterator_d__2.NativeFieldInfoPtr_self = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringCoda._CreateWrappedLinesIterator_d__2>.NativeClassPtr, "self");
				StringCoda._CreateWrappedLinesIterator_d__2.NativeFieldInfoPtr___3__self = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringCoda._CreateWrappedLinesIterator_d__2>.NativeClassPtr, "<>3__self");
				StringCoda._CreateWrappedLinesIterator_d__2.NativeFieldInfoPtr_widths = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringCoda._CreateWrappedLinesIterator_d__2>.NativeClassPtr, "widths");
				StringCoda._CreateWrappedLinesIterator_d__2.NativeFieldInfoPtr___3__widths = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringCoda._CreateWrappedLinesIterator_d__2>.NativeClassPtr, "<>3__widths");
				StringCoda._CreateWrappedLinesIterator_d__2.NativeFieldInfoPtr__ewidths_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringCoda._CreateWrappedLinesIterator_d__2>.NativeClassPtr, "<ewidths>5__2");
				StringCoda._CreateWrappedLinesIterator_d__2.NativeFieldInfoPtr__hw_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringCoda._CreateWrappedLinesIterator_d__2>.NativeClassPtr, "<hw>5__3");
				StringCoda._CreateWrappedLinesIterator_d__2.NativeFieldInfoPtr__width_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringCoda._CreateWrappedLinesIterator_d__2>.NativeClassPtr, "<width>5__4");
				StringCoda._CreateWrappedLinesIterator_d__2.NativeFieldInfoPtr__end_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringCoda._CreateWrappedLinesIterator_d__2>.NativeClassPtr, "<end>5__5");
				StringCoda._CreateWrappedLinesIterator_d__2.NativeFieldInfoPtr__c_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringCoda._CreateWrappedLinesIterator_d__2>.NativeClassPtr, "<c>5__6");
				StringCoda._CreateWrappedLinesIterator_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringCoda._CreateWrappedLinesIterator_d__2>.NativeClassPtr, 100663349);
				StringCoda._CreateWrappedLinesIterator_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringCoda._CreateWrappedLinesIterator_d__2>.NativeClassPtr, 100663350);
				StringCoda._CreateWrappedLinesIterator_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringCoda._CreateWrappedLinesIterator_d__2>.NativeClassPtr, 100663351);
				StringCoda._CreateWrappedLinesIterator_d__2.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringCoda._CreateWrappedLinesIterator_d__2>.NativeClassPtr, 100663352);
				StringCoda._CreateWrappedLinesIterator_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_String__get_Current_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringCoda._CreateWrappedLinesIterator_d__2>.NativeClassPtr, 100663353);
				StringCoda._CreateWrappedLinesIterator_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringCoda._CreateWrappedLinesIterator_d__2>.NativeClassPtr, 100663354);
				StringCoda._CreateWrappedLinesIterator_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringCoda._CreateWrappedLinesIterator_d__2>.NativeClassPtr, 100663355);
				StringCoda._CreateWrappedLinesIterator_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_String__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringCoda._CreateWrappedLinesIterator_d__2>.NativeClassPtr, 100663356);
				StringCoda._CreateWrappedLinesIterator_d__2.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringCoda._CreateWrappedLinesIterator_d__2>.NativeClassPtr, 100663357);
			}

			// Token: 0x060003C3 RID: 963 RVA: 0x00011AF4 File Offset: 0x0000FCF4
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _CreateWrappedLinesIterator_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringCoda._CreateWrappedLinesIterator_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringCoda._CreateWrappedLinesIterator_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060003C4 RID: 964 RVA: 0x00011B3C File Offset: 0x0000FD3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1165786, XrefRangeEnd = 1165791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringCoda._CreateWrappedLinesIterator_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003C5 RID: 965 RVA: 0x00011B70 File Offset: 0x0000FD70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1165791, XrefRangeEnd = 1165836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringCoda._CreateWrappedLinesIterator_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060003C6 RID: 966 RVA: 0x00011BAC File Offset: 0x0000FDAC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1165839, RefRangeEnd = 1165840, XrefRangeStart = 1165836, XrefRangeEnd = 1165839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringCoda._CreateWrappedLinesIterator_d__2.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000103 RID: 259
			// (get) Token: 0x060003C7 RID: 967 RVA: 0x00011BE0 File Offset: 0x0000FDE0
			public unsafe string System.Collections.Generic.IEnumerator<System.String>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringCoda._CreateWrappedLinesIterator_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_String__get_Current_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060003C8 RID: 968 RVA: 0x00011C18 File Offset: 0x0000FE18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1165840, XrefRangeEnd = 1165845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringCoda._CreateWrappedLinesIterator_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000104 RID: 260
			// (get) Token: 0x060003C9 RID: 969 RVA: 0x00011C4C File Offset: 0x0000FE4C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringCoda._CreateWrappedLinesIterator_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060003CA RID: 970 RVA: 0x00011C8C File Offset: 0x0000FE8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1165845, XrefRangeEnd = 1165854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<string> System_Collections_Generic_IEnumerable_System_String__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringCoda._CreateWrappedLinesIterator_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_String__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<string>>(intPtr3) : null;
			}

			// Token: 0x060003CB RID: 971 RVA: 0x00011CCC File Offset: 0x0000FECC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringCoda._CreateWrappedLinesIterator_d__2.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060003CC RID: 972 RVA: 0x00003D2D File Offset: 0x00001F2D
			public _CreateWrappedLinesIterator_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000F7 RID: 247
			// (get) Token: 0x060003CD RID: 973 RVA: 0x00011D0C File Offset: 0x0000FF0C
			// (set) Token: 0x060003CE RID: 974 RVA: 0x00003D36 File Offset: 0x00001F36
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringCoda._CreateWrappedLinesIterator_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringCoda._CreateWrappedLinesIterator_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170000F8 RID: 248
			// (get) Token: 0x060003CF RID: 975 RVA: 0x00011D34 File Offset: 0x0000FF34
			// (set) Token: 0x060003D0 RID: 976 RVA: 0x00003D51 File Offset: 0x00001F51
			public unsafe string __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringCoda._CreateWrappedLinesIterator_d__2.NativeFieldInfoPtr___2__current);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringCoda._CreateWrappedLinesIterator_d__2.NativeFieldInfoPtr___2__current), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170000F9 RID: 249
			// (get) Token: 0x060003D1 RID: 977 RVA: 0x00011D5C File Offset: 0x0000FF5C
			// (set) Token: 0x060003D2 RID: 978 RVA: 0x00003D70 File Offset: 0x00001F70
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringCoda._CreateWrappedLinesIterator_d__2.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringCoda._CreateWrappedLinesIterator_d__2.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170000FA RID: 250
			// (get) Token: 0x060003D3 RID: 979 RVA: 0x00011D84 File Offset: 0x0000FF84
			// (set) Token: 0x060003D4 RID: 980 RVA: 0x00003D8B File Offset: 0x00001F8B
			public unsafe string self
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringCoda._CreateWrappedLinesIterator_d__2.NativeFieldInfoPtr_self);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringCoda._CreateWrappedLinesIterator_d__2.NativeFieldInfoPtr_self), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170000FB RID: 251
			// (get) Token: 0x060003D5 RID: 981 RVA: 0x00011DAC File Offset: 0x0000FFAC
			// (set) Token: 0x060003D6 RID: 982 RVA: 0x00003DAA File Offset: 0x00001FAA
			public unsafe string __3__self
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringCoda._CreateWrappedLinesIterator_d__2.NativeFieldInfoPtr___3__self);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringCoda._CreateWrappedLinesIterator_d__2.NativeFieldInfoPtr___3__self), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170000FC RID: 252
			// (get) Token: 0x060003D7 RID: 983 RVA: 0x00011DD4 File Offset: 0x0000FFD4
			// (set) Token: 0x060003D8 RID: 984 RVA: 0x00003DC9 File Offset: 0x00001FC9
			public unsafe IEnumerable<int> widths
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringCoda._CreateWrappedLinesIterator_d__2.NativeFieldInfoPtr_widths);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringCoda._CreateWrappedLinesIterator_d__2.NativeFieldInfoPtr_widths), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000FD RID: 253
			// (get) Token: 0x060003D9 RID: 985 RVA: 0x00011E04 File Offset: 0x00010004
			// (set) Token: 0x060003DA RID: 986 RVA: 0x00003DE8 File Offset: 0x00001FE8
			public unsafe IEnumerable<int> __3__widths
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringCoda._CreateWrappedLinesIterator_d__2.NativeFieldInfoPtr___3__widths);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringCoda._CreateWrappedLinesIterator_d__2.NativeFieldInfoPtr___3__widths), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000FE RID: 254
			// (get) Token: 0x060003DB RID: 987 RVA: 0x00011E34 File Offset: 0x00010034
			// (set) Token: 0x060003DC RID: 988 RVA: 0x00003E07 File Offset: 0x00002007
			public unsafe IEnumerator<int> _ewidths_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringCoda._CreateWrappedLinesIterator_d__2.NativeFieldInfoPtr__ewidths_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringCoda._CreateWrappedLinesIterator_d__2.NativeFieldInfoPtr__ewidths_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000FF RID: 255
			// (get) Token: 0x060003DD RID: 989 RVA: 0x00011E64 File Offset: 0x00010064
			// (set) Token: 0x060003DE RID: 990 RVA: 0x00003E26 File Offset: 0x00002026
			public Nullable<bool> _hw_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringCoda._CreateWrappedLinesIterator_d__2.NativeFieldInfoPtr__hw_5__3);
					return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringCoda._CreateWrappedLinesIterator_d__2.NativeFieldInfoPtr__hw_5__3), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000100 RID: 256
			// (get) Token: 0x060003DF RID: 991 RVA: 0x00011E94 File Offset: 0x00010094
			// (set) Token: 0x060003E0 RID: 992 RVA: 0x00003E54 File Offset: 0x00002054
			public unsafe int _width_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringCoda._CreateWrappedLinesIterator_d__2.NativeFieldInfoPtr__width_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringCoda._CreateWrappedLinesIterator_d__2.NativeFieldInfoPtr__width_5__4)) = value;
				}
			}

			// Token: 0x17000101 RID: 257
			// (get) Token: 0x060003E1 RID: 993 RVA: 0x00011EBC File Offset: 0x000100BC
			// (set) Token: 0x060003E2 RID: 994 RVA: 0x00003E6F File Offset: 0x0000206F
			public unsafe int _end_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringCoda._CreateWrappedLinesIterator_d__2.NativeFieldInfoPtr__end_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringCoda._CreateWrappedLinesIterator_d__2.NativeFieldInfoPtr__end_5__5)) = value;
				}
			}

			// Token: 0x17000102 RID: 258
			// (get) Token: 0x060003E3 RID: 995 RVA: 0x00011EE4 File Offset: 0x000100E4
			// (set) Token: 0x060003E4 RID: 996 RVA: 0x00003E8A File Offset: 0x0000208A
			public unsafe char _c_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringCoda._CreateWrappedLinesIterator_d__2.NativeFieldInfoPtr__c_5__6);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringCoda._CreateWrappedLinesIterator_d__2.NativeFieldInfoPtr__c_5__6)) = value;
				}
			}

			// Token: 0x04000261 RID: 609
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000262 RID: 610
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000263 RID: 611
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04000264 RID: 612
			private static readonly IntPtr NativeFieldInfoPtr_self;

			// Token: 0x04000265 RID: 613
			private static readonly IntPtr NativeFieldInfoPtr___3__self;

			// Token: 0x04000266 RID: 614
			private static readonly IntPtr NativeFieldInfoPtr_widths;

			// Token: 0x04000267 RID: 615
			private static readonly IntPtr NativeFieldInfoPtr___3__widths;

			// Token: 0x04000268 RID: 616
			private static readonly IntPtr NativeFieldInfoPtr__ewidths_5__2;

			// Token: 0x04000269 RID: 617
			private static readonly IntPtr NativeFieldInfoPtr__hw_5__3;

			// Token: 0x0400026A RID: 618
			private static readonly IntPtr NativeFieldInfoPtr__width_5__4;

			// Token: 0x0400026B RID: 619
			private static readonly IntPtr NativeFieldInfoPtr__end_5__5;

			// Token: 0x0400026C RID: 620
			private static readonly IntPtr NativeFieldInfoPtr__c_5__6;

			// Token: 0x0400026D RID: 621
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400026E RID: 622
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400026F RID: 623
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000270 RID: 624
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04000271 RID: 625
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_String__get_Current_Private_Virtual_Final_New_get_String_0;

			// Token: 0x04000272 RID: 626
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000273 RID: 627
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000274 RID: 628
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_String__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_String_0;

			// Token: 0x04000275 RID: 629
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
