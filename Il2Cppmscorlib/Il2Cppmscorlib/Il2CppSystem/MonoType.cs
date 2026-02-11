using System;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x0200015C RID: 348
	public sealed class MonoType : RuntimeType
	{
		// Token: 0x060017A6 RID: 6054 RVA: 0x000077EC File Offset: 0x000059EC
		// Note: this type is marked as 'beforefieldinit'.
		static MonoType()
		{
			Il2CppClassPointerStore<MonoType>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "MonoType");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoType>.NativeClassPtr);
		}

		// Token: 0x060017A7 RID: 6055 RVA: 0x00007811 File Offset: 0x00005A11
		public MonoType(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
