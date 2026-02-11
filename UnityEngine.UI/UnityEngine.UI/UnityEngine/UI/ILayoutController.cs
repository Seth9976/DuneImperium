using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.UI
{
	// Token: 0x02000021 RID: 33
	public class ILayoutController : Il2CppObjectBase
	{
		// Token: 0x06000455 RID: 1109 RVA: 0x00017CAC File Offset: 0x00015EAC
		// Note: this type is marked as 'beforefieldinit'.
		static ILayoutController()
		{
			Il2CppClassPointerStore<ILayoutController>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "ILayoutController");
			ILayoutController.NativeMethodInfoPtr_SetLayoutHorizontal_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILayoutController>.NativeClassPtr, 100663992);
			ILayoutController.NativeMethodInfoPtr_SetLayoutVertical_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILayoutController>.NativeClassPtr, 100663993);
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x00017CFC File Offset: 0x00015EFC
		[CallerCount(0)]
		public unsafe virtual void SetLayoutHorizontal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILayoutController.NativeMethodInfoPtr_SetLayoutHorizontal_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x00017D38 File Offset: 0x00015F38
		[CallerCount(0)]
		public unsafe virtual void SetLayoutVertical()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILayoutController.NativeMethodInfoPtr_SetLayoutVertical_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x000037C3 File Offset: 0x000019C3
		public ILayoutController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000357 RID: 855
		private static readonly IntPtr NativeMethodInfoPtr_SetLayoutHorizontal_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04000358 RID: 856
		private static readonly IntPtr NativeMethodInfoPtr_SetLayoutVertical_Public_Abstract_Virtual_New_Void_0;
	}
}
