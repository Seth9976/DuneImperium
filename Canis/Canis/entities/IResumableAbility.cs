using System;
using Canis.actions;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Canis.entities
{
	// Token: 0x020000BB RID: 187
	public class IResumableAbility : Il2CppObjectBase
	{
		// Token: 0x060008B6 RID: 2230 RVA: 0x00005617 File Offset: 0x00003817
		// Note: this type is marked as 'beforefieldinit'.
		static IResumableAbility()
		{
			Il2CppClassPointerStore<IResumableAbility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities", "IResumableAbility");
			IResumableAbility.NativeMethodInfoPtr_Resume_Public_Abstract_Virtual_New_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IResumableAbility>.NativeClassPtr, 100665096);
		}

		// Token: 0x060008B7 RID: 2231 RVA: 0x0003CF2C File Offset: 0x0003B12C
		[CallerCount(0)]
		public unsafe virtual IEnumerable<Action> Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IResumableAbility.NativeMethodInfoPtr_Resume_Public_Abstract_Virtual_New_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
		}

		// Token: 0x060008B8 RID: 2232 RVA: 0x00005646 File Offset: 0x00003846
		public IResumableAbility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040005F1 RID: 1521
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Public_Abstract_Virtual_New_IEnumerable_1_Action_0;
	}
}
