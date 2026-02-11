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
	// Token: 0x0200019D RID: 413
	public class SpriteBundleLoader : global::Il2CppSystem.Object
	{
		// Token: 0x0600176B RID: 5995 RVA: 0x00071C34 File Offset: 0x0006FE34
		// Note: this type is marked as 'beforefieldinit'.
		static SpriteBundleLoader()
		{
			Il2CppClassPointerStore<SpriteBundleLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.loader.loaders", "SpriteBundleLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteBundleLoader>.NativeClassPtr);
			SpriteBundleLoader.NativeFieldInfoPtr_SPRITENAMEFORMAT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteBundleLoader>.NativeClassPtr, "SPRITENAMEFORMAT");
			SpriteBundleLoader.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteBundleLoader>.NativeClassPtr, "source");
			SpriteBundleLoader.NativeFieldInfoPtr_assetReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteBundleLoader>.NativeClassPtr, "assetReference");
			SpriteBundleLoader.NativeFieldInfoPtr__Asset_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteBundleLoader>.NativeClassPtr, "<Asset>k__BackingField");
			SpriteBundleLoader.NativeFieldInfoPtr__State_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteBundleLoader>.NativeClassPtr, "<State>k__BackingField");
			SpriteBundleLoader.NativeMethodInfoPtr_get_Asset_Public_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteBundleLoader>.NativeClassPtr, 100666957);
			SpriteBundleLoader.NativeMethodInfoPtr_set_Asset_Private_set_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteBundleLoader>.NativeClassPtr, 100666958);
			SpriteBundleLoader.NativeMethodInfoPtr_get_State_Public_get_States_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteBundleLoader>.NativeClassPtr, 100666959);
			SpriteBundleLoader.NativeMethodInfoPtr_set_State_Private_set_Void_States_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteBundleLoader>.NativeClassPtr, 100666960);
			SpriteBundleLoader.NativeMethodInfoPtr__ctor_Public_Void_IReferenceTracker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteBundleLoader>.NativeClassPtr, 100666961);
			SpriteBundleLoader.NativeMethodInfoPtr_LoadAndWait_Public_IEnumerator_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteBundleLoader>.NativeClassPtr, 100666962);
			SpriteBundleLoader.NativeMethodInfoPtr_LoadAndWait_Public_IEnumerator_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteBundleLoader>.NativeClassPtr, 100666963);
			SpriteBundleLoader.NativeMethodInfoPtr_LoadAndWait_Public_IEnumerator_AssetName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteBundleLoader>.NativeClassPtr, 100666964);
			SpriteBundleLoader.NativeMethodInfoPtr_Load_Public_Void_AssetName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteBundleLoader>.NativeClassPtr, 100666965);
			SpriteBundleLoader.NativeMethodInfoPtr_InternalLoadAndWait_Private_IEnumerator_AssetName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteBundleLoader>.NativeClassPtr, 100666966);
			SpriteBundleLoader.NativeMethodInfoPtr_LoadAsset_Public_Void_AssetName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteBundleLoader>.NativeClassPtr, 100666967);
			SpriteBundleLoader.NativeMethodInfoPtr_LoadAsset_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteBundleLoader>.NativeClassPtr, 100666968);
			SpriteBundleLoader.NativeMethodInfoPtr_LoadAsset_Public_Void_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteBundleLoader>.NativeClassPtr, 100666969);
			SpriteBundleLoader.NativeMethodInfoPtr_InternalLoadAsset_Private_IEnumerator_AssetName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteBundleLoader>.NativeClassPtr, 100666970);
			SpriteBundleLoader.NativeMethodInfoPtr_createAssetName_Private_Static_AssetName_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteBundleLoader>.NativeClassPtr, 100666971);
		}

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x0600176C RID: 5996 RVA: 0x00071DF4 File Offset: 0x0006FFF4
		// (set) Token: 0x0600176D RID: 5997 RVA: 0x00071E34 File Offset: 0x00070034
		public unsafe Sprite Asset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteBundleLoader.NativeMethodInfoPtr_get_Asset_Public_get_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteBundleLoader.NativeMethodInfoPtr_set_Asset_Private_set_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x0600176E RID: 5998 RVA: 0x00071E78 File Offset: 0x00070078
		// (set) Token: 0x0600176F RID: 5999 RVA: 0x00071EB4 File Offset: 0x000700B4
		public unsafe SpriteBundleLoader.States State
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteBundleLoader.NativeMethodInfoPtr_get_State_Public_get_States_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteBundleLoader.NativeMethodInfoPtr_set_State_Private_set_Void_States_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001770 RID: 6000 RVA: 0x00071EF4 File Offset: 0x000700F4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 879025, RefRangeEnd = 879031, XrefRangeStart = 879025, XrefRangeEnd = 879031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpriteBundleLoader(IReferenceTracker source)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpriteBundleLoader>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteBundleLoader.NativeMethodInfoPtr__ctor_Public_Void_IReferenceTracker_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001771 RID: 6001 RVA: 0x00071F40 File Offset: 0x00070140
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 879378, XrefRangeEnd = 879384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator LoadAndWait(string assetName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assetName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteBundleLoader.NativeMethodInfoPtr_LoadAndWait_Public_IEnumerator_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06001772 RID: 6002 RVA: 0x00071F90 File Offset: 0x00070190
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 879391, RefRangeEnd = 879392, XrefRangeStart = 879384, XrefRangeEnd = 879391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteBundleLoader.NativeMethodInfoPtr_LoadAndWait_Public_IEnumerator_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001773 RID: 6003 RVA: 0x00072000 File Offset: 0x00070200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 879392, XrefRangeEnd = 879398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator LoadAndWait(AssetName assetName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(assetName));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteBundleLoader.NativeMethodInfoPtr_LoadAndWait_Public_IEnumerator_AssetName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06001774 RID: 6004 RVA: 0x00072058 File Offset: 0x00070258
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 879412, RefRangeEnd = 879415, XrefRangeStart = 879398, XrefRangeEnd = 879412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load(AssetName assetName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(assetName));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteBundleLoader.NativeMethodInfoPtr_Load_Public_Void_AssetName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001775 RID: 6005 RVA: 0x000720A0 File Offset: 0x000702A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 879415, XrefRangeEnd = 879421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator InternalLoadAndWait(AssetName assetName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(assetName));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteBundleLoader.NativeMethodInfoPtr_InternalLoadAndWait_Private_IEnumerator_AssetName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06001776 RID: 6006 RVA: 0x000720F8 File Offset: 0x000702F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 879421, XrefRangeEnd = 879422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadAsset(AssetName assetName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(assetName));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteBundleLoader.NativeMethodInfoPtr_LoadAsset_Public_Void_AssetName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001777 RID: 6007 RVA: 0x00072140 File Offset: 0x00070340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 879422, XrefRangeEnd = 879425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadAsset(string assetName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assetName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteBundleLoader.NativeMethodInfoPtr_LoadAsset_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001778 RID: 6008 RVA: 0x00072184 File Offset: 0x00070384
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 879432, RefRangeEnd = 879433, XrefRangeStart = 879425, XrefRangeEnd = 879432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteBundleLoader.NativeMethodInfoPtr_LoadAsset_Public_Void_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001779 RID: 6009 RVA: 0x000721E8 File Offset: 0x000703E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 879433, XrefRangeEnd = 879439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator InternalLoadAsset(AssetName assetName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(assetName));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteBundleLoader.NativeMethodInfoPtr_InternalLoadAsset_Private_IEnumerator_AssetName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x0600177A RID: 6010 RVA: 0x00072240 File Offset: 0x00070440
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 879439, XrefRangeEnd = 879445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteBundleLoader.NativeMethodInfoPtr_createAssetName_Private_Static_AssetName_String_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AssetName(intPtr);
		}

		// Token: 0x0600177B RID: 6011 RVA: 0x0000A3BE File Offset: 0x000085BE
		public SpriteBundleLoader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x0600177C RID: 6012 RVA: 0x0007229C File Offset: 0x0007049C
		// (set) Token: 0x0600177D RID: 6013 RVA: 0x0000A3C7 File Offset: 0x000085C7
		public unsafe static string SPRITENAMEFORMAT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SpriteBundleLoader.NativeFieldInfoPtr_SPRITENAMEFORMAT, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SpriteBundleLoader.NativeFieldInfoPtr_SPRITENAMEFORMAT, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x0600177E RID: 6014 RVA: 0x000722BC File Offset: 0x000704BC
		// (set) Token: 0x0600177F RID: 6015 RVA: 0x0000A3D9 File Offset: 0x000085D9
		public unsafe IReferenceTracker source
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBundleLoader.NativeFieldInfoPtr_source);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReferenceTracker>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBundleLoader.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x06001780 RID: 6016 RVA: 0x000722EC File Offset: 0x000704EC
		// (set) Token: 0x06001781 RID: 6017 RVA: 0x0000A3F8 File Offset: 0x000085F8
		public unsafe ISpriteReference assetReference
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBundleLoader.NativeFieldInfoPtr_assetReference);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISpriteReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBundleLoader.NativeFieldInfoPtr_assetReference), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x06001782 RID: 6018 RVA: 0x0007231C File Offset: 0x0007051C
		// (set) Token: 0x06001783 RID: 6019 RVA: 0x0000A417 File Offset: 0x00008617
		public unsafe Sprite _Asset_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBundleLoader.NativeFieldInfoPtr__Asset_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBundleLoader.NativeFieldInfoPtr__Asset_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x06001784 RID: 6020 RVA: 0x0007234C File Offset: 0x0007054C
		// (set) Token: 0x06001785 RID: 6021 RVA: 0x0000A436 File Offset: 0x00008636
		public unsafe SpriteBundleLoader.States _State_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBundleLoader.NativeFieldInfoPtr__State_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBundleLoader.NativeFieldInfoPtr__State_k__BackingField)) = value;
			}
		}

		// Token: 0x0400108F RID: 4239
		private static readonly IntPtr NativeFieldInfoPtr_SPRITENAMEFORMAT;

		// Token: 0x04001090 RID: 4240
		private static readonly IntPtr NativeFieldInfoPtr_source;

		// Token: 0x04001091 RID: 4241
		private static readonly IntPtr NativeFieldInfoPtr_assetReference;

		// Token: 0x04001092 RID: 4242
		private static readonly IntPtr NativeFieldInfoPtr__Asset_k__BackingField;

		// Token: 0x04001093 RID: 4243
		private static readonly IntPtr NativeFieldInfoPtr__State_k__BackingField;

		// Token: 0x04001094 RID: 4244
		private static readonly IntPtr NativeMethodInfoPtr_get_Asset_Public_get_Sprite_0;

		// Token: 0x04001095 RID: 4245
		private static readonly IntPtr NativeMethodInfoPtr_set_Asset_Private_set_Void_Sprite_0;

		// Token: 0x04001096 RID: 4246
		private static readonly IntPtr NativeMethodInfoPtr_get_State_Public_get_States_0;

		// Token: 0x04001097 RID: 4247
		private static readonly IntPtr NativeMethodInfoPtr_set_State_Private_set_Void_States_0;

		// Token: 0x04001098 RID: 4248
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IReferenceTracker_0;

		// Token: 0x04001099 RID: 4249
		private static readonly IntPtr NativeMethodInfoPtr_LoadAndWait_Public_IEnumerator_String_0;

		// Token: 0x0400109A RID: 4250
		private static readonly IntPtr NativeMethodInfoPtr_LoadAndWait_Public_IEnumerator_String_String_Boolean_0;

		// Token: 0x0400109B RID: 4251
		private static readonly IntPtr NativeMethodInfoPtr_LoadAndWait_Public_IEnumerator_AssetName_0;

		// Token: 0x0400109C RID: 4252
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_AssetName_0;

		// Token: 0x0400109D RID: 4253
		private static readonly IntPtr NativeMethodInfoPtr_InternalLoadAndWait_Private_IEnumerator_AssetName_0;

		// Token: 0x0400109E RID: 4254
		private static readonly IntPtr NativeMethodInfoPtr_LoadAsset_Public_Void_AssetName_0;

		// Token: 0x0400109F RID: 4255
		private static readonly IntPtr NativeMethodInfoPtr_LoadAsset_Public_Void_String_0;

		// Token: 0x040010A0 RID: 4256
		private static readonly IntPtr NativeMethodInfoPtr_LoadAsset_Public_Void_String_String_Boolean_0;

		// Token: 0x040010A1 RID: 4257
		private static readonly IntPtr NativeMethodInfoPtr_InternalLoadAsset_Private_IEnumerator_AssetName_0;

		// Token: 0x040010A2 RID: 4258
		private static readonly IntPtr NativeMethodInfoPtr_createAssetName_Private_Static_AssetName_String_String_Boolean_0;

		// Token: 0x0200033E RID: 830
		public enum States
		{
			// Token: 0x040019E2 RID: 6626
			UNINITIALIZED,
			// Token: 0x040019E3 RID: 6627
			Loading,
			// Token: 0x040019E4 RID: 6628
			Loaded,
			// Token: 0x040019E5 RID: 6629
			Error
		}

		// Token: 0x0200033F RID: 831
		[ObfuscatedName("dwd.core.loader.loaders.SpriteBundleLoader+<InternalLoadAndWait>d__17")]
		public sealed class _InternalLoadAndWait_d__17 : global::Il2CppSystem.Object
		{
			// Token: 0x06002608 RID: 9736 RVA: 0x000A2CEC File Offset: 0x000A0EEC
			// Note: this type is marked as 'beforefieldinit'.
			static _InternalLoadAndWait_d__17()
			{
				Il2CppClassPointerStore<SpriteBundleLoader._InternalLoadAndWait_d__17>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpriteBundleLoader>.NativeClassPtr, "<InternalLoadAndWait>d__17");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteBundleLoader._InternalLoadAndWait_d__17>.NativeClassPtr);
				SpriteBundleLoader._InternalLoadAndWait_d__17.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteBundleLoader._InternalLoadAndWait_d__17>.NativeClassPtr, "<>1__state");
				SpriteBundleLoader._InternalLoadAndWait_d__17.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteBundleLoader._InternalLoadAndWait_d__17>.NativeClassPtr, "<>2__current");
				SpriteBundleLoader._InternalLoadAndWait_d__17.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteBundleLoader._InternalLoadAndWait_d__17>.NativeClassPtr, "<>4__this");
				SpriteBundleLoader._InternalLoadAndWait_d__17.NativeFieldInfoPtr_assetName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteBundleLoader._InternalLoadAndWait_d__17>.NativeClassPtr, "assetName");
				SpriteBundleLoader._InternalLoadAndWait_d__17.NativeFieldInfoPtr__load_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteBundleLoader._InternalLoadAndWait_d__17>.NativeClassPtr, "<load>5__2");
				SpriteBundleLoader._InternalLoadAndWait_d__17.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteBundleLoader._InternalLoadAndWait_d__17>.NativeClassPtr, 100666972);
				SpriteBundleLoader._InternalLoadAndWait_d__17.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteBundleLoader._InternalLoadAndWait_d__17>.NativeClassPtr, 100666973);
				SpriteBundleLoader._InternalLoadAndWait_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteBundleLoader._InternalLoadAndWait_d__17>.NativeClassPtr, 100666974);
				SpriteBundleLoader._InternalLoadAndWait_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteBundleLoader._InternalLoadAndWait_d__17>.NativeClassPtr, 100666975);
				SpriteBundleLoader._InternalLoadAndWait_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteBundleLoader._InternalLoadAndWait_d__17>.NativeClassPtr, 100666976);
				SpriteBundleLoader._InternalLoadAndWait_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteBundleLoader._InternalLoadAndWait_d__17>.NativeClassPtr, 100666977);
			}

			// Token: 0x06002609 RID: 9737 RVA: 0x000A2DF4 File Offset: 0x000A0FF4
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _InternalLoadAndWait_d__17(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpriteBundleLoader._InternalLoadAndWait_d__17>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteBundleLoader._InternalLoadAndWait_d__17.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600260A RID: 9738 RVA: 0x000A2E3C File Offset: 0x000A103C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteBundleLoader._InternalLoadAndWait_d__17.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600260B RID: 9739 RVA: 0x000A2E70 File Offset: 0x000A1070
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 879268, XrefRangeEnd = 879288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteBundleLoader._InternalLoadAndWait_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000AB6 RID: 2742
			// (get) Token: 0x0600260C RID: 9740 RVA: 0x000A2EAC File Offset: 0x000A10AC
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteBundleLoader._InternalLoadAndWait_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600260D RID: 9741 RVA: 0x000A2EEC File Offset: 0x000A10EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 879288, XrefRangeEnd = 879293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteBundleLoader._InternalLoadAndWait_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000AB7 RID: 2743
			// (get) Token: 0x0600260E RID: 9742 RVA: 0x000A2F20 File Offset: 0x000A1120
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteBundleLoader._InternalLoadAndWait_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600260F RID: 9743 RVA: 0x000113F3 File Offset: 0x0000F5F3
			public _InternalLoadAndWait_d__17(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000AB1 RID: 2737
			// (get) Token: 0x06002610 RID: 9744 RVA: 0x000A2F60 File Offset: 0x000A1160
			// (set) Token: 0x06002611 RID: 9745 RVA: 0x000113FC File Offset: 0x0000F5FC
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBundleLoader._InternalLoadAndWait_d__17.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBundleLoader._InternalLoadAndWait_d__17.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000AB2 RID: 2738
			// (get) Token: 0x06002612 RID: 9746 RVA: 0x000A2F88 File Offset: 0x000A1188
			// (set) Token: 0x06002613 RID: 9747 RVA: 0x00011417 File Offset: 0x0000F617
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBundleLoader._InternalLoadAndWait_d__17.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBundleLoader._InternalLoadAndWait_d__17.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AB3 RID: 2739
			// (get) Token: 0x06002614 RID: 9748 RVA: 0x000A2FB8 File Offset: 0x000A11B8
			// (set) Token: 0x06002615 RID: 9749 RVA: 0x00011436 File Offset: 0x0000F636
			public unsafe SpriteBundleLoader __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBundleLoader._InternalLoadAndWait_d__17.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteBundleLoader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBundleLoader._InternalLoadAndWait_d__17.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AB4 RID: 2740
			// (get) Token: 0x06002616 RID: 9750 RVA: 0x000A2FE8 File Offset: 0x000A11E8
			// (set) Token: 0x06002617 RID: 9751 RVA: 0x00011455 File Offset: 0x0000F655
			public AssetName assetName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBundleLoader._InternalLoadAndWait_d__17.NativeFieldInfoPtr_assetName);
					return new AssetName(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AssetName>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBundleLoader._InternalLoadAndWait_d__17.NativeFieldInfoPtr_assetName), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AssetName>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000AB5 RID: 2741
			// (get) Token: 0x06002618 RID: 9752 RVA: 0x000A3018 File Offset: 0x000A1218
			// (set) Token: 0x06002619 RID: 9753 RVA: 0x00011483 File Offset: 0x0000F683
			public unsafe IEnumerator _load_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBundleLoader._InternalLoadAndWait_d__17.NativeFieldInfoPtr__load_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBundleLoader._InternalLoadAndWait_d__17.NativeFieldInfoPtr__load_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040019E6 RID: 6630
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040019E7 RID: 6631
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040019E8 RID: 6632
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040019E9 RID: 6633
			private static readonly IntPtr NativeFieldInfoPtr_assetName;

			// Token: 0x040019EA RID: 6634
			private static readonly IntPtr NativeFieldInfoPtr__load_5__2;

			// Token: 0x040019EB RID: 6635
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040019EC RID: 6636
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040019ED RID: 6637
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040019EE RID: 6638
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040019EF RID: 6639
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040019F0 RID: 6640
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000340 RID: 832
		[ObfuscatedName("dwd.core.loader.loaders.SpriteBundleLoader+<InternalLoadAsset>d__21")]
		public sealed class _InternalLoadAsset_d__21 : global::Il2CppSystem.Object
		{
			// Token: 0x0600261A RID: 9754 RVA: 0x000A3048 File Offset: 0x000A1248
			// Note: this type is marked as 'beforefieldinit'.
			static _InternalLoadAsset_d__21()
			{
				Il2CppClassPointerStore<SpriteBundleLoader._InternalLoadAsset_d__21>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpriteBundleLoader>.NativeClassPtr, "<InternalLoadAsset>d__21");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteBundleLoader._InternalLoadAsset_d__21>.NativeClassPtr);
				SpriteBundleLoader._InternalLoadAsset_d__21.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteBundleLoader._InternalLoadAsset_d__21>.NativeClassPtr, "<>1__state");
				SpriteBundleLoader._InternalLoadAsset_d__21.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteBundleLoader._InternalLoadAsset_d__21>.NativeClassPtr, "<>2__current");
				SpriteBundleLoader._InternalLoadAsset_d__21.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteBundleLoader._InternalLoadAsset_d__21>.NativeClassPtr, "<>4__this");
				SpriteBundleLoader._InternalLoadAsset_d__21.NativeFieldInfoPtr_assetName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteBundleLoader._InternalLoadAsset_d__21>.NativeClassPtr, "assetName");
				SpriteBundleLoader._InternalLoadAsset_d__21.NativeFieldInfoPtr__loadEnumerator_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteBundleLoader._InternalLoadAsset_d__21>.NativeClassPtr, "<loadEnumerator>5__2");
				SpriteBundleLoader._InternalLoadAsset_d__21.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteBundleLoader._InternalLoadAsset_d__21>.NativeClassPtr, 100666978);
				SpriteBundleLoader._InternalLoadAsset_d__21.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteBundleLoader._InternalLoadAsset_d__21>.NativeClassPtr, 100666979);
				SpriteBundleLoader._InternalLoadAsset_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteBundleLoader._InternalLoadAsset_d__21>.NativeClassPtr, 100666980);
				SpriteBundleLoader._InternalLoadAsset_d__21.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteBundleLoader._InternalLoadAsset_d__21>.NativeClassPtr, 100666981);
				SpriteBundleLoader._InternalLoadAsset_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteBundleLoader._InternalLoadAsset_d__21>.NativeClassPtr, 100666982);
				SpriteBundleLoader._InternalLoadAsset_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteBundleLoader._InternalLoadAsset_d__21>.NativeClassPtr, 100666983);
			}

			// Token: 0x0600261B RID: 9755 RVA: 0x000A3150 File Offset: 0x000A1350
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _InternalLoadAsset_d__21(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpriteBundleLoader._InternalLoadAsset_d__21>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteBundleLoader._InternalLoadAsset_d__21.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600261C RID: 9756 RVA: 0x000A3198 File Offset: 0x000A1398
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteBundleLoader._InternalLoadAsset_d__21.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600261D RID: 9757 RVA: 0x000A31CC File Offset: 0x000A13CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 879293, XrefRangeEnd = 879307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteBundleLoader._InternalLoadAsset_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000ABD RID: 2749
			// (get) Token: 0x0600261E RID: 9758 RVA: 0x000A3208 File Offset: 0x000A1408
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteBundleLoader._InternalLoadAsset_d__21.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600261F RID: 9759 RVA: 0x000A3248 File Offset: 0x000A1448
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 879307, XrefRangeEnd = 879312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteBundleLoader._InternalLoadAsset_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000ABE RID: 2750
			// (get) Token: 0x06002620 RID: 9760 RVA: 0x000A327C File Offset: 0x000A147C
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteBundleLoader._InternalLoadAsset_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002621 RID: 9761 RVA: 0x000114A2 File Offset: 0x0000F6A2
			public _InternalLoadAsset_d__21(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000AB8 RID: 2744
			// (get) Token: 0x06002622 RID: 9762 RVA: 0x000A32BC File Offset: 0x000A14BC
			// (set) Token: 0x06002623 RID: 9763 RVA: 0x000114AB File Offset: 0x0000F6AB
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBundleLoader._InternalLoadAsset_d__21.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBundleLoader._InternalLoadAsset_d__21.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000AB9 RID: 2745
			// (get) Token: 0x06002624 RID: 9764 RVA: 0x000A32E4 File Offset: 0x000A14E4
			// (set) Token: 0x06002625 RID: 9765 RVA: 0x000114C6 File Offset: 0x0000F6C6
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBundleLoader._InternalLoadAsset_d__21.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBundleLoader._InternalLoadAsset_d__21.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000ABA RID: 2746
			// (get) Token: 0x06002626 RID: 9766 RVA: 0x000A3314 File Offset: 0x000A1514
			// (set) Token: 0x06002627 RID: 9767 RVA: 0x000114E5 File Offset: 0x0000F6E5
			public unsafe SpriteBundleLoader __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBundleLoader._InternalLoadAsset_d__21.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteBundleLoader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBundleLoader._InternalLoadAsset_d__21.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000ABB RID: 2747
			// (get) Token: 0x06002628 RID: 9768 RVA: 0x000A3344 File Offset: 0x000A1544
			// (set) Token: 0x06002629 RID: 9769 RVA: 0x00011504 File Offset: 0x0000F704
			public AssetName assetName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBundleLoader._InternalLoadAsset_d__21.NativeFieldInfoPtr_assetName);
					return new AssetName(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AssetName>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBundleLoader._InternalLoadAsset_d__21.NativeFieldInfoPtr_assetName), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AssetName>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000ABC RID: 2748
			// (get) Token: 0x0600262A RID: 9770 RVA: 0x000A3374 File Offset: 0x000A1574
			// (set) Token: 0x0600262B RID: 9771 RVA: 0x00011532 File Offset: 0x0000F732
			public unsafe IEnumerator _loadEnumerator_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBundleLoader._InternalLoadAsset_d__21.NativeFieldInfoPtr__loadEnumerator_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBundleLoader._InternalLoadAsset_d__21.NativeFieldInfoPtr__loadEnumerator_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040019F1 RID: 6641
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040019F2 RID: 6642
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040019F3 RID: 6643
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040019F4 RID: 6644
			private static readonly IntPtr NativeFieldInfoPtr_assetName;

			// Token: 0x040019F5 RID: 6645
			private static readonly IntPtr NativeFieldInfoPtr__loadEnumerator_5__2;

			// Token: 0x040019F6 RID: 6646
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040019F7 RID: 6647
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040019F8 RID: 6648
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040019F9 RID: 6649
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040019FA RID: 6650
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040019FB RID: 6651
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000341 RID: 833
		[ObfuscatedName("dwd.core.loader.loaders.SpriteBundleLoader+<LoadAndWait>d__13")]
		public sealed class _LoadAndWait_d__13 : global::Il2CppSystem.Object
		{
			// Token: 0x0600262C RID: 9772 RVA: 0x000A33A4 File Offset: 0x000A15A4
			// Note: this type is marked as 'beforefieldinit'.
			static _LoadAndWait_d__13()
			{
				Il2CppClassPointerStore<SpriteBundleLoader._LoadAndWait_d__13>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpriteBundleLoader>.NativeClassPtr, "<LoadAndWait>d__13");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteBundleLoader._LoadAndWait_d__13>.NativeClassPtr);
				SpriteBundleLoader._LoadAndWait_d__13.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteBundleLoader._LoadAndWait_d__13>.NativeClassPtr, "<>1__state");
				SpriteBundleLoader._LoadAndWait_d__13.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteBundleLoader._LoadAndWait_d__13>.NativeClassPtr, "<>2__current");
				SpriteBundleLoader._LoadAndWait_d__13.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteBundleLoader._LoadAndWait_d__13>.NativeClassPtr, "<>4__this");
				SpriteBundleLoader._LoadAndWait_d__13.NativeFieldInfoPtr_assetName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteBundleLoader._LoadAndWait_d__13>.NativeClassPtr, "assetName");
				SpriteBundleLoader._LoadAndWait_d__13.NativeFieldInfoPtr__l_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteBundleLoader._LoadAndWait_d__13>.NativeClassPtr, "<l>5__2");
				SpriteBundleLoader._LoadAndWait_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteBundleLoader._LoadAndWait_d__13>.NativeClassPtr, 100666984);
				SpriteBundleLoader._LoadAndWait_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteBundleLoader._LoadAndWait_d__13>.NativeClassPtr, 100666985);
				SpriteBundleLoader._LoadAndWait_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteBundleLoader._LoadAndWait_d__13>.NativeClassPtr, 100666986);
				SpriteBundleLoader._LoadAndWait_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteBundleLoader._LoadAndWait_d__13>.NativeClassPtr, 100666987);
				SpriteBundleLoader._LoadAndWait_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteBundleLoader._LoadAndWait_d__13>.NativeClassPtr, 100666988);
				SpriteBundleLoader._LoadAndWait_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteBundleLoader._LoadAndWait_d__13>.NativeClassPtr, 100666989);
			}

			// Token: 0x0600262D RID: 9773 RVA: 0x000A34AC File Offset: 0x000A16AC
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _LoadAndWait_d__13(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpriteBundleLoader._LoadAndWait_d__13>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteBundleLoader._LoadAndWait_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600262E RID: 9774 RVA: 0x000A34F4 File Offset: 0x000A16F4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteBundleLoader._LoadAndWait_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600262F RID: 9775 RVA: 0x000A3528 File Offset: 0x000A1728
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 879312, XrefRangeEnd = 879328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteBundleLoader._LoadAndWait_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000AC4 RID: 2756
			// (get) Token: 0x06002630 RID: 9776 RVA: 0x000A3564 File Offset: 0x000A1764
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteBundleLoader._LoadAndWait_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002631 RID: 9777 RVA: 0x000A35A4 File Offset: 0x000A17A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 879328, XrefRangeEnd = 879333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteBundleLoader._LoadAndWait_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000AC5 RID: 2757
			// (get) Token: 0x06002632 RID: 9778 RVA: 0x000A35D8 File Offset: 0x000A17D8
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteBundleLoader._LoadAndWait_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002633 RID: 9779 RVA: 0x00011551 File Offset: 0x0000F751
			public _LoadAndWait_d__13(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000ABF RID: 2751
			// (get) Token: 0x06002634 RID: 9780 RVA: 0x000A3618 File Offset: 0x000A1818
			// (set) Token: 0x06002635 RID: 9781 RVA: 0x0001155A File Offset: 0x0000F75A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBundleLoader._LoadAndWait_d__13.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBundleLoader._LoadAndWait_d__13.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000AC0 RID: 2752
			// (get) Token: 0x06002636 RID: 9782 RVA: 0x000A3640 File Offset: 0x000A1840
			// (set) Token: 0x06002637 RID: 9783 RVA: 0x00011575 File Offset: 0x0000F775
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBundleLoader._LoadAndWait_d__13.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBundleLoader._LoadAndWait_d__13.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AC1 RID: 2753
			// (get) Token: 0x06002638 RID: 9784 RVA: 0x000A3670 File Offset: 0x000A1870
			// (set) Token: 0x06002639 RID: 9785 RVA: 0x00011594 File Offset: 0x0000F794
			public unsafe SpriteBundleLoader __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBundleLoader._LoadAndWait_d__13.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteBundleLoader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBundleLoader._LoadAndWait_d__13.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AC2 RID: 2754
			// (get) Token: 0x0600263A RID: 9786 RVA: 0x000A36A0 File Offset: 0x000A18A0
			// (set) Token: 0x0600263B RID: 9787 RVA: 0x000115B3 File Offset: 0x0000F7B3
			public unsafe string assetName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBundleLoader._LoadAndWait_d__13.NativeFieldInfoPtr_assetName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBundleLoader._LoadAndWait_d__13.NativeFieldInfoPtr_assetName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000AC3 RID: 2755
			// (get) Token: 0x0600263C RID: 9788 RVA: 0x000A36C8 File Offset: 0x000A18C8
			// (set) Token: 0x0600263D RID: 9789 RVA: 0x000115D2 File Offset: 0x0000F7D2
			public unsafe IEnumerator _l_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBundleLoader._LoadAndWait_d__13.NativeFieldInfoPtr__l_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBundleLoader._LoadAndWait_d__13.NativeFieldInfoPtr__l_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040019FC RID: 6652
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040019FD RID: 6653
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040019FE RID: 6654
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040019FF RID: 6655
			private static readonly IntPtr NativeFieldInfoPtr_assetName;

			// Token: 0x04001A00 RID: 6656
			private static readonly IntPtr NativeFieldInfoPtr__l_5__2;

			// Token: 0x04001A01 RID: 6657
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001A02 RID: 6658
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001A03 RID: 6659
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001A04 RID: 6660
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001A05 RID: 6661
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001A06 RID: 6662
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000342 RID: 834
		[ObfuscatedName("dwd.core.loader.loaders.SpriteBundleLoader+<LoadAndWait>d__14")]
		public sealed class _LoadAndWait_d__14 : global::Il2CppSystem.Object
		{
			// Token: 0x0600263E RID: 9790 RVA: 0x000A36F8 File Offset: 0x000A18F8
			// Note: this type is marked as 'beforefieldinit'.
			static _LoadAndWait_d__14()
			{
				Il2CppClassPointerStore<SpriteBundleLoader._LoadAndWait_d__14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpriteBundleLoader>.NativeClassPtr, "<LoadAndWait>d__14");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteBundleLoader._LoadAndWait_d__14>.NativeClassPtr);
				SpriteBundleLoader._LoadAndWait_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteBundleLoader._LoadAndWait_d__14>.NativeClassPtr, "<>1__state");
				SpriteBundleLoader._LoadAndWait_d__14.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteBundleLoader._LoadAndWait_d__14>.NativeClassPtr, "<>2__current");
				SpriteBundleLoader._LoadAndWait_d__14.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteBundleLoader._LoadAndWait_d__14>.NativeClassPtr, "<>4__this");
				SpriteBundleLoader._LoadAndWait_d__14.NativeFieldInfoPtr_cropName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteBundleLoader._LoadAndWait_d__14>.NativeClassPtr, "cropName");
				SpriteBundleLoader._LoadAndWait_d__14.NativeFieldInfoPtr_baseAssetName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteBundleLoader._LoadAndWait_d__14>.NativeClassPtr, "baseAssetName");
				SpriteBundleLoader._LoadAndWait_d__14.NativeFieldInfoPtr_useSpriteNameFormating = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteBundleLoader._LoadAndWait_d__14>.NativeClassPtr, "useSpriteNameFormating");
				SpriteBundleLoader._LoadAndWait_d__14.NativeFieldInfoPtr__l_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteBundleLoader._LoadAndWait_d__14>.NativeClassPtr, "<l>5__2");
				SpriteBundleLoader._LoadAndWait_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteBundleLoader._LoadAndWait_d__14>.NativeClassPtr, 100666990);
				SpriteBundleLoader._LoadAndWait_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteBundleLoader._LoadAndWait_d__14>.NativeClassPtr, 100666991);
				SpriteBundleLoader._LoadAndWait_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteBundleLoader._LoadAndWait_d__14>.NativeClassPtr, 100666992);
				SpriteBundleLoader._LoadAndWait_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteBundleLoader._LoadAndWait_d__14>.NativeClassPtr, 100666993);
				SpriteBundleLoader._LoadAndWait_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteBundleLoader._LoadAndWait_d__14>.NativeClassPtr, 100666994);
				SpriteBundleLoader._LoadAndWait_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteBundleLoader._LoadAndWait_d__14>.NativeClassPtr, 100666995);
			}

			// Token: 0x0600263F RID: 9791 RVA: 0x000A3828 File Offset: 0x000A1A28
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _LoadAndWait_d__14(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpriteBundleLoader._LoadAndWait_d__14>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteBundleLoader._LoadAndWait_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002640 RID: 9792 RVA: 0x000A3870 File Offset: 0x000A1A70
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteBundleLoader._LoadAndWait_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002641 RID: 9793 RVA: 0x000A38A4 File Offset: 0x000A1AA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 879333, XrefRangeEnd = 879354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteBundleLoader._LoadAndWait_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000ACD RID: 2765
			// (get) Token: 0x06002642 RID: 9794 RVA: 0x000A38E0 File Offset: 0x000A1AE0
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteBundleLoader._LoadAndWait_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002643 RID: 9795 RVA: 0x000A3920 File Offset: 0x000A1B20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 879354, XrefRangeEnd = 879359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteBundleLoader._LoadAndWait_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000ACE RID: 2766
			// (get) Token: 0x06002644 RID: 9796 RVA: 0x000A3954 File Offset: 0x000A1B54
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteBundleLoader._LoadAndWait_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002645 RID: 9797 RVA: 0x000115F1 File Offset: 0x0000F7F1
			public _LoadAndWait_d__14(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000AC6 RID: 2758
			// (get) Token: 0x06002646 RID: 9798 RVA: 0x000A3994 File Offset: 0x000A1B94
			// (set) Token: 0x06002647 RID: 9799 RVA: 0x000115FA File Offset: 0x0000F7FA
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBundleLoader._LoadAndWait_d__14.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBundleLoader._LoadAndWait_d__14.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000AC7 RID: 2759
			// (get) Token: 0x06002648 RID: 9800 RVA: 0x000A39BC File Offset: 0x000A1BBC
			// (set) Token: 0x06002649 RID: 9801 RVA: 0x00011615 File Offset: 0x0000F815
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBundleLoader._LoadAndWait_d__14.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBundleLoader._LoadAndWait_d__14.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AC8 RID: 2760
			// (get) Token: 0x0600264A RID: 9802 RVA: 0x000A39EC File Offset: 0x000A1BEC
			// (set) Token: 0x0600264B RID: 9803 RVA: 0x00011634 File Offset: 0x0000F834
			public unsafe SpriteBundleLoader __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBundleLoader._LoadAndWait_d__14.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteBundleLoader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBundleLoader._LoadAndWait_d__14.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AC9 RID: 2761
			// (get) Token: 0x0600264C RID: 9804 RVA: 0x000A3A1C File Offset: 0x000A1C1C
			// (set) Token: 0x0600264D RID: 9805 RVA: 0x00011653 File Offset: 0x0000F853
			public unsafe string cropName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBundleLoader._LoadAndWait_d__14.NativeFieldInfoPtr_cropName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBundleLoader._LoadAndWait_d__14.NativeFieldInfoPtr_cropName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000ACA RID: 2762
			// (get) Token: 0x0600264E RID: 9806 RVA: 0x000A3A44 File Offset: 0x000A1C44
			// (set) Token: 0x0600264F RID: 9807 RVA: 0x00011672 File Offset: 0x0000F872
			public unsafe string baseAssetName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBundleLoader._LoadAndWait_d__14.NativeFieldInfoPtr_baseAssetName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBundleLoader._LoadAndWait_d__14.NativeFieldInfoPtr_baseAssetName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000ACB RID: 2763
			// (get) Token: 0x06002650 RID: 9808 RVA: 0x000A3A6C File Offset: 0x000A1C6C
			// (set) Token: 0x06002651 RID: 9809 RVA: 0x00011691 File Offset: 0x0000F891
			public unsafe bool useSpriteNameFormating
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBundleLoader._LoadAndWait_d__14.NativeFieldInfoPtr_useSpriteNameFormating);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBundleLoader._LoadAndWait_d__14.NativeFieldInfoPtr_useSpriteNameFormating)) = value;
				}
			}

			// Token: 0x17000ACC RID: 2764
			// (get) Token: 0x06002652 RID: 9810 RVA: 0x000A3A94 File Offset: 0x000A1C94
			// (set) Token: 0x06002653 RID: 9811 RVA: 0x000116AC File Offset: 0x0000F8AC
			public unsafe IEnumerator _l_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBundleLoader._LoadAndWait_d__14.NativeFieldInfoPtr__l_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBundleLoader._LoadAndWait_d__14.NativeFieldInfoPtr__l_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001A07 RID: 6663
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001A08 RID: 6664
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001A09 RID: 6665
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001A0A RID: 6666
			private static readonly IntPtr NativeFieldInfoPtr_cropName;

			// Token: 0x04001A0B RID: 6667
			private static readonly IntPtr NativeFieldInfoPtr_baseAssetName;

			// Token: 0x04001A0C RID: 6668
			private static readonly IntPtr NativeFieldInfoPtr_useSpriteNameFormating;

			// Token: 0x04001A0D RID: 6669
			private static readonly IntPtr NativeFieldInfoPtr__l_5__2;

			// Token: 0x04001A0E RID: 6670
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001A0F RID: 6671
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001A10 RID: 6672
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001A11 RID: 6673
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001A12 RID: 6674
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001A13 RID: 6675
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000343 RID: 835
		[ObfuscatedName("dwd.core.loader.loaders.SpriteBundleLoader+<LoadAndWait>d__15")]
		public sealed class _LoadAndWait_d__15 : global::Il2CppSystem.Object
		{
			// Token: 0x06002654 RID: 9812 RVA: 0x000A3AC4 File Offset: 0x000A1CC4
			// Note: this type is marked as 'beforefieldinit'.
			static _LoadAndWait_d__15()
			{
				Il2CppClassPointerStore<SpriteBundleLoader._LoadAndWait_d__15>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpriteBundleLoader>.NativeClassPtr, "<LoadAndWait>d__15");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteBundleLoader._LoadAndWait_d__15>.NativeClassPtr);
				SpriteBundleLoader._LoadAndWait_d__15.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteBundleLoader._LoadAndWait_d__15>.NativeClassPtr, "<>1__state");
				SpriteBundleLoader._LoadAndWait_d__15.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteBundleLoader._LoadAndWait_d__15>.NativeClassPtr, "<>2__current");
				SpriteBundleLoader._LoadAndWait_d__15.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteBundleLoader._LoadAndWait_d__15>.NativeClassPtr, "<>4__this");
				SpriteBundleLoader._LoadAndWait_d__15.NativeFieldInfoPtr_assetName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteBundleLoader._LoadAndWait_d__15>.NativeClassPtr, "assetName");
				SpriteBundleLoader._LoadAndWait_d__15.NativeFieldInfoPtr__l_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteBundleLoader._LoadAndWait_d__15>.NativeClassPtr, "<l>5__2");
				SpriteBundleLoader._LoadAndWait_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteBundleLoader._LoadAndWait_d__15>.NativeClassPtr, 100666996);
				SpriteBundleLoader._LoadAndWait_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteBundleLoader._LoadAndWait_d__15>.NativeClassPtr, 100666997);
				SpriteBundleLoader._LoadAndWait_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteBundleLoader._LoadAndWait_d__15>.NativeClassPtr, 100666998);
				SpriteBundleLoader._LoadAndWait_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteBundleLoader._LoadAndWait_d__15>.NativeClassPtr, 100666999);
				SpriteBundleLoader._LoadAndWait_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteBundleLoader._LoadAndWait_d__15>.NativeClassPtr, 100667000);
				SpriteBundleLoader._LoadAndWait_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteBundleLoader._LoadAndWait_d__15>.NativeClassPtr, 100667001);
			}

			// Token: 0x06002655 RID: 9813 RVA: 0x000A3BCC File Offset: 0x000A1DCC
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _LoadAndWait_d__15(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpriteBundleLoader._LoadAndWait_d__15>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteBundleLoader._LoadAndWait_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002656 RID: 9814 RVA: 0x000A3C14 File Offset: 0x000A1E14
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteBundleLoader._LoadAndWait_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002657 RID: 9815 RVA: 0x000A3C48 File Offset: 0x000A1E48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 879359, XrefRangeEnd = 879373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteBundleLoader._LoadAndWait_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000AD4 RID: 2772
			// (get) Token: 0x06002658 RID: 9816 RVA: 0x000A3C84 File Offset: 0x000A1E84
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteBundleLoader._LoadAndWait_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002659 RID: 9817 RVA: 0x000A3CC4 File Offset: 0x000A1EC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 879373, XrefRangeEnd = 879378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteBundleLoader._LoadAndWait_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000AD5 RID: 2773
			// (get) Token: 0x0600265A RID: 9818 RVA: 0x000A3CF8 File Offset: 0x000A1EF8
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteBundleLoader._LoadAndWait_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600265B RID: 9819 RVA: 0x000116CB File Offset: 0x0000F8CB
			public _LoadAndWait_d__15(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000ACF RID: 2767
			// (get) Token: 0x0600265C RID: 9820 RVA: 0x000A3D38 File Offset: 0x000A1F38
			// (set) Token: 0x0600265D RID: 9821 RVA: 0x000116D4 File Offset: 0x0000F8D4
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBundleLoader._LoadAndWait_d__15.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBundleLoader._LoadAndWait_d__15.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000AD0 RID: 2768
			// (get) Token: 0x0600265E RID: 9822 RVA: 0x000A3D60 File Offset: 0x000A1F60
			// (set) Token: 0x0600265F RID: 9823 RVA: 0x000116EF File Offset: 0x0000F8EF
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBundleLoader._LoadAndWait_d__15.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBundleLoader._LoadAndWait_d__15.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AD1 RID: 2769
			// (get) Token: 0x06002660 RID: 9824 RVA: 0x000A3D90 File Offset: 0x000A1F90
			// (set) Token: 0x06002661 RID: 9825 RVA: 0x0001170E File Offset: 0x0000F90E
			public unsafe SpriteBundleLoader __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBundleLoader._LoadAndWait_d__15.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteBundleLoader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBundleLoader._LoadAndWait_d__15.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AD2 RID: 2770
			// (get) Token: 0x06002662 RID: 9826 RVA: 0x000A3DC0 File Offset: 0x000A1FC0
			// (set) Token: 0x06002663 RID: 9827 RVA: 0x0001172D File Offset: 0x0000F92D
			public AssetName assetName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBundleLoader._LoadAndWait_d__15.NativeFieldInfoPtr_assetName);
					return new AssetName(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AssetName>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBundleLoader._LoadAndWait_d__15.NativeFieldInfoPtr_assetName), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AssetName>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000AD3 RID: 2771
			// (get) Token: 0x06002664 RID: 9828 RVA: 0x000A3DF0 File Offset: 0x000A1FF0
			// (set) Token: 0x06002665 RID: 9829 RVA: 0x0001175B File Offset: 0x0000F95B
			public unsafe IEnumerator _l_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBundleLoader._LoadAndWait_d__15.NativeFieldInfoPtr__l_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBundleLoader._LoadAndWait_d__15.NativeFieldInfoPtr__l_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001A14 RID: 6676
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001A15 RID: 6677
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001A16 RID: 6678
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001A17 RID: 6679
			private static readonly IntPtr NativeFieldInfoPtr_assetName;

			// Token: 0x04001A18 RID: 6680
			private static readonly IntPtr NativeFieldInfoPtr__l_5__2;

			// Token: 0x04001A19 RID: 6681
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001A1A RID: 6682
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001A1B RID: 6683
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001A1C RID: 6684
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001A1D RID: 6685
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001A1E RID: 6686
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
