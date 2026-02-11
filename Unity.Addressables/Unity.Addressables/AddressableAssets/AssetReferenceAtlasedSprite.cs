using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.AddressableAssets
{
	// Token: 0x02000012 RID: 18
	[Serializable]
	public class AssetReferenceAtlasedSprite : AssetReferenceT<Sprite>
	{
		// Token: 0x060001AE RID: 430 RVA: 0x0000CE40 File Offset: 0x0000B040
		// Note: this type is marked as 'beforefieldinit'.
		static AssetReferenceAtlasedSprite()
		{
			Il2CppClassPointerStore<AssetReferenceAtlasedSprite>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Addressables.dll", "UnityEngine.AddressableAssets", "AssetReferenceAtlasedSprite");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetReferenceAtlasedSprite>.NativeClassPtr);
			AssetReferenceAtlasedSprite.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetReferenceAtlasedSprite>.NativeClassPtr, 100663685);
			AssetReferenceAtlasedSprite.NativeMethodInfoPtr_ValidateAsset_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetReferenceAtlasedSprite>.NativeClassPtr, 100663686);
			AssetReferenceAtlasedSprite.NativeMethodInfoPtr_ValidateAsset_Public_Virtual_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetReferenceAtlasedSprite>.NativeClassPtr, 100663687);
		}

		// Token: 0x060001AF RID: 431 RVA: 0x0000CEAC File Offset: 0x0000B0AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161961, XrefRangeEnd = 1161964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssetReferenceAtlasedSprite(string guid)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetReferenceAtlasedSprite>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetReferenceAtlasedSprite.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x0000CEF8 File Offset: 0x0000B0F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161964, XrefRangeEnd = 1161965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ValidateAsset(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AssetReferenceAtlasedSprite.NativeMethodInfoPtr_ValidateAsset_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x0000CF50 File Offset: 0x0000B150
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AssetReferenceAtlasedSprite.NativeMethodInfoPtr_ValidateAsset_Public_Virtual_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x000026D5 File Offset: 0x000008D5
		public AssetReferenceAtlasedSprite(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400015F RID: 351
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000160 RID: 352
		private static readonly IntPtr NativeMethodInfoPtr_ValidateAsset_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000161 RID: 353
		private static readonly IntPtr NativeMethodInfoPtr_ValidateAsset_Public_Virtual_Boolean_String_0;
	}
}
