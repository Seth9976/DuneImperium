using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.TextCore.LowLevel
{
	// Token: 0x0200000E RID: 14
	[StructLayout(2)]
	public struct GlyphMarshallingStruct
	{
		// Token: 0x06000154 RID: 340 RVA: 0x00006A98 File Offset: 0x00004C98
		// Note: this type is marked as 'beforefieldinit'.
		static GlyphMarshallingStruct()
		{
			Il2CppClassPointerStore<GlyphMarshallingStruct>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreFontEngineModule.dll", "UnityEngine.TextCore.LowLevel", "GlyphMarshallingStruct");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlyphMarshallingStruct>.NativeClassPtr);
			GlyphMarshallingStruct.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphMarshallingStruct>.NativeClassPtr, "index");
			GlyphMarshallingStruct.NativeFieldInfoPtr_metrics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphMarshallingStruct>.NativeClassPtr, "metrics");
			GlyphMarshallingStruct.NativeFieldInfoPtr_glyphRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphMarshallingStruct>.NativeClassPtr, "glyphRect");
			GlyphMarshallingStruct.NativeFieldInfoPtr_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphMarshallingStruct>.NativeClassPtr, "scale");
			GlyphMarshallingStruct.NativeFieldInfoPtr_atlasIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphMarshallingStruct>.NativeClassPtr, "atlasIndex");
			GlyphMarshallingStruct.NativeFieldInfoPtr_classDefinitionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphMarshallingStruct>.NativeClassPtr, "classDefinitionType");
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00002ACE File Offset: 0x00000CCE
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlyphMarshallingStruct>.NativeClassPtr, ref this));
		}

		// Token: 0x04000115 RID: 277
		private static readonly IntPtr NativeFieldInfoPtr_index;

		// Token: 0x04000116 RID: 278
		private static readonly IntPtr NativeFieldInfoPtr_metrics;

		// Token: 0x04000117 RID: 279
		private static readonly IntPtr NativeFieldInfoPtr_glyphRect;

		// Token: 0x04000118 RID: 280
		private static readonly IntPtr NativeFieldInfoPtr_scale;

		// Token: 0x04000119 RID: 281
		private static readonly IntPtr NativeFieldInfoPtr_atlasIndex;

		// Token: 0x0400011A RID: 282
		private static readonly IntPtr NativeFieldInfoPtr_classDefinitionType;

		// Token: 0x0400011B RID: 283
		[FieldOffset(0)]
		public uint index;

		// Token: 0x0400011C RID: 284
		[FieldOffset(4)]
		public GlyphMetrics metrics;

		// Token: 0x0400011D RID: 285
		[FieldOffset(24)]
		public GlyphRect glyphRect;

		// Token: 0x0400011E RID: 286
		[FieldOffset(40)]
		public float scale;

		// Token: 0x0400011F RID: 287
		[FieldOffset(44)]
		public int atlasIndex;

		// Token: 0x04000120 RID: 288
		[FieldOffset(48)]
		public GlyphClassDefinitionType classDefinitionType;
	}
}
