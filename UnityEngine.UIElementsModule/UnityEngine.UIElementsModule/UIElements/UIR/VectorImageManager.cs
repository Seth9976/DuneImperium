using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Unity.Profiling;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x02000274 RID: 628
	public class VectorImageManager : Object
	{
		// Token: 0x06002E68 RID: 11880 RVA: 0x000C57D4 File Offset: 0x000C39D4
		// Note: this type is marked as 'beforefieldinit'.
		static VectorImageManager()
		{
			Il2CppClassPointerStore<VectorImageManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.UIR", "VectorImageManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VectorImageManager>.NativeClassPtr);
			VectorImageManager.NativeFieldInfoPtr_instances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VectorImageManager>.NativeClassPtr, "instances");
			VectorImageManager.NativeFieldInfoPtr_s_MarkerRegister = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VectorImageManager>.NativeClassPtr, "s_MarkerRegister");
			VectorImageManager.NativeFieldInfoPtr_s_MarkerUnregister = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VectorImageManager>.NativeClassPtr, "s_MarkerUnregister");
			VectorImageManager.NativeFieldInfoPtr_m_Atlas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VectorImageManager>.NativeClassPtr, "m_Atlas");
			VectorImageManager.NativeFieldInfoPtr_m_Registered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VectorImageManager>.NativeClassPtr, "m_Registered");
			VectorImageManager.NativeFieldInfoPtr_m_RenderInfoPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VectorImageManager>.NativeClassPtr, "m_RenderInfoPool");
			VectorImageManager.NativeFieldInfoPtr_m_GradientRemapPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VectorImageManager>.NativeClassPtr, "m_GradientRemapPool");
			VectorImageManager.NativeFieldInfoPtr_m_GradientSettingsAtlas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VectorImageManager>.NativeClassPtr, "m_GradientSettingsAtlas");
			VectorImageManager.NativeFieldInfoPtr_m_LoggedExhaustedSettingsAtlas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VectorImageManager>.NativeClassPtr, "m_LoggedExhaustedSettingsAtlas");
			VectorImageManager.NativeFieldInfoPtr__disposed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VectorImageManager>.NativeClassPtr, "<disposed>k__BackingField");
			VectorImageManager.NativeMethodInfoPtr_get_atlas_Public_get_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VectorImageManager>.NativeClassPtr, 100670043);
			VectorImageManager.NativeMethodInfoPtr__ctor_Public_Void_AtlasBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VectorImageManager>.NativeClassPtr, 100670044);
			VectorImageManager.NativeMethodInfoPtr_get_disposed_Protected_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VectorImageManager>.NativeClassPtr, 100670045);
			VectorImageManager.NativeMethodInfoPtr_set_disposed_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VectorImageManager>.NativeClassPtr, 100670046);
			VectorImageManager.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VectorImageManager>.NativeClassPtr, 100670047);
			VectorImageManager.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VectorImageManager>.NativeClassPtr, 100670048);
			VectorImageManager.NativeMethodInfoPtr_Commit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VectorImageManager>.NativeClassPtr, 100670049);
			VectorImageManager.NativeMethodInfoPtr_AddUser_Public_GradientRemap_VectorImage_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VectorImageManager>.NativeClassPtr, 100670050);
			VectorImageManager.NativeMethodInfoPtr_Register_Private_VectorImageRenderInfo_VectorImage_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VectorImageManager>.NativeClassPtr, 100670051);
		}

		// Token: 0x17000E90 RID: 3728
		// (get) Token: 0x06002E69 RID: 11881 RVA: 0x000C5980 File Offset: 0x000C3B80
		public unsafe Texture2D atlas
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 352092, RefRangeEnd = 352094, XrefRangeStart = 352091, XrefRangeEnd = 352092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VectorImageManager.NativeMethodInfoPtr_get_atlas_Public_get_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
			}
		}

		// Token: 0x06002E6A RID: 11882 RVA: 0x000C59C0 File Offset: 0x000C3BC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 352191, RefRangeEnd = 352192, XrefRangeStart = 352094, XrefRangeEnd = 352191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VectorImageManager(AtlasBase atlas)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VectorImageManager>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(atlas);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VectorImageManager.NativeMethodInfoPtr__ctor_Public_Void_AtlasBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000E91 RID: 3729
		// (get) Token: 0x06002E6B RID: 11883 RVA: 0x000C5A0C File Offset: 0x000C3C0C
		// (set) Token: 0x06002E6C RID: 11884 RVA: 0x000C5A48 File Offset: 0x000C3C48
		public unsafe bool disposed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VectorImageManager.NativeMethodInfoPtr_get_disposed_Protected_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VectorImageManager.NativeMethodInfoPtr_set_disposed_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002E6D RID: 11885 RVA: 0x000C5A88 File Offset: 0x000C3C88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 352196, RefRangeEnd = 352197, XrefRangeStart = 352192, XrefRangeEnd = 352196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VectorImageManager.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E6E RID: 11886 RVA: 0x000C5ABC File Offset: 0x000C3CBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352197, XrefRangeEnd = 352214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VectorImageManager.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002E6F RID: 11887 RVA: 0x000C5B08 File Offset: 0x000C3D08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 352216, RefRangeEnd = 352217, XrefRangeStart = 352214, XrefRangeEnd = 352216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Commit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VectorImageManager.NativeMethodInfoPtr_Commit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E70 RID: 11888 RVA: 0x000C5B3C File Offset: 0x000C3D3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352217, XrefRangeEnd = 352228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GradientRemap AddUser(VectorImage vi, VisualElement context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vi);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VectorImageManager.NativeMethodInfoPtr_AddUser_Public_GradientRemap_VectorImage_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GradientRemap>(intPtr3) : null;
		}

		// Token: 0x06002E71 RID: 11889 RVA: 0x000C5BA0 File Offset: 0x000C3DA0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 352264, RefRangeEnd = 352266, XrefRangeStart = 352228, XrefRangeEnd = 352264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VectorImageRenderInfo Register(VectorImage vi, VisualElement context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vi);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VectorImageManager.NativeMethodInfoPtr_Register_Private_VectorImageRenderInfo_VectorImage_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VectorImageRenderInfo>(intPtr3) : null;
		}

		// Token: 0x06002E72 RID: 11890 RVA: 0x0001326E File Offset: 0x0001146E
		public VectorImageManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000E86 RID: 3718
		// (get) Token: 0x06002E73 RID: 11891 RVA: 0x000C5C04 File Offset: 0x000C3E04
		// (set) Token: 0x06002E74 RID: 11892 RVA: 0x00013277 File Offset: 0x00011477
		public unsafe static List<VectorImageManager> instances
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(VectorImageManager.NativeFieldInfoPtr_instances, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VectorImageManager>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VectorImageManager.NativeFieldInfoPtr_instances, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E87 RID: 3719
		// (get) Token: 0x06002E75 RID: 11893 RVA: 0x000C5C2C File Offset: 0x000C3E2C
		// (set) Token: 0x06002E76 RID: 11894 RVA: 0x00013289 File Offset: 0x00011489
		public unsafe static ProfilerMarker s_MarkerRegister
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(VectorImageManager.NativeFieldInfoPtr_s_MarkerRegister, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VectorImageManager.NativeFieldInfoPtr_s_MarkerRegister, (void*)(&value));
			}
		}

		// Token: 0x17000E88 RID: 3720
		// (get) Token: 0x06002E77 RID: 11895 RVA: 0x000C5C48 File Offset: 0x000C3E48
		// (set) Token: 0x06002E78 RID: 11896 RVA: 0x00013297 File Offset: 0x00011497
		public unsafe static ProfilerMarker s_MarkerUnregister
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(VectorImageManager.NativeFieldInfoPtr_s_MarkerUnregister, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VectorImageManager.NativeFieldInfoPtr_s_MarkerUnregister, (void*)(&value));
			}
		}

		// Token: 0x17000E89 RID: 3721
		// (get) Token: 0x06002E79 RID: 11897 RVA: 0x000C5C64 File Offset: 0x000C3E64
		// (set) Token: 0x06002E7A RID: 11898 RVA: 0x000132A5 File Offset: 0x000114A5
		public unsafe AtlasBase m_Atlas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VectorImageManager.NativeFieldInfoPtr_m_Atlas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AtlasBase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VectorImageManager.NativeFieldInfoPtr_m_Atlas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E8A RID: 3722
		// (get) Token: 0x06002E7B RID: 11899 RVA: 0x000C5C94 File Offset: 0x000C3E94
		// (set) Token: 0x06002E7C RID: 11900 RVA: 0x000132C4 File Offset: 0x000114C4
		public unsafe Dictionary<VectorImage, VectorImageRenderInfo> m_Registered
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VectorImageManager.NativeFieldInfoPtr_m_Registered);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<VectorImage, VectorImageRenderInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VectorImageManager.NativeFieldInfoPtr_m_Registered), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E8B RID: 3723
		// (get) Token: 0x06002E7D RID: 11901 RVA: 0x000C5CC4 File Offset: 0x000C3EC4
		// (set) Token: 0x06002E7E RID: 11902 RVA: 0x000132E3 File Offset: 0x000114E3
		public unsafe VectorImageRenderInfoPool m_RenderInfoPool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VectorImageManager.NativeFieldInfoPtr_m_RenderInfoPool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VectorImageRenderInfoPool>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VectorImageManager.NativeFieldInfoPtr_m_RenderInfoPool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E8C RID: 3724
		// (get) Token: 0x06002E7F RID: 11903 RVA: 0x000C5CF4 File Offset: 0x000C3EF4
		// (set) Token: 0x06002E80 RID: 11904 RVA: 0x00013302 File Offset: 0x00011502
		public unsafe GradientRemapPool m_GradientRemapPool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VectorImageManager.NativeFieldInfoPtr_m_GradientRemapPool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GradientRemapPool>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VectorImageManager.NativeFieldInfoPtr_m_GradientRemapPool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E8D RID: 3725
		// (get) Token: 0x06002E81 RID: 11905 RVA: 0x000C5D24 File Offset: 0x000C3F24
		// (set) Token: 0x06002E82 RID: 11906 RVA: 0x00013321 File Offset: 0x00011521
		public unsafe GradientSettingsAtlas m_GradientSettingsAtlas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VectorImageManager.NativeFieldInfoPtr_m_GradientSettingsAtlas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GradientSettingsAtlas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VectorImageManager.NativeFieldInfoPtr_m_GradientSettingsAtlas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E8E RID: 3726
		// (get) Token: 0x06002E83 RID: 11907 RVA: 0x000C5D54 File Offset: 0x000C3F54
		// (set) Token: 0x06002E84 RID: 11908 RVA: 0x00013340 File Offset: 0x00011540
		public unsafe bool m_LoggedExhaustedSettingsAtlas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VectorImageManager.NativeFieldInfoPtr_m_LoggedExhaustedSettingsAtlas);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VectorImageManager.NativeFieldInfoPtr_m_LoggedExhaustedSettingsAtlas)) = value;
			}
		}

		// Token: 0x17000E8F RID: 3727
		// (get) Token: 0x06002E85 RID: 11909 RVA: 0x000C5D7C File Offset: 0x000C3F7C
		// (set) Token: 0x06002E86 RID: 11910 RVA: 0x0001335B File Offset: 0x0001155B
		public unsafe bool _disposed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VectorImageManager.NativeFieldInfoPtr__disposed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VectorImageManager.NativeFieldInfoPtr__disposed_k__BackingField)) = value;
			}
		}

		// Token: 0x06002E87 RID: 11911 RVA: 0x000C5DA4 File Offset: 0x000C3FA4
		public void Reset()
		{
			bool disposed = this.disposed;
			if (disposed)
			{
				DisposeHelper.NotifyDisposedUsed(this);
			}
			else
			{
				this.m_Registered.Clear();
				this.m_RenderInfoPool.Clear();
				this.m_GradientRemapPool.Clear();
				this.m_GradientSettingsAtlas.Reset();
			}
		}

		// Token: 0x06002E88 RID: 11912 RVA: 0x000C5DF8 File Offset: 0x000C3FF8
		public void RemoveUser(VectorImage vi)
		{
			bool disposed = this.disposed;
			if (disposed)
			{
				DisposeHelper.NotifyDisposedUsed(this);
			}
			else
			{
				bool flag = vi == null;
				if (!flag)
				{
					VectorImageRenderInfo vectorImageRenderInfo;
					bool flag2 = this.m_Registered.TryGetValue(vi, out vectorImageRenderInfo);
					if (flag2)
					{
						vectorImageRenderInfo.useCount--;
						bool flag3 = vectorImageRenderInfo.useCount == 0;
						if (flag3)
						{
							this.Unregister(vi, vectorImageRenderInfo);
						}
					}
				}
			}
		}

		// Token: 0x06002E89 RID: 11913 RVA: 0x00013376 File Offset: 0x00011576
		public void Unregister(VectorImage vi, VectorImageRenderInfo renderInfo)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0400215A RID: 8538
		private static readonly IntPtr NativeFieldInfoPtr_instances;

		// Token: 0x0400215B RID: 8539
		private static readonly IntPtr NativeFieldInfoPtr_s_MarkerRegister;

		// Token: 0x0400215C RID: 8540
		private static readonly IntPtr NativeFieldInfoPtr_s_MarkerUnregister;

		// Token: 0x0400215D RID: 8541
		private static readonly IntPtr NativeFieldInfoPtr_m_Atlas;

		// Token: 0x0400215E RID: 8542
		private static readonly IntPtr NativeFieldInfoPtr_m_Registered;

		// Token: 0x0400215F RID: 8543
		private static readonly IntPtr NativeFieldInfoPtr_m_RenderInfoPool;

		// Token: 0x04002160 RID: 8544
		private static readonly IntPtr NativeFieldInfoPtr_m_GradientRemapPool;

		// Token: 0x04002161 RID: 8545
		private static readonly IntPtr NativeFieldInfoPtr_m_GradientSettingsAtlas;

		// Token: 0x04002162 RID: 8546
		private static readonly IntPtr NativeFieldInfoPtr_m_LoggedExhaustedSettingsAtlas;

		// Token: 0x04002163 RID: 8547
		private static readonly IntPtr NativeFieldInfoPtr__disposed_k__BackingField;

		// Token: 0x04002164 RID: 8548
		private static readonly IntPtr NativeMethodInfoPtr_get_atlas_Public_get_Texture2D_0;

		// Token: 0x04002165 RID: 8549
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AtlasBase_0;

		// Token: 0x04002166 RID: 8550
		private static readonly IntPtr NativeMethodInfoPtr_get_disposed_Protected_get_Boolean_0;

		// Token: 0x04002167 RID: 8551
		private static readonly IntPtr NativeMethodInfoPtr_set_disposed_Private_set_Void_Boolean_0;

		// Token: 0x04002168 RID: 8552
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04002169 RID: 8553
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x0400216A RID: 8554
		private static readonly IntPtr NativeMethodInfoPtr_Commit_Public_Void_0;

		// Token: 0x0400216B RID: 8555
		private static readonly IntPtr NativeMethodInfoPtr_AddUser_Public_GradientRemap_VectorImage_VisualElement_0;

		// Token: 0x0400216C RID: 8556
		private static readonly IntPtr NativeMethodInfoPtr_Register_Private_VectorImageRenderInfo_VectorImage_VisualElement_0;
	}
}
