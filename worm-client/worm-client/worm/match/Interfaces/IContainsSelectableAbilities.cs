using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace worm.match.Interfaces
{
	// Token: 0x020000EE RID: 238
	public class IContainsSelectableAbilities : Il2CppObjectBase
	{
		// Token: 0x06000A90 RID: 2704 RVA: 0x00007869 File Offset: 0x00005A69
		// Note: this type is marked as 'beforefieldinit'.
		static IContainsSelectableAbilities()
		{
			Il2CppClassPointerStore<IContainsSelectableAbilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.Interfaces", "IContainsSelectableAbilities");
			IContainsSelectableAbilities.NativeMethodInfoPtr_get_SelectableAbilities_Public_Abstract_Virtual_New_get_IEnumerable_1_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IContainsSelectableAbilities>.NativeClassPtr, 100664746);
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06000A91 RID: 2705 RVA: 0x000383DC File Offset: 0x000365DC
		public unsafe virtual IEnumerable<EntityID> SelectableAbilities
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IContainsSelectableAbilities.NativeMethodInfoPtr_get_SelectableAbilities_Public_Abstract_Virtual_New_get_IEnumerable_1_EntityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<EntityID>>(intPtr3) : null;
			}
		}

		// Token: 0x06000A92 RID: 2706 RVA: 0x00007898 File Offset: 0x00005A98
		public IContainsSelectableAbilities(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400061A RID: 1562
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectableAbilities_Public_Abstract_Virtual_New_get_IEnumerable_1_EntityID_0;
	}
}
