using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppMono
{
	// Token: 0x0200001A RID: 26
	public sealed class SafeStringMarshal : ValueType
	{
		// Token: 0x0600008D RID: 141 RVA: 0x00027ADC File Offset: 0x00025CDC
		// Note: this type is marked as 'beforefieldinit'.
		static SafeStringMarshal()
		{
			Il2CppClassPointerStore<SafeStringMarshal>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono", "SafeStringMarshal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SafeStringMarshal>.NativeClassPtr);
			SafeStringMarshal.NativeFieldInfoPtr_str = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeStringMarshal>.NativeClassPtr, "str");
			SafeStringMarshal.NativeFieldInfoPtr_marshaled_string = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeStringMarshal>.NativeClassPtr, "marshaled_string");
			SafeStringMarshal.NativeMethodInfoPtr_StringToUtf8_icall_Private_Static_IntPtr_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeStringMarshal>.NativeClassPtr, 100663422);
			SafeStringMarshal.NativeMethodInfoPtr_StringToUtf8_Public_Static_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeStringMarshal>.NativeClassPtr, 100663423);
			SafeStringMarshal.NativeMethodInfoPtr_GFree_Public_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeStringMarshal>.NativeClassPtr, 100663424);
			SafeStringMarshal.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeStringMarshal>.NativeClassPtr, 100663425);
			SafeStringMarshal.NativeMethodInfoPtr_get_Value_Public_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeStringMarshal>.NativeClassPtr, 100663426);
			SafeStringMarshal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeStringMarshal>.NativeClassPtr, 100663427);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00027BAC File Offset: 0x00025DAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1276016, XrefRangeEnd = 1276017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr StringToUtf8_icall(ref string str)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(str);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SafeStringMarshal.NativeMethodInfoPtr_StringToUtf8_icall_Private_Static_IntPtr_byref_String_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				str = IL2CPP.Il2CppStringToManaged(intPtr);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00027BFC File Offset: 0x00025DFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1276017, XrefRangeEnd = 1276018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr StringToUtf8(string str)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeStringMarshal.NativeMethodInfoPtr_StringToUtf8_Public_Static_IntPtr_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00027C40 File Offset: 0x00025E40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1276018, XrefRangeEnd = 1276019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GFree(IntPtr ptr)
		{
			checked
			{
				IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeStringMarshal.NativeMethodInfoPtr_GFree_Public_Static_Void_IntPtr_0, 0, (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00027C74 File Offset: 0x00025E74
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1276020, RefRangeEnd = 1276025, XrefRangeStart = 1276019, XrefRangeEnd = 1276020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SafeStringMarshal(string str)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SafeStringMarshal>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeStringMarshal.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000092 RID: 146 RVA: 0x00027CC4 File Offset: 0x00025EC4
		public unsafe IntPtr Value
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 1276027, RefRangeEnd = 1276034, XrefRangeStart = 1276025, XrefRangeEnd = 1276027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeStringMarshal.NativeMethodInfoPtr_get_Value_Public_get_IntPtr_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00027D08 File Offset: 0x00025F08
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1276036, RefRangeEnd = 1276050, XrefRangeStart = 1276034, XrefRangeEnd = 1276036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeStringMarshal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00002324 File Offset: 0x00000524
		public SafeStringMarshal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000095 RID: 149 RVA: 0x0000232D File Offset: 0x0000052D
		public SafeStringMarshal()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SafeStringMarshal>.NativeClassPtr))
		{
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000096 RID: 150 RVA: 0x00027D40 File Offset: 0x00025F40
		// (set) Token: 0x06000097 RID: 151 RVA: 0x0000233F File Offset: 0x0000053F
		public unsafe string str
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeStringMarshal.NativeFieldInfoPtr_str);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeStringMarshal.NativeFieldInfoPtr_str), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000098 RID: 152 RVA: 0x00027D68 File Offset: 0x00025F68
		// (set) Token: 0x06000099 RID: 153 RVA: 0x0000235E File Offset: 0x0000055E
		public unsafe IntPtr marshaled_string
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeStringMarshal.NativeFieldInfoPtr_marshaled_string);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeStringMarshal.NativeFieldInfoPtr_marshaled_string)) = value;
			}
		}

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeFieldInfoPtr_str;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeFieldInfoPtr_marshaled_string;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeMethodInfoPtr_StringToUtf8_icall_Private_Static_IntPtr_byref_String_0;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeMethodInfoPtr_StringToUtf8_Public_Static_IntPtr_String_0;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeMethodInfoPtr_GFree_Public_Static_Void_IntPtr_0;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_IntPtr_0;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
	}
}
