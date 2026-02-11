using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Canis.mathLib
{
	// Token: 0x0200006F RID: 111
	[StructLayout(2)]
	public struct AngleRadians
	{
		// Token: 0x060005F7 RID: 1527 RVA: 0x00030AD0 File Offset: 0x0002ECD0
		// Note: this type is marked as 'beforefieldinit'.
		static AngleRadians()
		{
			Il2CppClassPointerStore<AngleRadians>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.mathLib", "AngleRadians");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AngleRadians>.NativeClassPtr);
			AngleRadians.NativeFieldInfoPtr__radians = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AngleRadians>.NativeClassPtr, "_radians");
			AngleRadians.NativeFieldInfoPtr_RadiansMod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AngleRadians>.NativeClassPtr, "RadiansMod");
			AngleRadians.NativeMethodInfoPtr__ctor_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AngleRadians>.NativeClassPtr, 100664501);
			AngleRadians.NativeMethodInfoPtr_op_Implicit_Public_Static_Double_AngleRadians_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AngleRadians>.NativeClassPtr, 100664502);
			AngleRadians.NativeMethodInfoPtr_op_Implicit_Public_Static_AngleDegrees_AngleRadians_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AngleRadians>.NativeClassPtr, 100664503);
			AngleRadians.NativeMethodInfoPtr_PositiveAngleModulo_Private_Static_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AngleRadians>.NativeClassPtr, 100664504);
			AngleRadians.NativeMethodInfoPtr_op_Addition_Public_Static_AngleRadians_AngleRadians_AngleRadians_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AngleRadians>.NativeClassPtr, 100664505);
			AngleRadians.NativeMethodInfoPtr_op_Subtraction_Public_Static_AngleRadians_AngleRadians_AngleRadians_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AngleRadians>.NativeClassPtr, 100664506);
			AngleRadians.NativeMethodInfoPtr_op_Multiply_Public_Static_AngleRadians_AngleRadians_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AngleRadians>.NativeClassPtr, 100664507);
			AngleRadians.NativeMethodInfoPtr_op_Division_Public_Static_AngleRadians_AngleRadians_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AngleRadians>.NativeClassPtr, 100664508);
			AngleRadians.NativeMethodInfoPtr_Min_Public_AngleRadians_AngleRadians_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AngleRadians>.NativeClassPtr, 100664509);
			AngleRadians.NativeMethodInfoPtr_Max_Public_AngleRadians_AngleRadians_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AngleRadians>.NativeClassPtr, 100664510);
			AngleRadians.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AngleRadians_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AngleRadians>.NativeClassPtr, 100664511);
			AngleRadians.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AngleRadians>.NativeClassPtr, 100664512);
			AngleRadians.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AngleRadians>.NativeClassPtr, 100664513);
			AngleRadians.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AngleRadians>.NativeClassPtr, 100664514);
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x00030C40 File Offset: 0x0002EE40
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 555587, RefRangeEnd = 555594, XrefRangeStart = 555587, XrefRangeEnd = 555587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AngleRadians(double radians)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref radians;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AngleRadians.NativeMethodInfoPtr__ctor_Public_Void_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x00030C74 File Offset: 0x0002EE74
		[CallerCount(0)]
		public unsafe static implicit operator double(AngleRadians angle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref angle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AngleRadians.NativeMethodInfoPtr_op_Implicit_Public_Static_Double_AngleRadians_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x00030CB4 File Offset: 0x0002EEB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 555594, XrefRangeEnd = 555598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator AngleDegrees(AngleRadians angle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref angle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AngleRadians.NativeMethodInfoPtr_op_Implicit_Public_Static_AngleDegrees_AngleRadians_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x00030CF4 File Offset: 0x0002EEF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 555598, XrefRangeEnd = 555600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double PositiveAngleModulo(double radians)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref radians;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AngleRadians.NativeMethodInfoPtr_PositiveAngleModulo_Private_Static_Double_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x00030D34 File Offset: 0x0002EF34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 555602, RefRangeEnd = 555603, XrefRangeStart = 555600, XrefRangeEnd = 555602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AngleRadians operator +(AngleRadians angle, AngleRadians angle2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref angle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref angle2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AngleRadians.NativeMethodInfoPtr_op_Addition_Public_Static_AngleRadians_AngleRadians_AngleRadians_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x00030D80 File Offset: 0x0002EF80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 555603, XrefRangeEnd = 555605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AngleRadians operator -(AngleRadians angle, AngleRadians angle2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref angle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref angle2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AngleRadians.NativeMethodInfoPtr_op_Subtraction_Public_Static_AngleRadians_AngleRadians_AngleRadians_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x00030DCC File Offset: 0x0002EFCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 555605, XrefRangeEnd = 555607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AngleRadians operator *(AngleRadians angle, double scalar)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref angle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scalar;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AngleRadians.NativeMethodInfoPtr_op_Multiply_Public_Static_AngleRadians_AngleRadians_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x00030E18 File Offset: 0x0002F018
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 555609, RefRangeEnd = 555610, XrefRangeStart = 555607, XrefRangeEnd = 555609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AngleRadians operator /(AngleRadians angle, double scalar)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref angle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scalar;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AngleRadians.NativeMethodInfoPtr_op_Division_Public_Static_AngleRadians_AngleRadians_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x00030E64 File Offset: 0x0002F064
		[CallerCount(0)]
		public unsafe AngleRadians Min(AngleRadians angle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref angle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AngleRadians.NativeMethodInfoPtr_Min_Public_AngleRadians_AngleRadians_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000601 RID: 1537 RVA: 0x00030EA4 File Offset: 0x0002F0A4
		[CallerCount(0)]
		public unsafe AngleRadians Max(AngleRadians angle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref angle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AngleRadians.NativeMethodInfoPtr_Max_Public_AngleRadians_AngleRadians_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x00030EE4 File Offset: 0x0002F0E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 555610, XrefRangeEnd = 555611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(AngleRadians other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AngleRadians.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AngleRadians_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x00030F24 File Offset: 0x0002F124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 555611, XrefRangeEnd = 555615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AngleRadians.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x00030F68 File Offset: 0x0002F168
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AngleRadians.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x00030F98 File Offset: 0x0002F198
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 555615, XrefRangeEnd = 555621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AngleRadians.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x000048DB File Offset: 0x00002ADB
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AngleRadians>.NativeClassPtr, ref this));
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x06000607 RID: 1543 RVA: 0x00030FC4 File Offset: 0x0002F1C4
		// (set) Token: 0x06000608 RID: 1544 RVA: 0x000048ED File Offset: 0x00002AED
		public unsafe static double RadiansMod
		{
			get
			{
				double num;
				IL2CPP.il2cpp_field_static_get_value(AngleRadians.NativeFieldInfoPtr_RadiansMod, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AngleRadians.NativeFieldInfoPtr_RadiansMod, (void*)(&value));
			}
		}

		// Token: 0x040003CB RID: 971
		private static readonly IntPtr NativeFieldInfoPtr__radians;

		// Token: 0x040003CC RID: 972
		private static readonly IntPtr NativeFieldInfoPtr_RadiansMod;

		// Token: 0x040003CD RID: 973
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_0;

		// Token: 0x040003CE RID: 974
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Double_AngleRadians_0;

		// Token: 0x040003CF RID: 975
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_AngleDegrees_AngleRadians_0;

		// Token: 0x040003D0 RID: 976
		private static readonly IntPtr NativeMethodInfoPtr_PositiveAngleModulo_Private_Static_Double_Double_0;

		// Token: 0x040003D1 RID: 977
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_AngleRadians_AngleRadians_AngleRadians_0;

		// Token: 0x040003D2 RID: 978
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_AngleRadians_AngleRadians_AngleRadians_0;

		// Token: 0x040003D3 RID: 979
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_AngleRadians_AngleRadians_Double_0;

		// Token: 0x040003D4 RID: 980
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_AngleRadians_AngleRadians_Double_0;

		// Token: 0x040003D5 RID: 981
		private static readonly IntPtr NativeMethodInfoPtr_Min_Public_AngleRadians_AngleRadians_0;

		// Token: 0x040003D6 RID: 982
		private static readonly IntPtr NativeMethodInfoPtr_Max_Public_AngleRadians_AngleRadians_0;

		// Token: 0x040003D7 RID: 983
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AngleRadians_0;

		// Token: 0x040003D8 RID: 984
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040003D9 RID: 985
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040003DA RID: 986
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040003DB RID: 987
		[FieldOffset(0)]
		public readonly double _radians;
	}
}
