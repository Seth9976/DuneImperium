using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000004 RID: 4
	public class AssetReferenceUIRestriction : Attribute
	{
		// Token: 0x0600000C RID: 12 RVA: 0x00004A20 File Offset: 0x00002C20
		// Note: this type is marked as 'beforefieldinit'.
		static AssetReferenceUIRestriction()
		{
			Il2CppClassPointerStore<AssetReferenceUIRestriction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Addressables.dll", "UnityEngine", "AssetReferenceUIRestriction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetReferenceUIRestriction>.NativeClassPtr);
			AssetReferenceUIRestriction.NativeMethodInfoPtr_ValidateAsset_Public_Virtual_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetReferenceUIRestriction>.NativeClassPtr, 100663303);
			AssetReferenceUIRestriction.NativeMethodInfoPtr_ValidateAsset_Public_Virtual_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetReferenceUIRestriction>.NativeClassPtr, 100663304);
			AssetReferenceUIRestriction.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetReferenceUIRestriction>.NativeClassPtr, 100663305);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00004A8C File Offset: 0x00002C8C
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ValidateAsset(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AssetReferenceUIRestriction.NativeMethodInfoPtr_ValidateAsset_Public_Virtual_New_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00004AE4 File Offset: 0x00002CE4
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ValidateAsset(string path)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AssetReferenceUIRestriction.NativeMethodInfoPtr_ValidateAsset_Public_Virtual_New_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00004B3C File Offset: 0x00002D3C
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssetReferenceUIRestriction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetReferenceUIRestriction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetReferenceUIRestriction.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002081 File Offset: 0x00000281
		public AssetReferenceUIRestriction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeMethodInfoPtr_ValidateAsset_Public_Virtual_New_Boolean_Object_0;

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeMethodInfoPtr_ValidateAsset_Public_Virtual_New_Boolean_String_0;

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
