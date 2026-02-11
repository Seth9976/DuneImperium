using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Unity.IO.Compression
{
	// Token: 0x02000076 RID: 118
	public class Inflater : Object
	{
		// Token: 0x060008B8 RID: 2232 RVA: 0x00035BB0 File Offset: 0x00033DB0
		// Note: this type is marked as 'beforefieldinit'.
		static Inflater()
		{
			Il2CppClassPointerStore<Inflater>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "Unity.IO.Compression", "Inflater");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Inflater>.NativeClassPtr);
			Inflater.NativeFieldInfoPtr_extraLengthBits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Inflater>.NativeClassPtr, "extraLengthBits");
			Inflater.NativeFieldInfoPtr_lengthBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Inflater>.NativeClassPtr, "lengthBase");
			Inflater.NativeFieldInfoPtr_distanceBasePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Inflater>.NativeClassPtr, "distanceBasePosition");
			Inflater.NativeFieldInfoPtr_codeOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Inflater>.NativeClassPtr, "codeOrder");
			Inflater.NativeFieldInfoPtr_staticDistanceTreeTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Inflater>.NativeClassPtr, "staticDistanceTreeTable");
			Inflater.NativeFieldInfoPtr_output = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Inflater>.NativeClassPtr, "output");
			Inflater.NativeFieldInfoPtr_input = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Inflater>.NativeClassPtr, "input");
			Inflater.NativeFieldInfoPtr_literalLengthTree = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Inflater>.NativeClassPtr, "literalLengthTree");
			Inflater.NativeFieldInfoPtr_distanceTree = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Inflater>.NativeClassPtr, "distanceTree");
			Inflater.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Inflater>.NativeClassPtr, "state");
			Inflater.NativeFieldInfoPtr_hasFormatReader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Inflater>.NativeClassPtr, "hasFormatReader");
			Inflater.NativeFieldInfoPtr_bfinal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Inflater>.NativeClassPtr, "bfinal");
			Inflater.NativeFieldInfoPtr_blockType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Inflater>.NativeClassPtr, "blockType");
			Inflater.NativeFieldInfoPtr_blockLengthBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Inflater>.NativeClassPtr, "blockLengthBuffer");
			Inflater.NativeFieldInfoPtr_blockLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Inflater>.NativeClassPtr, "blockLength");
			Inflater.NativeFieldInfoPtr_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Inflater>.NativeClassPtr, "length");
			Inflater.NativeFieldInfoPtr_distanceCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Inflater>.NativeClassPtr, "distanceCode");
			Inflater.NativeFieldInfoPtr_extraBits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Inflater>.NativeClassPtr, "extraBits");
			Inflater.NativeFieldInfoPtr_loopCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Inflater>.NativeClassPtr, "loopCounter");
			Inflater.NativeFieldInfoPtr_literalLengthCodeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Inflater>.NativeClassPtr, "literalLengthCodeCount");
			Inflater.NativeFieldInfoPtr_distanceCodeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Inflater>.NativeClassPtr, "distanceCodeCount");
			Inflater.NativeFieldInfoPtr_codeLengthCodeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Inflater>.NativeClassPtr, "codeLengthCodeCount");
			Inflater.NativeFieldInfoPtr_codeArraySize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Inflater>.NativeClassPtr, "codeArraySize");
			Inflater.NativeFieldInfoPtr_lengthCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Inflater>.NativeClassPtr, "lengthCode");
			Inflater.NativeFieldInfoPtr_codeList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Inflater>.NativeClassPtr, "codeList");
			Inflater.NativeFieldInfoPtr_codeLengthTreeCodeLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Inflater>.NativeClassPtr, "codeLengthTreeCodeLength");
			Inflater.NativeFieldInfoPtr_codeLengthTree = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Inflater>.NativeClassPtr, "codeLengthTree");
			Inflater.NativeFieldInfoPtr_formatReader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Inflater>.NativeClassPtr, "formatReader");
			Inflater.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Inflater>.NativeClassPtr, 100664547);
			Inflater.NativeMethodInfoPtr_SetFileFormatReader_Internal_Void_IFileFormatReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Inflater>.NativeClassPtr, 100664548);
			Inflater.NativeMethodInfoPtr_Reset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Inflater>.NativeClassPtr, 100664549);
			Inflater.NativeMethodInfoPtr_SetInput_Public_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Inflater>.NativeClassPtr, 100664550);
			Inflater.NativeMethodInfoPtr_Finished_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Inflater>.NativeClassPtr, 100664551);
			Inflater.NativeMethodInfoPtr_get_AvailableOutput_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Inflater>.NativeClassPtr, 100664552);
			Inflater.NativeMethodInfoPtr_NeedsInput_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Inflater>.NativeClassPtr, 100664553);
			Inflater.NativeMethodInfoPtr_Inflate_Public_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Inflater>.NativeClassPtr, 100664554);
			Inflater.NativeMethodInfoPtr_Decode_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Inflater>.NativeClassPtr, 100664555);
			Inflater.NativeMethodInfoPtr_DecodeUncompressedBlock_Private_Boolean_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Inflater>.NativeClassPtr, 100664556);
			Inflater.NativeMethodInfoPtr_DecodeBlock_Private_Boolean_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Inflater>.NativeClassPtr, 100664557);
			Inflater.NativeMethodInfoPtr_DecodeDynamicBlockHeader_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Inflater>.NativeClassPtr, 100664558);
		}

		// Token: 0x060008B9 RID: 2233 RVA: 0x00035F00 File Offset: 0x00034100
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 861567, XrefRangeEnd = 861592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Inflater()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Inflater>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Inflater.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008BA RID: 2234 RVA: 0x00035F3C File Offset: 0x0003413C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 861592, XrefRangeEnd = 861593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFileFormatReader(IFileFormatReader reader)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Inflater.NativeMethodInfoPtr_SetFileFormatReader_Internal_Void_IFileFormatReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008BB RID: 2235 RVA: 0x00035F80 File Offset: 0x00034180
		[CallerCount(0)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Inflater.NativeMethodInfoPtr_Reset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008BC RID: 2236 RVA: 0x00035FB4 File Offset: 0x000341B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 861593, XrefRangeEnd = 861594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInput(Il2CppStructArray<byte> inputBytes, int offset, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputBytes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Inflater.NativeMethodInfoPtr_SetInput_Public_Void_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008BD RID: 2237 RVA: 0x00036014 File Offset: 0x00034214
		[CallerCount(0)]
		public unsafe bool Finished()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Inflater.NativeMethodInfoPtr_Finished_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x060008BE RID: 2238 RVA: 0x00036050 File Offset: 0x00034250
		public unsafe int AvailableOutput
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Inflater.NativeMethodInfoPtr_get_AvailableOutput_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008BF RID: 2239 RVA: 0x0003608C File Offset: 0x0003428C
		[CallerCount(0)]
		public unsafe bool NeedsInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Inflater.NativeMethodInfoPtr_NeedsInput_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008C0 RID: 2240 RVA: 0x000360C8 File Offset: 0x000342C8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 861603, RefRangeEnd = 861606, XrefRangeStart = 861594, XrefRangeEnd = 861603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Inflate(Il2CppStructArray<byte> bytes, int offset, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Inflater.NativeMethodInfoPtr_Inflate_Public_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008C1 RID: 2241 RVA: 0x00036134 File Offset: 0x00034334
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 861610, RefRangeEnd = 861611, XrefRangeStart = 861606, XrefRangeEnd = 861610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Decode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Inflater.NativeMethodInfoPtr_Decode_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008C2 RID: 2242 RVA: 0x00036170 File Offset: 0x00034370
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 861611, XrefRangeEnd = 861613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DecodeUncompressedBlock(out bool end_of_block)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &end_of_block;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Inflater.NativeMethodInfoPtr_DecodeUncompressedBlock_Private_Boolean_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008C3 RID: 2243 RVA: 0x000361BC File Offset: 0x000343BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 861613, XrefRangeEnd = 861644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DecodeBlock(out bool end_of_block_code_seen)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &end_of_block_code_seen;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Inflater.NativeMethodInfoPtr_DecodeBlock_Private_Boolean_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008C4 RID: 2244 RVA: 0x00036208 File Offset: 0x00034408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 861644, XrefRangeEnd = 861681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DecodeDynamicBlockHeader()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Inflater.NativeMethodInfoPtr_DecodeDynamicBlockHeader_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008C5 RID: 2245 RVA: 0x00004EA6 File Offset: 0x000030A6
		public Inflater(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x060008C6 RID: 2246 RVA: 0x00036244 File Offset: 0x00034444
		// (set) Token: 0x060008C7 RID: 2247 RVA: 0x00004EAF File Offset: 0x000030AF
		public unsafe static Il2CppStructArray<byte> extraLengthBits
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Inflater.NativeFieldInfoPtr_extraLengthBits, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Inflater.NativeFieldInfoPtr_extraLengthBits, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x060008C8 RID: 2248 RVA: 0x0003626C File Offset: 0x0003446C
		// (set) Token: 0x060008C9 RID: 2249 RVA: 0x00004EC1 File Offset: 0x000030C1
		public unsafe static Il2CppStructArray<int> lengthBase
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Inflater.NativeFieldInfoPtr_lengthBase, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Inflater.NativeFieldInfoPtr_lengthBase, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x060008CA RID: 2250 RVA: 0x00036294 File Offset: 0x00034494
		// (set) Token: 0x060008CB RID: 2251 RVA: 0x00004ED3 File Offset: 0x000030D3
		public unsafe static Il2CppStructArray<int> distanceBasePosition
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Inflater.NativeFieldInfoPtr_distanceBasePosition, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Inflater.NativeFieldInfoPtr_distanceBasePosition, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x060008CC RID: 2252 RVA: 0x000362BC File Offset: 0x000344BC
		// (set) Token: 0x060008CD RID: 2253 RVA: 0x00004EE5 File Offset: 0x000030E5
		public unsafe static Il2CppStructArray<byte> codeOrder
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Inflater.NativeFieldInfoPtr_codeOrder, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Inflater.NativeFieldInfoPtr_codeOrder, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x060008CE RID: 2254 RVA: 0x000362E4 File Offset: 0x000344E4
		// (set) Token: 0x060008CF RID: 2255 RVA: 0x00004EF7 File Offset: 0x000030F7
		public unsafe static Il2CppStructArray<byte> staticDistanceTreeTable
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Inflater.NativeFieldInfoPtr_staticDistanceTreeTable, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Inflater.NativeFieldInfoPtr_staticDistanceTreeTable, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x060008D0 RID: 2256 RVA: 0x0003630C File Offset: 0x0003450C
		// (set) Token: 0x060008D1 RID: 2257 RVA: 0x00004F09 File Offset: 0x00003109
		public unsafe OutputWindow output
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Inflater.NativeFieldInfoPtr_output);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OutputWindow>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Inflater.NativeFieldInfoPtr_output), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x060008D2 RID: 2258 RVA: 0x0003633C File Offset: 0x0003453C
		// (set) Token: 0x060008D3 RID: 2259 RVA: 0x00004F28 File Offset: 0x00003128
		public unsafe InputBuffer input
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Inflater.NativeFieldInfoPtr_input);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputBuffer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Inflater.NativeFieldInfoPtr_input), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x060008D4 RID: 2260 RVA: 0x0003636C File Offset: 0x0003456C
		// (set) Token: 0x060008D5 RID: 2261 RVA: 0x00004F47 File Offset: 0x00003147
		public unsafe HuffmanTree literalLengthTree
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Inflater.NativeFieldInfoPtr_literalLengthTree);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HuffmanTree>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Inflater.NativeFieldInfoPtr_literalLengthTree), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x060008D6 RID: 2262 RVA: 0x0003639C File Offset: 0x0003459C
		// (set) Token: 0x060008D7 RID: 2263 RVA: 0x00004F66 File Offset: 0x00003166
		public unsafe HuffmanTree distanceTree
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Inflater.NativeFieldInfoPtr_distanceTree);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HuffmanTree>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Inflater.NativeFieldInfoPtr_distanceTree), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x060008D8 RID: 2264 RVA: 0x000363CC File Offset: 0x000345CC
		// (set) Token: 0x060008D9 RID: 2265 RVA: 0x00004F85 File Offset: 0x00003185
		public unsafe InflaterState state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Inflater.NativeFieldInfoPtr_state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Inflater.NativeFieldInfoPtr_state)) = value;
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x060008DA RID: 2266 RVA: 0x000363F4 File Offset: 0x000345F4
		// (set) Token: 0x060008DB RID: 2267 RVA: 0x00004FA0 File Offset: 0x000031A0
		public unsafe bool hasFormatReader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Inflater.NativeFieldInfoPtr_hasFormatReader);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Inflater.NativeFieldInfoPtr_hasFormatReader)) = value;
			}
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x060008DC RID: 2268 RVA: 0x0003641C File Offset: 0x0003461C
		// (set) Token: 0x060008DD RID: 2269 RVA: 0x00004FBB File Offset: 0x000031BB
		public unsafe int bfinal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Inflater.NativeFieldInfoPtr_bfinal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Inflater.NativeFieldInfoPtr_bfinal)) = value;
			}
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x060008DE RID: 2270 RVA: 0x00036444 File Offset: 0x00034644
		// (set) Token: 0x060008DF RID: 2271 RVA: 0x00004FD6 File Offset: 0x000031D6
		public unsafe BlockType blockType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Inflater.NativeFieldInfoPtr_blockType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Inflater.NativeFieldInfoPtr_blockType)) = value;
			}
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x060008E0 RID: 2272 RVA: 0x0003646C File Offset: 0x0003466C
		// (set) Token: 0x060008E1 RID: 2273 RVA: 0x00004FF1 File Offset: 0x000031F1
		public unsafe Il2CppStructArray<byte> blockLengthBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Inflater.NativeFieldInfoPtr_blockLengthBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Inflater.NativeFieldInfoPtr_blockLengthBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x060008E2 RID: 2274 RVA: 0x0003649C File Offset: 0x0003469C
		// (set) Token: 0x060008E3 RID: 2275 RVA: 0x00005010 File Offset: 0x00003210
		public unsafe int blockLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Inflater.NativeFieldInfoPtr_blockLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Inflater.NativeFieldInfoPtr_blockLength)) = value;
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x060008E4 RID: 2276 RVA: 0x000364C4 File Offset: 0x000346C4
		// (set) Token: 0x060008E5 RID: 2277 RVA: 0x0000502B File Offset: 0x0000322B
		public unsafe int length
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Inflater.NativeFieldInfoPtr_length);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Inflater.NativeFieldInfoPtr_length)) = value;
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x060008E6 RID: 2278 RVA: 0x000364EC File Offset: 0x000346EC
		// (set) Token: 0x060008E7 RID: 2279 RVA: 0x00005046 File Offset: 0x00003246
		public unsafe int distanceCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Inflater.NativeFieldInfoPtr_distanceCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Inflater.NativeFieldInfoPtr_distanceCode)) = value;
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x060008E8 RID: 2280 RVA: 0x00036514 File Offset: 0x00034714
		// (set) Token: 0x060008E9 RID: 2281 RVA: 0x00005061 File Offset: 0x00003261
		public unsafe int extraBits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Inflater.NativeFieldInfoPtr_extraBits);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Inflater.NativeFieldInfoPtr_extraBits)) = value;
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x060008EA RID: 2282 RVA: 0x0003653C File Offset: 0x0003473C
		// (set) Token: 0x060008EB RID: 2283 RVA: 0x0000507C File Offset: 0x0000327C
		public unsafe int loopCounter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Inflater.NativeFieldInfoPtr_loopCounter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Inflater.NativeFieldInfoPtr_loopCounter)) = value;
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x060008EC RID: 2284 RVA: 0x00036564 File Offset: 0x00034764
		// (set) Token: 0x060008ED RID: 2285 RVA: 0x00005097 File Offset: 0x00003297
		public unsafe int literalLengthCodeCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Inflater.NativeFieldInfoPtr_literalLengthCodeCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Inflater.NativeFieldInfoPtr_literalLengthCodeCount)) = value;
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x060008EE RID: 2286 RVA: 0x0003658C File Offset: 0x0003478C
		// (set) Token: 0x060008EF RID: 2287 RVA: 0x000050B2 File Offset: 0x000032B2
		public unsafe int distanceCodeCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Inflater.NativeFieldInfoPtr_distanceCodeCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Inflater.NativeFieldInfoPtr_distanceCodeCount)) = value;
			}
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x060008F0 RID: 2288 RVA: 0x000365B4 File Offset: 0x000347B4
		// (set) Token: 0x060008F1 RID: 2289 RVA: 0x000050CD File Offset: 0x000032CD
		public unsafe int codeLengthCodeCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Inflater.NativeFieldInfoPtr_codeLengthCodeCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Inflater.NativeFieldInfoPtr_codeLengthCodeCount)) = value;
			}
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x060008F2 RID: 2290 RVA: 0x000365DC File Offset: 0x000347DC
		// (set) Token: 0x060008F3 RID: 2291 RVA: 0x000050E8 File Offset: 0x000032E8
		public unsafe int codeArraySize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Inflater.NativeFieldInfoPtr_codeArraySize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Inflater.NativeFieldInfoPtr_codeArraySize)) = value;
			}
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x060008F4 RID: 2292 RVA: 0x00036604 File Offset: 0x00034804
		// (set) Token: 0x060008F5 RID: 2293 RVA: 0x00005103 File Offset: 0x00003303
		public unsafe int lengthCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Inflater.NativeFieldInfoPtr_lengthCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Inflater.NativeFieldInfoPtr_lengthCode)) = value;
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x060008F6 RID: 2294 RVA: 0x0003662C File Offset: 0x0003482C
		// (set) Token: 0x060008F7 RID: 2295 RVA: 0x0000511E File Offset: 0x0000331E
		public unsafe Il2CppStructArray<byte> codeList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Inflater.NativeFieldInfoPtr_codeList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Inflater.NativeFieldInfoPtr_codeList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x060008F8 RID: 2296 RVA: 0x0003665C File Offset: 0x0003485C
		// (set) Token: 0x060008F9 RID: 2297 RVA: 0x0000513D File Offset: 0x0000333D
		public unsafe Il2CppStructArray<byte> codeLengthTreeCodeLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Inflater.NativeFieldInfoPtr_codeLengthTreeCodeLength);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Inflater.NativeFieldInfoPtr_codeLengthTreeCodeLength), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x060008FA RID: 2298 RVA: 0x0003668C File Offset: 0x0003488C
		// (set) Token: 0x060008FB RID: 2299 RVA: 0x0000515C File Offset: 0x0000335C
		public unsafe HuffmanTree codeLengthTree
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Inflater.NativeFieldInfoPtr_codeLengthTree);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HuffmanTree>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Inflater.NativeFieldInfoPtr_codeLengthTree), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x060008FC RID: 2300 RVA: 0x000366BC File Offset: 0x000348BC
		// (set) Token: 0x060008FD RID: 2301 RVA: 0x0000517B File Offset: 0x0000337B
		public unsafe IFileFormatReader formatReader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Inflater.NativeFieldInfoPtr_formatReader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IFileFormatReader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Inflater.NativeFieldInfoPtr_formatReader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000677 RID: 1655
		private static readonly IntPtr NativeFieldInfoPtr_extraLengthBits;

		// Token: 0x04000678 RID: 1656
		private static readonly IntPtr NativeFieldInfoPtr_lengthBase;

		// Token: 0x04000679 RID: 1657
		private static readonly IntPtr NativeFieldInfoPtr_distanceBasePosition;

		// Token: 0x0400067A RID: 1658
		private static readonly IntPtr NativeFieldInfoPtr_codeOrder;

		// Token: 0x0400067B RID: 1659
		private static readonly IntPtr NativeFieldInfoPtr_staticDistanceTreeTable;

		// Token: 0x0400067C RID: 1660
		private static readonly IntPtr NativeFieldInfoPtr_output;

		// Token: 0x0400067D RID: 1661
		private static readonly IntPtr NativeFieldInfoPtr_input;

		// Token: 0x0400067E RID: 1662
		private static readonly IntPtr NativeFieldInfoPtr_literalLengthTree;

		// Token: 0x0400067F RID: 1663
		private static readonly IntPtr NativeFieldInfoPtr_distanceTree;

		// Token: 0x04000680 RID: 1664
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x04000681 RID: 1665
		private static readonly IntPtr NativeFieldInfoPtr_hasFormatReader;

		// Token: 0x04000682 RID: 1666
		private static readonly IntPtr NativeFieldInfoPtr_bfinal;

		// Token: 0x04000683 RID: 1667
		private static readonly IntPtr NativeFieldInfoPtr_blockType;

		// Token: 0x04000684 RID: 1668
		private static readonly IntPtr NativeFieldInfoPtr_blockLengthBuffer;

		// Token: 0x04000685 RID: 1669
		private static readonly IntPtr NativeFieldInfoPtr_blockLength;

		// Token: 0x04000686 RID: 1670
		private static readonly IntPtr NativeFieldInfoPtr_length;

		// Token: 0x04000687 RID: 1671
		private static readonly IntPtr NativeFieldInfoPtr_distanceCode;

		// Token: 0x04000688 RID: 1672
		private static readonly IntPtr NativeFieldInfoPtr_extraBits;

		// Token: 0x04000689 RID: 1673
		private static readonly IntPtr NativeFieldInfoPtr_loopCounter;

		// Token: 0x0400068A RID: 1674
		private static readonly IntPtr NativeFieldInfoPtr_literalLengthCodeCount;

		// Token: 0x0400068B RID: 1675
		private static readonly IntPtr NativeFieldInfoPtr_distanceCodeCount;

		// Token: 0x0400068C RID: 1676
		private static readonly IntPtr NativeFieldInfoPtr_codeLengthCodeCount;

		// Token: 0x0400068D RID: 1677
		private static readonly IntPtr NativeFieldInfoPtr_codeArraySize;

		// Token: 0x0400068E RID: 1678
		private static readonly IntPtr NativeFieldInfoPtr_lengthCode;

		// Token: 0x0400068F RID: 1679
		private static readonly IntPtr NativeFieldInfoPtr_codeList;

		// Token: 0x04000690 RID: 1680
		private static readonly IntPtr NativeFieldInfoPtr_codeLengthTreeCodeLength;

		// Token: 0x04000691 RID: 1681
		private static readonly IntPtr NativeFieldInfoPtr_codeLengthTree;

		// Token: 0x04000692 RID: 1682
		private static readonly IntPtr NativeFieldInfoPtr_formatReader;

		// Token: 0x04000693 RID: 1683
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000694 RID: 1684
		private static readonly IntPtr NativeMethodInfoPtr_SetFileFormatReader_Internal_Void_IFileFormatReader_0;

		// Token: 0x04000695 RID: 1685
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Private_Void_0;

		// Token: 0x04000696 RID: 1686
		private static readonly IntPtr NativeMethodInfoPtr_SetInput_Public_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04000697 RID: 1687
		private static readonly IntPtr NativeMethodInfoPtr_Finished_Public_Boolean_0;

		// Token: 0x04000698 RID: 1688
		private static readonly IntPtr NativeMethodInfoPtr_get_AvailableOutput_Public_get_Int32_0;

		// Token: 0x04000699 RID: 1689
		private static readonly IntPtr NativeMethodInfoPtr_NeedsInput_Public_Boolean_0;

		// Token: 0x0400069A RID: 1690
		private static readonly IntPtr NativeMethodInfoPtr_Inflate_Public_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x0400069B RID: 1691
		private static readonly IntPtr NativeMethodInfoPtr_Decode_Private_Boolean_0;

		// Token: 0x0400069C RID: 1692
		private static readonly IntPtr NativeMethodInfoPtr_DecodeUncompressedBlock_Private_Boolean_byref_Boolean_0;

		// Token: 0x0400069D RID: 1693
		private static readonly IntPtr NativeMethodInfoPtr_DecodeBlock_Private_Boolean_byref_Boolean_0;

		// Token: 0x0400069E RID: 1694
		private static readonly IntPtr NativeMethodInfoPtr_DecodeDynamicBlockHeader_Private_Boolean_0;
	}
}
