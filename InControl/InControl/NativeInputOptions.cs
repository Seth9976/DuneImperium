using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace InControl
{
	// Token: 0x0200004B RID: 75
	[StructLayout(2)]
	public struct NativeInputOptions
	{
		// Token: 0x06000726 RID: 1830 RVA: 0x000214CC File Offset: 0x0001F6CC
		// Note: this type is marked as 'beforefieldinit'.
		static NativeInputOptions()
		{
			Il2CppClassPointerStore<NativeInputOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "NativeInputOptions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeInputOptions>.NativeClassPtr);
			NativeInputOptions.NativeFieldInfoPtr_updateRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeInputOptions>.NativeClassPtr, "updateRate");
			NativeInputOptions.NativeFieldInfoPtr_enableXInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeInputOptions>.NativeClassPtr, "enableXInput");
			NativeInputOptions.NativeFieldInfoPtr_enableMFi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeInputOptions>.NativeClassPtr, "enableMFi");
			NativeInputOptions.NativeFieldInfoPtr_preventSleep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeInputOptions>.NativeClassPtr, "preventSleep");
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x00004B49 File Offset: 0x00002D49
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeInputOptions>.NativeClassPtr, ref this));
		}

		// Token: 0x04000709 RID: 1801
		private static readonly IntPtr NativeFieldInfoPtr_updateRate;

		// Token: 0x0400070A RID: 1802
		private static readonly IntPtr NativeFieldInfoPtr_enableXInput;

		// Token: 0x0400070B RID: 1803
		private static readonly IntPtr NativeFieldInfoPtr_enableMFi;

		// Token: 0x0400070C RID: 1804
		private static readonly IntPtr NativeFieldInfoPtr_preventSleep;

		// Token: 0x0400070D RID: 1805
		[FieldOffset(0)]
		public ushort updateRate;

		// Token: 0x0400070E RID: 1806
		[FieldOffset(4)]
		public int enableXInput;

		// Token: 0x0400070F RID: 1807
		[FieldOffset(8)]
		public int enableMFi;

		// Token: 0x04000710 RID: 1808
		[FieldOffset(12)]
		public int preventSleep;
	}
}
