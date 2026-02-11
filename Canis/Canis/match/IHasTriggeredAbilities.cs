using System;
using Canis.entities;
using Canis.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Canis.match
{
	// Token: 0x02000094 RID: 148
	public class IHasTriggeredAbilities : Il2CppObjectBase
	{
		// Token: 0x06000788 RID: 1928 RVA: 0x00004E05 File Offset: 0x00003005
		// Note: this type is marked as 'beforefieldinit'.
		static IHasTriggeredAbilities()
		{
			Il2CppClassPointerStore<IHasTriggeredAbilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.match", "IHasTriggeredAbilities");
			IHasTriggeredAbilities.NativeMethodInfoPtr_GetInstalledTriggers_Public_Abstract_Virtual_New_IEnumerable_1_ITriggeredAbility_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHasTriggeredAbilities>.NativeClassPtr, 100664845);
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x00038034 File Offset: 0x00036234
		[CallerCount(0)]
		public unsafe virtual IEnumerable<ITriggeredAbility> GetInstalledTriggers(Event evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHasTriggeredAbilities.NativeMethodInfoPtr_GetInstalledTriggers_Public_Abstract_Virtual_New_IEnumerable_1_ITriggeredAbility_Event_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ITriggeredAbility>>(intPtr3) : null;
			}
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x00004E34 File Offset: 0x00003034
		public IHasTriggeredAbilities(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000538 RID: 1336
		private static readonly IntPtr NativeMethodInfoPtr_GetInstalledTriggers_Public_Abstract_Virtual_New_IEnumerable_1_ITriggeredAbility_Event_0;
	}
}
