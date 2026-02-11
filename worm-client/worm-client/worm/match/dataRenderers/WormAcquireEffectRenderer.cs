using System;
using dwd.core.util;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using lotus;
using UnityEngine;
using UnityEngine.UI;
using worm.canis.data.enums;

namespace worm.match.dataRenderers
{
	// Token: 0x020000F6 RID: 246
	public class WormAcquireEffectRenderer : Observer
	{
		// Token: 0x06000AD3 RID: 2771 RVA: 0x0003905C File Offset: 0x0003725C
		// Note: this type is marked as 'beforefieldinit'.
		static WormAcquireEffectRenderer()
		{
			Il2CppClassPointerStore<WormAcquireEffectRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormAcquireEffectRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormAcquireEffectRenderer>.NativeClassPtr);
			WormAcquireEffectRenderer.NativeFieldInfoPtr_display = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAcquireEffectRenderer>.NativeClassPtr, "display");
			WormAcquireEffectRenderer.NativeFieldInfoPtr_iconTemplate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAcquireEffectRenderer>.NativeClassPtr, "iconTemplate");
			WormAcquireEffectRenderer.NativeFieldInfoPtr_iconsByEffectMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAcquireEffectRenderer>.NativeClassPtr, "iconsByEffectMap");
			WormAcquireEffectRenderer.NativeFieldInfoPtr_isReclaimedForces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAcquireEffectRenderer>.NativeClassPtr, "isReclaimedForces");
			WormAcquireEffectRenderer.NativeFieldInfoPtr_createdIcons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAcquireEffectRenderer>.NativeClassPtr, "createdIcons");
			WormAcquireEffectRenderer.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAcquireEffectRenderer>.NativeClassPtr, 100664790);
			WormAcquireEffectRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAcquireEffectRenderer>.NativeClassPtr, 100664791);
		}

		// Token: 0x06000AD4 RID: 2772 RVA: 0x00039118 File Offset: 0x00037318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 702062, XrefRangeEnd = 702153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormAcquireEffectRenderer.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AD5 RID: 2773 RVA: 0x00039154 File Offset: 0x00037354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 702153, XrefRangeEnd = 702173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormAcquireEffectRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAcquireEffectRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAcquireEffectRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AD6 RID: 2774 RVA: 0x00007A9A File Offset: 0x00005C9A
		public WormAcquireEffectRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06000AD7 RID: 2775 RVA: 0x00039190 File Offset: 0x00037390
		// (set) Token: 0x06000AD8 RID: 2776 RVA: 0x00007AA3 File Offset: 0x00005CA3
		public unsafe GameObject display
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAcquireEffectRenderer.NativeFieldInfoPtr_display);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAcquireEffectRenderer.NativeFieldInfoPtr_display), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06000AD9 RID: 2777 RVA: 0x000391C0 File Offset: 0x000373C0
		// (set) Token: 0x06000ADA RID: 2778 RVA: 0x00007AC2 File Offset: 0x00005CC2
		public unsafe Image iconTemplate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAcquireEffectRenderer.NativeFieldInfoPtr_iconTemplate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAcquireEffectRenderer.NativeFieldInfoPtr_iconTemplate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06000ADB RID: 2779 RVA: 0x000391F0 File Offset: 0x000373F0
		// (set) Token: 0x06000ADC RID: 2780 RVA: 0x00007AE1 File Offset: 0x00005CE1
		public unsafe Il2CppReferenceArray<WormAcquireEffectRenderer.AcquireEffectIconsPair> iconsByEffectMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAcquireEffectRenderer.NativeFieldInfoPtr_iconsByEffectMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<WormAcquireEffectRenderer.AcquireEffectIconsPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAcquireEffectRenderer.NativeFieldInfoPtr_iconsByEffectMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06000ADD RID: 2781 RVA: 0x00039220 File Offset: 0x00037420
		// (set) Token: 0x06000ADE RID: 2782 RVA: 0x00007B00 File Offset: 0x00005D00
		public unsafe BoolUnityEvents isReclaimedForces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAcquireEffectRenderer.NativeFieldInfoPtr_isReclaimedForces);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolUnityEvents>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAcquireEffectRenderer.NativeFieldInfoPtr_isReclaimedForces), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06000ADF RID: 2783 RVA: 0x00039250 File Offset: 0x00037450
		// (set) Token: 0x06000AE0 RID: 2784 RVA: 0x00007B1F File Offset: 0x00005D1F
		public unsafe List<Image> createdIcons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAcquireEffectRenderer.NativeFieldInfoPtr_createdIcons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Image>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAcquireEffectRenderer.NativeFieldInfoPtr_createdIcons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000640 RID: 1600
		private static readonly IntPtr NativeFieldInfoPtr_display;

		// Token: 0x04000641 RID: 1601
		private static readonly IntPtr NativeFieldInfoPtr_iconTemplate;

		// Token: 0x04000642 RID: 1602
		private static readonly IntPtr NativeFieldInfoPtr_iconsByEffectMap;

		// Token: 0x04000643 RID: 1603
		private static readonly IntPtr NativeFieldInfoPtr_isReclaimedForces;

		// Token: 0x04000644 RID: 1604
		private static readonly IntPtr NativeFieldInfoPtr_createdIcons;

		// Token: 0x04000645 RID: 1605
		private static readonly IntPtr NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0;

		// Token: 0x04000646 RID: 1606
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000356 RID: 854
		[Serializable]
		public sealed class AcquireEffectIconsPair : ValueType
		{
			// Token: 0x06002287 RID: 8839 RVA: 0x00081098 File Offset: 0x0007F298
			// Note: this type is marked as 'beforefieldinit'.
			static AcquireEffectIconsPair()
			{
				Il2CppClassPointerStore<WormAcquireEffectRenderer.AcquireEffectIconsPair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormAcquireEffectRenderer>.NativeClassPtr, "AcquireEffectIconsPair");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormAcquireEffectRenderer.AcquireEffectIconsPair>.NativeClassPtr);
				WormAcquireEffectRenderer.AcquireEffectIconsPair.NativeFieldInfoPtr_effect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAcquireEffectRenderer.AcquireEffectIconsPair>.NativeClassPtr, "effect");
				WormAcquireEffectRenderer.AcquireEffectIconsPair.NativeFieldInfoPtr_image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAcquireEffectRenderer.AcquireEffectIconsPair>.NativeClassPtr, "image");
			}

			// Token: 0x06002288 RID: 8840 RVA: 0x00013572 File Offset: 0x00011772
			public AcquireEffectIconsPair(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002289 RID: 8841 RVA: 0x0001357B File Offset: 0x0001177B
			public AcquireEffectIconsPair()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAcquireEffectRenderer.AcquireEffectIconsPair>.NativeClassPtr))
			{
			}

			// Token: 0x17000988 RID: 2440
			// (get) Token: 0x0600228A RID: 8842 RVA: 0x000810EC File Offset: 0x0007F2EC
			// (set) Token: 0x0600228B RID: 8843 RVA: 0x0001358D File Offset: 0x0001178D
			public unsafe AcquireEffects effect
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAcquireEffectRenderer.AcquireEffectIconsPair.NativeFieldInfoPtr_effect);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAcquireEffectRenderer.AcquireEffectIconsPair.NativeFieldInfoPtr_effect)) = value;
				}
			}

			// Token: 0x17000989 RID: 2441
			// (get) Token: 0x0600228C RID: 8844 RVA: 0x00081114 File Offset: 0x0007F314
			// (set) Token: 0x0600228D RID: 8845 RVA: 0x000135A8 File Offset: 0x000117A8
			public unsafe Sprite image
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAcquireEffectRenderer.AcquireEffectIconsPair.NativeFieldInfoPtr_image);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAcquireEffectRenderer.AcquireEffectIconsPair.NativeFieldInfoPtr_image), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040013DF RID: 5087
			private static readonly IntPtr NativeFieldInfoPtr_effect;

			// Token: 0x040013E0 RID: 5088
			private static readonly IntPtr NativeFieldInfoPtr_image;
		}

		// Token: 0x02000357 RID: 855
		[ObfuscatedName("worm.match.dataRenderers.WormAcquireEffectRenderer+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600228E RID: 8846 RVA: 0x00081144 File Offset: 0x0007F344
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<WormAcquireEffectRenderer.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormAcquireEffectRenderer>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormAcquireEffectRenderer.__c__DisplayClass6_0>.NativeClassPtr);
				WormAcquireEffectRenderer.__c__DisplayClass6_0.NativeFieldInfoPtr_effect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAcquireEffectRenderer.__c__DisplayClass6_0>.NativeClassPtr, "effect");
				WormAcquireEffectRenderer.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAcquireEffectRenderer.__c__DisplayClass6_0>.NativeClassPtr, 100664792);
				WormAcquireEffectRenderer.__c__DisplayClass6_0.NativeMethodInfoPtr__DirtyUpdate_b__0_Internal_Boolean_AcquireEffectIconsPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAcquireEffectRenderer.__c__DisplayClass6_0>.NativeClassPtr, 100664793);
			}

			// Token: 0x0600228F RID: 8847 RVA: 0x000811AC File Offset: 0x0007F3AC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAcquireEffectRenderer.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAcquireEffectRenderer.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002290 RID: 8848 RVA: 0x000811E8 File Offset: 0x0007F3E8
			[CallerCount(0)]
			public unsafe bool _DirtyUpdate_b__0(WormAcquireEffectRenderer.AcquireEffectIconsPair p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(p));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAcquireEffectRenderer.__c__DisplayClass6_0.NativeMethodInfoPtr__DirtyUpdate_b__0_Internal_Boolean_AcquireEffectIconsPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002291 RID: 8849 RVA: 0x000135C7 File Offset: 0x000117C7
			public __c__DisplayClass6_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700098A RID: 2442
			// (get) Token: 0x06002292 RID: 8850 RVA: 0x0008123C File Offset: 0x0007F43C
			// (set) Token: 0x06002293 RID: 8851 RVA: 0x000135D0 File Offset: 0x000117D0
			public unsafe AcquireEffects effect
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAcquireEffectRenderer.__c__DisplayClass6_0.NativeFieldInfoPtr_effect);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAcquireEffectRenderer.__c__DisplayClass6_0.NativeFieldInfoPtr_effect)) = value;
				}
			}

			// Token: 0x040013E1 RID: 5089
			private static readonly IntPtr NativeFieldInfoPtr_effect;

			// Token: 0x040013E2 RID: 5090
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040013E3 RID: 5091
			private static readonly IntPtr NativeMethodInfoPtr__DirtyUpdate_b__0_Internal_Boolean_AcquireEffectIconsPair_0;
		}
	}
}
