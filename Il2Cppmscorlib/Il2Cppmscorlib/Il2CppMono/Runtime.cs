using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMono
{
	// Token: 0x02000009 RID: 9
	public static class Runtime : Object
	{
		// Token: 0x06000027 RID: 39 RVA: 0x0000214B File Offset: 0x0000034B
		// Note: this type is marked as 'beforefieldinit'.
		static Runtime()
		{
			Il2CppClassPointerStore<Runtime>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono", "Runtime");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Runtime>.NativeClassPtr);
			Runtime.NativeFieldInfoPtr_dump = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Runtime>.NativeClassPtr, "dump");
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002184 File Offset: 0x00000384
		public Runtime(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000029 RID: 41 RVA: 0x00025E2C File Offset: 0x0002402C
		// (set) Token: 0x0600002A RID: 42 RVA: 0x0000218D File Offset: 0x0000038D
		public unsafe static Object dump
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Runtime.NativeFieldInfoPtr_dump, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Runtime.NativeFieldInfoPtr_dump, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeFieldInfoPtr_dump;
	}
}
