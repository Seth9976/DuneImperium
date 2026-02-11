using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000196 RID: 406
	[StructLayout(2)]
	public struct NativeOverlapped
	{
		// Token: 0x06001A7D RID: 6781 RVA: 0x000A1F9C File Offset: 0x000A019C
		// Note: this type is marked as 'beforefieldinit'.
		static NativeOverlapped()
		{
			Il2CppClassPointerStore<NativeOverlapped>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "NativeOverlapped");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeOverlapped>.NativeClassPtr);
			NativeOverlapped.NativeFieldInfoPtr_InternalLow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeOverlapped>.NativeClassPtr, "InternalLow");
			NativeOverlapped.NativeFieldInfoPtr_InternalHigh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeOverlapped>.NativeClassPtr, "InternalHigh");
			NativeOverlapped.NativeFieldInfoPtr_OffsetLow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeOverlapped>.NativeClassPtr, "OffsetLow");
			NativeOverlapped.NativeFieldInfoPtr_OffsetHigh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeOverlapped>.NativeClassPtr, "OffsetHigh");
			NativeOverlapped.NativeFieldInfoPtr_EventHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeOverlapped>.NativeClassPtr, "EventHandle");
		}

		// Token: 0x06001A7E RID: 6782 RVA: 0x00008700 File Offset: 0x00006900
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeOverlapped>.NativeClassPtr, ref this));
		}

		// Token: 0x04001870 RID: 6256
		private static readonly IntPtr NativeFieldInfoPtr_InternalLow;

		// Token: 0x04001871 RID: 6257
		private static readonly IntPtr NativeFieldInfoPtr_InternalHigh;

		// Token: 0x04001872 RID: 6258
		private static readonly IntPtr NativeFieldInfoPtr_OffsetLow;

		// Token: 0x04001873 RID: 6259
		private static readonly IntPtr NativeFieldInfoPtr_OffsetHigh;

		// Token: 0x04001874 RID: 6260
		private static readonly IntPtr NativeFieldInfoPtr_EventHandle;

		// Token: 0x04001875 RID: 6261
		[FieldOffset(0)]
		public IntPtr InternalLow;

		// Token: 0x04001876 RID: 6262
		[FieldOffset(8)]
		public IntPtr InternalHigh;

		// Token: 0x04001877 RID: 6263
		[FieldOffset(16)]
		public int OffsetLow;

		// Token: 0x04001878 RID: 6264
		[FieldOffset(20)]
		public int OffsetHigh;

		// Token: 0x04001879 RID: 6265
		[FieldOffset(24)]
		public IntPtr EventHandle;
	}
}
