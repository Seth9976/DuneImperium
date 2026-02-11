using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Unity.IO.Compression
{
	// Token: 0x0200006B RID: 107
	public class FastEncoder : Object
	{
		// Token: 0x060007BD RID: 1981 RVA: 0x00032A0C File Offset: 0x00030C0C
		// Note: this type is marked as 'beforefieldinit'.
		static FastEncoder()
		{
			Il2CppClassPointerStore<FastEncoder>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "Unity.IO.Compression", "FastEncoder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FastEncoder>.NativeClassPtr);
			FastEncoder.NativeFieldInfoPtr_inputWindow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastEncoder>.NativeClassPtr, "inputWindow");
			FastEncoder.NativeFieldInfoPtr_currentMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastEncoder>.NativeClassPtr, "currentMatch");
			FastEncoder.NativeFieldInfoPtr_lastCompressionRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastEncoder>.NativeClassPtr, "lastCompressionRatio");
			FastEncoder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastEncoder>.NativeClassPtr, 100664460);
			FastEncoder.NativeMethodInfoPtr_get_BytesInHistory_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastEncoder>.NativeClassPtr, 100664461);
			FastEncoder.NativeMethodInfoPtr_get_UnprocessedInput_Internal_get_DeflateInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastEncoder>.NativeClassPtr, 100664462);
			FastEncoder.NativeMethodInfoPtr_FlushInput_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastEncoder>.NativeClassPtr, 100664463);
			FastEncoder.NativeMethodInfoPtr_get_LastCompressionRatio_Internal_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastEncoder>.NativeClassPtr, 100664464);
			FastEncoder.NativeMethodInfoPtr_GetBlock_Internal_Void_DeflateInput_OutputBuffer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastEncoder>.NativeClassPtr, 100664465);
			FastEncoder.NativeMethodInfoPtr_GetCompressedData_Internal_Void_DeflateInput_OutputBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastEncoder>.NativeClassPtr, 100664466);
			FastEncoder.NativeMethodInfoPtr_GetBlockHeader_Internal_Void_OutputBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastEncoder>.NativeClassPtr, 100664467);
			FastEncoder.NativeMethodInfoPtr_GetBlockFooter_Internal_Void_OutputBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastEncoder>.NativeClassPtr, 100664468);
			FastEncoder.NativeMethodInfoPtr_GetCompressedOutput_Private_Void_DeflateInput_OutputBuffer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastEncoder>.NativeClassPtr, 100664469);
			FastEncoder.NativeMethodInfoPtr_GetCompressedOutput_Private_Void_OutputBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastEncoder>.NativeClassPtr, 100664470);
			FastEncoder.NativeMethodInfoPtr_InputAvailable_Private_Boolean_DeflateInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastEncoder>.NativeClassPtr, 100664471);
			FastEncoder.NativeMethodInfoPtr_SafeToWriteTo_Private_Boolean_OutputBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastEncoder>.NativeClassPtr, 100664472);
			FastEncoder.NativeMethodInfoPtr_WriteEndOfBlock_Private_Void_OutputBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastEncoder>.NativeClassPtr, 100664473);
			FastEncoder.NativeMethodInfoPtr_WriteMatch_Internal_Static_Void_Int32_Int32_OutputBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastEncoder>.NativeClassPtr, 100664474);
			FastEncoder.NativeMethodInfoPtr_WriteChar_Internal_Static_Void_Byte_OutputBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastEncoder>.NativeClassPtr, 100664475);
			FastEncoder.NativeMethodInfoPtr_WriteDeflatePreamble_Internal_Static_Void_OutputBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastEncoder>.NativeClassPtr, 100664476);
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x00032BCC File Offset: 0x00030DCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 861193, XrefRangeEnd = 861205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FastEncoder()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FastEncoder>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastEncoder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x060007BF RID: 1983 RVA: 0x00032C08 File Offset: 0x00030E08
		public unsafe int BytesInHistory
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastEncoder.NativeMethodInfoPtr_get_BytesInHistory_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x060007C0 RID: 1984 RVA: 0x00032C44 File Offset: 0x00030E44
		public unsafe DeflateInput UnprocessedInput
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 861205, XrefRangeEnd = 861210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastEncoder.NativeMethodInfoPtr_get_UnprocessedInput_Internal_get_DeflateInput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DeflateInput>(intPtr3) : null;
			}
		}

		// Token: 0x060007C1 RID: 1985 RVA: 0x00032C84 File Offset: 0x00030E84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 861210, XrefRangeEnd = 861212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FlushInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastEncoder.NativeMethodInfoPtr_FlushInput_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x060007C2 RID: 1986 RVA: 0x00032CB8 File Offset: 0x00030EB8
		public unsafe double LastCompressionRatio
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastEncoder.NativeMethodInfoPtr_get_LastCompressionRatio_Internal_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007C3 RID: 1987 RVA: 0x00032CF4 File Offset: 0x00030EF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 861212, XrefRangeEnd = 861221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetBlock(DeflateInput input, OutputBuffer output, int maxBytesToCopy)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(output);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxBytesToCopy;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastEncoder.NativeMethodInfoPtr_GetBlock_Internal_Void_DeflateInput_OutputBuffer_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x00032D58 File Offset: 0x00030F58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 861221, XrefRangeEnd = 861222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetCompressedData(DeflateInput input, OutputBuffer output)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(output);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastEncoder.NativeMethodInfoPtr_GetCompressedData_Internal_Void_DeflateInput_OutputBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x00032DAC File Offset: 0x00030FAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 861222, XrefRangeEnd = 861223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetBlockHeader(OutputBuffer output)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(output);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastEncoder.NativeMethodInfoPtr_GetBlockHeader_Internal_Void_OutputBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007C6 RID: 1990 RVA: 0x00032DF0 File Offset: 0x00030FF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 861230, RefRangeEnd = 861231, XrefRangeStart = 861223, XrefRangeEnd = 861230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetBlockFooter(OutputBuffer output)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(output);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastEncoder.NativeMethodInfoPtr_GetBlockFooter_Internal_Void_OutputBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x00032E34 File Offset: 0x00031034
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 861243, RefRangeEnd = 861247, XrefRangeStart = 861231, XrefRangeEnd = 861243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetCompressedOutput(DeflateInput input, OutputBuffer output, int maxBytesToCopy)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(output);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxBytesToCopy;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastEncoder.NativeMethodInfoPtr_GetCompressedOutput_Private_Void_DeflateInput_OutputBuffer_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007C8 RID: 1992 RVA: 0x00032E98 File Offset: 0x00031098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 861247, XrefRangeEnd = 861253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetCompressedOutput(OutputBuffer output)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(output);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastEncoder.NativeMethodInfoPtr_GetCompressedOutput_Private_Void_OutputBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x00032EDC File Offset: 0x000310DC
		[CallerCount(0)]
		public unsafe bool InputAvailable(DeflateInput input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastEncoder.NativeMethodInfoPtr_InputAvailable_Private_Boolean_DeflateInput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x00032F2C File Offset: 0x0003112C
		[CallerCount(0)]
		public unsafe bool SafeToWriteTo(OutputBuffer output)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(output);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastEncoder.NativeMethodInfoPtr_SafeToWriteTo_Private_Boolean_OutputBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007CB RID: 1995 RVA: 0x00032F7C File Offset: 0x0003117C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 861230, RefRangeEnd = 861231, XrefRangeStart = 861230, XrefRangeEnd = 861231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteEndOfBlock(OutputBuffer output)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(output);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastEncoder.NativeMethodInfoPtr_WriteEndOfBlock_Private_Void_OutputBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007CC RID: 1996 RVA: 0x00032FC0 File Offset: 0x000311C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 861272, RefRangeEnd = 861274, XrefRangeStart = 861253, XrefRangeEnd = 861272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteMatch(int matchLen, int matchPos, OutputBuffer output)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref matchLen;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref matchPos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(output);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastEncoder.NativeMethodInfoPtr_WriteMatch_Internal_Static_Void_Int32_Int32_OutputBuffer_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x00033014 File Offset: 0x00031214
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 861281, RefRangeEnd = 861285, XrefRangeStart = 861274, XrefRangeEnd = 861281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteChar(byte b, OutputBuffer output)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref b;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(output);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastEncoder.NativeMethodInfoPtr_WriteChar_Internal_Static_Void_Byte_OutputBuffer_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x00033058 File Offset: 0x00031258
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 861295, RefRangeEnd = 861299, XrefRangeStart = 861285, XrefRangeEnd = 861295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteDeflatePreamble(OutputBuffer output)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(output);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastEncoder.NativeMethodInfoPtr_WriteDeflatePreamble_Internal_Static_Void_OutputBuffer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007CF RID: 1999 RVA: 0x000048A0 File Offset: 0x00002AA0
		public FastEncoder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x060007D0 RID: 2000 RVA: 0x00033090 File Offset: 0x00031290
		// (set) Token: 0x060007D1 RID: 2001 RVA: 0x000048A9 File Offset: 0x00002AA9
		public unsafe FastEncoderWindow inputWindow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastEncoder.NativeFieldInfoPtr_inputWindow);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FastEncoderWindow>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastEncoder.NativeFieldInfoPtr_inputWindow), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x060007D2 RID: 2002 RVA: 0x000330C0 File Offset: 0x000312C0
		// (set) Token: 0x060007D3 RID: 2003 RVA: 0x000048C8 File Offset: 0x00002AC8
		public unsafe Match currentMatch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastEncoder.NativeFieldInfoPtr_currentMatch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastEncoder.NativeFieldInfoPtr_currentMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x060007D4 RID: 2004 RVA: 0x000330F0 File Offset: 0x000312F0
		// (set) Token: 0x060007D5 RID: 2005 RVA: 0x000048E7 File Offset: 0x00002AE7
		public unsafe double lastCompressionRatio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastEncoder.NativeFieldInfoPtr_lastCompressionRatio);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastEncoder.NativeFieldInfoPtr_lastCompressionRatio)) = value;
			}
		}

		// Token: 0x040005DA RID: 1498
		private static readonly IntPtr NativeFieldInfoPtr_inputWindow;

		// Token: 0x040005DB RID: 1499
		private static readonly IntPtr NativeFieldInfoPtr_currentMatch;

		// Token: 0x040005DC RID: 1500
		private static readonly IntPtr NativeFieldInfoPtr_lastCompressionRatio;

		// Token: 0x040005DD RID: 1501
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040005DE RID: 1502
		private static readonly IntPtr NativeMethodInfoPtr_get_BytesInHistory_Internal_get_Int32_0;

		// Token: 0x040005DF RID: 1503
		private static readonly IntPtr NativeMethodInfoPtr_get_UnprocessedInput_Internal_get_DeflateInput_0;

		// Token: 0x040005E0 RID: 1504
		private static readonly IntPtr NativeMethodInfoPtr_FlushInput_Internal_Void_0;

		// Token: 0x040005E1 RID: 1505
		private static readonly IntPtr NativeMethodInfoPtr_get_LastCompressionRatio_Internal_get_Double_0;

		// Token: 0x040005E2 RID: 1506
		private static readonly IntPtr NativeMethodInfoPtr_GetBlock_Internal_Void_DeflateInput_OutputBuffer_Int32_0;

		// Token: 0x040005E3 RID: 1507
		private static readonly IntPtr NativeMethodInfoPtr_GetCompressedData_Internal_Void_DeflateInput_OutputBuffer_0;

		// Token: 0x040005E4 RID: 1508
		private static readonly IntPtr NativeMethodInfoPtr_GetBlockHeader_Internal_Void_OutputBuffer_0;

		// Token: 0x040005E5 RID: 1509
		private static readonly IntPtr NativeMethodInfoPtr_GetBlockFooter_Internal_Void_OutputBuffer_0;

		// Token: 0x040005E6 RID: 1510
		private static readonly IntPtr NativeMethodInfoPtr_GetCompressedOutput_Private_Void_DeflateInput_OutputBuffer_Int32_0;

		// Token: 0x040005E7 RID: 1511
		private static readonly IntPtr NativeMethodInfoPtr_GetCompressedOutput_Private_Void_OutputBuffer_0;

		// Token: 0x040005E8 RID: 1512
		private static readonly IntPtr NativeMethodInfoPtr_InputAvailable_Private_Boolean_DeflateInput_0;

		// Token: 0x040005E9 RID: 1513
		private static readonly IntPtr NativeMethodInfoPtr_SafeToWriteTo_Private_Boolean_OutputBuffer_0;

		// Token: 0x040005EA RID: 1514
		private static readonly IntPtr NativeMethodInfoPtr_WriteEndOfBlock_Private_Void_OutputBuffer_0;

		// Token: 0x040005EB RID: 1515
		private static readonly IntPtr NativeMethodInfoPtr_WriteMatch_Internal_Static_Void_Int32_Int32_OutputBuffer_0;

		// Token: 0x040005EC RID: 1516
		private static readonly IntPtr NativeMethodInfoPtr_WriteChar_Internal_Static_Void_Byte_OutputBuffer_0;

		// Token: 0x040005ED RID: 1517
		private static readonly IntPtr NativeMethodInfoPtr_WriteDeflatePreamble_Internal_Static_Void_OutputBuffer_0;
	}
}
