using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;

namespace Il2CppSystem
{
	// Token: 0x020000E6 RID: 230
	[Serializable]
	public class StringComparer : Object
	{
		// Token: 0x06000EF1 RID: 3825 RVA: 0x0006BBF4 File Offset: 0x00069DF4
		// Note: this type is marked as 'beforefieldinit'.
		static StringComparer()
		{
			Il2CppClassPointerStore<StringComparer>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "StringComparer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringComparer>.NativeClassPtr);
			StringComparer.NativeFieldInfoPtr_s_invariantCulture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringComparer>.NativeClassPtr, "s_invariantCulture");
			StringComparer.NativeFieldInfoPtr_s_invariantCultureIgnoreCase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringComparer>.NativeClassPtr, "s_invariantCultureIgnoreCase");
			StringComparer.NativeFieldInfoPtr_s_ordinal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringComparer>.NativeClassPtr, "s_ordinal");
			StringComparer.NativeFieldInfoPtr_s_ordinalIgnoreCase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringComparer>.NativeClassPtr, "s_ordinalIgnoreCase");
			StringComparer.NativeMethodInfoPtr_get_InvariantCultureIgnoreCase_Public_Static_get_StringComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringComparer>.NativeClassPtr, 100665914);
			StringComparer.NativeMethodInfoPtr_get_Ordinal_Public_Static_get_StringComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringComparer>.NativeClassPtr, 100665915);
			StringComparer.NativeMethodInfoPtr_get_OrdinalIgnoreCase_Public_Static_get_StringComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringComparer>.NativeClassPtr, 100665916);
			StringComparer.NativeMethodInfoPtr_Create_Public_Static_StringComparer_CultureInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringComparer>.NativeClassPtr, 100665917);
			StringComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringComparer>.NativeClassPtr, 100665918);
			StringComparer.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringComparer>.NativeClassPtr, 100665919);
			StringComparer.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringComparer>.NativeClassPtr, 100665920);
			StringComparer.NativeMethodInfoPtr_Compare_Public_Abstract_Virtual_New_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringComparer>.NativeClassPtr, 100665921);
			StringComparer.NativeMethodInfoPtr_Equals_Public_Abstract_Virtual_New_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringComparer>.NativeClassPtr, 100665922);
			StringComparer.NativeMethodInfoPtr_GetHashCode_Public_Abstract_Virtual_New_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringComparer>.NativeClassPtr, 100665923);
			StringComparer.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringComparer>.NativeClassPtr, 100665924);
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06000EF2 RID: 3826 RVA: 0x0006BD50 File Offset: 0x00069F50
		public unsafe static StringComparer InvariantCultureIgnoreCase
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1320670, XrefRangeEnd = 1320674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringComparer.NativeMethodInfoPtr_get_InvariantCultureIgnoreCase_Public_Static_get_StringComparer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringComparer>(intPtr3) : null;
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06000EF3 RID: 3827 RVA: 0x0006BD84 File Offset: 0x00069F84
		public unsafe static StringComparer Ordinal
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1320674, XrefRangeEnd = 1320678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringComparer.NativeMethodInfoPtr_get_Ordinal_Public_Static_get_StringComparer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringComparer>(intPtr3) : null;
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06000EF4 RID: 3828 RVA: 0x0006BDB8 File Offset: 0x00069FB8
		public unsafe static StringComparer OrdinalIgnoreCase
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1320678, XrefRangeEnd = 1320682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringComparer.NativeMethodInfoPtr_get_OrdinalIgnoreCase_Public_Static_get_StringComparer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringComparer>(intPtr3) : null;
			}
		}

		// Token: 0x06000EF5 RID: 3829 RVA: 0x0006BDEC File Offset: 0x00069FEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1320682, XrefRangeEnd = 1320686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static StringComparer Create(CultureInfo culture, bool ignoreCase)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(culture);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringComparer.NativeMethodInfoPtr_Create_Public_Static_StringComparer_CultureInfo_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringComparer>(intPtr3) : null;
		}

		// Token: 0x06000EF6 RID: 3830 RVA: 0x0006BE40 File Offset: 0x0006A040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1320686, XrefRangeEnd = 1320693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int Compare(Object x, Object y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EF7 RID: 3831 RVA: 0x0006BEA0 File Offset: 0x0006A0A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1320693, XrefRangeEnd = 1320695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Equals(Object x, Object y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringComparer.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EF8 RID: 3832 RVA: 0x0006BF00 File Offset: 0x0006A100
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1320695, XrefRangeEnd = 1320742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetHashCode(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringComparer.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EF9 RID: 3833 RVA: 0x0006BF50 File Offset: 0x0006A150
		[CallerCount(0)]
		public unsafe virtual int Compare(string x, string y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(y);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StringComparer.NativeMethodInfoPtr_Compare_Public_Abstract_Virtual_New_Int32_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EFA RID: 3834 RVA: 0x0006BFBC File Offset: 0x0006A1BC
		[CallerCount(0)]
		public unsafe virtual bool Equals(string x, string y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(y);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StringComparer.NativeMethodInfoPtr_Equals_Public_Abstract_Virtual_New_Boolean_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EFB RID: 3835 RVA: 0x0006C028 File Offset: 0x0006A228
		[CallerCount(0)]
		public unsafe virtual int GetHashCode(string obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StringComparer.NativeMethodInfoPtr_GetHashCode_Public_Abstract_Virtual_New_Int32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EFC RID: 3836 RVA: 0x0006C080 File Offset: 0x0006A280
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringComparer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringComparer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringComparer.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EFD RID: 3837 RVA: 0x00005965 File Offset: 0x00003B65
		public StringComparer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06000EFE RID: 3838 RVA: 0x0006C0BC File Offset: 0x0006A2BC
		// (set) Token: 0x06000EFF RID: 3839 RVA: 0x0000596E File Offset: 0x00003B6E
		public unsafe static CultureAwareComparer s_invariantCulture
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StringComparer.NativeFieldInfoPtr_s_invariantCulture, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CultureAwareComparer>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StringComparer.NativeFieldInfoPtr_s_invariantCulture, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06000F00 RID: 3840 RVA: 0x0006C0E4 File Offset: 0x0006A2E4
		// (set) Token: 0x06000F01 RID: 3841 RVA: 0x00005980 File Offset: 0x00003B80
		public unsafe static CultureAwareComparer s_invariantCultureIgnoreCase
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StringComparer.NativeFieldInfoPtr_s_invariantCultureIgnoreCase, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CultureAwareComparer>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StringComparer.NativeFieldInfoPtr_s_invariantCultureIgnoreCase, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06000F02 RID: 3842 RVA: 0x0006C10C File Offset: 0x0006A30C
		// (set) Token: 0x06000F03 RID: 3843 RVA: 0x00005992 File Offset: 0x00003B92
		public unsafe static OrdinalCaseSensitiveComparer s_ordinal
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StringComparer.NativeFieldInfoPtr_s_ordinal, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OrdinalCaseSensitiveComparer>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StringComparer.NativeFieldInfoPtr_s_ordinal, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06000F04 RID: 3844 RVA: 0x0006C134 File Offset: 0x0006A334
		// (set) Token: 0x06000F05 RID: 3845 RVA: 0x000059A4 File Offset: 0x00003BA4
		public unsafe static OrdinalIgnoreCaseComparer s_ordinalIgnoreCase
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StringComparer.NativeFieldInfoPtr_s_ordinalIgnoreCase, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OrdinalIgnoreCaseComparer>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StringComparer.NativeFieldInfoPtr_s_ordinalIgnoreCase, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C33 RID: 3123
		private static readonly IntPtr NativeFieldInfoPtr_s_invariantCulture;

		// Token: 0x04000C34 RID: 3124
		private static readonly IntPtr NativeFieldInfoPtr_s_invariantCultureIgnoreCase;

		// Token: 0x04000C35 RID: 3125
		private static readonly IntPtr NativeFieldInfoPtr_s_ordinal;

		// Token: 0x04000C36 RID: 3126
		private static readonly IntPtr NativeFieldInfoPtr_s_ordinalIgnoreCase;

		// Token: 0x04000C37 RID: 3127
		private static readonly IntPtr NativeMethodInfoPtr_get_InvariantCultureIgnoreCase_Public_Static_get_StringComparer_0;

		// Token: 0x04000C38 RID: 3128
		private static readonly IntPtr NativeMethodInfoPtr_get_Ordinal_Public_Static_get_StringComparer_0;

		// Token: 0x04000C39 RID: 3129
		private static readonly IntPtr NativeMethodInfoPtr_get_OrdinalIgnoreCase_Public_Static_get_StringComparer_0;

		// Token: 0x04000C3A RID: 3130
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_StringComparer_CultureInfo_Boolean_0;

		// Token: 0x04000C3B RID: 3131
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Object_Object_0;

		// Token: 0x04000C3C RID: 3132
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Object_Object_0;

		// Token: 0x04000C3D RID: 3133
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_Object_0;

		// Token: 0x04000C3E RID: 3134
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Abstract_Virtual_New_Int32_String_String_0;

		// Token: 0x04000C3F RID: 3135
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Abstract_Virtual_New_Boolean_String_String_0;

		// Token: 0x04000C40 RID: 3136
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Abstract_Virtual_New_Int32_String_0;

		// Token: 0x04000C41 RID: 3137
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
