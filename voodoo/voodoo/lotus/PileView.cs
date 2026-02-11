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
	// Token: 0x02000070 RID: 112
	public class PileView : ContainerView
	{
		// Token: 0x0600067D RID: 1661 RVA: 0x0001EC8C File Offset: 0x0001CE8C
		// Note: this type is marked as 'beforefieldinit'.
		static PileView()
		{
			Il2CppClassPointerStore<PileView>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lotus", "PileView");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PileView>.NativeClassPtr);
			PileView.NativeFieldInfoPtr_step = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PileView>.NativeClassPtr, "step");
			PileView.NativeFieldInfoPtr_bounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PileView>.NativeClassPtr, "bounds");
			PileView.NativeFieldInfoPtr_pivot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PileView>.NativeClassPtr, "pivot");
			PileView.NativeFieldInfoPtr_align = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PileView>.NativeClassPtr, "align");
			PileView.NativeFieldInfoPtr_ignoreSecondaryMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PileView>.NativeClassPtr, "ignoreSecondaryMove");
			PileView.NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PileView>.NativeClassPtr, 100664180);
			PileView.NativeMethodInfoPtr_setPositionFor_Protected_Virtual_New_Void_UnitView_Int32_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PileView>.NativeClassPtr, 100664181);
			PileView.NativeMethodInfoPtr_LayoutViews_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PileView>.NativeClassPtr, 100664182);
			PileView.NativeMethodInfoPtr_getConstrainedStep_Protected_Vector3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PileView>.NativeClassPtr, 100664183);
			PileView.NativeMethodInfoPtr_getOffset_Protected_Vector3_Int32_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PileView>.NativeClassPtr, 100664184);
			PileView.NativeMethodInfoPtr_map_Private_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PileView>.NativeClassPtr, 100664185);
			PileView.NativeMethodInfoPtr_map_Private_Vector3_Vector3_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PileView>.NativeClassPtr, 100664186);
			PileView.NativeMethodInfoPtr_GetPositionsFor_Public_Virtual_Void_MoveContext_Il2CppStructArray_1_LocalTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PileView>.NativeClassPtr, 100664187);
			PileView.NativeMethodInfoPtr_OnPrepareToReceiveEntities_Public_Virtual_IEnumerator_MoveContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PileView>.NativeClassPtr, 100664188);
			PileView.NativeMethodInfoPtr_createSecondaryMoveContext_Private_MoveContext_Int32_List_1_UnitView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PileView>.NativeClassPtr, 100664189);
			PileView.NativeMethodInfoPtr_OnEntitiesRemoved_Public_Virtual_IEnumerator_MoveContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PileView>.NativeClassPtr, 100664190);
			PileView.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PileView>.NativeClassPtr, 100664191);
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x0001EE10 File Offset: 0x0001D010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1113141, XrefRangeEnd = 1113147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmosSelected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PileView.NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x0001EE44 File Offset: 0x0001D044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1113147, XrefRangeEnd = 1113153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void setPositionFor(UnitView view, int slot, Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(view);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref slot;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PileView.NativeMethodInfoPtr_setPositionFor_Protected_Virtual_New_Void_UnitView_Int32_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x0001EEB0 File Offset: 0x0001D0B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1113153, XrefRangeEnd = 1113159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void LayoutViews()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PileView.NativeMethodInfoPtr_LayoutViews_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x0001EEEC File Offset: 0x0001D0EC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1113161, RefRangeEnd = 1113164, XrefRangeStart = 1113159, XrefRangeEnd = 1113161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 getConstrainedStep(int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PileView.NativeMethodInfoPtr_getConstrainedStep_Protected_Vector3_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x0001EF38 File Offset: 0x0001D138
		[CallerCount(0)]
		public unsafe Vector3 getOffset(int size, Vector3 constrainedStep)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref constrainedStep;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PileView.NativeMethodInfoPtr_getOffset_Protected_Vector3_Int32_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x0001EF90 File Offset: 0x0001D190
		[CallerCount(0)]
		public unsafe float map(float x, float inMin, float inMax, float outMin, float outMax)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inMin;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inMax;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref outMin;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref outMax;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PileView.NativeMethodInfoPtr_map_Private_Single_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x0001F014 File Offset: 0x0001D214
		[CallerCount(0)]
		public unsafe Vector3 map(Vector3 v, float inMin, float inMax, float outMin, float outMax)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inMin;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inMax;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref outMin;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref outMax;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PileView.NativeMethodInfoPtr_map_Private_Vector3_Vector3_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x0001F098 File Offset: 0x0001D298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1113164, XrefRangeEnd = 1113177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PileView.NativeMethodInfoPtr_GetPositionsFor_Public_Virtual_Void_MoveContext_Il2CppStructArray_1_LocalTransform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x0001F0F8 File Offset: 0x0001D2F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1113177, XrefRangeEnd = 1113183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnPrepareToReceiveEntities(MoveContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PileView.NativeMethodInfoPtr_OnPrepareToReceiveEntities_Public_Virtual_IEnumerator_MoveContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x0001F154 File Offset: 0x0001D354
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1113206, RefRangeEnd = 1113208, XrefRangeStart = 1113183, XrefRangeEnd = 1113206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MoveContext createSecondaryMoveContext(int newSize, List<UnitView> mixedViews)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newSize;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mixedViews);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PileView.NativeMethodInfoPtr_createSecondaryMoveContext_Private_MoveContext_Int32_List_1_UnitView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MoveContext>(intPtr3) : null;
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x0001F1B4 File Offset: 0x0001D3B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1113208, XrefRangeEnd = 1113214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnEntitiesRemoved(MoveContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PileView.NativeMethodInfoPtr_OnEntitiesRemoved_Public_Virtual_IEnumerator_MoveContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x0001F210 File Offset: 0x0001D410
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1113214, XrefRangeEnd = 1113219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PileView()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PileView>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PileView.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x00005363 File Offset: 0x00003563
		public PileView(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x0600068B RID: 1675 RVA: 0x0001F24C File Offset: 0x0001D44C
		// (set) Token: 0x0600068C RID: 1676 RVA: 0x0000536C File Offset: 0x0000356C
		public unsafe Vector3 step
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PileView.NativeFieldInfoPtr_step);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PileView.NativeFieldInfoPtr_step)) = value;
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x0600068D RID: 1677 RVA: 0x0001F274 File Offset: 0x0001D474
		// (set) Token: 0x0600068E RID: 1678 RVA: 0x00005387 File Offset: 0x00003587
		public unsafe Vector3 bounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PileView.NativeFieldInfoPtr_bounds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PileView.NativeFieldInfoPtr_bounds)) = value;
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x0600068F RID: 1679 RVA: 0x0001F29C File Offset: 0x0001D49C
		// (set) Token: 0x06000690 RID: 1680 RVA: 0x000053A2 File Offset: 0x000035A2
		public unsafe Vector3 pivot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PileView.NativeFieldInfoPtr_pivot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PileView.NativeFieldInfoPtr_pivot)) = value;
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06000691 RID: 1681 RVA: 0x0001F2C4 File Offset: 0x0001D4C4
		// (set) Token: 0x06000692 RID: 1682 RVA: 0x000053BD File Offset: 0x000035BD
		public unsafe Vector3 align
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PileView.NativeFieldInfoPtr_align);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PileView.NativeFieldInfoPtr_align)) = value;
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06000693 RID: 1683 RVA: 0x0001F2EC File Offset: 0x0001D4EC
		// (set) Token: 0x06000694 RID: 1684 RVA: 0x000053D8 File Offset: 0x000035D8
		public unsafe bool ignoreSecondaryMove
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PileView.NativeFieldInfoPtr_ignoreSecondaryMove);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PileView.NativeFieldInfoPtr_ignoreSecondaryMove)) = value;
			}
		}

		// Token: 0x0400040C RID: 1036
		private static readonly IntPtr NativeFieldInfoPtr_step;

		// Token: 0x0400040D RID: 1037
		private static readonly IntPtr NativeFieldInfoPtr_bounds;

		// Token: 0x0400040E RID: 1038
		private static readonly IntPtr NativeFieldInfoPtr_pivot;

		// Token: 0x0400040F RID: 1039
		private static readonly IntPtr NativeFieldInfoPtr_align;

		// Token: 0x04000410 RID: 1040
		private static readonly IntPtr NativeFieldInfoPtr_ignoreSecondaryMove;

		// Token: 0x04000411 RID: 1041
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0;

		// Token: 0x04000412 RID: 1042
		private static readonly IntPtr NativeMethodInfoPtr_setPositionFor_Protected_Virtual_New_Void_UnitView_Int32_Vector3_0;

		// Token: 0x04000413 RID: 1043
		private static readonly IntPtr NativeMethodInfoPtr_LayoutViews_Public_Virtual_Void_0;

		// Token: 0x04000414 RID: 1044
		private static readonly IntPtr NativeMethodInfoPtr_getConstrainedStep_Protected_Vector3_Int32_0;

		// Token: 0x04000415 RID: 1045
		private static readonly IntPtr NativeMethodInfoPtr_getOffset_Protected_Vector3_Int32_Vector3_0;

		// Token: 0x04000416 RID: 1046
		private static readonly IntPtr NativeMethodInfoPtr_map_Private_Single_Single_Single_Single_Single_Single_0;

		// Token: 0x04000417 RID: 1047
		private static readonly IntPtr NativeMethodInfoPtr_map_Private_Vector3_Vector3_Single_Single_Single_Single_0;

		// Token: 0x04000418 RID: 1048
		private static readonly IntPtr NativeMethodInfoPtr_GetPositionsFor_Public_Virtual_Void_MoveContext_Il2CppStructArray_1_LocalTransform_0;

		// Token: 0x04000419 RID: 1049
		private static readonly IntPtr NativeMethodInfoPtr_OnPrepareToReceiveEntities_Public_Virtual_IEnumerator_MoveContext_0;

		// Token: 0x0400041A RID: 1050
		private static readonly IntPtr NativeMethodInfoPtr_createSecondaryMoveContext_Private_MoveContext_Int32_List_1_UnitView_0;

		// Token: 0x0400041B RID: 1051
		private static readonly IntPtr NativeMethodInfoPtr_OnEntitiesRemoved_Public_Virtual_IEnumerator_MoveContext_0;

		// Token: 0x0400041C RID: 1052
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020000F0 RID: 240
		[ObfuscatedName("lotus.PileView+<OnEntitiesRemoved>d__15")]
		public sealed class _OnEntitiesRemoved_d__15 : global::Il2CppSystem.Object
		{
			// Token: 0x06000C7D RID: 3197 RVA: 0x00031E24 File Offset: 0x00030024
			// Note: this type is marked as 'beforefieldinit'.
			static _OnEntitiesRemoved_d__15()
			{
				Il2CppClassPointerStore<PileView._OnEntitiesRemoved_d__15>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PileView>.NativeClassPtr, "<OnEntitiesRemoved>d__15");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PileView._OnEntitiesRemoved_d__15>.NativeClassPtr);
				PileView._OnEntitiesRemoved_d__15.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PileView._OnEntitiesRemoved_d__15>.NativeClassPtr, "<>1__state");
				PileView._OnEntitiesRemoved_d__15.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PileView._OnEntitiesRemoved_d__15>.NativeClassPtr, "<>2__current");
				PileView._OnEntitiesRemoved_d__15.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PileView._OnEntitiesRemoved_d__15>.NativeClassPtr, "context");
				PileView._OnEntitiesRemoved_d__15.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PileView._OnEntitiesRemoved_d__15>.NativeClassPtr, "<>4__this");
				PileView._OnEntitiesRemoved_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PileView._OnEntitiesRemoved_d__15>.NativeClassPtr, 100664192);
				PileView._OnEntitiesRemoved_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PileView._OnEntitiesRemoved_d__15>.NativeClassPtr, 100664193);
				PileView._OnEntitiesRemoved_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PileView._OnEntitiesRemoved_d__15>.NativeClassPtr, 100664194);
				PileView._OnEntitiesRemoved_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PileView._OnEntitiesRemoved_d__15>.NativeClassPtr, 100664195);
				PileView._OnEntitiesRemoved_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PileView._OnEntitiesRemoved_d__15>.NativeClassPtr, 100664196);
				PileView._OnEntitiesRemoved_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PileView._OnEntitiesRemoved_d__15>.NativeClassPtr, 100664197);
			}

			// Token: 0x06000C7E RID: 3198 RVA: 0x00031F18 File Offset: 0x00030118
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnEntitiesRemoved_d__15(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PileView._OnEntitiesRemoved_d__15>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PileView._OnEntitiesRemoved_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000C7F RID: 3199 RVA: 0x00031F60 File Offset: 0x00030160
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PileView._OnEntitiesRemoved_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000C80 RID: 3200 RVA: 0x00031F94 File Offset: 0x00030194
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1113075, XrefRangeEnd = 1113088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PileView._OnEntitiesRemoved_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170003B2 RID: 946
			// (get) Token: 0x06000C81 RID: 3201 RVA: 0x00031FD0 File Offset: 0x000301D0
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PileView._OnEntitiesRemoved_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000C82 RID: 3202 RVA: 0x00032010 File Offset: 0x00030210
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1113088, XrefRangeEnd = 1113093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PileView._OnEntitiesRemoved_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170003B3 RID: 947
			// (get) Token: 0x06000C83 RID: 3203 RVA: 0x00032044 File Offset: 0x00030244
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PileView._OnEntitiesRemoved_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000C84 RID: 3204 RVA: 0x00008254 File Offset: 0x00006454
			public _OnEntitiesRemoved_d__15(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170003AE RID: 942
			// (get) Token: 0x06000C85 RID: 3205 RVA: 0x00032084 File Offset: 0x00030284
			// (set) Token: 0x06000C86 RID: 3206 RVA: 0x0000825D File Offset: 0x0000645D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PileView._OnEntitiesRemoved_d__15.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PileView._OnEntitiesRemoved_d__15.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170003AF RID: 943
			// (get) Token: 0x06000C87 RID: 3207 RVA: 0x000320AC File Offset: 0x000302AC
			// (set) Token: 0x06000C88 RID: 3208 RVA: 0x00008278 File Offset: 0x00006478
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PileView._OnEntitiesRemoved_d__15.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PileView._OnEntitiesRemoved_d__15.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003B0 RID: 944
			// (get) Token: 0x06000C89 RID: 3209 RVA: 0x000320DC File Offset: 0x000302DC
			// (set) Token: 0x06000C8A RID: 3210 RVA: 0x00008297 File Offset: 0x00006497
			public unsafe MoveContext context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PileView._OnEntitiesRemoved_d__15.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MoveContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PileView._OnEntitiesRemoved_d__15.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003B1 RID: 945
			// (get) Token: 0x06000C8B RID: 3211 RVA: 0x0003210C File Offset: 0x0003030C
			// (set) Token: 0x06000C8C RID: 3212 RVA: 0x000082B6 File Offset: 0x000064B6
			public unsafe PileView __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PileView._OnEntitiesRemoved_d__15.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PileView>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PileView._OnEntitiesRemoved_d__15.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040007C3 RID: 1987
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040007C4 RID: 1988
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040007C5 RID: 1989
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x040007C6 RID: 1990
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040007C7 RID: 1991
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040007C8 RID: 1992
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040007C9 RID: 1993
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040007CA RID: 1994
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040007CB RID: 1995
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040007CC RID: 1996
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020000F1 RID: 241
		[ObfuscatedName("lotus.PileView+<OnPrepareToReceiveEntities>d__13")]
		public sealed class _OnPrepareToReceiveEntities_d__13 : global::Il2CppSystem.Object
		{
			// Token: 0x06000C8D RID: 3213 RVA: 0x0003213C File Offset: 0x0003033C
			// Note: this type is marked as 'beforefieldinit'.
			static _OnPrepareToReceiveEntities_d__13()
			{
				Il2CppClassPointerStore<PileView._OnPrepareToReceiveEntities_d__13>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PileView>.NativeClassPtr, "<OnPrepareToReceiveEntities>d__13");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PileView._OnPrepareToReceiveEntities_d__13>.NativeClassPtr);
				PileView._OnPrepareToReceiveEntities_d__13.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PileView._OnPrepareToReceiveEntities_d__13>.NativeClassPtr, "<>1__state");
				PileView._OnPrepareToReceiveEntities_d__13.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PileView._OnPrepareToReceiveEntities_d__13>.NativeClassPtr, "<>2__current");
				PileView._OnPrepareToReceiveEntities_d__13.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PileView._OnPrepareToReceiveEntities_d__13>.NativeClassPtr, "context");
				PileView._OnPrepareToReceiveEntities_d__13.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PileView._OnPrepareToReceiveEntities_d__13>.NativeClassPtr, "<>4__this");
				PileView._OnPrepareToReceiveEntities_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PileView._OnPrepareToReceiveEntities_d__13>.NativeClassPtr, 100664198);
				PileView._OnPrepareToReceiveEntities_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PileView._OnPrepareToReceiveEntities_d__13>.NativeClassPtr, 100664199);
				PileView._OnPrepareToReceiveEntities_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PileView._OnPrepareToReceiveEntities_d__13>.NativeClassPtr, 100664200);
				PileView._OnPrepareToReceiveEntities_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PileView._OnPrepareToReceiveEntities_d__13>.NativeClassPtr, 100664201);
				PileView._OnPrepareToReceiveEntities_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PileView._OnPrepareToReceiveEntities_d__13>.NativeClassPtr, 100664202);
				PileView._OnPrepareToReceiveEntities_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PileView._OnPrepareToReceiveEntities_d__13>.NativeClassPtr, 100664203);
			}

			// Token: 0x06000C8E RID: 3214 RVA: 0x00032230 File Offset: 0x00030430
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnPrepareToReceiveEntities_d__13(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PileView._OnPrepareToReceiveEntities_d__13>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PileView._OnPrepareToReceiveEntities_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000C8F RID: 3215 RVA: 0x00032278 File Offset: 0x00030478
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PileView._OnPrepareToReceiveEntities_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000C90 RID: 3216 RVA: 0x000322AC File Offset: 0x000304AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1113093, XrefRangeEnd = 1113136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PileView._OnPrepareToReceiveEntities_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170003B8 RID: 952
			// (get) Token: 0x06000C91 RID: 3217 RVA: 0x000322E8 File Offset: 0x000304E8
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PileView._OnPrepareToReceiveEntities_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000C92 RID: 3218 RVA: 0x00032328 File Offset: 0x00030528
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1113136, XrefRangeEnd = 1113141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PileView._OnPrepareToReceiveEntities_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170003B9 RID: 953
			// (get) Token: 0x06000C93 RID: 3219 RVA: 0x0003235C File Offset: 0x0003055C
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PileView._OnPrepareToReceiveEntities_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000C94 RID: 3220 RVA: 0x000082D5 File Offset: 0x000064D5
			public _OnPrepareToReceiveEntities_d__13(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170003B4 RID: 948
			// (get) Token: 0x06000C95 RID: 3221 RVA: 0x0003239C File Offset: 0x0003059C
			// (set) Token: 0x06000C96 RID: 3222 RVA: 0x000082DE File Offset: 0x000064DE
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PileView._OnPrepareToReceiveEntities_d__13.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PileView._OnPrepareToReceiveEntities_d__13.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170003B5 RID: 949
			// (get) Token: 0x06000C97 RID: 3223 RVA: 0x000323C4 File Offset: 0x000305C4
			// (set) Token: 0x06000C98 RID: 3224 RVA: 0x000082F9 File Offset: 0x000064F9
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PileView._OnPrepareToReceiveEntities_d__13.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PileView._OnPrepareToReceiveEntities_d__13.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003B6 RID: 950
			// (get) Token: 0x06000C99 RID: 3225 RVA: 0x000323F4 File Offset: 0x000305F4
			// (set) Token: 0x06000C9A RID: 3226 RVA: 0x00008318 File Offset: 0x00006518
			public unsafe MoveContext context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PileView._OnPrepareToReceiveEntities_d__13.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MoveContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PileView._OnPrepareToReceiveEntities_d__13.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003B7 RID: 951
			// (get) Token: 0x06000C9B RID: 3227 RVA: 0x00032424 File Offset: 0x00030624
			// (set) Token: 0x06000C9C RID: 3228 RVA: 0x00008337 File Offset: 0x00006537
			public unsafe PileView __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PileView._OnPrepareToReceiveEntities_d__13.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PileView>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PileView._OnPrepareToReceiveEntities_d__13.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040007CD RID: 1997
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040007CE RID: 1998
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040007CF RID: 1999
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x040007D0 RID: 2000
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040007D1 RID: 2001
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040007D2 RID: 2002
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040007D3 RID: 2003
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040007D4 RID: 2004
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040007D5 RID: 2005
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040007D6 RID: 2006
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
