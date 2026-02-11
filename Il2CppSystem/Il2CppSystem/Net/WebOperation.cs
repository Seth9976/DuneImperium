using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Runtime.ExceptionServices;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Net
{
	// Token: 0x02000215 RID: 533
	public class WebOperation : Object
	{
		// Token: 0x06002394 RID: 9108 RVA: 0x000A5190 File Offset: 0x000A3390
		// Note: this type is marked as 'beforefieldinit'.
		static WebOperation()
		{
			Il2CppClassPointerStore<WebOperation>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "WebOperation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebOperation>.NativeClassPtr);
			WebOperation.NativeFieldInfoPtr__Request_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, "<Request>k__BackingField");
			WebOperation.NativeFieldInfoPtr__Connection_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, "<Connection>k__BackingField");
			WebOperation.NativeFieldInfoPtr__ServicePoint_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, "<ServicePoint>k__BackingField");
			WebOperation.NativeFieldInfoPtr__WriteBuffer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, "<WriteBuffer>k__BackingField");
			WebOperation.NativeFieldInfoPtr__IsNtlmChallenge_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, "<IsNtlmChallenge>k__BackingField");
			WebOperation.NativeFieldInfoPtr_cts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, "cts");
			WebOperation.NativeFieldInfoPtr_requestTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, "requestTask");
			WebOperation.NativeFieldInfoPtr_requestWrittenTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, "requestWrittenTask");
			WebOperation.NativeFieldInfoPtr_responseTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, "responseTask");
			WebOperation.NativeFieldInfoPtr_finishedTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, "finishedTask");
			WebOperation.NativeFieldInfoPtr_writeStream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, "writeStream");
			WebOperation.NativeFieldInfoPtr_responseStream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, "responseStream");
			WebOperation.NativeFieldInfoPtr_disposedInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, "disposedInfo");
			WebOperation.NativeFieldInfoPtr_closedInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, "closedInfo");
			WebOperation.NativeFieldInfoPtr_priorityRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, "priorityRequest");
			WebOperation.NativeFieldInfoPtr_requestSent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, "requestSent");
			WebOperation.NativeFieldInfoPtr_finished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, "finished");
			WebOperation.NativeMethodInfoPtr_get_Request_Public_get_HttpWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100668591);
			WebOperation.NativeMethodInfoPtr_get_Connection_Public_get_WebConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100668592);
			WebOperation.NativeMethodInfoPtr_set_Connection_Private_set_Void_WebConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100668593);
			WebOperation.NativeMethodInfoPtr_get_ServicePoint_Public_get_ServicePoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100668594);
			WebOperation.NativeMethodInfoPtr_set_ServicePoint_Private_set_Void_ServicePoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100668595);
			WebOperation.NativeMethodInfoPtr_get_WriteBuffer_Public_get_BufferOffsetSize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100668596);
			WebOperation.NativeMethodInfoPtr_get_IsNtlmChallenge_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100668597);
			WebOperation.NativeMethodInfoPtr__ctor_Public_Void_HttpWebRequest_BufferOffsetSize_Boolean_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100668598);
			WebOperation.NativeMethodInfoPtr_get_Aborted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100668599);
			WebOperation.NativeMethodInfoPtr_get_Closed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100668600);
			WebOperation.NativeMethodInfoPtr_Abort_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100668601);
			WebOperation.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100668602);
			WebOperation.NativeMethodInfoPtr_SetCanceled_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100668603);
			WebOperation.NativeMethodInfoPtr_SetError_Private_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100668604);
			WebOperation.NativeMethodInfoPtr_SetDisposed_Private_ValueTuple_2_ExceptionDispatchInfo_Boolean_byref_ExceptionDispatchInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100668605);
			WebOperation.NativeMethodInfoPtr_CheckDisposed_Internal_ExceptionDispatchInfo_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100668606);
			WebOperation.NativeMethodInfoPtr_ThrowIfDisposed_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100668607);
			WebOperation.NativeMethodInfoPtr_ThrowIfDisposed_Internal_Void_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100668608);
			WebOperation.NativeMethodInfoPtr_ThrowIfClosedOrDisposed_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100668609);
			WebOperation.NativeMethodInfoPtr_ThrowIfClosedOrDisposed_Internal_Void_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100668610);
			WebOperation.NativeMethodInfoPtr_CheckThrowDisposed_Private_ExceptionDispatchInfo_Boolean_byref_ExceptionDispatchInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100668611);
			WebOperation.NativeMethodInfoPtr_RegisterRequest_Internal_Void_ServicePoint_WebConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100668612);
			WebOperation.NativeMethodInfoPtr_SetPriorityRequest_Public_Void_WebOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100668613);
			WebOperation.NativeMethodInfoPtr_GetRequestStream_Public_Task_1_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100668614);
			WebOperation.NativeMethodInfoPtr_GetRequestStreamInternal_Internal_Task_1_WebRequestStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100668615);
			WebOperation.NativeMethodInfoPtr_get_WriteStream_Public_get_WebRequestStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100668616);
			WebOperation.NativeMethodInfoPtr_GetResponseStream_Public_Task_1_WebResponseStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100668617);
			WebOperation.NativeMethodInfoPtr_get_Finished_Internal_get_WebCompletionSource_1_ValueTuple_2_Boolean_WebOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100668618);
			WebOperation.NativeMethodInfoPtr_Run_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100668619);
			WebOperation.NativeMethodInfoPtr_CompleteRequestWritten_Internal_Void_WebRequestStream_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100668620);
			WebOperation.NativeMethodInfoPtr_Finish_Internal_Void_Boolean_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100668621);
			WebOperation.NativeMethodInfoPtr__RegisterRequest_b__48_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, 100668622);
		}

		// Token: 0x17000B50 RID: 2896
		// (get) Token: 0x06002395 RID: 9109 RVA: 0x000A5594 File Offset: 0x000A3794
		public unsafe HttpWebRequest Request
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_get_Request_Public_get_HttpWebRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HttpWebRequest>(intPtr3) : null;
			}
		}

		// Token: 0x17000B51 RID: 2897
		// (get) Token: 0x06002396 RID: 9110 RVA: 0x000A55D4 File Offset: 0x000A37D4
		// (set) Token: 0x06002397 RID: 9111 RVA: 0x000A5614 File Offset: 0x000A3814
		public unsafe WebConnection Connection
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_get_Connection_Public_get_WebConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebConnection>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_set_Connection_Private_set_Void_WebConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B52 RID: 2898
		// (get) Token: 0x06002398 RID: 9112 RVA: 0x000A5658 File Offset: 0x000A3858
		// (set) Token: 0x06002399 RID: 9113 RVA: 0x000A5698 File Offset: 0x000A3898
		public unsafe ServicePoint ServicePoint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_get_ServicePoint_Public_get_ServicePoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServicePoint>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_set_ServicePoint_Private_set_Void_ServicePoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B53 RID: 2899
		// (get) Token: 0x0600239A RID: 9114 RVA: 0x000A56DC File Offset: 0x000A38DC
		public unsafe BufferOffsetSize WriteBuffer
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_get_WriteBuffer_Public_get_BufferOffsetSize_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BufferOffsetSize>(intPtr3) : null;
			}
		}

		// Token: 0x17000B54 RID: 2900
		// (get) Token: 0x0600239B RID: 9115 RVA: 0x000A571C File Offset: 0x000A391C
		public unsafe bool IsNtlmChallenge
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_get_IsNtlmChallenge_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600239C RID: 9116 RVA: 0x000A5758 File Offset: 0x000A3958
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 485416, RefRangeEnd = 485418, XrefRangeStart = 485382, XrefRangeEnd = 485416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebOperation(HttpWebRequest request, BufferOffsetSize writeBuffer, bool isNtlmChallenge, CancellationToken cancellationToken)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebOperation>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(writeBuffer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isNtlmChallenge;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr__ctor_Public_Void_HttpWebRequest_BufferOffsetSize_Boolean_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000B55 RID: 2901
		// (get) Token: 0x0600239D RID: 9117 RVA: 0x000A57DC File Offset: 0x000A39DC
		public unsafe bool Aborted
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 485420, RefRangeEnd = 485422, XrefRangeStart = 485418, XrefRangeEnd = 485420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_get_Aborted_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B56 RID: 2902
		// (get) Token: 0x0600239E RID: 9118 RVA: 0x000A5818 File Offset: 0x000A3A18
		public unsafe bool Closed
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485422, XrefRangeEnd = 485424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_get_Closed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600239F RID: 9119 RVA: 0x000A5854 File Offset: 0x000A3A54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 485428, RefRangeEnd = 485430, XrefRangeStart = 485424, XrefRangeEnd = 485428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Abort()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_Abort_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023A0 RID: 9120 RVA: 0x000A5888 File Offset: 0x000A3A88
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 485433, RefRangeEnd = 485435, XrefRangeStart = 485430, XrefRangeEnd = 485433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023A1 RID: 9121 RVA: 0x000A58BC File Offset: 0x000A3ABC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 485449, RefRangeEnd = 485452, XrefRangeStart = 485435, XrefRangeEnd = 485449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCanceled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_SetCanceled_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023A2 RID: 9122 RVA: 0x000A58F0 File Offset: 0x000A3AF0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 485462, RefRangeEnd = 485464, XrefRangeStart = 485452, XrefRangeEnd = 485462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetError(Exception error)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(error);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_SetError_Private_Void_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060023A3 RID: 9123 RVA: 0x000A5934 File Offset: 0x000A3B34
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 485476, RefRangeEnd = 485483, XrefRangeStart = 485464, XrefRangeEnd = 485476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTuple<ExceptionDispatchInfo, bool> SetDisposed(ref ExceptionDispatchInfo field)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(field);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_SetDisposed_Private_ValueTuple_2_ExceptionDispatchInfo_Boolean_byref_ExceptionDispatchInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				field = ((intPtr4 == 0) ? null : new ExceptionDispatchInfo(intPtr4));
				return new ValueTuple<ExceptionDispatchInfo, bool>(intPtr2);
			}
		}

		// Token: 0x060023A4 RID: 9124 RVA: 0x000A5994 File Offset: 0x000A3B94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485483, XrefRangeEnd = 485489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExceptionDispatchInfo CheckDisposed(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_CheckDisposed_Internal_ExceptionDispatchInfo_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExceptionDispatchInfo>(intPtr3) : null;
			}
		}

		// Token: 0x060023A5 RID: 9125 RVA: 0x000A59EC File Offset: 0x000A3BEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485489, XrefRangeEnd = 485494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowIfDisposed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_ThrowIfDisposed_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023A6 RID: 9126 RVA: 0x000A5A20 File Offset: 0x000A3C20
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 485503, RefRangeEnd = 485510, XrefRangeStart = 485494, XrefRangeEnd = 485503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowIfDisposed(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_ThrowIfDisposed_Internal_Void_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060023A7 RID: 9127 RVA: 0x000A5A68 File Offset: 0x000A3C68
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 485515, RefRangeEnd = 485518, XrefRangeStart = 485510, XrefRangeEnd = 485515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowIfClosedOrDisposed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_ThrowIfClosedOrDisposed_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023A8 RID: 9128 RVA: 0x000A5A9C File Offset: 0x000A3C9C
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 485527, RefRangeEnd = 485544, XrefRangeStart = 485518, XrefRangeEnd = 485527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowIfClosedOrDisposed(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_ThrowIfClosedOrDisposed_Internal_Void_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060023A9 RID: 9129 RVA: 0x000A5AE4 File Offset: 0x000A3CE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485544, XrefRangeEnd = 485547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExceptionDispatchInfo CheckThrowDisposed(bool throwIt, ref ExceptionDispatchInfo field)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref throwIt;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(field);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_CheckThrowDisposed_Private_ExceptionDispatchInfo_Boolean_byref_ExceptionDispatchInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			field = ((intPtr4 == 0) ? null : new ExceptionDispatchInfo(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<ExceptionDispatchInfo>(intPtr5) : null;
		}

		// Token: 0x060023AA RID: 9130 RVA: 0x000A5B5C File Offset: 0x000A3D5C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 485565, RefRangeEnd = 485567, XrefRangeStart = 485547, XrefRangeEnd = 485565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterRequest(ServicePoint servicePoint, WebConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(servicePoint);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_RegisterRequest_Internal_Void_ServicePoint_WebConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023AB RID: 9131 RVA: 0x000A5BB0 File Offset: 0x000A3DB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 485572, RefRangeEnd = 485573, XrefRangeStart = 485567, XrefRangeEnd = 485572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPriorityRequest(WebOperation operation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(operation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_SetPriorityRequest_Public_Void_WebOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060023AC RID: 9132 RVA: 0x000A5BF4 File Offset: 0x000A3DF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 485587, RefRangeEnd = 485588, XrefRangeStart = 485573, XrefRangeEnd = 485587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<Stream> GetRequestStream()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_GetRequestStream_Public_Task_1_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Stream>>(intPtr3) : null;
		}

		// Token: 0x060023AD RID: 9133 RVA: 0x000A5C34 File Offset: 0x000A3E34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 485592, RefRangeEnd = 485593, XrefRangeStart = 485588, XrefRangeEnd = 485592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<WebRequestStream> GetRequestStreamInternal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_GetRequestStreamInternal_Internal_Task_1_WebRequestStream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<WebRequestStream>>(intPtr3) : null;
		}

		// Token: 0x17000B57 RID: 2903
		// (get) Token: 0x060023AE RID: 9134 RVA: 0x000A5C74 File Offset: 0x000A3E74
		public unsafe WebRequestStream WriteStream
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 485598, RefRangeEnd = 485599, XrefRangeStart = 485593, XrefRangeEnd = 485598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_get_WriteStream_Public_get_WebRequestStream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebRequestStream>(intPtr3) : null;
			}
		}

		// Token: 0x060023AF RID: 9135 RVA: 0x000A5CB4 File Offset: 0x000A3EB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 485603, RefRangeEnd = 485604, XrefRangeStart = 485599, XrefRangeEnd = 485603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<WebResponseStream> GetResponseStream()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_GetResponseStream_Public_Task_1_WebResponseStream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<WebResponseStream>>(intPtr3) : null;
		}

		// Token: 0x17000B58 RID: 2904
		// (get) Token: 0x060023B0 RID: 9136 RVA: 0x000A5CF4 File Offset: 0x000A3EF4
		public unsafe WebCompletionSource<ValueTuple<bool, WebOperation>> Finished
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_get_Finished_Internal_get_WebCompletionSource_1_ValueTuple_2_Boolean_WebOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebCompletionSource<ValueTuple<bool, WebOperation>>>(intPtr3) : null;
			}
		}

		// Token: 0x060023B1 RID: 9137 RVA: 0x000A5D34 File Offset: 0x000A3F34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485604, XrefRangeEnd = 485610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Run()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_Run_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023B2 RID: 9138 RVA: 0x000A5D68 File Offset: 0x000A3F68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485610, XrefRangeEnd = 485615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompleteRequestWritten(WebRequestStream stream, Exception error = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(error);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_CompleteRequestWritten_Internal_Void_WebRequestStream_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023B3 RID: 9139 RVA: 0x000A5DBC File Offset: 0x000A3FBC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 485633, RefRangeEnd = 485640, XrefRangeStart = 485615, XrefRangeEnd = 485633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Finish(bool ok, Exception error = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ok;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(error);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr_Finish_Internal_Void_Boolean_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023B4 RID: 9140 RVA: 0x000A5E0C File Offset: 0x000A400C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485640, XrefRangeEnd = 485641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _RegisterRequest_b__48_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation.NativeMethodInfoPtr__RegisterRequest_b__48_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023B5 RID: 9141 RVA: 0x0000F617 File Offset: 0x0000D817
		public WebOperation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B3F RID: 2879
		// (get) Token: 0x060023B6 RID: 9142 RVA: 0x000A5E40 File Offset: 0x000A4040
		// (set) Token: 0x060023B7 RID: 9143 RVA: 0x0000F620 File Offset: 0x0000D820
		public unsafe HttpWebRequest _Request_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr__Request_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpWebRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr__Request_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B40 RID: 2880
		// (get) Token: 0x060023B8 RID: 9144 RVA: 0x000A5E70 File Offset: 0x000A4070
		// (set) Token: 0x060023B9 RID: 9145 RVA: 0x0000F63F File Offset: 0x0000D83F
		public unsafe WebConnection _Connection_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr__Connection_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebConnection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr__Connection_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B41 RID: 2881
		// (get) Token: 0x060023BA RID: 9146 RVA: 0x000A5EA0 File Offset: 0x000A40A0
		// (set) Token: 0x060023BB RID: 9147 RVA: 0x0000F65E File Offset: 0x0000D85E
		public unsafe ServicePoint _ServicePoint_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr__ServicePoint_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServicePoint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr__ServicePoint_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B42 RID: 2882
		// (get) Token: 0x060023BC RID: 9148 RVA: 0x000A5ED0 File Offset: 0x000A40D0
		// (set) Token: 0x060023BD RID: 9149 RVA: 0x0000F67D File Offset: 0x0000D87D
		public unsafe BufferOffsetSize _WriteBuffer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr__WriteBuffer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BufferOffsetSize>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr__WriteBuffer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B43 RID: 2883
		// (get) Token: 0x060023BE RID: 9150 RVA: 0x000A5F00 File Offset: 0x000A4100
		// (set) Token: 0x060023BF RID: 9151 RVA: 0x0000F69C File Offset: 0x0000D89C
		public unsafe bool _IsNtlmChallenge_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr__IsNtlmChallenge_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr__IsNtlmChallenge_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B44 RID: 2884
		// (get) Token: 0x060023C0 RID: 9152 RVA: 0x000A5F28 File Offset: 0x000A4128
		// (set) Token: 0x060023C1 RID: 9153 RVA: 0x0000F6B7 File Offset: 0x0000D8B7
		public unsafe CancellationTokenSource cts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr_cts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CancellationTokenSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr_cts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B45 RID: 2885
		// (get) Token: 0x060023C2 RID: 9154 RVA: 0x000A5F58 File Offset: 0x000A4158
		// (set) Token: 0x060023C3 RID: 9155 RVA: 0x0000F6D6 File Offset: 0x0000D8D6
		public unsafe WebCompletionSource<WebRequestStream> requestTask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr_requestTask);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebCompletionSource<WebRequestStream>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr_requestTask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B46 RID: 2886
		// (get) Token: 0x060023C4 RID: 9156 RVA: 0x000A5F88 File Offset: 0x000A4188
		// (set) Token: 0x060023C5 RID: 9157 RVA: 0x0000F6F5 File Offset: 0x0000D8F5
		public unsafe WebCompletionSource<WebRequestStream> requestWrittenTask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr_requestWrittenTask);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebCompletionSource<WebRequestStream>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr_requestWrittenTask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B47 RID: 2887
		// (get) Token: 0x060023C6 RID: 9158 RVA: 0x000A5FB8 File Offset: 0x000A41B8
		// (set) Token: 0x060023C7 RID: 9159 RVA: 0x0000F714 File Offset: 0x0000D914
		public unsafe WebCompletionSource<WebResponseStream> responseTask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr_responseTask);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebCompletionSource<WebResponseStream>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr_responseTask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B48 RID: 2888
		// (get) Token: 0x060023C8 RID: 9160 RVA: 0x000A5FE8 File Offset: 0x000A41E8
		// (set) Token: 0x060023C9 RID: 9161 RVA: 0x0000F733 File Offset: 0x0000D933
		public unsafe WebCompletionSource<ValueTuple<bool, WebOperation>> finishedTask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr_finishedTask);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebCompletionSource<ValueTuple<bool, WebOperation>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr_finishedTask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B49 RID: 2889
		// (get) Token: 0x060023CA RID: 9162 RVA: 0x000A6018 File Offset: 0x000A4218
		// (set) Token: 0x060023CB RID: 9163 RVA: 0x0000F752 File Offset: 0x0000D952
		public unsafe WebRequestStream writeStream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr_writeStream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebRequestStream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr_writeStream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B4A RID: 2890
		// (get) Token: 0x060023CC RID: 9164 RVA: 0x000A6048 File Offset: 0x000A4248
		// (set) Token: 0x060023CD RID: 9165 RVA: 0x0000F771 File Offset: 0x0000D971
		public unsafe WebResponseStream responseStream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr_responseStream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebResponseStream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr_responseStream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B4B RID: 2891
		// (get) Token: 0x060023CE RID: 9166 RVA: 0x000A6078 File Offset: 0x000A4278
		// (set) Token: 0x060023CF RID: 9167 RVA: 0x0000F790 File Offset: 0x0000D990
		public unsafe ExceptionDispatchInfo disposedInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr_disposedInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExceptionDispatchInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr_disposedInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B4C RID: 2892
		// (get) Token: 0x060023D0 RID: 9168 RVA: 0x000A60A8 File Offset: 0x000A42A8
		// (set) Token: 0x060023D1 RID: 9169 RVA: 0x0000F7AF File Offset: 0x0000D9AF
		public unsafe ExceptionDispatchInfo closedInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr_closedInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExceptionDispatchInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr_closedInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B4D RID: 2893
		// (get) Token: 0x060023D2 RID: 9170 RVA: 0x000A60D8 File Offset: 0x000A42D8
		// (set) Token: 0x060023D3 RID: 9171 RVA: 0x0000F7CE File Offset: 0x0000D9CE
		public unsafe WebOperation priorityRequest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr_priorityRequest);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebOperation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr_priorityRequest), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B4E RID: 2894
		// (get) Token: 0x060023D4 RID: 9172 RVA: 0x000A6108 File Offset: 0x000A4308
		// (set) Token: 0x060023D5 RID: 9173 RVA: 0x0000F7ED File Offset: 0x0000D9ED
		public unsafe int requestSent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr_requestSent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr_requestSent)) = value;
			}
		}

		// Token: 0x17000B4F RID: 2895
		// (get) Token: 0x060023D6 RID: 9174 RVA: 0x000A6130 File Offset: 0x000A4330
		// (set) Token: 0x060023D7 RID: 9175 RVA: 0x0000F808 File Offset: 0x0000DA08
		public unsafe int finished
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr_finished);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation.NativeFieldInfoPtr_finished)) = value;
			}
		}

		// Token: 0x04001BA0 RID: 7072
		private static readonly IntPtr NativeFieldInfoPtr__Request_k__BackingField;

		// Token: 0x04001BA1 RID: 7073
		private static readonly IntPtr NativeFieldInfoPtr__Connection_k__BackingField;

		// Token: 0x04001BA2 RID: 7074
		private static readonly IntPtr NativeFieldInfoPtr__ServicePoint_k__BackingField;

		// Token: 0x04001BA3 RID: 7075
		private static readonly IntPtr NativeFieldInfoPtr__WriteBuffer_k__BackingField;

		// Token: 0x04001BA4 RID: 7076
		private static readonly IntPtr NativeFieldInfoPtr__IsNtlmChallenge_k__BackingField;

		// Token: 0x04001BA5 RID: 7077
		private static readonly IntPtr NativeFieldInfoPtr_cts;

		// Token: 0x04001BA6 RID: 7078
		private static readonly IntPtr NativeFieldInfoPtr_requestTask;

		// Token: 0x04001BA7 RID: 7079
		private static readonly IntPtr NativeFieldInfoPtr_requestWrittenTask;

		// Token: 0x04001BA8 RID: 7080
		private static readonly IntPtr NativeFieldInfoPtr_responseTask;

		// Token: 0x04001BA9 RID: 7081
		private static readonly IntPtr NativeFieldInfoPtr_finishedTask;

		// Token: 0x04001BAA RID: 7082
		private static readonly IntPtr NativeFieldInfoPtr_writeStream;

		// Token: 0x04001BAB RID: 7083
		private static readonly IntPtr NativeFieldInfoPtr_responseStream;

		// Token: 0x04001BAC RID: 7084
		private static readonly IntPtr NativeFieldInfoPtr_disposedInfo;

		// Token: 0x04001BAD RID: 7085
		private static readonly IntPtr NativeFieldInfoPtr_closedInfo;

		// Token: 0x04001BAE RID: 7086
		private static readonly IntPtr NativeFieldInfoPtr_priorityRequest;

		// Token: 0x04001BAF RID: 7087
		private static readonly IntPtr NativeFieldInfoPtr_requestSent;

		// Token: 0x04001BB0 RID: 7088
		private static readonly IntPtr NativeFieldInfoPtr_finished;

		// Token: 0x04001BB1 RID: 7089
		private static readonly IntPtr NativeMethodInfoPtr_get_Request_Public_get_HttpWebRequest_0;

		// Token: 0x04001BB2 RID: 7090
		private static readonly IntPtr NativeMethodInfoPtr_get_Connection_Public_get_WebConnection_0;

		// Token: 0x04001BB3 RID: 7091
		private static readonly IntPtr NativeMethodInfoPtr_set_Connection_Private_set_Void_WebConnection_0;

		// Token: 0x04001BB4 RID: 7092
		private static readonly IntPtr NativeMethodInfoPtr_get_ServicePoint_Public_get_ServicePoint_0;

		// Token: 0x04001BB5 RID: 7093
		private static readonly IntPtr NativeMethodInfoPtr_set_ServicePoint_Private_set_Void_ServicePoint_0;

		// Token: 0x04001BB6 RID: 7094
		private static readonly IntPtr NativeMethodInfoPtr_get_WriteBuffer_Public_get_BufferOffsetSize_0;

		// Token: 0x04001BB7 RID: 7095
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNtlmChallenge_Public_get_Boolean_0;

		// Token: 0x04001BB8 RID: 7096
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_HttpWebRequest_BufferOffsetSize_Boolean_CancellationToken_0;

		// Token: 0x04001BB9 RID: 7097
		private static readonly IntPtr NativeMethodInfoPtr_get_Aborted_Public_get_Boolean_0;

		// Token: 0x04001BBA RID: 7098
		private static readonly IntPtr NativeMethodInfoPtr_get_Closed_Public_get_Boolean_0;

		// Token: 0x04001BBB RID: 7099
		private static readonly IntPtr NativeMethodInfoPtr_Abort_Public_Void_0;

		// Token: 0x04001BBC RID: 7100
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04001BBD RID: 7101
		private static readonly IntPtr NativeMethodInfoPtr_SetCanceled_Private_Void_0;

		// Token: 0x04001BBE RID: 7102
		private static readonly IntPtr NativeMethodInfoPtr_SetError_Private_Void_Exception_0;

		// Token: 0x04001BBF RID: 7103
		private static readonly IntPtr NativeMethodInfoPtr_SetDisposed_Private_ValueTuple_2_ExceptionDispatchInfo_Boolean_byref_ExceptionDispatchInfo_0;

		// Token: 0x04001BC0 RID: 7104
		private static readonly IntPtr NativeMethodInfoPtr_CheckDisposed_Internal_ExceptionDispatchInfo_CancellationToken_0;

		// Token: 0x04001BC1 RID: 7105
		private static readonly IntPtr NativeMethodInfoPtr_ThrowIfDisposed_Internal_Void_0;

		// Token: 0x04001BC2 RID: 7106
		private static readonly IntPtr NativeMethodInfoPtr_ThrowIfDisposed_Internal_Void_CancellationToken_0;

		// Token: 0x04001BC3 RID: 7107
		private static readonly IntPtr NativeMethodInfoPtr_ThrowIfClosedOrDisposed_Internal_Void_0;

		// Token: 0x04001BC4 RID: 7108
		private static readonly IntPtr NativeMethodInfoPtr_ThrowIfClosedOrDisposed_Internal_Void_CancellationToken_0;

		// Token: 0x04001BC5 RID: 7109
		private static readonly IntPtr NativeMethodInfoPtr_CheckThrowDisposed_Private_ExceptionDispatchInfo_Boolean_byref_ExceptionDispatchInfo_0;

		// Token: 0x04001BC6 RID: 7110
		private static readonly IntPtr NativeMethodInfoPtr_RegisterRequest_Internal_Void_ServicePoint_WebConnection_0;

		// Token: 0x04001BC7 RID: 7111
		private static readonly IntPtr NativeMethodInfoPtr_SetPriorityRequest_Public_Void_WebOperation_0;

		// Token: 0x04001BC8 RID: 7112
		private static readonly IntPtr NativeMethodInfoPtr_GetRequestStream_Public_Task_1_Stream_0;

		// Token: 0x04001BC9 RID: 7113
		private static readonly IntPtr NativeMethodInfoPtr_GetRequestStreamInternal_Internal_Task_1_WebRequestStream_0;

		// Token: 0x04001BCA RID: 7114
		private static readonly IntPtr NativeMethodInfoPtr_get_WriteStream_Public_get_WebRequestStream_0;

		// Token: 0x04001BCB RID: 7115
		private static readonly IntPtr NativeMethodInfoPtr_GetResponseStream_Public_Task_1_WebResponseStream_0;

		// Token: 0x04001BCC RID: 7116
		private static readonly IntPtr NativeMethodInfoPtr_get_Finished_Internal_get_WebCompletionSource_1_ValueTuple_2_Boolean_WebOperation_0;

		// Token: 0x04001BCD RID: 7117
		private static readonly IntPtr NativeMethodInfoPtr_Run_Internal_Void_0;

		// Token: 0x04001BCE RID: 7118
		private static readonly IntPtr NativeMethodInfoPtr_CompleteRequestWritten_Internal_Void_WebRequestStream_Exception_0;

		// Token: 0x04001BCF RID: 7119
		private static readonly IntPtr NativeMethodInfoPtr_Finish_Internal_Void_Boolean_Exception_0;

		// Token: 0x04001BD0 RID: 7120
		private static readonly IntPtr NativeMethodInfoPtr__RegisterRequest_b__48_0_Private_Void_0;

		// Token: 0x02000357 RID: 855
		[ObfuscatedName("System.Net.WebOperation+<GetRequestStream>d__50")]
		public sealed class _GetRequestStream_d__50 : ValueType
		{
			// Token: 0x06003145 RID: 12613 RVA: 0x000D338C File Offset: 0x000D158C
			// Note: this type is marked as 'beforefieldinit'.
			static _GetRequestStream_d__50()
			{
				Il2CppClassPointerStore<WebOperation._GetRequestStream_d__50>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, "<GetRequestStream>d__50");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebOperation._GetRequestStream_d__50>.NativeClassPtr);
				WebOperation._GetRequestStream_d__50.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation._GetRequestStream_d__50>.NativeClassPtr, "<>1__state");
				WebOperation._GetRequestStream_d__50.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation._GetRequestStream_d__50>.NativeClassPtr, "<>t__builder");
				WebOperation._GetRequestStream_d__50.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation._GetRequestStream_d__50>.NativeClassPtr, "<>4__this");
				WebOperation._GetRequestStream_d__50.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation._GetRequestStream_d__50>.NativeClassPtr, "<>u__1");
				WebOperation._GetRequestStream_d__50.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation._GetRequestStream_d__50>.NativeClassPtr, 100668623);
				WebOperation._GetRequestStream_d__50.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation._GetRequestStream_d__50>.NativeClassPtr, 100668624);
			}

			// Token: 0x06003146 RID: 12614 RVA: 0x000D3430 File Offset: 0x000D1630
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485256, XrefRangeEnd = 485277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation._GetRequestStream_d__50.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003147 RID: 12615 RVA: 0x000D3468 File Offset: 0x000D1668
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485277, XrefRangeEnd = 485283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation._GetRequestStream_d__50.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003148 RID: 12616 RVA: 0x00016C4C File Offset: 0x00014E4C
			public _GetRequestStream_d__50(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06003149 RID: 12617 RVA: 0x00016C55 File Offset: 0x00014E55
			public _GetRequestStream_d__50()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebOperation._GetRequestStream_d__50>.NativeClassPtr))
			{
			}

			// Token: 0x17000F7E RID: 3966
			// (get) Token: 0x0600314A RID: 12618 RVA: 0x000D34B0 File Offset: 0x000D16B0
			// (set) Token: 0x0600314B RID: 12619 RVA: 0x00016C67 File Offset: 0x00014E67
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._GetRequestStream_d__50.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._GetRequestStream_d__50.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000F7F RID: 3967
			// (get) Token: 0x0600314C RID: 12620 RVA: 0x000D34D8 File Offset: 0x000D16D8
			// (set) Token: 0x0600314D RID: 12621 RVA: 0x00016C82 File Offset: 0x00014E82
			public AsyncTaskMethodBuilder<Stream> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._GetRequestStream_d__50.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Stream>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Stream>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._GetRequestStream_d__50.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Stream>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000F80 RID: 3968
			// (get) Token: 0x0600314E RID: 12622 RVA: 0x000D3508 File Offset: 0x000D1708
			// (set) Token: 0x0600314F RID: 12623 RVA: 0x00016CB0 File Offset: 0x00014EB0
			public unsafe WebOperation __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._GetRequestStream_d__50.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebOperation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._GetRequestStream_d__50.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F81 RID: 3969
			// (get) Token: 0x06003150 RID: 12624 RVA: 0x000D3538 File Offset: 0x000D1738
			// (set) Token: 0x06003151 RID: 12625 RVA: 0x00016CCF File Offset: 0x00014ECF
			public ConfiguredTaskAwaitable<WebRequestStream>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._GetRequestStream_d__50.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<WebRequestStream>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<WebRequestStream>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._GetRequestStream_d__50.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<WebRequestStream>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400262E RID: 9774
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400262F RID: 9775
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04002630 RID: 9776
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002631 RID: 9777
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04002632 RID: 9778
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002633 RID: 9779
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000358 RID: 856
		[ObfuscatedName("System.Net.WebOperation+<Run>d__58")]
		public sealed class _Run_d__58 : ValueType
		{
			// Token: 0x06003152 RID: 12626 RVA: 0x000D3568 File Offset: 0x000D1768
			// Note: this type is marked as 'beforefieldinit'.
			static _Run_d__58()
			{
				Il2CppClassPointerStore<WebOperation._Run_d__58>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebOperation>.NativeClassPtr, "<Run>d__58");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebOperation._Run_d__58>.NativeClassPtr);
				WebOperation._Run_d__58.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation._Run_d__58>.NativeClassPtr, "<>1__state");
				WebOperation._Run_d__58.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation._Run_d__58>.NativeClassPtr, "<>t__builder");
				WebOperation._Run_d__58.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation._Run_d__58>.NativeClassPtr, "<>4__this");
				WebOperation._Run_d__58.NativeFieldInfoPtr__requestStream_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation._Run_d__58>.NativeClassPtr, "<requestStream>5__2");
				WebOperation._Run_d__58.NativeFieldInfoPtr__stream_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation._Run_d__58>.NativeClassPtr, "<stream>5__3");
				WebOperation._Run_d__58.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation._Run_d__58>.NativeClassPtr, "<>u__1");
				WebOperation._Run_d__58.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebOperation._Run_d__58>.NativeClassPtr, "<>u__2");
				WebOperation._Run_d__58.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation._Run_d__58>.NativeClassPtr, 100668625);
				WebOperation._Run_d__58.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebOperation._Run_d__58>.NativeClassPtr, 100668626);
			}

			// Token: 0x06003153 RID: 12627 RVA: 0x000D3648 File Offset: 0x000D1848
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485283, XrefRangeEnd = 485382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation._Run_d__58.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003154 RID: 12628 RVA: 0x000D3680 File Offset: 0x000D1880
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebOperation._Run_d__58.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003155 RID: 12629 RVA: 0x00016CFD File Offset: 0x00014EFD
			public _Run_d__58(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06003156 RID: 12630 RVA: 0x00016D06 File Offset: 0x00014F06
			public _Run_d__58()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebOperation._Run_d__58>.NativeClassPtr))
			{
			}

			// Token: 0x17000F82 RID: 3970
			// (get) Token: 0x06003157 RID: 12631 RVA: 0x000D36C8 File Offset: 0x000D18C8
			// (set) Token: 0x06003158 RID: 12632 RVA: 0x00016D18 File Offset: 0x00014F18
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._Run_d__58.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._Run_d__58.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000F83 RID: 3971
			// (get) Token: 0x06003159 RID: 12633 RVA: 0x000D36F0 File Offset: 0x000D18F0
			// (set) Token: 0x0600315A RID: 12634 RVA: 0x00016D33 File Offset: 0x00014F33
			public AsyncVoidMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._Run_d__58.NativeFieldInfoPtr___t__builder);
					return new AsyncVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._Run_d__58.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000F84 RID: 3972
			// (get) Token: 0x0600315B RID: 12635 RVA: 0x000D3720 File Offset: 0x000D1920
			// (set) Token: 0x0600315C RID: 12636 RVA: 0x00016D61 File Offset: 0x00014F61
			public unsafe WebOperation __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._Run_d__58.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebOperation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._Run_d__58.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F85 RID: 3973
			// (get) Token: 0x0600315D RID: 12637 RVA: 0x000D3750 File Offset: 0x000D1950
			// (set) Token: 0x0600315E RID: 12638 RVA: 0x00016D80 File Offset: 0x00014F80
			public unsafe WebRequestStream _requestStream_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._Run_d__58.NativeFieldInfoPtr__requestStream_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebRequestStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._Run_d__58.NativeFieldInfoPtr__requestStream_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F86 RID: 3974
			// (get) Token: 0x0600315F RID: 12639 RVA: 0x000D3780 File Offset: 0x000D1980
			// (set) Token: 0x06003160 RID: 12640 RVA: 0x00016D9F File Offset: 0x00014F9F
			public unsafe WebResponseStream _stream_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._Run_d__58.NativeFieldInfoPtr__stream_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebResponseStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._Run_d__58.NativeFieldInfoPtr__stream_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F87 RID: 3975
			// (get) Token: 0x06003161 RID: 12641 RVA: 0x000D37B0 File Offset: 0x000D19B0
			// (set) Token: 0x06003162 RID: 12642 RVA: 0x00016DBE File Offset: 0x00014FBE
			public ConfiguredTaskAwaitable<WebRequestStream>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._Run_d__58.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<WebRequestStream>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<WebRequestStream>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._Run_d__58.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<WebRequestStream>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000F88 RID: 3976
			// (get) Token: 0x06003163 RID: 12643 RVA: 0x000D37E0 File Offset: 0x000D19E0
			// (set) Token: 0x06003164 RID: 12644 RVA: 0x00016DEC File Offset: 0x00014FEC
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._Run_d__58.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebOperation._Run_d__58.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04002634 RID: 9780
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002635 RID: 9781
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04002636 RID: 9782
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002637 RID: 9783
			private static readonly IntPtr NativeFieldInfoPtr__requestStream_5__2;

			// Token: 0x04002638 RID: 9784
			private static readonly IntPtr NativeFieldInfoPtr__stream_5__3;

			// Token: 0x04002639 RID: 9785
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400263A RID: 9786
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x0400263B RID: 9787
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400263C RID: 9788
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
