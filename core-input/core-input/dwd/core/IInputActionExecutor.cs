using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;

namespace dwd.core
{
	// Token: 0x02000022 RID: 34
	public class IInputActionExecutor : Il2CppObjectBase
	{
		// Token: 0x06000107 RID: 263 RVA: 0x00002895 File Offset: 0x00000A95
		// Note: this type is marked as 'beforefieldinit'.
		static IInputActionExecutor()
		{
			Il2CppClassPointerStore<IInputActionExecutor>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core", "IInputActionExecutor");
			IInputActionExecutor.NativeMethodInfoPtr_ExportInputActions_Public_Abstract_Virtual_New_Void_byref_Dictionary_2_String_List_1_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInputActionExecutor>.NativeClassPtr, 100663444);
		}

		// Token: 0x06000108 RID: 264 RVA: 0x0000A6E0 File Offset: 0x000088E0
		[CallerCount(0)]
		public unsafe virtual void ExportInputActions([In] ref Dictionary<string, List<InputAction>> actionLookup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(actionLookup);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IInputActionExecutor.NativeMethodInfoPtr_ExportInputActions_Public_Abstract_Virtual_New_Void_byref_Dictionary_2_String_List_1_InputAction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				actionLookup = ((intPtr4 == 0) ? null : new Dictionary<string, List<InputAction>>(intPtr4));
			}
		}

		// Token: 0x06000109 RID: 265 RVA: 0x000028C4 File Offset: 0x00000AC4
		public IInputActionExecutor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeMethodInfoPtr_ExportInputActions_Public_Abstract_Virtual_New_Void_byref_Dictionary_2_String_List_1_InputAction_0;
	}
}
