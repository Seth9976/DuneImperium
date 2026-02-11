using System;
using System.Runtime.InteropServices;
using Canis;
using Canis.actions;
using Canis.context;
using Canis.entities;
using Canis.entities.ai;
using Canis.messages;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using lib.canis.data.enums;
using worm.canis.entities;

namespace worm.canis.abilities.ActivatedAbilities.Immortality
{
	// Token: 0x02000508 RID: 1288
	public class GainImmortalityIntrigueAbility : DeferredAbility
	{
		// Token: 0x06003BA9 RID: 15273 RVA: 0x0015E35C File Offset: 0x0015C55C
		// Note: this type is marked as 'beforefieldinit'.
		static GainImmortalityIntrigueAbility()
		{
			Il2CppClassPointerStore<GainImmortalityIntrigueAbility>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.ActivatedAbilities.Immortality", "GainImmortalityIntrigueAbility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GainImmortalityIntrigueAbility>.NativeClassPtr);
			GainImmortalityIntrigueAbility.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainImmortalityIntrigueAbility>.NativeClassPtr, "AbilityName");
			GainImmortalityIntrigueAbility.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainImmortalityIntrigueAbility>.NativeClassPtr, 100682754);
			GainImmortalityIntrigueAbility.NativeMethodInfoPtr_SelectionMode_Public_Virtual_DeferredSelectionMode_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainImmortalityIntrigueAbility>.NativeClassPtr, 100682755);
			GainImmortalityIntrigueAbility.NativeMethodInfoPtr_CanRunImmediately_Public_Virtual_Boolean_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainImmortalityIntrigueAbility>.NativeClassPtr, 100682756);
			GainImmortalityIntrigueAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainImmortalityIntrigueAbility>.NativeClassPtr, 100682757);
			GainImmortalityIntrigueAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainImmortalityIntrigueAbility>.NativeClassPtr, 100682758);
			GainImmortalityIntrigueAbility.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainImmortalityIntrigueAbility>.NativeClassPtr, 100682759);
			GainImmortalityIntrigueAbility.NativeMethodInfoPtr_ResumeExecution_Public_Virtual_Int32_WormActiveAbility_Action_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainImmortalityIntrigueAbility>.NativeClassPtr, 100682760);
			GainImmortalityIntrigueAbility.NativeMethodInfoPtr_ValueForPlayer_Public_Virtual_AIValueSummer_1_Double_WormPlayer_Il2CppReferenceArray_1_WormEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainImmortalityIntrigueAbility>.NativeClassPtr, 100682761);
		}

		// Token: 0x06003BAA RID: 15274 RVA: 0x0015E440 File Offset: 0x0015C640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264953, XrefRangeEnd = 264957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override CostAction Cost(Match match, Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GainImmortalityIntrigueAbility.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CostAction>(intPtr3) : null;
		}

		// Token: 0x06003BAB RID: 15275 RVA: 0x0015E4B0 File Offset: 0x0015C6B0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 25008, RefRangeEnd = 25013, XrefRangeStart = 25008, XrefRangeEnd = 25013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DeferredSelectionMode SelectionMode(Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GainImmortalityIntrigueAbility.NativeMethodInfoPtr_SelectionMode_Public_Virtual_DeferredSelectionMode_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003BAC RID: 15276 RVA: 0x0015E508 File Offset: 0x0015C708
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanRunImmediately(Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GainImmortalityIntrigueAbility.NativeMethodInfoPtr_CanRunImmediately_Public_Virtual_Boolean_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003BAD RID: 15277 RVA: 0x0015E560 File Offset: 0x0015C760
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 264970, RefRangeEnd = 264972, XrefRangeStart = 264957, XrefRangeEnd = 264970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GainImmortalityIntrigueAbility(WormMatch m, string name = "GainImmortalityIntrigueAbility")
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GainImmortalityIntrigueAbility>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainImmortalityIntrigueAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BAE RID: 15278 RVA: 0x0015E5C0 File Offset: 0x0015C7C0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 24983, RefRangeEnd = 24988, XrefRangeStart = 24983, XrefRangeEnd = 24988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GainImmortalityIntrigueAbility(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GainImmortalityIntrigueAbility>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainImmortalityIntrigueAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BAF RID: 15279 RVA: 0x0015E630 File Offset: 0x0015C830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264972, XrefRangeEnd = 264981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> BeginExecution(WormActiveAbility activeAbility, WormMatch match, Context context)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GainImmortalityIntrigueAbility.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06003BB0 RID: 15280 RVA: 0x0015E6B0 File Offset: 0x0015C8B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 25007, RefRangeEnd = 25008, XrefRangeStart = 25007, XrefRangeEnd = 25008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int ResumeExecution(WormActiveAbility activeAbility, global::Canis.actions.Action returningAction, Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(activeAbility);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(returningAction);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GainImmortalityIntrigueAbility.NativeMethodInfoPtr_ResumeExecution_Public_Virtual_Int32_WormActiveAbility_Action_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003BB1 RID: 15281 RVA: 0x0015E72C File Offset: 0x0015C92C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264981, XrefRangeEnd = 264991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GainImmortalityIntrigueAbility.NativeMethodInfoPtr_ValueForPlayer_Public_Virtual_AIValueSummer_1_Double_WormPlayer_Il2CppReferenceArray_1_WormEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIValueSummer<double>>(intPtr3) : null;
		}

		// Token: 0x06003BB2 RID: 15282 RVA: 0x0001356D File Offset: 0x0001176D
		public override AIValueSummer<double> ValueForPlayer(WormPlayer player, params WormEntity[] withEntities)
		{
			return this.ValueForPlayer(player, new Il2CppReferenceArray<WormEntity>(withEntities));
		}

		// Token: 0x06003BB3 RID: 15283 RVA: 0x0001357C File Offset: 0x0001177C
		public GainImmortalityIntrigueAbility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000E5C RID: 3676
		// (get) Token: 0x06003BB4 RID: 15284 RVA: 0x0015E7A8 File Offset: 0x0015C9A8
		// (set) Token: 0x06003BB5 RID: 15285 RVA: 0x00013585 File Offset: 0x00011785
		public unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GainImmortalityIntrigueAbility.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GainImmortalityIntrigueAbility.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400276E RID: 10094
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x0400276F RID: 10095
		private static readonly IntPtr NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0;

		// Token: 0x04002770 RID: 10096
		private static readonly IntPtr NativeMethodInfoPtr_SelectionMode_Public_Virtual_DeferredSelectionMode_Context_0;

		// Token: 0x04002771 RID: 10097
		private static readonly IntPtr NativeMethodInfoPtr_CanRunImmediately_Public_Virtual_Boolean_Context_0;

		// Token: 0x04002772 RID: 10098
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_String_0;

		// Token: 0x04002773 RID: 10099
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x04002774 RID: 10100
		private static readonly IntPtr NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0;

		// Token: 0x04002775 RID: 10101
		private static readonly IntPtr NativeMethodInfoPtr_ResumeExecution_Public_Virtual_Int32_WormActiveAbility_Action_Context_0;

		// Token: 0x04002776 RID: 10102
		private static readonly IntPtr NativeMethodInfoPtr_ValueForPlayer_Public_Virtual_AIValueSummer_1_Double_WormPlayer_Il2CppReferenceArray_1_WormEntity_0;

		// Token: 0x02000C5D RID: 3165
		[ObfuscatedName("worm.canis.abilities.ActivatedAbilities.Immortality.GainImmortalityIntrigueAbility+<BeginExecution>d__6")]
		public sealed class _BeginExecution_d__6 : Object
		{
			// Token: 0x0600CC68 RID: 52328 RVA: 0x00319710 File Offset: 0x00317910
			// Note: this type is marked as 'beforefieldinit'.
			static _BeginExecution_d__6()
			{
				Il2CppClassPointerStore<GainImmortalityIntrigueAbility._BeginExecution_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GainImmortalityIntrigueAbility>.NativeClassPtr, "<BeginExecution>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GainImmortalityIntrigueAbility._BeginExecution_d__6>.NativeClassPtr);
				GainImmortalityIntrigueAbility._BeginExecution_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainImmortalityIntrigueAbility._BeginExecution_d__6>.NativeClassPtr, "<>1__state");
				GainImmortalityIntrigueAbility._BeginExecution_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainImmortalityIntrigueAbility._BeginExecution_d__6>.NativeClassPtr, "<>2__current");
				GainImmortalityIntrigueAbility._BeginExecution_d__6.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainImmortalityIntrigueAbility._BeginExecution_d__6>.NativeClassPtr, "<>l__initialThreadId");
				GainImmortalityIntrigueAbility._BeginExecution_d__6.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainImmortalityIntrigueAbility._BeginExecution_d__6>.NativeClassPtr, "context");
				GainImmortalityIntrigueAbility._BeginExecution_d__6.NativeFieldInfoPtr___3__context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainImmortalityIntrigueAbility._BeginExecution_d__6>.NativeClassPtr, "<>3__context");
				GainImmortalityIntrigueAbility._BeginExecution_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainImmortalityIntrigueAbility._BeginExecution_d__6>.NativeClassPtr, "<>4__this");
				GainImmortalityIntrigueAbility._BeginExecution_d__6.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainImmortalityIntrigueAbility._BeginExecution_d__6>.NativeClassPtr, "match");
				GainImmortalityIntrigueAbility._BeginExecution_d__6.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainImmortalityIntrigueAbility._BeginExecution_d__6>.NativeClassPtr, "<>3__match");
				GainImmortalityIntrigueAbility._BeginExecution_d__6.NativeFieldInfoPtr_activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainImmortalityIntrigueAbility._BeginExecution_d__6>.NativeClassPtr, "activeAbility");
				GainImmortalityIntrigueAbility._BeginExecution_d__6.NativeFieldInfoPtr___3__activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainImmortalityIntrigueAbility._BeginExecution_d__6>.NativeClassPtr, "<>3__activeAbility");
				GainImmortalityIntrigueAbility._BeginExecution_d__6.NativeFieldInfoPtr__player_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainImmortalityIntrigueAbility._BeginExecution_d__6>.NativeClassPtr, "<player>5__2");
				GainImmortalityIntrigueAbility._BeginExecution_d__6.NativeFieldInfoPtr__sequenceHelper_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainImmortalityIntrigueAbility._BeginExecution_d__6>.NativeClassPtr, "<sequenceHelper>5__3");
				GainImmortalityIntrigueAbility._BeginExecution_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainImmortalityIntrigueAbility._BeginExecution_d__6>.NativeClassPtr, 100682762);
				GainImmortalityIntrigueAbility._BeginExecution_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainImmortalityIntrigueAbility._BeginExecution_d__6>.NativeClassPtr, 100682763);
				GainImmortalityIntrigueAbility._BeginExecution_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainImmortalityIntrigueAbility._BeginExecution_d__6>.NativeClassPtr, 100682764);
				GainImmortalityIntrigueAbility._BeginExecution_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainImmortalityIntrigueAbility._BeginExecution_d__6>.NativeClassPtr, 100682765);
				GainImmortalityIntrigueAbility._BeginExecution_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainImmortalityIntrigueAbility._BeginExecution_d__6>.NativeClassPtr, 100682766);
				GainImmortalityIntrigueAbility._BeginExecution_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainImmortalityIntrigueAbility._BeginExecution_d__6>.NativeClassPtr, 100682767);
				GainImmortalityIntrigueAbility._BeginExecution_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainImmortalityIntrigueAbility._BeginExecution_d__6>.NativeClassPtr, 100682768);
				GainImmortalityIntrigueAbility._BeginExecution_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainImmortalityIntrigueAbility._BeginExecution_d__6>.NativeClassPtr, 100682769);
			}

			// Token: 0x0600CC69 RID: 52329 RVA: 0x003198CC File Offset: 0x00317ACC
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _BeginExecution_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GainImmortalityIntrigueAbility._BeginExecution_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainImmortalityIntrigueAbility._BeginExecution_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600CC6A RID: 52330 RVA: 0x00319914 File Offset: 0x00317B14
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainImmortalityIntrigueAbility._BeginExecution_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CC6B RID: 52331 RVA: 0x00319948 File Offset: 0x00317B48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264919, XrefRangeEnd = 264937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainImmortalityIntrigueAbility._BeginExecution_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700400D RID: 16397
			// (get) Token: 0x0600CC6C RID: 52332 RVA: 0x00319984 File Offset: 0x00317B84
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainImmortalityIntrigueAbility._BeginExecution_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600CC6D RID: 52333 RVA: 0x003199C4 File Offset: 0x00317BC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264937, XrefRangeEnd = 264942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainImmortalityIntrigueAbility._BeginExecution_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700400E RID: 16398
			// (get) Token: 0x0600CC6E RID: 52334 RVA: 0x003199F8 File Offset: 0x00317BF8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainImmortalityIntrigueAbility._BeginExecution_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CC6F RID: 52335 RVA: 0x00319A38 File Offset: 0x00317C38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264942, XrefRangeEnd = 264953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainImmortalityIntrigueAbility._BeginExecution_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600CC70 RID: 52336 RVA: 0x00319A78 File Offset: 0x00317C78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainImmortalityIntrigueAbility._BeginExecution_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600CC71 RID: 52337 RVA: 0x00061135 File Offset: 0x0005F335
			public _BeginExecution_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17004001 RID: 16385
			// (get) Token: 0x0600CC72 RID: 52338 RVA: 0x00319AB8 File Offset: 0x00317CB8
			// (set) Token: 0x0600CC73 RID: 52339 RVA: 0x0006113E File Offset: 0x0005F33E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainImmortalityIntrigueAbility._BeginExecution_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainImmortalityIntrigueAbility._BeginExecution_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004002 RID: 16386
			// (get) Token: 0x0600CC74 RID: 52340 RVA: 0x00319AE0 File Offset: 0x00317CE0
			// (set) Token: 0x0600CC75 RID: 52341 RVA: 0x00061159 File Offset: 0x0005F359
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainImmortalityIntrigueAbility._BeginExecution_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainImmortalityIntrigueAbility._BeginExecution_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004003 RID: 16387
			// (get) Token: 0x0600CC76 RID: 52342 RVA: 0x00319B10 File Offset: 0x00317D10
			// (set) Token: 0x0600CC77 RID: 52343 RVA: 0x00061178 File Offset: 0x0005F378
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainImmortalityIntrigueAbility._BeginExecution_d__6.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainImmortalityIntrigueAbility._BeginExecution_d__6.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17004004 RID: 16388
			// (get) Token: 0x0600CC78 RID: 52344 RVA: 0x00319B38 File Offset: 0x00317D38
			// (set) Token: 0x0600CC79 RID: 52345 RVA: 0x00061193 File Offset: 0x0005F393
			public unsafe Context context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainImmortalityIntrigueAbility._BeginExecution_d__6.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainImmortalityIntrigueAbility._BeginExecution_d__6.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004005 RID: 16389
			// (get) Token: 0x0600CC7A RID: 52346 RVA: 0x00319B68 File Offset: 0x00317D68
			// (set) Token: 0x0600CC7B RID: 52347 RVA: 0x000611B2 File Offset: 0x0005F3B2
			public unsafe Context __3__context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainImmortalityIntrigueAbility._BeginExecution_d__6.NativeFieldInfoPtr___3__context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainImmortalityIntrigueAbility._BeginExecution_d__6.NativeFieldInfoPtr___3__context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004006 RID: 16390
			// (get) Token: 0x0600CC7C RID: 52348 RVA: 0x00319B98 File Offset: 0x00317D98
			// (set) Token: 0x0600CC7D RID: 52349 RVA: 0x000611D1 File Offset: 0x0005F3D1
			public unsafe GainImmortalityIntrigueAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainImmortalityIntrigueAbility._BeginExecution_d__6.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GainImmortalityIntrigueAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainImmortalityIntrigueAbility._BeginExecution_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004007 RID: 16391
			// (get) Token: 0x0600CC7E RID: 52350 RVA: 0x00319BC8 File Offset: 0x00317DC8
			// (set) Token: 0x0600CC7F RID: 52351 RVA: 0x000611F0 File Offset: 0x0005F3F0
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainImmortalityIntrigueAbility._BeginExecution_d__6.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainImmortalityIntrigueAbility._BeginExecution_d__6.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004008 RID: 16392
			// (get) Token: 0x0600CC80 RID: 52352 RVA: 0x00319BF8 File Offset: 0x00317DF8
			// (set) Token: 0x0600CC81 RID: 52353 RVA: 0x0006120F File Offset: 0x0005F40F
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainImmortalityIntrigueAbility._BeginExecution_d__6.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainImmortalityIntrigueAbility._BeginExecution_d__6.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004009 RID: 16393
			// (get) Token: 0x0600CC82 RID: 52354 RVA: 0x00319C28 File Offset: 0x00317E28
			// (set) Token: 0x0600CC83 RID: 52355 RVA: 0x0006122E File Offset: 0x0005F42E
			public unsafe WormActiveAbility activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainImmortalityIntrigueAbility._BeginExecution_d__6.NativeFieldInfoPtr_activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainImmortalityIntrigueAbility._BeginExecution_d__6.NativeFieldInfoPtr_activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700400A RID: 16394
			// (get) Token: 0x0600CC84 RID: 52356 RVA: 0x00319C58 File Offset: 0x00317E58
			// (set) Token: 0x0600CC85 RID: 52357 RVA: 0x0006124D File Offset: 0x0005F44D
			public unsafe WormActiveAbility __3__activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainImmortalityIntrigueAbility._BeginExecution_d__6.NativeFieldInfoPtr___3__activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainImmortalityIntrigueAbility._BeginExecution_d__6.NativeFieldInfoPtr___3__activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700400B RID: 16395
			// (get) Token: 0x0600CC86 RID: 52358 RVA: 0x00319C88 File Offset: 0x00317E88
			// (set) Token: 0x0600CC87 RID: 52359 RVA: 0x0006126C File Offset: 0x0005F46C
			public unsafe WormPlayer _player_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainImmortalityIntrigueAbility._BeginExecution_d__6.NativeFieldInfoPtr__player_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainImmortalityIntrigueAbility._BeginExecution_d__6.NativeFieldInfoPtr__player_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700400C RID: 16396
			// (get) Token: 0x0600CC88 RID: 52360 RVA: 0x00319CB8 File Offset: 0x00317EB8
			// (set) Token: 0x0600CC89 RID: 52361 RVA: 0x0006128B File Offset: 0x0005F48B
			public unsafe SequenceHelper _sequenceHelper_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainImmortalityIntrigueAbility._BeginExecution_d__6.NativeFieldInfoPtr__sequenceHelper_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceHelper>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainImmortalityIntrigueAbility._BeginExecution_d__6.NativeFieldInfoPtr__sequenceHelper_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007FE6 RID: 32742
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04007FE7 RID: 32743
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04007FE8 RID: 32744
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04007FE9 RID: 32745
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x04007FEA RID: 32746
			private static readonly IntPtr NativeFieldInfoPtr___3__context;

			// Token: 0x04007FEB RID: 32747
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04007FEC RID: 32748
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04007FED RID: 32749
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x04007FEE RID: 32750
			private static readonly IntPtr NativeFieldInfoPtr_activeAbility;

			// Token: 0x04007FEF RID: 32751
			private static readonly IntPtr NativeFieldInfoPtr___3__activeAbility;

			// Token: 0x04007FF0 RID: 32752
			private static readonly IntPtr NativeFieldInfoPtr__player_5__2;

			// Token: 0x04007FF1 RID: 32753
			private static readonly IntPtr NativeFieldInfoPtr__sequenceHelper_5__3;

			// Token: 0x04007FF2 RID: 32754
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04007FF3 RID: 32755
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007FF4 RID: 32756
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04007FF5 RID: 32757
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04007FF6 RID: 32758
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007FF7 RID: 32759
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04007FF8 RID: 32760
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04007FF9 RID: 32761
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
