using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Unity.IO.Compression
{
	// Token: 0x02000070 RID: 112
	public class GZipDecoder : Object
	{
		// Token: 0x0600083C RID: 2108 RVA: 0x000341F0 File Offset: 0x000323F0
		// Note: this type is marked as 'beforefieldinit'.
		static GZipDecoder()
		{
			Il2CppClassPointerStore<GZipDecoder>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "Unity.IO.Compression", "GZipDecoder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GZipDecoder>.NativeClassPtr);
			GZipDecoder.NativeFieldInfoPtr_gzipHeaderSubstate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GZipDecoder>.NativeClassPtr, "gzipHeaderSubstate");
			GZipDecoder.NativeFieldInfoPtr_gzipFooterSubstate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GZipDecoder>.NativeClassPtr, "gzipFooterSubstate");
			GZipDecoder.NativeFieldInfoPtr_gzip_header_flag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GZipDecoder>.NativeClassPtr, "gzip_header_flag");
			GZipDecoder.NativeFieldInfoPtr_gzip_header_xlen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GZipDecoder>.NativeClassPtr, "gzip_header_xlen");
			GZipDecoder.NativeFieldInfoPtr_expectedCrc32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GZipDecoder>.NativeClassPtr, "expectedCrc32");
			GZipDecoder.NativeFieldInfoPtr_expectedOutputStreamSizeModulo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GZipDecoder>.NativeClassPtr, "expectedOutputStreamSizeModulo");
			GZipDecoder.NativeFieldInfoPtr_loopCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GZipDecoder>.NativeClassPtr, "loopCounter");
			GZipDecoder.NativeFieldInfoPtr_actualCrc32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GZipDecoder>.NativeClassPtr, "actualCrc32");
			GZipDecoder.NativeFieldInfoPtr_actualStreamSizeModulo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GZipDecoder>.NativeClassPtr, "actualStreamSizeModulo");
			GZipDecoder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GZipDecoder>.NativeClassPtr, 100664502);
			GZipDecoder.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GZipDecoder>.NativeClassPtr, 100664503);
			GZipDecoder.NativeMethodInfoPtr_ReadHeader_Public_Virtual_Final_New_Boolean_InputBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GZipDecoder>.NativeClassPtr, 100664504);
			GZipDecoder.NativeMethodInfoPtr_ReadFooter_Public_Virtual_Final_New_Boolean_InputBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GZipDecoder>.NativeClassPtr, 100664505);
			GZipDecoder.NativeMethodInfoPtr_UpdateWithBytesRead_Public_Virtual_Final_New_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GZipDecoder>.NativeClassPtr, 100664506);
			GZipDecoder.NativeMethodInfoPtr_Validate_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GZipDecoder>.NativeClassPtr, 100664507);
		}

		// Token: 0x0600083D RID: 2109 RVA: 0x0003434C File Offset: 0x0003254C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 861349, XrefRangeEnd = 861350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GZipDecoder()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GZipDecoder>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GZipDecoder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x00034388 File Offset: 0x00032588
		[CallerCount(0)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GZipDecoder.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x000343BC File Offset: 0x000325BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 861350, XrefRangeEnd = 861370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ReadHeader(InputBuffer input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GZipDecoder.NativeMethodInfoPtr_ReadHeader_Public_Virtual_Final_New_Boolean_InputBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000840 RID: 2112 RVA: 0x0003440C File Offset: 0x0003260C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 861370, XrefRangeEnd = 861372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ReadFooter(InputBuffer input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GZipDecoder.NativeMethodInfoPtr_ReadFooter_Public_Virtual_Final_New_Boolean_InputBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x0003445C File Offset: 0x0003265C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 861372, XrefRangeEnd = 861380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateWithBytesRead(Il2CppStructArray<byte> buffer, int offset, int copied)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref copied;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GZipDecoder.NativeMethodInfoPtr_UpdateWithBytesRead_Public_Virtual_Final_New_Void_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000842 RID: 2114 RVA: 0x000344BC File Offset: 0x000326BC
		[CallerCount(0)]
		public unsafe virtual void Validate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GZipDecoder.NativeMethodInfoPtr_Validate_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000843 RID: 2115 RVA: 0x00004B7D File Offset: 0x00002D7D
		public GZipDecoder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x06000844 RID: 2116 RVA: 0x000344F0 File Offset: 0x000326F0
		// (set) Token: 0x06000845 RID: 2117 RVA: 0x00004B86 File Offset: 0x00002D86
		public unsafe GZipDecoder.GzipHeaderState gzipHeaderSubstate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GZipDecoder.NativeFieldInfoPtr_gzipHeaderSubstate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GZipDecoder.NativeFieldInfoPtr_gzipHeaderSubstate)) = value;
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06000846 RID: 2118 RVA: 0x00034518 File Offset: 0x00032718
		// (set) Token: 0x06000847 RID: 2119 RVA: 0x00004BA1 File Offset: 0x00002DA1
		public unsafe GZipDecoder.GzipHeaderState gzipFooterSubstate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GZipDecoder.NativeFieldInfoPtr_gzipFooterSubstate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GZipDecoder.NativeFieldInfoPtr_gzipFooterSubstate)) = value;
			}
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06000848 RID: 2120 RVA: 0x00034540 File Offset: 0x00032740
		// (set) Token: 0x06000849 RID: 2121 RVA: 0x00004BBC File Offset: 0x00002DBC
		public unsafe int gzip_header_flag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GZipDecoder.NativeFieldInfoPtr_gzip_header_flag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GZipDecoder.NativeFieldInfoPtr_gzip_header_flag)) = value;
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x0600084A RID: 2122 RVA: 0x00034568 File Offset: 0x00032768
		// (set) Token: 0x0600084B RID: 2123 RVA: 0x00004BD7 File Offset: 0x00002DD7
		public unsafe int gzip_header_xlen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GZipDecoder.NativeFieldInfoPtr_gzip_header_xlen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GZipDecoder.NativeFieldInfoPtr_gzip_header_xlen)) = value;
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x0600084C RID: 2124 RVA: 0x00034590 File Offset: 0x00032790
		// (set) Token: 0x0600084D RID: 2125 RVA: 0x00004BF2 File Offset: 0x00002DF2
		public unsafe uint expectedCrc32
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GZipDecoder.NativeFieldInfoPtr_expectedCrc32);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GZipDecoder.NativeFieldInfoPtr_expectedCrc32)) = value;
			}
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x0600084E RID: 2126 RVA: 0x000345B8 File Offset: 0x000327B8
		// (set) Token: 0x0600084F RID: 2127 RVA: 0x00004C0D File Offset: 0x00002E0D
		public unsafe uint expectedOutputStreamSizeModulo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GZipDecoder.NativeFieldInfoPtr_expectedOutputStreamSizeModulo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GZipDecoder.NativeFieldInfoPtr_expectedOutputStreamSizeModulo)) = value;
			}
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000850 RID: 2128 RVA: 0x000345E0 File Offset: 0x000327E0
		// (set) Token: 0x06000851 RID: 2129 RVA: 0x00004C28 File Offset: 0x00002E28
		public unsafe int loopCounter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GZipDecoder.NativeFieldInfoPtr_loopCounter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GZipDecoder.NativeFieldInfoPtr_loopCounter)) = value;
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06000852 RID: 2130 RVA: 0x00034608 File Offset: 0x00032808
		// (set) Token: 0x06000853 RID: 2131 RVA: 0x00004C43 File Offset: 0x00002E43
		public unsafe uint actualCrc32
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GZipDecoder.NativeFieldInfoPtr_actualCrc32);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GZipDecoder.NativeFieldInfoPtr_actualCrc32)) = value;
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06000854 RID: 2132 RVA: 0x00034630 File Offset: 0x00032830
		// (set) Token: 0x06000855 RID: 2133 RVA: 0x00004C5E File Offset: 0x00002E5E
		public unsafe long actualStreamSizeModulo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GZipDecoder.NativeFieldInfoPtr_actualStreamSizeModulo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GZipDecoder.NativeFieldInfoPtr_actualStreamSizeModulo)) = value;
			}
		}

		// Token: 0x04000629 RID: 1577
		private static readonly IntPtr NativeFieldInfoPtr_gzipHeaderSubstate;

		// Token: 0x0400062A RID: 1578
		private static readonly IntPtr NativeFieldInfoPtr_gzipFooterSubstate;

		// Token: 0x0400062B RID: 1579
		private static readonly IntPtr NativeFieldInfoPtr_gzip_header_flag;

		// Token: 0x0400062C RID: 1580
		private static readonly IntPtr NativeFieldInfoPtr_gzip_header_xlen;

		// Token: 0x0400062D RID: 1581
		private static readonly IntPtr NativeFieldInfoPtr_expectedCrc32;

		// Token: 0x0400062E RID: 1582
		private static readonly IntPtr NativeFieldInfoPtr_expectedOutputStreamSizeModulo;

		// Token: 0x0400062F RID: 1583
		private static readonly IntPtr NativeFieldInfoPtr_loopCounter;

		// Token: 0x04000630 RID: 1584
		private static readonly IntPtr NativeFieldInfoPtr_actualCrc32;

		// Token: 0x04000631 RID: 1585
		private static readonly IntPtr NativeFieldInfoPtr_actualStreamSizeModulo;

		// Token: 0x04000632 RID: 1586
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000633 RID: 1587
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

		// Token: 0x04000634 RID: 1588
		private static readonly IntPtr NativeMethodInfoPtr_ReadHeader_Public_Virtual_Final_New_Boolean_InputBuffer_0;

		// Token: 0x04000635 RID: 1589
		private static readonly IntPtr NativeMethodInfoPtr_ReadFooter_Public_Virtual_Final_New_Boolean_InputBuffer_0;

		// Token: 0x04000636 RID: 1590
		private static readonly IntPtr NativeMethodInfoPtr_UpdateWithBytesRead_Public_Virtual_Final_New_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04000637 RID: 1591
		private static readonly IntPtr NativeMethodInfoPtr_Validate_Public_Virtual_Final_New_Void_0;

		// Token: 0x02000282 RID: 642
		public enum GzipHeaderState
		{
			// Token: 0x040015BD RID: 5565
			ReadingID1,
			// Token: 0x040015BE RID: 5566
			ReadingID2,
			// Token: 0x040015BF RID: 5567
			ReadingCM,
			// Token: 0x040015C0 RID: 5568
			ReadingFLG,
			// Token: 0x040015C1 RID: 5569
			ReadingMMTime,
			// Token: 0x040015C2 RID: 5570
			ReadingXFL,
			// Token: 0x040015C3 RID: 5571
			ReadingOS,
			// Token: 0x040015C4 RID: 5572
			ReadingXLen1,
			// Token: 0x040015C5 RID: 5573
			ReadingXLen2,
			// Token: 0x040015C6 RID: 5574
			ReadingXLenData,
			// Token: 0x040015C7 RID: 5575
			ReadingFileName,
			// Token: 0x040015C8 RID: 5576
			ReadingComment,
			// Token: 0x040015C9 RID: 5577
			ReadingCRC16Part1,
			// Token: 0x040015CA RID: 5578
			ReadingCRC16Part2,
			// Token: 0x040015CB RID: 5579
			Done,
			// Token: 0x040015CC RID: 5580
			ReadingCRC,
			// Token: 0x040015CD RID: 5581
			ReadingFileSize
		}

		// Token: 0x02000283 RID: 643
		[Flags]
		public enum GZipOptionalHeaderFlags
		{
			// Token: 0x040015CF RID: 5583
			CRCFlag = 2,
			// Token: 0x040015D0 RID: 5584
			ExtraFieldsFlag = 4,
			// Token: 0x040015D1 RID: 5585
			FileNameFlag = 8,
			// Token: 0x040015D2 RID: 5586
			CommentFlag = 16
		}
	}
}
