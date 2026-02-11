using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine.Localization.PropertyVariants.TrackedObjects;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.Localization.PropertyVariants
{
	// Token: 0x020000E0 RID: 224
	public class GameObjectLocalizer : MonoBehaviour
	{
		// Token: 0x06000B4D RID: 2893 RVA: 0x00033D5C File Offset: 0x00031F5C
		// Note: this type is marked as 'beforefieldinit'.
		static GameObjectLocalizer()
		{
			Il2CppClassPointerStore<GameObjectLocalizer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.PropertyVariants", "GameObjectLocalizer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameObjectLocalizer>.NativeClassPtr);
			GameObjectLocalizer.NativeFieldInfoPtr_m_TrackedObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameObjectLocalizer>.NativeClassPtr, "m_TrackedObjects");
			GameObjectLocalizer.NativeFieldInfoPtr_m_CurrentLocale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameObjectLocalizer>.NativeClassPtr, "m_CurrentLocale");
			GameObjectLocalizer.NativeFieldInfoPtr_m_LocalizedStringChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameObjectLocalizer>.NativeClassPtr, "m_LocalizedStringChanged");
			GameObjectLocalizer.NativeFieldInfoPtr_m_IgnoreChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameObjectLocalizer>.NativeClassPtr, "m_IgnoreChange");
			GameObjectLocalizer.NativeFieldInfoPtr__CurrentOperation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameObjectLocalizer>.NativeClassPtr, "<CurrentOperation>k__BackingField");
			GameObjectLocalizer.NativeMethodInfoPtr_get_CurrentOperation_Internal_get_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectLocalizer>.NativeClassPtr, 100665170);
			GameObjectLocalizer.NativeMethodInfoPtr_set_CurrentOperation_Private_set_Void_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectLocalizer>.NativeClassPtr, 100665171);
			GameObjectLocalizer.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectLocalizer>.NativeClassPtr, 100665172);
			GameObjectLocalizer.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectLocalizer>.NativeClassPtr, 100665173);
			GameObjectLocalizer.NativeMethodInfoPtr_Start_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectLocalizer>.NativeClassPtr, 100665174);
			GameObjectLocalizer.NativeMethodInfoPtr_SelectedLocaleChanged_Private_Void_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectLocalizer>.NativeClassPtr, 100665175);
			GameObjectLocalizer.NativeMethodInfoPtr_get_TrackedObjects_Public_get_List_1_TrackedObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectLocalizer>.NativeClassPtr, 100665176);
			GameObjectLocalizer.NativeMethodInfoPtr_GetTrackedObject_Public_T_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectLocalizer>.NativeClassPtr, 100665177);
			GameObjectLocalizer.NativeMethodInfoPtr_GetTrackedObject_Public_TrackedObject_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectLocalizer>.NativeClassPtr, 100665178);
			GameObjectLocalizer.NativeMethodInfoPtr_ApplyLocaleVariant_Public_AsyncOperationHandle_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectLocalizer>.NativeClassPtr, 100665179);
			GameObjectLocalizer.NativeMethodInfoPtr_ApplyLocaleVariant_Public_AsyncOperationHandle_Locale_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectLocalizer>.NativeClassPtr, 100665180);
			GameObjectLocalizer.NativeMethodInfoPtr_RegisterChanges_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectLocalizer>.NativeClassPtr, 100665181);
			GameObjectLocalizer.NativeMethodInfoPtr_UnregisterChanges_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectLocalizer>.NativeClassPtr, 100665182);
			GameObjectLocalizer.NativeMethodInfoPtr_RequestUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectLocalizer>.NativeClassPtr, 100665183);
			GameObjectLocalizer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectLocalizer>.NativeClassPtr, 100665184);
			GameObjectLocalizer.NativeMethodInfoPtr__RegisterChanges_b__18_0_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectLocalizer>.NativeClassPtr, 100665185);
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x06000B4E RID: 2894 RVA: 0x00033F30 File Offset: 0x00032130
		// (set) Token: 0x06000B4F RID: 2895 RVA: 0x00033F68 File Offset: 0x00032168
		public unsafe AsyncOperationHandle CurrentOperation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectLocalizer.NativeMethodInfoPtr_get_CurrentOperation_Internal_get_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new AsyncOperationHandle(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectLocalizer.NativeMethodInfoPtr_set_CurrentOperation_Private_set_Void_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000B50 RID: 2896 RVA: 0x00033FB0 File Offset: 0x000321B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079398, XrefRangeEnd = 1079412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectLocalizer.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B51 RID: 2897 RVA: 0x00033FE4 File Offset: 0x000321E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079412, XrefRangeEnd = 1079422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectLocalizer.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B52 RID: 2898 RVA: 0x00034018 File Offset: 0x00032218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079422, XrefRangeEnd = 1079427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectLocalizer.NativeMethodInfoPtr_Start_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x00034058 File Offset: 0x00032258
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1079434, RefRangeEnd = 1079435, XrefRangeStart = 1079427, XrefRangeEnd = 1079434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectedLocaleChanged(Locale locale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(locale);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectLocalizer.NativeMethodInfoPtr_SelectedLocaleChanged_Private_Void_Locale_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x06000B54 RID: 2900 RVA: 0x0003409C File Offset: 0x0003229C
		public unsafe List<TrackedObject> TrackedObjects
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectLocalizer.NativeMethodInfoPtr_get_TrackedObjects_Public_get_List_1_TrackedObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<TrackedObject>>(intPtr3) : null;
			}
		}

		// Token: 0x06000B55 RID: 2901 RVA: 0x000340DC File Offset: 0x000322DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079435, XrefRangeEnd = 1079456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetTrackedObject<T>(Object target, bool create = true) where T : TrackedObject, new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref create;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectLocalizer.MethodInfoStoreGeneric_GetTrackedObject_Public_T_Object_Boolean_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06000B56 RID: 2902 RVA: 0x00034134 File Offset: 0x00032334
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1079474, RefRangeEnd = 1079475, XrefRangeStart = 1079456, XrefRangeEnd = 1079474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrackedObject GetTrackedObject(Object target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectLocalizer.NativeMethodInfoPtr_GetTrackedObject_Public_TrackedObject_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TrackedObject>(intPtr3) : null;
			}
		}

		// Token: 0x06000B57 RID: 2903 RVA: 0x00034184 File Offset: 0x00032384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079475, XrefRangeEnd = 1079477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle ApplyLocaleVariant(Locale locale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(locale);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectLocalizer.NativeMethodInfoPtr_ApplyLocaleVariant_Public_AsyncOperationHandle_Locale_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new AsyncOperationHandle(intPtr);
			}
		}

		// Token: 0x06000B58 RID: 2904 RVA: 0x000341CC File Offset: 0x000323CC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1079535, RefRangeEnd = 1079539, XrefRangeStart = 1079477, XrefRangeEnd = 1079535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle ApplyLocaleVariant(Locale locale, Locale fallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(locale);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectLocalizer.NativeMethodInfoPtr_ApplyLocaleVariant_Public_AsyncOperationHandle_Locale_Locale_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle(intPtr);
		}

		// Token: 0x06000B59 RID: 2905 RVA: 0x00034228 File Offset: 0x00032428
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1079580, RefRangeEnd = 1079581, XrefRangeStart = 1079539, XrefRangeEnd = 1079580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterChanges()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectLocalizer.NativeMethodInfoPtr_RegisterChanges_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B5A RID: 2906 RVA: 0x0003425C File Offset: 0x0003245C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1079615, RefRangeEnd = 1079616, XrefRangeStart = 1079581, XrefRangeEnd = 1079615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnregisterChanges()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectLocalizer.NativeMethodInfoPtr_UnregisterChanges_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B5B RID: 2907 RVA: 0x00034290 File Offset: 0x00032490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079616, XrefRangeEnd = 1079621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RequestUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectLocalizer.NativeMethodInfoPtr_RequestUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B5C RID: 2908 RVA: 0x000342C4 File Offset: 0x000324C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079621, XrefRangeEnd = 1079629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameObjectLocalizer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameObjectLocalizer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectLocalizer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B5D RID: 2909 RVA: 0x00034300 File Offset: 0x00032500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _RegisterChanges_b__18_0(string _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectLocalizer.NativeMethodInfoPtr__RegisterChanges_b__18_0_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B5E RID: 2910 RVA: 0x00006B48 File Offset: 0x00004D48
		public GameObjectLocalizer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06000B5F RID: 2911 RVA: 0x00034344 File Offset: 0x00032544
		// (set) Token: 0x06000B60 RID: 2912 RVA: 0x00006B51 File Offset: 0x00004D51
		public unsafe List<TrackedObject> m_TrackedObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameObjectLocalizer.NativeFieldInfoPtr_m_TrackedObjects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TrackedObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameObjectLocalizer.NativeFieldInfoPtr_m_TrackedObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06000B61 RID: 2913 RVA: 0x00034374 File Offset: 0x00032574
		// (set) Token: 0x06000B62 RID: 2914 RVA: 0x00006B70 File Offset: 0x00004D70
		public unsafe Locale m_CurrentLocale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameObjectLocalizer.NativeFieldInfoPtr_m_CurrentLocale);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Locale>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameObjectLocalizer.NativeFieldInfoPtr_m_CurrentLocale), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x06000B63 RID: 2915 RVA: 0x000343A4 File Offset: 0x000325A4
		// (set) Token: 0x06000B64 RID: 2916 RVA: 0x00006B8F File Offset: 0x00004D8F
		public unsafe LocalizedString.ChangeHandler m_LocalizedStringChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameObjectLocalizer.NativeFieldInfoPtr_m_LocalizedStringChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizedString.ChangeHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameObjectLocalizer.NativeFieldInfoPtr_m_LocalizedStringChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x06000B65 RID: 2917 RVA: 0x000343D4 File Offset: 0x000325D4
		// (set) Token: 0x06000B66 RID: 2918 RVA: 0x00006BAE File Offset: 0x00004DAE
		public unsafe bool m_IgnoreChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameObjectLocalizer.NativeFieldInfoPtr_m_IgnoreChange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameObjectLocalizer.NativeFieldInfoPtr_m_IgnoreChange)) = value;
			}
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06000B67 RID: 2919 RVA: 0x000343FC File Offset: 0x000325FC
		// (set) Token: 0x06000B68 RID: 2920 RVA: 0x00006BC9 File Offset: 0x00004DC9
		public AsyncOperationHandle _CurrentOperation_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameObjectLocalizer.NativeFieldInfoPtr__CurrentOperation_k__BackingField);
				return new AsyncOperationHandle(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameObjectLocalizer.NativeFieldInfoPtr__CurrentOperation_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x040007F3 RID: 2035
		private static readonly IntPtr NativeFieldInfoPtr_m_TrackedObjects;

		// Token: 0x040007F4 RID: 2036
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentLocale;

		// Token: 0x040007F5 RID: 2037
		private static readonly IntPtr NativeFieldInfoPtr_m_LocalizedStringChanged;

		// Token: 0x040007F6 RID: 2038
		private static readonly IntPtr NativeFieldInfoPtr_m_IgnoreChange;

		// Token: 0x040007F7 RID: 2039
		private static readonly IntPtr NativeFieldInfoPtr__CurrentOperation_k__BackingField;

		// Token: 0x040007F8 RID: 2040
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentOperation_Internal_get_AsyncOperationHandle_0;

		// Token: 0x040007F9 RID: 2041
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentOperation_Private_set_Void_AsyncOperationHandle_0;

		// Token: 0x040007FA RID: 2042
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x040007FB RID: 2043
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x040007FC RID: 2044
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_IEnumerator_0;

		// Token: 0x040007FD RID: 2045
		private static readonly IntPtr NativeMethodInfoPtr_SelectedLocaleChanged_Private_Void_Locale_0;

		// Token: 0x040007FE RID: 2046
		private static readonly IntPtr NativeMethodInfoPtr_get_TrackedObjects_Public_get_List_1_TrackedObject_0;

		// Token: 0x040007FF RID: 2047
		private static readonly IntPtr NativeMethodInfoPtr_GetTrackedObject_Public_T_Object_Boolean_0;

		// Token: 0x04000800 RID: 2048
		private static readonly IntPtr NativeMethodInfoPtr_GetTrackedObject_Public_TrackedObject_Object_0;

		// Token: 0x04000801 RID: 2049
		private static readonly IntPtr NativeMethodInfoPtr_ApplyLocaleVariant_Public_AsyncOperationHandle_Locale_0;

		// Token: 0x04000802 RID: 2050
		private static readonly IntPtr NativeMethodInfoPtr_ApplyLocaleVariant_Public_AsyncOperationHandle_Locale_Locale_0;

		// Token: 0x04000803 RID: 2051
		private static readonly IntPtr NativeMethodInfoPtr_RegisterChanges_Private_Void_0;

		// Token: 0x04000804 RID: 2052
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterChanges_Private_Void_0;

		// Token: 0x04000805 RID: 2053
		private static readonly IntPtr NativeMethodInfoPtr_RequestUpdate_Private_Void_0;

		// Token: 0x04000806 RID: 2054
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000807 RID: 2055
		private static readonly IntPtr NativeMethodInfoPtr__RegisterChanges_b__18_0_Private_Void_String_0;

		// Token: 0x0200017F RID: 383
		[ObfuscatedName("UnityEngine.Localization.PropertyVariants.GameObjectLocalizer+<Start>d__10")]
		public sealed class _Start_d__10 : Object
		{
			// Token: 0x06000FC2 RID: 4034 RVA: 0x00043168 File Offset: 0x00041368
			// Note: this type is marked as 'beforefieldinit'.
			static _Start_d__10()
			{
				Il2CppClassPointerStore<GameObjectLocalizer._Start_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameObjectLocalizer>.NativeClassPtr, "<Start>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameObjectLocalizer._Start_d__10>.NativeClassPtr);
				GameObjectLocalizer._Start_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameObjectLocalizer._Start_d__10>.NativeClassPtr, "<>1__state");
				GameObjectLocalizer._Start_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameObjectLocalizer._Start_d__10>.NativeClassPtr, "<>2__current");
				GameObjectLocalizer._Start_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameObjectLocalizer._Start_d__10>.NativeClassPtr, "<>4__this");
				GameObjectLocalizer._Start_d__10.NativeFieldInfoPtr__localeOp_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameObjectLocalizer._Start_d__10>.NativeClassPtr, "<localeOp>5__2");
				GameObjectLocalizer._Start_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectLocalizer._Start_d__10>.NativeClassPtr, 100665186);
				GameObjectLocalizer._Start_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectLocalizer._Start_d__10>.NativeClassPtr, 100665187);
				GameObjectLocalizer._Start_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectLocalizer._Start_d__10>.NativeClassPtr, 100665188);
				GameObjectLocalizer._Start_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectLocalizer._Start_d__10>.NativeClassPtr, 100665189);
				GameObjectLocalizer._Start_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectLocalizer._Start_d__10>.NativeClassPtr, 100665190);
				GameObjectLocalizer._Start_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectLocalizer._Start_d__10>.NativeClassPtr, 100665191);
			}

			// Token: 0x06000FC3 RID: 4035 RVA: 0x0004325C File Offset: 0x0004145C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Start_d__10(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameObjectLocalizer._Start_d__10>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectLocalizer._Start_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000FC4 RID: 4036 RVA: 0x000432A4 File Offset: 0x000414A4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectLocalizer._Start_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000FC5 RID: 4037 RVA: 0x000432D8 File Offset: 0x000414D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079382, XrefRangeEnd = 1079393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectLocalizer._Start_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700043A RID: 1082
			// (get) Token: 0x06000FC6 RID: 4038 RVA: 0x00043314 File Offset: 0x00041514
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectLocalizer._Start_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000FC7 RID: 4039 RVA: 0x00043354 File Offset: 0x00041554
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079393, XrefRangeEnd = 1079398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectLocalizer._Start_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700043B RID: 1083
			// (get) Token: 0x06000FC8 RID: 4040 RVA: 0x00043388 File Offset: 0x00041588
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectLocalizer._Start_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000FC9 RID: 4041 RVA: 0x00008919 File Offset: 0x00006B19
			public _Start_d__10(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000436 RID: 1078
			// (get) Token: 0x06000FCA RID: 4042 RVA: 0x000433C8 File Offset: 0x000415C8
			// (set) Token: 0x06000FCB RID: 4043 RVA: 0x00008922 File Offset: 0x00006B22
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameObjectLocalizer._Start_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameObjectLocalizer._Start_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000437 RID: 1079
			// (get) Token: 0x06000FCC RID: 4044 RVA: 0x000433F0 File Offset: 0x000415F0
			// (set) Token: 0x06000FCD RID: 4045 RVA: 0x0000893D File Offset: 0x00006B3D
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameObjectLocalizer._Start_d__10.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameObjectLocalizer._Start_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000438 RID: 1080
			// (get) Token: 0x06000FCE RID: 4046 RVA: 0x00043420 File Offset: 0x00041620
			// (set) Token: 0x06000FCF RID: 4047 RVA: 0x0000895C File Offset: 0x00006B5C
			public unsafe GameObjectLocalizer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameObjectLocalizer._Start_d__10.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObjectLocalizer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameObjectLocalizer._Start_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000439 RID: 1081
			// (get) Token: 0x06000FD0 RID: 4048 RVA: 0x00043450 File Offset: 0x00041650
			// (set) Token: 0x06000FD1 RID: 4049 RVA: 0x0000897B File Offset: 0x00006B7B
			public AsyncOperationHandle<Locale> _localeOp_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameObjectLocalizer._Start_d__10.NativeFieldInfoPtr__localeOp_5__2);
					return new AsyncOperationHandle<Locale>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle<Locale>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameObjectLocalizer._Start_d__10.NativeFieldInfoPtr__localeOp_5__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle<Locale>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04000AD4 RID: 2772
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000AD5 RID: 2773
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000AD6 RID: 2774
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000AD7 RID: 2775
			private static readonly IntPtr NativeFieldInfoPtr__localeOp_5__2;

			// Token: 0x04000AD8 RID: 2776
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000AD9 RID: 2777
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000ADA RID: 2778
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000ADB RID: 2779
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000ADC RID: 2780
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000ADD RID: 2781
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000180 RID: 384
		private sealed class MethodInfoStoreGeneric_GetTrackedObject_Public_T_Object_Boolean_0<T>
		{
			// Token: 0x04000ADE RID: 2782
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObjectLocalizer.NativeMethodInfoPtr_GetTrackedObject_Public_T_Object_Boolean_0, Il2CppClassPointerStore<GameObjectLocalizer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
