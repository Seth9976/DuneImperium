using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.AddressableAssets
{
	// Token: 0x0200000E RID: 14
	[Serializable]
	public class AssetReferenceTexture : AssetReferenceT<Texture>
	{
		// Token: 0x060001A1 RID: 417 RVA: 0x00002606 File Offset: 0x00000806
		// Note: this type is marked as 'beforefieldinit'.
		static AssetReferenceTexture()
		{
			Il2CppClassPointerStore<AssetReferenceTexture>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Addressables.dll", "UnityEngine.AddressableAssets", "AssetReferenceTexture");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetReferenceTexture>.NativeClassPtr);
			AssetReferenceTexture.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetReferenceTexture>.NativeClassPtr, 100663680);
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x0000CC60 File Offset: 0x0000AE60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161949, XrefRangeEnd = 1161952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssetReferenceTexture(string guid)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetReferenceTexture>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetReferenceTexture.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x0000263F File Offset: 0x0000083F
		public AssetReferenceTexture(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400015A RID: 346
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
