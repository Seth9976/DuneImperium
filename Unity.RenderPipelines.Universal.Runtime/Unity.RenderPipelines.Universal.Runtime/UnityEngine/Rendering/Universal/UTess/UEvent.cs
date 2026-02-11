using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Mathematics;

namespace UnityEngine.Rendering.Universal.UTess
{
	// Token: 0x02000130 RID: 304
	[StructLayout(2)]
	public struct UEvent
	{
		// Token: 0x06001A6D RID: 6765 RVA: 0x0006F050 File Offset: 0x0006D250
		// Note: this type is marked as 'beforefieldinit'.
		static UEvent()
		{
			Il2CppClassPointerStore<UEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal.UTess", "UEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UEvent>.NativeClassPtr);
			UEvent.NativeFieldInfoPtr_a = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UEvent>.NativeClassPtr, "a");
			UEvent.NativeFieldInfoPtr_b = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UEvent>.NativeClassPtr, "b");
			UEvent.NativeFieldInfoPtr_idx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UEvent>.NativeClassPtr, "idx");
			UEvent.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UEvent>.NativeClassPtr, "type");
		}

		// Token: 0x06001A6E RID: 6766 RVA: 0x0000EE50 File Offset: 0x0000D050
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UEvent>.NativeClassPtr, ref this));
		}

		// Token: 0x04001314 RID: 4884
		private static readonly IntPtr NativeFieldInfoPtr_a;

		// Token: 0x04001315 RID: 4885
		private static readonly IntPtr NativeFieldInfoPtr_b;

		// Token: 0x04001316 RID: 4886
		private static readonly IntPtr NativeFieldInfoPtr_idx;

		// Token: 0x04001317 RID: 4887
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x04001318 RID: 4888
		[FieldOffset(0)]
		public float2 a;

		// Token: 0x04001319 RID: 4889
		[FieldOffset(8)]
		public float2 b;

		// Token: 0x0400131A RID: 4890
		[FieldOffset(16)]
		public int idx;

		// Token: 0x0400131B RID: 4891
		[FieldOffset(20)]
		public int type;
	}
}
