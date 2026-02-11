using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Collections;
using Unity.Mathematics;

namespace UnityEngine.Rendering.Universal.UTess
{
	// Token: 0x02000139 RID: 313
	public sealed class IntersectionCompare : ValueType
	{
		// Token: 0x06001A95 RID: 6805 RVA: 0x0006F6E0 File Offset: 0x0006D8E0
		// Note: this type is marked as 'beforefieldinit'.
		static IntersectionCompare()
		{
			Il2CppClassPointerStore<IntersectionCompare>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal.UTess", "IntersectionCompare");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntersectionCompare>.NativeClassPtr);
			IntersectionCompare.NativeFieldInfoPtr_points = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntersectionCompare>.NativeClassPtr, "points");
			IntersectionCompare.NativeFieldInfoPtr_edges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntersectionCompare>.NativeClassPtr, "edges");
			IntersectionCompare.NativeFieldInfoPtr_xvasort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntersectionCompare>.NativeClassPtr, "xvasort");
			IntersectionCompare.NativeFieldInfoPtr_xvbsort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntersectionCompare>.NativeClassPtr, "xvbsort");
			IntersectionCompare.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_int2_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntersectionCompare>.NativeClassPtr, 100666415);
		}

		// Token: 0x06001A96 RID: 6806 RVA: 0x0006F774 File Offset: 0x0006D974
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 629859, XrefRangeEnd = 629868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Compare(int2 a, int2 b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntersectionCompare.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_int2_int2_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A97 RID: 6807 RVA: 0x0000F060 File Offset: 0x0000D260
		public IntersectionCompare(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001A98 RID: 6808 RVA: 0x0000F069 File Offset: 0x0000D269
		public IntersectionCompare()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntersectionCompare>.NativeClassPtr))
		{
		}

		// Token: 0x1700099F RID: 2463
		// (get) Token: 0x06001A99 RID: 6809 RVA: 0x0006F7D0 File Offset: 0x0006D9D0
		// (set) Token: 0x06001A9A RID: 6810 RVA: 0x0000F07B File Offset: 0x0000D27B
		public NativeArray<double2> points
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntersectionCompare.NativeFieldInfoPtr_points);
				return new NativeArray<double2>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<double2>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntersectionCompare.NativeFieldInfoPtr_points), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<double2>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170009A0 RID: 2464
		// (get) Token: 0x06001A9B RID: 6811 RVA: 0x0006F800 File Offset: 0x0006DA00
		// (set) Token: 0x06001A9C RID: 6812 RVA: 0x0000F0A9 File Offset: 0x0000D2A9
		public NativeArray<int2> edges
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntersectionCompare.NativeFieldInfoPtr_edges);
				return new NativeArray<int2>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int2>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntersectionCompare.NativeFieldInfoPtr_edges), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int2>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170009A1 RID: 2465
		// (get) Token: 0x06001A9D RID: 6813 RVA: 0x0006F830 File Offset: 0x0006DA30
		// (set) Token: 0x06001A9E RID: 6814 RVA: 0x0000F0D7 File Offset: 0x0000D2D7
		public unsafe IntersectionCompare._xvasort_e__FixedBuffer xvasort
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntersectionCompare.NativeFieldInfoPtr_xvasort);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntersectionCompare.NativeFieldInfoPtr_xvasort)) = value;
			}
		}

		// Token: 0x170009A2 RID: 2466
		// (get) Token: 0x06001A9F RID: 6815 RVA: 0x0006F858 File Offset: 0x0006DA58
		// (set) Token: 0x06001AA0 RID: 6816 RVA: 0x0000F0F2 File Offset: 0x0000D2F2
		public unsafe IntersectionCompare._xvbsort_e__FixedBuffer xvbsort
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntersectionCompare.NativeFieldInfoPtr_xvbsort);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntersectionCompare.NativeFieldInfoPtr_xvbsort)) = value;
			}
		}

		// Token: 0x04001341 RID: 4929
		private static readonly IntPtr NativeFieldInfoPtr_points;

		// Token: 0x04001342 RID: 4930
		private static readonly IntPtr NativeFieldInfoPtr_edges;

		// Token: 0x04001343 RID: 4931
		private static readonly IntPtr NativeFieldInfoPtr_xvasort;

		// Token: 0x04001344 RID: 4932
		private static readonly IntPtr NativeFieldInfoPtr_xvbsort;

		// Token: 0x04001345 RID: 4933
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_int2_int2_0;

		// Token: 0x0200020C RID: 524
		[ObfuscatedName("UnityEngine.Rendering.Universal.UTess.IntersectionCompare+<xvasort>e__FixedBuffer")]
		[StructLayout(2)]
		public struct _xvasort_e__FixedBuffer
		{
			// Token: 0x060023B0 RID: 9136 RVA: 0x00014839 File Offset: 0x00012A39
			// Note: this type is marked as 'beforefieldinit'.
			static _xvasort_e__FixedBuffer()
			{
				Il2CppClassPointerStore<IntersectionCompare._xvasort_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IntersectionCompare>.NativeClassPtr, "<xvasort>e__FixedBuffer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntersectionCompare._xvasort_e__FixedBuffer>.NativeClassPtr);
				IntersectionCompare._xvasort_e__FixedBuffer.NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntersectionCompare._xvasort_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
			}

			// Token: 0x060023B1 RID: 9137 RVA: 0x0001486D File Offset: 0x00012A6D
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IntersectionCompare._xvasort_e__FixedBuffer>.NativeClassPtr, ref this));
			}

			// Token: 0x040018DD RID: 6365
			private static readonly IntPtr NativeFieldInfoPtr_FixedElementField;

			// Token: 0x040018DE RID: 6366
			[FieldOffset(0)]
			public double FixedElementField;
		}

		// Token: 0x0200020D RID: 525
		[ObfuscatedName("UnityEngine.Rendering.Universal.UTess.IntersectionCompare+<xvbsort>e__FixedBuffer")]
		[StructLayout(2)]
		public struct _xvbsort_e__FixedBuffer
		{
			// Token: 0x060023B2 RID: 9138 RVA: 0x0001487F File Offset: 0x00012A7F
			// Note: this type is marked as 'beforefieldinit'.
			static _xvbsort_e__FixedBuffer()
			{
				Il2CppClassPointerStore<IntersectionCompare._xvbsort_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IntersectionCompare>.NativeClassPtr, "<xvbsort>e__FixedBuffer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntersectionCompare._xvbsort_e__FixedBuffer>.NativeClassPtr);
				IntersectionCompare._xvbsort_e__FixedBuffer.NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntersectionCompare._xvbsort_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
			}

			// Token: 0x060023B3 RID: 9139 RVA: 0x000148B3 File Offset: 0x00012AB3
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IntersectionCompare._xvbsort_e__FixedBuffer>.NativeClassPtr, ref this));
			}

			// Token: 0x040018DF RID: 6367
			private static readonly IntPtr NativeFieldInfoPtr_FixedElementField;

			// Token: 0x040018E0 RID: 6368
			[FieldOffset(0)]
			public double FixedElementField;
		}
	}
}
