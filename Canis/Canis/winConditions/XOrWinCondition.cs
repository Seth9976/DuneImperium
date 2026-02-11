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
	// Token: 0x02000033 RID: 51
	public class XOrWinCondition : IWinCondition
	{
		// Token: 0x06000349 RID: 841 RVA: 0x000266B0 File Offset: 0x000248B0
		// Note: this type is marked as 'beforefieldinit'.
		static XOrWinCondition()
		{
			Il2CppClassPointerStore<XOrWinCondition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.winConditions", "XOrWinCondition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XOrWinCondition>.NativeClassPtr);
			XOrWinCondition.NativeFieldInfoPtr_fst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XOrWinCondition>.NativeClassPtr, "fst");
			XOrWinCondition.NativeFieldInfoPtr_snd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XOrWinCondition>.NativeClassPtr, "snd");
			XOrWinCondition.NativeMethodInfoPtr__ctor_Public_Void_IWinCondition_IWinCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XOrWinCondition>.NativeClassPtr, 100663994);
			XOrWinCondition.NativeMethodInfoPtr_DidWin_Public_Virtual_Boolean_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XOrWinCondition>.NativeClassPtr, 100663995);
			XOrWinCondition.NativeMethodInfoPtr_ExtraActions_Public_Virtual_IEnumerable_1_Action_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XOrWinCondition>.NativeClassPtr, 100663996);
		}

		// Token: 0x0600034A RID: 842 RVA: 0x00026744 File Offset: 0x00024944
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 296744, RefRangeEnd = 296798, XrefRangeStart = 296744, XrefRangeEnd = 296798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XOrWinCondition(IWinCondition fst, IWinCondition snd)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XOrWinCondition>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fst);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(snd);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XOrWinCondition.NativeMethodInfoPtr__ctor_Public_Void_IWinCondition_IWinCondition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600034B RID: 843 RVA: 0x000267A4 File Offset: 0x000249A4
		[CallerCount(0)]
		public unsafe override bool DidWin(PlayerEntity player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XOrWinCondition.NativeMethodInfoPtr_DidWin_Public_Virtual_Boolean_PlayerEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600034C RID: 844 RVA: 0x000267FC File Offset: 0x000249FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 549722, XrefRangeEnd = 549729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<Canis.actions.Action> ExtraActions(PlayerEntity player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XOrWinCondition.NativeMethodInfoPtr_ExtraActions_Public_Virtual_IEnumerable_1_Action_PlayerEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Canis.actions.Action>>(intPtr3) : null;
			}
		}

		// Token: 0x0600034D RID: 845 RVA: 0x00003786 File Offset: 0x00001986
		public XOrWinCondition(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x0600034E RID: 846 RVA: 0x00026858 File Offset: 0x00024A58
		// (set) Token: 0x0600034F RID: 847 RVA: 0x0000378F File Offset: 0x0000198F
		public unsafe IWinCondition fst
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XOrWinCondition.NativeFieldInfoPtr_fst);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IWinCondition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XOrWinCondition.NativeFieldInfoPtr_fst), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000350 RID: 848 RVA: 0x00026888 File Offset: 0x00024A88
		// (set) Token: 0x06000351 RID: 849 RVA: 0x000037AE File Offset: 0x000019AE
		public unsafe IWinCondition snd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XOrWinCondition.NativeFieldInfoPtr_snd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IWinCondition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XOrWinCondition.NativeFieldInfoPtr_snd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400022B RID: 555
		private static readonly IntPtr NativeFieldInfoPtr_fst;

		// Token: 0x0400022C RID: 556
		private static readonly IntPtr NativeFieldInfoPtr_snd;

		// Token: 0x0400022D RID: 557
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IWinCondition_IWinCondition_0;

		// Token: 0x0400022E RID: 558
		private static readonly IntPtr NativeMethodInfoPtr_DidWin_Public_Virtual_Boolean_PlayerEntity_0;

		// Token: 0x0400022F RID: 559
		private static readonly IntPtr NativeMethodInfoPtr_ExtraActions_Public_Virtual_IEnumerable_1_Action_PlayerEntity_0;

		// Token: 0x02000281 RID: 641
		[ObfuscatedName("Canis.winConditions.XOrWinCondition+<ExtraActions>d__4")]
		public sealed class _ExtraActions_d__4 : Object
		{
			// Token: 0x06001B34 RID: 6964 RVA: 0x00083700 File Offset: 0x00081900
			// Note: this type is marked as 'beforefieldinit'.
			static _ExtraActions_d__4()
			{
				Il2CppClassPointerStore<XOrWinCondition._ExtraActions_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XOrWinCondition>.NativeClassPtr, "<ExtraActions>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XOrWinCondition._ExtraActions_d__4>.NativeClassPtr);
				XOrWinCondition._ExtraActions_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XOrWinCondition._ExtraActions_d__4>.NativeClassPtr, "<>1__state");
				XOrWinCondition._ExtraActions_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XOrWinCondition._ExtraActions_d__4>.NativeClassPtr, "<>2__current");
				XOrWinCondition._ExtraActions_d__4.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XOrWinCondition._ExtraActions_d__4>.NativeClassPtr, "<>l__initialThreadId");
				XOrWinCondition._ExtraActions_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XOrWinCondition._ExtraActions_d__4>.NativeClassPtr, "<>4__this");
				XOrWinCondition._ExtraActions_d__4.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XOrWinCondition._ExtraActions_d__4>.NativeClassPtr, "player");
				XOrWinCondition._ExtraActions_d__4.NativeFieldInfoPtr___3__player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XOrWinCondition._ExtraActions_d__4>.NativeClassPtr, "<>3__player");
				XOrWinCondition._ExtraActions_d__4.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XOrWinCondition._ExtraActions_d__4>.NativeClassPtr, "<>7__wrap1");
				XOrWinCondition._ExtraActions_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XOrWinCondition._ExtraActions_d__4>.NativeClassPtr, 100663997);
				XOrWinCondition._ExtraActions_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XOrWinCondition._ExtraActions_d__4>.NativeClassPtr, 100663998);
				XOrWinCondition._ExtraActions_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XOrWinCondition._ExtraActions_d__4>.NativeClassPtr, 100663999);
				XOrWinCondition._ExtraActions_d__4.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XOrWinCondition._ExtraActions_d__4>.NativeClassPtr, 100664000);
				XOrWinCondition._ExtraActions_d__4.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XOrWinCondition._ExtraActions_d__4>.NativeClassPtr, 100664001);
				XOrWinCondition._ExtraActions_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XOrWinCondition._ExtraActions_d__4>.NativeClassPtr, 100664002);
				XOrWinCondition._ExtraActions_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XOrWinCondition._ExtraActions_d__4>.NativeClassPtr, 100664003);
				XOrWinCondition._ExtraActions_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XOrWinCondition._ExtraActions_d__4>.NativeClassPtr, 100664004);
				XOrWinCondition._ExtraActions_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XOrWinCondition._ExtraActions_d__4>.NativeClassPtr, 100664005);
				XOrWinCondition._ExtraActions_d__4.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XOrWinCondition._ExtraActions_d__4>.NativeClassPtr, 100664006);
			}

			// Token: 0x06001B35 RID: 6965 RVA: 0x00083880 File Offset: 0x00081A80
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ExtraActions_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XOrWinCondition._ExtraActions_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XOrWinCondition._ExtraActions_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001B36 RID: 6966 RVA: 0x000838C8 File Offset: 0x00081AC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 549658, XrefRangeEnd = 549668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XOrWinCondition._ExtraActions_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B37 RID: 6967 RVA: 0x000838FC File Offset: 0x00081AFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 549668, XrefRangeEnd = 549702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XOrWinCondition._ExtraActions_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001B38 RID: 6968 RVA: 0x00083938 File Offset: 0x00081B38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 549702, XrefRangeEnd = 549705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XOrWinCondition._ExtraActions_d__4.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B39 RID: 6969 RVA: 0x0008396C File Offset: 0x00081B6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 549705, XrefRangeEnd = 549708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XOrWinCondition._ExtraActions_d__4.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700063B RID: 1595
			// (get) Token: 0x06001B3A RID: 6970 RVA: 0x000839A0 File Offset: 0x00081BA0
			public unsafe Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XOrWinCondition._ExtraActions_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06001B3B RID: 6971 RVA: 0x000839E0 File Offset: 0x00081BE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 549708, XrefRangeEnd = 549713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XOrWinCondition._ExtraActions_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700063C RID: 1596
			// (get) Token: 0x06001B3C RID: 6972 RVA: 0x00083A14 File Offset: 0x00081C14
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XOrWinCondition._ExtraActions_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001B3D RID: 6973 RVA: 0x00083A54 File Offset: 0x00081C54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 549713, XrefRangeEnd = 549722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XOrWinCondition._ExtraActions_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06001B3E RID: 6974 RVA: 0x00083A94 File Offset: 0x00081C94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XOrWinCondition._ExtraActions_d__4.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06001B3F RID: 6975 RVA: 0x0000D001 File Offset: 0x0000B201
			public _ExtraActions_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000634 RID: 1588
			// (get) Token: 0x06001B40 RID: 6976 RVA: 0x00083AD4 File Offset: 0x00081CD4
			// (set) Token: 0x06001B41 RID: 6977 RVA: 0x0000D00A File Offset: 0x0000B20A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XOrWinCondition._ExtraActions_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XOrWinCondition._ExtraActions_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000635 RID: 1589
			// (get) Token: 0x06001B42 RID: 6978 RVA: 0x00083AFC File Offset: 0x00081CFC
			// (set) Token: 0x06001B43 RID: 6979 RVA: 0x0000D025 File Offset: 0x0000B225
			public unsafe Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XOrWinCondition._ExtraActions_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XOrWinCondition._ExtraActions_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000636 RID: 1590
			// (get) Token: 0x06001B44 RID: 6980 RVA: 0x00083B2C File Offset: 0x00081D2C
			// (set) Token: 0x06001B45 RID: 6981 RVA: 0x0000D044 File Offset: 0x0000B244
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XOrWinCondition._ExtraActions_d__4.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XOrWinCondition._ExtraActions_d__4.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000637 RID: 1591
			// (get) Token: 0x06001B46 RID: 6982 RVA: 0x00083B54 File Offset: 0x00081D54
			// (set) Token: 0x06001B47 RID: 6983 RVA: 0x0000D05F File Offset: 0x0000B25F
			public unsafe XOrWinCondition __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XOrWinCondition._ExtraActions_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XOrWinCondition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XOrWinCondition._ExtraActions_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000638 RID: 1592
			// (get) Token: 0x06001B48 RID: 6984 RVA: 0x00083B84 File Offset: 0x00081D84
			// (set) Token: 0x06001B49 RID: 6985 RVA: 0x0000D07E File Offset: 0x0000B27E
			public unsafe PlayerEntity player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XOrWinCondition._ExtraActions_d__4.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XOrWinCondition._ExtraActions_d__4.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000639 RID: 1593
			// (get) Token: 0x06001B4A RID: 6986 RVA: 0x00083BB4 File Offset: 0x00081DB4
			// (set) Token: 0x06001B4B RID: 6987 RVA: 0x0000D09D File Offset: 0x0000B29D
			public unsafe PlayerEntity __3__player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XOrWinCondition._ExtraActions_d__4.NativeFieldInfoPtr___3__player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XOrWinCondition._ExtraActions_d__4.NativeFieldInfoPtr___3__player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700063A RID: 1594
			// (get) Token: 0x06001B4C RID: 6988 RVA: 0x00083BE4 File Offset: 0x00081DE4
			// (set) Token: 0x06001B4D RID: 6989 RVA: 0x0000D0BC File Offset: 0x0000B2BC
			public unsafe IEnumerator<Canis.actions.Action> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XOrWinCondition._ExtraActions_d__4.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Canis.actions.Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XOrWinCondition._ExtraActions_d__4.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001157 RID: 4439
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001158 RID: 4440
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001159 RID: 4441
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400115A RID: 4442
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400115B RID: 4443
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x0400115C RID: 4444
			private static readonly IntPtr NativeFieldInfoPtr___3__player;

			// Token: 0x0400115D RID: 4445
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x0400115E RID: 4446
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400115F RID: 4447
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001160 RID: 4448
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001161 RID: 4449
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04001162 RID: 4450
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x04001163 RID: 4451
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04001164 RID: 4452
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001165 RID: 4453
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001166 RID: 4454
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04001167 RID: 4455
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
