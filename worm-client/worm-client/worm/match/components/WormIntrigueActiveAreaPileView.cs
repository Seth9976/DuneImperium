using System;
using boardgames.match;
using boardgames.match.behaviours;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using lotus;
using UnityEngine;

namespace worm.match.components
{
	// Token: 0x020001FC RID: 508
	public class WormIntrigueActiveAreaPileView : MonoBehaviour
	{
		// Token: 0x0600166D RID: 5741 RVA: 0x0005C2B4 File Offset: 0x0005A4B4
		// Note: this type is marked as 'beforefieldinit'.
		static WormIntrigueActiveAreaPileView()
		{
			Il2CppClassPointerStore<WormIntrigueActiveAreaPileView>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormIntrigueActiveAreaPileView");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormIntrigueActiveAreaPileView>.NativeClassPtr);
			WormIntrigueActiveAreaPileView.NativeFieldInfoPtr_view = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormIntrigueActiveAreaPileView>.NativeClassPtr, "view");
			WormIntrigueActiveAreaPileView.NativeFieldInfoPtr_startView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormIntrigueActiveAreaPileView>.NativeClassPtr, "startView");
			WormIntrigueActiveAreaPileView.NativeFieldInfoPtr_entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormIntrigueActiveAreaPileView>.NativeClassPtr, "entities");
			WormIntrigueActiveAreaPileView.NativeFieldInfoPtr_tempEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormIntrigueActiveAreaPileView>.NativeClassPtr, "tempEntities");
			WormIntrigueActiveAreaPileView.NativeFieldInfoPtr_IntrigueCardPlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormIntrigueActiveAreaPileView>.NativeClassPtr, "IntrigueCardPlay");
			WormIntrigueActiveAreaPileView.NativeFieldInfoPtr_Active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormIntrigueActiveAreaPileView>.NativeClassPtr, "Active");
			WormIntrigueActiveAreaPileView.NativeMethodInfoPtr_Start_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormIntrigueActiveAreaPileView>.NativeClassPtr, 100666409);
			WormIntrigueActiveAreaPileView.NativeMethodInfoPtr_AnimateCard_Public_IEnumerator_EntityView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormIntrigueActiveAreaPileView>.NativeClassPtr, 100666410);
			WormIntrigueActiveAreaPileView.NativeMethodInfoPtr_Event_HideCard_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormIntrigueActiveAreaPileView>.NativeClassPtr, 100666411);
			WormIntrigueActiveAreaPileView.NativeMethodInfoPtr_Event_RemoveCard_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormIntrigueActiveAreaPileView>.NativeClassPtr, 100666412);
			WormIntrigueActiveAreaPileView.NativeMethodInfoPtr_NewTemp_Private_EntityComponent_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormIntrigueActiveAreaPileView>.NativeClassPtr, 100666413);
			WormIntrigueActiveAreaPileView.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormIntrigueActiveAreaPileView>.NativeClassPtr, 100666414);
			WormIntrigueActiveAreaPileView.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormIntrigueActiveAreaPileView>.NativeClassPtr, 100666415);
		}

		// Token: 0x0600166E RID: 5742 RVA: 0x0005C3E8 File Offset: 0x0005A5E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716530, XrefRangeEnd = 716535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormIntrigueActiveAreaPileView.NativeMethodInfoPtr_Start_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600166F RID: 5743 RVA: 0x0005C428 File Offset: 0x0005A628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716535, XrefRangeEnd = 716541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator AnimateCard(EntityView card)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(card);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormIntrigueActiveAreaPileView.NativeMethodInfoPtr_AnimateCard_Public_IEnumerator_EntityView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06001670 RID: 5744 RVA: 0x0005C478 File Offset: 0x0005A678
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 716552, RefRangeEnd = 716553, XrefRangeStart = 716541, XrefRangeEnd = 716552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_HideCard()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormIntrigueActiveAreaPileView.NativeMethodInfoPtr_Event_HideCard_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001671 RID: 5745 RVA: 0x0005C4AC File Offset: 0x0005A6AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 716557, RefRangeEnd = 716558, XrefRangeStart = 716553, XrefRangeEnd = 716557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_RemoveCard()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormIntrigueActiveAreaPileView.NativeMethodInfoPtr_Event_RemoveCard_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001672 RID: 5746 RVA: 0x0005C4E0 File Offset: 0x0005A6E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 716561, RefRangeEnd = 716562, XrefRangeStart = 716558, XrefRangeEnd = 716561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityComponent NewTemp(EntityComponent tempEntity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tempEntity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormIntrigueActiveAreaPileView.NativeMethodInfoPtr_NewTemp_Private_EntityComponent_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr3) : null;
			}
		}

		// Token: 0x06001673 RID: 5747 RVA: 0x0005C530 File Offset: 0x0005A730
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716562, XrefRangeEnd = 716577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormIntrigueActiveAreaPileView.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001674 RID: 5748 RVA: 0x0005C564 File Offset: 0x0005A764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716577, XrefRangeEnd = 716585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormIntrigueActiveAreaPileView()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormIntrigueActiveAreaPileView>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormIntrigueActiveAreaPileView.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001675 RID: 5749 RVA: 0x0000D831 File Offset: 0x0000BA31
		public WormIntrigueActiveAreaPileView(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x06001676 RID: 5750 RVA: 0x0005C5A0 File Offset: 0x0005A7A0
		// (set) Token: 0x06001677 RID: 5751 RVA: 0x0000D83A File Offset: 0x0000BA3A
		public unsafe ContainerView view
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormIntrigueActiveAreaPileView.NativeFieldInfoPtr_view);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContainerView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormIntrigueActiveAreaPileView.NativeFieldInfoPtr_view), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x06001678 RID: 5752 RVA: 0x0005C5D0 File Offset: 0x0005A7D0
		// (set) Token: 0x06001679 RID: 5753 RVA: 0x0000D859 File Offset: 0x0000BA59
		public unsafe ContainerView startView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormIntrigueActiveAreaPileView.NativeFieldInfoPtr_startView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContainerView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormIntrigueActiveAreaPileView.NativeFieldInfoPtr_startView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x0600167A RID: 5754 RVA: 0x0005C600 File Offset: 0x0005A800
		// (set) Token: 0x0600167B RID: 5755 RVA: 0x0000D878 File Offset: 0x0000BA78
		public unsafe DBGEntities entities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormIntrigueActiveAreaPileView.NativeFieldInfoPtr_entities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntities>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormIntrigueActiveAreaPileView.NativeFieldInfoPtr_entities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x0600167C RID: 5756 RVA: 0x0005C630 File Offset: 0x0005A830
		// (set) Token: 0x0600167D RID: 5757 RVA: 0x0000D897 File Offset: 0x0000BA97
		public unsafe List<EntityComponent> tempEntities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormIntrigueActiveAreaPileView.NativeFieldInfoPtr_tempEntities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EntityComponent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormIntrigueActiveAreaPileView.NativeFieldInfoPtr_tempEntities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x0600167E RID: 5758 RVA: 0x0005C660 File Offset: 0x0005A860
		// (set) Token: 0x0600167F RID: 5759 RVA: 0x0000D8B6 File Offset: 0x0000BAB6
		public unsafe static int IntrigueCardPlay
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WormIntrigueActiveAreaPileView.NativeFieldInfoPtr_IntrigueCardPlay, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormIntrigueActiveAreaPileView.NativeFieldInfoPtr_IntrigueCardPlay, (void*)(&value));
			}
		}

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x06001680 RID: 5760 RVA: 0x0005C67C File Offset: 0x0005A87C
		// (set) Token: 0x06001681 RID: 5761 RVA: 0x0000D8C4 File Offset: 0x0000BAC4
		public unsafe static int Active
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WormIntrigueActiveAreaPileView.NativeFieldInfoPtr_Active, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormIntrigueActiveAreaPileView.NativeFieldInfoPtr_Active, (void*)(&value));
			}
		}

		// Token: 0x04000D02 RID: 3330
		private static readonly IntPtr NativeFieldInfoPtr_view;

		// Token: 0x04000D03 RID: 3331
		private static readonly IntPtr NativeFieldInfoPtr_startView;

		// Token: 0x04000D04 RID: 3332
		private static readonly IntPtr NativeFieldInfoPtr_entities;

		// Token: 0x04000D05 RID: 3333
		private static readonly IntPtr NativeFieldInfoPtr_tempEntities;

		// Token: 0x04000D06 RID: 3334
		private static readonly IntPtr NativeFieldInfoPtr_IntrigueCardPlay;

		// Token: 0x04000D07 RID: 3335
		private static readonly IntPtr NativeFieldInfoPtr_Active;

		// Token: 0x04000D08 RID: 3336
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_IEnumerator_0;

		// Token: 0x04000D09 RID: 3337
		private static readonly IntPtr NativeMethodInfoPtr_AnimateCard_Public_IEnumerator_EntityView_0;

		// Token: 0x04000D0A RID: 3338
		private static readonly IntPtr NativeMethodInfoPtr_Event_HideCard_Public_Void_0;

		// Token: 0x04000D0B RID: 3339
		private static readonly IntPtr NativeMethodInfoPtr_Event_RemoveCard_Public_Void_0;

		// Token: 0x04000D0C RID: 3340
		private static readonly IntPtr NativeMethodInfoPtr_NewTemp_Private_EntityComponent_EntityComponent_0;

		// Token: 0x04000D0D RID: 3341
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000D0E RID: 3342
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003F4 RID: 1012
		[ObfuscatedName("worm.match.components.WormIntrigueActiveAreaPileView+<AnimateCard>d__7")]
		public sealed class _AnimateCard_d__7 : global::Il2CppSystem.Object
		{
			// Token: 0x0600292E RID: 10542 RVA: 0x00094D08 File Offset: 0x00092F08
			// Note: this type is marked as 'beforefieldinit'.
			static _AnimateCard_d__7()
			{
				Il2CppClassPointerStore<WormIntrigueActiveAreaPileView._AnimateCard_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormIntrigueActiveAreaPileView>.NativeClassPtr, "<AnimateCard>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormIntrigueActiveAreaPileView._AnimateCard_d__7>.NativeClassPtr);
				WormIntrigueActiveAreaPileView._AnimateCard_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormIntrigueActiveAreaPileView._AnimateCard_d__7>.NativeClassPtr, "<>1__state");
				WormIntrigueActiveAreaPileView._AnimateCard_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormIntrigueActiveAreaPileView._AnimateCard_d__7>.NativeClassPtr, "<>2__current");
				WormIntrigueActiveAreaPileView._AnimateCard_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormIntrigueActiveAreaPileView._AnimateCard_d__7>.NativeClassPtr, "<>4__this");
				WormIntrigueActiveAreaPileView._AnimateCard_d__7.NativeFieldInfoPtr_card = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormIntrigueActiveAreaPileView._AnimateCard_d__7>.NativeClassPtr, "card");
				WormIntrigueActiveAreaPileView._AnimateCard_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormIntrigueActiveAreaPileView._AnimateCard_d__7>.NativeClassPtr, 100666417);
				WormIntrigueActiveAreaPileView._AnimateCard_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormIntrigueActiveAreaPileView._AnimateCard_d__7>.NativeClassPtr, 100666418);
				WormIntrigueActiveAreaPileView._AnimateCard_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormIntrigueActiveAreaPileView._AnimateCard_d__7>.NativeClassPtr, 100666419);
				WormIntrigueActiveAreaPileView._AnimateCard_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormIntrigueActiveAreaPileView._AnimateCard_d__7>.NativeClassPtr, 100666420);
				WormIntrigueActiveAreaPileView._AnimateCard_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormIntrigueActiveAreaPileView._AnimateCard_d__7>.NativeClassPtr, 100666421);
				WormIntrigueActiveAreaPileView._AnimateCard_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormIntrigueActiveAreaPileView._AnimateCard_d__7>.NativeClassPtr, 100666422);
			}

			// Token: 0x0600292F RID: 10543 RVA: 0x00094DFC File Offset: 0x00092FFC
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _AnimateCard_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormIntrigueActiveAreaPileView._AnimateCard_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormIntrigueActiveAreaPileView._AnimateCard_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002930 RID: 10544 RVA: 0x00094E44 File Offset: 0x00093044
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormIntrigueActiveAreaPileView._AnimateCard_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002931 RID: 10545 RVA: 0x00094E78 File Offset: 0x00093078
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716464, XrefRangeEnd = 716512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormIntrigueActiveAreaPileView._AnimateCard_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000B98 RID: 2968
			// (get) Token: 0x06002932 RID: 10546 RVA: 0x00094EB4 File Offset: 0x000930B4
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormIntrigueActiveAreaPileView._AnimateCard_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002933 RID: 10547 RVA: 0x00094EF4 File Offset: 0x000930F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716512, XrefRangeEnd = 716517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormIntrigueActiveAreaPileView._AnimateCard_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000B99 RID: 2969
			// (get) Token: 0x06002934 RID: 10548 RVA: 0x00094F28 File Offset: 0x00093128
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormIntrigueActiveAreaPileView._AnimateCard_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002935 RID: 10549 RVA: 0x000168D5 File Offset: 0x00014AD5
			public _AnimateCard_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B94 RID: 2964
			// (get) Token: 0x06002936 RID: 10550 RVA: 0x00094F68 File Offset: 0x00093168
			// (set) Token: 0x06002937 RID: 10551 RVA: 0x000168DE File Offset: 0x00014ADE
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormIntrigueActiveAreaPileView._AnimateCard_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormIntrigueActiveAreaPileView._AnimateCard_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000B95 RID: 2965
			// (get) Token: 0x06002938 RID: 10552 RVA: 0x00094F90 File Offset: 0x00093190
			// (set) Token: 0x06002939 RID: 10553 RVA: 0x000168F9 File Offset: 0x00014AF9
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormIntrigueActiveAreaPileView._AnimateCard_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormIntrigueActiveAreaPileView._AnimateCard_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B96 RID: 2966
			// (get) Token: 0x0600293A RID: 10554 RVA: 0x00094FC0 File Offset: 0x000931C0
			// (set) Token: 0x0600293B RID: 10555 RVA: 0x00016918 File Offset: 0x00014B18
			public unsafe WormIntrigueActiveAreaPileView __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormIntrigueActiveAreaPileView._AnimateCard_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormIntrigueActiveAreaPileView>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormIntrigueActiveAreaPileView._AnimateCard_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B97 RID: 2967
			// (get) Token: 0x0600293C RID: 10556 RVA: 0x00094FF0 File Offset: 0x000931F0
			// (set) Token: 0x0600293D RID: 10557 RVA: 0x00016937 File Offset: 0x00014B37
			public unsafe EntityView card
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormIntrigueActiveAreaPileView._AnimateCard_d__7.NativeFieldInfoPtr_card);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormIntrigueActiveAreaPileView._AnimateCard_d__7.NativeFieldInfoPtr_card), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040017BB RID: 6075
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040017BC RID: 6076
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040017BD RID: 6077
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040017BE RID: 6078
			private static readonly IntPtr NativeFieldInfoPtr_card;

			// Token: 0x040017BF RID: 6079
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040017C0 RID: 6080
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040017C1 RID: 6081
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040017C2 RID: 6082
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040017C3 RID: 6083
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040017C4 RID: 6084
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020003F5 RID: 1013
		[ObfuscatedName("worm.match.components.WormIntrigueActiveAreaPileView+<Start>d__6")]
		public sealed class _Start_d__6 : global::Il2CppSystem.Object
		{
			// Token: 0x0600293E RID: 10558 RVA: 0x00095020 File Offset: 0x00093220
			// Note: this type is marked as 'beforefieldinit'.
			static _Start_d__6()
			{
				Il2CppClassPointerStore<WormIntrigueActiveAreaPileView._Start_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormIntrigueActiveAreaPileView>.NativeClassPtr, "<Start>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormIntrigueActiveAreaPileView._Start_d__6>.NativeClassPtr);
				WormIntrigueActiveAreaPileView._Start_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormIntrigueActiveAreaPileView._Start_d__6>.NativeClassPtr, "<>1__state");
				WormIntrigueActiveAreaPileView._Start_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormIntrigueActiveAreaPileView._Start_d__6>.NativeClassPtr, "<>2__current");
				WormIntrigueActiveAreaPileView._Start_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormIntrigueActiveAreaPileView._Start_d__6>.NativeClassPtr, "<>4__this");
				WormIntrigueActiveAreaPileView._Start_d__6.NativeFieldInfoPtr__entitiesProvider_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormIntrigueActiveAreaPileView._Start_d__6>.NativeClassPtr, "<entitiesProvider>5__2");
				WormIntrigueActiveAreaPileView._Start_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormIntrigueActiveAreaPileView._Start_d__6>.NativeClassPtr, 100666423);
				WormIntrigueActiveAreaPileView._Start_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormIntrigueActiveAreaPileView._Start_d__6>.NativeClassPtr, 100666424);
				WormIntrigueActiveAreaPileView._Start_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormIntrigueActiveAreaPileView._Start_d__6>.NativeClassPtr, 100666425);
				WormIntrigueActiveAreaPileView._Start_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormIntrigueActiveAreaPileView._Start_d__6>.NativeClassPtr, 100666426);
				WormIntrigueActiveAreaPileView._Start_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormIntrigueActiveAreaPileView._Start_d__6>.NativeClassPtr, 100666427);
				WormIntrigueActiveAreaPileView._Start_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormIntrigueActiveAreaPileView._Start_d__6>.NativeClassPtr, 100666428);
			}

			// Token: 0x0600293F RID: 10559 RVA: 0x00095114 File Offset: 0x00093314
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Start_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormIntrigueActiveAreaPileView._Start_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormIntrigueActiveAreaPileView._Start_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002940 RID: 10560 RVA: 0x0009515C File Offset: 0x0009335C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormIntrigueActiveAreaPileView._Start_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002941 RID: 10561 RVA: 0x00095190 File Offset: 0x00093390
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716517, XrefRangeEnd = 716525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormIntrigueActiveAreaPileView._Start_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000B9E RID: 2974
			// (get) Token: 0x06002942 RID: 10562 RVA: 0x000951CC File Offset: 0x000933CC
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormIntrigueActiveAreaPileView._Start_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002943 RID: 10563 RVA: 0x0009520C File Offset: 0x0009340C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716525, XrefRangeEnd = 716530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormIntrigueActiveAreaPileView._Start_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000B9F RID: 2975
			// (get) Token: 0x06002944 RID: 10564 RVA: 0x00095240 File Offset: 0x00093440
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormIntrigueActiveAreaPileView._Start_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002945 RID: 10565 RVA: 0x00016956 File Offset: 0x00014B56
			public _Start_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B9A RID: 2970
			// (get) Token: 0x06002946 RID: 10566 RVA: 0x00095280 File Offset: 0x00093480
			// (set) Token: 0x06002947 RID: 10567 RVA: 0x0001695F File Offset: 0x00014B5F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormIntrigueActiveAreaPileView._Start_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormIntrigueActiveAreaPileView._Start_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000B9B RID: 2971
			// (get) Token: 0x06002948 RID: 10568 RVA: 0x000952A8 File Offset: 0x000934A8
			// (set) Token: 0x06002949 RID: 10569 RVA: 0x0001697A File Offset: 0x00014B7A
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormIntrigueActiveAreaPileView._Start_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormIntrigueActiveAreaPileView._Start_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B9C RID: 2972
			// (get) Token: 0x0600294A RID: 10570 RVA: 0x000952D8 File Offset: 0x000934D8
			// (set) Token: 0x0600294B RID: 10571 RVA: 0x00016999 File Offset: 0x00014B99
			public unsafe WormIntrigueActiveAreaPileView __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormIntrigueActiveAreaPileView._Start_d__6.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormIntrigueActiveAreaPileView>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormIntrigueActiveAreaPileView._Start_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B9D RID: 2973
			// (get) Token: 0x0600294C RID: 10572 RVA: 0x00095308 File Offset: 0x00093508
			// (set) Token: 0x0600294D RID: 10573 RVA: 0x000169B8 File Offset: 0x00014BB8
			public unsafe DBGEntitiesProvider _entitiesProvider_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormIntrigueActiveAreaPileView._Start_d__6.NativeFieldInfoPtr__entitiesProvider_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntitiesProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormIntrigueActiveAreaPileView._Start_d__6.NativeFieldInfoPtr__entitiesProvider_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040017C5 RID: 6085
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040017C6 RID: 6086
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040017C7 RID: 6087
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040017C8 RID: 6088
			private static readonly IntPtr NativeFieldInfoPtr__entitiesProvider_5__2;

			// Token: 0x040017C9 RID: 6089
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040017CA RID: 6090
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040017CB RID: 6091
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040017CC RID: 6092
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040017CD RID: 6093
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040017CE RID: 6094
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
