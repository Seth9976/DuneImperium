using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.TextCore.Text
{
	// Token: 0x0200000C RID: 12
	[StructLayout(2)]
	public struct LineInfo
	{
		// Token: 0x06000158 RID: 344 RVA: 0x0000AF60 File Offset: 0x00009160
		// Note: this type is marked as 'beforefieldinit'.
		static LineInfo()
		{
			Il2CppClassPointerStore<LineInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreTextEngineModule.dll", "UnityEngine.TextCore.Text", "LineInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LineInfo>.NativeClassPtr);
			LineInfo.NativeFieldInfoPtr_controlCharacterCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineInfo>.NativeClassPtr, "controlCharacterCount");
			LineInfo.NativeFieldInfoPtr_characterCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineInfo>.NativeClassPtr, "characterCount");
			LineInfo.NativeFieldInfoPtr_visibleCharacterCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineInfo>.NativeClassPtr, "visibleCharacterCount");
			LineInfo.NativeFieldInfoPtr_spaceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineInfo>.NativeClassPtr, "spaceCount");
			LineInfo.NativeFieldInfoPtr_visibleSpaceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineInfo>.NativeClassPtr, "visibleSpaceCount");
			LineInfo.NativeFieldInfoPtr_wordCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineInfo>.NativeClassPtr, "wordCount");
			LineInfo.NativeFieldInfoPtr_firstCharacterIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineInfo>.NativeClassPtr, "firstCharacterIndex");
			LineInfo.NativeFieldInfoPtr_firstVisibleCharacterIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineInfo>.NativeClassPtr, "firstVisibleCharacterIndex");
			LineInfo.NativeFieldInfoPtr_lastCharacterIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineInfo>.NativeClassPtr, "lastCharacterIndex");
			LineInfo.NativeFieldInfoPtr_lastVisibleCharacterIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineInfo>.NativeClassPtr, "lastVisibleCharacterIndex");
			LineInfo.NativeFieldInfoPtr_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineInfo>.NativeClassPtr, "length");
			LineInfo.NativeFieldInfoPtr_lineHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineInfo>.NativeClassPtr, "lineHeight");
			LineInfo.NativeFieldInfoPtr_ascender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineInfo>.NativeClassPtr, "ascender");
			LineInfo.NativeFieldInfoPtr_baseline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineInfo>.NativeClassPtr, "baseline");
			LineInfo.NativeFieldInfoPtr_descender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineInfo>.NativeClassPtr, "descender");
			LineInfo.NativeFieldInfoPtr_maxAdvance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineInfo>.NativeClassPtr, "maxAdvance");
			LineInfo.NativeFieldInfoPtr_width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineInfo>.NativeClassPtr, "width");
			LineInfo.NativeFieldInfoPtr_marginLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineInfo>.NativeClassPtr, "marginLeft");
			LineInfo.NativeFieldInfoPtr_marginRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineInfo>.NativeClassPtr, "marginRight");
			LineInfo.NativeFieldInfoPtr_alignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineInfo>.NativeClassPtr, "alignment");
			LineInfo.NativeFieldInfoPtr_lineExtents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineInfo>.NativeClassPtr, "lineExtents");
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00002A5F File Offset: 0x00000C5F
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LineInfo>.NativeClassPtr, ref this));
		}

		// Token: 0x040000F2 RID: 242
		private static readonly IntPtr NativeFieldInfoPtr_controlCharacterCount;

		// Token: 0x040000F3 RID: 243
		private static readonly IntPtr NativeFieldInfoPtr_characterCount;

		// Token: 0x040000F4 RID: 244
		private static readonly IntPtr NativeFieldInfoPtr_visibleCharacterCount;

		// Token: 0x040000F5 RID: 245
		private static readonly IntPtr NativeFieldInfoPtr_spaceCount;

		// Token: 0x040000F6 RID: 246
		private static readonly IntPtr NativeFieldInfoPtr_visibleSpaceCount;

		// Token: 0x040000F7 RID: 247
		private static readonly IntPtr NativeFieldInfoPtr_wordCount;

		// Token: 0x040000F8 RID: 248
		private static readonly IntPtr NativeFieldInfoPtr_firstCharacterIndex;

		// Token: 0x040000F9 RID: 249
		private static readonly IntPtr NativeFieldInfoPtr_firstVisibleCharacterIndex;

		// Token: 0x040000FA RID: 250
		private static readonly IntPtr NativeFieldInfoPtr_lastCharacterIndex;

		// Token: 0x040000FB RID: 251
		private static readonly IntPtr NativeFieldInfoPtr_lastVisibleCharacterIndex;

		// Token: 0x040000FC RID: 252
		private static readonly IntPtr NativeFieldInfoPtr_length;

		// Token: 0x040000FD RID: 253
		private static readonly IntPtr NativeFieldInfoPtr_lineHeight;

		// Token: 0x040000FE RID: 254
		private static readonly IntPtr NativeFieldInfoPtr_ascender;

		// Token: 0x040000FF RID: 255
		private static readonly IntPtr NativeFieldInfoPtr_baseline;

		// Token: 0x04000100 RID: 256
		private static readonly IntPtr NativeFieldInfoPtr_descender;

		// Token: 0x04000101 RID: 257
		private static readonly IntPtr NativeFieldInfoPtr_maxAdvance;

		// Token: 0x04000102 RID: 258
		private static readonly IntPtr NativeFieldInfoPtr_width;

		// Token: 0x04000103 RID: 259
		private static readonly IntPtr NativeFieldInfoPtr_marginLeft;

		// Token: 0x04000104 RID: 260
		private static readonly IntPtr NativeFieldInfoPtr_marginRight;

		// Token: 0x04000105 RID: 261
		private static readonly IntPtr NativeFieldInfoPtr_alignment;

		// Token: 0x04000106 RID: 262
		private static readonly IntPtr NativeFieldInfoPtr_lineExtents;

		// Token: 0x04000107 RID: 263
		[FieldOffset(0)]
		public int controlCharacterCount;

		// Token: 0x04000108 RID: 264
		[FieldOffset(4)]
		public int characterCount;

		// Token: 0x04000109 RID: 265
		[FieldOffset(8)]
		public int visibleCharacterCount;

		// Token: 0x0400010A RID: 266
		[FieldOffset(12)]
		public int spaceCount;

		// Token: 0x0400010B RID: 267
		[FieldOffset(16)]
		public int visibleSpaceCount;

		// Token: 0x0400010C RID: 268
		[FieldOffset(20)]
		public int wordCount;

		// Token: 0x0400010D RID: 269
		[FieldOffset(24)]
		public int firstCharacterIndex;

		// Token: 0x0400010E RID: 270
		[FieldOffset(28)]
		public int firstVisibleCharacterIndex;

		// Token: 0x0400010F RID: 271
		[FieldOffset(32)]
		public int lastCharacterIndex;

		// Token: 0x04000110 RID: 272
		[FieldOffset(36)]
		public int lastVisibleCharacterIndex;

		// Token: 0x04000111 RID: 273
		[FieldOffset(40)]
		public float length;

		// Token: 0x04000112 RID: 274
		[FieldOffset(44)]
		public float lineHeight;

		// Token: 0x04000113 RID: 275
		[FieldOffset(48)]
		public float ascender;

		// Token: 0x04000114 RID: 276
		[FieldOffset(52)]
		public float baseline;

		// Token: 0x04000115 RID: 277
		[FieldOffset(56)]
		public float descender;

		// Token: 0x04000116 RID: 278
		[FieldOffset(60)]
		public float maxAdvance;

		// Token: 0x04000117 RID: 279
		[FieldOffset(64)]
		public float width;

		// Token: 0x04000118 RID: 280
		[FieldOffset(68)]
		public float marginLeft;

		// Token: 0x04000119 RID: 281
		[FieldOffset(72)]
		public float marginRight;

		// Token: 0x0400011A RID: 282
		[FieldOffset(76)]
		public TextAlignment alignment;

		// Token: 0x0400011B RID: 283
		[FieldOffset(80)]
		public Extents lineExtents;
	}
}
