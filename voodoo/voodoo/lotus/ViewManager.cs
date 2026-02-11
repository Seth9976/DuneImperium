using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace lotus
{
	// Token: 0x02000084 RID: 132
	public class ViewManager : MonoBehaviour
	{
		// Token: 0x060007D5 RID: 2005 RVA: 0x0002336C File Offset: 0x0002156C
		// Note: this type is marked as 'beforefieldinit'.
		static ViewManager()
		{
			Il2CppClassPointerStore<ViewManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lotus", "ViewManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ViewManager>.NativeClassPtr);
			ViewManager.NativeFieldInfoPtr_defaultUnit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewManager>.NativeClassPtr, "defaultUnit");
			ViewManager.NativeFieldInfoPtr_pathGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewManager>.NativeClassPtr, "pathGroup");
			ViewManager.NativeFieldInfoPtr_OnStateInitialize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewManager>.NativeClassPtr, "OnStateInitialize");
			ViewManager.NativeFieldInfoPtr_OnStateUninitialize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewManager>.NativeClassPtr, "OnStateUninitialize");
			ViewManager.NativeFieldInfoPtr_viewLayersMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewManager>.NativeClassPtr, "viewLayersMap");
			ViewManager.NativeFieldInfoPtr_containerViewsMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewManager>.NativeClassPtr, "containerViewsMap");
			ViewManager.NativeFieldInfoPtr_fallbackContainers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewManager>.NativeClassPtr, "fallbackContainers");
			ViewManager.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewManager>.NativeClassPtr, 100664344);
			ViewManager.NativeMethodInfoPtr_init_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewManager>.NativeClassPtr, 100664345);
			ViewManager.NativeMethodInfoPtr_AddView_Public_Void_EntityView_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewManager>.NativeClassPtr, 100664346);
			ViewManager.NativeMethodInfoPtr_RemoveView_Public_Void_EntityID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewManager>.NativeClassPtr, 100664347);
			ViewManager.NativeMethodInfoPtr_ViewFor_Public_EntityView_EntityID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewManager>.NativeClassPtr, 100664348);
			ViewManager.NativeMethodInfoPtr_TryGetViewFor_Public_Boolean_EntityID_byref_EntityView_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewManager>.NativeClassPtr, 100664349);
			ViewManager.NativeMethodInfoPtr_LayerFor_Private_Dictionary_2_EntityID_EntityView_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewManager>.NativeClassPtr, 100664350);
			ViewManager.NativeMethodInfoPtr_Clear_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewManager>.NativeClassPtr, 100664351);
			ViewManager.NativeMethodInfoPtr_HasViewFor_Public_Boolean_EntityID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewManager>.NativeClassPtr, 100664352);
			ViewManager.NativeMethodInfoPtr_HasContainerViewFor_Public_Boolean_EntityID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewManager>.NativeClassPtr, 100664353);
			ViewManager.NativeMethodInfoPtr_AddPathToContext_Public_Void_MoveContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewManager>.NativeClassPtr, 100664354);
			ViewManager.NativeMethodInfoPtr_OnDeserialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewManager>.NativeClassPtr, 100664355);
			ViewManager.NativeMethodInfoPtr_DeserializeOverTime_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewManager>.NativeClassPtr, 100664356);
			ViewManager.NativeMethodInfoPtr_RequestFallbackDestination_Public_ContainerView_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewManager>.NativeClassPtr, 100664357);
			ViewManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewManager>.NativeClassPtr, 100664358);
		}

		// Token: 0x060007D6 RID: 2006 RVA: 0x00023554 File Offset: 0x00021754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1114891, XrefRangeEnd = 1114894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewManager.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007D7 RID: 2007 RVA: 0x00023588 File Offset: 0x00021788
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ViewManager.NativeMethodInfoPtr_init_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x000235C4 File Offset: 0x000217C4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1114963, RefRangeEnd = 1114969, XrefRangeStart = 1114894, XrefRangeEnd = 1114963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddView(EntityView view, int viewLayer = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(view);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref viewLayer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewManager.NativeMethodInfoPtr_AddView_Public_Void_EntityView_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x00023614 File Offset: 0x00021814
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1114980, RefRangeEnd = 1114992, XrefRangeStart = 1114969, XrefRangeEnd = 1114980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveView(EntityID entityID, int viewLayer = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref viewLayer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewManager.NativeMethodInfoPtr_RemoveView_Public_Void_EntityID_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x00023664 File Offset: 0x00021864
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 1114996, RefRangeEnd = 1115023, XrefRangeStart = 1114992, XrefRangeEnd = 1114996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityView ViewFor(EntityID entityID, int viewLayer = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref viewLayer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewManager.NativeMethodInfoPtr_ViewFor_Public_EntityView_EntityID_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr3) : null;
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x000236C4 File Offset: 0x000218C4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1115029, RefRangeEnd = 1115036, XrefRangeStart = 1115023, XrefRangeEnd = 1115029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetViewFor(EntityID entityID, out EntityView entityView, int viewLayer = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityID);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref viewLayer;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ViewManager.NativeMethodInfoPtr_TryGetViewFor_Public_Boolean_EntityID_byref_EntityView_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			entityView = ((intPtr4 == 0) ? null : new EntityView(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x00023744 File Offset: 0x00021944
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1115048, RefRangeEnd = 1115056, XrefRangeStart = 1115036, XrefRangeEnd = 1115048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dictionary<EntityID, EntityView> LayerFor(int viewLayer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref viewLayer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewManager.NativeMethodInfoPtr_LayerFor_Private_Dictionary_2_EntityID_EntityView_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<EntityID, EntityView>>(intPtr3) : null;
			}
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x00023790 File Offset: 0x00021990
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115056, XrefRangeEnd = 1115099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ViewManager.NativeMethodInfoPtr_Clear_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x000237CC File Offset: 0x000219CC
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 1115105, RefRangeEnd = 1115120, XrefRangeStart = 1115099, XrefRangeEnd = 1115105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasViewFor(EntityID entityID, int viewLayer = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref viewLayer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewManager.NativeMethodInfoPtr_HasViewFor_Public_Boolean_EntityID_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x00023828 File Offset: 0x00021A28
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1115124, RefRangeEnd = 1115128, XrefRangeStart = 1115120, XrefRangeEnd = 1115124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasContainerViewFor(EntityID entityID, int viewLayer = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref viewLayer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewManager.NativeMethodInfoPtr_HasContainerViewFor_Public_Boolean_EntityID_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x00023884 File Offset: 0x00021A84
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1115129, RefRangeEnd = 1115131, XrefRangeStart = 1115128, XrefRangeEnd = 1115129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddPathToContext(MoveContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewManager.NativeMethodInfoPtr_AddPathToContext_Public_Void_MoveContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x000238C8 File Offset: 0x00021AC8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1115149, RefRangeEnd = 1115151, XrefRangeStart = 1115131, XrefRangeEnd = 1115149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDeserialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewManager.NativeMethodInfoPtr_OnDeserialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x000238FC File Offset: 0x00021AFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115151, XrefRangeEnd = 1115156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DeserializeOverTime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewManager.NativeMethodInfoPtr_DeserializeOverTime_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060007E3 RID: 2019 RVA: 0x0002393C File Offset: 0x00021B3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1115197, RefRangeEnd = 1115198, XrefRangeStart = 1115156, XrefRangeEnd = 1115197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContainerView RequestFallbackDestination(EntityID expectedDestination)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expectedDestination);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewManager.NativeMethodInfoPtr_RequestFallbackDestination_Public_ContainerView_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ContainerView>(intPtr3) : null;
			}
		}

		// Token: 0x060007E4 RID: 2020 RVA: 0x0002398C File Offset: 0x00021B8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1115206, RefRangeEnd = 1115207, XrefRangeStart = 1115198, XrefRangeEnd = 1115206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ViewManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ViewManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x00005DA9 File Offset: 0x00003FA9
		public ViewManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x060007E6 RID: 2022 RVA: 0x000239C8 File Offset: 0x00021BC8
		// (set) Token: 0x060007E7 RID: 2023 RVA: 0x00005DB2 File Offset: 0x00003FB2
		public unsafe UnitView defaultUnit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewManager.NativeFieldInfoPtr_defaultUnit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnitView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewManager.NativeFieldInfoPtr_defaultUnit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x060007E8 RID: 2024 RVA: 0x000239F8 File Offset: 0x00021BF8
		// (set) Token: 0x060007E9 RID: 2025 RVA: 0x00005DD1 File Offset: 0x00003FD1
		public unsafe PathProvider pathGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewManager.NativeFieldInfoPtr_pathGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PathProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewManager.NativeFieldInfoPtr_pathGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x060007EA RID: 2026 RVA: 0x00023A28 File Offset: 0x00021C28
		// (set) Token: 0x060007EB RID: 2027 RVA: 0x00005DF0 File Offset: 0x00003FF0
		public unsafe UnityEvent OnStateInitialize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewManager.NativeFieldInfoPtr_OnStateInitialize);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewManager.NativeFieldInfoPtr_OnStateInitialize), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x060007EC RID: 2028 RVA: 0x00023A58 File Offset: 0x00021C58
		// (set) Token: 0x060007ED RID: 2029 RVA: 0x00005E0F File Offset: 0x0000400F
		public unsafe UnityEvent OnStateUninitialize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewManager.NativeFieldInfoPtr_OnStateUninitialize);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewManager.NativeFieldInfoPtr_OnStateUninitialize), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x060007EE RID: 2030 RVA: 0x00023A88 File Offset: 0x00021C88
		// (set) Token: 0x060007EF RID: 2031 RVA: 0x00005E2E File Offset: 0x0000402E
		public unsafe Dictionary<int, Dictionary<EntityID, EntityView>> viewLayersMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewManager.NativeFieldInfoPtr_viewLayersMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Dictionary<EntityID, EntityView>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewManager.NativeFieldInfoPtr_viewLayersMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x060007F0 RID: 2032 RVA: 0x00023AB8 File Offset: 0x00021CB8
		// (set) Token: 0x060007F1 RID: 2033 RVA: 0x00005E4D File Offset: 0x0000404D
		public unsafe Dictionary<EntityID, EntityView> containerViewsMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewManager.NativeFieldInfoPtr_containerViewsMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<EntityID, EntityView>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewManager.NativeFieldInfoPtr_containerViewsMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x060007F2 RID: 2034 RVA: 0x00023AE8 File Offset: 0x00021CE8
		// (set) Token: 0x060007F3 RID: 2035 RVA: 0x00005E6C File Offset: 0x0000406C
		public unsafe Dictionary<EntityID, ContainerView> fallbackContainers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewManager.NativeFieldInfoPtr_fallbackContainers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<EntityID, ContainerView>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewManager.NativeFieldInfoPtr_fallbackContainers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040004E5 RID: 1253
		private static readonly IntPtr NativeFieldInfoPtr_defaultUnit;

		// Token: 0x040004E6 RID: 1254
		private static readonly IntPtr NativeFieldInfoPtr_pathGroup;

		// Token: 0x040004E7 RID: 1255
		private static readonly IntPtr NativeFieldInfoPtr_OnStateInitialize;

		// Token: 0x040004E8 RID: 1256
		private static readonly IntPtr NativeFieldInfoPtr_OnStateUninitialize;

		// Token: 0x040004E9 RID: 1257
		private static readonly IntPtr NativeFieldInfoPtr_viewLayersMap;

		// Token: 0x040004EA RID: 1258
		private static readonly IntPtr NativeFieldInfoPtr_containerViewsMap;

		// Token: 0x040004EB RID: 1259
		private static readonly IntPtr NativeFieldInfoPtr_fallbackContainers;

		// Token: 0x040004EC RID: 1260
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040004ED RID: 1261
		private static readonly IntPtr NativeMethodInfoPtr_init_Protected_Virtual_New_Void_0;

		// Token: 0x040004EE RID: 1262
		private static readonly IntPtr NativeMethodInfoPtr_AddView_Public_Void_EntityView_Int32_0;

		// Token: 0x040004EF RID: 1263
		private static readonly IntPtr NativeMethodInfoPtr_RemoveView_Public_Void_EntityID_Int32_0;

		// Token: 0x040004F0 RID: 1264
		private static readonly IntPtr NativeMethodInfoPtr_ViewFor_Public_EntityView_EntityID_Int32_0;

		// Token: 0x040004F1 RID: 1265
		private static readonly IntPtr NativeMethodInfoPtr_TryGetViewFor_Public_Boolean_EntityID_byref_EntityView_Int32_0;

		// Token: 0x040004F2 RID: 1266
		private static readonly IntPtr NativeMethodInfoPtr_LayerFor_Private_Dictionary_2_EntityID_EntityView_Int32_0;

		// Token: 0x040004F3 RID: 1267
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_New_Void_0;

		// Token: 0x040004F4 RID: 1268
		private static readonly IntPtr NativeMethodInfoPtr_HasViewFor_Public_Boolean_EntityID_Int32_0;

		// Token: 0x040004F5 RID: 1269
		private static readonly IntPtr NativeMethodInfoPtr_HasContainerViewFor_Public_Boolean_EntityID_Int32_0;

		// Token: 0x040004F6 RID: 1270
		private static readonly IntPtr NativeMethodInfoPtr_AddPathToContext_Public_Void_MoveContext_0;

		// Token: 0x040004F7 RID: 1271
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserialize_Public_Void_0;

		// Token: 0x040004F8 RID: 1272
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeOverTime_Public_IEnumerator_0;

		// Token: 0x040004F9 RID: 1273
		private static readonly IntPtr NativeMethodInfoPtr_RequestFallbackDestination_Public_ContainerView_EntityID_0;

		// Token: 0x040004FA RID: 1274
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020000FD RID: 253
		[ObfuscatedName("lotus.ViewManager+<DeserializeOverTime>d__19")]
		public sealed class _DeserializeOverTime_d__19 : global::Il2CppSystem.Object
		{
			// Token: 0x06000CE2 RID: 3298 RVA: 0x00033008 File Offset: 0x00031208
			// Note: this type is marked as 'beforefieldinit'.
			static _DeserializeOverTime_d__19()
			{
				Il2CppClassPointerStore<ViewManager._DeserializeOverTime_d__19>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ViewManager>.NativeClassPtr, "<DeserializeOverTime>d__19");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ViewManager._DeserializeOverTime_d__19>.NativeClassPtr);
				ViewManager._DeserializeOverTime_d__19.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewManager._DeserializeOverTime_d__19>.NativeClassPtr, "<>1__state");
				ViewManager._DeserializeOverTime_d__19.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewManager._DeserializeOverTime_d__19>.NativeClassPtr, "<>2__current");
				ViewManager._DeserializeOverTime_d__19.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewManager._DeserializeOverTime_d__19>.NativeClassPtr, "<>4__this");
				ViewManager._DeserializeOverTime_d__19.NativeFieldInfoPtr__context_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewManager._DeserializeOverTime_d__19>.NativeClassPtr, "<context>5__2");
				ViewManager._DeserializeOverTime_d__19.NativeFieldInfoPtr__batchSize_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewManager._DeserializeOverTime_d__19>.NativeClassPtr, "<batchSize>5__3");
				ViewManager._DeserializeOverTime_d__19.NativeFieldInfoPtr__batchCount_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewManager._DeserializeOverTime_d__19>.NativeClassPtr, "<batchCount>5__4");
				ViewManager._DeserializeOverTime_d__19.NativeFieldInfoPtr___7__wrap4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewManager._DeserializeOverTime_d__19>.NativeClassPtr, "<>7__wrap4");
				ViewManager._DeserializeOverTime_d__19.NativeFieldInfoPtr___7__wrap5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewManager._DeserializeOverTime_d__19>.NativeClassPtr, "<>7__wrap5");
				ViewManager._DeserializeOverTime_d__19.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewManager._DeserializeOverTime_d__19>.NativeClassPtr, 100664359);
				ViewManager._DeserializeOverTime_d__19.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewManager._DeserializeOverTime_d__19>.NativeClassPtr, 100664360);
				ViewManager._DeserializeOverTime_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewManager._DeserializeOverTime_d__19>.NativeClassPtr, 100664361);
				ViewManager._DeserializeOverTime_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewManager._DeserializeOverTime_d__19>.NativeClassPtr, 100664362);
				ViewManager._DeserializeOverTime_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewManager._DeserializeOverTime_d__19>.NativeClassPtr, 100664363);
				ViewManager._DeserializeOverTime_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewManager._DeserializeOverTime_d__19>.NativeClassPtr, 100664364);
			}

			// Token: 0x06000CE3 RID: 3299 RVA: 0x0003314C File Offset: 0x0003134C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DeserializeOverTime_d__19(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ViewManager._DeserializeOverTime_d__19>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewManager._DeserializeOverTime_d__19.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000CE4 RID: 3300 RVA: 0x00033194 File Offset: 0x00031394
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewManager._DeserializeOverTime_d__19.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000CE5 RID: 3301 RVA: 0x000331C8 File Offset: 0x000313C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1114865, XrefRangeEnd = 1114886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewManager._DeserializeOverTime_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170003D4 RID: 980
			// (get) Token: 0x06000CE6 RID: 3302 RVA: 0x00033204 File Offset: 0x00031404
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewManager._DeserializeOverTime_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000CE7 RID: 3303 RVA: 0x00033244 File Offset: 0x00031444
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1114886, XrefRangeEnd = 1114891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewManager._DeserializeOverTime_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170003D5 RID: 981
			// (get) Token: 0x06000CE8 RID: 3304 RVA: 0x00033278 File Offset: 0x00031478
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewManager._DeserializeOverTime_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000CE9 RID: 3305 RVA: 0x00008593 File Offset: 0x00006793
			public _DeserializeOverTime_d__19(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170003CC RID: 972
			// (get) Token: 0x06000CEA RID: 3306 RVA: 0x000332B8 File Offset: 0x000314B8
			// (set) Token: 0x06000CEB RID: 3307 RVA: 0x0000859C File Offset: 0x0000679C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewManager._DeserializeOverTime_d__19.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewManager._DeserializeOverTime_d__19.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170003CD RID: 973
			// (get) Token: 0x06000CEC RID: 3308 RVA: 0x000332E0 File Offset: 0x000314E0
			// (set) Token: 0x06000CED RID: 3309 RVA: 0x000085B7 File Offset: 0x000067B7
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewManager._DeserializeOverTime_d__19.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewManager._DeserializeOverTime_d__19.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003CE RID: 974
			// (get) Token: 0x06000CEE RID: 3310 RVA: 0x00033310 File Offset: 0x00031510
			// (set) Token: 0x06000CEF RID: 3311 RVA: 0x000085D6 File Offset: 0x000067D6
			public unsafe ViewManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewManager._DeserializeOverTime_d__19.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ViewManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewManager._DeserializeOverTime_d__19.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003CF RID: 975
			// (get) Token: 0x06000CF0 RID: 3312 RVA: 0x00033340 File Offset: 0x00031540
			// (set) Token: 0x06000CF1 RID: 3313 RVA: 0x000085F5 File Offset: 0x000067F5
			public unsafe EntityInitializationContext _context_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewManager._DeserializeOverTime_d__19.NativeFieldInfoPtr__context_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityInitializationContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewManager._DeserializeOverTime_d__19.NativeFieldInfoPtr__context_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003D0 RID: 976
			// (get) Token: 0x06000CF2 RID: 3314 RVA: 0x00033370 File Offset: 0x00031570
			// (set) Token: 0x06000CF3 RID: 3315 RVA: 0x00008614 File Offset: 0x00006814
			public unsafe int _batchSize_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewManager._DeserializeOverTime_d__19.NativeFieldInfoPtr__batchSize_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewManager._DeserializeOverTime_d__19.NativeFieldInfoPtr__batchSize_5__3)) = value;
				}
			}

			// Token: 0x170003D1 RID: 977
			// (get) Token: 0x06000CF4 RID: 3316 RVA: 0x00033398 File Offset: 0x00031598
			// (set) Token: 0x06000CF5 RID: 3317 RVA: 0x0000862F File Offset: 0x0000682F
			public unsafe int _batchCount_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewManager._DeserializeOverTime_d__19.NativeFieldInfoPtr__batchCount_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewManager._DeserializeOverTime_d__19.NativeFieldInfoPtr__batchCount_5__4)) = value;
				}
			}

			// Token: 0x170003D2 RID: 978
			// (get) Token: 0x06000CF6 RID: 3318 RVA: 0x000333C0 File Offset: 0x000315C0
			// (set) Token: 0x06000CF7 RID: 3319 RVA: 0x0000864A File Offset: 0x0000684A
			public unsafe Il2CppReferenceArray<VoodooView> __7__wrap4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewManager._DeserializeOverTime_d__19.NativeFieldInfoPtr___7__wrap4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<VoodooView>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewManager._DeserializeOverTime_d__19.NativeFieldInfoPtr___7__wrap4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003D3 RID: 979
			// (get) Token: 0x06000CF8 RID: 3320 RVA: 0x000333F0 File Offset: 0x000315F0
			// (set) Token: 0x06000CF9 RID: 3321 RVA: 0x00008669 File Offset: 0x00006869
			public unsafe int __7__wrap5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewManager._DeserializeOverTime_d__19.NativeFieldInfoPtr___7__wrap5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewManager._DeserializeOverTime_d__19.NativeFieldInfoPtr___7__wrap5)) = value;
				}
			}

			// Token: 0x04000801 RID: 2049
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000802 RID: 2050
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000803 RID: 2051
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000804 RID: 2052
			private static readonly IntPtr NativeFieldInfoPtr__context_5__2;

			// Token: 0x04000805 RID: 2053
			private static readonly IntPtr NativeFieldInfoPtr__batchSize_5__3;

			// Token: 0x04000806 RID: 2054
			private static readonly IntPtr NativeFieldInfoPtr__batchCount_5__4;

			// Token: 0x04000807 RID: 2055
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap4;

			// Token: 0x04000808 RID: 2056
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap5;

			// Token: 0x04000809 RID: 2057
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400080A RID: 2058
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400080B RID: 2059
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400080C RID: 2060
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400080D RID: 2061
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400080E RID: 2062
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
