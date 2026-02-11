using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Unity.Profiling
{
	// Token: 0x0200001E RID: 30
	public sealed class ProfilerRecorderDebugView : Object
	{
		// Token: 0x060000F5 RID: 245 RVA: 0x0000272F File Offset: 0x0000092F
		// Note: this type is marked as 'beforefieldinit'.
		static ProfilerRecorderDebugView()
		{
			Il2CppClassPointerStore<ProfilerRecorderDebugView>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Profiling", "ProfilerRecorderDebugView");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfilerRecorderDebugView>.NativeClassPtr);
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00002754 File Offset: 0x00000954
		public ProfilerRecorderDebugView(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x0000275D File Offset: 0x0000095D
		public Il2CppStructArray<ProfilerRecorderSample> Items
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}
	}
}
