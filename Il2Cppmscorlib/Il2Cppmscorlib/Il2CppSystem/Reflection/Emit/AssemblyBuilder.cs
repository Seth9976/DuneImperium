using System;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Reflection.Emit
{
	// Token: 0x02000450 RID: 1104
	public class AssemblyBuilder : Assembly
	{
		// Token: 0x06004080 RID: 16512 RVA: 0x0001778C File Offset: 0x0001598C
		// Note: this type is marked as 'beforefieldinit'.
		static AssemblyBuilder()
		{
			Il2CppClassPointerStore<AssemblyBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection.Emit", "AssemblyBuilder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssemblyBuilder>.NativeClassPtr);
		}

		// Token: 0x06004081 RID: 16513 RVA: 0x000177B1 File Offset: 0x000159B1
		public AssemblyBuilder(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
