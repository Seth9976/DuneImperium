using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Unity.Profiling;

namespace UnityEngine.UIElements
{
	// Token: 0x0200016A RID: 362
	public class UIRLayoutUpdater : BaseVisualTreeUpdater
	{
		// Token: 0x06001AD5 RID: 6869 RVA: 0x0007BD40 File Offset: 0x00079F40
		// Note: this type is marked as 'beforefieldinit'.
		static UIRLayoutUpdater()
		{
			Il2CppClassPointerStore<UIRLayoutUpdater>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "UIRLayoutUpdater");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIRLayoutUpdater>.NativeClassPtr);
			UIRLayoutUpdater.NativeFieldInfoPtr_s_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRLayoutUpdater>.NativeClassPtr, "s_Description");
			UIRLayoutUpdater.NativeFieldInfoPtr_s_ProfilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRLayoutUpdater>.NativeClassPtr, "s_ProfilerMarker");
			UIRLayoutUpdater.NativeFieldInfoPtr_changeEventsList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRLayoutUpdater>.NativeClassPtr, "changeEventsList");
			UIRLayoutUpdater.NativeMethodInfoPtr_get_profilerMarker_Public_Virtual_get_ProfilerMarker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRLayoutUpdater>.NativeClassPtr, 100667222);
			UIRLayoutUpdater.NativeMethodInfoPtr_OnVersionChanged_Public_Virtual_Void_VisualElement_VersionChangeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRLayoutUpdater>.NativeClassPtr, 100667223);
			UIRLayoutUpdater.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRLayoutUpdater>.NativeClassPtr, 100667224);
			UIRLayoutUpdater.NativeMethodInfoPtr_UpdateSubTree_Private_Void_VisualElement_Boolean_List_1_KeyValuePair_2_Rect_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRLayoutUpdater>.NativeClassPtr, 100667225);
			UIRLayoutUpdater.NativeMethodInfoPtr_DispatchChangeEvents_Private_Void_List_1_KeyValuePair_2_Rect_VisualElement_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRLayoutUpdater>.NativeClassPtr, 100667226);
			UIRLayoutUpdater.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRLayoutUpdater>.NativeClassPtr, 100667227);
		}

		// Token: 0x17000828 RID: 2088
		// (get) Token: 0x06001AD6 RID: 6870 RVA: 0x0007BE24 File Offset: 0x0007A024
		public unsafe override ProfilerMarker profilerMarker
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322460, XrefRangeEnd = 322464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIRLayoutUpdater.NativeMethodInfoPtr_get_profilerMarker_Public_Virtual_get_ProfilerMarker_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AD7 RID: 6871 RVA: 0x0007BE6C File Offset: 0x0007A06C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322464, XrefRangeEnd = 322465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref versionChangeType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIRLayoutUpdater.NativeMethodInfoPtr_OnVersionChanged_Public_Virtual_Void_VisualElement_VersionChangeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AD8 RID: 6872 RVA: 0x0007BEC8 File Offset: 0x0007A0C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322465, XrefRangeEnd = 322500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIRLayoutUpdater.NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AD9 RID: 6873 RVA: 0x0007BF04 File Offset: 0x0007A104
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 322546, RefRangeEnd = 322548, XrefRangeStart = 322500, XrefRangeEnd = 322546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSubTree(VisualElement ve, bool isDisplayed, List<KeyValuePair<Rect, VisualElement>> changeEvents)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isDisplayed;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(changeEvents);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRLayoutUpdater.NativeMethodInfoPtr_UpdateSubTree_Private_Void_VisualElement_Boolean_List_1_KeyValuePair_2_Rect_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001ADA RID: 6874 RVA: 0x0007BF68 File Offset: 0x0007A168
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 322576, RefRangeEnd = 322577, XrefRangeStart = 322548, XrefRangeEnd = 322576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DispatchChangeEvents(List<KeyValuePair<Rect, VisualElement>> changeEvents, int currentLayoutPass)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(changeEvents);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentLayoutPass;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRLayoutUpdater.NativeMethodInfoPtr_DispatchChangeEvents_Private_Void_List_1_KeyValuePair_2_Rect_VisualElement_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001ADB RID: 6875 RVA: 0x0007BFB8 File Offset: 0x0007A1B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322577, XrefRangeEnd = 322585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIRLayoutUpdater()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIRLayoutUpdater>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRLayoutUpdater.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001ADC RID: 6876 RVA: 0x0000C331 File Offset: 0x0000A531
		public UIRLayoutUpdater(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000825 RID: 2085
		// (get) Token: 0x06001ADD RID: 6877 RVA: 0x0007BFF4 File Offset: 0x0007A1F4
		// (set) Token: 0x06001ADE RID: 6878 RVA: 0x0000C33A File Offset: 0x0000A53A
		public unsafe static string s_Description
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UIRLayoutUpdater.NativeFieldInfoPtr_s_Description, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIRLayoutUpdater.NativeFieldInfoPtr_s_Description, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000826 RID: 2086
		// (get) Token: 0x06001ADF RID: 6879 RVA: 0x0007C014 File Offset: 0x0007A214
		// (set) Token: 0x06001AE0 RID: 6880 RVA: 0x0000C34C File Offset: 0x0000A54C
		public unsafe static ProfilerMarker s_ProfilerMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(UIRLayoutUpdater.NativeFieldInfoPtr_s_ProfilerMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIRLayoutUpdater.NativeFieldInfoPtr_s_ProfilerMarker, (void*)(&value));
			}
		}

		// Token: 0x17000827 RID: 2087
		// (get) Token: 0x06001AE1 RID: 6881 RVA: 0x0007C030 File Offset: 0x0007A230
		// (set) Token: 0x06001AE2 RID: 6882 RVA: 0x0000C35A File Offset: 0x0000A55A
		public unsafe List<KeyValuePair<Rect, VisualElement>> changeEventsList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRLayoutUpdater.NativeFieldInfoPtr_changeEventsList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<KeyValuePair<Rect, VisualElement>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRLayoutUpdater.NativeFieldInfoPtr_changeEventsList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400128D RID: 4749
		private static readonly IntPtr NativeFieldInfoPtr_s_Description;

		// Token: 0x0400128E RID: 4750
		private static readonly IntPtr NativeFieldInfoPtr_s_ProfilerMarker;

		// Token: 0x0400128F RID: 4751
		private static readonly IntPtr NativeFieldInfoPtr_changeEventsList;

		// Token: 0x04001290 RID: 4752
		private static readonly IntPtr NativeMethodInfoPtr_get_profilerMarker_Public_Virtual_get_ProfilerMarker_0;

		// Token: 0x04001291 RID: 4753
		private static readonly IntPtr NativeMethodInfoPtr_OnVersionChanged_Public_Virtual_Void_VisualElement_VersionChangeType_0;

		// Token: 0x04001292 RID: 4754
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;

		// Token: 0x04001293 RID: 4755
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSubTree_Private_Void_VisualElement_Boolean_List_1_KeyValuePair_2_Rect_VisualElement_0;

		// Token: 0x04001294 RID: 4756
		private static readonly IntPtr NativeMethodInfoPtr_DispatchChangeEvents_Private_Void_List_1_KeyValuePair_2_Rect_VisualElement_Int32_0;

		// Token: 0x04001295 RID: 4757
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001296 RID: 4758
		public const int kMaxValidateLayoutCount = 10;
	}
}
