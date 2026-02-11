using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Security.Cryptography;

namespace Il2CppMono.Security.Cryptography
{
	// Token: 0x02000031 RID: 49
	public sealed class CryptoConvert : Object
	{
		// Token: 0x060002C1 RID: 705 RVA: 0x0000E89C File Offset: 0x0000CA9C
		// Note: this type is marked as 'beforefieldinit'.
		static CryptoConvert()
		{
			Il2CppClassPointerStore<CryptoConvert>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.Cryptography", "CryptoConvert");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CryptoConvert>.NativeClassPtr);
			CryptoConvert.NativeMethodInfoPtr_ToInt32LE_Private_Static_Int32_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoConvert>.NativeClassPtr, 100663696);
			CryptoConvert.NativeMethodInfoPtr_ToUInt32LE_Private_Static_UInt32_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoConvert>.NativeClassPtr, 100663697);
			CryptoConvert.NativeMethodInfoPtr_Trim_Private_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoConvert>.NativeClassPtr, 100663698);
			CryptoConvert.NativeMethodInfoPtr_FromCapiPrivateKeyBlob_Public_Static_RSA_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoConvert>.NativeClassPtr, 100663699);
			CryptoConvert.NativeMethodInfoPtr_FromCapiPrivateKeyBlob_Public_Static_RSA_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoConvert>.NativeClassPtr, 100663700);
			CryptoConvert.NativeMethodInfoPtr_GetParametersFromCapiPrivateKeyBlob_Private_Static_RSAParameters_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoConvert>.NativeClassPtr, 100663701);
			CryptoConvert.NativeMethodInfoPtr_ToHex_Public_Static_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoConvert>.NativeClassPtr, 100663702);
			CryptoConvert.NativeMethodInfoPtr_FromHexChar_Private_Static_Byte_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoConvert>.NativeClassPtr, 100663703);
			CryptoConvert.NativeMethodInfoPtr_FromHex_Public_Static_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoConvert>.NativeClassPtr, 100663704);
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x0000E980 File Offset: 0x0000CB80
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

		// Token: 0x060002C3 RID: 707 RVA: 0x0000E9D0 File Offset: 0x0000CBD0
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

		// Token: 0x060002C4 RID: 708 RVA: 0x0000EA20 File Offset: 0x0000CC20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1149552, XrefRangeEnd = 1149557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060002C5 RID: 709 RVA: 0x0000EA64 File Offset: 0x0000CC64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1149557, XrefRangeEnd = 1149558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RSA FromCapiPrivateKeyBlob(Il2CppStructArray<byte> blob)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(blob);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoConvert.NativeMethodInfoPtr_FromCapiPrivateKeyBlob_Public_Static_RSA_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RSA>(intPtr3) : null;
			}
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x0000EAA8 File Offset: 0x0000CCA8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1149568, RefRangeEnd = 1149572, XrefRangeStart = 1149558, XrefRangeEnd = 1149568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060002C7 RID: 711 RVA: 0x0000EAFC File Offset: 0x0000CCFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1149628, RefRangeEnd = 1149629, XrefRangeStart = 1149572, XrefRangeEnd = 1149628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060002C8 RID: 712 RVA: 0x0000EB48 File Offset: 0x0000CD48
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1149642, RefRangeEnd = 1149644, XrefRangeStart = 1149629, XrefRangeEnd = 1149642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToHex(Il2CppStructArray<byte> input)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoConvert.NativeMethodInfoPtr_ToHex_Public_Static_String_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x0000EB84 File Offset: 0x0000CD84
		[CallerCount(0)]
		public unsafe static byte FromHexChar(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoConvert.NativeMethodInfoPtr_FromHexChar_Private_Static_Byte_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002CA RID: 714 RVA: 0x0000EBC4 File Offset: 0x0000CDC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1149654, RefRangeEnd = 1149655, XrefRangeStart = 1149644, XrefRangeEnd = 1149654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> FromHex(string hex)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(hex);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoConvert.NativeMethodInfoPtr_FromHex_Public_Static_Il2CppStructArray_1_Byte_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x060002CB RID: 715 RVA: 0x000032EA File Offset: 0x000014EA
		public CryptoConvert(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400032D RID: 813
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32LE_Private_Static_Int32_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x0400032E RID: 814
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt32LE_Private_Static_UInt32_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x0400032F RID: 815
		private static readonly IntPtr NativeMethodInfoPtr_Trim_Private_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000330 RID: 816
		private static readonly IntPtr NativeMethodInfoPtr_FromCapiPrivateKeyBlob_Public_Static_RSA_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000331 RID: 817
		private static readonly IntPtr NativeMethodInfoPtr_FromCapiPrivateKeyBlob_Public_Static_RSA_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04000332 RID: 818
		private static readonly IntPtr NativeMethodInfoPtr_GetParametersFromCapiPrivateKeyBlob_Private_Static_RSAParameters_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04000333 RID: 819
		private static readonly IntPtr NativeMethodInfoPtr_ToHex_Public_Static_String_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000334 RID: 820
		private static readonly IntPtr NativeMethodInfoPtr_FromHexChar_Private_Static_Byte_Char_0;

		// Token: 0x04000335 RID: 821
		private static readonly IntPtr NativeMethodInfoPtr_FromHex_Public_Static_Il2CppStructArray_1_Byte_String_0;
	}
}
