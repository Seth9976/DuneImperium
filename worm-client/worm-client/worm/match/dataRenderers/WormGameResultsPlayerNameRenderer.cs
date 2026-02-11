using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using worm.match.data;

namespace worm.match.dataRenderers
{
	// Token: 0x0200012C RID: 300
	public class WormGameResultsPlayerNameRenderer : Subscriber<WormGameResultsPlayerData>
	{
		// Token: 0x06000DA0 RID: 3488 RVA: 0x00041438 File Offset: 0x0003F638
		// Note: this type is marked as 'beforefieldinit'.
		static WormGameResultsPlayerNameRenderer()
		{
			Il2CppClassPointerStore<WormGameResultsPlayerNameRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormGameResultsPlayerNameRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormGameResultsPlayerNameRenderer>.NativeClassPtr);
			WormGameResultsPlayerNameRenderer.NativeFieldInfoPtr_nameText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsPlayerNameRenderer>.NativeClassPtr, "nameText");
			WormGameResultsPlayerNameRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameResultsPlayerNameRenderer>.NativeClassPtr, 100665147);
			WormGameResultsPlayerNameRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameResultsPlayerNameRenderer>.NativeClassPtr, 100665148);
		}

		// Token: 0x06000DA1 RID: 3489 RVA: 0x000414A4 File Offset: 0x0003F6A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705827, XrefRangeEnd = 705829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void modelChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormGameResultsPlayerNameRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DA2 RID: 3490 RVA: 0x000414E0 File Offset: 0x0003F6E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705829, XrefRangeEnd = 705832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormGameResultsPlayerNameRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormGameResultsPlayerNameRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGameResultsPlayerNameRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DA3 RID: 3491 RVA: 0x0000933B File Offset: 0x0000753B
		public WormGameResultsPlayerNameRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06000DA4 RID: 3492 RVA: 0x0004151C File Offset: 0x0003F71C
		// (set) Token: 0x06000DA5 RID: 3493 RVA: 0x00009344 File Offset: 0x00007544
		public unsafe TMP_Text nameText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsPlayerNameRenderer.NativeFieldInfoPtr_nameText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsPlayerNameRenderer.NativeFieldInfoPtr_nameText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040007DF RID: 2015
		private static readonly IntPtr NativeFieldInfoPtr_nameText;

		// Token: 0x040007E0 RID: 2016
		private static readonly IntPtr NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0;

		// Token: 0x040007E1 RID: 2017
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
