using System;
using Canis.utils;
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
	// Token: 0x02000197 RID: 407
	public class BaseBundleLoader<T> : VersionedModel where T : global::UnityEngine.Object
	{
		// Token: 0x060016EC RID: 5868 RVA: 0x0006FA44 File Offset: 0x0006DC44
		// Note: this type is marked as 'beforefieldinit'.
		static BaseBundleLoader()
		{
			Il2CppClassPointerStore<BaseBundleLoader<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.loader.loaders", "BaseBundleLoader`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseBundleLoader<T>>.NativeClassPtr);
			BaseBundleLoader<T>.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseBundleLoader<T>>.NativeClassPtr, "source");
			BaseBundleLoader<T>.NativeFieldInfoPtr_stateChangedCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseBundleLoader<T>>.NativeClassPtr, "stateChangedCallback");
			BaseBundleLoader<T>.NativeFieldInfoPtr_load = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseBundleLoader<T>>.NativeClassPtr, "load");
			BaseBundleLoader<T>.NativeFieldInfoPtr_assetReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseBundleLoader<T>>.NativeClassPtr, "assetReference");
			BaseBundleLoader<T>.NativeFieldInfoPtr_previousAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseBundleLoader<T>>.NativeClassPtr, "previousAsset");
			BaseBundleLoader<T>.NativeFieldInfoPtr_previousState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseBundleLoader<T>>.NativeClassPtr, "previousState");
			BaseBundleLoader<T>.NativeFieldInfoPtr__Asset_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseBundleLoader<T>>.NativeClassPtr, "<Asset>k__BackingField");
			BaseBundleLoader<T>.NativeFieldInfoPtr__State_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseBundleLoader<T>>.NativeClassPtr, "<State>k__BackingField");
			BaseBundleLoader<T>.NativeMethodInfoPtr_get_Asset_Public_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseBundleLoader<T>>.NativeClassPtr, 100666808);
			BaseBundleLoader<T>.NativeMethodInfoPtr_set_Asset_Private_set_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseBundleLoader<T>>.NativeClassPtr, 100666809);
			BaseBundleLoader<T>.NativeMethodInfoPtr_get_State_Public_get_States_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseBundleLoader<T>>.NativeClassPtr, 100666810);
			BaseBundleLoader<T>.NativeMethodInfoPtr_set_State_Private_set_Void_States_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseBundleLoader<T>>.NativeClassPtr, 100666811);
			BaseBundleLoader<T>.NativeMethodInfoPtr__ctor_Protected_Void_IReferenceTracker_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseBundleLoader<T>>.NativeClassPtr, 100666812);
			BaseBundleLoader<T>.NativeMethodInfoPtr_Clear_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseBundleLoader<T>>.NativeClassPtr, 100666813);
			BaseBundleLoader<T>.NativeMethodInfoPtr_Load_Protected_Void_AssetName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseBundleLoader<T>>.NativeClassPtr, 100666814);
			BaseBundleLoader<T>.NativeMethodInfoPtr_LoadAsset_Private_IEnumerator_AssetName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseBundleLoader<T>>.NativeClassPtr, 100666815);
			BaseBundleLoader<T>.NativeMethodInfoPtr_InternalLoadAndWait_Protected_IEnumerator_AssetName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseBundleLoader<T>>.NativeClassPtr, 100666816);
			BaseBundleLoader<T>.NativeMethodInfoPtr_SignalChange_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseBundleLoader<T>>.NativeClassPtr, 100666817);
		}

		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x060016ED RID: 5869 RVA: 0x0006FC18 File Offset: 0x0006DE18
		// (set) Token: 0x060016EE RID: 5870 RVA: 0x0006FC54 File Offset: 0x0006DE54
		public unsafe T Asset
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseBundleLoader<T>.NativeMethodInfoPtr_get_Asset_Public_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(BaseBundleLoader<T>.NativeMethodInfoPtr_set_Asset_Private_set_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}
		}

		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x060016EF RID: 5871 RVA: 0x0006FCCC File Offset: 0x0006DECC
		// (set) Token: 0x060016F0 RID: 5872 RVA: 0x0006FD08 File Offset: 0x0006DF08
		public unsafe BaseBundleLoader<T>.States State
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseBundleLoader<T>.NativeMethodInfoPtr_get_State_Public_get_States_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 403849, RefRangeEnd = 403852, XrefRangeStart = 403849, XrefRangeEnd = 403852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseBundleLoader<T>.NativeMethodInfoPtr_set_State_Private_set_Void_States_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060016F1 RID: 5873 RVA: 0x0006FD48 File Offset: 0x0006DF48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 878727, RefRangeEnd = 878728, XrefRangeStart = 878715, XrefRangeEnd = 878727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseBundleLoader(IReferenceTracker source, Action stateChangedCallback = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseBundleLoader<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stateChangedCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseBundleLoader<T>.NativeMethodInfoPtr__ctor_Protected_Void_IReferenceTracker_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016F2 RID: 5874 RVA: 0x0006FDA8 File Offset: 0x0006DFA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 878732, RefRangeEnd = 878733, XrefRangeStart = 878728, XrefRangeEnd = 878732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseBundleLoader<T>.NativeMethodInfoPtr_Clear_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016F3 RID: 5875 RVA: 0x0006FDDC File Offset: 0x0006DFDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 878750, RefRangeEnd = 878751, XrefRangeStart = 878733, XrefRangeEnd = 878750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load(AssetName assetName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(assetName));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseBundleLoader<T>.NativeMethodInfoPtr_Load_Protected_Void_AssetName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060016F4 RID: 5876 RVA: 0x0006FE24 File Offset: 0x0006E024
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 878756, RefRangeEnd = 878758, XrefRangeStart = 878751, XrefRangeEnd = 878756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator LoadAsset(AssetName assetName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(assetName));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseBundleLoader<T>.NativeMethodInfoPtr_LoadAsset_Private_IEnumerator_AssetName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x060016F5 RID: 5877 RVA: 0x0006FE7C File Offset: 0x0006E07C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 878763, RefRangeEnd = 878764, XrefRangeStart = 878758, XrefRangeEnd = 878763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator InternalLoadAndWait(AssetName assetName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(assetName));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseBundleLoader<T>.NativeMethodInfoPtr_InternalLoadAndWait_Protected_IEnumerator_AssetName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x060016F6 RID: 5878 RVA: 0x0006FED4 File Offset: 0x0006E0D4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 878774, RefRangeEnd = 878777, XrefRangeStart = 878764, XrefRangeEnd = 878774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SignalChange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseBundleLoader<T>.NativeMethodInfoPtr_SignalChange_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016F7 RID: 5879 RVA: 0x0000A0B0 File Offset: 0x000082B0
		public BaseBundleLoader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x060016F8 RID: 5880 RVA: 0x0006FF08 File Offset: 0x0006E108
		// (set) Token: 0x060016F9 RID: 5881 RVA: 0x0000A0B9 File Offset: 0x000082B9
		public unsafe IReferenceTracker source
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseBundleLoader<T>.NativeFieldInfoPtr_source);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReferenceTracker>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseBundleLoader<T>.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x060016FA RID: 5882 RVA: 0x0006FF38 File Offset: 0x0006E138
		// (set) Token: 0x060016FB RID: 5883 RVA: 0x0000A0D8 File Offset: 0x000082D8
		public unsafe Action stateChangedCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseBundleLoader<T>.NativeFieldInfoPtr_stateChangedCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseBundleLoader<T>.NativeFieldInfoPtr_stateChangedCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x060016FC RID: 5884 RVA: 0x0006FF68 File Offset: 0x0006E168
		// (set) Token: 0x060016FD RID: 5885 RVA: 0x0000A0F7 File Offset: 0x000082F7
		public unsafe InterruptableCommand load
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseBundleLoader<T>.NativeFieldInfoPtr_load);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InterruptableCommand>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseBundleLoader<T>.NativeFieldInfoPtr_load), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x060016FE RID: 5886 RVA: 0x0006FF98 File Offset: 0x0006E198
		// (set) Token: 0x060016FF RID: 5887 RVA: 0x0000A116 File Offset: 0x00008316
		public unsafe IAssetReference<T> assetReference
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseBundleLoader<T>.NativeFieldInfoPtr_assetReference);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAssetReference<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseBundleLoader<T>.NativeFieldInfoPtr_assetReference), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x06001700 RID: 5888 RVA: 0x0006FFC8 File Offset: 0x0006E1C8
		// (set) Token: 0x06001701 RID: 5889 RVA: 0x0006FFF0 File Offset: 0x0006E1F0
		public unsafe T previousAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseBundleLoader<T>.NativeFieldInfoPtr_previousAsset);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseBundleLoader<T>.NativeFieldInfoPtr_previousAsset);
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

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x06001702 RID: 5890 RVA: 0x00070098 File Offset: 0x0006E298
		// (set) Token: 0x06001703 RID: 5891 RVA: 0x0000A135 File Offset: 0x00008335
		public unsafe BaseBundleLoader<T>.States previousState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseBundleLoader<T>.NativeFieldInfoPtr_previousState);
				return *intPtr;
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseBundleLoader<T>.NativeFieldInfoPtr_previousState), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BaseBundleLoader<T>.States>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x06001704 RID: 5892 RVA: 0x000700C0 File Offset: 0x0006E2C0
		// (set) Token: 0x06001705 RID: 5893 RVA: 0x000700E8 File Offset: 0x0006E2E8
		public unsafe T _Asset_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseBundleLoader<T>.NativeFieldInfoPtr__Asset_k__BackingField);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseBundleLoader<T>.NativeFieldInfoPtr__Asset_k__BackingField);
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

		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x06001706 RID: 5894 RVA: 0x00070190 File Offset: 0x0006E390
		// (set) Token: 0x06001707 RID: 5895 RVA: 0x0000A163 File Offset: 0x00008363
		public unsafe BaseBundleLoader<T>.States _State_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseBundleLoader<T>.NativeFieldInfoPtr__State_k__BackingField);
				return *intPtr;
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseBundleLoader<T>.NativeFieldInfoPtr__State_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BaseBundleLoader<T>.States>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04001038 RID: 4152
		private static readonly IntPtr NativeFieldInfoPtr_source;

		// Token: 0x04001039 RID: 4153
		private static readonly IntPtr NativeFieldInfoPtr_stateChangedCallback;

		// Token: 0x0400103A RID: 4154
		private static readonly IntPtr NativeFieldInfoPtr_load;

		// Token: 0x0400103B RID: 4155
		private static readonly IntPtr NativeFieldInfoPtr_assetReference;

		// Token: 0x0400103C RID: 4156
		private static readonly IntPtr NativeFieldInfoPtr_previousAsset;

		// Token: 0x0400103D RID: 4157
		private static readonly IntPtr NativeFieldInfoPtr_previousState;

		// Token: 0x0400103E RID: 4158
		private static readonly IntPtr NativeFieldInfoPtr__Asset_k__BackingField;

		// Token: 0x0400103F RID: 4159
		private static readonly IntPtr NativeFieldInfoPtr__State_k__BackingField;

		// Token: 0x04001040 RID: 4160
		private static readonly IntPtr NativeMethodInfoPtr_get_Asset_Public_get_T_0;

		// Token: 0x04001041 RID: 4161
		private static readonly IntPtr NativeMethodInfoPtr_set_Asset_Private_set_Void_T_0;

		// Token: 0x04001042 RID: 4162
		private static readonly IntPtr NativeMethodInfoPtr_get_State_Public_get_States_T_0;

		// Token: 0x04001043 RID: 4163
		private static readonly IntPtr NativeMethodInfoPtr_set_State_Private_set_Void_States_T_0;

		// Token: 0x04001044 RID: 4164
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_IReferenceTracker_Action_0;

		// Token: 0x04001045 RID: 4165
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Protected_Void_0;

		// Token: 0x04001046 RID: 4166
		private static readonly IntPtr NativeMethodInfoPtr_Load_Protected_Void_AssetName_0;

		// Token: 0x04001047 RID: 4167
		private static readonly IntPtr NativeMethodInfoPtr_LoadAsset_Private_IEnumerator_AssetName_0;

		// Token: 0x04001048 RID: 4168
		private static readonly IntPtr NativeMethodInfoPtr_InternalLoadAndWait_Protected_IEnumerator_AssetName_0;

		// Token: 0x04001049 RID: 4169
		private static readonly IntPtr NativeMethodInfoPtr_SignalChange_Private_Void_0;

		// Token: 0x0200032B RID: 811
		public enum States
		{
			// Token: 0x04001929 RID: 6441
			UNINITIALIZED,
			// Token: 0x0400192A RID: 6442
			Loading,
			// Token: 0x0400192B RID: 6443
			Loaded,
			// Token: 0x0400192C RID: 6444
			Error
		}

		// Token: 0x0200032C RID: 812
		[ObfuscatedName("dwd.core.loader.loaders.BaseBundleLoader`1+<InternalLoadAndWait>d__19")]
		public sealed class _InternalLoadAndWait_d__19 : global::Il2CppSystem.Object
		{
			// Token: 0x060024FA RID: 9466 RVA: 0x0009F994 File Offset: 0x0009DB94
			// Note: this type is marked as 'beforefieldinit'.
			static _InternalLoadAndWait_d__19()
			{
				Il2CppClassPointerStore<BaseBundleLoader<T>._InternalLoadAndWait_d__19>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BaseBundleLoader<T>>.NativeClassPtr, "<InternalLoadAndWait>d__19"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseBundleLoader<T>._InternalLoadAndWait_d__19>.NativeClassPtr);
				BaseBundleLoader<T>._InternalLoadAndWait_d__19.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseBundleLoader<T>._InternalLoadAndWait_d__19>.NativeClassPtr, "<>1__state");
				BaseBundleLoader<T>._InternalLoadAndWait_d__19.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseBundleLoader<T>._InternalLoadAndWait_d__19>.NativeClassPtr, "<>2__current");
				BaseBundleLoader<T>._InternalLoadAndWait_d__19.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseBundleLoader<T>._InternalLoadAndWait_d__19>.NativeClassPtr, "<>4__this");
				BaseBundleLoader<T>._InternalLoadAndWait_d__19.NativeFieldInfoPtr_assetName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseBundleLoader<T>._InternalLoadAndWait_d__19>.NativeClassPtr, "assetName");
				BaseBundleLoader<T>._InternalLoadAndWait_d__19.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseBundleLoader<T>._InternalLoadAndWait_d__19>.NativeClassPtr, 100666818);
				BaseBundleLoader<T>._InternalLoadAndWait_d__19.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseBundleLoader<T>._InternalLoadAndWait_d__19>.NativeClassPtr, 100666819);
				BaseBundleLoader<T>._InternalLoadAndWait_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseBundleLoader<T>._InternalLoadAndWait_d__19>.NativeClassPtr, 100666820);
				BaseBundleLoader<T>._InternalLoadAndWait_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseBundleLoader<T>._InternalLoadAndWait_d__19>.NativeClassPtr, 100666821);
				BaseBundleLoader<T>._InternalLoadAndWait_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseBundleLoader<T>._InternalLoadAndWait_d__19>.NativeClassPtr, 100666822);
				BaseBundleLoader<T>._InternalLoadAndWait_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseBundleLoader<T>._InternalLoadAndWait_d__19>.NativeClassPtr, 100666823);
			}

			// Token: 0x060024FB RID: 9467 RVA: 0x0009FAC4 File Offset: 0x0009DCC4
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _InternalLoadAndWait_d__19(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseBundleLoader<T>._InternalLoadAndWait_d__19>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseBundleLoader<T>._InternalLoadAndWait_d__19.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060024FC RID: 9468 RVA: 0x0009FB0C File Offset: 0x0009DD0C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseBundleLoader<T>._InternalLoadAndWait_d__19.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060024FD RID: 9469 RVA: 0x0009FB40 File Offset: 0x0009DD40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 878678, XrefRangeEnd = 878693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseBundleLoader<T>._InternalLoadAndWait_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000A4C RID: 2636
			// (get) Token: 0x060024FE RID: 9470 RVA: 0x0009FB7C File Offset: 0x0009DD7C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseBundleLoader<T>._InternalLoadAndWait_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060024FF RID: 9471 RVA: 0x0009FBBC File Offset: 0x0009DDBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseBundleLoader<T>._InternalLoadAndWait_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000A4D RID: 2637
			// (get) Token: 0x06002500 RID: 9472 RVA: 0x0009FBF0 File Offset: 0x0009DDF0
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseBundleLoader<T>._InternalLoadAndWait_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002501 RID: 9473 RVA: 0x00010A01 File Offset: 0x0000EC01
			public _InternalLoadAndWait_d__19(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A48 RID: 2632
			// (get) Token: 0x06002502 RID: 9474 RVA: 0x0009FC30 File Offset: 0x0009DE30
			// (set) Token: 0x06002503 RID: 9475 RVA: 0x00010A0A File Offset: 0x0000EC0A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseBundleLoader<T>._InternalLoadAndWait_d__19.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseBundleLoader<T>._InternalLoadAndWait_d__19.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000A49 RID: 2633
			// (get) Token: 0x06002504 RID: 9476 RVA: 0x0009FC58 File Offset: 0x0009DE58
			// (set) Token: 0x06002505 RID: 9477 RVA: 0x00010A25 File Offset: 0x0000EC25
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseBundleLoader<T>._InternalLoadAndWait_d__19.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseBundleLoader<T>._InternalLoadAndWait_d__19.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A4A RID: 2634
			// (get) Token: 0x06002506 RID: 9478 RVA: 0x0009FC88 File Offset: 0x0009DE88
			// (set) Token: 0x06002507 RID: 9479 RVA: 0x00010A44 File Offset: 0x0000EC44
			public unsafe BaseBundleLoader<T> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseBundleLoader<T>._InternalLoadAndWait_d__19.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseBundleLoader<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseBundleLoader<T>._InternalLoadAndWait_d__19.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A4B RID: 2635
			// (get) Token: 0x06002508 RID: 9480 RVA: 0x0009FCB8 File Offset: 0x0009DEB8
			// (set) Token: 0x06002509 RID: 9481 RVA: 0x00010A63 File Offset: 0x0000EC63
			public AssetName assetName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseBundleLoader<T>._InternalLoadAndWait_d__19.NativeFieldInfoPtr_assetName);
					return new AssetName(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AssetName>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseBundleLoader<T>._InternalLoadAndWait_d__19.NativeFieldInfoPtr_assetName), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AssetName>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400192D RID: 6445
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400192E RID: 6446
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400192F RID: 6447
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001930 RID: 6448
			private static readonly IntPtr NativeFieldInfoPtr_assetName;

			// Token: 0x04001931 RID: 6449
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001932 RID: 6450
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001933 RID: 6451
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001934 RID: 6452
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001935 RID: 6453
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001936 RID: 6454
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200032D RID: 813
		[ObfuscatedName("dwd.core.loader.loaders.BaseBundleLoader`1+<LoadAsset>d__18")]
		public sealed class _LoadAsset_d__18 : global::Il2CppSystem.Object
		{
			// Token: 0x0600250A RID: 9482 RVA: 0x0009FCE8 File Offset: 0x0009DEE8
			// Note: this type is marked as 'beforefieldinit'.
			static _LoadAsset_d__18()
			{
				Il2CppClassPointerStore<BaseBundleLoader<T>._LoadAsset_d__18>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BaseBundleLoader<T>>.NativeClassPtr, "<LoadAsset>d__18"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseBundleLoader<T>._LoadAsset_d__18>.NativeClassPtr);
				BaseBundleLoader<T>._LoadAsset_d__18.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseBundleLoader<T>._LoadAsset_d__18>.NativeClassPtr, "<>1__state");
				BaseBundleLoader<T>._LoadAsset_d__18.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseBundleLoader<T>._LoadAsset_d__18>.NativeClassPtr, "<>2__current");
				BaseBundleLoader<T>._LoadAsset_d__18.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseBundleLoader<T>._LoadAsset_d__18>.NativeClassPtr, "<>4__this");
				BaseBundleLoader<T>._LoadAsset_d__18.NativeFieldInfoPtr_assetName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseBundleLoader<T>._LoadAsset_d__18>.NativeClassPtr, "assetName");
				BaseBundleLoader<T>._LoadAsset_d__18.NativeFieldInfoPtr__loadEnumerator_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseBundleLoader<T>._LoadAsset_d__18>.NativeClassPtr, "<loadEnumerator>5__2");
				BaseBundleLoader<T>._LoadAsset_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseBundleLoader<T>._LoadAsset_d__18>.NativeClassPtr, 100666824);
				BaseBundleLoader<T>._LoadAsset_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseBundleLoader<T>._LoadAsset_d__18>.NativeClassPtr, 100666825);
				BaseBundleLoader<T>._LoadAsset_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseBundleLoader<T>._LoadAsset_d__18>.NativeClassPtr, 100666826);
				BaseBundleLoader<T>._LoadAsset_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseBundleLoader<T>._LoadAsset_d__18>.NativeClassPtr, 100666827);
				BaseBundleLoader<T>._LoadAsset_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseBundleLoader<T>._LoadAsset_d__18>.NativeClassPtr, 100666828);
				BaseBundleLoader<T>._LoadAsset_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseBundleLoader<T>._LoadAsset_d__18>.NativeClassPtr, 100666829);
			}

			// Token: 0x0600250B RID: 9483 RVA: 0x0009FE2C File Offset: 0x0009E02C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _LoadAsset_d__18(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseBundleLoader<T>._LoadAsset_d__18>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseBundleLoader<T>._LoadAsset_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600250C RID: 9484 RVA: 0x0009FE74 File Offset: 0x0009E074
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseBundleLoader<T>._LoadAsset_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600250D RID: 9485 RVA: 0x0009FEA8 File Offset: 0x0009E0A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 878693, XrefRangeEnd = 878715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseBundleLoader<T>._LoadAsset_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000A53 RID: 2643
			// (get) Token: 0x0600250E RID: 9486 RVA: 0x0009FEE4 File Offset: 0x0009E0E4
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseBundleLoader<T>._LoadAsset_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600250F RID: 9487 RVA: 0x0009FF24 File Offset: 0x0009E124
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseBundleLoader<T>._LoadAsset_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000A54 RID: 2644
			// (get) Token: 0x06002510 RID: 9488 RVA: 0x0009FF58 File Offset: 0x0009E158
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseBundleLoader<T>._LoadAsset_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002511 RID: 9489 RVA: 0x00010A91 File Offset: 0x0000EC91
			public _LoadAsset_d__18(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A4E RID: 2638
			// (get) Token: 0x06002512 RID: 9490 RVA: 0x0009FF98 File Offset: 0x0009E198
			// (set) Token: 0x06002513 RID: 9491 RVA: 0x00010A9A File Offset: 0x0000EC9A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseBundleLoader<T>._LoadAsset_d__18.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseBundleLoader<T>._LoadAsset_d__18.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000A4F RID: 2639
			// (get) Token: 0x06002514 RID: 9492 RVA: 0x0009FFC0 File Offset: 0x0009E1C0
			// (set) Token: 0x06002515 RID: 9493 RVA: 0x00010AB5 File Offset: 0x0000ECB5
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseBundleLoader<T>._LoadAsset_d__18.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseBundleLoader<T>._LoadAsset_d__18.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A50 RID: 2640
			// (get) Token: 0x06002516 RID: 9494 RVA: 0x0009FFF0 File Offset: 0x0009E1F0
			// (set) Token: 0x06002517 RID: 9495 RVA: 0x00010AD4 File Offset: 0x0000ECD4
			public unsafe BaseBundleLoader<T> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseBundleLoader<T>._LoadAsset_d__18.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseBundleLoader<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseBundleLoader<T>._LoadAsset_d__18.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A51 RID: 2641
			// (get) Token: 0x06002518 RID: 9496 RVA: 0x000A0020 File Offset: 0x0009E220
			// (set) Token: 0x06002519 RID: 9497 RVA: 0x00010AF3 File Offset: 0x0000ECF3
			public AssetName assetName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseBundleLoader<T>._LoadAsset_d__18.NativeFieldInfoPtr_assetName);
					return new AssetName(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AssetName>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseBundleLoader<T>._LoadAsset_d__18.NativeFieldInfoPtr_assetName), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AssetName>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000A52 RID: 2642
			// (get) Token: 0x0600251A RID: 9498 RVA: 0x000A0050 File Offset: 0x0009E250
			// (set) Token: 0x0600251B RID: 9499 RVA: 0x00010B21 File Offset: 0x0000ED21
			public unsafe IEnumerator _loadEnumerator_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseBundleLoader<T>._LoadAsset_d__18.NativeFieldInfoPtr__loadEnumerator_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseBundleLoader<T>._LoadAsset_d__18.NativeFieldInfoPtr__loadEnumerator_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001937 RID: 6455
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001938 RID: 6456
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001939 RID: 6457
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400193A RID: 6458
			private static readonly IntPtr NativeFieldInfoPtr_assetName;

			// Token: 0x0400193B RID: 6459
			private static readonly IntPtr NativeFieldInfoPtr__loadEnumerator_5__2;

			// Token: 0x0400193C RID: 6460
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400193D RID: 6461
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400193E RID: 6462
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400193F RID: 6463
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001940 RID: 6464
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001941 RID: 6465
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
