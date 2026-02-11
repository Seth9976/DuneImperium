using System;
using System.Runtime.InteropServices;
using Canis.attributes;
using dwd.core.commands;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using voodoo;

namespace lotus
{
	// Token: 0x02000043 RID: 67
	public class ContainerView : EntityView
	{
		// Token: 0x0600041A RID: 1050 RVA: 0x0001638C File Offset: 0x0001458C
		// Note: this type is marked as 'beforefieldinit'.
		static ContainerView()
		{
			Il2CppClassPointerStore<ContainerView>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lotus", "ContainerView");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContainerView>.NativeClassPtr);
			ContainerView.NativeFieldInfoPtr_register = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerView>.NativeClassPtr, "register");
			ContainerView.NativeFieldInfoPtr_containerViewLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerView>.NativeClassPtr, "containerViewLayer");
			ContainerView.NativeFieldInfoPtr_childrenViewLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerView>.NativeClassPtr, "childrenViewLayer");
			ContainerView.NativeFieldInfoPtr_views = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerView>.NativeClassPtr, "views");
			ContainerView.NativeFieldInfoPtr_viewMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerView>.NativeClassPtr, "viewMap");
			ContainerView.NativeFieldInfoPtr_positionMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerView>.NativeClassPtr, "positionMap");
			ContainerView.NativeFieldInfoPtr_container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerView>.NativeClassPtr, "container");
			ContainerView.NativeFieldInfoPtr_destinationID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerView>.NativeClassPtr, "destinationID");
			ContainerView.NativeFieldInfoPtr_viewProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerView>.NativeClassPtr, "viewProvider");
			ContainerView.NativeFieldInfoPtr_moveLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerView>.NativeClassPtr, "moveLayer");
			ContainerView.NativeFieldInfoPtr_pathGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerView>.NativeClassPtr, "pathGroup");
			ContainerView.NativeFieldInfoPtr_pathProviderInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerView>.NativeClassPtr, "pathProviderInstance");
			ContainerView.NativeFieldInfoPtr_ce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerView>.NativeClassPtr, "ce");
			ContainerView.NativeFieldInfoPtr_skipCreationForEntityNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerView>.NativeClassPtr, "skipCreationForEntityNames");
			ContainerView.NativeMethodInfoPtr_Init_Public_Virtual_Void_EntityComponent_EntityView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerView>.NativeClassPtr, 100663758);
			ContainerView.NativeMethodInfoPtr_initPathGroup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerView>.NativeClassPtr, 100663759);
			ContainerView.NativeMethodInfoPtr_initViewProvider_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerView>.NativeClassPtr, 100663760);
			ContainerView.NativeMethodInfoPtr_CreateViews_Public_Void_Il2CppReferenceArray_1_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerView>.NativeClassPtr, 100663761);
			ContainerView.NativeMethodInfoPtr_CreateViews_Public_Virtual_New_Void_IReadOnlyList_1_EntityComponent_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerView>.NativeClassPtr, 100663762);
			ContainerView.NativeMethodInfoPtr_CreateHiddenView_Public_UnitView_ReadOnlyAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerView>.NativeClassPtr, 100663763);
			ContainerView.NativeMethodInfoPtr_CreateView_Public_UnitView_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerView>.NativeClassPtr, 100663764);
			ContainerView.NativeMethodInfoPtr_createView_Protected_Virtual_New_UnitView_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerView>.NativeClassPtr, 100663765);
			ContainerView.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerView>.NativeClassPtr, 100663766);
			ContainerView.NativeMethodInfoPtr_reset_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerView>.NativeClassPtr, 100663767);
			ContainerView.NativeMethodInfoPtr_UnregisterViews_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerView>.NativeClassPtr, 100663768);
			ContainerView.NativeMethodInfoPtr_RemoveView_Public_Virtual_New_Void_UnitView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerView>.NativeClassPtr, 100663769);
			ContainerView.NativeMethodInfoPtr_internalRemoveView_Private_Void_UnitView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerView>.NativeClassPtr, 100663770);
			ContainerView.NativeMethodInfoPtr_AddView_Public_Virtual_New_Void_UnitView_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerView>.NativeClassPtr, 100663771);
			ContainerView.NativeMethodInfoPtr_onChildDespawned_Protected_Virtual_New_Void_PoolableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerView>.NativeClassPtr, 100663772);
			ContainerView.NativeMethodInfoPtr_addUnitPositionTo_Protected_UnitPosition_UnitView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerView>.NativeClassPtr, 100663773);
			ContainerView.NativeMethodInfoPtr_removeUnitPositionFor_Protected_Void_UnitView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerView>.NativeClassPtr, 100663774);
			ContainerView.NativeMethodInfoPtr_GetUnitPositionFor_Public_UnitPosition_UnitView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerView>.NativeClassPtr, 100663775);
			ContainerView.NativeMethodInfoPtr_UpdatePosition_Public_Virtual_New_Void_UnitView_LocalTransform_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerView>.NativeClassPtr, 100663776);
			ContainerView.NativeMethodInfoPtr_ViewForComponent_Public_EntityView_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerView>.NativeClassPtr, 100663777);
			ContainerView.NativeMethodInfoPtr_OnPrepareToReceiveEntities_Public_Virtual_New_IEnumerator_MoveContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerView>.NativeClassPtr, 100663778);
			ContainerView.NativeMethodInfoPtr_OnPrepareToRemoveEntities_Public_Virtual_New_IEnumerator_MoveContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerView>.NativeClassPtr, 100663779);
			ContainerView.NativeMethodInfoPtr_GetPositionsFor_Public_Virtual_New_Void_MoveContext_Il2CppStructArray_1_LocalTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerView>.NativeClassPtr, 100663780);
			ContainerView.NativeMethodInfoPtr_OnEntitiesRemoved_Public_Virtual_New_IEnumerator_MoveContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerView>.NativeClassPtr, 100663781);
			ContainerView.NativeMethodInfoPtr_LayoutViews_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerView>.NativeClassPtr, 100663782);
			ContainerView.NativeMethodInfoPtr_ContainerForViewAndSlot_Public_Virtual_New_Transform_UnitView_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerView>.NativeClassPtr, 100663783);
			ContainerView.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerView>.NativeClassPtr, 100663784);
			ContainerView.NativeMethodInfoPtr_AddPathToContext_Public_Void_MoveContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerView>.NativeClassPtr, 100663785);
			ContainerView.NativeMethodInfoPtr_entitiesToCreateOnInit_Protected_Virtual_New_IReadOnlyList_1_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerView>.NativeClassPtr, 100663786);
			ContainerView.NativeMethodInfoPtr_onDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerView>.NativeClassPtr, 100663787);
			ContainerView.NativeMethodInfoPtr_OnDespawn_Public_Virtual_Void_PoolableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerView>.NativeClassPtr, 100663788);
			ContainerView.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerView>.NativeClassPtr, 100663789);
			ContainerView.NativeMethodInfoPtr__entitiesToCreateOnInit_b__42_0_Private_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerView>.NativeClassPtr, 100663790);
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x00016768 File Offset: 0x00014968
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1109656, RefRangeEnd = 1109658, XrefRangeStart = 1109624, XrefRangeEnd = 1109656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Init(EntityComponent ec, EntityView p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ec);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContainerView.NativeMethodInfoPtr_Init_Public_Virtual_Void_EntityComponent_EntityView_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x000167C8 File Offset: 0x000149C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1109698, RefRangeEnd = 1109699, XrefRangeStart = 1109658, XrefRangeEnd = 1109698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void initPathGroup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContainerView.NativeMethodInfoPtr_initPathGroup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x000167FC File Offset: 0x000149FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1109699, XrefRangeEnd = 1109718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void initViewProvider()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContainerView.NativeMethodInfoPtr_initViewProvider_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x00016830 File Offset: 0x00014A30
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1109718, RefRangeEnd = 1109725, XrefRangeStart = 1109718, XrefRangeEnd = 1109718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateViews([Optional] Il2CppReferenceArray<EntityComponent> entities)
		{
			if (entities == null)
			{
				entities = new Il2CppReferenceArray<EntityComponent>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entities);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContainerView.NativeMethodInfoPtr_CreateViews_Public_Void_Il2CppReferenceArray_1_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x00016880 File Offset: 0x00014A80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1109725, XrefRangeEnd = 1109765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CreateViews(IReadOnlyList<EntityComponent> entities, List<int> slots = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entities);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(slots);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContainerView.NativeMethodInfoPtr_CreateViews_Public_Virtual_New_Void_IReadOnlyList_1_EntityComponent_List_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x000168E0 File Offset: 0x00014AE0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1109812, RefRangeEnd = 1109814, XrefRangeStart = 1109765, XrefRangeEnd = 1109812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnitView CreateHiddenView(ReadOnlyAttributes visibleAttributes = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(visibleAttributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContainerView.NativeMethodInfoPtr_CreateHiddenView_Public_UnitView_ReadOnlyAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnitView>(intPtr3) : null;
			}
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x00016930 File Offset: 0x00014B30
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 884912, RefRangeEnd = 884914, XrefRangeStart = 884912, XrefRangeEnd = 884914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnitView CreateView(EntityComponent e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContainerView.NativeMethodInfoPtr_CreateView_Public_UnitView_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnitView>(intPtr3) : null;
			}
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x00016980 File Offset: 0x00014B80
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1109841, RefRangeEnd = 1109846, XrefRangeStart = 1109814, XrefRangeEnd = 1109841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual UnitView createView(EntityComponent e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContainerView.NativeMethodInfoPtr_createView_Protected_Virtual_New_UnitView_EntityComponent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnitView>(intPtr3) : null;
			}
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x000169DC File Offset: 0x00014BDC
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 1109849, RefRangeEnd = 1109864, XrefRangeStart = 1109846, XrefRangeEnd = 1109849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContainerView.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x00016A10 File Offset: 0x00014C10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1109864, XrefRangeEnd = 1109874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContainerView.NativeMethodInfoPtr_reset_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x00016A4C File Offset: 0x00014C4C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1109890, RefRangeEnd = 1109902, XrefRangeStart = 1109874, XrefRangeEnd = 1109890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnregisterViews()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContainerView.NativeMethodInfoPtr_UnregisterViews_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x00016A80 File Offset: 0x00014C80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1109913, RefRangeEnd = 1109914, XrefRangeStart = 1109902, XrefRangeEnd = 1109913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RemoveView(UnitView view)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(view);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContainerView.NativeMethodInfoPtr_RemoveView_Public_Virtual_New_Void_UnitView_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x00016AD0 File Offset: 0x00014CD0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1109951, RefRangeEnd = 1109954, XrefRangeStart = 1109914, XrefRangeEnd = 1109951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void internalRemoveView(UnitView view)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(view);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContainerView.NativeMethodInfoPtr_internalRemoveView_Private_Void_UnitView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x00016B14 File Offset: 0x00014D14
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1109991, RefRangeEnd = 1109993, XrefRangeStart = 1109954, XrefRangeEnd = 1109991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AddView(UnitView view, int slot)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContainerView.NativeMethodInfoPtr_AddView_Public_Virtual_New_Void_UnitView_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x00016B70 File Offset: 0x00014D70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1109993, XrefRangeEnd = 1110002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void onChildDespawned(PoolableItem pi)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pi);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContainerView.NativeMethodInfoPtr_onChildDespawned_Protected_Virtual_New_Void_PoolableItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x00016BC0 File Offset: 0x00014DC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110002, XrefRangeEnd = 1110014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnitPosition addUnitPositionTo(UnitView view)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(view);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContainerView.NativeMethodInfoPtr_addUnitPositionTo_Protected_UnitPosition_UnitView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnitPosition>(intPtr3) : null;
			}
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x00016C10 File Offset: 0x00014E10
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1110029, RefRangeEnd = 1110032, XrefRangeStart = 1110014, XrefRangeEnd = 1110029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void removeUnitPositionFor(UnitView view)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(view);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContainerView.NativeMethodInfoPtr_removeUnitPositionFor_Protected_Void_UnitView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x00016C54 File Offset: 0x00014E54
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1110036, RefRangeEnd = 1110043, XrefRangeStart = 1110032, XrefRangeEnd = 1110036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnitPosition GetUnitPositionFor(UnitView view)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(view);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContainerView.NativeMethodInfoPtr_GetUnitPositionFor_Public_UnitPosition_UnitView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnitPosition>(intPtr3) : null;
			}
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x00016CA4 File Offset: 0x00014EA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110043, XrefRangeEnd = 1110045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdatePosition(UnitView view, LocalTransform lt, int slot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(view);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lt;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref slot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContainerView.NativeMethodInfoPtr_UpdatePosition_Public_Virtual_New_Void_UnitView_LocalTransform_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x00016D10 File Offset: 0x00014F10
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1110048, RefRangeEnd = 1110051, XrefRangeStart = 1110045, XrefRangeEnd = 1110048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityView ViewForComponent(EntityComponent data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContainerView.NativeMethodInfoPtr_ViewForComponent_Public_EntityView_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr3) : null;
			}
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x00016D60 File Offset: 0x00014F60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110051, XrefRangeEnd = 1110055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator OnPrepareToReceiveEntities(MoveContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContainerView.NativeMethodInfoPtr_OnPrepareToReceiveEntities_Public_Virtual_New_IEnumerator_MoveContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x00016DBC File Offset: 0x00014FBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110055, XrefRangeEnd = 1110059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator OnPrepareToRemoveEntities(MoveContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContainerView.NativeMethodInfoPtr_OnPrepareToRemoveEntities_Public_Virtual_New_IEnumerator_MoveContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x00016E18 File Offset: 0x00015018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110059, XrefRangeEnd = 1110068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GetPositionsFor(MoveContext context, Il2CppStructArray<LocalTransform> retVal)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContainerView.NativeMethodInfoPtr_GetPositionsFor_Public_Virtual_New_Void_MoveContext_Il2CppStructArray_1_LocalTransform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x00016E78 File Offset: 0x00015078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110068, XrefRangeEnd = 1110072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator OnEntitiesRemoved(MoveContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContainerView.NativeMethodInfoPtr_OnEntitiesRemoved_Public_Virtual_New_IEnumerator_MoveContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x00016ED4 File Offset: 0x000150D4
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LayoutViews()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContainerView.NativeMethodInfoPtr_LayoutViews_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x00016F10 File Offset: 0x00015110
		[CallerCount(0)]
		public unsafe virtual Transform ContainerForViewAndSlot(UnitView view, int slot)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContainerView.NativeMethodInfoPtr_ContainerForViewAndSlot_Public_Virtual_New_Transform_UnitView_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x00016F7C File Offset: 0x0001517C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110072, XrefRangeEnd = 1110090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContainerView.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x00016FB0 File Offset: 0x000151B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110090, XrefRangeEnd = 1110091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddPathToContext(MoveContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContainerView.NativeMethodInfoPtr_AddPathToContext_Public_Void_MoveContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x00016FF4 File Offset: 0x000151F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110091, XrefRangeEnd = 1110104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IReadOnlyList<EntityComponent> entitiesToCreateOnInit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContainerView.NativeMethodInfoPtr_entitiesToCreateOnInit_Protected_Virtual_New_IReadOnlyList_1_EntityComponent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<EntityComponent>>(intPtr3) : null;
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x00017040 File Offset: 0x00015240
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110104, XrefRangeEnd = 1110107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void onDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContainerView.NativeMethodInfoPtr_onDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x0001707C File Offset: 0x0001527C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110107, XrefRangeEnd = 1110163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDespawn(PoolableItem pi)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pi);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContainerView.NativeMethodInfoPtr_OnDespawn_Public_Virtual_Void_PoolableItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x000170CC File Offset: 0x000152CC
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1110234, RefRangeEnd = 1110244, XrefRangeStart = 1110163, XrefRangeEnd = 1110234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContainerView()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContainerView>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContainerView.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x00017108 File Offset: 0x00015308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110244, XrefRangeEnd = 1110247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _entitiesToCreateOnInit_b__42_0(EntityComponent child)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(child);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContainerView.NativeMethodInfoPtr__entitiesToCreateOnInit_b__42_0_Private_Boolean_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x00004260 File Offset: 0x00002460
		public void CreateViews(params EntityComponent[] entities)
		{
			this.CreateViews(new Il2CppReferenceArray<EntityComponent>(entities));
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x0000426E File Offset: 0x0000246E
		public ContainerView(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x0600043E RID: 1086 RVA: 0x00017158 File Offset: 0x00015358
		// (set) Token: 0x0600043F RID: 1087 RVA: 0x00004277 File Offset: 0x00002477
		public unsafe bool register
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerView.NativeFieldInfoPtr_register);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerView.NativeFieldInfoPtr_register)) = value;
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000440 RID: 1088 RVA: 0x00017180 File Offset: 0x00015380
		// (set) Token: 0x06000441 RID: 1089 RVA: 0x00004292 File Offset: 0x00002492
		public unsafe int containerViewLayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerView.NativeFieldInfoPtr_containerViewLayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerView.NativeFieldInfoPtr_containerViewLayer)) = value;
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000442 RID: 1090 RVA: 0x000171A8 File Offset: 0x000153A8
		// (set) Token: 0x06000443 RID: 1091 RVA: 0x000042AD File Offset: 0x000024AD
		public unsafe int childrenViewLayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerView.NativeFieldInfoPtr_childrenViewLayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerView.NativeFieldInfoPtr_childrenViewLayer)) = value;
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06000444 RID: 1092 RVA: 0x000171D0 File Offset: 0x000153D0
		// (set) Token: 0x06000445 RID: 1093 RVA: 0x000042C8 File Offset: 0x000024C8
		public unsafe List<UnitView> views
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerView.NativeFieldInfoPtr_views);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<UnitView>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerView.NativeFieldInfoPtr_views), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000446 RID: 1094 RVA: 0x00017200 File Offset: 0x00015400
		// (set) Token: 0x06000447 RID: 1095 RVA: 0x000042E7 File Offset: 0x000024E7
		public unsafe Dictionary<EntityComponent, UnitView> viewMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerView.NativeFieldInfoPtr_viewMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<EntityComponent, UnitView>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerView.NativeFieldInfoPtr_viewMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06000448 RID: 1096 RVA: 0x00017230 File Offset: 0x00015430
		// (set) Token: 0x06000449 RID: 1097 RVA: 0x00004306 File Offset: 0x00002506
		public unsafe Dictionary<UnitView, UnitPosition> positionMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerView.NativeFieldInfoPtr_positionMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<UnitView, UnitPosition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerView.NativeFieldInfoPtr_positionMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x0600044A RID: 1098 RVA: 0x00017260 File Offset: 0x00015460
		// (set) Token: 0x0600044B RID: 1099 RVA: 0x00004325 File Offset: 0x00002525
		public unsafe Transform container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerView.NativeFieldInfoPtr_container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerView.NativeFieldInfoPtr_container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x0600044C RID: 1100 RVA: 0x00017290 File Offset: 0x00015490
		// (set) Token: 0x0600044D RID: 1101 RVA: 0x00004344 File Offset: 0x00002544
		public unsafe string destinationID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerView.NativeFieldInfoPtr_destinationID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerView.NativeFieldInfoPtr_destinationID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x0600044E RID: 1102 RVA: 0x000172B8 File Offset: 0x000154B8
		// (set) Token: 0x0600044F RID: 1103 RVA: 0x00004363 File Offset: 0x00002563
		public unsafe UnitViewProvider viewProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerView.NativeFieldInfoPtr_viewProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnitViewProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerView.NativeFieldInfoPtr_viewProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000450 RID: 1104 RVA: 0x000172E8 File Offset: 0x000154E8
		// (set) Token: 0x06000451 RID: 1105 RVA: 0x00004382 File Offset: 0x00002582
		public unsafe int moveLayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerView.NativeFieldInfoPtr_moveLayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerView.NativeFieldInfoPtr_moveLayer)) = value;
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000452 RID: 1106 RVA: 0x00017310 File Offset: 0x00015510
		// (set) Token: 0x06000453 RID: 1107 RVA: 0x0000439D File Offset: 0x0000259D
		public unsafe PathProvider pathGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerView.NativeFieldInfoPtr_pathGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PathProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerView.NativeFieldInfoPtr_pathGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000454 RID: 1108 RVA: 0x00017340 File Offset: 0x00015540
		// (set) Token: 0x06000455 RID: 1109 RVA: 0x000043BC File Offset: 0x000025BC
		public unsafe PathProvider pathProviderInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerView.NativeFieldInfoPtr_pathProviderInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PathProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerView.NativeFieldInfoPtr_pathProviderInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000456 RID: 1110 RVA: 0x00017370 File Offset: 0x00015570
		// (set) Token: 0x06000457 RID: 1111 RVA: 0x000043DB File Offset: 0x000025DB
		public unsafe CommandExecutor ce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerView.NativeFieldInfoPtr_ce);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CommandExecutor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerView.NativeFieldInfoPtr_ce), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000458 RID: 1112 RVA: 0x000173A0 File Offset: 0x000155A0
		// (set) Token: 0x06000459 RID: 1113 RVA: 0x000043FA File Offset: 0x000025FA
		public unsafe List<string> skipCreationForEntityNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerView.NativeFieldInfoPtr_skipCreationForEntityNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerView.NativeFieldInfoPtr_skipCreationForEntityNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000285 RID: 645
		private static readonly IntPtr NativeFieldInfoPtr_register;

		// Token: 0x04000286 RID: 646
		private static readonly IntPtr NativeFieldInfoPtr_containerViewLayer;

		// Token: 0x04000287 RID: 647
		private static readonly IntPtr NativeFieldInfoPtr_childrenViewLayer;

		// Token: 0x04000288 RID: 648
		private static readonly IntPtr NativeFieldInfoPtr_views;

		// Token: 0x04000289 RID: 649
		private static readonly IntPtr NativeFieldInfoPtr_viewMap;

		// Token: 0x0400028A RID: 650
		private static readonly IntPtr NativeFieldInfoPtr_positionMap;

		// Token: 0x0400028B RID: 651
		private static readonly IntPtr NativeFieldInfoPtr_container;

		// Token: 0x0400028C RID: 652
		private static readonly IntPtr NativeFieldInfoPtr_destinationID;

		// Token: 0x0400028D RID: 653
		private static readonly IntPtr NativeFieldInfoPtr_viewProvider;

		// Token: 0x0400028E RID: 654
		private static readonly IntPtr NativeFieldInfoPtr_moveLayer;

		// Token: 0x0400028F RID: 655
		private static readonly IntPtr NativeFieldInfoPtr_pathGroup;

		// Token: 0x04000290 RID: 656
		private static readonly IntPtr NativeFieldInfoPtr_pathProviderInstance;

		// Token: 0x04000291 RID: 657
		private static readonly IntPtr NativeFieldInfoPtr_ce;

		// Token: 0x04000292 RID: 658
		private static readonly IntPtr NativeFieldInfoPtr_skipCreationForEntityNames;

		// Token: 0x04000293 RID: 659
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Void_EntityComponent_EntityView_0;

		// Token: 0x04000294 RID: 660
		private static readonly IntPtr NativeMethodInfoPtr_initPathGroup_Private_Void_0;

		// Token: 0x04000295 RID: 661
		private static readonly IntPtr NativeMethodInfoPtr_initViewProvider_Private_Void_0;

		// Token: 0x04000296 RID: 662
		private static readonly IntPtr NativeMethodInfoPtr_CreateViews_Public_Void_Il2CppReferenceArray_1_EntityComponent_0;

		// Token: 0x04000297 RID: 663
		private static readonly IntPtr NativeMethodInfoPtr_CreateViews_Public_Virtual_New_Void_IReadOnlyList_1_EntityComponent_List_1_Int32_0;

		// Token: 0x04000298 RID: 664
		private static readonly IntPtr NativeMethodInfoPtr_CreateHiddenView_Public_UnitView_ReadOnlyAttributes_0;

		// Token: 0x04000299 RID: 665
		private static readonly IntPtr NativeMethodInfoPtr_CreateView_Public_UnitView_EntityComponent_0;

		// Token: 0x0400029A RID: 666
		private static readonly IntPtr NativeMethodInfoPtr_createView_Protected_Virtual_New_UnitView_EntityComponent_0;

		// Token: 0x0400029B RID: 667
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

		// Token: 0x0400029C RID: 668
		private static readonly IntPtr NativeMethodInfoPtr_reset_Protected_Virtual_New_Void_0;

		// Token: 0x0400029D RID: 669
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterViews_Public_Void_0;

		// Token: 0x0400029E RID: 670
		private static readonly IntPtr NativeMethodInfoPtr_RemoveView_Public_Virtual_New_Void_UnitView_0;

		// Token: 0x0400029F RID: 671
		private static readonly IntPtr NativeMethodInfoPtr_internalRemoveView_Private_Void_UnitView_0;

		// Token: 0x040002A0 RID: 672
		private static readonly IntPtr NativeMethodInfoPtr_AddView_Public_Virtual_New_Void_UnitView_Int32_0;

		// Token: 0x040002A1 RID: 673
		private static readonly IntPtr NativeMethodInfoPtr_onChildDespawned_Protected_Virtual_New_Void_PoolableItem_0;

		// Token: 0x040002A2 RID: 674
		private static readonly IntPtr NativeMethodInfoPtr_addUnitPositionTo_Protected_UnitPosition_UnitView_0;

		// Token: 0x040002A3 RID: 675
		private static readonly IntPtr NativeMethodInfoPtr_removeUnitPositionFor_Protected_Void_UnitView_0;

		// Token: 0x040002A4 RID: 676
		private static readonly IntPtr NativeMethodInfoPtr_GetUnitPositionFor_Public_UnitPosition_UnitView_0;

		// Token: 0x040002A5 RID: 677
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePosition_Public_Virtual_New_Void_UnitView_LocalTransform_Int32_0;

		// Token: 0x040002A6 RID: 678
		private static readonly IntPtr NativeMethodInfoPtr_ViewForComponent_Public_EntityView_EntityComponent_0;

		// Token: 0x040002A7 RID: 679
		private static readonly IntPtr NativeMethodInfoPtr_OnPrepareToReceiveEntities_Public_Virtual_New_IEnumerator_MoveContext_0;

		// Token: 0x040002A8 RID: 680
		private static readonly IntPtr NativeMethodInfoPtr_OnPrepareToRemoveEntities_Public_Virtual_New_IEnumerator_MoveContext_0;

		// Token: 0x040002A9 RID: 681
		private static readonly IntPtr NativeMethodInfoPtr_GetPositionsFor_Public_Virtual_New_Void_MoveContext_Il2CppStructArray_1_LocalTransform_0;

		// Token: 0x040002AA RID: 682
		private static readonly IntPtr NativeMethodInfoPtr_OnEntitiesRemoved_Public_Virtual_New_IEnumerator_MoveContext_0;

		// Token: 0x040002AB RID: 683
		private static readonly IntPtr NativeMethodInfoPtr_LayoutViews_Public_Virtual_New_Void_0;

		// Token: 0x040002AC RID: 684
		private static readonly IntPtr NativeMethodInfoPtr_ContainerForViewAndSlot_Public_Virtual_New_Transform_UnitView_Int32_0;

		// Token: 0x040002AD RID: 685
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x040002AE RID: 686
		private static readonly IntPtr NativeMethodInfoPtr_AddPathToContext_Public_Void_MoveContext_0;

		// Token: 0x040002AF RID: 687
		private static readonly IntPtr NativeMethodInfoPtr_entitiesToCreateOnInit_Protected_Virtual_New_IReadOnlyList_1_EntityComponent_0;

		// Token: 0x040002B0 RID: 688
		private static readonly IntPtr NativeMethodInfoPtr_onDestroy_Protected_Virtual_Void_0;

		// Token: 0x040002B1 RID: 689
		private static readonly IntPtr NativeMethodInfoPtr_OnDespawn_Public_Virtual_Void_PoolableItem_0;

		// Token: 0x040002B2 RID: 690
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040002B3 RID: 691
		private static readonly IntPtr NativeMethodInfoPtr__entitiesToCreateOnInit_b__42_0_Private_Boolean_EntityComponent_0;

		// Token: 0x020000CD RID: 205
		[ObfuscatedName("lotus.ContainerView+<OnEntitiesRemoved>d__37")]
		public sealed class _OnEntitiesRemoved_d__37 : global::Il2CppSystem.Object
		{
			// Token: 0x06000AD1 RID: 2769 RVA: 0x0002CCE4 File Offset: 0x0002AEE4
			// Note: this type is marked as 'beforefieldinit'.
			static _OnEntitiesRemoved_d__37()
			{
				Il2CppClassPointerStore<ContainerView._OnEntitiesRemoved_d__37>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ContainerView>.NativeClassPtr, "<OnEntitiesRemoved>d__37");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContainerView._OnEntitiesRemoved_d__37>.NativeClassPtr);
				ContainerView._OnEntitiesRemoved_d__37.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerView._OnEntitiesRemoved_d__37>.NativeClassPtr, "<>1__state");
				ContainerView._OnEntitiesRemoved_d__37.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerView._OnEntitiesRemoved_d__37>.NativeClassPtr, "<>2__current");
				ContainerView._OnEntitiesRemoved_d__37.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerView._OnEntitiesRemoved_d__37>.NativeClassPtr, 100663791);
				ContainerView._OnEntitiesRemoved_d__37.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerView._OnEntitiesRemoved_d__37>.NativeClassPtr, 100663792);
				ContainerView._OnEntitiesRemoved_d__37.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerView._OnEntitiesRemoved_d__37>.NativeClassPtr, 100663793);
				ContainerView._OnEntitiesRemoved_d__37.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerView._OnEntitiesRemoved_d__37>.NativeClassPtr, 100663794);
				ContainerView._OnEntitiesRemoved_d__37.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerView._OnEntitiesRemoved_d__37>.NativeClassPtr, 100663795);
				ContainerView._OnEntitiesRemoved_d__37.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerView._OnEntitiesRemoved_d__37>.NativeClassPtr, 100663796);
			}

			// Token: 0x06000AD2 RID: 2770 RVA: 0x0002CDB0 File Offset: 0x0002AFB0
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnEntitiesRemoved_d__37(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContainerView._OnEntitiesRemoved_d__37>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContainerView._OnEntitiesRemoved_d__37.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000AD3 RID: 2771 RVA: 0x0002CDF8 File Offset: 0x0002AFF8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContainerView._OnEntitiesRemoved_d__37.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000AD4 RID: 2772 RVA: 0x0002CE2C File Offset: 0x0002B02C
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContainerView._OnEntitiesRemoved_d__37.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000320 RID: 800
			// (get) Token: 0x06000AD5 RID: 2773 RVA: 0x0002CE68 File Offset: 0x0002B068
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContainerView._OnEntitiesRemoved_d__37.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000AD6 RID: 2774 RVA: 0x0002CEA8 File Offset: 0x0002B0A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1109609, XrefRangeEnd = 1109614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContainerView._OnEntitiesRemoved_d__37.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000321 RID: 801
			// (get) Token: 0x06000AD7 RID: 2775 RVA: 0x0002CEDC File Offset: 0x0002B0DC
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContainerView._OnEntitiesRemoved_d__37.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000AD8 RID: 2776 RVA: 0x0000752B File Offset: 0x0000572B
			public _OnEntitiesRemoved_d__37(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700031E RID: 798
			// (get) Token: 0x06000AD9 RID: 2777 RVA: 0x0002CF1C File Offset: 0x0002B11C
			// (set) Token: 0x06000ADA RID: 2778 RVA: 0x00007534 File Offset: 0x00005734
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerView._OnEntitiesRemoved_d__37.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerView._OnEntitiesRemoved_d__37.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700031F RID: 799
			// (get) Token: 0x06000ADB RID: 2779 RVA: 0x0002CF44 File Offset: 0x0002B144
			// (set) Token: 0x06000ADC RID: 2780 RVA: 0x0000754F File Offset: 0x0000574F
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerView._OnEntitiesRemoved_d__37.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerView._OnEntitiesRemoved_d__37.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040006BE RID: 1726
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040006BF RID: 1727
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040006C0 RID: 1728
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040006C1 RID: 1729
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040006C2 RID: 1730
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040006C3 RID: 1731
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040006C4 RID: 1732
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040006C5 RID: 1733
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020000CE RID: 206
		[ObfuscatedName("lotus.ContainerView+<OnPrepareToReceiveEntities>d__34")]
		public sealed class _OnPrepareToReceiveEntities_d__34 : global::Il2CppSystem.Object
		{
			// Token: 0x06000ADD RID: 2781 RVA: 0x0002CF74 File Offset: 0x0002B174
			// Note: this type is marked as 'beforefieldinit'.
			static _OnPrepareToReceiveEntities_d__34()
			{
				Il2CppClassPointerStore<ContainerView._OnPrepareToReceiveEntities_d__34>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ContainerView>.NativeClassPtr, "<OnPrepareToReceiveEntities>d__34");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContainerView._OnPrepareToReceiveEntities_d__34>.NativeClassPtr);
				ContainerView._OnPrepareToReceiveEntities_d__34.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerView._OnPrepareToReceiveEntities_d__34>.NativeClassPtr, "<>1__state");
				ContainerView._OnPrepareToReceiveEntities_d__34.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerView._OnPrepareToReceiveEntities_d__34>.NativeClassPtr, "<>2__current");
				ContainerView._OnPrepareToReceiveEntities_d__34.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerView._OnPrepareToReceiveEntities_d__34>.NativeClassPtr, 100663797);
				ContainerView._OnPrepareToReceiveEntities_d__34.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerView._OnPrepareToReceiveEntities_d__34>.NativeClassPtr, 100663798);
				ContainerView._OnPrepareToReceiveEntities_d__34.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerView._OnPrepareToReceiveEntities_d__34>.NativeClassPtr, 100663799);
				ContainerView._OnPrepareToReceiveEntities_d__34.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerView._OnPrepareToReceiveEntities_d__34>.NativeClassPtr, 100663800);
				ContainerView._OnPrepareToReceiveEntities_d__34.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerView._OnPrepareToReceiveEntities_d__34>.NativeClassPtr, 100663801);
				ContainerView._OnPrepareToReceiveEntities_d__34.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerView._OnPrepareToReceiveEntities_d__34>.NativeClassPtr, 100663802);
			}

			// Token: 0x06000ADE RID: 2782 RVA: 0x0002D040 File Offset: 0x0002B240
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnPrepareToReceiveEntities_d__34(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContainerView._OnPrepareToReceiveEntities_d__34>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContainerView._OnPrepareToReceiveEntities_d__34.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000ADF RID: 2783 RVA: 0x0002D088 File Offset: 0x0002B288
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContainerView._OnPrepareToReceiveEntities_d__34.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000AE0 RID: 2784 RVA: 0x0002D0BC File Offset: 0x0002B2BC
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContainerView._OnPrepareToReceiveEntities_d__34.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000324 RID: 804
			// (get) Token: 0x06000AE1 RID: 2785 RVA: 0x0002D0F8 File Offset: 0x0002B2F8
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContainerView._OnPrepareToReceiveEntities_d__34.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000AE2 RID: 2786 RVA: 0x0002D138 File Offset: 0x0002B338
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1109614, XrefRangeEnd = 1109619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContainerView._OnPrepareToReceiveEntities_d__34.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000325 RID: 805
			// (get) Token: 0x06000AE3 RID: 2787 RVA: 0x0002D16C File Offset: 0x0002B36C
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContainerView._OnPrepareToReceiveEntities_d__34.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000AE4 RID: 2788 RVA: 0x0000756E File Offset: 0x0000576E
			public _OnPrepareToReceiveEntities_d__34(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000322 RID: 802
			// (get) Token: 0x06000AE5 RID: 2789 RVA: 0x0002D1AC File Offset: 0x0002B3AC
			// (set) Token: 0x06000AE6 RID: 2790 RVA: 0x00007577 File Offset: 0x00005777
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerView._OnPrepareToReceiveEntities_d__34.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerView._OnPrepareToReceiveEntities_d__34.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000323 RID: 803
			// (get) Token: 0x06000AE7 RID: 2791 RVA: 0x0002D1D4 File Offset: 0x0002B3D4
			// (set) Token: 0x06000AE8 RID: 2792 RVA: 0x00007592 File Offset: 0x00005792
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerView._OnPrepareToReceiveEntities_d__34.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerView._OnPrepareToReceiveEntities_d__34.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040006C6 RID: 1734
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040006C7 RID: 1735
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040006C8 RID: 1736
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040006C9 RID: 1737
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040006CA RID: 1738
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040006CB RID: 1739
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040006CC RID: 1740
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040006CD RID: 1741
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020000CF RID: 207
		[ObfuscatedName("lotus.ContainerView+<OnPrepareToRemoveEntities>d__35")]
		public sealed class _OnPrepareToRemoveEntities_d__35 : global::Il2CppSystem.Object
		{
			// Token: 0x06000AE9 RID: 2793 RVA: 0x0002D204 File Offset: 0x0002B404
			// Note: this type is marked as 'beforefieldinit'.
			static _OnPrepareToRemoveEntities_d__35()
			{
				Il2CppClassPointerStore<ContainerView._OnPrepareToRemoveEntities_d__35>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ContainerView>.NativeClassPtr, "<OnPrepareToRemoveEntities>d__35");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContainerView._OnPrepareToRemoveEntities_d__35>.NativeClassPtr);
				ContainerView._OnPrepareToRemoveEntities_d__35.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerView._OnPrepareToRemoveEntities_d__35>.NativeClassPtr, "<>1__state");
				ContainerView._OnPrepareToRemoveEntities_d__35.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerView._OnPrepareToRemoveEntities_d__35>.NativeClassPtr, "<>2__current");
				ContainerView._OnPrepareToRemoveEntities_d__35.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerView._OnPrepareToRemoveEntities_d__35>.NativeClassPtr, 100663803);
				ContainerView._OnPrepareToRemoveEntities_d__35.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerView._OnPrepareToRemoveEntities_d__35>.NativeClassPtr, 100663804);
				ContainerView._OnPrepareToRemoveEntities_d__35.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerView._OnPrepareToRemoveEntities_d__35>.NativeClassPtr, 100663805);
				ContainerView._OnPrepareToRemoveEntities_d__35.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerView._OnPrepareToRemoveEntities_d__35>.NativeClassPtr, 100663806);
				ContainerView._OnPrepareToRemoveEntities_d__35.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerView._OnPrepareToRemoveEntities_d__35>.NativeClassPtr, 100663807);
				ContainerView._OnPrepareToRemoveEntities_d__35.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerView._OnPrepareToRemoveEntities_d__35>.NativeClassPtr, 100663808);
			}

			// Token: 0x06000AEA RID: 2794 RVA: 0x0002D2D0 File Offset: 0x0002B4D0
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnPrepareToRemoveEntities_d__35(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContainerView._OnPrepareToRemoveEntities_d__35>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContainerView._OnPrepareToRemoveEntities_d__35.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000AEB RID: 2795 RVA: 0x0002D318 File Offset: 0x0002B518
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContainerView._OnPrepareToRemoveEntities_d__35.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000AEC RID: 2796 RVA: 0x0002D34C File Offset: 0x0002B54C
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContainerView._OnPrepareToRemoveEntities_d__35.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000328 RID: 808
			// (get) Token: 0x06000AED RID: 2797 RVA: 0x0002D388 File Offset: 0x0002B588
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContainerView._OnPrepareToRemoveEntities_d__35.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000AEE RID: 2798 RVA: 0x0002D3C8 File Offset: 0x0002B5C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1109619, XrefRangeEnd = 1109624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContainerView._OnPrepareToRemoveEntities_d__35.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000329 RID: 809
			// (get) Token: 0x06000AEF RID: 2799 RVA: 0x0002D3FC File Offset: 0x0002B5FC
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContainerView._OnPrepareToRemoveEntities_d__35.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000AF0 RID: 2800 RVA: 0x000075B1 File Offset: 0x000057B1
			public _OnPrepareToRemoveEntities_d__35(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000326 RID: 806
			// (get) Token: 0x06000AF1 RID: 2801 RVA: 0x0002D43C File Offset: 0x0002B63C
			// (set) Token: 0x06000AF2 RID: 2802 RVA: 0x000075BA File Offset: 0x000057BA
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerView._OnPrepareToRemoveEntities_d__35.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerView._OnPrepareToRemoveEntities_d__35.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000327 RID: 807
			// (get) Token: 0x06000AF3 RID: 2803 RVA: 0x0002D464 File Offset: 0x0002B664
			// (set) Token: 0x06000AF4 RID: 2804 RVA: 0x000075D5 File Offset: 0x000057D5
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerView._OnPrepareToRemoveEntities_d__35.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerView._OnPrepareToRemoveEntities_d__35.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040006CE RID: 1742
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040006CF RID: 1743
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040006D0 RID: 1744
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040006D1 RID: 1745
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040006D2 RID: 1746
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040006D3 RID: 1747
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040006D4 RID: 1748
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040006D5 RID: 1749
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
