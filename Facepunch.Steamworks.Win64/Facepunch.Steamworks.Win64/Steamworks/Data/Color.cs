using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020001FE RID: 510
	[StructLayout(2)]
	public struct Color
	{
		// Token: 0x0600197A RID: 6522 RVA: 0x0007B52C File Offset: 0x0007972C
		// Note: this type is marked as 'beforefieldinit'.
		static Color()
		{
			Il2CppClassPointerStore<Color>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "Color");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Color>.NativeClassPtr);
			Color.NativeFieldInfoPtr_r = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Color>.NativeClassPtr, "r");
			Color.NativeFieldInfoPtr_g = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Color>.NativeClassPtr, "g");
			Color.NativeFieldInfoPtr_b = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Color>.NativeClassPtr, "b");
			Color.NativeFieldInfoPtr_a = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Color>.NativeClassPtr, "a");
		}

		// Token: 0x0600197B RID: 6523 RVA: 0x00008499 File Offset: 0x00006699
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Color>.NativeClassPtr, ref this));
		}

		// Token: 0x04001EAC RID: 7852
		private static readonly IntPtr NativeFieldInfoPtr_r;

		// Token: 0x04001EAD RID: 7853
		private static readonly IntPtr NativeFieldInfoPtr_g;

		// Token: 0x04001EAE RID: 7854
		private static readonly IntPtr NativeFieldInfoPtr_b;

		// Token: 0x04001EAF RID: 7855
		private static readonly IntPtr NativeFieldInfoPtr_a;

		// Token: 0x04001EB0 RID: 7856
		[FieldOffset(0)]
		public byte r;

		// Token: 0x04001EB1 RID: 7857
		[FieldOffset(1)]
		public byte g;

		// Token: 0x04001EB2 RID: 7858
		[FieldOffset(2)]
		public byte b;

		// Token: 0x04001EB3 RID: 7859
		[FieldOffset(3)]
		public byte a;
	}
}
