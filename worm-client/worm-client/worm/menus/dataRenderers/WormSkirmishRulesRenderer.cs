using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using lotus;
using UnityEngine;
using worm.match.data;
using worm.match.dataRenderers;

namespace worm.menus.dataRenderers
{
	// Token: 0x02000097 RID: 151
	public class WormSkirmishRulesRenderer : Subscriber<WormSkirmishRulesData>
	{
		// Token: 0x060005E5 RID: 1509 RVA: 0x0002AAFC File Offset: 0x00028CFC
		// Note: this type is marked as 'beforefieldinit'.
		static WormSkirmishRulesRenderer()
		{
			Il2CppClassPointerStore<WormSkirmishRulesRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.menus.dataRenderers", "WormSkirmishRulesRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormSkirmishRulesRenderer>.NativeClassPtr);
			WormSkirmishRulesRenderer.NativeFieldInfoPtr_skirmishRuleModifierPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSkirmishRulesRenderer>.NativeClassPtr, "skirmishRuleModifierPrefab");
			WormSkirmishRulesRenderer.NativeFieldInfoPtr_skirmishRuleModifierRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSkirmishRulesRenderer>.NativeClassPtr, "skirmishRuleModifierRoot");
			WormSkirmishRulesRenderer.NativeFieldInfoPtr_skirmishRuleModifierHeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSkirmishRulesRenderer>.NativeClassPtr, "skirmishRuleModifierHeader");
			WormSkirmishRulesRenderer.NativeFieldInfoPtr_scoringMethodsPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSkirmishRulesRenderer>.NativeClassPtr, "scoringMethodsPrefab");
			WormSkirmishRulesRenderer.NativeFieldInfoPtr_scoringMethodsRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSkirmishRulesRenderer>.NativeClassPtr, "scoringMethodsRoot");
			WormSkirmishRulesRenderer.NativeFieldInfoPtr_scoringMethodsHeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSkirmishRulesRenderer>.NativeClassPtr, "scoringMethodsHeader");
			WormSkirmishRulesRenderer.NativeFieldInfoPtr_scoreRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSkirmishRulesRenderer>.NativeClassPtr, "scoreRenderer");
			WormSkirmishRulesRenderer.NativeFieldInfoPtr_relatedTechIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSkirmishRulesRenderer>.NativeClassPtr, "relatedTechIcon");
			WormSkirmishRulesRenderer.NativeFieldInfoPtr_ruleModDisplays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSkirmishRulesRenderer>.NativeClassPtr, "ruleModDisplays");
			WormSkirmishRulesRenderer.NativeFieldInfoPtr_scoringMethodDisplays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSkirmishRulesRenderer>.NativeClassPtr, "scoringMethodDisplays");
			WormSkirmishRulesRenderer.NativeMethodInfoPtr_start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSkirmishRulesRenderer>.NativeClassPtr, 100664133);
			WormSkirmishRulesRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSkirmishRulesRenderer>.NativeClassPtr, 100664134);
			WormSkirmishRulesRenderer.NativeMethodInfoPtr_UpdateDisplay_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSkirmishRulesRenderer>.NativeClassPtr, 100664135);
			WormSkirmishRulesRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSkirmishRulesRenderer>.NativeClassPtr, 100664136);
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x0002AC44 File Offset: 0x00028E44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 695714, XrefRangeEnd = 695725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormSkirmishRulesRenderer.NativeMethodInfoPtr_start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x0002AC80 File Offset: 0x00028E80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 695725, XrefRangeEnd = 695726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void modelChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormSkirmishRulesRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x0002ACBC File Offset: 0x00028EBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 695859, RefRangeEnd = 695860, XrefRangeStart = 695726, XrefRangeEnd = 695859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDisplay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSkirmishRulesRenderer.NativeMethodInfoPtr_UpdateDisplay_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x0002ACF0 File Offset: 0x00028EF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 695860, XrefRangeEnd = 695875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormSkirmishRulesRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormSkirmishRulesRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSkirmishRulesRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x00004F05 File Offset: 0x00003105
		public WormSkirmishRulesRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x060005EB RID: 1515 RVA: 0x0002AD2C File Offset: 0x00028F2C
		// (set) Token: 0x060005EC RID: 1516 RVA: 0x00004F0E File Offset: 0x0000310E
		public unsafe GameObject skirmishRuleModifierPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSkirmishRulesRenderer.NativeFieldInfoPtr_skirmishRuleModifierPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSkirmishRulesRenderer.NativeFieldInfoPtr_skirmishRuleModifierPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x060005ED RID: 1517 RVA: 0x0002AD5C File Offset: 0x00028F5C
		// (set) Token: 0x060005EE RID: 1518 RVA: 0x00004F2D File Offset: 0x0000312D
		public unsafe GameObject skirmishRuleModifierRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSkirmishRulesRenderer.NativeFieldInfoPtr_skirmishRuleModifierRoot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSkirmishRulesRenderer.NativeFieldInfoPtr_skirmishRuleModifierRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x060005EF RID: 1519 RVA: 0x0002AD8C File Offset: 0x00028F8C
		// (set) Token: 0x060005F0 RID: 1520 RVA: 0x00004F4C File Offset: 0x0000314C
		public unsafe GameObject skirmishRuleModifierHeader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSkirmishRulesRenderer.NativeFieldInfoPtr_skirmishRuleModifierHeader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSkirmishRulesRenderer.NativeFieldInfoPtr_skirmishRuleModifierHeader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x060005F1 RID: 1521 RVA: 0x0002ADBC File Offset: 0x00028FBC
		// (set) Token: 0x060005F2 RID: 1522 RVA: 0x00004F6B File Offset: 0x0000316B
		public unsafe GameObject scoringMethodsPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSkirmishRulesRenderer.NativeFieldInfoPtr_scoringMethodsPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSkirmishRulesRenderer.NativeFieldInfoPtr_scoringMethodsPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x060005F3 RID: 1523 RVA: 0x0002ADEC File Offset: 0x00028FEC
		// (set) Token: 0x060005F4 RID: 1524 RVA: 0x00004F8A File Offset: 0x0000318A
		public unsafe GameObject scoringMethodsRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSkirmishRulesRenderer.NativeFieldInfoPtr_scoringMethodsRoot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSkirmishRulesRenderer.NativeFieldInfoPtr_scoringMethodsRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x060005F5 RID: 1525 RVA: 0x0002AE1C File Offset: 0x0002901C
		// (set) Token: 0x060005F6 RID: 1526 RVA: 0x00004FA9 File Offset: 0x000031A9
		public unsafe GameObject scoringMethodsHeader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSkirmishRulesRenderer.NativeFieldInfoPtr_scoringMethodsHeader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSkirmishRulesRenderer.NativeFieldInfoPtr_scoringMethodsHeader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x060005F7 RID: 1527 RVA: 0x0002AE4C File Offset: 0x0002904C
		// (set) Token: 0x060005F8 RID: 1528 RVA: 0x00004FC8 File Offset: 0x000031C8
		public unsafe WormSkirmishScoreRenderer scoreRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSkirmishRulesRenderer.NativeFieldInfoPtr_scoreRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormSkirmishScoreRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSkirmishRulesRenderer.NativeFieldInfoPtr_scoreRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x060005F9 RID: 1529 RVA: 0x0002AE7C File Offset: 0x0002907C
		// (set) Token: 0x060005FA RID: 1530 RVA: 0x00004FE7 File Offset: 0x000031E7
		public unsafe UnitView relatedTechIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSkirmishRulesRenderer.NativeFieldInfoPtr_relatedTechIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnitView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSkirmishRulesRenderer.NativeFieldInfoPtr_relatedTechIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x060005FB RID: 1531 RVA: 0x0002AEAC File Offset: 0x000290AC
		// (set) Token: 0x060005FC RID: 1532 RVA: 0x00005006 File Offset: 0x00003206
		public unsafe List<GameObject> ruleModDisplays
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSkirmishRulesRenderer.NativeFieldInfoPtr_ruleModDisplays);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSkirmishRulesRenderer.NativeFieldInfoPtr_ruleModDisplays), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x060005FD RID: 1533 RVA: 0x0002AEDC File Offset: 0x000290DC
		// (set) Token: 0x060005FE RID: 1534 RVA: 0x00005025 File Offset: 0x00003225
		public unsafe List<GameObject> scoringMethodDisplays
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSkirmishRulesRenderer.NativeFieldInfoPtr_scoringMethodDisplays);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSkirmishRulesRenderer.NativeFieldInfoPtr_scoringMethodDisplays), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000366 RID: 870
		private static readonly IntPtr NativeFieldInfoPtr_skirmishRuleModifierPrefab;

		// Token: 0x04000367 RID: 871
		private static readonly IntPtr NativeFieldInfoPtr_skirmishRuleModifierRoot;

		// Token: 0x04000368 RID: 872
		private static readonly IntPtr NativeFieldInfoPtr_skirmishRuleModifierHeader;

		// Token: 0x04000369 RID: 873
		private static readonly IntPtr NativeFieldInfoPtr_scoringMethodsPrefab;

		// Token: 0x0400036A RID: 874
		private static readonly IntPtr NativeFieldInfoPtr_scoringMethodsRoot;

		// Token: 0x0400036B RID: 875
		private static readonly IntPtr NativeFieldInfoPtr_scoringMethodsHeader;

		// Token: 0x0400036C RID: 876
		private static readonly IntPtr NativeFieldInfoPtr_scoreRenderer;

		// Token: 0x0400036D RID: 877
		private static readonly IntPtr NativeFieldInfoPtr_relatedTechIcon;

		// Token: 0x0400036E RID: 878
		private static readonly IntPtr NativeFieldInfoPtr_ruleModDisplays;

		// Token: 0x0400036F RID: 879
		private static readonly IntPtr NativeFieldInfoPtr_scoringMethodDisplays;

		// Token: 0x04000370 RID: 880
		private static readonly IntPtr NativeMethodInfoPtr_start_Protected_Virtual_Void_0;

		// Token: 0x04000371 RID: 881
		private static readonly IntPtr NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0;

		// Token: 0x04000372 RID: 882
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDisplay_Private_Void_0;

		// Token: 0x04000373 RID: 883
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000308 RID: 776
		[ObfuscatedName("worm.menus.dataRenderers.WormSkirmishRulesRenderer+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06001F47 RID: 8007 RVA: 0x00077B58 File Offset: 0x00075D58
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WormSkirmishRulesRenderer.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormSkirmishRulesRenderer>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormSkirmishRulesRenderer.__c>.NativeClassPtr);
				WormSkirmishRulesRenderer.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSkirmishRulesRenderer.__c>.NativeClassPtr, "<>9");
				WormSkirmishRulesRenderer.__c.NativeFieldInfoPtr___9__12_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSkirmishRulesRenderer.__c>.NativeClassPtr, "<>9__12_0");
				WormSkirmishRulesRenderer.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSkirmishRulesRenderer.__c>.NativeClassPtr, 100664138);
				WormSkirmishRulesRenderer.__c.NativeMethodInfoPtr__UpdateDisplay_b__12_0_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSkirmishRulesRenderer.__c>.NativeClassPtr, 100664139);
			}

			// Token: 0x06001F48 RID: 8008 RVA: 0x00077BD4 File Offset: 0x00075DD4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormSkirmishRulesRenderer.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSkirmishRulesRenderer.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F49 RID: 8009 RVA: 0x00077C10 File Offset: 0x00075E10
			[CallerCount(0)]
			public unsafe bool _UpdateDisplay_b__12_0(int m)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref m;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSkirmishRulesRenderer.__c.NativeMethodInfoPtr__UpdateDisplay_b__12_0_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001F4A RID: 8010 RVA: 0x00011AB7 File Offset: 0x0000FCB7
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700088D RID: 2189
			// (get) Token: 0x06001F4B RID: 8011 RVA: 0x00077C5C File Offset: 0x00075E5C
			// (set) Token: 0x06001F4C RID: 8012 RVA: 0x00011AC0 File Offset: 0x0000FCC0
			public unsafe static WormSkirmishRulesRenderer.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormSkirmishRulesRenderer.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormSkirmishRulesRenderer.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormSkirmishRulesRenderer.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700088E RID: 2190
			// (get) Token: 0x06001F4D RID: 8013 RVA: 0x00077C84 File Offset: 0x00075E84
			// (set) Token: 0x06001F4E RID: 8014 RVA: 0x00011AD2 File Offset: 0x0000FCD2
			public unsafe static Func<int, bool> __9__12_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormSkirmishRulesRenderer.__c.NativeFieldInfoPtr___9__12_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormSkirmishRulesRenderer.__c.NativeFieldInfoPtr___9__12_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001212 RID: 4626
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001213 RID: 4627
			private static readonly IntPtr NativeFieldInfoPtr___9__12_0;

			// Token: 0x04001214 RID: 4628
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001215 RID: 4629
			private static readonly IntPtr NativeMethodInfoPtr__UpdateDisplay_b__12_0_Internal_Boolean_Int32_0;
		}
	}
}
