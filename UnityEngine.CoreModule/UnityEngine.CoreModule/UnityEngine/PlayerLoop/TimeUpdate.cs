using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.PlayerLoop
{
	// Token: 0x020001C8 RID: 456
	[StructLayout(2)]
	public struct TimeUpdate
	{
		// Token: 0x060020F0 RID: 8432 RVA: 0x0000C80C File Offset: 0x0000AA0C
		// Note: this type is marked as 'beforefieldinit'.
		static TimeUpdate()
		{
			Il2CppClassPointerStore<TimeUpdate>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.PlayerLoop", "TimeUpdate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeUpdate>.NativeClassPtr);
		}

		// Token: 0x060020F1 RID: 8433 RVA: 0x0000C831 File Offset: 0x0000AA31
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TimeUpdate>.NativeClassPtr, ref this));
		}

		// Token: 0x02000893 RID: 2195
		[StructLayout(2)]
		public struct WaitForLastPresentationAndUpdateTime
		{
			// Token: 0x06003A29 RID: 14889 RVA: 0x00014950 File Offset: 0x00012B50
			// Note: this type is marked as 'beforefieldinit'.
			static WaitForLastPresentationAndUpdateTime()
			{
				Il2CppClassPointerStore<TimeUpdate.WaitForLastPresentationAndUpdateTime>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimeUpdate>.NativeClassPtr, "WaitForLastPresentationAndUpdateTime");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeUpdate.WaitForLastPresentationAndUpdateTime>.NativeClassPtr);
			}

			// Token: 0x06003A2A RID: 14890 RVA: 0x00014970 File Offset: 0x00012B70
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TimeUpdate.WaitForLastPresentationAndUpdateTime>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000894 RID: 2196
		public struct ProfilerStartFrame
		{
		}
	}
}
