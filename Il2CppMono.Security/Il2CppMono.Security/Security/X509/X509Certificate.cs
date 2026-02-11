using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Runtime.Serialization;
using Il2CppSystem.Security.Cryptography;

namespace Il2CppMono.Security.X509
{
	// Token: 0x0200000B RID: 11
	public class X509Certificate : Object
	{
		// Token: 0x060000C5 RID: 197 RVA: 0x000076C0 File Offset: 0x000058C0
		// Note: this type is marked as 'beforefieldinit'.
		static X509Certificate()
		{
			Il2CppClassPointerStore<X509Certificate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.X509", "X509Certificate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr);
			X509Certificate.NativeFieldInfoPtr_decoder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, "decoder");
			X509Certificate.NativeFieldInfoPtr_m_encodedcert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, "m_encodedcert");
			X509Certificate.NativeFieldInfoPtr_m_from = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, "m_from");
			X509Certificate.NativeFieldInfoPtr_m_until = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, "m_until");
			X509Certificate.NativeFieldInfoPtr_issuer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, "issuer");
			X509Certificate.NativeFieldInfoPtr_m_issuername = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, "m_issuername");
			X509Certificate.NativeFieldInfoPtr_m_keyalgo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, "m_keyalgo");
			X509Certificate.NativeFieldInfoPtr_m_keyalgoparams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, "m_keyalgoparams");
			X509Certificate.NativeFieldInfoPtr_subject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, "subject");
			X509Certificate.NativeFieldInfoPtr_m_subject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, "m_subject");
			X509Certificate.NativeFieldInfoPtr_m_publickey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, "m_publickey");
			X509Certificate.NativeFieldInfoPtr_signature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, "signature");
			X509Certificate.NativeFieldInfoPtr_m_signaturealgo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, "m_signaturealgo");
			X509Certificate.NativeFieldInfoPtr_m_signaturealgoparams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, "m_signaturealgoparams");
			X509Certificate.NativeFieldInfoPtr_certhash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, "certhash");
			X509Certificate.NativeFieldInfoPtr__rsa = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, "_rsa");
			X509Certificate.NativeFieldInfoPtr__dsa = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, "_dsa");
			X509Certificate.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, "version");
			X509Certificate.NativeFieldInfoPtr_serialnumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, "serialnumber");
			X509Certificate.NativeFieldInfoPtr_issuerUniqueID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, "issuerUniqueID");
			X509Certificate.NativeFieldInfoPtr_subjectUniqueID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, "subjectUniqueID");
			X509Certificate.NativeFieldInfoPtr_extensions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, "extensions");
			X509Certificate.NativeFieldInfoPtr_encoding_error = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, "encoding_error");
			X509Certificate.NativeMethodInfoPtr_Parse_Private_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100663437);
			X509Certificate.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100663438);
			X509Certificate.NativeMethodInfoPtr_GetUnsignedBigInteger_Private_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100663439);
			X509Certificate.NativeMethodInfoPtr_get_DSA_Public_get_DSA_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100663440);
			X509Certificate.NativeMethodInfoPtr_set_DSA_Public_set_Void_DSA_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100663441);
			X509Certificate.NativeMethodInfoPtr_get_Extensions_Public_get_X509ExtensionCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100663442);
			X509Certificate.NativeMethodInfoPtr_get_Hash_Public_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100663443);
			X509Certificate.NativeMethodInfoPtr_get_IssuerName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100663444);
			X509Certificate.NativeMethodInfoPtr_get_KeyAlgorithm_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100663445);
			X509Certificate.NativeMethodInfoPtr_get_KeyAlgorithmParameters_Public_Virtual_New_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100663446);
			X509Certificate.NativeMethodInfoPtr_set_KeyAlgorithmParameters_Public_Virtual_New_set_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100663447);
			X509Certificate.NativeMethodInfoPtr_get_PublicKey_Public_Virtual_New_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100663448);
			X509Certificate.NativeMethodInfoPtr_get_RSA_Public_Virtual_New_get_RSA_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100663449);
			X509Certificate.NativeMethodInfoPtr_set_RSA_Public_Virtual_New_set_Void_RSA_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100663450);
			X509Certificate.NativeMethodInfoPtr_get_RawData_Public_Virtual_New_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100663451);
			X509Certificate.NativeMethodInfoPtr_get_SerialNumber_Public_Virtual_New_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100663452);
			X509Certificate.NativeMethodInfoPtr_get_Signature_Public_Virtual_New_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100663453);
			X509Certificate.NativeMethodInfoPtr_get_SubjectName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100663454);
			X509Certificate.NativeMethodInfoPtr_get_ValidFrom_Public_Virtual_New_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100663455);
			X509Certificate.NativeMethodInfoPtr_get_ValidUntil_Public_Virtual_New_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100663456);
			X509Certificate.NativeMethodInfoPtr_get_Version_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100663457);
			X509Certificate.NativeMethodInfoPtr_get_IsCurrent_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100663458);
			X509Certificate.NativeMethodInfoPtr_WasCurrent_Public_Boolean_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100663459);
			X509Certificate.NativeMethodInfoPtr_VerifySignature_Internal_Boolean_DSA_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100663460);
			X509Certificate.NativeMethodInfoPtr_VerifySignature_Internal_Boolean_RSA_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100663461);
			X509Certificate.NativeMethodInfoPtr_VerifySignature_Public_Boolean_AsymmetricAlgorithm_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100663462);
			X509Certificate.NativeMethodInfoPtr_get_IsSelfSigned_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100663463);
			X509Certificate.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100663464);
			X509Certificate.NativeMethodInfoPtr_PEM_Private_Static_Il2CppStructArray_1_Byte_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100663465);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00007B00 File Offset: 0x00005D00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1147466, RefRangeEnd = 1147467, XrefRangeStart = 1147376, XrefRangeEnd = 1147466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Parse(Il2CppStructArray<byte> data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate.NativeMethodInfoPtr_Parse_Private_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00007B44 File Offset: 0x00005D44
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1147488, RefRangeEnd = 1147497, XrefRangeStart = 1147467, XrefRangeEnd = 1147488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509Certificate(Il2CppStructArray<byte> data)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00007B90 File Offset: 0x00005D90
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1147498, RefRangeEnd = 1147503, XrefRangeStart = 1147497, XrefRangeEnd = 1147498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> GetUnsignedBigInteger(Il2CppStructArray<byte> integer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(integer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate.NativeMethodInfoPtr_GetUnsignedBigInteger_Private_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x00007BE0 File Offset: 0x00005DE0
		// (set) Token: 0x060000CA RID: 202 RVA: 0x00007C20 File Offset: 0x00005E20
		public unsafe DSA DSA
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 1147536, RefRangeEnd = 1147543, XrefRangeStart = 1147503, XrefRangeEnd = 1147536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate.NativeMethodInfoPtr_get_DSA_Public_get_DSA_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DSA>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1147545, RefRangeEnd = 1147548, XrefRangeStart = 1147543, XrefRangeEnd = 1147545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate.NativeMethodInfoPtr_set_DSA_Public_set_Void_DSA_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060000CB RID: 203 RVA: 0x00007C64 File Offset: 0x00005E64
		public unsafe X509ExtensionCollection Extensions
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate.NativeMethodInfoPtr_get_Extensions_Public_get_X509ExtensionCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509ExtensionCollection>(intPtr3) : null;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060000CC RID: 204 RVA: 0x00007CA4 File Offset: 0x00005EA4
		public unsafe Il2CppStructArray<byte> Hash
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1147568, RefRangeEnd = 1147572, XrefRangeStart = 1147548, XrefRangeEnd = 1147568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate.NativeMethodInfoPtr_get_Hash_Public_get_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060000CD RID: 205 RVA: 0x00007CE4 File Offset: 0x00005EE4
		public unsafe virtual string IssuerName
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate.NativeMethodInfoPtr_get_IssuerName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060000CE RID: 206 RVA: 0x00007D28 File Offset: 0x00005F28
		public unsafe virtual string KeyAlgorithm
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate.NativeMethodInfoPtr_get_KeyAlgorithm_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060000CF RID: 207 RVA: 0x00007D6C File Offset: 0x00005F6C
		// (set) Token: 0x060000D0 RID: 208 RVA: 0x00007DB8 File Offset: 0x00005FB8
		public unsafe virtual Il2CppStructArray<byte> KeyAlgorithmParameters
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1147572, XrefRangeEnd = 1147575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate.NativeMethodInfoPtr_get_KeyAlgorithmParameters_Public_Virtual_New_get_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate.NativeMethodInfoPtr_set_KeyAlgorithmParameters_Public_Virtual_New_set_Void_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x00007E08 File Offset: 0x00006008
		public unsafe virtual Il2CppStructArray<byte> PublicKey
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1147575, XrefRangeEnd = 1147578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate.NativeMethodInfoPtr_get_PublicKey_Public_Virtual_New_get_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x00007E54 File Offset: 0x00006054
		// (set) Token: 0x060000D3 RID: 211 RVA: 0x00007EA0 File Offset: 0x000060A0
		public unsafe virtual RSA RSA
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1147578, XrefRangeEnd = 1147597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate.NativeMethodInfoPtr_get_RSA_Public_Virtual_New_get_RSA_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RSA>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1147597, XrefRangeEnd = 1147599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate.NativeMethodInfoPtr_set_RSA_Public_Virtual_New_set_Void_RSA_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x00007EF0 File Offset: 0x000060F0
		public unsafe virtual Il2CppStructArray<byte> RawData
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1147599, XrefRangeEnd = 1147602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate.NativeMethodInfoPtr_get_RawData_Public_Virtual_New_get_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x00007F3C File Offset: 0x0000613C
		public unsafe virtual Il2CppStructArray<byte> SerialNumber
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1147602, XrefRangeEnd = 1147605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate.NativeMethodInfoPtr_get_SerialNumber_Public_Virtual_New_get_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x00007F88 File Offset: 0x00006188
		public unsafe virtual Il2CppStructArray<byte> Signature
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1147605, XrefRangeEnd = 1147663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate.NativeMethodInfoPtr_get_Signature_Public_Virtual_New_get_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x00007FD4 File Offset: 0x000061D4
		public unsafe virtual string SubjectName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate.NativeMethodInfoPtr_get_SubjectName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x00008018 File Offset: 0x00006218
		public unsafe virtual DateTime ValidFrom
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate.NativeMethodInfoPtr_get_ValidFrom_Public_Virtual_New_get_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x00008060 File Offset: 0x00006260
		public unsafe virtual DateTime ValidUntil
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate.NativeMethodInfoPtr_get_ValidUntil_Public_Virtual_New_get_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060000DA RID: 218 RVA: 0x000080A8 File Offset: 0x000062A8
		public unsafe int Version
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate.NativeMethodInfoPtr_get_Version_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060000DB RID: 219 RVA: 0x000080E4 File Offset: 0x000062E4
		public unsafe bool IsCurrent
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1147663, XrefRangeEnd = 1147671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate.NativeMethodInfoPtr_get_IsCurrent_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00008120 File Offset: 0x00006320
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1147671, XrefRangeEnd = 1147675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool WasCurrent(DateTime instant)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref instant;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate.NativeMethodInfoPtr_WasCurrent_Public_Boolean_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000DD RID: 221 RVA: 0x0000816C File Offset: 0x0000636C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1147683, RefRangeEnd = 1147685, XrefRangeStart = 1147675, XrefRangeEnd = 1147683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool VerifySignature(DSA dsa)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dsa);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate.NativeMethodInfoPtr_VerifySignature_Internal_Boolean_DSA_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000DE RID: 222 RVA: 0x000081BC File Offset: 0x000063BC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1147697, RefRangeEnd = 1147700, XrefRangeStart = 1147685, XrefRangeEnd = 1147697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool VerifySignature(RSA rsa)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rsa);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate.NativeMethodInfoPtr_VerifySignature_Internal_Boolean_RSA_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000DF RID: 223 RVA: 0x0000820C File Offset: 0x0000640C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1147723, RefRangeEnd = 1147725, XrefRangeStart = 1147700, XrefRangeEnd = 1147723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool VerifySignature(AsymmetricAlgorithm aa)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(aa);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate.NativeMethodInfoPtr_VerifySignature_Public_Boolean_AsymmetricAlgorithm_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x0000825C File Offset: 0x0000645C
		public unsafe bool IsSelfSigned
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1147733, RefRangeEnd = 1147734, XrefRangeStart = 1147725, XrefRangeEnd = 1147733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate.NativeMethodInfoPtr_get_IsSelfSigned_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00008298 File Offset: 0x00006498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1147734, XrefRangeEnd = 1147738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x000082FC File Offset: 0x000064FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1147738, XrefRangeEnd = 1147753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> PEM(string type, Il2CppStructArray<byte> data)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate.NativeMethodInfoPtr_PEM_Private_Static_Il2CppStructArray_1_Byte_String_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x000024E9 File Offset: 0x000006E9
		public X509Certificate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x00008354 File Offset: 0x00006554
		// (set) Token: 0x060000E5 RID: 229 RVA: 0x000024F2 File Offset: 0x000006F2
		public unsafe ASN1 decoder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_decoder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ASN1>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_decoder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x00008384 File Offset: 0x00006584
		// (set) Token: 0x060000E7 RID: 231 RVA: 0x00002511 File Offset: 0x00000711
		public unsafe Il2CppStructArray<byte> m_encodedcert
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_m_encodedcert);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_m_encodedcert), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x000083B4 File Offset: 0x000065B4
		// (set) Token: 0x060000E9 RID: 233 RVA: 0x00002530 File Offset: 0x00000730
		public unsafe DateTime m_from
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_m_from);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_m_from)) = value;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000EA RID: 234 RVA: 0x000083DC File Offset: 0x000065DC
		// (set) Token: 0x060000EB RID: 235 RVA: 0x0000254B File Offset: 0x0000074B
		public unsafe DateTime m_until
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_m_until);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_m_until)) = value;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000EC RID: 236 RVA: 0x00008404 File Offset: 0x00006604
		// (set) Token: 0x060000ED RID: 237 RVA: 0x00002566 File Offset: 0x00000766
		public unsafe ASN1 issuer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_issuer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ASN1>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_issuer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000EE RID: 238 RVA: 0x00008434 File Offset: 0x00006634
		// (set) Token: 0x060000EF RID: 239 RVA: 0x00002585 File Offset: 0x00000785
		public unsafe string m_issuername
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_m_issuername);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_m_issuername), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x0000845C File Offset: 0x0000665C
		// (set) Token: 0x060000F1 RID: 241 RVA: 0x000025A4 File Offset: 0x000007A4
		public unsafe string m_keyalgo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_m_keyalgo);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_m_keyalgo), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x00008484 File Offset: 0x00006684
		// (set) Token: 0x060000F3 RID: 243 RVA: 0x000025C3 File Offset: 0x000007C3
		public unsafe Il2CppStructArray<byte> m_keyalgoparams
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_m_keyalgoparams);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_m_keyalgoparams), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x000084B4 File Offset: 0x000066B4
		// (set) Token: 0x060000F5 RID: 245 RVA: 0x000025E2 File Offset: 0x000007E2
		public unsafe ASN1 subject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_subject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ASN1>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_subject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x000084E4 File Offset: 0x000066E4
		// (set) Token: 0x060000F7 RID: 247 RVA: 0x00002601 File Offset: 0x00000801
		public unsafe string m_subject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_m_subject);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_m_subject), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x0000850C File Offset: 0x0000670C
		// (set) Token: 0x060000F9 RID: 249 RVA: 0x00002620 File Offset: 0x00000820
		public unsafe Il2CppStructArray<byte> m_publickey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_m_publickey);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_m_publickey), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000FA RID: 250 RVA: 0x0000853C File Offset: 0x0000673C
		// (set) Token: 0x060000FB RID: 251 RVA: 0x0000263F File Offset: 0x0000083F
		public unsafe Il2CppStructArray<byte> signature
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_signature);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_signature), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000FC RID: 252 RVA: 0x0000856C File Offset: 0x0000676C
		// (set) Token: 0x060000FD RID: 253 RVA: 0x0000265E File Offset: 0x0000085E
		public unsafe string m_signaturealgo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_m_signaturealgo);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_m_signaturealgo), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000FE RID: 254 RVA: 0x00008594 File Offset: 0x00006794
		// (set) Token: 0x060000FF RID: 255 RVA: 0x0000267D File Offset: 0x0000087D
		public unsafe Il2CppStructArray<byte> m_signaturealgoparams
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_m_signaturealgoparams);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_m_signaturealgoparams), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000100 RID: 256 RVA: 0x000085C4 File Offset: 0x000067C4
		// (set) Token: 0x06000101 RID: 257 RVA: 0x0000269C File Offset: 0x0000089C
		public unsafe Il2CppStructArray<byte> certhash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_certhash);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_certhash), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000102 RID: 258 RVA: 0x000085F4 File Offset: 0x000067F4
		// (set) Token: 0x06000103 RID: 259 RVA: 0x000026BB File Offset: 0x000008BB
		public unsafe RSA _rsa
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr__rsa);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RSA>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr__rsa), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000104 RID: 260 RVA: 0x00008624 File Offset: 0x00006824
		// (set) Token: 0x06000105 RID: 261 RVA: 0x000026DA File Offset: 0x000008DA
		public unsafe DSA _dsa
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr__dsa);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DSA>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr__dsa), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000106 RID: 262 RVA: 0x00008654 File Offset: 0x00006854
		// (set) Token: 0x06000107 RID: 263 RVA: 0x000026F9 File Offset: 0x000008F9
		public unsafe int version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_version)) = value;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000108 RID: 264 RVA: 0x0000867C File Offset: 0x0000687C
		// (set) Token: 0x06000109 RID: 265 RVA: 0x00002714 File Offset: 0x00000914
		public unsafe Il2CppStructArray<byte> serialnumber
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_serialnumber);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_serialnumber), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600010A RID: 266 RVA: 0x000086AC File Offset: 0x000068AC
		// (set) Token: 0x0600010B RID: 267 RVA: 0x00002733 File Offset: 0x00000933
		public unsafe Il2CppStructArray<byte> issuerUniqueID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_issuerUniqueID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_issuerUniqueID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600010C RID: 268 RVA: 0x000086DC File Offset: 0x000068DC
		// (set) Token: 0x0600010D RID: 269 RVA: 0x00002752 File Offset: 0x00000952
		public unsafe Il2CppStructArray<byte> subjectUniqueID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_subjectUniqueID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_subjectUniqueID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600010E RID: 270 RVA: 0x0000870C File Offset: 0x0000690C
		// (set) Token: 0x0600010F RID: 271 RVA: 0x00002771 File Offset: 0x00000971
		public unsafe X509ExtensionCollection extensions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_extensions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509ExtensionCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_extensions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000110 RID: 272 RVA: 0x0000873C File Offset: 0x0000693C
		// (set) Token: 0x06000111 RID: 273 RVA: 0x00002790 File Offset: 0x00000990
		public unsafe static string encoding_error
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(X509Certificate.NativeFieldInfoPtr_encoding_error, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(X509Certificate.NativeFieldInfoPtr_encoding_error, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeFieldInfoPtr_decoder;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeFieldInfoPtr_m_encodedcert;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeFieldInfoPtr_m_from;

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeFieldInfoPtr_m_until;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeFieldInfoPtr_issuer;

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeFieldInfoPtr_m_issuername;

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeFieldInfoPtr_m_keyalgo;

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeFieldInfoPtr_m_keyalgoparams;

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeFieldInfoPtr_subject;

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeFieldInfoPtr_m_subject;

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeFieldInfoPtr_m_publickey;

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeFieldInfoPtr_signature;

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeFieldInfoPtr_m_signaturealgo;

		// Token: 0x04000095 RID: 149
		private static readonly IntPtr NativeFieldInfoPtr_m_signaturealgoparams;

		// Token: 0x04000096 RID: 150
		private static readonly IntPtr NativeFieldInfoPtr_certhash;

		// Token: 0x04000097 RID: 151
		private static readonly IntPtr NativeFieldInfoPtr__rsa;

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeFieldInfoPtr__dsa;

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeFieldInfoPtr_version;

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeFieldInfoPtr_serialnumber;

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeFieldInfoPtr_issuerUniqueID;

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeFieldInfoPtr_subjectUniqueID;

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeFieldInfoPtr_extensions;

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeFieldInfoPtr_encoding_error;

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Private_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeMethodInfoPtr_GetUnsignedBigInteger_Private_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeMethodInfoPtr_get_DSA_Public_get_DSA_0;

		// Token: 0x040000A3 RID: 163
		private static readonly IntPtr NativeMethodInfoPtr_set_DSA_Public_set_Void_DSA_0;

		// Token: 0x040000A4 RID: 164
		private static readonly IntPtr NativeMethodInfoPtr_get_Extensions_Public_get_X509ExtensionCollection_0;

		// Token: 0x040000A5 RID: 165
		private static readonly IntPtr NativeMethodInfoPtr_get_Hash_Public_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x040000A6 RID: 166
		private static readonly IntPtr NativeMethodInfoPtr_get_IssuerName_Public_Virtual_New_get_String_0;

		// Token: 0x040000A7 RID: 167
		private static readonly IntPtr NativeMethodInfoPtr_get_KeyAlgorithm_Public_Virtual_New_get_String_0;

		// Token: 0x040000A8 RID: 168
		private static readonly IntPtr NativeMethodInfoPtr_get_KeyAlgorithmParameters_Public_Virtual_New_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeMethodInfoPtr_set_KeyAlgorithmParameters_Public_Virtual_New_set_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x040000AA RID: 170
		private static readonly IntPtr NativeMethodInfoPtr_get_PublicKey_Public_Virtual_New_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x040000AB RID: 171
		private static readonly IntPtr NativeMethodInfoPtr_get_RSA_Public_Virtual_New_get_RSA_0;

		// Token: 0x040000AC RID: 172
		private static readonly IntPtr NativeMethodInfoPtr_set_RSA_Public_Virtual_New_set_Void_RSA_0;

		// Token: 0x040000AD RID: 173
		private static readonly IntPtr NativeMethodInfoPtr_get_RawData_Public_Virtual_New_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x040000AE RID: 174
		private static readonly IntPtr NativeMethodInfoPtr_get_SerialNumber_Public_Virtual_New_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x040000AF RID: 175
		private static readonly IntPtr NativeMethodInfoPtr_get_Signature_Public_Virtual_New_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeMethodInfoPtr_get_SubjectName_Public_Virtual_New_get_String_0;

		// Token: 0x040000B1 RID: 177
		private static readonly IntPtr NativeMethodInfoPtr_get_ValidFrom_Public_Virtual_New_get_DateTime_0;

		// Token: 0x040000B2 RID: 178
		private static readonly IntPtr NativeMethodInfoPtr_get_ValidUntil_Public_Virtual_New_get_DateTime_0;

		// Token: 0x040000B3 RID: 179
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_get_Int32_0;

		// Token: 0x040000B4 RID: 180
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCurrent_Public_get_Boolean_0;

		// Token: 0x040000B5 RID: 181
		private static readonly IntPtr NativeMethodInfoPtr_WasCurrent_Public_Boolean_DateTime_0;

		// Token: 0x040000B6 RID: 182
		private static readonly IntPtr NativeMethodInfoPtr_VerifySignature_Internal_Boolean_DSA_0;

		// Token: 0x040000B7 RID: 183
		private static readonly IntPtr NativeMethodInfoPtr_VerifySignature_Internal_Boolean_RSA_0;

		// Token: 0x040000B8 RID: 184
		private static readonly IntPtr NativeMethodInfoPtr_VerifySignature_Public_Boolean_AsymmetricAlgorithm_0;

		// Token: 0x040000B9 RID: 185
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSelfSigned_Public_get_Boolean_0;

		// Token: 0x040000BA RID: 186
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040000BB RID: 187
		private static readonly IntPtr NativeMethodInfoPtr_PEM_Private_Static_Il2CppStructArray_1_Byte_String_Il2CppStructArray_1_Byte_0;
	}
}
