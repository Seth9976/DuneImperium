using System;
using Canis.attributes;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.match.selection
{
	// Token: 0x0200013C RID: 316
	public class IRevealChoice : Il2CppObjectBase
	{
		// Token: 0x060011A3 RID: 4515 RVA: 0x00059EDC File Offset: 0x000580DC
		// Note: this type is marked as 'beforefieldinit'.
		static IRevealChoice()
		{
			Il2CppClassPointerStore<IRevealChoice>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.match.selection", "IRevealChoice");
			IRevealChoice.NativeMethodInfoPtr_get_RevealedEntities_Public_Abstract_Virtual_New_get_IDictionary_2_EntityID_ReadOnlyAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRevealChoice>.NativeClassPtr, 100665880);
			IRevealChoice.NativeMethodInfoPtr_get_AllTargets_Public_Abstract_Virtual_New_get_IList_1_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRevealChoice>.NativeClassPtr, 100665881);
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x060011A4 RID: 4516 RVA: 0x00059F2C File Offset: 0x0005812C
		public unsafe virtual IDictionary<EntityID, ReadOnlyAttributes> RevealedEntities
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRevealChoice.NativeMethodInfoPtr_get_RevealedEntities_Public_Abstract_Virtual_New_get_IDictionary_2_EntityID_ReadOnlyAttributes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary<EntityID, ReadOnlyAttributes>>(intPtr3) : null;
			}
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x060011A5 RID: 4517 RVA: 0x00059F78 File Offset: 0x00058178
		public unsafe virtual IList<EntityID> AllTargets
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRevealChoice.NativeMethodInfoPtr_get_AllTargets_Public_Abstract_Virtual_New_get_IList_1_EntityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<EntityID>>(intPtr3) : null;
			}
		}

		// Token: 0x060011A6 RID: 4518 RVA: 0x000081A6 File Offset: 0x000063A6
		public IRevealChoice(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C87 RID: 3207
		private static readonly IntPtr NativeMethodInfoPtr_get_RevealedEntities_Public_Abstract_Virtual_New_get_IDictionary_2_EntityID_ReadOnlyAttributes_0;

		// Token: 0x04000C88 RID: 3208
		private static readonly IntPtr NativeMethodInfoPtr_get_AllTargets_Public_Abstract_Virtual_New_get_IList_1_EntityID_0;
	}
}
