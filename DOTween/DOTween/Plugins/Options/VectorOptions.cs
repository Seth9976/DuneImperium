using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace DG.Tweening.Plugins.Options
{
	// Token: 0x02000039 RID: 57
	[StructLayout(2)]
	public struct VectorOptions
	{
		// Token: 0x06000383 RID: 899 RVA: 0x00016FD0 File Offset: 0x000151D0
		// Note: this type is marked as 'beforefieldinit'.
		static VectorOptions()
		{
			Il2CppClassPointerStore<VectorOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening.Plugins.Options", "VectorOptions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VectorOptions>.NativeClassPtr);
			VectorOptions.NativeFieldInfoPtr_axisConstraint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VectorOptions>.NativeClassPtr, "axisConstraint");
			VectorOptions.NativeFieldInfoPtr_snapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VectorOptions>.NativeClassPtr, "snapping");
			VectorOptions.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VectorOptions>.NativeClassPtr, 100664093);
		}

		// Token: 0x06000384 RID: 900 RVA: 0x0001703C File Offset: 0x0001523C
		[CallerCount(0)]
		public unsafe void Reset()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VectorOptions.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000385 RID: 901 RVA: 0x000030A3 File Offset: 0x000012A3
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VectorOptions>.NativeClassPtr, ref this));
		}

		// Token: 0x04000305 RID: 773
		private static readonly IntPtr NativeFieldInfoPtr_axisConstraint;

		// Token: 0x04000306 RID: 774
		private static readonly IntPtr NativeFieldInfoPtr_snapping;

		// Token: 0x04000307 RID: 775
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000308 RID: 776
		[FieldOffset(0)]
		public AxisConstraint axisConstraint;

		// Token: 0x04000309 RID: 777
		[FieldOffset(4)]
		[MarshalAs(4)]
		public bool snapping;
	}
}
