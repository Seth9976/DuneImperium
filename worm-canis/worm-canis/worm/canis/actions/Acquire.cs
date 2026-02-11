using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using Canis.context;
using Canis.entities;
using Canis.gameLogs;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.canis.data.enums;
using worm.canis.entities;

namespace worm.canis.actions
{
	// Token: 0x02000222 RID: 546
	public class Acquire : global::Canis.actions.Action
	{
		// Token: 0x06001819 RID: 6169 RVA: 0x000B6804 File Offset: 0x000B4A04
		// Note: this type is marked as 'beforefieldinit'.
		static Acquire()
		{
			Il2CppClassPointerStore<Acquire>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "Acquire");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Acquire>.NativeClassPtr);
			Acquire.NativeFieldInfoPtr_toArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Acquire>.NativeClassPtr, "toArea");
			Acquire.NativeFieldInfoPtr_sequenceName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Acquire>.NativeClassPtr, "sequenceName");
			Acquire.NativeMethodInfoPtr__ctor_Public_Void_Match_CardToAreas_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Acquire>.NativeClassPtr, 100667377);
			Acquire.NativeMethodInfoPtr_MakeAnalyticsData_Private_Dictionary_2_String_Object_WormMatch_WormImperiumPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Acquire>.NativeClassPtr, 100667378);
			Acquire.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Acquire>.NativeClassPtr, 100667379);
			Acquire.NativeMethodInfoPtr_undo_Protected_Virtual_IEnumerable_1_Action_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Acquire>.NativeClassPtr, 100667380);
			Acquire.NativeMethodInfoPtr_GetAcquireEffectAction_Public_Static_Action_WormMatch_AcquireEffects_Dictionary_2_String_Object_Entity_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Acquire>.NativeClassPtr, 100667381);
			Acquire.NativeMethodInfoPtr_GetAcquireEffectLog_Public_Static_GameLogBuilder_WormMatch_AcquireEffects_Dictionary_2_String_Object_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Acquire>.NativeClassPtr, 100667382);
			Acquire.NativeMethodInfoPtr_GetAcquireEffectParameters_Private_Static_ValueTuple_2_Factions_WormImperiumPlayable_WormMatch_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Acquire>.NativeClassPtr, 100667383);
			Acquire.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Acquire>.NativeClassPtr, 100667384);
		}

		// Token: 0x0600181A RID: 6170 RVA: 0x000B68FC File Offset: 0x000B4AFC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 131124, RefRangeEnd = 131131, XrefRangeStart = 131122, XrefRangeEnd = 131124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Acquire(Match m, CardToAreas toArea = CardToAreas.Discard, string sequenceName = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Acquire>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref toArea;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sequenceName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Acquire.NativeMethodInfoPtr__ctor_Public_Void_Match_CardToAreas_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600181B RID: 6171 RVA: 0x000B6968 File Offset: 0x000B4B68
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 131267, RefRangeEnd = 131270, XrefRangeStart = 131131, XrefRangeEnd = 131267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dictionary<string, Object> MakeAnalyticsData(WormMatch wormMatch, WormImperiumPlayable cardToAcquire)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wormMatch);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cardToAcquire);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Acquire.NativeMethodInfoPtr_MakeAnalyticsData_Private_Dictionary_2_String_Object_WormMatch_WormImperiumPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Object>>(intPtr3) : null;
		}

		// Token: 0x0600181C RID: 6172 RVA: 0x000B69CC File Offset: 0x000B4BCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131270, XrefRangeEnd = 131276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Acquire.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x0600181D RID: 6173 RVA: 0x000B6A18 File Offset: 0x000B4C18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131276, XrefRangeEnd = 131283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> undo(Context undoContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(undoContext);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Acquire.NativeMethodInfoPtr_undo_Protected_Virtual_IEnumerable_1_Action_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
			}
		}

		// Token: 0x0600181E RID: 6174 RVA: 0x000B6A74 File Offset: 0x000B4C74
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 131452, RefRangeEnd = 131455, XrefRangeStart = 131283, XrefRangeEnd = 131452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static global::Canis.actions.Action GetAcquireEffectAction(WormMatch wormMatch, AcquireEffects acquireEffect, Dictionary<string, Object> parameters, Entity entity, WormPlayer player)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wormMatch);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref acquireEffect;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parameters);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(entity);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Acquire.NativeMethodInfoPtr_GetAcquireEffectAction_Public_Static_Action_WormMatch_AcquireEffects_Dictionary_2_String_Object_Entity_WormPlayer_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
		}

		// Token: 0x0600181F RID: 6175 RVA: 0x000B6B00 File Offset: 0x000B4D00
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 131588, RefRangeEnd = 131591, XrefRangeStart = 131455, XrefRangeEnd = 131588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameLogBuilder GetAcquireEffectLog(WormMatch wormMatch, AcquireEffects acquireEffect, Dictionary<string, Object> parameters, WormPlayer player)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wormMatch);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref acquireEffect;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parameters);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Acquire.NativeMethodInfoPtr_GetAcquireEffectLog_Public_Static_GameLogBuilder_WormMatch_AcquireEffects_Dictionary_2_String_Object_WormPlayer_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
		}

		// Token: 0x06001820 RID: 6176 RVA: 0x000B6B78 File Offset: 0x000B4D78
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 131612, RefRangeEnd = 131614, XrefRangeStart = 131591, XrefRangeEnd = 131612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ValueTuple<Factions, WormImperiumPlayable> GetAcquireEffectParameters(WormMatch match, Dictionary<string, Object> parameters)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parameters);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Acquire.NativeMethodInfoPtr_GetAcquireEffectParameters_Private_Static_ValueTuple_2_Factions_WormImperiumPlayable_WormMatch_Dictionary_2_String_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ValueTuple<Factions, WormImperiumPlayable>(intPtr);
		}

		// Token: 0x06001821 RID: 6177 RVA: 0x000B6BC8 File Offset: 0x000B4DC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131614, XrefRangeEnd = 131619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SerializedAction MakeSerializedAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Acquire.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedAction>(intPtr3) : null;
			}
		}

		// Token: 0x06001822 RID: 6178 RVA: 0x0000A779 File Offset: 0x00008979
		public Acquire(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008A8 RID: 2216
		// (get) Token: 0x06001823 RID: 6179 RVA: 0x000B6C24 File Offset: 0x000B4E24
		// (set) Token: 0x06001824 RID: 6180 RVA: 0x0000A782 File Offset: 0x00008982
		public unsafe CardToAreas toArea
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Acquire.NativeFieldInfoPtr_toArea);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Acquire.NativeFieldInfoPtr_toArea)) = value;
			}
		}

		// Token: 0x170008A9 RID: 2217
		// (get) Token: 0x06001825 RID: 6181 RVA: 0x000B6C4C File Offset: 0x000B4E4C
		// (set) Token: 0x06001826 RID: 6182 RVA: 0x0000A79D File Offset: 0x0000899D
		public unsafe string sequenceName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Acquire.NativeFieldInfoPtr_sequenceName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Acquire.NativeFieldInfoPtr_sequenceName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000EE5 RID: 3813
		private static readonly IntPtr NativeFieldInfoPtr_toArea;

		// Token: 0x04000EE6 RID: 3814
		private static readonly IntPtr NativeFieldInfoPtr_sequenceName;

		// Token: 0x04000EE7 RID: 3815
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Match_CardToAreas_String_0;

		// Token: 0x04000EE8 RID: 3816
		private static readonly IntPtr NativeMethodInfoPtr_MakeAnalyticsData_Private_Dictionary_2_String_Object_WormMatch_WormImperiumPlayable_0;

		// Token: 0x04000EE9 RID: 3817
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x04000EEA RID: 3818
		private static readonly IntPtr NativeMethodInfoPtr_undo_Protected_Virtual_IEnumerable_1_Action_Context_0;

		// Token: 0x04000EEB RID: 3819
		private static readonly IntPtr NativeMethodInfoPtr_GetAcquireEffectAction_Public_Static_Action_WormMatch_AcquireEffects_Dictionary_2_String_Object_Entity_WormPlayer_0;

		// Token: 0x04000EEC RID: 3820
		private static readonly IntPtr NativeMethodInfoPtr_GetAcquireEffectLog_Public_Static_GameLogBuilder_WormMatch_AcquireEffects_Dictionary_2_String_Object_WormPlayer_0;

		// Token: 0x04000EED RID: 3821
		private static readonly IntPtr NativeMethodInfoPtr_GetAcquireEffectParameters_Private_Static_ValueTuple_2_Factions_WormImperiumPlayable_WormMatch_Dictionary_2_String_Object_0;

		// Token: 0x04000EEE RID: 3822
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0;

		// Token: 0x0200064E RID: 1614
		[ObfuscatedName("worm.canis.actions.Acquire+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060051F5 RID: 20981 RVA: 0x001AF020 File Offset: 0x001AD220
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Acquire.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Acquire>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Acquire.__c>.NativeClassPtr);
				Acquire.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Acquire.__c>.NativeClassPtr, "<>9");
				Acquire.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Acquire.__c>.NativeClassPtr, "<>9__3_0");
				Acquire.__c.NativeFieldInfoPtr___9__3_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Acquire.__c>.NativeClassPtr, "<>9__3_1");
				Acquire.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Acquire.__c>.NativeClassPtr, "<>9__4_0");
				Acquire.__c.NativeFieldInfoPtr___9__4_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Acquire.__c>.NativeClassPtr, "<>9__4_1");
				Acquire.__c.NativeFieldInfoPtr___9__4_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Acquire.__c>.NativeClassPtr, "<>9__4_2");
				Acquire.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Acquire.__c>.NativeClassPtr, "<>9__6_0");
				Acquire.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Acquire.__c>.NativeClassPtr, 100667386);
				Acquire.__c.NativeMethodInfoPtr__MakeAnalyticsData_b__3_0_Internal_ArchetypeID_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Acquire.__c>.NativeClassPtr, 100667387);
				Acquire.__c.NativeMethodInfoPtr__MakeAnalyticsData_b__3_1_Internal_ArchetypeID_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Acquire.__c>.NativeClassPtr, 100667388);
				Acquire.__c.NativeMethodInfoPtr__execute_b__4_0_Internal_Boolean_WormImperiumPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Acquire.__c>.NativeClassPtr, 100667389);
				Acquire.__c.NativeMethodInfoPtr__execute_b__4_1_Internal_ValueTuple_2_String_Object_KeyValuePair_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Acquire.__c>.NativeClassPtr, 100667390);
				Acquire.__c.NativeMethodInfoPtr__execute_b__4_2_Internal_ValueTuple_2_String_Object_KeyValuePair_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Acquire.__c>.NativeClassPtr, 100667391);
				Acquire.__c.NativeMethodInfoPtr__GetAcquireEffectAction_b__6_0_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Acquire.__c>.NativeClassPtr, 100667392);
			}

			// Token: 0x060051F6 RID: 20982 RVA: 0x001AF164 File Offset: 0x001AD364
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Acquire.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Acquire.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060051F7 RID: 20983 RVA: 0x001AF1A0 File Offset: 0x001AD3A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ArchetypeID _MakeAnalyticsData_b__3_0(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Acquire.__c.NativeMethodInfoPtr__MakeAnalyticsData_b__3_0_Internal_ArchetypeID_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr3) : null;
				}
			}

			// Token: 0x060051F8 RID: 20984 RVA: 0x001AF1F0 File Offset: 0x001AD3F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ArchetypeID _MakeAnalyticsData_b__3_1(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Acquire.__c.NativeMethodInfoPtr__MakeAnalyticsData_b__3_1_Internal_ArchetypeID_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr3) : null;
				}
			}

			// Token: 0x060051F9 RID: 20985 RVA: 0x001AF240 File Offset: 0x001AD440
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130600, XrefRangeEnd = 130601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _execute_b__4_0(WormImperiumPlayable _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Acquire.__c.NativeMethodInfoPtr__execute_b__4_0_Internal_Boolean_WormImperiumPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060051FA RID: 20986 RVA: 0x001AF290 File Offset: 0x001AD490
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130601, XrefRangeEnd = 130606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple<string, Object> _execute_b__4_1(KeyValuePair<string, Object> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Acquire.__c.NativeMethodInfoPtr__execute_b__4_1_Internal_ValueTuple_2_String_Object_KeyValuePair_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ValueTuple<string, Object>(intPtr);
				}
			}

			// Token: 0x060051FB RID: 20987 RVA: 0x001AF2E0 File Offset: 0x001AD4E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130606, XrefRangeEnd = 130611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple<string, Object> _execute_b__4_2(KeyValuePair<string, Object> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Acquire.__c.NativeMethodInfoPtr__execute_b__4_2_Internal_ValueTuple_2_String_Object_KeyValuePair_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ValueTuple<string, Object>(intPtr);
				}
			}

			// Token: 0x060051FC RID: 20988 RVA: 0x001AF330 File Offset: 0x001AD530
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130611, XrefRangeEnd = 130616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetAcquireEffectAction_b__6_0(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Acquire.__c.NativeMethodInfoPtr__GetAcquireEffectAction_b__6_0_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060051FD RID: 20989 RVA: 0x0001C7C0 File Offset: 0x0001A9C0
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700143F RID: 5183
			// (get) Token: 0x060051FE RID: 20990 RVA: 0x001AF380 File Offset: 0x001AD580
			// (set) Token: 0x060051FF RID: 20991 RVA: 0x0001C7C9 File Offset: 0x0001A9C9
			public unsafe static Acquire.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Acquire.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Acquire.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Acquire.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001440 RID: 5184
			// (get) Token: 0x06005200 RID: 20992 RVA: 0x001AF3A8 File Offset: 0x001AD5A8
			// (set) Token: 0x06005201 RID: 20993 RVA: 0x0001C7DB File Offset: 0x0001A9DB
			public unsafe static Func<Entity, ArchetypeID> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Acquire.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, ArchetypeID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Acquire.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001441 RID: 5185
			// (get) Token: 0x06005202 RID: 20994 RVA: 0x001AF3D0 File Offset: 0x001AD5D0
			// (set) Token: 0x06005203 RID: 20995 RVA: 0x0001C7ED File Offset: 0x0001A9ED
			public unsafe static Func<Entity, ArchetypeID> __9__3_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Acquire.__c.NativeFieldInfoPtr___9__3_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, ArchetypeID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Acquire.__c.NativeFieldInfoPtr___9__3_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001442 RID: 5186
			// (get) Token: 0x06005204 RID: 20996 RVA: 0x001AF3F8 File Offset: 0x001AD5F8
			// (set) Token: 0x06005205 RID: 20997 RVA: 0x0001C7FF File Offset: 0x0001A9FF
			public unsafe static Func<WormImperiumPlayable, bool> __9__4_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Acquire.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormImperiumPlayable, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Acquire.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001443 RID: 5187
			// (get) Token: 0x06005206 RID: 20998 RVA: 0x001AF420 File Offset: 0x001AD620
			// (set) Token: 0x06005207 RID: 20999 RVA: 0x0001C811 File Offset: 0x0001AA11
			public unsafe static Func<KeyValuePair<string, Object>, ValueTuple<string, Object>> __9__4_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Acquire.__c.NativeFieldInfoPtr___9__4_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<string, Object>, ValueTuple<string, Object>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Acquire.__c.NativeFieldInfoPtr___9__4_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001444 RID: 5188
			// (get) Token: 0x06005208 RID: 21000 RVA: 0x001AF448 File Offset: 0x001AD648
			// (set) Token: 0x06005209 RID: 21001 RVA: 0x0001C823 File Offset: 0x0001AA23
			public unsafe static Func<KeyValuePair<string, Object>, ValueTuple<string, Object>> __9__4_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Acquire.__c.NativeFieldInfoPtr___9__4_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<string, Object>, ValueTuple<string, Object>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Acquire.__c.NativeFieldInfoPtr___9__4_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001445 RID: 5189
			// (get) Token: 0x0600520A RID: 21002 RVA: 0x001AF470 File Offset: 0x001AD670
			// (set) Token: 0x0600520B RID: 21003 RVA: 0x0001C835 File Offset: 0x0001AA35
			public unsafe static Func<Entity, bool> __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Acquire.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Acquire.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040035B5 RID: 13749
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040035B6 RID: 13750
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x040035B7 RID: 13751
			private static readonly IntPtr NativeFieldInfoPtr___9__3_1;

			// Token: 0x040035B8 RID: 13752
			private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

			// Token: 0x040035B9 RID: 13753
			private static readonly IntPtr NativeFieldInfoPtr___9__4_1;

			// Token: 0x040035BA RID: 13754
			private static readonly IntPtr NativeFieldInfoPtr___9__4_2;

			// Token: 0x040035BB RID: 13755
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x040035BC RID: 13756
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040035BD RID: 13757
			private static readonly IntPtr NativeMethodInfoPtr__MakeAnalyticsData_b__3_0_Internal_ArchetypeID_Entity_0;

			// Token: 0x040035BE RID: 13758
			private static readonly IntPtr NativeMethodInfoPtr__MakeAnalyticsData_b__3_1_Internal_ArchetypeID_Entity_0;

			// Token: 0x040035BF RID: 13759
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__4_0_Internal_Boolean_WormImperiumPlayable_0;

			// Token: 0x040035C0 RID: 13760
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__4_1_Internal_ValueTuple_2_String_Object_KeyValuePair_2_String_Object_0;

			// Token: 0x040035C1 RID: 13761
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__4_2_Internal_ValueTuple_2_String_Object_KeyValuePair_2_String_Object_0;

			// Token: 0x040035C2 RID: 13762
			private static readonly IntPtr NativeMethodInfoPtr__GetAcquireEffectAction_b__6_0_Internal_Boolean_Entity_0;
		}

		// Token: 0x0200064F RID: 1615
		[ObfuscatedName("worm.canis.actions.Acquire+<execute>d__4")]
		public sealed class _execute_d__4 : Object
		{
			// Token: 0x0600520C RID: 21004 RVA: 0x001AF498 File Offset: 0x001AD698
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__4()
			{
				Il2CppClassPointerStore<Acquire._execute_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Acquire>.NativeClassPtr, "<execute>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Acquire._execute_d__4>.NativeClassPtr);
				Acquire._execute_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Acquire._execute_d__4>.NativeClassPtr, "<>1__state");
				Acquire._execute_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Acquire._execute_d__4>.NativeClassPtr, "<>2__current");
				Acquire._execute_d__4.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Acquire._execute_d__4>.NativeClassPtr, "<>l__initialThreadId");
				Acquire._execute_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Acquire._execute_d__4>.NativeClassPtr, "<>4__this");
				Acquire._execute_d__4.NativeFieldInfoPtr__player_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Acquire._execute_d__4>.NativeClassPtr, "<player>5__2");
				Acquire._execute_d__4.NativeFieldInfoPtr__cardToAcquire_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Acquire._execute_d__4>.NativeClassPtr, "<cardToAcquire>5__3");
				Acquire._execute_d__4.NativeFieldInfoPtr__wormMatch_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Acquire._execute_d__4>.NativeClassPtr, "<wormMatch>5__4");
				Acquire._execute_d__4.NativeFieldInfoPtr__playmat_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Acquire._execute_d__4>.NativeClassPtr, "<playmat>5__5");
				Acquire._execute_d__4.NativeFieldInfoPtr__sequenceHelper_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Acquire._execute_d__4>.NativeClassPtr, "<sequenceHelper>5__6");
				Acquire._execute_d__4.NativeFieldInfoPtr__imperiumIndex_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Acquire._execute_d__4>.NativeClassPtr, "<imperiumIndex>5__7");
				Acquire._execute_d__4.NativeFieldInfoPtr__reserveIndex_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Acquire._execute_d__4>.NativeClassPtr, "<reserveIndex>5__8");
				Acquire._execute_d__4.NativeFieldInfoPtr__helenaIndex_5__9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Acquire._execute_d__4>.NativeClassPtr, "<helenaIndex>5__9");
				Acquire._execute_d__4.NativeFieldInfoPtr__tleilaxuIndex_5__10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Acquire._execute_d__4>.NativeClassPtr, "<tleilaxuIndex>5__10");
				Acquire._execute_d__4.NativeFieldInfoPtr__acquireEffectsList_5__11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Acquire._execute_d__4>.NativeClassPtr, "<acquireEffectsList>5__11");
				Acquire._execute_d__4.NativeFieldInfoPtr___7__wrap11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Acquire._execute_d__4>.NativeClassPtr, "<>7__wrap11");
				Acquire._execute_d__4.NativeFieldInfoPtr__from_5__13 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Acquire._execute_d__4>.NativeClassPtr, "<from>5__13");
				Acquire._execute_d__4.NativeFieldInfoPtr__childUndo_5__14 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Acquire._execute_d__4>.NativeClassPtr, "<childUndo>5__14");
				Acquire._execute_d__4.NativeFieldInfoPtr___7__wrap14 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Acquire._execute_d__4>.NativeClassPtr, "<>7__wrap14");
				Acquire._execute_d__4.NativeFieldInfoPtr__acquireEffect_5__16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Acquire._execute_d__4>.NativeClassPtr, "<acquireEffect>5__16");
				Acquire._execute_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Acquire._execute_d__4>.NativeClassPtr, 100667393);
				Acquire._execute_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Acquire._execute_d__4>.NativeClassPtr, 100667394);
				Acquire._execute_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Acquire._execute_d__4>.NativeClassPtr, 100667395);
				Acquire._execute_d__4.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Acquire._execute_d__4>.NativeClassPtr, 100667396);
				Acquire._execute_d__4.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Acquire._execute_d__4>.NativeClassPtr, 100667397);
				Acquire._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Acquire._execute_d__4>.NativeClassPtr, 100667398);
				Acquire._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Acquire._execute_d__4>.NativeClassPtr, 100667399);
				Acquire._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Acquire._execute_d__4>.NativeClassPtr, 100667400);
				Acquire._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Acquire._execute_d__4>.NativeClassPtr, 100667401);
				Acquire._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Acquire._execute_d__4>.NativeClassPtr, 100667402);
			}

			// Token: 0x0600520D RID: 21005 RVA: 0x001AF708 File Offset: 0x001AD908
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Acquire._execute_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Acquire._execute_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600520E RID: 21006 RVA: 0x001AF750 File Offset: 0x001AD950
			[CallerCount(0)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Acquire._execute_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600520F RID: 21007 RVA: 0x001AF784 File Offset: 0x001AD984
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130616, XrefRangeEnd = 131079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Acquire._execute_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005210 RID: 21008 RVA: 0x001AF7C0 File Offset: 0x001AD9C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131079, XrefRangeEnd = 131082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Acquire._execute_d__4.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005211 RID: 21009 RVA: 0x001AF7F4 File Offset: 0x001AD9F4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 131085, RefRangeEnd = 131086, XrefRangeStart = 131082, XrefRangeEnd = 131085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Acquire._execute_d__4.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001459 RID: 5209
			// (get) Token: 0x06005212 RID: 21010 RVA: 0x001AF828 File Offset: 0x001ADA28
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Acquire._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06005213 RID: 21011 RVA: 0x001AF868 File Offset: 0x001ADA68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131086, XrefRangeEnd = 131091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Acquire._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700145A RID: 5210
			// (get) Token: 0x06005214 RID: 21012 RVA: 0x001AF89C File Offset: 0x001ADA9C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Acquire._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005215 RID: 21013 RVA: 0x001AF8DC File Offset: 0x001ADADC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131091, XrefRangeEnd = 131093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Acquire._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06005216 RID: 21014 RVA: 0x001AF91C File Offset: 0x001ADB1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Acquire._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06005217 RID: 21015 RVA: 0x0001C847 File Offset: 0x0001AA47
			public _execute_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001446 RID: 5190
			// (get) Token: 0x06005218 RID: 21016 RVA: 0x001AF95C File Offset: 0x001ADB5C
			// (set) Token: 0x06005219 RID: 21017 RVA: 0x0001C850 File Offset: 0x0001AA50
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Acquire._execute_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Acquire._execute_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001447 RID: 5191
			// (get) Token: 0x0600521A RID: 21018 RVA: 0x001AF984 File Offset: 0x001ADB84
			// (set) Token: 0x0600521B RID: 21019 RVA: 0x0001C86B File Offset: 0x0001AA6B
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Acquire._execute_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Acquire._execute_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001448 RID: 5192
			// (get) Token: 0x0600521C RID: 21020 RVA: 0x001AF9B4 File Offset: 0x001ADBB4
			// (set) Token: 0x0600521D RID: 21021 RVA: 0x0001C88A File Offset: 0x0001AA8A
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Acquire._execute_d__4.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Acquire._execute_d__4.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001449 RID: 5193
			// (get) Token: 0x0600521E RID: 21022 RVA: 0x001AF9DC File Offset: 0x001ADBDC
			// (set) Token: 0x0600521F RID: 21023 RVA: 0x0001C8A5 File Offset: 0x0001AAA5
			public unsafe Acquire __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Acquire._execute_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Acquire>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Acquire._execute_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700144A RID: 5194
			// (get) Token: 0x06005220 RID: 21024 RVA: 0x001AFA0C File Offset: 0x001ADC0C
			// (set) Token: 0x06005221 RID: 21025 RVA: 0x0001C8C4 File Offset: 0x0001AAC4
			public unsafe WormPlayer _player_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Acquire._execute_d__4.NativeFieldInfoPtr__player_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Acquire._execute_d__4.NativeFieldInfoPtr__player_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700144B RID: 5195
			// (get) Token: 0x06005222 RID: 21026 RVA: 0x001AFA3C File Offset: 0x001ADC3C
			// (set) Token: 0x06005223 RID: 21027 RVA: 0x0001C8E3 File Offset: 0x0001AAE3
			public unsafe WormImperiumPlayable _cardToAcquire_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Acquire._execute_d__4.NativeFieldInfoPtr__cardToAcquire_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormImperiumPlayable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Acquire._execute_d__4.NativeFieldInfoPtr__cardToAcquire_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700144C RID: 5196
			// (get) Token: 0x06005224 RID: 21028 RVA: 0x001AFA6C File Offset: 0x001ADC6C
			// (set) Token: 0x06005225 RID: 21029 RVA: 0x0001C902 File Offset: 0x0001AB02
			public unsafe WormMatch _wormMatch_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Acquire._execute_d__4.NativeFieldInfoPtr__wormMatch_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Acquire._execute_d__4.NativeFieldInfoPtr__wormMatch_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700144D RID: 5197
			// (get) Token: 0x06005226 RID: 21030 RVA: 0x001AFA9C File Offset: 0x001ADC9C
			// (set) Token: 0x06005227 RID: 21031 RVA: 0x0001C921 File Offset: 0x0001AB21
			public unsafe WormPlaymat _playmat_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Acquire._execute_d__4.NativeFieldInfoPtr__playmat_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlaymat>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Acquire._execute_d__4.NativeFieldInfoPtr__playmat_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700144E RID: 5198
			// (get) Token: 0x06005228 RID: 21032 RVA: 0x001AFACC File Offset: 0x001ADCCC
			// (set) Token: 0x06005229 RID: 21033 RVA: 0x0001C940 File Offset: 0x0001AB40
			public unsafe SequenceHelper _sequenceHelper_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Acquire._execute_d__4.NativeFieldInfoPtr__sequenceHelper_5__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceHelper>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Acquire._execute_d__4.NativeFieldInfoPtr__sequenceHelper_5__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700144F RID: 5199
			// (get) Token: 0x0600522A RID: 21034 RVA: 0x001AFAFC File Offset: 0x001ADCFC
			// (set) Token: 0x0600522B RID: 21035 RVA: 0x0001C95F File Offset: 0x0001AB5F
			public unsafe int _imperiumIndex_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Acquire._execute_d__4.NativeFieldInfoPtr__imperiumIndex_5__7);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Acquire._execute_d__4.NativeFieldInfoPtr__imperiumIndex_5__7)) = value;
				}
			}

			// Token: 0x17001450 RID: 5200
			// (get) Token: 0x0600522C RID: 21036 RVA: 0x001AFB24 File Offset: 0x001ADD24
			// (set) Token: 0x0600522D RID: 21037 RVA: 0x0001C97A File Offset: 0x0001AB7A
			public unsafe int _reserveIndex_5__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Acquire._execute_d__4.NativeFieldInfoPtr__reserveIndex_5__8);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Acquire._execute_d__4.NativeFieldInfoPtr__reserveIndex_5__8)) = value;
				}
			}

			// Token: 0x17001451 RID: 5201
			// (get) Token: 0x0600522E RID: 21038 RVA: 0x001AFB4C File Offset: 0x001ADD4C
			// (set) Token: 0x0600522F RID: 21039 RVA: 0x0001C995 File Offset: 0x0001AB95
			public unsafe int _helenaIndex_5__9
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Acquire._execute_d__4.NativeFieldInfoPtr__helenaIndex_5__9);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Acquire._execute_d__4.NativeFieldInfoPtr__helenaIndex_5__9)) = value;
				}
			}

			// Token: 0x17001452 RID: 5202
			// (get) Token: 0x06005230 RID: 21040 RVA: 0x001AFB74 File Offset: 0x001ADD74
			// (set) Token: 0x06005231 RID: 21041 RVA: 0x0001C9B0 File Offset: 0x0001ABB0
			public unsafe int _tleilaxuIndex_5__10
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Acquire._execute_d__4.NativeFieldInfoPtr__tleilaxuIndex_5__10);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Acquire._execute_d__4.NativeFieldInfoPtr__tleilaxuIndex_5__10)) = value;
				}
			}

			// Token: 0x17001453 RID: 5203
			// (get) Token: 0x06005232 RID: 21042 RVA: 0x001AFB9C File Offset: 0x001ADD9C
			// (set) Token: 0x06005233 RID: 21043 RVA: 0x0001C9CB File Offset: 0x0001ABCB
			public unsafe List<AcquireEffects> _acquireEffectsList_5__11
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Acquire._execute_d__4.NativeFieldInfoPtr__acquireEffectsList_5__11);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AcquireEffects>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Acquire._execute_d__4.NativeFieldInfoPtr__acquireEffectsList_5__11), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001454 RID: 5204
			// (get) Token: 0x06005234 RID: 21044 RVA: 0x001AFBCC File Offset: 0x001ADDCC
			// (set) Token: 0x06005235 RID: 21045 RVA: 0x0001C9EA File Offset: 0x0001ABEA
			public unsafe IEnumerator<global::Canis.actions.Action> __7__wrap11
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Acquire._execute_d__4.NativeFieldInfoPtr___7__wrap11);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Acquire._execute_d__4.NativeFieldInfoPtr___7__wrap11), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001455 RID: 5205
			// (get) Token: 0x06005236 RID: 21046 RVA: 0x001AFBFC File Offset: 0x001ADDFC
			// (set) Token: 0x06005237 RID: 21047 RVA: 0x0001CA09 File Offset: 0x0001AC09
			public unsafe Entity _from_5__13
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Acquire._execute_d__4.NativeFieldInfoPtr__from_5__13);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Acquire._execute_d__4.NativeFieldInfoPtr__from_5__13), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001456 RID: 5206
			// (get) Token: 0x06005238 RID: 21048 RVA: 0x001AFC2C File Offset: 0x001ADE2C
			// (set) Token: 0x06005239 RID: 21049 RVA: 0x0001CA28 File Offset: 0x0001AC28
			public unsafe UndoNode _childUndo_5__14
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Acquire._execute_d__4.NativeFieldInfoPtr__childUndo_5__14);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UndoNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Acquire._execute_d__4.NativeFieldInfoPtr__childUndo_5__14), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001457 RID: 5207
			// (get) Token: 0x0600523A RID: 21050 RVA: 0x001AFC5C File Offset: 0x001ADE5C
			// (set) Token: 0x0600523B RID: 21051 RVA: 0x0001CA47 File Offset: 0x0001AC47
			public List<AcquireEffects>.Enumerator __7__wrap14
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Acquire._execute_d__4.NativeFieldInfoPtr___7__wrap14);
					return new List<AcquireEffects>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<AcquireEffects>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Acquire._execute_d__4.NativeFieldInfoPtr___7__wrap14), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<AcquireEffects>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001458 RID: 5208
			// (get) Token: 0x0600523C RID: 21052 RVA: 0x001AFC8C File Offset: 0x001ADE8C
			// (set) Token: 0x0600523D RID: 21053 RVA: 0x0001CA75 File Offset: 0x0001AC75
			public unsafe AcquireEffects _acquireEffect_5__16
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Acquire._execute_d__4.NativeFieldInfoPtr__acquireEffect_5__16);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Acquire._execute_d__4.NativeFieldInfoPtr__acquireEffect_5__16)) = value;
				}
			}

			// Token: 0x040035C3 RID: 13763
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040035C4 RID: 13764
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040035C5 RID: 13765
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040035C6 RID: 13766
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040035C7 RID: 13767
			private static readonly IntPtr NativeFieldInfoPtr__player_5__2;

			// Token: 0x040035C8 RID: 13768
			private static readonly IntPtr NativeFieldInfoPtr__cardToAcquire_5__3;

			// Token: 0x040035C9 RID: 13769
			private static readonly IntPtr NativeFieldInfoPtr__wormMatch_5__4;

			// Token: 0x040035CA RID: 13770
			private static readonly IntPtr NativeFieldInfoPtr__playmat_5__5;

			// Token: 0x040035CB RID: 13771
			private static readonly IntPtr NativeFieldInfoPtr__sequenceHelper_5__6;

			// Token: 0x040035CC RID: 13772
			private static readonly IntPtr NativeFieldInfoPtr__imperiumIndex_5__7;

			// Token: 0x040035CD RID: 13773
			private static readonly IntPtr NativeFieldInfoPtr__reserveIndex_5__8;

			// Token: 0x040035CE RID: 13774
			private static readonly IntPtr NativeFieldInfoPtr__helenaIndex_5__9;

			// Token: 0x040035CF RID: 13775
			private static readonly IntPtr NativeFieldInfoPtr__tleilaxuIndex_5__10;

			// Token: 0x040035D0 RID: 13776
			private static readonly IntPtr NativeFieldInfoPtr__acquireEffectsList_5__11;

			// Token: 0x040035D1 RID: 13777
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap11;

			// Token: 0x040035D2 RID: 13778
			private static readonly IntPtr NativeFieldInfoPtr__from_5__13;

			// Token: 0x040035D3 RID: 13779
			private static readonly IntPtr NativeFieldInfoPtr__childUndo_5__14;

			// Token: 0x040035D4 RID: 13780
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap14;

			// Token: 0x040035D5 RID: 13781
			private static readonly IntPtr NativeFieldInfoPtr__acquireEffect_5__16;

			// Token: 0x040035D6 RID: 13782
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040035D7 RID: 13783
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040035D8 RID: 13784
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040035D9 RID: 13785
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x040035DA RID: 13786
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x040035DB RID: 13787
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x040035DC RID: 13788
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040035DD RID: 13789
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040035DE RID: 13790
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x040035DF RID: 13791
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000650 RID: 1616
		[ObfuscatedName("worm.canis.actions.Acquire+<undo>d__5")]
		public sealed class _undo_d__5 : Object
		{
			// Token: 0x0600523E RID: 21054 RVA: 0x001AFCB4 File Offset: 0x001ADEB4
			// Note: this type is marked as 'beforefieldinit'.
			static _undo_d__5()
			{
				Il2CppClassPointerStore<Acquire._undo_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Acquire>.NativeClassPtr, "<undo>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Acquire._undo_d__5>.NativeClassPtr);
				Acquire._undo_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Acquire._undo_d__5>.NativeClassPtr, "<>1__state");
				Acquire._undo_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Acquire._undo_d__5>.NativeClassPtr, "<>2__current");
				Acquire._undo_d__5.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Acquire._undo_d__5>.NativeClassPtr, "<>l__initialThreadId");
				Acquire._undo_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Acquire._undo_d__5>.NativeClassPtr, "<>4__this");
				Acquire._undo_d__5.NativeFieldInfoPtr_undoContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Acquire._undo_d__5>.NativeClassPtr, "undoContext");
				Acquire._undo_d__5.NativeFieldInfoPtr___3__undoContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Acquire._undo_d__5>.NativeClassPtr, "<>3__undoContext");
				Acquire._undo_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Acquire._undo_d__5>.NativeClassPtr, 100667403);
				Acquire._undo_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Acquire._undo_d__5>.NativeClassPtr, 100667404);
				Acquire._undo_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Acquire._undo_d__5>.NativeClassPtr, 100667405);
				Acquire._undo_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Acquire._undo_d__5>.NativeClassPtr, 100667406);
				Acquire._undo_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Acquire._undo_d__5>.NativeClassPtr, 100667407);
				Acquire._undo_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Acquire._undo_d__5>.NativeClassPtr, 100667408);
				Acquire._undo_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Acquire._undo_d__5>.NativeClassPtr, 100667409);
				Acquire._undo_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Acquire._undo_d__5>.NativeClassPtr, 100667410);
			}

			// Token: 0x0600523F RID: 21055 RVA: 0x001AFDF8 File Offset: 0x001ADFF8
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _undo_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Acquire._undo_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Acquire._undo_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005240 RID: 21056 RVA: 0x001AFE40 File Offset: 0x001AE040
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Acquire._undo_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005241 RID: 21057 RVA: 0x001AFE74 File Offset: 0x001AE074
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131093, XrefRangeEnd = 131108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Acquire._undo_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001461 RID: 5217
			// (get) Token: 0x06005242 RID: 21058 RVA: 0x001AFEB0 File Offset: 0x001AE0B0
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Acquire._undo_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06005243 RID: 21059 RVA: 0x001AFEF0 File Offset: 0x001AE0F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131108, XrefRangeEnd = 131113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Acquire._undo_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001462 RID: 5218
			// (get) Token: 0x06005244 RID: 21060 RVA: 0x001AFF24 File Offset: 0x001AE124
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Acquire._undo_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005245 RID: 21061 RVA: 0x001AFF64 File Offset: 0x001AE164
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131113, XrefRangeEnd = 131122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Acquire._undo_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06005246 RID: 21062 RVA: 0x001AFFA4 File Offset: 0x001AE1A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Acquire._undo_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06005247 RID: 21063 RVA: 0x0001CA90 File Offset: 0x0001AC90
			public _undo_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700145B RID: 5211
			// (get) Token: 0x06005248 RID: 21064 RVA: 0x001AFFE4 File Offset: 0x001AE1E4
			// (set) Token: 0x06005249 RID: 21065 RVA: 0x0001CA99 File Offset: 0x0001AC99
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Acquire._undo_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Acquire._undo_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700145C RID: 5212
			// (get) Token: 0x0600524A RID: 21066 RVA: 0x001B000C File Offset: 0x001AE20C
			// (set) Token: 0x0600524B RID: 21067 RVA: 0x0001CAB4 File Offset: 0x0001ACB4
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Acquire._undo_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Acquire._undo_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700145D RID: 5213
			// (get) Token: 0x0600524C RID: 21068 RVA: 0x001B003C File Offset: 0x001AE23C
			// (set) Token: 0x0600524D RID: 21069 RVA: 0x0001CAD3 File Offset: 0x0001ACD3
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Acquire._undo_d__5.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Acquire._undo_d__5.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700145E RID: 5214
			// (get) Token: 0x0600524E RID: 21070 RVA: 0x001B0064 File Offset: 0x001AE264
			// (set) Token: 0x0600524F RID: 21071 RVA: 0x0001CAEE File Offset: 0x0001ACEE
			public unsafe Acquire __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Acquire._undo_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Acquire>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Acquire._undo_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700145F RID: 5215
			// (get) Token: 0x06005250 RID: 21072 RVA: 0x001B0094 File Offset: 0x001AE294
			// (set) Token: 0x06005251 RID: 21073 RVA: 0x0001CB0D File Offset: 0x0001AD0D
			public unsafe Context undoContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Acquire._undo_d__5.NativeFieldInfoPtr_undoContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Acquire._undo_d__5.NativeFieldInfoPtr_undoContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001460 RID: 5216
			// (get) Token: 0x06005252 RID: 21074 RVA: 0x001B00C4 File Offset: 0x001AE2C4
			// (set) Token: 0x06005253 RID: 21075 RVA: 0x0001CB2C File Offset: 0x0001AD2C
			public unsafe Context __3__undoContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Acquire._undo_d__5.NativeFieldInfoPtr___3__undoContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Acquire._undo_d__5.NativeFieldInfoPtr___3__undoContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040035E0 RID: 13792
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040035E1 RID: 13793
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040035E2 RID: 13794
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040035E3 RID: 13795
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040035E4 RID: 13796
			private static readonly IntPtr NativeFieldInfoPtr_undoContext;

			// Token: 0x040035E5 RID: 13797
			private static readonly IntPtr NativeFieldInfoPtr___3__undoContext;

			// Token: 0x040035E6 RID: 13798
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040035E7 RID: 13799
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040035E8 RID: 13800
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040035E9 RID: 13801
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x040035EA RID: 13802
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040035EB RID: 13803
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040035EC RID: 13804
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x040035ED RID: 13805
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
