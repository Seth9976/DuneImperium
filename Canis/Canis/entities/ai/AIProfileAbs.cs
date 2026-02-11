using System;
using Canis.selectionfilters;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Networking.selection.messages;
using Networking.selection.messages.outgoing;
using Networking.selection.targetinformation;

namespace Canis.entities.ai
{
	// Token: 0x02000100 RID: 256
	public class AIProfileAbs : Object
	{
		// Token: 0x06000B6D RID: 2925 RVA: 0x00049EA4 File Offset: 0x000480A4
		// Note: this type is marked as 'beforefieldinit'.
		static AIProfileAbs()
		{
			Il2CppClassPointerStore<AIProfileAbs>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities.ai", "AIProfileAbs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AIProfileAbs>.NativeClassPtr);
			AIProfileAbs.NativeMethodInfoPtr_get_Match_Protected_Abstract_Virtual_New_get_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIProfileAbs>.NativeClassPtr, 100665753);
			AIProfileAbs.NativeMethodInfoPtr_get_Player_Protected_Abstract_Virtual_New_get_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIProfileAbs>.NativeClassPtr, 100665754);
			AIProfileAbs.NativeMethodInfoPtr_get_LogColor_Protected_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIProfileAbs>.NativeClassPtr, 100665755);
			AIProfileAbs.NativeMethodInfoPtr_AILog_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIProfileAbs>.NativeClassPtr, 100665756);
			AIProfileAbs.NativeMethodInfoPtr_SelectionWithTargetsTwoStepFunctionSorted_Protected_SelectionWithTargets_SelectionWithTargetsRequired_Func_3_Entity_Entity_Int32_Boolean_Func_3_SelectionWithTargetsRequired_Func_3_Entity_Entity_Int32_Dictionary_2_ValueTuple_2_EntityID_EntityID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIProfileAbs>.NativeClassPtr, 100665757);
			AIProfileAbs.NativeMethodInfoPtr_SelectionWithTargetsFunctionSorted_Protected_SelectionWithTargets_SelectionWithTargetsRequired_Func_2_Entity_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIProfileAbs>.NativeClassPtr, 100665758);
			AIProfileAbs.NativeMethodInfoPtr_PassSelectionWithTargets_Protected_SelectionWithTargets_SelectionWithTargetsRequired_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIProfileAbs>.NativeClassPtr, 100665759);
			AIProfileAbs.NativeMethodInfoPtr_GetWeightMap_Private_Dictionary_2_EntityID_Int32_SelectionWithTargetsRequired_Func_2_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIProfileAbs>.NativeClassPtr, 100665760);
			AIProfileAbs.NativeMethodInfoPtr_SelectionWithTargetsFunctionSortedOption_Protected_SelectionWithTargets_SelectionWithTargetsRequired_Func_2_Entity_Nullable_1_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIProfileAbs>.NativeClassPtr, 100665761);
			AIProfileAbs.NativeMethodInfoPtr_GetWeightMapOption_Protected_Dictionary_2_EntityID_Int32_SelectionWithTargetsRequired_Func_2_Entity_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIProfileAbs>.NativeClassPtr, 100665762);
			AIProfileAbs.NativeMethodInfoPtr_GetTwoStepWeightMap_Private_Dictionary_2_ValueTuple_2_EntityID_EntityID_Int32_SelectionWithTargetsRequired_Func_3_Entity_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIProfileAbs>.NativeClassPtr, 100665763);
			AIProfileAbs.NativeMethodInfoPtr_EntityTargetsInSelectionWithTargetsRequired_Protected_List_1_Entity_SelectionWithTargetsRequired_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIProfileAbs>.NativeClassPtr, 100665764);
			AIProfileAbs.NativeMethodInfoPtr_EntityTargetsInTargetInfo_Private_IEnumerable_1_EntityID_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIProfileAbs>.NativeClassPtr, 100665765);
			AIProfileAbs.NativeMethodInfoPtr_GetMin_Private_Int32_SelectionWithTargetsRequired_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIProfileAbs>.NativeClassPtr, 100665766);
			AIProfileAbs.NativeMethodInfoPtr_GetMax_Private_Int32_SelectionWithTargetsRequired_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIProfileAbs>.NativeClassPtr, 100665767);
			AIProfileAbs.NativeMethodInfoPtr_PredeterminedSelection_Protected_Object_SelectionMessage_PlayerSelectionFiltering_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIProfileAbs>.NativeClassPtr, 100665768);
			AIProfileAbs.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIProfileAbs>.NativeClassPtr, 100665769);
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06000B6E RID: 2926 RVA: 0x0004A028 File Offset: 0x00048228
		public unsafe virtual Match Match
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AIProfileAbs.NativeMethodInfoPtr_get_Match_Protected_Abstract_Virtual_New_get_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Match>(intPtr3) : null;
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06000B6F RID: 2927 RVA: 0x0004A074 File Offset: 0x00048274
		public unsafe virtual PlayerEntity Player
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AIProfileAbs.NativeMethodInfoPtr_get_Player_Protected_Abstract_Virtual_New_get_PlayerEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr3) : null;
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06000B70 RID: 2928 RVA: 0x0004A0C0 File Offset: 0x000482C0
		public unsafe virtual string LogColor
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 568915, XrefRangeEnd = 568917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AIProfileAbs.NativeMethodInfoPtr_get_LogColor_Protected_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000B71 RID: 2929 RVA: 0x0004A104 File Offset: 0x00048304
		[CallerCount(203)]
		[CachedScanResults(RefRangeStart = 568917, RefRangeEnd = 569120, XrefRangeStart = 568917, XrefRangeEnd = 568917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AILog(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIProfileAbs.NativeMethodInfoPtr_AILog_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B72 RID: 2930 RVA: 0x0004A148 File Offset: 0x00048348
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 569120, XrefRangeEnd = 569254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectionWithTargets SelectionWithTargetsTwoStepFunctionSorted(SelectionWithTargetsRequired swtr, Func<Entity, Entity, int> func, bool ascending = true, Func<SelectionWithTargetsRequired, Func<Entity, Entity, int>, Dictionary<ValueTuple<EntityID, EntityID>, int>> getWeightMap = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(swtr);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(func);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ascending;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getWeightMap);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIProfileAbs.NativeMethodInfoPtr_SelectionWithTargetsTwoStepFunctionSorted_Protected_SelectionWithTargets_SelectionWithTargetsRequired_Func_3_Entity_Entity_Int32_Boolean_Func_3_SelectionWithTargetsRequired_Func_3_Entity_Entity_Int32_Dictionary_2_ValueTuple_2_EntityID_EntityID_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SelectionWithTargets>(intPtr3) : null;
		}

		// Token: 0x06000B73 RID: 2931 RVA: 0x0004A1CC File Offset: 0x000483CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 569254, XrefRangeEnd = 569386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectionWithTargets SelectionWithTargetsFunctionSorted(SelectionWithTargetsRequired swtr, Func<Entity, int> func, bool ascending = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(swtr);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(func);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ascending;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIProfileAbs.NativeMethodInfoPtr_SelectionWithTargetsFunctionSorted_Protected_SelectionWithTargets_SelectionWithTargetsRequired_Func_2_Entity_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SelectionWithTargets>(intPtr3) : null;
		}

		// Token: 0x06000B74 RID: 2932 RVA: 0x0004A23C File Offset: 0x0004843C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 569386, XrefRangeEnd = 569396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectionWithTargets PassSelectionWithTargets(SelectionWithTargetsRequired swtr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(swtr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIProfileAbs.NativeMethodInfoPtr_PassSelectionWithTargets_Protected_SelectionWithTargets_SelectionWithTargetsRequired_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SelectionWithTargets>(intPtr3) : null;
			}
		}

		// Token: 0x06000B75 RID: 2933 RVA: 0x0004A28C File Offset: 0x0004848C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 569441, RefRangeEnd = 569442, XrefRangeStart = 569396, XrefRangeEnd = 569441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dictionary<EntityID, int> GetWeightMap(SelectionWithTargetsRequired swtr, Func<Entity, int> func)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(swtr);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(func);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIProfileAbs.NativeMethodInfoPtr_GetWeightMap_Private_Dictionary_2_EntityID_Int32_SelectionWithTargetsRequired_Func_2_Entity_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<EntityID, int>>(intPtr3) : null;
		}

		// Token: 0x06000B76 RID: 2934 RVA: 0x0004A2F0 File Offset: 0x000484F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 569442, XrefRangeEnd = 569578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectionWithTargets SelectionWithTargetsFunctionSortedOption(SelectionWithTargetsRequired swtr, Func<Entity, Nullable<int>> func, bool ascending = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(swtr);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(func);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ascending;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIProfileAbs.NativeMethodInfoPtr_SelectionWithTargetsFunctionSortedOption_Protected_SelectionWithTargets_SelectionWithTargetsRequired_Func_2_Entity_Nullable_1_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SelectionWithTargets>(intPtr3) : null;
		}

		// Token: 0x06000B77 RID: 2935 RVA: 0x0004A360 File Offset: 0x00048560
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 569612, RefRangeEnd = 569613, XrefRangeStart = 569578, XrefRangeEnd = 569612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dictionary<EntityID, int> GetWeightMapOption(SelectionWithTargetsRequired swtr, Func<Entity, Nullable<int>> func)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(swtr);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(func);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIProfileAbs.NativeMethodInfoPtr_GetWeightMapOption_Protected_Dictionary_2_EntityID_Int32_SelectionWithTargetsRequired_Func_2_Entity_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<EntityID, int>>(intPtr3) : null;
		}

		// Token: 0x06000B78 RID: 2936 RVA: 0x0004A3C4 File Offset: 0x000485C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 569672, RefRangeEnd = 569673, XrefRangeStart = 569613, XrefRangeEnd = 569672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dictionary<ValueTuple<EntityID, EntityID>, int> GetTwoStepWeightMap(SelectionWithTargetsRequired swtr, Func<Entity, Entity, int> func)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(swtr);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(func);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIProfileAbs.NativeMethodInfoPtr_GetTwoStepWeightMap_Private_Dictionary_2_ValueTuple_2_EntityID_EntityID_Int32_SelectionWithTargetsRequired_Func_3_Entity_Entity_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<ValueTuple<EntityID, EntityID>, int>>(intPtr3) : null;
		}

		// Token: 0x06000B79 RID: 2937 RVA: 0x0004A428 File Offset: 0x00048628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 569673, XrefRangeEnd = 569720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Entity> EntityTargetsInSelectionWithTargetsRequired(SelectionWithTargetsRequired swtr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(swtr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIProfileAbs.NativeMethodInfoPtr_EntityTargetsInSelectionWithTargetsRequired_Protected_List_1_Entity_SelectionWithTargetsRequired_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Entity>>(intPtr3) : null;
			}
		}

		// Token: 0x06000B7A RID: 2938 RVA: 0x0004A478 File Offset: 0x00048678
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 569728, RefRangeEnd = 569730, XrefRangeStart = 569720, XrefRangeEnd = 569728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<EntityID> EntityTargetsInTargetInfo(TargetInformation targetInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIProfileAbs.NativeMethodInfoPtr_EntityTargetsInTargetInfo_Private_IEnumerable_1_EntityID_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<EntityID>>(intPtr3) : null;
			}
		}

		// Token: 0x06000B7B RID: 2939 RVA: 0x0004A4C8 File Offset: 0x000486C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 569730, XrefRangeEnd = 569741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetMin(SelectionWithTargetsRequired swtr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(swtr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIProfileAbs.NativeMethodInfoPtr_GetMin_Private_Int32_SelectionWithTargetsRequired_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B7C RID: 2940 RVA: 0x0004A518 File Offset: 0x00048718
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 569752, RefRangeEnd = 569754, XrefRangeStart = 569741, XrefRangeEnd = 569752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetMax(SelectionWithTargetsRequired swtr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(swtr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIProfileAbs.NativeMethodInfoPtr_GetMax_Private_Int32_SelectionWithTargetsRequired_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B7D RID: 2941 RVA: 0x0004A568 File Offset: 0x00048768
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 569754, XrefRangeEnd = 569897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object PredeterminedSelection(SelectionMessage selection, PlayerSelectionFiltering selectionFiltering)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selection);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selectionFiltering);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIProfileAbs.NativeMethodInfoPtr_PredeterminedSelection_Protected_Object_SelectionMessage_PlayerSelectionFiltering_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000B7E RID: 2942 RVA: 0x0004A5CC File Offset: 0x000487CC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AIProfileAbs()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AIProfileAbs>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIProfileAbs.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B7F RID: 2943 RVA: 0x0000630F File Offset: 0x0000450F
		public AIProfileAbs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040007C5 RID: 1989
		private static readonly IntPtr NativeMethodInfoPtr_get_Match_Protected_Abstract_Virtual_New_get_Match_0;

		// Token: 0x040007C6 RID: 1990
		private static readonly IntPtr NativeMethodInfoPtr_get_Player_Protected_Abstract_Virtual_New_get_PlayerEntity_0;

		// Token: 0x040007C7 RID: 1991
		private static readonly IntPtr NativeMethodInfoPtr_get_LogColor_Protected_Virtual_New_get_String_0;

		// Token: 0x040007C8 RID: 1992
		private static readonly IntPtr NativeMethodInfoPtr_AILog_Public_Void_String_0;

		// Token: 0x040007C9 RID: 1993
		private static readonly IntPtr NativeMethodInfoPtr_SelectionWithTargetsTwoStepFunctionSorted_Protected_SelectionWithTargets_SelectionWithTargetsRequired_Func_3_Entity_Entity_Int32_Boolean_Func_3_SelectionWithTargetsRequired_Func_3_Entity_Entity_Int32_Dictionary_2_ValueTuple_2_EntityID_EntityID_Int32_0;

		// Token: 0x040007CA RID: 1994
		private static readonly IntPtr NativeMethodInfoPtr_SelectionWithTargetsFunctionSorted_Protected_SelectionWithTargets_SelectionWithTargetsRequired_Func_2_Entity_Int32_Boolean_0;

		// Token: 0x040007CB RID: 1995
		private static readonly IntPtr NativeMethodInfoPtr_PassSelectionWithTargets_Protected_SelectionWithTargets_SelectionWithTargetsRequired_0;

		// Token: 0x040007CC RID: 1996
		private static readonly IntPtr NativeMethodInfoPtr_GetWeightMap_Private_Dictionary_2_EntityID_Int32_SelectionWithTargetsRequired_Func_2_Entity_Int32_0;

		// Token: 0x040007CD RID: 1997
		private static readonly IntPtr NativeMethodInfoPtr_SelectionWithTargetsFunctionSortedOption_Protected_SelectionWithTargets_SelectionWithTargetsRequired_Func_2_Entity_Nullable_1_Int32_Boolean_0;

		// Token: 0x040007CE RID: 1998
		private static readonly IntPtr NativeMethodInfoPtr_GetWeightMapOption_Protected_Dictionary_2_EntityID_Int32_SelectionWithTargetsRequired_Func_2_Entity_Nullable_1_Int32_0;

		// Token: 0x040007CF RID: 1999
		private static readonly IntPtr NativeMethodInfoPtr_GetTwoStepWeightMap_Private_Dictionary_2_ValueTuple_2_EntityID_EntityID_Int32_SelectionWithTargetsRequired_Func_3_Entity_Entity_Int32_0;

		// Token: 0x040007D0 RID: 2000
		private static readonly IntPtr NativeMethodInfoPtr_EntityTargetsInSelectionWithTargetsRequired_Protected_List_1_Entity_SelectionWithTargetsRequired_0;

		// Token: 0x040007D1 RID: 2001
		private static readonly IntPtr NativeMethodInfoPtr_EntityTargetsInTargetInfo_Private_IEnumerable_1_EntityID_TargetInformation_0;

		// Token: 0x040007D2 RID: 2002
		private static readonly IntPtr NativeMethodInfoPtr_GetMin_Private_Int32_SelectionWithTargetsRequired_0;

		// Token: 0x040007D3 RID: 2003
		private static readonly IntPtr NativeMethodInfoPtr_GetMax_Private_Int32_SelectionWithTargetsRequired_0;

		// Token: 0x040007D4 RID: 2004
		private static readonly IntPtr NativeMethodInfoPtr_PredeterminedSelection_Protected_Object_SelectionMessage_PlayerSelectionFiltering_0;

		// Token: 0x040007D5 RID: 2005
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x02000345 RID: 837
		[ObfuscatedName("Canis.entities.ai.AIProfileAbs+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060022F8 RID: 8952 RVA: 0x0009CCD4 File Offset: 0x0009AED4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<AIProfileAbs.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AIProfileAbs>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AIProfileAbs.__c>.NativeClassPtr);
				AIProfileAbs.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIProfileAbs.__c>.NativeClassPtr, "<>9");
				AIProfileAbs.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIProfileAbs.__c>.NativeClassPtr, "<>9__7_0");
				AIProfileAbs.__c.NativeFieldInfoPtr___9__7_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIProfileAbs.__c>.NativeClassPtr, "<>9__7_1");
				AIProfileAbs.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIProfileAbs.__c>.NativeClassPtr, "<>9__8_0");
				AIProfileAbs.__c.NativeFieldInfoPtr___9__8_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIProfileAbs.__c>.NativeClassPtr, "<>9__8_1");
				AIProfileAbs.__c.NativeFieldInfoPtr___9__8_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIProfileAbs.__c>.NativeClassPtr, "<>9__8_2");
				AIProfileAbs.__c.NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIProfileAbs.__c>.NativeClassPtr, "<>9__11_0");
				AIProfileAbs.__c.NativeFieldInfoPtr___9__11_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIProfileAbs.__c>.NativeClassPtr, "<>9__11_1");
				AIProfileAbs.__c.NativeFieldInfoPtr___9__11_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIProfileAbs.__c>.NativeClassPtr, "<>9__11_2");
				AIProfileAbs.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIProfileAbs.__c>.NativeClassPtr, 100665771);
				AIProfileAbs.__c.NativeMethodInfoPtr__SelectionWithTargetsTwoStepFunctionSorted_b__7_0_Internal_Int32_KeyValuePair_2_ValueTuple_2_EntityID_EntityID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIProfileAbs.__c>.NativeClassPtr, 100665772);
				AIProfileAbs.__c.NativeMethodInfoPtr__SelectionWithTargetsTwoStepFunctionSorted_b__7_1_Internal_Int32_KeyValuePair_2_ValueTuple_2_EntityID_EntityID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIProfileAbs.__c>.NativeClassPtr, 100665773);
				AIProfileAbs.__c.NativeMethodInfoPtr__SelectionWithTargetsFunctionSorted_b__8_0_Internal_Int32_KeyValuePair_2_EntityID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIProfileAbs.__c>.NativeClassPtr, 100665774);
				AIProfileAbs.__c.NativeMethodInfoPtr__SelectionWithTargetsFunctionSorted_b__8_1_Internal_Int32_KeyValuePair_2_EntityID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIProfileAbs.__c>.NativeClassPtr, 100665775);
				AIProfileAbs.__c.NativeMethodInfoPtr__SelectionWithTargetsFunctionSorted_b__8_2_Internal_EntityID_KeyValuePair_2_EntityID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIProfileAbs.__c>.NativeClassPtr, 100665776);
				AIProfileAbs.__c.NativeMethodInfoPtr__SelectionWithTargetsFunctionSortedOption_b__11_0_Internal_Int32_KeyValuePair_2_EntityID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIProfileAbs.__c>.NativeClassPtr, 100665777);
				AIProfileAbs.__c.NativeMethodInfoPtr__SelectionWithTargetsFunctionSortedOption_b__11_1_Internal_Int32_KeyValuePair_2_EntityID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIProfileAbs.__c>.NativeClassPtr, 100665778);
				AIProfileAbs.__c.NativeMethodInfoPtr__SelectionWithTargetsFunctionSortedOption_b__11_2_Internal_EntityID_KeyValuePair_2_EntityID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIProfileAbs.__c>.NativeClassPtr, 100665779);
			}

			// Token: 0x060022F9 RID: 8953 RVA: 0x0009CE68 File Offset: 0x0009B068
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AIProfileAbs.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIProfileAbs.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060022FA RID: 8954 RVA: 0x0009CEA4 File Offset: 0x0009B0A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 568907, XrefRangeEnd = 568908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _SelectionWithTargetsTwoStepFunctionSorted_b__7_0(KeyValuePair<ValueTuple<EntityID, EntityID>, int> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIProfileAbs.__c.NativeMethodInfoPtr__SelectionWithTargetsTwoStepFunctionSorted_b__7_0_Internal_Int32_KeyValuePair_2_ValueTuple_2_EntityID_EntityID_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060022FB RID: 8955 RVA: 0x0009CEF8 File Offset: 0x0009B0F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 568908, XrefRangeEnd = 568909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _SelectionWithTargetsTwoStepFunctionSorted_b__7_1(KeyValuePair<ValueTuple<EntityID, EntityID>, int> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIProfileAbs.__c.NativeMethodInfoPtr__SelectionWithTargetsTwoStepFunctionSorted_b__7_1_Internal_Int32_KeyValuePair_2_ValueTuple_2_EntityID_EntityID_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060022FC RID: 8956 RVA: 0x0009CF4C File Offset: 0x0009B14C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 568909, XrefRangeEnd = 568910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _SelectionWithTargetsFunctionSorted_b__8_0(KeyValuePair<EntityID, int> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIProfileAbs.__c.NativeMethodInfoPtr__SelectionWithTargetsFunctionSorted_b__8_0_Internal_Int32_KeyValuePair_2_EntityID_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060022FD RID: 8957 RVA: 0x0009CFA0 File Offset: 0x0009B1A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 568910, XrefRangeEnd = 568911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _SelectionWithTargetsFunctionSorted_b__8_1(KeyValuePair<EntityID, int> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIProfileAbs.__c.NativeMethodInfoPtr__SelectionWithTargetsFunctionSorted_b__8_1_Internal_Int32_KeyValuePair_2_EntityID_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060022FE RID: 8958 RVA: 0x0009CFF4 File Offset: 0x0009B1F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 568911, XrefRangeEnd = 568912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EntityID _SelectionWithTargetsFunctionSorted_b__8_2(KeyValuePair<EntityID, int> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIProfileAbs.__c.NativeMethodInfoPtr__SelectionWithTargetsFunctionSorted_b__8_2_Internal_EntityID_KeyValuePair_2_EntityID_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
				}
			}

			// Token: 0x060022FF RID: 8959 RVA: 0x0009D04C File Offset: 0x0009B24C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 568912, XrefRangeEnd = 568913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _SelectionWithTargetsFunctionSortedOption_b__11_0(KeyValuePair<EntityID, int> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIProfileAbs.__c.NativeMethodInfoPtr__SelectionWithTargetsFunctionSortedOption_b__11_0_Internal_Int32_KeyValuePair_2_EntityID_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002300 RID: 8960 RVA: 0x0009D0A0 File Offset: 0x0009B2A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 568913, XrefRangeEnd = 568914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _SelectionWithTargetsFunctionSortedOption_b__11_1(KeyValuePair<EntityID, int> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIProfileAbs.__c.NativeMethodInfoPtr__SelectionWithTargetsFunctionSortedOption_b__11_1_Internal_Int32_KeyValuePair_2_EntityID_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002301 RID: 8961 RVA: 0x0009D0F4 File Offset: 0x0009B2F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 568914, XrefRangeEnd = 568915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EntityID _SelectionWithTargetsFunctionSortedOption_b__11_2(KeyValuePair<EntityID, int> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIProfileAbs.__c.NativeMethodInfoPtr__SelectionWithTargetsFunctionSortedOption_b__11_2_Internal_EntityID_KeyValuePair_2_EntityID_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
				}
			}

			// Token: 0x06002302 RID: 8962 RVA: 0x00010CE8 File Offset: 0x0000EEE8
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000889 RID: 2185
			// (get) Token: 0x06002303 RID: 8963 RVA: 0x0009D14C File Offset: 0x0009B34C
			// (set) Token: 0x06002304 RID: 8964 RVA: 0x00010CF1 File Offset: 0x0000EEF1
			public unsafe static AIProfileAbs.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AIProfileAbs.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AIProfileAbs.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AIProfileAbs.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700088A RID: 2186
			// (get) Token: 0x06002305 RID: 8965 RVA: 0x0009D174 File Offset: 0x0009B374
			// (set) Token: 0x06002306 RID: 8966 RVA: 0x00010D03 File Offset: 0x0000EF03
			public unsafe static Func<KeyValuePair<ValueTuple<EntityID, EntityID>, int>, int> __9__7_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AIProfileAbs.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<ValueTuple<EntityID, EntityID>, int>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AIProfileAbs.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700088B RID: 2187
			// (get) Token: 0x06002307 RID: 8967 RVA: 0x0009D19C File Offset: 0x0009B39C
			// (set) Token: 0x06002308 RID: 8968 RVA: 0x00010D15 File Offset: 0x0000EF15
			public unsafe static Func<KeyValuePair<ValueTuple<EntityID, EntityID>, int>, int> __9__7_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AIProfileAbs.__c.NativeFieldInfoPtr___9__7_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<ValueTuple<EntityID, EntityID>, int>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AIProfileAbs.__c.NativeFieldInfoPtr___9__7_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700088C RID: 2188
			// (get) Token: 0x06002309 RID: 8969 RVA: 0x0009D1C4 File Offset: 0x0009B3C4
			// (set) Token: 0x0600230A RID: 8970 RVA: 0x00010D27 File Offset: 0x0000EF27
			public unsafe static Func<KeyValuePair<EntityID, int>, int> __9__8_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AIProfileAbs.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<EntityID, int>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AIProfileAbs.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700088D RID: 2189
			// (get) Token: 0x0600230B RID: 8971 RVA: 0x0009D1EC File Offset: 0x0009B3EC
			// (set) Token: 0x0600230C RID: 8972 RVA: 0x00010D39 File Offset: 0x0000EF39
			public unsafe static Func<KeyValuePair<EntityID, int>, int> __9__8_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AIProfileAbs.__c.NativeFieldInfoPtr___9__8_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<EntityID, int>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AIProfileAbs.__c.NativeFieldInfoPtr___9__8_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700088E RID: 2190
			// (get) Token: 0x0600230D RID: 8973 RVA: 0x0009D214 File Offset: 0x0009B414
			// (set) Token: 0x0600230E RID: 8974 RVA: 0x00010D4B File Offset: 0x0000EF4B
			public unsafe static Func<KeyValuePair<EntityID, int>, EntityID> __9__8_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AIProfileAbs.__c.NativeFieldInfoPtr___9__8_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<EntityID, int>, EntityID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AIProfileAbs.__c.NativeFieldInfoPtr___9__8_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700088F RID: 2191
			// (get) Token: 0x0600230F RID: 8975 RVA: 0x0009D23C File Offset: 0x0009B43C
			// (set) Token: 0x06002310 RID: 8976 RVA: 0x00010D5D File Offset: 0x0000EF5D
			public unsafe static Func<KeyValuePair<EntityID, int>, int> __9__11_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AIProfileAbs.__c.NativeFieldInfoPtr___9__11_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<EntityID, int>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AIProfileAbs.__c.NativeFieldInfoPtr___9__11_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000890 RID: 2192
			// (get) Token: 0x06002311 RID: 8977 RVA: 0x0009D264 File Offset: 0x0009B464
			// (set) Token: 0x06002312 RID: 8978 RVA: 0x00010D6F File Offset: 0x0000EF6F
			public unsafe static Func<KeyValuePair<EntityID, int>, int> __9__11_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AIProfileAbs.__c.NativeFieldInfoPtr___9__11_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<EntityID, int>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AIProfileAbs.__c.NativeFieldInfoPtr___9__11_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000891 RID: 2193
			// (get) Token: 0x06002313 RID: 8979 RVA: 0x0009D28C File Offset: 0x0009B48C
			// (set) Token: 0x06002314 RID: 8980 RVA: 0x00010D81 File Offset: 0x0000EF81
			public unsafe static Func<KeyValuePair<EntityID, int>, EntityID> __9__11_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AIProfileAbs.__c.NativeFieldInfoPtr___9__11_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<EntityID, int>, EntityID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AIProfileAbs.__c.NativeFieldInfoPtr___9__11_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040015F8 RID: 5624
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040015F9 RID: 5625
			private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

			// Token: 0x040015FA RID: 5626
			private static readonly IntPtr NativeFieldInfoPtr___9__7_1;

			// Token: 0x040015FB RID: 5627
			private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x040015FC RID: 5628
			private static readonly IntPtr NativeFieldInfoPtr___9__8_1;

			// Token: 0x040015FD RID: 5629
			private static readonly IntPtr NativeFieldInfoPtr___9__8_2;

			// Token: 0x040015FE RID: 5630
			private static readonly IntPtr NativeFieldInfoPtr___9__11_0;

			// Token: 0x040015FF RID: 5631
			private static readonly IntPtr NativeFieldInfoPtr___9__11_1;

			// Token: 0x04001600 RID: 5632
			private static readonly IntPtr NativeFieldInfoPtr___9__11_2;

			// Token: 0x04001601 RID: 5633
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001602 RID: 5634
			private static readonly IntPtr NativeMethodInfoPtr__SelectionWithTargetsTwoStepFunctionSorted_b__7_0_Internal_Int32_KeyValuePair_2_ValueTuple_2_EntityID_EntityID_Int32_0;

			// Token: 0x04001603 RID: 5635
			private static readonly IntPtr NativeMethodInfoPtr__SelectionWithTargetsTwoStepFunctionSorted_b__7_1_Internal_Int32_KeyValuePair_2_ValueTuple_2_EntityID_EntityID_Int32_0;

			// Token: 0x04001604 RID: 5636
			private static readonly IntPtr NativeMethodInfoPtr__SelectionWithTargetsFunctionSorted_b__8_0_Internal_Int32_KeyValuePair_2_EntityID_Int32_0;

			// Token: 0x04001605 RID: 5637
			private static readonly IntPtr NativeMethodInfoPtr__SelectionWithTargetsFunctionSorted_b__8_1_Internal_Int32_KeyValuePair_2_EntityID_Int32_0;

			// Token: 0x04001606 RID: 5638
			private static readonly IntPtr NativeMethodInfoPtr__SelectionWithTargetsFunctionSorted_b__8_2_Internal_EntityID_KeyValuePair_2_EntityID_Int32_0;

			// Token: 0x04001607 RID: 5639
			private static readonly IntPtr NativeMethodInfoPtr__SelectionWithTargetsFunctionSortedOption_b__11_0_Internal_Int32_KeyValuePair_2_EntityID_Int32_0;

			// Token: 0x04001608 RID: 5640
			private static readonly IntPtr NativeMethodInfoPtr__SelectionWithTargetsFunctionSortedOption_b__11_1_Internal_Int32_KeyValuePair_2_EntityID_Int32_0;

			// Token: 0x04001609 RID: 5641
			private static readonly IntPtr NativeMethodInfoPtr__SelectionWithTargetsFunctionSortedOption_b__11_2_Internal_EntityID_KeyValuePair_2_EntityID_Int32_0;
		}
	}
}
