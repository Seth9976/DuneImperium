using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Unity.Properties
{
	// Token: 0x02000017 RID: 23
	public class ListPropertyBag<TElement> : IndexedCollectionPropertyBag<List<TElement>, TElement>
	{
		// Token: 0x060000A9 RID: 169 RVA: 0x000057C8 File Offset: 0x000039C8
		// Note: this type is marked as 'beforefieldinit'.
		static ListPropertyBag()
		{
			Il2CppClassPointerStore<ListPropertyBag<TElement>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.PropertiesModule.dll", "Unity.Properties", "ListPropertyBag`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TElement>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListPropertyBag<TElement>>.NativeClassPtr);
			ListPropertyBag<TElement>.NativeMethodInfoPtr_get_InstantiationKind_Protected_Virtual_get_InstantiationKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListPropertyBag<TElement>>.NativeClassPtr, 100663367);
			ListPropertyBag<TElement>.NativeMethodInfoPtr_InstantiateWithCount_Protected_Virtual_List_1_TElement_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListPropertyBag<TElement>>.NativeClassPtr, 100663368);
			ListPropertyBag<TElement>.NativeMethodInfoPtr_Instantiate_Protected_Virtual_List_1_TElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListPropertyBag<TElement>>.NativeClassPtr, 100663369);
			ListPropertyBag<TElement>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListPropertyBag<TElement>>.NativeClassPtr, 100663370);
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000AA RID: 170 RVA: 0x00005884 File Offset: 0x00003A84
		public unsafe override InstantiationKind InstantiationKind
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ListPropertyBag<TElement>.NativeMethodInfoPtr_get_InstantiationKind_Protected_Virtual_get_InstantiationKind_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000AB RID: 171 RVA: 0x000058CC File Offset: 0x00003ACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230844, XrefRangeEnd = 1230846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override List<TElement> InstantiateWithCount(int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ListPropertyBag<TElement>.NativeMethodInfoPtr_InstantiateWithCount_Protected_Virtual_List_1_TElement_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<TElement>>(intPtr3) : null;
			}
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00005924 File Offset: 0x00003B24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230846, XrefRangeEnd = 1230848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override List<TElement> Instantiate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ListPropertyBag<TElement>.NativeMethodInfoPtr_Instantiate_Protected_Virtual_List_1_TElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<TElement>>(intPtr3) : null;
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00005970 File Offset: 0x00003B70
		[CallerCount(0)]
		public unsafe ListPropertyBag()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListPropertyBag<TElement>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListPropertyBag<TElement>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x0000256D File Offset: 0x0000076D
		public ListPropertyBag(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeMethodInfoPtr_get_InstantiationKind_Protected_Virtual_get_InstantiationKind_0;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeMethodInfoPtr_InstantiateWithCount_Protected_Virtual_List_1_TElement_Int32_0;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeMethodInfoPtr_Instantiate_Protected_Virtual_List_1_TElement_0;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
