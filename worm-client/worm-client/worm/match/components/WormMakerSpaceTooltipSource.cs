using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using voodoo;
using worm.match.data;

namespace worm.match.components
{
	// Token: 0x02000204 RID: 516
	public class WormMakerSpaceTooltipSource : VersionedDataComponentObserver<WormBonusSpiceData>
	{
		// Token: 0x060016D7 RID: 5847 RVA: 0x0005D61C File Offset: 0x0005B81C
		// Note: this type is marked as 'beforefieldinit'.
		static WormMakerSpaceTooltipSource()
		{
			Il2CppClassPointerStore<WormMakerSpaceTooltipSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormMakerSpaceTooltipSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormMakerSpaceTooltipSource>.NativeClassPtr);
			WormMakerSpaceTooltipSource.NativeFieldInfoPtr_locString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMakerSpaceTooltipSource>.NativeClassPtr, "locString");
			WormMakerSpaceTooltipSource.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMakerSpaceTooltipSource>.NativeClassPtr, 100666469);
			WormMakerSpaceTooltipSource.NativeMethodInfoPtr_GetLocalizedTooltip_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMakerSpaceTooltipSource>.NativeClassPtr, 100666470);
			WormMakerSpaceTooltipSource.NativeMethodInfoPtr_GetBonusSpice_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMakerSpaceTooltipSource>.NativeClassPtr, 100666471);
			WormMakerSpaceTooltipSource.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMakerSpaceTooltipSource>.NativeClassPtr, 100666472);
		}

		// Token: 0x060016D8 RID: 5848 RVA: 0x0005D6B0 File Offset: 0x0005B8B0
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void versionChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormMakerSpaceTooltipSource.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016D9 RID: 5849 RVA: 0x0005D6EC File Offset: 0x0005B8EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716927, XrefRangeEnd = 716940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetLocalizedTooltip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMakerSpaceTooltipSource.NativeMethodInfoPtr_GetLocalizedTooltip_Public_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060016DA RID: 5850 RVA: 0x0005D724 File Offset: 0x0005B924
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716940, XrefRangeEnd = 716942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetBonusSpice()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMakerSpaceTooltipSource.NativeMethodInfoPtr_GetBonusSpice_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060016DB RID: 5851 RVA: 0x0005D760 File Offset: 0x0005B960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716942, XrefRangeEnd = 716948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormMakerSpaceTooltipSource()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormMakerSpaceTooltipSource>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMakerSpaceTooltipSource.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016DC RID: 5852 RVA: 0x0000DB99 File Offset: 0x0000BD99
		public WormMakerSpaceTooltipSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x060016DD RID: 5853 RVA: 0x0005D79C File Offset: 0x0005B99C
		// (set) Token: 0x060016DE RID: 5854 RVA: 0x0000DBA2 File Offset: 0x0000BDA2
		public unsafe string locString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMakerSpaceTooltipSource.NativeFieldInfoPtr_locString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMakerSpaceTooltipSource.NativeFieldInfoPtr_locString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000D40 RID: 3392
		private static readonly IntPtr NativeFieldInfoPtr_locString;

		// Token: 0x04000D41 RID: 3393
		private static readonly IntPtr NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0;

		// Token: 0x04000D42 RID: 3394
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalizedTooltip_Public_Virtual_Final_New_String_0;

		// Token: 0x04000D43 RID: 3395
		private static readonly IntPtr NativeMethodInfoPtr_GetBonusSpice_Public_Int32_0;

		// Token: 0x04000D44 RID: 3396
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
