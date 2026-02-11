using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000058 RID: 88
	public static class StringExtensions : Object
	{
		// Token: 0x06000501 RID: 1281 RVA: 0x0002F428 File Offset: 0x0002D628
		// Note: this type is marked as 'beforefieldinit'.
		static StringExtensions()
		{
			Il2CppClassPointerStore<StringExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System", "StringExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringExtensions>.NativeClassPtr);
			StringExtensions.NativeMethodInfoPtr_SubstringTrim_Internal_Static_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringExtensions>.NativeClassPtr, 100664180);
			StringExtensions.NativeMethodInfoPtr_SubstringTrim_Internal_Static_String_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringExtensions>.NativeClassPtr, 100664181);
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x0002F480 File Offset: 0x0002D680
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 433685, RefRangeEnd = 433686, XrefRangeStart = 433671, XrefRangeEnd = 433685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string SubstringTrim(this string value, int startIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringExtensions.NativeMethodInfoPtr_SubstringTrim_Internal_Static_String_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x0002F4CC File Offset: 0x0002D6CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 433697, RefRangeEnd = 433699, XrefRangeStart = 433686, XrefRangeEnd = 433697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string SubstringTrim(this string value, int startIndex, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringExtensions.NativeMethodInfoPtr_SubstringTrim_Internal_Static_String_String_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x00003A5C File Offset: 0x00001C5C
		public StringExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000427 RID: 1063
		private static readonly IntPtr NativeMethodInfoPtr_SubstringTrim_Internal_Static_String_String_Int32_0;

		// Token: 0x04000428 RID: 1064
		private static readonly IntPtr NativeMethodInfoPtr_SubstringTrim_Internal_Static_String_String_Int32_Int32_0;
	}
}
