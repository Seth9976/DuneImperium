using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net.Http.Headers
{
	// Token: 0x0200001D RID: 29
	public class ContentRangeHeaderValue : Object
	{
		// Token: 0x060001D8 RID: 472 RVA: 0x0000B608 File Offset: 0x00009808
		// Note: this type is marked as 'beforefieldinit'.
		static ContentRangeHeaderValue()
		{
			Il2CppClassPointerStore<ContentRangeHeaderValue>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Net.Http.dll", "System.Net.Http.Headers", "ContentRangeHeaderValue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContentRangeHeaderValue>.NativeClassPtr);
			ContentRangeHeaderValue.NativeFieldInfoPtr_unit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentRangeHeaderValue>.NativeClassPtr, "unit");
			ContentRangeHeaderValue.NativeFieldInfoPtr__From_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentRangeHeaderValue>.NativeClassPtr, "<From>k__BackingField");
			ContentRangeHeaderValue.NativeFieldInfoPtr__Length_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentRangeHeaderValue>.NativeClassPtr, "<Length>k__BackingField");
			ContentRangeHeaderValue.NativeFieldInfoPtr__To_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentRangeHeaderValue>.NativeClassPtr, "<To>k__BackingField");
			ContentRangeHeaderValue.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentRangeHeaderValue>.NativeClassPtr, 100663560);
			ContentRangeHeaderValue.NativeMethodInfoPtr_get_From_Public_get_Nullable_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentRangeHeaderValue>.NativeClassPtr, 100663561);
			ContentRangeHeaderValue.NativeMethodInfoPtr_set_From_Private_set_Void_Nullable_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentRangeHeaderValue>.NativeClassPtr, 100663562);
			ContentRangeHeaderValue.NativeMethodInfoPtr_get_Length_Public_get_Nullable_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentRangeHeaderValue>.NativeClassPtr, 100663563);
			ContentRangeHeaderValue.NativeMethodInfoPtr_set_Length_Private_set_Void_Nullable_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentRangeHeaderValue>.NativeClassPtr, 100663564);
			ContentRangeHeaderValue.NativeMethodInfoPtr_get_To_Public_get_Nullable_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentRangeHeaderValue>.NativeClassPtr, 100663565);
			ContentRangeHeaderValue.NativeMethodInfoPtr_set_To_Private_set_Void_Nullable_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentRangeHeaderValue>.NativeClassPtr, 100663566);
			ContentRangeHeaderValue.NativeMethodInfoPtr_get_Unit_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentRangeHeaderValue>.NativeClassPtr, 100663567);
			ContentRangeHeaderValue.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentRangeHeaderValue>.NativeClassPtr, 100663568);
			ContentRangeHeaderValue.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentRangeHeaderValue>.NativeClassPtr, 100663569);
			ContentRangeHeaderValue.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentRangeHeaderValue>.NativeClassPtr, 100663570);
			ContentRangeHeaderValue.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_ContentRangeHeaderValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentRangeHeaderValue>.NativeClassPtr, 100663571);
			ContentRangeHeaderValue.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentRangeHeaderValue>.NativeClassPtr, 100663572);
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x0000B78C File Offset: 0x0000998C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173253, XrefRangeEnd = 1173258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContentRangeHeaderValue()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContentRangeHeaderValue>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentRangeHeaderValue.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060001DA RID: 474 RVA: 0x0000B7C8 File Offset: 0x000099C8
		// (set) Token: 0x060001DB RID: 475 RVA: 0x0000B800 File Offset: 0x00009A00
		public unsafe Nullable<long> From
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentRangeHeaderValue.NativeMethodInfoPtr_get_From_Public_get_Nullable_1_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<long>(intPtr);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentRangeHeaderValue.NativeMethodInfoPtr_set_From_Private_set_Void_Nullable_1_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060001DC RID: 476 RVA: 0x0000B848 File Offset: 0x00009A48
		// (set) Token: 0x060001DD RID: 477 RVA: 0x0000B880 File Offset: 0x00009A80
		public unsafe Nullable<long> Length
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentRangeHeaderValue.NativeMethodInfoPtr_get_Length_Public_get_Nullable_1_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<long>(intPtr);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentRangeHeaderValue.NativeMethodInfoPtr_set_Length_Private_set_Void_Nullable_1_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060001DE RID: 478 RVA: 0x0000B8C8 File Offset: 0x00009AC8
		// (set) Token: 0x060001DF RID: 479 RVA: 0x0000B900 File Offset: 0x00009B00
		public unsafe Nullable<long> To
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentRangeHeaderValue.NativeMethodInfoPtr_get_To_Public_get_Nullable_1_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<long>(intPtr);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentRangeHeaderValue.NativeMethodInfoPtr_set_To_Private_set_Void_Nullable_1_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060001E0 RID: 480 RVA: 0x0000B948 File Offset: 0x00009B48
		public unsafe string Unit
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentRangeHeaderValue.NativeMethodInfoPtr_get_Unit_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x0000B980 File Offset: 0x00009B80
		[CallerCount(105)]
		[CachedScanResults(RefRangeStart = 1172447, RefRangeEnd = 1172552, XrefRangeStart = 1172447, XrefRangeEnd = 1172552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object System_ICloneable_Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentRangeHeaderValue.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x0000B9C0 File Offset: 0x00009BC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173258, XrefRangeEnd = 1173264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContentRangeHeaderValue.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x0000BA18 File Offset: 0x00009C18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173264, XrefRangeEnd = 1173272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContentRangeHeaderValue.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x0000BA60 File Offset: 0x00009C60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173272, XrefRangeEnd = 1173340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParse(string input, out ContentRangeHeaderValue parsedValue)
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ContentRangeHeaderValue.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_ContentRangeHeaderValue_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			parsedValue = ((intPtr4 == 0) ? null : new ContentRangeHeaderValue(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x0000BAC4 File Offset: 0x00009CC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173340, XrefRangeEnd = 1173380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContentRangeHeaderValue.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00002BEB File Offset: 0x00000DEB
		public ContentRangeHeaderValue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060001E7 RID: 487 RVA: 0x0000BB08 File Offset: 0x00009D08
		// (set) Token: 0x060001E8 RID: 488 RVA: 0x00002BF4 File Offset: 0x00000DF4
		public unsafe string unit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentRangeHeaderValue.NativeFieldInfoPtr_unit);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentRangeHeaderValue.NativeFieldInfoPtr_unit), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060001E9 RID: 489 RVA: 0x0000BB30 File Offset: 0x00009D30
		// (set) Token: 0x060001EA RID: 490 RVA: 0x00002C13 File Offset: 0x00000E13
		public Nullable<long> _From_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentRangeHeaderValue.NativeFieldInfoPtr__From_k__BackingField);
				return new Nullable<long>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<long>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentRangeHeaderValue.NativeFieldInfoPtr__From_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<long>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060001EB RID: 491 RVA: 0x0000BB60 File Offset: 0x00009D60
		// (set) Token: 0x060001EC RID: 492 RVA: 0x00002C41 File Offset: 0x00000E41
		public Nullable<long> _Length_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentRangeHeaderValue.NativeFieldInfoPtr__Length_k__BackingField);
				return new Nullable<long>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<long>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentRangeHeaderValue.NativeFieldInfoPtr__Length_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<long>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060001ED RID: 493 RVA: 0x0000BB90 File Offset: 0x00009D90
		// (set) Token: 0x060001EE RID: 494 RVA: 0x00002C6F File Offset: 0x00000E6F
		public Nullable<long> _To_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentRangeHeaderValue.NativeFieldInfoPtr__To_k__BackingField);
				return new Nullable<long>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<long>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentRangeHeaderValue.NativeFieldInfoPtr__To_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<long>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x0400014D RID: 333
		private static readonly IntPtr NativeFieldInfoPtr_unit;

		// Token: 0x0400014E RID: 334
		private static readonly IntPtr NativeFieldInfoPtr__From_k__BackingField;

		// Token: 0x0400014F RID: 335
		private static readonly IntPtr NativeFieldInfoPtr__Length_k__BackingField;

		// Token: 0x04000150 RID: 336
		private static readonly IntPtr NativeFieldInfoPtr__To_k__BackingField;

		// Token: 0x04000151 RID: 337
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04000152 RID: 338
		private static readonly IntPtr NativeMethodInfoPtr_get_From_Public_get_Nullable_1_Int64_0;

		// Token: 0x04000153 RID: 339
		private static readonly IntPtr NativeMethodInfoPtr_set_From_Private_set_Void_Nullable_1_Int64_0;

		// Token: 0x04000154 RID: 340
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_get_Nullable_1_Int64_0;

		// Token: 0x04000155 RID: 341
		private static readonly IntPtr NativeMethodInfoPtr_set_Length_Private_set_Void_Nullable_1_Int64_0;

		// Token: 0x04000156 RID: 342
		private static readonly IntPtr NativeMethodInfoPtr_get_To_Public_get_Nullable_1_Int64_0;

		// Token: 0x04000157 RID: 343
		private static readonly IntPtr NativeMethodInfoPtr_set_To_Private_set_Void_Nullable_1_Int64_0;

		// Token: 0x04000158 RID: 344
		private static readonly IntPtr NativeMethodInfoPtr_get_Unit_Public_get_String_0;

		// Token: 0x04000159 RID: 345
		private static readonly IntPtr NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0;

		// Token: 0x0400015A RID: 346
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400015B RID: 347
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400015C RID: 348
		private static readonly IntPtr NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_ContentRangeHeaderValue_0;

		// Token: 0x0400015D RID: 349
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
