using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Yoga
{
	// Token: 0x02000014 RID: 20
	[StructLayout(2)]
	public struct YogaSize
	{
		// Token: 0x0600015E RID: 350 RVA: 0x000211EC File Offset: 0x0001F3EC
		// Note: this type is marked as 'beforefieldinit'.
		static YogaSize()
		{
			Il2CppClassPointerStore<YogaSize>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.Yoga", "YogaSize");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<YogaSize>.NativeClassPtr);
			YogaSize.NativeFieldInfoPtr_width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YogaSize>.NativeClassPtr, "width");
			YogaSize.NativeFieldInfoPtr_height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YogaSize>.NativeClassPtr, "height");
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00002608 File Offset: 0x00000808
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<YogaSize>.NativeClassPtr, ref this));
		}

		// Token: 0x04000109 RID: 265
		private static readonly IntPtr NativeFieldInfoPtr_width;

		// Token: 0x0400010A RID: 266
		private static readonly IntPtr NativeFieldInfoPtr_height;

		// Token: 0x0400010B RID: 267
		[FieldOffset(0)]
		public float width;

		// Token: 0x0400010C RID: 268
		[FieldOffset(4)]
		public float height;
	}
}
