using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Concurrent;

namespace dwd.core.networking
{
	// Token: 0x02000125 RID: 293
	public sealed class AverageIntFromSamples : Object
	{
		// Token: 0x06001072 RID: 4210 RVA: 0x00055078 File Offset: 0x00053278
		// Note: this type is marked as 'beforefieldinit'.
		static AverageIntFromSamples()
		{
			Il2CppClassPointerStore<AverageIntFromSamples>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.networking", "AverageIntFromSamples");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AverageIntFromSamples>.NativeClassPtr);
			AverageIntFromSamples.NativeFieldInfoPtr_samples = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AverageIntFromSamples>.NativeClassPtr, "samples");
			AverageIntFromSamples.NativeFieldInfoPtr_sampleCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AverageIntFromSamples>.NativeClassPtr, "sampleCount");
			AverageIntFromSamples.NativeFieldInfoPtr_sum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AverageIntFromSamples>.NativeClassPtr, "sum");
			AverageIntFromSamples.NativeFieldInfoPtr__Average_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AverageIntFromSamples>.NativeClassPtr, "<Average>k__BackingField");
			AverageIntFromSamples.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AverageIntFromSamples>.NativeClassPtr, 100665703);
			AverageIntFromSamples.NativeMethodInfoPtr_Add_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AverageIntFromSamples>.NativeClassPtr, 100665704);
			AverageIntFromSamples.NativeMethodInfoPtr_get_Average_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AverageIntFromSamples>.NativeClassPtr, 100665705);
			AverageIntFromSamples.NativeMethodInfoPtr_set_Average_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AverageIntFromSamples>.NativeClassPtr, 100665706);
			AverageIntFromSamples.NativeMethodInfoPtr_GetArray_Public_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AverageIntFromSamples>.NativeClassPtr, 100665707);
		}

		// Token: 0x06001073 RID: 4211 RVA: 0x0005515C File Offset: 0x0005335C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 869801, XrefRangeEnd = 869809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AverageIntFromSamples(uint sampleCount)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AverageIntFromSamples>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sampleCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AverageIntFromSamples.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001074 RID: 4212 RVA: 0x000551A4 File Offset: 0x000533A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 869836, RefRangeEnd = 869837, XrefRangeStart = 869809, XrefRangeEnd = 869836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(int sample)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sample;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AverageIntFromSamples.NativeMethodInfoPtr_Add_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x06001075 RID: 4213 RVA: 0x000551E4 File Offset: 0x000533E4
		// (set) Token: 0x06001076 RID: 4214 RVA: 0x00055220 File Offset: 0x00053420
		public unsafe int Average
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AverageIntFromSamples.NativeMethodInfoPtr_get_Average_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 287294, RefRangeEnd = 287297, XrefRangeStart = 287294, XrefRangeEnd = 287297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AverageIntFromSamples.NativeMethodInfoPtr_set_Average_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001077 RID: 4215 RVA: 0x00055260 File Offset: 0x00053460
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 869837, XrefRangeEnd = 869841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<int> GetArray()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AverageIntFromSamples.NativeMethodInfoPtr_GetArray_Public_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
		}

		// Token: 0x06001078 RID: 4216 RVA: 0x00007A9A File Offset: 0x00005C9A
		public AverageIntFromSamples(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x06001079 RID: 4217 RVA: 0x000552A0 File Offset: 0x000534A0
		// (set) Token: 0x0600107A RID: 4218 RVA: 0x00007AA3 File Offset: 0x00005CA3
		public unsafe ConcurrentQueue<int> samples
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AverageIntFromSamples.NativeFieldInfoPtr_samples);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConcurrentQueue<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AverageIntFromSamples.NativeFieldInfoPtr_samples), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x0600107B RID: 4219 RVA: 0x000552D0 File Offset: 0x000534D0
		// (set) Token: 0x0600107C RID: 4220 RVA: 0x00007AC2 File Offset: 0x00005CC2
		public unsafe uint sampleCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AverageIntFromSamples.NativeFieldInfoPtr_sampleCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AverageIntFromSamples.NativeFieldInfoPtr_sampleCount)) = value;
			}
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x0600107D RID: 4221 RVA: 0x000552F8 File Offset: 0x000534F8
		// (set) Token: 0x0600107E RID: 4222 RVA: 0x00007ADD File Offset: 0x00005CDD
		public unsafe int sum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AverageIntFromSamples.NativeFieldInfoPtr_sum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AverageIntFromSamples.NativeFieldInfoPtr_sum)) = value;
			}
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x0600107F RID: 4223 RVA: 0x00055320 File Offset: 0x00053520
		// (set) Token: 0x06001080 RID: 4224 RVA: 0x00007AF8 File Offset: 0x00005CF8
		public unsafe int _Average_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AverageIntFromSamples.NativeFieldInfoPtr__Average_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AverageIntFromSamples.NativeFieldInfoPtr__Average_k__BackingField)) = value;
			}
		}

		// Token: 0x04000BB5 RID: 2997
		private static readonly IntPtr NativeFieldInfoPtr_samples;

		// Token: 0x04000BB6 RID: 2998
		private static readonly IntPtr NativeFieldInfoPtr_sampleCount;

		// Token: 0x04000BB7 RID: 2999
		private static readonly IntPtr NativeFieldInfoPtr_sum;

		// Token: 0x04000BB8 RID: 3000
		private static readonly IntPtr NativeFieldInfoPtr__Average_k__BackingField;

		// Token: 0x04000BB9 RID: 3001
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x04000BBA RID: 3002
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_Int32_0;

		// Token: 0x04000BBB RID: 3003
		private static readonly IntPtr NativeMethodInfoPtr_get_Average_Public_get_Int32_0;

		// Token: 0x04000BBC RID: 3004
		private static readonly IntPtr NativeMethodInfoPtr_set_Average_Private_set_Void_Int32_0;

		// Token: 0x04000BBD RID: 3005
		private static readonly IntPtr NativeMethodInfoPtr_GetArray_Public_Il2CppStructArray_1_Int32_0;
	}
}
