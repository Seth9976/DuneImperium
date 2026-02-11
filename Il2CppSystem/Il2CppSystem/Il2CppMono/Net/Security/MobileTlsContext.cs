using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono.Security.Interface;
using Il2CppSystem;
using Il2CppSystem.Security.Authentication;
using Il2CppSystem.Security.Cryptography.X509Certificates;

namespace Il2CppMono.Net.Security
{
	// Token: 0x0200001B RID: 27
	public class MobileTlsContext : Object
	{
		// Token: 0x06000181 RID: 385 RVA: 0x00020B88 File Offset: 0x0001ED88
		// Note: this type is marked as 'beforefieldinit'.
		static MobileTlsContext()
		{
			Il2CppClassPointerStore<MobileTlsContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Net.Security", "MobileTlsContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MobileTlsContext>.NativeClassPtr);
			MobileTlsContext.NativeFieldInfoPtr_certificateValidator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileTlsContext>.NativeClassPtr, "certificateValidator");
			MobileTlsContext.NativeFieldInfoPtr__Options_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileTlsContext>.NativeClassPtr, "<Options>k__BackingField");
			MobileTlsContext.NativeFieldInfoPtr__Parent_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileTlsContext>.NativeClassPtr, "<Parent>k__BackingField");
			MobileTlsContext.NativeFieldInfoPtr__IsServer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileTlsContext>.NativeClassPtr, "<IsServer>k__BackingField");
			MobileTlsContext.NativeFieldInfoPtr__TargetHost_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileTlsContext>.NativeClassPtr, "<TargetHost>k__BackingField");
			MobileTlsContext.NativeFieldInfoPtr__ServerName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileTlsContext>.NativeClassPtr, "<ServerName>k__BackingField");
			MobileTlsContext.NativeFieldInfoPtr__AskForClientCertificate_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileTlsContext>.NativeClassPtr, "<AskForClientCertificate>k__BackingField");
			MobileTlsContext.NativeFieldInfoPtr__EnabledProtocols_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileTlsContext>.NativeClassPtr, "<EnabledProtocols>k__BackingField");
			MobileTlsContext.NativeFieldInfoPtr__ClientCertificates_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileTlsContext>.NativeClassPtr, "<ClientCertificates>k__BackingField");
			MobileTlsContext.NativeFieldInfoPtr__LocalServerCertificate_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileTlsContext>.NativeClassPtr, "<LocalServerCertificate>k__BackingField");
			MobileTlsContext.NativeMethodInfoPtr__ctor_Protected_Void_MobileAuthenticatedStream_MonoSslAuthenticationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileTlsContext>.NativeClassPtr, 100663580);
			MobileTlsContext.NativeMethodInfoPtr_get_Options_Internal_get_MonoSslAuthenticationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileTlsContext>.NativeClassPtr, 100663581);
			MobileTlsContext.NativeMethodInfoPtr_get_Parent_Internal_get_MobileAuthenticatedStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileTlsContext>.NativeClassPtr, 100663582);
			MobileTlsContext.NativeMethodInfoPtr_get_Settings_Public_get_MonoTlsSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileTlsContext>.NativeClassPtr, 100663583);
			MobileTlsContext.NativeMethodInfoPtr_get_IsAuthenticated_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileTlsContext>.NativeClassPtr, 100663584);
			MobileTlsContext.NativeMethodInfoPtr_get_IsServer_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileTlsContext>.NativeClassPtr, 100663585);
			MobileTlsContext.NativeMethodInfoPtr_get_TargetHost_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileTlsContext>.NativeClassPtr, 100663586);
			MobileTlsContext.NativeMethodInfoPtr_get_ServerName_Protected_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileTlsContext>.NativeClassPtr, 100663587);
			MobileTlsContext.NativeMethodInfoPtr_get_AskForClientCertificate_Protected_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileTlsContext>.NativeClassPtr, 100663588);
			MobileTlsContext.NativeMethodInfoPtr_get_EnabledProtocols_Protected_get_SslProtocols_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileTlsContext>.NativeClassPtr, 100663589);
			MobileTlsContext.NativeMethodInfoPtr_get_ClientCertificates_Protected_get_X509CertificateCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileTlsContext>.NativeClassPtr, 100663590);
			MobileTlsContext.NativeMethodInfoPtr_GetProtocolVersions_Protected_Void_byref_Nullable_1_TlsProtocolCode_byref_Nullable_1_TlsProtocolCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileTlsContext>.NativeClassPtr, 100663591);
			MobileTlsContext.NativeMethodInfoPtr_StartHandshake_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileTlsContext>.NativeClassPtr, 100663592);
			MobileTlsContext.NativeMethodInfoPtr_ProcessHandshake_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileTlsContext>.NativeClassPtr, 100663593);
			MobileTlsContext.NativeMethodInfoPtr_FinishHandshake_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileTlsContext>.NativeClassPtr, 100663594);
			MobileTlsContext.NativeMethodInfoPtr_get_LocalServerCertificate_Internal_get_X509Certificate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileTlsContext>.NativeClassPtr, 100663595);
			MobileTlsContext.NativeMethodInfoPtr_set_LocalServerCertificate_Private_set_Void_X509Certificate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileTlsContext>.NativeClassPtr, 100663596);
			MobileTlsContext.NativeMethodInfoPtr_get_LocalClientCertificate_Internal_Abstract_Virtual_New_get_X509Certificate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileTlsContext>.NativeClassPtr, 100663597);
			MobileTlsContext.NativeMethodInfoPtr_get_RemoteCertificate_Public_Abstract_Virtual_New_get_X509Certificate2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileTlsContext>.NativeClassPtr, 100663598);
			MobileTlsContext.NativeMethodInfoPtr_Flush_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileTlsContext>.NativeClassPtr, 100663599);
			MobileTlsContext.NativeMethodInfoPtr_Read_Public_Abstract_Virtual_New_ValueTuple_2_Int32_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileTlsContext>.NativeClassPtr, 100663600);
			MobileTlsContext.NativeMethodInfoPtr_Write_Public_Abstract_Virtual_New_ValueTuple_2_Int32_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileTlsContext>.NativeClassPtr, 100663601);
			MobileTlsContext.NativeMethodInfoPtr_Shutdown_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileTlsContext>.NativeClassPtr, 100663602);
			MobileTlsContext.NativeMethodInfoPtr_PendingRenegotiation_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileTlsContext>.NativeClassPtr, 100663603);
			MobileTlsContext.NativeMethodInfoPtr_ValidateCertificate_Protected_Boolean_X509Certificate2_X509Chain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileTlsContext>.NativeClassPtr, 100663604);
			MobileTlsContext.NativeMethodInfoPtr_SelectServerCertificate_Protected_X509Certificate_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileTlsContext>.NativeClassPtr, 100663605);
			MobileTlsContext.NativeMethodInfoPtr_SelectClientCertificate_Protected_X509Certificate_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileTlsContext>.NativeClassPtr, 100663606);
			MobileTlsContext.NativeMethodInfoPtr_Renegotiate_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileTlsContext>.NativeClassPtr, 100663607);
			MobileTlsContext.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileTlsContext>.NativeClassPtr, 100663608);
			MobileTlsContext.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileTlsContext>.NativeClassPtr, 100663609);
			MobileTlsContext.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileTlsContext>.NativeClassPtr, 100663610);
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00020EEC File Offset: 0x0001F0EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 428662, RefRangeEnd = 428664, XrefRangeStart = 428637, XrefRangeEnd = 428662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MobileTlsContext(MobileAuthenticatedStream parent, MonoSslAuthenticationOptions options)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MobileTlsContext>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileTlsContext.NativeMethodInfoPtr__ctor_Protected_Void_MobileAuthenticatedStream_MonoSslAuthenticationOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000183 RID: 387 RVA: 0x00020F4C File Offset: 0x0001F14C
		public unsafe MonoSslAuthenticationOptions Options
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileTlsContext.NativeMethodInfoPtr_get_Options_Internal_get_MonoSslAuthenticationOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoSslAuthenticationOptions>(intPtr3) : null;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000184 RID: 388 RVA: 0x00020F8C File Offset: 0x0001F18C
		public unsafe MobileAuthenticatedStream Parent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileTlsContext.NativeMethodInfoPtr_get_Parent_Internal_get_MobileAuthenticatedStream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MobileAuthenticatedStream>(intPtr3) : null;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000185 RID: 389 RVA: 0x00020FCC File Offset: 0x0001F1CC
		public unsafe MonoTlsSettings Settings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileTlsContext.NativeMethodInfoPtr_get_Settings_Public_get_MonoTlsSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoTlsSettings>(intPtr3) : null;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000186 RID: 390 RVA: 0x0002100C File Offset: 0x0001F20C
		public unsafe virtual bool IsAuthenticated
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileTlsContext.NativeMethodInfoPtr_get_IsAuthenticated_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000187 RID: 391 RVA: 0x00021054 File Offset: 0x0001F254
		public unsafe bool IsServer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileTlsContext.NativeMethodInfoPtr_get_IsServer_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000188 RID: 392 RVA: 0x00021090 File Offset: 0x0001F290
		public unsafe string TargetHost
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileTlsContext.NativeMethodInfoPtr_get_TargetHost_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000189 RID: 393 RVA: 0x000210C8 File Offset: 0x0001F2C8
		public unsafe string ServerName
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileTlsContext.NativeMethodInfoPtr_get_ServerName_Protected_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x0600018A RID: 394 RVA: 0x00021100 File Offset: 0x0001F300
		public unsafe bool AskForClientCertificate
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileTlsContext.NativeMethodInfoPtr_get_AskForClientCertificate_Protected_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x0600018B RID: 395 RVA: 0x0002113C File Offset: 0x0001F33C
		public unsafe SslProtocols EnabledProtocols
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileTlsContext.NativeMethodInfoPtr_get_EnabledProtocols_Protected_get_SslProtocols_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x0600018C RID: 396 RVA: 0x00021178 File Offset: 0x0001F378
		public unsafe X509CertificateCollection ClientCertificates
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileTlsContext.NativeMethodInfoPtr_get_ClientCertificates_Protected_get_X509CertificateCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509CertificateCollection>(intPtr3) : null;
			}
		}

		// Token: 0x0600018D RID: 397 RVA: 0x000211B8 File Offset: 0x0001F3B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 428664, XrefRangeEnd = 428675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetProtocolVersions(out Nullable<TlsProtocolCode> min, out Nullable<TlsProtocolCode> max)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(MobileTlsContext.NativeMethodInfoPtr_GetProtocolVersions_Protected_Void_byref_Nullable_1_TlsProtocolCode_byref_Nullable_1_TlsProtocolCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			min = ((intPtr5 == 0) ? null : new Nullable<TlsProtocolCode>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			max = ((intPtr6 == 0) ? null : new Nullable<TlsProtocolCode>(intPtr6));
		}

		// Token: 0x0600018E RID: 398 RVA: 0x0002122C File Offset: 0x0001F42C
		[CallerCount(0)]
		public unsafe virtual void StartHandshake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileTlsContext.NativeMethodInfoPtr_StartHandshake_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00021268 File Offset: 0x0001F468
		[CallerCount(0)]
		public unsafe virtual bool ProcessHandshake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileTlsContext.NativeMethodInfoPtr_ProcessHandshake_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000190 RID: 400 RVA: 0x000212B0 File Offset: 0x0001F4B0
		[CallerCount(0)]
		public unsafe virtual void FinishHandshake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileTlsContext.NativeMethodInfoPtr_FinishHandshake_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000191 RID: 401 RVA: 0x000212EC File Offset: 0x0001F4EC
		// (set) Token: 0x06000192 RID: 402 RVA: 0x0002132C File Offset: 0x0001F52C
		public unsafe X509Certificate LocalServerCertificate
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileTlsContext.NativeMethodInfoPtr_get_LocalServerCertificate_Internal_get_X509Certificate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileTlsContext.NativeMethodInfoPtr_set_LocalServerCertificate_Private_set_Void_X509Certificate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000193 RID: 403 RVA: 0x00021370 File Offset: 0x0001F570
		public unsafe virtual X509Certificate LocalClientCertificate
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileTlsContext.NativeMethodInfoPtr_get_LocalClientCertificate_Internal_Abstract_Virtual_New_get_X509Certificate_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate>(intPtr3) : null;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000194 RID: 404 RVA: 0x000213BC File Offset: 0x0001F5BC
		public unsafe virtual X509Certificate2 RemoteCertificate
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileTlsContext.NativeMethodInfoPtr_get_RemoteCertificate_Public_Abstract_Virtual_New_get_X509Certificate2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate2>(intPtr3) : null;
			}
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00021408 File Offset: 0x0001F608
		[CallerCount(0)]
		public unsafe virtual void Flush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileTlsContext.NativeMethodInfoPtr_Flush_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00021444 File Offset: 0x0001F644
		[CallerCount(0)]
		public unsafe virtual ValueTuple<int, bool> Read(Il2CppStructArray<byte> buffer, int offset, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileTlsContext.NativeMethodInfoPtr_Read_Public_Abstract_Virtual_New_ValueTuple_2_Int32_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ValueTuple<int, bool>(intPtr);
		}

		// Token: 0x06000197 RID: 407 RVA: 0x000214B4 File Offset: 0x0001F6B4
		[CallerCount(0)]
		public unsafe virtual ValueTuple<int, bool> Write(Il2CppStructArray<byte> buffer, int offset, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileTlsContext.NativeMethodInfoPtr_Write_Public_Abstract_Virtual_New_ValueTuple_2_Int32_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ValueTuple<int, bool>(intPtr);
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00021524 File Offset: 0x0001F724
		[CallerCount(0)]
		public unsafe virtual void Shutdown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileTlsContext.NativeMethodInfoPtr_Shutdown_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00021560 File Offset: 0x0001F760
		[CallerCount(0)]
		public unsafe virtual bool PendingRenegotiation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileTlsContext.NativeMethodInfoPtr_PendingRenegotiation_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600019A RID: 410 RVA: 0x000215A8 File Offset: 0x0001F7A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 428675, XrefRangeEnd = 428676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ValidateCertificate(X509Certificate2 leaf, X509Chain chain)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(leaf);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(chain);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileTlsContext.NativeMethodInfoPtr_ValidateCertificate_Protected_Boolean_X509Certificate2_X509Chain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00021608 File Offset: 0x0001F808
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 428693, RefRangeEnd = 428694, XrefRangeStart = 428676, XrefRangeEnd = 428693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509Certificate SelectServerCertificate(string serverIdentity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(serverIdentity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileTlsContext.NativeMethodInfoPtr_SelectServerCertificate_Protected_X509Certificate_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate>(intPtr3) : null;
			}
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00021658 File Offset: 0x0001F858
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 428699, RefRangeEnd = 428701, XrefRangeStart = 428694, XrefRangeEnd = 428699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509Certificate SelectClientCertificate(Il2CppStringArray acceptableIssuers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(acceptableIssuers);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileTlsContext.NativeMethodInfoPtr_SelectClientCertificate_Protected_X509Certificate_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate>(intPtr3) : null;
			}
		}

		// Token: 0x0600019D RID: 413 RVA: 0x000216A8 File Offset: 0x0001F8A8
		[CallerCount(0)]
		public unsafe virtual void Renegotiate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileTlsContext.NativeMethodInfoPtr_Renegotiate_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600019E RID: 414 RVA: 0x000216E4 File Offset: 0x0001F8E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 428701, XrefRangeEnd = 428705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileTlsContext.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00021718 File Offset: 0x0001F918
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileTlsContext.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00021764 File Offset: 0x0001F964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 428705, XrefRangeEnd = 428708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileTlsContext.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x0000299A File Offset: 0x00000B9A
		public MobileTlsContext(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x000217A0 File Offset: 0x0001F9A0
		// (set) Token: 0x060001A3 RID: 419 RVA: 0x000029A3 File Offset: 0x00000BA3
		public unsafe ChainValidationHelper certificateValidator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileTlsContext.NativeFieldInfoPtr_certificateValidator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChainValidationHelper>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileTlsContext.NativeFieldInfoPtr_certificateValidator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060001A4 RID: 420 RVA: 0x000217D0 File Offset: 0x0001F9D0
		// (set) Token: 0x060001A5 RID: 421 RVA: 0x000029C2 File Offset: 0x00000BC2
		public unsafe MonoSslAuthenticationOptions _Options_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileTlsContext.NativeFieldInfoPtr__Options_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoSslAuthenticationOptions>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileTlsContext.NativeFieldInfoPtr__Options_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060001A6 RID: 422 RVA: 0x00021800 File Offset: 0x0001FA00
		// (set) Token: 0x060001A7 RID: 423 RVA: 0x000029E1 File Offset: 0x00000BE1
		public unsafe MobileAuthenticatedStream _Parent_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileTlsContext.NativeFieldInfoPtr__Parent_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MobileAuthenticatedStream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileTlsContext.NativeFieldInfoPtr__Parent_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x00021830 File Offset: 0x0001FA30
		// (set) Token: 0x060001A9 RID: 425 RVA: 0x00002A00 File Offset: 0x00000C00
		public unsafe bool _IsServer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileTlsContext.NativeFieldInfoPtr__IsServer_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileTlsContext.NativeFieldInfoPtr__IsServer_k__BackingField)) = value;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060001AA RID: 426 RVA: 0x00021858 File Offset: 0x0001FA58
		// (set) Token: 0x060001AB RID: 427 RVA: 0x00002A1B File Offset: 0x00000C1B
		public unsafe string _TargetHost_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileTlsContext.NativeFieldInfoPtr__TargetHost_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileTlsContext.NativeFieldInfoPtr__TargetHost_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060001AC RID: 428 RVA: 0x00021880 File Offset: 0x0001FA80
		// (set) Token: 0x060001AD RID: 429 RVA: 0x00002A3A File Offset: 0x00000C3A
		public unsafe string _ServerName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileTlsContext.NativeFieldInfoPtr__ServerName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileTlsContext.NativeFieldInfoPtr__ServerName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060001AE RID: 430 RVA: 0x000218A8 File Offset: 0x0001FAA8
		// (set) Token: 0x060001AF RID: 431 RVA: 0x00002A59 File Offset: 0x00000C59
		public unsafe bool _AskForClientCertificate_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileTlsContext.NativeFieldInfoPtr__AskForClientCertificate_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileTlsContext.NativeFieldInfoPtr__AskForClientCertificate_k__BackingField)) = value;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060001B0 RID: 432 RVA: 0x000218D0 File Offset: 0x0001FAD0
		// (set) Token: 0x060001B1 RID: 433 RVA: 0x00002A74 File Offset: 0x00000C74
		public unsafe SslProtocols _EnabledProtocols_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileTlsContext.NativeFieldInfoPtr__EnabledProtocols_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileTlsContext.NativeFieldInfoPtr__EnabledProtocols_k__BackingField)) = value;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060001B2 RID: 434 RVA: 0x000218F8 File Offset: 0x0001FAF8
		// (set) Token: 0x060001B3 RID: 435 RVA: 0x00002A8F File Offset: 0x00000C8F
		public unsafe X509CertificateCollection _ClientCertificates_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileTlsContext.NativeFieldInfoPtr__ClientCertificates_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509CertificateCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileTlsContext.NativeFieldInfoPtr__ClientCertificates_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x00021928 File Offset: 0x0001FB28
		// (set) Token: 0x060001B5 RID: 437 RVA: 0x00002AAE File Offset: 0x00000CAE
		public unsafe X509Certificate _LocalServerCertificate_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileTlsContext.NativeFieldInfoPtr__LocalServerCertificate_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509Certificate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileTlsContext.NativeFieldInfoPtr__LocalServerCertificate_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400010C RID: 268
		private static readonly IntPtr NativeFieldInfoPtr_certificateValidator;

		// Token: 0x0400010D RID: 269
		private static readonly IntPtr NativeFieldInfoPtr__Options_k__BackingField;

		// Token: 0x0400010E RID: 270
		private static readonly IntPtr NativeFieldInfoPtr__Parent_k__BackingField;

		// Token: 0x0400010F RID: 271
		private static readonly IntPtr NativeFieldInfoPtr__IsServer_k__BackingField;

		// Token: 0x04000110 RID: 272
		private static readonly IntPtr NativeFieldInfoPtr__TargetHost_k__BackingField;

		// Token: 0x04000111 RID: 273
		private static readonly IntPtr NativeFieldInfoPtr__ServerName_k__BackingField;

		// Token: 0x04000112 RID: 274
		private static readonly IntPtr NativeFieldInfoPtr__AskForClientCertificate_k__BackingField;

		// Token: 0x04000113 RID: 275
		private static readonly IntPtr NativeFieldInfoPtr__EnabledProtocols_k__BackingField;

		// Token: 0x04000114 RID: 276
		private static readonly IntPtr NativeFieldInfoPtr__ClientCertificates_k__BackingField;

		// Token: 0x04000115 RID: 277
		private static readonly IntPtr NativeFieldInfoPtr__LocalServerCertificate_k__BackingField;

		// Token: 0x04000116 RID: 278
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_MobileAuthenticatedStream_MonoSslAuthenticationOptions_0;

		// Token: 0x04000117 RID: 279
		private static readonly IntPtr NativeMethodInfoPtr_get_Options_Internal_get_MonoSslAuthenticationOptions_0;

		// Token: 0x04000118 RID: 280
		private static readonly IntPtr NativeMethodInfoPtr_get_Parent_Internal_get_MobileAuthenticatedStream_0;

		// Token: 0x04000119 RID: 281
		private static readonly IntPtr NativeMethodInfoPtr_get_Settings_Public_get_MonoTlsSettings_0;

		// Token: 0x0400011A RID: 282
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAuthenticated_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x0400011B RID: 283
		private static readonly IntPtr NativeMethodInfoPtr_get_IsServer_Public_get_Boolean_0;

		// Token: 0x0400011C RID: 284
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetHost_Internal_get_String_0;

		// Token: 0x0400011D RID: 285
		private static readonly IntPtr NativeMethodInfoPtr_get_ServerName_Protected_get_String_0;

		// Token: 0x0400011E RID: 286
		private static readonly IntPtr NativeMethodInfoPtr_get_AskForClientCertificate_Protected_get_Boolean_0;

		// Token: 0x0400011F RID: 287
		private static readonly IntPtr NativeMethodInfoPtr_get_EnabledProtocols_Protected_get_SslProtocols_0;

		// Token: 0x04000120 RID: 288
		private static readonly IntPtr NativeMethodInfoPtr_get_ClientCertificates_Protected_get_X509CertificateCollection_0;

		// Token: 0x04000121 RID: 289
		private static readonly IntPtr NativeMethodInfoPtr_GetProtocolVersions_Protected_Void_byref_Nullable_1_TlsProtocolCode_byref_Nullable_1_TlsProtocolCode_0;

		// Token: 0x04000122 RID: 290
		private static readonly IntPtr NativeMethodInfoPtr_StartHandshake_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04000123 RID: 291
		private static readonly IntPtr NativeMethodInfoPtr_ProcessHandshake_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x04000124 RID: 292
		private static readonly IntPtr NativeMethodInfoPtr_FinishHandshake_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04000125 RID: 293
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalServerCertificate_Internal_get_X509Certificate_0;

		// Token: 0x04000126 RID: 294
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalServerCertificate_Private_set_Void_X509Certificate_0;

		// Token: 0x04000127 RID: 295
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalClientCertificate_Internal_Abstract_Virtual_New_get_X509Certificate_0;

		// Token: 0x04000128 RID: 296
		private static readonly IntPtr NativeMethodInfoPtr_get_RemoteCertificate_Public_Abstract_Virtual_New_get_X509Certificate2_0;

		// Token: 0x04000129 RID: 297
		private static readonly IntPtr NativeMethodInfoPtr_Flush_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x0400012A RID: 298
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Abstract_Virtual_New_ValueTuple_2_Int32_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x0400012B RID: 299
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Abstract_Virtual_New_ValueTuple_2_Int32_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x0400012C RID: 300
		private static readonly IntPtr NativeMethodInfoPtr_Shutdown_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x0400012D RID: 301
		private static readonly IntPtr NativeMethodInfoPtr_PendingRenegotiation_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x0400012E RID: 302
		private static readonly IntPtr NativeMethodInfoPtr_ValidateCertificate_Protected_Boolean_X509Certificate2_X509Chain_0;

		// Token: 0x0400012F RID: 303
		private static readonly IntPtr NativeMethodInfoPtr_SelectServerCertificate_Protected_X509Certificate_String_0;

		// Token: 0x04000130 RID: 304
		private static readonly IntPtr NativeMethodInfoPtr_SelectClientCertificate_Protected_X509Certificate_Il2CppStringArray_0;

		// Token: 0x04000131 RID: 305
		private static readonly IntPtr NativeMethodInfoPtr_Renegotiate_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04000132 RID: 306
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000133 RID: 307
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x04000134 RID: 308
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;
	}
}
