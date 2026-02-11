using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Unity.Properties
{
	// Token: 0x02000010 RID: 16
	public class DictionaryPropertyBag<TKey, TValue> : KeyValueCollectionPropertyBag<Dictionary<TKey, TValue>, TKey, TValue>
	{
		// Token: 0x0600007B RID: 123 RVA: 0x00004F00 File Offset: 0x00003100
		// Note: this type is marked as 'beforefieldinit'.
		static DictionaryPropertyBag()
		{
			Il2CppClassPointerStore<DictionaryPropertyBag<TKey, TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.PropertiesModule.dll", "Unity.Properties", "DictionaryPropertyBag`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DictionaryPropertyBag<TKey, TValue>>.NativeClassPtr);
			DictionaryPropertyBag<TKey, TValue>.NativeMethodInfoPtr_get_InstantiationKind_Protected_Virtual_get_InstantiationKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictionaryPropertyBag<TKey, TValue>>.NativeClassPtr, 100663344);
			DictionaryPropertyBag<TKey, TValue>.NativeMethodInfoPtr_Instantiate_Protected_Virtual_Dictionary_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictionaryPropertyBag<TKey, TValue>>.NativeClassPtr, 100663345);
			DictionaryPropertyBag<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictionaryPropertyBag<TKey, TValue>>.NativeClassPtr, 100663346);
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600007C RID: 124 RVA: 0x00004FBC File Offset: 0x000031BC
		public unsafe override InstantiationKind InstantiationKind
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DictionaryPropertyBag<TKey, TValue>.NativeMethodInfoPtr_get_InstantiationKind_Protected_Virtual_get_InstantiationKind_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00005004 File Offset: 0x00003204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230793, XrefRangeEnd = 1230795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Dictionary<TKey, TValue> Instantiate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DictionaryPropertyBag<TKey, TValue>.NativeMethodInfoPtr_Instantiate_Protected_Virtual_Dictionary_2_TKey_TValue_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<TKey, TValue>>(intPtr3) : null;
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00005050 File Offset: 0x00003250
		[CallerCount(0)]
		public unsafe DictionaryPropertyBag()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DictionaryPropertyBag<TKey, TValue>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictionaryPropertyBag<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00002435 File Offset: 0x00000635
		public DictionaryPropertyBag(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeMethodInfoPtr_get_InstantiationKind_Protected_Virtual_get_InstantiationKind_0;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeMethodInfoPtr_Instantiate_Protected_Virtual_Dictionary_2_TKey_TValue_0;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
