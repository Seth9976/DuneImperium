using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Net.Sockets;
using Il2CppSystem.Security.Cryptography.X509Certificates;

namespace Il2CppSystem.Net
{
	// Token: 0x0200020C RID: 524
	public class ServicePoint : Object
	{
		// Token: 0x0600224D RID: 8781 RVA: 0x000A0714 File Offset: 0x0009E914
		// Note: this type is marked as 'beforefieldinit'.
		static ServicePoint()
		{
			Il2CppClassPointerStore<ServicePoint>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "ServicePoint");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr);
			ServicePoint.NativeFieldInfoPtr_uri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, "uri");
			ServicePoint.NativeFieldInfoPtr_lastDnsResolve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, "lastDnsResolve");
			ServicePoint.NativeFieldInfoPtr_protocolVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, "protocolVersion");
			ServicePoint.NativeFieldInfoPtr_host = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, "host");
			ServicePoint.NativeFieldInfoPtr_usesProxy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, "usesProxy");
			ServicePoint.NativeFieldInfoPtr_sendContinue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, "sendContinue");
			ServicePoint.NativeFieldInfoPtr_useConnect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, "useConnect");
			ServicePoint.NativeFieldInfoPtr_hostE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, "hostE");
			ServicePoint.NativeFieldInfoPtr_useNagle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, "useNagle");
			ServicePoint.NativeFieldInfoPtr_endPointCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, "endPointCallback");
			ServicePoint.NativeFieldInfoPtr_tcp_keepalive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, "tcp_keepalive");
			ServicePoint.NativeFieldInfoPtr_tcp_keepalive_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, "tcp_keepalive_time");
			ServicePoint.NativeFieldInfoPtr_tcp_keepalive_interval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, "tcp_keepalive_interval");
			ServicePoint.NativeFieldInfoPtr_disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, "disposed");
			ServicePoint.NativeFieldInfoPtr_connectionLeaseTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, "connectionLeaseTimeout");
			ServicePoint.NativeFieldInfoPtr_receiveBufferSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, "receiveBufferSize");
			ServicePoint.NativeFieldInfoPtr__Key_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, "<Key>k__BackingField");
			ServicePoint.NativeFieldInfoPtr__Scheduler_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, "<Scheduler>k__BackingField");
			ServicePoint.NativeFieldInfoPtr_connectionLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, "connectionLimit");
			ServicePoint.NativeFieldInfoPtr_maxIdleTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, "maxIdleTime");
			ServicePoint.NativeFieldInfoPtr_m_ServerCertificateOrBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, "m_ServerCertificateOrBytes");
			ServicePoint.NativeFieldInfoPtr_m_ClientCertificateOrBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, "m_ClientCertificateOrBytes");
			ServicePoint.NativeMethodInfoPtr__ctor_Internal_Void_SPKey_Uri_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, 100668396);
			ServicePoint.NativeMethodInfoPtr_get_Key_Internal_get_SPKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, 100668397);
			ServicePoint.NativeMethodInfoPtr_get_Scheduler_Private_get_ServicePointScheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, 100668398);
			ServicePoint.NativeMethodInfoPtr_set_Scheduler_Private_set_Void_ServicePointScheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, 100668399);
			ServicePoint.NativeMethodInfoPtr_get_Address_Public_get_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, 100668400);
			ServicePoint.NativeMethodInfoPtr_get_ConnectionLimit_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, 100668401);
			ServicePoint.NativeMethodInfoPtr_get_ProtocolVersion_Public_Virtual_New_get_Version_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, 100668402);
			ServicePoint.NativeMethodInfoPtr_set_Expect100Continue_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, 100668403);
			ServicePoint.NativeMethodInfoPtr_get_UseNagleAlgorithm_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, 100668404);
			ServicePoint.NativeMethodInfoPtr_set_UseNagleAlgorithm_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, 100668405);
			ServicePoint.NativeMethodInfoPtr_get_SendContinue_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, 100668406);
			ServicePoint.NativeMethodInfoPtr_set_SendContinue_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, 100668407);
			ServicePoint.NativeMethodInfoPtr_SetTcpKeepAlive_Public_Void_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, 100668408);
			ServicePoint.NativeMethodInfoPtr_KeepAliveSetup_Internal_Void_Socket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, 100668409);
			ServicePoint.NativeMethodInfoPtr_PutBytes_Private_Static_Void_Il2CppStructArray_1_Byte_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, 100668410);
			ServicePoint.NativeMethodInfoPtr_get_UsesProxy_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, 100668411);
			ServicePoint.NativeMethodInfoPtr_set_UsesProxy_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, 100668412);
			ServicePoint.NativeMethodInfoPtr_get_UseConnect_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, 100668413);
			ServicePoint.NativeMethodInfoPtr_set_UseConnect_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, 100668414);
			ServicePoint.NativeMethodInfoPtr_get_HasTimedOut_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, 100668415);
			ServicePoint.NativeMethodInfoPtr_get_HostEntry_Internal_get_IPHostEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, 100668416);
			ServicePoint.NativeMethodInfoPtr_SetVersion_Internal_Void_Version_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, 100668417);
			ServicePoint.NativeMethodInfoPtr_SendRequest_Internal_Void_WebOperation_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, 100668418);
			ServicePoint.NativeMethodInfoPtr_CloseConnectionGroup_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, 100668419);
			ServicePoint.NativeMethodInfoPtr_FreeServicePoint_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, 100668420);
			ServicePoint.NativeMethodInfoPtr_UpdateServerCertificate_Internal_Void_X509Certificate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, 100668421);
			ServicePoint.NativeMethodInfoPtr_UpdateClientCertificate_Internal_Void_X509Certificate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, 100668422);
			ServicePoint.NativeMethodInfoPtr_CallEndPointDelegate_Internal_Boolean_Socket_IPEndPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, 100668423);
		}

		// Token: 0x0600224E RID: 8782 RVA: 0x000A0B2C File Offset: 0x0009ED2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 483208, XrefRangeEnd = 483221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ServicePoint(ServicePointManager.SPKey key, Uri uri, int connectionLimit, int maxIdleTime)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uri);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref connectionLimit;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxIdleTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePoint.NativeMethodInfoPtr__ctor_Internal_Void_SPKey_Uri_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000AD4 RID: 2772
		// (get) Token: 0x0600224F RID: 8783 RVA: 0x000A0BA8 File Offset: 0x0009EDA8
		public unsafe ServicePointManager.SPKey Key
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePoint.NativeMethodInfoPtr_get_Key_Internal_get_SPKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServicePointManager.SPKey>(intPtr3) : null;
			}
		}

		// Token: 0x17000AD5 RID: 2773
		// (get) Token: 0x06002250 RID: 8784 RVA: 0x000A0BE8 File Offset: 0x0009EDE8
		// (set) Token: 0x06002251 RID: 8785 RVA: 0x000A0C28 File Offset: 0x0009EE28
		public unsafe ServicePointScheduler Scheduler
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 34746, RefRangeEnd = 34747, XrefRangeStart = 34746, XrefRangeEnd = 34747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePoint.NativeMethodInfoPtr_get_Scheduler_Private_get_ServicePointScheduler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServicePointScheduler>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePoint.NativeMethodInfoPtr_set_Scheduler_Private_set_Void_ServicePointScheduler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000AD6 RID: 2774
		// (get) Token: 0x06002252 RID: 8786 RVA: 0x000A0C6C File Offset: 0x0009EE6C
		public unsafe Uri Address
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePoint.NativeMethodInfoPtr_get_Address_Public_get_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
			}
		}

		// Token: 0x17000AD7 RID: 2775
		// (get) Token: 0x06002253 RID: 8787 RVA: 0x000A0CAC File Offset: 0x0009EEAC
		public unsafe int ConnectionLimit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePoint.NativeMethodInfoPtr_get_ConnectionLimit_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AD8 RID: 2776
		// (get) Token: 0x06002254 RID: 8788 RVA: 0x000A0CE8 File Offset: 0x0009EEE8
		public unsafe virtual Version ProtocolVersion
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ServicePoint.NativeMethodInfoPtr_get_ProtocolVersion_Public_Virtual_New_get_Version_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Version>(intPtr3) : null;
			}
		}

		// Token: 0x17000AD9 RID: 2777
		// (set) Token: 0x06002255 RID: 8789 RVA: 0x000A0D34 File Offset: 0x0009EF34
		public unsafe bool Expect100Continue
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 483221, RefRangeEnd = 483222, XrefRangeStart = 483221, XrefRangeEnd = 483221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePoint.NativeMethodInfoPtr_set_Expect100Continue_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000ADA RID: 2778
		// (get) Token: 0x06002256 RID: 8790 RVA: 0x000A0D74 File Offset: 0x0009EF74
		// (set) Token: 0x06002257 RID: 8791 RVA: 0x000A0DB0 File Offset: 0x0009EFB0
		public unsafe bool UseNagleAlgorithm
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePoint.NativeMethodInfoPtr_get_UseNagleAlgorithm_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePoint.NativeMethodInfoPtr_set_UseNagleAlgorithm_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000ADB RID: 2779
		// (get) Token: 0x06002258 RID: 8792 RVA: 0x000A0DF0 File Offset: 0x0009EFF0
		// (set) Token: 0x06002259 RID: 8793 RVA: 0x000A0E2C File Offset: 0x0009F02C
		public unsafe bool SendContinue
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 483223, RefRangeEnd = 483224, XrefRangeStart = 483222, XrefRangeEnd = 483223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePoint.NativeMethodInfoPtr_get_SendContinue_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 483221, RefRangeEnd = 483222, XrefRangeStart = 483221, XrefRangeEnd = 483222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePoint.NativeMethodInfoPtr_set_SendContinue_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600225A RID: 8794 RVA: 0x000A0E6C File Offset: 0x0009F06C
		[CallerCount(0)]
		public unsafe void SetTcpKeepAlive(bool enabled, int keepAliveTime, int keepAliveInterval)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref enabled;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keepAliveTime;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keepAliveInterval;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePoint.NativeMethodInfoPtr_SetTcpKeepAlive_Public_Void_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600225B RID: 8795 RVA: 0x000A0EC8 File Offset: 0x0009F0C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 483224, XrefRangeEnd = 483228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void KeepAliveSetup(Socket socket)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(socket);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePoint.NativeMethodInfoPtr_KeepAliveSetup_Internal_Void_Socket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600225C RID: 8796 RVA: 0x000A0F0C File Offset: 0x0009F10C
		[CallerCount(0)]
		public unsafe static void PutBytes(Il2CppStructArray<byte> bytes, uint v, int offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref v;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePoint.NativeMethodInfoPtr_PutBytes_Private_Static_Void_Il2CppStructArray_1_Byte_UInt32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000ADC RID: 2780
		// (get) Token: 0x0600225D RID: 8797 RVA: 0x000A0F60 File Offset: 0x0009F160
		// (set) Token: 0x0600225E RID: 8798 RVA: 0x000A0F9C File Offset: 0x0009F19C
		public unsafe bool UsesProxy
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePoint.NativeMethodInfoPtr_get_UsesProxy_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePoint.NativeMethodInfoPtr_set_UsesProxy_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000ADD RID: 2781
		// (get) Token: 0x0600225F RID: 8799 RVA: 0x000A0FDC File Offset: 0x0009F1DC
		// (set) Token: 0x06002260 RID: 8800 RVA: 0x000A1018 File Offset: 0x0009F218
		public unsafe bool UseConnect
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePoint.NativeMethodInfoPtr_get_UseConnect_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePoint.NativeMethodInfoPtr_set_UseConnect_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000ADE RID: 2782
		// (get) Token: 0x06002261 RID: 8801 RVA: 0x000A1058 File Offset: 0x0009F258
		public unsafe bool HasTimedOut
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 483228, XrefRangeEnd = 483237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePoint.NativeMethodInfoPtr_get_HasTimedOut_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000ADF RID: 2783
		// (get) Token: 0x06002262 RID: 8802 RVA: 0x000A1094 File Offset: 0x0009F294
		public unsafe IPHostEntry HostEntry
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 483290, RefRangeEnd = 483291, XrefRangeStart = 483237, XrefRangeEnd = 483290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePoint.NativeMethodInfoPtr_get_HostEntry_Internal_get_IPHostEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPHostEntry>(intPtr3) : null;
			}
		}

		// Token: 0x06002263 RID: 8803 RVA: 0x000A10D4 File Offset: 0x0009F2D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVersion(Version version)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(version);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePoint.NativeMethodInfoPtr_SetVersion_Internal_Void_Version_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002264 RID: 8804 RVA: 0x000A1118 File Offset: 0x0009F318
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 483296, RefRangeEnd = 483297, XrefRangeStart = 483291, XrefRangeEnd = 483296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendRequest(WebOperation operation, string groupName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(operation);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(groupName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePoint.NativeMethodInfoPtr_SendRequest_Internal_Void_WebOperation_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002265 RID: 8805 RVA: 0x000A116C File Offset: 0x0009F36C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 483318, RefRangeEnd = 483319, XrefRangeStart = 483297, XrefRangeEnd = 483318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CloseConnectionGroup(string connectionGroupName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(connectionGroupName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePoint.NativeMethodInfoPtr_CloseConnectionGroup_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002266 RID: 8806 RVA: 0x000A11BC File Offset: 0x0009F3BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 483319, XrefRangeEnd = 483320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FreeServicePoint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePoint.NativeMethodInfoPtr_FreeServicePoint_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002267 RID: 8807 RVA: 0x000A11F0 File Offset: 0x0009F3F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 483322, RefRangeEnd = 483323, XrefRangeStart = 483320, XrefRangeEnd = 483322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateServerCertificate(X509Certificate certificate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(certificate);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePoint.NativeMethodInfoPtr_UpdateServerCertificate_Internal_Void_X509Certificate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002268 RID: 8808 RVA: 0x000A1234 File Offset: 0x0009F434
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 483325, RefRangeEnd = 483326, XrefRangeStart = 483323, XrefRangeEnd = 483325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateClientCertificate(X509Certificate certificate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(certificate);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePoint.NativeMethodInfoPtr_UpdateClientCertificate_Internal_Void_X509Certificate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002269 RID: 8809 RVA: 0x000A1278 File Offset: 0x0009F478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 483326, XrefRangeEnd = 483329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CallEndPointDelegate(Socket sock, IPEndPoint remote)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sock);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(remote);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePoint.NativeMethodInfoPtr_CallEndPointDelegate_Internal_Boolean_Socket_IPEndPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600226A RID: 8810 RVA: 0x0000ED17 File Offset: 0x0000CF17
		public ServicePoint(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000ABE RID: 2750
		// (get) Token: 0x0600226B RID: 8811 RVA: 0x000A12D8 File Offset: 0x0009F4D8
		// (set) Token: 0x0600226C RID: 8812 RVA: 0x0000ED20 File Offset: 0x0000CF20
		public unsafe Uri uri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_uri);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_uri), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ABF RID: 2751
		// (get) Token: 0x0600226D RID: 8813 RVA: 0x000A1308 File Offset: 0x0009F508
		// (set) Token: 0x0600226E RID: 8814 RVA: 0x0000ED3F File Offset: 0x0000CF3F
		public unsafe DateTime lastDnsResolve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_lastDnsResolve);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_lastDnsResolve)) = value;
			}
		}

		// Token: 0x17000AC0 RID: 2752
		// (get) Token: 0x0600226F RID: 8815 RVA: 0x000A1330 File Offset: 0x0009F530
		// (set) Token: 0x06002270 RID: 8816 RVA: 0x0000ED5A File Offset: 0x0000CF5A
		public unsafe Version protocolVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_protocolVersion);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Version>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_protocolVersion), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AC1 RID: 2753
		// (get) Token: 0x06002271 RID: 8817 RVA: 0x000A1360 File Offset: 0x0009F560
		// (set) Token: 0x06002272 RID: 8818 RVA: 0x0000ED79 File Offset: 0x0000CF79
		public unsafe IPHostEntry host
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_host);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPHostEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_host), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AC2 RID: 2754
		// (get) Token: 0x06002273 RID: 8819 RVA: 0x000A1390 File Offset: 0x0009F590
		// (set) Token: 0x06002274 RID: 8820 RVA: 0x0000ED98 File Offset: 0x0000CF98
		public unsafe bool usesProxy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_usesProxy);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_usesProxy)) = value;
			}
		}

		// Token: 0x17000AC3 RID: 2755
		// (get) Token: 0x06002275 RID: 8821 RVA: 0x000A13B8 File Offset: 0x0009F5B8
		// (set) Token: 0x06002276 RID: 8822 RVA: 0x0000EDB3 File Offset: 0x0000CFB3
		public unsafe bool sendContinue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_sendContinue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_sendContinue)) = value;
			}
		}

		// Token: 0x17000AC4 RID: 2756
		// (get) Token: 0x06002277 RID: 8823 RVA: 0x000A13E0 File Offset: 0x0009F5E0
		// (set) Token: 0x06002278 RID: 8824 RVA: 0x0000EDCE File Offset: 0x0000CFCE
		public unsafe bool useConnect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_useConnect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_useConnect)) = value;
			}
		}

		// Token: 0x17000AC5 RID: 2757
		// (get) Token: 0x06002279 RID: 8825 RVA: 0x000A1408 File Offset: 0x0009F608
		// (set) Token: 0x0600227A RID: 8826 RVA: 0x0000EDE9 File Offset: 0x0000CFE9
		public unsafe Object hostE
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_hostE);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_hostE), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AC6 RID: 2758
		// (get) Token: 0x0600227B RID: 8827 RVA: 0x000A1438 File Offset: 0x0009F638
		// (set) Token: 0x0600227C RID: 8828 RVA: 0x0000EE08 File Offset: 0x0000D008
		public unsafe bool useNagle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_useNagle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_useNagle)) = value;
			}
		}

		// Token: 0x17000AC7 RID: 2759
		// (get) Token: 0x0600227D RID: 8829 RVA: 0x000A1460 File Offset: 0x0009F660
		// (set) Token: 0x0600227E RID: 8830 RVA: 0x0000EE23 File Offset: 0x0000D023
		public unsafe BindIPEndPoint endPointCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_endPointCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BindIPEndPoint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_endPointCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AC8 RID: 2760
		// (get) Token: 0x0600227F RID: 8831 RVA: 0x000A1490 File Offset: 0x0009F690
		// (set) Token: 0x06002280 RID: 8832 RVA: 0x0000EE42 File Offset: 0x0000D042
		public unsafe bool tcp_keepalive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_tcp_keepalive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_tcp_keepalive)) = value;
			}
		}

		// Token: 0x17000AC9 RID: 2761
		// (get) Token: 0x06002281 RID: 8833 RVA: 0x000A14B8 File Offset: 0x0009F6B8
		// (set) Token: 0x06002282 RID: 8834 RVA: 0x0000EE5D File Offset: 0x0000D05D
		public unsafe int tcp_keepalive_time
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_tcp_keepalive_time);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_tcp_keepalive_time)) = value;
			}
		}

		// Token: 0x17000ACA RID: 2762
		// (get) Token: 0x06002283 RID: 8835 RVA: 0x000A14E0 File Offset: 0x0009F6E0
		// (set) Token: 0x06002284 RID: 8836 RVA: 0x0000EE78 File Offset: 0x0000D078
		public unsafe int tcp_keepalive_interval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_tcp_keepalive_interval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_tcp_keepalive_interval)) = value;
			}
		}

		// Token: 0x17000ACB RID: 2763
		// (get) Token: 0x06002285 RID: 8837 RVA: 0x000A1508 File Offset: 0x0009F708
		// (set) Token: 0x06002286 RID: 8838 RVA: 0x0000EE93 File Offset: 0x0000D093
		public unsafe bool disposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_disposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_disposed)) = value;
			}
		}

		// Token: 0x17000ACC RID: 2764
		// (get) Token: 0x06002287 RID: 8839 RVA: 0x000A1530 File Offset: 0x0009F730
		// (set) Token: 0x06002288 RID: 8840 RVA: 0x0000EEAE File Offset: 0x0000D0AE
		public unsafe int connectionLeaseTimeout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_connectionLeaseTimeout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_connectionLeaseTimeout)) = value;
			}
		}

		// Token: 0x17000ACD RID: 2765
		// (get) Token: 0x06002289 RID: 8841 RVA: 0x000A1558 File Offset: 0x0009F758
		// (set) Token: 0x0600228A RID: 8842 RVA: 0x0000EEC9 File Offset: 0x0000D0C9
		public unsafe int receiveBufferSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_receiveBufferSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_receiveBufferSize)) = value;
			}
		}

		// Token: 0x17000ACE RID: 2766
		// (get) Token: 0x0600228B RID: 8843 RVA: 0x000A1580 File Offset: 0x0009F780
		// (set) Token: 0x0600228C RID: 8844 RVA: 0x0000EEE4 File Offset: 0x0000D0E4
		public unsafe ServicePointManager.SPKey _Key_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr__Key_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServicePointManager.SPKey>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr__Key_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ACF RID: 2767
		// (get) Token: 0x0600228D RID: 8845 RVA: 0x000A15B0 File Offset: 0x0009F7B0
		// (set) Token: 0x0600228E RID: 8846 RVA: 0x0000EF03 File Offset: 0x0000D103
		public unsafe ServicePointScheduler _Scheduler_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr__Scheduler_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServicePointScheduler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr__Scheduler_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AD0 RID: 2768
		// (get) Token: 0x0600228F RID: 8847 RVA: 0x000A15E0 File Offset: 0x0009F7E0
		// (set) Token: 0x06002290 RID: 8848 RVA: 0x0000EF22 File Offset: 0x0000D122
		public unsafe int connectionLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_connectionLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_connectionLimit)) = value;
			}
		}

		// Token: 0x17000AD1 RID: 2769
		// (get) Token: 0x06002291 RID: 8849 RVA: 0x000A1608 File Offset: 0x0009F808
		// (set) Token: 0x06002292 RID: 8850 RVA: 0x0000EF3D File Offset: 0x0000D13D
		public unsafe int maxIdleTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_maxIdleTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_maxIdleTime)) = value;
			}
		}

		// Token: 0x17000AD2 RID: 2770
		// (get) Token: 0x06002293 RID: 8851 RVA: 0x000A1630 File Offset: 0x0009F830
		// (set) Token: 0x06002294 RID: 8852 RVA: 0x0000EF58 File Offset: 0x0000D158
		public unsafe Object m_ServerCertificateOrBytes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_m_ServerCertificateOrBytes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_m_ServerCertificateOrBytes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AD3 RID: 2771
		// (get) Token: 0x06002295 RID: 8853 RVA: 0x000A1660 File Offset: 0x0009F860
		// (set) Token: 0x06002296 RID: 8854 RVA: 0x0000EF77 File Offset: 0x0000D177
		public unsafe Object m_ClientCertificateOrBytes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_m_ClientCertificateOrBytes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_m_ClientCertificateOrBytes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001AB5 RID: 6837
		private static readonly IntPtr NativeFieldInfoPtr_uri;

		// Token: 0x04001AB6 RID: 6838
		private static readonly IntPtr NativeFieldInfoPtr_lastDnsResolve;

		// Token: 0x04001AB7 RID: 6839
		private static readonly IntPtr NativeFieldInfoPtr_protocolVersion;

		// Token: 0x04001AB8 RID: 6840
		private static readonly IntPtr NativeFieldInfoPtr_host;

		// Token: 0x04001AB9 RID: 6841
		private static readonly IntPtr NativeFieldInfoPtr_usesProxy;

		// Token: 0x04001ABA RID: 6842
		private static readonly IntPtr NativeFieldInfoPtr_sendContinue;

		// Token: 0x04001ABB RID: 6843
		private static readonly IntPtr NativeFieldInfoPtr_useConnect;

		// Token: 0x04001ABC RID: 6844
		private static readonly IntPtr NativeFieldInfoPtr_hostE;

		// Token: 0x04001ABD RID: 6845
		private static readonly IntPtr NativeFieldInfoPtr_useNagle;

		// Token: 0x04001ABE RID: 6846
		private static readonly IntPtr NativeFieldInfoPtr_endPointCallback;

		// Token: 0x04001ABF RID: 6847
		private static readonly IntPtr NativeFieldInfoPtr_tcp_keepalive;

		// Token: 0x04001AC0 RID: 6848
		private static readonly IntPtr NativeFieldInfoPtr_tcp_keepalive_time;

		// Token: 0x04001AC1 RID: 6849
		private static readonly IntPtr NativeFieldInfoPtr_tcp_keepalive_interval;

		// Token: 0x04001AC2 RID: 6850
		private static readonly IntPtr NativeFieldInfoPtr_disposed;

		// Token: 0x04001AC3 RID: 6851
		private static readonly IntPtr NativeFieldInfoPtr_connectionLeaseTimeout;

		// Token: 0x04001AC4 RID: 6852
		private static readonly IntPtr NativeFieldInfoPtr_receiveBufferSize;

		// Token: 0x04001AC5 RID: 6853
		private static readonly IntPtr NativeFieldInfoPtr__Key_k__BackingField;

		// Token: 0x04001AC6 RID: 6854
		private static readonly IntPtr NativeFieldInfoPtr__Scheduler_k__BackingField;

		// Token: 0x04001AC7 RID: 6855
		private static readonly IntPtr NativeFieldInfoPtr_connectionLimit;

		// Token: 0x04001AC8 RID: 6856
		private static readonly IntPtr NativeFieldInfoPtr_maxIdleTime;

		// Token: 0x04001AC9 RID: 6857
		private static readonly IntPtr NativeFieldInfoPtr_m_ServerCertificateOrBytes;

		// Token: 0x04001ACA RID: 6858
		private static readonly IntPtr NativeFieldInfoPtr_m_ClientCertificateOrBytes;

		// Token: 0x04001ACB RID: 6859
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SPKey_Uri_Int32_Int32_0;

		// Token: 0x04001ACC RID: 6860
		private static readonly IntPtr NativeMethodInfoPtr_get_Key_Internal_get_SPKey_0;

		// Token: 0x04001ACD RID: 6861
		private static readonly IntPtr NativeMethodInfoPtr_get_Scheduler_Private_get_ServicePointScheduler_0;

		// Token: 0x04001ACE RID: 6862
		private static readonly IntPtr NativeMethodInfoPtr_set_Scheduler_Private_set_Void_ServicePointScheduler_0;

		// Token: 0x04001ACF RID: 6863
		private static readonly IntPtr NativeMethodInfoPtr_get_Address_Public_get_Uri_0;

		// Token: 0x04001AD0 RID: 6864
		private static readonly IntPtr NativeMethodInfoPtr_get_ConnectionLimit_Public_get_Int32_0;

		// Token: 0x04001AD1 RID: 6865
		private static readonly IntPtr NativeMethodInfoPtr_get_ProtocolVersion_Public_Virtual_New_get_Version_0;

		// Token: 0x04001AD2 RID: 6866
		private static readonly IntPtr NativeMethodInfoPtr_set_Expect100Continue_Public_set_Void_Boolean_0;

		// Token: 0x04001AD3 RID: 6867
		private static readonly IntPtr NativeMethodInfoPtr_get_UseNagleAlgorithm_Public_get_Boolean_0;

		// Token: 0x04001AD4 RID: 6868
		private static readonly IntPtr NativeMethodInfoPtr_set_UseNagleAlgorithm_Public_set_Void_Boolean_0;

		// Token: 0x04001AD5 RID: 6869
		private static readonly IntPtr NativeMethodInfoPtr_get_SendContinue_Internal_get_Boolean_0;

		// Token: 0x04001AD6 RID: 6870
		private static readonly IntPtr NativeMethodInfoPtr_set_SendContinue_Internal_set_Void_Boolean_0;

		// Token: 0x04001AD7 RID: 6871
		private static readonly IntPtr NativeMethodInfoPtr_SetTcpKeepAlive_Public_Void_Boolean_Int32_Int32_0;

		// Token: 0x04001AD8 RID: 6872
		private static readonly IntPtr NativeMethodInfoPtr_KeepAliveSetup_Internal_Void_Socket_0;

		// Token: 0x04001AD9 RID: 6873
		private static readonly IntPtr NativeMethodInfoPtr_PutBytes_Private_Static_Void_Il2CppStructArray_1_Byte_UInt32_Int32_0;

		// Token: 0x04001ADA RID: 6874
		private static readonly IntPtr NativeMethodInfoPtr_get_UsesProxy_Internal_get_Boolean_0;

		// Token: 0x04001ADB RID: 6875
		private static readonly IntPtr NativeMethodInfoPtr_set_UsesProxy_Internal_set_Void_Boolean_0;

		// Token: 0x04001ADC RID: 6876
		private static readonly IntPtr NativeMethodInfoPtr_get_UseConnect_Internal_get_Boolean_0;

		// Token: 0x04001ADD RID: 6877
		private static readonly IntPtr NativeMethodInfoPtr_set_UseConnect_Internal_set_Void_Boolean_0;

		// Token: 0x04001ADE RID: 6878
		private static readonly IntPtr NativeMethodInfoPtr_get_HasTimedOut_Private_get_Boolean_0;

		// Token: 0x04001ADF RID: 6879
		private static readonly IntPtr NativeMethodInfoPtr_get_HostEntry_Internal_get_IPHostEntry_0;

		// Token: 0x04001AE0 RID: 6880
		private static readonly IntPtr NativeMethodInfoPtr_SetVersion_Internal_Void_Version_0;

		// Token: 0x04001AE1 RID: 6881
		private static readonly IntPtr NativeMethodInfoPtr_SendRequest_Internal_Void_WebOperation_String_0;

		// Token: 0x04001AE2 RID: 6882
		private static readonly IntPtr NativeMethodInfoPtr_CloseConnectionGroup_Public_Boolean_String_0;

		// Token: 0x04001AE3 RID: 6883
		private static readonly IntPtr NativeMethodInfoPtr_FreeServicePoint_Internal_Void_0;

		// Token: 0x04001AE4 RID: 6884
		private static readonly IntPtr NativeMethodInfoPtr_UpdateServerCertificate_Internal_Void_X509Certificate_0;

		// Token: 0x04001AE5 RID: 6885
		private static readonly IntPtr NativeMethodInfoPtr_UpdateClientCertificate_Internal_Void_X509Certificate_0;

		// Token: 0x04001AE6 RID: 6886
		private static readonly IntPtr NativeMethodInfoPtr_CallEndPointDelegate_Internal_Boolean_Socket_IPEndPoint_0;
	}
}
