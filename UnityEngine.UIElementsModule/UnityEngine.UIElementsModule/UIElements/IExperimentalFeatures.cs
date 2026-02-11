using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.UIElements.Experimental;

namespace UnityEngine.UIElements
{
	// Token: 0x0200022A RID: 554
	public class IExperimentalFeatures : Il2CppObjectBase
	{
		// Token: 0x0600293B RID: 10555 RVA: 0x00010A0E File Offset: 0x0000EC0E
		// Note: this type is marked as 'beforefieldinit'.
		static IExperimentalFeatures()
		{
			Il2CppClassPointerStore<IExperimentalFeatures>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "IExperimentalFeatures");
			IExperimentalFeatures.NativeMethodInfoPtr_get_animation_Public_Abstract_Virtual_New_get_ITransitionAnimations_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExperimentalFeatures>.NativeClassPtr, 100669490);
		}

		// Token: 0x17000CDE RID: 3294
		// (get) Token: 0x0600293C RID: 10556 RVA: 0x000B4758 File Offset: 0x000B2958
		public unsafe virtual UnityEngine.UIElements.Experimental.ITransitionAnimations animation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExperimentalFeatures.NativeMethodInfoPtr_get_animation_Public_Abstract_Virtual_New_get_ITransitionAnimations_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityEngine.UIElements.Experimental.ITransitionAnimations>(intPtr3) : null;
			}
		}

		// Token: 0x0600293D RID: 10557 RVA: 0x00010A3D File Offset: 0x0000EC3D
		public IExperimentalFeatures(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001D64 RID: 7524
		private static readonly IntPtr NativeMethodInfoPtr_get_animation_Public_Abstract_Virtual_New_get_ITransitionAnimations_0;
	}
}
