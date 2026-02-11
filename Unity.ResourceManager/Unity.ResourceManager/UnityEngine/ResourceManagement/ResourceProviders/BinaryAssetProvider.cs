using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.ResourceManagement.ResourceProviders
{
	// Token: 0x02000033 RID: 51
	public class BinaryAssetProvider<TAdapter> : BinaryDataProvider where TAdapter : new()
	{
		// Token: 0x060002D2 RID: 722 RVA: 0x0000FAAC File Offset: 0x0000DCAC
		// Note: this type is marked as 'beforefieldinit'.
		static BinaryAssetProvider()
		{
			Il2CppClassPointerStore<BinaryAssetProvider<TAdapter>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.ResourceManager.dll", "UnityEngine.ResourceManagement.ResourceProviders", "BinaryAssetProvider`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TAdapter>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinaryAssetProvider<TAdapter>>.NativeClassPtr);
			BinaryAssetProvider<TAdapter>.NativeMethodInfoPtr_Convert_Public_Virtual_Object_Type_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryAssetProvider<TAdapter>>.NativeClassPtr, 100663746);
			BinaryAssetProvider<TAdapter>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryAssetProvider<TAdapter>>.NativeClassPtr, 100663747);
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x0000FB40 File Offset: 0x0000DD40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1139940, XrefRangeEnd = 1139952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object Convert(Type type, Il2CppStructArray<byte> data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryAssetProvider<TAdapter>.NativeMethodInfoPtr_Convert_Public_Virtual_Object_Type_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x0000FBB0 File Offset: 0x0000DDB0
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinaryAssetProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryAssetProvider<TAdapter>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryAssetProvider<TAdapter>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x00003290 File Offset: 0x00001490
		public BinaryAssetProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001F0 RID: 496
		private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Object_Type_Il2CppStructArray_1_Byte_0;

		// Token: 0x040001F1 RID: 497
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
