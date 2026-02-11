using System;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000192 RID: 402
	public static class Timeout : Object
	{
		// Token: 0x06001A28 RID: 6696 RVA: 0x0000855B File Offset: 0x0000675B
		// Note: this type is marked as 'beforefieldinit'.
		static Timeout()
		{
			Il2CppClassPointerStore<Timeout>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "Timeout");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Timeout>.NativeClassPtr);
			Timeout.NativeFieldInfoPtr_InfiniteTimeSpan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Timeout>.NativeClassPtr, "InfiniteTimeSpan");
		}

		// Token: 0x06001A29 RID: 6697 RVA: 0x00008594 File Offset: 0x00006794
		public Timeout(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06001A2A RID: 6698 RVA: 0x000A0C60 File Offset: 0x0009EE60
		// (set) Token: 0x06001A2B RID: 6699 RVA: 0x0000859D File Offset: 0x0000679D
		public unsafe static TimeSpan InfiniteTimeSpan
		{
			get
			{
				TimeSpan timeSpan;
				IL2CPP.il2cpp_field_static_get_value(Timeout.NativeFieldInfoPtr_InfiniteTimeSpan, (void*)(&timeSpan));
				return timeSpan;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Timeout.NativeFieldInfoPtr_InfiniteTimeSpan, (void*)(&value));
			}
		}

		// Token: 0x04001835 RID: 6197
		private static readonly IntPtr NativeFieldInfoPtr_InfiniteTimeSpan;
	}
}
