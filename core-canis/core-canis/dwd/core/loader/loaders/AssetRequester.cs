using System;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;
using UnityEngine.AddressableAssets.ResourceLocators;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace dwd.core.loader.loaders
{
	// Token: 0x02000196 RID: 406
	public sealed class AssetRequester : MonoBehaviour
	{
		// Token: 0x060016DC RID: 5852 RVA: 0x0006F608 File Offset: 0x0006D808
		// Note: this type is marked as 'beforefieldinit'.
		static AssetRequester()
		{
			Il2CppClassPointerStore<AssetRequester>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.loader.loaders", "AssetRequester");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetRequester>.NativeClassPtr);
			AssetRequester.NativeFieldInfoPtr_IsAssetDataMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetRequester>.NativeClassPtr, "IsAssetDataMode");
			AssetRequester.NativeFieldInfoPtr_AddressableLocations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetRequester>.NativeClassPtr, "AddressableLocations");
			AssetRequester.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetRequester>.NativeClassPtr, 100666794);
			AssetRequester.NativeMethodInfoPtr_IsAddressValid_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetRequester>.NativeClassPtr, 100666795);
			AssetRequester.NativeMethodInfoPtr_Get_Public_AssetRequest_1_T_AssetName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetRequester>.NativeClassPtr, 100666796);
			AssetRequester.NativeMethodInfoPtr_GetSprite_Public_SpriteRequest_AssetName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetRequester>.NativeClassPtr, 100666797);
			AssetRequester.NativeMethodInfoPtr_GetSpriteAtlas_Public_SpriteAtlasRequest_AssetName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetRequester>.NativeClassPtr, 100666798);
			AssetRequester.NativeMethodInfoPtr_GetSingleSprite_Public_SingleSpriteRequest_AssetName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetRequester>.NativeClassPtr, 100666799);
			AssetRequester.NativeMethodInfoPtr_StopAllRequests_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetRequester>.NativeClassPtr, 100666800);
			AssetRequester.NativeMethodInfoPtr_Find_Public_Static_AssetRequester_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetRequester>.NativeClassPtr, 100666801);
			AssetRequester.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetRequester>.NativeClassPtr, 100666802);
			AssetRequester.NativeMethodInfoPtr__Start_b__2_0_Private_Void_AsyncOperationHandle_1_IResourceLocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetRequester>.NativeClassPtr, 100666803);
		}

		// Token: 0x060016DD RID: 5853 RVA: 0x0006F728 File Offset: 0x0006D928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 878489, XrefRangeEnd = 878502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetRequester.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016DE RID: 5854 RVA: 0x0006F75C File Offset: 0x0006D95C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 878506, RefRangeEnd = 878513, XrefRangeStart = 878502, XrefRangeEnd = 878506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAddressValid(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetRequester.NativeMethodInfoPtr_IsAddressValid_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060016DF RID: 5855 RVA: 0x0006F7AC File Offset: 0x0006D9AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 878518, RefRangeEnd = 878520, XrefRangeStart = 878513, XrefRangeEnd = 878518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssetRequest<T> Get<T>(AssetName assetName) where T : global::UnityEngine.Object
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(assetName));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetRequester.MethodInfoStoreGeneric_Get_Public_AssetRequest_1_T_AssetName_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssetRequest<T>>(intPtr3) : null;
			}
		}

		// Token: 0x060016E0 RID: 5856 RVA: 0x0006F804 File Offset: 0x0006DA04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 878520, XrefRangeEnd = 878526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpriteRequest GetSprite(AssetName assetName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(assetName));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetRequester.NativeMethodInfoPtr_GetSprite_Public_SpriteRequest_AssetName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SpriteRequest>(intPtr3) : null;
			}
		}

		// Token: 0x060016E1 RID: 5857 RVA: 0x0006F85C File Offset: 0x0006DA5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 878526, XrefRangeEnd = 878532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpriteAtlasRequest GetSpriteAtlas(AssetName assetName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(assetName));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetRequester.NativeMethodInfoPtr_GetSpriteAtlas_Public_SpriteAtlasRequest_AssetName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SpriteAtlasRequest>(intPtr3) : null;
			}
		}

		// Token: 0x060016E2 RID: 5858 RVA: 0x0006F8B4 File Offset: 0x0006DAB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 878532, XrefRangeEnd = 878538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SingleSpriteRequest GetSingleSprite(AssetName assetName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(assetName));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetRequester.NativeMethodInfoPtr_GetSingleSprite_Public_SingleSpriteRequest_AssetName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SingleSpriteRequest>(intPtr3) : null;
			}
		}

		// Token: 0x060016E3 RID: 5859 RVA: 0x0006F90C File Offset: 0x0006DB0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 878538, XrefRangeEnd = 878618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void StopAllRequests()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetRequester.NativeMethodInfoPtr_StopAllRequests_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016E4 RID: 5860 RVA: 0x0006F934 File Offset: 0x0006DB34
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 878621, RefRangeEnd = 878630, XrefRangeStart = 878618, XrefRangeEnd = 878621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AssetRequester Find()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetRequester.NativeMethodInfoPtr_Find_Public_Static_AssetRequester_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssetRequester>(intPtr3) : null;
		}

		// Token: 0x060016E5 RID: 5861 RVA: 0x0006F968 File Offset: 0x0006DB68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 878630, XrefRangeEnd = 878638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssetRequester()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetRequester>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetRequester.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016E6 RID: 5862 RVA: 0x0006F9A4 File Offset: 0x0006DBA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 878638, XrefRangeEnd = 878678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__2_0(AsyncOperationHandle<IResourceLocator> op)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(op));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetRequester.NativeMethodInfoPtr__Start_b__2_0_Private_Void_AsyncOperationHandle_1_IResourceLocator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060016E7 RID: 5863 RVA: 0x0000A06D File Offset: 0x0000826D
		public AssetRequester(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x060016E8 RID: 5864 RVA: 0x0006F9EC File Offset: 0x0006DBEC
		// (set) Token: 0x060016E9 RID: 5865 RVA: 0x0000A076 File Offset: 0x00008276
		public unsafe bool IsAssetDataMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetRequester.NativeFieldInfoPtr_IsAssetDataMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetRequester.NativeFieldInfoPtr_IsAssetDataMode)) = value;
			}
		}

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x060016EA RID: 5866 RVA: 0x0006FA14 File Offset: 0x0006DC14
		// (set) Token: 0x060016EB RID: 5867 RVA: 0x0000A091 File Offset: 0x00008291
		public unsafe HashSet<string> AddressableLocations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetRequester.NativeFieldInfoPtr_AddressableLocations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetRequester.NativeFieldInfoPtr_AddressableLocations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400102C RID: 4140
		private static readonly IntPtr NativeFieldInfoPtr_IsAssetDataMode;

		// Token: 0x0400102D RID: 4141
		private static readonly IntPtr NativeFieldInfoPtr_AddressableLocations;

		// Token: 0x0400102E RID: 4142
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x0400102F RID: 4143
		private static readonly IntPtr NativeMethodInfoPtr_IsAddressValid_Public_Boolean_String_0;

		// Token: 0x04001030 RID: 4144
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_AssetRequest_1_T_AssetName_0;

		// Token: 0x04001031 RID: 4145
		private static readonly IntPtr NativeMethodInfoPtr_GetSprite_Public_SpriteRequest_AssetName_0;

		// Token: 0x04001032 RID: 4146
		private static readonly IntPtr NativeMethodInfoPtr_GetSpriteAtlas_Public_SpriteAtlasRequest_AssetName_0;

		// Token: 0x04001033 RID: 4147
		private static readonly IntPtr NativeMethodInfoPtr_GetSingleSprite_Public_SingleSpriteRequest_AssetName_0;

		// Token: 0x04001034 RID: 4148
		private static readonly IntPtr NativeMethodInfoPtr_StopAllRequests_Internal_Static_Void_0;

		// Token: 0x04001035 RID: 4149
		private static readonly IntPtr NativeMethodInfoPtr_Find_Public_Static_AssetRequester_0;

		// Token: 0x04001036 RID: 4150
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001037 RID: 4151
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__2_0_Private_Void_AsyncOperationHandle_1_IResourceLocator_0;

		// Token: 0x02000329 RID: 809
		[ObfuscatedName("dwd.core.loader.loaders.AssetRequester+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x060024EE RID: 9454 RVA: 0x0009F748 File Offset: 0x0009D948
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<AssetRequester.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AssetRequester>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetRequester.__c>.NativeClassPtr);
				AssetRequester.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetRequester.__c>.NativeClassPtr, "<>9");
				AssetRequester.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetRequester.__c>.NativeClassPtr, "<>9__8_0");
				AssetRequester.__c.NativeFieldInfoPtr___9__8_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetRequester.__c>.NativeClassPtr, "<>9__8_1");
				AssetRequester.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetRequester.__c>.NativeClassPtr, 100666805);
				AssetRequester.__c.NativeMethodInfoPtr__StopAllRequests_b__8_0_Internal_Boolean_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetRequester.__c>.NativeClassPtr, 100666806);
				AssetRequester.__c.NativeMethodInfoPtr__StopAllRequests_b__8_1_Internal_Boolean_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetRequester.__c>.NativeClassPtr, 100666807);
			}

			// Token: 0x060024EF RID: 9455 RVA: 0x0009F7EC File Offset: 0x0009D9EC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetRequester.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetRequester.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060024F0 RID: 9456 RVA: 0x0009F828 File Offset: 0x0009DA28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 878484, XrefRangeEnd = 878487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _StopAllRequests_b__8_0(Command cmd)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetRequester.__c.NativeMethodInfoPtr__StopAllRequests_b__8_0_Internal_Boolean_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060024F1 RID: 9457 RVA: 0x0009F878 File Offset: 0x0009DA78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 878487, XrefRangeEnd = 878489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _StopAllRequests_b__8_1(Command cmd)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetRequester.__c.NativeMethodInfoPtr__StopAllRequests_b__8_1_Internal_Boolean_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060024F2 RID: 9458 RVA: 0x000109C2 File Offset: 0x0000EBC2
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A45 RID: 2629
			// (get) Token: 0x060024F3 RID: 9459 RVA: 0x0009F8C8 File Offset: 0x0009DAC8
			// (set) Token: 0x060024F4 RID: 9460 RVA: 0x000109CB File Offset: 0x0000EBCB
			public unsafe static AssetRequester.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AssetRequester.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetRequester.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AssetRequester.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A46 RID: 2630
			// (get) Token: 0x060024F5 RID: 9461 RVA: 0x0009F8F0 File Offset: 0x0009DAF0
			// (set) Token: 0x060024F6 RID: 9462 RVA: 0x000109DD File Offset: 0x0000EBDD
			public unsafe static Func<Command, bool> __9__8_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AssetRequester.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Command, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AssetRequester.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A47 RID: 2631
			// (get) Token: 0x060024F7 RID: 9463 RVA: 0x0009F918 File Offset: 0x0009DB18
			// (set) Token: 0x060024F8 RID: 9464 RVA: 0x000109EF File Offset: 0x0000EBEF
			public unsafe static Func<Command, bool> __9__8_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AssetRequester.__c.NativeFieldInfoPtr___9__8_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Command, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AssetRequester.__c.NativeFieldInfoPtr___9__8_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001921 RID: 6433
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001922 RID: 6434
			private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x04001923 RID: 6435
			private static readonly IntPtr NativeFieldInfoPtr___9__8_1;

			// Token: 0x04001924 RID: 6436
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001925 RID: 6437
			private static readonly IntPtr NativeMethodInfoPtr__StopAllRequests_b__8_0_Internal_Boolean_Command_0;

			// Token: 0x04001926 RID: 6438
			private static readonly IntPtr NativeMethodInfoPtr__StopAllRequests_b__8_1_Internal_Boolean_Command_0;
		}

		// Token: 0x0200032A RID: 810
		private sealed class MethodInfoStoreGeneric_Get_Public_AssetRequest_1_T_AssetName_0<T>
		{
			// Token: 0x04001927 RID: 6439
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AssetRequester.NativeMethodInfoPtr_Get_Public_AssetRequest_1_T_AssetName_0, Il2CppClassPointerStore<AssetRequester>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
