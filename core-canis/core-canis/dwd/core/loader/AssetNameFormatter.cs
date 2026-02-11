using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace dwd.core.loader
{
	// Token: 0x0200017A RID: 378
	public class AssetNameFormatter : ScriptableObject
	{
		// Token: 0x060015A6 RID: 5542 RVA: 0x0006A9D4 File Offset: 0x00068BD4
		// Note: this type is marked as 'beforefieldinit'.
		static AssetNameFormatter()
		{
			Il2CppClassPointerStore<AssetNameFormatter>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.loader", "AssetNameFormatter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetNameFormatter>.NativeClassPtr);
			AssetNameFormatter.NativeMethodInfoPtr_Format_Public_Abstract_Virtual_New_String_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetNameFormatter>.NativeClassPtr, 100666571);
			AssetNameFormatter.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetNameFormatter>.NativeClassPtr, 100666572);
		}

		// Token: 0x060015A7 RID: 5543 RVA: 0x0006AA2C File Offset: 0x00068C2C
		[CallerCount(0)]
		public unsafe virtual string Format(string asset, Type assetType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(asset);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(assetType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AssetNameFormatter.NativeMethodInfoPtr_Format_Public_Abstract_Virtual_New_String_String_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060015A8 RID: 5544 RVA: 0x0006AA94 File Offset: 0x00068C94
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 338035, RefRangeEnd = 338045, XrefRangeStart = 338035, XrefRangeEnd = 338045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssetNameFormatter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetNameFormatter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetNameFormatter.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015A9 RID: 5545 RVA: 0x00009885 File Offset: 0x00007A85
		public AssetNameFormatter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000F61 RID: 3937
		private static readonly IntPtr NativeMethodInfoPtr_Format_Public_Abstract_Virtual_New_String_String_Type_0;

		// Token: 0x04000F62 RID: 3938
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
