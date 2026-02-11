using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppMono.Options
{
	// Token: 0x0200000C RID: 12
	public class Option : Object
	{
		// Token: 0x0600008A RID: 138 RVA: 0x00006A28 File Offset: 0x00004C28
		// Note: this type is marked as 'beforefieldinit'.
		static Option()
		{
			Il2CppClassPointerStore<Option>.NativeClassPtr = IL2CPP.GetIl2CppClass("platform.dll", "Mono.Options", "Option");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Option>.NativeClassPtr);
			Option.NativeFieldInfoPtr_prototype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Option>.NativeClassPtr, "prototype");
			Option.NativeFieldInfoPtr_description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Option>.NativeClassPtr, "description");
			Option.NativeFieldInfoPtr_names = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Option>.NativeClassPtr, "names");
			Option.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Option>.NativeClassPtr, "type");
			Option.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Option>.NativeClassPtr, "count");
			Option.NativeFieldInfoPtr_separators = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Option>.NativeClassPtr, "separators");
			Option.NativeFieldInfoPtr_hidden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Option>.NativeClassPtr, "hidden");
			Option.NativeFieldInfoPtr_NameTerminator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Option>.NativeClassPtr, "NameTerminator");
			Option.NativeMethodInfoPtr__ctor_Protected_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Option>.NativeClassPtr, 100663398);
			Option.NativeMethodInfoPtr__ctor_Protected_Void_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Option>.NativeClassPtr, 100663399);
			Option.NativeMethodInfoPtr__ctor_Protected_Void_String_String_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Option>.NativeClassPtr, 100663400);
			Option.NativeMethodInfoPtr_get_Prototype_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Option>.NativeClassPtr, 100663401);
			Option.NativeMethodInfoPtr_get_Description_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Option>.NativeClassPtr, 100663402);
			Option.NativeMethodInfoPtr_get_OptionValueType_Public_get_OptionValueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Option>.NativeClassPtr, 100663403);
			Option.NativeMethodInfoPtr_get_MaxValueCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Option>.NativeClassPtr, 100663404);
			Option.NativeMethodInfoPtr_get_Hidden_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Option>.NativeClassPtr, 100663405);
			Option.NativeMethodInfoPtr_GetNames_Public_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Option>.NativeClassPtr, 100663406);
			Option.NativeMethodInfoPtr_GetValueSeparators_Public_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Option>.NativeClassPtr, 100663407);
			Option.NativeMethodInfoPtr_Parse_Protected_Static_T_String_OptionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Option>.NativeClassPtr, 100663408);
			Option.NativeMethodInfoPtr_get_Names_Internal_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Option>.NativeClassPtr, 100663409);
			Option.NativeMethodInfoPtr_get_ValueSeparators_Internal_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Option>.NativeClassPtr, 100663410);
			Option.NativeMethodInfoPtr_ParsePrototype_Private_OptionValueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Option>.NativeClassPtr, 100663411);
			Option.NativeMethodInfoPtr_AddSeparators_Private_Static_Void_String_Int32_ICollection_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Option>.NativeClassPtr, 100663412);
			Option.NativeMethodInfoPtr_Invoke_Public_Void_OptionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Option>.NativeClassPtr, 100663413);
			Option.NativeMethodInfoPtr_OnParseComplete_Protected_Abstract_Virtual_New_Void_OptionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Option>.NativeClassPtr, 100663414);
			Option.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Option>.NativeClassPtr, 100663415);
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00006C60 File Offset: 0x00004E60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1166053, XrefRangeEnd = 1166054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Option(string prototype, string description)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Option>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prototype);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(description);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Option.NativeMethodInfoPtr__ctor_Protected_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00006CC0 File Offset: 0x00004EC0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1166055, RefRangeEnd = 1166057, XrefRangeStart = 1166054, XrefRangeEnd = 1166055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Option(string prototype, string description, int maxValueCount)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Option>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prototype);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(description);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxValueCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Option.NativeMethodInfoPtr__ctor_Protected_Void_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00006D2C File Offset: 0x00004F2C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1166079, RefRangeEnd = 1166087, XrefRangeStart = 1166057, XrefRangeEnd = 1166079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Option(string prototype, string description, int maxValueCount, bool hidden)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Option>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prototype);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(description);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxValueCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hidden;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Option.NativeMethodInfoPtr__ctor_Protected_Void_String_String_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600008E RID: 142 RVA: 0x00006DA8 File Offset: 0x00004FA8
		public unsafe string Prototype
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Option.NativeMethodInfoPtr_get_Prototype_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600008F RID: 143 RVA: 0x00006DE0 File Offset: 0x00004FE0
		public unsafe string Description
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Option.NativeMethodInfoPtr_get_Description_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000090 RID: 144 RVA: 0x00006E18 File Offset: 0x00005018
		public unsafe OptionValueType OptionValueType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Option.NativeMethodInfoPtr_get_OptionValueType_Public_get_OptionValueType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000091 RID: 145 RVA: 0x00006E54 File Offset: 0x00005054
		public unsafe int MaxValueCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Option.NativeMethodInfoPtr_get_MaxValueCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000092 RID: 146 RVA: 0x00006E90 File Offset: 0x00005090
		public unsafe bool Hidden
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Option.NativeMethodInfoPtr_get_Hidden_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00006ECC File Offset: 0x000050CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1166087, XrefRangeEnd = 1166090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray GetNames()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Option.NativeMethodInfoPtr_GetNames_Public_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00006F0C File Offset: 0x0000510C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1166090, XrefRangeEnd = 1166093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray GetValueSeparators()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Option.NativeMethodInfoPtr_GetValueSeparators_Public_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00006F4C File Offset: 0x0000514C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1166093, XrefRangeEnd = 1166123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T Parse<T>(string value, OptionContext c)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(c);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Option.MethodInfoStoreGeneric_Parse_Protected_Static_T_String_OptionContext_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000096 RID: 150 RVA: 0x00006F9C File Offset: 0x0000519C
		public unsafe Il2CppStringArray Names
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Option.NativeMethodInfoPtr_get_Names_Internal_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000097 RID: 151 RVA: 0x00006FDC File Offset: 0x000051DC
		public unsafe Il2CppStringArray ValueSeparators
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Option.NativeMethodInfoPtr_get_ValueSeparators_Internal_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x06000098 RID: 152 RVA: 0x0000701C File Offset: 0x0000521C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1166151, RefRangeEnd = 1166152, XrefRangeStart = 1166123, XrefRangeEnd = 1166151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OptionValueType ParsePrototype()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Option.NativeMethodInfoPtr_ParsePrototype_Private_OptionValueType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00007058 File Offset: 0x00005258
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1166167, RefRangeEnd = 1166168, XrefRangeStart = 1166152, XrefRangeEnd = 1166167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddSeparators(string name, int end, ICollection<string> seps)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(seps);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Option.NativeMethodInfoPtr_AddSeparators_Private_Static_Void_String_Int32_ICollection_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x000070B0 File Offset: 0x000052B0
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1166172, RefRangeEnd = 1166181, XrefRangeStart = 1166168, XrefRangeEnd = 1166172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(OptionContext c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Option.NativeMethodInfoPtr_Invoke_Public_Void_OptionContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600009B RID: 155 RVA: 0x000070F4 File Offset: 0x000052F4
		[CallerCount(0)]
		public unsafe virtual void OnParseComplete(OptionContext c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Option.NativeMethodInfoPtr_OnParseComplete_Protected_Abstract_Virtual_New_Void_OptionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00007144 File Offset: 0x00005344
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Option.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00002347 File Offset: 0x00000547
		public Option(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600009E RID: 158 RVA: 0x00007188 File Offset: 0x00005388
		// (set) Token: 0x0600009F RID: 159 RVA: 0x00002350 File Offset: 0x00000550
		public unsafe string prototype
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Option.NativeFieldInfoPtr_prototype);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Option.NativeFieldInfoPtr_prototype), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x000071B0 File Offset: 0x000053B0
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x0000236F File Offset: 0x0000056F
		public unsafe string description
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Option.NativeFieldInfoPtr_description);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Option.NativeFieldInfoPtr_description), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x000071D8 File Offset: 0x000053D8
		// (set) Token: 0x060000A3 RID: 163 RVA: 0x0000238E File Offset: 0x0000058E
		public unsafe Il2CppStringArray names
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Option.NativeFieldInfoPtr_names);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Option.NativeFieldInfoPtr_names), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x00007208 File Offset: 0x00005408
		// (set) Token: 0x060000A5 RID: 165 RVA: 0x000023AD File Offset: 0x000005AD
		public unsafe OptionValueType type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Option.NativeFieldInfoPtr_type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Option.NativeFieldInfoPtr_type)) = value;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x00007230 File Offset: 0x00005430
		// (set) Token: 0x060000A7 RID: 167 RVA: 0x000023C8 File Offset: 0x000005C8
		public unsafe int count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Option.NativeFieldInfoPtr_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Option.NativeFieldInfoPtr_count)) = value;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x00007258 File Offset: 0x00005458
		// (set) Token: 0x060000A9 RID: 169 RVA: 0x000023E3 File Offset: 0x000005E3
		public unsafe Il2CppStringArray separators
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Option.NativeFieldInfoPtr_separators);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Option.NativeFieldInfoPtr_separators), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000AA RID: 170 RVA: 0x00007288 File Offset: 0x00005488
		// (set) Token: 0x060000AB RID: 171 RVA: 0x00002402 File Offset: 0x00000602
		public unsafe bool hidden
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Option.NativeFieldInfoPtr_hidden);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Option.NativeFieldInfoPtr_hidden)) = value;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000AC RID: 172 RVA: 0x000072B0 File Offset: 0x000054B0
		// (set) Token: 0x060000AD RID: 173 RVA: 0x0000241D File Offset: 0x0000061D
		public unsafe static Il2CppStructArray<char> NameTerminator
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Option.NativeFieldInfoPtr_NameTerminator, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Option.NativeFieldInfoPtr_NameTerminator, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeFieldInfoPtr_prototype;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeFieldInfoPtr_description;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeFieldInfoPtr_names;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeFieldInfoPtr_count;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeFieldInfoPtr_separators;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeFieldInfoPtr_hidden;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeFieldInfoPtr_NameTerminator;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_String_String_0;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_String_String_Int32_0;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_String_String_Int32_Boolean_0;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeMethodInfoPtr_get_Prototype_Public_get_String_0;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeMethodInfoPtr_get_Description_Public_get_String_0;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeMethodInfoPtr_get_OptionValueType_Public_get_OptionValueType_0;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxValueCount_Public_get_Int32_0;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeMethodInfoPtr_get_Hidden_Public_get_Boolean_0;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeMethodInfoPtr_GetNames_Public_Il2CppStringArray_0;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeMethodInfoPtr_GetValueSeparators_Public_Il2CppStringArray_0;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Protected_Static_T_String_OptionContext_0;

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeMethodInfoPtr_get_Names_Internal_get_Il2CppStringArray_0;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueSeparators_Internal_get_Il2CppStringArray_0;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeMethodInfoPtr_ParsePrototype_Private_OptionValueType_0;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeMethodInfoPtr_AddSeparators_Private_Static_Void_String_Int32_ICollection_1_String_0;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Void_OptionContext_0;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeMethodInfoPtr_OnParseComplete_Protected_Abstract_Virtual_New_Void_OptionContext_0;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0200005F RID: 95
		private sealed class MethodInfoStoreGeneric_Parse_Protected_Static_T_String_OptionContext_0<T>
		{
			// Token: 0x04000276 RID: 630
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Option.NativeMethodInfoPtr_Parse_Protected_Static_T_String_OptionContext_0, Il2CppClassPointerStore<Option>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
