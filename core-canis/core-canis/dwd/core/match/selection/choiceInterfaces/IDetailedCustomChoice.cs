using System;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Networking.selection.targetinformation;

namespace dwd.core.match.selection.choiceInterfaces
{
	// Token: 0x02000160 RID: 352
	public class IDetailedCustomChoice : Il2CppObjectBase
	{
		// Token: 0x060014B0 RID: 5296 RVA: 0x000671D0 File Offset: 0x000653D0
		// Note: this type is marked as 'beforefieldinit'.
		static IDetailedCustomChoice()
		{
			Il2CppClassPointerStore<IDetailedCustomChoice>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.match.selection.choiceInterfaces", "IDetailedCustomChoice");
			IDetailedCustomChoice.NativeMethodInfoPtr_get_ChoiceKind_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDetailedCustomChoice>.NativeClassPtr, 100666414);
			IDetailedCustomChoice.NativeMethodInfoPtr_get_Choices_Public_Abstract_Virtual_New_get_IReadOnlyList_1_SerializedEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDetailedCustomChoice>.NativeClassPtr, 100666415);
			IDetailedCustomChoice.NativeMethodInfoPtr_get_ChoicePreferences_Public_Abstract_Virtual_New_get_IReadOnlyList_1_TargetPreference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDetailedCustomChoice>.NativeClassPtr, 100666416);
			IDetailedCustomChoice.NativeMethodInfoPtr_get_SourceEntity_Public_Abstract_Virtual_New_get_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDetailedCustomChoice>.NativeClassPtr, 100666417);
		}

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x060014B1 RID: 5297 RVA: 0x00067248 File Offset: 0x00065448
		public unsafe virtual string ChoiceKind
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDetailedCustomChoice.NativeMethodInfoPtr_get_ChoiceKind_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x060014B2 RID: 5298 RVA: 0x0006728C File Offset: 0x0006548C
		public unsafe virtual IReadOnlyList<SerializedEntity> Choices
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDetailedCustomChoice.NativeMethodInfoPtr_get_Choices_Public_Abstract_Virtual_New_get_IReadOnlyList_1_SerializedEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<SerializedEntity>>(intPtr3) : null;
			}
		}

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x060014B3 RID: 5299 RVA: 0x000672D8 File Offset: 0x000654D8
		public unsafe virtual IReadOnlyList<TargetPreference> ChoicePreferences
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDetailedCustomChoice.NativeMethodInfoPtr_get_ChoicePreferences_Public_Abstract_Virtual_New_get_IReadOnlyList_1_TargetPreference_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<TargetPreference>>(intPtr3) : null;
			}
		}

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x060014B4 RID: 5300 RVA: 0x00067324 File Offset: 0x00065524
		public unsafe virtual EntityID SourceEntity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDetailedCustomChoice.NativeMethodInfoPtr_get_SourceEntity_Public_Abstract_Virtual_New_get_EntityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
			}
		}

		// Token: 0x060014B5 RID: 5301 RVA: 0x0000927A File Offset: 0x0000747A
		public IDetailedCustomChoice(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000ECD RID: 3789
		private static readonly IntPtr NativeMethodInfoPtr_get_ChoiceKind_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04000ECE RID: 3790
		private static readonly IntPtr NativeMethodInfoPtr_get_Choices_Public_Abstract_Virtual_New_get_IReadOnlyList_1_SerializedEntity_0;

		// Token: 0x04000ECF RID: 3791
		private static readonly IntPtr NativeMethodInfoPtr_get_ChoicePreferences_Public_Abstract_Virtual_New_get_IReadOnlyList_1_TargetPreference_0;

		// Token: 0x04000ED0 RID: 3792
		private static readonly IntPtr NativeMethodInfoPtr_get_SourceEntity_Public_Abstract_Virtual_New_get_EntityID_0;
	}
}
