using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200000B RID: 11
	[StructLayout(2)]
	public struct UILineInfo
	{
		// Token: 0x0600008B RID: 139 RVA: 0x000045F8 File Offset: 0x000027F8
		// Note: this type is marked as 'beforefieldinit'.
		static UILineInfo()
		{
			Il2CppClassPointerStore<UILineInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextRenderingModule.dll", "UnityEngine", "UILineInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UILineInfo>.NativeClassPtr);
			UILineInfo.NativeFieldInfoPtr_startCharIdx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILineInfo>.NativeClassPtr, "startCharIdx");
			UILineInfo.NativeFieldInfoPtr_height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILineInfo>.NativeClassPtr, "height");
			UILineInfo.NativeFieldInfoPtr_topY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILineInfo>.NativeClassPtr, "topY");
			UILineInfo.NativeFieldInfoPtr_leading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILineInfo>.NativeClassPtr, "leading");
		}

		// Token: 0x0600008C RID: 140 RVA: 0x000024AE File Offset: 0x000006AE
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UILineInfo>.NativeClassPtr, ref this));
		}

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeFieldInfoPtr_startCharIdx;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeFieldInfoPtr_height;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeFieldInfoPtr_topY;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeFieldInfoPtr_leading;

		// Token: 0x04000075 RID: 117
		[FieldOffset(0)]
		public int startCharIdx;

		// Token: 0x04000076 RID: 118
		[FieldOffset(4)]
		public int height;

		// Token: 0x04000077 RID: 119
		[FieldOffset(8)]
		public float topY;

		// Token: 0x04000078 RID: 120
		[FieldOffset(12)]
		public float leading;
	}
}
