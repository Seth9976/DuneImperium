using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x020000AF RID: 175
	public class GenerateHLSL : Attribute
	{
		// Token: 0x06000C73 RID: 3187 RVA: 0x0003A180 File Offset: 0x00038380
		// Note: this type is marked as 'beforefieldinit'.
		static GenerateHLSL()
		{
			Il2CppClassPointerStore<GenerateHLSL>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "GenerateHLSL");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenerateHLSL>.NativeClassPtr);
			GenerateHLSL.NativeFieldInfoPtr_packingRules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateHLSL>.NativeClassPtr, "packingRules");
			GenerateHLSL.NativeFieldInfoPtr_containsPackedFields = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateHLSL>.NativeClassPtr, "containsPackedFields");
			GenerateHLSL.NativeFieldInfoPtr_needAccessors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateHLSL>.NativeClassPtr, "needAccessors");
			GenerateHLSL.NativeFieldInfoPtr_needSetters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateHLSL>.NativeClassPtr, "needSetters");
			GenerateHLSL.NativeFieldInfoPtr_needParamDebug = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateHLSL>.NativeClassPtr, "needParamDebug");
			GenerateHLSL.NativeFieldInfoPtr_paramDefinesStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateHLSL>.NativeClassPtr, "paramDefinesStart");
			GenerateHLSL.NativeFieldInfoPtr_omitStructDeclaration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateHLSL>.NativeClassPtr, "omitStructDeclaration");
			GenerateHLSL.NativeFieldInfoPtr_generateCBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateHLSL>.NativeClassPtr, "generateCBuffer");
			GenerateHLSL.NativeFieldInfoPtr_constantRegister = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateHLSL>.NativeClassPtr, "constantRegister");
			GenerateHLSL.NativeFieldInfoPtr_sourcePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateHLSL>.NativeClassPtr, "sourcePath");
			GenerateHLSL.NativeMethodInfoPtr__ctor_Public_Void_PackingRules_Boolean_Boolean_Boolean_Int32_Boolean_Boolean_Boolean_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenerateHLSL>.NativeClassPtr, 100665121);
		}

		// Token: 0x06000C74 RID: 3188 RVA: 0x0003A28C File Offset: 0x0003848C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971635, XrefRangeEnd = 971637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GenerateHLSL(PackingRules rules = PackingRules.Exact, bool needAccessors = true, bool needSetters = false, bool needParamDebug = false, int paramDefinesStart = 1, bool omitStructDeclaration = false, bool containsPackedFields = false, bool generateCBuffer = false, int constantRegister = -1, string sourcePath = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenerateHLSL>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rules;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref needAccessors;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref needSetters;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref needParamDebug;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref paramDefinesStart;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref omitStructDeclaration;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref containsPackedFields;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref generateCBuffer;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref constantRegister;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sourcePath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenerateHLSL.NativeMethodInfoPtr__ctor_Public_Void_PackingRules_Boolean_Boolean_Boolean_Int32_Boolean_Boolean_Boolean_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C75 RID: 3189 RVA: 0x00007722 File Offset: 0x00005922
		public GenerateHLSL(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06000C76 RID: 3190 RVA: 0x0003A358 File Offset: 0x00038558
		// (set) Token: 0x06000C77 RID: 3191 RVA: 0x0000772B File Offset: 0x0000592B
		public unsafe PackingRules packingRules
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateHLSL.NativeFieldInfoPtr_packingRules);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateHLSL.NativeFieldInfoPtr_packingRules)) = value;
			}
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06000C78 RID: 3192 RVA: 0x0003A380 File Offset: 0x00038580
		// (set) Token: 0x06000C79 RID: 3193 RVA: 0x00007746 File Offset: 0x00005946
		public unsafe bool containsPackedFields
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateHLSL.NativeFieldInfoPtr_containsPackedFields);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateHLSL.NativeFieldInfoPtr_containsPackedFields)) = value;
			}
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06000C7A RID: 3194 RVA: 0x0003A3A8 File Offset: 0x000385A8
		// (set) Token: 0x06000C7B RID: 3195 RVA: 0x00007761 File Offset: 0x00005961
		public unsafe bool needAccessors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateHLSL.NativeFieldInfoPtr_needAccessors);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateHLSL.NativeFieldInfoPtr_needAccessors)) = value;
			}
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06000C7C RID: 3196 RVA: 0x0003A3D0 File Offset: 0x000385D0
		// (set) Token: 0x06000C7D RID: 3197 RVA: 0x0000777C File Offset: 0x0000597C
		public unsafe bool needSetters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateHLSL.NativeFieldInfoPtr_needSetters);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateHLSL.NativeFieldInfoPtr_needSetters)) = value;
			}
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06000C7E RID: 3198 RVA: 0x0003A3F8 File Offset: 0x000385F8
		// (set) Token: 0x06000C7F RID: 3199 RVA: 0x00007797 File Offset: 0x00005997
		public unsafe bool needParamDebug
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateHLSL.NativeFieldInfoPtr_needParamDebug);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateHLSL.NativeFieldInfoPtr_needParamDebug)) = value;
			}
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06000C80 RID: 3200 RVA: 0x0003A420 File Offset: 0x00038620
		// (set) Token: 0x06000C81 RID: 3201 RVA: 0x000077B2 File Offset: 0x000059B2
		public unsafe int paramDefinesStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateHLSL.NativeFieldInfoPtr_paramDefinesStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateHLSL.NativeFieldInfoPtr_paramDefinesStart)) = value;
			}
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06000C82 RID: 3202 RVA: 0x0003A448 File Offset: 0x00038648
		// (set) Token: 0x06000C83 RID: 3203 RVA: 0x000077CD File Offset: 0x000059CD
		public unsafe bool omitStructDeclaration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateHLSL.NativeFieldInfoPtr_omitStructDeclaration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateHLSL.NativeFieldInfoPtr_omitStructDeclaration)) = value;
			}
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06000C84 RID: 3204 RVA: 0x0003A470 File Offset: 0x00038670
		// (set) Token: 0x06000C85 RID: 3205 RVA: 0x000077E8 File Offset: 0x000059E8
		public unsafe bool generateCBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateHLSL.NativeFieldInfoPtr_generateCBuffer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateHLSL.NativeFieldInfoPtr_generateCBuffer)) = value;
			}
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06000C86 RID: 3206 RVA: 0x0003A498 File Offset: 0x00038698
		// (set) Token: 0x06000C87 RID: 3207 RVA: 0x00007803 File Offset: 0x00005A03
		public unsafe int constantRegister
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateHLSL.NativeFieldInfoPtr_constantRegister);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateHLSL.NativeFieldInfoPtr_constantRegister)) = value;
			}
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06000C88 RID: 3208 RVA: 0x0003A4C0 File Offset: 0x000386C0
		// (set) Token: 0x06000C89 RID: 3209 RVA: 0x0000781E File Offset: 0x00005A1E
		public unsafe string sourcePath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateHLSL.NativeFieldInfoPtr_sourcePath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenerateHLSL.NativeFieldInfoPtr_sourcePath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400095E RID: 2398
		private static readonly IntPtr NativeFieldInfoPtr_packingRules;

		// Token: 0x0400095F RID: 2399
		private static readonly IntPtr NativeFieldInfoPtr_containsPackedFields;

		// Token: 0x04000960 RID: 2400
		private static readonly IntPtr NativeFieldInfoPtr_needAccessors;

		// Token: 0x04000961 RID: 2401
		private static readonly IntPtr NativeFieldInfoPtr_needSetters;

		// Token: 0x04000962 RID: 2402
		private static readonly IntPtr NativeFieldInfoPtr_needParamDebug;

		// Token: 0x04000963 RID: 2403
		private static readonly IntPtr NativeFieldInfoPtr_paramDefinesStart;

		// Token: 0x04000964 RID: 2404
		private static readonly IntPtr NativeFieldInfoPtr_omitStructDeclaration;

		// Token: 0x04000965 RID: 2405
		private static readonly IntPtr NativeFieldInfoPtr_generateCBuffer;

		// Token: 0x04000966 RID: 2406
		private static readonly IntPtr NativeFieldInfoPtr_constantRegister;

		// Token: 0x04000967 RID: 2407
		private static readonly IntPtr NativeFieldInfoPtr_sourcePath;

		// Token: 0x04000968 RID: 2408
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_PackingRules_Boolean_Boolean_Boolean_Int32_Boolean_Boolean_Boolean_Int32_String_0;
	}
}
