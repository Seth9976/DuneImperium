using System;
using Google.Apis.Http;
using Google.Apis.Logging;
using Google.Apis.Services;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.IO;
using Il2CppSystem.Net.Http;
using Il2CppSystem.Net.Http.Headers;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Google.Apis.Download
{
	// Token: 0x0200001B RID: 27
	public class MediaDownloader : Object
	{
		// Token: 0x0600019E RID: 414 RVA: 0x0000B5B0 File Offset: 0x000097B0
		// Note: this type is marked as 'beforefieldinit'.
		static MediaDownloader()
		{
			Il2CppClassPointerStore<MediaDownloader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.dll", "Google.Apis.Download", "MediaDownloader");
			MediaDownloader.NativeFieldInfoPtr_Logger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediaDownloader>.NativeClassPtr, "Logger");
			MediaDownloader.NativeFieldInfoPtr_service = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediaDownloader>.NativeClassPtr, "service");
			MediaDownloader.NativeFieldInfoPtr_MB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediaDownloader>.NativeClassPtr, "MB");
			MediaDownloader.NativeFieldInfoPtr_MaximumChunkSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediaDownloader>.NativeClassPtr, "MaximumChunkSize");
			MediaDownloader.NativeFieldInfoPtr_chunkSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediaDownloader>.NativeClassPtr, "chunkSize");
			MediaDownloader.NativeFieldInfoPtr__Range_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediaDownloader>.NativeClassPtr, "<Range>k__BackingField");
			MediaDownloader.NativeFieldInfoPtr__ResponseStreamInterceptorProvider_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediaDownloader>.NativeClassPtr, "<ResponseStreamInterceptorProvider>k__BackingField");
			MediaDownloader.NativeFieldInfoPtr__ModifyRequest_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediaDownloader>.NativeClassPtr, "<ModifyRequest>k__BackingField");
			MediaDownloader.NativeFieldInfoPtr_ProgressChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediaDownloader>.NativeClassPtr, "ProgressChanged");
			MediaDownloader.NativeMethodInfoPtr_get_ChunkSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediaDownloader>.NativeClassPtr, 100663651);
			MediaDownloader.NativeMethodInfoPtr_set_ChunkSize_Public_Virtual_Final_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediaDownloader>.NativeClassPtr, 100663652);
			MediaDownloader.NativeMethodInfoPtr_get_Range_Public_get_RangeHeaderValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediaDownloader>.NativeClassPtr, 100663653);
			MediaDownloader.NativeMethodInfoPtr_set_Range_Public_set_Void_RangeHeaderValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediaDownloader>.NativeClassPtr, 100663654);
			MediaDownloader.NativeMethodInfoPtr_get_ResponseStreamInterceptorProvider_Public_get_Func_2_HttpResponseMessage_StreamInterceptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediaDownloader>.NativeClassPtr, 100663655);
			MediaDownloader.NativeMethodInfoPtr_set_ResponseStreamInterceptorProvider_Public_set_Void_Func_2_HttpResponseMessage_StreamInterceptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediaDownloader>.NativeClassPtr, 100663656);
			MediaDownloader.NativeMethodInfoPtr_UpdateProgress_Private_Void_IDownloadProgress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediaDownloader>.NativeClassPtr, 100663657);
			MediaDownloader.NativeMethodInfoPtr__ctor_Public_Void_IClientService_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediaDownloader>.NativeClassPtr, 100663658);
			MediaDownloader.NativeMethodInfoPtr_get_ModifyRequest_Public_get_Action_1_HttpRequestMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediaDownloader>.NativeClassPtr, 100663659);
			MediaDownloader.NativeMethodInfoPtr_set_ModifyRequest_Public_set_Void_Action_1_HttpRequestMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediaDownloader>.NativeClassPtr, 100663660);
			MediaDownloader.NativeMethodInfoPtr_add_ProgressChanged_Public_Virtual_Final_New_add_Void_Action_1_IDownloadProgress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediaDownloader>.NativeClassPtr, 100663661);
			MediaDownloader.NativeMethodInfoPtr_remove_ProgressChanged_Public_Virtual_Final_New_rem_Void_Action_1_IDownloadProgress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediaDownloader>.NativeClassPtr, 100663662);
			MediaDownloader.NativeMethodInfoPtr_Download_Public_Virtual_Final_New_IDownloadProgress_String_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediaDownloader>.NativeClassPtr, 100663663);
			MediaDownloader.NativeMethodInfoPtr_DownloadAsync_Public_Virtual_Final_New_Task_1_IDownloadProgress_String_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediaDownloader>.NativeClassPtr, 100663664);
			MediaDownloader.NativeMethodInfoPtr_DownloadAsync_Public_Virtual_Final_New_Task_1_IDownloadProgress_String_Stream_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediaDownloader>.NativeClassPtr, 100663665);
			MediaDownloader.NativeMethodInfoPtr_DownloadCoreAsync_Private_Task_1_IDownloadProgress_String_Stream_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediaDownloader>.NativeClassPtr, 100663666);
			MediaDownloader.NativeMethodInfoPtr_OnResponseReceived_Protected_Virtual_New_Void_HttpResponseMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediaDownloader>.NativeClassPtr, 100663667);
			MediaDownloader.NativeMethodInfoPtr_OnDataReceived_Protected_Virtual_New_Void_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediaDownloader>.NativeClassPtr, 100663668);
			MediaDownloader.NativeMethodInfoPtr_OnDownloadCompleted_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediaDownloader>.NativeClassPtr, 100663669);
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x0600019F RID: 415 RVA: 0x0000B808 File Offset: 0x00009A08
		// (set) Token: 0x060001A0 RID: 416 RVA: 0x0000B844 File Offset: 0x00009A44
		public unsafe virtual int ChunkSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MediaDownloader.NativeMethodInfoPtr_get_ChunkSize_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MediaDownloader.NativeMethodInfoPtr_set_ChunkSize_Public_Virtual_Final_New_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x0000B884 File Offset: 0x00009A84
		// (set) Token: 0x060001A2 RID: 418 RVA: 0x0000B8C4 File Offset: 0x00009AC4
		public unsafe RangeHeaderValue Range
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MediaDownloader.NativeMethodInfoPtr_get_Range_Public_get_RangeHeaderValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RangeHeaderValue>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MediaDownloader.NativeMethodInfoPtr_set_Range_Public_set_Void_RangeHeaderValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060001A3 RID: 419 RVA: 0x0000B908 File Offset: 0x00009B08
		// (set) Token: 0x060001A4 RID: 420 RVA: 0x0000B948 File Offset: 0x00009B48
		public unsafe Func<HttpResponseMessage, StreamInterceptor> ResponseStreamInterceptorProvider
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MediaDownloader.NativeMethodInfoPtr_get_ResponseStreamInterceptorProvider_Public_get_Func_2_HttpResponseMessage_StreamInterceptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<HttpResponseMessage, StreamInterceptor>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MediaDownloader.NativeMethodInfoPtr_set_ResponseStreamInterceptorProvider_Public_set_Void_Func_2_HttpResponseMessage_StreamInterceptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x0000B98C File Offset: 0x00009B8C
		[CallerCount(0)]
		public unsafe void UpdateProgress(IDownloadProgress progress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(progress);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MediaDownloader.NativeMethodInfoPtr_UpdateProgress_Private_Void_IDownloadProgress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x0000B9D0 File Offset: 0x00009BD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1199442, XrefRangeEnd = 1199444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MediaDownloader(IClientService service)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MediaDownloader>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(service);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MediaDownloader.NativeMethodInfoPtr__ctor_Public_Void_IClientService_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060001A7 RID: 423 RVA: 0x0000BA1C File Offset: 0x00009C1C
		// (set) Token: 0x060001A8 RID: 424 RVA: 0x0000BA5C File Offset: 0x00009C5C
		public unsafe Action<HttpRequestMessage> ModifyRequest
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MediaDownloader.NativeMethodInfoPtr_get_ModifyRequest_Public_get_Action_1_HttpRequestMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<HttpRequestMessage>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MediaDownloader.NativeMethodInfoPtr_set_ModifyRequest_Public_set_Void_Action_1_HttpRequestMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x0000BAA0 File Offset: 0x00009CA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1199444, XrefRangeEnd = 1199449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void add_ProgressChanged(Action<IDownloadProgress> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MediaDownloader.NativeMethodInfoPtr_add_ProgressChanged_Public_Virtual_Final_New_add_Void_Action_1_IDownloadProgress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001AA RID: 426 RVA: 0x0000BAE4 File Offset: 0x00009CE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1199449, XrefRangeEnd = 1199454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void remove_ProgressChanged(Action<IDownloadProgress> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MediaDownloader.NativeMethodInfoPtr_remove_ProgressChanged_Public_Virtual_Final_New_rem_Void_Action_1_IDownloadProgress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001AB RID: 427 RVA: 0x0000BB28 File Offset: 0x00009D28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1199454, XrefRangeEnd = 1199463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IDownloadProgress Download(string url, Stream stream)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stream);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MediaDownloader.NativeMethodInfoPtr_Download_Public_Virtual_Final_New_IDownloadProgress_String_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDownloadProgress>(intPtr3) : null;
		}

		// Token: 0x060001AC RID: 428 RVA: 0x0000BB8C File Offset: 0x00009D8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1199463, XrefRangeEnd = 1199479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task<IDownloadProgress> DownloadAsync(string url, Stream stream)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stream);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MediaDownloader.NativeMethodInfoPtr_DownloadAsync_Public_Virtual_Final_New_Task_1_IDownloadProgress_String_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<IDownloadProgress>>(intPtr3) : null;
		}

		// Token: 0x060001AD RID: 429 RVA: 0x0000BBF0 File Offset: 0x00009DF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1199479, XrefRangeEnd = 1199496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task<IDownloadProgress> DownloadAsync(string url, Stream stream, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stream);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MediaDownloader.NativeMethodInfoPtr_DownloadAsync_Public_Virtual_Final_New_Task_1_IDownloadProgress_String_Stream_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<IDownloadProgress>>(intPtr3) : null;
		}

		// Token: 0x060001AE RID: 430 RVA: 0x0000BC6C File Offset: 0x00009E6C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1199514, RefRangeEnd = 1199516, XrefRangeStart = 1199496, XrefRangeEnd = 1199514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<IDownloadProgress> DownloadCoreAsync(string url, Stream stream, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stream);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MediaDownloader.NativeMethodInfoPtr_DownloadCoreAsync_Private_Task_1_IDownloadProgress_String_Stream_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<IDownloadProgress>>(intPtr3) : null;
		}

		// Token: 0x060001AF RID: 431 RVA: 0x0000BCE8 File Offset: 0x00009EE8
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnResponseReceived(HttpResponseMessage response)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(response);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MediaDownloader.NativeMethodInfoPtr_OnResponseReceived_Protected_Virtual_New_Void_HttpResponseMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x0000BD38 File Offset: 0x00009F38
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDataReceived(Il2CppStructArray<byte> data, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MediaDownloader.NativeMethodInfoPtr_OnDataReceived_Protected_Virtual_New_Void_Il2CppStructArray_1_Byte_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x0000BD94 File Offset: 0x00009F94
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDownloadCompleted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MediaDownloader.NativeMethodInfoPtr_OnDownloadCompleted_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00002858 File Offset: 0x00000A58
		public MediaDownloader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x0000BDD0 File Offset: 0x00009FD0
		// (set) Token: 0x060001B4 RID: 436 RVA: 0x00002861 File Offset: 0x00000A61
		public unsafe static ILogger Logger
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MediaDownloader.NativeFieldInfoPtr_Logger, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ILogger>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MediaDownloader.NativeFieldInfoPtr_Logger, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060001B5 RID: 437 RVA: 0x0000BDF8 File Offset: 0x00009FF8
		// (set) Token: 0x060001B6 RID: 438 RVA: 0x00002873 File Offset: 0x00000A73
		public unsafe IClientService service
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader.NativeFieldInfoPtr_service);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IClientService>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader.NativeFieldInfoPtr_service), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060001B7 RID: 439 RVA: 0x0000BE28 File Offset: 0x0000A028
		// (set) Token: 0x060001B8 RID: 440 RVA: 0x00002892 File Offset: 0x00000A92
		public unsafe static int MB
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MediaDownloader.NativeFieldInfoPtr_MB, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MediaDownloader.NativeFieldInfoPtr_MB, (void*)(&value));
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060001B9 RID: 441 RVA: 0x0000BE44 File Offset: 0x0000A044
		// (set) Token: 0x060001BA RID: 442 RVA: 0x000028A0 File Offset: 0x00000AA0
		public unsafe static int MaximumChunkSize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MediaDownloader.NativeFieldInfoPtr_MaximumChunkSize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MediaDownloader.NativeFieldInfoPtr_MaximumChunkSize, (void*)(&value));
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060001BB RID: 443 RVA: 0x0000BE60 File Offset: 0x0000A060
		// (set) Token: 0x060001BC RID: 444 RVA: 0x000028AE File Offset: 0x00000AAE
		public unsafe int chunkSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader.NativeFieldInfoPtr_chunkSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader.NativeFieldInfoPtr_chunkSize)) = value;
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060001BD RID: 445 RVA: 0x0000BE88 File Offset: 0x0000A088
		// (set) Token: 0x060001BE RID: 446 RVA: 0x000028C9 File Offset: 0x00000AC9
		public unsafe RangeHeaderValue _Range_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader.NativeFieldInfoPtr__Range_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RangeHeaderValue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader.NativeFieldInfoPtr__Range_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060001BF RID: 447 RVA: 0x0000BEB8 File Offset: 0x0000A0B8
		// (set) Token: 0x060001C0 RID: 448 RVA: 0x000028E8 File Offset: 0x00000AE8
		public unsafe Func<HttpResponseMessage, StreamInterceptor> _ResponseStreamInterceptorProvider_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader.NativeFieldInfoPtr__ResponseStreamInterceptorProvider_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<HttpResponseMessage, StreamInterceptor>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader.NativeFieldInfoPtr__ResponseStreamInterceptorProvider_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060001C1 RID: 449 RVA: 0x0000BEE8 File Offset: 0x0000A0E8
		// (set) Token: 0x060001C2 RID: 450 RVA: 0x00002907 File Offset: 0x00000B07
		public unsafe Action<HttpRequestMessage> _ModifyRequest_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader.NativeFieldInfoPtr__ModifyRequest_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<HttpRequestMessage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader.NativeFieldInfoPtr__ModifyRequest_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060001C3 RID: 451 RVA: 0x0000BF18 File Offset: 0x0000A118
		// (set) Token: 0x060001C4 RID: 452 RVA: 0x00002926 File Offset: 0x00000B26
		public unsafe Action<IDownloadProgress> ProgressChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader.NativeFieldInfoPtr_ProgressChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<IDownloadProgress>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader.NativeFieldInfoPtr_ProgressChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400013A RID: 314
		private static readonly IntPtr NativeFieldInfoPtr_Logger;

		// Token: 0x0400013B RID: 315
		private static readonly IntPtr NativeFieldInfoPtr_service;

		// Token: 0x0400013C RID: 316
		private static readonly IntPtr NativeFieldInfoPtr_MB;

		// Token: 0x0400013D RID: 317
		private static readonly IntPtr NativeFieldInfoPtr_MaximumChunkSize;

		// Token: 0x0400013E RID: 318
		private static readonly IntPtr NativeFieldInfoPtr_chunkSize;

		// Token: 0x0400013F RID: 319
		private static readonly IntPtr NativeFieldInfoPtr__Range_k__BackingField;

		// Token: 0x04000140 RID: 320
		private static readonly IntPtr NativeFieldInfoPtr__ResponseStreamInterceptorProvider_k__BackingField;

		// Token: 0x04000141 RID: 321
		private static readonly IntPtr NativeFieldInfoPtr__ModifyRequest_k__BackingField;

		// Token: 0x04000142 RID: 322
		private static readonly IntPtr NativeFieldInfoPtr_ProgressChanged;

		// Token: 0x04000143 RID: 323
		private static readonly IntPtr NativeMethodInfoPtr_get_ChunkSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000144 RID: 324
		private static readonly IntPtr NativeMethodInfoPtr_set_ChunkSize_Public_Virtual_Final_New_set_Void_Int32_0;

		// Token: 0x04000145 RID: 325
		private static readonly IntPtr NativeMethodInfoPtr_get_Range_Public_get_RangeHeaderValue_0;

		// Token: 0x04000146 RID: 326
		private static readonly IntPtr NativeMethodInfoPtr_set_Range_Public_set_Void_RangeHeaderValue_0;

		// Token: 0x04000147 RID: 327
		private static readonly IntPtr NativeMethodInfoPtr_get_ResponseStreamInterceptorProvider_Public_get_Func_2_HttpResponseMessage_StreamInterceptor_0;

		// Token: 0x04000148 RID: 328
		private static readonly IntPtr NativeMethodInfoPtr_set_ResponseStreamInterceptorProvider_Public_set_Void_Func_2_HttpResponseMessage_StreamInterceptor_0;

		// Token: 0x04000149 RID: 329
		private static readonly IntPtr NativeMethodInfoPtr_UpdateProgress_Private_Void_IDownloadProgress_0;

		// Token: 0x0400014A RID: 330
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IClientService_0;

		// Token: 0x0400014B RID: 331
		private static readonly IntPtr NativeMethodInfoPtr_get_ModifyRequest_Public_get_Action_1_HttpRequestMessage_0;

		// Token: 0x0400014C RID: 332
		private static readonly IntPtr NativeMethodInfoPtr_set_ModifyRequest_Public_set_Void_Action_1_HttpRequestMessage_0;

		// Token: 0x0400014D RID: 333
		private static readonly IntPtr NativeMethodInfoPtr_add_ProgressChanged_Public_Virtual_Final_New_add_Void_Action_1_IDownloadProgress_0;

		// Token: 0x0400014E RID: 334
		private static readonly IntPtr NativeMethodInfoPtr_remove_ProgressChanged_Public_Virtual_Final_New_rem_Void_Action_1_IDownloadProgress_0;

		// Token: 0x0400014F RID: 335
		private static readonly IntPtr NativeMethodInfoPtr_Download_Public_Virtual_Final_New_IDownloadProgress_String_Stream_0;

		// Token: 0x04000150 RID: 336
		private static readonly IntPtr NativeMethodInfoPtr_DownloadAsync_Public_Virtual_Final_New_Task_1_IDownloadProgress_String_Stream_0;

		// Token: 0x04000151 RID: 337
		private static readonly IntPtr NativeMethodInfoPtr_DownloadAsync_Public_Virtual_Final_New_Task_1_IDownloadProgress_String_Stream_CancellationToken_0;

		// Token: 0x04000152 RID: 338
		private static readonly IntPtr NativeMethodInfoPtr_DownloadCoreAsync_Private_Task_1_IDownloadProgress_String_Stream_CancellationToken_0;

		// Token: 0x04000153 RID: 339
		private static readonly IntPtr NativeMethodInfoPtr_OnResponseReceived_Protected_Virtual_New_Void_HttpResponseMessage_0;

		// Token: 0x04000154 RID: 340
		private static readonly IntPtr NativeMethodInfoPtr_OnDataReceived_Protected_Virtual_New_Void_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04000155 RID: 341
		private static readonly IntPtr NativeMethodInfoPtr_OnDownloadCompleted_Protected_Virtual_New_Void_0;

		// Token: 0x02000048 RID: 72
		public class DownloadProgress : Object
		{
			// Token: 0x06000405 RID: 1029 RVA: 0x000124EC File Offset: 0x000106EC
			// Note: this type is marked as 'beforefieldinit'.
			static DownloadProgress()
			{
				Il2CppClassPointerStore<MediaDownloader.DownloadProgress>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MediaDownloader>.NativeClassPtr, "DownloadProgress");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MediaDownloader.DownloadProgress>.NativeClassPtr);
				MediaDownloader.DownloadProgress.NativeFieldInfoPtr__Status_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediaDownloader.DownloadProgress>.NativeClassPtr, "<Status>k__BackingField");
				MediaDownloader.DownloadProgress.NativeFieldInfoPtr__BytesDownloaded_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediaDownloader.DownloadProgress>.NativeClassPtr, "<BytesDownloaded>k__BackingField");
				MediaDownloader.DownloadProgress.NativeFieldInfoPtr__Exception_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediaDownloader.DownloadProgress>.NativeClassPtr, "<Exception>k__BackingField");
				MediaDownloader.DownloadProgress.NativeMethodInfoPtr__ctor_Public_Void_DownloadStatus_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediaDownloader.DownloadProgress>.NativeClassPtr, 100663670);
				MediaDownloader.DownloadProgress.NativeMethodInfoPtr__ctor_Public_Void_Exception_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediaDownloader.DownloadProgress>.NativeClassPtr, 100663671);
				MediaDownloader.DownloadProgress.NativeMethodInfoPtr_get_Status_Public_Virtual_Final_New_get_DownloadStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediaDownloader.DownloadProgress>.NativeClassPtr, 100663672);
				MediaDownloader.DownloadProgress.NativeMethodInfoPtr_set_Status_Private_set_Void_DownloadStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediaDownloader.DownloadProgress>.NativeClassPtr, 100663673);
				MediaDownloader.DownloadProgress.NativeMethodInfoPtr_get_BytesDownloaded_Public_Virtual_Final_New_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediaDownloader.DownloadProgress>.NativeClassPtr, 100663674);
				MediaDownloader.DownloadProgress.NativeMethodInfoPtr_set_BytesDownloaded_Private_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediaDownloader.DownloadProgress>.NativeClassPtr, 100663675);
				MediaDownloader.DownloadProgress.NativeMethodInfoPtr_get_Exception_Public_Virtual_Final_New_get_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediaDownloader.DownloadProgress>.NativeClassPtr, 100663676);
				MediaDownloader.DownloadProgress.NativeMethodInfoPtr_set_Exception_Private_set_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediaDownloader.DownloadProgress>.NativeClassPtr, 100663677);
			}

			// Token: 0x06000406 RID: 1030 RVA: 0x000125F4 File Offset: 0x000107F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DownloadProgress(DownloadStatus status, long bytes)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MediaDownloader.DownloadProgress>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref status;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bytes;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MediaDownloader.DownloadProgress.NativeMethodInfoPtr__ctor_Public_Void_DownloadStatus_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000407 RID: 1031 RVA: 0x0001264C File Offset: 0x0001084C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1199118, RefRangeEnd = 1199119, XrefRangeStart = 1199116, XrefRangeEnd = 1199118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DownloadProgress(Exception exception, long bytes)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MediaDownloader.DownloadProgress>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bytes;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MediaDownloader.DownloadProgress.NativeMethodInfoPtr__ctor_Public_Void_Exception_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000166 RID: 358
			// (get) Token: 0x06000408 RID: 1032 RVA: 0x000126A8 File Offset: 0x000108A8
			// (set) Token: 0x06000409 RID: 1033 RVA: 0x000126E4 File Offset: 0x000108E4
			public unsafe virtual DownloadStatus Status
			{
				[CallerCount(5)]
				[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MediaDownloader.DownloadProgress.NativeMethodInfoPtr_get_Status_Public_Virtual_Final_New_get_DownloadStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MediaDownloader.DownloadProgress.NativeMethodInfoPtr_set_Status_Private_set_Void_DownloadStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000167 RID: 359
			// (get) Token: 0x0600040A RID: 1034 RVA: 0x00012724 File Offset: 0x00010924
			// (set) Token: 0x0600040B RID: 1035 RVA: 0x00012760 File Offset: 0x00010960
			public unsafe virtual long BytesDownloaded
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MediaDownloader.DownloadProgress.NativeMethodInfoPtr_get_BytesDownloaded_Public_Virtual_Final_New_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MediaDownloader.DownloadProgress.NativeMethodInfoPtr_set_BytesDownloaded_Private_set_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000168 RID: 360
			// (get) Token: 0x0600040C RID: 1036 RVA: 0x000127A0 File Offset: 0x000109A0
			// (set) Token: 0x0600040D RID: 1037 RVA: 0x000127E0 File Offset: 0x000109E0
			public unsafe virtual Exception Exception
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MediaDownloader.DownloadProgress.NativeMethodInfoPtr_get_Exception_Public_Virtual_Final_New_get_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MediaDownloader.DownloadProgress.NativeMethodInfoPtr_set_Exception_Private_set_Void_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x0600040E RID: 1038 RVA: 0x00004444 File Offset: 0x00002644
			public DownloadProgress(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000163 RID: 355
			// (get) Token: 0x0600040F RID: 1039 RVA: 0x00012824 File Offset: 0x00010A24
			// (set) Token: 0x06000410 RID: 1040 RVA: 0x0000444D File Offset: 0x0000264D
			public unsafe DownloadStatus _Status_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader.DownloadProgress.NativeFieldInfoPtr__Status_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader.DownloadProgress.NativeFieldInfoPtr__Status_k__BackingField)) = value;
				}
			}

			// Token: 0x17000164 RID: 356
			// (get) Token: 0x06000411 RID: 1041 RVA: 0x0001284C File Offset: 0x00010A4C
			// (set) Token: 0x06000412 RID: 1042 RVA: 0x00004468 File Offset: 0x00002668
			public unsafe long _BytesDownloaded_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader.DownloadProgress.NativeFieldInfoPtr__BytesDownloaded_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader.DownloadProgress.NativeFieldInfoPtr__BytesDownloaded_k__BackingField)) = value;
				}
			}

			// Token: 0x17000165 RID: 357
			// (get) Token: 0x06000413 RID: 1043 RVA: 0x00012874 File Offset: 0x00010A74
			// (set) Token: 0x06000414 RID: 1044 RVA: 0x00004483 File Offset: 0x00002683
			public unsafe Exception _Exception_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader.DownloadProgress.NativeFieldInfoPtr__Exception_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader.DownloadProgress.NativeFieldInfoPtr__Exception_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000286 RID: 646
			private static readonly IntPtr NativeFieldInfoPtr__Status_k__BackingField;

			// Token: 0x04000287 RID: 647
			private static readonly IntPtr NativeFieldInfoPtr__BytesDownloaded_k__BackingField;

			// Token: 0x04000288 RID: 648
			private static readonly IntPtr NativeFieldInfoPtr__Exception_k__BackingField;

			// Token: 0x04000289 RID: 649
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DownloadStatus_Int64_0;

			// Token: 0x0400028A RID: 650
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Exception_Int64_0;

			// Token: 0x0400028B RID: 651
			private static readonly IntPtr NativeMethodInfoPtr_get_Status_Public_Virtual_Final_New_get_DownloadStatus_0;

			// Token: 0x0400028C RID: 652
			private static readonly IntPtr NativeMethodInfoPtr_set_Status_Private_set_Void_DownloadStatus_0;

			// Token: 0x0400028D RID: 653
			private static readonly IntPtr NativeMethodInfoPtr_get_BytesDownloaded_Public_Virtual_Final_New_get_Int64_0;

			// Token: 0x0400028E RID: 654
			private static readonly IntPtr NativeMethodInfoPtr_set_BytesDownloaded_Private_set_Void_Int64_0;

			// Token: 0x0400028F RID: 655
			private static readonly IntPtr NativeMethodInfoPtr_get_Exception_Public_Virtual_Final_New_get_Exception_0;

			// Token: 0x04000290 RID: 656
			private static readonly IntPtr NativeMethodInfoPtr_set_Exception_Private_set_Void_Exception_0;
		}

		// Token: 0x02000049 RID: 73
		public class CountedBuffer : Object
		{
			// Token: 0x06000415 RID: 1045 RVA: 0x000128A4 File Offset: 0x00010AA4
			// Note: this type is marked as 'beforefieldinit'.
			static CountedBuffer()
			{
				Il2CppClassPointerStore<MediaDownloader.CountedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MediaDownloader>.NativeClassPtr, "CountedBuffer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MediaDownloader.CountedBuffer>.NativeClassPtr);
				MediaDownloader.CountedBuffer.NativeFieldInfoPtr__Data_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediaDownloader.CountedBuffer>.NativeClassPtr, "<Data>k__BackingField");
				MediaDownloader.CountedBuffer.NativeFieldInfoPtr__Count_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediaDownloader.CountedBuffer>.NativeClassPtr, "<Count>k__BackingField");
				MediaDownloader.CountedBuffer.NativeMethodInfoPtr_get_Data_Public_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediaDownloader.CountedBuffer>.NativeClassPtr, 100663678);
				MediaDownloader.CountedBuffer.NativeMethodInfoPtr_set_Data_Public_set_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediaDownloader.CountedBuffer>.NativeClassPtr, 100663679);
				MediaDownloader.CountedBuffer.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediaDownloader.CountedBuffer>.NativeClassPtr, 100663680);
				MediaDownloader.CountedBuffer.NativeMethodInfoPtr_set_Count_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediaDownloader.CountedBuffer>.NativeClassPtr, 100663681);
				MediaDownloader.CountedBuffer.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediaDownloader.CountedBuffer>.NativeClassPtr, 100663682);
				MediaDownloader.CountedBuffer.NativeMethodInfoPtr_get_IsEmpty_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediaDownloader.CountedBuffer>.NativeClassPtr, 100663683);
				MediaDownloader.CountedBuffer.NativeMethodInfoPtr_Fill_Public_Task_Stream_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediaDownloader.CountedBuffer>.NativeClassPtr, 100663684);
				MediaDownloader.CountedBuffer.NativeMethodInfoPtr_RemoveFromFront_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediaDownloader.CountedBuffer>.NativeClassPtr, 100663685);
			}

			// Token: 0x1700016B RID: 363
			// (get) Token: 0x06000416 RID: 1046 RVA: 0x00012998 File Offset: 0x00010B98
			// (set) Token: 0x06000417 RID: 1047 RVA: 0x000129D8 File Offset: 0x00010BD8
			public unsafe Il2CppStructArray<byte> Data
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MediaDownloader.CountedBuffer.NativeMethodInfoPtr_get_Data_Public_get_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MediaDownloader.CountedBuffer.NativeMethodInfoPtr_set_Data_Public_set_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700016C RID: 364
			// (get) Token: 0x06000418 RID: 1048 RVA: 0x00012A1C File Offset: 0x00010C1C
			// (set) Token: 0x06000419 RID: 1049 RVA: 0x00012A58 File Offset: 0x00010C58
			public unsafe int Count
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MediaDownloader.CountedBuffer.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 311421, RefRangeEnd = 311423, XrefRangeStart = 311421, XrefRangeEnd = 311423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MediaDownloader.CountedBuffer.NativeMethodInfoPtr_set_Count_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x0600041A RID: 1050 RVA: 0x00012A98 File Offset: 0x00010C98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1199146, XrefRangeEnd = 1199151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CountedBuffer(int size)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MediaDownloader.CountedBuffer>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref size;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MediaDownloader.CountedBuffer.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x1700016D RID: 365
			// (get) Token: 0x0600041B RID: 1051 RVA: 0x00012AE0 File Offset: 0x00010CE0
			public unsafe bool IsEmpty
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MediaDownloader.CountedBuffer.NativeMethodInfoPtr_get_IsEmpty_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600041C RID: 1052 RVA: 0x00012B1C File Offset: 0x00010D1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1199151, XrefRangeEnd = 1199163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Task Fill(Stream stream, CancellationToken cancellationToken)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MediaDownloader.CountedBuffer.NativeMethodInfoPtr_Fill_Public_Task_Stream_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}

			// Token: 0x0600041D RID: 1053 RVA: 0x00012B84 File Offset: 0x00010D84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1199163, XrefRangeEnd = 1199164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void RemoveFromFront(int n)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref n;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MediaDownloader.CountedBuffer.NativeMethodInfoPtr_RemoveFromFront_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600041E RID: 1054 RVA: 0x000044A2 File Offset: 0x000026A2
			public CountedBuffer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000169 RID: 361
			// (get) Token: 0x0600041F RID: 1055 RVA: 0x00012BC4 File Offset: 0x00010DC4
			// (set) Token: 0x06000420 RID: 1056 RVA: 0x000044AB File Offset: 0x000026AB
			public unsafe Il2CppStructArray<byte> _Data_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader.CountedBuffer.NativeFieldInfoPtr__Data_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader.CountedBuffer.NativeFieldInfoPtr__Data_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700016A RID: 362
			// (get) Token: 0x06000421 RID: 1057 RVA: 0x00012BF4 File Offset: 0x00010DF4
			// (set) Token: 0x06000422 RID: 1058 RVA: 0x000044CA File Offset: 0x000026CA
			public unsafe int _Count_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader.CountedBuffer.NativeFieldInfoPtr__Count_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader.CountedBuffer.NativeFieldInfoPtr__Count_k__BackingField)) = value;
				}
			}

			// Token: 0x04000291 RID: 657
			private static readonly IntPtr NativeFieldInfoPtr__Data_k__BackingField;

			// Token: 0x04000292 RID: 658
			private static readonly IntPtr NativeFieldInfoPtr__Count_k__BackingField;

			// Token: 0x04000293 RID: 659
			private static readonly IntPtr NativeMethodInfoPtr_get_Data_Public_get_Il2CppStructArray_1_Byte_0;

			// Token: 0x04000294 RID: 660
			private static readonly IntPtr NativeMethodInfoPtr_set_Data_Public_set_Void_Il2CppStructArray_1_Byte_0;

			// Token: 0x04000295 RID: 661
			private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

			// Token: 0x04000296 RID: 662
			private static readonly IntPtr NativeMethodInfoPtr_set_Count_Private_set_Void_Int32_0;

			// Token: 0x04000297 RID: 663
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000298 RID: 664
			private static readonly IntPtr NativeMethodInfoPtr_get_IsEmpty_Public_get_Boolean_0;

			// Token: 0x04000299 RID: 665
			private static readonly IntPtr NativeMethodInfoPtr_Fill_Public_Task_Stream_CancellationToken_0;

			// Token: 0x0400029A RID: 666
			private static readonly IntPtr NativeMethodInfoPtr_RemoveFromFront_Public_Void_Int32_0;

			// Token: 0x0200004E RID: 78
			[ObfuscatedName("Google.Apis.Download.MediaDownloader+CountedBuffer+<Fill>d__11")]
			public sealed class _Fill_d__11 : ValueType
			{
				// Token: 0x06000472 RID: 1138 RVA: 0x0001371C File Offset: 0x0001191C
				// Note: this type is marked as 'beforefieldinit'.
				static _Fill_d__11()
				{
					Il2CppClassPointerStore<MediaDownloader.CountedBuffer._Fill_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MediaDownloader.CountedBuffer>.NativeClassPtr, "<Fill>d__11");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MediaDownloader.CountedBuffer._Fill_d__11>.NativeClassPtr);
					MediaDownloader.CountedBuffer._Fill_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediaDownloader.CountedBuffer._Fill_d__11>.NativeClassPtr, "<>1__state");
					MediaDownloader.CountedBuffer._Fill_d__11.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediaDownloader.CountedBuffer._Fill_d__11>.NativeClassPtr, "<>t__builder");
					MediaDownloader.CountedBuffer._Fill_d__11.NativeFieldInfoPtr_stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediaDownloader.CountedBuffer._Fill_d__11>.NativeClassPtr, "stream");
					MediaDownloader.CountedBuffer._Fill_d__11.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediaDownloader.CountedBuffer._Fill_d__11>.NativeClassPtr, "<>4__this");
					MediaDownloader.CountedBuffer._Fill_d__11.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediaDownloader.CountedBuffer._Fill_d__11>.NativeClassPtr, "cancellationToken");
					MediaDownloader.CountedBuffer._Fill_d__11.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediaDownloader.CountedBuffer._Fill_d__11>.NativeClassPtr, "<>u__1");
					MediaDownloader.CountedBuffer._Fill_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediaDownloader.CountedBuffer._Fill_d__11>.NativeClassPtr, 100663686);
					MediaDownloader.CountedBuffer._Fill_d__11.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediaDownloader.CountedBuffer._Fill_d__11>.NativeClassPtr, 100663687);
				}

				// Token: 0x06000473 RID: 1139 RVA: 0x000137E8 File Offset: 0x000119E8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1199119, XrefRangeEnd = 1199142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MediaDownloader.CountedBuffer._Fill_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06000474 RID: 1140 RVA: 0x00013820 File Offset: 0x00011A20
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1199142, XrefRangeEnd = 1199146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MediaDownloader.CountedBuffer._Fill_d__11.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06000475 RID: 1141 RVA: 0x00004958 File Offset: 0x00002B58
				public _Fill_d__11(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06000476 RID: 1142 RVA: 0x00004961 File Offset: 0x00002B61
				public _Fill_d__11()
					: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MediaDownloader.CountedBuffer._Fill_d__11>.NativeClassPtr))
				{
				}

				// Token: 0x1700018C RID: 396
				// (get) Token: 0x06000477 RID: 1143 RVA: 0x00013868 File Offset: 0x00011A68
				// (set) Token: 0x06000478 RID: 1144 RVA: 0x00004973 File Offset: 0x00002B73
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader.CountedBuffer._Fill_d__11.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader.CountedBuffer._Fill_d__11.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x1700018D RID: 397
				// (get) Token: 0x06000479 RID: 1145 RVA: 0x00013890 File Offset: 0x00011A90
				// (set) Token: 0x0600047A RID: 1146 RVA: 0x0000498E File Offset: 0x00002B8E
				public AsyncTaskMethodBuilder __t__builder
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader.CountedBuffer._Fill_d__11.NativeFieldInfoPtr___t__builder);
						return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader.CountedBuffer._Fill_d__11.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x1700018E RID: 398
				// (get) Token: 0x0600047B RID: 1147 RVA: 0x000138C0 File Offset: 0x00011AC0
				// (set) Token: 0x0600047C RID: 1148 RVA: 0x000049BC File Offset: 0x00002BBC
				public unsafe Stream stream
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader.CountedBuffer._Fill_d__11.NativeFieldInfoPtr_stream);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader.CountedBuffer._Fill_d__11.NativeFieldInfoPtr_stream), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700018F RID: 399
				// (get) Token: 0x0600047D RID: 1149 RVA: 0x000138F0 File Offset: 0x00011AF0
				// (set) Token: 0x0600047E RID: 1150 RVA: 0x000049DB File Offset: 0x00002BDB
				public unsafe MediaDownloader.CountedBuffer __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader.CountedBuffer._Fill_d__11.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<MediaDownloader.CountedBuffer>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader.CountedBuffer._Fill_d__11.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000190 RID: 400
				// (get) Token: 0x0600047F RID: 1151 RVA: 0x00013920 File Offset: 0x00011B20
				// (set) Token: 0x06000480 RID: 1152 RVA: 0x000049FA File Offset: 0x00002BFA
				public CancellationToken cancellationToken
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader.CountedBuffer._Fill_d__11.NativeFieldInfoPtr_cancellationToken);
						return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader.CountedBuffer._Fill_d__11.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x17000191 RID: 401
				// (get) Token: 0x06000481 RID: 1153 RVA: 0x00013950 File Offset: 0x00011B50
				// (set) Token: 0x06000482 RID: 1154 RVA: 0x00004A28 File Offset: 0x00002C28
				public ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter __u__1
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader.CountedBuffer._Fill_d__11.NativeFieldInfoPtr___u__1);
						return new ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader.CountedBuffer._Fill_d__11.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x040002C1 RID: 705
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x040002C2 RID: 706
				private static readonly IntPtr NativeFieldInfoPtr___t__builder;

				// Token: 0x040002C3 RID: 707
				private static readonly IntPtr NativeFieldInfoPtr_stream;

				// Token: 0x040002C4 RID: 708
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x040002C5 RID: 709
				private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

				// Token: 0x040002C6 RID: 710
				private static readonly IntPtr NativeFieldInfoPtr___u__1;

				// Token: 0x040002C7 RID: 711
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

				// Token: 0x040002C8 RID: 712
				private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
			}
		}

		// Token: 0x0200004A RID: 74
		[ObfuscatedName("Google.Apis.Download.MediaDownloader+<DownloadAsync>d__28")]
		public sealed class _DownloadAsync_d__28 : ValueType
		{
			// Token: 0x06000423 RID: 1059 RVA: 0x00012C1C File Offset: 0x00010E1C
			// Note: this type is marked as 'beforefieldinit'.
			static _DownloadAsync_d__28()
			{
				Il2CppClassPointerStore<MediaDownloader._DownloadAsync_d__28>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MediaDownloader>.NativeClassPtr, "<DownloadAsync>d__28");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MediaDownloader._DownloadAsync_d__28>.NativeClassPtr);
				MediaDownloader._DownloadAsync_d__28.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediaDownloader._DownloadAsync_d__28>.NativeClassPtr, "<>1__state");
				MediaDownloader._DownloadAsync_d__28.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediaDownloader._DownloadAsync_d__28>.NativeClassPtr, "<>t__builder");
				MediaDownloader._DownloadAsync_d__28.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediaDownloader._DownloadAsync_d__28>.NativeClassPtr, "<>4__this");
				MediaDownloader._DownloadAsync_d__28.NativeFieldInfoPtr_url = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediaDownloader._DownloadAsync_d__28>.NativeClassPtr, "url");
				MediaDownloader._DownloadAsync_d__28.NativeFieldInfoPtr_stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediaDownloader._DownloadAsync_d__28>.NativeClassPtr, "stream");
				MediaDownloader._DownloadAsync_d__28.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediaDownloader._DownloadAsync_d__28>.NativeClassPtr, "<>u__1");
				MediaDownloader._DownloadAsync_d__28.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediaDownloader._DownloadAsync_d__28>.NativeClassPtr, 100663688);
				MediaDownloader._DownloadAsync_d__28.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediaDownloader._DownloadAsync_d__28>.NativeClassPtr, 100663689);
			}

			// Token: 0x06000424 RID: 1060 RVA: 0x00012CE8 File Offset: 0x00010EE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1199164, XrefRangeEnd = 1199203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MediaDownloader._DownloadAsync_d__28.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000425 RID: 1061 RVA: 0x00012D20 File Offset: 0x00010F20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1199203, XrefRangeEnd = 1199209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MediaDownloader._DownloadAsync_d__28.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000426 RID: 1062 RVA: 0x000044E5 File Offset: 0x000026E5
			public _DownloadAsync_d__28(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000427 RID: 1063 RVA: 0x000044EE File Offset: 0x000026EE
			public _DownloadAsync_d__28()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MediaDownloader._DownloadAsync_d__28>.NativeClassPtr))
			{
			}

			// Token: 0x1700016E RID: 366
			// (get) Token: 0x06000428 RID: 1064 RVA: 0x00012D68 File Offset: 0x00010F68
			// (set) Token: 0x06000429 RID: 1065 RVA: 0x00004500 File Offset: 0x00002700
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader._DownloadAsync_d__28.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader._DownloadAsync_d__28.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700016F RID: 367
			// (get) Token: 0x0600042A RID: 1066 RVA: 0x00012D90 File Offset: 0x00010F90
			// (set) Token: 0x0600042B RID: 1067 RVA: 0x0000451B File Offset: 0x0000271B
			public AsyncTaskMethodBuilder<IDownloadProgress> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader._DownloadAsync_d__28.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<IDownloadProgress>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<IDownloadProgress>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader._DownloadAsync_d__28.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<IDownloadProgress>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000170 RID: 368
			// (get) Token: 0x0600042C RID: 1068 RVA: 0x00012DC0 File Offset: 0x00010FC0
			// (set) Token: 0x0600042D RID: 1069 RVA: 0x00004549 File Offset: 0x00002749
			public unsafe MediaDownloader __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader._DownloadAsync_d__28.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MediaDownloader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader._DownloadAsync_d__28.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000171 RID: 369
			// (get) Token: 0x0600042E RID: 1070 RVA: 0x00012DF0 File Offset: 0x00010FF0
			// (set) Token: 0x0600042F RID: 1071 RVA: 0x00004568 File Offset: 0x00002768
			public unsafe string url
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader._DownloadAsync_d__28.NativeFieldInfoPtr_url);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader._DownloadAsync_d__28.NativeFieldInfoPtr_url), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000172 RID: 370
			// (get) Token: 0x06000430 RID: 1072 RVA: 0x00012E18 File Offset: 0x00011018
			// (set) Token: 0x06000431 RID: 1073 RVA: 0x00004587 File Offset: 0x00002787
			public unsafe Stream stream
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader._DownloadAsync_d__28.NativeFieldInfoPtr_stream);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader._DownloadAsync_d__28.NativeFieldInfoPtr_stream), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000173 RID: 371
			// (get) Token: 0x06000432 RID: 1074 RVA: 0x00012E48 File Offset: 0x00011048
			// (set) Token: 0x06000433 RID: 1075 RVA: 0x000045A6 File Offset: 0x000027A6
			public ConfiguredTaskAwaitable<IDownloadProgress>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader._DownloadAsync_d__28.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<IDownloadProgress>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<IDownloadProgress>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader._DownloadAsync_d__28.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<IDownloadProgress>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400029B RID: 667
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400029C RID: 668
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400029D RID: 669
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400029E RID: 670
			private static readonly IntPtr NativeFieldInfoPtr_url;

			// Token: 0x0400029F RID: 671
			private static readonly IntPtr NativeFieldInfoPtr_stream;

			// Token: 0x040002A0 RID: 672
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040002A1 RID: 673
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040002A2 RID: 674
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200004B RID: 75
		[ObfuscatedName("Google.Apis.Download.MediaDownloader+<DownloadAsync>d__29")]
		public sealed class _DownloadAsync_d__29 : ValueType
		{
			// Token: 0x06000434 RID: 1076 RVA: 0x00012E78 File Offset: 0x00011078
			// Note: this type is marked as 'beforefieldinit'.
			static _DownloadAsync_d__29()
			{
				Il2CppClassPointerStore<MediaDownloader._DownloadAsync_d__29>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MediaDownloader>.NativeClassPtr, "<DownloadAsync>d__29");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MediaDownloader._DownloadAsync_d__29>.NativeClassPtr);
				MediaDownloader._DownloadAsync_d__29.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediaDownloader._DownloadAsync_d__29>.NativeClassPtr, "<>1__state");
				MediaDownloader._DownloadAsync_d__29.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediaDownloader._DownloadAsync_d__29>.NativeClassPtr, "<>t__builder");
				MediaDownloader._DownloadAsync_d__29.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediaDownloader._DownloadAsync_d__29>.NativeClassPtr, "<>4__this");
				MediaDownloader._DownloadAsync_d__29.NativeFieldInfoPtr_url = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediaDownloader._DownloadAsync_d__29>.NativeClassPtr, "url");
				MediaDownloader._DownloadAsync_d__29.NativeFieldInfoPtr_stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediaDownloader._DownloadAsync_d__29>.NativeClassPtr, "stream");
				MediaDownloader._DownloadAsync_d__29.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediaDownloader._DownloadAsync_d__29>.NativeClassPtr, "cancellationToken");
				MediaDownloader._DownloadAsync_d__29.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediaDownloader._DownloadAsync_d__29>.NativeClassPtr, "<>u__1");
				MediaDownloader._DownloadAsync_d__29.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediaDownloader._DownloadAsync_d__29>.NativeClassPtr, 100663690);
				MediaDownloader._DownloadAsync_d__29.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediaDownloader._DownloadAsync_d__29>.NativeClassPtr, 100663691);
			}

			// Token: 0x06000435 RID: 1077 RVA: 0x00012F58 File Offset: 0x00011158
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1199209, XrefRangeEnd = 1199228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MediaDownloader._DownloadAsync_d__29.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000436 RID: 1078 RVA: 0x00012F90 File Offset: 0x00011190
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1199228, XrefRangeEnd = 1199234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MediaDownloader._DownloadAsync_d__29.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000437 RID: 1079 RVA: 0x000045D4 File Offset: 0x000027D4
			public _DownloadAsync_d__29(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000438 RID: 1080 RVA: 0x000045DD File Offset: 0x000027DD
			public _DownloadAsync_d__29()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MediaDownloader._DownloadAsync_d__29>.NativeClassPtr))
			{
			}

			// Token: 0x17000174 RID: 372
			// (get) Token: 0x06000439 RID: 1081 RVA: 0x00012FD8 File Offset: 0x000111D8
			// (set) Token: 0x0600043A RID: 1082 RVA: 0x000045EF File Offset: 0x000027EF
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader._DownloadAsync_d__29.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader._DownloadAsync_d__29.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000175 RID: 373
			// (get) Token: 0x0600043B RID: 1083 RVA: 0x00013000 File Offset: 0x00011200
			// (set) Token: 0x0600043C RID: 1084 RVA: 0x0000460A File Offset: 0x0000280A
			public AsyncTaskMethodBuilder<IDownloadProgress> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader._DownloadAsync_d__29.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<IDownloadProgress>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<IDownloadProgress>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader._DownloadAsync_d__29.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<IDownloadProgress>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000176 RID: 374
			// (get) Token: 0x0600043D RID: 1085 RVA: 0x00013030 File Offset: 0x00011230
			// (set) Token: 0x0600043E RID: 1086 RVA: 0x00004638 File Offset: 0x00002838
			public unsafe MediaDownloader __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader._DownloadAsync_d__29.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MediaDownloader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader._DownloadAsync_d__29.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000177 RID: 375
			// (get) Token: 0x0600043F RID: 1087 RVA: 0x00013060 File Offset: 0x00011260
			// (set) Token: 0x06000440 RID: 1088 RVA: 0x00004657 File Offset: 0x00002857
			public unsafe string url
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader._DownloadAsync_d__29.NativeFieldInfoPtr_url);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader._DownloadAsync_d__29.NativeFieldInfoPtr_url), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000178 RID: 376
			// (get) Token: 0x06000441 RID: 1089 RVA: 0x00013088 File Offset: 0x00011288
			// (set) Token: 0x06000442 RID: 1090 RVA: 0x00004676 File Offset: 0x00002876
			public unsafe Stream stream
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader._DownloadAsync_d__29.NativeFieldInfoPtr_stream);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader._DownloadAsync_d__29.NativeFieldInfoPtr_stream), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000179 RID: 377
			// (get) Token: 0x06000443 RID: 1091 RVA: 0x000130B8 File Offset: 0x000112B8
			// (set) Token: 0x06000444 RID: 1092 RVA: 0x00004695 File Offset: 0x00002895
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader._DownloadAsync_d__29.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader._DownloadAsync_d__29.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700017A RID: 378
			// (get) Token: 0x06000445 RID: 1093 RVA: 0x000130E8 File Offset: 0x000112E8
			// (set) Token: 0x06000446 RID: 1094 RVA: 0x000046C3 File Offset: 0x000028C3
			public ConfiguredTaskAwaitable<IDownloadProgress>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader._DownloadAsync_d__29.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<IDownloadProgress>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<IDownloadProgress>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader._DownloadAsync_d__29.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<IDownloadProgress>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040002A3 RID: 675
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040002A4 RID: 676
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040002A5 RID: 677
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040002A6 RID: 678
			private static readonly IntPtr NativeFieldInfoPtr_url;

			// Token: 0x040002A7 RID: 679
			private static readonly IntPtr NativeFieldInfoPtr_stream;

			// Token: 0x040002A8 RID: 680
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x040002A9 RID: 681
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040002AA RID: 682
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040002AB RID: 683
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200004C RID: 76
		[ObfuscatedName("Google.Apis.Download.MediaDownloader+<DownloadCoreAsync>d__31")]
		public sealed class _DownloadCoreAsync_d__31 : ValueType
		{
			// Token: 0x06000447 RID: 1095 RVA: 0x00013118 File Offset: 0x00011318
			// Note: this type is marked as 'beforefieldinit'.
			static _DownloadCoreAsync_d__31()
			{
				Il2CppClassPointerStore<MediaDownloader._DownloadCoreAsync_d__31>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MediaDownloader>.NativeClassPtr, "<DownloadCoreAsync>d__31");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MediaDownloader._DownloadCoreAsync_d__31>.NativeClassPtr);
				MediaDownloader._DownloadCoreAsync_d__31.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediaDownloader._DownloadCoreAsync_d__31>.NativeClassPtr, "<>1__state");
				MediaDownloader._DownloadCoreAsync_d__31.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediaDownloader._DownloadCoreAsync_d__31>.NativeClassPtr, "<>t__builder");
				MediaDownloader._DownloadCoreAsync_d__31.NativeFieldInfoPtr_url = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediaDownloader._DownloadCoreAsync_d__31>.NativeClassPtr, "url");
				MediaDownloader._DownloadCoreAsync_d__31.NativeFieldInfoPtr_stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediaDownloader._DownloadCoreAsync_d__31>.NativeClassPtr, "stream");
				MediaDownloader._DownloadCoreAsync_d__31.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediaDownloader._DownloadCoreAsync_d__31>.NativeClassPtr, "<>4__this");
				MediaDownloader._DownloadCoreAsync_d__31.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediaDownloader._DownloadCoreAsync_d__31>.NativeClassPtr, "cancellationToken");
				MediaDownloader._DownloadCoreAsync_d__31.NativeFieldInfoPtr__bytesReturned_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediaDownloader._DownloadCoreAsync_d__31>.NativeClassPtr, "<bytesReturned>5__2");
				MediaDownloader._DownloadCoreAsync_d__31.NativeFieldInfoPtr__response_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediaDownloader._DownloadCoreAsync_d__31>.NativeClassPtr, "<response>5__3");
				MediaDownloader._DownloadCoreAsync_d__31.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediaDownloader._DownloadCoreAsync_d__31>.NativeClassPtr, "<>u__1");
				MediaDownloader._DownloadCoreAsync_d__31.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediaDownloader._DownloadCoreAsync_d__31>.NativeClassPtr, "<>u__2");
				MediaDownloader._DownloadCoreAsync_d__31.NativeFieldInfoPtr__responseStream_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediaDownloader._DownloadCoreAsync_d__31>.NativeClassPtr, "<responseStream>5__4");
				MediaDownloader._DownloadCoreAsync_d__31.NativeFieldInfoPtr___u__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediaDownloader._DownloadCoreAsync_d__31>.NativeClassPtr, "<>u__3");
				MediaDownloader._DownloadCoreAsync_d__31.NativeFieldInfoPtr__buffer_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediaDownloader._DownloadCoreAsync_d__31>.NativeClassPtr, "<buffer>5__5");
				MediaDownloader._DownloadCoreAsync_d__31.NativeFieldInfoPtr__bytesToReturn_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediaDownloader._DownloadCoreAsync_d__31>.NativeClassPtr, "<bytesToReturn>5__6");
				MediaDownloader._DownloadCoreAsync_d__31.NativeFieldInfoPtr___u__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediaDownloader._DownloadCoreAsync_d__31>.NativeClassPtr, "<>u__4");
				MediaDownloader._DownloadCoreAsync_d__31.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediaDownloader._DownloadCoreAsync_d__31>.NativeClassPtr, 100663692);
				MediaDownloader._DownloadCoreAsync_d__31.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediaDownloader._DownloadCoreAsync_d__31>.NativeClassPtr, 100663693);
			}

			// Token: 0x06000448 RID: 1096 RVA: 0x00013298 File Offset: 0x00011498
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1199234, XrefRangeEnd = 1199436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MediaDownloader._DownloadCoreAsync_d__31.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000449 RID: 1097 RVA: 0x000132D0 File Offset: 0x000114D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1199436, XrefRangeEnd = 1199442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MediaDownloader._DownloadCoreAsync_d__31.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600044A RID: 1098 RVA: 0x000046F1 File Offset: 0x000028F1
			public _DownloadCoreAsync_d__31(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600044B RID: 1099 RVA: 0x000046FA File Offset: 0x000028FA
			public _DownloadCoreAsync_d__31()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MediaDownloader._DownloadCoreAsync_d__31>.NativeClassPtr))
			{
			}

			// Token: 0x1700017B RID: 379
			// (get) Token: 0x0600044C RID: 1100 RVA: 0x00013318 File Offset: 0x00011518
			// (set) Token: 0x0600044D RID: 1101 RVA: 0x0000470C File Offset: 0x0000290C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader._DownloadCoreAsync_d__31.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader._DownloadCoreAsync_d__31.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700017C RID: 380
			// (get) Token: 0x0600044E RID: 1102 RVA: 0x00013340 File Offset: 0x00011540
			// (set) Token: 0x0600044F RID: 1103 RVA: 0x00004727 File Offset: 0x00002927
			public AsyncTaskMethodBuilder<IDownloadProgress> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader._DownloadCoreAsync_d__31.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<IDownloadProgress>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<IDownloadProgress>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader._DownloadCoreAsync_d__31.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<IDownloadProgress>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700017D RID: 381
			// (get) Token: 0x06000450 RID: 1104 RVA: 0x00013370 File Offset: 0x00011570
			// (set) Token: 0x06000451 RID: 1105 RVA: 0x00004755 File Offset: 0x00002955
			public unsafe string url
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader._DownloadCoreAsync_d__31.NativeFieldInfoPtr_url);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader._DownloadCoreAsync_d__31.NativeFieldInfoPtr_url), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700017E RID: 382
			// (get) Token: 0x06000452 RID: 1106 RVA: 0x00013398 File Offset: 0x00011598
			// (set) Token: 0x06000453 RID: 1107 RVA: 0x00004774 File Offset: 0x00002974
			public unsafe Stream stream
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader._DownloadCoreAsync_d__31.NativeFieldInfoPtr_stream);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader._DownloadCoreAsync_d__31.NativeFieldInfoPtr_stream), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700017F RID: 383
			// (get) Token: 0x06000454 RID: 1108 RVA: 0x000133C8 File Offset: 0x000115C8
			// (set) Token: 0x06000455 RID: 1109 RVA: 0x00004793 File Offset: 0x00002993
			public unsafe MediaDownloader __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader._DownloadCoreAsync_d__31.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MediaDownloader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader._DownloadCoreAsync_d__31.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000180 RID: 384
			// (get) Token: 0x06000456 RID: 1110 RVA: 0x000133F8 File Offset: 0x000115F8
			// (set) Token: 0x06000457 RID: 1111 RVA: 0x000047B2 File Offset: 0x000029B2
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader._DownloadCoreAsync_d__31.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader._DownloadCoreAsync_d__31.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000181 RID: 385
			// (get) Token: 0x06000458 RID: 1112 RVA: 0x00013428 File Offset: 0x00011628
			// (set) Token: 0x06000459 RID: 1113 RVA: 0x000047E0 File Offset: 0x000029E0
			public unsafe long _bytesReturned_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader._DownloadCoreAsync_d__31.NativeFieldInfoPtr__bytesReturned_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader._DownloadCoreAsync_d__31.NativeFieldInfoPtr__bytesReturned_5__2)) = value;
				}
			}

			// Token: 0x17000182 RID: 386
			// (get) Token: 0x0600045A RID: 1114 RVA: 0x00013450 File Offset: 0x00011650
			// (set) Token: 0x0600045B RID: 1115 RVA: 0x000047FB File Offset: 0x000029FB
			public unsafe HttpResponseMessage _response_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader._DownloadCoreAsync_d__31.NativeFieldInfoPtr__response_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpResponseMessage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader._DownloadCoreAsync_d__31.NativeFieldInfoPtr__response_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000183 RID: 387
			// (get) Token: 0x0600045C RID: 1116 RVA: 0x00013480 File Offset: 0x00011680
			// (set) Token: 0x0600045D RID: 1117 RVA: 0x0000481A File Offset: 0x00002A1A
			public ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader._DownloadCoreAsync_d__31.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader._DownloadCoreAsync_d__31.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000184 RID: 388
			// (get) Token: 0x0600045E RID: 1118 RVA: 0x000134B0 File Offset: 0x000116B0
			// (set) Token: 0x0600045F RID: 1119 RVA: 0x00004848 File Offset: 0x00002A48
			public ConfiguredTaskAwaitable<GoogleApiException>.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader._DownloadCoreAsync_d__31.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable<GoogleApiException>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<GoogleApiException>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader._DownloadCoreAsync_d__31.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<GoogleApiException>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000185 RID: 389
			// (get) Token: 0x06000460 RID: 1120 RVA: 0x000134E0 File Offset: 0x000116E0
			// (set) Token: 0x06000461 RID: 1121 RVA: 0x00004876 File Offset: 0x00002A76
			public unsafe Stream _responseStream_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader._DownloadCoreAsync_d__31.NativeFieldInfoPtr__responseStream_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader._DownloadCoreAsync_d__31.NativeFieldInfoPtr__responseStream_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000186 RID: 390
			// (get) Token: 0x06000462 RID: 1122 RVA: 0x00013510 File Offset: 0x00011710
			// (set) Token: 0x06000463 RID: 1123 RVA: 0x00004895 File Offset: 0x00002A95
			public ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter __u__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader._DownloadCoreAsync_d__31.NativeFieldInfoPtr___u__3);
					return new ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader._DownloadCoreAsync_d__31.NativeFieldInfoPtr___u__3), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000187 RID: 391
			// (get) Token: 0x06000464 RID: 1124 RVA: 0x00013540 File Offset: 0x00011740
			// (set) Token: 0x06000465 RID: 1125 RVA: 0x000048C3 File Offset: 0x00002AC3
			public unsafe MediaDownloader.CountedBuffer _buffer_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader._DownloadCoreAsync_d__31.NativeFieldInfoPtr__buffer_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MediaDownloader.CountedBuffer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader._DownloadCoreAsync_d__31.NativeFieldInfoPtr__buffer_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000188 RID: 392
			// (get) Token: 0x06000466 RID: 1126 RVA: 0x00013570 File Offset: 0x00011770
			// (set) Token: 0x06000467 RID: 1127 RVA: 0x000048E2 File Offset: 0x00002AE2
			public unsafe int _bytesToReturn_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader._DownloadCoreAsync_d__31.NativeFieldInfoPtr__bytesToReturn_5__6);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader._DownloadCoreAsync_d__31.NativeFieldInfoPtr__bytesToReturn_5__6)) = value;
				}
			}

			// Token: 0x17000189 RID: 393
			// (get) Token: 0x06000468 RID: 1128 RVA: 0x00013598 File Offset: 0x00011798
			// (set) Token: 0x06000469 RID: 1129 RVA: 0x000048FD File Offset: 0x00002AFD
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader._DownloadCoreAsync_d__31.NativeFieldInfoPtr___u__4);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaDownloader._DownloadCoreAsync_d__31.NativeFieldInfoPtr___u__4), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040002AC RID: 684
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040002AD RID: 685
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040002AE RID: 686
			private static readonly IntPtr NativeFieldInfoPtr_url;

			// Token: 0x040002AF RID: 687
			private static readonly IntPtr NativeFieldInfoPtr_stream;

			// Token: 0x040002B0 RID: 688
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040002B1 RID: 689
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x040002B2 RID: 690
			private static readonly IntPtr NativeFieldInfoPtr__bytesReturned_5__2;

			// Token: 0x040002B3 RID: 691
			private static readonly IntPtr NativeFieldInfoPtr__response_5__3;

			// Token: 0x040002B4 RID: 692
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040002B5 RID: 693
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x040002B6 RID: 694
			private static readonly IntPtr NativeFieldInfoPtr__responseStream_5__4;

			// Token: 0x040002B7 RID: 695
			private static readonly IntPtr NativeFieldInfoPtr___u__3;

			// Token: 0x040002B8 RID: 696
			private static readonly IntPtr NativeFieldInfoPtr__buffer_5__5;

			// Token: 0x040002B9 RID: 697
			private static readonly IntPtr NativeFieldInfoPtr__bytesToReturn_5__6;

			// Token: 0x040002BA RID: 698
			private static readonly IntPtr NativeFieldInfoPtr___u__4;

			// Token: 0x040002BB RID: 699
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040002BC RID: 700
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
