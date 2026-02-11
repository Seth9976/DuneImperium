using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using worm.match.data;

namespace worm.match.dataRenderers
{
	// Token: 0x02000130 RID: 304
	public class WormGameResultsSpiceRenderer : Subscriber<WormGameResultsPlayerData>
	{
		// Token: 0x06000DB9 RID: 3513 RVA: 0x000418D0 File Offset: 0x0003FAD0
		// Note: this type is marked as 'beforefieldinit'.
		static WormGameResultsSpiceRenderer()
		{
			Il2CppClassPointerStore<WormGameResultsSpiceRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormGameResultsSpiceRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormGameResultsSpiceRenderer>.NativeClassPtr);
			WormGameResultsSpiceRenderer.NativeFieldInfoPtr_spiceText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsSpiceRenderer>.NativeClassPtr, "spiceText");
			WormGameResultsSpiceRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameResultsSpiceRenderer>.NativeClassPtr, 100665156);
			WormGameResultsSpiceRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameResultsSpiceRenderer>.NativeClassPtr, 100665157);
		}

		// Token: 0x06000DBA RID: 3514 RVA: 0x0004193C File Offset: 0x0003FB3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705901, XrefRangeEnd = 705903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void modelChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormGameResultsSpiceRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DBB RID: 3515 RVA: 0x00041978 File Offset: 0x0003FB78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705903, XrefRangeEnd = 705906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormGameResultsSpiceRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormGameResultsSpiceRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGameResultsSpiceRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DBC RID: 3516 RVA: 0x000093DB File Offset: 0x000075DB
		public WormGameResultsSpiceRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06000DBD RID: 3517 RVA: 0x000419B4 File Offset: 0x0003FBB4
		// (set) Token: 0x06000DBE RID: 3518 RVA: 0x000093E4 File Offset: 0x000075E4
		public unsafe TMP_Text spiceText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsSpiceRenderer.NativeFieldInfoPtr_spiceText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsSpiceRenderer.NativeFieldInfoPtr_spiceText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040007EC RID: 2028
		private static readonly IntPtr NativeFieldInfoPtr_spiceText;

		// Token: 0x040007ED RID: 2029
		private static readonly IntPtr NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0;

		// Token: 0x040007EE RID: 2030
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
