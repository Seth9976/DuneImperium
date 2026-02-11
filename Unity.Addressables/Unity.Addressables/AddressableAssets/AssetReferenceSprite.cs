using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.AddressableAssets
{
	// Token: 0x02000011 RID: 17
	[Serializable]
	public class AssetReferenceSprite : AssetReferenceT<Sprite>
	{
		// Token: 0x060001AA RID: 426 RVA: 0x0000CD44 File Offset: 0x0000AF44
		// Note: this type is marked as 'beforefieldinit'.
		static AssetReferenceSprite()
		{
			Il2CppClassPointerStore<AssetReferenceSprite>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Addressables.dll", "UnityEngine.AddressableAssets", "AssetReferenceSprite");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetReferenceSprite>.NativeClassPtr);
			AssetReferenceSprite.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetReferenceSprite>.NativeClassPtr, 100663683);
			AssetReferenceSprite.NativeMethodInfoPtr_ValidateAsset_Public_Virtual_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetReferenceSprite>.NativeClassPtr, 100663684);
		}

		// Token: 0x060001AB RID: 427 RVA: 0x0000CD9C File Offset: 0x0000AF9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161958, XrefRangeEnd = 1161961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssetReferenceSprite(string guid)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetReferenceSprite>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetReferenceSprite.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001AC RID: 428 RVA: 0x0000CDE8 File Offset: 0x0000AFE8
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ValidateAsset(string path)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AssetReferenceSprite.NativeMethodInfoPtr_ValidateAsset_Public_Virtual_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001AD RID: 429 RVA: 0x000026CC File Offset: 0x000008CC
		public AssetReferenceSprite(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400015D RID: 349
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400015E RID: 350
		private static readonly IntPtr NativeMethodInfoPtr_ValidateAsset_Public_Virtual_Boolean_String_0;
	}
}
