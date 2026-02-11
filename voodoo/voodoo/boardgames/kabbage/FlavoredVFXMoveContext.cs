using System;
using dwd.core.data.readonlyWrappers;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using lotus;
using UnityEngine;

namespace boardgames.kabbage
{
	// Token: 0x02000092 RID: 146
	public class FlavoredVFXMoveContext : MoveContext
	{
		// Token: 0x060008A0 RID: 2208 RVA: 0x00026288 File Offset: 0x00024488
		// Note: this type is marked as 'beforefieldinit'.
		static FlavoredVFXMoveContext()
		{
			Il2CppClassPointerStore<FlavoredVFXMoveContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "boardgames.kabbage", "FlavoredVFXMoveContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlavoredVFXMoveContext>.NativeClassPtr);
			FlavoredVFXMoveContext.NativeFieldInfoPtr_FXAnchorView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlavoredVFXMoveContext>.NativeClassPtr, "FXAnchorView");
			FlavoredVFXMoveContext.NativeFieldInfoPtr_FXAnchorTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlavoredVFXMoveContext>.NativeClassPtr, "FXAnchorTransform");
			FlavoredVFXMoveContext.NativeFieldInfoPtr_SiblingIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlavoredVFXMoveContext>.NativeClassPtr, "SiblingIndex");
			FlavoredVFXMoveContext.NativeFieldInfoPtr_vfxFlavors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlavoredVFXMoveContext>.NativeClassPtr, "vfxFlavors");
			FlavoredVFXMoveContext.NativeFieldInfoPtr_VFXFlavors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlavoredVFXMoveContext>.NativeClassPtr, "VFXFlavors");
			FlavoredVFXMoveContext.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlavoredVFXMoveContext>.NativeClassPtr, 100664551);
			FlavoredVFXMoveContext.NativeMethodInfoPtr__ctor_Public_Void_List_1_UnitView_List_1_Int32_ContainerView_ContainerView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlavoredVFXMoveContext>.NativeClassPtr, 100664552);
			FlavoredVFXMoveContext.NativeMethodInfoPtr_WithFlavors_Public_Void_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlavoredVFXMoveContext>.NativeClassPtr, 100664553);
			FlavoredVFXMoveContext.NativeMethodInfoPtr_WithFlavor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlavoredVFXMoveContext>.NativeClassPtr, 100664554);
		}

		// Token: 0x060008A1 RID: 2209 RVA: 0x0002636C File Offset: 0x0002456C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1116532, RefRangeEnd = 1116536, XrefRangeStart = 1116517, XrefRangeEnd = 1116532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FlavoredVFXMoveContext()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlavoredVFXMoveContext>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlavoredVFXMoveContext.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008A2 RID: 2210 RVA: 0x000263A8 File Offset: 0x000245A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1116536, XrefRangeEnd = 1116551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FlavoredVFXMoveContext(List<UnitView> views, List<int> slots, ContainerView start, ContainerView dest)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlavoredVFXMoveContext>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(views);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(slots);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(start);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dest);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlavoredVFXMoveContext.NativeMethodInfoPtr__ctor_Public_Void_List_1_UnitView_List_1_Int32_ContainerView_ContainerView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008A3 RID: 2211 RVA: 0x0002642C File Offset: 0x0002462C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1116571, RefRangeEnd = 1116575, XrefRangeStart = 1116551, XrefRangeEnd = 1116571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WithFlavors(IEnumerable<string> flavors)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(flavors);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlavoredVFXMoveContext.NativeMethodInfoPtr_WithFlavors_Public_Void_IEnumerable_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008A4 RID: 2212 RVA: 0x00026470 File Offset: 0x00024670
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1116579, RefRangeEnd = 1116587, XrefRangeStart = 1116575, XrefRangeEnd = 1116579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WithFlavor(string flavor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(flavor);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlavoredVFXMoveContext.NativeMethodInfoPtr_WithFlavor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008A5 RID: 2213 RVA: 0x00006347 File Offset: 0x00004547
		public FlavoredVFXMoveContext(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x060008A6 RID: 2214 RVA: 0x000264B4 File Offset: 0x000246B4
		// (set) Token: 0x060008A7 RID: 2215 RVA: 0x00006350 File Offset: 0x00004550
		public unsafe EntityView FXAnchorView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlavoredVFXMoveContext.NativeFieldInfoPtr_FXAnchorView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlavoredVFXMoveContext.NativeFieldInfoPtr_FXAnchorView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x060008A8 RID: 2216 RVA: 0x000264E4 File Offset: 0x000246E4
		// (set) Token: 0x060008A9 RID: 2217 RVA: 0x0000636F File Offset: 0x0000456F
		public unsafe Transform FXAnchorTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlavoredVFXMoveContext.NativeFieldInfoPtr_FXAnchorTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlavoredVFXMoveContext.NativeFieldInfoPtr_FXAnchorTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x060008AA RID: 2218 RVA: 0x00026514 File Offset: 0x00024714
		// (set) Token: 0x060008AB RID: 2219 RVA: 0x0000638E File Offset: 0x0000458E
		public unsafe int SiblingIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlavoredVFXMoveContext.NativeFieldInfoPtr_SiblingIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlavoredVFXMoveContext.NativeFieldInfoPtr_SiblingIndex)) = value;
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x060008AC RID: 2220 RVA: 0x0002653C File Offset: 0x0002473C
		// (set) Token: 0x060008AD RID: 2221 RVA: 0x000063A9 File Offset: 0x000045A9
		public unsafe HashSet<string> vfxFlavors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlavoredVFXMoveContext.NativeFieldInfoPtr_vfxFlavors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlavoredVFXMoveContext.NativeFieldInfoPtr_vfxFlavors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x060008AE RID: 2222 RVA: 0x0002656C File Offset: 0x0002476C
		// (set) Token: 0x060008AF RID: 2223 RVA: 0x000063C8 File Offset: 0x000045C8
		public unsafe ReadOnlyHashSet<string> VFXFlavors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlavoredVFXMoveContext.NativeFieldInfoPtr_VFXFlavors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyHashSet<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlavoredVFXMoveContext.NativeFieldInfoPtr_VFXFlavors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400056A RID: 1386
		private static readonly IntPtr NativeFieldInfoPtr_FXAnchorView;

		// Token: 0x0400056B RID: 1387
		private static readonly IntPtr NativeFieldInfoPtr_FXAnchorTransform;

		// Token: 0x0400056C RID: 1388
		private static readonly IntPtr NativeFieldInfoPtr_SiblingIndex;

		// Token: 0x0400056D RID: 1389
		private static readonly IntPtr NativeFieldInfoPtr_vfxFlavors;

		// Token: 0x0400056E RID: 1390
		private static readonly IntPtr NativeFieldInfoPtr_VFXFlavors;

		// Token: 0x0400056F RID: 1391
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000570 RID: 1392
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_UnitView_List_1_Int32_ContainerView_ContainerView_0;

		// Token: 0x04000571 RID: 1393
		private static readonly IntPtr NativeMethodInfoPtr_WithFlavors_Public_Void_IEnumerable_1_String_0;

		// Token: 0x04000572 RID: 1394
		private static readonly IntPtr NativeMethodInfoPtr_WithFlavor_Public_Void_String_0;
	}
}
