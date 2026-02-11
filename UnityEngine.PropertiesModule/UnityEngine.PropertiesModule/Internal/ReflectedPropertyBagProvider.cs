using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Linq;
using Il2CppSystem.Reflection;

namespace Unity.Properties.Internal
{
	// Token: 0x02000034 RID: 52
	public class ReflectedPropertyBagProvider : Object
	{
		// Token: 0x0600018C RID: 396 RVA: 0x00007A94 File Offset: 0x00005C94
		// Note: this type is marked as 'beforefieldinit'.
		static ReflectedPropertyBagProvider()
		{
			Il2CppClassPointerStore<ReflectedPropertyBagProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.PropertiesModule.dll", "Unity.Properties.Internal", "ReflectedPropertyBagProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReflectedPropertyBagProvider>.NativeClassPtr);
			ReflectedPropertyBagProvider.NativeFieldInfoPtr_m_CreatePropertyMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectedPropertyBagProvider>.NativeClassPtr, "m_CreatePropertyMethod");
			ReflectedPropertyBagProvider.NativeFieldInfoPtr_m_CreatePropertyBagMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectedPropertyBagProvider>.NativeClassPtr, "m_CreatePropertyBagMethod");
			ReflectedPropertyBagProvider.NativeFieldInfoPtr_m_CreateIndexedCollectionPropertyBagMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectedPropertyBagProvider>.NativeClassPtr, "m_CreateIndexedCollectionPropertyBagMethod");
			ReflectedPropertyBagProvider.NativeFieldInfoPtr_m_CreateSetPropertyBagMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectedPropertyBagProvider>.NativeClassPtr, "m_CreateSetPropertyBagMethod");
			ReflectedPropertyBagProvider.NativeFieldInfoPtr_m_CreateKeyValueCollectionPropertyBagMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectedPropertyBagProvider>.NativeClassPtr, "m_CreateKeyValueCollectionPropertyBagMethod");
			ReflectedPropertyBagProvider.NativeFieldInfoPtr_m_CreateKeyValuePairPropertyBagMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectedPropertyBagProvider>.NativeClassPtr, "m_CreateKeyValuePairPropertyBagMethod");
			ReflectedPropertyBagProvider.NativeFieldInfoPtr_m_CreateArrayPropertyBagMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectedPropertyBagProvider>.NativeClassPtr, "m_CreateArrayPropertyBagMethod");
			ReflectedPropertyBagProvider.NativeFieldInfoPtr_m_CreateListPropertyBagMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectedPropertyBagProvider>.NativeClassPtr, "m_CreateListPropertyBagMethod");
			ReflectedPropertyBagProvider.NativeFieldInfoPtr_m_CreateHashSetPropertyBagMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectedPropertyBagProvider>.NativeClassPtr, "m_CreateHashSetPropertyBagMethod");
			ReflectedPropertyBagProvider.NativeFieldInfoPtr_m_CreateDictionaryPropertyBagMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectedPropertyBagProvider>.NativeClassPtr, "m_CreateDictionaryPropertyBagMethod");
			ReflectedPropertyBagProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectedPropertyBagProvider>.NativeClassPtr, 100663535);
			ReflectedPropertyBagProvider.NativeMethodInfoPtr_CreatePropertyBag_Public_IPropertyBag_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectedPropertyBagProvider>.NativeClassPtr, 100663536);
			ReflectedPropertyBagProvider.NativeMethodInfoPtr_CreatePropertyBag_Public_IPropertyBag_1_TContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectedPropertyBagProvider>.NativeClassPtr, 100663537);
			ReflectedPropertyBagProvider.NativeMethodInfoPtr_CreateProperty_Private_Void_IMemberInfo_ReflectedPropertyBag_1_TContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectedPropertyBagProvider>.NativeClassPtr, 100663538);
			ReflectedPropertyBagProvider.NativeMethodInfoPtr_CreateIndexedCollectionPropertyBag_Private_IPropertyBag_1_TList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectedPropertyBagProvider>.NativeClassPtr, 100663539);
			ReflectedPropertyBagProvider.NativeMethodInfoPtr_CreateSetPropertyBag_Private_IPropertyBag_1_TSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectedPropertyBagProvider>.NativeClassPtr, 100663540);
			ReflectedPropertyBagProvider.NativeMethodInfoPtr_CreateKeyValueCollectionPropertyBag_Private_IPropertyBag_1_TDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectedPropertyBagProvider>.NativeClassPtr, 100663541);
			ReflectedPropertyBagProvider.NativeMethodInfoPtr_CreateKeyValuePairPropertyBag_Private_IPropertyBag_1_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectedPropertyBagProvider>.NativeClassPtr, 100663542);
			ReflectedPropertyBagProvider.NativeMethodInfoPtr_CreateArrayPropertyBag_Private_IPropertyBag_1_Il2CppArrayBase_1_TElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectedPropertyBagProvider>.NativeClassPtr, 100663543);
			ReflectedPropertyBagProvider.NativeMethodInfoPtr_CreateListPropertyBag_Private_IPropertyBag_1_List_1_TElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectedPropertyBagProvider>.NativeClassPtr, 100663544);
			ReflectedPropertyBagProvider.NativeMethodInfoPtr_CreateHashSetPropertyBag_Private_IPropertyBag_1_HashSet_1_TElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectedPropertyBagProvider>.NativeClassPtr, 100663545);
			ReflectedPropertyBagProvider.NativeMethodInfoPtr_CreateDictionaryPropertyBag_Private_IPropertyBag_1_Dictionary_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectedPropertyBagProvider>.NativeClassPtr, 100663546);
			ReflectedPropertyBagProvider.NativeMethodInfoPtr_GetPropertyMembers_Private_Static_IEnumerable_1_MemberInfo_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectedPropertyBagProvider>.NativeClassPtr, 100663547);
			ReflectedPropertyBagProvider.NativeMethodInfoPtr_IsValidMember_Private_Static_Boolean_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectedPropertyBagProvider>.NativeClassPtr, 100663548);
			ReflectedPropertyBagProvider.NativeMethodInfoPtr_IsValidPropertyType_Private_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectedPropertyBagProvider>.NativeClassPtr, 100663549);
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00007CB8 File Offset: 0x00005EB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232867, XrefRangeEnd = 1232950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReflectedPropertyBagProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectedPropertyBagProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectedPropertyBagProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00007CF4 File Offset: 0x00005EF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232950, XrefRangeEnd = 1232960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IPropertyBag CreatePropertyBag(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectedPropertyBagProvider.NativeMethodInfoPtr_CreatePropertyBag_Public_IPropertyBag_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPropertyBag>(intPtr3) : null;
			}
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00007D44 File Offset: 0x00005F44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232960, XrefRangeEnd = 1233237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IPropertyBag<TContainer> CreatePropertyBag<TContainer>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectedPropertyBagProvider.MethodInfoStoreGeneric_CreatePropertyBag_Public_IPropertyBag_1_TContainer_0<TContainer>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPropertyBag<TContainer>>(intPtr3) : null;
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00007D84 File Offset: 0x00005F84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233237, XrefRangeEnd = 1233248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateProperty<TContainer, TValue>(IMemberInfo member, ReflectedPropertyBag<TContainer> propertyBag)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(member);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(propertyBag);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectedPropertyBagProvider.MethodInfoStoreGeneric_CreateProperty_Private_Void_IMemberInfo_ReflectedPropertyBag_1_TContainer_0<TContainer, TValue>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00007DD8 File Offset: 0x00005FD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233248, XrefRangeEnd = 1233251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IPropertyBag<TList> CreateIndexedCollectionPropertyBag<TList, TElement>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectedPropertyBagProvider.MethodInfoStoreGeneric_CreateIndexedCollectionPropertyBag_Private_IPropertyBag_1_TList_0<TList, TElement>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPropertyBag<TList>>(intPtr3) : null;
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00007E18 File Offset: 0x00006018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IPropertyBag<TSet> CreateSetPropertyBag<TSet, TValue>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectedPropertyBagProvider.MethodInfoStoreGeneric_CreateSetPropertyBag_Private_IPropertyBag_1_TSet_0<TSet, TValue>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPropertyBag<TSet>>(intPtr3) : null;
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00007E58 File Offset: 0x00006058
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IPropertyBag<TDictionary> CreateKeyValueCollectionPropertyBag<TDictionary, TKey, TValue>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectedPropertyBagProvider.MethodInfoStoreGeneric_CreateKeyValueCollectionPropertyBag_Private_IPropertyBag_1_TDictionary_0<TDictionary, TKey, TValue>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPropertyBag<TDictionary>>(intPtr3) : null;
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00007E98 File Offset: 0x00006098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IPropertyBag<KeyValuePair<TKey, TValue>> CreateKeyValuePairPropertyBag<TKey, TValue>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectedPropertyBagProvider.MethodInfoStoreGeneric_CreateKeyValuePairPropertyBag_Private_IPropertyBag_1_KeyValuePair_2_TKey_TValue_0<TKey, TValue>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPropertyBag<KeyValuePair<TKey, TValue>>>(intPtr3) : null;
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00007ED8 File Offset: 0x000060D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IPropertyBag<Il2CppArrayBase<TElement>> CreateArrayPropertyBag<TElement>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectedPropertyBagProvider.MethodInfoStoreGeneric_CreateArrayPropertyBag_Private_IPropertyBag_1_Il2CppArrayBase_1_TElement_0<TElement>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPropertyBag<Il2CppArrayBase<TElement>>>(intPtr3) : null;
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00007F18 File Offset: 0x00006118
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IPropertyBag<List<TElement>> CreateListPropertyBag<TElement>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectedPropertyBagProvider.MethodInfoStoreGeneric_CreateListPropertyBag_Private_IPropertyBag_1_List_1_TElement_0<TElement>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPropertyBag<List<TElement>>>(intPtr3) : null;
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00007F58 File Offset: 0x00006158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IPropertyBag<HashSet<TElement>> CreateHashSetPropertyBag<TElement>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectedPropertyBagProvider.MethodInfoStoreGeneric_CreateHashSetPropertyBag_Private_IPropertyBag_1_HashSet_1_TElement_0<TElement>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPropertyBag<HashSet<TElement>>>(intPtr3) : null;
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00007F98 File Offset: 0x00006198
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IPropertyBag<Dictionary<TKey, TValue>> CreateDictionaryPropertyBag<TKey, TValue>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectedPropertyBagProvider.MethodInfoStoreGeneric_CreateDictionaryPropertyBag_Private_IPropertyBag_1_Dictionary_2_TKey_TValue_0<TKey, TValue>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPropertyBag<Dictionary<TKey, TValue>>>(intPtr3) : null;
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00007FD8 File Offset: 0x000061D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1233257, RefRangeEnd = 1233258, XrefRangeStart = 1233251, XrefRangeEnd = 1233257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<MemberInfo> GetPropertyMembers(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectedPropertyBagProvider.NativeMethodInfoPtr_GetPropertyMembers_Private_Static_IEnumerable_1_MemberInfo_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<MemberInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x0600019A RID: 410 RVA: 0x0000801C File Offset: 0x0000621C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1233264, RefRangeEnd = 1233265, XrefRangeStart = 1233258, XrefRangeEnd = 1233264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValidMember(MemberInfo memberInfo)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(memberInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectedPropertyBagProvider.NativeMethodInfoPtr_IsValidMember_Private_Static_Boolean_MemberInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00008060 File Offset: 0x00006260
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1233269, RefRangeEnd = 1233270, XrefRangeStart = 1233265, XrefRangeEnd = 1233269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValidPropertyType(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectedPropertyBagProvider.NativeMethodInfoPtr_IsValidPropertyType_Private_Static_Boolean_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00002D0D File Offset: 0x00000F0D
		public ReflectedPropertyBagProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600019D RID: 413 RVA: 0x000080A4 File Offset: 0x000062A4
		// (set) Token: 0x0600019E RID: 414 RVA: 0x00002D16 File Offset: 0x00000F16
		public unsafe MethodInfo m_CreatePropertyMethod
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectedPropertyBagProvider.NativeFieldInfoPtr_m_CreatePropertyMethod);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectedPropertyBagProvider.NativeFieldInfoPtr_m_CreatePropertyMethod), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600019F RID: 415 RVA: 0x000080D4 File Offset: 0x000062D4
		// (set) Token: 0x060001A0 RID: 416 RVA: 0x00002D35 File Offset: 0x00000F35
		public unsafe MethodInfo m_CreatePropertyBagMethod
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectedPropertyBagProvider.NativeFieldInfoPtr_m_CreatePropertyBagMethod);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectedPropertyBagProvider.NativeFieldInfoPtr_m_CreatePropertyBagMethod), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x00008104 File Offset: 0x00006304
		// (set) Token: 0x060001A2 RID: 418 RVA: 0x00002D54 File Offset: 0x00000F54
		public unsafe MethodInfo m_CreateIndexedCollectionPropertyBagMethod
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectedPropertyBagProvider.NativeFieldInfoPtr_m_CreateIndexedCollectionPropertyBagMethod);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectedPropertyBagProvider.NativeFieldInfoPtr_m_CreateIndexedCollectionPropertyBagMethod), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060001A3 RID: 419 RVA: 0x00008134 File Offset: 0x00006334
		// (set) Token: 0x060001A4 RID: 420 RVA: 0x00002D73 File Offset: 0x00000F73
		public unsafe MethodInfo m_CreateSetPropertyBagMethod
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectedPropertyBagProvider.NativeFieldInfoPtr_m_CreateSetPropertyBagMethod);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectedPropertyBagProvider.NativeFieldInfoPtr_m_CreateSetPropertyBagMethod), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060001A5 RID: 421 RVA: 0x00008164 File Offset: 0x00006364
		// (set) Token: 0x060001A6 RID: 422 RVA: 0x00002D92 File Offset: 0x00000F92
		public unsafe MethodInfo m_CreateKeyValueCollectionPropertyBagMethod
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectedPropertyBagProvider.NativeFieldInfoPtr_m_CreateKeyValueCollectionPropertyBagMethod);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectedPropertyBagProvider.NativeFieldInfoPtr_m_CreateKeyValueCollectionPropertyBagMethod), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060001A7 RID: 423 RVA: 0x00008194 File Offset: 0x00006394
		// (set) Token: 0x060001A8 RID: 424 RVA: 0x00002DB1 File Offset: 0x00000FB1
		public unsafe MethodInfo m_CreateKeyValuePairPropertyBagMethod
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectedPropertyBagProvider.NativeFieldInfoPtr_m_CreateKeyValuePairPropertyBagMethod);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectedPropertyBagProvider.NativeFieldInfoPtr_m_CreateKeyValuePairPropertyBagMethod), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060001A9 RID: 425 RVA: 0x000081C4 File Offset: 0x000063C4
		// (set) Token: 0x060001AA RID: 426 RVA: 0x00002DD0 File Offset: 0x00000FD0
		public unsafe MethodInfo m_CreateArrayPropertyBagMethod
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectedPropertyBagProvider.NativeFieldInfoPtr_m_CreateArrayPropertyBagMethod);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectedPropertyBagProvider.NativeFieldInfoPtr_m_CreateArrayPropertyBagMethod), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060001AB RID: 427 RVA: 0x000081F4 File Offset: 0x000063F4
		// (set) Token: 0x060001AC RID: 428 RVA: 0x00002DEF File Offset: 0x00000FEF
		public unsafe MethodInfo m_CreateListPropertyBagMethod
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectedPropertyBagProvider.NativeFieldInfoPtr_m_CreateListPropertyBagMethod);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectedPropertyBagProvider.NativeFieldInfoPtr_m_CreateListPropertyBagMethod), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060001AD RID: 429 RVA: 0x00008224 File Offset: 0x00006424
		// (set) Token: 0x060001AE RID: 430 RVA: 0x00002E0E File Offset: 0x0000100E
		public unsafe MethodInfo m_CreateHashSetPropertyBagMethod
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectedPropertyBagProvider.NativeFieldInfoPtr_m_CreateHashSetPropertyBagMethod);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectedPropertyBagProvider.NativeFieldInfoPtr_m_CreateHashSetPropertyBagMethod), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060001AF RID: 431 RVA: 0x00008254 File Offset: 0x00006454
		// (set) Token: 0x060001B0 RID: 432 RVA: 0x00002E2D File Offset: 0x0000102D
		public unsafe MethodInfo m_CreateDictionaryPropertyBagMethod
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectedPropertyBagProvider.NativeFieldInfoPtr_m_CreateDictionaryPropertyBagMethod);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectedPropertyBagProvider.NativeFieldInfoPtr_m_CreateDictionaryPropertyBagMethod), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeFieldInfoPtr_m_CreatePropertyMethod;

		// Token: 0x040000B1 RID: 177
		private static readonly IntPtr NativeFieldInfoPtr_m_CreatePropertyBagMethod;

		// Token: 0x040000B2 RID: 178
		private static readonly IntPtr NativeFieldInfoPtr_m_CreateIndexedCollectionPropertyBagMethod;

		// Token: 0x040000B3 RID: 179
		private static readonly IntPtr NativeFieldInfoPtr_m_CreateSetPropertyBagMethod;

		// Token: 0x040000B4 RID: 180
		private static readonly IntPtr NativeFieldInfoPtr_m_CreateKeyValueCollectionPropertyBagMethod;

		// Token: 0x040000B5 RID: 181
		private static readonly IntPtr NativeFieldInfoPtr_m_CreateKeyValuePairPropertyBagMethod;

		// Token: 0x040000B6 RID: 182
		private static readonly IntPtr NativeFieldInfoPtr_m_CreateArrayPropertyBagMethod;

		// Token: 0x040000B7 RID: 183
		private static readonly IntPtr NativeFieldInfoPtr_m_CreateListPropertyBagMethod;

		// Token: 0x040000B8 RID: 184
		private static readonly IntPtr NativeFieldInfoPtr_m_CreateHashSetPropertyBagMethod;

		// Token: 0x040000B9 RID: 185
		private static readonly IntPtr NativeFieldInfoPtr_m_CreateDictionaryPropertyBagMethod;

		// Token: 0x040000BA RID: 186
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040000BB RID: 187
		private static readonly IntPtr NativeMethodInfoPtr_CreatePropertyBag_Public_IPropertyBag_Type_0;

		// Token: 0x040000BC RID: 188
		private static readonly IntPtr NativeMethodInfoPtr_CreatePropertyBag_Public_IPropertyBag_1_TContainer_0;

		// Token: 0x040000BD RID: 189
		private static readonly IntPtr NativeMethodInfoPtr_CreateProperty_Private_Void_IMemberInfo_ReflectedPropertyBag_1_TContainer_0;

		// Token: 0x040000BE RID: 190
		private static readonly IntPtr NativeMethodInfoPtr_CreateIndexedCollectionPropertyBag_Private_IPropertyBag_1_TList_0;

		// Token: 0x040000BF RID: 191
		private static readonly IntPtr NativeMethodInfoPtr_CreateSetPropertyBag_Private_IPropertyBag_1_TSet_0;

		// Token: 0x040000C0 RID: 192
		private static readonly IntPtr NativeMethodInfoPtr_CreateKeyValueCollectionPropertyBag_Private_IPropertyBag_1_TDictionary_0;

		// Token: 0x040000C1 RID: 193
		private static readonly IntPtr NativeMethodInfoPtr_CreateKeyValuePairPropertyBag_Private_IPropertyBag_1_KeyValuePair_2_TKey_TValue_0;

		// Token: 0x040000C2 RID: 194
		private static readonly IntPtr NativeMethodInfoPtr_CreateArrayPropertyBag_Private_IPropertyBag_1_Il2CppArrayBase_1_TElement_0;

		// Token: 0x040000C3 RID: 195
		private static readonly IntPtr NativeMethodInfoPtr_CreateListPropertyBag_Private_IPropertyBag_1_List_1_TElement_0;

		// Token: 0x040000C4 RID: 196
		private static readonly IntPtr NativeMethodInfoPtr_CreateHashSetPropertyBag_Private_IPropertyBag_1_HashSet_1_TElement_0;

		// Token: 0x040000C5 RID: 197
		private static readonly IntPtr NativeMethodInfoPtr_CreateDictionaryPropertyBag_Private_IPropertyBag_1_Dictionary_2_TKey_TValue_0;

		// Token: 0x040000C6 RID: 198
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertyMembers_Private_Static_IEnumerable_1_MemberInfo_Type_0;

		// Token: 0x040000C7 RID: 199
		private static readonly IntPtr NativeMethodInfoPtr_IsValidMember_Private_Static_Boolean_MemberInfo_0;

		// Token: 0x040000C8 RID: 200
		private static readonly IntPtr NativeMethodInfoPtr_IsValidPropertyType_Private_Static_Boolean_Type_0;

		// Token: 0x020000A1 RID: 161
		[ObfuscatedName("Unity.Properties.Internal.ReflectedPropertyBagProvider+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060002EB RID: 747 RVA: 0x0000BFD8 File Offset: 0x0000A1D8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ReflectedPropertyBagProvider.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReflectedPropertyBagProvider>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReflectedPropertyBagProvider.__c>.NativeClassPtr);
				ReflectedPropertyBagProvider.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectedPropertyBagProvider.__c>.NativeClassPtr, "<>9");
				ReflectedPropertyBagProvider.__c.NativeFieldInfoPtr___9__10_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectedPropertyBagProvider.__c>.NativeClassPtr, "<>9__10_0");
				ReflectedPropertyBagProvider.__c.NativeFieldInfoPtr___9__22_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectedPropertyBagProvider.__c>.NativeClassPtr, "<>9__22_0");
				ReflectedPropertyBagProvider.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectedPropertyBagProvider.__c>.NativeClassPtr, 100663551);
				ReflectedPropertyBagProvider.__c.NativeMethodInfoPtr___ctor_b__10_0_Internal_Boolean_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectedPropertyBagProvider.__c>.NativeClassPtr, 100663552);
				ReflectedPropertyBagProvider.__c.NativeMethodInfoPtr__GetPropertyMembers_b__22_0_Internal_Int32_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectedPropertyBagProvider.__c>.NativeClassPtr, 100663553);
			}

			// Token: 0x060002EC RID: 748 RVA: 0x0000C07C File Offset: 0x0000A27C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectedPropertyBagProvider.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectedPropertyBagProvider.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002ED RID: 749 RVA: 0x0000C0B8 File Offset: 0x0000A2B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232755, XrefRangeEnd = 1232758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool __ctor_b__10_0(MethodInfo x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectedPropertyBagProvider.__c.NativeMethodInfoPtr___ctor_b__10_0_Internal_Boolean_MethodInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060002EE RID: 750 RVA: 0x0000C108 File Offset: 0x0000A308
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetPropertyMembers_b__22_0(MemberInfo x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectedPropertyBagProvider.__c.NativeMethodInfoPtr__GetPropertyMembers_b__22_0_Internal_Int32_MemberInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060002EF RID: 751 RVA: 0x00003417 File Offset: 0x00001617
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000A4 RID: 164
			// (get) Token: 0x060002F0 RID: 752 RVA: 0x0000C158 File Offset: 0x0000A358
			// (set) Token: 0x060002F1 RID: 753 RVA: 0x00003420 File Offset: 0x00001620
			public unsafe static ReflectedPropertyBagProvider.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ReflectedPropertyBagProvider.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReflectedPropertyBagProvider.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ReflectedPropertyBagProvider.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000A5 RID: 165
			// (get) Token: 0x060002F2 RID: 754 RVA: 0x0000C180 File Offset: 0x0000A380
			// (set) Token: 0x060002F3 RID: 755 RVA: 0x00003432 File Offset: 0x00001632
			public unsafe static Func<MethodInfo, bool> __9__10_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ReflectedPropertyBagProvider.__c.NativeFieldInfoPtr___9__10_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<MethodInfo, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ReflectedPropertyBagProvider.__c.NativeFieldInfoPtr___9__10_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000A6 RID: 166
			// (get) Token: 0x060002F4 RID: 756 RVA: 0x0000C1A8 File Offset: 0x0000A3A8
			// (set) Token: 0x060002F5 RID: 757 RVA: 0x00003444 File Offset: 0x00001644
			public unsafe static Func<MemberInfo, int> __9__22_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ReflectedPropertyBagProvider.__c.NativeFieldInfoPtr___9__22_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<MemberInfo, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ReflectedPropertyBagProvider.__c.NativeFieldInfoPtr___9__22_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000171 RID: 369
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000172 RID: 370
			private static readonly IntPtr NativeFieldInfoPtr___9__10_0;

			// Token: 0x04000173 RID: 371
			private static readonly IntPtr NativeFieldInfoPtr___9__22_0;

			// Token: 0x04000174 RID: 372
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000175 RID: 373
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__10_0_Internal_Boolean_MethodInfo_0;

			// Token: 0x04000176 RID: 374
			private static readonly IntPtr NativeMethodInfoPtr__GetPropertyMembers_b__22_0_Internal_Int32_MemberInfo_0;
		}

		// Token: 0x020000A2 RID: 162
		[ObfuscatedName("Unity.Properties.Internal.ReflectedPropertyBagProvider+<GetPropertyMembers>d__22")]
		public sealed class _GetPropertyMembers_d__22 : Object
		{
			// Token: 0x060002F6 RID: 758 RVA: 0x0000C1D0 File Offset: 0x0000A3D0
			// Note: this type is marked as 'beforefieldinit'.
			static _GetPropertyMembers_d__22()
			{
				Il2CppClassPointerStore<ReflectedPropertyBagProvider._GetPropertyMembers_d__22>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReflectedPropertyBagProvider>.NativeClassPtr, "<GetPropertyMembers>d__22");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReflectedPropertyBagProvider._GetPropertyMembers_d__22>.NativeClassPtr);
				ReflectedPropertyBagProvider._GetPropertyMembers_d__22.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectedPropertyBagProvider._GetPropertyMembers_d__22>.NativeClassPtr, "<>1__state");
				ReflectedPropertyBagProvider._GetPropertyMembers_d__22.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectedPropertyBagProvider._GetPropertyMembers_d__22>.NativeClassPtr, "<>2__current");
				ReflectedPropertyBagProvider._GetPropertyMembers_d__22.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectedPropertyBagProvider._GetPropertyMembers_d__22>.NativeClassPtr, "<>l__initialThreadId");
				ReflectedPropertyBagProvider._GetPropertyMembers_d__22.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectedPropertyBagProvider._GetPropertyMembers_d__22>.NativeClassPtr, "type");
				ReflectedPropertyBagProvider._GetPropertyMembers_d__22.NativeFieldInfoPtr___3__type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectedPropertyBagProvider._GetPropertyMembers_d__22>.NativeClassPtr, "<>3__type");
				ReflectedPropertyBagProvider._GetPropertyMembers_d__22.NativeFieldInfoPtr__members_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectedPropertyBagProvider._GetPropertyMembers_d__22>.NativeClassPtr, "<members>5__1");
				ReflectedPropertyBagProvider._GetPropertyMembers_d__22.NativeFieldInfoPtr___s__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectedPropertyBagProvider._GetPropertyMembers_d__22>.NativeClassPtr, "<>s__2");
				ReflectedPropertyBagProvider._GetPropertyMembers_d__22.NativeFieldInfoPtr__member_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectedPropertyBagProvider._GetPropertyMembers_d__22>.NativeClassPtr, "<member>5__3");
				ReflectedPropertyBagProvider._GetPropertyMembers_d__22.NativeFieldInfoPtr__hasDontCreatePropertyAttribute_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectedPropertyBagProvider._GetPropertyMembers_d__22>.NativeClassPtr, "<hasDontCreatePropertyAttribute>5__4");
				ReflectedPropertyBagProvider._GetPropertyMembers_d__22.NativeFieldInfoPtr__hasCreatePropertyAttribute_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectedPropertyBagProvider._GetPropertyMembers_d__22>.NativeClassPtr, "<hasCreatePropertyAttribute>5__5");
				ReflectedPropertyBagProvider._GetPropertyMembers_d__22.NativeFieldInfoPtr__hasNonSerializedAttribute_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectedPropertyBagProvider._GetPropertyMembers_d__22>.NativeClassPtr, "<hasNonSerializedAttribute>5__6");
				ReflectedPropertyBagProvider._GetPropertyMembers_d__22.NativeFieldInfoPtr__hasSerializedFieldAttribute_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectedPropertyBagProvider._GetPropertyMembers_d__22>.NativeClassPtr, "<hasSerializedFieldAttribute>5__7");
				ReflectedPropertyBagProvider._GetPropertyMembers_d__22.NativeFieldInfoPtr__field_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectedPropertyBagProvider._GetPropertyMembers_d__22>.NativeClassPtr, "<field>5__8");
				ReflectedPropertyBagProvider._GetPropertyMembers_d__22.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectedPropertyBagProvider._GetPropertyMembers_d__22>.NativeClassPtr, 100663554);
				ReflectedPropertyBagProvider._GetPropertyMembers_d__22.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectedPropertyBagProvider._GetPropertyMembers_d__22>.NativeClassPtr, 100663555);
				ReflectedPropertyBagProvider._GetPropertyMembers_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectedPropertyBagProvider._GetPropertyMembers_d__22>.NativeClassPtr, 100663556);
				ReflectedPropertyBagProvider._GetPropertyMembers_d__22.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectedPropertyBagProvider._GetPropertyMembers_d__22>.NativeClassPtr, 100663557);
				ReflectedPropertyBagProvider._GetPropertyMembers_d__22.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Reflection_MemberInfo__get_Current_Private_Virtual_Final_New_get_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectedPropertyBagProvider._GetPropertyMembers_d__22>.NativeClassPtr, 100663558);
				ReflectedPropertyBagProvider._GetPropertyMembers_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectedPropertyBagProvider._GetPropertyMembers_d__22>.NativeClassPtr, 100663559);
				ReflectedPropertyBagProvider._GetPropertyMembers_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectedPropertyBagProvider._GetPropertyMembers_d__22>.NativeClassPtr, 100663560);
				ReflectedPropertyBagProvider._GetPropertyMembers_d__22.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Reflection_MemberInfo__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectedPropertyBagProvider._GetPropertyMembers_d__22>.NativeClassPtr, 100663561);
				ReflectedPropertyBagProvider._GetPropertyMembers_d__22.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectedPropertyBagProvider._GetPropertyMembers_d__22>.NativeClassPtr, 100663562);
			}

			// Token: 0x060002F7 RID: 759 RVA: 0x0000C3B4 File Offset: 0x0000A5B4
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetPropertyMembers_d__22(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectedPropertyBagProvider._GetPropertyMembers_d__22>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectedPropertyBagProvider._GetPropertyMembers_d__22.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060002F8 RID: 760 RVA: 0x0000C3FC File Offset: 0x0000A5FC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1232763, RefRangeEnd = 1232764, XrefRangeStart = 1232758, XrefRangeEnd = 1232763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectedPropertyBagProvider._GetPropertyMembers_d__22.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002F9 RID: 761 RVA: 0x0000C430 File Offset: 0x0000A630
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232764, XrefRangeEnd = 1232851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectedPropertyBagProvider._GetPropertyMembers_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060002FA RID: 762 RVA: 0x0000C46C File Offset: 0x0000A66C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232851, XrefRangeEnd = 1232854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectedPropertyBagProvider._GetPropertyMembers_d__22.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170000B4 RID: 180
			// (get) Token: 0x060002FB RID: 763 RVA: 0x0000C4A0 File Offset: 0x0000A6A0
			public unsafe MemberInfo System.Collections.Generic.IEnumerator<System.Reflection.MemberInfo>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectedPropertyBagProvider._GetPropertyMembers_d__22.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Reflection_MemberInfo__get_Current_Private_Virtual_Final_New_get_MemberInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<MemberInfo>(intPtr3) : null;
				}
			}

			// Token: 0x060002FC RID: 764 RVA: 0x0000C4E0 File Offset: 0x0000A6E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232854, XrefRangeEnd = 1232859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectedPropertyBagProvider._GetPropertyMembers_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170000B5 RID: 181
			// (get) Token: 0x060002FD RID: 765 RVA: 0x0000C514 File Offset: 0x0000A714
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectedPropertyBagProvider._GetPropertyMembers_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060002FE RID: 766 RVA: 0x0000C554 File Offset: 0x0000A754
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232859, XrefRangeEnd = 1232867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<MemberInfo> System_Collections_Generic_IEnumerable_System_Reflection_MemberInfo__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectedPropertyBagProvider._GetPropertyMembers_d__22.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Reflection_MemberInfo__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_MemberInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<MemberInfo>>(intPtr3) : null;
			}

			// Token: 0x060002FF RID: 767 RVA: 0x0000C594 File Offset: 0x0000A794
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectedPropertyBagProvider._GetPropertyMembers_d__22.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06000300 RID: 768 RVA: 0x00003456 File Offset: 0x00001656
			public _GetPropertyMembers_d__22(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000A7 RID: 167
			// (get) Token: 0x06000301 RID: 769 RVA: 0x0000C5D4 File Offset: 0x0000A7D4
			// (set) Token: 0x06000302 RID: 770 RVA: 0x0000345F File Offset: 0x0000165F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectedPropertyBagProvider._GetPropertyMembers_d__22.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectedPropertyBagProvider._GetPropertyMembers_d__22.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170000A8 RID: 168
			// (get) Token: 0x06000303 RID: 771 RVA: 0x0000C5FC File Offset: 0x0000A7FC
			// (set) Token: 0x06000304 RID: 772 RVA: 0x0000347A File Offset: 0x0000167A
			public unsafe MemberInfo __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectedPropertyBagProvider._GetPropertyMembers_d__22.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MemberInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectedPropertyBagProvider._GetPropertyMembers_d__22.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000A9 RID: 169
			// (get) Token: 0x06000305 RID: 773 RVA: 0x0000C62C File Offset: 0x0000A82C
			// (set) Token: 0x06000306 RID: 774 RVA: 0x00003499 File Offset: 0x00001699
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectedPropertyBagProvider._GetPropertyMembers_d__22.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectedPropertyBagProvider._GetPropertyMembers_d__22.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170000AA RID: 170
			// (get) Token: 0x06000307 RID: 775 RVA: 0x0000C654 File Offset: 0x0000A854
			// (set) Token: 0x06000308 RID: 776 RVA: 0x000034B4 File Offset: 0x000016B4
			public unsafe Type type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectedPropertyBagProvider._GetPropertyMembers_d__22.NativeFieldInfoPtr_type);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectedPropertyBagProvider._GetPropertyMembers_d__22.NativeFieldInfoPtr_type), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000AB RID: 171
			// (get) Token: 0x06000309 RID: 777 RVA: 0x0000C684 File Offset: 0x0000A884
			// (set) Token: 0x0600030A RID: 778 RVA: 0x000034D3 File Offset: 0x000016D3
			public unsafe Type __3__type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectedPropertyBagProvider._GetPropertyMembers_d__22.NativeFieldInfoPtr___3__type);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectedPropertyBagProvider._GetPropertyMembers_d__22.NativeFieldInfoPtr___3__type), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000AC RID: 172
			// (get) Token: 0x0600030B RID: 779 RVA: 0x0000C6B4 File Offset: 0x0000A8B4
			// (set) Token: 0x0600030C RID: 780 RVA: 0x000034F2 File Offset: 0x000016F2
			public unsafe IOrderedEnumerable<MemberInfo> _members_5__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectedPropertyBagProvider._GetPropertyMembers_d__22.NativeFieldInfoPtr__members_5__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IOrderedEnumerable<MemberInfo>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectedPropertyBagProvider._GetPropertyMembers_d__22.NativeFieldInfoPtr__members_5__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000AD RID: 173
			// (get) Token: 0x0600030D RID: 781 RVA: 0x0000C6E4 File Offset: 0x0000A8E4
			// (set) Token: 0x0600030E RID: 782 RVA: 0x00003511 File Offset: 0x00001711
			public unsafe IEnumerator<MemberInfo> __s__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectedPropertyBagProvider._GetPropertyMembers_d__22.NativeFieldInfoPtr___s__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<MemberInfo>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectedPropertyBagProvider._GetPropertyMembers_d__22.NativeFieldInfoPtr___s__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000AE RID: 174
			// (get) Token: 0x0600030F RID: 783 RVA: 0x0000C714 File Offset: 0x0000A914
			// (set) Token: 0x06000310 RID: 784 RVA: 0x00003530 File Offset: 0x00001730
			public unsafe MemberInfo _member_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectedPropertyBagProvider._GetPropertyMembers_d__22.NativeFieldInfoPtr__member_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MemberInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectedPropertyBagProvider._GetPropertyMembers_d__22.NativeFieldInfoPtr__member_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000AF RID: 175
			// (get) Token: 0x06000311 RID: 785 RVA: 0x0000C744 File Offset: 0x0000A944
			// (set) Token: 0x06000312 RID: 786 RVA: 0x0000354F File Offset: 0x0000174F
			public unsafe bool _hasDontCreatePropertyAttribute_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectedPropertyBagProvider._GetPropertyMembers_d__22.NativeFieldInfoPtr__hasDontCreatePropertyAttribute_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectedPropertyBagProvider._GetPropertyMembers_d__22.NativeFieldInfoPtr__hasDontCreatePropertyAttribute_5__4)) = value;
				}
			}

			// Token: 0x170000B0 RID: 176
			// (get) Token: 0x06000313 RID: 787 RVA: 0x0000C76C File Offset: 0x0000A96C
			// (set) Token: 0x06000314 RID: 788 RVA: 0x0000356A File Offset: 0x0000176A
			public unsafe bool _hasCreatePropertyAttribute_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectedPropertyBagProvider._GetPropertyMembers_d__22.NativeFieldInfoPtr__hasCreatePropertyAttribute_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectedPropertyBagProvider._GetPropertyMembers_d__22.NativeFieldInfoPtr__hasCreatePropertyAttribute_5__5)) = value;
				}
			}

			// Token: 0x170000B1 RID: 177
			// (get) Token: 0x06000315 RID: 789 RVA: 0x0000C794 File Offset: 0x0000A994
			// (set) Token: 0x06000316 RID: 790 RVA: 0x00003585 File Offset: 0x00001785
			public unsafe bool _hasNonSerializedAttribute_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectedPropertyBagProvider._GetPropertyMembers_d__22.NativeFieldInfoPtr__hasNonSerializedAttribute_5__6);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectedPropertyBagProvider._GetPropertyMembers_d__22.NativeFieldInfoPtr__hasNonSerializedAttribute_5__6)) = value;
				}
			}

			// Token: 0x170000B2 RID: 178
			// (get) Token: 0x06000317 RID: 791 RVA: 0x0000C7BC File Offset: 0x0000A9BC
			// (set) Token: 0x06000318 RID: 792 RVA: 0x000035A0 File Offset: 0x000017A0
			public unsafe bool _hasSerializedFieldAttribute_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectedPropertyBagProvider._GetPropertyMembers_d__22.NativeFieldInfoPtr__hasSerializedFieldAttribute_5__7);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectedPropertyBagProvider._GetPropertyMembers_d__22.NativeFieldInfoPtr__hasSerializedFieldAttribute_5__7)) = value;
				}
			}

			// Token: 0x170000B3 RID: 179
			// (get) Token: 0x06000319 RID: 793 RVA: 0x0000C7E4 File Offset: 0x0000A9E4
			// (set) Token: 0x0600031A RID: 794 RVA: 0x000035BB File Offset: 0x000017BB
			public unsafe FieldInfo _field_5__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectedPropertyBagProvider._GetPropertyMembers_d__22.NativeFieldInfoPtr__field_5__8);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FieldInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectedPropertyBagProvider._GetPropertyMembers_d__22.NativeFieldInfoPtr__field_5__8), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000177 RID: 375
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000178 RID: 376
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000179 RID: 377
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400017A RID: 378
			private static readonly IntPtr NativeFieldInfoPtr_type;

			// Token: 0x0400017B RID: 379
			private static readonly IntPtr NativeFieldInfoPtr___3__type;

			// Token: 0x0400017C RID: 380
			private static readonly IntPtr NativeFieldInfoPtr__members_5__1;

			// Token: 0x0400017D RID: 381
			private static readonly IntPtr NativeFieldInfoPtr___s__2;

			// Token: 0x0400017E RID: 382
			private static readonly IntPtr NativeFieldInfoPtr__member_5__3;

			// Token: 0x0400017F RID: 383
			private static readonly IntPtr NativeFieldInfoPtr__hasDontCreatePropertyAttribute_5__4;

			// Token: 0x04000180 RID: 384
			private static readonly IntPtr NativeFieldInfoPtr__hasCreatePropertyAttribute_5__5;

			// Token: 0x04000181 RID: 385
			private static readonly IntPtr NativeFieldInfoPtr__hasNonSerializedAttribute_5__6;

			// Token: 0x04000182 RID: 386
			private static readonly IntPtr NativeFieldInfoPtr__hasSerializedFieldAttribute_5__7;

			// Token: 0x04000183 RID: 387
			private static readonly IntPtr NativeFieldInfoPtr__field_5__8;

			// Token: 0x04000184 RID: 388
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000185 RID: 389
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000186 RID: 390
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000187 RID: 391
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04000188 RID: 392
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Reflection_MemberInfo__get_Current_Private_Virtual_Final_New_get_MemberInfo_0;

			// Token: 0x04000189 RID: 393
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400018A RID: 394
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400018B RID: 395
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Reflection_MemberInfo__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_MemberInfo_0;

			// Token: 0x0400018C RID: 396
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x020000A3 RID: 163
		private sealed class MethodInfoStoreGeneric_CreatePropertyBag_Public_IPropertyBag_1_TContainer_0<TContainer>
		{
			// Token: 0x0400018D RID: 397
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ReflectedPropertyBagProvider.NativeMethodInfoPtr_CreatePropertyBag_Public_IPropertyBag_1_TContainer_0, Il2CppClassPointerStore<ReflectedPropertyBagProvider>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TContainer>.NativeClassPtr)) }))));
		}

		// Token: 0x020000A4 RID: 164
		private sealed class MethodInfoStoreGeneric_CreateProperty_Private_Void_IMemberInfo_ReflectedPropertyBag_1_TContainer_0<TContainer, TValue>
		{
			// Token: 0x0400018E RID: 398
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ReflectedPropertyBagProvider.NativeMethodInfoPtr_CreateProperty_Private_Void_IMemberInfo_ReflectedPropertyBag_1_TContainer_0, Il2CppClassPointerStore<ReflectedPropertyBagProvider>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TContainer>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			}))));
		}

		// Token: 0x020000A5 RID: 165
		private sealed class MethodInfoStoreGeneric_CreateIndexedCollectionPropertyBag_Private_IPropertyBag_1_TList_0<TList, TElement>
		{
			// Token: 0x0400018F RID: 399
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ReflectedPropertyBagProvider.NativeMethodInfoPtr_CreateIndexedCollectionPropertyBag_Private_IPropertyBag_1_TList_0, Il2CppClassPointerStore<ReflectedPropertyBagProvider>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TList>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TElement>.NativeClassPtr))
			}))));
		}

		// Token: 0x020000A6 RID: 166
		private sealed class MethodInfoStoreGeneric_CreateSetPropertyBag_Private_IPropertyBag_1_TSet_0<TSet, TValue>
		{
			// Token: 0x04000190 RID: 400
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ReflectedPropertyBagProvider.NativeMethodInfoPtr_CreateSetPropertyBag_Private_IPropertyBag_1_TSet_0, Il2CppClassPointerStore<ReflectedPropertyBagProvider>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSet>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			}))));
		}

		// Token: 0x020000A7 RID: 167
		private sealed class MethodInfoStoreGeneric_CreateKeyValueCollectionPropertyBag_Private_IPropertyBag_1_TDictionary_0<TDictionary, TKey, TValue>
		{
			// Token: 0x04000191 RID: 401
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ReflectedPropertyBagProvider.NativeMethodInfoPtr_CreateKeyValueCollectionPropertyBag_Private_IPropertyBag_1_TDictionary_0, Il2CppClassPointerStore<ReflectedPropertyBagProvider>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TDictionary>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			}))));
		}

		// Token: 0x020000A8 RID: 168
		private sealed class MethodInfoStoreGeneric_CreateKeyValuePairPropertyBag_Private_IPropertyBag_1_KeyValuePair_2_TKey_TValue_0<TKey, TValue>
		{
			// Token: 0x04000192 RID: 402
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ReflectedPropertyBagProvider.NativeMethodInfoPtr_CreateKeyValuePairPropertyBag_Private_IPropertyBag_1_KeyValuePair_2_TKey_TValue_0, Il2CppClassPointerStore<ReflectedPropertyBagProvider>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			}))));
		}

		// Token: 0x020000A9 RID: 169
		private sealed class MethodInfoStoreGeneric_CreateArrayPropertyBag_Private_IPropertyBag_1_Il2CppArrayBase_1_TElement_0<TElement>
		{
			// Token: 0x04000193 RID: 403
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ReflectedPropertyBagProvider.NativeMethodInfoPtr_CreateArrayPropertyBag_Private_IPropertyBag_1_Il2CppArrayBase_1_TElement_0, Il2CppClassPointerStore<ReflectedPropertyBagProvider>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TElement>.NativeClassPtr)) }))));
		}

		// Token: 0x020000AA RID: 170
		private sealed class MethodInfoStoreGeneric_CreateListPropertyBag_Private_IPropertyBag_1_List_1_TElement_0<TElement>
		{
			// Token: 0x04000194 RID: 404
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ReflectedPropertyBagProvider.NativeMethodInfoPtr_CreateListPropertyBag_Private_IPropertyBag_1_List_1_TElement_0, Il2CppClassPointerStore<ReflectedPropertyBagProvider>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TElement>.NativeClassPtr)) }))));
		}

		// Token: 0x020000AB RID: 171
		private sealed class MethodInfoStoreGeneric_CreateHashSetPropertyBag_Private_IPropertyBag_1_HashSet_1_TElement_0<TElement>
		{
			// Token: 0x04000195 RID: 405
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ReflectedPropertyBagProvider.NativeMethodInfoPtr_CreateHashSetPropertyBag_Private_IPropertyBag_1_HashSet_1_TElement_0, Il2CppClassPointerStore<ReflectedPropertyBagProvider>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TElement>.NativeClassPtr)) }))));
		}

		// Token: 0x020000AC RID: 172
		private sealed class MethodInfoStoreGeneric_CreateDictionaryPropertyBag_Private_IPropertyBag_1_Dictionary_2_TKey_TValue_0<TKey, TValue>
		{
			// Token: 0x04000196 RID: 406
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ReflectedPropertyBagProvider.NativeMethodInfoPtr_CreateDictionaryPropertyBag_Private_IPropertyBag_1_Dictionary_2_TKey_TValue_0, Il2CppClassPointerStore<ReflectedPropertyBagProvider>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			}))));
		}

		// Token: 0x020000AD RID: 173
		[Serializable]
		public sealed class <>c
		{
		}

		// Token: 0x020000AE RID: 174
		public sealed class <GetPropertyMembers>d__22
		{
		}
	}
}
