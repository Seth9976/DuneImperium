using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Canis.mathLib
{
	// Token: 0x02000075 RID: 117
	[Serializable]
	[StructLayout(2)]
	public struct DwdVector2Floating
	{
		// Token: 0x06000653 RID: 1619 RVA: 0x000327C4 File Offset: 0x000309C4
		// Note: this type is marked as 'beforefieldinit'.
		static DwdVector2Floating()
		{
			Il2CppClassPointerStore<DwdVector2Floating>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.mathLib", "DwdVector2Floating");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DwdVector2Floating>.NativeClassPtr);
			DwdVector2Floating.NativeFieldInfoPtr_X = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DwdVector2Floating>.NativeClassPtr, "X");
			DwdVector2Floating.NativeFieldInfoPtr_Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DwdVector2Floating>.NativeClassPtr, "Y");
			DwdVector2Floating.NativeMethodInfoPtr__ctor_Public_Void_byref_Double_byref_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdVector2Floating>.NativeClassPtr, 100664600);
			DwdVector2Floating.NativeMethodInfoPtr_op_Addition_Public_Static_DwdVector2Floating_byref_DwdVector2Floating_byref_DwdVector2Floating_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdVector2Floating>.NativeClassPtr, 100664601);
			DwdVector2Floating.NativeMethodInfoPtr_op_Addition_Public_Static_DwdVector2Floating_byref_DwdVector2Floating_byref_DwdVector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdVector2Floating>.NativeClassPtr, 100664602);
			DwdVector2Floating.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_DwdVector2Floating_byref_DwdVector2Floating_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdVector2Floating>.NativeClassPtr, 100664603);
			DwdVector2Floating.NativeMethodInfoPtr_op_Subtraction_Public_Static_DwdVector2Floating_byref_DwdVector2Floating_byref_DwdVector2Floating_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdVector2Floating>.NativeClassPtr, 100664604);
			DwdVector2Floating.NativeMethodInfoPtr_op_Subtraction_Public_Static_DwdVector2Floating_byref_DwdVector2Floating_byref_DwdVector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdVector2Floating>.NativeClassPtr, 100664605);
			DwdVector2Floating.NativeMethodInfoPtr_op_Multiply_Public_Static_DwdVector2Floating_byref_DwdVector2Floating_byref_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdVector2Floating>.NativeClassPtr, 100664606);
			DwdVector2Floating.NativeMethodInfoPtr_op_Division_Public_Static_DwdVector2Floating_byref_DwdVector2Floating_byref_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdVector2Floating>.NativeClassPtr, 100664607);
			DwdVector2Floating.NativeMethodInfoPtr_DotProduct_Public_Double_byref_DwdVector2Floating_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdVector2Floating>.NativeClassPtr, 100664608);
			DwdVector2Floating.NativeMethodInfoPtr_CrossProduct_Public_Double_byref_DwdVector2Floating_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdVector2Floating>.NativeClassPtr, 100664609);
			DwdVector2Floating.NativeMethodInfoPtr_MagnitudeSquared_Public_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdVector2Floating>.NativeClassPtr, 100664610);
			DwdVector2Floating.NativeMethodInfoPtr_Magnitude_Public_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdVector2Floating>.NativeClassPtr, 100664611);
			DwdVector2Floating.NativeMethodInfoPtr_Angle_Public_AngleRadians_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdVector2Floating>.NativeClassPtr, 100664612);
			DwdVector2Floating.NativeMethodInfoPtr_DistanceTo_Public_Double_byref_DwdVector2Floating_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdVector2Floating>.NativeClassPtr, 100664613);
			DwdVector2Floating.NativeMethodInfoPtr_MinimumAngleTo_Public_AngleRadians_byref_DwdVector2Floating_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdVector2Floating>.NativeClassPtr, 100664614);
			DwdVector2Floating.NativeMethodInfoPtr_ProjectOnto_Public_DwdVector2Floating_byref_DwdVector2Floating_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdVector2Floating>.NativeClassPtr, 100664615);
			DwdVector2Floating.NativeMethodInfoPtr_Rotate_Public_DwdVector2Floating_byref_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdVector2Floating>.NativeClassPtr, 100664616);
			DwdVector2Floating.NativeMethodInfoPtr_CounterClockwisePerpendicular_Public_DwdVector2Floating_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdVector2Floating>.NativeClassPtr, 100664617);
			DwdVector2Floating.NativeMethodInfoPtr_op_Implicit_Public_Static_DwdVector2Floating_byref_DwdVector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdVector2Floating>.NativeClassPtr, 100664618);
			DwdVector2Floating.NativeMethodInfoPtr_op_Implicit_Public_Static_DwdVector2_byref_DwdVector2Floating_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdVector2Floating>.NativeClassPtr, 100664619);
			DwdVector2Floating.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdVector2Floating>.NativeClassPtr, 100664620);
			DwdVector2Floating.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_DwdVector2Floating_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdVector2Floating>.NativeClassPtr, 100664621);
			DwdVector2Floating.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdVector2Floating>.NativeClassPtr, 100664622);
			DwdVector2Floating.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdVector2Floating>.NativeClassPtr, 100664623);
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x000329FC File Offset: 0x00030BFC
		[CallerCount(0)]
		public unsafe DwdVector2Floating([In] ref double x, [In] ref double y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdVector2Floating.NativeMethodInfoPtr__ctor_Public_Void_byref_Double_byref_Double_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x00032A3C File Offset: 0x00030C3C
		[CallerCount(0)]
		public unsafe static DwdVector2Floating operator +([In] ref DwdVector2Floating vector1, [In] ref DwdVector2Floating vector2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &vector1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &vector2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdVector2Floating.NativeMethodInfoPtr_op_Addition_Public_Static_DwdVector2Floating_byref_DwdVector2Floating_byref_DwdVector2Floating_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x00032A88 File Offset: 0x00030C88
		[CallerCount(0)]
		public unsafe static DwdVector2Floating operator +([In] ref DwdVector2Floating vector1, [In] ref DwdVector2 vector2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &vector1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &vector2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdVector2Floating.NativeMethodInfoPtr_op_Addition_Public_Static_DwdVector2Floating_byref_DwdVector2Floating_byref_DwdVector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x00032AD4 File Offset: 0x00030CD4
		[CallerCount(0)]
		public unsafe static DwdVector2Floating operator -([In] ref DwdVector2Floating vector)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &vector;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdVector2Floating.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_DwdVector2Floating_byref_DwdVector2Floating_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x00032B14 File Offset: 0x00030D14
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 556169, RefRangeEnd = 556173, XrefRangeStart = 556169, XrefRangeEnd = 556169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DwdVector2Floating operator -([In] ref DwdVector2Floating vector1, [In] ref DwdVector2Floating vector2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &vector1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &vector2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdVector2Floating.NativeMethodInfoPtr_op_Subtraction_Public_Static_DwdVector2Floating_byref_DwdVector2Floating_byref_DwdVector2Floating_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x00032B60 File Offset: 0x00030D60
		[CallerCount(0)]
		public unsafe static DwdVector2Floating operator -([In] ref DwdVector2Floating vector1, [In] ref DwdVector2 vector2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &vector1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &vector2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdVector2Floating.NativeMethodInfoPtr_op_Subtraction_Public_Static_DwdVector2Floating_byref_DwdVector2Floating_byref_DwdVector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x00032BAC File Offset: 0x00030DAC
		[CallerCount(0)]
		public unsafe static DwdVector2Floating operator *([In] ref DwdVector2Floating vector1, [In] ref double scalar)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &vector1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &scalar;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdVector2Floating.NativeMethodInfoPtr_op_Multiply_Public_Static_DwdVector2Floating_byref_DwdVector2Floating_byref_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x00032BF8 File Offset: 0x00030DF8
		[CallerCount(0)]
		public unsafe static DwdVector2Floating operator /([In] ref DwdVector2Floating vector1, [In] ref double scalar)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &vector1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &scalar;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdVector2Floating.NativeMethodInfoPtr_op_Division_Public_Static_DwdVector2Floating_byref_DwdVector2Floating_byref_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x00032C44 File Offset: 0x00030E44
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 556173, RefRangeEnd = 556175, XrefRangeStart = 556173, XrefRangeEnd = 556173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double DotProduct([In] ref DwdVector2Floating vector)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &vector;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdVector2Floating.NativeMethodInfoPtr_DotProduct_Public_Double_byref_DwdVector2Floating_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x00032C84 File Offset: 0x00030E84
		[CallerCount(0)]
		public unsafe double CrossProduct([In] ref DwdVector2Floating vector)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &vector;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdVector2Floating.NativeMethodInfoPtr_CrossProduct_Public_Double_byref_DwdVector2Floating_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x00032CC4 File Offset: 0x00030EC4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 556175, RefRangeEnd = 556177, XrefRangeStart = 556175, XrefRangeEnd = 556175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double MagnitudeSquared()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdVector2Floating.NativeMethodInfoPtr_MagnitudeSquared_Public_Double_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x00032CF4 File Offset: 0x00030EF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 556180, RefRangeEnd = 556181, XrefRangeStart = 556177, XrefRangeEnd = 556180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double Magnitude()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdVector2Floating.NativeMethodInfoPtr_Magnitude_Public_Double_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x00032D24 File Offset: 0x00030F24
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 556187, RefRangeEnd = 556189, XrefRangeStart = 556181, XrefRangeEnd = 556187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AngleRadians Angle()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdVector2Floating.NativeMethodInfoPtr_Angle_Public_AngleRadians_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x00032D54 File Offset: 0x00030F54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 556189, XrefRangeEnd = 556192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double DistanceTo([In] ref DwdVector2Floating point)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &point;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdVector2Floating.NativeMethodInfoPtr_DistanceTo_Public_Double_byref_DwdVector2Floating_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x00032D94 File Offset: 0x00030F94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 556192, XrefRangeEnd = 556198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AngleRadians MinimumAngleTo([In] ref DwdVector2Floating point)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &point;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdVector2Floating.NativeMethodInfoPtr_MinimumAngleTo_Public_AngleRadians_byref_DwdVector2Floating_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x00032DD4 File Offset: 0x00030FD4
		[CallerCount(0)]
		public unsafe DwdVector2Floating ProjectOnto([In] ref DwdVector2Floating ontoVector)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ontoVector;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdVector2Floating.NativeMethodInfoPtr_ProjectOnto_Public_DwdVector2Floating_byref_DwdVector2Floating_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x00032E14 File Offset: 0x00031014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 556198, XrefRangeEnd = 556203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DwdVector2Floating Rotate([In] ref double rotationInRadians)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &rotationInRadians;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdVector2Floating.NativeMethodInfoPtr_Rotate_Public_DwdVector2Floating_byref_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x00032E54 File Offset: 0x00031054
		[CallerCount(0)]
		public unsafe DwdVector2Floating CounterClockwisePerpendicular()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdVector2Floating.NativeMethodInfoPtr_CounterClockwisePerpendicular_Public_DwdVector2Floating_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x00032E84 File Offset: 0x00031084
		[CallerCount(0)]
		public unsafe static implicit operator DwdVector2Floating([In] ref DwdVector2 intVector)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &intVector;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdVector2Floating.NativeMethodInfoPtr_op_Implicit_Public_Static_DwdVector2Floating_byref_DwdVector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000667 RID: 1639 RVA: 0x00032EC4 File Offset: 0x000310C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 556203, XrefRangeEnd = 556208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator DwdVector2([In] ref DwdVector2Floating floatingVector)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &floatingVector;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdVector2Floating.NativeMethodInfoPtr_op_Implicit_Public_Static_DwdVector2_byref_DwdVector2Floating_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x00032F04 File Offset: 0x00031104
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 556216, RefRangeEnd = 556220, XrefRangeStart = 556208, XrefRangeEnd = 556216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdVector2Floating.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000669 RID: 1641 RVA: 0x00032F30 File Offset: 0x00031130
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 556221, RefRangeEnd = 556223, XrefRangeStart = 556220, XrefRangeEnd = 556221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(DwdVector2Floating other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdVector2Floating.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_DwdVector2Floating_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x00032F70 File Offset: 0x00031170
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 556223, XrefRangeEnd = 556227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdVector2Floating.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600066B RID: 1643 RVA: 0x00032FB4 File Offset: 0x000311B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 556227, RefRangeEnd = 556229, XrefRangeStart = 556227, XrefRangeEnd = 556227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdVector2Floating.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600066C RID: 1644 RVA: 0x00004974 File Offset: 0x00002B74
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DwdVector2Floating>.NativeClassPtr, ref this));
		}

		// Token: 0x0400042C RID: 1068
		private static readonly IntPtr NativeFieldInfoPtr_X;

		// Token: 0x0400042D RID: 1069
		private static readonly IntPtr NativeFieldInfoPtr_Y;

		// Token: 0x0400042E RID: 1070
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_byref_Double_byref_Double_0;

		// Token: 0x0400042F RID: 1071
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_DwdVector2Floating_byref_DwdVector2Floating_byref_DwdVector2Floating_0;

		// Token: 0x04000430 RID: 1072
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_DwdVector2Floating_byref_DwdVector2Floating_byref_DwdVector2_0;

		// Token: 0x04000431 RID: 1073
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryNegation_Public_Static_DwdVector2Floating_byref_DwdVector2Floating_0;

		// Token: 0x04000432 RID: 1074
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_DwdVector2Floating_byref_DwdVector2Floating_byref_DwdVector2Floating_0;

		// Token: 0x04000433 RID: 1075
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_DwdVector2Floating_byref_DwdVector2Floating_byref_DwdVector2_0;

		// Token: 0x04000434 RID: 1076
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_DwdVector2Floating_byref_DwdVector2Floating_byref_Double_0;

		// Token: 0x04000435 RID: 1077
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_DwdVector2Floating_byref_DwdVector2Floating_byref_Double_0;

		// Token: 0x04000436 RID: 1078
		private static readonly IntPtr NativeMethodInfoPtr_DotProduct_Public_Double_byref_DwdVector2Floating_0;

		// Token: 0x04000437 RID: 1079
		private static readonly IntPtr NativeMethodInfoPtr_CrossProduct_Public_Double_byref_DwdVector2Floating_0;

		// Token: 0x04000438 RID: 1080
		private static readonly IntPtr NativeMethodInfoPtr_MagnitudeSquared_Public_Double_0;

		// Token: 0x04000439 RID: 1081
		private static readonly IntPtr NativeMethodInfoPtr_Magnitude_Public_Double_0;

		// Token: 0x0400043A RID: 1082
		private static readonly IntPtr NativeMethodInfoPtr_Angle_Public_AngleRadians_0;

		// Token: 0x0400043B RID: 1083
		private static readonly IntPtr NativeMethodInfoPtr_DistanceTo_Public_Double_byref_DwdVector2Floating_0;

		// Token: 0x0400043C RID: 1084
		private static readonly IntPtr NativeMethodInfoPtr_MinimumAngleTo_Public_AngleRadians_byref_DwdVector2Floating_0;

		// Token: 0x0400043D RID: 1085
		private static readonly IntPtr NativeMethodInfoPtr_ProjectOnto_Public_DwdVector2Floating_byref_DwdVector2Floating_0;

		// Token: 0x0400043E RID: 1086
		private static readonly IntPtr NativeMethodInfoPtr_Rotate_Public_DwdVector2Floating_byref_Double_0;

		// Token: 0x0400043F RID: 1087
		private static readonly IntPtr NativeMethodInfoPtr_CounterClockwisePerpendicular_Public_DwdVector2Floating_0;

		// Token: 0x04000440 RID: 1088
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_DwdVector2Floating_byref_DwdVector2_0;

		// Token: 0x04000441 RID: 1089
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_DwdVector2_byref_DwdVector2Floating_0;

		// Token: 0x04000442 RID: 1090
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000443 RID: 1091
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_DwdVector2Floating_0;

		// Token: 0x04000444 RID: 1092
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000445 RID: 1093
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000446 RID: 1094
		[FieldOffset(0)]
		public readonly double X;

		// Token: 0x04000447 RID: 1095
		[FieldOffset(8)]
		public readonly double Y;
	}
}
