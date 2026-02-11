using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Canis.mathLib
{
	// Token: 0x02000070 RID: 112
	public static class AngularSilhouette : Object
	{
		// Token: 0x06000609 RID: 1545 RVA: 0x00030FE0 File Offset: 0x0002F1E0
		// Note: this type is marked as 'beforefieldinit'.
		static AngularSilhouette()
		{
			Il2CppClassPointerStore<AngularSilhouette>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.mathLib", "AngularSilhouette");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AngularSilhouette>.NativeClassPtr);
			AngularSilhouette.NativeMethodInfoPtr_CalculateAngularSilhouette_Public_Static_List_1_ValueTuple_2_Segment_T_Arc_List_1_ValueTuple_2_Polygon_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AngularSilhouette>.NativeClassPtr, 100664515);
			AngularSilhouette.NativeMethodInfoPtr_Method_Internal_Static_Void_DwdVector2Floating_Segment_T_byref___c__DisplayClass0_6_1_T_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AngularSilhouette>.NativeClassPtr, 100664516);
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x00031038 File Offset: 0x0002F238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 555782, XrefRangeEnd = 555905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<ValueTuple<Segment, T>> CalculateAngularSilhouette<T>(this Arc self, List<ValueTuple<Polygon, T>> shapesOfConcern) where T : class
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(shapesOfConcern);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AngularSilhouette.MethodInfoStoreGeneric_CalculateAngularSilhouette_Public_Static_List_1_ValueTuple_2_Segment_T_Arc_List_1_ValueTuple_2_Polygon_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ValueTuple<Segment, T>>>(intPtr3) : null;
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x0003108C File Offset: 0x0002F28C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 555905, XrefRangeEnd = 555922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Internal_Static_Void_DwdVector2Floating_Segment_T_byref___c__DisplayClass0_6_1_T_PDM_0<T>(DwdVector2Floating point, Segment geometry, T pointOwner, ref AngularSilhouette.__c__DisplayClass0_6<T> A_3) where T : class
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref point;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref geometry;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = pointOwner;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref pointOwner;
			}
			ptr2 = intPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(A_3);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AngularSilhouette.MethodInfoStoreGeneric_Method_Internal_Static_Void_DwdVector2Floating_Segment_T_byref___c__DisplayClass0_6_1_T_PDM_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x000048FB File Offset: 0x00002AFB
		public AngularSilhouette(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003DC RID: 988
		private static readonly IntPtr NativeMethodInfoPtr_CalculateAngularSilhouette_Public_Static_List_1_ValueTuple_2_Segment_T_Arc_List_1_ValueTuple_2_Polygon_T_0;

		// Token: 0x040003DD RID: 989
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_DwdVector2Floating_Segment_T_byref___c__DisplayClass0_6_1_T_PDM_0;

		// Token: 0x020002C0 RID: 704
		public sealed class PolyVertexInfo<T> : ValueType
		{
			// Token: 0x06001DCA RID: 7626 RVA: 0x0008B5C0 File Offset: 0x000897C0
			// Note: this type is marked as 'beforefieldinit'.
			static PolyVertexInfo()
			{
				Il2CppClassPointerStore<AngularSilhouette.PolyVertexInfo<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AngularSilhouette>.NativeClassPtr, "PolyVertexInfo`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AngularSilhouette.PolyVertexInfo<T>>.NativeClassPtr);
				AngularSilhouette.PolyVertexInfo<T>.NativeFieldInfoPtr_self = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AngularSilhouette.PolyVertexInfo<T>>.NativeClassPtr, "self");
				AngularSilhouette.PolyVertexInfo<T>.NativeFieldInfoPtr_angle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AngularSilhouette.PolyVertexInfo<T>>.NativeClassPtr, "angle");
				AngularSilhouette.PolyVertexInfo<T>.NativeFieldInfoPtr_relatedEdges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AngularSilhouette.PolyVertexInfo<T>>.NativeClassPtr, "relatedEdges");
			}

			// Token: 0x06001DCB RID: 7627 RVA: 0x0000E4EC File Offset: 0x0000C6EC
			public PolyVertexInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001DCC RID: 7628 RVA: 0x0000E4F5 File Offset: 0x0000C6F5
			public PolyVertexInfo()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AngularSilhouette.PolyVertexInfo<T>>.NativeClassPtr))
			{
			}

			// Token: 0x170006F6 RID: 1782
			// (get) Token: 0x06001DCD RID: 7629 RVA: 0x0008B664 File Offset: 0x00089864
			// (set) Token: 0x06001DCE RID: 7630 RVA: 0x0000E507 File Offset: 0x0000C707
			public unsafe DwdVector2Floating self
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AngularSilhouette.PolyVertexInfo<T>.NativeFieldInfoPtr_self);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AngularSilhouette.PolyVertexInfo<T>.NativeFieldInfoPtr_self)) = value;
				}
			}

			// Token: 0x170006F7 RID: 1783
			// (get) Token: 0x06001DCF RID: 7631 RVA: 0x0008B68C File Offset: 0x0008988C
			// (set) Token: 0x06001DD0 RID: 7632 RVA: 0x0000E522 File Offset: 0x0000C722
			public unsafe AngleRadians angle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AngularSilhouette.PolyVertexInfo<T>.NativeFieldInfoPtr_angle);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AngularSilhouette.PolyVertexInfo<T>.NativeFieldInfoPtr_angle)) = value;
				}
			}

			// Token: 0x170006F8 RID: 1784
			// (get) Token: 0x06001DD1 RID: 7633 RVA: 0x0008B6B4 File Offset: 0x000898B4
			// (set) Token: 0x06001DD2 RID: 7634 RVA: 0x0000E53D File Offset: 0x0000C73D
			public unsafe List<ValueTuple<Segment, T>> relatedEdges
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AngularSilhouette.PolyVertexInfo<T>.NativeFieldInfoPtr_relatedEdges);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ValueTuple<Segment, T>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AngularSilhouette.PolyVertexInfo<T>.NativeFieldInfoPtr_relatedEdges), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040012E4 RID: 4836
			private static readonly IntPtr NativeFieldInfoPtr_self;

			// Token: 0x040012E5 RID: 4837
			private static readonly IntPtr NativeFieldInfoPtr_angle;

			// Token: 0x040012E6 RID: 4838
			private static readonly IntPtr NativeFieldInfoPtr_relatedEdges;
		}

		// Token: 0x020002C1 RID: 705
		[ObfuscatedName("Canis.mathLib.AngularSilhouette+<>c__0`1")]
		[Serializable]
		public sealed class __c__0<T> : Object where T : class
		{
			// Token: 0x06001DD3 RID: 7635 RVA: 0x0008B6E4 File Offset: 0x000898E4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__0()
			{
				Il2CppClassPointerStore<AngularSilhouette.__c__0<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AngularSilhouette>.NativeClassPtr, "<>c__0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AngularSilhouette.__c__0<T>>.NativeClassPtr);
				AngularSilhouette.__c__0<T>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AngularSilhouette.__c__0<T>>.NativeClassPtr, "<>9");
				AngularSilhouette.__c__0<T>.NativeFieldInfoPtr___9__0_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AngularSilhouette.__c__0<T>>.NativeClassPtr, "<>9__0_1");
				AngularSilhouette.__c__0<T>.NativeFieldInfoPtr___9__0_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AngularSilhouette.__c__0<T>>.NativeClassPtr, "<>9__0_2");
				AngularSilhouette.__c__0<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AngularSilhouette.__c__0<T>>.NativeClassPtr, 100664518);
				AngularSilhouette.__c__0<T>.NativeMethodInfoPtr__CalculateAngularSilhouette_b__0_1_Internal_T_ValueTuple_2_Polygon_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AngularSilhouette.__c__0<T>>.NativeClassPtr, 100664519);
				AngularSilhouette.__c__0<T>.NativeMethodInfoPtr__CalculateAngularSilhouette_b__0_2_Internal_Il2CppStructArray_1_Segment_ValueTuple_2_Polygon_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AngularSilhouette.__c__0<T>>.NativeClassPtr, 100664520);
			}

			// Token: 0x06001DD4 RID: 7636 RVA: 0x0008B7C4 File Offset: 0x000899C4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AngularSilhouette.__c__0<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AngularSilhouette.__c__0<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001DD5 RID: 7637 RVA: 0x0008B800 File Offset: 0x00089A00
			[CallerCount(0)]
			public unsafe T _CalculateAngularSilhouette_b__0_1(ValueTuple<Polygon, T> polyWithOwner)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(polyWithOwner));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AngularSilhouette.__c__0<T>.NativeMethodInfoPtr__CalculateAngularSilhouette_b__0_1_Internal_T_ValueTuple_2_Polygon_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x06001DD6 RID: 7638 RVA: 0x0008B850 File Offset: 0x00089A50
			[CallerCount(0)]
			public unsafe Il2CppStructArray<Segment> _CalculateAngularSilhouette_b__0_2(ValueTuple<Polygon, T> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AngularSilhouette.__c__0<T>.NativeMethodInfoPtr__CalculateAngularSilhouette_b__0_2_Internal_Il2CppStructArray_1_Segment_ValueTuple_2_Polygon_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Segment>>(intPtr3) : null;
				}
			}

			// Token: 0x06001DD7 RID: 7639 RVA: 0x0000E55C File Offset: 0x0000C75C
			public __c__0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006F9 RID: 1785
			// (get) Token: 0x06001DD8 RID: 7640 RVA: 0x0008B8A8 File Offset: 0x00089AA8
			// (set) Token: 0x06001DD9 RID: 7641 RVA: 0x0000E565 File Offset: 0x0000C765
			public unsafe static AngularSilhouette.__c__0<T> __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AngularSilhouette.__c__0<T>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AngularSilhouette.__c__0<T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AngularSilhouette.__c__0<T>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006FA RID: 1786
			// (get) Token: 0x06001DDA RID: 7642 RVA: 0x0008B8D0 File Offset: 0x00089AD0
			// (set) Token: 0x06001DDB RID: 7643 RVA: 0x0000E577 File Offset: 0x0000C777
			public unsafe static Func<ValueTuple<Polygon, T>, T> __9__0_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AngularSilhouette.__c__0<T>.NativeFieldInfoPtr___9__0_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<Polygon, T>, T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AngularSilhouette.__c__0<T>.NativeFieldInfoPtr___9__0_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006FB RID: 1787
			// (get) Token: 0x06001DDC RID: 7644 RVA: 0x0008B8F8 File Offset: 0x00089AF8
			// (set) Token: 0x06001DDD RID: 7645 RVA: 0x0000E589 File Offset: 0x0000C789
			public unsafe static Func<ValueTuple<Polygon, T>, Il2CppStructArray<Segment>> __9__0_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AngularSilhouette.__c__0<T>.NativeFieldInfoPtr___9__0_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<Polygon, T>, Il2CppStructArray<Segment>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AngularSilhouette.__c__0<T>.NativeFieldInfoPtr___9__0_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040012E7 RID: 4839
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040012E8 RID: 4840
			private static readonly IntPtr NativeFieldInfoPtr___9__0_1;

			// Token: 0x040012E9 RID: 4841
			private static readonly IntPtr NativeFieldInfoPtr___9__0_2;

			// Token: 0x040012EA RID: 4842
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040012EB RID: 4843
			private static readonly IntPtr NativeMethodInfoPtr__CalculateAngularSilhouette_b__0_1_Internal_T_ValueTuple_2_Polygon_T_0;

			// Token: 0x040012EC RID: 4844
			private static readonly IntPtr NativeMethodInfoPtr__CalculateAngularSilhouette_b__0_2_Internal_Il2CppStructArray_1_Segment_ValueTuple_2_Polygon_T_0;
		}

		// Token: 0x020002C2 RID: 706
		[ObfuscatedName("Canis.mathLib.AngularSilhouette+<>c__DisplayClass0_0`1")]
		public sealed class __c__DisplayClass0_0<T> : Object where T : class
		{
			// Token: 0x06001DDE RID: 7646 RVA: 0x0008B920 File Offset: 0x00089B20
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass0_0()
			{
				Il2CppClassPointerStore<AngularSilhouette.__c__DisplayClass0_0<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AngularSilhouette>.NativeClassPtr, "<>c__DisplayClass0_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AngularSilhouette.__c__DisplayClass0_0<T>>.NativeClassPtr);
				AngularSilhouette.__c__DisplayClass0_0<T>.NativeFieldInfoPtr_arcCenter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AngularSilhouette.__c__DisplayClass0_0<T>>.NativeClassPtr, "arcCenter");
				AngularSilhouette.__c__DisplayClass0_0<T>.NativeFieldInfoPtr_edgesByOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AngularSilhouette.__c__DisplayClass0_0<T>>.NativeClassPtr, "edgesByOwner");
				AngularSilhouette.__c__DisplayClass0_0<T>.NativeFieldInfoPtr_twoPi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AngularSilhouette.__c__DisplayClass0_0<T>>.NativeClassPtr, "twoPi");
				AngularSilhouette.__c__DisplayClass0_0<T>.NativeFieldInfoPtr_cwAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AngularSilhouette.__c__DisplayClass0_0<T>>.NativeClassPtr, "cwAngle");
				AngularSilhouette.__c__DisplayClass0_0<T>.NativeFieldInfoPtr_activeGeometry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AngularSilhouette.__c__DisplayClass0_0<T>>.NativeClassPtr, "activeGeometry");
				AngularSilhouette.__c__DisplayClass0_0<T>.NativeFieldInfoPtr_seenPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AngularSilhouette.__c__DisplayClass0_0<T>>.NativeClassPtr, "seenPoints");
				AngularSilhouette.__c__DisplayClass0_0<T>.NativeFieldInfoPtr___9__13 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AngularSilhouette.__c__DisplayClass0_0<T>>.NativeClassPtr, "<>9__13");
				AngularSilhouette.__c__DisplayClass0_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AngularSilhouette.__c__DisplayClass0_0<T>>.NativeClassPtr, 100664521);
				AngularSilhouette.__c__DisplayClass0_0<T>.NativeMethodInfoPtr__CalculateAngularSilhouette_b__0_Internal_IEnumerable_1_PolyVertexInfo_1_T_ValueTuple_2_Polygon_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AngularSilhouette.__c__DisplayClass0_0<T>>.NativeClassPtr, 100664522);
				AngularSilhouette.__c__DisplayClass0_0<T>.NativeMethodInfoPtr__CalculateAngularSilhouette_b__3_Internal_IEnumerable_1_PolyVertexInfo_1_T_KeyValuePair_2_T_Il2CppStructArray_1_Segment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AngularSilhouette.__c__DisplayClass0_0<T>>.NativeClassPtr, 100664523);
				AngularSilhouette.__c__DisplayClass0_0<T>.NativeMethodInfoPtr__CalculateAngularSilhouette_b__4_Internal_Double_PolyVertexInfo_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AngularSilhouette.__c__DisplayClass0_0<T>>.NativeClassPtr, 100664524);
				AngularSilhouette.__c__DisplayClass0_0<T>.NativeMethodInfoPtr_Method_Internal_Void_PolyVertexInfo_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AngularSilhouette.__c__DisplayClass0_0<T>>.NativeClassPtr, 100664525);
				AngularSilhouette.__c__DisplayClass0_0<T>.NativeMethodInfoPtr__CalculateAngularSilhouette_b__13_Internal_Boolean_ValueTuple_2_Segment_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AngularSilhouette.__c__DisplayClass0_0<T>>.NativeClassPtr, 100664526);
			}

			// Token: 0x06001DDF RID: 7647 RVA: 0x0008BA8C File Offset: 0x00089C8C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass0_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AngularSilhouette.__c__DisplayClass0_0<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AngularSilhouette.__c__DisplayClass0_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001DE0 RID: 7648 RVA: 0x0008BAC8 File Offset: 0x00089CC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 555621, XrefRangeEnd = 555651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<AngularSilhouette.PolyVertexInfo<T>> _CalculateAngularSilhouette_b__0(ValueTuple<Polygon, T> polyWithOwner)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(polyWithOwner));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AngularSilhouette.__c__DisplayClass0_0<T>.NativeMethodInfoPtr__CalculateAngularSilhouette_b__0_Internal_IEnumerable_1_PolyVertexInfo_1_T_ValueTuple_2_Polygon_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<AngularSilhouette.PolyVertexInfo<T>>>(intPtr3) : null;
				}
			}

			// Token: 0x06001DE1 RID: 7649 RVA: 0x0008BB20 File Offset: 0x00089D20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 555651, XrefRangeEnd = 555666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<AngularSilhouette.PolyVertexInfo<T>> _CalculateAngularSilhouette_b__3(KeyValuePair<T, Il2CppStructArray<Segment>> edgesForOwner)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(edgesForOwner));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AngularSilhouette.__c__DisplayClass0_0<T>.NativeMethodInfoPtr__CalculateAngularSilhouette_b__3_Internal_IEnumerable_1_PolyVertexInfo_1_T_KeyValuePair_2_T_Il2CppStructArray_1_Segment_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<AngularSilhouette.PolyVertexInfo<T>>>(intPtr3) : null;
				}
			}

			// Token: 0x06001DE2 RID: 7650 RVA: 0x0008BB78 File Offset: 0x00089D78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 555666, XrefRangeEnd = 555667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe double _CalculateAngularSilhouette_b__4(AngularSilhouette.PolyVertexInfo<T> pvi)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(pvi));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AngularSilhouette.__c__DisplayClass0_0<T>.NativeMethodInfoPtr__CalculateAngularSilhouette_b__4_Internal_Double_PolyVertexInfo_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001DE3 RID: 7651 RVA: 0x0008BBCC File Offset: 0x00089DCC
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 555683, RefRangeEnd = 555685, XrefRangeStart = 555667, XrefRangeEnd = 555683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PolyVertexInfo_1_T_0(AngularSilhouette.PolyVertexInfo<T> vertex)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(vertex));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AngularSilhouette.__c__DisplayClass0_0<T>.NativeMethodInfoPtr_Method_Internal_Void_PolyVertexInfo_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001DE4 RID: 7652 RVA: 0x0008BC14 File Offset: 0x00089E14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 555685, XrefRangeEnd = 555697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CalculateAngularSilhouette_b__13(ValueTuple<Segment, T> tup)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tup));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AngularSilhouette.__c__DisplayClass0_0<T>.NativeMethodInfoPtr__CalculateAngularSilhouette_b__13_Internal_Boolean_ValueTuple_2_Segment_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001DE5 RID: 7653 RVA: 0x0000E59B File Offset: 0x0000C79B
			public __c__DisplayClass0_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006FC RID: 1788
			// (get) Token: 0x06001DE6 RID: 7654 RVA: 0x0008BC68 File Offset: 0x00089E68
			// (set) Token: 0x06001DE7 RID: 7655 RVA: 0x0000E5A4 File Offset: 0x0000C7A4
			public unsafe DwdVector2Floating arcCenter
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AngularSilhouette.__c__DisplayClass0_0<T>.NativeFieldInfoPtr_arcCenter);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AngularSilhouette.__c__DisplayClass0_0<T>.NativeFieldInfoPtr_arcCenter)) = value;
				}
			}

			// Token: 0x170006FD RID: 1789
			// (get) Token: 0x06001DE8 RID: 7656 RVA: 0x0008BC90 File Offset: 0x00089E90
			// (set) Token: 0x06001DE9 RID: 7657 RVA: 0x0000E5BF File Offset: 0x0000C7BF
			public unsafe Dictionary<T, Il2CppStructArray<Segment>> edgesByOwner
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AngularSilhouette.__c__DisplayClass0_0<T>.NativeFieldInfoPtr_edgesByOwner);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<T, Il2CppStructArray<Segment>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AngularSilhouette.__c__DisplayClass0_0<T>.NativeFieldInfoPtr_edgesByOwner), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006FE RID: 1790
			// (get) Token: 0x06001DEA RID: 7658 RVA: 0x0008BCC0 File Offset: 0x00089EC0
			// (set) Token: 0x06001DEB RID: 7659 RVA: 0x0000E5DE File Offset: 0x0000C7DE
			public unsafe double twoPi
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AngularSilhouette.__c__DisplayClass0_0<T>.NativeFieldInfoPtr_twoPi);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AngularSilhouette.__c__DisplayClass0_0<T>.NativeFieldInfoPtr_twoPi)) = value;
				}
			}

			// Token: 0x170006FF RID: 1791
			// (get) Token: 0x06001DEC RID: 7660 RVA: 0x0008BCE8 File Offset: 0x00089EE8
			// (set) Token: 0x06001DED RID: 7661 RVA: 0x0000E5F9 File Offset: 0x0000C7F9
			public unsafe AngleRadians cwAngle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AngularSilhouette.__c__DisplayClass0_0<T>.NativeFieldInfoPtr_cwAngle);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AngularSilhouette.__c__DisplayClass0_0<T>.NativeFieldInfoPtr_cwAngle)) = value;
				}
			}

			// Token: 0x17000700 RID: 1792
			// (get) Token: 0x06001DEE RID: 7662 RVA: 0x0008BD10 File Offset: 0x00089F10
			// (set) Token: 0x06001DEF RID: 7663 RVA: 0x0000E614 File Offset: 0x0000C814
			public unsafe List<ValueTuple<Segment, T>> activeGeometry
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AngularSilhouette.__c__DisplayClass0_0<T>.NativeFieldInfoPtr_activeGeometry);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ValueTuple<Segment, T>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AngularSilhouette.__c__DisplayClass0_0<T>.NativeFieldInfoPtr_activeGeometry), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000701 RID: 1793
			// (get) Token: 0x06001DF0 RID: 7664 RVA: 0x0008BD40 File Offset: 0x00089F40
			// (set) Token: 0x06001DF1 RID: 7665 RVA: 0x0000E633 File Offset: 0x0000C833
			public unsafe HashSet<AngularSilhouette.PolyVertexInfo<T>> seenPoints
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AngularSilhouette.__c__DisplayClass0_0<T>.NativeFieldInfoPtr_seenPoints);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<AngularSilhouette.PolyVertexInfo<T>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AngularSilhouette.__c__DisplayClass0_0<T>.NativeFieldInfoPtr_seenPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000702 RID: 1794
			// (get) Token: 0x06001DF2 RID: 7666 RVA: 0x0008BD70 File Offset: 0x00089F70
			// (set) Token: 0x06001DF3 RID: 7667 RVA: 0x0000E652 File Offset: 0x0000C852
			public unsafe Func<ValueTuple<Segment, T>, bool> __9__13
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AngularSilhouette.__c__DisplayClass0_0<T>.NativeFieldInfoPtr___9__13);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<Segment, T>, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AngularSilhouette.__c__DisplayClass0_0<T>.NativeFieldInfoPtr___9__13), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040012ED RID: 4845
			private static readonly IntPtr NativeFieldInfoPtr_arcCenter;

			// Token: 0x040012EE RID: 4846
			private static readonly IntPtr NativeFieldInfoPtr_edgesByOwner;

			// Token: 0x040012EF RID: 4847
			private static readonly IntPtr NativeFieldInfoPtr_twoPi;

			// Token: 0x040012F0 RID: 4848
			private static readonly IntPtr NativeFieldInfoPtr_cwAngle;

			// Token: 0x040012F1 RID: 4849
			private static readonly IntPtr NativeFieldInfoPtr_activeGeometry;

			// Token: 0x040012F2 RID: 4850
			private static readonly IntPtr NativeFieldInfoPtr_seenPoints;

			// Token: 0x040012F3 RID: 4851
			private static readonly IntPtr NativeFieldInfoPtr___9__13;

			// Token: 0x040012F4 RID: 4852
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040012F5 RID: 4853
			private static readonly IntPtr NativeMethodInfoPtr__CalculateAngularSilhouette_b__0_Internal_IEnumerable_1_PolyVertexInfo_1_T_ValueTuple_2_Polygon_T_0;

			// Token: 0x040012F6 RID: 4854
			private static readonly IntPtr NativeMethodInfoPtr__CalculateAngularSilhouette_b__3_Internal_IEnumerable_1_PolyVertexInfo_1_T_KeyValuePair_2_T_Il2CppStructArray_1_Segment_0;

			// Token: 0x040012F7 RID: 4855
			private static readonly IntPtr NativeMethodInfoPtr__CalculateAngularSilhouette_b__4_Internal_Double_PolyVertexInfo_1_T_0;

			// Token: 0x040012F8 RID: 4856
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PolyVertexInfo_1_T_0;

			// Token: 0x040012F9 RID: 4857
			private static readonly IntPtr NativeMethodInfoPtr__CalculateAngularSilhouette_b__13_Internal_Boolean_ValueTuple_2_Segment_T_0;
		}

		// Token: 0x020002C3 RID: 707
		[ObfuscatedName("Canis.mathLib.AngularSilhouette+<>c__DisplayClass0_1`1")]
		public sealed class __c__DisplayClass0_1<T> : Object where T : class
		{
			// Token: 0x06001DF4 RID: 7668 RVA: 0x0008BDA0 File Offset: 0x00089FA0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass0_1()
			{
				Il2CppClassPointerStore<AngularSilhouette.__c__DisplayClass0_1<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AngularSilhouette>.NativeClassPtr, "<>c__DisplayClass0_1`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AngularSilhouette.__c__DisplayClass0_1<T>>.NativeClassPtr);
				AngularSilhouette.__c__DisplayClass0_1<T>.NativeFieldInfoPtr_owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AngularSilhouette.__c__DisplayClass0_1<T>>.NativeClassPtr, "owner");
				AngularSilhouette.__c__DisplayClass0_1<T>.NativeFieldInfoPtr_field_Public___c__DisplayClass0_0_1_T_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AngularSilhouette.__c__DisplayClass0_1<T>>.NativeClassPtr, "CS$<>8__locals1");
				AngularSilhouette.__c__DisplayClass0_1<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AngularSilhouette.__c__DisplayClass0_1<T>>.NativeClassPtr, 100664527);
				AngularSilhouette.__c__DisplayClass0_1<T>.NativeMethodInfoPtr__CalculateAngularSilhouette_b__6_Internal_PolyVertexInfo_1_T_ArraySegment_1_DwdVector2Floating_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AngularSilhouette.__c__DisplayClass0_1<T>>.NativeClassPtr, 100664528);
			}

			// Token: 0x06001DF5 RID: 7669 RVA: 0x0008BE58 File Offset: 0x0008A058
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass0_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AngularSilhouette.__c__DisplayClass0_1<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AngularSilhouette.__c__DisplayClass0_1<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001DF6 RID: 7670 RVA: 0x0008BE94 File Offset: 0x0008A094
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 555697, XrefRangeEnd = 555723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AngularSilhouette.PolyVertexInfo<T> _CalculateAngularSilhouette_b__6(ArraySegment<DwdVector2Floating> pointWithNeighbors)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(pointWithNeighbors));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AngularSilhouette.__c__DisplayClass0_1<T>.NativeMethodInfoPtr__CalculateAngularSilhouette_b__6_Internal_PolyVertexInfo_1_T_ArraySegment_1_DwdVector2Floating_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new AngularSilhouette.PolyVertexInfo<T>(intPtr);
				}
			}

			// Token: 0x06001DF7 RID: 7671 RVA: 0x0000E671 File Offset: 0x0000C871
			public __c__DisplayClass0_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000703 RID: 1795
			// (get) Token: 0x06001DF8 RID: 7672 RVA: 0x0008BEE4 File Offset: 0x0008A0E4
			// (set) Token: 0x06001DF9 RID: 7673 RVA: 0x0008BF0C File Offset: 0x0008A10C
			public unsafe T owner
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AngularSilhouette.__c__DisplayClass0_1<T>.NativeFieldInfoPtr_owner);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AngularSilhouette.__c__DisplayClass0_1<T>.NativeFieldInfoPtr_owner);
					Type typeFromHandle = typeof(T);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x17000704 RID: 1796
			// (get) Token: 0x06001DFA RID: 7674 RVA: 0x0008BFB4 File Offset: 0x0008A1B4
			// (set) Token: 0x06001DFB RID: 7675 RVA: 0x0000E67A File Offset: 0x0000C87A
			public unsafe AngularSilhouette.__c__DisplayClass0_0<T> field_Public___c__DisplayClass0_0_1_T_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AngularSilhouette.__c__DisplayClass0_1<T>.NativeFieldInfoPtr_field_Public___c__DisplayClass0_0_1_T_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AngularSilhouette.__c__DisplayClass0_0<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AngularSilhouette.__c__DisplayClass0_1<T>.NativeFieldInfoPtr_field_Public___c__DisplayClass0_0_1_T_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040012FA RID: 4858
			private static readonly IntPtr NativeFieldInfoPtr_owner;

			// Token: 0x040012FB RID: 4859
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass0_0_1_T_0;

			// Token: 0x040012FC RID: 4860
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040012FD RID: 4861
			private static readonly IntPtr NativeMethodInfoPtr__CalculateAngularSilhouette_b__6_Internal_PolyVertexInfo_1_T_ArraySegment_1_DwdVector2Floating_0;
		}

		// Token: 0x020002C4 RID: 708
		[ObfuscatedName("Canis.mathLib.AngularSilhouette+<>c__DisplayClass0_2`1")]
		public sealed class __c__DisplayClass0_2<T> : Object where T : class
		{
			// Token: 0x06001DFC RID: 7676 RVA: 0x0008BFE4 File Offset: 0x0008A1E4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass0_2()
			{
				Il2CppClassPointerStore<AngularSilhouette.__c__DisplayClass0_2<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AngularSilhouette>.NativeClassPtr, "<>c__DisplayClass0_2`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AngularSilhouette.__c__DisplayClass0_2<T>>.NativeClassPtr);
				AngularSilhouette.__c__DisplayClass0_2<T>.NativeFieldInfoPtr_owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AngularSilhouette.__c__DisplayClass0_2<T>>.NativeClassPtr, "owner");
				AngularSilhouette.__c__DisplayClass0_2<T>.NativeFieldInfoPtr_edges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AngularSilhouette.__c__DisplayClass0_2<T>>.NativeClassPtr, "edges");
				AngularSilhouette.__c__DisplayClass0_2<T>.NativeFieldInfoPtr_field_Public___c__DisplayClass0_0_1_T_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AngularSilhouette.__c__DisplayClass0_2<T>>.NativeClassPtr, "CS$<>8__locals2");
				AngularSilhouette.__c__DisplayClass0_2<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AngularSilhouette.__c__DisplayClass0_2<T>>.NativeClassPtr, 100664529);
				AngularSilhouette.__c__DisplayClass0_2<T>.NativeMethodInfoPtr__CalculateAngularSilhouette_b__7_Internal_Boolean_KeyValuePair_2_T_Il2CppStructArray_1_Segment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AngularSilhouette.__c__DisplayClass0_2<T>>.NativeClassPtr, 100664530);
				AngularSilhouette.__c__DisplayClass0_2<T>.NativeMethodInfoPtr__CalculateAngularSilhouette_b__8_Internal_IEnumerable_1_PolyVertexInfo_1_T_KeyValuePair_2_T_Il2CppStructArray_1_Segment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AngularSilhouette.__c__DisplayClass0_2<T>>.NativeClassPtr, 100664531);
			}

			// Token: 0x06001DFD RID: 7677 RVA: 0x0008C0C4 File Offset: 0x0008A2C4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass0_2()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AngularSilhouette.__c__DisplayClass0_2<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AngularSilhouette.__c__DisplayClass0_2<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001DFE RID: 7678 RVA: 0x0008C100 File Offset: 0x0008A300
			[CallerCount(0)]
			public unsafe bool _CalculateAngularSilhouette_b__7(KeyValuePair<T, Il2CppStructArray<Segment>> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AngularSilhouette.__c__DisplayClass0_2<T>.NativeMethodInfoPtr__CalculateAngularSilhouette_b__7_Internal_Boolean_KeyValuePair_2_T_Il2CppStructArray_1_Segment_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001DFF RID: 7679 RVA: 0x0008C154 File Offset: 0x0008A354
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 555723, XrefRangeEnd = 555733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<AngularSilhouette.PolyVertexInfo<T>> _CalculateAngularSilhouette_b__8(KeyValuePair<T, Il2CppStructArray<Segment>> otherOwnerEdges)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(otherOwnerEdges));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AngularSilhouette.__c__DisplayClass0_2<T>.NativeMethodInfoPtr__CalculateAngularSilhouette_b__8_Internal_IEnumerable_1_PolyVertexInfo_1_T_KeyValuePair_2_T_Il2CppStructArray_1_Segment_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<AngularSilhouette.PolyVertexInfo<T>>>(intPtr3) : null;
				}
			}

			// Token: 0x06001E00 RID: 7680 RVA: 0x0000E699 File Offset: 0x0000C899
			public __c__DisplayClass0_2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000705 RID: 1797
			// (get) Token: 0x06001E01 RID: 7681 RVA: 0x0008C1AC File Offset: 0x0008A3AC
			// (set) Token: 0x06001E02 RID: 7682 RVA: 0x0008C1D4 File Offset: 0x0008A3D4
			public unsafe T owner
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AngularSilhouette.__c__DisplayClass0_2<T>.NativeFieldInfoPtr_owner);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AngularSilhouette.__c__DisplayClass0_2<T>.NativeFieldInfoPtr_owner);
					Type typeFromHandle = typeof(T);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x17000706 RID: 1798
			// (get) Token: 0x06001E03 RID: 7683 RVA: 0x0008C27C File Offset: 0x0008A47C
			// (set) Token: 0x06001E04 RID: 7684 RVA: 0x0000E6A2 File Offset: 0x0000C8A2
			public unsafe Il2CppStructArray<Segment> edges
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AngularSilhouette.__c__DisplayClass0_2<T>.NativeFieldInfoPtr_edges);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Segment>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AngularSilhouette.__c__DisplayClass0_2<T>.NativeFieldInfoPtr_edges), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000707 RID: 1799
			// (get) Token: 0x06001E05 RID: 7685 RVA: 0x0008C2AC File Offset: 0x0008A4AC
			// (set) Token: 0x06001E06 RID: 7686 RVA: 0x0000E6C1 File Offset: 0x0000C8C1
			public unsafe AngularSilhouette.__c__DisplayClass0_0<T> field_Public___c__DisplayClass0_0_1_T_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AngularSilhouette.__c__DisplayClass0_2<T>.NativeFieldInfoPtr_field_Public___c__DisplayClass0_0_1_T_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AngularSilhouette.__c__DisplayClass0_0<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AngularSilhouette.__c__DisplayClass0_2<T>.NativeFieldInfoPtr_field_Public___c__DisplayClass0_0_1_T_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040012FE RID: 4862
			private static readonly IntPtr NativeFieldInfoPtr_owner;

			// Token: 0x040012FF RID: 4863
			private static readonly IntPtr NativeFieldInfoPtr_edges;

			// Token: 0x04001300 RID: 4864
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass0_0_1_T_0;

			// Token: 0x04001301 RID: 4865
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001302 RID: 4866
			private static readonly IntPtr NativeMethodInfoPtr__CalculateAngularSilhouette_b__7_Internal_Boolean_KeyValuePair_2_T_Il2CppStructArray_1_Segment_0;

			// Token: 0x04001303 RID: 4867
			private static readonly IntPtr NativeMethodInfoPtr__CalculateAngularSilhouette_b__8_Internal_IEnumerable_1_PolyVertexInfo_1_T_KeyValuePair_2_T_Il2CppStructArray_1_Segment_0;
		}

		// Token: 0x020002C5 RID: 709
		[ObfuscatedName("Canis.mathLib.AngularSilhouette+<>c__DisplayClass0_3`1")]
		public sealed class __c__DisplayClass0_3<T> : Object where T : class
		{
			// Token: 0x06001E07 RID: 7687 RVA: 0x0008C2DC File Offset: 0x0008A4DC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass0_3()
			{
				Il2CppClassPointerStore<AngularSilhouette.__c__DisplayClass0_3<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AngularSilhouette>.NativeClassPtr, "<>c__DisplayClass0_3`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AngularSilhouette.__c__DisplayClass0_3<T>>.NativeClassPtr);
				AngularSilhouette.__c__DisplayClass0_3<T>.NativeFieldInfoPtr_otherOwnerEdges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AngularSilhouette.__c__DisplayClass0_3<T>>.NativeClassPtr, "otherOwnerEdges");
				AngularSilhouette.__c__DisplayClass0_3<T>.NativeFieldInfoPtr_field_Public___c__DisplayClass0_2_1_T_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AngularSilhouette.__c__DisplayClass0_3<T>>.NativeClassPtr, "CS$<>8__locals3");
				AngularSilhouette.__c__DisplayClass0_3<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AngularSilhouette.__c__DisplayClass0_3<T>>.NativeClassPtr, 100664532);
				AngularSilhouette.__c__DisplayClass0_3<T>.NativeMethodInfoPtr__CalculateAngularSilhouette_b__9_Internal_IEnumerable_1_PolyVertexInfo_1_T_Segment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AngularSilhouette.__c__DisplayClass0_3<T>>.NativeClassPtr, 100664533);
			}

			// Token: 0x06001E08 RID: 7688 RVA: 0x0008C394 File Offset: 0x0008A594
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass0_3()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AngularSilhouette.__c__DisplayClass0_3<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AngularSilhouette.__c__DisplayClass0_3<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E09 RID: 7689 RVA: 0x0008C3D0 File Offset: 0x0008A5D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 555733, XrefRangeEnd = 555769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<AngularSilhouette.PolyVertexInfo<T>> _CalculateAngularSilhouette_b__9(Segment otherEdge)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref otherEdge;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AngularSilhouette.__c__DisplayClass0_3<T>.NativeMethodInfoPtr__CalculateAngularSilhouette_b__9_Internal_IEnumerable_1_PolyVertexInfo_1_T_Segment_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<AngularSilhouette.PolyVertexInfo<T>>>(intPtr3) : null;
				}
			}

			// Token: 0x06001E0A RID: 7690 RVA: 0x0000E6E0 File Offset: 0x0000C8E0
			public __c__DisplayClass0_3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000708 RID: 1800
			// (get) Token: 0x06001E0B RID: 7691 RVA: 0x0008C41C File Offset: 0x0008A61C
			// (set) Token: 0x06001E0C RID: 7692 RVA: 0x0000E6E9 File Offset: 0x0000C8E9
			public KeyValuePair<T, Il2CppStructArray<Segment>> otherOwnerEdges
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AngularSilhouette.__c__DisplayClass0_3<T>.NativeFieldInfoPtr_otherOwnerEdges);
					return new KeyValuePair<T, Il2CppStructArray<Segment>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KeyValuePair<T, Il2CppStructArray<Segment>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AngularSilhouette.__c__DisplayClass0_3<T>.NativeFieldInfoPtr_otherOwnerEdges), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<KeyValuePair<T, Il2CppStructArray<Segment>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000709 RID: 1801
			// (get) Token: 0x06001E0D RID: 7693 RVA: 0x0008C44C File Offset: 0x0008A64C
			// (set) Token: 0x06001E0E RID: 7694 RVA: 0x0000E717 File Offset: 0x0000C917
			public unsafe AngularSilhouette.__c__DisplayClass0_2<T> field_Public___c__DisplayClass0_2_1_T_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AngularSilhouette.__c__DisplayClass0_3<T>.NativeFieldInfoPtr_field_Public___c__DisplayClass0_2_1_T_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AngularSilhouette.__c__DisplayClass0_2<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AngularSilhouette.__c__DisplayClass0_3<T>.NativeFieldInfoPtr_field_Public___c__DisplayClass0_2_1_T_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001304 RID: 4868
			private static readonly IntPtr NativeFieldInfoPtr_otherOwnerEdges;

			// Token: 0x04001305 RID: 4869
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass0_2_1_T_0;

			// Token: 0x04001306 RID: 4870
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001307 RID: 4871
			private static readonly IntPtr NativeMethodInfoPtr__CalculateAngularSilhouette_b__9_Internal_IEnumerable_1_PolyVertexInfo_1_T_Segment_0;
		}

		// Token: 0x020002C6 RID: 710
		[ObfuscatedName("Canis.mathLib.AngularSilhouette+<>c__DisplayClass0_4`1")]
		public sealed class __c__DisplayClass0_4<T> : Object where T : class
		{
			// Token: 0x06001E0F RID: 7695 RVA: 0x0008C47C File Offset: 0x0008A67C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass0_4()
			{
				Il2CppClassPointerStore<AngularSilhouette.__c__DisplayClass0_4<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AngularSilhouette>.NativeClassPtr, "<>c__DisplayClass0_4`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AngularSilhouette.__c__DisplayClass0_4<T>>.NativeClassPtr);
				AngularSilhouette.__c__DisplayClass0_4<T>.NativeFieldInfoPtr_otherEdge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AngularSilhouette.__c__DisplayClass0_4<T>>.NativeClassPtr, "otherEdge");
				AngularSilhouette.__c__DisplayClass0_4<T>.NativeFieldInfoPtr_field_Public___c__DisplayClass0_3_1_T_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AngularSilhouette.__c__DisplayClass0_4<T>>.NativeClassPtr, "CS$<>8__locals4");
				AngularSilhouette.__c__DisplayClass0_4<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AngularSilhouette.__c__DisplayClass0_4<T>>.NativeClassPtr, 100664534);
				AngularSilhouette.__c__DisplayClass0_4<T>.NativeMethodInfoPtr__CalculateAngularSilhouette_b__10_Internal_PolyVertexInfo_1_T_ValueTuple_2_DwdVector2Floating_Segment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AngularSilhouette.__c__DisplayClass0_4<T>>.NativeClassPtr, 100664535);
			}

			// Token: 0x06001E10 RID: 7696 RVA: 0x0008C534 File Offset: 0x0008A734
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass0_4()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AngularSilhouette.__c__DisplayClass0_4<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AngularSilhouette.__c__DisplayClass0_4<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E11 RID: 7697 RVA: 0x0008C570 File Offset: 0x0008A770
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 555769, XrefRangeEnd = 555779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AngularSilhouette.PolyVertexInfo<T> _CalculateAngularSilhouette_b__10(ValueTuple<DwdVector2Floating, Segment> pt)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(pt));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AngularSilhouette.__c__DisplayClass0_4<T>.NativeMethodInfoPtr__CalculateAngularSilhouette_b__10_Internal_PolyVertexInfo_1_T_ValueTuple_2_DwdVector2Floating_Segment_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new AngularSilhouette.PolyVertexInfo<T>(intPtr);
				}
			}

			// Token: 0x06001E12 RID: 7698 RVA: 0x0000E736 File Offset: 0x0000C936
			public __c__DisplayClass0_4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700070A RID: 1802
			// (get) Token: 0x06001E13 RID: 7699 RVA: 0x0008C5C0 File Offset: 0x0008A7C0
			// (set) Token: 0x06001E14 RID: 7700 RVA: 0x0000E73F File Offset: 0x0000C93F
			public unsafe Segment otherEdge
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AngularSilhouette.__c__DisplayClass0_4<T>.NativeFieldInfoPtr_otherEdge);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AngularSilhouette.__c__DisplayClass0_4<T>.NativeFieldInfoPtr_otherEdge)) = value;
				}
			}

			// Token: 0x1700070B RID: 1803
			// (get) Token: 0x06001E15 RID: 7701 RVA: 0x0008C5E8 File Offset: 0x0008A7E8
			// (set) Token: 0x06001E16 RID: 7702 RVA: 0x0000E75A File Offset: 0x0000C95A
			public unsafe AngularSilhouette.__c__DisplayClass0_3<T> field_Public___c__DisplayClass0_3_1_T_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AngularSilhouette.__c__DisplayClass0_4<T>.NativeFieldInfoPtr_field_Public___c__DisplayClass0_3_1_T_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AngularSilhouette.__c__DisplayClass0_3<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AngularSilhouette.__c__DisplayClass0_4<T>.NativeFieldInfoPtr_field_Public___c__DisplayClass0_3_1_T_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001308 RID: 4872
			private static readonly IntPtr NativeFieldInfoPtr_otherEdge;

			// Token: 0x04001309 RID: 4873
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass0_3_1_T_0;

			// Token: 0x0400130A RID: 4874
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400130B RID: 4875
			private static readonly IntPtr NativeMethodInfoPtr__CalculateAngularSilhouette_b__10_Internal_PolyVertexInfo_1_T_ValueTuple_2_DwdVector2Floating_Segment_0;
		}

		// Token: 0x020002C7 RID: 711
		[ObfuscatedName("Canis.mathLib.AngularSilhouette+<>c__DisplayClass0_5`1")]
		public sealed class __c__DisplayClass0_5<T> : Object where T : class
		{
			// Token: 0x06001E17 RID: 7703 RVA: 0x0008C618 File Offset: 0x0008A818
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass0_5()
			{
				Il2CppClassPointerStore<AngularSilhouette.__c__DisplayClass0_5<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AngularSilhouette>.NativeClassPtr, "<>c__DisplayClass0_5`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AngularSilhouette.__c__DisplayClass0_5<T>>.NativeClassPtr);
				AngularSilhouette.__c__DisplayClass0_5<T>.NativeFieldInfoPtr_relatedEdge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AngularSilhouette.__c__DisplayClass0_5<T>>.NativeClassPtr, "relatedEdge");
				AngularSilhouette.__c__DisplayClass0_5<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AngularSilhouette.__c__DisplayClass0_5<T>>.NativeClassPtr, 100664536);
				AngularSilhouette.__c__DisplayClass0_5<T>.NativeMethodInfoPtr__CalculateAngularSilhouette_b__11_Internal_Boolean_ValueTuple_2_Segment_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AngularSilhouette.__c__DisplayClass0_5<T>>.NativeClassPtr, 100664537);
			}

			// Token: 0x06001E18 RID: 7704 RVA: 0x0008C6BC File Offset: 0x0008A8BC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass0_5()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AngularSilhouette.__c__DisplayClass0_5<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AngularSilhouette.__c__DisplayClass0_5<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E19 RID: 7705 RVA: 0x0008C6F8 File Offset: 0x0008A8F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 555779, XrefRangeEnd = 555780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CalculateAngularSilhouette_b__11(ValueTuple<Segment, T> tup)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tup));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AngularSilhouette.__c__DisplayClass0_5<T>.NativeMethodInfoPtr__CalculateAngularSilhouette_b__11_Internal_Boolean_ValueTuple_2_Segment_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001E1A RID: 7706 RVA: 0x0000E779 File Offset: 0x0000C979
			public __c__DisplayClass0_5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700070C RID: 1804
			// (get) Token: 0x06001E1B RID: 7707 RVA: 0x0008C74C File Offset: 0x0008A94C
			// (set) Token: 0x06001E1C RID: 7708 RVA: 0x0000E782 File Offset: 0x0000C982
			public unsafe Segment relatedEdge
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AngularSilhouette.__c__DisplayClass0_5<T>.NativeFieldInfoPtr_relatedEdge);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AngularSilhouette.__c__DisplayClass0_5<T>.NativeFieldInfoPtr_relatedEdge)) = value;
				}
			}

			// Token: 0x0400130C RID: 4876
			private static readonly IntPtr NativeFieldInfoPtr_relatedEdge;

			// Token: 0x0400130D RID: 4877
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400130E RID: 4878
			private static readonly IntPtr NativeMethodInfoPtr__CalculateAngularSilhouette_b__11_Internal_Boolean_ValueTuple_2_Segment_T_0;
		}

		// Token: 0x020002C8 RID: 712
		[ObfuscatedName("Canis.mathLib.AngularSilhouette+<>c__DisplayClass0_6`1")]
		public sealed class __c__DisplayClass0_6<T> : ValueType where T : class
		{
			// Token: 0x06001E1D RID: 7709 RVA: 0x0008C774 File Offset: 0x0008A974
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass0_6()
			{
				Il2CppClassPointerStore<AngularSilhouette.__c__DisplayClass0_6<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AngularSilhouette>.NativeClassPtr, "<>c__DisplayClass0_6`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AngularSilhouette.__c__DisplayClass0_6<T>>.NativeClassPtr);
				AngularSilhouette.__c__DisplayClass0_6<T>.NativeFieldInfoPtr_testRay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AngularSilhouette.__c__DisplayClass0_6<T>>.NativeClassPtr, "testRay");
				AngularSilhouette.__c__DisplayClass0_6<T>.NativeFieldInfoPtr_closestDist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AngularSilhouette.__c__DisplayClass0_6<T>>.NativeClassPtr, "closestDist");
				AngularSilhouette.__c__DisplayClass0_6<T>.NativeFieldInfoPtr_testArc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AngularSilhouette.__c__DisplayClass0_6<T>>.NativeClassPtr, "testArc");
				AngularSilhouette.__c__DisplayClass0_6<T>.NativeFieldInfoPtr_closestIntersectionPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AngularSilhouette.__c__DisplayClass0_6<T>>.NativeClassPtr, "closestIntersectionPoint");
				AngularSilhouette.__c__DisplayClass0_6<T>.NativeFieldInfoPtr_closestGeometry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AngularSilhouette.__c__DisplayClass0_6<T>>.NativeClassPtr, "closestGeometry");
				AngularSilhouette.__c__DisplayClass0_6<T>.NativeFieldInfoPtr_closestOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AngularSilhouette.__c__DisplayClass0_6<T>>.NativeClassPtr, "closestOwner");
			}

			// Token: 0x06001E1E RID: 7710 RVA: 0x0000E79D File Offset: 0x0000C99D
			public __c__DisplayClass0_6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001E1F RID: 7711 RVA: 0x0000E7A6 File Offset: 0x0000C9A6
			public __c__DisplayClass0_6()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AngularSilhouette.__c__DisplayClass0_6<T>>.NativeClassPtr))
			{
			}

			// Token: 0x1700070D RID: 1805
			// (get) Token: 0x06001E20 RID: 7712 RVA: 0x0008C854 File Offset: 0x0008AA54
			// (set) Token: 0x06001E21 RID: 7713 RVA: 0x0000E7B8 File Offset: 0x0000C9B8
			public unsafe Ray testRay
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AngularSilhouette.__c__DisplayClass0_6<T>.NativeFieldInfoPtr_testRay);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AngularSilhouette.__c__DisplayClass0_6<T>.NativeFieldInfoPtr_testRay)) = value;
				}
			}

			// Token: 0x1700070E RID: 1806
			// (get) Token: 0x06001E22 RID: 7714 RVA: 0x0008C87C File Offset: 0x0008AA7C
			// (set) Token: 0x06001E23 RID: 7715 RVA: 0x0000E7D3 File Offset: 0x0000C9D3
			public Nullable<double> closestDist
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AngularSilhouette.__c__DisplayClass0_6<T>.NativeFieldInfoPtr_closestDist);
					return new Nullable<double>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<double>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AngularSilhouette.__c__DisplayClass0_6<T>.NativeFieldInfoPtr_closestDist), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<double>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700070F RID: 1807
			// (get) Token: 0x06001E24 RID: 7716 RVA: 0x0008C8AC File Offset: 0x0008AAAC
			// (set) Token: 0x06001E25 RID: 7717 RVA: 0x0000E801 File Offset: 0x0000CA01
			public unsafe Arc testArc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AngularSilhouette.__c__DisplayClass0_6<T>.NativeFieldInfoPtr_testArc);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AngularSilhouette.__c__DisplayClass0_6<T>.NativeFieldInfoPtr_testArc)) = value;
				}
			}

			// Token: 0x17000710 RID: 1808
			// (get) Token: 0x06001E26 RID: 7718 RVA: 0x0008C8D4 File Offset: 0x0008AAD4
			// (set) Token: 0x06001E27 RID: 7719 RVA: 0x0000E81C File Offset: 0x0000CA1C
			public Nullable<DwdVector2Floating> closestIntersectionPoint
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AngularSilhouette.__c__DisplayClass0_6<T>.NativeFieldInfoPtr_closestIntersectionPoint);
					return new Nullable<DwdVector2Floating>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<DwdVector2Floating>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AngularSilhouette.__c__DisplayClass0_6<T>.NativeFieldInfoPtr_closestIntersectionPoint), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<DwdVector2Floating>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000711 RID: 1809
			// (get) Token: 0x06001E28 RID: 7720 RVA: 0x0008C904 File Offset: 0x0008AB04
			// (set) Token: 0x06001E29 RID: 7721 RVA: 0x0000E84A File Offset: 0x0000CA4A
			public Nullable<Segment> closestGeometry
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AngularSilhouette.__c__DisplayClass0_6<T>.NativeFieldInfoPtr_closestGeometry);
					return new Nullable<Segment>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<Segment>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AngularSilhouette.__c__DisplayClass0_6<T>.NativeFieldInfoPtr_closestGeometry), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<Segment>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000712 RID: 1810
			// (get) Token: 0x06001E2A RID: 7722 RVA: 0x0008C934 File Offset: 0x0008AB34
			// (set) Token: 0x06001E2B RID: 7723 RVA: 0x0008C95C File Offset: 0x0008AB5C
			public unsafe T closestOwner
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AngularSilhouette.__c__DisplayClass0_6<T>.NativeFieldInfoPtr_closestOwner);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AngularSilhouette.__c__DisplayClass0_6<T>.NativeFieldInfoPtr_closestOwner);
					Type typeFromHandle = typeof(T);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x0400130F RID: 4879
			private static readonly IntPtr NativeFieldInfoPtr_testRay;

			// Token: 0x04001310 RID: 4880
			private static readonly IntPtr NativeFieldInfoPtr_closestDist;

			// Token: 0x04001311 RID: 4881
			private static readonly IntPtr NativeFieldInfoPtr_testArc;

			// Token: 0x04001312 RID: 4882
			private static readonly IntPtr NativeFieldInfoPtr_closestIntersectionPoint;

			// Token: 0x04001313 RID: 4883
			private static readonly IntPtr NativeFieldInfoPtr_closestGeometry;

			// Token: 0x04001314 RID: 4884
			private static readonly IntPtr NativeFieldInfoPtr_closestOwner;
		}

		// Token: 0x020002C9 RID: 713
		[ObfuscatedName("Canis.mathLib.AngularSilhouette+<>c__DisplayClass0_7`1")]
		public sealed class __c__DisplayClass0_7<T> : Object where T : class
		{
			// Token: 0x06001E2C RID: 7724 RVA: 0x0008CA04 File Offset: 0x0008AC04
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass0_7()
			{
				Il2CppClassPointerStore<AngularSilhouette.__c__DisplayClass0_7<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AngularSilhouette>.NativeClassPtr, "<>c__DisplayClass0_7`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AngularSilhouette.__c__DisplayClass0_7<T>>.NativeClassPtr);
				AngularSilhouette.__c__DisplayClass0_7<T>.NativeFieldInfoPtr_segment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AngularSilhouette.__c__DisplayClass0_7<T>>.NativeClassPtr, "segment");
				AngularSilhouette.__c__DisplayClass0_7<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AngularSilhouette.__c__DisplayClass0_7<T>>.NativeClassPtr, 100664538);
				AngularSilhouette.__c__DisplayClass0_7<T>.NativeMethodInfoPtr__CalculateAngularSilhouette_b__14_Internal_Boolean_PolyVertexInfo_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AngularSilhouette.__c__DisplayClass0_7<T>>.NativeClassPtr, 100664539);
				AngularSilhouette.__c__DisplayClass0_7<T>.NativeMethodInfoPtr__CalculateAngularSilhouette_b__15_Internal_Boolean_PolyVertexInfo_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AngularSilhouette.__c__DisplayClass0_7<T>>.NativeClassPtr, 100664540);
			}

			// Token: 0x06001E2D RID: 7725 RVA: 0x0008CABC File Offset: 0x0008ACBC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass0_7()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AngularSilhouette.__c__DisplayClass0_7<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AngularSilhouette.__c__DisplayClass0_7<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E2E RID: 7726 RVA: 0x0008CAF8 File Offset: 0x0008ACF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 555780, XrefRangeEnd = 555781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CalculateAngularSilhouette_b__14(AngularSilhouette.PolyVertexInfo<T> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AngularSilhouette.__c__DisplayClass0_7<T>.NativeMethodInfoPtr__CalculateAngularSilhouette_b__14_Internal_Boolean_PolyVertexInfo_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001E2F RID: 7727 RVA: 0x0008CB4C File Offset: 0x0008AD4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 555781, XrefRangeEnd = 555782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CalculateAngularSilhouette_b__15(AngularSilhouette.PolyVertexInfo<T> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AngularSilhouette.__c__DisplayClass0_7<T>.NativeMethodInfoPtr__CalculateAngularSilhouette_b__15_Internal_Boolean_PolyVertexInfo_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001E30 RID: 7728 RVA: 0x0000E878 File Offset: 0x0000CA78
			public __c__DisplayClass0_7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000713 RID: 1811
			// (get) Token: 0x06001E31 RID: 7729 RVA: 0x0008CBA0 File Offset: 0x0008ADA0
			// (set) Token: 0x06001E32 RID: 7730 RVA: 0x0000E881 File Offset: 0x0000CA81
			public unsafe Segment segment
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AngularSilhouette.__c__DisplayClass0_7<T>.NativeFieldInfoPtr_segment);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AngularSilhouette.__c__DisplayClass0_7<T>.NativeFieldInfoPtr_segment)) = value;
				}
			}

			// Token: 0x04001315 RID: 4885
			private static readonly IntPtr NativeFieldInfoPtr_segment;

			// Token: 0x04001316 RID: 4886
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001317 RID: 4887
			private static readonly IntPtr NativeMethodInfoPtr__CalculateAngularSilhouette_b__14_Internal_Boolean_PolyVertexInfo_1_T_0;

			// Token: 0x04001318 RID: 4888
			private static readonly IntPtr NativeMethodInfoPtr__CalculateAngularSilhouette_b__15_Internal_Boolean_PolyVertexInfo_1_T_0;
		}

		// Token: 0x020002CA RID: 714
		private sealed class MethodInfoStoreGeneric_CalculateAngularSilhouette_Public_Static_List_1_ValueTuple_2_Segment_T_Arc_List_1_ValueTuple_2_Polygon_T_0<T>
		{
			// Token: 0x04001319 RID: 4889
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AngularSilhouette.NativeMethodInfoPtr_CalculateAngularSilhouette_Public_Static_List_1_ValueTuple_2_Segment_T_Arc_List_1_ValueTuple_2_Polygon_T_0, Il2CppClassPointerStore<AngularSilhouette>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020002CB RID: 715
		private sealed class MethodInfoStoreGeneric_Method_Internal_Static_Void_DwdVector2Floating_Segment_T_byref___c__DisplayClass0_6_1_T_PDM_0<T>
		{
			// Token: 0x0400131A RID: 4890
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AngularSilhouette.NativeMethodInfoPtr_Method_Internal_Static_Void_DwdVector2Floating_Segment_T_byref___c__DisplayClass0_6_1_T_PDM_0, Il2CppClassPointerStore<AngularSilhouette>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
