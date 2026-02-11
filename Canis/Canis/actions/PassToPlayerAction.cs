using System;
using Canis.entities;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Canis.actions
{
	// Token: 0x020001C8 RID: 456
	public class PassToPlayerAction : Action
	{
		// Token: 0x0600133B RID: 4923 RVA: 0x00067180 File Offset: 0x00065380
		// Note: this type is marked as 'beforefieldinit'.
		static PassToPlayerAction()
		{
			Il2CppClassPointerStore<PassToPlayerAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "PassToPlayerAction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PassToPlayerAction>.NativeClassPtr);
			PassToPlayerAction.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassToPlayerAction>.NativeClassPtr, "player");
			PassToPlayerAction.NativeFieldInfoPtr_players = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassToPlayerAction>.NativeClassPtr, "players");
			PassToPlayerAction.NativeFieldInfoPtr_forced = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassToPlayerAction>.NativeClassPtr, "forced");
			PassToPlayerAction.NativeMethodInfoPtr__ctor_Public_Void_PlayerEntity_Match_List_1_PlayerEntity_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassToPlayerAction>.NativeClassPtr, 100667451);
			PassToPlayerAction.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassToPlayerAction>.NativeClassPtr, 100667452);
		}

		// Token: 0x0600133C RID: 4924 RVA: 0x00067214 File Offset: 0x00065414
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 586667, RefRangeEnd = 586668, XrefRangeStart = 586663, XrefRangeEnd = 586667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PassToPlayerAction(PlayerEntity player, Match match, List<PlayerEntity> players, bool forced)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PassToPlayerAction>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(players);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forced;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PassToPlayerAction.NativeMethodInfoPtr__ctor_Public_Void_PlayerEntity_Match_List_1_PlayerEntity_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600133D RID: 4925 RVA: 0x00067294 File Offset: 0x00065494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 586668, XrefRangeEnd = 586674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PassToPlayerAction.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
		}

		// Token: 0x0600133E RID: 4926 RVA: 0x000096D4 File Offset: 0x000078D4
		public PassToPlayerAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x0600133F RID: 4927 RVA: 0x000672E0 File Offset: 0x000654E0
		// (set) Token: 0x06001340 RID: 4928 RVA: 0x000096DD File Offset: 0x000078DD
		public unsafe PlayerEntity player
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PassToPlayerAction.NativeFieldInfoPtr_player);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PassToPlayerAction.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06001341 RID: 4929 RVA: 0x00067310 File Offset: 0x00065510
		// (set) Token: 0x06001342 RID: 4930 RVA: 0x000096FC File Offset: 0x000078FC
		public unsafe List<PlayerEntity> players
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PassToPlayerAction.NativeFieldInfoPtr_players);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayerEntity>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PassToPlayerAction.NativeFieldInfoPtr_players), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06001343 RID: 4931 RVA: 0x00067340 File Offset: 0x00065540
		// (set) Token: 0x06001344 RID: 4932 RVA: 0x0000971B File Offset: 0x0000791B
		public unsafe bool forced
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PassToPlayerAction.NativeFieldInfoPtr_forced);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PassToPlayerAction.NativeFieldInfoPtr_forced)) = value;
			}
		}

		// Token: 0x04000C80 RID: 3200
		private static readonly IntPtr NativeFieldInfoPtr_player;

		// Token: 0x04000C81 RID: 3201
		private static readonly IntPtr NativeFieldInfoPtr_players;

		// Token: 0x04000C82 RID: 3202
		private static readonly IntPtr NativeFieldInfoPtr_forced;

		// Token: 0x04000C83 RID: 3203
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_PlayerEntity_Match_List_1_PlayerEntity_Boolean_0;

		// Token: 0x04000C84 RID: 3204
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x020003FC RID: 1020
		[ObfuscatedName("Canis.actions.PassToPlayerAction+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06002BFE RID: 11262 RVA: 0x000BAFA4 File Offset: 0x000B91A4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PassToPlayerAction.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PassToPlayerAction>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PassToPlayerAction.__c>.NativeClassPtr);
				PassToPlayerAction.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassToPlayerAction.__c>.NativeClassPtr, "<>9");
				PassToPlayerAction.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassToPlayerAction.__c>.NativeClassPtr, "<>9__4_0");
				PassToPlayerAction.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassToPlayerAction.__c>.NativeClassPtr, 100667454);
				PassToPlayerAction.__c.NativeMethodInfoPtr__execute_b__4_0_Internal_AccountID_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassToPlayerAction.__c>.NativeClassPtr, 100667455);
			}

			// Token: 0x06002BFF RID: 11263 RVA: 0x000BB020 File Offset: 0x000B9220
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PassToPlayerAction.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PassToPlayerAction.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002C00 RID: 11264 RVA: 0x000BB05C File Offset: 0x000B925C
			[CallerCount(0)]
			public unsafe AccountID _execute_b__4_0(PlayerEntity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PassToPlayerAction.__c.NativeMethodInfoPtr__execute_b__4_0_Internal_AccountID_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr3) : null;
				}
			}

			// Token: 0x06002C01 RID: 11265 RVA: 0x0001509C File Offset: 0x0001329C
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B49 RID: 2889
			// (get) Token: 0x06002C02 RID: 11266 RVA: 0x000BB0AC File Offset: 0x000B92AC
			// (set) Token: 0x06002C03 RID: 11267 RVA: 0x000150A5 File Offset: 0x000132A5
			public unsafe static PassToPlayerAction.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PassToPlayerAction.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PassToPlayerAction.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PassToPlayerAction.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B4A RID: 2890
			// (get) Token: 0x06002C04 RID: 11268 RVA: 0x000BB0D4 File Offset: 0x000B92D4
			// (set) Token: 0x06002C05 RID: 11269 RVA: 0x000150B7 File Offset: 0x000132B7
			public unsafe static Func<PlayerEntity, AccountID> __9__4_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PassToPlayerAction.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PlayerEntity, AccountID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PassToPlayerAction.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001B82 RID: 7042
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001B83 RID: 7043
			private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

			// Token: 0x04001B84 RID: 7044
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001B85 RID: 7045
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__4_0_Internal_AccountID_PlayerEntity_0;
		}

		// Token: 0x020003FD RID: 1021
		[ObfuscatedName("Canis.actions.PassToPlayerAction+<execute>d__4")]
		public sealed class _execute_d__4 : Object
		{
			// Token: 0x06002C06 RID: 11270 RVA: 0x000BB0FC File Offset: 0x000B92FC
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__4()
			{
				Il2CppClassPointerStore<PassToPlayerAction._execute_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PassToPlayerAction>.NativeClassPtr, "<execute>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PassToPlayerAction._execute_d__4>.NativeClassPtr);
				PassToPlayerAction._execute_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassToPlayerAction._execute_d__4>.NativeClassPtr, "<>1__state");
				PassToPlayerAction._execute_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassToPlayerAction._execute_d__4>.NativeClassPtr, "<>2__current");
				PassToPlayerAction._execute_d__4.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassToPlayerAction._execute_d__4>.NativeClassPtr, "<>l__initialThreadId");
				PassToPlayerAction._execute_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassToPlayerAction._execute_d__4>.NativeClassPtr, "<>4__this");
				PassToPlayerAction._execute_d__4.NativeFieldInfoPtr__playmat_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassToPlayerAction._execute_d__4>.NativeClassPtr, "<playmat>5__2");
				PassToPlayerAction._execute_d__4.NativeFieldInfoPtr__sequence_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassToPlayerAction._execute_d__4>.NativeClassPtr, "<sequence>5__3");
				PassToPlayerAction._execute_d__4.NativeFieldInfoPtr__name_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassToPlayerAction._execute_d__4>.NativeClassPtr, "<name>5__4");
				PassToPlayerAction._execute_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassToPlayerAction._execute_d__4>.NativeClassPtr, 100667456);
				PassToPlayerAction._execute_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassToPlayerAction._execute_d__4>.NativeClassPtr, 100667457);
				PassToPlayerAction._execute_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassToPlayerAction._execute_d__4>.NativeClassPtr, 100667458);
				PassToPlayerAction._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassToPlayerAction._execute_d__4>.NativeClassPtr, 100667459);
				PassToPlayerAction._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassToPlayerAction._execute_d__4>.NativeClassPtr, 100667460);
				PassToPlayerAction._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassToPlayerAction._execute_d__4>.NativeClassPtr, 100667461);
				PassToPlayerAction._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassToPlayerAction._execute_d__4>.NativeClassPtr, 100667462);
				PassToPlayerAction._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassToPlayerAction._execute_d__4>.NativeClassPtr, 100667463);
			}

			// Token: 0x06002C07 RID: 11271 RVA: 0x000BB254 File Offset: 0x000B9454
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PassToPlayerAction._execute_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PassToPlayerAction._execute_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002C08 RID: 11272 RVA: 0x000BB29C File Offset: 0x000B949C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PassToPlayerAction._execute_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002C09 RID: 11273 RVA: 0x000BB2D0 File Offset: 0x000B94D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 586565, XrefRangeEnd = 586656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PassToPlayerAction._execute_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000B52 RID: 2898
			// (get) Token: 0x06002C0A RID: 11274 RVA: 0x000BB30C File Offset: 0x000B950C
			public unsafe Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PassToPlayerAction._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
				}
			}

			// Token: 0x06002C0B RID: 11275 RVA: 0x000BB34C File Offset: 0x000B954C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 586656, XrefRangeEnd = 586661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PassToPlayerAction._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000B53 RID: 2899
			// (get) Token: 0x06002C0C RID: 11276 RVA: 0x000BB380 File Offset: 0x000B9580
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PassToPlayerAction._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002C0D RID: 11277 RVA: 0x000BB3C0 File Offset: 0x000B95C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 586661, XrefRangeEnd = 586663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PassToPlayerAction._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Action>>(intPtr3) : null;
			}

			// Token: 0x06002C0E RID: 11278 RVA: 0x000BB400 File Offset: 0x000B9600
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PassToPlayerAction._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06002C0F RID: 11279 RVA: 0x000150C9 File Offset: 0x000132C9
			public _execute_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B4B RID: 2891
			// (get) Token: 0x06002C10 RID: 11280 RVA: 0x000BB440 File Offset: 0x000B9640
			// (set) Token: 0x06002C11 RID: 11281 RVA: 0x000150D2 File Offset: 0x000132D2
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PassToPlayerAction._execute_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PassToPlayerAction._execute_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000B4C RID: 2892
			// (get) Token: 0x06002C12 RID: 11282 RVA: 0x000BB468 File Offset: 0x000B9668
			// (set) Token: 0x06002C13 RID: 11283 RVA: 0x000150ED File Offset: 0x000132ED
			public unsafe Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PassToPlayerAction._execute_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PassToPlayerAction._execute_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B4D RID: 2893
			// (get) Token: 0x06002C14 RID: 11284 RVA: 0x000BB498 File Offset: 0x000B9698
			// (set) Token: 0x06002C15 RID: 11285 RVA: 0x0001510C File Offset: 0x0001330C
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PassToPlayerAction._execute_d__4.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PassToPlayerAction._execute_d__4.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000B4E RID: 2894
			// (get) Token: 0x06002C16 RID: 11286 RVA: 0x000BB4C0 File Offset: 0x000B96C0
			// (set) Token: 0x06002C17 RID: 11287 RVA: 0x00015127 File Offset: 0x00013327
			public unsafe PassToPlayerAction __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PassToPlayerAction._execute_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PassToPlayerAction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PassToPlayerAction._execute_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B4F RID: 2895
			// (get) Token: 0x06002C18 RID: 11288 RVA: 0x000BB4F0 File Offset: 0x000B96F0
			// (set) Token: 0x06002C19 RID: 11289 RVA: 0x00015146 File Offset: 0x00013346
			public unsafe Entity _playmat_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PassToPlayerAction._execute_d__4.NativeFieldInfoPtr__playmat_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PassToPlayerAction._execute_d__4.NativeFieldInfoPtr__playmat_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B50 RID: 2896
			// (get) Token: 0x06002C1A RID: 11290 RVA: 0x000BB520 File Offset: 0x000B9720
			// (set) Token: 0x06002C1B RID: 11291 RVA: 0x00015165 File Offset: 0x00013365
			public unsafe SequenceHelper _sequence_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PassToPlayerAction._execute_d__4.NativeFieldInfoPtr__sequence_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceHelper>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PassToPlayerAction._execute_d__4.NativeFieldInfoPtr__sequence_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B51 RID: 2897
			// (get) Token: 0x06002C1C RID: 11292 RVA: 0x000BB550 File Offset: 0x000B9750
			// (set) Token: 0x06002C1D RID: 11293 RVA: 0x00015184 File Offset: 0x00013384
			public unsafe string _name_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PassToPlayerAction._execute_d__4.NativeFieldInfoPtr__name_5__4);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PassToPlayerAction._execute_d__4.NativeFieldInfoPtr__name_5__4), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04001B86 RID: 7046
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001B87 RID: 7047
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001B88 RID: 7048
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001B89 RID: 7049
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001B8A RID: 7050
			private static readonly IntPtr NativeFieldInfoPtr__playmat_5__2;

			// Token: 0x04001B8B RID: 7051
			private static readonly IntPtr NativeFieldInfoPtr__sequence_5__3;

			// Token: 0x04001B8C RID: 7052
			private static readonly IntPtr NativeFieldInfoPtr__name_5__4;

			// Token: 0x04001B8D RID: 7053
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001B8E RID: 7054
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001B8F RID: 7055
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001B90 RID: 7056
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04001B91 RID: 7057
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001B92 RID: 7058
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001B93 RID: 7059
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04001B94 RID: 7060
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
