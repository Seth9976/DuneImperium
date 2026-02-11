using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.UIElements
{
	// Token: 0x020000EB RID: 235
	public class IKeyboardEvent : Il2CppObjectBase
	{
		// Token: 0x0600137D RID: 4989 RVA: 0x0006171C File Offset: 0x0005F91C
		// Note: this type is marked as 'beforefieldinit'.
		static IKeyboardEvent()
		{
			Il2CppClassPointerStore<IKeyboardEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "IKeyboardEvent");
			IKeyboardEvent.NativeMethodInfoPtr_get_modifiers_Public_Abstract_Virtual_New_get_EventModifiers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IKeyboardEvent>.NativeClassPtr, 100666064);
			IKeyboardEvent.NativeMethodInfoPtr_get_character_Public_Abstract_Virtual_New_get_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IKeyboardEvent>.NativeClassPtr, 100666065);
			IKeyboardEvent.NativeMethodInfoPtr_get_keyCode_Public_Abstract_Virtual_New_get_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IKeyboardEvent>.NativeClassPtr, 100666066);
		}

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x0600137E RID: 4990 RVA: 0x00061780 File Offset: 0x0005F980
		public unsafe virtual EventModifiers modifiers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IKeyboardEvent.NativeMethodInfoPtr_get_modifiers_Public_Abstract_Virtual_New_get_EventModifiers_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x0600137F RID: 4991 RVA: 0x000617C8 File Offset: 0x0005F9C8
		public unsafe virtual char character
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IKeyboardEvent.NativeMethodInfoPtr_get_character_Public_Abstract_Virtual_New_get_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x06001380 RID: 4992 RVA: 0x00061810 File Offset: 0x0005FA10
		public unsafe virtual KeyCode keyCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IKeyboardEvent.NativeMethodInfoPtr_get_keyCode_Public_Abstract_Virtual_New_get_KeyCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001381 RID: 4993 RVA: 0x00009818 File Offset: 0x00007A18
		public IKeyboardEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D47 RID: 3399
		private static readonly IntPtr NativeMethodInfoPtr_get_modifiers_Public_Abstract_Virtual_New_get_EventModifiers_0;

		// Token: 0x04000D48 RID: 3400
		private static readonly IntPtr NativeMethodInfoPtr_get_character_Public_Abstract_Virtual_New_get_Char_0;

		// Token: 0x04000D49 RID: 3401
		private static readonly IntPtr NativeMethodInfoPtr_get_keyCode_Public_Abstract_Virtual_New_get_KeyCode_0;
	}
}
