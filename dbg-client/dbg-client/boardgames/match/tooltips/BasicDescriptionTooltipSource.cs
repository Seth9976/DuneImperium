using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace boardgames.match.tooltips
{
	// Token: 0x0200024C RID: 588
	public class BasicDescriptionTooltipSource : Subscriber<BasicDescription>
	{
		// Token: 0x06001ACA RID: 6858 RVA: 0x00074E2C File Offset: 0x0007302C
		// Note: this type is marked as 'beforefieldinit'.
		static BasicDescriptionTooltipSource()
		{
			Il2CppClassPointerStore<BasicDescriptionTooltipSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.tooltips", "BasicDescriptionTooltipSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BasicDescriptionTooltipSource>.NativeClassPtr);
			BasicDescriptionTooltipSource.NativeMethodInfoPtr_GetLocalizedTooltip_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicDescriptionTooltipSource>.NativeClassPtr, 100667576);
			BasicDescriptionTooltipSource.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicDescriptionTooltipSource>.NativeClassPtr, 100667577);
		}

		// Token: 0x06001ACB RID: 6859 RVA: 0x00074E84 File Offset: 0x00073084
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 532700, XrefRangeEnd = 532703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetLocalizedTooltip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicDescriptionTooltipSource.NativeMethodInfoPtr_GetLocalizedTooltip_Public_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001ACC RID: 6860 RVA: 0x00074EBC File Offset: 0x000730BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 532703, XrefRangeEnd = 532706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BasicDescriptionTooltipSource()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BasicDescriptionTooltipSource>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicDescriptionTooltipSource.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001ACD RID: 6861 RVA: 0x0000EA2E File Offset: 0x0000CC2E
		public BasicDescriptionTooltipSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040010BB RID: 4283
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalizedTooltip_Public_Virtual_Final_New_String_0;

		// Token: 0x040010BC RID: 4284
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
