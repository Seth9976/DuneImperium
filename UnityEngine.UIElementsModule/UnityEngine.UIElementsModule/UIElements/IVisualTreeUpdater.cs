using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Unity.Profiling;

namespace UnityEngine.UIElements
{
	// Token: 0x0200023E RID: 574
	public class IVisualTreeUpdater : Il2CppObjectBase
	{
		// Token: 0x06002A5C RID: 10844 RVA: 0x000B864C File Offset: 0x000B684C
		// Note: this type is marked as 'beforefieldinit'.
		static IVisualTreeUpdater()
		{
			Il2CppClassPointerStore<IVisualTreeUpdater>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "IVisualTreeUpdater");
			IVisualTreeUpdater.NativeMethodInfoPtr_set_panel_Public_Abstract_Virtual_New_set_Void_BaseVisualElementPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IVisualTreeUpdater>.NativeClassPtr, 100669630);
			IVisualTreeUpdater.NativeMethodInfoPtr_get_profilerMarker_Public_Abstract_Virtual_New_get_ProfilerMarker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IVisualTreeUpdater>.NativeClassPtr, 100669631);
			IVisualTreeUpdater.NativeMethodInfoPtr_Update_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IVisualTreeUpdater>.NativeClassPtr, 100669632);
			IVisualTreeUpdater.NativeMethodInfoPtr_OnVersionChanged_Public_Abstract_Virtual_New_Void_VisualElement_VersionChangeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IVisualTreeUpdater>.NativeClassPtr, 100669633);
		}

		// Token: 0x17000D2F RID: 3375
		// (set) Token: 0x06002A5D RID: 10845 RVA: 0x000B86C4 File Offset: 0x000B68C4
		public unsafe virtual BaseVisualElementPanel panel
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IVisualTreeUpdater.NativeMethodInfoPtr_set_panel_Public_Abstract_Virtual_New_set_Void_BaseVisualElementPanel_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D30 RID: 3376
		// (get) Token: 0x06002A5E RID: 10846 RVA: 0x000B8714 File Offset: 0x000B6914
		public unsafe virtual ProfilerMarker profilerMarker
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IVisualTreeUpdater.NativeMethodInfoPtr_get_profilerMarker_Public_Abstract_Virtual_New_get_ProfilerMarker_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002A5F RID: 10847 RVA: 0x000B875C File Offset: 0x000B695C
		[CallerCount(0)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IVisualTreeUpdater.NativeMethodInfoPtr_Update_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A60 RID: 10848 RVA: 0x000B8798 File Offset: 0x000B6998
		[CallerCount(0)]
		public unsafe virtual void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref versionChangeType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IVisualTreeUpdater.NativeMethodInfoPtr_OnVersionChanged_Public_Abstract_Virtual_New_Void_VisualElement_VersionChangeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A61 RID: 10849 RVA: 0x0001115D File Offset: 0x0000F35D
		public IVisualTreeUpdater(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001E23 RID: 7715
		private static readonly IntPtr NativeMethodInfoPtr_set_panel_Public_Abstract_Virtual_New_set_Void_BaseVisualElementPanel_0;

		// Token: 0x04001E24 RID: 7716
		private static readonly IntPtr NativeMethodInfoPtr_get_profilerMarker_Public_Abstract_Virtual_New_get_ProfilerMarker_0;

		// Token: 0x04001E25 RID: 7717
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04001E26 RID: 7718
		private static readonly IntPtr NativeMethodInfoPtr_OnVersionChanged_Public_Abstract_Virtual_New_Void_VisualElement_VersionChangeType_0;
	}
}
