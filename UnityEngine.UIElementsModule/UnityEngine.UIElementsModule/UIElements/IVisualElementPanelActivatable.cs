using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x02000230 RID: 560
	public class IVisualElementPanelActivatable : Il2CppObjectBase
	{
		// Token: 0x06002976 RID: 10614 RVA: 0x000B55DC File Offset: 0x000B37DC
		// Note: this type is marked as 'beforefieldinit'.
		static IVisualElementPanelActivatable()
		{
			Il2CppClassPointerStore<IVisualElementPanelActivatable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "IVisualElementPanelActivatable");
			IVisualElementPanelActivatable.NativeMethodInfoPtr_get_element_Public_Abstract_Virtual_New_get_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IVisualElementPanelActivatable>.NativeClassPtr, 100669528);
			IVisualElementPanelActivatable.NativeMethodInfoPtr_CanBeActivated_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IVisualElementPanelActivatable>.NativeClassPtr, 100669529);
			IVisualElementPanelActivatable.NativeMethodInfoPtr_OnPanelActivate_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IVisualElementPanelActivatable>.NativeClassPtr, 100669530);
			IVisualElementPanelActivatable.NativeMethodInfoPtr_OnPanelDeactivate_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IVisualElementPanelActivatable>.NativeClassPtr, 100669531);
		}

		// Token: 0x17000CED RID: 3309
		// (get) Token: 0x06002977 RID: 10615 RVA: 0x000B5654 File Offset: 0x000B3854
		public unsafe virtual VisualElement element
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IVisualElementPanelActivatable.NativeMethodInfoPtr_get_element_Public_Abstract_Virtual_New_get_VisualElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
			}
		}

		// Token: 0x06002978 RID: 10616 RVA: 0x000B56A0 File Offset: 0x000B38A0
		[CallerCount(0)]
		public unsafe virtual bool CanBeActivated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IVisualElementPanelActivatable.NativeMethodInfoPtr_CanBeActivated_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002979 RID: 10617 RVA: 0x000B56E8 File Offset: 0x000B38E8
		[CallerCount(0)]
		public unsafe virtual void OnPanelActivate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IVisualElementPanelActivatable.NativeMethodInfoPtr_OnPanelActivate_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600297A RID: 10618 RVA: 0x000B5724 File Offset: 0x000B3924
		[CallerCount(0)]
		public unsafe virtual void OnPanelDeactivate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IVisualElementPanelActivatable.NativeMethodInfoPtr_OnPanelDeactivate_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600297B RID: 10619 RVA: 0x00010B21 File Offset: 0x0000ED21
		public IVisualElementPanelActivatable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001D8B RID: 7563
		private static readonly IntPtr NativeMethodInfoPtr_get_element_Public_Abstract_Virtual_New_get_VisualElement_0;

		// Token: 0x04001D8C RID: 7564
		private static readonly IntPtr NativeMethodInfoPtr_CanBeActivated_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x04001D8D RID: 7565
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelActivate_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04001D8E RID: 7566
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelDeactivate_Public_Abstract_Virtual_New_Void_0;
	}
}
