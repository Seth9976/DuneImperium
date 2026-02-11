using System;
using System.Reflection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Security.Cryptography;

namespace Il2CppMono.Security.X509
{
	// Token: 0x0200000A RID: 10
	[DefaultMember("Item")]
	public class X509Crl : Object
	{
		// Token: 0x060000A3 RID: 163 RVA: 0x00006FAC File Offset: 0x000051AC
		// Note: this type is marked as 'beforefieldinit'.
		static X509Crl()
		{
			Il2CppClassPointerStore<X509Crl>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.X509", "X509Crl");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509Crl>.NativeClassPtr);
			X509Crl.NativeFieldInfoPtr_issuer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Crl>.NativeClassPtr, "issuer");
			X509Crl.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Crl>.NativeClassPtr, "version");
			X509Crl.NativeFieldInfoPtr_thisUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Crl>.NativeClassPtr, "thisUpdate");
			X509Crl.NativeFieldInfoPtr_nextUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Crl>.NativeClassPtr, "nextUpdate");
			X509Crl.NativeFieldInfoPtr_entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Crl>.NativeClassPtr, "entries");
			X509Crl.NativeFieldInfoPtr_signatureOID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Crl>.NativeClassPtr, "signatureOID");
			X509Crl.NativeFieldInfoPtr_signature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Crl>.NativeClassPtr, "signature");
			X509Crl.NativeFieldInfoPtr_extensions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Crl>.NativeClassPtr, "extensions");
			X509Crl.NativeFieldInfoPtr_encoded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Crl>.NativeClassPtr, "encoded");
			X509Crl.NativeFieldInfoPtr_hash_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Crl>.NativeClassPtr, "hash_value");
			X509Crl.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Crl>.NativeClassPtr, 100663421);
			X509Crl.NativeMethodInfoPtr_Parse_Private_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Crl>.NativeClassPtr, 100663422);
			X509Crl.NativeMethodInfoPtr_get_Extensions_Public_get_X509ExtensionCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Crl>.NativeClassPtr, 100663423);
			X509Crl.NativeMethodInfoPtr_get_Hash_Public_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Crl>.NativeClassPtr, 100663424);
			X509Crl.NativeMethodInfoPtr_get_IssuerName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Crl>.NativeClassPtr, 100663425);
			X509Crl.NativeMethodInfoPtr_get_NextUpdate_Public_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Crl>.NativeClassPtr, 100663426);
			X509Crl.NativeMethodInfoPtr_Compare_Private_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Crl>.NativeClassPtr, 100663427);
			X509Crl.NativeMethodInfoPtr_GetCrlEntry_Public_X509CrlEntry_X509Certificate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Crl>.NativeClassPtr, 100663428);
			X509Crl.NativeMethodInfoPtr_GetCrlEntry_Public_X509CrlEntry_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Crl>.NativeClassPtr, 100663429);
			X509Crl.NativeMethodInfoPtr_VerifySignature_Internal_Boolean_DSA_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Crl>.NativeClassPtr, 100663430);
			X509Crl.NativeMethodInfoPtr_VerifySignature_Internal_Boolean_RSA_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Crl>.NativeClassPtr, 100663431);
			X509Crl.NativeMethodInfoPtr_VerifySignature_Public_Boolean_AsymmetricAlgorithm_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Crl>.NativeClassPtr, 100663432);
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00007194 File Offset: 0x00005394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1147168, XrefRangeEnd = 1147186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509Crl(Il2CppStructArray<byte> crl)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509Crl>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(crl);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Crl.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x000071E0 File Offset: 0x000053E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1147263, RefRangeEnd = 1147265, XrefRangeStart = 1147186, XrefRangeEnd = 1147263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Parse(Il2CppStructArray<byte> crl)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(crl);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Crl.NativeMethodInfoPtr_Parse_Private_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x00007224 File Offset: 0x00005424
		public unsafe X509ExtensionCollection Extensions
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Crl.NativeMethodInfoPtr_get_Extensions_Public_get_X509ExtensionCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509ExtensionCollection>(intPtr3) : null;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x00007264 File Offset: 0x00005464
		public unsafe Il2CppStructArray<byte> Hash
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1147282, RefRangeEnd = 1147285, XrefRangeStart = 1147265, XrefRangeEnd = 1147282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Crl.NativeMethodInfoPtr_get_Hash_Public_get_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x000072A4 File Offset: 0x000054A4
		public unsafe string IssuerName
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Crl.NativeMethodInfoPtr_get_IssuerName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x000072DC File Offset: 0x000054DC
		public unsafe DateTime NextUpdate
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Crl.NativeMethodInfoPtr_get_NextUpdate_Public_get_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00007318 File Offset: 0x00005518
		[CallerCount(0)]
		public unsafe bool Compare(Il2CppStructArray<byte> array1, Il2CppStructArray<byte> array2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(array2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Crl.NativeMethodInfoPtr_Compare_Private_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00007378 File Offset: 0x00005578
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1147292, RefRangeEnd = 1147293, XrefRangeStart = 1147285, XrefRangeEnd = 1147292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509Crl.X509CrlEntry GetCrlEntry(X509Certificate x509)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x509);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Crl.NativeMethodInfoPtr_GetCrlEntry_Public_X509CrlEntry_X509Certificate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Crl.X509CrlEntry>(intPtr3) : null;
			}
		}

		// Token: 0x060000AC RID: 172 RVA: 0x000073C8 File Offset: 0x000055C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1147301, RefRangeEnd = 1147302, XrefRangeStart = 1147293, XrefRangeEnd = 1147301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509Crl.X509CrlEntry GetCrlEntry(Il2CppStructArray<byte> serialNumber)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serialNumber);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Crl.NativeMethodInfoPtr_GetCrlEntry_Public_X509CrlEntry_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Crl.X509CrlEntry>(intPtr3) : null;
			}
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00007418 File Offset: 0x00005618
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1147332, RefRangeEnd = 1147333, XrefRangeStart = 1147302, XrefRangeEnd = 1147332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool VerifySignature(DSA dsa)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dsa);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Crl.NativeMethodInfoPtr_VerifySignature_Internal_Boolean_DSA_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00007468 File Offset: 0x00005668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1147333, XrefRangeEnd = 1147343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool VerifySignature(RSA rsa)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rsa);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Crl.NativeMethodInfoPtr_VerifySignature_Internal_Boolean_RSA_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000AF RID: 175 RVA: 0x000074B8 File Offset: 0x000056B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1147375, RefRangeEnd = 1147376, XrefRangeStart = 1147343, XrefRangeEnd = 1147375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool VerifySignature(AsymmetricAlgorithm aa)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(aa);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Crl.NativeMethodInfoPtr_VerifySignature_Public_Boolean_AsymmetricAlgorithm_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x000023B6 File Offset: 0x000005B6
		public X509Crl(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x00007508 File Offset: 0x00005708
		// (set) Token: 0x060000B2 RID: 178 RVA: 0x000023BF File Offset: 0x000005BF
		public unsafe string issuer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Crl.NativeFieldInfoPtr_issuer);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Crl.NativeFieldInfoPtr_issuer), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x00007530 File Offset: 0x00005730
		// (set) Token: 0x060000B4 RID: 180 RVA: 0x000023DE File Offset: 0x000005DE
		public unsafe byte version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Crl.NativeFieldInfoPtr_version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Crl.NativeFieldInfoPtr_version)) = value;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x00007558 File Offset: 0x00005758
		// (set) Token: 0x060000B6 RID: 182 RVA: 0x000023F9 File Offset: 0x000005F9
		public unsafe DateTime thisUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Crl.NativeFieldInfoPtr_thisUpdate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Crl.NativeFieldInfoPtr_thisUpdate)) = value;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x00007580 File Offset: 0x00005780
		// (set) Token: 0x060000B8 RID: 184 RVA: 0x00002414 File Offset: 0x00000614
		public unsafe DateTime nextUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Crl.NativeFieldInfoPtr_nextUpdate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Crl.NativeFieldInfoPtr_nextUpdate)) = value;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x000075A8 File Offset: 0x000057A8
		// (set) Token: 0x060000BA RID: 186 RVA: 0x0000242F File Offset: 0x0000062F
		public unsafe ArrayList entries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Crl.NativeFieldInfoPtr_entries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Crl.NativeFieldInfoPtr_entries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000BB RID: 187 RVA: 0x000075D8 File Offset: 0x000057D8
		// (set) Token: 0x060000BC RID: 188 RVA: 0x0000244E File Offset: 0x0000064E
		public unsafe string signatureOID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Crl.NativeFieldInfoPtr_signatureOID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Crl.NativeFieldInfoPtr_signatureOID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000BD RID: 189 RVA: 0x00007600 File Offset: 0x00005800
		// (set) Token: 0x060000BE RID: 190 RVA: 0x0000246D File Offset: 0x0000066D
		public unsafe Il2CppStructArray<byte> signature
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Crl.NativeFieldInfoPtr_signature);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Crl.NativeFieldInfoPtr_signature), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000BF RID: 191 RVA: 0x00007630 File Offset: 0x00005830
		// (set) Token: 0x060000C0 RID: 192 RVA: 0x0000248C File Offset: 0x0000068C
		public unsafe X509ExtensionCollection extensions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Crl.NativeFieldInfoPtr_extensions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509ExtensionCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Crl.NativeFieldInfoPtr_extensions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x00007660 File Offset: 0x00005860
		// (set) Token: 0x060000C2 RID: 194 RVA: 0x000024AB File Offset: 0x000006AB
		public unsafe Il2CppStructArray<byte> encoded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Crl.NativeFieldInfoPtr_encoded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Crl.NativeFieldInfoPtr_encoded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x00007690 File Offset: 0x00005890
		// (set) Token: 0x060000C4 RID: 196 RVA: 0x000024CA File Offset: 0x000006CA
		public unsafe Il2CppStructArray<byte> hash_value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Crl.NativeFieldInfoPtr_hash_value);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Crl.NativeFieldInfoPtr_hash_value), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeFieldInfoPtr_issuer;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeFieldInfoPtr_version;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeFieldInfoPtr_thisUpdate;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeFieldInfoPtr_nextUpdate;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeFieldInfoPtr_entries;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeFieldInfoPtr_signatureOID;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeFieldInfoPtr_signature;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeFieldInfoPtr_extensions;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeFieldInfoPtr_encoded;

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeFieldInfoPtr_hash_value;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Private_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeMethodInfoPtr_get_Extensions_Public_get_X509ExtensionCollection_0;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeMethodInfoPtr_get_Hash_Public_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeMethodInfoPtr_get_IssuerName_Public_get_String_0;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeMethodInfoPtr_get_NextUpdate_Public_get_DateTime_0;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Private_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeMethodInfoPtr_GetCrlEntry_Public_X509CrlEntry_X509Certificate_0;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeMethodInfoPtr_GetCrlEntry_Public_X509CrlEntry_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeMethodInfoPtr_VerifySignature_Internal_Boolean_DSA_0;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeMethodInfoPtr_VerifySignature_Internal_Boolean_RSA_0;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeMethodInfoPtr_VerifySignature_Public_Boolean_AsymmetricAlgorithm_0;

		// Token: 0x0200004A RID: 74
		public class X509CrlEntry : Object
		{
			// Token: 0x06000498 RID: 1176 RVA: 0x00014D8C File Offset: 0x00012F8C
			// Note: this type is marked as 'beforefieldinit'.
			static X509CrlEntry()
			{
				Il2CppClassPointerStore<X509Crl.X509CrlEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<X509Crl>.NativeClassPtr, "X509CrlEntry");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509Crl.X509CrlEntry>.NativeClassPtr);
				X509Crl.X509CrlEntry.NativeFieldInfoPtr_sn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Crl.X509CrlEntry>.NativeClassPtr, "sn");
				X509Crl.X509CrlEntry.NativeFieldInfoPtr_revocationDate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Crl.X509CrlEntry>.NativeClassPtr, "revocationDate");
				X509Crl.X509CrlEntry.NativeFieldInfoPtr_extensions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Crl.X509CrlEntry>.NativeClassPtr, "extensions");
				X509Crl.X509CrlEntry.NativeMethodInfoPtr__ctor_Internal_Void_ASN1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Crl.X509CrlEntry>.NativeClassPtr, 100663433);
				X509Crl.X509CrlEntry.NativeMethodInfoPtr_get_SerialNumber_Public_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Crl.X509CrlEntry>.NativeClassPtr, 100663434);
				X509Crl.X509CrlEntry.NativeMethodInfoPtr_get_RevocationDate_Public_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Crl.X509CrlEntry>.NativeClassPtr, 100663435);
				X509Crl.X509CrlEntry.NativeMethodInfoPtr_get_Extensions_Public_get_X509ExtensionCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Crl.X509CrlEntry>.NativeClassPtr, 100663436);
			}

			// Token: 0x06000499 RID: 1177 RVA: 0x00014E44 File Offset: 0x00013044
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1147149, XrefRangeEnd = 1147165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe X509CrlEntry(ASN1 entry)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509Crl.X509CrlEntry>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(entry);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Crl.X509CrlEntry.NativeMethodInfoPtr__ctor_Internal_Void_ASN1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17000195 RID: 405
			// (get) Token: 0x0600049A RID: 1178 RVA: 0x00014E90 File Offset: 0x00013090
			public unsafe Il2CppStructArray<byte> SerialNumber
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1147165, XrefRangeEnd = 1147168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Crl.X509CrlEntry.NativeMethodInfoPtr_get_SerialNumber_Public_get_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
				}
			}

			// Token: 0x17000196 RID: 406
			// (get) Token: 0x0600049B RID: 1179 RVA: 0x00014ED0 File Offset: 0x000130D0
			public unsafe DateTime RevocationDate
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Crl.X509CrlEntry.NativeMethodInfoPtr_get_RevocationDate_Public_get_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000197 RID: 407
			// (get) Token: 0x0600049C RID: 1180 RVA: 0x00014F0C File Offset: 0x0001310C
			public unsafe X509ExtensionCollection Extensions
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Crl.X509CrlEntry.NativeMethodInfoPtr_get_Extensions_Public_get_X509ExtensionCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509ExtensionCollection>(intPtr3) : null;
				}
			}

			// Token: 0x0600049D RID: 1181 RVA: 0x00003F5E File Offset: 0x0000215E
			public X509CrlEntry(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000192 RID: 402
			// (get) Token: 0x0600049E RID: 1182 RVA: 0x00014F4C File Offset: 0x0001314C
			// (set) Token: 0x0600049F RID: 1183 RVA: 0x00003F67 File Offset: 0x00002167
			public unsafe Il2CppStructArray<byte> sn
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Crl.X509CrlEntry.NativeFieldInfoPtr_sn);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Crl.X509CrlEntry.NativeFieldInfoPtr_sn), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000193 RID: 403
			// (get) Token: 0x060004A0 RID: 1184 RVA: 0x00014F7C File Offset: 0x0001317C
			// (set) Token: 0x060004A1 RID: 1185 RVA: 0x00003F86 File Offset: 0x00002186
			public unsafe DateTime revocationDate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Crl.X509CrlEntry.NativeFieldInfoPtr_revocationDate);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Crl.X509CrlEntry.NativeFieldInfoPtr_revocationDate)) = value;
				}
			}

			// Token: 0x17000194 RID: 404
			// (get) Token: 0x060004A2 RID: 1186 RVA: 0x00014FA4 File Offset: 0x000131A4
			// (set) Token: 0x060004A3 RID: 1187 RVA: 0x00003FA1 File Offset: 0x000021A1
			public unsafe X509ExtensionCollection extensions
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Crl.X509CrlEntry.NativeFieldInfoPtr_extensions);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509ExtensionCollection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Crl.X509CrlEntry.NativeFieldInfoPtr_extensions), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000462 RID: 1122
			private static readonly IntPtr NativeFieldInfoPtr_sn;

			// Token: 0x04000463 RID: 1123
			private static readonly IntPtr NativeFieldInfoPtr_revocationDate;

			// Token: 0x04000464 RID: 1124
			private static readonly IntPtr NativeFieldInfoPtr_extensions;

			// Token: 0x04000465 RID: 1125
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ASN1_0;

			// Token: 0x04000466 RID: 1126
			private static readonly IntPtr NativeMethodInfoPtr_get_SerialNumber_Public_get_Il2CppStructArray_1_Byte_0;

			// Token: 0x04000467 RID: 1127
			private static readonly IntPtr NativeMethodInfoPtr_get_RevocationDate_Public_get_DateTime_0;

			// Token: 0x04000468 RID: 1128
			private static readonly IntPtr NativeMethodInfoPtr_get_Extensions_Public_get_X509ExtensionCollection_0;
		}
	}
}
