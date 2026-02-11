using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMicrosoft.Win32.SafeHandles;
using Il2CppSystem.Runtime.InteropServices;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.IO
{
	// Token: 0x02000544 RID: 1348
	public class FileStream : Stream
	{
		// Token: 0x060052DC RID: 21212 RVA: 0x00181E6C File Offset: 0x0018006C
		// Note: this type is marked as 'beforefieldinit'.
		static FileStream()
		{
			Il2CppClassPointerStore<FileStream>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "FileStream");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FileStream>.NativeClassPtr);
			FileStream.NativeFieldInfoPtr_buf_recycle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileStream>.NativeClassPtr, "buf_recycle");
			FileStream.NativeFieldInfoPtr_buf_recycle_lock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileStream>.NativeClassPtr, "buf_recycle_lock");
			FileStream.NativeFieldInfoPtr_buf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileStream>.NativeClassPtr, "buf");
			FileStream.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileStream>.NativeClassPtr, "name");
			FileStream.NativeFieldInfoPtr_safeHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileStream>.NativeClassPtr, "safeHandle");
			FileStream.NativeFieldInfoPtr_isExposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileStream>.NativeClassPtr, "isExposed");
			FileStream.NativeFieldInfoPtr_append_startpos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileStream>.NativeClassPtr, "append_startpos");
			FileStream.NativeFieldInfoPtr_access = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileStream>.NativeClassPtr, "access");
			FileStream.NativeFieldInfoPtr_owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileStream>.NativeClassPtr, "owner");
			FileStream.NativeFieldInfoPtr_async = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileStream>.NativeClassPtr, "async");
			FileStream.NativeFieldInfoPtr_canseek = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileStream>.NativeClassPtr, "canseek");
			FileStream.NativeFieldInfoPtr_anonymous = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileStream>.NativeClassPtr, "anonymous");
			FileStream.NativeFieldInfoPtr_buf_dirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileStream>.NativeClassPtr, "buf_dirty");
			FileStream.NativeFieldInfoPtr_buf_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileStream>.NativeClassPtr, "buf_size");
			FileStream.NativeFieldInfoPtr_buf_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileStream>.NativeClassPtr, "buf_length");
			FileStream.NativeFieldInfoPtr_buf_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileStream>.NativeClassPtr, "buf_offset");
			FileStream.NativeFieldInfoPtr_buf_start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileStream>.NativeClassPtr, "buf_start");
			FileStream.NativeMethodInfoPtr__ctor_Public_Void_IntPtr_FileAccess_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100676003);
			FileStream.NativeMethodInfoPtr__ctor_Internal_Void_IntPtr_FileAccess_Boolean_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100676004);
			FileStream.NativeMethodInfoPtr__ctor_Public_Void_String_FileMode_FileAccess_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100676005);
			FileStream.NativeMethodInfoPtr__ctor_Public_Void_String_FileMode_FileAccess_FileShare_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100676006);
			FileStream.NativeMethodInfoPtr__ctor_Public_Void_String_FileMode_FileAccess_FileShare_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100676007);
			FileStream.NativeMethodInfoPtr__ctor_Public_Void_String_FileMode_FileAccess_FileShare_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100676008);
			FileStream.NativeMethodInfoPtr__ctor_Public_Void_String_FileMode_FileAccess_FileShare_Int32_FileOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100676009);
			FileStream.NativeMethodInfoPtr__ctor_Public_Void_SafeFileHandle_FileAccess_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100676010);
			FileStream.NativeMethodInfoPtr__ctor_Public_Void_SafeFileHandle_FileAccess_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100676011);
			FileStream.NativeMethodInfoPtr__ctor_Internal_Void_String_FileMode_FileAccess_FileShare_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100676012);
			FileStream.NativeMethodInfoPtr__ctor_Internal_Void_String_FileMode_FileAccess_FileShare_Int32_Boolean_FileOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100676013);
			FileStream.NativeMethodInfoPtr_Init_Private_Void_SafeFileHandle_FileAccess_Boolean_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100676014);
			FileStream.NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100676015);
			FileStream.NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100676016);
			FileStream.NativeMethodInfoPtr_get_CanSeek_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100676017);
			FileStream.NativeMethodInfoPtr_get_Name_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100676018);
			FileStream.NativeMethodInfoPtr_get_Length_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100676019);
			FileStream.NativeMethodInfoPtr_get_Position_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100676020);
			FileStream.NativeMethodInfoPtr_set_Position_Public_Virtual_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100676021);
			FileStream.NativeMethodInfoPtr_get_SafeFileHandle_Public_Virtual_New_get_SafeFileHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100676022);
			FileStream.NativeMethodInfoPtr_ExposeHandle_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100676023);
			FileStream.NativeMethodInfoPtr_ReadByte_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100676024);
			FileStream.NativeMethodInfoPtr_WriteByte_Public_Virtual_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100676025);
			FileStream.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100676026);
			FileStream.NativeMethodInfoPtr_ReadInternal_Private_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100676027);
			FileStream.NativeMethodInfoPtr_BeginRead_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100676028);
			FileStream.NativeMethodInfoPtr_EndRead_Public_Virtual_Int32_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100676029);
			FileStream.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100676030);
			FileStream.NativeMethodInfoPtr_WriteInternal_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100676031);
			FileStream.NativeMethodInfoPtr_BeginWrite_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100676032);
			FileStream.NativeMethodInfoPtr_EndWrite_Public_Virtual_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100676033);
			FileStream.NativeMethodInfoPtr_Seek_Public_Virtual_Int64_Int64_SeekOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100676034);
			FileStream.NativeMethodInfoPtr_SetLength_Public_Virtual_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100676035);
			FileStream.NativeMethodInfoPtr_Flush_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100676036);
			FileStream.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100676037);
			FileStream.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100676038);
			FileStream.NativeMethodInfoPtr_FlushAsync_Public_Virtual_Task_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100676039);
			FileStream.NativeMethodInfoPtr_ReadAsync_Public_Virtual_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100676040);
			FileStream.NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100676041);
			FileStream.NativeMethodInfoPtr_ReadSegment_Private_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100676042);
			FileStream.NativeMethodInfoPtr_WriteSegment_Private_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100676043);
			FileStream.NativeMethodInfoPtr_FlushBuffer_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100676044);
			FileStream.NativeMethodInfoPtr_FlushBufferIfDirty_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100676045);
			FileStream.NativeMethodInfoPtr_RefillBuffer_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100676046);
			FileStream.NativeMethodInfoPtr_ReadData_Private_Int32_SafeHandle_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100676047);
			FileStream.NativeMethodInfoPtr_InitBuffer_Private_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100676048);
			FileStream.NativeMethodInfoPtr_GetSecureFileName_Private_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100676049);
			FileStream.NativeMethodInfoPtr_GetSecureFileName_Private_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100676050);
		}

		// Token: 0x060052DD RID: 21213 RVA: 0x001823B0 File Offset: 0x001805B0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1432569, RefRangeEnd = 1432572, XrefRangeStart = 1432551, XrefRangeEnd = 1432569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FileStream(IntPtr handle, FileAccess access, bool ownsHandle, int bufferSize)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileStream>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref access;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ownsHandle;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileStream.NativeMethodInfoPtr__ctor_Public_Void_IntPtr_FileAccess_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052DE RID: 21214 RVA: 0x00182424 File Offset: 0x00180624
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1432598, RefRangeEnd = 1432599, XrefRangeStart = 1432572, XrefRangeEnd = 1432598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FileStream(IntPtr handle, FileAccess access, bool ownsHandle, int bufferSize, bool isAsync, bool isConsoleWrapper)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileStream>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref access;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ownsHandle;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferSize;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isAsync;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isConsoleWrapper;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileStream.NativeMethodInfoPtr__ctor_Internal_Void_IntPtr_FileAccess_Boolean_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052DF RID: 21215 RVA: 0x001824B4 File Offset: 0x001806B4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1432600, RefRangeEnd = 1432603, XrefRangeStart = 1432599, XrefRangeEnd = 1432600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FileStream(string path, FileMode mode, FileAccess access)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileStream>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref access;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileStream.NativeMethodInfoPtr__ctor_Public_Void_String_FileMode_FileAccess_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052E0 RID: 21216 RVA: 0x0018251C File Offset: 0x0018071C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1432604, RefRangeEnd = 1432610, XrefRangeStart = 1432603, XrefRangeEnd = 1432604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FileStream(string path, FileMode mode, FileAccess access, FileShare share)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileStream>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref access;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref share;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileStream.NativeMethodInfoPtr__ctor_Public_Void_String_FileMode_FileAccess_FileShare_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052E1 RID: 21217 RVA: 0x00182594 File Offset: 0x00180794
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1432611, RefRangeEnd = 1432612, XrefRangeStart = 1432610, XrefRangeEnd = 1432611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileStream>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref access;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref share;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileStream.NativeMethodInfoPtr__ctor_Public_Void_String_FileMode_FileAccess_FileShare_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052E2 RID: 21218 RVA: 0x00182618 File Offset: 0x00180818
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1432613, RefRangeEnd = 1432616, XrefRangeStart = 1432612, XrefRangeEnd = 1432613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool useAsync)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileStream>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref access;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref share;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferSize;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useAsync;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileStream.NativeMethodInfoPtr__ctor_Public_Void_String_FileMode_FileAccess_FileShare_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052E3 RID: 21219 RVA: 0x001826AC File Offset: 0x001808AC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1432617, RefRangeEnd = 1432621, XrefRangeStart = 1432616, XrefRangeEnd = 1432617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, FileOptions options)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileStream>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref access;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref share;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferSize;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileStream.NativeMethodInfoPtr__ctor_Public_Void_String_FileMode_FileAccess_FileShare_Int32_FileOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052E4 RID: 21220 RVA: 0x00182740 File Offset: 0x00180940
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1432630, RefRangeEnd = 1432631, XrefRangeStart = 1432621, XrefRangeEnd = 1432630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FileStream(SafeFileHandle handle, FileAccess access)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileStream>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref access;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileStream.NativeMethodInfoPtr__ctor_Public_Void_SafeFileHandle_FileAccess_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052E5 RID: 21221 RVA: 0x0018279C File Offset: 0x0018099C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1432631, XrefRangeEnd = 1432640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FileStream(SafeFileHandle handle, FileAccess access, int bufferSize, bool isAsync)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileStream>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref access;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferSize;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isAsync;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileStream.NativeMethodInfoPtr__ctor_Public_Void_SafeFileHandle_FileAccess_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052E6 RID: 21222 RVA: 0x00182814 File Offset: 0x00180A14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1432640, XrefRangeEnd = 1432641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool isAsync, bool anonymous)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileStream>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref access;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref share;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferSize;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isAsync;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref anonymous;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileStream.NativeMethodInfoPtr__ctor_Internal_Void_String_FileMode_FileAccess_FileShare_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052E7 RID: 21223 RVA: 0x001828B4 File Offset: 0x00180AB4
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1432689, RefRangeEnd = 1432699, XrefRangeStart = 1432641, XrefRangeEnd = 1432689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool anonymous, FileOptions options)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileStream>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref access;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref share;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferSize;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref anonymous;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileStream.NativeMethodInfoPtr__ctor_Internal_Void_String_FileMode_FileAccess_FileShare_Int32_Boolean_FileOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052E8 RID: 21224 RVA: 0x00182954 File Offset: 0x00180B54
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1432709, RefRangeEnd = 1432713, XrefRangeStart = 1432699, XrefRangeEnd = 1432709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(SafeFileHandle safeHandle, FileAccess access, bool ownsHandle, int bufferSize, bool isAsync, bool isConsoleWrapper)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(safeHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref access;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ownsHandle;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferSize;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isAsync;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isConsoleWrapper;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileStream.NativeMethodInfoPtr_Init_Private_Void_SafeFileHandle_FileAccess_Boolean_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001518 RID: 5400
		// (get) Token: 0x060052E9 RID: 21225 RVA: 0x001829DC File Offset: 0x00180BDC
		public unsafe override bool CanRead
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileStream.NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001519 RID: 5401
		// (get) Token: 0x060052EA RID: 21226 RVA: 0x00182A24 File Offset: 0x00180C24
		public unsafe override bool CanWrite
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileStream.NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700151A RID: 5402
		// (get) Token: 0x060052EB RID: 21227 RVA: 0x00182A6C File Offset: 0x00180C6C
		public unsafe override bool CanSeek
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileStream.NativeMethodInfoPtr_get_CanSeek_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700151B RID: 5403
		// (get) Token: 0x060052EC RID: 21228 RVA: 0x00182AB4 File Offset: 0x00180CB4
		public unsafe virtual string Name
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileStream.NativeMethodInfoPtr_get_Name_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700151C RID: 5404
		// (get) Token: 0x060052ED RID: 21229 RVA: 0x00182AF8 File Offset: 0x00180CF8
		public unsafe override long Length
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1432713, XrefRangeEnd = 1432719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileStream.NativeMethodInfoPtr_get_Length_Public_Virtual_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700151D RID: 5405
		// (get) Token: 0x060052EE RID: 21230 RVA: 0x00182B40 File Offset: 0x00180D40
		// (set) Token: 0x060052EF RID: 21231 RVA: 0x00182B88 File Offset: 0x00180D88
		public unsafe override long Position
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1432719, XrefRangeEnd = 1432725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileStream.NativeMethodInfoPtr_get_Position_Public_Virtual_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1432725, XrefRangeEnd = 1432733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileStream.NativeMethodInfoPtr_set_Position_Public_Virtual_set_Void_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700151E RID: 5406
		// (get) Token: 0x060052F0 RID: 21232 RVA: 0x00182BD4 File Offset: 0x00180DD4
		public unsafe virtual SafeFileHandle SafeFileHandle
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1432733, XrefRangeEnd = 1432735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileStream.NativeMethodInfoPtr_get_SafeFileHandle_Public_Virtual_New_get_SafeFileHandle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SafeFileHandle>(intPtr3) : null;
			}
		}

		// Token: 0x060052F1 RID: 21233 RVA: 0x00182C20 File Offset: 0x00180E20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1432735, XrefRangeEnd = 1432737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExposeHandle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileStream.NativeMethodInfoPtr_ExposeHandle_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052F2 RID: 21234 RVA: 0x00182C54 File Offset: 0x00180E54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1432737, XrefRangeEnd = 1432739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int ReadByte()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileStream.NativeMethodInfoPtr_ReadByte_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060052F3 RID: 21235 RVA: 0x00182C9C File Offset: 0x00180E9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1432739, XrefRangeEnd = 1432741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteByte(byte value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileStream.NativeMethodInfoPtr_WriteByte_Public_Virtual_Void_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060052F4 RID: 21236 RVA: 0x00182CE8 File Offset: 0x00180EE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1432749, RefRangeEnd = 1432750, XrefRangeStart = 1432741, XrefRangeEnd = 1432749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Read([In] [Out] Il2CppStructArray<byte> array, int offset, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileStream.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*array = ((intPtr4 == 0) ? null : new Il2CppStructArray<byte>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060052F5 RID: 21237 RVA: 0x00182D70 File Offset: 0x00180F70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1432750, XrefRangeEnd = 1432758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ReadInternal(Il2CppStructArray<byte> dest, int offset, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dest);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileStream.NativeMethodInfoPtr_ReadInternal_Private_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060052F6 RID: 21238 RVA: 0x00182DDC File Offset: 0x00180FDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1432774, RefRangeEnd = 1432775, XrefRangeStart = 1432758, XrefRangeEnd = 1432774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IAsyncResult BeginRead(Il2CppStructArray<byte> array, int offset, int numBytes, AsyncCallback userCallback, Object stateObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numBytes;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(userCallback);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stateObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileStream.NativeMethodInfoPtr_BeginRead_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x060052F7 RID: 21239 RVA: 0x00182E7C File Offset: 0x0018107C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1432781, RefRangeEnd = 1432782, XrefRangeStart = 1432775, XrefRangeEnd = 1432781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int EndRead(IAsyncResult asyncResult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileStream.NativeMethodInfoPtr_EndRead_Public_Virtual_Int32_IAsyncResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060052F8 RID: 21240 RVA: 0x00182ED4 File Offset: 0x001810D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1432784, RefRangeEnd = 1432785, XrefRangeStart = 1432782, XrefRangeEnd = 1432784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Write(Il2CppStructArray<byte> array, int offset, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileStream.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052F9 RID: 21241 RVA: 0x00182F40 File Offset: 0x00181140
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1432796, RefRangeEnd = 1432797, XrefRangeStart = 1432785, XrefRangeEnd = 1432796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteInternal(Il2CppStructArray<byte> src, int offset, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(src);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileStream.NativeMethodInfoPtr_WriteInternal_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052FA RID: 21242 RVA: 0x00182FA0 File Offset: 0x001811A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1432831, RefRangeEnd = 1432832, XrefRangeStart = 1432797, XrefRangeEnd = 1432831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IAsyncResult BeginWrite(Il2CppStructArray<byte> array, int offset, int numBytes, AsyncCallback userCallback, Object stateObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numBytes;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(userCallback);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stateObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileStream.NativeMethodInfoPtr_BeginWrite_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x060052FB RID: 21243 RVA: 0x00183040 File Offset: 0x00181240
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1432858, RefRangeEnd = 1432859, XrefRangeStart = 1432832, XrefRangeEnd = 1432858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void EndWrite(IAsyncResult asyncResult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileStream.NativeMethodInfoPtr_EndWrite_Public_Virtual_Void_IAsyncResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060052FC RID: 21244 RVA: 0x00183090 File Offset: 0x00181290
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1432859, XrefRangeEnd = 1432867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override long Seek(long offset, SeekOrigin origin)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref offset;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref origin;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileStream.NativeMethodInfoPtr_Seek_Public_Virtual_Int64_Int64_SeekOrigin_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060052FD RID: 21245 RVA: 0x001830F4 File Offset: 0x001812F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1432867, XrefRangeEnd = 1432873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetLength(long value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileStream.NativeMethodInfoPtr_SetLength_Public_Virtual_Void_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060052FE RID: 21246 RVA: 0x00183140 File Offset: 0x00181340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1432873, XrefRangeEnd = 1432882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Flush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileStream.NativeMethodInfoPtr_Flush_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052FF RID: 21247 RVA: 0x0018317C File Offset: 0x0018137C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileStream.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005300 RID: 21248 RVA: 0x001831B8 File Offset: 0x001813B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1432912, RefRangeEnd = 1432914, XrefRangeStart = 1432882, XrefRangeEnd = 1432912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileStream.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005301 RID: 21249 RVA: 0x00183204 File Offset: 0x00181404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1432914, XrefRangeEnd = 1432945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Task FlushAsync(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileStream.NativeMethodInfoPtr_FlushAsync_Public_Virtual_Task_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x06005302 RID: 21250 RVA: 0x00183264 File Offset: 0x00181464
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1432945, XrefRangeEnd = 1432957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Task<int> ReadAsync(Il2CppStructArray<byte> buffer, int offset, int count, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileStream.NativeMethodInfoPtr_ReadAsync_Public_Virtual_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<int>>(intPtr3) : null;
		}

		// Token: 0x06005303 RID: 21251 RVA: 0x001832F4 File Offset: 0x001814F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1432957, XrefRangeEnd = 1432967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Task WriteAsync(Il2CppStructArray<byte> buffer, int offset, int count, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileStream.NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06005304 RID: 21252 RVA: 0x00183384 File Offset: 0x00181584
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1432972, RefRangeEnd = 1432976, XrefRangeStart = 1432967, XrefRangeEnd = 1432972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ReadSegment(Il2CppStructArray<byte> dest, int dest_offset, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dest);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dest_offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileStream.NativeMethodInfoPtr_ReadSegment_Private_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005305 RID: 21253 RVA: 0x001833F0 File Offset: 0x001815F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1432976, XrefRangeEnd = 1432977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int WriteSegment(Il2CppStructArray<byte> src, int src_offset, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(src);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref src_offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileStream.NativeMethodInfoPtr_WriteSegment_Private_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005306 RID: 21254 RVA: 0x0018345C File Offset: 0x0018165C
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 1432984, RefRangeEnd = 1433001, XrefRangeStart = 1432977, XrefRangeEnd = 1432984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FlushBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileStream.NativeMethodInfoPtr_FlushBuffer_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005307 RID: 21255 RVA: 0x00183490 File Offset: 0x00181690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1433001, XrefRangeEnd = 1433002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FlushBufferIfDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileStream.NativeMethodInfoPtr_FlushBufferIfDirty_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005308 RID: 21256 RVA: 0x001834C4 File Offset: 0x001816C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1433004, RefRangeEnd = 1433005, XrefRangeStart = 1433002, XrefRangeEnd = 1433004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefillBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileStream.NativeMethodInfoPtr_RefillBuffer_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005309 RID: 21257 RVA: 0x001834F8 File Offset: 0x001816F8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1433010, RefRangeEnd = 1433015, XrefRangeStart = 1433005, XrefRangeEnd = 1433010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ReadData(SafeHandle safeHandle, Il2CppStructArray<byte> buf, int offset, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(safeHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buf);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileStream.NativeMethodInfoPtr_ReadData_Private_Int32_SafeHandle_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600530A RID: 21258 RVA: 0x00183574 File Offset: 0x00181774
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1433040, RefRangeEnd = 1433044, XrefRangeStart = 1433015, XrefRangeEnd = 1433040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitBuffer(int size, bool isZeroSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isZeroSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileStream.NativeMethodInfoPtr_InitBuffer_Private_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600530B RID: 21259 RVA: 0x001835C0 File Offset: 0x001817C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1433044, XrefRangeEnd = 1433050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetSecureFileName(string filename)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(filename);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileStream.NativeMethodInfoPtr_GetSecureFileName_Private_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600530C RID: 21260 RVA: 0x00183608 File Offset: 0x00181808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1433050, XrefRangeEnd = 1433057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetSecureFileName(string filename, bool full)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(filename);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref full;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileStream.NativeMethodInfoPtr_GetSecureFileName_Private_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600530D RID: 21261 RVA: 0x0001D63B File Offset: 0x0001B83B
		public FileStream(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001507 RID: 5383
		// (get) Token: 0x0600530E RID: 21262 RVA: 0x00183660 File Offset: 0x00181860
		// (set) Token: 0x0600530F RID: 21263 RVA: 0x0001D644 File Offset: 0x0001B844
		public unsafe static Il2CppStructArray<byte> buf_recycle
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FileStream.NativeFieldInfoPtr_buf_recycle, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FileStream.NativeFieldInfoPtr_buf_recycle, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001508 RID: 5384
		// (get) Token: 0x06005310 RID: 21264 RVA: 0x00183688 File Offset: 0x00181888
		// (set) Token: 0x06005311 RID: 21265 RVA: 0x0001D656 File Offset: 0x0001B856
		public unsafe static Object buf_recycle_lock
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FileStream.NativeFieldInfoPtr_buf_recycle_lock, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FileStream.NativeFieldInfoPtr_buf_recycle_lock, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001509 RID: 5385
		// (get) Token: 0x06005312 RID: 21266 RVA: 0x001836B0 File Offset: 0x001818B0
		// (set) Token: 0x06005313 RID: 21267 RVA: 0x0001D668 File Offset: 0x0001B868
		public unsafe Il2CppStructArray<byte> buf
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStream.NativeFieldInfoPtr_buf);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStream.NativeFieldInfoPtr_buf), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700150A RID: 5386
		// (get) Token: 0x06005314 RID: 21268 RVA: 0x001836E0 File Offset: 0x001818E0
		// (set) Token: 0x06005315 RID: 21269 RVA: 0x0001D687 File Offset: 0x0001B887
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStream.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStream.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700150B RID: 5387
		// (get) Token: 0x06005316 RID: 21270 RVA: 0x00183708 File Offset: 0x00181908
		// (set) Token: 0x06005317 RID: 21271 RVA: 0x0001D6A6 File Offset: 0x0001B8A6
		public unsafe SafeFileHandle safeHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStream.NativeFieldInfoPtr_safeHandle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SafeFileHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStream.NativeFieldInfoPtr_safeHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700150C RID: 5388
		// (get) Token: 0x06005318 RID: 21272 RVA: 0x00183738 File Offset: 0x00181938
		// (set) Token: 0x06005319 RID: 21273 RVA: 0x0001D6C5 File Offset: 0x0001B8C5
		public unsafe bool isExposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStream.NativeFieldInfoPtr_isExposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStream.NativeFieldInfoPtr_isExposed)) = value;
			}
		}

		// Token: 0x1700150D RID: 5389
		// (get) Token: 0x0600531A RID: 21274 RVA: 0x00183760 File Offset: 0x00181960
		// (set) Token: 0x0600531B RID: 21275 RVA: 0x0001D6E0 File Offset: 0x0001B8E0
		public unsafe long append_startpos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStream.NativeFieldInfoPtr_append_startpos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStream.NativeFieldInfoPtr_append_startpos)) = value;
			}
		}

		// Token: 0x1700150E RID: 5390
		// (get) Token: 0x0600531C RID: 21276 RVA: 0x00183788 File Offset: 0x00181988
		// (set) Token: 0x0600531D RID: 21277 RVA: 0x0001D6FB File Offset: 0x0001B8FB
		public unsafe FileAccess access
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStream.NativeFieldInfoPtr_access);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStream.NativeFieldInfoPtr_access)) = value;
			}
		}

		// Token: 0x1700150F RID: 5391
		// (get) Token: 0x0600531E RID: 21278 RVA: 0x001837B0 File Offset: 0x001819B0
		// (set) Token: 0x0600531F RID: 21279 RVA: 0x0001D716 File Offset: 0x0001B916
		public unsafe bool owner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStream.NativeFieldInfoPtr_owner);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStream.NativeFieldInfoPtr_owner)) = value;
			}
		}

		// Token: 0x17001510 RID: 5392
		// (get) Token: 0x06005320 RID: 21280 RVA: 0x001837D8 File Offset: 0x001819D8
		// (set) Token: 0x06005321 RID: 21281 RVA: 0x0001D731 File Offset: 0x0001B931
		public unsafe bool async
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStream.NativeFieldInfoPtr_async);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStream.NativeFieldInfoPtr_async)) = value;
			}
		}

		// Token: 0x17001511 RID: 5393
		// (get) Token: 0x06005322 RID: 21282 RVA: 0x00183800 File Offset: 0x00181A00
		// (set) Token: 0x06005323 RID: 21283 RVA: 0x0001D74C File Offset: 0x0001B94C
		public unsafe bool canseek
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStream.NativeFieldInfoPtr_canseek);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStream.NativeFieldInfoPtr_canseek)) = value;
			}
		}

		// Token: 0x17001512 RID: 5394
		// (get) Token: 0x06005324 RID: 21284 RVA: 0x00183828 File Offset: 0x00181A28
		// (set) Token: 0x06005325 RID: 21285 RVA: 0x0001D767 File Offset: 0x0001B967
		public unsafe bool anonymous
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStream.NativeFieldInfoPtr_anonymous);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStream.NativeFieldInfoPtr_anonymous)) = value;
			}
		}

		// Token: 0x17001513 RID: 5395
		// (get) Token: 0x06005326 RID: 21286 RVA: 0x00183850 File Offset: 0x00181A50
		// (set) Token: 0x06005327 RID: 21287 RVA: 0x0001D782 File Offset: 0x0001B982
		public unsafe bool buf_dirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStream.NativeFieldInfoPtr_buf_dirty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStream.NativeFieldInfoPtr_buf_dirty)) = value;
			}
		}

		// Token: 0x17001514 RID: 5396
		// (get) Token: 0x06005328 RID: 21288 RVA: 0x00183878 File Offset: 0x00181A78
		// (set) Token: 0x06005329 RID: 21289 RVA: 0x0001D79D File Offset: 0x0001B99D
		public unsafe int buf_size
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStream.NativeFieldInfoPtr_buf_size);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStream.NativeFieldInfoPtr_buf_size)) = value;
			}
		}

		// Token: 0x17001515 RID: 5397
		// (get) Token: 0x0600532A RID: 21290 RVA: 0x001838A0 File Offset: 0x00181AA0
		// (set) Token: 0x0600532B RID: 21291 RVA: 0x0001D7B8 File Offset: 0x0001B9B8
		public unsafe int buf_length
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStream.NativeFieldInfoPtr_buf_length);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStream.NativeFieldInfoPtr_buf_length)) = value;
			}
		}

		// Token: 0x17001516 RID: 5398
		// (get) Token: 0x0600532C RID: 21292 RVA: 0x001838C8 File Offset: 0x00181AC8
		// (set) Token: 0x0600532D RID: 21293 RVA: 0x0001D7D3 File Offset: 0x0001B9D3
		public unsafe int buf_offset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStream.NativeFieldInfoPtr_buf_offset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStream.NativeFieldInfoPtr_buf_offset)) = value;
			}
		}

		// Token: 0x17001517 RID: 5399
		// (get) Token: 0x0600532E RID: 21294 RVA: 0x001838F0 File Offset: 0x00181AF0
		// (set) Token: 0x0600532F RID: 21295 RVA: 0x0001D7EE File Offset: 0x0001B9EE
		public unsafe long buf_start
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStream.NativeFieldInfoPtr_buf_start);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStream.NativeFieldInfoPtr_buf_start)) = value;
			}
		}

		// Token: 0x040043AF RID: 17327
		private static readonly IntPtr NativeFieldInfoPtr_buf_recycle;

		// Token: 0x040043B0 RID: 17328
		private static readonly IntPtr NativeFieldInfoPtr_buf_recycle_lock;

		// Token: 0x040043B1 RID: 17329
		private static readonly IntPtr NativeFieldInfoPtr_buf;

		// Token: 0x040043B2 RID: 17330
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x040043B3 RID: 17331
		private static readonly IntPtr NativeFieldInfoPtr_safeHandle;

		// Token: 0x040043B4 RID: 17332
		private static readonly IntPtr NativeFieldInfoPtr_isExposed;

		// Token: 0x040043B5 RID: 17333
		private static readonly IntPtr NativeFieldInfoPtr_append_startpos;

		// Token: 0x040043B6 RID: 17334
		private static readonly IntPtr NativeFieldInfoPtr_access;

		// Token: 0x040043B7 RID: 17335
		private static readonly IntPtr NativeFieldInfoPtr_owner;

		// Token: 0x040043B8 RID: 17336
		private static readonly IntPtr NativeFieldInfoPtr_async;

		// Token: 0x040043B9 RID: 17337
		private static readonly IntPtr NativeFieldInfoPtr_canseek;

		// Token: 0x040043BA RID: 17338
		private static readonly IntPtr NativeFieldInfoPtr_anonymous;

		// Token: 0x040043BB RID: 17339
		private static readonly IntPtr NativeFieldInfoPtr_buf_dirty;

		// Token: 0x040043BC RID: 17340
		private static readonly IntPtr NativeFieldInfoPtr_buf_size;

		// Token: 0x040043BD RID: 17341
		private static readonly IntPtr NativeFieldInfoPtr_buf_length;

		// Token: 0x040043BE RID: 17342
		private static readonly IntPtr NativeFieldInfoPtr_buf_offset;

		// Token: 0x040043BF RID: 17343
		private static readonly IntPtr NativeFieldInfoPtr_buf_start;

		// Token: 0x040043C0 RID: 17344
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IntPtr_FileAccess_Boolean_Int32_0;

		// Token: 0x040043C1 RID: 17345
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IntPtr_FileAccess_Boolean_Int32_Boolean_Boolean_0;

		// Token: 0x040043C2 RID: 17346
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_FileMode_FileAccess_0;

		// Token: 0x040043C3 RID: 17347
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_FileMode_FileAccess_FileShare_0;

		// Token: 0x040043C4 RID: 17348
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_FileMode_FileAccess_FileShare_Int32_0;

		// Token: 0x040043C5 RID: 17349
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_FileMode_FileAccess_FileShare_Int32_Boolean_0;

		// Token: 0x040043C6 RID: 17350
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_FileMode_FileAccess_FileShare_Int32_FileOptions_0;

		// Token: 0x040043C7 RID: 17351
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SafeFileHandle_FileAccess_0;

		// Token: 0x040043C8 RID: 17352
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SafeFileHandle_FileAccess_Int32_Boolean_0;

		// Token: 0x040043C9 RID: 17353
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_FileMode_FileAccess_FileShare_Int32_Boolean_Boolean_0;

		// Token: 0x040043CA RID: 17354
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_FileMode_FileAccess_FileShare_Int32_Boolean_FileOptions_0;

		// Token: 0x040043CB RID: 17355
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_SafeFileHandle_FileAccess_Boolean_Int32_Boolean_Boolean_0;

		// Token: 0x040043CC RID: 17356
		private static readonly IntPtr NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0;

		// Token: 0x040043CD RID: 17357
		private static readonly IntPtr NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0;

		// Token: 0x040043CE RID: 17358
		private static readonly IntPtr NativeMethodInfoPtr_get_CanSeek_Public_Virtual_get_Boolean_0;

		// Token: 0x040043CF RID: 17359
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_New_get_String_0;

		// Token: 0x040043D0 RID: 17360
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_Virtual_get_Int64_0;

		// Token: 0x040043D1 RID: 17361
		private static readonly IntPtr NativeMethodInfoPtr_get_Position_Public_Virtual_get_Int64_0;

		// Token: 0x040043D2 RID: 17362
		private static readonly IntPtr NativeMethodInfoPtr_set_Position_Public_Virtual_set_Void_Int64_0;

		// Token: 0x040043D3 RID: 17363
		private static readonly IntPtr NativeMethodInfoPtr_get_SafeFileHandle_Public_Virtual_New_get_SafeFileHandle_0;

		// Token: 0x040043D4 RID: 17364
		private static readonly IntPtr NativeMethodInfoPtr_ExposeHandle_Private_Void_0;

		// Token: 0x040043D5 RID: 17365
		private static readonly IntPtr NativeMethodInfoPtr_ReadByte_Public_Virtual_Int32_0;

		// Token: 0x040043D6 RID: 17366
		private static readonly IntPtr NativeMethodInfoPtr_WriteByte_Public_Virtual_Void_Byte_0;

		// Token: 0x040043D7 RID: 17367
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x040043D8 RID: 17368
		private static readonly IntPtr NativeMethodInfoPtr_ReadInternal_Private_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x040043D9 RID: 17369
		private static readonly IntPtr NativeMethodInfoPtr_BeginRead_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0;

		// Token: 0x040043DA RID: 17370
		private static readonly IntPtr NativeMethodInfoPtr_EndRead_Public_Virtual_Int32_IAsyncResult_0;

		// Token: 0x040043DB RID: 17371
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x040043DC RID: 17372
		private static readonly IntPtr NativeMethodInfoPtr_WriteInternal_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x040043DD RID: 17373
		private static readonly IntPtr NativeMethodInfoPtr_BeginWrite_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0;

		// Token: 0x040043DE RID: 17374
		private static readonly IntPtr NativeMethodInfoPtr_EndWrite_Public_Virtual_Void_IAsyncResult_0;

		// Token: 0x040043DF RID: 17375
		private static readonly IntPtr NativeMethodInfoPtr_Seek_Public_Virtual_Int64_Int64_SeekOrigin_0;

		// Token: 0x040043E0 RID: 17376
		private static readonly IntPtr NativeMethodInfoPtr_SetLength_Public_Virtual_Void_Int64_0;

		// Token: 0x040043E1 RID: 17377
		private static readonly IntPtr NativeMethodInfoPtr_Flush_Public_Virtual_Void_0;

		// Token: 0x040043E2 RID: 17378
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x040043E3 RID: 17379
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x040043E4 RID: 17380
		private static readonly IntPtr NativeMethodInfoPtr_FlushAsync_Public_Virtual_Task_CancellationToken_0;

		// Token: 0x040043E5 RID: 17381
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsync_Public_Virtual_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0;

		// Token: 0x040043E6 RID: 17382
		private static readonly IntPtr NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0;

		// Token: 0x040043E7 RID: 17383
		private static readonly IntPtr NativeMethodInfoPtr_ReadSegment_Private_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x040043E8 RID: 17384
		private static readonly IntPtr NativeMethodInfoPtr_WriteSegment_Private_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x040043E9 RID: 17385
		private static readonly IntPtr NativeMethodInfoPtr_FlushBuffer_Private_Void_0;

		// Token: 0x040043EA RID: 17386
		private static readonly IntPtr NativeMethodInfoPtr_FlushBufferIfDirty_Private_Void_0;

		// Token: 0x040043EB RID: 17387
		private static readonly IntPtr NativeMethodInfoPtr_RefillBuffer_Private_Void_0;

		// Token: 0x040043EC RID: 17388
		private static readonly IntPtr NativeMethodInfoPtr_ReadData_Private_Int32_SafeHandle_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x040043ED RID: 17389
		private static readonly IntPtr NativeMethodInfoPtr_InitBuffer_Private_Void_Int32_Boolean_0;

		// Token: 0x040043EE RID: 17390
		private static readonly IntPtr NativeMethodInfoPtr_GetSecureFileName_Private_String_String_0;

		// Token: 0x040043EF RID: 17391
		private static readonly IntPtr NativeMethodInfoPtr_GetSecureFileName_Private_String_String_Boolean_0;

		// Token: 0x0200072B RID: 1835
		public sealed class ReadDelegate : MulticastDelegate
		{
			// Token: 0x060061EA RID: 25066 RVA: 0x001B74A0 File Offset: 0x001B56A0
			// Note: this type is marked as 'beforefieldinit'.
			static ReadDelegate()
			{
				Il2CppClassPointerStore<FileStream.ReadDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FileStream>.NativeClassPtr, "ReadDelegate");
				FileStream.ReadDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream.ReadDelegate>.NativeClassPtr, 100676052);
				FileStream.ReadDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream.ReadDelegate>.NativeClassPtr, 100676053);
				FileStream.ReadDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream.ReadDelegate>.NativeClassPtr, 100676054);
				FileStream.ReadDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Int32_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream.ReadDelegate>.NativeClassPtr, 100676055);
			}

			// Token: 0x060061EB RID: 25067 RVA: 0x001B7514 File Offset: 0x001B5714
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ReadDelegate(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileStream.ReadDelegate>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileStream.ReadDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060061EC RID: 25068 RVA: 0x001B7570 File Offset: 0x001B5770
			[CallerCount(0)]
			public unsafe int Invoke(Il2CppStructArray<byte> buffer, int offset, int count)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileStream.ReadDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060061ED RID: 25069 RVA: 0x001B75DC File Offset: 0x001B57DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1432539, XrefRangeEnd = 1432545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Il2CppStructArray<byte> buffer, int offset, int count, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileStream.ReadDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x060061EE RID: 25070 RVA: 0x001B7670 File Offset: 0x001B5870
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileStream.ReadDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Int32_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060061EF RID: 25071 RVA: 0x00024432 File Offset: 0x00022632
			public ReadDelegate(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060061F0 RID: 25072 RVA: 0x0002443B File Offset: 0x0002263B
			public static implicit operator FileStream.ReadDelegate(Func<Il2CppStructArray<byte>, int, int, int> A_0)
			{
				return DelegateSupport.ConvertDelegate<FileStream.ReadDelegate>(A_0);
			}

			// Token: 0x060061F1 RID: 25073 RVA: 0x00024443 File Offset: 0x00022643
			public static FileStream.ReadDelegate operator +(FileStream.ReadDelegate A_0, FileStream.ReadDelegate A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<FileStream.ReadDelegate>();
			}

			// Token: 0x060061F2 RID: 25074 RVA: 0x00024451 File Offset: 0x00022651
			public static FileStream.ReadDelegate operator -(FileStream.ReadDelegate A_0, FileStream.ReadDelegate A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<FileStream.ReadDelegate>();
				}
				return delegate2;
			}

			// Token: 0x04004F1F RID: 20255
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04004F20 RID: 20256
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

			// Token: 0x04004F21 RID: 20257
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0;

			// Token: 0x04004F22 RID: 20258
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Int32_IAsyncResult_0;
		}

		// Token: 0x0200072C RID: 1836
		public sealed class WriteDelegate : MulticastDelegate
		{
			// Token: 0x060061F3 RID: 25075 RVA: 0x001B76C0 File Offset: 0x001B58C0
			// Note: this type is marked as 'beforefieldinit'.
			static WriteDelegate()
			{
				Il2CppClassPointerStore<FileStream.WriteDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FileStream>.NativeClassPtr, "WriteDelegate");
				FileStream.WriteDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream.WriteDelegate>.NativeClassPtr, 100676056);
				FileStream.WriteDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream.WriteDelegate>.NativeClassPtr, 100676057);
				FileStream.WriteDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream.WriteDelegate>.NativeClassPtr, 100676058);
				FileStream.WriteDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream.WriteDelegate>.NativeClassPtr, 100676059);
			}

			// Token: 0x060061F4 RID: 25076 RVA: 0x001B7734 File Offset: 0x001B5934
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WriteDelegate(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileStream.WriteDelegate>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileStream.WriteDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060061F5 RID: 25077 RVA: 0x001B7790 File Offset: 0x001B5990
			[CallerCount(0)]
			public unsafe void Invoke(Il2CppStructArray<byte> buffer, int offset, int count)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileStream.WriteDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060061F6 RID: 25078 RVA: 0x001B77F0 File Offset: 0x001B59F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1432545, XrefRangeEnd = 1432551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Il2CppStructArray<byte> buffer, int offset, int count, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileStream.WriteDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x060061F7 RID: 25079 RVA: 0x001B7884 File Offset: 0x001B5A84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileStream.WriteDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060061F8 RID: 25080 RVA: 0x00024462 File Offset: 0x00022662
			public WriteDelegate(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060061F9 RID: 25081 RVA: 0x0002446B File Offset: 0x0002266B
			public static implicit operator FileStream.WriteDelegate(Action<Il2CppStructArray<byte>, int, int> A_0)
			{
				return DelegateSupport.ConvertDelegate<FileStream.WriteDelegate>(A_0);
			}

			// Token: 0x060061FA RID: 25082 RVA: 0x00024473 File Offset: 0x00022673
			public static FileStream.WriteDelegate operator +(FileStream.WriteDelegate A_0, FileStream.WriteDelegate A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<FileStream.WriteDelegate>();
			}

			// Token: 0x060061FB RID: 25083 RVA: 0x00024481 File Offset: 0x00022681
			public static FileStream.WriteDelegate operator -(FileStream.WriteDelegate A_0, FileStream.WriteDelegate A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<FileStream.WriteDelegate>();
				}
				return delegate2;
			}

			// Token: 0x04004F23 RID: 20259
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04004F24 RID: 20260
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

			// Token: 0x04004F25 RID: 20261
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0;

			// Token: 0x04004F26 RID: 20262
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}
	}
}
