using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200036A RID: 874
	public sealed class TypeInformation : Object
	{
		// Token: 0x0600356D RID: 13677 RVA: 0x00108C74 File Offset: 0x00106E74
		// Note: this type is marked as 'beforefieldinit'.
		static TypeInformation()
		{
			Il2CppClassPointerStore<TypeInformation>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "TypeInformation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeInformation>.NativeClassPtr);
			TypeInformation.NativeFieldInfoPtr_fullTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeInformation>.NativeClassPtr, "fullTypeName");
			TypeInformation.NativeFieldInfoPtr_assemblyString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeInformation>.NativeClassPtr, "assemblyString");
			TypeInformation.NativeFieldInfoPtr_hasTypeForwardedFrom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeInformation>.NativeClassPtr, "hasTypeForwardedFrom");
			TypeInformation.NativeMethodInfoPtr_get_FullTypeName_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeInformation>.NativeClassPtr, 100671438);
			TypeInformation.NativeMethodInfoPtr_get_AssemblyString_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeInformation>.NativeClassPtr, 100671439);
			TypeInformation.NativeMethodInfoPtr_get_HasTypeForwardedFrom_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeInformation>.NativeClassPtr, 100671440);
			TypeInformation.NativeMethodInfoPtr__ctor_Internal_Void_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeInformation>.NativeClassPtr, 100671441);
		}

		// Token: 0x17000C5F RID: 3167
		// (get) Token: 0x0600356E RID: 13678 RVA: 0x00108D30 File Offset: 0x00106F30
		public unsafe string FullTypeName
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeInformation.NativeMethodInfoPtr_get_FullTypeName_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000C60 RID: 3168
		// (get) Token: 0x0600356F RID: 13679 RVA: 0x00108D68 File Offset: 0x00106F68
		public unsafe string AssemblyString
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeInformation.NativeMethodInfoPtr_get_AssemblyString_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000C61 RID: 3169
		// (get) Token: 0x06003570 RID: 13680 RVA: 0x00108DA0 File Offset: 0x00106FA0
		public unsafe bool HasTypeForwardedFrom
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 308625, RefRangeEnd = 308626, XrefRangeStart = 308625, XrefRangeEnd = 308626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeInformation.NativeMethodInfoPtr_get_HasTypeForwardedFrom_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003571 RID: 13681 RVA: 0x00108DDC File Offset: 0x00106FDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeInformation(string fullTypeName, string assemblyString, bool hasTypeForwardedFrom)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeInformation>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fullTypeName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(assemblyString);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasTypeForwardedFrom;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeInformation.NativeMethodInfoPtr__ctor_Internal_Void_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003572 RID: 13682 RVA: 0x00013116 File Offset: 0x00011316
		public TypeInformation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C5C RID: 3164
		// (get) Token: 0x06003573 RID: 13683 RVA: 0x00108E48 File Offset: 0x00107048
		// (set) Token: 0x06003574 RID: 13684 RVA: 0x0001311F File Offset: 0x0001131F
		public unsafe string fullTypeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeInformation.NativeFieldInfoPtr_fullTypeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeInformation.NativeFieldInfoPtr_fullTypeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000C5D RID: 3165
		// (get) Token: 0x06003575 RID: 13685 RVA: 0x00108E70 File Offset: 0x00107070
		// (set) Token: 0x06003576 RID: 13686 RVA: 0x0001313E File Offset: 0x0001133E
		public unsafe string assemblyString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeInformation.NativeFieldInfoPtr_assemblyString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeInformation.NativeFieldInfoPtr_assemblyString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000C5E RID: 3166
		// (get) Token: 0x06003577 RID: 13687 RVA: 0x00108E98 File Offset: 0x00107098
		// (set) Token: 0x06003578 RID: 13688 RVA: 0x0001315D File Offset: 0x0001135D
		public unsafe bool hasTypeForwardedFrom
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeInformation.NativeFieldInfoPtr_hasTypeForwardedFrom);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeInformation.NativeFieldInfoPtr_hasTypeForwardedFrom)) = value;
			}
		}

		// Token: 0x04002BB0 RID: 11184
		private static readonly IntPtr NativeFieldInfoPtr_fullTypeName;

		// Token: 0x04002BB1 RID: 11185
		private static readonly IntPtr NativeFieldInfoPtr_assemblyString;

		// Token: 0x04002BB2 RID: 11186
		private static readonly IntPtr NativeFieldInfoPtr_hasTypeForwardedFrom;

		// Token: 0x04002BB3 RID: 11187
		private static readonly IntPtr NativeMethodInfoPtr_get_FullTypeName_Internal_get_String_0;

		// Token: 0x04002BB4 RID: 11188
		private static readonly IntPtr NativeMethodInfoPtr_get_AssemblyString_Internal_get_String_0;

		// Token: 0x04002BB5 RID: 11189
		private static readonly IntPtr NativeMethodInfoPtr_get_HasTypeForwardedFrom_Internal_get_Boolean_0;

		// Token: 0x04002BB6 RID: 11190
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_String_Boolean_0;
	}
}
