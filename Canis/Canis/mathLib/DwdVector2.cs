using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Canis.mathLib
{
	// Token: 0x02000074 RID: 116
	[Serializable]
	[StructLayout(2)]
	public struct DwdVector2
	{
		// Token: 0x0600063B RID: 1595 RVA: 0x0003204C File Offset: 0x0003024C
		// Note: this type is marked as 'beforefieldinit'.
		static DwdVector2()
		{
			Il2CppClassPointerStore<DwdVector2>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.mathLib", "DwdVector2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DwdVector2>.NativeClassPtr);
			DwdVector2.NativeFieldInfoPtr_X = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DwdVector2>.NativeClassPtr, "X");
			DwdVector2.NativeFieldInfoPtr_Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DwdVector2>.NativeClassPtr, "Y");
			DwdVector2.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdVector2>.NativeClassPtr, 100664578);
			DwdVector2.NativeMethodInfoPtr_op_Addition_Public_Static_DwdVector2_byref_DwdVector2_byref_DwdVector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdVector2>.NativeClassPtr, 100664579);
			DwdVector2.NativeMethodInfoPtr_op_Addition_Public_Static_DwdVector2Floating_byref_DwdVector2_byref_DwdVector2Floating_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdVector2>.NativeClassPtr, 100664580);
			DwdVector2.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_DwdVector2_byref_DwdVector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdVector2>.NativeClassPtr, 100664581);
			DwdVector2.NativeMethodInfoPtr_op_Subtraction_Public_Static_DwdVector2_byref_DwdVector2_byref_DwdVector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdVector2>.NativeClassPtr, 100664582);
			DwdVector2.NativeMethodInfoPtr_op_Subtraction_Public_Static_DwdVector2Floating_byref_DwdVector2_byref_DwdVector2Floating_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdVector2>.NativeClassPtr, 100664583);
			DwdVector2.NativeMethodInfoPtr_op_Multiply_Public_Static_DwdVector2_byref_DwdVector2_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdVector2>.NativeClassPtr, 100664584);
			DwdVector2.NativeMethodInfoPtr_op_Multiply_Public_Static_DwdVector2Floating_byref_DwdVector2_byref_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdVector2>.NativeClassPtr, 100664585);
			DwdVector2.NativeMethodInfoPtr_DotProduct_Public_Int32_byref_DwdVector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdVector2>.NativeClassPtr, 100664586);
			DwdVector2.NativeMethodInfoPtr_DotProduct_Public_Double_byref_DwdVector2Floating_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdVector2>.NativeClassPtr, 100664587);
			DwdVector2.NativeMethodInfoPtr_CrossProduct_Public_Int32_byref_DwdVector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdVector2>.NativeClassPtr, 100664588);
			DwdVector2.NativeMethodInfoPtr_CrossProduct_Public_Double_byref_DwdVector2Floating_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdVector2>.NativeClassPtr, 100664589);
			DwdVector2.NativeMethodInfoPtr_MagnitudeSquared_Public_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdVector2>.NativeClassPtr, 100664590);
			DwdVector2.NativeMethodInfoPtr_Magnitude_Public_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdVector2>.NativeClassPtr, 100664591);
			DwdVector2.NativeMethodInfoPtr_DistanceTo_Public_Double_byref_DwdVector2Floating_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdVector2>.NativeClassPtr, 100664592);
			DwdVector2.NativeMethodInfoPtr_Angle_Public_AngleRadians_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdVector2>.NativeClassPtr, 100664593);
			DwdVector2.NativeMethodInfoPtr_Rotate_Public_DwdVector2Floating_byref_AngleRadians_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdVector2>.NativeClassPtr, 100664594);
			DwdVector2.NativeMethodInfoPtr_CounterClockwisePerpendicular_Public_DwdVector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdVector2>.NativeClassPtr, 100664595);
			DwdVector2.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdVector2>.NativeClassPtr, 100664596);
			DwdVector2.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_DwdVector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdVector2>.NativeClassPtr, 100664597);
			DwdVector2.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdVector2>.NativeClassPtr, 100664598);
			DwdVector2.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdVector2>.NativeClassPtr, 100664599);
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x0003225C File Offset: 0x0003045C
		[CallerCount(39)]
		[CachedScanResults(RefRangeStart = 283577, RefRangeEnd = 283616, XrefRangeStart = 283577, XrefRangeEnd = 283616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DwdVector2(int x, int y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdVector2.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x0003229C File Offset: 0x0003049C
		[CallerCount(0)]
		public unsafe static DwdVector2 operator +([In] ref DwdVector2 vector1, [In] ref DwdVector2 vector2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &vector1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &vector2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdVector2.NativeMethodInfoPtr_op_Addition_Public_Static_DwdVector2_byref_DwdVector2_byref_DwdVector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x000322E8 File Offset: 0x000304E8
		[CallerCount(0)]
		public unsafe static DwdVector2Floating operator +([In] ref DwdVector2 vector1, [In] ref DwdVector2Floating vector2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &vector1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &vector2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdVector2.NativeMethodInfoPtr_op_Addition_Public_Static_DwdVector2Floating_byref_DwdVector2_byref_DwdVector2Floating_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x00032334 File Offset: 0x00030534
		[CallerCount(0)]
		public unsafe static DwdVector2 operator -([In] ref DwdVector2 vector)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &vector;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdVector2.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_DwdVector2_byref_DwdVector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x00032374 File Offset: 0x00030574
		[CallerCount(0)]
		public unsafe static DwdVector2 operator -([In] ref DwdVector2 vector1, [In] ref DwdVector2 vector2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &vector1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &vector2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdVector2.NativeMethodInfoPtr_op_Subtraction_Public_Static_DwdVector2_byref_DwdVector2_byref_DwdVector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x000323C0 File Offset: 0x000305C0
		[CallerCount(0)]
		public unsafe static DwdVector2Floating operator -([In] ref DwdVector2 vector1, [In] ref DwdVector2Floating vector2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &vector1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &vector2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdVector2.NativeMethodInfoPtr_op_Subtraction_Public_Static_DwdVector2Floating_byref_DwdVector2_byref_DwdVector2Floating_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x0003240C File Offset: 0x0003060C
		[CallerCount(0)]
		public unsafe static DwdVector2 operator *([In] ref DwdVector2 vector1, [In] ref int scalar)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &vector1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &scalar;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdVector2.NativeMethodInfoPtr_op_Multiply_Public_Static_DwdVector2_byref_DwdVector2_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x00032458 File Offset: 0x00030658
		[CallerCount(0)]
		public unsafe static DwdVector2Floating operator *([In] ref DwdVector2 vector1, [In] ref double scalar)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &vector1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &scalar;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdVector2.NativeMethodInfoPtr_op_Multiply_Public_Static_DwdVector2Floating_byref_DwdVector2_byref_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x000324A4 File Offset: 0x000306A4
		[CallerCount(0)]
		public unsafe int DotProduct([In] ref DwdVector2 vector)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &vector;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdVector2.NativeMethodInfoPtr_DotProduct_Public_Int32_byref_DwdVector2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x000324E4 File Offset: 0x000306E4
		[CallerCount(0)]
		public unsafe double DotProduct([In] ref DwdVector2Floating vector)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &vector;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdVector2.NativeMethodInfoPtr_DotProduct_Public_Double_byref_DwdVector2Floating_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x00032524 File Offset: 0x00030724
		[CallerCount(0)]
		public unsafe int CrossProduct([In] ref DwdVector2 vector)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &vector;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdVector2.NativeMethodInfoPtr_CrossProduct_Public_Int32_byref_DwdVector2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x00032564 File Offset: 0x00030764
		[CallerCount(0)]
		public unsafe double CrossProduct([In] ref DwdVector2Floating vector)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &vector;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdVector2.NativeMethodInfoPtr_CrossProduct_Public_Double_byref_DwdVector2Floating_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x000325A4 File Offset: 0x000307A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 556141, RefRangeEnd = 556142, XrefRangeStart = 556136, XrefRangeEnd = 556141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double MagnitudeSquared()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdVector2.NativeMethodInfoPtr_MagnitudeSquared_Public_Double_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x000325D4 File Offset: 0x000307D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 556142, XrefRangeEnd = 556146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double Magnitude()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdVector2.NativeMethodInfoPtr_Magnitude_Public_Double_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x00032604 File Offset: 0x00030804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 556146, XrefRangeEnd = 556149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double DistanceTo([In] ref DwdVector2Floating point)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &point;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdVector2.NativeMethodInfoPtr_DistanceTo_Public_Double_byref_DwdVector2Floating_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x00032644 File Offset: 0x00030844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 556149, XrefRangeEnd = 556153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AngleRadians Angle()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdVector2.NativeMethodInfoPtr_Angle_Public_AngleRadians_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x00032674 File Offset: 0x00030874
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 556153, XrefRangeEnd = 556158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DwdVector2Floating Rotate([In] ref AngleRadians rotationInRadians)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &rotationInRadians;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdVector2.NativeMethodInfoPtr_Rotate_Public_DwdVector2Floating_byref_AngleRadians_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x000326B4 File Offset: 0x000308B4
		[CallerCount(0)]
		public unsafe DwdVector2 CounterClockwisePerpendicular()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdVector2.NativeMethodInfoPtr_CounterClockwisePerpendicular_Public_DwdVector2_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x000326E4 File Offset: 0x000308E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 556158, XrefRangeEnd = 556166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdVector2.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600064F RID: 1615 RVA: 0x00032710 File Offset: 0x00030910
		[CallerCount(0)]
		public unsafe bool Equals(DwdVector2 other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdVector2.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_DwdVector2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x00032750 File Offset: 0x00030950
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 556166, XrefRangeEnd = 556169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdVector2.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x00032794 File Offset: 0x00030994
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdVector2.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x00004962 File Offset: 0x00002B62
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DwdVector2>.NativeClassPtr, ref this));
		}

		// Token: 0x04000412 RID: 1042
		private static readonly IntPtr NativeFieldInfoPtr_X;

		// Token: 0x04000413 RID: 1043
		private static readonly IntPtr NativeFieldInfoPtr_Y;

		// Token: 0x04000414 RID: 1044
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

		// Token: 0x04000415 RID: 1045
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_DwdVector2_byref_DwdVector2_byref_DwdVector2_0;

		// Token: 0x04000416 RID: 1046
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_DwdVector2Floating_byref_DwdVector2_byref_DwdVector2Floating_0;

		// Token: 0x04000417 RID: 1047
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryNegation_Public_Static_DwdVector2_byref_DwdVector2_0;

		// Token: 0x04000418 RID: 1048
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_DwdVector2_byref_DwdVector2_byref_DwdVector2_0;

		// Token: 0x04000419 RID: 1049
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_DwdVector2Floating_byref_DwdVector2_byref_DwdVector2Floating_0;

		// Token: 0x0400041A RID: 1050
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_DwdVector2_byref_DwdVector2_byref_Int32_0;

		// Token: 0x0400041B RID: 1051
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_DwdVector2Floating_byref_DwdVector2_byref_Double_0;

		// Token: 0x0400041C RID: 1052
		private static readonly IntPtr NativeMethodInfoPtr_DotProduct_Public_Int32_byref_DwdVector2_0;

		// Token: 0x0400041D RID: 1053
		private static readonly IntPtr NativeMethodInfoPtr_DotProduct_Public_Double_byref_DwdVector2Floating_0;

		// Token: 0x0400041E RID: 1054
		private static readonly IntPtr NativeMethodInfoPtr_CrossProduct_Public_Int32_byref_DwdVector2_0;

		// Token: 0x0400041F RID: 1055
		private static readonly IntPtr NativeMethodInfoPtr_CrossProduct_Public_Double_byref_DwdVector2Floating_0;

		// Token: 0x04000420 RID: 1056
		private static readonly IntPtr NativeMethodInfoPtr_MagnitudeSquared_Public_Double_0;

		// Token: 0x04000421 RID: 1057
		private static readonly IntPtr NativeMethodInfoPtr_Magnitude_Public_Double_0;

		// Token: 0x04000422 RID: 1058
		private static readonly IntPtr NativeMethodInfoPtr_DistanceTo_Public_Double_byref_DwdVector2Floating_0;

		// Token: 0x04000423 RID: 1059
		private static readonly IntPtr NativeMethodInfoPtr_Angle_Public_AngleRadians_0;

		// Token: 0x04000424 RID: 1060
		private static readonly IntPtr NativeMethodInfoPtr_Rotate_Public_DwdVector2Floating_byref_AngleRadians_0;

		// Token: 0x04000425 RID: 1061
		private static readonly IntPtr NativeMethodInfoPtr_CounterClockwisePerpendicular_Public_DwdVector2_0;

		// Token: 0x04000426 RID: 1062
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000427 RID: 1063
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_DwdVector2_0;

		// Token: 0x04000428 RID: 1064
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000429 RID: 1065
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400042A RID: 1066
		[FieldOffset(0)]
		public readonly int X;

		// Token: 0x0400042B RID: 1067
		[FieldOffset(4)]
		public readonly int Y;
	}
}
