using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Canis.mathLib.intersections
{
	// Token: 0x02000082 RID: 130
	public static class IntersectionUtils : Object
	{
		// Token: 0x06000703 RID: 1795 RVA: 0x00036168 File Offset: 0x00034368
		// Note: this type is marked as 'beforefieldinit'.
		static IntersectionUtils()
		{
			Il2CppClassPointerStore<IntersectionUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.mathLib.intersections", "IntersectionUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntersectionUtils>.NativeClassPtr);
			IntersectionUtils.NativeFieldInfoPtr_PointDistanceComparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntersectionUtils>.NativeClassPtr, "PointDistanceComparer");
			IntersectionUtils.NativeMethodInfoPtr_Exists_Public_Static_Boolean_IIntersection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntersectionUtils>.NativeClassPtr, 100664746);
			IntersectionUtils.NativeMethodInfoPtr_Intersects_Public_Static_Boolean_TGeometry_ICanIntersectWith_1_TGeometry_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntersectionUtils>.NativeClassPtr, 100664747);
			IntersectionUtils.NativeMethodInfoPtr_Intersection_Public_Static_IIntersection_TGeometry_ICanIntersectWith_1_TGeometry_IntersectionDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntersectionUtils>.NativeClassPtr, 100664748);
			IntersectionUtils.NativeMethodInfoPtr_ClosestPointOfIntersectionTo_Public_Static_Nullable_1_ValueTuple_2_DwdVector2Floating_Double_IIntersection_DwdVector2Floating_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntersectionUtils>.NativeClassPtr, 100664749);
			IntersectionUtils.NativeMethodInfoPtr_Method_Internal_Static_Nullable_1_ValueTuple_2_DwdVector2Floating_Double_IEnumerable_1_DwdVector2Floating_DwdVector2Floating_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntersectionUtils>.NativeClassPtr, 100664751);
			IntersectionUtils.NativeMethodInfoPtr_Method_Internal_Static_Nullable_1_ValueTuple_2_DwdVector2Floating_Double_IEnumerable_1_ValueTuple_2_DwdVector2Floating_Double_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntersectionUtils>.NativeClassPtr, 100664752);
		}

		// Token: 0x06000704 RID: 1796 RVA: 0x00036224 File Offset: 0x00034424
		[CallerCount(32)]
		[CachedScanResults(RefRangeStart = 556999, RefRangeEnd = 557031, XrefRangeStart = 556995, XrefRangeEnd = 556999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Exists(this IIntersection intersection)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(intersection);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntersectionUtils.NativeMethodInfoPtr_Exists_Public_Static_Boolean_IIntersection_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000705 RID: 1797 RVA: 0x00036268 File Offset: 0x00034468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 557031, XrefRangeEnd = 557034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Intersects<TGeometry>(this TGeometry geometry, ICanIntersectWith<TGeometry> iciw, IntersectionDimension dimension = IntersectionDimension.Area)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TGeometry).IsValueType)
				{
					TGeometry tgeometry = geometry;
					intPtr = ((tgeometry is string) ? IL2CPP.ManagedStringToIl2Cpp(tgeometry as string) : IL2CPP.Il2CppObjectBaseToPtr(tgeometry as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref geometry;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(iciw);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dimension;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IntersectionUtils.MethodInfoStoreGeneric_Intersects_Public_Static_Boolean_TGeometry_ICanIntersectWith_1_TGeometry_IntersectionDimension_0<TGeometry>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000706 RID: 1798 RVA: 0x00036300 File Offset: 0x00034500
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 557037, RefRangeEnd = 557040, XrefRangeStart = 557034, XrefRangeEnd = 557037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IIntersection Intersection<TGeometry>(this TGeometry geometry, ICanIntersectWith<TGeometry> iciw, IntersectionDimension dimension = IntersectionDimension.Area)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TGeometry).IsValueType)
				{
					TGeometry tgeometry = geometry;
					intPtr = ((tgeometry is string) ? IL2CPP.ManagedStringToIl2Cpp(tgeometry as string) : IL2CPP.Il2CppObjectBaseToPtr(tgeometry as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref geometry;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(iciw);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dimension;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IntersectionUtils.MethodInfoStoreGeneric_Intersection_Public_Static_IIntersection_TGeometry_ICanIntersectWith_1_TGeometry_IntersectionDimension_0<TGeometry>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<IIntersection>(intPtr4) : null;
		}

		// Token: 0x06000707 RID: 1799 RVA: 0x0003639C File Offset: 0x0003459C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 557068, RefRangeEnd = 557069, XrefRangeStart = 557040, XrefRangeEnd = 557068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Nullable<ValueTuple<DwdVector2Floating, double>> ClosestPointOfIntersectionTo(this IIntersection intersection, DwdVector2Floating toPoint)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(intersection);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref toPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntersectionUtils.NativeMethodInfoPtr_ClosestPointOfIntersectionTo_Public_Static_Nullable_1_ValueTuple_2_DwdVector2Floating_Double_IIntersection_DwdVector2Floating_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Nullable<ValueTuple<DwdVector2Floating, double>>(intPtr);
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x000363E8 File Offset: 0x000345E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 557069, XrefRangeEnd = 557086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Nullable<ValueTuple<DwdVector2Floating, double>> Method_Internal_Static_Nullable_1_ValueTuple_2_DwdVector2Floating_Double_IEnumerable_1_DwdVector2Floating_DwdVector2Floating_PDM_0(IEnumerable<DwdVector2Floating> ensemble, DwdVector2Floating toP)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ensemble);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref toP;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntersectionUtils.NativeMethodInfoPtr_Method_Internal_Static_Nullable_1_ValueTuple_2_DwdVector2Floating_Double_IEnumerable_1_DwdVector2Floating_DwdVector2Floating_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Nullable<ValueTuple<DwdVector2Floating, double>>(intPtr);
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x00036434 File Offset: 0x00034634
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 557099, RefRangeEnd = 557100, XrefRangeStart = 557086, XrefRangeEnd = 557099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Nullable<ValueTuple<DwdVector2Floating, double>> Method_Internal_Static_Nullable_1_ValueTuple_2_DwdVector2Floating_Double_IEnumerable_1_ValueTuple_2_DwdVector2Floating_Double_PDM_0(IEnumerable<ValueTuple<DwdVector2Floating, double>> ensemble)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ensemble);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntersectionUtils.NativeMethodInfoPtr_Method_Internal_Static_Nullable_1_ValueTuple_2_DwdVector2Floating_Double_IEnumerable_1_ValueTuple_2_DwdVector2Floating_Double_PDM_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<ValueTuple<DwdVector2Floating, double>>(intPtr);
			}
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x00004ACF File Offset: 0x00002CCF
		public IntersectionUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x0600070B RID: 1803 RVA: 0x00036470 File Offset: 0x00034670
		// (set) Token: 0x0600070C RID: 1804 RVA: 0x00004AD8 File Offset: 0x00002CD8
		public unsafe static IComparer<ValueTuple<DwdVector2Floating, double>> PointDistanceComparer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IntersectionUtils.NativeFieldInfoPtr_PointDistanceComparer, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IComparer<ValueTuple<DwdVector2Floating, double>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IntersectionUtils.NativeFieldInfoPtr_PointDistanceComparer, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040004E1 RID: 1249
		private static readonly IntPtr NativeFieldInfoPtr_PointDistanceComparer;

		// Token: 0x040004E2 RID: 1250
		private static readonly IntPtr NativeMethodInfoPtr_Exists_Public_Static_Boolean_IIntersection_0;

		// Token: 0x040004E3 RID: 1251
		private static readonly IntPtr NativeMethodInfoPtr_Intersects_Public_Static_Boolean_TGeometry_ICanIntersectWith_1_TGeometry_IntersectionDimension_0;

		// Token: 0x040004E4 RID: 1252
		private static readonly IntPtr NativeMethodInfoPtr_Intersection_Public_Static_IIntersection_TGeometry_ICanIntersectWith_1_TGeometry_IntersectionDimension_0;

		// Token: 0x040004E5 RID: 1253
		private static readonly IntPtr NativeMethodInfoPtr_ClosestPointOfIntersectionTo_Public_Static_Nullable_1_ValueTuple_2_DwdVector2Floating_Double_IIntersection_DwdVector2Floating_0;

		// Token: 0x040004E6 RID: 1254
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Nullable_1_ValueTuple_2_DwdVector2Floating_Double_IEnumerable_1_DwdVector2Floating_DwdVector2Floating_PDM_0;

		// Token: 0x040004E7 RID: 1255
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Nullable_1_ValueTuple_2_DwdVector2Floating_Double_IEnumerable_1_ValueTuple_2_DwdVector2Floating_Double_PDM_0;

		// Token: 0x020002CF RID: 719
		[ObfuscatedName("Canis.mathLib.intersections.IntersectionUtils+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001E45 RID: 7749 RVA: 0x0008CFB4 File Offset: 0x0008B1B4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<IntersectionUtils.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IntersectionUtils>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntersectionUtils.__c>.NativeClassPtr);
				IntersectionUtils.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntersectionUtils.__c>.NativeClassPtr, "<>9");
				IntersectionUtils.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntersectionUtils.__c>.NativeClassPtr, 100664754);
				IntersectionUtils.__c.NativeMethodInfoPtr___cctor_b__5_0_Internal_Double_ValueTuple_2_DwdVector2Floating_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntersectionUtils.__c>.NativeClassPtr, 100664755);
			}

			// Token: 0x06001E46 RID: 7750 RVA: 0x0008D01C File Offset: 0x0008B21C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntersectionUtils.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntersectionUtils.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E47 RID: 7751 RVA: 0x0008D058 File Offset: 0x0008B258
			[CallerCount(0)]
			public unsafe double __cctor_b__5_0(ValueTuple<DwdVector2Floating, double> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntersectionUtils.__c.NativeMethodInfoPtr___cctor_b__5_0_Internal_Double_ValueTuple_2_DwdVector2Floating_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001E48 RID: 7752 RVA: 0x0000E934 File Offset: 0x0000CB34
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000716 RID: 1814
			// (get) Token: 0x06001E49 RID: 7753 RVA: 0x0008D0AC File Offset: 0x0008B2AC
			// (set) Token: 0x06001E4A RID: 7754 RVA: 0x0000E93D File Offset: 0x0000CB3D
			public unsafe static IntersectionUtils.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IntersectionUtils.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IntersectionUtils.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IntersectionUtils.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001329 RID: 4905
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400132A RID: 4906
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400132B RID: 4907
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__5_0_Internal_Double_ValueTuple_2_DwdVector2Floating_Double_0;
		}

		// Token: 0x020002D0 RID: 720
		[ObfuscatedName("Canis.mathLib.intersections.IntersectionUtils+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x06001E4B RID: 7755 RVA: 0x0008D0D4 File Offset: 0x0008B2D4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<IntersectionUtils.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IntersectionUtils>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntersectionUtils.__c__DisplayClass3_0>.NativeClassPtr);
				IntersectionUtils.__c__DisplayClass3_0.NativeFieldInfoPtr_toPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntersectionUtils.__c__DisplayClass3_0>.NativeClassPtr, "toPoint");
				IntersectionUtils.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntersectionUtils.__c__DisplayClass3_0>.NativeClassPtr, 100664756);
				IntersectionUtils.__c__DisplayClass3_0.NativeMethodInfoPtr__ClosestPointOfIntersectionTo_b__3_Internal_IEnumerable_1_ValueTuple_2_DwdVector2Floating_Double_IIntersection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntersectionUtils.__c__DisplayClass3_0>.NativeClassPtr, 100664757);
			}

			// Token: 0x06001E4C RID: 7756 RVA: 0x0008D13C File Offset: 0x0008B33C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntersectionUtils.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntersectionUtils.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E4D RID: 7757 RVA: 0x0008D178 File Offset: 0x0008B378
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 556983, XrefRangeEnd = 556990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<ValueTuple<DwdVector2Floating, double>> _ClosestPointOfIntersectionTo_b__3(IIntersection subIntersection)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(subIntersection);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntersectionUtils.__c__DisplayClass3_0.NativeMethodInfoPtr__ClosestPointOfIntersectionTo_b__3_Internal_IEnumerable_1_ValueTuple_2_DwdVector2Floating_Double_IIntersection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ValueTuple<DwdVector2Floating, double>>>(intPtr3) : null;
				}
			}

			// Token: 0x06001E4E RID: 7758 RVA: 0x0000E94F File Offset: 0x0000CB4F
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000717 RID: 1815
			// (get) Token: 0x06001E4F RID: 7759 RVA: 0x0008D1C8 File Offset: 0x0008B3C8
			// (set) Token: 0x06001E50 RID: 7760 RVA: 0x0000E958 File Offset: 0x0000CB58
			public unsafe DwdVector2Floating toPoint
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntersectionUtils.__c__DisplayClass3_0.NativeFieldInfoPtr_toPoint);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntersectionUtils.__c__DisplayClass3_0.NativeFieldInfoPtr_toPoint)) = value;
				}
			}

			// Token: 0x0400132C RID: 4908
			private static readonly IntPtr NativeFieldInfoPtr_toPoint;

			// Token: 0x0400132D RID: 4909
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400132E RID: 4910
			private static readonly IntPtr NativeMethodInfoPtr__ClosestPointOfIntersectionTo_b__3_Internal_IEnumerable_1_ValueTuple_2_DwdVector2Floating_Double_IIntersection_0;
		}

		// Token: 0x020002D1 RID: 721
		[ObfuscatedName("Canis.mathLib.intersections.IntersectionUtils+<>c__DisplayClass3_1")]
		public sealed class __c__DisplayClass3_1 : Object
		{
			// Token: 0x06001E51 RID: 7761 RVA: 0x0008D1F0 File Offset: 0x0008B3F0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_1()
			{
				Il2CppClassPointerStore<IntersectionUtils.__c__DisplayClass3_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IntersectionUtils>.NativeClassPtr, "<>c__DisplayClass3_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntersectionUtils.__c__DisplayClass3_1>.NativeClassPtr);
				IntersectionUtils.__c__DisplayClass3_1.NativeFieldInfoPtr_toP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntersectionUtils.__c__DisplayClass3_1>.NativeClassPtr, "toP");
				IntersectionUtils.__c__DisplayClass3_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntersectionUtils.__c__DisplayClass3_1>.NativeClassPtr, 100664758);
				IntersectionUtils.__c__DisplayClass3_1.NativeMethodInfoPtr__ClosestPointOfIntersectionTo_b__2_Internal_ValueTuple_2_DwdVector2Floating_Double_DwdVector2Floating_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntersectionUtils.__c__DisplayClass3_1>.NativeClassPtr, 100664759);
			}

			// Token: 0x06001E52 RID: 7762 RVA: 0x0008D258 File Offset: 0x0008B458
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntersectionUtils.__c__DisplayClass3_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntersectionUtils.__c__DisplayClass3_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E53 RID: 7763 RVA: 0x0008D294 File Offset: 0x0008B494
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 556990, XrefRangeEnd = 556995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple<DwdVector2Floating, double> _ClosestPointOfIntersectionTo_b__2(DwdVector2Floating point)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref point;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntersectionUtils.__c__DisplayClass3_1.NativeMethodInfoPtr__ClosestPointOfIntersectionTo_b__2_Internal_ValueTuple_2_DwdVector2Floating_Double_DwdVector2Floating_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ValueTuple<DwdVector2Floating, double>(intPtr);
				}
			}

			// Token: 0x06001E54 RID: 7764 RVA: 0x0000E973 File Offset: 0x0000CB73
			public __c__DisplayClass3_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000718 RID: 1816
			// (get) Token: 0x06001E55 RID: 7765 RVA: 0x0008D2D8 File Offset: 0x0008B4D8
			// (set) Token: 0x06001E56 RID: 7766 RVA: 0x0000E97C File Offset: 0x0000CB7C
			public unsafe DwdVector2Floating toP
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntersectionUtils.__c__DisplayClass3_1.NativeFieldInfoPtr_toP);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntersectionUtils.__c__DisplayClass3_1.NativeFieldInfoPtr_toP)) = value;
				}
			}

			// Token: 0x0400132F RID: 4911
			private static readonly IntPtr NativeFieldInfoPtr_toP;

			// Token: 0x04001330 RID: 4912
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001331 RID: 4913
			private static readonly IntPtr NativeMethodInfoPtr__ClosestPointOfIntersectionTo_b__2_Internal_ValueTuple_2_DwdVector2Floating_Double_DwdVector2Floating_0;
		}

		// Token: 0x020002D2 RID: 722
		private sealed class MethodInfoStoreGeneric_Intersects_Public_Static_Boolean_TGeometry_ICanIntersectWith_1_TGeometry_IntersectionDimension_0<TGeometry>
		{
			// Token: 0x04001332 RID: 4914
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(IntersectionUtils.NativeMethodInfoPtr_Intersects_Public_Static_Boolean_TGeometry_ICanIntersectWith_1_TGeometry_IntersectionDimension_0, Il2CppClassPointerStore<IntersectionUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TGeometry>.NativeClassPtr)) }))));
		}

		// Token: 0x020002D3 RID: 723
		private sealed class MethodInfoStoreGeneric_Intersection_Public_Static_IIntersection_TGeometry_ICanIntersectWith_1_TGeometry_IntersectionDimension_0<TGeometry>
		{
			// Token: 0x04001333 RID: 4915
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(IntersectionUtils.NativeMethodInfoPtr_Intersection_Public_Static_IIntersection_TGeometry_ICanIntersectWith_1_TGeometry_IntersectionDimension_0, Il2CppClassPointerStore<IntersectionUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TGeometry>.NativeClassPtr)) }))));
		}
	}
}
