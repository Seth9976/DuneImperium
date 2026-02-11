using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using UnityEngine.Events;

namespace UnityEngine.Localization.Components
{
	// Token: 0x020000C7 RID: 199
	public class LocalizedAssetEvent<TObject, TReference, TEvent> : LocalizedAssetBehaviour<TObject, TReference> where TObject : Object where TReference : LocalizedAsset<TObject>, new() where TEvent : UnityEvent<TObject>, new()
	{
		// Token: 0x06000A86 RID: 2694 RVA: 0x00030F2C File Offset: 0x0002F12C
		// Note: this type is marked as 'beforefieldinit'.
		static LocalizedAssetEvent()
		{
			Il2CppClassPointerStore<LocalizedAssetEvent<TObject, TReference, TEvent>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Components", "LocalizedAssetEvent`3"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TReference>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEvent>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizedAssetEvent<TObject, TReference, TEvent>>.NativeClassPtr);
			LocalizedAssetEvent<TObject, TReference, TEvent>.NativeFieldInfoPtr_m_UpdateAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedAssetEvent<TObject, TReference, TEvent>>.NativeClassPtr, "m_UpdateAsset");
			LocalizedAssetEvent<TObject, TReference, TEvent>.NativeMethodInfoPtr_get_OnUpdateAsset_Public_get_TEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedAssetEvent<TObject, TReference, TEvent>>.NativeClassPtr, 100665060);
			LocalizedAssetEvent<TObject, TReference, TEvent>.NativeMethodInfoPtr_set_OnUpdateAsset_Public_set_Void_TEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedAssetEvent<TObject, TReference, TEvent>>.NativeClassPtr, 100665061);
			LocalizedAssetEvent<TObject, TReference, TEvent>.NativeMethodInfoPtr_UpdateAsset_Protected_Virtual_Void_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedAssetEvent<TObject, TReference, TEvent>>.NativeClassPtr, 100665062);
			LocalizedAssetEvent<TObject, TReference, TEvent>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedAssetEvent<TObject, TReference, TEvent>>.NativeClassPtr, 100665063);
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06000A87 RID: 2695 RVA: 0x00031020 File Offset: 0x0002F220
		// (set) Token: 0x06000A88 RID: 2696 RVA: 0x0003105C File Offset: 0x0002F25C
		public unsafe TEvent OnUpdateAsset
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedAssetEvent<TObject, TReference, TEvent>.NativeMethodInfoPtr_get_OnUpdateAsset_Public_get_TEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TEvent>(intPtr, false, true);
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
					if (!typeof(TEvent).IsValueType)
					{
						TEvent tevent = value;
						intPtr = ((tevent is string) ? IL2CPP.ManagedStringToIl2Cpp(tevent as string) : IL2CPP.Il2CppObjectBaseToPtr(tevent as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref value;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LocalizedAssetEvent<TObject, TReference, TEvent>.NativeMethodInfoPtr_set_OnUpdateAsset_Public_set_Void_TEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}
		}

		// Token: 0x06000A89 RID: 2697 RVA: 0x000310D4 File Offset: 0x0002F2D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078779, XrefRangeEnd = 1078781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateAsset(TObject localizedAsset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TObject).IsValueType)
				{
					TObject tobject = localizedAsset;
					intPtr = ((tobject is string) ? IL2CPP.ManagedStringToIl2Cpp(tobject as string) : IL2CPP.Il2CppObjectBaseToPtr(tobject as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref localizedAsset;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizedAssetEvent<TObject, TReference, TEvent>.NativeMethodInfoPtr_UpdateAsset_Protected_Virtual_Void_TObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06000A8A RID: 2698 RVA: 0x00031158 File Offset: 0x0002F358
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1078786, RefRangeEnd = 1078790, XrefRangeStart = 1078781, XrefRangeEnd = 1078786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalizedAssetEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizedAssetEvent<TObject, TReference, TEvent>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedAssetEvent<TObject, TReference, TEvent>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A8B RID: 2699 RVA: 0x0000663E File Offset: 0x0000483E
		public LocalizedAssetEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06000A8C RID: 2700 RVA: 0x00031194 File Offset: 0x0002F394
		// (set) Token: 0x06000A8D RID: 2701 RVA: 0x000311BC File Offset: 0x0002F3BC
		public unsafe TEvent m_UpdateAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedAssetEvent<TObject, TReference, TEvent>.NativeFieldInfoPtr_m_UpdateAsset);
				return IL2CPP.PointerToValueGeneric<TEvent>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedAssetEvent<TObject, TReference, TEvent>.NativeFieldInfoPtr_m_UpdateAsset);
				Type typeFromHandle = typeof(TEvent);
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

		// Token: 0x04000760 RID: 1888
		private static readonly IntPtr NativeFieldInfoPtr_m_UpdateAsset;

		// Token: 0x04000761 RID: 1889
		private static readonly IntPtr NativeMethodInfoPtr_get_OnUpdateAsset_Public_get_TEvent_0;

		// Token: 0x04000762 RID: 1890
		private static readonly IntPtr NativeMethodInfoPtr_set_OnUpdateAsset_Public_set_Void_TEvent_0;

		// Token: 0x04000763 RID: 1891
		private static readonly IntPtr NativeMethodInfoPtr_UpdateAsset_Protected_Virtual_Void_TObject_0;

		// Token: 0x04000764 RID: 1892
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
