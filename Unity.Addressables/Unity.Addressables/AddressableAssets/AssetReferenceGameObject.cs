using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.AddressableAssets
{
	// Token: 0x0200000D RID: 13
	[Serializable]
	public class AssetReferenceGameObject : AssetReferenceT<GameObject>
	{
		// Token: 0x0600019E RID: 414 RVA: 0x000025C4 File Offset: 0x000007C4
		// Note: this type is marked as 'beforefieldinit'.
		static AssetReferenceGameObject()
		{
			Il2CppClassPointerStore<AssetReferenceGameObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Addressables.dll", "UnityEngine.AddressableAssets", "AssetReferenceGameObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetReferenceGameObject>.NativeClassPtr);
			AssetReferenceGameObject.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetReferenceGameObject>.NativeClassPtr, 100663679);
		}

		// Token: 0x0600019F RID: 415 RVA: 0x0000CC14 File Offset: 0x0000AE14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161946, XrefRangeEnd = 1161949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssetReferenceGameObject(string guid)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetReferenceGameObject>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetReferenceGameObject.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x000025FD File Offset: 0x000007FD
		public AssetReferenceGameObject(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000159 RID: 345
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
