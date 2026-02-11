using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Canis.mathLib
{
	// Token: 0x0200006E RID: 110
	[StructLayout(2)]
	public struct AngleDegrees
	{
		// Token: 0x060005EC RID: 1516 RVA: 0x000307AC File Offset: 0x0002E9AC
		// Note: this type is marked as 'beforefieldinit'.
		static AngleDegrees()
		{
			Il2CppClassPointerStore<AngleDegrees>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.mathLib", "AngleDegrees");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AngleDegrees>.NativeClassPtr);
			AngleDegrees.NativeFieldInfoPtr__degrees = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AngleDegrees>.NativeClassPtr, "_degrees");
			AngleDegrees.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AngleDegrees>.NativeClassPtr, 100664492);
			AngleDegrees.NativeMethodInfoPtr_op_Implicit_Public_Static_Int32_AngleDegrees_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AngleDegrees>.NativeClassPtr, 100664493);
			AngleDegrees.NativeMethodInfoPtr_op_Implicit_Public_Static_AngleRadians_AngleDegrees_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AngleDegrees>.NativeClassPtr, 100664494);
			AngleDegrees.NativeMethodInfoPtr_op_Addition_Public_Static_AngleDegrees_AngleDegrees_AngleDegrees_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AngleDegrees>.NativeClassPtr, 100664495);
			AngleDegrees.NativeMethodInfoPtr_op_Subtraction_Public_Static_AngleDegrees_AngleDegrees_AngleDegrees_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AngleDegrees>.NativeClassPtr, 100664496);
			AngleDegrees.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AngleDegrees_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AngleDegrees>.NativeClassPtr, 100664497);
			AngleDegrees.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AngleDegrees>.NativeClassPtr, 100664498);
			AngleDegrees.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AngleDegrees>.NativeClassPtr, 100664499);
			AngleDegrees.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AngleDegrees>.NativeClassPtr, 100664500);
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x000308A4 File Offset: 0x0002EAA4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 320163, RefRangeEnd = 320170, XrefRangeStart = 320163, XrefRangeEnd = 320170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AngleDegrees(int degrees)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref degrees;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AngleDegrees.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x000308D8 File Offset: 0x0002EAD8
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 555492, RefRangeEnd = 555566, XrefRangeStart = 555492, XrefRangeEnd = 555492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator int(AngleDegrees angle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref angle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AngleDegrees.NativeMethodInfoPtr_op_Implicit_Public_Static_Int32_AngleDegrees_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x00030918 File Offset: 0x0002EB18
		[CallerCount(0)]
		public unsafe static implicit operator AngleRadians(AngleDegrees angle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref angle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AngleDegrees.NativeMethodInfoPtr_op_Implicit_Public_Static_AngleRadians_AngleDegrees_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x00030958 File Offset: 0x0002EB58
		[CallerCount(0)]
		public unsafe static AngleDegrees operator +(AngleDegrees angle, AngleDegrees angle2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref angle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref angle2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AngleDegrees.NativeMethodInfoPtr_op_Addition_Public_Static_AngleDegrees_AngleDegrees_AngleDegrees_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x000309A4 File Offset: 0x0002EBA4
		[CallerCount(0)]
		public unsafe static AngleDegrees operator -(AngleDegrees angle, AngleDegrees angle2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref angle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref angle2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AngleDegrees.NativeMethodInfoPtr_op_Subtraction_Public_Static_AngleDegrees_AngleDegrees_AngleDegrees_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x000309F0 File Offset: 0x0002EBF0
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 555566, RefRangeEnd = 555578, XrefRangeStart = 555566, XrefRangeEnd = 555566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(AngleDegrees other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AngleDegrees.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AngleDegrees_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x00030A30 File Offset: 0x0002EC30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 555578, XrefRangeEnd = 555581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AngleDegrees.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x00030A74 File Offset: 0x0002EC74
		[CallerCount(200)]
		[CachedScanResults(RefRangeStart = 306429, RefRangeEnd = 306629, XrefRangeStart = 306429, XrefRangeEnd = 306629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AngleDegrees.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x00030AA4 File Offset: 0x0002ECA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 555581, XrefRangeEnd = 555587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AngleDegrees.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x000048C9 File Offset: 0x00002AC9
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AngleDegrees>.NativeClassPtr, ref this));
		}

		// Token: 0x040003C0 RID: 960
		private static readonly IntPtr NativeFieldInfoPtr__degrees;

		// Token: 0x040003C1 RID: 961
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040003C2 RID: 962
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Int32_AngleDegrees_0;

		// Token: 0x040003C3 RID: 963
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_AngleRadians_AngleDegrees_0;

		// Token: 0x040003C4 RID: 964
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_AngleDegrees_AngleDegrees_AngleDegrees_0;

		// Token: 0x040003C5 RID: 965
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_AngleDegrees_AngleDegrees_AngleDegrees_0;

		// Token: 0x040003C6 RID: 966
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AngleDegrees_0;

		// Token: 0x040003C7 RID: 967
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040003C8 RID: 968
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040003C9 RID: 969
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040003CA RID: 970
		[FieldOffset(0)]
		public readonly int _degrees;
	}
}
