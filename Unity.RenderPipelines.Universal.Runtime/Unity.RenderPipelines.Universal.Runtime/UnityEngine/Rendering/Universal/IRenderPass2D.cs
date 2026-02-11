using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x0200002C RID: 44
	public class IRenderPass2D : Il2CppObjectBase
	{
		// Token: 0x0600034D RID: 845 RVA: 0x00003668 File Offset: 0x00001868
		// Note: this type is marked as 'beforefieldinit'.
		static IRenderPass2D()
		{
			Il2CppClassPointerStore<IRenderPass2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "IRenderPass2D");
			IRenderPass2D.NativeMethodInfoPtr_get_rendererData_Public_Abstract_Virtual_New_get_Renderer2DData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRenderPass2D>.NativeClassPtr, 100663727);
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x0600034E RID: 846 RVA: 0x0002187C File Offset: 0x0001FA7C
		public unsafe virtual Renderer2DData rendererData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRenderPass2D.NativeMethodInfoPtr_get_rendererData_Public_Abstract_Virtual_New_get_Renderer2DData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Renderer2DData>(intPtr3) : null;
			}
		}

		// Token: 0x0600034F RID: 847 RVA: 0x00003697 File Offset: 0x00001897
		public IRenderPass2D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400028F RID: 655
		private static readonly IntPtr NativeMethodInfoPtr_get_rendererData_Public_Abstract_Virtual_New_get_Renderer2DData_0;
	}
}
