using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net.Http.Headers
{
	// Token: 0x02000032 RID: 50
	public class RangeConditionHeaderValue : Object
	{
		// Token: 0x06000322 RID: 802 RVA: 0x000114C4 File Offset: 0x0000F6C4
		// Note: this type is marked as 'beforefieldinit'.
		static RangeConditionHeaderValue()
		{
			Il2CppClassPointerStore<RangeConditionHeaderValue>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Net.Http.dll", "System.Net.Http.Headers", "RangeConditionHeaderValue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RangeConditionHeaderValue>.NativeClassPtr);
			RangeConditionHeaderValue.NativeFieldInfoPtr__Date_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RangeConditionHeaderValue>.NativeClassPtr, "<Date>k__BackingField");
			RangeConditionHeaderValue.NativeFieldInfoPtr__EntityTag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RangeConditionHeaderValue>.NativeClassPtr, "<EntityTag>k__BackingField");
			RangeConditionHeaderValue.NativeMethodInfoPtr__ctor_Public_Void_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RangeConditionHeaderValue>.NativeClassPtr, 100663827);
			RangeConditionHeaderValue.NativeMethodInfoPtr__ctor_Public_Void_EntityTagHeaderValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RangeConditionHeaderValue>.NativeClassPtr, 100663828);
			RangeConditionHeaderValue.NativeMethodInfoPtr_get_Date_Public_get_Nullable_1_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RangeConditionHeaderValue>.NativeClassPtr, 100663829);
			RangeConditionHeaderValue.NativeMethodInfoPtr_set_Date_Private_set_Void_Nullable_1_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RangeConditionHeaderValue>.NativeClassPtr, 100663830);
			RangeConditionHeaderValue.NativeMethodInfoPtr_get_EntityTag_Public_get_EntityTagHeaderValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RangeConditionHeaderValue>.NativeClassPtr, 100663831);
			RangeConditionHeaderValue.NativeMethodInfoPtr_set_EntityTag_Private_set_Void_EntityTagHeaderValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RangeConditionHeaderValue>.NativeClassPtr, 100663832);
			RangeConditionHeaderValue.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RangeConditionHeaderValue>.NativeClassPtr, 100663833);
			RangeConditionHeaderValue.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RangeConditionHeaderValue>.NativeClassPtr, 100663834);
			RangeConditionHeaderValue.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RangeConditionHeaderValue>.NativeClassPtr, 100663835);
			RangeConditionHeaderValue.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_RangeConditionHeaderValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RangeConditionHeaderValue>.NativeClassPtr, 100663836);
			RangeConditionHeaderValue.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RangeConditionHeaderValue>.NativeClassPtr, 100663837);
		}

		// Token: 0x06000323 RID: 803 RVA: 0x000115F8 File Offset: 0x0000F7F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1175558, XrefRangeEnd = 1175562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RangeConditionHeaderValue(DateTimeOffset date)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RangeConditionHeaderValue>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref date;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RangeConditionHeaderValue.NativeMethodInfoPtr__ctor_Public_Void_DateTimeOffset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000324 RID: 804 RVA: 0x00011640 File Offset: 0x0000F840
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1175562, XrefRangeEnd = 1175570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RangeConditionHeaderValue(EntityTagHeaderValue entityTag)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RangeConditionHeaderValue>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityTag);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RangeConditionHeaderValue.NativeMethodInfoPtr__ctor_Public_Void_EntityTagHeaderValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000325 RID: 805 RVA: 0x0001168C File Offset: 0x0000F88C
		// (set) Token: 0x06000326 RID: 806 RVA: 0x000116C4 File Offset: 0x0000F8C4
		public unsafe Nullable<DateTimeOffset> Date
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RangeConditionHeaderValue.NativeMethodInfoPtr_get_Date_Public_get_Nullable_1_DateTimeOffset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RangeConditionHeaderValue.NativeMethodInfoPtr_set_Date_Private_set_Void_Nullable_1_DateTimeOffset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000327 RID: 807 RVA: 0x0001170C File Offset: 0x0000F90C
		// (set) Token: 0x06000328 RID: 808 RVA: 0x0001174C File Offset: 0x0000F94C
		public unsafe EntityTagHeaderValue EntityTag
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RangeConditionHeaderValue.NativeMethodInfoPtr_get_EntityTag_Public_get_EntityTagHeaderValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityTagHeaderValue>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RangeConditionHeaderValue.NativeMethodInfoPtr_set_EntityTag_Private_set_Void_EntityTagHeaderValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000329 RID: 809 RVA: 0x00011790 File Offset: 0x0000F990
		[CallerCount(105)]
		[CachedScanResults(RefRangeStart = 1172447, RefRangeEnd = 1172552, XrefRangeStart = 1172447, XrefRangeEnd = 1172552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object System_ICloneable_Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RangeConditionHeaderValue.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600032A RID: 810 RVA: 0x000117D0 File Offset: 0x0000F9D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1175570, XrefRangeEnd = 1175579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RangeConditionHeaderValue.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600032B RID: 811 RVA: 0x00011828 File Offset: 0x0000FA28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1175579, XrefRangeEnd = 1175580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RangeConditionHeaderValue.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600032C RID: 812 RVA: 0x00011870 File Offset: 0x0000FA70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1175580, XrefRangeEnd = 1175620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParse(string input, out RangeConditionHeaderValue parsedValue)
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RangeConditionHeaderValue.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_RangeConditionHeaderValue_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			parsedValue = ((intPtr4 == 0) ? null : new RangeConditionHeaderValue(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600032D RID: 813 RVA: 0x000118D4 File Offset: 0x0000FAD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1175620, XrefRangeEnd = 1175633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RangeConditionHeaderValue.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600032E RID: 814 RVA: 0x00003171 File Offset: 0x00001371
		public RangeConditionHeaderValue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x0600032F RID: 815 RVA: 0x00011918 File Offset: 0x0000FB18
		// (set) Token: 0x06000330 RID: 816 RVA: 0x0000317A File Offset: 0x0000137A
		public Nullable<DateTimeOffset> _Date_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RangeConditionHeaderValue.NativeFieldInfoPtr__Date_k__BackingField);
				return new Nullable<DateTimeOffset>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<DateTimeOffset>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RangeConditionHeaderValue.NativeFieldInfoPtr__Date_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<DateTimeOffset>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000331 RID: 817 RVA: 0x00011948 File Offset: 0x0000FB48
		// (set) Token: 0x06000332 RID: 818 RVA: 0x000031A8 File Offset: 0x000013A8
		public unsafe EntityTagHeaderValue _EntityTag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RangeConditionHeaderValue.NativeFieldInfoPtr__EntityTag_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityTagHeaderValue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RangeConditionHeaderValue.NativeFieldInfoPtr__EntityTag_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000255 RID: 597
		private static readonly IntPtr NativeFieldInfoPtr__Date_k__BackingField;

		// Token: 0x04000256 RID: 598
		private static readonly IntPtr NativeFieldInfoPtr__EntityTag_k__BackingField;

		// Token: 0x04000257 RID: 599
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DateTimeOffset_0;

		// Token: 0x04000258 RID: 600
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EntityTagHeaderValue_0;

		// Token: 0x04000259 RID: 601
		private static readonly IntPtr NativeMethodInfoPtr_get_Date_Public_get_Nullable_1_DateTimeOffset_0;

		// Token: 0x0400025A RID: 602
		private static readonly IntPtr NativeMethodInfoPtr_set_Date_Private_set_Void_Nullable_1_DateTimeOffset_0;

		// Token: 0x0400025B RID: 603
		private static readonly IntPtr NativeMethodInfoPtr_get_EntityTag_Public_get_EntityTagHeaderValue_0;

		// Token: 0x0400025C RID: 604
		private static readonly IntPtr NativeMethodInfoPtr_set_EntityTag_Private_set_Void_EntityTagHeaderValue_0;

		// Token: 0x0400025D RID: 605
		private static readonly IntPtr NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0;

		// Token: 0x0400025E RID: 606
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400025F RID: 607
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000260 RID: 608
		private static readonly IntPtr NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_RangeConditionHeaderValue_0;

		// Token: 0x04000261 RID: 609
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
