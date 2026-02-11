using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.TextCore.Text
{
	// Token: 0x0200001B RID: 27
	[StructLayout(2)]
	public struct TextVertex
	{
		// Token: 0x06000257 RID: 599 RVA: 0x0000E528 File Offset: 0x0000C728
		// Note: this type is marked as 'beforefieldinit'.
		static TextVertex()
		{
			Il2CppClassPointerStore<TextVertex>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreTextEngineModule.dll", "UnityEngine.TextCore.Text", "TextVertex");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextVertex>.NativeClassPtr);
			TextVertex.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextVertex>.NativeClassPtr, "position");
			TextVertex.NativeFieldInfoPtr_uv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextVertex>.NativeClassPtr, "uv");
			TextVertex.NativeFieldInfoPtr_uv2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextVertex>.NativeClassPtr, "uv2");
			TextVertex.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextVertex>.NativeClassPtr, "color");
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00003272 File Offset: 0x00001472
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextVertex>.NativeClassPtr, ref this));
		}

		// Token: 0x040001C0 RID: 448
		private static readonly IntPtr NativeFieldInfoPtr_position;

		// Token: 0x040001C1 RID: 449
		private static readonly IntPtr NativeFieldInfoPtr_uv;

		// Token: 0x040001C2 RID: 450
		private static readonly IntPtr NativeFieldInfoPtr_uv2;

		// Token: 0x040001C3 RID: 451
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x040001C4 RID: 452
		[FieldOffset(0)]
		public Vector3 position;

		// Token: 0x040001C5 RID: 453
		[FieldOffset(12)]
		public Vector4 uv;

		// Token: 0x040001C6 RID: 454
		[FieldOffset(28)]
		public Vector2 uv2;

		// Token: 0x040001C7 RID: 455
		[FieldOffset(36)]
		public Color32 color;
	}
}
