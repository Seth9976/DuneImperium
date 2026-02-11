using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.Networking;

namespace boardgames.src.broadcast.motd
{
	// Token: 0x02000159 RID: 345
	public class BroadcastContentProvider : MonoBehaviour
	{
		// Token: 0x06001179 RID: 4473 RVA: 0x00046B70 File Offset: 0x00044D70
		// Note: this type is marked as 'beforefieldinit'.
		static BroadcastContentProvider()
		{
			Il2CppClassPointerStore<BroadcastContentProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.src.broadcast.motd", "BroadcastContentProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BroadcastContentProvider>.NativeClassPtr);
			BroadcastContentProvider.NativeFieldInfoPtr_initializedAssets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BroadcastContentProvider>.NativeClassPtr, "initializedAssets");
			BroadcastContentProvider.NativeFieldInfoPtr_initializedLoc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BroadcastContentProvider>.NativeClassPtr, "initializedLoc");
			BroadcastContentProvider.NativeFieldInfoPtr_needLocFromAssets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BroadcastContentProvider>.NativeClassPtr, "needLocFromAssets");
			BroadcastContentProvider.NativeFieldInfoPtr__AssetsVersion_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BroadcastContentProvider>.NativeClassPtr, "<AssetsVersion>k__BackingField");
			BroadcastContentProvider.NativeFieldInfoPtr__BroadcastedAssets_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BroadcastContentProvider>.NativeClassPtr, "<BroadcastedAssets>k__BackingField");
			BroadcastContentProvider.NativeFieldInfoPtr_broadcastedLoc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BroadcastContentProvider>.NativeClassPtr, "broadcastedLoc");
			BroadcastContentProvider.NativeFieldInfoPtr_platformDirectory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BroadcastContentProvider>.NativeClassPtr, "platformDirectory");
			BroadcastContentProvider.NativeFieldInfoPtr_fallbackToPrecache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BroadcastContentProvider>.NativeClassPtr, "fallbackToPrecache");
			BroadcastContentProvider.NativeMethodInfoPtr_get_InitializedAssets_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BroadcastContentProvider>.NativeClassPtr, 100665861);
			BroadcastContentProvider.NativeMethodInfoPtr_get_InitializedLoc_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BroadcastContentProvider>.NativeClassPtr, 100665862);
			BroadcastContentProvider.NativeMethodInfoPtr_get_AssetsVersion_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BroadcastContentProvider>.NativeClassPtr, 100665863);
			BroadcastContentProvider.NativeMethodInfoPtr_set_AssetsVersion_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BroadcastContentProvider>.NativeClassPtr, 100665864);
			BroadcastContentProvider.NativeMethodInfoPtr_get_BroadcastedAssets_Public_get_AssetBundle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BroadcastContentProvider>.NativeClassPtr, 100665865);
			BroadcastContentProvider.NativeMethodInfoPtr_set_BroadcastedAssets_Private_set_Void_AssetBundle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BroadcastContentProvider>.NativeClassPtr, 100665866);
			BroadcastContentProvider.NativeMethodInfoPtr_get_BroadcastedLoc_Public_get_AssetBundle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BroadcastContentProvider>.NativeClassPtr, 100665867);
			BroadcastContentProvider.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BroadcastContentProvider>.NativeClassPtr, 100665868);
			BroadcastContentProvider.NativeMethodInfoPtr_Init_Public_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BroadcastContentProvider>.NativeClassPtr, 100665869);
			BroadcastContentProvider.NativeMethodInfoPtr_IgnorePrecache_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BroadcastContentProvider>.NativeClassPtr, 100665870);
			BroadcastContentProvider.NativeMethodInfoPtr_downloadBroadcastContent_Protected_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BroadcastContentProvider>.NativeClassPtr, 100665871);
			BroadcastContentProvider.NativeMethodInfoPtr_downloadBundle_Private_IEnumerator_String_Nullable_1_Hash128_String_AssetBundle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BroadcastContentProvider>.NativeClassPtr, 100665872);
			BroadcastContentProvider.NativeMethodInfoPtr_attachBundle_Private_Void_String_Nullable_1_Hash128_AssetBundle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BroadcastContentProvider>.NativeClassPtr, 100665873);
			BroadcastContentProvider.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BroadcastContentProvider>.NativeClassPtr, 100665874);
			BroadcastContentProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BroadcastContentProvider>.NativeClassPtr, 100665875);
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x0600117A RID: 4474 RVA: 0x00046D6C File Offset: 0x00044F6C
		public unsafe bool InitializedAssets
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 308625, RefRangeEnd = 308626, XrefRangeStart = 308625, XrefRangeEnd = 308626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BroadcastContentProvider.NativeMethodInfoPtr_get_InitializedAssets_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x0600117B RID: 4475 RVA: 0x00046DA8 File Offset: 0x00044FA8
		public unsafe bool InitializedLoc
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1000173, RefRangeEnd = 1000174, XrefRangeStart = 1000173, XrefRangeEnd = 1000173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BroadcastContentProvider.NativeMethodInfoPtr_get_InitializedLoc_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x0600117C RID: 4476 RVA: 0x00046DE4 File Offset: 0x00044FE4
		// (set) Token: 0x0600117D RID: 4477 RVA: 0x00046E1C File Offset: 0x0004501C
		public unsafe string AssetsVersion
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BroadcastContentProvider.NativeMethodInfoPtr_get_AssetsVersion_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BroadcastContentProvider.NativeMethodInfoPtr_set_AssetsVersion_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x0600117E RID: 4478 RVA: 0x00046E60 File Offset: 0x00045060
		// (set) Token: 0x0600117F RID: 4479 RVA: 0x00046EA0 File Offset: 0x000450A0
		public unsafe AssetBundle BroadcastedAssets
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BroadcastContentProvider.NativeMethodInfoPtr_get_BroadcastedAssets_Public_get_AssetBundle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssetBundle>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BroadcastContentProvider.NativeMethodInfoPtr_set_BroadcastedAssets_Private_set_Void_AssetBundle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x06001180 RID: 4480 RVA: 0x00046EE4 File Offset: 0x000450E4
		public unsafe AssetBundle BroadcastedLoc
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BroadcastContentProvider.NativeMethodInfoPtr_get_BroadcastedLoc_Public_get_AssetBundle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssetBundle>(intPtr3) : null;
			}
		}

		// Token: 0x06001181 RID: 4481 RVA: 0x00046F24 File Offset: 0x00045124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000174, XrefRangeEnd = 1000180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BroadcastContentProvider.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001182 RID: 4482 RVA: 0x00046F58 File Offset: 0x00045158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000180, XrefRangeEnd = 1000185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BroadcastContentProvider.NativeMethodInfoPtr_Init_Public_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001183 RID: 4483 RVA: 0x00046F98 File Offset: 0x00045198
		[CallerCount(0)]
		public unsafe virtual void IgnorePrecache()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BroadcastContentProvider.NativeMethodInfoPtr_IgnorePrecache_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001184 RID: 4484 RVA: 0x00046FCC File Offset: 0x000451CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000185, XrefRangeEnd = 1000190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator downloadBroadcastContent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BroadcastContentProvider.NativeMethodInfoPtr_downloadBroadcastContent_Protected_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001185 RID: 4485 RVA: 0x00047018 File Offset: 0x00045218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000190, XrefRangeEnd = 1000197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator downloadBundle(string url, Nullable<Hash128> versionHash, string versionUrl, AssetBundle existingBundle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(versionHash));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(versionUrl);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(existingBundle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BroadcastContentProvider.NativeMethodInfoPtr_downloadBundle_Private_IEnumerator_String_Nullable_1_Hash128_String_AssetBundle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001186 RID: 4486 RVA: 0x000470A4 File Offset: 0x000452A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1000232, RefRangeEnd = 1000233, XrefRangeStart = 1000197, XrefRangeEnd = 1000232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void attachBundle(string sourceUrl, Nullable<Hash128> versionHash, AssetBundle bundle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sourceUrl);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(versionHash));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bundle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BroadcastContentProvider.NativeMethodInfoPtr_attachBundle_Private_Void_String_Nullable_1_Hash128_AssetBundle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001187 RID: 4487 RVA: 0x00047110 File Offset: 0x00045310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000233, XrefRangeEnd = 1000238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BroadcastContentProvider.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001188 RID: 4488 RVA: 0x00047144 File Offset: 0x00045344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000238, XrefRangeEnd = 1000243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BroadcastContentProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BroadcastContentProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BroadcastContentProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001189 RID: 4489 RVA: 0x0000A261 File Offset: 0x00008461
		public BroadcastContentProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x0600118A RID: 4490 RVA: 0x00047180 File Offset: 0x00045380
		// (set) Token: 0x0600118B RID: 4491 RVA: 0x0000A26A File Offset: 0x0000846A
		public unsafe bool initializedAssets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BroadcastContentProvider.NativeFieldInfoPtr_initializedAssets);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BroadcastContentProvider.NativeFieldInfoPtr_initializedAssets)) = value;
			}
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x0600118C RID: 4492 RVA: 0x000471A8 File Offset: 0x000453A8
		// (set) Token: 0x0600118D RID: 4493 RVA: 0x0000A285 File Offset: 0x00008485
		public unsafe bool initializedLoc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BroadcastContentProvider.NativeFieldInfoPtr_initializedLoc);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BroadcastContentProvider.NativeFieldInfoPtr_initializedLoc)) = value;
			}
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x0600118E RID: 4494 RVA: 0x000471D0 File Offset: 0x000453D0
		// (set) Token: 0x0600118F RID: 4495 RVA: 0x0000A2A0 File Offset: 0x000084A0
		public unsafe bool needLocFromAssets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BroadcastContentProvider.NativeFieldInfoPtr_needLocFromAssets);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BroadcastContentProvider.NativeFieldInfoPtr_needLocFromAssets)) = value;
			}
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x06001190 RID: 4496 RVA: 0x000471F8 File Offset: 0x000453F8
		// (set) Token: 0x06001191 RID: 4497 RVA: 0x0000A2BB File Offset: 0x000084BB
		public unsafe string _AssetsVersion_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BroadcastContentProvider.NativeFieldInfoPtr__AssetsVersion_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BroadcastContentProvider.NativeFieldInfoPtr__AssetsVersion_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06001192 RID: 4498 RVA: 0x00047220 File Offset: 0x00045420
		// (set) Token: 0x06001193 RID: 4499 RVA: 0x0000A2DA File Offset: 0x000084DA
		public unsafe AssetBundle _BroadcastedAssets_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BroadcastContentProvider.NativeFieldInfoPtr__BroadcastedAssets_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetBundle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BroadcastContentProvider.NativeFieldInfoPtr__BroadcastedAssets_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06001194 RID: 4500 RVA: 0x00047250 File Offset: 0x00045450
		// (set) Token: 0x06001195 RID: 4501 RVA: 0x0000A2F9 File Offset: 0x000084F9
		public unsafe AssetBundle broadcastedLoc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BroadcastContentProvider.NativeFieldInfoPtr_broadcastedLoc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetBundle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BroadcastContentProvider.NativeFieldInfoPtr_broadcastedLoc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x06001196 RID: 4502 RVA: 0x00047280 File Offset: 0x00045480
		// (set) Token: 0x06001197 RID: 4503 RVA: 0x0000A318 File Offset: 0x00008518
		public unsafe string platformDirectory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BroadcastContentProvider.NativeFieldInfoPtr_platformDirectory);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BroadcastContentProvider.NativeFieldInfoPtr_platformDirectory), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x06001198 RID: 4504 RVA: 0x000472A8 File Offset: 0x000454A8
		// (set) Token: 0x06001199 RID: 4505 RVA: 0x0000A337 File Offset: 0x00008537
		public unsafe bool fallbackToPrecache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BroadcastContentProvider.NativeFieldInfoPtr_fallbackToPrecache);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BroadcastContentProvider.NativeFieldInfoPtr_fallbackToPrecache)) = value;
			}
		}

		// Token: 0x04000A9F RID: 2719
		private static readonly IntPtr NativeFieldInfoPtr_initializedAssets;

		// Token: 0x04000AA0 RID: 2720
		private static readonly IntPtr NativeFieldInfoPtr_initializedLoc;

		// Token: 0x04000AA1 RID: 2721
		private static readonly IntPtr NativeFieldInfoPtr_needLocFromAssets;

		// Token: 0x04000AA2 RID: 2722
		private static readonly IntPtr NativeFieldInfoPtr__AssetsVersion_k__BackingField;

		// Token: 0x04000AA3 RID: 2723
		private static readonly IntPtr NativeFieldInfoPtr__BroadcastedAssets_k__BackingField;

		// Token: 0x04000AA4 RID: 2724
		private static readonly IntPtr NativeFieldInfoPtr_broadcastedLoc;

		// Token: 0x04000AA5 RID: 2725
		private static readonly IntPtr NativeFieldInfoPtr_platformDirectory;

		// Token: 0x04000AA6 RID: 2726
		private static readonly IntPtr NativeFieldInfoPtr_fallbackToPrecache;

		// Token: 0x04000AA7 RID: 2727
		private static readonly IntPtr NativeMethodInfoPtr_get_InitializedAssets_Public_get_Boolean_0;

		// Token: 0x04000AA8 RID: 2728
		private static readonly IntPtr NativeMethodInfoPtr_get_InitializedLoc_Public_get_Boolean_0;

		// Token: 0x04000AA9 RID: 2729
		private static readonly IntPtr NativeMethodInfoPtr_get_AssetsVersion_Public_get_String_0;

		// Token: 0x04000AAA RID: 2730
		private static readonly IntPtr NativeMethodInfoPtr_set_AssetsVersion_Private_set_Void_String_0;

		// Token: 0x04000AAB RID: 2731
		private static readonly IntPtr NativeMethodInfoPtr_get_BroadcastedAssets_Public_get_AssetBundle_0;

		// Token: 0x04000AAC RID: 2732
		private static readonly IntPtr NativeMethodInfoPtr_set_BroadcastedAssets_Private_set_Void_AssetBundle_0;

		// Token: 0x04000AAD RID: 2733
		private static readonly IntPtr NativeMethodInfoPtr_get_BroadcastedLoc_Public_get_AssetBundle_0;

		// Token: 0x04000AAE RID: 2734
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000AAF RID: 2735
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Final_New_IEnumerator_0;

		// Token: 0x04000AB0 RID: 2736
		private static readonly IntPtr NativeMethodInfoPtr_IgnorePrecache_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000AB1 RID: 2737
		private static readonly IntPtr NativeMethodInfoPtr_downloadBroadcastContent_Protected_Virtual_New_IEnumerator_0;

		// Token: 0x04000AB2 RID: 2738
		private static readonly IntPtr NativeMethodInfoPtr_downloadBundle_Private_IEnumerator_String_Nullable_1_Hash128_String_AssetBundle_0;

		// Token: 0x04000AB3 RID: 2739
		private static readonly IntPtr NativeMethodInfoPtr_attachBundle_Private_Void_String_Nullable_1_Hash128_AssetBundle_0;

		// Token: 0x04000AB4 RID: 2740
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000AB5 RID: 2741
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200027E RID: 638
		[ObfuscatedName("boardgames.src.broadcast.motd.BroadcastContentProvider+<Init>d__21")]
		public sealed class _Init_d__21 : global::Il2CppSystem.Object
		{
			// Token: 0x06001D6E RID: 7534 RVA: 0x0006BDF0 File Offset: 0x00069FF0
			// Note: this type is marked as 'beforefieldinit'.
			static _Init_d__21()
			{
				Il2CppClassPointerStore<BroadcastContentProvider._Init_d__21>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BroadcastContentProvider>.NativeClassPtr, "<Init>d__21");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BroadcastContentProvider._Init_d__21>.NativeClassPtr);
				BroadcastContentProvider._Init_d__21.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BroadcastContentProvider._Init_d__21>.NativeClassPtr, "<>1__state");
				BroadcastContentProvider._Init_d__21.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BroadcastContentProvider._Init_d__21>.NativeClassPtr, "<>2__current");
				BroadcastContentProvider._Init_d__21.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BroadcastContentProvider._Init_d__21>.NativeClassPtr, "<>4__this");
				BroadcastContentProvider._Init_d__21.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BroadcastContentProvider._Init_d__21>.NativeClassPtr, 100665876);
				BroadcastContentProvider._Init_d__21.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BroadcastContentProvider._Init_d__21>.NativeClassPtr, 100665877);
				BroadcastContentProvider._Init_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BroadcastContentProvider._Init_d__21>.NativeClassPtr, 100665878);
				BroadcastContentProvider._Init_d__21.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BroadcastContentProvider._Init_d__21>.NativeClassPtr, 100665879);
				BroadcastContentProvider._Init_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BroadcastContentProvider._Init_d__21>.NativeClassPtr, 100665880);
				BroadcastContentProvider._Init_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BroadcastContentProvider._Init_d__21>.NativeClassPtr, 100665881);
			}

			// Token: 0x06001D6F RID: 7535 RVA: 0x0006BED0 File Offset: 0x0006A0D0
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Init_d__21(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BroadcastContentProvider._Init_d__21>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BroadcastContentProvider._Init_d__21.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001D70 RID: 7536 RVA: 0x0006BF18 File Offset: 0x0006A118
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BroadcastContentProvider._Init_d__21.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D71 RID: 7537 RVA: 0x0006BF4C File Offset: 0x0006A14C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000043, XrefRangeEnd = 1000084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BroadcastContentProvider._Init_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170008C8 RID: 2248
			// (get) Token: 0x06001D72 RID: 7538 RVA: 0x0006BF88 File Offset: 0x0006A188
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BroadcastContentProvider._Init_d__21.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001D73 RID: 7539 RVA: 0x0006BFC8 File Offset: 0x0006A1C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000084, XrefRangeEnd = 1000089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BroadcastContentProvider._Init_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170008C9 RID: 2249
			// (get) Token: 0x06001D74 RID: 7540 RVA: 0x0006BFFC File Offset: 0x0006A1FC
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BroadcastContentProvider._Init_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001D75 RID: 7541 RVA: 0x0000FD0F File Offset: 0x0000DF0F
			public _Init_d__21(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008C5 RID: 2245
			// (get) Token: 0x06001D76 RID: 7542 RVA: 0x0006C03C File Offset: 0x0006A23C
			// (set) Token: 0x06001D77 RID: 7543 RVA: 0x0000FD18 File Offset: 0x0000DF18
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BroadcastContentProvider._Init_d__21.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BroadcastContentProvider._Init_d__21.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170008C6 RID: 2246
			// (get) Token: 0x06001D78 RID: 7544 RVA: 0x0006C064 File Offset: 0x0006A264
			// (set) Token: 0x06001D79 RID: 7545 RVA: 0x0000FD33 File Offset: 0x0000DF33
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BroadcastContentProvider._Init_d__21.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BroadcastContentProvider._Init_d__21.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008C7 RID: 2247
			// (get) Token: 0x06001D7A RID: 7546 RVA: 0x0006C094 File Offset: 0x0006A294
			// (set) Token: 0x06001D7B RID: 7547 RVA: 0x0000FD52 File Offset: 0x0000DF52
			public unsafe BroadcastContentProvider __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BroadcastContentProvider._Init_d__21.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BroadcastContentProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BroadcastContentProvider._Init_d__21.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040011EA RID: 4586
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040011EB RID: 4587
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040011EC RID: 4588
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040011ED RID: 4589
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040011EE RID: 4590
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040011EF RID: 4591
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040011F0 RID: 4592
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040011F1 RID: 4593
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040011F2 RID: 4594
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200027F RID: 639
		[ObfuscatedName("boardgames.src.broadcast.motd.BroadcastContentProvider+<downloadBroadcastContent>d__23")]
		public sealed class _downloadBroadcastContent_d__23 : global::Il2CppSystem.Object
		{
			// Token: 0x06001D7C RID: 7548 RVA: 0x0006C0C4 File Offset: 0x0006A2C4
			// Note: this type is marked as 'beforefieldinit'.
			static _downloadBroadcastContent_d__23()
			{
				Il2CppClassPointerStore<BroadcastContentProvider._downloadBroadcastContent_d__23>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BroadcastContentProvider>.NativeClassPtr, "<downloadBroadcastContent>d__23");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BroadcastContentProvider._downloadBroadcastContent_d__23>.NativeClassPtr);
				BroadcastContentProvider._downloadBroadcastContent_d__23.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BroadcastContentProvider._downloadBroadcastContent_d__23>.NativeClassPtr, "<>1__state");
				BroadcastContentProvider._downloadBroadcastContent_d__23.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BroadcastContentProvider._downloadBroadcastContent_d__23>.NativeClassPtr, "<>2__current");
				BroadcastContentProvider._downloadBroadcastContent_d__23.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BroadcastContentProvider._downloadBroadcastContent_d__23>.NativeClassPtr, "<>4__this");
				BroadcastContentProvider._downloadBroadcastContent_d__23.NativeFieldInfoPtr__versionUrl_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BroadcastContentProvider._downloadBroadcastContent_d__23>.NativeClassPtr, "<versionUrl>5__2");
				BroadcastContentProvider._downloadBroadcastContent_d__23.NativeFieldInfoPtr__assetUrl_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BroadcastContentProvider._downloadBroadcastContent_d__23>.NativeClassPtr, "<assetUrl>5__3");
				BroadcastContentProvider._downloadBroadcastContent_d__23.NativeFieldInfoPtr__locUrl_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BroadcastContentProvider._downloadBroadcastContent_d__23>.NativeClassPtr, "<locUrl>5__4");
				BroadcastContentProvider._downloadBroadcastContent_d__23.NativeFieldInfoPtr__manifestRequest_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BroadcastContentProvider._downloadBroadcastContent_d__23>.NativeClassPtr, "<manifestRequest>5__5");
				BroadcastContentProvider._downloadBroadcastContent_d__23.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BroadcastContentProvider._downloadBroadcastContent_d__23>.NativeClassPtr, 100665882);
				BroadcastContentProvider._downloadBroadcastContent_d__23.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BroadcastContentProvider._downloadBroadcastContent_d__23>.NativeClassPtr, 100665883);
				BroadcastContentProvider._downloadBroadcastContent_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BroadcastContentProvider._downloadBroadcastContent_d__23>.NativeClassPtr, 100665884);
				BroadcastContentProvider._downloadBroadcastContent_d__23.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BroadcastContentProvider._downloadBroadcastContent_d__23>.NativeClassPtr, 100665885);
				BroadcastContentProvider._downloadBroadcastContent_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BroadcastContentProvider._downloadBroadcastContent_d__23>.NativeClassPtr, 100665886);
				BroadcastContentProvider._downloadBroadcastContent_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BroadcastContentProvider._downloadBroadcastContent_d__23>.NativeClassPtr, 100665887);
			}

			// Token: 0x06001D7D RID: 7549 RVA: 0x0006C1F4 File Offset: 0x0006A3F4
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _downloadBroadcastContent_d__23(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BroadcastContentProvider._downloadBroadcastContent_d__23>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BroadcastContentProvider._downloadBroadcastContent_d__23.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001D7E RID: 7550 RVA: 0x0006C23C File Offset: 0x0006A43C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BroadcastContentProvider._downloadBroadcastContent_d__23.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D7F RID: 7551 RVA: 0x0006C270 File Offset: 0x0006A470
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000089, XrefRangeEnd = 1000137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BroadcastContentProvider._downloadBroadcastContent_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170008D1 RID: 2257
			// (get) Token: 0x06001D80 RID: 7552 RVA: 0x0006C2AC File Offset: 0x0006A4AC
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BroadcastContentProvider._downloadBroadcastContent_d__23.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001D81 RID: 7553 RVA: 0x0006C2EC File Offset: 0x0006A4EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000137, XrefRangeEnd = 1000142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BroadcastContentProvider._downloadBroadcastContent_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170008D2 RID: 2258
			// (get) Token: 0x06001D82 RID: 7554 RVA: 0x0006C320 File Offset: 0x0006A520
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BroadcastContentProvider._downloadBroadcastContent_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001D83 RID: 7555 RVA: 0x0000FD71 File Offset: 0x0000DF71
			public _downloadBroadcastContent_d__23(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008CA RID: 2250
			// (get) Token: 0x06001D84 RID: 7556 RVA: 0x0006C360 File Offset: 0x0006A560
			// (set) Token: 0x06001D85 RID: 7557 RVA: 0x0000FD7A File Offset: 0x0000DF7A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BroadcastContentProvider._downloadBroadcastContent_d__23.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BroadcastContentProvider._downloadBroadcastContent_d__23.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170008CB RID: 2251
			// (get) Token: 0x06001D86 RID: 7558 RVA: 0x0006C388 File Offset: 0x0006A588
			// (set) Token: 0x06001D87 RID: 7559 RVA: 0x0000FD95 File Offset: 0x0000DF95
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BroadcastContentProvider._downloadBroadcastContent_d__23.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BroadcastContentProvider._downloadBroadcastContent_d__23.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008CC RID: 2252
			// (get) Token: 0x06001D88 RID: 7560 RVA: 0x0006C3B8 File Offset: 0x0006A5B8
			// (set) Token: 0x06001D89 RID: 7561 RVA: 0x0000FDB4 File Offset: 0x0000DFB4
			public unsafe BroadcastContentProvider __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BroadcastContentProvider._downloadBroadcastContent_d__23.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BroadcastContentProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BroadcastContentProvider._downloadBroadcastContent_d__23.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008CD RID: 2253
			// (get) Token: 0x06001D8A RID: 7562 RVA: 0x0006C3E8 File Offset: 0x0006A5E8
			// (set) Token: 0x06001D8B RID: 7563 RVA: 0x0000FDD3 File Offset: 0x0000DFD3
			public unsafe string _versionUrl_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BroadcastContentProvider._downloadBroadcastContent_d__23.NativeFieldInfoPtr__versionUrl_5__2);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BroadcastContentProvider._downloadBroadcastContent_d__23.NativeFieldInfoPtr__versionUrl_5__2), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170008CE RID: 2254
			// (get) Token: 0x06001D8C RID: 7564 RVA: 0x0006C410 File Offset: 0x0006A610
			// (set) Token: 0x06001D8D RID: 7565 RVA: 0x0000FDF2 File Offset: 0x0000DFF2
			public unsafe string _assetUrl_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BroadcastContentProvider._downloadBroadcastContent_d__23.NativeFieldInfoPtr__assetUrl_5__3);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BroadcastContentProvider._downloadBroadcastContent_d__23.NativeFieldInfoPtr__assetUrl_5__3), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170008CF RID: 2255
			// (get) Token: 0x06001D8E RID: 7566 RVA: 0x0006C438 File Offset: 0x0006A638
			// (set) Token: 0x06001D8F RID: 7567 RVA: 0x0000FE11 File Offset: 0x0000E011
			public unsafe string _locUrl_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BroadcastContentProvider._downloadBroadcastContent_d__23.NativeFieldInfoPtr__locUrl_5__4);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BroadcastContentProvider._downloadBroadcastContent_d__23.NativeFieldInfoPtr__locUrl_5__4), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170008D0 RID: 2256
			// (get) Token: 0x06001D90 RID: 7568 RVA: 0x0006C460 File Offset: 0x0006A660
			// (set) Token: 0x06001D91 RID: 7569 RVA: 0x0000FE30 File Offset: 0x0000E030
			public unsafe UnityWebRequest _manifestRequest_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BroadcastContentProvider._downloadBroadcastContent_d__23.NativeFieldInfoPtr__manifestRequest_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BroadcastContentProvider._downloadBroadcastContent_d__23.NativeFieldInfoPtr__manifestRequest_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040011F3 RID: 4595
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040011F4 RID: 4596
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040011F5 RID: 4597
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040011F6 RID: 4598
			private static readonly IntPtr NativeFieldInfoPtr__versionUrl_5__2;

			// Token: 0x040011F7 RID: 4599
			private static readonly IntPtr NativeFieldInfoPtr__assetUrl_5__3;

			// Token: 0x040011F8 RID: 4600
			private static readonly IntPtr NativeFieldInfoPtr__locUrl_5__4;

			// Token: 0x040011F9 RID: 4601
			private static readonly IntPtr NativeFieldInfoPtr__manifestRequest_5__5;

			// Token: 0x040011FA RID: 4602
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040011FB RID: 4603
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040011FC RID: 4604
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040011FD RID: 4605
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040011FE RID: 4606
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040011FF RID: 4607
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000280 RID: 640
		[ObfuscatedName("boardgames.src.broadcast.motd.BroadcastContentProvider+<downloadBundle>d__24")]
		public sealed class _downloadBundle_d__24 : global::Il2CppSystem.Object
		{
			// Token: 0x06001D92 RID: 7570 RVA: 0x0006C490 File Offset: 0x0006A690
			// Note: this type is marked as 'beforefieldinit'.
			static _downloadBundle_d__24()
			{
				Il2CppClassPointerStore<BroadcastContentProvider._downloadBundle_d__24>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BroadcastContentProvider>.NativeClassPtr, "<downloadBundle>d__24");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BroadcastContentProvider._downloadBundle_d__24>.NativeClassPtr);
				BroadcastContentProvider._downloadBundle_d__24.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BroadcastContentProvider._downloadBundle_d__24>.NativeClassPtr, "<>1__state");
				BroadcastContentProvider._downloadBundle_d__24.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BroadcastContentProvider._downloadBundle_d__24>.NativeClassPtr, "<>2__current");
				BroadcastContentProvider._downloadBundle_d__24.NativeFieldInfoPtr_versionHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BroadcastContentProvider._downloadBundle_d__24>.NativeClassPtr, "versionHash");
				BroadcastContentProvider._downloadBundle_d__24.NativeFieldInfoPtr_url = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BroadcastContentProvider._downloadBundle_d__24>.NativeClassPtr, "url");
				BroadcastContentProvider._downloadBundle_d__24.NativeFieldInfoPtr_existingBundle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BroadcastContentProvider._downloadBundle_d__24>.NativeClassPtr, "existingBundle");
				BroadcastContentProvider._downloadBundle_d__24.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BroadcastContentProvider._downloadBundle_d__24>.NativeClassPtr, "<>4__this");
				BroadcastContentProvider._downloadBundle_d__24.NativeFieldInfoPtr__bundle_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BroadcastContentProvider._downloadBundle_d__24>.NativeClassPtr, "<bundle>5__2");
				BroadcastContentProvider._downloadBundle_d__24.NativeFieldInfoPtr__request_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BroadcastContentProvider._downloadBundle_d__24>.NativeClassPtr, "<request>5__3");
				BroadcastContentProvider._downloadBundle_d__24.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BroadcastContentProvider._downloadBundle_d__24>.NativeClassPtr, 100665888);
				BroadcastContentProvider._downloadBundle_d__24.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BroadcastContentProvider._downloadBundle_d__24>.NativeClassPtr, 100665889);
				BroadcastContentProvider._downloadBundle_d__24.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BroadcastContentProvider._downloadBundle_d__24>.NativeClassPtr, 100665890);
				BroadcastContentProvider._downloadBundle_d__24.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BroadcastContentProvider._downloadBundle_d__24>.NativeClassPtr, 100665891);
				BroadcastContentProvider._downloadBundle_d__24.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BroadcastContentProvider._downloadBundle_d__24>.NativeClassPtr, 100665892);
				BroadcastContentProvider._downloadBundle_d__24.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BroadcastContentProvider._downloadBundle_d__24>.NativeClassPtr, 100665893);
			}

			// Token: 0x06001D93 RID: 7571 RVA: 0x0006C5D4 File Offset: 0x0006A7D4
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _downloadBundle_d__24(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BroadcastContentProvider._downloadBundle_d__24>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BroadcastContentProvider._downloadBundle_d__24.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001D94 RID: 7572 RVA: 0x0006C61C File Offset: 0x0006A81C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BroadcastContentProvider._downloadBundle_d__24.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D95 RID: 7573 RVA: 0x0006C650 File Offset: 0x0006A850
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000142, XrefRangeEnd = 1000168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BroadcastContentProvider._downloadBundle_d__24.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170008DB RID: 2267
			// (get) Token: 0x06001D96 RID: 7574 RVA: 0x0006C68C File Offset: 0x0006A88C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BroadcastContentProvider._downloadBundle_d__24.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001D97 RID: 7575 RVA: 0x0006C6CC File Offset: 0x0006A8CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000168, XrefRangeEnd = 1000173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BroadcastContentProvider._downloadBundle_d__24.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170008DC RID: 2268
			// (get) Token: 0x06001D98 RID: 7576 RVA: 0x0006C700 File Offset: 0x0006A900
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BroadcastContentProvider._downloadBundle_d__24.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001D99 RID: 7577 RVA: 0x0000FE4F File Offset: 0x0000E04F
			public _downloadBundle_d__24(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008D3 RID: 2259
			// (get) Token: 0x06001D9A RID: 7578 RVA: 0x0006C740 File Offset: 0x0006A940
			// (set) Token: 0x06001D9B RID: 7579 RVA: 0x0000FE58 File Offset: 0x0000E058
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BroadcastContentProvider._downloadBundle_d__24.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BroadcastContentProvider._downloadBundle_d__24.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170008D4 RID: 2260
			// (get) Token: 0x06001D9C RID: 7580 RVA: 0x0006C768 File Offset: 0x0006A968
			// (set) Token: 0x06001D9D RID: 7581 RVA: 0x0000FE73 File Offset: 0x0000E073
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BroadcastContentProvider._downloadBundle_d__24.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BroadcastContentProvider._downloadBundle_d__24.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008D5 RID: 2261
			// (get) Token: 0x06001D9E RID: 7582 RVA: 0x0006C798 File Offset: 0x0006A998
			// (set) Token: 0x06001D9F RID: 7583 RVA: 0x0000FE92 File Offset: 0x0000E092
			public Nullable<Hash128> versionHash
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BroadcastContentProvider._downloadBundle_d__24.NativeFieldInfoPtr_versionHash);
					return new Nullable<Hash128>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<Hash128>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BroadcastContentProvider._downloadBundle_d__24.NativeFieldInfoPtr_versionHash), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<Hash128>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008D6 RID: 2262
			// (get) Token: 0x06001DA0 RID: 7584 RVA: 0x0006C7C8 File Offset: 0x0006A9C8
			// (set) Token: 0x06001DA1 RID: 7585 RVA: 0x0000FEC0 File Offset: 0x0000E0C0
			public unsafe string url
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BroadcastContentProvider._downloadBundle_d__24.NativeFieldInfoPtr_url);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BroadcastContentProvider._downloadBundle_d__24.NativeFieldInfoPtr_url), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170008D7 RID: 2263
			// (get) Token: 0x06001DA2 RID: 7586 RVA: 0x0006C7F0 File Offset: 0x0006A9F0
			// (set) Token: 0x06001DA3 RID: 7587 RVA: 0x0000FEDF File Offset: 0x0000E0DF
			public unsafe AssetBundle existingBundle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BroadcastContentProvider._downloadBundle_d__24.NativeFieldInfoPtr_existingBundle);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetBundle>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BroadcastContentProvider._downloadBundle_d__24.NativeFieldInfoPtr_existingBundle), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008D8 RID: 2264
			// (get) Token: 0x06001DA4 RID: 7588 RVA: 0x0006C820 File Offset: 0x0006AA20
			// (set) Token: 0x06001DA5 RID: 7589 RVA: 0x0000FEFE File Offset: 0x0000E0FE
			public unsafe BroadcastContentProvider __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BroadcastContentProvider._downloadBundle_d__24.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BroadcastContentProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BroadcastContentProvider._downloadBundle_d__24.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008D9 RID: 2265
			// (get) Token: 0x06001DA6 RID: 7590 RVA: 0x0006C850 File Offset: 0x0006AA50
			// (set) Token: 0x06001DA7 RID: 7591 RVA: 0x0000FF1D File Offset: 0x0000E11D
			public unsafe AssetBundle _bundle_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BroadcastContentProvider._downloadBundle_d__24.NativeFieldInfoPtr__bundle_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetBundle>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BroadcastContentProvider._downloadBundle_d__24.NativeFieldInfoPtr__bundle_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008DA RID: 2266
			// (get) Token: 0x06001DA8 RID: 7592 RVA: 0x0006C880 File Offset: 0x0006AA80
			// (set) Token: 0x06001DA9 RID: 7593 RVA: 0x0000FF3C File Offset: 0x0000E13C
			public unsafe UnityWebRequest _request_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BroadcastContentProvider._downloadBundle_d__24.NativeFieldInfoPtr__request_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BroadcastContentProvider._downloadBundle_d__24.NativeFieldInfoPtr__request_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001200 RID: 4608
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001201 RID: 4609
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001202 RID: 4610
			private static readonly IntPtr NativeFieldInfoPtr_versionHash;

			// Token: 0x04001203 RID: 4611
			private static readonly IntPtr NativeFieldInfoPtr_url;

			// Token: 0x04001204 RID: 4612
			private static readonly IntPtr NativeFieldInfoPtr_existingBundle;

			// Token: 0x04001205 RID: 4613
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001206 RID: 4614
			private static readonly IntPtr NativeFieldInfoPtr__bundle_5__2;

			// Token: 0x04001207 RID: 4615
			private static readonly IntPtr NativeFieldInfoPtr__request_5__3;

			// Token: 0x04001208 RID: 4616
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001209 RID: 4617
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400120A RID: 4618
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400120B RID: 4619
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400120C RID: 4620
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400120D RID: 4621
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
