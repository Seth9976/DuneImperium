using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Unity.Profiling;

namespace UnityEngine.UIElements
{
	// Token: 0x02000235 RID: 565
	public class VisualTreeHierarchyFlagsUpdater : BaseVisualTreeUpdater
	{
		// Token: 0x060029CD RID: 10701 RVA: 0x000B67E8 File Offset: 0x000B49E8
		// Note: this type is marked as 'beforefieldinit'.
		static VisualTreeHierarchyFlagsUpdater()
		{
			Il2CppClassPointerStore<VisualTreeHierarchyFlagsUpdater>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "VisualTreeHierarchyFlagsUpdater");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisualTreeHierarchyFlagsUpdater>.NativeClassPtr);
			VisualTreeHierarchyFlagsUpdater.NativeFieldInfoPtr_m_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeHierarchyFlagsUpdater>.NativeClassPtr, "m_Version");
			VisualTreeHierarchyFlagsUpdater.NativeFieldInfoPtr_m_LastVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeHierarchyFlagsUpdater>.NativeClassPtr, "m_LastVersion");
			VisualTreeHierarchyFlagsUpdater.NativeFieldInfoPtr_s_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeHierarchyFlagsUpdater>.NativeClassPtr, "s_Description");
			VisualTreeHierarchyFlagsUpdater.NativeFieldInfoPtr_s_ProfilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeHierarchyFlagsUpdater>.NativeClassPtr, "s_ProfilerMarker");
			VisualTreeHierarchyFlagsUpdater.NativeMethodInfoPtr_get_profilerMarker_Public_Virtual_get_ProfilerMarker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeHierarchyFlagsUpdater>.NativeClassPtr, 100669565);
			VisualTreeHierarchyFlagsUpdater.NativeMethodInfoPtr_OnVersionChanged_Public_Virtual_Void_VisualElement_VersionChangeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeHierarchyFlagsUpdater>.NativeClassPtr, 100669566);
			VisualTreeHierarchyFlagsUpdater.NativeMethodInfoPtr_DirtyHierarchy_Private_Static_Void_VisualElement_VisualElementFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeHierarchyFlagsUpdater>.NativeClassPtr, 100669567);
			VisualTreeHierarchyFlagsUpdater.NativeMethodInfoPtr_DirtyBoundingBoxHierarchy_Private_Static_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeHierarchyFlagsUpdater>.NativeClassPtr, 100669568);
			VisualTreeHierarchyFlagsUpdater.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeHierarchyFlagsUpdater>.NativeClassPtr, 100669569);
			VisualTreeHierarchyFlagsUpdater.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeHierarchyFlagsUpdater>.NativeClassPtr, 100669570);
		}

		// Token: 0x17000D0A RID: 3338
		// (get) Token: 0x060029CE RID: 10702 RVA: 0x000B68E0 File Offset: 0x000B4AE0
		public unsafe override ProfilerMarker profilerMarker
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346907, XrefRangeEnd = 346911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VisualTreeHierarchyFlagsUpdater.NativeMethodInfoPtr_get_profilerMarker_Public_Virtual_get_ProfilerMarker_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060029CF RID: 10703 RVA: 0x000B6928 File Offset: 0x000B4B28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346911, XrefRangeEnd = 346921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VisualTreeHierarchyFlagsUpdater.NativeMethodInfoPtr_OnVersionChanged_Public_Virtual_Void_VisualElement_VersionChangeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029D0 RID: 10704 RVA: 0x000B6984 File Offset: 0x000B4B84
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 346927, RefRangeEnd = 346929, XrefRangeStart = 346921, XrefRangeEnd = 346927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DirtyHierarchy(VisualElement ve, VisualElementFlags mustDirtyFlags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mustDirtyFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeHierarchyFlagsUpdater.NativeMethodInfoPtr_DirtyHierarchy_Private_Static_Void_VisualElement_VisualElementFlags_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029D1 RID: 10705 RVA: 0x000B69C8 File Offset: 0x000B4BC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346929, XrefRangeEnd = 346934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DirtyBoundingBoxHierarchy(VisualElement ve)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeHierarchyFlagsUpdater.NativeMethodInfoPtr_DirtyBoundingBoxHierarchy_Private_Static_Void_VisualElement_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060029D2 RID: 10706 RVA: 0x000B6A00 File Offset: 0x000B4C00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346934, XrefRangeEnd = 346936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VisualTreeHierarchyFlagsUpdater.NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029D3 RID: 10707 RVA: 0x000B6A3C File Offset: 0x000B4C3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346936, XrefRangeEnd = 346937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VisualTreeHierarchyFlagsUpdater()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisualTreeHierarchyFlagsUpdater>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeHierarchyFlagsUpdater.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029D4 RID: 10708 RVA: 0x00010D17 File Offset: 0x0000EF17
		public VisualTreeHierarchyFlagsUpdater(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D06 RID: 3334
		// (get) Token: 0x060029D5 RID: 10709 RVA: 0x000B6A78 File Offset: 0x000B4C78
		// (set) Token: 0x060029D6 RID: 10710 RVA: 0x00010D20 File Offset: 0x0000EF20
		public unsafe uint m_Version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeHierarchyFlagsUpdater.NativeFieldInfoPtr_m_Version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeHierarchyFlagsUpdater.NativeFieldInfoPtr_m_Version)) = value;
			}
		}

		// Token: 0x17000D07 RID: 3335
		// (get) Token: 0x060029D7 RID: 10711 RVA: 0x000B6AA0 File Offset: 0x000B4CA0
		// (set) Token: 0x060029D8 RID: 10712 RVA: 0x00010D3B File Offset: 0x0000EF3B
		public unsafe uint m_LastVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeHierarchyFlagsUpdater.NativeFieldInfoPtr_m_LastVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeHierarchyFlagsUpdater.NativeFieldInfoPtr_m_LastVersion)) = value;
			}
		}

		// Token: 0x17000D08 RID: 3336
		// (get) Token: 0x060029D9 RID: 10713 RVA: 0x000B6AC8 File Offset: 0x000B4CC8
		// (set) Token: 0x060029DA RID: 10714 RVA: 0x00010D56 File Offset: 0x0000EF56
		public unsafe static string s_Description
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(VisualTreeHierarchyFlagsUpdater.NativeFieldInfoPtr_s_Description, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VisualTreeHierarchyFlagsUpdater.NativeFieldInfoPtr_s_Description, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D09 RID: 3337
		// (get) Token: 0x060029DB RID: 10715 RVA: 0x000B6AE8 File Offset: 0x000B4CE8
		// (set) Token: 0x060029DC RID: 10716 RVA: 0x00010D68 File Offset: 0x0000EF68
		public unsafe static ProfilerMarker s_ProfilerMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(VisualTreeHierarchyFlagsUpdater.NativeFieldInfoPtr_s_ProfilerMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VisualTreeHierarchyFlagsUpdater.NativeFieldInfoPtr_s_ProfilerMarker, (void*)(&value));
			}
		}

		// Token: 0x04001DBD RID: 7613
		private static readonly IntPtr NativeFieldInfoPtr_m_Version;

		// Token: 0x04001DBE RID: 7614
		private static readonly IntPtr NativeFieldInfoPtr_m_LastVersion;

		// Token: 0x04001DBF RID: 7615
		private static readonly IntPtr NativeFieldInfoPtr_s_Description;

		// Token: 0x04001DC0 RID: 7616
		private static readonly IntPtr NativeFieldInfoPtr_s_ProfilerMarker;

		// Token: 0x04001DC1 RID: 7617
		private static readonly IntPtr NativeMethodInfoPtr_get_profilerMarker_Public_Virtual_get_ProfilerMarker_0;

		// Token: 0x04001DC2 RID: 7618
		private static readonly IntPtr NativeMethodInfoPtr_OnVersionChanged_Public_Virtual_Void_VisualElement_VersionChangeType_0;

		// Token: 0x04001DC3 RID: 7619
		private static readonly IntPtr NativeMethodInfoPtr_DirtyHierarchy_Private_Static_Void_VisualElement_VisualElementFlags_0;

		// Token: 0x04001DC4 RID: 7620
		private static readonly IntPtr NativeMethodInfoPtr_DirtyBoundingBoxHierarchy_Private_Static_Void_VisualElement_0;

		// Token: 0x04001DC5 RID: 7621
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;

		// Token: 0x04001DC6 RID: 7622
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
