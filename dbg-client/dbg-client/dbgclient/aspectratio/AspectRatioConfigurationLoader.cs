using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceLocations;

namespace dbgclient.aspectratio
{
	// Token: 0x020000DE RID: 222
	public class AspectRatioConfigurationLoader : MonoBehaviour
	{
		// Token: 0x0600097B RID: 2427 RVA: 0x0003B6D0 File Offset: 0x000398D0
		// Note: this type is marked as 'beforefieldinit'.
		static AspectRatioConfigurationLoader()
		{
			Il2CppClassPointerStore<AspectRatioConfigurationLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.aspectratio", "AspectRatioConfigurationLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AspectRatioConfigurationLoader>.NativeClassPtr);
			AspectRatioConfigurationLoader.NativeFieldInfoPtr__Version_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AspectRatioConfigurationLoader>.NativeClassPtr, "<Version>k__BackingField");
			AspectRatioConfigurationLoader.NativeFieldInfoPtr__AspectRatioConfig_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AspectRatioConfigurationLoader>.NativeClassPtr, "<AspectRatioConfig>k__BackingField");
			AspectRatioConfigurationLoader.NativeFieldInfoPtr__addressableLabels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AspectRatioConfigurationLoader>.NativeClassPtr, "_addressableLabels");
			AspectRatioConfigurationLoader.NativeFieldInfoPtr__locationsHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AspectRatioConfigurationLoader>.NativeClassPtr, "_locationsHandle");
			AspectRatioConfigurationLoader.NativeFieldInfoPtr__loadHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AspectRatioConfigurationLoader>.NativeClassPtr, "_loadHandle");
			AspectRatioConfigurationLoader.NativeFieldInfoPtr__cachedPlatform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AspectRatioConfigurationLoader>.NativeClassPtr, "_cachedPlatform");
			AspectRatioConfigurationLoader.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioConfigurationLoader>.NativeClassPtr, 100664676);
			AspectRatioConfigurationLoader.NativeMethodInfoPtr_set_Version_Private_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioConfigurationLoader>.NativeClassPtr, 100664677);
			AspectRatioConfigurationLoader.NativeMethodInfoPtr_get_AspectRatioConfig_Public_get_AspectRatioConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioConfigurationLoader>.NativeClassPtr, 100664678);
			AspectRatioConfigurationLoader.NativeMethodInfoPtr_set_AspectRatioConfig_Private_set_Void_AspectRatioConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioConfigurationLoader>.NativeClassPtr, 100664679);
			AspectRatioConfigurationLoader.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioConfigurationLoader>.NativeClassPtr, 100664680);
			AspectRatioConfigurationLoader.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioConfigurationLoader>.NativeClassPtr, 100664681);
			AspectRatioConfigurationLoader.NativeMethodInfoPtr_Load_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioConfigurationLoader>.NativeClassPtr, 100664682);
			AspectRatioConfigurationLoader.NativeMethodInfoPtr_TryLoadConfigLocation_Private_IEnumerator_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioConfigurationLoader>.NativeClassPtr, 100664683);
			AspectRatioConfigurationLoader.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioConfigurationLoader>.NativeClassPtr, 100664684);
			AspectRatioConfigurationLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioConfigurationLoader>.NativeClassPtr, 100664685);
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x0600097C RID: 2428 RVA: 0x0003B840 File Offset: 0x00039A40
		// (set) Token: 0x0600097D RID: 2429 RVA: 0x0003B87C File Offset: 0x00039A7C
		public unsafe virtual ulong Version
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AspectRatioConfigurationLoader.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AspectRatioConfigurationLoader.NativeMethodInfoPtr_set_Version_Private_set_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x0600097E RID: 2430 RVA: 0x0003B8BC File Offset: 0x00039ABC
		// (set) Token: 0x0600097F RID: 2431 RVA: 0x0003B8FC File Offset: 0x00039AFC
		public unsafe AspectRatioConfiguration AspectRatioConfig
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AspectRatioConfigurationLoader.NativeMethodInfoPtr_get_AspectRatioConfig_Public_get_AspectRatioConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AspectRatioConfiguration>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AspectRatioConfigurationLoader.NativeMethodInfoPtr_set_AspectRatioConfig_Private_set_Void_AspectRatioConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000980 RID: 2432 RVA: 0x0003B940 File Offset: 0x00039B40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506018, XrefRangeEnd = 506025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AspectRatioConfigurationLoader.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000981 RID: 2433 RVA: 0x0003B974 File Offset: 0x00039B74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506025, XrefRangeEnd = 506033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AspectRatioConfigurationLoader.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x0003B9A8 File Offset: 0x00039BA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506033, XrefRangeEnd = 506038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Load()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AspectRatioConfigurationLoader.NativeMethodInfoPtr_Load_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000983 RID: 2435 RVA: 0x0003B9E8 File Offset: 0x00039BE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 506044, RefRangeEnd = 506045, XrefRangeStart = 506038, XrefRangeEnd = 506044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator TryLoadConfigLocation(IEnumerable<string> labels)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(labels);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AspectRatioConfigurationLoader.NativeMethodInfoPtr_TryLoadConfigLocation_Private_IEnumerator_IEnumerable_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06000984 RID: 2436 RVA: 0x0003BA38 File Offset: 0x00039C38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506045, XrefRangeEnd = 506055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AspectRatioConfigurationLoader.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x0003BA6C File Offset: 0x00039C6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506055, XrefRangeEnd = 506072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AspectRatioConfigurationLoader()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AspectRatioConfigurationLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AspectRatioConfigurationLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000986 RID: 2438 RVA: 0x000067DA File Offset: 0x000049DA
		public AspectRatioConfigurationLoader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06000987 RID: 2439 RVA: 0x0003BAA8 File Offset: 0x00039CA8
		// (set) Token: 0x06000988 RID: 2440 RVA: 0x000067E3 File Offset: 0x000049E3
		public unsafe ulong _Version_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioConfigurationLoader.NativeFieldInfoPtr__Version_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioConfigurationLoader.NativeFieldInfoPtr__Version_k__BackingField)) = value;
			}
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x06000989 RID: 2441 RVA: 0x0003BAD0 File Offset: 0x00039CD0
		// (set) Token: 0x0600098A RID: 2442 RVA: 0x000067FE File Offset: 0x000049FE
		public unsafe AspectRatioConfiguration _AspectRatioConfig_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioConfigurationLoader.NativeFieldInfoPtr__AspectRatioConfig_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AspectRatioConfiguration>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioConfigurationLoader.NativeFieldInfoPtr__AspectRatioConfig_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x0600098B RID: 2443 RVA: 0x0003BB00 File Offset: 0x00039D00
		// (set) Token: 0x0600098C RID: 2444 RVA: 0x0000681D File Offset: 0x00004A1D
		public unsafe List<string> _addressableLabels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioConfigurationLoader.NativeFieldInfoPtr__addressableLabels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioConfigurationLoader.NativeFieldInfoPtr__addressableLabels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x0600098D RID: 2445 RVA: 0x0003BB30 File Offset: 0x00039D30
		// (set) Token: 0x0600098E RID: 2446 RVA: 0x0000683C File Offset: 0x00004A3C
		public AsyncOperationHandle<IList<IResourceLocation>> _locationsHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioConfigurationLoader.NativeFieldInfoPtr__locationsHandle);
				return new AsyncOperationHandle<IList<IResourceLocation>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle<IList<IResourceLocation>>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioConfigurationLoader.NativeFieldInfoPtr__locationsHandle), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle<IList<IResourceLocation>>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x0600098F RID: 2447 RVA: 0x0003BB60 File Offset: 0x00039D60
		// (set) Token: 0x06000990 RID: 2448 RVA: 0x0000686A File Offset: 0x00004A6A
		public Nullable<AsyncOperationHandle<ScriptableObject>> _loadHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioConfigurationLoader.NativeFieldInfoPtr__loadHandle);
				return new Nullable<AsyncOperationHandle<ScriptableObject>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<AsyncOperationHandle<ScriptableObject>>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioConfigurationLoader.NativeFieldInfoPtr__loadHandle), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<AsyncOperationHandle<ScriptableObject>>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06000991 RID: 2449 RVA: 0x0003BB90 File Offset: 0x00039D90
		// (set) Token: 0x06000992 RID: 2450 RVA: 0x00006898 File Offset: 0x00004A98
		public unsafe uint _cachedPlatform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioConfigurationLoader.NativeFieldInfoPtr__cachedPlatform);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioConfigurationLoader.NativeFieldInfoPtr__cachedPlatform)) = value;
			}
		}

		// Token: 0x040005C3 RID: 1475
		private static readonly IntPtr NativeFieldInfoPtr__Version_k__BackingField;

		// Token: 0x040005C4 RID: 1476
		private static readonly IntPtr NativeFieldInfoPtr__AspectRatioConfig_k__BackingField;

		// Token: 0x040005C5 RID: 1477
		private static readonly IntPtr NativeFieldInfoPtr__addressableLabels;

		// Token: 0x040005C6 RID: 1478
		private static readonly IntPtr NativeFieldInfoPtr__locationsHandle;

		// Token: 0x040005C7 RID: 1479
		private static readonly IntPtr NativeFieldInfoPtr__loadHandle;

		// Token: 0x040005C8 RID: 1480
		private static readonly IntPtr NativeFieldInfoPtr__cachedPlatform;

		// Token: 0x040005C9 RID: 1481
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0;

		// Token: 0x040005CA RID: 1482
		private static readonly IntPtr NativeMethodInfoPtr_set_Version_Private_set_Void_UInt64_0;

		// Token: 0x040005CB RID: 1483
		private static readonly IntPtr NativeMethodInfoPtr_get_AspectRatioConfig_Public_get_AspectRatioConfiguration_0;

		// Token: 0x040005CC RID: 1484
		private static readonly IntPtr NativeMethodInfoPtr_set_AspectRatioConfig_Private_set_Void_AspectRatioConfiguration_0;

		// Token: 0x040005CD RID: 1485
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040005CE RID: 1486
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040005CF RID: 1487
		private static readonly IntPtr NativeMethodInfoPtr_Load_Private_IEnumerator_0;

		// Token: 0x040005D0 RID: 1488
		private static readonly IntPtr NativeMethodInfoPtr_TryLoadConfigLocation_Private_IEnumerator_IEnumerable_1_String_0;

		// Token: 0x040005D1 RID: 1489
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040005D2 RID: 1490
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200032F RID: 815
		[ObfuscatedName("dbgclient.aspectratio.AspectRatioConfigurationLoader+<Load>d__14")]
		public sealed class _Load_d__14 : global::Il2CppSystem.Object
		{
			// Token: 0x06002674 RID: 9844 RVA: 0x0009B890 File Offset: 0x00099A90
			// Note: this type is marked as 'beforefieldinit'.
			static _Load_d__14()
			{
				Il2CppClassPointerStore<AspectRatioConfigurationLoader._Load_d__14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AspectRatioConfigurationLoader>.NativeClassPtr, "<Load>d__14");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AspectRatioConfigurationLoader._Load_d__14>.NativeClassPtr);
				AspectRatioConfigurationLoader._Load_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AspectRatioConfigurationLoader._Load_d__14>.NativeClassPtr, "<>1__state");
				AspectRatioConfigurationLoader._Load_d__14.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AspectRatioConfigurationLoader._Load_d__14>.NativeClassPtr, "<>2__current");
				AspectRatioConfigurationLoader._Load_d__14.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AspectRatioConfigurationLoader._Load_d__14>.NativeClassPtr, "<>4__this");
				AspectRatioConfigurationLoader._Load_d__14.NativeFieldInfoPtr__scene_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AspectRatioConfigurationLoader._Load_d__14>.NativeClassPtr, "<scene>5__2");
				AspectRatioConfigurationLoader._Load_d__14.NativeFieldInfoPtr__labels_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AspectRatioConfigurationLoader._Load_d__14>.NativeClassPtr, "<labels>5__3");
				AspectRatioConfigurationLoader._Load_d__14.NativeFieldInfoPtr__config_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AspectRatioConfigurationLoader._Load_d__14>.NativeClassPtr, "<config>5__4");
				AspectRatioConfigurationLoader._Load_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioConfigurationLoader._Load_d__14>.NativeClassPtr, 100664686);
				AspectRatioConfigurationLoader._Load_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioConfigurationLoader._Load_d__14>.NativeClassPtr, 100664687);
				AspectRatioConfigurationLoader._Load_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioConfigurationLoader._Load_d__14>.NativeClassPtr, 100664688);
				AspectRatioConfigurationLoader._Load_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioConfigurationLoader._Load_d__14>.NativeClassPtr, 100664689);
				AspectRatioConfigurationLoader._Load_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioConfigurationLoader._Load_d__14>.NativeClassPtr, 100664690);
				AspectRatioConfigurationLoader._Load_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioConfigurationLoader._Load_d__14>.NativeClassPtr, 100664691);
			}

			// Token: 0x06002675 RID: 9845 RVA: 0x0009B9AC File Offset: 0x00099BAC
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Load_d__14(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AspectRatioConfigurationLoader._Load_d__14>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AspectRatioConfigurationLoader._Load_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002676 RID: 9846 RVA: 0x0009B9F4 File Offset: 0x00099BF4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AspectRatioConfigurationLoader._Load_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002677 RID: 9847 RVA: 0x0009BA28 File Offset: 0x00099C28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 505913, XrefRangeEnd = 505993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AspectRatioConfigurationLoader._Load_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000AA8 RID: 2728
			// (get) Token: 0x06002678 RID: 9848 RVA: 0x0009BA64 File Offset: 0x00099C64
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AspectRatioConfigurationLoader._Load_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002679 RID: 9849 RVA: 0x0009BAA4 File Offset: 0x00099CA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 505993, XrefRangeEnd = 505998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AspectRatioConfigurationLoader._Load_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000AA9 RID: 2729
			// (get) Token: 0x0600267A RID: 9850 RVA: 0x0009BAD8 File Offset: 0x00099CD8
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AspectRatioConfigurationLoader._Load_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600267B RID: 9851 RVA: 0x00013EBD File Offset: 0x000120BD
			public _Load_d__14(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000AA2 RID: 2722
			// (get) Token: 0x0600267C RID: 9852 RVA: 0x0009BB18 File Offset: 0x00099D18
			// (set) Token: 0x0600267D RID: 9853 RVA: 0x00013EC6 File Offset: 0x000120C6
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioConfigurationLoader._Load_d__14.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioConfigurationLoader._Load_d__14.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000AA3 RID: 2723
			// (get) Token: 0x0600267E RID: 9854 RVA: 0x0009BB40 File Offset: 0x00099D40
			// (set) Token: 0x0600267F RID: 9855 RVA: 0x00013EE1 File Offset: 0x000120E1
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioConfigurationLoader._Load_d__14.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioConfigurationLoader._Load_d__14.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AA4 RID: 2724
			// (get) Token: 0x06002680 RID: 9856 RVA: 0x0009BB70 File Offset: 0x00099D70
			// (set) Token: 0x06002681 RID: 9857 RVA: 0x00013F00 File Offset: 0x00012100
			public unsafe AspectRatioConfigurationLoader __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioConfigurationLoader._Load_d__14.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AspectRatioConfigurationLoader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioConfigurationLoader._Load_d__14.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AA5 RID: 2725
			// (get) Token: 0x06002682 RID: 9858 RVA: 0x0009BBA0 File Offset: 0x00099DA0
			// (set) Token: 0x06002683 RID: 9859 RVA: 0x00013F1F File Offset: 0x0001211F
			public unsafe string _scene_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioConfigurationLoader._Load_d__14.NativeFieldInfoPtr__scene_5__2);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioConfigurationLoader._Load_d__14.NativeFieldInfoPtr__scene_5__2), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000AA6 RID: 2726
			// (get) Token: 0x06002684 RID: 9860 RVA: 0x0009BBC8 File Offset: 0x00099DC8
			// (set) Token: 0x06002685 RID: 9861 RVA: 0x00013F3E File Offset: 0x0001213E
			public unsafe List<string> _labels_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioConfigurationLoader._Load_d__14.NativeFieldInfoPtr__labels_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioConfigurationLoader._Load_d__14.NativeFieldInfoPtr__labels_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AA7 RID: 2727
			// (get) Token: 0x06002686 RID: 9862 RVA: 0x0009BBF8 File Offset: 0x00099DF8
			// (set) Token: 0x06002687 RID: 9863 RVA: 0x00013F5D File Offset: 0x0001215D
			public unsafe AspectRatioConfiguration _config_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioConfigurationLoader._Load_d__14.NativeFieldInfoPtr__config_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AspectRatioConfiguration>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioConfigurationLoader._Load_d__14.NativeFieldInfoPtr__config_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001819 RID: 6169
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400181A RID: 6170
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400181B RID: 6171
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400181C RID: 6172
			private static readonly IntPtr NativeFieldInfoPtr__scene_5__2;

			// Token: 0x0400181D RID: 6173
			private static readonly IntPtr NativeFieldInfoPtr__labels_5__3;

			// Token: 0x0400181E RID: 6174
			private static readonly IntPtr NativeFieldInfoPtr__config_5__4;

			// Token: 0x0400181F RID: 6175
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001820 RID: 6176
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001821 RID: 6177
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001822 RID: 6178
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001823 RID: 6179
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001824 RID: 6180
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000330 RID: 816
		[ObfuscatedName("dbgclient.aspectratio.AspectRatioConfigurationLoader+<TryLoadConfigLocation>d__15")]
		public sealed class _TryLoadConfigLocation_d__15 : global::Il2CppSystem.Object
		{
			// Token: 0x06002688 RID: 9864 RVA: 0x0009BC28 File Offset: 0x00099E28
			// Note: this type is marked as 'beforefieldinit'.
			static _TryLoadConfigLocation_d__15()
			{
				Il2CppClassPointerStore<AspectRatioConfigurationLoader._TryLoadConfigLocation_d__15>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AspectRatioConfigurationLoader>.NativeClassPtr, "<TryLoadConfigLocation>d__15");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AspectRatioConfigurationLoader._TryLoadConfigLocation_d__15>.NativeClassPtr);
				AspectRatioConfigurationLoader._TryLoadConfigLocation_d__15.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AspectRatioConfigurationLoader._TryLoadConfigLocation_d__15>.NativeClassPtr, "<>1__state");
				AspectRatioConfigurationLoader._TryLoadConfigLocation_d__15.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AspectRatioConfigurationLoader._TryLoadConfigLocation_d__15>.NativeClassPtr, "<>2__current");
				AspectRatioConfigurationLoader._TryLoadConfigLocation_d__15.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AspectRatioConfigurationLoader._TryLoadConfigLocation_d__15>.NativeClassPtr, "<>4__this");
				AspectRatioConfigurationLoader._TryLoadConfigLocation_d__15.NativeFieldInfoPtr_labels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AspectRatioConfigurationLoader._TryLoadConfigLocation_d__15>.NativeClassPtr, "labels");
				AspectRatioConfigurationLoader._TryLoadConfigLocation_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioConfigurationLoader._TryLoadConfigLocation_d__15>.NativeClassPtr, 100664692);
				AspectRatioConfigurationLoader._TryLoadConfigLocation_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioConfigurationLoader._TryLoadConfigLocation_d__15>.NativeClassPtr, 100664693);
				AspectRatioConfigurationLoader._TryLoadConfigLocation_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioConfigurationLoader._TryLoadConfigLocation_d__15>.NativeClassPtr, 100664694);
				AspectRatioConfigurationLoader._TryLoadConfigLocation_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioConfigurationLoader._TryLoadConfigLocation_d__15>.NativeClassPtr, 100664695);
				AspectRatioConfigurationLoader._TryLoadConfigLocation_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioConfigurationLoader._TryLoadConfigLocation_d__15>.NativeClassPtr, 100664696);
				AspectRatioConfigurationLoader._TryLoadConfigLocation_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioConfigurationLoader._TryLoadConfigLocation_d__15>.NativeClassPtr, 100664697);
			}

			// Token: 0x06002689 RID: 9865 RVA: 0x0009BD1C File Offset: 0x00099F1C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _TryLoadConfigLocation_d__15(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AspectRatioConfigurationLoader._TryLoadConfigLocation_d__15>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AspectRatioConfigurationLoader._TryLoadConfigLocation_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600268A RID: 9866 RVA: 0x0009BD64 File Offset: 0x00099F64
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AspectRatioConfigurationLoader._TryLoadConfigLocation_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600268B RID: 9867 RVA: 0x0009BD98 File Offset: 0x00099F98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 505998, XrefRangeEnd = 506013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AspectRatioConfigurationLoader._TryLoadConfigLocation_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000AAE RID: 2734
			// (get) Token: 0x0600268C RID: 9868 RVA: 0x0009BDD4 File Offset: 0x00099FD4
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AspectRatioConfigurationLoader._TryLoadConfigLocation_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600268D RID: 9869 RVA: 0x0009BE14 File Offset: 0x0009A014
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506013, XrefRangeEnd = 506018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AspectRatioConfigurationLoader._TryLoadConfigLocation_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000AAF RID: 2735
			// (get) Token: 0x0600268E RID: 9870 RVA: 0x0009BE48 File Offset: 0x0009A048
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AspectRatioConfigurationLoader._TryLoadConfigLocation_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600268F RID: 9871 RVA: 0x00013F7C File Offset: 0x0001217C
			public _TryLoadConfigLocation_d__15(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000AAA RID: 2730
			// (get) Token: 0x06002690 RID: 9872 RVA: 0x0009BE88 File Offset: 0x0009A088
			// (set) Token: 0x06002691 RID: 9873 RVA: 0x00013F85 File Offset: 0x00012185
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioConfigurationLoader._TryLoadConfigLocation_d__15.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioConfigurationLoader._TryLoadConfigLocation_d__15.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000AAB RID: 2731
			// (get) Token: 0x06002692 RID: 9874 RVA: 0x0009BEB0 File Offset: 0x0009A0B0
			// (set) Token: 0x06002693 RID: 9875 RVA: 0x00013FA0 File Offset: 0x000121A0
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioConfigurationLoader._TryLoadConfigLocation_d__15.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioConfigurationLoader._TryLoadConfigLocation_d__15.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AAC RID: 2732
			// (get) Token: 0x06002694 RID: 9876 RVA: 0x0009BEE0 File Offset: 0x0009A0E0
			// (set) Token: 0x06002695 RID: 9877 RVA: 0x00013FBF File Offset: 0x000121BF
			public unsafe AspectRatioConfigurationLoader __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioConfigurationLoader._TryLoadConfigLocation_d__15.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AspectRatioConfigurationLoader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioConfigurationLoader._TryLoadConfigLocation_d__15.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AAD RID: 2733
			// (get) Token: 0x06002696 RID: 9878 RVA: 0x0009BF10 File Offset: 0x0009A110
			// (set) Token: 0x06002697 RID: 9879 RVA: 0x00013FDE File Offset: 0x000121DE
			public unsafe IEnumerable<string> labels
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioConfigurationLoader._TryLoadConfigLocation_d__15.NativeFieldInfoPtr_labels);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioConfigurationLoader._TryLoadConfigLocation_d__15.NativeFieldInfoPtr_labels), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001825 RID: 6181
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001826 RID: 6182
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001827 RID: 6183
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001828 RID: 6184
			private static readonly IntPtr NativeFieldInfoPtr_labels;

			// Token: 0x04001829 RID: 6185
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400182A RID: 6186
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400182B RID: 6187
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400182C RID: 6188
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400182D RID: 6189
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400182E RID: 6190
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
