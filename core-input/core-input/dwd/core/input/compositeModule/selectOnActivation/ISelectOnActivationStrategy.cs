using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace dwd.core.input.compositeModule.selectOnActivation
{
	// Token: 0x02000091 RID: 145
	public class ISelectOnActivationStrategy : Il2CppObjectBase
	{
		// Token: 0x06000636 RID: 1590 RVA: 0x00005606 File Offset: 0x00003806
		// Note: this type is marked as 'beforefieldinit'.
		static ISelectOnActivationStrategy()
		{
			Il2CppClassPointerStore<ISelectOnActivationStrategy>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.compositeModule.selectOnActivation", "ISelectOnActivationStrategy");
			ISelectOnActivationStrategy.NativeMethodInfoPtr_GetSelection_Public_Abstract_Virtual_New_GameObject_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISelectOnActivationStrategy>.NativeClassPtr, 100664066);
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x0001A95C File Offset: 0x00018B5C
		[CallerCount(0)]
		public unsafe virtual GameObject GetSelection(GameObject lastSelectionOnDeactivation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lastSelectionOnDeactivation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISelectOnActivationStrategy.NativeMethodInfoPtr_GetSelection_Public_Abstract_Virtual_New_GameObject_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x00005635 File Offset: 0x00003835
		public ISelectOnActivationStrategy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003C3 RID: 963
		private static readonly IntPtr NativeMethodInfoPtr_GetSelection_Public_Abstract_Virtual_New_GameObject_GameObject_0;
	}
}
