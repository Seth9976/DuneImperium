using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis.mathLib.intersections
{
	// Token: 0x02000084 RID: 132
	public sealed class MultiIntersection : ValueType
	{
		// Token: 0x06000712 RID: 1810 RVA: 0x00036538 File Offset: 0x00034738
		// Note: this type is marked as 'beforefieldinit'.
		static MultiIntersection()
		{
			Il2CppClassPointerStore<MultiIntersection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.mathLib.intersections", "MultiIntersection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultiIntersection>.NativeClassPtr);
			MultiIntersection.NativeFieldInfoPtr_Intersections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiIntersection>.NativeClassPtr, "Intersections");
			MultiIntersection.NativeMethodInfoPtr__ctor_Private_Void_Il2CppReferenceArray_1_IIntersection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiIntersection>.NativeClassPtr, 100664762);
			MultiIntersection.NativeMethodInfoPtr_FromIntersections_Public_Static_IIntersection_IEnumerable_1_IIntersection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiIntersection>.NativeClassPtr, 100664763);
			MultiIntersection.NativeMethodInfoPtr_FlattenIntersections_Private_Static_IEnumerable_1_IIntersection_IEnumerable_1_IIntersection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiIntersection>.NativeClassPtr, 100664764);
			MultiIntersection.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiIntersection>.NativeClassPtr, 100664765);
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x000365CC File Offset: 0x000347CC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 307804, RefRangeEnd = 307807, XrefRangeStart = 307804, XrefRangeEnd = 307807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MultiIntersection(Il2CppReferenceArray<IIntersection> flattenedIntersections)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultiIntersection>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(flattenedIntersections);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiIntersection.NativeMethodInfoPtr__ctor_Private_Void_Il2CppReferenceArray_1_IIntersection_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x0003661C File Offset: 0x0003481C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 557128, RefRangeEnd = 557132, XrefRangeStart = 557118, XrefRangeEnd = 557128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IIntersection FromIntersections(IEnumerable<IIntersection> subIntersections)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(subIntersections);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiIntersection.NativeMethodInfoPtr_FromIntersections_Public_Static_IIntersection_IEnumerable_1_IIntersection_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IIntersection>(intPtr3) : null;
			}
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x00036660 File Offset: 0x00034860
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 557150, RefRangeEnd = 557152, XrefRangeStart = 557132, XrefRangeEnd = 557150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<IIntersection> FlattenIntersections(IEnumerable<IIntersection> subIntersections)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(subIntersections);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiIntersection.NativeMethodInfoPtr_FlattenIntersections_Private_Static_IEnumerable_1_IIntersection_IEnumerable_1_IIntersection_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IIntersection>>(intPtr3) : null;
			}
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x000366A4 File Offset: 0x000348A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 557152, XrefRangeEnd = 557163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiIntersection.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x00004B0A File Offset: 0x00002D0A
		public MultiIntersection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x00004B13 File Offset: 0x00002D13
		public MultiIntersection()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultiIntersection>.NativeClassPtr))
		{
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x06000719 RID: 1817 RVA: 0x000366E0 File Offset: 0x000348E0
		// (set) Token: 0x0600071A RID: 1818 RVA: 0x00004B25 File Offset: 0x00002D25
		public unsafe Il2CppReferenceArray<IIntersection> Intersections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiIntersection.NativeFieldInfoPtr_Intersections);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IIntersection>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiIntersection.NativeFieldInfoPtr_Intersections), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040004EA RID: 1258
		private static readonly IntPtr NativeFieldInfoPtr_Intersections;

		// Token: 0x040004EB RID: 1259
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Il2CppReferenceArray_1_IIntersection_0;

		// Token: 0x040004EC RID: 1260
		private static readonly IntPtr NativeMethodInfoPtr_FromIntersections_Public_Static_IIntersection_IEnumerable_1_IIntersection_0;

		// Token: 0x040004ED RID: 1261
		private static readonly IntPtr NativeMethodInfoPtr_FlattenIntersections_Private_Static_IEnumerable_1_IIntersection_IEnumerable_1_IIntersection_0;

		// Token: 0x040004EE RID: 1262
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x020002D4 RID: 724
		[ObfuscatedName("Canis.mathLib.intersections.MultiIntersection+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001E59 RID: 7769 RVA: 0x0008D3A8 File Offset: 0x0008B5A8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<MultiIntersection.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MultiIntersection>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultiIntersection.__c>.NativeClassPtr);
				MultiIntersection.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiIntersection.__c>.NativeClassPtr, "<>9");
				MultiIntersection.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiIntersection.__c>.NativeClassPtr, "<>9__3_0");
				MultiIntersection.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiIntersection.__c>.NativeClassPtr, 100664767);
				MultiIntersection.__c.NativeMethodInfoPtr__FlattenIntersections_b__3_0_Internal_IEnumerable_1_IIntersection_IIntersection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiIntersection.__c>.NativeClassPtr, 100664768);
			}

			// Token: 0x06001E5A RID: 7770 RVA: 0x0008D424 File Offset: 0x0008B624
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultiIntersection.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiIntersection.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E5B RID: 7771 RVA: 0x0008D460 File Offset: 0x0008B660
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 557102, XrefRangeEnd = 557118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<IIntersection> _FlattenIntersections_b__3_0(IIntersection ii)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ii);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiIntersection.__c.NativeMethodInfoPtr__FlattenIntersections_b__3_0_Internal_IEnumerable_1_IIntersection_IIntersection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IIntersection>>(intPtr3) : null;
				}
			}

			// Token: 0x06001E5C RID: 7772 RVA: 0x0000E997 File Offset: 0x0000CB97
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000719 RID: 1817
			// (get) Token: 0x06001E5D RID: 7773 RVA: 0x0008D4B0 File Offset: 0x0008B6B0
			// (set) Token: 0x06001E5E RID: 7774 RVA: 0x0000E9A0 File Offset: 0x0000CBA0
			public unsafe static MultiIntersection.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MultiIntersection.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultiIntersection.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MultiIntersection.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700071A RID: 1818
			// (get) Token: 0x06001E5F RID: 7775 RVA: 0x0008D4D8 File Offset: 0x0008B6D8
			// (set) Token: 0x06001E60 RID: 7776 RVA: 0x0000E9B2 File Offset: 0x0000CBB2
			public unsafe static Func<IIntersection, IEnumerable<IIntersection>> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MultiIntersection.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IIntersection, IEnumerable<IIntersection>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MultiIntersection.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001334 RID: 4916
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001335 RID: 4917
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x04001336 RID: 4918
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001337 RID: 4919
			private static readonly IntPtr NativeMethodInfoPtr__FlattenIntersections_b__3_0_Internal_IEnumerable_1_IIntersection_IIntersection_0;
		}
	}
}
