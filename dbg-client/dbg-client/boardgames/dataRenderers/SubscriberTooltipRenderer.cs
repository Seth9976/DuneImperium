using System;
using boardgames.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace boardgames.datarenderers
{
	// Token: 0x02000178 RID: 376
	public class SubscriberTooltipRenderer : Subscriber<BasicTooltip>
	{
		// Token: 0x0600109A RID: 4250 RVA: 0x00051FC8 File Offset: 0x000501C8
		// Note: this type is marked as 'beforefieldinit'.
		static SubscriberTooltipRenderer()
		{
			Il2CppClassPointerStore<SubscriberTooltipRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.datarenderers", "SubscriberTooltipRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubscriberTooltipRenderer>.NativeClassPtr);
			SubscriberTooltipRenderer.NativeFieldInfoPtr_tooltipFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubscriberTooltipRenderer>.NativeClassPtr, "tooltipFormat");
			SubscriberTooltipRenderer.NativeMethodInfoPtr_GetLocalizedTooltip_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubscriberTooltipRenderer>.NativeClassPtr, 100665621);
			SubscriberTooltipRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubscriberTooltipRenderer>.NativeClassPtr, 100665622);
		}

		// Token: 0x0600109B RID: 4251 RVA: 0x00052034 File Offset: 0x00050234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 514124, XrefRangeEnd = 514131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetLocalizedTooltip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubscriberTooltipRenderer.NativeMethodInfoPtr_GetLocalizedTooltip_Public_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600109C RID: 4252 RVA: 0x0005206C File Offset: 0x0005026C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 514131, XrefRangeEnd = 514137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SubscriberTooltipRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubscriberTooltipRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubscriberTooltipRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600109D RID: 4253 RVA: 0x0000A076 File Offset: 0x00008276
		public SubscriberTooltipRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x0600109E RID: 4254 RVA: 0x000520A8 File Offset: 0x000502A8
		// (set) Token: 0x0600109F RID: 4255 RVA: 0x0000A07F File Offset: 0x0000827F
		public unsafe string tooltipFormat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscriberTooltipRenderer.NativeFieldInfoPtr_tooltipFormat);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscriberTooltipRenderer.NativeFieldInfoPtr_tooltipFormat), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000A1F RID: 2591
		private static readonly IntPtr NativeFieldInfoPtr_tooltipFormat;

		// Token: 0x04000A20 RID: 2592
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalizedTooltip_Public_Virtual_Final_New_String_0;

		// Token: 0x04000A21 RID: 2593
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
