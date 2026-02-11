using System;
using System.Runtime.InteropServices;
using Canis.mathLib.intersections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.mathLib
{
	// Token: 0x0200007A RID: 122
	[Serializable]
	public sealed class Polygon : ValueType
	{
		// Token: 0x06000696 RID: 1686 RVA: 0x00033C8C File Offset: 0x00031E8C
		// Note: this type is marked as 'beforefieldinit'.
		static Polygon()
		{
			Il2CppClassPointerStore<Polygon>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.mathLib", "Polygon");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Polygon>.NativeClassPtr);
			Polygon.NativeFieldInfoPtr_Points = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Polygon>.NativeClassPtr, "Points");
			Polygon.NativeFieldInfoPtr_Edges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Polygon>.NativeClassPtr, "Edges");
			Polygon.NativeFieldInfoPtr_Centroid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Polygon>.NativeClassPtr, "Centroid");
			Polygon.NativeFieldInfoPtr_ArbitraryUnitVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Polygon>.NativeClassPtr, "ArbitraryUnitVector");
			Polygon.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_DwdVector2Floating_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Polygon>.NativeClassPtr, 100664653);
			Polygon.NativeMethodInfoPtr_Intersects_Public_Boolean_byref_Line_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Polygon>.NativeClassPtr, 100664654);
			Polygon.NativeMethodInfoPtr_Intersection_Public_IIntersection_byref_Line_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Polygon>.NativeClassPtr, 100664655);
			Polygon.NativeMethodInfoPtr_Intersects_Public_Boolean_byref_DwdVector2Floating_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Polygon>.NativeClassPtr, 100664656);
			Polygon.NativeMethodInfoPtr_Intersection_Public_IIntersection_byref_DwdVector2Floating_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Polygon>.NativeClassPtr, 100664657);
			Polygon.NativeMethodInfoPtr_PointInsideConvex_Private_Boolean_DwdVector2Floating_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Polygon>.NativeClassPtr, 100664658);
			Polygon.NativeMethodInfoPtr_WindingNumber_Private_Int32_DwdVector2Floating_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Polygon>.NativeClassPtr, 100664659);
			Polygon.NativeMethodInfoPtr_Intersects_Public_Boolean_byref_Segment_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Polygon>.NativeClassPtr, 100664660);
			Polygon.NativeMethodInfoPtr_Intersection_Public_IIntersection_byref_Segment_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Polygon>.NativeClassPtr, 100664661);
			Polygon.NativeMethodInfoPtr_Intersects_Public_Boolean_byref_Ray_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Polygon>.NativeClassPtr, 100664662);
			Polygon.NativeMethodInfoPtr_Intersection_Public_IIntersection_byref_Ray_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Polygon>.NativeClassPtr, 100664663);
			Polygon.NativeMethodInfoPtr_Intersects_Public_Boolean_byref_Polygon_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Polygon>.NativeClassPtr, 100664664);
			Polygon.NativeMethodInfoPtr_Intersection_Public_IIntersection_byref_Polygon_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Polygon>.NativeClassPtr, 100664665);
			Polygon.NativeMethodInfoPtr_Intersects_Public_Boolean_byref_Circle_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Polygon>.NativeClassPtr, 100664666);
			Polygon.NativeMethodInfoPtr_Intersection_Public_IIntersection_byref_Circle_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Polygon>.NativeClassPtr, 100664667);
			Polygon.NativeMethodInfoPtr_Intersects_Public_Boolean_byref_Arc_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Polygon>.NativeClassPtr, 100664668);
			Polygon.NativeMethodInfoPtr_Intersection_Public_IIntersection_byref_Arc_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Polygon>.NativeClassPtr, 100664669);
			Polygon.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Polygon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Polygon>.NativeClassPtr, 100664670);
			Polygon.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Polygon>.NativeClassPtr, 100664671);
			Polygon.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Polygon>.NativeClassPtr, 100664672);
			Polygon.NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Polygon__Intersects_Private_Virtual_Final_New_Boolean_byref_Polygon_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Polygon>.NativeClassPtr, 100664674);
			Polygon.NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Polygon__Intersection_Private_Virtual_Final_New_IIntersection_byref_Polygon_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Polygon>.NativeClassPtr, 100664675);
			Polygon.NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Line__Intersects_Private_Virtual_Final_New_Boolean_byref_Line_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Polygon>.NativeClassPtr, 100664676);
			Polygon.NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Line__Intersection_Private_Virtual_Final_New_IIntersection_byref_Line_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Polygon>.NativeClassPtr, 100664677);
			Polygon.NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Ray__Intersects_Private_Virtual_Final_New_Boolean_byref_Ray_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Polygon>.NativeClassPtr, 100664678);
			Polygon.NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Ray__Intersection_Private_Virtual_Final_New_IIntersection_byref_Ray_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Polygon>.NativeClassPtr, 100664679);
			Polygon.NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Segment__Intersects_Private_Virtual_Final_New_Boolean_byref_Segment_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Polygon>.NativeClassPtr, 100664680);
			Polygon.NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Segment__Intersection_Private_Virtual_Final_New_IIntersection_byref_Segment_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Polygon>.NativeClassPtr, 100664681);
			Polygon.NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Circle__Intersects_Private_Virtual_Final_New_Boolean_byref_Circle_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Polygon>.NativeClassPtr, 100664682);
			Polygon.NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Circle__Intersection_Private_Virtual_Final_New_IIntersection_byref_Circle_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Polygon>.NativeClassPtr, 100664683);
			Polygon.NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Arc__Intersects_Private_Virtual_Final_New_Boolean_byref_Arc_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Polygon>.NativeClassPtr, 100664684);
			Polygon.NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Arc__Intersection_Private_Virtual_Final_New_IIntersection_byref_Arc_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Polygon>.NativeClassPtr, 100664685);
			Polygon.NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_DwdVector2Floating__Intersects_Private_Virtual_Final_New_Boolean_byref_DwdVector2Floating_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Polygon>.NativeClassPtr, 100664686);
			Polygon.NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_DwdVector2Floating__Intersection_Private_Virtual_Final_New_IIntersection_byref_DwdVector2Floating_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Polygon>.NativeClassPtr, 100664687);
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x00033FB4 File Offset: 0x000321B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 556386, RefRangeEnd = 556387, XrefRangeStart = 556357, XrefRangeEnd = 556386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Polygon(Il2CppStructArray<DwdVector2Floating> points)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Polygon>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(points);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Polygon.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_DwdVector2Floating_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x00034004 File Offset: 0x00032204
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 556395, RefRangeEnd = 556396, XrefRangeStart = 556387, XrefRangeEnd = 556395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Intersects([In] ref Line line, IntersectionDimension dimension = IntersectionDimension.Area)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &line;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dimension;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Polygon.NativeMethodInfoPtr_Intersects_Public_Boolean_byref_Line_IntersectionDimension_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x00034060 File Offset: 0x00032260
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 556419, RefRangeEnd = 556423, XrefRangeStart = 556396, XrefRangeEnd = 556419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IIntersection Intersection([In] ref Line line, IntersectionDimension dimension = IntersectionDimension.Area)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &line;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dimension;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Polygon.NativeMethodInfoPtr_Intersection_Public_IIntersection_byref_Line_IntersectionDimension_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IIntersection>(intPtr3) : null;
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x000340C0 File Offset: 0x000322C0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 556427, RefRangeEnd = 556431, XrefRangeStart = 556423, XrefRangeEnd = 556427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Intersects([In] ref DwdVector2Floating point, IntersectionDimension dimension = IntersectionDimension.Area)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &point;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dimension;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Polygon.NativeMethodInfoPtr_Intersects_Public_Boolean_byref_DwdVector2Floating_IntersectionDimension_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x0003411C File Offset: 0x0003231C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 556444, RefRangeEnd = 556445, XrefRangeStart = 556431, XrefRangeEnd = 556444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IIntersection Intersection([In] ref DwdVector2Floating point, IntersectionDimension dimension = IntersectionDimension.Area)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &point;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dimension;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Polygon.NativeMethodInfoPtr_Intersection_Public_IIntersection_byref_DwdVector2Floating_IntersectionDimension_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IIntersection>(intPtr3) : null;
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x0003417C File Offset: 0x0003237C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 556447, RefRangeEnd = 556448, XrefRangeStart = 556445, XrefRangeEnd = 556447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool PointInsideConvex(DwdVector2Floating point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref point;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Polygon.NativeMethodInfoPtr_PointInsideConvex_Private_Boolean_DwdVector2Floating_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x000341CC File Offset: 0x000323CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 556448, XrefRangeEnd = 556473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int WindingNumber(DwdVector2Floating point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref point;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Polygon.NativeMethodInfoPtr_WindingNumber_Private_Int32_DwdVector2Floating_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x0003421C File Offset: 0x0003241C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 556481, RefRangeEnd = 556482, XrefRangeStart = 556473, XrefRangeEnd = 556481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Intersects([In] ref Segment segment, IntersectionDimension dimension = IntersectionDimension.Area)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &segment;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dimension;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Polygon.NativeMethodInfoPtr_Intersects_Public_Boolean_byref_Segment_IntersectionDimension_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x00034278 File Offset: 0x00032478
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 556518, RefRangeEnd = 556521, XrefRangeStart = 556482, XrefRangeEnd = 556518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IIntersection Intersection([In] ref Segment segment, IntersectionDimension dimension = IntersectionDimension.Area)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &segment;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dimension;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Polygon.NativeMethodInfoPtr_Intersection_Public_IIntersection_byref_Segment_IntersectionDimension_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IIntersection>(intPtr3) : null;
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x000342D8 File Offset: 0x000324D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 556529, RefRangeEnd = 556530, XrefRangeStart = 556521, XrefRangeEnd = 556529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Intersects([In] ref Ray ray, IntersectionDimension dimension = IntersectionDimension.Area)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ray;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dimension;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Polygon.NativeMethodInfoPtr_Intersects_Public_Boolean_byref_Ray_IntersectionDimension_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x00034334 File Offset: 0x00032534
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 556580, RefRangeEnd = 556582, XrefRangeStart = 556530, XrefRangeEnd = 556580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IIntersection Intersection([In] ref Ray ray, IntersectionDimension dimension = IntersectionDimension.Area)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ray;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dimension;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Polygon.NativeMethodInfoPtr_Intersection_Public_IIntersection_byref_Ray_IntersectionDimension_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IIntersection>(intPtr3) : null;
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x00034394 File Offset: 0x00032594
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 556590, RefRangeEnd = 556591, XrefRangeStart = 556582, XrefRangeEnd = 556590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Intersects([In] ref Polygon polygon, IntersectionDimension dimension = IntersectionDimension.Area)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(polygon);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dimension;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Polygon.NativeMethodInfoPtr_Intersects_Public_Boolean_byref_Polygon_IntersectionDimension_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x000343F8 File Offset: 0x000325F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 556616, RefRangeEnd = 556618, XrefRangeStart = 556591, XrefRangeEnd = 556616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IIntersection Intersection([In] ref Polygon polygon, IntersectionDimension dimension = IntersectionDimension.Area)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(polygon);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dimension;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Polygon.NativeMethodInfoPtr_Intersection_Public_IIntersection_byref_Polygon_IntersectionDimension_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IIntersection>(intPtr3) : null;
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x0003445C File Offset: 0x0003265C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 556626, RefRangeEnd = 556627, XrefRangeStart = 556618, XrefRangeEnd = 556626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Intersects([In] ref Circle circle, IntersectionDimension dimension = IntersectionDimension.Area)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &circle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dimension;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Polygon.NativeMethodInfoPtr_Intersects_Public_Boolean_byref_Circle_IntersectionDimension_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x000344B8 File Offset: 0x000326B8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 556652, RefRangeEnd = 556655, XrefRangeStart = 556627, XrefRangeEnd = 556652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IIntersection Intersection([In] ref Circle circle, IntersectionDimension dimension = IntersectionDimension.Area)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &circle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dimension;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Polygon.NativeMethodInfoPtr_Intersection_Public_IIntersection_byref_Circle_IntersectionDimension_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IIntersection>(intPtr3) : null;
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x00034518 File Offset: 0x00032718
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 556663, RefRangeEnd = 556664, XrefRangeStart = 556655, XrefRangeEnd = 556663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Intersects([In] ref Arc arc, IntersectionDimension dimension = IntersectionDimension.Area)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &arc;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dimension;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Polygon.NativeMethodInfoPtr_Intersects_Public_Boolean_byref_Arc_IntersectionDimension_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x00034574 File Offset: 0x00032774
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 556684, RefRangeEnd = 556686, XrefRangeStart = 556664, XrefRangeEnd = 556684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IIntersection Intersection([In] ref Arc arc, IntersectionDimension dimension = IntersectionDimension.Area)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &arc;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dimension;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Polygon.NativeMethodInfoPtr_Intersection_Public_IIntersection_byref_Arc_IntersectionDimension_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IIntersection>(intPtr3) : null;
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x000345D4 File Offset: 0x000327D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 556703, RefRangeEnd = 556704, XrefRangeStart = 556686, XrefRangeEnd = 556703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(Polygon other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Polygon.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Polygon_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x0003462C File Offset: 0x0003282C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 556704, XrefRangeEnd = 556710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Polygon.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x00034680 File Offset: 0x00032880
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Polygon.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x000346C4 File Offset: 0x000328C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 556710, XrefRangeEnd = 556714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Polygon__Intersects([In] ref Polygon geometry, IntersectionDimension dimension)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(geometry);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dimension;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Polygon.NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Polygon__Intersects_Private_Virtual_Final_New_Boolean_byref_Polygon_IntersectionDimension_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x00034728 File Offset: 0x00032928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 556714, XrefRangeEnd = 556718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IIntersection Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Polygon__Intersection([In] ref Polygon geometry, IntersectionDimension dimension)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(geometry);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dimension;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Polygon.NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Polygon__Intersection_Private_Virtual_Final_New_IIntersection_byref_Polygon_IntersectionDimension_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IIntersection>(intPtr3) : null;
		}

		// Token: 0x060006AD RID: 1709 RVA: 0x0003478C File Offset: 0x0003298C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 556718, XrefRangeEnd = 556722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Line__Intersects([In] ref Line geometry, IntersectionDimension dimension)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &geometry;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dimension;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Polygon.NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Line__Intersects_Private_Virtual_Final_New_Boolean_byref_Line_IntersectionDimension_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006AE RID: 1710 RVA: 0x000347E8 File Offset: 0x000329E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 556722, XrefRangeEnd = 556726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IIntersection Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Line__Intersection([In] ref Line geometry, IntersectionDimension dimension)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &geometry;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dimension;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Polygon.NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Line__Intersection_Private_Virtual_Final_New_IIntersection_byref_Line_IntersectionDimension_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IIntersection>(intPtr3) : null;
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x00034848 File Offset: 0x00032A48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 556726, XrefRangeEnd = 556730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Ray__Intersects([In] ref Ray geometry, IntersectionDimension dimension)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &geometry;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dimension;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Polygon.NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Ray__Intersects_Private_Virtual_Final_New_Boolean_byref_Ray_IntersectionDimension_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x000348A4 File Offset: 0x00032AA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 556730, XrefRangeEnd = 556734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IIntersection Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Ray__Intersection([In] ref Ray geometry, IntersectionDimension dimension)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &geometry;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dimension;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Polygon.NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Ray__Intersection_Private_Virtual_Final_New_IIntersection_byref_Ray_IntersectionDimension_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IIntersection>(intPtr3) : null;
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x00034904 File Offset: 0x00032B04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 556734, XrefRangeEnd = 556738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Segment__Intersects([In] ref Segment geometry, IntersectionDimension dimension)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &geometry;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dimension;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Polygon.NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Segment__Intersects_Private_Virtual_Final_New_Boolean_byref_Segment_IntersectionDimension_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x00034960 File Offset: 0x00032B60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 556738, XrefRangeEnd = 556742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IIntersection Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Segment__Intersection([In] ref Segment geometry, IntersectionDimension dimension)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &geometry;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dimension;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Polygon.NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Segment__Intersection_Private_Virtual_Final_New_IIntersection_byref_Segment_IntersectionDimension_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IIntersection>(intPtr3) : null;
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x000349C0 File Offset: 0x00032BC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 556742, XrefRangeEnd = 556746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Circle__Intersects([In] ref Circle geometry, IntersectionDimension dimension)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &geometry;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dimension;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Polygon.NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Circle__Intersects_Private_Virtual_Final_New_Boolean_byref_Circle_IntersectionDimension_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x00034A1C File Offset: 0x00032C1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 556746, XrefRangeEnd = 556750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IIntersection Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Circle__Intersection([In] ref Circle geometry, IntersectionDimension dimension)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &geometry;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dimension;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Polygon.NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Circle__Intersection_Private_Virtual_Final_New_IIntersection_byref_Circle_IntersectionDimension_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IIntersection>(intPtr3) : null;
		}

		// Token: 0x060006B5 RID: 1717 RVA: 0x00034A7C File Offset: 0x00032C7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 556750, XrefRangeEnd = 556754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Arc__Intersects([In] ref Arc geometry, IntersectionDimension dimension)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &geometry;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dimension;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Polygon.NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Arc__Intersects_Private_Virtual_Final_New_Boolean_byref_Arc_IntersectionDimension_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x00034AD8 File Offset: 0x00032CD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 556754, XrefRangeEnd = 556758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IIntersection Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Arc__Intersection([In] ref Arc geometry, IntersectionDimension dimension)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &geometry;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dimension;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Polygon.NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Arc__Intersection_Private_Virtual_Final_New_IIntersection_byref_Arc_IntersectionDimension_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IIntersection>(intPtr3) : null;
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x00034B38 File Offset: 0x00032D38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 556758, XrefRangeEnd = 556762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_DwdVector2Floating__Intersects([In] ref DwdVector2Floating geometry, IntersectionDimension dimension)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &geometry;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dimension;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Polygon.NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_DwdVector2Floating__Intersects_Private_Virtual_Final_New_Boolean_byref_DwdVector2Floating_IntersectionDimension_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x00034B94 File Offset: 0x00032D94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 556762, XrefRangeEnd = 556766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IIntersection Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_DwdVector2Floating__Intersection([In] ref DwdVector2Floating geometry, IntersectionDimension dimension)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &geometry;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dimension;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Polygon.NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_DwdVector2Floating__Intersection_Private_Virtual_Final_New_IIntersection_byref_DwdVector2Floating_IntersectionDimension_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IIntersection>(intPtr3) : null;
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x000049D8 File Offset: 0x00002BD8
		public Polygon(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060006BA RID: 1722 RVA: 0x000049E1 File Offset: 0x00002BE1
		public Polygon()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Polygon>.NativeClassPtr))
		{
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x060006BB RID: 1723 RVA: 0x00034BF4 File Offset: 0x00032DF4
		// (set) Token: 0x060006BC RID: 1724 RVA: 0x000049F3 File Offset: 0x00002BF3
		public unsafe Il2CppStructArray<DwdVector2Floating> Points
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Polygon.NativeFieldInfoPtr_Points);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<DwdVector2Floating>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Polygon.NativeFieldInfoPtr_Points), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x060006BD RID: 1725 RVA: 0x00034C24 File Offset: 0x00032E24
		// (set) Token: 0x060006BE RID: 1726 RVA: 0x00004A12 File Offset: 0x00002C12
		public unsafe Il2CppStructArray<Segment> Edges
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Polygon.NativeFieldInfoPtr_Edges);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Segment>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Polygon.NativeFieldInfoPtr_Edges), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x060006BF RID: 1727 RVA: 0x00034C54 File Offset: 0x00032E54
		// (set) Token: 0x060006C0 RID: 1728 RVA: 0x00004A31 File Offset: 0x00002C31
		public unsafe DwdVector2Floating Centroid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Polygon.NativeFieldInfoPtr_Centroid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Polygon.NativeFieldInfoPtr_Centroid)) = value;
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x060006C1 RID: 1729 RVA: 0x00034C7C File Offset: 0x00032E7C
		// (set) Token: 0x060006C2 RID: 1730 RVA: 0x00004A4C File Offset: 0x00002C4C
		public unsafe static DwdVector2 ArbitraryUnitVector
		{
			get
			{
				DwdVector2 dwdVector;
				IL2CPP.il2cpp_field_static_get_value(Polygon.NativeFieldInfoPtr_ArbitraryUnitVector, (void*)(&dwdVector));
				return dwdVector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Polygon.NativeFieldInfoPtr_ArbitraryUnitVector, (void*)(&value));
			}
		}

		// Token: 0x04000473 RID: 1139
		private static readonly IntPtr NativeFieldInfoPtr_Points;

		// Token: 0x04000474 RID: 1140
		private static readonly IntPtr NativeFieldInfoPtr_Edges;

		// Token: 0x04000475 RID: 1141
		private static readonly IntPtr NativeFieldInfoPtr_Centroid;

		// Token: 0x04000476 RID: 1142
		private static readonly IntPtr NativeFieldInfoPtr_ArbitraryUnitVector;

		// Token: 0x04000477 RID: 1143
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_DwdVector2Floating_0;

		// Token: 0x04000478 RID: 1144
		private static readonly IntPtr NativeMethodInfoPtr_Intersects_Public_Boolean_byref_Line_IntersectionDimension_0;

		// Token: 0x04000479 RID: 1145
		private static readonly IntPtr NativeMethodInfoPtr_Intersection_Public_IIntersection_byref_Line_IntersectionDimension_0;

		// Token: 0x0400047A RID: 1146
		private static readonly IntPtr NativeMethodInfoPtr_Intersects_Public_Boolean_byref_DwdVector2Floating_IntersectionDimension_0;

		// Token: 0x0400047B RID: 1147
		private static readonly IntPtr NativeMethodInfoPtr_Intersection_Public_IIntersection_byref_DwdVector2Floating_IntersectionDimension_0;

		// Token: 0x0400047C RID: 1148
		private static readonly IntPtr NativeMethodInfoPtr_PointInsideConvex_Private_Boolean_DwdVector2Floating_0;

		// Token: 0x0400047D RID: 1149
		private static readonly IntPtr NativeMethodInfoPtr_WindingNumber_Private_Int32_DwdVector2Floating_0;

		// Token: 0x0400047E RID: 1150
		private static readonly IntPtr NativeMethodInfoPtr_Intersects_Public_Boolean_byref_Segment_IntersectionDimension_0;

		// Token: 0x0400047F RID: 1151
		private static readonly IntPtr NativeMethodInfoPtr_Intersection_Public_IIntersection_byref_Segment_IntersectionDimension_0;

		// Token: 0x04000480 RID: 1152
		private static readonly IntPtr NativeMethodInfoPtr_Intersects_Public_Boolean_byref_Ray_IntersectionDimension_0;

		// Token: 0x04000481 RID: 1153
		private static readonly IntPtr NativeMethodInfoPtr_Intersection_Public_IIntersection_byref_Ray_IntersectionDimension_0;

		// Token: 0x04000482 RID: 1154
		private static readonly IntPtr NativeMethodInfoPtr_Intersects_Public_Boolean_byref_Polygon_IntersectionDimension_0;

		// Token: 0x04000483 RID: 1155
		private static readonly IntPtr NativeMethodInfoPtr_Intersection_Public_IIntersection_byref_Polygon_IntersectionDimension_0;

		// Token: 0x04000484 RID: 1156
		private static readonly IntPtr NativeMethodInfoPtr_Intersects_Public_Boolean_byref_Circle_IntersectionDimension_0;

		// Token: 0x04000485 RID: 1157
		private static readonly IntPtr NativeMethodInfoPtr_Intersection_Public_IIntersection_byref_Circle_IntersectionDimension_0;

		// Token: 0x04000486 RID: 1158
		private static readonly IntPtr NativeMethodInfoPtr_Intersects_Public_Boolean_byref_Arc_IntersectionDimension_0;

		// Token: 0x04000487 RID: 1159
		private static readonly IntPtr NativeMethodInfoPtr_Intersection_Public_IIntersection_byref_Arc_IntersectionDimension_0;

		// Token: 0x04000488 RID: 1160
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Polygon_0;

		// Token: 0x04000489 RID: 1161
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400048A RID: 1162
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400048B RID: 1163
		private static readonly IntPtr NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Polygon__Intersects_Private_Virtual_Final_New_Boolean_byref_Polygon_IntersectionDimension_0;

		// Token: 0x0400048C RID: 1164
		private static readonly IntPtr NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Polygon__Intersection_Private_Virtual_Final_New_IIntersection_byref_Polygon_IntersectionDimension_0;

		// Token: 0x0400048D RID: 1165
		private static readonly IntPtr NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Line__Intersects_Private_Virtual_Final_New_Boolean_byref_Line_IntersectionDimension_0;

		// Token: 0x0400048E RID: 1166
		private static readonly IntPtr NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Line__Intersection_Private_Virtual_Final_New_IIntersection_byref_Line_IntersectionDimension_0;

		// Token: 0x0400048F RID: 1167
		private static readonly IntPtr NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Ray__Intersects_Private_Virtual_Final_New_Boolean_byref_Ray_IntersectionDimension_0;

		// Token: 0x04000490 RID: 1168
		private static readonly IntPtr NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Ray__Intersection_Private_Virtual_Final_New_IIntersection_byref_Ray_IntersectionDimension_0;

		// Token: 0x04000491 RID: 1169
		private static readonly IntPtr NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Segment__Intersects_Private_Virtual_Final_New_Boolean_byref_Segment_IntersectionDimension_0;

		// Token: 0x04000492 RID: 1170
		private static readonly IntPtr NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Segment__Intersection_Private_Virtual_Final_New_IIntersection_byref_Segment_IntersectionDimension_0;

		// Token: 0x04000493 RID: 1171
		private static readonly IntPtr NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Circle__Intersects_Private_Virtual_Final_New_Boolean_byref_Circle_IntersectionDimension_0;

		// Token: 0x04000494 RID: 1172
		private static readonly IntPtr NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Circle__Intersection_Private_Virtual_Final_New_IIntersection_byref_Circle_IntersectionDimension_0;

		// Token: 0x04000495 RID: 1173
		private static readonly IntPtr NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Arc__Intersects_Private_Virtual_Final_New_Boolean_byref_Arc_IntersectionDimension_0;

		// Token: 0x04000496 RID: 1174
		private static readonly IntPtr NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Arc__Intersection_Private_Virtual_Final_New_IIntersection_byref_Arc_IntersectionDimension_0;

		// Token: 0x04000497 RID: 1175
		private static readonly IntPtr NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_DwdVector2Floating__Intersects_Private_Virtual_Final_New_Boolean_byref_DwdVector2Floating_IntersectionDimension_0;

		// Token: 0x04000498 RID: 1176
		private static readonly IntPtr NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_DwdVector2Floating__Intersection_Private_Virtual_Final_New_IIntersection_byref_DwdVector2Floating_IntersectionDimension_0;

		// Token: 0x020002CC RID: 716
		[ObfuscatedName("Canis.mathLib.Polygon+<>O")]
		public static class __O : Object
		{
			// Token: 0x06001E35 RID: 7733 RVA: 0x0000E89C File Offset: 0x0000CA9C
			// Note: this type is marked as 'beforefieldinit'.
			static __O()
			{
				Il2CppClassPointerStore<Polygon.__O>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Polygon>.NativeClassPtr, "<>O");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Polygon.__O>.NativeClassPtr);
				Polygon.__O.NativeFieldInfoPtr__0___FromPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Polygon.__O>.NativeClassPtr, "<0>__FromPoints");
			}

			// Token: 0x06001E36 RID: 7734 RVA: 0x0000E8D0 File Offset: 0x0000CAD0
			public __O(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000714 RID: 1812
			// (get) Token: 0x06001E37 RID: 7735 RVA: 0x0008CC70 File Offset: 0x0008AE70
			// (set) Token: 0x06001E38 RID: 7736 RVA: 0x0000E8D9 File Offset: 0x0000CAD9
			public unsafe static Func<DwdVector2Floating, DwdVector2Floating, Segment> _0___FromPoints
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Polygon.__O.NativeFieldInfoPtr__0___FromPoints, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DwdVector2Floating, DwdVector2Floating, Segment>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Polygon.__O.NativeFieldInfoPtr__0___FromPoints, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400131B RID: 4891
			private static readonly IntPtr NativeFieldInfoPtr__0___FromPoints;
		}

		// Token: 0x020002CD RID: 717
		[ObfuscatedName("Canis.mathLib.Polygon+<>c__DisplayClass21_0")]
		public sealed class __c__DisplayClass21_0 : Object
		{
			// Token: 0x06001E39 RID: 7737 RVA: 0x0008CC98 File Offset: 0x0008AE98
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass21_0()
			{
				Il2CppClassPointerStore<Polygon.__c__DisplayClass21_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Polygon>.NativeClassPtr, "<>c__DisplayClass21_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Polygon.__c__DisplayClass21_0>.NativeClassPtr);
				Polygon.__c__DisplayClass21_0.NativeFieldInfoPtr_other = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Polygon.__c__DisplayClass21_0>.NativeClassPtr, "other");
				Polygon.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Polygon.__c__DisplayClass21_0>.NativeClassPtr, 100664688);
				Polygon.__c__DisplayClass21_0.NativeMethodInfoPtr__Equals_b__0_Internal_Boolean_DwdVector2Floating_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Polygon.__c__DisplayClass21_0>.NativeClassPtr, 100664689);
			}

			// Token: 0x06001E3A RID: 7738 RVA: 0x0008CD00 File Offset: 0x0008AF00
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass21_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Polygon.__c__DisplayClass21_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Polygon.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E3B RID: 7739 RVA: 0x0008CD3C File Offset: 0x0008AF3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 556356, XrefRangeEnd = 556357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Equals_b__0(DwdVector2Floating t, int i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref t;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Polygon.__c__DisplayClass21_0.NativeMethodInfoPtr__Equals_b__0_Internal_Boolean_DwdVector2Floating_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001E3C RID: 7740 RVA: 0x0000E8EB File Offset: 0x0000CAEB
			public __c__DisplayClass21_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000715 RID: 1813
			// (get) Token: 0x06001E3D RID: 7741 RVA: 0x0008CD94 File Offset: 0x0008AF94
			// (set) Token: 0x06001E3E RID: 7742 RVA: 0x0000E8F4 File Offset: 0x0000CAF4
			public Polygon other
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Polygon.__c__DisplayClass21_0.NativeFieldInfoPtr_other);
					return new Polygon(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Polygon>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Polygon.__c__DisplayClass21_0.NativeFieldInfoPtr_other), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Polygon>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400131C RID: 4892
			private static readonly IntPtr NativeFieldInfoPtr_other;

			// Token: 0x0400131D RID: 4893
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400131E RID: 4894
			private static readonly IntPtr NativeMethodInfoPtr__Equals_b__0_Internal_Boolean_DwdVector2Floating_Int32_0;
		}
	}
}
