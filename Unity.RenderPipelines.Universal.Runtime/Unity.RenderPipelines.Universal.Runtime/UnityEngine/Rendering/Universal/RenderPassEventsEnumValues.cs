using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x020000B6 RID: 182
	public static class RenderPassEventsEnumValues : Object
	{
		// Token: 0x06000E96 RID: 3734 RVA: 0x00008FF7 File Offset: 0x000071F7
		// Note: this type is marked as 'beforefieldinit'.
		static RenderPassEventsEnumValues()
		{
			Il2CppClassPointerStore<RenderPassEventsEnumValues>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "RenderPassEventsEnumValues");
			RenderPassEventsEnumValues.NativeFieldInfoPtr_values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPassEventsEnumValues>.NativeClassPtr, "values");
		}

		// Token: 0x06000E97 RID: 3735 RVA: 0x00009026 File Offset: 0x00007226
		public RenderPassEventsEnumValues(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x06000E98 RID: 3736 RVA: 0x00047DC8 File Offset: 0x00045FC8
		// (set) Token: 0x06000E99 RID: 3737 RVA: 0x0000902F File Offset: 0x0000722F
		public unsafe static Il2CppStructArray<int> values
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RenderPassEventsEnumValues.NativeFieldInfoPtr_values, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderPassEventsEnumValues.NativeFieldInfoPtr_values, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AAA RID: 2730
		private static readonly IntPtr NativeFieldInfoPtr_values;
	}
}
