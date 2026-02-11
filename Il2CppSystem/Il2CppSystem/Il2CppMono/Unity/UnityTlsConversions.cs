using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppMono.Security.Interface;
using Il2CppSystem;
using Il2CppSystem.Net.Security;
using Il2CppSystem.Security.Authentication;
using Il2CppSystem.Security.Cryptography.X509Certificates;

namespace Il2CppMono.Unity
{
	// Token: 0x0200000C RID: 12
	public static class UnityTlsConversions : Object
	{
		// Token: 0x06000086 RID: 134 RVA: 0x0001C7B0 File Offset: 0x0001A9B0
		// Note: this type is marked as 'beforefieldinit'.
		static UnityTlsConversions()
		{
			Il2CppClassPointerStore<UnityTlsConversions>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Unity", "UnityTlsConversions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityTlsConversions>.NativeClassPtr);
			UnityTlsConversions.NativeMethodInfoPtr_GetMinProtocol_Public_Static_unitytls_protocol_SslProtocols_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsConversions>.NativeClassPtr, 100663434);
			UnityTlsConversions.NativeMethodInfoPtr_GetMaxProtocol_Public_Static_unitytls_protocol_SslProtocols_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsConversions>.NativeClassPtr, 100663435);
			UnityTlsConversions.NativeMethodInfoPtr_ConvertProtocolVersion_Public_Static_TlsProtocols_unitytls_protocol_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsConversions>.NativeClassPtr, 100663436);
			UnityTlsConversions.NativeMethodInfoPtr_VerifyResultToAlertDescription_Public_Static_AlertDescription_unitytls_x509verify_result_AlertDescription_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsConversions>.NativeClassPtr, 100663437);
			UnityTlsConversions.NativeMethodInfoPtr_VerifyResultToPolicyErrror_Public_Static_SslPolicyErrors_unitytls_x509verify_result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsConversions>.NativeClassPtr, 100663438);
			UnityTlsConversions.NativeMethodInfoPtr_VerifyResultToChainStatus_Public_Static_X509ChainStatusFlags_unitytls_x509verify_result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsConversions>.NativeClassPtr, 100663439);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0001C858 File Offset: 0x0001AA58
		[CallerCount(0)]
		public unsafe static UnityTls.unitytls_protocol GetMinProtocol(SslProtocols protocols)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref protocols;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTlsConversions.NativeMethodInfoPtr_GetMinProtocol_Public_Static_unitytls_protocol_SslProtocols_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0001C898 File Offset: 0x0001AA98
		[CallerCount(0)]
		public unsafe static UnityTls.unitytls_protocol GetMaxProtocol(SslProtocols protocols)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref protocols;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTlsConversions.NativeMethodInfoPtr_GetMaxProtocol_Public_Static_unitytls_protocol_SslProtocols_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000089 RID: 137 RVA: 0x0001C8D8 File Offset: 0x0001AAD8
		[CallerCount(0)]
		public unsafe static TlsProtocols ConvertProtocolVersion(UnityTls.unitytls_protocol protocol)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref protocol;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTlsConversions.NativeMethodInfoPtr_ConvertProtocolVersion_Public_Static_TlsProtocols_unitytls_protocol_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600008A RID: 138 RVA: 0x0001C918 File Offset: 0x0001AB18
		[CallerCount(0)]
		public unsafe static AlertDescription VerifyResultToAlertDescription(UnityTls.unitytls_x509verify_result verifyResult, AlertDescription defaultAlert = AlertDescription.InternalError)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref verifyResult;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultAlert;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTlsConversions.NativeMethodInfoPtr_VerifyResultToAlertDescription_Public_Static_AlertDescription_unitytls_x509verify_result_AlertDescription_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600008B RID: 139 RVA: 0x0001C964 File Offset: 0x0001AB64
		[CallerCount(0)]
		public unsafe static SslPolicyErrors VerifyResultToPolicyErrror(UnityTls.unitytls_x509verify_result verifyResult)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref verifyResult;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTlsConversions.NativeMethodInfoPtr_VerifyResultToPolicyErrror_Public_Static_SslPolicyErrors_unitytls_x509verify_result_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0001C9A4 File Offset: 0x0001ABA4
		[CallerCount(0)]
		public unsafe static X509ChainStatusFlags VerifyResultToChainStatus(UnityTls.unitytls_x509verify_result verifyResult)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref verifyResult;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTlsConversions.NativeMethodInfoPtr_VerifyResultToChainStatus_Public_Static_X509ChainStatusFlags_unitytls_x509verify_result_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600008D RID: 141 RVA: 0x000023BA File Offset: 0x000005BA
		public UnityTlsConversions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeMethodInfoPtr_GetMinProtocol_Public_Static_unitytls_protocol_SslProtocols_0;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeMethodInfoPtr_GetMaxProtocol_Public_Static_unitytls_protocol_SslProtocols_0;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeMethodInfoPtr_ConvertProtocolVersion_Public_Static_TlsProtocols_unitytls_protocol_0;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeMethodInfoPtr_VerifyResultToAlertDescription_Public_Static_AlertDescription_unitytls_x509verify_result_AlertDescription_0;

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeMethodInfoPtr_VerifyResultToPolicyErrror_Public_Static_SslPolicyErrors_unitytls_x509verify_result_0;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeMethodInfoPtr_VerifyResultToChainStatus_Public_Static_X509ChainStatusFlags_unitytls_x509verify_result_0;
	}
}
