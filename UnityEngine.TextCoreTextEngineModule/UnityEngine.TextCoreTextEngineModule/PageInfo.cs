using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.TextCore.Text
{
	// Token: 0x0200002E RID: 46
	[StructLayout(2)]
	public struct PageInfo
	{
		// Token: 0x0600055F RID: 1375 RVA: 0x000172D4 File Offset: 0x000154D4
		// Note: this type is marked as 'beforefieldinit'.
		static PageInfo()
		{
			Il2CppClassPointerStore<PageInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreTextEngineModule.dll", "UnityEngine.TextCore.Text", "PageInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PageInfo>.NativeClassPtr);
			PageInfo.NativeFieldInfoPtr_firstCharacterIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PageInfo>.NativeClassPtr, "firstCharacterIndex");
			PageInfo.NativeFieldInfoPtr_lastCharacterIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PageInfo>.NativeClassPtr, "lastCharacterIndex");
			PageInfo.NativeFieldInfoPtr_ascender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PageInfo>.NativeClassPtr, "ascender");
			PageInfo.NativeFieldInfoPtr_baseLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PageInfo>.NativeClassPtr, "baseLine");
			PageInfo.NativeFieldInfoPtr_descender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PageInfo>.NativeClassPtr, "descender");
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x000055C8 File Offset: 0x000037C8
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PageInfo>.NativeClassPtr, ref this));
		}

		// Token: 0x0400040B RID: 1035
		private static readonly IntPtr NativeFieldInfoPtr_firstCharacterIndex;

		// Token: 0x0400040C RID: 1036
		private static readonly IntPtr NativeFieldInfoPtr_lastCharacterIndex;

		// Token: 0x0400040D RID: 1037
		private static readonly IntPtr NativeFieldInfoPtr_ascender;

		// Token: 0x0400040E RID: 1038
		private static readonly IntPtr NativeFieldInfoPtr_baseLine;

		// Token: 0x0400040F RID: 1039
		private static readonly IntPtr NativeFieldInfoPtr_descender;

		// Token: 0x04000410 RID: 1040
		[FieldOffset(0)]
		public int firstCharacterIndex;

		// Token: 0x04000411 RID: 1041
		[FieldOffset(4)]
		public int lastCharacterIndex;

		// Token: 0x04000412 RID: 1042
		[FieldOffset(8)]
		public float ascender;

		// Token: 0x04000413 RID: 1043
		[FieldOffset(12)]
		public float baseLine;

		// Token: 0x04000414 RID: 1044
		[FieldOffset(16)]
		public float descender;
	}
}
