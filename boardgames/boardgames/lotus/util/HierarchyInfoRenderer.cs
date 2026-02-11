using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace lotus.util
{
	// Token: 0x020000D8 RID: 216
	public class HierarchyInfoRenderer : MonoBehaviour
	{
		// Token: 0x06000AD0 RID: 2768 RVA: 0x00033888 File Offset: 0x00031A88
		// Note: this type is marked as 'beforefieldinit'.
		static HierarchyInfoRenderer()
		{
			Il2CppClassPointerStore<HierarchyInfoRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lotus.util", "HierarchyInfoRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HierarchyInfoRenderer>.NativeClassPtr);
			HierarchyInfoRenderer.NativeFieldInfoPtr_INDENT_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchyInfoRenderer>.NativeClassPtr, "INDENT_SIZE");
			HierarchyInfoRenderer.NativeFieldInfoPtr_itemPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchyInfoRenderer>.NativeClassPtr, "itemPrefab");
			HierarchyInfoRenderer.NativeFieldInfoPtr_itemListParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchyInfoRenderer>.NativeClassPtr, "itemListParent");
			HierarchyInfoRenderer.NativeFieldInfoPtr_roots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchyInfoRenderer>.NativeClassPtr, "roots");
			HierarchyInfoRenderer.NativeFieldInfoPtr_allObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchyInfoRenderer>.NativeClassPtr, "allObjects");
			HierarchyInfoRenderer.NativeFieldInfoPtr_itemRenderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchyInfoRenderer>.NativeClassPtr, "itemRenderers");
			HierarchyInfoRenderer.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyInfoRenderer>.NativeClassPtr, 100665039);
			HierarchyInfoRenderer.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyInfoRenderer>.NativeClassPtr, 100665040);
			HierarchyInfoRenderer.NativeMethodInfoPtr_Refresh_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyInfoRenderer>.NativeClassPtr, 100665041);
			HierarchyInfoRenderer.NativeMethodInfoPtr_UpdateRoots_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyInfoRenderer>.NativeClassPtr, 100665042);
			HierarchyInfoRenderer.NativeMethodInfoPtr_UpdateHierarchy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyInfoRenderer>.NativeClassPtr, 100665043);
			HierarchyInfoRenderer.NativeMethodInfoPtr_AddHierarchyObject_Private_Void_Transform_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyInfoRenderer>.NativeClassPtr, 100665044);
			HierarchyInfoRenderer.NativeMethodInfoPtr_UpdateList_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyInfoRenderer>.NativeClassPtr, 100665045);
			HierarchyInfoRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyInfoRenderer>.NativeClassPtr, 100665046);
		}

		// Token: 0x06000AD1 RID: 2769 RVA: 0x000339D0 File Offset: 0x00031BD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994251, XrefRangeEnd = 994272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HierarchyInfoRenderer.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AD2 RID: 2770 RVA: 0x00033A04 File Offset: 0x00031C04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994272, XrefRangeEnd = 994275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HierarchyInfoRenderer.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AD3 RID: 2771 RVA: 0x00033A38 File Offset: 0x00031C38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Refresh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HierarchyInfoRenderer.NativeMethodInfoPtr_Refresh_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AD4 RID: 2772 RVA: 0x00033A6C File Offset: 0x00031C6C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 994301, RefRangeEnd = 994303, XrefRangeStart = 994275, XrefRangeEnd = 994301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateRoots()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HierarchyInfoRenderer.NativeMethodInfoPtr_UpdateRoots_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AD5 RID: 2773 RVA: 0x00033AA0 File Offset: 0x00031CA0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 994321, RefRangeEnd = 994323, XrefRangeStart = 994303, XrefRangeEnd = 994321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateHierarchy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HierarchyInfoRenderer.NativeMethodInfoPtr_UpdateHierarchy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AD6 RID: 2774 RVA: 0x00033AD4 File Offset: 0x00031CD4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 994339, RefRangeEnd = 994341, XrefRangeStart = 994323, XrefRangeEnd = 994339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddHierarchyObject(Transform parentTransform, int depth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentTransform);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HierarchyInfoRenderer.NativeMethodInfoPtr_AddHierarchyObject_Private_Void_Transform_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AD7 RID: 2775 RVA: 0x00033B24 File Offset: 0x00031D24
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 994382, RefRangeEnd = 994384, XrefRangeStart = 994341, XrefRangeEnd = 994382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateList()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HierarchyInfoRenderer.NativeMethodInfoPtr_UpdateList_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AD8 RID: 2776 RVA: 0x00033B58 File Offset: 0x00031D58
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HierarchyInfoRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HierarchyInfoRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HierarchyInfoRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AD9 RID: 2777 RVA: 0x00006F5E File Offset: 0x0000515E
		public HierarchyInfoRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06000ADA RID: 2778 RVA: 0x00033B94 File Offset: 0x00031D94
		// (set) Token: 0x06000ADB RID: 2779 RVA: 0x00006F67 File Offset: 0x00005167
		public unsafe static int INDENT_SIZE
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HierarchyInfoRenderer.NativeFieldInfoPtr_INDENT_SIZE, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HierarchyInfoRenderer.NativeFieldInfoPtr_INDENT_SIZE, (void*)(&value));
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06000ADC RID: 2780 RVA: 0x00033BB0 File Offset: 0x00031DB0
		// (set) Token: 0x06000ADD RID: 2781 RVA: 0x00006F75 File Offset: 0x00005175
		public unsafe HierarchyItemRenderer itemPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HierarchyInfoRenderer.NativeFieldInfoPtr_itemPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HierarchyItemRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HierarchyInfoRenderer.NativeFieldInfoPtr_itemPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06000ADE RID: 2782 RVA: 0x00033BE0 File Offset: 0x00031DE0
		// (set) Token: 0x06000ADF RID: 2783 RVA: 0x00006F94 File Offset: 0x00005194
		public unsafe Transform itemListParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HierarchyInfoRenderer.NativeFieldInfoPtr_itemListParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HierarchyInfoRenderer.NativeFieldInfoPtr_itemListParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06000AE0 RID: 2784 RVA: 0x00033C10 File Offset: 0x00031E10
		// (set) Token: 0x06000AE1 RID: 2785 RVA: 0x00006FB3 File Offset: 0x000051B3
		public unsafe List<GameObject> roots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HierarchyInfoRenderer.NativeFieldInfoPtr_roots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HierarchyInfoRenderer.NativeFieldInfoPtr_roots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06000AE2 RID: 2786 RVA: 0x00033C40 File Offset: 0x00031E40
		// (set) Token: 0x06000AE3 RID: 2787 RVA: 0x00006FD2 File Offset: 0x000051D2
		public unsafe List<HierarchyInfoRenderer.GameObjectHierarchyData> allObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HierarchyInfoRenderer.NativeFieldInfoPtr_allObjects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<HierarchyInfoRenderer.GameObjectHierarchyData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HierarchyInfoRenderer.NativeFieldInfoPtr_allObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06000AE4 RID: 2788 RVA: 0x00033C70 File Offset: 0x00031E70
		// (set) Token: 0x06000AE5 RID: 2789 RVA: 0x00006FF1 File Offset: 0x000051F1
		public unsafe List<HierarchyItemRenderer> itemRenderers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HierarchyInfoRenderer.NativeFieldInfoPtr_itemRenderers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<HierarchyItemRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HierarchyInfoRenderer.NativeFieldInfoPtr_itemRenderers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040006A9 RID: 1705
		private static readonly IntPtr NativeFieldInfoPtr_INDENT_SIZE;

		// Token: 0x040006AA RID: 1706
		private static readonly IntPtr NativeFieldInfoPtr_itemPrefab;

		// Token: 0x040006AB RID: 1707
		private static readonly IntPtr NativeFieldInfoPtr_itemListParent;

		// Token: 0x040006AC RID: 1708
		private static readonly IntPtr NativeFieldInfoPtr_roots;

		// Token: 0x040006AD RID: 1709
		private static readonly IntPtr NativeFieldInfoPtr_allObjects;

		// Token: 0x040006AE RID: 1710
		private static readonly IntPtr NativeFieldInfoPtr_itemRenderers;

		// Token: 0x040006AF RID: 1711
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040006B0 RID: 1712
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x040006B1 RID: 1713
		private static readonly IntPtr NativeMethodInfoPtr_Refresh_Public_Void_0;

		// Token: 0x040006B2 RID: 1714
		private static readonly IntPtr NativeMethodInfoPtr_UpdateRoots_Private_Void_0;

		// Token: 0x040006B3 RID: 1715
		private static readonly IntPtr NativeMethodInfoPtr_UpdateHierarchy_Private_Void_0;

		// Token: 0x040006B4 RID: 1716
		private static readonly IntPtr NativeMethodInfoPtr_AddHierarchyObject_Private_Void_Transform_Int32_0;

		// Token: 0x040006B5 RID: 1717
		private static readonly IntPtr NativeMethodInfoPtr_UpdateList_Private_Void_0;

		// Token: 0x040006B6 RID: 1718
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200023F RID: 575
		public sealed class GameObjectHierarchyData : ValueType
		{
			// Token: 0x06001AA1 RID: 6817 RVA: 0x000635FC File Offset: 0x000617FC
			// Note: this type is marked as 'beforefieldinit'.
			static GameObjectHierarchyData()
			{
				Il2CppClassPointerStore<HierarchyInfoRenderer.GameObjectHierarchyData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HierarchyInfoRenderer>.NativeClassPtr, "GameObjectHierarchyData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HierarchyInfoRenderer.GameObjectHierarchyData>.NativeClassPtr);
				HierarchyInfoRenderer.GameObjectHierarchyData.NativeFieldInfoPtr_GameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchyInfoRenderer.GameObjectHierarchyData>.NativeClassPtr, "GameObject");
				HierarchyInfoRenderer.GameObjectHierarchyData.NativeFieldInfoPtr_Depth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchyInfoRenderer.GameObjectHierarchyData>.NativeClassPtr, "Depth");
				HierarchyInfoRenderer.GameObjectHierarchyData.NativeMethodInfoPtr__ctor_Public_Void_GameObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyInfoRenderer.GameObjectHierarchyData>.NativeClassPtr, 100665047);
			}

			// Token: 0x06001AA2 RID: 6818 RVA: 0x00063664 File Offset: 0x00061864
			[CallerCount(40)]
			[CachedScanResults(RefRangeStart = 336243, RefRangeEnd = 336283, XrefRangeStart = 336243, XrefRangeEnd = 336283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GameObjectHierarchyData(GameObject gameObject, int depth)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HierarchyInfoRenderer.GameObjectHierarchyData>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HierarchyInfoRenderer.GameObjectHierarchyData.NativeMethodInfoPtr__ctor_Public_Void_GameObject_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001AA3 RID: 6819 RVA: 0x0000E7F6 File Offset: 0x0000C9F6
			public GameObjectHierarchyData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001AA4 RID: 6820 RVA: 0x0000E7FF File Offset: 0x0000C9FF
			public GameObjectHierarchyData()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HierarchyInfoRenderer.GameObjectHierarchyData>.NativeClassPtr))
			{
			}

			// Token: 0x170007CF RID: 1999
			// (get) Token: 0x06001AA5 RID: 6821 RVA: 0x000636C4 File Offset: 0x000618C4
			// (set) Token: 0x06001AA6 RID: 6822 RVA: 0x0000E811 File Offset: 0x0000CA11
			public unsafe GameObject GameObject
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HierarchyInfoRenderer.GameObjectHierarchyData.NativeFieldInfoPtr_GameObject);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HierarchyInfoRenderer.GameObjectHierarchyData.NativeFieldInfoPtr_GameObject), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007D0 RID: 2000
			// (get) Token: 0x06001AA7 RID: 6823 RVA: 0x000636F4 File Offset: 0x000618F4
			// (set) Token: 0x06001AA8 RID: 6824 RVA: 0x0000E830 File Offset: 0x0000CA30
			public unsafe int Depth
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HierarchyInfoRenderer.GameObjectHierarchyData.NativeFieldInfoPtr_Depth);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HierarchyInfoRenderer.GameObjectHierarchyData.NativeFieldInfoPtr_Depth)) = value;
				}
			}

			// Token: 0x0400101C RID: 4124
			private static readonly IntPtr NativeFieldInfoPtr_GameObject;

			// Token: 0x0400101D RID: 4125
			private static readonly IntPtr NativeFieldInfoPtr_Depth;

			// Token: 0x0400101E RID: 4126
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameObject_Int32_0;
		}
	}
}
