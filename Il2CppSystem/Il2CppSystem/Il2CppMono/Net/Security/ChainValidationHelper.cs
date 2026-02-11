using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono.Security.Interface;
using Il2CppSystem;
using Il2CppSystem.Net;
using Il2CppSystem.Net.Security;
using Il2CppSystem.Security.Cryptography.X509Certificates;

namespace Il2CppMono.Net.Security
{
	// Token: 0x02000019 RID: 25
	public class ChainValidationHelper : Object
	{
		// Token: 0x0600010E RID: 270 RVA: 0x0001E970 File Offset: 0x0001CB70
		// Note: this type is marked as 'beforefieldinit'.
		static ChainValidationHelper()
		{
			Il2CppClassPointerStore<ChainValidationHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Net.Security", "ChainValidationHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChainValidationHelper>.NativeClassPtr);
			ChainValidationHelper.NativeFieldInfoPtr_owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChainValidationHelper>.NativeClassPtr, "owner");
			ChainValidationHelper.NativeFieldInfoPtr_settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChainValidationHelper>.NativeClassPtr, "settings");
			ChainValidationHelper.NativeFieldInfoPtr_provider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChainValidationHelper>.NativeClassPtr, "provider");
			ChainValidationHelper.NativeFieldInfoPtr_certValidationCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChainValidationHelper>.NativeClassPtr, "certValidationCallback");
			ChainValidationHelper.NativeFieldInfoPtr_certSelectionCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChainValidationHelper>.NativeClassPtr, "certSelectionCallback");
			ChainValidationHelper.NativeFieldInfoPtr_tlsStream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChainValidationHelper>.NativeClassPtr, "tlsStream");
			ChainValidationHelper.NativeFieldInfoPtr_request = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChainValidationHelper>.NativeClassPtr, "request");
			ChainValidationHelper.NativeMethodInfoPtr_GetInternalValidator_Internal_Static_ChainValidationHelper_SslStream_MobileTlsProvider_MonoTlsSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChainValidationHelper>.NativeClassPtr, 100663506);
			ChainValidationHelper.NativeMethodInfoPtr_Create_Internal_Static_ChainValidationHelper_MobileTlsProvider_byref_MonoTlsSettings_MonoTlsStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChainValidationHelper>.NativeClassPtr, 100663507);
			ChainValidationHelper.NativeMethodInfoPtr__ctor_Private_Void_SslStream_MobileTlsProvider_MonoTlsSettings_Boolean_MonoTlsStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChainValidationHelper>.NativeClassPtr, 100663508);
			ChainValidationHelper.NativeMethodInfoPtr_GetValidationCallback_Private_Static_ServerCertValidationCallback_MonoTlsSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChainValidationHelper>.NativeClassPtr, 100663509);
			ChainValidationHelper.NativeMethodInfoPtr_DefaultSelectionCallback_Private_Static_X509Certificate_String_X509CertificateCollection_X509Certificate_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChainValidationHelper>.NativeClassPtr, 100663510);
			ChainValidationHelper.NativeMethodInfoPtr_get_Settings_Public_Virtual_Final_New_get_MonoTlsSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChainValidationHelper>.NativeClassPtr, 100663511);
			ChainValidationHelper.NativeMethodInfoPtr_SelectClientCertificate_Public_Virtual_Final_New_Boolean_String_X509CertificateCollection_X509Certificate_Il2CppStringArray_byref_X509Certificate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChainValidationHelper>.NativeClassPtr, 100663512);
			ChainValidationHelper.NativeMethodInfoPtr_ValidateCertificate_Public_ValidationResult_String_Boolean_X509Certificate_X509Chain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChainValidationHelper>.NativeClassPtr, 100663513);
			ChainValidationHelper.NativeMethodInfoPtr_ValidateChain_Private_ValidationResult_String_Boolean_X509Certificate_X509Chain_X509CertificateCollection_SslPolicyErrors_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChainValidationHelper>.NativeClassPtr, 100663514);
			ChainValidationHelper.NativeMethodInfoPtr_ValidateChain_Private_ValidationResult_String_Boolean_X509Certificate_byref_X509Chain_X509CertificateCollection_SslPolicyErrors_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChainValidationHelper>.NativeClassPtr, 100663515);
			ChainValidationHelper.NativeMethodInfoPtr_InvokeCallback_Private_Boolean_X509Certificate_X509Chain_SslPolicyErrors_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChainValidationHelper>.NativeClassPtr, 100663516);
		}

		// Token: 0x0600010F RID: 271 RVA: 0x0001EB08 File Offset: 0x0001CD08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 427922, XrefRangeEnd = 427931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ChainValidationHelper GetInternalValidator(SslStream owner, MobileTlsProvider provider, MonoTlsSettings settings)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(owner);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChainValidationHelper.NativeMethodInfoPtr_GetInternalValidator_Internal_Static_ChainValidationHelper_SslStream_MobileTlsProvider_MonoTlsSettings_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ChainValidationHelper>(intPtr3) : null;
		}

		// Token: 0x06000110 RID: 272 RVA: 0x0001EB70 File Offset: 0x0001CD70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 427931, XrefRangeEnd = 427936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ChainValidationHelper Create(MobileTlsProvider provider, ref MonoTlsSettings settings, MonoTlsStream stream)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stream);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ChainValidationHelper.NativeMethodInfoPtr_Create_Internal_Static_ChainValidationHelper_MobileTlsProvider_byref_MonoTlsSettings_MonoTlsStream_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			settings = ((intPtr4 == 0) ? null : new MonoTlsSettings(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<ChainValidationHelper>(intPtr5) : null;
		}

		// Token: 0x06000111 RID: 273 RVA: 0x0001EBF0 File Offset: 0x0001CDF0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 428003, RefRangeEnd = 428007, XrefRangeStart = 427936, XrefRangeEnd = 428003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChainValidationHelper(SslStream owner, MobileTlsProvider provider, MonoTlsSettings settings, bool cloneSettings, MonoTlsStream stream)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChainValidationHelper>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(owner);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cloneSettings;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stream);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChainValidationHelper.NativeMethodInfoPtr__ctor_Private_Void_SslStream_MobileTlsProvider_MonoTlsSettings_Boolean_MonoTlsStream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000112 RID: 274 RVA: 0x0001EC80 File Offset: 0x0001CE80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 428007, XrefRangeEnd = 428022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ServerCertValidationCallback GetValidationCallback(MonoTlsSettings settings)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChainValidationHelper.NativeMethodInfoPtr_GetValidationCallback_Private_Static_ServerCertValidationCallback_MonoTlsSettings_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServerCertValidationCallback>(intPtr3) : null;
			}
		}

		// Token: 0x06000113 RID: 275 RVA: 0x0001ECC4 File Offset: 0x0001CEC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 428022, XrefRangeEnd = 428024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static X509Certificate DefaultSelectionCallback(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, Il2CppStringArray acceptableIssuers)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(targetHost);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(localCertificates);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(remoteCertificate);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(acceptableIssuers);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChainValidationHelper.NativeMethodInfoPtr_DefaultSelectionCallback_Private_Static_X509Certificate_String_X509CertificateCollection_X509Certificate_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate>(intPtr3) : null;
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000114 RID: 276 RVA: 0x0001ED40 File Offset: 0x0001CF40
		public unsafe virtual MonoTlsSettings Settings
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChainValidationHelper.NativeMethodInfoPtr_get_Settings_Public_Virtual_Final_New_get_MonoTlsSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoTlsSettings>(intPtr3) : null;
			}
		}

		// Token: 0x06000115 RID: 277 RVA: 0x0001ED80 File Offset: 0x0001CF80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 428024, XrefRangeEnd = 428025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool SelectClientCertificate(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, Il2CppStringArray acceptableIssuers, out X509Certificate clientCertificate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(targetHost);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(localCertificates);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(remoteCertificate);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(acceptableIssuers);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ChainValidationHelper.NativeMethodInfoPtr_SelectClientCertificate_Public_Virtual_Final_New_Boolean_String_X509CertificateCollection_X509Certificate_Il2CppStringArray_byref_X509Certificate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			clientCertificate = ((intPtr4 == 0) ? null : new X509Certificate(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000116 RID: 278 RVA: 0x0001EE28 File Offset: 0x0001D028
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 428027, RefRangeEnd = 428032, XrefRangeStart = 428025, XrefRangeEnd = 428027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValidationResult ValidateCertificate(string host, bool serverMode, X509Certificate leaf, X509Chain chain)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(host);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref serverMode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(leaf);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(chain);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChainValidationHelper.NativeMethodInfoPtr_ValidateCertificate_Public_ValidationResult_String_Boolean_X509Certificate_X509Chain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ValidationResult>(intPtr3) : null;
		}

		// Token: 0x06000117 RID: 279 RVA: 0x0001EEAC File Offset: 0x0001D0AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 428037, RefRangeEnd = 428038, XrefRangeStart = 428032, XrefRangeEnd = 428037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValidationResult ValidateChain(string host, bool server, X509Certificate leaf, X509Chain chain, X509CertificateCollection certs, SslPolicyErrors errors)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(host);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref server;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(leaf);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(chain);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(certs);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref errors;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChainValidationHelper.NativeMethodInfoPtr_ValidateChain_Private_ValidationResult_String_Boolean_X509Certificate_X509Chain_X509CertificateCollection_SslPolicyErrors_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ValidationResult>(intPtr3) : null;
		}

		// Token: 0x06000118 RID: 280 RVA: 0x0001EF50 File Offset: 0x0001D150
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 428077, RefRangeEnd = 428078, XrefRangeStart = 428038, XrefRangeEnd = 428077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValidationResult ValidateChain(string host, bool server, X509Certificate leaf, ref X509Chain chain, X509CertificateCollection certs, SslPolicyErrors errors)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(host);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref server;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(leaf);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(chain);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(certs);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref errors;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ChainValidationHelper.NativeMethodInfoPtr_ValidateChain_Private_ValidationResult_String_Boolean_X509Certificate_byref_X509Chain_X509CertificateCollection_SslPolicyErrors_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			chain = ((intPtr4 == 0) ? null : new X509Chain(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<ValidationResult>(intPtr5) : null;
		}

		// Token: 0x06000119 RID: 281 RVA: 0x0001F00C File Offset: 0x0001D20C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 428083, RefRangeEnd = 428085, XrefRangeStart = 428078, XrefRangeEnd = 428083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool InvokeCallback(X509Certificate leaf, X509Chain chain, SslPolicyErrors errors)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(leaf);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(chain);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref errors;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChainValidationHelper.NativeMethodInfoPtr_InvokeCallback_Private_Boolean_X509Certificate_X509Chain_SslPolicyErrors_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600011A RID: 282 RVA: 0x000026B3 File Offset: 0x000008B3
		public ChainValidationHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600011B RID: 283 RVA: 0x0001F07C File Offset: 0x0001D27C
		// (set) Token: 0x0600011C RID: 284 RVA: 0x000026BC File Offset: 0x000008BC
		public unsafe WeakReference<SslStream> owner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChainValidationHelper.NativeFieldInfoPtr_owner);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WeakReference<SslStream>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChainValidationHelper.NativeFieldInfoPtr_owner), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x0600011D RID: 285 RVA: 0x0001F0AC File Offset: 0x0001D2AC
		// (set) Token: 0x0600011E RID: 286 RVA: 0x000026DB File Offset: 0x000008DB
		public unsafe MonoTlsSettings settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChainValidationHelper.NativeFieldInfoPtr_settings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoTlsSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChainValidationHelper.NativeFieldInfoPtr_settings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600011F RID: 287 RVA: 0x0001F0DC File Offset: 0x0001D2DC
		// (set) Token: 0x06000120 RID: 288 RVA: 0x000026FA File Offset: 0x000008FA
		public unsafe MobileTlsProvider provider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChainValidationHelper.NativeFieldInfoPtr_provider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MobileTlsProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChainValidationHelper.NativeFieldInfoPtr_provider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000121 RID: 289 RVA: 0x0001F10C File Offset: 0x0001D30C
		// (set) Token: 0x06000122 RID: 290 RVA: 0x00002719 File Offset: 0x00000919
		public unsafe ServerCertValidationCallback certValidationCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChainValidationHelper.NativeFieldInfoPtr_certValidationCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServerCertValidationCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChainValidationHelper.NativeFieldInfoPtr_certValidationCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000123 RID: 291 RVA: 0x0001F13C File Offset: 0x0001D33C
		// (set) Token: 0x06000124 RID: 292 RVA: 0x00002738 File Offset: 0x00000938
		public unsafe LocalCertSelectionCallback certSelectionCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChainValidationHelper.NativeFieldInfoPtr_certSelectionCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalCertSelectionCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChainValidationHelper.NativeFieldInfoPtr_certSelectionCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000125 RID: 293 RVA: 0x0001F16C File Offset: 0x0001D36C
		// (set) Token: 0x06000126 RID: 294 RVA: 0x00002757 File Offset: 0x00000957
		public unsafe MonoTlsStream tlsStream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChainValidationHelper.NativeFieldInfoPtr_tlsStream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoTlsStream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChainValidationHelper.NativeFieldInfoPtr_tlsStream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000127 RID: 295 RVA: 0x0001F19C File Offset: 0x0001D39C
		// (set) Token: 0x06000128 RID: 296 RVA: 0x00002776 File Offset: 0x00000976
		public unsafe HttpWebRequest request
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChainValidationHelper.NativeFieldInfoPtr_request);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpWebRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChainValidationHelper.NativeFieldInfoPtr_request), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000B6 RID: 182
		private static readonly IntPtr NativeFieldInfoPtr_owner;

		// Token: 0x040000B7 RID: 183
		private static readonly IntPtr NativeFieldInfoPtr_settings;

		// Token: 0x040000B8 RID: 184
		private static readonly IntPtr NativeFieldInfoPtr_provider;

		// Token: 0x040000B9 RID: 185
		private static readonly IntPtr NativeFieldInfoPtr_certValidationCallback;

		// Token: 0x040000BA RID: 186
		private static readonly IntPtr NativeFieldInfoPtr_certSelectionCallback;

		// Token: 0x040000BB RID: 187
		private static readonly IntPtr NativeFieldInfoPtr_tlsStream;

		// Token: 0x040000BC RID: 188
		private static readonly IntPtr NativeFieldInfoPtr_request;

		// Token: 0x040000BD RID: 189
		private static readonly IntPtr NativeMethodInfoPtr_GetInternalValidator_Internal_Static_ChainValidationHelper_SslStream_MobileTlsProvider_MonoTlsSettings_0;

		// Token: 0x040000BE RID: 190
		private static readonly IntPtr NativeMethodInfoPtr_Create_Internal_Static_ChainValidationHelper_MobileTlsProvider_byref_MonoTlsSettings_MonoTlsStream_0;

		// Token: 0x040000BF RID: 191
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_SslStream_MobileTlsProvider_MonoTlsSettings_Boolean_MonoTlsStream_0;

		// Token: 0x040000C0 RID: 192
		private static readonly IntPtr NativeMethodInfoPtr_GetValidationCallback_Private_Static_ServerCertValidationCallback_MonoTlsSettings_0;

		// Token: 0x040000C1 RID: 193
		private static readonly IntPtr NativeMethodInfoPtr_DefaultSelectionCallback_Private_Static_X509Certificate_String_X509CertificateCollection_X509Certificate_Il2CppStringArray_0;

		// Token: 0x040000C2 RID: 194
		private static readonly IntPtr NativeMethodInfoPtr_get_Settings_Public_Virtual_Final_New_get_MonoTlsSettings_0;

		// Token: 0x040000C3 RID: 195
		private static readonly IntPtr NativeMethodInfoPtr_SelectClientCertificate_Public_Virtual_Final_New_Boolean_String_X509CertificateCollection_X509Certificate_Il2CppStringArray_byref_X509Certificate_0;

		// Token: 0x040000C4 RID: 196
		private static readonly IntPtr NativeMethodInfoPtr_ValidateCertificate_Public_ValidationResult_String_Boolean_X509Certificate_X509Chain_0;

		// Token: 0x040000C5 RID: 197
		private static readonly IntPtr NativeMethodInfoPtr_ValidateChain_Private_ValidationResult_String_Boolean_X509Certificate_X509Chain_X509CertificateCollection_SslPolicyErrors_0;

		// Token: 0x040000C6 RID: 198
		private static readonly IntPtr NativeMethodInfoPtr_ValidateChain_Private_ValidationResult_String_Boolean_X509Certificate_byref_X509Chain_X509CertificateCollection_SslPolicyErrors_0;

		// Token: 0x040000C7 RID: 199
		private static readonly IntPtr NativeMethodInfoPtr_InvokeCallback_Private_Boolean_X509Certificate_X509Chain_SslPolicyErrors_0;

		// Token: 0x0200029A RID: 666
		[ObfuscatedName("Mono.Net.Security.ChainValidationHelper+<>c__DisplayClass11_0")]
		public sealed class __c__DisplayClass11_0 : Object
		{
			// Token: 0x06002A4C RID: 10828 RVA: 0x000BDD04 File Offset: 0x000BBF04
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<ChainValidationHelper.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChainValidationHelper>.NativeClassPtr, "<>c__DisplayClass11_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChainValidationHelper.__c__DisplayClass11_0>.NativeClassPtr);
				ChainValidationHelper.__c__DisplayClass11_0.NativeFieldInfoPtr_settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChainValidationHelper.__c__DisplayClass11_0>.NativeClassPtr, "settings");
				ChainValidationHelper.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChainValidationHelper.__c__DisplayClass11_0>.NativeClassPtr, 100663517);
				ChainValidationHelper.__c__DisplayClass11_0.NativeMethodInfoPtr__GetValidationCallback_b__0_Internal_Boolean_Object_X509Certificate_X509Chain_SslPolicyErrors_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChainValidationHelper.__c__DisplayClass11_0>.NativeClassPtr, 100663518);
			}

			// Token: 0x06002A4D RID: 10829 RVA: 0x000BDD6C File Offset: 0x000BBF6C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChainValidationHelper.__c__DisplayClass11_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChainValidationHelper.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002A4E RID: 10830 RVA: 0x000BDDA8 File Offset: 0x000BBFA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 427909, XrefRangeEnd = 427922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetValidationCallback_b__0(Object s, X509Certificate c, X509Chain ch, SslPolicyErrors e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(c);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ch);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref e;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChainValidationHelper.__c__DisplayClass11_0.NativeMethodInfoPtr__GetValidationCallback_b__0_Internal_Boolean_Object_X509Certificate_X509Chain_SslPolicyErrors_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002A4F RID: 10831 RVA: 0x0001295E File Offset: 0x00010B5E
			public __c__DisplayClass11_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D62 RID: 3426
			// (get) Token: 0x06002A50 RID: 10832 RVA: 0x000BDE28 File Offset: 0x000BC028
			// (set) Token: 0x06002A51 RID: 10833 RVA: 0x00012967 File Offset: 0x00010B67
			public unsafe MonoTlsSettings settings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChainValidationHelper.__c__DisplayClass11_0.NativeFieldInfoPtr_settings);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoTlsSettings>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChainValidationHelper.__c__DisplayClass11_0.NativeFieldInfoPtr_settings), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002173 RID: 8563
			private static readonly IntPtr NativeFieldInfoPtr_settings;

			// Token: 0x04002174 RID: 8564
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002175 RID: 8565
			private static readonly IntPtr NativeMethodInfoPtr__GetValidationCallback_b__0_Internal_Boolean_Object_X509Certificate_X509Chain_SslPolicyErrors_0;
		}
	}
}
