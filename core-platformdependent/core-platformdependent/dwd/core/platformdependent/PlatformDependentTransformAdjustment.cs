using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace dwd.core.platformdependent
{
	// Token: 0x02000021 RID: 33
	[Serializable]
	public class PlatformDependentTransformAdjustment : PlatformDependentAdjustment
	{
		// Token: 0x06000125 RID: 293 RVA: 0x0000677C File Offset: 0x0000497C
		// Note: this type is marked as 'beforefieldinit'.
		static PlatformDependentTransformAdjustment()
		{
			Il2CppClassPointerStore<PlatformDependentTransformAdjustment>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-platformdependent.dll", "dwd.core.platformdependent", "PlatformDependentTransformAdjustment");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformDependentTransformAdjustment>.NativeClassPtr);
			PlatformDependentTransformAdjustment.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDependentTransformAdjustment>.NativeClassPtr, "position");
			PlatformDependentTransformAdjustment.NativeFieldInfoPtr_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDependentTransformAdjustment>.NativeClassPtr, "scale");
			PlatformDependentTransformAdjustment.NativeMethodInfoPtr_ApplyAdjustment_Public_Virtual_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformDependentTransformAdjustment>.NativeClassPtr, 100663418);
			PlatformDependentTransformAdjustment.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformDependentTransformAdjustment>.NativeClassPtr, 100663419);
		}

		// Token: 0x06000126 RID: 294 RVA: 0x000067FC File Offset: 0x000049FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239575, XrefRangeEnd = 1239578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyAdjustment(GameObject target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformDependentTransformAdjustment.NativeMethodInfoPtr_ApplyAdjustment_Public_Virtual_Void_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000127 RID: 295 RVA: 0x0000684C File Offset: 0x00004A4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239578, XrefRangeEnd = 1239583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlatformDependentTransformAdjustment()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformDependentTransformAdjustment>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformDependentTransformAdjustment.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000128 RID: 296 RVA: 0x000028C7 File Offset: 0x00000AC7
		public PlatformDependentTransformAdjustment(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000129 RID: 297 RVA: 0x00006888 File Offset: 0x00004A88
		// (set) Token: 0x0600012A RID: 298 RVA: 0x000028D0 File Offset: 0x00000AD0
		public unsafe Vector3 position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentTransformAdjustment.NativeFieldInfoPtr_position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentTransformAdjustment.NativeFieldInfoPtr_position)) = value;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600012B RID: 299 RVA: 0x000068B0 File Offset: 0x00004AB0
		// (set) Token: 0x0600012C RID: 300 RVA: 0x000028EB File Offset: 0x00000AEB
		public unsafe Vector3 scale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentTransformAdjustment.NativeFieldInfoPtr_scale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentTransformAdjustment.NativeFieldInfoPtr_scale)) = value;
			}
		}

		// Token: 0x040000A5 RID: 165
		private static readonly IntPtr NativeFieldInfoPtr_position;

		// Token: 0x040000A6 RID: 166
		private static readonly IntPtr NativeFieldInfoPtr_scale;

		// Token: 0x040000A7 RID: 167
		private static readonly IntPtr NativeMethodInfoPtr_ApplyAdjustment_Public_Virtual_Void_GameObject_0;

		// Token: 0x040000A8 RID: 168
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
