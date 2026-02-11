using System;
using dwd.core.util;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.input
{
	// Token: 0x02000046 RID: 70
	public class IMousePressProvider : Il2CppObjectBase
	{
		// Token: 0x0600020E RID: 526 RVA: 0x00003338 File Offset: 0x00001538
		// Note: this type is marked as 'beforefieldinit'.
		static IMousePressProvider()
		{
			Il2CppClassPointerStore<IMousePressProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input", "IMousePressProvider");
			IMousePressProvider.NativeMethodInfoPtr_GetMouseActions_Public_Abstract_Virtual_New_Void_IList_1_PressAction_MouseButton_InputSample_Action_byref_MutableMousePress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMousePressProvider>.NativeClassPtr, 100663566);
		}

		// Token: 0x0600020F RID: 527 RVA: 0x0000D4A4 File Offset: 0x0000B6A4
		[CallerCount(0)]
		public unsafe virtual void GetMouseActions(IList<PressAction> actions, MouseButton button, InputSample sample, Action updatePressesCallback, ref MutableMousePress activePress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(actions);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref button;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(sample));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(updatePressesCallback);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(activePress);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMousePressProvider.NativeMethodInfoPtr_GetMouseActions_Public_Abstract_Virtual_New_Void_IList_1_PressAction_MouseButton_InputSample_Action_byref_MutableMousePress_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			activePress = ((intPtr4 == 0) ? null : new MutableMousePress(intPtr4));
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00003367 File Offset: 0x00001567
		public IMousePressProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000131 RID: 305
		private static readonly IntPtr NativeMethodInfoPtr_GetMouseActions_Public_Abstract_Virtual_New_Void_IList_1_PressAction_MouseButton_InputSample_Action_byref_MutableMousePress_0;
	}
}
