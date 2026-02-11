using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Yoga
{
	// Token: 0x02000016 RID: 22
	[StructLayout(2)]
	public struct YogaValue
	{
		// Token: 0x06000160 RID: 352 RVA: 0x00021244 File Offset: 0x0001F444
		// Note: this type is marked as 'beforefieldinit'.
		static YogaValue()
		{
			Il2CppClassPointerStore<YogaValue>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.Yoga", "YogaValue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<YogaValue>.NativeClassPtr);
			YogaValue.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YogaValue>.NativeClassPtr, "value");
			YogaValue.NativeFieldInfoPtr_unit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YogaValue>.NativeClassPtr, "unit");
			YogaValue.NativeMethodInfoPtr_get_Unit_Public_get_YogaUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaValue>.NativeClassPtr, 100663460);
			YogaValue.NativeMethodInfoPtr_get_Value_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaValue>.NativeClassPtr, 100663461);
			YogaValue.NativeMethodInfoPtr_Point_Public_Static_YogaValue_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaValue>.NativeClassPtr, 100663462);
			YogaValue.NativeMethodInfoPtr_Equals_Public_Boolean_YogaValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaValue>.NativeClassPtr, 100663463);
			YogaValue.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaValue>.NativeClassPtr, 100663464);
			YogaValue.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaValue>.NativeClassPtr, 100663465);
			YogaValue.NativeMethodInfoPtr_Auto_Public_Static_YogaValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaValue>.NativeClassPtr, 100663466);
			YogaValue.NativeMethodInfoPtr_Percent_Public_Static_YogaValue_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaValue>.NativeClassPtr, 100663467);
			YogaValue.NativeMethodInfoPtr_op_Implicit_Public_Static_YogaValue_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaValue>.NativeClassPtr, 100663468);
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000161 RID: 353 RVA: 0x00021350 File Offset: 0x0001F550
		public unsafe YogaUnit Unit
		{
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 283125, RefRangeEnd = 283150, XrefRangeStart = 283125, XrefRangeEnd = 283125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaValue.NativeMethodInfoPtr_get_Unit_Public_get_YogaUnit_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000162 RID: 354 RVA: 0x00021380 File Offset: 0x0001F580
		public unsafe float Value
		{
			[CallerCount(58)]
			[CachedScanResults(RefRangeStart = 283150, RefRangeEnd = 283208, XrefRangeStart = 283150, XrefRangeEnd = 283150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaValue.NativeMethodInfoPtr_get_Value_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000163 RID: 355 RVA: 0x000213B0 File Offset: 0x0001F5B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 283208, RefRangeEnd = 283210, XrefRangeStart = 283208, XrefRangeEnd = 283208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static YogaValue Point(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaValue.NativeMethodInfoPtr_Point_Public_Static_YogaValue_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000164 RID: 356 RVA: 0x000213F0 File Offset: 0x0001F5F0
		[CallerCount(0)]
		public unsafe bool Equals(YogaValue other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaValue.NativeMethodInfoPtr_Equals_Public_Boolean_YogaValue_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00021430 File Offset: 0x0001F630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283210, XrefRangeEnd = 283214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaValue.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00021474 File Offset: 0x0001F674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283214, XrefRangeEnd = 283215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaValue.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000167 RID: 359 RVA: 0x000214A4 File Offset: 0x0001F6A4
		[CallerCount(0)]
		public unsafe static YogaValue Auto()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaValue.NativeMethodInfoPtr_Auto_Public_Static_YogaValue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000168 RID: 360 RVA: 0x000214D4 File Offset: 0x0001F6D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 283215, RefRangeEnd = 283216, XrefRangeStart = 283215, XrefRangeEnd = 283215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static YogaValue Percent(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaValue.NativeMethodInfoPtr_Percent_Public_Static_YogaValue_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00021514 File Offset: 0x0001F714
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 283208, RefRangeEnd = 283210, XrefRangeStart = 283208, XrefRangeEnd = 283210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator YogaValue(float pointValue)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaValue.NativeMethodInfoPtr_op_Implicit_Public_Static_YogaValue_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600016A RID: 362 RVA: 0x0000261A File Offset: 0x0000081A
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<YogaValue>.NativeClassPtr, ref this));
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00021554 File Offset: 0x0001F754
		public static YogaValue Undefined()
		{
			return new YogaValue
			{
				value = float.NaN,
				unit = YogaUnit.Undefined
			};
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00021584 File Offset: 0x0001F784
		public static YogaValue MarshalValue(YogaValue value)
		{
			return value;
		}

		// Token: 0x04000112 RID: 274
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x04000113 RID: 275
		private static readonly IntPtr NativeFieldInfoPtr_unit;

		// Token: 0x04000114 RID: 276
		private static readonly IntPtr NativeMethodInfoPtr_get_Unit_Public_get_YogaUnit_0;

		// Token: 0x04000115 RID: 277
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_Single_0;

		// Token: 0x04000116 RID: 278
		private static readonly IntPtr NativeMethodInfoPtr_Point_Public_Static_YogaValue_Single_0;

		// Token: 0x04000117 RID: 279
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Boolean_YogaValue_0;

		// Token: 0x04000118 RID: 280
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000119 RID: 281
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400011A RID: 282
		private static readonly IntPtr NativeMethodInfoPtr_Auto_Public_Static_YogaValue_0;

		// Token: 0x0400011B RID: 283
		private static readonly IntPtr NativeMethodInfoPtr_Percent_Public_Static_YogaValue_Single_0;

		// Token: 0x0400011C RID: 284
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_YogaValue_Single_0;

		// Token: 0x0400011D RID: 285
		[FieldOffset(0)]
		public float value;

		// Token: 0x0400011E RID: 286
		[FieldOffset(4)]
		public YogaUnit unit;
	}
}
