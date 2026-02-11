using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Unity.Properties
{
	// Token: 0x0200000E RID: 14
	public sealed class ArrayPropertyBag<TElement> : IndexedCollectionPropertyBag<Il2CppArrayBase<TElement>, TElement>
	{
		// Token: 0x0600006C RID: 108 RVA: 0x00004B0C File Offset: 0x00002D0C
		// Note: this type is marked as 'beforefieldinit'.
		static ArrayPropertyBag()
		{
			Il2CppClassPointerStore<ArrayPropertyBag<TElement>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.PropertiesModule.dll", "Unity.Properties", "ArrayPropertyBag`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TElement>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArrayPropertyBag<TElement>>.NativeClassPtr);
			ArrayPropertyBag<TElement>.NativeMethodInfoPtr_get_InstantiationKind_Protected_Virtual_get_InstantiationKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayPropertyBag<TElement>>.NativeClassPtr, 100663336);
			ArrayPropertyBag<TElement>.NativeMethodInfoPtr_InstantiateWithCount_Protected_Virtual_Il2CppArrayBase_1_TElement_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayPropertyBag<TElement>>.NativeClassPtr, 100663337);
			ArrayPropertyBag<TElement>.NativeMethodInfoPtr_Instantiate_Protected_Virtual_Il2CppArrayBase_1_TElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayPropertyBag<TElement>>.NativeClassPtr, 100663338);
			ArrayPropertyBag<TElement>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayPropertyBag<TElement>>.NativeClassPtr, 100663339);
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600006D RID: 109 RVA: 0x00004BC8 File Offset: 0x00002DC8
		public unsafe override InstantiationKind InstantiationKind
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayPropertyBag<TElement>.NativeMethodInfoPtr_get_InstantiationKind_Protected_Virtual_get_InstantiationKind_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00004C04 File Offset: 0x00002E04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230669, XrefRangeEnd = 1230671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppArrayBase<TElement> InstantiateWithCount(int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayPropertyBag<TElement>.NativeMethodInfoPtr_InstantiateWithCount_Protected_Virtual_Il2CppArrayBase_1_TElement_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return Il2CppArrayBase<TElement>.WrapNativeGenericArrayPointer(intPtr);
			}
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00004C48 File Offset: 0x00002E48
		[CallerCount(0)]
		public unsafe override Il2CppArrayBase<TElement> Instantiate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayPropertyBag<TElement>.NativeMethodInfoPtr_Instantiate_Protected_Virtual_Il2CppArrayBase_1_TElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return Il2CppArrayBase<TElement>.WrapNativeGenericArrayPointer(intPtr);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00004C80 File Offset: 0x00002E80
		[CallerCount(0)]
		public unsafe ArrayPropertyBag()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArrayPropertyBag<TElement>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayPropertyBag<TElement>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x000023E5 File Offset: 0x000005E5
		public ArrayPropertyBag(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeMethodInfoPtr_get_InstantiationKind_Protected_Virtual_get_InstantiationKind_0;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeMethodInfoPtr_InstantiateWithCount_Protected_Virtual_Il2CppArrayBase_1_TElement_Int32_0;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeMethodInfoPtr_Instantiate_Protected_Virtual_Il2CppArrayBase_1_TElement_0;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
