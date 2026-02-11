using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Canis.mathLib
{
	// Token: 0x02000079 RID: 121
	public static class DwdMathUtils : Object
	{
		// Token: 0x06000690 RID: 1680 RVA: 0x00033BFC File Offset: 0x00031DFC
		// Note: this type is marked as 'beforefieldinit'.
		static DwdMathUtils()
		{
			Il2CppClassPointerStore<DwdMathUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.mathLib", "DwdMathUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DwdMathUtils>.NativeClassPtr);
			DwdMathUtils.NativeFieldInfoPtr_Epsilon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DwdMathUtils>.NativeClassPtr, "Epsilon");
			DwdMathUtils.NativeFieldInfoPtr_HalfPI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DwdMathUtils>.NativeClassPtr, "HalfPI");
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x000049B3 File Offset: 0x00002BB3
		public DwdMathUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x06000692 RID: 1682 RVA: 0x00033C54 File Offset: 0x00031E54
		// (set) Token: 0x06000693 RID: 1683 RVA: 0x000049BC File Offset: 0x00002BBC
		public unsafe static double Epsilon
		{
			get
			{
				double num;
				IL2CPP.il2cpp_field_static_get_value(DwdMathUtils.NativeFieldInfoPtr_Epsilon, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DwdMathUtils.NativeFieldInfoPtr_Epsilon, (void*)(&value));
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x06000694 RID: 1684 RVA: 0x00033C70 File Offset: 0x00031E70
		// (set) Token: 0x06000695 RID: 1685 RVA: 0x000049CA File Offset: 0x00002BCA
		public unsafe static double HalfPI
		{
			get
			{
				double num;
				IL2CPP.il2cpp_field_static_get_value(DwdMathUtils.NativeFieldInfoPtr_HalfPI, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DwdMathUtils.NativeFieldInfoPtr_HalfPI, (void*)(&value));
			}
		}

		// Token: 0x04000471 RID: 1137
		private static readonly IntPtr NativeFieldInfoPtr_Epsilon;

		// Token: 0x04000472 RID: 1138
		private static readonly IntPtr NativeFieldInfoPtr_HalfPI;
	}
}
