using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using lotus;
using UnityEngine;

namespace voodoo.pathing
{
	// Token: 0x02000035 RID: 53
	public class RelativePathVoodoo : PathVoodoo
	{
		// Token: 0x060002FB RID: 763 RVA: 0x00012B88 File Offset: 0x00010D88
		// Note: this type is marked as 'beforefieldinit'.
		static RelativePathVoodoo()
		{
			Il2CppClassPointerStore<RelativePathVoodoo>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "voodoo.pathing", "RelativePathVoodoo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RelativePathVoodoo>.NativeClassPtr);
			RelativePathVoodoo.NativeFieldInfoPtr_startMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelativePathVoodoo>.NativeClassPtr, "startMatrix");
			RelativePathVoodoo.NativeFieldInfoPtr_startRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelativePathVoodoo>.NativeClassPtr, "startRot");
			RelativePathVoodoo.NativeMethodInfoPtr_InitWithContext_Public_Virtual_Void_UnitView_UnitPosition_LocalTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelativePathVoodoo>.NativeClassPtr, 100663634);
			RelativePathVoodoo.NativeMethodInfoPtr_updateWeights_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelativePathVoodoo>.NativeClassPtr, 100663635);
			RelativePathVoodoo.NativeMethodInfoPtr_computeScaleAtPos_Public_Virtual_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelativePathVoodoo>.NativeClassPtr, 100663636);
			RelativePathVoodoo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelativePathVoodoo>.NativeClassPtr, 100663637);
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00012C30 File Offset: 0x00010E30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1108323, XrefRangeEnd = 1108340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitWithContext(UnitView unitView, UnitPosition unitPosition, LocalTransform dlt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(unitView);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(unitPosition);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dlt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RelativePathVoodoo.NativeMethodInfoPtr_InitWithContext_Public_Virtual_Void_UnitView_UnitPosition_LocalTransform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002FD RID: 765 RVA: 0x00012CA0 File Offset: 0x00010EA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1108340, XrefRangeEnd = 1108388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void updateWeights(bool force)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref force;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RelativePathVoodoo.NativeMethodInfoPtr_updateWeights_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00012CEC File Offset: 0x00010EEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1108388, XrefRangeEnd = 1108390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Vector3 computeScaleAtPos(float pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RelativePathVoodoo.NativeMethodInfoPtr_computeScaleAtPos_Public_Virtual_Vector3_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002FF RID: 767 RVA: 0x00012D40 File Offset: 0x00010F40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RelativePathVoodoo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RelativePathVoodoo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelativePathVoodoo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00003897 File Offset: 0x00001A97
		public RelativePathVoodoo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000301 RID: 769 RVA: 0x00012D7C File Offset: 0x00010F7C
		// (set) Token: 0x06000302 RID: 770 RVA: 0x000038A0 File Offset: 0x00001AA0
		public unsafe Matrix4x4 startMatrix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelativePathVoodoo.NativeFieldInfoPtr_startMatrix);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelativePathVoodoo.NativeFieldInfoPtr_startMatrix)) = value;
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000303 RID: 771 RVA: 0x00012DA4 File Offset: 0x00010FA4
		// (set) Token: 0x06000304 RID: 772 RVA: 0x000038BB File Offset: 0x00001ABB
		public unsafe Quaternion startRot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelativePathVoodoo.NativeFieldInfoPtr_startRot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelativePathVoodoo.NativeFieldInfoPtr_startRot)) = value;
			}
		}

		// Token: 0x040001D2 RID: 466
		private static readonly IntPtr NativeFieldInfoPtr_startMatrix;

		// Token: 0x040001D3 RID: 467
		private static readonly IntPtr NativeFieldInfoPtr_startRot;

		// Token: 0x040001D4 RID: 468
		private static readonly IntPtr NativeMethodInfoPtr_InitWithContext_Public_Virtual_Void_UnitView_UnitPosition_LocalTransform_0;

		// Token: 0x040001D5 RID: 469
		private static readonly IntPtr NativeMethodInfoPtr_updateWeights_Protected_Virtual_Void_Boolean_0;

		// Token: 0x040001D6 RID: 470
		private static readonly IntPtr NativeMethodInfoPtr_computeScaleAtPos_Public_Virtual_Vector3_Single_0;

		// Token: 0x040001D7 RID: 471
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
