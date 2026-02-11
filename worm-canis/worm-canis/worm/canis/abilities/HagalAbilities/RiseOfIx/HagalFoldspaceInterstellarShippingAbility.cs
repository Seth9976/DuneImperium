using System;
using Canis.actions;
using Canis.context;
using Canis.entities;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.canis.entities;

namespace worm.canis.abilities.HagalAbilities.RiseOfIx
{
	// Token: 0x020003C4 RID: 964
	public class HagalFoldspaceInterstellarShippingAbility : HagalAbility
	{
		// Token: 0x06002895 RID: 10389 RVA: 0x000FE44C File Offset: 0x000FC64C
		// Note: this type is marked as 'beforefieldinit'.
		static HagalFoldspaceInterstellarShippingAbility()
		{
			Il2CppClassPointerStore<HagalFoldspaceInterstellarShippingAbility>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.HagalAbilities.RiseOfIx", "HagalFoldspaceInterstellarShippingAbility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HagalFoldspaceInterstellarShippingAbility>.NativeClassPtr);
			HagalFoldspaceInterstellarShippingAbility.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalFoldspaceInterstellarShippingAbility>.NativeClassPtr, "AbilityName");
			HagalFoldspaceInterstellarShippingAbility.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalFoldspaceInterstellarShippingAbility>.NativeClassPtr, "AbilityID");
			HagalFoldspaceInterstellarShippingAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalFoldspaceInterstellarShippingAbility>.NativeClassPtr, 100675196);
			HagalFoldspaceInterstellarShippingAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalFoldspaceInterstellarShippingAbility>.NativeClassPtr, 100675197);
			HagalFoldspaceInterstellarShippingAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalFoldspaceInterstellarShippingAbility>.NativeClassPtr, 100675198);
			HagalFoldspaceInterstellarShippingAbility.NativeMethodInfoPtr_GetSpace_Protected_Virtual_WormSpace_WormMatch_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalFoldspaceInterstellarShippingAbility>.NativeClassPtr, 100675199);
			HagalFoldspaceInterstellarShippingAbility.NativeMethodInfoPtr_GrantResources_Protected_Virtual_IEnumerable_1_Action_WormMatch_Context_WormSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalFoldspaceInterstellarShippingAbility>.NativeClassPtr, 100675200);
		}

		// Token: 0x06002896 RID: 10390 RVA: 0x000FE508 File Offset: 0x000FC708
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199839, XrefRangeEnd = 199843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HagalFoldspaceInterstellarShippingAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x06002897 RID: 10391 RVA: 0x000FE554 File Offset: 0x000FC754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199843, XrefRangeEnd = 199849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HagalFoldspaceInterstellarShippingAbility(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HagalFoldspaceInterstellarShippingAbility>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalFoldspaceInterstellarShippingAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002898 RID: 10392 RVA: 0x000FE5A0 File Offset: 0x000FC7A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199849, XrefRangeEnd = 199853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HagalFoldspaceInterstellarShippingAbility(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HagalFoldspaceInterstellarShippingAbility>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalFoldspaceInterstellarShippingAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002899 RID: 10393 RVA: 0x000FE610 File Offset: 0x000FC810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199853, XrefRangeEnd = 199868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override WormSpace GetSpace(WormMatch match, WormPlayer player)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HagalFoldspaceInterstellarShippingAbility.NativeMethodInfoPtr_GetSpace_Protected_Virtual_WormSpace_WormMatch_WormPlayer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormSpace>(intPtr3) : null;
		}

		// Token: 0x0600289A RID: 10394 RVA: 0x000FE680 File Offset: 0x000FC880
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199868, XrefRangeEnd = 199876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<Canis.actions.Action> GrantResources(WormMatch match, Context context, WormSpace space)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(space);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HagalFoldspaceInterstellarShippingAbility.NativeMethodInfoPtr_GrantResources_Protected_Virtual_IEnumerable_1_Action_WormMatch_Context_WormSpace_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x0600289B RID: 10395 RVA: 0x0000F372 File Offset: 0x0000D572
		public HagalFoldspaceInterstellarShippingAbility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BB3 RID: 2995
		// (get) Token: 0x0600289C RID: 10396 RVA: 0x000FE700 File Offset: 0x000FC900
		// (set) Token: 0x0600289D RID: 10397 RVA: 0x0000F37B File Offset: 0x0000D57B
		public new unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HagalFoldspaceInterstellarShippingAbility.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HagalFoldspaceInterstellarShippingAbility.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000BB4 RID: 2996
		// (get) Token: 0x0600289E RID: 10398 RVA: 0x000FE720 File Offset: 0x000FC920
		// (set) Token: 0x0600289F RID: 10399 RVA: 0x0000F38D File Offset: 0x0000D58D
		public new unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HagalFoldspaceInterstellarShippingAbility.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HagalFoldspaceInterstellarShippingAbility.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001A01 RID: 6657
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x04001A02 RID: 6658
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x04001A03 RID: 6659
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x04001A04 RID: 6660
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x04001A05 RID: 6661
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x04001A06 RID: 6662
		private static readonly IntPtr NativeMethodInfoPtr_GetSpace_Protected_Virtual_WormSpace_WormMatch_WormPlayer_0;

		// Token: 0x04001A07 RID: 6663
		private static readonly IntPtr NativeMethodInfoPtr_GrantResources_Protected_Virtual_IEnumerable_1_Action_WormMatch_Context_WormSpace_0;

		// Token: 0x02000977 RID: 2423
		[ObfuscatedName("worm.canis.abilities.HagalAbilities.RiseOfIx.HagalFoldspaceInterstellarShippingAbility+<GrantResources>d__6")]
		public sealed class _GrantResources_d__6 : Object
		{
			// Token: 0x0600925E RID: 37470 RVA: 0x00270AC8 File Offset: 0x0026ECC8
			// Note: this type is marked as 'beforefieldinit'.
			static _GrantResources_d__6()
			{
				Il2CppClassPointerStore<HagalFoldspaceInterstellarShippingAbility._GrantResources_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HagalFoldspaceInterstellarShippingAbility>.NativeClassPtr, "<GrantResources>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HagalFoldspaceInterstellarShippingAbility._GrantResources_d__6>.NativeClassPtr);
				HagalFoldspaceInterstellarShippingAbility._GrantResources_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalFoldspaceInterstellarShippingAbility._GrantResources_d__6>.NativeClassPtr, "<>1__state");
				HagalFoldspaceInterstellarShippingAbility._GrantResources_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalFoldspaceInterstellarShippingAbility._GrantResources_d__6>.NativeClassPtr, "<>2__current");
				HagalFoldspaceInterstellarShippingAbility._GrantResources_d__6.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalFoldspaceInterstellarShippingAbility._GrantResources_d__6>.NativeClassPtr, "<>l__initialThreadId");
				HagalFoldspaceInterstellarShippingAbility._GrantResources_d__6.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalFoldspaceInterstellarShippingAbility._GrantResources_d__6>.NativeClassPtr, "context");
				HagalFoldspaceInterstellarShippingAbility._GrantResources_d__6.NativeFieldInfoPtr___3__context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalFoldspaceInterstellarShippingAbility._GrantResources_d__6>.NativeClassPtr, "<>3__context");
				HagalFoldspaceInterstellarShippingAbility._GrantResources_d__6.NativeFieldInfoPtr_space = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalFoldspaceInterstellarShippingAbility._GrantResources_d__6>.NativeClassPtr, "space");
				HagalFoldspaceInterstellarShippingAbility._GrantResources_d__6.NativeFieldInfoPtr___3__space = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalFoldspaceInterstellarShippingAbility._GrantResources_d__6>.NativeClassPtr, "<>3__space");
				HagalFoldspaceInterstellarShippingAbility._GrantResources_d__6.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalFoldspaceInterstellarShippingAbility._GrantResources_d__6>.NativeClassPtr, "match");
				HagalFoldspaceInterstellarShippingAbility._GrantResources_d__6.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalFoldspaceInterstellarShippingAbility._GrantResources_d__6>.NativeClassPtr, "<>3__match");
				HagalFoldspaceInterstellarShippingAbility._GrantResources_d__6.NativeFieldInfoPtr__player_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalFoldspaceInterstellarShippingAbility._GrantResources_d__6>.NativeClassPtr, "<player>5__2");
				HagalFoldspaceInterstellarShippingAbility._GrantResources_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalFoldspaceInterstellarShippingAbility._GrantResources_d__6>.NativeClassPtr, 100675202);
				HagalFoldspaceInterstellarShippingAbility._GrantResources_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalFoldspaceInterstellarShippingAbility._GrantResources_d__6>.NativeClassPtr, 100675203);
				HagalFoldspaceInterstellarShippingAbility._GrantResources_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalFoldspaceInterstellarShippingAbility._GrantResources_d__6>.NativeClassPtr, 100675204);
				HagalFoldspaceInterstellarShippingAbility._GrantResources_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalFoldspaceInterstellarShippingAbility._GrantResources_d__6>.NativeClassPtr, 100675205);
				HagalFoldspaceInterstellarShippingAbility._GrantResources_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalFoldspaceInterstellarShippingAbility._GrantResources_d__6>.NativeClassPtr, 100675206);
				HagalFoldspaceInterstellarShippingAbility._GrantResources_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalFoldspaceInterstellarShippingAbility._GrantResources_d__6>.NativeClassPtr, 100675207);
				HagalFoldspaceInterstellarShippingAbility._GrantResources_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalFoldspaceInterstellarShippingAbility._GrantResources_d__6>.NativeClassPtr, 100675208);
				HagalFoldspaceInterstellarShippingAbility._GrantResources_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalFoldspaceInterstellarShippingAbility._GrantResources_d__6>.NativeClassPtr, 100675209);
			}

			// Token: 0x0600925F RID: 37471 RVA: 0x00270C5C File Offset: 0x0026EE5C
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GrantResources_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HagalFoldspaceInterstellarShippingAbility._GrantResources_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalFoldspaceInterstellarShippingAbility._GrantResources_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06009260 RID: 37472 RVA: 0x00270CA4 File Offset: 0x0026EEA4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalFoldspaceInterstellarShippingAbility._GrantResources_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009261 RID: 37473 RVA: 0x00270CD8 File Offset: 0x0026EED8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199803, XrefRangeEnd = 199824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalFoldspaceInterstellarShippingAbility._GrantResources_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17002B16 RID: 11030
			// (get) Token: 0x06009262 RID: 37474 RVA: 0x00270D14 File Offset: 0x0026EF14
			public unsafe Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalFoldspaceInterstellarShippingAbility._GrantResources_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06009263 RID: 37475 RVA: 0x00270D54 File Offset: 0x0026EF54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199824, XrefRangeEnd = 199829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalFoldspaceInterstellarShippingAbility._GrantResources_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002B17 RID: 11031
			// (get) Token: 0x06009264 RID: 37476 RVA: 0x00270D88 File Offset: 0x0026EF88
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalFoldspaceInterstellarShippingAbility._GrantResources_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06009265 RID: 37477 RVA: 0x00270DC8 File Offset: 0x0026EFC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199829, XrefRangeEnd = 199839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalFoldspaceInterstellarShippingAbility._GrantResources_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06009266 RID: 37478 RVA: 0x00270E08 File Offset: 0x0026F008
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalFoldspaceInterstellarShippingAbility._GrantResources_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06009267 RID: 37479 RVA: 0x0003F735 File Offset: 0x0003D935
			public _GrantResources_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002B0C RID: 11020
			// (get) Token: 0x06009268 RID: 37480 RVA: 0x00270E48 File Offset: 0x0026F048
			// (set) Token: 0x06009269 RID: 37481 RVA: 0x0003F73E File Offset: 0x0003D93E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalFoldspaceInterstellarShippingAbility._GrantResources_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalFoldspaceInterstellarShippingAbility._GrantResources_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002B0D RID: 11021
			// (get) Token: 0x0600926A RID: 37482 RVA: 0x00270E70 File Offset: 0x0026F070
			// (set) Token: 0x0600926B RID: 37483 RVA: 0x0003F759 File Offset: 0x0003D959
			public unsafe Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalFoldspaceInterstellarShippingAbility._GrantResources_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalFoldspaceInterstellarShippingAbility._GrantResources_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B0E RID: 11022
			// (get) Token: 0x0600926C RID: 37484 RVA: 0x00270EA0 File Offset: 0x0026F0A0
			// (set) Token: 0x0600926D RID: 37485 RVA: 0x0003F778 File Offset: 0x0003D978
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalFoldspaceInterstellarShippingAbility._GrantResources_d__6.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalFoldspaceInterstellarShippingAbility._GrantResources_d__6.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17002B0F RID: 11023
			// (get) Token: 0x0600926E RID: 37486 RVA: 0x00270EC8 File Offset: 0x0026F0C8
			// (set) Token: 0x0600926F RID: 37487 RVA: 0x0003F793 File Offset: 0x0003D993
			public unsafe Context context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalFoldspaceInterstellarShippingAbility._GrantResources_d__6.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalFoldspaceInterstellarShippingAbility._GrantResources_d__6.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B10 RID: 11024
			// (get) Token: 0x06009270 RID: 37488 RVA: 0x00270EF8 File Offset: 0x0026F0F8
			// (set) Token: 0x06009271 RID: 37489 RVA: 0x0003F7B2 File Offset: 0x0003D9B2
			public unsafe Context __3__context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalFoldspaceInterstellarShippingAbility._GrantResources_d__6.NativeFieldInfoPtr___3__context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalFoldspaceInterstellarShippingAbility._GrantResources_d__6.NativeFieldInfoPtr___3__context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B11 RID: 11025
			// (get) Token: 0x06009272 RID: 37490 RVA: 0x00270F28 File Offset: 0x0026F128
			// (set) Token: 0x06009273 RID: 37491 RVA: 0x0003F7D1 File Offset: 0x0003D9D1
			public unsafe WormSpace space
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalFoldspaceInterstellarShippingAbility._GrantResources_d__6.NativeFieldInfoPtr_space);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormSpace>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalFoldspaceInterstellarShippingAbility._GrantResources_d__6.NativeFieldInfoPtr_space), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B12 RID: 11026
			// (get) Token: 0x06009274 RID: 37492 RVA: 0x00270F58 File Offset: 0x0026F158
			// (set) Token: 0x06009275 RID: 37493 RVA: 0x0003F7F0 File Offset: 0x0003D9F0
			public unsafe WormSpace __3__space
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalFoldspaceInterstellarShippingAbility._GrantResources_d__6.NativeFieldInfoPtr___3__space);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormSpace>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalFoldspaceInterstellarShippingAbility._GrantResources_d__6.NativeFieldInfoPtr___3__space), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B13 RID: 11027
			// (get) Token: 0x06009276 RID: 37494 RVA: 0x00270F88 File Offset: 0x0026F188
			// (set) Token: 0x06009277 RID: 37495 RVA: 0x0003F80F File Offset: 0x0003DA0F
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalFoldspaceInterstellarShippingAbility._GrantResources_d__6.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalFoldspaceInterstellarShippingAbility._GrantResources_d__6.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B14 RID: 11028
			// (get) Token: 0x06009278 RID: 37496 RVA: 0x00270FB8 File Offset: 0x0026F1B8
			// (set) Token: 0x06009279 RID: 37497 RVA: 0x0003F82E File Offset: 0x0003DA2E
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalFoldspaceInterstellarShippingAbility._GrantResources_d__6.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalFoldspaceInterstellarShippingAbility._GrantResources_d__6.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B15 RID: 11029
			// (get) Token: 0x0600927A RID: 37498 RVA: 0x00270FE8 File Offset: 0x0026F1E8
			// (set) Token: 0x0600927B RID: 37499 RVA: 0x0003F84D File Offset: 0x0003DA4D
			public unsafe WormPlayer _player_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalFoldspaceInterstellarShippingAbility._GrantResources_d__6.NativeFieldInfoPtr__player_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalFoldspaceInterstellarShippingAbility._GrantResources_d__6.NativeFieldInfoPtr__player_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005D4F RID: 23887
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005D50 RID: 23888
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04005D51 RID: 23889
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04005D52 RID: 23890
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x04005D53 RID: 23891
			private static readonly IntPtr NativeFieldInfoPtr___3__context;

			// Token: 0x04005D54 RID: 23892
			private static readonly IntPtr NativeFieldInfoPtr_space;

			// Token: 0x04005D55 RID: 23893
			private static readonly IntPtr NativeFieldInfoPtr___3__space;

			// Token: 0x04005D56 RID: 23894
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04005D57 RID: 23895
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x04005D58 RID: 23896
			private static readonly IntPtr NativeFieldInfoPtr__player_5__2;

			// Token: 0x04005D59 RID: 23897
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04005D5A RID: 23898
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005D5B RID: 23899
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04005D5C RID: 23900
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04005D5D RID: 23901
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005D5E RID: 23902
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04005D5F RID: 23903
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04005D60 RID: 23904
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
