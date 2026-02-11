using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x020003B6 RID: 950
	public static class FormattableStringFactory : Object
	{
		// Token: 0x06003913 RID: 14611 RVA: 0x00015092 File Offset: 0x00013292
		// Note: this type is marked as 'beforefieldinit'.
		static FormattableStringFactory()
		{
			Il2CppClassPointerStore<FormattableStringFactory>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "FormattableStringFactory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FormattableStringFactory>.NativeClassPtr);
			FormattableStringFactory.NativeMethodInfoPtr_Create_Public_Static_FormattableString_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormattableStringFactory>.NativeClassPtr, 100671816);
		}

		// Token: 0x06003914 RID: 14612 RVA: 0x00114F08 File Offset: 0x00113108
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 1392935, RefRangeEnd = 1392951, XrefRangeStart = 1392929, XrefRangeEnd = 1392935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FormattableString Create(string format, [Optional] Il2CppReferenceArray<Object> arguments)
		{
			if (arguments == null)
			{
				arguments = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arguments);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormattableStringFactory.NativeMethodInfoPtr_Create_Public_Static_FormattableString_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FormattableString>(intPtr3) : null;
		}

		// Token: 0x06003915 RID: 14613 RVA: 0x000150CB File Offset: 0x000132CB
		public static FormattableString Create(string format, params Object[] arguments)
		{
			return FormattableStringFactory.Create(format, new Il2CppReferenceArray<Object>(arguments));
		}

		// Token: 0x06003916 RID: 14614 RVA: 0x000150D9 File Offset: 0x000132D9
		public FormattableStringFactory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002E7F RID: 11903
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_FormattableString_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0200068B RID: 1675
		public sealed class ConcreteFormattableString : FormattableString
		{
			// Token: 0x06005BB9 RID: 23481 RVA: 0x001A0FBC File Offset: 0x0019F1BC
			// Note: this type is marked as 'beforefieldinit'.
			static ConcreteFormattableString()
			{
				Il2CppClassPointerStore<FormattableStringFactory.ConcreteFormattableString>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FormattableStringFactory>.NativeClassPtr, "ConcreteFormattableString");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FormattableStringFactory.ConcreteFormattableString>.NativeClassPtr);
				FormattableStringFactory.ConcreteFormattableString.NativeFieldInfoPtr__format = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormattableStringFactory.ConcreteFormattableString>.NativeClassPtr, "_format");
				FormattableStringFactory.ConcreteFormattableString.NativeFieldInfoPtr__arguments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormattableStringFactory.ConcreteFormattableString>.NativeClassPtr, "_arguments");
				FormattableStringFactory.ConcreteFormattableString.NativeMethodInfoPtr__ctor_Internal_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormattableStringFactory.ConcreteFormattableString>.NativeClassPtr, 100671817);
				FormattableStringFactory.ConcreteFormattableString.NativeMethodInfoPtr_get_Format_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormattableStringFactory.ConcreteFormattableString>.NativeClassPtr, 100671818);
				FormattableStringFactory.ConcreteFormattableString.NativeMethodInfoPtr_GetArguments_Public_Virtual_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormattableStringFactory.ConcreteFormattableString>.NativeClassPtr, 100671819);
				FormattableStringFactory.ConcreteFormattableString.NativeMethodInfoPtr_get_ArgumentCount_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormattableStringFactory.ConcreteFormattableString>.NativeClassPtr, 100671820);
				FormattableStringFactory.ConcreteFormattableString.NativeMethodInfoPtr_GetArgument_Public_Virtual_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormattableStringFactory.ConcreteFormattableString>.NativeClassPtr, 100671821);
				FormattableStringFactory.ConcreteFormattableString.NativeMethodInfoPtr_ToString_Public_Virtual_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormattableStringFactory.ConcreteFormattableString>.NativeClassPtr, 100671822);
			}

			// Token: 0x06005BBA RID: 23482 RVA: 0x001A1088 File Offset: 0x0019F288
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 442634, RefRangeEnd = 442638, XrefRangeStart = 442634, XrefRangeEnd = 442638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ConcreteFormattableString(string format, Il2CppReferenceArray<Object> arguments)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FormattableStringFactory.ConcreteFormattableString>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arguments);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormattableStringFactory.ConcreteFormattableString.NativeMethodInfoPtr__ctor_Internal_Void_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700177A RID: 6010
			// (get) Token: 0x06005BBB RID: 23483 RVA: 0x001A10E8 File Offset: 0x0019F2E8
			public unsafe override string Format
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormattableStringFactory.ConcreteFormattableString.NativeMethodInfoPtr_get_Format_Public_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06005BBC RID: 23484 RVA: 0x001A1120 File Offset: 0x0019F320
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Il2CppReferenceArray<Object> GetArguments()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormattableStringFactory.ConcreteFormattableString.NativeMethodInfoPtr_GetArguments_Public_Virtual_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}

			// Token: 0x1700177B RID: 6011
			// (get) Token: 0x06005BBD RID: 23485 RVA: 0x001A1160 File Offset: 0x0019F360
			public unsafe override int ArgumentCount
			{
				[CallerCount(13)]
				[CachedScanResults(RefRangeStart = 428718, RefRangeEnd = 428731, XrefRangeStart = 428718, XrefRangeEnd = 428731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormattableStringFactory.ConcreteFormattableString.NativeMethodInfoPtr_get_ArgumentCount_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005BBE RID: 23486 RVA: 0x001A119C File Offset: 0x0019F39C
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1029194, RefRangeEnd = 1029200, XrefRangeStart = 1029194, XrefRangeEnd = 1029200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Object GetArgument(int index)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormattableStringFactory.ConcreteFormattableString.NativeMethodInfoPtr_GetArgument_Public_Virtual_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005BBF RID: 23487 RVA: 0x001A11E8 File Offset: 0x0019F3E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1392928, XrefRangeEnd = 1392929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ToString(IFormatProvider formatProvider)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(formatProvider);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormattableStringFactory.ConcreteFormattableString.NativeMethodInfoPtr_ToString_Public_Virtual_String_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06005BC0 RID: 23488 RVA: 0x0002140E File Offset: 0x0001F60E
			public ConcreteFormattableString(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001778 RID: 6008
			// (get) Token: 0x06005BC1 RID: 23489 RVA: 0x001A1230 File Offset: 0x0019F430
			// (set) Token: 0x06005BC2 RID: 23490 RVA: 0x00021417 File Offset: 0x0001F617
			public unsafe string _format
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormattableStringFactory.ConcreteFormattableString.NativeFieldInfoPtr__format);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormattableStringFactory.ConcreteFormattableString.NativeFieldInfoPtr__format), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001779 RID: 6009
			// (get) Token: 0x06005BC3 RID: 23491 RVA: 0x001A1258 File Offset: 0x0019F458
			// (set) Token: 0x06005BC4 RID: 23492 RVA: 0x00021436 File Offset: 0x0001F636
			public unsafe Il2CppReferenceArray<Object> _arguments
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormattableStringFactory.ConcreteFormattableString.NativeFieldInfoPtr__arguments);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormattableStringFactory.ConcreteFormattableString.NativeFieldInfoPtr__arguments), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004AAA RID: 19114
			private static readonly IntPtr NativeFieldInfoPtr__format;

			// Token: 0x04004AAB RID: 19115
			private static readonly IntPtr NativeFieldInfoPtr__arguments;

			// Token: 0x04004AAC RID: 19116
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Il2CppReferenceArray_1_Object_0;

			// Token: 0x04004AAD RID: 19117
			private static readonly IntPtr NativeMethodInfoPtr_get_Format_Public_Virtual_get_String_0;

			// Token: 0x04004AAE RID: 19118
			private static readonly IntPtr NativeMethodInfoPtr_GetArguments_Public_Virtual_Il2CppReferenceArray_1_Object_0;

			// Token: 0x04004AAF RID: 19119
			private static readonly IntPtr NativeMethodInfoPtr_get_ArgumentCount_Public_Virtual_get_Int32_0;

			// Token: 0x04004AB0 RID: 19120
			private static readonly IntPtr NativeMethodInfoPtr_GetArgument_Public_Virtual_Object_Int32_0;

			// Token: 0x04004AB1 RID: 19121
			private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_IFormatProvider_0;
		}
	}
}
