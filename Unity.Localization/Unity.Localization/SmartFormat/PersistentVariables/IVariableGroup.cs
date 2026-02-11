using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Localization.SmartFormat.PersistentVariables
{
	// Token: 0x02000052 RID: 82
	public class IVariableGroup : Il2CppObjectBase
	{
		// Token: 0x06000459 RID: 1113 RVA: 0x00003A71 File Offset: 0x00001C71
		// Note: this type is marked as 'beforefieldinit'.
		static IVariableGroup()
		{
			Il2CppClassPointerStore<IVariableGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat.PersistentVariables", "IVariableGroup");
			IVariableGroup.NativeMethodInfoPtr_TryGetValue_Public_Abstract_Virtual_New_Boolean_String_byref_IVariable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IVariableGroup>.NativeClassPtr, 100664114);
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x00019DEC File Offset: 0x00017FEC
		[CallerCount(0)]
		public unsafe virtual bool TryGetValue(string key, out IVariable value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IVariableGroup.NativeMethodInfoPtr_TryGetValue_Public_Abstract_Virtual_New_Boolean_String_byref_IVariable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			value = ((intPtr4 == 0) ? null : new IVariable(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x00003AA0 File Offset: 0x00001CA0
		public IVariableGroup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000321 RID: 801
		private static readonly IntPtr NativeMethodInfoPtr_TryGetValue_Public_Abstract_Virtual_New_Boolean_String_byref_IVariable_0;
	}
}
