using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Rendering
{
	// Token: 0x02000049 RID: 73
	public class IVirtualTexturingEnabledRenderPipeline : Il2CppObjectBase
	{
		// Token: 0x0600058E RID: 1422 RVA: 0x0000440B File Offset: 0x0000260B
		// Note: this type is marked as 'beforefieldinit'.
		static IVirtualTexturingEnabledRenderPipeline()
		{
			Il2CppClassPointerStore<IVirtualTexturingEnabledRenderPipeline>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "IVirtualTexturingEnabledRenderPipeline");
			IVirtualTexturingEnabledRenderPipeline.NativeMethodInfoPtr_get_virtualTexturingEnabled_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IVirtualTexturingEnabledRenderPipeline>.NativeClassPtr, 100664004);
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x0600058F RID: 1423 RVA: 0x0002226C File Offset: 0x0002046C
		public unsafe virtual bool virtualTexturingEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IVirtualTexturingEnabledRenderPipeline.NativeMethodInfoPtr_get_virtualTexturingEnabled_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x0000443A File Offset: 0x0000263A
		public IVirtualTexturingEnabledRenderPipeline(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000423 RID: 1059
		private static readonly IntPtr NativeMethodInfoPtr_get_virtualTexturingEnabled_Public_Abstract_Virtual_New_get_Boolean_0;
	}
}
