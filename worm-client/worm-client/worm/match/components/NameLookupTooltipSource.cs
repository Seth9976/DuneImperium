using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using voodoo;

namespace worm.match.components
{
	// Token: 0x020001B6 RID: 438
	public class NameLookupTooltipSource : VersionedDataComponentObserver<NameLookup>
	{
		// Token: 0x06001359 RID: 4953 RVA: 0x00052CE0 File Offset: 0x00050EE0
		// Note: this type is marked as 'beforefieldinit'.
		static NameLookupTooltipSource()
		{
			Il2CppClassPointerStore<NameLookupTooltipSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "NameLookupTooltipSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NameLookupTooltipSource>.NativeClassPtr);
			NameLookupTooltipSource.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameLookupTooltipSource>.NativeClassPtr, 100665945);
			NameLookupTooltipSource.NativeMethodInfoPtr_GetLocalizedTooltip_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameLookupTooltipSource>.NativeClassPtr, 100665946);
			NameLookupTooltipSource.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameLookupTooltipSource>.NativeClassPtr, 100665947);
		}

		// Token: 0x0600135A RID: 4954 RVA: 0x00052D4C File Offset: 0x00050F4C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void versionChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NameLookupTooltipSource.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600135B RID: 4955 RVA: 0x00052D88 File Offset: 0x00050F88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 712892, XrefRangeEnd = 712895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetLocalizedTooltip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameLookupTooltipSource.NativeMethodInfoPtr_GetLocalizedTooltip_Public_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600135C RID: 4956 RVA: 0x00052DC0 File Offset: 0x00050FC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 712895, XrefRangeEnd = 712898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NameLookupTooltipSource()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NameLookupTooltipSource>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameLookupTooltipSource.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600135D RID: 4957 RVA: 0x0000BFD9 File Offset: 0x0000A1D9
		public NameLookupTooltipSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B35 RID: 2869
		private static readonly IntPtr NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0;

		// Token: 0x04000B36 RID: 2870
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalizedTooltip_Public_Virtual_Final_New_String_0;

		// Token: 0x04000B37 RID: 2871
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
