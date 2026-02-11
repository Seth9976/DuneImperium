using System;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Versioning
{
	// Token: 0x02000313 RID: 787
	public static class BinaryCompatibility : Object
	{
		// Token: 0x06003074 RID: 12404 RVA: 0x000F7694 File Offset: 0x000F5894
		// Note: this type is marked as 'beforefieldinit'.
		static BinaryCompatibility()
		{
			Il2CppClassPointerStore<BinaryCompatibility>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Versioning", "BinaryCompatibility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinaryCompatibility>.NativeClassPtr);
			BinaryCompatibility.NativeFieldInfoPtr_TargetsAtLeast_Desktop_V4_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryCompatibility>.NativeClassPtr, "TargetsAtLeast_Desktop_V4_5");
			BinaryCompatibility.NativeFieldInfoPtr_TargetsAtLeast_Desktop_V4_5_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryCompatibility>.NativeClassPtr, "TargetsAtLeast_Desktop_V4_5_1");
		}

		// Token: 0x06003075 RID: 12405 RVA: 0x000109FC File Offset: 0x0000EBFC
		public BinaryCompatibility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000ADC RID: 2780
		// (get) Token: 0x06003076 RID: 12406 RVA: 0x000F76EC File Offset: 0x000F58EC
		// (set) Token: 0x06003077 RID: 12407 RVA: 0x00010A05 File Offset: 0x0000EC05
		public unsafe static bool TargetsAtLeast_Desktop_V4_5
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(BinaryCompatibility.NativeFieldInfoPtr_TargetsAtLeast_Desktop_V4_5, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BinaryCompatibility.NativeFieldInfoPtr_TargetsAtLeast_Desktop_V4_5, (void*)(&value));
			}
		}

		// Token: 0x17000ADD RID: 2781
		// (get) Token: 0x06003078 RID: 12408 RVA: 0x000F7708 File Offset: 0x000F5908
		// (set) Token: 0x06003079 RID: 12409 RVA: 0x00010A13 File Offset: 0x0000EC13
		public unsafe static bool TargetsAtLeast_Desktop_V4_5_1
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(BinaryCompatibility.NativeFieldInfoPtr_TargetsAtLeast_Desktop_V4_5_1, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BinaryCompatibility.NativeFieldInfoPtr_TargetsAtLeast_Desktop_V4_5_1, (void*)(&value));
			}
		}

		// Token: 0x0400280F RID: 10255
		private static readonly IntPtr NativeFieldInfoPtr_TargetsAtLeast_Desktop_V4_5;

		// Token: 0x04002810 RID: 10256
		private static readonly IntPtr NativeFieldInfoPtr_TargetsAtLeast_Desktop_V4_5_1;
	}
}
