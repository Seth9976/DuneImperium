using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.UIElements
{
	// Token: 0x020000BE RID: 190
	public class IPointerCaptureEventInternal : Il2CppObjectBase
	{
		// Token: 0x0600118F RID: 4495 RVA: 0x00008CF1 File Offset: 0x00006EF1
		// Note: this type is marked as 'beforefieldinit'.
		static IPointerCaptureEventInternal()
		{
			Il2CppClassPointerStore<IPointerCaptureEventInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "IPointerCaptureEventInternal");
			IPointerCaptureEventInternal.NativeMethodInfoPtr_get_pointerId_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPointerCaptureEventInternal>.NativeClassPtr, 100665768);
		}

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x06001190 RID: 4496 RVA: 0x0005A620 File Offset: 0x00058820
		public unsafe virtual int pointerId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPointerCaptureEventInternal.NativeMethodInfoPtr_get_pointerId_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001191 RID: 4497 RVA: 0x00008D20 File Offset: 0x00006F20
		public IPointerCaptureEventInternal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C0C RID: 3084
		private static readonly IntPtr NativeMethodInfoPtr_get_pointerId_Public_Abstract_Virtual_New_get_Int32_0;
	}
}
