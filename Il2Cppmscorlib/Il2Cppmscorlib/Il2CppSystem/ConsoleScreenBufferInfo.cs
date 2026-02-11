using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x0200017C RID: 380
	[StructLayout(2)]
	public struct ConsoleScreenBufferInfo
	{
		// Token: 0x06001945 RID: 6469 RVA: 0x0009CDE4 File Offset: 0x0009AFE4
		// Note: this type is marked as 'beforefieldinit'.
		static ConsoleScreenBufferInfo()
		{
			Il2CppClassPointerStore<ConsoleScreenBufferInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ConsoleScreenBufferInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConsoleScreenBufferInfo>.NativeClassPtr);
			ConsoleScreenBufferInfo.NativeFieldInfoPtr_Size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleScreenBufferInfo>.NativeClassPtr, "Size");
			ConsoleScreenBufferInfo.NativeFieldInfoPtr_CursorPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleScreenBufferInfo>.NativeClassPtr, "CursorPosition");
			ConsoleScreenBufferInfo.NativeFieldInfoPtr_Attribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleScreenBufferInfo>.NativeClassPtr, "Attribute");
			ConsoleScreenBufferInfo.NativeFieldInfoPtr_Window = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleScreenBufferInfo>.NativeClassPtr, "Window");
			ConsoleScreenBufferInfo.NativeFieldInfoPtr_MaxWindowSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleScreenBufferInfo>.NativeClassPtr, "MaxWindowSize");
		}

		// Token: 0x06001946 RID: 6470 RVA: 0x00008211 File Offset: 0x00006411
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConsoleScreenBufferInfo>.NativeClassPtr, ref this));
		}

		// Token: 0x04001767 RID: 5991
		private static readonly IntPtr NativeFieldInfoPtr_Size;

		// Token: 0x04001768 RID: 5992
		private static readonly IntPtr NativeFieldInfoPtr_CursorPosition;

		// Token: 0x04001769 RID: 5993
		private static readonly IntPtr NativeFieldInfoPtr_Attribute;

		// Token: 0x0400176A RID: 5994
		private static readonly IntPtr NativeFieldInfoPtr_Window;

		// Token: 0x0400176B RID: 5995
		private static readonly IntPtr NativeFieldInfoPtr_MaxWindowSize;

		// Token: 0x0400176C RID: 5996
		[FieldOffset(0)]
		public Coord Size;

		// Token: 0x0400176D RID: 5997
		[FieldOffset(4)]
		public Coord CursorPosition;

		// Token: 0x0400176E RID: 5998
		[FieldOffset(8)]
		public short Attribute;

		// Token: 0x0400176F RID: 5999
		[FieldOffset(10)]
		public SmallRect Window;

		// Token: 0x04001770 RID: 6000
		[FieldOffset(18)]
		public Coord MaxWindowSize;
	}
}
