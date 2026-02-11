using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Properties
{
	// Token: 0x02000003 RID: 3
	public class DontCreatePropertyAttribute : Attribute
	{
		// Token: 0x06000003 RID: 3 RVA: 0x0000207E File Offset: 0x0000027E
		// Note: this type is marked as 'beforefieldinit'.
		static DontCreatePropertyAttribute()
		{
			Il2CppClassPointerStore<DontCreatePropertyAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.PropertiesModule.dll", "Unity.Properties", "DontCreatePropertyAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DontCreatePropertyAttribute>.NativeClassPtr);
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000020A3 File Offset: 0x000002A3
		public DontCreatePropertyAttribute(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
