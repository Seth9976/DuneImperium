using System;
using System.Runtime.InteropServices;
using Canis.mathLib.intersections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.mathLib
{
	// Token: 0x02000077 RID: 119
	[StructLayout(2)]
	public struct Line
	{
		// Token: 0x06000672 RID: 1650 RVA: 0x0003315C File Offset: 0x0003135C
		// Note: this type is marked as 'beforefieldinit'.
		static Line()
		{
			Il2CppClassPointerStore<Line>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.mathLib", "Line");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Line>.NativeClassPtr);
			Line.NativeFieldInfoPtr_Point1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Line>.NativeClassPtr, "Point1");
			Line.NativeFieldInfoPtr_Point2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Line>.NativeClassPtr, "Point2");
			Line.NativeFieldInfoPtr_Span = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Line>.NativeClassPtr, "Span");
			Line.NativeMethodInfoPtr__ctor_Private_Void_DwdVector2Floating_DwdVector2Floating_DwdVector2Floating_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Line>.NativeClassPtr, 100664627);
			Line.NativeMethodInfoPtr_FromPoints_Public_Static_Line_DwdVector2Floating_DwdVector2Floating_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Line>.NativeClassPtr, 100664628);
			Line.NativeMethodInfoPtr_FromSpan_Public_Static_Line_DwdVector2Floating_DwdVector2Floating_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Line>.NativeClassPtr, 100664629);
			Line.NativeMethodInfoPtr_op_Addition_Public_Static_Line_Line_DwdVector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Line>.NativeClassPtr, 100664630);
			Line.NativeMethodInfoPtr_op_Addition_Public_Static_Line_Line_DwdVector2Floating_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Line>.NativeClassPtr, 100664631);
			Line.NativeMethodInfoPtr_op_Subtraction_Public_Static_Line_Line_DwdVector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Line>.NativeClassPtr, 100664632);
			Line.NativeMethodInfoPtr_op_Subtraction_Public_Static_Line_Line_DwdVector2Floating_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Line>.NativeClassPtr, 100664633);
			Line.NativeMethodInfoPtr_Intersects_Public_Boolean_byref_Line_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Line>.NativeClassPtr, 100664634);
			Line.NativeMethodInfoPtr_Intersection_Public_IIntersection_byref_Line_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Line>.NativeClassPtr, 100664635);
			Line.NativeMethodInfoPtr_IntersectionWithInfo_Private_ValueTuple_3_IIntersection_DwdVector2Floating_Double_byref_Line_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Line>.NativeClassPtr, 100664636);
			Line.NativeMethodInfoPtr_Intersects_Public_Boolean_byref_Ray_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Line>.NativeClassPtr, 100664637);
			Line.NativeMethodInfoPtr_Intersection_Public_IIntersection_byref_Ray_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Line>.NativeClassPtr, 100664638);
			Line.NativeMethodInfoPtr_Intersects_Public_Boolean_byref_Segment_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Line>.NativeClassPtr, 100664639);
			Line.NativeMethodInfoPtr_Intersection_Public_IIntersection_byref_Segment_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Line>.NativeClassPtr, 100664640);
			Line.NativeMethodInfoPtr_Intersects_Public_Boolean_byref_DwdVector2Floating_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Line>.NativeClassPtr, 100664641);
			Line.NativeMethodInfoPtr_Intersection_Public_IIntersection_byref_DwdVector2Floating_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Line>.NativeClassPtr, 100664642);
			Line.NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Line__Intersects_Private_Virtual_Final_New_Boolean_byref_Line_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Line>.NativeClassPtr, 100664643);
			Line.NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Line__Intersection_Private_Virtual_Final_New_IIntersection_byref_Line_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Line>.NativeClassPtr, 100664644);
			Line.NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Ray__Intersects_Private_Virtual_Final_New_Boolean_byref_Ray_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Line>.NativeClassPtr, 100664645);
			Line.NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Ray__Intersection_Private_Virtual_Final_New_IIntersection_byref_Ray_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Line>.NativeClassPtr, 100664646);
			Line.NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Segment__Intersects_Private_Virtual_Final_New_Boolean_byref_Segment_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Line>.NativeClassPtr, 100664647);
			Line.NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Segment__Intersection_Private_Virtual_Final_New_IIntersection_byref_Segment_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Line>.NativeClassPtr, 100664648);
			Line.NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_DwdVector2Floating__Intersects_Private_Virtual_Final_New_Boolean_byref_DwdVector2Floating_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Line>.NativeClassPtr, 100664649);
			Line.NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_DwdVector2Floating__Intersection_Private_Virtual_Final_New_IIntersection_byref_DwdVector2Floating_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Line>.NativeClassPtr, 100664650);
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x000333A8 File Offset: 0x000315A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 556238, RefRangeEnd = 556240, XrefRangeStart = 556238, XrefRangeEnd = 556238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Line(DwdVector2Floating point1, DwdVector2Floating point2, DwdVector2Floating span)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref point1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref point2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref span;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Line.NativeMethodInfoPtr__ctor_Private_Void_DwdVector2Floating_DwdVector2Floating_DwdVector2Floating_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x000333F8 File Offset: 0x000315F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 556240, RefRangeEnd = 556242, XrefRangeStart = 556240, XrefRangeEnd = 556240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Line FromPoints(DwdVector2Floating point1, DwdVector2Floating point2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref point1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref point2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Line.NativeMethodInfoPtr_FromPoints_Public_Static_Line_DwdVector2Floating_DwdVector2Floating_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x00033444 File Offset: 0x00031644
		[CallerCount(0)]
		public unsafe static Line FromSpan(DwdVector2Floating point, DwdVector2Floating span)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref point;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref span;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Line.NativeMethodInfoPtr_FromSpan_Public_Static_Line_DwdVector2Floating_DwdVector2Floating_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x00033490 File Offset: 0x00031690
		[CallerCount(0)]
		public unsafe static Line operator +(Line segment, DwdVector2 vector)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref segment;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vector;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Line.NativeMethodInfoPtr_op_Addition_Public_Static_Line_Line_DwdVector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x000334DC File Offset: 0x000316DC
		[CallerCount(0)]
		public unsafe static Line operator +(Line segment, DwdVector2Floating vector)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref segment;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vector;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Line.NativeMethodInfoPtr_op_Addition_Public_Static_Line_Line_DwdVector2Floating_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x00033528 File Offset: 0x00031728
		[CallerCount(0)]
		public unsafe static Line operator -(Line segment, DwdVector2 vector)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref segment;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vector;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Line.NativeMethodInfoPtr_op_Subtraction_Public_Static_Line_Line_DwdVector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000679 RID: 1657 RVA: 0x00033574 File Offset: 0x00031774
		[CallerCount(0)]
		public unsafe static Line operator -(Line segment, DwdVector2Floating vector)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref segment;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vector;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Line.NativeMethodInfoPtr_op_Subtraction_Public_Static_Line_Line_DwdVector2Floating_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x000335C0 File Offset: 0x000317C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 556248, RefRangeEnd = 556249, XrefRangeStart = 556242, XrefRangeEnd = 556248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Intersects([In] ref Line line, IntersectionDimension dimension = IntersectionDimension.Area)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &line;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dimension;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Line.NativeMethodInfoPtr_Intersects_Public_Boolean_byref_Line_IntersectionDimension_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600067B RID: 1659 RVA: 0x0003360C File Offset: 0x0003180C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 556249, XrefRangeEnd = 556250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IIntersection Intersection([In] ref Line line, IntersectionDimension dimension = IntersectionDimension.Area)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &line;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dimension;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Line.NativeMethodInfoPtr_Intersection_Public_IIntersection_byref_Line_IntersectionDimension_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IIntersection>(intPtr3) : null;
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x0003365C File Offset: 0x0003185C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 556270, RefRangeEnd = 556274, XrefRangeStart = 556250, XrefRangeEnd = 556270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTuple<IIntersection, DwdVector2Floating, double> IntersectionWithInfo([In] ref Line line)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &line;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Line.NativeMethodInfoPtr_IntersectionWithInfo_Private_ValueTuple_3_IIntersection_DwdVector2Floating_Double_byref_Line_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ValueTuple<IIntersection, DwdVector2Floating, double>(intPtr);
			}
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x00033694 File Offset: 0x00031894
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 556274, XrefRangeEnd = 556279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Intersects([In] ref Ray ray, IntersectionDimension dimension = IntersectionDimension.Area)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ray;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dimension;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Line.NativeMethodInfoPtr_Intersects_Public_Boolean_byref_Ray_IntersectionDimension_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x000336E0 File Offset: 0x000318E0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 556291, RefRangeEnd = 556295, XrefRangeStart = 556279, XrefRangeEnd = 556291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IIntersection Intersection([In] ref Ray ray, IntersectionDimension dimension = IntersectionDimension.Area)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ray;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dimension;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Line.NativeMethodInfoPtr_Intersection_Public_IIntersection_byref_Ray_IntersectionDimension_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IIntersection>(intPtr3) : null;
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x00033730 File Offset: 0x00031930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 556295, XrefRangeEnd = 556300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Intersects([In] ref Segment segment, IntersectionDimension dimension = IntersectionDimension.Area)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &segment;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dimension;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Line.NativeMethodInfoPtr_Intersects_Public_Boolean_byref_Segment_IntersectionDimension_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x0003377C File Offset: 0x0003197C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 556307, RefRangeEnd = 556311, XrefRangeStart = 556300, XrefRangeEnd = 556307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IIntersection Intersection([In] ref Segment segment, IntersectionDimension dimension = IntersectionDimension.Area)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &segment;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dimension;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Line.NativeMethodInfoPtr_Intersection_Public_IIntersection_byref_Segment_IntersectionDimension_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IIntersection>(intPtr3) : null;
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x000337CC File Offset: 0x000319CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 556314, RefRangeEnd = 556316, XrefRangeStart = 556311, XrefRangeEnd = 556314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Intersects([In] ref DwdVector2Floating point, IntersectionDimension dimension = IntersectionDimension.Area)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &point;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dimension;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Line.NativeMethodInfoPtr_Intersects_Public_Boolean_byref_DwdVector2Floating_IntersectionDimension_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x00033818 File Offset: 0x00031A18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 556326, RefRangeEnd = 556327, XrefRangeStart = 556316, XrefRangeEnd = 556326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IIntersection Intersection([In] ref DwdVector2Floating point, IntersectionDimension dimension = IntersectionDimension.Area)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &point;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dimension;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Line.NativeMethodInfoPtr_Intersection_Public_IIntersection_byref_DwdVector2Floating_IntersectionDimension_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IIntersection>(intPtr3) : null;
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x00033868 File Offset: 0x00031A68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 556327, XrefRangeEnd = 556328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Line__Intersects([In] ref Line geometry, IntersectionDimension dimension)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &geometry;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dimension;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Line.NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Line__Intersects_Private_Virtual_Final_New_Boolean_byref_Line_IntersectionDimension_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x000338B4 File Offset: 0x00031AB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IIntersection Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Line__Intersection([In] ref Line geometry, IntersectionDimension dimension)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &geometry;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dimension;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Line.NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Line__Intersection_Private_Virtual_Final_New_IIntersection_byref_Line_IntersectionDimension_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IIntersection>(intPtr3) : null;
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x00033904 File Offset: 0x00031B04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Ray__Intersects([In] ref Ray geometry, IntersectionDimension dimension)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &geometry;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dimension;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Line.NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Ray__Intersects_Private_Virtual_Final_New_Boolean_byref_Ray_IntersectionDimension_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x00033950 File Offset: 0x00031B50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 556328, XrefRangeEnd = 556329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IIntersection Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Ray__Intersection([In] ref Ray geometry, IntersectionDimension dimension)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &geometry;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dimension;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Line.NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Ray__Intersection_Private_Virtual_Final_New_IIntersection_byref_Ray_IntersectionDimension_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IIntersection>(intPtr3) : null;
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x000339A0 File Offset: 0x00031BA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Segment__Intersects([In] ref Segment geometry, IntersectionDimension dimension)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &geometry;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dimension;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Line.NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Segment__Intersects_Private_Virtual_Final_New_Boolean_byref_Segment_IntersectionDimension_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x000339EC File Offset: 0x00031BEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 556329, XrefRangeEnd = 556330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IIntersection Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Segment__Intersection([In] ref Segment geometry, IntersectionDimension dimension)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &geometry;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dimension;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Line.NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Segment__Intersection_Private_Virtual_Final_New_IIntersection_byref_Segment_IntersectionDimension_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IIntersection>(intPtr3) : null;
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x00033A3C File Offset: 0x00031C3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 556330, XrefRangeEnd = 556331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_DwdVector2Floating__Intersects([In] ref DwdVector2Floating geometry, IntersectionDimension dimension)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &geometry;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dimension;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Line.NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_DwdVector2Floating__Intersects_Private_Virtual_Final_New_Boolean_byref_DwdVector2Floating_IntersectionDimension_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x00033A88 File Offset: 0x00031C88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 556331, XrefRangeEnd = 556332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IIntersection Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_DwdVector2Floating__Intersection([In] ref DwdVector2Floating geometry, IntersectionDimension dimension)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &geometry;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dimension;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Line.NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_DwdVector2Floating__Intersection_Private_Virtual_Final_New_IIntersection_byref_DwdVector2Floating_IntersectionDimension_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IIntersection>(intPtr3) : null;
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x00004998 File Offset: 0x00002B98
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Line>.NativeClassPtr, ref this));
		}

		// Token: 0x04000451 RID: 1105
		private static readonly IntPtr NativeFieldInfoPtr_Point1;

		// Token: 0x04000452 RID: 1106
		private static readonly IntPtr NativeFieldInfoPtr_Point2;

		// Token: 0x04000453 RID: 1107
		private static readonly IntPtr NativeFieldInfoPtr_Span;

		// Token: 0x04000454 RID: 1108
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_DwdVector2Floating_DwdVector2Floating_DwdVector2Floating_0;

		// Token: 0x04000455 RID: 1109
		private static readonly IntPtr NativeMethodInfoPtr_FromPoints_Public_Static_Line_DwdVector2Floating_DwdVector2Floating_0;

		// Token: 0x04000456 RID: 1110
		private static readonly IntPtr NativeMethodInfoPtr_FromSpan_Public_Static_Line_DwdVector2Floating_DwdVector2Floating_0;

		// Token: 0x04000457 RID: 1111
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_Line_Line_DwdVector2_0;

		// Token: 0x04000458 RID: 1112
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_Line_Line_DwdVector2Floating_0;

		// Token: 0x04000459 RID: 1113
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_Line_Line_DwdVector2_0;

		// Token: 0x0400045A RID: 1114
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_Line_Line_DwdVector2Floating_0;

		// Token: 0x0400045B RID: 1115
		private static readonly IntPtr NativeMethodInfoPtr_Intersects_Public_Boolean_byref_Line_IntersectionDimension_0;

		// Token: 0x0400045C RID: 1116
		private static readonly IntPtr NativeMethodInfoPtr_Intersection_Public_IIntersection_byref_Line_IntersectionDimension_0;

		// Token: 0x0400045D RID: 1117
		private static readonly IntPtr NativeMethodInfoPtr_IntersectionWithInfo_Private_ValueTuple_3_IIntersection_DwdVector2Floating_Double_byref_Line_0;

		// Token: 0x0400045E RID: 1118
		private static readonly IntPtr NativeMethodInfoPtr_Intersects_Public_Boolean_byref_Ray_IntersectionDimension_0;

		// Token: 0x0400045F RID: 1119
		private static readonly IntPtr NativeMethodInfoPtr_Intersection_Public_IIntersection_byref_Ray_IntersectionDimension_0;

		// Token: 0x04000460 RID: 1120
		private static readonly IntPtr NativeMethodInfoPtr_Intersects_Public_Boolean_byref_Segment_IntersectionDimension_0;

		// Token: 0x04000461 RID: 1121
		private static readonly IntPtr NativeMethodInfoPtr_Intersection_Public_IIntersection_byref_Segment_IntersectionDimension_0;

		// Token: 0x04000462 RID: 1122
		private static readonly IntPtr NativeMethodInfoPtr_Intersects_Public_Boolean_byref_DwdVector2Floating_IntersectionDimension_0;

		// Token: 0x04000463 RID: 1123
		private static readonly IntPtr NativeMethodInfoPtr_Intersection_Public_IIntersection_byref_DwdVector2Floating_IntersectionDimension_0;

		// Token: 0x04000464 RID: 1124
		private static readonly IntPtr NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Line__Intersects_Private_Virtual_Final_New_Boolean_byref_Line_IntersectionDimension_0;

		// Token: 0x04000465 RID: 1125
		private static readonly IntPtr NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Line__Intersection_Private_Virtual_Final_New_IIntersection_byref_Line_IntersectionDimension_0;

		// Token: 0x04000466 RID: 1126
		private static readonly IntPtr NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Ray__Intersects_Private_Virtual_Final_New_Boolean_byref_Ray_IntersectionDimension_0;

		// Token: 0x04000467 RID: 1127
		private static readonly IntPtr NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Ray__Intersection_Private_Virtual_Final_New_IIntersection_byref_Ray_IntersectionDimension_0;

		// Token: 0x04000468 RID: 1128
		private static readonly IntPtr NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Segment__Intersects_Private_Virtual_Final_New_Boolean_byref_Segment_IntersectionDimension_0;

		// Token: 0x04000469 RID: 1129
		private static readonly IntPtr NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Segment__Intersection_Private_Virtual_Final_New_IIntersection_byref_Segment_IntersectionDimension_0;

		// Token: 0x0400046A RID: 1130
		private static readonly IntPtr NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_DwdVector2Floating__Intersects_Private_Virtual_Final_New_Boolean_byref_DwdVector2Floating_IntersectionDimension_0;

		// Token: 0x0400046B RID: 1131
		private static readonly IntPtr NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_DwdVector2Floating__Intersection_Private_Virtual_Final_New_IIntersection_byref_DwdVector2Floating_IntersectionDimension_0;

		// Token: 0x0400046C RID: 1132
		[FieldOffset(0)]
		public readonly DwdVector2Floating Point1;

		// Token: 0x0400046D RID: 1133
		[FieldOffset(16)]
		public readonly DwdVector2Floating Point2;

		// Token: 0x0400046E RID: 1134
		[FieldOffset(32)]
		public readonly DwdVector2Floating Span;
	}
}
