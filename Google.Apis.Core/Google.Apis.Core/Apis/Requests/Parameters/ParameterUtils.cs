using System;
using Google.Apis.Logging;
using Google.Apis.Util;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Net.Http;

namespace Google.Apis.Requests.Parameters
{
	// Token: 0x02000016 RID: 22
	public static class ParameterUtils : Object
	{
		// Token: 0x060000D4 RID: 212 RVA: 0x00007414 File Offset: 0x00005614
		// Note: this type is marked as 'beforefieldinit'.
		static ParameterUtils()
		{
			Il2CppClassPointerStore<ParameterUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Core.dll", "Google.Apis.Requests.Parameters", "ParameterUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParameterUtils>.NativeClassPtr);
			ParameterUtils.NativeFieldInfoPtr_Logger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParameterUtils>.NativeClassPtr, "Logger");
			ParameterUtils.NativeMethodInfoPtr_CreateFormUrlEncodedContent_Public_Static_FormUrlEncodedContent_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterUtils>.NativeClassPtr, 100663422);
			ParameterUtils.NativeMethodInfoPtr_CreateParameterDictionary_Public_Static_IDictionary_2_String_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterUtils>.NativeClassPtr, 100663423);
			ParameterUtils.NativeMethodInfoPtr_InitParameters_Public_Static_Void_RequestBuilder_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterUtils>.NativeClassPtr, 100663424);
			ParameterUtils.NativeMethodInfoPtr_IterateParameters_Private_Static_Void_Object_Action_3_RequestParameterType_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterUtils>.NativeClassPtr, 100663425);
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x000074A8 File Offset: 0x000056A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1210879, RefRangeEnd = 1210880, XrefRangeStart = 1210854, XrefRangeEnd = 1210879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FormUrlEncodedContent CreateFormUrlEncodedContent(Object request)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterUtils.NativeMethodInfoPtr_CreateFormUrlEncodedContent_Public_Static_FormUrlEncodedContent_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FormUrlEncodedContent>(intPtr3) : null;
			}
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x000074EC File Offset: 0x000056EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1210901, RefRangeEnd = 1210902, XrefRangeStart = 1210880, XrefRangeEnd = 1210901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IDictionary<string, Object> CreateParameterDictionary(Object request)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterUtils.NativeMethodInfoPtr_CreateParameterDictionary_Public_Static_IDictionary_2_String_Object_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary<string, Object>>(intPtr3) : null;
			}
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00007530 File Offset: 0x00005730
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1210918, RefRangeEnd = 1210920, XrefRangeStart = 1210902, XrefRangeEnd = 1210918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitParameters(RequestBuilder builder, Object request)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(request);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterUtils.NativeMethodInfoPtr_InitParameters_Public_Static_Void_RequestBuilder_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00007578 File Offset: 0x00005778
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1210978, RefRangeEnd = 1210981, XrefRangeStart = 1210920, XrefRangeEnd = 1210978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void IterateParameters(Object request, Action<RequestParameterType, string, Object> action)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterUtils.NativeMethodInfoPtr_IterateParameters_Private_Static_Void_Object_Action_3_RequestParameterType_String_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x000024BB File Offset: 0x000006BB
		public ParameterUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000DA RID: 218 RVA: 0x000075C0 File Offset: 0x000057C0
		// (set) Token: 0x060000DB RID: 219 RVA: 0x000024C4 File Offset: 0x000006C4
		public unsafe static ILogger Logger
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ParameterUtils.NativeFieldInfoPtr_Logger, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ILogger>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ParameterUtils.NativeFieldInfoPtr_Logger, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeFieldInfoPtr_Logger;

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeMethodInfoPtr_CreateFormUrlEncodedContent_Public_Static_FormUrlEncodedContent_Object_0;

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeMethodInfoPtr_CreateParameterDictionary_Public_Static_IDictionary_2_String_Object_Object_0;

		// Token: 0x04000095 RID: 149
		private static readonly IntPtr NativeMethodInfoPtr_InitParameters_Public_Static_Void_RequestBuilder_Object_0;

		// Token: 0x04000096 RID: 150
		private static readonly IntPtr NativeMethodInfoPtr_IterateParameters_Private_Static_Void_Object_Action_3_RequestParameterType_String_Object_0;

		// Token: 0x0200004C RID: 76
		[ObfuscatedName("Google.Apis.Requests.Parameters.ParameterUtils+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : Object
		{
			// Token: 0x060002E8 RID: 744 RVA: 0x0000E830 File Offset: 0x0000CA30
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<ParameterUtils.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParameterUtils>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParameterUtils.__c__DisplayClass1_0>.NativeClassPtr);
				ParameterUtils.__c__DisplayClass1_0.NativeFieldInfoPtr_list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParameterUtils.__c__DisplayClass1_0>.NativeClassPtr, "list");
				ParameterUtils.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterUtils.__c__DisplayClass1_0>.NativeClassPtr, 100663427);
				ParameterUtils.__c__DisplayClass1_0.NativeMethodInfoPtr__CreateFormUrlEncodedContent_b__0_Internal_Void_RequestParameterType_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterUtils.__c__DisplayClass1_0>.NativeClassPtr, 100663428);
			}

			// Token: 0x060002E9 RID: 745 RVA: 0x0000E898 File Offset: 0x0000CA98
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParameterUtils.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterUtils.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002EA RID: 746 RVA: 0x0000E8D4 File Offset: 0x0000CAD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1210814, XrefRangeEnd = 1210820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateFormUrlEncodedContent_b__0(RequestParameterType type, string name, Object value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref type;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterUtils.__c__DisplayClass1_0.NativeMethodInfoPtr__CreateFormUrlEncodedContent_b__0_Internal_Void_RequestParameterType_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002EB RID: 747 RVA: 0x00003340 File Offset: 0x00001540
			public __c__DisplayClass1_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000E0 RID: 224
			// (get) Token: 0x060002EC RID: 748 RVA: 0x0000E938 File Offset: 0x0000CB38
			// (set) Token: 0x060002ED RID: 749 RVA: 0x00003349 File Offset: 0x00001549
			public unsafe IList<KeyValuePair<string, string>> list
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterUtils.__c__DisplayClass1_0.NativeFieldInfoPtr_list);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<KeyValuePair<string, string>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterUtils.__c__DisplayClass1_0.NativeFieldInfoPtr_list), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040001EF RID: 495
			private static readonly IntPtr NativeFieldInfoPtr_list;

			// Token: 0x040001F0 RID: 496
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040001F1 RID: 497
			private static readonly IntPtr NativeMethodInfoPtr__CreateFormUrlEncodedContent_b__0_Internal_Void_RequestParameterType_String_Object_0;
		}

		// Token: 0x0200004D RID: 77
		[ObfuscatedName("Google.Apis.Requests.Parameters.ParameterUtils+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Object
		{
			// Token: 0x060002EE RID: 750 RVA: 0x0000E968 File Offset: 0x0000CB68
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<ParameterUtils.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParameterUtils>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParameterUtils.__c__DisplayClass2_0>.NativeClassPtr);
				ParameterUtils.__c__DisplayClass2_0.NativeFieldInfoPtr_dict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParameterUtils.__c__DisplayClass2_0>.NativeClassPtr, "dict");
				ParameterUtils.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterUtils.__c__DisplayClass2_0>.NativeClassPtr, 100663429);
				ParameterUtils.__c__DisplayClass2_0.NativeMethodInfoPtr__CreateParameterDictionary_b__0_Internal_Void_RequestParameterType_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterUtils.__c__DisplayClass2_0>.NativeClassPtr, 100663430);
			}

			// Token: 0x060002EF RID: 751 RVA: 0x0000E9D0 File Offset: 0x0000CBD0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParameterUtils.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterUtils.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002F0 RID: 752 RVA: 0x0000EA0C File Offset: 0x0000CC0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1210820, XrefRangeEnd = 1210824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateParameterDictionary_b__0(RequestParameterType type, string name, Object value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref type;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterUtils.__c__DisplayClass2_0.NativeMethodInfoPtr__CreateParameterDictionary_b__0_Internal_Void_RequestParameterType_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002F1 RID: 753 RVA: 0x00003368 File Offset: 0x00001568
			public __c__DisplayClass2_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000E1 RID: 225
			// (get) Token: 0x060002F2 RID: 754 RVA: 0x0000EA70 File Offset: 0x0000CC70
			// (set) Token: 0x060002F3 RID: 755 RVA: 0x00003371 File Offset: 0x00001571
			public unsafe Dictionary<string, Object> dict
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterUtils.__c__DisplayClass2_0.NativeFieldInfoPtr_dict);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Object>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterUtils.__c__DisplayClass2_0.NativeFieldInfoPtr_dict), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040001F2 RID: 498
			private static readonly IntPtr NativeFieldInfoPtr_dict;

			// Token: 0x040001F3 RID: 499
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040001F4 RID: 500
			private static readonly IntPtr NativeMethodInfoPtr__CreateParameterDictionary_b__0_Internal_Void_RequestParameterType_String_Object_0;
		}

		// Token: 0x0200004E RID: 78
		[ObfuscatedName("Google.Apis.Requests.Parameters.ParameterUtils+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x060002F4 RID: 756 RVA: 0x0000EAA0 File Offset: 0x0000CCA0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<ParameterUtils.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParameterUtils>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParameterUtils.__c__DisplayClass3_0>.NativeClassPtr);
				ParameterUtils.__c__DisplayClass3_0.NativeFieldInfoPtr_builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParameterUtils.__c__DisplayClass3_0>.NativeClassPtr, "builder");
				ParameterUtils.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterUtils.__c__DisplayClass3_0>.NativeClassPtr, 100663431);
				ParameterUtils.__c__DisplayClass3_0.NativeMethodInfoPtr__InitParameters_b__0_Internal_Void_RequestParameterType_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterUtils.__c__DisplayClass3_0>.NativeClassPtr, 100663432);
			}

			// Token: 0x060002F5 RID: 757 RVA: 0x0000EB08 File Offset: 0x0000CD08
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParameterUtils.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterUtils.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002F6 RID: 758 RVA: 0x0000EB44 File Offset: 0x0000CD44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1210824, XrefRangeEnd = 1210854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InitParameters_b__0(RequestParameterType type, string name, Object value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref type;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterUtils.__c__DisplayClass3_0.NativeMethodInfoPtr__InitParameters_b__0_Internal_Void_RequestParameterType_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002F7 RID: 759 RVA: 0x00003390 File Offset: 0x00001590
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000E2 RID: 226
			// (get) Token: 0x060002F8 RID: 760 RVA: 0x0000EBA8 File Offset: 0x0000CDA8
			// (set) Token: 0x060002F9 RID: 761 RVA: 0x00003399 File Offset: 0x00001599
			public unsafe RequestBuilder builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterUtils.__c__DisplayClass3_0.NativeFieldInfoPtr_builder);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RequestBuilder>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterUtils.__c__DisplayClass3_0.NativeFieldInfoPtr_builder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040001F5 RID: 501
			private static readonly IntPtr NativeFieldInfoPtr_builder;

			// Token: 0x040001F6 RID: 502
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040001F7 RID: 503
			private static readonly IntPtr NativeMethodInfoPtr__InitParameters_b__0_Internal_Void_RequestParameterType_String_Object_0;
		}
	}
}
