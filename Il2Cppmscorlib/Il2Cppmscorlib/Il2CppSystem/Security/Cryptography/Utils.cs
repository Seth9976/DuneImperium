using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x0200026F RID: 623
	public static class Utils : Object
	{
		// Token: 0x0600281C RID: 10268 RVA: 0x000D8D38 File Offset: 0x000D6F38
		// Note: this type is marked as 'beforefieldinit'.
		static Utils()
		{
			Il2CppClassPointerStore<Utils>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "Utils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Utils>.NativeClassPtr);
			Utils.NativeFieldInfoPtr__rng = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utils>.NativeClassPtr, "_rng");
			Utils.NativeMethodInfoPtr_get_StaticRandomNumberGenerator_Internal_Static_get_RNGCryptoServiceProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100669900);
			Utils.NativeMethodInfoPtr_GenerateRandom_Internal_Static_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100669901);
			Utils.NativeMethodInfoPtr_HasAlgorithm_Internal_Static_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100669902);
			Utils.NativeMethodInfoPtr_DiscardWhiteSpaces_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100669903);
			Utils.NativeMethodInfoPtr_DiscardWhiteSpaces_Internal_Static_String_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100669904);
			Utils.NativeMethodInfoPtr_ConvertByteArrayToInt_Internal_Static_Int32_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100669905);
			Utils.NativeMethodInfoPtr_ConvertIntToByteArray_Internal_Static_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100669906);
			Utils.NativeMethodInfoPtr_FixupKeyParity_Internal_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100669907);
			Utils.NativeMethodInfoPtr_DWORDFromLittleEndian_Internal_Static_Void_ptr_UInt32_Int32_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100669908);
			Utils.NativeMethodInfoPtr_DWORDToLittleEndian_Internal_Static_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100669909);
			Utils.NativeMethodInfoPtr_DWORDFromBigEndian_Internal_Static_Void_ptr_UInt32_Int32_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100669910);
			Utils.NativeMethodInfoPtr_DWORDToBigEndian_Internal_Static_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100669911);
			Utils.NativeMethodInfoPtr_QuadWordFromBigEndian_Internal_Static_Void_ptr_UInt64_Int32_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100669912);
			Utils.NativeMethodInfoPtr_QuadWordToBigEndian_Internal_Static_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_UInt64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100669913);
			Utils.NativeMethodInfoPtr__ProduceLegacyHmacValues_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100669914);
		}

		// Token: 0x17000834 RID: 2100
		// (get) Token: 0x0600281D RID: 10269 RVA: 0x000D8EA8 File Offset: 0x000D70A8
		public unsafe static RNGCryptoServiceProvider StaticRandomNumberGenerator
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 1374061, RefRangeEnd = 1374070, XrefRangeStart = 1374048, XrefRangeEnd = 1374061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_get_StaticRandomNumberGenerator_Internal_Static_get_RNGCryptoServiceProvider_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RNGCryptoServiceProvider>(intPtr3) : null;
			}
		}

		// Token: 0x0600281E RID: 10270 RVA: 0x000D8EDC File Offset: 0x000D70DC
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 1374074, RefRangeEnd = 1374089, XrefRangeStart = 1374070, XrefRangeEnd = 1374074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> GenerateRandom(int keySize)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keySize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_GenerateRandom_Internal_Static_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x0600281F RID: 10271 RVA: 0x000D8F1C File Offset: 0x000D711C
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasAlgorithm(int dwCalg, int dwKeySize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dwCalg;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dwKeySize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_HasAlgorithm_Internal_Static_Boolean_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002820 RID: 10272 RVA: 0x000D8F68 File Offset: 0x000D7168
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1374091, RefRangeEnd = 1374099, XrefRangeStart = 1374089, XrefRangeEnd = 1374091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string DiscardWhiteSpaces(string inputBuffer)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(inputBuffer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_DiscardWhiteSpaces_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002821 RID: 10273 RVA: 0x000D8FA4 File Offset: 0x000D71A4
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1374118, RefRangeEnd = 1374127, XrefRangeStart = 1374099, XrefRangeEnd = 1374118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string DiscardWhiteSpaces(string inputBuffer, int inputOffset, int inputCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(inputBuffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputOffset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_DiscardWhiteSpaces_Internal_Static_String_String_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002822 RID: 10274 RVA: 0x000D8FFC File Offset: 0x000D71FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1374128, RefRangeEnd = 1374129, XrefRangeStart = 1374127, XrefRangeEnd = 1374128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ConvertByteArrayToInt(Il2CppStructArray<byte> input)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_ConvertByteArrayToInt_Internal_Static_Int32_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002823 RID: 10275 RVA: 0x000D9040 File Offset: 0x000D7240
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1374137, RefRangeEnd = 1374138, XrefRangeStart = 1374129, XrefRangeEnd = 1374137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> ConvertIntToByteArray(int dwInput)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dwInput;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_ConvertIntToByteArray_Internal_Static_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06002824 RID: 10276 RVA: 0x000D9080 File Offset: 0x000D7280
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1374142, RefRangeEnd = 1374144, XrefRangeStart = 1374138, XrefRangeEnd = 1374142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> FixupKeyParity(Il2CppStructArray<byte> key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_FixupKeyParity_Internal_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06002825 RID: 10277 RVA: 0x000D90C4 File Offset: 0x000D72C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1374144, RefRangeEnd = 1374145, XrefRangeStart = 1374144, XrefRangeEnd = 1374144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DWORDFromLittleEndian(uint* x, int digits, byte* block)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref digits;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = block;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_DWORDFromLittleEndian_Internal_Static_Void_ptr_UInt32_Int32_ptr_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002826 RID: 10278 RVA: 0x000D9110 File Offset: 0x000D7310
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1374145, RefRangeEnd = 1374146, XrefRangeStart = 1374145, XrefRangeEnd = 1374145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DWORDToLittleEndian(Il2CppStructArray<byte> block, Il2CppStructArray<uint> x, int digits)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(block);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(x);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref digits;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_DWORDToLittleEndian_Internal_Static_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_UInt32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002827 RID: 10279 RVA: 0x000D9168 File Offset: 0x000D7368
		[CallerCount(0)]
		public unsafe static void DWORDFromBigEndian(uint* x, int digits, byte* block)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref digits;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = block;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_DWORDFromBigEndian_Internal_Static_Void_ptr_UInt32_Int32_ptr_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002828 RID: 10280 RVA: 0x000D91B4 File Offset: 0x000D73B4
		[CallerCount(0)]
		public unsafe static void DWORDToBigEndian(Il2CppStructArray<byte> block, Il2CppStructArray<uint> x, int digits)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(block);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(x);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref digits;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_DWORDToBigEndian_Internal_Static_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_UInt32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002829 RID: 10281 RVA: 0x000D920C File Offset: 0x000D740C
		[CallerCount(0)]
		public unsafe static void QuadWordFromBigEndian(ulong* x, int digits, byte* block)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref digits;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = block;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_QuadWordFromBigEndian_Internal_Static_Void_ptr_UInt64_Int32_ptr_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600282A RID: 10282 RVA: 0x000D9258 File Offset: 0x000D7458
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1374146, RefRangeEnd = 1374148, XrefRangeStart = 1374146, XrefRangeEnd = 1374146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void QuadWordToBigEndian(Il2CppStructArray<byte> block, Il2CppStructArray<ulong> x, int digits)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(block);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(x);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref digits;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_QuadWordToBigEndian_Internal_Static_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_UInt64_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600282B RID: 10283 RVA: 0x000D92B0 File Offset: 0x000D74B0
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _ProduceLegacyHmacValues()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr__ProduceLegacyHmacValues_Internal_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600282C RID: 10284 RVA: 0x0000D2D7 File Offset: 0x0000B4D7
		public Utils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000833 RID: 2099
		// (get) Token: 0x0600282D RID: 10285 RVA: 0x000D92E0 File Offset: 0x000D74E0
		// (set) Token: 0x0600282E RID: 10286 RVA: 0x0000D2E0 File Offset: 0x0000B4E0
		public unsafe static RNGCryptoServiceProvider _rng
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Utils.NativeFieldInfoPtr__rng, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RNGCryptoServiceProvider>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Utils.NativeFieldInfoPtr__rng, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002263 RID: 8803
		private static readonly IntPtr NativeFieldInfoPtr__rng;

		// Token: 0x04002264 RID: 8804
		private static readonly IntPtr NativeMethodInfoPtr_get_StaticRandomNumberGenerator_Internal_Static_get_RNGCryptoServiceProvider_0;

		// Token: 0x04002265 RID: 8805
		private static readonly IntPtr NativeMethodInfoPtr_GenerateRandom_Internal_Static_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04002266 RID: 8806
		private static readonly IntPtr NativeMethodInfoPtr_HasAlgorithm_Internal_Static_Boolean_Int32_Int32_0;

		// Token: 0x04002267 RID: 8807
		private static readonly IntPtr NativeMethodInfoPtr_DiscardWhiteSpaces_Internal_Static_String_String_0;

		// Token: 0x04002268 RID: 8808
		private static readonly IntPtr NativeMethodInfoPtr_DiscardWhiteSpaces_Internal_Static_String_String_Int32_Int32_0;

		// Token: 0x04002269 RID: 8809
		private static readonly IntPtr NativeMethodInfoPtr_ConvertByteArrayToInt_Internal_Static_Int32_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400226A RID: 8810
		private static readonly IntPtr NativeMethodInfoPtr_ConvertIntToByteArray_Internal_Static_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x0400226B RID: 8811
		private static readonly IntPtr NativeMethodInfoPtr_FixupKeyParity_Internal_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400226C RID: 8812
		private static readonly IntPtr NativeMethodInfoPtr_DWORDFromLittleEndian_Internal_Static_Void_ptr_UInt32_Int32_ptr_Byte_0;

		// Token: 0x0400226D RID: 8813
		private static readonly IntPtr NativeMethodInfoPtr_DWORDToLittleEndian_Internal_Static_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_UInt32_Int32_0;

		// Token: 0x0400226E RID: 8814
		private static readonly IntPtr NativeMethodInfoPtr_DWORDFromBigEndian_Internal_Static_Void_ptr_UInt32_Int32_ptr_Byte_0;

		// Token: 0x0400226F RID: 8815
		private static readonly IntPtr NativeMethodInfoPtr_DWORDToBigEndian_Internal_Static_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_UInt32_Int32_0;

		// Token: 0x04002270 RID: 8816
		private static readonly IntPtr NativeMethodInfoPtr_QuadWordFromBigEndian_Internal_Static_Void_ptr_UInt64_Int32_ptr_Byte_0;

		// Token: 0x04002271 RID: 8817
		private static readonly IntPtr NativeMethodInfoPtr_QuadWordToBigEndian_Internal_Static_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_UInt64_Int32_0;

		// Token: 0x04002272 RID: 8818
		private static readonly IntPtr NativeMethodInfoPtr__ProduceLegacyHmacValues_Internal_Static_Boolean_0;
	}
}
