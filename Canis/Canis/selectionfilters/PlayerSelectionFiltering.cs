using System;
using Canis.attributes;
using Canis.entities;
using Canis.json.events;
using Canis.utils.ids;
using Canis.utils.localization;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Networking.selection.targetinformation;

namespace Canis.selectionfilters
{
	// Token: 0x02000053 RID: 83
	public class PlayerSelectionFiltering : Object
	{
		// Token: 0x060004FA RID: 1274 RVA: 0x0002CA2C File Offset: 0x0002AC2C
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerSelectionFiltering()
		{
			Il2CppClassPointerStore<PlayerSelectionFiltering>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.selectionfilters", "PlayerSelectionFiltering");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerSelectionFiltering>.NativeClassPtr);
			PlayerSelectionFiltering.NativeFieldInfoPtr_filters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSelectionFiltering>.NativeClassPtr, "filters");
			PlayerSelectionFiltering.NativeFieldInfoPtr_aiFilters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSelectionFiltering>.NativeClassPtr, "aiFilters");
			PlayerSelectionFiltering.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSelectionFiltering>.NativeClassPtr, "match");
			PlayerSelectionFiltering.NativeMethodInfoPtr__ctor_Public_Void_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSelectionFiltering>.NativeClassPtr, 100664302);
			PlayerSelectionFiltering.NativeMethodInfoPtr_init_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSelectionFiltering>.NativeClassPtr, 100664303);
			PlayerSelectionFiltering.NativeMethodInfoPtr_GetValidSelectionFilter_Public_IEnumerable_1_SelectionFilter_NetworkMessageEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSelectionFiltering>.NativeClassPtr, 100664304);
			PlayerSelectionFiltering.NativeMethodInfoPtr_GetValidAISelectionFilter_Public_IEnumerable_1_SelectionFilter_NetworkMessageEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSelectionFiltering>.NativeClassPtr, 100664305);
			PlayerSelectionFiltering.NativeMethodInfoPtr_ForceSelectionStepOne_Protected_IEnumerable_1_IAttribute_NetworkMessageEvent_Func_2_Entity_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSelectionFiltering>.NativeClassPtr, 100664306);
			PlayerSelectionFiltering.NativeMethodInfoPtr_FilterSelectionStepOne_Public_IEnumerable_1_IAttribute_NetworkMessageEvent_Func_2_Entity_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSelectionFiltering>.NativeClassPtr, 100664307);
			PlayerSelectionFiltering.NativeMethodInfoPtr_ForceSelectionStepTwo_Protected_IEnumerable_1_IAttribute_NetworkMessageEvent_Func_2_Entity_Boolean_Func_2_Entity_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSelectionFiltering>.NativeClassPtr, 100664308);
			PlayerSelectionFiltering.NativeMethodInfoPtr_FilterSelectionStepTwo_Protected_IEnumerable_1_IAttribute_NetworkMessageEvent_Func_2_Entity_Boolean_Func_2_Entity_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSelectionFiltering>.NativeClassPtr, 100664309);
			PlayerSelectionFiltering.NativeMethodInfoPtr_FilterSelectionTargets_Protected_IEnumerable_1_IAttribute_NetworkMessageEvent_Func_2_Entity_Boolean_Func_2_TargetInformation_SelectionNodeFilterData_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSelectionFiltering>.NativeClassPtr, 100664310);
			PlayerSelectionFiltering.NativeMethodInfoPtr_DoneSelection_Protected_IEnumerable_1_IAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSelectionFiltering>.NativeClassPtr, 100664311);
			PlayerSelectionFiltering.NativeMethodInfoPtr_ForceDoneSelection_Protected_IEnumerable_1_IAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSelectionFiltering>.NativeClassPtr, 100664312);
			PlayerSelectionFiltering.NativeMethodInfoPtr_ForceIntChoice_Protected_IEnumerable_1_IAttribute_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSelectionFiltering>.NativeClassPtr, 100664313);
			PlayerSelectionFiltering.NativeMethodInfoPtr_FilterIntChoice_Protected_IEnumerable_1_IAttribute_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSelectionFiltering>.NativeClassPtr, 100664314);
			PlayerSelectionFiltering.NativeMethodInfoPtr_FilterCustomChoice_Protected_IEnumerable_1_IAttribute_NetworkMessageEvent_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSelectionFiltering>.NativeClassPtr, 100664315);
			PlayerSelectionFiltering.NativeMethodInfoPtr_TrueSelection_Protected_Static_Func_2_Entity_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSelectionFiltering>.NativeClassPtr, 100664316);
			PlayerSelectionFiltering.NativeMethodInfoPtr_True_Protected_Static_Func_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSelectionFiltering>.NativeClassPtr, 100664317);
			PlayerSelectionFiltering.NativeMethodInfoPtr_And_Protected_Func_1_Boolean_Func_1_Boolean_Func_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSelectionFiltering>.NativeClassPtr, 100664318);
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x0002CBEC File Offset: 0x0002ADEC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 458838, RefRangeEnd = 458841, XrefRangeStart = 458838, XrefRangeEnd = 458841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerSelectionFiltering(Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerSelectionFiltering>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSelectionFiltering.NativeMethodInfoPtr__ctor_Public_Void_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x0002CC38 File Offset: 0x0002AE38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 553954, XrefRangeEnd = 553966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerSelectionFiltering.NativeMethodInfoPtr_init_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x0002CC74 File Offset: 0x0002AE74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 553966, XrefRangeEnd = 553981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<SelectionFilter> GetValidSelectionFilter(NetworkMessageEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSelectionFiltering.NativeMethodInfoPtr_GetValidSelectionFilter_Public_IEnumerable_1_SelectionFilter_NetworkMessageEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<SelectionFilter>>(intPtr3) : null;
			}
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x0002CCC4 File Offset: 0x0002AEC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 553996, RefRangeEnd = 553997, XrefRangeStart = 553981, XrefRangeEnd = 553996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<SelectionFilter> GetValidAISelectionFilter(NetworkMessageEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSelectionFiltering.NativeMethodInfoPtr_GetValidAISelectionFilter_Public_IEnumerable_1_SelectionFilter_NetworkMessageEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<SelectionFilter>>(intPtr3) : null;
			}
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x0002CD14 File Offset: 0x0002AF14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 554036, RefRangeEnd = 554037, XrefRangeStart = 553997, XrefRangeEnd = 554036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<IAttribute> ForceSelectionStepOne(NetworkMessageEvent evt, Func<Entity, bool> filter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSelectionFiltering.NativeMethodInfoPtr_ForceSelectionStepOne_Protected_IEnumerable_1_IAttribute_NetworkMessageEvent_Func_2_Entity_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IAttribute>>(intPtr3) : null;
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x0002CD78 File Offset: 0x0002AF78
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 554107, RefRangeEnd = 554116, XrefRangeStart = 554037, XrefRangeEnd = 554107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<IAttribute> FilterSelectionStepOne(NetworkMessageEvent evt, Func<Entity, bool> filter, bool canCancelStepTwo = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref canCancelStepTwo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSelectionFiltering.NativeMethodInfoPtr_FilterSelectionStepOne_Public_IEnumerable_1_IAttribute_NetworkMessageEvent_Func_2_Entity_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IAttribute>>(intPtr3) : null;
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x0002CDE8 File Offset: 0x0002AFE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 554116, XrefRangeEnd = 554162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<IAttribute> ForceSelectionStepTwo(NetworkMessageEvent evt, Func<Entity, bool> selectionOne, Func<Entity, bool> selectionTwo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selectionOne);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selectionTwo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSelectionFiltering.NativeMethodInfoPtr_ForceSelectionStepTwo_Protected_IEnumerable_1_IAttribute_NetworkMessageEvent_Func_2_Entity_Boolean_Func_2_Entity_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IAttribute>>(intPtr3) : null;
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x0002CE5C File Offset: 0x0002B05C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 554222, RefRangeEnd = 554230, XrefRangeStart = 554162, XrefRangeEnd = 554222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<IAttribute> FilterSelectionStepTwo(NetworkMessageEvent evt, Func<Entity, bool> selectionOne, Func<Entity, bool> selectionTwo, bool canCancelStepTwo = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selectionOne);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selectionTwo);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref canCancelStepTwo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSelectionFiltering.NativeMethodInfoPtr_FilterSelectionStepTwo_Protected_IEnumerable_1_IAttribute_NetworkMessageEvent_Func_2_Entity_Boolean_Func_2_Entity_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IAttribute>>(intPtr3) : null;
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x0002CEE0 File Offset: 0x0002B0E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 554239, RefRangeEnd = 554240, XrefRangeStart = 554230, XrefRangeEnd = 554239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<IAttribute> FilterSelectionTargets(NetworkMessageEvent evt, Func<Entity, bool> selectionOne, Func<TargetInformation, SelectionNodeFilterData> selectionTargets, bool canCancelStepTwo = false, bool forceStepOne = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selectionOne);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selectionTargets);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref canCancelStepTwo;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceStepOne;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSelectionFiltering.NativeMethodInfoPtr_FilterSelectionTargets_Protected_IEnumerable_1_IAttribute_NetworkMessageEvent_Func_2_Entity_Boolean_Func_2_TargetInformation_SelectionNodeFilterData_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IAttribute>>(intPtr3) : null;
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x0002CF70 File Offset: 0x0002B170
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 554240, XrefRangeEnd = 554254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<IAttribute> DoneSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSelectionFiltering.NativeMethodInfoPtr_DoneSelection_Protected_IEnumerable_1_IAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IAttribute>>(intPtr3) : null;
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x0002CFB0 File Offset: 0x0002B1B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 554254, XrefRangeEnd = 554268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<IAttribute> ForceDoneSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSelectionFiltering.NativeMethodInfoPtr_ForceDoneSelection_Protected_IEnumerable_1_IAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IAttribute>>(intPtr3) : null;
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x0002CFF0 File Offset: 0x0002B1F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 554268, XrefRangeEnd = 554282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<IAttribute> ForceIntChoice(int choice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref choice;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSelectionFiltering.NativeMethodInfoPtr_ForceIntChoice_Protected_IEnumerable_1_IAttribute_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IAttribute>>(intPtr3) : null;
			}
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x0002D03C File Offset: 0x0002B23C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 554296, RefRangeEnd = 554297, XrefRangeStart = 554282, XrefRangeEnd = 554296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<IAttribute> FilterIntChoice(int choice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref choice;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSelectionFiltering.NativeMethodInfoPtr_FilterIntChoice_Protected_IEnumerable_1_IAttribute_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IAttribute>>(intPtr3) : null;
			}
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x0002D088 File Offset: 0x0002B288
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 554354, RefRangeEnd = 554357, XrefRangeStart = 554297, XrefRangeEnd = 554354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<IAttribute> FilterCustomChoice(NetworkMessageEvent evt, string choice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(choice);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSelectionFiltering.NativeMethodInfoPtr_FilterCustomChoice_Protected_IEnumerable_1_IAttribute_NetworkMessageEvent_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IAttribute>>(intPtr3) : null;
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x0002D0EC File Offset: 0x0002B2EC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 554372, RefRangeEnd = 554378, XrefRangeStart = 554357, XrefRangeEnd = 554372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Func<Entity, bool> TrueSelection()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSelectionFiltering.NativeMethodInfoPtr_TrueSelection_Protected_Static_Func_2_Entity_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr3) : null;
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x0002D120 File Offset: 0x0002B320
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 554378, XrefRangeEnd = 554393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Func<bool> True()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSelectionFiltering.NativeMethodInfoPtr_True_Protected_Static_Func_1_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr3) : null;
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x0002D154 File Offset: 0x0002B354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 554393, XrefRangeEnd = 554405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Func<bool> And(Func<bool> a, Func<bool> b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSelectionFiltering.NativeMethodInfoPtr_And_Protected_Func_1_Boolean_Func_1_Boolean_Func_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr3) : null;
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x00004303 File Offset: 0x00002503
		public PlayerSelectionFiltering(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x0600050D RID: 1293 RVA: 0x0002D1B8 File Offset: 0x0002B3B8
		// (set) Token: 0x0600050E RID: 1294 RVA: 0x0000430C File Offset: 0x0000250C
		public unsafe List<SelectionFilter> filters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFiltering.NativeFieldInfoPtr_filters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SelectionFilter>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFiltering.NativeFieldInfoPtr_filters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x0600050F RID: 1295 RVA: 0x0002D1E8 File Offset: 0x0002B3E8
		// (set) Token: 0x06000510 RID: 1296 RVA: 0x0000432B File Offset: 0x0000252B
		public unsafe List<SelectionFilter> aiFilters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFiltering.NativeFieldInfoPtr_aiFilters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SelectionFilter>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFiltering.NativeFieldInfoPtr_aiFilters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000511 RID: 1297 RVA: 0x0002D218 File Offset: 0x0002B418
		// (set) Token: 0x06000512 RID: 1298 RVA: 0x0000434A File Offset: 0x0000254A
		public unsafe Match match
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFiltering.NativeFieldInfoPtr_match);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFiltering.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400032A RID: 810
		private static readonly IntPtr NativeFieldInfoPtr_filters;

		// Token: 0x0400032B RID: 811
		private static readonly IntPtr NativeFieldInfoPtr_aiFilters;

		// Token: 0x0400032C RID: 812
		private static readonly IntPtr NativeFieldInfoPtr_match;

		// Token: 0x0400032D RID: 813
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Match_0;

		// Token: 0x0400032E RID: 814
		private static readonly IntPtr NativeMethodInfoPtr_init_Public_Virtual_New_Void_0;

		// Token: 0x0400032F RID: 815
		private static readonly IntPtr NativeMethodInfoPtr_GetValidSelectionFilter_Public_IEnumerable_1_SelectionFilter_NetworkMessageEvent_0;

		// Token: 0x04000330 RID: 816
		private static readonly IntPtr NativeMethodInfoPtr_GetValidAISelectionFilter_Public_IEnumerable_1_SelectionFilter_NetworkMessageEvent_0;

		// Token: 0x04000331 RID: 817
		private static readonly IntPtr NativeMethodInfoPtr_ForceSelectionStepOne_Protected_IEnumerable_1_IAttribute_NetworkMessageEvent_Func_2_Entity_Boolean_0;

		// Token: 0x04000332 RID: 818
		private static readonly IntPtr NativeMethodInfoPtr_FilterSelectionStepOne_Public_IEnumerable_1_IAttribute_NetworkMessageEvent_Func_2_Entity_Boolean_Boolean_0;

		// Token: 0x04000333 RID: 819
		private static readonly IntPtr NativeMethodInfoPtr_ForceSelectionStepTwo_Protected_IEnumerable_1_IAttribute_NetworkMessageEvent_Func_2_Entity_Boolean_Func_2_Entity_Boolean_0;

		// Token: 0x04000334 RID: 820
		private static readonly IntPtr NativeMethodInfoPtr_FilterSelectionStepTwo_Protected_IEnumerable_1_IAttribute_NetworkMessageEvent_Func_2_Entity_Boolean_Func_2_Entity_Boolean_Boolean_0;

		// Token: 0x04000335 RID: 821
		private static readonly IntPtr NativeMethodInfoPtr_FilterSelectionTargets_Protected_IEnumerable_1_IAttribute_NetworkMessageEvent_Func_2_Entity_Boolean_Func_2_TargetInformation_SelectionNodeFilterData_Boolean_Boolean_0;

		// Token: 0x04000336 RID: 822
		private static readonly IntPtr NativeMethodInfoPtr_DoneSelection_Protected_IEnumerable_1_IAttribute_0;

		// Token: 0x04000337 RID: 823
		private static readonly IntPtr NativeMethodInfoPtr_ForceDoneSelection_Protected_IEnumerable_1_IAttribute_0;

		// Token: 0x04000338 RID: 824
		private static readonly IntPtr NativeMethodInfoPtr_ForceIntChoice_Protected_IEnumerable_1_IAttribute_Int32_0;

		// Token: 0x04000339 RID: 825
		private static readonly IntPtr NativeMethodInfoPtr_FilterIntChoice_Protected_IEnumerable_1_IAttribute_Int32_0;

		// Token: 0x0400033A RID: 826
		private static readonly IntPtr NativeMethodInfoPtr_FilterCustomChoice_Protected_IEnumerable_1_IAttribute_NetworkMessageEvent_String_0;

		// Token: 0x0400033B RID: 827
		private static readonly IntPtr NativeMethodInfoPtr_TrueSelection_Protected_Static_Func_2_Entity_Boolean_0;

		// Token: 0x0400033C RID: 828
		private static readonly IntPtr NativeMethodInfoPtr_True_Protected_Static_Func_1_Boolean_0;

		// Token: 0x0400033D RID: 829
		private static readonly IntPtr NativeMethodInfoPtr_And_Protected_Func_1_Boolean_Func_1_Boolean_Func_1_Boolean_0;

		// Token: 0x020002A4 RID: 676
		[ObfuscatedName("Canis.selectionfilters.PlayerSelectionFiltering+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001CAD RID: 7341 RVA: 0x000882A8 File Offset: 0x000864A8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PlayerSelectionFiltering.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerSelectionFiltering>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerSelectionFiltering.__c>.NativeClassPtr);
				PlayerSelectionFiltering.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSelectionFiltering.__c>.NativeClassPtr, "<>9");
				PlayerSelectionFiltering.__c.NativeFieldInfoPtr___9__17_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSelectionFiltering.__c>.NativeClassPtr, "<>9__17_0");
				PlayerSelectionFiltering.__c.NativeFieldInfoPtr___9__18_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSelectionFiltering.__c>.NativeClassPtr, "<>9__18_0");
				PlayerSelectionFiltering.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSelectionFiltering.__c>.NativeClassPtr, 100664320);
				PlayerSelectionFiltering.__c.NativeMethodInfoPtr__TrueSelection_b__17_0_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSelectionFiltering.__c>.NativeClassPtr, 100664321);
				PlayerSelectionFiltering.__c.NativeMethodInfoPtr__True_b__18_0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSelectionFiltering.__c>.NativeClassPtr, 100664322);
			}

			// Token: 0x06001CAE RID: 7342 RVA: 0x0008834C File Offset: 0x0008654C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerSelectionFiltering.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSelectionFiltering.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001CAF RID: 7343 RVA: 0x00088388 File Offset: 0x00086588
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _TrueSelection_b__17_0(Entity ent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSelectionFiltering.__c.NativeMethodInfoPtr__TrueSelection_b__17_0_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001CB0 RID: 7344 RVA: 0x000883D8 File Offset: 0x000865D8
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _True_b__18_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSelectionFiltering.__c.NativeMethodInfoPtr__True_b__18_0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001CB1 RID: 7345 RVA: 0x0000DAFA File Offset: 0x0000BCFA
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006A6 RID: 1702
			// (get) Token: 0x06001CB2 RID: 7346 RVA: 0x00088414 File Offset: 0x00086614
			// (set) Token: 0x06001CB3 RID: 7347 RVA: 0x0000DB03 File Offset: 0x0000BD03
			public unsafe static PlayerSelectionFiltering.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayerSelectionFiltering.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerSelectionFiltering.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerSelectionFiltering.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006A7 RID: 1703
			// (get) Token: 0x06001CB4 RID: 7348 RVA: 0x0008843C File Offset: 0x0008663C
			// (set) Token: 0x06001CB5 RID: 7349 RVA: 0x0000DB15 File Offset: 0x0000BD15
			public unsafe static Func<Entity, bool> __9__17_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayerSelectionFiltering.__c.NativeFieldInfoPtr___9__17_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerSelectionFiltering.__c.NativeFieldInfoPtr___9__17_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006A8 RID: 1704
			// (get) Token: 0x06001CB6 RID: 7350 RVA: 0x00088464 File Offset: 0x00086664
			// (set) Token: 0x06001CB7 RID: 7351 RVA: 0x0000DB27 File Offset: 0x0000BD27
			public unsafe static Func<bool> __9__18_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayerSelectionFiltering.__c.NativeFieldInfoPtr___9__18_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerSelectionFiltering.__c.NativeFieldInfoPtr___9__18_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400124B RID: 4683
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400124C RID: 4684
			private static readonly IntPtr NativeFieldInfoPtr___9__17_0;

			// Token: 0x0400124D RID: 4685
			private static readonly IntPtr NativeFieldInfoPtr___9__18_0;

			// Token: 0x0400124E RID: 4686
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400124F RID: 4687
			private static readonly IntPtr NativeMethodInfoPtr__TrueSelection_b__17_0_Internal_Boolean_Entity_0;

			// Token: 0x04001250 RID: 4688
			private static readonly IntPtr NativeMethodInfoPtr__True_b__18_0_Internal_Boolean_0;
		}

		// Token: 0x020002A5 RID: 677
		[ObfuscatedName("Canis.selectionfilters.PlayerSelectionFiltering+<>c__DisplayClass16_0")]
		public sealed class __c__DisplayClass16_0 : Object
		{
			// Token: 0x06001CB8 RID: 7352 RVA: 0x0008848C File Offset: 0x0008668C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass16_0()
			{
				Il2CppClassPointerStore<PlayerSelectionFiltering.__c__DisplayClass16_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerSelectionFiltering>.NativeClassPtr, "<>c__DisplayClass16_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerSelectionFiltering.__c__DisplayClass16_0>.NativeClassPtr);
				PlayerSelectionFiltering.__c__DisplayClass16_0.NativeFieldInfoPtr_choice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSelectionFiltering.__c__DisplayClass16_0>.NativeClassPtr, "choice");
				PlayerSelectionFiltering.__c__DisplayClass16_0.NativeFieldInfoPtr___9__0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSelectionFiltering.__c__DisplayClass16_0>.NativeClassPtr, "<>9__0");
				PlayerSelectionFiltering.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSelectionFiltering.__c__DisplayClass16_0>.NativeClassPtr, 100664323);
				PlayerSelectionFiltering.__c__DisplayClass16_0.NativeMethodInfoPtr__FilterCustomChoice_b__0_Internal_Boolean_LocalizableText_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSelectionFiltering.__c__DisplayClass16_0>.NativeClassPtr, 100664324);
				PlayerSelectionFiltering.__c__DisplayClass16_0.NativeMethodInfoPtr__FilterCustomChoice_b__1_Internal_Boolean_LocalizableText_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSelectionFiltering.__c__DisplayClass16_0>.NativeClassPtr, 100664325);
			}

			// Token: 0x06001CB9 RID: 7353 RVA: 0x0008851C File Offset: 0x0008671C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass16_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerSelectionFiltering.__c__DisplayClass16_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSelectionFiltering.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001CBA RID: 7354 RVA: 0x00088558 File Offset: 0x00086758
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _FilterCustomChoice_b__0(LocalizableText button)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(button);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSelectionFiltering.__c__DisplayClass16_0.NativeMethodInfoPtr__FilterCustomChoice_b__0_Internal_Boolean_LocalizableText_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001CBB RID: 7355 RVA: 0x000885A8 File Offset: 0x000867A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _FilterCustomChoice_b__1(LocalizableText button)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(button);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSelectionFiltering.__c__DisplayClass16_0.NativeMethodInfoPtr__FilterCustomChoice_b__1_Internal_Boolean_LocalizableText_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001CBC RID: 7356 RVA: 0x0000DB39 File Offset: 0x0000BD39
			public __c__DisplayClass16_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006A9 RID: 1705
			// (get) Token: 0x06001CBD RID: 7357 RVA: 0x000885F8 File Offset: 0x000867F8
			// (set) Token: 0x06001CBE RID: 7358 RVA: 0x0000DB42 File Offset: 0x0000BD42
			public unsafe string choice
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFiltering.__c__DisplayClass16_0.NativeFieldInfoPtr_choice);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFiltering.__c__DisplayClass16_0.NativeFieldInfoPtr_choice), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170006AA RID: 1706
			// (get) Token: 0x06001CBF RID: 7359 RVA: 0x00088620 File Offset: 0x00086820
			// (set) Token: 0x06001CC0 RID: 7360 RVA: 0x0000DB61 File Offset: 0x0000BD61
			public unsafe Predicate<LocalizableText> __9__0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFiltering.__c__DisplayClass16_0.NativeFieldInfoPtr___9__0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<LocalizableText>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFiltering.__c__DisplayClass16_0.NativeFieldInfoPtr___9__0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001251 RID: 4689
			private static readonly IntPtr NativeFieldInfoPtr_choice;

			// Token: 0x04001252 RID: 4690
			private static readonly IntPtr NativeFieldInfoPtr___9__0;

			// Token: 0x04001253 RID: 4691
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001254 RID: 4692
			private static readonly IntPtr NativeMethodInfoPtr__FilterCustomChoice_b__0_Internal_Boolean_LocalizableText_0;

			// Token: 0x04001255 RID: 4693
			private static readonly IntPtr NativeMethodInfoPtr__FilterCustomChoice_b__1_Internal_Boolean_LocalizableText_0;
		}

		// Token: 0x020002A6 RID: 678
		[ObfuscatedName("Canis.selectionfilters.PlayerSelectionFiltering+<>c__DisplayClass19_0")]
		public sealed class __c__DisplayClass19_0 : Object
		{
			// Token: 0x06001CC1 RID: 7361 RVA: 0x00088650 File Offset: 0x00086850
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass19_0()
			{
				Il2CppClassPointerStore<PlayerSelectionFiltering.__c__DisplayClass19_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerSelectionFiltering>.NativeClassPtr, "<>c__DisplayClass19_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerSelectionFiltering.__c__DisplayClass19_0>.NativeClassPtr);
				PlayerSelectionFiltering.__c__DisplayClass19_0.NativeFieldInfoPtr_a = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSelectionFiltering.__c__DisplayClass19_0>.NativeClassPtr, "a");
				PlayerSelectionFiltering.__c__DisplayClass19_0.NativeFieldInfoPtr_b = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSelectionFiltering.__c__DisplayClass19_0>.NativeClassPtr, "b");
				PlayerSelectionFiltering.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSelectionFiltering.__c__DisplayClass19_0>.NativeClassPtr, 100664326);
				PlayerSelectionFiltering.__c__DisplayClass19_0.NativeMethodInfoPtr__And_b__0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSelectionFiltering.__c__DisplayClass19_0>.NativeClassPtr, 100664327);
			}

			// Token: 0x06001CC2 RID: 7362 RVA: 0x000886CC File Offset: 0x000868CC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass19_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerSelectionFiltering.__c__DisplayClass19_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSelectionFiltering.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001CC3 RID: 7363 RVA: 0x00088708 File Offset: 0x00086908
			[CallerCount(0)]
			public unsafe bool _And_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSelectionFiltering.__c__DisplayClass19_0.NativeMethodInfoPtr__And_b__0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001CC4 RID: 7364 RVA: 0x0000DB80 File Offset: 0x0000BD80
			public __c__DisplayClass19_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006AB RID: 1707
			// (get) Token: 0x06001CC5 RID: 7365 RVA: 0x00088744 File Offset: 0x00086944
			// (set) Token: 0x06001CC6 RID: 7366 RVA: 0x0000DB89 File Offset: 0x0000BD89
			public unsafe Func<bool> a
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFiltering.__c__DisplayClass19_0.NativeFieldInfoPtr_a);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFiltering.__c__DisplayClass19_0.NativeFieldInfoPtr_a), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006AC RID: 1708
			// (get) Token: 0x06001CC7 RID: 7367 RVA: 0x00088774 File Offset: 0x00086974
			// (set) Token: 0x06001CC8 RID: 7368 RVA: 0x0000DBA8 File Offset: 0x0000BDA8
			public unsafe Func<bool> b
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFiltering.__c__DisplayClass19_0.NativeFieldInfoPtr_b);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFiltering.__c__DisplayClass19_0.NativeFieldInfoPtr_b), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001256 RID: 4694
			private static readonly IntPtr NativeFieldInfoPtr_a;

			// Token: 0x04001257 RID: 4695
			private static readonly IntPtr NativeFieldInfoPtr_b;

			// Token: 0x04001258 RID: 4696
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001259 RID: 4697
			private static readonly IntPtr NativeMethodInfoPtr__And_b__0_Internal_Boolean_0;
		}

		// Token: 0x020002A7 RID: 679
		[ObfuscatedName("Canis.selectionfilters.PlayerSelectionFiltering+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : Object
		{
			// Token: 0x06001CC9 RID: 7369 RVA: 0x000887A4 File Offset: 0x000869A4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<PlayerSelectionFiltering.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerSelectionFiltering>.NativeClassPtr, "<>c__DisplayClass5_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerSelectionFiltering.__c__DisplayClass5_0>.NativeClassPtr);
				PlayerSelectionFiltering.__c__DisplayClass5_0.NativeFieldInfoPtr_evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSelectionFiltering.__c__DisplayClass5_0>.NativeClassPtr, "evt");
				PlayerSelectionFiltering.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSelectionFiltering.__c__DisplayClass5_0>.NativeClassPtr, 100664328);
				PlayerSelectionFiltering.__c__DisplayClass5_0.NativeMethodInfoPtr__GetValidSelectionFilter_b__0_Internal_Boolean_SelectionFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSelectionFiltering.__c__DisplayClass5_0>.NativeClassPtr, 100664329);
			}

			// Token: 0x06001CCA RID: 7370 RVA: 0x0008880C File Offset: 0x00086A0C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerSelectionFiltering.__c__DisplayClass5_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSelectionFiltering.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001CCB RID: 7371 RVA: 0x00088848 File Offset: 0x00086A48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 553836, XrefRangeEnd = 553837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetValidSelectionFilter_b__0(SelectionFilter filter)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(filter);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSelectionFiltering.__c__DisplayClass5_0.NativeMethodInfoPtr__GetValidSelectionFilter_b__0_Internal_Boolean_SelectionFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001CCC RID: 7372 RVA: 0x0000DBC7 File Offset: 0x0000BDC7
			public __c__DisplayClass5_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006AD RID: 1709
			// (get) Token: 0x06001CCD RID: 7373 RVA: 0x00088898 File Offset: 0x00086A98
			// (set) Token: 0x06001CCE RID: 7374 RVA: 0x0000DBD0 File Offset: 0x0000BDD0
			public unsafe NetworkMessageEvent evt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFiltering.__c__DisplayClass5_0.NativeFieldInfoPtr_evt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkMessageEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFiltering.__c__DisplayClass5_0.NativeFieldInfoPtr_evt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400125A RID: 4698
			private static readonly IntPtr NativeFieldInfoPtr_evt;

			// Token: 0x0400125B RID: 4699
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400125C RID: 4700
			private static readonly IntPtr NativeMethodInfoPtr__GetValidSelectionFilter_b__0_Internal_Boolean_SelectionFilter_0;
		}

		// Token: 0x020002A8 RID: 680
		[ObfuscatedName("Canis.selectionfilters.PlayerSelectionFiltering+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Object
		{
			// Token: 0x06001CCF RID: 7375 RVA: 0x000888C8 File Offset: 0x00086AC8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<PlayerSelectionFiltering.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerSelectionFiltering>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerSelectionFiltering.__c__DisplayClass6_0>.NativeClassPtr);
				PlayerSelectionFiltering.__c__DisplayClass6_0.NativeFieldInfoPtr_evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSelectionFiltering.__c__DisplayClass6_0>.NativeClassPtr, "evt");
				PlayerSelectionFiltering.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSelectionFiltering.__c__DisplayClass6_0>.NativeClassPtr, 100664330);
				PlayerSelectionFiltering.__c__DisplayClass6_0.NativeMethodInfoPtr__GetValidAISelectionFilter_b__0_Internal_Boolean_SelectionFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSelectionFiltering.__c__DisplayClass6_0>.NativeClassPtr, 100664331);
			}

			// Token: 0x06001CD0 RID: 7376 RVA: 0x00088930 File Offset: 0x00086B30
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerSelectionFiltering.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSelectionFiltering.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001CD1 RID: 7377 RVA: 0x0008896C File Offset: 0x00086B6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetValidAISelectionFilter_b__0(SelectionFilter filter)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(filter);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSelectionFiltering.__c__DisplayClass6_0.NativeMethodInfoPtr__GetValidAISelectionFilter_b__0_Internal_Boolean_SelectionFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001CD2 RID: 7378 RVA: 0x0000DBEF File Offset: 0x0000BDEF
			public __c__DisplayClass6_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006AE RID: 1710
			// (get) Token: 0x06001CD3 RID: 7379 RVA: 0x000889BC File Offset: 0x00086BBC
			// (set) Token: 0x06001CD4 RID: 7380 RVA: 0x0000DBF8 File Offset: 0x0000BDF8
			public unsafe NetworkMessageEvent evt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFiltering.__c__DisplayClass6_0.NativeFieldInfoPtr_evt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkMessageEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFiltering.__c__DisplayClass6_0.NativeFieldInfoPtr_evt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400125D RID: 4701
			private static readonly IntPtr NativeFieldInfoPtr_evt;

			// Token: 0x0400125E RID: 4702
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400125F RID: 4703
			private static readonly IntPtr NativeMethodInfoPtr__GetValidAISelectionFilter_b__0_Internal_Boolean_SelectionFilter_0;
		}

		// Token: 0x020002A9 RID: 681
		[ObfuscatedName("Canis.selectionfilters.PlayerSelectionFiltering+<FilterSelectionTargets>d__11")]
		public sealed class _FilterSelectionTargets_d__11 : Object
		{
			// Token: 0x06001CD5 RID: 7381 RVA: 0x000889EC File Offset: 0x00086BEC
			// Note: this type is marked as 'beforefieldinit'.
			static _FilterSelectionTargets_d__11()
			{
				Il2CppClassPointerStore<PlayerSelectionFiltering._FilterSelectionTargets_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerSelectionFiltering>.NativeClassPtr, "<FilterSelectionTargets>d__11");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerSelectionFiltering._FilterSelectionTargets_d__11>.NativeClassPtr);
				PlayerSelectionFiltering._FilterSelectionTargets_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSelectionFiltering._FilterSelectionTargets_d__11>.NativeClassPtr, "<>1__state");
				PlayerSelectionFiltering._FilterSelectionTargets_d__11.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSelectionFiltering._FilterSelectionTargets_d__11>.NativeClassPtr, "<>2__current");
				PlayerSelectionFiltering._FilterSelectionTargets_d__11.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSelectionFiltering._FilterSelectionTargets_d__11>.NativeClassPtr, "<>l__initialThreadId");
				PlayerSelectionFiltering._FilterSelectionTargets_d__11.NativeFieldInfoPtr_evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSelectionFiltering._FilterSelectionTargets_d__11>.NativeClassPtr, "evt");
				PlayerSelectionFiltering._FilterSelectionTargets_d__11.NativeFieldInfoPtr___3__evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSelectionFiltering._FilterSelectionTargets_d__11>.NativeClassPtr, "<>3__evt");
				PlayerSelectionFiltering._FilterSelectionTargets_d__11.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSelectionFiltering._FilterSelectionTargets_d__11>.NativeClassPtr, "<>4__this");
				PlayerSelectionFiltering._FilterSelectionTargets_d__11.NativeFieldInfoPtr_selectionOne = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSelectionFiltering._FilterSelectionTargets_d__11>.NativeClassPtr, "selectionOne");
				PlayerSelectionFiltering._FilterSelectionTargets_d__11.NativeFieldInfoPtr___3__selectionOne = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSelectionFiltering._FilterSelectionTargets_d__11>.NativeClassPtr, "<>3__selectionOne");
				PlayerSelectionFiltering._FilterSelectionTargets_d__11.NativeFieldInfoPtr_selectionTargets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSelectionFiltering._FilterSelectionTargets_d__11>.NativeClassPtr, "selectionTargets");
				PlayerSelectionFiltering._FilterSelectionTargets_d__11.NativeFieldInfoPtr___3__selectionTargets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSelectionFiltering._FilterSelectionTargets_d__11>.NativeClassPtr, "<>3__selectionTargets");
				PlayerSelectionFiltering._FilterSelectionTargets_d__11.NativeFieldInfoPtr_forceStepOne = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSelectionFiltering._FilterSelectionTargets_d__11>.NativeClassPtr, "forceStepOne");
				PlayerSelectionFiltering._FilterSelectionTargets_d__11.NativeFieldInfoPtr___3__forceStepOne = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSelectionFiltering._FilterSelectionTargets_d__11>.NativeClassPtr, "<>3__forceStepOne");
				PlayerSelectionFiltering._FilterSelectionTargets_d__11.NativeFieldInfoPtr_canCancelStepTwo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSelectionFiltering._FilterSelectionTargets_d__11>.NativeClassPtr, "canCancelStepTwo");
				PlayerSelectionFiltering._FilterSelectionTargets_d__11.NativeFieldInfoPtr___3__canCancelStepTwo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSelectionFiltering._FilterSelectionTargets_d__11>.NativeClassPtr, "<>3__canCancelStepTwo");
				PlayerSelectionFiltering._FilterSelectionTargets_d__11.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSelectionFiltering._FilterSelectionTargets_d__11>.NativeClassPtr, "<>7__wrap1");
				PlayerSelectionFiltering._FilterSelectionTargets_d__11.NativeFieldInfoPtr__ent_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSelectionFiltering._FilterSelectionTargets_d__11>.NativeClassPtr, "<ent>5__3");
				PlayerSelectionFiltering._FilterSelectionTargets_d__11.NativeFieldInfoPtr__responses_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSelectionFiltering._FilterSelectionTargets_d__11>.NativeClassPtr, "<responses>5__4");
				PlayerSelectionFiltering._FilterSelectionTargets_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSelectionFiltering._FilterSelectionTargets_d__11>.NativeClassPtr, 100664332);
				PlayerSelectionFiltering._FilterSelectionTargets_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSelectionFiltering._FilterSelectionTargets_d__11>.NativeClassPtr, 100664333);
				PlayerSelectionFiltering._FilterSelectionTargets_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSelectionFiltering._FilterSelectionTargets_d__11>.NativeClassPtr, 100664334);
				PlayerSelectionFiltering._FilterSelectionTargets_d__11.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSelectionFiltering._FilterSelectionTargets_d__11>.NativeClassPtr, 100664335);
				PlayerSelectionFiltering._FilterSelectionTargets_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_attributes_IAttribute__get_Current_Private_Virtual_Final_New_get_IAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSelectionFiltering._FilterSelectionTargets_d__11>.NativeClassPtr, 100664336);
				PlayerSelectionFiltering._FilterSelectionTargets_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSelectionFiltering._FilterSelectionTargets_d__11>.NativeClassPtr, 100664337);
				PlayerSelectionFiltering._FilterSelectionTargets_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSelectionFiltering._FilterSelectionTargets_d__11>.NativeClassPtr, 100664338);
				PlayerSelectionFiltering._FilterSelectionTargets_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_attributes_IAttribute__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_IAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSelectionFiltering._FilterSelectionTargets_d__11>.NativeClassPtr, 100664339);
				PlayerSelectionFiltering._FilterSelectionTargets_d__11.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSelectionFiltering._FilterSelectionTargets_d__11>.NativeClassPtr, 100664340);
			}

			// Token: 0x06001CD6 RID: 7382 RVA: 0x00088C20 File Offset: 0x00086E20
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _FilterSelectionTargets_d__11(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerSelectionFiltering._FilterSelectionTargets_d__11>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSelectionFiltering._FilterSelectionTargets_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001CD7 RID: 7383 RVA: 0x00088C68 File Offset: 0x00086E68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 553837, XrefRangeEnd = 553842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSelectionFiltering._FilterSelectionTargets_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001CD8 RID: 7384 RVA: 0x00088C9C File Offset: 0x00086E9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 553842, XrefRangeEnd = 553934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSelectionFiltering._FilterSelectionTargets_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001CD9 RID: 7385 RVA: 0x00088CD8 File Offset: 0x00086ED8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 553937, RefRangeEnd = 553938, XrefRangeStart = 553934, XrefRangeEnd = 553937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSelectionFiltering._FilterSelectionTargets_d__11.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170006C0 RID: 1728
			// (get) Token: 0x06001CDA RID: 7386 RVA: 0x00088D0C File Offset: 0x00086F0C
			public unsafe IAttribute System.Collections.Generic.IEnumerator<Canis.attributes.IAttribute>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSelectionFiltering._FilterSelectionTargets_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_attributes_IAttribute__get_Current_Private_Virtual_Final_New_get_IAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAttribute>(intPtr3) : null;
				}
			}

			// Token: 0x06001CDB RID: 7387 RVA: 0x00088D4C File Offset: 0x00086F4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 553938, XrefRangeEnd = 553943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSelectionFiltering._FilterSelectionTargets_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170006C1 RID: 1729
			// (get) Token: 0x06001CDC RID: 7388 RVA: 0x00088D80 File Offset: 0x00086F80
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSelectionFiltering._FilterSelectionTargets_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001CDD RID: 7389 RVA: 0x00088DC0 File Offset: 0x00086FC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 553943, XrefRangeEnd = 553954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<IAttribute> System_Collections_Generic_IEnumerable_Canis_attributes_IAttribute__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSelectionFiltering._FilterSelectionTargets_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_attributes_IAttribute__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_IAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<IAttribute>>(intPtr3) : null;
			}

			// Token: 0x06001CDE RID: 7390 RVA: 0x00088E00 File Offset: 0x00087000
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSelectionFiltering._FilterSelectionTargets_d__11.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06001CDF RID: 7391 RVA: 0x0000DC17 File Offset: 0x0000BE17
			public _FilterSelectionTargets_d__11(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006AF RID: 1711
			// (get) Token: 0x06001CE0 RID: 7392 RVA: 0x00088E40 File Offset: 0x00087040
			// (set) Token: 0x06001CE1 RID: 7393 RVA: 0x0000DC20 File Offset: 0x0000BE20
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFiltering._FilterSelectionTargets_d__11.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFiltering._FilterSelectionTargets_d__11.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170006B0 RID: 1712
			// (get) Token: 0x06001CE2 RID: 7394 RVA: 0x00088E68 File Offset: 0x00087068
			// (set) Token: 0x06001CE3 RID: 7395 RVA: 0x0000DC3B File Offset: 0x0000BE3B
			public unsafe IAttribute __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFiltering._FilterSelectionTargets_d__11.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFiltering._FilterSelectionTargets_d__11.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006B1 RID: 1713
			// (get) Token: 0x06001CE4 RID: 7396 RVA: 0x00088E98 File Offset: 0x00087098
			// (set) Token: 0x06001CE5 RID: 7397 RVA: 0x0000DC5A File Offset: 0x0000BE5A
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFiltering._FilterSelectionTargets_d__11.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFiltering._FilterSelectionTargets_d__11.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170006B2 RID: 1714
			// (get) Token: 0x06001CE6 RID: 7398 RVA: 0x00088EC0 File Offset: 0x000870C0
			// (set) Token: 0x06001CE7 RID: 7399 RVA: 0x0000DC75 File Offset: 0x0000BE75
			public unsafe NetworkMessageEvent evt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFiltering._FilterSelectionTargets_d__11.NativeFieldInfoPtr_evt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkMessageEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFiltering._FilterSelectionTargets_d__11.NativeFieldInfoPtr_evt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006B3 RID: 1715
			// (get) Token: 0x06001CE8 RID: 7400 RVA: 0x00088EF0 File Offset: 0x000870F0
			// (set) Token: 0x06001CE9 RID: 7401 RVA: 0x0000DC94 File Offset: 0x0000BE94
			public unsafe NetworkMessageEvent __3__evt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFiltering._FilterSelectionTargets_d__11.NativeFieldInfoPtr___3__evt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkMessageEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFiltering._FilterSelectionTargets_d__11.NativeFieldInfoPtr___3__evt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006B4 RID: 1716
			// (get) Token: 0x06001CEA RID: 7402 RVA: 0x00088F20 File Offset: 0x00087120
			// (set) Token: 0x06001CEB RID: 7403 RVA: 0x0000DCB3 File Offset: 0x0000BEB3
			public unsafe PlayerSelectionFiltering __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFiltering._FilterSelectionTargets_d__11.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerSelectionFiltering>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFiltering._FilterSelectionTargets_d__11.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006B5 RID: 1717
			// (get) Token: 0x06001CEC RID: 7404 RVA: 0x00088F50 File Offset: 0x00087150
			// (set) Token: 0x06001CED RID: 7405 RVA: 0x0000DCD2 File Offset: 0x0000BED2
			public unsafe Func<Entity, bool> selectionOne
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFiltering._FilterSelectionTargets_d__11.NativeFieldInfoPtr_selectionOne);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFiltering._FilterSelectionTargets_d__11.NativeFieldInfoPtr_selectionOne), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006B6 RID: 1718
			// (get) Token: 0x06001CEE RID: 7406 RVA: 0x00088F80 File Offset: 0x00087180
			// (set) Token: 0x06001CEF RID: 7407 RVA: 0x0000DCF1 File Offset: 0x0000BEF1
			public unsafe Func<Entity, bool> __3__selectionOne
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFiltering._FilterSelectionTargets_d__11.NativeFieldInfoPtr___3__selectionOne);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFiltering._FilterSelectionTargets_d__11.NativeFieldInfoPtr___3__selectionOne), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006B7 RID: 1719
			// (get) Token: 0x06001CF0 RID: 7408 RVA: 0x00088FB0 File Offset: 0x000871B0
			// (set) Token: 0x06001CF1 RID: 7409 RVA: 0x0000DD10 File Offset: 0x0000BF10
			public unsafe Func<TargetInformation, SelectionNodeFilterData> selectionTargets
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFiltering._FilterSelectionTargets_d__11.NativeFieldInfoPtr_selectionTargets);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TargetInformation, SelectionNodeFilterData>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFiltering._FilterSelectionTargets_d__11.NativeFieldInfoPtr_selectionTargets), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006B8 RID: 1720
			// (get) Token: 0x06001CF2 RID: 7410 RVA: 0x00088FE0 File Offset: 0x000871E0
			// (set) Token: 0x06001CF3 RID: 7411 RVA: 0x0000DD2F File Offset: 0x0000BF2F
			public unsafe Func<TargetInformation, SelectionNodeFilterData> __3__selectionTargets
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFiltering._FilterSelectionTargets_d__11.NativeFieldInfoPtr___3__selectionTargets);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TargetInformation, SelectionNodeFilterData>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFiltering._FilterSelectionTargets_d__11.NativeFieldInfoPtr___3__selectionTargets), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006B9 RID: 1721
			// (get) Token: 0x06001CF4 RID: 7412 RVA: 0x00089010 File Offset: 0x00087210
			// (set) Token: 0x06001CF5 RID: 7413 RVA: 0x0000DD4E File Offset: 0x0000BF4E
			public unsafe bool forceStepOne
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFiltering._FilterSelectionTargets_d__11.NativeFieldInfoPtr_forceStepOne);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFiltering._FilterSelectionTargets_d__11.NativeFieldInfoPtr_forceStepOne)) = value;
				}
			}

			// Token: 0x170006BA RID: 1722
			// (get) Token: 0x06001CF6 RID: 7414 RVA: 0x00089038 File Offset: 0x00087238
			// (set) Token: 0x06001CF7 RID: 7415 RVA: 0x0000DD69 File Offset: 0x0000BF69
			public unsafe bool __3__forceStepOne
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFiltering._FilterSelectionTargets_d__11.NativeFieldInfoPtr___3__forceStepOne);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFiltering._FilterSelectionTargets_d__11.NativeFieldInfoPtr___3__forceStepOne)) = value;
				}
			}

			// Token: 0x170006BB RID: 1723
			// (get) Token: 0x06001CF8 RID: 7416 RVA: 0x00089060 File Offset: 0x00087260
			// (set) Token: 0x06001CF9 RID: 7417 RVA: 0x0000DD84 File Offset: 0x0000BF84
			public unsafe bool canCancelStepTwo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFiltering._FilterSelectionTargets_d__11.NativeFieldInfoPtr_canCancelStepTwo);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFiltering._FilterSelectionTargets_d__11.NativeFieldInfoPtr_canCancelStepTwo)) = value;
				}
			}

			// Token: 0x170006BC RID: 1724
			// (get) Token: 0x06001CFA RID: 7418 RVA: 0x00089088 File Offset: 0x00087288
			// (set) Token: 0x06001CFB RID: 7419 RVA: 0x0000DD9F File Offset: 0x0000BF9F
			public unsafe bool __3__canCancelStepTwo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFiltering._FilterSelectionTargets_d__11.NativeFieldInfoPtr___3__canCancelStepTwo);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFiltering._FilterSelectionTargets_d__11.NativeFieldInfoPtr___3__canCancelStepTwo)) = value;
				}
			}

			// Token: 0x170006BD RID: 1725
			// (get) Token: 0x06001CFC RID: 7420 RVA: 0x000890B0 File Offset: 0x000872B0
			// (set) Token: 0x06001CFD RID: 7421 RVA: 0x0000DDBA File Offset: 0x0000BFBA
			public Dictionary<EntityID, Il2CppReferenceArray<TargetInformation>>.Enumerator __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFiltering._FilterSelectionTargets_d__11.NativeFieldInfoPtr___7__wrap1);
					return new Dictionary<EntityID, Il2CppReferenceArray<TargetInformation>>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Dictionary<EntityID, Il2CppReferenceArray<TargetInformation>>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFiltering._FilterSelectionTargets_d__11.NativeFieldInfoPtr___7__wrap1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Dictionary<EntityID, Il2CppReferenceArray<TargetInformation>>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170006BE RID: 1726
			// (get) Token: 0x06001CFE RID: 7422 RVA: 0x000890E0 File Offset: 0x000872E0
			// (set) Token: 0x06001CFF RID: 7423 RVA: 0x0000DDE8 File Offset: 0x0000BFE8
			public unsafe Entity _ent_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFiltering._FilterSelectionTargets_d__11.NativeFieldInfoPtr__ent_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFiltering._FilterSelectionTargets_d__11.NativeFieldInfoPtr__ent_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006BF RID: 1727
			// (get) Token: 0x06001D00 RID: 7424 RVA: 0x00089110 File Offset: 0x00087310
			// (set) Token: 0x06001D01 RID: 7425 RVA: 0x0000DE07 File Offset: 0x0000C007
			public unsafe List<SelectionNodeFilterData> _responses_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFiltering._FilterSelectionTargets_d__11.NativeFieldInfoPtr__responses_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SelectionNodeFilterData>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFiltering._FilterSelectionTargets_d__11.NativeFieldInfoPtr__responses_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001260 RID: 4704
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001261 RID: 4705
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001262 RID: 4706
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001263 RID: 4707
			private static readonly IntPtr NativeFieldInfoPtr_evt;

			// Token: 0x04001264 RID: 4708
			private static readonly IntPtr NativeFieldInfoPtr___3__evt;

			// Token: 0x04001265 RID: 4709
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001266 RID: 4710
			private static readonly IntPtr NativeFieldInfoPtr_selectionOne;

			// Token: 0x04001267 RID: 4711
			private static readonly IntPtr NativeFieldInfoPtr___3__selectionOne;

			// Token: 0x04001268 RID: 4712
			private static readonly IntPtr NativeFieldInfoPtr_selectionTargets;

			// Token: 0x04001269 RID: 4713
			private static readonly IntPtr NativeFieldInfoPtr___3__selectionTargets;

			// Token: 0x0400126A RID: 4714
			private static readonly IntPtr NativeFieldInfoPtr_forceStepOne;

			// Token: 0x0400126B RID: 4715
			private static readonly IntPtr NativeFieldInfoPtr___3__forceStepOne;

			// Token: 0x0400126C RID: 4716
			private static readonly IntPtr NativeFieldInfoPtr_canCancelStepTwo;

			// Token: 0x0400126D RID: 4717
			private static readonly IntPtr NativeFieldInfoPtr___3__canCancelStepTwo;

			// Token: 0x0400126E RID: 4718
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x0400126F RID: 4719
			private static readonly IntPtr NativeFieldInfoPtr__ent_5__3;

			// Token: 0x04001270 RID: 4720
			private static readonly IntPtr NativeFieldInfoPtr__responses_5__4;

			// Token: 0x04001271 RID: 4721
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001272 RID: 4722
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001273 RID: 4723
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001274 RID: 4724
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04001275 RID: 4725
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_attributes_IAttribute__get_Current_Private_Virtual_Final_New_get_IAttribute_0;

			// Token: 0x04001276 RID: 4726
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001277 RID: 4727
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001278 RID: 4728
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_attributes_IAttribute__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_IAttribute_0;

			// Token: 0x04001279 RID: 4729
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
