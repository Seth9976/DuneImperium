using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Concurrent;
using Il2CppSystem.Net.Security;

namespace Il2CppSystem.Net
{
	// Token: 0x0200020D RID: 525
	public class ServicePointManager : Object
	{
		// Token: 0x06002297 RID: 8855 RVA: 0x000A1690 File Offset: 0x0009F890
		// Note: this type is marked as 'beforefieldinit'.
		static ServicePointManager()
		{
			Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "ServicePointManager");
			ServicePointManager.NativeFieldInfoPtr_servicePoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, "servicePoints");
			ServicePointManager.NativeFieldInfoPtr_policy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, "policy");
			ServicePointManager.NativeFieldInfoPtr_defaultConnectionLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, "defaultConnectionLimit");
			ServicePointManager.NativeFieldInfoPtr_maxServicePointIdleTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, "maxServicePointIdleTime");
			ServicePointManager.NativeFieldInfoPtr_maxServicePoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, "maxServicePoints");
			ServicePointManager.NativeFieldInfoPtr_dnsRefreshTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, "dnsRefreshTimeout");
			ServicePointManager.NativeFieldInfoPtr__checkCRL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, "_checkCRL");
			ServicePointManager.NativeFieldInfoPtr__securityProtocol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, "_securityProtocol");
			ServicePointManager.NativeFieldInfoPtr_expectContinue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, "expectContinue");
			ServicePointManager.NativeFieldInfoPtr_useNagle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, "useNagle");
			ServicePointManager.NativeFieldInfoPtr_server_cert_cb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, "server_cert_cb");
			ServicePointManager.NativeFieldInfoPtr_tcp_keepalive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, "tcp_keepalive");
			ServicePointManager.NativeFieldInfoPtr_tcp_keepalive_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, "tcp_keepalive_time");
			ServicePointManager.NativeFieldInfoPtr_tcp_keepalive_interval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, "tcp_keepalive_interval");
			ServicePointManager.NativeMethodInfoPtr_GetLegacyCertificatePolicy_Internal_Static_ICertificatePolicy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, 100668425);
			ServicePointManager.NativeMethodInfoPtr_get_CheckCertificateRevocationList_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, 100668426);
			ServicePointManager.NativeMethodInfoPtr_get_DnsRefreshTimeout_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, 100668427);
			ServicePointManager.NativeMethodInfoPtr_get_SecurityProtocol_Public_Static_get_SecurityProtocolType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, 100668428);
			ServicePointManager.NativeMethodInfoPtr_get_ServerCertValidationCallback_Internal_Static_get_ServerCertValidationCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, 100668429);
			ServicePointManager.NativeMethodInfoPtr_get_ServerCertificateValidationCallback_Public_Static_get_RemoteCertificateValidationCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, 100668430);
			ServicePointManager.NativeMethodInfoPtr_set_ServerCertificateValidationCallback_Public_Static_set_Void_RemoteCertificateValidationCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, 100668431);
			ServicePointManager.NativeMethodInfoPtr_FindServicePoint_Public_Static_ServicePoint_Uri_IWebProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, 100668432);
			ServicePointManager.NativeMethodInfoPtr_CloseConnectionGroup_Internal_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, 100668433);
			ServicePointManager.NativeMethodInfoPtr_RemoveServicePoint_Internal_Static_Void_ServicePoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, 100668434);
		}

		// Token: 0x06002298 RID: 8856 RVA: 0x000A1898 File Offset: 0x0009FA98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 483347, XrefRangeEnd = 483351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ICertificatePolicy GetLegacyCertificatePolicy()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointManager.NativeMethodInfoPtr_GetLegacyCertificatePolicy_Internal_Static_ICertificatePolicy_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICertificatePolicy>(intPtr3) : null;
		}

		// Token: 0x17000AEE RID: 2798
		// (get) Token: 0x06002299 RID: 8857 RVA: 0x000A18CC File Offset: 0x0009FACC
		public unsafe static bool CheckCertificateRevocationList
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 483351, XrefRangeEnd = 483355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointManager.NativeMethodInfoPtr_get_CheckCertificateRevocationList_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AEF RID: 2799
		// (get) Token: 0x0600229A RID: 8858 RVA: 0x000A18FC File Offset: 0x0009FAFC
		public unsafe static int DnsRefreshTimeout
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 483355, XrefRangeEnd = 483359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointManager.NativeMethodInfoPtr_get_DnsRefreshTimeout_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AF0 RID: 2800
		// (get) Token: 0x0600229B RID: 8859 RVA: 0x000A192C File Offset: 0x0009FB2C
		public unsafe static SecurityProtocolType SecurityProtocol
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 483359, XrefRangeEnd = 483363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointManager.NativeMethodInfoPtr_get_SecurityProtocol_Public_Static_get_SecurityProtocolType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AF1 RID: 2801
		// (get) Token: 0x0600229C RID: 8860 RVA: 0x000A195C File Offset: 0x0009FB5C
		public unsafe static ServerCertValidationCallback ServerCertValidationCallback
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 483363, XrefRangeEnd = 483367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointManager.NativeMethodInfoPtr_get_ServerCertValidationCallback_Internal_Static_get_ServerCertValidationCallback_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServerCertValidationCallback>(intPtr3) : null;
			}
		}

		// Token: 0x17000AF2 RID: 2802
		// (get) Token: 0x0600229D RID: 8861 RVA: 0x000A1990 File Offset: 0x0009FB90
		// (set) Token: 0x0600229E RID: 8862 RVA: 0x000A19C4 File Offset: 0x0009FBC4
		public unsafe static RemoteCertificateValidationCallback ServerCertificateValidationCallback
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 483373, RefRangeEnd = 483375, XrefRangeStart = 483367, XrefRangeEnd = 483373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointManager.NativeMethodInfoPtr_get_ServerCertificateValidationCallback_Public_Static_get_RemoteCertificateValidationCallback_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RemoteCertificateValidationCallback>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 483389, RefRangeEnd = 483390, XrefRangeStart = 483375, XrefRangeEnd = 483389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointManager.NativeMethodInfoPtr_set_ServerCertificateValidationCallback_Public_Static_set_Void_RemoteCertificateValidationCallback_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600229F RID: 8863 RVA: 0x000A19FC File Offset: 0x0009FBFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 483483, RefRangeEnd = 483484, XrefRangeStart = 483390, XrefRangeEnd = 483483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ServicePoint FindServicePoint(Uri address, IWebProxy proxy)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(address);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(proxy);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointManager.NativeMethodInfoPtr_FindServicePoint_Public_Static_ServicePoint_Uri_IWebProxy_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServicePoint>(intPtr3) : null;
		}

		// Token: 0x060022A0 RID: 8864 RVA: 0x000A1A54 File Offset: 0x0009FC54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 483515, RefRangeEnd = 483516, XrefRangeStart = 483484, XrefRangeEnd = 483515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CloseConnectionGroup(string connectionGroupName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(connectionGroupName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointManager.NativeMethodInfoPtr_CloseConnectionGroup_Internal_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060022A1 RID: 8865 RVA: 0x000A1A8C File Offset: 0x0009FC8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 483516, XrefRangeEnd = 483523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoveServicePoint(ServicePoint sp)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointManager.NativeMethodInfoPtr_RemoveServicePoint_Internal_Static_Void_ServicePoint_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060022A2 RID: 8866 RVA: 0x0000EF96 File Offset: 0x0000D196
		public ServicePointManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000AE0 RID: 2784
		// (get) Token: 0x060022A3 RID: 8867 RVA: 0x000A1AC4 File Offset: 0x0009FCC4
		// (set) Token: 0x060022A4 RID: 8868 RVA: 0x0000EF9F File Offset: 0x0000D19F
		public unsafe static ConcurrentDictionary<ServicePointManager.SPKey, ServicePoint> servicePoints
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ServicePointManager.NativeFieldInfoPtr_servicePoints, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConcurrentDictionary<ServicePointManager.SPKey, ServicePoint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ServicePointManager.NativeFieldInfoPtr_servicePoints, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AE1 RID: 2785
		// (get) Token: 0x060022A5 RID: 8869 RVA: 0x000A1AEC File Offset: 0x0009FCEC
		// (set) Token: 0x060022A6 RID: 8870 RVA: 0x0000EFB1 File Offset: 0x0000D1B1
		public unsafe static ICertificatePolicy policy
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ServicePointManager.NativeFieldInfoPtr_policy, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ICertificatePolicy>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ServicePointManager.NativeFieldInfoPtr_policy, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AE2 RID: 2786
		// (get) Token: 0x060022A7 RID: 8871 RVA: 0x000A1B14 File Offset: 0x0009FD14
		// (set) Token: 0x060022A8 RID: 8872 RVA: 0x0000EFC3 File Offset: 0x0000D1C3
		public unsafe static int defaultConnectionLimit
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ServicePointManager.NativeFieldInfoPtr_defaultConnectionLimit, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ServicePointManager.NativeFieldInfoPtr_defaultConnectionLimit, (void*)(&value));
			}
		}

		// Token: 0x17000AE3 RID: 2787
		// (get) Token: 0x060022A9 RID: 8873 RVA: 0x000A1B30 File Offset: 0x0009FD30
		// (set) Token: 0x060022AA RID: 8874 RVA: 0x0000EFD1 File Offset: 0x0000D1D1
		public unsafe static int maxServicePointIdleTime
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ServicePointManager.NativeFieldInfoPtr_maxServicePointIdleTime, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ServicePointManager.NativeFieldInfoPtr_maxServicePointIdleTime, (void*)(&value));
			}
		}

		// Token: 0x17000AE4 RID: 2788
		// (get) Token: 0x060022AB RID: 8875 RVA: 0x000A1B4C File Offset: 0x0009FD4C
		// (set) Token: 0x060022AC RID: 8876 RVA: 0x0000EFDF File Offset: 0x0000D1DF
		public unsafe static int maxServicePoints
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ServicePointManager.NativeFieldInfoPtr_maxServicePoints, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ServicePointManager.NativeFieldInfoPtr_maxServicePoints, (void*)(&value));
			}
		}

		// Token: 0x17000AE5 RID: 2789
		// (get) Token: 0x060022AD RID: 8877 RVA: 0x000A1B68 File Offset: 0x0009FD68
		// (set) Token: 0x060022AE RID: 8878 RVA: 0x0000EFED File Offset: 0x0000D1ED
		public unsafe static int dnsRefreshTimeout
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ServicePointManager.NativeFieldInfoPtr_dnsRefreshTimeout, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ServicePointManager.NativeFieldInfoPtr_dnsRefreshTimeout, (void*)(&value));
			}
		}

		// Token: 0x17000AE6 RID: 2790
		// (get) Token: 0x060022AF RID: 8879 RVA: 0x000A1B84 File Offset: 0x0009FD84
		// (set) Token: 0x060022B0 RID: 8880 RVA: 0x0000EFFB File Offset: 0x0000D1FB
		public unsafe static bool _checkCRL
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(ServicePointManager.NativeFieldInfoPtr__checkCRL, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ServicePointManager.NativeFieldInfoPtr__checkCRL, (void*)(&value));
			}
		}

		// Token: 0x17000AE7 RID: 2791
		// (get) Token: 0x060022B1 RID: 8881 RVA: 0x000A1BA0 File Offset: 0x0009FDA0
		// (set) Token: 0x060022B2 RID: 8882 RVA: 0x0000F009 File Offset: 0x0000D209
		public unsafe static SecurityProtocolType _securityProtocol
		{
			get
			{
				SecurityProtocolType securityProtocolType;
				IL2CPP.il2cpp_field_static_get_value(ServicePointManager.NativeFieldInfoPtr__securityProtocol, (void*)(&securityProtocolType));
				return securityProtocolType;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ServicePointManager.NativeFieldInfoPtr__securityProtocol, (void*)(&value));
			}
		}

		// Token: 0x17000AE8 RID: 2792
		// (get) Token: 0x060022B3 RID: 8883 RVA: 0x000A1BBC File Offset: 0x0009FDBC
		// (set) Token: 0x060022B4 RID: 8884 RVA: 0x0000F017 File Offset: 0x0000D217
		public unsafe static bool expectContinue
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(ServicePointManager.NativeFieldInfoPtr_expectContinue, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ServicePointManager.NativeFieldInfoPtr_expectContinue, (void*)(&value));
			}
		}

		// Token: 0x17000AE9 RID: 2793
		// (get) Token: 0x060022B5 RID: 8885 RVA: 0x000A1BD8 File Offset: 0x0009FDD8
		// (set) Token: 0x060022B6 RID: 8886 RVA: 0x0000F025 File Offset: 0x0000D225
		public unsafe static bool useNagle
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(ServicePointManager.NativeFieldInfoPtr_useNagle, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ServicePointManager.NativeFieldInfoPtr_useNagle, (void*)(&value));
			}
		}

		// Token: 0x17000AEA RID: 2794
		// (get) Token: 0x060022B7 RID: 8887 RVA: 0x000A1BF4 File Offset: 0x0009FDF4
		// (set) Token: 0x060022B8 RID: 8888 RVA: 0x0000F033 File Offset: 0x0000D233
		public unsafe static ServerCertValidationCallback server_cert_cb
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ServicePointManager.NativeFieldInfoPtr_server_cert_cb, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServerCertValidationCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ServicePointManager.NativeFieldInfoPtr_server_cert_cb, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AEB RID: 2795
		// (get) Token: 0x060022B9 RID: 8889 RVA: 0x000A1C1C File Offset: 0x0009FE1C
		// (set) Token: 0x060022BA RID: 8890 RVA: 0x0000F045 File Offset: 0x0000D245
		public unsafe static bool tcp_keepalive
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(ServicePointManager.NativeFieldInfoPtr_tcp_keepalive, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ServicePointManager.NativeFieldInfoPtr_tcp_keepalive, (void*)(&value));
			}
		}

		// Token: 0x17000AEC RID: 2796
		// (get) Token: 0x060022BB RID: 8891 RVA: 0x000A1C38 File Offset: 0x0009FE38
		// (set) Token: 0x060022BC RID: 8892 RVA: 0x0000F053 File Offset: 0x0000D253
		public unsafe static int tcp_keepalive_time
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ServicePointManager.NativeFieldInfoPtr_tcp_keepalive_time, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ServicePointManager.NativeFieldInfoPtr_tcp_keepalive_time, (void*)(&value));
			}
		}

		// Token: 0x17000AED RID: 2797
		// (get) Token: 0x060022BD RID: 8893 RVA: 0x000A1C54 File Offset: 0x0009FE54
		// (set) Token: 0x060022BE RID: 8894 RVA: 0x0000F061 File Offset: 0x0000D261
		public unsafe static int tcp_keepalive_interval
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ServicePointManager.NativeFieldInfoPtr_tcp_keepalive_interval, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ServicePointManager.NativeFieldInfoPtr_tcp_keepalive_interval, (void*)(&value));
			}
		}

		// Token: 0x04001AE7 RID: 6887
		private static readonly IntPtr NativeFieldInfoPtr_servicePoints;

		// Token: 0x04001AE8 RID: 6888
		private static readonly IntPtr NativeFieldInfoPtr_policy;

		// Token: 0x04001AE9 RID: 6889
		private static readonly IntPtr NativeFieldInfoPtr_defaultConnectionLimit;

		// Token: 0x04001AEA RID: 6890
		private static readonly IntPtr NativeFieldInfoPtr_maxServicePointIdleTime;

		// Token: 0x04001AEB RID: 6891
		private static readonly IntPtr NativeFieldInfoPtr_maxServicePoints;

		// Token: 0x04001AEC RID: 6892
		private static readonly IntPtr NativeFieldInfoPtr_dnsRefreshTimeout;

		// Token: 0x04001AED RID: 6893
		private static readonly IntPtr NativeFieldInfoPtr__checkCRL;

		// Token: 0x04001AEE RID: 6894
		private static readonly IntPtr NativeFieldInfoPtr__securityProtocol;

		// Token: 0x04001AEF RID: 6895
		private static readonly IntPtr NativeFieldInfoPtr_expectContinue;

		// Token: 0x04001AF0 RID: 6896
		private static readonly IntPtr NativeFieldInfoPtr_useNagle;

		// Token: 0x04001AF1 RID: 6897
		private static readonly IntPtr NativeFieldInfoPtr_server_cert_cb;

		// Token: 0x04001AF2 RID: 6898
		private static readonly IntPtr NativeFieldInfoPtr_tcp_keepalive;

		// Token: 0x04001AF3 RID: 6899
		private static readonly IntPtr NativeFieldInfoPtr_tcp_keepalive_time;

		// Token: 0x04001AF4 RID: 6900
		private static readonly IntPtr NativeFieldInfoPtr_tcp_keepalive_interval;

		// Token: 0x04001AF5 RID: 6901
		private static readonly IntPtr NativeMethodInfoPtr_GetLegacyCertificatePolicy_Internal_Static_ICertificatePolicy_0;

		// Token: 0x04001AF6 RID: 6902
		private static readonly IntPtr NativeMethodInfoPtr_get_CheckCertificateRevocationList_Public_Static_get_Boolean_0;

		// Token: 0x04001AF7 RID: 6903
		private static readonly IntPtr NativeMethodInfoPtr_get_DnsRefreshTimeout_Public_Static_get_Int32_0;

		// Token: 0x04001AF8 RID: 6904
		private static readonly IntPtr NativeMethodInfoPtr_get_SecurityProtocol_Public_Static_get_SecurityProtocolType_0;

		// Token: 0x04001AF9 RID: 6905
		private static readonly IntPtr NativeMethodInfoPtr_get_ServerCertValidationCallback_Internal_Static_get_ServerCertValidationCallback_0;

		// Token: 0x04001AFA RID: 6906
		private static readonly IntPtr NativeMethodInfoPtr_get_ServerCertificateValidationCallback_Public_Static_get_RemoteCertificateValidationCallback_0;

		// Token: 0x04001AFB RID: 6907
		private static readonly IntPtr NativeMethodInfoPtr_set_ServerCertificateValidationCallback_Public_Static_set_Void_RemoteCertificateValidationCallback_0;

		// Token: 0x04001AFC RID: 6908
		private static readonly IntPtr NativeMethodInfoPtr_FindServicePoint_Public_Static_ServicePoint_Uri_IWebProxy_0;

		// Token: 0x04001AFD RID: 6909
		private static readonly IntPtr NativeMethodInfoPtr_CloseConnectionGroup_Internal_Static_Void_String_0;

		// Token: 0x04001AFE RID: 6910
		private static readonly IntPtr NativeMethodInfoPtr_RemoveServicePoint_Internal_Static_Void_ServicePoint_0;

		// Token: 0x02000348 RID: 840
		public class SPKey : Object
		{
			// Token: 0x06003058 RID: 12376 RVA: 0x000D0CA0 File Offset: 0x000CEEA0
			// Note: this type is marked as 'beforefieldinit'.
			static SPKey()
			{
				Il2CppClassPointerStore<ServicePointManager.SPKey>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, "SPKey");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServicePointManager.SPKey>.NativeClassPtr);
				ServicePointManager.SPKey.NativeFieldInfoPtr_uri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointManager.SPKey>.NativeClassPtr, "uri");
				ServicePointManager.SPKey.NativeFieldInfoPtr_proxy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointManager.SPKey>.NativeClassPtr, "proxy");
				ServicePointManager.SPKey.NativeFieldInfoPtr_use_connect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointManager.SPKey>.NativeClassPtr, "use_connect");
				ServicePointManager.SPKey.NativeMethodInfoPtr__ctor_Public_Void_Uri_Uri_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointManager.SPKey>.NativeClassPtr, 100668435);
				ServicePointManager.SPKey.NativeMethodInfoPtr_get_UsesProxy_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointManager.SPKey>.NativeClassPtr, 100668436);
				ServicePointManager.SPKey.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointManager.SPKey>.NativeClassPtr, 100668437);
				ServicePointManager.SPKey.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointManager.SPKey>.NativeClassPtr, 100668438);
			}

			// Token: 0x06003059 RID: 12377 RVA: 0x000D0D58 File Offset: 0x000CEF58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SPKey(Uri uri, Uri proxy, bool use_connect)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServicePointManager.SPKey>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(proxy);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref use_connect;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointManager.SPKey.NativeMethodInfoPtr__ctor_Public_Void_Uri_Uri_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000F2B RID: 3883
			// (get) Token: 0x0600305A RID: 12378 RVA: 0x000D0DC4 File Offset: 0x000CEFC4
			public unsafe bool UsesProxy
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 483333, RefRangeEnd = 483336, XrefRangeStart = 483329, XrefRangeEnd = 483333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointManager.SPKey.NativeMethodInfoPtr_get_UsesProxy_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600305B RID: 12379 RVA: 0x000D0E00 File Offset: 0x000CF000
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 483336, XrefRangeEnd = 483341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int GetHashCode()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ServicePointManager.SPKey.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600305C RID: 12380 RVA: 0x000D0E48 File Offset: 0x000CF048
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 483341, XrefRangeEnd = 483347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool Equals(Object obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ServicePointManager.SPKey.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600305D RID: 12381 RVA: 0x000160BB File Offset: 0x000142BB
			public SPKey(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000F28 RID: 3880
			// (get) Token: 0x0600305E RID: 12382 RVA: 0x000D0EA0 File Offset: 0x000CF0A0
			// (set) Token: 0x0600305F RID: 12383 RVA: 0x000160C4 File Offset: 0x000142C4
			public unsafe Uri uri
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointManager.SPKey.NativeFieldInfoPtr_uri);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointManager.SPKey.NativeFieldInfoPtr_uri), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F29 RID: 3881
			// (get) Token: 0x06003060 RID: 12384 RVA: 0x000D0ED0 File Offset: 0x000CF0D0
			// (set) Token: 0x06003061 RID: 12385 RVA: 0x000160E3 File Offset: 0x000142E3
			public unsafe Uri proxy
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointManager.SPKey.NativeFieldInfoPtr_proxy);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointManager.SPKey.NativeFieldInfoPtr_proxy), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F2A RID: 3882
			// (get) Token: 0x06003062 RID: 12386 RVA: 0x000D0F00 File Offset: 0x000CF100
			// (set) Token: 0x06003063 RID: 12387 RVA: 0x00016102 File Offset: 0x00014302
			public unsafe bool use_connect
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointManager.SPKey.NativeFieldInfoPtr_use_connect);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointManager.SPKey.NativeFieldInfoPtr_use_connect)) = value;
				}
			}

			// Token: 0x040025AA RID: 9642
			private static readonly IntPtr NativeFieldInfoPtr_uri;

			// Token: 0x040025AB RID: 9643
			private static readonly IntPtr NativeFieldInfoPtr_proxy;

			// Token: 0x040025AC RID: 9644
			private static readonly IntPtr NativeFieldInfoPtr_use_connect;

			// Token: 0x040025AD RID: 9645
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Uri_Uri_Boolean_0;

			// Token: 0x040025AE RID: 9646
			private static readonly IntPtr NativeMethodInfoPtr_get_UsesProxy_Public_get_Boolean_0;

			// Token: 0x040025AF RID: 9647
			private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

			// Token: 0x040025B0 RID: 9648
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
		}
	}
}
