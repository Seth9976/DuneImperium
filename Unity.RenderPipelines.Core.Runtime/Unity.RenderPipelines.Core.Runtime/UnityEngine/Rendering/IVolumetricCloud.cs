using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Rendering
{
	// Token: 0x020000AA RID: 170
	public class IVolumetricCloud : Il2CppObjectBase
	{
		// Token: 0x06000C6B RID: 3179 RVA: 0x000076E1 File Offset: 0x000058E1
		// Note: this type is marked as 'beforefieldinit'.
		static IVolumetricCloud()
		{
			Il2CppClassPointerStore<IVolumetricCloud>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "IVolumetricCloud");
			IVolumetricCloud.NativeMethodInfoPtr_IsVolumetricCloudUsable_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IVolumetricCloud>.NativeClassPtr, 100665117);
		}

		// Token: 0x06000C6C RID: 3180 RVA: 0x0003A014 File Offset: 0x00038214
		[CallerCount(0)]
		public unsafe virtual bool IsVolumetricCloudUsable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IVolumetricCloud.NativeMethodInfoPtr_IsVolumetricCloudUsable_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C6D RID: 3181 RVA: 0x00007710 File Offset: 0x00005910
		public IVolumetricCloud(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400094E RID: 2382
		private static readonly IntPtr NativeMethodInfoPtr_IsVolumetricCloudUsable_Public_Abstract_Virtual_New_Boolean_0;
	}
}
