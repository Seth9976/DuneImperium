using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x020000B2 RID: 178
	public class IPostProcessComponent : Il2CppObjectBase
	{
		// Token: 0x06000DF2 RID: 3570 RVA: 0x00045B34 File Offset: 0x00043D34
		// Note: this type is marked as 'beforefieldinit'.
		static IPostProcessComponent()
		{
			Il2CppClassPointerStore<IPostProcessComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "IPostProcessComponent");
			IPostProcessComponent.NativeMethodInfoPtr_IsActive_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPostProcessComponent>.NativeClassPtr, 100665116);
			IPostProcessComponent.NativeMethodInfoPtr_IsTileCompatible_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPostProcessComponent>.NativeClassPtr, 100665117);
		}

		// Token: 0x06000DF3 RID: 3571 RVA: 0x00045B84 File Offset: 0x00043D84
		[CallerCount(0)]
		public unsafe virtual bool IsActive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPostProcessComponent.NativeMethodInfoPtr_IsActive_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DF4 RID: 3572 RVA: 0x00045BCC File Offset: 0x00043DCC
		[CallerCount(0)]
		public unsafe virtual bool IsTileCompatible()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPostProcessComponent.NativeMethodInfoPtr_IsTileCompatible_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DF5 RID: 3573 RVA: 0x00008989 File Offset: 0x00006B89
		public IPostProcessComponent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000A2C RID: 2604
		private static readonly IntPtr NativeMethodInfoPtr_IsActive_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x04000A2D RID: 2605
		private static readonly IntPtr NativeMethodInfoPtr_IsTileCompatible_Public_Abstract_Virtual_New_Boolean_0;
	}
}
