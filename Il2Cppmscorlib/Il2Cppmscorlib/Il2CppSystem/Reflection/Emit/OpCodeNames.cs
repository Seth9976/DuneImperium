using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Reflection.Emit
{
	// Token: 0x0200045D RID: 1117
	public static class OpCodeNames : Object
	{
		// Token: 0x06004138 RID: 16696 RVA: 0x000178F6 File Offset: 0x00015AF6
		// Note: this type is marked as 'beforefieldinit'.
		static OpCodeNames()
		{
			Il2CppClassPointerStore<OpCodeNames>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection.Emit", "OpCodeNames");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OpCodeNames>.NativeClassPtr);
			OpCodeNames.NativeFieldInfoPtr_names = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpCodeNames>.NativeClassPtr, "names");
		}

		// Token: 0x06004139 RID: 16697 RVA: 0x0001792F File Offset: 0x00015B2F
		public OpCodeNames(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F8A RID: 3978
		// (get) Token: 0x0600413A RID: 16698 RVA: 0x00138C1C File Offset: 0x00136E1C
		// (set) Token: 0x0600413B RID: 16699 RVA: 0x00017938 File Offset: 0x00015B38
		public unsafe static Il2CppStringArray names
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(OpCodeNames.NativeFieldInfoPtr_names, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OpCodeNames.NativeFieldInfoPtr_names, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040035C0 RID: 13760
		private static readonly IntPtr NativeFieldInfoPtr_names;
	}
}
