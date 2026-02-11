using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Security.Authentication;
using Il2CppSystem.Security.Cryptography.X509Certificates;

namespace Il2CppSystem.Net.Security
{
	// Token: 0x02000260 RID: 608
	public class SslServerAuthenticationOptions : Object
	{
		// Token: 0x060028AD RID: 10413 RVA: 0x000B93E0 File Offset: 0x000B75E0
		// Note: this type is marked as 'beforefieldinit'.
		static SslServerAuthenticationOptions()
		{
			Il2CppClassPointerStore<SslServerAuthenticationOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Security", "SslServerAuthenticationOptions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SslServerAuthenticationOptions>.NativeClassPtr);
			SslServerAuthenticationOptions.NativeFieldInfoPtr__checkCertificateRevocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SslServerAuthenticationOptions>.NativeClassPtr, "_checkCertificateRevocation");
			SslServerAuthenticationOptions.NativeFieldInfoPtr__enabledSslProtocols = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SslServerAuthenticationOptions>.NativeClassPtr, "_enabledSslProtocols");
			SslServerAuthenticationOptions.NativeFieldInfoPtr__encryptionPolicy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SslServerAuthenticationOptions>.NativeClassPtr, "_encryptionPolicy");
			SslServerAuthenticationOptions.NativeFieldInfoPtr__allowRenegotiation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SslServerAuthenticationOptions>.NativeClassPtr, "_allowRenegotiation");
			SslServerAuthenticationOptions.NativeFieldInfoPtr__ClientCertificateRequired_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SslServerAuthenticationOptions>.NativeClassPtr, "<ClientCertificateRequired>k__BackingField");
			SslServerAuthenticationOptions.NativeFieldInfoPtr__ServerCertificate_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SslServerAuthenticationOptions>.NativeClassPtr, "<ServerCertificate>k__BackingField");
			SslServerAuthenticationOptions.NativeMethodInfoPtr_get_AllowRenegotiation_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SslServerAuthenticationOptions>.NativeClassPtr, 100669373);
			SslServerAuthenticationOptions.NativeMethodInfoPtr_get_ClientCertificateRequired_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SslServerAuthenticationOptions>.NativeClassPtr, 100669374);
			SslServerAuthenticationOptions.NativeMethodInfoPtr_set_ClientCertificateRequired_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SslServerAuthenticationOptions>.NativeClassPtr, 100669375);
			SslServerAuthenticationOptions.NativeMethodInfoPtr_get_ServerCertificate_Public_get_X509Certificate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SslServerAuthenticationOptions>.NativeClassPtr, 100669376);
			SslServerAuthenticationOptions.NativeMethodInfoPtr_set_ServerCertificate_Public_set_Void_X509Certificate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SslServerAuthenticationOptions>.NativeClassPtr, 100669377);
			SslServerAuthenticationOptions.NativeMethodInfoPtr_get_EnabledSslProtocols_Public_get_SslProtocols_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SslServerAuthenticationOptions>.NativeClassPtr, 100669378);
			SslServerAuthenticationOptions.NativeMethodInfoPtr_set_EnabledSslProtocols_Public_set_Void_SslProtocols_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SslServerAuthenticationOptions>.NativeClassPtr, 100669379);
			SslServerAuthenticationOptions.NativeMethodInfoPtr_set_CertificateRevocationCheckMode_Public_set_Void_X509RevocationMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SslServerAuthenticationOptions>.NativeClassPtr, 100669380);
			SslServerAuthenticationOptions.NativeMethodInfoPtr_set_EncryptionPolicy_Public_set_Void_EncryptionPolicy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SslServerAuthenticationOptions>.NativeClassPtr, 100669381);
			SslServerAuthenticationOptions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SslServerAuthenticationOptions>.NativeClassPtr, 100669382);
		}

		// Token: 0x17000CEE RID: 3310
		// (get) Token: 0x060028AE RID: 10414 RVA: 0x000B9550 File Offset: 0x000B7750
		public unsafe bool AllowRenegotiation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SslServerAuthenticationOptions.NativeMethodInfoPtr_get_AllowRenegotiation_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000CEF RID: 3311
		// (get) Token: 0x060028AF RID: 10415 RVA: 0x000B958C File Offset: 0x000B778C
		// (set) Token: 0x060028B0 RID: 10416 RVA: 0x000B95C8 File Offset: 0x000B77C8
		public unsafe bool ClientCertificateRequired
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SslServerAuthenticationOptions.NativeMethodInfoPtr_get_ClientCertificateRequired_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SslServerAuthenticationOptions.NativeMethodInfoPtr_set_ClientCertificateRequired_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CF0 RID: 3312
		// (get) Token: 0x060028B1 RID: 10417 RVA: 0x000B9608 File Offset: 0x000B7808
		// (set) Token: 0x060028B2 RID: 10418 RVA: 0x000B9648 File Offset: 0x000B7848
		public unsafe X509Certificate ServerCertificate
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SslServerAuthenticationOptions.NativeMethodInfoPtr_get_ServerCertificate_Public_get_X509Certificate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SslServerAuthenticationOptions.NativeMethodInfoPtr_set_ServerCertificate_Public_set_Void_X509Certificate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CF1 RID: 3313
		// (get) Token: 0x060028B3 RID: 10419 RVA: 0x000B968C File Offset: 0x000B788C
		// (set) Token: 0x060028B4 RID: 10420 RVA: 0x000B96C8 File Offset: 0x000B78C8
		public unsafe SslProtocols EnabledSslProtocols
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SslServerAuthenticationOptions.NativeMethodInfoPtr_get_EnabledSslProtocols_Public_get_SslProtocols_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 310312, RefRangeEnd = 310318, XrefRangeStart = 310312, XrefRangeEnd = 310318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SslServerAuthenticationOptions.NativeMethodInfoPtr_set_EnabledSslProtocols_Public_set_Void_SslProtocols_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CF2 RID: 3314
		// (set) Token: 0x060028B5 RID: 10421 RVA: 0x000B9708 File Offset: 0x000B7908
		public unsafe X509RevocationMode CertificateRevocationCheckMode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 493874, RefRangeEnd = 493875, XrefRangeStart = 493874, XrefRangeEnd = 493874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SslServerAuthenticationOptions.NativeMethodInfoPtr_set_CertificateRevocationCheckMode_Public_set_Void_X509RevocationMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CF3 RID: 3315
		// (set) Token: 0x060028B6 RID: 10422 RVA: 0x000B9748 File Offset: 0x000B7948
		public unsafe EncryptionPolicy EncryptionPolicy
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 493875, RefRangeEnd = 493876, XrefRangeStart = 493875, XrefRangeEnd = 493875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SslServerAuthenticationOptions.NativeMethodInfoPtr_set_EncryptionPolicy_Public_set_Void_EncryptionPolicy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060028B7 RID: 10423 RVA: 0x000B9788 File Offset: 0x000B7988
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 493866, RefRangeEnd = 493874, XrefRangeStart = 493866, XrefRangeEnd = 493874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SslServerAuthenticationOptions()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SslServerAuthenticationOptions>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SslServerAuthenticationOptions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028B8 RID: 10424 RVA: 0x00011848 File Offset: 0x0000FA48
		public SslServerAuthenticationOptions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CE8 RID: 3304
		// (get) Token: 0x060028B9 RID: 10425 RVA: 0x000B97C4 File Offset: 0x000B79C4
		// (set) Token: 0x060028BA RID: 10426 RVA: 0x00011851 File Offset: 0x0000FA51
		public unsafe X509RevocationMode _checkCertificateRevocation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SslServerAuthenticationOptions.NativeFieldInfoPtr__checkCertificateRevocation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SslServerAuthenticationOptions.NativeFieldInfoPtr__checkCertificateRevocation)) = value;
			}
		}

		// Token: 0x17000CE9 RID: 3305
		// (get) Token: 0x060028BB RID: 10427 RVA: 0x000B97EC File Offset: 0x000B79EC
		// (set) Token: 0x060028BC RID: 10428 RVA: 0x0001186C File Offset: 0x0000FA6C
		public unsafe SslProtocols _enabledSslProtocols
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SslServerAuthenticationOptions.NativeFieldInfoPtr__enabledSslProtocols);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SslServerAuthenticationOptions.NativeFieldInfoPtr__enabledSslProtocols)) = value;
			}
		}

		// Token: 0x17000CEA RID: 3306
		// (get) Token: 0x060028BD RID: 10429 RVA: 0x000B9814 File Offset: 0x000B7A14
		// (set) Token: 0x060028BE RID: 10430 RVA: 0x00011887 File Offset: 0x0000FA87
		public unsafe EncryptionPolicy _encryptionPolicy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SslServerAuthenticationOptions.NativeFieldInfoPtr__encryptionPolicy);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SslServerAuthenticationOptions.NativeFieldInfoPtr__encryptionPolicy)) = value;
			}
		}

		// Token: 0x17000CEB RID: 3307
		// (get) Token: 0x060028BF RID: 10431 RVA: 0x000B983C File Offset: 0x000B7A3C
		// (set) Token: 0x060028C0 RID: 10432 RVA: 0x000118A2 File Offset: 0x0000FAA2
		public unsafe bool _allowRenegotiation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SslServerAuthenticationOptions.NativeFieldInfoPtr__allowRenegotiation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SslServerAuthenticationOptions.NativeFieldInfoPtr__allowRenegotiation)) = value;
			}
		}

		// Token: 0x17000CEC RID: 3308
		// (get) Token: 0x060028C1 RID: 10433 RVA: 0x000B9864 File Offset: 0x000B7A64
		// (set) Token: 0x060028C2 RID: 10434 RVA: 0x000118BD File Offset: 0x0000FABD
		public unsafe bool _ClientCertificateRequired_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SslServerAuthenticationOptions.NativeFieldInfoPtr__ClientCertificateRequired_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SslServerAuthenticationOptions.NativeFieldInfoPtr__ClientCertificateRequired_k__BackingField)) = value;
			}
		}

		// Token: 0x17000CED RID: 3309
		// (get) Token: 0x060028C3 RID: 10435 RVA: 0x000B988C File Offset: 0x000B7A8C
		// (set) Token: 0x060028C4 RID: 10436 RVA: 0x000118D8 File Offset: 0x0000FAD8
		public unsafe X509Certificate _ServerCertificate_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SslServerAuthenticationOptions.NativeFieldInfoPtr__ServerCertificate_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509Certificate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SslServerAuthenticationOptions.NativeFieldInfoPtr__ServerCertificate_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400205C RID: 8284
		private static readonly IntPtr NativeFieldInfoPtr__checkCertificateRevocation;

		// Token: 0x0400205D RID: 8285
		private static readonly IntPtr NativeFieldInfoPtr__enabledSslProtocols;

		// Token: 0x0400205E RID: 8286
		private static readonly IntPtr NativeFieldInfoPtr__encryptionPolicy;

		// Token: 0x0400205F RID: 8287
		private static readonly IntPtr NativeFieldInfoPtr__allowRenegotiation;

		// Token: 0x04002060 RID: 8288
		private static readonly IntPtr NativeFieldInfoPtr__ClientCertificateRequired_k__BackingField;

		// Token: 0x04002061 RID: 8289
		private static readonly IntPtr NativeFieldInfoPtr__ServerCertificate_k__BackingField;

		// Token: 0x04002062 RID: 8290
		private static readonly IntPtr NativeMethodInfoPtr_get_AllowRenegotiation_Public_get_Boolean_0;

		// Token: 0x04002063 RID: 8291
		private static readonly IntPtr NativeMethodInfoPtr_get_ClientCertificateRequired_Public_get_Boolean_0;

		// Token: 0x04002064 RID: 8292
		private static readonly IntPtr NativeMethodInfoPtr_set_ClientCertificateRequired_Public_set_Void_Boolean_0;

		// Token: 0x04002065 RID: 8293
		private static readonly IntPtr NativeMethodInfoPtr_get_ServerCertificate_Public_get_X509Certificate_0;

		// Token: 0x04002066 RID: 8294
		private static readonly IntPtr NativeMethodInfoPtr_set_ServerCertificate_Public_set_Void_X509Certificate_0;

		// Token: 0x04002067 RID: 8295
		private static readonly IntPtr NativeMethodInfoPtr_get_EnabledSslProtocols_Public_get_SslProtocols_0;

		// Token: 0x04002068 RID: 8296
		private static readonly IntPtr NativeMethodInfoPtr_set_EnabledSslProtocols_Public_set_Void_SslProtocols_0;

		// Token: 0x04002069 RID: 8297
		private static readonly IntPtr NativeMethodInfoPtr_set_CertificateRevocationCheckMode_Public_set_Void_X509RevocationMode_0;

		// Token: 0x0400206A RID: 8298
		private static readonly IntPtr NativeMethodInfoPtr_set_EncryptionPolicy_Public_set_Void_EncryptionPolicy_0;

		// Token: 0x0400206B RID: 8299
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
