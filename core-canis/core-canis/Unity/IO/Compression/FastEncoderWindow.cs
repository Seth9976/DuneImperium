using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Unity.IO.Compression
{
	// Token: 0x0200006D RID: 109
	public class FastEncoderWindow : Object
	{
		// Token: 0x060007FE RID: 2046 RVA: 0x000335B4 File Offset: 0x000317B4
		// Note: this type is marked as 'beforefieldinit'.
		static FastEncoderWindow()
		{
			Il2CppClassPointerStore<FastEncoderWindow>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "Unity.IO.Compression", "FastEncoderWindow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FastEncoderWindow>.NativeClassPtr);
			FastEncoderWindow.NativeFieldInfoPtr_window = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastEncoderWindow>.NativeClassPtr, "window");
			FastEncoderWindow.NativeFieldInfoPtr_bufPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastEncoderWindow>.NativeClassPtr, "bufPos");
			FastEncoderWindow.NativeFieldInfoPtr_bufEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastEncoderWindow>.NativeClassPtr, "bufEnd");
			FastEncoderWindow.NativeFieldInfoPtr_FastEncoderHashShift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastEncoderWindow>.NativeClassPtr, "FastEncoderHashShift");
			FastEncoderWindow.NativeFieldInfoPtr_FastEncoderHashtableSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastEncoderWindow>.NativeClassPtr, "FastEncoderHashtableSize");
			FastEncoderWindow.NativeFieldInfoPtr_FastEncoderHashMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastEncoderWindow>.NativeClassPtr, "FastEncoderHashMask");
			FastEncoderWindow.NativeFieldInfoPtr_FastEncoderWindowSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastEncoderWindow>.NativeClassPtr, "FastEncoderWindowSize");
			FastEncoderWindow.NativeFieldInfoPtr_FastEncoderWindowMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastEncoderWindow>.NativeClassPtr, "FastEncoderWindowMask");
			FastEncoderWindow.NativeFieldInfoPtr_FastEncoderMatch3DistThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastEncoderWindow>.NativeClassPtr, "FastEncoderMatch3DistThreshold");
			FastEncoderWindow.NativeFieldInfoPtr_MaxMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastEncoderWindow>.NativeClassPtr, "MaxMatch");
			FastEncoderWindow.NativeFieldInfoPtr_MinMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastEncoderWindow>.NativeClassPtr, "MinMatch");
			FastEncoderWindow.NativeFieldInfoPtr_SearchDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastEncoderWindow>.NativeClassPtr, "SearchDepth");
			FastEncoderWindow.NativeFieldInfoPtr_GoodLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastEncoderWindow>.NativeClassPtr, "GoodLength");
			FastEncoderWindow.NativeFieldInfoPtr_NiceLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastEncoderWindow>.NativeClassPtr, "NiceLength");
			FastEncoderWindow.NativeFieldInfoPtr_LazyMatchThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastEncoderWindow>.NativeClassPtr, "LazyMatchThreshold");
			FastEncoderWindow.NativeFieldInfoPtr_prev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastEncoderWindow>.NativeClassPtr, "prev");
			FastEncoderWindow.NativeFieldInfoPtr_lookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastEncoderWindow>.NativeClassPtr, "lookup");
			FastEncoderWindow.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastEncoderWindow>.NativeClassPtr, 100664480);
			FastEncoderWindow.NativeMethodInfoPtr_get_BytesAvailable_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastEncoderWindow>.NativeClassPtr, 100664481);
			FastEncoderWindow.NativeMethodInfoPtr_get_UnprocessedInput_Public_get_DeflateInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastEncoderWindow>.NativeClassPtr, 100664482);
			FastEncoderWindow.NativeMethodInfoPtr_FlushWindow_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastEncoderWindow>.NativeClassPtr, 100664483);
			FastEncoderWindow.NativeMethodInfoPtr_ResetWindow_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastEncoderWindow>.NativeClassPtr, 100664484);
			FastEncoderWindow.NativeMethodInfoPtr_get_FreeWindowSpace_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastEncoderWindow>.NativeClassPtr, 100664485);
			FastEncoderWindow.NativeMethodInfoPtr_CopyBytes_Public_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastEncoderWindow>.NativeClassPtr, 100664486);
			FastEncoderWindow.NativeMethodInfoPtr_MoveWindows_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastEncoderWindow>.NativeClassPtr, 100664487);
			FastEncoderWindow.NativeMethodInfoPtr_HashValue_Private_UInt32_UInt32_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastEncoderWindow>.NativeClassPtr, 100664488);
			FastEncoderWindow.NativeMethodInfoPtr_InsertString_Private_UInt32_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastEncoderWindow>.NativeClassPtr, 100664489);
			FastEncoderWindow.NativeMethodInfoPtr_InsertStrings_Private_Void_byref_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastEncoderWindow>.NativeClassPtr, 100664490);
			FastEncoderWindow.NativeMethodInfoPtr_GetNextSymbolOrMatch_Internal_Boolean_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastEncoderWindow>.NativeClassPtr, 100664491);
			FastEncoderWindow.NativeMethodInfoPtr_FindMatch_Private_Int32_Int32_byref_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastEncoderWindow>.NativeClassPtr, 100664492);
			FastEncoderWindow.NativeMethodInfoPtr_VerifyHashes_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastEncoderWindow>.NativeClassPtr, 100664493);
			FastEncoderWindow.NativeMethodInfoPtr_RecalculateHash_Private_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastEncoderWindow>.NativeClassPtr, 100664494);
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x00033864 File Offset: 0x00031A64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 861303, XrefRangeEnd = 861305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FastEncoderWindow()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FastEncoderWindow>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastEncoderWindow.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x06000800 RID: 2048 RVA: 0x000338A0 File Offset: 0x00031AA0
		public unsafe int BytesAvailable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastEncoderWindow.NativeMethodInfoPtr_get_BytesAvailable_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06000801 RID: 2049 RVA: 0x000338DC File Offset: 0x00031ADC
		public unsafe DeflateInput UnprocessedInput
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 861305, XrefRangeEnd = 861310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastEncoderWindow.NativeMethodInfoPtr_get_UnprocessedInput_Public_get_DeflateInput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DeflateInput>(intPtr3) : null;
			}
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x0003391C File Offset: 0x00031B1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 861310, XrefRangeEnd = 861311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FlushWindow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastEncoderWindow.NativeMethodInfoPtr_FlushWindow_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x00033950 File Offset: 0x00031B50
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 861322, RefRangeEnd = 861331, XrefRangeStart = 861311, XrefRangeEnd = 861322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetWindow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastEncoderWindow.NativeMethodInfoPtr_ResetWindow_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06000804 RID: 2052 RVA: 0x00033984 File Offset: 0x00031B84
		public unsafe int FreeWindowSpace
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastEncoderWindow.NativeMethodInfoPtr_get_FreeWindowSpace_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000805 RID: 2053 RVA: 0x000339C0 File Offset: 0x00031BC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 861331, XrefRangeEnd = 861332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyBytes(Il2CppStructArray<byte> inputBuffer, int startIndex, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputBuffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastEncoderWindow.NativeMethodInfoPtr_CopyBytes_Public_Void_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x00033A20 File Offset: 0x00031C20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 861332, XrefRangeEnd = 861333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveWindows()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastEncoderWindow.NativeMethodInfoPtr_MoveWindows_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000807 RID: 2055 RVA: 0x00033A54 File Offset: 0x00031C54
		[CallerCount(0)]
		public unsafe uint HashValue(uint hash, byte b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hash;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastEncoderWindow.NativeMethodInfoPtr_HashValue_Private_UInt32_UInt32_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x00033AAC File Offset: 0x00031CAC
		[CallerCount(0)]
		public unsafe uint InsertString(ref uint hash)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &hash;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastEncoderWindow.NativeMethodInfoPtr_InsertString_Private_UInt32_byref_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x00033AF8 File Offset: 0x00031CF8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 861333, RefRangeEnd = 861336, XrefRangeStart = 861333, XrefRangeEnd = 861333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InsertStrings(ref uint hash, int matchLen)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &hash;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref matchLen;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastEncoderWindow.NativeMethodInfoPtr_InsertStrings_Private_Void_byref_UInt32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600080A RID: 2058 RVA: 0x00033B44 File Offset: 0x00031D44
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 861345, RefRangeEnd = 861347, XrefRangeStart = 861336, XrefRangeEnd = 861345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetNextSymbolOrMatch(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastEncoderWindow.NativeMethodInfoPtr_GetNextSymbolOrMatch_Internal_Boolean_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x00033B94 File Offset: 0x00031D94
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 861347, RefRangeEnd = 861349, XrefRangeStart = 861347, XrefRangeEnd = 861347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FindMatch(int search, out int matchPos, int searchDepth, int niceLength)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref search;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &matchPos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref searchDepth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref niceLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastEncoderWindow.NativeMethodInfoPtr_FindMatch_Private_Int32_Int32_byref_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x00033C08 File Offset: 0x00031E08
		[CallerCount(0)]
		public unsafe void VerifyHashes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastEncoderWindow.NativeMethodInfoPtr_VerifyHashes_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600080D RID: 2061 RVA: 0x00033C3C File Offset: 0x00031E3C
		[CallerCount(0)]
		public unsafe uint RecalculateHash(int position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastEncoderWindow.NativeMethodInfoPtr_RecalculateHash_Private_UInt32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x00004A27 File Offset: 0x00002C27
		public FastEncoderWindow(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x0600080F RID: 2063 RVA: 0x00033C88 File Offset: 0x00031E88
		// (set) Token: 0x06000810 RID: 2064 RVA: 0x00004A30 File Offset: 0x00002C30
		public unsafe Il2CppStructArray<byte> window
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastEncoderWindow.NativeFieldInfoPtr_window);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastEncoderWindow.NativeFieldInfoPtr_window), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06000811 RID: 2065 RVA: 0x00033CB8 File Offset: 0x00031EB8
		// (set) Token: 0x06000812 RID: 2066 RVA: 0x00004A4F File Offset: 0x00002C4F
		public unsafe int bufPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastEncoderWindow.NativeFieldInfoPtr_bufPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastEncoderWindow.NativeFieldInfoPtr_bufPos)) = value;
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06000813 RID: 2067 RVA: 0x00033CE0 File Offset: 0x00031EE0
		// (set) Token: 0x06000814 RID: 2068 RVA: 0x00004A6A File Offset: 0x00002C6A
		public unsafe int bufEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastEncoderWindow.NativeFieldInfoPtr_bufEnd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastEncoderWindow.NativeFieldInfoPtr_bufEnd)) = value;
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x06000815 RID: 2069 RVA: 0x00033D08 File Offset: 0x00031F08
		// (set) Token: 0x06000816 RID: 2070 RVA: 0x00004A85 File Offset: 0x00002C85
		public unsafe static int FastEncoderHashShift
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FastEncoderWindow.NativeFieldInfoPtr_FastEncoderHashShift, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FastEncoderWindow.NativeFieldInfoPtr_FastEncoderHashShift, (void*)(&value));
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x06000817 RID: 2071 RVA: 0x00033D24 File Offset: 0x00031F24
		// (set) Token: 0x06000818 RID: 2072 RVA: 0x00004A93 File Offset: 0x00002C93
		public unsafe static int FastEncoderHashtableSize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FastEncoderWindow.NativeFieldInfoPtr_FastEncoderHashtableSize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FastEncoderWindow.NativeFieldInfoPtr_FastEncoderHashtableSize, (void*)(&value));
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x06000819 RID: 2073 RVA: 0x00033D40 File Offset: 0x00031F40
		// (set) Token: 0x0600081A RID: 2074 RVA: 0x00004AA1 File Offset: 0x00002CA1
		public unsafe static int FastEncoderHashMask
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FastEncoderWindow.NativeFieldInfoPtr_FastEncoderHashMask, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FastEncoderWindow.NativeFieldInfoPtr_FastEncoderHashMask, (void*)(&value));
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x0600081B RID: 2075 RVA: 0x00033D5C File Offset: 0x00031F5C
		// (set) Token: 0x0600081C RID: 2076 RVA: 0x00004AAF File Offset: 0x00002CAF
		public unsafe static int FastEncoderWindowSize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FastEncoderWindow.NativeFieldInfoPtr_FastEncoderWindowSize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FastEncoderWindow.NativeFieldInfoPtr_FastEncoderWindowSize, (void*)(&value));
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x0600081D RID: 2077 RVA: 0x00033D78 File Offset: 0x00031F78
		// (set) Token: 0x0600081E RID: 2078 RVA: 0x00004ABD File Offset: 0x00002CBD
		public unsafe static int FastEncoderWindowMask
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FastEncoderWindow.NativeFieldInfoPtr_FastEncoderWindowMask, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FastEncoderWindow.NativeFieldInfoPtr_FastEncoderWindowMask, (void*)(&value));
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x0600081F RID: 2079 RVA: 0x00033D94 File Offset: 0x00031F94
		// (set) Token: 0x06000820 RID: 2080 RVA: 0x00004ACB File Offset: 0x00002CCB
		public unsafe static int FastEncoderMatch3DistThreshold
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FastEncoderWindow.NativeFieldInfoPtr_FastEncoderMatch3DistThreshold, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FastEncoderWindow.NativeFieldInfoPtr_FastEncoderMatch3DistThreshold, (void*)(&value));
			}
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x06000821 RID: 2081 RVA: 0x00033DB0 File Offset: 0x00031FB0
		// (set) Token: 0x06000822 RID: 2082 RVA: 0x00004AD9 File Offset: 0x00002CD9
		public unsafe static int MaxMatch
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FastEncoderWindow.NativeFieldInfoPtr_MaxMatch, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FastEncoderWindow.NativeFieldInfoPtr_MaxMatch, (void*)(&value));
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06000823 RID: 2083 RVA: 0x00033DCC File Offset: 0x00031FCC
		// (set) Token: 0x06000824 RID: 2084 RVA: 0x00004AE7 File Offset: 0x00002CE7
		public unsafe static int MinMatch
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FastEncoderWindow.NativeFieldInfoPtr_MinMatch, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FastEncoderWindow.NativeFieldInfoPtr_MinMatch, (void*)(&value));
			}
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06000825 RID: 2085 RVA: 0x00033DE8 File Offset: 0x00031FE8
		// (set) Token: 0x06000826 RID: 2086 RVA: 0x00004AF5 File Offset: 0x00002CF5
		public unsafe static int SearchDepth
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FastEncoderWindow.NativeFieldInfoPtr_SearchDepth, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FastEncoderWindow.NativeFieldInfoPtr_SearchDepth, (void*)(&value));
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06000827 RID: 2087 RVA: 0x00033E04 File Offset: 0x00032004
		// (set) Token: 0x06000828 RID: 2088 RVA: 0x00004B03 File Offset: 0x00002D03
		public unsafe static int GoodLength
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FastEncoderWindow.NativeFieldInfoPtr_GoodLength, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FastEncoderWindow.NativeFieldInfoPtr_GoodLength, (void*)(&value));
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x06000829 RID: 2089 RVA: 0x00033E20 File Offset: 0x00032020
		// (set) Token: 0x0600082A RID: 2090 RVA: 0x00004B11 File Offset: 0x00002D11
		public unsafe static int NiceLength
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FastEncoderWindow.NativeFieldInfoPtr_NiceLength, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FastEncoderWindow.NativeFieldInfoPtr_NiceLength, (void*)(&value));
			}
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x0600082B RID: 2091 RVA: 0x00033E3C File Offset: 0x0003203C
		// (set) Token: 0x0600082C RID: 2092 RVA: 0x00004B1F File Offset: 0x00002D1F
		public unsafe static int LazyMatchThreshold
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FastEncoderWindow.NativeFieldInfoPtr_LazyMatchThreshold, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FastEncoderWindow.NativeFieldInfoPtr_LazyMatchThreshold, (void*)(&value));
			}
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x0600082D RID: 2093 RVA: 0x00033E58 File Offset: 0x00032058
		// (set) Token: 0x0600082E RID: 2094 RVA: 0x00004B2D File Offset: 0x00002D2D
		public unsafe Il2CppStructArray<ushort> prev
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastEncoderWindow.NativeFieldInfoPtr_prev);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ushort>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastEncoderWindow.NativeFieldInfoPtr_prev), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x0600082F RID: 2095 RVA: 0x00033E88 File Offset: 0x00032088
		// (set) Token: 0x06000830 RID: 2096 RVA: 0x00004B4C File Offset: 0x00002D4C
		public unsafe Il2CppStructArray<ushort> lookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastEncoderWindow.NativeFieldInfoPtr_lookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ushort>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastEncoderWindow.NativeFieldInfoPtr_lookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000602 RID: 1538
		private static readonly IntPtr NativeFieldInfoPtr_window;

		// Token: 0x04000603 RID: 1539
		private static readonly IntPtr NativeFieldInfoPtr_bufPos;

		// Token: 0x04000604 RID: 1540
		private static readonly IntPtr NativeFieldInfoPtr_bufEnd;

		// Token: 0x04000605 RID: 1541
		private static readonly IntPtr NativeFieldInfoPtr_FastEncoderHashShift;

		// Token: 0x04000606 RID: 1542
		private static readonly IntPtr NativeFieldInfoPtr_FastEncoderHashtableSize;

		// Token: 0x04000607 RID: 1543
		private static readonly IntPtr NativeFieldInfoPtr_FastEncoderHashMask;

		// Token: 0x04000608 RID: 1544
		private static readonly IntPtr NativeFieldInfoPtr_FastEncoderWindowSize;

		// Token: 0x04000609 RID: 1545
		private static readonly IntPtr NativeFieldInfoPtr_FastEncoderWindowMask;

		// Token: 0x0400060A RID: 1546
		private static readonly IntPtr NativeFieldInfoPtr_FastEncoderMatch3DistThreshold;

		// Token: 0x0400060B RID: 1547
		private static readonly IntPtr NativeFieldInfoPtr_MaxMatch;

		// Token: 0x0400060C RID: 1548
		private static readonly IntPtr NativeFieldInfoPtr_MinMatch;

		// Token: 0x0400060D RID: 1549
		private static readonly IntPtr NativeFieldInfoPtr_SearchDepth;

		// Token: 0x0400060E RID: 1550
		private static readonly IntPtr NativeFieldInfoPtr_GoodLength;

		// Token: 0x0400060F RID: 1551
		private static readonly IntPtr NativeFieldInfoPtr_NiceLength;

		// Token: 0x04000610 RID: 1552
		private static readonly IntPtr NativeFieldInfoPtr_LazyMatchThreshold;

		// Token: 0x04000611 RID: 1553
		private static readonly IntPtr NativeFieldInfoPtr_prev;

		// Token: 0x04000612 RID: 1554
		private static readonly IntPtr NativeFieldInfoPtr_lookup;

		// Token: 0x04000613 RID: 1555
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000614 RID: 1556
		private static readonly IntPtr NativeMethodInfoPtr_get_BytesAvailable_Public_get_Int32_0;

		// Token: 0x04000615 RID: 1557
		private static readonly IntPtr NativeMethodInfoPtr_get_UnprocessedInput_Public_get_DeflateInput_0;

		// Token: 0x04000616 RID: 1558
		private static readonly IntPtr NativeMethodInfoPtr_FlushWindow_Public_Void_0;

		// Token: 0x04000617 RID: 1559
		private static readonly IntPtr NativeMethodInfoPtr_ResetWindow_Private_Void_0;

		// Token: 0x04000618 RID: 1560
		private static readonly IntPtr NativeMethodInfoPtr_get_FreeWindowSpace_Public_get_Int32_0;

		// Token: 0x04000619 RID: 1561
		private static readonly IntPtr NativeMethodInfoPtr_CopyBytes_Public_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x0400061A RID: 1562
		private static readonly IntPtr NativeMethodInfoPtr_MoveWindows_Public_Void_0;

		// Token: 0x0400061B RID: 1563
		private static readonly IntPtr NativeMethodInfoPtr_HashValue_Private_UInt32_UInt32_Byte_0;

		// Token: 0x0400061C RID: 1564
		private static readonly IntPtr NativeMethodInfoPtr_InsertString_Private_UInt32_byref_UInt32_0;

		// Token: 0x0400061D RID: 1565
		private static readonly IntPtr NativeMethodInfoPtr_InsertStrings_Private_Void_byref_UInt32_Int32_0;

		// Token: 0x0400061E RID: 1566
		private static readonly IntPtr NativeMethodInfoPtr_GetNextSymbolOrMatch_Internal_Boolean_Match_0;

		// Token: 0x0400061F RID: 1567
		private static readonly IntPtr NativeMethodInfoPtr_FindMatch_Private_Int32_Int32_byref_Int32_Int32_Int32_0;

		// Token: 0x04000620 RID: 1568
		private static readonly IntPtr NativeMethodInfoPtr_VerifyHashes_Private_Void_0;

		// Token: 0x04000621 RID: 1569
		private static readonly IntPtr NativeMethodInfoPtr_RecalculateHash_Private_UInt32_Int32_0;
	}
}
