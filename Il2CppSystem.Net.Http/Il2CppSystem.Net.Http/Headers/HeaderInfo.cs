using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Net.Http.Headers
{
	// Token: 0x02000022 RID: 34
	public class HeaderInfo : Object
	{
		// Token: 0x0600020E RID: 526 RVA: 0x0000C468 File Offset: 0x0000A668
		// Note: this type is marked as 'beforefieldinit'.
		static HeaderInfo()
		{
			Il2CppClassPointerStore<HeaderInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Net.Http.dll", "System.Net.Http.Headers", "HeaderInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HeaderInfo>.NativeClassPtr);
			HeaderInfo.NativeFieldInfoPtr_AllowsMany = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeaderInfo>.NativeClassPtr, "AllowsMany");
			HeaderInfo.NativeFieldInfoPtr_HeaderKind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeaderInfo>.NativeClassPtr, "HeaderKind");
			HeaderInfo.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeaderInfo>.NativeClassPtr, "Name");
			HeaderInfo.NativeFieldInfoPtr__CustomToString_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeaderInfo>.NativeClassPtr, "<CustomToString>k__BackingField");
			HeaderInfo.NativeMethodInfoPtr__ctor_Protected_Void_String_HttpHeaderKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeaderInfo>.NativeClassPtr, 100663591);
			HeaderInfo.NativeMethodInfoPtr_CreateSingle_Public_Static_HeaderInfo_String_TryParseDelegate_1_T_HttpHeaderKind_Func_2_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeaderInfo>.NativeClassPtr, 100663592);
			HeaderInfo.NativeMethodInfoPtr_CreateMulti_Public_Static_HeaderInfo_String_TryParseListDelegate_1_T_HttpHeaderKind_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeaderInfo>.NativeClassPtr, 100663593);
			HeaderInfo.NativeMethodInfoPtr_CreateCollection_Public_Object_HttpHeaders_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeaderInfo>.NativeClassPtr, 100663594);
			HeaderInfo.NativeMethodInfoPtr_get_CustomToString_Public_get_Func_2_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeaderInfo>.NativeClassPtr, 100663595);
			HeaderInfo.NativeMethodInfoPtr_set_CustomToString_Private_set_Void_Func_2_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeaderInfo>.NativeClassPtr, 100663596);
			HeaderInfo.NativeMethodInfoPtr_get_Separator_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeaderInfo>.NativeClassPtr, 100663597);
			HeaderInfo.NativeMethodInfoPtr_AddToCollection_Public_Abstract_Virtual_New_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeaderInfo>.NativeClassPtr, 100663598);
			HeaderInfo.NativeMethodInfoPtr_CreateCollection_Protected_Abstract_Virtual_New_Object_HttpHeaders_HeaderInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeaderInfo>.NativeClassPtr, 100663599);
			HeaderInfo.NativeMethodInfoPtr_ToStringCollection_Public_Abstract_Virtual_New_List_1_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeaderInfo>.NativeClassPtr, 100663600);
			HeaderInfo.NativeMethodInfoPtr_TryParse_Public_Abstract_Virtual_New_Boolean_String_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeaderInfo>.NativeClassPtr, 100663601);
		}

		// Token: 0x0600020F RID: 527 RVA: 0x0000C5C4 File Offset: 0x0000A7C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1173534, RefRangeEnd = 1173535, XrefRangeStart = 1173532, XrefRangeEnd = 1173534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HeaderInfo(string name, HttpHeaderKind headerKind)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HeaderInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref headerKind;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeaderInfo.NativeMethodInfoPtr__ctor_Protected_Void_String_HttpHeaderKind_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000210 RID: 528 RVA: 0x0000C620 File Offset: 0x0000A820
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173535, XrefRangeEnd = 1173540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HeaderInfo CreateSingle<T>(string name, TryParseDelegate<T> parser, HttpHeaderKind headerKind, Func<Object, string> toString = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parser);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref headerKind;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(toString);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeaderInfo.MethodInfoStoreGeneric_CreateSingle_Public_Static_HeaderInfo_String_TryParseDelegate_1_T_HttpHeaderKind_Func_2_Object_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<HeaderInfo>(intPtr3) : null;
		}

		// Token: 0x06000211 RID: 529 RVA: 0x0000C698 File Offset: 0x0000A898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173540, XrefRangeEnd = 1173544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HeaderInfo CreateMulti<T>(string name, TryParseListDelegate<T> elementParser, HttpHeaderKind headerKind, int minimalCount = 1, string separator = ", ") where T : class
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(elementParser);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref headerKind;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minimalCount;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(separator);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeaderInfo.MethodInfoStoreGeneric_CreateMulti_Public_Static_HeaderInfo_String_TryParseListDelegate_1_T_HttpHeaderKind_Int32_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<HeaderInfo>(intPtr3) : null;
		}

		// Token: 0x06000212 RID: 530 RVA: 0x0000C720 File Offset: 0x0000A920
		[CallerCount(0)]
		public unsafe Object CreateCollection(HttpHeaders headers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(headers);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeaderInfo.NativeMethodInfoPtr_CreateCollection_Public_Object_HttpHeaders_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000213 RID: 531 RVA: 0x0000C770 File Offset: 0x0000A970
		// (set) Token: 0x06000214 RID: 532 RVA: 0x0000C7B0 File Offset: 0x0000A9B0
		public unsafe Func<Object, string> CustomToString
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeaderInfo.NativeMethodInfoPtr_get_CustomToString_Public_get_Func_2_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<Object, string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeaderInfo.NativeMethodInfoPtr_set_CustomToString_Private_set_Void_Func_2_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000215 RID: 533 RVA: 0x0000C7F4 File Offset: 0x0000A9F4
		public unsafe virtual string Separator
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173544, XrefRangeEnd = 1173549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HeaderInfo.NativeMethodInfoPtr_get_Separator_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000216 RID: 534 RVA: 0x0000C838 File Offset: 0x0000AA38
		[CallerCount(0)]
		public unsafe virtual void AddToCollection(Object collection, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collection);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HeaderInfo.NativeMethodInfoPtr_AddToCollection_Public_Abstract_Virtual_New_Void_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000217 RID: 535 RVA: 0x0000C898 File Offset: 0x0000AA98
		[CallerCount(0)]
		public unsafe virtual Object CreateCollection(HttpHeaders headers, HeaderInfo headerInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(headers);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(headerInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HeaderInfo.NativeMethodInfoPtr_CreateCollection_Protected_Abstract_Virtual_New_Object_HttpHeaders_HeaderInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000218 RID: 536 RVA: 0x0000C908 File Offset: 0x0000AB08
		[CallerCount(0)]
		public unsafe virtual List<string> ToStringCollection(Object collection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collection);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HeaderInfo.NativeMethodInfoPtr_ToStringCollection_Public_Abstract_Virtual_New_List_1_String_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
		}

		// Token: 0x06000219 RID: 537 RVA: 0x0000C964 File Offset: 0x0000AB64
		[CallerCount(0)]
		public unsafe virtual bool TryParse(string value, out Object result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HeaderInfo.NativeMethodInfoPtr_TryParse_Public_Abstract_Virtual_New_Boolean_String_byref_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			result = ((intPtr4 == 0) ? null : new Object(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00002D46 File Offset: 0x00000F46
		public HeaderInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x0600021B RID: 539 RVA: 0x0000C9E0 File Offset: 0x0000ABE0
		// (set) Token: 0x0600021C RID: 540 RVA: 0x00002D4F File Offset: 0x00000F4F
		public unsafe bool AllowsMany
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeaderInfo.NativeFieldInfoPtr_AllowsMany);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeaderInfo.NativeFieldInfoPtr_AllowsMany)) = value;
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x0600021D RID: 541 RVA: 0x0000CA08 File Offset: 0x0000AC08
		// (set) Token: 0x0600021E RID: 542 RVA: 0x00002D6A File Offset: 0x00000F6A
		public unsafe HttpHeaderKind HeaderKind
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeaderInfo.NativeFieldInfoPtr_HeaderKind);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeaderInfo.NativeFieldInfoPtr_HeaderKind)) = value;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x0600021F RID: 543 RVA: 0x0000CA30 File Offset: 0x0000AC30
		// (set) Token: 0x06000220 RID: 544 RVA: 0x00002D85 File Offset: 0x00000F85
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeaderInfo.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeaderInfo.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000221 RID: 545 RVA: 0x0000CA58 File Offset: 0x0000AC58
		// (set) Token: 0x06000222 RID: 546 RVA: 0x00002DA4 File Offset: 0x00000FA4
		public unsafe Func<Object, string> _CustomToString_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeaderInfo.NativeFieldInfoPtr__CustomToString_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Object, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeaderInfo.NativeFieldInfoPtr__CustomToString_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000172 RID: 370
		private static readonly IntPtr NativeFieldInfoPtr_AllowsMany;

		// Token: 0x04000173 RID: 371
		private static readonly IntPtr NativeFieldInfoPtr_HeaderKind;

		// Token: 0x04000174 RID: 372
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x04000175 RID: 373
		private static readonly IntPtr NativeFieldInfoPtr__CustomToString_k__BackingField;

		// Token: 0x04000176 RID: 374
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_String_HttpHeaderKind_0;

		// Token: 0x04000177 RID: 375
		private static readonly IntPtr NativeMethodInfoPtr_CreateSingle_Public_Static_HeaderInfo_String_TryParseDelegate_1_T_HttpHeaderKind_Func_2_Object_String_0;

		// Token: 0x04000178 RID: 376
		private static readonly IntPtr NativeMethodInfoPtr_CreateMulti_Public_Static_HeaderInfo_String_TryParseListDelegate_1_T_HttpHeaderKind_Int32_String_0;

		// Token: 0x04000179 RID: 377
		private static readonly IntPtr NativeMethodInfoPtr_CreateCollection_Public_Object_HttpHeaders_0;

		// Token: 0x0400017A RID: 378
		private static readonly IntPtr NativeMethodInfoPtr_get_CustomToString_Public_get_Func_2_Object_String_0;

		// Token: 0x0400017B RID: 379
		private static readonly IntPtr NativeMethodInfoPtr_set_CustomToString_Private_set_Void_Func_2_Object_String_0;

		// Token: 0x0400017C RID: 380
		private static readonly IntPtr NativeMethodInfoPtr_get_Separator_Public_Virtual_New_get_String_0;

		// Token: 0x0400017D RID: 381
		private static readonly IntPtr NativeMethodInfoPtr_AddToCollection_Public_Abstract_Virtual_New_Void_Object_Object_0;

		// Token: 0x0400017E RID: 382
		private static readonly IntPtr NativeMethodInfoPtr_CreateCollection_Protected_Abstract_Virtual_New_Object_HttpHeaders_HeaderInfo_0;

		// Token: 0x0400017F RID: 383
		private static readonly IntPtr NativeMethodInfoPtr_ToStringCollection_Public_Abstract_Virtual_New_List_1_String_Object_0;

		// Token: 0x04000180 RID: 384
		private static readonly IntPtr NativeMethodInfoPtr_TryParse_Public_Abstract_Virtual_New_Boolean_String_byref_Object_0;

		// Token: 0x0200004D RID: 77
		public class HeaderTypeInfo<T, U> : HeaderInfo where U : class
		{
			// Token: 0x0600048B RID: 1163 RVA: 0x00015E60 File Offset: 0x00014060
			// Note: this type is marked as 'beforefieldinit'.
			static HeaderTypeInfo()
			{
				Il2CppClassPointerStore<HeaderInfo.HeaderTypeInfo<T, U>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HeaderInfo>.NativeClassPtr, "HeaderTypeInfo`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HeaderInfo.HeaderTypeInfo<T, U>>.NativeClassPtr);
				HeaderInfo.HeaderTypeInfo<T, U>.NativeFieldInfoPtr_parser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeaderInfo.HeaderTypeInfo<T, U>>.NativeClassPtr, "parser");
				HeaderInfo.HeaderTypeInfo<T, U>.NativeMethodInfoPtr__ctor_Public_Void_String_TryParseDelegate_1_T_HttpHeaderKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeaderInfo.HeaderTypeInfo<T, U>>.NativeClassPtr, 100663602);
				HeaderInfo.HeaderTypeInfo<T, U>.NativeMethodInfoPtr_AddToCollection_Public_Virtual_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeaderInfo.HeaderTypeInfo<T, U>>.NativeClassPtr, 100663603);
				HeaderInfo.HeaderTypeInfo<T, U>.NativeMethodInfoPtr_CreateCollection_Protected_Virtual_Object_HttpHeaders_HeaderInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeaderInfo.HeaderTypeInfo<T, U>>.NativeClassPtr, 100663604);
				HeaderInfo.HeaderTypeInfo<T, U>.NativeMethodInfoPtr_ToStringCollection_Public_Virtual_List_1_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeaderInfo.HeaderTypeInfo<T, U>>.NativeClassPtr, 100663605);
				HeaderInfo.HeaderTypeInfo<T, U>.NativeMethodInfoPtr_TryParse_Public_Virtual_Boolean_String_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeaderInfo.HeaderTypeInfo<T, U>>.NativeClassPtr, 100663606);
			}

			// Token: 0x0600048C RID: 1164 RVA: 0x00015F50 File Offset: 0x00014150
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1173480, RefRangeEnd = 1173482, XrefRangeStart = 1173478, XrefRangeEnd = 1173480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe HeaderTypeInfo(string name, TryParseDelegate<T> parser, HttpHeaderKind headerKind)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HeaderInfo.HeaderTypeInfo<T, U>>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parser);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref headerKind;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeaderInfo.HeaderTypeInfo<T, U>.NativeMethodInfoPtr__ctor_Public_Void_String_TryParseDelegate_1_T_HttpHeaderKind_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600048D RID: 1165 RVA: 0x00015FBC File Offset: 0x000141BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173482, XrefRangeEnd = 1173490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void AddToCollection(Object collection, Object value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(collection);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HeaderInfo.HeaderTypeInfo<T, U>.NativeMethodInfoPtr_AddToCollection_Public_Virtual_Void_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600048E RID: 1166 RVA: 0x0001601C File Offset: 0x0001421C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173490, XrefRangeEnd = 1173493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Object CreateCollection(HttpHeaders headers, HeaderInfo headerInfo)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(headers);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(headerInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HeaderInfo.HeaderTypeInfo<T, U>.NativeMethodInfoPtr_CreateCollection_Protected_Virtual_Object_HttpHeaders_HeaderInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}

			// Token: 0x0600048F RID: 1167 RVA: 0x0001608C File Offset: 0x0001428C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173493, XrefRangeEnd = 1173523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override List<string> ToStringCollection(Object collection)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(collection);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HeaderInfo.HeaderTypeInfo<T, U>.NativeMethodInfoPtr_ToStringCollection_Public_Virtual_List_1_String_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
				}
			}

			// Token: 0x06000490 RID: 1168 RVA: 0x000160E8 File Offset: 0x000142E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173523, XrefRangeEnd = 1173525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool TryParse(string value, out Object result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				}
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HeaderInfo.HeaderTypeInfo<T, U>.NativeMethodInfoPtr_TryParse_Public_Virtual_Boolean_String_byref_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				result = ((intPtr4 == 0) ? null : new Object(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			// Token: 0x06000491 RID: 1169 RVA: 0x00003EF8 File Offset: 0x000020F8
			public HeaderTypeInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700015F RID: 351
			// (get) Token: 0x06000492 RID: 1170 RVA: 0x00016164 File Offset: 0x00014364
			// (set) Token: 0x06000493 RID: 1171 RVA: 0x00003F01 File Offset: 0x00002101
			public unsafe TryParseDelegate<T> parser
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeaderInfo.HeaderTypeInfo<T, U>.NativeFieldInfoPtr_parser);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TryParseDelegate<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeaderInfo.HeaderTypeInfo<T, U>.NativeFieldInfoPtr_parser), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000330 RID: 816
			private static readonly IntPtr NativeFieldInfoPtr_parser;

			// Token: 0x04000331 RID: 817
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_TryParseDelegate_1_T_HttpHeaderKind_0;

			// Token: 0x04000332 RID: 818
			private static readonly IntPtr NativeMethodInfoPtr_AddToCollection_Public_Virtual_Void_Object_Object_0;

			// Token: 0x04000333 RID: 819
			private static readonly IntPtr NativeMethodInfoPtr_CreateCollection_Protected_Virtual_Object_HttpHeaders_HeaderInfo_0;

			// Token: 0x04000334 RID: 820
			private static readonly IntPtr NativeMethodInfoPtr_ToStringCollection_Public_Virtual_List_1_String_Object_0;

			// Token: 0x04000335 RID: 821
			private static readonly IntPtr NativeMethodInfoPtr_TryParse_Public_Virtual_Boolean_String_byref_Object_0;
		}

		// Token: 0x0200004E RID: 78
		public class CollectionHeaderTypeInfo<T, U> : HeaderInfo.HeaderTypeInfo<T, U> where U : class
		{
			// Token: 0x06000494 RID: 1172 RVA: 0x00016194 File Offset: 0x00014394
			// Note: this type is marked as 'beforefieldinit'.
			static CollectionHeaderTypeInfo()
			{
				Il2CppClassPointerStore<HeaderInfo.CollectionHeaderTypeInfo<T, U>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HeaderInfo>.NativeClassPtr, "CollectionHeaderTypeInfo`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HeaderInfo.CollectionHeaderTypeInfo<T, U>>.NativeClassPtr);
				HeaderInfo.CollectionHeaderTypeInfo<T, U>.NativeFieldInfoPtr_minimalCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeaderInfo.CollectionHeaderTypeInfo<T, U>>.NativeClassPtr, "minimalCount");
				HeaderInfo.CollectionHeaderTypeInfo<T, U>.NativeFieldInfoPtr_separator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeaderInfo.CollectionHeaderTypeInfo<T, U>>.NativeClassPtr, "separator");
				HeaderInfo.CollectionHeaderTypeInfo<T, U>.NativeFieldInfoPtr_parser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeaderInfo.CollectionHeaderTypeInfo<T, U>>.NativeClassPtr, "parser");
				HeaderInfo.CollectionHeaderTypeInfo<T, U>.NativeMethodInfoPtr__ctor_Public_Void_String_TryParseListDelegate_1_T_HttpHeaderKind_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeaderInfo.CollectionHeaderTypeInfo<T, U>>.NativeClassPtr, 100663607);
				HeaderInfo.CollectionHeaderTypeInfo<T, U>.NativeMethodInfoPtr_get_Separator_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeaderInfo.CollectionHeaderTypeInfo<T, U>>.NativeClassPtr, 100663608);
				HeaderInfo.CollectionHeaderTypeInfo<T, U>.NativeMethodInfoPtr_TryParse_Public_Virtual_Boolean_String_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeaderInfo.CollectionHeaderTypeInfo<T, U>>.NativeClassPtr, 100663609);
			}

			// Token: 0x06000495 RID: 1173 RVA: 0x00016284 File Offset: 0x00014484
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1173530, RefRangeEnd = 1173531, XrefRangeStart = 1173525, XrefRangeEnd = 1173530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CollectionHeaderTypeInfo(string name, TryParseListDelegate<T> parser, HttpHeaderKind headerKind, int minimalCount, string separator)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HeaderInfo.CollectionHeaderTypeInfo<T, U>>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parser);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref headerKind;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minimalCount;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(separator);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeaderInfo.CollectionHeaderTypeInfo<T, U>.NativeMethodInfoPtr__ctor_Public_Void_String_TryParseListDelegate_1_T_HttpHeaderKind_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000163 RID: 355
			// (get) Token: 0x06000496 RID: 1174 RVA: 0x00016310 File Offset: 0x00014510
			public unsafe override string Separator
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HeaderInfo.CollectionHeaderTypeInfo<T, U>.NativeMethodInfoPtr_get_Separator_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06000497 RID: 1175 RVA: 0x00016354 File Offset: 0x00014554
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173531, XrefRangeEnd = 1173532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool TryParse(string value, out Object result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				}
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HeaderInfo.CollectionHeaderTypeInfo<T, U>.NativeMethodInfoPtr_TryParse_Public_Virtual_Boolean_String_byref_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				result = ((intPtr4 == 0) ? null : new Object(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			// Token: 0x06000498 RID: 1176 RVA: 0x00003F20 File Offset: 0x00002120
			public CollectionHeaderTypeInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000160 RID: 352
			// (get) Token: 0x06000499 RID: 1177 RVA: 0x000163D0 File Offset: 0x000145D0
			// (set) Token: 0x0600049A RID: 1178 RVA: 0x00003F29 File Offset: 0x00002129
			public unsafe int minimalCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeaderInfo.CollectionHeaderTypeInfo<T, U>.NativeFieldInfoPtr_minimalCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeaderInfo.CollectionHeaderTypeInfo<T, U>.NativeFieldInfoPtr_minimalCount)) = value;
				}
			}

			// Token: 0x17000161 RID: 353
			// (get) Token: 0x0600049B RID: 1179 RVA: 0x000163F8 File Offset: 0x000145F8
			// (set) Token: 0x0600049C RID: 1180 RVA: 0x00003F44 File Offset: 0x00002144
			public unsafe string separator
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeaderInfo.CollectionHeaderTypeInfo<T, U>.NativeFieldInfoPtr_separator);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeaderInfo.CollectionHeaderTypeInfo<T, U>.NativeFieldInfoPtr_separator), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000162 RID: 354
			// (get) Token: 0x0600049D RID: 1181 RVA: 0x00016420 File Offset: 0x00014620
			// (set) Token: 0x0600049E RID: 1182 RVA: 0x00003F63 File Offset: 0x00002163
			public new unsafe TryParseListDelegate<T> parser
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeaderInfo.CollectionHeaderTypeInfo<T, U>.NativeFieldInfoPtr_parser);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TryParseListDelegate<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeaderInfo.CollectionHeaderTypeInfo<T, U>.NativeFieldInfoPtr_parser), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000336 RID: 822
			private static readonly IntPtr NativeFieldInfoPtr_minimalCount;

			// Token: 0x04000337 RID: 823
			private static readonly IntPtr NativeFieldInfoPtr_separator;

			// Token: 0x04000338 RID: 824
			private static readonly IntPtr NativeFieldInfoPtr_parser;

			// Token: 0x04000339 RID: 825
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_TryParseListDelegate_1_T_HttpHeaderKind_Int32_String_0;

			// Token: 0x0400033A RID: 826
			private static readonly IntPtr NativeMethodInfoPtr_get_Separator_Public_Virtual_get_String_0;

			// Token: 0x0400033B RID: 827
			private static readonly IntPtr NativeMethodInfoPtr_TryParse_Public_Virtual_Boolean_String_byref_Object_0;
		}

		// Token: 0x0200004F RID: 79
		private sealed class MethodInfoStoreGeneric_CreateSingle_Public_Static_HeaderInfo_String_TryParseDelegate_1_T_HttpHeaderKind_Func_2_Object_String_0<T>
		{
			// Token: 0x0400033C RID: 828
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(HeaderInfo.NativeMethodInfoPtr_CreateSingle_Public_Static_HeaderInfo_String_TryParseDelegate_1_T_HttpHeaderKind_Func_2_Object_String_0, Il2CppClassPointerStore<HeaderInfo>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000050 RID: 80
		private sealed class MethodInfoStoreGeneric_CreateMulti_Public_Static_HeaderInfo_String_TryParseListDelegate_1_T_HttpHeaderKind_Int32_String_0<T>
		{
			// Token: 0x0400033D RID: 829
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(HeaderInfo.NativeMethodInfoPtr_CreateMulti_Public_Static_HeaderInfo_String_TryParseListDelegate_1_T_HttpHeaderKind_Int32_String_0, Il2CppClassPointerStore<HeaderInfo>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
