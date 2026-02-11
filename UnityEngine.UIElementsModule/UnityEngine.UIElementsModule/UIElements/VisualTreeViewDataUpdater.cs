using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Unity.Profiling;

namespace UnityEngine.UIElements
{
	// Token: 0x02000240 RID: 576
	public class VisualTreeViewDataUpdater : BaseVisualTreeUpdater
	{
		// Token: 0x06002A73 RID: 10867 RVA: 0x000B8C70 File Offset: 0x000B6E70
		// Note: this type is marked as 'beforefieldinit'.
		static VisualTreeViewDataUpdater()
		{
			Il2CppClassPointerStore<VisualTreeViewDataUpdater>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "VisualTreeViewDataUpdater");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisualTreeViewDataUpdater>.NativeClassPtr);
			VisualTreeViewDataUpdater.NativeFieldInfoPtr_m_UpdateList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeViewDataUpdater>.NativeClassPtr, "m_UpdateList");
			VisualTreeViewDataUpdater.NativeFieldInfoPtr_m_ParentList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeViewDataUpdater>.NativeClassPtr, "m_ParentList");
			VisualTreeViewDataUpdater.NativeFieldInfoPtr_m_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeViewDataUpdater>.NativeClassPtr, "m_Version");
			VisualTreeViewDataUpdater.NativeFieldInfoPtr_m_LastVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeViewDataUpdater>.NativeClassPtr, "m_LastVersion");
			VisualTreeViewDataUpdater.NativeFieldInfoPtr_s_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeViewDataUpdater>.NativeClassPtr, "s_Description");
			VisualTreeViewDataUpdater.NativeFieldInfoPtr_s_ProfilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeViewDataUpdater>.NativeClassPtr, "s_ProfilerMarker");
			VisualTreeViewDataUpdater.NativeMethodInfoPtr_get_profilerMarker_Public_Virtual_get_ProfilerMarker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeViewDataUpdater>.NativeClassPtr, 100669645);
			VisualTreeViewDataUpdater.NativeMethodInfoPtr_OnVersionChanged_Public_Virtual_Void_VisualElement_VersionChangeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeViewDataUpdater>.NativeClassPtr, 100669646);
			VisualTreeViewDataUpdater.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeViewDataUpdater>.NativeClassPtr, 100669647);
			VisualTreeViewDataUpdater.NativeMethodInfoPtr_ValidateViewDataOnSubTree_Private_Void_VisualElement_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeViewDataUpdater>.NativeClassPtr, 100669648);
			VisualTreeViewDataUpdater.NativeMethodInfoPtr_PropagateToParents_Private_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeViewDataUpdater>.NativeClassPtr, 100669649);
			VisualTreeViewDataUpdater.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeViewDataUpdater>.NativeClassPtr, 100669650);
		}

		// Token: 0x17000D3C RID: 3388
		// (get) Token: 0x06002A74 RID: 10868 RVA: 0x000B8D90 File Offset: 0x000B6F90
		public unsafe override ProfilerMarker profilerMarker
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347698, XrefRangeEnd = 347702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VisualTreeViewDataUpdater.NativeMethodInfoPtr_get_profilerMarker_Public_Virtual_get_ProfilerMarker_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002A75 RID: 10869 RVA: 0x000B8DD8 File Offset: 0x000B6FD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347702, XrefRangeEnd = 347710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VisualTreeViewDataUpdater.NativeMethodInfoPtr_OnVersionChanged_Public_Virtual_Void_VisualElement_VersionChangeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A76 RID: 10870 RVA: 0x000B8E34 File Offset: 0x000B7034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347710, XrefRangeEnd = 347724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VisualTreeViewDataUpdater.NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A77 RID: 10871 RVA: 0x000B8E70 File Offset: 0x000B7070
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 347739, RefRangeEnd = 347741, XrefRangeStart = 347724, XrefRangeEnd = 347739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateViewDataOnSubTree(VisualElement ve, bool enablePersistence)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enablePersistence;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeViewDataUpdater.NativeMethodInfoPtr_ValidateViewDataOnSubTree_Private_Void_VisualElement_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A78 RID: 10872 RVA: 0x000B8EC0 File Offset: 0x000B70C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347741, XrefRangeEnd = 347746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PropagateToParents(VisualElement ve)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeViewDataUpdater.NativeMethodInfoPtr_PropagateToParents_Private_Void_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A79 RID: 10873 RVA: 0x000B8F04 File Offset: 0x000B7104
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347746, XrefRangeEnd = 347759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VisualTreeViewDataUpdater()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisualTreeViewDataUpdater>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeViewDataUpdater.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A7A RID: 10874 RVA: 0x000111AD File Offset: 0x0000F3AD
		public VisualTreeViewDataUpdater(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D36 RID: 3382
		// (get) Token: 0x06002A7B RID: 10875 RVA: 0x000B8F40 File Offset: 0x000B7140
		// (set) Token: 0x06002A7C RID: 10876 RVA: 0x000111B6 File Offset: 0x0000F3B6
		public unsafe HashSet<VisualElement> m_UpdateList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeViewDataUpdater.NativeFieldInfoPtr_m_UpdateList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<VisualElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeViewDataUpdater.NativeFieldInfoPtr_m_UpdateList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D37 RID: 3383
		// (get) Token: 0x06002A7D RID: 10877 RVA: 0x000B8F70 File Offset: 0x000B7170
		// (set) Token: 0x06002A7E RID: 10878 RVA: 0x000111D5 File Offset: 0x0000F3D5
		public unsafe HashSet<VisualElement> m_ParentList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeViewDataUpdater.NativeFieldInfoPtr_m_ParentList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<VisualElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeViewDataUpdater.NativeFieldInfoPtr_m_ParentList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D38 RID: 3384
		// (get) Token: 0x06002A7F RID: 10879 RVA: 0x000B8FA0 File Offset: 0x000B71A0
		// (set) Token: 0x06002A80 RID: 10880 RVA: 0x000111F4 File Offset: 0x0000F3F4
		public unsafe uint m_Version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeViewDataUpdater.NativeFieldInfoPtr_m_Version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeViewDataUpdater.NativeFieldInfoPtr_m_Version)) = value;
			}
		}

		// Token: 0x17000D39 RID: 3385
		// (get) Token: 0x06002A81 RID: 10881 RVA: 0x000B8FC8 File Offset: 0x000B71C8
		// (set) Token: 0x06002A82 RID: 10882 RVA: 0x0001120F File Offset: 0x0000F40F
		public unsafe uint m_LastVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeViewDataUpdater.NativeFieldInfoPtr_m_LastVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeViewDataUpdater.NativeFieldInfoPtr_m_LastVersion)) = value;
			}
		}

		// Token: 0x17000D3A RID: 3386
		// (get) Token: 0x06002A83 RID: 10883 RVA: 0x000B8FF0 File Offset: 0x000B71F0
		// (set) Token: 0x06002A84 RID: 10884 RVA: 0x0001122A File Offset: 0x0000F42A
		public unsafe static string s_Description
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(VisualTreeViewDataUpdater.NativeFieldInfoPtr_s_Description, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VisualTreeViewDataUpdater.NativeFieldInfoPtr_s_Description, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D3B RID: 3387
		// (get) Token: 0x06002A85 RID: 10885 RVA: 0x000B9010 File Offset: 0x000B7210
		// (set) Token: 0x06002A86 RID: 10886 RVA: 0x0001123C File Offset: 0x0000F43C
		public unsafe static ProfilerMarker s_ProfilerMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(VisualTreeViewDataUpdater.NativeFieldInfoPtr_s_ProfilerMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VisualTreeViewDataUpdater.NativeFieldInfoPtr_s_ProfilerMarker, (void*)(&value));
			}
		}

		// Token: 0x04001E34 RID: 7732
		private static readonly IntPtr NativeFieldInfoPtr_m_UpdateList;

		// Token: 0x04001E35 RID: 7733
		private static readonly IntPtr NativeFieldInfoPtr_m_ParentList;

		// Token: 0x04001E36 RID: 7734
		private static readonly IntPtr NativeFieldInfoPtr_m_Version;

		// Token: 0x04001E37 RID: 7735
		private static readonly IntPtr NativeFieldInfoPtr_m_LastVersion;

		// Token: 0x04001E38 RID: 7736
		private static readonly IntPtr NativeFieldInfoPtr_s_Description;

		// Token: 0x04001E39 RID: 7737
		private static readonly IntPtr NativeFieldInfoPtr_s_ProfilerMarker;

		// Token: 0x04001E3A RID: 7738
		private static readonly IntPtr NativeMethodInfoPtr_get_profilerMarker_Public_Virtual_get_ProfilerMarker_0;

		// Token: 0x04001E3B RID: 7739
		private static readonly IntPtr NativeMethodInfoPtr_OnVersionChanged_Public_Virtual_Void_VisualElement_VersionChangeType_0;

		// Token: 0x04001E3C RID: 7740
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;

		// Token: 0x04001E3D RID: 7741
		private static readonly IntPtr NativeMethodInfoPtr_ValidateViewDataOnSubTree_Private_Void_VisualElement_Boolean_0;

		// Token: 0x04001E3E RID: 7742
		private static readonly IntPtr NativeMethodInfoPtr_PropagateToParents_Private_Void_VisualElement_0;

		// Token: 0x04001E3F RID: 7743
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001E40 RID: 7744
		public const int kMaxValidatePersistentDataCount = 5;
	}
}
