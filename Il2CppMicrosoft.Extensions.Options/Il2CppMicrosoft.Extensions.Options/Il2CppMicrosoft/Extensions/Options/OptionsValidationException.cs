using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppMicrosoft.Extensions.Options
{
	// Token: 0x0200001E RID: 30
	public class OptionsValidationException : Exception
	{
		// Token: 0x06000090 RID: 144 RVA: 0x00004918 File Offset: 0x00002B18
		// Note: this type is marked as 'beforefieldinit'.
		static OptionsValidationException()
		{
			Il2CppClassPointerStore<OptionsValidationException>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.Options.dll", "Microsoft.Extensions.Options", "OptionsValidationException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionsValidationException>.NativeClassPtr);
			OptionsValidationException.NativeFieldInfoPtr__OptionsName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsValidationException>.NativeClassPtr, "<OptionsName>k__BackingField");
			OptionsValidationException.NativeFieldInfoPtr__OptionsType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsValidationException>.NativeClassPtr, "<OptionsType>k__BackingField");
			OptionsValidationException.NativeFieldInfoPtr__Failures_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsValidationException>.NativeClassPtr, "<Failures>k__BackingField");
			OptionsValidationException.NativeMethodInfoPtr__ctor_Public_Void_String_Type_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsValidationException>.NativeClassPtr, 100663369);
			OptionsValidationException.NativeMethodInfoPtr_get_Failures_Public_get_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsValidationException>.NativeClassPtr, 100663370);
			OptionsValidationException.NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsValidationException>.NativeClassPtr, 100663371);
		}

		// Token: 0x06000091 RID: 145 RVA: 0x000049C0 File Offset: 0x00002BC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1266022, XrefRangeEnd = 1266042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OptionsValidationException(string optionsName, Type optionsType, IEnumerable<string> failureMessages)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OptionsValidationException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(optionsName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(optionsType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(failureMessages);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionsValidationException.NativeMethodInfoPtr__ctor_Public_Void_String_Type_IEnumerable_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000092 RID: 146 RVA: 0x00004A30 File Offset: 0x00002C30
		public unsafe IEnumerable<string> Failures
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionsValidationException.NativeMethodInfoPtr_get_Failures_Public_get_IEnumerable_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000093 RID: 147 RVA: 0x00004A70 File Offset: 0x00002C70
		public unsafe override string Message
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1266042, XrefRangeEnd = 1266051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OptionsValidationException.NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00002472 File Offset: 0x00000672
		public OptionsValidationException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000095 RID: 149 RVA: 0x00004AB4 File Offset: 0x00002CB4
		// (set) Token: 0x06000096 RID: 150 RVA: 0x0000247B File Offset: 0x0000067B
		public unsafe string _OptionsName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionsValidationException.NativeFieldInfoPtr__OptionsName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionsValidationException.NativeFieldInfoPtr__OptionsName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000097 RID: 151 RVA: 0x00004ADC File Offset: 0x00002CDC
		// (set) Token: 0x06000098 RID: 152 RVA: 0x0000249A File Offset: 0x0000069A
		public unsafe Type _OptionsType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionsValidationException.NativeFieldInfoPtr__OptionsType_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionsValidationException.NativeFieldInfoPtr__OptionsType_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000099 RID: 153 RVA: 0x00004B0C File Offset: 0x00002D0C
		// (set) Token: 0x0600009A RID: 154 RVA: 0x000024B9 File Offset: 0x000006B9
		public unsafe IEnumerable<string> _Failures_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionsValidationException.NativeFieldInfoPtr__Failures_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionsValidationException.NativeFieldInfoPtr__Failures_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeFieldInfoPtr__OptionsName_k__BackingField;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeFieldInfoPtr__OptionsType_k__BackingField;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeFieldInfoPtr__Failures_k__BackingField;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Type_IEnumerable_1_String_0;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeMethodInfoPtr_get_Failures_Public_get_IEnumerable_1_String_0;

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0;
	}
}
