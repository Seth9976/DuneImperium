using System;
using System.Runtime.InteropServices;
using Canis.mathLib.intersections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.mathLib
{
	// Token: 0x02000071 RID: 113
	[StructLayout(2)]
	public struct Arc
	{
		// Token: 0x0600060D RID: 1549 RVA: 0x00031128 File Offset: 0x0002F328
		// Note: this type is marked as 'beforefieldinit'.
		static Arc()
		{
			Il2CppClassPointerStore<Arc>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.mathLib", "Arc");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Arc>.NativeClassPtr);
			Arc.NativeFieldInfoPtr_Circle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Arc>.NativeClassPtr, "Circle");
			Arc.NativeFieldInfoPtr_ClockwiseAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Arc>.NativeClassPtr, "ClockwiseAngle");
			Arc.NativeFieldInfoPtr_CounterClockwiseAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Arc>.NativeClassPtr, "CounterClockwiseAngle");
			Arc.NativeFieldInfoPtr_ClockwisePoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Arc>.NativeClassPtr, "ClockwisePoint");
			Arc.NativeFieldInfoPtr_CounterClockwisePoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Arc>.NativeClassPtr, "CounterClockwisePoint");
			Arc.NativeMethodInfoPtr__ctor_Public_Void_Circle_AngleRadians_AngleRadians_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Arc>.NativeClassPtr, 100664541);
			Arc.NativeMethodInfoPtr_get_Length_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Arc>.NativeClassPtr, 100664542);
			Arc.NativeMethodInfoPtr_ContainsAngle_Public_Boolean_AngleRadians_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Arc>.NativeClassPtr, 100664543);
			Arc.NativeMethodInfoPtr_Intersects_Public_Boolean_byref_DwdVector2Floating_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Arc>.NativeClassPtr, 100664544);
			Arc.NativeMethodInfoPtr_Intersection_Public_IIntersection_byref_DwdVector2Floating_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Arc>.NativeClassPtr, 100664545);
			Arc.NativeMethodInfoPtr_Intersects_Public_Boolean_byref_Line_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Arc>.NativeClassPtr, 100664546);
			Arc.NativeMethodInfoPtr_Intersection_Public_IIntersection_byref_Line_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Arc>.NativeClassPtr, 100664547);
			Arc.NativeMethodInfoPtr_InAnglesIntersection_Private_IIntersection_byref_IIntersection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Arc>.NativeClassPtr, 100664548);
			Arc.NativeMethodInfoPtr_Intersects_Public_Boolean_byref_Segment_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Arc>.NativeClassPtr, 100664549);
			Arc.NativeMethodInfoPtr_Intersection_Public_IIntersection_byref_Segment_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Arc>.NativeClassPtr, 100664550);
			Arc.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Arc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Arc>.NativeClassPtr, 100664551);
			Arc.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Arc>.NativeClassPtr, 100664552);
			Arc.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Arc>.NativeClassPtr, 100664553);
			Arc.NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Line__Intersects_Private_Virtual_Final_New_Boolean_byref_Line_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Arc>.NativeClassPtr, 100664554);
			Arc.NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Line__Intersection_Private_Virtual_Final_New_IIntersection_byref_Line_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Arc>.NativeClassPtr, 100664555);
			Arc.NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Segment__Intersects_Private_Virtual_Final_New_Boolean_byref_Segment_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Arc>.NativeClassPtr, 100664556);
			Arc.NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Segment__Intersection_Private_Virtual_Final_New_IIntersection_byref_Segment_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Arc>.NativeClassPtr, 100664557);
			Arc.NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_DwdVector2Floating__Intersects_Private_Virtual_Final_New_Boolean_byref_DwdVector2Floating_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Arc>.NativeClassPtr, 100664558);
			Arc.NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_DwdVector2Floating__Intersection_Private_Virtual_Final_New_IIntersection_byref_DwdVector2Floating_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Arc>.NativeClassPtr, 100664559);
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x00031338 File Offset: 0x0002F538
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 555924, RefRangeEnd = 555925, XrefRangeStart = 555922, XrefRangeEnd = 555924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Arc(Circle circle, AngleRadians clockwiseAngle, AngleRadians counterClockwiseAngle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref circle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clockwiseAngle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref counterClockwiseAngle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Arc.NativeMethodInfoPtr__ctor_Public_Void_Circle_AngleRadians_AngleRadians_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x0600060F RID: 1551 RVA: 0x00031388 File Offset: 0x0002F588
		public unsafe double Length
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 555925, XrefRangeEnd = 555927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Arc.NativeMethodInfoPtr_get_Length_Public_get_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x000313B8 File Offset: 0x0002F5B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 555927, XrefRangeEnd = 555931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ContainsAngle(AngleRadians angle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref angle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Arc.NativeMethodInfoPtr_ContainsAngle_Public_Boolean_AngleRadians_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x000313F8 File Offset: 0x0002F5F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 555941, RefRangeEnd = 555943, XrefRangeStart = 555931, XrefRangeEnd = 555941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Arc.NativeMethodInfoPtr_Intersects_Public_Boolean_byref_DwdVector2Floating_IntersectionDimension_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x00031444 File Offset: 0x0002F644
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 555953, RefRangeEnd = 555955, XrefRangeStart = 555943, XrefRangeEnd = 555953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Arc.NativeMethodInfoPtr_Intersection_Public_IIntersection_byref_DwdVector2Floating_IntersectionDimension_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IIntersection>(intPtr3) : null;
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x00031494 File Offset: 0x0002F694
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 555961, RefRangeEnd = 555962, XrefRangeStart = 555955, XrefRangeEnd = 555961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Arc.NativeMethodInfoPtr_Intersects_Public_Boolean_byref_Line_IntersectionDimension_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x000314E0 File Offset: 0x0002F6E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 555962, XrefRangeEnd = 555964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Arc.NativeMethodInfoPtr_Intersection_Public_IIntersection_byref_Line_IntersectionDimension_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IIntersection>(intPtr3) : null;
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x00031530 File Offset: 0x0002F730
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 555980, RefRangeEnd = 555984, XrefRangeStart = 555964, XrefRangeEnd = 555980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IIntersection InAnglesIntersection([In] ref IIntersection circularIntersection)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(circularIntersection);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Arc.NativeMethodInfoPtr_InAnglesIntersection_Private_IIntersection_byref_IIntersection_0, ref this, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				circularIntersection = ((intPtr4 == 0) ? null : new IIntersection(intPtr4));
				IntPtr intPtr5 = intPtr2;
				return (intPtr5 != 0) ? Il2CppObjectPool.Get<IIntersection>(intPtr5) : null;
			}
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x0003158C File Offset: 0x0002F78C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 555984, XrefRangeEnd = 555989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Arc.NativeMethodInfoPtr_Intersects_Public_Boolean_byref_Segment_IntersectionDimension_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x000315D8 File Offset: 0x0002F7D8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 556002, RefRangeEnd = 556006, XrefRangeStart = 555989, XrefRangeEnd = 556002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Arc.NativeMethodInfoPtr_Intersection_Public_IIntersection_byref_Segment_IntersectionDimension_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IIntersection>(intPtr3) : null;
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x00031628 File Offset: 0x0002F828
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 556012, RefRangeEnd = 556013, XrefRangeStart = 556006, XrefRangeEnd = 556012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(Arc other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Arc.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Arc_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x00031668 File Offset: 0x0002F868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 556013, XrefRangeEnd = 556017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Arc.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x000316AC File Offset: 0x0002F8AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 556017, XrefRangeEnd = 556018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Arc.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x000316DC File Offset: 0x0002F8DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 556018, XrefRangeEnd = 556019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Arc.NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Line__Intersects_Private_Virtual_Final_New_Boolean_byref_Line_IntersectionDimension_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x00031728 File Offset: 0x0002F928
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Arc.NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Line__Intersection_Private_Virtual_Final_New_IIntersection_byref_Line_IntersectionDimension_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IIntersection>(intPtr3) : null;
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x00031778 File Offset: 0x0002F978
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Arc.NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Segment__Intersects_Private_Virtual_Final_New_Boolean_byref_Segment_IntersectionDimension_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x000317C4 File Offset: 0x0002F9C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 556019, XrefRangeEnd = 556020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Arc.NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Segment__Intersection_Private_Virtual_Final_New_IIntersection_byref_Segment_IntersectionDimension_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IIntersection>(intPtr3) : null;
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x00031814 File Offset: 0x0002FA14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 556020, XrefRangeEnd = 556021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Arc.NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_DwdVector2Floating__Intersects_Private_Virtual_Final_New_Boolean_byref_DwdVector2Floating_IntersectionDimension_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x00031860 File Offset: 0x0002FA60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 556021, XrefRangeEnd = 556022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Arc.NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_DwdVector2Floating__Intersection_Private_Virtual_Final_New_IIntersection_byref_DwdVector2Floating_IntersectionDimension_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IIntersection>(intPtr3) : null;
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x00004904 File Offset: 0x00002B04
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Arc>.NativeClassPtr, ref this));
		}

		// Token: 0x040003DE RID: 990
		private static readonly IntPtr NativeFieldInfoPtr_Circle;

		// Token: 0x040003DF RID: 991
		private static readonly IntPtr NativeFieldInfoPtr_ClockwiseAngle;

		// Token: 0x040003E0 RID: 992
		private static readonly IntPtr NativeFieldInfoPtr_CounterClockwiseAngle;

		// Token: 0x040003E1 RID: 993
		private static readonly IntPtr NativeFieldInfoPtr_ClockwisePoint;

		// Token: 0x040003E2 RID: 994
		private static readonly IntPtr NativeFieldInfoPtr_CounterClockwisePoint;

		// Token: 0x040003E3 RID: 995
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Circle_AngleRadians_AngleRadians_0;

		// Token: 0x040003E4 RID: 996
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_get_Double_0;

		// Token: 0x040003E5 RID: 997
		private static readonly IntPtr NativeMethodInfoPtr_ContainsAngle_Public_Boolean_AngleRadians_0;

		// Token: 0x040003E6 RID: 998
		private static readonly IntPtr NativeMethodInfoPtr_Intersects_Public_Boolean_byref_DwdVector2Floating_IntersectionDimension_0;

		// Token: 0x040003E7 RID: 999
		private static readonly IntPtr NativeMethodInfoPtr_Intersection_Public_IIntersection_byref_DwdVector2Floating_IntersectionDimension_0;

		// Token: 0x040003E8 RID: 1000
		private static readonly IntPtr NativeMethodInfoPtr_Intersects_Public_Boolean_byref_Line_IntersectionDimension_0;

		// Token: 0x040003E9 RID: 1001
		private static readonly IntPtr NativeMethodInfoPtr_Intersection_Public_IIntersection_byref_Line_IntersectionDimension_0;

		// Token: 0x040003EA RID: 1002
		private static readonly IntPtr NativeMethodInfoPtr_InAnglesIntersection_Private_IIntersection_byref_IIntersection_0;

		// Token: 0x040003EB RID: 1003
		private static readonly IntPtr NativeMethodInfoPtr_Intersects_Public_Boolean_byref_Segment_IntersectionDimension_0;

		// Token: 0x040003EC RID: 1004
		private static readonly IntPtr NativeMethodInfoPtr_Intersection_Public_IIntersection_byref_Segment_IntersectionDimension_0;

		// Token: 0x040003ED RID: 1005
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Arc_0;

		// Token: 0x040003EE RID: 1006
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040003EF RID: 1007
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040003F0 RID: 1008
		private static readonly IntPtr NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Line__Intersects_Private_Virtual_Final_New_Boolean_byref_Line_IntersectionDimension_0;

		// Token: 0x040003F1 RID: 1009
		private static readonly IntPtr NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Line__Intersection_Private_Virtual_Final_New_IIntersection_byref_Line_IntersectionDimension_0;

		// Token: 0x040003F2 RID: 1010
		private static readonly IntPtr NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Segment__Intersects_Private_Virtual_Final_New_Boolean_byref_Segment_IntersectionDimension_0;

		// Token: 0x040003F3 RID: 1011
		private static readonly IntPtr NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Segment__Intersection_Private_Virtual_Final_New_IIntersection_byref_Segment_IntersectionDimension_0;

		// Token: 0x040003F4 RID: 1012
		private static readonly IntPtr NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_DwdVector2Floating__Intersects_Private_Virtual_Final_New_Boolean_byref_DwdVector2Floating_IntersectionDimension_0;

		// Token: 0x040003F5 RID: 1013
		private static readonly IntPtr NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_DwdVector2Floating__Intersection_Private_Virtual_Final_New_IIntersection_byref_DwdVector2Floating_IntersectionDimension_0;

		// Token: 0x040003F6 RID: 1014
		[FieldOffset(0)]
		public readonly Circle Circle;

		// Token: 0x040003F7 RID: 1015
		[FieldOffset(24)]
		public readonly AngleRadians ClockwiseAngle;

		// Token: 0x040003F8 RID: 1016
		[FieldOffset(32)]
		public readonly AngleRadians CounterClockwiseAngle;

		// Token: 0x040003F9 RID: 1017
		[FieldOffset(40)]
		public readonly DwdVector2Floating ClockwisePoint;

		// Token: 0x040003FA RID: 1018
		[FieldOffset(56)]
		public readonly DwdVector2Floating CounterClockwisePoint;
	}
}
