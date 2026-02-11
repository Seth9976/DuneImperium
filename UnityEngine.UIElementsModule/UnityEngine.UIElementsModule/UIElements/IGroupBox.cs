using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.UIElements
{
	// Token: 0x0200013D RID: 317
	public class IGroupBox : Il2CppObjectBase
	{
		// Token: 0x060017AF RID: 6063 RVA: 0x00070D88 File Offset: 0x0006EF88
		// Note: this type is marked as 'beforefieldinit'.
		static IGroupBox()
		{
			Il2CppClassPointerStore<IGroupBox>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "IGroupBox");
			IGroupBox.NativeMethodInfoPtr_OnOptionAdded_Public_Abstract_Virtual_New_Void_IGroupBoxOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGroupBox>.NativeClassPtr, 100666824);
			IGroupBox.NativeMethodInfoPtr_OnOptionRemoved_Public_Abstract_Virtual_New_Void_IGroupBoxOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGroupBox>.NativeClassPtr, 100666825);
		}

		// Token: 0x060017B0 RID: 6064 RVA: 0x00070DD8 File Offset: 0x0006EFD8
		[CallerCount(0)]
		public unsafe virtual void OnOptionAdded(IGroupBoxOption option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGroupBox.NativeMethodInfoPtr_OnOptionAdded_Public_Abstract_Virtual_New_Void_IGroupBoxOption_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017B1 RID: 6065 RVA: 0x00070E28 File Offset: 0x0006F028
		[CallerCount(0)]
		public unsafe virtual void OnOptionRemoved(IGroupBoxOption option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGroupBox.NativeMethodInfoPtr_OnOptionRemoved_Public_Abstract_Virtual_New_Void_IGroupBoxOption_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017B2 RID: 6066 RVA: 0x0000AECA File Offset: 0x000090CA
		public IGroupBox(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400102D RID: 4141
		private static readonly IntPtr NativeMethodInfoPtr_OnOptionAdded_Public_Abstract_Virtual_New_Void_IGroupBoxOption_0;

		// Token: 0x0400102E RID: 4142
		private static readonly IntPtr NativeMethodInfoPtr_OnOptionRemoved_Public_Abstract_Virtual_New_Void_IGroupBoxOption_0;
	}
}
