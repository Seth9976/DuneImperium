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

namespace worm.canis.abilities.HagalAbilities.Immortality
{
	// Token: 0x020003C8 RID: 968
	public class HagalCarthagShadowAbility : HagalAbility
	{
		// Token: 0x060028C1 RID: 10433 RVA: 0x000FF03C File Offset: 0x000FD23C
		// Note: this type is marked as 'beforefieldinit'.
		static HagalCarthagShadowAbility()
		{
			Il2CppClassPointerStore<HagalCarthagShadowAbility>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.HagalAbilities.Immortality", "HagalCarthagShadowAbility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HagalCarthagShadowAbility>.NativeClassPtr);
			HagalCarthagShadowAbility.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalCarthagShadowAbility>.NativeClassPtr, "AbilityName");
			HagalCarthagShadowAbility.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalCarthagShadowAbility>.NativeClassPtr, "AbilityID");
			HagalCarthagShadowAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalCarthagShadowAbility>.NativeClassPtr, 100675253);
			HagalCarthagShadowAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalCarthagShadowAbility>.NativeClassPtr, 100675254);
			HagalCarthagShadowAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalCarthagShadowAbility>.NativeClassPtr, 100675255);
			HagalCarthagShadowAbility.NativeMethodInfoPtr_GrantResources_Protected_Virtual_IEnumerable_1_Action_WormMatch_Context_WormSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalCarthagShadowAbility>.NativeClassPtr, 100675256);
			HagalCarthagShadowAbility.NativeMethodInfoPtr_DiscardTleilaxuCard_Protected_Virtual_New_IEnumerable_1_Action_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalCarthagShadowAbility>.NativeClassPtr, 100675257);
		}

		// Token: 0x060028C2 RID: 10434 RVA: 0x000FF0F8 File Offset: 0x000FD2F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200192, XrefRangeEnd = 200196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HagalCarthagShadowAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x060028C3 RID: 10435 RVA: 0x000FF144 File Offset: 0x000FD344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200196, XrefRangeEnd = 200200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HagalCarthagShadowAbility(WormMatch m, string name = "HagalCarthagShadowAbility")
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HagalCarthagShadowAbility>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalCarthagShadowAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028C4 RID: 10436 RVA: 0x000FF1A4 File Offset: 0x000FD3A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 200204, RefRangeEnd = 200206, XrefRangeStart = 200200, XrefRangeEnd = 200204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HagalCarthagShadowAbility(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HagalCarthagShadowAbility>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalCarthagShadowAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028C5 RID: 10437 RVA: 0x000FF214 File Offset: 0x000FD414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200206, XrefRangeEnd = 200214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HagalCarthagShadowAbility.NativeMethodInfoPtr_GrantResources_Protected_Virtual_IEnumerable_1_Action_WormMatch_Context_WormSpace_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x060028C6 RID: 10438 RVA: 0x000FF294 File Offset: 0x000FD494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200214, XrefRangeEnd = 200219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerable<Canis.actions.Action> DiscardTleilaxuCard(WormMatch match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HagalCarthagShadowAbility.NativeMethodInfoPtr_DiscardTleilaxuCard_Protected_Virtual_New_IEnumerable_1_Action_WormMatch_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Canis.actions.Action>>(intPtr3) : null;
			}
		}

		// Token: 0x060028C7 RID: 10439 RVA: 0x0000F426 File Offset: 0x0000D626
		public HagalCarthagShadowAbility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BBB RID: 3003
		// (get) Token: 0x060028C8 RID: 10440 RVA: 0x000FF2F0 File Offset: 0x000FD4F0
		// (set) Token: 0x060028C9 RID: 10441 RVA: 0x0000F42F File Offset: 0x0000D62F
		public new unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HagalCarthagShadowAbility.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HagalCarthagShadowAbility.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000BBC RID: 3004
		// (get) Token: 0x060028CA RID: 10442 RVA: 0x000FF310 File Offset: 0x000FD510
		// (set) Token: 0x060028CB RID: 10443 RVA: 0x0000F441 File Offset: 0x0000D641
		public new unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HagalCarthagShadowAbility.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HagalCarthagShadowAbility.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001A1D RID: 6685
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x04001A1E RID: 6686
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x04001A1F RID: 6687
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x04001A20 RID: 6688
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_String_0;

		// Token: 0x04001A21 RID: 6689
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x04001A22 RID: 6690
		private static readonly IntPtr NativeMethodInfoPtr_GrantResources_Protected_Virtual_IEnumerable_1_Action_WormMatch_Context_WormSpace_0;

		// Token: 0x04001A23 RID: 6691
		private static readonly IntPtr NativeMethodInfoPtr_DiscardTleilaxuCard_Protected_Virtual_New_IEnumerable_1_Action_WormMatch_0;

		// Token: 0x0200097B RID: 2427
		[ObfuscatedName("worm.canis.abilities.HagalAbilities.Immortality.HagalCarthagShadowAbility+<DiscardTleilaxuCard>d__6")]
		public sealed class _DiscardTleilaxuCard_d__6 : Object
		{
			// Token: 0x060092D1 RID: 37585 RVA: 0x00271F84 File Offset: 0x00270184
			// Note: this type is marked as 'beforefieldinit'.
			static _DiscardTleilaxuCard_d__6()
			{
				Il2CppClassPointerStore<HagalCarthagShadowAbility._DiscardTleilaxuCard_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HagalCarthagShadowAbility>.NativeClassPtr, "<DiscardTleilaxuCard>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HagalCarthagShadowAbility._DiscardTleilaxuCard_d__6>.NativeClassPtr);
				HagalCarthagShadowAbility._DiscardTleilaxuCard_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalCarthagShadowAbility._DiscardTleilaxuCard_d__6>.NativeClassPtr, "<>1__state");
				HagalCarthagShadowAbility._DiscardTleilaxuCard_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalCarthagShadowAbility._DiscardTleilaxuCard_d__6>.NativeClassPtr, "<>2__current");
				HagalCarthagShadowAbility._DiscardTleilaxuCard_d__6.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalCarthagShadowAbility._DiscardTleilaxuCard_d__6>.NativeClassPtr, "<>l__initialThreadId");
				HagalCarthagShadowAbility._DiscardTleilaxuCard_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalCarthagShadowAbility._DiscardTleilaxuCard_d__6>.NativeClassPtr, 100675259);
				HagalCarthagShadowAbility._DiscardTleilaxuCard_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalCarthagShadowAbility._DiscardTleilaxuCard_d__6>.NativeClassPtr, 100675260);
				HagalCarthagShadowAbility._DiscardTleilaxuCard_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalCarthagShadowAbility._DiscardTleilaxuCard_d__6>.NativeClassPtr, 100675261);
				HagalCarthagShadowAbility._DiscardTleilaxuCard_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalCarthagShadowAbility._DiscardTleilaxuCard_d__6>.NativeClassPtr, 100675262);
				HagalCarthagShadowAbility._DiscardTleilaxuCard_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalCarthagShadowAbility._DiscardTleilaxuCard_d__6>.NativeClassPtr, 100675263);
				HagalCarthagShadowAbility._DiscardTleilaxuCard_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalCarthagShadowAbility._DiscardTleilaxuCard_d__6>.NativeClassPtr, 100675264);
				HagalCarthagShadowAbility._DiscardTleilaxuCard_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalCarthagShadowAbility._DiscardTleilaxuCard_d__6>.NativeClassPtr, 100675265);
				HagalCarthagShadowAbility._DiscardTleilaxuCard_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalCarthagShadowAbility._DiscardTleilaxuCard_d__6>.NativeClassPtr, 100675266);
			}

			// Token: 0x060092D2 RID: 37586 RVA: 0x0027208C File Offset: 0x0027028C
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DiscardTleilaxuCard_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HagalCarthagShadowAbility._DiscardTleilaxuCard_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalCarthagShadowAbility._DiscardTleilaxuCard_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060092D3 RID: 37587 RVA: 0x002720D4 File Offset: 0x002702D4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalCarthagShadowAbility._DiscardTleilaxuCard_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060092D4 RID: 37588 RVA: 0x00272108 File Offset: 0x00270308
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalCarthagShadowAbility._DiscardTleilaxuCard_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17002B3C RID: 11068
			// (get) Token: 0x060092D5 RID: 37589 RVA: 0x00272144 File Offset: 0x00270344
			public unsafe Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalCarthagShadowAbility._DiscardTleilaxuCard_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x060092D6 RID: 37590 RVA: 0x00272184 File Offset: 0x00270384
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200099, XrefRangeEnd = 200104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalCarthagShadowAbility._DiscardTleilaxuCard_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002B3D RID: 11069
			// (get) Token: 0x060092D7 RID: 37591 RVA: 0x002721B8 File Offset: 0x002703B8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalCarthagShadowAbility._DiscardTleilaxuCard_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060092D8 RID: 37592 RVA: 0x002721F8 File Offset: 0x002703F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200104, XrefRangeEnd = 200106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalCarthagShadowAbility._DiscardTleilaxuCard_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x060092D9 RID: 37593 RVA: 0x00272238 File Offset: 0x00270438
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalCarthagShadowAbility._DiscardTleilaxuCard_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060092DA RID: 37594 RVA: 0x0003FBB4 File Offset: 0x0003DDB4
			public _DiscardTleilaxuCard_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002B39 RID: 11065
			// (get) Token: 0x060092DB RID: 37595 RVA: 0x00272278 File Offset: 0x00270478
			// (set) Token: 0x060092DC RID: 37596 RVA: 0x0003FBBD File Offset: 0x0003DDBD
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalCarthagShadowAbility._DiscardTleilaxuCard_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalCarthagShadowAbility._DiscardTleilaxuCard_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002B3A RID: 11066
			// (get) Token: 0x060092DD RID: 37597 RVA: 0x002722A0 File Offset: 0x002704A0
			// (set) Token: 0x060092DE RID: 37598 RVA: 0x0003FBD8 File Offset: 0x0003DDD8
			public unsafe Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalCarthagShadowAbility._DiscardTleilaxuCard_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalCarthagShadowAbility._DiscardTleilaxuCard_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B3B RID: 11067
			// (get) Token: 0x060092DF RID: 37599 RVA: 0x002722D0 File Offset: 0x002704D0
			// (set) Token: 0x060092E0 RID: 37600 RVA: 0x0003FBF7 File Offset: 0x0003DDF7
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalCarthagShadowAbility._DiscardTleilaxuCard_d__6.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalCarthagShadowAbility._DiscardTleilaxuCard_d__6.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x04005D95 RID: 23957
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005D96 RID: 23958
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04005D97 RID: 23959
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04005D98 RID: 23960
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04005D99 RID: 23961
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005D9A RID: 23962
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04005D9B RID: 23963
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04005D9C RID: 23964
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005D9D RID: 23965
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04005D9E RID: 23966
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04005D9F RID: 23967
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200097C RID: 2428
		[ObfuscatedName("worm.canis.abilities.HagalAbilities.Immortality.HagalCarthagShadowAbility+<GrantResources>d__5")]
		public sealed class _GrantResources_d__5 : Object
		{
			// Token: 0x060092E1 RID: 37601 RVA: 0x002722F8 File Offset: 0x002704F8
			// Note: this type is marked as 'beforefieldinit'.
			static _GrantResources_d__5()
			{
				Il2CppClassPointerStore<HagalCarthagShadowAbility._GrantResources_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HagalCarthagShadowAbility>.NativeClassPtr, "<GrantResources>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HagalCarthagShadowAbility._GrantResources_d__5>.NativeClassPtr);
				HagalCarthagShadowAbility._GrantResources_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalCarthagShadowAbility._GrantResources_d__5>.NativeClassPtr, "<>1__state");
				HagalCarthagShadowAbility._GrantResources_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalCarthagShadowAbility._GrantResources_d__5>.NativeClassPtr, "<>2__current");
				HagalCarthagShadowAbility._GrantResources_d__5.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalCarthagShadowAbility._GrantResources_d__5>.NativeClassPtr, "<>l__initialThreadId");
				HagalCarthagShadowAbility._GrantResources_d__5.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalCarthagShadowAbility._GrantResources_d__5>.NativeClassPtr, "context");
				HagalCarthagShadowAbility._GrantResources_d__5.NativeFieldInfoPtr___3__context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalCarthagShadowAbility._GrantResources_d__5>.NativeClassPtr, "<>3__context");
				HagalCarthagShadowAbility._GrantResources_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalCarthagShadowAbility._GrantResources_d__5>.NativeClassPtr, "<>4__this");
				HagalCarthagShadowAbility._GrantResources_d__5.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalCarthagShadowAbility._GrantResources_d__5>.NativeClassPtr, "match");
				HagalCarthagShadowAbility._GrantResources_d__5.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalCarthagShadowAbility._GrantResources_d__5>.NativeClassPtr, "<>3__match");
				HagalCarthagShadowAbility._GrantResources_d__5.NativeFieldInfoPtr__player_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalCarthagShadowAbility._GrantResources_d__5>.NativeClassPtr, "<player>5__2");
				HagalCarthagShadowAbility._GrantResources_d__5.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalCarthagShadowAbility._GrantResources_d__5>.NativeClassPtr, "<>7__wrap2");
				HagalCarthagShadowAbility._GrantResources_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalCarthagShadowAbility._GrantResources_d__5>.NativeClassPtr, 100675267);
				HagalCarthagShadowAbility._GrantResources_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalCarthagShadowAbility._GrantResources_d__5>.NativeClassPtr, 100675268);
				HagalCarthagShadowAbility._GrantResources_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalCarthagShadowAbility._GrantResources_d__5>.NativeClassPtr, 100675269);
				HagalCarthagShadowAbility._GrantResources_d__5.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalCarthagShadowAbility._GrantResources_d__5>.NativeClassPtr, 100675270);
				HagalCarthagShadowAbility._GrantResources_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalCarthagShadowAbility._GrantResources_d__5>.NativeClassPtr, 100675271);
				HagalCarthagShadowAbility._GrantResources_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalCarthagShadowAbility._GrantResources_d__5>.NativeClassPtr, 100675272);
				HagalCarthagShadowAbility._GrantResources_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalCarthagShadowAbility._GrantResources_d__5>.NativeClassPtr, 100675273);
				HagalCarthagShadowAbility._GrantResources_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalCarthagShadowAbility._GrantResources_d__5>.NativeClassPtr, 100675274);
				HagalCarthagShadowAbility._GrantResources_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalCarthagShadowAbility._GrantResources_d__5>.NativeClassPtr, 100675275);
			}

			// Token: 0x060092E2 RID: 37602 RVA: 0x002724A0 File Offset: 0x002706A0
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GrantResources_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HagalCarthagShadowAbility._GrantResources_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalCarthagShadowAbility._GrantResources_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060092E3 RID: 37603 RVA: 0x002724E8 File Offset: 0x002706E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200106, XrefRangeEnd = 200111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalCarthagShadowAbility._GrantResources_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060092E4 RID: 37604 RVA: 0x0027251C File Offset: 0x0027071C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200111, XrefRangeEnd = 200174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalCarthagShadowAbility._GrantResources_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060092E5 RID: 37605 RVA: 0x00272558 File Offset: 0x00270758
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200174, XrefRangeEnd = 200177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalCarthagShadowAbility._GrantResources_d__5.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002B48 RID: 11080
			// (get) Token: 0x060092E6 RID: 37606 RVA: 0x0027258C File Offset: 0x0027078C
			public unsafe Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalCarthagShadowAbility._GrantResources_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x060092E7 RID: 37607 RVA: 0x002725CC File Offset: 0x002707CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200177, XrefRangeEnd = 200182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalCarthagShadowAbility._GrantResources_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002B49 RID: 11081
			// (get) Token: 0x060092E8 RID: 37608 RVA: 0x00272600 File Offset: 0x00270800
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalCarthagShadowAbility._GrantResources_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060092E9 RID: 37609 RVA: 0x00272640 File Offset: 0x00270840
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200182, XrefRangeEnd = 200192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalCarthagShadowAbility._GrantResources_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x060092EA RID: 37610 RVA: 0x00272680 File Offset: 0x00270880
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalCarthagShadowAbility._GrantResources_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060092EB RID: 37611 RVA: 0x0003FC12 File Offset: 0x0003DE12
			public _GrantResources_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002B3E RID: 11070
			// (get) Token: 0x060092EC RID: 37612 RVA: 0x002726C0 File Offset: 0x002708C0
			// (set) Token: 0x060092ED RID: 37613 RVA: 0x0003FC1B File Offset: 0x0003DE1B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalCarthagShadowAbility._GrantResources_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalCarthagShadowAbility._GrantResources_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002B3F RID: 11071
			// (get) Token: 0x060092EE RID: 37614 RVA: 0x002726E8 File Offset: 0x002708E8
			// (set) Token: 0x060092EF RID: 37615 RVA: 0x0003FC36 File Offset: 0x0003DE36
			public unsafe Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalCarthagShadowAbility._GrantResources_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalCarthagShadowAbility._GrantResources_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B40 RID: 11072
			// (get) Token: 0x060092F0 RID: 37616 RVA: 0x00272718 File Offset: 0x00270918
			// (set) Token: 0x060092F1 RID: 37617 RVA: 0x0003FC55 File Offset: 0x0003DE55
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalCarthagShadowAbility._GrantResources_d__5.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalCarthagShadowAbility._GrantResources_d__5.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17002B41 RID: 11073
			// (get) Token: 0x060092F2 RID: 37618 RVA: 0x00272740 File Offset: 0x00270940
			// (set) Token: 0x060092F3 RID: 37619 RVA: 0x0003FC70 File Offset: 0x0003DE70
			public unsafe Context context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalCarthagShadowAbility._GrantResources_d__5.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalCarthagShadowAbility._GrantResources_d__5.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B42 RID: 11074
			// (get) Token: 0x060092F4 RID: 37620 RVA: 0x00272770 File Offset: 0x00270970
			// (set) Token: 0x060092F5 RID: 37621 RVA: 0x0003FC8F File Offset: 0x0003DE8F
			public unsafe Context __3__context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalCarthagShadowAbility._GrantResources_d__5.NativeFieldInfoPtr___3__context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalCarthagShadowAbility._GrantResources_d__5.NativeFieldInfoPtr___3__context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B43 RID: 11075
			// (get) Token: 0x060092F6 RID: 37622 RVA: 0x002727A0 File Offset: 0x002709A0
			// (set) Token: 0x060092F7 RID: 37623 RVA: 0x0003FCAE File Offset: 0x0003DEAE
			public unsafe HagalCarthagShadowAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalCarthagShadowAbility._GrantResources_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HagalCarthagShadowAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalCarthagShadowAbility._GrantResources_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B44 RID: 11076
			// (get) Token: 0x060092F8 RID: 37624 RVA: 0x002727D0 File Offset: 0x002709D0
			// (set) Token: 0x060092F9 RID: 37625 RVA: 0x0003FCCD File Offset: 0x0003DECD
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalCarthagShadowAbility._GrantResources_d__5.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalCarthagShadowAbility._GrantResources_d__5.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B45 RID: 11077
			// (get) Token: 0x060092FA RID: 37626 RVA: 0x00272800 File Offset: 0x00270A00
			// (set) Token: 0x060092FB RID: 37627 RVA: 0x0003FCEC File Offset: 0x0003DEEC
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalCarthagShadowAbility._GrantResources_d__5.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalCarthagShadowAbility._GrantResources_d__5.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B46 RID: 11078
			// (get) Token: 0x060092FC RID: 37628 RVA: 0x00272830 File Offset: 0x00270A30
			// (set) Token: 0x060092FD RID: 37629 RVA: 0x0003FD0B File Offset: 0x0003DF0B
			public unsafe WormPlayer _player_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalCarthagShadowAbility._GrantResources_d__5.NativeFieldInfoPtr__player_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalCarthagShadowAbility._GrantResources_d__5.NativeFieldInfoPtr__player_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B47 RID: 11079
			// (get) Token: 0x060092FE RID: 37630 RVA: 0x00272860 File Offset: 0x00270A60
			// (set) Token: 0x060092FF RID: 37631 RVA: 0x0003FD2A File Offset: 0x0003DF2A
			public unsafe IEnumerator<Canis.actions.Action> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalCarthagShadowAbility._GrantResources_d__5.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Canis.actions.Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalCarthagShadowAbility._GrantResources_d__5.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005DA0 RID: 23968
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005DA1 RID: 23969
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04005DA2 RID: 23970
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04005DA3 RID: 23971
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x04005DA4 RID: 23972
			private static readonly IntPtr NativeFieldInfoPtr___3__context;

			// Token: 0x04005DA5 RID: 23973
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005DA6 RID: 23974
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04005DA7 RID: 23975
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x04005DA8 RID: 23976
			private static readonly IntPtr NativeFieldInfoPtr__player_5__2;

			// Token: 0x04005DA9 RID: 23977
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x04005DAA RID: 23978
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04005DAB RID: 23979
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005DAC RID: 23980
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04005DAD RID: 23981
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04005DAE RID: 23982
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04005DAF RID: 23983
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005DB0 RID: 23984
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04005DB1 RID: 23985
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04005DB2 RID: 23986
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
