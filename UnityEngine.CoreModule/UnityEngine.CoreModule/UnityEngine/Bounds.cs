using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000080 RID: 128
	[StructLayout(2)]
	public struct Bounds
	{
		// Token: 0x0600067A RID: 1658 RVA: 0x0002B278 File Offset: 0x00029478
		// Note: this type is marked as 'beforefieldinit'.
		static Bounds()
		{
			Il2CppClassPointerStore<Bounds>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Bounds");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Bounds>.NativeClassPtr);
			Bounds.NativeFieldInfoPtr_m_Center = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bounds>.NativeClassPtr, "m_Center");
			Bounds.NativeFieldInfoPtr_m_Extents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bounds>.NativeClassPtr, "m_Extents");
			Bounds.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100664096);
			Bounds.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100664097);
			Bounds.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100664098);
			Bounds.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100664099);
			Bounds.NativeMethodInfoPtr_get_center_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100664100);
			Bounds.NativeMethodInfoPtr_set_center_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100664101);
			Bounds.NativeMethodInfoPtr_get_size_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100664102);
			Bounds.NativeMethodInfoPtr_set_size_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100664103);
			Bounds.NativeMethodInfoPtr_get_extents_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100664104);
			Bounds.NativeMethodInfoPtr_set_extents_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100664105);
			Bounds.NativeMethodInfoPtr_get_min_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100664106);
			Bounds.NativeMethodInfoPtr_set_min_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100664107);
			Bounds.NativeMethodInfoPtr_get_max_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100664108);
			Bounds.NativeMethodInfoPtr_set_max_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100664109);
			Bounds.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Bounds_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100664110);
			Bounds.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Bounds_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100664111);
			Bounds.NativeMethodInfoPtr_SetMinMax_Public_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100664112);
			Bounds.NativeMethodInfoPtr_Encapsulate_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100664113);
			Bounds.NativeMethodInfoPtr_Encapsulate_Public_Void_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100664114);
			Bounds.NativeMethodInfoPtr_IntersectRay_Public_Boolean_Ray_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100664115);
			Bounds.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100664116);
			Bounds.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100664117);
			Bounds.NativeMethodInfoPtr_IntersectRayAABB_Private_Static_Boolean_Ray_Bounds_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100664118);
			Bounds.NativeMethodInfoPtr_IntersectRayAABB_Injected_Private_Static_Boolean_byref_Ray_byref_Bounds_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100664119);
			Bounds.Contains_InjectedDelegateField = IL2CPP.ResolveICall<Bounds.Contains_InjectedDelegate>("UnityEngine.Bounds::Contains_Injected");
			Bounds.SqrDistance_InjectedDelegateField = IL2CPP.ResolveICall<Bounds.SqrDistance_InjectedDelegate>("UnityEngine.Bounds::SqrDistance_Injected");
			Bounds.ClosestPoint_InjectedDelegateField = IL2CPP.ResolveICall<Bounds.ClosestPoint_InjectedDelegate>("UnityEngine.Bounds::ClosestPoint_Injected");
		}

		// Token: 0x0600067B RID: 1659 RVA: 0x0002B4E0 File Offset: 0x000296E0
		[CallerCount(0)]
		public unsafe Bounds(Vector3 center, Vector3 size)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref center;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x0002B520 File Offset: 0x00029720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 648512, XrefRangeEnd = 648518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x0002B550 File Offset: 0x00029750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 648518, XrefRangeEnd = 648521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x0002B594 File Offset: 0x00029794
		[CallerCount(0)]
		public unsafe bool Equals(Bounds other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Bounds_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x0600067F RID: 1663 RVA: 0x0002B5D4 File Offset: 0x000297D4
		// (set) Token: 0x06000680 RID: 1664 RVA: 0x0002B604 File Offset: 0x00029804
		public unsafe Vector3 center
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 648521, RefRangeEnd = 648525, XrefRangeStart = 648521, XrefRangeEnd = 648521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_get_center_Public_get_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_set_center_Public_set_Void_Vector3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x06000681 RID: 1665 RVA: 0x0002B638 File Offset: 0x00029838
		// (set) Token: 0x06000682 RID: 1666 RVA: 0x0002B668 File Offset: 0x00029868
		public unsafe Vector3 size
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_get_size_Public_get_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_set_size_Public_set_Void_Vector3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x06000683 RID: 1667 RVA: 0x0002B69C File Offset: 0x0002989C
		// (set) Token: 0x06000684 RID: 1668 RVA: 0x0002B6CC File Offset: 0x000298CC
		public unsafe Vector3 extents
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 648525, RefRangeEnd = 648526, XrefRangeStart = 648525, XrefRangeEnd = 648525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_get_extents_Public_get_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_set_extents_Public_set_Void_Vector3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x06000685 RID: 1669 RVA: 0x0002B700 File Offset: 0x00029900
		// (set) Token: 0x06000686 RID: 1670 RVA: 0x0002B730 File Offset: 0x00029930
		public unsafe Vector3 min
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_get_min_Public_get_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_set_min_Public_set_Void_Vector3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x06000687 RID: 1671 RVA: 0x0002B764 File Offset: 0x00029964
		// (set) Token: 0x06000688 RID: 1672 RVA: 0x0002B794 File Offset: 0x00029994
		public unsafe Vector3 max
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_get_max_Public_get_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_set_max_Public_set_Void_Vector3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x0002B7C8 File Offset: 0x000299C8
		[CallerCount(0)]
		public unsafe static bool operator ==(Bounds lhs, Bounds rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Bounds_Bounds_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x0002B814 File Offset: 0x00029A14
		[CallerCount(0)]
		public unsafe static bool operator !=(Bounds lhs, Bounds rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Bounds_Bounds_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x0002B860 File Offset: 0x00029A60
		[CallerCount(0)]
		public unsafe void SetMinMax(Vector3 min, Vector3 max)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref min;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_SetMinMax_Public_Void_Vector3_Vector3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x0002B8A0 File Offset: 0x00029AA0
		[CallerCount(0)]
		public unsafe void Encapsulate(Vector3 point)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref point;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_Encapsulate_Public_Void_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x0002B8D4 File Offset: 0x00029AD4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 648526, RefRangeEnd = 648528, XrefRangeStart = 648526, XrefRangeEnd = 648526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Encapsulate(Bounds bounds)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bounds;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_Encapsulate_Public_Void_Bounds_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x0002B908 File Offset: 0x00029B08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 648528, XrefRangeEnd = 648530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IntersectRay(Ray ray, out float distance)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ray;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &distance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_IntersectRay_Public_Boolean_Ray_byref_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x0002B954 File Offset: 0x00029B54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 648530, XrefRangeEnd = 648531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x0002B980 File Offset: 0x00029B80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 648531, XrefRangeEnd = 648556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(string format, IFormatProvider formatProvider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatProvider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x0002B9D0 File Offset: 0x00029BD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 648558, RefRangeEnd = 648559, XrefRangeStart = 648556, XrefRangeEnd = 648558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IntersectRayAABB(Ray ray, Bounds bounds, out float dist)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ray;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bounds;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &dist;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_IntersectRayAABB_Private_Static_Boolean_Ray_Bounds_byref_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x0002BA2C File Offset: 0x00029C2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 648559, XrefRangeEnd = 648561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IntersectRayAABB_Injected(ref Ray ray, ref Bounds bounds, out float dist)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ray;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &bounds;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &dist;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_IntersectRayAABB_Injected_Private_Static_Boolean_byref_Ray_byref_Bounds_byref_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x000048FB File Offset: 0x00002AFB
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Bounds>.NativeClassPtr, ref this));
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x0000490D File Offset: 0x00002B0D
		public void Expand(float amount)
		{
			amount *= 0.5f;
			this.extents += new Vector3(amount, amount, amount);
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x00004933 File Offset: 0x00002B33
		public void Expand(Vector3 amount)
		{
			this.extents += amount * 0.5f;
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x0002BA88 File Offset: 0x00029C88
		public bool Intersects(Bounds bounds)
		{
			return this.min.x <= bounds.max.x && this.max.x >= bounds.min.x && this.min.y <= bounds.max.y && this.max.y >= bounds.min.y && this.min.z <= bounds.max.z && this.max.z >= bounds.min.z;
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x0002BB3C File Offset: 0x00029D3C
		public bool IntersectRay(Ray ray)
		{
			float num;
			return Bounds.IntersectRayAABB(ray, this, out num);
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x0002BB5C File Offset: 0x00029D5C
		public string ToString(string format)
		{
			return this.ToString(format, null);
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x00004953 File Offset: 0x00002B53
		public bool Contains(Vector3 point)
		{
			return Bounds.Contains_Injected(ref this, ref point);
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x0000495D File Offset: 0x00002B5D
		public float SqrDistance(Vector3 point)
		{
			return Bounds.SqrDistance_Injected(ref this, ref point);
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x0002BB78 File Offset: 0x00029D78
		public Vector3 ClosestPoint(Vector3 point)
		{
			Vector3 vector;
			Bounds.ClosestPoint_Injected(ref this, ref point, out vector);
			return vector;
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x00004967 File Offset: 0x00002B67
		public static bool Contains_Injected(ref Bounds _unity_self, ref Vector3 point)
		{
			return Bounds.Contains_InjectedDelegateField(ref _unity_self, ref point);
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x00004975 File Offset: 0x00002B75
		public static float SqrDistance_Injected(ref Bounds _unity_self, ref Vector3 point)
		{
			return Bounds.SqrDistance_InjectedDelegateField(ref _unity_self, ref point);
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x00004983 File Offset: 0x00002B83
		public static void ClosestPoint_Injected(ref Bounds _unity_self, ref Vector3 point, out Vector3 ret)
		{
			Bounds.ClosestPoint_InjectedDelegateField(ref _unity_self, ref point, out ret);
		}

		// Token: 0x04000588 RID: 1416
		private static readonly IntPtr NativeFieldInfoPtr_m_Center;

		// Token: 0x04000589 RID: 1417
		private static readonly IntPtr NativeFieldInfoPtr_m_Extents;

		// Token: 0x0400058A RID: 1418
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_0;

		// Token: 0x0400058B RID: 1419
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400058C RID: 1420
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400058D RID: 1421
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Bounds_0;

		// Token: 0x0400058E RID: 1422
		private static readonly IntPtr NativeMethodInfoPtr_get_center_Public_get_Vector3_0;

		// Token: 0x0400058F RID: 1423
		private static readonly IntPtr NativeMethodInfoPtr_set_center_Public_set_Void_Vector3_0;

		// Token: 0x04000590 RID: 1424
		private static readonly IntPtr NativeMethodInfoPtr_get_size_Public_get_Vector3_0;

		// Token: 0x04000591 RID: 1425
		private static readonly IntPtr NativeMethodInfoPtr_set_size_Public_set_Void_Vector3_0;

		// Token: 0x04000592 RID: 1426
		private static readonly IntPtr NativeMethodInfoPtr_get_extents_Public_get_Vector3_0;

		// Token: 0x04000593 RID: 1427
		private static readonly IntPtr NativeMethodInfoPtr_set_extents_Public_set_Void_Vector3_0;

		// Token: 0x04000594 RID: 1428
		private static readonly IntPtr NativeMethodInfoPtr_get_min_Public_get_Vector3_0;

		// Token: 0x04000595 RID: 1429
		private static readonly IntPtr NativeMethodInfoPtr_set_min_Public_set_Void_Vector3_0;

		// Token: 0x04000596 RID: 1430
		private static readonly IntPtr NativeMethodInfoPtr_get_max_Public_get_Vector3_0;

		// Token: 0x04000597 RID: 1431
		private static readonly IntPtr NativeMethodInfoPtr_set_max_Public_set_Void_Vector3_0;

		// Token: 0x04000598 RID: 1432
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Bounds_Bounds_0;

		// Token: 0x04000599 RID: 1433
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Bounds_Bounds_0;

		// Token: 0x0400059A RID: 1434
		private static readonly IntPtr NativeMethodInfoPtr_SetMinMax_Public_Void_Vector3_Vector3_0;

		// Token: 0x0400059B RID: 1435
		private static readonly IntPtr NativeMethodInfoPtr_Encapsulate_Public_Void_Vector3_0;

		// Token: 0x0400059C RID: 1436
		private static readonly IntPtr NativeMethodInfoPtr_Encapsulate_Public_Void_Bounds_0;

		// Token: 0x0400059D RID: 1437
		private static readonly IntPtr NativeMethodInfoPtr_IntersectRay_Public_Boolean_Ray_byref_Single_0;

		// Token: 0x0400059E RID: 1438
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400059F RID: 1439
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x040005A0 RID: 1440
		private static readonly IntPtr NativeMethodInfoPtr_IntersectRayAABB_Private_Static_Boolean_Ray_Bounds_byref_Single_0;

		// Token: 0x040005A1 RID: 1441
		private static readonly IntPtr NativeMethodInfoPtr_IntersectRayAABB_Injected_Private_Static_Boolean_byref_Ray_byref_Bounds_byref_Single_0;

		// Token: 0x040005A2 RID: 1442
		[FieldOffset(0)]
		public Vector3 m_Center;

		// Token: 0x040005A3 RID: 1443
		[FieldOffset(12)]
		public Vector3 m_Extents;

		// Token: 0x040005A4 RID: 1444
		private static readonly Bounds.Contains_InjectedDelegate Contains_InjectedDelegateField;

		// Token: 0x040005A5 RID: 1445
		private static readonly Bounds.SqrDistance_InjectedDelegate SqrDistance_InjectedDelegateField;

		// Token: 0x040005A6 RID: 1446
		private static readonly Bounds.ClosestPoint_InjectedDelegate ClosestPoint_InjectedDelegateField;

		// Token: 0x020004A6 RID: 1190
		// (Invoke) Token: 0x06003257 RID: 12887
		private delegate bool Contains_InjectedDelegate(IntPtr _unity_self, IntPtr point);

		// Token: 0x020004A7 RID: 1191
		// (Invoke) Token: 0x06003259 RID: 12889
		private delegate float SqrDistance_InjectedDelegate(IntPtr _unity_self, IntPtr point);

		// Token: 0x020004A8 RID: 1192
		// (Invoke) Token: 0x0600325B RID: 12891
		private delegate void ClosestPoint_InjectedDelegate(IntPtr _unity_self, IntPtr point, [Out] IntPtr ret);
	}
}
