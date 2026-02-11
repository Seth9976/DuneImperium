using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x020000A2 RID: 162
	public static class Extensions : Object
	{
		// Token: 0x06000DE7 RID: 3559 RVA: 0x0005239C File Offset: 0x0005059C
		// Note: this type is marked as 'beforefieldinit'.
		static Extensions()
		{
			Il2CppClassPointerStore<Extensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Schema", "Extensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Extensions>.NativeClassPtr);
			Extensions.NativeMethodInfoPtr_IsValid_Public_Static_Boolean_JToken_JsonSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extensions>.NativeClassPtr, 100665834);
			Extensions.NativeMethodInfoPtr_IsValid_Public_Static_Boolean_JToken_JsonSchema_byref_IList_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extensions>.NativeClassPtr, 100665835);
			Extensions.NativeMethodInfoPtr_Validate_Public_Static_Void_JToken_JsonSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extensions>.NativeClassPtr, 100665836);
			Extensions.NativeMethodInfoPtr_Validate_Public_Static_Void_JToken_JsonSchema_ValidationEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extensions>.NativeClassPtr, 100665837);
		}

		// Token: 0x06000DE8 RID: 3560 RVA: 0x0005241C File Offset: 0x0005061C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 754014, XrefRangeEnd = 754025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValid(this JToken source, JsonSchema schema)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schema);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Extensions.NativeMethodInfoPtr_IsValid_Public_Static_Boolean_JToken_JsonSchema_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DE9 RID: 3561 RVA: 0x00052470 File Offset: 0x00050670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 754025, XrefRangeEnd = 754047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValid(this JToken source, JsonSchema schema, out IList<string> errorMessages)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schema);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Extensions.NativeMethodInfoPtr_IsValid_Public_Static_Boolean_JToken_JsonSchema_byref_IList_1_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			errorMessages = ((intPtr4 == 0) ? null : new IList<string>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000DEA RID: 3562 RVA: 0x000524E8 File Offset: 0x000506E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 754047, XrefRangeEnd = 754048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Validate(this JToken source, JsonSchema schema)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schema);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Extensions.NativeMethodInfoPtr_Validate_Public_Static_Void_JToken_JsonSchema_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DEB RID: 3563 RVA: 0x00052530 File Offset: 0x00050730
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 754067, RefRangeEnd = 754070, XrefRangeStart = 754048, XrefRangeEnd = 754067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Validate(this JToken source, JsonSchema schema, ValidationEventHandler validationEventHandler)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schema);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(validationEventHandler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Extensions.NativeMethodInfoPtr_Validate_Public_Static_Void_JToken_JsonSchema_ValidationEventHandler_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DEC RID: 3564 RVA: 0x00006741 File Offset: 0x00004941
		public Extensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B40 RID: 2880
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Public_Static_Boolean_JToken_JsonSchema_0;

		// Token: 0x04000B41 RID: 2881
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Public_Static_Boolean_JToken_JsonSchema_byref_IList_1_String_0;

		// Token: 0x04000B42 RID: 2882
		private static readonly IntPtr NativeMethodInfoPtr_Validate_Public_Static_Void_JToken_JsonSchema_0;

		// Token: 0x04000B43 RID: 2883
		private static readonly IntPtr NativeMethodInfoPtr_Validate_Public_Static_Void_JToken_JsonSchema_ValidationEventHandler_0;

		// Token: 0x020001DA RID: 474
		[ObfuscatedName("Newtonsoft.Json.Schema.Extensions+<>c__DisplayClass0_0")]
		public sealed class __c__DisplayClass0_0 : Object
		{
			// Token: 0x06001ED2 RID: 7890 RVA: 0x0008DAC4 File Offset: 0x0008BCC4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass0_0()
			{
				Il2CppClassPointerStore<Extensions.__c__DisplayClass0_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Extensions>.NativeClassPtr, "<>c__DisplayClass0_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Extensions.__c__DisplayClass0_0>.NativeClassPtr);
				Extensions.__c__DisplayClass0_0.NativeFieldInfoPtr_valid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Extensions.__c__DisplayClass0_0>.NativeClassPtr, "valid");
				Extensions.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extensions.__c__DisplayClass0_0>.NativeClassPtr, 100665838);
				Extensions.__c__DisplayClass0_0.NativeMethodInfoPtr__IsValid_b__0_Internal_Void_Object_ValidationEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extensions.__c__DisplayClass0_0>.NativeClassPtr, 100665839);
			}

			// Token: 0x06001ED3 RID: 7891 RVA: 0x0008DB2C File Offset: 0x0008BD2C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass0_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Extensions.__c__DisplayClass0_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Extensions.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001ED4 RID: 7892 RVA: 0x0008DB68 File Offset: 0x0008BD68
			[CallerCount(0)]
			public unsafe void _IsValid_b__0(Object sender, ValidationEventArgs args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Extensions.__c__DisplayClass0_0.NativeMethodInfoPtr__IsValid_b__0_Internal_Void_Object_ValidationEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001ED5 RID: 7893 RVA: 0x0000F385 File Offset: 0x0000D585
			public __c__DisplayClass0_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008A4 RID: 2212
			// (get) Token: 0x06001ED6 RID: 7894 RVA: 0x0008DBBC File Offset: 0x0008BDBC
			// (set) Token: 0x06001ED7 RID: 7895 RVA: 0x0000F38E File Offset: 0x0000D58E
			public unsafe bool valid
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Extensions.__c__DisplayClass0_0.NativeFieldInfoPtr_valid);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Extensions.__c__DisplayClass0_0.NativeFieldInfoPtr_valid)) = value;
				}
			}

			// Token: 0x04001676 RID: 5750
			private static readonly IntPtr NativeFieldInfoPtr_valid;

			// Token: 0x04001677 RID: 5751
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001678 RID: 5752
			private static readonly IntPtr NativeMethodInfoPtr__IsValid_b__0_Internal_Void_Object_ValidationEventArgs_0;
		}

		// Token: 0x020001DB RID: 475
		[ObfuscatedName("Newtonsoft.Json.Schema.Extensions+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : Object
		{
			// Token: 0x06001ED8 RID: 7896 RVA: 0x0008DBE4 File Offset: 0x0008BDE4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<Extensions.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Extensions>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Extensions.__c__DisplayClass1_0>.NativeClassPtr);
				Extensions.__c__DisplayClass1_0.NativeFieldInfoPtr_errors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Extensions.__c__DisplayClass1_0>.NativeClassPtr, "errors");
				Extensions.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extensions.__c__DisplayClass1_0>.NativeClassPtr, 100665840);
				Extensions.__c__DisplayClass1_0.NativeMethodInfoPtr__IsValid_b__0_Internal_Void_Object_ValidationEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extensions.__c__DisplayClass1_0>.NativeClassPtr, 100665841);
			}

			// Token: 0x06001ED9 RID: 7897 RVA: 0x0008DC4C File Offset: 0x0008BE4C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Extensions.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Extensions.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001EDA RID: 7898 RVA: 0x0008DC88 File Offset: 0x0008BE88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 754009, XrefRangeEnd = 754014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _IsValid_b__0(Object sender, ValidationEventArgs args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Extensions.__c__DisplayClass1_0.NativeMethodInfoPtr__IsValid_b__0_Internal_Void_Object_ValidationEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001EDB RID: 7899 RVA: 0x0000F3A9 File Offset: 0x0000D5A9
			public __c__DisplayClass1_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008A5 RID: 2213
			// (get) Token: 0x06001EDC RID: 7900 RVA: 0x0008DCDC File Offset: 0x0008BEDC
			// (set) Token: 0x06001EDD RID: 7901 RVA: 0x0000F3B2 File Offset: 0x0000D5B2
			public unsafe IList<string> errors
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Extensions.__c__DisplayClass1_0.NativeFieldInfoPtr_errors);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Extensions.__c__DisplayClass1_0.NativeFieldInfoPtr_errors), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001679 RID: 5753
			private static readonly IntPtr NativeFieldInfoPtr_errors;

			// Token: 0x0400167A RID: 5754
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400167B RID: 5755
			private static readonly IntPtr NativeMethodInfoPtr__IsValid_b__0_Internal_Void_Object_ValidationEventArgs_0;
		}
	}
}
