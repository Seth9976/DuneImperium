using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x020000C6 RID: 198
	public sealed class PublicKey : Object
	{
		// Token: 0x06000CF8 RID: 3320 RVA: 0x0004C7B0 File Offset: 0x0004A9B0
		// Note: this type is marked as 'beforefieldinit'.
		static PublicKey()
		{
			Il2CppClassPointerStore<PublicKey>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Security.Cryptography.X509Certificates", "PublicKey");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PublicKey>.NativeClassPtr);
			PublicKey.NativeFieldInfoPtr__keyValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PublicKey>.NativeClassPtr, "_keyValue");
			PublicKey.NativeFieldInfoPtr__params = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PublicKey>.NativeClassPtr, "_params");
			PublicKey.NativeFieldInfoPtr__oid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PublicKey>.NativeClassPtr, "_oid");
			PublicKey.NativeFieldInfoPtr_Empty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PublicKey>.NativeClassPtr, "Empty");
			PublicKey.NativeMethodInfoPtr__ctor_Public_Void_Oid_AsnEncodedData_AsnEncodedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublicKey>.NativeClassPtr, 100665160);
			PublicKey.NativeMethodInfoPtr_get_EncodedKeyValue_Public_get_AsnEncodedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublicKey>.NativeClassPtr, 100665161);
			PublicKey.NativeMethodInfoPtr_get_EncodedParameters_Public_get_AsnEncodedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublicKey>.NativeClassPtr, 100665162);
			PublicKey.NativeMethodInfoPtr_get_Key_Public_get_AsymmetricAlgorithm_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublicKey>.NativeClassPtr, 100665163);
			PublicKey.NativeMethodInfoPtr_get_Oid_Public_get_Oid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublicKey>.NativeClassPtr, 100665164);
			PublicKey.NativeMethodInfoPtr_GetUnsignedBigInteger_Private_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublicKey>.NativeClassPtr, 100665165);
			PublicKey.NativeMethodInfoPtr_DecodeDSA_Internal_Static_DSA_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublicKey>.NativeClassPtr, 100665166);
			PublicKey.NativeMethodInfoPtr_DecodeRSA_Internal_Static_RSA_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublicKey>.NativeClassPtr, 100665167);
		}

		// Token: 0x06000CF9 RID: 3321 RVA: 0x0004C8D0 File Offset: 0x0004AAD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 452811, RefRangeEnd = 452812, XrefRangeStart = 452776, XrefRangeEnd = 452811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PublicKey(Oid oid, AsnEncodedData parameters, AsnEncodedData keyValue)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PublicKey>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(oid);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parameters);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(keyValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublicKey.NativeMethodInfoPtr__ctor_Public_Void_Oid_AsnEncodedData_AsnEncodedData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06000CFA RID: 3322 RVA: 0x0004C940 File Offset: 0x0004AB40
		public unsafe AsnEncodedData EncodedKeyValue
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublicKey.NativeMethodInfoPtr_get_EncodedKeyValue_Public_get_AsnEncodedData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsnEncodedData>(intPtr3) : null;
			}
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06000CFB RID: 3323 RVA: 0x0004C980 File Offset: 0x0004AB80
		public unsafe AsnEncodedData EncodedParameters
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublicKey.NativeMethodInfoPtr_get_EncodedParameters_Public_get_AsnEncodedData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsnEncodedData>(intPtr3) : null;
			}
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06000CFC RID: 3324 RVA: 0x0004C9C0 File Offset: 0x0004ABC0
		public unsafe AsymmetricAlgorithm Key
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 452840, RefRangeEnd = 452845, XrefRangeStart = 452812, XrefRangeEnd = 452840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublicKey.NativeMethodInfoPtr_get_Key_Public_get_AsymmetricAlgorithm_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsymmetricAlgorithm>(intPtr3) : null;
			}
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06000CFD RID: 3325 RVA: 0x0004CA00 File Offset: 0x0004AC00
		public unsafe Oid Oid
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublicKey.NativeMethodInfoPtr_get_Oid_Public_get_Oid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Oid>(intPtr3) : null;
			}
		}

		// Token: 0x06000CFE RID: 3326 RVA: 0x0004CA40 File Offset: 0x0004AC40
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 452849, RefRangeEnd = 452853, XrefRangeStart = 452845, XrefRangeEnd = 452849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> GetUnsignedBigInteger(Il2CppStructArray<byte> integer)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(integer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublicKey.NativeMethodInfoPtr_GetUnsignedBigInteger_Private_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06000CFF RID: 3327 RVA: 0x0004CA84 File Offset: 0x0004AC84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 452892, RefRangeEnd = 452893, XrefRangeStart = 452853, XrefRangeEnd = 452892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DSA DecodeDSA(Il2CppStructArray<byte> rawPublicKey, Il2CppStructArray<byte> rawParameters)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rawPublicKey);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rawParameters);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublicKey.NativeMethodInfoPtr_DecodeDSA_Internal_Static_DSA_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DSA>(intPtr3) : null;
		}

		// Token: 0x06000D00 RID: 3328 RVA: 0x0004CADC File Offset: 0x0004ACDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 452912, RefRangeEnd = 452913, XrefRangeStart = 452893, XrefRangeEnd = 452912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RSA DecodeRSA(Il2CppStructArray<byte> rawPublicKey)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rawPublicKey);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublicKey.NativeMethodInfoPtr_DecodeRSA_Internal_Static_RSA_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RSA>(intPtr3) : null;
			}
		}

		// Token: 0x06000D01 RID: 3329 RVA: 0x00006CBA File Offset: 0x00004EBA
		public PublicKey(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06000D02 RID: 3330 RVA: 0x0004CB20 File Offset: 0x0004AD20
		// (set) Token: 0x06000D03 RID: 3331 RVA: 0x00006CC3 File Offset: 0x00004EC3
		public unsafe AsnEncodedData _keyValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PublicKey.NativeFieldInfoPtr__keyValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsnEncodedData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PublicKey.NativeFieldInfoPtr__keyValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06000D04 RID: 3332 RVA: 0x0004CB50 File Offset: 0x0004AD50
		// (set) Token: 0x06000D05 RID: 3333 RVA: 0x00006CE2 File Offset: 0x00004EE2
		public unsafe AsnEncodedData _params
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PublicKey.NativeFieldInfoPtr__params);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsnEncodedData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PublicKey.NativeFieldInfoPtr__params), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06000D06 RID: 3334 RVA: 0x0004CB80 File Offset: 0x0004AD80
		// (set) Token: 0x06000D07 RID: 3335 RVA: 0x00006D01 File Offset: 0x00004F01
		public unsafe Oid _oid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PublicKey.NativeFieldInfoPtr__oid);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Oid>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PublicKey.NativeFieldInfoPtr__oid), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06000D08 RID: 3336 RVA: 0x0004CBB0 File Offset: 0x0004ADB0
		// (set) Token: 0x06000D09 RID: 3337 RVA: 0x00006D20 File Offset: 0x00004F20
		public unsafe static Il2CppStructArray<byte> Empty
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PublicKey.NativeFieldInfoPtr_Empty, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PublicKey.NativeFieldInfoPtr_Empty, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AC0 RID: 2752
		private static readonly IntPtr NativeFieldInfoPtr__keyValue;

		// Token: 0x04000AC1 RID: 2753
		private static readonly IntPtr NativeFieldInfoPtr__params;

		// Token: 0x04000AC2 RID: 2754
		private static readonly IntPtr NativeFieldInfoPtr__oid;

		// Token: 0x04000AC3 RID: 2755
		private static readonly IntPtr NativeFieldInfoPtr_Empty;

		// Token: 0x04000AC4 RID: 2756
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Oid_AsnEncodedData_AsnEncodedData_0;

		// Token: 0x04000AC5 RID: 2757
		private static readonly IntPtr NativeMethodInfoPtr_get_EncodedKeyValue_Public_get_AsnEncodedData_0;

		// Token: 0x04000AC6 RID: 2758
		private static readonly IntPtr NativeMethodInfoPtr_get_EncodedParameters_Public_get_AsnEncodedData_0;

		// Token: 0x04000AC7 RID: 2759
		private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_get_AsymmetricAlgorithm_0;

		// Token: 0x04000AC8 RID: 2760
		private static readonly IntPtr NativeMethodInfoPtr_get_Oid_Public_get_Oid_0;

		// Token: 0x04000AC9 RID: 2761
		private static readonly IntPtr NativeMethodInfoPtr_GetUnsignedBigInteger_Private_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000ACA RID: 2762
		private static readonly IntPtr NativeMethodInfoPtr_DecodeDSA_Internal_Static_DSA_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000ACB RID: 2763
		private static readonly IntPtr NativeMethodInfoPtr_DecodeRSA_Internal_Static_RSA_Il2CppStructArray_1_Byte_0;
	}
}
