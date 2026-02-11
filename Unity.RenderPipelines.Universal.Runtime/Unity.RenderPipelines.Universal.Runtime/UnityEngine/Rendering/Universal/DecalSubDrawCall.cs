using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x0200006A RID: 106
	[StructLayout(2)]
	public struct DecalSubDrawCall
	{
		// Token: 0x06000941 RID: 2369 RVA: 0x0003534C File Offset: 0x0003354C
		// Note: this type is marked as 'beforefieldinit'.
		static DecalSubDrawCall()
		{
			Il2CppClassPointerStore<DecalSubDrawCall>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "DecalSubDrawCall");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecalSubDrawCall>.NativeClassPtr);
			DecalSubDrawCall.NativeFieldInfoPtr_start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalSubDrawCall>.NativeClassPtr, "start");
			DecalSubDrawCall.NativeFieldInfoPtr_end = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalSubDrawCall>.NativeClassPtr, "end");
			DecalSubDrawCall.NativeMethodInfoPtr_get_count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalSubDrawCall>.NativeClassPtr, 100664553);
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06000942 RID: 2370 RVA: 0x000353B8 File Offset: 0x000335B8
		public unsafe int count
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalSubDrawCall.NativeMethodInfoPtr_get_count_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000943 RID: 2371 RVA: 0x00006003 File Offset: 0x00004203
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DecalSubDrawCall>.NativeClassPtr, ref this));
		}

		// Token: 0x040006F6 RID: 1782
		private static readonly IntPtr NativeFieldInfoPtr_start;

		// Token: 0x040006F7 RID: 1783
		private static readonly IntPtr NativeFieldInfoPtr_end;

		// Token: 0x040006F8 RID: 1784
		private static readonly IntPtr NativeMethodInfoPtr_get_count_Public_get_Int32_0;

		// Token: 0x040006F9 RID: 1785
		[FieldOffset(0)]
		public int start;

		// Token: 0x040006FA RID: 1786
		[FieldOffset(4)]
		public int end;
	}
}
