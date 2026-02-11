using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMicrosoft.Win32.SafeHandles;

namespace Il2CppSystem.IO
{
	// Token: 0x0200051B RID: 1307
	public static class FileSystem : Object
	{
		// Token: 0x06004FC5 RID: 20421 RVA: 0x00173194 File Offset: 0x00171394
		// Note: this type is marked as 'beforefieldinit'.
		static FileSystem()
		{
			Il2CppClassPointerStore<FileSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "FileSystem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FileSystem>.NativeClassPtr);
			FileSystem.NativeMethodInfoPtr_CopyFile_Public_Static_Void_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystem>.NativeClassPtr, 100675330);
			FileSystem.NativeMethodInfoPtr_CreateDirectory_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystem>.NativeClassPtr, 100675331);
			FileSystem.NativeMethodInfoPtr_DeleteFile_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystem>.NativeClassPtr, 100675332);
			FileSystem.NativeMethodInfoPtr_DirectoryExists_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystem>.NativeClassPtr, 100675333);
			FileSystem.NativeMethodInfoPtr_DirectoryExists_Private_Static_Boolean_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystem>.NativeClassPtr, 100675334);
			FileSystem.NativeMethodInfoPtr_FillAttributeInfo_Internal_Static_Int32_String_byref_WIN32_FILE_ATTRIBUTE_DATA_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystem>.NativeClassPtr, 100675335);
			FileSystem.NativeMethodInfoPtr_FileExists_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystem>.NativeClassPtr, 100675336);
			FileSystem.NativeMethodInfoPtr_GetAttributes_Public_Static_FileAttributes_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystem>.NativeClassPtr, 100675337);
			FileSystem.NativeMethodInfoPtr_GetCreationTime_Public_Static_DateTimeOffset_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystem>.NativeClassPtr, 100675338);
			FileSystem.NativeMethodInfoPtr_GetLastWriteTime_Public_Static_DateTimeOffset_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystem>.NativeClassPtr, 100675339);
			FileSystem.NativeMethodInfoPtr_RemoveDirectory_Public_Static_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystem>.NativeClassPtr, 100675340);
			FileSystem.NativeMethodInfoPtr_GetFindData_Private_Static_Void_String_byref_WIN32_FIND_DATA_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystem>.NativeClassPtr, 100675341);
			FileSystem.NativeMethodInfoPtr_IsNameSurrogateReparsePoint_Private_Static_Boolean_byref_WIN32_FIND_DATA_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystem>.NativeClassPtr, 100675342);
			FileSystem.NativeMethodInfoPtr_RemoveDirectoryRecursive_Private_Static_Void_String_byref_WIN32_FIND_DATA_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystem>.NativeClassPtr, 100675343);
			FileSystem.NativeMethodInfoPtr_RemoveDirectoryInternal_Private_Static_Void_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystem>.NativeClassPtr, 100675344);
			FileSystem.NativeMethodInfoPtr_UnityCreateDirectory_Private_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystem>.NativeClassPtr, 100675345);
			FileSystem.NativeMethodInfoPtr_UnityRemoveDirectory_Private_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystem>.NativeClassPtr, 100675346);
			FileSystem.NativeMethodInfoPtr_UnityGetFileAttributesEx_Private_Static_Boolean_String_byref_WIN32_FILE_ATTRIBUTE_DATA_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystem>.NativeClassPtr, 100675347);
			FileSystem.NativeMethodInfoPtr_UnityCreateFile_IntPtr_Internal_Static_IntPtr_String_Int32_FileShare_FileMode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystem>.NativeClassPtr, 100675348);
			FileSystem.NativeMethodInfoPtr_UnityCopyFile_Private_Static_Int32_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystem>.NativeClassPtr, 100675349);
			FileSystem.NativeMethodInfoPtr_UnityDeleteFile_Private_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystem>.NativeClassPtr, 100675350);
			FileSystem.NativeMethodInfoPtr_UnityFindFirstFile_Private_Static_SafeFindHandle_String_byref_WIN32_FIND_DATA_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystem>.NativeClassPtr, 100675351);
			FileSystem.NativeMethodInfoPtr_UnityFindNextFile_Private_Static_Boolean_SafeFindHandle_byref_WIN32_FIND_DATA_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystem>.NativeClassPtr, 100675352);
			FileSystem.NativeMethodInfoPtr_BrokeredCreateDirectory_Private_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystem>.NativeClassPtr, 100675353);
			FileSystem.NativeMethodInfoPtr_BrokeredRemoveDirectory_Private_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystem>.NativeClassPtr, 100675354);
			FileSystem.NativeMethodInfoPtr_BrokeredGetFileAttributes_Private_Static_Boolean_String_byref_WIN32_FILE_ATTRIBUTE_DATA_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystem>.NativeClassPtr, 100675355);
			FileSystem.NativeMethodInfoPtr_BrokeredOpenFile_Private_Static_IntPtr_String_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystem>.NativeClassPtr, 100675356);
			FileSystem.NativeMethodInfoPtr_BrokeredCopyFile_Private_Static_Void_String_String_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystem>.NativeClassPtr, 100675357);
			FileSystem.NativeMethodInfoPtr_BrokeredDeleteFile_Private_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystem>.NativeClassPtr, 100675358);
			FileSystem.NativeMethodInfoPtr_BrokeredFindFirstFile_Private_Static_IntPtr_String_byref_String_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystem>.NativeClassPtr, 100675359);
			FileSystem.NativeMethodInfoPtr_BrokeredFindNextFile_Private_Static_Boolean_IntPtr_byref_String_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystem>.NativeClassPtr, 100675360);
			FileSystem.NativeMethodInfoPtr_BrokeredSafeFindHandleDispose_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystem>.NativeClassPtr, 100675361);
			FileSystem.NativeMethodInfoPtr_RemoveExtendedPathPrefix_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystem>.NativeClassPtr, 100675362);
		}

		// Token: 0x06004FC6 RID: 20422 RVA: 0x00173458 File Offset: 0x00171658
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1426830, RefRangeEnd = 1426831, XrefRangeStart = 1426819, XrefRangeEnd = 1426830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CopyFile(string sourceFullPath, string destFullPath, bool overwrite)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sourceFullPath);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(destFullPath);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overwrite;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystem.NativeMethodInfoPtr_CopyFile_Public_Static_Void_String_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004FC7 RID: 20423 RVA: 0x001734B0 File Offset: 0x001716B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1426885, RefRangeEnd = 1426887, XrefRangeStart = 1426831, XrefRangeEnd = 1426885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CreateDirectory(string fullPath)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fullPath);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystem.NativeMethodInfoPtr_CreateDirectory_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004FC8 RID: 20424 RVA: 0x001734E8 File Offset: 0x001716E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1426892, RefRangeEnd = 1426893, XrefRangeStart = 1426887, XrefRangeEnd = 1426892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DeleteFile(string fullPath)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fullPath);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystem.NativeMethodInfoPtr_DeleteFile_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004FC9 RID: 20425 RVA: 0x00173520 File Offset: 0x00171720
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1426894, RefRangeEnd = 1426895, XrefRangeStart = 1426893, XrefRangeEnd = 1426894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DirectoryExists(string fullPath)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fullPath);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystem.NativeMethodInfoPtr_DirectoryExists_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004FCA RID: 20426 RVA: 0x00173564 File Offset: 0x00171764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1426895, XrefRangeEnd = 1426896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DirectoryExists(string path, out int lastError)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lastError;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystem.NativeMethodInfoPtr_DirectoryExists_Private_Static_Boolean_String_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004FCB RID: 20427 RVA: 0x001735B4 File Offset: 0x001717B4
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 1426948, RefRangeEnd = 1426966, XrefRangeStart = 1426896, XrefRangeEnd = 1426948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FillAttributeInfo(string path, ref Interop.Kernel32.WIN32_FILE_ATTRIBUTE_DATA data, bool returnErrorOnNotFound)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &data;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref returnErrorOnNotFound;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystem.NativeMethodInfoPtr_FillAttributeInfo_Internal_Static_Int32_String_byref_WIN32_FILE_ATTRIBUTE_DATA_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004FCC RID: 20428 RVA: 0x00173614 File Offset: 0x00171814
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1426967, RefRangeEnd = 1426969, XrefRangeStart = 1426966, XrefRangeEnd = 1426967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool FileExists(string fullPath)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fullPath);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystem.NativeMethodInfoPtr_FileExists_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004FCD RID: 20429 RVA: 0x00173658 File Offset: 0x00171858
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1426970, RefRangeEnd = 1426971, XrefRangeStart = 1426969, XrefRangeEnd = 1426970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FileAttributes GetAttributes(string fullPath)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fullPath);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystem.NativeMethodInfoPtr_GetAttributes_Public_Static_FileAttributes_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004FCE RID: 20430 RVA: 0x0017369C File Offset: 0x0017189C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1426973, RefRangeEnd = 1426974, XrefRangeStart = 1426971, XrefRangeEnd = 1426973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTimeOffset GetCreationTime(string fullPath)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fullPath);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystem.NativeMethodInfoPtr_GetCreationTime_Public_Static_DateTimeOffset_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004FCF RID: 20431 RVA: 0x001736E0 File Offset: 0x001718E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1426976, RefRangeEnd = 1426977, XrefRangeStart = 1426974, XrefRangeEnd = 1426976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTimeOffset GetLastWriteTime(string fullPath)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fullPath);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystem.NativeMethodInfoPtr_GetLastWriteTime_Public_Static_DateTimeOffset_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004FD0 RID: 20432 RVA: 0x00173724 File Offset: 0x00171924
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1426984, RefRangeEnd = 1426985, XrefRangeStart = 1426977, XrefRangeEnd = 1426984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoveDirectory(string fullPath, bool recursive)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fullPath);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref recursive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystem.NativeMethodInfoPtr_RemoveDirectory_Public_Static_Void_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004FD1 RID: 20433 RVA: 0x00173768 File Offset: 0x00171968
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1426996, RefRangeEnd = 1426997, XrefRangeStart = 1426985, XrefRangeEnd = 1426996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetFindData(string fullPath, ref Interop.Kernel32.WIN32_FIND_DATA findData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fullPath);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &findData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystem.NativeMethodInfoPtr_GetFindData_Private_Static_Void_String_byref_WIN32_FIND_DATA_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004FD2 RID: 20434 RVA: 0x001737AC File Offset: 0x001719AC
		[CallerCount(0)]
		public unsafe static bool IsNameSurrogateReparsePoint(ref Interop.Kernel32.WIN32_FIND_DATA data)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &data;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystem.NativeMethodInfoPtr_IsNameSurrogateReparsePoint_Private_Static_Boolean_byref_WIN32_FIND_DATA_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004FD3 RID: 20435 RVA: 0x001737EC File Offset: 0x001719EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1427079, RefRangeEnd = 1427081, XrefRangeStart = 1426997, XrefRangeEnd = 1427079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoveDirectoryRecursive(string fullPath, ref Interop.Kernel32.WIN32_FIND_DATA findData, bool topLevel)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fullPath);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &findData;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref topLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystem.NativeMethodInfoPtr_RemoveDirectoryRecursive_Private_Static_Void_String_byref_WIN32_FIND_DATA_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004FD4 RID: 20436 RVA: 0x00173840 File Offset: 0x00171A40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1427086, RefRangeEnd = 1427087, XrefRangeStart = 1427081, XrefRangeEnd = 1427086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoveDirectoryInternal(string fullPath, bool topLevel, bool allowDirectoryNotEmpty = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fullPath);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref topLevel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowDirectoryNotEmpty;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystem.NativeMethodInfoPtr_RemoveDirectoryInternal_Private_Static_Void_String_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004FD5 RID: 20437 RVA: 0x00173894 File Offset: 0x00171A94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1427087, XrefRangeEnd = 1427093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool UnityCreateDirectory(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystem.NativeMethodInfoPtr_UnityCreateDirectory_Private_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004FD6 RID: 20438 RVA: 0x001738D8 File Offset: 0x00171AD8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1427104, RefRangeEnd = 1427106, XrefRangeStart = 1427093, XrefRangeEnd = 1427104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool UnityRemoveDirectory(string fullPath)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fullPath);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystem.NativeMethodInfoPtr_UnityRemoveDirectory_Private_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004FD7 RID: 20439 RVA: 0x0017391C File Offset: 0x00171B1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1427106, XrefRangeEnd = 1427128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool UnityGetFileAttributesEx(string path, ref Interop.Kernel32.WIN32_FILE_ATTRIBUTE_DATA data)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &data;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystem.NativeMethodInfoPtr_UnityGetFileAttributesEx_Private_Static_Boolean_String_byref_WIN32_FILE_ATTRIBUTE_DATA_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004FD8 RID: 20440 RVA: 0x0017396C File Offset: 0x00171B6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1427138, RefRangeEnd = 1427139, XrefRangeStart = 1427128, XrefRangeEnd = 1427138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr UnityCreateFile_IntPtr(string lpFileName, int dwDesiredAccess, FileShare dwShareMode, FileMode dwCreationDisposition, int dwFlagsAndAttributes)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystem.NativeMethodInfoPtr_UnityCreateFile_IntPtr_Internal_Static_IntPtr_String_Int32_FileShare_FileMode_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004FD9 RID: 20441 RVA: 0x001739E8 File Offset: 0x00171BE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1427139, XrefRangeEnd = 1427141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int UnityCopyFile(string sourceFullPath, string destFullPath, bool failIfExists)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sourceFullPath);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(destFullPath);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref failIfExists;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystem.NativeMethodInfoPtr_UnityCopyFile_Private_Static_Int32_String_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004FDA RID: 20442 RVA: 0x00173A4C File Offset: 0x00171C4C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1427152, RefRangeEnd = 1427154, XrefRangeStart = 1427141, XrefRangeEnd = 1427152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool UnityDeleteFile(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystem.NativeMethodInfoPtr_UnityDeleteFile_Private_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004FDB RID: 20443 RVA: 0x00173A90 File Offset: 0x00171C90
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1427174, RefRangeEnd = 1427177, XrefRangeStart = 1427154, XrefRangeEnd = 1427174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SafeFindHandle UnityFindFirstFile(string path, ref Interop.Kernel32.WIN32_FIND_DATA findData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &findData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystem.NativeMethodInfoPtr_UnityFindFirstFile_Private_Static_SafeFindHandle_String_byref_WIN32_FIND_DATA_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SafeFindHandle>(intPtr3) : null;
		}

		// Token: 0x06004FDC RID: 20444 RVA: 0x00173AE4 File Offset: 0x00171CE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1427177, XrefRangeEnd = 1427182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool UnityFindNextFile(SafeFindHandle handle, ref Interop.Kernel32.WIN32_FIND_DATA findData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &findData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystem.NativeMethodInfoPtr_UnityFindNextFile_Private_Static_Boolean_SafeFindHandle_byref_WIN32_FIND_DATA_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004FDD RID: 20445 RVA: 0x00173B34 File Offset: 0x00171D34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1427182, XrefRangeEnd = 1427183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BrokeredCreateDirectory(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystem.NativeMethodInfoPtr_BrokeredCreateDirectory_Private_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004FDE RID: 20446 RVA: 0x00173B78 File Offset: 0x00171D78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BrokeredRemoveDirectory(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystem.NativeMethodInfoPtr_BrokeredRemoveDirectory_Private_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004FDF RID: 20447 RVA: 0x00173BBC File Offset: 0x00171DBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1427183, XrefRangeEnd = 1427184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BrokeredGetFileAttributes(string path, ref Interop.Kernel32.WIN32_FILE_ATTRIBUTE_DATA data)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &data;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystem.NativeMethodInfoPtr_BrokeredGetFileAttributes_Private_Static_Boolean_String_byref_WIN32_FILE_ATTRIBUTE_DATA_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004FE0 RID: 20448 RVA: 0x00173C0C File Offset: 0x00171E0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1427184, XrefRangeEnd = 1427185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr BrokeredOpenFile(string lpFileName, int dwDesiredAccess, int dwShareMode, int dwCreationDisposition, int dwFlagsAndAttributes)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystem.NativeMethodInfoPtr_BrokeredOpenFile_Private_Static_IntPtr_String_Int32_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004FE1 RID: 20449 RVA: 0x00173C88 File Offset: 0x00171E88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1427185, XrefRangeEnd = 1427186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BrokeredCopyFile(string sourcePath, string destPath, bool overwrite, ref int error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sourcePath);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(destPath);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overwrite;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystem.NativeMethodInfoPtr_BrokeredCopyFile_Private_Static_Void_String_String_Boolean_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004FE2 RID: 20450 RVA: 0x00173CEC File Offset: 0x00171EEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BrokeredDeleteFile(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystem.NativeMethodInfoPtr_BrokeredDeleteFile_Private_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004FE3 RID: 20451 RVA: 0x00173D30 File Offset: 0x00171F30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1427186, XrefRangeEnd = 1427187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr BrokeredFindFirstFile(string searchPath, ref string resultFilePath, ref uint attributes)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(searchPath);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(resultFilePath);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &attributes;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(FileSystem.NativeMethodInfoPtr_BrokeredFindFirstFile_Private_Static_IntPtr_String_byref_String_byref_UInt32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			resultFilePath = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06004FE4 RID: 20452 RVA: 0x00173DA0 File Offset: 0x00171FA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1427187, XrefRangeEnd = 1427188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BrokeredFindNextFile(IntPtr handle, ref string resultFilePath, ref uint attributes)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(resultFilePath);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &attributes;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(FileSystem.NativeMethodInfoPtr_BrokeredFindNextFile_Private_Static_Boolean_IntPtr_byref_String_byref_UInt32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			resultFilePath = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06004FE5 RID: 20453 RVA: 0x00173E0C File Offset: 0x0017200C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1427188, XrefRangeEnd = 1427189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int BrokeredSafeFindHandleDispose(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystem.NativeMethodInfoPtr_BrokeredSafeFindHandleDispose_Private_Static_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004FE6 RID: 20454 RVA: 0x00173E4C File Offset: 0x0017204C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1427189, XrefRangeEnd = 1427194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string RemoveExtendedPathPrefix(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystem.NativeMethodInfoPtr_RemoveExtendedPathPrefix_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06004FE7 RID: 20455 RVA: 0x0001C9F1 File Offset: 0x0001ABF1
		public FileSystem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040040FF RID: 16639
		private static readonly IntPtr NativeMethodInfoPtr_CopyFile_Public_Static_Void_String_String_Boolean_0;

		// Token: 0x04004100 RID: 16640
		private static readonly IntPtr NativeMethodInfoPtr_CreateDirectory_Public_Static_Void_String_0;

		// Token: 0x04004101 RID: 16641
		private static readonly IntPtr NativeMethodInfoPtr_DeleteFile_Public_Static_Void_String_0;

		// Token: 0x04004102 RID: 16642
		private static readonly IntPtr NativeMethodInfoPtr_DirectoryExists_Public_Static_Boolean_String_0;

		// Token: 0x04004103 RID: 16643
		private static readonly IntPtr NativeMethodInfoPtr_DirectoryExists_Private_Static_Boolean_String_byref_Int32_0;

		// Token: 0x04004104 RID: 16644
		private static readonly IntPtr NativeMethodInfoPtr_FillAttributeInfo_Internal_Static_Int32_String_byref_WIN32_FILE_ATTRIBUTE_DATA_Boolean_0;

		// Token: 0x04004105 RID: 16645
		private static readonly IntPtr NativeMethodInfoPtr_FileExists_Public_Static_Boolean_String_0;

		// Token: 0x04004106 RID: 16646
		private static readonly IntPtr NativeMethodInfoPtr_GetAttributes_Public_Static_FileAttributes_String_0;

		// Token: 0x04004107 RID: 16647
		private static readonly IntPtr NativeMethodInfoPtr_GetCreationTime_Public_Static_DateTimeOffset_String_0;

		// Token: 0x04004108 RID: 16648
		private static readonly IntPtr NativeMethodInfoPtr_GetLastWriteTime_Public_Static_DateTimeOffset_String_0;

		// Token: 0x04004109 RID: 16649
		private static readonly IntPtr NativeMethodInfoPtr_RemoveDirectory_Public_Static_Void_String_Boolean_0;

		// Token: 0x0400410A RID: 16650
		private static readonly IntPtr NativeMethodInfoPtr_GetFindData_Private_Static_Void_String_byref_WIN32_FIND_DATA_0;

		// Token: 0x0400410B RID: 16651
		private static readonly IntPtr NativeMethodInfoPtr_IsNameSurrogateReparsePoint_Private_Static_Boolean_byref_WIN32_FIND_DATA_0;

		// Token: 0x0400410C RID: 16652
		private static readonly IntPtr NativeMethodInfoPtr_RemoveDirectoryRecursive_Private_Static_Void_String_byref_WIN32_FIND_DATA_Boolean_0;

		// Token: 0x0400410D RID: 16653
		private static readonly IntPtr NativeMethodInfoPtr_RemoveDirectoryInternal_Private_Static_Void_String_Boolean_Boolean_0;

		// Token: 0x0400410E RID: 16654
		private static readonly IntPtr NativeMethodInfoPtr_UnityCreateDirectory_Private_Static_Boolean_String_0;

		// Token: 0x0400410F RID: 16655
		private static readonly IntPtr NativeMethodInfoPtr_UnityRemoveDirectory_Private_Static_Boolean_String_0;

		// Token: 0x04004110 RID: 16656
		private static readonly IntPtr NativeMethodInfoPtr_UnityGetFileAttributesEx_Private_Static_Boolean_String_byref_WIN32_FILE_ATTRIBUTE_DATA_0;

		// Token: 0x04004111 RID: 16657
		private static readonly IntPtr NativeMethodInfoPtr_UnityCreateFile_IntPtr_Internal_Static_IntPtr_String_Int32_FileShare_FileMode_Int32_0;

		// Token: 0x04004112 RID: 16658
		private static readonly IntPtr NativeMethodInfoPtr_UnityCopyFile_Private_Static_Int32_String_String_Boolean_0;

		// Token: 0x04004113 RID: 16659
		private static readonly IntPtr NativeMethodInfoPtr_UnityDeleteFile_Private_Static_Boolean_String_0;

		// Token: 0x04004114 RID: 16660
		private static readonly IntPtr NativeMethodInfoPtr_UnityFindFirstFile_Private_Static_SafeFindHandle_String_byref_WIN32_FIND_DATA_0;

		// Token: 0x04004115 RID: 16661
		private static readonly IntPtr NativeMethodInfoPtr_UnityFindNextFile_Private_Static_Boolean_SafeFindHandle_byref_WIN32_FIND_DATA_0;

		// Token: 0x04004116 RID: 16662
		private static readonly IntPtr NativeMethodInfoPtr_BrokeredCreateDirectory_Private_Static_Boolean_String_0;

		// Token: 0x04004117 RID: 16663
		private static readonly IntPtr NativeMethodInfoPtr_BrokeredRemoveDirectory_Private_Static_Boolean_String_0;

		// Token: 0x04004118 RID: 16664
		private static readonly IntPtr NativeMethodInfoPtr_BrokeredGetFileAttributes_Private_Static_Boolean_String_byref_WIN32_FILE_ATTRIBUTE_DATA_0;

		// Token: 0x04004119 RID: 16665
		private static readonly IntPtr NativeMethodInfoPtr_BrokeredOpenFile_Private_Static_IntPtr_String_Int32_Int32_Int32_Int32_0;

		// Token: 0x0400411A RID: 16666
		private static readonly IntPtr NativeMethodInfoPtr_BrokeredCopyFile_Private_Static_Void_String_String_Boolean_byref_Int32_0;

		// Token: 0x0400411B RID: 16667
		private static readonly IntPtr NativeMethodInfoPtr_BrokeredDeleteFile_Private_Static_Boolean_String_0;

		// Token: 0x0400411C RID: 16668
		private static readonly IntPtr NativeMethodInfoPtr_BrokeredFindFirstFile_Private_Static_IntPtr_String_byref_String_byref_UInt32_0;

		// Token: 0x0400411D RID: 16669
		private static readonly IntPtr NativeMethodInfoPtr_BrokeredFindNextFile_Private_Static_Boolean_IntPtr_byref_String_byref_UInt32_0;

		// Token: 0x0400411E RID: 16670
		private static readonly IntPtr NativeMethodInfoPtr_BrokeredSafeFindHandleDispose_Private_Static_Int32_IntPtr_0;

		// Token: 0x0400411F RID: 16671
		private static readonly IntPtr NativeMethodInfoPtr_RemoveExtendedPathPrefix_Private_Static_String_String_0;

		// Token: 0x02000714 RID: 1812
		public class UnitySafeFindHandle : SafeFindHandle
		{
			// Token: 0x0600601B RID: 24603 RVA: 0x001B1D2C File Offset: 0x001AFF2C
			// Note: this type is marked as 'beforefieldinit'.
			static UnitySafeFindHandle()
			{
				Il2CppClassPointerStore<FileSystem.UnitySafeFindHandle>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FileSystem>.NativeClassPtr, "UnitySafeFindHandle");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FileSystem.UnitySafeFindHandle>.NativeClassPtr);
				FileSystem.UnitySafeFindHandle.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystem.UnitySafeFindHandle>.NativeClassPtr, "m_Handle");
				FileSystem.UnitySafeFindHandle.NativeMethodInfoPtr_get_Handle_Public_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystem.UnitySafeFindHandle>.NativeClassPtr, 100675364);
				FileSystem.UnitySafeFindHandle.NativeMethodInfoPtr_get_IsInvalid_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystem.UnitySafeFindHandle>.NativeClassPtr, 100675365);
				FileSystem.UnitySafeFindHandle.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystem.UnitySafeFindHandle>.NativeClassPtr, 100675366);
			}

			// Token: 0x170018DB RID: 6363
			// (get) Token: 0x0600601C RID: 24604 RVA: 0x001B1DA8 File Offset: 0x001AFFA8
			public unsafe IntPtr Handle
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystem.UnitySafeFindHandle.NativeMethodInfoPtr_get_Handle_Public_get_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170018DC RID: 6364
			// (get) Token: 0x0600601D RID: 24605 RVA: 0x001B1DE4 File Offset: 0x001AFFE4
			public unsafe override bool IsInvalid
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1426816, XrefRangeEnd = 1426817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileSystem.UnitySafeFindHandle.NativeMethodInfoPtr_get_IsInvalid_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600601E RID: 24606 RVA: 0x001B1E2C File Offset: 0x001B002C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1426817, XrefRangeEnd = 1426819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Dispose(bool disposing)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref disposing;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileSystem.UnitySafeFindHandle.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600601F RID: 24607 RVA: 0x000231FB File Offset: 0x000213FB
			public UnitySafeFindHandle(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170018DA RID: 6362
			// (get) Token: 0x06006020 RID: 24608 RVA: 0x001B1E78 File Offset: 0x001B0078
			// (set) Token: 0x06006021 RID: 24609 RVA: 0x00023204 File Offset: 0x00021404
			public unsafe IntPtr m_Handle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystem.UnitySafeFindHandle.NativeFieldInfoPtr_m_Handle);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystem.UnitySafeFindHandle.NativeFieldInfoPtr_m_Handle)) = value;
				}
			}

			// Token: 0x04004E12 RID: 19986
			private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

			// Token: 0x04004E13 RID: 19987
			private static readonly IntPtr NativeMethodInfoPtr_get_Handle_Public_get_IntPtr_0;

			// Token: 0x04004E14 RID: 19988
			private static readonly IntPtr NativeMethodInfoPtr_get_IsInvalid_Public_Virtual_get_Boolean_0;

			// Token: 0x04004E15 RID: 19989
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;
		}
	}
}
