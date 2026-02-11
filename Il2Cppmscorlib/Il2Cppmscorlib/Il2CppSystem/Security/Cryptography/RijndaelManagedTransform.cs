using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x02000257 RID: 599
	public sealed class RijndaelManagedTransform : Object
	{
		// Token: 0x0600269E RID: 9886 RVA: 0x000D3524 File Offset: 0x000D1724
		// Note: this type is marked as 'beforefieldinit'.
		static RijndaelManagedTransform()
		{
			Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "RijndaelManagedTransform");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr);
			RijndaelManagedTransform.NativeFieldInfoPtr_m_cipherMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, "m_cipherMode");
			RijndaelManagedTransform.NativeFieldInfoPtr_m_paddingValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, "m_paddingValue");
			RijndaelManagedTransform.NativeFieldInfoPtr_m_transformMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, "m_transformMode");
			RijndaelManagedTransform.NativeFieldInfoPtr_m_blockSizeBits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, "m_blockSizeBits");
			RijndaelManagedTransform.NativeFieldInfoPtr_m_blockSizeBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, "m_blockSizeBytes");
			RijndaelManagedTransform.NativeFieldInfoPtr_m_inputBlockSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, "m_inputBlockSize");
			RijndaelManagedTransform.NativeFieldInfoPtr_m_outputBlockSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, "m_outputBlockSize");
			RijndaelManagedTransform.NativeFieldInfoPtr_m_encryptKeyExpansion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, "m_encryptKeyExpansion");
			RijndaelManagedTransform.NativeFieldInfoPtr_m_decryptKeyExpansion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, "m_decryptKeyExpansion");
			RijndaelManagedTransform.NativeFieldInfoPtr_m_Nr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, "m_Nr");
			RijndaelManagedTransform.NativeFieldInfoPtr_m_Nb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, "m_Nb");
			RijndaelManagedTransform.NativeFieldInfoPtr_m_Nk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, "m_Nk");
			RijndaelManagedTransform.NativeFieldInfoPtr_m_encryptindex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, "m_encryptindex");
			RijndaelManagedTransform.NativeFieldInfoPtr_m_decryptindex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, "m_decryptindex");
			RijndaelManagedTransform.NativeFieldInfoPtr_m_IV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, "m_IV");
			RijndaelManagedTransform.NativeFieldInfoPtr_m_lastBlockBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, "m_lastBlockBuffer");
			RijndaelManagedTransform.NativeFieldInfoPtr_m_depadBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, "m_depadBuffer");
			RijndaelManagedTransform.NativeFieldInfoPtr_m_shiftRegister = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, "m_shiftRegister");
			RijndaelManagedTransform.NativeFieldInfoPtr_s_Sbox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, "s_Sbox");
			RijndaelManagedTransform.NativeFieldInfoPtr_s_Rcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, "s_Rcon");
			RijndaelManagedTransform.NativeFieldInfoPtr_s_T = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, "s_T");
			RijndaelManagedTransform.NativeFieldInfoPtr_s_TF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, "s_TF");
			RijndaelManagedTransform.NativeFieldInfoPtr_s_iT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, "s_iT");
			RijndaelManagedTransform.NativeFieldInfoPtr_s_iTF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, "s_iTF");
			RijndaelManagedTransform.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStructArray_1_Byte_CipherMode_Il2CppStructArray_1_Byte_Int32_Int32_PaddingMode_RijndaelManagedTransformMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, 100669718);
			RijndaelManagedTransform.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, 100669719);
			RijndaelManagedTransform.NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, 100669720);
			RijndaelManagedTransform.NativeMethodInfoPtr_get_InputBlockSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, 100669721);
			RijndaelManagedTransform.NativeMethodInfoPtr_get_OutputBlockSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, 100669722);
			RijndaelManagedTransform.NativeMethodInfoPtr_get_CanTransformMultipleBlocks_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, 100669723);
			RijndaelManagedTransform.NativeMethodInfoPtr_TransformBlock_Public_Virtual_Final_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, 100669724);
			RijndaelManagedTransform.NativeMethodInfoPtr_TransformFinalBlock_Public_Virtual_Final_New_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, 100669725);
			RijndaelManagedTransform.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, 100669726);
			RijndaelManagedTransform.NativeMethodInfoPtr_EncryptData_Private_Int32_Il2CppStructArray_1_Byte_Int32_Int32_byref_Il2CppStructArray_1_Byte_Int32_PaddingMode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, 100669727);
			RijndaelManagedTransform.NativeMethodInfoPtr_DecryptData_Private_Int32_Il2CppStructArray_1_Byte_Int32_Int32_byref_Il2CppStructArray_1_Byte_Int32_PaddingMode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, 100669728);
			RijndaelManagedTransform.NativeMethodInfoPtr_Enc_Private_Void_ptr_Int32_ptr_Int32_ptr_Int32_ptr_Int32_ptr_Int32_ptr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, 100669729);
			RijndaelManagedTransform.NativeMethodInfoPtr_Dec_Private_Void_ptr_Int32_ptr_Int32_ptr_Int32_ptr_Int32_ptr_Int32_ptr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, 100669730);
			RijndaelManagedTransform.NativeMethodInfoPtr_GenerateKeyExpansion_Private_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, 100669731);
			RijndaelManagedTransform.NativeMethodInfoPtr_rot1_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, 100669732);
			RijndaelManagedTransform.NativeMethodInfoPtr_rot2_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, 100669733);
			RijndaelManagedTransform.NativeMethodInfoPtr_rot3_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, 100669734);
			RijndaelManagedTransform.NativeMethodInfoPtr_SubWord_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, 100669735);
			RijndaelManagedTransform.NativeMethodInfoPtr_MulX_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, 100669736);
		}

		// Token: 0x0600269F RID: 9887 RVA: 0x000D38B0 File Offset: 0x000D1AB0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1372678, RefRangeEnd = 1372681, XrefRangeStart = 1372638, XrefRangeEnd = 1372678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RijndaelManagedTransform(Il2CppStructArray<byte> rgbKey, CipherMode mode, Il2CppStructArray<byte> rgbIV, int blockSize, int feedbackSize, PaddingMode PaddingValue, RijndaelManagedTransformMode transformMode)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgbKey);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rgbIV);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blockSize;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref feedbackSize;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref PaddingValue;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref transformMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RijndaelManagedTransform.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStructArray_1_Byte_CipherMode_Il2CppStructArray_1_Byte_Int32_Int32_PaddingMode_RijndaelManagedTransformMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026A0 RID: 9888 RVA: 0x000D3954 File Offset: 0x000D1B54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1372681, XrefRangeEnd = 1372693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RijndaelManagedTransform.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026A1 RID: 9889 RVA: 0x000D3988 File Offset: 0x000D1B88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1372693, XrefRangeEnd = 1372705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RijndaelManagedTransform.NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170007EA RID: 2026
		// (get) Token: 0x060026A2 RID: 9890 RVA: 0x000D39C8 File Offset: 0x000D1BC8
		public unsafe int InputBlockSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RijndaelManagedTransform.NativeMethodInfoPtr_get_InputBlockSize_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007EB RID: 2027
		// (get) Token: 0x060026A3 RID: 9891 RVA: 0x000D3A04 File Offset: 0x000D1C04
		public unsafe int OutputBlockSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RijndaelManagedTransform.NativeMethodInfoPtr_get_OutputBlockSize_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007EC RID: 2028
		// (get) Token: 0x060026A4 RID: 9892 RVA: 0x000D3A40 File Offset: 0x000D1C40
		public unsafe bool CanTransformMultipleBlocks
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RijndaelManagedTransform.NativeMethodInfoPtr_get_CanTransformMultipleBlocks_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060026A5 RID: 9893 RVA: 0x000D3A7C File Offset: 0x000D1C7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1372705, XrefRangeEnd = 1372709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int TransformBlock(Il2CppStructArray<byte> inputBuffer, int inputOffset, int inputCount, Il2CppStructArray<byte> outputBuffer, int outputOffset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputBuffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputOffset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(outputBuffer);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref outputOffset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RijndaelManagedTransform.NativeMethodInfoPtr_TransformBlock_Public_Virtual_Final_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060026A6 RID: 9894 RVA: 0x000D3B08 File Offset: 0x000D1D08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1372709, XrefRangeEnd = 1372716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> TransformFinalBlock(Il2CppStructArray<byte> inputBuffer, int inputOffset, int inputCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputBuffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputOffset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RijndaelManagedTransform.NativeMethodInfoPtr_TransformFinalBlock_Public_Virtual_Final_New_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x060026A7 RID: 9895 RVA: 0x000D3B74 File Offset: 0x000D1D74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1372719, RefRangeEnd = 1372720, XrefRangeStart = 1372716, XrefRangeEnd = 1372719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RijndaelManagedTransform.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026A8 RID: 9896 RVA: 0x000D3BA8 File Offset: 0x000D1DA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1372720, XrefRangeEnd = 1372766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int EncryptData(Il2CppStructArray<byte> inputBuffer, int inputOffset, int inputCount, ref Il2CppStructArray<byte> outputBuffer, int outputOffset, PaddingMode paddingMode, bool fLast)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputBuffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputOffset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputCount;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(outputBuffer);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref outputOffset;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref paddingMode;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fLast;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RijndaelManagedTransform.NativeMethodInfoPtr_EncryptData_Private_Int32_Il2CppStructArray_1_Byte_Int32_Int32_byref_Il2CppStructArray_1_Byte_Int32_PaddingMode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			outputBuffer = ((intPtr4 == 0) ? null : new Il2CppStructArray<byte>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060026A9 RID: 9897 RVA: 0x000D3C68 File Offset: 0x000D1E68
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1372805, RefRangeEnd = 1372808, XrefRangeStart = 1372766, XrefRangeEnd = 1372805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int DecryptData(Il2CppStructArray<byte> inputBuffer, int inputOffset, int inputCount, ref Il2CppStructArray<byte> outputBuffer, int outputOffset, PaddingMode paddingMode, bool fLast)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputBuffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputOffset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputCount;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(outputBuffer);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref outputOffset;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref paddingMode;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fLast;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RijndaelManagedTransform.NativeMethodInfoPtr_DecryptData_Private_Int32_Il2CppStructArray_1_Byte_Int32_Int32_byref_Il2CppStructArray_1_Byte_Int32_PaddingMode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			outputBuffer = ((intPtr4 == 0) ? null : new Il2CppStructArray<byte>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060026AA RID: 9898 RVA: 0x000D3D28 File Offset: 0x000D1F28
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1372808, RefRangeEnd = 1372810, XrefRangeStart = 1372808, XrefRangeEnd = 1372808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Enc(int* encryptindex, int* encryptKeyExpansion, int* T, int* TF, int* work, int* temp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = encryptindex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = encryptKeyExpansion;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = T;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = TF;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = work;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = temp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RijndaelManagedTransform.NativeMethodInfoPtr_Enc_Private_Void_ptr_Int32_ptr_Int32_ptr_Int32_ptr_Int32_ptr_Int32_ptr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026AB RID: 9899 RVA: 0x000D3DAC File Offset: 0x000D1FAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1372810, RefRangeEnd = 1372811, XrefRangeStart = 1372810, XrefRangeEnd = 1372810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dec(int* decryptindex, int* decryptKeyExpansion, int* iT, int* iTF, int* work, int* temp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = decryptindex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = decryptKeyExpansion;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = iT;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = iTF;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = work;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = temp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RijndaelManagedTransform.NativeMethodInfoPtr_Dec_Private_Void_ptr_Int32_ptr_Int32_ptr_Int32_ptr_Int32_ptr_Int32_ptr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026AC RID: 9900 RVA: 0x000D3E30 File Offset: 0x000D2030
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1372837, RefRangeEnd = 1372838, XrefRangeStart = 1372811, XrefRangeEnd = 1372837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateKeyExpansion(Il2CppStructArray<byte> rgbKey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgbKey);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RijndaelManagedTransform.NativeMethodInfoPtr_GenerateKeyExpansion_Private_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060026AD RID: 9901 RVA: 0x000D3E74 File Offset: 0x000D2074
		[CallerCount(0)]
		public unsafe static int rot1(int val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RijndaelManagedTransform.NativeMethodInfoPtr_rot1_Private_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060026AE RID: 9902 RVA: 0x000D3EB4 File Offset: 0x000D20B4
		[CallerCount(0)]
		public unsafe static int rot2(int val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RijndaelManagedTransform.NativeMethodInfoPtr_rot2_Private_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060026AF RID: 9903 RVA: 0x000D3EF4 File Offset: 0x000D20F4
		[CallerCount(0)]
		public unsafe static int rot3(int val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RijndaelManagedTransform.NativeMethodInfoPtr_rot3_Private_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060026B0 RID: 9904 RVA: 0x000D3F34 File Offset: 0x000D2134
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1372842, RefRangeEnd = 1372845, XrefRangeStart = 1372838, XrefRangeEnd = 1372842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int SubWord(int a)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RijndaelManagedTransform.NativeMethodInfoPtr_SubWord_Private_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060026B1 RID: 9905 RVA: 0x000D3F74 File Offset: 0x000D2174
		[CallerCount(0)]
		public unsafe static int MulX(int x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RijndaelManagedTransform.NativeMethodInfoPtr_MulX_Private_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060026B2 RID: 9906 RVA: 0x0000C85E File Offset: 0x0000AA5E
		public RijndaelManagedTransform(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007D2 RID: 2002
		// (get) Token: 0x060026B3 RID: 9907 RVA: 0x000D3FB4 File Offset: 0x000D21B4
		// (set) Token: 0x060026B4 RID: 9908 RVA: 0x0000C867 File Offset: 0x0000AA67
		public unsafe CipherMode m_cipherMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_cipherMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_cipherMode)) = value;
			}
		}

		// Token: 0x170007D3 RID: 2003
		// (get) Token: 0x060026B5 RID: 9909 RVA: 0x000D3FDC File Offset: 0x000D21DC
		// (set) Token: 0x060026B6 RID: 9910 RVA: 0x0000C882 File Offset: 0x0000AA82
		public unsafe PaddingMode m_paddingValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_paddingValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_paddingValue)) = value;
			}
		}

		// Token: 0x170007D4 RID: 2004
		// (get) Token: 0x060026B7 RID: 9911 RVA: 0x000D4004 File Offset: 0x000D2204
		// (set) Token: 0x060026B8 RID: 9912 RVA: 0x0000C89D File Offset: 0x0000AA9D
		public unsafe RijndaelManagedTransformMode m_transformMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_transformMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_transformMode)) = value;
			}
		}

		// Token: 0x170007D5 RID: 2005
		// (get) Token: 0x060026B9 RID: 9913 RVA: 0x000D402C File Offset: 0x000D222C
		// (set) Token: 0x060026BA RID: 9914 RVA: 0x0000C8B8 File Offset: 0x0000AAB8
		public unsafe int m_blockSizeBits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_blockSizeBits);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_blockSizeBits)) = value;
			}
		}

		// Token: 0x170007D6 RID: 2006
		// (get) Token: 0x060026BB RID: 9915 RVA: 0x000D4054 File Offset: 0x000D2254
		// (set) Token: 0x060026BC RID: 9916 RVA: 0x0000C8D3 File Offset: 0x0000AAD3
		public unsafe int m_blockSizeBytes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_blockSizeBytes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_blockSizeBytes)) = value;
			}
		}

		// Token: 0x170007D7 RID: 2007
		// (get) Token: 0x060026BD RID: 9917 RVA: 0x000D407C File Offset: 0x000D227C
		// (set) Token: 0x060026BE RID: 9918 RVA: 0x0000C8EE File Offset: 0x0000AAEE
		public unsafe int m_inputBlockSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_inputBlockSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_inputBlockSize)) = value;
			}
		}

		// Token: 0x170007D8 RID: 2008
		// (get) Token: 0x060026BF RID: 9919 RVA: 0x000D40A4 File Offset: 0x000D22A4
		// (set) Token: 0x060026C0 RID: 9920 RVA: 0x0000C909 File Offset: 0x0000AB09
		public unsafe int m_outputBlockSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_outputBlockSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_outputBlockSize)) = value;
			}
		}

		// Token: 0x170007D9 RID: 2009
		// (get) Token: 0x060026C1 RID: 9921 RVA: 0x000D40CC File Offset: 0x000D22CC
		// (set) Token: 0x060026C2 RID: 9922 RVA: 0x0000C924 File Offset: 0x0000AB24
		public unsafe Il2CppStructArray<int> m_encryptKeyExpansion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_encryptKeyExpansion);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_encryptKeyExpansion), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007DA RID: 2010
		// (get) Token: 0x060026C3 RID: 9923 RVA: 0x000D40FC File Offset: 0x000D22FC
		// (set) Token: 0x060026C4 RID: 9924 RVA: 0x0000C943 File Offset: 0x0000AB43
		public unsafe Il2CppStructArray<int> m_decryptKeyExpansion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_decryptKeyExpansion);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_decryptKeyExpansion), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007DB RID: 2011
		// (get) Token: 0x060026C5 RID: 9925 RVA: 0x000D412C File Offset: 0x000D232C
		// (set) Token: 0x060026C6 RID: 9926 RVA: 0x0000C962 File Offset: 0x0000AB62
		public unsafe int m_Nr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_Nr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_Nr)) = value;
			}
		}

		// Token: 0x170007DC RID: 2012
		// (get) Token: 0x060026C7 RID: 9927 RVA: 0x000D4154 File Offset: 0x000D2354
		// (set) Token: 0x060026C8 RID: 9928 RVA: 0x0000C97D File Offset: 0x0000AB7D
		public unsafe int m_Nb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_Nb);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_Nb)) = value;
			}
		}

		// Token: 0x170007DD RID: 2013
		// (get) Token: 0x060026C9 RID: 9929 RVA: 0x000D417C File Offset: 0x000D237C
		// (set) Token: 0x060026CA RID: 9930 RVA: 0x0000C998 File Offset: 0x0000AB98
		public unsafe int m_Nk
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_Nk);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_Nk)) = value;
			}
		}

		// Token: 0x170007DE RID: 2014
		// (get) Token: 0x060026CB RID: 9931 RVA: 0x000D41A4 File Offset: 0x000D23A4
		// (set) Token: 0x060026CC RID: 9932 RVA: 0x0000C9B3 File Offset: 0x0000ABB3
		public unsafe Il2CppStructArray<int> m_encryptindex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_encryptindex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_encryptindex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007DF RID: 2015
		// (get) Token: 0x060026CD RID: 9933 RVA: 0x000D41D4 File Offset: 0x000D23D4
		// (set) Token: 0x060026CE RID: 9934 RVA: 0x0000C9D2 File Offset: 0x0000ABD2
		public unsafe Il2CppStructArray<int> m_decryptindex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_decryptindex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_decryptindex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007E0 RID: 2016
		// (get) Token: 0x060026CF RID: 9935 RVA: 0x000D4204 File Offset: 0x000D2404
		// (set) Token: 0x060026D0 RID: 9936 RVA: 0x0000C9F1 File Offset: 0x0000ABF1
		public unsafe Il2CppStructArray<int> m_IV
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_IV);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_IV), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007E1 RID: 2017
		// (get) Token: 0x060026D1 RID: 9937 RVA: 0x000D4234 File Offset: 0x000D2434
		// (set) Token: 0x060026D2 RID: 9938 RVA: 0x0000CA10 File Offset: 0x0000AC10
		public unsafe Il2CppStructArray<int> m_lastBlockBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_lastBlockBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_lastBlockBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007E2 RID: 2018
		// (get) Token: 0x060026D3 RID: 9939 RVA: 0x000D4264 File Offset: 0x000D2464
		// (set) Token: 0x060026D4 RID: 9940 RVA: 0x0000CA2F File Offset: 0x0000AC2F
		public unsafe Il2CppStructArray<byte> m_depadBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_depadBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_depadBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007E3 RID: 2019
		// (get) Token: 0x060026D5 RID: 9941 RVA: 0x000D4294 File Offset: 0x000D2494
		// (set) Token: 0x060026D6 RID: 9942 RVA: 0x0000CA4E File Offset: 0x0000AC4E
		public unsafe Il2CppStructArray<byte> m_shiftRegister
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_shiftRegister);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_shiftRegister), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007E4 RID: 2020
		// (get) Token: 0x060026D7 RID: 9943 RVA: 0x000D42C4 File Offset: 0x000D24C4
		// (set) Token: 0x060026D8 RID: 9944 RVA: 0x0000CA6D File Offset: 0x0000AC6D
		public unsafe static Il2CppStructArray<byte> s_Sbox
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RijndaelManagedTransform.NativeFieldInfoPtr_s_Sbox, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RijndaelManagedTransform.NativeFieldInfoPtr_s_Sbox, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007E5 RID: 2021
		// (get) Token: 0x060026D9 RID: 9945 RVA: 0x000D42EC File Offset: 0x000D24EC
		// (set) Token: 0x060026DA RID: 9946 RVA: 0x0000CA7F File Offset: 0x0000AC7F
		public unsafe static Il2CppStructArray<int> s_Rcon
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RijndaelManagedTransform.NativeFieldInfoPtr_s_Rcon, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RijndaelManagedTransform.NativeFieldInfoPtr_s_Rcon, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007E6 RID: 2022
		// (get) Token: 0x060026DB RID: 9947 RVA: 0x000D4314 File Offset: 0x000D2514
		// (set) Token: 0x060026DC RID: 9948 RVA: 0x0000CA91 File Offset: 0x0000AC91
		public unsafe static Il2CppStructArray<int> s_T
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RijndaelManagedTransform.NativeFieldInfoPtr_s_T, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RijndaelManagedTransform.NativeFieldInfoPtr_s_T, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007E7 RID: 2023
		// (get) Token: 0x060026DD RID: 9949 RVA: 0x000D433C File Offset: 0x000D253C
		// (set) Token: 0x060026DE RID: 9950 RVA: 0x0000CAA3 File Offset: 0x0000ACA3
		public unsafe static Il2CppStructArray<int> s_TF
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RijndaelManagedTransform.NativeFieldInfoPtr_s_TF, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RijndaelManagedTransform.NativeFieldInfoPtr_s_TF, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007E8 RID: 2024
		// (get) Token: 0x060026DF RID: 9951 RVA: 0x000D4364 File Offset: 0x000D2564
		// (set) Token: 0x060026E0 RID: 9952 RVA: 0x0000CAB5 File Offset: 0x0000ACB5
		public unsafe static Il2CppStructArray<int> s_iT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RijndaelManagedTransform.NativeFieldInfoPtr_s_iT, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RijndaelManagedTransform.NativeFieldInfoPtr_s_iT, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007E9 RID: 2025
		// (get) Token: 0x060026E1 RID: 9953 RVA: 0x000D438C File Offset: 0x000D258C
		// (set) Token: 0x060026E2 RID: 9954 RVA: 0x0000CAC7 File Offset: 0x0000ACC7
		public unsafe static Il2CppStructArray<int> s_iTF
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RijndaelManagedTransform.NativeFieldInfoPtr_s_iTF, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RijndaelManagedTransform.NativeFieldInfoPtr_s_iTF, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002164 RID: 8548
		private static readonly IntPtr NativeFieldInfoPtr_m_cipherMode;

		// Token: 0x04002165 RID: 8549
		private static readonly IntPtr NativeFieldInfoPtr_m_paddingValue;

		// Token: 0x04002166 RID: 8550
		private static readonly IntPtr NativeFieldInfoPtr_m_transformMode;

		// Token: 0x04002167 RID: 8551
		private static readonly IntPtr NativeFieldInfoPtr_m_blockSizeBits;

		// Token: 0x04002168 RID: 8552
		private static readonly IntPtr NativeFieldInfoPtr_m_blockSizeBytes;

		// Token: 0x04002169 RID: 8553
		private static readonly IntPtr NativeFieldInfoPtr_m_inputBlockSize;

		// Token: 0x0400216A RID: 8554
		private static readonly IntPtr NativeFieldInfoPtr_m_outputBlockSize;

		// Token: 0x0400216B RID: 8555
		private static readonly IntPtr NativeFieldInfoPtr_m_encryptKeyExpansion;

		// Token: 0x0400216C RID: 8556
		private static readonly IntPtr NativeFieldInfoPtr_m_decryptKeyExpansion;

		// Token: 0x0400216D RID: 8557
		private static readonly IntPtr NativeFieldInfoPtr_m_Nr;

		// Token: 0x0400216E RID: 8558
		private static readonly IntPtr NativeFieldInfoPtr_m_Nb;

		// Token: 0x0400216F RID: 8559
		private static readonly IntPtr NativeFieldInfoPtr_m_Nk;

		// Token: 0x04002170 RID: 8560
		private static readonly IntPtr NativeFieldInfoPtr_m_encryptindex;

		// Token: 0x04002171 RID: 8561
		private static readonly IntPtr NativeFieldInfoPtr_m_decryptindex;

		// Token: 0x04002172 RID: 8562
		private static readonly IntPtr NativeFieldInfoPtr_m_IV;

		// Token: 0x04002173 RID: 8563
		private static readonly IntPtr NativeFieldInfoPtr_m_lastBlockBuffer;

		// Token: 0x04002174 RID: 8564
		private static readonly IntPtr NativeFieldInfoPtr_m_depadBuffer;

		// Token: 0x04002175 RID: 8565
		private static readonly IntPtr NativeFieldInfoPtr_m_shiftRegister;

		// Token: 0x04002176 RID: 8566
		private static readonly IntPtr NativeFieldInfoPtr_s_Sbox;

		// Token: 0x04002177 RID: 8567
		private static readonly IntPtr NativeFieldInfoPtr_s_Rcon;

		// Token: 0x04002178 RID: 8568
		private static readonly IntPtr NativeFieldInfoPtr_s_T;

		// Token: 0x04002179 RID: 8569
		private static readonly IntPtr NativeFieldInfoPtr_s_TF;

		// Token: 0x0400217A RID: 8570
		private static readonly IntPtr NativeFieldInfoPtr_s_iT;

		// Token: 0x0400217B RID: 8571
		private static readonly IntPtr NativeFieldInfoPtr_s_iTF;

		// Token: 0x0400217C RID: 8572
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStructArray_1_Byte_CipherMode_Il2CppStructArray_1_Byte_Int32_Int32_PaddingMode_RijndaelManagedTransformMode_0;

		// Token: 0x0400217D RID: 8573
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400217E RID: 8574
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0;

		// Token: 0x0400217F RID: 8575
		private static readonly IntPtr NativeMethodInfoPtr_get_InputBlockSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04002180 RID: 8576
		private static readonly IntPtr NativeMethodInfoPtr_get_OutputBlockSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04002181 RID: 8577
		private static readonly IntPtr NativeMethodInfoPtr_get_CanTransformMultipleBlocks_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04002182 RID: 8578
		private static readonly IntPtr NativeMethodInfoPtr_TransformBlock_Public_Virtual_Final_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04002183 RID: 8579
		private static readonly IntPtr NativeMethodInfoPtr_TransformFinalBlock_Public_Virtual_Final_New_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04002184 RID: 8580
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

		// Token: 0x04002185 RID: 8581
		private static readonly IntPtr NativeMethodInfoPtr_EncryptData_Private_Int32_Il2CppStructArray_1_Byte_Int32_Int32_byref_Il2CppStructArray_1_Byte_Int32_PaddingMode_Boolean_0;

		// Token: 0x04002186 RID: 8582
		private static readonly IntPtr NativeMethodInfoPtr_DecryptData_Private_Int32_Il2CppStructArray_1_Byte_Int32_Int32_byref_Il2CppStructArray_1_Byte_Int32_PaddingMode_Boolean_0;

		// Token: 0x04002187 RID: 8583
		private static readonly IntPtr NativeMethodInfoPtr_Enc_Private_Void_ptr_Int32_ptr_Int32_ptr_Int32_ptr_Int32_ptr_Int32_ptr_Int32_0;

		// Token: 0x04002188 RID: 8584
		private static readonly IntPtr NativeMethodInfoPtr_Dec_Private_Void_ptr_Int32_ptr_Int32_ptr_Int32_ptr_Int32_ptr_Int32_ptr_Int32_0;

		// Token: 0x04002189 RID: 8585
		private static readonly IntPtr NativeMethodInfoPtr_GenerateKeyExpansion_Private_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400218A RID: 8586
		private static readonly IntPtr NativeMethodInfoPtr_rot1_Private_Static_Int32_Int32_0;

		// Token: 0x0400218B RID: 8587
		private static readonly IntPtr NativeMethodInfoPtr_rot2_Private_Static_Int32_Int32_0;

		// Token: 0x0400218C RID: 8588
		private static readonly IntPtr NativeMethodInfoPtr_rot3_Private_Static_Int32_Int32_0;

		// Token: 0x0400218D RID: 8589
		private static readonly IntPtr NativeMethodInfoPtr_SubWord_Private_Static_Int32_Int32_0;

		// Token: 0x0400218E RID: 8590
		private static readonly IntPtr NativeMethodInfoPtr_MulX_Private_Static_Int32_Int32_0;
	}
}
