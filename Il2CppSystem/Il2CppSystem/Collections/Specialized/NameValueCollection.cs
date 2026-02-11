using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Collections.Specialized
{
	// Token: 0x0200015A RID: 346
	[Serializable]
	public class NameValueCollection : NameObjectCollectionBase
	{
		// Token: 0x060014D1 RID: 5329 RVA: 0x0006CCE8 File Offset: 0x0006AEE8
		// Note: this type is marked as 'beforefieldinit'.
		static NameValueCollection()
		{
			Il2CppClassPointerStore<NameValueCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Collections.Specialized", "NameValueCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NameValueCollection>.NativeClassPtr);
			NameValueCollection.NativeFieldInfoPtr__all = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameValueCollection>.NativeClassPtr, "_all");
			NameValueCollection.NativeFieldInfoPtr__allKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameValueCollection>.NativeClassPtr, "_allKeys");
			NameValueCollection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameValueCollection>.NativeClassPtr, 100666445);
			NameValueCollection.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameValueCollection>.NativeClassPtr, 100666446);
			NameValueCollection.NativeMethodInfoPtr__ctor_Public_Void_Int32_IEqualityComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameValueCollection>.NativeClassPtr, 100666447);
			NameValueCollection.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameValueCollection>.NativeClassPtr, 100666448);
			NameValueCollection.NativeMethodInfoPtr_InvalidateCachedArrays_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameValueCollection>.NativeClassPtr, 100666449);
			NameValueCollection.NativeMethodInfoPtr_GetAsOneString_Private_Static_String_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameValueCollection>.NativeClassPtr, 100666450);
			NameValueCollection.NativeMethodInfoPtr_GetAsStringArray_Private_Static_Il2CppStringArray_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameValueCollection>.NativeClassPtr, 100666451);
			NameValueCollection.NativeMethodInfoPtr_Add_Public_Virtual_New_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameValueCollection>.NativeClassPtr, 100666452);
			NameValueCollection.NativeMethodInfoPtr_Get_Public_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameValueCollection>.NativeClassPtr, 100666453);
			NameValueCollection.NativeMethodInfoPtr_GetValues_Public_Virtual_New_Il2CppStringArray_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameValueCollection>.NativeClassPtr, 100666454);
			NameValueCollection.NativeMethodInfoPtr_Set_Public_Virtual_New_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameValueCollection>.NativeClassPtr, 100666455);
			NameValueCollection.NativeMethodInfoPtr_Remove_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameValueCollection>.NativeClassPtr, 100666456);
			NameValueCollection.NativeMethodInfoPtr_get_Item_Public_get_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameValueCollection>.NativeClassPtr, 100666457);
			NameValueCollection.NativeMethodInfoPtr_set_Item_Public_set_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameValueCollection>.NativeClassPtr, 100666458);
			NameValueCollection.NativeMethodInfoPtr_Get_Public_Virtual_New_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameValueCollection>.NativeClassPtr, 100666459);
			NameValueCollection.NativeMethodInfoPtr_GetValues_Public_Virtual_New_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameValueCollection>.NativeClassPtr, 100666460);
			NameValueCollection.NativeMethodInfoPtr_GetKey_Public_Virtual_New_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameValueCollection>.NativeClassPtr, 100666461);
			NameValueCollection.NativeMethodInfoPtr_get_AllKeys_Public_Virtual_New_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameValueCollection>.NativeClassPtr, 100666462);
			NameValueCollection.NativeMethodInfoPtr__ctor_Internal_Void_DBNull_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameValueCollection>.NativeClassPtr, 100666463);
		}

		// Token: 0x060014D2 RID: 5330 RVA: 0x0006CEBC File Offset: 0x0006B0BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 466430, RefRangeEnd = 466432, XrefRangeStart = 466422, XrefRangeEnd = 466430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NameValueCollection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NameValueCollection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameValueCollection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014D3 RID: 5331 RVA: 0x0006CEF8 File Offset: 0x0006B0F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 466445, RefRangeEnd = 466446, XrefRangeStart = 466432, XrefRangeEnd = 466445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NameValueCollection(int capacity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NameValueCollection>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameValueCollection.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014D4 RID: 5332 RVA: 0x0006CF40 File Offset: 0x0006B140
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 466451, RefRangeEnd = 466453, XrefRangeStart = 466446, XrefRangeEnd = 466451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NameValueCollection(int capacity, IEqualityComparer equalityComparer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NameValueCollection>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(equalityComparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameValueCollection.NativeMethodInfoPtr__ctor_Public_Void_Int32_IEqualityComparer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014D5 RID: 5333 RVA: 0x0006CF9C File Offset: 0x0006B19C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 466453, XrefRangeEnd = 466458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NameValueCollection(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NameValueCollection>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameValueCollection.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014D6 RID: 5334 RVA: 0x0006D000 File Offset: 0x0006B200
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 466460, RefRangeEnd = 466470, XrefRangeStart = 466458, XrefRangeEnd = 466460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvalidateCachedArrays()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameValueCollection.NativeMethodInfoPtr_InvalidateCachedArrays_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014D7 RID: 5335 RVA: 0x0006D034 File Offset: 0x0006B234
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 466480, RefRangeEnd = 466483, XrefRangeStart = 466470, XrefRangeEnd = 466480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetAsOneString(ArrayList list)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameValueCollection.NativeMethodInfoPtr_GetAsOneString_Private_Static_String_ArrayList_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060014D8 RID: 5336 RVA: 0x0006D070 File Offset: 0x0006B270
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 466486, RefRangeEnd = 466489, XrefRangeStart = 466483, XrefRangeEnd = 466486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray GetAsStringArray(ArrayList list)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameValueCollection.NativeMethodInfoPtr_GetAsStringArray_Private_Static_Il2CppStringArray_ArrayList_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x060014D9 RID: 5337 RVA: 0x0006D0B4 File Offset: 0x0006B2B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 466489, XrefRangeEnd = 466494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Add(string name, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NameValueCollection.NativeMethodInfoPtr_Add_Public_Virtual_New_Void_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014DA RID: 5338 RVA: 0x0006D114 File Offset: 0x0006B314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 466494, XrefRangeEnd = 466500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string Get(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NameValueCollection.NativeMethodInfoPtr_Get_Public_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060014DB RID: 5339 RVA: 0x0006D168 File Offset: 0x0006B368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 466500, XrefRangeEnd = 466506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppStringArray GetValues(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NameValueCollection.NativeMethodInfoPtr_GetValues_Public_Virtual_New_Il2CppStringArray_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x060014DC RID: 5340 RVA: 0x0006D1C4 File Offset: 0x0006B3C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 466506, XrefRangeEnd = 466514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Set(string name, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NameValueCollection.NativeMethodInfoPtr_Set_Public_Virtual_New_Void_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014DD RID: 5341 RVA: 0x0006D224 File Offset: 0x0006B424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 466514, XrefRangeEnd = 466517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Remove(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NameValueCollection.NativeMethodInfoPtr_Remove_Public_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700061A RID: 1562
		public unsafe string this[string name]
		{
			[CallerCount(28)]
			[CachedScanResults(RefRangeStart = 466517, RefRangeEnd = 466545, XrefRangeStart = 466517, XrefRangeEnd = 466517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameValueCollection.NativeMethodInfoPtr_get_Item_Public_get_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 466545, RefRangeEnd = 466548, XrefRangeStart = 466545, XrefRangeEnd = 466545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameValueCollection.NativeMethodInfoPtr_set_Item_Public_set_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014E0 RID: 5344 RVA: 0x0006D310 File Offset: 0x0006B510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 466548, XrefRangeEnd = 466554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string Get(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NameValueCollection.NativeMethodInfoPtr_Get_Public_Virtual_New_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060014E1 RID: 5345 RVA: 0x0006D360 File Offset: 0x0006B560
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 466554, XrefRangeEnd = 466560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppStringArray GetValues(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NameValueCollection.NativeMethodInfoPtr_GetValues_Public_Virtual_New_Il2CppStringArray_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x060014E2 RID: 5346 RVA: 0x0006D3B8 File Offset: 0x0006B5B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 466560, XrefRangeEnd = 466561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetKey(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NameValueCollection.NativeMethodInfoPtr_GetKey_Public_Virtual_New_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x060014E3 RID: 5347 RVA: 0x0006D408 File Offset: 0x0006B608
		public unsafe virtual Il2CppStringArray AllKeys
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 466561, XrefRangeEnd = 466568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NameValueCollection.NativeMethodInfoPtr_get_AllKeys_Public_Virtual_New_get_Il2CppStringArray_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x060014E4 RID: 5348 RVA: 0x0006D454 File Offset: 0x0006B654
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 466572, RefRangeEnd = 466578, XrefRangeStart = 466568, XrefRangeEnd = 466572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NameValueCollection(DBNull dummy)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NameValueCollection>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dummy);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameValueCollection.NativeMethodInfoPtr__ctor_Internal_Void_DBNull_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014E5 RID: 5349 RVA: 0x000093F5 File Offset: 0x000075F5
		public NameValueCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x060014E6 RID: 5350 RVA: 0x0006D4A0 File Offset: 0x0006B6A0
		// (set) Token: 0x060014E7 RID: 5351 RVA: 0x000093FE File Offset: 0x000075FE
		public unsafe Il2CppStringArray _all
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameValueCollection.NativeFieldInfoPtr__all);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameValueCollection.NativeFieldInfoPtr__all), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x060014E8 RID: 5352 RVA: 0x0006D4D0 File Offset: 0x0006B6D0
		// (set) Token: 0x060014E9 RID: 5353 RVA: 0x0000941D File Offset: 0x0000761D
		public unsafe Il2CppStringArray _allKeys
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameValueCollection.NativeFieldInfoPtr__allKeys);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameValueCollection.NativeFieldInfoPtr__allKeys), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001052 RID: 4178
		private static readonly IntPtr NativeFieldInfoPtr__all;

		// Token: 0x04001053 RID: 4179
		private static readonly IntPtr NativeFieldInfoPtr__allKeys;

		// Token: 0x04001054 RID: 4180
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001055 RID: 4181
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001056 RID: 4182
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_IEqualityComparer_0;

		// Token: 0x04001057 RID: 4183
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04001058 RID: 4184
		private static readonly IntPtr NativeMethodInfoPtr_InvalidateCachedArrays_Protected_Void_0;

		// Token: 0x04001059 RID: 4185
		private static readonly IntPtr NativeMethodInfoPtr_GetAsOneString_Private_Static_String_ArrayList_0;

		// Token: 0x0400105A RID: 4186
		private static readonly IntPtr NativeMethodInfoPtr_GetAsStringArray_Private_Static_Il2CppStringArray_ArrayList_0;

		// Token: 0x0400105B RID: 4187
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_New_Void_String_String_0;

		// Token: 0x0400105C RID: 4188
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Virtual_New_String_String_0;

		// Token: 0x0400105D RID: 4189
		private static readonly IntPtr NativeMethodInfoPtr_GetValues_Public_Virtual_New_Il2CppStringArray_String_0;

		// Token: 0x0400105E RID: 4190
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Virtual_New_Void_String_String_0;

		// Token: 0x0400105F RID: 4191
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_New_Void_String_0;

		// Token: 0x04001060 RID: 4192
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_String_String_0;

		// Token: 0x04001061 RID: 4193
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_String_String_0;

		// Token: 0x04001062 RID: 4194
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Virtual_New_String_Int32_0;

		// Token: 0x04001063 RID: 4195
		private static readonly IntPtr NativeMethodInfoPtr_GetValues_Public_Virtual_New_Il2CppStringArray_Int32_0;

		// Token: 0x04001064 RID: 4196
		private static readonly IntPtr NativeMethodInfoPtr_GetKey_Public_Virtual_New_String_Int32_0;

		// Token: 0x04001065 RID: 4197
		private static readonly IntPtr NativeMethodInfoPtr_get_AllKeys_Public_Virtual_New_get_Il2CppStringArray_0;

		// Token: 0x04001066 RID: 4198
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_DBNull_0;
	}
}
