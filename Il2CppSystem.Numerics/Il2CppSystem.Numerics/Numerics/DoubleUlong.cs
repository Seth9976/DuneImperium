using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Numerics
{
	// Token: 0x02000006 RID: 6
	[StructLayout(2)]
	public struct DoubleUlong
	{
		// Token: 0x06000089 RID: 137 RVA: 0x000052A0 File Offset: 0x000034A0
		// Note: this type is marked as 'beforefieldinit'.
		static DoubleUlong()
		{
			Il2CppClassPointerStore<DoubleUlong>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Numerics.dll", "System.Numerics", "DoubleUlong");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DoubleUlong>.NativeClassPtr);
			DoubleUlong.NativeFieldInfoPtr_dbl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoubleUlong>.NativeClassPtr, "dbl");
			DoubleUlong.NativeFieldInfoPtr_uu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoubleUlong>.NativeClassPtr, "uu");
		}

		// Token: 0x0600008A RID: 138 RVA: 0x0000219F File Offset: 0x0000039F
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DoubleUlong>.NativeClassPtr, ref this));
		}

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeFieldInfoPtr_dbl;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeFieldInfoPtr_uu;

		// Token: 0x04000077 RID: 119
		[FieldOffset(0)]
		public double dbl;

		// Token: 0x04000078 RID: 120
		[FieldOffset(0)]
		public ulong uu;
	}
}
