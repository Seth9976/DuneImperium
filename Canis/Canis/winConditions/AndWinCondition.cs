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
	// Token: 0x02000031 RID: 49
	public class AndWinCondition : IWinCondition
	{
		// Token: 0x06000337 RID: 823 RVA: 0x000262A0 File Offset: 0x000244A0
		// Note: this type is marked as 'beforefieldinit'.
		static AndWinCondition()
		{
			Il2CppClassPointerStore<AndWinCondition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.winConditions", "AndWinCondition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndWinCondition>.NativeClassPtr);
			AndWinCondition.NativeFieldInfoPtr_fst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndWinCondition>.NativeClassPtr, "fst");
			AndWinCondition.NativeFieldInfoPtr_snd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndWinCondition>.NativeClassPtr, "snd");
			AndWinCondition.NativeMethodInfoPtr__ctor_Public_Void_IWinCondition_IWinCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndWinCondition>.NativeClassPtr, 100663968);
			AndWinCondition.NativeMethodInfoPtr_DidWin_Public_Virtual_Boolean_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndWinCondition>.NativeClassPtr, 100663969);
			AndWinCondition.NativeMethodInfoPtr_ExtraActions_Public_Virtual_IEnumerable_1_Action_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndWinCondition>.NativeClassPtr, 100663970);
		}

		// Token: 0x06000338 RID: 824 RVA: 0x00026334 File Offset: 0x00024534
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 296744, RefRangeEnd = 296798, XrefRangeStart = 296744, XrefRangeEnd = 296798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AndWinCondition(IWinCondition fst, IWinCondition snd)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndWinCondition>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fst);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(snd);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndWinCondition.NativeMethodInfoPtr__ctor_Public_Void_IWinCondition_IWinCondition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000339 RID: 825 RVA: 0x00026394 File Offset: 0x00024594
		[CallerCount(0)]
		public unsafe override bool DidWin(PlayerEntity player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AndWinCondition.NativeMethodInfoPtr_DidWin_Public_Virtual_Boolean_PlayerEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600033A RID: 826 RVA: 0x000263EC File Offset: 0x000245EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 549580, XrefRangeEnd = 549587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<Canis.actions.Action> ExtraActions(PlayerEntity player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AndWinCondition.NativeMethodInfoPtr_ExtraActions_Public_Virtual_IEnumerable_1_Action_PlayerEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Canis.actions.Action>>(intPtr3) : null;
			}
		}

		// Token: 0x0600033B RID: 827 RVA: 0x000036F8 File Offset: 0x000018F8
		public AndWinCondition(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x0600033C RID: 828 RVA: 0x00026448 File Offset: 0x00024648
		// (set) Token: 0x0600033D RID: 829 RVA: 0x00003701 File Offset: 0x00001901
		public unsafe IWinCondition fst
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndWinCondition.NativeFieldInfoPtr_fst);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IWinCondition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndWinCondition.NativeFieldInfoPtr_fst), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x0600033E RID: 830 RVA: 0x00026478 File Offset: 0x00024678
		// (set) Token: 0x0600033F RID: 831 RVA: 0x00003720 File Offset: 0x00001920
		public unsafe IWinCondition snd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndWinCondition.NativeFieldInfoPtr_snd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IWinCondition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndWinCondition.NativeFieldInfoPtr_snd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000221 RID: 545
		private static readonly IntPtr NativeFieldInfoPtr_fst;

		// Token: 0x04000222 RID: 546
		private static readonly IntPtr NativeFieldInfoPtr_snd;

		// Token: 0x04000223 RID: 547
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IWinCondition_IWinCondition_0;

		// Token: 0x04000224 RID: 548
		private static readonly IntPtr NativeMethodInfoPtr_DidWin_Public_Virtual_Boolean_PlayerEntity_0;

		// Token: 0x04000225 RID: 549
		private static readonly IntPtr NativeMethodInfoPtr_ExtraActions_Public_Virtual_IEnumerable_1_Action_PlayerEntity_0;

		// Token: 0x0200027F RID: 639
		[ObfuscatedName("Canis.winConditions.AndWinCondition+<ExtraActions>d__4")]
		public sealed class _ExtraActions_d__4 : Object
		{
			// Token: 0x06001B00 RID: 6912 RVA: 0x00082CD8 File Offset: 0x00080ED8
			// Note: this type is marked as 'beforefieldinit'.
			static _ExtraActions_d__4()
			{
				Il2CppClassPointerStore<AndWinCondition._ExtraActions_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AndWinCondition>.NativeClassPtr, "<ExtraActions>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndWinCondition._ExtraActions_d__4>.NativeClassPtr);
				AndWinCondition._ExtraActions_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndWinCondition._ExtraActions_d__4>.NativeClassPtr, "<>1__state");
				AndWinCondition._ExtraActions_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndWinCondition._ExtraActions_d__4>.NativeClassPtr, "<>2__current");
				AndWinCondition._ExtraActions_d__4.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndWinCondition._ExtraActions_d__4>.NativeClassPtr, "<>l__initialThreadId");
				AndWinCondition._ExtraActions_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndWinCondition._ExtraActions_d__4>.NativeClassPtr, "<>4__this");
				AndWinCondition._ExtraActions_d__4.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndWinCondition._ExtraActions_d__4>.NativeClassPtr, "player");
				AndWinCondition._ExtraActions_d__4.NativeFieldInfoPtr___3__player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndWinCondition._ExtraActions_d__4>.NativeClassPtr, "<>3__player");
				AndWinCondition._ExtraActions_d__4.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndWinCondition._ExtraActions_d__4>.NativeClassPtr, "<>7__wrap1");
				AndWinCondition._ExtraActions_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndWinCondition._ExtraActions_d__4>.NativeClassPtr, 100663971);
				AndWinCondition._ExtraActions_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndWinCondition._ExtraActions_d__4>.NativeClassPtr, 100663972);
				AndWinCondition._ExtraActions_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndWinCondition._ExtraActions_d__4>.NativeClassPtr, 100663973);
				AndWinCondition._ExtraActions_d__4.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndWinCondition._ExtraActions_d__4>.NativeClassPtr, 100663974);
				AndWinCondition._ExtraActions_d__4.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndWinCondition._ExtraActions_d__4>.NativeClassPtr, 100663975);
				AndWinCondition._ExtraActions_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndWinCondition._ExtraActions_d__4>.NativeClassPtr, 100663976);
				AndWinCondition._ExtraActions_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndWinCondition._ExtraActions_d__4>.NativeClassPtr, 100663977);
				AndWinCondition._ExtraActions_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndWinCondition._ExtraActions_d__4>.NativeClassPtr, 100663978);
				AndWinCondition._ExtraActions_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndWinCondition._ExtraActions_d__4>.NativeClassPtr, 100663979);
				AndWinCondition._ExtraActions_d__4.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndWinCondition._ExtraActions_d__4>.NativeClassPtr, 100663980);
			}

			// Token: 0x06001B01 RID: 6913 RVA: 0x00082E58 File Offset: 0x00081058
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ExtraActions_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndWinCondition._ExtraActions_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndWinCondition._ExtraActions_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001B02 RID: 6914 RVA: 0x00082EA0 File Offset: 0x000810A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 549517, XrefRangeEnd = 549527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndWinCondition._ExtraActions_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B03 RID: 6915 RVA: 0x00082ED4 File Offset: 0x000810D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 549527, XrefRangeEnd = 549560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndWinCondition._ExtraActions_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001B04 RID: 6916 RVA: 0x00082F10 File Offset: 0x00081110
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 549560, XrefRangeEnd = 549563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndWinCondition._ExtraActions_d__4.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B05 RID: 6917 RVA: 0x00082F44 File Offset: 0x00081144
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 549563, XrefRangeEnd = 549566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndWinCondition._ExtraActions_d__4.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000629 RID: 1577
			// (get) Token: 0x06001B06 RID: 6918 RVA: 0x00082F78 File Offset: 0x00081178
			public unsafe Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndWinCondition._ExtraActions_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06001B07 RID: 6919 RVA: 0x00082FB8 File Offset: 0x000811B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 549566, XrefRangeEnd = 549571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndWinCondition._ExtraActions_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700062A RID: 1578
			// (get) Token: 0x06001B08 RID: 6920 RVA: 0x00082FEC File Offset: 0x000811EC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndWinCondition._ExtraActions_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001B09 RID: 6921 RVA: 0x0008302C File Offset: 0x0008122C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 549571, XrefRangeEnd = 549580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndWinCondition._ExtraActions_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06001B0A RID: 6922 RVA: 0x0008306C File Offset: 0x0008126C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndWinCondition._ExtraActions_d__4.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06001B0B RID: 6923 RVA: 0x0000CE4D File Offset: 0x0000B04D
			public _ExtraActions_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000622 RID: 1570
			// (get) Token: 0x06001B0C RID: 6924 RVA: 0x000830AC File Offset: 0x000812AC
			// (set) Token: 0x06001B0D RID: 6925 RVA: 0x0000CE56 File Offset: 0x0000B056
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndWinCondition._ExtraActions_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndWinCondition._ExtraActions_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000623 RID: 1571
			// (get) Token: 0x06001B0E RID: 6926 RVA: 0x000830D4 File Offset: 0x000812D4
			// (set) Token: 0x06001B0F RID: 6927 RVA: 0x0000CE71 File Offset: 0x0000B071
			public unsafe Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndWinCondition._ExtraActions_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndWinCondition._ExtraActions_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000624 RID: 1572
			// (get) Token: 0x06001B10 RID: 6928 RVA: 0x00083104 File Offset: 0x00081304
			// (set) Token: 0x06001B11 RID: 6929 RVA: 0x0000CE90 File Offset: 0x0000B090
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndWinCondition._ExtraActions_d__4.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndWinCondition._ExtraActions_d__4.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000625 RID: 1573
			// (get) Token: 0x06001B12 RID: 6930 RVA: 0x0008312C File Offset: 0x0008132C
			// (set) Token: 0x06001B13 RID: 6931 RVA: 0x0000CEAB File Offset: 0x0000B0AB
			public unsafe AndWinCondition __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndWinCondition._ExtraActions_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AndWinCondition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndWinCondition._ExtraActions_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000626 RID: 1574
			// (get) Token: 0x06001B14 RID: 6932 RVA: 0x0008315C File Offset: 0x0008135C
			// (set) Token: 0x06001B15 RID: 6933 RVA: 0x0000CECA File Offset: 0x0000B0CA
			public unsafe PlayerEntity player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndWinCondition._ExtraActions_d__4.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndWinCondition._ExtraActions_d__4.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000627 RID: 1575
			// (get) Token: 0x06001B16 RID: 6934 RVA: 0x0008318C File Offset: 0x0008138C
			// (set) Token: 0x06001B17 RID: 6935 RVA: 0x0000CEE9 File Offset: 0x0000B0E9
			public unsafe PlayerEntity __3__player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndWinCondition._ExtraActions_d__4.NativeFieldInfoPtr___3__player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndWinCondition._ExtraActions_d__4.NativeFieldInfoPtr___3__player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000628 RID: 1576
			// (get) Token: 0x06001B18 RID: 6936 RVA: 0x000831BC File Offset: 0x000813BC
			// (set) Token: 0x06001B19 RID: 6937 RVA: 0x0000CF08 File Offset: 0x0000B108
			public unsafe IEnumerator<Canis.actions.Action> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndWinCondition._ExtraActions_d__4.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Canis.actions.Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndWinCondition._ExtraActions_d__4.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001135 RID: 4405
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001136 RID: 4406
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001137 RID: 4407
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001138 RID: 4408
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001139 RID: 4409
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x0400113A RID: 4410
			private static readonly IntPtr NativeFieldInfoPtr___3__player;

			// Token: 0x0400113B RID: 4411
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x0400113C RID: 4412
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400113D RID: 4413
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400113E RID: 4414
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400113F RID: 4415
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04001140 RID: 4416
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x04001141 RID: 4417
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04001142 RID: 4418
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001143 RID: 4419
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001144 RID: 4420
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04001145 RID: 4421
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
