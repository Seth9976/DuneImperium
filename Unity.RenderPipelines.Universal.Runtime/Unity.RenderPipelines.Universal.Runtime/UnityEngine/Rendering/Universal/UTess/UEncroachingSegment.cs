using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Mathematics;

namespace UnityEngine.Rendering.Universal.UTess
{
	// Token: 0x02000136 RID: 310
	[StructLayout(2)]
	public struct UEncroachingSegment
	{
		// Token: 0x06001A8D RID: 6797 RVA: 0x0006F4BC File Offset: 0x0006D6BC
		// Note: this type is marked as 'beforefieldinit'.
		static UEncroachingSegment()
		{
			Il2CppClassPointerStore<UEncroachingSegment>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal.UTess", "UEncroachingSegment");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UEncroachingSegment>.NativeClassPtr);
			UEncroachingSegment.NativeFieldInfoPtr_a = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UEncroachingSegment>.NativeClassPtr, "a");
			UEncroachingSegment.NativeFieldInfoPtr_b = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UEncroachingSegment>.NativeClassPtr, "b");
			UEncroachingSegment.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UEncroachingSegment>.NativeClassPtr, "index");
		}

		// Token: 0x06001A8E RID: 6798 RVA: 0x0000EFFA File Offset: 0x0000D1FA
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UEncroachingSegment>.NativeClassPtr, ref this));
		}

		// Token: 0x04001339 RID: 4921
		private static readonly IntPtr NativeFieldInfoPtr_a;

		// Token: 0x0400133A RID: 4922
		private static readonly IntPtr NativeFieldInfoPtr_b;

		// Token: 0x0400133B RID: 4923
		private static readonly IntPtr NativeFieldInfoPtr_index;

		// Token: 0x0400133C RID: 4924
		[FieldOffset(0)]
		public float2 a;

		// Token: 0x0400133D RID: 4925
		[FieldOffset(8)]
		public float2 b;

		// Token: 0x0400133E RID: 4926
		[FieldOffset(16)]
		public int index;
	}
}
