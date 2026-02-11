using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x020000EC RID: 236
	public static class LightExtensions : Object
	{
		// Token: 0x06001200 RID: 4608 RVA: 0x0000AA59 File Offset: 0x00008C59
		// Note: this type is marked as 'beforefieldinit'.
		static LightExtensions()
		{
			Il2CppClassPointerStore<LightExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "LightExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightExtensions>.NativeClassPtr);
			LightExtensions.NativeMethodInfoPtr_GetUniversalAdditionalLightData_Public_Static_UniversalAdditionalLightData_Light_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightExtensions>.NativeClassPtr, 100665579);
		}

		// Token: 0x06001201 RID: 4609 RVA: 0x00053E20 File Offset: 0x00052020
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 619203, RefRangeEnd = 619209, XrefRangeStart = 619196, XrefRangeEnd = 619203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UniversalAdditionalLightData GetUniversalAdditionalLightData(this Light light)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(light);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightExtensions.NativeMethodInfoPtr_GetUniversalAdditionalLightData_Public_Static_UniversalAdditionalLightData_Light_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UniversalAdditionalLightData>(intPtr3) : null;
			}
		}

		// Token: 0x06001202 RID: 4610 RVA: 0x0000AA92 File Offset: 0x00008C92
		public LightExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D41 RID: 3393
		private static readonly IntPtr NativeMethodInfoPtr_GetUniversalAdditionalLightData_Public_Static_UniversalAdditionalLightData_Light_0;
	}
}
