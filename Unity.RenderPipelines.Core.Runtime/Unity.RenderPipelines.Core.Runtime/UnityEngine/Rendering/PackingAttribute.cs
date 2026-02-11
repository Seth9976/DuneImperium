using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x020000B2 RID: 178
	public class PackingAttribute : Attribute
	{
		// Token: 0x06000CA1 RID: 3233 RVA: 0x0003A900 File Offset: 0x00038B00
		// Note: this type is marked as 'beforefieldinit'.
		static PackingAttribute()
		{
			Il2CppClassPointerStore<PackingAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "PackingAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackingAttribute>.NativeClassPtr);
			PackingAttribute.NativeFieldInfoPtr_displayNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackingAttribute>.NativeClassPtr, "displayNames");
			PackingAttribute.NativeFieldInfoPtr_range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackingAttribute>.NativeClassPtr, "range");
			PackingAttribute.NativeFieldInfoPtr_packingScheme = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackingAttribute>.NativeClassPtr, "packingScheme");
			PackingAttribute.NativeFieldInfoPtr_offsetInSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackingAttribute>.NativeClassPtr, "offsetInSource");
			PackingAttribute.NativeFieldInfoPtr_sizeInBits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackingAttribute>.NativeClassPtr, "sizeInBits");
			PackingAttribute.NativeFieldInfoPtr_isDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackingAttribute>.NativeClassPtr, "isDirection");
			PackingAttribute.NativeFieldInfoPtr_sRGBDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackingAttribute>.NativeClassPtr, "sRGBDisplay");
			PackingAttribute.NativeFieldInfoPtr_checkIsNormalized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackingAttribute>.NativeClassPtr, "checkIsNormalized");
			PackingAttribute.NativeFieldInfoPtr_preprocessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackingAttribute>.NativeClassPtr, "preprocessor");
			PackingAttribute.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_FieldPacking_Int32_Int32_Single_Single_Boolean_Boolean_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackingAttribute>.NativeClassPtr, 100665125);
			PackingAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_FieldPacking_Int32_Int32_Single_Single_Boolean_Boolean_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackingAttribute>.NativeClassPtr, 100665126);
		}

		// Token: 0x06000CA2 RID: 3234 RVA: 0x0003AA0C File Offset: 0x00038C0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971655, XrefRangeEnd = 971664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PackingAttribute(Il2CppStringArray displayNames, FieldPacking packingScheme = FieldPacking.NoPacking, int bitSize = 32, int offsetInSource = 0, float minValue = 0f, float maxValue = 1f, bool isDirection = false, bool sRGBDisplay = false, bool checkIsNormalized = false, string preprocessor = "")
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackingAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(displayNames);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref packingScheme;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bitSize;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offsetInSource;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minValue;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxValue;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isDirection;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sRGBDisplay;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkIsNormalized;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(preprocessor);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackingAttribute.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_FieldPacking_Int32_Int32_Single_Single_Boolean_Boolean_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CA3 RID: 3235 RVA: 0x0003AADC File Offset: 0x00038CDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971664, XrefRangeEnd = 971677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PackingAttribute(string displayName = "", FieldPacking packingScheme = FieldPacking.NoPacking, int bitSize = 0, int offsetInSource = 0, float minValue = 0f, float maxValue = 1f, bool isDirection = false, bool sRGBDisplay = false, bool checkIsNormalized = false, string preprocessor = "")
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackingAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(displayName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref packingScheme;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bitSize;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offsetInSource;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minValue;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxValue;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isDirection;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sRGBDisplay;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkIsNormalized;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(preprocessor);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackingAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_FieldPacking_Int32_Int32_Single_Single_Boolean_Boolean_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CA4 RID: 3236 RVA: 0x00007933 File Offset: 0x00005B33
		public PackingAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06000CA5 RID: 3237 RVA: 0x0003ABAC File Offset: 0x00038DAC
		// (set) Token: 0x06000CA6 RID: 3238 RVA: 0x0000793C File Offset: 0x00005B3C
		public unsafe Il2CppStringArray displayNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAttribute.NativeFieldInfoPtr_displayNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAttribute.NativeFieldInfoPtr_displayNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06000CA7 RID: 3239 RVA: 0x0003ABDC File Offset: 0x00038DDC
		// (set) Token: 0x06000CA8 RID: 3240 RVA: 0x0000795B File Offset: 0x00005B5B
		public unsafe Il2CppStructArray<float> range
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAttribute.NativeFieldInfoPtr_range);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAttribute.NativeFieldInfoPtr_range), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06000CA9 RID: 3241 RVA: 0x0003AC0C File Offset: 0x00038E0C
		// (set) Token: 0x06000CAA RID: 3242 RVA: 0x0000797A File Offset: 0x00005B7A
		public unsafe FieldPacking packingScheme
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAttribute.NativeFieldInfoPtr_packingScheme);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAttribute.NativeFieldInfoPtr_packingScheme)) = value;
			}
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06000CAB RID: 3243 RVA: 0x0003AC34 File Offset: 0x00038E34
		// (set) Token: 0x06000CAC RID: 3244 RVA: 0x00007995 File Offset: 0x00005B95
		public unsafe int offsetInSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAttribute.NativeFieldInfoPtr_offsetInSource);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAttribute.NativeFieldInfoPtr_offsetInSource)) = value;
			}
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06000CAD RID: 3245 RVA: 0x0003AC5C File Offset: 0x00038E5C
		// (set) Token: 0x06000CAE RID: 3246 RVA: 0x000079B0 File Offset: 0x00005BB0
		public unsafe int sizeInBits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAttribute.NativeFieldInfoPtr_sizeInBits);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAttribute.NativeFieldInfoPtr_sizeInBits)) = value;
			}
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06000CAF RID: 3247 RVA: 0x0003AC84 File Offset: 0x00038E84
		// (set) Token: 0x06000CB0 RID: 3248 RVA: 0x000079CB File Offset: 0x00005BCB
		public unsafe bool isDirection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAttribute.NativeFieldInfoPtr_isDirection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAttribute.NativeFieldInfoPtr_isDirection)) = value;
			}
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06000CB1 RID: 3249 RVA: 0x0003ACAC File Offset: 0x00038EAC
		// (set) Token: 0x06000CB2 RID: 3250 RVA: 0x000079E6 File Offset: 0x00005BE6
		public unsafe bool sRGBDisplay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAttribute.NativeFieldInfoPtr_sRGBDisplay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAttribute.NativeFieldInfoPtr_sRGBDisplay)) = value;
			}
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06000CB3 RID: 3251 RVA: 0x0003ACD4 File Offset: 0x00038ED4
		// (set) Token: 0x06000CB4 RID: 3252 RVA: 0x00007A01 File Offset: 0x00005C01
		public unsafe bool checkIsNormalized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAttribute.NativeFieldInfoPtr_checkIsNormalized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAttribute.NativeFieldInfoPtr_checkIsNormalized)) = value;
			}
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x06000CB5 RID: 3253 RVA: 0x0003ACFC File Offset: 0x00038EFC
		// (set) Token: 0x06000CB6 RID: 3254 RVA: 0x00007A1C File Offset: 0x00005C1C
		public unsafe string preprocessor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAttribute.NativeFieldInfoPtr_preprocessor);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackingAttribute.NativeFieldInfoPtr_preprocessor), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000974 RID: 2420
		private static readonly IntPtr NativeFieldInfoPtr_displayNames;

		// Token: 0x04000975 RID: 2421
		private static readonly IntPtr NativeFieldInfoPtr_range;

		// Token: 0x04000976 RID: 2422
		private static readonly IntPtr NativeFieldInfoPtr_packingScheme;

		// Token: 0x04000977 RID: 2423
		private static readonly IntPtr NativeFieldInfoPtr_offsetInSource;

		// Token: 0x04000978 RID: 2424
		private static readonly IntPtr NativeFieldInfoPtr_sizeInBits;

		// Token: 0x04000979 RID: 2425
		private static readonly IntPtr NativeFieldInfoPtr_isDirection;

		// Token: 0x0400097A RID: 2426
		private static readonly IntPtr NativeFieldInfoPtr_sRGBDisplay;

		// Token: 0x0400097B RID: 2427
		private static readonly IntPtr NativeFieldInfoPtr_checkIsNormalized;

		// Token: 0x0400097C RID: 2428
		private static readonly IntPtr NativeFieldInfoPtr_preprocessor;

		// Token: 0x0400097D RID: 2429
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_FieldPacking_Int32_Int32_Single_Single_Boolean_Boolean_Boolean_String_0;

		// Token: 0x0400097E RID: 2430
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_FieldPacking_Int32_Int32_Single_Single_Boolean_Boolean_Boolean_String_0;
	}
}
