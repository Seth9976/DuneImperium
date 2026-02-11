using System;
using System.Runtime.InteropServices;
using Canis.mathLib.intersections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.mathLib
{
	// Token: 0x0200007C RID: 124
	[StructLayout(2)]
	public struct Segment
	{
		// Token: 0x060006DF RID: 1759 RVA: 0x0003568C File Offset: 0x0003388C
		// Note: this type is marked as 'beforefieldinit'.
		static Segment()
		{
			Il2CppClassPointerStore<Segment>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.mathLib", "Segment");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Segment>.NativeClassPtr);
			Segment.NativeFieldInfoPtr_Point1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Segment>.NativeClassPtr, "Point1");
			Segment.NativeFieldInfoPtr_Point2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Segment>.NativeClassPtr, "Point2");
			Segment.NativeFieldInfoPtr_Span = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Segment>.NativeClassPtr, "Span");
			Segment.NativeMethodInfoPtr__ctor_Private_Void_DwdVector2Floating_DwdVector2Floating_DwdVector2Floating_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Segment>.NativeClassPtr, 100664716);
			Segment.NativeMethodInfoPtr_FromPoints_Public_Static_Segment_DwdVector2Floating_DwdVector2Floating_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Segment>.NativeClassPtr, 100664717);
			Segment.NativeMethodInfoPtr_FromSpan_Public_Static_Segment_DwdVector2Floating_DwdVector2Floating_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Segment>.NativeClassPtr, 100664718);
			Segment.NativeMethodInfoPtr_op_Addition_Public_Static_Segment_Segment_DwdVector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Segment>.NativeClassPtr, 100664719);
			Segment.NativeMethodInfoPtr_op_Addition_Public_Static_Segment_Segment_DwdVector2Floating_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Segment>.NativeClassPtr, 100664720);
			Segment.NativeMethodInfoPtr_op_Subtraction_Public_Static_Segment_Segment_DwdVector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Segment>.NativeClassPtr, 100664721);
			Segment.NativeMethodInfoPtr_op_Subtraction_Public_Static_Segment_Segment_DwdVector2Floating_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Segment>.NativeClassPtr, 100664722);
			Segment.NativeMethodInfoPtr_AsLine_Public_Line_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Segment>.NativeClassPtr, 100664723);
			Segment.NativeMethodInfoPtr_Intersects_Public_Boolean_byref_DwdVector2Floating_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Segment>.NativeClassPtr, 100664724);
			Segment.NativeMethodInfoPtr_Intersection_Public_IIntersection_byref_DwdVector2Floating_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Segment>.NativeClassPtr, 100664725);
			Segment.NativeMethodInfoPtr_Intersects_Public_Boolean_byref_Segment_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Segment>.NativeClassPtr, 100664726);
			Segment.NativeMethodInfoPtr_Intersection_Public_IIntersection_byref_Segment_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Segment>.NativeClassPtr, 100664727);
			Segment.NativeMethodInfoPtr_CollinearIntersection_Public_IIntersection_Segment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Segment>.NativeClassPtr, 100664728);
			Segment.NativeMethodInfoPtr_MinDistanceFrom_Public_ValueTuple_2_Double_DwdVector2Floating_DwdVector2Floating_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Segment>.NativeClassPtr, 100664729);
			Segment.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Segment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Segment>.NativeClassPtr, 100664730);
			Segment.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Segment>.NativeClassPtr, 100664731);
			Segment.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Segment>.NativeClassPtr, 100664732);
			Segment.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Segment>.NativeClassPtr, 100664733);
			Segment.NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Segment__Intersects_Private_Virtual_Final_New_Boolean_byref_Segment_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Segment>.NativeClassPtr, 100664734);
			Segment.NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Segment__Intersection_Private_Virtual_Final_New_IIntersection_byref_Segment_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Segment>.NativeClassPtr, 100664735);
			Segment.NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_DwdVector2Floating__Intersects_Private_Virtual_Final_New_Boolean_byref_DwdVector2Floating_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Segment>.NativeClassPtr, 100664736);
			Segment.NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_DwdVector2Floating__Intersection_Private_Virtual_Final_New_IIntersection_byref_DwdVector2Floating_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Segment>.NativeClassPtr, 100664737);
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x000358B0 File Offset: 0x00033AB0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 556238, RefRangeEnd = 556240, XrefRangeStart = 556238, XrefRangeEnd = 556240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Segment(DwdVector2Floating point1, DwdVector2Floating point2, DwdVector2Floating span)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Segment.NativeMethodInfoPtr__ctor_Private_Void_DwdVector2Floating_DwdVector2Floating_DwdVector2Floating_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x00035900 File Offset: 0x00033B00
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 556240, RefRangeEnd = 556242, XrefRangeStart = 556240, XrefRangeEnd = 556242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Segment FromPoints(DwdVector2Floating point1, DwdVector2Floating point2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref point1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref point2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Segment.NativeMethodInfoPtr_FromPoints_Public_Static_Segment_DwdVector2Floating_DwdVector2Floating_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x0003594C File Offset: 0x00033B4C
		[CallerCount(0)]
		public unsafe static Segment FromSpan(DwdVector2Floating point, DwdVector2Floating span)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref point;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref span;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Segment.NativeMethodInfoPtr_FromSpan_Public_Static_Segment_DwdVector2Floating_DwdVector2Floating_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x00035998 File Offset: 0x00033B98
		[CallerCount(0)]
		public unsafe static Segment operator +(Segment segment, DwdVector2 vector)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref segment;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vector;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Segment.NativeMethodInfoPtr_op_Addition_Public_Static_Segment_Segment_DwdVector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x000359E4 File Offset: 0x00033BE4
		[CallerCount(0)]
		public unsafe static Segment operator +(Segment segment, DwdVector2Floating vector)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref segment;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vector;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Segment.NativeMethodInfoPtr_op_Addition_Public_Static_Segment_Segment_DwdVector2Floating_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x00035A30 File Offset: 0x00033C30
		[CallerCount(0)]
		public unsafe static Segment operator -(Segment segment, DwdVector2 vector)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref segment;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vector;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Segment.NativeMethodInfoPtr_op_Subtraction_Public_Static_Segment_Segment_DwdVector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x00035A7C File Offset: 0x00033C7C
		[CallerCount(0)]
		public unsafe static Segment operator -(Segment segment, DwdVector2Floating vector)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref segment;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vector;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Segment.NativeMethodInfoPtr_op_Subtraction_Public_Static_Segment_Segment_DwdVector2Floating_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x00035AC8 File Offset: 0x00033CC8
		[CallerCount(0)]
		public unsafe Line AsLine()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Segment.NativeMethodInfoPtr_AsLine_Public_Line_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006E8 RID: 1768 RVA: 0x00035AF8 File Offset: 0x00033CF8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 556863, RefRangeEnd = 556866, XrefRangeStart = 556858, XrefRangeEnd = 556863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Segment.NativeMethodInfoPtr_Intersects_Public_Boolean_byref_DwdVector2Floating_IntersectionDimension_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x00035B44 File Offset: 0x00033D44
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 556872, RefRangeEnd = 556877, XrefRangeStart = 556866, XrefRangeEnd = 556872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Segment.NativeMethodInfoPtr_Intersection_Public_IIntersection_byref_DwdVector2Floating_IntersectionDimension_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IIntersection>(intPtr3) : null;
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x00035B94 File Offset: 0x00033D94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 556877, XrefRangeEnd = 556882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Segment.NativeMethodInfoPtr_Intersects_Public_Boolean_byref_Segment_IntersectionDimension_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x00035BE0 File Offset: 0x00033DE0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 556889, RefRangeEnd = 556893, XrefRangeStart = 556882, XrefRangeEnd = 556889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Segment.NativeMethodInfoPtr_Intersection_Public_IIntersection_byref_Segment_IntersectionDimension_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IIntersection>(intPtr3) : null;
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x00035C30 File Offset: 0x00033E30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 556942, RefRangeEnd = 556943, XrefRangeStart = 556893, XrefRangeEnd = 556942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IIntersection CollinearIntersection(Segment segment)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref segment;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Segment.NativeMethodInfoPtr_CollinearIntersection_Public_IIntersection_Segment_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IIntersection>(intPtr3) : null;
			}
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x00035C70 File Offset: 0x00033E70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 556943, XrefRangeEnd = 556960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTuple<double, DwdVector2Floating> MinDistanceFrom(DwdVector2Floating point)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref point;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Segment.NativeMethodInfoPtr_MinDistanceFrom_Public_ValueTuple_2_Double_DwdVector2Floating_DwdVector2Floating_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ValueTuple<double, DwdVector2Floating>(intPtr);
			}
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x00035CA8 File Offset: 0x00033EA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 556964, RefRangeEnd = 556966, XrefRangeStart = 556960, XrefRangeEnd = 556964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(Segment other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Segment.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Segment_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x00035CE8 File Offset: 0x00033EE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 556966, XrefRangeEnd = 556970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Segment.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x00035D2C File Offset: 0x00033F2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 556842, RefRangeEnd = 556843, XrefRangeStart = 556842, XrefRangeEnd = 556843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Segment.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006F1 RID: 1777 RVA: 0x00035D5C File Offset: 0x00033F5C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 556978, RefRangeEnd = 556980, XrefRangeStart = 556970, XrefRangeEnd = 556978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Segment.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x00035D88 File Offset: 0x00033F88
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Segment.NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Segment__Intersects_Private_Virtual_Final_New_Boolean_byref_Segment_IntersectionDimension_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x00035DD4 File Offset: 0x00033FD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 556980, XrefRangeEnd = 556981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Segment.NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Segment__Intersection_Private_Virtual_Final_New_IIntersection_byref_Segment_IntersectionDimension_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IIntersection>(intPtr3) : null;
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x00035E24 File Offset: 0x00034024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 556981, XrefRangeEnd = 556982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Segment.NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_DwdVector2Floating__Intersects_Private_Virtual_Final_New_Boolean_byref_DwdVector2Floating_IntersectionDimension_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x00035E70 File Offset: 0x00034070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 556982, XrefRangeEnd = 556983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Segment.NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_DwdVector2Floating__Intersection_Private_Virtual_Final_New_IIntersection_byref_DwdVector2Floating_IntersectionDimension_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IIntersection>(intPtr3) : null;
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x00004A6C File Offset: 0x00002C6C
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Segment>.NativeClassPtr, ref this));
		}

		// Token: 0x040004B9 RID: 1209
		private static readonly IntPtr NativeFieldInfoPtr_Point1;

		// Token: 0x040004BA RID: 1210
		private static readonly IntPtr NativeFieldInfoPtr_Point2;

		// Token: 0x040004BB RID: 1211
		private static readonly IntPtr NativeFieldInfoPtr_Span;

		// Token: 0x040004BC RID: 1212
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_DwdVector2Floating_DwdVector2Floating_DwdVector2Floating_0;

		// Token: 0x040004BD RID: 1213
		private static readonly IntPtr NativeMethodInfoPtr_FromPoints_Public_Static_Segment_DwdVector2Floating_DwdVector2Floating_0;

		// Token: 0x040004BE RID: 1214
		private static readonly IntPtr NativeMethodInfoPtr_FromSpan_Public_Static_Segment_DwdVector2Floating_DwdVector2Floating_0;

		// Token: 0x040004BF RID: 1215
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_Segment_Segment_DwdVector2_0;

		// Token: 0x040004C0 RID: 1216
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_Segment_Segment_DwdVector2Floating_0;

		// Token: 0x040004C1 RID: 1217
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_Segment_Segment_DwdVector2_0;

		// Token: 0x040004C2 RID: 1218
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_Segment_Segment_DwdVector2Floating_0;

		// Token: 0x040004C3 RID: 1219
		private static readonly IntPtr NativeMethodInfoPtr_AsLine_Public_Line_0;

		// Token: 0x040004C4 RID: 1220
		private static readonly IntPtr NativeMethodInfoPtr_Intersects_Public_Boolean_byref_DwdVector2Floating_IntersectionDimension_0;

		// Token: 0x040004C5 RID: 1221
		private static readonly IntPtr NativeMethodInfoPtr_Intersection_Public_IIntersection_byref_DwdVector2Floating_IntersectionDimension_0;

		// Token: 0x040004C6 RID: 1222
		private static readonly IntPtr NativeMethodInfoPtr_Intersects_Public_Boolean_byref_Segment_IntersectionDimension_0;

		// Token: 0x040004C7 RID: 1223
		private static readonly IntPtr NativeMethodInfoPtr_Intersection_Public_IIntersection_byref_Segment_IntersectionDimension_0;

		// Token: 0x040004C8 RID: 1224
		private static readonly IntPtr NativeMethodInfoPtr_CollinearIntersection_Public_IIntersection_Segment_0;

		// Token: 0x040004C9 RID: 1225
		private static readonly IntPtr NativeMethodInfoPtr_MinDistanceFrom_Public_ValueTuple_2_Double_DwdVector2Floating_DwdVector2Floating_0;

		// Token: 0x040004CA RID: 1226
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Segment_0;

		// Token: 0x040004CB RID: 1227
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040004CC RID: 1228
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040004CD RID: 1229
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040004CE RID: 1230
		private static readonly IntPtr NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Segment__Intersects_Private_Virtual_Final_New_Boolean_byref_Segment_IntersectionDimension_0;

		// Token: 0x040004CF RID: 1231
		private static readonly IntPtr NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_Segment__Intersection_Private_Virtual_Final_New_IIntersection_byref_Segment_IntersectionDimension_0;

		// Token: 0x040004D0 RID: 1232
		private static readonly IntPtr NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_DwdVector2Floating__Intersects_Private_Virtual_Final_New_Boolean_byref_DwdVector2Floating_IntersectionDimension_0;

		// Token: 0x040004D1 RID: 1233
		private static readonly IntPtr NativeMethodInfoPtr_Canis_mathLib_intersections_ICanIntersectWith_Canis_mathLib_DwdVector2Floating__Intersection_Private_Virtual_Final_New_IIntersection_byref_DwdVector2Floating_IntersectionDimension_0;

		// Token: 0x040004D2 RID: 1234
		[FieldOffset(0)]
		public readonly DwdVector2Floating Point1;

		// Token: 0x040004D3 RID: 1235
		[FieldOffset(16)]
		public readonly DwdVector2Floating Point2;

		// Token: 0x040004D4 RID: 1236
		[FieldOffset(32)]
		public readonly DwdVector2Floating Span;

		// Token: 0x020002CE RID: 718
		[StructLayout(2)]
		public struct AffiliatedAlignedPoint
		{
			// Token: 0x06001E3F RID: 7743 RVA: 0x0008CDC4 File Offset: 0x0008AFC4
			// Note: this type is marked as 'beforefieldinit'.
			static AffiliatedAlignedPoint()
			{
				Il2CppClassPointerStore<Segment.AffiliatedAlignedPoint>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Segment>.NativeClassPtr, "AffiliatedAlignedPoint");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Segment.AffiliatedAlignedPoint>.NativeClassPtr);
				Segment.AffiliatedAlignedPoint.NativeFieldInfoPtr_Point = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Segment.AffiliatedAlignedPoint>.NativeClassPtr, "Point");
				Segment.AffiliatedAlignedPoint.NativeFieldInfoPtr_Affiliation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Segment.AffiliatedAlignedPoint>.NativeClassPtr, "Affiliation");
				Segment.AffiliatedAlignedPoint.NativeFieldInfoPtr_Alignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Segment.AffiliatedAlignedPoint>.NativeClassPtr, "Alignment");
				Segment.AffiliatedAlignedPoint.NativeMethodInfoPtr__ctor_Public_Void_byref_DwdVector2Floating_Boolean_byref_DwdVector2Floating_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Segment.AffiliatedAlignedPoint>.NativeClassPtr, 100664738);
				Segment.AffiliatedAlignedPoint.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_byref_AffiliatedAlignedPoint_byref_AffiliatedAlignedPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Segment.AffiliatedAlignedPoint>.NativeClassPtr, 100664739);
				Segment.AffiliatedAlignedPoint.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_byref_AffiliatedAlignedPoint_byref_AffiliatedAlignedPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Segment.AffiliatedAlignedPoint>.NativeClassPtr, 100664740);
				Segment.AffiliatedAlignedPoint.NativeMethodInfoPtr_Deconstruct_Public_Void_byref_DwdVector2Floating_byref_Boolean_byref_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Segment.AffiliatedAlignedPoint>.NativeClassPtr, 100664741);
			}

			// Token: 0x06001E40 RID: 7744 RVA: 0x0008CE7C File Offset: 0x0008B07C
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 556848, RefRangeEnd = 556852, XrefRangeStart = 556847, XrefRangeEnd = 556848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AffiliatedAlignedPoint([In] ref DwdVector2Floating point, bool affiliation, [In] ref DwdVector2Floating alignmentVector)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &point;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref affiliation;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &alignmentVector;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Segment.AffiliatedAlignedPoint.NativeMethodInfoPtr__ctor_Public_Void_byref_DwdVector2Floating_Boolean_byref_DwdVector2Floating_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E41 RID: 7745 RVA: 0x0008CECC File Offset: 0x0008B0CC
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 556852, RefRangeEnd = 556857, XrefRangeStart = 556852, XrefRangeEnd = 556852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static bool operator >([In] ref Segment.AffiliatedAlignedPoint self, [In] ref Segment.AffiliatedAlignedPoint other)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &self;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Segment.AffiliatedAlignedPoint.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_byref_AffiliatedAlignedPoint_byref_AffiliatedAlignedPoint_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001E42 RID: 7746 RVA: 0x0008CF18 File Offset: 0x0008B118
			[CallerCount(0)]
			public unsafe static bool operator <([In] ref Segment.AffiliatedAlignedPoint self, [In] ref Segment.AffiliatedAlignedPoint other)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &self;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Segment.AffiliatedAlignedPoint.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_byref_AffiliatedAlignedPoint_byref_AffiliatedAlignedPoint_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001E43 RID: 7747 RVA: 0x0008CF64 File Offset: 0x0008B164
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 556857, RefRangeEnd = 556858, XrefRangeStart = 556857, XrefRangeEnd = 556857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Deconstruct(out DwdVector2Floating point, out bool affiliation, out double alignment)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &point;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &affiliation;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &alignment;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Segment.AffiliatedAlignedPoint.NativeMethodInfoPtr_Deconstruct_Public_Void_byref_DwdVector2Floating_byref_Boolean_byref_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E44 RID: 7748 RVA: 0x0000E922 File Offset: 0x0000CB22
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Segment.AffiliatedAlignedPoint>.NativeClassPtr, ref this));
			}

			// Token: 0x0400131F RID: 4895
			private static readonly IntPtr NativeFieldInfoPtr_Point;

			// Token: 0x04001320 RID: 4896
			private static readonly IntPtr NativeFieldInfoPtr_Affiliation;

			// Token: 0x04001321 RID: 4897
			private static readonly IntPtr NativeFieldInfoPtr_Alignment;

			// Token: 0x04001322 RID: 4898
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_byref_DwdVector2Floating_Boolean_byref_DwdVector2Floating_0;

			// Token: 0x04001323 RID: 4899
			private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_byref_AffiliatedAlignedPoint_byref_AffiliatedAlignedPoint_0;

			// Token: 0x04001324 RID: 4900
			private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_byref_AffiliatedAlignedPoint_byref_AffiliatedAlignedPoint_0;

			// Token: 0x04001325 RID: 4901
			private static readonly IntPtr NativeMethodInfoPtr_Deconstruct_Public_Void_byref_DwdVector2Floating_byref_Boolean_byref_Double_0;

			// Token: 0x04001326 RID: 4902
			[FieldOffset(0)]
			public readonly DwdVector2Floating Point;

			// Token: 0x04001327 RID: 4903
			[FieldOffset(16)]
			[MarshalAs(4)]
			public readonly bool Affiliation;

			// Token: 0x04001328 RID: 4904
			[FieldOffset(24)]
			public readonly double Alignment;
		}
	}
}
