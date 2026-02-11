using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x02000135 RID: 309
	public class IRevertibleChangeTracking : Il2CppObjectBase
	{
		// Token: 0x060012A1 RID: 4769 RVA: 0x0000882E File Offset: 0x00006A2E
		// Note: this type is marked as 'beforefieldinit'.
		static IRevertibleChangeTracking()
		{
			Il2CppClassPointerStore<IRevertibleChangeTracking>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "IRevertibleChangeTracking");
			IRevertibleChangeTracking.NativeMethodInfoPtr_RejectChanges_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRevertibleChangeTracking>.NativeClassPtr, 100666016);
		}

		// Token: 0x060012A2 RID: 4770 RVA: 0x00063EEC File Offset: 0x000620EC
		[CallerCount(0)]
		public unsafe virtual void RejectChanges()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRevertibleChangeTracking.NativeMethodInfoPtr_RejectChanges_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012A3 RID: 4771 RVA: 0x0000885D File Offset: 0x00006A5D
		public IRevertibleChangeTracking(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000ECD RID: 3789
		private static readonly IntPtr NativeMethodInfoPtr_RejectChanges_Public_Abstract_Virtual_New_Void_0;
	}
}
