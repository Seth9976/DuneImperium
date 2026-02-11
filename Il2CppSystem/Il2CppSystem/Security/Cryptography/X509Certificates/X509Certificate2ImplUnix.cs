using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMicrosoft.Win32.SafeHandles;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Text;
using Internal.Cryptography.Pal;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x020000CE RID: 206
	public class X509Certificate2ImplUnix : X509Certificate2Impl
	{
		// Token: 0x06000DA1 RID: 3489 RVA: 0x0004F430 File Offset: 0x0004D630
		// Note: this type is marked as 'beforefieldinit'.
		static X509Certificate2ImplUnix()
		{
			Il2CppClassPointerStore<X509Certificate2ImplUnix>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Security.Cryptography.X509Certificates", "X509Certificate2ImplUnix");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509Certificate2ImplUnix>.NativeClassPtr);
			X509Certificate2ImplUnix.NativeFieldInfoPtr_readCertData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate2ImplUnix>.NativeClassPtr, "readCertData");
			X509Certificate2ImplUnix.NativeFieldInfoPtr_certData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate2ImplUnix>.NativeClassPtr, "certData");
			X509Certificate2ImplUnix.NativeMethodInfoPtr_EnsureCertData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2ImplUnix>.NativeClassPtr, 100665264);
			X509Certificate2ImplUnix.NativeMethodInfoPtr_GetRawCertData_Protected_Abstract_Virtual_New_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2ImplUnix>.NativeClassPtr, 100665265);
			X509Certificate2ImplUnix.NativeMethodInfoPtr_get_KeyAlgorithm_Public_Virtual_Final_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2ImplUnix>.NativeClassPtr, 100665266);
			X509Certificate2ImplUnix.NativeMethodInfoPtr_get_KeyAlgorithmParameters_Public_Virtual_Final_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2ImplUnix>.NativeClassPtr, 100665267);
			X509Certificate2ImplUnix.NativeMethodInfoPtr_get_PublicKeyValue_Public_Virtual_Final_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2ImplUnix>.NativeClassPtr, 100665268);
			X509Certificate2ImplUnix.NativeMethodInfoPtr_get_SerialNumber_Public_Virtual_Final_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2ImplUnix>.NativeClassPtr, 100665269);
			X509Certificate2ImplUnix.NativeMethodInfoPtr_get_SignatureAlgorithm_Public_Virtual_Final_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2ImplUnix>.NativeClassPtr, 100665270);
			X509Certificate2ImplUnix.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2ImplUnix>.NativeClassPtr, 100665271);
			X509Certificate2ImplUnix.NativeMethodInfoPtr_get_SubjectName_Public_Virtual_Final_get_X500DistinguishedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2ImplUnix>.NativeClassPtr, 100665272);
			X509Certificate2ImplUnix.NativeMethodInfoPtr_get_IssuerName_Public_Virtual_Final_get_X500DistinguishedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2ImplUnix>.NativeClassPtr, 100665273);
			X509Certificate2ImplUnix.NativeMethodInfoPtr_get_Subject_Public_Virtual_Final_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2ImplUnix>.NativeClassPtr, 100665274);
			X509Certificate2ImplUnix.NativeMethodInfoPtr_get_Issuer_Public_Virtual_Final_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2ImplUnix>.NativeClassPtr, 100665275);
			X509Certificate2ImplUnix.NativeMethodInfoPtr_get_RawData_Public_Virtual_Final_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2ImplUnix>.NativeClassPtr, 100665276);
			X509Certificate2ImplUnix.NativeMethodInfoPtr_get_Thumbprint_Public_Virtual_Final_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2ImplUnix>.NativeClassPtr, 100665277);
			X509Certificate2ImplUnix.NativeMethodInfoPtr_GetNameInfo_Public_Virtual_Final_String_X509NameType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2ImplUnix>.NativeClassPtr, 100665278);
			X509Certificate2ImplUnix.NativeMethodInfoPtr_get_Extensions_Public_Virtual_Final_get_IEnumerable_1_X509Extension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2ImplUnix>.NativeClassPtr, 100665279);
			X509Certificate2ImplUnix.NativeMethodInfoPtr_get_NotAfter_Public_Virtual_Final_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2ImplUnix>.NativeClassPtr, 100665280);
			X509Certificate2ImplUnix.NativeMethodInfoPtr_get_NotBefore_Public_Virtual_Final_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2ImplUnix>.NativeClassPtr, 100665281);
			X509Certificate2ImplUnix.NativeMethodInfoPtr_AppendPrivateKeyInfo_Public_Virtual_Final_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2ImplUnix>.NativeClassPtr, 100665282);
			X509Certificate2ImplUnix.NativeMethodInfoPtr_Export_Public_Virtual_Final_Il2CppStructArray_1_Byte_X509ContentType_SafePasswordHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2ImplUnix>.NativeClassPtr, 100665283);
			X509Certificate2ImplUnix.NativeMethodInfoPtr_ExportPkcs12_Private_Il2CppStructArray_1_Byte_SafePasswordHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2ImplUnix>.NativeClassPtr, 100665284);
			X509Certificate2ImplUnix.NativeMethodInfoPtr_ExportPkcs12_Private_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2ImplUnix>.NativeClassPtr, 100665285);
			X509Certificate2ImplUnix.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2ImplUnix>.NativeClassPtr, 100665286);
		}

		// Token: 0x06000DA2 RID: 3490 RVA: 0x0004F654 File Offset: 0x0004D854
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 454099, RefRangeEnd = 454113, XrefRangeStart = 454096, XrefRangeEnd = 454099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureCertData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2ImplUnix.NativeMethodInfoPtr_EnsureCertData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DA3 RID: 3491 RVA: 0x0004F688 File Offset: 0x0004D888
		[CallerCount(0)]
		public unsafe virtual Il2CppStructArray<byte> GetRawCertData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate2ImplUnix.NativeMethodInfoPtr_GetRawCertData_Protected_Abstract_Virtual_New_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06000DA4 RID: 3492 RVA: 0x0004F6D4 File Offset: 0x0004D8D4
		public unsafe override string KeyAlgorithm
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 454113, XrefRangeEnd = 454114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2ImplUnix.NativeMethodInfoPtr_get_KeyAlgorithm_Public_Virtual_Final_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06000DA5 RID: 3493 RVA: 0x0004F70C File Offset: 0x0004D90C
		public unsafe override Il2CppStructArray<byte> KeyAlgorithmParameters
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 454114, XrefRangeEnd = 454115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2ImplUnix.NativeMethodInfoPtr_get_KeyAlgorithmParameters_Public_Virtual_Final_get_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06000DA6 RID: 3494 RVA: 0x0004F74C File Offset: 0x0004D94C
		public unsafe override Il2CppStructArray<byte> PublicKeyValue
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 454115, XrefRangeEnd = 454116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2ImplUnix.NativeMethodInfoPtr_get_PublicKeyValue_Public_Virtual_Final_get_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06000DA7 RID: 3495 RVA: 0x0004F78C File Offset: 0x0004D98C
		public unsafe override Il2CppStructArray<byte> SerialNumber
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 454116, XrefRangeEnd = 454117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2ImplUnix.NativeMethodInfoPtr_get_SerialNumber_Public_Virtual_Final_get_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06000DA8 RID: 3496 RVA: 0x0004F7CC File Offset: 0x0004D9CC
		public unsafe override string SignatureAlgorithm
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 454117, XrefRangeEnd = 454118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2ImplUnix.NativeMethodInfoPtr_get_SignatureAlgorithm_Public_Virtual_Final_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06000DA9 RID: 3497 RVA: 0x0004F804 File Offset: 0x0004DA04
		public unsafe override int Version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 454118, XrefRangeEnd = 454119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2ImplUnix.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06000DAA RID: 3498 RVA: 0x0004F840 File Offset: 0x0004DA40
		public unsafe override X500DistinguishedName SubjectName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 454119, XrefRangeEnd = 454120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2ImplUnix.NativeMethodInfoPtr_get_SubjectName_Public_Virtual_Final_get_X500DistinguishedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X500DistinguishedName>(intPtr3) : null;
			}
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06000DAB RID: 3499 RVA: 0x0004F880 File Offset: 0x0004DA80
		public unsafe override X500DistinguishedName IssuerName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 454120, XrefRangeEnd = 454121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2ImplUnix.NativeMethodInfoPtr_get_IssuerName_Public_Virtual_Final_get_X500DistinguishedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X500DistinguishedName>(intPtr3) : null;
			}
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06000DAC RID: 3500 RVA: 0x0004F8C0 File Offset: 0x0004DAC0
		public unsafe override string Subject
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2ImplUnix.NativeMethodInfoPtr_get_Subject_Public_Virtual_Final_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06000DAD RID: 3501 RVA: 0x0004F8F8 File Offset: 0x0004DAF8
		public unsafe override string Issuer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2ImplUnix.NativeMethodInfoPtr_get_Issuer_Public_Virtual_Final_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06000DAE RID: 3502 RVA: 0x0004F930 File Offset: 0x0004DB30
		public unsafe override Il2CppStructArray<byte> RawData
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 454121, XrefRangeEnd = 454122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2ImplUnix.NativeMethodInfoPtr_get_RawData_Public_Virtual_Final_get_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06000DAF RID: 3503 RVA: 0x0004F970 File Offset: 0x0004DB70
		public unsafe override Il2CppStructArray<byte> Thumbprint
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 454122, XrefRangeEnd = 454131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2ImplUnix.NativeMethodInfoPtr_get_Thumbprint_Public_Virtual_Final_get_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06000DB0 RID: 3504 RVA: 0x0004F9B0 File Offset: 0x0004DBB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 454131, XrefRangeEnd = 454133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetNameInfo(X509NameType nameType, bool forIssuer)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2ImplUnix.NativeMethodInfoPtr_GetNameInfo_Public_Virtual_Final_String_X509NameType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06000DB1 RID: 3505 RVA: 0x0004FA04 File Offset: 0x0004DC04
		public unsafe override IEnumerable<X509Extension> Extensions
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 454133, XrefRangeEnd = 454134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2ImplUnix.NativeMethodInfoPtr_get_Extensions_Public_Virtual_Final_get_IEnumerable_1_X509Extension_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<X509Extension>>(intPtr3) : null;
			}
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06000DB2 RID: 3506 RVA: 0x0004FA44 File Offset: 0x0004DC44
		public unsafe override DateTime NotAfter
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 454134, XrefRangeEnd = 454139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2ImplUnix.NativeMethodInfoPtr_get_NotAfter_Public_Virtual_Final_get_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06000DB3 RID: 3507 RVA: 0x0004FA80 File Offset: 0x0004DC80
		public unsafe override DateTime NotBefore
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 454139, XrefRangeEnd = 454144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2ImplUnix.NativeMethodInfoPtr_get_NotBefore_Public_Virtual_Final_get_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DB4 RID: 3508 RVA: 0x0004FABC File Offset: 0x0004DCBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 454144, XrefRangeEnd = 454149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AppendPrivateKeyInfo(StringBuilder sb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2ImplUnix.NativeMethodInfoPtr_AppendPrivateKeyInfo_Public_Virtual_Final_Void_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DB5 RID: 3509 RVA: 0x0004FB00 File Offset: 0x0004DD00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 454149, XrefRangeEnd = 454166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppStructArray<byte> Export(X509ContentType contentType, SafePasswordHandle password)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref contentType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(password);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2ImplUnix.NativeMethodInfoPtr_Export_Public_Virtual_Final_Il2CppStructArray_1_Byte_X509ContentType_SafePasswordHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06000DB6 RID: 3510 RVA: 0x0004FB60 File Offset: 0x0004DD60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 454166, XrefRangeEnd = 454169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> ExportPkcs12(SafePasswordHandle password)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(password);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2ImplUnix.NativeMethodInfoPtr_ExportPkcs12_Private_Il2CppStructArray_1_Byte_SafePasswordHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06000DB7 RID: 3511 RVA: 0x0004FBB0 File Offset: 0x0004DDB0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 454206, RefRangeEnd = 454210, XrefRangeStart = 454169, XrefRangeEnd = 454206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> ExportPkcs12(string password)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(password);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2ImplUnix.NativeMethodInfoPtr_ExportPkcs12_Private_Il2CppStructArray_1_Byte_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06000DB8 RID: 3512 RVA: 0x0004FC00 File Offset: 0x0004DE00
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509Certificate2ImplUnix()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509Certificate2ImplUnix>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2ImplUnix.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DB9 RID: 3513 RVA: 0x00006FC6 File Offset: 0x000051C6
		public X509Certificate2ImplUnix(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06000DBA RID: 3514 RVA: 0x0004FC3C File Offset: 0x0004DE3C
		// (set) Token: 0x06000DBB RID: 3515 RVA: 0x00006FCF File Offset: 0x000051CF
		public unsafe bool readCertData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate2ImplUnix.NativeFieldInfoPtr_readCertData);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate2ImplUnix.NativeFieldInfoPtr_readCertData)) = value;
			}
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06000DBC RID: 3516 RVA: 0x0004FC64 File Offset: 0x0004DE64
		// (set) Token: 0x06000DBD RID: 3517 RVA: 0x00006FEA File Offset: 0x000051EA
		public CertificateData certData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate2ImplUnix.NativeFieldInfoPtr_certData);
				return new CertificateData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CertificateData>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate2ImplUnix.NativeFieldInfoPtr_certData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CertificateData>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000B3F RID: 2879
		private static readonly IntPtr NativeFieldInfoPtr_readCertData;

		// Token: 0x04000B40 RID: 2880
		private static readonly IntPtr NativeFieldInfoPtr_certData;

		// Token: 0x04000B41 RID: 2881
		private static readonly IntPtr NativeMethodInfoPtr_EnsureCertData_Private_Void_0;

		// Token: 0x04000B42 RID: 2882
		private static readonly IntPtr NativeMethodInfoPtr_GetRawCertData_Protected_Abstract_Virtual_New_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000B43 RID: 2883
		private static readonly IntPtr NativeMethodInfoPtr_get_KeyAlgorithm_Public_Virtual_Final_get_String_0;

		// Token: 0x04000B44 RID: 2884
		private static readonly IntPtr NativeMethodInfoPtr_get_KeyAlgorithmParameters_Public_Virtual_Final_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000B45 RID: 2885
		private static readonly IntPtr NativeMethodInfoPtr_get_PublicKeyValue_Public_Virtual_Final_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000B46 RID: 2886
		private static readonly IntPtr NativeMethodInfoPtr_get_SerialNumber_Public_Virtual_Final_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000B47 RID: 2887
		private static readonly IntPtr NativeMethodInfoPtr_get_SignatureAlgorithm_Public_Virtual_Final_get_String_0;

		// Token: 0x04000B48 RID: 2888
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_Final_get_Int32_0;

		// Token: 0x04000B49 RID: 2889
		private static readonly IntPtr NativeMethodInfoPtr_get_SubjectName_Public_Virtual_Final_get_X500DistinguishedName_0;

		// Token: 0x04000B4A RID: 2890
		private static readonly IntPtr NativeMethodInfoPtr_get_IssuerName_Public_Virtual_Final_get_X500DistinguishedName_0;

		// Token: 0x04000B4B RID: 2891
		private static readonly IntPtr NativeMethodInfoPtr_get_Subject_Public_Virtual_Final_get_String_0;

		// Token: 0x04000B4C RID: 2892
		private static readonly IntPtr NativeMethodInfoPtr_get_Issuer_Public_Virtual_Final_get_String_0;

		// Token: 0x04000B4D RID: 2893
		private static readonly IntPtr NativeMethodInfoPtr_get_RawData_Public_Virtual_Final_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000B4E RID: 2894
		private static readonly IntPtr NativeMethodInfoPtr_get_Thumbprint_Public_Virtual_Final_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000B4F RID: 2895
		private static readonly IntPtr NativeMethodInfoPtr_GetNameInfo_Public_Virtual_Final_String_X509NameType_Boolean_0;

		// Token: 0x04000B50 RID: 2896
		private static readonly IntPtr NativeMethodInfoPtr_get_Extensions_Public_Virtual_Final_get_IEnumerable_1_X509Extension_0;

		// Token: 0x04000B51 RID: 2897
		private static readonly IntPtr NativeMethodInfoPtr_get_NotAfter_Public_Virtual_Final_get_DateTime_0;

		// Token: 0x04000B52 RID: 2898
		private static readonly IntPtr NativeMethodInfoPtr_get_NotBefore_Public_Virtual_Final_get_DateTime_0;

		// Token: 0x04000B53 RID: 2899
		private static readonly IntPtr NativeMethodInfoPtr_AppendPrivateKeyInfo_Public_Virtual_Final_Void_StringBuilder_0;

		// Token: 0x04000B54 RID: 2900
		private static readonly IntPtr NativeMethodInfoPtr_Export_Public_Virtual_Final_Il2CppStructArray_1_Byte_X509ContentType_SafePasswordHandle_0;

		// Token: 0x04000B55 RID: 2901
		private static readonly IntPtr NativeMethodInfoPtr_ExportPkcs12_Private_Il2CppStructArray_1_Byte_SafePasswordHandle_0;

		// Token: 0x04000B56 RID: 2902
		private static readonly IntPtr NativeMethodInfoPtr_ExportPkcs12_Private_Il2CppStructArray_1_Byte_String_0;

		// Token: 0x04000B57 RID: 2903
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
