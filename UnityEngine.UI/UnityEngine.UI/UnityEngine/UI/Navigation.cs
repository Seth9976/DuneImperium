using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UI
{
	// Token: 0x02000030 RID: 48
	[Serializable]
	public sealed class Navigation : ValueType
	{
		// Token: 0x0600054A RID: 1354 RVA: 0x0001BA7C File Offset: 0x00019C7C
		// Note: this type is marked as 'beforefieldinit'.
		static Navigation()
		{
			Il2CppClassPointerStore<Navigation>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "Navigation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Navigation>.NativeClassPtr);
			Navigation.NativeFieldInfoPtr_m_Mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Navigation>.NativeClassPtr, "m_Mode");
			Navigation.NativeFieldInfoPtr_m_WrapAround = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Navigation>.NativeClassPtr, "m_WrapAround");
			Navigation.NativeFieldInfoPtr_m_SelectOnUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Navigation>.NativeClassPtr, "m_SelectOnUp");
			Navigation.NativeFieldInfoPtr_m_SelectOnDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Navigation>.NativeClassPtr, "m_SelectOnDown");
			Navigation.NativeFieldInfoPtr_m_SelectOnLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Navigation>.NativeClassPtr, "m_SelectOnLeft");
			Navigation.NativeFieldInfoPtr_m_SelectOnRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Navigation>.NativeClassPtr, "m_SelectOnRight");
			Navigation.NativeMethodInfoPtr_get_mode_Public_get_Mode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Navigation>.NativeClassPtr, 100664166);
			Navigation.NativeMethodInfoPtr_set_mode_Public_set_Void_Mode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Navigation>.NativeClassPtr, 100664167);
			Navigation.NativeMethodInfoPtr_get_wrapAround_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Navigation>.NativeClassPtr, 100664168);
			Navigation.NativeMethodInfoPtr_set_wrapAround_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Navigation>.NativeClassPtr, 100664169);
			Navigation.NativeMethodInfoPtr_get_selectOnUp_Public_get_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Navigation>.NativeClassPtr, 100664170);
			Navigation.NativeMethodInfoPtr_set_selectOnUp_Public_set_Void_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Navigation>.NativeClassPtr, 100664171);
			Navigation.NativeMethodInfoPtr_get_selectOnDown_Public_get_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Navigation>.NativeClassPtr, 100664172);
			Navigation.NativeMethodInfoPtr_set_selectOnDown_Public_set_Void_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Navigation>.NativeClassPtr, 100664173);
			Navigation.NativeMethodInfoPtr_get_selectOnLeft_Public_get_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Navigation>.NativeClassPtr, 100664174);
			Navigation.NativeMethodInfoPtr_set_selectOnLeft_Public_set_Void_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Navigation>.NativeClassPtr, 100664175);
			Navigation.NativeMethodInfoPtr_get_selectOnRight_Public_get_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Navigation>.NativeClassPtr, 100664176);
			Navigation.NativeMethodInfoPtr_set_selectOnRight_Public_set_Void_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Navigation>.NativeClassPtr, 100664177);
			Navigation.NativeMethodInfoPtr_get_defaultNavigation_Public_Static_get_Navigation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Navigation>.NativeClassPtr, 100664178);
			Navigation.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Navigation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Navigation>.NativeClassPtr, 100664179);
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x0600054B RID: 1355 RVA: 0x0001BC3C File Offset: 0x00019E3C
		// (set) Token: 0x0600054C RID: 1356 RVA: 0x0001BC80 File Offset: 0x00019E80
		public unsafe Navigation.Mode mode
		{
			[CallerCount(200)]
			[CachedScanResults(RefRangeStart = 306429, RefRangeEnd = 306629, XrefRangeStart = 306429, XrefRangeEnd = 306629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Navigation.NativeMethodInfoPtr_get_mode_Public_get_Mode_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 320163, RefRangeEnd = 320170, XrefRangeStart = 320163, XrefRangeEnd = 320170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Navigation.NativeMethodInfoPtr_set_mode_Public_set_Void_Mode_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x0600054D RID: 1357 RVA: 0x0001BCC4 File Offset: 0x00019EC4
		// (set) Token: 0x0600054E RID: 1358 RVA: 0x0001BD08 File Offset: 0x00019F08
		public unsafe bool wrapAround
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Navigation.NativeMethodInfoPtr_get_wrapAround_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 685122, RefRangeEnd = 685123, XrefRangeStart = 685122, XrefRangeEnd = 685123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Navigation.NativeMethodInfoPtr_set_wrapAround_Public_set_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x0600054F RID: 1359 RVA: 0x0001BD4C File Offset: 0x00019F4C
		// (set) Token: 0x06000550 RID: 1360 RVA: 0x0001BD90 File Offset: 0x00019F90
		public unsafe Selectable selectOnUp
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 306629, RefRangeEnd = 306630, XrefRangeStart = 306629, XrefRangeEnd = 306630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Navigation.NativeMethodInfoPtr_get_selectOnUp_Public_get_Selectable_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 315685, RefRangeEnd = 315686, XrefRangeStart = 315685, XrefRangeEnd = 315686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Navigation.NativeMethodInfoPtr_set_selectOnUp_Public_set_Void_Selectable_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06000551 RID: 1361 RVA: 0x0001BDD8 File Offset: 0x00019FD8
		// (set) Token: 0x06000552 RID: 1362 RVA: 0x0001BE1C File Offset: 0x0001A01C
		public unsafe Selectable selectOnDown
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Navigation.NativeMethodInfoPtr_get_selectOnDown_Public_get_Selectable_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Navigation.NativeMethodInfoPtr_set_selectOnDown_Public_set_Void_Selectable_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x06000553 RID: 1363 RVA: 0x0001BE64 File Offset: 0x0001A064
		// (set) Token: 0x06000554 RID: 1364 RVA: 0x0001BEA8 File Offset: 0x0001A0A8
		public unsafe Selectable selectOnLeft
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Navigation.NativeMethodInfoPtr_get_selectOnLeft_Public_get_Selectable_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Navigation.NativeMethodInfoPtr_set_selectOnLeft_Public_set_Void_Selectable_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06000555 RID: 1365 RVA: 0x0001BEF0 File Offset: 0x0001A0F0
		// (set) Token: 0x06000556 RID: 1366 RVA: 0x0001BF34 File Offset: 0x0001A134
		public unsafe Selectable selectOnRight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Navigation.NativeMethodInfoPtr_get_selectOnRight_Public_get_Selectable_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Navigation.NativeMethodInfoPtr_set_selectOnRight_Public_set_Void_Selectable_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x06000557 RID: 1367 RVA: 0x0001BF7C File Offset: 0x0001A17C
		public unsafe static Navigation defaultNavigation
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1090241, RefRangeEnd = 1090243, XrefRangeStart = 1090241, XrefRangeEnd = 1090241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Navigation.NativeMethodInfoPtr_get_defaultNavigation_Public_Static_get_Navigation_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Navigation(intPtr);
			}
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x0001BFA8 File Offset: 0x0001A1A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1090243, XrefRangeEnd = 1090256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(Navigation other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Navigation.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Navigation_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x00003C9B File Offset: 0x00001E9B
		public Navigation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x00003CA4 File Offset: 0x00001EA4
		public Navigation()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Navigation>.NativeClassPtr))
		{
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x0600055B RID: 1371 RVA: 0x0001C000 File Offset: 0x0001A200
		// (set) Token: 0x0600055C RID: 1372 RVA: 0x00003CB6 File Offset: 0x00001EB6
		public unsafe Navigation.Mode m_Mode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Navigation.NativeFieldInfoPtr_m_Mode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Navigation.NativeFieldInfoPtr_m_Mode)) = value;
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x0600055D RID: 1373 RVA: 0x0001C028 File Offset: 0x0001A228
		// (set) Token: 0x0600055E RID: 1374 RVA: 0x00003CD1 File Offset: 0x00001ED1
		public unsafe bool m_WrapAround
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Navigation.NativeFieldInfoPtr_m_WrapAround);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Navigation.NativeFieldInfoPtr_m_WrapAround)) = value;
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x0600055F RID: 1375 RVA: 0x0001C050 File Offset: 0x0001A250
		// (set) Token: 0x06000560 RID: 1376 RVA: 0x00003CEC File Offset: 0x00001EEC
		public unsafe Selectable m_SelectOnUp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Navigation.NativeFieldInfoPtr_m_SelectOnUp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Navigation.NativeFieldInfoPtr_m_SelectOnUp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06000561 RID: 1377 RVA: 0x0001C080 File Offset: 0x0001A280
		// (set) Token: 0x06000562 RID: 1378 RVA: 0x00003D0B File Offset: 0x00001F0B
		public unsafe Selectable m_SelectOnDown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Navigation.NativeFieldInfoPtr_m_SelectOnDown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Navigation.NativeFieldInfoPtr_m_SelectOnDown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000563 RID: 1379 RVA: 0x0001C0B0 File Offset: 0x0001A2B0
		// (set) Token: 0x06000564 RID: 1380 RVA: 0x00003D2A File Offset: 0x00001F2A
		public unsafe Selectable m_SelectOnLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Navigation.NativeFieldInfoPtr_m_SelectOnLeft);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Navigation.NativeFieldInfoPtr_m_SelectOnLeft), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06000565 RID: 1381 RVA: 0x0001C0E0 File Offset: 0x0001A2E0
		// (set) Token: 0x06000566 RID: 1382 RVA: 0x00003D49 File Offset: 0x00001F49
		public unsafe Selectable m_SelectOnRight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Navigation.NativeFieldInfoPtr_m_SelectOnRight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Navigation.NativeFieldInfoPtr_m_SelectOnRight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400040C RID: 1036
		private static readonly IntPtr NativeFieldInfoPtr_m_Mode;

		// Token: 0x0400040D RID: 1037
		private static readonly IntPtr NativeFieldInfoPtr_m_WrapAround;

		// Token: 0x0400040E RID: 1038
		private static readonly IntPtr NativeFieldInfoPtr_m_SelectOnUp;

		// Token: 0x0400040F RID: 1039
		private static readonly IntPtr NativeFieldInfoPtr_m_SelectOnDown;

		// Token: 0x04000410 RID: 1040
		private static readonly IntPtr NativeFieldInfoPtr_m_SelectOnLeft;

		// Token: 0x04000411 RID: 1041
		private static readonly IntPtr NativeFieldInfoPtr_m_SelectOnRight;

		// Token: 0x04000412 RID: 1042
		private static readonly IntPtr NativeMethodInfoPtr_get_mode_Public_get_Mode_0;

		// Token: 0x04000413 RID: 1043
		private static readonly IntPtr NativeMethodInfoPtr_set_mode_Public_set_Void_Mode_0;

		// Token: 0x04000414 RID: 1044
		private static readonly IntPtr NativeMethodInfoPtr_get_wrapAround_Public_get_Boolean_0;

		// Token: 0x04000415 RID: 1045
		private static readonly IntPtr NativeMethodInfoPtr_set_wrapAround_Public_set_Void_Boolean_0;

		// Token: 0x04000416 RID: 1046
		private static readonly IntPtr NativeMethodInfoPtr_get_selectOnUp_Public_get_Selectable_0;

		// Token: 0x04000417 RID: 1047
		private static readonly IntPtr NativeMethodInfoPtr_set_selectOnUp_Public_set_Void_Selectable_0;

		// Token: 0x04000418 RID: 1048
		private static readonly IntPtr NativeMethodInfoPtr_get_selectOnDown_Public_get_Selectable_0;

		// Token: 0x04000419 RID: 1049
		private static readonly IntPtr NativeMethodInfoPtr_set_selectOnDown_Public_set_Void_Selectable_0;

		// Token: 0x0400041A RID: 1050
		private static readonly IntPtr NativeMethodInfoPtr_get_selectOnLeft_Public_get_Selectable_0;

		// Token: 0x0400041B RID: 1051
		private static readonly IntPtr NativeMethodInfoPtr_set_selectOnLeft_Public_set_Void_Selectable_0;

		// Token: 0x0400041C RID: 1052
		private static readonly IntPtr NativeMethodInfoPtr_get_selectOnRight_Public_get_Selectable_0;

		// Token: 0x0400041D RID: 1053
		private static readonly IntPtr NativeMethodInfoPtr_set_selectOnRight_Public_set_Void_Selectable_0;

		// Token: 0x0400041E RID: 1054
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultNavigation_Public_Static_get_Navigation_0;

		// Token: 0x0400041F RID: 1055
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Navigation_0;

		// Token: 0x020000A8 RID: 168
		[Flags]
		public enum Mode
		{
			// Token: 0x040009D4 RID: 2516
			None = 0,
			// Token: 0x040009D5 RID: 2517
			Horizontal = 1,
			// Token: 0x040009D6 RID: 2518
			Vertical = 2,
			// Token: 0x040009D7 RID: 2519
			Automatic = 3,
			// Token: 0x040009D8 RID: 2520
			Explicit = 4
		}
	}
}
