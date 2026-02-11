using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Localization.SmartFormat.Core.Extensions;

namespace UnityEngine.Localization.SmartFormat.PersistentVariables
{
	// Token: 0x02000053 RID: 83
	public class IVariable : Il2CppObjectBase
	{
		// Token: 0x0600045C RID: 1116 RVA: 0x00003AA9 File Offset: 0x00001CA9
		// Note: this type is marked as 'beforefieldinit'.
		static IVariable()
		{
			Il2CppClassPointerStore<IVariable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat.PersistentVariables", "IVariable");
			IVariable.NativeMethodInfoPtr_GetSourceValue_Public_Abstract_Virtual_New_Object_ISelectorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IVariable>.NativeClassPtr, 100664115);
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x00019E68 File Offset: 0x00018068
		[CallerCount(0)]
		public unsafe virtual Object GetSourceValue(ISelectorInfo selector)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selector);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IVariable.NativeMethodInfoPtr_GetSourceValue_Public_Abstract_Virtual_New_Object_ISelectorInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x00003AD8 File Offset: 0x00001CD8
		public IVariable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000322 RID: 802
		private static readonly IntPtr NativeMethodInfoPtr_GetSourceValue_Public_Abstract_Virtual_New_Object_ISelectorInfo_0;
	}
}
