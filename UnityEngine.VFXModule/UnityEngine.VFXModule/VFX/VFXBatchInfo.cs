using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.VFX
{
	// Token: 0x02000006 RID: 6
	[StructLayout(2)]
	public struct VFXBatchInfo
	{
		// Token: 0x06000089 RID: 137 RVA: 0x000040A0 File Offset: 0x000022A0
		// Note: this type is marked as 'beforefieldinit'.
		static VFXBatchInfo()
		{
			Il2CppClassPointerStore<VFXBatchInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.VFXModule.dll", "UnityEngine.VFX", "VFXBatchInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VFXBatchInfo>.NativeClassPtr);
			VFXBatchInfo.NativeFieldInfoPtr_capacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXBatchInfo>.NativeClassPtr, "capacity");
			VFXBatchInfo.NativeFieldInfoPtr_activeInstanceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXBatchInfo>.NativeClassPtr, "activeInstanceCount");
		}

		// Token: 0x0600008A RID: 138 RVA: 0x0000257C File Offset: 0x0000077C
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VFXBatchInfo>.NativeClassPtr, ref this));
		}

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeFieldInfoPtr_capacity;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeFieldInfoPtr_activeInstanceCount;

		// Token: 0x04000048 RID: 72
		[FieldOffset(0)]
		public uint capacity;

		// Token: 0x04000049 RID: 73
		[FieldOffset(4)]
		public uint activeInstanceCount;
	}
}
