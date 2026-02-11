using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x0200017A RID: 378
	[StructLayout(2)]
	public struct Coord
	{
		// Token: 0x06001941 RID: 6465 RVA: 0x0009CD0C File Offset: 0x0009AF0C
		// Note: this type is marked as 'beforefieldinit'.
		static Coord()
		{
			Il2CppClassPointerStore<Coord>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Coord");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Coord>.NativeClassPtr);
			Coord.NativeFieldInfoPtr_X = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Coord>.NativeClassPtr, "X");
			Coord.NativeFieldInfoPtr_Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Coord>.NativeClassPtr, "Y");
		}

		// Token: 0x06001942 RID: 6466 RVA: 0x000081ED File Offset: 0x000063ED
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Coord>.NativeClassPtr, ref this));
		}

		// Token: 0x0400175B RID: 5979
		private static readonly IntPtr NativeFieldInfoPtr_X;

		// Token: 0x0400175C RID: 5980
		private static readonly IntPtr NativeFieldInfoPtr_Y;

		// Token: 0x0400175D RID: 5981
		[FieldOffset(0)]
		public short X;

		// Token: 0x0400175E RID: 5982
		[FieldOffset(2)]
		public short Y;
	}
}
