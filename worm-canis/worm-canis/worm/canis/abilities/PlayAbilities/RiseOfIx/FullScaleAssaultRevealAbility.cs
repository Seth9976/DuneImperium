using System;
using System.Runtime.InteropServices;
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

namespace worm.canis.abilities.PlayAbilities.RiseOfIx
{
	// Token: 0x0200043A RID: 1082
	public class FullScaleAssaultRevealAbility : RevealAbility
	{
		// Token: 0x06002F05 RID: 12037 RVA: 0x0011D270 File Offset: 0x0011B470
		// Note: this type is marked as 'beforefieldinit'.
		static FullScaleAssaultRevealAbility()
		{
			Il2CppClassPointerStore<FullScaleAssaultRevealAbility>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.PlayAbilities.RiseOfIx", "FullScaleAssaultRevealAbility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FullScaleAssaultRevealAbility>.NativeClassPtr);
			FullScaleAssaultRevealAbility.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullScaleAssaultRevealAbility>.NativeClassPtr, "AbilityName");
			FullScaleAssaultRevealAbility.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullScaleAssaultRevealAbility>.NativeClassPtr, "AbilityID");
			FullScaleAssaultRevealAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullScaleAssaultRevealAbility>.NativeClassPtr, 100677543);
			FullScaleAssaultRevealAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullScaleAssaultRevealAbility>.NativeClassPtr, 100677544);
			FullScaleAssaultRevealAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullScaleAssaultRevealAbility>.NativeClassPtr, 100677545);
			FullScaleAssaultRevealAbility.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullScaleAssaultRevealAbility>.NativeClassPtr, 100677546);
			FullScaleAssaultRevealAbility.NativeMethodInfoPtr_GetRevealPreviewValue_Public_Virtual_Dictionary_2_String_Int32_WormMatch_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullScaleAssaultRevealAbility>.NativeClassPtr, 100677547);
			FullScaleAssaultRevealAbility.NativeMethodInfoPtr_ValueForPlayer_Public_Virtual_AIValueSummer_1_Double_WormPlayer_Il2CppReferenceArray_1_WormEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullScaleAssaultRevealAbility>.NativeClassPtr, 100677548);
			FullScaleAssaultRevealAbility.NativeMethodInfoPtr___n__0_Private_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullScaleAssaultRevealAbility>.NativeClassPtr, 100677550);
		}

		// Token: 0x06002F06 RID: 12038 RVA: 0x0011D354 File Offset: 0x0011B554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218885, XrefRangeEnd = 218889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FullScaleAssaultRevealAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x06002F07 RID: 12039 RVA: 0x0011D3A0 File Offset: 0x0011B5A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218889, XrefRangeEnd = 218905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FullScaleAssaultRevealAbility(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FullScaleAssaultRevealAbility>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FullScaleAssaultRevealAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F08 RID: 12040 RVA: 0x0011D3EC File Offset: 0x0011B5EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218905, XrefRangeEnd = 218909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FullScaleAssaultRevealAbility(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FullScaleAssaultRevealAbility>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FullScaleAssaultRevealAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F09 RID: 12041 RVA: 0x0011D45C File Offset: 0x0011B65C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218909, XrefRangeEnd = 218918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<Canis.actions.Action> BeginExecution(WormActiveAbility activeAbility, WormMatch match, Context context)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FullScaleAssaultRevealAbility.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06002F0A RID: 12042 RVA: 0x0011D4DC File Offset: 0x0011B6DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218918, XrefRangeEnd = 218941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Dictionary<string, int> GetRevealPreviewValue(WormMatch match, WormPlayer player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FullScaleAssaultRevealAbility.NativeMethodInfoPtr_GetRevealPreviewValue_Public_Virtual_Dictionary_2_String_Int32_WormMatch_WormPlayer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, int>>(intPtr3) : null;
		}

		// Token: 0x06002F0B RID: 12043 RVA: 0x0011D54C File Offset: 0x0011B74C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218941, XrefRangeEnd = 218966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FullScaleAssaultRevealAbility.NativeMethodInfoPtr_ValueForPlayer_Public_Virtual_AIValueSummer_1_Double_WormPlayer_Il2CppReferenceArray_1_WormEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIValueSummer<double>>(intPtr3) : null;
		}

		// Token: 0x06002F0C RID: 12044 RVA: 0x0011D5C8 File Offset: 0x0011B7C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218966, XrefRangeEnd = 218967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<Canis.actions.Action> __n__0(WormActiveAbility activeAbility, WormMatch match, Context context)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FullScaleAssaultRevealAbility.NativeMethodInfoPtr___n__0_Private_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06002F0D RID: 12045 RVA: 0x00010D0D File Offset: 0x0000EF0D
		public override AIValueSummer<double> ValueForPlayer(WormPlayer player, params WormEntity[] withEntities)
		{
			return this.ValueForPlayer(player, new Il2CppReferenceArray<WormEntity>(withEntities));
		}

		// Token: 0x06002F0E RID: 12046 RVA: 0x00010D1C File Offset: 0x0000EF1C
		public FullScaleAssaultRevealAbility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C9F RID: 3231
		// (get) Token: 0x06002F0F RID: 12047 RVA: 0x0011D63C File Offset: 0x0011B83C
		// (set) Token: 0x06002F10 RID: 12048 RVA: 0x00010D25 File Offset: 0x0000EF25
		public new unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FullScaleAssaultRevealAbility.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FullScaleAssaultRevealAbility.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000CA0 RID: 3232
		// (get) Token: 0x06002F11 RID: 12049 RVA: 0x0011D65C File Offset: 0x0011B85C
		// (set) Token: 0x06002F12 RID: 12050 RVA: 0x00010D37 File Offset: 0x0000EF37
		public new unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FullScaleAssaultRevealAbility.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FullScaleAssaultRevealAbility.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001E46 RID: 7750
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x04001E47 RID: 7751
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x04001E48 RID: 7752
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x04001E49 RID: 7753
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x04001E4A RID: 7754
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x04001E4B RID: 7755
		private static readonly IntPtr NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0;

		// Token: 0x04001E4C RID: 7756
		private static readonly IntPtr NativeMethodInfoPtr_GetRevealPreviewValue_Public_Virtual_Dictionary_2_String_Int32_WormMatch_WormPlayer_0;

		// Token: 0x04001E4D RID: 7757
		private static readonly IntPtr NativeMethodInfoPtr_ValueForPlayer_Public_Virtual_AIValueSummer_1_Double_WormPlayer_Il2CppReferenceArray_1_WormEntity_0;

		// Token: 0x04001E4E RID: 7758
		private static readonly IntPtr NativeMethodInfoPtr___n__0_Private_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0;

		// Token: 0x02000A43 RID: 2627
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.RiseOfIx.FullScaleAssaultRevealAbility+<BeginExecution>d__5")]
		public sealed class _BeginExecution_d__5 : Object
		{
			// Token: 0x0600A3E3 RID: 41955 RVA: 0x002A40E4 File Offset: 0x002A22E4
			// Note: this type is marked as 'beforefieldinit'.
			static _BeginExecution_d__5()
			{
				Il2CppClassPointerStore<FullScaleAssaultRevealAbility._BeginExecution_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FullScaleAssaultRevealAbility>.NativeClassPtr, "<BeginExecution>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FullScaleAssaultRevealAbility._BeginExecution_d__5>.NativeClassPtr);
				FullScaleAssaultRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullScaleAssaultRevealAbility._BeginExecution_d__5>.NativeClassPtr, "<>1__state");
				FullScaleAssaultRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullScaleAssaultRevealAbility._BeginExecution_d__5>.NativeClassPtr, "<>2__current");
				FullScaleAssaultRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullScaleAssaultRevealAbility._BeginExecution_d__5>.NativeClassPtr, "<>l__initialThreadId");
				FullScaleAssaultRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr_activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullScaleAssaultRevealAbility._BeginExecution_d__5>.NativeClassPtr, "activeAbility");
				FullScaleAssaultRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr___3__activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullScaleAssaultRevealAbility._BeginExecution_d__5>.NativeClassPtr, "<>3__activeAbility");
				FullScaleAssaultRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullScaleAssaultRevealAbility._BeginExecution_d__5>.NativeClassPtr, "match");
				FullScaleAssaultRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullScaleAssaultRevealAbility._BeginExecution_d__5>.NativeClassPtr, "<>3__match");
				FullScaleAssaultRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullScaleAssaultRevealAbility._BeginExecution_d__5>.NativeClassPtr, "<>4__this");
				FullScaleAssaultRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullScaleAssaultRevealAbility._BeginExecution_d__5>.NativeClassPtr, "context");
				FullScaleAssaultRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr___3__context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullScaleAssaultRevealAbility._BeginExecution_d__5>.NativeClassPtr, "<>3__context");
				FullScaleAssaultRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr__strengthGain_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullScaleAssaultRevealAbility._BeginExecution_d__5>.NativeClassPtr, "<strengthGain>5__2");
				FullScaleAssaultRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullScaleAssaultRevealAbility._BeginExecution_d__5>.NativeClassPtr, "<>7__wrap2");
				FullScaleAssaultRevealAbility._BeginExecution_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullScaleAssaultRevealAbility._BeginExecution_d__5>.NativeClassPtr, 100677551);
				FullScaleAssaultRevealAbility._BeginExecution_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullScaleAssaultRevealAbility._BeginExecution_d__5>.NativeClassPtr, 100677552);
				FullScaleAssaultRevealAbility._BeginExecution_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullScaleAssaultRevealAbility._BeginExecution_d__5>.NativeClassPtr, 100677553);
				FullScaleAssaultRevealAbility._BeginExecution_d__5.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullScaleAssaultRevealAbility._BeginExecution_d__5>.NativeClassPtr, 100677554);
				FullScaleAssaultRevealAbility._BeginExecution_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullScaleAssaultRevealAbility._BeginExecution_d__5>.NativeClassPtr, 100677555);
				FullScaleAssaultRevealAbility._BeginExecution_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullScaleAssaultRevealAbility._BeginExecution_d__5>.NativeClassPtr, 100677556);
				FullScaleAssaultRevealAbility._BeginExecution_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullScaleAssaultRevealAbility._BeginExecution_d__5>.NativeClassPtr, 100677557);
				FullScaleAssaultRevealAbility._BeginExecution_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullScaleAssaultRevealAbility._BeginExecution_d__5>.NativeClassPtr, 100677558);
				FullScaleAssaultRevealAbility._BeginExecution_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullScaleAssaultRevealAbility._BeginExecution_d__5>.NativeClassPtr, 100677559);
			}

			// Token: 0x0600A3E4 RID: 41956 RVA: 0x002A42B4 File Offset: 0x002A24B4
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _BeginExecution_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FullScaleAssaultRevealAbility._BeginExecution_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FullScaleAssaultRevealAbility._BeginExecution_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600A3E5 RID: 41957 RVA: 0x002A42FC File Offset: 0x002A24FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218796, XrefRangeEnd = 218801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FullScaleAssaultRevealAbility._BeginExecution_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A3E6 RID: 41958 RVA: 0x002A4330 File Offset: 0x002A2530
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218801, XrefRangeEnd = 218866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FullScaleAssaultRevealAbility._BeginExecution_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A3E7 RID: 41959 RVA: 0x002A436C File Offset: 0x002A256C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218866, XrefRangeEnd = 218869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FullScaleAssaultRevealAbility._BeginExecution_d__5.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003189 RID: 12681
			// (get) Token: 0x0600A3E8 RID: 41960 RVA: 0x002A43A0 File Offset: 0x002A25A0
			public unsafe Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FullScaleAssaultRevealAbility._BeginExecution_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600A3E9 RID: 41961 RVA: 0x002A43E0 File Offset: 0x002A25E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218869, XrefRangeEnd = 218874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FullScaleAssaultRevealAbility._BeginExecution_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700318A RID: 12682
			// (get) Token: 0x0600A3EA RID: 41962 RVA: 0x002A4414 File Offset: 0x002A2614
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FullScaleAssaultRevealAbility._BeginExecution_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600A3EB RID: 41963 RVA: 0x002A4454 File Offset: 0x002A2654
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218874, XrefRangeEnd = 218885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FullScaleAssaultRevealAbility._BeginExecution_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600A3EC RID: 41964 RVA: 0x002A4494 File Offset: 0x002A2694
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FullScaleAssaultRevealAbility._BeginExecution_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600A3ED RID: 41965 RVA: 0x00049A2F File Offset: 0x00047C2F
			public _BeginExecution_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700317D RID: 12669
			// (get) Token: 0x0600A3EE RID: 41966 RVA: 0x002A44D4 File Offset: 0x002A26D4
			// (set) Token: 0x0600A3EF RID: 41967 RVA: 0x00049A38 File Offset: 0x00047C38
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FullScaleAssaultRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FullScaleAssaultRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700317E RID: 12670
			// (get) Token: 0x0600A3F0 RID: 41968 RVA: 0x002A44FC File Offset: 0x002A26FC
			// (set) Token: 0x0600A3F1 RID: 41969 RVA: 0x00049A53 File Offset: 0x00047C53
			public unsafe Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FullScaleAssaultRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FullScaleAssaultRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700317F RID: 12671
			// (get) Token: 0x0600A3F2 RID: 41970 RVA: 0x002A452C File Offset: 0x002A272C
			// (set) Token: 0x0600A3F3 RID: 41971 RVA: 0x00049A72 File Offset: 0x00047C72
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FullScaleAssaultRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FullScaleAssaultRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17003180 RID: 12672
			// (get) Token: 0x0600A3F4 RID: 41972 RVA: 0x002A4554 File Offset: 0x002A2754
			// (set) Token: 0x0600A3F5 RID: 41973 RVA: 0x00049A8D File Offset: 0x00047C8D
			public unsafe WormActiveAbility activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FullScaleAssaultRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr_activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FullScaleAssaultRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr_activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003181 RID: 12673
			// (get) Token: 0x0600A3F6 RID: 41974 RVA: 0x002A4584 File Offset: 0x002A2784
			// (set) Token: 0x0600A3F7 RID: 41975 RVA: 0x00049AAC File Offset: 0x00047CAC
			public unsafe WormActiveAbility __3__activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FullScaleAssaultRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr___3__activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FullScaleAssaultRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr___3__activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003182 RID: 12674
			// (get) Token: 0x0600A3F8 RID: 41976 RVA: 0x002A45B4 File Offset: 0x002A27B4
			// (set) Token: 0x0600A3F9 RID: 41977 RVA: 0x00049ACB File Offset: 0x00047CCB
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FullScaleAssaultRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FullScaleAssaultRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003183 RID: 12675
			// (get) Token: 0x0600A3FA RID: 41978 RVA: 0x002A45E4 File Offset: 0x002A27E4
			// (set) Token: 0x0600A3FB RID: 41979 RVA: 0x00049AEA File Offset: 0x00047CEA
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FullScaleAssaultRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FullScaleAssaultRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003184 RID: 12676
			// (get) Token: 0x0600A3FC RID: 41980 RVA: 0x002A4614 File Offset: 0x002A2814
			// (set) Token: 0x0600A3FD RID: 41981 RVA: 0x00049B09 File Offset: 0x00047D09
			public unsafe FullScaleAssaultRevealAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FullScaleAssaultRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FullScaleAssaultRevealAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FullScaleAssaultRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003185 RID: 12677
			// (get) Token: 0x0600A3FE RID: 41982 RVA: 0x002A4644 File Offset: 0x002A2844
			// (set) Token: 0x0600A3FF RID: 41983 RVA: 0x00049B28 File Offset: 0x00047D28
			public unsafe Context context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FullScaleAssaultRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FullScaleAssaultRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003186 RID: 12678
			// (get) Token: 0x0600A400 RID: 41984 RVA: 0x002A4674 File Offset: 0x002A2874
			// (set) Token: 0x0600A401 RID: 41985 RVA: 0x00049B47 File Offset: 0x00047D47
			public unsafe Context __3__context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FullScaleAssaultRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr___3__context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FullScaleAssaultRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr___3__context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003187 RID: 12679
			// (get) Token: 0x0600A402 RID: 41986 RVA: 0x002A46A4 File Offset: 0x002A28A4
			// (set) Token: 0x0600A403 RID: 41987 RVA: 0x00049B66 File Offset: 0x00047D66
			public unsafe int _strengthGain_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FullScaleAssaultRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr__strengthGain_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FullScaleAssaultRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr__strengthGain_5__2)) = value;
				}
			}

			// Token: 0x17003188 RID: 12680
			// (get) Token: 0x0600A404 RID: 41988 RVA: 0x002A46CC File Offset: 0x002A28CC
			// (set) Token: 0x0600A405 RID: 41989 RVA: 0x00049B81 File Offset: 0x00047D81
			public unsafe IEnumerator<Canis.actions.Action> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FullScaleAssaultRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Canis.actions.Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FullScaleAssaultRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040067E9 RID: 26601
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040067EA RID: 26602
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040067EB RID: 26603
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040067EC RID: 26604
			private static readonly IntPtr NativeFieldInfoPtr_activeAbility;

			// Token: 0x040067ED RID: 26605
			private static readonly IntPtr NativeFieldInfoPtr___3__activeAbility;

			// Token: 0x040067EE RID: 26606
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x040067EF RID: 26607
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x040067F0 RID: 26608
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040067F1 RID: 26609
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x040067F2 RID: 26610
			private static readonly IntPtr NativeFieldInfoPtr___3__context;

			// Token: 0x040067F3 RID: 26611
			private static readonly IntPtr NativeFieldInfoPtr__strengthGain_5__2;

			// Token: 0x040067F4 RID: 26612
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x040067F5 RID: 26613
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040067F6 RID: 26614
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040067F7 RID: 26615
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040067F8 RID: 26616
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x040067F9 RID: 26617
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x040067FA RID: 26618
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040067FB RID: 26619
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040067FC RID: 26620
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x040067FD RID: 26621
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
