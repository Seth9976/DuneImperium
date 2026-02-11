using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.Localization.SmartFormat.PersistentVariables
{
	// Token: 0x02000055 RID: 85
	public class IVariableValueChanged : Il2CppObjectBase
	{
		// Token: 0x06000462 RID: 1122 RVA: 0x00019F08 File Offset: 0x00018108
		// Note: this type is marked as 'beforefieldinit'.
		static IVariableValueChanged()
		{
			Il2CppClassPointerStore<IVariableValueChanged>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat.PersistentVariables", "IVariableValueChanged");
			IVariableValueChanged.NativeMethodInfoPtr_add_ValueChanged_Public_Abstract_Virtual_New_add_Void_Action_1_IVariable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IVariableValueChanged>.NativeClassPtr, 100664117);
			IVariableValueChanged.NativeMethodInfoPtr_remove_ValueChanged_Public_Abstract_Virtual_New_rem_Void_Action_1_IVariable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IVariableValueChanged>.NativeClassPtr, 100664118);
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x00019F58 File Offset: 0x00018158
		[CallerCount(0)]
		public unsafe virtual void add_ValueChanged(Action<IVariable> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IVariableValueChanged.NativeMethodInfoPtr_add_ValueChanged_Public_Abstract_Virtual_New_add_Void_Action_1_IVariable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x00019FA8 File Offset: 0x000181A8
		[CallerCount(0)]
		public unsafe virtual void remove_ValueChanged(Action<IVariable> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IVariableValueChanged.NativeMethodInfoPtr_remove_ValueChanged_Public_Abstract_Virtual_New_rem_Void_Action_1_IVariable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x00003B19 File Offset: 0x00001D19
		public IVariableValueChanged(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000324 RID: 804
		private static readonly IntPtr NativeMethodInfoPtr_add_ValueChanged_Public_Abstract_Virtual_New_add_Void_Action_1_IVariable_0;

		// Token: 0x04000325 RID: 805
		private static readonly IntPtr NativeMethodInfoPtr_remove_ValueChanged_Public_Abstract_Virtual_New_rem_Void_Action_1_IVariable_0;
	}
}
