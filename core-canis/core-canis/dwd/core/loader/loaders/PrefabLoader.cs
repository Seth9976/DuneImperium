using System;
using dwd.core.commands;
using dwd.core.loader.caching;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace dwd.core.loader.loaders
{
	// Token: 0x0200019A RID: 410
	public sealed class PrefabLoader<T> : DefaultLoader where T : global::UnityEngine.Object
	{
		// Token: 0x06001715 RID: 5909 RVA: 0x000705CC File Offset: 0x0006E7CC
		// Note: this type is marked as 'beforefieldinit'.
		static PrefabLoader()
		{
			Il2CppClassPointerStore<PrefabLoader<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.loader.loaders", "PrefabLoader`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrefabLoader<T>>.NativeClassPtr);
			PrefabLoader<T>.NativeFieldInfoPtr_stateChangedCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabLoader<T>>.NativeClassPtr, "stateChangedCallback");
			PrefabLoader<T>.NativeFieldInfoPtr_transfrom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabLoader<T>>.NativeClassPtr, "transfrom");
			PrefabLoader<T>.NativeFieldInfoPtr_worldSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabLoader<T>>.NativeClassPtr, "worldSpace");
			PrefabLoader<T>.NativeFieldInfoPtr_refTracker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabLoader<T>>.NativeClassPtr, "refTracker");
			PrefabLoader<T>.NativeFieldInfoPtr_load = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabLoader<T>>.NativeClassPtr, "load");
			PrefabLoader<T>.NativeFieldInfoPtr_assetReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabLoader<T>>.NativeClassPtr, "assetReference");
			PrefabLoader<T>.NativeFieldInfoPtr_previousAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabLoader<T>>.NativeClassPtr, "previousAsset");
			PrefabLoader<T>.NativeFieldInfoPtr_previousState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabLoader<T>>.NativeClassPtr, "previousState");
			PrefabLoader<T>.NativeFieldInfoPtr__Asset_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabLoader<T>>.NativeClassPtr, "<Asset>k__BackingField");
			PrefabLoader<T>.NativeFieldInfoPtr__State_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabLoader<T>>.NativeClassPtr, "<State>k__BackingField");
			PrefabLoader<T>.NativeMethodInfoPtr_get_Asset_Public_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabLoader<T>>.NativeClassPtr, 100666851);
			PrefabLoader<T>.NativeMethodInfoPtr_set_Asset_Private_set_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabLoader<T>>.NativeClassPtr, 100666852);
			PrefabLoader<T>.NativeMethodInfoPtr_get_State_Private_get_States_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabLoader<T>>.NativeClassPtr, 100666853);
			PrefabLoader<T>.NativeMethodInfoPtr_set_State_Private_set_Void_States_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabLoader<T>>.NativeClassPtr, 100666854);
			PrefabLoader<T>.NativeMethodInfoPtr__ctor_Public_Void_Transform_Boolean_Action_IReferenceTracker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabLoader<T>>.NativeClassPtr, 100666855);
			PrefabLoader<T>.NativeMethodInfoPtr_LoadAsset_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabLoader<T>>.NativeClassPtr, 100666856);
			PrefabLoader<T>.NativeMethodInfoPtr_Load_Public_Virtual_Void_AssetName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabLoader<T>>.NativeClassPtr, 100666857);
			PrefabLoader<T>.NativeMethodInfoPtr_LoadAndWait_Public_Virtual_IEnumerator_AssetName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabLoader<T>>.NativeClassPtr, 100666858);
			PrefabLoader<T>.NativeMethodInfoPtr_AssignAsset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabLoader<T>>.NativeClassPtr, 100666859);
			PrefabLoader<T>.NativeMethodInfoPtr_loadAsset_Private_IEnumerator_AssetName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabLoader<T>>.NativeClassPtr, 100666860);
			PrefabLoader<T>.NativeMethodInfoPtr_signalChange_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabLoader<T>>.NativeClassPtr, 100666861);
		}

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x06001716 RID: 5910 RVA: 0x000707DC File Offset: 0x0006E9DC
		// (set) Token: 0x06001717 RID: 5911 RVA: 0x00070818 File Offset: 0x0006EA18
		public unsafe T Asset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabLoader<T>.NativeMethodInfoPtr_get_Asset_Public_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = value;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref value;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(PrefabLoader<T>.NativeMethodInfoPtr_set_Asset_Private_set_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}
		}

		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x06001718 RID: 5912 RVA: 0x00070890 File Offset: 0x0006EA90
		// (set) Token: 0x06001719 RID: 5913 RVA: 0x000708CC File Offset: 0x0006EACC
		public unsafe DefaultLoader.States State
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabLoader<T>.NativeMethodInfoPtr_get_State_Private_get_States_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 337738, RefRangeEnd = 337747, XrefRangeStart = 337738, XrefRangeEnd = 337747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabLoader<T>.NativeMethodInfoPtr_set_State_Private_set_Void_States_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600171A RID: 5914 RVA: 0x0007090C File Offset: 0x0006EB0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 878869, RefRangeEnd = 878871, XrefRangeStart = 878865, XrefRangeEnd = 878869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PrefabLoader(Transform transform = null, bool worldSpace = false, Action stateChangedCallback = null, IReferenceTracker refTracker = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrefabLoader<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref worldSpace;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stateChangedCallback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(refTracker);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabLoader<T>.NativeMethodInfoPtr__ctor_Public_Void_Transform_Boolean_Action_IReferenceTracker_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600171B RID: 5915 RVA: 0x0007098C File Offset: 0x0006EB8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 878872, RefRangeEnd = 878873, XrefRangeStart = 878871, XrefRangeEnd = 878872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadAsset(string assetName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assetName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabLoader<T>.NativeMethodInfoPtr_LoadAsset_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600171C RID: 5916 RVA: 0x000709D0 File Offset: 0x0006EBD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 878873, XrefRangeEnd = 878892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(AssetName assetName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(assetName));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabLoader<T>.NativeMethodInfoPtr_Load_Public_Virtual_Void_AssetName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600171D RID: 5917 RVA: 0x00070A18 File Offset: 0x0006EC18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 878892, XrefRangeEnd = 878897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator LoadAndWait(AssetName assetName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(assetName));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabLoader<T>.NativeMethodInfoPtr_LoadAndWait_Public_Virtual_IEnumerator_AssetName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x0600171E RID: 5918 RVA: 0x00070A70 File Offset: 0x0006EC70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 878926, RefRangeEnd = 878927, XrefRangeStart = 878897, XrefRangeEnd = 878926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignAsset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabLoader<T>.NativeMethodInfoPtr_AssignAsset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600171F RID: 5919 RVA: 0x00070AA4 File Offset: 0x0006ECA4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 878756, RefRangeEnd = 878758, XrefRangeStart = 878756, XrefRangeEnd = 878758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator loadAsset(AssetName assetName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(assetName));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabLoader<T>.NativeMethodInfoPtr_loadAsset_Private_IEnumerator_AssetName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06001720 RID: 5920 RVA: 0x00070AFC File Offset: 0x0006ECFC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 878937, RefRangeEnd = 878939, XrefRangeStart = 878927, XrefRangeEnd = 878937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void signalChange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabLoader<T>.NativeMethodInfoPtr_signalChange_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001721 RID: 5921 RVA: 0x0000A1A3 File Offset: 0x000083A3
		public PrefabLoader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x06001722 RID: 5922 RVA: 0x00070B30 File Offset: 0x0006ED30
		// (set) Token: 0x06001723 RID: 5923 RVA: 0x0000A1AC File Offset: 0x000083AC
		public unsafe Action stateChangedCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabLoader<T>.NativeFieldInfoPtr_stateChangedCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabLoader<T>.NativeFieldInfoPtr_stateChangedCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x06001724 RID: 5924 RVA: 0x00070B60 File Offset: 0x0006ED60
		// (set) Token: 0x06001725 RID: 5925 RVA: 0x0000A1CB File Offset: 0x000083CB
		public unsafe Transform transfrom
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabLoader<T>.NativeFieldInfoPtr_transfrom);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabLoader<T>.NativeFieldInfoPtr_transfrom), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x06001726 RID: 5926 RVA: 0x00070B90 File Offset: 0x0006ED90
		// (set) Token: 0x06001727 RID: 5927 RVA: 0x0000A1EA File Offset: 0x000083EA
		public unsafe bool worldSpace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabLoader<T>.NativeFieldInfoPtr_worldSpace);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabLoader<T>.NativeFieldInfoPtr_worldSpace)) = value;
			}
		}

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x06001728 RID: 5928 RVA: 0x00070BB8 File Offset: 0x0006EDB8
		// (set) Token: 0x06001729 RID: 5929 RVA: 0x0000A205 File Offset: 0x00008405
		public unsafe IReferenceTracker refTracker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabLoader<T>.NativeFieldInfoPtr_refTracker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReferenceTracker>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabLoader<T>.NativeFieldInfoPtr_refTracker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x0600172A RID: 5930 RVA: 0x00070BE8 File Offset: 0x0006EDE8
		// (set) Token: 0x0600172B RID: 5931 RVA: 0x0000A224 File Offset: 0x00008424
		public unsafe InterruptableCommand load
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabLoader<T>.NativeFieldInfoPtr_load);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InterruptableCommand>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabLoader<T>.NativeFieldInfoPtr_load), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x0600172C RID: 5932 RVA: 0x00070C18 File Offset: 0x0006EE18
		// (set) Token: 0x0600172D RID: 5933 RVA: 0x0000A243 File Offset: 0x00008443
		public unsafe IAssetReference<GameObject> assetReference
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabLoader<T>.NativeFieldInfoPtr_assetReference);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAssetReference<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabLoader<T>.NativeFieldInfoPtr_assetReference), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x0600172E RID: 5934 RVA: 0x00070C48 File Offset: 0x0006EE48
		// (set) Token: 0x0600172F RID: 5935 RVA: 0x00070C70 File Offset: 0x0006EE70
		public unsafe T previousAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabLoader<T>.NativeFieldInfoPtr_previousAsset);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabLoader<T>.NativeFieldInfoPtr_previousAsset);
				Type typeFromHandle = typeof(T);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						IntPtr intPtr4;
						IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
						if (intPtr3 != 0)
						{
							intPtr4 = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								IntPtr intPtr5 = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
								return;
							}
						}
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x06001730 RID: 5936 RVA: 0x00070D18 File Offset: 0x0006EF18
		// (set) Token: 0x06001731 RID: 5937 RVA: 0x0000A262 File Offset: 0x00008462
		public unsafe DefaultLoader.States previousState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabLoader<T>.NativeFieldInfoPtr_previousState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabLoader<T>.NativeFieldInfoPtr_previousState)) = value;
			}
		}

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x06001732 RID: 5938 RVA: 0x00070D40 File Offset: 0x0006EF40
		// (set) Token: 0x06001733 RID: 5939 RVA: 0x00070D68 File Offset: 0x0006EF68
		public unsafe T _Asset_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabLoader<T>.NativeFieldInfoPtr__Asset_k__BackingField);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabLoader<T>.NativeFieldInfoPtr__Asset_k__BackingField);
				Type typeFromHandle = typeof(T);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						IntPtr intPtr4;
						IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
						if (intPtr3 != 0)
						{
							intPtr4 = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								IntPtr intPtr5 = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
								return;
							}
						}
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x06001734 RID: 5940 RVA: 0x00070E10 File Offset: 0x0006F010
		// (set) Token: 0x06001735 RID: 5941 RVA: 0x0000A27D File Offset: 0x0000847D
		public unsafe DefaultLoader.States _State_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabLoader<T>.NativeFieldInfoPtr__State_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabLoader<T>.NativeFieldInfoPtr__State_k__BackingField)) = value;
			}
		}

		// Token: 0x04001053 RID: 4179
		private static readonly IntPtr NativeFieldInfoPtr_stateChangedCallback;

		// Token: 0x04001054 RID: 4180
		private static readonly IntPtr NativeFieldInfoPtr_transfrom;

		// Token: 0x04001055 RID: 4181
		private static readonly IntPtr NativeFieldInfoPtr_worldSpace;

		// Token: 0x04001056 RID: 4182
		private static readonly IntPtr NativeFieldInfoPtr_refTracker;

		// Token: 0x04001057 RID: 4183
		private static readonly IntPtr NativeFieldInfoPtr_load;

		// Token: 0x04001058 RID: 4184
		private static readonly IntPtr NativeFieldInfoPtr_assetReference;

		// Token: 0x04001059 RID: 4185
		private static readonly IntPtr NativeFieldInfoPtr_previousAsset;

		// Token: 0x0400105A RID: 4186
		private static readonly IntPtr NativeFieldInfoPtr_previousState;

		// Token: 0x0400105B RID: 4187
		private static readonly IntPtr NativeFieldInfoPtr__Asset_k__BackingField;

		// Token: 0x0400105C RID: 4188
		private static readonly IntPtr NativeFieldInfoPtr__State_k__BackingField;

		// Token: 0x0400105D RID: 4189
		private static readonly IntPtr NativeMethodInfoPtr_get_Asset_Public_get_T_0;

		// Token: 0x0400105E RID: 4190
		private static readonly IntPtr NativeMethodInfoPtr_set_Asset_Private_set_Void_T_0;

		// Token: 0x0400105F RID: 4191
		private static readonly IntPtr NativeMethodInfoPtr_get_State_Private_get_States_0;

		// Token: 0x04001060 RID: 4192
		private static readonly IntPtr NativeMethodInfoPtr_set_State_Private_set_Void_States_0;

		// Token: 0x04001061 RID: 4193
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Transform_Boolean_Action_IReferenceTracker_0;

		// Token: 0x04001062 RID: 4194
		private static readonly IntPtr NativeMethodInfoPtr_LoadAsset_Public_Void_String_0;

		// Token: 0x04001063 RID: 4195
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_AssetName_0;

		// Token: 0x04001064 RID: 4196
		private static readonly IntPtr NativeMethodInfoPtr_LoadAndWait_Public_Virtual_IEnumerator_AssetName_0;

		// Token: 0x04001065 RID: 4197
		private static readonly IntPtr NativeMethodInfoPtr_AssignAsset_Private_Void_0;

		// Token: 0x04001066 RID: 4198
		private static readonly IntPtr NativeMethodInfoPtr_loadAsset_Private_IEnumerator_AssetName_0;

		// Token: 0x04001067 RID: 4199
		private static readonly IntPtr NativeMethodInfoPtr_signalChange_Private_Void_0;

		// Token: 0x02000331 RID: 817
		[ObfuscatedName("dwd.core.loader.loaders.PrefabLoader`1+<LoadAndWait>d__19")]
		public sealed class _LoadAndWait_d__19 : global::Il2CppSystem.Object
		{
			// Token: 0x06002540 RID: 9536 RVA: 0x000A0764 File Offset: 0x0009E964
			// Note: this type is marked as 'beforefieldinit'.
			static _LoadAndWait_d__19()
			{
				Il2CppClassPointerStore<PrefabLoader<T>._LoadAndWait_d__19>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PrefabLoader<T>>.NativeClassPtr, "<LoadAndWait>d__19"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrefabLoader<T>._LoadAndWait_d__19>.NativeClassPtr);
				PrefabLoader<T>._LoadAndWait_d__19.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabLoader<T>._LoadAndWait_d__19>.NativeClassPtr, "<>1__state");
				PrefabLoader<T>._LoadAndWait_d__19.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabLoader<T>._LoadAndWait_d__19>.NativeClassPtr, "<>2__current");
				PrefabLoader<T>._LoadAndWait_d__19.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabLoader<T>._LoadAndWait_d__19>.NativeClassPtr, "<>4__this");
				PrefabLoader<T>._LoadAndWait_d__19.NativeFieldInfoPtr_assetName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabLoader<T>._LoadAndWait_d__19>.NativeClassPtr, "assetName");
				PrefabLoader<T>._LoadAndWait_d__19.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabLoader<T>._LoadAndWait_d__19>.NativeClassPtr, 100666862);
				PrefabLoader<T>._LoadAndWait_d__19.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabLoader<T>._LoadAndWait_d__19>.NativeClassPtr, 100666863);
				PrefabLoader<T>._LoadAndWait_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabLoader<T>._LoadAndWait_d__19>.NativeClassPtr, 100666864);
				PrefabLoader<T>._LoadAndWait_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabLoader<T>._LoadAndWait_d__19>.NativeClassPtr, 100666865);
				PrefabLoader<T>._LoadAndWait_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabLoader<T>._LoadAndWait_d__19>.NativeClassPtr, 100666866);
				PrefabLoader<T>._LoadAndWait_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabLoader<T>._LoadAndWait_d__19>.NativeClassPtr, 100666867);
			}

			// Token: 0x06002541 RID: 9537 RVA: 0x000A0894 File Offset: 0x0009EA94
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _LoadAndWait_d__19(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrefabLoader<T>._LoadAndWait_d__19>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabLoader<T>._LoadAndWait_d__19.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002542 RID: 9538 RVA: 0x000A08DC File Offset: 0x0009EADC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabLoader<T>._LoadAndWait_d__19.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002543 RID: 9539 RVA: 0x000A0910 File Offset: 0x0009EB10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 878828, XrefRangeEnd = 878845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabLoader<T>._LoadAndWait_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000A67 RID: 2663
			// (get) Token: 0x06002544 RID: 9540 RVA: 0x000A094C File Offset: 0x0009EB4C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabLoader<T>._LoadAndWait_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002545 RID: 9541 RVA: 0x000A098C File Offset: 0x0009EB8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabLoader<T>._LoadAndWait_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000A68 RID: 2664
			// (get) Token: 0x06002546 RID: 9542 RVA: 0x000A09C0 File Offset: 0x0009EBC0
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabLoader<T>._LoadAndWait_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002547 RID: 9543 RVA: 0x00010C80 File Offset: 0x0000EE80
			public _LoadAndWait_d__19(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A63 RID: 2659
			// (get) Token: 0x06002548 RID: 9544 RVA: 0x000A0A00 File Offset: 0x0009EC00
			// (set) Token: 0x06002549 RID: 9545 RVA: 0x00010C89 File Offset: 0x0000EE89
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabLoader<T>._LoadAndWait_d__19.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabLoader<T>._LoadAndWait_d__19.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000A64 RID: 2660
			// (get) Token: 0x0600254A RID: 9546 RVA: 0x000A0A28 File Offset: 0x0009EC28
			// (set) Token: 0x0600254B RID: 9547 RVA: 0x00010CA4 File Offset: 0x0000EEA4
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabLoader<T>._LoadAndWait_d__19.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabLoader<T>._LoadAndWait_d__19.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A65 RID: 2661
			// (get) Token: 0x0600254C RID: 9548 RVA: 0x000A0A58 File Offset: 0x0009EC58
			// (set) Token: 0x0600254D RID: 9549 RVA: 0x00010CC3 File Offset: 0x0000EEC3
			public unsafe PrefabLoader<T> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabLoader<T>._LoadAndWait_d__19.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PrefabLoader<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabLoader<T>._LoadAndWait_d__19.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A66 RID: 2662
			// (get) Token: 0x0600254E RID: 9550 RVA: 0x000A0A88 File Offset: 0x0009EC88
			// (set) Token: 0x0600254F RID: 9551 RVA: 0x00010CE2 File Offset: 0x0000EEE2
			public AssetName assetName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabLoader<T>._LoadAndWait_d__19.NativeFieldInfoPtr_assetName);
					return new AssetName(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AssetName>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabLoader<T>._LoadAndWait_d__19.NativeFieldInfoPtr_assetName), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AssetName>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400195D RID: 6493
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400195E RID: 6494
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400195F RID: 6495
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001960 RID: 6496
			private static readonly IntPtr NativeFieldInfoPtr_assetName;

			// Token: 0x04001961 RID: 6497
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001962 RID: 6498
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001963 RID: 6499
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001964 RID: 6500
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001965 RID: 6501
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001966 RID: 6502
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000332 RID: 818
		[ObfuscatedName("dwd.core.loader.loaders.PrefabLoader`1+<loadAsset>d__21")]
		public sealed class _loadAsset_d__21 : global::Il2CppSystem.Object
		{
			// Token: 0x06002550 RID: 9552 RVA: 0x000A0AB8 File Offset: 0x0009ECB8
			// Note: this type is marked as 'beforefieldinit'.
			static _loadAsset_d__21()
			{
				Il2CppClassPointerStore<PrefabLoader<T>._loadAsset_d__21>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PrefabLoader<T>>.NativeClassPtr, "<loadAsset>d__21"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrefabLoader<T>._loadAsset_d__21>.NativeClassPtr);
				PrefabLoader<T>._loadAsset_d__21.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabLoader<T>._loadAsset_d__21>.NativeClassPtr, "<>1__state");
				PrefabLoader<T>._loadAsset_d__21.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabLoader<T>._loadAsset_d__21>.NativeClassPtr, "<>2__current");
				PrefabLoader<T>._loadAsset_d__21.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabLoader<T>._loadAsset_d__21>.NativeClassPtr, "<>4__this");
				PrefabLoader<T>._loadAsset_d__21.NativeFieldInfoPtr_assetName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabLoader<T>._loadAsset_d__21>.NativeClassPtr, "assetName");
				PrefabLoader<T>._loadAsset_d__21.NativeFieldInfoPtr__load_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabLoader<T>._loadAsset_d__21>.NativeClassPtr, "<load>5__2");
				PrefabLoader<T>._loadAsset_d__21.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabLoader<T>._loadAsset_d__21>.NativeClassPtr, 100666868);
				PrefabLoader<T>._loadAsset_d__21.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabLoader<T>._loadAsset_d__21>.NativeClassPtr, 100666869);
				PrefabLoader<T>._loadAsset_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabLoader<T>._loadAsset_d__21>.NativeClassPtr, 100666870);
				PrefabLoader<T>._loadAsset_d__21.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabLoader<T>._loadAsset_d__21>.NativeClassPtr, 100666871);
				PrefabLoader<T>._loadAsset_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabLoader<T>._loadAsset_d__21>.NativeClassPtr, 100666872);
				PrefabLoader<T>._loadAsset_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabLoader<T>._loadAsset_d__21>.NativeClassPtr, 100666873);
			}

			// Token: 0x06002551 RID: 9553 RVA: 0x000A0BFC File Offset: 0x0009EDFC
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _loadAsset_d__21(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrefabLoader<T>._loadAsset_d__21>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabLoader<T>._loadAsset_d__21.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002552 RID: 9554 RVA: 0x000A0C44 File Offset: 0x0009EE44
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabLoader<T>._loadAsset_d__21.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002553 RID: 9555 RVA: 0x000A0C78 File Offset: 0x0009EE78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 878845, XrefRangeEnd = 878865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabLoader<T>._loadAsset_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000A6E RID: 2670
			// (get) Token: 0x06002554 RID: 9556 RVA: 0x000A0CB4 File Offset: 0x0009EEB4
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabLoader<T>._loadAsset_d__21.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002555 RID: 9557 RVA: 0x000A0CF4 File Offset: 0x0009EEF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabLoader<T>._loadAsset_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000A6F RID: 2671
			// (get) Token: 0x06002556 RID: 9558 RVA: 0x000A0D28 File Offset: 0x0009EF28
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabLoader<T>._loadAsset_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002557 RID: 9559 RVA: 0x00010D10 File Offset: 0x0000EF10
			public _loadAsset_d__21(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A69 RID: 2665
			// (get) Token: 0x06002558 RID: 9560 RVA: 0x000A0D68 File Offset: 0x0009EF68
			// (set) Token: 0x06002559 RID: 9561 RVA: 0x00010D19 File Offset: 0x0000EF19
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabLoader<T>._loadAsset_d__21.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabLoader<T>._loadAsset_d__21.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000A6A RID: 2666
			// (get) Token: 0x0600255A RID: 9562 RVA: 0x000A0D90 File Offset: 0x0009EF90
			// (set) Token: 0x0600255B RID: 9563 RVA: 0x00010D34 File Offset: 0x0000EF34
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabLoader<T>._loadAsset_d__21.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabLoader<T>._loadAsset_d__21.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A6B RID: 2667
			// (get) Token: 0x0600255C RID: 9564 RVA: 0x000A0DC0 File Offset: 0x0009EFC0
			// (set) Token: 0x0600255D RID: 9565 RVA: 0x00010D53 File Offset: 0x0000EF53
			public unsafe PrefabLoader<T> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabLoader<T>._loadAsset_d__21.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PrefabLoader<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabLoader<T>._loadAsset_d__21.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A6C RID: 2668
			// (get) Token: 0x0600255E RID: 9566 RVA: 0x000A0DF0 File Offset: 0x0009EFF0
			// (set) Token: 0x0600255F RID: 9567 RVA: 0x00010D72 File Offset: 0x0000EF72
			public AssetName assetName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabLoader<T>._loadAsset_d__21.NativeFieldInfoPtr_assetName);
					return new AssetName(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AssetName>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabLoader<T>._loadAsset_d__21.NativeFieldInfoPtr_assetName), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AssetName>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000A6D RID: 2669
			// (get) Token: 0x06002560 RID: 9568 RVA: 0x000A0E20 File Offset: 0x0009F020
			// (set) Token: 0x06002561 RID: 9569 RVA: 0x00010DA0 File Offset: 0x0000EFA0
			public unsafe IEnumerator _load_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabLoader<T>._loadAsset_d__21.NativeFieldInfoPtr__load_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabLoader<T>._loadAsset_d__21.NativeFieldInfoPtr__load_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001967 RID: 6503
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001968 RID: 6504
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001969 RID: 6505
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400196A RID: 6506
			private static readonly IntPtr NativeFieldInfoPtr_assetName;

			// Token: 0x0400196B RID: 6507
			private static readonly IntPtr NativeFieldInfoPtr__load_5__2;

			// Token: 0x0400196C RID: 6508
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400196D RID: 6509
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400196E RID: 6510
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400196F RID: 6511
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001970 RID: 6512
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001971 RID: 6513
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
