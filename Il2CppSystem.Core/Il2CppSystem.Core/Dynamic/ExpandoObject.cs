using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.ComponentModel;
using Il2CppSystem.Linq.Expressions;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Dynamic
{
	// Token: 0x0200011D RID: 285
	public sealed class ExpandoObject : Object
	{
		// Token: 0x060010D3 RID: 4307 RVA: 0x000583F4 File Offset: 0x000565F4
		// Note: this type is marked as 'beforefieldinit'.
		static ExpandoObject()
		{
			Il2CppClassPointerStore<ExpandoObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Dynamic", "ExpandoObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExpandoObject>.NativeClassPtr);
			ExpandoObject.NativeFieldInfoPtr_s_expandoTryGetValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandoObject>.NativeClassPtr, "s_expandoTryGetValue");
			ExpandoObject.NativeFieldInfoPtr_s_expandoTrySetValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandoObject>.NativeClassPtr, "s_expandoTrySetValue");
			ExpandoObject.NativeFieldInfoPtr_s_expandoTryDeleteValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandoObject>.NativeClassPtr, "s_expandoTryDeleteValue");
			ExpandoObject.NativeFieldInfoPtr_s_expandoPromoteClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandoObject>.NativeClassPtr, "s_expandoPromoteClass");
			ExpandoObject.NativeFieldInfoPtr_s_expandoCheckVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandoObject>.NativeClassPtr, "s_expandoCheckVersion");
			ExpandoObject.NativeFieldInfoPtr_LockObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandoObject>.NativeClassPtr, "LockObject");
			ExpandoObject.NativeFieldInfoPtr__data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandoObject>.NativeClassPtr, "_data");
			ExpandoObject.NativeFieldInfoPtr__count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandoObject>.NativeClassPtr, "_count");
			ExpandoObject.NativeFieldInfoPtr_Uninitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandoObject>.NativeClassPtr, "Uninitialized");
			ExpandoObject.NativeFieldInfoPtr__propertyChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandoObject>.NativeClassPtr, "_propertyChanged");
			ExpandoObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject>.NativeClassPtr, 100666437);
			ExpandoObject.NativeMethodInfoPtr_TryGetValue_Internal_Boolean_Object_Int32_String_Boolean_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject>.NativeClassPtr, 100666438);
			ExpandoObject.NativeMethodInfoPtr_TrySetValue_Internal_Void_Object_Int32_Object_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject>.NativeClassPtr, 100666439);
			ExpandoObject.NativeMethodInfoPtr_TryDeleteValue_Internal_Boolean_Object_Int32_String_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject>.NativeClassPtr, 100666440);
			ExpandoObject.NativeMethodInfoPtr_IsDeletedMember_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject>.NativeClassPtr, 100666441);
			ExpandoObject.NativeMethodInfoPtr_get_Class_Internal_get_ExpandoClass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject>.NativeClassPtr, 100666442);
			ExpandoObject.NativeMethodInfoPtr_PromoteClassCore_Private_ExpandoData_ExpandoClass_ExpandoClass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject>.NativeClassPtr, 100666443);
			ExpandoObject.NativeMethodInfoPtr_PromoteClass_Internal_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject>.NativeClassPtr, 100666444);
			ExpandoObject.NativeMethodInfoPtr_System_Dynamic_IDynamicMetaObjectProvider_GetMetaObject_Private_Virtual_Final_New_DynamicMetaObject_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject>.NativeClassPtr, 100666445);
			ExpandoObject.NativeMethodInfoPtr_TryAddMember_Private_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject>.NativeClassPtr, 100666446);
			ExpandoObject.NativeMethodInfoPtr_TryGetValueForKey_Private_Boolean_String_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject>.NativeClassPtr, 100666447);
			ExpandoObject.NativeMethodInfoPtr_ExpandoContainsKey_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject>.NativeClassPtr, 100666448);
			ExpandoObject.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ICollection_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject>.NativeClassPtr, 100666449);
			ExpandoObject.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ICollection_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject>.NativeClassPtr, 100666450);
			ExpandoObject.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject>.NativeClassPtr, 100666451);
			ExpandoObject.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_set_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject>.NativeClassPtr, 100666452);
			ExpandoObject.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject>.NativeClassPtr, 100666453);
			ExpandoObject.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject>.NativeClassPtr, 100666454);
			ExpandoObject.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_String_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject>.NativeClassPtr, 100666455);
			ExpandoObject.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_String_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject>.NativeClassPtr, 100666456);
			ExpandoObject.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject>.NativeClassPtr, 100666457);
			ExpandoObject.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject>.NativeClassPtr, 100666458);
			ExpandoObject.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_KeyValuePair_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject>.NativeClassPtr, 100666459);
			ExpandoObject.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject>.NativeClassPtr, 100666460);
			ExpandoObject.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject>.NativeClassPtr, 100666461);
			ExpandoObject.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_Il2CppReferenceArray_1_KeyValuePair_2_String_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject>.NativeClassPtr, 100666462);
			ExpandoObject.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_String_Object_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject>.NativeClassPtr, 100666463);
			ExpandoObject.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject>.NativeClassPtr, 100666464);
			ExpandoObject.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject>.NativeClassPtr, 100666465);
			ExpandoObject.NativeMethodInfoPtr_GetExpandoEnumerator_Private_IEnumerator_1_KeyValuePair_2_String_Object_ExpandoData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject>.NativeClassPtr, 100666466);
		}

		// Token: 0x060010D4 RID: 4308 RVA: 0x00058744 File Offset: 0x00056944
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1029269, RefRangeEnd = 1029270, XrefRangeStart = 1029258, XrefRangeEnd = 1029269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExpandoObject()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExpandoObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010D5 RID: 4309 RVA: 0x00058780 File Offset: 0x00056980
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1029279, RefRangeEnd = 1029284, XrefRangeStart = 1029270, XrefRangeEnd = 1029279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetValue(Object indexClass, int index, string name, bool ignoreCase, out Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(indexClass);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.NativeMethodInfoPtr_TryGetValue_Internal_Boolean_Object_Int32_String_Boolean_byref_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			value = ((intPtr4 == 0) ? null : new Object(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060010D6 RID: 4310 RVA: 0x00058820 File Offset: 0x00056A20
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1029308, RefRangeEnd = 1029311, XrefRangeStart = 1029284, XrefRangeEnd = 1029308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TrySetValue(Object indexClass, int index, Object value, string name, bool ignoreCase, bool add)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(indexClass);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref add;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.NativeMethodInfoPtr_TrySetValue_Internal_Void_Object_Int32_Object_String_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010D7 RID: 4311 RVA: 0x000588B4 File Offset: 0x00056AB4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1029340, RefRangeEnd = 1029343, XrefRangeStart = 1029311, XrefRangeEnd = 1029340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryDeleteValue(Object indexClass, int index, string name, bool ignoreCase, Object deleteValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(indexClass);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(deleteValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.NativeMethodInfoPtr_TryDeleteValue_Internal_Boolean_Object_Int32_String_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010D8 RID: 4312 RVA: 0x00058944 File Offset: 0x00056B44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1029349, RefRangeEnd = 1029350, XrefRangeStart = 1029343, XrefRangeEnd = 1029349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsDeletedMember(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.NativeMethodInfoPtr_IsDeletedMember_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x060010D9 RID: 4313 RVA: 0x00058990 File Offset: 0x00056B90
		public unsafe ExpandoClass Class
		{
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 373350, RefRangeEnd = 373371, XrefRangeStart = 373350, XrefRangeEnd = 373371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.NativeMethodInfoPtr_get_Class_Internal_get_ExpandoClass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExpandoClass>(intPtr3) : null;
			}
		}

		// Token: 0x060010DA RID: 4314 RVA: 0x000589D0 File Offset: 0x00056BD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1029352, RefRangeEnd = 1029353, XrefRangeStart = 1029350, XrefRangeEnd = 1029352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExpandoObject.ExpandoData PromoteClassCore(ExpandoClass oldClass, ExpandoClass newClass)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(oldClass);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newClass);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.NativeMethodInfoPtr_PromoteClassCore_Private_ExpandoData_ExpandoClass_ExpandoClass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExpandoObject.ExpandoData>(intPtr3) : null;
		}

		// Token: 0x060010DB RID: 4315 RVA: 0x00058A34 File Offset: 0x00056C34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1029362, RefRangeEnd = 1029363, XrefRangeStart = 1029353, XrefRangeEnd = 1029362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PromoteClass(Object oldClass, Object newClass)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(oldClass);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newClass);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.NativeMethodInfoPtr_PromoteClass_Internal_Void_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010DC RID: 4316 RVA: 0x00058A88 File Offset: 0x00056C88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1029363, XrefRangeEnd = 1029367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynamicMetaObject System_Dynamic_IDynamicMetaObjectProvider_GetMetaObject(Expression parameter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parameter);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.NativeMethodInfoPtr_System_Dynamic_IDynamicMetaObjectProvider_GetMetaObject_Private_Virtual_Final_New_DynamicMetaObject_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicMetaObject>(intPtr3) : null;
			}
		}

		// Token: 0x060010DD RID: 4317 RVA: 0x00058AD8 File Offset: 0x00056CD8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1029371, RefRangeEnd = 1029373, XrefRangeStart = 1029367, XrefRangeEnd = 1029371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryAddMember(string key, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.NativeMethodInfoPtr_TryAddMember_Private_Void_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010DE RID: 4318 RVA: 0x00058B2C File Offset: 0x00056D2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1029373, XrefRangeEnd = 1029374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetValueForKey(string key, out Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.NativeMethodInfoPtr_TryGetValueForKey_Private_Boolean_String_byref_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			value = ((intPtr4 == 0) ? null : new Object(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060010DF RID: 4319 RVA: 0x00058B9C File Offset: 0x00056D9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1029374, XrefRangeEnd = 1029375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ExpandoContainsKey(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.NativeMethodInfoPtr_ExpandoContainsKey_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x060010E0 RID: 4320 RVA: 0x00058BEC File Offset: 0x00056DEC
		public unsafe ICollection<string> prop_ICollection_1_String_0
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1029375, XrefRangeEnd = 1029379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ICollection_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection<string>>(intPtr3) : null;
			}
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x060010E1 RID: 4321 RVA: 0x00058C2C File Offset: 0x00056E2C
		public unsafe ICollection<Object> prop_ICollection_1_Object_0
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1029379, XrefRangeEnd = 1029383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ICollection_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x060010E2 RID: 4322 RVA: 0x00058C6C File Offset: 0x00056E6C
		// (set) Token: 0x060010E3 RID: 4323 RVA: 0x00058CBC File Offset: 0x00056EBC
		public unsafe Object prop_Object_0
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1029383, XrefRangeEnd = 1029384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1029384, XrefRangeEnd = 1029388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_set_Void_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010E4 RID: 4324 RVA: 0x00058D10 File Offset: 0x00056F10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1029388, XrefRangeEnd = 1029389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Virtual_Final_New_Void_String_Object_0(string key, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010E5 RID: 4325 RVA: 0x00058D64 File Offset: 0x00056F64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1029389, XrefRangeEnd = 1029394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Method_Private_Virtual_Final_New_Boolean_String_0(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010E6 RID: 4326 RVA: 0x00058DB4 File Offset: 0x00056FB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1029394, XrefRangeEnd = 1029402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Method_Private_Virtual_Final_New_Boolean_String_1(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_String_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010E7 RID: 4327 RVA: 0x00058E04 File Offset: 0x00057004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Method_Private_Virtual_Final_New_Boolean_String_byref_Object_0(string key, out Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_String_byref_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			value = ((intPtr4 == 0) ? null : new Object(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x060010E8 RID: 4328 RVA: 0x00058E74 File Offset: 0x00057074
		public unsafe int prop_Int32_0
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x060010E9 RID: 4329 RVA: 0x00058EB0 File Offset: 0x000570B0
		public unsafe bool prop_Boolean_0
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010EA RID: 4330 RVA: 0x00058EEC File Offset: 0x000570EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1029402, XrefRangeEnd = 1029405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Virtual_Final_New_Void_KeyValuePair_2_String_Object_0(KeyValuePair<string, Object> item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(item));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_KeyValuePair_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010EB RID: 4331 RVA: 0x00058F34 File Offset: 0x00057134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1029405, XrefRangeEnd = 1029423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Virtual_Final_New_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010EC RID: 4332 RVA: 0x00058F68 File Offset: 0x00057168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1029423, XrefRangeEnd = 1029427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_String_Object_0(KeyValuePair<string, Object> item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(item));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010ED RID: 4333 RVA: 0x00058FBC File Offset: 0x000571BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1029427, XrefRangeEnd = 1029459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Virtual_Final_New_Void_Il2CppReferenceArray_1_KeyValuePair_2_String_Object_Int32_0(Il2CppReferenceArray<KeyValuePair<string, Object>> array, int arrayIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arrayIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_Il2CppReferenceArray_1_KeyValuePair_2_String_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010EE RID: 4334 RVA: 0x0005900C File Offset: 0x0005720C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1029459, XrefRangeEnd = 1029462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_String_Object_1(KeyValuePair<string, Object> item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(item));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_String_Object_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010EF RID: 4335 RVA: 0x00059060 File Offset: 0x00057260
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1029462, XrefRangeEnd = 1029464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator<KeyValuePair<string, Object>> Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_String_Object_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<KeyValuePair<string, Object>>>(intPtr3) : null;
		}

		// Token: 0x060010F0 RID: 4336 RVA: 0x000590A0 File Offset: 0x000572A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060010F1 RID: 4337 RVA: 0x000590E0 File Offset: 0x000572E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1029470, RefRangeEnd = 1029472, XrefRangeStart = 1029464, XrefRangeEnd = 1029470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator<KeyValuePair<string, Object>> GetExpandoEnumerator(ExpandoObject.ExpandoData data, int version)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref version;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.NativeMethodInfoPtr_GetExpandoEnumerator_Private_IEnumerator_1_KeyValuePair_2_String_Object_ExpandoData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<KeyValuePair<string, Object>>>(intPtr3) : null;
		}

		// Token: 0x060010F2 RID: 4338 RVA: 0x000072C7 File Offset: 0x000054C7
		public ExpandoObject(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x060010F3 RID: 4339 RVA: 0x00059140 File Offset: 0x00057340
		// (set) Token: 0x060010F4 RID: 4340 RVA: 0x000072D0 File Offset: 0x000054D0
		public unsafe static MethodInfo s_expandoTryGetValue
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExpandoObject.NativeFieldInfoPtr_s_expandoTryGetValue, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExpandoObject.NativeFieldInfoPtr_s_expandoTryGetValue, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x060010F5 RID: 4341 RVA: 0x00059168 File Offset: 0x00057368
		// (set) Token: 0x060010F6 RID: 4342 RVA: 0x000072E2 File Offset: 0x000054E2
		public unsafe static MethodInfo s_expandoTrySetValue
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExpandoObject.NativeFieldInfoPtr_s_expandoTrySetValue, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExpandoObject.NativeFieldInfoPtr_s_expandoTrySetValue, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x060010F7 RID: 4343 RVA: 0x00059190 File Offset: 0x00057390
		// (set) Token: 0x060010F8 RID: 4344 RVA: 0x000072F4 File Offset: 0x000054F4
		public unsafe static MethodInfo s_expandoTryDeleteValue
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExpandoObject.NativeFieldInfoPtr_s_expandoTryDeleteValue, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExpandoObject.NativeFieldInfoPtr_s_expandoTryDeleteValue, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x060010F9 RID: 4345 RVA: 0x000591B8 File Offset: 0x000573B8
		// (set) Token: 0x060010FA RID: 4346 RVA: 0x00007306 File Offset: 0x00005506
		public unsafe static MethodInfo s_expandoPromoteClass
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExpandoObject.NativeFieldInfoPtr_s_expandoPromoteClass, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExpandoObject.NativeFieldInfoPtr_s_expandoPromoteClass, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x060010FB RID: 4347 RVA: 0x000591E0 File Offset: 0x000573E0
		// (set) Token: 0x060010FC RID: 4348 RVA: 0x00007318 File Offset: 0x00005518
		public unsafe static MethodInfo s_expandoCheckVersion
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExpandoObject.NativeFieldInfoPtr_s_expandoCheckVersion, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExpandoObject.NativeFieldInfoPtr_s_expandoCheckVersion, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x060010FD RID: 4349 RVA: 0x00059208 File Offset: 0x00057408
		// (set) Token: 0x060010FE RID: 4350 RVA: 0x0000732A File Offset: 0x0000552A
		public unsafe Object LockObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoObject.NativeFieldInfoPtr_LockObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoObject.NativeFieldInfoPtr_LockObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x060010FF RID: 4351 RVA: 0x00059238 File Offset: 0x00057438
		// (set) Token: 0x06001100 RID: 4352 RVA: 0x00007349 File Offset: 0x00005549
		public unsafe ExpandoObject.ExpandoData _data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoObject.NativeFieldInfoPtr__data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExpandoObject.ExpandoData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoObject.NativeFieldInfoPtr__data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x06001101 RID: 4353 RVA: 0x00059268 File Offset: 0x00057468
		// (set) Token: 0x06001102 RID: 4354 RVA: 0x00007368 File Offset: 0x00005568
		public unsafe int _count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoObject.NativeFieldInfoPtr__count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoObject.NativeFieldInfoPtr__count)) = value;
			}
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x06001103 RID: 4355 RVA: 0x00059290 File Offset: 0x00057490
		// (set) Token: 0x06001104 RID: 4356 RVA: 0x00007383 File Offset: 0x00005583
		public unsafe static Object Uninitialized
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExpandoObject.NativeFieldInfoPtr_Uninitialized, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExpandoObject.NativeFieldInfoPtr_Uninitialized, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x06001105 RID: 4357 RVA: 0x000592B8 File Offset: 0x000574B8
		// (set) Token: 0x06001106 RID: 4358 RVA: 0x00007395 File Offset: 0x00005595
		public unsafe PropertyChangedEventHandler _propertyChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoObject.NativeFieldInfoPtr__propertyChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertyChangedEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoObject.NativeFieldInfoPtr__propertyChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C15 RID: 3093
		private static readonly IntPtr NativeFieldInfoPtr_s_expandoTryGetValue;

		// Token: 0x04000C16 RID: 3094
		private static readonly IntPtr NativeFieldInfoPtr_s_expandoTrySetValue;

		// Token: 0x04000C17 RID: 3095
		private static readonly IntPtr NativeFieldInfoPtr_s_expandoTryDeleteValue;

		// Token: 0x04000C18 RID: 3096
		private static readonly IntPtr NativeFieldInfoPtr_s_expandoPromoteClass;

		// Token: 0x04000C19 RID: 3097
		private static readonly IntPtr NativeFieldInfoPtr_s_expandoCheckVersion;

		// Token: 0x04000C1A RID: 3098
		private static readonly IntPtr NativeFieldInfoPtr_LockObject;

		// Token: 0x04000C1B RID: 3099
		private static readonly IntPtr NativeFieldInfoPtr__data;

		// Token: 0x04000C1C RID: 3100
		private static readonly IntPtr NativeFieldInfoPtr__count;

		// Token: 0x04000C1D RID: 3101
		private static readonly IntPtr NativeFieldInfoPtr_Uninitialized;

		// Token: 0x04000C1E RID: 3102
		private static readonly IntPtr NativeFieldInfoPtr__propertyChanged;

		// Token: 0x04000C1F RID: 3103
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000C20 RID: 3104
		private static readonly IntPtr NativeMethodInfoPtr_TryGetValue_Internal_Boolean_Object_Int32_String_Boolean_byref_Object_0;

		// Token: 0x04000C21 RID: 3105
		private static readonly IntPtr NativeMethodInfoPtr_TrySetValue_Internal_Void_Object_Int32_Object_String_Boolean_Boolean_0;

		// Token: 0x04000C22 RID: 3106
		private static readonly IntPtr NativeMethodInfoPtr_TryDeleteValue_Internal_Boolean_Object_Int32_String_Boolean_Object_0;

		// Token: 0x04000C23 RID: 3107
		private static readonly IntPtr NativeMethodInfoPtr_IsDeletedMember_Internal_Boolean_Int32_0;

		// Token: 0x04000C24 RID: 3108
		private static readonly IntPtr NativeMethodInfoPtr_get_Class_Internal_get_ExpandoClass_0;

		// Token: 0x04000C25 RID: 3109
		private static readonly IntPtr NativeMethodInfoPtr_PromoteClassCore_Private_ExpandoData_ExpandoClass_ExpandoClass_0;

		// Token: 0x04000C26 RID: 3110
		private static readonly IntPtr NativeMethodInfoPtr_PromoteClass_Internal_Void_Object_Object_0;

		// Token: 0x04000C27 RID: 3111
		private static readonly IntPtr NativeMethodInfoPtr_System_Dynamic_IDynamicMetaObjectProvider_GetMetaObject_Private_Virtual_Final_New_DynamicMetaObject_Expression_0;

		// Token: 0x04000C28 RID: 3112
		private static readonly IntPtr NativeMethodInfoPtr_TryAddMember_Private_Void_String_Object_0;

		// Token: 0x04000C29 RID: 3113
		private static readonly IntPtr NativeMethodInfoPtr_TryGetValueForKey_Private_Boolean_String_byref_Object_0;

		// Token: 0x04000C2A RID: 3114
		private static readonly IntPtr NativeMethodInfoPtr_ExpandoContainsKey_Private_Boolean_String_0;

		// Token: 0x04000C2B RID: 3115
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ICollection_1_String_0;

		// Token: 0x04000C2C RID: 3116
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ICollection_1_Object_0;

		// Token: 0x04000C2D RID: 3117
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Object_String_0;

		// Token: 0x04000C2E RID: 3118
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_set_Void_String_Object_0;

		// Token: 0x04000C2F RID: 3119
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_String_Object_0;

		// Token: 0x04000C30 RID: 3120
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_String_0;

		// Token: 0x04000C31 RID: 3121
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_String_1;

		// Token: 0x04000C32 RID: 3122
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_String_byref_Object_0;

		// Token: 0x04000C33 RID: 3123
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000C34 RID: 3124
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000C35 RID: 3125
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_KeyValuePair_2_String_Object_0;

		// Token: 0x04000C36 RID: 3126
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_0;

		// Token: 0x04000C37 RID: 3127
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_String_Object_0;

		// Token: 0x04000C38 RID: 3128
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_Il2CppReferenceArray_1_KeyValuePair_2_String_Object_Int32_0;

		// Token: 0x04000C39 RID: 3129
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_String_Object_1;

		// Token: 0x04000C3A RID: 3130
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_String_Object_0;

		// Token: 0x04000C3B RID: 3131
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x04000C3C RID: 3132
		private static readonly IntPtr NativeMethodInfoPtr_GetExpandoEnumerator_Private_IEnumerator_1_KeyValuePair_2_String_Object_ExpandoData_Int32_0;

		// Token: 0x02000343 RID: 835
		public sealed class KeyCollectionDebugView : Object
		{
			// Token: 0x06001BAA RID: 7082 RVA: 0x0000A8D0 File Offset: 0x00008AD0
			// Note: this type is marked as 'beforefieldinit'.
			static KeyCollectionDebugView()
			{
				Il2CppClassPointerStore<ExpandoObject.KeyCollectionDebugView>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ExpandoObject>.NativeClassPtr, "KeyCollectionDebugView");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExpandoObject.KeyCollectionDebugView>.NativeClassPtr);
			}

			// Token: 0x06001BAB RID: 7083 RVA: 0x0000A8F0 File Offset: 0x00008AF0
			public KeyCollectionDebugView(IntPtr pointer)
				: base(pointer)
			{
			}
		}

		// Token: 0x02000344 RID: 836
		public class KeyCollection : Object
		{
			// Token: 0x06001BAC RID: 7084 RVA: 0x00082FC8 File Offset: 0x000811C8
			// Note: this type is marked as 'beforefieldinit'.
			static KeyCollection()
			{
				Il2CppClassPointerStore<ExpandoObject.KeyCollection>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ExpandoObject>.NativeClassPtr, "KeyCollection");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExpandoObject.KeyCollection>.NativeClassPtr);
				ExpandoObject.KeyCollection.NativeFieldInfoPtr__expando = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandoObject.KeyCollection>.NativeClassPtr, "_expando");
				ExpandoObject.KeyCollection.NativeFieldInfoPtr__expandoVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandoObject.KeyCollection>.NativeClassPtr, "_expandoVersion");
				ExpandoObject.KeyCollection.NativeFieldInfoPtr__expandoCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandoObject.KeyCollection>.NativeClassPtr, "_expandoCount");
				ExpandoObject.KeyCollection.NativeFieldInfoPtr__expandoData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandoObject.KeyCollection>.NativeClassPtr, "_expandoData");
				ExpandoObject.KeyCollection.NativeMethodInfoPtr__ctor_Internal_Void_ExpandoObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject.KeyCollection>.NativeClassPtr, 100666468);
				ExpandoObject.KeyCollection.NativeMethodInfoPtr_CheckVersion_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject.KeyCollection>.NativeClassPtr, 100666469);
				ExpandoObject.KeyCollection.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject.KeyCollection>.NativeClassPtr, 100666470);
				ExpandoObject.KeyCollection.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject.KeyCollection>.NativeClassPtr, 100666471);
				ExpandoObject.KeyCollection.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject.KeyCollection>.NativeClassPtr, 100666472);
				ExpandoObject.KeyCollection.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject.KeyCollection>.NativeClassPtr, 100666473);
				ExpandoObject.KeyCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject.KeyCollection>.NativeClassPtr, 100666474);
				ExpandoObject.KeyCollection.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject.KeyCollection>.NativeClassPtr, 100666475);
				ExpandoObject.KeyCollection.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject.KeyCollection>.NativeClassPtr, 100666476);
				ExpandoObject.KeyCollection.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject.KeyCollection>.NativeClassPtr, 100666477);
				ExpandoObject.KeyCollection.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject.KeyCollection>.NativeClassPtr, 100666478);
			}

			// Token: 0x06001BAD RID: 7085 RVA: 0x00083120 File Offset: 0x00081320
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1028733, RefRangeEnd = 1028735, XrefRangeStart = 1028726, XrefRangeEnd = 1028733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe KeyCollection(ExpandoObject expando)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExpandoObject.KeyCollection>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(expando);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.KeyCollection.NativeMethodInfoPtr__ctor_Internal_Void_ExpandoObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001BAE RID: 7086 RVA: 0x0008316C File Offset: 0x0008136C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1028735, RefRangeEnd = 1028736, XrefRangeStart = 1028735, XrefRangeEnd = 1028735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CheckVersion()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.KeyCollection.NativeMethodInfoPtr_CheckVersion_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001BAF RID: 7087 RVA: 0x000831A0 File Offset: 0x000813A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028736, XrefRangeEnd = 1028739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Add(string item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(item);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.KeyCollection.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001BB0 RID: 7088 RVA: 0x000831E4 File Offset: 0x000813E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028739, XrefRangeEnd = 1028742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Clear()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.KeyCollection.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001BB1 RID: 7089 RVA: 0x00083218 File Offset: 0x00081418
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028742, XrefRangeEnd = 1028747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool Contains(string item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(item);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.KeyCollection.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001BB2 RID: 7090 RVA: 0x00083268 File Offset: 0x00081468
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028747, XrefRangeEnd = 1028768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void CopyTo(Il2CppStringArray array, int arrayIndex)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arrayIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.KeyCollection.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppStringArray_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170006FD RID: 1789
			// (get) Token: 0x06001BB3 RID: 7091 RVA: 0x000832B8 File Offset: 0x000814B8
			public unsafe virtual int Count
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.KeyCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170006FE RID: 1790
			// (get) Token: 0x06001BB4 RID: 7092 RVA: 0x000832F4 File Offset: 0x000814F4
			public unsafe virtual bool IsReadOnly
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.KeyCollection.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001BB5 RID: 7093 RVA: 0x00083330 File Offset: 0x00081530
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028768, XrefRangeEnd = 1028771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool Remove(string item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(item);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.KeyCollection.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001BB6 RID: 7094 RVA: 0x00083380 File Offset: 0x00081580
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028771, XrefRangeEnd = 1028776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual IEnumerator<string> GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.KeyCollection.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<string>>(intPtr3) : null;
			}

			// Token: 0x06001BB7 RID: 7095 RVA: 0x000833C0 File Offset: 0x000815C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.KeyCollection.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06001BB8 RID: 7096 RVA: 0x0000A8F9 File Offset: 0x00008AF9
			public KeyCollection(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006F9 RID: 1785
			// (get) Token: 0x06001BB9 RID: 7097 RVA: 0x00083400 File Offset: 0x00081600
			// (set) Token: 0x06001BBA RID: 7098 RVA: 0x0000A902 File Offset: 0x00008B02
			public unsafe ExpandoObject _expando
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoObject.KeyCollection.NativeFieldInfoPtr__expando);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExpandoObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoObject.KeyCollection.NativeFieldInfoPtr__expando), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006FA RID: 1786
			// (get) Token: 0x06001BBB RID: 7099 RVA: 0x00083430 File Offset: 0x00081630
			// (set) Token: 0x06001BBC RID: 7100 RVA: 0x0000A921 File Offset: 0x00008B21
			public unsafe int _expandoVersion
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoObject.KeyCollection.NativeFieldInfoPtr__expandoVersion);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoObject.KeyCollection.NativeFieldInfoPtr__expandoVersion)) = value;
				}
			}

			// Token: 0x170006FB RID: 1787
			// (get) Token: 0x06001BBD RID: 7101 RVA: 0x00083458 File Offset: 0x00081658
			// (set) Token: 0x06001BBE RID: 7102 RVA: 0x0000A93C File Offset: 0x00008B3C
			public unsafe int _expandoCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoObject.KeyCollection.NativeFieldInfoPtr__expandoCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoObject.KeyCollection.NativeFieldInfoPtr__expandoCount)) = value;
				}
			}

			// Token: 0x170006FC RID: 1788
			// (get) Token: 0x06001BBF RID: 7103 RVA: 0x00083480 File Offset: 0x00081680
			// (set) Token: 0x06001BC0 RID: 7104 RVA: 0x0000A957 File Offset: 0x00008B57
			public unsafe ExpandoObject.ExpandoData _expandoData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoObject.KeyCollection.NativeFieldInfoPtr__expandoData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExpandoObject.ExpandoData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoObject.KeyCollection.NativeFieldInfoPtr__expandoData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040012AE RID: 4782
			private static readonly IntPtr NativeFieldInfoPtr__expando;

			// Token: 0x040012AF RID: 4783
			private static readonly IntPtr NativeFieldInfoPtr__expandoVersion;

			// Token: 0x040012B0 RID: 4784
			private static readonly IntPtr NativeFieldInfoPtr__expandoCount;

			// Token: 0x040012B1 RID: 4785
			private static readonly IntPtr NativeFieldInfoPtr__expandoData;

			// Token: 0x040012B2 RID: 4786
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ExpandoObject_0;

			// Token: 0x040012B3 RID: 4787
			private static readonly IntPtr NativeMethodInfoPtr_CheckVersion_Private_Void_0;

			// Token: 0x040012B4 RID: 4788
			private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_String_0;

			// Token: 0x040012B5 RID: 4789
			private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0;

			// Token: 0x040012B6 RID: 4790
			private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_String_0;

			// Token: 0x040012B7 RID: 4791
			private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppStringArray_Int32_0;

			// Token: 0x040012B8 RID: 4792
			private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

			// Token: 0x040012B9 RID: 4793
			private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0;

			// Token: 0x040012BA RID: 4794
			private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_String_0;

			// Token: 0x040012BB RID: 4795
			private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_String_0;

			// Token: 0x040012BC RID: 4796
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

			// Token: 0x0200036D RID: 877
			[ObfuscatedName("System.Dynamic.ExpandoObject+KeyCollection+<GetEnumerator>d__15")]
			public sealed class _GetEnumerator_d__15 : Object
			{
				// Token: 0x06001C8B RID: 7307 RVA: 0x00086374 File Offset: 0x00084574
				// Note: this type is marked as 'beforefieldinit'.
				static _GetEnumerator_d__15()
				{
					Il2CppClassPointerStore<ExpandoObject.KeyCollection._GetEnumerator_d__15>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ExpandoObject.KeyCollection>.NativeClassPtr, "<GetEnumerator>d__15");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExpandoObject.KeyCollection._GetEnumerator_d__15>.NativeClassPtr);
					ExpandoObject.KeyCollection._GetEnumerator_d__15.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandoObject.KeyCollection._GetEnumerator_d__15>.NativeClassPtr, "<>1__state");
					ExpandoObject.KeyCollection._GetEnumerator_d__15.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandoObject.KeyCollection._GetEnumerator_d__15>.NativeClassPtr, "<>2__current");
					ExpandoObject.KeyCollection._GetEnumerator_d__15.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandoObject.KeyCollection._GetEnumerator_d__15>.NativeClassPtr, "<>4__this");
					ExpandoObject.KeyCollection._GetEnumerator_d__15.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandoObject.KeyCollection._GetEnumerator_d__15>.NativeClassPtr, "<i>5__2");
					ExpandoObject.KeyCollection._GetEnumerator_d__15.NativeFieldInfoPtr__n_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandoObject.KeyCollection._GetEnumerator_d__15>.NativeClassPtr, "<n>5__3");
					ExpandoObject.KeyCollection._GetEnumerator_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject.KeyCollection._GetEnumerator_d__15>.NativeClassPtr, 100666479);
					ExpandoObject.KeyCollection._GetEnumerator_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject.KeyCollection._GetEnumerator_d__15>.NativeClassPtr, 100666480);
					ExpandoObject.KeyCollection._GetEnumerator_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject.KeyCollection._GetEnumerator_d__15>.NativeClassPtr, 100666481);
					ExpandoObject.KeyCollection._GetEnumerator_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_String__get_Current_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject.KeyCollection._GetEnumerator_d__15>.NativeClassPtr, 100666482);
					ExpandoObject.KeyCollection._GetEnumerator_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject.KeyCollection._GetEnumerator_d__15>.NativeClassPtr, 100666483);
					ExpandoObject.KeyCollection._GetEnumerator_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject.KeyCollection._GetEnumerator_d__15>.NativeClassPtr, 100666484);
				}

				// Token: 0x06001C8C RID: 7308 RVA: 0x0008647C File Offset: 0x0008467C
				[CallerCount(73)]
				[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe _GetEnumerator_d__15(int <>1__state)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExpandoObject.KeyCollection._GetEnumerator_d__15>.NativeClassPtr))
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref <>1__state;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.KeyCollection._GetEnumerator_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06001C8D RID: 7309 RVA: 0x000864C4 File Offset: 0x000846C4
				[CallerCount(21425)]
				[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.KeyCollection._GetEnumerator_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001C8E RID: 7310 RVA: 0x000864F8 File Offset: 0x000846F8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028714, XrefRangeEnd = 1028721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.KeyCollection._GetEnumerator_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17000738 RID: 1848
				// (get) Token: 0x06001C8F RID: 7311 RVA: 0x00086534 File Offset: 0x00084734
				public unsafe string System.Collections.Generic.IEnumerator<System.String>.Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.KeyCollection._GetEnumerator_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_String__get_Current_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x06001C90 RID: 7312 RVA: 0x0008656C File Offset: 0x0008476C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028721, XrefRangeEnd = 1028726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.KeyCollection._GetEnumerator_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17000739 RID: 1849
				// (get) Token: 0x06001C91 RID: 7313 RVA: 0x000865A0 File Offset: 0x000847A0
				public unsafe Object System.Collections.IEnumerator.Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.KeyCollection._GetEnumerator_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}

				// Token: 0x06001C92 RID: 7314 RVA: 0x0000AEA9 File Offset: 0x000090A9
				public _GetEnumerator_d__15(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000733 RID: 1843
				// (get) Token: 0x06001C93 RID: 7315 RVA: 0x000865E0 File Offset: 0x000847E0
				// (set) Token: 0x06001C94 RID: 7316 RVA: 0x0000AEB2 File Offset: 0x000090B2
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoObject.KeyCollection._GetEnumerator_d__15.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoObject.KeyCollection._GetEnumerator_d__15.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17000734 RID: 1844
				// (get) Token: 0x06001C95 RID: 7317 RVA: 0x00086608 File Offset: 0x00084808
				// (set) Token: 0x06001C96 RID: 7318 RVA: 0x0000AECD File Offset: 0x000090CD
				public unsafe string __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoObject.KeyCollection._GetEnumerator_d__15.NativeFieldInfoPtr___2__current);
						return IL2CPP.Il2CppStringToManaged(*intPtr);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoObject.KeyCollection._GetEnumerator_d__15.NativeFieldInfoPtr___2__current), IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x17000735 RID: 1845
				// (get) Token: 0x06001C97 RID: 7319 RVA: 0x00086630 File Offset: 0x00084830
				// (set) Token: 0x06001C98 RID: 7320 RVA: 0x0000AEEC File Offset: 0x000090EC
				public unsafe ExpandoObject.KeyCollection __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoObject.KeyCollection._GetEnumerator_d__15.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExpandoObject.KeyCollection>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoObject.KeyCollection._GetEnumerator_d__15.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000736 RID: 1846
				// (get) Token: 0x06001C99 RID: 7321 RVA: 0x00086660 File Offset: 0x00084860
				// (set) Token: 0x06001C9A RID: 7322 RVA: 0x0000AF0B File Offset: 0x0000910B
				public unsafe int _i_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoObject.KeyCollection._GetEnumerator_d__15.NativeFieldInfoPtr__i_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoObject.KeyCollection._GetEnumerator_d__15.NativeFieldInfoPtr__i_5__2)) = value;
					}
				}

				// Token: 0x17000737 RID: 1847
				// (get) Token: 0x06001C9B RID: 7323 RVA: 0x00086688 File Offset: 0x00084888
				// (set) Token: 0x06001C9C RID: 7324 RVA: 0x0000AF26 File Offset: 0x00009126
				public unsafe int _n_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoObject.KeyCollection._GetEnumerator_d__15.NativeFieldInfoPtr__n_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoObject.KeyCollection._GetEnumerator_d__15.NativeFieldInfoPtr__n_5__3)) = value;
					}
				}

				// Token: 0x0400133A RID: 4922
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400133B RID: 4923
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400133C RID: 4924
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400133D RID: 4925
				private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

				// Token: 0x0400133E RID: 4926
				private static readonly IntPtr NativeFieldInfoPtr__n_5__3;

				// Token: 0x0400133F RID: 4927
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04001340 RID: 4928
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04001341 RID: 4929
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04001342 RID: 4930
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_String__get_Current_Private_Virtual_Final_New_get_String_0;

				// Token: 0x04001343 RID: 4931
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04001344 RID: 4932
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000345 RID: 837
		public sealed class ValueCollectionDebugView : Object
		{
			// Token: 0x06001BC1 RID: 7105 RVA: 0x0000A976 File Offset: 0x00008B76
			// Note: this type is marked as 'beforefieldinit'.
			static ValueCollectionDebugView()
			{
				Il2CppClassPointerStore<ExpandoObject.ValueCollectionDebugView>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ExpandoObject>.NativeClassPtr, "ValueCollectionDebugView");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExpandoObject.ValueCollectionDebugView>.NativeClassPtr);
			}

			// Token: 0x06001BC2 RID: 7106 RVA: 0x0000A996 File Offset: 0x00008B96
			public ValueCollectionDebugView(IntPtr pointer)
				: base(pointer)
			{
			}
		}

		// Token: 0x02000346 RID: 838
		public class ValueCollection : Object
		{
			// Token: 0x06001BC3 RID: 7107 RVA: 0x000834B0 File Offset: 0x000816B0
			// Note: this type is marked as 'beforefieldinit'.
			static ValueCollection()
			{
				Il2CppClassPointerStore<ExpandoObject.ValueCollection>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ExpandoObject>.NativeClassPtr, "ValueCollection");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExpandoObject.ValueCollection>.NativeClassPtr);
				ExpandoObject.ValueCollection.NativeFieldInfoPtr__expando = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandoObject.ValueCollection>.NativeClassPtr, "_expando");
				ExpandoObject.ValueCollection.NativeFieldInfoPtr__expandoVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandoObject.ValueCollection>.NativeClassPtr, "_expandoVersion");
				ExpandoObject.ValueCollection.NativeFieldInfoPtr__expandoCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandoObject.ValueCollection>.NativeClassPtr, "_expandoCount");
				ExpandoObject.ValueCollection.NativeFieldInfoPtr__expandoData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandoObject.ValueCollection>.NativeClassPtr, "_expandoData");
				ExpandoObject.ValueCollection.NativeMethodInfoPtr__ctor_Internal_Void_ExpandoObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject.ValueCollection>.NativeClassPtr, 100666485);
				ExpandoObject.ValueCollection.NativeMethodInfoPtr_CheckVersion_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject.ValueCollection>.NativeClassPtr, 100666486);
				ExpandoObject.ValueCollection.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject.ValueCollection>.NativeClassPtr, 100666487);
				ExpandoObject.ValueCollection.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject.ValueCollection>.NativeClassPtr, 100666488);
				ExpandoObject.ValueCollection.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject.ValueCollection>.NativeClassPtr, 100666489);
				ExpandoObject.ValueCollection.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppReferenceArray_1_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject.ValueCollection>.NativeClassPtr, 100666490);
				ExpandoObject.ValueCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject.ValueCollection>.NativeClassPtr, 100666491);
				ExpandoObject.ValueCollection.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject.ValueCollection>.NativeClassPtr, 100666492);
				ExpandoObject.ValueCollection.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject.ValueCollection>.NativeClassPtr, 100666493);
				ExpandoObject.ValueCollection.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject.ValueCollection>.NativeClassPtr, 100666494);
				ExpandoObject.ValueCollection.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject.ValueCollection>.NativeClassPtr, 100666495);
			}

			// Token: 0x06001BC4 RID: 7108 RVA: 0x00083608 File Offset: 0x00081808
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1028733, RefRangeEnd = 1028735, XrefRangeStart = 1028733, XrefRangeEnd = 1028735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueCollection(ExpandoObject expando)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExpandoObject.ValueCollection>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(expando);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.ValueCollection.NativeMethodInfoPtr__ctor_Internal_Void_ExpandoObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001BC5 RID: 7109 RVA: 0x00083654 File Offset: 0x00081854
			[CallerCount(0)]
			public unsafe void CheckVersion()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.ValueCollection.NativeMethodInfoPtr_CheckVersion_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001BC6 RID: 7110 RVA: 0x00083688 File Offset: 0x00081888
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028788, XrefRangeEnd = 1028791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Add(Object item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.ValueCollection.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001BC7 RID: 7111 RVA: 0x000836CC File Offset: 0x000818CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028791, XrefRangeEnd = 1028794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Clear()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.ValueCollection.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001BC8 RID: 7112 RVA: 0x00083700 File Offset: 0x00081900
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028794, XrefRangeEnd = 1028802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool Contains(Object item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.ValueCollection.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001BC9 RID: 7113 RVA: 0x00083750 File Offset: 0x00081950
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028802, XrefRangeEnd = 1028822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void CopyTo(Il2CppReferenceArray<Object> array, int arrayIndex)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arrayIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.ValueCollection.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppReferenceArray_1_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000703 RID: 1795
			// (get) Token: 0x06001BCA RID: 7114 RVA: 0x000837A0 File Offset: 0x000819A0
			public unsafe virtual int Count
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.ValueCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000704 RID: 1796
			// (get) Token: 0x06001BCB RID: 7115 RVA: 0x000837DC File Offset: 0x000819DC
			public unsafe virtual bool IsReadOnly
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.ValueCollection.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001BCC RID: 7116 RVA: 0x00083818 File Offset: 0x00081A18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028822, XrefRangeEnd = 1028825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool Remove(Object item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.ValueCollection.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001BCD RID: 7117 RVA: 0x00083868 File Offset: 0x00081A68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028825, XrefRangeEnd = 1028830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual IEnumerator<Object> GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.ValueCollection.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Object>>(intPtr3) : null;
			}

			// Token: 0x06001BCE RID: 7118 RVA: 0x000838A8 File Offset: 0x00081AA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.ValueCollection.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06001BCF RID: 7119 RVA: 0x0000A99F File Offset: 0x00008B9F
			public ValueCollection(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006FF RID: 1791
			// (get) Token: 0x06001BD0 RID: 7120 RVA: 0x000838E8 File Offset: 0x00081AE8
			// (set) Token: 0x06001BD1 RID: 7121 RVA: 0x0000A9A8 File Offset: 0x00008BA8
			public unsafe ExpandoObject _expando
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoObject.ValueCollection.NativeFieldInfoPtr__expando);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExpandoObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoObject.ValueCollection.NativeFieldInfoPtr__expando), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000700 RID: 1792
			// (get) Token: 0x06001BD2 RID: 7122 RVA: 0x00083918 File Offset: 0x00081B18
			// (set) Token: 0x06001BD3 RID: 7123 RVA: 0x0000A9C7 File Offset: 0x00008BC7
			public unsafe int _expandoVersion
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoObject.ValueCollection.NativeFieldInfoPtr__expandoVersion);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoObject.ValueCollection.NativeFieldInfoPtr__expandoVersion)) = value;
				}
			}

			// Token: 0x17000701 RID: 1793
			// (get) Token: 0x06001BD4 RID: 7124 RVA: 0x00083940 File Offset: 0x00081B40
			// (set) Token: 0x06001BD5 RID: 7125 RVA: 0x0000A9E2 File Offset: 0x00008BE2
			public unsafe int _expandoCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoObject.ValueCollection.NativeFieldInfoPtr__expandoCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoObject.ValueCollection.NativeFieldInfoPtr__expandoCount)) = value;
				}
			}

			// Token: 0x17000702 RID: 1794
			// (get) Token: 0x06001BD6 RID: 7126 RVA: 0x00083968 File Offset: 0x00081B68
			// (set) Token: 0x06001BD7 RID: 7127 RVA: 0x0000A9FD File Offset: 0x00008BFD
			public unsafe ExpandoObject.ExpandoData _expandoData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoObject.ValueCollection.NativeFieldInfoPtr__expandoData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExpandoObject.ExpandoData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoObject.ValueCollection.NativeFieldInfoPtr__expandoData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040012BD RID: 4797
			private static readonly IntPtr NativeFieldInfoPtr__expando;

			// Token: 0x040012BE RID: 4798
			private static readonly IntPtr NativeFieldInfoPtr__expandoVersion;

			// Token: 0x040012BF RID: 4799
			private static readonly IntPtr NativeFieldInfoPtr__expandoCount;

			// Token: 0x040012C0 RID: 4800
			private static readonly IntPtr NativeFieldInfoPtr__expandoData;

			// Token: 0x040012C1 RID: 4801
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ExpandoObject_0;

			// Token: 0x040012C2 RID: 4802
			private static readonly IntPtr NativeMethodInfoPtr_CheckVersion_Private_Void_0;

			// Token: 0x040012C3 RID: 4803
			private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_Object_0;

			// Token: 0x040012C4 RID: 4804
			private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0;

			// Token: 0x040012C5 RID: 4805
			private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_Object_0;

			// Token: 0x040012C6 RID: 4806
			private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppReferenceArray_1_Object_Int32_0;

			// Token: 0x040012C7 RID: 4807
			private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

			// Token: 0x040012C8 RID: 4808
			private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0;

			// Token: 0x040012C9 RID: 4809
			private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_Object_0;

			// Token: 0x040012CA RID: 4810
			private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_Object_0;

			// Token: 0x040012CB RID: 4811
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

			// Token: 0x0200036E RID: 878
			[ObfuscatedName("System.Dynamic.ExpandoObject+ValueCollection+<GetEnumerator>d__15")]
			public sealed class _GetEnumerator_d__15 : Object
			{
				// Token: 0x06001C9D RID: 7325 RVA: 0x000866B0 File Offset: 0x000848B0
				// Note: this type is marked as 'beforefieldinit'.
				static _GetEnumerator_d__15()
				{
					Il2CppClassPointerStore<ExpandoObject.ValueCollection._GetEnumerator_d__15>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ExpandoObject.ValueCollection>.NativeClassPtr, "<GetEnumerator>d__15");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExpandoObject.ValueCollection._GetEnumerator_d__15>.NativeClassPtr);
					ExpandoObject.ValueCollection._GetEnumerator_d__15.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandoObject.ValueCollection._GetEnumerator_d__15>.NativeClassPtr, "<>1__state");
					ExpandoObject.ValueCollection._GetEnumerator_d__15.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandoObject.ValueCollection._GetEnumerator_d__15>.NativeClassPtr, "<>2__current");
					ExpandoObject.ValueCollection._GetEnumerator_d__15.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandoObject.ValueCollection._GetEnumerator_d__15>.NativeClassPtr, "<>4__this");
					ExpandoObject.ValueCollection._GetEnumerator_d__15.NativeFieldInfoPtr__data_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandoObject.ValueCollection._GetEnumerator_d__15>.NativeClassPtr, "<data>5__2");
					ExpandoObject.ValueCollection._GetEnumerator_d__15.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandoObject.ValueCollection._GetEnumerator_d__15>.NativeClassPtr, "<i>5__3");
					ExpandoObject.ValueCollection._GetEnumerator_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject.ValueCollection._GetEnumerator_d__15>.NativeClassPtr, 100666496);
					ExpandoObject.ValueCollection._GetEnumerator_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject.ValueCollection._GetEnumerator_d__15>.NativeClassPtr, 100666497);
					ExpandoObject.ValueCollection._GetEnumerator_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject.ValueCollection._GetEnumerator_d__15>.NativeClassPtr, 100666498);
					ExpandoObject.ValueCollection._GetEnumerator_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject.ValueCollection._GetEnumerator_d__15>.NativeClassPtr, 100666499);
					ExpandoObject.ValueCollection._GetEnumerator_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject.ValueCollection._GetEnumerator_d__15>.NativeClassPtr, 100666500);
					ExpandoObject.ValueCollection._GetEnumerator_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject.ValueCollection._GetEnumerator_d__15>.NativeClassPtr, 100666501);
				}

				// Token: 0x06001C9E RID: 7326 RVA: 0x000867B8 File Offset: 0x000849B8
				[CallerCount(73)]
				[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe _GetEnumerator_d__15(int <>1__state)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExpandoObject.ValueCollection._GetEnumerator_d__15>.NativeClassPtr))
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref <>1__state;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.ValueCollection._GetEnumerator_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06001C9F RID: 7327 RVA: 0x00086800 File Offset: 0x00084A00
				[CallerCount(21425)]
				[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.ValueCollection._GetEnumerator_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001CA0 RID: 7328 RVA: 0x00086834 File Offset: 0x00084A34
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028776, XrefRangeEnd = 1028783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.ValueCollection._GetEnumerator_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x1700073F RID: 1855
				// (get) Token: 0x06001CA1 RID: 7329 RVA: 0x00086870 File Offset: 0x00084A70
				public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.ValueCollection._GetEnumerator_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}

				// Token: 0x06001CA2 RID: 7330 RVA: 0x000868B0 File Offset: 0x00084AB0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028783, XrefRangeEnd = 1028788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.ValueCollection._GetEnumerator_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17000740 RID: 1856
				// (get) Token: 0x06001CA3 RID: 7331 RVA: 0x000868E4 File Offset: 0x00084AE4
				public unsafe Object System.Collections.IEnumerator.Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.ValueCollection._GetEnumerator_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}

				// Token: 0x06001CA4 RID: 7332 RVA: 0x0000AF41 File Offset: 0x00009141
				public _GetEnumerator_d__15(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x1700073A RID: 1850
				// (get) Token: 0x06001CA5 RID: 7333 RVA: 0x00086924 File Offset: 0x00084B24
				// (set) Token: 0x06001CA6 RID: 7334 RVA: 0x0000AF4A File Offset: 0x0000914A
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoObject.ValueCollection._GetEnumerator_d__15.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoObject.ValueCollection._GetEnumerator_d__15.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x1700073B RID: 1851
				// (get) Token: 0x06001CA7 RID: 7335 RVA: 0x0008694C File Offset: 0x00084B4C
				// (set) Token: 0x06001CA8 RID: 7336 RVA: 0x0000AF65 File Offset: 0x00009165
				public unsafe Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoObject.ValueCollection._GetEnumerator_d__15.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoObject.ValueCollection._GetEnumerator_d__15.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700073C RID: 1852
				// (get) Token: 0x06001CA9 RID: 7337 RVA: 0x0008697C File Offset: 0x00084B7C
				// (set) Token: 0x06001CAA RID: 7338 RVA: 0x0000AF84 File Offset: 0x00009184
				public unsafe ExpandoObject.ValueCollection __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoObject.ValueCollection._GetEnumerator_d__15.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExpandoObject.ValueCollection>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoObject.ValueCollection._GetEnumerator_d__15.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700073D RID: 1853
				// (get) Token: 0x06001CAB RID: 7339 RVA: 0x000869AC File Offset: 0x00084BAC
				// (set) Token: 0x06001CAC RID: 7340 RVA: 0x0000AFA3 File Offset: 0x000091A3
				public unsafe ExpandoObject.ExpandoData _data_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoObject.ValueCollection._GetEnumerator_d__15.NativeFieldInfoPtr__data_5__2);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExpandoObject.ExpandoData>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoObject.ValueCollection._GetEnumerator_d__15.NativeFieldInfoPtr__data_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700073E RID: 1854
				// (get) Token: 0x06001CAD RID: 7341 RVA: 0x000869DC File Offset: 0x00084BDC
				// (set) Token: 0x06001CAE RID: 7342 RVA: 0x0000AFC2 File Offset: 0x000091C2
				public unsafe int _i_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoObject.ValueCollection._GetEnumerator_d__15.NativeFieldInfoPtr__i_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoObject.ValueCollection._GetEnumerator_d__15.NativeFieldInfoPtr__i_5__3)) = value;
					}
				}

				// Token: 0x04001345 RID: 4933
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04001346 RID: 4934
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04001347 RID: 4935
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04001348 RID: 4936
				private static readonly IntPtr NativeFieldInfoPtr__data_5__2;

				// Token: 0x04001349 RID: 4937
				private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

				// Token: 0x0400134A RID: 4938
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400134B RID: 4939
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400134C RID: 4940
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400134D RID: 4941
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400134E RID: 4942
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400134F RID: 4943
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000347 RID: 839
		public class MetaExpando : DynamicMetaObject
		{
			// Token: 0x06001BD8 RID: 7128 RVA: 0x00083998 File Offset: 0x00081B98
			// Note: this type is marked as 'beforefieldinit'.
			static MetaExpando()
			{
				Il2CppClassPointerStore<ExpandoObject.MetaExpando>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ExpandoObject>.NativeClassPtr, "MetaExpando");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExpandoObject.MetaExpando>.NativeClassPtr);
				ExpandoObject.MetaExpando.NativeMethodInfoPtr__ctor_Public_Void_Expression_ExpandoObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject.MetaExpando>.NativeClassPtr, 100666502);
				ExpandoObject.MetaExpando.NativeMethodInfoPtr_BindGetOrInvokeMember_Private_DynamicMetaObject_DynamicMetaObjectBinder_String_Boolean_DynamicMetaObject_Func_2_DynamicMetaObject_DynamicMetaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject.MetaExpando>.NativeClassPtr, 100666503);
				ExpandoObject.MetaExpando.NativeMethodInfoPtr_BindGetMember_Public_Virtual_DynamicMetaObject_GetMemberBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject.MetaExpando>.NativeClassPtr, 100666504);
				ExpandoObject.MetaExpando.NativeMethodInfoPtr_BindInvokeMember_Public_Virtual_DynamicMetaObject_InvokeMemberBinder_Il2CppReferenceArray_1_DynamicMetaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject.MetaExpando>.NativeClassPtr, 100666505);
				ExpandoObject.MetaExpando.NativeMethodInfoPtr_BindSetMember_Public_Virtual_DynamicMetaObject_SetMemberBinder_DynamicMetaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject.MetaExpando>.NativeClassPtr, 100666506);
				ExpandoObject.MetaExpando.NativeMethodInfoPtr_BindDeleteMember_Public_Virtual_DynamicMetaObject_DeleteMemberBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject.MetaExpando>.NativeClassPtr, 100666507);
				ExpandoObject.MetaExpando.NativeMethodInfoPtr_GetDynamicMemberNames_Public_Virtual_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject.MetaExpando>.NativeClassPtr, 100666508);
				ExpandoObject.MetaExpando.NativeMethodInfoPtr_AddDynamicTestAndDefer_Private_DynamicMetaObject_DynamicMetaObjectBinder_ExpandoClass_ExpandoClass_DynamicMetaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject.MetaExpando>.NativeClassPtr, 100666509);
				ExpandoObject.MetaExpando.NativeMethodInfoPtr_GetClassEnsureIndex_Private_ExpandoClass_String_Boolean_ExpandoObject_byref_ExpandoClass_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject.MetaExpando>.NativeClassPtr, 100666510);
				ExpandoObject.MetaExpando.NativeMethodInfoPtr_GetLimitedSelf_Private_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject.MetaExpando>.NativeClassPtr, 100666511);
				ExpandoObject.MetaExpando.NativeMethodInfoPtr_GetRestrictions_Private_BindingRestrictions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject.MetaExpando>.NativeClassPtr, 100666512);
				ExpandoObject.MetaExpando.NativeMethodInfoPtr_get_Value_Public_get_ExpandoObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject.MetaExpando>.NativeClassPtr, 100666513);
			}

			// Token: 0x06001BD9 RID: 7129 RVA: 0x00083AB4 File Offset: 0x00081CB4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1028856, RefRangeEnd = 1028857, XrefRangeStart = 1028848, XrefRangeEnd = 1028856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MetaExpando(Expression expression, ExpandoObject value)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExpandoObject.MetaExpando>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(expression);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.MetaExpando.NativeMethodInfoPtr__ctor_Public_Void_Expression_ExpandoObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001BDA RID: 7130 RVA: 0x00083B14 File Offset: 0x00081D14
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1028974, RefRangeEnd = 1028976, XrefRangeStart = 1028857, XrefRangeEnd = 1028974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DynamicMetaObject BindGetOrInvokeMember(DynamicMetaObjectBinder binder, string name, bool ignoreCase, DynamicMetaObject fallback, Func<DynamicMetaObject, DynamicMetaObject> fallbackInvoke)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(binder);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fallback);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fallbackInvoke);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.MetaExpando.NativeMethodInfoPtr_BindGetOrInvokeMember_Private_DynamicMetaObject_DynamicMetaObjectBinder_String_Boolean_DynamicMetaObject_Func_2_DynamicMetaObject_DynamicMetaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicMetaObject>(intPtr3) : null;
			}

			// Token: 0x06001BDB RID: 7131 RVA: 0x00083BAC File Offset: 0x00081DAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028976, XrefRangeEnd = 1028979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override DynamicMetaObject BindGetMember(GetMemberBinder binder)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(binder);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExpandoObject.MetaExpando.NativeMethodInfoPtr_BindGetMember_Public_Virtual_DynamicMetaObject_GetMemberBinder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicMetaObject>(intPtr3) : null;
				}
			}

			// Token: 0x06001BDC RID: 7132 RVA: 0x00083C08 File Offset: 0x00081E08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028979, XrefRangeEnd = 1028994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override DynamicMetaObject BindInvokeMember(InvokeMemberBinder binder, Il2CppReferenceArray<DynamicMetaObject> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(binder);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExpandoObject.MetaExpando.NativeMethodInfoPtr_BindInvokeMember_Public_Virtual_DynamicMetaObject_InvokeMemberBinder_Il2CppReferenceArray_1_DynamicMetaObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicMetaObject>(intPtr3) : null;
			}

			// Token: 0x06001BDD RID: 7133 RVA: 0x00083C78 File Offset: 0x00081E78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028994, XrefRangeEnd = 1029060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override DynamicMetaObject BindSetMember(SetMemberBinder binder, DynamicMetaObject value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(binder);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExpandoObject.MetaExpando.NativeMethodInfoPtr_BindSetMember_Public_Virtual_DynamicMetaObject_SetMemberBinder_DynamicMetaObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicMetaObject>(intPtr3) : null;
			}

			// Token: 0x06001BDE RID: 7134 RVA: 0x00083CE8 File Offset: 0x00081EE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1029060, XrefRangeEnd = 1029108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override DynamicMetaObject BindDeleteMember(DeleteMemberBinder binder)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(binder);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExpandoObject.MetaExpando.NativeMethodInfoPtr_BindDeleteMember_Public_Virtual_DynamicMetaObject_DeleteMemberBinder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicMetaObject>(intPtr3) : null;
				}
			}

			// Token: 0x06001BDF RID: 7135 RVA: 0x00083D44 File Offset: 0x00081F44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1029108, XrefRangeEnd = 1029114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override IEnumerable<string> GetDynamicMemberNames()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExpandoObject.MetaExpando.NativeMethodInfoPtr_GetDynamicMemberNames_Public_Virtual_IEnumerable_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
			}

			// Token: 0x06001BE0 RID: 7136 RVA: 0x00083D90 File Offset: 0x00081F90
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1029157, RefRangeEnd = 1029160, XrefRangeStart = 1029114, XrefRangeEnd = 1029157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DynamicMetaObject AddDynamicTestAndDefer(DynamicMetaObjectBinder binder, ExpandoClass klass, ExpandoClass originalClass, DynamicMetaObject succeeds)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(binder);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(klass);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(originalClass);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(succeeds);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.MetaExpando.NativeMethodInfoPtr_AddDynamicTestAndDefer_Private_DynamicMetaObject_DynamicMetaObjectBinder_ExpandoClass_ExpandoClass_DynamicMetaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicMetaObject>(intPtr3) : null;
			}

			// Token: 0x06001BE1 RID: 7137 RVA: 0x00083E18 File Offset: 0x00082018
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1029160, XrefRangeEnd = 1029168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ExpandoClass GetClassEnsureIndex(string name, bool caseInsensitive, ExpandoObject obj, out ExpandoClass klass, out int index)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref caseInsensitive;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &index;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.MetaExpando.NativeMethodInfoPtr_GetClassEnsureIndex_Private_ExpandoClass_String_Boolean_ExpandoObject_byref_ExpandoClass_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				klass = ((intPtr4 == 0) ? null : new ExpandoClass(intPtr4));
				IntPtr intPtr5 = intPtr2;
				return (intPtr5 != 0) ? Il2CppObjectPool.Get<ExpandoClass>(intPtr5) : null;
			}

			// Token: 0x06001BE2 RID: 7138 RVA: 0x00083EBC File Offset: 0x000820BC
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1029182, RefRangeEnd = 1029187, XrefRangeStart = 1029168, XrefRangeEnd = 1029182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Expression GetLimitedSelf()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.MetaExpando.NativeMethodInfoPtr_GetLimitedSelf_Private_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}

			// Token: 0x06001BE3 RID: 7139 RVA: 0x00083EFC File Offset: 0x000820FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1029187, XrefRangeEnd = 1029191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BindingRestrictions GetRestrictions()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.MetaExpando.NativeMethodInfoPtr_GetRestrictions_Private_BindingRestrictions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BindingRestrictions>(intPtr3) : null;
			}

			// Token: 0x17000705 RID: 1797
			// (get) Token: 0x06001BE4 RID: 7140 RVA: 0x00083F3C File Offset: 0x0008213C
			public new unsafe ExpandoObject Value
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1029191, XrefRangeEnd = 1029194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.MetaExpando.NativeMethodInfoPtr_get_Value_Public_get_ExpandoObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExpandoObject>(intPtr3) : null;
				}
			}

			// Token: 0x06001BE5 RID: 7141 RVA: 0x0000AA1C File Offset: 0x00008C1C
			public MetaExpando(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040012CC RID: 4812
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Expression_ExpandoObject_0;

			// Token: 0x040012CD RID: 4813
			private static readonly IntPtr NativeMethodInfoPtr_BindGetOrInvokeMember_Private_DynamicMetaObject_DynamicMetaObjectBinder_String_Boolean_DynamicMetaObject_Func_2_DynamicMetaObject_DynamicMetaObject_0;

			// Token: 0x040012CE RID: 4814
			private static readonly IntPtr NativeMethodInfoPtr_BindGetMember_Public_Virtual_DynamicMetaObject_GetMemberBinder_0;

			// Token: 0x040012CF RID: 4815
			private static readonly IntPtr NativeMethodInfoPtr_BindInvokeMember_Public_Virtual_DynamicMetaObject_InvokeMemberBinder_Il2CppReferenceArray_1_DynamicMetaObject_0;

			// Token: 0x040012D0 RID: 4816
			private static readonly IntPtr NativeMethodInfoPtr_BindSetMember_Public_Virtual_DynamicMetaObject_SetMemberBinder_DynamicMetaObject_0;

			// Token: 0x040012D1 RID: 4817
			private static readonly IntPtr NativeMethodInfoPtr_BindDeleteMember_Public_Virtual_DynamicMetaObject_DeleteMemberBinder_0;

			// Token: 0x040012D2 RID: 4818
			private static readonly IntPtr NativeMethodInfoPtr_GetDynamicMemberNames_Public_Virtual_IEnumerable_1_String_0;

			// Token: 0x040012D3 RID: 4819
			private static readonly IntPtr NativeMethodInfoPtr_AddDynamicTestAndDefer_Private_DynamicMetaObject_DynamicMetaObjectBinder_ExpandoClass_ExpandoClass_DynamicMetaObject_0;

			// Token: 0x040012D4 RID: 4820
			private static readonly IntPtr NativeMethodInfoPtr_GetClassEnsureIndex_Private_ExpandoClass_String_Boolean_ExpandoObject_byref_ExpandoClass_byref_Int32_0;

			// Token: 0x040012D5 RID: 4821
			private static readonly IntPtr NativeMethodInfoPtr_GetLimitedSelf_Private_Expression_0;

			// Token: 0x040012D6 RID: 4822
			private static readonly IntPtr NativeMethodInfoPtr_GetRestrictions_Private_BindingRestrictions_0;

			// Token: 0x040012D7 RID: 4823
			private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_ExpandoObject_0;

			// Token: 0x0200036F RID: 879
			[ObfuscatedName("System.Dynamic.ExpandoObject+MetaExpando+<>c__DisplayClass3_0")]
			public sealed class __c__DisplayClass3_0 : Object
			{
				// Token: 0x06001CAF RID: 7343 RVA: 0x00086A04 File Offset: 0x00084C04
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass3_0()
				{
					Il2CppClassPointerStore<ExpandoObject.MetaExpando.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ExpandoObject.MetaExpando>.NativeClassPtr, "<>c__DisplayClass3_0");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExpandoObject.MetaExpando.__c__DisplayClass3_0>.NativeClassPtr);
					ExpandoObject.MetaExpando.__c__DisplayClass3_0.NativeFieldInfoPtr_binder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandoObject.MetaExpando.__c__DisplayClass3_0>.NativeClassPtr, "binder");
					ExpandoObject.MetaExpando.__c__DisplayClass3_0.NativeFieldInfoPtr_args = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandoObject.MetaExpando.__c__DisplayClass3_0>.NativeClassPtr, "args");
					ExpandoObject.MetaExpando.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject.MetaExpando.__c__DisplayClass3_0>.NativeClassPtr, 100666514);
					ExpandoObject.MetaExpando.__c__DisplayClass3_0.NativeMethodInfoPtr__BindInvokeMember_b__0_Internal_DynamicMetaObject_DynamicMetaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject.MetaExpando.__c__DisplayClass3_0>.NativeClassPtr, 100666515);
				}

				// Token: 0x06001CB0 RID: 7344 RVA: 0x00086A80 File Offset: 0x00084C80
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass3_0()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExpandoObject.MetaExpando.__c__DisplayClass3_0>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.MetaExpando.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001CB1 RID: 7345 RVA: 0x00086ABC File Offset: 0x00084CBC
				[CallerCount(0)]
				public unsafe DynamicMetaObject _BindInvokeMember_b__0(DynamicMetaObject value)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.MetaExpando.__c__DisplayClass3_0.NativeMethodInfoPtr__BindInvokeMember_b__0_Internal_DynamicMetaObject_DynamicMetaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicMetaObject>(intPtr3) : null;
					}
				}

				// Token: 0x06001CB2 RID: 7346 RVA: 0x0000AFDD File Offset: 0x000091DD
				public __c__DisplayClass3_0(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000741 RID: 1857
				// (get) Token: 0x06001CB3 RID: 7347 RVA: 0x00086B0C File Offset: 0x00084D0C
				// (set) Token: 0x06001CB4 RID: 7348 RVA: 0x0000AFE6 File Offset: 0x000091E6
				public unsafe InvokeMemberBinder binder
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoObject.MetaExpando.__c__DisplayClass3_0.NativeFieldInfoPtr_binder);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<InvokeMemberBinder>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoObject.MetaExpando.__c__DisplayClass3_0.NativeFieldInfoPtr_binder), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000742 RID: 1858
				// (get) Token: 0x06001CB5 RID: 7349 RVA: 0x00086B3C File Offset: 0x00084D3C
				// (set) Token: 0x06001CB6 RID: 7350 RVA: 0x0000B005 File Offset: 0x00009205
				public unsafe Il2CppReferenceArray<DynamicMetaObject> args
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoObject.MetaExpando.__c__DisplayClass3_0.NativeFieldInfoPtr_args);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DynamicMetaObject>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoObject.MetaExpando.__c__DisplayClass3_0.NativeFieldInfoPtr_args), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04001350 RID: 4944
				private static readonly IntPtr NativeFieldInfoPtr_binder;

				// Token: 0x04001351 RID: 4945
				private static readonly IntPtr NativeFieldInfoPtr_args;

				// Token: 0x04001352 RID: 4946
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x04001353 RID: 4947
				private static readonly IntPtr NativeMethodInfoPtr__BindInvokeMember_b__0_Internal_DynamicMetaObject_DynamicMetaObject_0;
			}

			// Token: 0x02000370 RID: 880
			[ObfuscatedName("System.Dynamic.ExpandoObject+MetaExpando+<GetDynamicMemberNames>d__6")]
			public sealed class _GetDynamicMemberNames_d__6 : Object
			{
				// Token: 0x06001CB7 RID: 7351 RVA: 0x00086B6C File Offset: 0x00084D6C
				// Note: this type is marked as 'beforefieldinit'.
				static _GetDynamicMemberNames_d__6()
				{
					Il2CppClassPointerStore<ExpandoObject.MetaExpando._GetDynamicMemberNames_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ExpandoObject.MetaExpando>.NativeClassPtr, "<GetDynamicMemberNames>d__6");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExpandoObject.MetaExpando._GetDynamicMemberNames_d__6>.NativeClassPtr);
					ExpandoObject.MetaExpando._GetDynamicMemberNames_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandoObject.MetaExpando._GetDynamicMemberNames_d__6>.NativeClassPtr, "<>1__state");
					ExpandoObject.MetaExpando._GetDynamicMemberNames_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandoObject.MetaExpando._GetDynamicMemberNames_d__6>.NativeClassPtr, "<>2__current");
					ExpandoObject.MetaExpando._GetDynamicMemberNames_d__6.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandoObject.MetaExpando._GetDynamicMemberNames_d__6>.NativeClassPtr, "<>l__initialThreadId");
					ExpandoObject.MetaExpando._GetDynamicMemberNames_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandoObject.MetaExpando._GetDynamicMemberNames_d__6>.NativeClassPtr, "<>4__this");
					ExpandoObject.MetaExpando._GetDynamicMemberNames_d__6.NativeFieldInfoPtr__expandoData_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandoObject.MetaExpando._GetDynamicMemberNames_d__6>.NativeClassPtr, "<expandoData>5__2");
					ExpandoObject.MetaExpando._GetDynamicMemberNames_d__6.NativeFieldInfoPtr__klass_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandoObject.MetaExpando._GetDynamicMemberNames_d__6>.NativeClassPtr, "<klass>5__3");
					ExpandoObject.MetaExpando._GetDynamicMemberNames_d__6.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandoObject.MetaExpando._GetDynamicMemberNames_d__6>.NativeClassPtr, "<i>5__4");
					ExpandoObject.MetaExpando._GetDynamicMemberNames_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject.MetaExpando._GetDynamicMemberNames_d__6>.NativeClassPtr, 100666516);
					ExpandoObject.MetaExpando._GetDynamicMemberNames_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject.MetaExpando._GetDynamicMemberNames_d__6>.NativeClassPtr, 100666517);
					ExpandoObject.MetaExpando._GetDynamicMemberNames_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject.MetaExpando._GetDynamicMemberNames_d__6>.NativeClassPtr, 100666518);
					ExpandoObject.MetaExpando._GetDynamicMemberNames_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_String__get_Current_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject.MetaExpando._GetDynamicMemberNames_d__6>.NativeClassPtr, 100666519);
					ExpandoObject.MetaExpando._GetDynamicMemberNames_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject.MetaExpando._GetDynamicMemberNames_d__6>.NativeClassPtr, 100666520);
					ExpandoObject.MetaExpando._GetDynamicMemberNames_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject.MetaExpando._GetDynamicMemberNames_d__6>.NativeClassPtr, 100666521);
					ExpandoObject.MetaExpando._GetDynamicMemberNames_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_String__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject.MetaExpando._GetDynamicMemberNames_d__6>.NativeClassPtr, 100666522);
					ExpandoObject.MetaExpando._GetDynamicMemberNames_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject.MetaExpando._GetDynamicMemberNames_d__6>.NativeClassPtr, 100666523);
				}

				// Token: 0x06001CB8 RID: 7352 RVA: 0x00086CC4 File Offset: 0x00084EC4
				[CallerCount(126)]
				[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe _GetDynamicMemberNames_d__6(int <>1__state)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExpandoObject.MetaExpando._GetDynamicMemberNames_d__6>.NativeClassPtr))
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref <>1__state;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.MetaExpando._GetDynamicMemberNames_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06001CB9 RID: 7353 RVA: 0x00086D0C File Offset: 0x00084F0C
				[CallerCount(21425)]
				[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.MetaExpando._GetDynamicMemberNames_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001CBA RID: 7354 RVA: 0x00086D40 File Offset: 0x00084F40
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028830, XrefRangeEnd = 1028841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.MetaExpando._GetDynamicMemberNames_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x1700074A RID: 1866
				// (get) Token: 0x06001CBB RID: 7355 RVA: 0x00086D7C File Offset: 0x00084F7C
				public unsafe string System.Collections.Generic.IEnumerator<System.String>.Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.MetaExpando._GetDynamicMemberNames_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_String__get_Current_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x06001CBC RID: 7356 RVA: 0x00086DB4 File Offset: 0x00084FB4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028841, XrefRangeEnd = 1028846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.MetaExpando._GetDynamicMemberNames_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x1700074B RID: 1867
				// (get) Token: 0x06001CBD RID: 7357 RVA: 0x00086DE8 File Offset: 0x00084FE8
				public unsafe Object System.Collections.IEnumerator.Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.MetaExpando._GetDynamicMemberNames_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}

				// Token: 0x06001CBE RID: 7358 RVA: 0x00086E28 File Offset: 0x00085028
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028846, XrefRangeEnd = 1028848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IEnumerator<string> System_Collections_Generic_IEnumerable_System_String__GetEnumerator()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.MetaExpando._GetDynamicMemberNames_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_String__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<string>>(intPtr3) : null;
				}

				// Token: 0x06001CBF RID: 7359 RVA: 0x00086E68 File Offset: 0x00085068
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.MetaExpando._GetDynamicMemberNames_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
				}

				// Token: 0x06001CC0 RID: 7360 RVA: 0x0000B024 File Offset: 0x00009224
				public _GetDynamicMemberNames_d__6(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000743 RID: 1859
				// (get) Token: 0x06001CC1 RID: 7361 RVA: 0x00086EA8 File Offset: 0x000850A8
				// (set) Token: 0x06001CC2 RID: 7362 RVA: 0x0000B02D File Offset: 0x0000922D
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoObject.MetaExpando._GetDynamicMemberNames_d__6.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoObject.MetaExpando._GetDynamicMemberNames_d__6.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17000744 RID: 1860
				// (get) Token: 0x06001CC3 RID: 7363 RVA: 0x00086ED0 File Offset: 0x000850D0
				// (set) Token: 0x06001CC4 RID: 7364 RVA: 0x0000B048 File Offset: 0x00009248
				public unsafe string __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoObject.MetaExpando._GetDynamicMemberNames_d__6.NativeFieldInfoPtr___2__current);
						return IL2CPP.Il2CppStringToManaged(*intPtr);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoObject.MetaExpando._GetDynamicMemberNames_d__6.NativeFieldInfoPtr___2__current), IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x17000745 RID: 1861
				// (get) Token: 0x06001CC5 RID: 7365 RVA: 0x00086EF8 File Offset: 0x000850F8
				// (set) Token: 0x06001CC6 RID: 7366 RVA: 0x0000B067 File Offset: 0x00009267
				public unsafe int __l__initialThreadId
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoObject.MetaExpando._GetDynamicMemberNames_d__6.NativeFieldInfoPtr___l__initialThreadId);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoObject.MetaExpando._GetDynamicMemberNames_d__6.NativeFieldInfoPtr___l__initialThreadId)) = value;
					}
				}

				// Token: 0x17000746 RID: 1862
				// (get) Token: 0x06001CC7 RID: 7367 RVA: 0x00086F20 File Offset: 0x00085120
				// (set) Token: 0x06001CC8 RID: 7368 RVA: 0x0000B082 File Offset: 0x00009282
				public unsafe ExpandoObject.MetaExpando __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoObject.MetaExpando._GetDynamicMemberNames_d__6.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExpandoObject.MetaExpando>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoObject.MetaExpando._GetDynamicMemberNames_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000747 RID: 1863
				// (get) Token: 0x06001CC9 RID: 7369 RVA: 0x00086F50 File Offset: 0x00085150
				// (set) Token: 0x06001CCA RID: 7370 RVA: 0x0000B0A1 File Offset: 0x000092A1
				public unsafe ExpandoObject.ExpandoData _expandoData_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoObject.MetaExpando._GetDynamicMemberNames_d__6.NativeFieldInfoPtr__expandoData_5__2);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExpandoObject.ExpandoData>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoObject.MetaExpando._GetDynamicMemberNames_d__6.NativeFieldInfoPtr__expandoData_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000748 RID: 1864
				// (get) Token: 0x06001CCB RID: 7371 RVA: 0x00086F80 File Offset: 0x00085180
				// (set) Token: 0x06001CCC RID: 7372 RVA: 0x0000B0C0 File Offset: 0x000092C0
				public unsafe ExpandoClass _klass_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoObject.MetaExpando._GetDynamicMemberNames_d__6.NativeFieldInfoPtr__klass_5__3);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExpandoClass>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoObject.MetaExpando._GetDynamicMemberNames_d__6.NativeFieldInfoPtr__klass_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000749 RID: 1865
				// (get) Token: 0x06001CCD RID: 7373 RVA: 0x00086FB0 File Offset: 0x000851B0
				// (set) Token: 0x06001CCE RID: 7374 RVA: 0x0000B0DF File Offset: 0x000092DF
				public unsafe int _i_5__4
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoObject.MetaExpando._GetDynamicMemberNames_d__6.NativeFieldInfoPtr__i_5__4);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoObject.MetaExpando._GetDynamicMemberNames_d__6.NativeFieldInfoPtr__i_5__4)) = value;
					}
				}

				// Token: 0x04001354 RID: 4948
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04001355 RID: 4949
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04001356 RID: 4950
				private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

				// Token: 0x04001357 RID: 4951
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04001358 RID: 4952
				private static readonly IntPtr NativeFieldInfoPtr__expandoData_5__2;

				// Token: 0x04001359 RID: 4953
				private static readonly IntPtr NativeFieldInfoPtr__klass_5__3;

				// Token: 0x0400135A RID: 4954
				private static readonly IntPtr NativeFieldInfoPtr__i_5__4;

				// Token: 0x0400135B RID: 4955
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400135C RID: 4956
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400135D RID: 4957
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400135E RID: 4958
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_String__get_Current_Private_Virtual_Final_New_get_String_0;

				// Token: 0x0400135F RID: 4959
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04001360 RID: 4960
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04001361 RID: 4961
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_String__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_String_0;

				// Token: 0x04001362 RID: 4962
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
			}
		}

		// Token: 0x02000348 RID: 840
		public class ExpandoData : Object
		{
			// Token: 0x06001BE6 RID: 7142 RVA: 0x00083F7C File Offset: 0x0008217C
			// Note: this type is marked as 'beforefieldinit'.
			static ExpandoData()
			{
				Il2CppClassPointerStore<ExpandoObject.ExpandoData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ExpandoObject>.NativeClassPtr, "ExpandoData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExpandoObject.ExpandoData>.NativeClassPtr);
				ExpandoObject.ExpandoData.NativeFieldInfoPtr_Empty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandoObject.ExpandoData>.NativeClassPtr, "Empty");
				ExpandoObject.ExpandoData.NativeFieldInfoPtr_Class = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandoObject.ExpandoData>.NativeClassPtr, "Class");
				ExpandoObject.ExpandoData.NativeFieldInfoPtr__dataArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandoObject.ExpandoData>.NativeClassPtr, "_dataArray");
				ExpandoObject.ExpandoData.NativeFieldInfoPtr__version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandoObject.ExpandoData>.NativeClassPtr, "_version");
				ExpandoObject.ExpandoData.NativeMethodInfoPtr_get_Item_Internal_get_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject.ExpandoData>.NativeClassPtr, 100666524);
				ExpandoObject.ExpandoData.NativeMethodInfoPtr_set_Item_Internal_set_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject.ExpandoData>.NativeClassPtr, 100666525);
				ExpandoObject.ExpandoData.NativeMethodInfoPtr_get_Version_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject.ExpandoData>.NativeClassPtr, 100666526);
				ExpandoObject.ExpandoData.NativeMethodInfoPtr_get_Length_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject.ExpandoData>.NativeClassPtr, 100666527);
				ExpandoObject.ExpandoData.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject.ExpandoData>.NativeClassPtr, 100666528);
				ExpandoObject.ExpandoData.NativeMethodInfoPtr__ctor_Internal_Void_ExpandoClass_Il2CppReferenceArray_1_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject.ExpandoData>.NativeClassPtr, 100666529);
				ExpandoObject.ExpandoData.NativeMethodInfoPtr_UpdateClass_Internal_ExpandoData_ExpandoClass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject.ExpandoData>.NativeClassPtr, 100666530);
				ExpandoObject.ExpandoData.NativeMethodInfoPtr_GetAlignedSize_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject.ExpandoData>.NativeClassPtr, 100666531);
			}

			// Token: 0x1700070A RID: 1802
			public unsafe Object this[int index]
			{
				[CallerCount(6)]
				[CachedScanResults(RefRangeStart = 1029194, RefRangeEnd = 1029200, XrefRangeStart = 1029194, XrefRangeEnd = 1029194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref index;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.ExpandoData.NativeMethodInfoPtr_get_Item_Internal_get_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 1029206, RefRangeEnd = 1029208, XrefRangeStart = 1029200, XrefRangeEnd = 1029206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref index;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.ExpandoData.NativeMethodInfoPtr_set_Item_Internal_set_Void_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x1700070B RID: 1803
			// (get) Token: 0x06001BE9 RID: 7145 RVA: 0x00084134 File Offset: 0x00082334
			public unsafe int Version
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.ExpandoData.NativeMethodInfoPtr_get_Version_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700070C RID: 1804
			// (get) Token: 0x06001BEA RID: 7146 RVA: 0x00084170 File Offset: 0x00082370
			public unsafe int Length
			{
				[CallerCount(13)]
				[CachedScanResults(RefRangeStart = 428718, RefRangeEnd = 428731, XrefRangeStart = 428718, XrefRangeEnd = 428731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.ExpandoData.NativeMethodInfoPtr_get_Length_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001BEB RID: 7147 RVA: 0x000841AC File Offset: 0x000823AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1029208, XrefRangeEnd = 1029221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ExpandoData()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExpandoObject.ExpandoData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.ExpandoData.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001BEC RID: 7148 RVA: 0x000841E8 File Offset: 0x000823E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ExpandoData(ExpandoClass klass, Il2CppReferenceArray<Object> data, int version)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExpandoObject.ExpandoData>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(klass);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref version;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.ExpandoData.NativeMethodInfoPtr__ctor_Internal_Void_ExpandoClass_Il2CppReferenceArray_1_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001BED RID: 7149 RVA: 0x00084254 File Offset: 0x00082454
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1029239, RefRangeEnd = 1029241, XrefRangeStart = 1029221, XrefRangeEnd = 1029239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ExpandoObject.ExpandoData UpdateClass(ExpandoClass newClass)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(newClass);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.ExpandoData.NativeMethodInfoPtr_UpdateClass_Internal_ExpandoData_ExpandoClass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExpandoObject.ExpandoData>(intPtr3) : null;
				}
			}

			// Token: 0x06001BEE RID: 7150 RVA: 0x000842A4 File Offset: 0x000824A4
			[CallerCount(0)]
			public unsafe static int GetAlignedSize(int len)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref len;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject.ExpandoData.NativeMethodInfoPtr_GetAlignedSize_Private_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001BEF RID: 7151 RVA: 0x0000AA25 File Offset: 0x00008C25
			public ExpandoData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000706 RID: 1798
			// (get) Token: 0x06001BF0 RID: 7152 RVA: 0x000842E4 File Offset: 0x000824E4
			// (set) Token: 0x06001BF1 RID: 7153 RVA: 0x0000AA2E File Offset: 0x00008C2E
			public unsafe static ExpandoObject.ExpandoData Empty
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ExpandoObject.ExpandoData.NativeFieldInfoPtr_Empty, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExpandoObject.ExpandoData>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ExpandoObject.ExpandoData.NativeFieldInfoPtr_Empty, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000707 RID: 1799
			// (get) Token: 0x06001BF2 RID: 7154 RVA: 0x0008430C File Offset: 0x0008250C
			// (set) Token: 0x06001BF3 RID: 7155 RVA: 0x0000AA40 File Offset: 0x00008C40
			public unsafe ExpandoClass Class
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoObject.ExpandoData.NativeFieldInfoPtr_Class);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExpandoClass>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoObject.ExpandoData.NativeFieldInfoPtr_Class), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000708 RID: 1800
			// (get) Token: 0x06001BF4 RID: 7156 RVA: 0x0008433C File Offset: 0x0008253C
			// (set) Token: 0x06001BF5 RID: 7157 RVA: 0x0000AA5F File Offset: 0x00008C5F
			public unsafe Il2CppReferenceArray<Object> _dataArray
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoObject.ExpandoData.NativeFieldInfoPtr__dataArray);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoObject.ExpandoData.NativeFieldInfoPtr__dataArray), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000709 RID: 1801
			// (get) Token: 0x06001BF6 RID: 7158 RVA: 0x0008436C File Offset: 0x0008256C
			// (set) Token: 0x06001BF7 RID: 7159 RVA: 0x0000AA7E File Offset: 0x00008C7E
			public unsafe int _version
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoObject.ExpandoData.NativeFieldInfoPtr__version);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoObject.ExpandoData.NativeFieldInfoPtr__version)) = value;
				}
			}

			// Token: 0x040012D8 RID: 4824
			private static readonly IntPtr NativeFieldInfoPtr_Empty;

			// Token: 0x040012D9 RID: 4825
			private static readonly IntPtr NativeFieldInfoPtr_Class;

			// Token: 0x040012DA RID: 4826
			private static readonly IntPtr NativeFieldInfoPtr__dataArray;

			// Token: 0x040012DB RID: 4827
			private static readonly IntPtr NativeFieldInfoPtr__version;

			// Token: 0x040012DC RID: 4828
			private static readonly IntPtr NativeMethodInfoPtr_get_Item_Internal_get_Object_Int32_0;

			// Token: 0x040012DD RID: 4829
			private static readonly IntPtr NativeMethodInfoPtr_set_Item_Internal_set_Void_Int32_Object_0;

			// Token: 0x040012DE RID: 4830
			private static readonly IntPtr NativeMethodInfoPtr_get_Version_Internal_get_Int32_0;

			// Token: 0x040012DF RID: 4831
			private static readonly IntPtr NativeMethodInfoPtr_get_Length_Internal_get_Int32_0;

			// Token: 0x040012E0 RID: 4832
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

			// Token: 0x040012E1 RID: 4833
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ExpandoClass_Il2CppReferenceArray_1_Object_Int32_0;

			// Token: 0x040012E2 RID: 4834
			private static readonly IntPtr NativeMethodInfoPtr_UpdateClass_Internal_ExpandoData_ExpandoClass_0;

			// Token: 0x040012E3 RID: 4835
			private static readonly IntPtr NativeMethodInfoPtr_GetAlignedSize_Private_Static_Int32_Int32_0;
		}

		// Token: 0x02000349 RID: 841
		[ObfuscatedName("System.Dynamic.ExpandoObject+<GetExpandoEnumerator>d__51")]
		public sealed class _GetExpandoEnumerator_d__51 : Object
		{
			// Token: 0x06001BF8 RID: 7160 RVA: 0x00084394 File Offset: 0x00082594
			// Note: this type is marked as 'beforefieldinit'.
			static _GetExpandoEnumerator_d__51()
			{
				Il2CppClassPointerStore<ExpandoObject._GetExpandoEnumerator_d__51>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ExpandoObject>.NativeClassPtr, "<GetExpandoEnumerator>d__51");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExpandoObject._GetExpandoEnumerator_d__51>.NativeClassPtr);
				ExpandoObject._GetExpandoEnumerator_d__51.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandoObject._GetExpandoEnumerator_d__51>.NativeClassPtr, "<>1__state");
				ExpandoObject._GetExpandoEnumerator_d__51.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandoObject._GetExpandoEnumerator_d__51>.NativeClassPtr, "<>2__current");
				ExpandoObject._GetExpandoEnumerator_d__51.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandoObject._GetExpandoEnumerator_d__51>.NativeClassPtr, "<>4__this");
				ExpandoObject._GetExpandoEnumerator_d__51.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandoObject._GetExpandoEnumerator_d__51>.NativeClassPtr, "version");
				ExpandoObject._GetExpandoEnumerator_d__51.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandoObject._GetExpandoEnumerator_d__51>.NativeClassPtr, "data");
				ExpandoObject._GetExpandoEnumerator_d__51.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandoObject._GetExpandoEnumerator_d__51>.NativeClassPtr, "<i>5__2");
				ExpandoObject._GetExpandoEnumerator_d__51.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject._GetExpandoEnumerator_d__51>.NativeClassPtr, 100666533);
				ExpandoObject._GetExpandoEnumerator_d__51.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject._GetExpandoEnumerator_d__51>.NativeClassPtr, 100666534);
				ExpandoObject._GetExpandoEnumerator_d__51.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject._GetExpandoEnumerator_d__51>.NativeClassPtr, 100666535);
				ExpandoObject._GetExpandoEnumerator_d__51.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_KeyValuePair_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject._GetExpandoEnumerator_d__51>.NativeClassPtr, 100666536);
				ExpandoObject._GetExpandoEnumerator_d__51.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject._GetExpandoEnumerator_d__51>.NativeClassPtr, 100666537);
				ExpandoObject._GetExpandoEnumerator_d__51.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoObject._GetExpandoEnumerator_d__51>.NativeClassPtr, 100666538);
			}

			// Token: 0x06001BF9 RID: 7161 RVA: 0x000844B0 File Offset: 0x000826B0
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetExpandoEnumerator_d__51(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExpandoObject._GetExpandoEnumerator_d__51>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject._GetExpandoEnumerator_d__51.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001BFA RID: 7162 RVA: 0x000844F8 File Offset: 0x000826F8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject._GetExpandoEnumerator_d__51.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001BFB RID: 7163 RVA: 0x0008452C File Offset: 0x0008272C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1029241, XrefRangeEnd = 1029250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject._GetExpandoEnumerator_d__51.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000713 RID: 1811
			// (get) Token: 0x06001BFC RID: 7164 RVA: 0x00084568 File Offset: 0x00082768
			public unsafe KeyValuePair<string, Object> prop_KeyValuePair_2_String_Object_0
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject._GetExpandoEnumerator_d__51.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_KeyValuePair_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new KeyValuePair<string, Object>(intPtr);
				}
			}

			// Token: 0x06001BFD RID: 7165 RVA: 0x000845A0 File Offset: 0x000827A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1029250, XrefRangeEnd = 1029255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject._GetExpandoEnumerator_d__51.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000714 RID: 1812
			// (get) Token: 0x06001BFE RID: 7166 RVA: 0x000845D4 File Offset: 0x000827D4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1029255, XrefRangeEnd = 1029258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoObject._GetExpandoEnumerator_d__51.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001BFF RID: 7167 RVA: 0x0000AA99 File Offset: 0x00008C99
			public _GetExpandoEnumerator_d__51(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700070D RID: 1805
			// (get) Token: 0x06001C00 RID: 7168 RVA: 0x00084614 File Offset: 0x00082814
			// (set) Token: 0x06001C01 RID: 7169 RVA: 0x0000AAA2 File Offset: 0x00008CA2
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoObject._GetExpandoEnumerator_d__51.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoObject._GetExpandoEnumerator_d__51.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700070E RID: 1806
			// (get) Token: 0x06001C02 RID: 7170 RVA: 0x0008463C File Offset: 0x0008283C
			// (set) Token: 0x06001C03 RID: 7171 RVA: 0x0000AABD File Offset: 0x00008CBD
			public KeyValuePair<string, Object> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoObject._GetExpandoEnumerator_d__51.NativeFieldInfoPtr___2__current);
					return new KeyValuePair<string, Object>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KeyValuePair<string, Object>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoObject._GetExpandoEnumerator_d__51.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<KeyValuePair<string, Object>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700070F RID: 1807
			// (get) Token: 0x06001C04 RID: 7172 RVA: 0x0008466C File Offset: 0x0008286C
			// (set) Token: 0x06001C05 RID: 7173 RVA: 0x0000AAEB File Offset: 0x00008CEB
			public unsafe ExpandoObject __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoObject._GetExpandoEnumerator_d__51.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExpandoObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoObject._GetExpandoEnumerator_d__51.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000710 RID: 1808
			// (get) Token: 0x06001C06 RID: 7174 RVA: 0x0008469C File Offset: 0x0008289C
			// (set) Token: 0x06001C07 RID: 7175 RVA: 0x0000AB0A File Offset: 0x00008D0A
			public unsafe int version
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoObject._GetExpandoEnumerator_d__51.NativeFieldInfoPtr_version);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoObject._GetExpandoEnumerator_d__51.NativeFieldInfoPtr_version)) = value;
				}
			}

			// Token: 0x17000711 RID: 1809
			// (get) Token: 0x06001C08 RID: 7176 RVA: 0x000846C4 File Offset: 0x000828C4
			// (set) Token: 0x06001C09 RID: 7177 RVA: 0x0000AB25 File Offset: 0x00008D25
			public unsafe ExpandoObject.ExpandoData data
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoObject._GetExpandoEnumerator_d__51.NativeFieldInfoPtr_data);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExpandoObject.ExpandoData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoObject._GetExpandoEnumerator_d__51.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000712 RID: 1810
			// (get) Token: 0x06001C0A RID: 7178 RVA: 0x000846F4 File Offset: 0x000828F4
			// (set) Token: 0x06001C0B RID: 7179 RVA: 0x0000AB44 File Offset: 0x00008D44
			public unsafe int _i_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoObject._GetExpandoEnumerator_d__51.NativeFieldInfoPtr__i_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoObject._GetExpandoEnumerator_d__51.NativeFieldInfoPtr__i_5__2)) = value;
				}
			}

			// Token: 0x040012E4 RID: 4836
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040012E5 RID: 4837
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040012E6 RID: 4838
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040012E7 RID: 4839
			private static readonly IntPtr NativeFieldInfoPtr_version;

			// Token: 0x040012E8 RID: 4840
			private static readonly IntPtr NativeFieldInfoPtr_data;

			// Token: 0x040012E9 RID: 4841
			private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

			// Token: 0x040012EA RID: 4842
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040012EB RID: 4843
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040012EC RID: 4844
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040012ED RID: 4845
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_KeyValuePair_2_String_Object_0;

			// Token: 0x040012EE RID: 4846
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040012EF RID: 4847
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
