using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Security.Cryptography;

namespace Il2CppMono.Security.Cryptography
{
	// Token: 0x0200002B RID: 43
	public sealed class CryptoConvert : Object
	{
		// Token: 0x0600020E RID: 526 RVA: 0x0002D798 File Offset: 0x0002B998
		// Note: this type is marked as 'beforefieldinit'.
		static CryptoConvert()
		{
			Il2CppClassPointerStore<CryptoConvert>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Security.Cryptography", "CryptoConvert");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CryptoConvert>.NativeClassPtr);
			CryptoConvert.NativeMethodInfoPtr_ToInt32LE_Private_Static_Int32_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoConvert>.NativeClassPtr, 100663601);
			CryptoConvert.NativeMethodInfoPtr_ToUInt32LE_Private_Static_UInt32_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoConvert>.NativeClassPtr, 100663602);
			CryptoConvert.NativeMethodInfoPtr_GetBytesLE_Private_Static_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoConvert>.NativeClassPtr, 100663603);
			CryptoConvert.NativeMethodInfoPtr_Trim_Private_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoConvert>.NativeClassPtr, 100663604);
			CryptoConvert.NativeMethodInfoPtr_FromCapiPrivateKeyBlob_Public_Static_RSA_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoConvert>.NativeClassPtr, 100663605);
			CryptoConvert.NativeMethodInfoPtr_GetParametersFromCapiPrivateKeyBlob_Private_Static_RSAParameters_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoConvert>.NativeClassPtr, 100663606);
			CryptoConvert.NativeMethodInfoPtr_ToCapiPrivateKeyBlob_Public_Static_Il2CppStructArray_1_Byte_RSA_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoConvert>.NativeClassPtr, 100663607);
			CryptoConvert.NativeMethodInfoPtr_FromCapiPublicKeyBlob_Public_Static_RSA_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoConvert>.NativeClassPtr, 100663608);
			CryptoConvert.NativeMethodInfoPtr_GetParametersFromCapiPublicKeyBlob_Private_Static_RSAParameters_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoConvert>.NativeClassPtr, 100663609);
			CryptoConvert.NativeMethodInfoPtr_ToCapiPublicKeyBlob_Public_Static_Il2CppStructArray_1_Byte_RSA_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoConvert>.NativeClassPtr, 100663610);
			CryptoConvert.NativeMethodInfoPtr_FromCapiKeyBlob_Public_Static_RSA_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoConvert>.NativeClassPtr, 100663611);
			CryptoConvert.NativeMethodInfoPtr_FromCapiKeyBlob_Public_Static_RSA_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoConvert>.NativeClassPtr, 100663612);
		}

		// Token: 0x0600020F RID: 527 RVA: 0x0002D8B8 File Offset: 0x0002BAB8
		[CallerCount(0)]
		public unsafe static int ToInt32LE(Il2CppStructArray<byte> bytes, int offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoConvert.NativeMethodInfoPtr_ToInt32LE_Private_Static_Int32_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000210 RID: 528 RVA: 0x0002D908 File Offset: 0x0002BB08
		[CallerCount(0)]
		public unsafe static uint ToUInt32LE(Il2CppStructArray<byte> bytes, int offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoConvert.NativeMethodInfoPtr_ToUInt32LE_Private_Static_UInt32_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000211 RID: 529 RVA: 0x0002D958 File Offset: 0x0002BB58
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1277745, RefRangeEnd = 1277747, XrefRangeStart = 1277742, XrefRangeEnd = 1277745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> GetBytesLE(int val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoConvert.NativeMethodInfoPtr_GetBytesLE_Private_Static_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06000212 RID: 530 RVA: 0x0002D998 File Offset: 0x0002BB98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1277747, XrefRangeEnd = 1277752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> Trim(Il2CppStructArray<byte> array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoConvert.NativeMethodInfoPtr_Trim_Private_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06000213 RID: 531 RVA: 0x0002D9DC File Offset: 0x0002BBDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1277752, XrefRangeEnd = 1277754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RSA FromCapiPrivateKeyBlob(Il2CppStructArray<byte> blob, int offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(blob);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoConvert.NativeMethodInfoPtr_FromCapiPrivateKeyBlob_Public_Static_RSA_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RSA>(intPtr3) : null;
		}

		// Token: 0x06000214 RID: 532 RVA: 0x0002DA30 File Offset: 0x0002BC30
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1277810, RefRangeEnd = 1277812, XrefRangeStart = 1277754, XrefRangeEnd = 1277810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RSAParameters GetParametersFromCapiPrivateKeyBlob(Il2CppStructArray<byte> blob, int offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(blob);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoConvert.NativeMethodInfoPtr_GetParametersFromCapiPrivateKeyBlob_Private_Static_RSAParameters_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new RSAParameters(intPtr);
		}

		// Token: 0x06000215 RID: 533 RVA: 0x0002DA7C File Offset: 0x0002BC7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1277838, RefRangeEnd = 1277839, XrefRangeStart = 1277812, XrefRangeEnd = 1277838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> ToCapiPrivateKeyBlob(RSA rsa)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rsa);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoConvert.NativeMethodInfoPtr_ToCapiPrivateKeyBlob_Public_Static_Il2CppStructArray_1_Byte_RSA_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06000216 RID: 534 RVA: 0x0002DAC0 File Offset: 0x0002BCC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1277841, RefRangeEnd = 1277842, XrefRangeStart = 1277839, XrefRangeEnd = 1277841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RSA FromCapiPublicKeyBlob(Il2CppStructArray<byte> blob, int offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(blob);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoConvert.NativeMethodInfoPtr_FromCapiPublicKeyBlob_Public_Static_RSA_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RSA>(intPtr3) : null;
		}

		// Token: 0x06000217 RID: 535 RVA: 0x0002DB14 File Offset: 0x0002BD14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1277853, RefRangeEnd = 1277854, XrefRangeStart = 1277842, XrefRangeEnd = 1277853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RSAParameters GetParametersFromCapiPublicKeyBlob(Il2CppStructArray<byte> blob, int offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(blob);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoConvert.NativeMethodInfoPtr_GetParametersFromCapiPublicKeyBlob_Private_Static_RSAParameters_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new RSAParameters(intPtr);
		}

		// Token: 0x06000218 RID: 536 RVA: 0x0002DB60 File Offset: 0x0002BD60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1277862, RefRangeEnd = 1277863, XrefRangeStart = 1277854, XrefRangeEnd = 1277862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> ToCapiPublicKeyBlob(RSA rsa)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rsa);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoConvert.NativeMethodInfoPtr_ToCapiPublicKeyBlob_Public_Static_Il2CppStructArray_1_Byte_RSA_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06000219 RID: 537 RVA: 0x0002DBA4 File Offset: 0x0002BDA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1277864, RefRangeEnd = 1277865, XrefRangeStart = 1277863, XrefRangeEnd = 1277864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RSA FromCapiKeyBlob(Il2CppStructArray<byte> blob)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(blob);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoConvert.NativeMethodInfoPtr_FromCapiKeyBlob_Public_Static_RSA_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RSA>(intPtr3) : null;
			}
		}

		// Token: 0x0600021A RID: 538 RVA: 0x0002DBE8 File Offset: 0x0002BDE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1277868, RefRangeEnd = 1277869, XrefRangeStart = 1277865, XrefRangeEnd = 1277868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RSA FromCapiKeyBlob(Il2CppStructArray<byte> blob, int offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(blob);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoConvert.NativeMethodInfoPtr_FromCapiKeyBlob_Public_Static_RSA_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RSA>(intPtr3) : null;
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00002DD7 File Offset: 0x00000FD7
		public CryptoConvert(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000168 RID: 360
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32LE_Private_Static_Int32_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04000169 RID: 361
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt32LE_Private_Static_UInt32_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x0400016A RID: 362
		private static readonly IntPtr NativeMethodInfoPtr_GetBytesLE_Private_Static_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x0400016B RID: 363
		private static readonly IntPtr NativeMethodInfoPtr_Trim_Private_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400016C RID: 364
		private static readonly IntPtr NativeMethodInfoPtr_FromCapiPrivateKeyBlob_Public_Static_RSA_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x0400016D RID: 365
		private static readonly IntPtr NativeMethodInfoPtr_GetParametersFromCapiPrivateKeyBlob_Private_Static_RSAParameters_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x0400016E RID: 366
		private static readonly IntPtr NativeMethodInfoPtr_ToCapiPrivateKeyBlob_Public_Static_Il2CppStructArray_1_Byte_RSA_0;

		// Token: 0x0400016F RID: 367
		private static readonly IntPtr NativeMethodInfoPtr_FromCapiPublicKeyBlob_Public_Static_RSA_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04000170 RID: 368
		private static readonly IntPtr NativeMethodInfoPtr_GetParametersFromCapiPublicKeyBlob_Private_Static_RSAParameters_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04000171 RID: 369
		private static readonly IntPtr NativeMethodInfoPtr_ToCapiPublicKeyBlob_Public_Static_Il2CppStructArray_1_Byte_RSA_0;

		// Token: 0x04000172 RID: 370
		private static readonly IntPtr NativeMethodInfoPtr_FromCapiKeyBlob_Public_Static_RSA_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000173 RID: 371
		private static readonly IntPtr NativeMethodInfoPtr_FromCapiKeyBlob_Public_Static_RSA_Il2CppStructArray_1_Byte_Int32_0;
	}
}
