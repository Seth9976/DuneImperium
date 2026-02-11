using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Unity.IO.Compression
{
	// Token: 0x02000074 RID: 116
	public class HuffmanTree : Object
	{
		// Token: 0x06000890 RID: 2192 RVA: 0x0003545C File Offset: 0x0003365C
		// Note: this type is marked as 'beforefieldinit'.
		static HuffmanTree()
		{
			Il2CppClassPointerStore<HuffmanTree>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "Unity.IO.Compression", "HuffmanTree");
			HuffmanTree.NativeFieldInfoPtr_MaxLiteralTreeElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HuffmanTree>.NativeClassPtr, "MaxLiteralTreeElements");
			HuffmanTree.NativeFieldInfoPtr_MaxDistTreeElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HuffmanTree>.NativeClassPtr, "MaxDistTreeElements");
			HuffmanTree.NativeFieldInfoPtr_EndOfBlockCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HuffmanTree>.NativeClassPtr, "EndOfBlockCode");
			HuffmanTree.NativeFieldInfoPtr_NumberOfCodeLengthTreeElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HuffmanTree>.NativeClassPtr, "NumberOfCodeLengthTreeElements");
			HuffmanTree.NativeFieldInfoPtr_tableBits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HuffmanTree>.NativeClassPtr, "tableBits");
			HuffmanTree.NativeFieldInfoPtr_table = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HuffmanTree>.NativeClassPtr, "table");
			HuffmanTree.NativeFieldInfoPtr_left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HuffmanTree>.NativeClassPtr, "left");
			HuffmanTree.NativeFieldInfoPtr_right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HuffmanTree>.NativeClassPtr, "right");
			HuffmanTree.NativeFieldInfoPtr_codeLengthArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HuffmanTree>.NativeClassPtr, "codeLengthArray");
			HuffmanTree.NativeFieldInfoPtr_tableMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HuffmanTree>.NativeClassPtr, "tableMask");
			HuffmanTree.NativeFieldInfoPtr_staticLiteralLengthTree = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HuffmanTree>.NativeClassPtr, "staticLiteralLengthTree");
			HuffmanTree.NativeFieldInfoPtr_staticDistanceTree = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HuffmanTree>.NativeClassPtr, "staticDistanceTree");
			HuffmanTree.NativeMethodInfoPtr_get_StaticLiteralLengthTree_Public_Static_get_HuffmanTree_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HuffmanTree>.NativeClassPtr, 100664535);
			HuffmanTree.NativeMethodInfoPtr_get_StaticDistanceTree_Public_Static_get_HuffmanTree_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HuffmanTree>.NativeClassPtr, 100664536);
			HuffmanTree.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HuffmanTree>.NativeClassPtr, 100664537);
			HuffmanTree.NativeMethodInfoPtr_GetStaticLiteralTreeLength_Private_Static_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HuffmanTree>.NativeClassPtr, 100664538);
			HuffmanTree.NativeMethodInfoPtr_GetStaticDistanceTreeLength_Private_Static_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HuffmanTree>.NativeClassPtr, 100664539);
			HuffmanTree.NativeMethodInfoPtr_CalculateHuffmanCode_Private_Il2CppStructArray_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HuffmanTree>.NativeClassPtr, 100664540);
			HuffmanTree.NativeMethodInfoPtr_CreateTable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HuffmanTree>.NativeClassPtr, 100664541);
			HuffmanTree.NativeMethodInfoPtr_GetNextSymbol_Public_Int32_InputBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HuffmanTree>.NativeClassPtr, 100664542);
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06000891 RID: 2193 RVA: 0x00035614 File Offset: 0x00033814
		public unsafe static HuffmanTree StaticLiteralLengthTree
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 861514, XrefRangeEnd = 861518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HuffmanTree.NativeMethodInfoPtr_get_StaticLiteralLengthTree_Public_Static_get_HuffmanTree_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HuffmanTree>(intPtr3) : null;
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x06000892 RID: 2194 RVA: 0x00035648 File Offset: 0x00033848
		public unsafe static HuffmanTree StaticDistanceTree
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 861518, XrefRangeEnd = 861522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HuffmanTree.NativeMethodInfoPtr_get_StaticDistanceTree_Public_Static_get_HuffmanTree_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HuffmanTree>(intPtr3) : null;
			}
		}

		// Token: 0x06000893 RID: 2195 RVA: 0x0003567C File Offset: 0x0003387C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 861522, XrefRangeEnd = 861526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HuffmanTree(Il2CppStructArray<byte> codeLengths)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HuffmanTree>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(codeLengths);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HuffmanTree.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000894 RID: 2196 RVA: 0x000356C8 File Offset: 0x000338C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 861526, XrefRangeEnd = 861529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> GetStaticLiteralTreeLength()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HuffmanTree.NativeMethodInfoPtr_GetStaticLiteralTreeLength_Private_Static_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06000895 RID: 2197 RVA: 0x000356FC File Offset: 0x000338FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 861529, XrefRangeEnd = 861532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> GetStaticDistanceTreeLength()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HuffmanTree.NativeMethodInfoPtr_GetStaticDistanceTreeLength_Private_Static_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06000896 RID: 2198 RVA: 0x00035730 File Offset: 0x00033930
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 861544, RefRangeEnd = 861545, XrefRangeStart = 861532, XrefRangeEnd = 861544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<uint> CalculateHuffmanCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HuffmanTree.NativeMethodInfoPtr_CalculateHuffmanCode_Private_Il2CppStructArray_1_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr3) : null;
		}

		// Token: 0x06000897 RID: 2199 RVA: 0x00035770 File Offset: 0x00033970
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 861559, RefRangeEnd = 861561, XrefRangeStart = 861545, XrefRangeEnd = 861559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateTable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HuffmanTree.NativeMethodInfoPtr_CreateTable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000898 RID: 2200 RVA: 0x000357A4 File Offset: 0x000339A4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 861564, RefRangeEnd = 861567, XrefRangeStart = 861561, XrefRangeEnd = 861564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetNextSymbol(InputBuffer input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HuffmanTree.NativeMethodInfoPtr_GetNextSymbol_Public_Int32_InputBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x00004D86 File Offset: 0x00002F86
		public HuffmanTree(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x0600089A RID: 2202 RVA: 0x000357F4 File Offset: 0x000339F4
		// (set) Token: 0x0600089B RID: 2203 RVA: 0x00004D8F File Offset: 0x00002F8F
		public unsafe static int MaxLiteralTreeElements
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HuffmanTree.NativeFieldInfoPtr_MaxLiteralTreeElements, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HuffmanTree.NativeFieldInfoPtr_MaxLiteralTreeElements, (void*)(&value));
			}
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x0600089C RID: 2204 RVA: 0x00035810 File Offset: 0x00033A10
		// (set) Token: 0x0600089D RID: 2205 RVA: 0x00004D9D File Offset: 0x00002F9D
		public unsafe static int MaxDistTreeElements
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HuffmanTree.NativeFieldInfoPtr_MaxDistTreeElements, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HuffmanTree.NativeFieldInfoPtr_MaxDistTreeElements, (void*)(&value));
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x0600089E RID: 2206 RVA: 0x0003582C File Offset: 0x00033A2C
		// (set) Token: 0x0600089F RID: 2207 RVA: 0x00004DAB File Offset: 0x00002FAB
		public unsafe static int EndOfBlockCode
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HuffmanTree.NativeFieldInfoPtr_EndOfBlockCode, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HuffmanTree.NativeFieldInfoPtr_EndOfBlockCode, (void*)(&value));
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x060008A0 RID: 2208 RVA: 0x00035848 File Offset: 0x00033A48
		// (set) Token: 0x060008A1 RID: 2209 RVA: 0x00004DB9 File Offset: 0x00002FB9
		public unsafe static int NumberOfCodeLengthTreeElements
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HuffmanTree.NativeFieldInfoPtr_NumberOfCodeLengthTreeElements, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HuffmanTree.NativeFieldInfoPtr_NumberOfCodeLengthTreeElements, (void*)(&value));
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x060008A2 RID: 2210 RVA: 0x00035864 File Offset: 0x00033A64
		// (set) Token: 0x060008A3 RID: 2211 RVA: 0x00004DC7 File Offset: 0x00002FC7
		public unsafe int tableBits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HuffmanTree.NativeFieldInfoPtr_tableBits);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HuffmanTree.NativeFieldInfoPtr_tableBits)) = value;
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x060008A4 RID: 2212 RVA: 0x0003588C File Offset: 0x00033A8C
		// (set) Token: 0x060008A5 RID: 2213 RVA: 0x00004DE2 File Offset: 0x00002FE2
		public unsafe Il2CppStructArray<short> table
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HuffmanTree.NativeFieldInfoPtr_table);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<short>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HuffmanTree.NativeFieldInfoPtr_table), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x060008A6 RID: 2214 RVA: 0x000358BC File Offset: 0x00033ABC
		// (set) Token: 0x060008A7 RID: 2215 RVA: 0x00004E01 File Offset: 0x00003001
		public unsafe Il2CppStructArray<short> left
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HuffmanTree.NativeFieldInfoPtr_left);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<short>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HuffmanTree.NativeFieldInfoPtr_left), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x060008A8 RID: 2216 RVA: 0x000358EC File Offset: 0x00033AEC
		// (set) Token: 0x060008A9 RID: 2217 RVA: 0x00004E20 File Offset: 0x00003020
		public unsafe Il2CppStructArray<short> right
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HuffmanTree.NativeFieldInfoPtr_right);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<short>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HuffmanTree.NativeFieldInfoPtr_right), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x060008AA RID: 2218 RVA: 0x0003591C File Offset: 0x00033B1C
		// (set) Token: 0x060008AB RID: 2219 RVA: 0x00004E3F File Offset: 0x0000303F
		public unsafe Il2CppStructArray<byte> codeLengthArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HuffmanTree.NativeFieldInfoPtr_codeLengthArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HuffmanTree.NativeFieldInfoPtr_codeLengthArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x060008AC RID: 2220 RVA: 0x0003594C File Offset: 0x00033B4C
		// (set) Token: 0x060008AD RID: 2221 RVA: 0x00004E5E File Offset: 0x0000305E
		public unsafe int tableMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HuffmanTree.NativeFieldInfoPtr_tableMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HuffmanTree.NativeFieldInfoPtr_tableMask)) = value;
			}
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x060008AE RID: 2222 RVA: 0x00035974 File Offset: 0x00033B74
		// (set) Token: 0x060008AF RID: 2223 RVA: 0x00004E79 File Offset: 0x00003079
		public unsafe static HuffmanTree staticLiteralLengthTree
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HuffmanTree.NativeFieldInfoPtr_staticLiteralLengthTree, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HuffmanTree>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HuffmanTree.NativeFieldInfoPtr_staticLiteralLengthTree, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x060008B0 RID: 2224 RVA: 0x0003599C File Offset: 0x00033B9C
		// (set) Token: 0x060008B1 RID: 2225 RVA: 0x00004E8B File Offset: 0x0000308B
		public unsafe static HuffmanTree staticDistanceTree
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HuffmanTree.NativeFieldInfoPtr_staticDistanceTree, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HuffmanTree>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HuffmanTree.NativeFieldInfoPtr_staticDistanceTree, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400065F RID: 1631
		private static readonly IntPtr NativeFieldInfoPtr_MaxLiteralTreeElements;

		// Token: 0x04000660 RID: 1632
		private static readonly IntPtr NativeFieldInfoPtr_MaxDistTreeElements;

		// Token: 0x04000661 RID: 1633
		private static readonly IntPtr NativeFieldInfoPtr_EndOfBlockCode;

		// Token: 0x04000662 RID: 1634
		private static readonly IntPtr NativeFieldInfoPtr_NumberOfCodeLengthTreeElements;

		// Token: 0x04000663 RID: 1635
		private static readonly IntPtr NativeFieldInfoPtr_tableBits;

		// Token: 0x04000664 RID: 1636
		private static readonly IntPtr NativeFieldInfoPtr_table;

		// Token: 0x04000665 RID: 1637
		private static readonly IntPtr NativeFieldInfoPtr_left;

		// Token: 0x04000666 RID: 1638
		private static readonly IntPtr NativeFieldInfoPtr_right;

		// Token: 0x04000667 RID: 1639
		private static readonly IntPtr NativeFieldInfoPtr_codeLengthArray;

		// Token: 0x04000668 RID: 1640
		private static readonly IntPtr NativeFieldInfoPtr_tableMask;

		// Token: 0x04000669 RID: 1641
		private static readonly IntPtr NativeFieldInfoPtr_staticLiteralLengthTree;

		// Token: 0x0400066A RID: 1642
		private static readonly IntPtr NativeFieldInfoPtr_staticDistanceTree;

		// Token: 0x0400066B RID: 1643
		private static readonly IntPtr NativeMethodInfoPtr_get_StaticLiteralLengthTree_Public_Static_get_HuffmanTree_0;

		// Token: 0x0400066C RID: 1644
		private static readonly IntPtr NativeMethodInfoPtr_get_StaticDistanceTree_Public_Static_get_HuffmanTree_0;

		// Token: 0x0400066D RID: 1645
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400066E RID: 1646
		private static readonly IntPtr NativeMethodInfoPtr_GetStaticLiteralTreeLength_Private_Static_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400066F RID: 1647
		private static readonly IntPtr NativeMethodInfoPtr_GetStaticDistanceTreeLength_Private_Static_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000670 RID: 1648
		private static readonly IntPtr NativeMethodInfoPtr_CalculateHuffmanCode_Private_Il2CppStructArray_1_UInt32_0;

		// Token: 0x04000671 RID: 1649
		private static readonly IntPtr NativeMethodInfoPtr_CreateTable_Private_Void_0;

		// Token: 0x04000672 RID: 1650
		private static readonly IntPtr NativeMethodInfoPtr_GetNextSymbol_Public_Int32_InputBuffer_0;
	}
}
