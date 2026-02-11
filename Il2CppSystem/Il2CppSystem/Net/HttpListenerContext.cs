using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Security.Principal;

namespace Il2CppSystem.Net
{
	// Token: 0x020001FC RID: 508
	public sealed class HttpListenerContext : Object
	{
		// Token: 0x06001FD3 RID: 8147 RVA: 0x000977EC File Offset: 0x000959EC
		// Note: this type is marked as 'beforefieldinit'.
		static HttpListenerContext()
		{
			Il2CppClassPointerStore<HttpListenerContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "HttpListenerContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HttpListenerContext>.NativeClassPtr);
			HttpListenerContext.NativeFieldInfoPtr_request = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpListenerContext>.NativeClassPtr, "request");
			HttpListenerContext.NativeFieldInfoPtr_response = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpListenerContext>.NativeClassPtr, "response");
			HttpListenerContext.NativeFieldInfoPtr_user = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpListenerContext>.NativeClassPtr, "user");
			HttpListenerContext.NativeFieldInfoPtr_cnc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpListenerContext>.NativeClassPtr, "cnc");
			HttpListenerContext.NativeFieldInfoPtr_error = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpListenerContext>.NativeClassPtr, "error");
			HttpListenerContext.NativeFieldInfoPtr_err_status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpListenerContext>.NativeClassPtr, "err_status");
			HttpListenerContext.NativeFieldInfoPtr_Listener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpListenerContext>.NativeClassPtr, "Listener");
			HttpListenerContext.NativeMethodInfoPtr__ctor_Internal_Void_HttpConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListenerContext>.NativeClassPtr, 100668103);
			HttpListenerContext.NativeMethodInfoPtr_get_ErrorStatus_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListenerContext>.NativeClassPtr, 100668104);
			HttpListenerContext.NativeMethodInfoPtr_set_ErrorStatus_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListenerContext>.NativeClassPtr, 100668105);
			HttpListenerContext.NativeMethodInfoPtr_get_ErrorMessage_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListenerContext>.NativeClassPtr, 100668106);
			HttpListenerContext.NativeMethodInfoPtr_set_ErrorMessage_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListenerContext>.NativeClassPtr, 100668107);
			HttpListenerContext.NativeMethodInfoPtr_get_HaveError_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListenerContext>.NativeClassPtr, 100668108);
			HttpListenerContext.NativeMethodInfoPtr_get_Connection_Internal_get_HttpConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListenerContext>.NativeClassPtr, 100668109);
			HttpListenerContext.NativeMethodInfoPtr_get_Request_Public_get_HttpListenerRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListenerContext>.NativeClassPtr, 100668110);
			HttpListenerContext.NativeMethodInfoPtr_get_Response_Public_get_HttpListenerResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListenerContext>.NativeClassPtr, 100668111);
			HttpListenerContext.NativeMethodInfoPtr_ParseAuthentication_Internal_Void_AuthenticationSchemes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListenerContext>.NativeClassPtr, 100668112);
			HttpListenerContext.NativeMethodInfoPtr_ParseBasicAuthentication_Internal_IPrincipal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListenerContext>.NativeClassPtr, 100668113);
		}

		// Token: 0x06001FD4 RID: 8148 RVA: 0x00097984 File Offset: 0x00095B84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 480627, RefRangeEnd = 480628, XrefRangeStart = 480584, XrefRangeEnd = 480627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HttpListenerContext(HttpConnection cnc)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpListenerContext>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cnc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListenerContext.NativeMethodInfoPtr__ctor_Internal_Void_HttpConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170009B8 RID: 2488
		// (get) Token: 0x06001FD5 RID: 8149 RVA: 0x000979D0 File Offset: 0x00095BD0
		// (set) Token: 0x06001FD6 RID: 8150 RVA: 0x00097A0C File Offset: 0x00095C0C
		public unsafe int ErrorStatus
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListenerContext.NativeMethodInfoPtr_get_ErrorStatus_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 170594, RefRangeEnd = 170603, XrefRangeStart = 170594, XrefRangeEnd = 170603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListenerContext.NativeMethodInfoPtr_set_ErrorStatus_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009B9 RID: 2489
		// (get) Token: 0x06001FD7 RID: 8151 RVA: 0x00097A4C File Offset: 0x00095C4C
		// (set) Token: 0x06001FD8 RID: 8152 RVA: 0x00097A84 File Offset: 0x00095C84
		public unsafe string ErrorMessage
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListenerContext.NativeMethodInfoPtr_get_ErrorMessage_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListenerContext.NativeMethodInfoPtr_set_ErrorMessage_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009BA RID: 2490
		// (get) Token: 0x06001FD9 RID: 8153 RVA: 0x00097AC8 File Offset: 0x00095CC8
		public unsafe bool HaveError
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 480628, RefRangeEnd = 480631, XrefRangeStart = 480628, XrefRangeEnd = 480628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListenerContext.NativeMethodInfoPtr_get_HaveError_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009BB RID: 2491
		// (get) Token: 0x06001FDA RID: 8154 RVA: 0x00097B04 File Offset: 0x00095D04
		public unsafe HttpConnection Connection
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListenerContext.NativeMethodInfoPtr_get_Connection_Internal_get_HttpConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HttpConnection>(intPtr3) : null;
			}
		}

		// Token: 0x170009BC RID: 2492
		// (get) Token: 0x06001FDB RID: 8155 RVA: 0x00097B44 File Offset: 0x00095D44
		public unsafe HttpListenerRequest Request
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListenerContext.NativeMethodInfoPtr_get_Request_Public_get_HttpListenerRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HttpListenerRequest>(intPtr3) : null;
			}
		}

		// Token: 0x170009BD RID: 2493
		// (get) Token: 0x06001FDC RID: 8156 RVA: 0x00097B84 File Offset: 0x00095D84
		public unsafe HttpListenerResponse Response
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListenerContext.NativeMethodInfoPtr_get_Response_Public_get_HttpListenerResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HttpListenerResponse>(intPtr3) : null;
			}
		}

		// Token: 0x06001FDD RID: 8157 RVA: 0x00097BC4 File Offset: 0x00095DC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 480631, XrefRangeEnd = 480643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseAuthentication(AuthenticationSchemes expectedSchemes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref expectedSchemes;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListenerContext.NativeMethodInfoPtr_ParseAuthentication_Internal_Void_AuthenticationSchemes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001FDE RID: 8158 RVA: 0x00097C04 File Offset: 0x00095E04
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 480668, RefRangeEnd = 480670, XrefRangeStart = 480643, XrefRangeEnd = 480668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IPrincipal ParseBasicAuthentication(string authData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(authData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListenerContext.NativeMethodInfoPtr_ParseBasicAuthentication_Internal_IPrincipal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPrincipal>(intPtr3) : null;
			}
		}

		// Token: 0x06001FDF RID: 8159 RVA: 0x0000D957 File Offset: 0x0000BB57
		public HttpListenerContext(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009B1 RID: 2481
		// (get) Token: 0x06001FE0 RID: 8160 RVA: 0x00097C54 File Offset: 0x00095E54
		// (set) Token: 0x06001FE1 RID: 8161 RVA: 0x0000D960 File Offset: 0x0000BB60
		public unsafe HttpListenerRequest request
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerContext.NativeFieldInfoPtr_request);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpListenerRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerContext.NativeFieldInfoPtr_request), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009B2 RID: 2482
		// (get) Token: 0x06001FE2 RID: 8162 RVA: 0x00097C84 File Offset: 0x00095E84
		// (set) Token: 0x06001FE3 RID: 8163 RVA: 0x0000D97F File Offset: 0x0000BB7F
		public unsafe HttpListenerResponse response
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerContext.NativeFieldInfoPtr_response);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpListenerResponse>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerContext.NativeFieldInfoPtr_response), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009B3 RID: 2483
		// (get) Token: 0x06001FE4 RID: 8164 RVA: 0x00097CB4 File Offset: 0x00095EB4
		// (set) Token: 0x06001FE5 RID: 8165 RVA: 0x0000D99E File Offset: 0x0000BB9E
		public unsafe IPrincipal user
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerContext.NativeFieldInfoPtr_user);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPrincipal>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerContext.NativeFieldInfoPtr_user), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009B4 RID: 2484
		// (get) Token: 0x06001FE6 RID: 8166 RVA: 0x00097CE4 File Offset: 0x00095EE4
		// (set) Token: 0x06001FE7 RID: 8167 RVA: 0x0000D9BD File Offset: 0x0000BBBD
		public unsafe HttpConnection cnc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerContext.NativeFieldInfoPtr_cnc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpConnection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerContext.NativeFieldInfoPtr_cnc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009B5 RID: 2485
		// (get) Token: 0x06001FE8 RID: 8168 RVA: 0x00097D14 File Offset: 0x00095F14
		// (set) Token: 0x06001FE9 RID: 8169 RVA: 0x0000D9DC File Offset: 0x0000BBDC
		public unsafe string error
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerContext.NativeFieldInfoPtr_error);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerContext.NativeFieldInfoPtr_error), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170009B6 RID: 2486
		// (get) Token: 0x06001FEA RID: 8170 RVA: 0x00097D3C File Offset: 0x00095F3C
		// (set) Token: 0x06001FEB RID: 8171 RVA: 0x0000D9FB File Offset: 0x0000BBFB
		public unsafe int err_status
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerContext.NativeFieldInfoPtr_err_status);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerContext.NativeFieldInfoPtr_err_status)) = value;
			}
		}

		// Token: 0x170009B7 RID: 2487
		// (get) Token: 0x06001FEC RID: 8172 RVA: 0x00097D64 File Offset: 0x00095F64
		// (set) Token: 0x06001FED RID: 8173 RVA: 0x0000DA16 File Offset: 0x0000BC16
		public unsafe HttpListener Listener
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerContext.NativeFieldInfoPtr_Listener);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpListener>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerContext.NativeFieldInfoPtr_Listener), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001904 RID: 6404
		private static readonly IntPtr NativeFieldInfoPtr_request;

		// Token: 0x04001905 RID: 6405
		private static readonly IntPtr NativeFieldInfoPtr_response;

		// Token: 0x04001906 RID: 6406
		private static readonly IntPtr NativeFieldInfoPtr_user;

		// Token: 0x04001907 RID: 6407
		private static readonly IntPtr NativeFieldInfoPtr_cnc;

		// Token: 0x04001908 RID: 6408
		private static readonly IntPtr NativeFieldInfoPtr_error;

		// Token: 0x04001909 RID: 6409
		private static readonly IntPtr NativeFieldInfoPtr_err_status;

		// Token: 0x0400190A RID: 6410
		private static readonly IntPtr NativeFieldInfoPtr_Listener;

		// Token: 0x0400190B RID: 6411
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_HttpConnection_0;

		// Token: 0x0400190C RID: 6412
		private static readonly IntPtr NativeMethodInfoPtr_get_ErrorStatus_Internal_get_Int32_0;

		// Token: 0x0400190D RID: 6413
		private static readonly IntPtr NativeMethodInfoPtr_set_ErrorStatus_Internal_set_Void_Int32_0;

		// Token: 0x0400190E RID: 6414
		private static readonly IntPtr NativeMethodInfoPtr_get_ErrorMessage_Internal_get_String_0;

		// Token: 0x0400190F RID: 6415
		private static readonly IntPtr NativeMethodInfoPtr_set_ErrorMessage_Internal_set_Void_String_0;

		// Token: 0x04001910 RID: 6416
		private static readonly IntPtr NativeMethodInfoPtr_get_HaveError_Internal_get_Boolean_0;

		// Token: 0x04001911 RID: 6417
		private static readonly IntPtr NativeMethodInfoPtr_get_Connection_Internal_get_HttpConnection_0;

		// Token: 0x04001912 RID: 6418
		private static readonly IntPtr NativeMethodInfoPtr_get_Request_Public_get_HttpListenerRequest_0;

		// Token: 0x04001913 RID: 6419
		private static readonly IntPtr NativeMethodInfoPtr_get_Response_Public_get_HttpListenerResponse_0;

		// Token: 0x04001914 RID: 6420
		private static readonly IntPtr NativeMethodInfoPtr_ParseAuthentication_Internal_Void_AuthenticationSchemes_0;

		// Token: 0x04001915 RID: 6421
		private static readonly IntPtr NativeMethodInfoPtr_ParseBasicAuthentication_Internal_IPrincipal_String_0;
	}
}
