using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Net.Security;
using Il2CppSystem.Security.Authentication;
using Il2CppSystem.Security.Cryptography.X509Certificates;

namespace Il2CppMono.Net.Security
{
	// Token: 0x0200001D RID: 29
	public class MonoSslAuthenticationOptions : Object
	{
		// Token: 0x060001BB RID: 443 RVA: 0x00021B74 File Offset: 0x0001FD74
		// Note: this type is marked as 'beforefieldinit'.
		static MonoSslAuthenticationOptions()
		{
			Il2CppClassPointerStore<MonoSslAuthenticationOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Net.Security", "MonoSslAuthenticationOptions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoSslAuthenticationOptions>.NativeClassPtr);
			MonoSslAuthenticationOptions.NativeFieldInfoPtr__ServerCertSelectionDelegate_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoSslAuthenticationOptions>.NativeClassPtr, "<ServerCertSelectionDelegate>k__BackingField");
			MonoSslAuthenticationOptions.NativeMethodInfoPtr_get_ServerMode_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoSslAuthenticationOptions>.NativeClassPtr, 100663614);
			MonoSslAuthenticationOptions.NativeMethodInfoPtr_get_AllowRenegotiation_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoSslAuthenticationOptions>.NativeClassPtr, 100663615);
			MonoSslAuthenticationOptions.NativeMethodInfoPtr_get_EnabledSslProtocols_Public_Abstract_Virtual_New_get_SslProtocols_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoSslAuthenticationOptions>.NativeClassPtr, 100663616);
			MonoSslAuthenticationOptions.NativeMethodInfoPtr_set_EnabledSslProtocols_Public_Abstract_Virtual_New_set_Void_SslProtocols_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoSslAuthenticationOptions>.NativeClassPtr, 100663617);
			MonoSslAuthenticationOptions.NativeMethodInfoPtr_set_EncryptionPolicy_Public_Abstract_Virtual_New_set_Void_EncryptionPolicy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoSslAuthenticationOptions>.NativeClassPtr, 100663618);
			MonoSslAuthenticationOptions.NativeMethodInfoPtr_set_CertificateRevocationCheckMode_Public_Abstract_Virtual_New_set_Void_X509RevocationMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoSslAuthenticationOptions>.NativeClassPtr, 100663619);
			MonoSslAuthenticationOptions.NativeMethodInfoPtr_get_TargetHost_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoSslAuthenticationOptions>.NativeClassPtr, 100663620);
			MonoSslAuthenticationOptions.NativeMethodInfoPtr_set_TargetHost_Public_Abstract_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoSslAuthenticationOptions>.NativeClassPtr, 100663621);
			MonoSslAuthenticationOptions.NativeMethodInfoPtr_get_ServerCertificate_Public_Abstract_Virtual_New_get_X509Certificate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoSslAuthenticationOptions>.NativeClassPtr, 100663622);
			MonoSslAuthenticationOptions.NativeMethodInfoPtr_set_ServerCertificate_Public_Abstract_Virtual_New_set_Void_X509Certificate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoSslAuthenticationOptions>.NativeClassPtr, 100663623);
			MonoSslAuthenticationOptions.NativeMethodInfoPtr_get_ClientCertificates_Public_Abstract_Virtual_New_get_X509CertificateCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoSslAuthenticationOptions>.NativeClassPtr, 100663624);
			MonoSslAuthenticationOptions.NativeMethodInfoPtr_set_ClientCertificates_Public_Abstract_Virtual_New_set_Void_X509CertificateCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoSslAuthenticationOptions>.NativeClassPtr, 100663625);
			MonoSslAuthenticationOptions.NativeMethodInfoPtr_get_ClientCertificateRequired_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoSslAuthenticationOptions>.NativeClassPtr, 100663626);
			MonoSslAuthenticationOptions.NativeMethodInfoPtr_set_ClientCertificateRequired_Public_Abstract_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoSslAuthenticationOptions>.NativeClassPtr, 100663627);
			MonoSslAuthenticationOptions.NativeMethodInfoPtr_get_ServerCertSelectionDelegate_Internal_get_ServerCertSelectionCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoSslAuthenticationOptions>.NativeClassPtr, 100663628);
			MonoSslAuthenticationOptions.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoSslAuthenticationOptions>.NativeClassPtr, 100663629);
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060001BC RID: 444 RVA: 0x00021CF8 File Offset: 0x0001FEF8
		public unsafe virtual bool ServerMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoSslAuthenticationOptions.NativeMethodInfoPtr_get_ServerMode_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060001BD RID: 445 RVA: 0x00021D40 File Offset: 0x0001FF40
		public unsafe virtual bool AllowRenegotiation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoSslAuthenticationOptions.NativeMethodInfoPtr_get_AllowRenegotiation_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060001BE RID: 446 RVA: 0x00021D88 File Offset: 0x0001FF88
		// (set) Token: 0x060001BF RID: 447 RVA: 0x00021DD0 File Offset: 0x0001FFD0
		public unsafe virtual SslProtocols EnabledSslProtocols
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoSslAuthenticationOptions.NativeMethodInfoPtr_get_EnabledSslProtocols_Public_Abstract_Virtual_New_get_SslProtocols_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoSslAuthenticationOptions.NativeMethodInfoPtr_set_EnabledSslProtocols_Public_Abstract_Virtual_New_set_Void_SslProtocols_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000098 RID: 152
		// (set) Token: 0x060001C0 RID: 448 RVA: 0x00021E1C File Offset: 0x0002001C
		public unsafe virtual EncryptionPolicy EncryptionPolicy
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoSslAuthenticationOptions.NativeMethodInfoPtr_set_EncryptionPolicy_Public_Abstract_Virtual_New_set_Void_EncryptionPolicy_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000099 RID: 153
		// (set) Token: 0x060001C1 RID: 449 RVA: 0x00021E68 File Offset: 0x00020068
		public unsafe virtual X509RevocationMode CertificateRevocationCheckMode
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoSslAuthenticationOptions.NativeMethodInfoPtr_set_CertificateRevocationCheckMode_Public_Abstract_Virtual_New_set_Void_X509RevocationMode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060001C2 RID: 450 RVA: 0x00021EB4 File Offset: 0x000200B4
		// (set) Token: 0x060001C3 RID: 451 RVA: 0x00021EF8 File Offset: 0x000200F8
		public unsafe virtual string TargetHost
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoSslAuthenticationOptions.NativeMethodInfoPtr_get_TargetHost_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoSslAuthenticationOptions.NativeMethodInfoPtr_set_TargetHost_Public_Abstract_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060001C4 RID: 452 RVA: 0x00021F48 File Offset: 0x00020148
		// (set) Token: 0x060001C5 RID: 453 RVA: 0x00021F94 File Offset: 0x00020194
		public unsafe virtual X509Certificate ServerCertificate
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoSslAuthenticationOptions.NativeMethodInfoPtr_get_ServerCertificate_Public_Abstract_Virtual_New_get_X509Certificate_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoSslAuthenticationOptions.NativeMethodInfoPtr_set_ServerCertificate_Public_Abstract_Virtual_New_set_Void_X509Certificate_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060001C6 RID: 454 RVA: 0x00021FE4 File Offset: 0x000201E4
		// (set) Token: 0x060001C7 RID: 455 RVA: 0x00022030 File Offset: 0x00020230
		public unsafe virtual X509CertificateCollection ClientCertificates
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoSslAuthenticationOptions.NativeMethodInfoPtr_get_ClientCertificates_Public_Abstract_Virtual_New_get_X509CertificateCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509CertificateCollection>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoSslAuthenticationOptions.NativeMethodInfoPtr_set_ClientCertificates_Public_Abstract_Virtual_New_set_Void_X509CertificateCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060001C8 RID: 456 RVA: 0x00022080 File Offset: 0x00020280
		// (set) Token: 0x060001C9 RID: 457 RVA: 0x000220C8 File Offset: 0x000202C8
		public unsafe virtual bool ClientCertificateRequired
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoSslAuthenticationOptions.NativeMethodInfoPtr_get_ClientCertificateRequired_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoSslAuthenticationOptions.NativeMethodInfoPtr_set_ClientCertificateRequired_Public_Abstract_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060001CA RID: 458 RVA: 0x00022114 File Offset: 0x00020314
		public unsafe ServerCertSelectionCallback ServerCertSelectionDelegate
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoSslAuthenticationOptions.NativeMethodInfoPtr_get_ServerCertSelectionDelegate_Internal_get_ServerCertSelectionCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServerCertSelectionCallback>(intPtr3) : null;
			}
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00022154 File Offset: 0x00020354
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoSslAuthenticationOptions()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoSslAuthenticationOptions>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoSslAuthenticationOptions.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00002AD6 File Offset: 0x00000CD6
		public MonoSslAuthenticationOptions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060001CD RID: 461 RVA: 0x00022190 File Offset: 0x00020390
		// (set) Token: 0x060001CE RID: 462 RVA: 0x00002ADF File Offset: 0x00000CDF
		public unsafe ServerCertSelectionCallback _ServerCertSelectionDelegate_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoSslAuthenticationOptions.NativeFieldInfoPtr__ServerCertSelectionDelegate_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServerCertSelectionCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoSslAuthenticationOptions.NativeFieldInfoPtr__ServerCertSelectionDelegate_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000138 RID: 312
		private static readonly IntPtr NativeFieldInfoPtr__ServerCertSelectionDelegate_k__BackingField;

		// Token: 0x04000139 RID: 313
		private static readonly IntPtr NativeMethodInfoPtr_get_ServerMode_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x0400013A RID: 314
		private static readonly IntPtr NativeMethodInfoPtr_get_AllowRenegotiation_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x0400013B RID: 315
		private static readonly IntPtr NativeMethodInfoPtr_get_EnabledSslProtocols_Public_Abstract_Virtual_New_get_SslProtocols_0;

		// Token: 0x0400013C RID: 316
		private static readonly IntPtr NativeMethodInfoPtr_set_EnabledSslProtocols_Public_Abstract_Virtual_New_set_Void_SslProtocols_0;

		// Token: 0x0400013D RID: 317
		private static readonly IntPtr NativeMethodInfoPtr_set_EncryptionPolicy_Public_Abstract_Virtual_New_set_Void_EncryptionPolicy_0;

		// Token: 0x0400013E RID: 318
		private static readonly IntPtr NativeMethodInfoPtr_set_CertificateRevocationCheckMode_Public_Abstract_Virtual_New_set_Void_X509RevocationMode_0;

		// Token: 0x0400013F RID: 319
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetHost_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04000140 RID: 320
		private static readonly IntPtr NativeMethodInfoPtr_set_TargetHost_Public_Abstract_Virtual_New_set_Void_String_0;

		// Token: 0x04000141 RID: 321
		private static readonly IntPtr NativeMethodInfoPtr_get_ServerCertificate_Public_Abstract_Virtual_New_get_X509Certificate_0;

		// Token: 0x04000142 RID: 322
		private static readonly IntPtr NativeMethodInfoPtr_set_ServerCertificate_Public_Abstract_Virtual_New_set_Void_X509Certificate_0;

		// Token: 0x04000143 RID: 323
		private static readonly IntPtr NativeMethodInfoPtr_get_ClientCertificates_Public_Abstract_Virtual_New_get_X509CertificateCollection_0;

		// Token: 0x04000144 RID: 324
		private static readonly IntPtr NativeMethodInfoPtr_set_ClientCertificates_Public_Abstract_Virtual_New_set_Void_X509CertificateCollection_0;

		// Token: 0x04000145 RID: 325
		private static readonly IntPtr NativeMethodInfoPtr_get_ClientCertificateRequired_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000146 RID: 326
		private static readonly IntPtr NativeMethodInfoPtr_set_ClientCertificateRequired_Public_Abstract_Virtual_New_set_Void_Boolean_0;

		// Token: 0x04000147 RID: 327
		private static readonly IntPtr NativeMethodInfoPtr_get_ServerCertSelectionDelegate_Internal_get_ServerCertSelectionCallback_0;

		// Token: 0x04000148 RID: 328
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
