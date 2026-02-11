using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.UIElements
{
	// Token: 0x02000149 RID: 329
	public class IManipulator : Il2CppObjectBase
	{
		// Token: 0x06001856 RID: 6230 RVA: 0x0000B288 File Offset: 0x00009488
		// Note: this type is marked as 'beforefieldinit'.
		static IManipulator()
		{
			Il2CppClassPointerStore<IManipulator>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "IManipulator");
			IManipulator.NativeMethodInfoPtr_set_target_Public_Abstract_Virtual_New_set_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IManipulator>.NativeClassPtr, 100666908);
		}

		// Token: 0x17000763 RID: 1891
		// (set) Token: 0x06001857 RID: 6231 RVA: 0x00073460 File Offset: 0x00071660
		public unsafe virtual VisualElement target
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IManipulator.NativeMethodInfoPtr_set_target_Public_Abstract_Virtual_New_set_Void_VisualElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001858 RID: 6232 RVA: 0x0000B2B7 File Offset: 0x000094B7
		public IManipulator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040010B3 RID: 4275
		private static readonly IntPtr NativeMethodInfoPtr_set_target_Public_Abstract_Virtual_New_set_Void_VisualElement_0;
	}
}
