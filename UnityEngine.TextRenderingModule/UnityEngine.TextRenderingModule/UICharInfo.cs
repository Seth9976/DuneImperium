using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200000A RID: 10
	[StructLayout(2)]
	public struct UICharInfo
	{
		// Token: 0x06000089 RID: 137 RVA: 0x000045A0 File Offset: 0x000027A0
		// Note: this type is marked as 'beforefieldinit'.
		static UICharInfo()
		{
			Il2CppClassPointerStore<UICharInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextRenderingModule.dll", "UnityEngine", "UICharInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UICharInfo>.NativeClassPtr);
			UICharInfo.NativeFieldInfoPtr_cursorPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICharInfo>.NativeClassPtr, "cursorPos");
			UICharInfo.NativeFieldInfoPtr_charWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICharInfo>.NativeClassPtr, "charWidth");
		}

		// Token: 0x0600008A RID: 138 RVA: 0x0000249C File Offset: 0x0000069C
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UICharInfo>.NativeClassPtr, ref this));
		}

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeFieldInfoPtr_cursorPos;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeFieldInfoPtr_charWidth;

		// Token: 0x0400006F RID: 111
		[FieldOffset(0)]
		public Vector2 cursorPos;

		// Token: 0x04000070 RID: 112
		[FieldOffset(8)]
		public float charWidth;
	}
}
