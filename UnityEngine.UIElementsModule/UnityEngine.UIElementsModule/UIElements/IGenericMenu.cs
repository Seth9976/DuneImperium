using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200005C RID: 92
	public class IGenericMenu : Il2CppObjectBase
	{
		// Token: 0x06000864 RID: 2148 RVA: 0x0003AD34 File Offset: 0x00038F34
		// Note: this type is marked as 'beforefieldinit'.
		static IGenericMenu()
		{
			Il2CppClassPointerStore<IGenericMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "IGenericMenu");
			IGenericMenu.NativeMethodInfoPtr_AddItem_Public_Abstract_Virtual_New_Void_String_Boolean_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGenericMenu>.NativeClassPtr, 100664516);
			IGenericMenu.NativeMethodInfoPtr_AddItem_Public_Abstract_Virtual_New_Void_String_Boolean_Action_1_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGenericMenu>.NativeClassPtr, 100664517);
			IGenericMenu.NativeMethodInfoPtr_DropDown_Public_Abstract_Virtual_New_Void_Rect_VisualElement_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGenericMenu>.NativeClassPtr, 100664518);
		}

		// Token: 0x06000865 RID: 2149 RVA: 0x0003AD98 File Offset: 0x00038F98
		[CallerCount(0)]
		public unsafe virtual void AddItem(string itemName, bool isChecked, Action action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(itemName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isChecked;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGenericMenu.NativeMethodInfoPtr_AddItem_Public_Abstract_Virtual_New_Void_String_Boolean_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000866 RID: 2150 RVA: 0x0003AE08 File Offset: 0x00039008
		[CallerCount(0)]
		public unsafe virtual void AddItem(string itemName, bool isChecked, Action<Object> action, Object data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(itemName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isChecked;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGenericMenu.NativeMethodInfoPtr_AddItem_Public_Abstract_Virtual_New_Void_String_Boolean_Action_1_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x0003AE88 File Offset: 0x00039088
		[CallerCount(0)]
		public unsafe virtual void DropDown(Rect position, VisualElement targetElement = null, bool anchored = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetElement);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref anchored;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGenericMenu.NativeMethodInfoPtr_DropDown_Public_Abstract_Virtual_New_Void_Rect_VisualElement_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x00004EE1 File Offset: 0x000030E1
		public IGenericMenu(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040005E7 RID: 1511
		private static readonly IntPtr NativeMethodInfoPtr_AddItem_Public_Abstract_Virtual_New_Void_String_Boolean_Action_0;

		// Token: 0x040005E8 RID: 1512
		private static readonly IntPtr NativeMethodInfoPtr_AddItem_Public_Abstract_Virtual_New_Void_String_Boolean_Action_1_Object_Object_0;

		// Token: 0x040005E9 RID: 1513
		private static readonly IntPtr NativeMethodInfoPtr_DropDown_Public_Abstract_Virtual_New_Void_Rect_VisualElement_Boolean_0;
	}
}
