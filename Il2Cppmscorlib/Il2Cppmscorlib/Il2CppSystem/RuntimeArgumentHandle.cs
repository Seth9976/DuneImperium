using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000161 RID: 353
	[StructLayout(2)]
	public struct RuntimeArgumentHandle
	{
		// Token: 0x060017D7 RID: 6103 RVA: 0x0000786A File Offset: 0x00005A6A
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeArgumentHandle()
		{
			Il2CppClassPointerStore<RuntimeArgumentHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "RuntimeArgumentHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeArgumentHandle>.NativeClassPtr);
			RuntimeArgumentHandle.NativeFieldInfoPtr_args = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeArgumentHandle>.NativeClassPtr, "args");
		}

		// Token: 0x060017D8 RID: 6104 RVA: 0x000078A3 File Offset: 0x00005AA3
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RuntimeArgumentHandle>.NativeClassPtr, ref this));
		}

		// Token: 0x0400146D RID: 5229
		private static readonly IntPtr NativeFieldInfoPtr_args;

		// Token: 0x0400146E RID: 5230
		[FieldOffset(0)]
		public IntPtr args;
	}
}
