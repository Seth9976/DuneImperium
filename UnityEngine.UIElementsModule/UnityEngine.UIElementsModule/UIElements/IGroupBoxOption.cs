using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.UIElements
{
	// Token: 0x0200013C RID: 316
	public class IGroupBoxOption : Il2CppObjectBase
	{
		// Token: 0x060017AC RID: 6060 RVA: 0x0000AE92 File Offset: 0x00009092
		// Note: this type is marked as 'beforefieldinit'.
		static IGroupBoxOption()
		{
			Il2CppClassPointerStore<IGroupBoxOption>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "IGroupBoxOption");
			IGroupBoxOption.NativeMethodInfoPtr_SetSelected_Public_Abstract_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGroupBoxOption>.NativeClassPtr, 100666823);
		}

		// Token: 0x060017AD RID: 6061 RVA: 0x00070D3C File Offset: 0x0006EF3C
		[CallerCount(0)]
		public unsafe virtual void SetSelected(bool selected)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref selected;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGroupBoxOption.NativeMethodInfoPtr_SetSelected_Public_Abstract_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017AE RID: 6062 RVA: 0x0000AEC1 File Offset: 0x000090C1
		public IGroupBoxOption(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400102C RID: 4140
		private static readonly IntPtr NativeMethodInfoPtr_SetSelected_Public_Abstract_Virtual_New_Void_Boolean_0;
	}
}
