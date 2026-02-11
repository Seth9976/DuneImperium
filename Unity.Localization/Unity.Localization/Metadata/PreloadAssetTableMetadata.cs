using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Localization.Metadata
{
	// Token: 0x020000DB RID: 219
	[Serializable]
	public class PreloadAssetTableMetadata : Object
	{
		// Token: 0x06000B1B RID: 2843 RVA: 0x00033280 File Offset: 0x00031480
		// Note: this type is marked as 'beforefieldinit'.
		static PreloadAssetTableMetadata()
		{
			Il2CppClassPointerStore<PreloadAssetTableMetadata>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Metadata", "PreloadAssetTableMetadata");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreloadAssetTableMetadata>.NativeClassPtr);
			PreloadAssetTableMetadata.NativeFieldInfoPtr_m_PreloadBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreloadAssetTableMetadata>.NativeClassPtr, "m_PreloadBehaviour");
			PreloadAssetTableMetadata.NativeMethodInfoPtr_get_Behaviour_Public_get_PreloadBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreloadAssetTableMetadata>.NativeClassPtr, 100665141);
			PreloadAssetTableMetadata.NativeMethodInfoPtr_set_Behaviour_Public_set_Void_PreloadBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreloadAssetTableMetadata>.NativeClassPtr, 100665142);
			PreloadAssetTableMetadata.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreloadAssetTableMetadata>.NativeClassPtr, 100665143);
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06000B1C RID: 2844 RVA: 0x00033300 File Offset: 0x00031500
		// (set) Token: 0x06000B1D RID: 2845 RVA: 0x0003333C File Offset: 0x0003153C
		public unsafe PreloadAssetTableMetadata.PreloadBehaviour Behaviour
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreloadAssetTableMetadata.NativeMethodInfoPtr_get_Behaviour_Public_get_PreloadBehaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 307807, RefRangeEnd = 307812, XrefRangeStart = 307807, XrefRangeEnd = 307812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreloadAssetTableMetadata.NativeMethodInfoPtr_set_Behaviour_Public_set_Void_PreloadBehaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000B1E RID: 2846 RVA: 0x0003337C File Offset: 0x0003157C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PreloadAssetTableMetadata()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PreloadAssetTableMetadata>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreloadAssetTableMetadata.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B1F RID: 2847 RVA: 0x000069F2 File Offset: 0x00004BF2
		public PreloadAssetTableMetadata(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06000B20 RID: 2848 RVA: 0x000333B8 File Offset: 0x000315B8
		// (set) Token: 0x06000B21 RID: 2849 RVA: 0x000069FB File Offset: 0x00004BFB
		public unsafe PreloadAssetTableMetadata.PreloadBehaviour m_PreloadBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreloadAssetTableMetadata.NativeFieldInfoPtr_m_PreloadBehaviour);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreloadAssetTableMetadata.NativeFieldInfoPtr_m_PreloadBehaviour)) = value;
			}
		}

		// Token: 0x040007D3 RID: 2003
		private static readonly IntPtr NativeFieldInfoPtr_m_PreloadBehaviour;

		// Token: 0x040007D4 RID: 2004
		private static readonly IntPtr NativeMethodInfoPtr_get_Behaviour_Public_get_PreloadBehaviour_0;

		// Token: 0x040007D5 RID: 2005
		private static readonly IntPtr NativeMethodInfoPtr_set_Behaviour_Public_set_Void_PreloadBehaviour_0;

		// Token: 0x040007D6 RID: 2006
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200017C RID: 380
		public enum PreloadBehaviour
		{
			// Token: 0x04000AC9 RID: 2761
			NoPreload,
			// Token: 0x04000ACA RID: 2762
			PreloadAll
		}
	}
}
