using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net.Http.Headers
{
	// Token: 0x02000034 RID: 52
	public class RangeItemHeaderValue : Object
	{
		// Token: 0x06000342 RID: 834 RVA: 0x00011D64 File Offset: 0x0000FF64
		// Note: this type is marked as 'beforefieldinit'.
		static RangeItemHeaderValue()
		{
			Il2CppClassPointerStore<RangeItemHeaderValue>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Net.Http.dll", "System.Net.Http.Headers", "RangeItemHeaderValue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RangeItemHeaderValue>.NativeClassPtr);
			RangeItemHeaderValue.NativeFieldInfoPtr__From_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RangeItemHeaderValue>.NativeClassPtr, "<From>k__BackingField");
			RangeItemHeaderValue.NativeFieldInfoPtr__To_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RangeItemHeaderValue>.NativeClassPtr, "<To>k__BackingField");
			RangeItemHeaderValue.NativeMethodInfoPtr__ctor_Public_Void_Nullable_1_Int64_Nullable_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RangeItemHeaderValue>.NativeClassPtr, 100663847);
			RangeItemHeaderValue.NativeMethodInfoPtr_get_From_Public_get_Nullable_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RangeItemHeaderValue>.NativeClassPtr, 100663848);
			RangeItemHeaderValue.NativeMethodInfoPtr_set_From_Private_set_Void_Nullable_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RangeItemHeaderValue>.NativeClassPtr, 100663849);
			RangeItemHeaderValue.NativeMethodInfoPtr_get_To_Public_get_Nullable_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RangeItemHeaderValue>.NativeClassPtr, 100663850);
			RangeItemHeaderValue.NativeMethodInfoPtr_set_To_Private_set_Void_Nullable_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RangeItemHeaderValue>.NativeClassPtr, 100663851);
			RangeItemHeaderValue.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RangeItemHeaderValue>.NativeClassPtr, 100663852);
			RangeItemHeaderValue.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RangeItemHeaderValue>.NativeClassPtr, 100663853);
			RangeItemHeaderValue.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RangeItemHeaderValue>.NativeClassPtr, 100663854);
			RangeItemHeaderValue.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RangeItemHeaderValue>.NativeClassPtr, 100663855);
		}

		// Token: 0x06000343 RID: 835 RVA: 0x00011E70 File Offset: 0x00010070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1175786, XrefRangeEnd = 1175790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RangeItemHeaderValue(Nullable<long> from, Nullable<long> to)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RangeItemHeaderValue>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(from));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(to));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RangeItemHeaderValue.NativeMethodInfoPtr__ctor_Public_Void_Nullable_1_Int64_Nullable_1_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000344 RID: 836 RVA: 0x00011ED8 File Offset: 0x000100D8
		// (set) Token: 0x06000345 RID: 837 RVA: 0x00011F10 File Offset: 0x00010110
		public unsafe Nullable<long> From
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RangeItemHeaderValue.NativeMethodInfoPtr_get_From_Public_get_Nullable_1_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RangeItemHeaderValue.NativeMethodInfoPtr_set_From_Private_set_Void_Nullable_1_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000346 RID: 838 RVA: 0x00011F58 File Offset: 0x00010158
		// (set) Token: 0x06000347 RID: 839 RVA: 0x00011F90 File Offset: 0x00010190
		public unsafe Nullable<long> To
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RangeItemHeaderValue.NativeMethodInfoPtr_get_To_Public_get_Nullable_1_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RangeItemHeaderValue.NativeMethodInfoPtr_set_To_Private_set_Void_Nullable_1_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000348 RID: 840 RVA: 0x00011FD8 File Offset: 0x000101D8
		[CallerCount(105)]
		[CachedScanResults(RefRangeStart = 1172447, RefRangeEnd = 1172552, XrefRangeStart = 1172447, XrefRangeEnd = 1172552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object System_ICloneable_Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RangeItemHeaderValue.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000349 RID: 841 RVA: 0x00012018 File Offset: 0x00010218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1175790, XrefRangeEnd = 1175795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RangeItemHeaderValue.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600034A RID: 842 RVA: 0x00012070 File Offset: 0x00010270
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1175795, XrefRangeEnd = 1175800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RangeItemHeaderValue.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600034B RID: 843 RVA: 0x000120B8 File Offset: 0x000102B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1175800, XrefRangeEnd = 1175811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RangeItemHeaderValue.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600034C RID: 844 RVA: 0x0000320E File Offset: 0x0000140E
		public RangeItemHeaderValue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x0600034D RID: 845 RVA: 0x000120FC File Offset: 0x000102FC
		// (set) Token: 0x0600034E RID: 846 RVA: 0x00003217 File Offset: 0x00001417
		public Nullable<long> _From_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RangeItemHeaderValue.NativeFieldInfoPtr__From_k__BackingField);
				return new Nullable<long>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<long>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RangeItemHeaderValue.NativeFieldInfoPtr__From_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<long>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x0600034F RID: 847 RVA: 0x0001212C File Offset: 0x0001032C
		// (set) Token: 0x06000350 RID: 848 RVA: 0x00003245 File Offset: 0x00001445
		public Nullable<long> _To_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RangeItemHeaderValue.NativeFieldInfoPtr__To_k__BackingField);
				return new Nullable<long>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<long>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RangeItemHeaderValue.NativeFieldInfoPtr__To_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<long>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x0400026D RID: 621
		private static readonly IntPtr NativeFieldInfoPtr__From_k__BackingField;

		// Token: 0x0400026E RID: 622
		private static readonly IntPtr NativeFieldInfoPtr__To_k__BackingField;

		// Token: 0x0400026F RID: 623
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Nullable_1_Int64_Nullable_1_Int64_0;

		// Token: 0x04000270 RID: 624
		private static readonly IntPtr NativeMethodInfoPtr_get_From_Public_get_Nullable_1_Int64_0;

		// Token: 0x04000271 RID: 625
		private static readonly IntPtr NativeMethodInfoPtr_set_From_Private_set_Void_Nullable_1_Int64_0;

		// Token: 0x04000272 RID: 626
		private static readonly IntPtr NativeMethodInfoPtr_get_To_Public_get_Nullable_1_Int64_0;

		// Token: 0x04000273 RID: 627
		private static readonly IntPtr NativeMethodInfoPtr_set_To_Private_set_Void_Nullable_1_Int64_0;

		// Token: 0x04000274 RID: 628
		private static readonly IntPtr NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0;

		// Token: 0x04000275 RID: 629
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000276 RID: 630
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000277 RID: 631
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
