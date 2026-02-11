using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.Localization.Tables
{
	// Token: 0x02000020 RID: 32
	public class AssetTableEntry : TableEntry
	{
		// Token: 0x0600019D RID: 413 RVA: 0x0000F1B4 File Offset: 0x0000D3B4
		// Note: this type is marked as 'beforefieldinit'.
		static AssetTableEntry()
		{
			Il2CppClassPointerStore<AssetTableEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Tables", "AssetTableEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetTableEntry>.NativeClassPtr);
			AssetTableEntry.NativeFieldInfoPtr__PreloadAsyncOperation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetTableEntry>.NativeClassPtr, "<PreloadAsyncOperation>k__BackingField");
			AssetTableEntry.NativeFieldInfoPtr__AsyncOperation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetTableEntry>.NativeClassPtr, "<AsyncOperation>k__BackingField");
			AssetTableEntry.NativeFieldInfoPtr_m_GuidCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetTableEntry>.NativeClassPtr, "m_GuidCache");
			AssetTableEntry.NativeFieldInfoPtr_m_SubAssetNameCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetTableEntry>.NativeClassPtr, "m_SubAssetNameCache");
			AssetTableEntry.NativeMethodInfoPtr_get_PreloadAsyncOperation_Internal_get_AsyncOperationHandle_1_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetTableEntry>.NativeClassPtr, 100663595);
			AssetTableEntry.NativeMethodInfoPtr_set_PreloadAsyncOperation_Internal_set_Void_AsyncOperationHandle_1_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetTableEntry>.NativeClassPtr, 100663596);
			AssetTableEntry.NativeMethodInfoPtr_get_AsyncOperation_Internal_get_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetTableEntry>.NativeClassPtr, 100663597);
			AssetTableEntry.NativeMethodInfoPtr_set_AsyncOperation_Internal_set_Void_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetTableEntry>.NativeClassPtr, 100663598);
			AssetTableEntry.NativeMethodInfoPtr_get_Address_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetTableEntry>.NativeClassPtr, 100663599);
			AssetTableEntry.NativeMethodInfoPtr_set_Address_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetTableEntry>.NativeClassPtr, 100663600);
			AssetTableEntry.NativeMethodInfoPtr_get_Guid_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetTableEntry>.NativeClassPtr, 100663601);
			AssetTableEntry.NativeMethodInfoPtr_set_Guid_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetTableEntry>.NativeClassPtr, 100663602);
			AssetTableEntry.NativeMethodInfoPtr_get_SubAssetName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetTableEntry>.NativeClassPtr, 100663603);
			AssetTableEntry.NativeMethodInfoPtr_get_IsEmpty_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetTableEntry>.NativeClassPtr, 100663604);
			AssetTableEntry.NativeMethodInfoPtr_get_IsSubAsset_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetTableEntry>.NativeClassPtr, 100663605);
			AssetTableEntry.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetTableEntry>.NativeClassPtr, 100663606);
			AssetTableEntry.NativeMethodInfoPtr_RemoveFromTable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetTableEntry>.NativeClassPtr, 100663607);
			AssetTableEntry.NativeMethodInfoPtr_GetExpectedType_Internal_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetTableEntry>.NativeClassPtr, 100663608);
			AssetTableEntry.NativeMethodInfoPtr_SetAssetOverride_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetTableEntry>.NativeClassPtr, 100663609);
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x0600019E RID: 414 RVA: 0x0000F360 File Offset: 0x0000D560
		// (set) Token: 0x0600019F RID: 415 RVA: 0x0000F398 File Offset: 0x0000D598
		public unsafe AsyncOperationHandle<Il2CppReferenceArray<Object>> PreloadAsyncOperation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetTableEntry.NativeMethodInfoPtr_get_PreloadAsyncOperation_Internal_get_AsyncOperationHandle_1_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new AsyncOperationHandle<Il2CppReferenceArray<Object>>(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1066653, XrefRangeEnd = 1066654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetTableEntry.NativeMethodInfoPtr_set_PreloadAsyncOperation_Internal_set_Void_AsyncOperationHandle_1_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x0000F3E0 File Offset: 0x0000D5E0
		// (set) Token: 0x060001A1 RID: 417 RVA: 0x0000F418 File Offset: 0x0000D618
		public unsafe AsyncOperationHandle AsyncOperation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetTableEntry.NativeMethodInfoPtr_get_AsyncOperation_Internal_get_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new AsyncOperationHandle(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1066654, XrefRangeEnd = 1066655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetTableEntry.NativeMethodInfoPtr_set_AsyncOperation_Internal_set_Void_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x0000F460 File Offset: 0x0000D660
		// (set) Token: 0x060001A3 RID: 419 RVA: 0x0000F498 File Offset: 0x0000D698
		public unsafe string Address
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 374429, RefRangeEnd = 374430, XrefRangeStart = 374429, XrefRangeEnd = 374430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetTableEntry.NativeMethodInfoPtr_get_Address_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1066655, XrefRangeEnd = 1066659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetTableEntry.NativeMethodInfoPtr_set_Address_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060001A4 RID: 420 RVA: 0x0000F4DC File Offset: 0x0000D6DC
		// (set) Token: 0x060001A5 RID: 421 RVA: 0x0000F514 File Offset: 0x0000D714
		public unsafe string Guid
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1066667, RefRangeEnd = 1066668, XrefRangeStart = 1066659, XrefRangeEnd = 1066667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetTableEntry.NativeMethodInfoPtr_get_Guid_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetTableEntry.NativeMethodInfoPtr_set_Guid_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060001A6 RID: 422 RVA: 0x0000F558 File Offset: 0x0000D758
		public unsafe string SubAssetName
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1066677, RefRangeEnd = 1066678, XrefRangeStart = 1066668, XrefRangeEnd = 1066677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetTableEntry.NativeMethodInfoPtr_get_SubAssetName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060001A7 RID: 423 RVA: 0x0000F590 File Offset: 0x0000D790
		public unsafe bool IsEmpty
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1066680, RefRangeEnd = 1066681, XrefRangeStart = 1066678, XrefRangeEnd = 1066680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetTableEntry.NativeMethodInfoPtr_get_IsEmpty_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x0000F5CC File Offset: 0x0000D7CC
		public unsafe bool IsSubAsset
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1066682, RefRangeEnd = 1066683, XrefRangeStart = 1066681, XrefRangeEnd = 1066682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetTableEntry.NativeMethodInfoPtr_get_IsSubAsset_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x0000F608 File Offset: 0x0000D808
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssetTableEntry()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetTableEntry>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetTableEntry.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001AA RID: 426 RVA: 0x0000F644 File Offset: 0x0000D844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1066683, XrefRangeEnd = 1066706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveFromTable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetTableEntry.NativeMethodInfoPtr_RemoveFromTable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001AB RID: 427 RVA: 0x0000F678 File Offset: 0x0000D878
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1066706, XrefRangeEnd = 1066724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Type GetExpectedType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetTableEntry.NativeMethodInfoPtr_GetExpectedType_Internal_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x060001AC RID: 428 RVA: 0x0000F6B8 File Offset: 0x0000D8B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1066724, XrefRangeEnd = 1066731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAssetOverride<T>(T asset) where T : Object
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = asset;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref asset;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AssetTableEntry.MethodInfoStoreGeneric_SetAssetOverride_Public_Void_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00002AA3 File Offset: 0x00000CA3
		public AssetTableEntry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060001AE RID: 430 RVA: 0x0000F730 File Offset: 0x0000D930
		// (set) Token: 0x060001AF RID: 431 RVA: 0x00002AAC File Offset: 0x00000CAC
		public AsyncOperationHandle<Il2CppReferenceArray<Object>> _PreloadAsyncOperation_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetTableEntry.NativeFieldInfoPtr__PreloadAsyncOperation_k__BackingField);
				return new AsyncOperationHandle<Il2CppReferenceArray<Object>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle<Il2CppReferenceArray<Object>>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetTableEntry.NativeFieldInfoPtr__PreloadAsyncOperation_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle<Il2CppReferenceArray<Object>>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060001B0 RID: 432 RVA: 0x0000F760 File Offset: 0x0000D960
		// (set) Token: 0x060001B1 RID: 433 RVA: 0x00002ADA File Offset: 0x00000CDA
		public AsyncOperationHandle _AsyncOperation_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetTableEntry.NativeFieldInfoPtr__AsyncOperation_k__BackingField);
				return new AsyncOperationHandle(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetTableEntry.NativeFieldInfoPtr__AsyncOperation_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060001B2 RID: 434 RVA: 0x0000F790 File Offset: 0x0000D990
		// (set) Token: 0x060001B3 RID: 435 RVA: 0x00002B08 File Offset: 0x00000D08
		public unsafe string m_GuidCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetTableEntry.NativeFieldInfoPtr_m_GuidCache);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetTableEntry.NativeFieldInfoPtr_m_GuidCache), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x0000F7B8 File Offset: 0x0000D9B8
		// (set) Token: 0x060001B5 RID: 437 RVA: 0x00002B27 File Offset: 0x00000D27
		public unsafe string m_SubAssetNameCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetTableEntry.NativeFieldInfoPtr_m_SubAssetNameCache);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetTableEntry.NativeFieldInfoPtr_m_SubAssetNameCache), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000125 RID: 293
		private static readonly IntPtr NativeFieldInfoPtr__PreloadAsyncOperation_k__BackingField;

		// Token: 0x04000126 RID: 294
		private static readonly IntPtr NativeFieldInfoPtr__AsyncOperation_k__BackingField;

		// Token: 0x04000127 RID: 295
		private static readonly IntPtr NativeFieldInfoPtr_m_GuidCache;

		// Token: 0x04000128 RID: 296
		private static readonly IntPtr NativeFieldInfoPtr_m_SubAssetNameCache;

		// Token: 0x04000129 RID: 297
		private static readonly IntPtr NativeMethodInfoPtr_get_PreloadAsyncOperation_Internal_get_AsyncOperationHandle_1_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400012A RID: 298
		private static readonly IntPtr NativeMethodInfoPtr_set_PreloadAsyncOperation_Internal_set_Void_AsyncOperationHandle_1_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400012B RID: 299
		private static readonly IntPtr NativeMethodInfoPtr_get_AsyncOperation_Internal_get_AsyncOperationHandle_0;

		// Token: 0x0400012C RID: 300
		private static readonly IntPtr NativeMethodInfoPtr_set_AsyncOperation_Internal_set_Void_AsyncOperationHandle_0;

		// Token: 0x0400012D RID: 301
		private static readonly IntPtr NativeMethodInfoPtr_get_Address_Public_get_String_0;

		// Token: 0x0400012E RID: 302
		private static readonly IntPtr NativeMethodInfoPtr_set_Address_Public_set_Void_String_0;

		// Token: 0x0400012F RID: 303
		private static readonly IntPtr NativeMethodInfoPtr_get_Guid_Public_get_String_0;

		// Token: 0x04000130 RID: 304
		private static readonly IntPtr NativeMethodInfoPtr_set_Guid_Public_set_Void_String_0;

		// Token: 0x04000131 RID: 305
		private static readonly IntPtr NativeMethodInfoPtr_get_SubAssetName_Public_get_String_0;

		// Token: 0x04000132 RID: 306
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEmpty_Public_get_Boolean_0;

		// Token: 0x04000133 RID: 307
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSubAsset_Public_get_Boolean_0;

		// Token: 0x04000134 RID: 308
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04000135 RID: 309
		private static readonly IntPtr NativeMethodInfoPtr_RemoveFromTable_Public_Void_0;

		// Token: 0x04000136 RID: 310
		private static readonly IntPtr NativeMethodInfoPtr_GetExpectedType_Internal_Type_0;

		// Token: 0x04000137 RID: 311
		private static readonly IntPtr NativeMethodInfoPtr_SetAssetOverride_Public_Void_T_0;

		// Token: 0x0200011B RID: 283
		private sealed class MethodInfoStoreGeneric_SetAssetOverride_Public_Void_T_0<T>
		{
			// Token: 0x04000910 RID: 2320
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AssetTableEntry.NativeMethodInfoPtr_SetAssetOverride_Public_Void_T_0, Il2CppClassPointerStore<AssetTableEntry>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
