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
	// Token: 0x020003CA RID: 970
	public class HagalCarthagShadowRightAbility : HagalCarthagShadowAbility
	{
		// Token: 0x060028D6 RID: 10454 RVA: 0x000FF5A0 File Offset: 0x000FD7A0
		// Note: this type is marked as 'beforefieldinit'.
		static HagalCarthagShadowRightAbility()
		{
			Il2CppClassPointerStore<HagalCarthagShadowRightAbility>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.HagalAbilities.Immortality", "HagalCarthagShadowRightAbility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HagalCarthagShadowRightAbility>.NativeClassPtr);
			HagalCarthagShadowRightAbility.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalCarthagShadowRightAbility>.NativeClassPtr, "AbilityName");
			HagalCarthagShadowRightAbility.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalCarthagShadowRightAbility>.NativeClassPtr, "AbilityID");
			HagalCarthagShadowRightAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalCarthagShadowRightAbility>.NativeClassPtr, 100675289);
			HagalCarthagShadowRightAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalCarthagShadowRightAbility>.NativeClassPtr, 100675290);
			HagalCarthagShadowRightAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalCarthagShadowRightAbility>.NativeClassPtr, 100675291);
			HagalCarthagShadowRightAbility.NativeMethodInfoPtr_DiscardTleilaxuCard_Protected_Virtual_IEnumerable_1_Action_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalCarthagShadowRightAbility>.NativeClassPtr, 100675292);
		}

		// Token: 0x060028D7 RID: 10455 RVA: 0x000FF648 File Offset: 0x000FD848
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200298, XrefRangeEnd = 200302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HagalCarthagShadowRightAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x060028D8 RID: 10456 RVA: 0x000FF694 File Offset: 0x000FD894
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200302, XrefRangeEnd = 200309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HagalCarthagShadowRightAbility(WormMatch m, string name = "HagalCarthagShadowRightAbility")
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HagalCarthagShadowRightAbility>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalCarthagShadowRightAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028D9 RID: 10457 RVA: 0x000FF6F4 File Offset: 0x000FD8F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200309, XrefRangeEnd = 200313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HagalCarthagShadowRightAbility(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HagalCarthagShadowRightAbility>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalCarthagShadowRightAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028DA RID: 10458 RVA: 0x000FF764 File Offset: 0x000FD964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200313, XrefRangeEnd = 200319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<Canis.actions.Action> DiscardTleilaxuCard(WormMatch match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HagalCarthagShadowRightAbility.NativeMethodInfoPtr_DiscardTleilaxuCard_Protected_Virtual_IEnumerable_1_Action_WormMatch_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Canis.actions.Action>>(intPtr3) : null;
			}
		}

		// Token: 0x060028DB RID: 10459 RVA: 0x0000F480 File Offset: 0x0000D680
		public HagalCarthagShadowRightAbility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BBF RID: 3007
		// (get) Token: 0x060028DC RID: 10460 RVA: 0x000FF7C0 File Offset: 0x000FD9C0
		// (set) Token: 0x060028DD RID: 10461 RVA: 0x0000F489 File Offset: 0x0000D689
		public new unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HagalCarthagShadowRightAbility.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HagalCarthagShadowRightAbility.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000BC0 RID: 3008
		// (get) Token: 0x060028DE RID: 10462 RVA: 0x000FF7E0 File Offset: 0x000FD9E0
		// (set) Token: 0x060028DF RID: 10463 RVA: 0x0000F49B File Offset: 0x0000D69B
		public new unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HagalCarthagShadowRightAbility.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HagalCarthagShadowRightAbility.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001A2A RID: 6698
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x04001A2B RID: 6699
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x04001A2C RID: 6700
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x04001A2D RID: 6701
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_String_0;

		// Token: 0x04001A2E RID: 6702
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x04001A2F RID: 6703
		private static readonly IntPtr NativeMethodInfoPtr_DiscardTleilaxuCard_Protected_Virtual_IEnumerable_1_Action_WormMatch_0;

		// Token: 0x0200097E RID: 2430
		[ObfuscatedName("worm.canis.abilities.HagalAbilities.Immortality.HagalCarthagShadowRightAbility+<DiscardTleilaxuCard>d__5")]
		public sealed class _DiscardTleilaxuCard_d__5 : Object
		{
			// Token: 0x06009316 RID: 37654 RVA: 0x00272CD0 File Offset: 0x00270ED0
			// Note: this type is marked as 'beforefieldinit'.
			static _DiscardTleilaxuCard_d__5()
			{
				Il2CppClassPointerStore<HagalCarthagShadowRightAbility._DiscardTleilaxuCard_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HagalCarthagShadowRightAbility>.NativeClassPtr, "<DiscardTleilaxuCard>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HagalCarthagShadowRightAbility._DiscardTleilaxuCard_d__5>.NativeClassPtr);
				HagalCarthagShadowRightAbility._DiscardTleilaxuCard_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalCarthagShadowRightAbility._DiscardTleilaxuCard_d__5>.NativeClassPtr, "<>1__state");
				HagalCarthagShadowRightAbility._DiscardTleilaxuCard_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalCarthagShadowRightAbility._DiscardTleilaxuCard_d__5>.NativeClassPtr, "<>2__current");
				HagalCarthagShadowRightAbility._DiscardTleilaxuCard_d__5.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalCarthagShadowRightAbility._DiscardTleilaxuCard_d__5>.NativeClassPtr, "<>l__initialThreadId");
				HagalCarthagShadowRightAbility._DiscardTleilaxuCard_d__5.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalCarthagShadowRightAbility._DiscardTleilaxuCard_d__5>.NativeClassPtr, "match");
				HagalCarthagShadowRightAbility._DiscardTleilaxuCard_d__5.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalCarthagShadowRightAbility._DiscardTleilaxuCard_d__5>.NativeClassPtr, "<>3__match");
				HagalCarthagShadowRightAbility._DiscardTleilaxuCard_d__5.NativeFieldInfoPtr__index_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalCarthagShadowRightAbility._DiscardTleilaxuCard_d__5>.NativeClassPtr, "<index>5__2");
				HagalCarthagShadowRightAbility._DiscardTleilaxuCard_d__5.NativeFieldInfoPtr__entity_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalCarthagShadowRightAbility._DiscardTleilaxuCard_d__5>.NativeClassPtr, "<entity>5__3");
				HagalCarthagShadowRightAbility._DiscardTleilaxuCard_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalCarthagShadowRightAbility._DiscardTleilaxuCard_d__5>.NativeClassPtr, 100675294);
				HagalCarthagShadowRightAbility._DiscardTleilaxuCard_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalCarthagShadowRightAbility._DiscardTleilaxuCard_d__5>.NativeClassPtr, 100675295);
				HagalCarthagShadowRightAbility._DiscardTleilaxuCard_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalCarthagShadowRightAbility._DiscardTleilaxuCard_d__5>.NativeClassPtr, 100675296);
				HagalCarthagShadowRightAbility._DiscardTleilaxuCard_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalCarthagShadowRightAbility._DiscardTleilaxuCard_d__5>.NativeClassPtr, 100675297);
				HagalCarthagShadowRightAbility._DiscardTleilaxuCard_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalCarthagShadowRightAbility._DiscardTleilaxuCard_d__5>.NativeClassPtr, 100675298);
				HagalCarthagShadowRightAbility._DiscardTleilaxuCard_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalCarthagShadowRightAbility._DiscardTleilaxuCard_d__5>.NativeClassPtr, 100675299);
				HagalCarthagShadowRightAbility._DiscardTleilaxuCard_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalCarthagShadowRightAbility._DiscardTleilaxuCard_d__5>.NativeClassPtr, 100675300);
				HagalCarthagShadowRightAbility._DiscardTleilaxuCard_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalCarthagShadowRightAbility._DiscardTleilaxuCard_d__5>.NativeClassPtr, 100675301);
			}

			// Token: 0x06009317 RID: 37655 RVA: 0x00272E28 File Offset: 0x00271028
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DiscardTleilaxuCard_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HagalCarthagShadowRightAbility._DiscardTleilaxuCard_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalCarthagShadowRightAbility._DiscardTleilaxuCard_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06009318 RID: 37656 RVA: 0x00272E70 File Offset: 0x00271070
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalCarthagShadowRightAbility._DiscardTleilaxuCard_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009319 RID: 37657 RVA: 0x00272EA4 File Offset: 0x002710A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200269, XrefRangeEnd = 200285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalCarthagShadowRightAbility._DiscardTleilaxuCard_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17002B59 RID: 11097
			// (get) Token: 0x0600931A RID: 37658 RVA: 0x00272EE0 File Offset: 0x002710E0
			public unsafe Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalCarthagShadowRightAbility._DiscardTleilaxuCard_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600931B RID: 37659 RVA: 0x00272F20 File Offset: 0x00271120
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200285, XrefRangeEnd = 200290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalCarthagShadowRightAbility._DiscardTleilaxuCard_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002B5A RID: 11098
			// (get) Token: 0x0600931C RID: 37660 RVA: 0x00272F54 File Offset: 0x00271154
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalCarthagShadowRightAbility._DiscardTleilaxuCard_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600931D RID: 37661 RVA: 0x00272F94 File Offset: 0x00271194
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200290, XrefRangeEnd = 200298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalCarthagShadowRightAbility._DiscardTleilaxuCard_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600931E RID: 37662 RVA: 0x00272FD4 File Offset: 0x002711D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalCarthagShadowRightAbility._DiscardTleilaxuCard_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600931F RID: 37663 RVA: 0x0003FE04 File Offset: 0x0003E004
			public _DiscardTleilaxuCard_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002B52 RID: 11090
			// (get) Token: 0x06009320 RID: 37664 RVA: 0x00273014 File Offset: 0x00271214
			// (set) Token: 0x06009321 RID: 37665 RVA: 0x0003FE0D File Offset: 0x0003E00D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalCarthagShadowRightAbility._DiscardTleilaxuCard_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalCarthagShadowRightAbility._DiscardTleilaxuCard_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002B53 RID: 11091
			// (get) Token: 0x06009322 RID: 37666 RVA: 0x0027303C File Offset: 0x0027123C
			// (set) Token: 0x06009323 RID: 37667 RVA: 0x0003FE28 File Offset: 0x0003E028
			public unsafe Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalCarthagShadowRightAbility._DiscardTleilaxuCard_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalCarthagShadowRightAbility._DiscardTleilaxuCard_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B54 RID: 11092
			// (get) Token: 0x06009324 RID: 37668 RVA: 0x0027306C File Offset: 0x0027126C
			// (set) Token: 0x06009325 RID: 37669 RVA: 0x0003FE47 File Offset: 0x0003E047
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalCarthagShadowRightAbility._DiscardTleilaxuCard_d__5.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalCarthagShadowRightAbility._DiscardTleilaxuCard_d__5.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17002B55 RID: 11093
			// (get) Token: 0x06009326 RID: 37670 RVA: 0x00273094 File Offset: 0x00271294
			// (set) Token: 0x06009327 RID: 37671 RVA: 0x0003FE62 File Offset: 0x0003E062
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalCarthagShadowRightAbility._DiscardTleilaxuCard_d__5.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalCarthagShadowRightAbility._DiscardTleilaxuCard_d__5.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B56 RID: 11094
			// (get) Token: 0x06009328 RID: 37672 RVA: 0x002730C4 File Offset: 0x002712C4
			// (set) Token: 0x06009329 RID: 37673 RVA: 0x0003FE81 File Offset: 0x0003E081
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalCarthagShadowRightAbility._DiscardTleilaxuCard_d__5.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalCarthagShadowRightAbility._DiscardTleilaxuCard_d__5.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B57 RID: 11095
			// (get) Token: 0x0600932A RID: 37674 RVA: 0x002730F4 File Offset: 0x002712F4
			// (set) Token: 0x0600932B RID: 37675 RVA: 0x0003FEA0 File Offset: 0x0003E0A0
			public unsafe int _index_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalCarthagShadowRightAbility._DiscardTleilaxuCard_d__5.NativeFieldInfoPtr__index_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalCarthagShadowRightAbility._DiscardTleilaxuCard_d__5.NativeFieldInfoPtr__index_5__2)) = value;
				}
			}

			// Token: 0x17002B58 RID: 11096
			// (get) Token: 0x0600932C RID: 37676 RVA: 0x0027311C File Offset: 0x0027131C
			// (set) Token: 0x0600932D RID: 37677 RVA: 0x0003FEBB File Offset: 0x0003E0BB
			public unsafe Entity _entity_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalCarthagShadowRightAbility._DiscardTleilaxuCard_d__5.NativeFieldInfoPtr__entity_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalCarthagShadowRightAbility._DiscardTleilaxuCard_d__5.NativeFieldInfoPtr__entity_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005DC1 RID: 24001
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005DC2 RID: 24002
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04005DC3 RID: 24003
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04005DC4 RID: 24004
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04005DC5 RID: 24005
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x04005DC6 RID: 24006
			private static readonly IntPtr NativeFieldInfoPtr__index_5__2;

			// Token: 0x04005DC7 RID: 24007
			private static readonly IntPtr NativeFieldInfoPtr__entity_5__3;

			// Token: 0x04005DC8 RID: 24008
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04005DC9 RID: 24009
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005DCA RID: 24010
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04005DCB RID: 24011
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04005DCC RID: 24012
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005DCD RID: 24013
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04005DCE RID: 24014
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04005DCF RID: 24015
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
