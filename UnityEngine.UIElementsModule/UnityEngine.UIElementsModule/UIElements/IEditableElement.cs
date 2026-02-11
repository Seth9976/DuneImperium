using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000065 RID: 101
	public class IEditableElement : Il2CppObjectBase
	{
		// Token: 0x06000936 RID: 2358 RVA: 0x0003DA30 File Offset: 0x0003BC30
		// Note: this type is marked as 'beforefieldinit'.
		static IEditableElement()
		{
			Il2CppClassPointerStore<IEditableElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "IEditableElement");
			IEditableElement.NativeMethodInfoPtr_get_editingStarted_Internal_Abstract_Virtual_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEditableElement>.NativeClassPtr, 100664618);
			IEditableElement.NativeMethodInfoPtr_get_editingEnded_Internal_Abstract_Virtual_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEditableElement>.NativeClassPtr, 100664619);
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x06000937 RID: 2359 RVA: 0x0003DA80 File Offset: 0x0003BC80
		public unsafe virtual Action editingStarted
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IEditableElement.NativeMethodInfoPtr_get_editingStarted_Internal_Abstract_Virtual_New_get_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x06000938 RID: 2360 RVA: 0x0003DACC File Offset: 0x0003BCCC
		public unsafe virtual Action editingEnded
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IEditableElement.NativeMethodInfoPtr_get_editingEnded_Internal_Abstract_Virtual_New_get_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x06000939 RID: 2361 RVA: 0x0000543E File Offset: 0x0000363E
		public IEditableElement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400066E RID: 1646
		private static readonly IntPtr NativeMethodInfoPtr_get_editingStarted_Internal_Abstract_Virtual_New_get_Action_0;

		// Token: 0x0400066F RID: 1647
		private static readonly IntPtr NativeMethodInfoPtr_get_editingEnded_Internal_Abstract_Virtual_New_get_Action_0;
	}
}
