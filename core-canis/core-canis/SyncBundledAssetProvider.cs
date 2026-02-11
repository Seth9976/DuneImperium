using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.ResourceManagement.ResourceProviders;

// Token: 0x02000035 RID: 53
public class SyncBundledAssetProvider : BundledAssetProvider
{
	// Token: 0x0600048C RID: 1164 RVA: 0x000255AC File Offset: 0x000237AC
	// Note: this type is marked as 'beforefieldinit'.
	static SyncBundledAssetProvider()
	{
		Il2CppClassPointerStore<SyncBundledAssetProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "", "SyncBundledAssetProvider");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SyncBundledAssetProvider>.NativeClassPtr);
		SyncBundledAssetProvider.NativeMethodInfoPtr_Provide_Public_Virtual_Void_ProvideHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncBundledAssetProvider>.NativeClassPtr, 100663953);
		SyncBundledAssetProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncBundledAssetProvider>.NativeClassPtr, 100663954);
	}

	// Token: 0x0600048D RID: 1165 RVA: 0x00025604 File Offset: 0x00023804
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 856832, XrefRangeEnd = 856837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Provide(ProvideHandle provideHandle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(provideHandle));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SyncBundledAssetProvider.NativeMethodInfoPtr_Provide_Public_Virtual_Void_ProvideHandle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600048E RID: 1166 RVA: 0x00025658 File Offset: 0x00023858
	[CallerCount(220)]
	[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SyncBundledAssetProvider()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SyncBundledAssetProvider>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SyncBundledAssetProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600048F RID: 1167 RVA: 0x00003B3E File Offset: 0x00001D3E
	public SyncBundledAssetProvider(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000355 RID: 853
	private static readonly IntPtr NativeMethodInfoPtr_Provide_Public_Virtual_Void_ProvideHandle_0;

	// Token: 0x04000356 RID: 854
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x0200023F RID: 575
	public new class InternalOp : global::Il2CppSystem.Object
	{
		// Token: 0x06001E96 RID: 7830 RVA: 0x0008BB8C File Offset: 0x00089D8C
		// Note: this type is marked as 'beforefieldinit'.
		static InternalOp()
		{
			Il2CppClassPointerStore<SyncBundledAssetProvider.InternalOp>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SyncBundledAssetProvider>.NativeClassPtr, "InternalOp");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SyncBundledAssetProvider.InternalOp>.NativeClassPtr);
			SyncBundledAssetProvider.InternalOp.NativeMethodInfoPtr_LoadBundleFromDependecies_Internal_Static_AssetBundle_IList_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncBundledAssetProvider.InternalOp>.NativeClassPtr, 100663955);
			SyncBundledAssetProvider.InternalOp.NativeMethodInfoPtr_Start_Public_Void_ProvideHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncBundledAssetProvider.InternalOp>.NativeClassPtr, 100663956);
			SyncBundledAssetProvider.InternalOp.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncBundledAssetProvider.InternalOp>.NativeClassPtr, 100663957);
		}

		// Token: 0x06001E97 RID: 7831 RVA: 0x0008BBF4 File Offset: 0x00089DF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 856778, RefRangeEnd = 856779, XrefRangeStart = 856762, XrefRangeEnd = 856778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AssetBundle LoadBundleFromDependecies(IList<global::Il2CppSystem.Object> results)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(results);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SyncBundledAssetProvider.InternalOp.NativeMethodInfoPtr_LoadBundleFromDependecies_Internal_Static_AssetBundle_IList_1_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssetBundle>(intPtr3) : null;
			}
		}

		// Token: 0x06001E98 RID: 7832 RVA: 0x0008BC38 File Offset: 0x00089E38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 856831, RefRangeEnd = 856832, XrefRangeStart = 856779, XrefRangeEnd = 856831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start(ProvideHandle provideHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(provideHandle));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SyncBundledAssetProvider.InternalOp.NativeMethodInfoPtr_Start_Public_Void_ProvideHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E99 RID: 7833 RVA: 0x0008BC80 File Offset: 0x00089E80
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InternalOp()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SyncBundledAssetProvider.InternalOp>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SyncBundledAssetProvider.InternalOp.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E9A RID: 7834 RVA: 0x0000D18B File Offset: 0x0000B38B
		public InternalOp(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001552 RID: 5458
		private static readonly IntPtr NativeMethodInfoPtr_LoadBundleFromDependecies_Internal_Static_AssetBundle_IList_1_Object_0;

		// Token: 0x04001553 RID: 5459
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_ProvideHandle_0;

		// Token: 0x04001554 RID: 5460
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
