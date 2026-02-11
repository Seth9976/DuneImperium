using System;
using System.Runtime.InteropServices;
using Canis.mathLib.intersections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.mathLib
{
	// Token: 0x02000072 RID: 114
	[Serializable]
	[StructLayout(2)]
	public struct Circle
	{
		// Token: 0x06000622 RID: 1570 RVA: 0x000318B0 File Offset: 0x0002FAB0
		// Note: this type is marked as 'beforefieldinit'.
		static Circle()
		{
			Il2CppClassPointerStore<Circle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.mathLib", "Circle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Circle>.NativeClassPtr);
			Circle.NativeFieldInfoPtr_Center = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Circle>.NativeClassPtr, "Center");
			Circle.NativeFieldInfoPtr_Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Circle>.NativeClassPtr, "Radius");
			Circle.NativeMethodInfoPtr__ctor_Public_Void_DwdVector2Floating_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Circle>.NativeClassPtr, 100664560);
			Circle.NativeMethodInfoPtr_PointAtAngle_Public_DwdVector2Floating_AngleRadians_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Circle>.NativeClassPtr, 100664561);
			Circle.NativeMethodInfoPtr_Intersects_Public_Boolean_byref_Line_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Circle>.NativeClassPtr, 100664562);
			Circle.NativeMethodInfoPtr_Intersection_Public_IIntersection_byref_Line_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Circle>.NativeClassPtr, 100664563);
			Circle.NativeMethodInfoPtr_Intersects_Public_Boolean_byref_Segment_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Circle>.NativeClassPtr, 100664564);
			Circle.NativeMethodInfoPtr_Intersection_Public_IIntersection_byref_Segment_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Circle>.NativeClassPtr, 100664565);
			Circle.NativeMethodInfoPtr_Intersects_Public_Boolean_byref_DwdVector2Floating_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Circle>.NativeClassPtr, 100664566);
			Circle.NativeMethodInfoPtr_Intersection_Public_IIntersection_byref_DwdVector2Floating_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Circle>.NativeClassPtr, 100664567);
			Circle.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Circle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Circle>.NativeClassPtr, 100664568);
			Circle.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Circle>.NativeClassPtr, 100664569);
			Circle.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Circle>.NativeClassPtr, 100664570);
			Circle.NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Line__Intersects_Private_Virtual_Final_New_Boolean_byref_Line_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Circle>.NativeClassPtr, 100664571);
			Circle.NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Line__Intersection_Private_Virtual_Final_New_IIntersection_byref_Line_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Circle>.NativeClassPtr, 100664572);
			Circle.NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Segment__Intersects_Private_Virtual_Final_New_Boolean_byref_Segment_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Circle>.NativeClassPtr, 100664573);
			Circle.NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Segment__Intersection_Private_Virtual_Final_New_IIntersection_byref_Segment_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Circle>.NativeClassPtr, 100664574);
			Circle.NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_DwdVector2Floating__Intersects_Private_Virtual_Final_New_Boolean_byref_DwdVector2Floating_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Circle>.NativeClassPtr, 100664575);
			Circle.NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_DwdVector2Floating__Intersection_Private_Virtual_Final_New_IIntersection_byref_DwdVector2Floating_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Circle>.NativeClassPtr, 100664576);
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x00031A5C File Offset: 0x0002FC5C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 556022, RefRangeEnd = 556024, XrefRangeStart = 556022, XrefRangeEnd = 556022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Circle(DwdVector2Floating center, double radius)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref center;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radius;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Circle.NativeMethodInfoPtr__ctor_Public_Void_DwdVector2Floating_Double_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x00031A9C File Offset: 0x0002FC9C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 556029, RefRangeEnd = 556031, XrefRangeStart = 556024, XrefRangeEnd = 556029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DwdVector2Floating PointAtAngle(AngleRadians angle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref angle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Circle.NativeMethodInfoPtr_PointAtAngle_Public_DwdVector2Floating_AngleRadians_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x00031ADC File Offset: 0x0002FCDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 556031, XrefRangeEnd = 556036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Circle.NativeMethodInfoPtr_Intersects_Public_Boolean_byref_Line_IntersectionDimension_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x00031B28 File Offset: 0x0002FD28
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 556062, RefRangeEnd = 556070, XrefRangeStart = 556036, XrefRangeEnd = 556062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Circle.NativeMethodInfoPtr_Intersection_Public_IIntersection_byref_Line_IntersectionDimension_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IIntersection>(intPtr3) : null;
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x00031B78 File Offset: 0x0002FD78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 556070, XrefRangeEnd = 556075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Circle.NativeMethodInfoPtr_Intersects_Public_Boolean_byref_Segment_IntersectionDimension_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x00031BC4 File Offset: 0x0002FDC4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 556102, RefRangeEnd = 556106, XrefRangeStart = 556075, XrefRangeEnd = 556102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Circle.NativeMethodInfoPtr_Intersection_Public_IIntersection_byref_Segment_IntersectionDimension_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IIntersection>(intPtr3) : null;
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x00031C14 File Offset: 0x0002FE14
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 556107, RefRangeEnd = 556111, XrefRangeStart = 556106, XrefRangeEnd = 556107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Circle.NativeMethodInfoPtr_Intersects_Public_Boolean_byref_DwdVector2Floating_IntersectionDimension_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x00031C60 File Offset: 0x0002FE60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 556121, RefRangeEnd = 556122, XrefRangeStart = 556111, XrefRangeEnd = 556121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Circle.NativeMethodInfoPtr_Intersection_Public_IIntersection_byref_DwdVector2Floating_IntersectionDimension_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IIntersection>(intPtr3) : null;
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x00031CB0 File Offset: 0x0002FEB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 556122, XrefRangeEnd = 556125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(Circle other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Circle.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Circle_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x00031CF0 File Offset: 0x0002FEF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 556125, XrefRangeEnd = 556131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Circle.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x00031D34 File Offset: 0x0002FF34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 556131, RefRangeEnd = 556132, XrefRangeStart = 556131, XrefRangeEnd = 556131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Circle.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x00031D64 File Offset: 0x0002FF64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Circle.NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Line__Intersects_Private_Virtual_Final_New_Boolean_byref_Line_IntersectionDimension_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x00031DB0 File Offset: 0x0002FFB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 556132, XrefRangeEnd = 556133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Circle.NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Line__Intersection_Private_Virtual_Final_New_IIntersection_byref_Line_IntersectionDimension_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IIntersection>(intPtr3) : null;
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x00031E00 File Offset: 0x00030000
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Circle.NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Segment__Intersects_Private_Virtual_Final_New_Boolean_byref_Segment_IntersectionDimension_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x00031E4C File Offset: 0x0003004C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 556133, XrefRangeEnd = 556134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Circle.NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Segment__Intersection_Private_Virtual_Final_New_IIntersection_byref_Segment_IntersectionDimension_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IIntersection>(intPtr3) : null;
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x00031E9C File Offset: 0x0003009C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 556134, XrefRangeEnd = 556135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Circle.NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_DwdVector2Floating__Intersects_Private_Virtual_Final_New_Boolean_byref_DwdVector2Floating_IntersectionDimension_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x00031EE8 File Offset: 0x000300E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 556135, XrefRangeEnd = 556136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Circle.NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_DwdVector2Floating__Intersection_Private_Virtual_Final_New_IIntersection_byref_DwdVector2Floating_IntersectionDimension_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IIntersection>(intPtr3) : null;
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x00004916 File Offset: 0x00002B16
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Circle>.NativeClassPtr, ref this));
		}

		// Token: 0x040003FB RID: 1019
		private static readonly IntPtr NativeFieldInfoPtr_Center;

		// Token: 0x040003FC RID: 1020
		private static readonly IntPtr NativeFieldInfoPtr_Radius;

		// Token: 0x040003FD RID: 1021
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DwdVector2Floating_Double_0;

		// Token: 0x040003FE RID: 1022
		private static readonly IntPtr NativeMethodInfoPtr_PointAtAngle_Public_DwdVector2Floating_AngleRadians_0;

		// Token: 0x040003FF RID: 1023
		private static readonly IntPtr NativeMethodInfoPtr_Intersects_Public_Boolean_byref_Line_IntersectionDimension_0;

		// Token: 0x04000400 RID: 1024
		private static readonly IntPtr NativeMethodInfoPtr_Intersection_Public_IIntersection_byref_Line_IntersectionDimension_0;

		// Token: 0x04000401 RID: 1025
		private static readonly IntPtr NativeMethodInfoPtr_Intersects_Public_Boolean_byref_Segment_IntersectionDimension_0;

		// Token: 0x04000402 RID: 1026
		private static readonly IntPtr NativeMethodInfoPtr_Intersection_Public_IIntersection_byref_Segment_IntersectionDimension_0;

		// Token: 0x04000403 RID: 1027
		private static readonly IntPtr NativeMethodInfoPtr_Intersects_Public_Boolean_byref_DwdVector2Floating_IntersectionDimension_0;

		// Token: 0x04000404 RID: 1028
		private static readonly IntPtr NativeMethodInfoPtr_Intersection_Public_IIntersection_byref_DwdVector2Floating_IntersectionDimension_0;

		// Token: 0x04000405 RID: 1029
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Circle_0;

		// Token: 0x04000406 RID: 1030
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000407 RID: 1031
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000408 RID: 1032
		private static readonly IntPtr NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Line__Intersects_Private_Virtual_Final_New_Boolean_byref_Line_IntersectionDimension_0;

		// Token: 0x04000409 RID: 1033
		private static readonly IntPtr NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Line__Intersection_Private_Virtual_Final_New_IIntersection_byref_Line_IntersectionDimension_0;

		// Token: 0x0400040A RID: 1034
		private static readonly IntPtr NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Segment__Intersects_Private_Virtual_Final_New_Boolean_byref_Segment_IntersectionDimension_0;

		// Token: 0x0400040B RID: 1035
		private static readonly IntPtr NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Segment__Intersection_Private_Virtual_Final_New_IIntersection_byref_Segment_IntersectionDimension_0;

		// Token: 0x0400040C RID: 1036
		private static readonly IntPtr NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_DwdVector2Floating__Intersects_Private_Virtual_Final_New_Boolean_byref_DwdVector2Floating_IntersectionDimension_0;

		// Token: 0x0400040D RID: 1037
		private static readonly IntPtr NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_DwdVector2Floating__Intersection_Private_Virtual_Final_New_IIntersection_byref_DwdVector2Floating_IntersectionDimension_0;

		// Token: 0x0400040E RID: 1038
		[FieldOffset(0)]
		public readonly DwdVector2Floating Center;

		// Token: 0x0400040F RID: 1039
		[FieldOffset(16)]
		public readonly double Radius;
	}
}
