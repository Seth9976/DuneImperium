using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.ResourceManagement.ResourceProviders
{
	// Token: 0x02000040 RID: 64
	public class JsonAssetProvider : TextDataProvider
	{
		// Token: 0x06000339 RID: 825 RVA: 0x00011510 File Offset: 0x0000F710
		// Note: this type is marked as 'beforefieldinit'.
		static JsonAssetProvider()
		{
			Il2CppClassPointerStore<JsonAssetProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.ResourceManager.dll", "UnityEngine.ResourceManagement.ResourceProviders", "JsonAssetProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonAssetProvider>.NativeClassPtr);
			JsonAssetProvider.NativeMethodInfoPtr_Convert_Public_Virtual_Object_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonAssetProvider>.NativeClassPtr, 100663820);
			JsonAssetProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonAssetProvider>.NativeClassPtr, 100663821);
		}

		// Token: 0x0600033A RID: 826 RVA: 0x00011568 File Offset: 0x0000F768
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140701, XrefRangeEnd = 1140702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object Convert(Type type, string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonAssetProvider.NativeMethodInfoPtr_Convert_Public_Virtual_Object_Type_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600033B RID: 827 RVA: 0x000115D8 File Offset: 0x0000F7D8
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonAssetProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonAssetProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonAssetProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600033C RID: 828 RVA: 0x000034F2 File Offset: 0x000016F2
		public JsonAssetProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000233 RID: 563
		private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Object_Type_String_0;

		// Token: 0x04000234 RID: 564
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
