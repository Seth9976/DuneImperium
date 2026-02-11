using System;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using lotus;
using UnityEngine;

namespace dbgclient
{
	// Token: 0x02000085 RID: 133
	public class DBGFanView : ContainerView
	{
		// Token: 0x06000513 RID: 1299 RVA: 0x0002D6D0 File Offset: 0x0002B8D0
		// Note: this type is marked as 'beforefieldinit'.
		static DBGFanView()
		{
			Il2CppClassPointerStore<DBGFanView>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient", "DBGFanView");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGFanView>.NativeClassPtr);
			DBGFanView.NativeFieldInfoPtr_noCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGFanView>.NativeClassPtr, "noCurve");
			DBGFanView.NativeFieldInfoPtr_resolutionDataList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGFanView>.NativeClassPtr, "resolutionDataList");
			DBGFanView.NativeFieldInfoPtr_fallbackData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGFanView>.NativeClassPtr, "fallbackData");
			DBGFanView.NativeFieldInfoPtr_currentData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGFanView>.NativeClassPtr, "currentData");
			DBGFanView.NativeFieldInfoPtr_rectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGFanView>.NativeClassPtr, "rectTransform");
			DBGFanView.NativeFieldInfoPtr_runningSpacingCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGFanView>.NativeClassPtr, "runningSpacingCoroutine");
			DBGFanView.NativeFieldInfoPtr_runningWidthCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGFanView>.NativeClassPtr, "runningWidthCoroutine");
			DBGFanView.NativeMethodInfoPtr_Init_Public_Virtual_Void_EntityComponent_EntityView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGFanView>.NativeClassPtr, 100664057);
			DBGFanView.NativeMethodInfoPtr_setPositionFor_Protected_Void_UnitView_LocalTransform_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGFanView>.NativeClassPtr, 100664058);
			DBGFanView.NativeMethodInfoPtr_LayoutViews_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGFanView>.NativeClassPtr, 100664059);
			DBGFanView.NativeMethodInfoPtr_getFanTransform_Private_LocalTransform_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGFanView>.NativeClassPtr, 100664060);
			DBGFanView.NativeMethodInfoPtr_GetPositionsFor_Public_Virtual_Void_MoveContext_Il2CppStructArray_1_LocalTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGFanView>.NativeClassPtr, 100664061);
			DBGFanView.NativeMethodInfoPtr_OnPrepareToReceiveEntities_Public_Virtual_IEnumerator_MoveContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGFanView>.NativeClassPtr, 100664062);
			DBGFanView.NativeMethodInfoPtr_createSecondaryMoveContext_Protected_MoveContext_Int32_List_1_UnitView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGFanView>.NativeClassPtr, 100664063);
			DBGFanView.NativeMethodInfoPtr_OnEntitiesRemoved_Public_Virtual_IEnumerator_MoveContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGFanView>.NativeClassPtr, 100664064);
			DBGFanView.NativeMethodInfoPtr_SetSpacing_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGFanView>.NativeClassPtr, 100664065);
			DBGFanView.NativeMethodInfoPtr_SetMaxWidth_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGFanView>.NativeClassPtr, 100664066);
			DBGFanView.NativeMethodInfoPtr_LerpHandSpacing_Private_IEnumerator_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGFanView>.NativeClassPtr, 100664067);
			DBGFanView.NativeMethodInfoPtr_LerpHandWidth_Private_IEnumerator_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGFanView>.NativeClassPtr, 100664068);
			DBGFanView.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGFanView>.NativeClassPtr, 100664069);
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x0002D890 File Offset: 0x0002BA90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501469, XrefRangeEnd = 501491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Init(EntityComponent ec, EntityView p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ec);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGFanView.NativeMethodInfoPtr_Init_Public_Virtual_Void_EntityComponent_EntityView_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x0002D8F0 File Offset: 0x0002BAF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501491, XrefRangeEnd = 501493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void setPositionFor(UnitView view, LocalTransform localTransform, Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(view);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref localTransform;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGFanView.NativeMethodInfoPtr_setPositionFor_Protected_Void_UnitView_LocalTransform_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x0002D950 File Offset: 0x0002BB50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 501502, RefRangeEnd = 501503, XrefRangeStart = 501493, XrefRangeEnd = 501502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void LayoutViews()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGFanView.NativeMethodInfoPtr_LayoutViews_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x0002D98C File Offset: 0x0002BB8C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 501521, RefRangeEnd = 501523, XrefRangeStart = 501503, XrefRangeEnd = 501521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalTransform getFanTransform(int index, int total)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref total;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGFanView.NativeMethodInfoPtr_getFanTransform_Private_LocalTransform_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x0002D9E4 File Offset: 0x0002BBE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501523, XrefRangeEnd = 501529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GetPositionsFor(MoveContext context, Il2CppStructArray<LocalTransform> retVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(retVal);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGFanView.NativeMethodInfoPtr_GetPositionsFor_Public_Virtual_Void_MoveContext_Il2CppStructArray_1_LocalTransform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x0002DA44 File Offset: 0x0002BC44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501529, XrefRangeEnd = 501535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnPrepareToReceiveEntities(MoveContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGFanView.NativeMethodInfoPtr_OnPrepareToReceiveEntities_Public_Virtual_IEnumerator_MoveContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x0002DAA0 File Offset: 0x0002BCA0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 501562, RefRangeEnd = 501564, XrefRangeStart = 501535, XrefRangeEnd = 501562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MoveContext createSecondaryMoveContext(int newSize, List<UnitView> mixedViews)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newSize;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mixedViews);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGFanView.NativeMethodInfoPtr_createSecondaryMoveContext_Protected_MoveContext_Int32_List_1_UnitView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MoveContext>(intPtr3) : null;
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x0002DB00 File Offset: 0x0002BD00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501564, XrefRangeEnd = 501570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnEntitiesRemoved(MoveContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGFanView.NativeMethodInfoPtr_OnEntitiesRemoved_Public_Virtual_IEnumerator_MoveContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x0002DB5C File Offset: 0x0002BD5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501570, XrefRangeEnd = 501578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSpacing(float spacing, float duration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref spacing;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGFanView.NativeMethodInfoPtr_SetSpacing_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x0002DBA8 File Offset: 0x0002BDA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501578, XrefRangeEnd = 501586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMaxWidth(float width, float duration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGFanView.NativeMethodInfoPtr_SetMaxWidth_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x0002DBF4 File Offset: 0x0002BDF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501586, XrefRangeEnd = 501591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator LerpHandSpacing(float targetSpacing, float duration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref targetSpacing;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGFanView.NativeMethodInfoPtr_LerpHandSpacing_Private_IEnumerator_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x0002DC50 File Offset: 0x0002BE50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501591, XrefRangeEnd = 501596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator LerpHandWidth(float targetWidth, float duration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref targetWidth;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGFanView.NativeMethodInfoPtr_LerpHandWidth_Private_IEnumerator_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x0002DCAC File Offset: 0x0002BEAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 501604, RefRangeEnd = 501605, XrefRangeStart = 501596, XrefRangeEnd = 501604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DBGFanView()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGFanView>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGFanView.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x000044F9 File Offset: 0x000026F9
		public DBGFanView(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000522 RID: 1314 RVA: 0x0002DCE8 File Offset: 0x0002BEE8
		// (set) Token: 0x06000523 RID: 1315 RVA: 0x00004502 File Offset: 0x00002702
		public unsafe bool noCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGFanView.NativeFieldInfoPtr_noCurve);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGFanView.NativeFieldInfoPtr_noCurve)) = value;
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000524 RID: 1316 RVA: 0x0002DD10 File Offset: 0x0002BF10
		// (set) Token: 0x06000525 RID: 1317 RVA: 0x0000451D File Offset: 0x0000271D
		public unsafe List<FanViewPerResolutionData> resolutionDataList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGFanView.NativeFieldInfoPtr_resolutionDataList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FanViewPerResolutionData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGFanView.NativeFieldInfoPtr_resolutionDataList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x06000526 RID: 1318 RVA: 0x0002DD40 File Offset: 0x0002BF40
		// (set) Token: 0x06000527 RID: 1319 RVA: 0x0000453C File Offset: 0x0000273C
		public unsafe FanViewPerResolutionData fallbackData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGFanView.NativeFieldInfoPtr_fallbackData);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGFanView.NativeFieldInfoPtr_fallbackData)) = value;
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000528 RID: 1320 RVA: 0x0002DD68 File Offset: 0x0002BF68
		// (set) Token: 0x06000529 RID: 1321 RVA: 0x00004557 File Offset: 0x00002757
		public unsafe FanViewPerResolutionData currentData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGFanView.NativeFieldInfoPtr_currentData);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGFanView.NativeFieldInfoPtr_currentData)) = value;
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x0600052A RID: 1322 RVA: 0x0002DD90 File Offset: 0x0002BF90
		// (set) Token: 0x0600052B RID: 1323 RVA: 0x00004572 File Offset: 0x00002772
		public unsafe RectTransform rectTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGFanView.NativeFieldInfoPtr_rectTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGFanView.NativeFieldInfoPtr_rectTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x0600052C RID: 1324 RVA: 0x0002DDC0 File Offset: 0x0002BFC0
		// (set) Token: 0x0600052D RID: 1325 RVA: 0x00004591 File Offset: 0x00002791
		public unsafe Coroutine runningSpacingCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGFanView.NativeFieldInfoPtr_runningSpacingCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGFanView.NativeFieldInfoPtr_runningSpacingCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x0600052E RID: 1326 RVA: 0x0002DDF0 File Offset: 0x0002BFF0
		// (set) Token: 0x0600052F RID: 1327 RVA: 0x000045B0 File Offset: 0x000027B0
		public unsafe Coroutine runningWidthCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGFanView.NativeFieldInfoPtr_runningWidthCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGFanView.NativeFieldInfoPtr_runningWidthCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400031D RID: 797
		private static readonly IntPtr NativeFieldInfoPtr_noCurve;

		// Token: 0x0400031E RID: 798
		private static readonly IntPtr NativeFieldInfoPtr_resolutionDataList;

		// Token: 0x0400031F RID: 799
		private static readonly IntPtr NativeFieldInfoPtr_fallbackData;

		// Token: 0x04000320 RID: 800
		private static readonly IntPtr NativeFieldInfoPtr_currentData;

		// Token: 0x04000321 RID: 801
		private static readonly IntPtr NativeFieldInfoPtr_rectTransform;

		// Token: 0x04000322 RID: 802
		private static readonly IntPtr NativeFieldInfoPtr_runningSpacingCoroutine;

		// Token: 0x04000323 RID: 803
		private static readonly IntPtr NativeFieldInfoPtr_runningWidthCoroutine;

		// Token: 0x04000324 RID: 804
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Void_EntityComponent_EntityView_0;

		// Token: 0x04000325 RID: 805
		private static readonly IntPtr NativeMethodInfoPtr_setPositionFor_Protected_Void_UnitView_LocalTransform_Vector3_0;

		// Token: 0x04000326 RID: 806
		private static readonly IntPtr NativeMethodInfoPtr_LayoutViews_Public_Virtual_Void_0;

		// Token: 0x04000327 RID: 807
		private static readonly IntPtr NativeMethodInfoPtr_getFanTransform_Private_LocalTransform_Int32_Int32_0;

		// Token: 0x04000328 RID: 808
		private static readonly IntPtr NativeMethodInfoPtr_GetPositionsFor_Public_Virtual_Void_MoveContext_Il2CppStructArray_1_LocalTransform_0;

		// Token: 0x04000329 RID: 809
		private static readonly IntPtr NativeMethodInfoPtr_OnPrepareToReceiveEntities_Public_Virtual_IEnumerator_MoveContext_0;

		// Token: 0x0400032A RID: 810
		private static readonly IntPtr NativeMethodInfoPtr_createSecondaryMoveContext_Protected_MoveContext_Int32_List_1_UnitView_0;

		// Token: 0x0400032B RID: 811
		private static readonly IntPtr NativeMethodInfoPtr_OnEntitiesRemoved_Public_Virtual_IEnumerator_MoveContext_0;

		// Token: 0x0400032C RID: 812
		private static readonly IntPtr NativeMethodInfoPtr_SetSpacing_Public_Void_Single_Single_0;

		// Token: 0x0400032D RID: 813
		private static readonly IntPtr NativeMethodInfoPtr_SetMaxWidth_Public_Void_Single_Single_0;

		// Token: 0x0400032E RID: 814
		private static readonly IntPtr NativeMethodInfoPtr_LerpHandSpacing_Private_IEnumerator_Single_Single_0;

		// Token: 0x0400032F RID: 815
		private static readonly IntPtr NativeMethodInfoPtr_LerpHandWidth_Private_IEnumerator_Single_Single_0;

		// Token: 0x04000330 RID: 816
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002FE RID: 766
		[ObfuscatedName("dbgclient.DBGFanView+<LerpHandSpacing>d__17")]
		public sealed class _LerpHandSpacing_d__17 : global::Il2CppSystem.Object
		{
			// Token: 0x06002415 RID: 9237 RVA: 0x00094638 File Offset: 0x00092838
			// Note: this type is marked as 'beforefieldinit'.
			static _LerpHandSpacing_d__17()
			{
				Il2CppClassPointerStore<DBGFanView._LerpHandSpacing_d__17>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGFanView>.NativeClassPtr, "<LerpHandSpacing>d__17");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGFanView._LerpHandSpacing_d__17>.NativeClassPtr);
				DBGFanView._LerpHandSpacing_d__17.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGFanView._LerpHandSpacing_d__17>.NativeClassPtr, "<>1__state");
				DBGFanView._LerpHandSpacing_d__17.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGFanView._LerpHandSpacing_d__17>.NativeClassPtr, "<>2__current");
				DBGFanView._LerpHandSpacing_d__17.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGFanView._LerpHandSpacing_d__17>.NativeClassPtr, "<>4__this");
				DBGFanView._LerpHandSpacing_d__17.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGFanView._LerpHandSpacing_d__17>.NativeClassPtr, "duration");
				DBGFanView._LerpHandSpacing_d__17.NativeFieldInfoPtr_targetSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGFanView._LerpHandSpacing_d__17>.NativeClassPtr, "targetSpacing");
				DBGFanView._LerpHandSpacing_d__17.NativeFieldInfoPtr__time_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGFanView._LerpHandSpacing_d__17>.NativeClassPtr, "<time>5__2");
				DBGFanView._LerpHandSpacing_d__17.NativeFieldInfoPtr__startingSpacing_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGFanView._LerpHandSpacing_d__17>.NativeClassPtr, "<startingSpacing>5__3");
				DBGFanView._LerpHandSpacing_d__17.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGFanView._LerpHandSpacing_d__17>.NativeClassPtr, 100664070);
				DBGFanView._LerpHandSpacing_d__17.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGFanView._LerpHandSpacing_d__17>.NativeClassPtr, 100664071);
				DBGFanView._LerpHandSpacing_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGFanView._LerpHandSpacing_d__17>.NativeClassPtr, 100664072);
				DBGFanView._LerpHandSpacing_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGFanView._LerpHandSpacing_d__17>.NativeClassPtr, 100664073);
				DBGFanView._LerpHandSpacing_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGFanView._LerpHandSpacing_d__17>.NativeClassPtr, 100664074);
				DBGFanView._LerpHandSpacing_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGFanView._LerpHandSpacing_d__17>.NativeClassPtr, 100664075);
			}

			// Token: 0x06002416 RID: 9238 RVA: 0x00094768 File Offset: 0x00092968
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _LerpHandSpacing_d__17(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGFanView._LerpHandSpacing_d__17>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGFanView._LerpHandSpacing_d__17.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002417 RID: 9239 RVA: 0x000947B0 File Offset: 0x000929B0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGFanView._LerpHandSpacing_d__17.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002418 RID: 9240 RVA: 0x000947E4 File Offset: 0x000929E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501379, XrefRangeEnd = 501386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGFanView._LerpHandSpacing_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170009DB RID: 2523
			// (get) Token: 0x06002419 RID: 9241 RVA: 0x00094820 File Offset: 0x00092A20
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGFanView._LerpHandSpacing_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600241A RID: 9242 RVA: 0x00094860 File Offset: 0x00092A60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501386, XrefRangeEnd = 501391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGFanView._LerpHandSpacing_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170009DC RID: 2524
			// (get) Token: 0x0600241B RID: 9243 RVA: 0x00094894 File Offset: 0x00092A94
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGFanView._LerpHandSpacing_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600241C RID: 9244 RVA: 0x00012C5C File Offset: 0x00010E5C
			public _LerpHandSpacing_d__17(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170009D4 RID: 2516
			// (get) Token: 0x0600241D RID: 9245 RVA: 0x000948D4 File Offset: 0x00092AD4
			// (set) Token: 0x0600241E RID: 9246 RVA: 0x00012C65 File Offset: 0x00010E65
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGFanView._LerpHandSpacing_d__17.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGFanView._LerpHandSpacing_d__17.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170009D5 RID: 2517
			// (get) Token: 0x0600241F RID: 9247 RVA: 0x000948FC File Offset: 0x00092AFC
			// (set) Token: 0x06002420 RID: 9248 RVA: 0x00012C80 File Offset: 0x00010E80
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGFanView._LerpHandSpacing_d__17.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGFanView._LerpHandSpacing_d__17.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009D6 RID: 2518
			// (get) Token: 0x06002421 RID: 9249 RVA: 0x0009492C File Offset: 0x00092B2C
			// (set) Token: 0x06002422 RID: 9250 RVA: 0x00012C9F File Offset: 0x00010E9F
			public unsafe DBGFanView __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGFanView._LerpHandSpacing_d__17.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGFanView>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGFanView._LerpHandSpacing_d__17.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009D7 RID: 2519
			// (get) Token: 0x06002423 RID: 9251 RVA: 0x0009495C File Offset: 0x00092B5C
			// (set) Token: 0x06002424 RID: 9252 RVA: 0x00012CBE File Offset: 0x00010EBE
			public unsafe float duration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGFanView._LerpHandSpacing_d__17.NativeFieldInfoPtr_duration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGFanView._LerpHandSpacing_d__17.NativeFieldInfoPtr_duration)) = value;
				}
			}

			// Token: 0x170009D8 RID: 2520
			// (get) Token: 0x06002425 RID: 9253 RVA: 0x00094984 File Offset: 0x00092B84
			// (set) Token: 0x06002426 RID: 9254 RVA: 0x00012CD9 File Offset: 0x00010ED9
			public unsafe float targetSpacing
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGFanView._LerpHandSpacing_d__17.NativeFieldInfoPtr_targetSpacing);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGFanView._LerpHandSpacing_d__17.NativeFieldInfoPtr_targetSpacing)) = value;
				}
			}

			// Token: 0x170009D9 RID: 2521
			// (get) Token: 0x06002427 RID: 9255 RVA: 0x000949AC File Offset: 0x00092BAC
			// (set) Token: 0x06002428 RID: 9256 RVA: 0x00012CF4 File Offset: 0x00010EF4
			public unsafe float _time_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGFanView._LerpHandSpacing_d__17.NativeFieldInfoPtr__time_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGFanView._LerpHandSpacing_d__17.NativeFieldInfoPtr__time_5__2)) = value;
				}
			}

			// Token: 0x170009DA RID: 2522
			// (get) Token: 0x06002429 RID: 9257 RVA: 0x000949D4 File Offset: 0x00092BD4
			// (set) Token: 0x0600242A RID: 9258 RVA: 0x00012D0F File Offset: 0x00010F0F
			public unsafe float _startingSpacing_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGFanView._LerpHandSpacing_d__17.NativeFieldInfoPtr__startingSpacing_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGFanView._LerpHandSpacing_d__17.NativeFieldInfoPtr__startingSpacing_5__3)) = value;
				}
			}

			// Token: 0x040016AC RID: 5804
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040016AD RID: 5805
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040016AE RID: 5806
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040016AF RID: 5807
			private static readonly IntPtr NativeFieldInfoPtr_duration;

			// Token: 0x040016B0 RID: 5808
			private static readonly IntPtr NativeFieldInfoPtr_targetSpacing;

			// Token: 0x040016B1 RID: 5809
			private static readonly IntPtr NativeFieldInfoPtr__time_5__2;

			// Token: 0x040016B2 RID: 5810
			private static readonly IntPtr NativeFieldInfoPtr__startingSpacing_5__3;

			// Token: 0x040016B3 RID: 5811
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040016B4 RID: 5812
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040016B5 RID: 5813
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040016B6 RID: 5814
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040016B7 RID: 5815
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040016B8 RID: 5816
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020002FF RID: 767
		[ObfuscatedName("dbgclient.DBGFanView+<LerpHandWidth>d__18")]
		public sealed class _LerpHandWidth_d__18 : global::Il2CppSystem.Object
		{
			// Token: 0x0600242B RID: 9259 RVA: 0x000949FC File Offset: 0x00092BFC
			// Note: this type is marked as 'beforefieldinit'.
			static _LerpHandWidth_d__18()
			{
				Il2CppClassPointerStore<DBGFanView._LerpHandWidth_d__18>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGFanView>.NativeClassPtr, "<LerpHandWidth>d__18");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGFanView._LerpHandWidth_d__18>.NativeClassPtr);
				DBGFanView._LerpHandWidth_d__18.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGFanView._LerpHandWidth_d__18>.NativeClassPtr, "<>1__state");
				DBGFanView._LerpHandWidth_d__18.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGFanView._LerpHandWidth_d__18>.NativeClassPtr, "<>2__current");
				DBGFanView._LerpHandWidth_d__18.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGFanView._LerpHandWidth_d__18>.NativeClassPtr, "<>4__this");
				DBGFanView._LerpHandWidth_d__18.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGFanView._LerpHandWidth_d__18>.NativeClassPtr, "duration");
				DBGFanView._LerpHandWidth_d__18.NativeFieldInfoPtr_targetWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGFanView._LerpHandWidth_d__18>.NativeClassPtr, "targetWidth");
				DBGFanView._LerpHandWidth_d__18.NativeFieldInfoPtr__time_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGFanView._LerpHandWidth_d__18>.NativeClassPtr, "<time>5__2");
				DBGFanView._LerpHandWidth_d__18.NativeFieldInfoPtr__startingWidth_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGFanView._LerpHandWidth_d__18>.NativeClassPtr, "<startingWidth>5__3");
				DBGFanView._LerpHandWidth_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGFanView._LerpHandWidth_d__18>.NativeClassPtr, 100664076);
				DBGFanView._LerpHandWidth_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGFanView._LerpHandWidth_d__18>.NativeClassPtr, 100664077);
				DBGFanView._LerpHandWidth_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGFanView._LerpHandWidth_d__18>.NativeClassPtr, 100664078);
				DBGFanView._LerpHandWidth_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGFanView._LerpHandWidth_d__18>.NativeClassPtr, 100664079);
				DBGFanView._LerpHandWidth_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGFanView._LerpHandWidth_d__18>.NativeClassPtr, 100664080);
				DBGFanView._LerpHandWidth_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGFanView._LerpHandWidth_d__18>.NativeClassPtr, 100664081);
			}

			// Token: 0x0600242C RID: 9260 RVA: 0x00094B2C File Offset: 0x00092D2C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _LerpHandWidth_d__18(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGFanView._LerpHandWidth_d__18>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGFanView._LerpHandWidth_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600242D RID: 9261 RVA: 0x00094B74 File Offset: 0x00092D74
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGFanView._LerpHandWidth_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600242E RID: 9262 RVA: 0x00094BA8 File Offset: 0x00092DA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501391, XrefRangeEnd = 501398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGFanView._LerpHandWidth_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170009E4 RID: 2532
			// (get) Token: 0x0600242F RID: 9263 RVA: 0x00094BE4 File Offset: 0x00092DE4
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGFanView._LerpHandWidth_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002430 RID: 9264 RVA: 0x00094C24 File Offset: 0x00092E24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501398, XrefRangeEnd = 501403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGFanView._LerpHandWidth_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170009E5 RID: 2533
			// (get) Token: 0x06002431 RID: 9265 RVA: 0x00094C58 File Offset: 0x00092E58
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGFanView._LerpHandWidth_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002432 RID: 9266 RVA: 0x00012D2A File Offset: 0x00010F2A
			public _LerpHandWidth_d__18(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170009DD RID: 2525
			// (get) Token: 0x06002433 RID: 9267 RVA: 0x00094C98 File Offset: 0x00092E98
			// (set) Token: 0x06002434 RID: 9268 RVA: 0x00012D33 File Offset: 0x00010F33
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGFanView._LerpHandWidth_d__18.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGFanView._LerpHandWidth_d__18.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170009DE RID: 2526
			// (get) Token: 0x06002435 RID: 9269 RVA: 0x00094CC0 File Offset: 0x00092EC0
			// (set) Token: 0x06002436 RID: 9270 RVA: 0x00012D4E File Offset: 0x00010F4E
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGFanView._LerpHandWidth_d__18.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGFanView._LerpHandWidth_d__18.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009DF RID: 2527
			// (get) Token: 0x06002437 RID: 9271 RVA: 0x00094CF0 File Offset: 0x00092EF0
			// (set) Token: 0x06002438 RID: 9272 RVA: 0x00012D6D File Offset: 0x00010F6D
			public unsafe DBGFanView __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGFanView._LerpHandWidth_d__18.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGFanView>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGFanView._LerpHandWidth_d__18.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009E0 RID: 2528
			// (get) Token: 0x06002439 RID: 9273 RVA: 0x00094D20 File Offset: 0x00092F20
			// (set) Token: 0x0600243A RID: 9274 RVA: 0x00012D8C File Offset: 0x00010F8C
			public unsafe float duration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGFanView._LerpHandWidth_d__18.NativeFieldInfoPtr_duration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGFanView._LerpHandWidth_d__18.NativeFieldInfoPtr_duration)) = value;
				}
			}

			// Token: 0x170009E1 RID: 2529
			// (get) Token: 0x0600243B RID: 9275 RVA: 0x00094D48 File Offset: 0x00092F48
			// (set) Token: 0x0600243C RID: 9276 RVA: 0x00012DA7 File Offset: 0x00010FA7
			public unsafe float targetWidth
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGFanView._LerpHandWidth_d__18.NativeFieldInfoPtr_targetWidth);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGFanView._LerpHandWidth_d__18.NativeFieldInfoPtr_targetWidth)) = value;
				}
			}

			// Token: 0x170009E2 RID: 2530
			// (get) Token: 0x0600243D RID: 9277 RVA: 0x00094D70 File Offset: 0x00092F70
			// (set) Token: 0x0600243E RID: 9278 RVA: 0x00012DC2 File Offset: 0x00010FC2
			public unsafe float _time_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGFanView._LerpHandWidth_d__18.NativeFieldInfoPtr__time_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGFanView._LerpHandWidth_d__18.NativeFieldInfoPtr__time_5__2)) = value;
				}
			}

			// Token: 0x170009E3 RID: 2531
			// (get) Token: 0x0600243F RID: 9279 RVA: 0x00094D98 File Offset: 0x00092F98
			// (set) Token: 0x06002440 RID: 9280 RVA: 0x00012DDD File Offset: 0x00010FDD
			public unsafe float _startingWidth_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGFanView._LerpHandWidth_d__18.NativeFieldInfoPtr__startingWidth_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGFanView._LerpHandWidth_d__18.NativeFieldInfoPtr__startingWidth_5__3)) = value;
				}
			}

			// Token: 0x040016B9 RID: 5817
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040016BA RID: 5818
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040016BB RID: 5819
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040016BC RID: 5820
			private static readonly IntPtr NativeFieldInfoPtr_duration;

			// Token: 0x040016BD RID: 5821
			private static readonly IntPtr NativeFieldInfoPtr_targetWidth;

			// Token: 0x040016BE RID: 5822
			private static readonly IntPtr NativeFieldInfoPtr__time_5__2;

			// Token: 0x040016BF RID: 5823
			private static readonly IntPtr NativeFieldInfoPtr__startingWidth_5__3;

			// Token: 0x040016C0 RID: 5824
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040016C1 RID: 5825
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040016C2 RID: 5826
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040016C3 RID: 5827
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040016C4 RID: 5828
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040016C5 RID: 5829
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000300 RID: 768
		[ObfuscatedName("dbgclient.DBGFanView+<OnEntitiesRemoved>d__14")]
		public sealed class _OnEntitiesRemoved_d__14 : global::Il2CppSystem.Object
		{
			// Token: 0x06002441 RID: 9281 RVA: 0x00094DC0 File Offset: 0x00092FC0
			// Note: this type is marked as 'beforefieldinit'.
			static _OnEntitiesRemoved_d__14()
			{
				Il2CppClassPointerStore<DBGFanView._OnEntitiesRemoved_d__14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGFanView>.NativeClassPtr, "<OnEntitiesRemoved>d__14");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGFanView._OnEntitiesRemoved_d__14>.NativeClassPtr);
				DBGFanView._OnEntitiesRemoved_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGFanView._OnEntitiesRemoved_d__14>.NativeClassPtr, "<>1__state");
				DBGFanView._OnEntitiesRemoved_d__14.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGFanView._OnEntitiesRemoved_d__14>.NativeClassPtr, "<>2__current");
				DBGFanView._OnEntitiesRemoved_d__14.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGFanView._OnEntitiesRemoved_d__14>.NativeClassPtr, "context");
				DBGFanView._OnEntitiesRemoved_d__14.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGFanView._OnEntitiesRemoved_d__14>.NativeClassPtr, "<>4__this");
				DBGFanView._OnEntitiesRemoved_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGFanView._OnEntitiesRemoved_d__14>.NativeClassPtr, 100664082);
				DBGFanView._OnEntitiesRemoved_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGFanView._OnEntitiesRemoved_d__14>.NativeClassPtr, 100664083);
				DBGFanView._OnEntitiesRemoved_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGFanView._OnEntitiesRemoved_d__14>.NativeClassPtr, 100664084);
				DBGFanView._OnEntitiesRemoved_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGFanView._OnEntitiesRemoved_d__14>.NativeClassPtr, 100664085);
				DBGFanView._OnEntitiesRemoved_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGFanView._OnEntitiesRemoved_d__14>.NativeClassPtr, 100664086);
				DBGFanView._OnEntitiesRemoved_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGFanView._OnEntitiesRemoved_d__14>.NativeClassPtr, 100664087);
			}

			// Token: 0x06002442 RID: 9282 RVA: 0x00094EB4 File Offset: 0x000930B4
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnEntitiesRemoved_d__14(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGFanView._OnEntitiesRemoved_d__14>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGFanView._OnEntitiesRemoved_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002443 RID: 9283 RVA: 0x00094EFC File Offset: 0x000930FC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGFanView._OnEntitiesRemoved_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002444 RID: 9284 RVA: 0x00094F30 File Offset: 0x00093130
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501403, XrefRangeEnd = 501416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGFanView._OnEntitiesRemoved_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170009EA RID: 2538
			// (get) Token: 0x06002445 RID: 9285 RVA: 0x00094F6C File Offset: 0x0009316C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGFanView._OnEntitiesRemoved_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002446 RID: 9286 RVA: 0x00094FAC File Offset: 0x000931AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501416, XrefRangeEnd = 501421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGFanView._OnEntitiesRemoved_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170009EB RID: 2539
			// (get) Token: 0x06002447 RID: 9287 RVA: 0x00094FE0 File Offset: 0x000931E0
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGFanView._OnEntitiesRemoved_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002448 RID: 9288 RVA: 0x00012DF8 File Offset: 0x00010FF8
			public _OnEntitiesRemoved_d__14(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170009E6 RID: 2534
			// (get) Token: 0x06002449 RID: 9289 RVA: 0x00095020 File Offset: 0x00093220
			// (set) Token: 0x0600244A RID: 9290 RVA: 0x00012E01 File Offset: 0x00011001
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGFanView._OnEntitiesRemoved_d__14.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGFanView._OnEntitiesRemoved_d__14.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170009E7 RID: 2535
			// (get) Token: 0x0600244B RID: 9291 RVA: 0x00095048 File Offset: 0x00093248
			// (set) Token: 0x0600244C RID: 9292 RVA: 0x00012E1C File Offset: 0x0001101C
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGFanView._OnEntitiesRemoved_d__14.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGFanView._OnEntitiesRemoved_d__14.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009E8 RID: 2536
			// (get) Token: 0x0600244D RID: 9293 RVA: 0x00095078 File Offset: 0x00093278
			// (set) Token: 0x0600244E RID: 9294 RVA: 0x00012E3B File Offset: 0x0001103B
			public unsafe MoveContext context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGFanView._OnEntitiesRemoved_d__14.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MoveContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGFanView._OnEntitiesRemoved_d__14.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009E9 RID: 2537
			// (get) Token: 0x0600244F RID: 9295 RVA: 0x000950A8 File Offset: 0x000932A8
			// (set) Token: 0x06002450 RID: 9296 RVA: 0x00012E5A File Offset: 0x0001105A
			public unsafe DBGFanView __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGFanView._OnEntitiesRemoved_d__14.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGFanView>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGFanView._OnEntitiesRemoved_d__14.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040016C6 RID: 5830
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040016C7 RID: 5831
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040016C8 RID: 5832
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x040016C9 RID: 5833
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040016CA RID: 5834
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040016CB RID: 5835
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040016CC RID: 5836
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040016CD RID: 5837
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040016CE RID: 5838
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040016CF RID: 5839
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000301 RID: 769
		[ObfuscatedName("dbgclient.DBGFanView+<OnPrepareToReceiveEntities>d__12")]
		public sealed class _OnPrepareToReceiveEntities_d__12 : global::Il2CppSystem.Object
		{
			// Token: 0x06002451 RID: 9297 RVA: 0x000950D8 File Offset: 0x000932D8
			// Note: this type is marked as 'beforefieldinit'.
			static _OnPrepareToReceiveEntities_d__12()
			{
				Il2CppClassPointerStore<DBGFanView._OnPrepareToReceiveEntities_d__12>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGFanView>.NativeClassPtr, "<OnPrepareToReceiveEntities>d__12");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGFanView._OnPrepareToReceiveEntities_d__12>.NativeClassPtr);
				DBGFanView._OnPrepareToReceiveEntities_d__12.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGFanView._OnPrepareToReceiveEntities_d__12>.NativeClassPtr, "<>1__state");
				DBGFanView._OnPrepareToReceiveEntities_d__12.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGFanView._OnPrepareToReceiveEntities_d__12>.NativeClassPtr, "<>2__current");
				DBGFanView._OnPrepareToReceiveEntities_d__12.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGFanView._OnPrepareToReceiveEntities_d__12>.NativeClassPtr, "context");
				DBGFanView._OnPrepareToReceiveEntities_d__12.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGFanView._OnPrepareToReceiveEntities_d__12>.NativeClassPtr, "<>4__this");
				DBGFanView._OnPrepareToReceiveEntities_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGFanView._OnPrepareToReceiveEntities_d__12>.NativeClassPtr, 100664088);
				DBGFanView._OnPrepareToReceiveEntities_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGFanView._OnPrepareToReceiveEntities_d__12>.NativeClassPtr, 100664089);
				DBGFanView._OnPrepareToReceiveEntities_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGFanView._OnPrepareToReceiveEntities_d__12>.NativeClassPtr, 100664090);
				DBGFanView._OnPrepareToReceiveEntities_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGFanView._OnPrepareToReceiveEntities_d__12>.NativeClassPtr, 100664091);
				DBGFanView._OnPrepareToReceiveEntities_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGFanView._OnPrepareToReceiveEntities_d__12>.NativeClassPtr, 100664092);
				DBGFanView._OnPrepareToReceiveEntities_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGFanView._OnPrepareToReceiveEntities_d__12>.NativeClassPtr, 100664093);
			}

			// Token: 0x06002452 RID: 9298 RVA: 0x000951CC File Offset: 0x000933CC
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnPrepareToReceiveEntities_d__12(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGFanView._OnPrepareToReceiveEntities_d__12>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGFanView._OnPrepareToReceiveEntities_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002453 RID: 9299 RVA: 0x00095214 File Offset: 0x00093414
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGFanView._OnPrepareToReceiveEntities_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002454 RID: 9300 RVA: 0x00095248 File Offset: 0x00093448
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501421, XrefRangeEnd = 501464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGFanView._OnPrepareToReceiveEntities_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170009F0 RID: 2544
			// (get) Token: 0x06002455 RID: 9301 RVA: 0x00095284 File Offset: 0x00093484
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGFanView._OnPrepareToReceiveEntities_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002456 RID: 9302 RVA: 0x000952C4 File Offset: 0x000934C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501464, XrefRangeEnd = 501469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGFanView._OnPrepareToReceiveEntities_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170009F1 RID: 2545
			// (get) Token: 0x06002457 RID: 9303 RVA: 0x000952F8 File Offset: 0x000934F8
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGFanView._OnPrepareToReceiveEntities_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002458 RID: 9304 RVA: 0x00012E79 File Offset: 0x00011079
			public _OnPrepareToReceiveEntities_d__12(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170009EC RID: 2540
			// (get) Token: 0x06002459 RID: 9305 RVA: 0x00095338 File Offset: 0x00093538
			// (set) Token: 0x0600245A RID: 9306 RVA: 0x00012E82 File Offset: 0x00011082
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGFanView._OnPrepareToReceiveEntities_d__12.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGFanView._OnPrepareToReceiveEntities_d__12.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170009ED RID: 2541
			// (get) Token: 0x0600245B RID: 9307 RVA: 0x00095360 File Offset: 0x00093560
			// (set) Token: 0x0600245C RID: 9308 RVA: 0x00012E9D File Offset: 0x0001109D
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGFanView._OnPrepareToReceiveEntities_d__12.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGFanView._OnPrepareToReceiveEntities_d__12.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009EE RID: 2542
			// (get) Token: 0x0600245D RID: 9309 RVA: 0x00095390 File Offset: 0x00093590
			// (set) Token: 0x0600245E RID: 9310 RVA: 0x00012EBC File Offset: 0x000110BC
			public unsafe MoveContext context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGFanView._OnPrepareToReceiveEntities_d__12.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MoveContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGFanView._OnPrepareToReceiveEntities_d__12.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009EF RID: 2543
			// (get) Token: 0x0600245F RID: 9311 RVA: 0x000953C0 File Offset: 0x000935C0
			// (set) Token: 0x06002460 RID: 9312 RVA: 0x00012EDB File Offset: 0x000110DB
			public unsafe DBGFanView __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGFanView._OnPrepareToReceiveEntities_d__12.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGFanView>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGFanView._OnPrepareToReceiveEntities_d__12.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040016D0 RID: 5840
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040016D1 RID: 5841
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040016D2 RID: 5842
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x040016D3 RID: 5843
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040016D4 RID: 5844
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040016D5 RID: 5845
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040016D6 RID: 5846
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040016D7 RID: 5847
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040016D8 RID: 5848
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040016D9 RID: 5849
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
