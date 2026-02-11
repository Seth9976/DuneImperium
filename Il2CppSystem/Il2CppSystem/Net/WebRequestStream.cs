using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Net
{
	// Token: 0x02000217 RID: 535
	public class WebRequestStream : WebConnectionStream
	{
		// Token: 0x060023F5 RID: 9205 RVA: 0x000A6B58 File Offset: 0x000A4D58
		// Note: this type is marked as 'beforefieldinit'.
		static WebRequestStream()
		{
			Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "WebRequestStream");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr);
			WebRequestStream.NativeFieldInfoPtr_crlf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, "crlf");
			WebRequestStream.NativeFieldInfoPtr_writeBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, "writeBuffer");
			WebRequestStream.NativeFieldInfoPtr_requestWritten = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, "requestWritten");
			WebRequestStream.NativeFieldInfoPtr_allowBuffering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, "allowBuffering");
			WebRequestStream.NativeFieldInfoPtr_sendChunked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, "sendChunked");
			WebRequestStream.NativeFieldInfoPtr_pendingWrite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, "pendingWrite");
			WebRequestStream.NativeFieldInfoPtr_totalWritten = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, "totalWritten");
			WebRequestStream.NativeFieldInfoPtr_headers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, "headers");
			WebRequestStream.NativeFieldInfoPtr_headersSent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, "headersSent");
			WebRequestStream.NativeFieldInfoPtr_completeRequestWritten = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, "completeRequestWritten");
			WebRequestStream.NativeFieldInfoPtr_chunkTrailerWritten = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, "chunkTrailerWritten");
			WebRequestStream.NativeFieldInfoPtr__InnerStream_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, "<InnerStream>k__BackingField");
			WebRequestStream.NativeFieldInfoPtr__KeepAlive_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, "<KeepAlive>k__BackingField");
			WebRequestStream.NativeMethodInfoPtr__ctor_Public_Void_WebConnection_WebOperation_Stream_WebConnectionTunnel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, 100668650);
			WebRequestStream.NativeMethodInfoPtr_get_InnerStream_Internal_get_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, 100668651);
			WebRequestStream.NativeMethodInfoPtr_get_KeepAlive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, 100668652);
			WebRequestStream.NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, 100668653);
			WebRequestStream.NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, 100668654);
			WebRequestStream.NativeMethodInfoPtr_get_HasWriteBuffer_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, 100668655);
			WebRequestStream.NativeMethodInfoPtr_get_WriteBufferLength_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, 100668656);
			WebRequestStream.NativeMethodInfoPtr_GetWriteBuffer_Internal_BufferOffsetSize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, 100668657);
			WebRequestStream.NativeMethodInfoPtr_FinishWriting_Private_Task_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, 100668658);
			WebRequestStream.NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, 100668659);
			WebRequestStream.NativeMethodInfoPtr_WriteAsyncInner_Private_Task_Il2CppStructArray_1_Byte_Int32_Int32_WebCompletionSource_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, 100668660);
			WebRequestStream.NativeMethodInfoPtr_ProcessWrite_Private_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, 100668661);
			WebRequestStream.NativeMethodInfoPtr_CheckWriteOverflow_Private_Void_Int64_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, 100668662);
			WebRequestStream.NativeMethodInfoPtr_Initialize_Internal_Task_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, 100668663);
			WebRequestStream.NativeMethodInfoPtr_SetHeadersAsync_Private_Task_Boolean_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, 100668664);
			WebRequestStream.NativeMethodInfoPtr_WriteRequestAsync_Internal_Task_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, 100668665);
			WebRequestStream.NativeMethodInfoPtr_WriteChunkTrailer_inner_Private_Task_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, 100668666);
			WebRequestStream.NativeMethodInfoPtr_WriteChunkTrailer_Private_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, 100668667);
			WebRequestStream.NativeMethodInfoPtr_KillBuffer_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, 100668668);
			WebRequestStream.NativeMethodInfoPtr_ReadAsync_Public_Virtual_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, 100668669);
			WebRequestStream.NativeMethodInfoPtr_TryReadFromBufferedContent_Protected_Virtual_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, 100668670);
			WebRequestStream.NativeMethodInfoPtr_Close_internal_Protected_Virtual_Void_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, 100668671);
		}

		// Token: 0x060023F6 RID: 9206 RVA: 0x000A6E44 File Offset: 0x000A5044
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 486219, RefRangeEnd = 486220, XrefRangeStart = 486192, XrefRangeEnd = 486219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebRequestStream(WebConnection connection, WebOperation operation, Stream stream, WebConnectionTunnel tunnel)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(operation);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stream);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tunnel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream.NativeMethodInfoPtr__ctor_Public_Void_WebConnection_WebOperation_Stream_WebConnectionTunnel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000B70 RID: 2928
		// (get) Token: 0x060023F7 RID: 9207 RVA: 0x000A6EC8 File Offset: 0x000A50C8
		public unsafe Stream InnerStream
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 34751, RefRangeEnd = 34758, XrefRangeStart = 34751, XrefRangeEnd = 34758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream.NativeMethodInfoPtr_get_InnerStream_Internal_get_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
			}
		}

		// Token: 0x17000B71 RID: 2929
		// (get) Token: 0x060023F8 RID: 9208 RVA: 0x000A6F08 File Offset: 0x000A5108
		public unsafe bool KeepAlive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream.NativeMethodInfoPtr_get_KeepAlive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B72 RID: 2930
		// (get) Token: 0x060023F9 RID: 9209 RVA: 0x000A6F44 File Offset: 0x000A5144
		public unsafe override bool CanRead
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebRequestStream.NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B73 RID: 2931
		// (get) Token: 0x060023FA RID: 9210 RVA: 0x000A6F8C File Offset: 0x000A518C
		public unsafe override bool CanWrite
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebRequestStream.NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B74 RID: 2932
		// (get) Token: 0x060023FB RID: 9211 RVA: 0x000A6FD4 File Offset: 0x000A51D4
		public unsafe bool HasWriteBuffer
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 486220, RefRangeEnd = 486223, XrefRangeStart = 486220, XrefRangeEnd = 486220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream.NativeMethodInfoPtr_get_HasWriteBuffer_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B75 RID: 2933
		// (get) Token: 0x060023FC RID: 9212 RVA: 0x000A7010 File Offset: 0x000A5210
		public unsafe int WriteBufferLength
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 486223, RefRangeEnd = 486225, XrefRangeStart = 486223, XrefRangeEnd = 486223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream.NativeMethodInfoPtr_get_WriteBufferLength_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060023FD RID: 9213 RVA: 0x000A704C File Offset: 0x000A524C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 486229, RefRangeEnd = 486230, XrefRangeStart = 486225, XrefRangeEnd = 486229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BufferOffsetSize GetWriteBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream.NativeMethodInfoPtr_GetWriteBuffer_Internal_BufferOffsetSize_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BufferOffsetSize>(intPtr3) : null;
		}

		// Token: 0x060023FE RID: 9214 RVA: 0x000A708C File Offset: 0x000A528C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 486241, RefRangeEnd = 486242, XrefRangeStart = 486230, XrefRangeEnd = 486241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task FinishWriting(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream.NativeMethodInfoPtr_FinishWriting_Private_Task_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x060023FF RID: 9215 RVA: 0x000A70E4 File Offset: 0x000A52E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486242, XrefRangeEnd = 486268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebRequestStream.NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06002400 RID: 9216 RVA: 0x000A7174 File Offset: 0x000A5374
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486268, XrefRangeEnd = 486281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task WriteAsyncInner(Il2CppStructArray<byte> buffer, int offset, int size, WebCompletionSource completion, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(completion);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream.NativeMethodInfoPtr_WriteAsyncInner_Private_Task_Il2CppStructArray_1_Byte_Int32_Int32_WebCompletionSource_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06002401 RID: 9217 RVA: 0x000A720C File Offset: 0x000A540C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486281, XrefRangeEnd = 486293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task ProcessWrite(Il2CppStructArray<byte> buffer, int offset, int size, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream.NativeMethodInfoPtr_ProcessWrite_Private_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06002402 RID: 9218 RVA: 0x000A7290 File Offset: 0x000A5490
		[CallerCount(0)]
		public unsafe void CheckWriteOverflow(long contentLength, long totalWritten, long size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref contentLength;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref totalWritten;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream.NativeMethodInfoPtr_CheckWriteOverflow_Private_Void_Int64_Int64_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002403 RID: 9219 RVA: 0x000A72EC File Offset: 0x000A54EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486293, XrefRangeEnd = 486304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task Initialize(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream.NativeMethodInfoPtr_Initialize_Internal_Task_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x06002404 RID: 9220 RVA: 0x000A7344 File Offset: 0x000A5544
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 486315, RefRangeEnd = 486316, XrefRangeStart = 486304, XrefRangeEnd = 486315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task SetHeadersAsync(bool setInternalLength, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref setInternalLength;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream.NativeMethodInfoPtr_SetHeadersAsync_Private_Task_Boolean_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06002405 RID: 9221 RVA: 0x000A73A8 File Offset: 0x000A55A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 486327, RefRangeEnd = 486328, XrefRangeStart = 486316, XrefRangeEnd = 486327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task WriteRequestAsync(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream.NativeMethodInfoPtr_WriteRequestAsync_Internal_Task_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x06002406 RID: 9222 RVA: 0x000A7400 File Offset: 0x000A5600
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 486339, RefRangeEnd = 486340, XrefRangeStart = 486328, XrefRangeEnd = 486339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task WriteChunkTrailer_inner(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream.NativeMethodInfoPtr_WriteChunkTrailer_inner_Private_Task_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x06002407 RID: 9223 RVA: 0x000A7458 File Offset: 0x000A5658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486340, XrefRangeEnd = 486350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task WriteChunkTrailer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream.NativeMethodInfoPtr_WriteChunkTrailer_Private_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06002408 RID: 9224 RVA: 0x000A7498 File Offset: 0x000A5698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486350, XrefRangeEnd = 486351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void KillBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream.NativeMethodInfoPtr_KillBuffer_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002409 RID: 9225 RVA: 0x000A74CC File Offset: 0x000A56CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486351, XrefRangeEnd = 486363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Task<int> ReadAsync(Il2CppStructArray<byte> buffer, int offset, int size, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebRequestStream.NativeMethodInfoPtr_ReadAsync_Public_Virtual_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<int>>(intPtr3) : null;
		}

		// Token: 0x0600240A RID: 9226 RVA: 0x000A755C File Offset: 0x000A575C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486363, XrefRangeEnd = 486368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool TryReadFromBufferedContent(Il2CppStructArray<byte> buffer, int offset, int count, out int result)
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
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebRequestStream.NativeMethodInfoPtr_TryReadFromBufferedContent_Protected_Virtual_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_byref_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600240B RID: 9227 RVA: 0x000A75E0 File Offset: 0x000A57E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486368, XrefRangeEnd = 486372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Close_internal(ref bool disposed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &disposed;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebRequestStream.NativeMethodInfoPtr_Close_internal_Protected_Virtual_Void_byref_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600240C RID: 9228 RVA: 0x0000F885 File Offset: 0x0000DA85
		public WebRequestStream(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B63 RID: 2915
		// (get) Token: 0x0600240D RID: 9229 RVA: 0x000A762C File Offset: 0x000A582C
		// (set) Token: 0x0600240E RID: 9230 RVA: 0x0000F88E File Offset: 0x0000DA8E
		public unsafe static Il2CppStructArray<byte> crlf
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WebRequestStream.NativeFieldInfoPtr_crlf, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WebRequestStream.NativeFieldInfoPtr_crlf, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B64 RID: 2916
		// (get) Token: 0x0600240F RID: 9231 RVA: 0x000A7654 File Offset: 0x000A5854
		// (set) Token: 0x06002410 RID: 9232 RVA: 0x0000F8A0 File Offset: 0x0000DAA0
		public unsafe MemoryStream writeBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream.NativeFieldInfoPtr_writeBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MemoryStream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream.NativeFieldInfoPtr_writeBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B65 RID: 2917
		// (get) Token: 0x06002411 RID: 9233 RVA: 0x000A7684 File Offset: 0x000A5884
		// (set) Token: 0x06002412 RID: 9234 RVA: 0x0000F8BF File Offset: 0x0000DABF
		public unsafe bool requestWritten
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream.NativeFieldInfoPtr_requestWritten);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream.NativeFieldInfoPtr_requestWritten)) = value;
			}
		}

		// Token: 0x17000B66 RID: 2918
		// (get) Token: 0x06002413 RID: 9235 RVA: 0x000A76AC File Offset: 0x000A58AC
		// (set) Token: 0x06002414 RID: 9236 RVA: 0x0000F8DA File Offset: 0x0000DADA
		public unsafe bool allowBuffering
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream.NativeFieldInfoPtr_allowBuffering);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream.NativeFieldInfoPtr_allowBuffering)) = value;
			}
		}

		// Token: 0x17000B67 RID: 2919
		// (get) Token: 0x06002415 RID: 9237 RVA: 0x000A76D4 File Offset: 0x000A58D4
		// (set) Token: 0x06002416 RID: 9238 RVA: 0x0000F8F5 File Offset: 0x0000DAF5
		public unsafe bool sendChunked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream.NativeFieldInfoPtr_sendChunked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream.NativeFieldInfoPtr_sendChunked)) = value;
			}
		}

		// Token: 0x17000B68 RID: 2920
		// (get) Token: 0x06002417 RID: 9239 RVA: 0x000A76FC File Offset: 0x000A58FC
		// (set) Token: 0x06002418 RID: 9240 RVA: 0x0000F910 File Offset: 0x0000DB10
		public unsafe WebCompletionSource pendingWrite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream.NativeFieldInfoPtr_pendingWrite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebCompletionSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream.NativeFieldInfoPtr_pendingWrite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B69 RID: 2921
		// (get) Token: 0x06002419 RID: 9241 RVA: 0x000A772C File Offset: 0x000A592C
		// (set) Token: 0x0600241A RID: 9242 RVA: 0x0000F92F File Offset: 0x0000DB2F
		public unsafe long totalWritten
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream.NativeFieldInfoPtr_totalWritten);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream.NativeFieldInfoPtr_totalWritten)) = value;
			}
		}

		// Token: 0x17000B6A RID: 2922
		// (get) Token: 0x0600241B RID: 9243 RVA: 0x000A7754 File Offset: 0x000A5954
		// (set) Token: 0x0600241C RID: 9244 RVA: 0x0000F94A File Offset: 0x0000DB4A
		public unsafe Il2CppStructArray<byte> headers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream.NativeFieldInfoPtr_headers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream.NativeFieldInfoPtr_headers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B6B RID: 2923
		// (get) Token: 0x0600241D RID: 9245 RVA: 0x000A7784 File Offset: 0x000A5984
		// (set) Token: 0x0600241E RID: 9246 RVA: 0x0000F969 File Offset: 0x0000DB69
		public unsafe bool headersSent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream.NativeFieldInfoPtr_headersSent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream.NativeFieldInfoPtr_headersSent)) = value;
			}
		}

		// Token: 0x17000B6C RID: 2924
		// (get) Token: 0x0600241F RID: 9247 RVA: 0x000A77AC File Offset: 0x000A59AC
		// (set) Token: 0x06002420 RID: 9248 RVA: 0x0000F984 File Offset: 0x0000DB84
		public unsafe int completeRequestWritten
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream.NativeFieldInfoPtr_completeRequestWritten);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream.NativeFieldInfoPtr_completeRequestWritten)) = value;
			}
		}

		// Token: 0x17000B6D RID: 2925
		// (get) Token: 0x06002421 RID: 9249 RVA: 0x000A77D4 File Offset: 0x000A59D4
		// (set) Token: 0x06002422 RID: 9250 RVA: 0x0000F99F File Offset: 0x0000DB9F
		public unsafe int chunkTrailerWritten
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream.NativeFieldInfoPtr_chunkTrailerWritten);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream.NativeFieldInfoPtr_chunkTrailerWritten)) = value;
			}
		}

		// Token: 0x17000B6E RID: 2926
		// (get) Token: 0x06002423 RID: 9251 RVA: 0x000A77FC File Offset: 0x000A59FC
		// (set) Token: 0x06002424 RID: 9252 RVA: 0x0000F9BA File Offset: 0x0000DBBA
		public unsafe Stream _InnerStream_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream.NativeFieldInfoPtr__InnerStream_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream.NativeFieldInfoPtr__InnerStream_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B6F RID: 2927
		// (get) Token: 0x06002425 RID: 9253 RVA: 0x000A782C File Offset: 0x000A5A2C
		// (set) Token: 0x06002426 RID: 9254 RVA: 0x0000F9D9 File Offset: 0x0000DBD9
		public unsafe bool _KeepAlive_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream.NativeFieldInfoPtr__KeepAlive_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream.NativeFieldInfoPtr__KeepAlive_k__BackingField)) = value;
			}
		}

		// Token: 0x04001BE9 RID: 7145
		private static readonly IntPtr NativeFieldInfoPtr_crlf;

		// Token: 0x04001BEA RID: 7146
		private static readonly IntPtr NativeFieldInfoPtr_writeBuffer;

		// Token: 0x04001BEB RID: 7147
		private static readonly IntPtr NativeFieldInfoPtr_requestWritten;

		// Token: 0x04001BEC RID: 7148
		private static readonly IntPtr NativeFieldInfoPtr_allowBuffering;

		// Token: 0x04001BED RID: 7149
		private static readonly IntPtr NativeFieldInfoPtr_sendChunked;

		// Token: 0x04001BEE RID: 7150
		private static readonly IntPtr NativeFieldInfoPtr_pendingWrite;

		// Token: 0x04001BEF RID: 7151
		private static readonly IntPtr NativeFieldInfoPtr_totalWritten;

		// Token: 0x04001BF0 RID: 7152
		private static readonly IntPtr NativeFieldInfoPtr_headers;

		// Token: 0x04001BF1 RID: 7153
		private static readonly IntPtr NativeFieldInfoPtr_headersSent;

		// Token: 0x04001BF2 RID: 7154
		private static readonly IntPtr NativeFieldInfoPtr_completeRequestWritten;

		// Token: 0x04001BF3 RID: 7155
		private static readonly IntPtr NativeFieldInfoPtr_chunkTrailerWritten;

		// Token: 0x04001BF4 RID: 7156
		private static readonly IntPtr NativeFieldInfoPtr__InnerStream_k__BackingField;

		// Token: 0x04001BF5 RID: 7157
		private static readonly IntPtr NativeFieldInfoPtr__KeepAlive_k__BackingField;

		// Token: 0x04001BF6 RID: 7158
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WebConnection_WebOperation_Stream_WebConnectionTunnel_0;

		// Token: 0x04001BF7 RID: 7159
		private static readonly IntPtr NativeMethodInfoPtr_get_InnerStream_Internal_get_Stream_0;

		// Token: 0x04001BF8 RID: 7160
		private static readonly IntPtr NativeMethodInfoPtr_get_KeepAlive_Public_get_Boolean_0;

		// Token: 0x04001BF9 RID: 7161
		private static readonly IntPtr NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0;

		// Token: 0x04001BFA RID: 7162
		private static readonly IntPtr NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0;

		// Token: 0x04001BFB RID: 7163
		private static readonly IntPtr NativeMethodInfoPtr_get_HasWriteBuffer_Internal_get_Boolean_0;

		// Token: 0x04001BFC RID: 7164
		private static readonly IntPtr NativeMethodInfoPtr_get_WriteBufferLength_Internal_get_Int32_0;

		// Token: 0x04001BFD RID: 7165
		private static readonly IntPtr NativeMethodInfoPtr_GetWriteBuffer_Internal_BufferOffsetSize_0;

		// Token: 0x04001BFE RID: 7166
		private static readonly IntPtr NativeMethodInfoPtr_FinishWriting_Private_Task_CancellationToken_0;

		// Token: 0x04001BFF RID: 7167
		private static readonly IntPtr NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0;

		// Token: 0x04001C00 RID: 7168
		private static readonly IntPtr NativeMethodInfoPtr_WriteAsyncInner_Private_Task_Il2CppStructArray_1_Byte_Int32_Int32_WebCompletionSource_CancellationToken_0;

		// Token: 0x04001C01 RID: 7169
		private static readonly IntPtr NativeMethodInfoPtr_ProcessWrite_Private_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0;

		// Token: 0x04001C02 RID: 7170
		private static readonly IntPtr NativeMethodInfoPtr_CheckWriteOverflow_Private_Void_Int64_Int64_Int64_0;

		// Token: 0x04001C03 RID: 7171
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Internal_Task_CancellationToken_0;

		// Token: 0x04001C04 RID: 7172
		private static readonly IntPtr NativeMethodInfoPtr_SetHeadersAsync_Private_Task_Boolean_CancellationToken_0;

		// Token: 0x04001C05 RID: 7173
		private static readonly IntPtr NativeMethodInfoPtr_WriteRequestAsync_Internal_Task_CancellationToken_0;

		// Token: 0x04001C06 RID: 7174
		private static readonly IntPtr NativeMethodInfoPtr_WriteChunkTrailer_inner_Private_Task_CancellationToken_0;

		// Token: 0x04001C07 RID: 7175
		private static readonly IntPtr NativeMethodInfoPtr_WriteChunkTrailer_Private_Task_0;

		// Token: 0x04001C08 RID: 7176
		private static readonly IntPtr NativeMethodInfoPtr_KillBuffer_Internal_Void_0;

		// Token: 0x04001C09 RID: 7177
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsync_Public_Virtual_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0;

		// Token: 0x04001C0A RID: 7178
		private static readonly IntPtr NativeMethodInfoPtr_TryReadFromBufferedContent_Protected_Virtual_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_byref_Int32_0;

		// Token: 0x04001C0B RID: 7179
		private static readonly IntPtr NativeMethodInfoPtr_Close_internal_Protected_Virtual_Void_byref_Boolean_0;

		// Token: 0x0200035A RID: 858
		[ObfuscatedName("System.Net.WebRequestStream+<FinishWriting>d__31")]
		public sealed class _FinishWriting_d__31 : ValueType
		{
			// Token: 0x0600317C RID: 12668 RVA: 0x000D3B30 File Offset: 0x000D1D30
			// Note: this type is marked as 'beforefieldinit'.
			static _FinishWriting_d__31()
			{
				Il2CppClassPointerStore<WebRequestStream._FinishWriting_d__31>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, "<FinishWriting>d__31");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebRequestStream._FinishWriting_d__31>.NativeClassPtr);
				WebRequestStream._FinishWriting_d__31.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._FinishWriting_d__31>.NativeClassPtr, "<>1__state");
				WebRequestStream._FinishWriting_d__31.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._FinishWriting_d__31>.NativeClassPtr, "<>t__builder");
				WebRequestStream._FinishWriting_d__31.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._FinishWriting_d__31>.NativeClassPtr, "<>4__this");
				WebRequestStream._FinishWriting_d__31.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._FinishWriting_d__31>.NativeClassPtr, "cancellationToken");
				WebRequestStream._FinishWriting_d__31.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._FinishWriting_d__31>.NativeClassPtr, "<>u__1");
				WebRequestStream._FinishWriting_d__31.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream._FinishWriting_d__31>.NativeClassPtr, 100668673);
				WebRequestStream._FinishWriting_d__31.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream._FinishWriting_d__31>.NativeClassPtr, 100668674);
			}

			// Token: 0x0600317D RID: 12669 RVA: 0x000D3BE8 File Offset: 0x000D1DE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485817, XrefRangeEnd = 485850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream._FinishWriting_d__31.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600317E RID: 12670 RVA: 0x000D3C20 File Offset: 0x000D1E20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485850, XrefRangeEnd = 485854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream._FinishWriting_d__31.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600317F RID: 12671 RVA: 0x00016F7C File Offset: 0x0001517C
			public _FinishWriting_d__31(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06003180 RID: 12672 RVA: 0x00016F85 File Offset: 0x00015185
			public _FinishWriting_d__31()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebRequestStream._FinishWriting_d__31>.NativeClassPtr))
			{
			}

			// Token: 0x17000F92 RID: 3986
			// (get) Token: 0x06003181 RID: 12673 RVA: 0x000D3C68 File Offset: 0x000D1E68
			// (set) Token: 0x06003182 RID: 12674 RVA: 0x00016F97 File Offset: 0x00015197
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._FinishWriting_d__31.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._FinishWriting_d__31.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000F93 RID: 3987
			// (get) Token: 0x06003183 RID: 12675 RVA: 0x000D3C90 File Offset: 0x000D1E90
			// (set) Token: 0x06003184 RID: 12676 RVA: 0x00016FB2 File Offset: 0x000151B2
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._FinishWriting_d__31.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._FinishWriting_d__31.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000F94 RID: 3988
			// (get) Token: 0x06003185 RID: 12677 RVA: 0x000D3CC0 File Offset: 0x000D1EC0
			// (set) Token: 0x06003186 RID: 12678 RVA: 0x00016FE0 File Offset: 0x000151E0
			public unsafe WebRequestStream __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._FinishWriting_d__31.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebRequestStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._FinishWriting_d__31.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F95 RID: 3989
			// (get) Token: 0x06003187 RID: 12679 RVA: 0x000D3CF0 File Offset: 0x000D1EF0
			// (set) Token: 0x06003188 RID: 12680 RVA: 0x00016FFF File Offset: 0x000151FF
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._FinishWriting_d__31.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._FinishWriting_d__31.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000F96 RID: 3990
			// (get) Token: 0x06003189 RID: 12681 RVA: 0x000D3D20 File Offset: 0x000D1F20
			// (set) Token: 0x0600318A RID: 12682 RVA: 0x0001702D File Offset: 0x0001522D
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._FinishWriting_d__31.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._FinishWriting_d__31.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04002648 RID: 9800
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002649 RID: 9801
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400264A RID: 9802
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400264B RID: 9803
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x0400264C RID: 9804
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400264D RID: 9805
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400264E RID: 9806
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200035B RID: 859
		[ObfuscatedName("System.Net.WebRequestStream+<WriteAsyncInner>d__33")]
		public sealed class _WriteAsyncInner_d__33 : ValueType
		{
			// Token: 0x0600318B RID: 12683 RVA: 0x000D3D50 File Offset: 0x000D1F50
			// Note: this type is marked as 'beforefieldinit'.
			static _WriteAsyncInner_d__33()
			{
				Il2CppClassPointerStore<WebRequestStream._WriteAsyncInner_d__33>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, "<WriteAsyncInner>d__33");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebRequestStream._WriteAsyncInner_d__33>.NativeClassPtr);
				WebRequestStream._WriteAsyncInner_d__33.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteAsyncInner_d__33>.NativeClassPtr, "<>1__state");
				WebRequestStream._WriteAsyncInner_d__33.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteAsyncInner_d__33>.NativeClassPtr, "<>t__builder");
				WebRequestStream._WriteAsyncInner_d__33.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteAsyncInner_d__33>.NativeClassPtr, "<>4__this");
				WebRequestStream._WriteAsyncInner_d__33.NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteAsyncInner_d__33>.NativeClassPtr, "buffer");
				WebRequestStream._WriteAsyncInner_d__33.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteAsyncInner_d__33>.NativeClassPtr, "offset");
				WebRequestStream._WriteAsyncInner_d__33.NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteAsyncInner_d__33>.NativeClassPtr, "size");
				WebRequestStream._WriteAsyncInner_d__33.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteAsyncInner_d__33>.NativeClassPtr, "cancellationToken");
				WebRequestStream._WriteAsyncInner_d__33.NativeFieldInfoPtr_completion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteAsyncInner_d__33>.NativeClassPtr, "completion");
				WebRequestStream._WriteAsyncInner_d__33.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteAsyncInner_d__33>.NativeClassPtr, "<>u__1");
				WebRequestStream._WriteAsyncInner_d__33.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteAsyncInner_d__33>.NativeClassPtr, "<>u__2");
				WebRequestStream._WriteAsyncInner_d__33.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream._WriteAsyncInner_d__33>.NativeClassPtr, 100668675);
				WebRequestStream._WriteAsyncInner_d__33.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream._WriteAsyncInner_d__33>.NativeClassPtr, 100668676);
			}

			// Token: 0x0600318C RID: 12684 RVA: 0x000D3E6C File Offset: 0x000D206C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485854, XrefRangeEnd = 485902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream._WriteAsyncInner_d__33.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600318D RID: 12685 RVA: 0x000D3EA4 File Offset: 0x000D20A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485902, XrefRangeEnd = 485906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream._WriteAsyncInner_d__33.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600318E RID: 12686 RVA: 0x0001705B File Offset: 0x0001525B
			public _WriteAsyncInner_d__33(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600318F RID: 12687 RVA: 0x00017064 File Offset: 0x00015264
			public _WriteAsyncInner_d__33()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebRequestStream._WriteAsyncInner_d__33>.NativeClassPtr))
			{
			}

			// Token: 0x17000F97 RID: 3991
			// (get) Token: 0x06003190 RID: 12688 RVA: 0x000D3EEC File Offset: 0x000D20EC
			// (set) Token: 0x06003191 RID: 12689 RVA: 0x00017076 File Offset: 0x00015276
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteAsyncInner_d__33.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteAsyncInner_d__33.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000F98 RID: 3992
			// (get) Token: 0x06003192 RID: 12690 RVA: 0x000D3F14 File Offset: 0x000D2114
			// (set) Token: 0x06003193 RID: 12691 RVA: 0x00017091 File Offset: 0x00015291
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteAsyncInner_d__33.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteAsyncInner_d__33.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000F99 RID: 3993
			// (get) Token: 0x06003194 RID: 12692 RVA: 0x000D3F44 File Offset: 0x000D2144
			// (set) Token: 0x06003195 RID: 12693 RVA: 0x000170BF File Offset: 0x000152BF
			public unsafe WebRequestStream __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteAsyncInner_d__33.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebRequestStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteAsyncInner_d__33.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F9A RID: 3994
			// (get) Token: 0x06003196 RID: 12694 RVA: 0x000D3F74 File Offset: 0x000D2174
			// (set) Token: 0x06003197 RID: 12695 RVA: 0x000170DE File Offset: 0x000152DE
			public unsafe Il2CppStructArray<byte> buffer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteAsyncInner_d__33.NativeFieldInfoPtr_buffer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteAsyncInner_d__33.NativeFieldInfoPtr_buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F9B RID: 3995
			// (get) Token: 0x06003198 RID: 12696 RVA: 0x000D3FA4 File Offset: 0x000D21A4
			// (set) Token: 0x06003199 RID: 12697 RVA: 0x000170FD File Offset: 0x000152FD
			public unsafe int offset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteAsyncInner_d__33.NativeFieldInfoPtr_offset);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteAsyncInner_d__33.NativeFieldInfoPtr_offset)) = value;
				}
			}

			// Token: 0x17000F9C RID: 3996
			// (get) Token: 0x0600319A RID: 12698 RVA: 0x000D3FCC File Offset: 0x000D21CC
			// (set) Token: 0x0600319B RID: 12699 RVA: 0x00017118 File Offset: 0x00015318
			public unsafe int size
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteAsyncInner_d__33.NativeFieldInfoPtr_size);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteAsyncInner_d__33.NativeFieldInfoPtr_size)) = value;
				}
			}

			// Token: 0x17000F9D RID: 3997
			// (get) Token: 0x0600319C RID: 12700 RVA: 0x000D3FF4 File Offset: 0x000D21F4
			// (set) Token: 0x0600319D RID: 12701 RVA: 0x00017133 File Offset: 0x00015333
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteAsyncInner_d__33.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteAsyncInner_d__33.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000F9E RID: 3998
			// (get) Token: 0x0600319E RID: 12702 RVA: 0x000D4024 File Offset: 0x000D2224
			// (set) Token: 0x0600319F RID: 12703 RVA: 0x00017161 File Offset: 0x00015361
			public unsafe WebCompletionSource completion
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteAsyncInner_d__33.NativeFieldInfoPtr_completion);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebCompletionSource>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteAsyncInner_d__33.NativeFieldInfoPtr_completion), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F9F RID: 3999
			// (get) Token: 0x060031A0 RID: 12704 RVA: 0x000D4054 File Offset: 0x000D2254
			// (set) Token: 0x060031A1 RID: 12705 RVA: 0x00017180 File Offset: 0x00015380
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteAsyncInner_d__33.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteAsyncInner_d__33.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000FA0 RID: 4000
			// (get) Token: 0x060031A2 RID: 12706 RVA: 0x000D4084 File Offset: 0x000D2284
			// (set) Token: 0x060031A3 RID: 12707 RVA: 0x000171AE File Offset: 0x000153AE
			public TaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteAsyncInner_d__33.NativeFieldInfoPtr___u__2);
					return new TaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteAsyncInner_d__33.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400264F RID: 9807
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002650 RID: 9808
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04002651 RID: 9809
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002652 RID: 9810
			private static readonly IntPtr NativeFieldInfoPtr_buffer;

			// Token: 0x04002653 RID: 9811
			private static readonly IntPtr NativeFieldInfoPtr_offset;

			// Token: 0x04002654 RID: 9812
			private static readonly IntPtr NativeFieldInfoPtr_size;

			// Token: 0x04002655 RID: 9813
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04002656 RID: 9814
			private static readonly IntPtr NativeFieldInfoPtr_completion;

			// Token: 0x04002657 RID: 9815
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04002658 RID: 9816
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x04002659 RID: 9817
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400265A RID: 9818
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200035C RID: 860
		[ObfuscatedName("System.Net.WebRequestStream+<ProcessWrite>d__34")]
		public sealed class _ProcessWrite_d__34 : ValueType
		{
			// Token: 0x060031A4 RID: 12708 RVA: 0x000D40B4 File Offset: 0x000D22B4
			// Note: this type is marked as 'beforefieldinit'.
			static _ProcessWrite_d__34()
			{
				Il2CppClassPointerStore<WebRequestStream._ProcessWrite_d__34>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, "<ProcessWrite>d__34");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebRequestStream._ProcessWrite_d__34>.NativeClassPtr);
				WebRequestStream._ProcessWrite_d__34.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._ProcessWrite_d__34>.NativeClassPtr, "<>1__state");
				WebRequestStream._ProcessWrite_d__34.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._ProcessWrite_d__34>.NativeClassPtr, "<>t__builder");
				WebRequestStream._ProcessWrite_d__34.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._ProcessWrite_d__34>.NativeClassPtr, "<>4__this");
				WebRequestStream._ProcessWrite_d__34.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._ProcessWrite_d__34>.NativeClassPtr, "cancellationToken");
				WebRequestStream._ProcessWrite_d__34.NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._ProcessWrite_d__34>.NativeClassPtr, "size");
				WebRequestStream._ProcessWrite_d__34.NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._ProcessWrite_d__34>.NativeClassPtr, "buffer");
				WebRequestStream._ProcessWrite_d__34.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._ProcessWrite_d__34>.NativeClassPtr, "offset");
				WebRequestStream._ProcessWrite_d__34.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._ProcessWrite_d__34>.NativeClassPtr, "<>u__1");
				WebRequestStream._ProcessWrite_d__34.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream._ProcessWrite_d__34>.NativeClassPtr, 100668677);
				WebRequestStream._ProcessWrite_d__34.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream._ProcessWrite_d__34>.NativeClassPtr, 100668678);
			}

			// Token: 0x060031A5 RID: 12709 RVA: 0x000D41A8 File Offset: 0x000D23A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485906, XrefRangeEnd = 485947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream._ProcessWrite_d__34.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060031A6 RID: 12710 RVA: 0x000D41E0 File Offset: 0x000D23E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485947, XrefRangeEnd = 485951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream._ProcessWrite_d__34.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060031A7 RID: 12711 RVA: 0x000171DC File Offset: 0x000153DC
			public _ProcessWrite_d__34(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060031A8 RID: 12712 RVA: 0x000171E5 File Offset: 0x000153E5
			public _ProcessWrite_d__34()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebRequestStream._ProcessWrite_d__34>.NativeClassPtr))
			{
			}

			// Token: 0x17000FA1 RID: 4001
			// (get) Token: 0x060031A9 RID: 12713 RVA: 0x000D4228 File Offset: 0x000D2428
			// (set) Token: 0x060031AA RID: 12714 RVA: 0x000171F7 File Offset: 0x000153F7
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._ProcessWrite_d__34.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._ProcessWrite_d__34.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000FA2 RID: 4002
			// (get) Token: 0x060031AB RID: 12715 RVA: 0x000D4250 File Offset: 0x000D2450
			// (set) Token: 0x060031AC RID: 12716 RVA: 0x00017212 File Offset: 0x00015412
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._ProcessWrite_d__34.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._ProcessWrite_d__34.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000FA3 RID: 4003
			// (get) Token: 0x060031AD RID: 12717 RVA: 0x000D4280 File Offset: 0x000D2480
			// (set) Token: 0x060031AE RID: 12718 RVA: 0x00017240 File Offset: 0x00015440
			public unsafe WebRequestStream __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._ProcessWrite_d__34.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebRequestStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._ProcessWrite_d__34.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FA4 RID: 4004
			// (get) Token: 0x060031AF RID: 12719 RVA: 0x000D42B0 File Offset: 0x000D24B0
			// (set) Token: 0x060031B0 RID: 12720 RVA: 0x0001725F File Offset: 0x0001545F
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._ProcessWrite_d__34.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._ProcessWrite_d__34.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000FA5 RID: 4005
			// (get) Token: 0x060031B1 RID: 12721 RVA: 0x000D42E0 File Offset: 0x000D24E0
			// (set) Token: 0x060031B2 RID: 12722 RVA: 0x0001728D File Offset: 0x0001548D
			public unsafe int size
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._ProcessWrite_d__34.NativeFieldInfoPtr_size);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._ProcessWrite_d__34.NativeFieldInfoPtr_size)) = value;
				}
			}

			// Token: 0x17000FA6 RID: 4006
			// (get) Token: 0x060031B3 RID: 12723 RVA: 0x000D4308 File Offset: 0x000D2508
			// (set) Token: 0x060031B4 RID: 12724 RVA: 0x000172A8 File Offset: 0x000154A8
			public unsafe Il2CppStructArray<byte> buffer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._ProcessWrite_d__34.NativeFieldInfoPtr_buffer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._ProcessWrite_d__34.NativeFieldInfoPtr_buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FA7 RID: 4007
			// (get) Token: 0x060031B5 RID: 12725 RVA: 0x000D4338 File Offset: 0x000D2538
			// (set) Token: 0x060031B6 RID: 12726 RVA: 0x000172C7 File Offset: 0x000154C7
			public unsafe int offset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._ProcessWrite_d__34.NativeFieldInfoPtr_offset);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._ProcessWrite_d__34.NativeFieldInfoPtr_offset)) = value;
				}
			}

			// Token: 0x17000FA8 RID: 4008
			// (get) Token: 0x060031B7 RID: 12727 RVA: 0x000D4360 File Offset: 0x000D2560
			// (set) Token: 0x060031B8 RID: 12728 RVA: 0x000172E2 File Offset: 0x000154E2
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._ProcessWrite_d__34.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._ProcessWrite_d__34.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400265B RID: 9819
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400265C RID: 9820
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400265D RID: 9821
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400265E RID: 9822
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x0400265F RID: 9823
			private static readonly IntPtr NativeFieldInfoPtr_size;

			// Token: 0x04002660 RID: 9824
			private static readonly IntPtr NativeFieldInfoPtr_buffer;

			// Token: 0x04002661 RID: 9825
			private static readonly IntPtr NativeFieldInfoPtr_offset;

			// Token: 0x04002662 RID: 9826
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04002663 RID: 9827
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002664 RID: 9828
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200035D RID: 861
		[ObfuscatedName("System.Net.WebRequestStream+<Initialize>d__36")]
		public sealed class _Initialize_d__36 : ValueType
		{
			// Token: 0x060031B9 RID: 12729 RVA: 0x000D4390 File Offset: 0x000D2590
			// Note: this type is marked as 'beforefieldinit'.
			static _Initialize_d__36()
			{
				Il2CppClassPointerStore<WebRequestStream._Initialize_d__36>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, "<Initialize>d__36");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebRequestStream._Initialize_d__36>.NativeClassPtr);
				WebRequestStream._Initialize_d__36.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._Initialize_d__36>.NativeClassPtr, "<>1__state");
				WebRequestStream._Initialize_d__36.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._Initialize_d__36>.NativeClassPtr, "<>t__builder");
				WebRequestStream._Initialize_d__36.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._Initialize_d__36>.NativeClassPtr, "<>4__this");
				WebRequestStream._Initialize_d__36.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._Initialize_d__36>.NativeClassPtr, "cancellationToken");
				WebRequestStream._Initialize_d__36.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._Initialize_d__36>.NativeClassPtr, "<>u__1");
				WebRequestStream._Initialize_d__36.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._Initialize_d__36>.NativeClassPtr, "<>u__2");
				WebRequestStream._Initialize_d__36.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream._Initialize_d__36>.NativeClassPtr, 100668679);
				WebRequestStream._Initialize_d__36.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream._Initialize_d__36>.NativeClassPtr, 100668680);
			}

			// Token: 0x060031BA RID: 12730 RVA: 0x000D445C File Offset: 0x000D265C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485951, XrefRangeEnd = 485989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream._Initialize_d__36.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060031BB RID: 12731 RVA: 0x000D4494 File Offset: 0x000D2694
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485989, XrefRangeEnd = 485993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream._Initialize_d__36.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060031BC RID: 12732 RVA: 0x00017310 File Offset: 0x00015510
			public _Initialize_d__36(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060031BD RID: 12733 RVA: 0x00017319 File Offset: 0x00015519
			public _Initialize_d__36()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebRequestStream._Initialize_d__36>.NativeClassPtr))
			{
			}

			// Token: 0x17000FA9 RID: 4009
			// (get) Token: 0x060031BE RID: 12734 RVA: 0x000D44DC File Offset: 0x000D26DC
			// (set) Token: 0x060031BF RID: 12735 RVA: 0x0001732B File Offset: 0x0001552B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._Initialize_d__36.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._Initialize_d__36.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000FAA RID: 4010
			// (get) Token: 0x060031C0 RID: 12736 RVA: 0x000D4504 File Offset: 0x000D2704
			// (set) Token: 0x060031C1 RID: 12737 RVA: 0x00017346 File Offset: 0x00015546
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._Initialize_d__36.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._Initialize_d__36.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000FAB RID: 4011
			// (get) Token: 0x060031C2 RID: 12738 RVA: 0x000D4534 File Offset: 0x000D2734
			// (set) Token: 0x060031C3 RID: 12739 RVA: 0x00017374 File Offset: 0x00015574
			public unsafe WebRequestStream __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._Initialize_d__36.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebRequestStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._Initialize_d__36.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FAC RID: 4012
			// (get) Token: 0x060031C4 RID: 12740 RVA: 0x000D4564 File Offset: 0x000D2764
			// (set) Token: 0x060031C5 RID: 12741 RVA: 0x00017393 File Offset: 0x00015593
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._Initialize_d__36.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._Initialize_d__36.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000FAD RID: 4013
			// (get) Token: 0x060031C6 RID: 12742 RVA: 0x000D4594 File Offset: 0x000D2794
			// (set) Token: 0x060031C7 RID: 12743 RVA: 0x000173C1 File Offset: 0x000155C1
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._Initialize_d__36.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._Initialize_d__36.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000FAE RID: 4014
			// (get) Token: 0x060031C8 RID: 12744 RVA: 0x000D45C4 File Offset: 0x000D27C4
			// (set) Token: 0x060031C9 RID: 12745 RVA: 0x000173EF File Offset: 0x000155EF
			public TaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._Initialize_d__36.NativeFieldInfoPtr___u__2);
					return new TaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._Initialize_d__36.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04002665 RID: 9829
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002666 RID: 9830
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04002667 RID: 9831
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002668 RID: 9832
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04002669 RID: 9833
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400266A RID: 9834
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x0400266B RID: 9835
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400266C RID: 9836
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200035E RID: 862
		[ObfuscatedName("System.Net.WebRequestStream+<SetHeadersAsync>d__37")]
		public sealed class _SetHeadersAsync_d__37 : ValueType
		{
			// Token: 0x060031CA RID: 12746 RVA: 0x000D45F4 File Offset: 0x000D27F4
			// Note: this type is marked as 'beforefieldinit'.
			static _SetHeadersAsync_d__37()
			{
				Il2CppClassPointerStore<WebRequestStream._SetHeadersAsync_d__37>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, "<SetHeadersAsync>d__37");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebRequestStream._SetHeadersAsync_d__37>.NativeClassPtr);
				WebRequestStream._SetHeadersAsync_d__37.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._SetHeadersAsync_d__37>.NativeClassPtr, "<>1__state");
				WebRequestStream._SetHeadersAsync_d__37.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._SetHeadersAsync_d__37>.NativeClassPtr, "<>t__builder");
				WebRequestStream._SetHeadersAsync_d__37.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._SetHeadersAsync_d__37>.NativeClassPtr, "<>4__this");
				WebRequestStream._SetHeadersAsync_d__37.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._SetHeadersAsync_d__37>.NativeClassPtr, "cancellationToken");
				WebRequestStream._SetHeadersAsync_d__37.NativeFieldInfoPtr_setInternalLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._SetHeadersAsync_d__37>.NativeClassPtr, "setInternalLength");
				WebRequestStream._SetHeadersAsync_d__37.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._SetHeadersAsync_d__37>.NativeClassPtr, "<>u__1");
				WebRequestStream._SetHeadersAsync_d__37.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream._SetHeadersAsync_d__37>.NativeClassPtr, 100668681);
				WebRequestStream._SetHeadersAsync_d__37.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream._SetHeadersAsync_d__37>.NativeClassPtr, 100668682);
			}

			// Token: 0x060031CB RID: 12747 RVA: 0x000D46C0 File Offset: 0x000D28C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485993, XrefRangeEnd = 486047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream._SetHeadersAsync_d__37.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060031CC RID: 12748 RVA: 0x000D46F8 File Offset: 0x000D28F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486047, XrefRangeEnd = 486051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream._SetHeadersAsync_d__37.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060031CD RID: 12749 RVA: 0x0001741D File Offset: 0x0001561D
			public _SetHeadersAsync_d__37(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060031CE RID: 12750 RVA: 0x00017426 File Offset: 0x00015626
			public _SetHeadersAsync_d__37()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebRequestStream._SetHeadersAsync_d__37>.NativeClassPtr))
			{
			}

			// Token: 0x17000FAF RID: 4015
			// (get) Token: 0x060031CF RID: 12751 RVA: 0x000D4740 File Offset: 0x000D2940
			// (set) Token: 0x060031D0 RID: 12752 RVA: 0x00017438 File Offset: 0x00015638
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._SetHeadersAsync_d__37.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._SetHeadersAsync_d__37.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000FB0 RID: 4016
			// (get) Token: 0x060031D1 RID: 12753 RVA: 0x000D4768 File Offset: 0x000D2968
			// (set) Token: 0x060031D2 RID: 12754 RVA: 0x00017453 File Offset: 0x00015653
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._SetHeadersAsync_d__37.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._SetHeadersAsync_d__37.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000FB1 RID: 4017
			// (get) Token: 0x060031D3 RID: 12755 RVA: 0x000D4798 File Offset: 0x000D2998
			// (set) Token: 0x060031D4 RID: 12756 RVA: 0x00017481 File Offset: 0x00015681
			public unsafe WebRequestStream __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._SetHeadersAsync_d__37.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebRequestStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._SetHeadersAsync_d__37.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FB2 RID: 4018
			// (get) Token: 0x060031D5 RID: 12757 RVA: 0x000D47C8 File Offset: 0x000D29C8
			// (set) Token: 0x060031D6 RID: 12758 RVA: 0x000174A0 File Offset: 0x000156A0
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._SetHeadersAsync_d__37.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._SetHeadersAsync_d__37.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000FB3 RID: 4019
			// (get) Token: 0x060031D7 RID: 12759 RVA: 0x000D47F8 File Offset: 0x000D29F8
			// (set) Token: 0x060031D8 RID: 12760 RVA: 0x000174CE File Offset: 0x000156CE
			public unsafe bool setInternalLength
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._SetHeadersAsync_d__37.NativeFieldInfoPtr_setInternalLength);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._SetHeadersAsync_d__37.NativeFieldInfoPtr_setInternalLength)) = value;
				}
			}

			// Token: 0x17000FB4 RID: 4020
			// (get) Token: 0x060031D9 RID: 12761 RVA: 0x000D4820 File Offset: 0x000D2A20
			// (set) Token: 0x060031DA RID: 12762 RVA: 0x000174E9 File Offset: 0x000156E9
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._SetHeadersAsync_d__37.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._SetHeadersAsync_d__37.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400266D RID: 9837
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400266E RID: 9838
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400266F RID: 9839
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002670 RID: 9840
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04002671 RID: 9841
			private static readonly IntPtr NativeFieldInfoPtr_setInternalLength;

			// Token: 0x04002672 RID: 9842
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04002673 RID: 9843
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002674 RID: 9844
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200035F RID: 863
		[ObfuscatedName("System.Net.WebRequestStream+<WriteRequestAsync>d__38")]
		public sealed class _WriteRequestAsync_d__38 : ValueType
		{
			// Token: 0x060031DB RID: 12763 RVA: 0x000D4850 File Offset: 0x000D2A50
			// Note: this type is marked as 'beforefieldinit'.
			static _WriteRequestAsync_d__38()
			{
				Il2CppClassPointerStore<WebRequestStream._WriteRequestAsync_d__38>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, "<WriteRequestAsync>d__38");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebRequestStream._WriteRequestAsync_d__38>.NativeClassPtr);
				WebRequestStream._WriteRequestAsync_d__38.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteRequestAsync_d__38>.NativeClassPtr, "<>1__state");
				WebRequestStream._WriteRequestAsync_d__38.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteRequestAsync_d__38>.NativeClassPtr, "<>t__builder");
				WebRequestStream._WriteRequestAsync_d__38.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteRequestAsync_d__38>.NativeClassPtr, "<>4__this");
				WebRequestStream._WriteRequestAsync_d__38.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteRequestAsync_d__38>.NativeClassPtr, "cancellationToken");
				WebRequestStream._WriteRequestAsync_d__38.NativeFieldInfoPtr__buffer_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteRequestAsync_d__38>.NativeClassPtr, "<buffer>5__2");
				WebRequestStream._WriteRequestAsync_d__38.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteRequestAsync_d__38>.NativeClassPtr, "<>u__1");
				WebRequestStream._WriteRequestAsync_d__38.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteRequestAsync_d__38>.NativeClassPtr, "<>u__2");
				WebRequestStream._WriteRequestAsync_d__38.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream._WriteRequestAsync_d__38>.NativeClassPtr, 100668683);
				WebRequestStream._WriteRequestAsync_d__38.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream._WriteRequestAsync_d__38>.NativeClassPtr, 100668684);
			}

			// Token: 0x060031DC RID: 12764 RVA: 0x000D4930 File Offset: 0x000D2B30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486051, XrefRangeEnd = 486085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream._WriteRequestAsync_d__38.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060031DD RID: 12765 RVA: 0x000D4968 File Offset: 0x000D2B68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486085, XrefRangeEnd = 486089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream._WriteRequestAsync_d__38.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060031DE RID: 12766 RVA: 0x00017517 File Offset: 0x00015717
			public _WriteRequestAsync_d__38(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060031DF RID: 12767 RVA: 0x00017520 File Offset: 0x00015720
			public _WriteRequestAsync_d__38()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebRequestStream._WriteRequestAsync_d__38>.NativeClassPtr))
			{
			}

			// Token: 0x17000FB5 RID: 4021
			// (get) Token: 0x060031E0 RID: 12768 RVA: 0x000D49B0 File Offset: 0x000D2BB0
			// (set) Token: 0x060031E1 RID: 12769 RVA: 0x00017532 File Offset: 0x00015732
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteRequestAsync_d__38.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteRequestAsync_d__38.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000FB6 RID: 4022
			// (get) Token: 0x060031E2 RID: 12770 RVA: 0x000D49D8 File Offset: 0x000D2BD8
			// (set) Token: 0x060031E3 RID: 12771 RVA: 0x0001754D File Offset: 0x0001574D
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteRequestAsync_d__38.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteRequestAsync_d__38.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000FB7 RID: 4023
			// (get) Token: 0x060031E4 RID: 12772 RVA: 0x000D4A08 File Offset: 0x000D2C08
			// (set) Token: 0x060031E5 RID: 12773 RVA: 0x0001757B File Offset: 0x0001577B
			public unsafe WebRequestStream __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteRequestAsync_d__38.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebRequestStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteRequestAsync_d__38.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FB8 RID: 4024
			// (get) Token: 0x060031E6 RID: 12774 RVA: 0x000D4A38 File Offset: 0x000D2C38
			// (set) Token: 0x060031E7 RID: 12775 RVA: 0x0001759A File Offset: 0x0001579A
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteRequestAsync_d__38.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteRequestAsync_d__38.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000FB9 RID: 4025
			// (get) Token: 0x060031E8 RID: 12776 RVA: 0x000D4A68 File Offset: 0x000D2C68
			// (set) Token: 0x060031E9 RID: 12777 RVA: 0x000175C8 File Offset: 0x000157C8
			public unsafe BufferOffsetSize _buffer_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteRequestAsync_d__38.NativeFieldInfoPtr__buffer_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BufferOffsetSize>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteRequestAsync_d__38.NativeFieldInfoPtr__buffer_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FBA RID: 4026
			// (get) Token: 0x060031EA RID: 12778 RVA: 0x000D4A98 File Offset: 0x000D2C98
			// (set) Token: 0x060031EB RID: 12779 RVA: 0x000175E7 File Offset: 0x000157E7
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteRequestAsync_d__38.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteRequestAsync_d__38.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000FBB RID: 4027
			// (get) Token: 0x060031EC RID: 12780 RVA: 0x000D4AC8 File Offset: 0x000D2CC8
			// (set) Token: 0x060031ED RID: 12781 RVA: 0x00017615 File Offset: 0x00015815
			public TaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteRequestAsync_d__38.NativeFieldInfoPtr___u__2);
					return new TaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteRequestAsync_d__38.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04002675 RID: 9845
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002676 RID: 9846
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04002677 RID: 9847
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002678 RID: 9848
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04002679 RID: 9849
			private static readonly IntPtr NativeFieldInfoPtr__buffer_5__2;

			// Token: 0x0400267A RID: 9850
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400267B RID: 9851
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x0400267C RID: 9852
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400267D RID: 9853
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000360 RID: 864
		[ObfuscatedName("System.Net.WebRequestStream+<WriteChunkTrailer_inner>d__39")]
		public sealed class _WriteChunkTrailer_inner_d__39 : ValueType
		{
			// Token: 0x060031EE RID: 12782 RVA: 0x000D4AF8 File Offset: 0x000D2CF8
			// Note: this type is marked as 'beforefieldinit'.
			static _WriteChunkTrailer_inner_d__39()
			{
				Il2CppClassPointerStore<WebRequestStream._WriteChunkTrailer_inner_d__39>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, "<WriteChunkTrailer_inner>d__39");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebRequestStream._WriteChunkTrailer_inner_d__39>.NativeClassPtr);
				WebRequestStream._WriteChunkTrailer_inner_d__39.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteChunkTrailer_inner_d__39>.NativeClassPtr, "<>1__state");
				WebRequestStream._WriteChunkTrailer_inner_d__39.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteChunkTrailer_inner_d__39>.NativeClassPtr, "<>t__builder");
				WebRequestStream._WriteChunkTrailer_inner_d__39.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteChunkTrailer_inner_d__39>.NativeClassPtr, "<>4__this");
				WebRequestStream._WriteChunkTrailer_inner_d__39.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteChunkTrailer_inner_d__39>.NativeClassPtr, "cancellationToken");
				WebRequestStream._WriteChunkTrailer_inner_d__39.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteChunkTrailer_inner_d__39>.NativeClassPtr, "<>u__1");
				WebRequestStream._WriteChunkTrailer_inner_d__39.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream._WriteChunkTrailer_inner_d__39>.NativeClassPtr, 100668685);
				WebRequestStream._WriteChunkTrailer_inner_d__39.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream._WriteChunkTrailer_inner_d__39>.NativeClassPtr, 100668686);
			}

			// Token: 0x060031EF RID: 12783 RVA: 0x000D4BB0 File Offset: 0x000D2DB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486089, XrefRangeEnd = 486110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream._WriteChunkTrailer_inner_d__39.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060031F0 RID: 12784 RVA: 0x000D4BE8 File Offset: 0x000D2DE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486110, XrefRangeEnd = 486114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream._WriteChunkTrailer_inner_d__39.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060031F1 RID: 12785 RVA: 0x00017643 File Offset: 0x00015843
			public _WriteChunkTrailer_inner_d__39(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060031F2 RID: 12786 RVA: 0x0001764C File Offset: 0x0001584C
			public _WriteChunkTrailer_inner_d__39()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebRequestStream._WriteChunkTrailer_inner_d__39>.NativeClassPtr))
			{
			}

			// Token: 0x17000FBC RID: 4028
			// (get) Token: 0x060031F3 RID: 12787 RVA: 0x000D4C30 File Offset: 0x000D2E30
			// (set) Token: 0x060031F4 RID: 12788 RVA: 0x0001765E File Offset: 0x0001585E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteChunkTrailer_inner_d__39.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteChunkTrailer_inner_d__39.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000FBD RID: 4029
			// (get) Token: 0x060031F5 RID: 12789 RVA: 0x000D4C58 File Offset: 0x000D2E58
			// (set) Token: 0x060031F6 RID: 12790 RVA: 0x00017679 File Offset: 0x00015879
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteChunkTrailer_inner_d__39.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteChunkTrailer_inner_d__39.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000FBE RID: 4030
			// (get) Token: 0x060031F7 RID: 12791 RVA: 0x000D4C88 File Offset: 0x000D2E88
			// (set) Token: 0x060031F8 RID: 12792 RVA: 0x000176A7 File Offset: 0x000158A7
			public unsafe WebRequestStream __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteChunkTrailer_inner_d__39.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebRequestStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteChunkTrailer_inner_d__39.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FBF RID: 4031
			// (get) Token: 0x060031F9 RID: 12793 RVA: 0x000D4CB8 File Offset: 0x000D2EB8
			// (set) Token: 0x060031FA RID: 12794 RVA: 0x000176C6 File Offset: 0x000158C6
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteChunkTrailer_inner_d__39.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteChunkTrailer_inner_d__39.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000FC0 RID: 4032
			// (get) Token: 0x060031FB RID: 12795 RVA: 0x000D4CE8 File Offset: 0x000D2EE8
			// (set) Token: 0x060031FC RID: 12796 RVA: 0x000176F4 File Offset: 0x000158F4
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteChunkTrailer_inner_d__39.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteChunkTrailer_inner_d__39.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400267E RID: 9854
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400267F RID: 9855
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04002680 RID: 9856
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002681 RID: 9857
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04002682 RID: 9858
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04002683 RID: 9859
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002684 RID: 9860
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000361 RID: 865
		[ObfuscatedName("System.Net.WebRequestStream+<WriteChunkTrailer>d__40")]
		public sealed class _WriteChunkTrailer_d__40 : ValueType
		{
			// Token: 0x060031FD RID: 12797 RVA: 0x000D4D18 File Offset: 0x000D2F18
			// Note: this type is marked as 'beforefieldinit'.
			static _WriteChunkTrailer_d__40()
			{
				Il2CppClassPointerStore<WebRequestStream._WriteChunkTrailer_d__40>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebRequestStream>.NativeClassPtr, "<WriteChunkTrailer>d__40");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebRequestStream._WriteChunkTrailer_d__40>.NativeClassPtr);
				WebRequestStream._WriteChunkTrailer_d__40.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteChunkTrailer_d__40>.NativeClassPtr, "<>1__state");
				WebRequestStream._WriteChunkTrailer_d__40.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteChunkTrailer_d__40>.NativeClassPtr, "<>t__builder");
				WebRequestStream._WriteChunkTrailer_d__40.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteChunkTrailer_d__40>.NativeClassPtr, "<>4__this");
				WebRequestStream._WriteChunkTrailer_d__40.NativeFieldInfoPtr__cts_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteChunkTrailer_d__40>.NativeClassPtr, "<cts>5__2");
				WebRequestStream._WriteChunkTrailer_d__40.NativeFieldInfoPtr__timeoutTask_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteChunkTrailer_d__40>.NativeClassPtr, "<timeoutTask>5__3");
				WebRequestStream._WriteChunkTrailer_d__40.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteChunkTrailer_d__40>.NativeClassPtr, "<>u__1");
				WebRequestStream._WriteChunkTrailer_d__40.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestStream._WriteChunkTrailer_d__40>.NativeClassPtr, "<>u__2");
				WebRequestStream._WriteChunkTrailer_d__40.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream._WriteChunkTrailer_d__40>.NativeClassPtr, 100668687);
				WebRequestStream._WriteChunkTrailer_d__40.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestStream._WriteChunkTrailer_d__40>.NativeClassPtr, 100668688);
			}

			// Token: 0x060031FE RID: 12798 RVA: 0x000D4DF8 File Offset: 0x000D2FF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486114, XrefRangeEnd = 486188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream._WriteChunkTrailer_d__40.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060031FF RID: 12799 RVA: 0x000D4E30 File Offset: 0x000D3030
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486188, XrefRangeEnd = 486192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestStream._WriteChunkTrailer_d__40.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003200 RID: 12800 RVA: 0x00017722 File Offset: 0x00015922
			public _WriteChunkTrailer_d__40(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06003201 RID: 12801 RVA: 0x0001772B File Offset: 0x0001592B
			public _WriteChunkTrailer_d__40()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebRequestStream._WriteChunkTrailer_d__40>.NativeClassPtr))
			{
			}

			// Token: 0x17000FC1 RID: 4033
			// (get) Token: 0x06003202 RID: 12802 RVA: 0x000D4E78 File Offset: 0x000D3078
			// (set) Token: 0x06003203 RID: 12803 RVA: 0x0001773D File Offset: 0x0001593D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteChunkTrailer_d__40.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteChunkTrailer_d__40.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000FC2 RID: 4034
			// (get) Token: 0x06003204 RID: 12804 RVA: 0x000D4EA0 File Offset: 0x000D30A0
			// (set) Token: 0x06003205 RID: 12805 RVA: 0x00017758 File Offset: 0x00015958
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteChunkTrailer_d__40.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteChunkTrailer_d__40.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000FC3 RID: 4035
			// (get) Token: 0x06003206 RID: 12806 RVA: 0x000D4ED0 File Offset: 0x000D30D0
			// (set) Token: 0x06003207 RID: 12807 RVA: 0x00017786 File Offset: 0x00015986
			public unsafe WebRequestStream __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteChunkTrailer_d__40.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebRequestStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteChunkTrailer_d__40.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FC4 RID: 4036
			// (get) Token: 0x06003208 RID: 12808 RVA: 0x000D4F00 File Offset: 0x000D3100
			// (set) Token: 0x06003209 RID: 12809 RVA: 0x000177A5 File Offset: 0x000159A5
			public unsafe CancellationTokenSource _cts_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteChunkTrailer_d__40.NativeFieldInfoPtr__cts_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CancellationTokenSource>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteChunkTrailer_d__40.NativeFieldInfoPtr__cts_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FC5 RID: 4037
			// (get) Token: 0x0600320A RID: 12810 RVA: 0x000D4F30 File Offset: 0x000D3130
			// (set) Token: 0x0600320B RID: 12811 RVA: 0x000177C4 File Offset: 0x000159C4
			public unsafe Task _timeoutTask_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteChunkTrailer_d__40.NativeFieldInfoPtr__timeoutTask_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteChunkTrailer_d__40.NativeFieldInfoPtr__timeoutTask_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FC6 RID: 4038
			// (get) Token: 0x0600320C RID: 12812 RVA: 0x000D4F60 File Offset: 0x000D3160
			// (set) Token: 0x0600320D RID: 12813 RVA: 0x000177E3 File Offset: 0x000159E3
			public ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteChunkTrailer_d__40.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteChunkTrailer_d__40.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000FC7 RID: 4039
			// (get) Token: 0x0600320E RID: 12814 RVA: 0x000D4F90 File Offset: 0x000D3190
			// (set) Token: 0x0600320F RID: 12815 RVA: 0x00017811 File Offset: 0x00015A11
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteChunkTrailer_d__40.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequestStream._WriteChunkTrailer_d__40.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04002685 RID: 9861
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002686 RID: 9862
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04002687 RID: 9863
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002688 RID: 9864
			private static readonly IntPtr NativeFieldInfoPtr__cts_5__2;

			// Token: 0x04002689 RID: 9865
			private static readonly IntPtr NativeFieldInfoPtr__timeoutTask_5__3;

			// Token: 0x0400268A RID: 9866
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400268B RID: 9867
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x0400268C RID: 9868
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400268D RID: 9869
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
