using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x0200017B RID: 379
	[StructLayout(2)]
	public struct SmallRect
	{
		// Token: 0x06001943 RID: 6467 RVA: 0x0009CD64 File Offset: 0x0009AF64
		// Note: this type is marked as 'beforefieldinit'.
		static SmallRect()
		{
			Il2CppClassPointerStore<SmallRect>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "SmallRect");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SmallRect>.NativeClassPtr);
			SmallRect.NativeFieldInfoPtr_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmallRect>.NativeClassPtr, "Left");
			SmallRect.NativeFieldInfoPtr_Top = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmallRect>.NativeClassPtr, "Top");
			SmallRect.NativeFieldInfoPtr_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmallRect>.NativeClassPtr, "Right");
			SmallRect.NativeFieldInfoPtr_Bottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmallRect>.NativeClassPtr, "Bottom");
		}

		// Token: 0x06001944 RID: 6468 RVA: 0x000081FF File Offset: 0x000063FF
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SmallRect>.NativeClassPtr, ref this));
		}

		// Token: 0x0400175F RID: 5983
		private static readonly IntPtr NativeFieldInfoPtr_Left;

		// Token: 0x04001760 RID: 5984
		private static readonly IntPtr NativeFieldInfoPtr_Top;

		// Token: 0x04001761 RID: 5985
		private static readonly IntPtr NativeFieldInfoPtr_Right;

		// Token: 0x04001762 RID: 5986
		private static readonly IntPtr NativeFieldInfoPtr_Bottom;

		// Token: 0x04001763 RID: 5987
		[FieldOffset(0)]
		public short Left;

		// Token: 0x04001764 RID: 5988
		[FieldOffset(2)]
		public short Top;

		// Token: 0x04001765 RID: 5989
		[FieldOffset(4)]
		public short Right;

		// Token: 0x04001766 RID: 5990
		[FieldOffset(6)]
		public short Bottom;
	}
}
