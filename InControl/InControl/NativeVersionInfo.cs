using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace InControl
{
	// Token: 0x0200004C RID: 76
	[StructLayout(2)]
	public struct NativeVersionInfo
	{
		// Token: 0x06000728 RID: 1832 RVA: 0x0002154C File Offset: 0x0001F74C
		// Note: this type is marked as 'beforefieldinit'.
		static NativeVersionInfo()
		{
			Il2CppClassPointerStore<NativeVersionInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "NativeVersionInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeVersionInfo>.NativeClassPtr);
			NativeVersionInfo.NativeFieldInfoPtr_major = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeVersionInfo>.NativeClassPtr, "major");
			NativeVersionInfo.NativeFieldInfoPtr_minor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeVersionInfo>.NativeClassPtr, "minor");
			NativeVersionInfo.NativeFieldInfoPtr_patch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeVersionInfo>.NativeClassPtr, "patch");
			NativeVersionInfo.NativeFieldInfoPtr_build = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeVersionInfo>.NativeClassPtr, "build");
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x00004B5B File Offset: 0x00002D5B
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeVersionInfo>.NativeClassPtr, ref this));
		}

		// Token: 0x04000711 RID: 1809
		private static readonly IntPtr NativeFieldInfoPtr_major;

		// Token: 0x04000712 RID: 1810
		private static readonly IntPtr NativeFieldInfoPtr_minor;

		// Token: 0x04000713 RID: 1811
		private static readonly IntPtr NativeFieldInfoPtr_patch;

		// Token: 0x04000714 RID: 1812
		private static readonly IntPtr NativeFieldInfoPtr_build;

		// Token: 0x04000715 RID: 1813
		[FieldOffset(0)]
		public uint major;

		// Token: 0x04000716 RID: 1814
		[FieldOffset(4)]
		public uint minor;

		// Token: 0x04000717 RID: 1815
		[FieldOffset(8)]
		public uint patch;

		// Token: 0x04000718 RID: 1816
		[FieldOffset(12)]
		public uint build;
	}
}
