using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Bindings
{
	// Token: 0x02000013 RID: 19
	public class NativeTypeAttribute : Attribute
	{
		// Token: 0x0600007A RID: 122 RVA: 0x00003B48 File Offset: 0x00001D48
		// Note: this type is marked as 'beforefieldinit'.
		static NativeTypeAttribute()
		{
			Il2CppClassPointerStore<NativeTypeAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SharedInternalsModule.dll", "UnityEngine.Bindings", "NativeTypeAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeTypeAttribute>.NativeClassPtr);
			NativeTypeAttribute.NativeFieldInfoPtr__Header_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeTypeAttribute>.NativeClassPtr, "<Header>k__BackingField");
			NativeTypeAttribute.NativeFieldInfoPtr__IntermediateScriptingStructName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeTypeAttribute>.NativeClassPtr, "<IntermediateScriptingStructName>k__BackingField");
			NativeTypeAttribute.NativeFieldInfoPtr__CodegenOptions_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeTypeAttribute>.NativeClassPtr, "<CodegenOptions>k__BackingField");
			NativeTypeAttribute.NativeMethodInfoPtr_set_Header_Public_Virtual_Final_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeTypeAttribute>.NativeClassPtr, 100663335);
			NativeTypeAttribute.NativeMethodInfoPtr_set_IntermediateScriptingStructName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeTypeAttribute>.NativeClassPtr, 100663336);
			NativeTypeAttribute.NativeMethodInfoPtr_set_CodegenOptions_Public_Virtual_Final_New_set_Void_CodegenOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeTypeAttribute>.NativeClassPtr, 100663337);
			NativeTypeAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeTypeAttribute>.NativeClassPtr, 100663338);
			NativeTypeAttribute.NativeMethodInfoPtr__ctor_Public_Void_CodegenOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeTypeAttribute>.NativeClassPtr, 100663339);
			NativeTypeAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeTypeAttribute>.NativeClassPtr, 100663340);
			NativeTypeAttribute.NativeMethodInfoPtr__ctor_Public_Void_CodegenOptions_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeTypeAttribute>.NativeClassPtr, 100663341);
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000089 RID: 137 RVA: 0x00002528 File Offset: 0x00000728
		// (set) Token: 0x0600007B RID: 123 RVA: 0x00003C40 File Offset: 0x00001E40
		public unsafe virtual string Header
		{
			get
			{
				return this._Header_k__BackingField;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeTypeAttribute.NativeMethodInfoPtr_set_Header_Public_Virtual_Final_New_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600008A RID: 138 RVA: 0x00002530 File Offset: 0x00000730
		// (set) Token: 0x0600007C RID: 124 RVA: 0x00003C84 File Offset: 0x00001E84
		public unsafe string IntermediateScriptingStructName
		{
			get
			{
				return this._IntermediateScriptingStructName_k__BackingField;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeTypeAttribute.NativeMethodInfoPtr_set_IntermediateScriptingStructName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600008B RID: 139 RVA: 0x00002538 File Offset: 0x00000738
		// (set) Token: 0x0600007D RID: 125 RVA: 0x00003CC8 File Offset: 0x00001EC8
		public unsafe virtual CodegenOptions CodegenOptions
		{
			get
			{
				return this._CodegenOptions_k__BackingField;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 287294, RefRangeEnd = 287297, XrefRangeStart = 287294, XrefRangeEnd = 287297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeTypeAttribute.NativeMethodInfoPtr_set_CodegenOptions_Public_Virtual_Final_New_set_Void_CodegenOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00003D08 File Offset: 0x00001F08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269106, XrefRangeEnd = 1269107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeTypeAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeTypeAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeTypeAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00003D44 File Offset: 0x00001F44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269107, XrefRangeEnd = 1269108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeTypeAttribute(CodegenOptions codegenOptions)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeTypeAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref codegenOptions;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeTypeAttribute.NativeMethodInfoPtr__ctor_Public_Void_CodegenOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00003D8C File Offset: 0x00001F8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269108, XrefRangeEnd = 1269126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeTypeAttribute(string header)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeTypeAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(header);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeTypeAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00003DD8 File Offset: 0x00001FD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269126, XrefRangeEnd = 1269128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeTypeAttribute(CodegenOptions codegenOptions, string intermediateStructName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeTypeAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref codegenOptions;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(intermediateStructName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeTypeAttribute.NativeMethodInfoPtr__ctor_Public_Void_CodegenOptions_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x000024C6 File Offset: 0x000006C6
		public NativeTypeAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000083 RID: 131 RVA: 0x00003E34 File Offset: 0x00002034
		// (set) Token: 0x06000084 RID: 132 RVA: 0x000024CF File Offset: 0x000006CF
		public unsafe string _Header_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeTypeAttribute.NativeFieldInfoPtr__Header_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeTypeAttribute.NativeFieldInfoPtr__Header_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000085 RID: 133 RVA: 0x00003E5C File Offset: 0x0000205C
		// (set) Token: 0x06000086 RID: 134 RVA: 0x000024EE File Offset: 0x000006EE
		public unsafe string _IntermediateScriptingStructName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeTypeAttribute.NativeFieldInfoPtr__IntermediateScriptingStructName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeTypeAttribute.NativeFieldInfoPtr__IntermediateScriptingStructName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000087 RID: 135 RVA: 0x00003E84 File Offset: 0x00002084
		// (set) Token: 0x06000088 RID: 136 RVA: 0x0000250D File Offset: 0x0000070D
		public unsafe CodegenOptions _CodegenOptions_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeTypeAttribute.NativeFieldInfoPtr__CodegenOptions_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeTypeAttribute.NativeFieldInfoPtr__CodegenOptions_k__BackingField)) = value;
			}
		}

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeFieldInfoPtr__Header_k__BackingField;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeFieldInfoPtr__IntermediateScriptingStructName_k__BackingField;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeFieldInfoPtr__CodegenOptions_k__BackingField;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeMethodInfoPtr_set_Header_Public_Virtual_Final_New_set_Void_String_0;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeMethodInfoPtr_set_IntermediateScriptingStructName_Public_set_Void_String_0;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeMethodInfoPtr_set_CodegenOptions_Public_Virtual_Final_New_set_Void_CodegenOptions_0;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CodegenOptions_0;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CodegenOptions_String_0;
	}
}
