using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x02000134 RID: 308
	public class IChangeTracking : Il2CppObjectBase
	{
		// Token: 0x0600129D RID: 4765 RVA: 0x00063E18 File Offset: 0x00062018
		// Note: this type is marked as 'beforefieldinit'.
		static IChangeTracking()
		{
			Il2CppClassPointerStore<IChangeTracking>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "IChangeTracking");
			IChangeTracking.NativeMethodInfoPtr_get_IsChanged_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IChangeTracking>.NativeClassPtr, 100666014);
			IChangeTracking.NativeMethodInfoPtr_AcceptChanges_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IChangeTracking>.NativeClassPtr, 100666015);
		}

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x0600129E RID: 4766 RVA: 0x00063E68 File Offset: 0x00062068
		public unsafe virtual bool IsChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IChangeTracking.NativeMethodInfoPtr_get_IsChanged_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600129F RID: 4767 RVA: 0x00063EB0 File Offset: 0x000620B0
		[CallerCount(0)]
		public unsafe virtual void AcceptChanges()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IChangeTracking.NativeMethodInfoPtr_AcceptChanges_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012A0 RID: 4768 RVA: 0x00008825 File Offset: 0x00006A25
		public IChangeTracking(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000ECB RID: 3787
		private static readonly IntPtr NativeMethodInfoPtr_get_IsChanged_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000ECC RID: 3788
		private static readonly IntPtr NativeMethodInfoPtr_AcceptChanges_Public_Abstract_Virtual_New_Void_0;
	}
}
