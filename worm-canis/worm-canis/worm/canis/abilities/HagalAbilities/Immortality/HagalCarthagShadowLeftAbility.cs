using System;
using Canis.actions;
using Canis.entities;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace worm.canis.abilities.HagalAbilities.Immortality
{
	// Token: 0x020003C9 RID: 969
	public class HagalCarthagShadowLeftAbility : HagalCarthagShadowAbility
	{
		// Token: 0x060028CC RID: 10444 RVA: 0x000FF338 File Offset: 0x000FD538
		// Note: this type is marked as 'beforefieldinit'.
		static HagalCarthagShadowLeftAbility()
		{
			Il2CppClassPointerStore<HagalCarthagShadowLeftAbility>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.HagalAbilities.Immortality", "HagalCarthagShadowLeftAbility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HagalCarthagShadowLeftAbility>.NativeClassPtr);
			HagalCarthagShadowLeftAbility.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalCarthagShadowLeftAbility>.NativeClassPtr, "AbilityName");
			HagalCarthagShadowLeftAbility.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalCarthagShadowLeftAbility>.NativeClassPtr, "AbilityID");
			HagalCarthagShadowLeftAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalCarthagShadowLeftAbility>.NativeClassPtr, 100675276);
			HagalCarthagShadowLeftAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalCarthagShadowLeftAbility>.NativeClassPtr, 100675277);
			HagalCarthagShadowLeftAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalCarthagShadowLeftAbility>.NativeClassPtr, 100675278);
			HagalCarthagShadowLeftAbility.NativeMethodInfoPtr_DiscardTleilaxuCard_Protected_Virtual_IEnumerable_1_Action_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalCarthagShadowLeftAbility>.NativeClassPtr, 100675279);
		}

		// Token: 0x060028CD RID: 10445 RVA: 0x000FF3E0 File Offset: 0x000FD5E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200248, XrefRangeEnd = 200252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HagalCarthagShadowLeftAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x060028CE RID: 10446 RVA: 0x000FF42C File Offset: 0x000FD62C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200252, XrefRangeEnd = 200259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HagalCarthagShadowLeftAbility(WormMatch m, string name = "HagalCarthagShadowLeftAbility")
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HagalCarthagShadowLeftAbility>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalCarthagShadowLeftAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028CF RID: 10447 RVA: 0x000FF48C File Offset: 0x000FD68C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200259, XrefRangeEnd = 200263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HagalCarthagShadowLeftAbility(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HagalCarthagShadowLeftAbility>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalCarthagShadowLeftAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028D0 RID: 10448 RVA: 0x000FF4FC File Offset: 0x000FD6FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200263, XrefRangeEnd = 200269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<Canis.actions.Action> DiscardTleilaxuCard(WormMatch match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HagalCarthagShadowLeftAbility.NativeMethodInfoPtr_DiscardTleilaxuCard_Protected_Virtual_IEnumerable_1_Action_WormMatch_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Canis.actions.Action>>(intPtr3) : null;
			}
		}

		// Token: 0x060028D1 RID: 10449 RVA: 0x0000F453 File Offset: 0x0000D653
		public HagalCarthagShadowLeftAbility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BBD RID: 3005
		// (get) Token: 0x060028D2 RID: 10450 RVA: 0x000FF558 File Offset: 0x000FD758
		// (set) Token: 0x060028D3 RID: 10451 RVA: 0x0000F45C File Offset: 0x0000D65C
		public new unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HagalCarthagShadowLeftAbility.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HagalCarthagShadowLeftAbility.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000BBE RID: 3006
		// (get) Token: 0x060028D4 RID: 10452 RVA: 0x000FF578 File Offset: 0x000FD778
		// (set) Token: 0x060028D5 RID: 10453 RVA: 0x0000F46E File Offset: 0x0000D66E
		public new unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HagalCarthagShadowLeftAbility.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HagalCarthagShadowLeftAbility.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001A24 RID: 6692
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x04001A25 RID: 6693
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x04001A26 RID: 6694
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x04001A27 RID: 6695
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_String_0;

		// Token: 0x04001A28 RID: 6696
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x04001A29 RID: 6697
		private static readonly IntPtr NativeMethodInfoPtr_DiscardTleilaxuCard_Protected_Virtual_IEnumerable_1_Action_WormMatch_0;

		// Token: 0x0200097D RID: 2429
		[ObfuscatedName("worm.canis.abilities.HagalAbilities.Immortality.HagalCarthagShadowLeftAbility+<DiscardTleilaxuCard>d__5")]
		public sealed class _DiscardTleilaxuCard_d__5 : Object
		{
			// Token: 0x06009300 RID: 37632 RVA: 0x00272890 File Offset: 0x00270A90
			// Note: this type is marked as 'beforefieldinit'.
			static _DiscardTleilaxuCard_d__5()
			{
				Il2CppClassPointerStore<HagalCarthagShadowLeftAbility._DiscardTleilaxuCard_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HagalCarthagShadowLeftAbility>.NativeClassPtr, "<DiscardTleilaxuCard>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HagalCarthagShadowLeftAbility._DiscardTleilaxuCard_d__5>.NativeClassPtr);
				HagalCarthagShadowLeftAbility._DiscardTleilaxuCard_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalCarthagShadowLeftAbility._DiscardTleilaxuCard_d__5>.NativeClassPtr, "<>1__state");
				HagalCarthagShadowLeftAbility._DiscardTleilaxuCard_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalCarthagShadowLeftAbility._DiscardTleilaxuCard_d__5>.NativeClassPtr, "<>2__current");
				HagalCarthagShadowLeftAbility._DiscardTleilaxuCard_d__5.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalCarthagShadowLeftAbility._DiscardTleilaxuCard_d__5>.NativeClassPtr, "<>l__initialThreadId");
				HagalCarthagShadowLeftAbility._DiscardTleilaxuCard_d__5.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalCarthagShadowLeftAbility._DiscardTleilaxuCard_d__5>.NativeClassPtr, "match");
				HagalCarthagShadowLeftAbility._DiscardTleilaxuCard_d__5.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalCarthagShadowLeftAbility._DiscardTleilaxuCard_d__5>.NativeClassPtr, "<>3__match");
				HagalCarthagShadowLeftAbility._DiscardTleilaxuCard_d__5.NativeFieldInfoPtr__entity_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalCarthagShadowLeftAbility._DiscardTleilaxuCard_d__5>.NativeClassPtr, "<entity>5__2");
				HagalCarthagShadowLeftAbility._DiscardTleilaxuCard_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalCarthagShadowLeftAbility._DiscardTleilaxuCard_d__5>.NativeClassPtr, 100675281);
				HagalCarthagShadowLeftAbility._DiscardTleilaxuCard_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalCarthagShadowLeftAbility._DiscardTleilaxuCard_d__5>.NativeClassPtr, 100675282);
				HagalCarthagShadowLeftAbility._DiscardTleilaxuCard_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalCarthagShadowLeftAbility._DiscardTleilaxuCard_d__5>.NativeClassPtr, 100675283);
				HagalCarthagShadowLeftAbility._DiscardTleilaxuCard_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalCarthagShadowLeftAbility._DiscardTleilaxuCard_d__5>.NativeClassPtr, 100675284);
				HagalCarthagShadowLeftAbility._DiscardTleilaxuCard_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalCarthagShadowLeftAbility._DiscardTleilaxuCard_d__5>.NativeClassPtr, 100675285);
				HagalCarthagShadowLeftAbility._DiscardTleilaxuCard_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalCarthagShadowLeftAbility._DiscardTleilaxuCard_d__5>.NativeClassPtr, 100675286);
				HagalCarthagShadowLeftAbility._DiscardTleilaxuCard_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalCarthagShadowLeftAbility._DiscardTleilaxuCard_d__5>.NativeClassPtr, 100675287);
				HagalCarthagShadowLeftAbility._DiscardTleilaxuCard_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalCarthagShadowLeftAbility._DiscardTleilaxuCard_d__5>.NativeClassPtr, 100675288);
			}

			// Token: 0x06009301 RID: 37633 RVA: 0x002729D4 File Offset: 0x00270BD4
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DiscardTleilaxuCard_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HagalCarthagShadowLeftAbility._DiscardTleilaxuCard_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalCarthagShadowLeftAbility._DiscardTleilaxuCard_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06009302 RID: 37634 RVA: 0x00272A1C File Offset: 0x00270C1C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalCarthagShadowLeftAbility._DiscardTleilaxuCard_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009303 RID: 37635 RVA: 0x00272A50 File Offset: 0x00270C50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200219, XrefRangeEnd = 200235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalCarthagShadowLeftAbility._DiscardTleilaxuCard_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17002B50 RID: 11088
			// (get) Token: 0x06009304 RID: 37636 RVA: 0x00272A8C File Offset: 0x00270C8C
			public unsafe Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalCarthagShadowLeftAbility._DiscardTleilaxuCard_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06009305 RID: 37637 RVA: 0x00272ACC File Offset: 0x00270CCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200235, XrefRangeEnd = 200240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalCarthagShadowLeftAbility._DiscardTleilaxuCard_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002B51 RID: 11089
			// (get) Token: 0x06009306 RID: 37638 RVA: 0x00272B00 File Offset: 0x00270D00
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalCarthagShadowLeftAbility._DiscardTleilaxuCard_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06009307 RID: 37639 RVA: 0x00272B40 File Offset: 0x00270D40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200240, XrefRangeEnd = 200248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalCarthagShadowLeftAbility._DiscardTleilaxuCard_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06009308 RID: 37640 RVA: 0x00272B80 File Offset: 0x00270D80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalCarthagShadowLeftAbility._DiscardTleilaxuCard_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06009309 RID: 37641 RVA: 0x0003FD49 File Offset: 0x0003DF49
			public _DiscardTleilaxuCard_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002B4A RID: 11082
			// (get) Token: 0x0600930A RID: 37642 RVA: 0x00272BC0 File Offset: 0x00270DC0
			// (set) Token: 0x0600930B RID: 37643 RVA: 0x0003FD52 File Offset: 0x0003DF52
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalCarthagShadowLeftAbility._DiscardTleilaxuCard_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalCarthagShadowLeftAbility._DiscardTleilaxuCard_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002B4B RID: 11083
			// (get) Token: 0x0600930C RID: 37644 RVA: 0x00272BE8 File Offset: 0x00270DE8
			// (set) Token: 0x0600930D RID: 37645 RVA: 0x0003FD6D File Offset: 0x0003DF6D
			public unsafe Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalCarthagShadowLeftAbility._DiscardTleilaxuCard_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalCarthagShadowLeftAbility._DiscardTleilaxuCard_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B4C RID: 11084
			// (get) Token: 0x0600930E RID: 37646 RVA: 0x00272C18 File Offset: 0x00270E18
			// (set) Token: 0x0600930F RID: 37647 RVA: 0x0003FD8C File Offset: 0x0003DF8C
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalCarthagShadowLeftAbility._DiscardTleilaxuCard_d__5.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalCarthagShadowLeftAbility._DiscardTleilaxuCard_d__5.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17002B4D RID: 11085
			// (get) Token: 0x06009310 RID: 37648 RVA: 0x00272C40 File Offset: 0x00270E40
			// (set) Token: 0x06009311 RID: 37649 RVA: 0x0003FDA7 File Offset: 0x0003DFA7
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalCarthagShadowLeftAbility._DiscardTleilaxuCard_d__5.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalCarthagShadowLeftAbility._DiscardTleilaxuCard_d__5.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B4E RID: 11086
			// (get) Token: 0x06009312 RID: 37650 RVA: 0x00272C70 File Offset: 0x00270E70
			// (set) Token: 0x06009313 RID: 37651 RVA: 0x0003FDC6 File Offset: 0x0003DFC6
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalCarthagShadowLeftAbility._DiscardTleilaxuCard_d__5.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalCarthagShadowLeftAbility._DiscardTleilaxuCard_d__5.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B4F RID: 11087
			// (get) Token: 0x06009314 RID: 37652 RVA: 0x00272CA0 File Offset: 0x00270EA0
			// (set) Token: 0x06009315 RID: 37653 RVA: 0x0003FDE5 File Offset: 0x0003DFE5
			public unsafe Entity _entity_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalCarthagShadowLeftAbility._DiscardTleilaxuCard_d__5.NativeFieldInfoPtr__entity_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalCarthagShadowLeftAbility._DiscardTleilaxuCard_d__5.NativeFieldInfoPtr__entity_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005DB3 RID: 23987
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005DB4 RID: 23988
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04005DB5 RID: 23989
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04005DB6 RID: 23990
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04005DB7 RID: 23991
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x04005DB8 RID: 23992
			private static readonly IntPtr NativeFieldInfoPtr__entity_5__2;

			// Token: 0x04005DB9 RID: 23993
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04005DBA RID: 23994
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005DBB RID: 23995
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04005DBC RID: 23996
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04005DBD RID: 23997
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005DBE RID: 23998
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04005DBF RID: 23999
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04005DC0 RID: 24000
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
