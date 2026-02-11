using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Mathematics;

namespace UnityEngine.Rendering.Universal.UTess
{
	// Token: 0x0200013E RID: 318
	[StructLayout(2)]
	public struct DelaEdgeCompare
	{
		// Token: 0x06001AAD RID: 6829 RVA: 0x0000F239 File Offset: 0x0000D439
		// Note: this type is marked as 'beforefieldinit'.
		static DelaEdgeCompare()
		{
			Il2CppClassPointerStore<DelaEdgeCompare>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal.UTess", "DelaEdgeCompare");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DelaEdgeCompare>.NativeClassPtr);
			DelaEdgeCompare.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_int4_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelaEdgeCompare>.NativeClassPtr, 100666420);
		}

		// Token: 0x06001AAE RID: 6830 RVA: 0x0006F9B0 File Offset: 0x0006DBB0
		[CallerCount(0)]
		public unsafe int Compare(int4 a, int4 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelaEdgeCompare.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_int4_int4_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AAF RID: 6831 RVA: 0x0000F272 File Offset: 0x0000D472
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DelaEdgeCompare>.NativeClassPtr, ref this));
		}

		// Token: 0x0400134A RID: 4938
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_int4_int4_0;
	}
}
