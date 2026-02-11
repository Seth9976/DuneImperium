using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Net.Security;
using Il2CppSystem.Security.Authentication;
using Il2CppSystem.Security.Cryptography.X509Certificates;

namespace Il2CppMono.Net.Security
{
	// Token: 0x0200001F RID: 31
	public sealed class MonoSslServerAuthenticationOptions : MonoSslAuthenticationOptions
	{
		// Token: 0x060001E3 RID: 483 RVA: 0x00022764 File Offset: 0x00020964
		// Note: this type is marked as 'beforefieldinit'.
		static MonoSslServerAuthenticationOptions()
		{
			Il2CppClassPointerStore<MonoSslServerAuthenticationOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Net.Security", "MonoSslServerAuthenticationOptions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoSslServerAuthenticationOptions>.NativeClassPtr);
			MonoSslServerAuthenticationOptions.NativeFieldInfoPtr__Options_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoSslServerAuthenticationOptions>.NativeClassPtr, "<Options>k__BackingField");
			MonoSslServerAuthenticationOptions.NativeMethodInfoPtr_get_Options_Public_get_SslServerAuthenticationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoSslServerAuthenticationOptions>.NativeClassPtr, 100663646);
			MonoSslServerAuthenticationOptions.NativeMethodInfoPtr_get_ServerMode_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoSslServerAuthenticationOptions>.NativeClassPtr, 100663647);
			MonoSslServerAuthenticationOptions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoSslServerAuthenticationOptions>.NativeClassPtr, 100663648);
			MonoSslServerAuthenticationOptions.NativeMethodInfoPtr_get_AllowRenegotiation_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoSslServerAuthenticationOptions>.NativeClassPtr, 100663649);
			MonoSslServerAuthenticationOptions.NativeMethodInfoPtr_set_CertificateRevocationCheckMode_Public_Virtual_set_Void_X509RevocationMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoSslServerAuthenticationOptions>.NativeClassPtr, 100663650);
			MonoSslServerAuthenticationOptions.NativeMethodInfoPtr_set_EncryptionPolicy_Public_Virtual_set_Void_EncryptionPolicy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoSslServerAuthenticationOptions>.NativeClassPtr, 100663651);
			MonoSslServerAuthenticationOptions.NativeMethodInfoPtr_get_EnabledSslProtocols_Public_Virtual_get_SslProtocols_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoSslServerAuthenticationOptions>.NativeClassPtr, 100663652);
			MonoSslServerAuthenticationOptions.NativeMethodInfoPtr_set_EnabledSslProtocols_Public_Virtual_set_Void_SslProtocols_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoSslServerAuthenticationOptions>.NativeClassPtr, 100663653);
			MonoSslServerAuthenticationOptions.NativeMethodInfoPtr_get_ClientCertificateRequired_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoSslServerAuthenticationOptions>.NativeClassPtr, 100663654);
			MonoSslServerAuthenticationOptions.NativeMethodInfoPtr_set_ClientCertificateRequired_Public_Virtual_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoSslServerAuthenticationOptions>.NativeClassPtr, 100663655);
			MonoSslServerAuthenticationOptions.NativeMethodInfoPtr_get_TargetHost_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoSslServerAuthenticationOptions>.NativeClassPtr, 100663656);
			MonoSslServerAuthenticationOptions.NativeMethodInfoPtr_set_TargetHost_Public_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoSslServerAuthenticationOptions>.NativeClassPtr, 100663657);
			MonoSslServerAuthenticationOptions.NativeMethodInfoPtr_get_ServerCertificate_Public_Virtual_get_X509Certificate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoSslServerAuthenticationOptions>.NativeClassPtr, 100663658);
			MonoSslServerAuthenticationOptions.NativeMethodInfoPtr_set_ServerCertificate_Public_Virtual_set_Void_X509Certificate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoSslServerAuthenticationOptions>.NativeClassPtr, 100663659);
			MonoSslServerAuthenticationOptions.NativeMethodInfoPtr_get_ClientCertificates_Public_Virtual_get_X509CertificateCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoSslServerAuthenticationOptions>.NativeClassPtr, 100663660);
			MonoSslServerAuthenticationOptions.NativeMethodInfoPtr_set_ClientCertificates_Public_Virtual_set_Void_X509CertificateCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoSslServerAuthenticationOptions>.NativeClassPtr, 100663661);
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x000228E8 File Offset: 0x00020AE8
		public unsafe SslServerAuthenticationOptions Options
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoSslServerAuthenticationOptions.NativeMethodInfoPtr_get_Options_Public_get_SslServerAuthenticationOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SslServerAuthenticationOptions>(intPtr3) : null;
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060001E5 RID: 485 RVA: 0x00022928 File Offset: 0x00020B28
		public unsafe override bool ServerMode
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoSslServerAuthenticationOptions.NativeMethodInfoPtr_get_ServerMode_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00022964 File Offset: 0x00020B64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 428755, XrefRangeEnd = 428761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoSslServerAuthenticationOptions()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoSslServerAuthenticationOptions>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoSslServerAuthenticationOptions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060001E7 RID: 487 RVA: 0x000229A0 File Offset: 0x00020BA0
		public unsafe override bool AllowRenegotiation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoSslServerAuthenticationOptions.NativeMethodInfoPtr_get_AllowRenegotiation_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000AE RID: 174
		// (set) Token: 0x060001E8 RID: 488 RVA: 0x000229DC File Offset: 0x00020BDC
		public unsafe override X509RevocationMode CertificateRevocationCheckMode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 428761, XrefRangeEnd = 428763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoSslServerAuthenticationOptions.NativeMethodInfoPtr_set_CertificateRevocationCheckMode_Public_Virtual_set_Void_X509RevocationMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000AF RID: 175
		// (set) Token: 0x060001E9 RID: 489 RVA: 0x00022A1C File Offset: 0x00020C1C
		public unsafe override EncryptionPolicy EncryptionPolicy
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 428763, XrefRangeEnd = 428765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoSslServerAuthenticationOptions.NativeMethodInfoPtr_set_EncryptionPolicy_Public_Virtual_set_Void_EncryptionPolicy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060001EA RID: 490 RVA: 0x00022A5C File Offset: 0x00020C5C
		// (set) Token: 0x060001EB RID: 491 RVA: 0x00022A98 File Offset: 0x00020C98
		public unsafe override SslProtocols EnabledSslProtocols
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 428765, RefRangeEnd = 428767, XrefRangeStart = 428765, XrefRangeEnd = 428765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoSslServerAuthenticationOptions.NativeMethodInfoPtr_get_EnabledSslProtocols_Public_Virtual_get_SslProtocols_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoSslServerAuthenticationOptions.NativeMethodInfoPtr_set_EnabledSslProtocols_Public_Virtual_set_Void_SslProtocols_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060001EC RID: 492 RVA: 0x00022AD8 File Offset: 0x00020CD8
		// (set) Token: 0x060001ED RID: 493 RVA: 0x00022B14 File Offset: 0x00020D14
		public unsafe override bool ClientCertificateRequired
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoSslServerAuthenticationOptions.NativeMethodInfoPtr_get_ClientCertificateRequired_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoSslServerAuthenticationOptions.NativeMethodInfoPtr_set_ClientCertificateRequired_Public_Virtual_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060001EE RID: 494 RVA: 0x00022B54 File Offset: 0x00020D54
		// (set) Token: 0x060001EF RID: 495 RVA: 0x00022B8C File Offset: 0x00020D8C
		public unsafe override string TargetHost
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 428767, XrefRangeEnd = 428772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoSslServerAuthenticationOptions.NativeMethodInfoPtr_get_TargetHost_Public_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 428772, XrefRangeEnd = 428777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoSslServerAuthenticationOptions.NativeMethodInfoPtr_set_TargetHost_Public_Virtual_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060001F0 RID: 496 RVA: 0x00022BD0 File Offset: 0x00020DD0
		// (set) Token: 0x060001F1 RID: 497 RVA: 0x00022C10 File Offset: 0x00020E10
		public unsafe override X509Certificate ServerCertificate
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 373348, RefRangeEnd = 373350, XrefRangeStart = 373348, XrefRangeEnd = 373350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoSslServerAuthenticationOptions.NativeMethodInfoPtr_get_ServerCertificate_Public_Virtual_get_X509Certificate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 428777, XrefRangeEnd = 428779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoSslServerAuthenticationOptions.NativeMethodInfoPtr_set_ServerCertificate_Public_Virtual_set_Void_X509Certificate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060001F2 RID: 498 RVA: 0x00022C54 File Offset: 0x00020E54
		// (set) Token: 0x060001F3 RID: 499 RVA: 0x00022C94 File Offset: 0x00020E94
		public unsafe override X509CertificateCollection ClientCertificates
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 428779, XrefRangeEnd = 428784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoSslServerAuthenticationOptions.NativeMethodInfoPtr_get_ClientCertificates_Public_Virtual_get_X509CertificateCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509CertificateCollection>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 428784, XrefRangeEnd = 428789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoSslServerAuthenticationOptions.NativeMethodInfoPtr_set_ClientCertificates_Public_Virtual_set_Void_X509CertificateCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00002B26 File Offset: 0x00000D26
		public MonoSslServerAuthenticationOptions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060001F5 RID: 501 RVA: 0x00022CD8 File Offset: 0x00020ED8
		// (set) Token: 0x060001F6 RID: 502 RVA: 0x00002B2F File Offset: 0x00000D2F
		public unsafe SslServerAuthenticationOptions _Options_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoSslServerAuthenticationOptions.NativeFieldInfoPtr__Options_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SslServerAuthenticationOptions>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoSslServerAuthenticationOptions.NativeFieldInfoPtr__Options_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400015A RID: 346
		private static readonly IntPtr NativeFieldInfoPtr__Options_k__BackingField;

		// Token: 0x0400015B RID: 347
		private static readonly IntPtr NativeMethodInfoPtr_get_Options_Public_get_SslServerAuthenticationOptions_0;

		// Token: 0x0400015C RID: 348
		private static readonly IntPtr NativeMethodInfoPtr_get_ServerMode_Public_Virtual_get_Boolean_0;

		// Token: 0x0400015D RID: 349
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400015E RID: 350
		private static readonly IntPtr NativeMethodInfoPtr_get_AllowRenegotiation_Public_Virtual_get_Boolean_0;

		// Token: 0x0400015F RID: 351
		private static readonly IntPtr NativeMethodInfoPtr_set_CertificateRevocationCheckMode_Public_Virtual_set_Void_X509RevocationMode_0;

		// Token: 0x04000160 RID: 352
		private static readonly IntPtr NativeMethodInfoPtr_set_EncryptionPolicy_Public_Virtual_set_Void_EncryptionPolicy_0;

		// Token: 0x04000161 RID: 353
		private static readonly IntPtr NativeMethodInfoPtr_get_EnabledSslProtocols_Public_Virtual_get_SslProtocols_0;

		// Token: 0x04000162 RID: 354
		private static readonly IntPtr NativeMethodInfoPtr_set_EnabledSslProtocols_Public_Virtual_set_Void_SslProtocols_0;

		// Token: 0x04000163 RID: 355
		private static readonly IntPtr NativeMethodInfoPtr_get_ClientCertificateRequired_Public_Virtual_get_Boolean_0;

		// Token: 0x04000164 RID: 356
		private static readonly IntPtr NativeMethodInfoPtr_set_ClientCertificateRequired_Public_Virtual_set_Void_Boolean_0;

		// Token: 0x04000165 RID: 357
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetHost_Public_Virtual_get_String_0;

		// Token: 0x04000166 RID: 358
		private static readonly IntPtr NativeMethodInfoPtr_set_TargetHost_Public_Virtual_set_Void_String_0;

		// Token: 0x04000167 RID: 359
		private static readonly IntPtr NativeMethodInfoPtr_get_ServerCertificate_Public_Virtual_get_X509Certificate_0;

		// Token: 0x04000168 RID: 360
		private static readonly IntPtr NativeMethodInfoPtr_set_ServerCertificate_Public_Virtual_set_Void_X509Certificate_0;

		// Token: 0x04000169 RID: 361
		private static readonly IntPtr NativeMethodInfoPtr_get_ClientCertificates_Public_Virtual_get_X509CertificateCollection_0;

		// Token: 0x0400016A RID: 362
		private static readonly IntPtr NativeMethodInfoPtr_set_ClientCertificates_Public_Virtual_set_Void_X509CertificateCollection_0;
	}
}
