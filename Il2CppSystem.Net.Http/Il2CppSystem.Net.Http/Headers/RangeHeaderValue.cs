using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Net.Http.Headers
{
	// Token: 0x02000033 RID: 51
	public class RangeHeaderValue : Object
	{
		// Token: 0x06000333 RID: 819 RVA: 0x00011978 File Offset: 0x0000FB78
		// Note: this type is marked as 'beforefieldinit'.
		static RangeHeaderValue()
		{
			Il2CppClassPointerStore<RangeHeaderValue>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Net.Http.dll", "System.Net.Http.Headers", "RangeHeaderValue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RangeHeaderValue>.NativeClassPtr);
			RangeHeaderValue.NativeFieldInfoPtr_ranges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RangeHeaderValue>.NativeClassPtr, "ranges");
			RangeHeaderValue.NativeFieldInfoPtr_unit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RangeHeaderValue>.NativeClassPtr, "unit");
			RangeHeaderValue.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RangeHeaderValue>.NativeClassPtr, 100663838);
			RangeHeaderValue.NativeMethodInfoPtr__ctor_Private_Void_RangeHeaderValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RangeHeaderValue>.NativeClassPtr, 100663839);
			RangeHeaderValue.NativeMethodInfoPtr_get_Ranges_Public_get_ICollection_1_RangeItemHeaderValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RangeHeaderValue>.NativeClassPtr, 100663840);
			RangeHeaderValue.NativeMethodInfoPtr_get_Unit_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RangeHeaderValue>.NativeClassPtr, 100663841);
			RangeHeaderValue.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RangeHeaderValue>.NativeClassPtr, 100663842);
			RangeHeaderValue.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RangeHeaderValue>.NativeClassPtr, 100663843);
			RangeHeaderValue.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RangeHeaderValue>.NativeClassPtr, 100663844);
			RangeHeaderValue.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_RangeHeaderValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RangeHeaderValue>.NativeClassPtr, 100663845);
			RangeHeaderValue.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RangeHeaderValue>.NativeClassPtr, 100663846);
		}

		// Token: 0x06000334 RID: 820 RVA: 0x00011A84 File Offset: 0x0000FC84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1175633, XrefRangeEnd = 1175638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RangeHeaderValue()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RangeHeaderValue>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RangeHeaderValue.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000335 RID: 821 RVA: 0x00011AC0 File Offset: 0x0000FCC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1175668, RefRangeEnd = 1175669, XrefRangeStart = 1175638, XrefRangeEnd = 1175668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RangeHeaderValue(RangeHeaderValue source)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RangeHeaderValue>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RangeHeaderValue.NativeMethodInfoPtr__ctor_Private_Void_RangeHeaderValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000336 RID: 822 RVA: 0x00011B0C File Offset: 0x0000FD0C
		public unsafe ICollection<RangeItemHeaderValue> Ranges
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1175669, XrefRangeEnd = 1175676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RangeHeaderValue.NativeMethodInfoPtr_get_Ranges_Public_get_ICollection_1_RangeItemHeaderValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection<RangeItemHeaderValue>>(intPtr3) : null;
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000337 RID: 823 RVA: 0x00011B4C File Offset: 0x0000FD4C
		public unsafe string Unit
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RangeHeaderValue.NativeMethodInfoPtr_get_Unit_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000338 RID: 824 RVA: 0x00011B84 File Offset: 0x0000FD84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1175676, XrefRangeEnd = 1175680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object System_ICloneable_Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RangeHeaderValue.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000339 RID: 825 RVA: 0x00011BC4 File Offset: 0x0000FDC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1175680, XrefRangeEnd = 1175687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RangeHeaderValue.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600033A RID: 826 RVA: 0x00011C1C File Offset: 0x0000FE1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1175687, XrefRangeEnd = 1175691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RangeHeaderValue.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600033B RID: 827 RVA: 0x00011C64 File Offset: 0x0000FE64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1175691, XrefRangeEnd = 1175759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParse(string input, out RangeHeaderValue parsedValue)
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RangeHeaderValue.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_RangeHeaderValue_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			parsedValue = ((intPtr4 == 0) ? null : new RangeHeaderValue(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600033C RID: 828 RVA: 0x00011CC8 File Offset: 0x0000FEC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1175759, XrefRangeEnd = 1175786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RangeHeaderValue.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600033D RID: 829 RVA: 0x000031C7 File Offset: 0x000013C7
		public RangeHeaderValue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x0600033E RID: 830 RVA: 0x00011D0C File Offset: 0x0000FF0C
		// (set) Token: 0x0600033F RID: 831 RVA: 0x000031D0 File Offset: 0x000013D0
		public unsafe List<RangeItemHeaderValue> ranges
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RangeHeaderValue.NativeFieldInfoPtr_ranges);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RangeItemHeaderValue>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RangeHeaderValue.NativeFieldInfoPtr_ranges), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000340 RID: 832 RVA: 0x00011D3C File Offset: 0x0000FF3C
		// (set) Token: 0x06000341 RID: 833 RVA: 0x000031EF File Offset: 0x000013EF
		public unsafe string unit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RangeHeaderValue.NativeFieldInfoPtr_unit);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RangeHeaderValue.NativeFieldInfoPtr_unit), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000262 RID: 610
		private static readonly IntPtr NativeFieldInfoPtr_ranges;

		// Token: 0x04000263 RID: 611
		private static readonly IntPtr NativeFieldInfoPtr_unit;

		// Token: 0x04000264 RID: 612
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000265 RID: 613
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_RangeHeaderValue_0;

		// Token: 0x04000266 RID: 614
		private static readonly IntPtr NativeMethodInfoPtr_get_Ranges_Public_get_ICollection_1_RangeItemHeaderValue_0;

		// Token: 0x04000267 RID: 615
		private static readonly IntPtr NativeMethodInfoPtr_get_Unit_Public_get_String_0;

		// Token: 0x04000268 RID: 616
		private static readonly IntPtr NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0;

		// Token: 0x04000269 RID: 617
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400026A RID: 618
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400026B RID: 619
		private static readonly IntPtr NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_RangeHeaderValue_0;

		// Token: 0x0400026C RID: 620
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
