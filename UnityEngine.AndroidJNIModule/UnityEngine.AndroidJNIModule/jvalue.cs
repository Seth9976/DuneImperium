using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200000B RID: 11
	[StructLayout(2)]
	public struct jvalue
	{
		// Token: 0x060000B2 RID: 178 RVA: 0x00006054 File Offset: 0x00004254
		// Note: this type is marked as 'beforefieldinit'.
		static jvalue()
		{
			Il2CppClassPointerStore<jvalue>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AndroidJNIModule.dll", "UnityEngine", "jvalue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<jvalue>.NativeClassPtr);
			jvalue.NativeFieldInfoPtr_z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<jvalue>.NativeClassPtr, "z");
			jvalue.NativeFieldInfoPtr_b = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<jvalue>.NativeClassPtr, "b");
			jvalue.NativeFieldInfoPtr_c = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<jvalue>.NativeClassPtr, "c");
			jvalue.NativeFieldInfoPtr_s = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<jvalue>.NativeClassPtr, "s");
			jvalue.NativeFieldInfoPtr_i = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<jvalue>.NativeClassPtr, "i");
			jvalue.NativeFieldInfoPtr_j = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<jvalue>.NativeClassPtr, "j");
			jvalue.NativeFieldInfoPtr_f = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<jvalue>.NativeClassPtr, "f");
			jvalue.NativeFieldInfoPtr_d = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<jvalue>.NativeClassPtr, "d");
			jvalue.NativeFieldInfoPtr_l = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<jvalue>.NativeClassPtr, "l");
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x000023FD File Offset: 0x000005FD
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<jvalue>.NativeClassPtr, ref this));
		}

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeFieldInfoPtr_z;

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeFieldInfoPtr_b;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeFieldInfoPtr_c;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeFieldInfoPtr_s;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeFieldInfoPtr_i;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeFieldInfoPtr_j;

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeFieldInfoPtr_f;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeFieldInfoPtr_d;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeFieldInfoPtr_l;

		// Token: 0x04000064 RID: 100
		[FieldOffset(0)]
		[MarshalAs(4)]
		public bool z;

		// Token: 0x04000065 RID: 101
		[FieldOffset(0)]
		public sbyte b;

		// Token: 0x04000066 RID: 102
		[FieldOffset(0)]
		public char c;

		// Token: 0x04000067 RID: 103
		[FieldOffset(0)]
		public short s;

		// Token: 0x04000068 RID: 104
		[FieldOffset(0)]
		public int i;

		// Token: 0x04000069 RID: 105
		[FieldOffset(0)]
		public long j;

		// Token: 0x0400006A RID: 106
		[FieldOffset(0)]
		public float f;

		// Token: 0x0400006B RID: 107
		[FieldOffset(0)]
		public double d;

		// Token: 0x0400006C RID: 108
		[FieldOffset(0)]
		public IntPtr l;
	}
}
