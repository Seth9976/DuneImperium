using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnityEngine.Localization.Operations;
using UnityEngine.Pool;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.Localization
{
	// Token: 0x02000011 RID: 17
	[Serializable]
	public class LocalizedAsset<TObject> : LocalizedAssetBase where TObject : Object
	{
		// Token: 0x0600008F RID: 143 RVA: 0x0000AFE0 File Offset: 0x000091E0
		// Note: this type is marked as 'beforefieldinit'.
		static LocalizedAsset()
		{
			Il2CppClassPointerStore<LocalizedAsset<TObject>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization", "LocalizedAsset`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizedAsset<TObject>>.NativeClassPtr);
			LocalizedAsset<TObject>.NativeFieldInfoPtr_m_ChangeHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedAsset<TObject>>.NativeClassPtr, "m_ChangeHandler");
			LocalizedAsset<TObject>.NativeFieldInfoPtr_m_SelectedLocaleChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedAsset<TObject>>.NativeClassPtr, "m_SelectedLocaleChanged");
			LocalizedAsset<TObject>.NativeFieldInfoPtr_m_AutomaticLoadingCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedAsset<TObject>>.NativeClassPtr, "m_AutomaticLoadingCompleted");
			LocalizedAsset<TObject>.NativeFieldInfoPtr_m_PreviousLoadingOperation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedAsset<TObject>>.NativeClassPtr, "m_PreviousLoadingOperation");
			LocalizedAsset<TObject>.NativeFieldInfoPtr__CurrentLoadingOperationHandle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedAsset<TObject>>.NativeClassPtr, "<CurrentLoadingOperationHandle>k__BackingField");
			LocalizedAsset<TObject>.NativeMethodInfoPtr_set_WaitForCompletion_Public_Virtual_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedAsset<TObject>>.NativeClassPtr, 100663393);
			LocalizedAsset<TObject>.NativeMethodInfoPtr_get_ForceSynchronous_Internal_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedAsset<TObject>>.NativeClassPtr, 100663394);
			LocalizedAsset<TObject>.NativeMethodInfoPtr_get_CurrentLoadingOperationHandle_Public_get_AsyncOperationHandle_1_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedAsset<TObject>>.NativeClassPtr, 100663395);
			LocalizedAsset<TObject>.NativeMethodInfoPtr_set_CurrentLoadingOperationHandle_Internal_set_Void_AsyncOperationHandle_1_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedAsset<TObject>>.NativeClassPtr, 100663396);
			LocalizedAsset<TObject>.NativeMethodInfoPtr_add_AssetChanged_Public_add_Void_ChangeHandler_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedAsset<TObject>>.NativeClassPtr, 100663397);
			LocalizedAsset<TObject>.NativeMethodInfoPtr_remove_AssetChanged_Public_rem_Void_ChangeHandler_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedAsset<TObject>>.NativeClassPtr, 100663398);
			LocalizedAsset<TObject>.NativeMethodInfoPtr_get_HasChangeHandler_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedAsset<TObject>>.NativeClassPtr, 100663399);
			LocalizedAsset<TObject>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedAsset<TObject>>.NativeClassPtr, 100663400);
			LocalizedAsset<TObject>.NativeMethodInfoPtr_LoadAssetAsync_Public_AsyncOperationHandle_1_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedAsset<TObject>>.NativeClassPtr, 100663401);
			LocalizedAsset<TObject>.NativeMethodInfoPtr_LoadAssetAsync_Public_Virtual_AsyncOperationHandle_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedAsset<TObject>>.NativeClassPtr, 100663402);
			LocalizedAsset<TObject>.NativeMethodInfoPtr_LoadAssetAsObjectAsync_Public_Virtual_AsyncOperationHandle_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedAsset<TObject>>.NativeClassPtr, 100663403);
			LocalizedAsset<TObject>.NativeMethodInfoPtr_LoadAsset_Public_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedAsset<TObject>>.NativeClassPtr, 100663404);
			LocalizedAsset<TObject>.NativeMethodInfoPtr_ForceUpdate_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedAsset<TObject>>.NativeClassPtr, 100663405);
			LocalizedAsset<TObject>.NativeMethodInfoPtr_HandleLocaleChange_Private_Void_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedAsset<TObject>>.NativeClassPtr, 100663406);
			LocalizedAsset<TObject>.NativeMethodInfoPtr_AutomaticLoadingCompleted_Private_Void_AsyncOperationHandle_1_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedAsset<TObject>>.NativeClassPtr, 100663407);
			LocalizedAsset<TObject>.NativeMethodInfoPtr_InvokeChangeHandler_Private_Void_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedAsset<TObject>>.NativeClassPtr, 100663408);
			LocalizedAsset<TObject>.NativeMethodInfoPtr_ClearLoadingOperation_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedAsset<TObject>>.NativeClassPtr, 100663409);
			LocalizedAsset<TObject>.NativeMethodInfoPtr_ClearPreviousLoadingOperation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedAsset<TObject>>.NativeClassPtr, 100663410);
			LocalizedAsset<TObject>.NativeMethodInfoPtr_ClearLoadingOperation_Private_Void_AsyncOperationHandle_1_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedAsset<TObject>>.NativeClassPtr, 100663411);
			LocalizedAsset<TObject>.NativeMethodInfoPtr_Reset_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedAsset<TObject>>.NativeClassPtr, 100663412);
			LocalizedAsset<TObject>.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedAsset<TObject>>.NativeClassPtr, 100663413);
			LocalizedAsset<TObject>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedAsset<TObject>>.NativeClassPtr, 100663414);
		}

		// Token: 0x1700001F RID: 31
		// (set) Token: 0x06000090 RID: 144 RVA: 0x0000B268 File Offset: 0x00009468
		public unsafe override bool WaitForCompletion
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065458, XrefRangeEnd = 1065461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizedAsset<TObject>.NativeMethodInfoPtr_set_WaitForCompletion_Public_Virtual_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000091 RID: 145 RVA: 0x0000B2B4 File Offset: 0x000094B4
		public unsafe override bool ForceSynchronous
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065461, XrefRangeEnd = 1065462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizedAsset<TObject>.NativeMethodInfoPtr_get_ForceSynchronous_Internal_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000092 RID: 146 RVA: 0x0000B2FC File Offset: 0x000094FC
		// (set) Token: 0x06000093 RID: 147 RVA: 0x0000B334 File Offset: 0x00009534
		public unsafe AsyncOperationHandle<TObject> CurrentLoadingOperationHandle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedAsset<TObject>.NativeMethodInfoPtr_get_CurrentLoadingOperationHandle_Public_get_AsyncOperationHandle_1_TObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new AsyncOperationHandle<TObject>(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065462, XrefRangeEnd = 1065463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedAsset<TObject>.NativeMethodInfoPtr_set_CurrentLoadingOperationHandle_Internal_set_Void_AsyncOperationHandle_1_TObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000094 RID: 148 RVA: 0x0000B37C File Offset: 0x0000957C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065463, XrefRangeEnd = 1065468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_AssetChanged(LocalizedAsset<TObject>.ChangeHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedAsset<TObject>.NativeMethodInfoPtr_add_AssetChanged_Public_add_Void_ChangeHandler_TObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000095 RID: 149 RVA: 0x0000B3C0 File Offset: 0x000095C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065468, XrefRangeEnd = 1065471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_AssetChanged(LocalizedAsset<TObject>.ChangeHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedAsset<TObject>.NativeMethodInfoPtr_remove_AssetChanged_Public_rem_Void_ChangeHandler_TObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000096 RID: 150 RVA: 0x0000B404 File Offset: 0x00009604
		public unsafe bool HasChangeHandler
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedAsset<TObject>.NativeMethodInfoPtr_get_HasChangeHandler_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000097 RID: 151 RVA: 0x0000B440 File Offset: 0x00009640
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1065481, RefRangeEnd = 1065490, XrefRangeStart = 1065471, XrefRangeEnd = 1065481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalizedAsset()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizedAsset<TObject>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedAsset<TObject>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x0000B47C File Offset: 0x0000967C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065490, XrefRangeEnd = 1065491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<TObject> LoadAssetAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedAsset<TObject>.NativeMethodInfoPtr_LoadAssetAsync_Public_AsyncOperationHandle_1_TObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<TObject>(intPtr);
		}

		// Token: 0x06000099 RID: 153 RVA: 0x0000B4B4 File Offset: 0x000096B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065491, XrefRangeEnd = 1065497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AsyncOperationHandle<T> LoadAssetAsync<T>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizedAsset<T>.MethodInfoStoreGeneric_LoadAssetAsync_Public_Virtual_AsyncOperationHandle_1_T_0.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<T>(intPtr);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x0000B4F8 File Offset: 0x000096F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065497, XrefRangeEnd = 1065507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AsyncOperationHandle<Object> LoadAssetAsObjectAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizedAsset<TObject>.NativeMethodInfoPtr_LoadAssetAsObjectAsync_Public_Virtual_AsyncOperationHandle_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<Object>(intPtr);
		}

		// Token: 0x0600009B RID: 155 RVA: 0x0000B53C File Offset: 0x0000973C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065507, XrefRangeEnd = 1065509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TObject LoadAsset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedAsset<TObject>.NativeMethodInfoPtr_LoadAsset_Public_TObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TObject>(intPtr, false, true);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x0000B578 File Offset: 0x00009778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065509, XrefRangeEnd = 1065510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ForceUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizedAsset<TObject>.NativeMethodInfoPtr_ForceUpdate_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600009D RID: 157 RVA: 0x0000B5B4 File Offset: 0x000097B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1065520, RefRangeEnd = 1065521, XrefRangeStart = 1065510, XrefRangeEnd = 1065520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleLocaleChange(Locale locale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(locale);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedAsset<TObject>.NativeMethodInfoPtr_HandleLocaleChange_Private_Void_Locale_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600009E RID: 158 RVA: 0x0000B5F8 File Offset: 0x000097F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065521, XrefRangeEnd = 1065525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AutomaticLoadingCompleted(AsyncOperationHandle<TObject> loadOperation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(loadOperation));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedAsset<TObject>.NativeMethodInfoPtr_AutomaticLoadingCompleted_Private_Void_AsyncOperationHandle_1_TObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600009F RID: 159 RVA: 0x0000B640 File Offset: 0x00009840
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1065536, RefRangeEnd = 1065537, XrefRangeStart = 1065525, XrefRangeEnd = 1065536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeChangeHandler(TObject value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TObject).IsValueType)
				{
					TObject tobject = value;
					intPtr = ((tobject is string) ? IL2CPP.ManagedStringToIl2Cpp(tobject as string) : IL2CPP.Il2CppObjectBaseToPtr(tobject as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref value;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LocalizedAsset<TObject>.NativeMethodInfoPtr_InvokeChangeHandler_Private_Void_TObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x0000B6B8 File Offset: 0x000098B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065537, XrefRangeEnd = 1065539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearLoadingOperation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedAsset<TObject>.NativeMethodInfoPtr_ClearLoadingOperation_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x0000B6EC File Offset: 0x000098EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065539, XrefRangeEnd = 1065540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearPreviousLoadingOperation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedAsset<TObject>.NativeMethodInfoPtr_ClearPreviousLoadingOperation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x0000B720 File Offset: 0x00009920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065540, XrefRangeEnd = 1065545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearLoadingOperation(AsyncOperationHandle<TObject> operationHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(operationHandle));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedAsset<TObject>.NativeMethodInfoPtr_ClearLoadingOperation_Private_Void_AsyncOperationHandle_1_TObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x0000B768 File Offset: 0x00009968
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065545, XrefRangeEnd = 1065546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizedAsset<TObject>.NativeMethodInfoPtr_Reset_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x0000B7A4 File Offset: 0x000099A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065546, XrefRangeEnd = 1065550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizedAsset<TObject>.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x0000B7E0 File Offset: 0x000099E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065550, XrefRangeEnd = 1065557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedAsset<TObject>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00002458 File Offset: 0x00000658
		public LocalizedAsset(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x0000B814 File Offset: 0x00009A14
		// (set) Token: 0x060000A8 RID: 168 RVA: 0x00002461 File Offset: 0x00000661
		public CallbackArray<LocalizedAsset<TObject>.ChangeHandler> m_ChangeHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedAsset<TObject>.NativeFieldInfoPtr_m_ChangeHandler);
				return new CallbackArray<LocalizedAsset<TObject>.ChangeHandler>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CallbackArray<LocalizedAsset<TObject>.ChangeHandler>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedAsset<TObject>.NativeFieldInfoPtr_m_ChangeHandler), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CallbackArray<LocalizedAsset<TObject>.ChangeHandler>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x0000B844 File Offset: 0x00009A44
		// (set) Token: 0x060000AA RID: 170 RVA: 0x0000248F File Offset: 0x0000068F
		public unsafe Action<Locale> m_SelectedLocaleChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedAsset<TObject>.NativeFieldInfoPtr_m_SelectedLocaleChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Locale>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedAsset<TObject>.NativeFieldInfoPtr_m_SelectedLocaleChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000AB RID: 171 RVA: 0x0000B874 File Offset: 0x00009A74
		// (set) Token: 0x060000AC RID: 172 RVA: 0x000024AE File Offset: 0x000006AE
		public unsafe Action<AsyncOperationHandle<TObject>> m_AutomaticLoadingCompleted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedAsset<TObject>.NativeFieldInfoPtr_m_AutomaticLoadingCompleted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AsyncOperationHandle<TObject>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedAsset<TObject>.NativeFieldInfoPtr_m_AutomaticLoadingCompleted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000AD RID: 173 RVA: 0x0000B8A4 File Offset: 0x00009AA4
		// (set) Token: 0x060000AE RID: 174 RVA: 0x000024CD File Offset: 0x000006CD
		public AsyncOperationHandle<TObject> m_PreviousLoadingOperation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedAsset<TObject>.NativeFieldInfoPtr_m_PreviousLoadingOperation);
				return new AsyncOperationHandle<TObject>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle<TObject>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedAsset<TObject>.NativeFieldInfoPtr_m_PreviousLoadingOperation), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle<TObject>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000AF RID: 175 RVA: 0x0000B8D4 File Offset: 0x00009AD4
		// (set) Token: 0x060000B0 RID: 176 RVA: 0x000024FB File Offset: 0x000006FB
		public AsyncOperationHandle<TObject> _CurrentLoadingOperationHandle_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedAsset<TObject>.NativeFieldInfoPtr__CurrentLoadingOperationHandle_k__BackingField);
				return new AsyncOperationHandle<TObject>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle<TObject>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedAsset<TObject>.NativeFieldInfoPtr__CurrentLoadingOperationHandle_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle<TObject>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeFieldInfoPtr_m_ChangeHandler;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeFieldInfoPtr_m_SelectedLocaleChanged;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeFieldInfoPtr_m_AutomaticLoadingCompleted;

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeFieldInfoPtr_m_PreviousLoadingOperation;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeFieldInfoPtr__CurrentLoadingOperationHandle_k__BackingField;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeMethodInfoPtr_set_WaitForCompletion_Public_Virtual_set_Void_Boolean_0;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeMethodInfoPtr_get_ForceSynchronous_Internal_Virtual_get_Boolean_0;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentLoadingOperationHandle_Public_get_AsyncOperationHandle_1_TObject_0;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentLoadingOperationHandle_Internal_set_Void_AsyncOperationHandle_1_TObject_0;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeMethodInfoPtr_add_AssetChanged_Public_add_Void_ChangeHandler_TObject_0;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeMethodInfoPtr_remove_AssetChanged_Public_rem_Void_ChangeHandler_TObject_0;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeMethodInfoPtr_get_HasChangeHandler_Public_get_Boolean_0;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeMethodInfoPtr_LoadAssetAsync_Public_AsyncOperationHandle_1_TObject_0;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeMethodInfoPtr_LoadAssetAsync_Public_Virtual_AsyncOperationHandle_1_T_0;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeMethodInfoPtr_LoadAssetAsObjectAsync_Public_Virtual_AsyncOperationHandle_1_Object_0;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeMethodInfoPtr_LoadAsset_Public_TObject_0;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeMethodInfoPtr_ForceUpdate_FamOrAssem_Virtual_Void_0;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeMethodInfoPtr_HandleLocaleChange_Private_Void_Locale_0;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeMethodInfoPtr_AutomaticLoadingCompleted_Private_Void_AsyncOperationHandle_1_TObject_0;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeMethodInfoPtr_InvokeChangeHandler_Private_Void_TObject_0;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeMethodInfoPtr_ClearLoadingOperation_Internal_Void_0;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeMethodInfoPtr_ClearPreviousLoadingOperation_Private_Void_0;

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeMethodInfoPtr_ClearLoadingOperation_Private_Void_AsyncOperationHandle_1_TObject_0;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Protected_Virtual_Void_0;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x02000110 RID: 272
		public sealed class ChangeHandler : MulticastDelegate
		{
			// Token: 0x06000CA5 RID: 3237 RVA: 0x00038C20 File Offset: 0x00036E20
			// Note: this type is marked as 'beforefieldinit'.
			static ChangeHandler()
			{
				Il2CppClassPointerStore<LocalizedAsset<TObject>.ChangeHandler>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LocalizedAsset<TObject>>.NativeClassPtr, "ChangeHandler"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) })).TypeHandle.value);
				LocalizedAsset<TObject>.ChangeHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedAsset<TObject>.ChangeHandler>.NativeClassPtr, 100663415);
				LocalizedAsset<TObject>.ChangeHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedAsset<TObject>.ChangeHandler>.NativeClassPtr, 100663416);
				LocalizedAsset<TObject>.ChangeHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_TObject_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedAsset<TObject>.ChangeHandler>.NativeClassPtr, 100663417);
				LocalizedAsset<TObject>.ChangeHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedAsset<TObject>.ChangeHandler>.NativeClassPtr, 100663418);
			}

			// Token: 0x06000CA6 RID: 3238 RVA: 0x00038CCC File Offset: 0x00036ECC
			[CallerCount(144)]
			[CachedScanResults(RefRangeStart = 387041, RefRangeEnd = 387185, XrefRangeStart = 387041, XrefRangeEnd = 387185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ChangeHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizedAsset<TObject>.ChangeHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedAsset<TObject>.ChangeHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000CA7 RID: 3239 RVA: 0x00038D28 File Offset: 0x00036F28
			[CallerCount(0)]
			public unsafe void Invoke(TObject value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TObject).IsValueType)
					{
						TObject tobject = value;
						intPtr = ((tobject is string) ? IL2CPP.ManagedStringToIl2Cpp(tobject as string) : IL2CPP.Il2CppObjectBaseToPtr(tobject as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref value;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LocalizedAsset<TObject>.ChangeHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_TObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}

			// Token: 0x06000CA8 RID: 3240 RVA: 0x00038DA0 File Offset: 0x00036FA0
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 479320, RefRangeEnd = 479322, XrefRangeStart = 479320, XrefRangeEnd = 479322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(TObject value, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TObject).IsValueType)
					{
						TObject tobject = value;
						intPtr = ((tobject is string) ? IL2CPP.ManagedStringToIl2Cpp(tobject as string) : IL2CPP.Il2CppObjectBaseToPtr(tobject as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref value;
					}
					ptr2 = intPtr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LocalizedAsset<TObject>.ChangeHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_TObject_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr4) : null;
			}

			// Token: 0x06000CA9 RID: 3241 RVA: 0x00038E4C File Offset: 0x0003704C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedAsset<TObject>.ChangeHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000CAA RID: 3242 RVA: 0x0000754E File Offset: 0x0000574E
			public ChangeHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000CAB RID: 3243 RVA: 0x00007557 File Offset: 0x00005757
			public static implicit operator LocalizedAsset<TObject>.ChangeHandler(Action<TObject> A_0)
			{
				return DelegateSupport.ConvertDelegate<LocalizedAsset<TObject>.ChangeHandler>(A_0);
			}

			// Token: 0x06000CAC RID: 3244 RVA: 0x0000755F File Offset: 0x0000575F
			public static LocalizedAsset<TObject>.ChangeHandler operator +(LocalizedAsset<TObject>.ChangeHandler A_0, LocalizedAsset<TObject>.ChangeHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<LocalizedAsset<TObject>.ChangeHandler>();
			}

			// Token: 0x06000CAD RID: 3245 RVA: 0x0000756D File Offset: 0x0000576D
			public static LocalizedAsset<TObject>.ChangeHandler operator -(LocalizedAsset<TObject>.ChangeHandler A_0, LocalizedAsset<TObject>.ChangeHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<LocalizedAsset<TObject>.ChangeHandler>();
				}
				return delegate2;
			}

			// Token: 0x040008D1 RID: 2257
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040008D2 RID: 2258
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_TObject_0;

			// Token: 0x040008D3 RID: 2259
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_TObject_AsyncCallback_Object_0;

			// Token: 0x040008D4 RID: 2260
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000111 RID: 273
		public class ConvertToObjectOperation : WaitForCurrentOperationAsyncOperationBase<Object>
		{
			// Token: 0x06000CAE RID: 3246 RVA: 0x00038E90 File Offset: 0x00037090
			// Note: this type is marked as 'beforefieldinit'.
			static ConvertToObjectOperation()
			{
				Il2CppClassPointerStore<LocalizedAsset<TObject>.ConvertToObjectOperation>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LocalizedAsset<TObject>>.NativeClassPtr, "ConvertToObjectOperation"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizedAsset<TObject>.ConvertToObjectOperation>.NativeClassPtr);
				LocalizedAsset<TObject>.ConvertToObjectOperation.NativeFieldInfoPtr_Pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedAsset<TObject>.ConvertToObjectOperation>.NativeClassPtr, "Pool");
				LocalizedAsset<TObject>.ConvertToObjectOperation.NativeFieldInfoPtr_m_Operation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedAsset<TObject>.ConvertToObjectOperation>.NativeClassPtr, "m_Operation");
				LocalizedAsset<TObject>.ConvertToObjectOperation.NativeMethodInfoPtr_Init_Public_Void_AsyncOperationHandle_1_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedAsset<TObject>.ConvertToObjectOperation>.NativeClassPtr, 100663419);
				LocalizedAsset<TObject>.ConvertToObjectOperation.NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedAsset<TObject>.ConvertToObjectOperation>.NativeClassPtr, 100663420);
				LocalizedAsset<TObject>.ConvertToObjectOperation.NativeMethodInfoPtr_OnCompleted_Private_Void_AsyncOperationHandle_1_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedAsset<TObject>.ConvertToObjectOperation>.NativeClassPtr, 100663421);
				LocalizedAsset<TObject>.ConvertToObjectOperation.NativeMethodInfoPtr_Destroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedAsset<TObject>.ConvertToObjectOperation>.NativeClassPtr, 100663422);
				LocalizedAsset<TObject>.ConvertToObjectOperation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedAsset<TObject>.ConvertToObjectOperation>.NativeClassPtr, 100663423);
			}

			// Token: 0x06000CAF RID: 3247 RVA: 0x00038F84 File Offset: 0x00037184
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1065436, RefRangeEnd = 1065437, XrefRangeStart = 1065429, XrefRangeEnd = 1065436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Init(AsyncOperationHandle<TObject> operation)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(operation));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedAsset<TObject>.ConvertToObjectOperation.NativeMethodInfoPtr_Init_Public_Void_AsyncOperationHandle_1_TObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000CB0 RID: 3248 RVA: 0x00038FCC File Offset: 0x000371CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065437, XrefRangeEnd = 1065442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizedAsset<TObject>.ConvertToObjectOperation.NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000CB1 RID: 3249 RVA: 0x00039008 File Offset: 0x00037208
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065442, XrefRangeEnd = 1065447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void OnCompleted(AsyncOperationHandle<TObject> op)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(op));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedAsset<TObject>.ConvertToObjectOperation.NativeMethodInfoPtr_OnCompleted_Private_Void_AsyncOperationHandle_1_TObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000CB2 RID: 3250 RVA: 0x00039050 File Offset: 0x00037250
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065447, XrefRangeEnd = 1065454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Destroy()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizedAsset<TObject>.ConvertToObjectOperation.NativeMethodInfoPtr_Destroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000CB3 RID: 3251 RVA: 0x0003908C File Offset: 0x0003728C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1065457, RefRangeEnd = 1065458, XrefRangeStart = 1065454, XrefRangeEnd = 1065457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ConvertToObjectOperation()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizedAsset<TObject>.ConvertToObjectOperation>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedAsset<TObject>.ConvertToObjectOperation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000CB4 RID: 3252 RVA: 0x0000757E File Offset: 0x0000577E
			public ConvertToObjectOperation(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000372 RID: 882
			// (get) Token: 0x06000CB5 RID: 3253 RVA: 0x000390C8 File Offset: 0x000372C8
			// (set) Token: 0x06000CB6 RID: 3254 RVA: 0x00007587 File Offset: 0x00005787
			public unsafe static ObjectPool<LocalizedAsset<TObject>.ConvertToObjectOperation> Pool
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LocalizedAsset<TObject>.ConvertToObjectOperation.NativeFieldInfoPtr_Pool, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<LocalizedAsset<TObject>.ConvertToObjectOperation>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LocalizedAsset<TObject>.ConvertToObjectOperation.NativeFieldInfoPtr_Pool, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000373 RID: 883
			// (get) Token: 0x06000CB7 RID: 3255 RVA: 0x000390F0 File Offset: 0x000372F0
			// (set) Token: 0x06000CB8 RID: 3256 RVA: 0x00007599 File Offset: 0x00005799
			public AsyncOperationHandle<TObject> m_Operation
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedAsset<TObject>.ConvertToObjectOperation.NativeFieldInfoPtr_m_Operation);
					return new AsyncOperationHandle<TObject>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle<TObject>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedAsset<TObject>.ConvertToObjectOperation.NativeFieldInfoPtr_m_Operation), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle<TObject>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040008D5 RID: 2261
			private static readonly IntPtr NativeFieldInfoPtr_Pool;

			// Token: 0x040008D6 RID: 2262
			private static readonly IntPtr NativeFieldInfoPtr_m_Operation;

			// Token: 0x040008D7 RID: 2263
			private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_AsyncOperationHandle_1_TObject_0;

			// Token: 0x040008D8 RID: 2264
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0;

			// Token: 0x040008D9 RID: 2265
			private static readonly IntPtr NativeMethodInfoPtr_OnCompleted_Private_Void_AsyncOperationHandle_1_TObject_0;

			// Token: 0x040008DA RID: 2266
			private static readonly IntPtr NativeMethodInfoPtr_Destroy_Protected_Virtual_Void_0;

			// Token: 0x040008DB RID: 2267
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0200018E RID: 398
			[ObfuscatedName("UnityEngine.Localization.LocalizedAsset`1+ConvertToObjectOperation+<>c")]
			[Serializable]
			public sealed class __c : Object
			{
				// Token: 0x06001021 RID: 4129 RVA: 0x0004417C File Offset: 0x0004237C
				// Note: this type is marked as 'beforefieldinit'.
				static __c()
				{
					Il2CppClassPointerStore<LocalizedAsset<TObject>.ConvertToObjectOperation.__c>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LocalizedAsset<TObject>.ConvertToObjectOperation>.NativeClassPtr, "<>c"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) })).TypeHandle.value);
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizedAsset<TObject>.ConvertToObjectOperation.__c>.NativeClassPtr);
					LocalizedAsset<TObject>.ConvertToObjectOperation.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedAsset<TObject>.ConvertToObjectOperation.__c>.NativeClassPtr, "<>9");
					LocalizedAsset<TObject>.ConvertToObjectOperation.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedAsset<TObject>.ConvertToObjectOperation.__c>.NativeClassPtr, 100663426);
					LocalizedAsset<TObject>.ConvertToObjectOperation.__c.NativeMethodInfoPtr___cctor_b__7_0_Internal_ConvertToObjectOperation_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedAsset<TObject>.ConvertToObjectOperation.__c>.NativeClassPtr, 100663427);
				}

				// Token: 0x06001022 RID: 4130 RVA: 0x00044220 File Offset: 0x00042420
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizedAsset<TObject>.ConvertToObjectOperation.__c>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedAsset<TObject>.ConvertToObjectOperation.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001023 RID: 4131 RVA: 0x0004425C File Offset: 0x0004245C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065426, XrefRangeEnd = 1065429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe LocalizedAsset<TObject>.ConvertToObjectOperation __cctor_b__7_0()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedAsset<TObject>.ConvertToObjectOperation.__c.NativeMethodInfoPtr___cctor_b__7_0_Internal_ConvertToObjectOperation_TObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalizedAsset<TObject>.ConvertToObjectOperation>(intPtr3) : null;
				}

				// Token: 0x06001024 RID: 4132 RVA: 0x00008CF4 File Offset: 0x00006EF4
				public __c(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000453 RID: 1107
				// (get) Token: 0x06001025 RID: 4133 RVA: 0x0004429C File Offset: 0x0004249C
				// (set) Token: 0x06001026 RID: 4134 RVA: 0x00008CFD File Offset: 0x00006EFD
				public unsafe static LocalizedAsset<TObject>.ConvertToObjectOperation.__c __9
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(LocalizedAsset<TObject>.ConvertToObjectOperation.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizedAsset<TObject>.ConvertToObjectOperation.__c>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(LocalizedAsset<TObject>.ConvertToObjectOperation.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04000B06 RID: 2822
				private static readonly IntPtr NativeFieldInfoPtr___9;

				// Token: 0x04000B07 RID: 2823
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x04000B08 RID: 2824
				private static readonly IntPtr NativeMethodInfoPtr___cctor_b__7_0_Internal_ConvertToObjectOperation_TObject_0;
			}
		}

		// Token: 0x02000112 RID: 274
		private sealed class MethodInfoStoreGeneric_LoadAssetAsync_Public_Virtual_AsyncOperationHandle_1_T_0
		{
			// Token: 0x040008DC RID: 2268
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LocalizedAsset<T>.NativeMethodInfoPtr_LoadAssetAsync_Public_Virtual_AsyncOperationHandle_1_T_0, Il2CppClassPointerStore<LocalizedAsset<T>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
