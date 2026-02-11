using System;
using boardgames.match.behaviours;
using boardgames.voodoo;
using dwd.core.prefabs.implementations.byflavor;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using lotus;
using UnityEngine;
using voodoo.flavors;

namespace boardgames.match.voodoo
{
	// Token: 0x0200024B RID: 587
	public class StackedViewsLayout : MonoBehaviour
	{
		// Token: 0x06001A9F RID: 6815 RVA: 0x000745D0 File Offset: 0x000727D0
		// Note: this type is marked as 'beforefieldinit'.
		static StackedViewsLayout()
		{
			Il2CppClassPointerStore<StackedViewsLayout>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.voodoo", "StackedViewsLayout");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StackedViewsLayout>.NativeClassPtr);
			StackedViewsLayout.NativeFieldInfoPtr_visibleUnitScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackedViewsLayout>.NativeClassPtr, "visibleUnitScale");
			StackedViewsLayout.NativeFieldInfoPtr_stackCountInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackedViewsLayout>.NativeClassPtr, "stackCountInstance");
			StackedViewsLayout.NativeFieldInfoPtr_disableCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackedViewsLayout>.NativeClassPtr, "disableCount");
			StackedViewsLayout.NativeFieldInfoPtr_disableWhenLessThan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackedViewsLayout>.NativeClassPtr, "disableWhenLessThan");
			StackedViewsLayout.NativeFieldInfoPtr_container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackedViewsLayout>.NativeClassPtr, "container");
			StackedViewsLayout.NativeFieldInfoPtr_animateRemove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackedViewsLayout>.NativeClassPtr, "animateRemove");
			StackedViewsLayout.NativeFieldInfoPtr_unitProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackedViewsLayout>.NativeClassPtr, "unitProvider");
			StackedViewsLayout.NativeFieldInfoPtr_pileFlavors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackedViewsLayout>.NativeClassPtr, "pileFlavors");
			StackedViewsLayout.NativeFieldInfoPtr_updateManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackedViewsLayout>.NativeClassPtr, "updateManager");
			StackedViewsLayout.NativeFieldInfoPtr_entitiesProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackedViewsLayout>.NativeClassPtr, "entitiesProvider");
			StackedViewsLayout.NativeFieldInfoPtr_cachedFlavorContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackedViewsLayout>.NativeClassPtr, "cachedFlavorContext");
			StackedViewsLayout.NativeFieldInfoPtr_serializedInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackedViewsLayout>.NativeClassPtr, "serializedInstance");
			StackedViewsLayout.NativeFieldInfoPtr_localViews = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackedViewsLayout>.NativeClassPtr, "localViews");
			StackedViewsLayout.NativeMethodInfoPtr_get_AnimateRemove_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackedViewsLayout>.NativeClassPtr, 100667548);
			StackedViewsLayout.NativeMethodInfoPtr_set_AnimateRemove_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackedViewsLayout>.NativeClassPtr, 100667549);
			StackedViewsLayout.NativeMethodInfoPtr_Init_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackedViewsLayout>.NativeClassPtr, 100667550);
			StackedViewsLayout.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackedViewsLayout>.NativeClassPtr, 100667551);
			StackedViewsLayout.NativeMethodInfoPtr_setupContextCacheFromFlavors_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackedViewsLayout>.NativeClassPtr, 100667552);
			StackedViewsLayout.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackedViewsLayout>.NativeClassPtr, 100667553);
			StackedViewsLayout.NativeMethodInfoPtr_GetStackCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackedViewsLayout>.NativeClassPtr, 100667554);
			StackedViewsLayout.NativeMethodInfoPtr_Layout_Public_Virtual_Final_New_Void_List_1_UnitView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackedViewsLayout>.NativeClassPtr, 100667555);
			StackedViewsLayout.NativeMethodInfoPtr_GetSlotFor_Public_Virtual_Final_New_Transform_UnitView_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackedViewsLayout>.NativeClassPtr, 100667556);
			StackedViewsLayout.NativeMethodInfoPtr_OnPrepareToReceiveEntities_Public_Virtual_Final_New_IEnumerator_MoveContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackedViewsLayout>.NativeClassPtr, 100667557);
			StackedViewsLayout.NativeMethodInfoPtr_OnPrepareToRemoveEntities_Public_Virtual_Final_New_IEnumerator_MoveContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackedViewsLayout>.NativeClassPtr, 100667558);
			StackedViewsLayout.NativeMethodInfoPtr_OnViewsRemoved_Public_Virtual_Final_New_Void_List_1_UnitView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackedViewsLayout>.NativeClassPtr, 100667559);
			StackedViewsLayout.NativeMethodInfoPtr_updateStack_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackedViewsLayout>.NativeClassPtr, 100667560);
			StackedViewsLayout.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackedViewsLayout>.NativeClassPtr, 100667561);
			StackedViewsLayout.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackedViewsLayout>.NativeClassPtr, 100667562);
		}

		// Token: 0x17000722 RID: 1826
		// (get) Token: 0x06001AA0 RID: 6816 RVA: 0x00074830 File Offset: 0x00072A30
		// (set) Token: 0x06001AA1 RID: 6817 RVA: 0x0007486C File Offset: 0x00072A6C
		public unsafe bool AnimateRemove
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackedViewsLayout.NativeMethodInfoPtr_get_AnimateRemove_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackedViewsLayout.NativeMethodInfoPtr_set_AnimateRemove_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001AA2 RID: 6818 RVA: 0x000748AC File Offset: 0x00072AAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 532544, XrefRangeEnd = 532566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackedViewsLayout.NativeMethodInfoPtr_Init_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AA3 RID: 6819 RVA: 0x000748E0 File Offset: 0x00072AE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackedViewsLayout.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AA4 RID: 6820 RVA: 0x00074914 File Offset: 0x00072B14
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 532576, RefRangeEnd = 532579, XrefRangeStart = 532566, XrefRangeEnd = 532576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void setupContextCacheFromFlavors()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackedViewsLayout.NativeMethodInfoPtr_setupContextCacheFromFlavors_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AA5 RID: 6821 RVA: 0x00074948 File Offset: 0x00072B48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 532579, XrefRangeEnd = 532588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackedViewsLayout.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AA6 RID: 6822 RVA: 0x0007497C File Offset: 0x00072B7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 532588, XrefRangeEnd = 532595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetStackCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackedViewsLayout.NativeMethodInfoPtr_GetStackCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AA7 RID: 6823 RVA: 0x000749B8 File Offset: 0x00072BB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 532595, XrefRangeEnd = 532620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Layout(List<UnitView> views)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(views);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackedViewsLayout.NativeMethodInfoPtr_Layout_Public_Virtual_Final_New_Void_List_1_UnitView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001AA8 RID: 6824 RVA: 0x000749FC File Offset: 0x00072BFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 532624, RefRangeEnd = 532625, XrefRangeStart = 532620, XrefRangeEnd = 532624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Transform GetSlotFor(UnitView view, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(view);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackedViewsLayout.NativeMethodInfoPtr_GetSlotFor_Public_Virtual_Final_New_Transform_UnitView_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x06001AA9 RID: 6825 RVA: 0x00074A5C File Offset: 0x00072C5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 532625, XrefRangeEnd = 532629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator OnPrepareToReceiveEntities(MoveContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackedViewsLayout.NativeMethodInfoPtr_OnPrepareToReceiveEntities_Public_Virtual_Final_New_IEnumerator_MoveContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06001AAA RID: 6826 RVA: 0x00074AAC File Offset: 0x00072CAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 532629, XrefRangeEnd = 532635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator OnPrepareToRemoveEntities(MoveContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackedViewsLayout.NativeMethodInfoPtr_OnPrepareToRemoveEntities_Public_Virtual_Final_New_IEnumerator_MoveContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06001AAB RID: 6827 RVA: 0x00074AFC File Offset: 0x00072CFC
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnViewsRemoved(List<UnitView> views)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(views);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackedViewsLayout.NativeMethodInfoPtr_OnViewsRemoved_Public_Virtual_Final_New_Void_List_1_UnitView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001AAC RID: 6828 RVA: 0x00074B40 File Offset: 0x00072D40
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 532676, RefRangeEnd = 532678, XrefRangeStart = 532635, XrefRangeEnd = 532676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void updateStack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackedViewsLayout.NativeMethodInfoPtr_updateStack_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AAD RID: 6829 RVA: 0x00074B74 File Offset: 0x00072D74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 532678, XrefRangeEnd = 532692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackedViewsLayout.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AAE RID: 6830 RVA: 0x00074BA8 File Offset: 0x00072DA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 532692, XrefRangeEnd = 532700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StackedViewsLayout()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StackedViewsLayout>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackedViewsLayout.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AAF RID: 6831 RVA: 0x0000E897 File Offset: 0x0000CA97
		public StackedViewsLayout(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x06001AB0 RID: 6832 RVA: 0x00074BE4 File Offset: 0x00072DE4
		// (set) Token: 0x06001AB1 RID: 6833 RVA: 0x0000E8A0 File Offset: 0x0000CAA0
		public unsafe float visibleUnitScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackedViewsLayout.NativeFieldInfoPtr_visibleUnitScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackedViewsLayout.NativeFieldInfoPtr_visibleUnitScale)) = value;
			}
		}

		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x06001AB2 RID: 6834 RVA: 0x00074C0C File Offset: 0x00072E0C
		// (set) Token: 0x06001AB3 RID: 6835 RVA: 0x0000E8BB File Offset: 0x0000CABB
		public unsafe EntityView stackCountInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackedViewsLayout.NativeFieldInfoPtr_stackCountInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackedViewsLayout.NativeFieldInfoPtr_stackCountInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x06001AB4 RID: 6836 RVA: 0x00074C3C File Offset: 0x00072E3C
		// (set) Token: 0x06001AB5 RID: 6837 RVA: 0x0000E8DA File Offset: 0x0000CADA
		public unsafe bool disableCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackedViewsLayout.NativeFieldInfoPtr_disableCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackedViewsLayout.NativeFieldInfoPtr_disableCount)) = value;
			}
		}

		// Token: 0x17000718 RID: 1816
		// (get) Token: 0x06001AB6 RID: 6838 RVA: 0x00074C64 File Offset: 0x00072E64
		// (set) Token: 0x06001AB7 RID: 6839 RVA: 0x0000E8F5 File Offset: 0x0000CAF5
		public unsafe int disableWhenLessThan
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackedViewsLayout.NativeFieldInfoPtr_disableWhenLessThan);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackedViewsLayout.NativeFieldInfoPtr_disableWhenLessThan)) = value;
			}
		}

		// Token: 0x17000719 RID: 1817
		// (get) Token: 0x06001AB8 RID: 6840 RVA: 0x00074C8C File Offset: 0x00072E8C
		// (set) Token: 0x06001AB9 RID: 6841 RVA: 0x0000E910 File Offset: 0x0000CB10
		public unsafe Transform container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackedViewsLayout.NativeFieldInfoPtr_container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackedViewsLayout.NativeFieldInfoPtr_container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700071A RID: 1818
		// (get) Token: 0x06001ABA RID: 6842 RVA: 0x00074CBC File Offset: 0x00072EBC
		// (set) Token: 0x06001ABB RID: 6843 RVA: 0x0000E92F File Offset: 0x0000CB2F
		public unsafe bool animateRemove
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackedViewsLayout.NativeFieldInfoPtr_animateRemove);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackedViewsLayout.NativeFieldInfoPtr_animateRemove)) = value;
			}
		}

		// Token: 0x1700071B RID: 1819
		// (get) Token: 0x06001ABC RID: 6844 RVA: 0x00074CE4 File Offset: 0x00072EE4
		// (set) Token: 0x06001ABD RID: 6845 RVA: 0x0000E94A File Offset: 0x0000CB4A
		public unsafe FlavoredUnitViewProvider unitProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackedViewsLayout.NativeFieldInfoPtr_unitProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FlavoredUnitViewProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackedViewsLayout.NativeFieldInfoPtr_unitProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700071C RID: 1820
		// (get) Token: 0x06001ABE RID: 6846 RVA: 0x00074D14 File Offset: 0x00072F14
		// (set) Token: 0x06001ABF RID: 6847 RVA: 0x0000E969 File Offset: 0x0000CB69
		public unsafe PileFlavors pileFlavors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackedViewsLayout.NativeFieldInfoPtr_pileFlavors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PileFlavors>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackedViewsLayout.NativeFieldInfoPtr_pileFlavors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700071D RID: 1821
		// (get) Token: 0x06001AC0 RID: 6848 RVA: 0x00074D44 File Offset: 0x00072F44
		// (set) Token: 0x06001AC1 RID: 6849 RVA: 0x0000E988 File Offset: 0x0000CB88
		public unsafe UpdateManager updateManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackedViewsLayout.NativeFieldInfoPtr_updateManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UpdateManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackedViewsLayout.NativeFieldInfoPtr_updateManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700071E RID: 1822
		// (get) Token: 0x06001AC2 RID: 6850 RVA: 0x00074D74 File Offset: 0x00072F74
		// (set) Token: 0x06001AC3 RID: 6851 RVA: 0x0000E9A7 File Offset: 0x0000CBA7
		public unsafe DBGEntitiesProvider entitiesProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackedViewsLayout.NativeFieldInfoPtr_entitiesProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntitiesProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackedViewsLayout.NativeFieldInfoPtr_entitiesProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700071F RID: 1823
		// (get) Token: 0x06001AC4 RID: 6852 RVA: 0x00074DA4 File Offset: 0x00072FA4
		// (set) Token: 0x06001AC5 RID: 6853 RVA: 0x0000E9C6 File Offset: 0x0000CBC6
		public PrefabFlavorContext cachedFlavorContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackedViewsLayout.NativeFieldInfoPtr_cachedFlavorContext);
				return new PrefabFlavorContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PrefabFlavorContext>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackedViewsLayout.NativeFieldInfoPtr_cachedFlavorContext), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<PrefabFlavorContext>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000720 RID: 1824
		// (get) Token: 0x06001AC6 RID: 6854 RVA: 0x00074DD4 File Offset: 0x00072FD4
		// (set) Token: 0x06001AC7 RID: 6855 RVA: 0x0000E9F4 File Offset: 0x0000CBF4
		public unsafe bool serializedInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackedViewsLayout.NativeFieldInfoPtr_serializedInstance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackedViewsLayout.NativeFieldInfoPtr_serializedInstance)) = value;
			}
		}

		// Token: 0x17000721 RID: 1825
		// (get) Token: 0x06001AC8 RID: 6856 RVA: 0x00074DFC File Offset: 0x00072FFC
		// (set) Token: 0x06001AC9 RID: 6857 RVA: 0x0000EA0F File Offset: 0x0000CC0F
		public unsafe List<UnitView> localViews
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackedViewsLayout.NativeFieldInfoPtr_localViews);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<UnitView>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackedViewsLayout.NativeFieldInfoPtr_localViews), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400109F RID: 4255
		private static readonly IntPtr NativeFieldInfoPtr_visibleUnitScale;

		// Token: 0x040010A0 RID: 4256
		private static readonly IntPtr NativeFieldInfoPtr_stackCountInstance;

		// Token: 0x040010A1 RID: 4257
		private static readonly IntPtr NativeFieldInfoPtr_disableCount;

		// Token: 0x040010A2 RID: 4258
		private static readonly IntPtr NativeFieldInfoPtr_disableWhenLessThan;

		// Token: 0x040010A3 RID: 4259
		private static readonly IntPtr NativeFieldInfoPtr_container;

		// Token: 0x040010A4 RID: 4260
		private static readonly IntPtr NativeFieldInfoPtr_animateRemove;

		// Token: 0x040010A5 RID: 4261
		private static readonly IntPtr NativeFieldInfoPtr_unitProvider;

		// Token: 0x040010A6 RID: 4262
		private static readonly IntPtr NativeFieldInfoPtr_pileFlavors;

		// Token: 0x040010A7 RID: 4263
		private static readonly IntPtr NativeFieldInfoPtr_updateManager;

		// Token: 0x040010A8 RID: 4264
		private static readonly IntPtr NativeFieldInfoPtr_entitiesProvider;

		// Token: 0x040010A9 RID: 4265
		private static readonly IntPtr NativeFieldInfoPtr_cachedFlavorContext;

		// Token: 0x040010AA RID: 4266
		private static readonly IntPtr NativeFieldInfoPtr_serializedInstance;

		// Token: 0x040010AB RID: 4267
		private static readonly IntPtr NativeFieldInfoPtr_localViews;

		// Token: 0x040010AC RID: 4268
		private static readonly IntPtr NativeMethodInfoPtr_get_AnimateRemove_Public_get_Boolean_0;

		// Token: 0x040010AD RID: 4269
		private static readonly IntPtr NativeMethodInfoPtr_set_AnimateRemove_Public_set_Void_Boolean_0;

		// Token: 0x040010AE RID: 4270
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Final_New_Void_0;

		// Token: 0x040010AF RID: 4271
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040010B0 RID: 4272
		private static readonly IntPtr NativeMethodInfoPtr_setupContextCacheFromFlavors_Private_Void_0;

		// Token: 0x040010B1 RID: 4273
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040010B2 RID: 4274
		private static readonly IntPtr NativeMethodInfoPtr_GetStackCount_Public_Int32_0;

		// Token: 0x040010B3 RID: 4275
		private static readonly IntPtr NativeMethodInfoPtr_Layout_Public_Virtual_Final_New_Void_List_1_UnitView_0;

		// Token: 0x040010B4 RID: 4276
		private static readonly IntPtr NativeMethodInfoPtr_GetSlotFor_Public_Virtual_Final_New_Transform_UnitView_Int32_0;

		// Token: 0x040010B5 RID: 4277
		private static readonly IntPtr NativeMethodInfoPtr_OnPrepareToReceiveEntities_Public_Virtual_Final_New_IEnumerator_MoveContext_0;

		// Token: 0x040010B6 RID: 4278
		private static readonly IntPtr NativeMethodInfoPtr_OnPrepareToRemoveEntities_Public_Virtual_Final_New_IEnumerator_MoveContext_0;

		// Token: 0x040010B7 RID: 4279
		private static readonly IntPtr NativeMethodInfoPtr_OnViewsRemoved_Public_Virtual_Final_New_Void_List_1_UnitView_0;

		// Token: 0x040010B8 RID: 4280
		private static readonly IntPtr NativeMethodInfoPtr_updateStack_Private_Void_0;

		// Token: 0x040010B9 RID: 4281
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

		// Token: 0x040010BA RID: 4282
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200043D RID: 1085
		[ObfuscatedName("boardgames.match.voodoo.StackedViewsLayout+<OnPrepareToReceiveEntities>d__23")]
		public sealed class _OnPrepareToReceiveEntities_d__23 : global::Il2CppSystem.Object
		{
			// Token: 0x06003347 RID: 13127 RVA: 0x000C17C4 File Offset: 0x000BF9C4
			// Note: this type is marked as 'beforefieldinit'.
			static _OnPrepareToReceiveEntities_d__23()
			{
				Il2CppClassPointerStore<StackedViewsLayout._OnPrepareToReceiveEntities_d__23>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StackedViewsLayout>.NativeClassPtr, "<OnPrepareToReceiveEntities>d__23");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StackedViewsLayout._OnPrepareToReceiveEntities_d__23>.NativeClassPtr);
				StackedViewsLayout._OnPrepareToReceiveEntities_d__23.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackedViewsLayout._OnPrepareToReceiveEntities_d__23>.NativeClassPtr, "<>1__state");
				StackedViewsLayout._OnPrepareToReceiveEntities_d__23.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackedViewsLayout._OnPrepareToReceiveEntities_d__23>.NativeClassPtr, "<>2__current");
				StackedViewsLayout._OnPrepareToReceiveEntities_d__23.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackedViewsLayout._OnPrepareToReceiveEntities_d__23>.NativeClassPtr, 100667563);
				StackedViewsLayout._OnPrepareToReceiveEntities_d__23.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackedViewsLayout._OnPrepareToReceiveEntities_d__23>.NativeClassPtr, 100667564);
				StackedViewsLayout._OnPrepareToReceiveEntities_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackedViewsLayout._OnPrepareToReceiveEntities_d__23>.NativeClassPtr, 100667565);
				StackedViewsLayout._OnPrepareToReceiveEntities_d__23.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackedViewsLayout._OnPrepareToReceiveEntities_d__23>.NativeClassPtr, 100667566);
				StackedViewsLayout._OnPrepareToReceiveEntities_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackedViewsLayout._OnPrepareToReceiveEntities_d__23>.NativeClassPtr, 100667567);
				StackedViewsLayout._OnPrepareToReceiveEntities_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackedViewsLayout._OnPrepareToReceiveEntities_d__23>.NativeClassPtr, 100667568);
			}

			// Token: 0x06003348 RID: 13128 RVA: 0x000C1890 File Offset: 0x000BFA90
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnPrepareToReceiveEntities_d__23(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StackedViewsLayout._OnPrepareToReceiveEntities_d__23>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackedViewsLayout._OnPrepareToReceiveEntities_d__23.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003349 RID: 13129 RVA: 0x000C18D8 File Offset: 0x000BFAD8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackedViewsLayout._OnPrepareToReceiveEntities_d__23.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600334A RID: 13130 RVA: 0x000C190C File Offset: 0x000BFB0C
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackedViewsLayout._OnPrepareToReceiveEntities_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000EF6 RID: 3830
			// (get) Token: 0x0600334B RID: 13131 RVA: 0x000C1948 File Offset: 0x000BFB48
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackedViewsLayout._OnPrepareToReceiveEntities_d__23.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600334C RID: 13132 RVA: 0x000C1988 File Offset: 0x000BFB88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 532492, XrefRangeEnd = 532497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackedViewsLayout._OnPrepareToReceiveEntities_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000EF7 RID: 3831
			// (get) Token: 0x0600334D RID: 13133 RVA: 0x000C19BC File Offset: 0x000BFBBC
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackedViewsLayout._OnPrepareToReceiveEntities_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600334E RID: 13134 RVA: 0x0001A7AB File Offset: 0x000189AB
			public _OnPrepareToReceiveEntities_d__23(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000EF4 RID: 3828
			// (get) Token: 0x0600334F RID: 13135 RVA: 0x000C19FC File Offset: 0x000BFBFC
			// (set) Token: 0x06003350 RID: 13136 RVA: 0x0001A7B4 File Offset: 0x000189B4
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackedViewsLayout._OnPrepareToReceiveEntities_d__23.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackedViewsLayout._OnPrepareToReceiveEntities_d__23.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000EF5 RID: 3829
			// (get) Token: 0x06003351 RID: 13137 RVA: 0x000C1A24 File Offset: 0x000BFC24
			// (set) Token: 0x06003352 RID: 13138 RVA: 0x0001A7CF File Offset: 0x000189CF
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackedViewsLayout._OnPrepareToReceiveEntities_d__23.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackedViewsLayout._OnPrepareToReceiveEntities_d__23.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001FA0 RID: 8096
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001FA1 RID: 8097
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001FA2 RID: 8098
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001FA3 RID: 8099
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001FA4 RID: 8100
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001FA5 RID: 8101
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001FA6 RID: 8102
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001FA7 RID: 8103
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200043E RID: 1086
		[ObfuscatedName("boardgames.match.voodoo.StackedViewsLayout+<OnPrepareToRemoveEntities>d__24")]
		public sealed class _OnPrepareToRemoveEntities_d__24 : global::Il2CppSystem.Object
		{
			// Token: 0x06003353 RID: 13139 RVA: 0x000C1A54 File Offset: 0x000BFC54
			// Note: this type is marked as 'beforefieldinit'.
			static _OnPrepareToRemoveEntities_d__24()
			{
				Il2CppClassPointerStore<StackedViewsLayout._OnPrepareToRemoveEntities_d__24>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StackedViewsLayout>.NativeClassPtr, "<OnPrepareToRemoveEntities>d__24");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StackedViewsLayout._OnPrepareToRemoveEntities_d__24>.NativeClassPtr);
				StackedViewsLayout._OnPrepareToRemoveEntities_d__24.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackedViewsLayout._OnPrepareToRemoveEntities_d__24>.NativeClassPtr, "<>1__state");
				StackedViewsLayout._OnPrepareToRemoveEntities_d__24.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackedViewsLayout._OnPrepareToRemoveEntities_d__24>.NativeClassPtr, "<>2__current");
				StackedViewsLayout._OnPrepareToRemoveEntities_d__24.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackedViewsLayout._OnPrepareToRemoveEntities_d__24>.NativeClassPtr, "<>4__this");
				StackedViewsLayout._OnPrepareToRemoveEntities_d__24.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackedViewsLayout._OnPrepareToRemoveEntities_d__24>.NativeClassPtr, "context");
				StackedViewsLayout._OnPrepareToRemoveEntities_d__24.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackedViewsLayout._OnPrepareToRemoveEntities_d__24>.NativeClassPtr, "<>7__wrap1");
				StackedViewsLayout._OnPrepareToRemoveEntities_d__24.NativeFieldInfoPtr__triggerAndBlock_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackedViewsLayout._OnPrepareToRemoveEntities_d__24>.NativeClassPtr, "<triggerAndBlock>5__3");
				StackedViewsLayout._OnPrepareToRemoveEntities_d__24.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackedViewsLayout._OnPrepareToRemoveEntities_d__24>.NativeClassPtr, 100667569);
				StackedViewsLayout._OnPrepareToRemoveEntities_d__24.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackedViewsLayout._OnPrepareToRemoveEntities_d__24>.NativeClassPtr, 100667570);
				StackedViewsLayout._OnPrepareToRemoveEntities_d__24.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackedViewsLayout._OnPrepareToRemoveEntities_d__24>.NativeClassPtr, 100667571);
				StackedViewsLayout._OnPrepareToRemoveEntities_d__24.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackedViewsLayout._OnPrepareToRemoveEntities_d__24>.NativeClassPtr, 100667572);
				StackedViewsLayout._OnPrepareToRemoveEntities_d__24.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackedViewsLayout._OnPrepareToRemoveEntities_d__24>.NativeClassPtr, 100667573);
				StackedViewsLayout._OnPrepareToRemoveEntities_d__24.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackedViewsLayout._OnPrepareToRemoveEntities_d__24>.NativeClassPtr, 100667574);
				StackedViewsLayout._OnPrepareToRemoveEntities_d__24.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackedViewsLayout._OnPrepareToRemoveEntities_d__24>.NativeClassPtr, 100667575);
			}

			// Token: 0x06003354 RID: 13140 RVA: 0x000C1B84 File Offset: 0x000BFD84
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnPrepareToRemoveEntities_d__24(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StackedViewsLayout._OnPrepareToRemoveEntities_d__24>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackedViewsLayout._OnPrepareToRemoveEntities_d__24.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003355 RID: 13141 RVA: 0x000C1BCC File Offset: 0x000BFDCC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 532502, RefRangeEnd = 532503, XrefRangeStart = 532497, XrefRangeEnd = 532502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackedViewsLayout._OnPrepareToRemoveEntities_d__24.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003356 RID: 13142 RVA: 0x000C1C00 File Offset: 0x000BFE00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 532503, XrefRangeEnd = 532536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackedViewsLayout._OnPrepareToRemoveEntities_d__24.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003357 RID: 13143 RVA: 0x000C1C3C File Offset: 0x000BFE3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 532536, XrefRangeEnd = 532539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackedViewsLayout._OnPrepareToRemoveEntities_d__24.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000EFE RID: 3838
			// (get) Token: 0x06003358 RID: 13144 RVA: 0x000C1C70 File Offset: 0x000BFE70
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackedViewsLayout._OnPrepareToRemoveEntities_d__24.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003359 RID: 13145 RVA: 0x000C1CB0 File Offset: 0x000BFEB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 532539, XrefRangeEnd = 532544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackedViewsLayout._OnPrepareToRemoveEntities_d__24.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000EFF RID: 3839
			// (get) Token: 0x0600335A RID: 13146 RVA: 0x000C1CE4 File Offset: 0x000BFEE4
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackedViewsLayout._OnPrepareToRemoveEntities_d__24.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600335B RID: 13147 RVA: 0x0001A7EE File Offset: 0x000189EE
			public _OnPrepareToRemoveEntities_d__24(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000EF8 RID: 3832
			// (get) Token: 0x0600335C RID: 13148 RVA: 0x000C1D24 File Offset: 0x000BFF24
			// (set) Token: 0x0600335D RID: 13149 RVA: 0x0001A7F7 File Offset: 0x000189F7
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackedViewsLayout._OnPrepareToRemoveEntities_d__24.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackedViewsLayout._OnPrepareToRemoveEntities_d__24.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000EF9 RID: 3833
			// (get) Token: 0x0600335E RID: 13150 RVA: 0x000C1D4C File Offset: 0x000BFF4C
			// (set) Token: 0x0600335F RID: 13151 RVA: 0x0001A812 File Offset: 0x00018A12
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackedViewsLayout._OnPrepareToRemoveEntities_d__24.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackedViewsLayout._OnPrepareToRemoveEntities_d__24.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000EFA RID: 3834
			// (get) Token: 0x06003360 RID: 13152 RVA: 0x000C1D7C File Offset: 0x000BFF7C
			// (set) Token: 0x06003361 RID: 13153 RVA: 0x0001A831 File Offset: 0x00018A31
			public unsafe StackedViewsLayout __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackedViewsLayout._OnPrepareToRemoveEntities_d__24.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StackedViewsLayout>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackedViewsLayout._OnPrepareToRemoveEntities_d__24.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000EFB RID: 3835
			// (get) Token: 0x06003362 RID: 13154 RVA: 0x000C1DAC File Offset: 0x000BFFAC
			// (set) Token: 0x06003363 RID: 13155 RVA: 0x0001A850 File Offset: 0x00018A50
			public unsafe MoveContext context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackedViewsLayout._OnPrepareToRemoveEntities_d__24.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MoveContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackedViewsLayout._OnPrepareToRemoveEntities_d__24.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000EFC RID: 3836
			// (get) Token: 0x06003364 RID: 13156 RVA: 0x000C1DDC File Offset: 0x000BFFDC
			// (set) Token: 0x06003365 RID: 13157 RVA: 0x0001A86F File Offset: 0x00018A6F
			public List<UnitView>.Enumerator __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackedViewsLayout._OnPrepareToRemoveEntities_d__24.NativeFieldInfoPtr___7__wrap1);
					return new List<UnitView>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<UnitView>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackedViewsLayout._OnPrepareToRemoveEntities_d__24.NativeFieldInfoPtr___7__wrap1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<UnitView>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000EFD RID: 3837
			// (get) Token: 0x06003366 RID: 13158 RVA: 0x000C1E0C File Offset: 0x000C000C
			// (set) Token: 0x06003367 RID: 13159 RVA: 0x0001A89D File Offset: 0x00018A9D
			public unsafe IEnumerator _triggerAndBlock_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackedViewsLayout._OnPrepareToRemoveEntities_d__24.NativeFieldInfoPtr__triggerAndBlock_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackedViewsLayout._OnPrepareToRemoveEntities_d__24.NativeFieldInfoPtr__triggerAndBlock_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001FA8 RID: 8104
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001FA9 RID: 8105
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001FAA RID: 8106
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001FAB RID: 8107
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x04001FAC RID: 8108
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04001FAD RID: 8109
			private static readonly IntPtr NativeFieldInfoPtr__triggerAndBlock_5__3;

			// Token: 0x04001FAE RID: 8110
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001FAF RID: 8111
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001FB0 RID: 8112
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001FB1 RID: 8113
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04001FB2 RID: 8114
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001FB3 RID: 8115
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001FB4 RID: 8116
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
