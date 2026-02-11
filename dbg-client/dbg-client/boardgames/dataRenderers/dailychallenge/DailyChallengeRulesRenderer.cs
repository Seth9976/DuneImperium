using System;
using boardgames.data;
using dbgclient.dataProviders;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace boardgames.dataRenderers.dailychallenge
{
	// Token: 0x02000161 RID: 353
	public class DailyChallengeRulesRenderer : Subscriber<DailyChallengeRulesData>
	{
		// Token: 0x06000FC8 RID: 4040 RVA: 0x0004FA70 File Offset: 0x0004DC70
		// Note: this type is marked as 'beforefieldinit'.
		static DailyChallengeRulesRenderer()
		{
			Il2CppClassPointerStore<DailyChallengeRulesRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.dataRenderers.dailychallenge", "DailyChallengeRulesRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DailyChallengeRulesRenderer>.NativeClassPtr);
			DailyChallengeRulesRenderer.NativeFieldInfoPtr_ruleModifierPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeRulesRenderer>.NativeClassPtr, "ruleModifierPrefab");
			DailyChallengeRulesRenderer.NativeFieldInfoPtr_ruleModifierRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeRulesRenderer>.NativeClassPtr, "ruleModifierRoot");
			DailyChallengeRulesRenderer.NativeFieldInfoPtr_ruleModifierHeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeRulesRenderer>.NativeClassPtr, "ruleModifierHeader");
			DailyChallengeRulesRenderer.NativeFieldInfoPtr_scoringMethodsPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeRulesRenderer>.NativeClassPtr, "scoringMethodsPrefab");
			DailyChallengeRulesRenderer.NativeFieldInfoPtr_scoringMethodsRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeRulesRenderer>.NativeClassPtr, "scoringMethodsRoot");
			DailyChallengeRulesRenderer.NativeFieldInfoPtr_scoringMethodsHeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeRulesRenderer>.NativeClassPtr, "scoringMethodsHeader");
			DailyChallengeRulesRenderer.NativeFieldInfoPtr_ruleModDisplays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeRulesRenderer>.NativeClassPtr, "ruleModDisplays");
			DailyChallengeRulesRenderer.NativeFieldInfoPtr_scoringMethodDisplays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeRulesRenderer>.NativeClassPtr, "scoringMethodDisplays");
			DailyChallengeRulesRenderer.NativeFieldInfoPtr_scoreProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeRulesRenderer>.NativeClassPtr, "scoreProvider");
			DailyChallengeRulesRenderer.NativeMethodInfoPtr_start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeRulesRenderer>.NativeClassPtr, 100665545);
			DailyChallengeRulesRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeRulesRenderer>.NativeClassPtr, 100665546);
			DailyChallengeRulesRenderer.NativeMethodInfoPtr_UpdateDisplay_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeRulesRenderer>.NativeClassPtr, 100665547);
			DailyChallengeRulesRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeRulesRenderer>.NativeClassPtr, 100665548);
		}

		// Token: 0x06000FC9 RID: 4041 RVA: 0x0004FBA4 File Offset: 0x0004DDA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513539, XrefRangeEnd = 513552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DailyChallengeRulesRenderer.NativeMethodInfoPtr_start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FCA RID: 4042 RVA: 0x0004FBE0 File Offset: 0x0004DDE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513552, XrefRangeEnd = 513553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void modelChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DailyChallengeRulesRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FCB RID: 4043 RVA: 0x0004FC1C File Offset: 0x0004DE1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 513669, RefRangeEnd = 513670, XrefRangeStart = 513553, XrefRangeEnd = 513669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDisplay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeRulesRenderer.NativeMethodInfoPtr_UpdateDisplay_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FCC RID: 4044 RVA: 0x0004FC50 File Offset: 0x0004DE50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513670, XrefRangeEnd = 513685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DailyChallengeRulesRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DailyChallengeRulesRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeRulesRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FCD RID: 4045 RVA: 0x000099AD File Offset: 0x00007BAD
		public DailyChallengeRulesRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x06000FCE RID: 4046 RVA: 0x0004FC8C File Offset: 0x0004DE8C
		// (set) Token: 0x06000FCF RID: 4047 RVA: 0x000099B6 File Offset: 0x00007BB6
		public unsafe GameObject ruleModifierPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeRulesRenderer.NativeFieldInfoPtr_ruleModifierPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeRulesRenderer.NativeFieldInfoPtr_ruleModifierPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x06000FD0 RID: 4048 RVA: 0x0004FCBC File Offset: 0x0004DEBC
		// (set) Token: 0x06000FD1 RID: 4049 RVA: 0x000099D5 File Offset: 0x00007BD5
		public unsafe GameObject ruleModifierRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeRulesRenderer.NativeFieldInfoPtr_ruleModifierRoot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeRulesRenderer.NativeFieldInfoPtr_ruleModifierRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x06000FD2 RID: 4050 RVA: 0x0004FCEC File Offset: 0x0004DEEC
		// (set) Token: 0x06000FD3 RID: 4051 RVA: 0x000099F4 File Offset: 0x00007BF4
		public unsafe GameObject ruleModifierHeader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeRulesRenderer.NativeFieldInfoPtr_ruleModifierHeader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeRulesRenderer.NativeFieldInfoPtr_ruleModifierHeader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06000FD4 RID: 4052 RVA: 0x0004FD1C File Offset: 0x0004DF1C
		// (set) Token: 0x06000FD5 RID: 4053 RVA: 0x00009A13 File Offset: 0x00007C13
		public unsafe GameObject scoringMethodsPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeRulesRenderer.NativeFieldInfoPtr_scoringMethodsPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeRulesRenderer.NativeFieldInfoPtr_scoringMethodsPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06000FD6 RID: 4054 RVA: 0x0004FD4C File Offset: 0x0004DF4C
		// (set) Token: 0x06000FD7 RID: 4055 RVA: 0x00009A32 File Offset: 0x00007C32
		public unsafe GameObject scoringMethodsRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeRulesRenderer.NativeFieldInfoPtr_scoringMethodsRoot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeRulesRenderer.NativeFieldInfoPtr_scoringMethodsRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06000FD8 RID: 4056 RVA: 0x0004FD7C File Offset: 0x0004DF7C
		// (set) Token: 0x06000FD9 RID: 4057 RVA: 0x00009A51 File Offset: 0x00007C51
		public unsafe GameObject scoringMethodsHeader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeRulesRenderer.NativeFieldInfoPtr_scoringMethodsHeader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeRulesRenderer.NativeFieldInfoPtr_scoringMethodsHeader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06000FDA RID: 4058 RVA: 0x0004FDAC File Offset: 0x0004DFAC
		// (set) Token: 0x06000FDB RID: 4059 RVA: 0x00009A70 File Offset: 0x00007C70
		public unsafe List<GameObject> ruleModDisplays
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeRulesRenderer.NativeFieldInfoPtr_ruleModDisplays);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeRulesRenderer.NativeFieldInfoPtr_ruleModDisplays), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06000FDC RID: 4060 RVA: 0x0004FDDC File Offset: 0x0004DFDC
		// (set) Token: 0x06000FDD RID: 4061 RVA: 0x00009A8F File Offset: 0x00007C8F
		public unsafe List<GameObject> scoringMethodDisplays
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeRulesRenderer.NativeFieldInfoPtr_scoringMethodDisplays);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeRulesRenderer.NativeFieldInfoPtr_scoringMethodDisplays), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06000FDE RID: 4062 RVA: 0x0004FE0C File Offset: 0x0004E00C
		// (set) Token: 0x06000FDF RID: 4063 RVA: 0x00009AAE File Offset: 0x00007CAE
		public unsafe IDailyChallengeScoreProvider scoreProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeRulesRenderer.NativeFieldInfoPtr_scoreProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDailyChallengeScoreProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeRulesRenderer.NativeFieldInfoPtr_scoreProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009AC RID: 2476
		private static readonly IntPtr NativeFieldInfoPtr_ruleModifierPrefab;

		// Token: 0x040009AD RID: 2477
		private static readonly IntPtr NativeFieldInfoPtr_ruleModifierRoot;

		// Token: 0x040009AE RID: 2478
		private static readonly IntPtr NativeFieldInfoPtr_ruleModifierHeader;

		// Token: 0x040009AF RID: 2479
		private static readonly IntPtr NativeFieldInfoPtr_scoringMethodsPrefab;

		// Token: 0x040009B0 RID: 2480
		private static readonly IntPtr NativeFieldInfoPtr_scoringMethodsRoot;

		// Token: 0x040009B1 RID: 2481
		private static readonly IntPtr NativeFieldInfoPtr_scoringMethodsHeader;

		// Token: 0x040009B2 RID: 2482
		private static readonly IntPtr NativeFieldInfoPtr_ruleModDisplays;

		// Token: 0x040009B3 RID: 2483
		private static readonly IntPtr NativeFieldInfoPtr_scoringMethodDisplays;

		// Token: 0x040009B4 RID: 2484
		private static readonly IntPtr NativeFieldInfoPtr_scoreProvider;

		// Token: 0x040009B5 RID: 2485
		private static readonly IntPtr NativeMethodInfoPtr_start_Protected_Virtual_Void_0;

		// Token: 0x040009B6 RID: 2486
		private static readonly IntPtr NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0;

		// Token: 0x040009B7 RID: 2487
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDisplay_Private_Void_0;

		// Token: 0x040009B8 RID: 2488
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200036E RID: 878
		[ObfuscatedName("boardgames.dataRenderers.dailychallenge.DailyChallengeRulesRenderer+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06002958 RID: 10584 RVA: 0x000A4368 File Offset: 0x000A2568
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DailyChallengeRulesRenderer.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DailyChallengeRulesRenderer>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DailyChallengeRulesRenderer.__c>.NativeClassPtr);
				DailyChallengeRulesRenderer.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeRulesRenderer.__c>.NativeClassPtr, "<>9");
				DailyChallengeRulesRenderer.__c.NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeRulesRenderer.__c>.NativeClassPtr, "<>9__11_0");
				DailyChallengeRulesRenderer.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeRulesRenderer.__c>.NativeClassPtr, 100665550);
				DailyChallengeRulesRenderer.__c.NativeMethodInfoPtr__UpdateDisplay_b__11_0_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeRulesRenderer.__c>.NativeClassPtr, 100665551);
			}

			// Token: 0x06002959 RID: 10585 RVA: 0x000A43E4 File Offset: 0x000A25E4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DailyChallengeRulesRenderer.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeRulesRenderer.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600295A RID: 10586 RVA: 0x000A4420 File Offset: 0x000A2620
			[CallerCount(0)]
			public unsafe bool _UpdateDisplay_b__11_0(int m)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref m;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeRulesRenderer.__c.NativeMethodInfoPtr__UpdateDisplay_b__11_0_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600295B RID: 10587 RVA: 0x0001559B File Offset: 0x0001379B
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B9F RID: 2975
			// (get) Token: 0x0600295C RID: 10588 RVA: 0x000A446C File Offset: 0x000A266C
			// (set) Token: 0x0600295D RID: 10589 RVA: 0x000155A4 File Offset: 0x000137A4
			public unsafe static DailyChallengeRulesRenderer.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DailyChallengeRulesRenderer.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DailyChallengeRulesRenderer.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DailyChallengeRulesRenderer.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BA0 RID: 2976
			// (get) Token: 0x0600295E RID: 10590 RVA: 0x000A4494 File Offset: 0x000A2694
			// (set) Token: 0x0600295F RID: 10591 RVA: 0x000155B6 File Offset: 0x000137B6
			public unsafe static Func<int, bool> __9__11_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DailyChallengeRulesRenderer.__c.NativeFieldInfoPtr___9__11_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DailyChallengeRulesRenderer.__c.NativeFieldInfoPtr___9__11_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040019D5 RID: 6613
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040019D6 RID: 6614
			private static readonly IntPtr NativeFieldInfoPtr___9__11_0;

			// Token: 0x040019D7 RID: 6615
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040019D8 RID: 6616
			private static readonly IntPtr NativeMethodInfoPtr__UpdateDisplay_b__11_0_Internal_Boolean_Int32_0;
		}
	}
}
