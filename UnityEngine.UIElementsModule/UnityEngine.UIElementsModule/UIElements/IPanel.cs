using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x0200015A RID: 346
	public class IPanel : Il2CppObjectBase
	{
		// Token: 0x060018E7 RID: 6375 RVA: 0x00074E04 File Offset: 0x00073004
		// Note: this type is marked as 'beforefieldinit'.
		static IPanel()
		{
			Il2CppClassPointerStore<IPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "IPanel");
			IPanel.NativeMethodInfoPtr_get_visualTree_Public_Abstract_Virtual_New_get_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPanel>.NativeClassPtr, 100666957);
			IPanel.NativeMethodInfoPtr_get_dispatcher_Public_Abstract_Virtual_New_get_EventDispatcher_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPanel>.NativeClassPtr, 100666958);
			IPanel.NativeMethodInfoPtr_get_contextType_Public_Abstract_Virtual_New_get_ContextType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPanel>.NativeClassPtr, 100666959);
			IPanel.NativeMethodInfoPtr_get_focusController_Public_Abstract_Virtual_New_get_FocusController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPanel>.NativeClassPtr, 100666960);
			IPanel.NativeMethodInfoPtr_Pick_Public_Abstract_Virtual_New_VisualElement_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPanel>.NativeClassPtr, 100666961);
		}

		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x060018E8 RID: 6376 RVA: 0x00074E90 File Offset: 0x00073090
		public unsafe virtual VisualElement visualTree
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPanel.NativeMethodInfoPtr_get_visualTree_Public_Abstract_Virtual_New_get_VisualElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
			}
		}

		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x060018E9 RID: 6377 RVA: 0x00074EDC File Offset: 0x000730DC
		public unsafe virtual EventDispatcher dispatcher
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPanel.NativeMethodInfoPtr_get_dispatcher_Public_Abstract_Virtual_New_get_EventDispatcher_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventDispatcher>(intPtr3) : null;
			}
		}

		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x060018EA RID: 6378 RVA: 0x00074F28 File Offset: 0x00073128
		public unsafe virtual ContextType contextType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPanel.NativeMethodInfoPtr_get_contextType_Public_Abstract_Virtual_New_get_ContextType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x060018EB RID: 6379 RVA: 0x00074F70 File Offset: 0x00073170
		public unsafe virtual FocusController focusController
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPanel.NativeMethodInfoPtr_get_focusController_Public_Abstract_Virtual_New_get_FocusController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FocusController>(intPtr3) : null;
			}
		}

		// Token: 0x060018EC RID: 6380 RVA: 0x00074FBC File Offset: 0x000731BC
		[CallerCount(0)]
		public unsafe virtual VisualElement Pick(Vector2 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref point;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPanel.NativeMethodInfoPtr_Pick_Public_Abstract_Virtual_New_VisualElement_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
			}
		}

		// Token: 0x060018ED RID: 6381 RVA: 0x0000B6C7 File Offset: 0x000098C7
		public IPanel(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001144 RID: 4420
		private static readonly IntPtr NativeMethodInfoPtr_get_visualTree_Public_Abstract_Virtual_New_get_VisualElement_0;

		// Token: 0x04001145 RID: 4421
		private static readonly IntPtr NativeMethodInfoPtr_get_dispatcher_Public_Abstract_Virtual_New_get_EventDispatcher_0;

		// Token: 0x04001146 RID: 4422
		private static readonly IntPtr NativeMethodInfoPtr_get_contextType_Public_Abstract_Virtual_New_get_ContextType_0;

		// Token: 0x04001147 RID: 4423
		private static readonly IntPtr NativeMethodInfoPtr_get_focusController_Public_Abstract_Virtual_New_get_FocusController_0;

		// Token: 0x04001148 RID: 4424
		private static readonly IntPtr NativeMethodInfoPtr_Pick_Public_Abstract_Virtual_New_VisualElement_Vector2_0;
	}
}
