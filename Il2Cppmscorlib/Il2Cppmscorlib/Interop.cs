using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMicrosoft.Win32;
using Il2CppMicrosoft.Win32.SafeHandles;
using Il2CppSystem;
using Il2CppSystem.IO;
using Il2CppSystem.Text;

// Token: 0x02000002 RID: 2
public static class Interop : Object
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
	// Note: this type is marked as 'beforefieldinit'.
	static Interop()
	{
		Il2CppClassPointerStore<Interop>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "", "Interop");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Interop>.NativeClassPtr);
		Interop.NativeMethodInfoPtr_GetRandomBytes_Internal_Static_Void_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interop>.NativeClassPtr, 100663297);
	}

	// Token: 0x06000002 RID: 2 RVA: 0x000255D0 File Offset: 0x000237D0
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1275687, RefRangeEnd = 1275690, XrefRangeStart = 1275684, XrefRangeEnd = 1275687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetRandomBytes(byte* buffer, int length)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = buffer;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interop.NativeMethodInfoPtr_GetRandomBytes_Internal_Static_Void_ptr_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000003 RID: 3 RVA: 0x00002089 File Offset: 0x00000289
	public Interop(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000001 RID: 1
	private static readonly IntPtr NativeMethodInfoPtr_GetRandomBytes_Internal_Static_Void_ptr_Byte_Int32_0;

	// Token: 0x02000557 RID: 1367
	public static class Kernel32 : Object
	{
		// Token: 0x06005548 RID: 21832 RVA: 0x00189CCC File Offset: 0x00187ECC
		// Note: this type is marked as 'beforefieldinit'.
		static Kernel32()
		{
			Il2CppClassPointerStore<Interop.Kernel32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Interop>.NativeClassPtr, "Kernel32");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Interop.Kernel32>.NativeClassPtr);
			Interop.Kernel32.NativeFieldInfoPtr_useUWPFallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.Kernel32>.NativeClassPtr, "useUWPFallback");
			Interop.Kernel32.NativeMethodInfoPtr_CopyFileUWP_Internal_Static_Int32_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interop.Kernel32>.NativeClassPtr, 100663298);
			Interop.Kernel32.NativeMethodInfoPtr_CopyFile_Internal_Static_Int32_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interop.Kernel32>.NativeClassPtr, 100663299);
			Interop.Kernel32.NativeMethodInfoPtr_DeleteVolumeMountPointPrivate_Internal_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interop.Kernel32>.NativeClassPtr, 100663300);
			Interop.Kernel32.NativeMethodInfoPtr_DeleteVolumeMountPoint_Internal_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interop.Kernel32>.NativeClassPtr, 100663301);
			Interop.Kernel32.NativeMethodInfoPtr_FreeLibrary_Internal_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interop.Kernel32>.NativeClassPtr, 100663302);
			Interop.Kernel32.NativeMethodInfoPtr_LoadLibraryEx_Internal_Static_SafeLibraryHandle_String_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interop.Kernel32>.NativeClassPtr, 100663303);
			Interop.Kernel32.NativeMethodInfoPtr_GetFileMUIPath_Internal_Static_Boolean_UInt32_String_StringBuilder_byref_Int32_StringBuilder_byref_Int32_byref_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interop.Kernel32>.NativeClassPtr, 100663304);
			Interop.Kernel32.NativeMethodInfoPtr_GetDynamicTimeZoneInformation_Internal_Static_UInt32_byref_TIME_DYNAMIC_ZONE_INFORMATION_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interop.Kernel32>.NativeClassPtr, 100663305);
			Interop.Kernel32.NativeMethodInfoPtr_GetTimeZoneInformation_Internal_Static_UInt32_byref_TIME_ZONE_INFORMATION_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interop.Kernel32>.NativeClassPtr, 100663306);
			Interop.Kernel32.NativeMethodInfoPtr_CloseHandle_Internal_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interop.Kernel32>.NativeClassPtr, 100663307);
			Interop.Kernel32.NativeMethodInfoPtr_CopyFile2_Internal_Static_Int32_String_String_byref_COPYFILE2_EXTENDED_PARAMETERS_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interop.Kernel32>.NativeClassPtr, 100663308);
			Interop.Kernel32.NativeMethodInfoPtr_CopyFileExPrivate_Private_Static_Boolean_String_String_IntPtr_IntPtr_byref_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interop.Kernel32>.NativeClassPtr, 100663309);
			Interop.Kernel32.NativeMethodInfoPtr_CopyFileEx_Internal_Static_Boolean_String_String_IntPtr_IntPtr_byref_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interop.Kernel32>.NativeClassPtr, 100663310);
			Interop.Kernel32.NativeMethodInfoPtr_CreateDirectoryPrivate_Private_Static_Boolean_String_byref_SECURITY_ATTRIBUTES_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interop.Kernel32>.NativeClassPtr, 100663311);
			Interop.Kernel32.NativeMethodInfoPtr_CreateDirectory_Internal_Static_Boolean_String_byref_SECURITY_ATTRIBUTES_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interop.Kernel32>.NativeClassPtr, 100663312);
			Interop.Kernel32.NativeMethodInfoPtr_CreateFilePrivate_Private_Static_IntPtr_String_Int32_FileShare_ptr_SECURITY_ATTRIBUTES_FileMode_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interop.Kernel32>.NativeClassPtr, 100663313);
			Interop.Kernel32.NativeMethodInfoPtr_CreateFile_Internal_Static_SafeFileHandle_String_Int32_FileShare_FileMode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interop.Kernel32>.NativeClassPtr, 100663314);
			Interop.Kernel32.NativeMethodInfoPtr_CreateFile_IntPtr_Internal_Static_IntPtr_String_Int32_FileShare_FileMode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interop.Kernel32>.NativeClassPtr, 100663315);
			Interop.Kernel32.NativeMethodInfoPtr_DeleteFilePrivate_Private_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interop.Kernel32>.NativeClassPtr, 100663316);
			Interop.Kernel32.NativeMethodInfoPtr_DeleteFile_Internal_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interop.Kernel32>.NativeClassPtr, 100663317);
			Interop.Kernel32.NativeMethodInfoPtr_FindFirstFileExPrivate_Private_Static_SafeFindHandle_String_FINDEX_INFO_LEVELS_byref_WIN32_FIND_DATA_FINDEX_SEARCH_OPS_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interop.Kernel32>.NativeClassPtr, 100663318);
			Interop.Kernel32.NativeMethodInfoPtr_FindFirstFile_Internal_Static_SafeFindHandle_String_byref_WIN32_FIND_DATA_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interop.Kernel32>.NativeClassPtr, 100663319);
			Interop.Kernel32.NativeMethodInfoPtr_FindNextFile_Internal_Static_Boolean_SafeFindHandle_byref_WIN32_FIND_DATA_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interop.Kernel32>.NativeClassPtr, 100663320);
			Interop.Kernel32.NativeMethodInfoPtr_FormatMessage_Private_Static_Int32_Int32_IntPtr_UInt32_Int32_ptr_Char_Int32_Il2CppStructArray_1_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interop.Kernel32>.NativeClassPtr, 100663321);
			Interop.Kernel32.NativeMethodInfoPtr_GetMessage_Internal_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interop.Kernel32>.NativeClassPtr, 100663322);
			Interop.Kernel32.NativeMethodInfoPtr_GetMessage_Internal_Static_String_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interop.Kernel32>.NativeClassPtr, 100663323);
			Interop.Kernel32.NativeMethodInfoPtr_TryGetErrorMessage_Private_Static_Boolean_IntPtr_Int32_Span_1_Char_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interop.Kernel32>.NativeClassPtr, 100663324);
			Interop.Kernel32.NativeMethodInfoPtr_GetFileAttributesExPrivate_Private_Static_Boolean_String_GET_FILEEX_INFO_LEVELS_byref_WIN32_FILE_ATTRIBUTE_DATA_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interop.Kernel32>.NativeClassPtr, 100663325);
			Interop.Kernel32.NativeMethodInfoPtr_GetFileAttributesEx_Internal_Static_Boolean_String_GET_FILEEX_INFO_LEVELS_byref_WIN32_FILE_ATTRIBUTE_DATA_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interop.Kernel32>.NativeClassPtr, 100663326);
			Interop.Kernel32.NativeMethodInfoPtr_GetFileInformationByHandleEx_Public_Static_Boolean_IntPtr_FILE_INFO_BY_HANDLE_CLASS_IntPtr_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interop.Kernel32>.NativeClassPtr, 100663327);
			Interop.Kernel32.NativeMethodInfoPtr_RemoveDirectoryPrivate_Private_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interop.Kernel32>.NativeClassPtr, 100663328);
			Interop.Kernel32.NativeMethodInfoPtr_RemoveDirectory_Internal_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interop.Kernel32>.NativeClassPtr, 100663329);
			Interop.Kernel32.NativeMethodInfoPtr_SetThreadErrorMode_Internal_Static_Boolean_UInt32_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interop.Kernel32>.NativeClassPtr, 100663330);
		}

		// Token: 0x06005549 RID: 21833 RVA: 0x00189FA0 File Offset: 0x001881A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275294, XrefRangeEnd = 1275303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CopyFileUWP(string src, string dst, bool failIfExists)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(src);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dst);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref failIfExists;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interop.Kernel32.NativeMethodInfoPtr_CopyFileUWP_Internal_Static_Int32_String_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600554A RID: 21834 RVA: 0x0018A004 File Offset: 0x00188204
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1275314, RefRangeEnd = 1275316, XrefRangeStart = 1275303, XrefRangeEnd = 1275314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CopyFile(string src, string dst, bool failIfExists)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(src);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dst);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref failIfExists;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interop.Kernel32.NativeMethodInfoPtr_CopyFile_Internal_Static_Int32_String_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600554B RID: 21835 RVA: 0x0018A068 File Offset: 0x00188268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275316, XrefRangeEnd = 1275319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DeleteVolumeMountPointPrivate(string mountPoint)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(mountPoint);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interop.Kernel32.NativeMethodInfoPtr_DeleteVolumeMountPointPrivate_Internal_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600554C RID: 21836 RVA: 0x0018A0AC File Offset: 0x001882AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1275326, RefRangeEnd = 1275327, XrefRangeStart = 1275319, XrefRangeEnd = 1275326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DeleteVolumeMountPoint(string mountPoint)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(mountPoint);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interop.Kernel32.NativeMethodInfoPtr_DeleteVolumeMountPoint_Internal_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600554D RID: 21837 RVA: 0x0018A0F0 File Offset: 0x001882F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1275330, RefRangeEnd = 1275331, XrefRangeStart = 1275327, XrefRangeEnd = 1275330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool FreeLibrary(IntPtr hModule)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hModule;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interop.Kernel32.NativeMethodInfoPtr_FreeLibrary_Internal_Static_Boolean_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600554E RID: 21838 RVA: 0x0018A130 File Offset: 0x00188330
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1275338, RefRangeEnd = 1275339, XrefRangeStart = 1275331, XrefRangeEnd = 1275338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SafeLibraryHandle LoadLibraryEx(string libFilename, IntPtr reserved, int flags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(libFilename);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reserved;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interop.Kernel32.NativeMethodInfoPtr_LoadLibraryEx_Internal_Static_SafeLibraryHandle_String_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SafeLibraryHandle>(intPtr3) : null;
		}

		// Token: 0x0600554F RID: 21839 RVA: 0x0018A190 File Offset: 0x00188390
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1275347, RefRangeEnd = 1275348, XrefRangeStart = 1275339, XrefRangeEnd = 1275347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetFileMUIPath(uint flags, string filePath, [Out] StringBuilder language, ref int languageLength, [Out] StringBuilder fileMuiPath, ref int fileMuiPathLength, ref long enumerator)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(filePath);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &languageLength;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &fileMuiPathLength;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &enumerator;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(Interop.Kernel32.NativeMethodInfoPtr_GetFileMUIPath_Internal_Static_Boolean_UInt32_String_StringBuilder_byref_Int32_StringBuilder_byref_Int32_byref_Int64_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			*language = ((intPtr5 == 0) ? null : new StringBuilder(intPtr5));
			IntPtr intPtr6 = intPtr2;
			*fileMuiPath = ((intPtr6 == 0) ? null : new StringBuilder(intPtr6));
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06005550 RID: 21840 RVA: 0x0018A254 File Offset: 0x00188454
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1275351, RefRangeEnd = 1275352, XrefRangeStart = 1275348, XrefRangeEnd = 1275351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetDynamicTimeZoneInformation(out Interop.Kernel32.TIME_DYNAMIC_ZONE_INFORMATION pTimeZoneInformation)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pTimeZoneInformation;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interop.Kernel32.NativeMethodInfoPtr_GetDynamicTimeZoneInformation_Internal_Static_UInt32_byref_TIME_DYNAMIC_ZONE_INFORMATION_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06005551 RID: 21841 RVA: 0x0018A294 File Offset: 0x00188494
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1275355, RefRangeEnd = 1275358, XrefRangeStart = 1275352, XrefRangeEnd = 1275355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetTimeZoneInformation(out Interop.Kernel32.TIME_ZONE_INFORMATION lpTimeZoneInformation)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &lpTimeZoneInformation;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interop.Kernel32.NativeMethodInfoPtr_GetTimeZoneInformation_Internal_Static_UInt32_byref_TIME_ZONE_INFORMATION_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06005552 RID: 21842 RVA: 0x0018A2D4 File Offset: 0x001884D4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1275361, RefRangeEnd = 1275365, XrefRangeStart = 1275358, XrefRangeEnd = 1275361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CloseHandle(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interop.Kernel32.NativeMethodInfoPtr_CloseHandle_Internal_Static_Boolean_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06005553 RID: 21843 RVA: 0x0018A314 File Offset: 0x00188514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275365, XrefRangeEnd = 1275367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CopyFile2(string pwszExistingFileName, string pwszNewFileName, ref Interop.Kernel32.COPYFILE2_EXTENDED_PARAMETERS pExtendedParameters)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pwszExistingFileName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pwszNewFileName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pExtendedParameters;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interop.Kernel32.NativeMethodInfoPtr_CopyFile2_Internal_Static_Int32_String_String_byref_COPYFILE2_EXTENDED_PARAMETERS_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005554 RID: 21844 RVA: 0x0018A378 File Offset: 0x00188578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275367, XrefRangeEnd = 1275370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CopyFileExPrivate(string src, string dst, IntPtr progressRoutine, IntPtr progressData, ref int cancel, int flags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(src);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dst);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref progressRoutine;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref progressData;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &cancel;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interop.Kernel32.NativeMethodInfoPtr_CopyFileExPrivate_Private_Static_Boolean_String_String_IntPtr_IntPtr_byref_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005555 RID: 21845 RVA: 0x0018A404 File Offset: 0x00188604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275370, XrefRangeEnd = 1275378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CopyFileEx(string src, string dst, IntPtr progressRoutine, IntPtr progressData, ref int cancel, int flags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(src);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dst);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref progressRoutine;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref progressData;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &cancel;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interop.Kernel32.NativeMethodInfoPtr_CopyFileEx_Internal_Static_Boolean_String_String_IntPtr_IntPtr_byref_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005556 RID: 21846 RVA: 0x0018A490 File Offset: 0x00188690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275378, XrefRangeEnd = 1275381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CreateDirectoryPrivate(string path, ref Interop.Kernel32.SECURITY_ATTRIBUTES lpSecurityAttributes)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lpSecurityAttributes;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interop.Kernel32.NativeMethodInfoPtr_CreateDirectoryPrivate_Private_Static_Boolean_String_byref_SECURITY_ATTRIBUTES_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005557 RID: 21847 RVA: 0x0018A4E0 File Offset: 0x001886E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1275388, RefRangeEnd = 1275390, XrefRangeStart = 1275381, XrefRangeEnd = 1275388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CreateDirectory(string path, ref Interop.Kernel32.SECURITY_ATTRIBUTES lpSecurityAttributes)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lpSecurityAttributes;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interop.Kernel32.NativeMethodInfoPtr_CreateDirectory_Internal_Static_Boolean_String_byref_SECURITY_ATTRIBUTES_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005558 RID: 21848 RVA: 0x0018A530 File Offset: 0x00188730
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275390, XrefRangeEnd = 1275393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr CreateFilePrivate(string lpFileName, int dwDesiredAccess, FileShare dwShareMode, Interop.Kernel32.SECURITY_ATTRIBUTES* securityAttrs, FileMode dwCreationDisposition, int dwFlagsAndAttributes, IntPtr hTemplateFile)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(lpFileName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dwDesiredAccess;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dwShareMode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = securityAttrs;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dwCreationDisposition;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dwFlagsAndAttributes;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hTemplateFile;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interop.Kernel32.NativeMethodInfoPtr_CreateFilePrivate_Private_Static_IntPtr_String_Int32_FileShare_ptr_SECURITY_ATTRIBUTES_FileMode_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005559 RID: 21849 RVA: 0x0018A5C4 File Offset: 0x001887C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1275404, RefRangeEnd = 1275405, XrefRangeStart = 1275393, XrefRangeEnd = 1275404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SafeFileHandle CreateFile(string lpFileName, int dwDesiredAccess, FileShare dwShareMode, FileMode dwCreationDisposition, int dwFlagsAndAttributes)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(lpFileName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dwDesiredAccess;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dwShareMode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dwCreationDisposition;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dwFlagsAndAttributes;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interop.Kernel32.NativeMethodInfoPtr_CreateFile_Internal_Static_SafeFileHandle_String_Int32_FileShare_FileMode_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SafeFileHandle>(intPtr3) : null;
		}

		// Token: 0x0600555A RID: 21850 RVA: 0x0018A640 File Offset: 0x00188840
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1275412, RefRangeEnd = 1275413, XrefRangeStart = 1275405, XrefRangeEnd = 1275412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr CreateFile_IntPtr(string lpFileName, int dwDesiredAccess, FileShare dwShareMode, FileMode dwCreationDisposition, int dwFlagsAndAttributes)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(lpFileName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dwDesiredAccess;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dwShareMode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dwCreationDisposition;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dwFlagsAndAttributes;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interop.Kernel32.NativeMethodInfoPtr_CreateFile_IntPtr_Internal_Static_IntPtr_String_Int32_FileShare_FileMode_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600555B RID: 21851 RVA: 0x0018A6BC File Offset: 0x001888BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275413, XrefRangeEnd = 1275416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DeleteFilePrivate(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interop.Kernel32.NativeMethodInfoPtr_DeleteFilePrivate_Private_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600555C RID: 21852 RVA: 0x0018A700 File Offset: 0x00188900
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1275423, RefRangeEnd = 1275424, XrefRangeStart = 1275416, XrefRangeEnd = 1275423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DeleteFile(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interop.Kernel32.NativeMethodInfoPtr_DeleteFile_Internal_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600555D RID: 21853 RVA: 0x0018A744 File Offset: 0x00188944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275424, XrefRangeEnd = 1275431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SafeFindHandle FindFirstFileExPrivate(string lpFileName, Interop.Kernel32.FINDEX_INFO_LEVELS fInfoLevelId, ref Interop.Kernel32.WIN32_FIND_DATA lpFindFileData, Interop.Kernel32.FINDEX_SEARCH_OPS fSearchOp, IntPtr lpSearchFilter, int dwAdditionalFlags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(lpFileName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fInfoLevelId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lpFindFileData;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fSearchOp;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lpSearchFilter;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dwAdditionalFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interop.Kernel32.NativeMethodInfoPtr_FindFirstFileExPrivate_Private_Static_SafeFindHandle_String_FINDEX_INFO_LEVELS_byref_WIN32_FIND_DATA_FINDEX_SEARCH_OPS_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SafeFindHandle>(intPtr3) : null;
		}

		// Token: 0x0600555E RID: 21854 RVA: 0x0018A7D0 File Offset: 0x001889D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1275442, RefRangeEnd = 1275443, XrefRangeStart = 1275431, XrefRangeEnd = 1275442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SafeFindHandle FindFirstFile(string fileName, ref Interop.Kernel32.WIN32_FIND_DATA data)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fileName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &data;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interop.Kernel32.NativeMethodInfoPtr_FindFirstFile_Internal_Static_SafeFindHandle_String_byref_WIN32_FIND_DATA_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SafeFindHandle>(intPtr3) : null;
		}

		// Token: 0x0600555F RID: 21855 RVA: 0x0018A824 File Offset: 0x00188A24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1275447, RefRangeEnd = 1275448, XrefRangeStart = 1275443, XrefRangeEnd = 1275447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool FindNextFile(SafeFindHandle hndFindFile, ref Interop.Kernel32.WIN32_FIND_DATA lpFindFileData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hndFindFile);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lpFindFileData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interop.Kernel32.NativeMethodInfoPtr_FindNextFile_Internal_Static_Boolean_SafeFindHandle_byref_WIN32_FIND_DATA_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005560 RID: 21856 RVA: 0x0018A874 File Offset: 0x00188A74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275448, XrefRangeEnd = 1275451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FormatMessage(int dwFlags, IntPtr lpSource, uint dwMessageId, int dwLanguageId, char* lpBuffer, int nSize, Il2CppStructArray<IntPtr> arguments)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dwFlags;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lpSource;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dwMessageId;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dwLanguageId;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = lpBuffer;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nSize;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arguments);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interop.Kernel32.NativeMethodInfoPtr_FormatMessage_Private_Static_Int32_Int32_IntPtr_UInt32_Int32_ptr_Char_Int32_Il2CppStructArray_1_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005561 RID: 21857 RVA: 0x0018A90C File Offset: 0x00188B0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1275452, RefRangeEnd = 1275454, XrefRangeStart = 1275451, XrefRangeEnd = 1275452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetMessage(int errorCode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref errorCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interop.Kernel32.NativeMethodInfoPtr_GetMessage_Internal_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06005562 RID: 21858 RVA: 0x0018A944 File Offset: 0x00188B44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1275470, RefRangeEnd = 1275471, XrefRangeStart = 1275454, XrefRangeEnd = 1275470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetMessage(IntPtr moduleHandle, int errorCode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref moduleHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref errorCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interop.Kernel32.NativeMethodInfoPtr_GetMessage_Internal_Static_String_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005563 RID: 21859 RVA: 0x0018A98C File Offset: 0x00188B8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1275503, RefRangeEnd = 1275504, XrefRangeStart = 1275471, XrefRangeEnd = 1275503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetErrorMessage(IntPtr moduleHandle, int errorCode, Span<char> buffer, out string errorMsg)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref moduleHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref errorCode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(buffer));
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Interop.Kernel32.NativeMethodInfoPtr_TryGetErrorMessage_Private_Static_Boolean_IntPtr_Int32_Span_1_Char_byref_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			errorMsg = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06005564 RID: 21860 RVA: 0x0018AA0C File Offset: 0x00188C0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275504, XrefRangeEnd = 1275507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetFileAttributesExPrivate(string name, Interop.Kernel32.GET_FILEEX_INFO_LEVELS fileInfoLevel, ref Interop.Kernel32.WIN32_FILE_ATTRIBUTE_DATA lpFileInformation)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fileInfoLevel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lpFileInformation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interop.Kernel32.NativeMethodInfoPtr_GetFileAttributesExPrivate_Private_Static_Boolean_String_GET_FILEEX_INFO_LEVELS_byref_WIN32_FILE_ATTRIBUTE_DATA_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005565 RID: 21861 RVA: 0x0018AA6C File Offset: 0x00188C6C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1275514, RefRangeEnd = 1275516, XrefRangeStart = 1275507, XrefRangeEnd = 1275514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetFileAttributesEx(string name, Interop.Kernel32.GET_FILEEX_INFO_LEVELS fileInfoLevel, ref Interop.Kernel32.WIN32_FILE_ATTRIBUTE_DATA lpFileInformation)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fileInfoLevel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lpFileInformation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interop.Kernel32.NativeMethodInfoPtr_GetFileAttributesEx_Internal_Static_Boolean_String_GET_FILEEX_INFO_LEVELS_byref_WIN32_FILE_ATTRIBUTE_DATA_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005566 RID: 21862 RVA: 0x0018AACC File Offset: 0x00188CCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1275519, RefRangeEnd = 1275520, XrefRangeStart = 1275516, XrefRangeEnd = 1275519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetFileInformationByHandleEx(IntPtr hFile, Interop.Kernel32.FILE_INFO_BY_HANDLE_CLASS FileInformationClass, IntPtr lpFileInformation, uint dwBufferSize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hFile;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref FileInformationClass;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lpFileInformation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dwBufferSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interop.Kernel32.NativeMethodInfoPtr_GetFileInformationByHandleEx_Public_Static_Boolean_IntPtr_FILE_INFO_BY_HANDLE_CLASS_IntPtr_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005567 RID: 21863 RVA: 0x0018AB34 File Offset: 0x00188D34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275520, XrefRangeEnd = 1275523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RemoveDirectoryPrivate(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interop.Kernel32.NativeMethodInfoPtr_RemoveDirectoryPrivate_Private_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06005568 RID: 21864 RVA: 0x0018AB78 File Offset: 0x00188D78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1275530, RefRangeEnd = 1275531, XrefRangeStart = 1275523, XrefRangeEnd = 1275530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RemoveDirectory(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interop.Kernel32.NativeMethodInfoPtr_RemoveDirectory_Internal_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06005569 RID: 21865 RVA: 0x0018ABBC File Offset: 0x00188DBC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1275534, RefRangeEnd = 1275540, XrefRangeStart = 1275531, XrefRangeEnd = 1275534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetThreadErrorMode(uint dwNewMode, out uint lpOldMode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dwNewMode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lpOldMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interop.Kernel32.NativeMethodInfoPtr_SetThreadErrorMode_Internal_Static_Boolean_UInt32_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600556A RID: 21866 RVA: 0x0001E4BA File Offset: 0x0001C6BA
		public Kernel32(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170015E2 RID: 5602
		// (get) Token: 0x0600556B RID: 21867 RVA: 0x0018AC08 File Offset: 0x00188E08
		// (set) Token: 0x0600556C RID: 21868 RVA: 0x0001E4C3 File Offset: 0x0001C6C3
		public unsafe static bool useUWPFallback
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(Interop.Kernel32.NativeFieldInfoPtr_useUWPFallback, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Interop.Kernel32.NativeFieldInfoPtr_useUWPFallback, (void*)(&value));
			}
		}

		// Token: 0x04004567 RID: 17767
		private static readonly IntPtr NativeFieldInfoPtr_useUWPFallback;

		// Token: 0x04004568 RID: 17768
		private static readonly IntPtr NativeMethodInfoPtr_CopyFileUWP_Internal_Static_Int32_String_String_Boolean_0;

		// Token: 0x04004569 RID: 17769
		private static readonly IntPtr NativeMethodInfoPtr_CopyFile_Internal_Static_Int32_String_String_Boolean_0;

		// Token: 0x0400456A RID: 17770
		private static readonly IntPtr NativeMethodInfoPtr_DeleteVolumeMountPointPrivate_Internal_Static_Boolean_String_0;

		// Token: 0x0400456B RID: 17771
		private static readonly IntPtr NativeMethodInfoPtr_DeleteVolumeMountPoint_Internal_Static_Boolean_String_0;

		// Token: 0x0400456C RID: 17772
		private static readonly IntPtr NativeMethodInfoPtr_FreeLibrary_Internal_Static_Boolean_IntPtr_0;

		// Token: 0x0400456D RID: 17773
		private static readonly IntPtr NativeMethodInfoPtr_LoadLibraryEx_Internal_Static_SafeLibraryHandle_String_IntPtr_Int32_0;

		// Token: 0x0400456E RID: 17774
		private static readonly IntPtr NativeMethodInfoPtr_GetFileMUIPath_Internal_Static_Boolean_UInt32_String_StringBuilder_byref_Int32_StringBuilder_byref_Int32_byref_Int64_0;

		// Token: 0x0400456F RID: 17775
		private static readonly IntPtr NativeMethodInfoPtr_GetDynamicTimeZoneInformation_Internal_Static_UInt32_byref_TIME_DYNAMIC_ZONE_INFORMATION_0;

		// Token: 0x04004570 RID: 17776
		private static readonly IntPtr NativeMethodInfoPtr_GetTimeZoneInformation_Internal_Static_UInt32_byref_TIME_ZONE_INFORMATION_0;

		// Token: 0x04004571 RID: 17777
		private static readonly IntPtr NativeMethodInfoPtr_CloseHandle_Internal_Static_Boolean_IntPtr_0;

		// Token: 0x04004572 RID: 17778
		private static readonly IntPtr NativeMethodInfoPtr_CopyFile2_Internal_Static_Int32_String_String_byref_COPYFILE2_EXTENDED_PARAMETERS_0;

		// Token: 0x04004573 RID: 17779
		private static readonly IntPtr NativeMethodInfoPtr_CopyFileExPrivate_Private_Static_Boolean_String_String_IntPtr_IntPtr_byref_Int32_Int32_0;

		// Token: 0x04004574 RID: 17780
		private static readonly IntPtr NativeMethodInfoPtr_CopyFileEx_Internal_Static_Boolean_String_String_IntPtr_IntPtr_byref_Int32_Int32_0;

		// Token: 0x04004575 RID: 17781
		private static readonly IntPtr NativeMethodInfoPtr_CreateDirectoryPrivate_Private_Static_Boolean_String_byref_SECURITY_ATTRIBUTES_0;

		// Token: 0x04004576 RID: 17782
		private static readonly IntPtr NativeMethodInfoPtr_CreateDirectory_Internal_Static_Boolean_String_byref_SECURITY_ATTRIBUTES_0;

		// Token: 0x04004577 RID: 17783
		private static readonly IntPtr NativeMethodInfoPtr_CreateFilePrivate_Private_Static_IntPtr_String_Int32_FileShare_ptr_SECURITY_ATTRIBUTES_FileMode_Int32_IntPtr_0;

		// Token: 0x04004578 RID: 17784
		private static readonly IntPtr NativeMethodInfoPtr_CreateFile_Internal_Static_SafeFileHandle_String_Int32_FileShare_FileMode_Int32_0;

		// Token: 0x04004579 RID: 17785
		private static readonly IntPtr NativeMethodInfoPtr_CreateFile_IntPtr_Internal_Static_IntPtr_String_Int32_FileShare_FileMode_Int32_0;

		// Token: 0x0400457A RID: 17786
		private static readonly IntPtr NativeMethodInfoPtr_DeleteFilePrivate_Private_Static_Boolean_String_0;

		// Token: 0x0400457B RID: 17787
		private static readonly IntPtr NativeMethodInfoPtr_DeleteFile_Internal_Static_Boolean_String_0;

		// Token: 0x0400457C RID: 17788
		private static readonly IntPtr NativeMethodInfoPtr_FindFirstFileExPrivate_Private_Static_SafeFindHandle_String_FINDEX_INFO_LEVELS_byref_WIN32_FIND_DATA_FINDEX_SEARCH_OPS_IntPtr_Int32_0;

		// Token: 0x0400457D RID: 17789
		private static readonly IntPtr NativeMethodInfoPtr_FindFirstFile_Internal_Static_SafeFindHandle_String_byref_WIN32_FIND_DATA_0;

		// Token: 0x0400457E RID: 17790
		private static readonly IntPtr NativeMethodInfoPtr_FindNextFile_Internal_Static_Boolean_SafeFindHandle_byref_WIN32_FIND_DATA_0;

		// Token: 0x0400457F RID: 17791
		private static readonly IntPtr NativeMethodInfoPtr_FormatMessage_Private_Static_Int32_Int32_IntPtr_UInt32_Int32_ptr_Char_Int32_Il2CppStructArray_1_IntPtr_0;

		// Token: 0x04004580 RID: 17792
		private static readonly IntPtr NativeMethodInfoPtr_GetMessage_Internal_Static_String_Int32_0;

		// Token: 0x04004581 RID: 17793
		private static readonly IntPtr NativeMethodInfoPtr_GetMessage_Internal_Static_String_IntPtr_Int32_0;

		// Token: 0x04004582 RID: 17794
		private static readonly IntPtr NativeMethodInfoPtr_TryGetErrorMessage_Private_Static_Boolean_IntPtr_Int32_Span_1_Char_byref_String_0;

		// Token: 0x04004583 RID: 17795
		private static readonly IntPtr NativeMethodInfoPtr_GetFileAttributesExPrivate_Private_Static_Boolean_String_GET_FILEEX_INFO_LEVELS_byref_WIN32_FILE_ATTRIBUTE_DATA_0;

		// Token: 0x04004584 RID: 17796
		private static readonly IntPtr NativeMethodInfoPtr_GetFileAttributesEx_Internal_Static_Boolean_String_GET_FILEEX_INFO_LEVELS_byref_WIN32_FILE_ATTRIBUTE_DATA_0;

		// Token: 0x04004585 RID: 17797
		private static readonly IntPtr NativeMethodInfoPtr_GetFileInformationByHandleEx_Public_Static_Boolean_IntPtr_FILE_INFO_BY_HANDLE_CLASS_IntPtr_UInt32_0;

		// Token: 0x04004586 RID: 17798
		private static readonly IntPtr NativeMethodInfoPtr_RemoveDirectoryPrivate_Private_Static_Boolean_String_0;

		// Token: 0x04004587 RID: 17799
		private static readonly IntPtr NativeMethodInfoPtr_RemoveDirectory_Internal_Static_Boolean_String_0;

		// Token: 0x04004588 RID: 17800
		private static readonly IntPtr NativeMethodInfoPtr_SetThreadErrorMode_Internal_Static_Boolean_UInt32_byref_UInt32_0;

		// Token: 0x02000770 RID: 1904
		[StructLayout(2, CharSet = 3)]
		public struct WIN32_FIND_DATA
		{
			// Token: 0x060062CD RID: 25293 RVA: 0x001B8C7C File Offset: 0x001B6E7C
			// Note: this type is marked as 'beforefieldinit'.
			static WIN32_FIND_DATA()
			{
				Il2CppClassPointerStore<Interop.Kernel32.WIN32_FIND_DATA>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Interop.Kernel32>.NativeClassPtr, "WIN32_FIND_DATA");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Interop.Kernel32.WIN32_FIND_DATA>.NativeClassPtr);
				Interop.Kernel32.WIN32_FIND_DATA.NativeFieldInfoPtr_dwFileAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.Kernel32.WIN32_FIND_DATA>.NativeClassPtr, "dwFileAttributes");
				Interop.Kernel32.WIN32_FIND_DATA.NativeFieldInfoPtr_ftCreationTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.Kernel32.WIN32_FIND_DATA>.NativeClassPtr, "ftCreationTime");
				Interop.Kernel32.WIN32_FIND_DATA.NativeFieldInfoPtr_ftLastAccessTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.Kernel32.WIN32_FIND_DATA>.NativeClassPtr, "ftLastAccessTime");
				Interop.Kernel32.WIN32_FIND_DATA.NativeFieldInfoPtr_ftLastWriteTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.Kernel32.WIN32_FIND_DATA>.NativeClassPtr, "ftLastWriteTime");
				Interop.Kernel32.WIN32_FIND_DATA.NativeFieldInfoPtr_nFileSizeHigh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.Kernel32.WIN32_FIND_DATA>.NativeClassPtr, "nFileSizeHigh");
				Interop.Kernel32.WIN32_FIND_DATA.NativeFieldInfoPtr_nFileSizeLow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.Kernel32.WIN32_FIND_DATA>.NativeClassPtr, "nFileSizeLow");
				Interop.Kernel32.WIN32_FIND_DATA.NativeFieldInfoPtr_dwReserved0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.Kernel32.WIN32_FIND_DATA>.NativeClassPtr, "dwReserved0");
				Interop.Kernel32.WIN32_FIND_DATA.NativeFieldInfoPtr_dwReserved1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.Kernel32.WIN32_FIND_DATA>.NativeClassPtr, "dwReserved1");
				Interop.Kernel32.WIN32_FIND_DATA.NativeFieldInfoPtr__cFileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.Kernel32.WIN32_FIND_DATA>.NativeClassPtr, "_cFileName");
				Interop.Kernel32.WIN32_FIND_DATA.NativeFieldInfoPtr__cAlternateFileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.Kernel32.WIN32_FIND_DATA>.NativeClassPtr, "_cAlternateFileName");
				Interop.Kernel32.WIN32_FIND_DATA.NativeMethodInfoPtr_get_cFileName_Internal_get_ReadOnlySpan_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interop.Kernel32.WIN32_FIND_DATA>.NativeClassPtr, 100663331);
				Interop.Kernel32.WIN32_FIND_DATA.NativeMethodInfoPtr_SetFileName_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interop.Kernel32.WIN32_FIND_DATA>.NativeClassPtr, 100663332);
			}

			// Token: 0x1700198C RID: 6540
			// (get) Token: 0x060062CE RID: 25294 RVA: 0x001B8D98 File Offset: 0x001B6F98
			public unsafe ReadOnlySpan<char> cFileName
			{
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 1275259, RefRangeEnd = 1275263, XrefRangeStart = 1275258, XrefRangeEnd = 1275259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interop.Kernel32.WIN32_FIND_DATA.NativeMethodInfoPtr_get_cFileName_Internal_get_ReadOnlySpan_1_Char_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ReadOnlySpan<char>(intPtr);
				}
			}

			// Token: 0x060062CF RID: 25295 RVA: 0x001B8DC4 File Offset: 0x001B6FC4
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1275268, RefRangeEnd = 1275271, XrefRangeStart = 1275263, XrefRangeEnd = 1275268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetFileName(string fileName)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(fileName);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interop.Kernel32.WIN32_FIND_DATA.NativeMethodInfoPtr_SetFileName_Internal_Void_String_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060062D0 RID: 25296 RVA: 0x00024FD4 File Offset: 0x000231D4
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Interop.Kernel32.WIN32_FIND_DATA>.NativeClassPtr, ref this));
			}

			// Token: 0x04004F5D RID: 20317
			private static readonly IntPtr NativeFieldInfoPtr_dwFileAttributes;

			// Token: 0x04004F5E RID: 20318
			private static readonly IntPtr NativeFieldInfoPtr_ftCreationTime;

			// Token: 0x04004F5F RID: 20319
			private static readonly IntPtr NativeFieldInfoPtr_ftLastAccessTime;

			// Token: 0x04004F60 RID: 20320
			private static readonly IntPtr NativeFieldInfoPtr_ftLastWriteTime;

			// Token: 0x04004F61 RID: 20321
			private static readonly IntPtr NativeFieldInfoPtr_nFileSizeHigh;

			// Token: 0x04004F62 RID: 20322
			private static readonly IntPtr NativeFieldInfoPtr_nFileSizeLow;

			// Token: 0x04004F63 RID: 20323
			private static readonly IntPtr NativeFieldInfoPtr_dwReserved0;

			// Token: 0x04004F64 RID: 20324
			private static readonly IntPtr NativeFieldInfoPtr_dwReserved1;

			// Token: 0x04004F65 RID: 20325
			private static readonly IntPtr NativeFieldInfoPtr__cFileName;

			// Token: 0x04004F66 RID: 20326
			private static readonly IntPtr NativeFieldInfoPtr__cAlternateFileName;

			// Token: 0x04004F67 RID: 20327
			private static readonly IntPtr NativeMethodInfoPtr_get_cFileName_Internal_get_ReadOnlySpan_1_Char_0;

			// Token: 0x04004F68 RID: 20328
			private static readonly IntPtr NativeMethodInfoPtr_SetFileName_Internal_Void_String_0;

			// Token: 0x04004F69 RID: 20329
			[FieldOffset(0)]
			public uint dwFileAttributes;

			// Token: 0x04004F6A RID: 20330
			[FieldOffset(4)]
			public Interop.Kernel32.FILE_TIME ftCreationTime;

			// Token: 0x04004F6B RID: 20331
			[FieldOffset(12)]
			public Interop.Kernel32.FILE_TIME ftLastAccessTime;

			// Token: 0x04004F6C RID: 20332
			[FieldOffset(20)]
			public Interop.Kernel32.FILE_TIME ftLastWriteTime;

			// Token: 0x04004F6D RID: 20333
			[FieldOffset(28)]
			public uint nFileSizeHigh;

			// Token: 0x04004F6E RID: 20334
			[FieldOffset(32)]
			public uint nFileSizeLow;

			// Token: 0x04004F6F RID: 20335
			[FieldOffset(36)]
			public uint dwReserved0;

			// Token: 0x04004F70 RID: 20336
			[FieldOffset(40)]
			public uint dwReserved1;

			// Token: 0x04004F71 RID: 20337
			[FieldOffset(44)]
			public Interop.Kernel32.WIN32_FIND_DATA.__cFileName_e__FixedBuffer _cFileName;

			// Token: 0x04004F72 RID: 20338
			[FieldOffset(564)]
			public Interop.Kernel32.WIN32_FIND_DATA.__cAlternateFileName_e__FixedBuffer _cAlternateFileName;

			// Token: 0x02000796 RID: 1942
			[ObfuscatedName("Interop+Kernel32+WIN32_FIND_DATA+<_cFileName>e__FixedBuffer")]
			[StructLayout(2, CharSet = 3)]
			public struct __cFileName_e__FixedBuffer
			{
				// Token: 0x06006366 RID: 25446 RVA: 0x000253D2 File Offset: 0x000235D2
				// Note: this type is marked as 'beforefieldinit'.
				static __cFileName_e__FixedBuffer()
				{
					Il2CppClassPointerStore<Interop.Kernel32.WIN32_FIND_DATA.__cFileName_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Interop.Kernel32.WIN32_FIND_DATA>.NativeClassPtr, "<_cFileName>e__FixedBuffer");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Interop.Kernel32.WIN32_FIND_DATA.__cFileName_e__FixedBuffer>.NativeClassPtr);
					Interop.Kernel32.WIN32_FIND_DATA.__cFileName_e__FixedBuffer.NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.Kernel32.WIN32_FIND_DATA.__cFileName_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
				}

				// Token: 0x06006367 RID: 25447 RVA: 0x00025406 File Offset: 0x00023606
				public Object BoxIl2CppObject()
				{
					return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Interop.Kernel32.WIN32_FIND_DATA.__cFileName_e__FixedBuffer>.NativeClassPtr, ref this));
				}

				// Token: 0x04005118 RID: 20760
				private static readonly IntPtr NativeFieldInfoPtr_FixedElementField;

				// Token: 0x04005119 RID: 20761
				[FieldOffset(0)]
				public char FixedElementField;
			}

			// Token: 0x02000797 RID: 1943
			[ObfuscatedName("Interop+Kernel32+WIN32_FIND_DATA+<_cAlternateFileName>e__FixedBuffer")]
			[StructLayout(2, CharSet = 3)]
			public struct __cAlternateFileName_e__FixedBuffer
			{
				// Token: 0x06006368 RID: 25448 RVA: 0x00025418 File Offset: 0x00023618
				// Note: this type is marked as 'beforefieldinit'.
				static __cAlternateFileName_e__FixedBuffer()
				{
					Il2CppClassPointerStore<Interop.Kernel32.WIN32_FIND_DATA.__cAlternateFileName_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Interop.Kernel32.WIN32_FIND_DATA>.NativeClassPtr, "<_cAlternateFileName>e__FixedBuffer");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Interop.Kernel32.WIN32_FIND_DATA.__cAlternateFileName_e__FixedBuffer>.NativeClassPtr);
					Interop.Kernel32.WIN32_FIND_DATA.__cAlternateFileName_e__FixedBuffer.NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.Kernel32.WIN32_FIND_DATA.__cAlternateFileName_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
				}

				// Token: 0x06006369 RID: 25449 RVA: 0x0002544C File Offset: 0x0002364C
				public Object BoxIl2CppObject()
				{
					return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Interop.Kernel32.WIN32_FIND_DATA.__cAlternateFileName_e__FixedBuffer>.NativeClassPtr, ref this));
				}

				// Token: 0x0400511A RID: 20762
				private static readonly IntPtr NativeFieldInfoPtr_FixedElementField;

				// Token: 0x0400511B RID: 20763
				[FieldOffset(0)]
				public char FixedElementField;
			}
		}

		// Token: 0x02000771 RID: 1905
		[StructLayout(2)]
		public struct REG_TZI_FORMAT
		{
			// Token: 0x060062D1 RID: 25297 RVA: 0x001B8DFC File Offset: 0x001B6FFC
			// Note: this type is marked as 'beforefieldinit'.
			static REG_TZI_FORMAT()
			{
				Il2CppClassPointerStore<Interop.Kernel32.REG_TZI_FORMAT>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Interop.Kernel32>.NativeClassPtr, "REG_TZI_FORMAT");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Interop.Kernel32.REG_TZI_FORMAT>.NativeClassPtr);
				Interop.Kernel32.REG_TZI_FORMAT.NativeFieldInfoPtr_Bias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.Kernel32.REG_TZI_FORMAT>.NativeClassPtr, "Bias");
				Interop.Kernel32.REG_TZI_FORMAT.NativeFieldInfoPtr_StandardBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.Kernel32.REG_TZI_FORMAT>.NativeClassPtr, "StandardBias");
				Interop.Kernel32.REG_TZI_FORMAT.NativeFieldInfoPtr_DaylightBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.Kernel32.REG_TZI_FORMAT>.NativeClassPtr, "DaylightBias");
				Interop.Kernel32.REG_TZI_FORMAT.NativeFieldInfoPtr_StandardDate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.Kernel32.REG_TZI_FORMAT>.NativeClassPtr, "StandardDate");
				Interop.Kernel32.REG_TZI_FORMAT.NativeFieldInfoPtr_DaylightDate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.Kernel32.REG_TZI_FORMAT>.NativeClassPtr, "DaylightDate");
				Interop.Kernel32.REG_TZI_FORMAT.NativeMethodInfoPtr__ctor_Internal_Void_byref_TIME_ZONE_INFORMATION_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interop.Kernel32.REG_TZI_FORMAT>.NativeClassPtr, 100663333);
			}

			// Token: 0x060062D2 RID: 25298 RVA: 0x001B8EA0 File Offset: 0x001B70A0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1275271, RefRangeEnd = 1275272, XrefRangeStart = 1275271, XrefRangeEnd = 1275271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe REG_TZI_FORMAT([In] ref Interop.Kernel32.TIME_ZONE_INFORMATION tzi)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &tzi;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interop.Kernel32.REG_TZI_FORMAT.NativeMethodInfoPtr__ctor_Internal_Void_byref_TIME_ZONE_INFORMATION_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060062D3 RID: 25299 RVA: 0x00024FE6 File Offset: 0x000231E6
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Interop.Kernel32.REG_TZI_FORMAT>.NativeClassPtr, ref this));
			}

			// Token: 0x04004F73 RID: 20339
			private static readonly IntPtr NativeFieldInfoPtr_Bias;

			// Token: 0x04004F74 RID: 20340
			private static readonly IntPtr NativeFieldInfoPtr_StandardBias;

			// Token: 0x04004F75 RID: 20341
			private static readonly IntPtr NativeFieldInfoPtr_DaylightBias;

			// Token: 0x04004F76 RID: 20342
			private static readonly IntPtr NativeFieldInfoPtr_StandardDate;

			// Token: 0x04004F77 RID: 20343
			private static readonly IntPtr NativeFieldInfoPtr_DaylightDate;

			// Token: 0x04004F78 RID: 20344
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_byref_TIME_ZONE_INFORMATION_0;

			// Token: 0x04004F79 RID: 20345
			[FieldOffset(0)]
			public int Bias;

			// Token: 0x04004F7A RID: 20346
			[FieldOffset(4)]
			public int StandardBias;

			// Token: 0x04004F7B RID: 20347
			[FieldOffset(8)]
			public int DaylightBias;

			// Token: 0x04004F7C RID: 20348
			[FieldOffset(12)]
			public Interop.Kernel32.SYSTEMTIME StandardDate;

			// Token: 0x04004F7D RID: 20349
			[FieldOffset(28)]
			public Interop.Kernel32.SYSTEMTIME DaylightDate;
		}

		// Token: 0x02000772 RID: 1906
		[StructLayout(2)]
		public struct SYSTEMTIME
		{
			// Token: 0x060062D4 RID: 25300 RVA: 0x001B8ED4 File Offset: 0x001B70D4
			// Note: this type is marked as 'beforefieldinit'.
			static SYSTEMTIME()
			{
				Il2CppClassPointerStore<Interop.Kernel32.SYSTEMTIME>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Interop.Kernel32>.NativeClassPtr, "SYSTEMTIME");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Interop.Kernel32.SYSTEMTIME>.NativeClassPtr);
				Interop.Kernel32.SYSTEMTIME.NativeFieldInfoPtr_Year = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.Kernel32.SYSTEMTIME>.NativeClassPtr, "Year");
				Interop.Kernel32.SYSTEMTIME.NativeFieldInfoPtr_Month = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.Kernel32.SYSTEMTIME>.NativeClassPtr, "Month");
				Interop.Kernel32.SYSTEMTIME.NativeFieldInfoPtr_DayOfWeek = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.Kernel32.SYSTEMTIME>.NativeClassPtr, "DayOfWeek");
				Interop.Kernel32.SYSTEMTIME.NativeFieldInfoPtr_Day = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.Kernel32.SYSTEMTIME>.NativeClassPtr, "Day");
				Interop.Kernel32.SYSTEMTIME.NativeFieldInfoPtr_Hour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.Kernel32.SYSTEMTIME>.NativeClassPtr, "Hour");
				Interop.Kernel32.SYSTEMTIME.NativeFieldInfoPtr_Minute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.Kernel32.SYSTEMTIME>.NativeClassPtr, "Minute");
				Interop.Kernel32.SYSTEMTIME.NativeFieldInfoPtr_Second = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.Kernel32.SYSTEMTIME>.NativeClassPtr, "Second");
				Interop.Kernel32.SYSTEMTIME.NativeFieldInfoPtr_Milliseconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.Kernel32.SYSTEMTIME>.NativeClassPtr, "Milliseconds");
				Interop.Kernel32.SYSTEMTIME.NativeMethodInfoPtr_Equals_Internal_Boolean_byref_SYSTEMTIME_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interop.Kernel32.SYSTEMTIME>.NativeClassPtr, 100663334);
			}

			// Token: 0x060062D5 RID: 25301 RVA: 0x001B8FB4 File Offset: 0x001B71B4
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1275272, RefRangeEnd = 1275277, XrefRangeStart = 1275272, XrefRangeEnd = 1275272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Equals([In] ref Interop.Kernel32.SYSTEMTIME other)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &other;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interop.Kernel32.SYSTEMTIME.NativeMethodInfoPtr_Equals_Internal_Boolean_byref_SYSTEMTIME_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060062D6 RID: 25302 RVA: 0x00024FF8 File Offset: 0x000231F8
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Interop.Kernel32.SYSTEMTIME>.NativeClassPtr, ref this));
			}

			// Token: 0x04004F7E RID: 20350
			private static readonly IntPtr NativeFieldInfoPtr_Year;

			// Token: 0x04004F7F RID: 20351
			private static readonly IntPtr NativeFieldInfoPtr_Month;

			// Token: 0x04004F80 RID: 20352
			private static readonly IntPtr NativeFieldInfoPtr_DayOfWeek;

			// Token: 0x04004F81 RID: 20353
			private static readonly IntPtr NativeFieldInfoPtr_Day;

			// Token: 0x04004F82 RID: 20354
			private static readonly IntPtr NativeFieldInfoPtr_Hour;

			// Token: 0x04004F83 RID: 20355
			private static readonly IntPtr NativeFieldInfoPtr_Minute;

			// Token: 0x04004F84 RID: 20356
			private static readonly IntPtr NativeFieldInfoPtr_Second;

			// Token: 0x04004F85 RID: 20357
			private static readonly IntPtr NativeFieldInfoPtr_Milliseconds;

			// Token: 0x04004F86 RID: 20358
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Internal_Boolean_byref_SYSTEMTIME_0;

			// Token: 0x04004F87 RID: 20359
			[FieldOffset(0)]
			public ushort Year;

			// Token: 0x04004F88 RID: 20360
			[FieldOffset(2)]
			public ushort Month;

			// Token: 0x04004F89 RID: 20361
			[FieldOffset(4)]
			public ushort DayOfWeek;

			// Token: 0x04004F8A RID: 20362
			[FieldOffset(6)]
			public ushort Day;

			// Token: 0x04004F8B RID: 20363
			[FieldOffset(8)]
			public ushort Hour;

			// Token: 0x04004F8C RID: 20364
			[FieldOffset(10)]
			public ushort Minute;

			// Token: 0x04004F8D RID: 20365
			[FieldOffset(12)]
			public ushort Second;

			// Token: 0x04004F8E RID: 20366
			[FieldOffset(14)]
			public ushort Milliseconds;
		}

		// Token: 0x02000773 RID: 1907
		[StructLayout(2, CharSet = 3)]
		public struct TIME_DYNAMIC_ZONE_INFORMATION
		{
			// Token: 0x060062D7 RID: 25303 RVA: 0x001B8FF4 File Offset: 0x001B71F4
			// Note: this type is marked as 'beforefieldinit'.
			static TIME_DYNAMIC_ZONE_INFORMATION()
			{
				Il2CppClassPointerStore<Interop.Kernel32.TIME_DYNAMIC_ZONE_INFORMATION>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Interop.Kernel32>.NativeClassPtr, "TIME_DYNAMIC_ZONE_INFORMATION");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Interop.Kernel32.TIME_DYNAMIC_ZONE_INFORMATION>.NativeClassPtr);
				Interop.Kernel32.TIME_DYNAMIC_ZONE_INFORMATION.NativeFieldInfoPtr_Bias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.Kernel32.TIME_DYNAMIC_ZONE_INFORMATION>.NativeClassPtr, "Bias");
				Interop.Kernel32.TIME_DYNAMIC_ZONE_INFORMATION.NativeFieldInfoPtr_StandardName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.Kernel32.TIME_DYNAMIC_ZONE_INFORMATION>.NativeClassPtr, "StandardName");
				Interop.Kernel32.TIME_DYNAMIC_ZONE_INFORMATION.NativeFieldInfoPtr_StandardDate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.Kernel32.TIME_DYNAMIC_ZONE_INFORMATION>.NativeClassPtr, "StandardDate");
				Interop.Kernel32.TIME_DYNAMIC_ZONE_INFORMATION.NativeFieldInfoPtr_StandardBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.Kernel32.TIME_DYNAMIC_ZONE_INFORMATION>.NativeClassPtr, "StandardBias");
				Interop.Kernel32.TIME_DYNAMIC_ZONE_INFORMATION.NativeFieldInfoPtr_DaylightName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.Kernel32.TIME_DYNAMIC_ZONE_INFORMATION>.NativeClassPtr, "DaylightName");
				Interop.Kernel32.TIME_DYNAMIC_ZONE_INFORMATION.NativeFieldInfoPtr_DaylightDate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.Kernel32.TIME_DYNAMIC_ZONE_INFORMATION>.NativeClassPtr, "DaylightDate");
				Interop.Kernel32.TIME_DYNAMIC_ZONE_INFORMATION.NativeFieldInfoPtr_DaylightBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.Kernel32.TIME_DYNAMIC_ZONE_INFORMATION>.NativeClassPtr, "DaylightBias");
				Interop.Kernel32.TIME_DYNAMIC_ZONE_INFORMATION.NativeFieldInfoPtr_TimeZoneKeyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.Kernel32.TIME_DYNAMIC_ZONE_INFORMATION>.NativeClassPtr, "TimeZoneKeyName");
				Interop.Kernel32.TIME_DYNAMIC_ZONE_INFORMATION.NativeFieldInfoPtr_DynamicDaylightTimeDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.Kernel32.TIME_DYNAMIC_ZONE_INFORMATION>.NativeClassPtr, "DynamicDaylightTimeDisabled");
				Interop.Kernel32.TIME_DYNAMIC_ZONE_INFORMATION.NativeMethodInfoPtr_GetTimeZoneKeyName_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interop.Kernel32.TIME_DYNAMIC_ZONE_INFORMATION>.NativeClassPtr, 100663335);
			}

			// Token: 0x060062D8 RID: 25304 RVA: 0x001B90E8 File Offset: 0x001B72E8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1275278, RefRangeEnd = 1275279, XrefRangeStart = 1275277, XrefRangeEnd = 1275278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string GetTimeZoneKeyName()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interop.Kernel32.TIME_DYNAMIC_ZONE_INFORMATION.NativeMethodInfoPtr_GetTimeZoneKeyName_Internal_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x060062D9 RID: 25305 RVA: 0x0002500A File Offset: 0x0002320A
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Interop.Kernel32.TIME_DYNAMIC_ZONE_INFORMATION>.NativeClassPtr, ref this));
			}

			// Token: 0x04004F8F RID: 20367
			private static readonly IntPtr NativeFieldInfoPtr_Bias;

			// Token: 0x04004F90 RID: 20368
			private static readonly IntPtr NativeFieldInfoPtr_StandardName;

			// Token: 0x04004F91 RID: 20369
			private static readonly IntPtr NativeFieldInfoPtr_StandardDate;

			// Token: 0x04004F92 RID: 20370
			private static readonly IntPtr NativeFieldInfoPtr_StandardBias;

			// Token: 0x04004F93 RID: 20371
			private static readonly IntPtr NativeFieldInfoPtr_DaylightName;

			// Token: 0x04004F94 RID: 20372
			private static readonly IntPtr NativeFieldInfoPtr_DaylightDate;

			// Token: 0x04004F95 RID: 20373
			private static readonly IntPtr NativeFieldInfoPtr_DaylightBias;

			// Token: 0x04004F96 RID: 20374
			private static readonly IntPtr NativeFieldInfoPtr_TimeZoneKeyName;

			// Token: 0x04004F97 RID: 20375
			private static readonly IntPtr NativeFieldInfoPtr_DynamicDaylightTimeDisabled;

			// Token: 0x04004F98 RID: 20376
			private static readonly IntPtr NativeMethodInfoPtr_GetTimeZoneKeyName_Internal_String_0;

			// Token: 0x04004F99 RID: 20377
			[FieldOffset(0)]
			public int Bias;

			// Token: 0x04004F9A RID: 20378
			[FieldOffset(4)]
			public Interop.Kernel32.TIME_DYNAMIC_ZONE_INFORMATION._StandardName_e__FixedBuffer StandardName;

			// Token: 0x04004F9B RID: 20379
			[FieldOffset(68)]
			public Interop.Kernel32.SYSTEMTIME StandardDate;

			// Token: 0x04004F9C RID: 20380
			[FieldOffset(84)]
			public int StandardBias;

			// Token: 0x04004F9D RID: 20381
			[FieldOffset(88)]
			public Interop.Kernel32.TIME_DYNAMIC_ZONE_INFORMATION._DaylightName_e__FixedBuffer DaylightName;

			// Token: 0x04004F9E RID: 20382
			[FieldOffset(152)]
			public Interop.Kernel32.SYSTEMTIME DaylightDate;

			// Token: 0x04004F9F RID: 20383
			[FieldOffset(168)]
			public int DaylightBias;

			// Token: 0x04004FA0 RID: 20384
			[FieldOffset(172)]
			public Interop.Kernel32.TIME_DYNAMIC_ZONE_INFORMATION._TimeZoneKeyName_e__FixedBuffer TimeZoneKeyName;

			// Token: 0x04004FA1 RID: 20385
			[FieldOffset(428)]
			public byte DynamicDaylightTimeDisabled;

			// Token: 0x02000798 RID: 1944
			[ObfuscatedName("Interop+Kernel32+TIME_DYNAMIC_ZONE_INFORMATION+<StandardName>e__FixedBuffer")]
			[StructLayout(2, CharSet = 3)]
			public struct _StandardName_e__FixedBuffer
			{
				// Token: 0x0600636A RID: 25450 RVA: 0x0002545E File Offset: 0x0002365E
				// Note: this type is marked as 'beforefieldinit'.
				static _StandardName_e__FixedBuffer()
				{
					Il2CppClassPointerStore<Interop.Kernel32.TIME_DYNAMIC_ZONE_INFORMATION._StandardName_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Interop.Kernel32.TIME_DYNAMIC_ZONE_INFORMATION>.NativeClassPtr, "<StandardName>e__FixedBuffer");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Interop.Kernel32.TIME_DYNAMIC_ZONE_INFORMATION._StandardName_e__FixedBuffer>.NativeClassPtr);
					Interop.Kernel32.TIME_DYNAMIC_ZONE_INFORMATION._StandardName_e__FixedBuffer.NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.Kernel32.TIME_DYNAMIC_ZONE_INFORMATION._StandardName_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
				}

				// Token: 0x0600636B RID: 25451 RVA: 0x00025492 File Offset: 0x00023692
				public Object BoxIl2CppObject()
				{
					return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Interop.Kernel32.TIME_DYNAMIC_ZONE_INFORMATION._StandardName_e__FixedBuffer>.NativeClassPtr, ref this));
				}

				// Token: 0x0400511C RID: 20764
				private static readonly IntPtr NativeFieldInfoPtr_FixedElementField;

				// Token: 0x0400511D RID: 20765
				[FieldOffset(0)]
				public char FixedElementField;
			}

			// Token: 0x02000799 RID: 1945
			[ObfuscatedName("Interop+Kernel32+TIME_DYNAMIC_ZONE_INFORMATION+<DaylightName>e__FixedBuffer")]
			[StructLayout(2, CharSet = 3)]
			public struct _DaylightName_e__FixedBuffer
			{
				// Token: 0x0600636C RID: 25452 RVA: 0x000254A4 File Offset: 0x000236A4
				// Note: this type is marked as 'beforefieldinit'.
				static _DaylightName_e__FixedBuffer()
				{
					Il2CppClassPointerStore<Interop.Kernel32.TIME_DYNAMIC_ZONE_INFORMATION._DaylightName_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Interop.Kernel32.TIME_DYNAMIC_ZONE_INFORMATION>.NativeClassPtr, "<DaylightName>e__FixedBuffer");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Interop.Kernel32.TIME_DYNAMIC_ZONE_INFORMATION._DaylightName_e__FixedBuffer>.NativeClassPtr);
					Interop.Kernel32.TIME_DYNAMIC_ZONE_INFORMATION._DaylightName_e__FixedBuffer.NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.Kernel32.TIME_DYNAMIC_ZONE_INFORMATION._DaylightName_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
				}

				// Token: 0x0600636D RID: 25453 RVA: 0x000254D8 File Offset: 0x000236D8
				public Object BoxIl2CppObject()
				{
					return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Interop.Kernel32.TIME_DYNAMIC_ZONE_INFORMATION._DaylightName_e__FixedBuffer>.NativeClassPtr, ref this));
				}

				// Token: 0x0400511E RID: 20766
				private static readonly IntPtr NativeFieldInfoPtr_FixedElementField;

				// Token: 0x0400511F RID: 20767
				[FieldOffset(0)]
				public char FixedElementField;
			}

			// Token: 0x0200079A RID: 1946
			[ObfuscatedName("Interop+Kernel32+TIME_DYNAMIC_ZONE_INFORMATION+<TimeZoneKeyName>e__FixedBuffer")]
			[StructLayout(2, CharSet = 3)]
			public struct _TimeZoneKeyName_e__FixedBuffer
			{
				// Token: 0x0600636E RID: 25454 RVA: 0x000254EA File Offset: 0x000236EA
				// Note: this type is marked as 'beforefieldinit'.
				static _TimeZoneKeyName_e__FixedBuffer()
				{
					Il2CppClassPointerStore<Interop.Kernel32.TIME_DYNAMIC_ZONE_INFORMATION._TimeZoneKeyName_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Interop.Kernel32.TIME_DYNAMIC_ZONE_INFORMATION>.NativeClassPtr, "<TimeZoneKeyName>e__FixedBuffer");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Interop.Kernel32.TIME_DYNAMIC_ZONE_INFORMATION._TimeZoneKeyName_e__FixedBuffer>.NativeClassPtr);
					Interop.Kernel32.TIME_DYNAMIC_ZONE_INFORMATION._TimeZoneKeyName_e__FixedBuffer.NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.Kernel32.TIME_DYNAMIC_ZONE_INFORMATION._TimeZoneKeyName_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
				}

				// Token: 0x0600636F RID: 25455 RVA: 0x0002551E File Offset: 0x0002371E
				public Object BoxIl2CppObject()
				{
					return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Interop.Kernel32.TIME_DYNAMIC_ZONE_INFORMATION._TimeZoneKeyName_e__FixedBuffer>.NativeClassPtr, ref this));
				}

				// Token: 0x04005120 RID: 20768
				private static readonly IntPtr NativeFieldInfoPtr_FixedElementField;

				// Token: 0x04005121 RID: 20769
				[FieldOffset(0)]
				public char FixedElementField;
			}
		}

		// Token: 0x02000774 RID: 1908
		[StructLayout(2, CharSet = 3)]
		public struct TIME_ZONE_INFORMATION
		{
			// Token: 0x060062DA RID: 25306 RVA: 0x001B9114 File Offset: 0x001B7314
			// Note: this type is marked as 'beforefieldinit'.
			static TIME_ZONE_INFORMATION()
			{
				Il2CppClassPointerStore<Interop.Kernel32.TIME_ZONE_INFORMATION>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Interop.Kernel32>.NativeClassPtr, "TIME_ZONE_INFORMATION");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Interop.Kernel32.TIME_ZONE_INFORMATION>.NativeClassPtr);
				Interop.Kernel32.TIME_ZONE_INFORMATION.NativeFieldInfoPtr_Bias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.Kernel32.TIME_ZONE_INFORMATION>.NativeClassPtr, "Bias");
				Interop.Kernel32.TIME_ZONE_INFORMATION.NativeFieldInfoPtr_StandardName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.Kernel32.TIME_ZONE_INFORMATION>.NativeClassPtr, "StandardName");
				Interop.Kernel32.TIME_ZONE_INFORMATION.NativeFieldInfoPtr_StandardDate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.Kernel32.TIME_ZONE_INFORMATION>.NativeClassPtr, "StandardDate");
				Interop.Kernel32.TIME_ZONE_INFORMATION.NativeFieldInfoPtr_StandardBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.Kernel32.TIME_ZONE_INFORMATION>.NativeClassPtr, "StandardBias");
				Interop.Kernel32.TIME_ZONE_INFORMATION.NativeFieldInfoPtr_DaylightName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.Kernel32.TIME_ZONE_INFORMATION>.NativeClassPtr, "DaylightName");
				Interop.Kernel32.TIME_ZONE_INFORMATION.NativeFieldInfoPtr_DaylightDate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.Kernel32.TIME_ZONE_INFORMATION>.NativeClassPtr, "DaylightDate");
				Interop.Kernel32.TIME_ZONE_INFORMATION.NativeFieldInfoPtr_DaylightBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.Kernel32.TIME_ZONE_INFORMATION>.NativeClassPtr, "DaylightBias");
				Interop.Kernel32.TIME_ZONE_INFORMATION.NativeMethodInfoPtr__ctor_Internal_Void_byref_TIME_DYNAMIC_ZONE_INFORMATION_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interop.Kernel32.TIME_ZONE_INFORMATION>.NativeClassPtr, 100663336);
				Interop.Kernel32.TIME_ZONE_INFORMATION.NativeMethodInfoPtr_GetStandardName_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interop.Kernel32.TIME_ZONE_INFORMATION>.NativeClassPtr, 100663337);
				Interop.Kernel32.TIME_ZONE_INFORMATION.NativeMethodInfoPtr_GetDaylightName_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interop.Kernel32.TIME_ZONE_INFORMATION>.NativeClassPtr, 100663338);
			}

			// Token: 0x060062DB RID: 25307 RVA: 0x001B9208 File Offset: 0x001B7408
			[CallerCount(0)]
			public unsafe TIME_ZONE_INFORMATION([In] ref Interop.Kernel32.TIME_DYNAMIC_ZONE_INFORMATION dtzi)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &dtzi;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interop.Kernel32.TIME_ZONE_INFORMATION.NativeMethodInfoPtr__ctor_Internal_Void_byref_TIME_DYNAMIC_ZONE_INFORMATION_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060062DC RID: 25308 RVA: 0x001B923C File Offset: 0x001B743C
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1275280, RefRangeEnd = 1275284, XrefRangeStart = 1275279, XrefRangeEnd = 1275280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string GetStandardName()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interop.Kernel32.TIME_ZONE_INFORMATION.NativeMethodInfoPtr_GetStandardName_Internal_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x060062DD RID: 25309 RVA: 0x001B9268 File Offset: 0x001B7468
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1275285, RefRangeEnd = 1275287, XrefRangeStart = 1275284, XrefRangeEnd = 1275285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string GetDaylightName()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interop.Kernel32.TIME_ZONE_INFORMATION.NativeMethodInfoPtr_GetDaylightName_Internal_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x060062DE RID: 25310 RVA: 0x0002501C File Offset: 0x0002321C
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Interop.Kernel32.TIME_ZONE_INFORMATION>.NativeClassPtr, ref this));
			}

			// Token: 0x04004FA2 RID: 20386
			private static readonly IntPtr NativeFieldInfoPtr_Bias;

			// Token: 0x04004FA3 RID: 20387
			private static readonly IntPtr NativeFieldInfoPtr_StandardName;

			// Token: 0x04004FA4 RID: 20388
			private static readonly IntPtr NativeFieldInfoPtr_StandardDate;

			// Token: 0x04004FA5 RID: 20389
			private static readonly IntPtr NativeFieldInfoPtr_StandardBias;

			// Token: 0x04004FA6 RID: 20390
			private static readonly IntPtr NativeFieldInfoPtr_DaylightName;

			// Token: 0x04004FA7 RID: 20391
			private static readonly IntPtr NativeFieldInfoPtr_DaylightDate;

			// Token: 0x04004FA8 RID: 20392
			private static readonly IntPtr NativeFieldInfoPtr_DaylightBias;

			// Token: 0x04004FA9 RID: 20393
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_byref_TIME_DYNAMIC_ZONE_INFORMATION_0;

			// Token: 0x04004FAA RID: 20394
			private static readonly IntPtr NativeMethodInfoPtr_GetStandardName_Internal_String_0;

			// Token: 0x04004FAB RID: 20395
			private static readonly IntPtr NativeMethodInfoPtr_GetDaylightName_Internal_String_0;

			// Token: 0x04004FAC RID: 20396
			[FieldOffset(0)]
			public int Bias;

			// Token: 0x04004FAD RID: 20397
			[FieldOffset(4)]
			public Interop.Kernel32.TIME_ZONE_INFORMATION._StandardName_e__FixedBuffer StandardName;

			// Token: 0x04004FAE RID: 20398
			[FieldOffset(68)]
			public Interop.Kernel32.SYSTEMTIME StandardDate;

			// Token: 0x04004FAF RID: 20399
			[FieldOffset(84)]
			public int StandardBias;

			// Token: 0x04004FB0 RID: 20400
			[FieldOffset(88)]
			public Interop.Kernel32.TIME_ZONE_INFORMATION._DaylightName_e__FixedBuffer DaylightName;

			// Token: 0x04004FB1 RID: 20401
			[FieldOffset(152)]
			public Interop.Kernel32.SYSTEMTIME DaylightDate;

			// Token: 0x04004FB2 RID: 20402
			[FieldOffset(168)]
			public int DaylightBias;

			// Token: 0x0200079B RID: 1947
			[ObfuscatedName("Interop+Kernel32+TIME_ZONE_INFORMATION+<StandardName>e__FixedBuffer")]
			[StructLayout(2, CharSet = 3)]
			public struct _StandardName_e__FixedBuffer
			{
				// Token: 0x06006370 RID: 25456 RVA: 0x00025530 File Offset: 0x00023730
				// Note: this type is marked as 'beforefieldinit'.
				static _StandardName_e__FixedBuffer()
				{
					Il2CppClassPointerStore<Interop.Kernel32.TIME_ZONE_INFORMATION._StandardName_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Interop.Kernel32.TIME_ZONE_INFORMATION>.NativeClassPtr, "<StandardName>e__FixedBuffer");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Interop.Kernel32.TIME_ZONE_INFORMATION._StandardName_e__FixedBuffer>.NativeClassPtr);
					Interop.Kernel32.TIME_ZONE_INFORMATION._StandardName_e__FixedBuffer.NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.Kernel32.TIME_ZONE_INFORMATION._StandardName_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
				}

				// Token: 0x06006371 RID: 25457 RVA: 0x00025564 File Offset: 0x00023764
				public Object BoxIl2CppObject()
				{
					return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Interop.Kernel32.TIME_ZONE_INFORMATION._StandardName_e__FixedBuffer>.NativeClassPtr, ref this));
				}

				// Token: 0x04005122 RID: 20770
				private static readonly IntPtr NativeFieldInfoPtr_FixedElementField;

				// Token: 0x04005123 RID: 20771
				[FieldOffset(0)]
				public char FixedElementField;
			}

			// Token: 0x0200079C RID: 1948
			[ObfuscatedName("Interop+Kernel32+TIME_ZONE_INFORMATION+<DaylightName>e__FixedBuffer")]
			[StructLayout(2, CharSet = 3)]
			public struct _DaylightName_e__FixedBuffer
			{
				// Token: 0x06006372 RID: 25458 RVA: 0x00025576 File Offset: 0x00023776
				// Note: this type is marked as 'beforefieldinit'.
				static _DaylightName_e__FixedBuffer()
				{
					Il2CppClassPointerStore<Interop.Kernel32.TIME_ZONE_INFORMATION._DaylightName_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Interop.Kernel32.TIME_ZONE_INFORMATION>.NativeClassPtr, "<DaylightName>e__FixedBuffer");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Interop.Kernel32.TIME_ZONE_INFORMATION._DaylightName_e__FixedBuffer>.NativeClassPtr);
					Interop.Kernel32.TIME_ZONE_INFORMATION._DaylightName_e__FixedBuffer.NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.Kernel32.TIME_ZONE_INFORMATION._DaylightName_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
				}

				// Token: 0x06006373 RID: 25459 RVA: 0x000255AA File Offset: 0x000237AA
				public Object BoxIl2CppObject()
				{
					return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Interop.Kernel32.TIME_ZONE_INFORMATION._DaylightName_e__FixedBuffer>.NativeClassPtr, ref this));
				}

				// Token: 0x04005124 RID: 20772
				private static readonly IntPtr NativeFieldInfoPtr_FixedElementField;

				// Token: 0x04005125 RID: 20773
				[FieldOffset(0)]
				public char FixedElementField;
			}
		}

		// Token: 0x02000775 RID: 1909
		[StructLayout(2)]
		public struct COPYFILE2_EXTENDED_PARAMETERS
		{
			// Token: 0x060062DF RID: 25311 RVA: 0x001B9294 File Offset: 0x001B7494
			// Note: this type is marked as 'beforefieldinit'.
			static COPYFILE2_EXTENDED_PARAMETERS()
			{
				Il2CppClassPointerStore<Interop.Kernel32.COPYFILE2_EXTENDED_PARAMETERS>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Interop.Kernel32>.NativeClassPtr, "COPYFILE2_EXTENDED_PARAMETERS");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Interop.Kernel32.COPYFILE2_EXTENDED_PARAMETERS>.NativeClassPtr);
				Interop.Kernel32.COPYFILE2_EXTENDED_PARAMETERS.NativeFieldInfoPtr_dwSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.Kernel32.COPYFILE2_EXTENDED_PARAMETERS>.NativeClassPtr, "dwSize");
				Interop.Kernel32.COPYFILE2_EXTENDED_PARAMETERS.NativeFieldInfoPtr_dwCopyFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.Kernel32.COPYFILE2_EXTENDED_PARAMETERS>.NativeClassPtr, "dwCopyFlags");
				Interop.Kernel32.COPYFILE2_EXTENDED_PARAMETERS.NativeFieldInfoPtr_pfCancel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.Kernel32.COPYFILE2_EXTENDED_PARAMETERS>.NativeClassPtr, "pfCancel");
				Interop.Kernel32.COPYFILE2_EXTENDED_PARAMETERS.NativeFieldInfoPtr_pProgressRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.Kernel32.COPYFILE2_EXTENDED_PARAMETERS>.NativeClassPtr, "pProgressRoutine");
				Interop.Kernel32.COPYFILE2_EXTENDED_PARAMETERS.NativeFieldInfoPtr_pvCallbackContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.Kernel32.COPYFILE2_EXTENDED_PARAMETERS>.NativeClassPtr, "pvCallbackContext");
			}

			// Token: 0x060062E0 RID: 25312 RVA: 0x0002502E File Offset: 0x0002322E
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Interop.Kernel32.COPYFILE2_EXTENDED_PARAMETERS>.NativeClassPtr, ref this));
			}

			// Token: 0x04004FB3 RID: 20403
			private static readonly IntPtr NativeFieldInfoPtr_dwSize;

			// Token: 0x04004FB4 RID: 20404
			private static readonly IntPtr NativeFieldInfoPtr_dwCopyFlags;

			// Token: 0x04004FB5 RID: 20405
			private static readonly IntPtr NativeFieldInfoPtr_pfCancel;

			// Token: 0x04004FB6 RID: 20406
			private static readonly IntPtr NativeFieldInfoPtr_pProgressRoutine;

			// Token: 0x04004FB7 RID: 20407
			private static readonly IntPtr NativeFieldInfoPtr_pvCallbackContext;

			// Token: 0x04004FB8 RID: 20408
			[FieldOffset(0)]
			public uint dwSize;

			// Token: 0x04004FB9 RID: 20409
			[FieldOffset(4)]
			public uint dwCopyFlags;

			// Token: 0x04004FBA RID: 20410
			[FieldOffset(8)]
			public IntPtr pfCancel;

			// Token: 0x04004FBB RID: 20411
			[FieldOffset(16)]
			public IntPtr pProgressRoutine;

			// Token: 0x04004FBC RID: 20412
			[FieldOffset(24)]
			public IntPtr pvCallbackContext;
		}

		// Token: 0x02000776 RID: 1910
		public enum FILE_INFO_BY_HANDLE_CLASS : uint
		{
			// Token: 0x04004FBE RID: 20414
			FileBasicInfo,
			// Token: 0x04004FBF RID: 20415
			FileStandardInfo,
			// Token: 0x04004FC0 RID: 20416
			FileNameInfo,
			// Token: 0x04004FC1 RID: 20417
			FileRenameInfo,
			// Token: 0x04004FC2 RID: 20418
			FileDispositionInfo,
			// Token: 0x04004FC3 RID: 20419
			FileAllocationInfo,
			// Token: 0x04004FC4 RID: 20420
			FileEndOfFileInfo,
			// Token: 0x04004FC5 RID: 20421
			FileStreamInfo,
			// Token: 0x04004FC6 RID: 20422
			FileCompressionInfo,
			// Token: 0x04004FC7 RID: 20423
			FileAttributeTagInfo,
			// Token: 0x04004FC8 RID: 20424
			FileIdBothDirectoryInfo,
			// Token: 0x04004FC9 RID: 20425
			FileIdBothDirectoryRestartInfo,
			// Token: 0x04004FCA RID: 20426
			FileIoPriorityHintInfo,
			// Token: 0x04004FCB RID: 20427
			FileRemoteProtocolInfo,
			// Token: 0x04004FCC RID: 20428
			FileFullDirectoryInfo,
			// Token: 0x04004FCD RID: 20429
			FileFullDirectoryRestartInfo
		}

		// Token: 0x02000777 RID: 1911
		[StructLayout(2)]
		public struct FILE_TIME
		{
			// Token: 0x060062E1 RID: 25313 RVA: 0x001B9324 File Offset: 0x001B7524
			// Note: this type is marked as 'beforefieldinit'.
			static FILE_TIME()
			{
				Il2CppClassPointerStore<Interop.Kernel32.FILE_TIME>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Interop.Kernel32>.NativeClassPtr, "FILE_TIME");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Interop.Kernel32.FILE_TIME>.NativeClassPtr);
				Interop.Kernel32.FILE_TIME.NativeFieldInfoPtr_dwLowDateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.Kernel32.FILE_TIME>.NativeClassPtr, "dwLowDateTime");
				Interop.Kernel32.FILE_TIME.NativeFieldInfoPtr_dwHighDateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.Kernel32.FILE_TIME>.NativeClassPtr, "dwHighDateTime");
				Interop.Kernel32.FILE_TIME.NativeMethodInfoPtr_ToTicks_Internal_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interop.Kernel32.FILE_TIME>.NativeClassPtr, 100663339);
				Interop.Kernel32.FILE_TIME.NativeMethodInfoPtr_ToDateTimeOffset_Internal_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interop.Kernel32.FILE_TIME>.NativeClassPtr, 100663340);
			}

			// Token: 0x060062E2 RID: 25314 RVA: 0x001B93A0 File Offset: 0x001B75A0
			[CallerCount(0)]
			public unsafe long ToTicks()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interop.Kernel32.FILE_TIME.NativeMethodInfoPtr_ToTicks_Internal_Int64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060062E3 RID: 25315 RVA: 0x001B93D0 File Offset: 0x001B75D0
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1275291, RefRangeEnd = 1275293, XrefRangeStart = 1275287, XrefRangeEnd = 1275291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DateTimeOffset ToDateTimeOffset()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interop.Kernel32.FILE_TIME.NativeMethodInfoPtr_ToDateTimeOffset_Internal_DateTimeOffset_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060062E4 RID: 25316 RVA: 0x00025040 File Offset: 0x00023240
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Interop.Kernel32.FILE_TIME>.NativeClassPtr, ref this));
			}

			// Token: 0x04004FCE RID: 20430
			private static readonly IntPtr NativeFieldInfoPtr_dwLowDateTime;

			// Token: 0x04004FCF RID: 20431
			private static readonly IntPtr NativeFieldInfoPtr_dwHighDateTime;

			// Token: 0x04004FD0 RID: 20432
			private static readonly IntPtr NativeMethodInfoPtr_ToTicks_Internal_Int64_0;

			// Token: 0x04004FD1 RID: 20433
			private static readonly IntPtr NativeMethodInfoPtr_ToDateTimeOffset_Internal_DateTimeOffset_0;

			// Token: 0x04004FD2 RID: 20434
			[FieldOffset(0)]
			public uint dwLowDateTime;

			// Token: 0x04004FD3 RID: 20435
			[FieldOffset(4)]
			public uint dwHighDateTime;
		}

		// Token: 0x02000778 RID: 1912
		public enum FINDEX_INFO_LEVELS : uint
		{
			// Token: 0x04004FD5 RID: 20437
			FindExInfoStandard,
			// Token: 0x04004FD6 RID: 20438
			FindExInfoBasic,
			// Token: 0x04004FD7 RID: 20439
			FindExInfoMaxInfoLevel
		}

		// Token: 0x02000779 RID: 1913
		public enum FINDEX_SEARCH_OPS : uint
		{
			// Token: 0x04004FD9 RID: 20441
			FindExSearchNameMatch,
			// Token: 0x04004FDA RID: 20442
			FindExSearchLimitToDirectories,
			// Token: 0x04004FDB RID: 20443
			FindExSearchLimitToDevices,
			// Token: 0x04004FDC RID: 20444
			FindExSearchMaxSearchOp
		}

		// Token: 0x0200077A RID: 1914
		public enum GET_FILEEX_INFO_LEVELS : uint
		{
			// Token: 0x04004FDE RID: 20446
			GetFileExInfoStandard,
			// Token: 0x04004FDF RID: 20447
			GetFileExMaxInfoLevel
		}

		// Token: 0x0200077B RID: 1915
		[StructLayout(2)]
		public struct SECURITY_ATTRIBUTES
		{
			// Token: 0x060062E5 RID: 25317 RVA: 0x001B9400 File Offset: 0x001B7600
			// Note: this type is marked as 'beforefieldinit'.
			static SECURITY_ATTRIBUTES()
			{
				Il2CppClassPointerStore<Interop.Kernel32.SECURITY_ATTRIBUTES>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Interop.Kernel32>.NativeClassPtr, "SECURITY_ATTRIBUTES");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Interop.Kernel32.SECURITY_ATTRIBUTES>.NativeClassPtr);
				Interop.Kernel32.SECURITY_ATTRIBUTES.NativeFieldInfoPtr_nLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.Kernel32.SECURITY_ATTRIBUTES>.NativeClassPtr, "nLength");
				Interop.Kernel32.SECURITY_ATTRIBUTES.NativeFieldInfoPtr_lpSecurityDescriptor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.Kernel32.SECURITY_ATTRIBUTES>.NativeClassPtr, "lpSecurityDescriptor");
				Interop.Kernel32.SECURITY_ATTRIBUTES.NativeFieldInfoPtr_bInheritHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.Kernel32.SECURITY_ATTRIBUTES>.NativeClassPtr, "bInheritHandle");
			}

			// Token: 0x060062E6 RID: 25318 RVA: 0x00025052 File Offset: 0x00023252
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Interop.Kernel32.SECURITY_ATTRIBUTES>.NativeClassPtr, ref this));
			}

			// Token: 0x04004FE0 RID: 20448
			private static readonly IntPtr NativeFieldInfoPtr_nLength;

			// Token: 0x04004FE1 RID: 20449
			private static readonly IntPtr NativeFieldInfoPtr_lpSecurityDescriptor;

			// Token: 0x04004FE2 RID: 20450
			private static readonly IntPtr NativeFieldInfoPtr_bInheritHandle;

			// Token: 0x04004FE3 RID: 20451
			[FieldOffset(0)]
			public uint nLength;

			// Token: 0x04004FE4 RID: 20452
			[FieldOffset(8)]
			public IntPtr lpSecurityDescriptor;

			// Token: 0x04004FE5 RID: 20453
			[FieldOffset(16)]
			public Interop.BOOL bInheritHandle;
		}

		// Token: 0x0200077C RID: 1916
		[StructLayout(2)]
		public struct WIN32_FILE_ATTRIBUTE_DATA
		{
			// Token: 0x060062E7 RID: 25319 RVA: 0x001B9468 File Offset: 0x001B7668
			// Note: this type is marked as 'beforefieldinit'.
			static WIN32_FILE_ATTRIBUTE_DATA()
			{
				Il2CppClassPointerStore<Interop.Kernel32.WIN32_FILE_ATTRIBUTE_DATA>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Interop.Kernel32>.NativeClassPtr, "WIN32_FILE_ATTRIBUTE_DATA");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Interop.Kernel32.WIN32_FILE_ATTRIBUTE_DATA>.NativeClassPtr);
				Interop.Kernel32.WIN32_FILE_ATTRIBUTE_DATA.NativeFieldInfoPtr_dwFileAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.Kernel32.WIN32_FILE_ATTRIBUTE_DATA>.NativeClassPtr, "dwFileAttributes");
				Interop.Kernel32.WIN32_FILE_ATTRIBUTE_DATA.NativeFieldInfoPtr_ftCreationTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.Kernel32.WIN32_FILE_ATTRIBUTE_DATA>.NativeClassPtr, "ftCreationTime");
				Interop.Kernel32.WIN32_FILE_ATTRIBUTE_DATA.NativeFieldInfoPtr_ftLastAccessTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.Kernel32.WIN32_FILE_ATTRIBUTE_DATA>.NativeClassPtr, "ftLastAccessTime");
				Interop.Kernel32.WIN32_FILE_ATTRIBUTE_DATA.NativeFieldInfoPtr_ftLastWriteTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.Kernel32.WIN32_FILE_ATTRIBUTE_DATA>.NativeClassPtr, "ftLastWriteTime");
				Interop.Kernel32.WIN32_FILE_ATTRIBUTE_DATA.NativeFieldInfoPtr_nFileSizeHigh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.Kernel32.WIN32_FILE_ATTRIBUTE_DATA>.NativeClassPtr, "nFileSizeHigh");
				Interop.Kernel32.WIN32_FILE_ATTRIBUTE_DATA.NativeFieldInfoPtr_nFileSizeLow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.Kernel32.WIN32_FILE_ATTRIBUTE_DATA>.NativeClassPtr, "nFileSizeLow");
				Interop.Kernel32.WIN32_FILE_ATTRIBUTE_DATA.NativeMethodInfoPtr_PopulateFrom_Internal_Void_byref_WIN32_FIND_DATA_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interop.Kernel32.WIN32_FILE_ATTRIBUTE_DATA>.NativeClassPtr, 100663341);
			}

			// Token: 0x060062E8 RID: 25320 RVA: 0x001B9520 File Offset: 0x001B7720
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1275293, RefRangeEnd = 1275294, XrefRangeStart = 1275293, XrefRangeEnd = 1275293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void PopulateFrom(ref Interop.Kernel32.WIN32_FIND_DATA findData)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &findData;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interop.Kernel32.WIN32_FILE_ATTRIBUTE_DATA.NativeMethodInfoPtr_PopulateFrom_Internal_Void_byref_WIN32_FIND_DATA_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060062E9 RID: 25321 RVA: 0x00025064 File Offset: 0x00023264
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Interop.Kernel32.WIN32_FILE_ATTRIBUTE_DATA>.NativeClassPtr, ref this));
			}

			// Token: 0x04004FE6 RID: 20454
			private static readonly IntPtr NativeFieldInfoPtr_dwFileAttributes;

			// Token: 0x04004FE7 RID: 20455
			private static readonly IntPtr NativeFieldInfoPtr_ftCreationTime;

			// Token: 0x04004FE8 RID: 20456
			private static readonly IntPtr NativeFieldInfoPtr_ftLastAccessTime;

			// Token: 0x04004FE9 RID: 20457
			private static readonly IntPtr NativeFieldInfoPtr_ftLastWriteTime;

			// Token: 0x04004FEA RID: 20458
			private static readonly IntPtr NativeFieldInfoPtr_nFileSizeHigh;

			// Token: 0x04004FEB RID: 20459
			private static readonly IntPtr NativeFieldInfoPtr_nFileSizeLow;

			// Token: 0x04004FEC RID: 20460
			private static readonly IntPtr NativeMethodInfoPtr_PopulateFrom_Internal_Void_byref_WIN32_FIND_DATA_0;

			// Token: 0x04004FED RID: 20461
			[FieldOffset(0)]
			public int dwFileAttributes;

			// Token: 0x04004FEE RID: 20462
			[FieldOffset(4)]
			public Interop.Kernel32.FILE_TIME ftCreationTime;

			// Token: 0x04004FEF RID: 20463
			[FieldOffset(12)]
			public Interop.Kernel32.FILE_TIME ftLastAccessTime;

			// Token: 0x04004FF0 RID: 20464
			[FieldOffset(20)]
			public Interop.Kernel32.FILE_TIME ftLastWriteTime;

			// Token: 0x04004FF1 RID: 20465
			[FieldOffset(28)]
			public uint nFileSizeHigh;

			// Token: 0x04004FF2 RID: 20466
			[FieldOffset(32)]
			public uint nFileSizeLow;
		}
	}

	// Token: 0x02000558 RID: 1368
	public class BCrypt : Object
	{
		// Token: 0x0600556D RID: 21869 RVA: 0x0001E4D1 File Offset: 0x0001C6D1
		// Note: this type is marked as 'beforefieldinit'.
		static BCrypt()
		{
			Il2CppClassPointerStore<Interop.BCrypt>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Interop>.NativeClassPtr, "BCrypt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Interop.BCrypt>.NativeClassPtr);
			Interop.BCrypt.NativeMethodInfoPtr_BCryptGenRandom_Internal_Static_NTSTATUS_IntPtr_ptr_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interop.BCrypt>.NativeClassPtr, 100663342);
		}

		// Token: 0x0600556E RID: 21870 RVA: 0x0018AC24 File Offset: 0x00188E24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275540, XrefRangeEnd = 1275542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Interop.BCrypt.NTSTATUS BCryptGenRandom(IntPtr hAlgorithm, byte* pbBuffer, int cbBuffer, int dwFlags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hAlgorithm;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = pbBuffer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbBuffer;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dwFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interop.BCrypt.NativeMethodInfoPtr_BCryptGenRandom_Internal_Static_NTSTATUS_IntPtr_ptr_Byte_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600556F RID: 21871 RVA: 0x0001E505 File Offset: 0x0001C705
		public BCrypt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04004589 RID: 17801
		private static readonly IntPtr NativeMethodInfoPtr_BCryptGenRandom_Internal_Static_NTSTATUS_IntPtr_ptr_Byte_Int32_Int32_0;

		// Token: 0x0200077D RID: 1917
		public enum NTSTATUS : uint
		{
			// Token: 0x04004FF4 RID: 20468
			STATUS_SUCCESS,
			// Token: 0x04004FF5 RID: 20469
			STATUS_NOT_FOUND = 3221226021U,
			// Token: 0x04004FF6 RID: 20470
			STATUS_INVALID_PARAMETER = 3221225485U,
			// Token: 0x04004FF7 RID: 20471
			STATUS_NO_MEMORY = 3221225495U
		}
	}

	// Token: 0x02000559 RID: 1369
	public class User32 : Object
	{
		// Token: 0x06005570 RID: 21872 RVA: 0x0001E50E File Offset: 0x0001C70E
		// Note: this type is marked as 'beforefieldinit'.
		static User32()
		{
			Il2CppClassPointerStore<Interop.User32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Interop>.NativeClassPtr, "User32");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Interop.User32>.NativeClassPtr);
			Interop.User32.NativeMethodInfoPtr_LoadString_Internal_Static_Int32_SafeLibraryHandle_Int32_StringBuilder_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interop.User32>.NativeClassPtr, 100663343);
		}

		// Token: 0x06005571 RID: 21873 RVA: 0x0018AC8C File Offset: 0x00188E8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1275549, RefRangeEnd = 1275550, XrefRangeStart = 1275542, XrefRangeEnd = 1275549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int LoadString(SafeLibraryHandle handle, int id, [Out] StringBuilder buffer, int bufferLength)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferLength;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Interop.User32.NativeMethodInfoPtr_LoadString_Internal_Static_Int32_SafeLibraryHandle_Int32_StringBuilder_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*buffer = ((intPtr4 == 0) ? null : new StringBuilder(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06005572 RID: 21874 RVA: 0x0001E542 File Offset: 0x0001C742
		public User32(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400458A RID: 17802
		private static readonly IntPtr NativeMethodInfoPtr_LoadString_Internal_Static_Int32_SafeLibraryHandle_Int32_StringBuilder_Int32_0;
	}

	// Token: 0x0200055A RID: 1370
	public enum BOOL
	{
		// Token: 0x0400458C RID: 17804
		FALSE,
		// Token: 0x0400458D RID: 17805
		TRUE
	}

	// Token: 0x0200055B RID: 1371
	public enum BOOLEAN : byte
	{
		// Token: 0x0400458F RID: 17807
		FALSE,
		// Token: 0x04004590 RID: 17808
		TRUE
	}

	// Token: 0x0200055C RID: 1372
	[StructLayout(2)]
	public struct LongFileTime
	{
		// Token: 0x06005573 RID: 21875 RVA: 0x0001E54B File Offset: 0x0001C74B
		// Note: this type is marked as 'beforefieldinit'.
		static LongFileTime()
		{
			Il2CppClassPointerStore<Interop.LongFileTime>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Interop>.NativeClassPtr, "LongFileTime");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Interop.LongFileTime>.NativeClassPtr);
			Interop.LongFileTime.NativeFieldInfoPtr_TicksSince1601 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.LongFileTime>.NativeClassPtr, "TicksSince1601");
		}

		// Token: 0x06005574 RID: 21876 RVA: 0x0001E57F File Offset: 0x0001C77F
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Interop.LongFileTime>.NativeClassPtr, ref this));
		}

		// Token: 0x04004591 RID: 17809
		private static readonly IntPtr NativeFieldInfoPtr_TicksSince1601;

		// Token: 0x04004592 RID: 17810
		[FieldOffset(0)]
		public long TicksSince1601;
	}

	// Token: 0x0200055D RID: 1373
	[StructLayout(2)]
	public struct UNICODE_STRING
	{
		// Token: 0x06005575 RID: 21877 RVA: 0x0018AD0C File Offset: 0x00188F0C
		// Note: this type is marked as 'beforefieldinit'.
		static UNICODE_STRING()
		{
			Il2CppClassPointerStore<Interop.UNICODE_STRING>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Interop>.NativeClassPtr, "UNICODE_STRING");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Interop.UNICODE_STRING>.NativeClassPtr);
			Interop.UNICODE_STRING.NativeFieldInfoPtr_Length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.UNICODE_STRING>.NativeClassPtr, "Length");
			Interop.UNICODE_STRING.NativeFieldInfoPtr_MaximumLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.UNICODE_STRING>.NativeClassPtr, "MaximumLength");
			Interop.UNICODE_STRING.NativeFieldInfoPtr_Buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.UNICODE_STRING>.NativeClassPtr, "Buffer");
		}

		// Token: 0x06005576 RID: 21878 RVA: 0x0001E591 File Offset: 0x0001C791
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Interop.UNICODE_STRING>.NativeClassPtr, ref this));
		}

		// Token: 0x04004593 RID: 17811
		private static readonly IntPtr NativeFieldInfoPtr_Length;

		// Token: 0x04004594 RID: 17812
		private static readonly IntPtr NativeFieldInfoPtr_MaximumLength;

		// Token: 0x04004595 RID: 17813
		private static readonly IntPtr NativeFieldInfoPtr_Buffer;

		// Token: 0x04004596 RID: 17814
		[FieldOffset(0)]
		public ushort Length;

		// Token: 0x04004597 RID: 17815
		[FieldOffset(2)]
		public ushort MaximumLength;

		// Token: 0x04004598 RID: 17816
		[FieldOffset(8)]
		public IntPtr Buffer;
	}

	// Token: 0x0200055E RID: 1374
	public class NtDll : Object
	{
		// Token: 0x06005577 RID: 21879 RVA: 0x0018AD74 File Offset: 0x00188F74
		// Note: this type is marked as 'beforefieldinit'.
		static NtDll()
		{
			Il2CppClassPointerStore<Interop.NtDll>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Interop>.NativeClassPtr, "NtDll");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Interop.NtDll>.NativeClassPtr);
			Interop.NtDll.NativeMethodInfoPtr_NtCreateFile_Private_Static_Int32_byref_IntPtr_DesiredAccess_byref_OBJECT_ATTRIBUTES_byref_IO_STATUS_BLOCK_ptr_Int64_FileAttributes_FileShare_CreateDisposition_CreateOptions_ptr_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interop.NtDll>.NativeClassPtr, 100663344);
			Interop.NtDll.NativeMethodInfoPtr_CreateFile_Internal_Static_ValueTuple_2_Int32_IntPtr_ReadOnlySpan_1_Char_IntPtr_CreateDisposition_DesiredAccess_FileShare_FileAttributes_CreateOptions_ObjectAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interop.NtDll>.NativeClassPtr, 100663345);
			Interop.NtDll.NativeMethodInfoPtr_NtQueryDirectoryFile_Public_Static_Int32_IntPtr_IntPtr_IntPtr_IntPtr_byref_IO_STATUS_BLOCK_IntPtr_UInt32_FILE_INFORMATION_CLASS_BOOLEAN_ptr_UNICODE_STRING_BOOLEAN_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interop.NtDll>.NativeClassPtr, 100663346);
			Interop.NtDll.NativeMethodInfoPtr_RtlNtStatusToDosError_Public_Static_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interop.NtDll>.NativeClassPtr, 100663347);
		}

		// Token: 0x06005578 RID: 21880 RVA: 0x0018ADF0 File Offset: 0x00188FF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275565, XrefRangeEnd = 1275567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int NtCreateFile(out IntPtr FileHandle, Interop.NtDll.DesiredAccess DesiredAccess, ref Interop.NtDll.OBJECT_ATTRIBUTES ObjectAttributes, out Interop.NtDll.IO_STATUS_BLOCK IoStatusBlock, long* AllocationSize, FileAttributes FileAttributes, FileShare ShareAccess, Interop.NtDll.CreateDisposition CreateDisposition, Interop.NtDll.CreateOptions CreateOptions, void* EaBuffer, uint EaLength)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &FileHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref DesiredAccess;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ObjectAttributes;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &IoStatusBlock;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = AllocationSize;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref FileAttributes;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ShareAccess;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref CreateDisposition;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref CreateOptions;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = EaBuffer;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref EaLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interop.NtDll.NativeMethodInfoPtr_NtCreateFile_Private_Static_Int32_byref_IntPtr_DesiredAccess_byref_OBJECT_ATTRIBUTES_byref_IO_STATUS_BLOCK_ptr_Int64_FileAttributes_FileShare_CreateDisposition_CreateOptions_ptr_Void_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005579 RID: 21881 RVA: 0x0018AEBC File Offset: 0x001890BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1275578, RefRangeEnd = 1275580, XrefRangeStart = 1275567, XrefRangeEnd = 1275578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ValueTuple<int, IntPtr> CreateFile(ReadOnlySpan<char> path, IntPtr rootDirectory, Interop.NtDll.CreateDisposition createDisposition, Interop.NtDll.DesiredAccess desiredAccess = Interop.NtDll.DesiredAccess.SYNCHRONIZE | Interop.NtDll.DesiredAccess.FILE_GENERIC_READ, FileShare shareAccess = FileShare.Read | FileShare.Write | FileShare.Delete, FileAttributes fileAttributes = (FileAttributes)0, Interop.NtDll.CreateOptions createOptions = Interop.NtDll.CreateOptions.FILE_SYNCHRONOUS_IO_NONALERT, Interop.NtDll.ObjectAttributes objectAttributes = Interop.NtDll.ObjectAttributes.OBJ_CASE_INSENSITIVE)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(path));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rootDirectory;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref createDisposition;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref desiredAccess;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shareAccess;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fileAttributes;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref createOptions;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref objectAttributes;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interop.NtDll.NativeMethodInfoPtr_CreateFile_Internal_Static_ValueTuple_2_Int32_IntPtr_ReadOnlySpan_1_Char_IntPtr_CreateDisposition_DesiredAccess_FileShare_FileAttributes_CreateOptions_ObjectAttributes_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ValueTuple<int, IntPtr>(intPtr);
		}

		// Token: 0x0600557A RID: 21882 RVA: 0x0018AF60 File Offset: 0x00189160
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1275582, RefRangeEnd = 1275585, XrefRangeStart = 1275580, XrefRangeEnd = 1275582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int NtQueryDirectoryFile(IntPtr FileHandle, IntPtr Event, IntPtr ApcRoutine, IntPtr ApcContext, out Interop.NtDll.IO_STATUS_BLOCK IoStatusBlock, IntPtr FileInformation, uint Length, Interop.NtDll.FILE_INFORMATION_CLASS FileInformationClass, Interop.BOOLEAN ReturnSingleEntry, Interop.UNICODE_STRING* FileName, Interop.BOOLEAN RestartScan)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref FileHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Event;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ApcRoutine;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ApcContext;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &IoStatusBlock;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref FileInformation;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Length;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref FileInformationClass;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ReturnSingleEntry;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = FileName;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref RestartScan;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interop.NtDll.NativeMethodInfoPtr_NtQueryDirectoryFile_Public_Static_Int32_IntPtr_IntPtr_IntPtr_IntPtr_byref_IO_STATUS_BLOCK_IntPtr_UInt32_FILE_INFORMATION_CLASS_BOOLEAN_ptr_UNICODE_STRING_BOOLEAN_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600557B RID: 21883 RVA: 0x0018B030 File Offset: 0x00189230
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1275587, RefRangeEnd = 1275591, XrefRangeStart = 1275585, XrefRangeEnd = 1275587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint RtlNtStatusToDosError(int Status)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref Status;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interop.NtDll.NativeMethodInfoPtr_RtlNtStatusToDosError_Public_Static_UInt32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600557C RID: 21884 RVA: 0x0001E5A3 File Offset: 0x0001C7A3
		public NtDll(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04004599 RID: 17817
		private static readonly IntPtr NativeMethodInfoPtr_NtCreateFile_Private_Static_Int32_byref_IntPtr_DesiredAccess_byref_OBJECT_ATTRIBUTES_byref_IO_STATUS_BLOCK_ptr_Int64_FileAttributes_FileShare_CreateDisposition_CreateOptions_ptr_Void_UInt32_0;

		// Token: 0x0400459A RID: 17818
		private static readonly IntPtr NativeMethodInfoPtr_CreateFile_Internal_Static_ValueTuple_2_Int32_IntPtr_ReadOnlySpan_1_Char_IntPtr_CreateDisposition_DesiredAccess_FileShare_FileAttributes_CreateOptions_ObjectAttributes_0;

		// Token: 0x0400459B RID: 17819
		private static readonly IntPtr NativeMethodInfoPtr_NtQueryDirectoryFile_Public_Static_Int32_IntPtr_IntPtr_IntPtr_IntPtr_byref_IO_STATUS_BLOCK_IntPtr_UInt32_FILE_INFORMATION_CLASS_BOOLEAN_ptr_UNICODE_STRING_BOOLEAN_0;

		// Token: 0x0400459C RID: 17820
		private static readonly IntPtr NativeMethodInfoPtr_RtlNtStatusToDosError_Public_Static_UInt32_Int32_0;

		// Token: 0x0200077E RID: 1918
		[StructLayout(2, CharSet = 3)]
		public struct FILE_FULL_DIR_INFORMATION
		{
			// Token: 0x060062EA RID: 25322 RVA: 0x001B9554 File Offset: 0x001B7754
			// Note: this type is marked as 'beforefieldinit'.
			static FILE_FULL_DIR_INFORMATION()
			{
				Il2CppClassPointerStore<Interop.NtDll.FILE_FULL_DIR_INFORMATION>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Interop.NtDll>.NativeClassPtr, "FILE_FULL_DIR_INFORMATION");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Interop.NtDll.FILE_FULL_DIR_INFORMATION>.NativeClassPtr);
				Interop.NtDll.FILE_FULL_DIR_INFORMATION.NativeFieldInfoPtr_NextEntryOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.NtDll.FILE_FULL_DIR_INFORMATION>.NativeClassPtr, "NextEntryOffset");
				Interop.NtDll.FILE_FULL_DIR_INFORMATION.NativeFieldInfoPtr_FileIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.NtDll.FILE_FULL_DIR_INFORMATION>.NativeClassPtr, "FileIndex");
				Interop.NtDll.FILE_FULL_DIR_INFORMATION.NativeFieldInfoPtr_CreationTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.NtDll.FILE_FULL_DIR_INFORMATION>.NativeClassPtr, "CreationTime");
				Interop.NtDll.FILE_FULL_DIR_INFORMATION.NativeFieldInfoPtr_LastAccessTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.NtDll.FILE_FULL_DIR_INFORMATION>.NativeClassPtr, "LastAccessTime");
				Interop.NtDll.FILE_FULL_DIR_INFORMATION.NativeFieldInfoPtr_LastWriteTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.NtDll.FILE_FULL_DIR_INFORMATION>.NativeClassPtr, "LastWriteTime");
				Interop.NtDll.FILE_FULL_DIR_INFORMATION.NativeFieldInfoPtr_ChangeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.NtDll.FILE_FULL_DIR_INFORMATION>.NativeClassPtr, "ChangeTime");
				Interop.NtDll.FILE_FULL_DIR_INFORMATION.NativeFieldInfoPtr_EndOfFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.NtDll.FILE_FULL_DIR_INFORMATION>.NativeClassPtr, "EndOfFile");
				Interop.NtDll.FILE_FULL_DIR_INFORMATION.NativeFieldInfoPtr_AllocationSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.NtDll.FILE_FULL_DIR_INFORMATION>.NativeClassPtr, "AllocationSize");
				Interop.NtDll.FILE_FULL_DIR_INFORMATION.NativeFieldInfoPtr_FileAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.NtDll.FILE_FULL_DIR_INFORMATION>.NativeClassPtr, "FileAttributes");
				Interop.NtDll.FILE_FULL_DIR_INFORMATION.NativeFieldInfoPtr_FileNameLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.NtDll.FILE_FULL_DIR_INFORMATION>.NativeClassPtr, "FileNameLength");
				Interop.NtDll.FILE_FULL_DIR_INFORMATION.NativeFieldInfoPtr_EaSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.NtDll.FILE_FULL_DIR_INFORMATION>.NativeClassPtr, "EaSize");
				Interop.NtDll.FILE_FULL_DIR_INFORMATION.NativeFieldInfoPtr__fileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.NtDll.FILE_FULL_DIR_INFORMATION>.NativeClassPtr, "_fileName");
				Interop.NtDll.FILE_FULL_DIR_INFORMATION.NativeMethodInfoPtr_get_FileName_Public_get_ReadOnlySpan_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interop.NtDll.FILE_FULL_DIR_INFORMATION>.NativeClassPtr, 100663348);
				Interop.NtDll.FILE_FULL_DIR_INFORMATION.NativeMethodInfoPtr_GetNextInfo_Public_Static_ptr_FILE_FULL_DIR_INFORMATION_ptr_FILE_FULL_DIR_INFORMATION_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interop.NtDll.FILE_FULL_DIR_INFORMATION>.NativeClassPtr, 100663349);
			}

			// Token: 0x1700198D RID: 6541
			// (get) Token: 0x060062EB RID: 25323 RVA: 0x001B9698 File Offset: 0x001B7898
			public unsafe ReadOnlySpan<char> FileName
			{
				[CallerCount(11)]
				[CachedScanResults(RefRangeStart = 1275552, RefRangeEnd = 1275563, XrefRangeStart = 1275550, XrefRangeEnd = 1275552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interop.NtDll.FILE_FULL_DIR_INFORMATION.NativeMethodInfoPtr_get_FileName_Public_get_ReadOnlySpan_1_Char_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ReadOnlySpan<char>(intPtr);
				}
			}

			// Token: 0x060062EC RID: 25324 RVA: 0x001B96C4 File Offset: 0x001B78C4
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1275563, RefRangeEnd = 1275565, XrefRangeStart = 1275563, XrefRangeEnd = 1275563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static Interop.NtDll.FILE_FULL_DIR_INFORMATION* GetNextInfo(Interop.NtDll.FILE_FULL_DIR_INFORMATION* info)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = info;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interop.NtDll.FILE_FULL_DIR_INFORMATION.NativeMethodInfoPtr_GetNextInfo_Public_Static_ptr_FILE_FULL_DIR_INFORMATION_ptr_FILE_FULL_DIR_INFORMATION_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return intPtr;
				}
			}

			// Token: 0x060062ED RID: 25325 RVA: 0x00025076 File Offset: 0x00023276
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Interop.NtDll.FILE_FULL_DIR_INFORMATION>.NativeClassPtr, ref this));
			}

			// Token: 0x04004FF8 RID: 20472
			private static readonly IntPtr NativeFieldInfoPtr_NextEntryOffset;

			// Token: 0x04004FF9 RID: 20473
			private static readonly IntPtr NativeFieldInfoPtr_FileIndex;

			// Token: 0x04004FFA RID: 20474
			private static readonly IntPtr NativeFieldInfoPtr_CreationTime;

			// Token: 0x04004FFB RID: 20475
			private static readonly IntPtr NativeFieldInfoPtr_LastAccessTime;

			// Token: 0x04004FFC RID: 20476
			private static readonly IntPtr NativeFieldInfoPtr_LastWriteTime;

			// Token: 0x04004FFD RID: 20477
			private static readonly IntPtr NativeFieldInfoPtr_ChangeTime;

			// Token: 0x04004FFE RID: 20478
			private static readonly IntPtr NativeFieldInfoPtr_EndOfFile;

			// Token: 0x04004FFF RID: 20479
			private static readonly IntPtr NativeFieldInfoPtr_AllocationSize;

			// Token: 0x04005000 RID: 20480
			private static readonly IntPtr NativeFieldInfoPtr_FileAttributes;

			// Token: 0x04005001 RID: 20481
			private static readonly IntPtr NativeFieldInfoPtr_FileNameLength;

			// Token: 0x04005002 RID: 20482
			private static readonly IntPtr NativeFieldInfoPtr_EaSize;

			// Token: 0x04005003 RID: 20483
			private static readonly IntPtr NativeFieldInfoPtr__fileName;

			// Token: 0x04005004 RID: 20484
			private static readonly IntPtr NativeMethodInfoPtr_get_FileName_Public_get_ReadOnlySpan_1_Char_0;

			// Token: 0x04005005 RID: 20485
			private static readonly IntPtr NativeMethodInfoPtr_GetNextInfo_Public_Static_ptr_FILE_FULL_DIR_INFORMATION_ptr_FILE_FULL_DIR_INFORMATION_0;

			// Token: 0x04005006 RID: 20486
			[FieldOffset(0)]
			public uint NextEntryOffset;

			// Token: 0x04005007 RID: 20487
			[FieldOffset(4)]
			public uint FileIndex;

			// Token: 0x04005008 RID: 20488
			[FieldOffset(8)]
			public Interop.LongFileTime CreationTime;

			// Token: 0x04005009 RID: 20489
			[FieldOffset(16)]
			public Interop.LongFileTime LastAccessTime;

			// Token: 0x0400500A RID: 20490
			[FieldOffset(24)]
			public Interop.LongFileTime LastWriteTime;

			// Token: 0x0400500B RID: 20491
			[FieldOffset(32)]
			public Interop.LongFileTime ChangeTime;

			// Token: 0x0400500C RID: 20492
			[FieldOffset(40)]
			public long EndOfFile;

			// Token: 0x0400500D RID: 20493
			[FieldOffset(48)]
			public long AllocationSize;

			// Token: 0x0400500E RID: 20494
			[FieldOffset(56)]
			public FileAttributes FileAttributes;

			// Token: 0x0400500F RID: 20495
			[FieldOffset(60)]
			public uint FileNameLength;

			// Token: 0x04005010 RID: 20496
			[FieldOffset(64)]
			public uint EaSize;

			// Token: 0x04005011 RID: 20497
			[FieldOffset(68)]
			public char _fileName;
		}

		// Token: 0x0200077F RID: 1919
		public enum FILE_INFORMATION_CLASS : uint
		{
			// Token: 0x04005013 RID: 20499
			FileDirectoryInformation = 1U,
			// Token: 0x04005014 RID: 20500
			FileFullDirectoryInformation,
			// Token: 0x04005015 RID: 20501
			FileBothDirectoryInformation,
			// Token: 0x04005016 RID: 20502
			FileBasicInformation,
			// Token: 0x04005017 RID: 20503
			FileStandardInformation,
			// Token: 0x04005018 RID: 20504
			FileInternalInformation,
			// Token: 0x04005019 RID: 20505
			FileEaInformation,
			// Token: 0x0400501A RID: 20506
			FileAccessInformation,
			// Token: 0x0400501B RID: 20507
			FileNameInformation,
			// Token: 0x0400501C RID: 20508
			FileRenameInformation,
			// Token: 0x0400501D RID: 20509
			FileLinkInformation,
			// Token: 0x0400501E RID: 20510
			FileNamesInformation,
			// Token: 0x0400501F RID: 20511
			FileDispositionInformation,
			// Token: 0x04005020 RID: 20512
			FilePositionInformation,
			// Token: 0x04005021 RID: 20513
			FileFullEaInformation,
			// Token: 0x04005022 RID: 20514
			FileModeInformation,
			// Token: 0x04005023 RID: 20515
			FileAlignmentInformation,
			// Token: 0x04005024 RID: 20516
			FileAllInformation,
			// Token: 0x04005025 RID: 20517
			FileAllocationInformation,
			// Token: 0x04005026 RID: 20518
			FileEndOfFileInformation,
			// Token: 0x04005027 RID: 20519
			FileAlternateNameInformation,
			// Token: 0x04005028 RID: 20520
			FileStreamInformation,
			// Token: 0x04005029 RID: 20521
			FilePipeInformation,
			// Token: 0x0400502A RID: 20522
			FilePipeLocalInformation,
			// Token: 0x0400502B RID: 20523
			FilePipeRemoteInformation,
			// Token: 0x0400502C RID: 20524
			FileMailslotQueryInformation,
			// Token: 0x0400502D RID: 20525
			FileMailslotSetInformation,
			// Token: 0x0400502E RID: 20526
			FileCompressionInformation,
			// Token: 0x0400502F RID: 20527
			FileObjectIdInformation,
			// Token: 0x04005030 RID: 20528
			FileCompletionInformation,
			// Token: 0x04005031 RID: 20529
			FileMoveClusterInformation,
			// Token: 0x04005032 RID: 20530
			FileQuotaInformation,
			// Token: 0x04005033 RID: 20531
			FileReparsePointInformation,
			// Token: 0x04005034 RID: 20532
			FileNetworkOpenInformation,
			// Token: 0x04005035 RID: 20533
			FileAttributeTagInformation,
			// Token: 0x04005036 RID: 20534
			FileTrackingInformation,
			// Token: 0x04005037 RID: 20535
			FileIdBothDirectoryInformation,
			// Token: 0x04005038 RID: 20536
			FileIdFullDirectoryInformation,
			// Token: 0x04005039 RID: 20537
			FileValidDataLengthInformation,
			// Token: 0x0400503A RID: 20538
			FileShortNameInformation,
			// Token: 0x0400503B RID: 20539
			FileIoCompletionNotificationInformation,
			// Token: 0x0400503C RID: 20540
			FileIoStatusBlockRangeInformation,
			// Token: 0x0400503D RID: 20541
			FileIoPriorityHintInformation,
			// Token: 0x0400503E RID: 20542
			FileSfioReserveInformation,
			// Token: 0x0400503F RID: 20543
			FileSfioVolumeInformation,
			// Token: 0x04005040 RID: 20544
			FileHardLinkInformation,
			// Token: 0x04005041 RID: 20545
			FileProcessIdsUsingFileInformation,
			// Token: 0x04005042 RID: 20546
			FileNormalizedNameInformation,
			// Token: 0x04005043 RID: 20547
			FileNetworkPhysicalNameInformation,
			// Token: 0x04005044 RID: 20548
			FileIdGlobalTxDirectoryInformation,
			// Token: 0x04005045 RID: 20549
			FileIsRemoteDeviceInformation,
			// Token: 0x04005046 RID: 20550
			FileUnusedInformation,
			// Token: 0x04005047 RID: 20551
			FileNumaNodeInformation,
			// Token: 0x04005048 RID: 20552
			FileStandardLinkInformation,
			// Token: 0x04005049 RID: 20553
			FileRemoteProtocolInformation,
			// Token: 0x0400504A RID: 20554
			FileRenameInformationBypassAccessCheck,
			// Token: 0x0400504B RID: 20555
			FileLinkInformationBypassAccessCheck,
			// Token: 0x0400504C RID: 20556
			FileVolumeNameInformation,
			// Token: 0x0400504D RID: 20557
			FileIdInformation,
			// Token: 0x0400504E RID: 20558
			FileIdExtdDirectoryInformation,
			// Token: 0x0400504F RID: 20559
			FileReplaceCompletionInformation,
			// Token: 0x04005050 RID: 20560
			FileHardLinkFullIdInformation,
			// Token: 0x04005051 RID: 20561
			FileIdExtdBothDirectoryInformation,
			// Token: 0x04005052 RID: 20562
			FileDispositionInformationEx,
			// Token: 0x04005053 RID: 20563
			FileRenameInformationEx,
			// Token: 0x04005054 RID: 20564
			FileRenameInformationExBypassAccessCheck,
			// Token: 0x04005055 RID: 20565
			FileDesiredStorageClassInformation,
			// Token: 0x04005056 RID: 20566
			FileStatInformation
		}

		// Token: 0x02000780 RID: 1920
		[StructLayout(2)]
		public struct IO_STATUS_BLOCK
		{
			// Token: 0x060062EE RID: 25326 RVA: 0x001B96F8 File Offset: 0x001B78F8
			// Note: this type is marked as 'beforefieldinit'.
			static IO_STATUS_BLOCK()
			{
				Il2CppClassPointerStore<Interop.NtDll.IO_STATUS_BLOCK>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Interop.NtDll>.NativeClassPtr, "IO_STATUS_BLOCK");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Interop.NtDll.IO_STATUS_BLOCK>.NativeClassPtr);
				Interop.NtDll.IO_STATUS_BLOCK.NativeFieldInfoPtr_Status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.NtDll.IO_STATUS_BLOCK>.NativeClassPtr, "Status");
				Interop.NtDll.IO_STATUS_BLOCK.NativeFieldInfoPtr_Information = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.NtDll.IO_STATUS_BLOCK>.NativeClassPtr, "Information");
			}

			// Token: 0x060062EF RID: 25327 RVA: 0x00025088 File Offset: 0x00023288
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Interop.NtDll.IO_STATUS_BLOCK>.NativeClassPtr, ref this));
			}

			// Token: 0x04005057 RID: 20567
			private static readonly IntPtr NativeFieldInfoPtr_Status;

			// Token: 0x04005058 RID: 20568
			private static readonly IntPtr NativeFieldInfoPtr_Information;

			// Token: 0x04005059 RID: 20569
			[FieldOffset(0)]
			public Interop.NtDll.IO_STATUS_BLOCK.IO_STATUS Status;

			// Token: 0x0400505A RID: 20570
			[FieldOffset(8)]
			public IntPtr Information;

			// Token: 0x0200079D RID: 1949
			[StructLayout(2)]
			public struct IO_STATUS
			{
				// Token: 0x06006374 RID: 25460 RVA: 0x001BB098 File Offset: 0x001B9298
				// Note: this type is marked as 'beforefieldinit'.
				static IO_STATUS()
				{
					Il2CppClassPointerStore<Interop.NtDll.IO_STATUS_BLOCK.IO_STATUS>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Interop.NtDll.IO_STATUS_BLOCK>.NativeClassPtr, "IO_STATUS");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Interop.NtDll.IO_STATUS_BLOCK.IO_STATUS>.NativeClassPtr);
					Interop.NtDll.IO_STATUS_BLOCK.IO_STATUS.NativeFieldInfoPtr_Status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.NtDll.IO_STATUS_BLOCK.IO_STATUS>.NativeClassPtr, "Status");
					Interop.NtDll.IO_STATUS_BLOCK.IO_STATUS.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.NtDll.IO_STATUS_BLOCK.IO_STATUS>.NativeClassPtr, "Pointer");
				}

				// Token: 0x06006375 RID: 25461 RVA: 0x000255BC File Offset: 0x000237BC
				public Object BoxIl2CppObject()
				{
					return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Interop.NtDll.IO_STATUS_BLOCK.IO_STATUS>.NativeClassPtr, ref this));
				}

				// Token: 0x04005126 RID: 20774
				private static readonly IntPtr NativeFieldInfoPtr_Status;

				// Token: 0x04005127 RID: 20775
				private static readonly IntPtr NativeFieldInfoPtr_Pointer;

				// Token: 0x04005128 RID: 20776
				[FieldOffset(0)]
				public uint Status;

				// Token: 0x04005129 RID: 20777
				[FieldOffset(0)]
				public IntPtr Pointer;
			}
		}

		// Token: 0x02000781 RID: 1921
		[StructLayout(2)]
		public struct OBJECT_ATTRIBUTES
		{
			// Token: 0x060062F0 RID: 25328 RVA: 0x001B974C File Offset: 0x001B794C
			// Note: this type is marked as 'beforefieldinit'.
			static OBJECT_ATTRIBUTES()
			{
				Il2CppClassPointerStore<Interop.NtDll.OBJECT_ATTRIBUTES>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Interop.NtDll>.NativeClassPtr, "OBJECT_ATTRIBUTES");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Interop.NtDll.OBJECT_ATTRIBUTES>.NativeClassPtr);
				Interop.NtDll.OBJECT_ATTRIBUTES.NativeFieldInfoPtr_Length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.NtDll.OBJECT_ATTRIBUTES>.NativeClassPtr, "Length");
				Interop.NtDll.OBJECT_ATTRIBUTES.NativeFieldInfoPtr_RootDirectory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.NtDll.OBJECT_ATTRIBUTES>.NativeClassPtr, "RootDirectory");
				Interop.NtDll.OBJECT_ATTRIBUTES.NativeFieldInfoPtr_ObjectName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.NtDll.OBJECT_ATTRIBUTES>.NativeClassPtr, "ObjectName");
				Interop.NtDll.OBJECT_ATTRIBUTES.NativeFieldInfoPtr_Attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.NtDll.OBJECT_ATTRIBUTES>.NativeClassPtr, "Attributes");
				Interop.NtDll.OBJECT_ATTRIBUTES.NativeFieldInfoPtr_SecurityDescriptor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.NtDll.OBJECT_ATTRIBUTES>.NativeClassPtr, "SecurityDescriptor");
				Interop.NtDll.OBJECT_ATTRIBUTES.NativeFieldInfoPtr_SecurityQualityOfService = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interop.NtDll.OBJECT_ATTRIBUTES>.NativeClassPtr, "SecurityQualityOfService");
				Interop.NtDll.OBJECT_ATTRIBUTES.NativeMethodInfoPtr__ctor_Public_Void_ptr_UNICODE_STRING_ObjectAttributes_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interop.NtDll.OBJECT_ATTRIBUTES>.NativeClassPtr, 100663350);
			}

			// Token: 0x060062F1 RID: 25329 RVA: 0x001B9804 File Offset: 0x001B7A04
			[CallerCount(0)]
			public unsafe OBJECT_ATTRIBUTES(Interop.UNICODE_STRING* objectName, Interop.NtDll.ObjectAttributes attributes, IntPtr rootDirectory)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = objectName;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref attributes;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rootDirectory;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interop.NtDll.OBJECT_ATTRIBUTES.NativeMethodInfoPtr__ctor_Public_Void_ptr_UNICODE_STRING_ObjectAttributes_IntPtr_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060062F2 RID: 25330 RVA: 0x0002509A File Offset: 0x0002329A
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Interop.NtDll.OBJECT_ATTRIBUTES>.NativeClassPtr, ref this));
			}

			// Token: 0x0400505B RID: 20571
			private static readonly IntPtr NativeFieldInfoPtr_Length;

			// Token: 0x0400505C RID: 20572
			private static readonly IntPtr NativeFieldInfoPtr_RootDirectory;

			// Token: 0x0400505D RID: 20573
			private static readonly IntPtr NativeFieldInfoPtr_ObjectName;

			// Token: 0x0400505E RID: 20574
			private static readonly IntPtr NativeFieldInfoPtr_Attributes;

			// Token: 0x0400505F RID: 20575
			private static readonly IntPtr NativeFieldInfoPtr_SecurityDescriptor;

			// Token: 0x04005060 RID: 20576
			private static readonly IntPtr NativeFieldInfoPtr_SecurityQualityOfService;

			// Token: 0x04005061 RID: 20577
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ptr_UNICODE_STRING_ObjectAttributes_IntPtr_0;

			// Token: 0x04005062 RID: 20578
			[FieldOffset(0)]
			public uint Length;

			// Token: 0x04005063 RID: 20579
			[FieldOffset(8)]
			public IntPtr RootDirectory;

			// Token: 0x04005064 RID: 20580
			[FieldOffset(16)]
			public IntPtr ObjectName;

			// Token: 0x04005065 RID: 20581
			[FieldOffset(24)]
			public Interop.NtDll.ObjectAttributes Attributes;

			// Token: 0x04005066 RID: 20582
			[FieldOffset(32)]
			public IntPtr SecurityDescriptor;

			// Token: 0x04005067 RID: 20583
			[FieldOffset(40)]
			public IntPtr SecurityQualityOfService;
		}

		// Token: 0x02000782 RID: 1922
		[Flags]
		public enum ObjectAttributes : uint
		{
			// Token: 0x04005069 RID: 20585
			OBJ_INHERIT = 2U,
			// Token: 0x0400506A RID: 20586
			OBJ_PERMANENT = 16U,
			// Token: 0x0400506B RID: 20587
			OBJ_EXCLUSIVE = 32U,
			// Token: 0x0400506C RID: 20588
			OBJ_CASE_INSENSITIVE = 64U,
			// Token: 0x0400506D RID: 20589
			OBJ_OPENIF = 128U,
			// Token: 0x0400506E RID: 20590
			OBJ_OPENLINK = 256U
		}

		// Token: 0x02000783 RID: 1923
		public enum CreateDisposition : uint
		{
			// Token: 0x04005070 RID: 20592
			FILE_SUPERSEDE,
			// Token: 0x04005071 RID: 20593
			FILE_OPEN,
			// Token: 0x04005072 RID: 20594
			FILE_CREATE,
			// Token: 0x04005073 RID: 20595
			FILE_OPEN_IF,
			// Token: 0x04005074 RID: 20596
			FILE_OVERWRITE,
			// Token: 0x04005075 RID: 20597
			FILE_OVERWRITE_IF
		}

		// Token: 0x02000784 RID: 1924
		public enum CreateOptions : uint
		{
			// Token: 0x04005077 RID: 20599
			FILE_DIRECTORY_FILE = 1U,
			// Token: 0x04005078 RID: 20600
			FILE_WRITE_THROUGH,
			// Token: 0x04005079 RID: 20601
			FILE_SEQUENTIAL_ONLY = 4U,
			// Token: 0x0400507A RID: 20602
			FILE_NO_INTERMEDIATE_BUFFERING = 8U,
			// Token: 0x0400507B RID: 20603
			FILE_SYNCHRONOUS_IO_ALERT = 16U,
			// Token: 0x0400507C RID: 20604
			FILE_SYNCHRONOUS_IO_NONALERT = 32U,
			// Token: 0x0400507D RID: 20605
			FILE_NON_DIRECTORY_FILE = 64U,
			// Token: 0x0400507E RID: 20606
			FILE_CREATE_TREE_CONNECTION = 128U,
			// Token: 0x0400507F RID: 20607
			FILE_COMPLETE_IF_OPLOCKED = 256U,
			// Token: 0x04005080 RID: 20608
			FILE_NO_EA_KNOWLEDGE = 512U,
			// Token: 0x04005081 RID: 20609
			FILE_RANDOM_ACCESS = 2048U,
			// Token: 0x04005082 RID: 20610
			FILE_DELETE_ON_CLOSE = 4096U,
			// Token: 0x04005083 RID: 20611
			FILE_OPEN_BY_FILE_ID = 8192U,
			// Token: 0x04005084 RID: 20612
			FILE_OPEN_FOR_BACKUP_INTENT = 16384U,
			// Token: 0x04005085 RID: 20613
			FILE_NO_COMPRESSION = 32768U,
			// Token: 0x04005086 RID: 20614
			FILE_OPEN_REQUIRING_OPLOCK = 65536U,
			// Token: 0x04005087 RID: 20615
			FILE_DISALLOW_EXCLUSIVE = 131072U,
			// Token: 0x04005088 RID: 20616
			FILE_SESSION_AWARE = 262144U,
			// Token: 0x04005089 RID: 20617
			FILE_RESERVE_OPFILTER = 1048576U,
			// Token: 0x0400508A RID: 20618
			FILE_OPEN_REPARSE_POINT = 2097152U,
			// Token: 0x0400508B RID: 20619
			FILE_OPEN_NO_RECALL = 4194304U
		}

		// Token: 0x02000785 RID: 1925
		[Flags]
		public enum DesiredAccess : uint
		{
			// Token: 0x0400508D RID: 20621
			FILE_READ_DATA = 1U,
			// Token: 0x0400508E RID: 20622
			FILE_LIST_DIRECTORY = 1U,
			// Token: 0x0400508F RID: 20623
			FILE_WRITE_DATA = 2U,
			// Token: 0x04005090 RID: 20624
			FILE_ADD_FILE = 2U,
			// Token: 0x04005091 RID: 20625
			FILE_APPEND_DATA = 4U,
			// Token: 0x04005092 RID: 20626
			FILE_ADD_SUBDIRECTORY = 4U,
			// Token: 0x04005093 RID: 20627
			FILE_CREATE_PIPE_INSTANCE = 4U,
			// Token: 0x04005094 RID: 20628
			FILE_READ_EA = 8U,
			// Token: 0x04005095 RID: 20629
			FILE_WRITE_EA = 16U,
			// Token: 0x04005096 RID: 20630
			FILE_EXECUTE = 32U,
			// Token: 0x04005097 RID: 20631
			FILE_TRAVERSE = 32U,
			// Token: 0x04005098 RID: 20632
			FILE_DELETE_CHILD = 64U,
			// Token: 0x04005099 RID: 20633
			FILE_READ_ATTRIBUTES = 128U,
			// Token: 0x0400509A RID: 20634
			FILE_WRITE_ATTRIBUTES = 256U,
			// Token: 0x0400509B RID: 20635
			FILE_ALL_ACCESS = 983551U,
			// Token: 0x0400509C RID: 20636
			DELETE = 65536U,
			// Token: 0x0400509D RID: 20637
			READ_CONTROL = 131072U,
			// Token: 0x0400509E RID: 20638
			WRITE_DAC = 262144U,
			// Token: 0x0400509F RID: 20639
			WRITE_OWNER = 524288U,
			// Token: 0x040050A0 RID: 20640
			SYNCHRONIZE = 1048576U,
			// Token: 0x040050A1 RID: 20641
			STANDARD_RIGHTS_READ = 131072U,
			// Token: 0x040050A2 RID: 20642
			STANDARD_RIGHTS_WRITE = 131072U,
			// Token: 0x040050A3 RID: 20643
			STANDARD_RIGHTS_EXECUTE = 131072U,
			// Token: 0x040050A4 RID: 20644
			FILE_GENERIC_READ = 2147483648U,
			// Token: 0x040050A5 RID: 20645
			FILE_GENERIC_WRITE = 1073741824U,
			// Token: 0x040050A6 RID: 20646
			FILE_GENERIC_EXECUTE = 536870912U
		}
	}

	// Token: 0x0200055F RID: 1375
	public class Advapi32 : Object
	{
		// Token: 0x0600557D RID: 21885 RVA: 0x0018B070 File Offset: 0x00189270
		// Note: this type is marked as 'beforefieldinit'.
		static Advapi32()
		{
			Il2CppClassPointerStore<Interop.Advapi32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Interop>.NativeClassPtr, "Advapi32");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Interop.Advapi32>.NativeClassPtr);
			Interop.Advapi32.NativeMethodInfoPtr_RegCloseKey_Internal_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interop.Advapi32>.NativeClassPtr, 100663351);
			Interop.Advapi32.NativeMethodInfoPtr_RegCreateKeyEx_Internal_Static_Int32_SafeRegistryHandle_String_Int32_String_Int32_Int32_byref_SECURITY_ATTRIBUTES_byref_SafeRegistryHandle_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interop.Advapi32>.NativeClassPtr, 100663352);
			Interop.Advapi32.NativeMethodInfoPtr_RegDeleteKeyEx_Internal_Static_Int32_SafeRegistryHandle_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interop.Advapi32>.NativeClassPtr, 100663353);
			Interop.Advapi32.NativeMethodInfoPtr_RegEnumKeyEx_Internal_Static_Int32_SafeRegistryHandle_Int32_Il2CppStructArray_1_Char_byref_Int32_Il2CppStructArray_1_Int32_StringBuilder_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interop.Advapi32>.NativeClassPtr, 100663354);
			Interop.Advapi32.NativeMethodInfoPtr_RegOpenKeyEx_Internal_Static_Int32_SafeRegistryHandle_String_Int32_Int32_byref_SafeRegistryHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interop.Advapi32>.NativeClassPtr, 100663355);
			Interop.Advapi32.NativeMethodInfoPtr_RegQueryInfoKey_Internal_Static_Int32_SafeRegistryHandle_StringBuilder_Il2CppStructArray_1_Int32_IntPtr_byref_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_byref_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interop.Advapi32>.NativeClassPtr, 100663356);
			Interop.Advapi32.NativeMethodInfoPtr_RegQueryValueEx_Internal_Static_Int32_SafeRegistryHandle_String_Il2CppStructArray_1_Int32_byref_Int32_Il2CppStructArray_1_Byte_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interop.Advapi32>.NativeClassPtr, 100663357);
			Interop.Advapi32.NativeMethodInfoPtr_RegQueryValueEx_Internal_Static_Int32_SafeRegistryHandle_String_Il2CppStructArray_1_Int32_byref_Int32_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interop.Advapi32>.NativeClassPtr, 100663358);
			Interop.Advapi32.NativeMethodInfoPtr_RegQueryValueEx_Internal_Static_Int32_SafeRegistryHandle_String_Il2CppStructArray_1_Int32_byref_Int32_byref_Int64_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interop.Advapi32>.NativeClassPtr, 100663359);
			Interop.Advapi32.NativeMethodInfoPtr_RegQueryValueEx_Internal_Static_Int32_SafeRegistryHandle_String_Il2CppStructArray_1_Int32_byref_Int32_Il2CppStructArray_1_Char_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interop.Advapi32>.NativeClassPtr, 100663360);
			Interop.Advapi32.NativeMethodInfoPtr_RegSetValueEx_Internal_Static_Int32_SafeRegistryHandle_String_Int32_RegistryValueKind_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interop.Advapi32>.NativeClassPtr, 100663361);
			Interop.Advapi32.NativeMethodInfoPtr_RegSetValueEx_Internal_Static_Int32_SafeRegistryHandle_String_Int32_RegistryValueKind_Il2CppStructArray_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interop.Advapi32>.NativeClassPtr, 100663362);
			Interop.Advapi32.NativeMethodInfoPtr_RegSetValueEx_Internal_Static_Int32_SafeRegistryHandle_String_Int32_RegistryValueKind_byref_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interop.Advapi32>.NativeClassPtr, 100663363);
			Interop.Advapi32.NativeMethodInfoPtr_RegSetValueEx_Internal_Static_Int32_SafeRegistryHandle_String_Int32_RegistryValueKind_byref_Int64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interop.Advapi32>.NativeClassPtr, 100663364);
			Interop.Advapi32.NativeMethodInfoPtr_RegSetValueEx_Internal_Static_Int32_SafeRegistryHandle_String_Int32_RegistryValueKind_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interop.Advapi32>.NativeClassPtr, 100663365);
		}

		// Token: 0x0600557E RID: 21886 RVA: 0x0018B1C8 File Offset: 0x001893C8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1275593, RefRangeEnd = 1275596, XrefRangeStart = 1275591, XrefRangeEnd = 1275593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RegCloseKey(IntPtr hKey)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hKey;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interop.Advapi32.NativeMethodInfoPtr_RegCloseKey_Internal_Static_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600557F RID: 21887 RVA: 0x0018B208 File Offset: 0x00189408
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1275604, RefRangeEnd = 1275605, XrefRangeStart = 1275596, XrefRangeEnd = 1275604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RegCreateKeyEx(SafeRegistryHandle hKey, string lpSubKey, int Reserved, string lpClass, int dwOptions, int samDesired, ref Interop.Kernel32.SECURITY_ATTRIBUTES secAttrs, out SafeRegistryHandle hkResult, out int lpdwDisposition)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hKey);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lpSubKey);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Reserved;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lpClass);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dwOptions;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref samDesired;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &secAttrs;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lpdwDisposition;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Interop.Advapi32.NativeMethodInfoPtr_RegCreateKeyEx_Internal_Static_Int32_SafeRegistryHandle_String_Int32_String_Int32_Int32_byref_SECURITY_ATTRIBUTES_byref_SafeRegistryHandle_byref_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			hkResult = ((intPtr4 == 0) ? null : new SafeRegistryHandle(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06005580 RID: 21888 RVA: 0x0018B2DC File Offset: 0x001894DC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1275608, RefRangeEnd = 1275611, XrefRangeStart = 1275605, XrefRangeEnd = 1275608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RegDeleteKeyEx(SafeRegistryHandle hKey, string lpSubKey, int samDesired, int Reserved)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hKey);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lpSubKey);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref samDesired;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Reserved;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interop.Advapi32.NativeMethodInfoPtr_RegDeleteKeyEx_Internal_Static_Int32_SafeRegistryHandle_String_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005581 RID: 21889 RVA: 0x0018B34C File Offset: 0x0018954C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1275617, RefRangeEnd = 1275618, XrefRangeStart = 1275611, XrefRangeEnd = 1275617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RegEnumKeyEx(SafeRegistryHandle hKey, int dwIndex, Il2CppStructArray<char> lpName, ref int lpcbName, Il2CppStructArray<int> lpReserved, [Out] StringBuilder lpClass, Il2CppStructArray<int> lpcbClass, Il2CppStructArray<long> lpftLastWriteTime)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hKey);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dwIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lpName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lpcbName;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lpReserved);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lpcbClass);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lpftLastWriteTime);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Interop.Advapi32.NativeMethodInfoPtr_RegEnumKeyEx_Internal_Static_Int32_SafeRegistryHandle_Int32_Il2CppStructArray_1_Char_byref_Int32_Il2CppStructArray_1_Int32_StringBuilder_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int64_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*lpClass = ((intPtr4 == 0) ? null : new StringBuilder(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06005582 RID: 21890 RVA: 0x0018B418 File Offset: 0x00189618
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1275626, RefRangeEnd = 1275629, XrefRangeStart = 1275618, XrefRangeEnd = 1275626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RegOpenKeyEx(SafeRegistryHandle hKey, string lpSubKey, int ulOptions, int samDesired, out SafeRegistryHandle hkResult)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hKey);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lpSubKey);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ulOptions;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref samDesired;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Interop.Advapi32.NativeMethodInfoPtr_RegOpenKeyEx_Internal_Static_Int32_SafeRegistryHandle_String_Int32_Int32_byref_SafeRegistryHandle_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			hkResult = ((intPtr4 == 0) ? null : new SafeRegistryHandle(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06005583 RID: 21891 RVA: 0x0018B4AC File Offset: 0x001896AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1275635, RefRangeEnd = 1275637, XrefRangeStart = 1275629, XrefRangeEnd = 1275635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RegQueryInfoKey(SafeRegistryHandle hKey, [Out] StringBuilder lpClass, Il2CppStructArray<int> lpcbClass, IntPtr lpReserved_MustBeZero, ref int lpcSubKeys, Il2CppStructArray<int> lpcbMaxSubKeyLen, Il2CppStructArray<int> lpcbMaxClassLen, ref int lpcValues, Il2CppStructArray<int> lpcbMaxValueNameLen, Il2CppStructArray<int> lpcbMaxValueLen, Il2CppStructArray<int> lpcbSecurityDescriptor, Il2CppStructArray<int> lpftLastWriteTime)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hKey);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lpcbClass);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lpReserved_MustBeZero;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lpcSubKeys;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lpcbMaxSubKeyLen);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lpcbMaxClassLen);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lpcValues;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lpcbMaxValueNameLen);
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lpcbMaxValueLen);
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lpcbSecurityDescriptor);
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lpftLastWriteTime);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Interop.Advapi32.NativeMethodInfoPtr_RegQueryInfoKey_Internal_Static_Int32_SafeRegistryHandle_StringBuilder_Il2CppStructArray_1_Int32_IntPtr_byref_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_byref_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*lpClass = ((intPtr4 == 0) ? null : new StringBuilder(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06005584 RID: 21892 RVA: 0x0018B5C4 File Offset: 0x001897C4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1275643, RefRangeEnd = 1275647, XrefRangeStart = 1275637, XrefRangeEnd = 1275643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RegQueryValueEx(SafeRegistryHandle hKey, string lpValueName, Il2CppStructArray<int> lpReserved, ref int lpType, [Out] Il2CppStructArray<byte> lpData, ref int lpcbData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hKey);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lpValueName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lpReserved);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lpType;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lpcbData;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Interop.Advapi32.NativeMethodInfoPtr_RegQueryValueEx_Internal_Static_Int32_SafeRegistryHandle_String_Il2CppStructArray_1_Int32_byref_Int32_Il2CppStructArray_1_Byte_byref_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*lpData = ((intPtr4 == 0) ? null : new Il2CppStructArray<byte>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06005585 RID: 21893 RVA: 0x0018B66C File Offset: 0x0018986C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1275650, RefRangeEnd = 1275651, XrefRangeStart = 1275647, XrefRangeEnd = 1275650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RegQueryValueEx(SafeRegistryHandle hKey, string lpValueName, Il2CppStructArray<int> lpReserved, ref int lpType, ref int lpData, ref int lpcbData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hKey);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lpValueName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lpReserved);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lpType;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lpData;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lpcbData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interop.Advapi32.NativeMethodInfoPtr_RegQueryValueEx_Internal_Static_Int32_SafeRegistryHandle_String_Il2CppStructArray_1_Int32_byref_Int32_byref_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005586 RID: 21894 RVA: 0x0018B700 File Offset: 0x00189900
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1275654, RefRangeEnd = 1275655, XrefRangeStart = 1275651, XrefRangeEnd = 1275654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RegQueryValueEx(SafeRegistryHandle hKey, string lpValueName, Il2CppStructArray<int> lpReserved, ref int lpType, ref long lpData, ref int lpcbData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hKey);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lpValueName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lpReserved);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lpType;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lpData;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lpcbData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interop.Advapi32.NativeMethodInfoPtr_RegQueryValueEx_Internal_Static_Int32_SafeRegistryHandle_String_Il2CppStructArray_1_Int32_byref_Int32_byref_Int64_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005587 RID: 21895 RVA: 0x0018B794 File Offset: 0x00189994
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1275661, RefRangeEnd = 1275664, XrefRangeStart = 1275655, XrefRangeEnd = 1275661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RegQueryValueEx(SafeRegistryHandle hKey, string lpValueName, Il2CppStructArray<int> lpReserved, ref int lpType, [Out] Il2CppStructArray<char> lpData, ref int lpcbData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hKey);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lpValueName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lpReserved);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lpType;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lpcbData;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Interop.Advapi32.NativeMethodInfoPtr_RegQueryValueEx_Internal_Static_Int32_SafeRegistryHandle_String_Il2CppStructArray_1_Int32_byref_Int32_Il2CppStructArray_1_Char_byref_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*lpData = ((intPtr4 == 0) ? null : new Il2CppStructArray<char>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06005588 RID: 21896 RVA: 0x0018B83C File Offset: 0x00189A3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1275667, RefRangeEnd = 1275668, XrefRangeStart = 1275664, XrefRangeEnd = 1275667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RegSetValueEx(SafeRegistryHandle hKey, string lpValueName, int Reserved, RegistryValueKind dwType, Il2CppStructArray<byte> lpData, int cbData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hKey);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lpValueName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Reserved;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dwType;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lpData);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interop.Advapi32.NativeMethodInfoPtr_RegSetValueEx_Internal_Static_Int32_SafeRegistryHandle_String_Int32_RegistryValueKind_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005589 RID: 21897 RVA: 0x0018B8CC File Offset: 0x00189ACC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1275671, RefRangeEnd = 1275672, XrefRangeStart = 1275668, XrefRangeEnd = 1275671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RegSetValueEx(SafeRegistryHandle hKey, string lpValueName, int Reserved, RegistryValueKind dwType, Il2CppStructArray<char> lpData, int cbData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hKey);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lpValueName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Reserved;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dwType;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lpData);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interop.Advapi32.NativeMethodInfoPtr_RegSetValueEx_Internal_Static_Int32_SafeRegistryHandle_String_Int32_RegistryValueKind_Il2CppStructArray_1_Char_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600558A RID: 21898 RVA: 0x0018B95C File Offset: 0x00189B5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1275675, RefRangeEnd = 1275676, XrefRangeStart = 1275672, XrefRangeEnd = 1275675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RegSetValueEx(SafeRegistryHandle hKey, string lpValueName, int Reserved, RegistryValueKind dwType, ref int lpData, int cbData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hKey);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lpValueName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Reserved;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dwType;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lpData;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interop.Advapi32.NativeMethodInfoPtr_RegSetValueEx_Internal_Static_Int32_SafeRegistryHandle_String_Int32_RegistryValueKind_byref_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600558B RID: 21899 RVA: 0x0018B9E8 File Offset: 0x00189BE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1275679, RefRangeEnd = 1275680, XrefRangeStart = 1275676, XrefRangeEnd = 1275679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RegSetValueEx(SafeRegistryHandle hKey, string lpValueName, int Reserved, RegistryValueKind dwType, ref long lpData, int cbData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hKey);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lpValueName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Reserved;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dwType;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lpData;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interop.Advapi32.NativeMethodInfoPtr_RegSetValueEx_Internal_Static_Int32_SafeRegistryHandle_String_Int32_RegistryValueKind_byref_Int64_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600558C RID: 21900 RVA: 0x0018BA74 File Offset: 0x00189C74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1275683, RefRangeEnd = 1275684, XrefRangeStart = 1275680, XrefRangeEnd = 1275683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RegSetValueEx(SafeRegistryHandle hKey, string lpValueName, int Reserved, RegistryValueKind dwType, string lpData, int cbData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hKey);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lpValueName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Reserved;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dwType;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lpData);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interop.Advapi32.NativeMethodInfoPtr_RegSetValueEx_Internal_Static_Int32_SafeRegistryHandle_String_Int32_RegistryValueKind_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600558D RID: 21901 RVA: 0x0001E5AC File Offset: 0x0001C7AC
		public Advapi32(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400459D RID: 17821
		private static readonly IntPtr NativeMethodInfoPtr_RegCloseKey_Internal_Static_Int32_IntPtr_0;

		// Token: 0x0400459E RID: 17822
		private static readonly IntPtr NativeMethodInfoPtr_RegCreateKeyEx_Internal_Static_Int32_SafeRegistryHandle_String_Int32_String_Int32_Int32_byref_SECURITY_ATTRIBUTES_byref_SafeRegistryHandle_byref_Int32_0;

		// Token: 0x0400459F RID: 17823
		private static readonly IntPtr NativeMethodInfoPtr_RegDeleteKeyEx_Internal_Static_Int32_SafeRegistryHandle_String_Int32_Int32_0;

		// Token: 0x040045A0 RID: 17824
		private static readonly IntPtr NativeMethodInfoPtr_RegEnumKeyEx_Internal_Static_Int32_SafeRegistryHandle_Int32_Il2CppStructArray_1_Char_byref_Int32_Il2CppStructArray_1_Int32_StringBuilder_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int64_0;

		// Token: 0x040045A1 RID: 17825
		private static readonly IntPtr NativeMethodInfoPtr_RegOpenKeyEx_Internal_Static_Int32_SafeRegistryHandle_String_Int32_Int32_byref_SafeRegistryHandle_0;

		// Token: 0x040045A2 RID: 17826
		private static readonly IntPtr NativeMethodInfoPtr_RegQueryInfoKey_Internal_Static_Int32_SafeRegistryHandle_StringBuilder_Il2CppStructArray_1_Int32_IntPtr_byref_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_byref_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0;

		// Token: 0x040045A3 RID: 17827
		private static readonly IntPtr NativeMethodInfoPtr_RegQueryValueEx_Internal_Static_Int32_SafeRegistryHandle_String_Il2CppStructArray_1_Int32_byref_Int32_Il2CppStructArray_1_Byte_byref_Int32_0;

		// Token: 0x040045A4 RID: 17828
		private static readonly IntPtr NativeMethodInfoPtr_RegQueryValueEx_Internal_Static_Int32_SafeRegistryHandle_String_Il2CppStructArray_1_Int32_byref_Int32_byref_Int32_byref_Int32_0;

		// Token: 0x040045A5 RID: 17829
		private static readonly IntPtr NativeMethodInfoPtr_RegQueryValueEx_Internal_Static_Int32_SafeRegistryHandle_String_Il2CppStructArray_1_Int32_byref_Int32_byref_Int64_byref_Int32_0;

		// Token: 0x040045A6 RID: 17830
		private static readonly IntPtr NativeMethodInfoPtr_RegQueryValueEx_Internal_Static_Int32_SafeRegistryHandle_String_Il2CppStructArray_1_Int32_byref_Int32_Il2CppStructArray_1_Char_byref_Int32_0;

		// Token: 0x040045A7 RID: 17831
		private static readonly IntPtr NativeMethodInfoPtr_RegSetValueEx_Internal_Static_Int32_SafeRegistryHandle_String_Int32_RegistryValueKind_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x040045A8 RID: 17832
		private static readonly IntPtr NativeMethodInfoPtr_RegSetValueEx_Internal_Static_Int32_SafeRegistryHandle_String_Int32_RegistryValueKind_Il2CppStructArray_1_Char_Int32_0;

		// Token: 0x040045A9 RID: 17833
		private static readonly IntPtr NativeMethodInfoPtr_RegSetValueEx_Internal_Static_Int32_SafeRegistryHandle_String_Int32_RegistryValueKind_byref_Int32_Int32_0;

		// Token: 0x040045AA RID: 17834
		private static readonly IntPtr NativeMethodInfoPtr_RegSetValueEx_Internal_Static_Int32_SafeRegistryHandle_String_Int32_RegistryValueKind_byref_Int64_Int32_0;

		// Token: 0x040045AB RID: 17835
		private static readonly IntPtr NativeMethodInfoPtr_RegSetValueEx_Internal_Static_Int32_SafeRegistryHandle_String_Int32_RegistryValueKind_String_Int32_0;
	}
}
