using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono.Security.X509;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x020000D6 RID: 214
	public class X509ChainImplMono : X509ChainImpl
	{
		// Token: 0x06000E1D RID: 3613 RVA: 0x00051618 File Offset: 0x0004F818
		// Note: this type is marked as 'beforefieldinit'.
		static X509ChainImplMono()
		{
			Il2CppClassPointerStore<X509ChainImplMono>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Security.Cryptography.X509Certificates", "X509ChainImplMono");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509ChainImplMono>.NativeClassPtr);
			X509ChainImplMono.NativeFieldInfoPtr_location = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainImplMono>.NativeClassPtr, "location");
			X509ChainImplMono.NativeFieldInfoPtr_elements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainImplMono>.NativeClassPtr, "elements");
			X509ChainImplMono.NativeFieldInfoPtr_policy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainImplMono>.NativeClassPtr, "policy");
			X509ChainImplMono.NativeFieldInfoPtr_status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainImplMono>.NativeClassPtr, "status");
			X509ChainImplMono.NativeFieldInfoPtr_Empty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainImplMono>.NativeClassPtr, "Empty");
			X509ChainImplMono.NativeFieldInfoPtr_max_path_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainImplMono>.NativeClassPtr, "max_path_length");
			X509ChainImplMono.NativeFieldInfoPtr_working_issuer_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainImplMono>.NativeClassPtr, "working_issuer_name");
			X509ChainImplMono.NativeFieldInfoPtr_working_public_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainImplMono>.NativeClassPtr, "working_public_key");
			X509ChainImplMono.NativeFieldInfoPtr_bce_restriction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainImplMono>.NativeClassPtr, "bce_restriction");
			X509ChainImplMono.NativeFieldInfoPtr_roots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainImplMono>.NativeClassPtr, "roots");
			X509ChainImplMono.NativeFieldInfoPtr_cas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainImplMono>.NativeClassPtr, "cas");
			X509ChainImplMono.NativeFieldInfoPtr_root_store = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainImplMono>.NativeClassPtr, "root_store");
			X509ChainImplMono.NativeFieldInfoPtr_ca_store = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainImplMono>.NativeClassPtr, "ca_store");
			X509ChainImplMono.NativeFieldInfoPtr_user_root_store = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainImplMono>.NativeClassPtr, "user_root_store");
			X509ChainImplMono.NativeFieldInfoPtr_user_ca_store = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainImplMono>.NativeClassPtr, "user_ca_store");
			X509ChainImplMono.NativeFieldInfoPtr_collection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainImplMono>.NativeClassPtr, "collection");
			X509ChainImplMono.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImplMono>.NativeClassPtr, 100665359);
			X509ChainImplMono.NativeMethodInfoPtr_get_IsValid_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImplMono>.NativeClassPtr, 100665360);
			X509ChainImplMono.NativeMethodInfoPtr_get_ChainElements_Public_Virtual_get_X509ChainElementCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImplMono>.NativeClassPtr, 100665361);
			X509ChainImplMono.NativeMethodInfoPtr_get_ChainPolicy_Public_Virtual_get_X509ChainPolicy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImplMono>.NativeClassPtr, 100665362);
			X509ChainImplMono.NativeMethodInfoPtr_get_ChainStatus_Public_Virtual_get_Il2CppReferenceArray_1_X509ChainStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImplMono>.NativeClassPtr, 100665363);
			X509ChainImplMono.NativeMethodInfoPtr_AddStatus_Public_Virtual_Void_X509ChainStatusFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImplMono>.NativeClassPtr, 100665364);
			X509ChainImplMono.NativeMethodInfoPtr_Build_Public_Virtual_Boolean_X509Certificate2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImplMono>.NativeClassPtr, 100665365);
			X509ChainImplMono.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImplMono>.NativeClassPtr, 100665366);
			X509ChainImplMono.NativeMethodInfoPtr_get_Roots_Private_get_X509Certificate2Collection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImplMono>.NativeClassPtr, 100665367);
			X509ChainImplMono.NativeMethodInfoPtr_get_CertificateAuthorities_Private_get_X509Certificate2Collection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImplMono>.NativeClassPtr, 100665368);
			X509ChainImplMono.NativeMethodInfoPtr_get_LMRootStore_Private_get_X509Store_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImplMono>.NativeClassPtr, 100665369);
			X509ChainImplMono.NativeMethodInfoPtr_get_UserRootStore_Private_get_X509Store_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImplMono>.NativeClassPtr, 100665370);
			X509ChainImplMono.NativeMethodInfoPtr_get_LMCAStore_Private_get_X509Store_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImplMono>.NativeClassPtr, 100665371);
			X509ChainImplMono.NativeMethodInfoPtr_get_UserCAStore_Private_get_X509Store_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImplMono>.NativeClassPtr, 100665372);
			X509ChainImplMono.NativeMethodInfoPtr_get_CertificateCollection_Private_get_X509Certificate2Collection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImplMono>.NativeClassPtr, 100665373);
			X509ChainImplMono.NativeMethodInfoPtr_BuildChainFrom_Private_X509ChainStatusFlags_X509Certificate2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImplMono>.NativeClassPtr, 100665374);
			X509ChainImplMono.NativeMethodInfoPtr_SelectBestFromCollection_Private_X509Certificate2_X509Certificate2_X509Certificate2Collection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImplMono>.NativeClassPtr, 100665375);
			X509ChainImplMono.NativeMethodInfoPtr_FindParent_Private_X509Certificate2_X509Certificate2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImplMono>.NativeClassPtr, 100665376);
			X509ChainImplMono.NativeMethodInfoPtr_IsChainComplete_Private_Boolean_X509Certificate2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImplMono>.NativeClassPtr, 100665377);
			X509ChainImplMono.NativeMethodInfoPtr_IsSelfIssued_Private_Boolean_X509Certificate2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImplMono>.NativeClassPtr, 100665378);
			X509ChainImplMono.NativeMethodInfoPtr_ValidateChain_Private_Void_X509ChainStatusFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImplMono>.NativeClassPtr, 100665379);
			X509ChainImplMono.NativeMethodInfoPtr_Process_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImplMono>.NativeClassPtr, 100665380);
			X509ChainImplMono.NativeMethodInfoPtr_PrepareForNextCertificate_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImplMono>.NativeClassPtr, 100665381);
			X509ChainImplMono.NativeMethodInfoPtr_WrapUp_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImplMono>.NativeClassPtr, 100665382);
			X509ChainImplMono.NativeMethodInfoPtr_ProcessCertificateExtensions_Private_Void_X509ChainElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImplMono>.NativeClassPtr, 100665383);
			X509ChainImplMono.NativeMethodInfoPtr_IsSignedWith_Private_Boolean_X509Certificate2_AsymmetricAlgorithm_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImplMono>.NativeClassPtr, 100665384);
			X509ChainImplMono.NativeMethodInfoPtr_GetSubjectKeyIdentifier_Private_String_X509Certificate2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImplMono>.NativeClassPtr, 100665385);
			X509ChainImplMono.NativeMethodInfoPtr_GetAuthorityKeyIdentifier_Private_Static_String_X509Certificate2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImplMono>.NativeClassPtr, 100665386);
			X509ChainImplMono.NativeMethodInfoPtr_GetAuthorityKeyIdentifier_Private_Static_String_X509Crl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImplMono>.NativeClassPtr, 100665387);
			X509ChainImplMono.NativeMethodInfoPtr_GetAuthorityKeyIdentifier_Private_Static_String_X509Extension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImplMono>.NativeClassPtr, 100665388);
			X509ChainImplMono.NativeMethodInfoPtr_CheckRevocationOnChain_Private_Void_X509ChainStatusFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImplMono>.NativeClassPtr, 100665389);
			X509ChainImplMono.NativeMethodInfoPtr_CheckRevocation_Private_X509ChainStatusFlags_X509Certificate2_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImplMono>.NativeClassPtr, 100665390);
			X509ChainImplMono.NativeMethodInfoPtr_CheckRevocation_Private_X509ChainStatusFlags_X509Certificate2_X509Certificate2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImplMono>.NativeClassPtr, 100665391);
			X509ChainImplMono.NativeMethodInfoPtr_CheckCrls_Private_Static_X509Crl_String_String_X509Store_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImplMono>.NativeClassPtr, 100665392);
			X509ChainImplMono.NativeMethodInfoPtr_FindCrl_Private_X509Crl_X509Certificate2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImplMono>.NativeClassPtr, 100665393);
			X509ChainImplMono.NativeMethodInfoPtr_ProcessCrlExtensions_Private_Boolean_X509Crl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImplMono>.NativeClassPtr, 100665394);
			X509ChainImplMono.NativeMethodInfoPtr_ProcessCrlEntryExtensions_Private_Boolean_X509CrlEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImplMono>.NativeClassPtr, 100665395);
		}

		// Token: 0x06000E1E RID: 3614 RVA: 0x00051A6C File Offset: 0x0004FC6C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 454704, RefRangeEnd = 454709, XrefRangeStart = 454669, XrefRangeEnd = 454704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509ChainImplMono(bool useMachineContext)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509ChainImplMono>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref useMachineContext;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainImplMono.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x06000E1F RID: 3615 RVA: 0x00051AB4 File Offset: 0x0004FCB4
		public unsafe override bool IsValid
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509ChainImplMono.NativeMethodInfoPtr_get_IsValid_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x06000E20 RID: 3616 RVA: 0x00051AFC File Offset: 0x0004FCFC
		public unsafe override X509ChainElementCollection ChainElements
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509ChainImplMono.NativeMethodInfoPtr_get_ChainElements_Public_Virtual_get_X509ChainElementCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509ChainElementCollection>(intPtr3) : null;
			}
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x06000E21 RID: 3617 RVA: 0x00051B48 File Offset: 0x0004FD48
		public unsafe override X509ChainPolicy ChainPolicy
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509ChainImplMono.NativeMethodInfoPtr_get_ChainPolicy_Public_Virtual_get_X509ChainPolicy_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509ChainPolicy>(intPtr3) : null;
			}
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x06000E22 RID: 3618 RVA: 0x00051B94 File Offset: 0x0004FD94
		public unsafe override Il2CppReferenceArray<X509ChainStatus> ChainStatus
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 454709, XrefRangeEnd = 454710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509ChainImplMono.NativeMethodInfoPtr_get_ChainStatus_Public_Virtual_get_Il2CppReferenceArray_1_X509ChainStatus_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<X509ChainStatus>>(intPtr3) : null;
			}
		}

		// Token: 0x06000E23 RID: 3619 RVA: 0x00051BE0 File Offset: 0x0004FDE0
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AddStatus(X509ChainStatusFlags error)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref error;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509ChainImplMono.NativeMethodInfoPtr_AddStatus_Public_Virtual_Void_X509ChainStatusFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E24 RID: 3620 RVA: 0x00051C2C File Offset: 0x0004FE2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 454710, XrefRangeEnd = 454757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Build(X509Certificate2 certificate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(certificate);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509ChainImplMono.NativeMethodInfoPtr_Build_Public_Virtual_Boolean_X509Certificate2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E25 RID: 3621 RVA: 0x00051C84 File Offset: 0x0004FE84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 454757, XrefRangeEnd = 454776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509ChainImplMono.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x06000E26 RID: 3622 RVA: 0x00051CC0 File Offset: 0x0004FEC0
		public unsafe X509Certificate2Collection Roots
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 454785, RefRangeEnd = 454787, XrefRangeStart = 454776, XrefRangeEnd = 454785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainImplMono.NativeMethodInfoPtr_get_Roots_Private_get_X509Certificate2Collection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate2Collection>(intPtr3) : null;
			}
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x06000E27 RID: 3623 RVA: 0x00051D00 File Offset: 0x0004FF00
		public unsafe X509Certificate2Collection CertificateAuthorities
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 454796, RefRangeEnd = 454797, XrefRangeStart = 454787, XrefRangeEnd = 454796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainImplMono.NativeMethodInfoPtr_get_CertificateAuthorities_Private_get_X509Certificate2Collection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate2Collection>(intPtr3) : null;
			}
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x06000E28 RID: 3624 RVA: 0x00051D40 File Offset: 0x0004FF40
		public unsafe X509Store LMRootStore
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 454804, RefRangeEnd = 454806, XrefRangeStart = 454797, XrefRangeEnd = 454804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainImplMono.NativeMethodInfoPtr_get_LMRootStore_Private_get_X509Store_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Store>(intPtr3) : null;
			}
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x06000E29 RID: 3625 RVA: 0x00051D80 File Offset: 0x0004FF80
		public unsafe X509Store UserRootStore
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 454813, RefRangeEnd = 454815, XrefRangeStart = 454806, XrefRangeEnd = 454813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainImplMono.NativeMethodInfoPtr_get_UserRootStore_Private_get_X509Store_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Store>(intPtr3) : null;
			}
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x06000E2A RID: 3626 RVA: 0x00051DC0 File Offset: 0x0004FFC0
		public unsafe X509Store LMCAStore
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 454822, RefRangeEnd = 454824, XrefRangeStart = 454815, XrefRangeEnd = 454822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainImplMono.NativeMethodInfoPtr_get_LMCAStore_Private_get_X509Store_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Store>(intPtr3) : null;
			}
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x06000E2B RID: 3627 RVA: 0x00051E00 File Offset: 0x00050000
		public unsafe X509Store UserCAStore
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 454831, RefRangeEnd = 454833, XrefRangeStart = 454824, XrefRangeEnd = 454831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainImplMono.NativeMethodInfoPtr_get_UserCAStore_Private_get_X509Store_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Store>(intPtr3) : null;
			}
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x06000E2C RID: 3628 RVA: 0x00051E40 File Offset: 0x00050040
		public unsafe X509Certificate2Collection CertificateCollection
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 454841, RefRangeEnd = 454845, XrefRangeStart = 454833, XrefRangeEnd = 454841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainImplMono.NativeMethodInfoPtr_get_CertificateCollection_Private_get_X509Certificate2Collection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate2Collection>(intPtr3) : null;
			}
		}

		// Token: 0x06000E2D RID: 3629 RVA: 0x00051E80 File Offset: 0x00050080
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 454877, RefRangeEnd = 454878, XrefRangeStart = 454845, XrefRangeEnd = 454877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509ChainStatusFlags BuildChainFrom(X509Certificate2 certificate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(certificate);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainImplMono.NativeMethodInfoPtr_BuildChainFrom_Private_X509ChainStatusFlags_X509Certificate2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E2E RID: 3630 RVA: 0x00051ED0 File Offset: 0x000500D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 454883, RefRangeEnd = 454885, XrefRangeStart = 454878, XrefRangeEnd = 454883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509Certificate2 SelectBestFromCollection(X509Certificate2 child, X509Certificate2Collection c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(child);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(c);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainImplMono.NativeMethodInfoPtr_SelectBestFromCollection_Private_X509Certificate2_X509Certificate2_X509Certificate2Collection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate2>(intPtr3) : null;
		}

		// Token: 0x06000E2F RID: 3631 RVA: 0x00051F34 File Offset: 0x00050134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 454885, XrefRangeEnd = 454895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509Certificate2 FindParent(X509Certificate2 certificate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(certificate);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainImplMono.NativeMethodInfoPtr_FindParent_Private_X509Certificate2_X509Certificate2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate2>(intPtr3) : null;
			}
		}

		// Token: 0x06000E30 RID: 3632 RVA: 0x00051F84 File Offset: 0x00050184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 454895, XrefRangeEnd = 454910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsChainComplete(X509Certificate2 certificate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(certificate);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainImplMono.NativeMethodInfoPtr_IsChainComplete_Private_Boolean_X509Certificate2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E31 RID: 3633 RVA: 0x00051FD4 File Offset: 0x000501D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 454910, XrefRangeEnd = 454914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsSelfIssued(X509Certificate2 certificate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(certificate);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainImplMono.NativeMethodInfoPtr_IsSelfIssued_Private_Boolean_X509Certificate2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E32 RID: 3634 RVA: 0x00052024 File Offset: 0x00050224
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 454933, RefRangeEnd = 454934, XrefRangeStart = 454914, XrefRangeEnd = 454933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateChain(X509ChainStatusFlags flag)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flag;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainImplMono.NativeMethodInfoPtr_ValidateChain_Private_Void_X509ChainStatusFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E33 RID: 3635 RVA: 0x00052064 File Offset: 0x00050264
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 454963, RefRangeEnd = 454966, XrefRangeStart = 454934, XrefRangeEnd = 454963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Process(int n)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref n;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainImplMono.NativeMethodInfoPtr_Process_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E34 RID: 3636 RVA: 0x000520A4 File Offset: 0x000502A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 455012, RefRangeEnd = 455013, XrefRangeStart = 454966, XrefRangeEnd = 455012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PrepareForNextCertificate(int n)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref n;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainImplMono.NativeMethodInfoPtr_PrepareForNextCertificate_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E35 RID: 3637 RVA: 0x000520E4 File Offset: 0x000502E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 455013, XrefRangeEnd = 455021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WrapUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainImplMono.NativeMethodInfoPtr_WrapUp_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E36 RID: 3638 RVA: 0x00052118 File Offset: 0x00050318
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 455038, RefRangeEnd = 455041, XrefRangeStart = 455021, XrefRangeEnd = 455038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessCertificateExtensions(X509ChainElement element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainImplMono.NativeMethodInfoPtr_ProcessCertificateExtensions_Private_Void_X509ChainElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E37 RID: 3639 RVA: 0x0005215C File Offset: 0x0005035C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 455041, XrefRangeEnd = 455043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsSignedWith(X509Certificate2 signed, AsymmetricAlgorithm pubkey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(signed);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pubkey);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainImplMono.NativeMethodInfoPtr_IsSignedWith_Private_Boolean_X509Certificate2_AsymmetricAlgorithm_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E38 RID: 3640 RVA: 0x000521BC File Offset: 0x000503BC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 455052, RefRangeEnd = 455055, XrefRangeStart = 455043, XrefRangeEnd = 455052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetSubjectKeyIdentifier(X509Certificate2 certificate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(certificate);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainImplMono.NativeMethodInfoPtr_GetSubjectKeyIdentifier_Private_String_X509Certificate2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000E39 RID: 3641 RVA: 0x00052204 File Offset: 0x00050404
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 455064, RefRangeEnd = 455068, XrefRangeStart = 455055, XrefRangeEnd = 455064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetAuthorityKeyIdentifier(X509Certificate2 certificate)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(certificate);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainImplMono.NativeMethodInfoPtr_GetAuthorityKeyIdentifier_Private_Static_String_X509Certificate2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000E3A RID: 3642 RVA: 0x00052240 File Offset: 0x00050440
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 455076, RefRangeEnd = 455077, XrefRangeStart = 455068, XrefRangeEnd = 455076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetAuthorityKeyIdentifier(X509Crl crl)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(crl);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainImplMono.NativeMethodInfoPtr_GetAuthorityKeyIdentifier_Private_Static_String_X509Crl_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000E3B RID: 3643 RVA: 0x0005227C File Offset: 0x0005047C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 455092, RefRangeEnd = 455094, XrefRangeStart = 455077, XrefRangeEnd = 455092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetAuthorityKeyIdentifier(X509Extension ext)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ext);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainImplMono.NativeMethodInfoPtr_GetAuthorityKeyIdentifier_Private_Static_String_X509Extension_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000E3C RID: 3644 RVA: 0x000522B8 File Offset: 0x000504B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 455102, RefRangeEnd = 455103, XrefRangeStart = 455094, XrefRangeEnd = 455102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckRevocationOnChain(X509ChainStatusFlags flag)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flag;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainImplMono.NativeMethodInfoPtr_CheckRevocationOnChain_Private_Void_X509ChainStatusFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E3D RID: 3645 RVA: 0x000522F8 File Offset: 0x000504F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 455111, RefRangeEnd = 455112, XrefRangeStart = 455103, XrefRangeEnd = 455111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509ChainStatusFlags CheckRevocation(X509Certificate2 certificate, int ca, bool online)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(certificate);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ca;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref online;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainImplMono.NativeMethodInfoPtr_CheckRevocation_Private_X509ChainStatusFlags_X509Certificate2_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E3E RID: 3646 RVA: 0x00052364 File Offset: 0x00050564
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 455130, RefRangeEnd = 455132, XrefRangeStart = 455112, XrefRangeEnd = 455130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509ChainStatusFlags CheckRevocation(X509Certificate2 certificate, X509Certificate2 ca_cert, bool online)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(certificate);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ca_cert);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref online;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainImplMono.NativeMethodInfoPtr_CheckRevocation_Private_X509ChainStatusFlags_X509Certificate2_X509Certificate2_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E3F RID: 3647 RVA: 0x000523D4 File Offset: 0x000505D4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 455148, RefRangeEnd = 455152, XrefRangeStart = 455132, XrefRangeEnd = 455148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static X509Crl CheckCrls(string subject, string ski, X509Store store)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(subject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ski);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(store);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainImplMono.NativeMethodInfoPtr_CheckCrls_Private_Static_X509Crl_String_String_X509Store_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Crl>(intPtr3) : null;
		}

		// Token: 0x06000E40 RID: 3648 RVA: 0x0005243C File Offset: 0x0005063C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 455185, RefRangeEnd = 455186, XrefRangeStart = 455152, XrefRangeEnd = 455185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509Crl FindCrl(X509Certificate2 caCertificate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(caCertificate);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainImplMono.NativeMethodInfoPtr_FindCrl_Private_X509Crl_X509Certificate2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Crl>(intPtr3) : null;
			}
		}

		// Token: 0x06000E41 RID: 3649 RVA: 0x0005248C File Offset: 0x0005068C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 455186, XrefRangeEnd = 455202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ProcessCrlExtensions(X509Crl crl)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(crl);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainImplMono.NativeMethodInfoPtr_ProcessCrlExtensions_Private_Boolean_X509Crl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E42 RID: 3650 RVA: 0x000524DC File Offset: 0x000506DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 455215, RefRangeEnd = 455216, XrefRangeStart = 455202, XrefRangeEnd = 455215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ProcessCrlEntryExtensions(X509Crl.X509CrlEntry entry)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entry);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainImplMono.NativeMethodInfoPtr_ProcessCrlEntryExtensions_Private_Boolean_X509CrlEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E43 RID: 3651 RVA: 0x0000714B File Offset: 0x0000534B
		public X509ChainImplMono(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x06000E44 RID: 3652 RVA: 0x0005252C File Offset: 0x0005072C
		// (set) Token: 0x06000E45 RID: 3653 RVA: 0x00007154 File Offset: 0x00005354
		public unsafe StoreLocation location
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplMono.NativeFieldInfoPtr_location);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplMono.NativeFieldInfoPtr_location)) = value;
			}
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x06000E46 RID: 3654 RVA: 0x00052554 File Offset: 0x00050754
		// (set) Token: 0x06000E47 RID: 3655 RVA: 0x0000716F File Offset: 0x0000536F
		public unsafe X509ChainElementCollection elements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplMono.NativeFieldInfoPtr_elements);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509ChainElementCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplMono.NativeFieldInfoPtr_elements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x06000E48 RID: 3656 RVA: 0x00052584 File Offset: 0x00050784
		// (set) Token: 0x06000E49 RID: 3657 RVA: 0x0000718E File Offset: 0x0000538E
		public unsafe X509ChainPolicy policy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplMono.NativeFieldInfoPtr_policy);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509ChainPolicy>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplMono.NativeFieldInfoPtr_policy), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x06000E4A RID: 3658 RVA: 0x000525B4 File Offset: 0x000507B4
		// (set) Token: 0x06000E4B RID: 3659 RVA: 0x000071AD File Offset: 0x000053AD
		public unsafe Il2CppReferenceArray<X509ChainStatus> status
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplMono.NativeFieldInfoPtr_status);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<X509ChainStatus>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplMono.NativeFieldInfoPtr_status), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x06000E4C RID: 3660 RVA: 0x000525E4 File Offset: 0x000507E4
		// (set) Token: 0x06000E4D RID: 3661 RVA: 0x000071CC File Offset: 0x000053CC
		public unsafe static Il2CppReferenceArray<X509ChainStatus> Empty
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(X509ChainImplMono.NativeFieldInfoPtr_Empty, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<X509ChainStatus>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(X509ChainImplMono.NativeFieldInfoPtr_Empty, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x06000E4E RID: 3662 RVA: 0x0005260C File Offset: 0x0005080C
		// (set) Token: 0x06000E4F RID: 3663 RVA: 0x000071DE File Offset: 0x000053DE
		public unsafe int max_path_length
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplMono.NativeFieldInfoPtr_max_path_length);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplMono.NativeFieldInfoPtr_max_path_length)) = value;
			}
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x06000E50 RID: 3664 RVA: 0x00052634 File Offset: 0x00050834
		// (set) Token: 0x06000E51 RID: 3665 RVA: 0x000071F9 File Offset: 0x000053F9
		public unsafe X500DistinguishedName working_issuer_name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplMono.NativeFieldInfoPtr_working_issuer_name);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X500DistinguishedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplMono.NativeFieldInfoPtr_working_issuer_name), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x06000E52 RID: 3666 RVA: 0x00052664 File Offset: 0x00050864
		// (set) Token: 0x06000E53 RID: 3667 RVA: 0x00007218 File Offset: 0x00005418
		public unsafe AsymmetricAlgorithm working_public_key
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplMono.NativeFieldInfoPtr_working_public_key);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsymmetricAlgorithm>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplMono.NativeFieldInfoPtr_working_public_key), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x06000E54 RID: 3668 RVA: 0x00052694 File Offset: 0x00050894
		// (set) Token: 0x06000E55 RID: 3669 RVA: 0x00007237 File Offset: 0x00005437
		public unsafe X509ChainElement bce_restriction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplMono.NativeFieldInfoPtr_bce_restriction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509ChainElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplMono.NativeFieldInfoPtr_bce_restriction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x06000E56 RID: 3670 RVA: 0x000526C4 File Offset: 0x000508C4
		// (set) Token: 0x06000E57 RID: 3671 RVA: 0x00007256 File Offset: 0x00005456
		public unsafe X509Certificate2Collection roots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplMono.NativeFieldInfoPtr_roots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509Certificate2Collection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplMono.NativeFieldInfoPtr_roots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x06000E58 RID: 3672 RVA: 0x000526F4 File Offset: 0x000508F4
		// (set) Token: 0x06000E59 RID: 3673 RVA: 0x00007275 File Offset: 0x00005475
		public unsafe X509Certificate2Collection cas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplMono.NativeFieldInfoPtr_cas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509Certificate2Collection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplMono.NativeFieldInfoPtr_cas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x06000E5A RID: 3674 RVA: 0x00052724 File Offset: 0x00050924
		// (set) Token: 0x06000E5B RID: 3675 RVA: 0x00007294 File Offset: 0x00005494
		public unsafe X509Store root_store
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplMono.NativeFieldInfoPtr_root_store);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509Store>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplMono.NativeFieldInfoPtr_root_store), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x06000E5C RID: 3676 RVA: 0x00052754 File Offset: 0x00050954
		// (set) Token: 0x06000E5D RID: 3677 RVA: 0x000072B3 File Offset: 0x000054B3
		public unsafe X509Store ca_store
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplMono.NativeFieldInfoPtr_ca_store);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509Store>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplMono.NativeFieldInfoPtr_ca_store), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x06000E5E RID: 3678 RVA: 0x00052784 File Offset: 0x00050984
		// (set) Token: 0x06000E5F RID: 3679 RVA: 0x000072D2 File Offset: 0x000054D2
		public unsafe X509Store user_root_store
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplMono.NativeFieldInfoPtr_user_root_store);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509Store>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplMono.NativeFieldInfoPtr_user_root_store), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x06000E60 RID: 3680 RVA: 0x000527B4 File Offset: 0x000509B4
		// (set) Token: 0x06000E61 RID: 3681 RVA: 0x000072F1 File Offset: 0x000054F1
		public unsafe X509Store user_ca_store
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplMono.NativeFieldInfoPtr_user_ca_store);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509Store>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplMono.NativeFieldInfoPtr_user_ca_store), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x06000E62 RID: 3682 RVA: 0x000527E4 File Offset: 0x000509E4
		// (set) Token: 0x06000E63 RID: 3683 RVA: 0x00007310 File Offset: 0x00005510
		public unsafe X509Certificate2Collection collection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplMono.NativeFieldInfoPtr_collection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509Certificate2Collection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplMono.NativeFieldInfoPtr_collection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BA1 RID: 2977
		private static readonly IntPtr NativeFieldInfoPtr_location;

		// Token: 0x04000BA2 RID: 2978
		private static readonly IntPtr NativeFieldInfoPtr_elements;

		// Token: 0x04000BA3 RID: 2979
		private static readonly IntPtr NativeFieldInfoPtr_policy;

		// Token: 0x04000BA4 RID: 2980
		private static readonly IntPtr NativeFieldInfoPtr_status;

		// Token: 0x04000BA5 RID: 2981
		private static readonly IntPtr NativeFieldInfoPtr_Empty;

		// Token: 0x04000BA6 RID: 2982
		private static readonly IntPtr NativeFieldInfoPtr_max_path_length;

		// Token: 0x04000BA7 RID: 2983
		private static readonly IntPtr NativeFieldInfoPtr_working_issuer_name;

		// Token: 0x04000BA8 RID: 2984
		private static readonly IntPtr NativeFieldInfoPtr_working_public_key;

		// Token: 0x04000BA9 RID: 2985
		private static readonly IntPtr NativeFieldInfoPtr_bce_restriction;

		// Token: 0x04000BAA RID: 2986
		private static readonly IntPtr NativeFieldInfoPtr_roots;

		// Token: 0x04000BAB RID: 2987
		private static readonly IntPtr NativeFieldInfoPtr_cas;

		// Token: 0x04000BAC RID: 2988
		private static readonly IntPtr NativeFieldInfoPtr_root_store;

		// Token: 0x04000BAD RID: 2989
		private static readonly IntPtr NativeFieldInfoPtr_ca_store;

		// Token: 0x04000BAE RID: 2990
		private static readonly IntPtr NativeFieldInfoPtr_user_root_store;

		// Token: 0x04000BAF RID: 2991
		private static readonly IntPtr NativeFieldInfoPtr_user_ca_store;

		// Token: 0x04000BB0 RID: 2992
		private static readonly IntPtr NativeFieldInfoPtr_collection;

		// Token: 0x04000BB1 RID: 2993
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x04000BB2 RID: 2994
		private static readonly IntPtr NativeMethodInfoPtr_get_IsValid_Public_Virtual_get_Boolean_0;

		// Token: 0x04000BB3 RID: 2995
		private static readonly IntPtr NativeMethodInfoPtr_get_ChainElements_Public_Virtual_get_X509ChainElementCollection_0;

		// Token: 0x04000BB4 RID: 2996
		private static readonly IntPtr NativeMethodInfoPtr_get_ChainPolicy_Public_Virtual_get_X509ChainPolicy_0;

		// Token: 0x04000BB5 RID: 2997
		private static readonly IntPtr NativeMethodInfoPtr_get_ChainStatus_Public_Virtual_get_Il2CppReferenceArray_1_X509ChainStatus_0;

		// Token: 0x04000BB6 RID: 2998
		private static readonly IntPtr NativeMethodInfoPtr_AddStatus_Public_Virtual_Void_X509ChainStatusFlags_0;

		// Token: 0x04000BB7 RID: 2999
		private static readonly IntPtr NativeMethodInfoPtr_Build_Public_Virtual_Boolean_X509Certificate2_0;

		// Token: 0x04000BB8 RID: 3000
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

		// Token: 0x04000BB9 RID: 3001
		private static readonly IntPtr NativeMethodInfoPtr_get_Roots_Private_get_X509Certificate2Collection_0;

		// Token: 0x04000BBA RID: 3002
		private static readonly IntPtr NativeMethodInfoPtr_get_CertificateAuthorities_Private_get_X509Certificate2Collection_0;

		// Token: 0x04000BBB RID: 3003
		private static readonly IntPtr NativeMethodInfoPtr_get_LMRootStore_Private_get_X509Store_0;

		// Token: 0x04000BBC RID: 3004
		private static readonly IntPtr NativeMethodInfoPtr_get_UserRootStore_Private_get_X509Store_0;

		// Token: 0x04000BBD RID: 3005
		private static readonly IntPtr NativeMethodInfoPtr_get_LMCAStore_Private_get_X509Store_0;

		// Token: 0x04000BBE RID: 3006
		private static readonly IntPtr NativeMethodInfoPtr_get_UserCAStore_Private_get_X509Store_0;

		// Token: 0x04000BBF RID: 3007
		private static readonly IntPtr NativeMethodInfoPtr_get_CertificateCollection_Private_get_X509Certificate2Collection_0;

		// Token: 0x04000BC0 RID: 3008
		private static readonly IntPtr NativeMethodInfoPtr_BuildChainFrom_Private_X509ChainStatusFlags_X509Certificate2_0;

		// Token: 0x04000BC1 RID: 3009
		private static readonly IntPtr NativeMethodInfoPtr_SelectBestFromCollection_Private_X509Certificate2_X509Certificate2_X509Certificate2Collection_0;

		// Token: 0x04000BC2 RID: 3010
		private static readonly IntPtr NativeMethodInfoPtr_FindParent_Private_X509Certificate2_X509Certificate2_0;

		// Token: 0x04000BC3 RID: 3011
		private static readonly IntPtr NativeMethodInfoPtr_IsChainComplete_Private_Boolean_X509Certificate2_0;

		// Token: 0x04000BC4 RID: 3012
		private static readonly IntPtr NativeMethodInfoPtr_IsSelfIssued_Private_Boolean_X509Certificate2_0;

		// Token: 0x04000BC5 RID: 3013
		private static readonly IntPtr NativeMethodInfoPtr_ValidateChain_Private_Void_X509ChainStatusFlags_0;

		// Token: 0x04000BC6 RID: 3014
		private static readonly IntPtr NativeMethodInfoPtr_Process_Private_Void_Int32_0;

		// Token: 0x04000BC7 RID: 3015
		private static readonly IntPtr NativeMethodInfoPtr_PrepareForNextCertificate_Private_Void_Int32_0;

		// Token: 0x04000BC8 RID: 3016
		private static readonly IntPtr NativeMethodInfoPtr_WrapUp_Private_Void_0;

		// Token: 0x04000BC9 RID: 3017
		private static readonly IntPtr NativeMethodInfoPtr_ProcessCertificateExtensions_Private_Void_X509ChainElement_0;

		// Token: 0x04000BCA RID: 3018
		private static readonly IntPtr NativeMethodInfoPtr_IsSignedWith_Private_Boolean_X509Certificate2_AsymmetricAlgorithm_0;

		// Token: 0x04000BCB RID: 3019
		private static readonly IntPtr NativeMethodInfoPtr_GetSubjectKeyIdentifier_Private_String_X509Certificate2_0;

		// Token: 0x04000BCC RID: 3020
		private static readonly IntPtr NativeMethodInfoPtr_GetAuthorityKeyIdentifier_Private_Static_String_X509Certificate2_0;

		// Token: 0x04000BCD RID: 3021
		private static readonly IntPtr NativeMethodInfoPtr_GetAuthorityKeyIdentifier_Private_Static_String_X509Crl_0;

		// Token: 0x04000BCE RID: 3022
		private static readonly IntPtr NativeMethodInfoPtr_GetAuthorityKeyIdentifier_Private_Static_String_X509Extension_0;

		// Token: 0x04000BCF RID: 3023
		private static readonly IntPtr NativeMethodInfoPtr_CheckRevocationOnChain_Private_Void_X509ChainStatusFlags_0;

		// Token: 0x04000BD0 RID: 3024
		private static readonly IntPtr NativeMethodInfoPtr_CheckRevocation_Private_X509ChainStatusFlags_X509Certificate2_Int32_Boolean_0;

		// Token: 0x04000BD1 RID: 3025
		private static readonly IntPtr NativeMethodInfoPtr_CheckRevocation_Private_X509ChainStatusFlags_X509Certificate2_X509Certificate2_Boolean_0;

		// Token: 0x04000BD2 RID: 3026
		private static readonly IntPtr NativeMethodInfoPtr_CheckCrls_Private_Static_X509Crl_String_String_X509Store_0;

		// Token: 0x04000BD3 RID: 3027
		private static readonly IntPtr NativeMethodInfoPtr_FindCrl_Private_X509Crl_X509Certificate2_0;

		// Token: 0x04000BD4 RID: 3028
		private static readonly IntPtr NativeMethodInfoPtr_ProcessCrlExtensions_Private_Boolean_X509Crl_0;

		// Token: 0x04000BD5 RID: 3029
		private static readonly IntPtr NativeMethodInfoPtr_ProcessCrlEntryExtensions_Private_Boolean_X509CrlEntry_0;
	}
}
