using System;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lotus;
using UnityEngine;
using voodoo;

namespace dbgclient.match.render
{
	// Token: 0x020000AB RID: 171
	public class StrategicViewElement : VersionedDataComponentObserver<EntityComponent>
	{
		// Token: 0x060006CB RID: 1739 RVA: 0x000330AC File Offset: 0x000312AC
		// Note: this type is marked as 'beforefieldinit'.
		static StrategicViewElement()
		{
			Il2CppClassPointerStore<StrategicViewElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.match.render", "StrategicViewElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StrategicViewElement>.NativeClassPtr);
			StrategicViewElement.NativeFieldInfoPtr_iconPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StrategicViewElement>.NativeClassPtr, "iconPrefab");
			StrategicViewElement.NativeFieldInfoPtr_sortOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StrategicViewElement>.NativeClassPtr, "sortOrder");
			StrategicViewElement.NativeFieldInfoPtr_doScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StrategicViewElement>.NativeClassPtr, "doScale");
			StrategicViewElement.NativeFieldInfoPtr_maxScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StrategicViewElement>.NativeClassPtr, "maxScale");
			StrategicViewElement.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StrategicViewElement>.NativeClassPtr, "instance");
			StrategicViewElement.NativeFieldInfoPtr_instanceEntityView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StrategicViewElement>.NativeClassPtr, "instanceEntityView");
			StrategicViewElement.NativeFieldInfoPtr_initialScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StrategicViewElement>.NativeClassPtr, "initialScale");
			StrategicViewElement.NativeFieldInfoPtr_strategicViewCanvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StrategicViewElement>.NativeClassPtr, "strategicViewCanvas");
			StrategicViewElement.NativeFieldInfoPtr_locatorTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StrategicViewElement>.NativeClassPtr, "locatorTransform");
			StrategicViewElement.NativeMethodInfoPtr_get_Instance_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StrategicViewElement>.NativeClassPtr, 100664363);
			StrategicViewElement.NativeMethodInfoPtr_PositionFor_Public_Void_Camera_RectTransform_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StrategicViewElement>.NativeClassPtr, 100664364);
			StrategicViewElement.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StrategicViewElement>.NativeClassPtr, 100664365);
			StrategicViewElement.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StrategicViewElement>.NativeClassPtr, 100664366);
			StrategicViewElement.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StrategicViewElement>.NativeClassPtr, 100664367);
			StrategicViewElement.NativeMethodInfoPtr_GetInstanceTransform_Public_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StrategicViewElement>.NativeClassPtr, 100664368);
			StrategicViewElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StrategicViewElement>.NativeClassPtr, 100664369);
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x060006CC RID: 1740 RVA: 0x0003321C File Offset: 0x0003141C
		public unsafe RectTransform Instance
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 503838, RefRangeEnd = 503845, XrefRangeStart = 503821, XrefRangeEnd = 503838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StrategicViewElement.NativeMethodInfoPtr_get_Instance_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x0003325C File Offset: 0x0003145C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 503873, RefRangeEnd = 503874, XrefRangeStart = 503845, XrefRangeEnd = 503873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PositionFor(Camera canvasCamera, RectTransform canvasTransform, float zoomPercent, int siblingIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(canvasCamera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(canvasTransform);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref zoomPercent;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref siblingIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StrategicViewElement.NativeMethodInfoPtr_PositionFor_Public_Void_Camera_RectTransform_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006CE RID: 1742 RVA: 0x000332CC File Offset: 0x000314CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503874, XrefRangeEnd = 503901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StrategicViewElement.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006CF RID: 1743 RVA: 0x00033300 File Offset: 0x00031500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503901, XrefRangeEnd = 503926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StrategicViewElement.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006D0 RID: 1744 RVA: 0x00033334 File Offset: 0x00031534
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void versionChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StrategicViewElement.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x00033370 File Offset: 0x00031570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503926, XrefRangeEnd = 503927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RectTransform GetInstanceTransform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StrategicViewElement.NativeMethodInfoPtr_GetInstanceTransform_Public_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
		}

		// Token: 0x060006D2 RID: 1746 RVA: 0x000333B0 File Offset: 0x000315B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503927, XrefRangeEnd = 503930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StrategicViewElement()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StrategicViewElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StrategicViewElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x0000519B File Offset: 0x0000339B
		public StrategicViewElement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x060006D4 RID: 1748 RVA: 0x000333EC File Offset: 0x000315EC
		// (set) Token: 0x060006D5 RID: 1749 RVA: 0x000051A4 File Offset: 0x000033A4
		public unsafe RectTransform iconPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StrategicViewElement.NativeFieldInfoPtr_iconPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StrategicViewElement.NativeFieldInfoPtr_iconPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x060006D6 RID: 1750 RVA: 0x0003341C File Offset: 0x0003161C
		// (set) Token: 0x060006D7 RID: 1751 RVA: 0x000051C3 File Offset: 0x000033C3
		public unsafe int sortOrder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StrategicViewElement.NativeFieldInfoPtr_sortOrder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StrategicViewElement.NativeFieldInfoPtr_sortOrder)) = value;
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x060006D8 RID: 1752 RVA: 0x00033444 File Offset: 0x00031644
		// (set) Token: 0x060006D9 RID: 1753 RVA: 0x000051DE File Offset: 0x000033DE
		public unsafe bool doScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StrategicViewElement.NativeFieldInfoPtr_doScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StrategicViewElement.NativeFieldInfoPtr_doScale)) = value;
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x060006DA RID: 1754 RVA: 0x0003346C File Offset: 0x0003166C
		// (set) Token: 0x060006DB RID: 1755 RVA: 0x000051F9 File Offset: 0x000033F9
		public unsafe float maxScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StrategicViewElement.NativeFieldInfoPtr_maxScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StrategicViewElement.NativeFieldInfoPtr_maxScale)) = value;
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x060006DC RID: 1756 RVA: 0x00033494 File Offset: 0x00031694
		// (set) Token: 0x060006DD RID: 1757 RVA: 0x00005214 File Offset: 0x00003414
		public unsafe RectTransform instance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StrategicViewElement.NativeFieldInfoPtr_instance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StrategicViewElement.NativeFieldInfoPtr_instance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x060006DE RID: 1758 RVA: 0x000334C4 File Offset: 0x000316C4
		// (set) Token: 0x060006DF RID: 1759 RVA: 0x00005233 File Offset: 0x00003433
		public unsafe EntityView instanceEntityView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StrategicViewElement.NativeFieldInfoPtr_instanceEntityView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StrategicViewElement.NativeFieldInfoPtr_instanceEntityView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x060006E0 RID: 1760 RVA: 0x000334F4 File Offset: 0x000316F4
		// (set) Token: 0x060006E1 RID: 1761 RVA: 0x00005252 File Offset: 0x00003452
		public unsafe float initialScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StrategicViewElement.NativeFieldInfoPtr_initialScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StrategicViewElement.NativeFieldInfoPtr_initialScale)) = value;
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x060006E2 RID: 1762 RVA: 0x0003351C File Offset: 0x0003171C
		// (set) Token: 0x060006E3 RID: 1763 RVA: 0x0000526D File Offset: 0x0000346D
		public unsafe StrategicViewCanvas strategicViewCanvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StrategicViewElement.NativeFieldInfoPtr_strategicViewCanvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StrategicViewCanvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StrategicViewElement.NativeFieldInfoPtr_strategicViewCanvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x060006E4 RID: 1764 RVA: 0x0003354C File Offset: 0x0003174C
		// (set) Token: 0x060006E5 RID: 1765 RVA: 0x0000528C File Offset: 0x0000348C
		public unsafe Transform locatorTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StrategicViewElement.NativeFieldInfoPtr_locatorTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StrategicViewElement.NativeFieldInfoPtr_locatorTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400042D RID: 1069
		private static readonly IntPtr NativeFieldInfoPtr_iconPrefab;

		// Token: 0x0400042E RID: 1070
		private static readonly IntPtr NativeFieldInfoPtr_sortOrder;

		// Token: 0x0400042F RID: 1071
		private static readonly IntPtr NativeFieldInfoPtr_doScale;

		// Token: 0x04000430 RID: 1072
		private static readonly IntPtr NativeFieldInfoPtr_maxScale;

		// Token: 0x04000431 RID: 1073
		private static readonly IntPtr NativeFieldInfoPtr_instance;

		// Token: 0x04000432 RID: 1074
		private static readonly IntPtr NativeFieldInfoPtr_instanceEntityView;

		// Token: 0x04000433 RID: 1075
		private static readonly IntPtr NativeFieldInfoPtr_initialScale;

		// Token: 0x04000434 RID: 1076
		private static readonly IntPtr NativeFieldInfoPtr_strategicViewCanvas;

		// Token: 0x04000435 RID: 1077
		private static readonly IntPtr NativeFieldInfoPtr_locatorTransform;

		// Token: 0x04000436 RID: 1078
		private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_get_RectTransform_0;

		// Token: 0x04000437 RID: 1079
		private static readonly IntPtr NativeMethodInfoPtr_PositionFor_Public_Void_Camera_RectTransform_Single_Int32_0;

		// Token: 0x04000438 RID: 1080
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000439 RID: 1081
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x0400043A RID: 1082
		private static readonly IntPtr NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0;

		// Token: 0x0400043B RID: 1083
		private static readonly IntPtr NativeMethodInfoPtr_GetInstanceTransform_Public_RectTransform_0;

		// Token: 0x0400043C RID: 1084
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
