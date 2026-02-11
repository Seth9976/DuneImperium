using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements.StyleSheets
{
	// Token: 0x02000284 RID: 644
	[Serializable]
	[StructLayout(2)]
	public struct Dimension
	{
		// Token: 0x0600303C RID: 12348 RVA: 0x000CCE24 File Offset: 0x000CB024
		// Note: this type is marked as 'beforefieldinit'.
		static Dimension()
		{
			Il2CppClassPointerStore<Dimension>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.StyleSheets", "Dimension");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dimension>.NativeClassPtr);
			Dimension.NativeFieldInfoPtr_unit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dimension>.NativeClassPtr, "unit");
			Dimension.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dimension>.NativeClassPtr, "value");
			Dimension.NativeMethodInfoPtr__ctor_Public_Void_Single_Unit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dimension>.NativeClassPtr, 100670302);
			Dimension.NativeMethodInfoPtr_ToLength_Public_Length_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dimension>.NativeClassPtr, 100670303);
			Dimension.NativeMethodInfoPtr_ToTime_Public_TimeValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dimension>.NativeClassPtr, 100670304);
			Dimension.NativeMethodInfoPtr_ToAngle_Public_Angle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dimension>.NativeClassPtr, 100670305);
			Dimension.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Dimension_Dimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dimension>.NativeClassPtr, 100670306);
			Dimension.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Dimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dimension>.NativeClassPtr, 100670307);
			Dimension.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dimension>.NativeClassPtr, 100670308);
			Dimension.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dimension>.NativeClassPtr, 100670309);
			Dimension.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dimension>.NativeClassPtr, 100670310);
		}

		// Token: 0x0600303D RID: 12349 RVA: 0x000CCF30 File Offset: 0x000CB130
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 357370, RefRangeEnd = 357371, XrefRangeStart = 357370, XrefRangeEnd = 357370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dimension(float value, Dimension.Unit unit)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dimension.NativeMethodInfoPtr__ctor_Public_Void_Single_Unit_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600303E RID: 12350 RVA: 0x000CCF70 File Offset: 0x000CB170
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 357371, XrefRangeEnd = 357372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Length ToLength()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dimension.NativeMethodInfoPtr_ToLength_Public_Length_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600303F RID: 12351 RVA: 0x000CCFA0 File Offset: 0x000CB1A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 357372, XrefRangeEnd = 357373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeValue ToTime()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dimension.NativeMethodInfoPtr_ToTime_Public_TimeValue_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003040 RID: 12352 RVA: 0x000CCFD0 File Offset: 0x000CB1D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 357373, XrefRangeEnd = 357374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Angle ToAngle()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dimension.NativeMethodInfoPtr_ToAngle_Public_Angle_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003041 RID: 12353 RVA: 0x000CD000 File Offset: 0x000CB200
		[CallerCount(0)]
		public unsafe static bool operator ==(Dimension lhs, Dimension rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dimension.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Dimension_Dimension_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003042 RID: 12354 RVA: 0x000CD04C File Offset: 0x000CB24C
		[CallerCount(0)]
		public unsafe bool Equals(Dimension other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dimension.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Dimension_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003043 RID: 12355 RVA: 0x000CD08C File Offset: 0x000CB28C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 357374, XrefRangeEnd = 357377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dimension.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003044 RID: 12356 RVA: 0x000CD0D0 File Offset: 0x000CB2D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 357377, XrefRangeEnd = 357379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dimension.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003045 RID: 12357 RVA: 0x000CD100 File Offset: 0x000CB300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 357379, XrefRangeEnd = 357412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dimension.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003046 RID: 12358 RVA: 0x00013B98 File Offset: 0x00011D98
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Dimension>.NativeClassPtr, ref this));
		}

		// Token: 0x06003047 RID: 12359 RVA: 0x000CD12C File Offset: 0x000CB32C
		public static bool operator !=(Dimension lhs, Dimension rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x04002335 RID: 9013
		private static readonly IntPtr NativeFieldInfoPtr_unit;

		// Token: 0x04002336 RID: 9014
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x04002337 RID: 9015
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Unit_0;

		// Token: 0x04002338 RID: 9016
		private static readonly IntPtr NativeMethodInfoPtr_ToLength_Public_Length_0;

		// Token: 0x04002339 RID: 9017
		private static readonly IntPtr NativeMethodInfoPtr_ToTime_Public_TimeValue_0;

		// Token: 0x0400233A RID: 9018
		private static readonly IntPtr NativeMethodInfoPtr_ToAngle_Public_Angle_0;

		// Token: 0x0400233B RID: 9019
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Dimension_Dimension_0;

		// Token: 0x0400233C RID: 9020
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Dimension_0;

		// Token: 0x0400233D RID: 9021
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400233E RID: 9022
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400233F RID: 9023
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04002340 RID: 9024
		[FieldOffset(0)]
		public Dimension.Unit unit;

		// Token: 0x04002341 RID: 9025
		[FieldOffset(4)]
		public float value;

		// Token: 0x02000565 RID: 1381
		public enum Unit
		{
			// Token: 0x04002E6A RID: 11882
			Unitless,
			// Token: 0x04002E6B RID: 11883
			Pixel,
			// Token: 0x04002E6C RID: 11884
			Percent,
			// Token: 0x04002E6D RID: 11885
			Second,
			// Token: 0x04002E6E RID: 11886
			Millisecond,
			// Token: 0x04002E6F RID: 11887
			Degree,
			// Token: 0x04002E70 RID: 11888
			Gradian,
			// Token: 0x04002E71 RID: 11889
			Radian,
			// Token: 0x04002E72 RID: 11890
			Turn
		}
	}
}
