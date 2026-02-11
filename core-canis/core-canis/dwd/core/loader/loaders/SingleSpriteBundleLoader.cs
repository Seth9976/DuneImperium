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
	// Token: 0x0200019B RID: 411
	public class SingleSpriteBundleLoader : global::Il2CppSystem.Object
	{
		// Token: 0x06001736 RID: 5942 RVA: 0x00070E38 File Offset: 0x0006F038
		// Note: this type is marked as 'beforefieldinit'.
		static SingleSpriteBundleLoader()
		{
			Il2CppClassPointerStore<SingleSpriteBundleLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.loader.loaders", "SingleSpriteBundleLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SingleSpriteBundleLoader>.NativeClassPtr);
			SingleSpriteBundleLoader.NativeFieldInfoPtr_SPRITENAMEFORMAT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleSpriteBundleLoader>.NativeClassPtr, "SPRITENAMEFORMAT");
			SingleSpriteBundleLoader.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleSpriteBundleLoader>.NativeClassPtr, "source");
			SingleSpriteBundleLoader.NativeFieldInfoPtr_assetReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleSpriteBundleLoader>.NativeClassPtr, "assetReference");
			SingleSpriteBundleLoader.NativeFieldInfoPtr__Asset_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleSpriteBundleLoader>.NativeClassPtr, "<Asset>k__BackingField");
			SingleSpriteBundleLoader.NativeFieldInfoPtr__State_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleSpriteBundleLoader>.NativeClassPtr, "<State>k__BackingField");
			SingleSpriteBundleLoader.NativeMethodInfoPtr_get_Asset_Public_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleSpriteBundleLoader>.NativeClassPtr, 100666874);
			SingleSpriteBundleLoader.NativeMethodInfoPtr_set_Asset_Private_set_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleSpriteBundleLoader>.NativeClassPtr, 100666875);
			SingleSpriteBundleLoader.NativeMethodInfoPtr_get_State_Public_get_States_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleSpriteBundleLoader>.NativeClassPtr, 100666876);
			SingleSpriteBundleLoader.NativeMethodInfoPtr_set_State_Private_set_Void_States_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleSpriteBundleLoader>.NativeClassPtr, 100666877);
			SingleSpriteBundleLoader.NativeMethodInfoPtr__ctor_Public_Void_IReferenceTracker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleSpriteBundleLoader>.NativeClassPtr, 100666878);
			SingleSpriteBundleLoader.NativeMethodInfoPtr_LoadAndWait_Public_IEnumerator_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleSpriteBundleLoader>.NativeClassPtr, 100666879);
			SingleSpriteBundleLoader.NativeMethodInfoPtr_LoadAndWait_Public_IEnumerator_AssetName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleSpriteBundleLoader>.NativeClassPtr, 100666880);
			SingleSpriteBundleLoader.NativeMethodInfoPtr_Load_Public_Void_AssetName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleSpriteBundleLoader>.NativeClassPtr, 100666881);
			SingleSpriteBundleLoader.NativeMethodInfoPtr_InternalLoadAndWait_Private_IEnumerator_AssetName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleSpriteBundleLoader>.NativeClassPtr, 100666882);
			SingleSpriteBundleLoader.NativeMethodInfoPtr_LoadAsset_Public_Void_AssetName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleSpriteBundleLoader>.NativeClassPtr, 100666883);
			SingleSpriteBundleLoader.NativeMethodInfoPtr_LoadAsset_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleSpriteBundleLoader>.NativeClassPtr, 100666884);
			SingleSpriteBundleLoader.NativeMethodInfoPtr_LoadAsset_Public_Void_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleSpriteBundleLoader>.NativeClassPtr, 100666885);
			SingleSpriteBundleLoader.NativeMethodInfoPtr_InternalLoadAsset_Private_IEnumerator_AssetName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleSpriteBundleLoader>.NativeClassPtr, 100666886);
			SingleSpriteBundleLoader.NativeMethodInfoPtr_createAssetName_Private_Static_AssetName_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleSpriteBundleLoader>.NativeClassPtr, 100666887);
		}

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x06001737 RID: 5943 RVA: 0x00070FE4 File Offset: 0x0006F1E4
		// (set) Token: 0x06001738 RID: 5944 RVA: 0x00071024 File Offset: 0x0006F224
		public unsafe Sprite Asset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleSpriteBundleLoader.NativeMethodInfoPtr_get_Asset_Public_get_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleSpriteBundleLoader.NativeMethodInfoPtr_set_Asset_Private_set_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x06001739 RID: 5945 RVA: 0x00071068 File Offset: 0x0006F268
		// (set) Token: 0x0600173A RID: 5946 RVA: 0x000710A4 File Offset: 0x0006F2A4
		public unsafe SingleSpriteBundleLoader.States State
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleSpriteBundleLoader.NativeMethodInfoPtr_get_State_Public_get_States_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleSpriteBundleLoader.NativeMethodInfoPtr_set_State_Private_set_Void_States_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600173B RID: 5947 RVA: 0x000710E4 File Offset: 0x0006F2E4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 879025, RefRangeEnd = 879031, XrefRangeStart = 879023, XrefRangeEnd = 879025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SingleSpriteBundleLoader(IReferenceTracker source)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SingleSpriteBundleLoader>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleSpriteBundleLoader.NativeMethodInfoPtr__ctor_Public_Void_IReferenceTracker_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600173C RID: 5948 RVA: 0x00071130 File Offset: 0x0006F330
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 879037, RefRangeEnd = 879038, XrefRangeStart = 879031, XrefRangeEnd = 879037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator LoadAndWait(string assetName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assetName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleSpriteBundleLoader.NativeMethodInfoPtr_LoadAndWait_Public_IEnumerator_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x0600173D RID: 5949 RVA: 0x00071180 File Offset: 0x0006F380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 879038, XrefRangeEnd = 879044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator LoadAndWait(AssetName assetName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(assetName));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleSpriteBundleLoader.NativeMethodInfoPtr_LoadAndWait_Public_IEnumerator_AssetName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x0600173E RID: 5950 RVA: 0x000711D8 File Offset: 0x0006F3D8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 879058, RefRangeEnd = 879061, XrefRangeStart = 879044, XrefRangeEnd = 879058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load(AssetName assetName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(assetName));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleSpriteBundleLoader.NativeMethodInfoPtr_Load_Public_Void_AssetName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600173F RID: 5951 RVA: 0x00071220 File Offset: 0x0006F420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 879061, XrefRangeEnd = 879067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator InternalLoadAndWait(AssetName assetName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(assetName));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleSpriteBundleLoader.NativeMethodInfoPtr_InternalLoadAndWait_Private_IEnumerator_AssetName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06001740 RID: 5952 RVA: 0x00071278 File Offset: 0x0006F478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 879067, XrefRangeEnd = 879068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadAsset(AssetName assetName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(assetName));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleSpriteBundleLoader.NativeMethodInfoPtr_LoadAsset_Public_Void_AssetName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001741 RID: 5953 RVA: 0x000712C0 File Offset: 0x0006F4C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 879071, RefRangeEnd = 879072, XrefRangeStart = 879068, XrefRangeEnd = 879071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadAsset(string assetName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assetName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleSpriteBundleLoader.NativeMethodInfoPtr_LoadAsset_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001742 RID: 5954 RVA: 0x00071304 File Offset: 0x0006F504
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 879072, XrefRangeEnd = 879079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleSpriteBundleLoader.NativeMethodInfoPtr_LoadAsset_Public_Void_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001743 RID: 5955 RVA: 0x00071368 File Offset: 0x0006F568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 879079, XrefRangeEnd = 879085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator InternalLoadAsset(AssetName assetName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(assetName));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleSpriteBundleLoader.NativeMethodInfoPtr_InternalLoadAsset_Private_IEnumerator_AssetName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06001744 RID: 5956 RVA: 0x000713C0 File Offset: 0x0006F5C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 879085, XrefRangeEnd = 879091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleSpriteBundleLoader.NativeMethodInfoPtr_createAssetName_Private_Static_AssetName_String_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AssetName(intPtr);
		}

		// Token: 0x06001745 RID: 5957 RVA: 0x0000A298 File Offset: 0x00008498
		public SingleSpriteBundleLoader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x06001746 RID: 5958 RVA: 0x0007141C File Offset: 0x0006F61C
		// (set) Token: 0x06001747 RID: 5959 RVA: 0x0000A2A1 File Offset: 0x000084A1
		public unsafe static string SPRITENAMEFORMAT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SingleSpriteBundleLoader.NativeFieldInfoPtr_SPRITENAMEFORMAT, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SingleSpriteBundleLoader.NativeFieldInfoPtr_SPRITENAMEFORMAT, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x06001748 RID: 5960 RVA: 0x0007143C File Offset: 0x0006F63C
		// (set) Token: 0x06001749 RID: 5961 RVA: 0x0000A2B3 File Offset: 0x000084B3
		public unsafe IReferenceTracker source
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteBundleLoader.NativeFieldInfoPtr_source);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReferenceTracker>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteBundleLoader.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x0600174A RID: 5962 RVA: 0x0007146C File Offset: 0x0006F66C
		// (set) Token: 0x0600174B RID: 5963 RVA: 0x0000A2D2 File Offset: 0x000084D2
		public unsafe ISpriteReference assetReference
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteBundleLoader.NativeFieldInfoPtr_assetReference);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISpriteReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteBundleLoader.NativeFieldInfoPtr_assetReference), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x0600174C RID: 5964 RVA: 0x0007149C File Offset: 0x0006F69C
		// (set) Token: 0x0600174D RID: 5965 RVA: 0x0000A2F1 File Offset: 0x000084F1
		public unsafe Sprite _Asset_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteBundleLoader.NativeFieldInfoPtr__Asset_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteBundleLoader.NativeFieldInfoPtr__Asset_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x0600174E RID: 5966 RVA: 0x000714CC File Offset: 0x0006F6CC
		// (set) Token: 0x0600174F RID: 5967 RVA: 0x0000A310 File Offset: 0x00008510
		public unsafe SingleSpriteBundleLoader.States _State_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteBundleLoader.NativeFieldInfoPtr__State_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteBundleLoader.NativeFieldInfoPtr__State_k__BackingField)) = value;
			}
		}

		// Token: 0x04001068 RID: 4200
		private static readonly IntPtr NativeFieldInfoPtr_SPRITENAMEFORMAT;

		// Token: 0x04001069 RID: 4201
		private static readonly IntPtr NativeFieldInfoPtr_source;

		// Token: 0x0400106A RID: 4202
		private static readonly IntPtr NativeFieldInfoPtr_assetReference;

		// Token: 0x0400106B RID: 4203
		private static readonly IntPtr NativeFieldInfoPtr__Asset_k__BackingField;

		// Token: 0x0400106C RID: 4204
		private static readonly IntPtr NativeFieldInfoPtr__State_k__BackingField;

		// Token: 0x0400106D RID: 4205
		private static readonly IntPtr NativeMethodInfoPtr_get_Asset_Public_get_Sprite_0;

		// Token: 0x0400106E RID: 4206
		private static readonly IntPtr NativeMethodInfoPtr_set_Asset_Private_set_Void_Sprite_0;

		// Token: 0x0400106F RID: 4207
		private static readonly IntPtr NativeMethodInfoPtr_get_State_Public_get_States_0;

		// Token: 0x04001070 RID: 4208
		private static readonly IntPtr NativeMethodInfoPtr_set_State_Private_set_Void_States_0;

		// Token: 0x04001071 RID: 4209
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IReferenceTracker_0;

		// Token: 0x04001072 RID: 4210
		private static readonly IntPtr NativeMethodInfoPtr_LoadAndWait_Public_IEnumerator_String_0;

		// Token: 0x04001073 RID: 4211
		private static readonly IntPtr NativeMethodInfoPtr_LoadAndWait_Public_IEnumerator_AssetName_0;

		// Token: 0x04001074 RID: 4212
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_AssetName_0;

		// Token: 0x04001075 RID: 4213
		private static readonly IntPtr NativeMethodInfoPtr_InternalLoadAndWait_Private_IEnumerator_AssetName_0;

		// Token: 0x04001076 RID: 4214
		private static readonly IntPtr NativeMethodInfoPtr_LoadAsset_Public_Void_AssetName_0;

		// Token: 0x04001077 RID: 4215
		private static readonly IntPtr NativeMethodInfoPtr_LoadAsset_Public_Void_String_0;

		// Token: 0x04001078 RID: 4216
		private static readonly IntPtr NativeMethodInfoPtr_LoadAsset_Public_Void_String_String_Boolean_0;

		// Token: 0x04001079 RID: 4217
		private static readonly IntPtr NativeMethodInfoPtr_InternalLoadAsset_Private_IEnumerator_AssetName_0;

		// Token: 0x0400107A RID: 4218
		private static readonly IntPtr NativeMethodInfoPtr_createAssetName_Private_Static_AssetName_String_String_Boolean_0;

		// Token: 0x02000333 RID: 819
		public enum States
		{
			// Token: 0x04001973 RID: 6515
			UNINITIALIZED,
			// Token: 0x04001974 RID: 6516
			Loading,
			// Token: 0x04001975 RID: 6517
			Loaded,
			// Token: 0x04001976 RID: 6518
			Error
		}

		// Token: 0x02000334 RID: 820
		[ObfuscatedName("dwd.core.loader.loaders.SingleSpriteBundleLoader+<InternalLoadAndWait>d__16")]
		public sealed class _InternalLoadAndWait_d__16 : global::Il2CppSystem.Object
		{
			// Token: 0x06002562 RID: 9570 RVA: 0x000A0E50 File Offset: 0x0009F050
			// Note: this type is marked as 'beforefieldinit'.
			static _InternalLoadAndWait_d__16()
			{
				Il2CppClassPointerStore<SingleSpriteBundleLoader._InternalLoadAndWait_d__16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SingleSpriteBundleLoader>.NativeClassPtr, "<InternalLoadAndWait>d__16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SingleSpriteBundleLoader._InternalLoadAndWait_d__16>.NativeClassPtr);
				SingleSpriteBundleLoader._InternalLoadAndWait_d__16.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleSpriteBundleLoader._InternalLoadAndWait_d__16>.NativeClassPtr, "<>1__state");
				SingleSpriteBundleLoader._InternalLoadAndWait_d__16.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleSpriteBundleLoader._InternalLoadAndWait_d__16>.NativeClassPtr, "<>2__current");
				SingleSpriteBundleLoader._InternalLoadAndWait_d__16.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleSpriteBundleLoader._InternalLoadAndWait_d__16>.NativeClassPtr, "<>4__this");
				SingleSpriteBundleLoader._InternalLoadAndWait_d__16.NativeFieldInfoPtr_assetName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleSpriteBundleLoader._InternalLoadAndWait_d__16>.NativeClassPtr, "assetName");
				SingleSpriteBundleLoader._InternalLoadAndWait_d__16.NativeFieldInfoPtr__load_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleSpriteBundleLoader._InternalLoadAndWait_d__16>.NativeClassPtr, "<load>5__2");
				SingleSpriteBundleLoader._InternalLoadAndWait_d__16.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleSpriteBundleLoader._InternalLoadAndWait_d__16>.NativeClassPtr, 100666888);
				SingleSpriteBundleLoader._InternalLoadAndWait_d__16.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleSpriteBundleLoader._InternalLoadAndWait_d__16>.NativeClassPtr, 100666889);
				SingleSpriteBundleLoader._InternalLoadAndWait_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleSpriteBundleLoader._InternalLoadAndWait_d__16>.NativeClassPtr, 100666890);
				SingleSpriteBundleLoader._InternalLoadAndWait_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleSpriteBundleLoader._InternalLoadAndWait_d__16>.NativeClassPtr, 100666891);
				SingleSpriteBundleLoader._InternalLoadAndWait_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleSpriteBundleLoader._InternalLoadAndWait_d__16>.NativeClassPtr, 100666892);
				SingleSpriteBundleLoader._InternalLoadAndWait_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleSpriteBundleLoader._InternalLoadAndWait_d__16>.NativeClassPtr, 100666893);
			}

			// Token: 0x06002563 RID: 9571 RVA: 0x000A0F58 File Offset: 0x0009F158
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _InternalLoadAndWait_d__16(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SingleSpriteBundleLoader._InternalLoadAndWait_d__16>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleSpriteBundleLoader._InternalLoadAndWait_d__16.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002564 RID: 9572 RVA: 0x000A0FA0 File Offset: 0x0009F1A0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleSpriteBundleLoader._InternalLoadAndWait_d__16.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002565 RID: 9573 RVA: 0x000A0FD4 File Offset: 0x0009F1D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 878939, XrefRangeEnd = 878959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleSpriteBundleLoader._InternalLoadAndWait_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000A75 RID: 2677
			// (get) Token: 0x06002566 RID: 9574 RVA: 0x000A1010 File Offset: 0x0009F210
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleSpriteBundleLoader._InternalLoadAndWait_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002567 RID: 9575 RVA: 0x000A1050 File Offset: 0x0009F250
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 878959, XrefRangeEnd = 878964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleSpriteBundleLoader._InternalLoadAndWait_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000A76 RID: 2678
			// (get) Token: 0x06002568 RID: 9576 RVA: 0x000A1084 File Offset: 0x0009F284
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleSpriteBundleLoader._InternalLoadAndWait_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002569 RID: 9577 RVA: 0x00010DBF File Offset: 0x0000EFBF
			public _InternalLoadAndWait_d__16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A70 RID: 2672
			// (get) Token: 0x0600256A RID: 9578 RVA: 0x000A10C4 File Offset: 0x0009F2C4
			// (set) Token: 0x0600256B RID: 9579 RVA: 0x00010DC8 File Offset: 0x0000EFC8
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteBundleLoader._InternalLoadAndWait_d__16.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteBundleLoader._InternalLoadAndWait_d__16.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000A71 RID: 2673
			// (get) Token: 0x0600256C RID: 9580 RVA: 0x000A10EC File Offset: 0x0009F2EC
			// (set) Token: 0x0600256D RID: 9581 RVA: 0x00010DE3 File Offset: 0x0000EFE3
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteBundleLoader._InternalLoadAndWait_d__16.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteBundleLoader._InternalLoadAndWait_d__16.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A72 RID: 2674
			// (get) Token: 0x0600256E RID: 9582 RVA: 0x000A111C File Offset: 0x0009F31C
			// (set) Token: 0x0600256F RID: 9583 RVA: 0x00010E02 File Offset: 0x0000F002
			public unsafe SingleSpriteBundleLoader __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteBundleLoader._InternalLoadAndWait_d__16.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SingleSpriteBundleLoader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteBundleLoader._InternalLoadAndWait_d__16.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A73 RID: 2675
			// (get) Token: 0x06002570 RID: 9584 RVA: 0x000A114C File Offset: 0x0009F34C
			// (set) Token: 0x06002571 RID: 9585 RVA: 0x00010E21 File Offset: 0x0000F021
			public AssetName assetName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteBundleLoader._InternalLoadAndWait_d__16.NativeFieldInfoPtr_assetName);
					return new AssetName(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AssetName>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteBundleLoader._InternalLoadAndWait_d__16.NativeFieldInfoPtr_assetName), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AssetName>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000A74 RID: 2676
			// (get) Token: 0x06002572 RID: 9586 RVA: 0x000A117C File Offset: 0x0009F37C
			// (set) Token: 0x06002573 RID: 9587 RVA: 0x00010E4F File Offset: 0x0000F04F
			public unsafe IEnumerator _load_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteBundleLoader._InternalLoadAndWait_d__16.NativeFieldInfoPtr__load_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteBundleLoader._InternalLoadAndWait_d__16.NativeFieldInfoPtr__load_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001977 RID: 6519
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001978 RID: 6520
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001979 RID: 6521
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400197A RID: 6522
			private static readonly IntPtr NativeFieldInfoPtr_assetName;

			// Token: 0x0400197B RID: 6523
			private static readonly IntPtr NativeFieldInfoPtr__load_5__2;

			// Token: 0x0400197C RID: 6524
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400197D RID: 6525
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400197E RID: 6526
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400197F RID: 6527
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001980 RID: 6528
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001981 RID: 6529
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000335 RID: 821
		[ObfuscatedName("dwd.core.loader.loaders.SingleSpriteBundleLoader+<InternalLoadAsset>d__20")]
		public sealed class _InternalLoadAsset_d__20 : global::Il2CppSystem.Object
		{
			// Token: 0x06002574 RID: 9588 RVA: 0x000A11AC File Offset: 0x0009F3AC
			// Note: this type is marked as 'beforefieldinit'.
			static _InternalLoadAsset_d__20()
			{
				Il2CppClassPointerStore<SingleSpriteBundleLoader._InternalLoadAsset_d__20>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SingleSpriteBundleLoader>.NativeClassPtr, "<InternalLoadAsset>d__20");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SingleSpriteBundleLoader._InternalLoadAsset_d__20>.NativeClassPtr);
				SingleSpriteBundleLoader._InternalLoadAsset_d__20.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleSpriteBundleLoader._InternalLoadAsset_d__20>.NativeClassPtr, "<>1__state");
				SingleSpriteBundleLoader._InternalLoadAsset_d__20.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleSpriteBundleLoader._InternalLoadAsset_d__20>.NativeClassPtr, "<>2__current");
				SingleSpriteBundleLoader._InternalLoadAsset_d__20.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleSpriteBundleLoader._InternalLoadAsset_d__20>.NativeClassPtr, "<>4__this");
				SingleSpriteBundleLoader._InternalLoadAsset_d__20.NativeFieldInfoPtr_assetName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleSpriteBundleLoader._InternalLoadAsset_d__20>.NativeClassPtr, "assetName");
				SingleSpriteBundleLoader._InternalLoadAsset_d__20.NativeFieldInfoPtr__loadEnumerator_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleSpriteBundleLoader._InternalLoadAsset_d__20>.NativeClassPtr, "<loadEnumerator>5__2");
				SingleSpriteBundleLoader._InternalLoadAsset_d__20.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleSpriteBundleLoader._InternalLoadAsset_d__20>.NativeClassPtr, 100666894);
				SingleSpriteBundleLoader._InternalLoadAsset_d__20.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleSpriteBundleLoader._InternalLoadAsset_d__20>.NativeClassPtr, 100666895);
				SingleSpriteBundleLoader._InternalLoadAsset_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleSpriteBundleLoader._InternalLoadAsset_d__20>.NativeClassPtr, 100666896);
				SingleSpriteBundleLoader._InternalLoadAsset_d__20.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleSpriteBundleLoader._InternalLoadAsset_d__20>.NativeClassPtr, 100666897);
				SingleSpriteBundleLoader._InternalLoadAsset_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleSpriteBundleLoader._InternalLoadAsset_d__20>.NativeClassPtr, 100666898);
				SingleSpriteBundleLoader._InternalLoadAsset_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleSpriteBundleLoader._InternalLoadAsset_d__20>.NativeClassPtr, 100666899);
			}

			// Token: 0x06002575 RID: 9589 RVA: 0x000A12B4 File Offset: 0x0009F4B4
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _InternalLoadAsset_d__20(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SingleSpriteBundleLoader._InternalLoadAsset_d__20>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleSpriteBundleLoader._InternalLoadAsset_d__20.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002576 RID: 9590 RVA: 0x000A12FC File Offset: 0x0009F4FC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleSpriteBundleLoader._InternalLoadAsset_d__20.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002577 RID: 9591 RVA: 0x000A1330 File Offset: 0x0009F530
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 878964, XrefRangeEnd = 878978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleSpriteBundleLoader._InternalLoadAsset_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000A7C RID: 2684
			// (get) Token: 0x06002578 RID: 9592 RVA: 0x000A136C File Offset: 0x0009F56C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleSpriteBundleLoader._InternalLoadAsset_d__20.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002579 RID: 9593 RVA: 0x000A13AC File Offset: 0x0009F5AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 878978, XrefRangeEnd = 878983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleSpriteBundleLoader._InternalLoadAsset_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000A7D RID: 2685
			// (get) Token: 0x0600257A RID: 9594 RVA: 0x000A13E0 File Offset: 0x0009F5E0
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleSpriteBundleLoader._InternalLoadAsset_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600257B RID: 9595 RVA: 0x00010E6E File Offset: 0x0000F06E
			public _InternalLoadAsset_d__20(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A77 RID: 2679
			// (get) Token: 0x0600257C RID: 9596 RVA: 0x000A1420 File Offset: 0x0009F620
			// (set) Token: 0x0600257D RID: 9597 RVA: 0x00010E77 File Offset: 0x0000F077
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteBundleLoader._InternalLoadAsset_d__20.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteBundleLoader._InternalLoadAsset_d__20.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000A78 RID: 2680
			// (get) Token: 0x0600257E RID: 9598 RVA: 0x000A1448 File Offset: 0x0009F648
			// (set) Token: 0x0600257F RID: 9599 RVA: 0x00010E92 File Offset: 0x0000F092
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteBundleLoader._InternalLoadAsset_d__20.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteBundleLoader._InternalLoadAsset_d__20.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A79 RID: 2681
			// (get) Token: 0x06002580 RID: 9600 RVA: 0x000A1478 File Offset: 0x0009F678
			// (set) Token: 0x06002581 RID: 9601 RVA: 0x00010EB1 File Offset: 0x0000F0B1
			public unsafe SingleSpriteBundleLoader __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteBundleLoader._InternalLoadAsset_d__20.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SingleSpriteBundleLoader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteBundleLoader._InternalLoadAsset_d__20.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A7A RID: 2682
			// (get) Token: 0x06002582 RID: 9602 RVA: 0x000A14A8 File Offset: 0x0009F6A8
			// (set) Token: 0x06002583 RID: 9603 RVA: 0x00010ED0 File Offset: 0x0000F0D0
			public AssetName assetName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteBundleLoader._InternalLoadAsset_d__20.NativeFieldInfoPtr_assetName);
					return new AssetName(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AssetName>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteBundleLoader._InternalLoadAsset_d__20.NativeFieldInfoPtr_assetName), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AssetName>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000A7B RID: 2683
			// (get) Token: 0x06002584 RID: 9604 RVA: 0x000A14D8 File Offset: 0x0009F6D8
			// (set) Token: 0x06002585 RID: 9605 RVA: 0x00010EFE File Offset: 0x0000F0FE
			public unsafe IEnumerator _loadEnumerator_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteBundleLoader._InternalLoadAsset_d__20.NativeFieldInfoPtr__loadEnumerator_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteBundleLoader._InternalLoadAsset_d__20.NativeFieldInfoPtr__loadEnumerator_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001982 RID: 6530
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001983 RID: 6531
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001984 RID: 6532
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001985 RID: 6533
			private static readonly IntPtr NativeFieldInfoPtr_assetName;

			// Token: 0x04001986 RID: 6534
			private static readonly IntPtr NativeFieldInfoPtr__loadEnumerator_5__2;

			// Token: 0x04001987 RID: 6535
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001988 RID: 6536
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001989 RID: 6537
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400198A RID: 6538
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400198B RID: 6539
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400198C RID: 6540
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000336 RID: 822
		[ObfuscatedName("dwd.core.loader.loaders.SingleSpriteBundleLoader+<LoadAndWait>d__13")]
		public sealed class _LoadAndWait_d__13 : global::Il2CppSystem.Object
		{
			// Token: 0x06002586 RID: 9606 RVA: 0x000A1508 File Offset: 0x0009F708
			// Note: this type is marked as 'beforefieldinit'.
			static _LoadAndWait_d__13()
			{
				Il2CppClassPointerStore<SingleSpriteBundleLoader._LoadAndWait_d__13>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SingleSpriteBundleLoader>.NativeClassPtr, "<LoadAndWait>d__13");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SingleSpriteBundleLoader._LoadAndWait_d__13>.NativeClassPtr);
				SingleSpriteBundleLoader._LoadAndWait_d__13.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleSpriteBundleLoader._LoadAndWait_d__13>.NativeClassPtr, "<>1__state");
				SingleSpriteBundleLoader._LoadAndWait_d__13.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleSpriteBundleLoader._LoadAndWait_d__13>.NativeClassPtr, "<>2__current");
				SingleSpriteBundleLoader._LoadAndWait_d__13.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleSpriteBundleLoader._LoadAndWait_d__13>.NativeClassPtr, "<>4__this");
				SingleSpriteBundleLoader._LoadAndWait_d__13.NativeFieldInfoPtr_assetName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleSpriteBundleLoader._LoadAndWait_d__13>.NativeClassPtr, "assetName");
				SingleSpriteBundleLoader._LoadAndWait_d__13.NativeFieldInfoPtr__l_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleSpriteBundleLoader._LoadAndWait_d__13>.NativeClassPtr, "<l>5__2");
				SingleSpriteBundleLoader._LoadAndWait_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleSpriteBundleLoader._LoadAndWait_d__13>.NativeClassPtr, 100666900);
				SingleSpriteBundleLoader._LoadAndWait_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleSpriteBundleLoader._LoadAndWait_d__13>.NativeClassPtr, 100666901);
				SingleSpriteBundleLoader._LoadAndWait_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleSpriteBundleLoader._LoadAndWait_d__13>.NativeClassPtr, 100666902);
				SingleSpriteBundleLoader._LoadAndWait_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleSpriteBundleLoader._LoadAndWait_d__13>.NativeClassPtr, 100666903);
				SingleSpriteBundleLoader._LoadAndWait_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleSpriteBundleLoader._LoadAndWait_d__13>.NativeClassPtr, 100666904);
				SingleSpriteBundleLoader._LoadAndWait_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleSpriteBundleLoader._LoadAndWait_d__13>.NativeClassPtr, 100666905);
			}

			// Token: 0x06002587 RID: 9607 RVA: 0x000A1610 File Offset: 0x0009F810
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _LoadAndWait_d__13(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SingleSpriteBundleLoader._LoadAndWait_d__13>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleSpriteBundleLoader._LoadAndWait_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002588 RID: 9608 RVA: 0x000A1658 File Offset: 0x0009F858
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleSpriteBundleLoader._LoadAndWait_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002589 RID: 9609 RVA: 0x000A168C File Offset: 0x0009F88C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 878983, XrefRangeEnd = 878999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleSpriteBundleLoader._LoadAndWait_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000A83 RID: 2691
			// (get) Token: 0x0600258A RID: 9610 RVA: 0x000A16C8 File Offset: 0x0009F8C8
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleSpriteBundleLoader._LoadAndWait_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600258B RID: 9611 RVA: 0x000A1708 File Offset: 0x0009F908
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 878999, XrefRangeEnd = 879004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleSpriteBundleLoader._LoadAndWait_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000A84 RID: 2692
			// (get) Token: 0x0600258C RID: 9612 RVA: 0x000A173C File Offset: 0x0009F93C
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleSpriteBundleLoader._LoadAndWait_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600258D RID: 9613 RVA: 0x00010F1D File Offset: 0x0000F11D
			public _LoadAndWait_d__13(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A7E RID: 2686
			// (get) Token: 0x0600258E RID: 9614 RVA: 0x000A177C File Offset: 0x0009F97C
			// (set) Token: 0x0600258F RID: 9615 RVA: 0x00010F26 File Offset: 0x0000F126
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteBundleLoader._LoadAndWait_d__13.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteBundleLoader._LoadAndWait_d__13.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000A7F RID: 2687
			// (get) Token: 0x06002590 RID: 9616 RVA: 0x000A17A4 File Offset: 0x0009F9A4
			// (set) Token: 0x06002591 RID: 9617 RVA: 0x00010F41 File Offset: 0x0000F141
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteBundleLoader._LoadAndWait_d__13.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteBundleLoader._LoadAndWait_d__13.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A80 RID: 2688
			// (get) Token: 0x06002592 RID: 9618 RVA: 0x000A17D4 File Offset: 0x0009F9D4
			// (set) Token: 0x06002593 RID: 9619 RVA: 0x00010F60 File Offset: 0x0000F160
			public unsafe SingleSpriteBundleLoader __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteBundleLoader._LoadAndWait_d__13.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SingleSpriteBundleLoader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteBundleLoader._LoadAndWait_d__13.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A81 RID: 2689
			// (get) Token: 0x06002594 RID: 9620 RVA: 0x000A1804 File Offset: 0x0009FA04
			// (set) Token: 0x06002595 RID: 9621 RVA: 0x00010F7F File Offset: 0x0000F17F
			public unsafe string assetName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteBundleLoader._LoadAndWait_d__13.NativeFieldInfoPtr_assetName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteBundleLoader._LoadAndWait_d__13.NativeFieldInfoPtr_assetName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000A82 RID: 2690
			// (get) Token: 0x06002596 RID: 9622 RVA: 0x000A182C File Offset: 0x0009FA2C
			// (set) Token: 0x06002597 RID: 9623 RVA: 0x00010F9E File Offset: 0x0000F19E
			public unsafe IEnumerator _l_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteBundleLoader._LoadAndWait_d__13.NativeFieldInfoPtr__l_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteBundleLoader._LoadAndWait_d__13.NativeFieldInfoPtr__l_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400198D RID: 6541
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400198E RID: 6542
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400198F RID: 6543
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001990 RID: 6544
			private static readonly IntPtr NativeFieldInfoPtr_assetName;

			// Token: 0x04001991 RID: 6545
			private static readonly IntPtr NativeFieldInfoPtr__l_5__2;

			// Token: 0x04001992 RID: 6546
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001993 RID: 6547
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001994 RID: 6548
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001995 RID: 6549
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001996 RID: 6550
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001997 RID: 6551
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000337 RID: 823
		[ObfuscatedName("dwd.core.loader.loaders.SingleSpriteBundleLoader+<LoadAndWait>d__14")]
		public sealed class _LoadAndWait_d__14 : global::Il2CppSystem.Object
		{
			// Token: 0x06002598 RID: 9624 RVA: 0x000A185C File Offset: 0x0009FA5C
			// Note: this type is marked as 'beforefieldinit'.
			static _LoadAndWait_d__14()
			{
				Il2CppClassPointerStore<SingleSpriteBundleLoader._LoadAndWait_d__14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SingleSpriteBundleLoader>.NativeClassPtr, "<LoadAndWait>d__14");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SingleSpriteBundleLoader._LoadAndWait_d__14>.NativeClassPtr);
				SingleSpriteBundleLoader._LoadAndWait_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleSpriteBundleLoader._LoadAndWait_d__14>.NativeClassPtr, "<>1__state");
				SingleSpriteBundleLoader._LoadAndWait_d__14.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleSpriteBundleLoader._LoadAndWait_d__14>.NativeClassPtr, "<>2__current");
				SingleSpriteBundleLoader._LoadAndWait_d__14.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleSpriteBundleLoader._LoadAndWait_d__14>.NativeClassPtr, "<>4__this");
				SingleSpriteBundleLoader._LoadAndWait_d__14.NativeFieldInfoPtr_assetName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleSpriteBundleLoader._LoadAndWait_d__14>.NativeClassPtr, "assetName");
				SingleSpriteBundleLoader._LoadAndWait_d__14.NativeFieldInfoPtr__l_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleSpriteBundleLoader._LoadAndWait_d__14>.NativeClassPtr, "<l>5__2");
				SingleSpriteBundleLoader._LoadAndWait_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleSpriteBundleLoader._LoadAndWait_d__14>.NativeClassPtr, 100666906);
				SingleSpriteBundleLoader._LoadAndWait_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleSpriteBundleLoader._LoadAndWait_d__14>.NativeClassPtr, 100666907);
				SingleSpriteBundleLoader._LoadAndWait_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleSpriteBundleLoader._LoadAndWait_d__14>.NativeClassPtr, 100666908);
				SingleSpriteBundleLoader._LoadAndWait_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleSpriteBundleLoader._LoadAndWait_d__14>.NativeClassPtr, 100666909);
				SingleSpriteBundleLoader._LoadAndWait_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleSpriteBundleLoader._LoadAndWait_d__14>.NativeClassPtr, 100666910);
				SingleSpriteBundleLoader._LoadAndWait_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleSpriteBundleLoader._LoadAndWait_d__14>.NativeClassPtr, 100666911);
			}

			// Token: 0x06002599 RID: 9625 RVA: 0x000A1964 File Offset: 0x0009FB64
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _LoadAndWait_d__14(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SingleSpriteBundleLoader._LoadAndWait_d__14>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleSpriteBundleLoader._LoadAndWait_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600259A RID: 9626 RVA: 0x000A19AC File Offset: 0x0009FBAC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleSpriteBundleLoader._LoadAndWait_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600259B RID: 9627 RVA: 0x000A19E0 File Offset: 0x0009FBE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 879004, XrefRangeEnd = 879018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleSpriteBundleLoader._LoadAndWait_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000A8A RID: 2698
			// (get) Token: 0x0600259C RID: 9628 RVA: 0x000A1A1C File Offset: 0x0009FC1C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleSpriteBundleLoader._LoadAndWait_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600259D RID: 9629 RVA: 0x000A1A5C File Offset: 0x0009FC5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 879018, XrefRangeEnd = 879023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleSpriteBundleLoader._LoadAndWait_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000A8B RID: 2699
			// (get) Token: 0x0600259E RID: 9630 RVA: 0x000A1A90 File Offset: 0x0009FC90
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleSpriteBundleLoader._LoadAndWait_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600259F RID: 9631 RVA: 0x00010FBD File Offset: 0x0000F1BD
			public _LoadAndWait_d__14(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A85 RID: 2693
			// (get) Token: 0x060025A0 RID: 9632 RVA: 0x000A1AD0 File Offset: 0x0009FCD0
			// (set) Token: 0x060025A1 RID: 9633 RVA: 0x00010FC6 File Offset: 0x0000F1C6
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteBundleLoader._LoadAndWait_d__14.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteBundleLoader._LoadAndWait_d__14.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000A86 RID: 2694
			// (get) Token: 0x060025A2 RID: 9634 RVA: 0x000A1AF8 File Offset: 0x0009FCF8
			// (set) Token: 0x060025A3 RID: 9635 RVA: 0x00010FE1 File Offset: 0x0000F1E1
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteBundleLoader._LoadAndWait_d__14.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteBundleLoader._LoadAndWait_d__14.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A87 RID: 2695
			// (get) Token: 0x060025A4 RID: 9636 RVA: 0x000A1B28 File Offset: 0x0009FD28
			// (set) Token: 0x060025A5 RID: 9637 RVA: 0x00011000 File Offset: 0x0000F200
			public unsafe SingleSpriteBundleLoader __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteBundleLoader._LoadAndWait_d__14.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SingleSpriteBundleLoader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteBundleLoader._LoadAndWait_d__14.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A88 RID: 2696
			// (get) Token: 0x060025A6 RID: 9638 RVA: 0x000A1B58 File Offset: 0x0009FD58
			// (set) Token: 0x060025A7 RID: 9639 RVA: 0x0001101F File Offset: 0x0000F21F
			public AssetName assetName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteBundleLoader._LoadAndWait_d__14.NativeFieldInfoPtr_assetName);
					return new AssetName(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AssetName>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteBundleLoader._LoadAndWait_d__14.NativeFieldInfoPtr_assetName), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AssetName>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000A89 RID: 2697
			// (get) Token: 0x060025A8 RID: 9640 RVA: 0x000A1B88 File Offset: 0x0009FD88
			// (set) Token: 0x060025A9 RID: 9641 RVA: 0x0001104D File Offset: 0x0000F24D
			public unsafe IEnumerator _l_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteBundleLoader._LoadAndWait_d__14.NativeFieldInfoPtr__l_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteBundleLoader._LoadAndWait_d__14.NativeFieldInfoPtr__l_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001998 RID: 6552
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001999 RID: 6553
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400199A RID: 6554
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400199B RID: 6555
			private static readonly IntPtr NativeFieldInfoPtr_assetName;

			// Token: 0x0400199C RID: 6556
			private static readonly IntPtr NativeFieldInfoPtr__l_5__2;

			// Token: 0x0400199D RID: 6557
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400199E RID: 6558
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400199F RID: 6559
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040019A0 RID: 6560
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040019A1 RID: 6561
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040019A2 RID: 6562
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
