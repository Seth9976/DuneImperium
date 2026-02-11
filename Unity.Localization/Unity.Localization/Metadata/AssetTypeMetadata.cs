using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Localization.Metadata
{
	// Token: 0x020000D0 RID: 208
	public class AssetTypeMetadata : SharedTableCollectionMetadata
	{
		// Token: 0x06000ACC RID: 2764 RVA: 0x00031EE0 File Offset: 0x000300E0
		// Note: this type is marked as 'beforefieldinit'.
		static AssetTypeMetadata()
		{
			Il2CppClassPointerStore<AssetTypeMetadata>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Metadata", "AssetTypeMetadata");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetTypeMetadata>.NativeClassPtr);
			AssetTypeMetadata.NativeFieldInfoPtr_m_TypeString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetTypeMetadata>.NativeClassPtr, "m_TypeString");
			AssetTypeMetadata.NativeFieldInfoPtr__Type_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetTypeMetadata>.NativeClassPtr, "<Type>k__BackingField");
			AssetTypeMetadata.NativeMethodInfoPtr_get_Type_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetTypeMetadata>.NativeClassPtr, 100665094);
			AssetTypeMetadata.NativeMethodInfoPtr_set_Type_Public_set_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetTypeMetadata>.NativeClassPtr, 100665095);
			AssetTypeMetadata.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetTypeMetadata>.NativeClassPtr, 100665096);
			AssetTypeMetadata.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetTypeMetadata>.NativeClassPtr, 100665097);
			AssetTypeMetadata.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetTypeMetadata>.NativeClassPtr, 100665098);
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06000ACD RID: 2765 RVA: 0x00031F9C File Offset: 0x0003019C
		// (set) Token: 0x06000ACE RID: 2766 RVA: 0x00031FDC File Offset: 0x000301DC
		public unsafe Type Type
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetTypeMetadata.NativeMethodInfoPtr_get_Type_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetTypeMetadata.NativeMethodInfoPtr_set_Type_Public_set_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000ACF RID: 2767 RVA: 0x00032020 File Offset: 0x00030220
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078900, XrefRangeEnd = 1078903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBeforeSerialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AssetTypeMetadata.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AD0 RID: 2768 RVA: 0x0003205C File Offset: 0x0003025C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078903, XrefRangeEnd = 1078914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnAfterDeserialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AssetTypeMetadata.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AD1 RID: 2769 RVA: 0x00032098 File Offset: 0x00030298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078914, XrefRangeEnd = 1078929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssetTypeMetadata()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetTypeMetadata>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetTypeMetadata.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AD2 RID: 2770 RVA: 0x0000683C File Offset: 0x00004A3C
		public AssetTypeMetadata(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06000AD3 RID: 2771 RVA: 0x000320D4 File Offset: 0x000302D4
		// (set) Token: 0x06000AD4 RID: 2772 RVA: 0x00006845 File Offset: 0x00004A45
		public unsafe string m_TypeString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetTypeMetadata.NativeFieldInfoPtr_m_TypeString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetTypeMetadata.NativeFieldInfoPtr_m_TypeString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06000AD5 RID: 2773 RVA: 0x000320FC File Offset: 0x000302FC
		// (set) Token: 0x06000AD6 RID: 2774 RVA: 0x00006864 File Offset: 0x00004A64
		public unsafe Type _Type_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetTypeMetadata.NativeFieldInfoPtr__Type_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetTypeMetadata.NativeFieldInfoPtr__Type_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400079A RID: 1946
		private static readonly IntPtr NativeFieldInfoPtr_m_TypeString;

		// Token: 0x0400079B RID: 1947
		private static readonly IntPtr NativeFieldInfoPtr__Type_k__BackingField;

		// Token: 0x0400079C RID: 1948
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_get_Type_0;

		// Token: 0x0400079D RID: 1949
		private static readonly IntPtr NativeMethodInfoPtr_set_Type_Public_set_Void_Type_0;

		// Token: 0x0400079E RID: 1950
		private static readonly IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Void_0;

		// Token: 0x0400079F RID: 1951
		private static readonly IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Void_0;

		// Token: 0x040007A0 RID: 1952
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
