using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Security.Cryptography.X509Certificates;

namespace Il2CppMono.Security.Interface
{
	// Token: 0x0200002C RID: 44
	public sealed class MonoTlsSettings : Object
	{
		// Token: 0x06000254 RID: 596 RVA: 0x0000CEA8 File Offset: 0x0000B0A8
		// Note: this type is marked as 'beforefieldinit'.
		static MonoTlsSettings()
		{
			Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.Interface", "MonoTlsSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr);
			MonoTlsSettings.NativeFieldInfoPtr__RemoteCertificateValidationCallback_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, "<RemoteCertificateValidationCallback>k__BackingField");
			MonoTlsSettings.NativeFieldInfoPtr__ClientCertificateSelectionCallback_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, "<ClientCertificateSelectionCallback>k__BackingField");
			MonoTlsSettings.NativeFieldInfoPtr__CertificateValidationTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, "<CertificateValidationTime>k__BackingField");
			MonoTlsSettings.NativeFieldInfoPtr__TrustAnchors_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, "<TrustAnchors>k__BackingField");
			MonoTlsSettings.NativeFieldInfoPtr__UserSettings_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, "<UserSettings>k__BackingField");
			MonoTlsSettings.NativeFieldInfoPtr__CertificateSearchPaths_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, "<CertificateSearchPaths>k__BackingField");
			MonoTlsSettings.NativeFieldInfoPtr__SendCloseNotify_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, "<SendCloseNotify>k__BackingField");
			MonoTlsSettings.NativeFieldInfoPtr__ClientCertificateIssuers_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, "<ClientCertificateIssuers>k__BackingField");
			MonoTlsSettings.NativeFieldInfoPtr__DisallowUnauthenticatedCertificateRequest_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, "<DisallowUnauthenticatedCertificateRequest>k__BackingField");
			MonoTlsSettings.NativeFieldInfoPtr__EnabledProtocols_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, "<EnabledProtocols>k__BackingField");
			MonoTlsSettings.NativeFieldInfoPtr__EnabledCiphers_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, "<EnabledCiphers>k__BackingField");
			MonoTlsSettings.NativeFieldInfoPtr_cloned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, "cloned");
			MonoTlsSettings.NativeFieldInfoPtr_checkCertName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, "checkCertName");
			MonoTlsSettings.NativeFieldInfoPtr_checkCertRevocationStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, "checkCertRevocationStatus");
			MonoTlsSettings.NativeFieldInfoPtr_useServicePointManagerCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, "useServicePointManagerCallback");
			MonoTlsSettings.NativeFieldInfoPtr_skipSystemValidators = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, "skipSystemValidators");
			MonoTlsSettings.NativeFieldInfoPtr_callbackNeedsChain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, "callbackNeedsChain");
			MonoTlsSettings.NativeFieldInfoPtr_certificateValidator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, "certificateValidator");
			MonoTlsSettings.NativeFieldInfoPtr_defaultSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, "defaultSettings");
			MonoTlsSettings.NativeMethodInfoPtr_get_RemoteCertificateValidationCallback_Public_get_MonoRemoteCertificateValidationCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663643);
			MonoTlsSettings.NativeMethodInfoPtr_set_RemoteCertificateValidationCallback_Public_set_Void_MonoRemoteCertificateValidationCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663644);
			MonoTlsSettings.NativeMethodInfoPtr_get_ClientCertificateSelectionCallback_Public_get_MonoLocalCertificateSelectionCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663645);
			MonoTlsSettings.NativeMethodInfoPtr_set_ClientCertificateSelectionCallback_Public_set_Void_MonoLocalCertificateSelectionCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663646);
			MonoTlsSettings.NativeMethodInfoPtr_get_UseServicePointManagerCallback_Public_get_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663647);
			MonoTlsSettings.NativeMethodInfoPtr_set_UseServicePointManagerCallback_Public_set_Void_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663648);
			MonoTlsSettings.NativeMethodInfoPtr_get_CallbackNeedsCertificateChain_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663649);
			MonoTlsSettings.NativeMethodInfoPtr_get_CertificateValidationTime_Public_get_Nullable_1_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663650);
			MonoTlsSettings.NativeMethodInfoPtr_set_CertificateValidationTime_Public_set_Void_Nullable_1_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663651);
			MonoTlsSettings.NativeMethodInfoPtr_get_TrustAnchors_Public_get_X509CertificateCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663652);
			MonoTlsSettings.NativeMethodInfoPtr_set_TrustAnchors_Public_set_Void_X509CertificateCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663653);
			MonoTlsSettings.NativeMethodInfoPtr_get_UserSettings_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663654);
			MonoTlsSettings.NativeMethodInfoPtr_set_UserSettings_Public_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663655);
			MonoTlsSettings.NativeMethodInfoPtr_get_CertificateSearchPaths_Internal_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663656);
			MonoTlsSettings.NativeMethodInfoPtr_set_CertificateSearchPaths_Internal_set_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663657);
			MonoTlsSettings.NativeMethodInfoPtr_get_SendCloseNotify_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663658);
			MonoTlsSettings.NativeMethodInfoPtr_set_SendCloseNotify_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663659);
			MonoTlsSettings.NativeMethodInfoPtr_get_ClientCertificateIssuers_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663660);
			MonoTlsSettings.NativeMethodInfoPtr_set_ClientCertificateIssuers_Public_set_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663661);
			MonoTlsSettings.NativeMethodInfoPtr_get_DisallowUnauthenticatedCertificateRequest_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663662);
			MonoTlsSettings.NativeMethodInfoPtr_set_DisallowUnauthenticatedCertificateRequest_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663663);
			MonoTlsSettings.NativeMethodInfoPtr_get_EnabledProtocols_Public_get_Nullable_1_TlsProtocols_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663664);
			MonoTlsSettings.NativeMethodInfoPtr_set_EnabledProtocols_Public_set_Void_Nullable_1_TlsProtocols_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663665);
			MonoTlsSettings.NativeMethodInfoPtr_get_EnabledCiphers_Public_get_Il2CppStructArray_1_CipherSuiteCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663666);
			MonoTlsSettings.NativeMethodInfoPtr_set_EnabledCiphers_Public_set_Void_Il2CppStructArray_1_CipherSuiteCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663667);
			MonoTlsSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663668);
			MonoTlsSettings.NativeMethodInfoPtr_get_DefaultSettings_Public_Static_get_MonoTlsSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663669);
			MonoTlsSettings.NativeMethodInfoPtr_CopyDefaultSettings_Public_Static_MonoTlsSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663670);
			MonoTlsSettings.NativeMethodInfoPtr_get_CertificateValidator_Public_get_ICertificateValidator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663671);
			MonoTlsSettings.NativeMethodInfoPtr_CloneWithValidator_Public_MonoTlsSettings_ICertificateValidator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663672);
			MonoTlsSettings.NativeMethodInfoPtr_Clone_Public_MonoTlsSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663673);
			MonoTlsSettings.NativeMethodInfoPtr__ctor_Private_Void_MonoTlsSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663674);
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000255 RID: 597 RVA: 0x0000D2D4 File Offset: 0x0000B4D4
		// (set) Token: 0x06000256 RID: 598 RVA: 0x0000D314 File Offset: 0x0000B514
		public unsafe MonoRemoteCertificateValidationCallback RemoteCertificateValidationCallback
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsSettings.NativeMethodInfoPtr_get_RemoteCertificateValidationCallback_Public_get_MonoRemoteCertificateValidationCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoRemoteCertificateValidationCallback>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsSettings.NativeMethodInfoPtr_set_RemoteCertificateValidationCallback_Public_set_Void_MonoRemoteCertificateValidationCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000257 RID: 599 RVA: 0x0000D358 File Offset: 0x0000B558
		// (set) Token: 0x06000258 RID: 600 RVA: 0x0000D398 File Offset: 0x0000B598
		public unsafe MonoLocalCertificateSelectionCallback ClientCertificateSelectionCallback
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsSettings.NativeMethodInfoPtr_get_ClientCertificateSelectionCallback_Public_get_MonoLocalCertificateSelectionCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoLocalCertificateSelectionCallback>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsSettings.NativeMethodInfoPtr_set_ClientCertificateSelectionCallback_Public_set_Void_MonoLocalCertificateSelectionCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000259 RID: 601 RVA: 0x0000D3DC File Offset: 0x0000B5DC
		// (set) Token: 0x0600025A RID: 602 RVA: 0x0000D414 File Offset: 0x0000B614
		public unsafe Nullable<bool> UseServicePointManagerCallback
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsSettings.NativeMethodInfoPtr_get_UseServicePointManagerCallback_Public_get_Nullable_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<bool>(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsSettings.NativeMethodInfoPtr_set_UseServicePointManagerCallback_Public_set_Void_Nullable_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x0600025B RID: 603 RVA: 0x0000D45C File Offset: 0x0000B65C
		public unsafe bool CallbackNeedsCertificateChain
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsSettings.NativeMethodInfoPtr_get_CallbackNeedsCertificateChain_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x0600025C RID: 604 RVA: 0x0000D498 File Offset: 0x0000B698
		// (set) Token: 0x0600025D RID: 605 RVA: 0x0000D4D0 File Offset: 0x0000B6D0
		public unsafe Nullable<DateTime> CertificateValidationTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsSettings.NativeMethodInfoPtr_get_CertificateValidationTime_Public_get_Nullable_1_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<DateTime>(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsSettings.NativeMethodInfoPtr_set_CertificateValidationTime_Public_set_Void_Nullable_1_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x0600025E RID: 606 RVA: 0x0000D518 File Offset: 0x0000B718
		// (set) Token: 0x0600025F RID: 607 RVA: 0x0000D558 File Offset: 0x0000B758
		public unsafe X509CertificateCollection TrustAnchors
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsSettings.NativeMethodInfoPtr_get_TrustAnchors_Public_get_X509CertificateCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsSettings.NativeMethodInfoPtr_set_TrustAnchors_Public_set_Void_X509CertificateCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000260 RID: 608 RVA: 0x0000D59C File Offset: 0x0000B79C
		// (set) Token: 0x06000261 RID: 609 RVA: 0x0000D5DC File Offset: 0x0000B7DC
		public unsafe Object UserSettings
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsSettings.NativeMethodInfoPtr_get_UserSettings_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsSettings.NativeMethodInfoPtr_set_UserSettings_Public_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000262 RID: 610 RVA: 0x0000D620 File Offset: 0x0000B820
		// (set) Token: 0x06000263 RID: 611 RVA: 0x0000D660 File Offset: 0x0000B860
		public unsafe Il2CppStringArray CertificateSearchPaths
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsSettings.NativeMethodInfoPtr_get_CertificateSearchPaths_Internal_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsSettings.NativeMethodInfoPtr_set_CertificateSearchPaths_Internal_set_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000264 RID: 612 RVA: 0x0000D6A4 File Offset: 0x0000B8A4
		// (set) Token: 0x06000265 RID: 613 RVA: 0x0000D6E0 File Offset: 0x0000B8E0
		public unsafe bool SendCloseNotify
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsSettings.NativeMethodInfoPtr_get_SendCloseNotify_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsSettings.NativeMethodInfoPtr_set_SendCloseNotify_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000266 RID: 614 RVA: 0x0000D720 File Offset: 0x0000B920
		// (set) Token: 0x06000267 RID: 615 RVA: 0x0000D760 File Offset: 0x0000B960
		public unsafe Il2CppStringArray ClientCertificateIssuers
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsSettings.NativeMethodInfoPtr_get_ClientCertificateIssuers_Public_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsSettings.NativeMethodInfoPtr_set_ClientCertificateIssuers_Public_set_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000268 RID: 616 RVA: 0x0000D7A4 File Offset: 0x0000B9A4
		// (set) Token: 0x06000269 RID: 617 RVA: 0x0000D7E0 File Offset: 0x0000B9E0
		public unsafe bool DisallowUnauthenticatedCertificateRequest
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsSettings.NativeMethodInfoPtr_get_DisallowUnauthenticatedCertificateRequest_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsSettings.NativeMethodInfoPtr_set_DisallowUnauthenticatedCertificateRequest_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x0600026A RID: 618 RVA: 0x0000D820 File Offset: 0x0000BA20
		// (set) Token: 0x0600026B RID: 619 RVA: 0x0000D858 File Offset: 0x0000BA58
		public unsafe Nullable<TlsProtocols> EnabledProtocols
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsSettings.NativeMethodInfoPtr_get_EnabledProtocols_Public_get_Nullable_1_TlsProtocols_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<TlsProtocols>(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsSettings.NativeMethodInfoPtr_set_EnabledProtocols_Public_set_Void_Nullable_1_TlsProtocols_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x0600026C RID: 620 RVA: 0x0000D8A0 File Offset: 0x0000BAA0
		// (set) Token: 0x0600026D RID: 621 RVA: 0x0000D8E0 File Offset: 0x0000BAE0
		public unsafe Il2CppStructArray<CipherSuiteCode> EnabledCiphers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsSettings.NativeMethodInfoPtr_get_EnabledCiphers_Public_get_Il2CppStructArray_1_CipherSuiteCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<CipherSuiteCode>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsSettings.NativeMethodInfoPtr_set_EnabledCiphers_Public_set_Void_Il2CppStructArray_1_CipherSuiteCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600026E RID: 622 RVA: 0x0000D924 File Offset: 0x0000BB24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1149385, XrefRangeEnd = 1149386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoTlsSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x0600026F RID: 623 RVA: 0x0000D960 File Offset: 0x0000BB60
		public unsafe static MonoTlsSettings DefaultSettings
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1149393, RefRangeEnd = 1149395, XrefRangeStart = 1149386, XrefRangeEnd = 1149393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsSettings.NativeMethodInfoPtr_get_DefaultSettings_Public_Static_get_MonoTlsSettings_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoTlsSettings>(intPtr3) : null;
			}
		}

		// Token: 0x06000270 RID: 624 RVA: 0x0000D994 File Offset: 0x0000BB94
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1149406, RefRangeEnd = 1149413, XrefRangeStart = 1149395, XrefRangeEnd = 1149406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MonoTlsSettings CopyDefaultSettings()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsSettings.NativeMethodInfoPtr_CopyDefaultSettings_Public_Static_MonoTlsSettings_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoTlsSettings>(intPtr3) : null;
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000271 RID: 625 RVA: 0x0000D9C8 File Offset: 0x0000BBC8
		public unsafe ICertificateValidator CertificateValidator
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsSettings.NativeMethodInfoPtr_get_CertificateValidator_Public_get_ICertificateValidator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICertificateValidator>(intPtr3) : null;
			}
		}

		// Token: 0x06000272 RID: 626 RVA: 0x0000DA08 File Offset: 0x0000BC08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1149418, RefRangeEnd = 1149419, XrefRangeStart = 1149413, XrefRangeEnd = 1149418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoTlsSettings CloneWithValidator(ICertificateValidator validator)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(validator);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsSettings.NativeMethodInfoPtr_CloneWithValidator_Public_MonoTlsSettings_ICertificateValidator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoTlsSettings>(intPtr3) : null;
			}
		}

		// Token: 0x06000273 RID: 627 RVA: 0x0000DA58 File Offset: 0x0000BC58
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1149423, RefRangeEnd = 1149425, XrefRangeStart = 1149419, XrefRangeEnd = 1149423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoTlsSettings Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsSettings.NativeMethodInfoPtr_Clone_Public_MonoTlsSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoTlsSettings>(intPtr3) : null;
		}

		// Token: 0x06000274 RID: 628 RVA: 0x0000DA98 File Offset: 0x0000BC98
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1149441, RefRangeEnd = 1149444, XrefRangeStart = 1149425, XrefRangeEnd = 1149441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoTlsSettings(MonoTlsSettings other)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsSettings.NativeMethodInfoPtr__ctor_Private_Void_MonoTlsSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00002FD0 File Offset: 0x000011D0
		public MonoTlsSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000276 RID: 630 RVA: 0x0000DAE4 File Offset: 0x0000BCE4
		// (set) Token: 0x06000277 RID: 631 RVA: 0x00002FD9 File Offset: 0x000011D9
		public unsafe MonoRemoteCertificateValidationCallback _RemoteCertificateValidationCallback_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsSettings.NativeFieldInfoPtr__RemoteCertificateValidationCallback_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoRemoteCertificateValidationCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsSettings.NativeFieldInfoPtr__RemoteCertificateValidationCallback_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000278 RID: 632 RVA: 0x0000DB14 File Offset: 0x0000BD14
		// (set) Token: 0x06000279 RID: 633 RVA: 0x00002FF8 File Offset: 0x000011F8
		public unsafe MonoLocalCertificateSelectionCallback _ClientCertificateSelectionCallback_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsSettings.NativeFieldInfoPtr__ClientCertificateSelectionCallback_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoLocalCertificateSelectionCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsSettings.NativeFieldInfoPtr__ClientCertificateSelectionCallback_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x0600027A RID: 634 RVA: 0x0000DB44 File Offset: 0x0000BD44
		// (set) Token: 0x0600027B RID: 635 RVA: 0x00003017 File Offset: 0x00001217
		public Nullable<DateTime> _CertificateValidationTime_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsSettings.NativeFieldInfoPtr__CertificateValidationTime_k__BackingField);
				return new Nullable<DateTime>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<DateTime>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsSettings.NativeFieldInfoPtr__CertificateValidationTime_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<DateTime>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x0600027C RID: 636 RVA: 0x0000DB74 File Offset: 0x0000BD74
		// (set) Token: 0x0600027D RID: 637 RVA: 0x00003045 File Offset: 0x00001245
		public unsafe X509CertificateCollection _TrustAnchors_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsSettings.NativeFieldInfoPtr__TrustAnchors_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509CertificateCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsSettings.NativeFieldInfoPtr__TrustAnchors_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x0600027E RID: 638 RVA: 0x0000DBA4 File Offset: 0x0000BDA4
		// (set) Token: 0x0600027F RID: 639 RVA: 0x00003064 File Offset: 0x00001264
		public unsafe Object _UserSettings_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsSettings.NativeFieldInfoPtr__UserSettings_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsSettings.NativeFieldInfoPtr__UserSettings_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000280 RID: 640 RVA: 0x0000DBD4 File Offset: 0x0000BDD4
		// (set) Token: 0x06000281 RID: 641 RVA: 0x00003083 File Offset: 0x00001283
		public unsafe Il2CppStringArray _CertificateSearchPaths_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsSettings.NativeFieldInfoPtr__CertificateSearchPaths_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsSettings.NativeFieldInfoPtr__CertificateSearchPaths_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000282 RID: 642 RVA: 0x0000DC04 File Offset: 0x0000BE04
		// (set) Token: 0x06000283 RID: 643 RVA: 0x000030A2 File Offset: 0x000012A2
		public unsafe bool _SendCloseNotify_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsSettings.NativeFieldInfoPtr__SendCloseNotify_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsSettings.NativeFieldInfoPtr__SendCloseNotify_k__BackingField)) = value;
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000284 RID: 644 RVA: 0x0000DC2C File Offset: 0x0000BE2C
		// (set) Token: 0x06000285 RID: 645 RVA: 0x000030BD File Offset: 0x000012BD
		public unsafe Il2CppStringArray _ClientCertificateIssuers_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsSettings.NativeFieldInfoPtr__ClientCertificateIssuers_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsSettings.NativeFieldInfoPtr__ClientCertificateIssuers_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000286 RID: 646 RVA: 0x0000DC5C File Offset: 0x0000BE5C
		// (set) Token: 0x06000287 RID: 647 RVA: 0x000030DC File Offset: 0x000012DC
		public unsafe bool _DisallowUnauthenticatedCertificateRequest_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsSettings.NativeFieldInfoPtr__DisallowUnauthenticatedCertificateRequest_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsSettings.NativeFieldInfoPtr__DisallowUnauthenticatedCertificateRequest_k__BackingField)) = value;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000288 RID: 648 RVA: 0x0000DC84 File Offset: 0x0000BE84
		// (set) Token: 0x06000289 RID: 649 RVA: 0x000030F7 File Offset: 0x000012F7
		public Nullable<TlsProtocols> _EnabledProtocols_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsSettings.NativeFieldInfoPtr__EnabledProtocols_k__BackingField);
				return new Nullable<TlsProtocols>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<TlsProtocols>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsSettings.NativeFieldInfoPtr__EnabledProtocols_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<TlsProtocols>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x0600028A RID: 650 RVA: 0x0000DCB4 File Offset: 0x0000BEB4
		// (set) Token: 0x0600028B RID: 651 RVA: 0x00003125 File Offset: 0x00001325
		public unsafe Il2CppStructArray<CipherSuiteCode> _EnabledCiphers_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsSettings.NativeFieldInfoPtr__EnabledCiphers_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<CipherSuiteCode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsSettings.NativeFieldInfoPtr__EnabledCiphers_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x0600028C RID: 652 RVA: 0x0000DCE4 File Offset: 0x0000BEE4
		// (set) Token: 0x0600028D RID: 653 RVA: 0x00003144 File Offset: 0x00001344
		public unsafe bool cloned
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsSettings.NativeFieldInfoPtr_cloned);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsSettings.NativeFieldInfoPtr_cloned)) = value;
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x0600028E RID: 654 RVA: 0x0000DD0C File Offset: 0x0000BF0C
		// (set) Token: 0x0600028F RID: 655 RVA: 0x0000315F File Offset: 0x0000135F
		public unsafe bool checkCertName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsSettings.NativeFieldInfoPtr_checkCertName);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsSettings.NativeFieldInfoPtr_checkCertName)) = value;
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000290 RID: 656 RVA: 0x0000DD34 File Offset: 0x0000BF34
		// (set) Token: 0x06000291 RID: 657 RVA: 0x0000317A File Offset: 0x0000137A
		public unsafe bool checkCertRevocationStatus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsSettings.NativeFieldInfoPtr_checkCertRevocationStatus);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsSettings.NativeFieldInfoPtr_checkCertRevocationStatus)) = value;
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000292 RID: 658 RVA: 0x0000DD5C File Offset: 0x0000BF5C
		// (set) Token: 0x06000293 RID: 659 RVA: 0x00003195 File Offset: 0x00001395
		public Nullable<bool> useServicePointManagerCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsSettings.NativeFieldInfoPtr_useServicePointManagerCallback);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsSettings.NativeFieldInfoPtr_useServicePointManagerCallback), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000294 RID: 660 RVA: 0x0000DD8C File Offset: 0x0000BF8C
		// (set) Token: 0x06000295 RID: 661 RVA: 0x000031C3 File Offset: 0x000013C3
		public unsafe bool skipSystemValidators
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsSettings.NativeFieldInfoPtr_skipSystemValidators);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsSettings.NativeFieldInfoPtr_skipSystemValidators)) = value;
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000296 RID: 662 RVA: 0x0000DDB4 File Offset: 0x0000BFB4
		// (set) Token: 0x06000297 RID: 663 RVA: 0x000031DE File Offset: 0x000013DE
		public unsafe bool callbackNeedsChain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsSettings.NativeFieldInfoPtr_callbackNeedsChain);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsSettings.NativeFieldInfoPtr_callbackNeedsChain)) = value;
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000298 RID: 664 RVA: 0x0000DDDC File Offset: 0x0000BFDC
		// (set) Token: 0x06000299 RID: 665 RVA: 0x000031F9 File Offset: 0x000013F9
		public unsafe ICertificateValidator certificateValidator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsSettings.NativeFieldInfoPtr_certificateValidator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ICertificateValidator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsSettings.NativeFieldInfoPtr_certificateValidator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x0600029A RID: 666 RVA: 0x0000DE0C File Offset: 0x0000C00C
		// (set) Token: 0x0600029B RID: 667 RVA: 0x00003218 File Offset: 0x00001418
		public unsafe static MonoTlsSettings defaultSettings
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MonoTlsSettings.NativeFieldInfoPtr_defaultSettings, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoTlsSettings>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MonoTlsSettings.NativeFieldInfoPtr_defaultSettings, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002CE RID: 718
		private static readonly IntPtr NativeFieldInfoPtr__RemoteCertificateValidationCallback_k__BackingField;

		// Token: 0x040002CF RID: 719
		private static readonly IntPtr NativeFieldInfoPtr__ClientCertificateSelectionCallback_k__BackingField;

		// Token: 0x040002D0 RID: 720
		private static readonly IntPtr NativeFieldInfoPtr__CertificateValidationTime_k__BackingField;

		// Token: 0x040002D1 RID: 721
		private static readonly IntPtr NativeFieldInfoPtr__TrustAnchors_k__BackingField;

		// Token: 0x040002D2 RID: 722
		private static readonly IntPtr NativeFieldInfoPtr__UserSettings_k__BackingField;

		// Token: 0x040002D3 RID: 723
		private static readonly IntPtr NativeFieldInfoPtr__CertificateSearchPaths_k__BackingField;

		// Token: 0x040002D4 RID: 724
		private static readonly IntPtr NativeFieldInfoPtr__SendCloseNotify_k__BackingField;

		// Token: 0x040002D5 RID: 725
		private static readonly IntPtr NativeFieldInfoPtr__ClientCertificateIssuers_k__BackingField;

		// Token: 0x040002D6 RID: 726
		private static readonly IntPtr NativeFieldInfoPtr__DisallowUnauthenticatedCertificateRequest_k__BackingField;

		// Token: 0x040002D7 RID: 727
		private static readonly IntPtr NativeFieldInfoPtr__EnabledProtocols_k__BackingField;

		// Token: 0x040002D8 RID: 728
		private static readonly IntPtr NativeFieldInfoPtr__EnabledCiphers_k__BackingField;

		// Token: 0x040002D9 RID: 729
		private static readonly IntPtr NativeFieldInfoPtr_cloned;

		// Token: 0x040002DA RID: 730
		private static readonly IntPtr NativeFieldInfoPtr_checkCertName;

		// Token: 0x040002DB RID: 731
		private static readonly IntPtr NativeFieldInfoPtr_checkCertRevocationStatus;

		// Token: 0x040002DC RID: 732
		private static readonly IntPtr NativeFieldInfoPtr_useServicePointManagerCallback;

		// Token: 0x040002DD RID: 733
		private static readonly IntPtr NativeFieldInfoPtr_skipSystemValidators;

		// Token: 0x040002DE RID: 734
		private static readonly IntPtr NativeFieldInfoPtr_callbackNeedsChain;

		// Token: 0x040002DF RID: 735
		private static readonly IntPtr NativeFieldInfoPtr_certificateValidator;

		// Token: 0x040002E0 RID: 736
		private static readonly IntPtr NativeFieldInfoPtr_defaultSettings;

		// Token: 0x040002E1 RID: 737
		private static readonly IntPtr NativeMethodInfoPtr_get_RemoteCertificateValidationCallback_Public_get_MonoRemoteCertificateValidationCallback_0;

		// Token: 0x040002E2 RID: 738
		private static readonly IntPtr NativeMethodInfoPtr_set_RemoteCertificateValidationCallback_Public_set_Void_MonoRemoteCertificateValidationCallback_0;

		// Token: 0x040002E3 RID: 739
		private static readonly IntPtr NativeMethodInfoPtr_get_ClientCertificateSelectionCallback_Public_get_MonoLocalCertificateSelectionCallback_0;

		// Token: 0x040002E4 RID: 740
		private static readonly IntPtr NativeMethodInfoPtr_set_ClientCertificateSelectionCallback_Public_set_Void_MonoLocalCertificateSelectionCallback_0;

		// Token: 0x040002E5 RID: 741
		private static readonly IntPtr NativeMethodInfoPtr_get_UseServicePointManagerCallback_Public_get_Nullable_1_Boolean_0;

		// Token: 0x040002E6 RID: 742
		private static readonly IntPtr NativeMethodInfoPtr_set_UseServicePointManagerCallback_Public_set_Void_Nullable_1_Boolean_0;

		// Token: 0x040002E7 RID: 743
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackNeedsCertificateChain_Public_get_Boolean_0;

		// Token: 0x040002E8 RID: 744
		private static readonly IntPtr NativeMethodInfoPtr_get_CertificateValidationTime_Public_get_Nullable_1_DateTime_0;

		// Token: 0x040002E9 RID: 745
		private static readonly IntPtr NativeMethodInfoPtr_set_CertificateValidationTime_Public_set_Void_Nullable_1_DateTime_0;

		// Token: 0x040002EA RID: 746
		private static readonly IntPtr NativeMethodInfoPtr_get_TrustAnchors_Public_get_X509CertificateCollection_0;

		// Token: 0x040002EB RID: 747
		private static readonly IntPtr NativeMethodInfoPtr_set_TrustAnchors_Public_set_Void_X509CertificateCollection_0;

		// Token: 0x040002EC RID: 748
		private static readonly IntPtr NativeMethodInfoPtr_get_UserSettings_Public_get_Object_0;

		// Token: 0x040002ED RID: 749
		private static readonly IntPtr NativeMethodInfoPtr_set_UserSettings_Public_set_Void_Object_0;

		// Token: 0x040002EE RID: 750
		private static readonly IntPtr NativeMethodInfoPtr_get_CertificateSearchPaths_Internal_get_Il2CppStringArray_0;

		// Token: 0x040002EF RID: 751
		private static readonly IntPtr NativeMethodInfoPtr_set_CertificateSearchPaths_Internal_set_Void_Il2CppStringArray_0;

		// Token: 0x040002F0 RID: 752
		private static readonly IntPtr NativeMethodInfoPtr_get_SendCloseNotify_Internal_get_Boolean_0;

		// Token: 0x040002F1 RID: 753
		private static readonly IntPtr NativeMethodInfoPtr_set_SendCloseNotify_Internal_set_Void_Boolean_0;

		// Token: 0x040002F2 RID: 754
		private static readonly IntPtr NativeMethodInfoPtr_get_ClientCertificateIssuers_Public_get_Il2CppStringArray_0;

		// Token: 0x040002F3 RID: 755
		private static readonly IntPtr NativeMethodInfoPtr_set_ClientCertificateIssuers_Public_set_Void_Il2CppStringArray_0;

		// Token: 0x040002F4 RID: 756
		private static readonly IntPtr NativeMethodInfoPtr_get_DisallowUnauthenticatedCertificateRequest_Public_get_Boolean_0;

		// Token: 0x040002F5 RID: 757
		private static readonly IntPtr NativeMethodInfoPtr_set_DisallowUnauthenticatedCertificateRequest_Public_set_Void_Boolean_0;

		// Token: 0x040002F6 RID: 758
		private static readonly IntPtr NativeMethodInfoPtr_get_EnabledProtocols_Public_get_Nullable_1_TlsProtocols_0;

		// Token: 0x040002F7 RID: 759
		private static readonly IntPtr NativeMethodInfoPtr_set_EnabledProtocols_Public_set_Void_Nullable_1_TlsProtocols_0;

		// Token: 0x040002F8 RID: 760
		private static readonly IntPtr NativeMethodInfoPtr_get_EnabledCiphers_Public_get_Il2CppStructArray_1_CipherSuiteCode_0;

		// Token: 0x040002F9 RID: 761
		private static readonly IntPtr NativeMethodInfoPtr_set_EnabledCiphers_Public_set_Void_Il2CppStructArray_1_CipherSuiteCode_0;

		// Token: 0x040002FA RID: 762
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040002FB RID: 763
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultSettings_Public_Static_get_MonoTlsSettings_0;

		// Token: 0x040002FC RID: 764
		private static readonly IntPtr NativeMethodInfoPtr_CopyDefaultSettings_Public_Static_MonoTlsSettings_0;

		// Token: 0x040002FD RID: 765
		private static readonly IntPtr NativeMethodInfoPtr_get_CertificateValidator_Public_get_ICertificateValidator_0;

		// Token: 0x040002FE RID: 766
		private static readonly IntPtr NativeMethodInfoPtr_CloneWithValidator_Public_MonoTlsSettings_ICertificateValidator_0;

		// Token: 0x040002FF RID: 767
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_MonoTlsSettings_0;

		// Token: 0x04000300 RID: 768
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_MonoTlsSettings_0;
	}
}
