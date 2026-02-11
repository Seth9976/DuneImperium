using System;
using boardgames.match.selection;
using Canis.utils.ids;
using dwd.core.match.selection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace worm.match.commands.selectionCommands
{
	// Token: 0x02000278 RID: 632
	public class WormCombatSelectionCommand : DBGBasicEntityListSelectionCommand
	{
		// Token: 0x060019E2 RID: 6626 RVA: 0x000676E0 File Offset: 0x000658E0
		// Note: this type is marked as 'beforefieldinit'.
		static WormCombatSelectionCommand()
		{
			Il2CppClassPointerStore<WormCombatSelectionCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.commands.selectionCommands", "WormCombatSelectionCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormCombatSelectionCommand>.NativeClassPtr);
			WormCombatSelectionCommand.NativeFieldInfoPtr_selectableAbilities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormCombatSelectionCommand>.NativeClassPtr, "selectableAbilities");
			WormCombatSelectionCommand.NativeMethodInfoPtr_get_SelectableAbilities_Public_Virtual_Final_New_get_IEnumerable_1_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCombatSelectionCommand>.NativeClassPtr, 100667049);
			WormCombatSelectionCommand.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCombatSelectionCommand>.NativeClassPtr, 100667050);
			WormCombatSelectionCommand.NativeMethodInfoPtr_idle_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCombatSelectionCommand>.NativeClassPtr, 100667051);
			WormCombatSelectionCommand.NativeMethodInfoPtr_exitNode_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCombatSelectionCommand>.NativeClassPtr, 100667052);
			WormCombatSelectionCommand.NativeMethodInfoPtr___n__0_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCombatSelectionCommand>.NativeClassPtr, 100667053);
		}

		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x060019E3 RID: 6627 RVA: 0x00067788 File Offset: 0x00065988
		public unsafe virtual IEnumerable<EntityID> SelectableAbilities
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCombatSelectionCommand.NativeMethodInfoPtr_get_SelectableAbilities_Public_Virtual_Final_New_get_IEnumerable_1_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<EntityID>>(intPtr3) : null;
			}
		}

		// Token: 0x060019E4 RID: 6628 RVA: 0x000677C8 File Offset: 0x000659C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 721584, XrefRangeEnd = 721620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormCombatSelectionCommand(ISelectionNode node, bool fromCancel)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormCombatSelectionCommand>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromCancel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCombatSelectionCommand.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019E5 RID: 6629 RVA: 0x00067824 File Offset: 0x00065A24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 721620, XrefRangeEnd = 721625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator idle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormCombatSelectionCommand.NativeMethodInfoPtr_idle_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060019E6 RID: 6630 RVA: 0x00067870 File Offset: 0x00065A70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 721625, XrefRangeEnd = 721635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void exitNode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormCombatSelectionCommand.NativeMethodInfoPtr_exitNode_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019E7 RID: 6631 RVA: 0x000678AC File Offset: 0x00065AAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator __n__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCombatSelectionCommand.NativeMethodInfoPtr___n__0_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060019E8 RID: 6632 RVA: 0x0000F296 File Offset: 0x0000D496
		public WormCombatSelectionCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x060019E9 RID: 6633 RVA: 0x000678EC File Offset: 0x00065AEC
		// (set) Token: 0x060019EA RID: 6634 RVA: 0x0000F29F File Offset: 0x0000D49F
		public unsafe List<EntityID> selectableAbilities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCombatSelectionCommand.NativeFieldInfoPtr_selectableAbilities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EntityID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCombatSelectionCommand.NativeFieldInfoPtr_selectableAbilities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000EF0 RID: 3824
		private static readonly IntPtr NativeFieldInfoPtr_selectableAbilities;

		// Token: 0x04000EF1 RID: 3825
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectableAbilities_Public_Virtual_Final_New_get_IEnumerable_1_EntityID_0;

		// Token: 0x04000EF2 RID: 3826
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0;

		// Token: 0x04000EF3 RID: 3827
		private static readonly IntPtr NativeMethodInfoPtr_idle_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000EF4 RID: 3828
		private static readonly IntPtr NativeMethodInfoPtr_exitNode_Protected_Virtual_Void_0;

		// Token: 0x04000EF5 RID: 3829
		private static readonly IntPtr NativeMethodInfoPtr___n__0_Private_IEnumerator_0;

		// Token: 0x02000429 RID: 1065
		[ObfuscatedName("worm.match.commands.selectionCommands.WormCombatSelectionCommand+<idle>d__4")]
		public sealed class _idle_d__4 : Object
		{
			// Token: 0x06002C2D RID: 11309 RVA: 0x0009DFBC File Offset: 0x0009C1BC
			// Note: this type is marked as 'beforefieldinit'.
			static _idle_d__4()
			{
				Il2CppClassPointerStore<WormCombatSelectionCommand._idle_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormCombatSelectionCommand>.NativeClassPtr, "<idle>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormCombatSelectionCommand._idle_d__4>.NativeClassPtr);
				WormCombatSelectionCommand._idle_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormCombatSelectionCommand._idle_d__4>.NativeClassPtr, "<>1__state");
				WormCombatSelectionCommand._idle_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormCombatSelectionCommand._idle_d__4>.NativeClassPtr, "<>2__current");
				WormCombatSelectionCommand._idle_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormCombatSelectionCommand._idle_d__4>.NativeClassPtr, "<>4__this");
				WormCombatSelectionCommand._idle_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCombatSelectionCommand._idle_d__4>.NativeClassPtr, 100667054);
				WormCombatSelectionCommand._idle_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCombatSelectionCommand._idle_d__4>.NativeClassPtr, 100667055);
				WormCombatSelectionCommand._idle_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCombatSelectionCommand._idle_d__4>.NativeClassPtr, 100667056);
				WormCombatSelectionCommand._idle_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCombatSelectionCommand._idle_d__4>.NativeClassPtr, 100667057);
				WormCombatSelectionCommand._idle_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCombatSelectionCommand._idle_d__4>.NativeClassPtr, 100667058);
				WormCombatSelectionCommand._idle_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCombatSelectionCommand._idle_d__4>.NativeClassPtr, 100667059);
			}

			// Token: 0x06002C2E RID: 11310 RVA: 0x0009E09C File Offset: 0x0009C29C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _idle_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormCombatSelectionCommand._idle_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCombatSelectionCommand._idle_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002C2F RID: 11311 RVA: 0x0009E0E4 File Offset: 0x0009C2E4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCombatSelectionCommand._idle_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002C30 RID: 11312 RVA: 0x0009E118 File Offset: 0x0009C318
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 721577, XrefRangeEnd = 721579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCombatSelectionCommand._idle_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000CA8 RID: 3240
			// (get) Token: 0x06002C31 RID: 11313 RVA: 0x0009E154 File Offset: 0x0009C354
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCombatSelectionCommand._idle_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002C32 RID: 11314 RVA: 0x0009E194 File Offset: 0x0009C394
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 721579, XrefRangeEnd = 721584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCombatSelectionCommand._idle_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000CA9 RID: 3241
			// (get) Token: 0x06002C33 RID: 11315 RVA: 0x0009E1C8 File Offset: 0x0009C3C8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCombatSelectionCommand._idle_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002C34 RID: 11316 RVA: 0x0001803A File Offset: 0x0001623A
			public _idle_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000CA5 RID: 3237
			// (get) Token: 0x06002C35 RID: 11317 RVA: 0x0009E208 File Offset: 0x0009C408
			// (set) Token: 0x06002C36 RID: 11318 RVA: 0x00018043 File Offset: 0x00016243
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCombatSelectionCommand._idle_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCombatSelectionCommand._idle_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000CA6 RID: 3238
			// (get) Token: 0x06002C37 RID: 11319 RVA: 0x0009E230 File Offset: 0x0009C430
			// (set) Token: 0x06002C38 RID: 11320 RVA: 0x0001805E File Offset: 0x0001625E
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCombatSelectionCommand._idle_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCombatSelectionCommand._idle_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CA7 RID: 3239
			// (get) Token: 0x06002C39 RID: 11321 RVA: 0x0009E260 File Offset: 0x0009C460
			// (set) Token: 0x06002C3A RID: 11322 RVA: 0x0001807D File Offset: 0x0001627D
			public unsafe WormCombatSelectionCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCombatSelectionCommand._idle_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormCombatSelectionCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCombatSelectionCommand._idle_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040019B0 RID: 6576
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040019B1 RID: 6577
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040019B2 RID: 6578
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040019B3 RID: 6579
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040019B4 RID: 6580
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040019B5 RID: 6581
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040019B6 RID: 6582
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040019B7 RID: 6583
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040019B8 RID: 6584
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
