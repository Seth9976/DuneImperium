using System;
using Canis.actions;
using Canis.entities;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Canis.winConditions
{
	// Token: 0x02000032 RID: 50
	public class OrWinCondition : IWinCondition
	{
		// Token: 0x06000340 RID: 832 RVA: 0x000264A8 File Offset: 0x000246A8
		// Note: this type is marked as 'beforefieldinit'.
		static OrWinCondition()
		{
			Il2CppClassPointerStore<OrWinCondition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.winConditions", "OrWinCondition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OrWinCondition>.NativeClassPtr);
			OrWinCondition.NativeFieldInfoPtr_fst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrWinCondition>.NativeClassPtr, "fst");
			OrWinCondition.NativeFieldInfoPtr_snd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrWinCondition>.NativeClassPtr, "snd");
			OrWinCondition.NativeMethodInfoPtr__ctor_Public_Void_IWinCondition_IWinCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrWinCondition>.NativeClassPtr, 100663981);
			OrWinCondition.NativeMethodInfoPtr_DidWin_Public_Virtual_Boolean_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrWinCondition>.NativeClassPtr, 100663982);
			OrWinCondition.NativeMethodInfoPtr_ExtraActions_Public_Virtual_IEnumerable_1_Action_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrWinCondition>.NativeClassPtr, 100663983);
		}

		// Token: 0x06000341 RID: 833 RVA: 0x0002653C File Offset: 0x0002473C
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 296744, RefRangeEnd = 296798, XrefRangeStart = 296744, XrefRangeEnd = 296798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OrWinCondition(IWinCondition fst, IWinCondition snd)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OrWinCondition>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fst);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(snd);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrWinCondition.NativeMethodInfoPtr__ctor_Public_Void_IWinCondition_IWinCondition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000342 RID: 834 RVA: 0x0002659C File Offset: 0x0002479C
		[CallerCount(0)]
		public unsafe override bool DidWin(PlayerEntity player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OrWinCondition.NativeMethodInfoPtr_DidWin_Public_Virtual_Boolean_PlayerEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000343 RID: 835 RVA: 0x000265F4 File Offset: 0x000247F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 549651, XrefRangeEnd = 549658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<Canis.actions.Action> ExtraActions(PlayerEntity player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OrWinCondition.NativeMethodInfoPtr_ExtraActions_Public_Virtual_IEnumerable_1_Action_PlayerEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Canis.actions.Action>>(intPtr3) : null;
			}
		}

		// Token: 0x06000344 RID: 836 RVA: 0x0000373F File Offset: 0x0000193F
		public OrWinCondition(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000345 RID: 837 RVA: 0x00026650 File Offset: 0x00024850
		// (set) Token: 0x06000346 RID: 838 RVA: 0x00003748 File Offset: 0x00001948
		public unsafe IWinCondition fst
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrWinCondition.NativeFieldInfoPtr_fst);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IWinCondition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrWinCondition.NativeFieldInfoPtr_fst), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000347 RID: 839 RVA: 0x00026680 File Offset: 0x00024880
		// (set) Token: 0x06000348 RID: 840 RVA: 0x00003767 File Offset: 0x00001967
		public unsafe IWinCondition snd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrWinCondition.NativeFieldInfoPtr_snd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IWinCondition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrWinCondition.NativeFieldInfoPtr_snd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000226 RID: 550
		private static readonly IntPtr NativeFieldInfoPtr_fst;

		// Token: 0x04000227 RID: 551
		private static readonly IntPtr NativeFieldInfoPtr_snd;

		// Token: 0x04000228 RID: 552
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IWinCondition_IWinCondition_0;

		// Token: 0x04000229 RID: 553
		private static readonly IntPtr NativeMethodInfoPtr_DidWin_Public_Virtual_Boolean_PlayerEntity_0;

		// Token: 0x0400022A RID: 554
		private static readonly IntPtr NativeMethodInfoPtr_ExtraActions_Public_Virtual_IEnumerable_1_Action_PlayerEntity_0;

		// Token: 0x02000280 RID: 640
		[ObfuscatedName("Canis.winConditions.OrWinCondition+<ExtraActions>d__4")]
		public sealed class _ExtraActions_d__4 : Object
		{
			// Token: 0x06001B1A RID: 6938 RVA: 0x000831EC File Offset: 0x000813EC
			// Note: this type is marked as 'beforefieldinit'.
			static _ExtraActions_d__4()
			{
				Il2CppClassPointerStore<OrWinCondition._ExtraActions_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OrWinCondition>.NativeClassPtr, "<ExtraActions>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OrWinCondition._ExtraActions_d__4>.NativeClassPtr);
				OrWinCondition._ExtraActions_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrWinCondition._ExtraActions_d__4>.NativeClassPtr, "<>1__state");
				OrWinCondition._ExtraActions_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrWinCondition._ExtraActions_d__4>.NativeClassPtr, "<>2__current");
				OrWinCondition._ExtraActions_d__4.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrWinCondition._ExtraActions_d__4>.NativeClassPtr, "<>l__initialThreadId");
				OrWinCondition._ExtraActions_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrWinCondition._ExtraActions_d__4>.NativeClassPtr, "<>4__this");
				OrWinCondition._ExtraActions_d__4.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrWinCondition._ExtraActions_d__4>.NativeClassPtr, "player");
				OrWinCondition._ExtraActions_d__4.NativeFieldInfoPtr___3__player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrWinCondition._ExtraActions_d__4>.NativeClassPtr, "<>3__player");
				OrWinCondition._ExtraActions_d__4.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrWinCondition._ExtraActions_d__4>.NativeClassPtr, "<>7__wrap1");
				OrWinCondition._ExtraActions_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrWinCondition._ExtraActions_d__4>.NativeClassPtr, 100663984);
				OrWinCondition._ExtraActions_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrWinCondition._ExtraActions_d__4>.NativeClassPtr, 100663985);
				OrWinCondition._ExtraActions_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrWinCondition._ExtraActions_d__4>.NativeClassPtr, 100663986);
				OrWinCondition._ExtraActions_d__4.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrWinCondition._ExtraActions_d__4>.NativeClassPtr, 100663987);
				OrWinCondition._ExtraActions_d__4.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrWinCondition._ExtraActions_d__4>.NativeClassPtr, 100663988);
				OrWinCondition._ExtraActions_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrWinCondition._ExtraActions_d__4>.NativeClassPtr, 100663989);
				OrWinCondition._ExtraActions_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrWinCondition._ExtraActions_d__4>.NativeClassPtr, 100663990);
				OrWinCondition._ExtraActions_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrWinCondition._ExtraActions_d__4>.NativeClassPtr, 100663991);
				OrWinCondition._ExtraActions_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrWinCondition._ExtraActions_d__4>.NativeClassPtr, 100663992);
				OrWinCondition._ExtraActions_d__4.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrWinCondition._ExtraActions_d__4>.NativeClassPtr, 100663993);
			}

			// Token: 0x06001B1B RID: 6939 RVA: 0x0008336C File Offset: 0x0008156C
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ExtraActions_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OrWinCondition._ExtraActions_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrWinCondition._ExtraActions_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001B1C RID: 6940 RVA: 0x000833B4 File Offset: 0x000815B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 549587, XrefRangeEnd = 549597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrWinCondition._ExtraActions_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B1D RID: 6941 RVA: 0x000833E8 File Offset: 0x000815E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 549597, XrefRangeEnd = 549631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrWinCondition._ExtraActions_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001B1E RID: 6942 RVA: 0x00083424 File Offset: 0x00081624
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 549631, XrefRangeEnd = 549634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrWinCondition._ExtraActions_d__4.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B1F RID: 6943 RVA: 0x00083458 File Offset: 0x00081658
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 549634, XrefRangeEnd = 549637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrWinCondition._ExtraActions_d__4.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000632 RID: 1586
			// (get) Token: 0x06001B20 RID: 6944 RVA: 0x0008348C File Offset: 0x0008168C
			public unsafe Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrWinCondition._ExtraActions_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06001B21 RID: 6945 RVA: 0x000834CC File Offset: 0x000816CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 549637, XrefRangeEnd = 549642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrWinCondition._ExtraActions_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000633 RID: 1587
			// (get) Token: 0x06001B22 RID: 6946 RVA: 0x00083500 File Offset: 0x00081700
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrWinCondition._ExtraActions_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001B23 RID: 6947 RVA: 0x00083540 File Offset: 0x00081740
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 549642, XrefRangeEnd = 549651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrWinCondition._ExtraActions_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06001B24 RID: 6948 RVA: 0x00083580 File Offset: 0x00081780
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrWinCondition._ExtraActions_d__4.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06001B25 RID: 6949 RVA: 0x0000CF27 File Offset: 0x0000B127
			public _ExtraActions_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700062B RID: 1579
			// (get) Token: 0x06001B26 RID: 6950 RVA: 0x000835C0 File Offset: 0x000817C0
			// (set) Token: 0x06001B27 RID: 6951 RVA: 0x0000CF30 File Offset: 0x0000B130
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrWinCondition._ExtraActions_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrWinCondition._ExtraActions_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700062C RID: 1580
			// (get) Token: 0x06001B28 RID: 6952 RVA: 0x000835E8 File Offset: 0x000817E8
			// (set) Token: 0x06001B29 RID: 6953 RVA: 0x0000CF4B File Offset: 0x0000B14B
			public unsafe Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrWinCondition._ExtraActions_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrWinCondition._ExtraActions_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700062D RID: 1581
			// (get) Token: 0x06001B2A RID: 6954 RVA: 0x00083618 File Offset: 0x00081818
			// (set) Token: 0x06001B2B RID: 6955 RVA: 0x0000CF6A File Offset: 0x0000B16A
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrWinCondition._ExtraActions_d__4.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrWinCondition._ExtraActions_d__4.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700062E RID: 1582
			// (get) Token: 0x06001B2C RID: 6956 RVA: 0x00083640 File Offset: 0x00081840
			// (set) Token: 0x06001B2D RID: 6957 RVA: 0x0000CF85 File Offset: 0x0000B185
			public unsafe OrWinCondition __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrWinCondition._ExtraActions_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OrWinCondition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrWinCondition._ExtraActions_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700062F RID: 1583
			// (get) Token: 0x06001B2E RID: 6958 RVA: 0x00083670 File Offset: 0x00081870
			// (set) Token: 0x06001B2F RID: 6959 RVA: 0x0000CFA4 File Offset: 0x0000B1A4
			public unsafe PlayerEntity player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrWinCondition._ExtraActions_d__4.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrWinCondition._ExtraActions_d__4.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000630 RID: 1584
			// (get) Token: 0x06001B30 RID: 6960 RVA: 0x000836A0 File Offset: 0x000818A0
			// (set) Token: 0x06001B31 RID: 6961 RVA: 0x0000CFC3 File Offset: 0x0000B1C3
			public unsafe PlayerEntity __3__player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrWinCondition._ExtraActions_d__4.NativeFieldInfoPtr___3__player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrWinCondition._ExtraActions_d__4.NativeFieldInfoPtr___3__player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000631 RID: 1585
			// (get) Token: 0x06001B32 RID: 6962 RVA: 0x000836D0 File Offset: 0x000818D0
			// (set) Token: 0x06001B33 RID: 6963 RVA: 0x0000CFE2 File Offset: 0x0000B1E2
			public unsafe IEnumerator<Canis.actions.Action> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrWinCondition._ExtraActions_d__4.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Canis.actions.Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrWinCondition._ExtraActions_d__4.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001146 RID: 4422
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001147 RID: 4423
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001148 RID: 4424
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001149 RID: 4425
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400114A RID: 4426
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x0400114B RID: 4427
			private static readonly IntPtr NativeFieldInfoPtr___3__player;

			// Token: 0x0400114C RID: 4428
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x0400114D RID: 4429
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400114E RID: 4430
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400114F RID: 4431
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001150 RID: 4432
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04001151 RID: 4433
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x04001152 RID: 4434
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04001153 RID: 4435
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001154 RID: 4436
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001155 RID: 4437
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04001156 RID: 4438
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
