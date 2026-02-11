using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Unity.Properties
{
	// Token: 0x02000011 RID: 17
	public class HashSetPropertyBag<TElement> : SetPropertyBagBase<HashSet<TElement>, TElement>
	{
		// Token: 0x06000080 RID: 128 RVA: 0x0000508C File Offset: 0x0000328C
		// Note: this type is marked as 'beforefieldinit'.
		static HashSetPropertyBag()
		{
			Il2CppClassPointerStore<HashSetPropertyBag<TElement>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.PropertiesModule.dll", "Unity.Properties", "HashSetPropertyBag`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TElement>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HashSetPropertyBag<TElement>>.NativeClassPtr);
			HashSetPropertyBag<TElement>.NativeMethodInfoPtr_get_InstantiationKind_Protected_Virtual_get_InstantiationKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSetPropertyBag<TElement>>.NativeClassPtr, 100663347);
			HashSetPropertyBag<TElement>.NativeMethodInfoPtr_Instantiate_Protected_Virtual_HashSet_1_TElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSetPropertyBag<TElement>>.NativeClassPtr, 100663348);
			HashSetPropertyBag<TElement>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSetPropertyBag<TElement>>.NativeClassPtr, 100663349);
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000081 RID: 129 RVA: 0x00005134 File Offset: 0x00003334
		public unsafe override InstantiationKind InstantiationKind
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HashSetPropertyBag<TElement>.NativeMethodInfoPtr_get_InstantiationKind_Protected_Virtual_get_InstantiationKind_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000082 RID: 130 RVA: 0x0000517C File Offset: 0x0000337C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override HashSet<TElement> Instantiate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HashSetPropertyBag<TElement>.NativeMethodInfoPtr_Instantiate_Protected_Virtual_HashSet_1_TElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<HashSet<TElement>>(intPtr3) : null;
		}

		// Token: 0x06000083 RID: 131 RVA: 0x000051C8 File Offset: 0x000033C8
		[CallerCount(0)]
		public unsafe HashSetPropertyBag()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HashSetPropertyBag<TElement>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashSetPropertyBag<TElement>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x0000243E File Offset: 0x0000063E
		public HashSetPropertyBag(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeMethodInfoPtr_get_InstantiationKind_Protected_Virtual_get_InstantiationKind_0;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeMethodInfoPtr_Instantiate_Protected_Virtual_HashSet_1_TElement_0;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
