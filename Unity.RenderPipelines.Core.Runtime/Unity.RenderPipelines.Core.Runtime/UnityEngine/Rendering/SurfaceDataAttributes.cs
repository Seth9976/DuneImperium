using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x020000B0 RID: 176
	public class SurfaceDataAttributes : Attribute
	{
		// Token: 0x06000C8A RID: 3210 RVA: 0x0003A4E8 File Offset: 0x000386E8
		// Note: this type is marked as 'beforefieldinit'.
		static SurfaceDataAttributes()
		{
			Il2CppClassPointerStore<SurfaceDataAttributes>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "SurfaceDataAttributes");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SurfaceDataAttributes>.NativeClassPtr);
			SurfaceDataAttributes.NativeFieldInfoPtr_displayNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurfaceDataAttributes>.NativeClassPtr, "displayNames");
			SurfaceDataAttributes.NativeFieldInfoPtr_isDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurfaceDataAttributes>.NativeClassPtr, "isDirection");
			SurfaceDataAttributes.NativeFieldInfoPtr_sRGBDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurfaceDataAttributes>.NativeClassPtr, "sRGBDisplay");
			SurfaceDataAttributes.NativeFieldInfoPtr_precision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurfaceDataAttributes>.NativeClassPtr, "precision");
			SurfaceDataAttributes.NativeFieldInfoPtr_checkIsNormalized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurfaceDataAttributes>.NativeClassPtr, "checkIsNormalized");
			SurfaceDataAttributes.NativeFieldInfoPtr_preprocessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurfaceDataAttributes>.NativeClassPtr, "preprocessor");
			SurfaceDataAttributes.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Boolean_FieldPrecision_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceDataAttributes>.NativeClassPtr, 100665122);
			SurfaceDataAttributes.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_Boolean_Boolean_FieldPrecision_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceDataAttributes>.NativeClassPtr, 100665123);
		}

		// Token: 0x06000C8B RID: 3211 RVA: 0x0003A5B8 File Offset: 0x000387B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971637, XrefRangeEnd = 971646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SurfaceDataAttributes(string displayName = "", bool isDirection = false, bool sRGBDisplay = false, FieldPrecision precision = FieldPrecision.Default, bool checkIsNormalized = false, string preprocessor = "")
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SurfaceDataAttributes>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(displayName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isDirection;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sRGBDisplay;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref precision;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkIsNormalized;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(preprocessor);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceDataAttributes.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Boolean_FieldPrecision_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C8C RID: 3212 RVA: 0x0003A650 File Offset: 0x00038850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971646, XrefRangeEnd = 971649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SurfaceDataAttributes(Il2CppStringArray displayNames, bool isDirection = false, bool sRGBDisplay = false, FieldPrecision precision = FieldPrecision.Default, bool checkIsNormalized = false, string preprocessor = "")
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SurfaceDataAttributes>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(displayNames);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isDirection;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sRGBDisplay;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref precision;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkIsNormalized;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(preprocessor);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceDataAttributes.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_Boolean_Boolean_FieldPrecision_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C8D RID: 3213 RVA: 0x0000783D File Offset: 0x00005A3D
		public SurfaceDataAttributes(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06000C8E RID: 3214 RVA: 0x0003A6E8 File Offset: 0x000388E8
		// (set) Token: 0x06000C8F RID: 3215 RVA: 0x00007846 File Offset: 0x00005A46
		public unsafe Il2CppStringArray displayNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceDataAttributes.NativeFieldInfoPtr_displayNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceDataAttributes.NativeFieldInfoPtr_displayNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06000C90 RID: 3216 RVA: 0x0003A718 File Offset: 0x00038918
		// (set) Token: 0x06000C91 RID: 3217 RVA: 0x00007865 File Offset: 0x00005A65
		public unsafe bool isDirection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceDataAttributes.NativeFieldInfoPtr_isDirection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceDataAttributes.NativeFieldInfoPtr_isDirection)) = value;
			}
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06000C92 RID: 3218 RVA: 0x0003A740 File Offset: 0x00038940
		// (set) Token: 0x06000C93 RID: 3219 RVA: 0x00007880 File Offset: 0x00005A80
		public unsafe bool sRGBDisplay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceDataAttributes.NativeFieldInfoPtr_sRGBDisplay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceDataAttributes.NativeFieldInfoPtr_sRGBDisplay)) = value;
			}
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06000C94 RID: 3220 RVA: 0x0003A768 File Offset: 0x00038968
		// (set) Token: 0x06000C95 RID: 3221 RVA: 0x0000789B File Offset: 0x00005A9B
		public unsafe FieldPrecision precision
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceDataAttributes.NativeFieldInfoPtr_precision);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceDataAttributes.NativeFieldInfoPtr_precision)) = value;
			}
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06000C96 RID: 3222 RVA: 0x0003A790 File Offset: 0x00038990
		// (set) Token: 0x06000C97 RID: 3223 RVA: 0x000078B6 File Offset: 0x00005AB6
		public unsafe bool checkIsNormalized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceDataAttributes.NativeFieldInfoPtr_checkIsNormalized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceDataAttributes.NativeFieldInfoPtr_checkIsNormalized)) = value;
			}
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06000C98 RID: 3224 RVA: 0x0003A7B8 File Offset: 0x000389B8
		// (set) Token: 0x06000C99 RID: 3225 RVA: 0x000078D1 File Offset: 0x00005AD1
		public unsafe string preprocessor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceDataAttributes.NativeFieldInfoPtr_preprocessor);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceDataAttributes.NativeFieldInfoPtr_preprocessor), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000969 RID: 2409
		private static readonly IntPtr NativeFieldInfoPtr_displayNames;

		// Token: 0x0400096A RID: 2410
		private static readonly IntPtr NativeFieldInfoPtr_isDirection;

		// Token: 0x0400096B RID: 2411
		private static readonly IntPtr NativeFieldInfoPtr_sRGBDisplay;

		// Token: 0x0400096C RID: 2412
		private static readonly IntPtr NativeFieldInfoPtr_precision;

		// Token: 0x0400096D RID: 2413
		private static readonly IntPtr NativeFieldInfoPtr_checkIsNormalized;

		// Token: 0x0400096E RID: 2414
		private static readonly IntPtr NativeFieldInfoPtr_preprocessor;

		// Token: 0x0400096F RID: 2415
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Boolean_FieldPrecision_Boolean_String_0;

		// Token: 0x04000970 RID: 2416
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_Boolean_Boolean_FieldPrecision_Boolean_String_0;
	}
}
