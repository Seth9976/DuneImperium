using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x0200007D RID: 125
	public static class ShaderDebugPrintInputProducer : Object
	{
		// Token: 0x0600084C RID: 2124 RVA: 0x0000547E File Offset: 0x0000367E
		// Note: this type is marked as 'beforefieldinit'.
		static ShaderDebugPrintInputProducer()
		{
			Il2CppClassPointerStore<ShaderDebugPrintInputProducer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "ShaderDebugPrintInputProducer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderDebugPrintInputProducer>.NativeClassPtr);
			ShaderDebugPrintInputProducer.NativeMethodInfoPtr_Get_Public_Static_ShaderDebugPrintInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderDebugPrintInputProducer>.NativeClassPtr, 100664604);
		}

		// Token: 0x0600084D RID: 2125 RVA: 0x0002C950 File Offset: 0x0002AB50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965491, XrefRangeEnd = 965495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ShaderDebugPrintInput Get()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderDebugPrintInputProducer.NativeMethodInfoPtr_Get_Public_Static_ShaderDebugPrintInput_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x000054B7 File Offset: 0x000036B7
		public ShaderDebugPrintInputProducer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400062A RID: 1578
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_ShaderDebugPrintInput_0;
	}
}
