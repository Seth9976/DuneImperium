using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Rendering
{
	// Token: 0x020000A7 RID: 167
	public class ICloudBackground : Il2CppObjectBase
	{
		// Token: 0x06000C62 RID: 3170 RVA: 0x000076A0 File Offset: 0x000058A0
		// Note: this type is marked as 'beforefieldinit'.
		static ICloudBackground()
		{
			Il2CppClassPointerStore<ICloudBackground>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "ICloudBackground");
			ICloudBackground.NativeMethodInfoPtr_IsCloudBackgroundUsable_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICloudBackground>.NativeClassPtr, 100665112);
		}

		// Token: 0x06000C63 RID: 3171 RVA: 0x00039E2C File Offset: 0x0003802C
		[CallerCount(0)]
		public unsafe virtual bool IsCloudBackgroundUsable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICloudBackground.NativeMethodInfoPtr_IsCloudBackgroundUsable_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C64 RID: 3172 RVA: 0x000076CF File Offset: 0x000058CF
		public ICloudBackground(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000945 RID: 2373
		private static readonly IntPtr NativeMethodInfoPtr_IsCloudBackgroundUsable_Public_Abstract_Virtual_New_Boolean_0;
	}
}
