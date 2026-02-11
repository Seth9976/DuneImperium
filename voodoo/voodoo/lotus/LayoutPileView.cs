using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace lotus
{
	// Token: 0x0200005C RID: 92
	public class LayoutPileView : ContainerView
	{
		// Token: 0x06000564 RID: 1380 RVA: 0x0001B304 File Offset: 0x00019504
		// Note: this type is marked as 'beforefieldinit'.
		static LayoutPileView()
		{
			Il2CppClassPointerStore<LayoutPileView>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lotus", "LayoutPileView");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LayoutPileView>.NativeClassPtr);
			LayoutPileView.NativeFieldInfoPtr_layout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutPileView>.NativeClassPtr, "layout");
			LayoutPileView.NativeFieldInfoPtr_sorter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutPileView>.NativeClassPtr, "sorter");
			LayoutPileView.NativeFieldInfoPtr_layoutSortedViews = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutPileView>.NativeClassPtr, "layoutSortedViews");
			LayoutPileView.NativeMethodInfoPtr_InitProperties_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutPileView>.NativeClassPtr, 100663998);
			LayoutPileView.NativeMethodInfoPtr_LayoutViews_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutPileView>.NativeClassPtr, 100663999);
			LayoutPileView.NativeMethodInfoPtr_GetPositionsFor_Public_Virtual_Void_MoveContext_Il2CppStructArray_1_LocalTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutPileView>.NativeClassPtr, 100664000);
			LayoutPileView.NativeMethodInfoPtr_ContainerForViewAndSlot_Public_Virtual_Transform_UnitView_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutPileView>.NativeClassPtr, 100664001);
			LayoutPileView.NativeMethodInfoPtr_OnPrepareToReceiveEntities_Public_Virtual_IEnumerator_MoveContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutPileView>.NativeClassPtr, 100664002);
			LayoutPileView.NativeMethodInfoPtr_OnPrepareToRemoveEntities_Public_Virtual_IEnumerator_MoveContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutPileView>.NativeClassPtr, 100664003);
			LayoutPileView.NativeMethodInfoPtr_OnEntitiesRemoved_Public_Virtual_IEnumerator_MoveContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutPileView>.NativeClassPtr, 100664004);
			LayoutPileView.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutPileView>.NativeClassPtr, 100664005);
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x0001B410 File Offset: 0x00019610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111696, XrefRangeEnd = 1111708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LayoutPileView.NativeMethodInfoPtr_InitProperties_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x0001B44C File Offset: 0x0001964C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1111719, RefRangeEnd = 1111720, XrefRangeStart = 1111708, XrefRangeEnd = 1111719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void LayoutViews()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LayoutPileView.NativeMethodInfoPtr_LayoutViews_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x0001B488 File Offset: 0x00019688
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111720, XrefRangeEnd = 1111733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GetPositionsFor(MoveContext context, Il2CppStructArray<LocalTransform> retVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(retVal);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LayoutPileView.NativeMethodInfoPtr_GetPositionsFor_Public_Virtual_Void_MoveContext_Il2CppStructArray_1_LocalTransform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x0001B4E8 File Offset: 0x000196E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111733, XrefRangeEnd = 1111741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Transform ContainerForViewAndSlot(UnitView view, int slot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(view);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref slot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LayoutPileView.NativeMethodInfoPtr_ContainerForViewAndSlot_Public_Virtual_Transform_UnitView_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x0001B554 File Offset: 0x00019754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111741, XrefRangeEnd = 1111747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnPrepareToReceiveEntities(MoveContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LayoutPileView.NativeMethodInfoPtr_OnPrepareToReceiveEntities_Public_Virtual_IEnumerator_MoveContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x0001B5B0 File Offset: 0x000197B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111747, XrefRangeEnd = 1111753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnPrepareToRemoveEntities(MoveContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LayoutPileView.NativeMethodInfoPtr_OnPrepareToRemoveEntities_Public_Virtual_IEnumerator_MoveContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x0001B60C File Offset: 0x0001980C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111753, XrefRangeEnd = 1111759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnEntitiesRemoved(MoveContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LayoutPileView.NativeMethodInfoPtr_OnEntitiesRemoved_Public_Virtual_IEnumerator_MoveContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x0001B668 File Offset: 0x00019868
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1111767, RefRangeEnd = 1111769, XrefRangeStart = 1111759, XrefRangeEnd = 1111767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LayoutPileView()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LayoutPileView>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutPileView.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x00004A30 File Offset: 0x00002C30
		public LayoutPileView(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x0600056E RID: 1390 RVA: 0x0001B6A4 File Offset: 0x000198A4
		// (set) Token: 0x0600056F RID: 1391 RVA: 0x00004A39 File Offset: 0x00002C39
		public unsafe IViewLayout layout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutPileView.NativeFieldInfoPtr_layout);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IViewLayout>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutPileView.NativeFieldInfoPtr_layout), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x06000570 RID: 1392 RVA: 0x0001B6D4 File Offset: 0x000198D4
		// (set) Token: 0x06000571 RID: 1393 RVA: 0x00004A58 File Offset: 0x00002C58
		public unsafe IViewSorter sorter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutPileView.NativeFieldInfoPtr_sorter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IViewSorter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutPileView.NativeFieldInfoPtr_sorter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x06000572 RID: 1394 RVA: 0x0001B704 File Offset: 0x00019904
		// (set) Token: 0x06000573 RID: 1395 RVA: 0x00004A77 File Offset: 0x00002C77
		public unsafe List<UnitView> layoutSortedViews
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutPileView.NativeFieldInfoPtr_layoutSortedViews);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<UnitView>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutPileView.NativeFieldInfoPtr_layoutSortedViews), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000363 RID: 867
		private static readonly IntPtr NativeFieldInfoPtr_layout;

		// Token: 0x04000364 RID: 868
		private static readonly IntPtr NativeFieldInfoPtr_sorter;

		// Token: 0x04000365 RID: 869
		private static readonly IntPtr NativeFieldInfoPtr_layoutSortedViews;

		// Token: 0x04000366 RID: 870
		private static readonly IntPtr NativeMethodInfoPtr_InitProperties_Public_Virtual_Void_0;

		// Token: 0x04000367 RID: 871
		private static readonly IntPtr NativeMethodInfoPtr_LayoutViews_Public_Virtual_Void_0;

		// Token: 0x04000368 RID: 872
		private static readonly IntPtr NativeMethodInfoPtr_GetPositionsFor_Public_Virtual_Void_MoveContext_Il2CppStructArray_1_LocalTransform_0;

		// Token: 0x04000369 RID: 873
		private static readonly IntPtr NativeMethodInfoPtr_ContainerForViewAndSlot_Public_Virtual_Transform_UnitView_Int32_0;

		// Token: 0x0400036A RID: 874
		private static readonly IntPtr NativeMethodInfoPtr_OnPrepareToReceiveEntities_Public_Virtual_IEnumerator_MoveContext_0;

		// Token: 0x0400036B RID: 875
		private static readonly IntPtr NativeMethodInfoPtr_OnPrepareToRemoveEntities_Public_Virtual_IEnumerator_MoveContext_0;

		// Token: 0x0400036C RID: 876
		private static readonly IntPtr NativeMethodInfoPtr_OnEntitiesRemoved_Public_Virtual_IEnumerator_MoveContext_0;

		// Token: 0x0400036D RID: 877
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020000DD RID: 221
		[ObfuscatedName("lotus.LayoutPileView+<OnEntitiesRemoved>d__9")]
		public sealed class _OnEntitiesRemoved_d__9 : global::Il2CppSystem.Object
		{
			// Token: 0x06000B91 RID: 2961 RVA: 0x0002F254 File Offset: 0x0002D454
			// Note: this type is marked as 'beforefieldinit'.
			static _OnEntitiesRemoved_d__9()
			{
				Il2CppClassPointerStore<LayoutPileView._OnEntitiesRemoved_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LayoutPileView>.NativeClassPtr, "<OnEntitiesRemoved>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LayoutPileView._OnEntitiesRemoved_d__9>.NativeClassPtr);
				LayoutPileView._OnEntitiesRemoved_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutPileView._OnEntitiesRemoved_d__9>.NativeClassPtr, "<>1__state");
				LayoutPileView._OnEntitiesRemoved_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutPileView._OnEntitiesRemoved_d__9>.NativeClassPtr, "<>2__current");
				LayoutPileView._OnEntitiesRemoved_d__9.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutPileView._OnEntitiesRemoved_d__9>.NativeClassPtr, "context");
				LayoutPileView._OnEntitiesRemoved_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutPileView._OnEntitiesRemoved_d__9>.NativeClassPtr, "<>4__this");
				LayoutPileView._OnEntitiesRemoved_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutPileView._OnEntitiesRemoved_d__9>.NativeClassPtr, 100664006);
				LayoutPileView._OnEntitiesRemoved_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutPileView._OnEntitiesRemoved_d__9>.NativeClassPtr, 100664007);
				LayoutPileView._OnEntitiesRemoved_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutPileView._OnEntitiesRemoved_d__9>.NativeClassPtr, 100664008);
				LayoutPileView._OnEntitiesRemoved_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutPileView._OnEntitiesRemoved_d__9>.NativeClassPtr, 100664009);
				LayoutPileView._OnEntitiesRemoved_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutPileView._OnEntitiesRemoved_d__9>.NativeClassPtr, 100664010);
				LayoutPileView._OnEntitiesRemoved_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutPileView._OnEntitiesRemoved_d__9>.NativeClassPtr, 100664011);
			}

			// Token: 0x06000B92 RID: 2962 RVA: 0x0002F348 File Offset: 0x0002D548
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnEntitiesRemoved_d__9(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LayoutPileView._OnEntitiesRemoved_d__9>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutPileView._OnEntitiesRemoved_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000B93 RID: 2963 RVA: 0x0002F390 File Offset: 0x0002D590
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutPileView._OnEntitiesRemoved_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000B94 RID: 2964 RVA: 0x0002F3C4 File Offset: 0x0002D5C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111642, XrefRangeEnd = 1111659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutPileView._OnEntitiesRemoved_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000366 RID: 870
			// (get) Token: 0x06000B95 RID: 2965 RVA: 0x0002F400 File Offset: 0x0002D600
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutPileView._OnEntitiesRemoved_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000B96 RID: 2966 RVA: 0x0002F440 File Offset: 0x0002D640
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111659, XrefRangeEnd = 1111664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutPileView._OnEntitiesRemoved_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000367 RID: 871
			// (get) Token: 0x06000B97 RID: 2967 RVA: 0x0002F474 File Offset: 0x0002D674
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutPileView._OnEntitiesRemoved_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000B98 RID: 2968 RVA: 0x00007AC1 File Offset: 0x00005CC1
			public _OnEntitiesRemoved_d__9(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000362 RID: 866
			// (get) Token: 0x06000B99 RID: 2969 RVA: 0x0002F4B4 File Offset: 0x0002D6B4
			// (set) Token: 0x06000B9A RID: 2970 RVA: 0x00007ACA File Offset: 0x00005CCA
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutPileView._OnEntitiesRemoved_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutPileView._OnEntitiesRemoved_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000363 RID: 867
			// (get) Token: 0x06000B9B RID: 2971 RVA: 0x0002F4DC File Offset: 0x0002D6DC
			// (set) Token: 0x06000B9C RID: 2972 RVA: 0x00007AE5 File Offset: 0x00005CE5
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutPileView._OnEntitiesRemoved_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutPileView._OnEntitiesRemoved_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000364 RID: 868
			// (get) Token: 0x06000B9D RID: 2973 RVA: 0x0002F50C File Offset: 0x0002D70C
			// (set) Token: 0x06000B9E RID: 2974 RVA: 0x00007B04 File Offset: 0x00005D04
			public unsafe MoveContext context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutPileView._OnEntitiesRemoved_d__9.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MoveContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutPileView._OnEntitiesRemoved_d__9.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000365 RID: 869
			// (get) Token: 0x06000B9F RID: 2975 RVA: 0x0002F53C File Offset: 0x0002D73C
			// (set) Token: 0x06000BA0 RID: 2976 RVA: 0x00007B23 File Offset: 0x00005D23
			public unsafe LayoutPileView __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutPileView._OnEntitiesRemoved_d__9.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LayoutPileView>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutPileView._OnEntitiesRemoved_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400073A RID: 1850
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400073B RID: 1851
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400073C RID: 1852
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x0400073D RID: 1853
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400073E RID: 1854
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400073F RID: 1855
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000740 RID: 1856
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000741 RID: 1857
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000742 RID: 1858
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000743 RID: 1859
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020000DE RID: 222
		[ObfuscatedName("lotus.LayoutPileView+<OnPrepareToReceiveEntities>d__7")]
		public sealed class _OnPrepareToReceiveEntities_d__7 : global::Il2CppSystem.Object
		{
			// Token: 0x06000BA1 RID: 2977 RVA: 0x0002F56C File Offset: 0x0002D76C
			// Note: this type is marked as 'beforefieldinit'.
			static _OnPrepareToReceiveEntities_d__7()
			{
				Il2CppClassPointerStore<LayoutPileView._OnPrepareToReceiveEntities_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LayoutPileView>.NativeClassPtr, "<OnPrepareToReceiveEntities>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LayoutPileView._OnPrepareToReceiveEntities_d__7>.NativeClassPtr);
				LayoutPileView._OnPrepareToReceiveEntities_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutPileView._OnPrepareToReceiveEntities_d__7>.NativeClassPtr, "<>1__state");
				LayoutPileView._OnPrepareToReceiveEntities_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutPileView._OnPrepareToReceiveEntities_d__7>.NativeClassPtr, "<>2__current");
				LayoutPileView._OnPrepareToReceiveEntities_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutPileView._OnPrepareToReceiveEntities_d__7>.NativeClassPtr, "<>4__this");
				LayoutPileView._OnPrepareToReceiveEntities_d__7.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutPileView._OnPrepareToReceiveEntities_d__7>.NativeClassPtr, "context");
				LayoutPileView._OnPrepareToReceiveEntities_d__7.NativeFieldInfoPtr__prepareToReceiveEntities_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutPileView._OnPrepareToReceiveEntities_d__7>.NativeClassPtr, "<prepareToReceiveEntities>5__2");
				LayoutPileView._OnPrepareToReceiveEntities_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutPileView._OnPrepareToReceiveEntities_d__7>.NativeClassPtr, 100664012);
				LayoutPileView._OnPrepareToReceiveEntities_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutPileView._OnPrepareToReceiveEntities_d__7>.NativeClassPtr, 100664013);
				LayoutPileView._OnPrepareToReceiveEntities_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutPileView._OnPrepareToReceiveEntities_d__7>.NativeClassPtr, 100664014);
				LayoutPileView._OnPrepareToReceiveEntities_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutPileView._OnPrepareToReceiveEntities_d__7>.NativeClassPtr, 100664015);
				LayoutPileView._OnPrepareToReceiveEntities_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutPileView._OnPrepareToReceiveEntities_d__7>.NativeClassPtr, 100664016);
				LayoutPileView._OnPrepareToReceiveEntities_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutPileView._OnPrepareToReceiveEntities_d__7>.NativeClassPtr, 100664017);
			}

			// Token: 0x06000BA2 RID: 2978 RVA: 0x0002F674 File Offset: 0x0002D874
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnPrepareToReceiveEntities_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LayoutPileView._OnPrepareToReceiveEntities_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutPileView._OnPrepareToReceiveEntities_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000BA3 RID: 2979 RVA: 0x0002F6BC File Offset: 0x0002D8BC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutPileView._OnPrepareToReceiveEntities_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000BA4 RID: 2980 RVA: 0x0002F6F0 File Offset: 0x0002D8F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111664, XrefRangeEnd = 1111675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutPileView._OnPrepareToReceiveEntities_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700036D RID: 877
			// (get) Token: 0x06000BA5 RID: 2981 RVA: 0x0002F72C File Offset: 0x0002D92C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutPileView._OnPrepareToReceiveEntities_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000BA6 RID: 2982 RVA: 0x0002F76C File Offset: 0x0002D96C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111675, XrefRangeEnd = 1111680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutPileView._OnPrepareToReceiveEntities_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700036E RID: 878
			// (get) Token: 0x06000BA7 RID: 2983 RVA: 0x0002F7A0 File Offset: 0x0002D9A0
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutPileView._OnPrepareToReceiveEntities_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000BA8 RID: 2984 RVA: 0x00007B42 File Offset: 0x00005D42
			public _OnPrepareToReceiveEntities_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000368 RID: 872
			// (get) Token: 0x06000BA9 RID: 2985 RVA: 0x0002F7E0 File Offset: 0x0002D9E0
			// (set) Token: 0x06000BAA RID: 2986 RVA: 0x00007B4B File Offset: 0x00005D4B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutPileView._OnPrepareToReceiveEntities_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutPileView._OnPrepareToReceiveEntities_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000369 RID: 873
			// (get) Token: 0x06000BAB RID: 2987 RVA: 0x0002F808 File Offset: 0x0002DA08
			// (set) Token: 0x06000BAC RID: 2988 RVA: 0x00007B66 File Offset: 0x00005D66
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutPileView._OnPrepareToReceiveEntities_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutPileView._OnPrepareToReceiveEntities_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700036A RID: 874
			// (get) Token: 0x06000BAD RID: 2989 RVA: 0x0002F838 File Offset: 0x0002DA38
			// (set) Token: 0x06000BAE RID: 2990 RVA: 0x00007B85 File Offset: 0x00005D85
			public unsafe LayoutPileView __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutPileView._OnPrepareToReceiveEntities_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LayoutPileView>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutPileView._OnPrepareToReceiveEntities_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700036B RID: 875
			// (get) Token: 0x06000BAF RID: 2991 RVA: 0x0002F868 File Offset: 0x0002DA68
			// (set) Token: 0x06000BB0 RID: 2992 RVA: 0x00007BA4 File Offset: 0x00005DA4
			public unsafe MoveContext context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutPileView._OnPrepareToReceiveEntities_d__7.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MoveContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutPileView._OnPrepareToReceiveEntities_d__7.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700036C RID: 876
			// (get) Token: 0x06000BB1 RID: 2993 RVA: 0x0002F898 File Offset: 0x0002DA98
			// (set) Token: 0x06000BB2 RID: 2994 RVA: 0x00007BC3 File Offset: 0x00005DC3
			public unsafe IEnumerator _prepareToReceiveEntities_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutPileView._OnPrepareToReceiveEntities_d__7.NativeFieldInfoPtr__prepareToReceiveEntities_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutPileView._OnPrepareToReceiveEntities_d__7.NativeFieldInfoPtr__prepareToReceiveEntities_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000744 RID: 1860
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000745 RID: 1861
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000746 RID: 1862
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000747 RID: 1863
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x04000748 RID: 1864
			private static readonly IntPtr NativeFieldInfoPtr__prepareToReceiveEntities_5__2;

			// Token: 0x04000749 RID: 1865
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400074A RID: 1866
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400074B RID: 1867
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400074C RID: 1868
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400074D RID: 1869
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400074E RID: 1870
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020000DF RID: 223
		[ObfuscatedName("lotus.LayoutPileView+<OnPrepareToRemoveEntities>d__8")]
		public sealed class _OnPrepareToRemoveEntities_d__8 : global::Il2CppSystem.Object
		{
			// Token: 0x06000BB3 RID: 2995 RVA: 0x0002F8C8 File Offset: 0x0002DAC8
			// Note: this type is marked as 'beforefieldinit'.
			static _OnPrepareToRemoveEntities_d__8()
			{
				Il2CppClassPointerStore<LayoutPileView._OnPrepareToRemoveEntities_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LayoutPileView>.NativeClassPtr, "<OnPrepareToRemoveEntities>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LayoutPileView._OnPrepareToRemoveEntities_d__8>.NativeClassPtr);
				LayoutPileView._OnPrepareToRemoveEntities_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutPileView._OnPrepareToRemoveEntities_d__8>.NativeClassPtr, "<>1__state");
				LayoutPileView._OnPrepareToRemoveEntities_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutPileView._OnPrepareToRemoveEntities_d__8>.NativeClassPtr, "<>2__current");
				LayoutPileView._OnPrepareToRemoveEntities_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutPileView._OnPrepareToRemoveEntities_d__8>.NativeClassPtr, "<>4__this");
				LayoutPileView._OnPrepareToRemoveEntities_d__8.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutPileView._OnPrepareToRemoveEntities_d__8>.NativeClassPtr, "context");
				LayoutPileView._OnPrepareToRemoveEntities_d__8.NativeFieldInfoPtr__prepareToRemoveEntities_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutPileView._OnPrepareToRemoveEntities_d__8>.NativeClassPtr, "<prepareToRemoveEntities>5__2");
				LayoutPileView._OnPrepareToRemoveEntities_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutPileView._OnPrepareToRemoveEntities_d__8>.NativeClassPtr, 100664018);
				LayoutPileView._OnPrepareToRemoveEntities_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutPileView._OnPrepareToRemoveEntities_d__8>.NativeClassPtr, 100664019);
				LayoutPileView._OnPrepareToRemoveEntities_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutPileView._OnPrepareToRemoveEntities_d__8>.NativeClassPtr, 100664020);
				LayoutPileView._OnPrepareToRemoveEntities_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutPileView._OnPrepareToRemoveEntities_d__8>.NativeClassPtr, 100664021);
				LayoutPileView._OnPrepareToRemoveEntities_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutPileView._OnPrepareToRemoveEntities_d__8>.NativeClassPtr, 100664022);
				LayoutPileView._OnPrepareToRemoveEntities_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutPileView._OnPrepareToRemoveEntities_d__8>.NativeClassPtr, 100664023);
			}

			// Token: 0x06000BB4 RID: 2996 RVA: 0x0002F9D0 File Offset: 0x0002DBD0
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnPrepareToRemoveEntities_d__8(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LayoutPileView._OnPrepareToRemoveEntities_d__8>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutPileView._OnPrepareToRemoveEntities_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000BB5 RID: 2997 RVA: 0x0002FA18 File Offset: 0x0002DC18
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutPileView._OnPrepareToRemoveEntities_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000BB6 RID: 2998 RVA: 0x0002FA4C File Offset: 0x0002DC4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111680, XrefRangeEnd = 1111691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutPileView._OnPrepareToRemoveEntities_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000374 RID: 884
			// (get) Token: 0x06000BB7 RID: 2999 RVA: 0x0002FA88 File Offset: 0x0002DC88
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutPileView._OnPrepareToRemoveEntities_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000BB8 RID: 3000 RVA: 0x0002FAC8 File Offset: 0x0002DCC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111691, XrefRangeEnd = 1111696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutPileView._OnPrepareToRemoveEntities_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000375 RID: 885
			// (get) Token: 0x06000BB9 RID: 3001 RVA: 0x0002FAFC File Offset: 0x0002DCFC
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutPileView._OnPrepareToRemoveEntities_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000BBA RID: 3002 RVA: 0x00007BE2 File Offset: 0x00005DE2
			public _OnPrepareToRemoveEntities_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700036F RID: 879
			// (get) Token: 0x06000BBB RID: 3003 RVA: 0x0002FB3C File Offset: 0x0002DD3C
			// (set) Token: 0x06000BBC RID: 3004 RVA: 0x00007BEB File Offset: 0x00005DEB
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutPileView._OnPrepareToRemoveEntities_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutPileView._OnPrepareToRemoveEntities_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000370 RID: 880
			// (get) Token: 0x06000BBD RID: 3005 RVA: 0x0002FB64 File Offset: 0x0002DD64
			// (set) Token: 0x06000BBE RID: 3006 RVA: 0x00007C06 File Offset: 0x00005E06
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutPileView._OnPrepareToRemoveEntities_d__8.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutPileView._OnPrepareToRemoveEntities_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000371 RID: 881
			// (get) Token: 0x06000BBF RID: 3007 RVA: 0x0002FB94 File Offset: 0x0002DD94
			// (set) Token: 0x06000BC0 RID: 3008 RVA: 0x00007C25 File Offset: 0x00005E25
			public unsafe LayoutPileView __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutPileView._OnPrepareToRemoveEntities_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LayoutPileView>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutPileView._OnPrepareToRemoveEntities_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000372 RID: 882
			// (get) Token: 0x06000BC1 RID: 3009 RVA: 0x0002FBC4 File Offset: 0x0002DDC4
			// (set) Token: 0x06000BC2 RID: 3010 RVA: 0x00007C44 File Offset: 0x00005E44
			public unsafe MoveContext context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutPileView._OnPrepareToRemoveEntities_d__8.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MoveContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutPileView._OnPrepareToRemoveEntities_d__8.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000373 RID: 883
			// (get) Token: 0x06000BC3 RID: 3011 RVA: 0x0002FBF4 File Offset: 0x0002DDF4
			// (set) Token: 0x06000BC4 RID: 3012 RVA: 0x00007C63 File Offset: 0x00005E63
			public unsafe IEnumerator _prepareToRemoveEntities_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutPileView._OnPrepareToRemoveEntities_d__8.NativeFieldInfoPtr__prepareToRemoveEntities_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutPileView._OnPrepareToRemoveEntities_d__8.NativeFieldInfoPtr__prepareToRemoveEntities_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400074F RID: 1871
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000750 RID: 1872
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000751 RID: 1873
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000752 RID: 1874
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x04000753 RID: 1875
			private static readonly IntPtr NativeFieldInfoPtr__prepareToRemoveEntities_5__2;

			// Token: 0x04000754 RID: 1876
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000755 RID: 1877
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000756 RID: 1878
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000757 RID: 1879
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000758 RID: 1880
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000759 RID: 1881
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
