using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Networking.selection;

namespace dwd.core.match.selection
{
	// Token: 0x02000137 RID: 311
	public class IHintedEntitySelection : Il2CppObjectBase
	{
		// Token: 0x0600118C RID: 4492 RVA: 0x00059970 File Offset: 0x00057B70
		// Note: this type is marked as 'beforefieldinit'.
		static IHintedEntitySelection()
		{
			Il2CppClassPointerStore<IHintedEntitySelection>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.match.selection", "IHintedEntitySelection");
			IHintedEntitySelection.NativeMethodInfoPtr_HintStrength_Public_Abstract_Virtual_New_TargetStrength_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHintedEntitySelection>.NativeClassPtr, 100665867);
			IHintedEntitySelection.NativeMethodInfoPtr_HintStrengths_Public_Abstract_Virtual_New_List_1_TargetStrength_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHintedEntitySelection>.NativeClassPtr, 100665868);
			IHintedEntitySelection.NativeMethodInfoPtr_AllHintStrengths_Public_Abstract_Virtual_New_Dictionary_2_EntityID_List_1_TargetStrength_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHintedEntitySelection>.NativeClassPtr, 100665869);
		}

		// Token: 0x0600118D RID: 4493 RVA: 0x000599D4 File Offset: 0x00057BD4
		[CallerCount(0)]
		public unsafe virtual TargetStrength HintStrength(EntityID entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHintedEntitySelection.NativeMethodInfoPtr_HintStrength_Public_Abstract_Virtual_New_TargetStrength_EntityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600118E RID: 4494 RVA: 0x00059A2C File Offset: 0x00057C2C
		[CallerCount(0)]
		public unsafe virtual List<TargetStrength> HintStrengths(EntityID entityID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHintedEntitySelection.NativeMethodInfoPtr_HintStrengths_Public_Abstract_Virtual_New_List_1_TargetStrength_EntityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<TargetStrength>>(intPtr3) : null;
			}
		}

		// Token: 0x0600118F RID: 4495 RVA: 0x00059A88 File Offset: 0x00057C88
		[CallerCount(0)]
		public unsafe virtual Dictionary<EntityID, List<TargetStrength>> AllHintStrengths()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHintedEntitySelection.NativeMethodInfoPtr_AllHintStrengths_Public_Abstract_Virtual_New_Dictionary_2_EntityID_List_1_TargetStrength_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<EntityID, List<TargetStrength>>>(intPtr3) : null;
		}

		// Token: 0x06001190 RID: 4496 RVA: 0x0000814A File Offset: 0x0000634A
		public IHintedEntitySelection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C7A RID: 3194
		private static readonly IntPtr NativeMethodInfoPtr_HintStrength_Public_Abstract_Virtual_New_TargetStrength_EntityID_0;

		// Token: 0x04000C7B RID: 3195
		private static readonly IntPtr NativeMethodInfoPtr_HintStrengths_Public_Abstract_Virtual_New_List_1_TargetStrength_EntityID_0;

		// Token: 0x04000C7C RID: 3196
		private static readonly IntPtr NativeMethodInfoPtr_AllHintStrengths_Public_Abstract_Virtual_New_Dictionary_2_EntityID_List_1_TargetStrength_0;
	}
}
