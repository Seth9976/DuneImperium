using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.IO;
using Il2CppSystem.Net.Http;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Google.Apis.Http
{
	// Token: 0x02000037 RID: 55
	public sealed class StreamInterceptionHandler : DelegatingHandler
	{
		// Token: 0x06000268 RID: 616 RVA: 0x0000CD90 File Offset: 0x0000AF90
		// Note: this type is marked as 'beforefieldinit'.
		static StreamInterceptionHandler()
		{
			Il2CppClassPointerStore<StreamInterceptionHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Core.dll", "Google.Apis.Http", "StreamInterceptionHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StreamInterceptionHandler>.NativeClassPtr);
			StreamInterceptionHandler.NativeMethodInfoPtr__ctor_Internal_Void_HttpMessageHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamInterceptionHandler>.NativeClassPtr, 100663660);
			StreamInterceptionHandler.NativeMethodInfoPtr_SendAsync_Protected_Virtual_Task_1_HttpResponseMessage_HttpRequestMessage_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamInterceptionHandler>.NativeClassPtr, 100663661);
			StreamInterceptionHandler.NativeMethodInfoPtr_ReplaceAsync_Private_Task_1_HttpResponseMessage_Task_1_HttpResponseMessage_Func_2_HttpResponseMessage_StreamInterceptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamInterceptionHandler>.NativeClassPtr, 100663662);
			StreamInterceptionHandler.NativeMethodInfoPtr_GetInterceptorProvider_Internal_Static_Func_2_HttpResponseMessage_StreamInterceptor_HttpRequestMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamInterceptionHandler>.NativeClassPtr, 100663663);
		}

		// Token: 0x06000269 RID: 617 RVA: 0x0000CE10 File Offset: 0x0000B010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1212605, XrefRangeEnd = 1212606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StreamInterceptionHandler(HttpMessageHandler handler)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamInterceptionHandler>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamInterceptionHandler.NativeMethodInfoPtr__ctor_Internal_Void_HttpMessageHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600026A RID: 618 RVA: 0x0000CE5C File Offset: 0x0000B05C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1212606, XrefRangeEnd = 1212624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamInterceptionHandler.NativeMethodInfoPtr_SendAsync_Protected_Virtual_Task_1_HttpResponseMessage_HttpRequestMessage_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<HttpResponseMessage>>(intPtr3) : null;
		}

		// Token: 0x0600026B RID: 619 RVA: 0x0000CEC4 File Offset: 0x0000B0C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1212624, XrefRangeEnd = 1212639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<HttpResponseMessage> ReplaceAsync(Task<HttpResponseMessage> responseTask, Func<HttpResponseMessage, StreamInterceptor> interceptorProvider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(responseTask);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(interceptorProvider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamInterceptionHandler.NativeMethodInfoPtr_ReplaceAsync_Private_Task_1_HttpResponseMessage_Task_1_HttpResponseMessage_Func_2_HttpResponseMessage_StreamInterceptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<HttpResponseMessage>>(intPtr3) : null;
		}

		// Token: 0x0600026C RID: 620 RVA: 0x0000CF28 File Offset: 0x0000B128
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1212648, RefRangeEnd = 1212650, XrefRangeStart = 1212639, XrefRangeEnd = 1212648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Func<HttpResponseMessage, StreamInterceptor> GetInterceptorProvider(HttpRequestMessage request)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamInterceptionHandler.NativeMethodInfoPtr_GetInterceptorProvider_Internal_Static_Func_2_HttpResponseMessage_StreamInterceptor_HttpRequestMessage_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<HttpResponseMessage, StreamInterceptor>>(intPtr3) : null;
			}
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00002FC0 File Offset: 0x000011C0
		public StreamInterceptionHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000199 RID: 409
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_HttpMessageHandler_0;

		// Token: 0x0400019A RID: 410
		private static readonly IntPtr NativeMethodInfoPtr_SendAsync_Protected_Virtual_Task_1_HttpResponseMessage_HttpRequestMessage_CancellationToken_0;

		// Token: 0x0400019B RID: 411
		private static readonly IntPtr NativeMethodInfoPtr_ReplaceAsync_Private_Task_1_HttpResponseMessage_Task_1_HttpResponseMessage_Func_2_HttpResponseMessage_StreamInterceptor_0;

		// Token: 0x0400019C RID: 412
		private static readonly IntPtr NativeMethodInfoPtr_GetInterceptorProvider_Internal_Static_Func_2_HttpResponseMessage_StreamInterceptor_HttpRequestMessage_0;

		// Token: 0x0200005F RID: 95
		public sealed class InterceptingStream : Stream
		{
			// Token: 0x060003B0 RID: 944 RVA: 0x00010C30 File Offset: 0x0000EE30
			// Note: this type is marked as 'beforefieldinit'.
			static InterceptingStream()
			{
				Il2CppClassPointerStore<StreamInterceptionHandler.InterceptingStream>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StreamInterceptionHandler>.NativeClassPtr, "InterceptingStream");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StreamInterceptionHandler.InterceptingStream>.NativeClassPtr);
				StreamInterceptionHandler.InterceptingStream.NativeFieldInfoPtr__original = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamInterceptionHandler.InterceptingStream>.NativeClassPtr, "_original");
				StreamInterceptionHandler.InterceptingStream.NativeFieldInfoPtr__interceptor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamInterceptionHandler.InterceptingStream>.NativeClassPtr, "_interceptor");
				StreamInterceptionHandler.InterceptingStream.NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamInterceptionHandler.InterceptingStream>.NativeClassPtr, 100663664);
				StreamInterceptionHandler.InterceptingStream.NativeMethodInfoPtr_get_CanSeek_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamInterceptionHandler.InterceptingStream>.NativeClassPtr, 100663665);
				StreamInterceptionHandler.InterceptingStream.NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamInterceptionHandler.InterceptingStream>.NativeClassPtr, 100663666);
				StreamInterceptionHandler.InterceptingStream.NativeMethodInfoPtr_get_Length_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamInterceptionHandler.InterceptingStream>.NativeClassPtr, 100663667);
				StreamInterceptionHandler.InterceptingStream.NativeMethodInfoPtr_get_Position_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamInterceptionHandler.InterceptingStream>.NativeClassPtr, 100663668);
				StreamInterceptionHandler.InterceptingStream.NativeMethodInfoPtr_set_Position_Public_Virtual_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamInterceptionHandler.InterceptingStream>.NativeClassPtr, 100663669);
				StreamInterceptionHandler.InterceptingStream.NativeMethodInfoPtr__ctor_Internal_Void_Stream_StreamInterceptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamInterceptionHandler.InterceptingStream>.NativeClassPtr, 100663670);
				StreamInterceptionHandler.InterceptingStream.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamInterceptionHandler.InterceptingStream>.NativeClassPtr, 100663671);
				StreamInterceptionHandler.InterceptingStream.NativeMethodInfoPtr_ReadAsync_Public_Virtual_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamInterceptionHandler.InterceptingStream>.NativeClassPtr, 100663672);
				StreamInterceptionHandler.InterceptingStream.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamInterceptionHandler.InterceptingStream>.NativeClassPtr, 100663673);
				StreamInterceptionHandler.InterceptingStream.NativeMethodInfoPtr_Flush_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamInterceptionHandler.InterceptingStream>.NativeClassPtr, 100663674);
				StreamInterceptionHandler.InterceptingStream.NativeMethodInfoPtr_Seek_Public_Virtual_Int64_Int64_SeekOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamInterceptionHandler.InterceptingStream>.NativeClassPtr, 100663675);
				StreamInterceptionHandler.InterceptingStream.NativeMethodInfoPtr_SetLength_Public_Virtual_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamInterceptionHandler.InterceptingStream>.NativeClassPtr, 100663676);
				StreamInterceptionHandler.InterceptingStream.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamInterceptionHandler.InterceptingStream>.NativeClassPtr, 100663677);
			}

			// Token: 0x17000125 RID: 293
			// (get) Token: 0x060003B1 RID: 945 RVA: 0x00010D9C File Offset: 0x0000EF9C
			public unsafe override bool CanRead
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamInterceptionHandler.InterceptingStream.NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000126 RID: 294
			// (get) Token: 0x060003B2 RID: 946 RVA: 0x00010DD8 File Offset: 0x0000EFD8
			public unsafe override bool CanSeek
			{
				[CallerCount(184)]
				[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamInterceptionHandler.InterceptingStream.NativeMethodInfoPtr_get_CanSeek_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000127 RID: 295
			// (get) Token: 0x060003B3 RID: 947 RVA: 0x00010E14 File Offset: 0x0000F014
			public unsafe override bool CanWrite
			{
				[CallerCount(184)]
				[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamInterceptionHandler.InterceptingStream.NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000128 RID: 296
			// (get) Token: 0x060003B4 RID: 948 RVA: 0x00010E50 File Offset: 0x0000F050
			public unsafe override long Length
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamInterceptionHandler.InterceptingStream.NativeMethodInfoPtr_get_Length_Public_Virtual_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000129 RID: 297
			// (get) Token: 0x060003B5 RID: 949 RVA: 0x00010E8C File Offset: 0x0000F08C
			// (set) Token: 0x060003B6 RID: 950 RVA: 0x00010EC8 File Offset: 0x0000F0C8
			public unsafe override long Position
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamInterceptionHandler.InterceptingStream.NativeMethodInfoPtr_get_Position_Public_Virtual_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1212511, XrefRangeEnd = 1212516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamInterceptionHandler.InterceptingStream.NativeMethodInfoPtr_set_Position_Public_Virtual_set_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x060003B7 RID: 951 RVA: 0x00010F08 File Offset: 0x0000F108
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1212516, XrefRangeEnd = 1212522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InterceptingStream(Stream original, StreamInterceptor interceptor)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamInterceptionHandler.InterceptingStream>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(original);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(interceptor);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamInterceptionHandler.InterceptingStream.NativeMethodInfoPtr__ctor_Internal_Void_Stream_StreamInterceptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003B8 RID: 952 RVA: 0x00010F68 File Offset: 0x0000F168
			[CallerCount(0)]
			public unsafe override int Read(Il2CppStructArray<byte> buffer, int offset, int count)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamInterceptionHandler.InterceptingStream.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060003B9 RID: 953 RVA: 0x00010FD4 File Offset: 0x0000F1D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1212522, XrefRangeEnd = 1212538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamInterceptionHandler.InterceptingStream.NativeMethodInfoPtr_ReadAsync_Public_Virtual_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<int>>(intPtr3) : null;
			}

			// Token: 0x060003BA RID: 954 RVA: 0x00011058 File Offset: 0x0000F258
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1212538, XrefRangeEnd = 1212540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Dispose(bool disposing)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref disposing;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamInterceptionHandler.InterceptingStream.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060003BB RID: 955 RVA: 0x00011098 File Offset: 0x0000F298
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Flush()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamInterceptionHandler.InterceptingStream.NativeMethodInfoPtr_Flush_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003BC RID: 956 RVA: 0x000110CC File Offset: 0x0000F2CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1212540, XrefRangeEnd = 1212545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamInterceptionHandler.InterceptingStream.NativeMethodInfoPtr_Seek_Public_Virtual_Int64_Int64_SeekOrigin_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060003BD RID: 957 RVA: 0x00011124 File Offset: 0x0000F324
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1212545, XrefRangeEnd = 1212550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void SetLength(long value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamInterceptionHandler.InterceptingStream.NativeMethodInfoPtr_SetLength_Public_Virtual_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060003BE RID: 958 RVA: 0x00011164 File Offset: 0x0000F364
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1212550, XrefRangeEnd = 1212555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Write(Il2CppStructArray<byte> buffer, int offset, int count)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamInterceptionHandler.InterceptingStream.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003BF RID: 959 RVA: 0x00003C07 File Offset: 0x00001E07
			public InterceptingStream(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000123 RID: 291
			// (get) Token: 0x060003C0 RID: 960 RVA: 0x000111C4 File Offset: 0x0000F3C4
			// (set) Token: 0x060003C1 RID: 961 RVA: 0x00003C10 File Offset: 0x00001E10
			public unsafe Stream _original
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamInterceptionHandler.InterceptingStream.NativeFieldInfoPtr__original);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamInterceptionHandler.InterceptingStream.NativeFieldInfoPtr__original), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000124 RID: 292
			// (get) Token: 0x060003C2 RID: 962 RVA: 0x000111F4 File Offset: 0x0000F3F4
			// (set) Token: 0x060003C3 RID: 963 RVA: 0x00003C2F File Offset: 0x00001E2F
			public unsafe StreamInterceptor _interceptor
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamInterceptionHandler.InterceptingStream.NativeFieldInfoPtr__interceptor);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StreamInterceptor>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamInterceptionHandler.InterceptingStream.NativeFieldInfoPtr__interceptor), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000266 RID: 614
			private static readonly IntPtr NativeFieldInfoPtr__original;

			// Token: 0x04000267 RID: 615
			private static readonly IntPtr NativeFieldInfoPtr__interceptor;

			// Token: 0x04000268 RID: 616
			private static readonly IntPtr NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0;

			// Token: 0x04000269 RID: 617
			private static readonly IntPtr NativeMethodInfoPtr_get_CanSeek_Public_Virtual_get_Boolean_0;

			// Token: 0x0400026A RID: 618
			private static readonly IntPtr NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0;

			// Token: 0x0400026B RID: 619
			private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_Virtual_get_Int64_0;

			// Token: 0x0400026C RID: 620
			private static readonly IntPtr NativeMethodInfoPtr_get_Position_Public_Virtual_get_Int64_0;

			// Token: 0x0400026D RID: 621
			private static readonly IntPtr NativeMethodInfoPtr_set_Position_Public_Virtual_set_Void_Int64_0;

			// Token: 0x0400026E RID: 622
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Stream_StreamInterceptor_0;

			// Token: 0x0400026F RID: 623
			private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

			// Token: 0x04000270 RID: 624
			private static readonly IntPtr NativeMethodInfoPtr_ReadAsync_Public_Virtual_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0;

			// Token: 0x04000271 RID: 625
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

			// Token: 0x04000272 RID: 626
			private static readonly IntPtr NativeMethodInfoPtr_Flush_Public_Virtual_Void_0;

			// Token: 0x04000273 RID: 627
			private static readonly IntPtr NativeMethodInfoPtr_Seek_Public_Virtual_Int64_Int64_SeekOrigin_0;

			// Token: 0x04000274 RID: 628
			private static readonly IntPtr NativeMethodInfoPtr_SetLength_Public_Virtual_Void_Int64_0;

			// Token: 0x04000275 RID: 629
			private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

			// Token: 0x02000068 RID: 104
			[ObfuscatedName("Google.Apis.Http.StreamInterceptionHandler+InterceptingStream+<ReadAsync>d__15")]
			public sealed class _ReadAsync_d__15 : ValueType
			{
				// Token: 0x0600041E RID: 1054 RVA: 0x0001209C File Offset: 0x0001029C
				// Note: this type is marked as 'beforefieldinit'.
				static _ReadAsync_d__15()
				{
					Il2CppClassPointerStore<StreamInterceptionHandler.InterceptingStream._ReadAsync_d__15>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StreamInterceptionHandler.InterceptingStream>.NativeClassPtr, "<ReadAsync>d__15");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StreamInterceptionHandler.InterceptingStream._ReadAsync_d__15>.NativeClassPtr);
					StreamInterceptionHandler.InterceptingStream._ReadAsync_d__15.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamInterceptionHandler.InterceptingStream._ReadAsync_d__15>.NativeClassPtr, "<>1__state");
					StreamInterceptionHandler.InterceptingStream._ReadAsync_d__15.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamInterceptionHandler.InterceptingStream._ReadAsync_d__15>.NativeClassPtr, "<>t__builder");
					StreamInterceptionHandler.InterceptingStream._ReadAsync_d__15.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamInterceptionHandler.InterceptingStream._ReadAsync_d__15>.NativeClassPtr, "<>4__this");
					StreamInterceptionHandler.InterceptingStream._ReadAsync_d__15.NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamInterceptionHandler.InterceptingStream._ReadAsync_d__15>.NativeClassPtr, "buffer");
					StreamInterceptionHandler.InterceptingStream._ReadAsync_d__15.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamInterceptionHandler.InterceptingStream._ReadAsync_d__15>.NativeClassPtr, "offset");
					StreamInterceptionHandler.InterceptingStream._ReadAsync_d__15.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamInterceptionHandler.InterceptingStream._ReadAsync_d__15>.NativeClassPtr, "count");
					StreamInterceptionHandler.InterceptingStream._ReadAsync_d__15.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamInterceptionHandler.InterceptingStream._ReadAsync_d__15>.NativeClassPtr, "cancellationToken");
					StreamInterceptionHandler.InterceptingStream._ReadAsync_d__15.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamInterceptionHandler.InterceptingStream._ReadAsync_d__15>.NativeClassPtr, "<>u__1");
					StreamInterceptionHandler.InterceptingStream._ReadAsync_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamInterceptionHandler.InterceptingStream._ReadAsync_d__15>.NativeClassPtr, 100663678);
					StreamInterceptionHandler.InterceptingStream._ReadAsync_d__15.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamInterceptionHandler.InterceptingStream._ReadAsync_d__15>.NativeClassPtr, 100663679);
				}

				// Token: 0x0600041F RID: 1055 RVA: 0x00012190 File Offset: 0x00010390
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1212487, XrefRangeEnd = 1212505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamInterceptionHandler.InterceptingStream._ReadAsync_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06000420 RID: 1056 RVA: 0x000121C8 File Offset: 0x000103C8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1212505, XrefRangeEnd = 1212511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamInterceptionHandler.InterceptingStream._ReadAsync_d__15.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06000421 RID: 1057 RVA: 0x00004070 File Offset: 0x00002270
				public _ReadAsync_d__15(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06000422 RID: 1058 RVA: 0x00004079 File Offset: 0x00002279
				public _ReadAsync_d__15()
					: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamInterceptionHandler.InterceptingStream._ReadAsync_d__15>.NativeClassPtr))
				{
				}

				// Token: 0x17000144 RID: 324
				// (get) Token: 0x06000423 RID: 1059 RVA: 0x00012210 File Offset: 0x00010410
				// (set) Token: 0x06000424 RID: 1060 RVA: 0x0000408B File Offset: 0x0000228B
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamInterceptionHandler.InterceptingStream._ReadAsync_d__15.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamInterceptionHandler.InterceptingStream._ReadAsync_d__15.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17000145 RID: 325
				// (get) Token: 0x06000425 RID: 1061 RVA: 0x00012238 File Offset: 0x00010438
				// (set) Token: 0x06000426 RID: 1062 RVA: 0x000040A6 File Offset: 0x000022A6
				public AsyncTaskMethodBuilder<int> __t__builder
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamInterceptionHandler.InterceptingStream._ReadAsync_d__15.NativeFieldInfoPtr___t__builder);
						return new AsyncTaskMethodBuilder<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<int>>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamInterceptionHandler.InterceptingStream._ReadAsync_d__15.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<int>>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x17000146 RID: 326
				// (get) Token: 0x06000427 RID: 1063 RVA: 0x00012268 File Offset: 0x00010468
				// (set) Token: 0x06000428 RID: 1064 RVA: 0x000040D4 File Offset: 0x000022D4
				public unsafe StreamInterceptionHandler.InterceptingStream __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamInterceptionHandler.InterceptingStream._ReadAsync_d__15.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<StreamInterceptionHandler.InterceptingStream>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamInterceptionHandler.InterceptingStream._ReadAsync_d__15.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000147 RID: 327
				// (get) Token: 0x06000429 RID: 1065 RVA: 0x00012298 File Offset: 0x00010498
				// (set) Token: 0x0600042A RID: 1066 RVA: 0x000040F3 File Offset: 0x000022F3
				public unsafe Il2CppStructArray<byte> buffer
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamInterceptionHandler.InterceptingStream._ReadAsync_d__15.NativeFieldInfoPtr_buffer);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamInterceptionHandler.InterceptingStream._ReadAsync_d__15.NativeFieldInfoPtr_buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000148 RID: 328
				// (get) Token: 0x0600042B RID: 1067 RVA: 0x000122C8 File Offset: 0x000104C8
				// (set) Token: 0x0600042C RID: 1068 RVA: 0x00004112 File Offset: 0x00002312
				public unsafe int offset
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamInterceptionHandler.InterceptingStream._ReadAsync_d__15.NativeFieldInfoPtr_offset);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamInterceptionHandler.InterceptingStream._ReadAsync_d__15.NativeFieldInfoPtr_offset)) = value;
					}
				}

				// Token: 0x17000149 RID: 329
				// (get) Token: 0x0600042D RID: 1069 RVA: 0x000122F0 File Offset: 0x000104F0
				// (set) Token: 0x0600042E RID: 1070 RVA: 0x0000412D File Offset: 0x0000232D
				public unsafe int count
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamInterceptionHandler.InterceptingStream._ReadAsync_d__15.NativeFieldInfoPtr_count);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamInterceptionHandler.InterceptingStream._ReadAsync_d__15.NativeFieldInfoPtr_count)) = value;
					}
				}

				// Token: 0x1700014A RID: 330
				// (get) Token: 0x0600042F RID: 1071 RVA: 0x00012318 File Offset: 0x00010518
				// (set) Token: 0x06000430 RID: 1072 RVA: 0x00004148 File Offset: 0x00002348
				public CancellationToken cancellationToken
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamInterceptionHandler.InterceptingStream._ReadAsync_d__15.NativeFieldInfoPtr_cancellationToken);
						return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamInterceptionHandler.InterceptingStream._ReadAsync_d__15.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x1700014B RID: 331
				// (get) Token: 0x06000431 RID: 1073 RVA: 0x00012348 File Offset: 0x00010548
				// (set) Token: 0x06000432 RID: 1074 RVA: 0x00004176 File Offset: 0x00002376
				public ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter __u__1
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamInterceptionHandler.InterceptingStream._ReadAsync_d__15.NativeFieldInfoPtr___u__1);
						return new ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamInterceptionHandler.InterceptingStream._ReadAsync_d__15.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x040002A2 RID: 674
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x040002A3 RID: 675
				private static readonly IntPtr NativeFieldInfoPtr___t__builder;

				// Token: 0x040002A4 RID: 676
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x040002A5 RID: 677
				private static readonly IntPtr NativeFieldInfoPtr_buffer;

				// Token: 0x040002A6 RID: 678
				private static readonly IntPtr NativeFieldInfoPtr_offset;

				// Token: 0x040002A7 RID: 679
				private static readonly IntPtr NativeFieldInfoPtr_count;

				// Token: 0x040002A8 RID: 680
				private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

				// Token: 0x040002A9 RID: 681
				private static readonly IntPtr NativeFieldInfoPtr___u__1;

				// Token: 0x040002AA RID: 682
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

				// Token: 0x040002AB RID: 683
				private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
			}
		}

		// Token: 0x02000060 RID: 96
		[ObfuscatedName("Google.Apis.Http.StreamInterceptionHandler+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Object
		{
			// Token: 0x060003C4 RID: 964 RVA: 0x00011224 File Offset: 0x0000F424
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<StreamInterceptionHandler.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StreamInterceptionHandler>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StreamInterceptionHandler.__c__DisplayClass2_0>.NativeClassPtr);
				StreamInterceptionHandler.__c__DisplayClass2_0.NativeFieldInfoPtr_interceptor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamInterceptionHandler.__c__DisplayClass2_0>.NativeClassPtr, "interceptor");
				StreamInterceptionHandler.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamInterceptionHandler.__c__DisplayClass2_0>.NativeClassPtr, 100663680);
				StreamInterceptionHandler.__c__DisplayClass2_0.NativeMethodInfoPtr__ReplaceAsync_b__0_Internal_Stream_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamInterceptionHandler.__c__DisplayClass2_0>.NativeClassPtr, 100663681);
			}

			// Token: 0x060003C5 RID: 965 RVA: 0x0001128C File Offset: 0x0000F48C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamInterceptionHandler.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamInterceptionHandler.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003C6 RID: 966 RVA: 0x000112C8 File Offset: 0x0000F4C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1212555, XrefRangeEnd = 1212564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Stream _ReplaceAsync_b__0(Stream stream)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamInterceptionHandler.__c__DisplayClass2_0.NativeMethodInfoPtr__ReplaceAsync_b__0_Internal_Stream_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
				}
			}

			// Token: 0x060003C7 RID: 967 RVA: 0x00003C4E File Offset: 0x00001E4E
			public __c__DisplayClass2_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700012A RID: 298
			// (get) Token: 0x060003C8 RID: 968 RVA: 0x00011318 File Offset: 0x0000F518
			// (set) Token: 0x060003C9 RID: 969 RVA: 0x00003C57 File Offset: 0x00001E57
			public unsafe StreamInterceptor interceptor
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamInterceptionHandler.__c__DisplayClass2_0.NativeFieldInfoPtr_interceptor);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StreamInterceptor>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamInterceptionHandler.__c__DisplayClass2_0.NativeFieldInfoPtr_interceptor), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000276 RID: 630
			private static readonly IntPtr NativeFieldInfoPtr_interceptor;

			// Token: 0x04000277 RID: 631
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000278 RID: 632
			private static readonly IntPtr NativeMethodInfoPtr__ReplaceAsync_b__0_Internal_Stream_Stream_0;
		}

		// Token: 0x02000061 RID: 97
		[ObfuscatedName("Google.Apis.Http.StreamInterceptionHandler+<ReplaceAsync>d__2")]
		public sealed class _ReplaceAsync_d__2 : ValueType
		{
			// Token: 0x060003CA RID: 970 RVA: 0x00011348 File Offset: 0x0000F548
			// Note: this type is marked as 'beforefieldinit'.
			static _ReplaceAsync_d__2()
			{
				Il2CppClassPointerStore<StreamInterceptionHandler._ReplaceAsync_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StreamInterceptionHandler>.NativeClassPtr, "<ReplaceAsync>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StreamInterceptionHandler._ReplaceAsync_d__2>.NativeClassPtr);
				StreamInterceptionHandler._ReplaceAsync_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamInterceptionHandler._ReplaceAsync_d__2>.NativeClassPtr, "<>1__state");
				StreamInterceptionHandler._ReplaceAsync_d__2.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamInterceptionHandler._ReplaceAsync_d__2>.NativeClassPtr, "<>t__builder");
				StreamInterceptionHandler._ReplaceAsync_d__2.NativeFieldInfoPtr_responseTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamInterceptionHandler._ReplaceAsync_d__2>.NativeClassPtr, "responseTask");
				StreamInterceptionHandler._ReplaceAsync_d__2.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamInterceptionHandler._ReplaceAsync_d__2>.NativeClassPtr, "<>8__1");
				StreamInterceptionHandler._ReplaceAsync_d__2.NativeFieldInfoPtr_interceptorProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamInterceptionHandler._ReplaceAsync_d__2>.NativeClassPtr, "interceptorProvider");
				StreamInterceptionHandler._ReplaceAsync_d__2.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamInterceptionHandler._ReplaceAsync_d__2>.NativeClassPtr, "<>u__1");
				StreamInterceptionHandler._ReplaceAsync_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamInterceptionHandler._ReplaceAsync_d__2>.NativeClassPtr, 100663682);
				StreamInterceptionHandler._ReplaceAsync_d__2.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamInterceptionHandler._ReplaceAsync_d__2>.NativeClassPtr, 100663683);
			}

			// Token: 0x060003CB RID: 971 RVA: 0x00011414 File Offset: 0x0000F614
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1212564, XrefRangeEnd = 1212599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamInterceptionHandler._ReplaceAsync_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003CC RID: 972 RVA: 0x0001144C File Offset: 0x0000F64C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1212599, XrefRangeEnd = 1212605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamInterceptionHandler._ReplaceAsync_d__2.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060003CD RID: 973 RVA: 0x00003C76 File Offset: 0x00001E76
			public _ReplaceAsync_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060003CE RID: 974 RVA: 0x00003C7F File Offset: 0x00001E7F
			public _ReplaceAsync_d__2()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamInterceptionHandler._ReplaceAsync_d__2>.NativeClassPtr))
			{
			}

			// Token: 0x1700012B RID: 299
			// (get) Token: 0x060003CF RID: 975 RVA: 0x00011494 File Offset: 0x0000F694
			// (set) Token: 0x060003D0 RID: 976 RVA: 0x00003C91 File Offset: 0x00001E91
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamInterceptionHandler._ReplaceAsync_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamInterceptionHandler._ReplaceAsync_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700012C RID: 300
			// (get) Token: 0x060003D1 RID: 977 RVA: 0x000114BC File Offset: 0x0000F6BC
			// (set) Token: 0x060003D2 RID: 978 RVA: 0x00003CAC File Offset: 0x00001EAC
			public AsyncTaskMethodBuilder<HttpResponseMessage> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamInterceptionHandler._ReplaceAsync_d__2.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<HttpResponseMessage>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<HttpResponseMessage>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamInterceptionHandler._ReplaceAsync_d__2.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<HttpResponseMessage>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700012D RID: 301
			// (get) Token: 0x060003D3 RID: 979 RVA: 0x000114EC File Offset: 0x0000F6EC
			// (set) Token: 0x060003D4 RID: 980 RVA: 0x00003CDA File Offset: 0x00001EDA
			public unsafe Task<HttpResponseMessage> responseTask
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamInterceptionHandler._ReplaceAsync_d__2.NativeFieldInfoPtr_responseTask);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task<HttpResponseMessage>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamInterceptionHandler._ReplaceAsync_d__2.NativeFieldInfoPtr_responseTask), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700012E RID: 302
			// (get) Token: 0x060003D5 RID: 981 RVA: 0x0001151C File Offset: 0x0000F71C
			// (set) Token: 0x060003D6 RID: 982 RVA: 0x00003CF9 File Offset: 0x00001EF9
			public unsafe StreamInterceptionHandler.__c__DisplayClass2_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamInterceptionHandler._ReplaceAsync_d__2.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StreamInterceptionHandler.__c__DisplayClass2_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamInterceptionHandler._ReplaceAsync_d__2.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700012F RID: 303
			// (get) Token: 0x060003D7 RID: 983 RVA: 0x0001154C File Offset: 0x0000F74C
			// (set) Token: 0x060003D8 RID: 984 RVA: 0x00003D18 File Offset: 0x00001F18
			public unsafe Func<HttpResponseMessage, StreamInterceptor> interceptorProvider
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamInterceptionHandler._ReplaceAsync_d__2.NativeFieldInfoPtr_interceptorProvider);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<HttpResponseMessage, StreamInterceptor>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamInterceptionHandler._ReplaceAsync_d__2.NativeFieldInfoPtr_interceptorProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000130 RID: 304
			// (get) Token: 0x060003D9 RID: 985 RVA: 0x0001157C File Offset: 0x0000F77C
			// (set) Token: 0x060003DA RID: 986 RVA: 0x00003D37 File Offset: 0x00001F37
			public ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamInterceptionHandler._ReplaceAsync_d__2.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamInterceptionHandler._ReplaceAsync_d__2.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04000279 RID: 633
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400027A RID: 634
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400027B RID: 635
			private static readonly IntPtr NativeFieldInfoPtr_responseTask;

			// Token: 0x0400027C RID: 636
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x0400027D RID: 637
			private static readonly IntPtr NativeFieldInfoPtr_interceptorProvider;

			// Token: 0x0400027E RID: 638
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400027F RID: 639
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000280 RID: 640
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
