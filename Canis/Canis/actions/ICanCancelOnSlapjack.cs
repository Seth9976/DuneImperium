using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.actions
{
	// Token: 0x0200017D RID: 381
	public class ICanCancelOnSlapjack : Il2CppObjectBase
	{
		// Token: 0x060010E2 RID: 4322 RVA: 0x00008754 File Offset: 0x00006954
		// Note: this type is marked as 'beforefieldinit'.
		static ICanCancelOnSlapjack()
		{
			Il2CppClassPointerStore<ICanCancelOnSlapjack>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "ICanCancelOnSlapjack");
			ICanCancelOnSlapjack.NativeMethodInfoPtr_CancelOnSlapjack_Public_Abstract_Virtual_New_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICanCancelOnSlapjack>.NativeClassPtr, 100666812);
		}

		// Token: 0x060010E3 RID: 4323 RVA: 0x0005E0A4 File Offset: 0x0005C2A4
		[CallerCount(0)]
		public unsafe virtual Action CancelOnSlapjack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICanCancelOnSlapjack.NativeMethodInfoPtr_CancelOnSlapjack_Public_Abstract_Virtual_New_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
		}

		// Token: 0x060010E4 RID: 4324 RVA: 0x00008783 File Offset: 0x00006983
		public ICanCancelOnSlapjack(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B1E RID: 2846
		private static readonly IntPtr NativeMethodInfoPtr_CancelOnSlapjack_Public_Abstract_Virtual_New_Action_0;
	}
}
