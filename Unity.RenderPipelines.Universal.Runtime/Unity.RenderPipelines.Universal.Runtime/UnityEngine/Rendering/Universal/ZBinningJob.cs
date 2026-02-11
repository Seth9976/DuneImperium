using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Collections;
using Unity.Mathematics;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x020000E2 RID: 226
	public sealed class ZBinningJob : ValueType
	{
		// Token: 0x0600114D RID: 4429 RVA: 0x000519E8 File Offset: 0x0004FBE8
		// Note: this type is marked as 'beforefieldinit'.
		static ZBinningJob()
		{
			Il2CppClassPointerStore<ZBinningJob>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "ZBinningJob");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ZBinningJob>.NativeClassPtr);
			ZBinningJob.NativeFieldInfoPtr_batchSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZBinningJob>.NativeClassPtr, "batchSize");
			ZBinningJob.NativeFieldInfoPtr_headerLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZBinningJob>.NativeClassPtr, "headerLength");
			ZBinningJob.NativeFieldInfoPtr_bins = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZBinningJob>.NativeClassPtr, "bins");
			ZBinningJob.NativeFieldInfoPtr_minMaxZs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZBinningJob>.NativeClassPtr, "minMaxZs");
			ZBinningJob.NativeFieldInfoPtr_zBinScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZBinningJob>.NativeClassPtr, "zBinScale");
			ZBinningJob.NativeFieldInfoPtr_zBinOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZBinningJob>.NativeClassPtr, "zBinOffset");
			ZBinningJob.NativeFieldInfoPtr_binCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZBinningJob>.NativeClassPtr, "binCount");
			ZBinningJob.NativeFieldInfoPtr_wordsPerTile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZBinningJob>.NativeClassPtr, "wordsPerTile");
			ZBinningJob.NativeFieldInfoPtr_lightCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZBinningJob>.NativeClassPtr, "lightCount");
			ZBinningJob.NativeFieldInfoPtr_reflectionProbeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZBinningJob>.NativeClassPtr, "reflectionProbeCount");
			ZBinningJob.NativeFieldInfoPtr_batchCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZBinningJob>.NativeClassPtr, "batchCount");
			ZBinningJob.NativeFieldInfoPtr_viewCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZBinningJob>.NativeClassPtr, "viewCount");
			ZBinningJob.NativeFieldInfoPtr_isOrthographic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZBinningJob>.NativeClassPtr, "isOrthographic");
			ZBinningJob.NativeMethodInfoPtr_EncodeHeader_Private_Static_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZBinningJob>.NativeClassPtr, 100665501);
			ZBinningJob.NativeMethodInfoPtr_DecodeHeader_Private_Static_ValueTuple_2_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZBinningJob>.NativeClassPtr, 100665502);
			ZBinningJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZBinningJob>.NativeClassPtr, 100665503);
			ZBinningJob.NativeMethodInfoPtr_FillZBins_Private_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZBinningJob>.NativeClassPtr, 100665504);
		}

		// Token: 0x0600114E RID: 4430 RVA: 0x00051B6C File Offset: 0x0004FD6C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 618748, RefRangeEnd = 618750, XrefRangeStart = 618748, XrefRangeEnd = 618748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint EncodeHeader(uint min, uint max)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref min;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZBinningJob.NativeMethodInfoPtr_EncodeHeader_Private_Static_UInt32_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600114F RID: 4431 RVA: 0x00051BB8 File Offset: 0x0004FDB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 618753, RefRangeEnd = 618754, XrefRangeStart = 618750, XrefRangeEnd = 618753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ValueTuple<uint, uint> DecodeHeader(uint zBin)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref zBin;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZBinningJob.NativeMethodInfoPtr_DecodeHeader_Private_Static_ValueTuple_2_UInt32_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ValueTuple<uint, uint>(intPtr);
			}
		}

		// Token: 0x06001150 RID: 4432 RVA: 0x00051BF0 File Offset: 0x0004FDF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 618757, RefRangeEnd = 618758, XrefRangeStart = 618754, XrefRangeEnd = 618757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Execute(int jobIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref jobIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZBinningJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001151 RID: 4433 RVA: 0x00051C34 File Offset: 0x0004FE34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 618762, RefRangeEnd = 618764, XrefRangeStart = 618758, XrefRangeEnd = 618762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FillZBins(int binStart, int binEnd, int itemStart, int itemEnd, int headerIndex, int itemOffset, int binOffset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref binStart;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref binEnd;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemStart;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemEnd;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref headerIndex;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemOffset;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref binOffset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZBinningJob.NativeMethodInfoPtr_FillZBins_Private_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001152 RID: 4434 RVA: 0x0000A52E File Offset: 0x0000872E
		public ZBinningJob(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001153 RID: 4435 RVA: 0x0000A537 File Offset: 0x00008737
		public ZBinningJob()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ZBinningJob>.NativeClassPtr))
		{
		}

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x06001154 RID: 4436 RVA: 0x00051CCC File Offset: 0x0004FECC
		// (set) Token: 0x06001155 RID: 4437 RVA: 0x0000A549 File Offset: 0x00008749
		public unsafe static int batchSize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ZBinningJob.NativeFieldInfoPtr_batchSize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ZBinningJob.NativeFieldInfoPtr_batchSize, (void*)(&value));
			}
		}

		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x06001156 RID: 4438 RVA: 0x00051CE8 File Offset: 0x0004FEE8
		// (set) Token: 0x06001157 RID: 4439 RVA: 0x0000A557 File Offset: 0x00008757
		public unsafe static int headerLength
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ZBinningJob.NativeFieldInfoPtr_headerLength, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ZBinningJob.NativeFieldInfoPtr_headerLength, (void*)(&value));
			}
		}

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x06001158 RID: 4440 RVA: 0x00051D04 File Offset: 0x0004FF04
		// (set) Token: 0x06001159 RID: 4441 RVA: 0x0000A565 File Offset: 0x00008765
		public NativeArray<uint> bins
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZBinningJob.NativeFieldInfoPtr_bins);
				return new NativeArray<uint>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<uint>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZBinningJob.NativeFieldInfoPtr_bins), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<uint>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x0600115A RID: 4442 RVA: 0x00051D34 File Offset: 0x0004FF34
		// (set) Token: 0x0600115B RID: 4443 RVA: 0x0000A593 File Offset: 0x00008793
		public NativeArray<float2> minMaxZs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZBinningJob.NativeFieldInfoPtr_minMaxZs);
				return new NativeArray<float2>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float2>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZBinningJob.NativeFieldInfoPtr_minMaxZs), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float2>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x0600115C RID: 4444 RVA: 0x00051D64 File Offset: 0x0004FF64
		// (set) Token: 0x0600115D RID: 4445 RVA: 0x0000A5C1 File Offset: 0x000087C1
		public unsafe float zBinScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZBinningJob.NativeFieldInfoPtr_zBinScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZBinningJob.NativeFieldInfoPtr_zBinScale)) = value;
			}
		}

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x0600115E RID: 4446 RVA: 0x00051D8C File Offset: 0x0004FF8C
		// (set) Token: 0x0600115F RID: 4447 RVA: 0x0000A5DC File Offset: 0x000087DC
		public unsafe float zBinOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZBinningJob.NativeFieldInfoPtr_zBinOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZBinningJob.NativeFieldInfoPtr_zBinOffset)) = value;
			}
		}

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x06001160 RID: 4448 RVA: 0x00051DB4 File Offset: 0x0004FFB4
		// (set) Token: 0x06001161 RID: 4449 RVA: 0x0000A5F7 File Offset: 0x000087F7
		public unsafe int binCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZBinningJob.NativeFieldInfoPtr_binCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZBinningJob.NativeFieldInfoPtr_binCount)) = value;
			}
		}

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x06001162 RID: 4450 RVA: 0x00051DDC File Offset: 0x0004FFDC
		// (set) Token: 0x06001163 RID: 4451 RVA: 0x0000A612 File Offset: 0x00008812
		public unsafe int wordsPerTile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZBinningJob.NativeFieldInfoPtr_wordsPerTile);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZBinningJob.NativeFieldInfoPtr_wordsPerTile)) = value;
			}
		}

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x06001164 RID: 4452 RVA: 0x00051E04 File Offset: 0x00050004
		// (set) Token: 0x06001165 RID: 4453 RVA: 0x0000A62D File Offset: 0x0000882D
		public unsafe int lightCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZBinningJob.NativeFieldInfoPtr_lightCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZBinningJob.NativeFieldInfoPtr_lightCount)) = value;
			}
		}

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x06001166 RID: 4454 RVA: 0x00051E2C File Offset: 0x0005002C
		// (set) Token: 0x06001167 RID: 4455 RVA: 0x0000A648 File Offset: 0x00008848
		public unsafe int reflectionProbeCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZBinningJob.NativeFieldInfoPtr_reflectionProbeCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZBinningJob.NativeFieldInfoPtr_reflectionProbeCount)) = value;
			}
		}

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x06001168 RID: 4456 RVA: 0x00051E54 File Offset: 0x00050054
		// (set) Token: 0x06001169 RID: 4457 RVA: 0x0000A663 File Offset: 0x00008863
		public unsafe int batchCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZBinningJob.NativeFieldInfoPtr_batchCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZBinningJob.NativeFieldInfoPtr_batchCount)) = value;
			}
		}

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x0600116A RID: 4458 RVA: 0x00051E7C File Offset: 0x0005007C
		// (set) Token: 0x0600116B RID: 4459 RVA: 0x0000A67E File Offset: 0x0000887E
		public unsafe int viewCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZBinningJob.NativeFieldInfoPtr_viewCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZBinningJob.NativeFieldInfoPtr_viewCount)) = value;
			}
		}

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x0600116C RID: 4460 RVA: 0x00051EA4 File Offset: 0x000500A4
		// (set) Token: 0x0600116D RID: 4461 RVA: 0x0000A699 File Offset: 0x00008899
		public unsafe bool isOrthographic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZBinningJob.NativeFieldInfoPtr_isOrthographic);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZBinningJob.NativeFieldInfoPtr_isOrthographic)) = value;
			}
		}

		// Token: 0x04000CA9 RID: 3241
		private static readonly IntPtr NativeFieldInfoPtr_batchSize;

		// Token: 0x04000CAA RID: 3242
		private static readonly IntPtr NativeFieldInfoPtr_headerLength;

		// Token: 0x04000CAB RID: 3243
		private static readonly IntPtr NativeFieldInfoPtr_bins;

		// Token: 0x04000CAC RID: 3244
		private static readonly IntPtr NativeFieldInfoPtr_minMaxZs;

		// Token: 0x04000CAD RID: 3245
		private static readonly IntPtr NativeFieldInfoPtr_zBinScale;

		// Token: 0x04000CAE RID: 3246
		private static readonly IntPtr NativeFieldInfoPtr_zBinOffset;

		// Token: 0x04000CAF RID: 3247
		private static readonly IntPtr NativeFieldInfoPtr_binCount;

		// Token: 0x04000CB0 RID: 3248
		private static readonly IntPtr NativeFieldInfoPtr_wordsPerTile;

		// Token: 0x04000CB1 RID: 3249
		private static readonly IntPtr NativeFieldInfoPtr_lightCount;

		// Token: 0x04000CB2 RID: 3250
		private static readonly IntPtr NativeFieldInfoPtr_reflectionProbeCount;

		// Token: 0x04000CB3 RID: 3251
		private static readonly IntPtr NativeFieldInfoPtr_batchCount;

		// Token: 0x04000CB4 RID: 3252
		private static readonly IntPtr NativeFieldInfoPtr_viewCount;

		// Token: 0x04000CB5 RID: 3253
		private static readonly IntPtr NativeFieldInfoPtr_isOrthographic;

		// Token: 0x04000CB6 RID: 3254
		private static readonly IntPtr NativeMethodInfoPtr_EncodeHeader_Private_Static_UInt32_UInt32_UInt32_0;

		// Token: 0x04000CB7 RID: 3255
		private static readonly IntPtr NativeMethodInfoPtr_DecodeHeader_Private_Static_ValueTuple_2_UInt32_UInt32_UInt32_0;

		// Token: 0x04000CB8 RID: 3256
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0;

		// Token: 0x04000CB9 RID: 3257
		private static readonly IntPtr NativeMethodInfoPtr_FillZBins_Private_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0;
	}
}
