using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace dwd.core.input.ui.selectable.advancedNavigation
{
	// Token: 0x02000060 RID: 96
	public class AdvancedSelectableNavigation : MonoBehaviour
	{
		// Token: 0x060003A4 RID: 932 RVA: 0x00012254 File Offset: 0x00010454
		// Note: this type is marked as 'beforefieldinit'.
		static AdvancedSelectableNavigation()
		{
			Il2CppClassPointerStore<AdvancedSelectableNavigation>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.ui.selectable.advancedNavigation", "AdvancedSelectableNavigation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AdvancedSelectableNavigation>.NativeClassPtr);
			AdvancedSelectableNavigation.NativeFieldInfoPtr_AllowSelectionWhenNoninteractable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedSelectableNavigation>.NativeClassPtr, "AllowSelectionWhenNoninteractable");
			AdvancedSelectableNavigation.NativeFieldInfoPtr_SourceSelectionCenter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedSelectableNavigation>.NativeClassPtr, "SourceSelectionCenter");
			AdvancedSelectableNavigation.NativeFieldInfoPtr_NavigateLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedSelectableNavigation>.NativeClassPtr, "NavigateLeft");
			AdvancedSelectableNavigation.NativeFieldInfoPtr_NavigateRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedSelectableNavigation>.NativeClassPtr, "NavigateRight");
			AdvancedSelectableNavigation.NativeFieldInfoPtr_NavigateUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedSelectableNavigation>.NativeClassPtr, "NavigateUp");
			AdvancedSelectableNavigation.NativeFieldInfoPtr_NavigateDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedSelectableNavigation>.NativeClassPtr, "NavigateDown");
			AdvancedSelectableNavigation.NativeMethodInfoPtr_get_Selectable_Public_get_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedSelectableNavigation>.NativeClassPtr, 100663705);
			AdvancedSelectableNavigation.NativeMethodInfoPtr_IAdvancedSelectableNavigation_get_AllowSelectionWhenNoninteractable_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedSelectableNavigation>.NativeClassPtr, 100663706);
			AdvancedSelectableNavigation.NativeMethodInfoPtr_IAdvancedSelectableNavigation_get_SourceSelectionCenter_Private_Virtual_Final_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedSelectableNavigation>.NativeClassPtr, 100663707);
			AdvancedSelectableNavigation.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedSelectableNavigation>.NativeClassPtr, 100663708);
			AdvancedSelectableNavigation.NativeMethodInfoPtr_GetNavDataByDirection_Public_Virtual_Final_New_DirectionalNavigationData_MoveDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedSelectableNavigation>.NativeClassPtr, 100663709);
			AdvancedSelectableNavigation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedSelectableNavigation>.NativeClassPtr, 100663710);
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060003A5 RID: 933 RVA: 0x00012374 File Offset: 0x00010574
		public unsafe Selectable Selectable
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121930, XrefRangeEnd = 1121933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedSelectableNavigation.NativeMethodInfoPtr_get_Selectable_Public_get_Selectable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr3) : null;
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060003A6 RID: 934 RVA: 0x000123B4 File Offset: 0x000105B4
		public unsafe virtual bool IAdvancedSelectableNavigation.AllowSelectionWhenNoninteractable
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 308625, RefRangeEnd = 308626, XrefRangeStart = 308625, XrefRangeEnd = 308626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedSelectableNavigation.NativeMethodInfoPtr_IAdvancedSelectableNavigation_get_AllowSelectionWhenNoninteractable_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060003A7 RID: 935 RVA: 0x000123F0 File Offset: 0x000105F0
		public unsafe virtual Transform IAdvancedSelectableNavigation.SourceSelectionCenter
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedSelectableNavigation.NativeMethodInfoPtr_IAdvancedSelectableNavigation_get_SourceSelectionCenter_Private_Virtual_Final_New_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x00012430 File Offset: 0x00010630
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedSelectableNavigation.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x00012464 File Offset: 0x00010664
		[CallerCount(0)]
		public unsafe virtual DirectionalNavigationData GetNavDataByDirection(MoveDirection navDirection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref navDirection;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedSelectableNavigation.NativeMethodInfoPtr_GetNavDataByDirection_Public_Virtual_Final_New_DirectionalNavigationData_MoveDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DirectionalNavigationData>(intPtr3) : null;
			}
		}

		// Token: 0x060003AA RID: 938 RVA: 0x000124B0 File Offset: 0x000106B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121933, XrefRangeEnd = 1121951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AdvancedSelectableNavigation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AdvancedSelectableNavigation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedSelectableNavigation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003AB RID: 939 RVA: 0x000041E5 File Offset: 0x000023E5
		public AdvancedSelectableNavigation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x060003AC RID: 940 RVA: 0x000124EC File Offset: 0x000106EC
		// (set) Token: 0x060003AD RID: 941 RVA: 0x000041EE File Offset: 0x000023EE
		public unsafe bool AllowSelectionWhenNoninteractable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedSelectableNavigation.NativeFieldInfoPtr_AllowSelectionWhenNoninteractable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedSelectableNavigation.NativeFieldInfoPtr_AllowSelectionWhenNoninteractable)) = value;
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x060003AE RID: 942 RVA: 0x00012514 File Offset: 0x00010714
		// (set) Token: 0x060003AF RID: 943 RVA: 0x00004209 File Offset: 0x00002409
		public unsafe Transform SourceSelectionCenter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedSelectableNavigation.NativeFieldInfoPtr_SourceSelectionCenter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedSelectableNavigation.NativeFieldInfoPtr_SourceSelectionCenter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060003B0 RID: 944 RVA: 0x00012544 File Offset: 0x00010744
		// (set) Token: 0x060003B1 RID: 945 RVA: 0x00004228 File Offset: 0x00002428
		public unsafe DirectionalNavigationData NavigateLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedSelectableNavigation.NativeFieldInfoPtr_NavigateLeft);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DirectionalNavigationData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedSelectableNavigation.NativeFieldInfoPtr_NavigateLeft), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x060003B2 RID: 946 RVA: 0x00012574 File Offset: 0x00010774
		// (set) Token: 0x060003B3 RID: 947 RVA: 0x00004247 File Offset: 0x00002447
		public unsafe DirectionalNavigationData NavigateRight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedSelectableNavigation.NativeFieldInfoPtr_NavigateRight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DirectionalNavigationData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedSelectableNavigation.NativeFieldInfoPtr_NavigateRight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x060003B4 RID: 948 RVA: 0x000125A4 File Offset: 0x000107A4
		// (set) Token: 0x060003B5 RID: 949 RVA: 0x00004266 File Offset: 0x00002466
		public unsafe DirectionalNavigationData NavigateUp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedSelectableNavigation.NativeFieldInfoPtr_NavigateUp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DirectionalNavigationData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedSelectableNavigation.NativeFieldInfoPtr_NavigateUp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060003B6 RID: 950 RVA: 0x000125D4 File Offset: 0x000107D4
		// (set) Token: 0x060003B7 RID: 951 RVA: 0x00004285 File Offset: 0x00002485
		public unsafe DirectionalNavigationData NavigateDown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedSelectableNavigation.NativeFieldInfoPtr_NavigateDown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DirectionalNavigationData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedSelectableNavigation.NativeFieldInfoPtr_NavigateDown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000221 RID: 545
		private static readonly IntPtr NativeFieldInfoPtr_AllowSelectionWhenNoninteractable;

		// Token: 0x04000222 RID: 546
		private static readonly IntPtr NativeFieldInfoPtr_SourceSelectionCenter;

		// Token: 0x04000223 RID: 547
		private static readonly IntPtr NativeFieldInfoPtr_NavigateLeft;

		// Token: 0x04000224 RID: 548
		private static readonly IntPtr NativeFieldInfoPtr_NavigateRight;

		// Token: 0x04000225 RID: 549
		private static readonly IntPtr NativeFieldInfoPtr_NavigateUp;

		// Token: 0x04000226 RID: 550
		private static readonly IntPtr NativeFieldInfoPtr_NavigateDown;

		// Token: 0x04000227 RID: 551
		private static readonly IntPtr NativeMethodInfoPtr_get_Selectable_Public_get_Selectable_0;

		// Token: 0x04000228 RID: 552
		private static readonly IntPtr NativeMethodInfoPtr_IAdvancedSelectableNavigation_get_AllowSelectionWhenNoninteractable_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000229 RID: 553
		private static readonly IntPtr NativeMethodInfoPtr_IAdvancedSelectableNavigation_get_SourceSelectionCenter_Private_Virtual_Final_New_get_Transform_0;

		// Token: 0x0400022A RID: 554
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400022B RID: 555
		private static readonly IntPtr NativeMethodInfoPtr_GetNavDataByDirection_Public_Virtual_Final_New_DirectionalNavigationData_MoveDirection_0;

		// Token: 0x0400022C RID: 556
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
