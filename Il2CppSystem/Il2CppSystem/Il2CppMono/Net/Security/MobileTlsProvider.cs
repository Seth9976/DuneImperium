using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono.Security.Interface;
using Il2CppSystem.IO;
using Il2CppSystem.Net.Security;
using Il2CppSystem.Security.Cryptography.X509Certificates;

namespace Il2CppMono.Net.Security
{
	// Token: 0x0200001C RID: 28
	public class MobileTlsProvider : MonoTlsProvider
	{
		// Token: 0x060001B6 RID: 438 RVA: 0x00021958 File Offset: 0x0001FB58
		// Note: this type is marked as 'beforefieldinit'.
		static MobileTlsProvider()
		{
			Il2CppClassPointerStore<MobileTlsProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Net.Security", "MobileTlsProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MobileTlsProvider>.NativeClassPtr);
			MobileTlsProvider.NativeMethodInfoPtr_CreateSslStream_Internal_Abstract_Virtual_New_MobileAuthenticatedStream_SslStream_Stream_Boolean_MonoTlsSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileTlsProvider>.NativeClassPtr, 100663611);
			MobileTlsProvider.NativeMethodInfoPtr_ValidateCertificate_Internal_Abstract_Virtual_New_Boolean_ChainValidationHelper_String_Boolean_X509CertificateCollection_Boolean_byref_X509Chain_byref_SslPolicyErrors_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileTlsProvider>.NativeClassPtr, 100663612);
			MobileTlsProvider.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileTlsProvider>.NativeClassPtr, 100663613);
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x000219C4 File Offset: 0x0001FBC4
		[CallerCount(0)]
		public unsafe virtual MobileAuthenticatedStream CreateSslStream(SslStream sslStream, Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sslStream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerStream);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leaveInnerStreamOpen;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileTlsProvider.NativeMethodInfoPtr_CreateSslStream_Internal_Abstract_Virtual_New_MobileAuthenticatedStream_SslStream_Stream_Boolean_MonoTlsSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MobileAuthenticatedStream>(intPtr3) : null;
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00021A54 File Offset: 0x0001FC54
		[CallerCount(0)]
		public unsafe virtual bool ValidateCertificate(ChainValidationHelper validator, string targetHost, bool serverMode, X509CertificateCollection certificates, bool wantsChain, ref X509Chain chain, ref SslPolicyErrors errors, ref int status11)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(validator);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(targetHost);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref serverMode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(certificates);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref wantsChain;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(chain);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &errors;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &status11;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileTlsProvider.NativeMethodInfoPtr_ValidateCertificate_Internal_Abstract_Virtual_New_Boolean_ChainValidationHelper_String_Boolean_X509CertificateCollection_Boolean_byref_X509Chain_byref_SslPolicyErrors_byref_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			chain = ((intPtr4 == 0) ? null : new X509Chain(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00021B38 File Offset: 0x0001FD38
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MobileTlsProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MobileTlsProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileTlsProvider.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00002ACD File Offset: 0x00000CCD
		public MobileTlsProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000135 RID: 309
		private static readonly IntPtr NativeMethodInfoPtr_CreateSslStream_Internal_Abstract_Virtual_New_MobileAuthenticatedStream_SslStream_Stream_Boolean_MonoTlsSettings_0;

		// Token: 0x04000136 RID: 310
		private static readonly IntPtr NativeMethodInfoPtr_ValidateCertificate_Internal_Abstract_Virtual_New_Boolean_ChainValidationHelper_String_Boolean_X509CertificateCollection_Boolean_byref_X509Chain_byref_SslPolicyErrors_byref_Int32_0;

		// Token: 0x04000137 RID: 311
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
