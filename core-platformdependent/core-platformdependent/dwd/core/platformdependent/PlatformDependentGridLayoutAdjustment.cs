using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace dwd.core.platformdependent
{
	// Token: 0x02000011 RID: 17
	[Serializable]
	public class PlatformDependentGridLayoutAdjustment : PlatformDependentAdjustment
	{
		// Token: 0x06000066 RID: 102 RVA: 0x00004418 File Offset: 0x00002618
		// Note: this type is marked as 'beforefieldinit'.
		static PlatformDependentGridLayoutAdjustment()
		{
			Il2CppClassPointerStore<PlatformDependentGridLayoutAdjustment>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-platformdependent.dll", "dwd.core.platformdependent", "PlatformDependentGridLayoutAdjustment");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformDependentGridLayoutAdjustment>.NativeClassPtr);
			PlatformDependentGridLayoutAdjustment.NativeFieldInfoPtr_cellSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDependentGridLayoutAdjustment>.NativeClassPtr, "cellSize");
			PlatformDependentGridLayoutAdjustment.NativeFieldInfoPtr_spacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDependentGridLayoutAdjustment>.NativeClassPtr, "spacing");
			PlatformDependentGridLayoutAdjustment.NativeFieldInfoPtr_padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDependentGridLayoutAdjustment>.NativeClassPtr, "padding");
			PlatformDependentGridLayoutAdjustment.NativeMethodInfoPtr_ApplyAdjustment_Public_Virtual_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformDependentGridLayoutAdjustment>.NativeClassPtr, 100663351);
			PlatformDependentGridLayoutAdjustment.NativeMethodInfoPtr_Approximately_Public_Boolean_GridLayoutGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformDependentGridLayoutAdjustment>.NativeClassPtr, 100663352);
			PlatformDependentGridLayoutAdjustment.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformDependentGridLayoutAdjustment>.NativeClassPtr, 100663353);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x000044C0 File Offset: 0x000026C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238953, XrefRangeEnd = 1238960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyAdjustment(GameObject target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformDependentGridLayoutAdjustment.NativeMethodInfoPtr_ApplyAdjustment_Public_Virtual_Void_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00004510 File Offset: 0x00002710
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238960, XrefRangeEnd = 1238962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Approximately(GridLayoutGroup layout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(layout);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformDependentGridLayoutAdjustment.NativeMethodInfoPtr_Approximately_Public_Boolean_GridLayoutGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00004560 File Offset: 0x00002760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238962, XrefRangeEnd = 1238965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlatformDependentGridLayoutAdjustment()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformDependentGridLayoutAdjustment>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformDependentGridLayoutAdjustment.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x000022DB File Offset: 0x000004DB
		public PlatformDependentGridLayoutAdjustment(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600006B RID: 107 RVA: 0x0000459C File Offset: 0x0000279C
		// (set) Token: 0x0600006C RID: 108 RVA: 0x000022E4 File Offset: 0x000004E4
		public unsafe Vector2 cellSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentGridLayoutAdjustment.NativeFieldInfoPtr_cellSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentGridLayoutAdjustment.NativeFieldInfoPtr_cellSize)) = value;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600006D RID: 109 RVA: 0x000045C4 File Offset: 0x000027C4
		// (set) Token: 0x0600006E RID: 110 RVA: 0x000022FF File Offset: 0x000004FF
		public unsafe Vector2 spacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentGridLayoutAdjustment.NativeFieldInfoPtr_spacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentGridLayoutAdjustment.NativeFieldInfoPtr_spacing)) = value;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600006F RID: 111 RVA: 0x000045EC File Offset: 0x000027EC
		// (set) Token: 0x06000070 RID: 112 RVA: 0x0000231A File Offset: 0x0000051A
		public unsafe RectOffset padding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentGridLayoutAdjustment.NativeFieldInfoPtr_padding);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectOffset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentGridLayoutAdjustment.NativeFieldInfoPtr_padding), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeFieldInfoPtr_cellSize;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeFieldInfoPtr_spacing;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeFieldInfoPtr_padding;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeMethodInfoPtr_ApplyAdjustment_Public_Virtual_Void_GameObject_0;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeMethodInfoPtr_Approximately_Public_Boolean_GridLayoutGroup_0;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
