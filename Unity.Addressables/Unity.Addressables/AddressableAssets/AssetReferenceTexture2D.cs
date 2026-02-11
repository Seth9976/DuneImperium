using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.AddressableAssets
{
	// Token: 0x0200000F RID: 15
	[Serializable]
	public class AssetReferenceTexture2D : AssetReferenceT<Texture2D>
	{
		// Token: 0x060001A4 RID: 420 RVA: 0x00002648 File Offset: 0x00000848
		// Note: this type is marked as 'beforefieldinit'.
		static AssetReferenceTexture2D()
		{
			Il2CppClassPointerStore<AssetReferenceTexture2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Addressables.dll", "UnityEngine.AddressableAssets", "AssetReferenceTexture2D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetReferenceTexture2D>.NativeClassPtr);
			AssetReferenceTexture2D.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetReferenceTexture2D>.NativeClassPtr, 100663681);
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x0000CCAC File Offset: 0x0000AEAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161952, XrefRangeEnd = 1161955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssetReferenceTexture2D(string guid)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetReferenceTexture2D>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetReferenceTexture2D.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00002681 File Offset: 0x00000881
		public AssetReferenceTexture2D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400015B RID: 347
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
