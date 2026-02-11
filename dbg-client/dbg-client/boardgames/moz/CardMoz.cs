using System;
using boardgames.voodoo;
using dwd.core.match;
using dwd.core.match.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using lotus;
using UnityEngine;
using UnityEngine.EventSystems;

namespace boardgames.moz
{
	// Token: 0x0200010E RID: 270
	public class CardMoz : BaseMoz
	{
		// Token: 0x06000C06 RID: 3078 RVA: 0x00043A30 File Offset: 0x00041C30
		// Note: this type is marked as 'beforefieldinit'.
		static CardMoz()
		{
			Il2CppClassPointerStore<CardMoz>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.moz", "CardMoz");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardMoz>.NativeClassPtr);
			CardMoz.NativeFieldInfoPtr_mozUnitView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardMoz>.NativeClassPtr, "mozUnitView");
			CardMoz.NativeFieldInfoPtr_overlayCanvasRectT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardMoz>.NativeClassPtr, "overlayCanvasRectT");
			CardMoz.NativeFieldInfoPtr_unitProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardMoz>.NativeClassPtr, "unitProvider");
			CardMoz.NativeFieldInfoPtr_offsetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardMoz>.NativeClassPtr, "offsetPosition");
			CardMoz.NativeFieldInfoPtr_MozContainerPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardMoz>.NativeClassPtr, "MozContainerPrefab");
			CardMoz.NativeFieldInfoPtr_MozContainerPrefabPhone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardMoz>.NativeClassPtr, "MozContainerPrefabPhone");
			CardMoz.NativeFieldInfoPtr_mozContainerInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardMoz>.NativeClassPtr, "mozContainerInstance");
			CardMoz.NativeFieldInfoPtr_poolManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardMoz>.NativeClassPtr, "poolManager");
			CardMoz.NativeFieldInfoPtr_entitiesProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardMoz>.NativeClassPtr, "entitiesProvider");
			CardMoz.NativeFieldInfoPtr_useOffsetMozContainers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardMoz>.NativeClassPtr, "useOffsetMozContainers");
			CardMoz.NativeFieldInfoPtr_leftMozContainerPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardMoz>.NativeClassPtr, "leftMozContainerPrefab");
			CardMoz.NativeFieldInfoPtr_rightMozContainerPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardMoz>.NativeClassPtr, "rightMozContainerPrefab");
			CardMoz.NativeMethodInfoPtr_Reset_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardMoz>.NativeClassPtr, 100665083);
			CardMoz.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardMoz>.NativeClassPtr, 100665084);
			CardMoz.NativeMethodInfoPtr_getUnitViewData_Protected_Virtual_New_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardMoz>.NativeClassPtr, 100665085);
			CardMoz.NativeMethodInfoPtr_invokePrepareToMoz_Protected_Virtual_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardMoz>.NativeClassPtr, 100665086);
			CardMoz.NativeMethodInfoPtr_initMoz_Protected_Virtual_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardMoz>.NativeClassPtr, 100665087);
			CardMoz.NativeMethodInfoPtr_GetMozContainerPrefabForInputPosition_Private_GameObject_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardMoz>.NativeClassPtr, 100665088);
			CardMoz.NativeMethodInfoPtr_getMozUnitViewFlavors_Protected_Virtual_New_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardMoz>.NativeClassPtr, 100665089);
			CardMoz.NativeMethodInfoPtr_updateMoz_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardMoz>.NativeClassPtr, 100665090);
			CardMoz.NativeMethodInfoPtr_endMoz_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardMoz>.NativeClassPtr, 100665091);
			CardMoz.NativeMethodInfoPtr_ignoreInitMoz_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardMoz>.NativeClassPtr, 100665092);
			CardMoz.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardMoz>.NativeClassPtr, 100665093);
		}

		// Token: 0x06000C07 RID: 3079 RVA: 0x00043C2C File Offset: 0x00041E2C
		[CallerCount(0)]
		public unsafe override void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CardMoz.NativeMethodInfoPtr_Reset_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C08 RID: 3080 RVA: 0x00043C68 File Offset: 0x00041E68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509370, XrefRangeEnd = 509386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardMoz.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C09 RID: 3081 RVA: 0x00043C9C File Offset: 0x00041E9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509386, XrefRangeEnd = 509400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual EntityComponent getUnitViewData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CardMoz.NativeMethodInfoPtr_getUnitViewData_Protected_Virtual_New_EntityComponent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr3) : null;
		}

		// Token: 0x06000C0A RID: 3082 RVA: 0x00043CE8 File Offset: 0x00041EE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509400, XrefRangeEnd = 509403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void invokePrepareToMoz(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CardMoz.NativeMethodInfoPtr_invokePrepareToMoz_Protected_Virtual_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C0B RID: 3083 RVA: 0x00043D38 File Offset: 0x00041F38
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 509466, RefRangeEnd = 509470, XrefRangeStart = 509403, XrefRangeEnd = 509466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initMoz(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CardMoz.NativeMethodInfoPtr_initMoz_Protected_Virtual_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C0C RID: 3084 RVA: 0x00043D88 File Offset: 0x00041F88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509470, XrefRangeEnd = 509472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameObject GetMozContainerPrefabForInputPosition(Vector2 mozPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mozPosition;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardMoz.NativeMethodInfoPtr_GetMozContainerPrefabForInputPosition_Private_GameObject_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x06000C0D RID: 3085 RVA: 0x00043DD4 File Offset: 0x00041FD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509472, XrefRangeEnd = 509480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppStringArray getMozUnitViewFlavors()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CardMoz.NativeMethodInfoPtr_getMozUnitViewFlavors_Protected_Virtual_New_Il2CppStringArray_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x06000C0E RID: 3086 RVA: 0x00043E20 File Offset: 0x00042020
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void updateMoz()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CardMoz.NativeMethodInfoPtr_updateMoz_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C0F RID: 3087 RVA: 0x00043E5C File Offset: 0x0004205C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 509495, RefRangeEnd = 509496, XrefRangeStart = 509480, XrefRangeEnd = 509495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void endMoz()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CardMoz.NativeMethodInfoPtr_endMoz_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C10 RID: 3088 RVA: 0x00043E98 File Offset: 0x00042098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509496, XrefRangeEnd = 509497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ignoreInitMoz()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CardMoz.NativeMethodInfoPtr_ignoreInitMoz_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C11 RID: 3089 RVA: 0x00043EE0 File Offset: 0x000420E0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 509502, RefRangeEnd = 509507, XrefRangeStart = 509497, XrefRangeEnd = 509502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CardMoz()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardMoz>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardMoz.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C12 RID: 3090 RVA: 0x00007C44 File Offset: 0x00005E44
		public CardMoz(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x06000C13 RID: 3091 RVA: 0x00043F1C File Offset: 0x0004211C
		// (set) Token: 0x06000C14 RID: 3092 RVA: 0x00007C4D File Offset: 0x00005E4D
		public unsafe UnitView mozUnitView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardMoz.NativeFieldInfoPtr_mozUnitView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnitView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardMoz.NativeFieldInfoPtr_mozUnitView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x06000C15 RID: 3093 RVA: 0x00043F4C File Offset: 0x0004214C
		// (set) Token: 0x06000C16 RID: 3094 RVA: 0x00007C6C File Offset: 0x00005E6C
		public unsafe RectTransform overlayCanvasRectT
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardMoz.NativeFieldInfoPtr_overlayCanvasRectT);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardMoz.NativeFieldInfoPtr_overlayCanvasRectT), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06000C17 RID: 3095 RVA: 0x00043F7C File Offset: 0x0004217C
		// (set) Token: 0x06000C18 RID: 3096 RVA: 0x00007C8B File Offset: 0x00005E8B
		public unsafe FlavoredUnitViewProvider unitProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardMoz.NativeFieldInfoPtr_unitProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FlavoredUnitViewProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardMoz.NativeFieldInfoPtr_unitProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x06000C19 RID: 3097 RVA: 0x00043FAC File Offset: 0x000421AC
		// (set) Token: 0x06000C1A RID: 3098 RVA: 0x00007CAA File Offset: 0x00005EAA
		public unsafe Vector3 offsetPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardMoz.NativeFieldInfoPtr_offsetPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardMoz.NativeFieldInfoPtr_offsetPosition)) = value;
			}
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06000C1B RID: 3099 RVA: 0x00043FD4 File Offset: 0x000421D4
		// (set) Token: 0x06000C1C RID: 3100 RVA: 0x00007CC5 File Offset: 0x00005EC5
		public unsafe GameObject MozContainerPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardMoz.NativeFieldInfoPtr_MozContainerPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardMoz.NativeFieldInfoPtr_MozContainerPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06000C1D RID: 3101 RVA: 0x00044004 File Offset: 0x00042204
		// (set) Token: 0x06000C1E RID: 3102 RVA: 0x00007CE4 File Offset: 0x00005EE4
		public unsafe GameObject MozContainerPrefabPhone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardMoz.NativeFieldInfoPtr_MozContainerPrefabPhone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardMoz.NativeFieldInfoPtr_MozContainerPrefabPhone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06000C1F RID: 3103 RVA: 0x00044034 File Offset: 0x00042234
		// (set) Token: 0x06000C20 RID: 3104 RVA: 0x00007D03 File Offset: 0x00005F03
		public unsafe GameObject mozContainerInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardMoz.NativeFieldInfoPtr_mozContainerInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardMoz.NativeFieldInfoPtr_mozContainerInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06000C21 RID: 3105 RVA: 0x00044064 File Offset: 0x00042264
		// (set) Token: 0x06000C22 RID: 3106 RVA: 0x00007D22 File Offset: 0x00005F22
		public unsafe PoolManager poolManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardMoz.NativeFieldInfoPtr_poolManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PoolManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardMoz.NativeFieldInfoPtr_poolManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06000C23 RID: 3107 RVA: 0x00044094 File Offset: 0x00042294
		// (set) Token: 0x06000C24 RID: 3108 RVA: 0x00007D41 File Offset: 0x00005F41
		public unsafe EntitiesProvider entitiesProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardMoz.NativeFieldInfoPtr_entitiesProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntitiesProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardMoz.NativeFieldInfoPtr_entitiesProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06000C25 RID: 3109 RVA: 0x000440C4 File Offset: 0x000422C4
		// (set) Token: 0x06000C26 RID: 3110 RVA: 0x00007D60 File Offset: 0x00005F60
		public unsafe bool useOffsetMozContainers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardMoz.NativeFieldInfoPtr_useOffsetMozContainers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardMoz.NativeFieldInfoPtr_useOffsetMozContainers)) = value;
			}
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06000C27 RID: 3111 RVA: 0x000440EC File Offset: 0x000422EC
		// (set) Token: 0x06000C28 RID: 3112 RVA: 0x00007D7B File Offset: 0x00005F7B
		public unsafe GameObject leftMozContainerPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardMoz.NativeFieldInfoPtr_leftMozContainerPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardMoz.NativeFieldInfoPtr_leftMozContainerPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06000C29 RID: 3113 RVA: 0x0004411C File Offset: 0x0004231C
		// (set) Token: 0x06000C2A RID: 3114 RVA: 0x00007D9A File Offset: 0x00005F9A
		public unsafe GameObject rightMozContainerPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardMoz.NativeFieldInfoPtr_rightMozContainerPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardMoz.NativeFieldInfoPtr_rightMozContainerPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400076C RID: 1900
		private static readonly IntPtr NativeFieldInfoPtr_mozUnitView;

		// Token: 0x0400076D RID: 1901
		private static readonly IntPtr NativeFieldInfoPtr_overlayCanvasRectT;

		// Token: 0x0400076E RID: 1902
		private static readonly IntPtr NativeFieldInfoPtr_unitProvider;

		// Token: 0x0400076F RID: 1903
		private static readonly IntPtr NativeFieldInfoPtr_offsetPosition;

		// Token: 0x04000770 RID: 1904
		private static readonly IntPtr NativeFieldInfoPtr_MozContainerPrefab;

		// Token: 0x04000771 RID: 1905
		private static readonly IntPtr NativeFieldInfoPtr_MozContainerPrefabPhone;

		// Token: 0x04000772 RID: 1906
		private static readonly IntPtr NativeFieldInfoPtr_mozContainerInstance;

		// Token: 0x04000773 RID: 1907
		private static readonly IntPtr NativeFieldInfoPtr_poolManager;

		// Token: 0x04000774 RID: 1908
		private static readonly IntPtr NativeFieldInfoPtr_entitiesProvider;

		// Token: 0x04000775 RID: 1909
		private static readonly IntPtr NativeFieldInfoPtr_useOffsetMozContainers;

		// Token: 0x04000776 RID: 1910
		private static readonly IntPtr NativeFieldInfoPtr_leftMozContainerPrefab;

		// Token: 0x04000777 RID: 1911
		private static readonly IntPtr NativeFieldInfoPtr_rightMozContainerPrefab;

		// Token: 0x04000778 RID: 1912
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Protected_Virtual_Void_0;

		// Token: 0x04000779 RID: 1913
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400077A RID: 1914
		private static readonly IntPtr NativeMethodInfoPtr_getUnitViewData_Protected_Virtual_New_EntityComponent_0;

		// Token: 0x0400077B RID: 1915
		private static readonly IntPtr NativeMethodInfoPtr_invokePrepareToMoz_Protected_Virtual_Void_PointerEventData_0;

		// Token: 0x0400077C RID: 1916
		private static readonly IntPtr NativeMethodInfoPtr_initMoz_Protected_Virtual_Void_PointerEventData_0;

		// Token: 0x0400077D RID: 1917
		private static readonly IntPtr NativeMethodInfoPtr_GetMozContainerPrefabForInputPosition_Private_GameObject_Vector2_0;

		// Token: 0x0400077E RID: 1918
		private static readonly IntPtr NativeMethodInfoPtr_getMozUnitViewFlavors_Protected_Virtual_New_Il2CppStringArray_0;

		// Token: 0x0400077F RID: 1919
		private static readonly IntPtr NativeMethodInfoPtr_updateMoz_Protected_Virtual_Void_0;

		// Token: 0x04000780 RID: 1920
		private static readonly IntPtr NativeMethodInfoPtr_endMoz_Protected_Virtual_Void_0;

		// Token: 0x04000781 RID: 1921
		private static readonly IntPtr NativeMethodInfoPtr_ignoreInitMoz_Protected_Virtual_New_Boolean_0;

		// Token: 0x04000782 RID: 1922
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
