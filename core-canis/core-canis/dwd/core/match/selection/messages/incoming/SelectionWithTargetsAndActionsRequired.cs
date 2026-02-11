using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Networking.selection.messages;
using Networking.selection.targetinformation;

namespace dwd.core.match.selection.messages.incoming
{
	// Token: 0x0200015E RID: 350
	public class SelectionWithTargetsAndActionsRequired : SelectionMessage
	{
		// Token: 0x06001492 RID: 5266 RVA: 0x00066CC4 File Offset: 0x00064EC4
		// Note: this type is marked as 'beforefieldinit'.
		static SelectionWithTargetsAndActionsRequired()
		{
			Il2CppClassPointerStore<SelectionWithTargetsAndActionsRequired>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.match.selection.messages.incoming", "SelectionWithTargetsAndActionsRequired");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectionWithTargetsAndActionsRequired>.NativeClassPtr);
			SelectionWithTargetsAndActionsRequired.NativeFieldInfoPtr_TargetMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionWithTargetsAndActionsRequired>.NativeClassPtr, "TargetMap");
			SelectionWithTargetsAndActionsRequired.NativeFieldInfoPtr_TargetPreferences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionWithTargetsAndActionsRequired>.NativeClassPtr, "TargetPreferences");
			SelectionWithTargetsAndActionsRequired.NativeFieldInfoPtr_forced = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionWithTargetsAndActionsRequired>.NativeClassPtr, "forced");
			SelectionWithTargetsAndActionsRequired.NativeFieldInfoPtr_TargetType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionWithTargetsAndActionsRequired>.NativeClassPtr, "TargetType");
			SelectionWithTargetsAndActionsRequired.NativeFieldInfoPtr_SelectionParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionWithTargetsAndActionsRequired>.NativeClassPtr, "SelectionParams");
			SelectionWithTargetsAndActionsRequired.NativeFieldInfoPtr__abilityMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionWithTargetsAndActionsRequired>.NativeClassPtr, "_abilityMap");
			SelectionWithTargetsAndActionsRequired.NativeFieldInfoPtr__abilityTargetMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionWithTargetsAndActionsRequired>.NativeClassPtr, "_abilityTargetMap");
			SelectionWithTargetsAndActionsRequired.NativeMethodInfoPtr_get_Params_Public_Virtual_Final_New_get_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionWithTargetsAndActionsRequired>.NativeClassPtr, 100666407);
			SelectionWithTargetsAndActionsRequired.NativeMethodInfoPtr_get_abilityMap_Public_get_Dictionary_2_EntityID_List_1_SelectableAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionWithTargetsAndActionsRequired>.NativeClassPtr, 100666408);
			SelectionWithTargetsAndActionsRequired.NativeMethodInfoPtr_get_abilityTargetMap_Public_get_Dictionary_2_EntityID_Dictionary_2_SelectableAction_Il2CppReferenceArray_1_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionWithTargetsAndActionsRequired>.NativeClassPtr, 100666409);
			SelectionWithTargetsAndActionsRequired.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionWithTargetsAndActionsRequired>.NativeClassPtr, 100666410);
		}

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x06001493 RID: 5267 RVA: 0x00066DD0 File Offset: 0x00064FD0
		public unsafe virtual Dictionary<string, Object> Params
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionWithTargetsAndActionsRequired.NativeMethodInfoPtr_get_Params_Public_Virtual_Final_New_get_Dictionary_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Object>>(intPtr3) : null;
			}
		}

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x06001494 RID: 5268 RVA: 0x00066E10 File Offset: 0x00065010
		public unsafe Dictionary<EntityID, List<SelectableAction>> abilityMap
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 874982, XrefRangeEnd = 875008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionWithTargetsAndActionsRequired.NativeMethodInfoPtr_get_abilityMap_Public_get_Dictionary_2_EntityID_List_1_SelectableAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<EntityID, List<SelectableAction>>>(intPtr3) : null;
			}
		}

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x06001495 RID: 5269 RVA: 0x00066E50 File Offset: 0x00065050
		public unsafe Dictionary<EntityID, Dictionary<SelectableAction, Il2CppReferenceArray<TargetInformation>>> abilityTargetMap
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 875034, RefRangeEnd = 875035, XrefRangeStart = 875008, XrefRangeEnd = 875034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionWithTargetsAndActionsRequired.NativeMethodInfoPtr_get_abilityTargetMap_Public_get_Dictionary_2_EntityID_Dictionary_2_SelectableAction_Il2CppReferenceArray_1_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<EntityID, Dictionary<SelectableAction, Il2CppReferenceArray<TargetInformation>>>>(intPtr3) : null;
			}
		}

		// Token: 0x06001496 RID: 5270 RVA: 0x00066E90 File Offset: 0x00065090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 875035, XrefRangeEnd = 875040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectionWithTargetsAndActionsRequired()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectionWithTargetsAndActionsRequired>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionWithTargetsAndActionsRequired.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001497 RID: 5271 RVA: 0x0000913A File Offset: 0x0000733A
		public SelectionWithTargetsAndActionsRequired(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x06001498 RID: 5272 RVA: 0x00066ECC File Offset: 0x000650CC
		// (set) Token: 0x06001499 RID: 5273 RVA: 0x00009143 File Offset: 0x00007343
		public unsafe Il2CppReferenceArray<SelectionWithTargetsAndActionsRequired.TargetsAndActions> TargetMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionWithTargetsAndActionsRequired.NativeFieldInfoPtr_TargetMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SelectionWithTargetsAndActionsRequired.TargetsAndActions>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionWithTargetsAndActionsRequired.NativeFieldInfoPtr_TargetMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x0600149A RID: 5274 RVA: 0x00066EFC File Offset: 0x000650FC
		// (set) Token: 0x0600149B RID: 5275 RVA: 0x00009162 File Offset: 0x00007362
		public unsafe Il2CppReferenceArray<Tuple<EntityID, TargetPreference>> TargetPreferences
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionWithTargetsAndActionsRequired.NativeFieldInfoPtr_TargetPreferences);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Tuple<EntityID, TargetPreference>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionWithTargetsAndActionsRequired.NativeFieldInfoPtr_TargetPreferences), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x0600149C RID: 5276 RVA: 0x00066F2C File Offset: 0x0006512C
		// (set) Token: 0x0600149D RID: 5277 RVA: 0x00009181 File Offset: 0x00007381
		public unsafe bool forced
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionWithTargetsAndActionsRequired.NativeFieldInfoPtr_forced);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionWithTargetsAndActionsRequired.NativeFieldInfoPtr_forced)) = value;
			}
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x0600149E RID: 5278 RVA: 0x00066F54 File Offset: 0x00065154
		// (set) Token: 0x0600149F RID: 5279 RVA: 0x0000919C File Offset: 0x0000739C
		public unsafe string TargetType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionWithTargetsAndActionsRequired.NativeFieldInfoPtr_TargetType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionWithTargetsAndActionsRequired.NativeFieldInfoPtr_TargetType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x060014A0 RID: 5280 RVA: 0x00066F7C File Offset: 0x0006517C
		// (set) Token: 0x060014A1 RID: 5281 RVA: 0x000091BB File Offset: 0x000073BB
		public unsafe Dictionary<string, Object> SelectionParams
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionWithTargetsAndActionsRequired.NativeFieldInfoPtr_SelectionParams);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionWithTargetsAndActionsRequired.NativeFieldInfoPtr_SelectionParams), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x060014A2 RID: 5282 RVA: 0x00066FAC File Offset: 0x000651AC
		// (set) Token: 0x060014A3 RID: 5283 RVA: 0x000091DA File Offset: 0x000073DA
		public unsafe Dictionary<EntityID, List<SelectableAction>> _abilityMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionWithTargetsAndActionsRequired.NativeFieldInfoPtr__abilityMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<EntityID, List<SelectableAction>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionWithTargetsAndActionsRequired.NativeFieldInfoPtr__abilityMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x060014A4 RID: 5284 RVA: 0x00066FDC File Offset: 0x000651DC
		// (set) Token: 0x060014A5 RID: 5285 RVA: 0x000091F9 File Offset: 0x000073F9
		public unsafe Dictionary<EntityID, Dictionary<SelectableAction, Il2CppReferenceArray<TargetInformation>>> _abilityTargetMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionWithTargetsAndActionsRequired.NativeFieldInfoPtr__abilityTargetMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<EntityID, Dictionary<SelectableAction, Il2CppReferenceArray<TargetInformation>>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionWithTargetsAndActionsRequired.NativeFieldInfoPtr__abilityTargetMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000EBD RID: 3773
		private static readonly IntPtr NativeFieldInfoPtr_TargetMap;

		// Token: 0x04000EBE RID: 3774
		private static readonly IntPtr NativeFieldInfoPtr_TargetPreferences;

		// Token: 0x04000EBF RID: 3775
		private static readonly IntPtr NativeFieldInfoPtr_forced;

		// Token: 0x04000EC0 RID: 3776
		private static readonly IntPtr NativeFieldInfoPtr_TargetType;

		// Token: 0x04000EC1 RID: 3777
		private static readonly IntPtr NativeFieldInfoPtr_SelectionParams;

		// Token: 0x04000EC2 RID: 3778
		private static readonly IntPtr NativeFieldInfoPtr__abilityMap;

		// Token: 0x04000EC3 RID: 3779
		private static readonly IntPtr NativeFieldInfoPtr__abilityTargetMap;

		// Token: 0x04000EC4 RID: 3780
		private static readonly IntPtr NativeMethodInfoPtr_get_Params_Public_Virtual_Final_New_get_Dictionary_2_String_Object_0;

		// Token: 0x04000EC5 RID: 3781
		private static readonly IntPtr NativeMethodInfoPtr_get_abilityMap_Public_get_Dictionary_2_EntityID_List_1_SelectableAction_0;

		// Token: 0x04000EC6 RID: 3782
		private static readonly IntPtr NativeMethodInfoPtr_get_abilityTargetMap_Public_get_Dictionary_2_EntityID_Dictionary_2_SelectableAction_Il2CppReferenceArray_1_TargetInformation_0;

		// Token: 0x04000EC7 RID: 3783
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002E3 RID: 739
		public class TargetsAndActions : Object
		{
			// Token: 0x06002232 RID: 8754 RVA: 0x00098140 File Offset: 0x00096340
			// Note: this type is marked as 'beforefieldinit'.
			static TargetsAndActions()
			{
				Il2CppClassPointerStore<SelectionWithTargetsAndActionsRequired.TargetsAndActions>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SelectionWithTargetsAndActionsRequired>.NativeClassPtr, "TargetsAndActions");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectionWithTargetsAndActionsRequired.TargetsAndActions>.NativeClassPtr);
				SelectionWithTargetsAndActionsRequired.TargetsAndActions.NativeFieldInfoPtr_EntityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionWithTargetsAndActionsRequired.TargetsAndActions>.NativeClassPtr, "EntityID");
				SelectionWithTargetsAndActionsRequired.TargetsAndActions.NativeFieldInfoPtr_SelectableAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionWithTargetsAndActionsRequired.TargetsAndActions>.NativeClassPtr, "SelectableAction");
				SelectionWithTargetsAndActionsRequired.TargetsAndActions.NativeFieldInfoPtr_TargetInfoList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionWithTargetsAndActionsRequired.TargetsAndActions>.NativeClassPtr, "TargetInfoList");
				SelectionWithTargetsAndActionsRequired.TargetsAndActions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionWithTargetsAndActionsRequired.TargetsAndActions>.NativeClassPtr, 100666411);
			}

			// Token: 0x06002233 RID: 8755 RVA: 0x000981BC File Offset: 0x000963BC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TargetsAndActions()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectionWithTargetsAndActionsRequired.TargetsAndActions>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionWithTargetsAndActionsRequired.TargetsAndActions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002234 RID: 8756 RVA: 0x0000EA80 File Offset: 0x0000CC80
			public TargetsAndActions(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000955 RID: 2389
			// (get) Token: 0x06002235 RID: 8757 RVA: 0x000981F8 File Offset: 0x000963F8
			// (set) Token: 0x06002236 RID: 8758 RVA: 0x0000EA89 File Offset: 0x0000CC89
			public unsafe EntityID EntityID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionWithTargetsAndActionsRequired.TargetsAndActions.NativeFieldInfoPtr_EntityID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionWithTargetsAndActionsRequired.TargetsAndActions.NativeFieldInfoPtr_EntityID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000956 RID: 2390
			// (get) Token: 0x06002237 RID: 8759 RVA: 0x00098228 File Offset: 0x00096428
			// (set) Token: 0x06002238 RID: 8760 RVA: 0x0000EAA8 File Offset: 0x0000CCA8
			public unsafe SelectableAction SelectableAction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionWithTargetsAndActionsRequired.TargetsAndActions.NativeFieldInfoPtr_SelectableAction);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SelectableAction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionWithTargetsAndActionsRequired.TargetsAndActions.NativeFieldInfoPtr_SelectableAction), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000957 RID: 2391
			// (get) Token: 0x06002239 RID: 8761 RVA: 0x00098258 File Offset: 0x00096458
			// (set) Token: 0x0600223A RID: 8762 RVA: 0x0000EAC7 File Offset: 0x0000CCC7
			public unsafe Il2CppReferenceArray<TargetInformation> TargetInfoList
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionWithTargetsAndActionsRequired.TargetsAndActions.NativeFieldInfoPtr_TargetInfoList);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TargetInformation>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionWithTargetsAndActionsRequired.TargetsAndActions.NativeFieldInfoPtr_TargetInfoList), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040017AA RID: 6058
			private static readonly IntPtr NativeFieldInfoPtr_EntityID;

			// Token: 0x040017AB RID: 6059
			private static readonly IntPtr NativeFieldInfoPtr_SelectableAction;

			// Token: 0x040017AC RID: 6060
			private static readonly IntPtr NativeFieldInfoPtr_TargetInfoList;

			// Token: 0x040017AD RID: 6061
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
