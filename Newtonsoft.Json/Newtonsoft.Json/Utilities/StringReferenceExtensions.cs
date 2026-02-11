using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200006A RID: 106
	public static class StringReferenceExtensions : Object
	{
		// Token: 0x06000945 RID: 2373 RVA: 0x0003D478 File Offset: 0x0003B678
		// Note: this type is marked as 'beforefieldinit'.
		static StringReferenceExtensions()
		{
			Il2CppClassPointerStore<StringReferenceExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Utilities", "StringReferenceExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringReferenceExtensions>.NativeClassPtr);
			StringReferenceExtensions.NativeMethodInfoPtr_IndexOf_Public_Static_Int32_StringReference_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringReferenceExtensions>.NativeClassPtr, 100665086);
			StringReferenceExtensions.NativeMethodInfoPtr_StartsWith_Public_Static_Boolean_StringReference_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringReferenceExtensions>.NativeClassPtr, 100665087);
			StringReferenceExtensions.NativeMethodInfoPtr_EndsWith_Public_Static_Boolean_StringReference_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringReferenceExtensions>.NativeClassPtr, 100665088);
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x0003D4E4 File Offset: 0x0003B6E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 745952, RefRangeEnd = 745954, XrefRangeStart = 745948, XrefRangeEnd = 745952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int IndexOf(this StringReference s, char c, int startIndex, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(s));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringReferenceExtensions.NativeMethodInfoPtr_IndexOf_Public_Static_Int32_StringReference_Char_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x0003D554 File Offset: 0x0003B754
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 745956, RefRangeEnd = 745958, XrefRangeStart = 745954, XrefRangeEnd = 745956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool StartsWith(this StringReference s, string text)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(s));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringReferenceExtensions.NativeMethodInfoPtr_StartsWith_Public_Static_Boolean_StringReference_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000948 RID: 2376 RVA: 0x0003D5AC File Offset: 0x0003B7AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 745960, RefRangeEnd = 745962, XrefRangeStart = 745958, XrefRangeEnd = 745960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool EndsWith(this StringReference s, string text)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(s));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringReferenceExtensions.NativeMethodInfoPtr_EndsWith_Public_Static_Boolean_StringReference_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x00004DDC File Offset: 0x00002FDC
		public StringReferenceExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040007CE RID: 1998
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Static_Int32_StringReference_Char_Int32_Int32_0;

		// Token: 0x040007CF RID: 1999
		private static readonly IntPtr NativeMethodInfoPtr_StartsWith_Public_Static_Boolean_StringReference_String_0;

		// Token: 0x040007D0 RID: 2000
		private static readonly IntPtr NativeMethodInfoPtr_EndsWith_Public_Static_Boolean_StringReference_String_0;
	}
}
