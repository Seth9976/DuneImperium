using System;
using Canis.entities;
using Canis.events;
using Canis.messages;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.canis.data.enums;

namespace worm.canis.abilities.TriggeredAbilities
{
	// Token: 0x0200031D RID: 797
	public class AllianceAbility : TriggeredAbility
	{
		// Token: 0x0600207F RID: 8319 RVA: 0x000D8700 File Offset: 0x000D6900
		// Note: this type is marked as 'beforefieldinit'.
		static AllianceAbility()
		{
			Il2CppClassPointerStore<AllianceAbility>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.TriggeredAbilities", "AllianceAbility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AllianceAbility>.NativeClassPtr);
			AllianceAbility.NativeMethodInfoPtr__ctor_Protected_Void_WormMatch_String_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllianceAbility>.NativeClassPtr, 100671245);
			AllianceAbility.NativeMethodInfoPtr__ctor_Protected_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllianceAbility>.NativeClassPtr, 100671246);
			AllianceAbility.NativeMethodInfoPtr_get_AllianceFaction_Public_Abstract_Virtual_New_get_Factions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllianceAbility>.NativeClassPtr, 100671247);
			AllianceAbility.NativeMethodInfoPtr_get_ShouldExhaust_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllianceAbility>.NativeClassPtr, 100671248);
			AllianceAbility.NativeMethodInfoPtr_IsValidFor_Public_Virtual_Final_IEnumerable_1_PlayerEntity_SerializableEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllianceAbility>.NativeClassPtr, 100671249);
		}

		// Token: 0x06002080 RID: 8320 RVA: 0x000D8794 File Offset: 0x000D6994
		[CallerCount(154)]
		[CachedScanResults(RefRangeStart = 176120, RefRangeEnd = 176274, XrefRangeStart = 176119, XrefRangeEnd = 176120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AllianceAbility(WormMatch m, string name = "", PlayerEntity owningPlayer = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AllianceAbility>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owningPlayer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllianceAbility.NativeMethodInfoPtr__ctor_Protected_Void_WormMatch_String_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002081 RID: 8321 RVA: 0x000D8804 File Offset: 0x000D6A04
		[CallerCount(314)]
		[CachedScanResults(RefRangeStart = 176275, RefRangeEnd = 176589, XrefRangeStart = 176274, XrefRangeEnd = 176275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AllianceAbility(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AllianceAbility>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllianceAbility.NativeMethodInfoPtr__ctor_Protected_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000A1E RID: 2590
		// (get) Token: 0x06002082 RID: 8322 RVA: 0x000D8874 File Offset: 0x000D6A74
		public unsafe virtual Factions AllianceFaction
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AllianceAbility.NativeMethodInfoPtr_get_AllianceFaction_Public_Abstract_Virtual_New_get_Factions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A1F RID: 2591
		// (get) Token: 0x06002083 RID: 8323 RVA: 0x000D88BC File Offset: 0x000D6ABC
		public unsafe override bool ShouldExhaust
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AllianceAbility.NativeMethodInfoPtr_get_ShouldExhaust_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002084 RID: 8324 RVA: 0x000D8904 File Offset: 0x000D6B04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176589, XrefRangeEnd = 176596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<PlayerEntity> IsValidFor(SerializableEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllianceAbility.NativeMethodInfoPtr_IsValidFor_Public_Virtual_Final_IEnumerable_1_PlayerEntity_SerializableEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<PlayerEntity>>(intPtr3) : null;
			}
		}

		// Token: 0x06002085 RID: 8325 RVA: 0x0000D68A File Offset: 0x0000B88A
		public AllianceAbility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001480 RID: 5248
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_WormMatch_String_PlayerEntity_0;

		// Token: 0x04001481 RID: 5249
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x04001482 RID: 5250
		private static readonly IntPtr NativeMethodInfoPtr_get_AllianceFaction_Public_Abstract_Virtual_New_get_Factions_0;

		// Token: 0x04001483 RID: 5251
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldExhaust_Public_Virtual_get_Boolean_0;

		// Token: 0x04001484 RID: 5252
		private static readonly IntPtr NativeMethodInfoPtr_IsValidFor_Public_Virtual_Final_IEnumerable_1_PlayerEntity_SerializableEvent_0;

		// Token: 0x020007DB RID: 2011
		[ObfuscatedName("worm.canis.abilities.TriggeredAbilities.AllianceAbility+<IsValidFor>d__6")]
		public sealed class _IsValidFor_d__6 : Object
		{
			// Token: 0x060071BF RID: 29119 RVA: 0x00210284 File Offset: 0x0020E484
			// Note: this type is marked as 'beforefieldinit'.
			static _IsValidFor_d__6()
			{
				Il2CppClassPointerStore<AllianceAbility._IsValidFor_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AllianceAbility>.NativeClassPtr, "<IsValidFor>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AllianceAbility._IsValidFor_d__6>.NativeClassPtr);
				AllianceAbility._IsValidFor_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllianceAbility._IsValidFor_d__6>.NativeClassPtr, "<>1__state");
				AllianceAbility._IsValidFor_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllianceAbility._IsValidFor_d__6>.NativeClassPtr, "<>2__current");
				AllianceAbility._IsValidFor_d__6.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllianceAbility._IsValidFor_d__6>.NativeClassPtr, "<>l__initialThreadId");
				AllianceAbility._IsValidFor_d__6.NativeFieldInfoPtr_evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllianceAbility._IsValidFor_d__6>.NativeClassPtr, "evt");
				AllianceAbility._IsValidFor_d__6.NativeFieldInfoPtr___3__evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllianceAbility._IsValidFor_d__6>.NativeClassPtr, "<>3__evt");
				AllianceAbility._IsValidFor_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllianceAbility._IsValidFor_d__6>.NativeClassPtr, "<>4__this");
				AllianceAbility._IsValidFor_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllianceAbility._IsValidFor_d__6>.NativeClassPtr, 100671250);
				AllianceAbility._IsValidFor_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllianceAbility._IsValidFor_d__6>.NativeClassPtr, 100671251);
				AllianceAbility._IsValidFor_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllianceAbility._IsValidFor_d__6>.NativeClassPtr, 100671252);
				AllianceAbility._IsValidFor_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_PlayerEntity__get_Current_Private_Virtual_Final_New_get_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllianceAbility._IsValidFor_d__6>.NativeClassPtr, 100671253);
				AllianceAbility._IsValidFor_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllianceAbility._IsValidFor_d__6>.NativeClassPtr, 100671254);
				AllianceAbility._IsValidFor_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllianceAbility._IsValidFor_d__6>.NativeClassPtr, 100671255);
				AllianceAbility._IsValidFor_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllianceAbility._IsValidFor_d__6>.NativeClassPtr, 100671256);
				AllianceAbility._IsValidFor_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllianceAbility._IsValidFor_d__6>.NativeClassPtr, 100671257);
			}

			// Token: 0x060071C0 RID: 29120 RVA: 0x002103C8 File Offset: 0x0020E5C8
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _IsValidFor_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AllianceAbility._IsValidFor_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllianceAbility._IsValidFor_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060071C1 RID: 29121 RVA: 0x00210410 File Offset: 0x0020E610
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllianceAbility._IsValidFor_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060071C2 RID: 29122 RVA: 0x00210444 File Offset: 0x0020E644
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176083, XrefRangeEnd = 176105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllianceAbility._IsValidFor_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001F4D RID: 8013
			// (get) Token: 0x060071C3 RID: 29123 RVA: 0x00210480 File Offset: 0x0020E680
			public unsafe PlayerEntity System.Collections.Generic.IEnumerator<Canis.entities.PlayerEntity>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllianceAbility._IsValidFor_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_PlayerEntity__get_Current_Private_Virtual_Final_New_get_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr3) : null;
				}
			}

			// Token: 0x060071C4 RID: 29124 RVA: 0x002104C0 File Offset: 0x0020E6C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176105, XrefRangeEnd = 176110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllianceAbility._IsValidFor_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001F4E RID: 8014
			// (get) Token: 0x060071C5 RID: 29125 RVA: 0x002104F4 File Offset: 0x0020E6F4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllianceAbility._IsValidFor_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060071C6 RID: 29126 RVA: 0x00210534 File Offset: 0x0020E734
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176110, XrefRangeEnd = 176119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<PlayerEntity> System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllianceAbility._IsValidFor_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<PlayerEntity>>(intPtr3) : null;
			}

			// Token: 0x060071C7 RID: 29127 RVA: 0x00210574 File Offset: 0x0020E774
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllianceAbility._IsValidFor_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060071C8 RID: 29128 RVA: 0x0002D2EC File Offset: 0x0002B4EC
			public _IsValidFor_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001F47 RID: 8007
			// (get) Token: 0x060071C9 RID: 29129 RVA: 0x002105B4 File Offset: 0x0020E7B4
			// (set) Token: 0x060071CA RID: 29130 RVA: 0x0002D2F5 File Offset: 0x0002B4F5
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllianceAbility._IsValidFor_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllianceAbility._IsValidFor_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001F48 RID: 8008
			// (get) Token: 0x060071CB RID: 29131 RVA: 0x002105DC File Offset: 0x0020E7DC
			// (set) Token: 0x060071CC RID: 29132 RVA: 0x0002D310 File Offset: 0x0002B510
			public unsafe PlayerEntity __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllianceAbility._IsValidFor_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllianceAbility._IsValidFor_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001F49 RID: 8009
			// (get) Token: 0x060071CD RID: 29133 RVA: 0x0021060C File Offset: 0x0020E80C
			// (set) Token: 0x060071CE RID: 29134 RVA: 0x0002D32F File Offset: 0x0002B52F
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllianceAbility._IsValidFor_d__6.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllianceAbility._IsValidFor_d__6.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001F4A RID: 8010
			// (get) Token: 0x060071CF RID: 29135 RVA: 0x00210634 File Offset: 0x0020E834
			// (set) Token: 0x060071D0 RID: 29136 RVA: 0x0002D34A File Offset: 0x0002B54A
			public unsafe SerializableEvent evt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllianceAbility._IsValidFor_d__6.NativeFieldInfoPtr_evt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllianceAbility._IsValidFor_d__6.NativeFieldInfoPtr_evt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001F4B RID: 8011
			// (get) Token: 0x060071D1 RID: 29137 RVA: 0x00210664 File Offset: 0x0020E864
			// (set) Token: 0x060071D2 RID: 29138 RVA: 0x0002D369 File Offset: 0x0002B569
			public unsafe SerializableEvent __3__evt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllianceAbility._IsValidFor_d__6.NativeFieldInfoPtr___3__evt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllianceAbility._IsValidFor_d__6.NativeFieldInfoPtr___3__evt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001F4C RID: 8012
			// (get) Token: 0x060071D3 RID: 29139 RVA: 0x00210694 File Offset: 0x0020E894
			// (set) Token: 0x060071D4 RID: 29140 RVA: 0x0002D388 File Offset: 0x0002B588
			public unsafe AllianceAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllianceAbility._IsValidFor_d__6.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AllianceAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllianceAbility._IsValidFor_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004979 RID: 18809
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400497A RID: 18810
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400497B RID: 18811
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400497C RID: 18812
			private static readonly IntPtr NativeFieldInfoPtr_evt;

			// Token: 0x0400497D RID: 18813
			private static readonly IntPtr NativeFieldInfoPtr___3__evt;

			// Token: 0x0400497E RID: 18814
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400497F RID: 18815
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04004980 RID: 18816
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004981 RID: 18817
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04004982 RID: 18818
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_PlayerEntity__get_Current_Private_Virtual_Final_New_get_PlayerEntity_0;

			// Token: 0x04004983 RID: 18819
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004984 RID: 18820
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04004985 RID: 18821
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_PlayerEntity_0;

			// Token: 0x04004986 RID: 18822
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
