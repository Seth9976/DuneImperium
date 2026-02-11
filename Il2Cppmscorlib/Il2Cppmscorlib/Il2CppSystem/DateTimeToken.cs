using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x0200009C RID: 156
	[StructLayout(2)]
	public struct DateTimeToken
	{
		// Token: 0x06000AE6 RID: 2790 RVA: 0x00057FF8 File Offset: 0x000561F8
		// Note: this type is marked as 'beforefieldinit'.
		static DateTimeToken()
		{
			Il2CppClassPointerStore<DateTimeToken>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "DateTimeToken");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DateTimeToken>.NativeClassPtr);
			DateTimeToken.NativeFieldInfoPtr_dtt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeToken>.NativeClassPtr, "dtt");
			DateTimeToken.NativeFieldInfoPtr_suffix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeToken>.NativeClassPtr, "suffix");
			DateTimeToken.NativeFieldInfoPtr_num = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeToken>.NativeClassPtr, "num");
		}

		// Token: 0x06000AE7 RID: 2791 RVA: 0x00004A4A File Offset: 0x00002C4A
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DateTimeToken>.NativeClassPtr, ref this));
		}

		// Token: 0x04000893 RID: 2195
		private static readonly IntPtr NativeFieldInfoPtr_dtt;

		// Token: 0x04000894 RID: 2196
		private static readonly IntPtr NativeFieldInfoPtr_suffix;

		// Token: 0x04000895 RID: 2197
		private static readonly IntPtr NativeFieldInfoPtr_num;

		// Token: 0x04000896 RID: 2198
		[FieldOffset(0)]
		public DateTimeParse.DTT dtt;

		// Token: 0x04000897 RID: 2199
		[FieldOffset(4)]
		public TokenType suffix;

		// Token: 0x04000898 RID: 2200
		[FieldOffset(8)]
		public int num;
	}
}
