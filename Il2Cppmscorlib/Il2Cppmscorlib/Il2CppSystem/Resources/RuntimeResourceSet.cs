using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;

namespace Il2CppSystem.Resources
{
	// Token: 0x020003E8 RID: 1000
	public sealed class RuntimeResourceSet : ResourceSet
	{
		// Token: 0x06003A7E RID: 14974 RVA: 0x00119D8C File Offset: 0x00117F8C
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeResourceSet()
		{
			Il2CppClassPointerStore<RuntimeResourceSet>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Resources", "RuntimeResourceSet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeResourceSet>.NativeClassPtr);
			RuntimeResourceSet.NativeFieldInfoPtr_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeResourceSet>.NativeClassPtr, "Version");
			RuntimeResourceSet.NativeFieldInfoPtr__resCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeResourceSet>.NativeClassPtr, "_resCache");
			RuntimeResourceSet.NativeFieldInfoPtr__defaultReader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeResourceSet>.NativeClassPtr, "_defaultReader");
			RuntimeResourceSet.NativeFieldInfoPtr__caseInsensitiveTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeResourceSet>.NativeClassPtr, "_caseInsensitiveTable");
			RuntimeResourceSet.NativeFieldInfoPtr__haveReadFromReader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeResourceSet>.NativeClassPtr, "_haveReadFromReader");
			RuntimeResourceSet.NativeMethodInfoPtr__ctor_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeResourceSet>.NativeClassPtr, 100672033);
			RuntimeResourceSet.NativeMethodInfoPtr__ctor_Internal_Void_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeResourceSet>.NativeClassPtr, 100672034);
			RuntimeResourceSet.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeResourceSet>.NativeClassPtr, 100672035);
			RuntimeResourceSet.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_IDictionaryEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeResourceSet>.NativeClassPtr, 100672036);
			RuntimeResourceSet.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeResourceSet>.NativeClassPtr, 100672037);
			RuntimeResourceSet.NativeMethodInfoPtr_GetEnumeratorHelper_Private_IDictionaryEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeResourceSet>.NativeClassPtr, 100672038);
			RuntimeResourceSet.NativeMethodInfoPtr_GetString_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeResourceSet>.NativeClassPtr, 100672039);
			RuntimeResourceSet.NativeMethodInfoPtr_GetString_Public_Virtual_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeResourceSet>.NativeClassPtr, 100672040);
			RuntimeResourceSet.NativeMethodInfoPtr_GetObject_Public_Virtual_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeResourceSet>.NativeClassPtr, 100672041);
			RuntimeResourceSet.NativeMethodInfoPtr_GetObject_Public_Virtual_Object_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeResourceSet>.NativeClassPtr, 100672042);
			RuntimeResourceSet.NativeMethodInfoPtr_GetObject_Private_Object_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeResourceSet>.NativeClassPtr, 100672043);
			RuntimeResourceSet.NativeMethodInfoPtr_ResolveResourceLocator_Private_Object_ResourceLocator_String_Dictionary_2_String_ResourceLocator_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeResourceSet>.NativeClassPtr, 100672044);
		}

		// Token: 0x06003A7F RID: 14975 RVA: 0x00119F10 File Offset: 0x00118110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1396494, XrefRangeEnd = 1396516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeResourceSet(string fileName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimeResourceSet>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fileName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeResourceSet.NativeMethodInfoPtr__ctor_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003A80 RID: 14976 RVA: 0x00119F5C File Offset: 0x0011815C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1396534, RefRangeEnd = 1396535, XrefRangeStart = 1396516, XrefRangeEnd = 1396534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeResourceSet(Stream stream)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimeResourceSet>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeResourceSet.NativeMethodInfoPtr__ctor_Internal_Void_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003A81 RID: 14977 RVA: 0x00119FA8 File Offset: 0x001181A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1396535, XrefRangeEnd = 1396548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeResourceSet.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003A82 RID: 14978 RVA: 0x00119FE8 File Offset: 0x001181E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1396548, XrefRangeEnd = 1396549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IDictionaryEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeResourceSet.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_IDictionaryEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionaryEnumerator>(intPtr3) : null;
		}

		// Token: 0x06003A83 RID: 14979 RVA: 0x0011A028 File Offset: 0x00118228
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeResourceSet.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06003A84 RID: 14980 RVA: 0x0011A068 File Offset: 0x00118268
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1396558, RefRangeEnd = 1396560, XrefRangeStart = 1396549, XrefRangeEnd = 1396558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe IDictionaryEnumerator GetEnumeratorHelper()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeResourceSet.NativeMethodInfoPtr_GetEnumeratorHelper_Private_IDictionaryEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionaryEnumerator>(intPtr3) : null;
		}

		// Token: 0x06003A85 RID: 14981 RVA: 0x0011A0A8 File Offset: 0x001182A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1396560, XrefRangeEnd = 1396563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetString(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeResourceSet.NativeMethodInfoPtr_GetString_Public_Virtual_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003A86 RID: 14982 RVA: 0x0011A0F0 File Offset: 0x001182F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1396563, XrefRangeEnd = 1396566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetString(string key, bool ignoreCase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeResourceSet.NativeMethodInfoPtr_GetString_Public_Virtual_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003A87 RID: 14983 RVA: 0x0011A148 File Offset: 0x00118348
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1396566, XrefRangeEnd = 1396567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object GetObject(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeResourceSet.NativeMethodInfoPtr_GetObject_Public_Virtual_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003A88 RID: 14984 RVA: 0x0011A198 File Offset: 0x00118398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1396567, XrefRangeEnd = 1396568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object GetObject(string key, bool ignoreCase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeResourceSet.NativeMethodInfoPtr_GetObject_Public_Virtual_Object_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06003A89 RID: 14985 RVA: 0x0011A1F8 File Offset: 0x001183F8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1396639, RefRangeEnd = 1396643, XrefRangeStart = 1396568, XrefRangeEnd = 1396639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetObject(string key, bool ignoreCase, bool isString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isString;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeResourceSet.NativeMethodInfoPtr_GetObject_Private_Object_String_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06003A8A RID: 14986 RVA: 0x0011A264 File Offset: 0x00118464
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1396653, RefRangeEnd = 1396655, XrefRangeStart = 1396643, XrefRangeEnd = 1396653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ResolveResourceLocator(ResourceLocator resLocation, string key, Dictionary<string, ResourceLocator> copyOfCache, bool keyInWrongCase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(resLocation));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(copyOfCache);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keyInWrongCase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeResourceSet.NativeMethodInfoPtr_ResolveResourceLocator_Private_Object_ResourceLocator_String_Dictionary_2_String_ResourceLocator_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06003A8B RID: 14987 RVA: 0x00015BA2 File Offset: 0x00013DA2
		public RuntimeResourceSet(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D9E RID: 3486
		// (get) Token: 0x06003A8C RID: 14988 RVA: 0x0011A2EC File Offset: 0x001184EC
		// (set) Token: 0x06003A8D RID: 14989 RVA: 0x00015BAB File Offset: 0x00013DAB
		public unsafe static int Version
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RuntimeResourceSet.NativeFieldInfoPtr_Version, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RuntimeResourceSet.NativeFieldInfoPtr_Version, (void*)(&value));
			}
		}

		// Token: 0x17000D9F RID: 3487
		// (get) Token: 0x06003A8E RID: 14990 RVA: 0x0011A308 File Offset: 0x00118508
		// (set) Token: 0x06003A8F RID: 14991 RVA: 0x00015BB9 File Offset: 0x00013DB9
		public unsafe Dictionary<string, ResourceLocator> _resCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeResourceSet.NativeFieldInfoPtr__resCache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, ResourceLocator>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeResourceSet.NativeFieldInfoPtr__resCache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DA0 RID: 3488
		// (get) Token: 0x06003A90 RID: 14992 RVA: 0x0011A338 File Offset: 0x00118538
		// (set) Token: 0x06003A91 RID: 14993 RVA: 0x00015BD8 File Offset: 0x00013DD8
		public unsafe ResourceReader _defaultReader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeResourceSet.NativeFieldInfoPtr__defaultReader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResourceReader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeResourceSet.NativeFieldInfoPtr__defaultReader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DA1 RID: 3489
		// (get) Token: 0x06003A92 RID: 14994 RVA: 0x0011A368 File Offset: 0x00118568
		// (set) Token: 0x06003A93 RID: 14995 RVA: 0x00015BF7 File Offset: 0x00013DF7
		public new unsafe Dictionary<string, ResourceLocator> _caseInsensitiveTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeResourceSet.NativeFieldInfoPtr__caseInsensitiveTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, ResourceLocator>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeResourceSet.NativeFieldInfoPtr__caseInsensitiveTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DA2 RID: 3490
		// (get) Token: 0x06003A94 RID: 14996 RVA: 0x0011A398 File Offset: 0x00118598
		// (set) Token: 0x06003A95 RID: 14997 RVA: 0x00015C16 File Offset: 0x00013E16
		public unsafe bool _haveReadFromReader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeResourceSet.NativeFieldInfoPtr__haveReadFromReader);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeResourceSet.NativeFieldInfoPtr__haveReadFromReader)) = value;
			}
		}

		// Token: 0x04002F69 RID: 12137
		private static readonly IntPtr NativeFieldInfoPtr_Version;

		// Token: 0x04002F6A RID: 12138
		private static readonly IntPtr NativeFieldInfoPtr__resCache;

		// Token: 0x04002F6B RID: 12139
		private static readonly IntPtr NativeFieldInfoPtr__defaultReader;

		// Token: 0x04002F6C RID: 12140
		private static readonly IntPtr NativeFieldInfoPtr__caseInsensitiveTable;

		// Token: 0x04002F6D RID: 12141
		private static readonly IntPtr NativeFieldInfoPtr__haveReadFromReader;

		// Token: 0x04002F6E RID: 12142
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_0;

		// Token: 0x04002F6F RID: 12143
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Stream_0;

		// Token: 0x04002F70 RID: 12144
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x04002F71 RID: 12145
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_IDictionaryEnumerator_0;

		// Token: 0x04002F72 RID: 12146
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x04002F73 RID: 12147
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumeratorHelper_Private_IDictionaryEnumerator_0;

		// Token: 0x04002F74 RID: 12148
		private static readonly IntPtr NativeMethodInfoPtr_GetString_Public_Virtual_String_String_0;

		// Token: 0x04002F75 RID: 12149
		private static readonly IntPtr NativeMethodInfoPtr_GetString_Public_Virtual_String_String_Boolean_0;

		// Token: 0x04002F76 RID: 12150
		private static readonly IntPtr NativeMethodInfoPtr_GetObject_Public_Virtual_Object_String_0;

		// Token: 0x04002F77 RID: 12151
		private static readonly IntPtr NativeMethodInfoPtr_GetObject_Public_Virtual_Object_String_Boolean_0;

		// Token: 0x04002F78 RID: 12152
		private static readonly IntPtr NativeMethodInfoPtr_GetObject_Private_Object_String_Boolean_Boolean_0;

		// Token: 0x04002F79 RID: 12153
		private static readonly IntPtr NativeMethodInfoPtr_ResolveResourceLocator_Private_Object_ResourceLocator_String_Dictionary_2_String_ResourceLocator_Boolean_0;
	}
}
