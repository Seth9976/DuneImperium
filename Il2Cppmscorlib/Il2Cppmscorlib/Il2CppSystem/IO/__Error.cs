using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.IO
{
	// Token: 0x0200053F RID: 1343
	public static class __Error : Object
	{
		// Token: 0x0600524C RID: 21068 RVA: 0x0017F72C File Offset: 0x0017D92C
		// Note: this type is marked as 'beforefieldinit'.
		static __Error()
		{
			Il2CppClassPointerStore<__Error>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "__Error");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__Error>.NativeClassPtr);
			__Error.NativeMethodInfoPtr_EndOfFile_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__Error>.NativeClassPtr, 100675916);
			__Error.NativeMethodInfoPtr_FileNotOpen_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__Error>.NativeClassPtr, 100675917);
			__Error.NativeMethodInfoPtr_ReaderClosed_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__Error>.NativeClassPtr, 100675918);
			__Error.NativeMethodInfoPtr_GetDisplayablePath_Internal_Static_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__Error>.NativeClassPtr, 100675919);
			__Error.NativeMethodInfoPtr_WinIOError_Internal_Static_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__Error>.NativeClassPtr, 100675920);
			__Error.NativeMethodInfoPtr_WriterClosed_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__Error>.NativeClassPtr, 100675921);
		}

		// Token: 0x0600524D RID: 21069 RVA: 0x0017F7D4 File Offset: 0x0017D9D4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1431885, RefRangeEnd = 1431888, XrefRangeStart = 1431878, XrefRangeEnd = 1431885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EndOfFile()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__Error.NativeMethodInfoPtr_EndOfFile_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600524E RID: 21070 RVA: 0x0017F7FC File Offset: 0x0017D9FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1431895, RefRangeEnd = 1431897, XrefRangeStart = 1431888, XrefRangeEnd = 1431895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FileNotOpen()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__Error.NativeMethodInfoPtr_FileNotOpen_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600524F RID: 21071 RVA: 0x0017F824 File Offset: 0x0017DA24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1431897, XrefRangeEnd = 1431904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReaderClosed()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__Error.NativeMethodInfoPtr_ReaderClosed_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005250 RID: 21072 RVA: 0x0017F84C File Offset: 0x0017DA4C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1431923, RefRangeEnd = 1431925, XrefRangeStart = 1431904, XrefRangeEnd = 1431923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetDisplayablePath(string path, bool isInvalidPath)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isInvalidPath;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__Error.NativeMethodInfoPtr_GetDisplayablePath_Internal_Static_String_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005251 RID: 21073 RVA: 0x0017F898 File Offset: 0x0017DA98
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1432070, RefRangeEnd = 1432073, XrefRangeStart = 1431925, XrefRangeEnd = 1432070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WinIOError(int errorCode, string maybeFullPath)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref errorCode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(maybeFullPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__Error.NativeMethodInfoPtr_WinIOError_Internal_Static_Void_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005252 RID: 21074 RVA: 0x0017F8DC File Offset: 0x0017DADC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1432080, RefRangeEnd = 1432082, XrefRangeStart = 1432073, XrefRangeEnd = 1432080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriterClosed()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__Error.NativeMethodInfoPtr_WriterClosed_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005253 RID: 21075 RVA: 0x0001D364 File Offset: 0x0001B564
		public __Error(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04004341 RID: 17217
		private static readonly IntPtr NativeMethodInfoPtr_EndOfFile_Internal_Static_Void_0;

		// Token: 0x04004342 RID: 17218
		private static readonly IntPtr NativeMethodInfoPtr_FileNotOpen_Internal_Static_Void_0;

		// Token: 0x04004343 RID: 17219
		private static readonly IntPtr NativeMethodInfoPtr_ReaderClosed_Internal_Static_Void_0;

		// Token: 0x04004344 RID: 17220
		private static readonly IntPtr NativeMethodInfoPtr_GetDisplayablePath_Internal_Static_String_String_Boolean_0;

		// Token: 0x04004345 RID: 17221
		private static readonly IntPtr NativeMethodInfoPtr_WinIOError_Internal_Static_Void_Int32_String_0;

		// Token: 0x04004346 RID: 17222
		private static readonly IntPtr NativeMethodInfoPtr_WriterClosed_Internal_Static_Void_0;
	}
}
