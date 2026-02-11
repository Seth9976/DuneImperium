using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Security.Cryptography;
using Il2CppSystem.Security.Cryptography.X509Certificates;

namespace Internal.Cryptography.Pal
{
	// Token: 0x02000053 RID: 83
	public sealed class CertificateData : ValueType
	{
		// Token: 0x060004BF RID: 1215 RVA: 0x0002E54C File Offset: 0x0002C74C
		// Note: this type is marked as 'beforefieldinit'.
		static CertificateData()
		{
			Il2CppClassPointerStore<CertificateData>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Internal.Cryptography.Pal", "CertificateData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CertificateData>.NativeClassPtr);
			CertificateData.NativeFieldInfoPtr_RawData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CertificateData>.NativeClassPtr, "RawData");
			CertificateData.NativeFieldInfoPtr_SubjectPublicKeyInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CertificateData>.NativeClassPtr, "SubjectPublicKeyInfo");
			CertificateData.NativeFieldInfoPtr_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CertificateData>.NativeClassPtr, "Version");
			CertificateData.NativeFieldInfoPtr_SerialNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CertificateData>.NativeClassPtr, "SerialNumber");
			CertificateData.NativeFieldInfoPtr_TbsSignature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CertificateData>.NativeClassPtr, "TbsSignature");
			CertificateData.NativeFieldInfoPtr_Issuer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CertificateData>.NativeClassPtr, "Issuer");
			CertificateData.NativeFieldInfoPtr_NotBefore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CertificateData>.NativeClassPtr, "NotBefore");
			CertificateData.NativeFieldInfoPtr_NotAfter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CertificateData>.NativeClassPtr, "NotAfter");
			CertificateData.NativeFieldInfoPtr_Subject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CertificateData>.NativeClassPtr, "Subject");
			CertificateData.NativeFieldInfoPtr_PublicKeyAlgorithm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CertificateData>.NativeClassPtr, "PublicKeyAlgorithm");
			CertificateData.NativeFieldInfoPtr_PublicKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CertificateData>.NativeClassPtr, "PublicKey");
			CertificateData.NativeFieldInfoPtr_IssuerUniqueId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CertificateData>.NativeClassPtr, "IssuerUniqueId");
			CertificateData.NativeFieldInfoPtr_SubjectUniqueId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CertificateData>.NativeClassPtr, "SubjectUniqueId");
			CertificateData.NativeFieldInfoPtr_Extensions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CertificateData>.NativeClassPtr, "Extensions");
			CertificateData.NativeFieldInfoPtr_SignatureAlgorithm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CertificateData>.NativeClassPtr, "SignatureAlgorithm");
			CertificateData.NativeFieldInfoPtr_SignatureValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CertificateData>.NativeClassPtr, "SignatureValue");
			CertificateData.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CertificateData>.NativeClassPtr, 100664149);
			CertificateData.NativeMethodInfoPtr_GetNameInfo_Public_String_X509NameType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CertificateData>.NativeClassPtr, 100664150);
			CertificateData.NativeMethodInfoPtr_GetSimpleNameInfo_Private_Static_String_X500DistinguishedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CertificateData>.NativeClassPtr, 100664151);
			CertificateData.NativeMethodInfoPtr_FindAltNameMatch_Private_Static_String_Il2CppStructArray_1_Byte_GeneralNameType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CertificateData>.NativeClassPtr, 100664152);
			CertificateData.NativeMethodInfoPtr_ReadReverseRdns_Private_Static_IEnumerable_1_KeyValuePair_2_String_String_X500DistinguishedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CertificateData>.NativeClassPtr, 100664153);
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x0002E720 File Offset: 0x0002C920
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 433379, RefRangeEnd = 433380, XrefRangeStart = 433212, XrefRangeEnd = 433379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CertificateData(Il2CppStructArray<byte> rawData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CertificateData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rawData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CertificateData.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStructArray_1_Byte_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x0002E770 File Offset: 0x0002C970
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 433449, RefRangeEnd = 433450, XrefRangeStart = 433380, XrefRangeEnd = 433449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetNameInfo(X509NameType nameType, bool forIssuer)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CertificateData.NativeMethodInfoPtr_GetNameInfo_Public_String_X509NameType_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x0002E7C8 File Offset: 0x0002C9C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 433471, RefRangeEnd = 433472, XrefRangeStart = 433450, XrefRangeEnd = 433471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetSimpleNameInfo(X500DistinguishedName name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CertificateData.NativeMethodInfoPtr_GetSimpleNameInfo_Private_Static_String_X500DistinguishedName_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x0002E804 File Offset: 0x0002CA04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 433484, RefRangeEnd = 433485, XrefRangeStart = 433472, XrefRangeEnd = 433484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FindAltNameMatch(Il2CppStructArray<byte> extensionBytes, GeneralNameType matchType, string otherOid)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(extensionBytes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref matchType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(otherOid);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CertificateData.NativeMethodInfoPtr_FindAltNameMatch_Private_Static_String_Il2CppStructArray_1_Byte_GeneralNameType_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x0002E860 File Offset: 0x0002CA60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 433491, RefRangeEnd = 433493, XrefRangeStart = 433485, XrefRangeEnd = 433491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<KeyValuePair<string, string>> ReadReverseRdns(X500DistinguishedName name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CertificateData.NativeMethodInfoPtr_ReadReverseRdns_Private_Static_IEnumerable_1_KeyValuePair_2_String_String_X500DistinguishedName_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<string, string>>>(intPtr3) : null;
			}
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x000037D3 File Offset: 0x000019D3
		public CertificateData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x000037DC File Offset: 0x000019DC
		public CertificateData()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CertificateData>.NativeClassPtr))
		{
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x060004C7 RID: 1223 RVA: 0x0002E8A4 File Offset: 0x0002CAA4
		// (set) Token: 0x060004C8 RID: 1224 RVA: 0x000037EE File Offset: 0x000019EE
		public unsafe Il2CppStructArray<byte> RawData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CertificateData.NativeFieldInfoPtr_RawData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CertificateData.NativeFieldInfoPtr_RawData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x060004C9 RID: 1225 RVA: 0x0002E8D4 File Offset: 0x0002CAD4
		// (set) Token: 0x060004CA RID: 1226 RVA: 0x0000380D File Offset: 0x00001A0D
		public unsafe Il2CppStructArray<byte> SubjectPublicKeyInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CertificateData.NativeFieldInfoPtr_SubjectPublicKeyInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CertificateData.NativeFieldInfoPtr_SubjectPublicKeyInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x060004CB RID: 1227 RVA: 0x0002E904 File Offset: 0x0002CB04
		// (set) Token: 0x060004CC RID: 1228 RVA: 0x0000382C File Offset: 0x00001A2C
		public unsafe int Version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CertificateData.NativeFieldInfoPtr_Version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CertificateData.NativeFieldInfoPtr_Version)) = value;
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x060004CD RID: 1229 RVA: 0x0002E92C File Offset: 0x0002CB2C
		// (set) Token: 0x060004CE RID: 1230 RVA: 0x00003847 File Offset: 0x00001A47
		public unsafe Il2CppStructArray<byte> SerialNumber
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CertificateData.NativeFieldInfoPtr_SerialNumber);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CertificateData.NativeFieldInfoPtr_SerialNumber), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x060004CF RID: 1231 RVA: 0x0002E95C File Offset: 0x0002CB5C
		// (set) Token: 0x060004D0 RID: 1232 RVA: 0x00003866 File Offset: 0x00001A66
		public CertificateData.AlgorithmIdentifier TbsSignature
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CertificateData.NativeFieldInfoPtr_TbsSignature);
				return new CertificateData.AlgorithmIdentifier(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CertificateData.AlgorithmIdentifier>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CertificateData.NativeFieldInfoPtr_TbsSignature), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CertificateData.AlgorithmIdentifier>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x060004D1 RID: 1233 RVA: 0x0002E98C File Offset: 0x0002CB8C
		// (set) Token: 0x060004D2 RID: 1234 RVA: 0x00003894 File Offset: 0x00001A94
		public unsafe X500DistinguishedName Issuer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CertificateData.NativeFieldInfoPtr_Issuer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X500DistinguishedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CertificateData.NativeFieldInfoPtr_Issuer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x060004D3 RID: 1235 RVA: 0x0002E9BC File Offset: 0x0002CBBC
		// (set) Token: 0x060004D4 RID: 1236 RVA: 0x000038B3 File Offset: 0x00001AB3
		public unsafe DateTime NotBefore
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CertificateData.NativeFieldInfoPtr_NotBefore);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CertificateData.NativeFieldInfoPtr_NotBefore)) = value;
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x060004D5 RID: 1237 RVA: 0x0002E9E4 File Offset: 0x0002CBE4
		// (set) Token: 0x060004D6 RID: 1238 RVA: 0x000038CE File Offset: 0x00001ACE
		public unsafe DateTime NotAfter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CertificateData.NativeFieldInfoPtr_NotAfter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CertificateData.NativeFieldInfoPtr_NotAfter)) = value;
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x060004D7 RID: 1239 RVA: 0x0002EA0C File Offset: 0x0002CC0C
		// (set) Token: 0x060004D8 RID: 1240 RVA: 0x000038E9 File Offset: 0x00001AE9
		public unsafe X500DistinguishedName Subject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CertificateData.NativeFieldInfoPtr_Subject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X500DistinguishedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CertificateData.NativeFieldInfoPtr_Subject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x060004D9 RID: 1241 RVA: 0x0002EA3C File Offset: 0x0002CC3C
		// (set) Token: 0x060004DA RID: 1242 RVA: 0x00003908 File Offset: 0x00001B08
		public CertificateData.AlgorithmIdentifier PublicKeyAlgorithm
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CertificateData.NativeFieldInfoPtr_PublicKeyAlgorithm);
				return new CertificateData.AlgorithmIdentifier(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CertificateData.AlgorithmIdentifier>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CertificateData.NativeFieldInfoPtr_PublicKeyAlgorithm), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CertificateData.AlgorithmIdentifier>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x060004DB RID: 1243 RVA: 0x0002EA6C File Offset: 0x0002CC6C
		// (set) Token: 0x060004DC RID: 1244 RVA: 0x00003936 File Offset: 0x00001B36
		public unsafe Il2CppStructArray<byte> PublicKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CertificateData.NativeFieldInfoPtr_PublicKey);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CertificateData.NativeFieldInfoPtr_PublicKey), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x060004DD RID: 1245 RVA: 0x0002EA9C File Offset: 0x0002CC9C
		// (set) Token: 0x060004DE RID: 1246 RVA: 0x00003955 File Offset: 0x00001B55
		public unsafe Il2CppStructArray<byte> IssuerUniqueId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CertificateData.NativeFieldInfoPtr_IssuerUniqueId);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CertificateData.NativeFieldInfoPtr_IssuerUniqueId), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x060004DF RID: 1247 RVA: 0x0002EACC File Offset: 0x0002CCCC
		// (set) Token: 0x060004E0 RID: 1248 RVA: 0x00003974 File Offset: 0x00001B74
		public unsafe Il2CppStructArray<byte> SubjectUniqueId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CertificateData.NativeFieldInfoPtr_SubjectUniqueId);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CertificateData.NativeFieldInfoPtr_SubjectUniqueId), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x060004E1 RID: 1249 RVA: 0x0002EAFC File Offset: 0x0002CCFC
		// (set) Token: 0x060004E2 RID: 1250 RVA: 0x00003993 File Offset: 0x00001B93
		public unsafe List<X509Extension> Extensions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CertificateData.NativeFieldInfoPtr_Extensions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<X509Extension>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CertificateData.NativeFieldInfoPtr_Extensions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x060004E3 RID: 1251 RVA: 0x0002EB2C File Offset: 0x0002CD2C
		// (set) Token: 0x060004E4 RID: 1252 RVA: 0x000039B2 File Offset: 0x00001BB2
		public CertificateData.AlgorithmIdentifier SignatureAlgorithm
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CertificateData.NativeFieldInfoPtr_SignatureAlgorithm);
				return new CertificateData.AlgorithmIdentifier(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CertificateData.AlgorithmIdentifier>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CertificateData.NativeFieldInfoPtr_SignatureAlgorithm), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CertificateData.AlgorithmIdentifier>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x060004E5 RID: 1253 RVA: 0x0002EB5C File Offset: 0x0002CD5C
		// (set) Token: 0x060004E6 RID: 1254 RVA: 0x000039E0 File Offset: 0x00001BE0
		public unsafe Il2CppStructArray<byte> SignatureValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CertificateData.NativeFieldInfoPtr_SignatureValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CertificateData.NativeFieldInfoPtr_SignatureValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000400 RID: 1024
		private static readonly IntPtr NativeFieldInfoPtr_RawData;

		// Token: 0x04000401 RID: 1025
		private static readonly IntPtr NativeFieldInfoPtr_SubjectPublicKeyInfo;

		// Token: 0x04000402 RID: 1026
		private static readonly IntPtr NativeFieldInfoPtr_Version;

		// Token: 0x04000403 RID: 1027
		private static readonly IntPtr NativeFieldInfoPtr_SerialNumber;

		// Token: 0x04000404 RID: 1028
		private static readonly IntPtr NativeFieldInfoPtr_TbsSignature;

		// Token: 0x04000405 RID: 1029
		private static readonly IntPtr NativeFieldInfoPtr_Issuer;

		// Token: 0x04000406 RID: 1030
		private static readonly IntPtr NativeFieldInfoPtr_NotBefore;

		// Token: 0x04000407 RID: 1031
		private static readonly IntPtr NativeFieldInfoPtr_NotAfter;

		// Token: 0x04000408 RID: 1032
		private static readonly IntPtr NativeFieldInfoPtr_Subject;

		// Token: 0x04000409 RID: 1033
		private static readonly IntPtr NativeFieldInfoPtr_PublicKeyAlgorithm;

		// Token: 0x0400040A RID: 1034
		private static readonly IntPtr NativeFieldInfoPtr_PublicKey;

		// Token: 0x0400040B RID: 1035
		private static readonly IntPtr NativeFieldInfoPtr_IssuerUniqueId;

		// Token: 0x0400040C RID: 1036
		private static readonly IntPtr NativeFieldInfoPtr_SubjectUniqueId;

		// Token: 0x0400040D RID: 1037
		private static readonly IntPtr NativeFieldInfoPtr_Extensions;

		// Token: 0x0400040E RID: 1038
		private static readonly IntPtr NativeFieldInfoPtr_SignatureAlgorithm;

		// Token: 0x0400040F RID: 1039
		private static readonly IntPtr NativeFieldInfoPtr_SignatureValue;

		// Token: 0x04000410 RID: 1040
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000411 RID: 1041
		private static readonly IntPtr NativeMethodInfoPtr_GetNameInfo_Public_String_X509NameType_Boolean_0;

		// Token: 0x04000412 RID: 1042
		private static readonly IntPtr NativeMethodInfoPtr_GetSimpleNameInfo_Private_Static_String_X500DistinguishedName_0;

		// Token: 0x04000413 RID: 1043
		private static readonly IntPtr NativeMethodInfoPtr_FindAltNameMatch_Private_Static_String_Il2CppStructArray_1_Byte_GeneralNameType_String_0;

		// Token: 0x04000414 RID: 1044
		private static readonly IntPtr NativeMethodInfoPtr_ReadReverseRdns_Private_Static_IEnumerable_1_KeyValuePair_2_String_String_X500DistinguishedName_0;

		// Token: 0x020002BF RID: 703
		public sealed class AlgorithmIdentifier : ValueType
		{
			// Token: 0x06002B37 RID: 11063 RVA: 0x000BFF74 File Offset: 0x000BE174
			// Note: this type is marked as 'beforefieldinit'.
			static AlgorithmIdentifier()
			{
				Il2CppClassPointerStore<CertificateData.AlgorithmIdentifier>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CertificateData>.NativeClassPtr, "AlgorithmIdentifier");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CertificateData.AlgorithmIdentifier>.NativeClassPtr);
				CertificateData.AlgorithmIdentifier.NativeFieldInfoPtr_AlgorithmId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CertificateData.AlgorithmIdentifier>.NativeClassPtr, "AlgorithmId");
				CertificateData.AlgorithmIdentifier.NativeFieldInfoPtr_Parameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CertificateData.AlgorithmIdentifier>.NativeClassPtr, "Parameters");
			}

			// Token: 0x06002B38 RID: 11064 RVA: 0x0001359D File Offset: 0x0001179D
			public AlgorithmIdentifier(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002B39 RID: 11065 RVA: 0x000135A6 File Offset: 0x000117A6
			public AlgorithmIdentifier()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CertificateData.AlgorithmIdentifier>.NativeClassPtr))
			{
			}

			// Token: 0x17000D8F RID: 3471
			// (get) Token: 0x06002B3A RID: 11066 RVA: 0x000BFFC8 File Offset: 0x000BE1C8
			// (set) Token: 0x06002B3B RID: 11067 RVA: 0x000135B8 File Offset: 0x000117B8
			public unsafe string AlgorithmId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CertificateData.AlgorithmIdentifier.NativeFieldInfoPtr_AlgorithmId);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CertificateData.AlgorithmIdentifier.NativeFieldInfoPtr_AlgorithmId), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000D90 RID: 3472
			// (get) Token: 0x06002B3C RID: 11068 RVA: 0x000BFFF0 File Offset: 0x000BE1F0
			// (set) Token: 0x06002B3D RID: 11069 RVA: 0x000135D7 File Offset: 0x000117D7
			public unsafe Il2CppStructArray<byte> Parameters
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CertificateData.AlgorithmIdentifier.NativeFieldInfoPtr_Parameters);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CertificateData.AlgorithmIdentifier.NativeFieldInfoPtr_Parameters), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040021E8 RID: 8680
			private static readonly IntPtr NativeFieldInfoPtr_AlgorithmId;

			// Token: 0x040021E9 RID: 8681
			private static readonly IntPtr NativeFieldInfoPtr_Parameters;
		}

		// Token: 0x020002C0 RID: 704
		[ObfuscatedName("Internal.Cryptography.Pal.CertificateData+<ReadReverseRdns>d__21")]
		public sealed class _ReadReverseRdns_d__21 : Object
		{
			// Token: 0x06002B3E RID: 11070 RVA: 0x000C0020 File Offset: 0x000BE220
			// Note: this type is marked as 'beforefieldinit'.
			static _ReadReverseRdns_d__21()
			{
				Il2CppClassPointerStore<CertificateData._ReadReverseRdns_d__21>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CertificateData>.NativeClassPtr, "<ReadReverseRdns>d__21");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CertificateData._ReadReverseRdns_d__21>.NativeClassPtr);
				CertificateData._ReadReverseRdns_d__21.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CertificateData._ReadReverseRdns_d__21>.NativeClassPtr, "<>1__state");
				CertificateData._ReadReverseRdns_d__21.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CertificateData._ReadReverseRdns_d__21>.NativeClassPtr, "<>2__current");
				CertificateData._ReadReverseRdns_d__21.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CertificateData._ReadReverseRdns_d__21>.NativeClassPtr, "<>l__initialThreadId");
				CertificateData._ReadReverseRdns_d__21.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CertificateData._ReadReverseRdns_d__21>.NativeClassPtr, "name");
				CertificateData._ReadReverseRdns_d__21.NativeFieldInfoPtr___3__name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CertificateData._ReadReverseRdns_d__21>.NativeClassPtr, "<>3__name");
				CertificateData._ReadReverseRdns_d__21.NativeFieldInfoPtr__rdnReaders_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CertificateData._ReadReverseRdns_d__21>.NativeClassPtr, "<rdnReaders>5__2");
				CertificateData._ReadReverseRdns_d__21.NativeFieldInfoPtr__rdnReader_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CertificateData._ReadReverseRdns_d__21>.NativeClassPtr, "<rdnReader>5__3");
				CertificateData._ReadReverseRdns_d__21.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CertificateData._ReadReverseRdns_d__21>.NativeClassPtr, 100664154);
				CertificateData._ReadReverseRdns_d__21.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CertificateData._ReadReverseRdns_d__21>.NativeClassPtr, 100664155);
				CertificateData._ReadReverseRdns_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CertificateData._ReadReverseRdns_d__21>.NativeClassPtr, 100664156);
				CertificateData._ReadReverseRdns_d__21.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_KeyValuePair_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CertificateData._ReadReverseRdns_d__21>.NativeClassPtr, 100664157);
				CertificateData._ReadReverseRdns_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CertificateData._ReadReverseRdns_d__21>.NativeClassPtr, 100664158);
				CertificateData._ReadReverseRdns_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CertificateData._ReadReverseRdns_d__21>.NativeClassPtr, 100664159);
				CertificateData._ReadReverseRdns_d__21.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CertificateData._ReadReverseRdns_d__21>.NativeClassPtr, 100664160);
				CertificateData._ReadReverseRdns_d__21.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CertificateData._ReadReverseRdns_d__21>.NativeClassPtr, 100664161);
			}

			// Token: 0x06002B3F RID: 11071 RVA: 0x000C0178 File Offset: 0x000BE378
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 26131, RefRangeEnd = 26152, XrefRangeStart = 26131, XrefRangeEnd = 26152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ReadReverseRdns_d__21(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CertificateData._ReadReverseRdns_d__21>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CertificateData._ReadReverseRdns_d__21.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002B40 RID: 11072 RVA: 0x000C01C0 File Offset: 0x000BE3C0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CertificateData._ReadReverseRdns_d__21.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002B41 RID: 11073 RVA: 0x000C01F4 File Offset: 0x000BE3F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 433154, XrefRangeEnd = 433196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CertificateData._ReadReverseRdns_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000D98 RID: 3480
			// (get) Token: 0x06002B42 RID: 11074 RVA: 0x000C0230 File Offset: 0x000BE430
			public unsafe KeyValuePair<string, string> prop_KeyValuePair_2_String_String_0
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CertificateData._ReadReverseRdns_d__21.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_KeyValuePair_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new KeyValuePair<string, string>(intPtr);
				}
			}

			// Token: 0x06002B43 RID: 11075 RVA: 0x000C0268 File Offset: 0x000BE468
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 433196, XrefRangeEnd = 433201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CertificateData._ReadReverseRdns_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000D99 RID: 3481
			// (get) Token: 0x06002B44 RID: 11076 RVA: 0x000C029C File Offset: 0x000BE49C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 433201, XrefRangeEnd = 433204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CertificateData._ReadReverseRdns_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002B45 RID: 11077 RVA: 0x000C02DC File Offset: 0x000BE4DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 433204, XrefRangeEnd = 433212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<KeyValuePair<string, string>> Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_String_String_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CertificateData._ReadReverseRdns_d__21.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<KeyValuePair<string, string>>>(intPtr3) : null;
			}

			// Token: 0x06002B46 RID: 11078 RVA: 0x000C031C File Offset: 0x000BE51C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CertificateData._ReadReverseRdns_d__21.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06002B47 RID: 11079 RVA: 0x000135F6 File Offset: 0x000117F6
			public _ReadReverseRdns_d__21(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D91 RID: 3473
			// (get) Token: 0x06002B48 RID: 11080 RVA: 0x000C035C File Offset: 0x000BE55C
			// (set) Token: 0x06002B49 RID: 11081 RVA: 0x000135FF File Offset: 0x000117FF
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CertificateData._ReadReverseRdns_d__21.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CertificateData._ReadReverseRdns_d__21.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000D92 RID: 3474
			// (get) Token: 0x06002B4A RID: 11082 RVA: 0x000C0384 File Offset: 0x000BE584
			// (set) Token: 0x06002B4B RID: 11083 RVA: 0x0001361A File Offset: 0x0001181A
			public KeyValuePair<string, string> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CertificateData._ReadReverseRdns_d__21.NativeFieldInfoPtr___2__current);
					return new KeyValuePair<string, string>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KeyValuePair<string, string>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CertificateData._ReadReverseRdns_d__21.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<KeyValuePair<string, string>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000D93 RID: 3475
			// (get) Token: 0x06002B4C RID: 11084 RVA: 0x000C03B4 File Offset: 0x000BE5B4
			// (set) Token: 0x06002B4D RID: 11085 RVA: 0x00013648 File Offset: 0x00011848
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CertificateData._ReadReverseRdns_d__21.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CertificateData._ReadReverseRdns_d__21.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000D94 RID: 3476
			// (get) Token: 0x06002B4E RID: 11086 RVA: 0x000C03DC File Offset: 0x000BE5DC
			// (set) Token: 0x06002B4F RID: 11087 RVA: 0x00013663 File Offset: 0x00011863
			public unsafe X500DistinguishedName name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CertificateData._ReadReverseRdns_d__21.NativeFieldInfoPtr_name);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<X500DistinguishedName>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CertificateData._ReadReverseRdns_d__21.NativeFieldInfoPtr_name), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D95 RID: 3477
			// (get) Token: 0x06002B50 RID: 11088 RVA: 0x000C040C File Offset: 0x000BE60C
			// (set) Token: 0x06002B51 RID: 11089 RVA: 0x00013682 File Offset: 0x00011882
			public unsafe X500DistinguishedName __3__name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CertificateData._ReadReverseRdns_d__21.NativeFieldInfoPtr___3__name);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<X500DistinguishedName>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CertificateData._ReadReverseRdns_d__21.NativeFieldInfoPtr___3__name), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D96 RID: 3478
			// (get) Token: 0x06002B52 RID: 11090 RVA: 0x000C043C File Offset: 0x000BE63C
			// (set) Token: 0x06002B53 RID: 11091 RVA: 0x000136A1 File Offset: 0x000118A1
			public unsafe Stack<DerSequenceReader> _rdnReaders_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CertificateData._ReadReverseRdns_d__21.NativeFieldInfoPtr__rdnReaders_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<DerSequenceReader>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CertificateData._ReadReverseRdns_d__21.NativeFieldInfoPtr__rdnReaders_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D97 RID: 3479
			// (get) Token: 0x06002B54 RID: 11092 RVA: 0x000C046C File Offset: 0x000BE66C
			// (set) Token: 0x06002B55 RID: 11093 RVA: 0x000136C0 File Offset: 0x000118C0
			public unsafe DerSequenceReader _rdnReader_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CertificateData._ReadReverseRdns_d__21.NativeFieldInfoPtr__rdnReader_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DerSequenceReader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CertificateData._ReadReverseRdns_d__21.NativeFieldInfoPtr__rdnReader_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040021EA RID: 8682
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040021EB RID: 8683
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040021EC RID: 8684
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040021ED RID: 8685
			private static readonly IntPtr NativeFieldInfoPtr_name;

			// Token: 0x040021EE RID: 8686
			private static readonly IntPtr NativeFieldInfoPtr___3__name;

			// Token: 0x040021EF RID: 8687
			private static readonly IntPtr NativeFieldInfoPtr__rdnReaders_5__2;

			// Token: 0x040021F0 RID: 8688
			private static readonly IntPtr NativeFieldInfoPtr__rdnReader_5__3;

			// Token: 0x040021F1 RID: 8689
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040021F2 RID: 8690
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040021F3 RID: 8691
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040021F4 RID: 8692
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_KeyValuePair_2_String_String_0;

			// Token: 0x040021F5 RID: 8693
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040021F6 RID: 8694
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040021F7 RID: 8695
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_String_String_0;

			// Token: 0x040021F8 RID: 8696
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
