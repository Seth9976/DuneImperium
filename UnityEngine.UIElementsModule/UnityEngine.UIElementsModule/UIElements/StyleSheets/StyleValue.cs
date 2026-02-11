using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Runtime.InteropServices;

namespace UnityEngine.UIElements.StyleSheets
{
	// Token: 0x0200028F RID: 655
	[StructLayout(2)]
	public struct StyleValue
	{
		// Token: 0x060030DF RID: 12511 RVA: 0x000CF6EC File Offset: 0x000CD8EC
		// Note: this type is marked as 'beforefieldinit'.
		static StyleValue()
		{
			Il2CppClassPointerStore<StyleValue>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.StyleSheets", "StyleValue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StyleValue>.NativeClassPtr);
			StyleValue.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleValue>.NativeClassPtr, "id");
			StyleValue.NativeFieldInfoPtr_keyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleValue>.NativeClassPtr, "keyword");
			StyleValue.NativeFieldInfoPtr_number = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleValue>.NativeClassPtr, "number");
			StyleValue.NativeFieldInfoPtr_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleValue>.NativeClassPtr, "length");
			StyleValue.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleValue>.NativeClassPtr, "color");
			StyleValue.NativeFieldInfoPtr_resource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleValue>.NativeClassPtr, "resource");
			StyleValue.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleValue>.NativeClassPtr, "position");
			StyleValue.NativeFieldInfoPtr_repeat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleValue>.NativeClassPtr, "repeat");
		}

		// Token: 0x060030E0 RID: 12512 RVA: 0x00013F65 File Offset: 0x00012165
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StyleValue>.NativeClassPtr, ref this));
		}

		// Token: 0x040023A9 RID: 9129
		private static readonly IntPtr NativeFieldInfoPtr_id;

		// Token: 0x040023AA RID: 9130
		private static readonly IntPtr NativeFieldInfoPtr_keyword;

		// Token: 0x040023AB RID: 9131
		private static readonly IntPtr NativeFieldInfoPtr_number;

		// Token: 0x040023AC RID: 9132
		private static readonly IntPtr NativeFieldInfoPtr_length;

		// Token: 0x040023AD RID: 9133
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x040023AE RID: 9134
		private static readonly IntPtr NativeFieldInfoPtr_resource;

		// Token: 0x040023AF RID: 9135
		private static readonly IntPtr NativeFieldInfoPtr_position;

		// Token: 0x040023B0 RID: 9136
		private static readonly IntPtr NativeFieldInfoPtr_repeat;

		// Token: 0x040023B1 RID: 9137
		[FieldOffset(0)]
		public StylePropertyId id;

		// Token: 0x040023B2 RID: 9138
		[FieldOffset(4)]
		public StyleKeyword keyword;

		// Token: 0x040023B3 RID: 9139
		[FieldOffset(8)]
		public float number;

		// Token: 0x040023B4 RID: 9140
		[FieldOffset(8)]
		public Length length;

		// Token: 0x040023B5 RID: 9141
		[FieldOffset(8)]
		public Color color;

		// Token: 0x040023B6 RID: 9142
		[FieldOffset(8)]
		public GCHandle resource;

		// Token: 0x040023B7 RID: 9143
		[FieldOffset(8)]
		public BackgroundPosition position;

		// Token: 0x040023B8 RID: 9144
		[FieldOffset(8)]
		public BackgroundRepeat repeat;
	}
}
