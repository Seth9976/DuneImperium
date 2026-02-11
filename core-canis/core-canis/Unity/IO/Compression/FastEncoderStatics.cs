using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Unity.IO.Compression
{
	// Token: 0x0200006C RID: 108
	public static class FastEncoderStatics : Object
	{
		// Token: 0x060007D6 RID: 2006 RVA: 0x00033118 File Offset: 0x00031318
		// Note: this type is marked as 'beforefieldinit'.
		static FastEncoderStatics()
		{
			Il2CppClassPointerStore<FastEncoderStatics>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "Unity.IO.Compression", "FastEncoderStatics");
			FastEncoderStatics.NativeFieldInfoPtr_FastEncoderTreeStructureData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastEncoderStatics>.NativeClassPtr, "FastEncoderTreeStructureData");
			FastEncoderStatics.NativeFieldInfoPtr_BFinalFastEncoderTreeStructureData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastEncoderStatics>.NativeClassPtr, "BFinalFastEncoderTreeStructureData");
			FastEncoderStatics.NativeFieldInfoPtr_FastEncoderLiteralCodeInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastEncoderStatics>.NativeClassPtr, "FastEncoderLiteralCodeInfo");
			FastEncoderStatics.NativeFieldInfoPtr_FastEncoderDistanceCodeInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastEncoderStatics>.NativeClassPtr, "FastEncoderDistanceCodeInfo");
			FastEncoderStatics.NativeFieldInfoPtr_BitMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastEncoderStatics>.NativeClassPtr, "BitMask");
			FastEncoderStatics.NativeFieldInfoPtr_ExtraLengthBits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastEncoderStatics>.NativeClassPtr, "ExtraLengthBits");
			FastEncoderStatics.NativeFieldInfoPtr_ExtraDistanceBits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastEncoderStatics>.NativeClassPtr, "ExtraDistanceBits");
			FastEncoderStatics.NativeFieldInfoPtr_NumChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastEncoderStatics>.NativeClassPtr, "NumChars");
			FastEncoderStatics.NativeFieldInfoPtr_NumLengthBaseCodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastEncoderStatics>.NativeClassPtr, "NumLengthBaseCodes");
			FastEncoderStatics.NativeFieldInfoPtr_NumDistBaseCodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastEncoderStatics>.NativeClassPtr, "NumDistBaseCodes");
			FastEncoderStatics.NativeFieldInfoPtr_FastEncoderPostTreeBitBuf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastEncoderStatics>.NativeClassPtr, "FastEncoderPostTreeBitBuf");
			FastEncoderStatics.NativeFieldInfoPtr_FastEncoderPostTreeBitCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastEncoderStatics>.NativeClassPtr, "FastEncoderPostTreeBitCount");
			FastEncoderStatics.NativeFieldInfoPtr_NoCompressionHeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastEncoderStatics>.NativeClassPtr, "NoCompressionHeader");
			FastEncoderStatics.NativeFieldInfoPtr_NoCompressionHeaderBitCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastEncoderStatics>.NativeClassPtr, "NoCompressionHeaderBitCount");
			FastEncoderStatics.NativeFieldInfoPtr_BFinalNoCompressionHeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastEncoderStatics>.NativeClassPtr, "BFinalNoCompressionHeader");
			FastEncoderStatics.NativeFieldInfoPtr_BFinalNoCompressionHeaderBitCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastEncoderStatics>.NativeClassPtr, "BFinalNoCompressionHeaderBitCount");
			FastEncoderStatics.NativeFieldInfoPtr_MaxCodeLen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastEncoderStatics>.NativeClassPtr, "MaxCodeLen");
			FastEncoderStatics.NativeFieldInfoPtr_distLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastEncoderStatics>.NativeClassPtr, "distLookup");
			FastEncoderStatics.NativeMethodInfoPtr_GetSlot_Internal_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastEncoderStatics>.NativeClassPtr, 100664478);
			FastEncoderStatics.NativeMethodInfoPtr_BitReverse_Public_Static_UInt32_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastEncoderStatics>.NativeClassPtr, 100664479);
		}

		// Token: 0x060007D7 RID: 2007 RVA: 0x000332D0 File Offset: 0x000314D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 861299, XrefRangeEnd = 861303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetSlot(int pos)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastEncoderStatics.NativeMethodInfoPtr_GetSlot_Internal_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x00033310 File Offset: 0x00031510
		[CallerCount(0)]
		public unsafe static uint BitReverse(uint code, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref code;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastEncoderStatics.NativeMethodInfoPtr_BitReverse_Public_Static_UInt32_UInt32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x00004902 File Offset: 0x00002B02
		public FastEncoderStatics(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x060007DA RID: 2010 RVA: 0x0003335C File Offset: 0x0003155C
		// (set) Token: 0x060007DB RID: 2011 RVA: 0x0000490B File Offset: 0x00002B0B
		public unsafe static Il2CppStructArray<byte> FastEncoderTreeStructureData
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FastEncoderStatics.NativeFieldInfoPtr_FastEncoderTreeStructureData, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FastEncoderStatics.NativeFieldInfoPtr_FastEncoderTreeStructureData, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x060007DC RID: 2012 RVA: 0x00033384 File Offset: 0x00031584
		// (set) Token: 0x060007DD RID: 2013 RVA: 0x0000491D File Offset: 0x00002B1D
		public unsafe static Il2CppStructArray<byte> BFinalFastEncoderTreeStructureData
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FastEncoderStatics.NativeFieldInfoPtr_BFinalFastEncoderTreeStructureData, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FastEncoderStatics.NativeFieldInfoPtr_BFinalFastEncoderTreeStructureData, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x060007DE RID: 2014 RVA: 0x000333AC File Offset: 0x000315AC
		// (set) Token: 0x060007DF RID: 2015 RVA: 0x0000492F File Offset: 0x00002B2F
		public unsafe static Il2CppStructArray<uint> FastEncoderLiteralCodeInfo
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FastEncoderStatics.NativeFieldInfoPtr_FastEncoderLiteralCodeInfo, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FastEncoderStatics.NativeFieldInfoPtr_FastEncoderLiteralCodeInfo, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x060007E0 RID: 2016 RVA: 0x000333D4 File Offset: 0x000315D4
		// (set) Token: 0x060007E1 RID: 2017 RVA: 0x00004941 File Offset: 0x00002B41
		public unsafe static Il2CppStructArray<uint> FastEncoderDistanceCodeInfo
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FastEncoderStatics.NativeFieldInfoPtr_FastEncoderDistanceCodeInfo, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FastEncoderStatics.NativeFieldInfoPtr_FastEncoderDistanceCodeInfo, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x060007E2 RID: 2018 RVA: 0x000333FC File Offset: 0x000315FC
		// (set) Token: 0x060007E3 RID: 2019 RVA: 0x00004953 File Offset: 0x00002B53
		public unsafe static Il2CppStructArray<uint> BitMask
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FastEncoderStatics.NativeFieldInfoPtr_BitMask, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FastEncoderStatics.NativeFieldInfoPtr_BitMask, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x060007E4 RID: 2020 RVA: 0x00033424 File Offset: 0x00031624
		// (set) Token: 0x060007E5 RID: 2021 RVA: 0x00004965 File Offset: 0x00002B65
		public unsafe static Il2CppStructArray<byte> ExtraLengthBits
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FastEncoderStatics.NativeFieldInfoPtr_ExtraLengthBits, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FastEncoderStatics.NativeFieldInfoPtr_ExtraLengthBits, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x060007E6 RID: 2022 RVA: 0x0003344C File Offset: 0x0003164C
		// (set) Token: 0x060007E7 RID: 2023 RVA: 0x00004977 File Offset: 0x00002B77
		public unsafe static Il2CppStructArray<byte> ExtraDistanceBits
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FastEncoderStatics.NativeFieldInfoPtr_ExtraDistanceBits, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FastEncoderStatics.NativeFieldInfoPtr_ExtraDistanceBits, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x060007E8 RID: 2024 RVA: 0x00033474 File Offset: 0x00031674
		// (set) Token: 0x060007E9 RID: 2025 RVA: 0x00004989 File Offset: 0x00002B89
		public unsafe static int NumChars
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FastEncoderStatics.NativeFieldInfoPtr_NumChars, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FastEncoderStatics.NativeFieldInfoPtr_NumChars, (void*)(&value));
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x060007EA RID: 2026 RVA: 0x00033490 File Offset: 0x00031690
		// (set) Token: 0x060007EB RID: 2027 RVA: 0x00004997 File Offset: 0x00002B97
		public unsafe static int NumLengthBaseCodes
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FastEncoderStatics.NativeFieldInfoPtr_NumLengthBaseCodes, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FastEncoderStatics.NativeFieldInfoPtr_NumLengthBaseCodes, (void*)(&value));
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x060007EC RID: 2028 RVA: 0x000334AC File Offset: 0x000316AC
		// (set) Token: 0x060007ED RID: 2029 RVA: 0x000049A5 File Offset: 0x00002BA5
		public unsafe static int NumDistBaseCodes
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FastEncoderStatics.NativeFieldInfoPtr_NumDistBaseCodes, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FastEncoderStatics.NativeFieldInfoPtr_NumDistBaseCodes, (void*)(&value));
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x060007EE RID: 2030 RVA: 0x000334C8 File Offset: 0x000316C8
		// (set) Token: 0x060007EF RID: 2031 RVA: 0x000049B3 File Offset: 0x00002BB3
		public unsafe static uint FastEncoderPostTreeBitBuf
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(FastEncoderStatics.NativeFieldInfoPtr_FastEncoderPostTreeBitBuf, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FastEncoderStatics.NativeFieldInfoPtr_FastEncoderPostTreeBitBuf, (void*)(&value));
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x060007F0 RID: 2032 RVA: 0x000334E4 File Offset: 0x000316E4
		// (set) Token: 0x060007F1 RID: 2033 RVA: 0x000049C1 File Offset: 0x00002BC1
		public unsafe static int FastEncoderPostTreeBitCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FastEncoderStatics.NativeFieldInfoPtr_FastEncoderPostTreeBitCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FastEncoderStatics.NativeFieldInfoPtr_FastEncoderPostTreeBitCount, (void*)(&value));
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x060007F2 RID: 2034 RVA: 0x00033500 File Offset: 0x00031700
		// (set) Token: 0x060007F3 RID: 2035 RVA: 0x000049CF File Offset: 0x00002BCF
		public unsafe static uint NoCompressionHeader
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(FastEncoderStatics.NativeFieldInfoPtr_NoCompressionHeader, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FastEncoderStatics.NativeFieldInfoPtr_NoCompressionHeader, (void*)(&value));
			}
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x060007F4 RID: 2036 RVA: 0x0003351C File Offset: 0x0003171C
		// (set) Token: 0x060007F5 RID: 2037 RVA: 0x000049DD File Offset: 0x00002BDD
		public unsafe static int NoCompressionHeaderBitCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FastEncoderStatics.NativeFieldInfoPtr_NoCompressionHeaderBitCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FastEncoderStatics.NativeFieldInfoPtr_NoCompressionHeaderBitCount, (void*)(&value));
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x060007F6 RID: 2038 RVA: 0x00033538 File Offset: 0x00031738
		// (set) Token: 0x060007F7 RID: 2039 RVA: 0x000049EB File Offset: 0x00002BEB
		public unsafe static uint BFinalNoCompressionHeader
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(FastEncoderStatics.NativeFieldInfoPtr_BFinalNoCompressionHeader, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FastEncoderStatics.NativeFieldInfoPtr_BFinalNoCompressionHeader, (void*)(&value));
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x060007F8 RID: 2040 RVA: 0x00033554 File Offset: 0x00031754
		// (set) Token: 0x060007F9 RID: 2041 RVA: 0x000049F9 File Offset: 0x00002BF9
		public unsafe static int BFinalNoCompressionHeaderBitCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FastEncoderStatics.NativeFieldInfoPtr_BFinalNoCompressionHeaderBitCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FastEncoderStatics.NativeFieldInfoPtr_BFinalNoCompressionHeaderBitCount, (void*)(&value));
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x060007FA RID: 2042 RVA: 0x00033570 File Offset: 0x00031770
		// (set) Token: 0x060007FB RID: 2043 RVA: 0x00004A07 File Offset: 0x00002C07
		public unsafe static int MaxCodeLen
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FastEncoderStatics.NativeFieldInfoPtr_MaxCodeLen, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FastEncoderStatics.NativeFieldInfoPtr_MaxCodeLen, (void*)(&value));
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x060007FC RID: 2044 RVA: 0x0003358C File Offset: 0x0003178C
		// (set) Token: 0x060007FD RID: 2045 RVA: 0x00004A15 File Offset: 0x00002C15
		public unsafe static Il2CppStructArray<byte> distLookup
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FastEncoderStatics.NativeFieldInfoPtr_distLookup, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FastEncoderStatics.NativeFieldInfoPtr_distLookup, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005EE RID: 1518
		private static readonly IntPtr NativeFieldInfoPtr_FastEncoderTreeStructureData;

		// Token: 0x040005EF RID: 1519
		private static readonly IntPtr NativeFieldInfoPtr_BFinalFastEncoderTreeStructureData;

		// Token: 0x040005F0 RID: 1520
		private static readonly IntPtr NativeFieldInfoPtr_FastEncoderLiteralCodeInfo;

		// Token: 0x040005F1 RID: 1521
		private static readonly IntPtr NativeFieldInfoPtr_FastEncoderDistanceCodeInfo;

		// Token: 0x040005F2 RID: 1522
		private static readonly IntPtr NativeFieldInfoPtr_BitMask;

		// Token: 0x040005F3 RID: 1523
		private static readonly IntPtr NativeFieldInfoPtr_ExtraLengthBits;

		// Token: 0x040005F4 RID: 1524
		private static readonly IntPtr NativeFieldInfoPtr_ExtraDistanceBits;

		// Token: 0x040005F5 RID: 1525
		private static readonly IntPtr NativeFieldInfoPtr_NumChars;

		// Token: 0x040005F6 RID: 1526
		private static readonly IntPtr NativeFieldInfoPtr_NumLengthBaseCodes;

		// Token: 0x040005F7 RID: 1527
		private static readonly IntPtr NativeFieldInfoPtr_NumDistBaseCodes;

		// Token: 0x040005F8 RID: 1528
		private static readonly IntPtr NativeFieldInfoPtr_FastEncoderPostTreeBitBuf;

		// Token: 0x040005F9 RID: 1529
		private static readonly IntPtr NativeFieldInfoPtr_FastEncoderPostTreeBitCount;

		// Token: 0x040005FA RID: 1530
		private static readonly IntPtr NativeFieldInfoPtr_NoCompressionHeader;

		// Token: 0x040005FB RID: 1531
		private static readonly IntPtr NativeFieldInfoPtr_NoCompressionHeaderBitCount;

		// Token: 0x040005FC RID: 1532
		private static readonly IntPtr NativeFieldInfoPtr_BFinalNoCompressionHeader;

		// Token: 0x040005FD RID: 1533
		private static readonly IntPtr NativeFieldInfoPtr_BFinalNoCompressionHeaderBitCount;

		// Token: 0x040005FE RID: 1534
		private static readonly IntPtr NativeFieldInfoPtr_MaxCodeLen;

		// Token: 0x040005FF RID: 1535
		private static readonly IntPtr NativeFieldInfoPtr_distLookup;

		// Token: 0x04000600 RID: 1536
		private static readonly IntPtr NativeMethodInfoPtr_GetSlot_Internal_Static_Int32_Int32_0;

		// Token: 0x04000601 RID: 1537
		private static readonly IntPtr NativeMethodInfoPtr_BitReverse_Public_Static_UInt32_UInt32_Int32_0;
	}
}
