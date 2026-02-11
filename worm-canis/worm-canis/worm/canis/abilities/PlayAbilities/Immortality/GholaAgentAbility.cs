using System;
using System.Runtime.InteropServices;
using Canis;
using Canis.actions;
using Canis.context;
using Canis.entities;
using Canis.entities.ai;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.canis.entities;

namespace worm.canis.abilities.PlayAbilities.Immortality
{
	// Token: 0x0200045B RID: 1115
	public class GholaAgentAbility : GraftAgentAbility
	{
		// Token: 0x06003103 RID: 12547 RVA: 0x001275A8 File Offset: 0x001257A8
		// Note: this type is marked as 'beforefieldinit'.
		static GholaAgentAbility()
		{
			Il2CppClassPointerStore<GholaAgentAbility>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.PlayAbilities.Immortality", "GholaAgentAbility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GholaAgentAbility>.NativeClassPtr);
			GholaAgentAbility.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GholaAgentAbility>.NativeClassPtr, "AbilityName");
			GholaAgentAbility.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GholaAgentAbility>.NativeClassPtr, "AbilityID");
			GholaAgentAbility.NativeFieldInfoPtr_NoCopyList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GholaAgentAbility>.NativeClassPtr, "NoCopyList");
			GholaAgentAbility.NativeFieldInfoPtr_NoRunList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GholaAgentAbility>.NativeClassPtr, "NoRunList");
			GholaAgentAbility.NativeFieldInfoPtr__negativeOneValueList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GholaAgentAbility>.NativeClassPtr, "_negativeOneValueList");
			GholaAgentAbility.NativeFieldInfoPtr__negativeThreeValueList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GholaAgentAbility>.NativeClassPtr, "_negativeThreeValueList");
			GholaAgentAbility.NativeFieldInfoPtr__negativeFiveValueList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GholaAgentAbility>.NativeClassPtr, "_negativeFiveValueList");
			GholaAgentAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GholaAgentAbility>.NativeClassPtr, 100678402);
			GholaAgentAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GholaAgentAbility>.NativeClassPtr, 100678403);
			GholaAgentAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GholaAgentAbility>.NativeClassPtr, 100678404);
			GholaAgentAbility.NativeMethodInfoPtr_RunImmediateEffects_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GholaAgentAbility>.NativeClassPtr, 100678405);
			GholaAgentAbility.NativeMethodInfoPtr_RemoveCopiedAbilities_Public_IEnumerable_1_Action_WormMatch_List_1_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GholaAgentAbility>.NativeClassPtr, 100678406);
			GholaAgentAbility.NativeMethodInfoPtr_Undo_Public_Virtual_Final_New_IEnumerable_1_Action_UndoNode_PlayerEntity_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GholaAgentAbility>.NativeClassPtr, 100678407);
			GholaAgentAbility.NativeMethodInfoPtr_ValueForPlayer_Public_Virtual_AIValueSummer_1_Double_WormPlayer_Il2CppReferenceArray_1_WormEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GholaAgentAbility>.NativeClassPtr, 100678408);
			GholaAgentAbility.NativeMethodInfoPtr_SpecificAcquireValue_Public_Virtual_AIValueSummer_1_Double_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GholaAgentAbility>.NativeClassPtr, 100678409);
			GholaAgentAbility.NativeMethodInfoPtr___n__0_Private_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GholaAgentAbility>.NativeClassPtr, 100678411);
		}

		// Token: 0x06003104 RID: 12548 RVA: 0x00127718 File Offset: 0x00125918
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226504, XrefRangeEnd = 226508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GholaAgentAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x06003105 RID: 12549 RVA: 0x00127764 File Offset: 0x00125964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226508, XrefRangeEnd = 226714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GholaAgentAbility(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GholaAgentAbility>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GholaAgentAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003106 RID: 12550 RVA: 0x001277B0 File Offset: 0x001259B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226714, XrefRangeEnd = 226917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GholaAgentAbility(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GholaAgentAbility>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GholaAgentAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003107 RID: 12551 RVA: 0x00127820 File Offset: 0x00125A20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226917, XrefRangeEnd = 226926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> RunImmediateEffects(WormActiveAbility activeAbility, WormMatch match, Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(activeAbility);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GholaAgentAbility.NativeMethodInfoPtr_RunImmediateEffects_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06003108 RID: 12552 RVA: 0x001278A0 File Offset: 0x00125AA0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 226934, RefRangeEnd = 226936, XrefRangeStart = 226926, XrefRangeEnd = 226934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<global::Canis.actions.Action> RemoveCopiedAbilities(WormMatch wormMatch, List<AbilityID> exceptList = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wormMatch);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(exceptList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GholaAgentAbility.NativeMethodInfoPtr_RemoveCopiedAbilities_Public_IEnumerable_1_Action_WormMatch_List_1_AbilityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06003109 RID: 12553 RVA: 0x00127904 File Offset: 0x00125B04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226936, XrefRangeEnd = 226945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerable<global::Canis.actions.Action> Undo(UndoNode node, PlayerEntity player, Match match, Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GholaAgentAbility.NativeMethodInfoPtr_Undo_Public_Virtual_Final_New_IEnumerable_1_Action_UndoNode_PlayerEntity_Match_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x0600310A RID: 12554 RVA: 0x0012798C File Offset: 0x00125B8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226945, XrefRangeEnd = 227013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AIValueSummer<double> ValueForPlayer(WormPlayer player, [Optional] Il2CppReferenceArray<WormEntity> withEntities)
		{
			if (withEntities == null)
			{
				withEntities = new Il2CppReferenceArray<WormEntity>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(withEntities);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GholaAgentAbility.NativeMethodInfoPtr_ValueForPlayer_Public_Virtual_AIValueSummer_1_Double_WormPlayer_Il2CppReferenceArray_1_WormEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIValueSummer<double>>(intPtr3) : null;
		}

		// Token: 0x0600310B RID: 12555 RVA: 0x00127A08 File Offset: 0x00125C08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227013, XrefRangeEnd = 227039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AIValueSummer<double> SpecificAcquireValue(WormPlayer player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GholaAgentAbility.NativeMethodInfoPtr_SpecificAcquireValue_Public_Virtual_AIValueSummer_1_Double_WormPlayer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIValueSummer<double>>(intPtr3) : null;
			}
		}

		// Token: 0x0600310C RID: 12556 RVA: 0x00127A64 File Offset: 0x00125C64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<global::Canis.actions.Action> __n__0(WormActiveAbility activeAbility, WormMatch match, Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(activeAbility);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GholaAgentAbility.NativeMethodInfoPtr___n__0_Private_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x0600310D RID: 12557 RVA: 0x00011376 File Offset: 0x0000F576
		public override AIValueSummer<double> ValueForPlayer(WormPlayer player, params WormEntity[] withEntities)
		{
			return this.ValueForPlayer(player, new Il2CppReferenceArray<WormEntity>(withEntities));
		}

		// Token: 0x0600310E RID: 12558 RVA: 0x00011385 File Offset: 0x0000F585
		public GholaAgentAbility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CE7 RID: 3303
		// (get) Token: 0x0600310F RID: 12559 RVA: 0x00127AD8 File Offset: 0x00125CD8
		// (set) Token: 0x06003110 RID: 12560 RVA: 0x0001138E File Offset: 0x0000F58E
		public new unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GholaAgentAbility.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GholaAgentAbility.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000CE8 RID: 3304
		// (get) Token: 0x06003111 RID: 12561 RVA: 0x00127AF8 File Offset: 0x00125CF8
		// (set) Token: 0x06003112 RID: 12562 RVA: 0x000113A0 File Offset: 0x0000F5A0
		public new unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GholaAgentAbility.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GholaAgentAbility.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CE9 RID: 3305
		// (get) Token: 0x06003113 RID: 12563 RVA: 0x00127B20 File Offset: 0x00125D20
		// (set) Token: 0x06003114 RID: 12564 RVA: 0x000113B2 File Offset: 0x0000F5B2
		public unsafe List<ArchetypeID> NoCopyList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility.NativeFieldInfoPtr_NoCopyList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ArchetypeID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility.NativeFieldInfoPtr_NoCopyList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CEA RID: 3306
		// (get) Token: 0x06003115 RID: 12565 RVA: 0x00127B50 File Offset: 0x00125D50
		// (set) Token: 0x06003116 RID: 12566 RVA: 0x000113D1 File Offset: 0x0000F5D1
		public unsafe List<ArchetypeID> NoRunList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility.NativeFieldInfoPtr_NoRunList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ArchetypeID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility.NativeFieldInfoPtr_NoRunList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CEB RID: 3307
		// (get) Token: 0x06003117 RID: 12567 RVA: 0x00127B80 File Offset: 0x00125D80
		// (set) Token: 0x06003118 RID: 12568 RVA: 0x000113F0 File Offset: 0x0000F5F0
		public unsafe List<ArchetypeID> _negativeOneValueList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility.NativeFieldInfoPtr__negativeOneValueList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ArchetypeID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility.NativeFieldInfoPtr__negativeOneValueList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CEC RID: 3308
		// (get) Token: 0x06003119 RID: 12569 RVA: 0x00127BB0 File Offset: 0x00125DB0
		// (set) Token: 0x0600311A RID: 12570 RVA: 0x0001140F File Offset: 0x0000F60F
		public unsafe List<ArchetypeID> _negativeThreeValueList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility.NativeFieldInfoPtr__negativeThreeValueList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ArchetypeID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility.NativeFieldInfoPtr__negativeThreeValueList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CED RID: 3309
		// (get) Token: 0x0600311B RID: 12571 RVA: 0x00127BE0 File Offset: 0x00125DE0
		// (set) Token: 0x0600311C RID: 12572 RVA: 0x0001142E File Offset: 0x0000F62E
		public unsafe List<ArchetypeID> _negativeFiveValueList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility.NativeFieldInfoPtr__negativeFiveValueList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ArchetypeID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility.NativeFieldInfoPtr__negativeFiveValueList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001FB6 RID: 8118
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x04001FB7 RID: 8119
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x04001FB8 RID: 8120
		private static readonly IntPtr NativeFieldInfoPtr_NoCopyList;

		// Token: 0x04001FB9 RID: 8121
		private static readonly IntPtr NativeFieldInfoPtr_NoRunList;

		// Token: 0x04001FBA RID: 8122
		private static readonly IntPtr NativeFieldInfoPtr__negativeOneValueList;

		// Token: 0x04001FBB RID: 8123
		private static readonly IntPtr NativeFieldInfoPtr__negativeThreeValueList;

		// Token: 0x04001FBC RID: 8124
		private static readonly IntPtr NativeFieldInfoPtr__negativeFiveValueList;

		// Token: 0x04001FBD RID: 8125
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x04001FBE RID: 8126
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x04001FBF RID: 8127
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x04001FC0 RID: 8128
		private static readonly IntPtr NativeMethodInfoPtr_RunImmediateEffects_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0;

		// Token: 0x04001FC1 RID: 8129
		private static readonly IntPtr NativeMethodInfoPtr_RemoveCopiedAbilities_Public_IEnumerable_1_Action_WormMatch_List_1_AbilityID_0;

		// Token: 0x04001FC2 RID: 8130
		private static readonly IntPtr NativeMethodInfoPtr_Undo_Public_Virtual_Final_New_IEnumerable_1_Action_UndoNode_PlayerEntity_Match_Context_0;

		// Token: 0x04001FC3 RID: 8131
		private static readonly IntPtr NativeMethodInfoPtr_ValueForPlayer_Public_Virtual_AIValueSummer_1_Double_WormPlayer_Il2CppReferenceArray_1_WormEntity_0;

		// Token: 0x04001FC4 RID: 8132
		private static readonly IntPtr NativeMethodInfoPtr_SpecificAcquireValue_Public_Virtual_AIValueSummer_1_Double_WormPlayer_0;

		// Token: 0x04001FC5 RID: 8133
		private static readonly IntPtr NativeMethodInfoPtr___n__0_Private_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0;

		// Token: 0x02000A9E RID: 2718
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.Immortality.GholaAgentAbility+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x0600AAD8 RID: 43736 RVA: 0x002B82A0 File Offset: 0x002B64A0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<GholaAgentAbility.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GholaAgentAbility>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GholaAgentAbility.__c>.NativeClassPtr);
				GholaAgentAbility.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GholaAgentAbility.__c>.NativeClassPtr, "<>9");
				GholaAgentAbility.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GholaAgentAbility.__c>.NativeClassPtr, "<>9__7_0");
				GholaAgentAbility.__c.NativeFieldInfoPtr___9__7_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GholaAgentAbility.__c>.NativeClassPtr, "<>9__7_2");
				GholaAgentAbility.__c.NativeFieldInfoPtr___9__13_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GholaAgentAbility.__c>.NativeClassPtr, "<>9__13_0");
				GholaAgentAbility.__c.NativeFieldInfoPtr___9__14_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GholaAgentAbility.__c>.NativeClassPtr, "<>9__14_0");
				GholaAgentAbility.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GholaAgentAbility.__c>.NativeClassPtr, 100678413);
				GholaAgentAbility.__c.NativeMethodInfoPtr__RunImmediateEffects_b__7_0_Internal_Boolean_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GholaAgentAbility.__c>.NativeClassPtr, 100678414);
				GholaAgentAbility.__c.NativeMethodInfoPtr__RunImmediateEffects_b__7_2_Internal_Boolean_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GholaAgentAbility.__c>.NativeClassPtr, 100678415);
				GholaAgentAbility.__c.NativeMethodInfoPtr__ValueForPlayer_b__13_0_Internal_Boolean_WormEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GholaAgentAbility.__c>.NativeClassPtr, 100678416);
				GholaAgentAbility.__c.NativeMethodInfoPtr__SpecificAcquireValue_b__14_0_Internal_Boolean_WormImperiumPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GholaAgentAbility.__c>.NativeClassPtr, 100678417);
			}

			// Token: 0x0600AAD9 RID: 43737 RVA: 0x002B8394 File Offset: 0x002B6594
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GholaAgentAbility.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GholaAgentAbility.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AADA RID: 43738 RVA: 0x002B83D0 File Offset: 0x002B65D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225765, XrefRangeEnd = 225776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RunImmediateEffects_b__7_0(WormAbilityDefinition ability)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ability);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GholaAgentAbility.__c.NativeMethodInfoPtr__RunImmediateEffects_b__7_0_Internal_Boolean_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600AADB RID: 43739 RVA: 0x002B8420 File Offset: 0x002B6620
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225776, XrefRangeEnd = 225777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RunImmediateEffects_b__7_2(WormAbilityDefinition ability)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ability);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GholaAgentAbility.__c.NativeMethodInfoPtr__RunImmediateEffects_b__7_2_Internal_Boolean_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600AADC RID: 43740 RVA: 0x002B8470 File Offset: 0x002B6670
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225777, XrefRangeEnd = 225778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ValueForPlayer_b__13_0(WormEntity ent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GholaAgentAbility.__c.NativeMethodInfoPtr__ValueForPlayer_b__13_0_Internal_Boolean_WormEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600AADD RID: 43741 RVA: 0x002B84C0 File Offset: 0x002B66C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225778, XrefRangeEnd = 225785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SpecificAcquireValue_b__14_0(WormImperiumPlayable card)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(card);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GholaAgentAbility.__c.NativeMethodInfoPtr__SpecificAcquireValue_b__14_0_Internal_Boolean_WormImperiumPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600AADE RID: 43742 RVA: 0x0004DADD File Offset: 0x0004BCDD
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170033FF RID: 13311
			// (get) Token: 0x0600AADF RID: 43743 RVA: 0x002B8510 File Offset: 0x002B6710
			// (set) Token: 0x0600AAE0 RID: 43744 RVA: 0x0004DAE6 File Offset: 0x0004BCE6
			public unsafe static GholaAgentAbility.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GholaAgentAbility.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GholaAgentAbility.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GholaAgentAbility.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003400 RID: 13312
			// (get) Token: 0x0600AAE1 RID: 43745 RVA: 0x002B8538 File Offset: 0x002B6738
			// (set) Token: 0x0600AAE2 RID: 43746 RVA: 0x0004DAF8 File Offset: 0x0004BCF8
			public unsafe static Func<WormAbilityDefinition, bool> __9__7_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GholaAgentAbility.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormAbilityDefinition, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GholaAgentAbility.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003401 RID: 13313
			// (get) Token: 0x0600AAE3 RID: 43747 RVA: 0x002B8560 File Offset: 0x002B6760
			// (set) Token: 0x0600AAE4 RID: 43748 RVA: 0x0004DB0A File Offset: 0x0004BD0A
			public unsafe static Func<WormAbilityDefinition, bool> __9__7_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GholaAgentAbility.__c.NativeFieldInfoPtr___9__7_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormAbilityDefinition, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GholaAgentAbility.__c.NativeFieldInfoPtr___9__7_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003402 RID: 13314
			// (get) Token: 0x0600AAE5 RID: 43749 RVA: 0x002B8588 File Offset: 0x002B6788
			// (set) Token: 0x0600AAE6 RID: 43750 RVA: 0x0004DB1C File Offset: 0x0004BD1C
			public unsafe static Func<WormEntity, bool> __9__13_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GholaAgentAbility.__c.NativeFieldInfoPtr___9__13_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormEntity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GholaAgentAbility.__c.NativeFieldInfoPtr___9__13_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003403 RID: 13315
			// (get) Token: 0x0600AAE7 RID: 43751 RVA: 0x002B85B0 File Offset: 0x002B67B0
			// (set) Token: 0x0600AAE8 RID: 43752 RVA: 0x0004DB2E File Offset: 0x0004BD2E
			public unsafe static Func<WormImperiumPlayable, bool> __9__14_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GholaAgentAbility.__c.NativeFieldInfoPtr___9__14_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormImperiumPlayable, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GholaAgentAbility.__c.NativeFieldInfoPtr___9__14_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006C08 RID: 27656
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04006C09 RID: 27657
			private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

			// Token: 0x04006C0A RID: 27658
			private static readonly IntPtr NativeFieldInfoPtr___9__7_2;

			// Token: 0x04006C0B RID: 27659
			private static readonly IntPtr NativeFieldInfoPtr___9__13_0;

			// Token: 0x04006C0C RID: 27660
			private static readonly IntPtr NativeFieldInfoPtr___9__14_0;

			// Token: 0x04006C0D RID: 27661
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006C0E RID: 27662
			private static readonly IntPtr NativeMethodInfoPtr__RunImmediateEffects_b__7_0_Internal_Boolean_WormAbilityDefinition_0;

			// Token: 0x04006C0F RID: 27663
			private static readonly IntPtr NativeMethodInfoPtr__RunImmediateEffects_b__7_2_Internal_Boolean_WormAbilityDefinition_0;

			// Token: 0x04006C10 RID: 27664
			private static readonly IntPtr NativeMethodInfoPtr__ValueForPlayer_b__13_0_Internal_Boolean_WormEntity_0;

			// Token: 0x04006C11 RID: 27665
			private static readonly IntPtr NativeMethodInfoPtr__SpecificAcquireValue_b__14_0_Internal_Boolean_WormImperiumPlayable_0;
		}

		// Token: 0x02000A9F RID: 2719
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.Immortality.GholaAgentAbility+<>c__DisplayClass7_0")]
		public new sealed class __c__DisplayClass7_0 : Object
		{
			// Token: 0x0600AAE9 RID: 43753 RVA: 0x002B85D8 File Offset: 0x002B67D8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<GholaAgentAbility.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GholaAgentAbility>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GholaAgentAbility.__c__DisplayClass7_0>.NativeClassPtr);
				GholaAgentAbility.__c__DisplayClass7_0.NativeFieldInfoPtr_da = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GholaAgentAbility.__c__DisplayClass7_0>.NativeClassPtr, "da");
				GholaAgentAbility.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GholaAgentAbility.__c__DisplayClass7_0>.NativeClassPtr, 100678418);
				GholaAgentAbility.__c__DisplayClass7_0.NativeMethodInfoPtr__RunImmediateEffects_b__1_Internal_Boolean_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GholaAgentAbility.__c__DisplayClass7_0>.NativeClassPtr, 100678419);
			}

			// Token: 0x0600AAEA RID: 43754 RVA: 0x002B8640 File Offset: 0x002B6840
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GholaAgentAbility.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GholaAgentAbility.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AAEB RID: 43755 RVA: 0x002B867C File Offset: 0x002B687C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225785, XrefRangeEnd = 225790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RunImmediateEffects_b__1(WormAbilityDefinition c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GholaAgentAbility.__c__DisplayClass7_0.NativeMethodInfoPtr__RunImmediateEffects_b__1_Internal_Boolean_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600AAEC RID: 43756 RVA: 0x0004DB40 File Offset: 0x0004BD40
			public __c__DisplayClass7_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17003404 RID: 13316
			// (get) Token: 0x0600AAED RID: 43757 RVA: 0x002B86CC File Offset: 0x002B68CC
			// (set) Token: 0x0600AAEE RID: 43758 RVA: 0x0004DB49 File Offset: 0x0004BD49
			public unsafe WormAbilityDefinition da
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility.__c__DisplayClass7_0.NativeFieldInfoPtr_da);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormAbilityDefinition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility.__c__DisplayClass7_0.NativeFieldInfoPtr_da), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006C12 RID: 27666
			private static readonly IntPtr NativeFieldInfoPtr_da;

			// Token: 0x04006C13 RID: 27667
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006C14 RID: 27668
			private static readonly IntPtr NativeMethodInfoPtr__RunImmediateEffects_b__1_Internal_Boolean_WormAbilityDefinition_0;
		}

		// Token: 0x02000AA0 RID: 2720
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.Immortality.GholaAgentAbility+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Object
		{
			// Token: 0x0600AAEF RID: 43759 RVA: 0x002B86FC File Offset: 0x002B68FC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<GholaAgentAbility.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GholaAgentAbility>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GholaAgentAbility.__c__DisplayClass8_0>.NativeClassPtr);
				GholaAgentAbility.__c__DisplayClass8_0.NativeFieldInfoPtr_abilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GholaAgentAbility.__c__DisplayClass8_0>.NativeClassPtr, "abilityID");
				GholaAgentAbility.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GholaAgentAbility.__c__DisplayClass8_0>.NativeClassPtr, 100678420);
				GholaAgentAbility.__c__DisplayClass8_0.NativeMethodInfoPtr__RemoveCopiedAbilities_b__0_Internal_Boolean_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GholaAgentAbility.__c__DisplayClass8_0>.NativeClassPtr, 100678421);
			}

			// Token: 0x0600AAF0 RID: 43760 RVA: 0x002B8764 File Offset: 0x002B6964
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GholaAgentAbility.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GholaAgentAbility.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AAF1 RID: 43761 RVA: 0x002B87A0 File Offset: 0x002B69A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225790, XrefRangeEnd = 225795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RemoveCopiedAbilities_b__0(WormAbilityDefinition a)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GholaAgentAbility.__c__DisplayClass8_0.NativeMethodInfoPtr__RemoveCopiedAbilities_b__0_Internal_Boolean_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600AAF2 RID: 43762 RVA: 0x0004DB68 File Offset: 0x0004BD68
			public __c__DisplayClass8_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17003405 RID: 13317
			// (get) Token: 0x0600AAF3 RID: 43763 RVA: 0x002B87F0 File Offset: 0x002B69F0
			// (set) Token: 0x0600AAF4 RID: 43764 RVA: 0x0004DB71 File Offset: 0x0004BD71
			public unsafe AbilityID abilityID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility.__c__DisplayClass8_0.NativeFieldInfoPtr_abilityID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility.__c__DisplayClass8_0.NativeFieldInfoPtr_abilityID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006C15 RID: 27669
			private static readonly IntPtr NativeFieldInfoPtr_abilityID;

			// Token: 0x04006C16 RID: 27670
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006C17 RID: 27671
			private static readonly IntPtr NativeMethodInfoPtr__RemoveCopiedAbilities_b__0_Internal_Boolean_WormAbilityDefinition_0;
		}

		// Token: 0x02000AA1 RID: 2721
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.Immortality.GholaAgentAbility+<RemoveCopiedAbilities>d__8")]
		public sealed class _RemoveCopiedAbilities_d__8 : Object
		{
			// Token: 0x0600AAF5 RID: 43765 RVA: 0x002B8820 File Offset: 0x002B6A20
			// Note: this type is marked as 'beforefieldinit'.
			static _RemoveCopiedAbilities_d__8()
			{
				Il2CppClassPointerStore<GholaAgentAbility._RemoveCopiedAbilities_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GholaAgentAbility>.NativeClassPtr, "<RemoveCopiedAbilities>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GholaAgentAbility._RemoveCopiedAbilities_d__8>.NativeClassPtr);
				GholaAgentAbility._RemoveCopiedAbilities_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GholaAgentAbility._RemoveCopiedAbilities_d__8>.NativeClassPtr, "<>1__state");
				GholaAgentAbility._RemoveCopiedAbilities_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GholaAgentAbility._RemoveCopiedAbilities_d__8>.NativeClassPtr, "<>2__current");
				GholaAgentAbility._RemoveCopiedAbilities_d__8.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GholaAgentAbility._RemoveCopiedAbilities_d__8>.NativeClassPtr, "<>l__initialThreadId");
				GholaAgentAbility._RemoveCopiedAbilities_d__8.NativeFieldInfoPtr_exceptList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GholaAgentAbility._RemoveCopiedAbilities_d__8>.NativeClassPtr, "exceptList");
				GholaAgentAbility._RemoveCopiedAbilities_d__8.NativeFieldInfoPtr___3__exceptList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GholaAgentAbility._RemoveCopiedAbilities_d__8>.NativeClassPtr, "<>3__exceptList");
				GholaAgentAbility._RemoveCopiedAbilities_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GholaAgentAbility._RemoveCopiedAbilities_d__8>.NativeClassPtr, "<>4__this");
				GholaAgentAbility._RemoveCopiedAbilities_d__8.NativeFieldInfoPtr_wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GholaAgentAbility._RemoveCopiedAbilities_d__8>.NativeClassPtr, "wormMatch");
				GholaAgentAbility._RemoveCopiedAbilities_d__8.NativeFieldInfoPtr___3__wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GholaAgentAbility._RemoveCopiedAbilities_d__8>.NativeClassPtr, "<>3__wormMatch");
				GholaAgentAbility._RemoveCopiedAbilities_d__8.NativeFieldInfoPtr__gholaCard_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GholaAgentAbility._RemoveCopiedAbilities_d__8>.NativeClassPtr, "<gholaCard>5__2");
				GholaAgentAbility._RemoveCopiedAbilities_d__8.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GholaAgentAbility._RemoveCopiedAbilities_d__8>.NativeClassPtr, "<>7__wrap2");
				GholaAgentAbility._RemoveCopiedAbilities_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GholaAgentAbility._RemoveCopiedAbilities_d__8>.NativeClassPtr, 100678422);
				GholaAgentAbility._RemoveCopiedAbilities_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GholaAgentAbility._RemoveCopiedAbilities_d__8>.NativeClassPtr, 100678423);
				GholaAgentAbility._RemoveCopiedAbilities_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GholaAgentAbility._RemoveCopiedAbilities_d__8>.NativeClassPtr, 100678424);
				GholaAgentAbility._RemoveCopiedAbilities_d__8.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GholaAgentAbility._RemoveCopiedAbilities_d__8>.NativeClassPtr, 100678425);
				GholaAgentAbility._RemoveCopiedAbilities_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GholaAgentAbility._RemoveCopiedAbilities_d__8>.NativeClassPtr, 100678426);
				GholaAgentAbility._RemoveCopiedAbilities_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GholaAgentAbility._RemoveCopiedAbilities_d__8>.NativeClassPtr, 100678427);
				GholaAgentAbility._RemoveCopiedAbilities_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GholaAgentAbility._RemoveCopiedAbilities_d__8>.NativeClassPtr, 100678428);
				GholaAgentAbility._RemoveCopiedAbilities_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GholaAgentAbility._RemoveCopiedAbilities_d__8>.NativeClassPtr, 100678429);
				GholaAgentAbility._RemoveCopiedAbilities_d__8.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GholaAgentAbility._RemoveCopiedAbilities_d__8>.NativeClassPtr, 100678430);
			}

			// Token: 0x0600AAF6 RID: 43766 RVA: 0x002B89C8 File Offset: 0x002B6BC8
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RemoveCopiedAbilities_d__8(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GholaAgentAbility._RemoveCopiedAbilities_d__8>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GholaAgentAbility._RemoveCopiedAbilities_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600AAF7 RID: 43767 RVA: 0x002B8A10 File Offset: 0x002B6C10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225795, XrefRangeEnd = 225800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GholaAgentAbility._RemoveCopiedAbilities_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AAF8 RID: 43768 RVA: 0x002B8A44 File Offset: 0x002B6C44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225800, XrefRangeEnd = 225945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GholaAgentAbility._RemoveCopiedAbilities_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600AAF9 RID: 43769 RVA: 0x002B8A80 File Offset: 0x002B6C80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225945, XrefRangeEnd = 225948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GholaAgentAbility._RemoveCopiedAbilities_d__8.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003410 RID: 13328
			// (get) Token: 0x0600AAFA RID: 43770 RVA: 0x002B8AB4 File Offset: 0x002B6CB4
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GholaAgentAbility._RemoveCopiedAbilities_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600AAFB RID: 43771 RVA: 0x002B8AF4 File Offset: 0x002B6CF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225948, XrefRangeEnd = 225953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GholaAgentAbility._RemoveCopiedAbilities_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003411 RID: 13329
			// (get) Token: 0x0600AAFC RID: 43772 RVA: 0x002B8B28 File Offset: 0x002B6D28
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GholaAgentAbility._RemoveCopiedAbilities_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600AAFD RID: 43773 RVA: 0x002B8B68 File Offset: 0x002B6D68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225953, XrefRangeEnd = 225963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GholaAgentAbility._RemoveCopiedAbilities_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600AAFE RID: 43774 RVA: 0x002B8BA8 File Offset: 0x002B6DA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GholaAgentAbility._RemoveCopiedAbilities_d__8.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600AAFF RID: 43775 RVA: 0x0004DB90 File Offset: 0x0004BD90
			public _RemoveCopiedAbilities_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17003406 RID: 13318
			// (get) Token: 0x0600AB00 RID: 43776 RVA: 0x002B8BE8 File Offset: 0x002B6DE8
			// (set) Token: 0x0600AB01 RID: 43777 RVA: 0x0004DB99 File Offset: 0x0004BD99
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility._RemoveCopiedAbilities_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility._RemoveCopiedAbilities_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003407 RID: 13319
			// (get) Token: 0x0600AB02 RID: 43778 RVA: 0x002B8C10 File Offset: 0x002B6E10
			// (set) Token: 0x0600AB03 RID: 43779 RVA: 0x0004DBB4 File Offset: 0x0004BDB4
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility._RemoveCopiedAbilities_d__8.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility._RemoveCopiedAbilities_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003408 RID: 13320
			// (get) Token: 0x0600AB04 RID: 43780 RVA: 0x002B8C40 File Offset: 0x002B6E40
			// (set) Token: 0x0600AB05 RID: 43781 RVA: 0x0004DBD3 File Offset: 0x0004BDD3
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility._RemoveCopiedAbilities_d__8.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility._RemoveCopiedAbilities_d__8.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17003409 RID: 13321
			// (get) Token: 0x0600AB06 RID: 43782 RVA: 0x002B8C68 File Offset: 0x002B6E68
			// (set) Token: 0x0600AB07 RID: 43783 RVA: 0x0004DBEE File Offset: 0x0004BDEE
			public unsafe List<AbilityID> exceptList
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility._RemoveCopiedAbilities_d__8.NativeFieldInfoPtr_exceptList);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AbilityID>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility._RemoveCopiedAbilities_d__8.NativeFieldInfoPtr_exceptList), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700340A RID: 13322
			// (get) Token: 0x0600AB08 RID: 43784 RVA: 0x002B8C98 File Offset: 0x002B6E98
			// (set) Token: 0x0600AB09 RID: 43785 RVA: 0x0004DC0D File Offset: 0x0004BE0D
			public unsafe List<AbilityID> __3__exceptList
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility._RemoveCopiedAbilities_d__8.NativeFieldInfoPtr___3__exceptList);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AbilityID>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility._RemoveCopiedAbilities_d__8.NativeFieldInfoPtr___3__exceptList), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700340B RID: 13323
			// (get) Token: 0x0600AB0A RID: 43786 RVA: 0x002B8CC8 File Offset: 0x002B6EC8
			// (set) Token: 0x0600AB0B RID: 43787 RVA: 0x0004DC2C File Offset: 0x0004BE2C
			public unsafe GholaAgentAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility._RemoveCopiedAbilities_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GholaAgentAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility._RemoveCopiedAbilities_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700340C RID: 13324
			// (get) Token: 0x0600AB0C RID: 43788 RVA: 0x002B8CF8 File Offset: 0x002B6EF8
			// (set) Token: 0x0600AB0D RID: 43789 RVA: 0x0004DC4B File Offset: 0x0004BE4B
			public unsafe WormMatch wormMatch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility._RemoveCopiedAbilities_d__8.NativeFieldInfoPtr_wormMatch);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility._RemoveCopiedAbilities_d__8.NativeFieldInfoPtr_wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700340D RID: 13325
			// (get) Token: 0x0600AB0E RID: 43790 RVA: 0x002B8D28 File Offset: 0x002B6F28
			// (set) Token: 0x0600AB0F RID: 43791 RVA: 0x0004DC6A File Offset: 0x0004BE6A
			public unsafe WormMatch __3__wormMatch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility._RemoveCopiedAbilities_d__8.NativeFieldInfoPtr___3__wormMatch);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility._RemoveCopiedAbilities_d__8.NativeFieldInfoPtr___3__wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700340E RID: 13326
			// (get) Token: 0x0600AB10 RID: 43792 RVA: 0x002B8D58 File Offset: 0x002B6F58
			// (set) Token: 0x0600AB11 RID: 43793 RVA: 0x0004DC89 File Offset: 0x0004BE89
			public unsafe WormImperiumPlayable _gholaCard_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility._RemoveCopiedAbilities_d__8.NativeFieldInfoPtr__gholaCard_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormImperiumPlayable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility._RemoveCopiedAbilities_d__8.NativeFieldInfoPtr__gholaCard_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700340F RID: 13327
			// (get) Token: 0x0600AB12 RID: 43794 RVA: 0x002B8D88 File Offset: 0x002B6F88
			// (set) Token: 0x0600AB13 RID: 43795 RVA: 0x0004DCA8 File Offset: 0x0004BEA8
			public List<AbilityID>.Enumerator __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility._RemoveCopiedAbilities_d__8.NativeFieldInfoPtr___7__wrap2);
					return new List<AbilityID>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<AbilityID>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility._RemoveCopiedAbilities_d__8.NativeFieldInfoPtr___7__wrap2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<AbilityID>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04006C18 RID: 27672
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04006C19 RID: 27673
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04006C1A RID: 27674
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04006C1B RID: 27675
			private static readonly IntPtr NativeFieldInfoPtr_exceptList;

			// Token: 0x04006C1C RID: 27676
			private static readonly IntPtr NativeFieldInfoPtr___3__exceptList;

			// Token: 0x04006C1D RID: 27677
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006C1E RID: 27678
			private static readonly IntPtr NativeFieldInfoPtr_wormMatch;

			// Token: 0x04006C1F RID: 27679
			private static readonly IntPtr NativeFieldInfoPtr___3__wormMatch;

			// Token: 0x04006C20 RID: 27680
			private static readonly IntPtr NativeFieldInfoPtr__gholaCard_5__2;

			// Token: 0x04006C21 RID: 27681
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x04006C22 RID: 27682
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04006C23 RID: 27683
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006C24 RID: 27684
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04006C25 RID: 27685
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04006C26 RID: 27686
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04006C27 RID: 27687
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006C28 RID: 27688
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04006C29 RID: 27689
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04006C2A RID: 27690
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000AA2 RID: 2722
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.Immortality.GholaAgentAbility+<RunImmediateEffects>d__7")]
		public sealed class _RunImmediateEffects_d__7 : Object
		{
			// Token: 0x0600AB14 RID: 43796 RVA: 0x002B8DB8 File Offset: 0x002B6FB8
			// Note: this type is marked as 'beforefieldinit'.
			static _RunImmediateEffects_d__7()
			{
				Il2CppClassPointerStore<GholaAgentAbility._RunImmediateEffects_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GholaAgentAbility>.NativeClassPtr, "<RunImmediateEffects>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GholaAgentAbility._RunImmediateEffects_d__7>.NativeClassPtr);
				GholaAgentAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GholaAgentAbility._RunImmediateEffects_d__7>.NativeClassPtr, "<>1__state");
				GholaAgentAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GholaAgentAbility._RunImmediateEffects_d__7>.NativeClassPtr, "<>2__current");
				GholaAgentAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GholaAgentAbility._RunImmediateEffects_d__7>.NativeClassPtr, "<>l__initialThreadId");
				GholaAgentAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GholaAgentAbility._RunImmediateEffects_d__7>.NativeClassPtr, "<>4__this");
				GholaAgentAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr_activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GholaAgentAbility._RunImmediateEffects_d__7>.NativeClassPtr, "activeAbility");
				GholaAgentAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___3__activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GholaAgentAbility._RunImmediateEffects_d__7>.NativeClassPtr, "<>3__activeAbility");
				GholaAgentAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GholaAgentAbility._RunImmediateEffects_d__7>.NativeClassPtr, "match");
				GholaAgentAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GholaAgentAbility._RunImmediateEffects_d__7>.NativeClassPtr, "<>3__match");
				GholaAgentAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GholaAgentAbility._RunImmediateEffects_d__7>.NativeClassPtr, "context");
				GholaAgentAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___3__context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GholaAgentAbility._RunImmediateEffects_d__7>.NativeClassPtr, "<>3__context");
				GholaAgentAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr__chosenSpace_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GholaAgentAbility._RunImmediateEffects_d__7>.NativeClassPtr, "<chosenSpace>5__2");
				GholaAgentAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr__player_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GholaAgentAbility._RunImmediateEffects_d__7>.NativeClassPtr, "<player>5__3");
				GholaAgentAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr__gholaCard_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GholaAgentAbility._RunImmediateEffects_d__7>.NativeClassPtr, "<gholaCard>5__4");
				GholaAgentAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr__graftedCard_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GholaAgentAbility._RunImmediateEffects_d__7>.NativeClassPtr, "<graftedCard>5__5");
				GholaAgentAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr__abilitesToCopy_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GholaAgentAbility._RunImmediateEffects_d__7>.NativeClassPtr, "<abilitesToCopy>5__6");
				GholaAgentAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr__addedAbilityIDs_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GholaAgentAbility._RunImmediateEffects_d__7>.NativeClassPtr, "<addedAbilityIDs>5__7");
				GholaAgentAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___7__wrap7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GholaAgentAbility._RunImmediateEffects_d__7>.NativeClassPtr, "<>7__wrap7");
				GholaAgentAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___7__wrap8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GholaAgentAbility._RunImmediateEffects_d__7>.NativeClassPtr, "<>7__wrap8");
				GholaAgentAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GholaAgentAbility._RunImmediateEffects_d__7>.NativeClassPtr, 100678431);
				GholaAgentAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GholaAgentAbility._RunImmediateEffects_d__7>.NativeClassPtr, 100678432);
				GholaAgentAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GholaAgentAbility._RunImmediateEffects_d__7>.NativeClassPtr, 100678433);
				GholaAgentAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GholaAgentAbility._RunImmediateEffects_d__7>.NativeClassPtr, 100678434);
				GholaAgentAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GholaAgentAbility._RunImmediateEffects_d__7>.NativeClassPtr, 100678435);
				GholaAgentAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr___m__Finally3_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GholaAgentAbility._RunImmediateEffects_d__7>.NativeClassPtr, 100678436);
				GholaAgentAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GholaAgentAbility._RunImmediateEffects_d__7>.NativeClassPtr, 100678437);
				GholaAgentAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GholaAgentAbility._RunImmediateEffects_d__7>.NativeClassPtr, 100678438);
				GholaAgentAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GholaAgentAbility._RunImmediateEffects_d__7>.NativeClassPtr, 100678439);
				GholaAgentAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GholaAgentAbility._RunImmediateEffects_d__7>.NativeClassPtr, 100678440);
				GholaAgentAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GholaAgentAbility._RunImmediateEffects_d__7>.NativeClassPtr, 100678441);
			}

			// Token: 0x0600AB15 RID: 43797 RVA: 0x002B9028 File Offset: 0x002B7228
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RunImmediateEffects_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GholaAgentAbility._RunImmediateEffects_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GholaAgentAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600AB16 RID: 43798 RVA: 0x002B9070 File Offset: 0x002B7270
			[CallerCount(0)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GholaAgentAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AB17 RID: 43799 RVA: 0x002B90A4 File Offset: 0x002B72A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225963, XrefRangeEnd = 226348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GholaAgentAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600AB18 RID: 43800 RVA: 0x002B90E0 File Offset: 0x002B72E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226348, XrefRangeEnd = 226351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GholaAgentAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AB19 RID: 43801 RVA: 0x002B9114 File Offset: 0x002B7314
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226351, XrefRangeEnd = 226354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GholaAgentAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AB1A RID: 43802 RVA: 0x002B9148 File Offset: 0x002B7348
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226354, XrefRangeEnd = 226357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GholaAgentAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr___m__Finally3_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003424 RID: 13348
			// (get) Token: 0x0600AB1B RID: 43803 RVA: 0x002B917C File Offset: 0x002B737C
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GholaAgentAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600AB1C RID: 43804 RVA: 0x002B91BC File Offset: 0x002B73BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226357, XrefRangeEnd = 226362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GholaAgentAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003425 RID: 13349
			// (get) Token: 0x0600AB1D RID: 43805 RVA: 0x002B91F0 File Offset: 0x002B73F0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GholaAgentAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600AB1E RID: 43806 RVA: 0x002B9230 File Offset: 0x002B7430
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226362, XrefRangeEnd = 226373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GholaAgentAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600AB1F RID: 43807 RVA: 0x002B9270 File Offset: 0x002B7470
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GholaAgentAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600AB20 RID: 43808 RVA: 0x0004DCD6 File Offset: 0x0004BED6
			public _RunImmediateEffects_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17003412 RID: 13330
			// (get) Token: 0x0600AB21 RID: 43809 RVA: 0x002B92B0 File Offset: 0x002B74B0
			// (set) Token: 0x0600AB22 RID: 43810 RVA: 0x0004DCDF File Offset: 0x0004BEDF
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003413 RID: 13331
			// (get) Token: 0x0600AB23 RID: 43811 RVA: 0x002B92D8 File Offset: 0x002B74D8
			// (set) Token: 0x0600AB24 RID: 43812 RVA: 0x0004DCFA File Offset: 0x0004BEFA
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003414 RID: 13332
			// (get) Token: 0x0600AB25 RID: 43813 RVA: 0x002B9308 File Offset: 0x002B7508
			// (set) Token: 0x0600AB26 RID: 43814 RVA: 0x0004DD19 File Offset: 0x0004BF19
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17003415 RID: 13333
			// (get) Token: 0x0600AB27 RID: 43815 RVA: 0x002B9330 File Offset: 0x002B7530
			// (set) Token: 0x0600AB28 RID: 43816 RVA: 0x0004DD34 File Offset: 0x0004BF34
			public unsafe GholaAgentAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GholaAgentAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003416 RID: 13334
			// (get) Token: 0x0600AB29 RID: 43817 RVA: 0x002B9360 File Offset: 0x002B7560
			// (set) Token: 0x0600AB2A RID: 43818 RVA: 0x0004DD53 File Offset: 0x0004BF53
			public unsafe WormActiveAbility activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr_activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr_activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003417 RID: 13335
			// (get) Token: 0x0600AB2B RID: 43819 RVA: 0x002B9390 File Offset: 0x002B7590
			// (set) Token: 0x0600AB2C RID: 43820 RVA: 0x0004DD72 File Offset: 0x0004BF72
			public unsafe WormActiveAbility __3__activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___3__activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___3__activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003418 RID: 13336
			// (get) Token: 0x0600AB2D RID: 43821 RVA: 0x002B93C0 File Offset: 0x002B75C0
			// (set) Token: 0x0600AB2E RID: 43822 RVA: 0x0004DD91 File Offset: 0x0004BF91
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003419 RID: 13337
			// (get) Token: 0x0600AB2F RID: 43823 RVA: 0x002B93F0 File Offset: 0x002B75F0
			// (set) Token: 0x0600AB30 RID: 43824 RVA: 0x0004DDB0 File Offset: 0x0004BFB0
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700341A RID: 13338
			// (get) Token: 0x0600AB31 RID: 43825 RVA: 0x002B9420 File Offset: 0x002B7620
			// (set) Token: 0x0600AB32 RID: 43826 RVA: 0x0004DDCF File Offset: 0x0004BFCF
			public unsafe Context context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700341B RID: 13339
			// (get) Token: 0x0600AB33 RID: 43827 RVA: 0x002B9450 File Offset: 0x002B7650
			// (set) Token: 0x0600AB34 RID: 43828 RVA: 0x0004DDEE File Offset: 0x0004BFEE
			public unsafe Context __3__context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___3__context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___3__context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700341C RID: 13340
			// (get) Token: 0x0600AB35 RID: 43829 RVA: 0x002B9480 File Offset: 0x002B7680
			// (set) Token: 0x0600AB36 RID: 43830 RVA: 0x0004DE0D File Offset: 0x0004C00D
			public unsafe WormSpace _chosenSpace_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr__chosenSpace_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormSpace>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr__chosenSpace_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700341D RID: 13341
			// (get) Token: 0x0600AB37 RID: 43831 RVA: 0x002B94B0 File Offset: 0x002B76B0
			// (set) Token: 0x0600AB38 RID: 43832 RVA: 0x0004DE2C File Offset: 0x0004C02C
			public unsafe WormPlayer _player_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr__player_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr__player_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700341E RID: 13342
			// (get) Token: 0x0600AB39 RID: 43833 RVA: 0x002B94E0 File Offset: 0x002B76E0
			// (set) Token: 0x0600AB3A RID: 43834 RVA: 0x0004DE4B File Offset: 0x0004C04B
			public unsafe WormImperiumPlayable _gholaCard_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr__gholaCard_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormImperiumPlayable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr__gholaCard_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700341F RID: 13343
			// (get) Token: 0x0600AB3B RID: 43835 RVA: 0x002B9510 File Offset: 0x002B7710
			// (set) Token: 0x0600AB3C RID: 43836 RVA: 0x0004DE6A File Offset: 0x0004C06A
			public unsafe WormImperiumPlayable _graftedCard_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr__graftedCard_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormImperiumPlayable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr__graftedCard_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003420 RID: 13344
			// (get) Token: 0x0600AB3D RID: 43837 RVA: 0x002B9540 File Offset: 0x002B7740
			// (set) Token: 0x0600AB3E RID: 43838 RVA: 0x0004DE89 File Offset: 0x0004C089
			public unsafe IEnumerable<WormAbilityDefinition> _abilitesToCopy_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr__abilitesToCopy_5__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<WormAbilityDefinition>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr__abilitesToCopy_5__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003421 RID: 13345
			// (get) Token: 0x0600AB3F RID: 43839 RVA: 0x002B9570 File Offset: 0x002B7770
			// (set) Token: 0x0600AB40 RID: 43840 RVA: 0x0004DEA8 File Offset: 0x0004C0A8
			public unsafe List<AbilityID> _addedAbilityIDs_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr__addedAbilityIDs_5__7);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AbilityID>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr__addedAbilityIDs_5__7), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003422 RID: 13346
			// (get) Token: 0x0600AB41 RID: 43841 RVA: 0x002B95A0 File Offset: 0x002B77A0
			// (set) Token: 0x0600AB42 RID: 43842 RVA: 0x0004DEC7 File Offset: 0x0004C0C7
			public unsafe IEnumerator<WormAbilityDefinition> __7__wrap7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___7__wrap7);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<WormAbilityDefinition>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___7__wrap7), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003423 RID: 13347
			// (get) Token: 0x0600AB43 RID: 43843 RVA: 0x002B95D0 File Offset: 0x002B77D0
			// (set) Token: 0x0600AB44 RID: 43844 RVA: 0x0004DEE6 File Offset: 0x0004C0E6
			public unsafe IEnumerator<global::Canis.actions.Action> __7__wrap8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___7__wrap8);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___7__wrap8), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006C2B RID: 27691
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04006C2C RID: 27692
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04006C2D RID: 27693
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04006C2E RID: 27694
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006C2F RID: 27695
			private static readonly IntPtr NativeFieldInfoPtr_activeAbility;

			// Token: 0x04006C30 RID: 27696
			private static readonly IntPtr NativeFieldInfoPtr___3__activeAbility;

			// Token: 0x04006C31 RID: 27697
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04006C32 RID: 27698
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x04006C33 RID: 27699
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x04006C34 RID: 27700
			private static readonly IntPtr NativeFieldInfoPtr___3__context;

			// Token: 0x04006C35 RID: 27701
			private static readonly IntPtr NativeFieldInfoPtr__chosenSpace_5__2;

			// Token: 0x04006C36 RID: 27702
			private static readonly IntPtr NativeFieldInfoPtr__player_5__3;

			// Token: 0x04006C37 RID: 27703
			private static readonly IntPtr NativeFieldInfoPtr__gholaCard_5__4;

			// Token: 0x04006C38 RID: 27704
			private static readonly IntPtr NativeFieldInfoPtr__graftedCard_5__5;

			// Token: 0x04006C39 RID: 27705
			private static readonly IntPtr NativeFieldInfoPtr__abilitesToCopy_5__6;

			// Token: 0x04006C3A RID: 27706
			private static readonly IntPtr NativeFieldInfoPtr__addedAbilityIDs_5__7;

			// Token: 0x04006C3B RID: 27707
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap7;

			// Token: 0x04006C3C RID: 27708
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap8;

			// Token: 0x04006C3D RID: 27709
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04006C3E RID: 27710
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006C3F RID: 27711
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04006C40 RID: 27712
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04006C41 RID: 27713
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x04006C42 RID: 27714
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally3_Private_Void_0;

			// Token: 0x04006C43 RID: 27715
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04006C44 RID: 27716
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006C45 RID: 27717
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04006C46 RID: 27718
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04006C47 RID: 27719
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000AA3 RID: 2723
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.Immortality.GholaAgentAbility+<Undo>d__9")]
		public sealed class _Undo_d__9 : Object
		{
			// Token: 0x0600AB45 RID: 43845 RVA: 0x002B9600 File Offset: 0x002B7800
			// Note: this type is marked as 'beforefieldinit'.
			static _Undo_d__9()
			{
				Il2CppClassPointerStore<GholaAgentAbility._Undo_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GholaAgentAbility>.NativeClassPtr, "<Undo>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GholaAgentAbility._Undo_d__9>.NativeClassPtr);
				GholaAgentAbility._Undo_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GholaAgentAbility._Undo_d__9>.NativeClassPtr, "<>1__state");
				GholaAgentAbility._Undo_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GholaAgentAbility._Undo_d__9>.NativeClassPtr, "<>2__current");
				GholaAgentAbility._Undo_d__9.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GholaAgentAbility._Undo_d__9>.NativeClassPtr, "<>l__initialThreadId");
				GholaAgentAbility._Undo_d__9.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GholaAgentAbility._Undo_d__9>.NativeClassPtr, "match");
				GholaAgentAbility._Undo_d__9.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GholaAgentAbility._Undo_d__9>.NativeClassPtr, "<>3__match");
				GholaAgentAbility._Undo_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GholaAgentAbility._Undo_d__9>.NativeClassPtr, "<>4__this");
				GholaAgentAbility._Undo_d__9.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GholaAgentAbility._Undo_d__9>.NativeClassPtr, "player");
				GholaAgentAbility._Undo_d__9.NativeFieldInfoPtr___3__player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GholaAgentAbility._Undo_d__9>.NativeClassPtr, "<>3__player");
				GholaAgentAbility._Undo_d__9.NativeFieldInfoPtr_node = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GholaAgentAbility._Undo_d__9>.NativeClassPtr, "node");
				GholaAgentAbility._Undo_d__9.NativeFieldInfoPtr___3__node = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GholaAgentAbility._Undo_d__9>.NativeClassPtr, "<>3__node");
				GholaAgentAbility._Undo_d__9.NativeFieldInfoPtr__wormMatch_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GholaAgentAbility._Undo_d__9>.NativeClassPtr, "<wormMatch>5__2");
				GholaAgentAbility._Undo_d__9.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GholaAgentAbility._Undo_d__9>.NativeClassPtr, "<>7__wrap2");
				GholaAgentAbility._Undo_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GholaAgentAbility._Undo_d__9>.NativeClassPtr, 100678442);
				GholaAgentAbility._Undo_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GholaAgentAbility._Undo_d__9>.NativeClassPtr, 100678443);
				GholaAgentAbility._Undo_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GholaAgentAbility._Undo_d__9>.NativeClassPtr, 100678444);
				GholaAgentAbility._Undo_d__9.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GholaAgentAbility._Undo_d__9>.NativeClassPtr, 100678445);
				GholaAgentAbility._Undo_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GholaAgentAbility._Undo_d__9>.NativeClassPtr, 100678446);
				GholaAgentAbility._Undo_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GholaAgentAbility._Undo_d__9>.NativeClassPtr, 100678447);
				GholaAgentAbility._Undo_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GholaAgentAbility._Undo_d__9>.NativeClassPtr, 100678448);
				GholaAgentAbility._Undo_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GholaAgentAbility._Undo_d__9>.NativeClassPtr, 100678449);
				GholaAgentAbility._Undo_d__9.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GholaAgentAbility._Undo_d__9>.NativeClassPtr, 100678450);
			}

			// Token: 0x0600AB46 RID: 43846 RVA: 0x002B97D0 File Offset: 0x002B79D0
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Undo_d__9(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GholaAgentAbility._Undo_d__9>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GholaAgentAbility._Undo_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600AB47 RID: 43847 RVA: 0x002B9818 File Offset: 0x002B7A18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226373, XrefRangeEnd = 226378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GholaAgentAbility._Undo_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AB48 RID: 43848 RVA: 0x002B984C File Offset: 0x002B7A4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226378, XrefRangeEnd = 226485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GholaAgentAbility._Undo_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600AB49 RID: 43849 RVA: 0x002B9888 File Offset: 0x002B7A88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226485, XrefRangeEnd = 226488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GholaAgentAbility._Undo_d__9.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003432 RID: 13362
			// (get) Token: 0x0600AB4A RID: 43850 RVA: 0x002B98BC File Offset: 0x002B7ABC
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GholaAgentAbility._Undo_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600AB4B RID: 43851 RVA: 0x002B98FC File Offset: 0x002B7AFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226488, XrefRangeEnd = 226493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GholaAgentAbility._Undo_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003433 RID: 13363
			// (get) Token: 0x0600AB4C RID: 43852 RVA: 0x002B9930 File Offset: 0x002B7B30
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GholaAgentAbility._Undo_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600AB4D RID: 43853 RVA: 0x002B9970 File Offset: 0x002B7B70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226493, XrefRangeEnd = 226504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GholaAgentAbility._Undo_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600AB4E RID: 43854 RVA: 0x002B99B0 File Offset: 0x002B7BB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GholaAgentAbility._Undo_d__9.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600AB4F RID: 43855 RVA: 0x0004DF05 File Offset: 0x0004C105
			public _Undo_d__9(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17003426 RID: 13350
			// (get) Token: 0x0600AB50 RID: 43856 RVA: 0x002B99F0 File Offset: 0x002B7BF0
			// (set) Token: 0x0600AB51 RID: 43857 RVA: 0x0004DF0E File Offset: 0x0004C10E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility._Undo_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility._Undo_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003427 RID: 13351
			// (get) Token: 0x0600AB52 RID: 43858 RVA: 0x002B9A18 File Offset: 0x002B7C18
			// (set) Token: 0x0600AB53 RID: 43859 RVA: 0x0004DF29 File Offset: 0x0004C129
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility._Undo_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility._Undo_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003428 RID: 13352
			// (get) Token: 0x0600AB54 RID: 43860 RVA: 0x002B9A48 File Offset: 0x002B7C48
			// (set) Token: 0x0600AB55 RID: 43861 RVA: 0x0004DF48 File Offset: 0x0004C148
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility._Undo_d__9.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility._Undo_d__9.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17003429 RID: 13353
			// (get) Token: 0x0600AB56 RID: 43862 RVA: 0x002B9A70 File Offset: 0x002B7C70
			// (set) Token: 0x0600AB57 RID: 43863 RVA: 0x0004DF63 File Offset: 0x0004C163
			public unsafe Match match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility._Undo_d__9.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility._Undo_d__9.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700342A RID: 13354
			// (get) Token: 0x0600AB58 RID: 43864 RVA: 0x002B9AA0 File Offset: 0x002B7CA0
			// (set) Token: 0x0600AB59 RID: 43865 RVA: 0x0004DF82 File Offset: 0x0004C182
			public unsafe Match __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility._Undo_d__9.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility._Undo_d__9.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700342B RID: 13355
			// (get) Token: 0x0600AB5A RID: 43866 RVA: 0x002B9AD0 File Offset: 0x002B7CD0
			// (set) Token: 0x0600AB5B RID: 43867 RVA: 0x0004DFA1 File Offset: 0x0004C1A1
			public unsafe GholaAgentAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility._Undo_d__9.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GholaAgentAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility._Undo_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700342C RID: 13356
			// (get) Token: 0x0600AB5C RID: 43868 RVA: 0x002B9B00 File Offset: 0x002B7D00
			// (set) Token: 0x0600AB5D RID: 43869 RVA: 0x0004DFC0 File Offset: 0x0004C1C0
			public unsafe PlayerEntity player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility._Undo_d__9.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility._Undo_d__9.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700342D RID: 13357
			// (get) Token: 0x0600AB5E RID: 43870 RVA: 0x002B9B30 File Offset: 0x002B7D30
			// (set) Token: 0x0600AB5F RID: 43871 RVA: 0x0004DFDF File Offset: 0x0004C1DF
			public unsafe PlayerEntity __3__player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility._Undo_d__9.NativeFieldInfoPtr___3__player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility._Undo_d__9.NativeFieldInfoPtr___3__player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700342E RID: 13358
			// (get) Token: 0x0600AB60 RID: 43872 RVA: 0x002B9B60 File Offset: 0x002B7D60
			// (set) Token: 0x0600AB61 RID: 43873 RVA: 0x0004DFFE File Offset: 0x0004C1FE
			public unsafe UndoNode node
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility._Undo_d__9.NativeFieldInfoPtr_node);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UndoNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility._Undo_d__9.NativeFieldInfoPtr_node), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700342F RID: 13359
			// (get) Token: 0x0600AB62 RID: 43874 RVA: 0x002B9B90 File Offset: 0x002B7D90
			// (set) Token: 0x0600AB63 RID: 43875 RVA: 0x0004E01D File Offset: 0x0004C21D
			public unsafe UndoNode __3__node
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility._Undo_d__9.NativeFieldInfoPtr___3__node);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UndoNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility._Undo_d__9.NativeFieldInfoPtr___3__node), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003430 RID: 13360
			// (get) Token: 0x0600AB64 RID: 43876 RVA: 0x002B9BC0 File Offset: 0x002B7DC0
			// (set) Token: 0x0600AB65 RID: 43877 RVA: 0x0004E03C File Offset: 0x0004C23C
			public unsafe WormMatch _wormMatch_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility._Undo_d__9.NativeFieldInfoPtr__wormMatch_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility._Undo_d__9.NativeFieldInfoPtr__wormMatch_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003431 RID: 13361
			// (get) Token: 0x0600AB66 RID: 43878 RVA: 0x002B9BF0 File Offset: 0x002B7DF0
			// (set) Token: 0x0600AB67 RID: 43879 RVA: 0x0004E05B File Offset: 0x0004C25B
			public unsafe IEnumerator<global::Canis.actions.Action> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility._Undo_d__9.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GholaAgentAbility._Undo_d__9.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006C48 RID: 27720
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04006C49 RID: 27721
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04006C4A RID: 27722
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04006C4B RID: 27723
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04006C4C RID: 27724
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x04006C4D RID: 27725
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006C4E RID: 27726
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04006C4F RID: 27727
			private static readonly IntPtr NativeFieldInfoPtr___3__player;

			// Token: 0x04006C50 RID: 27728
			private static readonly IntPtr NativeFieldInfoPtr_node;

			// Token: 0x04006C51 RID: 27729
			private static readonly IntPtr NativeFieldInfoPtr___3__node;

			// Token: 0x04006C52 RID: 27730
			private static readonly IntPtr NativeFieldInfoPtr__wormMatch_5__2;

			// Token: 0x04006C53 RID: 27731
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x04006C54 RID: 27732
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04006C55 RID: 27733
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006C56 RID: 27734
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04006C57 RID: 27735
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04006C58 RID: 27736
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04006C59 RID: 27737
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006C5A RID: 27738
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04006C5B RID: 27739
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04006C5C RID: 27740
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
