using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono.Security.Cryptography;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Security.Cryptography;

namespace Il2CppMono.Security.X509
{
	// Token: 0x02000008 RID: 8
	public class PKCS12 : Object
	{
		// Token: 0x0600003D RID: 61 RVA: 0x00005784 File Offset: 0x00003984
		// Note: this type is marked as 'beforefieldinit'.
		static PKCS12()
		{
			Il2CppClassPointerStore<PKCS12>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.X509", "PKCS12");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PKCS12>.NativeClassPtr);
			PKCS12.NativeFieldInfoPtr__password = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, "_password");
			PKCS12.NativeFieldInfoPtr__keyBags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, "_keyBags");
			PKCS12.NativeFieldInfoPtr__secretBags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, "_secretBags");
			PKCS12.NativeFieldInfoPtr__certs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, "_certs");
			PKCS12.NativeFieldInfoPtr__keyBagsChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, "_keyBagsChanged");
			PKCS12.NativeFieldInfoPtr__secretBagsChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, "_secretBagsChanged");
			PKCS12.NativeFieldInfoPtr__certsChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, "_certsChanged");
			PKCS12.NativeFieldInfoPtr__iterations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, "_iterations");
			PKCS12.NativeFieldInfoPtr__safeBags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, "_safeBags");
			PKCS12.NativeFieldInfoPtr__rng = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, "_rng");
			PKCS12.NativeFieldInfoPtr_password_max_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, "password_max_length");
			PKCS12.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663364);
			PKCS12.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663365);
			PKCS12.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663366);
			PKCS12.NativeMethodInfoPtr_Decode_Private_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663367);
			PKCS12.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663368);
			PKCS12.NativeMethodInfoPtr_set_Password_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663369);
			PKCS12.NativeMethodInfoPtr_get_IterationCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663370);
			PKCS12.NativeMethodInfoPtr_set_IterationCount_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663371);
			PKCS12.NativeMethodInfoPtr_get_Keys_Public_get_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663372);
			PKCS12.NativeMethodInfoPtr_get_Certificates_Public_get_X509CertificateCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663373);
			PKCS12.NativeMethodInfoPtr_get_RNG_Internal_get_RandomNumberGenerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663374);
			PKCS12.NativeMethodInfoPtr_Compare_Private_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663375);
			PKCS12.NativeMethodInfoPtr_GetSymmetricAlgorithm_Private_SymmetricAlgorithm_String_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663376);
			PKCS12.NativeMethodInfoPtr_Decrypt_Public_Il2CppStructArray_1_Byte_String_Il2CppStructArray_1_Byte_Int32_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663377);
			PKCS12.NativeMethodInfoPtr_Decrypt_Public_Il2CppStructArray_1_Byte_EncryptedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663378);
			PKCS12.NativeMethodInfoPtr_Encrypt_Public_Il2CppStructArray_1_Byte_String_Il2CppStructArray_1_Byte_Int32_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663379);
			PKCS12.NativeMethodInfoPtr_GetExistingParameters_Private_DSAParameters_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663380);
			PKCS12.NativeMethodInfoPtr_AddPrivateKey_Private_Void_PrivateKeyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663381);
			PKCS12.NativeMethodInfoPtr_ReadSafeBag_Private_Void_ASN1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663382);
			PKCS12.NativeMethodInfoPtr_Pkcs8ShroudedKeyBagSafeBag_Private_ASN1_AsymmetricAlgorithm_IDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663383);
			PKCS12.NativeMethodInfoPtr_CertificateSafeBag_Private_ASN1_X509Certificate_IDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663384);
			PKCS12.NativeMethodInfoPtr_MAC_Private_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663385);
			PKCS12.NativeMethodInfoPtr_GetBytes_Public_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663386);
			PKCS12.NativeMethodInfoPtr_EncryptedContentInfo_Private_ContentInfo_ASN1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663387);
			PKCS12.NativeMethodInfoPtr_AddCertificate_Public_Void_X509Certificate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663388);
			PKCS12.NativeMethodInfoPtr_AddCertificate_Public_Void_X509Certificate_IDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663389);
			PKCS12.NativeMethodInfoPtr_RemoveCertificate_Public_Void_X509Certificate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663390);
			PKCS12.NativeMethodInfoPtr_RemoveCertificate_Public_Void_X509Certificate_IDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663391);
			PKCS12.NativeMethodInfoPtr_CompareAsymmetricAlgorithm_Private_Boolean_AsymmetricAlgorithm_AsymmetricAlgorithm_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663392);
			PKCS12.NativeMethodInfoPtr_AddPkcs8ShroudedKeyBag_Public_Void_AsymmetricAlgorithm_IDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663393);
			PKCS12.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663394);
			PKCS12.NativeMethodInfoPtr_get_MaximumPasswordLength_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663395);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00005B10 File Offset: 0x00003D10
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1145089, RefRangeEnd = 1145094, XrefRangeStart = 1145070, XrefRangeEnd = 1145089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PKCS12()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PKCS12>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00005B4C File Offset: 0x00003D4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1145094, XrefRangeEnd = 1145100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PKCS12(Il2CppStructArray<byte> data)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PKCS12>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00005B98 File Offset: 0x00003D98
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1145103, RefRangeEnd = 1145106, XrefRangeStart = 1145100, XrefRangeEnd = 1145103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PKCS12(Il2CppStructArray<byte> data, string password)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PKCS12>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(password);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00005BF8 File Offset: 0x00003DF8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1145185, RefRangeEnd = 1145188, XrefRangeStart = 1145106, XrefRangeEnd = 1145185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Decode(Il2CppStructArray<byte> data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr_Decode_Private_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00005C3C File Offset: 0x00003E3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1145188, XrefRangeEnd = 1145193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PKCS12.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000018 RID: 24
		// (set) Token: 0x06000043 RID: 67 RVA: 0x00005C78 File Offset: 0x00003E78
		public unsafe string Password
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1145215, RefRangeEnd = 1145220, XrefRangeStart = 1145193, XrefRangeEnd = 1145215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr_set_Password_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000044 RID: 68 RVA: 0x00005CBC File Offset: 0x00003EBC
		// (set) Token: 0x06000045 RID: 69 RVA: 0x00005CF8 File Offset: 0x00003EF8
		public unsafe int IterationCount
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 134006, RefRangeEnd = 134007, XrefRangeStart = 134006, XrefRangeEnd = 134007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr_get_IterationCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr_set_IterationCount_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000046 RID: 70 RVA: 0x00005D38 File Offset: 0x00003F38
		public unsafe ArrayList Keys
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1145274, RefRangeEnd = 1145276, XrefRangeStart = 1145220, XrefRangeEnd = 1145274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr_get_Keys_Public_get_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr3) : null;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000047 RID: 71 RVA: 0x00005D78 File Offset: 0x00003F78
		public unsafe X509CertificateCollection Certificates
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 1145309, RefRangeEnd = 1145317, XrefRangeStart = 1145276, XrefRangeEnd = 1145309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr_get_Certificates_Public_get_X509CertificateCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509CertificateCollection>(intPtr3) : null;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000048 RID: 72 RVA: 0x00005DB8 File Offset: 0x00003FB8
		public unsafe RandomNumberGenerator RNG
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1145317, XrefRangeEnd = 1145319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr_get_RNG_Internal_get_RandomNumberGenerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RandomNumberGenerator>(intPtr3) : null;
			}
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00005DF8 File Offset: 0x00003FF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1145320, RefRangeEnd = 1145322, XrefRangeStart = 1145319, XrefRangeEnd = 1145320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Compare(Il2CppStructArray<byte> expected, Il2CppStructArray<byte> actual)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expected);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(actual);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr_Compare_Private_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00005E58 File Offset: 0x00004058
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1145424, RefRangeEnd = 1145426, XrefRangeStart = 1145322, XrefRangeEnd = 1145424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SymmetricAlgorithm GetSymmetricAlgorithm(string algorithmOid, Il2CppStructArray<byte> salt, int iterationCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(algorithmOid);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(salt);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iterationCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr_GetSymmetricAlgorithm_Private_SymmetricAlgorithm_String_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SymmetricAlgorithm>(intPtr3) : null;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00005EC8 File Offset: 0x000040C8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1145433, RefRangeEnd = 1145437, XrefRangeStart = 1145426, XrefRangeEnd = 1145433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> Decrypt(string algorithmOid, Il2CppStructArray<byte> salt, int iterationCount, Il2CppStructArray<byte> encryptedData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(algorithmOid);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(salt);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iterationCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encryptedData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr_Decrypt_Public_Il2CppStructArray_1_Byte_String_Il2CppStructArray_1_Byte_Int32_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00005F4C File Offset: 0x0000414C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1145447, RefRangeEnd = 1145448, XrefRangeStart = 1145437, XrefRangeEnd = 1145447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> Decrypt(PKCS7.EncryptedData ed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ed);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr_Decrypt_Public_Il2CppStructArray_1_Byte_EncryptedData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00005F9C File Offset: 0x0000419C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1145458, RefRangeEnd = 1145460, XrefRangeStart = 1145448, XrefRangeEnd = 1145458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> Encrypt(string algorithmOid, Il2CppStructArray<byte> salt, int iterationCount, Il2CppStructArray<byte> data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(algorithmOid);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(salt);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iterationCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr_Encrypt_Public_Il2CppStructArray_1_Byte_String_Il2CppStructArray_1_Byte_Int32_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00006020 File Offset: 0x00004220
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1145476, RefRangeEnd = 1145477, XrefRangeStart = 1145460, XrefRangeEnd = 1145476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DSAParameters GetExistingParameters(out bool found)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &found;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr_GetExistingParameters_Private_DSAParameters_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new DSAParameters(intPtr);
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00006064 File Offset: 0x00004264
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1145494, RefRangeEnd = 1145496, XrefRangeStart = 1145477, XrefRangeEnd = 1145494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddPrivateKey(PKCS8.PrivateKeyInfo pki)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pki);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr_AddPrivateKey_Private_Void_PrivateKeyInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000060A8 File Offset: 0x000042A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1145639, RefRangeEnd = 1145641, XrefRangeStart = 1145496, XrefRangeEnd = 1145639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadSafeBag(ASN1 safeBag)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(safeBag);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr_ReadSafeBag_Private_Void_ASN1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000051 RID: 81 RVA: 0x000060EC File Offset: 0x000042EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1145801, RefRangeEnd = 1145802, XrefRangeStart = 1145641, XrefRangeEnd = 1145801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ASN1 Pkcs8ShroudedKeyBagSafeBag(AsymmetricAlgorithm aa, IDictionary attributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(aa);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr_Pkcs8ShroudedKeyBagSafeBag_Private_ASN1_AsymmetricAlgorithm_IDictionary_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ASN1>(intPtr3) : null;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00006150 File Offset: 0x00004350
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1145944, RefRangeEnd = 1145945, XrefRangeStart = 1145802, XrefRangeEnd = 1145944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ASN1 CertificateSafeBag(X509Certificate x509, IDictionary attributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x509);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr_CertificateSafeBag_Private_ASN1_X509Certificate_IDictionary_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ASN1>(intPtr3) : null;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x000061B4 File Offset: 0x000043B4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1145965, RefRangeEnd = 1145968, XrefRangeStart = 1145945, XrefRangeEnd = 1145965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> MAC(Il2CppStructArray<byte> password, Il2CppStructArray<byte> salt, int iterations, Il2CppStructArray<byte> data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(password);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(salt);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iterations;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr_MAC_Private_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00006238 File Offset: 0x00004438
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1146355, RefRangeEnd = 1146358, XrefRangeStart = 1145968, XrefRangeEnd = 1146355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> GetBytes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr_GetBytes_Public_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00006278 File Offset: 0x00004478
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1146476, RefRangeEnd = 1146478, XrefRangeStart = 1146358, XrefRangeEnd = 1146476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PKCS7.ContentInfo EncryptedContentInfo(ASN1 safeBags, string algorithmOid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(safeBags);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(algorithmOid);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr_EncryptedContentInfo_Private_ContentInfo_ASN1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PKCS7.ContentInfo>(intPtr3) : null;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000062DC File Offset: 0x000044DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1146479, RefRangeEnd = 1146480, XrefRangeStart = 1146478, XrefRangeEnd = 1146479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCertificate(X509Certificate cert)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cert);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr_AddCertificate_Public_Void_X509Certificate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00006320 File Offset: 0x00004520
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1146506, RefRangeEnd = 1146509, XrefRangeStart = 1146480, XrefRangeEnd = 1146506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCertificate(X509Certificate cert, IDictionary attributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cert);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr_AddCertificate_Public_Void_X509Certificate_IDictionary_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00006374 File Offset: 0x00004574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1146509, XrefRangeEnd = 1146512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveCertificate(X509Certificate cert)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cert);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr_RemoveCertificate_Public_Void_X509Certificate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000063B8 File Offset: 0x000045B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1146558, RefRangeEnd = 1146560, XrefRangeStart = 1146512, XrefRangeEnd = 1146558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveCertificate(X509Certificate cert, IDictionary attrs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cert);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attrs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr_RemoveCertificate_Public_Void_X509Certificate_IDictionary_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0000640C File Offset: 0x0000460C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1146561, RefRangeEnd = 1146562, XrefRangeStart = 1146560, XrefRangeEnd = 1146561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CompareAsymmetricAlgorithm(AsymmetricAlgorithm a1, AsymmetricAlgorithm a2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(a2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr_CompareAsymmetricAlgorithm_Private_Boolean_AsymmetricAlgorithm_AsymmetricAlgorithm_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x0000646C File Offset: 0x0000466C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1146595, RefRangeEnd = 1146596, XrefRangeStart = 1146562, XrefRangeEnd = 1146595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddPkcs8ShroudedKeyBag(AsymmetricAlgorithm aa, IDictionary attributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(aa);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr_AddPkcs8ShroudedKeyBag_Public_Void_AsymmetricAlgorithm_IDictionary_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x000064C0 File Offset: 0x000046C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1146596, XrefRangeEnd = 1146613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600005D RID: 93 RVA: 0x00006500 File Offset: 0x00004700
		public unsafe static int MaximumPasswordLength
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1146613, XrefRangeEnd = 1146617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr_get_MaximumPasswordLength_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002150 File Offset: 0x00000350
		public PKCS12(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600005F RID: 95 RVA: 0x00006530 File Offset: 0x00004730
		// (set) Token: 0x06000060 RID: 96 RVA: 0x00002159 File Offset: 0x00000359
		public unsafe Il2CppStructArray<byte> _password
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.NativeFieldInfoPtr__password);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.NativeFieldInfoPtr__password), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000061 RID: 97 RVA: 0x00006560 File Offset: 0x00004760
		// (set) Token: 0x06000062 RID: 98 RVA: 0x00002178 File Offset: 0x00000378
		public unsafe ArrayList _keyBags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.NativeFieldInfoPtr__keyBags);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.NativeFieldInfoPtr__keyBags), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000063 RID: 99 RVA: 0x00006590 File Offset: 0x00004790
		// (set) Token: 0x06000064 RID: 100 RVA: 0x00002197 File Offset: 0x00000397
		public unsafe ArrayList _secretBags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.NativeFieldInfoPtr__secretBags);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.NativeFieldInfoPtr__secretBags), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000065 RID: 101 RVA: 0x000065C0 File Offset: 0x000047C0
		// (set) Token: 0x06000066 RID: 102 RVA: 0x000021B6 File Offset: 0x000003B6
		public unsafe X509CertificateCollection _certs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.NativeFieldInfoPtr__certs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509CertificateCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.NativeFieldInfoPtr__certs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000067 RID: 103 RVA: 0x000065F0 File Offset: 0x000047F0
		// (set) Token: 0x06000068 RID: 104 RVA: 0x000021D5 File Offset: 0x000003D5
		public unsafe bool _keyBagsChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.NativeFieldInfoPtr__keyBagsChanged);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.NativeFieldInfoPtr__keyBagsChanged)) = value;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000069 RID: 105 RVA: 0x00006618 File Offset: 0x00004818
		// (set) Token: 0x0600006A RID: 106 RVA: 0x000021F0 File Offset: 0x000003F0
		public unsafe bool _secretBagsChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.NativeFieldInfoPtr__secretBagsChanged);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.NativeFieldInfoPtr__secretBagsChanged)) = value;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600006B RID: 107 RVA: 0x00006640 File Offset: 0x00004840
		// (set) Token: 0x0600006C RID: 108 RVA: 0x0000220B File Offset: 0x0000040B
		public unsafe bool _certsChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.NativeFieldInfoPtr__certsChanged);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.NativeFieldInfoPtr__certsChanged)) = value;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600006D RID: 109 RVA: 0x00006668 File Offset: 0x00004868
		// (set) Token: 0x0600006E RID: 110 RVA: 0x00002226 File Offset: 0x00000426
		public unsafe int _iterations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.NativeFieldInfoPtr__iterations);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.NativeFieldInfoPtr__iterations)) = value;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600006F RID: 111 RVA: 0x00006690 File Offset: 0x00004890
		// (set) Token: 0x06000070 RID: 112 RVA: 0x00002241 File Offset: 0x00000441
		public unsafe ArrayList _safeBags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.NativeFieldInfoPtr__safeBags);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.NativeFieldInfoPtr__safeBags), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000071 RID: 113 RVA: 0x000066C0 File Offset: 0x000048C0
		// (set) Token: 0x06000072 RID: 114 RVA: 0x00002260 File Offset: 0x00000460
		public unsafe RandomNumberGenerator _rng
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.NativeFieldInfoPtr__rng);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RandomNumberGenerator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.NativeFieldInfoPtr__rng), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000073 RID: 115 RVA: 0x000066F0 File Offset: 0x000048F0
		// (set) Token: 0x06000074 RID: 116 RVA: 0x0000227F File Offset: 0x0000047F
		public unsafe static int password_max_length
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(PKCS12.NativeFieldInfoPtr_password_max_length, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PKCS12.NativeFieldInfoPtr_password_max_length, (void*)(&value));
			}
		}

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeFieldInfoPtr__password;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeFieldInfoPtr__keyBags;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeFieldInfoPtr__secretBags;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeFieldInfoPtr__certs;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeFieldInfoPtr__keyBagsChanged;

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeFieldInfoPtr__secretBagsChanged;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeFieldInfoPtr__certsChanged;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeFieldInfoPtr__iterations;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeFieldInfoPtr__safeBags;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeFieldInfoPtr__rng;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeFieldInfoPtr_password_max_length;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_String_0;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeMethodInfoPtr_Decode_Private_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeMethodInfoPtr_set_Password_Public_set_Void_String_0;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeMethodInfoPtr_get_IterationCount_Public_get_Int32_0;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeMethodInfoPtr_set_IterationCount_Public_set_Void_Int32_0;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeMethodInfoPtr_get_Keys_Public_get_ArrayList_0;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeMethodInfoPtr_get_Certificates_Public_get_X509CertificateCollection_0;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeMethodInfoPtr_get_RNG_Internal_get_RandomNumberGenerator_0;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Private_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeMethodInfoPtr_GetSymmetricAlgorithm_Private_SymmetricAlgorithm_String_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeMethodInfoPtr_Decrypt_Public_Il2CppStructArray_1_Byte_String_Il2CppStructArray_1_Byte_Int32_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeMethodInfoPtr_Decrypt_Public_Il2CppStructArray_1_Byte_EncryptedData_0;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeMethodInfoPtr_Encrypt_Public_Il2CppStructArray_1_Byte_String_Il2CppStructArray_1_Byte_Int32_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeMethodInfoPtr_GetExistingParameters_Private_DSAParameters_byref_Boolean_0;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeMethodInfoPtr_AddPrivateKey_Private_Void_PrivateKeyInfo_0;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeMethodInfoPtr_ReadSafeBag_Private_Void_ASN1_0;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeMethodInfoPtr_Pkcs8ShroudedKeyBagSafeBag_Private_ASN1_AsymmetricAlgorithm_IDictionary_0;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeMethodInfoPtr_CertificateSafeBag_Private_ASN1_X509Certificate_IDictionary_0;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeMethodInfoPtr_MAC_Private_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeMethodInfoPtr_EncryptedContentInfo_Private_ContentInfo_ASN1_String_0;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeMethodInfoPtr_AddCertificate_Public_Void_X509Certificate_0;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeMethodInfoPtr_AddCertificate_Public_Void_X509Certificate_IDictionary_0;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeMethodInfoPtr_RemoveCertificate_Public_Void_X509Certificate_0;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeMethodInfoPtr_RemoveCertificate_Public_Void_X509Certificate_IDictionary_0;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeMethodInfoPtr_CompareAsymmetricAlgorithm_Private_Boolean_AsymmetricAlgorithm_AsymmetricAlgorithm_0;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeMethodInfoPtr_AddPkcs8ShroudedKeyBag_Public_Void_AsymmetricAlgorithm_IDictionary_0;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeMethodInfoPtr_get_MaximumPasswordLength_Public_Static_get_Int32_0;

		// Token: 0x02000049 RID: 73
		public class DeriveBytes : Object
		{
			// Token: 0x0600047E RID: 1150 RVA: 0x000147F4 File Offset: 0x000129F4
			// Note: this type is marked as 'beforefieldinit'.
			static DeriveBytes()
			{
				Il2CppClassPointerStore<PKCS12.DeriveBytes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, "DeriveBytes");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PKCS12.DeriveBytes>.NativeClassPtr);
				PKCS12.DeriveBytes.NativeFieldInfoPtr_keyDiversifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS12.DeriveBytes>.NativeClassPtr, "keyDiversifier");
				PKCS12.DeriveBytes.NativeFieldInfoPtr_ivDiversifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS12.DeriveBytes>.NativeClassPtr, "ivDiversifier");
				PKCS12.DeriveBytes.NativeFieldInfoPtr_macDiversifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS12.DeriveBytes>.NativeClassPtr, "macDiversifier");
				PKCS12.DeriveBytes.NativeFieldInfoPtr__hashName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS12.DeriveBytes>.NativeClassPtr, "_hashName");
				PKCS12.DeriveBytes.NativeFieldInfoPtr__iterations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS12.DeriveBytes>.NativeClassPtr, "_iterations");
				PKCS12.DeriveBytes.NativeFieldInfoPtr__password = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS12.DeriveBytes>.NativeClassPtr, "_password");
				PKCS12.DeriveBytes.NativeFieldInfoPtr__salt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS12.DeriveBytes>.NativeClassPtr, "_salt");
				PKCS12.DeriveBytes.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12.DeriveBytes>.NativeClassPtr, 100663397);
				PKCS12.DeriveBytes.NativeMethodInfoPtr_set_HashName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12.DeriveBytes>.NativeClassPtr, 100663398);
				PKCS12.DeriveBytes.NativeMethodInfoPtr_set_IterationCount_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12.DeriveBytes>.NativeClassPtr, 100663399);
				PKCS12.DeriveBytes.NativeMethodInfoPtr_set_Password_Public_set_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12.DeriveBytes>.NativeClassPtr, 100663400);
				PKCS12.DeriveBytes.NativeMethodInfoPtr_set_Salt_Public_set_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12.DeriveBytes>.NativeClassPtr, 100663401);
				PKCS12.DeriveBytes.NativeMethodInfoPtr_Adjust_Private_Void_Il2CppStructArray_1_Byte_Int32_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12.DeriveBytes>.NativeClassPtr, 100663402);
				PKCS12.DeriveBytes.NativeMethodInfoPtr_Derive_Private_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12.DeriveBytes>.NativeClassPtr, 100663403);
				PKCS12.DeriveBytes.NativeMethodInfoPtr_DeriveKey_Public_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12.DeriveBytes>.NativeClassPtr, 100663404);
				PKCS12.DeriveBytes.NativeMethodInfoPtr_DeriveIV_Public_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12.DeriveBytes>.NativeClassPtr, 100663405);
				PKCS12.DeriveBytes.NativeMethodInfoPtr_DeriveMAC_Public_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12.DeriveBytes>.NativeClassPtr, 100663406);
			}

			// Token: 0x0600047F RID: 1151 RVA: 0x00014974 File Offset: 0x00012B74
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DeriveBytes()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PKCS12.DeriveBytes>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.DeriveBytes.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700018E RID: 398
			// (set) Token: 0x06000480 RID: 1152 RVA: 0x000149B0 File Offset: 0x00012BB0
			public unsafe string HashName
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.DeriveBytes.NativeMethodInfoPtr_set_HashName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700018F RID: 399
			// (set) Token: 0x06000481 RID: 1153 RVA: 0x000149F4 File Offset: 0x00012BF4
			public unsafe int IterationCount
			{
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.DeriveBytes.NativeMethodInfoPtr_set_IterationCount_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000190 RID: 400
			// (set) Token: 0x06000482 RID: 1154 RVA: 0x00014A34 File Offset: 0x00012C34
			public unsafe Il2CppStructArray<byte> Password
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 1145001, RefRangeEnd = 1145003, XrefRangeStart = 1144988, XrefRangeEnd = 1145001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.DeriveBytes.NativeMethodInfoPtr_set_Password_Public_set_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000191 RID: 401
			// (set) Token: 0x06000483 RID: 1155 RVA: 0x00014A78 File Offset: 0x00012C78
			public unsafe Il2CppStructArray<byte> Salt
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 1145014, RefRangeEnd = 1145016, XrefRangeStart = 1145003, XrefRangeEnd = 1145014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.DeriveBytes.NativeMethodInfoPtr_set_Salt_Public_set_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06000484 RID: 1156 RVA: 0x00014ABC File Offset: 0x00012CBC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1145016, RefRangeEnd = 1145017, XrefRangeStart = 1145016, XrefRangeEnd = 1145016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Adjust(Il2CppStructArray<byte> a, int aOff, Il2CppStructArray<byte> b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref aOff;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.DeriveBytes.NativeMethodInfoPtr_Adjust_Private_Void_Il2CppStructArray_1_Byte_Int32_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000485 RID: 1157 RVA: 0x00014B20 File Offset: 0x00012D20
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1145049, RefRangeEnd = 1145055, XrefRangeStart = 1145017, XrefRangeEnd = 1145049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppStructArray<byte> Derive(Il2CppStructArray<byte> diversifier, int n)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(diversifier);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.DeriveBytes.NativeMethodInfoPtr_Derive_Private_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}

			// Token: 0x06000486 RID: 1158 RVA: 0x00014B80 File Offset: 0x00012D80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1145055, XrefRangeEnd = 1145060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppStructArray<byte> DeriveKey(int size)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref size;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.DeriveBytes.NativeMethodInfoPtr_DeriveKey_Public_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
				}
			}

			// Token: 0x06000487 RID: 1159 RVA: 0x00014BCC File Offset: 0x00012DCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1145060, XrefRangeEnd = 1145065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppStructArray<byte> DeriveIV(int size)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref size;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.DeriveBytes.NativeMethodInfoPtr_DeriveIV_Public_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
				}
			}

			// Token: 0x06000488 RID: 1160 RVA: 0x00014C18 File Offset: 0x00012E18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1145065, XrefRangeEnd = 1145070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppStructArray<byte> DeriveMAC(int size)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref size;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.DeriveBytes.NativeMethodInfoPtr_DeriveMAC_Public_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
				}
			}

			// Token: 0x06000489 RID: 1161 RVA: 0x00003EA7 File Offset: 0x000020A7
			public DeriveBytes(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000187 RID: 391
			// (get) Token: 0x0600048A RID: 1162 RVA: 0x00014C64 File Offset: 0x00012E64
			// (set) Token: 0x0600048B RID: 1163 RVA: 0x00003EB0 File Offset: 0x000020B0
			public unsafe static Il2CppStructArray<byte> keyDiversifier
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PKCS12.DeriveBytes.NativeFieldInfoPtr_keyDiversifier, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PKCS12.DeriveBytes.NativeFieldInfoPtr_keyDiversifier, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000188 RID: 392
			// (get) Token: 0x0600048C RID: 1164 RVA: 0x00014C8C File Offset: 0x00012E8C
			// (set) Token: 0x0600048D RID: 1165 RVA: 0x00003EC2 File Offset: 0x000020C2
			public unsafe static Il2CppStructArray<byte> ivDiversifier
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PKCS12.DeriveBytes.NativeFieldInfoPtr_ivDiversifier, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PKCS12.DeriveBytes.NativeFieldInfoPtr_ivDiversifier, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000189 RID: 393
			// (get) Token: 0x0600048E RID: 1166 RVA: 0x00014CB4 File Offset: 0x00012EB4
			// (set) Token: 0x0600048F RID: 1167 RVA: 0x00003ED4 File Offset: 0x000020D4
			public unsafe static Il2CppStructArray<byte> macDiversifier
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PKCS12.DeriveBytes.NativeFieldInfoPtr_macDiversifier, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PKCS12.DeriveBytes.NativeFieldInfoPtr_macDiversifier, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700018A RID: 394
			// (get) Token: 0x06000490 RID: 1168 RVA: 0x00014CDC File Offset: 0x00012EDC
			// (set) Token: 0x06000491 RID: 1169 RVA: 0x00003EE6 File Offset: 0x000020E6
			public unsafe string _hashName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.DeriveBytes.NativeFieldInfoPtr__hashName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.DeriveBytes.NativeFieldInfoPtr__hashName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700018B RID: 395
			// (get) Token: 0x06000492 RID: 1170 RVA: 0x00014D04 File Offset: 0x00012F04
			// (set) Token: 0x06000493 RID: 1171 RVA: 0x00003F05 File Offset: 0x00002105
			public unsafe int _iterations
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.DeriveBytes.NativeFieldInfoPtr__iterations);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.DeriveBytes.NativeFieldInfoPtr__iterations)) = value;
				}
			}

			// Token: 0x1700018C RID: 396
			// (get) Token: 0x06000494 RID: 1172 RVA: 0x00014D2C File Offset: 0x00012F2C
			// (set) Token: 0x06000495 RID: 1173 RVA: 0x00003F20 File Offset: 0x00002120
			public unsafe Il2CppStructArray<byte> _password
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.DeriveBytes.NativeFieldInfoPtr__password);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.DeriveBytes.NativeFieldInfoPtr__password), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700018D RID: 397
			// (get) Token: 0x06000496 RID: 1174 RVA: 0x00014D5C File Offset: 0x00012F5C
			// (set) Token: 0x06000497 RID: 1175 RVA: 0x00003F3F File Offset: 0x0000213F
			public unsafe Il2CppStructArray<byte> _salt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.DeriveBytes.NativeFieldInfoPtr__salt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.DeriveBytes.NativeFieldInfoPtr__salt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000451 RID: 1105
			private static readonly IntPtr NativeFieldInfoPtr_keyDiversifier;

			// Token: 0x04000452 RID: 1106
			private static readonly IntPtr NativeFieldInfoPtr_ivDiversifier;

			// Token: 0x04000453 RID: 1107
			private static readonly IntPtr NativeFieldInfoPtr_macDiversifier;

			// Token: 0x04000454 RID: 1108
			private static readonly IntPtr NativeFieldInfoPtr__hashName;

			// Token: 0x04000455 RID: 1109
			private static readonly IntPtr NativeFieldInfoPtr__iterations;

			// Token: 0x04000456 RID: 1110
			private static readonly IntPtr NativeFieldInfoPtr__password;

			// Token: 0x04000457 RID: 1111
			private static readonly IntPtr NativeFieldInfoPtr__salt;

			// Token: 0x04000458 RID: 1112
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000459 RID: 1113
			private static readonly IntPtr NativeMethodInfoPtr_set_HashName_Public_set_Void_String_0;

			// Token: 0x0400045A RID: 1114
			private static readonly IntPtr NativeMethodInfoPtr_set_IterationCount_Public_set_Void_Int32_0;

			// Token: 0x0400045B RID: 1115
			private static readonly IntPtr NativeMethodInfoPtr_set_Password_Public_set_Void_Il2CppStructArray_1_Byte_0;

			// Token: 0x0400045C RID: 1116
			private static readonly IntPtr NativeMethodInfoPtr_set_Salt_Public_set_Void_Il2CppStructArray_1_Byte_0;

			// Token: 0x0400045D RID: 1117
			private static readonly IntPtr NativeMethodInfoPtr_Adjust_Private_Void_Il2CppStructArray_1_Byte_Int32_Il2CppStructArray_1_Byte_0;

			// Token: 0x0400045E RID: 1118
			private static readonly IntPtr NativeMethodInfoPtr_Derive_Private_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_0;

			// Token: 0x0400045F RID: 1119
			private static readonly IntPtr NativeMethodInfoPtr_DeriveKey_Public_Il2CppStructArray_1_Byte_Int32_0;

			// Token: 0x04000460 RID: 1120
			private static readonly IntPtr NativeMethodInfoPtr_DeriveIV_Public_Il2CppStructArray_1_Byte_Int32_0;

			// Token: 0x04000461 RID: 1121
			private static readonly IntPtr NativeMethodInfoPtr_DeriveMAC_Public_Il2CppStructArray_1_Byte_Int32_0;
		}
	}
}
