using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Kyub.UI
{
	// Token: 0x02000006 RID: 6
	public class NestedScrollRect : ScrollRect
	{
		// Token: 0x06000053 RID: 83 RVA: 0x00003A28 File Offset: 0x00001C28
		// Note: this type is marked as 'beforefieldinit'.
		static NestedScrollRect()
		{
			Il2CppClassPointerStore<NestedScrollRect>.NativeClassPtr = IL2CPP.GetIl2CppClass("UICommons.dll", "Kyub.UI", "NestedScrollRect");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NestedScrollRect>.NativeClassPtr);
			NestedScrollRect.NativeFieldInfoPtr_m_NestedDragActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NestedScrollRect>.NativeClassPtr, "m_NestedDragActive");
			NestedScrollRect.NativeFieldInfoPtr__routeToParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NestedScrollRect>.NativeClassPtr, "_routeToParent");
			NestedScrollRect.NativeFieldInfoPtr__MinWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NestedScrollRect>.NativeClassPtr, "_MinWidth");
			NestedScrollRect.NativeFieldInfoPtr__MinHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NestedScrollRect>.NativeClassPtr, "_MinHeight");
			NestedScrollRect.NativeFieldInfoPtr__PreferredWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NestedScrollRect>.NativeClassPtr, "_PreferredWidth");
			NestedScrollRect.NativeFieldInfoPtr__PreferredHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NestedScrollRect>.NativeClassPtr, "_PreferredHeight");
			NestedScrollRect.NativeMethodInfoPtr_get_nestedDragActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NestedScrollRect>.NativeClassPtr, 100663363);
			NestedScrollRect.NativeMethodInfoPtr_set_nestedDragActive_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NestedScrollRect>.NativeClassPtr, 100663364);
			NestedScrollRect.NativeMethodInfoPtr_OnInitializePotentialDrag_Public_Virtual_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NestedScrollRect>.NativeClassPtr, 100663365);
			NestedScrollRect.NativeMethodInfoPtr_OnDrag_Public_Virtual_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NestedScrollRect>.NativeClassPtr, 100663366);
			NestedScrollRect.NativeMethodInfoPtr_OnBeginDrag_Public_Virtual_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NestedScrollRect>.NativeClassPtr, 100663367);
			NestedScrollRect.NativeMethodInfoPtr_OnEndDrag_Public_Virtual_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NestedScrollRect>.NativeClassPtr, 100663368);
			NestedScrollRect.NativeMethodInfoPtr_get_preferredWidth_Public_Virtual_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NestedScrollRect>.NativeClassPtr, 100663369);
			NestedScrollRect.NativeMethodInfoPtr_get_preferredHeight_Public_Virtual_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NestedScrollRect>.NativeClassPtr, 100663370);
			NestedScrollRect.NativeMethodInfoPtr_get_minWidth_Public_Virtual_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NestedScrollRect>.NativeClassPtr, 100663371);
			NestedScrollRect.NativeMethodInfoPtr_get_minHeight_Public_Virtual_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NestedScrollRect>.NativeClassPtr, 100663372);
			NestedScrollRect.NativeMethodInfoPtr_get_layoutPriority_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NestedScrollRect>.NativeClassPtr, 100663373);
			NestedScrollRect.NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NestedScrollRect>.NativeClassPtr, 100663374);
			NestedScrollRect.NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NestedScrollRect>.NativeClassPtr, 100663375);
			NestedScrollRect.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NestedScrollRect>.NativeClassPtr, 100663376);
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000054 RID: 84 RVA: 0x00003BE8 File Offset: 0x00001DE8
		// (set) Token: 0x06000055 RID: 85 RVA: 0x00003C24 File Offset: 0x00001E24
		public unsafe bool nestedDragActive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NestedScrollRect.NativeMethodInfoPtr_get_nestedDragActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NestedScrollRect.NativeMethodInfoPtr_set_nestedDragActive_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00003C64 File Offset: 0x00001E64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269557, XrefRangeEnd = 1269572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnInitializePotentialDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NestedScrollRect.NativeMethodInfoPtr_OnInitializePotentialDrag_Public_Virtual_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00003CB4 File Offset: 0x00001EB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269572, XrefRangeEnd = 1269587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NestedScrollRect.NativeMethodInfoPtr_OnDrag_Public_Virtual_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00003D04 File Offset: 0x00001F04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269587, XrefRangeEnd = 1269608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBeginDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NestedScrollRect.NativeMethodInfoPtr_OnBeginDrag_Public_Virtual_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00003D54 File Offset: 0x00001F54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269608, XrefRangeEnd = 1269621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEndDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NestedScrollRect.NativeMethodInfoPtr_OnEndDrag_Public_Virtual_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600005A RID: 90 RVA: 0x00003DA4 File Offset: 0x00001FA4
		public unsafe override float preferredWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NestedScrollRect.NativeMethodInfoPtr_get_preferredWidth_Public_Virtual_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600005B RID: 91 RVA: 0x00003DEC File Offset: 0x00001FEC
		public unsafe override float preferredHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NestedScrollRect.NativeMethodInfoPtr_get_preferredHeight_Public_Virtual_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600005C RID: 92 RVA: 0x00003E34 File Offset: 0x00002034
		public unsafe override float minWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NestedScrollRect.NativeMethodInfoPtr_get_minWidth_Public_Virtual_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600005D RID: 93 RVA: 0x00003E7C File Offset: 0x0000207C
		public unsafe override float minHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NestedScrollRect.NativeMethodInfoPtr_get_minHeight_Public_Virtual_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600005E RID: 94 RVA: 0x00003EC4 File Offset: 0x000020C4
		public unsafe override int layoutPriority
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NestedScrollRect.NativeMethodInfoPtr_get_layoutPriority_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00003F0C File Offset: 0x0000210C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269621, XrefRangeEnd = 1269660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CalculateLayoutInputHorizontal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NestedScrollRect.NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00003F48 File Offset: 0x00002148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269660, XrefRangeEnd = 1269699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CalculateLayoutInputVertical()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NestedScrollRect.NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00003F84 File Offset: 0x00002184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269699, XrefRangeEnd = 1269700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NestedScrollRect()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NestedScrollRect>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NestedScrollRect.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002186 File Offset: 0x00000386
		public NestedScrollRect(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000063 RID: 99 RVA: 0x00003FC0 File Offset: 0x000021C0
		// (set) Token: 0x06000064 RID: 100 RVA: 0x0000218F File Offset: 0x0000038F
		public unsafe bool m_NestedDragActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NestedScrollRect.NativeFieldInfoPtr_m_NestedDragActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NestedScrollRect.NativeFieldInfoPtr_m_NestedDragActive)) = value;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00003FE8 File Offset: 0x000021E8
		// (set) Token: 0x06000066 RID: 102 RVA: 0x000021AA File Offset: 0x000003AA
		public unsafe bool _routeToParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NestedScrollRect.NativeFieldInfoPtr__routeToParent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NestedScrollRect.NativeFieldInfoPtr__routeToParent)) = value;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000067 RID: 103 RVA: 0x00004010 File Offset: 0x00002210
		// (set) Token: 0x06000068 RID: 104 RVA: 0x000021C5 File Offset: 0x000003C5
		public unsafe float _MinWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NestedScrollRect.NativeFieldInfoPtr__MinWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NestedScrollRect.NativeFieldInfoPtr__MinWidth)) = value;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000069 RID: 105 RVA: 0x00004038 File Offset: 0x00002238
		// (set) Token: 0x0600006A RID: 106 RVA: 0x000021E0 File Offset: 0x000003E0
		public unsafe float _MinHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NestedScrollRect.NativeFieldInfoPtr__MinHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NestedScrollRect.NativeFieldInfoPtr__MinHeight)) = value;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600006B RID: 107 RVA: 0x00004060 File Offset: 0x00002260
		// (set) Token: 0x0600006C RID: 108 RVA: 0x000021FB File Offset: 0x000003FB
		public unsafe float _PreferredWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NestedScrollRect.NativeFieldInfoPtr__PreferredWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NestedScrollRect.NativeFieldInfoPtr__PreferredWidth)) = value;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600006D RID: 109 RVA: 0x00004088 File Offset: 0x00002288
		// (set) Token: 0x0600006E RID: 110 RVA: 0x00002216 File Offset: 0x00000416
		public unsafe float _PreferredHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NestedScrollRect.NativeFieldInfoPtr__PreferredHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NestedScrollRect.NativeFieldInfoPtr__PreferredHeight)) = value;
			}
		}

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeFieldInfoPtr_m_NestedDragActive;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeFieldInfoPtr__routeToParent;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeFieldInfoPtr__MinWidth;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeFieldInfoPtr__MinHeight;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeFieldInfoPtr__PreferredWidth;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeFieldInfoPtr__PreferredHeight;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeMethodInfoPtr_get_nestedDragActive_Public_get_Boolean_0;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeMethodInfoPtr_set_nestedDragActive_Public_set_Void_Boolean_0;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeMethodInfoPtr_OnInitializePotentialDrag_Public_Virtual_Void_PointerEventData_0;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeMethodInfoPtr_OnDrag_Public_Virtual_Void_PointerEventData_0;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeMethodInfoPtr_OnBeginDrag_Public_Virtual_Void_PointerEventData_0;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeMethodInfoPtr_OnEndDrag_Public_Virtual_Void_PointerEventData_0;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeMethodInfoPtr_get_preferredWidth_Public_Virtual_get_Single_0;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeMethodInfoPtr_get_preferredHeight_Public_Virtual_get_Single_0;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeMethodInfoPtr_get_minWidth_Public_Virtual_get_Single_0;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeMethodInfoPtr_get_minHeight_Public_Virtual_get_Single_0;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeMethodInfoPtr_get_layoutPriority_Public_Virtual_get_Int32_0;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_Void_0;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_Void_0;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200000A RID: 10
		[ObfuscatedName("Kyub.UI.NestedScrollRect+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600009C RID: 156 RVA: 0x00004898 File Offset: 0x00002A98
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<NestedScrollRect.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NestedScrollRect>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NestedScrollRect.__c>.NativeClassPtr);
				NestedScrollRect.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NestedScrollRect.__c>.NativeClassPtr, "<>9");
				NestedScrollRect.__c.NativeFieldInfoPtr___9__23_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NestedScrollRect.__c>.NativeClassPtr, "<>9__23_0");
				NestedScrollRect.__c.NativeFieldInfoPtr___9__23_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NestedScrollRect.__c>.NativeClassPtr, "<>9__23_1");
				NestedScrollRect.__c.NativeFieldInfoPtr___9__24_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NestedScrollRect.__c>.NativeClassPtr, "<>9__24_0");
				NestedScrollRect.__c.NativeFieldInfoPtr___9__24_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NestedScrollRect.__c>.NativeClassPtr, "<>9__24_1");
				NestedScrollRect.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NestedScrollRect.__c>.NativeClassPtr, 100663378);
				NestedScrollRect.__c.NativeMethodInfoPtr__CalculateLayoutInputHorizontal_b__23_0_Internal_Single_ILayoutElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NestedScrollRect.__c>.NativeClassPtr, 100663379);
				NestedScrollRect.__c.NativeMethodInfoPtr__CalculateLayoutInputHorizontal_b__23_1_Internal_Single_ILayoutElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NestedScrollRect.__c>.NativeClassPtr, 100663380);
				NestedScrollRect.__c.NativeMethodInfoPtr__CalculateLayoutInputVertical_b__24_0_Internal_Single_ILayoutElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NestedScrollRect.__c>.NativeClassPtr, 100663381);
				NestedScrollRect.__c.NativeMethodInfoPtr__CalculateLayoutInputVertical_b__24_1_Internal_Single_ILayoutElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NestedScrollRect.__c>.NativeClassPtr, 100663382);
			}

			// Token: 0x0600009D RID: 157 RVA: 0x0000498C File Offset: 0x00002B8C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NestedScrollRect.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NestedScrollRect.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600009E RID: 158 RVA: 0x000049C8 File Offset: 0x00002BC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269534, XrefRangeEnd = 1269538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _CalculateLayoutInputHorizontal_b__23_0(ILayoutElement e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NestedScrollRect.__c.NativeMethodInfoPtr__CalculateLayoutInputHorizontal_b__23_0_Internal_Single_ILayoutElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600009F RID: 159 RVA: 0x00004A18 File Offset: 0x00002C18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269538, XrefRangeEnd = 1269542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _CalculateLayoutInputHorizontal_b__23_1(ILayoutElement e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NestedScrollRect.__c.NativeMethodInfoPtr__CalculateLayoutInputHorizontal_b__23_1_Internal_Single_ILayoutElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060000A0 RID: 160 RVA: 0x00004A68 File Offset: 0x00002C68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269542, XrefRangeEnd = 1269546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _CalculateLayoutInputVertical_b__24_0(ILayoutElement e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NestedScrollRect.__c.NativeMethodInfoPtr__CalculateLayoutInputVertical_b__24_0_Internal_Single_ILayoutElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060000A1 RID: 161 RVA: 0x00004AB8 File Offset: 0x00002CB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269546, XrefRangeEnd = 1269557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _CalculateLayoutInputVertical_b__24_1(ILayoutElement e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NestedScrollRect.__c.NativeMethodInfoPtr__CalculateLayoutInputVertical_b__24_1_Internal_Single_ILayoutElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060000A2 RID: 162 RVA: 0x000023AF File Offset: 0x000005AF
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000036 RID: 54
			// (get) Token: 0x060000A3 RID: 163 RVA: 0x00004B08 File Offset: 0x00002D08
			// (set) Token: 0x060000A4 RID: 164 RVA: 0x000023B8 File Offset: 0x000005B8
			public unsafe static NestedScrollRect.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NestedScrollRect.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NestedScrollRect.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NestedScrollRect.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000037 RID: 55
			// (get) Token: 0x060000A5 RID: 165 RVA: 0x00004B30 File Offset: 0x00002D30
			// (set) Token: 0x060000A6 RID: 166 RVA: 0x000023CA File Offset: 0x000005CA
			public unsafe static Func<ILayoutElement, float> __9__23_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NestedScrollRect.__c.NativeFieldInfoPtr___9__23_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ILayoutElement, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NestedScrollRect.__c.NativeFieldInfoPtr___9__23_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000038 RID: 56
			// (get) Token: 0x060000A7 RID: 167 RVA: 0x00004B58 File Offset: 0x00002D58
			// (set) Token: 0x060000A8 RID: 168 RVA: 0x000023DC File Offset: 0x000005DC
			public unsafe static Func<ILayoutElement, float> __9__23_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NestedScrollRect.__c.NativeFieldInfoPtr___9__23_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ILayoutElement, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NestedScrollRect.__c.NativeFieldInfoPtr___9__23_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000039 RID: 57
			// (get) Token: 0x060000A9 RID: 169 RVA: 0x00004B80 File Offset: 0x00002D80
			// (set) Token: 0x060000AA RID: 170 RVA: 0x000023EE File Offset: 0x000005EE
			public unsafe static Func<ILayoutElement, float> __9__24_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NestedScrollRect.__c.NativeFieldInfoPtr___9__24_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ILayoutElement, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NestedScrollRect.__c.NativeFieldInfoPtr___9__24_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700003A RID: 58
			// (get) Token: 0x060000AB RID: 171 RVA: 0x00004BA8 File Offset: 0x00002DA8
			// (set) Token: 0x060000AC RID: 172 RVA: 0x00002400 File Offset: 0x00000600
			public unsafe static Func<ILayoutElement, float> __9__24_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NestedScrollRect.__c.NativeFieldInfoPtr___9__24_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ILayoutElement, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NestedScrollRect.__c.NativeFieldInfoPtr___9__24_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400006E RID: 110
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400006F RID: 111
			private static readonly IntPtr NativeFieldInfoPtr___9__23_0;

			// Token: 0x04000070 RID: 112
			private static readonly IntPtr NativeFieldInfoPtr___9__23_1;

			// Token: 0x04000071 RID: 113
			private static readonly IntPtr NativeFieldInfoPtr___9__24_0;

			// Token: 0x04000072 RID: 114
			private static readonly IntPtr NativeFieldInfoPtr___9__24_1;

			// Token: 0x04000073 RID: 115
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000074 RID: 116
			private static readonly IntPtr NativeMethodInfoPtr__CalculateLayoutInputHorizontal_b__23_0_Internal_Single_ILayoutElement_0;

			// Token: 0x04000075 RID: 117
			private static readonly IntPtr NativeMethodInfoPtr__CalculateLayoutInputHorizontal_b__23_1_Internal_Single_ILayoutElement_0;

			// Token: 0x04000076 RID: 118
			private static readonly IntPtr NativeMethodInfoPtr__CalculateLayoutInputVertical_b__24_0_Internal_Single_ILayoutElement_0;

			// Token: 0x04000077 RID: 119
			private static readonly IntPtr NativeMethodInfoPtr__CalculateLayoutInputVertical_b__24_1_Internal_Single_ILayoutElement_0;
		}
	}
}
