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
	// Token: 0x02000132 RID: 306
	public class IArchetypeCustomChoice : Il2CppObjectBase
	{
		// Token: 0x06001173 RID: 4467 RVA: 0x00059374 File Offset: 0x00057574
		// Note: this type is marked as 'beforefieldinit'.
		static IArchetypeCustomChoice()
		{
			Il2CppClassPointerStore<IArchetypeCustomChoice>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.match.selection", "IArchetypeCustomChoice");
			IArchetypeCustomChoice.NativeMethodInfoPtr_get_SourceEntity_Public_Abstract_Virtual_New_get_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IArchetypeCustomChoice>.NativeClassPtr, 100665852);
			IArchetypeCustomChoice.NativeMethodInfoPtr_get_Buttons_Public_Abstract_Virtual_New_get_IReadOnlyList_1_ReadOnlyAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IArchetypeCustomChoice>.NativeClassPtr, 100665853);
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06001174 RID: 4468 RVA: 0x000593C4 File Offset: 0x000575C4
		public unsafe virtual EntityID SourceEntity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IArchetypeCustomChoice.NativeMethodInfoPtr_get_SourceEntity_Public_Abstract_Virtual_New_get_EntityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
			}
		}

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x06001175 RID: 4469 RVA: 0x00059410 File Offset: 0x00057610
		public unsafe virtual IReadOnlyList<ReadOnlyAttributes> Buttons
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IArchetypeCustomChoice.NativeMethodInfoPtr_get_Buttons_Public_Abstract_Virtual_New_get_IReadOnlyList_1_ReadOnlyAttributes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<ReadOnlyAttributes>>(intPtr3) : null;
			}
		}

		// Token: 0x06001176 RID: 4470 RVA: 0x000080BF File Offset: 0x000062BF
		public IArchetypeCustomChoice(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C6B RID: 3179
		private static readonly IntPtr NativeMethodInfoPtr_get_SourceEntity_Public_Abstract_Virtual_New_get_EntityID_0;

		// Token: 0x04000C6C RID: 3180
		private static readonly IntPtr NativeMethodInfoPtr_get_Buttons_Public_Abstract_Virtual_New_get_IReadOnlyList_1_ReadOnlyAttributes_0;
	}
}
