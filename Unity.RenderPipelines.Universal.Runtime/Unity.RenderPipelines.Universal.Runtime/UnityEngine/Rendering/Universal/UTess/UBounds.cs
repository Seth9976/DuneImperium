using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Mathematics;

namespace UnityEngine.Rendering.Universal.UTess
{
	// Token: 0x02000133 RID: 307
	[StructLayout(2)]
	public struct UBounds
	{
		// Token: 0x06001A87 RID: 6791 RVA: 0x0006F364 File Offset: 0x0006D564
		// Note: this type is marked as 'beforefieldinit'.
		static UBounds()
		{
			Il2CppClassPointerStore<UBounds>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal.UTess", "UBounds");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UBounds>.NativeClassPtr);
			UBounds.NativeFieldInfoPtr_min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UBounds>.NativeClassPtr, "min");
			UBounds.NativeFieldInfoPtr_max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UBounds>.NativeClassPtr, "max");
		}

		// Token: 0x06001A88 RID: 6792 RVA: 0x0000EFC4 File Offset: 0x0000D1C4
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UBounds>.NativeClassPtr, ref this));
		}

		// Token: 0x04001325 RID: 4901
		private static readonly IntPtr NativeFieldInfoPtr_min;

		// Token: 0x04001326 RID: 4902
		private static readonly IntPtr NativeFieldInfoPtr_max;

		// Token: 0x04001327 RID: 4903
		[FieldOffset(0)]
		public double2 min;

		// Token: 0x04001328 RID: 4904
		[FieldOffset(16)]
		public double2 max;
	}
}
