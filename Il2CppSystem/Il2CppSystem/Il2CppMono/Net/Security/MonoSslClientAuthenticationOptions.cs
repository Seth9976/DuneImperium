using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Net.Security;
using Il2CppSystem.Security.Authentication;
using Il2CppSystem.Security.Cryptography.X509Certificates;

namespace Il2CppMono.Net.Security
{
	// Token: 0x0200001E RID: 30
	public sealed class MonoSslClientAuthenticationOptions : MonoSslAuthenticationOptions
	{
		// Token: 0x060001CF RID: 463 RVA: 0x000221C0 File Offset: 0x000203C0
		// Note: this type is marked as 'beforefieldinit'.
		static MonoSslClientAuthenticationOptions()
		{
			Il2CppClassPointerStore<MonoSslClientAuthenticationOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Net.Security", "MonoSslClientAuthenticationOptions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoSslClientAuthenticationOptions>.NativeClassPtr);
			MonoSslClientAuthenticationOptions.NativeFieldInfoPtr__Options_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoSslClientAuthenticationOptions>.NativeClassPtr, "<Options>k__BackingField");
			MonoSslClientAuthenticationOptions.NativeMethodInfoPtr_get_Options_Public_get_SslClientAuthenticationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoSslClientAuthenticationOptions>.NativeClassPtr, 100663630);
			MonoSslClientAuthenticationOptions.NativeMethodInfoPtr_get_ServerMode_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoSslClientAuthenticationOptions>.NativeClassPtr, 100663631);
			MonoSslClientAuthenticationOptions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoSslClientAuthenticationOptions>.NativeClassPtr, 100663632);
			MonoSslClientAuthenticationOptions.NativeMethodInfoPtr_get_AllowRenegotiation_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoSslClientAuthenticationOptions>.NativeClassPtr, 100663633);
			MonoSslClientAuthenticationOptions.NativeMethodInfoPtr_set_CertificateRevocationCheckMode_Public_Virtual_set_Void_X509RevocationMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoSslClientAuthenticationOptions>.NativeClassPtr, 100663634);
			MonoSslClientAuthenticationOptions.NativeMethodInfoPtr_set_EncryptionPolicy_Public_Virtual_set_Void_EncryptionPolicy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoSslClientAuthenticationOptions>.NativeClassPtr, 100663635);
			MonoSslClientAuthenticationOptions.NativeMethodInfoPtr_get_EnabledSslProtocols_Public_Virtual_get_SslProtocols_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoSslClientAuthenticationOptions>.NativeClassPtr, 100663636);
			MonoSslClientAuthenticationOptions.NativeMethodInfoPtr_set_EnabledSslProtocols_Public_Virtual_set_Void_SslProtocols_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoSslClientAuthenticationOptions>.NativeClassPtr, 100663637);
			MonoSslClientAuthenticationOptions.NativeMethodInfoPtr_get_TargetHost_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoSslClientAuthenticationOptions>.NativeClassPtr, 100663638);
			MonoSslClientAuthenticationOptions.NativeMethodInfoPtr_set_TargetHost_Public_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoSslClientAuthenticationOptions>.NativeClassPtr, 100663639);
			MonoSslClientAuthenticationOptions.NativeMethodInfoPtr_get_ClientCertificateRequired_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoSslClientAuthenticationOptions>.NativeClassPtr, 100663640);
			MonoSslClientAuthenticationOptions.NativeMethodInfoPtr_set_ClientCertificateRequired_Public_Virtual_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoSslClientAuthenticationOptions>.NativeClassPtr, 100663641);
			MonoSslClientAuthenticationOptions.NativeMethodInfoPtr_get_ClientCertificates_Public_Virtual_get_X509CertificateCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoSslClientAuthenticationOptions>.NativeClassPtr, 100663642);
			MonoSslClientAuthenticationOptions.NativeMethodInfoPtr_set_ClientCertificates_Public_Virtual_set_Void_X509CertificateCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoSslClientAuthenticationOptions>.NativeClassPtr, 100663643);
			MonoSslClientAuthenticationOptions.NativeMethodInfoPtr_get_ServerCertificate_Public_Virtual_get_X509Certificate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoSslClientAuthenticationOptions>.NativeClassPtr, 100663644);
			MonoSslClientAuthenticationOptions.NativeMethodInfoPtr_set_ServerCertificate_Public_Virtual_set_Void_X509Certificate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoSslClientAuthenticationOptions>.NativeClassPtr, 100663645);
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060001D0 RID: 464 RVA: 0x00022344 File Offset: 0x00020544
		public unsafe SslClientAuthenticationOptions Options
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoSslClientAuthenticationOptions.NativeMethodInfoPtr_get_Options_Public_get_SslClientAuthenticationOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SslClientAuthenticationOptions>(intPtr3) : null;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x00022384 File Offset: 0x00020584
		public unsafe override bool ServerMode
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoSslClientAuthenticationOptions.NativeMethodInfoPtr_get_ServerMode_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x000223C0 File Offset: 0x000205C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 428708, XrefRangeEnd = 428714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoSslClientAuthenticationOptions()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoSslClientAuthenticationOptions>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoSslClientAuthenticationOptions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x000223FC File Offset: 0x000205FC
		public unsafe override bool AllowRenegotiation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoSslClientAuthenticationOptions.NativeMethodInfoPtr_get_AllowRenegotiation_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000A3 RID: 163
		// (set) Token: 0x060001D4 RID: 468 RVA: 0x00022438 File Offset: 0x00020638
		public unsafe override X509RevocationMode CertificateRevocationCheckMode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 428714, XrefRangeEnd = 428716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoSslClientAuthenticationOptions.NativeMethodInfoPtr_set_CertificateRevocationCheckMode_Public_Virtual_set_Void_X509RevocationMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000A4 RID: 164
		// (set) Token: 0x060001D5 RID: 469 RVA: 0x00022478 File Offset: 0x00020678
		public unsafe override EncryptionPolicy EncryptionPolicy
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 428716, XrefRangeEnd = 428718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoSslClientAuthenticationOptions.NativeMethodInfoPtr_set_EncryptionPolicy_Public_Virtual_set_Void_EncryptionPolicy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x000224B8 File Offset: 0x000206B8
		// (set) Token: 0x060001D7 RID: 471 RVA: 0x000224F4 File Offset: 0x000206F4
		public unsafe override SslProtocols EnabledSslProtocols
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 428718, RefRangeEnd = 428731, XrefRangeStart = 428718, XrefRangeEnd = 428718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoSslClientAuthenticationOptions.NativeMethodInfoPtr_get_EnabledSslProtocols_Public_Virtual_get_SslProtocols_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoSslClientAuthenticationOptions.NativeMethodInfoPtr_set_EnabledSslProtocols_Public_Virtual_set_Void_SslProtocols_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x00022534 File Offset: 0x00020734
		// (set) Token: 0x060001D9 RID: 473 RVA: 0x0002256C File Offset: 0x0002076C
		public unsafe override string TargetHost
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoSslClientAuthenticationOptions.NativeMethodInfoPtr_get_TargetHost_Public_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 428731, XrefRangeEnd = 428733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoSslClientAuthenticationOptions.NativeMethodInfoPtr_set_TargetHost_Public_Virtual_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060001DA RID: 474 RVA: 0x000225B0 File Offset: 0x000207B0
		// (set) Token: 0x060001DB RID: 475 RVA: 0x000225EC File Offset: 0x000207EC
		public unsafe override bool ClientCertificateRequired
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 428733, XrefRangeEnd = 428738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoSslClientAuthenticationOptions.NativeMethodInfoPtr_get_ClientCertificateRequired_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 428738, XrefRangeEnd = 428743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoSslClientAuthenticationOptions.NativeMethodInfoPtr_set_ClientCertificateRequired_Public_Virtual_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060001DC RID: 476 RVA: 0x0002262C File Offset: 0x0002082C
		// (set) Token: 0x060001DD RID: 477 RVA: 0x0002266C File Offset: 0x0002086C
		public unsafe override X509CertificateCollection ClientCertificates
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoSslClientAuthenticationOptions.NativeMethodInfoPtr_get_ClientCertificates_Public_Virtual_get_X509CertificateCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509CertificateCollection>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 428743, XrefRangeEnd = 428745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoSslClientAuthenticationOptions.NativeMethodInfoPtr_set_ClientCertificates_Public_Virtual_set_Void_X509CertificateCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060001DE RID: 478 RVA: 0x000226B0 File Offset: 0x000208B0
		// (set) Token: 0x060001DF RID: 479 RVA: 0x000226F0 File Offset: 0x000208F0
		public unsafe override X509Certificate ServerCertificate
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 428745, XrefRangeEnd = 428750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoSslClientAuthenticationOptions.NativeMethodInfoPtr_get_ServerCertificate_Public_Virtual_get_X509Certificate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 428750, XrefRangeEnd = 428755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoSslClientAuthenticationOptions.NativeMethodInfoPtr_set_ServerCertificate_Public_Virtual_set_Void_X509Certificate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00002AFE File Offset: 0x00000CFE
		public MonoSslClientAuthenticationOptions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060001E1 RID: 481 RVA: 0x00022734 File Offset: 0x00020934
		// (set) Token: 0x060001E2 RID: 482 RVA: 0x00002B07 File Offset: 0x00000D07
		public unsafe SslClientAuthenticationOptions _Options_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoSslClientAuthenticationOptions.NativeFieldInfoPtr__Options_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SslClientAuthenticationOptions>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoSslClientAuthenticationOptions.NativeFieldInfoPtr__Options_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000149 RID: 329
		private static readonly IntPtr NativeFieldInfoPtr__Options_k__BackingField;

		// Token: 0x0400014A RID: 330
		private static readonly IntPtr NativeMethodInfoPtr_get_Options_Public_get_SslClientAuthenticationOptions_0;

		// Token: 0x0400014B RID: 331
		private static readonly IntPtr NativeMethodInfoPtr_get_ServerMode_Public_Virtual_get_Boolean_0;

		// Token: 0x0400014C RID: 332
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400014D RID: 333
		private static readonly IntPtr NativeMethodInfoPtr_get_AllowRenegotiation_Public_Virtual_get_Boolean_0;

		// Token: 0x0400014E RID: 334
		private static readonly IntPtr NativeMethodInfoPtr_set_CertificateRevocationCheckMode_Public_Virtual_set_Void_X509RevocationMode_0;

		// Token: 0x0400014F RID: 335
		private static readonly IntPtr NativeMethodInfoPtr_set_EncryptionPolicy_Public_Virtual_set_Void_EncryptionPolicy_0;

		// Token: 0x04000150 RID: 336
		private static readonly IntPtr NativeMethodInfoPtr_get_EnabledSslProtocols_Public_Virtual_get_SslProtocols_0;

		// Token: 0x04000151 RID: 337
		private static readonly IntPtr NativeMethodInfoPtr_set_EnabledSslProtocols_Public_Virtual_set_Void_SslProtocols_0;

		// Token: 0x04000152 RID: 338
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetHost_Public_Virtual_get_String_0;

		// Token: 0x04000153 RID: 339
		private static readonly IntPtr NativeMethodInfoPtr_set_TargetHost_Public_Virtual_set_Void_String_0;

		// Token: 0x04000154 RID: 340
		private static readonly IntPtr NativeMethodInfoPtr_get_ClientCertificateRequired_Public_Virtual_get_Boolean_0;

		// Token: 0x04000155 RID: 341
		private static readonly IntPtr NativeMethodInfoPtr_set_ClientCertificateRequired_Public_Virtual_set_Void_Boolean_0;

		// Token: 0x04000156 RID: 342
		private static readonly IntPtr NativeMethodInfoPtr_get_ClientCertificates_Public_Virtual_get_X509CertificateCollection_0;

		// Token: 0x04000157 RID: 343
		private static readonly IntPtr NativeMethodInfoPtr_set_ClientCertificates_Public_Virtual_set_Void_X509CertificateCollection_0;

		// Token: 0x04000158 RID: 344
		private static readonly IntPtr NativeMethodInfoPtr_get_ServerCertificate_Public_Virtual_get_X509Certificate_0;

		// Token: 0x04000159 RID: 345
		private static readonly IntPtr NativeMethodInfoPtr_set_ServerCertificate_Public_Virtual_set_Void_X509Certificate_0;
	}
}
