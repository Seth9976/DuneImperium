using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppMono
{
	// Token: 0x02000013 RID: 19
	[StructLayout(2)]
	public struct ValueTuple
	{
		// Token: 0x06000059 RID: 89 RVA: 0x00002254 File Offset: 0x00000454
		// Note: this type is marked as 'beforefieldinit'.
		static ValueTuple()
		{
			Il2CppClassPointerStore<ValueTuple>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono", "ValueTuple");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValueTuple>.NativeClassPtr);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00002279 File Offset: 0x00000479
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple>.NativeClassPtr, ref this));
		}
	}
}
