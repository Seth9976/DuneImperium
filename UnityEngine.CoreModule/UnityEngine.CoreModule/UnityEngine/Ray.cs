using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000084 RID: 132
	[StructLayout(2)]
	public struct Ray
	{
		// Token: 0x060006EE RID: 1774 RVA: 0x0002CD78 File Offset: 0x0002AF78
		// Note: this type is marked as 'beforefieldinit'.
		static Ray()
		{
			Il2CppClassPointerStore<Ray>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Ray");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Ray>.NativeClassPtr);
			Ray.NativeFieldInfoPtr_m_Origin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ray>.NativeClassPtr, "m_Origin");
			Ray.NativeFieldInfoPtr_m_Direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ray>.NativeClassPtr, "m_Direction");
			Ray.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ray>.NativeClassPtr, 100664144);
			Ray.NativeMethodInfoPtr_get_origin_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ray>.NativeClassPtr, 100664145);
			Ray.NativeMethodInfoPtr_get_direction_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ray>.NativeClassPtr, 100664146);
			Ray.NativeMethodInfoPtr_GetPoint_Public_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ray>.NativeClassPtr, 100664147);
			Ray.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ray>.NativeClassPtr, 100664148);
			Ray.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ray>.NativeClassPtr, 100664149);
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x0002CE48 File Offset: 0x0002B048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 648668, XrefRangeEnd = 648669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Ray(Vector3 origin, Vector3 direction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ray.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x060006F0 RID: 1776 RVA: 0x0002CE88 File Offset: 0x0002B088
		// (set) Token: 0x060006F6 RID: 1782 RVA: 0x00004B76 File Offset: 0x00002D76
		public unsafe Vector3 origin
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 648521, RefRangeEnd = 648525, XrefRangeStart = 648521, XrefRangeEnd = 648525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ray.NativeMethodInfoPtr_get_origin_Public_get_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Origin = value;
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x060006F1 RID: 1777 RVA: 0x0002CEB8 File Offset: 0x0002B0B8
		// (set) Token: 0x060006F7 RID: 1783 RVA: 0x00004B80 File Offset: 0x00002D80
		public unsafe Vector3 direction
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 648525, RefRangeEnd = 648526, XrefRangeStart = 648525, XrefRangeEnd = 648526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ray.NativeMethodInfoPtr_get_direction_Public_get_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Direction = value.normalized;
			}
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x0002CEE8 File Offset: 0x0002B0E8
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 648669, RefRangeEnd = 648685, XrefRangeStart = 648669, XrefRangeEnd = 648669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetPoint(float distance)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref distance;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ray.NativeMethodInfoPtr_GetPoint_Public_Vector3_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x0002CF28 File Offset: 0x0002B128
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 648685, XrefRangeEnd = 648686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ray.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x0002CF54 File Offset: 0x0002B154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 648686, XrefRangeEnd = 648711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ray.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x00004B64 File Offset: 0x00002D64
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Ray>.NativeClassPtr, ref this));
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x0002CFA4 File Offset: 0x0002B1A4
		public string ToString(string format)
		{
			return this.ToString(format, null);
		}

		// Token: 0x040005C9 RID: 1481
		private static readonly IntPtr NativeFieldInfoPtr_m_Origin;

		// Token: 0x040005CA RID: 1482
		private static readonly IntPtr NativeFieldInfoPtr_m_Direction;

		// Token: 0x040005CB RID: 1483
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_0;

		// Token: 0x040005CC RID: 1484
		private static readonly IntPtr NativeMethodInfoPtr_get_origin_Public_get_Vector3_0;

		// Token: 0x040005CD RID: 1485
		private static readonly IntPtr NativeMethodInfoPtr_get_direction_Public_get_Vector3_0;

		// Token: 0x040005CE RID: 1486
		private static readonly IntPtr NativeMethodInfoPtr_GetPoint_Public_Vector3_Single_0;

		// Token: 0x040005CF RID: 1487
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040005D0 RID: 1488
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x040005D1 RID: 1489
		[FieldOffset(0)]
		public Vector3 m_Origin;

		// Token: 0x040005D2 RID: 1490
		[FieldOffset(12)]
		public Vector3 m_Direction;
	}
}
