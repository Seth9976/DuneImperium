using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono.Security.X509;
using Il2CppSystem;
using Il2CppSystem.Security.Cryptography;

namespace Il2CppMono.Security.Authenticode
{
	// Token: 0x0200003C RID: 60
	public class AuthenticodeDeformatter : AuthenticodeBase
	{
		// Token: 0x0600036E RID: 878 RVA: 0x00010F9C File Offset: 0x0000F19C
		// Note: this type is marked as 'beforefieldinit'.
		static AuthenticodeDeformatter()
		{
			Il2CppClassPointerStore<AuthenticodeDeformatter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.Authenticode", "AuthenticodeDeformatter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AuthenticodeDeformatter>.NativeClassPtr);
			AuthenticodeDeformatter.NativeFieldInfoPtr_filename = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthenticodeDeformatter>.NativeClassPtr, "filename");
			AuthenticodeDeformatter.NativeFieldInfoPtr_rawdata = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthenticodeDeformatter>.NativeClassPtr, "rawdata");
			AuthenticodeDeformatter.NativeFieldInfoPtr_hash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthenticodeDeformatter>.NativeClassPtr, "hash");
			AuthenticodeDeformatter.NativeFieldInfoPtr_coll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthenticodeDeformatter>.NativeClassPtr, "coll");
			AuthenticodeDeformatter.NativeFieldInfoPtr_signedHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthenticodeDeformatter>.NativeClassPtr, "signedHash");
			AuthenticodeDeformatter.NativeFieldInfoPtr_timestamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthenticodeDeformatter>.NativeClassPtr, "timestamp");
			AuthenticodeDeformatter.NativeFieldInfoPtr_signingCertificate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthenticodeDeformatter>.NativeClassPtr, "signingCertificate");
			AuthenticodeDeformatter.NativeFieldInfoPtr_reason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthenticodeDeformatter>.NativeClassPtr, "reason");
			AuthenticodeDeformatter.NativeFieldInfoPtr_trustedRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthenticodeDeformatter>.NativeClassPtr, "trustedRoot");
			AuthenticodeDeformatter.NativeFieldInfoPtr_trustedTimestampRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthenticodeDeformatter>.NativeClassPtr, "trustedTimestampRoot");
			AuthenticodeDeformatter.NativeFieldInfoPtr_entry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthenticodeDeformatter>.NativeClassPtr, "entry");
			AuthenticodeDeformatter.NativeFieldInfoPtr_signerChain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthenticodeDeformatter>.NativeClassPtr, "signerChain");
			AuthenticodeDeformatter.NativeFieldInfoPtr_timestampChain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthenticodeDeformatter>.NativeClassPtr, "timestampChain");
			AuthenticodeDeformatter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthenticodeDeformatter>.NativeClassPtr, 100663798);
			AuthenticodeDeformatter.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthenticodeDeformatter>.NativeClassPtr, 100663799);
			AuthenticodeDeformatter.NativeMethodInfoPtr_set_RawData_Public_set_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthenticodeDeformatter>.NativeClassPtr, 100663800);
			AuthenticodeDeformatter.NativeMethodInfoPtr_get_SigningCertificate_Public_get_X509Certificate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthenticodeDeformatter>.NativeClassPtr, 100663801);
			AuthenticodeDeformatter.NativeMethodInfoPtr_CheckSignature_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthenticodeDeformatter>.NativeClassPtr, 100663802);
			AuthenticodeDeformatter.NativeMethodInfoPtr_CompareIssuerSerial_Private_Boolean_String_Il2CppStructArray_1_Byte_X509Certificate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthenticodeDeformatter>.NativeClassPtr, 100663803);
			AuthenticodeDeformatter.NativeMethodInfoPtr_VerifySignature_Private_Boolean_SignedData_Il2CppStructArray_1_Byte_HashAlgorithm_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthenticodeDeformatter>.NativeClassPtr, 100663804);
			AuthenticodeDeformatter.NativeMethodInfoPtr_VerifyCounterSignature_Private_Boolean_SignerInfo_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthenticodeDeformatter>.NativeClassPtr, 100663805);
			AuthenticodeDeformatter.NativeMethodInfoPtr_Reset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthenticodeDeformatter>.NativeClassPtr, 100663806);
		}

		// Token: 0x0600036F RID: 879 RVA: 0x00011184 File Offset: 0x0000F384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150864, XrefRangeEnd = 1150878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AuthenticodeDeformatter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AuthenticodeDeformatter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthenticodeDeformatter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000370 RID: 880 RVA: 0x000111C0 File Offset: 0x0000F3C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1150893, RefRangeEnd = 1150895, XrefRangeStart = 1150878, XrefRangeEnd = 1150893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AuthenticodeDeformatter(Il2CppStructArray<byte> rawData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AuthenticodeDeformatter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rawData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthenticodeDeformatter.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000136 RID: 310
		// (set) Token: 0x06000371 RID: 881 RVA: 0x0001120C File Offset: 0x0000F40C
		public unsafe Il2CppStructArray<byte> RawData
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1150910, RefRangeEnd = 1150911, XrefRangeStart = 1150895, XrefRangeEnd = 1150910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthenticodeDeformatter.NativeMethodInfoPtr_set_RawData_Public_set_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000372 RID: 882 RVA: 0x00011250 File Offset: 0x0000F450
		public unsafe X509Certificate SigningCertificate
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 34746, RefRangeEnd = 34747, XrefRangeStart = 34746, XrefRangeEnd = 34747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthenticodeDeformatter.NativeMethodInfoPtr_get_SigningCertificate_Public_get_X509Certificate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate>(intPtr3) : null;
			}
		}

		// Token: 0x06000373 RID: 883 RVA: 0x00011290 File Offset: 0x0000F490
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1151051, RefRangeEnd = 1151052, XrefRangeStart = 1150911, XrefRangeEnd = 1151051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckSignature()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthenticodeDeformatter.NativeMethodInfoPtr_CheckSignature_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000374 RID: 884 RVA: 0x000112CC File Offset: 0x0000F4CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1151054, RefRangeEnd = 1151056, XrefRangeStart = 1151052, XrefRangeEnd = 1151054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CompareIssuerSerial(string issuer, Il2CppStructArray<byte> serial, X509Certificate x509)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(issuer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serial);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(x509);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthenticodeDeformatter.NativeMethodInfoPtr_CompareIssuerSerial_Private_Boolean_String_Il2CppStructArray_1_Byte_X509Certificate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000375 RID: 885 RVA: 0x00011340 File Offset: 0x0000F540
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1151142, RefRangeEnd = 1151143, XrefRangeStart = 1151056, XrefRangeEnd = 1151142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool VerifySignature(PKCS7.SignedData sd, Il2CppStructArray<byte> calculatedMessageDigest, HashAlgorithm ha)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(calculatedMessageDigest);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ha);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthenticodeDeformatter.NativeMethodInfoPtr_VerifySignature_Private_Boolean_SignedData_Il2CppStructArray_1_Byte_HashAlgorithm_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000376 RID: 886 RVA: 0x000113B4 File Offset: 0x0000F5B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1151228, RefRangeEnd = 1151229, XrefRangeStart = 1151143, XrefRangeEnd = 1151228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool VerifyCounterSignature(PKCS7.SignerInfo cs, Il2CppStructArray<byte> signature)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cs);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(signature);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthenticodeDeformatter.NativeMethodInfoPtr_VerifyCounterSignature_Private_Boolean_SignerInfo_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000377 RID: 887 RVA: 0x00011414 File Offset: 0x0000F614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151229, XrefRangeEnd = 1151241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthenticodeDeformatter.NativeMethodInfoPtr_Reset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000378 RID: 888 RVA: 0x000037B2 File Offset: 0x000019B2
		public AuthenticodeDeformatter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000379 RID: 889 RVA: 0x00011448 File Offset: 0x0000F648
		// (set) Token: 0x0600037A RID: 890 RVA: 0x000037BB File Offset: 0x000019BB
		public unsafe string filename
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthenticodeDeformatter.NativeFieldInfoPtr_filename);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthenticodeDeformatter.NativeFieldInfoPtr_filename), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x0600037B RID: 891 RVA: 0x00011470 File Offset: 0x0000F670
		// (set) Token: 0x0600037C RID: 892 RVA: 0x000037DA File Offset: 0x000019DA
		public unsafe Il2CppStructArray<byte> rawdata
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthenticodeDeformatter.NativeFieldInfoPtr_rawdata);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthenticodeDeformatter.NativeFieldInfoPtr_rawdata), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x0600037D RID: 893 RVA: 0x000114A0 File Offset: 0x0000F6A0
		// (set) Token: 0x0600037E RID: 894 RVA: 0x000037F9 File Offset: 0x000019F9
		public unsafe Il2CppStructArray<byte> hash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthenticodeDeformatter.NativeFieldInfoPtr_hash);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthenticodeDeformatter.NativeFieldInfoPtr_hash), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x0600037F RID: 895 RVA: 0x000114D0 File Offset: 0x0000F6D0
		// (set) Token: 0x06000380 RID: 896 RVA: 0x00003818 File Offset: 0x00001A18
		public unsafe X509CertificateCollection coll
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthenticodeDeformatter.NativeFieldInfoPtr_coll);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509CertificateCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthenticodeDeformatter.NativeFieldInfoPtr_coll), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000381 RID: 897 RVA: 0x00011500 File Offset: 0x0000F700
		// (set) Token: 0x06000382 RID: 898 RVA: 0x00003837 File Offset: 0x00001A37
		public unsafe ASN1 signedHash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthenticodeDeformatter.NativeFieldInfoPtr_signedHash);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ASN1>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthenticodeDeformatter.NativeFieldInfoPtr_signedHash), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000383 RID: 899 RVA: 0x00011530 File Offset: 0x0000F730
		// (set) Token: 0x06000384 RID: 900 RVA: 0x00003856 File Offset: 0x00001A56
		public unsafe DateTime timestamp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthenticodeDeformatter.NativeFieldInfoPtr_timestamp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthenticodeDeformatter.NativeFieldInfoPtr_timestamp)) = value;
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000385 RID: 901 RVA: 0x00011558 File Offset: 0x0000F758
		// (set) Token: 0x06000386 RID: 902 RVA: 0x00003871 File Offset: 0x00001A71
		public unsafe X509Certificate signingCertificate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthenticodeDeformatter.NativeFieldInfoPtr_signingCertificate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509Certificate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthenticodeDeformatter.NativeFieldInfoPtr_signingCertificate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000387 RID: 903 RVA: 0x00011588 File Offset: 0x0000F788
		// (set) Token: 0x06000388 RID: 904 RVA: 0x00003890 File Offset: 0x00001A90
		public unsafe int reason
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthenticodeDeformatter.NativeFieldInfoPtr_reason);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthenticodeDeformatter.NativeFieldInfoPtr_reason)) = value;
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000389 RID: 905 RVA: 0x000115B0 File Offset: 0x0000F7B0
		// (set) Token: 0x0600038A RID: 906 RVA: 0x000038AB File Offset: 0x00001AAB
		public unsafe bool trustedRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthenticodeDeformatter.NativeFieldInfoPtr_trustedRoot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthenticodeDeformatter.NativeFieldInfoPtr_trustedRoot)) = value;
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x0600038B RID: 907 RVA: 0x000115D8 File Offset: 0x0000F7D8
		// (set) Token: 0x0600038C RID: 908 RVA: 0x000038C6 File Offset: 0x00001AC6
		public unsafe bool trustedTimestampRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthenticodeDeformatter.NativeFieldInfoPtr_trustedTimestampRoot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthenticodeDeformatter.NativeFieldInfoPtr_trustedTimestampRoot)) = value;
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x0600038D RID: 909 RVA: 0x00011600 File Offset: 0x0000F800
		// (set) Token: 0x0600038E RID: 910 RVA: 0x000038E1 File Offset: 0x00001AE1
		public unsafe Il2CppStructArray<byte> entry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthenticodeDeformatter.NativeFieldInfoPtr_entry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthenticodeDeformatter.NativeFieldInfoPtr_entry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x0600038F RID: 911 RVA: 0x00011630 File Offset: 0x0000F830
		// (set) Token: 0x06000390 RID: 912 RVA: 0x00003900 File Offset: 0x00001B00
		public unsafe X509Chain signerChain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthenticodeDeformatter.NativeFieldInfoPtr_signerChain);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509Chain>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthenticodeDeformatter.NativeFieldInfoPtr_signerChain), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000391 RID: 913 RVA: 0x00011660 File Offset: 0x0000F860
		// (set) Token: 0x06000392 RID: 914 RVA: 0x0000391F File Offset: 0x00001B1F
		public unsafe X509Chain timestampChain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthenticodeDeformatter.NativeFieldInfoPtr_timestampChain);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509Chain>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthenticodeDeformatter.NativeFieldInfoPtr_timestampChain), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400039C RID: 924
		private static readonly IntPtr NativeFieldInfoPtr_filename;

		// Token: 0x0400039D RID: 925
		private static readonly IntPtr NativeFieldInfoPtr_rawdata;

		// Token: 0x0400039E RID: 926
		private static readonly IntPtr NativeFieldInfoPtr_hash;

		// Token: 0x0400039F RID: 927
		private static readonly IntPtr NativeFieldInfoPtr_coll;

		// Token: 0x040003A0 RID: 928
		private static readonly IntPtr NativeFieldInfoPtr_signedHash;

		// Token: 0x040003A1 RID: 929
		private static readonly IntPtr NativeFieldInfoPtr_timestamp;

		// Token: 0x040003A2 RID: 930
		private static readonly IntPtr NativeFieldInfoPtr_signingCertificate;

		// Token: 0x040003A3 RID: 931
		private static readonly IntPtr NativeFieldInfoPtr_reason;

		// Token: 0x040003A4 RID: 932
		private static readonly IntPtr NativeFieldInfoPtr_trustedRoot;

		// Token: 0x040003A5 RID: 933
		private static readonly IntPtr NativeFieldInfoPtr_trustedTimestampRoot;

		// Token: 0x040003A6 RID: 934
		private static readonly IntPtr NativeFieldInfoPtr_entry;

		// Token: 0x040003A7 RID: 935
		private static readonly IntPtr NativeFieldInfoPtr_signerChain;

		// Token: 0x040003A8 RID: 936
		private static readonly IntPtr NativeFieldInfoPtr_timestampChain;

		// Token: 0x040003A9 RID: 937
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040003AA RID: 938
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x040003AB RID: 939
		private static readonly IntPtr NativeMethodInfoPtr_set_RawData_Public_set_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x040003AC RID: 940
		private static readonly IntPtr NativeMethodInfoPtr_get_SigningCertificate_Public_get_X509Certificate_0;

		// Token: 0x040003AD RID: 941
		private static readonly IntPtr NativeMethodInfoPtr_CheckSignature_Private_Boolean_0;

		// Token: 0x040003AE RID: 942
		private static readonly IntPtr NativeMethodInfoPtr_CompareIssuerSerial_Private_Boolean_String_Il2CppStructArray_1_Byte_X509Certificate_0;

		// Token: 0x040003AF RID: 943
		private static readonly IntPtr NativeMethodInfoPtr_VerifySignature_Private_Boolean_SignedData_Il2CppStructArray_1_Byte_HashAlgorithm_0;

		// Token: 0x040003B0 RID: 944
		private static readonly IntPtr NativeMethodInfoPtr_VerifyCounterSignature_Private_Boolean_SignerInfo_Il2CppStructArray_1_Byte_0;

		// Token: 0x040003B1 RID: 945
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Private_Void_0;
	}
}
