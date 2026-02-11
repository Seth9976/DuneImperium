using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.UI;

namespace worm.match.Interfaces
{
	// Token: 0x020000EF RID: 239
	public class IPlaymatToggleView : Il2CppObjectBase
	{
		// Token: 0x06000A93 RID: 2707 RVA: 0x00038428 File Offset: 0x00036628
		// Note: this type is marked as 'beforefieldinit'.
		static IPlaymatToggleView()
		{
			Il2CppClassPointerStore<IPlaymatToggleView>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.Interfaces", "IPlaymatToggleView");
			IPlaymatToggleView.NativeMethodInfoPtr_get_OverrideToggle_Public_Abstract_Virtual_New_get_Toggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlaymatToggleView>.NativeClassPtr, 100664747);
			IPlaymatToggleView.NativeMethodInfoPtr_set_OverrideToggle_Public_Abstract_Virtual_New_set_Void_Toggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlaymatToggleView>.NativeClassPtr, 100664748);
			IPlaymatToggleView.NativeMethodInfoPtr_Event_ToggleRow_Public_Abstract_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlaymatToggleView>.NativeClassPtr, 100664749);
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06000A94 RID: 2708 RVA: 0x0003848C File Offset: 0x0003668C
		// (set) Token: 0x06000A95 RID: 2709 RVA: 0x000384D8 File Offset: 0x000366D8
		public unsafe virtual Toggle OverrideToggle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlaymatToggleView.NativeMethodInfoPtr_get_OverrideToggle_Public_Abstract_Virtual_New_get_Toggle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlaymatToggleView.NativeMethodInfoPtr_set_OverrideToggle_Public_Abstract_Virtual_New_set_Void_Toggle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000A96 RID: 2710 RVA: 0x00038528 File Offset: 0x00036728
		[CallerCount(0)]
		public unsafe virtual void Event_ToggleRow(bool isOn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isOn;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlaymatToggleView.NativeMethodInfoPtr_Event_ToggleRow_Public_Abstract_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A97 RID: 2711 RVA: 0x000078A1 File Offset: 0x00005AA1
		public IPlaymatToggleView(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400061B RID: 1563
		private static readonly IntPtr NativeMethodInfoPtr_get_OverrideToggle_Public_Abstract_Virtual_New_get_Toggle_0;

		// Token: 0x0400061C RID: 1564
		private static readonly IntPtr NativeMethodInfoPtr_set_OverrideToggle_Public_Abstract_Virtual_New_set_Void_Toggle_0;

		// Token: 0x0400061D RID: 1565
		private static readonly IntPtr NativeMethodInfoPtr_Event_ToggleRow_Public_Abstract_Virtual_New_Void_Boolean_0;
	}
}
