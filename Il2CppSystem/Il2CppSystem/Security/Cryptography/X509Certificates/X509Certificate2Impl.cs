using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Text;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x020000CC RID: 204
	public class X509Certificate2Impl : X509CertificateImpl
	{
		// Token: 0x06000D77 RID: 3447 RVA: 0x0004E748 File Offset: 0x0004C948
		// Note: this type is marked as 'beforefieldinit'.
		static X509Certificate2Impl()
		{
			Il2CppClassPointerStore<X509Certificate2Impl>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Security.Cryptography.X509Certificates", "X509Certificate2Impl");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509Certificate2Impl>.NativeClassPtr);
			X509Certificate2Impl.NativeMethodInfoPtr_get_Extensions_Public_Abstract_Virtual_New_get_IEnumerable_1_X509Extension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2Impl>.NativeClassPtr, 100665233);
			X509Certificate2Impl.NativeMethodInfoPtr_get_IssuerName_Public_Abstract_Virtual_New_get_X500DistinguishedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2Impl>.NativeClassPtr, 100665234);
			X509Certificate2Impl.NativeMethodInfoPtr_get_PrivateKey_Public_Abstract_Virtual_New_get_AsymmetricAlgorithm_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2Impl>.NativeClassPtr, 100665235);
			X509Certificate2Impl.NativeMethodInfoPtr_set_PrivateKey_Public_Abstract_Virtual_New_set_Void_AsymmetricAlgorithm_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2Impl>.NativeClassPtr, 100665236);
			X509Certificate2Impl.NativeMethodInfoPtr_get_SignatureAlgorithm_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2Impl>.NativeClassPtr, 100665237);
			X509Certificate2Impl.NativeMethodInfoPtr_get_SubjectName_Public_Abstract_Virtual_New_get_X500DistinguishedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2Impl>.NativeClassPtr, 100665238);
			X509Certificate2Impl.NativeMethodInfoPtr_get_Version_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2Impl>.NativeClassPtr, 100665239);
			X509Certificate2Impl.NativeMethodInfoPtr_get_IntermediateCertificates_Internal_Abstract_Virtual_New_get_X509CertificateImplCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2Impl>.NativeClassPtr, 100665240);
			X509Certificate2Impl.NativeMethodInfoPtr_GetNameInfo_Public_Abstract_Virtual_New_String_X509NameType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2Impl>.NativeClassPtr, 100665241);
			X509Certificate2Impl.NativeMethodInfoPtr_Verify_Public_Abstract_Virtual_New_Boolean_X509Certificate2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2Impl>.NativeClassPtr, 100665242);
			X509Certificate2Impl.NativeMethodInfoPtr_AppendPrivateKeyInfo_Public_Abstract_Virtual_New_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2Impl>.NativeClassPtr, 100665243);
			X509Certificate2Impl.NativeMethodInfoPtr_CopyWithPrivateKey_Public_Virtual_Final_X509CertificateImpl_RSA_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2Impl>.NativeClassPtr, 100665244);
			X509Certificate2Impl.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2Impl>.NativeClassPtr, 100665245);
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06000D78 RID: 3448 RVA: 0x0004E87C File Offset: 0x0004CA7C
		public unsafe virtual IEnumerable<X509Extension> Extensions
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate2Impl.NativeMethodInfoPtr_get_Extensions_Public_Abstract_Virtual_New_get_IEnumerable_1_X509Extension_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<X509Extension>>(intPtr3) : null;
			}
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06000D79 RID: 3449 RVA: 0x0004E8C8 File Offset: 0x0004CAC8
		public unsafe virtual X500DistinguishedName IssuerName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate2Impl.NativeMethodInfoPtr_get_IssuerName_Public_Abstract_Virtual_New_get_X500DistinguishedName_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X500DistinguishedName>(intPtr3) : null;
			}
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x06000D7A RID: 3450 RVA: 0x0004E914 File Offset: 0x0004CB14
		// (set) Token: 0x06000D7B RID: 3451 RVA: 0x0004E960 File Offset: 0x0004CB60
		public unsafe virtual AsymmetricAlgorithm PrivateKey
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate2Impl.NativeMethodInfoPtr_get_PrivateKey_Public_Abstract_Virtual_New_get_AsymmetricAlgorithm_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsymmetricAlgorithm>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate2Impl.NativeMethodInfoPtr_set_PrivateKey_Public_Abstract_Virtual_New_set_Void_AsymmetricAlgorithm_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x06000D7C RID: 3452 RVA: 0x0004E9B0 File Offset: 0x0004CBB0
		public unsafe virtual string SignatureAlgorithm
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate2Impl.NativeMethodInfoPtr_get_SignatureAlgorithm_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x06000D7D RID: 3453 RVA: 0x0004E9F4 File Offset: 0x0004CBF4
		public unsafe virtual X500DistinguishedName SubjectName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate2Impl.NativeMethodInfoPtr_get_SubjectName_Public_Abstract_Virtual_New_get_X500DistinguishedName_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X500DistinguishedName>(intPtr3) : null;
			}
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06000D7E RID: 3454 RVA: 0x0004EA40 File Offset: 0x0004CC40
		public unsafe virtual int Version
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate2Impl.NativeMethodInfoPtr_get_Version_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06000D7F RID: 3455 RVA: 0x0004EA88 File Offset: 0x0004CC88
		public unsafe virtual X509CertificateImplCollection IntermediateCertificates
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate2Impl.NativeMethodInfoPtr_get_IntermediateCertificates_Internal_Abstract_Virtual_New_get_X509CertificateImplCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509CertificateImplCollection>(intPtr3) : null;
			}
		}

		// Token: 0x06000D80 RID: 3456 RVA: 0x0004EAD4 File Offset: 0x0004CCD4
		[CallerCount(0)]
		public unsafe virtual string GetNameInfo(X509NameType nameType, bool forIssuer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forIssuer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate2Impl.NativeMethodInfoPtr_GetNameInfo_Public_Abstract_Virtual_New_String_X509NameType_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000D81 RID: 3457 RVA: 0x0004EB34 File Offset: 0x0004CD34
		[CallerCount(0)]
		public unsafe virtual bool Verify(X509Certificate2 thisCertificate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(thisCertificate);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate2Impl.NativeMethodInfoPtr_Verify_Public_Abstract_Virtual_New_Boolean_X509Certificate2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D82 RID: 3458 RVA: 0x0004EB8C File Offset: 0x0004CD8C
		[CallerCount(0)]
		public unsafe virtual void AppendPrivateKeyInfo(StringBuilder sb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate2Impl.NativeMethodInfoPtr_AppendPrivateKeyInfo_Public_Abstract_Virtual_New_Void_StringBuilder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D83 RID: 3459 RVA: 0x0004EBDC File Offset: 0x0004CDDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 453916, XrefRangeEnd = 453918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override X509CertificateImpl CopyWithPrivateKey(RSA privateKey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(privateKey);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2Impl.NativeMethodInfoPtr_CopyWithPrivateKey_Public_Virtual_Final_X509CertificateImpl_RSA_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509CertificateImpl>(intPtr3) : null;
			}
		}

		// Token: 0x06000D84 RID: 3460 RVA: 0x0004EC2C File Offset: 0x0004CE2C
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509Certificate2Impl()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509Certificate2Impl>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2Impl.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D85 RID: 3461 RVA: 0x00006F52 File Offset: 0x00005152
		public X509Certificate2Impl(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B1D RID: 2845
		private static readonly IntPtr NativeMethodInfoPtr_get_Extensions_Public_Abstract_Virtual_New_get_IEnumerable_1_X509Extension_0;

		// Token: 0x04000B1E RID: 2846
		private static readonly IntPtr NativeMethodInfoPtr_get_IssuerName_Public_Abstract_Virtual_New_get_X500DistinguishedName_0;

		// Token: 0x04000B1F RID: 2847
		private static readonly IntPtr NativeMethodInfoPtr_get_PrivateKey_Public_Abstract_Virtual_New_get_AsymmetricAlgorithm_0;

		// Token: 0x04000B20 RID: 2848
		private static readonly IntPtr NativeMethodInfoPtr_set_PrivateKey_Public_Abstract_Virtual_New_set_Void_AsymmetricAlgorithm_0;

		// Token: 0x04000B21 RID: 2849
		private static readonly IntPtr NativeMethodInfoPtr_get_SignatureAlgorithm_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04000B22 RID: 2850
		private static readonly IntPtr NativeMethodInfoPtr_get_SubjectName_Public_Abstract_Virtual_New_get_X500DistinguishedName_0;

		// Token: 0x04000B23 RID: 2851
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04000B24 RID: 2852
		private static readonly IntPtr NativeMethodInfoPtr_get_IntermediateCertificates_Internal_Abstract_Virtual_New_get_X509CertificateImplCollection_0;

		// Token: 0x04000B25 RID: 2853
		private static readonly IntPtr NativeMethodInfoPtr_GetNameInfo_Public_Abstract_Virtual_New_String_X509NameType_Boolean_0;

		// Token: 0x04000B26 RID: 2854
		private static readonly IntPtr NativeMethodInfoPtr_Verify_Public_Abstract_Virtual_New_Boolean_X509Certificate2_0;

		// Token: 0x04000B27 RID: 2855
		private static readonly IntPtr NativeMethodInfoPtr_AppendPrivateKeyInfo_Public_Abstract_Virtual_New_Void_StringBuilder_0;

		// Token: 0x04000B28 RID: 2856
		private static readonly IntPtr NativeMethodInfoPtr_CopyWithPrivateKey_Public_Virtual_Final_X509CertificateImpl_RSA_0;

		// Token: 0x04000B29 RID: 2857
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
