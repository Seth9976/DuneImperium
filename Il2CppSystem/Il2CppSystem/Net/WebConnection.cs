using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono.Net.Security;
using Il2CppSystem.IO;
using Il2CppSystem.Net.Sockets;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Net
{
	// Token: 0x02000212 RID: 530
	public class WebConnection : Object
	{
		// Token: 0x06002303 RID: 8963 RVA: 0x000A2C18 File Offset: 0x000A0E18
		// Note: this type is marked as 'beforefieldinit'.
		static WebConnection()
		{
			Il2CppClassPointerStore<WebConnection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "WebConnection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebConnection>.NativeClassPtr);
			WebConnection.NativeFieldInfoPtr_ntlm_credentials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, "ntlm_credentials");
			WebConnection.NativeFieldInfoPtr_ntlm_authenticated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, "ntlm_authenticated");
			WebConnection.NativeFieldInfoPtr_unsafe_sharing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, "unsafe_sharing");
			WebConnection.NativeFieldInfoPtr_networkStream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, "networkStream");
			WebConnection.NativeFieldInfoPtr_socket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, "socket");
			WebConnection.NativeFieldInfoPtr_monoTlsStream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, "monoTlsStream");
			WebConnection.NativeFieldInfoPtr_tunnel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, "tunnel");
			WebConnection.NativeFieldInfoPtr_disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, "disposed");
			WebConnection.NativeFieldInfoPtr__ServicePoint_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, "<ServicePoint>k__BackingField");
			WebConnection.NativeFieldInfoPtr_idleSince = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, "idleSince");
			WebConnection.NativeFieldInfoPtr_currentOperation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, "currentOperation");
			WebConnection.NativeMethodInfoPtr_get_ServicePoint_Public_get_ServicePoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, 100668500);
			WebConnection.NativeMethodInfoPtr__ctor_Public_Void_ServicePoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, 100668501);
			WebConnection.NativeMethodInfoPtr_CanReuse_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, 100668502);
			WebConnection.NativeMethodInfoPtr_CheckReusable_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, 100668503);
			WebConnection.NativeMethodInfoPtr_Connect_Private_Task_WebOperation_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, 100668504);
			WebConnection.NativeMethodInfoPtr_CreateStream_Private_Task_1_Boolean_WebOperation_Boolean_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, 100668505);
			WebConnection.NativeMethodInfoPtr_InitConnection_Internal_Task_1_WebRequestStream_WebOperation_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, 100668506);
			WebConnection.NativeMethodInfoPtr_GetException_Internal_Static_WebException_WebExceptionStatus_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, 100668507);
			WebConnection.NativeMethodInfoPtr_ReadLine_Internal_Static_Boolean_Il2CppStructArray_1_Byte_byref_Int32_Int32_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, 100668508);
			WebConnection.NativeMethodInfoPtr_CanReuseConnection_Internal_Boolean_WebOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, 100668509);
			WebConnection.NativeMethodInfoPtr_PrepareSharingNtlm_Private_Boolean_WebOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, 100668510);
			WebConnection.NativeMethodInfoPtr_Reset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, 100668511);
			WebConnection.NativeMethodInfoPtr_Close_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, 100668512);
			WebConnection.NativeMethodInfoPtr_CloseSocket_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, 100668513);
			WebConnection.NativeMethodInfoPtr_get_Closed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, 100668514);
			WebConnection.NativeMethodInfoPtr_get_IdleSince_Public_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, 100668515);
			WebConnection.NativeMethodInfoPtr_StartOperation_Public_Boolean_WebOperation_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, 100668516);
			WebConnection.NativeMethodInfoPtr_Continue_Public_Boolean_WebOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, 100668517);
			WebConnection.NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, 100668518);
			WebConnection.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, 100668519);
			WebConnection.NativeMethodInfoPtr_ResetNtlm_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, 100668520);
			WebConnection.NativeMethodInfoPtr_get_NtlmAuthenticated_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, 100668521);
			WebConnection.NativeMethodInfoPtr_set_NtlmAuthenticated_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, 100668522);
			WebConnection.NativeMethodInfoPtr_get_NtlmCredential_Internal_get_NetworkCredential_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, 100668523);
			WebConnection.NativeMethodInfoPtr_set_NtlmCredential_Internal_set_Void_NetworkCredential_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, 100668524);
			WebConnection.NativeMethodInfoPtr_get_UnsafeAuthenticatedConnectionSharing_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, 100668525);
			WebConnection.NativeMethodInfoPtr_set_UnsafeAuthenticatedConnectionSharing_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, 100668526);
		}

		// Token: 0x17000B11 RID: 2833
		// (get) Token: 0x06002304 RID: 8964 RVA: 0x000A2F40 File Offset: 0x000A1140
		public unsafe ServicePoint ServicePoint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection.NativeMethodInfoPtr_get_ServicePoint_Public_get_ServicePoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServicePoint>(intPtr3) : null;
			}
		}

		// Token: 0x06002305 RID: 8965 RVA: 0x000A2F80 File Offset: 0x000A1180
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484613, XrefRangeEnd = 484615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebConnection(ServicePoint sPoint)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebConnection>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sPoint);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection.NativeMethodInfoPtr__ctor_Public_Void_ServicePoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002306 RID: 8966 RVA: 0x000A2FCC File Offset: 0x000A11CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484615, XrefRangeEnd = 484616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanReuse()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection.NativeMethodInfoPtr_CanReuse_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002307 RID: 8967 RVA: 0x000A3008 File Offset: 0x000A1208
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484616, XrefRangeEnd = 484618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckReusable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection.NativeMethodInfoPtr_CheckReusable_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002308 RID: 8968 RVA: 0x000A3044 File Offset: 0x000A1244
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484618, XrefRangeEnd = 484630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task Connect(WebOperation operation, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(operation);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection.NativeMethodInfoPtr_Connect_Private_Task_WebOperation_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06002309 RID: 8969 RVA: 0x000A30AC File Offset: 0x000A12AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484630, XrefRangeEnd = 484646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<bool> CreateStream(WebOperation operation, bool reused, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(operation);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reused;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection.NativeMethodInfoPtr_CreateStream_Private_Task_1_Boolean_WebOperation_Boolean_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr3) : null;
		}

		// Token: 0x0600230A RID: 8970 RVA: 0x000A3124 File Offset: 0x000A1324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484646, XrefRangeEnd = 484662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<WebRequestStream> InitConnection(WebOperation operation, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(operation);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection.NativeMethodInfoPtr_InitConnection_Internal_Task_1_WebRequestStream_WebOperation_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<WebRequestStream>>(intPtr3) : null;
		}

		// Token: 0x0600230B RID: 8971 RVA: 0x000A318C File Offset: 0x000A138C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484662, XrefRangeEnd = 484683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WebException GetException(WebExceptionStatus status, Exception error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref status;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(error);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection.NativeMethodInfoPtr_GetException_Internal_Static_WebException_WebExceptionStatus_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebException>(intPtr3) : null;
		}

		// Token: 0x0600230C RID: 8972 RVA: 0x000A31E0 File Offset: 0x000A13E0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 484704, RefRangeEnd = 484707, XrefRangeStart = 484683, XrefRangeEnd = 484704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ReadLine(Il2CppStructArray<byte> buffer, ref int start, int max, ref string output)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(output);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(WebConnection.NativeMethodInfoPtr_ReadLine_Internal_Static_Boolean_Il2CppStructArray_1_Byte_byref_Int32_Int32_byref_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			output = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600230D RID: 8973 RVA: 0x000A3260 File Offset: 0x000A1460
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 484738, RefRangeEnd = 484739, XrefRangeStart = 484707, XrefRangeEnd = 484738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanReuseConnection(WebOperation operation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(operation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection.NativeMethodInfoPtr_CanReuseConnection_Internal_Boolean_WebOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600230E RID: 8974 RVA: 0x000A32B0 File Offset: 0x000A14B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 484760, RefRangeEnd = 484762, XrefRangeStart = 484739, XrefRangeEnd = 484760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool PrepareSharingNtlm(WebOperation operation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(operation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection.NativeMethodInfoPtr_PrepareSharingNtlm_Private_Boolean_WebOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600230F RID: 8975 RVA: 0x000A3300 File Offset: 0x000A1500
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 484768, RefRangeEnd = 484769, XrefRangeStart = 484762, XrefRangeEnd = 484768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection.NativeMethodInfoPtr_Reset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002310 RID: 8976 RVA: 0x000A3334 File Offset: 0x000A1534
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 484775, RefRangeEnd = 484781, XrefRangeStart = 484769, XrefRangeEnd = 484775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close(bool reset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref reset;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection.NativeMethodInfoPtr_Close_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002311 RID: 8977 RVA: 0x000A3374 File Offset: 0x000A1574
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 484795, RefRangeEnd = 484796, XrefRangeStart = 484781, XrefRangeEnd = 484795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CloseSocket()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection.NativeMethodInfoPtr_CloseSocket_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000B12 RID: 2834
		// (get) Token: 0x06002312 RID: 8978 RVA: 0x000A33A8 File Offset: 0x000A15A8
		public unsafe bool Closed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection.NativeMethodInfoPtr_get_Closed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B13 RID: 2835
		// (get) Token: 0x06002313 RID: 8979 RVA: 0x000A33E4 File Offset: 0x000A15E4
		public unsafe DateTime IdleSince
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection.NativeMethodInfoPtr_get_IdleSince_Public_get_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002314 RID: 8980 RVA: 0x000A3420 File Offset: 0x000A1620
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 484815, RefRangeEnd = 484816, XrefRangeStart = 484796, XrefRangeEnd = 484815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool StartOperation(WebOperation operation, bool reused)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(operation);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reused;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection.NativeMethodInfoPtr_StartOperation_Public_Boolean_WebOperation_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002315 RID: 8981 RVA: 0x000A347C File Offset: 0x000A167C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 484828, RefRangeEnd = 484829, XrefRangeStart = 484816, XrefRangeEnd = 484828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Continue(WebOperation next)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(next);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection.NativeMethodInfoPtr_Continue_Public_Boolean_WebOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002316 RID: 8982 RVA: 0x000A34CC File Offset: 0x000A16CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484829, XrefRangeEnd = 484831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection.NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002317 RID: 8983 RVA: 0x000A350C File Offset: 0x000A170C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002318 RID: 8984 RVA: 0x000A3540 File Offset: 0x000A1740
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484831, XrefRangeEnd = 484832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetNtlm()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection.NativeMethodInfoPtr_ResetNtlm_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000B14 RID: 2836
		// (get) Token: 0x06002319 RID: 8985 RVA: 0x000A3574 File Offset: 0x000A1774
		// (set) Token: 0x0600231A RID: 8986 RVA: 0x000A35B0 File Offset: 0x000A17B0
		public unsafe bool NtlmAuthenticated
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection.NativeMethodInfoPtr_get_NtlmAuthenticated_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection.NativeMethodInfoPtr_set_NtlmAuthenticated_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B15 RID: 2837
		// (get) Token: 0x0600231B RID: 8987 RVA: 0x000A35F0 File Offset: 0x000A17F0
		// (set) Token: 0x0600231C RID: 8988 RVA: 0x000A3630 File Offset: 0x000A1830
		public unsafe NetworkCredential NtlmCredential
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection.NativeMethodInfoPtr_get_NtlmCredential_Internal_get_NetworkCredential_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkCredential>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection.NativeMethodInfoPtr_set_NtlmCredential_Internal_set_Void_NetworkCredential_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B16 RID: 2838
		// (get) Token: 0x0600231D RID: 8989 RVA: 0x000A3674 File Offset: 0x000A1874
		// (set) Token: 0x0600231E RID: 8990 RVA: 0x000A36B0 File Offset: 0x000A18B0
		public unsafe bool UnsafeAuthenticatedConnectionSharing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection.NativeMethodInfoPtr_get_UnsafeAuthenticatedConnectionSharing_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection.NativeMethodInfoPtr_set_UnsafeAuthenticatedConnectionSharing_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600231F RID: 8991 RVA: 0x0000F26B File Offset: 0x0000D46B
		public WebConnection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B06 RID: 2822
		// (get) Token: 0x06002320 RID: 8992 RVA: 0x000A36F0 File Offset: 0x000A18F0
		// (set) Token: 0x06002321 RID: 8993 RVA: 0x0000F274 File Offset: 0x0000D474
		public unsafe NetworkCredential ntlm_credentials
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection.NativeFieldInfoPtr_ntlm_credentials);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkCredential>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection.NativeFieldInfoPtr_ntlm_credentials), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B07 RID: 2823
		// (get) Token: 0x06002322 RID: 8994 RVA: 0x000A3720 File Offset: 0x000A1920
		// (set) Token: 0x06002323 RID: 8995 RVA: 0x0000F293 File Offset: 0x0000D493
		public unsafe bool ntlm_authenticated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection.NativeFieldInfoPtr_ntlm_authenticated);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection.NativeFieldInfoPtr_ntlm_authenticated)) = value;
			}
		}

		// Token: 0x17000B08 RID: 2824
		// (get) Token: 0x06002324 RID: 8996 RVA: 0x000A3748 File Offset: 0x000A1948
		// (set) Token: 0x06002325 RID: 8997 RVA: 0x0000F2AE File Offset: 0x0000D4AE
		public unsafe bool unsafe_sharing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection.NativeFieldInfoPtr_unsafe_sharing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection.NativeFieldInfoPtr_unsafe_sharing)) = value;
			}
		}

		// Token: 0x17000B09 RID: 2825
		// (get) Token: 0x06002326 RID: 8998 RVA: 0x000A3770 File Offset: 0x000A1970
		// (set) Token: 0x06002327 RID: 8999 RVA: 0x0000F2C9 File Offset: 0x0000D4C9
		public unsafe Stream networkStream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection.NativeFieldInfoPtr_networkStream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection.NativeFieldInfoPtr_networkStream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B0A RID: 2826
		// (get) Token: 0x06002328 RID: 9000 RVA: 0x000A37A0 File Offset: 0x000A19A0
		// (set) Token: 0x06002329 RID: 9001 RVA: 0x0000F2E8 File Offset: 0x0000D4E8
		public unsafe Socket socket
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection.NativeFieldInfoPtr_socket);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Socket>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection.NativeFieldInfoPtr_socket), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B0B RID: 2827
		// (get) Token: 0x0600232A RID: 9002 RVA: 0x000A37D0 File Offset: 0x000A19D0
		// (set) Token: 0x0600232B RID: 9003 RVA: 0x0000F307 File Offset: 0x0000D507
		public unsafe MonoTlsStream monoTlsStream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection.NativeFieldInfoPtr_monoTlsStream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoTlsStream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection.NativeFieldInfoPtr_monoTlsStream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B0C RID: 2828
		// (get) Token: 0x0600232C RID: 9004 RVA: 0x000A3800 File Offset: 0x000A1A00
		// (set) Token: 0x0600232D RID: 9005 RVA: 0x0000F326 File Offset: 0x0000D526
		public unsafe WebConnectionTunnel tunnel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection.NativeFieldInfoPtr_tunnel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebConnectionTunnel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection.NativeFieldInfoPtr_tunnel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B0D RID: 2829
		// (get) Token: 0x0600232E RID: 9006 RVA: 0x000A3830 File Offset: 0x000A1A30
		// (set) Token: 0x0600232F RID: 9007 RVA: 0x0000F345 File Offset: 0x0000D545
		public unsafe int disposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection.NativeFieldInfoPtr_disposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection.NativeFieldInfoPtr_disposed)) = value;
			}
		}

		// Token: 0x17000B0E RID: 2830
		// (get) Token: 0x06002330 RID: 9008 RVA: 0x000A3858 File Offset: 0x000A1A58
		// (set) Token: 0x06002331 RID: 9009 RVA: 0x0000F360 File Offset: 0x0000D560
		public unsafe ServicePoint _ServicePoint_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection.NativeFieldInfoPtr__ServicePoint_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServicePoint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection.NativeFieldInfoPtr__ServicePoint_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B0F RID: 2831
		// (get) Token: 0x06002332 RID: 9010 RVA: 0x000A3888 File Offset: 0x000A1A88
		// (set) Token: 0x06002333 RID: 9011 RVA: 0x0000F37F File Offset: 0x0000D57F
		public unsafe DateTime idleSince
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection.NativeFieldInfoPtr_idleSince);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection.NativeFieldInfoPtr_idleSince)) = value;
			}
		}

		// Token: 0x17000B10 RID: 2832
		// (get) Token: 0x06002334 RID: 9012 RVA: 0x000A38B0 File Offset: 0x000A1AB0
		// (set) Token: 0x06002335 RID: 9013 RVA: 0x0000F39A File Offset: 0x0000D59A
		public unsafe WebOperation currentOperation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection.NativeFieldInfoPtr_currentOperation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebOperation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection.NativeFieldInfoPtr_currentOperation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001B34 RID: 6964
		private static readonly IntPtr NativeFieldInfoPtr_ntlm_credentials;

		// Token: 0x04001B35 RID: 6965
		private static readonly IntPtr NativeFieldInfoPtr_ntlm_authenticated;

		// Token: 0x04001B36 RID: 6966
		private static readonly IntPtr NativeFieldInfoPtr_unsafe_sharing;

		// Token: 0x04001B37 RID: 6967
		private static readonly IntPtr NativeFieldInfoPtr_networkStream;

		// Token: 0x04001B38 RID: 6968
		private static readonly IntPtr NativeFieldInfoPtr_socket;

		// Token: 0x04001B39 RID: 6969
		private static readonly IntPtr NativeFieldInfoPtr_monoTlsStream;

		// Token: 0x04001B3A RID: 6970
		private static readonly IntPtr NativeFieldInfoPtr_tunnel;

		// Token: 0x04001B3B RID: 6971
		private static readonly IntPtr NativeFieldInfoPtr_disposed;

		// Token: 0x04001B3C RID: 6972
		private static readonly IntPtr NativeFieldInfoPtr__ServicePoint_k__BackingField;

		// Token: 0x04001B3D RID: 6973
		private static readonly IntPtr NativeFieldInfoPtr_idleSince;

		// Token: 0x04001B3E RID: 6974
		private static readonly IntPtr NativeFieldInfoPtr_currentOperation;

		// Token: 0x04001B3F RID: 6975
		private static readonly IntPtr NativeMethodInfoPtr_get_ServicePoint_Public_get_ServicePoint_0;

		// Token: 0x04001B40 RID: 6976
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ServicePoint_0;

		// Token: 0x04001B41 RID: 6977
		private static readonly IntPtr NativeMethodInfoPtr_CanReuse_Private_Boolean_0;

		// Token: 0x04001B42 RID: 6978
		private static readonly IntPtr NativeMethodInfoPtr_CheckReusable_Private_Boolean_0;

		// Token: 0x04001B43 RID: 6979
		private static readonly IntPtr NativeMethodInfoPtr_Connect_Private_Task_WebOperation_CancellationToken_0;

		// Token: 0x04001B44 RID: 6980
		private static readonly IntPtr NativeMethodInfoPtr_CreateStream_Private_Task_1_Boolean_WebOperation_Boolean_CancellationToken_0;

		// Token: 0x04001B45 RID: 6981
		private static readonly IntPtr NativeMethodInfoPtr_InitConnection_Internal_Task_1_WebRequestStream_WebOperation_CancellationToken_0;

		// Token: 0x04001B46 RID: 6982
		private static readonly IntPtr NativeMethodInfoPtr_GetException_Internal_Static_WebException_WebExceptionStatus_Exception_0;

		// Token: 0x04001B47 RID: 6983
		private static readonly IntPtr NativeMethodInfoPtr_ReadLine_Internal_Static_Boolean_Il2CppStructArray_1_Byte_byref_Int32_Int32_byref_String_0;

		// Token: 0x04001B48 RID: 6984
		private static readonly IntPtr NativeMethodInfoPtr_CanReuseConnection_Internal_Boolean_WebOperation_0;

		// Token: 0x04001B49 RID: 6985
		private static readonly IntPtr NativeMethodInfoPtr_PrepareSharingNtlm_Private_Boolean_WebOperation_0;

		// Token: 0x04001B4A RID: 6986
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Private_Void_0;

		// Token: 0x04001B4B RID: 6987
		private static readonly IntPtr NativeMethodInfoPtr_Close_Private_Void_Boolean_0;

		// Token: 0x04001B4C RID: 6988
		private static readonly IntPtr NativeMethodInfoPtr_CloseSocket_Private_Void_0;

		// Token: 0x04001B4D RID: 6989
		private static readonly IntPtr NativeMethodInfoPtr_get_Closed_Public_get_Boolean_0;

		// Token: 0x04001B4E RID: 6990
		private static readonly IntPtr NativeMethodInfoPtr_get_IdleSince_Public_get_DateTime_0;

		// Token: 0x04001B4F RID: 6991
		private static readonly IntPtr NativeMethodInfoPtr_StartOperation_Public_Boolean_WebOperation_Boolean_0;

		// Token: 0x04001B50 RID: 6992
		private static readonly IntPtr NativeMethodInfoPtr_Continue_Public_Boolean_WebOperation_0;

		// Token: 0x04001B51 RID: 6993
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0;

		// Token: 0x04001B52 RID: 6994
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001B53 RID: 6995
		private static readonly IntPtr NativeMethodInfoPtr_ResetNtlm_Private_Void_0;

		// Token: 0x04001B54 RID: 6996
		private static readonly IntPtr NativeMethodInfoPtr_get_NtlmAuthenticated_Internal_get_Boolean_0;

		// Token: 0x04001B55 RID: 6997
		private static readonly IntPtr NativeMethodInfoPtr_set_NtlmAuthenticated_Internal_set_Void_Boolean_0;

		// Token: 0x04001B56 RID: 6998
		private static readonly IntPtr NativeMethodInfoPtr_get_NtlmCredential_Internal_get_NetworkCredential_0;

		// Token: 0x04001B57 RID: 6999
		private static readonly IntPtr NativeMethodInfoPtr_set_NtlmCredential_Internal_set_Void_NetworkCredential_0;

		// Token: 0x04001B58 RID: 7000
		private static readonly IntPtr NativeMethodInfoPtr_get_UnsafeAuthenticatedConnectionSharing_Internal_get_Boolean_0;

		// Token: 0x04001B59 RID: 7001
		private static readonly IntPtr NativeMethodInfoPtr_set_UnsafeAuthenticatedConnectionSharing_Internal_set_Void_Boolean_0;

		// Token: 0x02000350 RID: 848
		[ObfuscatedName("System.Net.WebConnection+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060030C9 RID: 12489 RVA: 0x000D21F8 File Offset: 0x000D03F8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WebConnection.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebConnection.__c>.NativeClassPtr);
				WebConnection.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection.__c>.NativeClassPtr, "<>9");
				WebConnection.__c.NativeFieldInfoPtr___9__16_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection.__c>.NativeClassPtr, "<>9__16_0");
				WebConnection.__c.NativeFieldInfoPtr___9__16_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection.__c>.NativeClassPtr, "<>9__16_1");
				WebConnection.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection.__c>.NativeClassPtr, 100668528);
				WebConnection.__c.NativeMethodInfoPtr__Connect_b__16_0_Internal_IAsyncResult_IPEndPoint_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection.__c>.NativeClassPtr, 100668529);
				WebConnection.__c.NativeMethodInfoPtr__Connect_b__16_1_Internal_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection.__c>.NativeClassPtr, 100668530);
			}

			// Token: 0x060030CA RID: 12490 RVA: 0x000D229C File Offset: 0x000D049C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebConnection.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060030CB RID: 12491 RVA: 0x000D22D8 File Offset: 0x000D04D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484403, XrefRangeEnd = 484408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult _Connect_b__16_0(IPEndPoint targetEndPoint, AsyncCallback callback, Object state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetEndPoint);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection.__c.NativeMethodInfoPtr__Connect_b__16_0_Internal_IAsyncResult_IPEndPoint_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x060030CC RID: 12492 RVA: 0x000D234C File Offset: 0x000D054C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484408, XrefRangeEnd = 484416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Connect_b__16_1(IAsyncResult asyncResult)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection.__c.NativeMethodInfoPtr__Connect_b__16_1_Internal_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060030CD RID: 12493 RVA: 0x0001654C File Offset: 0x0001474C
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000F4F RID: 3919
			// (get) Token: 0x060030CE RID: 12494 RVA: 0x000D2390 File Offset: 0x000D0590
			// (set) Token: 0x060030CF RID: 12495 RVA: 0x00016555 File Offset: 0x00014755
			public unsafe static WebConnection.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WebConnection.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebConnection.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WebConnection.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F50 RID: 3920
			// (get) Token: 0x060030D0 RID: 12496 RVA: 0x000D23B8 File Offset: 0x000D05B8
			// (set) Token: 0x060030D1 RID: 12497 RVA: 0x00016567 File Offset: 0x00014767
			public unsafe static Func<IPEndPoint, AsyncCallback, Object, IAsyncResult> __9__16_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WebConnection.__c.NativeFieldInfoPtr___9__16_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IPEndPoint, AsyncCallback, Object, IAsyncResult>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WebConnection.__c.NativeFieldInfoPtr___9__16_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F51 RID: 3921
			// (get) Token: 0x060030D2 RID: 12498 RVA: 0x000D23E0 File Offset: 0x000D05E0
			// (set) Token: 0x060030D3 RID: 12499 RVA: 0x00016579 File Offset: 0x00014779
			public unsafe static Action<IAsyncResult> __9__16_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WebConnection.__c.NativeFieldInfoPtr___9__16_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<IAsyncResult>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WebConnection.__c.NativeFieldInfoPtr___9__16_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040025EE RID: 9710
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040025EF RID: 9711
			private static readonly IntPtr NativeFieldInfoPtr___9__16_0;

			// Token: 0x040025F0 RID: 9712
			private static readonly IntPtr NativeFieldInfoPtr___9__16_1;

			// Token: 0x040025F1 RID: 9713
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040025F2 RID: 9714
			private static readonly IntPtr NativeMethodInfoPtr__Connect_b__16_0_Internal_IAsyncResult_IPEndPoint_AsyncCallback_Object_0;

			// Token: 0x040025F3 RID: 9715
			private static readonly IntPtr NativeMethodInfoPtr__Connect_b__16_1_Internal_Void_IAsyncResult_0;
		}

		// Token: 0x02000351 RID: 849
		[ObfuscatedName("System.Net.WebConnection+<Connect>d__16")]
		public sealed class _Connect_d__16 : ValueType
		{
			// Token: 0x060030D4 RID: 12500 RVA: 0x000D2408 File Offset: 0x000D0608
			// Note: this type is marked as 'beforefieldinit'.
			static _Connect_d__16()
			{
				Il2CppClassPointerStore<WebConnection._Connect_d__16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, "<Connect>d__16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebConnection._Connect_d__16>.NativeClassPtr);
				WebConnection._Connect_d__16.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection._Connect_d__16>.NativeClassPtr, "<>1__state");
				WebConnection._Connect_d__16.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection._Connect_d__16>.NativeClassPtr, "<>t__builder");
				WebConnection._Connect_d__16.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection._Connect_d__16>.NativeClassPtr, "<>4__this");
				WebConnection._Connect_d__16.NativeFieldInfoPtr_operation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection._Connect_d__16>.NativeClassPtr, "operation");
				WebConnection._Connect_d__16.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection._Connect_d__16>.NativeClassPtr, "cancellationToken");
				WebConnection._Connect_d__16.NativeFieldInfoPtr__connectException_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection._Connect_d__16>.NativeClassPtr, "<connectException>5__2");
				WebConnection._Connect_d__16.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection._Connect_d__16>.NativeClassPtr, "<>7__wrap2");
				WebConnection._Connect_d__16.NativeFieldInfoPtr___7__wrap3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection._Connect_d__16>.NativeClassPtr, "<>7__wrap3");
				WebConnection._Connect_d__16.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection._Connect_d__16>.NativeClassPtr, "<>u__1");
				WebConnection._Connect_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection._Connect_d__16>.NativeClassPtr, 100668531);
				WebConnection._Connect_d__16.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection._Connect_d__16>.NativeClassPtr, 100668532);
			}

			// Token: 0x060030D5 RID: 12501 RVA: 0x000D2510 File Offset: 0x000D0710
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484416, XrefRangeEnd = 484472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection._Connect_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060030D6 RID: 12502 RVA: 0x000D2548 File Offset: 0x000D0748
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484472, XrefRangeEnd = 484476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection._Connect_d__16.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060030D7 RID: 12503 RVA: 0x0001658B File Offset: 0x0001478B
			public _Connect_d__16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060030D8 RID: 12504 RVA: 0x00016594 File Offset: 0x00014794
			public _Connect_d__16()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebConnection._Connect_d__16>.NativeClassPtr))
			{
			}

			// Token: 0x17000F52 RID: 3922
			// (get) Token: 0x060030D9 RID: 12505 RVA: 0x000D2590 File Offset: 0x000D0790
			// (set) Token: 0x060030DA RID: 12506 RVA: 0x000165A6 File Offset: 0x000147A6
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._Connect_d__16.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._Connect_d__16.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000F53 RID: 3923
			// (get) Token: 0x060030DB RID: 12507 RVA: 0x000D25B8 File Offset: 0x000D07B8
			// (set) Token: 0x060030DC RID: 12508 RVA: 0x000165C1 File Offset: 0x000147C1
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._Connect_d__16.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._Connect_d__16.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000F54 RID: 3924
			// (get) Token: 0x060030DD RID: 12509 RVA: 0x000D25E8 File Offset: 0x000D07E8
			// (set) Token: 0x060030DE RID: 12510 RVA: 0x000165EF File Offset: 0x000147EF
			public unsafe WebConnection __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._Connect_d__16.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebConnection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._Connect_d__16.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F55 RID: 3925
			// (get) Token: 0x060030DF RID: 12511 RVA: 0x000D2618 File Offset: 0x000D0818
			// (set) Token: 0x060030E0 RID: 12512 RVA: 0x0001660E File Offset: 0x0001480E
			public unsafe WebOperation operation
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._Connect_d__16.NativeFieldInfoPtr_operation);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebOperation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._Connect_d__16.NativeFieldInfoPtr_operation), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F56 RID: 3926
			// (get) Token: 0x060030E1 RID: 12513 RVA: 0x000D2648 File Offset: 0x000D0848
			// (set) Token: 0x060030E2 RID: 12514 RVA: 0x0001662D File Offset: 0x0001482D
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._Connect_d__16.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._Connect_d__16.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000F57 RID: 3927
			// (get) Token: 0x060030E3 RID: 12515 RVA: 0x000D2678 File Offset: 0x000D0878
			// (set) Token: 0x060030E4 RID: 12516 RVA: 0x0001665B File Offset: 0x0001485B
			public unsafe Exception _connectException_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._Connect_d__16.NativeFieldInfoPtr__connectException_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._Connect_d__16.NativeFieldInfoPtr__connectException_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F58 RID: 3928
			// (get) Token: 0x060030E5 RID: 12517 RVA: 0x000D26A8 File Offset: 0x000D08A8
			// (set) Token: 0x060030E6 RID: 12518 RVA: 0x0001667A File Offset: 0x0001487A
			public unsafe Il2CppReferenceArray<IPAddress> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._Connect_d__16.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IPAddress>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._Connect_d__16.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F59 RID: 3929
			// (get) Token: 0x060030E7 RID: 12519 RVA: 0x000D26D8 File Offset: 0x000D08D8
			// (set) Token: 0x060030E8 RID: 12520 RVA: 0x00016699 File Offset: 0x00014899
			public unsafe int __7__wrap3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._Connect_d__16.NativeFieldInfoPtr___7__wrap3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._Connect_d__16.NativeFieldInfoPtr___7__wrap3)) = value;
				}
			}

			// Token: 0x17000F5A RID: 3930
			// (get) Token: 0x060030E9 RID: 12521 RVA: 0x000D2700 File Offset: 0x000D0900
			// (set) Token: 0x060030EA RID: 12522 RVA: 0x000166B4 File Offset: 0x000148B4
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._Connect_d__16.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._Connect_d__16.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040025F4 RID: 9716
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040025F5 RID: 9717
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040025F6 RID: 9718
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040025F7 RID: 9719
			private static readonly IntPtr NativeFieldInfoPtr_operation;

			// Token: 0x040025F8 RID: 9720
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x040025F9 RID: 9721
			private static readonly IntPtr NativeFieldInfoPtr__connectException_5__2;

			// Token: 0x040025FA RID: 9722
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x040025FB RID: 9723
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap3;

			// Token: 0x040025FC RID: 9724
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040025FD RID: 9725
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040025FE RID: 9726
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000352 RID: 850
		[ObfuscatedName("System.Net.WebConnection+<CreateStream>d__18")]
		public sealed class _CreateStream_d__18 : ValueType
		{
			// Token: 0x060030EB RID: 12523 RVA: 0x000D2730 File Offset: 0x000D0930
			// Note: this type is marked as 'beforefieldinit'.
			static _CreateStream_d__18()
			{
				Il2CppClassPointerStore<WebConnection._CreateStream_d__18>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, "<CreateStream>d__18");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebConnection._CreateStream_d__18>.NativeClassPtr);
				WebConnection._CreateStream_d__18.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection._CreateStream_d__18>.NativeClassPtr, "<>1__state");
				WebConnection._CreateStream_d__18.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection._CreateStream_d__18>.NativeClassPtr, "<>t__builder");
				WebConnection._CreateStream_d__18.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection._CreateStream_d__18>.NativeClassPtr, "<>4__this");
				WebConnection._CreateStream_d__18.NativeFieldInfoPtr_operation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection._CreateStream_d__18>.NativeClassPtr, "operation");
				WebConnection._CreateStream_d__18.NativeFieldInfoPtr_reused = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection._CreateStream_d__18>.NativeClassPtr, "reused");
				WebConnection._CreateStream_d__18.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection._CreateStream_d__18>.NativeClassPtr, "cancellationToken");
				WebConnection._CreateStream_d__18.NativeFieldInfoPtr__stream_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection._CreateStream_d__18>.NativeClassPtr, "<stream>5__2");
				WebConnection._CreateStream_d__18.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection._CreateStream_d__18>.NativeClassPtr, "<>u__1");
				WebConnection._CreateStream_d__18.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection._CreateStream_d__18>.NativeClassPtr, "<>u__2");
				WebConnection._CreateStream_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection._CreateStream_d__18>.NativeClassPtr, 100668533);
				WebConnection._CreateStream_d__18.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection._CreateStream_d__18>.NativeClassPtr, 100668534);
			}

			// Token: 0x060030EC RID: 12524 RVA: 0x000D2838 File Offset: 0x000D0A38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484476, XrefRangeEnd = 484545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection._CreateStream_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060030ED RID: 12525 RVA: 0x000D2870 File Offset: 0x000D0A70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484545, XrefRangeEnd = 484551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection._CreateStream_d__18.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060030EE RID: 12526 RVA: 0x000166E2 File Offset: 0x000148E2
			public _CreateStream_d__18(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060030EF RID: 12527 RVA: 0x000166EB File Offset: 0x000148EB
			public _CreateStream_d__18()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebConnection._CreateStream_d__18>.NativeClassPtr))
			{
			}

			// Token: 0x17000F5B RID: 3931
			// (get) Token: 0x060030F0 RID: 12528 RVA: 0x000D28B8 File Offset: 0x000D0AB8
			// (set) Token: 0x060030F1 RID: 12529 RVA: 0x000166FD File Offset: 0x000148FD
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._CreateStream_d__18.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._CreateStream_d__18.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000F5C RID: 3932
			// (get) Token: 0x060030F2 RID: 12530 RVA: 0x000D28E0 File Offset: 0x000D0AE0
			// (set) Token: 0x060030F3 RID: 12531 RVA: 0x00016718 File Offset: 0x00014918
			public AsyncTaskMethodBuilder<bool> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._CreateStream_d__18.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._CreateStream_d__18.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000F5D RID: 3933
			// (get) Token: 0x060030F4 RID: 12532 RVA: 0x000D2910 File Offset: 0x000D0B10
			// (set) Token: 0x060030F5 RID: 12533 RVA: 0x00016746 File Offset: 0x00014946
			public unsafe WebConnection __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._CreateStream_d__18.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebConnection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._CreateStream_d__18.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F5E RID: 3934
			// (get) Token: 0x060030F6 RID: 12534 RVA: 0x000D2940 File Offset: 0x000D0B40
			// (set) Token: 0x060030F7 RID: 12535 RVA: 0x00016765 File Offset: 0x00014965
			public unsafe WebOperation operation
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._CreateStream_d__18.NativeFieldInfoPtr_operation);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebOperation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._CreateStream_d__18.NativeFieldInfoPtr_operation), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F5F RID: 3935
			// (get) Token: 0x060030F8 RID: 12536 RVA: 0x000D2970 File Offset: 0x000D0B70
			// (set) Token: 0x060030F9 RID: 12537 RVA: 0x00016784 File Offset: 0x00014984
			public unsafe bool reused
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._CreateStream_d__18.NativeFieldInfoPtr_reused);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._CreateStream_d__18.NativeFieldInfoPtr_reused)) = value;
				}
			}

			// Token: 0x17000F60 RID: 3936
			// (get) Token: 0x060030FA RID: 12538 RVA: 0x000D2998 File Offset: 0x000D0B98
			// (set) Token: 0x060030FB RID: 12539 RVA: 0x0001679F File Offset: 0x0001499F
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._CreateStream_d__18.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._CreateStream_d__18.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000F61 RID: 3937
			// (get) Token: 0x060030FC RID: 12540 RVA: 0x000D29C8 File Offset: 0x000D0BC8
			// (set) Token: 0x060030FD RID: 12541 RVA: 0x000167CD File Offset: 0x000149CD
			public unsafe NetworkStream _stream_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._CreateStream_d__18.NativeFieldInfoPtr__stream_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._CreateStream_d__18.NativeFieldInfoPtr__stream_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F62 RID: 3938
			// (get) Token: 0x060030FE RID: 12542 RVA: 0x000D29F8 File Offset: 0x000D0BF8
			// (set) Token: 0x060030FF RID: 12543 RVA: 0x000167EC File Offset: 0x000149EC
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._CreateStream_d__18.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._CreateStream_d__18.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000F63 RID: 3939
			// (get) Token: 0x06003100 RID: 12544 RVA: 0x000D2A28 File Offset: 0x000D0C28
			// (set) Token: 0x06003101 RID: 12545 RVA: 0x0001681A File Offset: 0x00014A1A
			public ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._CreateStream_d__18.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._CreateStream_d__18.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040025FF RID: 9727
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002600 RID: 9728
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04002601 RID: 9729
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002602 RID: 9730
			private static readonly IntPtr NativeFieldInfoPtr_operation;

			// Token: 0x04002603 RID: 9731
			private static readonly IntPtr NativeFieldInfoPtr_reused;

			// Token: 0x04002604 RID: 9732
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04002605 RID: 9733
			private static readonly IntPtr NativeFieldInfoPtr__stream_5__2;

			// Token: 0x04002606 RID: 9734
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04002607 RID: 9735
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x04002608 RID: 9736
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002609 RID: 9737
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000353 RID: 851
		[ObfuscatedName("System.Net.WebConnection+<InitConnection>d__19")]
		public sealed class _InitConnection_d__19 : ValueType
		{
			// Token: 0x06003102 RID: 12546 RVA: 0x000D2A58 File Offset: 0x000D0C58
			// Note: this type is marked as 'beforefieldinit'.
			static _InitConnection_d__19()
			{
				Il2CppClassPointerStore<WebConnection._InitConnection_d__19>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, "<InitConnection>d__19");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebConnection._InitConnection_d__19>.NativeClassPtr);
				WebConnection._InitConnection_d__19.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection._InitConnection_d__19>.NativeClassPtr, "<>1__state");
				WebConnection._InitConnection_d__19.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection._InitConnection_d__19>.NativeClassPtr, "<>t__builder");
				WebConnection._InitConnection_d__19.NativeFieldInfoPtr_operation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection._InitConnection_d__19>.NativeClassPtr, "operation");
				WebConnection._InitConnection_d__19.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection._InitConnection_d__19>.NativeClassPtr, "cancellationToken");
				WebConnection._InitConnection_d__19.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection._InitConnection_d__19>.NativeClassPtr, "<>4__this");
				WebConnection._InitConnection_d__19.NativeFieldInfoPtr__reused_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection._InitConnection_d__19>.NativeClassPtr, "<reused>5__2");
				WebConnection._InitConnection_d__19.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection._InitConnection_d__19>.NativeClassPtr, "<>u__1");
				WebConnection._InitConnection_d__19.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection._InitConnection_d__19>.NativeClassPtr, "<>u__2");
				WebConnection._InitConnection_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection._InitConnection_d__19>.NativeClassPtr, 100668535);
				WebConnection._InitConnection_d__19.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection._InitConnection_d__19>.NativeClassPtr, 100668536);
			}

			// Token: 0x06003103 RID: 12547 RVA: 0x000D2B4C File Offset: 0x000D0D4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484551, XrefRangeEnd = 484607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection._InitConnection_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003104 RID: 12548 RVA: 0x000D2B84 File Offset: 0x000D0D84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484607, XrefRangeEnd = 484613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection._InitConnection_d__19.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003105 RID: 12549 RVA: 0x00016848 File Offset: 0x00014A48
			public _InitConnection_d__19(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06003106 RID: 12550 RVA: 0x00016851 File Offset: 0x00014A51
			public _InitConnection_d__19()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebConnection._InitConnection_d__19>.NativeClassPtr))
			{
			}

			// Token: 0x17000F64 RID: 3940
			// (get) Token: 0x06003107 RID: 12551 RVA: 0x000D2BCC File Offset: 0x000D0DCC
			// (set) Token: 0x06003108 RID: 12552 RVA: 0x00016863 File Offset: 0x00014A63
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._InitConnection_d__19.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._InitConnection_d__19.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000F65 RID: 3941
			// (get) Token: 0x06003109 RID: 12553 RVA: 0x000D2BF4 File Offset: 0x000D0DF4
			// (set) Token: 0x0600310A RID: 12554 RVA: 0x0001687E File Offset: 0x00014A7E
			public AsyncTaskMethodBuilder<WebRequestStream> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._InitConnection_d__19.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<WebRequestStream>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<WebRequestStream>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._InitConnection_d__19.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<WebRequestStream>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000F66 RID: 3942
			// (get) Token: 0x0600310B RID: 12555 RVA: 0x000D2C24 File Offset: 0x000D0E24
			// (set) Token: 0x0600310C RID: 12556 RVA: 0x000168AC File Offset: 0x00014AAC
			public unsafe WebOperation operation
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._InitConnection_d__19.NativeFieldInfoPtr_operation);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebOperation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._InitConnection_d__19.NativeFieldInfoPtr_operation), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F67 RID: 3943
			// (get) Token: 0x0600310D RID: 12557 RVA: 0x000D2C54 File Offset: 0x000D0E54
			// (set) Token: 0x0600310E RID: 12558 RVA: 0x000168CB File Offset: 0x00014ACB
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._InitConnection_d__19.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._InitConnection_d__19.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000F68 RID: 3944
			// (get) Token: 0x0600310F RID: 12559 RVA: 0x000D2C84 File Offset: 0x000D0E84
			// (set) Token: 0x06003110 RID: 12560 RVA: 0x000168F9 File Offset: 0x00014AF9
			public unsafe WebConnection __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._InitConnection_d__19.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebConnection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._InitConnection_d__19.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F69 RID: 3945
			// (get) Token: 0x06003111 RID: 12561 RVA: 0x000D2CB4 File Offset: 0x000D0EB4
			// (set) Token: 0x06003112 RID: 12562 RVA: 0x00016918 File Offset: 0x00014B18
			public unsafe bool _reused_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._InitConnection_d__19.NativeFieldInfoPtr__reused_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._InitConnection_d__19.NativeFieldInfoPtr__reused_5__2)) = value;
				}
			}

			// Token: 0x17000F6A RID: 3946
			// (get) Token: 0x06003113 RID: 12563 RVA: 0x000D2CDC File Offset: 0x000D0EDC
			// (set) Token: 0x06003114 RID: 12564 RVA: 0x00016933 File Offset: 0x00014B33
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._InitConnection_d__19.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._InitConnection_d__19.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000F6B RID: 3947
			// (get) Token: 0x06003115 RID: 12565 RVA: 0x000D2D0C File Offset: 0x000D0F0C
			// (set) Token: 0x06003116 RID: 12566 RVA: 0x00016961 File Offset: 0x00014B61
			public ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._InitConnection_d__19.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._InitConnection_d__19.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400260A RID: 9738
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400260B RID: 9739
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400260C RID: 9740
			private static readonly IntPtr NativeFieldInfoPtr_operation;

			// Token: 0x0400260D RID: 9741
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x0400260E RID: 9742
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400260F RID: 9743
			private static readonly IntPtr NativeFieldInfoPtr__reused_5__2;

			// Token: 0x04002610 RID: 9744
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04002611 RID: 9745
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x04002612 RID: 9746
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002613 RID: 9747
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
