using System;
using dwd.core.loader.caching;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace dwd.core.loader.loaders
{
	// Token: 0x0200019C RID: 412
	public class SpriteAtlasLoader : global::Il2CppSystem.Object
	{
		// Token: 0x06001750 RID: 5968 RVA: 0x000714F4 File Offset: 0x0006F6F4
		// Note: this type is marked as 'beforefieldinit'.
		static SpriteAtlasLoader()
		{
			Il2CppClassPointerStore<SpriteAtlasLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.loader.loaders", "SpriteAtlasLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteAtlasLoader>.NativeClassPtr);
			SpriteAtlasLoader.NativeFieldInfoPtr_SPRITENAMEFORMAT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAtlasLoader>.NativeClassPtr, "SPRITENAMEFORMAT");
			SpriteAtlasLoader.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAtlasLoader>.NativeClassPtr, "source");
			SpriteAtlasLoader.NativeFieldInfoPtr_assetReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAtlasLoader>.NativeClassPtr, "assetReference");
			SpriteAtlasLoader.NativeFieldInfoPtr__Asset_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAtlasLoader>.NativeClassPtr, "<Asset>k__BackingField");
			SpriteAtlasLoader.NativeFieldInfoPtr__State_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAtlasLoader>.NativeClassPtr, "<State>k__BackingField");
			SpriteAtlasLoader.NativeMethodInfoPtr_get_Asset_Public_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasLoader>.NativeClassPtr, 100666912);
			SpriteAtlasLoader.NativeMethodInfoPtr_set_Asset_Private_set_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasLoader>.NativeClassPtr, 100666913);
			SpriteAtlasLoader.NativeMethodInfoPtr_get_State_Public_get_States_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasLoader>.NativeClassPtr, 100666914);
			SpriteAtlasLoader.NativeMethodInfoPtr_set_State_Private_set_Void_States_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasLoader>.NativeClassPtr, 100666915);
			SpriteAtlasLoader.NativeMethodInfoPtr__ctor_Public_Void_IReferenceTracker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasLoader>.NativeClassPtr, 100666916);
			SpriteAtlasLoader.NativeMethodInfoPtr_LoadAndWait_Public_IEnumerator_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasLoader>.NativeClassPtr, 100666917);
			SpriteAtlasLoader.NativeMethodInfoPtr_LoadAndWait_Public_IEnumerator_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasLoader>.NativeClassPtr, 100666918);
			SpriteAtlasLoader.NativeMethodInfoPtr_LoadAndWait_Public_IEnumerator_AssetName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasLoader>.NativeClassPtr, 100666919);
			SpriteAtlasLoader.NativeMethodInfoPtr_Load_Public_Void_AssetName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasLoader>.NativeClassPtr, 100666920);
			SpriteAtlasLoader.NativeMethodInfoPtr_InternalLoadAndWait_Private_IEnumerator_AssetName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasLoader>.NativeClassPtr, 100666921);
			SpriteAtlasLoader.NativeMethodInfoPtr_LoadAsset_Public_Void_AssetName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasLoader>.NativeClassPtr, 100666922);
			SpriteAtlasLoader.NativeMethodInfoPtr_LoadAsset_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasLoader>.NativeClassPtr, 100666923);
			SpriteAtlasLoader.NativeMethodInfoPtr_LoadAsset_Public_Void_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasLoader>.NativeClassPtr, 100666924);
			SpriteAtlasLoader.NativeMethodInfoPtr_InternalLoadAsset_Private_IEnumerator_AssetName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasLoader>.NativeClassPtr, 100666925);
			SpriteAtlasLoader.NativeMethodInfoPtr_createAssetName_Private_Static_AssetName_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasLoader>.NativeClassPtr, 100666926);
		}

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x06001751 RID: 5969 RVA: 0x000716B4 File Offset: 0x0006F8B4
		// (set) Token: 0x06001752 RID: 5970 RVA: 0x000716F4 File Offset: 0x0006F8F4
		public unsafe Sprite Asset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasLoader.NativeMethodInfoPtr_get_Asset_Public_get_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasLoader.NativeMethodInfoPtr_set_Asset_Private_set_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x06001753 RID: 5971 RVA: 0x00071738 File Offset: 0x0006F938
		// (set) Token: 0x06001754 RID: 5972 RVA: 0x00071774 File Offset: 0x0006F974
		public unsafe SpriteAtlasLoader.States State
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasLoader.NativeMethodInfoPtr_get_State_Public_get_States_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasLoader.NativeMethodInfoPtr_set_State_Private_set_Void_States_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001755 RID: 5973 RVA: 0x000717B4 File Offset: 0x0006F9B4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 879025, RefRangeEnd = 879031, XrefRangeStart = 879025, XrefRangeEnd = 879031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpriteAtlasLoader(IReferenceTracker source)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpriteAtlasLoader>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasLoader.NativeMethodInfoPtr__ctor_Public_Void_IReferenceTracker_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001756 RID: 5974 RVA: 0x00071800 File Offset: 0x0006FA00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 879201, XrefRangeEnd = 879207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator LoadAndWait(string assetName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assetName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasLoader.NativeMethodInfoPtr_LoadAndWait_Public_IEnumerator_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06001757 RID: 5975 RVA: 0x00071850 File Offset: 0x0006FA50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 879214, RefRangeEnd = 879215, XrefRangeStart = 879207, XrefRangeEnd = 879214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator LoadAndWait(string cropName, string baseAssetName, bool useSpriteNameFormating)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(cropName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(baseAssetName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useSpriteNameFormating;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasLoader.NativeMethodInfoPtr_LoadAndWait_Public_IEnumerator_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001758 RID: 5976 RVA: 0x000718C0 File Offset: 0x0006FAC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 879215, XrefRangeEnd = 879221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator LoadAndWait(AssetName assetName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(assetName));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasLoader.NativeMethodInfoPtr_LoadAndWait_Public_IEnumerator_AssetName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06001759 RID: 5977 RVA: 0x00071918 File Offset: 0x0006FB18
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 879235, RefRangeEnd = 879238, XrefRangeStart = 879221, XrefRangeEnd = 879235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load(AssetName assetName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(assetName));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasLoader.NativeMethodInfoPtr_Load_Public_Void_AssetName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600175A RID: 5978 RVA: 0x00071960 File Offset: 0x0006FB60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 879238, XrefRangeEnd = 879244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator InternalLoadAndWait(AssetName assetName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(assetName));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasLoader.NativeMethodInfoPtr_InternalLoadAndWait_Private_IEnumerator_AssetName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x0600175B RID: 5979 RVA: 0x000719B8 File Offset: 0x0006FBB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 879244, XrefRangeEnd = 879245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadAsset(AssetName assetName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(assetName));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasLoader.NativeMethodInfoPtr_LoadAsset_Public_Void_AssetName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600175C RID: 5980 RVA: 0x00071A00 File Offset: 0x0006FC00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 879245, XrefRangeEnd = 879248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadAsset(string assetName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assetName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasLoader.NativeMethodInfoPtr_LoadAsset_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600175D RID: 5981 RVA: 0x00071A44 File Offset: 0x0006FC44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 879255, RefRangeEnd = 879256, XrefRangeStart = 879248, XrefRangeEnd = 879255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadAsset(string cropName, string baseAssetName, bool useSpriteNameFormating)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(cropName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(baseAssetName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useSpriteNameFormating;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasLoader.NativeMethodInfoPtr_LoadAsset_Public_Void_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600175E RID: 5982 RVA: 0x00071AA8 File Offset: 0x0006FCA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 879256, XrefRangeEnd = 879262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator InternalLoadAsset(AssetName assetName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(assetName));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasLoader.NativeMethodInfoPtr_InternalLoadAsset_Private_IEnumerator_AssetName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x0600175F RID: 5983 RVA: 0x00071B00 File Offset: 0x0006FD00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 879262, XrefRangeEnd = 879268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AssetName createAssetName(string cropName, string baseName, bool useSpriteNameFormating = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(cropName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(baseName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useSpriteNameFormating;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasLoader.NativeMethodInfoPtr_createAssetName_Private_Static_AssetName_String_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AssetName(intPtr);
		}

		// Token: 0x06001760 RID: 5984 RVA: 0x0000A32B File Offset: 0x0000852B
		public SpriteAtlasLoader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x06001761 RID: 5985 RVA: 0x00071B5C File Offset: 0x0006FD5C
		// (set) Token: 0x06001762 RID: 5986 RVA: 0x0000A334 File Offset: 0x00008534
		public unsafe static string SPRITENAMEFORMAT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SpriteAtlasLoader.NativeFieldInfoPtr_SPRITENAMEFORMAT, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SpriteAtlasLoader.NativeFieldInfoPtr_SPRITENAMEFORMAT, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x06001763 RID: 5987 RVA: 0x00071B7C File Offset: 0x0006FD7C
		// (set) Token: 0x06001764 RID: 5988 RVA: 0x0000A346 File Offset: 0x00008546
		public unsafe IReferenceTracker source
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasLoader.NativeFieldInfoPtr_source);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReferenceTracker>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasLoader.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x06001765 RID: 5989 RVA: 0x00071BAC File Offset: 0x0006FDAC
		// (set) Token: 0x06001766 RID: 5990 RVA: 0x0000A365 File Offset: 0x00008565
		public unsafe ISpriteReference assetReference
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasLoader.NativeFieldInfoPtr_assetReference);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISpriteReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasLoader.NativeFieldInfoPtr_assetReference), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x06001767 RID: 5991 RVA: 0x00071BDC File Offset: 0x0006FDDC
		// (set) Token: 0x06001768 RID: 5992 RVA: 0x0000A384 File Offset: 0x00008584
		public unsafe Sprite _Asset_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasLoader.NativeFieldInfoPtr__Asset_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasLoader.NativeFieldInfoPtr__Asset_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x06001769 RID: 5993 RVA: 0x00071C0C File Offset: 0x0006FE0C
		// (set) Token: 0x0600176A RID: 5994 RVA: 0x0000A3A3 File Offset: 0x000085A3
		public unsafe SpriteAtlasLoader.States _State_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasLoader.NativeFieldInfoPtr__State_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasLoader.NativeFieldInfoPtr__State_k__BackingField)) = value;
			}
		}

		// Token: 0x0400107B RID: 4219
		private static readonly IntPtr NativeFieldInfoPtr_SPRITENAMEFORMAT;

		// Token: 0x0400107C RID: 4220
		private static readonly IntPtr NativeFieldInfoPtr_source;

		// Token: 0x0400107D RID: 4221
		private static readonly IntPtr NativeFieldInfoPtr_assetReference;

		// Token: 0x0400107E RID: 4222
		private static readonly IntPtr NativeFieldInfoPtr__Asset_k__BackingField;

		// Token: 0x0400107F RID: 4223
		private static readonly IntPtr NativeFieldInfoPtr__State_k__BackingField;

		// Token: 0x04001080 RID: 4224
		private static readonly IntPtr NativeMethodInfoPtr_get_Asset_Public_get_Sprite_0;

		// Token: 0x04001081 RID: 4225
		private static readonly IntPtr NativeMethodInfoPtr_set_Asset_Private_set_Void_Sprite_0;

		// Token: 0x04001082 RID: 4226
		private static readonly IntPtr NativeMethodInfoPtr_get_State_Public_get_States_0;

		// Token: 0x04001083 RID: 4227
		private static readonly IntPtr NativeMethodInfoPtr_set_State_Private_set_Void_States_0;

		// Token: 0x04001084 RID: 4228
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IReferenceTracker_0;

		// Token: 0x04001085 RID: 4229
		private static readonly IntPtr NativeMethodInfoPtr_LoadAndWait_Public_IEnumerator_String_0;

		// Token: 0x04001086 RID: 4230
		private static readonly IntPtr NativeMethodInfoPtr_LoadAndWait_Public_IEnumerator_String_String_Boolean_0;

		// Token: 0x04001087 RID: 4231
		private static readonly IntPtr NativeMethodInfoPtr_LoadAndWait_Public_IEnumerator_AssetName_0;

		// Token: 0x04001088 RID: 4232
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_AssetName_0;

		// Token: 0x04001089 RID: 4233
		private static readonly IntPtr NativeMethodInfoPtr_InternalLoadAndWait_Private_IEnumerator_AssetName_0;

		// Token: 0x0400108A RID: 4234
		private static readonly IntPtr NativeMethodInfoPtr_LoadAsset_Public_Void_AssetName_0;

		// Token: 0x0400108B RID: 4235
		private static readonly IntPtr NativeMethodInfoPtr_LoadAsset_Public_Void_String_0;

		// Token: 0x0400108C RID: 4236
		private static readonly IntPtr NativeMethodInfoPtr_LoadAsset_Public_Void_String_String_Boolean_0;

		// Token: 0x0400108D RID: 4237
		private static readonly IntPtr NativeMethodInfoPtr_InternalLoadAsset_Private_IEnumerator_AssetName_0;

		// Token: 0x0400108E RID: 4238
		private static readonly IntPtr NativeMethodInfoPtr_createAssetName_Private_Static_AssetName_String_String_Boolean_0;

		// Token: 0x02000338 RID: 824
		public enum States
		{
			// Token: 0x040019A4 RID: 6564
			UNINITIALIZED,
			// Token: 0x040019A5 RID: 6565
			Loading,
			// Token: 0x040019A6 RID: 6566
			Loaded,
			// Token: 0x040019A7 RID: 6567
			Error
		}

		// Token: 0x02000339 RID: 825
		[ObfuscatedName("dwd.core.loader.loaders.SpriteAtlasLoader+<InternalLoadAndWait>d__17")]
		public sealed class _InternalLoadAndWait_d__17 : global::Il2CppSystem.Object
		{
			// Token: 0x060025AA RID: 9642 RVA: 0x000A1BB8 File Offset: 0x0009FDB8
			// Note: this type is marked as 'beforefieldinit'.
			static _InternalLoadAndWait_d__17()
			{
				Il2CppClassPointerStore<SpriteAtlasLoader._InternalLoadAndWait_d__17>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpriteAtlasLoader>.NativeClassPtr, "<InternalLoadAndWait>d__17");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteAtlasLoader._InternalLoadAndWait_d__17>.NativeClassPtr);
				SpriteAtlasLoader._InternalLoadAndWait_d__17.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAtlasLoader._InternalLoadAndWait_d__17>.NativeClassPtr, "<>1__state");
				SpriteAtlasLoader._InternalLoadAndWait_d__17.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAtlasLoader._InternalLoadAndWait_d__17>.NativeClassPtr, "<>2__current");
				SpriteAtlasLoader._InternalLoadAndWait_d__17.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAtlasLoader._InternalLoadAndWait_d__17>.NativeClassPtr, "<>4__this");
				SpriteAtlasLoader._InternalLoadAndWait_d__17.NativeFieldInfoPtr_assetName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAtlasLoader._InternalLoadAndWait_d__17>.NativeClassPtr, "assetName");
				SpriteAtlasLoader._InternalLoadAndWait_d__17.NativeFieldInfoPtr__load_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAtlasLoader._InternalLoadAndWait_d__17>.NativeClassPtr, "<load>5__2");
				SpriteAtlasLoader._InternalLoadAndWait_d__17.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasLoader._InternalLoadAndWait_d__17>.NativeClassPtr, 100666927);
				SpriteAtlasLoader._InternalLoadAndWait_d__17.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasLoader._InternalLoadAndWait_d__17>.NativeClassPtr, 100666928);
				SpriteAtlasLoader._InternalLoadAndWait_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasLoader._InternalLoadAndWait_d__17>.NativeClassPtr, 100666929);
				SpriteAtlasLoader._InternalLoadAndWait_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasLoader._InternalLoadAndWait_d__17>.NativeClassPtr, 100666930);
				SpriteAtlasLoader._InternalLoadAndWait_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasLoader._InternalLoadAndWait_d__17>.NativeClassPtr, 100666931);
				SpriteAtlasLoader._InternalLoadAndWait_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasLoader._InternalLoadAndWait_d__17>.NativeClassPtr, 100666932);
			}

			// Token: 0x060025AB RID: 9643 RVA: 0x000A1CC0 File Offset: 0x0009FEC0
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _InternalLoadAndWait_d__17(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpriteAtlasLoader._InternalLoadAndWait_d__17>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasLoader._InternalLoadAndWait_d__17.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060025AC RID: 9644 RVA: 0x000A1D08 File Offset: 0x0009FF08
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasLoader._InternalLoadAndWait_d__17.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060025AD RID: 9645 RVA: 0x000A1D3C File Offset: 0x0009FF3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 879091, XrefRangeEnd = 879111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasLoader._InternalLoadAndWait_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000A91 RID: 2705
			// (get) Token: 0x060025AE RID: 9646 RVA: 0x000A1D78 File Offset: 0x0009FF78
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasLoader._InternalLoadAndWait_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060025AF RID: 9647 RVA: 0x000A1DB8 File Offset: 0x0009FFB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 879111, XrefRangeEnd = 879116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasLoader._InternalLoadAndWait_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000A92 RID: 2706
			// (get) Token: 0x060025B0 RID: 9648 RVA: 0x000A1DEC File Offset: 0x0009FFEC
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasLoader._InternalLoadAndWait_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060025B1 RID: 9649 RVA: 0x0001106C File Offset: 0x0000F26C
			public _InternalLoadAndWait_d__17(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A8C RID: 2700
			// (get) Token: 0x060025B2 RID: 9650 RVA: 0x000A1E2C File Offset: 0x000A002C
			// (set) Token: 0x060025B3 RID: 9651 RVA: 0x00011075 File Offset: 0x0000F275
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasLoader._InternalLoadAndWait_d__17.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasLoader._InternalLoadAndWait_d__17.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000A8D RID: 2701
			// (get) Token: 0x060025B4 RID: 9652 RVA: 0x000A1E54 File Offset: 0x000A0054
			// (set) Token: 0x060025B5 RID: 9653 RVA: 0x00011090 File Offset: 0x0000F290
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasLoader._InternalLoadAndWait_d__17.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasLoader._InternalLoadAndWait_d__17.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A8E RID: 2702
			// (get) Token: 0x060025B6 RID: 9654 RVA: 0x000A1E84 File Offset: 0x000A0084
			// (set) Token: 0x060025B7 RID: 9655 RVA: 0x000110AF File Offset: 0x0000F2AF
			public unsafe SpriteAtlasLoader __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasLoader._InternalLoadAndWait_d__17.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteAtlasLoader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasLoader._InternalLoadAndWait_d__17.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A8F RID: 2703
			// (get) Token: 0x060025B8 RID: 9656 RVA: 0x000A1EB4 File Offset: 0x000A00B4
			// (set) Token: 0x060025B9 RID: 9657 RVA: 0x000110CE File Offset: 0x0000F2CE
			public AssetName assetName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasLoader._InternalLoadAndWait_d__17.NativeFieldInfoPtr_assetName);
					return new AssetName(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AssetName>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasLoader._InternalLoadAndWait_d__17.NativeFieldInfoPtr_assetName), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AssetName>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000A90 RID: 2704
			// (get) Token: 0x060025BA RID: 9658 RVA: 0x000A1EE4 File Offset: 0x000A00E4
			// (set) Token: 0x060025BB RID: 9659 RVA: 0x000110FC File Offset: 0x0000F2FC
			public unsafe IEnumerator _load_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasLoader._InternalLoadAndWait_d__17.NativeFieldInfoPtr__load_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasLoader._InternalLoadAndWait_d__17.NativeFieldInfoPtr__load_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040019A8 RID: 6568
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040019A9 RID: 6569
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040019AA RID: 6570
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040019AB RID: 6571
			private static readonly IntPtr NativeFieldInfoPtr_assetName;

			// Token: 0x040019AC RID: 6572
			private static readonly IntPtr NativeFieldInfoPtr__load_5__2;

			// Token: 0x040019AD RID: 6573
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040019AE RID: 6574
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040019AF RID: 6575
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040019B0 RID: 6576
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040019B1 RID: 6577
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040019B2 RID: 6578
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200033A RID: 826
		[ObfuscatedName("dwd.core.loader.loaders.SpriteAtlasLoader+<InternalLoadAsset>d__21")]
		public sealed class _InternalLoadAsset_d__21 : global::Il2CppSystem.Object
		{
			// Token: 0x060025BC RID: 9660 RVA: 0x000A1F14 File Offset: 0x000A0114
			// Note: this type is marked as 'beforefieldinit'.
			static _InternalLoadAsset_d__21()
			{
				Il2CppClassPointerStore<SpriteAtlasLoader._InternalLoadAsset_d__21>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpriteAtlasLoader>.NativeClassPtr, "<InternalLoadAsset>d__21");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteAtlasLoader._InternalLoadAsset_d__21>.NativeClassPtr);
				SpriteAtlasLoader._InternalLoadAsset_d__21.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAtlasLoader._InternalLoadAsset_d__21>.NativeClassPtr, "<>1__state");
				SpriteAtlasLoader._InternalLoadAsset_d__21.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAtlasLoader._InternalLoadAsset_d__21>.NativeClassPtr, "<>2__current");
				SpriteAtlasLoader._InternalLoadAsset_d__21.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAtlasLoader._InternalLoadAsset_d__21>.NativeClassPtr, "<>4__this");
				SpriteAtlasLoader._InternalLoadAsset_d__21.NativeFieldInfoPtr_assetName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAtlasLoader._InternalLoadAsset_d__21>.NativeClassPtr, "assetName");
				SpriteAtlasLoader._InternalLoadAsset_d__21.NativeFieldInfoPtr__loadEnumerator_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAtlasLoader._InternalLoadAsset_d__21>.NativeClassPtr, "<loadEnumerator>5__2");
				SpriteAtlasLoader._InternalLoadAsset_d__21.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasLoader._InternalLoadAsset_d__21>.NativeClassPtr, 100666933);
				SpriteAtlasLoader._InternalLoadAsset_d__21.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasLoader._InternalLoadAsset_d__21>.NativeClassPtr, 100666934);
				SpriteAtlasLoader._InternalLoadAsset_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasLoader._InternalLoadAsset_d__21>.NativeClassPtr, 100666935);
				SpriteAtlasLoader._InternalLoadAsset_d__21.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasLoader._InternalLoadAsset_d__21>.NativeClassPtr, 100666936);
				SpriteAtlasLoader._InternalLoadAsset_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasLoader._InternalLoadAsset_d__21>.NativeClassPtr, 100666937);
				SpriteAtlasLoader._InternalLoadAsset_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasLoader._InternalLoadAsset_d__21>.NativeClassPtr, 100666938);
			}

			// Token: 0x060025BD RID: 9661 RVA: 0x000A201C File Offset: 0x000A021C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _InternalLoadAsset_d__21(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpriteAtlasLoader._InternalLoadAsset_d__21>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasLoader._InternalLoadAsset_d__21.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060025BE RID: 9662 RVA: 0x000A2064 File Offset: 0x000A0264
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasLoader._InternalLoadAsset_d__21.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060025BF RID: 9663 RVA: 0x000A2098 File Offset: 0x000A0298
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 879116, XrefRangeEnd = 879130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasLoader._InternalLoadAsset_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000A98 RID: 2712
			// (get) Token: 0x060025C0 RID: 9664 RVA: 0x000A20D4 File Offset: 0x000A02D4
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasLoader._InternalLoadAsset_d__21.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060025C1 RID: 9665 RVA: 0x000A2114 File Offset: 0x000A0314
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 879130, XrefRangeEnd = 879135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasLoader._InternalLoadAsset_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000A99 RID: 2713
			// (get) Token: 0x060025C2 RID: 9666 RVA: 0x000A2148 File Offset: 0x000A0348
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasLoader._InternalLoadAsset_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060025C3 RID: 9667 RVA: 0x0001111B File Offset: 0x0000F31B
			public _InternalLoadAsset_d__21(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A93 RID: 2707
			// (get) Token: 0x060025C4 RID: 9668 RVA: 0x000A2188 File Offset: 0x000A0388
			// (set) Token: 0x060025C5 RID: 9669 RVA: 0x00011124 File Offset: 0x0000F324
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasLoader._InternalLoadAsset_d__21.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasLoader._InternalLoadAsset_d__21.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000A94 RID: 2708
			// (get) Token: 0x060025C6 RID: 9670 RVA: 0x000A21B0 File Offset: 0x000A03B0
			// (set) Token: 0x060025C7 RID: 9671 RVA: 0x0001113F File Offset: 0x0000F33F
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasLoader._InternalLoadAsset_d__21.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasLoader._InternalLoadAsset_d__21.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A95 RID: 2709
			// (get) Token: 0x060025C8 RID: 9672 RVA: 0x000A21E0 File Offset: 0x000A03E0
			// (set) Token: 0x060025C9 RID: 9673 RVA: 0x0001115E File Offset: 0x0000F35E
			public unsafe SpriteAtlasLoader __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasLoader._InternalLoadAsset_d__21.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteAtlasLoader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasLoader._InternalLoadAsset_d__21.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A96 RID: 2710
			// (get) Token: 0x060025CA RID: 9674 RVA: 0x000A2210 File Offset: 0x000A0410
			// (set) Token: 0x060025CB RID: 9675 RVA: 0x0001117D File Offset: 0x0000F37D
			public AssetName assetName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasLoader._InternalLoadAsset_d__21.NativeFieldInfoPtr_assetName);
					return new AssetName(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AssetName>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasLoader._InternalLoadAsset_d__21.NativeFieldInfoPtr_assetName), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AssetName>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000A97 RID: 2711
			// (get) Token: 0x060025CC RID: 9676 RVA: 0x000A2240 File Offset: 0x000A0440
			// (set) Token: 0x060025CD RID: 9677 RVA: 0x000111AB File Offset: 0x0000F3AB
			public unsafe IEnumerator _loadEnumerator_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasLoader._InternalLoadAsset_d__21.NativeFieldInfoPtr__loadEnumerator_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasLoader._InternalLoadAsset_d__21.NativeFieldInfoPtr__loadEnumerator_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040019B3 RID: 6579
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040019B4 RID: 6580
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040019B5 RID: 6581
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040019B6 RID: 6582
			private static readonly IntPtr NativeFieldInfoPtr_assetName;

			// Token: 0x040019B7 RID: 6583
			private static readonly IntPtr NativeFieldInfoPtr__loadEnumerator_5__2;

			// Token: 0x040019B8 RID: 6584
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040019B9 RID: 6585
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040019BA RID: 6586
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040019BB RID: 6587
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040019BC RID: 6588
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040019BD RID: 6589
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200033B RID: 827
		[ObfuscatedName("dwd.core.loader.loaders.SpriteAtlasLoader+<LoadAndWait>d__13")]
		public sealed class _LoadAndWait_d__13 : global::Il2CppSystem.Object
		{
			// Token: 0x060025CE RID: 9678 RVA: 0x000A2270 File Offset: 0x000A0470
			// Note: this type is marked as 'beforefieldinit'.
			static _LoadAndWait_d__13()
			{
				Il2CppClassPointerStore<SpriteAtlasLoader._LoadAndWait_d__13>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpriteAtlasLoader>.NativeClassPtr, "<LoadAndWait>d__13");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteAtlasLoader._LoadAndWait_d__13>.NativeClassPtr);
				SpriteAtlasLoader._LoadAndWait_d__13.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAtlasLoader._LoadAndWait_d__13>.NativeClassPtr, "<>1__state");
				SpriteAtlasLoader._LoadAndWait_d__13.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAtlasLoader._LoadAndWait_d__13>.NativeClassPtr, "<>2__current");
				SpriteAtlasLoader._LoadAndWait_d__13.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAtlasLoader._LoadAndWait_d__13>.NativeClassPtr, "<>4__this");
				SpriteAtlasLoader._LoadAndWait_d__13.NativeFieldInfoPtr_assetName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAtlasLoader._LoadAndWait_d__13>.NativeClassPtr, "assetName");
				SpriteAtlasLoader._LoadAndWait_d__13.NativeFieldInfoPtr__l_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAtlasLoader._LoadAndWait_d__13>.NativeClassPtr, "<l>5__2");
				SpriteAtlasLoader._LoadAndWait_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasLoader._LoadAndWait_d__13>.NativeClassPtr, 100666939);
				SpriteAtlasLoader._LoadAndWait_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasLoader._LoadAndWait_d__13>.NativeClassPtr, 100666940);
				SpriteAtlasLoader._LoadAndWait_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasLoader._LoadAndWait_d__13>.NativeClassPtr, 100666941);
				SpriteAtlasLoader._LoadAndWait_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasLoader._LoadAndWait_d__13>.NativeClassPtr, 100666942);
				SpriteAtlasLoader._LoadAndWait_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasLoader._LoadAndWait_d__13>.NativeClassPtr, 100666943);
				SpriteAtlasLoader._LoadAndWait_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasLoader._LoadAndWait_d__13>.NativeClassPtr, 100666944);
			}

			// Token: 0x060025CF RID: 9679 RVA: 0x000A2378 File Offset: 0x000A0578
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _LoadAndWait_d__13(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpriteAtlasLoader._LoadAndWait_d__13>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasLoader._LoadAndWait_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060025D0 RID: 9680 RVA: 0x000A23C0 File Offset: 0x000A05C0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasLoader._LoadAndWait_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060025D1 RID: 9681 RVA: 0x000A23F4 File Offset: 0x000A05F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 879135, XrefRangeEnd = 879151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasLoader._LoadAndWait_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000A9F RID: 2719
			// (get) Token: 0x060025D2 RID: 9682 RVA: 0x000A2430 File Offset: 0x000A0630
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasLoader._LoadAndWait_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060025D3 RID: 9683 RVA: 0x000A2470 File Offset: 0x000A0670
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 879151, XrefRangeEnd = 879156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasLoader._LoadAndWait_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000AA0 RID: 2720
			// (get) Token: 0x060025D4 RID: 9684 RVA: 0x000A24A4 File Offset: 0x000A06A4
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasLoader._LoadAndWait_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060025D5 RID: 9685 RVA: 0x000111CA File Offset: 0x0000F3CA
			public _LoadAndWait_d__13(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A9A RID: 2714
			// (get) Token: 0x060025D6 RID: 9686 RVA: 0x000A24E4 File Offset: 0x000A06E4
			// (set) Token: 0x060025D7 RID: 9687 RVA: 0x000111D3 File Offset: 0x0000F3D3
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasLoader._LoadAndWait_d__13.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasLoader._LoadAndWait_d__13.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000A9B RID: 2715
			// (get) Token: 0x060025D8 RID: 9688 RVA: 0x000A250C File Offset: 0x000A070C
			// (set) Token: 0x060025D9 RID: 9689 RVA: 0x000111EE File Offset: 0x0000F3EE
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasLoader._LoadAndWait_d__13.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasLoader._LoadAndWait_d__13.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A9C RID: 2716
			// (get) Token: 0x060025DA RID: 9690 RVA: 0x000A253C File Offset: 0x000A073C
			// (set) Token: 0x060025DB RID: 9691 RVA: 0x0001120D File Offset: 0x0000F40D
			public unsafe SpriteAtlasLoader __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasLoader._LoadAndWait_d__13.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteAtlasLoader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasLoader._LoadAndWait_d__13.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A9D RID: 2717
			// (get) Token: 0x060025DC RID: 9692 RVA: 0x000A256C File Offset: 0x000A076C
			// (set) Token: 0x060025DD RID: 9693 RVA: 0x0001122C File Offset: 0x0000F42C
			public unsafe string assetName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasLoader._LoadAndWait_d__13.NativeFieldInfoPtr_assetName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasLoader._LoadAndWait_d__13.NativeFieldInfoPtr_assetName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000A9E RID: 2718
			// (get) Token: 0x060025DE RID: 9694 RVA: 0x000A2594 File Offset: 0x000A0794
			// (set) Token: 0x060025DF RID: 9695 RVA: 0x0001124B File Offset: 0x0000F44B
			public unsafe IEnumerator _l_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasLoader._LoadAndWait_d__13.NativeFieldInfoPtr__l_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasLoader._LoadAndWait_d__13.NativeFieldInfoPtr__l_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040019BE RID: 6590
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040019BF RID: 6591
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040019C0 RID: 6592
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040019C1 RID: 6593
			private static readonly IntPtr NativeFieldInfoPtr_assetName;

			// Token: 0x040019C2 RID: 6594
			private static readonly IntPtr NativeFieldInfoPtr__l_5__2;

			// Token: 0x040019C3 RID: 6595
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040019C4 RID: 6596
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040019C5 RID: 6597
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040019C6 RID: 6598
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040019C7 RID: 6599
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040019C8 RID: 6600
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200033C RID: 828
		[ObfuscatedName("dwd.core.loader.loaders.SpriteAtlasLoader+<LoadAndWait>d__14")]
		public sealed class _LoadAndWait_d__14 : global::Il2CppSystem.Object
		{
			// Token: 0x060025E0 RID: 9696 RVA: 0x000A25C4 File Offset: 0x000A07C4
			// Note: this type is marked as 'beforefieldinit'.
			static _LoadAndWait_d__14()
			{
				Il2CppClassPointerStore<SpriteAtlasLoader._LoadAndWait_d__14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpriteAtlasLoader>.NativeClassPtr, "<LoadAndWait>d__14");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteAtlasLoader._LoadAndWait_d__14>.NativeClassPtr);
				SpriteAtlasLoader._LoadAndWait_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAtlasLoader._LoadAndWait_d__14>.NativeClassPtr, "<>1__state");
				SpriteAtlasLoader._LoadAndWait_d__14.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAtlasLoader._LoadAndWait_d__14>.NativeClassPtr, "<>2__current");
				SpriteAtlasLoader._LoadAndWait_d__14.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAtlasLoader._LoadAndWait_d__14>.NativeClassPtr, "<>4__this");
				SpriteAtlasLoader._LoadAndWait_d__14.NativeFieldInfoPtr_cropName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAtlasLoader._LoadAndWait_d__14>.NativeClassPtr, "cropName");
				SpriteAtlasLoader._LoadAndWait_d__14.NativeFieldInfoPtr_baseAssetName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAtlasLoader._LoadAndWait_d__14>.NativeClassPtr, "baseAssetName");
				SpriteAtlasLoader._LoadAndWait_d__14.NativeFieldInfoPtr_useSpriteNameFormating = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAtlasLoader._LoadAndWait_d__14>.NativeClassPtr, "useSpriteNameFormating");
				SpriteAtlasLoader._LoadAndWait_d__14.NativeFieldInfoPtr__l_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAtlasLoader._LoadAndWait_d__14>.NativeClassPtr, "<l>5__2");
				SpriteAtlasLoader._LoadAndWait_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasLoader._LoadAndWait_d__14>.NativeClassPtr, 100666945);
				SpriteAtlasLoader._LoadAndWait_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasLoader._LoadAndWait_d__14>.NativeClassPtr, 100666946);
				SpriteAtlasLoader._LoadAndWait_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasLoader._LoadAndWait_d__14>.NativeClassPtr, 100666947);
				SpriteAtlasLoader._LoadAndWait_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasLoader._LoadAndWait_d__14>.NativeClassPtr, 100666948);
				SpriteAtlasLoader._LoadAndWait_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasLoader._LoadAndWait_d__14>.NativeClassPtr, 100666949);
				SpriteAtlasLoader._LoadAndWait_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasLoader._LoadAndWait_d__14>.NativeClassPtr, 100666950);
			}

			// Token: 0x060025E1 RID: 9697 RVA: 0x000A26F4 File Offset: 0x000A08F4
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _LoadAndWait_d__14(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpriteAtlasLoader._LoadAndWait_d__14>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasLoader._LoadAndWait_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060025E2 RID: 9698 RVA: 0x000A273C File Offset: 0x000A093C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasLoader._LoadAndWait_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060025E3 RID: 9699 RVA: 0x000A2770 File Offset: 0x000A0970
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 879156, XrefRangeEnd = 879177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasLoader._LoadAndWait_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000AA8 RID: 2728
			// (get) Token: 0x060025E4 RID: 9700 RVA: 0x000A27AC File Offset: 0x000A09AC
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasLoader._LoadAndWait_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060025E5 RID: 9701 RVA: 0x000A27EC File Offset: 0x000A09EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 879177, XrefRangeEnd = 879182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasLoader._LoadAndWait_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000AA9 RID: 2729
			// (get) Token: 0x060025E6 RID: 9702 RVA: 0x000A2820 File Offset: 0x000A0A20
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasLoader._LoadAndWait_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060025E7 RID: 9703 RVA: 0x0001126A File Offset: 0x0000F46A
			public _LoadAndWait_d__14(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000AA1 RID: 2721
			// (get) Token: 0x060025E8 RID: 9704 RVA: 0x000A2860 File Offset: 0x000A0A60
			// (set) Token: 0x060025E9 RID: 9705 RVA: 0x00011273 File Offset: 0x0000F473
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasLoader._LoadAndWait_d__14.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasLoader._LoadAndWait_d__14.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000AA2 RID: 2722
			// (get) Token: 0x060025EA RID: 9706 RVA: 0x000A2888 File Offset: 0x000A0A88
			// (set) Token: 0x060025EB RID: 9707 RVA: 0x0001128E File Offset: 0x0000F48E
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasLoader._LoadAndWait_d__14.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasLoader._LoadAndWait_d__14.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AA3 RID: 2723
			// (get) Token: 0x060025EC RID: 9708 RVA: 0x000A28B8 File Offset: 0x000A0AB8
			// (set) Token: 0x060025ED RID: 9709 RVA: 0x000112AD File Offset: 0x0000F4AD
			public unsafe SpriteAtlasLoader __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasLoader._LoadAndWait_d__14.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteAtlasLoader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasLoader._LoadAndWait_d__14.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AA4 RID: 2724
			// (get) Token: 0x060025EE RID: 9710 RVA: 0x000A28E8 File Offset: 0x000A0AE8
			// (set) Token: 0x060025EF RID: 9711 RVA: 0x000112CC File Offset: 0x0000F4CC
			public unsafe string cropName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasLoader._LoadAndWait_d__14.NativeFieldInfoPtr_cropName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasLoader._LoadAndWait_d__14.NativeFieldInfoPtr_cropName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000AA5 RID: 2725
			// (get) Token: 0x060025F0 RID: 9712 RVA: 0x000A2910 File Offset: 0x000A0B10
			// (set) Token: 0x060025F1 RID: 9713 RVA: 0x000112EB File Offset: 0x0000F4EB
			public unsafe string baseAssetName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasLoader._LoadAndWait_d__14.NativeFieldInfoPtr_baseAssetName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasLoader._LoadAndWait_d__14.NativeFieldInfoPtr_baseAssetName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000AA6 RID: 2726
			// (get) Token: 0x060025F2 RID: 9714 RVA: 0x000A2938 File Offset: 0x000A0B38
			// (set) Token: 0x060025F3 RID: 9715 RVA: 0x0001130A File Offset: 0x0000F50A
			public unsafe bool useSpriteNameFormating
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasLoader._LoadAndWait_d__14.NativeFieldInfoPtr_useSpriteNameFormating);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasLoader._LoadAndWait_d__14.NativeFieldInfoPtr_useSpriteNameFormating)) = value;
				}
			}

			// Token: 0x17000AA7 RID: 2727
			// (get) Token: 0x060025F4 RID: 9716 RVA: 0x000A2960 File Offset: 0x000A0B60
			// (set) Token: 0x060025F5 RID: 9717 RVA: 0x00011325 File Offset: 0x0000F525
			public unsafe IEnumerator _l_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasLoader._LoadAndWait_d__14.NativeFieldInfoPtr__l_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasLoader._LoadAndWait_d__14.NativeFieldInfoPtr__l_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040019C9 RID: 6601
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040019CA RID: 6602
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040019CB RID: 6603
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040019CC RID: 6604
			private static readonly IntPtr NativeFieldInfoPtr_cropName;

			// Token: 0x040019CD RID: 6605
			private static readonly IntPtr NativeFieldInfoPtr_baseAssetName;

			// Token: 0x040019CE RID: 6606
			private static readonly IntPtr NativeFieldInfoPtr_useSpriteNameFormating;

			// Token: 0x040019CF RID: 6607
			private static readonly IntPtr NativeFieldInfoPtr__l_5__2;

			// Token: 0x040019D0 RID: 6608
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040019D1 RID: 6609
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040019D2 RID: 6610
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040019D3 RID: 6611
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040019D4 RID: 6612
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040019D5 RID: 6613
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200033D RID: 829
		[ObfuscatedName("dwd.core.loader.loaders.SpriteAtlasLoader+<LoadAndWait>d__15")]
		public sealed class _LoadAndWait_d__15 : global::Il2CppSystem.Object
		{
			// Token: 0x060025F6 RID: 9718 RVA: 0x000A2990 File Offset: 0x000A0B90
			// Note: this type is marked as 'beforefieldinit'.
			static _LoadAndWait_d__15()
			{
				Il2CppClassPointerStore<SpriteAtlasLoader._LoadAndWait_d__15>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpriteAtlasLoader>.NativeClassPtr, "<LoadAndWait>d__15");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteAtlasLoader._LoadAndWait_d__15>.NativeClassPtr);
				SpriteAtlasLoader._LoadAndWait_d__15.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAtlasLoader._LoadAndWait_d__15>.NativeClassPtr, "<>1__state");
				SpriteAtlasLoader._LoadAndWait_d__15.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAtlasLoader._LoadAndWait_d__15>.NativeClassPtr, "<>2__current");
				SpriteAtlasLoader._LoadAndWait_d__15.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAtlasLoader._LoadAndWait_d__15>.NativeClassPtr, "<>4__this");
				SpriteAtlasLoader._LoadAndWait_d__15.NativeFieldInfoPtr_assetName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAtlasLoader._LoadAndWait_d__15>.NativeClassPtr, "assetName");
				SpriteAtlasLoader._LoadAndWait_d__15.NativeFieldInfoPtr__l_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAtlasLoader._LoadAndWait_d__15>.NativeClassPtr, "<l>5__2");
				SpriteAtlasLoader._LoadAndWait_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasLoader._LoadAndWait_d__15>.NativeClassPtr, 100666951);
				SpriteAtlasLoader._LoadAndWait_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasLoader._LoadAndWait_d__15>.NativeClassPtr, 100666952);
				SpriteAtlasLoader._LoadAndWait_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasLoader._LoadAndWait_d__15>.NativeClassPtr, 100666953);
				SpriteAtlasLoader._LoadAndWait_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasLoader._LoadAndWait_d__15>.NativeClassPtr, 100666954);
				SpriteAtlasLoader._LoadAndWait_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasLoader._LoadAndWait_d__15>.NativeClassPtr, 100666955);
				SpriteAtlasLoader._LoadAndWait_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasLoader._LoadAndWait_d__15>.NativeClassPtr, 100666956);
			}

			// Token: 0x060025F7 RID: 9719 RVA: 0x000A2A98 File Offset: 0x000A0C98
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _LoadAndWait_d__15(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpriteAtlasLoader._LoadAndWait_d__15>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasLoader._LoadAndWait_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060025F8 RID: 9720 RVA: 0x000A2AE0 File Offset: 0x000A0CE0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasLoader._LoadAndWait_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060025F9 RID: 9721 RVA: 0x000A2B14 File Offset: 0x000A0D14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 879182, XrefRangeEnd = 879196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasLoader._LoadAndWait_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000AAF RID: 2735
			// (get) Token: 0x060025FA RID: 9722 RVA: 0x000A2B50 File Offset: 0x000A0D50
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasLoader._LoadAndWait_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060025FB RID: 9723 RVA: 0x000A2B90 File Offset: 0x000A0D90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 879196, XrefRangeEnd = 879201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasLoader._LoadAndWait_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000AB0 RID: 2736
			// (get) Token: 0x060025FC RID: 9724 RVA: 0x000A2BC4 File Offset: 0x000A0DC4
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasLoader._LoadAndWait_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060025FD RID: 9725 RVA: 0x00011344 File Offset: 0x0000F544
			public _LoadAndWait_d__15(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000AAA RID: 2730
			// (get) Token: 0x060025FE RID: 9726 RVA: 0x000A2C04 File Offset: 0x000A0E04
			// (set) Token: 0x060025FF RID: 9727 RVA: 0x0001134D File Offset: 0x0000F54D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasLoader._LoadAndWait_d__15.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasLoader._LoadAndWait_d__15.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000AAB RID: 2731
			// (get) Token: 0x06002600 RID: 9728 RVA: 0x000A2C2C File Offset: 0x000A0E2C
			// (set) Token: 0x06002601 RID: 9729 RVA: 0x00011368 File Offset: 0x0000F568
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasLoader._LoadAndWait_d__15.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasLoader._LoadAndWait_d__15.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AAC RID: 2732
			// (get) Token: 0x06002602 RID: 9730 RVA: 0x000A2C5C File Offset: 0x000A0E5C
			// (set) Token: 0x06002603 RID: 9731 RVA: 0x00011387 File Offset: 0x0000F587
			public unsafe SpriteAtlasLoader __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasLoader._LoadAndWait_d__15.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteAtlasLoader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasLoader._LoadAndWait_d__15.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AAD RID: 2733
			// (get) Token: 0x06002604 RID: 9732 RVA: 0x000A2C8C File Offset: 0x000A0E8C
			// (set) Token: 0x06002605 RID: 9733 RVA: 0x000113A6 File Offset: 0x0000F5A6
			public AssetName assetName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasLoader._LoadAndWait_d__15.NativeFieldInfoPtr_assetName);
					return new AssetName(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AssetName>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasLoader._LoadAndWait_d__15.NativeFieldInfoPtr_assetName), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AssetName>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000AAE RID: 2734
			// (get) Token: 0x06002606 RID: 9734 RVA: 0x000A2CBC File Offset: 0x000A0EBC
			// (set) Token: 0x06002607 RID: 9735 RVA: 0x000113D4 File Offset: 0x0000F5D4
			public unsafe IEnumerator _l_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasLoader._LoadAndWait_d__15.NativeFieldInfoPtr__l_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAtlasLoader._LoadAndWait_d__15.NativeFieldInfoPtr__l_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040019D6 RID: 6614
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040019D7 RID: 6615
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040019D8 RID: 6616
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040019D9 RID: 6617
			private static readonly IntPtr NativeFieldInfoPtr_assetName;

			// Token: 0x040019DA RID: 6618
			private static readonly IntPtr NativeFieldInfoPtr__l_5__2;

			// Token: 0x040019DB RID: 6619
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040019DC RID: 6620
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040019DD RID: 6621
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040019DE RID: 6622
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040019DF RID: 6623
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040019E0 RID: 6624
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
