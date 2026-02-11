using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Security.Cryptography;

namespace Il2CppMono.Security.Cryptography
{
	// Token: 0x02000037 RID: 55
	public sealed class PKCS1 : Object
	{
		// Token: 0x06000309 RID: 777 RVA: 0x0000FB24 File Offset: 0x0000DD24
		// Note: this type is marked as 'beforefieldinit'.
		static PKCS1()
		{
			Il2CppClassPointerStore<PKCS1>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.Cryptography", "PKCS1");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PKCS1>.NativeClassPtr);
			PKCS1.NativeFieldInfoPtr_emptySHA1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS1>.NativeClassPtr, "emptySHA1");
			PKCS1.NativeFieldInfoPtr_emptySHA256 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS1>.NativeClassPtr, "emptySHA256");
			PKCS1.NativeFieldInfoPtr_emptySHA384 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS1>.NativeClassPtr, "emptySHA384");
			PKCS1.NativeFieldInfoPtr_emptySHA512 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS1>.NativeClassPtr, "emptySHA512");
			PKCS1.NativeMethodInfoPtr_Compare_Private_Static_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS1>.NativeClassPtr, 100663733);
			PKCS1.NativeMethodInfoPtr_I2OSP_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS1>.NativeClassPtr, 100663734);
			PKCS1.NativeMethodInfoPtr_OS2IP_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS1>.NativeClassPtr, 100663735);
			PKCS1.NativeMethodInfoPtr_RSAVP1_Public_Static_Il2CppStructArray_1_Byte_RSA_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS1>.NativeClassPtr, 100663736);
			PKCS1.NativeMethodInfoPtr_Verify_v15_Public_Static_Boolean_RSA_HashAlgorithm_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS1>.NativeClassPtr, 100663737);
			PKCS1.NativeMethodInfoPtr_Encode_v15_Public_Static_Il2CppStructArray_1_Byte_HashAlgorithm_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS1>.NativeClassPtr, 100663738);
			PKCS1.NativeMethodInfoPtr_HashNameFromOid_Internal_Static_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS1>.NativeClassPtr, 100663739);
			PKCS1.NativeMethodInfoPtr_CreateFromOid_Internal_Static_HashAlgorithm_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS1>.NativeClassPtr, 100663740);
			PKCS1.NativeMethodInfoPtr_CreateFromName_Internal_Static_HashAlgorithm_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS1>.NativeClassPtr, 100663741);
		}

		// Token: 0x0600030A RID: 778 RVA: 0x0000FC58 File Offset: 0x0000DE58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1149801, XrefRangeEnd = 1149802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Compare(Il2CppStructArray<byte> array1, Il2CppStructArray<byte> array2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(array2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS1.NativeMethodInfoPtr_Compare_Private_Static_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600030B RID: 779 RVA: 0x0000FCAC File Offset: 0x0000DEAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1149802, XrefRangeEnd = 1149806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> I2OSP(Il2CppStructArray<byte> x, int size)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS1.NativeMethodInfoPtr_I2OSP_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x0600030C RID: 780 RVA: 0x0000FD00 File Offset: 0x0000DF00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1149806, XrefRangeEnd = 1149807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> OS2IP(Il2CppStructArray<byte> x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS1.NativeMethodInfoPtr_OS2IP_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x0600030D RID: 781 RVA: 0x0000FD44 File Offset: 0x0000DF44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1149807, XrefRangeEnd = 1149808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> RSAVP1(RSA rsa, Il2CppStructArray<byte> s)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rsa);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(s);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS1.NativeMethodInfoPtr_RSAVP1_Public_Static_Il2CppStructArray_1_Byte_RSA_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x0600030E RID: 782 RVA: 0x0000FD9C File Offset: 0x0000DF9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1149830, RefRangeEnd = 1149831, XrefRangeStart = 1149808, XrefRangeEnd = 1149830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Verify_v15(RSA rsa, HashAlgorithm hash, Il2CppStructArray<byte> hashValue, Il2CppStructArray<byte> signature, bool tryNonStandardEncoding)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rsa);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hash);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hashValue);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(signature);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tryNonStandardEncoding;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS1.NativeMethodInfoPtr_Verify_v15_Public_Static_Boolean_RSA_HashAlgorithm_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600030F RID: 783 RVA: 0x0000FE24 File Offset: 0x0000E024
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1149868, RefRangeEnd = 1149869, XrefRangeStart = 1149831, XrefRangeEnd = 1149868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> Encode_v15(HashAlgorithm hash, Il2CppStructArray<byte> hashValue, int emLength)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hash);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hashValue);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref emLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS1.NativeMethodInfoPtr_Encode_v15_Public_Static_Il2CppStructArray_1_Byte_HashAlgorithm_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06000310 RID: 784 RVA: 0x0000FE88 File Offset: 0x0000E088
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1149892, RefRangeEnd = 1149897, XrefRangeStart = 1149869, XrefRangeEnd = 1149892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string HashNameFromOid(string oid, bool throwOnError = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(oid);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwOnError;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS1.NativeMethodInfoPtr_HashNameFromOid_Internal_Static_String_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000311 RID: 785 RVA: 0x0000FED4 File Offset: 0x0000E0D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1149902, RefRangeEnd = 1149903, XrefRangeStart = 1149897, XrefRangeEnd = 1149902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HashAlgorithm CreateFromOid(string oid)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(oid);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS1.NativeMethodInfoPtr_CreateFromOid_Internal_Static_HashAlgorithm_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HashAlgorithm>(intPtr3) : null;
			}
		}

		// Token: 0x06000312 RID: 786 RVA: 0x0000FF18 File Offset: 0x0000E118
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1149920, RefRangeEnd = 1149923, XrefRangeStart = 1149903, XrefRangeEnd = 1149920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HashAlgorithm CreateFromName(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS1.NativeMethodInfoPtr_CreateFromName_Internal_Static_HashAlgorithm_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HashAlgorithm>(intPtr3) : null;
			}
		}

		// Token: 0x06000313 RID: 787 RVA: 0x00003476 File Offset: 0x00001676
		public PKCS1(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000314 RID: 788 RVA: 0x0000FF5C File Offset: 0x0000E15C
		// (set) Token: 0x06000315 RID: 789 RVA: 0x0000347F File Offset: 0x0000167F
		public unsafe static Il2CppStructArray<byte> emptySHA1
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PKCS1.NativeFieldInfoPtr_emptySHA1, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PKCS1.NativeFieldInfoPtr_emptySHA1, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000316 RID: 790 RVA: 0x0000FF84 File Offset: 0x0000E184
		// (set) Token: 0x06000317 RID: 791 RVA: 0x00003491 File Offset: 0x00001691
		public unsafe static Il2CppStructArray<byte> emptySHA256
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PKCS1.NativeFieldInfoPtr_emptySHA256, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PKCS1.NativeFieldInfoPtr_emptySHA256, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x06000318 RID: 792 RVA: 0x0000FFAC File Offset: 0x0000E1AC
		// (set) Token: 0x06000319 RID: 793 RVA: 0x000034A3 File Offset: 0x000016A3
		public unsafe static Il2CppStructArray<byte> emptySHA384
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PKCS1.NativeFieldInfoPtr_emptySHA384, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PKCS1.NativeFieldInfoPtr_emptySHA384, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x0600031A RID: 794 RVA: 0x0000FFD4 File Offset: 0x0000E1D4
		// (set) Token: 0x0600031B RID: 795 RVA: 0x000034B5 File Offset: 0x000016B5
		public unsafe static Il2CppStructArray<byte> emptySHA512
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PKCS1.NativeFieldInfoPtr_emptySHA512, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PKCS1.NativeFieldInfoPtr_emptySHA512, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400035D RID: 861
		private static readonly IntPtr NativeFieldInfoPtr_emptySHA1;

		// Token: 0x0400035E RID: 862
		private static readonly IntPtr NativeFieldInfoPtr_emptySHA256;

		// Token: 0x0400035F RID: 863
		private static readonly IntPtr NativeFieldInfoPtr_emptySHA384;

		// Token: 0x04000360 RID: 864
		private static readonly IntPtr NativeFieldInfoPtr_emptySHA512;

		// Token: 0x04000361 RID: 865
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Private_Static_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000362 RID: 866
		private static readonly IntPtr NativeMethodInfoPtr_I2OSP_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04000363 RID: 867
		private static readonly IntPtr NativeMethodInfoPtr_OS2IP_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000364 RID: 868
		private static readonly IntPtr NativeMethodInfoPtr_RSAVP1_Public_Static_Il2CppStructArray_1_Byte_RSA_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000365 RID: 869
		private static readonly IntPtr NativeMethodInfoPtr_Verify_v15_Public_Static_Boolean_RSA_HashAlgorithm_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Boolean_0;

		// Token: 0x04000366 RID: 870
		private static readonly IntPtr NativeMethodInfoPtr_Encode_v15_Public_Static_Il2CppStructArray_1_Byte_HashAlgorithm_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04000367 RID: 871
		private static readonly IntPtr NativeMethodInfoPtr_HashNameFromOid_Internal_Static_String_String_Boolean_0;

		// Token: 0x04000368 RID: 872
		private static readonly IntPtr NativeMethodInfoPtr_CreateFromOid_Internal_Static_HashAlgorithm_String_0;

		// Token: 0x04000369 RID: 873
		private static readonly IntPtr NativeMethodInfoPtr_CreateFromName_Internal_Static_HashAlgorithm_String_0;
	}
}
