using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.mathLib.intersections
{
	// Token: 0x02000088 RID: 136
	[StructLayout(2)]
	public struct SegmentIntersection
	{
		// Token: 0x06000728 RID: 1832 RVA: 0x0003696C File Offset: 0x00034B6C
		// Note: this type is marked as 'beforefieldinit'.
		static SegmentIntersection()
		{
			Il2CppClassPointerStore<SegmentIntersection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.mathLib.intersections", "SegmentIntersection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SegmentIntersection>.NativeClassPtr);
			SegmentIntersection.NativeFieldInfoPtr_Segment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SegmentIntersection>.NativeClassPtr, "Segment");
			SegmentIntersection.NativeMethodInfoPtr__ctor_Public_Void_Segment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentIntersection>.NativeClassPtr, 100664773);
			SegmentIntersection.NativeMethodInfoPtr_LimitedToDimension_Public_Static_IIntersection_Segment_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentIntersection>.NativeClassPtr, 100664774);
			SegmentIntersection.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentIntersection>.NativeClassPtr, 100664775);
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x000369EC File Offset: 0x00034BEC
		[CallerCount(0)]
		public unsafe SegmentIntersection(Segment segment)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref segment;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SegmentIntersection.NativeMethodInfoPtr__ctor_Public_Void_Segment_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x00036A20 File Offset: 0x00034C20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 557168, XrefRangeEnd = 557173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IIntersection LimitedToDimension(Segment segment, IntersectionDimension dim)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref segment;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dim;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SegmentIntersection.NativeMethodInfoPtr_LimitedToDimension_Public_Static_IIntersection_Segment_IntersectionDimension_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IIntersection>(intPtr3) : null;
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x00036A70 File Offset: 0x00034C70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 557173, XrefRangeEnd = 557179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SegmentIntersection.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x00004BB1 File Offset: 0x00002DB1
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SegmentIntersection>.NativeClassPtr, ref this));
		}

		// Token: 0x040004F8 RID: 1272
		private static readonly IntPtr NativeFieldInfoPtr_Segment;

		// Token: 0x040004F9 RID: 1273
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Segment_0;

		// Token: 0x040004FA RID: 1274
		private static readonly IntPtr NativeMethodInfoPtr_LimitedToDimension_Public_Static_IIntersection_Segment_IntersectionDimension_0;

		// Token: 0x040004FB RID: 1275
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040004FC RID: 1276
		[FieldOffset(0)]
		public readonly Segment Segment;
	}
}
