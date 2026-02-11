using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Security.Authentication;
using Il2CppSystem.Security.Cryptography.X509Certificates;

namespace Il2CppSystem.Net.Security
{
	// Token: 0x0200025F RID: 607
	public class SslClientAuthenticationOptions : Object
	{
		// Token: 0x0600288E RID: 10382 RVA: 0x000B8D7C File Offset: 0x000B6F7C
		// Note: this type is marked as 'beforefieldinit'.
		static SslClientAuthenticationOptions()
		{
			Il2CppClassPointerStore<SslClientAuthenticationOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Security", "SslClientAuthenticationOptions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SslClientAuthenticationOptions>.NativeClassPtr);
			SslClientAuthenticationOptions.NativeFieldInfoPtr__encryptionPolicy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SslClientAuthenticationOptions>.NativeClassPtr, "_encryptionPolicy");
			SslClientAuthenticationOptions.NativeFieldInfoPtr__checkCertificateRevocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SslClientAuthenticationOptions>.NativeClassPtr, "_checkCertificateRevocation");
			SslClientAuthenticationOptions.NativeFieldInfoPtr__enabledSslProtocols = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SslClientAuthenticationOptions>.NativeClassPtr, "_enabledSslProtocols");
			SslClientAuthenticationOptions.NativeFieldInfoPtr__allowRenegotiation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SslClientAuthenticationOptions>.NativeClassPtr, "_allowRenegotiation");
			SslClientAuthenticationOptions.NativeFieldInfoPtr__LocalCertificateSelectionCallback_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SslClientAuthenticationOptions>.NativeClassPtr, "<LocalCertificateSelectionCallback>k__BackingField");
			SslClientAuthenticationOptions.NativeFieldInfoPtr__RemoteCertificateValidationCallback_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SslClientAuthenticationOptions>.NativeClassPtr, "<RemoteCertificateValidationCallback>k__BackingField");
			SslClientAuthenticationOptions.NativeFieldInfoPtr__TargetHost_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SslClientAuthenticationOptions>.NativeClassPtr, "<TargetHost>k__BackingField");
			SslClientAuthenticationOptions.NativeFieldInfoPtr__ClientCertificates_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SslClientAuthenticationOptions>.NativeClassPtr, "<ClientCertificates>k__BackingField");
			SslClientAuthenticationOptions.NativeMethodInfoPtr_get_AllowRenegotiation_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SslClientAuthenticationOptions>.NativeClassPtr, 100669360);
			SslClientAuthenticationOptions.NativeMethodInfoPtr_get_LocalCertificateSelectionCallback_Public_get_LocalCertificateSelectionCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SslClientAuthenticationOptions>.NativeClassPtr, 100669361);
			SslClientAuthenticationOptions.NativeMethodInfoPtr_set_LocalCertificateSelectionCallback_Public_set_Void_LocalCertificateSelectionCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SslClientAuthenticationOptions>.NativeClassPtr, 100669362);
			SslClientAuthenticationOptions.NativeMethodInfoPtr_get_RemoteCertificateValidationCallback_Public_get_RemoteCertificateValidationCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SslClientAuthenticationOptions>.NativeClassPtr, 100669363);
			SslClientAuthenticationOptions.NativeMethodInfoPtr_get_TargetHost_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SslClientAuthenticationOptions>.NativeClassPtr, 100669364);
			SslClientAuthenticationOptions.NativeMethodInfoPtr_set_TargetHost_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SslClientAuthenticationOptions>.NativeClassPtr, 100669365);
			SslClientAuthenticationOptions.NativeMethodInfoPtr_get_ClientCertificates_Public_get_X509CertificateCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SslClientAuthenticationOptions>.NativeClassPtr, 100669366);
			SslClientAuthenticationOptions.NativeMethodInfoPtr_set_ClientCertificates_Public_set_Void_X509CertificateCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SslClientAuthenticationOptions>.NativeClassPtr, 100669367);
			SslClientAuthenticationOptions.NativeMethodInfoPtr_set_CertificateRevocationCheckMode_Public_set_Void_X509RevocationMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SslClientAuthenticationOptions>.NativeClassPtr, 100669368);
			SslClientAuthenticationOptions.NativeMethodInfoPtr_set_EncryptionPolicy_Public_set_Void_EncryptionPolicy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SslClientAuthenticationOptions>.NativeClassPtr, 100669369);
			SslClientAuthenticationOptions.NativeMethodInfoPtr_get_EnabledSslProtocols_Public_get_SslProtocols_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SslClientAuthenticationOptions>.NativeClassPtr, 100669370);
			SslClientAuthenticationOptions.NativeMethodInfoPtr_set_EnabledSslProtocols_Public_set_Void_SslProtocols_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SslClientAuthenticationOptions>.NativeClassPtr, 100669371);
			SslClientAuthenticationOptions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SslClientAuthenticationOptions>.NativeClassPtr, 100669372);
		}

		// Token: 0x17000CE0 RID: 3296
		// (get) Token: 0x0600288F RID: 10383 RVA: 0x000B8F50 File Offset: 0x000B7150
		public unsafe bool AllowRenegotiation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SslClientAuthenticationOptions.NativeMethodInfoPtr_get_AllowRenegotiation_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000CE1 RID: 3297
		// (get) Token: 0x06002890 RID: 10384 RVA: 0x000B8F8C File Offset: 0x000B718C
		// (set) Token: 0x06002891 RID: 10385 RVA: 0x000B8FCC File Offset: 0x000B71CC
		public unsafe LocalCertificateSelectionCallback LocalCertificateSelectionCallback
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SslClientAuthenticationOptions.NativeMethodInfoPtr_get_LocalCertificateSelectionCallback_Public_get_LocalCertificateSelectionCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalCertificateSelectionCallback>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SslClientAuthenticationOptions.NativeMethodInfoPtr_set_LocalCertificateSelectionCallback_Public_set_Void_LocalCertificateSelectionCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CE2 RID: 3298
		// (get) Token: 0x06002892 RID: 10386 RVA: 0x000B9010 File Offset: 0x000B7210
		public unsafe RemoteCertificateValidationCallback RemoteCertificateValidationCallback
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SslClientAuthenticationOptions.NativeMethodInfoPtr_get_RemoteCertificateValidationCallback_Public_get_RemoteCertificateValidationCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RemoteCertificateValidationCallback>(intPtr3) : null;
			}
		}

		// Token: 0x17000CE3 RID: 3299
		// (get) Token: 0x06002893 RID: 10387 RVA: 0x000B9050 File Offset: 0x000B7250
		// (set) Token: 0x06002894 RID: 10388 RVA: 0x000B9088 File Offset: 0x000B7288
		public unsafe string TargetHost
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SslClientAuthenticationOptions.NativeMethodInfoPtr_get_TargetHost_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SslClientAuthenticationOptions.NativeMethodInfoPtr_set_TargetHost_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CE4 RID: 3300
		// (get) Token: 0x06002895 RID: 10389 RVA: 0x000B90CC File Offset: 0x000B72CC
		// (set) Token: 0x06002896 RID: 10390 RVA: 0x000B910C File Offset: 0x000B730C
		public unsafe X509CertificateCollection ClientCertificates
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SslClientAuthenticationOptions.NativeMethodInfoPtr_get_ClientCertificates_Public_get_X509CertificateCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509CertificateCollection>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SslClientAuthenticationOptions.NativeMethodInfoPtr_set_ClientCertificates_Public_set_Void_X509CertificateCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CE5 RID: 3301
		// (set) Token: 0x06002897 RID: 10391 RVA: 0x000B9150 File Offset: 0x000B7350
		public unsafe X509RevocationMode CertificateRevocationCheckMode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 493863, RefRangeEnd = 493864, XrefRangeStart = 493863, XrefRangeEnd = 493863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SslClientAuthenticationOptions.NativeMethodInfoPtr_set_CertificateRevocationCheckMode_Public_set_Void_X509RevocationMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CE6 RID: 3302
		// (set) Token: 0x06002898 RID: 10392 RVA: 0x000B9190 File Offset: 0x000B7390
		public unsafe EncryptionPolicy EncryptionPolicy
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 493864, RefRangeEnd = 493865, XrefRangeStart = 493864, XrefRangeEnd = 493864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SslClientAuthenticationOptions.NativeMethodInfoPtr_set_EncryptionPolicy_Public_set_Void_EncryptionPolicy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CE7 RID: 3303
		// (get) Token: 0x06002899 RID: 10393 RVA: 0x000B91D0 File Offset: 0x000B73D0
		// (set) Token: 0x0600289A RID: 10394 RVA: 0x000B920C File Offset: 0x000B740C
		public unsafe SslProtocols EnabledSslProtocols
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SslClientAuthenticationOptions.NativeMethodInfoPtr_get_EnabledSslProtocols_Public_get_SslProtocols_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 311421, RefRangeEnd = 311423, XrefRangeStart = 311421, XrefRangeEnd = 311423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SslClientAuthenticationOptions.NativeMethodInfoPtr_set_EnabledSslProtocols_Public_set_Void_SslProtocols_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600289B RID: 10395 RVA: 0x000B924C File Offset: 0x000B744C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 493866, RefRangeEnd = 493874, XrefRangeStart = 493865, XrefRangeEnd = 493866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SslClientAuthenticationOptions()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SslClientAuthenticationOptions>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SslClientAuthenticationOptions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600289C RID: 10396 RVA: 0x00011757 File Offset: 0x0000F957
		public SslClientAuthenticationOptions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CD8 RID: 3288
		// (get) Token: 0x0600289D RID: 10397 RVA: 0x000B9288 File Offset: 0x000B7488
		// (set) Token: 0x0600289E RID: 10398 RVA: 0x00011760 File Offset: 0x0000F960
		public unsafe EncryptionPolicy _encryptionPolicy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SslClientAuthenticationOptions.NativeFieldInfoPtr__encryptionPolicy);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SslClientAuthenticationOptions.NativeFieldInfoPtr__encryptionPolicy)) = value;
			}
		}

		// Token: 0x17000CD9 RID: 3289
		// (get) Token: 0x0600289F RID: 10399 RVA: 0x000B92B0 File Offset: 0x000B74B0
		// (set) Token: 0x060028A0 RID: 10400 RVA: 0x0001177B File Offset: 0x0000F97B
		public unsafe X509RevocationMode _checkCertificateRevocation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SslClientAuthenticationOptions.NativeFieldInfoPtr__checkCertificateRevocation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SslClientAuthenticationOptions.NativeFieldInfoPtr__checkCertificateRevocation)) = value;
			}
		}

		// Token: 0x17000CDA RID: 3290
		// (get) Token: 0x060028A1 RID: 10401 RVA: 0x000B92D8 File Offset: 0x000B74D8
		// (set) Token: 0x060028A2 RID: 10402 RVA: 0x00011796 File Offset: 0x0000F996
		public unsafe SslProtocols _enabledSslProtocols
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SslClientAuthenticationOptions.NativeFieldInfoPtr__enabledSslProtocols);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SslClientAuthenticationOptions.NativeFieldInfoPtr__enabledSslProtocols)) = value;
			}
		}

		// Token: 0x17000CDB RID: 3291
		// (get) Token: 0x060028A3 RID: 10403 RVA: 0x000B9300 File Offset: 0x000B7500
		// (set) Token: 0x060028A4 RID: 10404 RVA: 0x000117B1 File Offset: 0x0000F9B1
		public unsafe bool _allowRenegotiation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SslClientAuthenticationOptions.NativeFieldInfoPtr__allowRenegotiation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SslClientAuthenticationOptions.NativeFieldInfoPtr__allowRenegotiation)) = value;
			}
		}

		// Token: 0x17000CDC RID: 3292
		// (get) Token: 0x060028A5 RID: 10405 RVA: 0x000B9328 File Offset: 0x000B7528
		// (set) Token: 0x060028A6 RID: 10406 RVA: 0x000117CC File Offset: 0x0000F9CC
		public unsafe LocalCertificateSelectionCallback _LocalCertificateSelectionCallback_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SslClientAuthenticationOptions.NativeFieldInfoPtr__LocalCertificateSelectionCallback_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalCertificateSelectionCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SslClientAuthenticationOptions.NativeFieldInfoPtr__LocalCertificateSelectionCallback_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CDD RID: 3293
		// (get) Token: 0x060028A7 RID: 10407 RVA: 0x000B9358 File Offset: 0x000B7558
		// (set) Token: 0x060028A8 RID: 10408 RVA: 0x000117EB File Offset: 0x0000F9EB
		public unsafe RemoteCertificateValidationCallback _RemoteCertificateValidationCallback_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SslClientAuthenticationOptions.NativeFieldInfoPtr__RemoteCertificateValidationCallback_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RemoteCertificateValidationCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SslClientAuthenticationOptions.NativeFieldInfoPtr__RemoteCertificateValidationCallback_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CDE RID: 3294
		// (get) Token: 0x060028A9 RID: 10409 RVA: 0x000B9388 File Offset: 0x000B7588
		// (set) Token: 0x060028AA RID: 10410 RVA: 0x0001180A File Offset: 0x0000FA0A
		public unsafe string _TargetHost_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SslClientAuthenticationOptions.NativeFieldInfoPtr__TargetHost_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SslClientAuthenticationOptions.NativeFieldInfoPtr__TargetHost_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000CDF RID: 3295
		// (get) Token: 0x060028AB RID: 10411 RVA: 0x000B93B0 File Offset: 0x000B75B0
		// (set) Token: 0x060028AC RID: 10412 RVA: 0x00011829 File Offset: 0x0000FA29
		public unsafe X509CertificateCollection _ClientCertificates_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SslClientAuthenticationOptions.NativeFieldInfoPtr__ClientCertificates_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509CertificateCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SslClientAuthenticationOptions.NativeFieldInfoPtr__ClientCertificates_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002047 RID: 8263
		private static readonly IntPtr NativeFieldInfoPtr__encryptionPolicy;

		// Token: 0x04002048 RID: 8264
		private static readonly IntPtr NativeFieldInfoPtr__checkCertificateRevocation;

		// Token: 0x04002049 RID: 8265
		private static readonly IntPtr NativeFieldInfoPtr__enabledSslProtocols;

		// Token: 0x0400204A RID: 8266
		private static readonly IntPtr NativeFieldInfoPtr__allowRenegotiation;

		// Token: 0x0400204B RID: 8267
		private static readonly IntPtr NativeFieldInfoPtr__LocalCertificateSelectionCallback_k__BackingField;

		// Token: 0x0400204C RID: 8268
		private static readonly IntPtr NativeFieldInfoPtr__RemoteCertificateValidationCallback_k__BackingField;

		// Token: 0x0400204D RID: 8269
		private static readonly IntPtr NativeFieldInfoPtr__TargetHost_k__BackingField;

		// Token: 0x0400204E RID: 8270
		private static readonly IntPtr NativeFieldInfoPtr__ClientCertificates_k__BackingField;

		// Token: 0x0400204F RID: 8271
		private static readonly IntPtr NativeMethodInfoPtr_get_AllowRenegotiation_Public_get_Boolean_0;

		// Token: 0x04002050 RID: 8272
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalCertificateSelectionCallback_Public_get_LocalCertificateSelectionCallback_0;

		// Token: 0x04002051 RID: 8273
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalCertificateSelectionCallback_Public_set_Void_LocalCertificateSelectionCallback_0;

		// Token: 0x04002052 RID: 8274
		private static readonly IntPtr NativeMethodInfoPtr_get_RemoteCertificateValidationCallback_Public_get_RemoteCertificateValidationCallback_0;

		// Token: 0x04002053 RID: 8275
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetHost_Public_get_String_0;

		// Token: 0x04002054 RID: 8276
		private static readonly IntPtr NativeMethodInfoPtr_set_TargetHost_Public_set_Void_String_0;

		// Token: 0x04002055 RID: 8277
		private static readonly IntPtr NativeMethodInfoPtr_get_ClientCertificates_Public_get_X509CertificateCollection_0;

		// Token: 0x04002056 RID: 8278
		private static readonly IntPtr NativeMethodInfoPtr_set_ClientCertificates_Public_set_Void_X509CertificateCollection_0;

		// Token: 0x04002057 RID: 8279
		private static readonly IntPtr NativeMethodInfoPtr_set_CertificateRevocationCheckMode_Public_set_Void_X509RevocationMode_0;

		// Token: 0x04002058 RID: 8280
		private static readonly IntPtr NativeMethodInfoPtr_set_EncryptionPolicy_Public_set_Void_EncryptionPolicy_0;

		// Token: 0x04002059 RID: 8281
		private static readonly IntPtr NativeMethodInfoPtr_get_EnabledSslProtocols_Public_get_SslProtocols_0;

		// Token: 0x0400205A RID: 8282
		private static readonly IntPtr NativeMethodInfoPtr_set_EnabledSslProtocols_Public_set_Void_SslProtocols_0;

		// Token: 0x0400205B RID: 8283
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
