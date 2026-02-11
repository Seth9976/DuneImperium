using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering
{
	// Token: 0x0200006E RID: 110
	public class FrameTimeSampleHistory : Object
	{
		// Token: 0x0600078F RID: 1935 RVA: 0x0002A040 File Offset: 0x00028240
		// Note: this type is marked as 'beforefieldinit'.
		static FrameTimeSampleHistory()
		{
			Il2CppClassPointerStore<FrameTimeSampleHistory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "FrameTimeSampleHistory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FrameTimeSampleHistory>.NativeClassPtr);
			FrameTimeSampleHistory.NativeFieldInfoPtr_m_Samples = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTimeSampleHistory>.NativeClassPtr, "m_Samples");
			FrameTimeSampleHistory.NativeFieldInfoPtr_SampleAverage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTimeSampleHistory>.NativeClassPtr, "SampleAverage");
			FrameTimeSampleHistory.NativeFieldInfoPtr_SampleMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTimeSampleHistory>.NativeClassPtr, "SampleMin");
			FrameTimeSampleHistory.NativeFieldInfoPtr_SampleMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTimeSampleHistory>.NativeClassPtr, "SampleMax");
			FrameTimeSampleHistory.NativeFieldInfoPtr_s_SampleValueAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTimeSampleHistory>.NativeClassPtr, "s_SampleValueAdd");
			FrameTimeSampleHistory.NativeFieldInfoPtr_s_SampleValueMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTimeSampleHistory>.NativeClassPtr, "s_SampleValueMin");
			FrameTimeSampleHistory.NativeFieldInfoPtr_s_SampleValueMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTimeSampleHistory>.NativeClassPtr, "s_SampleValueMax");
			FrameTimeSampleHistory.NativeFieldInfoPtr_s_SampleValueCountValid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTimeSampleHistory>.NativeClassPtr, "s_SampleValueCountValid");
			FrameTimeSampleHistory.NativeFieldInfoPtr_s_SampleValueEnsureValid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTimeSampleHistory>.NativeClassPtr, "s_SampleValueEnsureValid");
			FrameTimeSampleHistory.NativeFieldInfoPtr_s_SampleValueDivide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTimeSampleHistory>.NativeClassPtr, "s_SampleValueDivide");
			FrameTimeSampleHistory.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameTimeSampleHistory>.NativeClassPtr, 100664505);
			FrameTimeSampleHistory.NativeMethodInfoPtr_Add_Internal_Void_FrameTimeSample_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameTimeSampleHistory>.NativeClassPtr, 100664506);
			FrameTimeSampleHistory.NativeMethodInfoPtr_ComputeAggregateValues_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameTimeSampleHistory>.NativeClassPtr, 100664507);
			FrameTimeSampleHistory.NativeMethodInfoPtr_DiscardOldSamples_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameTimeSampleHistory>.NativeClassPtr, 100664508);
			FrameTimeSampleHistory.NativeMethodInfoPtr_Clear_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameTimeSampleHistory>.NativeClassPtr, 100664509);
			FrameTimeSampleHistory.NativeMethodInfoPtr_Method_Internal_Static_Void_byref_FrameTimeSample_FrameTimeSample_Func_3_Single_Single_Single_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameTimeSampleHistory>.NativeClassPtr, 100664511);
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x0002A1B0 File Offset: 0x000283B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 964885, RefRangeEnd = 964886, XrefRangeStart = 964873, XrefRangeEnd = 964885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FrameTimeSampleHistory(int initialCapacity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FrameTimeSampleHistory>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref initialCapacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FrameTimeSampleHistory.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x0002A1F8 File Offset: 0x000283F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 964889, RefRangeEnd = 964890, XrefRangeStart = 964886, XrefRangeEnd = 964889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(FrameTimeSample sample)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sample;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FrameTimeSampleHistory.NativeMethodInfoPtr_Add_Internal_Void_FrameTimeSample_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x0002A238 File Offset: 0x00028438
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 964907, RefRangeEnd = 964908, XrefRangeStart = 964890, XrefRangeEnd = 964907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ComputeAggregateValues()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FrameTimeSampleHistory.NativeMethodInfoPtr_ComputeAggregateValues_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x0002A26C File Offset: 0x0002846C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 964917, RefRangeEnd = 964918, XrefRangeStart = 964908, XrefRangeEnd = 964917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DiscardOldSamples(int sampleHistorySize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sampleHistorySize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FrameTimeSampleHistory.NativeMethodInfoPtr_DiscardOldSamples_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x0002A2AC File Offset: 0x000284AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 964919, RefRangeEnd = 964920, XrefRangeStart = 964918, XrefRangeEnd = 964919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FrameTimeSampleHistory.NativeMethodInfoPtr_Clear_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x0002A2E0 File Offset: 0x000284E0
		[CallerCount(0)]
		public unsafe static void Method_Internal_Static_Void_byref_FrameTimeSample_FrameTimeSample_Func_3_Single_Single_Single_PDM_0(ref FrameTimeSample aggregate, FrameTimeSample sample, Func<float, float, float> func)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &aggregate;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sample;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(func);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FrameTimeSampleHistory.NativeMethodInfoPtr_Method_Internal_Static_Void_byref_FrameTimeSample_FrameTimeSample_Func_3_Single_Single_Single_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x0000502F File Offset: 0x0000322F
		public FrameTimeSampleHistory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x06000797 RID: 1943 RVA: 0x0002A334 File Offset: 0x00028534
		// (set) Token: 0x06000798 RID: 1944 RVA: 0x00005038 File Offset: 0x00003238
		public unsafe List<FrameTimeSample> m_Samples
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FrameTimeSampleHistory.NativeFieldInfoPtr_m_Samples);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FrameTimeSample>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FrameTimeSampleHistory.NativeFieldInfoPtr_m_Samples), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x06000799 RID: 1945 RVA: 0x0002A364 File Offset: 0x00028564
		// (set) Token: 0x0600079A RID: 1946 RVA: 0x00005057 File Offset: 0x00003257
		public unsafe FrameTimeSample SampleAverage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FrameTimeSampleHistory.NativeFieldInfoPtr_SampleAverage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FrameTimeSampleHistory.NativeFieldInfoPtr_SampleAverage)) = value;
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x0600079B RID: 1947 RVA: 0x0002A38C File Offset: 0x0002858C
		// (set) Token: 0x0600079C RID: 1948 RVA: 0x00005072 File Offset: 0x00003272
		public unsafe FrameTimeSample SampleMin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FrameTimeSampleHistory.NativeFieldInfoPtr_SampleMin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FrameTimeSampleHistory.NativeFieldInfoPtr_SampleMin)) = value;
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x0600079D RID: 1949 RVA: 0x0002A3B4 File Offset: 0x000285B4
		// (set) Token: 0x0600079E RID: 1950 RVA: 0x0000508D File Offset: 0x0000328D
		public unsafe FrameTimeSample SampleMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FrameTimeSampleHistory.NativeFieldInfoPtr_SampleMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FrameTimeSampleHistory.NativeFieldInfoPtr_SampleMax)) = value;
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x0600079F RID: 1951 RVA: 0x0002A3DC File Offset: 0x000285DC
		// (set) Token: 0x060007A0 RID: 1952 RVA: 0x000050A8 File Offset: 0x000032A8
		public unsafe static Func<float, float, float> s_SampleValueAdd
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FrameTimeSampleHistory.NativeFieldInfoPtr_s_SampleValueAdd, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float, float, float>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FrameTimeSampleHistory.NativeFieldInfoPtr_s_SampleValueAdd, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x060007A1 RID: 1953 RVA: 0x0002A404 File Offset: 0x00028604
		// (set) Token: 0x060007A2 RID: 1954 RVA: 0x000050BA File Offset: 0x000032BA
		public unsafe static Func<float, float, float> s_SampleValueMin
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FrameTimeSampleHistory.NativeFieldInfoPtr_s_SampleValueMin, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float, float, float>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FrameTimeSampleHistory.NativeFieldInfoPtr_s_SampleValueMin, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x060007A3 RID: 1955 RVA: 0x0002A42C File Offset: 0x0002862C
		// (set) Token: 0x060007A4 RID: 1956 RVA: 0x000050CC File Offset: 0x000032CC
		public unsafe static Func<float, float, float> s_SampleValueMax
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FrameTimeSampleHistory.NativeFieldInfoPtr_s_SampleValueMax, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float, float, float>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FrameTimeSampleHistory.NativeFieldInfoPtr_s_SampleValueMax, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x060007A5 RID: 1957 RVA: 0x0002A454 File Offset: 0x00028654
		// (set) Token: 0x060007A6 RID: 1958 RVA: 0x000050DE File Offset: 0x000032DE
		public unsafe static Func<float, float, float> s_SampleValueCountValid
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FrameTimeSampleHistory.NativeFieldInfoPtr_s_SampleValueCountValid, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float, float, float>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FrameTimeSampleHistory.NativeFieldInfoPtr_s_SampleValueCountValid, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x060007A7 RID: 1959 RVA: 0x0002A47C File Offset: 0x0002867C
		// (set) Token: 0x060007A8 RID: 1960 RVA: 0x000050F0 File Offset: 0x000032F0
		public unsafe static Func<float, float, float> s_SampleValueEnsureValid
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FrameTimeSampleHistory.NativeFieldInfoPtr_s_SampleValueEnsureValid, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float, float, float>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FrameTimeSampleHistory.NativeFieldInfoPtr_s_SampleValueEnsureValid, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x060007A9 RID: 1961 RVA: 0x0002A4A4 File Offset: 0x000286A4
		// (set) Token: 0x060007AA RID: 1962 RVA: 0x00005102 File Offset: 0x00003302
		public unsafe static Func<float, float, float> s_SampleValueDivide
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FrameTimeSampleHistory.NativeFieldInfoPtr_s_SampleValueDivide, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float, float, float>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FrameTimeSampleHistory.NativeFieldInfoPtr_s_SampleValueDivide, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005A8 RID: 1448
		private static readonly IntPtr NativeFieldInfoPtr_m_Samples;

		// Token: 0x040005A9 RID: 1449
		private static readonly IntPtr NativeFieldInfoPtr_SampleAverage;

		// Token: 0x040005AA RID: 1450
		private static readonly IntPtr NativeFieldInfoPtr_SampleMin;

		// Token: 0x040005AB RID: 1451
		private static readonly IntPtr NativeFieldInfoPtr_SampleMax;

		// Token: 0x040005AC RID: 1452
		private static readonly IntPtr NativeFieldInfoPtr_s_SampleValueAdd;

		// Token: 0x040005AD RID: 1453
		private static readonly IntPtr NativeFieldInfoPtr_s_SampleValueMin;

		// Token: 0x040005AE RID: 1454
		private static readonly IntPtr NativeFieldInfoPtr_s_SampleValueMax;

		// Token: 0x040005AF RID: 1455
		private static readonly IntPtr NativeFieldInfoPtr_s_SampleValueCountValid;

		// Token: 0x040005B0 RID: 1456
		private static readonly IntPtr NativeFieldInfoPtr_s_SampleValueEnsureValid;

		// Token: 0x040005B1 RID: 1457
		private static readonly IntPtr NativeFieldInfoPtr_s_SampleValueDivide;

		// Token: 0x040005B2 RID: 1458
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040005B3 RID: 1459
		private static readonly IntPtr NativeMethodInfoPtr_Add_Internal_Void_FrameTimeSample_0;

		// Token: 0x040005B4 RID: 1460
		private static readonly IntPtr NativeMethodInfoPtr_ComputeAggregateValues_Internal_Void_0;

		// Token: 0x040005B5 RID: 1461
		private static readonly IntPtr NativeMethodInfoPtr_DiscardOldSamples_Internal_Void_Int32_0;

		// Token: 0x040005B6 RID: 1462
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Internal_Void_0;

		// Token: 0x040005B7 RID: 1463
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_byref_FrameTimeSample_FrameTimeSample_Func_3_Single_Single_Single_PDM_0;

		// Token: 0x020001B4 RID: 436
		[ObfuscatedName("UnityEngine.Rendering.FrameTimeSampleHistory+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600183F RID: 6207 RVA: 0x00066E6C File Offset: 0x0006506C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<FrameTimeSampleHistory.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FrameTimeSampleHistory>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FrameTimeSampleHistory.__c>.NativeClassPtr);
				FrameTimeSampleHistory.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTimeSampleHistory.__c>.NativeClassPtr, "<>9");
				FrameTimeSampleHistory.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameTimeSampleHistory.__c>.NativeClassPtr, 100664513);
				FrameTimeSampleHistory.__c.NativeMethodInfoPtr___cctor_b__15_0_Internal_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameTimeSampleHistory.__c>.NativeClassPtr, 100664514);
				FrameTimeSampleHistory.__c.NativeMethodInfoPtr___cctor_b__15_1_Internal_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameTimeSampleHistory.__c>.NativeClassPtr, 100664515);
				FrameTimeSampleHistory.__c.NativeMethodInfoPtr___cctor_b__15_2_Internal_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameTimeSampleHistory.__c>.NativeClassPtr, 100664516);
				FrameTimeSampleHistory.__c.NativeMethodInfoPtr___cctor_b__15_3_Internal_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameTimeSampleHistory.__c>.NativeClassPtr, 100664517);
				FrameTimeSampleHistory.__c.NativeMethodInfoPtr___cctor_b__15_4_Internal_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameTimeSampleHistory.__c>.NativeClassPtr, 100664518);
				FrameTimeSampleHistory.__c.NativeMethodInfoPtr___cctor_b__15_5_Internal_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameTimeSampleHistory.__c>.NativeClassPtr, 100664519);
			}

			// Token: 0x06001840 RID: 6208 RVA: 0x00066F38 File Offset: 0x00065138
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FrameTimeSampleHistory.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FrameTimeSampleHistory.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001841 RID: 6209 RVA: 0x00066F74 File Offset: 0x00065174
			[CallerCount(0)]
			public unsafe float __cctor_b__15_0(float value, float other)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FrameTimeSampleHistory.__c.NativeMethodInfoPtr___cctor_b__15_0_Internal_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001842 RID: 6210 RVA: 0x00066FCC File Offset: 0x000651CC
			[CallerCount(0)]
			public unsafe float __cctor_b__15_1(float value, float other)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FrameTimeSampleHistory.__c.NativeMethodInfoPtr___cctor_b__15_1_Internal_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001843 RID: 6211 RVA: 0x00067024 File Offset: 0x00065224
			[CallerCount(0)]
			public unsafe float __cctor_b__15_2(float value, float other)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FrameTimeSampleHistory.__c.NativeMethodInfoPtr___cctor_b__15_2_Internal_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001844 RID: 6212 RVA: 0x0006707C File Offset: 0x0006527C
			[CallerCount(0)]
			public unsafe float __cctor_b__15_3(float value, float other)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FrameTimeSampleHistory.__c.NativeMethodInfoPtr___cctor_b__15_3_Internal_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001845 RID: 6213 RVA: 0x000670D4 File Offset: 0x000652D4
			[CallerCount(0)]
			public unsafe float __cctor_b__15_4(float value, float other)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FrameTimeSampleHistory.__c.NativeMethodInfoPtr___cctor_b__15_4_Internal_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001846 RID: 6214 RVA: 0x0006712C File Offset: 0x0006532C
			[CallerCount(0)]
			public unsafe float __cctor_b__15_5(float value, float other)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FrameTimeSampleHistory.__c.NativeMethodInfoPtr___cctor_b__15_5_Internal_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001847 RID: 6215 RVA: 0x0000C0FB File Offset: 0x0000A2FB
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006D3 RID: 1747
			// (get) Token: 0x06001848 RID: 6216 RVA: 0x00067184 File Offset: 0x00065384
			// (set) Token: 0x06001849 RID: 6217 RVA: 0x0000C104 File Offset: 0x0000A304
			public unsafe static FrameTimeSampleHistory.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FrameTimeSampleHistory.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FrameTimeSampleHistory.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FrameTimeSampleHistory.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001180 RID: 4480
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001181 RID: 4481
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001182 RID: 4482
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__15_0_Internal_Single_Single_Single_0;

			// Token: 0x04001183 RID: 4483
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__15_1_Internal_Single_Single_Single_0;

			// Token: 0x04001184 RID: 4484
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__15_2_Internal_Single_Single_Single_0;

			// Token: 0x04001185 RID: 4485
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__15_3_Internal_Single_Single_Single_0;

			// Token: 0x04001186 RID: 4486
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__15_4_Internal_Single_Single_Single_0;

			// Token: 0x04001187 RID: 4487
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__15_5_Internal_Single_Single_Single_0;
		}
	}
}
