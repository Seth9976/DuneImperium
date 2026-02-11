using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.InteropServices;

namespace Il2CppSystem.IO
{
	// Token: 0x02000547 RID: 1351
	public static class MonoIO : Object
	{
		// Token: 0x0600534A RID: 21322 RVA: 0x00183D8C File Offset: 0x00181F8C
		// Note: this type is marked as 'beforefieldinit'.
		static MonoIO()
		{
			Il2CppClassPointerStore<MonoIO>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "MonoIO");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoIO>.NativeClassPtr);
			MonoIO.NativeFieldInfoPtr_InvalidHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, "InvalidHandle");
			MonoIO.NativeFieldInfoPtr_dump_handles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, "dump_handles");
			MonoIO.NativeMethodInfoPtr_GetException_Public_Static_Exception_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100676066);
			MonoIO.NativeMethodInfoPtr_GetException_Public_Static_Exception_String_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100676067);
			MonoIO.NativeMethodInfoPtr_GetCurrentDirectory_Public_Static_String_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100676068);
			MonoIO.NativeMethodInfoPtr_GetFileType_Private_Static_MonoFileType_IntPtr_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100676069);
			MonoIO.NativeMethodInfoPtr_GetFileType_Public_Static_MonoFileType_SafeHandle_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100676070);
			MonoIO.NativeMethodInfoPtr_FindCloseFile_Public_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100676071);
			MonoIO.NativeMethodInfoPtr_Open_Private_Static_IntPtr_ptr_Char_FileMode_FileAccess_FileShare_FileOptions_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100676072);
			MonoIO.NativeMethodInfoPtr_Open_Public_Static_IntPtr_String_FileMode_FileAccess_FileShare_FileOptions_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100676073);
			MonoIO.NativeMethodInfoPtr_Cancel_internal_Private_Static_Boolean_IntPtr_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100676074);
			MonoIO.NativeMethodInfoPtr_Cancel_Internal_Static_Boolean_SafeHandle_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100676075);
			MonoIO.NativeMethodInfoPtr_Close_Public_Static_Boolean_IntPtr_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100676076);
			MonoIO.NativeMethodInfoPtr_Read_Private_Static_Int32_IntPtr_Il2CppStructArray_1_Byte_Int32_Int32_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100676077);
			MonoIO.NativeMethodInfoPtr_Read_Public_Static_Int32_SafeHandle_Il2CppStructArray_1_Byte_Int32_Int32_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100676078);
			MonoIO.NativeMethodInfoPtr_Write_Private_Static_Int32_IntPtr_Il2CppStructArray_1_Byte_Int32_Int32_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100676079);
			MonoIO.NativeMethodInfoPtr_Write_Public_Static_Int32_SafeHandle_Il2CppStructArray_1_Byte_Int32_Int32_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100676080);
			MonoIO.NativeMethodInfoPtr_Seek_Private_Static_Int64_IntPtr_Int64_SeekOrigin_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100676081);
			MonoIO.NativeMethodInfoPtr_Seek_Public_Static_Int64_SafeHandle_Int64_SeekOrigin_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100676082);
			MonoIO.NativeMethodInfoPtr_GetLength_Private_Static_Int64_IntPtr_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100676083);
			MonoIO.NativeMethodInfoPtr_GetLength_Public_Static_Int64_SafeHandle_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100676084);
			MonoIO.NativeMethodInfoPtr_SetLength_Private_Static_Boolean_IntPtr_Int64_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100676085);
			MonoIO.NativeMethodInfoPtr_SetLength_Public_Static_Boolean_SafeHandle_Int64_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100676086);
			MonoIO.NativeMethodInfoPtr_get_ConsoleOutput_Public_Static_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100676087);
			MonoIO.NativeMethodInfoPtr_get_ConsoleInput_Public_Static_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100676088);
			MonoIO.NativeMethodInfoPtr_get_ConsoleError_Public_Static_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100676089);
			MonoIO.NativeMethodInfoPtr_CreatePipe_Public_Static_Boolean_byref_IntPtr_byref_IntPtr_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100676090);
			MonoIO.NativeMethodInfoPtr_DuplicateHandle_Public_Static_Boolean_IntPtr_IntPtr_IntPtr_byref_IntPtr_Int32_Int32_Int32_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100676091);
			MonoIO.NativeMethodInfoPtr_get_VolumeSeparatorChar_Public_Static_get_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100676092);
			MonoIO.NativeMethodInfoPtr_get_DirectorySeparatorChar_Public_Static_get_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100676093);
			MonoIO.NativeMethodInfoPtr_get_AltDirectorySeparatorChar_Public_Static_get_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100676094);
			MonoIO.NativeMethodInfoPtr_get_PathSeparator_Public_Static_get_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100676095);
			MonoIO.NativeMethodInfoPtr_DumpHandles_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100676096);
			MonoIO.NativeMethodInfoPtr_RemapPath_Public_Static_Boolean_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100676097);
		}

		// Token: 0x0600534B RID: 21323 RVA: 0x00184064 File Offset: 0x00182264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1433075, XrefRangeEnd = 1433085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception GetException(MonoIOError error)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref error;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_GetException_Public_Static_Exception_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x0600534C RID: 21324 RVA: 0x001840A4 File Offset: 0x001822A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1433085, XrefRangeEnd = 1433226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception GetException(string path, MonoIOError error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_GetException_Public_Static_Exception_String_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x0600534D RID: 21325 RVA: 0x001840F8 File Offset: 0x001822F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1433226, XrefRangeEnd = 1433227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetCurrentDirectory(out MonoIOError error)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &error;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_GetCurrentDirectory_Public_Static_String_byref_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600534E RID: 21326 RVA: 0x00184130 File Offset: 0x00182330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1433227, XrefRangeEnd = 1433228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MonoFileType GetFileType(IntPtr handle, out MonoIOError error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_GetFileType_Private_Static_MonoFileType_IntPtr_byref_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600534F RID: 21327 RVA: 0x0018417C File Offset: 0x0018237C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1433236, RefRangeEnd = 1433238, XrefRangeStart = 1433228, XrefRangeEnd = 1433236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MonoFileType GetFileType(SafeHandle safeHandle, out MonoIOError error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(safeHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_GetFileType_Public_Static_MonoFileType_SafeHandle_byref_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005350 RID: 21328 RVA: 0x001841CC File Offset: 0x001823CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1433239, RefRangeEnd = 1433240, XrefRangeStart = 1433238, XrefRangeEnd = 1433239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool FindCloseFile(IntPtr hnd)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hnd;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_FindCloseFile_Public_Static_Boolean_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06005351 RID: 21329 RVA: 0x0018420C File Offset: 0x0018240C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1433240, XrefRangeEnd = 1433241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr Open(char* filename, FileMode mode, FileAccess access, FileShare share, FileOptions options, out MonoIOError error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = filename;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref access;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref share;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_Open_Private_Static_IntPtr_ptr_Char_FileMode_FileAccess_FileShare_FileOptions_byref_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005352 RID: 21330 RVA: 0x00184290 File Offset: 0x00182490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1433241, XrefRangeEnd = 1433246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr Open(string filename, FileMode mode, FileAccess access, FileShare share, FileOptions options, out MonoIOError error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(filename);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref access;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref share;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_Open_Public_Static_IntPtr_String_FileMode_FileAccess_FileShare_FileOptions_byref_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005353 RID: 21331 RVA: 0x00184318 File Offset: 0x00182518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1433246, XrefRangeEnd = 1433247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Cancel_internal(IntPtr handle, out MonoIOError error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_Cancel_internal_Private_Static_Boolean_IntPtr_byref_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005354 RID: 21332 RVA: 0x00184364 File Offset: 0x00182564
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1433255, RefRangeEnd = 1433256, XrefRangeStart = 1433247, XrefRangeEnd = 1433255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Cancel(SafeHandle safeHandle, out MonoIOError error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(safeHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_Cancel_Internal_Static_Boolean_SafeHandle_byref_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005355 RID: 21333 RVA: 0x001843B4 File Offset: 0x001825B4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1433257, RefRangeEnd = 1433262, XrefRangeStart = 1433256, XrefRangeEnd = 1433257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Close(IntPtr handle, out MonoIOError error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_Close_Public_Static_Boolean_IntPtr_byref_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005356 RID: 21334 RVA: 0x00184400 File Offset: 0x00182600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1433262, XrefRangeEnd = 1433263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Read(IntPtr handle, Il2CppStructArray<byte> dest, int dest_offset, int count, out MonoIOError error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dest);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dest_offset;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_Read_Private_Static_Int32_IntPtr_Il2CppStructArray_1_Byte_Int32_Int32_byref_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005357 RID: 21335 RVA: 0x0018447C File Offset: 0x0018267C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1433271, RefRangeEnd = 1433272, XrefRangeStart = 1433263, XrefRangeEnd = 1433271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Read(SafeHandle safeHandle, Il2CppStructArray<byte> dest, int dest_offset, int count, out MonoIOError error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(safeHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dest);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dest_offset;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_Read_Public_Static_Int32_SafeHandle_Il2CppStructArray_1_Byte_Int32_Int32_byref_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005358 RID: 21336 RVA: 0x001844FC File Offset: 0x001826FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1433272, XrefRangeEnd = 1433280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Write(IntPtr handle, [In] Il2CppStructArray<byte> src, int src_offset, int count, out MonoIOError error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(src);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref src_offset;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_Write_Private_Static_Int32_IntPtr_Il2CppStructArray_1_Byte_Int32_Int32_byref_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005359 RID: 21337 RVA: 0x00184578 File Offset: 0x00182778
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1433288, RefRangeEnd = 1433290, XrefRangeStart = 1433280, XrefRangeEnd = 1433288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Write(SafeHandle safeHandle, Il2CppStructArray<byte> src, int src_offset, int count, out MonoIOError error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(safeHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(src);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref src_offset;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_Write_Public_Static_Int32_SafeHandle_Il2CppStructArray_1_Byte_Int32_Int32_byref_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600535A RID: 21338 RVA: 0x001845F8 File Offset: 0x001827F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1433290, XrefRangeEnd = 1433291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long Seek(IntPtr handle, long offset, SeekOrigin origin, out MonoIOError error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref origin;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_Seek_Private_Static_Int64_IntPtr_Int64_SeekOrigin_byref_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600535B RID: 21339 RVA: 0x00184660 File Offset: 0x00182860
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1433299, RefRangeEnd = 1433304, XrefRangeStart = 1433291, XrefRangeEnd = 1433299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long Seek(SafeHandle safeHandle, long offset, SeekOrigin origin, out MonoIOError error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(safeHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref origin;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_Seek_Public_Static_Int64_SafeHandle_Int64_SeekOrigin_byref_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600535C RID: 21340 RVA: 0x001846CC File Offset: 0x001828CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1433304, XrefRangeEnd = 1433305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long GetLength(IntPtr handle, out MonoIOError error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_GetLength_Private_Static_Int64_IntPtr_byref_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600535D RID: 21341 RVA: 0x00184718 File Offset: 0x00182918
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1433313, RefRangeEnd = 1433314, XrefRangeStart = 1433305, XrefRangeEnd = 1433313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long GetLength(SafeHandle safeHandle, out MonoIOError error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(safeHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_GetLength_Public_Static_Int64_SafeHandle_byref_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600535E RID: 21342 RVA: 0x00184768 File Offset: 0x00182968
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1433314, XrefRangeEnd = 1433315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetLength(IntPtr handle, long length, out MonoIOError error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_SetLength_Private_Static_Boolean_IntPtr_Int64_byref_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600535F RID: 21343 RVA: 0x001847C4 File Offset: 0x001829C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1433323, RefRangeEnd = 1433324, XrefRangeStart = 1433315, XrefRangeEnd = 1433323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetLength(SafeHandle safeHandle, long length, out MonoIOError error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(safeHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_SetLength_Public_Static_Boolean_SafeHandle_Int64_byref_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700152E RID: 5422
		// (get) Token: 0x06005360 RID: 21344 RVA: 0x00184824 File Offset: 0x00182A24
		public unsafe static IntPtr ConsoleOutput
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1433325, RefRangeEnd = 1433328, XrefRangeStart = 1433324, XrefRangeEnd = 1433325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_get_ConsoleOutput_Public_Static_get_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700152F RID: 5423
		// (get) Token: 0x06005361 RID: 21345 RVA: 0x00184854 File Offset: 0x00182A54
		public unsafe static IntPtr ConsoleInput
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1433329, RefRangeEnd = 1433332, XrefRangeStart = 1433328, XrefRangeEnd = 1433329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_get_ConsoleInput_Public_Static_get_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001530 RID: 5424
		// (get) Token: 0x06005362 RID: 21346 RVA: 0x00184884 File Offset: 0x00182A84
		public unsafe static IntPtr ConsoleError
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1433333, RefRangeEnd = 1433335, XrefRangeStart = 1433332, XrefRangeEnd = 1433333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_get_ConsoleError_Public_Static_get_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06005363 RID: 21347 RVA: 0x001848B4 File Offset: 0x00182AB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1433336, RefRangeEnd = 1433337, XrefRangeStart = 1433335, XrefRangeEnd = 1433336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CreatePipe(out IntPtr read_handle, out IntPtr write_handle, out MonoIOError error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &read_handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &write_handle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_CreatePipe_Public_Static_Boolean_byref_IntPtr_byref_IntPtr_byref_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005364 RID: 21348 RVA: 0x00184910 File Offset: 0x00182B10
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1433338, RefRangeEnd = 1433340, XrefRangeStart = 1433337, XrefRangeEnd = 1433338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DuplicateHandle(IntPtr source_process_handle, IntPtr source_handle, IntPtr target_process_handle, out IntPtr target_handle, int access, int inherit, int options, out MonoIOError error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref source_process_handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref source_handle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref target_process_handle;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &target_handle;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref access;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inherit;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_DuplicateHandle_Public_Static_Boolean_IntPtr_IntPtr_IntPtr_byref_IntPtr_Int32_Int32_Int32_byref_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17001531 RID: 5425
		// (get) Token: 0x06005365 RID: 21349 RVA: 0x001849B0 File Offset: 0x00182BB0
		public unsafe static char VolumeSeparatorChar
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1433340, XrefRangeEnd = 1433341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_get_VolumeSeparatorChar_Public_Static_get_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001532 RID: 5426
		// (get) Token: 0x06005366 RID: 21350 RVA: 0x001849E0 File Offset: 0x00182BE0
		public unsafe static char DirectorySeparatorChar
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1433341, XrefRangeEnd = 1433342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_get_DirectorySeparatorChar_Public_Static_get_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001533 RID: 5427
		// (get) Token: 0x06005367 RID: 21351 RVA: 0x00184A10 File Offset: 0x00182C10
		public unsafe static char AltDirectorySeparatorChar
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1433342, XrefRangeEnd = 1433343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_get_AltDirectorySeparatorChar_Public_Static_get_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001534 RID: 5428
		// (get) Token: 0x06005368 RID: 21352 RVA: 0x00184A40 File Offset: 0x00182C40
		public unsafe static char PathSeparator
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1433343, XrefRangeEnd = 1433344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_get_PathSeparator_Public_Static_get_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06005369 RID: 21353 RVA: 0x00184A70 File Offset: 0x00182C70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DumpHandles()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_DumpHandles_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600536A RID: 21354 RVA: 0x00184A98 File Offset: 0x00182C98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1433345, RefRangeEnd = 1433346, XrefRangeStart = 1433344, XrefRangeEnd = 1433345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RemapPath(string path, out string newPath)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_RemapPath_Public_Static_Boolean_String_byref_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			newPath = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600536B RID: 21355 RVA: 0x0001D915 File Offset: 0x0001BB15
		public MonoIO(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700152C RID: 5420
		// (get) Token: 0x0600536C RID: 21356 RVA: 0x00184AF4 File Offset: 0x00182CF4
		// (set) Token: 0x0600536D RID: 21357 RVA: 0x0001D91E File Offset: 0x0001BB1E
		public unsafe static IntPtr InvalidHandle
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MonoIO.NativeFieldInfoPtr_InvalidHandle, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MonoIO.NativeFieldInfoPtr_InvalidHandle, (void*)(&value));
			}
		}

		// Token: 0x1700152D RID: 5421
		// (get) Token: 0x0600536E RID: 21358 RVA: 0x00184B10 File Offset: 0x00182D10
		// (set) Token: 0x0600536F RID: 21359 RVA: 0x0001D92C File Offset: 0x0001BB2C
		public unsafe static bool dump_handles
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(MonoIO.NativeFieldInfoPtr_dump_handles, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MonoIO.NativeFieldInfoPtr_dump_handles, (void*)(&value));
			}
		}

		// Token: 0x04004405 RID: 17413
		private static readonly IntPtr NativeFieldInfoPtr_InvalidHandle;

		// Token: 0x04004406 RID: 17414
		private static readonly IntPtr NativeFieldInfoPtr_dump_handles;

		// Token: 0x04004407 RID: 17415
		private static readonly IntPtr NativeMethodInfoPtr_GetException_Public_Static_Exception_MonoIOError_0;

		// Token: 0x04004408 RID: 17416
		private static readonly IntPtr NativeMethodInfoPtr_GetException_Public_Static_Exception_String_MonoIOError_0;

		// Token: 0x04004409 RID: 17417
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentDirectory_Public_Static_String_byref_MonoIOError_0;

		// Token: 0x0400440A RID: 17418
		private static readonly IntPtr NativeMethodInfoPtr_GetFileType_Private_Static_MonoFileType_IntPtr_byref_MonoIOError_0;

		// Token: 0x0400440B RID: 17419
		private static readonly IntPtr NativeMethodInfoPtr_GetFileType_Public_Static_MonoFileType_SafeHandle_byref_MonoIOError_0;

		// Token: 0x0400440C RID: 17420
		private static readonly IntPtr NativeMethodInfoPtr_FindCloseFile_Public_Static_Boolean_IntPtr_0;

		// Token: 0x0400440D RID: 17421
		private static readonly IntPtr NativeMethodInfoPtr_Open_Private_Static_IntPtr_ptr_Char_FileMode_FileAccess_FileShare_FileOptions_byref_MonoIOError_0;

		// Token: 0x0400440E RID: 17422
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Static_IntPtr_String_FileMode_FileAccess_FileShare_FileOptions_byref_MonoIOError_0;

		// Token: 0x0400440F RID: 17423
		private static readonly IntPtr NativeMethodInfoPtr_Cancel_internal_Private_Static_Boolean_IntPtr_byref_MonoIOError_0;

		// Token: 0x04004410 RID: 17424
		private static readonly IntPtr NativeMethodInfoPtr_Cancel_Internal_Static_Boolean_SafeHandle_byref_MonoIOError_0;

		// Token: 0x04004411 RID: 17425
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Static_Boolean_IntPtr_byref_MonoIOError_0;

		// Token: 0x04004412 RID: 17426
		private static readonly IntPtr NativeMethodInfoPtr_Read_Private_Static_Int32_IntPtr_Il2CppStructArray_1_Byte_Int32_Int32_byref_MonoIOError_0;

		// Token: 0x04004413 RID: 17427
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Static_Int32_SafeHandle_Il2CppStructArray_1_Byte_Int32_Int32_byref_MonoIOError_0;

		// Token: 0x04004414 RID: 17428
		private static readonly IntPtr NativeMethodInfoPtr_Write_Private_Static_Int32_IntPtr_Il2CppStructArray_1_Byte_Int32_Int32_byref_MonoIOError_0;

		// Token: 0x04004415 RID: 17429
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Static_Int32_SafeHandle_Il2CppStructArray_1_Byte_Int32_Int32_byref_MonoIOError_0;

		// Token: 0x04004416 RID: 17430
		private static readonly IntPtr NativeMethodInfoPtr_Seek_Private_Static_Int64_IntPtr_Int64_SeekOrigin_byref_MonoIOError_0;

		// Token: 0x04004417 RID: 17431
		private static readonly IntPtr NativeMethodInfoPtr_Seek_Public_Static_Int64_SafeHandle_Int64_SeekOrigin_byref_MonoIOError_0;

		// Token: 0x04004418 RID: 17432
		private static readonly IntPtr NativeMethodInfoPtr_GetLength_Private_Static_Int64_IntPtr_byref_MonoIOError_0;

		// Token: 0x04004419 RID: 17433
		private static readonly IntPtr NativeMethodInfoPtr_GetLength_Public_Static_Int64_SafeHandle_byref_MonoIOError_0;

		// Token: 0x0400441A RID: 17434
		private static readonly IntPtr NativeMethodInfoPtr_SetLength_Private_Static_Boolean_IntPtr_Int64_byref_MonoIOError_0;

		// Token: 0x0400441B RID: 17435
		private static readonly IntPtr NativeMethodInfoPtr_SetLength_Public_Static_Boolean_SafeHandle_Int64_byref_MonoIOError_0;

		// Token: 0x0400441C RID: 17436
		private static readonly IntPtr NativeMethodInfoPtr_get_ConsoleOutput_Public_Static_get_IntPtr_0;

		// Token: 0x0400441D RID: 17437
		private static readonly IntPtr NativeMethodInfoPtr_get_ConsoleInput_Public_Static_get_IntPtr_0;

		// Token: 0x0400441E RID: 17438
		private static readonly IntPtr NativeMethodInfoPtr_get_ConsoleError_Public_Static_get_IntPtr_0;

		// Token: 0x0400441F RID: 17439
		private static readonly IntPtr NativeMethodInfoPtr_CreatePipe_Public_Static_Boolean_byref_IntPtr_byref_IntPtr_byref_MonoIOError_0;

		// Token: 0x04004420 RID: 17440
		private static readonly IntPtr NativeMethodInfoPtr_DuplicateHandle_Public_Static_Boolean_IntPtr_IntPtr_IntPtr_byref_IntPtr_Int32_Int32_Int32_byref_MonoIOError_0;

		// Token: 0x04004421 RID: 17441
		private static readonly IntPtr NativeMethodInfoPtr_get_VolumeSeparatorChar_Public_Static_get_Char_0;

		// Token: 0x04004422 RID: 17442
		private static readonly IntPtr NativeMethodInfoPtr_get_DirectorySeparatorChar_Public_Static_get_Char_0;

		// Token: 0x04004423 RID: 17443
		private static readonly IntPtr NativeMethodInfoPtr_get_AltDirectorySeparatorChar_Public_Static_get_Char_0;

		// Token: 0x04004424 RID: 17444
		private static readonly IntPtr NativeMethodInfoPtr_get_PathSeparator_Public_Static_get_Char_0;

		// Token: 0x04004425 RID: 17445
		private static readonly IntPtr NativeMethodInfoPtr_DumpHandles_Private_Static_Void_0;

		// Token: 0x04004426 RID: 17446
		private static readonly IntPtr NativeMethodInfoPtr_RemapPath_Public_Static_Boolean_String_byref_String_0;
	}
}
