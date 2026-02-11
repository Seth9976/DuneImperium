using System;
using boardgames.match.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace boardgames.match.tooltips
{
	// Token: 0x0200024D RID: 589
	public class ObserverCountTooltipSource : VersionedView<ObserversProvider>
	{
		// Token: 0x06001ACE RID: 6862 RVA: 0x00074EF8 File Offset: 0x000730F8
		// Note: this type is marked as 'beforefieldinit'.
		static ObserverCountTooltipSource()
		{
			Il2CppClassPointerStore<ObserverCountTooltipSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.tooltips", "ObserverCountTooltipSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObserverCountTooltipSource>.NativeClassPtr);
			ObserverCountTooltipSource.NativeFieldInfoPtr_localizationKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObserverCountTooltipSource>.NativeClassPtr, "localizationKey");
			ObserverCountTooltipSource.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObserverCountTooltipSource>.NativeClassPtr, "count");
			ObserverCountTooltipSource.NativeMethodInfoPtr_start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserverCountTooltipSource>.NativeClassPtr, 100667578);
			ObserverCountTooltipSource.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserverCountTooltipSource>.NativeClassPtr, 100667579);
			ObserverCountTooltipSource.NativeMethodInfoPtr_GetLocalizedTooltip_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserverCountTooltipSource>.NativeClassPtr, 100667580);
			ObserverCountTooltipSource.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserverCountTooltipSource>.NativeClassPtr, 100667581);
		}

		// Token: 0x06001ACF RID: 6863 RVA: 0x00074FA0 File Offset: 0x000731A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 532706, XrefRangeEnd = 532709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObserverCountTooltipSource.NativeMethodInfoPtr_start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AD0 RID: 6864 RVA: 0x00074FDC File Offset: 0x000731DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 532709, XrefRangeEnd = 532710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObserverCountTooltipSource.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AD1 RID: 6865 RVA: 0x00075018 File Offset: 0x00073218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 532710, XrefRangeEnd = 532722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetLocalizedTooltip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObserverCountTooltipSource.NativeMethodInfoPtr_GetLocalizedTooltip_Public_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001AD2 RID: 6866 RVA: 0x00075050 File Offset: 0x00073250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 532722, XrefRangeEnd = 532729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObserverCountTooltipSource()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObserverCountTooltipSource>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObserverCountTooltipSource.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AD3 RID: 6867 RVA: 0x0000EA37 File Offset: 0x0000CC37
		public ObserverCountTooltipSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000723 RID: 1827
		// (get) Token: 0x06001AD4 RID: 6868 RVA: 0x0007508C File Offset: 0x0007328C
		// (set) Token: 0x06001AD5 RID: 6869 RVA: 0x0000EA40 File Offset: 0x0000CC40
		public unsafe string localizationKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserverCountTooltipSource.NativeFieldInfoPtr_localizationKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserverCountTooltipSource.NativeFieldInfoPtr_localizationKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000724 RID: 1828
		// (get) Token: 0x06001AD6 RID: 6870 RVA: 0x000750B4 File Offset: 0x000732B4
		// (set) Token: 0x06001AD7 RID: 6871 RVA: 0x0000EA5F File Offset: 0x0000CC5F
		public unsafe ulong count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserverCountTooltipSource.NativeFieldInfoPtr_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserverCountTooltipSource.NativeFieldInfoPtr_count)) = value;
			}
		}

		// Token: 0x040010BD RID: 4285
		private static readonly IntPtr NativeFieldInfoPtr_localizationKey;

		// Token: 0x040010BE RID: 4286
		private static readonly IntPtr NativeFieldInfoPtr_count;

		// Token: 0x040010BF RID: 4287
		private static readonly IntPtr NativeMethodInfoPtr_start_Protected_Virtual_Void_0;

		// Token: 0x040010C0 RID: 4288
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x040010C1 RID: 4289
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalizedTooltip_Public_Virtual_Final_New_String_0;

		// Token: 0x040010C2 RID: 4290
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
