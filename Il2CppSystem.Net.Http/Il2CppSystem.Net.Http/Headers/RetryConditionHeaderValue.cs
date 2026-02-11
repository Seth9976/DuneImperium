using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net.Http.Headers
{
	// Token: 0x02000035 RID: 53
	public class RetryConditionHeaderValue : Object
	{
		// Token: 0x06000351 RID: 849 RVA: 0x0001215C File Offset: 0x0001035C
		// Note: this type is marked as 'beforefieldinit'.
		static RetryConditionHeaderValue()
		{
			Il2CppClassPointerStore<RetryConditionHeaderValue>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Net.Http.dll", "System.Net.Http.Headers", "RetryConditionHeaderValue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RetryConditionHeaderValue>.NativeClassPtr);
			RetryConditionHeaderValue.NativeFieldInfoPtr__Date_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RetryConditionHeaderValue>.NativeClassPtr, "<Date>k__BackingField");
			RetryConditionHeaderValue.NativeFieldInfoPtr__Delta_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RetryConditionHeaderValue>.NativeClassPtr, "<Delta>k__BackingField");
			RetryConditionHeaderValue.NativeMethodInfoPtr__ctor_Public_Void_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RetryConditionHeaderValue>.NativeClassPtr, 100663856);
			RetryConditionHeaderValue.NativeMethodInfoPtr__ctor_Public_Void_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RetryConditionHeaderValue>.NativeClassPtr, 100663857);
			RetryConditionHeaderValue.NativeMethodInfoPtr_get_Date_Public_get_Nullable_1_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RetryConditionHeaderValue>.NativeClassPtr, 100663858);
			RetryConditionHeaderValue.NativeMethodInfoPtr_set_Date_Private_set_Void_Nullable_1_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RetryConditionHeaderValue>.NativeClassPtr, 100663859);
			RetryConditionHeaderValue.NativeMethodInfoPtr_get_Delta_Public_get_Nullable_1_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RetryConditionHeaderValue>.NativeClassPtr, 100663860);
			RetryConditionHeaderValue.NativeMethodInfoPtr_set_Delta_Private_set_Void_Nullable_1_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RetryConditionHeaderValue>.NativeClassPtr, 100663861);
			RetryConditionHeaderValue.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RetryConditionHeaderValue>.NativeClassPtr, 100663862);
			RetryConditionHeaderValue.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RetryConditionHeaderValue>.NativeClassPtr, 100663863);
			RetryConditionHeaderValue.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RetryConditionHeaderValue>.NativeClassPtr, 100663864);
			RetryConditionHeaderValue.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_RetryConditionHeaderValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RetryConditionHeaderValue>.NativeClassPtr, 100663865);
			RetryConditionHeaderValue.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RetryConditionHeaderValue>.NativeClassPtr, 100663866);
		}

		// Token: 0x06000352 RID: 850 RVA: 0x00012290 File Offset: 0x00010490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1175811, XrefRangeEnd = 1175815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RetryConditionHeaderValue(DateTimeOffset date)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RetryConditionHeaderValue>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref date;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RetryConditionHeaderValue.NativeMethodInfoPtr__ctor_Public_Void_DateTimeOffset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000353 RID: 851 RVA: 0x000122D8 File Offset: 0x000104D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1175815, XrefRangeEnd = 1175823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RetryConditionHeaderValue(TimeSpan delta)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RetryConditionHeaderValue>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref delta;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RetryConditionHeaderValue.NativeMethodInfoPtr__ctor_Public_Void_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000354 RID: 852 RVA: 0x00012320 File Offset: 0x00010520
		// (set) Token: 0x06000355 RID: 853 RVA: 0x00012358 File Offset: 0x00010558
		public unsafe Nullable<DateTimeOffset> Date
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RetryConditionHeaderValue.NativeMethodInfoPtr_get_Date_Public_get_Nullable_1_DateTimeOffset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<DateTimeOffset>(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RetryConditionHeaderValue.NativeMethodInfoPtr_set_Date_Private_set_Void_Nullable_1_DateTimeOffset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000356 RID: 854 RVA: 0x000123A0 File Offset: 0x000105A0
		// (set) Token: 0x06000357 RID: 855 RVA: 0x000123D8 File Offset: 0x000105D8
		public unsafe Nullable<TimeSpan> Delta
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RetryConditionHeaderValue.NativeMethodInfoPtr_get_Delta_Public_get_Nullable_1_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<TimeSpan>(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 755145, RefRangeEnd = 755149, XrefRangeStart = 755145, XrefRangeEnd = 755149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RetryConditionHeaderValue.NativeMethodInfoPtr_set_Delta_Private_set_Void_Nullable_1_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000358 RID: 856 RVA: 0x00012420 File Offset: 0x00010620
		[CallerCount(105)]
		[CachedScanResults(RefRangeStart = 1172447, RefRangeEnd = 1172552, XrefRangeStart = 1172447, XrefRangeEnd = 1172552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object System_ICloneable_Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RetryConditionHeaderValue.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000359 RID: 857 RVA: 0x00012460 File Offset: 0x00010660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1175823, XrefRangeEnd = 1175840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RetryConditionHeaderValue.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600035A RID: 858 RVA: 0x000124B8 File Offset: 0x000106B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1175840, XrefRangeEnd = 1175846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RetryConditionHeaderValue.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600035B RID: 859 RVA: 0x00012500 File Offset: 0x00010700
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1175846, XrefRangeEnd = 1175885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParse(string input, out RetryConditionHeaderValue parsedValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RetryConditionHeaderValue.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_RetryConditionHeaderValue_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			parsedValue = ((intPtr4 == 0) ? null : new RetryConditionHeaderValue(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600035C RID: 860 RVA: 0x00012564 File Offset: 0x00010764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1175885, XrefRangeEnd = 1175901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RetryConditionHeaderValue.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600035D RID: 861 RVA: 0x00003273 File Offset: 0x00001473
		public RetryConditionHeaderValue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x0600035E RID: 862 RVA: 0x000125A8 File Offset: 0x000107A8
		// (set) Token: 0x0600035F RID: 863 RVA: 0x0000327C File Offset: 0x0000147C
		public Nullable<DateTimeOffset> _Date_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RetryConditionHeaderValue.NativeFieldInfoPtr__Date_k__BackingField);
				return new Nullable<DateTimeOffset>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<DateTimeOffset>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RetryConditionHeaderValue.NativeFieldInfoPtr__Date_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<DateTimeOffset>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000360 RID: 864 RVA: 0x000125D8 File Offset: 0x000107D8
		// (set) Token: 0x06000361 RID: 865 RVA: 0x000032AA File Offset: 0x000014AA
		public Nullable<TimeSpan> _Delta_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RetryConditionHeaderValue.NativeFieldInfoPtr__Delta_k__BackingField);
				return new Nullable<TimeSpan>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<TimeSpan>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RetryConditionHeaderValue.NativeFieldInfoPtr__Delta_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<TimeSpan>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000278 RID: 632
		private static readonly IntPtr NativeFieldInfoPtr__Date_k__BackingField;

		// Token: 0x04000279 RID: 633
		private static readonly IntPtr NativeFieldInfoPtr__Delta_k__BackingField;

		// Token: 0x0400027A RID: 634
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DateTimeOffset_0;

		// Token: 0x0400027B RID: 635
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TimeSpan_0;

		// Token: 0x0400027C RID: 636
		private static readonly IntPtr NativeMethodInfoPtr_get_Date_Public_get_Nullable_1_DateTimeOffset_0;

		// Token: 0x0400027D RID: 637
		private static readonly IntPtr NativeMethodInfoPtr_set_Date_Private_set_Void_Nullable_1_DateTimeOffset_0;

		// Token: 0x0400027E RID: 638
		private static readonly IntPtr NativeMethodInfoPtr_get_Delta_Public_get_Nullable_1_TimeSpan_0;

		// Token: 0x0400027F RID: 639
		private static readonly IntPtr NativeMethodInfoPtr_set_Delta_Private_set_Void_Nullable_1_TimeSpan_0;

		// Token: 0x04000280 RID: 640
		private static readonly IntPtr NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0;

		// Token: 0x04000281 RID: 641
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000282 RID: 642
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000283 RID: 643
		private static readonly IntPtr NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_RetryConditionHeaderValue_0;

		// Token: 0x04000284 RID: 644
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
