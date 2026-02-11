using System;
using Google.Apis.Http;
using Google.Apis.Logging;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using Il2CppSystem.Net.Http;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Google.Apis.Upload
{
	// Token: 0x02000008 RID: 8
	public class ResumableUpload : Object
	{
		// Token: 0x06000023 RID: 35 RVA: 0x000052C0 File Offset: 0x000034C0
		// Note: this type is marked as 'beforefieldinit'.
		static ResumableUpload()
		{
			Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.dll", "Google.Apis.Upload", "ResumableUpload");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr);
			ResumableUpload.NativeFieldInfoPtr_Logger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, "Logger");
			ResumableUpload.NativeFieldInfoPtr_KB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, "KB");
			ResumableUpload.NativeFieldInfoPtr_MB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, "MB");
			ResumableUpload.NativeFieldInfoPtr_MinimumChunkSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, "MinimumChunkSize");
			ResumableUpload.NativeFieldInfoPtr_DefaultChunkSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, "DefaultChunkSize");
			ResumableUpload.NativeFieldInfoPtr_BufferSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, "BufferSize");
			ResumableUpload.NativeFieldInfoPtr_UnknownSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, "UnknownSize");
			ResumableUpload.NativeFieldInfoPtr_ZeroByteContentRangeHeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, "ZeroByteContentRangeHeader");
			ResumableUpload.NativeFieldInfoPtr_DefaultGoogleApiClientHeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, "DefaultGoogleApiClientHeader");
			ResumableUpload.NativeFieldInfoPtr__Options_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, "<Options>k__BackingField");
			ResumableUpload.NativeFieldInfoPtr__HttpClient_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, "<HttpClient>k__BackingField");
			ResumableUpload.NativeFieldInfoPtr__ContentStream_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, "<ContentStream>k__BackingField");
			ResumableUpload.NativeFieldInfoPtr__StreamLength_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, "<StreamLength>k__BackingField");
			ResumableUpload.NativeFieldInfoPtr__LastMediaRequest_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, "<LastMediaRequest>k__BackingField");
			ResumableUpload.NativeFieldInfoPtr__LastMediaLength_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, "<LastMediaLength>k__BackingField");
			ResumableUpload.NativeFieldInfoPtr__UploadUri_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, "<UploadUri>k__BackingField");
			ResumableUpload.NativeFieldInfoPtr__BytesServerReceived_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, "<BytesServerReceived>k__BackingField");
			ResumableUpload.NativeFieldInfoPtr__BytesClientSent_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, "<BytesClientSent>k__BackingField");
			ResumableUpload.NativeFieldInfoPtr_chunkSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, "chunkSize");
			ResumableUpload.NativeFieldInfoPtr_ProgressChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, "ProgressChanged");
			ResumableUpload.NativeFieldInfoPtr__UploadStreamInterceptor_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, "<UploadStreamInterceptor>k__BackingField");
			ResumableUpload.NativeFieldInfoPtr__Progress_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, "<Progress>k__BackingField");
			ResumableUpload.NativeFieldInfoPtr_UploadSessionData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, "UploadSessionData");
			ResumableUpload.NativeMethodInfoPtr__ctor_Protected_Void_Stream_ResumableUploadOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, 100663317);
			ResumableUpload.NativeMethodInfoPtr_CreateFromUploadUri_Public_Static_ResumableUpload_Uri_Stream_ResumableUploadOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, 100663318);
			ResumableUpload.NativeMethodInfoPtr_get_Options_Protected_get_ResumableUploadOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, 100663319);
			ResumableUpload.NativeMethodInfoPtr_get_HttpClient_Internal_get_ConfigurableHttpClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, 100663320);
			ResumableUpload.NativeMethodInfoPtr_get_ContentStream_Public_get_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, 100663321);
			ResumableUpload.NativeMethodInfoPtr_get_StreamLength_Internal_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, 100663322);
			ResumableUpload.NativeMethodInfoPtr_set_StreamLength_Internal_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, 100663323);
			ResumableUpload.NativeMethodInfoPtr_get_LastMediaRequest_Private_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, 100663324);
			ResumableUpload.NativeMethodInfoPtr_set_LastMediaRequest_Private_set_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, 100663325);
			ResumableUpload.NativeMethodInfoPtr_get_LastMediaLength_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, 100663326);
			ResumableUpload.NativeMethodInfoPtr_set_LastMediaLength_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, 100663327);
			ResumableUpload.NativeMethodInfoPtr_get_UploadUri_Private_get_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, 100663328);
			ResumableUpload.NativeMethodInfoPtr_set_UploadUri_Private_set_Void_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, 100663329);
			ResumableUpload.NativeMethodInfoPtr_get_BytesServerReceived_Private_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, 100663330);
			ResumableUpload.NativeMethodInfoPtr_set_BytesServerReceived_Private_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, 100663331);
			ResumableUpload.NativeMethodInfoPtr_get_BytesClientSent_Private_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, 100663332);
			ResumableUpload.NativeMethodInfoPtr_set_BytesClientSent_Private_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, 100663333);
			ResumableUpload.NativeMethodInfoPtr_get_ChunkSize_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, 100663334);
			ResumableUpload.NativeMethodInfoPtr_set_ChunkSize_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, 100663335);
			ResumableUpload.NativeMethodInfoPtr_add_ProgressChanged_Public_add_Void_Action_1_IUploadProgress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, 100663336);
			ResumableUpload.NativeMethodInfoPtr_remove_ProgressChanged_Public_rem_Void_Action_1_IUploadProgress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, 100663337);
			ResumableUpload.NativeMethodInfoPtr_get_UploadStreamInterceptor_Public_get_StreamInterceptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, 100663338);
			ResumableUpload.NativeMethodInfoPtr_set_UploadStreamInterceptor_Public_set_Void_StreamInterceptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, 100663339);
			ResumableUpload.NativeMethodInfoPtr_get_Progress_Private_get_ResumableUploadProgress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, 100663340);
			ResumableUpload.NativeMethodInfoPtr_set_Progress_Private_set_Void_ResumableUploadProgress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, 100663341);
			ResumableUpload.NativeMethodInfoPtr_UpdateProgress_Private_Void_ResumableUploadProgress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, 100663342);
			ResumableUpload.NativeMethodInfoPtr_GetProgress_Public_IUploadProgress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, 100663343);
			ResumableUpload.NativeMethodInfoPtr_add_UploadSessionData_Public_add_Void_Action_1_IUploadSessionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, 100663344);
			ResumableUpload.NativeMethodInfoPtr_remove_UploadSessionData_Public_rem_Void_Action_1_IUploadSessionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, 100663345);
			ResumableUpload.NativeMethodInfoPtr_SendUploadSessionData_Private_Void_ResumeableUploadSessionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, 100663346);
			ResumableUpload.NativeMethodInfoPtr_Upload_Public_IUploadProgress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, 100663347);
			ResumableUpload.NativeMethodInfoPtr_UploadAsync_Public_Task_1_IUploadProgress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, 100663348);
			ResumableUpload.NativeMethodInfoPtr_UploadAsync_Public_Task_1_IUploadProgress_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, 100663349);
			ResumableUpload.NativeMethodInfoPtr_Resume_Public_IUploadProgress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, 100663350);
			ResumableUpload.NativeMethodInfoPtr_Resume_Public_IUploadProgress_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, 100663351);
			ResumableUpload.NativeMethodInfoPtr_ResumeAsync_Public_Task_1_IUploadProgress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, 100663352);
			ResumableUpload.NativeMethodInfoPtr_ResumeAsync_Public_Task_1_IUploadProgress_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, 100663353);
			ResumableUpload.NativeMethodInfoPtr_ResumeAsync_Public_Task_1_IUploadProgress_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, 100663354);
			ResumableUpload.NativeMethodInfoPtr_ResumeAsync_Public_Task_1_IUploadProgress_Uri_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, 100663355);
			ResumableUpload.NativeMethodInfoPtr_UploadCoreAsync_Private_Task_1_IUploadProgress_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, 100663356);
			ResumableUpload.NativeMethodInfoPtr_InitiateSessionAsync_Public_Abstract_Virtual_New_Task_1_Uri_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, 100663357);
			ResumableUpload.NativeMethodInfoPtr_ProcessResponse_Protected_Virtual_New_Void_HttpResponseMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, 100663358);
			ResumableUpload.NativeMethodInfoPtr_SendNextChunkAsync_Protected_Task_1_Boolean_Stream_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, 100663359);
			ResumableUpload.NativeMethodInfoPtr_HandleResponse_Private_Task_1_Boolean_HttpResponseMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, 100663360);
			ResumableUpload.NativeMethodInfoPtr_ExceptionForResponseAsync_Protected_Task_1_GoogleApiException_HttpResponseMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, 100663361);
			ResumableUpload.NativeMethodInfoPtr_MediaCompleted_Private_Void_HttpResponseMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, 100663362);
			ResumableUpload.NativeMethodInfoPtr_PrepareNextChunkUnknownSizeAsync_Private_Task_1_Tuple_2_Il2CppStructArray_1_Byte_Int32_Stream_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, 100663363);
			ResumableUpload.NativeMethodInfoPtr_PrepareNextChunkKnownSizeAsync_Private_Task_1_Tuple_2_Il2CppStructArray_1_Byte_Int32_Stream_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, 100663364);
			ResumableUpload.NativeMethodInfoPtr_GetNextByte_Private_Int64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, 100663365);
			ResumableUpload.NativeMethodInfoPtr_GetContentRangeHeader_Private_String_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, 100663366);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000058A4 File Offset: 0x00003AA4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1196339, RefRangeEnd = 1196342, XrefRangeStart = 1196307, XrefRangeEnd = 1196339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResumableUpload(Stream contentStream, ResumableUploadOptions options)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(contentStream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload.NativeMethodInfoPtr__ctor_Protected_Void_Stream_ResumableUploadOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00005904 File Offset: 0x00003B04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1196342, XrefRangeEnd = 1196355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ResumableUpload CreateFromUploadUri(Uri uploadUri, Stream contentStream, ResumableUploadOptions options = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uploadUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contentStream);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload.NativeMethodInfoPtr_CreateFromUploadUri_Public_Static_ResumableUpload_Uri_Stream_ResumableUploadOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResumableUpload>(intPtr3) : null;
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000026 RID: 38 RVA: 0x0000596C File Offset: 0x00003B6C
		public unsafe ResumableUploadOptions Options
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload.NativeMethodInfoPtr_get_Options_Protected_get_ResumableUploadOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResumableUploadOptions>(intPtr3) : null;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000027 RID: 39 RVA: 0x000059AC File Offset: 0x00003BAC
		public unsafe ConfigurableHttpClient HttpClient
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload.NativeMethodInfoPtr_get_HttpClient_Internal_get_ConfigurableHttpClient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigurableHttpClient>(intPtr3) : null;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000028 RID: 40 RVA: 0x000059EC File Offset: 0x00003BEC
		public unsafe Stream ContentStream
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload.NativeMethodInfoPtr_get_ContentStream_Public_get_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000029 RID: 41 RVA: 0x00005A2C File Offset: 0x00003C2C
		// (set) Token: 0x0600002A RID: 42 RVA: 0x00005A68 File Offset: 0x00003C68
		public unsafe long StreamLength
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload.NativeMethodInfoPtr_get_StreamLength_Internal_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload.NativeMethodInfoPtr_set_StreamLength_Internal_set_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600002B RID: 43 RVA: 0x00005AA8 File Offset: 0x00003CA8
		// (set) Token: 0x0600002C RID: 44 RVA: 0x00005AE8 File Offset: 0x00003CE8
		public unsafe Il2CppStructArray<byte> LastMediaRequest
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload.NativeMethodInfoPtr_get_LastMediaRequest_Private_get_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload.NativeMethodInfoPtr_set_LastMediaRequest_Private_set_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600002D RID: 45 RVA: 0x00005B2C File Offset: 0x00003D2C
		// (set) Token: 0x0600002E RID: 46 RVA: 0x00005B68 File Offset: 0x00003D68
		public unsafe int LastMediaLength
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload.NativeMethodInfoPtr_get_LastMediaLength_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload.NativeMethodInfoPtr_set_LastMediaLength_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600002F RID: 47 RVA: 0x00005BA8 File Offset: 0x00003DA8
		// (set) Token: 0x06000030 RID: 48 RVA: 0x00005BE8 File Offset: 0x00003DE8
		public unsafe Uri UploadUri
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload.NativeMethodInfoPtr_get_UploadUri_Private_get_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload.NativeMethodInfoPtr_set_UploadUri_Private_set_Void_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000031 RID: 49 RVA: 0x00005C2C File Offset: 0x00003E2C
		// (set) Token: 0x06000032 RID: 50 RVA: 0x00005C68 File Offset: 0x00003E68
		public unsafe long BytesServerReceived
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload.NativeMethodInfoPtr_get_BytesServerReceived_Private_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload.NativeMethodInfoPtr_set_BytesServerReceived_Private_set_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000033 RID: 51 RVA: 0x00005CA8 File Offset: 0x00003EA8
		// (set) Token: 0x06000034 RID: 52 RVA: 0x00005CE4 File Offset: 0x00003EE4
		public unsafe long BytesClientSent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload.NativeMethodInfoPtr_get_BytesClientSent_Private_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload.NativeMethodInfoPtr_set_BytesClientSent_Private_set_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000035 RID: 53 RVA: 0x00005D24 File Offset: 0x00003F24
		// (set) Token: 0x06000036 RID: 54 RVA: 0x00005D60 File Offset: 0x00003F60
		public unsafe int ChunkSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload.NativeMethodInfoPtr_get_ChunkSize_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload.NativeMethodInfoPtr_set_ChunkSize_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00005DA0 File Offset: 0x00003FA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1196355, XrefRangeEnd = 1196360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_ProgressChanged(Action<IUploadProgress> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload.NativeMethodInfoPtr_add_ProgressChanged_Public_add_Void_Action_1_IUploadProgress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00005DE4 File Offset: 0x00003FE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1196360, XrefRangeEnd = 1196365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_ProgressChanged(Action<IUploadProgress> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload.NativeMethodInfoPtr_remove_ProgressChanged_Public_rem_Void_Action_1_IUploadProgress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000039 RID: 57 RVA: 0x00005E28 File Offset: 0x00004028
		// (set) Token: 0x0600003A RID: 58 RVA: 0x00005E68 File Offset: 0x00004068
		public unsafe StreamInterceptor UploadStreamInterceptor
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 34746, RefRangeEnd = 34747, XrefRangeStart = 34746, XrefRangeEnd = 34747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload.NativeMethodInfoPtr_get_UploadStreamInterceptor_Public_get_StreamInterceptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StreamInterceptor>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload.NativeMethodInfoPtr_set_UploadStreamInterceptor_Public_set_Void_StreamInterceptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600003B RID: 59 RVA: 0x00005EAC File Offset: 0x000040AC
		// (set) Token: 0x0600003C RID: 60 RVA: 0x00005EEC File Offset: 0x000040EC
		public unsafe ResumableUpload.ResumableUploadProgress Progress
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload.NativeMethodInfoPtr_get_Progress_Private_get_ResumableUploadProgress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResumableUpload.ResumableUploadProgress>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload.NativeMethodInfoPtr_set_Progress_Private_set_Void_ResumableUploadProgress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00005F30 File Offset: 0x00004130
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1196366, RefRangeEnd = 1196369, XrefRangeStart = 1196365, XrefRangeEnd = 1196366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateProgress(ResumableUpload.ResumableUploadProgress progress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(progress);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload.NativeMethodInfoPtr_UpdateProgress_Private_Void_ResumableUploadProgress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00005F74 File Offset: 0x00004174
		[CallerCount(0)]
		public unsafe IUploadProgress GetProgress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload.NativeMethodInfoPtr_GetProgress_Public_IUploadProgress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IUploadProgress>(intPtr3) : null;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00005FB4 File Offset: 0x000041B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1196369, XrefRangeEnd = 1196374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_UploadSessionData(Action<IUploadSessionData> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload.NativeMethodInfoPtr_add_UploadSessionData_Public_add_Void_Action_1_IUploadSessionData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00005FF8 File Offset: 0x000041F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1196374, XrefRangeEnd = 1196379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_UploadSessionData(Action<IUploadSessionData> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload.NativeMethodInfoPtr_remove_UploadSessionData_Public_rem_Void_Action_1_IUploadSessionData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000041 RID: 65 RVA: 0x0000603C File Offset: 0x0000423C
		[CallerCount(0)]
		public unsafe void SendUploadSessionData(ResumableUpload.ResumeableUploadSessionData sessionData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sessionData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload.NativeMethodInfoPtr_SendUploadSessionData_Private_Void_ResumeableUploadSessionData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00006080 File Offset: 0x00004280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1196379, XrefRangeEnd = 1196418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IUploadProgress Upload()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload.NativeMethodInfoPtr_Upload_Public_IUploadProgress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IUploadProgress>(intPtr3) : null;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000060C0 File Offset: 0x000042C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1196418, XrefRangeEnd = 1196423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<IUploadProgress> UploadAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload.NativeMethodInfoPtr_UploadAsync_Public_Task_1_IUploadProgress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<IUploadProgress>>(intPtr3) : null;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00006100 File Offset: 0x00004300
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1196438, RefRangeEnd = 1196441, XrefRangeStart = 1196423, XrefRangeEnd = 1196438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<IUploadProgress> UploadAsync(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload.NativeMethodInfoPtr_UploadAsync_Public_Task_1_IUploadProgress_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<IUploadProgress>>(intPtr3) : null;
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00006158 File Offset: 0x00004358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1196441, XrefRangeEnd = 1196450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IUploadProgress Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload.NativeMethodInfoPtr_Resume_Public_IUploadProgress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IUploadProgress>(intPtr3) : null;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00006198 File Offset: 0x00004398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1196450, XrefRangeEnd = 1196459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IUploadProgress Resume(Uri uploadUri)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uploadUri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload.NativeMethodInfoPtr_Resume_Public_IUploadProgress_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IUploadProgress>(intPtr3) : null;
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000061E8 File Offset: 0x000043E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1196459, XrefRangeEnd = 1196464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<IUploadProgress> ResumeAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload.NativeMethodInfoPtr_ResumeAsync_Public_Task_1_IUploadProgress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<IUploadProgress>>(intPtr3) : null;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00006228 File Offset: 0x00004428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1196464, XrefRangeEnd = 1196465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<IUploadProgress> ResumeAsync(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload.NativeMethodInfoPtr_ResumeAsync_Public_Task_1_IUploadProgress_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<IUploadProgress>>(intPtr3) : null;
			}
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00006280 File Offset: 0x00004480
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1196465, XrefRangeEnd = 1196470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<IUploadProgress> ResumeAsync(Uri uploadUri)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uploadUri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload.NativeMethodInfoPtr_ResumeAsync_Public_Task_1_IUploadProgress_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<IUploadProgress>>(intPtr3) : null;
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000062D0 File Offset: 0x000044D0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1196486, RefRangeEnd = 1196491, XrefRangeStart = 1196470, XrefRangeEnd = 1196486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<IUploadProgress> ResumeAsync(Uri uploadUri, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uploadUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload.NativeMethodInfoPtr_ResumeAsync_Public_Task_1_IUploadProgress_Uri_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<IUploadProgress>>(intPtr3) : null;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00006338 File Offset: 0x00004538
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1196506, RefRangeEnd = 1196508, XrefRangeStart = 1196491, XrefRangeEnd = 1196506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<IUploadProgress> UploadCoreAsync(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload.NativeMethodInfoPtr_UploadCoreAsync_Private_Task_1_IUploadProgress_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<IUploadProgress>>(intPtr3) : null;
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00006390 File Offset: 0x00004590
		[CallerCount(0)]
		public unsafe virtual Task<Uri> InitiateSessionAsync(CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResumableUpload.NativeMethodInfoPtr_InitiateSessionAsync_Public_Abstract_Virtual_New_Task_1_Uri_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Uri>>(intPtr3) : null;
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x000063F0 File Offset: 0x000045F0
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ProcessResponse(HttpResponseMessage httpResponse)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(httpResponse);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResumableUpload.NativeMethodInfoPtr_ProcessResponse_Protected_Virtual_New_Void_HttpResponseMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00006440 File Offset: 0x00004640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1196508, XrefRangeEnd = 1196524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<bool> SendNextChunkAsync(Stream stream, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload.NativeMethodInfoPtr_SendNextChunkAsync_Protected_Task_1_Boolean_Stream_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr3) : null;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000064A8 File Offset: 0x000046A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1196539, RefRangeEnd = 1196541, XrefRangeStart = 1196524, XrefRangeEnd = 1196539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<bool> HandleResponse(HttpResponseMessage response)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(response);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload.NativeMethodInfoPtr_HandleResponse_Private_Task_1_Boolean_HttpResponseMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr3) : null;
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000064F8 File Offset: 0x000046F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1196541, XrefRangeEnd = 1196543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<GoogleApiException> ExceptionForResponseAsync(HttpResponseMessage response)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(response);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload.NativeMethodInfoPtr_ExceptionForResponseAsync_Protected_Task_1_GoogleApiException_HttpResponseMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<GoogleApiException>>(intPtr3) : null;
			}
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00006548 File Offset: 0x00004748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1196543, XrefRangeEnd = 1196562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MediaCompleted(HttpResponseMessage response)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(response);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload.NativeMethodInfoPtr_MediaCompleted_Private_Void_HttpResponseMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000052 RID: 82 RVA: 0x0000658C File Offset: 0x0000478C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1196562, XrefRangeEnd = 1196578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<Tuple<Il2CppStructArray<byte>, int>> PrepareNextChunkUnknownSizeAsync(Stream stream, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload.NativeMethodInfoPtr_PrepareNextChunkUnknownSizeAsync_Private_Task_1_Tuple_2_Il2CppStructArray_1_Byte_Int32_Stream_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Tuple<Il2CppStructArray<byte>, int>>>(intPtr3) : null;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x000065F4 File Offset: 0x000047F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1196578, XrefRangeEnd = 1196594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<Tuple<Il2CppStructArray<byte>, int>> PrepareNextChunkKnownSizeAsync(Stream stream, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload.NativeMethodInfoPtr_PrepareNextChunkKnownSizeAsync_Private_Task_1_Tuple_2_Il2CppStructArray_1_Byte_Int32_Stream_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Tuple<Il2CppStructArray<byte>, int>>>(intPtr3) : null;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x0000665C File Offset: 0x0000485C
		[CallerCount(0)]
		public unsafe long GetNextByte(string range)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(range);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload.NativeMethodInfoPtr_GetNextByte_Private_Int64_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000055 RID: 85 RVA: 0x000066AC File Offset: 0x000048AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1196594, XrefRangeEnd = 1196602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetContentRangeHeader(long chunkStart, long chunkSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref chunkStart;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref chunkSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload.NativeMethodInfoPtr_GetContentRangeHeader_Private_String_Int64_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000020F8 File Offset: 0x000002F8
		public ResumableUpload(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000057 RID: 87 RVA: 0x00006700 File Offset: 0x00004900
		// (set) Token: 0x06000058 RID: 88 RVA: 0x00002101 File Offset: 0x00000301
		public unsafe static ILogger Logger
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ResumableUpload.NativeFieldInfoPtr_Logger, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ILogger>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResumableUpload.NativeFieldInfoPtr_Logger, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000059 RID: 89 RVA: 0x00006728 File Offset: 0x00004928
		// (set) Token: 0x0600005A RID: 90 RVA: 0x00002113 File Offset: 0x00000313
		public unsafe static int KB
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ResumableUpload.NativeFieldInfoPtr_KB, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResumableUpload.NativeFieldInfoPtr_KB, (void*)(&value));
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600005B RID: 91 RVA: 0x00006744 File Offset: 0x00004944
		// (set) Token: 0x0600005C RID: 92 RVA: 0x00002121 File Offset: 0x00000321
		public unsafe static int MB
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ResumableUpload.NativeFieldInfoPtr_MB, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResumableUpload.NativeFieldInfoPtr_MB, (void*)(&value));
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600005D RID: 93 RVA: 0x00006760 File Offset: 0x00004960
		// (set) Token: 0x0600005E RID: 94 RVA: 0x0000212F File Offset: 0x0000032F
		public unsafe static int MinimumChunkSize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ResumableUpload.NativeFieldInfoPtr_MinimumChunkSize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResumableUpload.NativeFieldInfoPtr_MinimumChunkSize, (void*)(&value));
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600005F RID: 95 RVA: 0x0000677C File Offset: 0x0000497C
		// (set) Token: 0x06000060 RID: 96 RVA: 0x0000213D File Offset: 0x0000033D
		public unsafe static int DefaultChunkSize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ResumableUpload.NativeFieldInfoPtr_DefaultChunkSize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResumableUpload.NativeFieldInfoPtr_DefaultChunkSize, (void*)(&value));
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000061 RID: 97 RVA: 0x00006798 File Offset: 0x00004998
		// (set) Token: 0x06000062 RID: 98 RVA: 0x0000214B File Offset: 0x0000034B
		public unsafe int BufferSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload.NativeFieldInfoPtr_BufferSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload.NativeFieldInfoPtr_BufferSize)) = value;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000063 RID: 99 RVA: 0x000067C0 File Offset: 0x000049C0
		// (set) Token: 0x06000064 RID: 100 RVA: 0x00002166 File Offset: 0x00000366
		public unsafe static int UnknownSize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ResumableUpload.NativeFieldInfoPtr_UnknownSize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResumableUpload.NativeFieldInfoPtr_UnknownSize, (void*)(&value));
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000065 RID: 101 RVA: 0x000067DC File Offset: 0x000049DC
		// (set) Token: 0x06000066 RID: 102 RVA: 0x00002174 File Offset: 0x00000374
		public unsafe static string ZeroByteContentRangeHeader
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ResumableUpload.NativeFieldInfoPtr_ZeroByteContentRangeHeader, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResumableUpload.NativeFieldInfoPtr_ZeroByteContentRangeHeader, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000067 RID: 103 RVA: 0x000067FC File Offset: 0x000049FC
		// (set) Token: 0x06000068 RID: 104 RVA: 0x00002186 File Offset: 0x00000386
		public unsafe static string DefaultGoogleApiClientHeader
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ResumableUpload.NativeFieldInfoPtr_DefaultGoogleApiClientHeader, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResumableUpload.NativeFieldInfoPtr_DefaultGoogleApiClientHeader, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000069 RID: 105 RVA: 0x0000681C File Offset: 0x00004A1C
		// (set) Token: 0x0600006A RID: 106 RVA: 0x00002198 File Offset: 0x00000398
		public unsafe ResumableUploadOptions _Options_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload.NativeFieldInfoPtr__Options_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResumableUploadOptions>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload.NativeFieldInfoPtr__Options_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600006B RID: 107 RVA: 0x0000684C File Offset: 0x00004A4C
		// (set) Token: 0x0600006C RID: 108 RVA: 0x000021B7 File Offset: 0x000003B7
		public unsafe ConfigurableHttpClient _HttpClient_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload.NativeFieldInfoPtr__HttpClient_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigurableHttpClient>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload.NativeFieldInfoPtr__HttpClient_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600006D RID: 109 RVA: 0x0000687C File Offset: 0x00004A7C
		// (set) Token: 0x0600006E RID: 110 RVA: 0x000021D6 File Offset: 0x000003D6
		public unsafe Stream _ContentStream_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload.NativeFieldInfoPtr__ContentStream_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload.NativeFieldInfoPtr__ContentStream_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600006F RID: 111 RVA: 0x000068AC File Offset: 0x00004AAC
		// (set) Token: 0x06000070 RID: 112 RVA: 0x000021F5 File Offset: 0x000003F5
		public unsafe long _StreamLength_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload.NativeFieldInfoPtr__StreamLength_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload.NativeFieldInfoPtr__StreamLength_k__BackingField)) = value;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000071 RID: 113 RVA: 0x000068D4 File Offset: 0x00004AD4
		// (set) Token: 0x06000072 RID: 114 RVA: 0x00002210 File Offset: 0x00000410
		public unsafe Il2CppStructArray<byte> _LastMediaRequest_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload.NativeFieldInfoPtr__LastMediaRequest_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload.NativeFieldInfoPtr__LastMediaRequest_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000073 RID: 115 RVA: 0x00006904 File Offset: 0x00004B04
		// (set) Token: 0x06000074 RID: 116 RVA: 0x0000222F File Offset: 0x0000042F
		public unsafe int _LastMediaLength_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload.NativeFieldInfoPtr__LastMediaLength_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload.NativeFieldInfoPtr__LastMediaLength_k__BackingField)) = value;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000075 RID: 117 RVA: 0x0000692C File Offset: 0x00004B2C
		// (set) Token: 0x06000076 RID: 118 RVA: 0x0000224A File Offset: 0x0000044A
		public unsafe Uri _UploadUri_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload.NativeFieldInfoPtr__UploadUri_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload.NativeFieldInfoPtr__UploadUri_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000077 RID: 119 RVA: 0x0000695C File Offset: 0x00004B5C
		// (set) Token: 0x06000078 RID: 120 RVA: 0x00002269 File Offset: 0x00000469
		public unsafe long _BytesServerReceived_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload.NativeFieldInfoPtr__BytesServerReceived_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload.NativeFieldInfoPtr__BytesServerReceived_k__BackingField)) = value;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000079 RID: 121 RVA: 0x00006984 File Offset: 0x00004B84
		// (set) Token: 0x0600007A RID: 122 RVA: 0x00002284 File Offset: 0x00000484
		public unsafe long _BytesClientSent_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload.NativeFieldInfoPtr__BytesClientSent_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload.NativeFieldInfoPtr__BytesClientSent_k__BackingField)) = value;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600007B RID: 123 RVA: 0x000069AC File Offset: 0x00004BAC
		// (set) Token: 0x0600007C RID: 124 RVA: 0x0000229F File Offset: 0x0000049F
		public unsafe int chunkSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload.NativeFieldInfoPtr_chunkSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload.NativeFieldInfoPtr_chunkSize)) = value;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600007D RID: 125 RVA: 0x000069D4 File Offset: 0x00004BD4
		// (set) Token: 0x0600007E RID: 126 RVA: 0x000022BA File Offset: 0x000004BA
		public unsafe Action<IUploadProgress> ProgressChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload.NativeFieldInfoPtr_ProgressChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<IUploadProgress>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload.NativeFieldInfoPtr_ProgressChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600007F RID: 127 RVA: 0x00006A04 File Offset: 0x00004C04
		// (set) Token: 0x06000080 RID: 128 RVA: 0x000022D9 File Offset: 0x000004D9
		public unsafe StreamInterceptor _UploadStreamInterceptor_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload.NativeFieldInfoPtr__UploadStreamInterceptor_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StreamInterceptor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload.NativeFieldInfoPtr__UploadStreamInterceptor_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000081 RID: 129 RVA: 0x00006A34 File Offset: 0x00004C34
		// (set) Token: 0x06000082 RID: 130 RVA: 0x000022F8 File Offset: 0x000004F8
		public unsafe ResumableUpload.ResumableUploadProgress _Progress_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload.NativeFieldInfoPtr__Progress_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResumableUpload.ResumableUploadProgress>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload.NativeFieldInfoPtr__Progress_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000083 RID: 131 RVA: 0x00006A64 File Offset: 0x00004C64
		// (set) Token: 0x06000084 RID: 132 RVA: 0x00002317 File Offset: 0x00000517
		public unsafe Action<IUploadSessionData> UploadSessionData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload.NativeFieldInfoPtr_UploadSessionData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<IUploadSessionData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload.NativeFieldInfoPtr_UploadSessionData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeFieldInfoPtr_Logger;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeFieldInfoPtr_KB;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeFieldInfoPtr_MB;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeFieldInfoPtr_MinimumChunkSize;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeFieldInfoPtr_DefaultChunkSize;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeFieldInfoPtr_BufferSize;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeFieldInfoPtr_UnknownSize;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeFieldInfoPtr_ZeroByteContentRangeHeader;

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeFieldInfoPtr_DefaultGoogleApiClientHeader;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeFieldInfoPtr__Options_k__BackingField;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeFieldInfoPtr__HttpClient_k__BackingField;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeFieldInfoPtr__ContentStream_k__BackingField;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeFieldInfoPtr__StreamLength_k__BackingField;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeFieldInfoPtr__LastMediaRequest_k__BackingField;

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeFieldInfoPtr__LastMediaLength_k__BackingField;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeFieldInfoPtr__UploadUri_k__BackingField;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeFieldInfoPtr__BytesServerReceived_k__BackingField;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeFieldInfoPtr__BytesClientSent_k__BackingField;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeFieldInfoPtr_chunkSize;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeFieldInfoPtr_ProgressChanged;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeFieldInfoPtr__UploadStreamInterceptor_k__BackingField;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeFieldInfoPtr__Progress_k__BackingField;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeFieldInfoPtr_UploadSessionData;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Stream_ResumableUploadOptions_0;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeMethodInfoPtr_CreateFromUploadUri_Public_Static_ResumableUpload_Uri_Stream_ResumableUploadOptions_0;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeMethodInfoPtr_get_Options_Protected_get_ResumableUploadOptions_0;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeMethodInfoPtr_get_HttpClient_Internal_get_ConfigurableHttpClient_0;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeMethodInfoPtr_get_ContentStream_Public_get_Stream_0;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeMethodInfoPtr_get_StreamLength_Internal_get_Int64_0;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeMethodInfoPtr_set_StreamLength_Internal_set_Void_Int64_0;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeMethodInfoPtr_get_LastMediaRequest_Private_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeMethodInfoPtr_set_LastMediaRequest_Private_set_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeMethodInfoPtr_get_LastMediaLength_Private_get_Int32_0;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeMethodInfoPtr_set_LastMediaLength_Private_set_Void_Int32_0;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeMethodInfoPtr_get_UploadUri_Private_get_Uri_0;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeMethodInfoPtr_set_UploadUri_Private_set_Void_Uri_0;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeMethodInfoPtr_get_BytesServerReceived_Private_get_Int64_0;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeMethodInfoPtr_set_BytesServerReceived_Private_set_Void_Int64_0;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeMethodInfoPtr_get_BytesClientSent_Private_get_Int64_0;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeMethodInfoPtr_set_BytesClientSent_Private_set_Void_Int64_0;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeMethodInfoPtr_get_ChunkSize_Public_get_Int32_0;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeMethodInfoPtr_set_ChunkSize_Public_set_Void_Int32_0;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeMethodInfoPtr_add_ProgressChanged_Public_add_Void_Action_1_IUploadProgress_0;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeMethodInfoPtr_remove_ProgressChanged_Public_rem_Void_Action_1_IUploadProgress_0;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeMethodInfoPtr_get_UploadStreamInterceptor_Public_get_StreamInterceptor_0;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeMethodInfoPtr_set_UploadStreamInterceptor_Public_set_Void_StreamInterceptor_0;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeMethodInfoPtr_get_Progress_Private_get_ResumableUploadProgress_0;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeMethodInfoPtr_set_Progress_Private_set_Void_ResumableUploadProgress_0;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeMethodInfoPtr_UpdateProgress_Private_Void_ResumableUploadProgress_0;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeMethodInfoPtr_GetProgress_Public_IUploadProgress_0;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeMethodInfoPtr_add_UploadSessionData_Public_add_Void_Action_1_IUploadSessionData_0;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeMethodInfoPtr_remove_UploadSessionData_Public_rem_Void_Action_1_IUploadSessionData_0;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeMethodInfoPtr_SendUploadSessionData_Private_Void_ResumeableUploadSessionData_0;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeMethodInfoPtr_Upload_Public_IUploadProgress_0;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeMethodInfoPtr_UploadAsync_Public_Task_1_IUploadProgress_0;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeMethodInfoPtr_UploadAsync_Public_Task_1_IUploadProgress_CancellationToken_0;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Public_IUploadProgress_0;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Public_IUploadProgress_Uri_0;

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeMethodInfoPtr_ResumeAsync_Public_Task_1_IUploadProgress_0;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeMethodInfoPtr_ResumeAsync_Public_Task_1_IUploadProgress_CancellationToken_0;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeMethodInfoPtr_ResumeAsync_Public_Task_1_IUploadProgress_Uri_0;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeMethodInfoPtr_ResumeAsync_Public_Task_1_IUploadProgress_Uri_CancellationToken_0;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeMethodInfoPtr_UploadCoreAsync_Private_Task_1_IUploadProgress_CancellationToken_0;

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeMethodInfoPtr_InitiateSessionAsync_Public_Abstract_Virtual_New_Task_1_Uri_CancellationToken_0;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeMethodInfoPtr_ProcessResponse_Protected_Virtual_New_Void_HttpResponseMessage_0;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeMethodInfoPtr_SendNextChunkAsync_Protected_Task_1_Boolean_Stream_CancellationToken_0;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeMethodInfoPtr_HandleResponse_Private_Task_1_Boolean_HttpResponseMessage_0;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeMethodInfoPtr_ExceptionForResponseAsync_Protected_Task_1_GoogleApiException_HttpResponseMessage_0;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeMethodInfoPtr_MediaCompleted_Private_Void_HttpResponseMessage_0;

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeMethodInfoPtr_PrepareNextChunkUnknownSizeAsync_Private_Task_1_Tuple_2_Il2CppStructArray_1_Byte_Int32_Stream_CancellationToken_0;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeMethodInfoPtr_PrepareNextChunkKnownSizeAsync_Private_Task_1_Tuple_2_Il2CppStructArray_1_Byte_Int32_Stream_CancellationToken_0;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeMethodInfoPtr_GetNextByte_Private_Int64_String_0;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeMethodInfoPtr_GetContentRangeHeader_Private_String_Int64_Int64_0;

		// Token: 0x02000023 RID: 35
		public sealed class InitiatedResumableUpload : ResumableUpload
		{
			// Token: 0x060001CC RID: 460 RVA: 0x0000C194 File Offset: 0x0000A394
			// Note: this type is marked as 'beforefieldinit'.
			static InitiatedResumableUpload()
			{
				Il2CppClassPointerStore<ResumableUpload.InitiatedResumableUpload>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, "InitiatedResumableUpload");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResumableUpload.InitiatedResumableUpload>.NativeClassPtr);
				ResumableUpload.InitiatedResumableUpload.NativeFieldInfoPtr__initiatedUploadUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload.InitiatedResumableUpload>.NativeClassPtr, "_initiatedUploadUri");
				ResumableUpload.InitiatedResumableUpload.NativeMethodInfoPtr__ctor_Public_Void_Uri_Stream_ResumableUploadOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload.InitiatedResumableUpload>.NativeClassPtr, 100663368);
				ResumableUpload.InitiatedResumableUpload.NativeMethodInfoPtr_InitiateSessionAsync_Public_Virtual_Task_1_Uri_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload.InitiatedResumableUpload>.NativeClassPtr, 100663369);
			}

			// Token: 0x060001CD RID: 461 RVA: 0x0000C1FC File Offset: 0x0000A3FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1195507, XrefRangeEnd = 1195512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InitiatedResumableUpload(Uri uploadUri, Stream contentStream, ResumableUploadOptions options)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResumableUpload.InitiatedResumableUpload>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(uploadUri);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contentStream);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload.InitiatedResumableUpload.NativeMethodInfoPtr__ctor_Public_Void_Uri_Stream_ResumableUploadOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060001CE RID: 462 RVA: 0x0000C26C File Offset: 0x0000A46C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1195512, XrefRangeEnd = 1195518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Task<Uri> InitiateSessionAsync(CancellationToken cancellationToken = null)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload.InitiatedResumableUpload.NativeMethodInfoPtr_InitiateSessionAsync_Public_Virtual_Task_1_Uri_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Uri>>(intPtr3) : null;
				}
			}

			// Token: 0x060001CF RID: 463 RVA: 0x00002945 File Offset: 0x00000B45
			public InitiatedResumableUpload(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700009C RID: 156
			// (get) Token: 0x060001D0 RID: 464 RVA: 0x0000C2C4 File Offset: 0x0000A4C4
			// (set) Token: 0x060001D1 RID: 465 RVA: 0x0000294E File Offset: 0x00000B4E
			public unsafe Uri _initiatedUploadUri
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload.InitiatedResumableUpload.NativeFieldInfoPtr__initiatedUploadUri);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload.InitiatedResumableUpload.NativeFieldInfoPtr__initiatedUploadUri), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400015D RID: 349
			private static readonly IntPtr NativeFieldInfoPtr__initiatedUploadUri;

			// Token: 0x0400015E RID: 350
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Uri_Stream_ResumableUploadOptions_0;

			// Token: 0x0400015F RID: 351
			private static readonly IntPtr NativeMethodInfoPtr_InitiateSessionAsync_Public_Virtual_Task_1_Uri_CancellationToken_0;
		}

		// Token: 0x02000024 RID: 36
		public class ServerErrorCallback : Object
		{
			// Token: 0x060001D2 RID: 466 RVA: 0x0000C2F4 File Offset: 0x0000A4F4
			// Note: this type is marked as 'beforefieldinit'.
			static ServerErrorCallback()
			{
				Il2CppClassPointerStore<ResumableUpload.ServerErrorCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, "ServerErrorCallback");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResumableUpload.ServerErrorCallback>.NativeClassPtr);
				ResumableUpload.ServerErrorCallback.NativeFieldInfoPtr__Owner_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload.ServerErrorCallback>.NativeClassPtr, "<Owner>k__BackingField");
				ResumableUpload.ServerErrorCallback.NativeMethodInfoPtr_get_Owner_Private_get_ResumableUpload_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload.ServerErrorCallback>.NativeClassPtr, 100663370);
				ResumableUpload.ServerErrorCallback.NativeMethodInfoPtr_set_Owner_Private_set_Void_ResumableUpload_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload.ServerErrorCallback>.NativeClassPtr, 100663371);
				ResumableUpload.ServerErrorCallback.NativeMethodInfoPtr__ctor_Public_Void_ResumableUpload_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload.ServerErrorCallback>.NativeClassPtr, 100663372);
				ResumableUpload.ServerErrorCallback.NativeMethodInfoPtr_AddToRequest_Public_Void_HttpRequestMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload.ServerErrorCallback>.NativeClassPtr, 100663373);
				ResumableUpload.ServerErrorCallback.NativeMethodInfoPtr_HandleResponseAsync_Public_Virtual_Final_New_Task_1_Boolean_HandleUnsuccessfulResponseArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload.ServerErrorCallback>.NativeClassPtr, 100663374);
				ResumableUpload.ServerErrorCallback.NativeMethodInfoPtr_HandleExceptionAsync_Public_Virtual_Final_New_Task_1_Boolean_HandleExceptionArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload.ServerErrorCallback>.NativeClassPtr, 100663375);
				ResumableUpload.ServerErrorCallback.NativeMethodInfoPtr_OnServerError_Private_Boolean_HttpRequestMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload.ServerErrorCallback>.NativeClassPtr, 100663376);
			}

			// Token: 0x1700009E RID: 158
			// (get) Token: 0x060001D3 RID: 467 RVA: 0x0000C3C0 File Offset: 0x0000A5C0
			// (set) Token: 0x060001D4 RID: 468 RVA: 0x0000C400 File Offset: 0x0000A600
			public unsafe ResumableUpload Owner
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload.ServerErrorCallback.NativeMethodInfoPtr_get_Owner_Private_get_ResumableUpload_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResumableUpload>(intPtr3) : null;
				}
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload.ServerErrorCallback.NativeMethodInfoPtr_set_Owner_Private_set_Void_ResumableUpload_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x060001D5 RID: 469 RVA: 0x0000C444 File Offset: 0x0000A644
			[CallerCount(148)]
			[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ServerErrorCallback(ResumableUpload resumable)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResumableUpload.ServerErrorCallback>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(resumable);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload.ServerErrorCallback.NativeMethodInfoPtr__ctor_Public_Void_ResumableUpload_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060001D6 RID: 470 RVA: 0x0000C490 File Offset: 0x0000A690
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1195551, RefRangeEnd = 1195553, XrefRangeStart = 1195518, XrefRangeEnd = 1195551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void AddToRequest(HttpRequestMessage request)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload.ServerErrorCallback.NativeMethodInfoPtr_AddToRequest_Public_Void_HttpRequestMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060001D7 RID: 471 RVA: 0x0000C4D4 File Offset: 0x0000A6D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1195553, XrefRangeEnd = 1195565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual Task<bool> HandleResponseAsync(HandleUnsuccessfulResponseArgs args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload.ServerErrorCallback.NativeMethodInfoPtr_HandleResponseAsync_Public_Virtual_Final_New_Task_1_Boolean_HandleUnsuccessfulResponseArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr3) : null;
				}
			}

			// Token: 0x060001D8 RID: 472 RVA: 0x0000C524 File Offset: 0x0000A724
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1195565, XrefRangeEnd = 1195582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual Task<bool> HandleExceptionAsync(HandleExceptionArgs args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload.ServerErrorCallback.NativeMethodInfoPtr_HandleExceptionAsync_Public_Virtual_Final_New_Task_1_Boolean_HandleExceptionArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr3) : null;
				}
			}

			// Token: 0x060001D9 RID: 473 RVA: 0x0000C574 File Offset: 0x0000A774
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1195604, RefRangeEnd = 1195606, XrefRangeStart = 1195582, XrefRangeEnd = 1195604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool OnServerError(HttpRequestMessage request)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload.ServerErrorCallback.NativeMethodInfoPtr_OnServerError_Private_Boolean_HttpRequestMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060001DA RID: 474 RVA: 0x0000296D File Offset: 0x00000B6D
			public ServerErrorCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700009D RID: 157
			// (get) Token: 0x060001DB RID: 475 RVA: 0x0000C5C4 File Offset: 0x0000A7C4
			// (set) Token: 0x060001DC RID: 476 RVA: 0x00002976 File Offset: 0x00000B76
			public unsafe ResumableUpload _Owner_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload.ServerErrorCallback.NativeFieldInfoPtr__Owner_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResumableUpload>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload.ServerErrorCallback.NativeFieldInfoPtr__Owner_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000160 RID: 352
			private static readonly IntPtr NativeFieldInfoPtr__Owner_k__BackingField;

			// Token: 0x04000161 RID: 353
			private static readonly IntPtr NativeMethodInfoPtr_get_Owner_Private_get_ResumableUpload_0;

			// Token: 0x04000162 RID: 354
			private static readonly IntPtr NativeMethodInfoPtr_set_Owner_Private_set_Void_ResumableUpload_0;

			// Token: 0x04000163 RID: 355
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ResumableUpload_0;

			// Token: 0x04000164 RID: 356
			private static readonly IntPtr NativeMethodInfoPtr_AddToRequest_Public_Void_HttpRequestMessage_0;

			// Token: 0x04000165 RID: 357
			private static readonly IntPtr NativeMethodInfoPtr_HandleResponseAsync_Public_Virtual_Final_New_Task_1_Boolean_HandleUnsuccessfulResponseArgs_0;

			// Token: 0x04000166 RID: 358
			private static readonly IntPtr NativeMethodInfoPtr_HandleExceptionAsync_Public_Virtual_Final_New_Task_1_Boolean_HandleExceptionArgs_0;

			// Token: 0x04000167 RID: 359
			private static readonly IntPtr NativeMethodInfoPtr_OnServerError_Private_Boolean_HttpRequestMessage_0;
		}

		// Token: 0x02000025 RID: 37
		public class ResumableUploadProgress : Object
		{
			// Token: 0x060001DD RID: 477 RVA: 0x0000C5F4 File Offset: 0x0000A7F4
			// Note: this type is marked as 'beforefieldinit'.
			static ResumableUploadProgress()
			{
				Il2CppClassPointerStore<ResumableUpload.ResumableUploadProgress>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, "ResumableUploadProgress");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResumableUpload.ResumableUploadProgress>.NativeClassPtr);
				ResumableUpload.ResumableUploadProgress.NativeFieldInfoPtr__Status_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload.ResumableUploadProgress>.NativeClassPtr, "<Status>k__BackingField");
				ResumableUpload.ResumableUploadProgress.NativeFieldInfoPtr__BytesSent_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload.ResumableUploadProgress>.NativeClassPtr, "<BytesSent>k__BackingField");
				ResumableUpload.ResumableUploadProgress.NativeFieldInfoPtr__Exception_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload.ResumableUploadProgress>.NativeClassPtr, "<Exception>k__BackingField");
				ResumableUpload.ResumableUploadProgress.NativeMethodInfoPtr__ctor_Public_Void_UploadStatus_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload.ResumableUploadProgress>.NativeClassPtr, 100663377);
				ResumableUpload.ResumableUploadProgress.NativeMethodInfoPtr__ctor_Public_Void_Exception_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload.ResumableUploadProgress>.NativeClassPtr, 100663378);
				ResumableUpload.ResumableUploadProgress.NativeMethodInfoPtr_get_Status_Public_Virtual_Final_New_get_UploadStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload.ResumableUploadProgress>.NativeClassPtr, 100663379);
				ResumableUpload.ResumableUploadProgress.NativeMethodInfoPtr_set_Status_Private_set_Void_UploadStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload.ResumableUploadProgress>.NativeClassPtr, 100663380);
				ResumableUpload.ResumableUploadProgress.NativeMethodInfoPtr_get_BytesSent_Public_Virtual_Final_New_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload.ResumableUploadProgress>.NativeClassPtr, 100663381);
				ResumableUpload.ResumableUploadProgress.NativeMethodInfoPtr_set_BytesSent_Private_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload.ResumableUploadProgress>.NativeClassPtr, 100663382);
				ResumableUpload.ResumableUploadProgress.NativeMethodInfoPtr_get_Exception_Public_Virtual_Final_New_get_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload.ResumableUploadProgress>.NativeClassPtr, 100663383);
				ResumableUpload.ResumableUploadProgress.NativeMethodInfoPtr_set_Exception_Private_set_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload.ResumableUploadProgress>.NativeClassPtr, 100663384);
			}

			// Token: 0x060001DE RID: 478 RVA: 0x0000C6FC File Offset: 0x0000A8FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1195606, XrefRangeEnd = 1195607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ResumableUploadProgress(UploadStatus status, long bytesSent)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResumableUpload.ResumableUploadProgress>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref status;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bytesSent;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload.ResumableUploadProgress.NativeMethodInfoPtr__ctor_Public_Void_UploadStatus_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060001DF RID: 479 RVA: 0x0000C754 File Offset: 0x0000A954
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1195609, RefRangeEnd = 1195612, XrefRangeStart = 1195607, XrefRangeEnd = 1195609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ResumableUploadProgress(Exception exception, long bytesSent)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResumableUpload.ResumableUploadProgress>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bytesSent;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload.ResumableUploadProgress.NativeMethodInfoPtr__ctor_Public_Void_Exception_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170000A2 RID: 162
			// (get) Token: 0x060001E0 RID: 480 RVA: 0x0000C7B0 File Offset: 0x0000A9B0
			// (set) Token: 0x060001E1 RID: 481 RVA: 0x0000C7EC File Offset: 0x0000A9EC
			public unsafe virtual UploadStatus Status
			{
				[CallerCount(5)]
				[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload.ResumableUploadProgress.NativeMethodInfoPtr_get_Status_Public_Virtual_Final_New_get_UploadStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(5)]
				[CachedScanResults(RefRangeStart = 307807, RefRangeEnd = 307812, XrefRangeStart = 307807, XrefRangeEnd = 307812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload.ResumableUploadProgress.NativeMethodInfoPtr_set_Status_Private_set_Void_UploadStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170000A3 RID: 163
			// (get) Token: 0x060001E2 RID: 482 RVA: 0x0000C82C File Offset: 0x0000AA2C
			// (set) Token: 0x060001E3 RID: 483 RVA: 0x0000C868 File Offset: 0x0000AA68
			public unsafe virtual long BytesSent
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload.ResumableUploadProgress.NativeMethodInfoPtr_get_BytesSent_Public_Virtual_Final_New_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload.ResumableUploadProgress.NativeMethodInfoPtr_set_BytesSent_Private_set_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170000A4 RID: 164
			// (get) Token: 0x060001E4 RID: 484 RVA: 0x0000C8A8 File Offset: 0x0000AAA8
			// (set) Token: 0x060001E5 RID: 485 RVA: 0x0000C8E8 File Offset: 0x0000AAE8
			public unsafe virtual Exception Exception
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload.ResumableUploadProgress.NativeMethodInfoPtr_get_Exception_Public_Virtual_Final_New_get_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload.ResumableUploadProgress.NativeMethodInfoPtr_set_Exception_Private_set_Void_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x060001E6 RID: 486 RVA: 0x00002995 File Offset: 0x00000B95
			public ResumableUploadProgress(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700009F RID: 159
			// (get) Token: 0x060001E7 RID: 487 RVA: 0x0000C92C File Offset: 0x0000AB2C
			// (set) Token: 0x060001E8 RID: 488 RVA: 0x0000299E File Offset: 0x00000B9E
			public unsafe UploadStatus _Status_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload.ResumableUploadProgress.NativeFieldInfoPtr__Status_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload.ResumableUploadProgress.NativeFieldInfoPtr__Status_k__BackingField)) = value;
				}
			}

			// Token: 0x170000A0 RID: 160
			// (get) Token: 0x060001E9 RID: 489 RVA: 0x0000C954 File Offset: 0x0000AB54
			// (set) Token: 0x060001EA RID: 490 RVA: 0x000029B9 File Offset: 0x00000BB9
			public unsafe long _BytesSent_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload.ResumableUploadProgress.NativeFieldInfoPtr__BytesSent_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload.ResumableUploadProgress.NativeFieldInfoPtr__BytesSent_k__BackingField)) = value;
				}
			}

			// Token: 0x170000A1 RID: 161
			// (get) Token: 0x060001EB RID: 491 RVA: 0x0000C97C File Offset: 0x0000AB7C
			// (set) Token: 0x060001EC RID: 492 RVA: 0x000029D4 File Offset: 0x00000BD4
			public unsafe Exception _Exception_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload.ResumableUploadProgress.NativeFieldInfoPtr__Exception_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload.ResumableUploadProgress.NativeFieldInfoPtr__Exception_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000168 RID: 360
			private static readonly IntPtr NativeFieldInfoPtr__Status_k__BackingField;

			// Token: 0x04000169 RID: 361
			private static readonly IntPtr NativeFieldInfoPtr__BytesSent_k__BackingField;

			// Token: 0x0400016A RID: 362
			private static readonly IntPtr NativeFieldInfoPtr__Exception_k__BackingField;

			// Token: 0x0400016B RID: 363
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UploadStatus_Int64_0;

			// Token: 0x0400016C RID: 364
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Exception_Int64_0;

			// Token: 0x0400016D RID: 365
			private static readonly IntPtr NativeMethodInfoPtr_get_Status_Public_Virtual_Final_New_get_UploadStatus_0;

			// Token: 0x0400016E RID: 366
			private static readonly IntPtr NativeMethodInfoPtr_set_Status_Private_set_Void_UploadStatus_0;

			// Token: 0x0400016F RID: 367
			private static readonly IntPtr NativeMethodInfoPtr_get_BytesSent_Public_Virtual_Final_New_get_Int64_0;

			// Token: 0x04000170 RID: 368
			private static readonly IntPtr NativeMethodInfoPtr_set_BytesSent_Private_set_Void_Int64_0;

			// Token: 0x04000171 RID: 369
			private static readonly IntPtr NativeMethodInfoPtr_get_Exception_Public_Virtual_Final_New_get_Exception_0;

			// Token: 0x04000172 RID: 370
			private static readonly IntPtr NativeMethodInfoPtr_set_Exception_Private_set_Void_Exception_0;
		}

		// Token: 0x02000026 RID: 38
		public class ResumeableUploadSessionData : Object
		{
			// Token: 0x060001ED RID: 493 RVA: 0x0000C9AC File Offset: 0x0000ABAC
			// Note: this type is marked as 'beforefieldinit'.
			static ResumeableUploadSessionData()
			{
				Il2CppClassPointerStore<ResumableUpload.ResumeableUploadSessionData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, "ResumeableUploadSessionData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResumableUpload.ResumeableUploadSessionData>.NativeClassPtr);
				ResumableUpload.ResumeableUploadSessionData.NativeFieldInfoPtr__UploadUri_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload.ResumeableUploadSessionData>.NativeClassPtr, "<UploadUri>k__BackingField");
				ResumableUpload.ResumeableUploadSessionData.NativeMethodInfoPtr__ctor_Public_Void_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload.ResumeableUploadSessionData>.NativeClassPtr, 100663385);
				ResumableUpload.ResumeableUploadSessionData.NativeMethodInfoPtr_get_UploadUri_Public_Virtual_Final_New_get_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload.ResumeableUploadSessionData>.NativeClassPtr, 100663386);
				ResumableUpload.ResumeableUploadSessionData.NativeMethodInfoPtr_set_UploadUri_Private_set_Void_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload.ResumeableUploadSessionData>.NativeClassPtr, 100663387);
			}

			// Token: 0x060001EE RID: 494 RVA: 0x0000CA28 File Offset: 0x0000AC28
			[CallerCount(148)]
			[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ResumeableUploadSessionData(Uri uploadUri)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResumableUpload.ResumeableUploadSessionData>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(uploadUri);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload.ResumeableUploadSessionData.NativeMethodInfoPtr__ctor_Public_Void_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x170000A6 RID: 166
			// (get) Token: 0x060001EF RID: 495 RVA: 0x0000CA74 File Offset: 0x0000AC74
			// (set) Token: 0x060001F0 RID: 496 RVA: 0x0000CAB4 File Offset: 0x0000ACB4
			public unsafe virtual Uri UploadUri
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload.ResumeableUploadSessionData.NativeMethodInfoPtr_get_UploadUri_Public_Virtual_Final_New_get_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
				}
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload.ResumeableUploadSessionData.NativeMethodInfoPtr_set_UploadUri_Private_set_Void_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x060001F1 RID: 497 RVA: 0x000029F3 File Offset: 0x00000BF3
			public ResumeableUploadSessionData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000A5 RID: 165
			// (get) Token: 0x060001F2 RID: 498 RVA: 0x0000CAF8 File Offset: 0x0000ACF8
			// (set) Token: 0x060001F3 RID: 499 RVA: 0x000029FC File Offset: 0x00000BFC
			public unsafe Uri _UploadUri_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload.ResumeableUploadSessionData.NativeFieldInfoPtr__UploadUri_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload.ResumeableUploadSessionData.NativeFieldInfoPtr__UploadUri_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000173 RID: 371
			private static readonly IntPtr NativeFieldInfoPtr__UploadUri_k__BackingField;

			// Token: 0x04000174 RID: 372
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Uri_0;

			// Token: 0x04000175 RID: 373
			private static readonly IntPtr NativeMethodInfoPtr_get_UploadUri_Public_Virtual_Final_New_get_Uri_0;

			// Token: 0x04000176 RID: 374
			private static readonly IntPtr NativeMethodInfoPtr_set_UploadUri_Private_set_Void_Uri_0;
		}

		// Token: 0x02000027 RID: 39
		[ObfuscatedName("Google.Apis.Upload.ResumableUpload+<UploadAsync>d__71")]
		public sealed class _UploadAsync_d__71 : ValueType
		{
			// Token: 0x060001F4 RID: 500 RVA: 0x0000CB28 File Offset: 0x0000AD28
			// Note: this type is marked as 'beforefieldinit'.
			static _UploadAsync_d__71()
			{
				Il2CppClassPointerStore<ResumableUpload._UploadAsync_d__71>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, "<UploadAsync>d__71");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResumableUpload._UploadAsync_d__71>.NativeClassPtr);
				ResumableUpload._UploadAsync_d__71.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload._UploadAsync_d__71>.NativeClassPtr, "<>1__state");
				ResumableUpload._UploadAsync_d__71.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload._UploadAsync_d__71>.NativeClassPtr, "<>t__builder");
				ResumableUpload._UploadAsync_d__71.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload._UploadAsync_d__71>.NativeClassPtr, "<>4__this");
				ResumableUpload._UploadAsync_d__71.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload._UploadAsync_d__71>.NativeClassPtr, "cancellationToken");
				ResumableUpload._UploadAsync_d__71.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload._UploadAsync_d__71>.NativeClassPtr, "<>u__1");
				ResumableUpload._UploadAsync_d__71.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload._UploadAsync_d__71>.NativeClassPtr, "<>u__2");
				ResumableUpload._UploadAsync_d__71.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload._UploadAsync_d__71>.NativeClassPtr, 100663388);
				ResumableUpload._UploadAsync_d__71.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload._UploadAsync_d__71>.NativeClassPtr, 100663389);
			}

			// Token: 0x060001F5 RID: 501 RVA: 0x0000CBF4 File Offset: 0x0000ADF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1195612, XrefRangeEnd = 1195693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload._UploadAsync_d__71.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060001F6 RID: 502 RVA: 0x0000CC2C File Offset: 0x0000AE2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1195693, XrefRangeEnd = 1195699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload._UploadAsync_d__71.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060001F7 RID: 503 RVA: 0x00002A1B File Offset: 0x00000C1B
			public _UploadAsync_d__71(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060001F8 RID: 504 RVA: 0x00002A24 File Offset: 0x00000C24
			public _UploadAsync_d__71()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResumableUpload._UploadAsync_d__71>.NativeClassPtr))
			{
			}

			// Token: 0x170000A7 RID: 167
			// (get) Token: 0x060001F9 RID: 505 RVA: 0x0000CC74 File Offset: 0x0000AE74
			// (set) Token: 0x060001FA RID: 506 RVA: 0x00002A36 File Offset: 0x00000C36
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._UploadAsync_d__71.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._UploadAsync_d__71.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170000A8 RID: 168
			// (get) Token: 0x060001FB RID: 507 RVA: 0x0000CC9C File Offset: 0x0000AE9C
			// (set) Token: 0x060001FC RID: 508 RVA: 0x00002A51 File Offset: 0x00000C51
			public AsyncTaskMethodBuilder<IUploadProgress> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._UploadAsync_d__71.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<IUploadProgress>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<IUploadProgress>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._UploadAsync_d__71.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<IUploadProgress>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170000A9 RID: 169
			// (get) Token: 0x060001FD RID: 509 RVA: 0x0000CCCC File Offset: 0x0000AECC
			// (set) Token: 0x060001FE RID: 510 RVA: 0x00002A7F File Offset: 0x00000C7F
			public unsafe ResumableUpload __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._UploadAsync_d__71.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResumableUpload>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._UploadAsync_d__71.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000AA RID: 170
			// (get) Token: 0x060001FF RID: 511 RVA: 0x0000CCFC File Offset: 0x0000AEFC
			// (set) Token: 0x06000200 RID: 512 RVA: 0x00002A9E File Offset: 0x00000C9E
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._UploadAsync_d__71.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._UploadAsync_d__71.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170000AB RID: 171
			// (get) Token: 0x06000201 RID: 513 RVA: 0x0000CD2C File Offset: 0x0000AF2C
			// (set) Token: 0x06000202 RID: 514 RVA: 0x00002ACC File Offset: 0x00000CCC
			public ConfiguredTaskAwaitable<Uri>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._UploadAsync_d__71.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<Uri>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Uri>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._UploadAsync_d__71.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Uri>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170000AC RID: 172
			// (get) Token: 0x06000203 RID: 515 RVA: 0x0000CD5C File Offset: 0x0000AF5C
			// (set) Token: 0x06000204 RID: 516 RVA: 0x00002AFA File Offset: 0x00000CFA
			public ConfiguredTaskAwaitable<IUploadProgress>.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._UploadAsync_d__71.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable<IUploadProgress>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<IUploadProgress>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._UploadAsync_d__71.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<IUploadProgress>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04000177 RID: 375
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000178 RID: 376
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04000179 RID: 377
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400017A RID: 378
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x0400017B RID: 379
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400017C RID: 380
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x0400017D RID: 381
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400017E RID: 382
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000028 RID: 40
		[ObfuscatedName("Google.Apis.Upload.ResumableUpload+<ResumeAsync>d__77")]
		public sealed class _ResumeAsync_d__77 : ValueType
		{
			// Token: 0x06000205 RID: 517 RVA: 0x0000CD8C File Offset: 0x0000AF8C
			// Note: this type is marked as 'beforefieldinit'.
			static _ResumeAsync_d__77()
			{
				Il2CppClassPointerStore<ResumableUpload._ResumeAsync_d__77>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, "<ResumeAsync>d__77");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResumableUpload._ResumeAsync_d__77>.NativeClassPtr);
				ResumableUpload._ResumeAsync_d__77.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload._ResumeAsync_d__77>.NativeClassPtr, "<>1__state");
				ResumableUpload._ResumeAsync_d__77.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload._ResumeAsync_d__77>.NativeClassPtr, "<>t__builder");
				ResumableUpload._ResumeAsync_d__77.NativeFieldInfoPtr_uploadUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload._ResumeAsync_d__77>.NativeClassPtr, "uploadUri");
				ResumableUpload._ResumeAsync_d__77.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload._ResumeAsync_d__77>.NativeClassPtr, "<>4__this");
				ResumableUpload._ResumeAsync_d__77.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload._ResumeAsync_d__77>.NativeClassPtr, "cancellationToken");
				ResumableUpload._ResumeAsync_d__77.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload._ResumeAsync_d__77>.NativeClassPtr, "<>u__1");
				ResumableUpload._ResumeAsync_d__77.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload._ResumeAsync_d__77>.NativeClassPtr, "<>u__2");
				ResumableUpload._ResumeAsync_d__77.NativeFieldInfoPtr___u__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload._ResumeAsync_d__77>.NativeClassPtr, "<>u__3");
				ResumableUpload._ResumeAsync_d__77.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload._ResumeAsync_d__77>.NativeClassPtr, 100663390);
				ResumableUpload._ResumeAsync_d__77.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload._ResumeAsync_d__77>.NativeClassPtr, 100663391);
			}

			// Token: 0x06000206 RID: 518 RVA: 0x0000CE80 File Offset: 0x0000B080
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1195699, XrefRangeEnd = 1195855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload._ResumeAsync_d__77.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000207 RID: 519 RVA: 0x0000CEB8 File Offset: 0x0000B0B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1195855, XrefRangeEnd = 1195861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload._ResumeAsync_d__77.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000208 RID: 520 RVA: 0x00002B28 File Offset: 0x00000D28
			public _ResumeAsync_d__77(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000209 RID: 521 RVA: 0x00002B31 File Offset: 0x00000D31
			public _ResumeAsync_d__77()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResumableUpload._ResumeAsync_d__77>.NativeClassPtr))
			{
			}

			// Token: 0x170000AD RID: 173
			// (get) Token: 0x0600020A RID: 522 RVA: 0x0000CF00 File Offset: 0x0000B100
			// (set) Token: 0x0600020B RID: 523 RVA: 0x00002B43 File Offset: 0x00000D43
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._ResumeAsync_d__77.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._ResumeAsync_d__77.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170000AE RID: 174
			// (get) Token: 0x0600020C RID: 524 RVA: 0x0000CF28 File Offset: 0x0000B128
			// (set) Token: 0x0600020D RID: 525 RVA: 0x00002B5E File Offset: 0x00000D5E
			public AsyncTaskMethodBuilder<IUploadProgress> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._ResumeAsync_d__77.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<IUploadProgress>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<IUploadProgress>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._ResumeAsync_d__77.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<IUploadProgress>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170000AF RID: 175
			// (get) Token: 0x0600020E RID: 526 RVA: 0x0000CF58 File Offset: 0x0000B158
			// (set) Token: 0x0600020F RID: 527 RVA: 0x00002B8C File Offset: 0x00000D8C
			public unsafe Uri uploadUri
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._ResumeAsync_d__77.NativeFieldInfoPtr_uploadUri);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._ResumeAsync_d__77.NativeFieldInfoPtr_uploadUri), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000B0 RID: 176
			// (get) Token: 0x06000210 RID: 528 RVA: 0x0000CF88 File Offset: 0x0000B188
			// (set) Token: 0x06000211 RID: 529 RVA: 0x00002BAB File Offset: 0x00000DAB
			public unsafe ResumableUpload __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._ResumeAsync_d__77.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResumableUpload>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._ResumeAsync_d__77.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000B1 RID: 177
			// (get) Token: 0x06000212 RID: 530 RVA: 0x0000CFB8 File Offset: 0x0000B1B8
			// (set) Token: 0x06000213 RID: 531 RVA: 0x00002BCA File Offset: 0x00000DCA
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._ResumeAsync_d__77.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._ResumeAsync_d__77.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170000B2 RID: 178
			// (get) Token: 0x06000214 RID: 532 RVA: 0x0000CFE8 File Offset: 0x0000B1E8
			// (set) Token: 0x06000215 RID: 533 RVA: 0x00002BF8 File Offset: 0x00000DF8
			public ConfiguredTaskAwaitable<IUploadProgress>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._ResumeAsync_d__77.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<IUploadProgress>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<IUploadProgress>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._ResumeAsync_d__77.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<IUploadProgress>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170000B3 RID: 179
			// (get) Token: 0x06000216 RID: 534 RVA: 0x0000D018 File Offset: 0x0000B218
			// (set) Token: 0x06000217 RID: 535 RVA: 0x00002C26 File Offset: 0x00000E26
			public ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._ResumeAsync_d__77.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._ResumeAsync_d__77.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170000B4 RID: 180
			// (get) Token: 0x06000218 RID: 536 RVA: 0x0000D048 File Offset: 0x0000B248
			// (set) Token: 0x06000219 RID: 537 RVA: 0x00002C54 File Offset: 0x00000E54
			public ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter __u__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._ResumeAsync_d__77.NativeFieldInfoPtr___u__3);
					return new ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._ResumeAsync_d__77.NativeFieldInfoPtr___u__3), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400017F RID: 383
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000180 RID: 384
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04000181 RID: 385
			private static readonly IntPtr NativeFieldInfoPtr_uploadUri;

			// Token: 0x04000182 RID: 386
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000183 RID: 387
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04000184 RID: 388
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04000185 RID: 389
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x04000186 RID: 390
			private static readonly IntPtr NativeFieldInfoPtr___u__3;

			// Token: 0x04000187 RID: 391
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000188 RID: 392
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000029 RID: 41
		[ObfuscatedName("Google.Apis.Upload.ResumableUpload+<UploadCoreAsync>d__78")]
		public sealed class _UploadCoreAsync_d__78 : ValueType
		{
			// Token: 0x0600021A RID: 538 RVA: 0x0000D078 File Offset: 0x0000B278
			// Note: this type is marked as 'beforefieldinit'.
			static _UploadCoreAsync_d__78()
			{
				Il2CppClassPointerStore<ResumableUpload._UploadCoreAsync_d__78>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, "<UploadCoreAsync>d__78");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResumableUpload._UploadCoreAsync_d__78>.NativeClassPtr);
				ResumableUpload._UploadCoreAsync_d__78.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload._UploadCoreAsync_d__78>.NativeClassPtr, "<>1__state");
				ResumableUpload._UploadCoreAsync_d__78.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload._UploadCoreAsync_d__78>.NativeClassPtr, "<>t__builder");
				ResumableUpload._UploadCoreAsync_d__78.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload._UploadCoreAsync_d__78>.NativeClassPtr, "<>4__this");
				ResumableUpload._UploadCoreAsync_d__78.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload._UploadCoreAsync_d__78>.NativeClassPtr, "cancellationToken");
				ResumableUpload._UploadCoreAsync_d__78.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload._UploadCoreAsync_d__78>.NativeClassPtr, "<>u__1");
				ResumableUpload._UploadCoreAsync_d__78.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload._UploadCoreAsync_d__78>.NativeClassPtr, 100663392);
				ResumableUpload._UploadCoreAsync_d__78.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload._UploadCoreAsync_d__78>.NativeClassPtr, 100663393);
			}

			// Token: 0x0600021B RID: 539 RVA: 0x0000D130 File Offset: 0x0000B330
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1195861, XrefRangeEnd = 1195926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload._UploadCoreAsync_d__78.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600021C RID: 540 RVA: 0x0000D168 File Offset: 0x0000B368
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1195926, XrefRangeEnd = 1195932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload._UploadCoreAsync_d__78.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600021D RID: 541 RVA: 0x00002C82 File Offset: 0x00000E82
			public _UploadCoreAsync_d__78(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600021E RID: 542 RVA: 0x00002C8B File Offset: 0x00000E8B
			public _UploadCoreAsync_d__78()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResumableUpload._UploadCoreAsync_d__78>.NativeClassPtr))
			{
			}

			// Token: 0x170000B5 RID: 181
			// (get) Token: 0x0600021F RID: 543 RVA: 0x0000D1B0 File Offset: 0x0000B3B0
			// (set) Token: 0x06000220 RID: 544 RVA: 0x00002C9D File Offset: 0x00000E9D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._UploadCoreAsync_d__78.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._UploadCoreAsync_d__78.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170000B6 RID: 182
			// (get) Token: 0x06000221 RID: 545 RVA: 0x0000D1D8 File Offset: 0x0000B3D8
			// (set) Token: 0x06000222 RID: 546 RVA: 0x00002CB8 File Offset: 0x00000EB8
			public AsyncTaskMethodBuilder<IUploadProgress> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._UploadCoreAsync_d__78.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<IUploadProgress>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<IUploadProgress>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._UploadCoreAsync_d__78.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<IUploadProgress>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170000B7 RID: 183
			// (get) Token: 0x06000223 RID: 547 RVA: 0x0000D208 File Offset: 0x0000B408
			// (set) Token: 0x06000224 RID: 548 RVA: 0x00002CE6 File Offset: 0x00000EE6
			public unsafe ResumableUpload __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._UploadCoreAsync_d__78.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResumableUpload>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._UploadCoreAsync_d__78.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000B8 RID: 184
			// (get) Token: 0x06000225 RID: 549 RVA: 0x0000D238 File Offset: 0x0000B438
			// (set) Token: 0x06000226 RID: 550 RVA: 0x00002D05 File Offset: 0x00000F05
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._UploadCoreAsync_d__78.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._UploadCoreAsync_d__78.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170000B9 RID: 185
			// (get) Token: 0x06000227 RID: 551 RVA: 0x0000D268 File Offset: 0x0000B468
			// (set) Token: 0x06000228 RID: 552 RVA: 0x00002D33 File Offset: 0x00000F33
			public ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._UploadCoreAsync_d__78.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._UploadCoreAsync_d__78.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04000189 RID: 393
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400018A RID: 394
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400018B RID: 395
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400018C RID: 396
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x0400018D RID: 397
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400018E RID: 398
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400018F RID: 399
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200002A RID: 42
		[ObfuscatedName("Google.Apis.Upload.ResumableUpload+<SendNextChunkAsync>d__81")]
		public sealed class _SendNextChunkAsync_d__81 : ValueType
		{
			// Token: 0x06000229 RID: 553 RVA: 0x0000D298 File Offset: 0x0000B498
			// Note: this type is marked as 'beforefieldinit'.
			static _SendNextChunkAsync_d__81()
			{
				Il2CppClassPointerStore<ResumableUpload._SendNextChunkAsync_d__81>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, "<SendNextChunkAsync>d__81");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResumableUpload._SendNextChunkAsync_d__81>.NativeClassPtr);
				ResumableUpload._SendNextChunkAsync_d__81.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload._SendNextChunkAsync_d__81>.NativeClassPtr, "<>1__state");
				ResumableUpload._SendNextChunkAsync_d__81.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload._SendNextChunkAsync_d__81>.NativeClassPtr, "<>t__builder");
				ResumableUpload._SendNextChunkAsync_d__81.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload._SendNextChunkAsync_d__81>.NativeClassPtr, "cancellationToken");
				ResumableUpload._SendNextChunkAsync_d__81.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload._SendNextChunkAsync_d__81>.NativeClassPtr, "<>4__this");
				ResumableUpload._SendNextChunkAsync_d__81.NativeFieldInfoPtr_stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload._SendNextChunkAsync_d__81>.NativeClassPtr, "stream");
				ResumableUpload._SendNextChunkAsync_d__81.NativeFieldInfoPtr__request_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload._SendNextChunkAsync_d__81>.NativeClassPtr, "<request>5__2");
				ResumableUpload._SendNextChunkAsync_d__81.NativeFieldInfoPtr__chunk_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload._SendNextChunkAsync_d__81>.NativeClassPtr, "<chunk>5__3");
				ResumableUpload._SendNextChunkAsync_d__81.NativeFieldInfoPtr__bytesServerReceivedBefore_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload._SendNextChunkAsync_d__81>.NativeClassPtr, "<bytesServerReceivedBefore>5__4");
				ResumableUpload._SendNextChunkAsync_d__81.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload._SendNextChunkAsync_d__81>.NativeClassPtr, "<>u__1");
				ResumableUpload._SendNextChunkAsync_d__81.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload._SendNextChunkAsync_d__81>.NativeClassPtr, "<>u__2");
				ResumableUpload._SendNextChunkAsync_d__81.NativeFieldInfoPtr___u__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload._SendNextChunkAsync_d__81>.NativeClassPtr, "<>u__3");
				ResumableUpload._SendNextChunkAsync_d__81.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload._SendNextChunkAsync_d__81>.NativeClassPtr, 100663394);
				ResumableUpload._SendNextChunkAsync_d__81.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload._SendNextChunkAsync_d__81>.NativeClassPtr, 100663395);
			}

			// Token: 0x0600022A RID: 554 RVA: 0x0000D3C8 File Offset: 0x0000B5C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1195932, XrefRangeEnd = 1196095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload._SendNextChunkAsync_d__81.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600022B RID: 555 RVA: 0x0000D400 File Offset: 0x0000B600
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1196095, XrefRangeEnd = 1196101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload._SendNextChunkAsync_d__81.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600022C RID: 556 RVA: 0x00002D61 File Offset: 0x00000F61
			public _SendNextChunkAsync_d__81(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600022D RID: 557 RVA: 0x00002D6A File Offset: 0x00000F6A
			public _SendNextChunkAsync_d__81()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResumableUpload._SendNextChunkAsync_d__81>.NativeClassPtr))
			{
			}

			// Token: 0x170000BA RID: 186
			// (get) Token: 0x0600022E RID: 558 RVA: 0x0000D448 File Offset: 0x0000B648
			// (set) Token: 0x0600022F RID: 559 RVA: 0x00002D7C File Offset: 0x00000F7C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._SendNextChunkAsync_d__81.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._SendNextChunkAsync_d__81.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170000BB RID: 187
			// (get) Token: 0x06000230 RID: 560 RVA: 0x0000D470 File Offset: 0x0000B670
			// (set) Token: 0x06000231 RID: 561 RVA: 0x00002D97 File Offset: 0x00000F97
			public AsyncTaskMethodBuilder<bool> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._SendNextChunkAsync_d__81.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._SendNextChunkAsync_d__81.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170000BC RID: 188
			// (get) Token: 0x06000232 RID: 562 RVA: 0x0000D4A0 File Offset: 0x0000B6A0
			// (set) Token: 0x06000233 RID: 563 RVA: 0x00002DC5 File Offset: 0x00000FC5
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._SendNextChunkAsync_d__81.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._SendNextChunkAsync_d__81.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170000BD RID: 189
			// (get) Token: 0x06000234 RID: 564 RVA: 0x0000D4D0 File Offset: 0x0000B6D0
			// (set) Token: 0x06000235 RID: 565 RVA: 0x00002DF3 File Offset: 0x00000FF3
			public unsafe ResumableUpload __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._SendNextChunkAsync_d__81.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResumableUpload>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._SendNextChunkAsync_d__81.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000BE RID: 190
			// (get) Token: 0x06000236 RID: 566 RVA: 0x0000D500 File Offset: 0x0000B700
			// (set) Token: 0x06000237 RID: 567 RVA: 0x00002E12 File Offset: 0x00001012
			public unsafe Stream stream
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._SendNextChunkAsync_d__81.NativeFieldInfoPtr_stream);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._SendNextChunkAsync_d__81.NativeFieldInfoPtr_stream), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000BF RID: 191
			// (get) Token: 0x06000238 RID: 568 RVA: 0x0000D530 File Offset: 0x0000B730
			// (set) Token: 0x06000239 RID: 569 RVA: 0x00002E31 File Offset: 0x00001031
			public unsafe HttpRequestMessage _request_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._SendNextChunkAsync_d__81.NativeFieldInfoPtr__request_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpRequestMessage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._SendNextChunkAsync_d__81.NativeFieldInfoPtr__request_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000C0 RID: 192
			// (get) Token: 0x0600023A RID: 570 RVA: 0x0000D560 File Offset: 0x0000B760
			// (set) Token: 0x0600023B RID: 571 RVA: 0x00002E50 File Offset: 0x00001050
			public unsafe Il2CppStructArray<byte> _chunk_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._SendNextChunkAsync_d__81.NativeFieldInfoPtr__chunk_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._SendNextChunkAsync_d__81.NativeFieldInfoPtr__chunk_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000C1 RID: 193
			// (get) Token: 0x0600023C RID: 572 RVA: 0x0000D590 File Offset: 0x0000B790
			// (set) Token: 0x0600023D RID: 573 RVA: 0x00002E6F File Offset: 0x0000106F
			public unsafe long _bytesServerReceivedBefore_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._SendNextChunkAsync_d__81.NativeFieldInfoPtr__bytesServerReceivedBefore_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._SendNextChunkAsync_d__81.NativeFieldInfoPtr__bytesServerReceivedBefore_5__4)) = value;
				}
			}

			// Token: 0x170000C2 RID: 194
			// (get) Token: 0x0600023E RID: 574 RVA: 0x0000D5B8 File Offset: 0x0000B7B8
			// (set) Token: 0x0600023F RID: 575 RVA: 0x00002E8A File Offset: 0x0000108A
			public ConfiguredTaskAwaitable<Tuple<Il2CppStructArray<byte>, int>>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._SendNextChunkAsync_d__81.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<Tuple<Il2CppStructArray<byte>, int>>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Tuple<Il2CppStructArray<byte>, int>>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._SendNextChunkAsync_d__81.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Tuple<Il2CppStructArray<byte>, int>>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170000C3 RID: 195
			// (get) Token: 0x06000240 RID: 576 RVA: 0x0000D5E8 File Offset: 0x0000B7E8
			// (set) Token: 0x06000241 RID: 577 RVA: 0x00002EB8 File Offset: 0x000010B8
			public ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._SendNextChunkAsync_d__81.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._SendNextChunkAsync_d__81.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170000C4 RID: 196
			// (get) Token: 0x06000242 RID: 578 RVA: 0x0000D618 File Offset: 0x0000B818
			// (set) Token: 0x06000243 RID: 579 RVA: 0x00002EE6 File Offset: 0x000010E6
			public ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter __u__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._SendNextChunkAsync_d__81.NativeFieldInfoPtr___u__3);
					return new ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._SendNextChunkAsync_d__81.NativeFieldInfoPtr___u__3), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04000190 RID: 400
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000191 RID: 401
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04000192 RID: 402
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04000193 RID: 403
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000194 RID: 404
			private static readonly IntPtr NativeFieldInfoPtr_stream;

			// Token: 0x04000195 RID: 405
			private static readonly IntPtr NativeFieldInfoPtr__request_5__2;

			// Token: 0x04000196 RID: 406
			private static readonly IntPtr NativeFieldInfoPtr__chunk_5__3;

			// Token: 0x04000197 RID: 407
			private static readonly IntPtr NativeFieldInfoPtr__bytesServerReceivedBefore_5__4;

			// Token: 0x04000198 RID: 408
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04000199 RID: 409
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x0400019A RID: 410
			private static readonly IntPtr NativeFieldInfoPtr___u__3;

			// Token: 0x0400019B RID: 411
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400019C RID: 412
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200002B RID: 43
		[ObfuscatedName("Google.Apis.Upload.ResumableUpload+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000244 RID: 580 RVA: 0x0000D648 File Offset: 0x0000B848
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ResumableUpload.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResumableUpload.__c>.NativeClassPtr);
				ResumableUpload.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload.__c>.NativeClassPtr, "<>9");
				ResumableUpload.__c.NativeFieldInfoPtr___9__82_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload.__c>.NativeClassPtr, "<>9__82_0");
				ResumableUpload.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload.__c>.NativeClassPtr, 100663397);
				ResumableUpload.__c.NativeMethodInfoPtr__HandleResponse_b__82_0_Internal_Boolean_KeyValuePair_2_String_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload.__c>.NativeClassPtr, 100663398);
			}

			// Token: 0x06000245 RID: 581 RVA: 0x0000D6C4 File Offset: 0x0000B8C4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResumableUpload.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000246 RID: 582 RVA: 0x0000D700 File Offset: 0x0000B900
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1196101, XrefRangeEnd = 1196106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _HandleResponse_b__82_0(KeyValuePair<string, IEnumerable<string>> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload.__c.NativeMethodInfoPtr__HandleResponse_b__82_0_Internal_Boolean_KeyValuePair_2_String_IEnumerable_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000247 RID: 583 RVA: 0x00002F14 File Offset: 0x00001114
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000C5 RID: 197
			// (get) Token: 0x06000248 RID: 584 RVA: 0x0000D754 File Offset: 0x0000B954
			// (set) Token: 0x06000249 RID: 585 RVA: 0x00002F1D File Offset: 0x0000111D
			public unsafe static ResumableUpload.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ResumableUpload.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResumableUpload.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ResumableUpload.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000C6 RID: 198
			// (get) Token: 0x0600024A RID: 586 RVA: 0x0000D77C File Offset: 0x0000B97C
			// (set) Token: 0x0600024B RID: 587 RVA: 0x00002F2F File Offset: 0x0000112F
			public unsafe static Func<KeyValuePair<string, IEnumerable<string>>, bool> __9__82_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ResumableUpload.__c.NativeFieldInfoPtr___9__82_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<string, IEnumerable<string>>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ResumableUpload.__c.NativeFieldInfoPtr___9__82_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400019D RID: 413
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400019E RID: 414
			private static readonly IntPtr NativeFieldInfoPtr___9__82_0;

			// Token: 0x0400019F RID: 415
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040001A0 RID: 416
			private static readonly IntPtr NativeMethodInfoPtr__HandleResponse_b__82_0_Internal_Boolean_KeyValuePair_2_String_IEnumerable_1_String_0;
		}

		// Token: 0x0200002C RID: 44
		[ObfuscatedName("Google.Apis.Upload.ResumableUpload+<HandleResponse>d__82")]
		public sealed class _HandleResponse_d__82 : ValueType
		{
			// Token: 0x0600024C RID: 588 RVA: 0x0000D7A4 File Offset: 0x0000B9A4
			// Note: this type is marked as 'beforefieldinit'.
			static _HandleResponse_d__82()
			{
				Il2CppClassPointerStore<ResumableUpload._HandleResponse_d__82>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, "<HandleResponse>d__82");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResumableUpload._HandleResponse_d__82>.NativeClassPtr);
				ResumableUpload._HandleResponse_d__82.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload._HandleResponse_d__82>.NativeClassPtr, "<>1__state");
				ResumableUpload._HandleResponse_d__82.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload._HandleResponse_d__82>.NativeClassPtr, "<>t__builder");
				ResumableUpload._HandleResponse_d__82.NativeFieldInfoPtr_response = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload._HandleResponse_d__82>.NativeClassPtr, "response");
				ResumableUpload._HandleResponse_d__82.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload._HandleResponse_d__82>.NativeClassPtr, "<>4__this");
				ResumableUpload._HandleResponse_d__82.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload._HandleResponse_d__82>.NativeClassPtr, "<>u__1");
				ResumableUpload._HandleResponse_d__82.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload._HandleResponse_d__82>.NativeClassPtr, 100663399);
				ResumableUpload._HandleResponse_d__82.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload._HandleResponse_d__82>.NativeClassPtr, 100663400);
			}

			// Token: 0x0600024D RID: 589 RVA: 0x0000D85C File Offset: 0x0000BA5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1196106, XrefRangeEnd = 1196193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload._HandleResponse_d__82.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600024E RID: 590 RVA: 0x0000D894 File Offset: 0x0000BA94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1196193, XrefRangeEnd = 1196199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload._HandleResponse_d__82.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600024F RID: 591 RVA: 0x00002F41 File Offset: 0x00001141
			public _HandleResponse_d__82(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000250 RID: 592 RVA: 0x00002F4A File Offset: 0x0000114A
			public _HandleResponse_d__82()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResumableUpload._HandleResponse_d__82>.NativeClassPtr))
			{
			}

			// Token: 0x170000C7 RID: 199
			// (get) Token: 0x06000251 RID: 593 RVA: 0x0000D8DC File Offset: 0x0000BADC
			// (set) Token: 0x06000252 RID: 594 RVA: 0x00002F5C File Offset: 0x0000115C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._HandleResponse_d__82.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._HandleResponse_d__82.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170000C8 RID: 200
			// (get) Token: 0x06000253 RID: 595 RVA: 0x0000D904 File Offset: 0x0000BB04
			// (set) Token: 0x06000254 RID: 596 RVA: 0x00002F77 File Offset: 0x00001177
			public AsyncTaskMethodBuilder<bool> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._HandleResponse_d__82.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._HandleResponse_d__82.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170000C9 RID: 201
			// (get) Token: 0x06000255 RID: 597 RVA: 0x0000D934 File Offset: 0x0000BB34
			// (set) Token: 0x06000256 RID: 598 RVA: 0x00002FA5 File Offset: 0x000011A5
			public unsafe HttpResponseMessage response
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._HandleResponse_d__82.NativeFieldInfoPtr_response);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpResponseMessage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._HandleResponse_d__82.NativeFieldInfoPtr_response), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000CA RID: 202
			// (get) Token: 0x06000257 RID: 599 RVA: 0x0000D964 File Offset: 0x0000BB64
			// (set) Token: 0x06000258 RID: 600 RVA: 0x00002FC4 File Offset: 0x000011C4
			public unsafe ResumableUpload __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._HandleResponse_d__82.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResumableUpload>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._HandleResponse_d__82.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000CB RID: 203
			// (get) Token: 0x06000259 RID: 601 RVA: 0x0000D994 File Offset: 0x0000BB94
			// (set) Token: 0x0600025A RID: 602 RVA: 0x00002FE3 File Offset: 0x000011E3
			public ConfiguredTaskAwaitable<GoogleApiException>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._HandleResponse_d__82.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<GoogleApiException>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<GoogleApiException>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._HandleResponse_d__82.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<GoogleApiException>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040001A1 RID: 417
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040001A2 RID: 418
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040001A3 RID: 419
			private static readonly IntPtr NativeFieldInfoPtr_response;

			// Token: 0x040001A4 RID: 420
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040001A5 RID: 421
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040001A6 RID: 422
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040001A7 RID: 423
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200002D RID: 45
		[ObfuscatedName("Google.Apis.Upload.ResumableUpload+<PrepareNextChunkUnknownSizeAsync>d__85")]
		public sealed class _PrepareNextChunkUnknownSizeAsync_d__85 : ValueType
		{
			// Token: 0x0600025B RID: 603 RVA: 0x0000D9C4 File Offset: 0x0000BBC4
			// Note: this type is marked as 'beforefieldinit'.
			static _PrepareNextChunkUnknownSizeAsync_d__85()
			{
				Il2CppClassPointerStore<ResumableUpload._PrepareNextChunkUnknownSizeAsync_d__85>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, "<PrepareNextChunkUnknownSizeAsync>d__85");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResumableUpload._PrepareNextChunkUnknownSizeAsync_d__85>.NativeClassPtr);
				ResumableUpload._PrepareNextChunkUnknownSizeAsync_d__85.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload._PrepareNextChunkUnknownSizeAsync_d__85>.NativeClassPtr, "<>1__state");
				ResumableUpload._PrepareNextChunkUnknownSizeAsync_d__85.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload._PrepareNextChunkUnknownSizeAsync_d__85>.NativeClassPtr, "<>t__builder");
				ResumableUpload._PrepareNextChunkUnknownSizeAsync_d__85.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload._PrepareNextChunkUnknownSizeAsync_d__85>.NativeClassPtr, "<>4__this");
				ResumableUpload._PrepareNextChunkUnknownSizeAsync_d__85.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload._PrepareNextChunkUnknownSizeAsync_d__85>.NativeClassPtr, "cancellationToken");
				ResumableUpload._PrepareNextChunkUnknownSizeAsync_d__85.NativeFieldInfoPtr_stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload._PrepareNextChunkUnknownSizeAsync_d__85>.NativeClassPtr, "stream");
				ResumableUpload._PrepareNextChunkUnknownSizeAsync_d__85.NativeFieldInfoPtr__finished_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload._PrepareNextChunkUnknownSizeAsync_d__85>.NativeClassPtr, "<finished>5__2");
				ResumableUpload._PrepareNextChunkUnknownSizeAsync_d__85.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload._PrepareNextChunkUnknownSizeAsync_d__85>.NativeClassPtr, "<>u__1");
				ResumableUpload._PrepareNextChunkUnknownSizeAsync_d__85.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload._PrepareNextChunkUnknownSizeAsync_d__85>.NativeClassPtr, 100663401);
				ResumableUpload._PrepareNextChunkUnknownSizeAsync_d__85.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload._PrepareNextChunkUnknownSizeAsync_d__85>.NativeClassPtr, 100663402);
			}

			// Token: 0x0600025C RID: 604 RVA: 0x0000DAA4 File Offset: 0x0000BCA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1196199, XrefRangeEnd = 1196249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload._PrepareNextChunkUnknownSizeAsync_d__85.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600025D RID: 605 RVA: 0x0000DADC File Offset: 0x0000BCDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1196249, XrefRangeEnd = 1196255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload._PrepareNextChunkUnknownSizeAsync_d__85.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600025E RID: 606 RVA: 0x00003011 File Offset: 0x00001211
			public _PrepareNextChunkUnknownSizeAsync_d__85(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600025F RID: 607 RVA: 0x0000301A File Offset: 0x0000121A
			public _PrepareNextChunkUnknownSizeAsync_d__85()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResumableUpload._PrepareNextChunkUnknownSizeAsync_d__85>.NativeClassPtr))
			{
			}

			// Token: 0x170000CC RID: 204
			// (get) Token: 0x06000260 RID: 608 RVA: 0x0000DB24 File Offset: 0x0000BD24
			// (set) Token: 0x06000261 RID: 609 RVA: 0x0000302C File Offset: 0x0000122C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._PrepareNextChunkUnknownSizeAsync_d__85.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._PrepareNextChunkUnknownSizeAsync_d__85.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170000CD RID: 205
			// (get) Token: 0x06000262 RID: 610 RVA: 0x0000DB4C File Offset: 0x0000BD4C
			// (set) Token: 0x06000263 RID: 611 RVA: 0x00003047 File Offset: 0x00001247
			public AsyncTaskMethodBuilder<Tuple<Il2CppStructArray<byte>, int>> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._PrepareNextChunkUnknownSizeAsync_d__85.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Tuple<Il2CppStructArray<byte>, int>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Tuple<Il2CppStructArray<byte>, int>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._PrepareNextChunkUnknownSizeAsync_d__85.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Tuple<Il2CppStructArray<byte>, int>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170000CE RID: 206
			// (get) Token: 0x06000264 RID: 612 RVA: 0x0000DB7C File Offset: 0x0000BD7C
			// (set) Token: 0x06000265 RID: 613 RVA: 0x00003075 File Offset: 0x00001275
			public unsafe ResumableUpload __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._PrepareNextChunkUnknownSizeAsync_d__85.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResumableUpload>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._PrepareNextChunkUnknownSizeAsync_d__85.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000CF RID: 207
			// (get) Token: 0x06000266 RID: 614 RVA: 0x0000DBAC File Offset: 0x0000BDAC
			// (set) Token: 0x06000267 RID: 615 RVA: 0x00003094 File Offset: 0x00001294
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._PrepareNextChunkUnknownSizeAsync_d__85.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._PrepareNextChunkUnknownSizeAsync_d__85.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170000D0 RID: 208
			// (get) Token: 0x06000268 RID: 616 RVA: 0x0000DBDC File Offset: 0x0000BDDC
			// (set) Token: 0x06000269 RID: 617 RVA: 0x000030C2 File Offset: 0x000012C2
			public unsafe Stream stream
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._PrepareNextChunkUnknownSizeAsync_d__85.NativeFieldInfoPtr_stream);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._PrepareNextChunkUnknownSizeAsync_d__85.NativeFieldInfoPtr_stream), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000D1 RID: 209
			// (get) Token: 0x0600026A RID: 618 RVA: 0x0000DC0C File Offset: 0x0000BE0C
			// (set) Token: 0x0600026B RID: 619 RVA: 0x000030E1 File Offset: 0x000012E1
			public unsafe bool _finished_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._PrepareNextChunkUnknownSizeAsync_d__85.NativeFieldInfoPtr__finished_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._PrepareNextChunkUnknownSizeAsync_d__85.NativeFieldInfoPtr__finished_5__2)) = value;
				}
			}

			// Token: 0x170000D2 RID: 210
			// (get) Token: 0x0600026C RID: 620 RVA: 0x0000DC34 File Offset: 0x0000BE34
			// (set) Token: 0x0600026D RID: 621 RVA: 0x000030FC File Offset: 0x000012FC
			public ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._PrepareNextChunkUnknownSizeAsync_d__85.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._PrepareNextChunkUnknownSizeAsync_d__85.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040001A8 RID: 424
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040001A9 RID: 425
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040001AA RID: 426
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040001AB RID: 427
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x040001AC RID: 428
			private static readonly IntPtr NativeFieldInfoPtr_stream;

			// Token: 0x040001AD RID: 429
			private static readonly IntPtr NativeFieldInfoPtr__finished_5__2;

			// Token: 0x040001AE RID: 430
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040001AF RID: 431
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040001B0 RID: 432
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200002E RID: 46
		[ObfuscatedName("Google.Apis.Upload.ResumableUpload+<PrepareNextChunkKnownSizeAsync>d__86")]
		public sealed class _PrepareNextChunkKnownSizeAsync_d__86 : ValueType
		{
			// Token: 0x0600026E RID: 622 RVA: 0x0000DC64 File Offset: 0x0000BE64
			// Note: this type is marked as 'beforefieldinit'.
			static _PrepareNextChunkKnownSizeAsync_d__86()
			{
				Il2CppClassPointerStore<ResumableUpload._PrepareNextChunkKnownSizeAsync_d__86>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResumableUpload>.NativeClassPtr, "<PrepareNextChunkKnownSizeAsync>d__86");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResumableUpload._PrepareNextChunkKnownSizeAsync_d__86>.NativeClassPtr);
				ResumableUpload._PrepareNextChunkKnownSizeAsync_d__86.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload._PrepareNextChunkKnownSizeAsync_d__86>.NativeClassPtr, "<>1__state");
				ResumableUpload._PrepareNextChunkKnownSizeAsync_d__86.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload._PrepareNextChunkKnownSizeAsync_d__86>.NativeClassPtr, "<>t__builder");
				ResumableUpload._PrepareNextChunkKnownSizeAsync_d__86.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload._PrepareNextChunkKnownSizeAsync_d__86>.NativeClassPtr, "<>4__this");
				ResumableUpload._PrepareNextChunkKnownSizeAsync_d__86.NativeFieldInfoPtr_stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload._PrepareNextChunkKnownSizeAsync_d__86>.NativeClassPtr, "stream");
				ResumableUpload._PrepareNextChunkKnownSizeAsync_d__86.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload._PrepareNextChunkKnownSizeAsync_d__86>.NativeClassPtr, "cancellationToken");
				ResumableUpload._PrepareNextChunkKnownSizeAsync_d__86.NativeFieldInfoPtr__chunk_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload._PrepareNextChunkKnownSizeAsync_d__86>.NativeClassPtr, "<chunk>5__2");
				ResumableUpload._PrepareNextChunkKnownSizeAsync_d__86.NativeFieldInfoPtr__bytesLeft_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload._PrepareNextChunkKnownSizeAsync_d__86>.NativeClassPtr, "<bytesLeft>5__3");
				ResumableUpload._PrepareNextChunkKnownSizeAsync_d__86.NativeFieldInfoPtr__bytesRead_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload._PrepareNextChunkKnownSizeAsync_d__86>.NativeClassPtr, "<bytesRead>5__4");
				ResumableUpload._PrepareNextChunkKnownSizeAsync_d__86.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUpload._PrepareNextChunkKnownSizeAsync_d__86>.NativeClassPtr, "<>u__1");
				ResumableUpload._PrepareNextChunkKnownSizeAsync_d__86.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload._PrepareNextChunkKnownSizeAsync_d__86>.NativeClassPtr, 100663403);
				ResumableUpload._PrepareNextChunkKnownSizeAsync_d__86.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUpload._PrepareNextChunkKnownSizeAsync_d__86>.NativeClassPtr, 100663404);
			}

			// Token: 0x0600026F RID: 623 RVA: 0x0000DD6C File Offset: 0x0000BF6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1196255, XrefRangeEnd = 1196301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload._PrepareNextChunkKnownSizeAsync_d__86.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000270 RID: 624 RVA: 0x0000DDA4 File Offset: 0x0000BFA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1196301, XrefRangeEnd = 1196307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUpload._PrepareNextChunkKnownSizeAsync_d__86.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000271 RID: 625 RVA: 0x0000312A File Offset: 0x0000132A
			public _PrepareNextChunkKnownSizeAsync_d__86(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000272 RID: 626 RVA: 0x00003133 File Offset: 0x00001333
			public _PrepareNextChunkKnownSizeAsync_d__86()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResumableUpload._PrepareNextChunkKnownSizeAsync_d__86>.NativeClassPtr))
			{
			}

			// Token: 0x170000D3 RID: 211
			// (get) Token: 0x06000273 RID: 627 RVA: 0x0000DDEC File Offset: 0x0000BFEC
			// (set) Token: 0x06000274 RID: 628 RVA: 0x00003145 File Offset: 0x00001345
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._PrepareNextChunkKnownSizeAsync_d__86.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._PrepareNextChunkKnownSizeAsync_d__86.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170000D4 RID: 212
			// (get) Token: 0x06000275 RID: 629 RVA: 0x0000DE14 File Offset: 0x0000C014
			// (set) Token: 0x06000276 RID: 630 RVA: 0x00003160 File Offset: 0x00001360
			public AsyncTaskMethodBuilder<Tuple<Il2CppStructArray<byte>, int>> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._PrepareNextChunkKnownSizeAsync_d__86.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Tuple<Il2CppStructArray<byte>, int>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Tuple<Il2CppStructArray<byte>, int>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._PrepareNextChunkKnownSizeAsync_d__86.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Tuple<Il2CppStructArray<byte>, int>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170000D5 RID: 213
			// (get) Token: 0x06000277 RID: 631 RVA: 0x0000DE44 File Offset: 0x0000C044
			// (set) Token: 0x06000278 RID: 632 RVA: 0x0000318E File Offset: 0x0000138E
			public unsafe ResumableUpload __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._PrepareNextChunkKnownSizeAsync_d__86.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResumableUpload>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._PrepareNextChunkKnownSizeAsync_d__86.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000D6 RID: 214
			// (get) Token: 0x06000279 RID: 633 RVA: 0x0000DE74 File Offset: 0x0000C074
			// (set) Token: 0x0600027A RID: 634 RVA: 0x000031AD File Offset: 0x000013AD
			public unsafe Stream stream
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._PrepareNextChunkKnownSizeAsync_d__86.NativeFieldInfoPtr_stream);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._PrepareNextChunkKnownSizeAsync_d__86.NativeFieldInfoPtr_stream), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000D7 RID: 215
			// (get) Token: 0x0600027B RID: 635 RVA: 0x0000DEA4 File Offset: 0x0000C0A4
			// (set) Token: 0x0600027C RID: 636 RVA: 0x000031CC File Offset: 0x000013CC
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._PrepareNextChunkKnownSizeAsync_d__86.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._PrepareNextChunkKnownSizeAsync_d__86.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170000D8 RID: 216
			// (get) Token: 0x0600027D RID: 637 RVA: 0x0000DED4 File Offset: 0x0000C0D4
			// (set) Token: 0x0600027E RID: 638 RVA: 0x000031FA File Offset: 0x000013FA
			public unsafe Il2CppStructArray<byte> _chunk_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._PrepareNextChunkKnownSizeAsync_d__86.NativeFieldInfoPtr__chunk_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._PrepareNextChunkKnownSizeAsync_d__86.NativeFieldInfoPtr__chunk_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000D9 RID: 217
			// (get) Token: 0x0600027F RID: 639 RVA: 0x0000DF04 File Offset: 0x0000C104
			// (set) Token: 0x06000280 RID: 640 RVA: 0x00003219 File Offset: 0x00001419
			public unsafe int _bytesLeft_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._PrepareNextChunkKnownSizeAsync_d__86.NativeFieldInfoPtr__bytesLeft_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._PrepareNextChunkKnownSizeAsync_d__86.NativeFieldInfoPtr__bytesLeft_5__3)) = value;
				}
			}

			// Token: 0x170000DA RID: 218
			// (get) Token: 0x06000281 RID: 641 RVA: 0x0000DF2C File Offset: 0x0000C12C
			// (set) Token: 0x06000282 RID: 642 RVA: 0x00003234 File Offset: 0x00001434
			public unsafe int _bytesRead_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._PrepareNextChunkKnownSizeAsync_d__86.NativeFieldInfoPtr__bytesRead_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._PrepareNextChunkKnownSizeAsync_d__86.NativeFieldInfoPtr__bytesRead_5__4)) = value;
				}
			}

			// Token: 0x170000DB RID: 219
			// (get) Token: 0x06000283 RID: 643 RVA: 0x0000DF54 File Offset: 0x0000C154
			// (set) Token: 0x06000284 RID: 644 RVA: 0x0000324F File Offset: 0x0000144F
			public ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._PrepareNextChunkKnownSizeAsync_d__86.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUpload._PrepareNextChunkKnownSizeAsync_d__86.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040001B1 RID: 433
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040001B2 RID: 434
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040001B3 RID: 435
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040001B4 RID: 436
			private static readonly IntPtr NativeFieldInfoPtr_stream;

			// Token: 0x040001B5 RID: 437
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x040001B6 RID: 438
			private static readonly IntPtr NativeFieldInfoPtr__chunk_5__2;

			// Token: 0x040001B7 RID: 439
			private static readonly IntPtr NativeFieldInfoPtr__bytesLeft_5__3;

			// Token: 0x040001B8 RID: 440
			private static readonly IntPtr NativeFieldInfoPtr__bytesRead_5__4;

			// Token: 0x040001B9 RID: 441
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040001BA RID: 442
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040001BB RID: 443
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
