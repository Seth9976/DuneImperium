using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Resources
{
	// Token: 0x020003F2 RID: 1010
	[Serializable]
	public class ResourceSet : Object
	{
		// Token: 0x06003B52 RID: 15186 RVA: 0x0011CFF0 File Offset: 0x0011B1F0
		// Note: this type is marked as 'beforefieldinit'.
		static ResourceSet()
		{
			Il2CppClassPointerStore<ResourceSet>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Resources", "ResourceSet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourceSet>.NativeClassPtr);
			ResourceSet.NativeFieldInfoPtr_Reader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceSet>.NativeClassPtr, "Reader");
			ResourceSet.NativeFieldInfoPtr_Table = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceSet>.NativeClassPtr, "Table");
			ResourceSet.NativeFieldInfoPtr__caseInsensitiveTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceSet>.NativeClassPtr, "_caseInsensitiveTable");
			ResourceSet.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceSet>.NativeClassPtr, 100672153);
			ResourceSet.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceSet>.NativeClassPtr, 100672154);
			ResourceSet.NativeMethodInfoPtr_CommonInit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceSet>.NativeClassPtr, 100672155);
			ResourceSet.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceSet>.NativeClassPtr, 100672156);
			ResourceSet.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceSet>.NativeClassPtr, 100672157);
			ResourceSet.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IDictionaryEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceSet>.NativeClassPtr, 100672158);
			ResourceSet.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceSet>.NativeClassPtr, 100672159);
			ResourceSet.NativeMethodInfoPtr_GetEnumeratorHelper_Private_IDictionaryEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceSet>.NativeClassPtr, 100672160);
			ResourceSet.NativeMethodInfoPtr_GetString_Public_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceSet>.NativeClassPtr, 100672161);
			ResourceSet.NativeMethodInfoPtr_GetString_Public_Virtual_New_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceSet>.NativeClassPtr, 100672162);
			ResourceSet.NativeMethodInfoPtr_GetObject_Public_Virtual_New_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceSet>.NativeClassPtr, 100672163);
			ResourceSet.NativeMethodInfoPtr_GetObject_Public_Virtual_New_Object_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceSet>.NativeClassPtr, 100672164);
			ResourceSet.NativeMethodInfoPtr_GetObjectInternal_Private_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceSet>.NativeClassPtr, 100672165);
			ResourceSet.NativeMethodInfoPtr_GetCaseInsensitiveObjectInternal_Private_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceSet>.NativeClassPtr, 100672166);
		}

		// Token: 0x06003B53 RID: 15187 RVA: 0x0011D174 File Offset: 0x0011B374
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1397977, XrefRangeEnd = 1397983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResourceSet()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourceSet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceSet.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B54 RID: 15188 RVA: 0x0011D1B0 File Offset: 0x0011B3B0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResourceSet(bool junk)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourceSet>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref junk;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceSet.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003B55 RID: 15189 RVA: 0x0011D1F8 File Offset: 0x0011B3F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1397983, XrefRangeEnd = 1397988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CommonInit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceSet.NativeMethodInfoPtr_CommonInit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B56 RID: 15190 RVA: 0x0011D22C File Offset: 0x0011B42C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1397996, RefRangeEnd = 1397998, XrefRangeStart = 1397988, XrefRangeEnd = 1397996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResourceSet.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003B57 RID: 15191 RVA: 0x0011D278 File Offset: 0x0011B478
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 1171637, RefRangeEnd = 1171657, XrefRangeStart = 1171637, XrefRangeEnd = 1171657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceSet.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B58 RID: 15192 RVA: 0x0011D2AC File Offset: 0x0011B4AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1397998, XrefRangeEnd = 1397999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IDictionaryEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResourceSet.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IDictionaryEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionaryEnumerator>(intPtr3) : null;
		}

		// Token: 0x06003B59 RID: 15193 RVA: 0x0011D2F8 File Offset: 0x0011B4F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceSet.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06003B5A RID: 15194 RVA: 0x0011D338 File Offset: 0x0011B538
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1398006, RefRangeEnd = 1398008, XrefRangeStart = 1397999, XrefRangeEnd = 1398006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IDictionaryEnumerator GetEnumeratorHelper()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceSet.NativeMethodInfoPtr_GetEnumeratorHelper_Private_IDictionaryEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionaryEnumerator>(intPtr3) : null;
		}

		// Token: 0x06003B5B RID: 15195 RVA: 0x0011D378 File Offset: 0x0011B578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1398008, XrefRangeEnd = 1398010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetString(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResourceSet.NativeMethodInfoPtr_GetString_Public_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003B5C RID: 15196 RVA: 0x0011D3CC File Offset: 0x0011B5CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1398010, XrefRangeEnd = 1398014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetString(string name, bool ignoreCase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResourceSet.NativeMethodInfoPtr_GetString_Public_Virtual_New_String_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003B5D RID: 15197 RVA: 0x0011D430 File Offset: 0x0011B630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1398014, XrefRangeEnd = 1398027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object GetObject(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResourceSet.NativeMethodInfoPtr_GetObject_Public_Virtual_New_Object_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003B5E RID: 15198 RVA: 0x0011D48C File Offset: 0x0011B68C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1398027, XrefRangeEnd = 1398028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object GetObject(string name, bool ignoreCase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResourceSet.NativeMethodInfoPtr_GetObject_Public_Virtual_New_Object_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06003B5F RID: 15199 RVA: 0x0011D4F8 File Offset: 0x0011B6F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetObjectInternal(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceSet.NativeMethodInfoPtr_GetObjectInternal_Private_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003B60 RID: 15200 RVA: 0x0011D548 File Offset: 0x0011B748
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1398060, RefRangeEnd = 1398062, XrefRangeStart = 1398028, XrefRangeEnd = 1398060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetCaseInsensitiveObjectInternal(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceSet.NativeMethodInfoPtr_GetCaseInsensitiveObjectInternal_Private_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003B61 RID: 15201 RVA: 0x00016189 File Offset: 0x00014389
		public ResourceSet(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DD5 RID: 3541
		// (get) Token: 0x06003B62 RID: 15202 RVA: 0x0011D598 File Offset: 0x0011B798
		// (set) Token: 0x06003B63 RID: 15203 RVA: 0x00016192 File Offset: 0x00014392
		public unsafe IResourceReader Reader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceSet.NativeFieldInfoPtr_Reader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IResourceReader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceSet.NativeFieldInfoPtr_Reader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DD6 RID: 3542
		// (get) Token: 0x06003B64 RID: 15204 RVA: 0x0011D5C8 File Offset: 0x0011B7C8
		// (set) Token: 0x06003B65 RID: 15205 RVA: 0x000161B1 File Offset: 0x000143B1
		public unsafe Hashtable Table
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceSet.NativeFieldInfoPtr_Table);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceSet.NativeFieldInfoPtr_Table), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DD7 RID: 3543
		// (get) Token: 0x06003B66 RID: 15206 RVA: 0x0011D5F8 File Offset: 0x0011B7F8
		// (set) Token: 0x06003B67 RID: 15207 RVA: 0x000161D0 File Offset: 0x000143D0
		public unsafe Hashtable _caseInsensitiveTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceSet.NativeFieldInfoPtr__caseInsensitiveTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceSet.NativeFieldInfoPtr__caseInsensitiveTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002FFB RID: 12283
		private static readonly IntPtr NativeFieldInfoPtr_Reader;

		// Token: 0x04002FFC RID: 12284
		private static readonly IntPtr NativeFieldInfoPtr_Table;

		// Token: 0x04002FFD RID: 12285
		private static readonly IntPtr NativeFieldInfoPtr__caseInsensitiveTable;

		// Token: 0x04002FFE RID: 12286
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04002FFF RID: 12287
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0;

		// Token: 0x04003000 RID: 12288
		private static readonly IntPtr NativeMethodInfoPtr_CommonInit_Private_Void_0;

		// Token: 0x04003001 RID: 12289
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x04003002 RID: 12290
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04003003 RID: 12291
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IDictionaryEnumerator_0;

		// Token: 0x04003004 RID: 12292
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x04003005 RID: 12293
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumeratorHelper_Private_IDictionaryEnumerator_0;

		// Token: 0x04003006 RID: 12294
		private static readonly IntPtr NativeMethodInfoPtr_GetString_Public_Virtual_New_String_String_0;

		// Token: 0x04003007 RID: 12295
		private static readonly IntPtr NativeMethodInfoPtr_GetString_Public_Virtual_New_String_String_Boolean_0;

		// Token: 0x04003008 RID: 12296
		private static readonly IntPtr NativeMethodInfoPtr_GetObject_Public_Virtual_New_Object_String_0;

		// Token: 0x04003009 RID: 12297
		private static readonly IntPtr NativeMethodInfoPtr_GetObject_Public_Virtual_New_Object_String_Boolean_0;

		// Token: 0x0400300A RID: 12298
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectInternal_Private_Object_String_0;

		// Token: 0x0400300B RID: 12299
		private static readonly IntPtr NativeMethodInfoPtr_GetCaseInsensitiveObjectInternal_Private_Object_String_0;
	}
}
