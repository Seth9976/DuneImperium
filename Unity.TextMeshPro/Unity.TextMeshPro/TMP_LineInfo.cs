using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace TMPro
{
	// Token: 0x02000043 RID: 67
	[StructLayout(2)]
	public struct TMP_LineInfo
	{
		// Token: 0x060007B0 RID: 1968 RVA: 0x00023E80 File Offset: 0x00022080
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_LineInfo()
		{
			Il2CppClassPointerStore<TMP_LineInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_LineInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_LineInfo>.NativeClassPtr);
			TMP_LineInfo.NativeFieldInfoPtr_controlCharacterCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_LineInfo>.NativeClassPtr, "controlCharacterCount");
			TMP_LineInfo.NativeFieldInfoPtr_characterCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_LineInfo>.NativeClassPtr, "characterCount");
			TMP_LineInfo.NativeFieldInfoPtr_visibleCharacterCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_LineInfo>.NativeClassPtr, "visibleCharacterCount");
			TMP_LineInfo.NativeFieldInfoPtr_spaceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_LineInfo>.NativeClassPtr, "spaceCount");
			TMP_LineInfo.NativeFieldInfoPtr_wordCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_LineInfo>.NativeClassPtr, "wordCount");
			TMP_LineInfo.NativeFieldInfoPtr_firstCharacterIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_LineInfo>.NativeClassPtr, "firstCharacterIndex");
			TMP_LineInfo.NativeFieldInfoPtr_firstVisibleCharacterIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_LineInfo>.NativeClassPtr, "firstVisibleCharacterIndex");
			TMP_LineInfo.NativeFieldInfoPtr_lastCharacterIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_LineInfo>.NativeClassPtr, "lastCharacterIndex");
			TMP_LineInfo.NativeFieldInfoPtr_lastVisibleCharacterIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_LineInfo>.NativeClassPtr, "lastVisibleCharacterIndex");
			TMP_LineInfo.NativeFieldInfoPtr_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_LineInfo>.NativeClassPtr, "length");
			TMP_LineInfo.NativeFieldInfoPtr_lineHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_LineInfo>.NativeClassPtr, "lineHeight");
			TMP_LineInfo.NativeFieldInfoPtr_ascender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_LineInfo>.NativeClassPtr, "ascender");
			TMP_LineInfo.NativeFieldInfoPtr_baseline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_LineInfo>.NativeClassPtr, "baseline");
			TMP_LineInfo.NativeFieldInfoPtr_descender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_LineInfo>.NativeClassPtr, "descender");
			TMP_LineInfo.NativeFieldInfoPtr_maxAdvance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_LineInfo>.NativeClassPtr, "maxAdvance");
			TMP_LineInfo.NativeFieldInfoPtr_width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_LineInfo>.NativeClassPtr, "width");
			TMP_LineInfo.NativeFieldInfoPtr_marginLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_LineInfo>.NativeClassPtr, "marginLeft");
			TMP_LineInfo.NativeFieldInfoPtr_marginRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_LineInfo>.NativeClassPtr, "marginRight");
			TMP_LineInfo.NativeFieldInfoPtr_alignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_LineInfo>.NativeClassPtr, "alignment");
			TMP_LineInfo.NativeFieldInfoPtr_lineExtents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_LineInfo>.NativeClassPtr, "lineExtents");
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x000059BB File Offset: 0x00003BBB
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_LineInfo>.NativeClassPtr, ref this));
		}

		// Token: 0x040005B1 RID: 1457
		private static readonly IntPtr NativeFieldInfoPtr_controlCharacterCount;

		// Token: 0x040005B2 RID: 1458
		private static readonly IntPtr NativeFieldInfoPtr_characterCount;

		// Token: 0x040005B3 RID: 1459
		private static readonly IntPtr NativeFieldInfoPtr_visibleCharacterCount;

		// Token: 0x040005B4 RID: 1460
		private static readonly IntPtr NativeFieldInfoPtr_spaceCount;

		// Token: 0x040005B5 RID: 1461
		private static readonly IntPtr NativeFieldInfoPtr_wordCount;

		// Token: 0x040005B6 RID: 1462
		private static readonly IntPtr NativeFieldInfoPtr_firstCharacterIndex;

		// Token: 0x040005B7 RID: 1463
		private static readonly IntPtr NativeFieldInfoPtr_firstVisibleCharacterIndex;

		// Token: 0x040005B8 RID: 1464
		private static readonly IntPtr NativeFieldInfoPtr_lastCharacterIndex;

		// Token: 0x040005B9 RID: 1465
		private static readonly IntPtr NativeFieldInfoPtr_lastVisibleCharacterIndex;

		// Token: 0x040005BA RID: 1466
		private static readonly IntPtr NativeFieldInfoPtr_length;

		// Token: 0x040005BB RID: 1467
		private static readonly IntPtr NativeFieldInfoPtr_lineHeight;

		// Token: 0x040005BC RID: 1468
		private static readonly IntPtr NativeFieldInfoPtr_ascender;

		// Token: 0x040005BD RID: 1469
		private static readonly IntPtr NativeFieldInfoPtr_baseline;

		// Token: 0x040005BE RID: 1470
		private static readonly IntPtr NativeFieldInfoPtr_descender;

		// Token: 0x040005BF RID: 1471
		private static readonly IntPtr NativeFieldInfoPtr_maxAdvance;

		// Token: 0x040005C0 RID: 1472
		private static readonly IntPtr NativeFieldInfoPtr_width;

		// Token: 0x040005C1 RID: 1473
		private static readonly IntPtr NativeFieldInfoPtr_marginLeft;

		// Token: 0x040005C2 RID: 1474
		private static readonly IntPtr NativeFieldInfoPtr_marginRight;

		// Token: 0x040005C3 RID: 1475
		private static readonly IntPtr NativeFieldInfoPtr_alignment;

		// Token: 0x040005C4 RID: 1476
		private static readonly IntPtr NativeFieldInfoPtr_lineExtents;

		// Token: 0x040005C5 RID: 1477
		[FieldOffset(0)]
		public int controlCharacterCount;

		// Token: 0x040005C6 RID: 1478
		[FieldOffset(4)]
		public int characterCount;

		// Token: 0x040005C7 RID: 1479
		[FieldOffset(8)]
		public int visibleCharacterCount;

		// Token: 0x040005C8 RID: 1480
		[FieldOffset(12)]
		public int spaceCount;

		// Token: 0x040005C9 RID: 1481
		[FieldOffset(16)]
		public int wordCount;

		// Token: 0x040005CA RID: 1482
		[FieldOffset(20)]
		public int firstCharacterIndex;

		// Token: 0x040005CB RID: 1483
		[FieldOffset(24)]
		public int firstVisibleCharacterIndex;

		// Token: 0x040005CC RID: 1484
		[FieldOffset(28)]
		public int lastCharacterIndex;

		// Token: 0x040005CD RID: 1485
		[FieldOffset(32)]
		public int lastVisibleCharacterIndex;

		// Token: 0x040005CE RID: 1486
		[FieldOffset(36)]
		public float length;

		// Token: 0x040005CF RID: 1487
		[FieldOffset(40)]
		public float lineHeight;

		// Token: 0x040005D0 RID: 1488
		[FieldOffset(44)]
		public float ascender;

		// Token: 0x040005D1 RID: 1489
		[FieldOffset(48)]
		public float baseline;

		// Token: 0x040005D2 RID: 1490
		[FieldOffset(52)]
		public float descender;

		// Token: 0x040005D3 RID: 1491
		[FieldOffset(56)]
		public float maxAdvance;

		// Token: 0x040005D4 RID: 1492
		[FieldOffset(60)]
		public float width;

		// Token: 0x040005D5 RID: 1493
		[FieldOffset(64)]
		public float marginLeft;

		// Token: 0x040005D6 RID: 1494
		[FieldOffset(68)]
		public float marginRight;

		// Token: 0x040005D7 RID: 1495
		[FieldOffset(72)]
		public HorizontalAlignmentOptions alignment;

		// Token: 0x040005D8 RID: 1496
		[FieldOffset(76)]
		public Extents lineExtents;
	}
}
