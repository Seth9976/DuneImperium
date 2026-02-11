using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.AddressableAssets
{
	// Token: 0x02000010 RID: 16
	[Serializable]
	public class AssetReferenceTexture3D : AssetReferenceT<Texture3D>
	{
		// Token: 0x060001A7 RID: 423 RVA: 0x0000268A File Offset: 0x0000088A
		// Note: this type is marked as 'beforefieldinit'.
		static AssetReferenceTexture3D()
		{
			Il2CppClassPointerStore<AssetReferenceTexture3D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Addressables.dll", "UnityEngine.AddressableAssets", "AssetReferenceTexture3D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetReferenceTexture3D>.NativeClassPtr);
			AssetReferenceTexture3D.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetReferenceTexture3D>.NativeClassPtr, 100663682);
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x0000CCF8 File Offset: 0x0000AEF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161955, XrefRangeEnd = 1161958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssetReferenceTexture3D(string guid)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetReferenceTexture3D>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetReferenceTexture3D.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x000026C3 File Offset: 0x000008C3
		public AssetReferenceTexture3D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400015C RID: 348
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
