using System;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.match.selection
{
	// Token: 0x02000134 RID: 308
	public class IDetailedRevealChoice : Il2CppObjectBase
	{
		// Token: 0x0600117A RID: 4474 RVA: 0x000594A8 File Offset: 0x000576A8
		// Note: this type is marked as 'beforefieldinit'.
		static IDetailedRevealChoice()
		{
			Il2CppClassPointerStore<IDetailedRevealChoice>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.match.selection", "IDetailedRevealChoice");
			IDetailedRevealChoice.NativeMethodInfoPtr_get_RevealedEntities_Public_Abstract_Virtual_New_get_IList_1_SerializedEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDetailedRevealChoice>.NativeClassPtr, 100665855);
			IDetailedRevealChoice.NativeMethodInfoPtr_get_ValidTargetCounts_Public_Abstract_Virtual_New_get_IDictionary_2_EntityID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDetailedRevealChoice>.NativeClassPtr, 100665856);
			IDetailedRevealChoice.NativeMethodInfoPtr_get_RevealedEntitiesByID_Public_Abstract_Virtual_New_get_IDictionary_2_EntityID_SerializedEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDetailedRevealChoice>.NativeClassPtr, 100665857);
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x0600117B RID: 4475 RVA: 0x0005950C File Offset: 0x0005770C
		public unsafe virtual IList<SerializedEntity> RevealedEntities
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDetailedRevealChoice.NativeMethodInfoPtr_get_RevealedEntities_Public_Abstract_Virtual_New_get_IList_1_SerializedEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<SerializedEntity>>(intPtr3) : null;
			}
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x0600117C RID: 4476 RVA: 0x00059558 File Offset: 0x00057758
		public unsafe virtual IDictionary<EntityID, int> ValidTargetCounts
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDetailedRevealChoice.NativeMethodInfoPtr_get_ValidTargetCounts_Public_Abstract_Virtual_New_get_IDictionary_2_EntityID_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary<EntityID, int>>(intPtr3) : null;
			}
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x0600117D RID: 4477 RVA: 0x000595A4 File Offset: 0x000577A4
		public unsafe virtual IDictionary<EntityID, SerializedEntity> RevealedEntitiesByID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDetailedRevealChoice.NativeMethodInfoPtr_get_RevealedEntitiesByID_Public_Abstract_Virtual_New_get_IDictionary_2_EntityID_SerializedEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary<EntityID, SerializedEntity>>(intPtr3) : null;
			}
		}

		// Token: 0x0600117E RID: 4478 RVA: 0x00008100 File Offset: 0x00006300
		public IDetailedRevealChoice(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C6E RID: 3182
		private static readonly IntPtr NativeMethodInfoPtr_get_RevealedEntities_Public_Abstract_Virtual_New_get_IList_1_SerializedEntity_0;

		// Token: 0x04000C6F RID: 3183
		private static readonly IntPtr NativeMethodInfoPtr_get_ValidTargetCounts_Public_Abstract_Virtual_New_get_IDictionary_2_EntityID_Int32_0;

		// Token: 0x04000C70 RID: 3184
		private static readonly IntPtr NativeMethodInfoPtr_get_RevealedEntitiesByID_Public_Abstract_Virtual_New_get_IDictionary_2_EntityID_SerializedEntity_0;
	}
}
