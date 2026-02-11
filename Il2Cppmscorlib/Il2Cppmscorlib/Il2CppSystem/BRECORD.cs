using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000176 RID: 374
	[StructLayout(2)]
	public struct BRECORD
	{
		// Token: 0x0600191F RID: 6431 RVA: 0x0009C278 File Offset: 0x0009A478
		// Note: this type is marked as 'beforefieldinit'.
		static BRECORD()
		{
			Il2CppClassPointerStore<BRECORD>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "BRECORD");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BRECORD>.NativeClassPtr);
			BRECORD.NativeFieldInfoPtr_pvRecord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BRECORD>.NativeClassPtr, "pvRecord");
			BRECORD.NativeFieldInfoPtr_pRecInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BRECORD>.NativeClassPtr, "pRecInfo");
		}

		// Token: 0x06001920 RID: 6432 RVA: 0x0000814B File Offset: 0x0000634B
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BRECORD>.NativeClassPtr, ref this));
		}

		// Token: 0x0400172F RID: 5935
		private static readonly IntPtr NativeFieldInfoPtr_pvRecord;

		// Token: 0x04001730 RID: 5936
		private static readonly IntPtr NativeFieldInfoPtr_pRecInfo;

		// Token: 0x04001731 RID: 5937
		[FieldOffset(0)]
		public IntPtr pvRecord;

		// Token: 0x04001732 RID: 5938
		[FieldOffset(8)]
		public IntPtr pRecInfo;
	}
}
