using System;
using System.Runtime.InteropServices;
using Canis.actions;
using Canis.context;
using Canis.events;
using Canis.selectionfilters;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Linq;
using Utils;

namespace Canis.tutorialScripts
{
	// Token: 0x02000037 RID: 55
	public class AdvancedTutorialScript : TutorialScript
	{
		// Token: 0x06000369 RID: 873 RVA: 0x00027194 File Offset: 0x00025394
		// Note: this type is marked as 'beforefieldinit'.
		static AdvancedTutorialScript()
		{
			Il2CppClassPointerStore<AdvancedTutorialScript>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.tutorialScripts", "AdvancedTutorialScript");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AdvancedTutorialScript>.NativeClassPtr);
			AdvancedTutorialScript.NativeFieldInfoPtr__cachedActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedTutorialScript>.NativeClassPtr, "_cachedActions");
			AdvancedTutorialScript.NativeFieldInfoPtr__cachedHumanAIFilters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedTutorialScript>.NativeClassPtr, "_cachedHumanAIFilters");
			AdvancedTutorialScript.NativeFieldInfoPtr__cachedAIFilters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedTutorialScript>.NativeClassPtr, "_cachedAIFilters");
			AdvancedTutorialScript.NativeFieldInfoPtr__cachedFilterByIdentifer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedTutorialScript>.NativeClassPtr, "_cachedFilterByIdentifer");
			AdvancedTutorialScript.NativeMethodInfoPtr_innerActions_Protected_Virtual_Final_List_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedTutorialScript>.NativeClassPtr, 100664024);
			AdvancedTutorialScript.NativeMethodInfoPtr_tutorialHumanFilters_Public_List_1_SelectionFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedTutorialScript>.NativeClassPtr, 100664025);
			AdvancedTutorialScript.NativeMethodInfoPtr_tutorialAIFilters_Public_List_1_SelectionFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedTutorialScript>.NativeClassPtr, 100664026);
			AdvancedTutorialScript.NativeMethodInfoPtr_getFiltersByIdentifier_Public_List_1_SelectionFilter_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedTutorialScript>.NativeClassPtr, 100664027);
			AdvancedTutorialScript.NativeMethodInfoPtr_tutorialItems_Protected_Virtual_New_IEnumerable_1_TutorialItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedTutorialScript>.NativeClassPtr, 100664028);
			AdvancedTutorialScript.NativeMethodInfoPtr__ctor_Protected_Void_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedTutorialScript>.NativeClassPtr, 100664029);
			AdvancedTutorialScript.NativeMethodInfoPtr_ObjectiveAt_Protected_Func_2_Context_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedTutorialScript>.NativeClassPtr, 100664030);
			AdvancedTutorialScript.NativeMethodInfoPtr_ObjectiveAtOrGreater_Protected_Func_2_Context_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedTutorialScript>.NativeClassPtr, 100664031);
			AdvancedTutorialScript.NativeMethodInfoPtr_ObjectiveCompleted_Protected_Func_2_Context_Boolean_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedTutorialScript>.NativeClassPtr, 100664032);
			AdvancedTutorialScript.NativeMethodInfoPtr_objectiveCheck_Protected_Event_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedTutorialScript>.NativeClassPtr, 100664033);
			AdvancedTutorialScript.NativeMethodInfoPtr_objectiveComplete_Protected_Event_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedTutorialScript>.NativeClassPtr, 100664034);
			AdvancedTutorialScript.NativeMethodInfoPtr___ctor_b__9_0_Private_List_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedTutorialScript>.NativeClassPtr, 100664035);
			AdvancedTutorialScript.NativeMethodInfoPtr___ctor_b__9_1_Private_List_1_SelectionFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedTutorialScript>.NativeClassPtr, 100664036);
			AdvancedTutorialScript.NativeMethodInfoPtr___ctor_b__9_2_Private_List_1_SelectionFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedTutorialScript>.NativeClassPtr, 100664037);
			AdvancedTutorialScript.NativeMethodInfoPtr___ctor_b__9_3_Private_Dictionary_2_String_List_1_SelectionFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedTutorialScript>.NativeClassPtr, 100664038);
		}

		// Token: 0x0600036A RID: 874 RVA: 0x00027340 File Offset: 0x00025540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 550530, XrefRangeEnd = 550534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override List<Canis.actions.Action> innerActions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedTutorialScript.NativeMethodInfoPtr_innerActions_Protected_Virtual_Final_List_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x0600036B RID: 875 RVA: 0x00027380 File Offset: 0x00025580
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 550538, RefRangeEnd = 550539, XrefRangeStart = 550534, XrefRangeEnd = 550538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<SelectionFilter> tutorialHumanFilters()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedTutorialScript.NativeMethodInfoPtr_tutorialHumanFilters_Public_List_1_SelectionFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<SelectionFilter>>(intPtr3) : null;
		}

		// Token: 0x0600036C RID: 876 RVA: 0x000273C0 File Offset: 0x000255C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 550543, RefRangeEnd = 550544, XrefRangeStart = 550539, XrefRangeEnd = 550543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<SelectionFilter> tutorialAIFilters()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedTutorialScript.NativeMethodInfoPtr_tutorialAIFilters_Public_List_1_SelectionFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<SelectionFilter>>(intPtr3) : null;
		}

		// Token: 0x0600036D RID: 877 RVA: 0x00027400 File Offset: 0x00025600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 550544, XrefRangeEnd = 550552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<SelectionFilter> getFiltersByIdentifier(string identifier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(identifier);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedTutorialScript.NativeMethodInfoPtr_getFiltersByIdentifier_Public_List_1_SelectionFilter_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<SelectionFilter>>(intPtr3) : null;
			}
		}

		// Token: 0x0600036E RID: 878 RVA: 0x00027450 File Offset: 0x00025650
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 550552, XrefRangeEnd = 550555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerable<AdvancedTutorialScript.TutorialItem> tutorialItems()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AdvancedTutorialScript.NativeMethodInfoPtr_tutorialItems_Protected_Virtual_New_IEnumerable_1_TutorialItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<AdvancedTutorialScript.TutorialItem>>(intPtr3) : null;
		}

		// Token: 0x0600036F RID: 879 RVA: 0x0002749C File Offset: 0x0002569C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 550605, RefRangeEnd = 550606, XrefRangeStart = 550555, XrefRangeEnd = 550605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AdvancedTutorialScript(Match match)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AdvancedTutorialScript>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedTutorialScript.NativeMethodInfoPtr__ctor_Protected_Void_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000370 RID: 880 RVA: 0x000274E8 File Offset: 0x000256E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 550606, XrefRangeEnd = 550617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Func<Context, bool> ObjectiveAt(int objective, int current)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref objective;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref current;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedTutorialScript.NativeMethodInfoPtr_ObjectiveAt_Protected_Func_2_Context_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<Context, bool>>(intPtr3) : null;
		}

		// Token: 0x06000371 RID: 881 RVA: 0x00027544 File Offset: 0x00025744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 550617, XrefRangeEnd = 550628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Func<Context, bool> ObjectiveAtOrGreater(int objective, int current)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref objective;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref current;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedTutorialScript.NativeMethodInfoPtr_ObjectiveAtOrGreater_Protected_Func_2_Context_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<Context, bool>>(intPtr3) : null;
		}

		// Token: 0x06000372 RID: 882 RVA: 0x000275A0 File Offset: 0x000257A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 550628, XrefRangeEnd = 550640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Func<Context, bool> ObjectiveCompleted(Il2CppStructArray<int> objectives)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectives);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedTutorialScript.NativeMethodInfoPtr_ObjectiveCompleted_Protected_Func_2_Context_Boolean_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<Context, bool>>(intPtr3) : null;
			}
		}

		// Token: 0x06000373 RID: 883 RVA: 0x000275F0 File Offset: 0x000257F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 550640, XrefRangeEnd = 550659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Event objectiveCheck(int objective, int current)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref objective;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref current;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedTutorialScript.NativeMethodInfoPtr_objectiveCheck_Protected_Event_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Event>(intPtr3) : null;
		}

		// Token: 0x06000374 RID: 884 RVA: 0x0002764C File Offset: 0x0002584C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 550679, RefRangeEnd = 550688, XrefRangeStart = 550659, XrefRangeEnd = 550679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Event objectiveComplete([Optional] Il2CppStructArray<int> objectives)
		{
			if (objectives == null)
			{
				objectives = new Il2CppStructArray<int>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectives);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedTutorialScript.NativeMethodInfoPtr_objectiveComplete_Protected_Event_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Event>(intPtr3) : null;
			}
		}

		// Token: 0x06000375 RID: 885 RVA: 0x000276AC File Offset: 0x000258AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 550688, XrefRangeEnd = 550709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Canis.actions.Action> __ctor_b__9_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedTutorialScript.NativeMethodInfoPtr___ctor_b__9_0_Private_List_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06000376 RID: 886 RVA: 0x000276EC File Offset: 0x000258EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 550709, XrefRangeEnd = 550730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<SelectionFilter> __ctor_b__9_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedTutorialScript.NativeMethodInfoPtr___ctor_b__9_1_Private_List_1_SelectionFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<SelectionFilter>>(intPtr3) : null;
		}

		// Token: 0x06000377 RID: 887 RVA: 0x0002772C File Offset: 0x0002592C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 550730, XrefRangeEnd = 550751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<SelectionFilter> __ctor_b__9_2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedTutorialScript.NativeMethodInfoPtr___ctor_b__9_2_Private_List_1_SelectionFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<SelectionFilter>>(intPtr3) : null;
		}

		// Token: 0x06000378 RID: 888 RVA: 0x0002776C File Offset: 0x0002596C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 550751, XrefRangeEnd = 550834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dictionary<string, List<SelectionFilter>> __ctor_b__9_3()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedTutorialScript.NativeMethodInfoPtr___ctor_b__9_3_Private_Dictionary_2_String_List_1_SelectionFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, List<SelectionFilter>>>(intPtr3) : null;
		}

		// Token: 0x06000379 RID: 889 RVA: 0x00003821 File Offset: 0x00001A21
		public Event objectiveComplete(params int[] objectives)
		{
			return this.objectiveComplete(new Il2CppStructArray<int>(objectives));
		}

		// Token: 0x0600037A RID: 890 RVA: 0x0000382F File Offset: 0x00001A2F
		public AdvancedTutorialScript(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x0600037B RID: 891 RVA: 0x000277AC File Offset: 0x000259AC
		// (set) Token: 0x0600037C RID: 892 RVA: 0x00003838 File Offset: 0x00001A38
		public unsafe Cached<List<Canis.actions.Action>> _cachedActions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedTutorialScript.NativeFieldInfoPtr__cachedActions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Cached<List<Canis.actions.Action>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedTutorialScript.NativeFieldInfoPtr__cachedActions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x0600037D RID: 893 RVA: 0x000277DC File Offset: 0x000259DC
		// (set) Token: 0x0600037E RID: 894 RVA: 0x00003857 File Offset: 0x00001A57
		public unsafe Cached<List<SelectionFilter>> _cachedHumanAIFilters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedTutorialScript.NativeFieldInfoPtr__cachedHumanAIFilters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Cached<List<SelectionFilter>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedTutorialScript.NativeFieldInfoPtr__cachedHumanAIFilters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x0600037F RID: 895 RVA: 0x0002780C File Offset: 0x00025A0C
		// (set) Token: 0x06000380 RID: 896 RVA: 0x00003876 File Offset: 0x00001A76
		public unsafe Cached<List<SelectionFilter>> _cachedAIFilters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedTutorialScript.NativeFieldInfoPtr__cachedAIFilters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Cached<List<SelectionFilter>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedTutorialScript.NativeFieldInfoPtr__cachedAIFilters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000381 RID: 897 RVA: 0x0002783C File Offset: 0x00025A3C
		// (set) Token: 0x06000382 RID: 898 RVA: 0x00003895 File Offset: 0x00001A95
		public unsafe Cached<Dictionary<string, List<SelectionFilter>>> _cachedFilterByIdentifer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedTutorialScript.NativeFieldInfoPtr__cachedFilterByIdentifer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Cached<Dictionary<string, List<SelectionFilter>>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedTutorialScript.NativeFieldInfoPtr__cachedFilterByIdentifer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000241 RID: 577
		private static readonly IntPtr NativeFieldInfoPtr__cachedActions;

		// Token: 0x04000242 RID: 578
		private static readonly IntPtr NativeFieldInfoPtr__cachedHumanAIFilters;

		// Token: 0x04000243 RID: 579
		private static readonly IntPtr NativeFieldInfoPtr__cachedAIFilters;

		// Token: 0x04000244 RID: 580
		private static readonly IntPtr NativeFieldInfoPtr__cachedFilterByIdentifer;

		// Token: 0x04000245 RID: 581
		private static readonly IntPtr NativeMethodInfoPtr_innerActions_Protected_Virtual_Final_List_1_Action_0;

		// Token: 0x04000246 RID: 582
		private static readonly IntPtr NativeMethodInfoPtr_tutorialHumanFilters_Public_List_1_SelectionFilter_0;

		// Token: 0x04000247 RID: 583
		private static readonly IntPtr NativeMethodInfoPtr_tutorialAIFilters_Public_List_1_SelectionFilter_0;

		// Token: 0x04000248 RID: 584
		private static readonly IntPtr NativeMethodInfoPtr_getFiltersByIdentifier_Public_List_1_SelectionFilter_String_0;

		// Token: 0x04000249 RID: 585
		private static readonly IntPtr NativeMethodInfoPtr_tutorialItems_Protected_Virtual_New_IEnumerable_1_TutorialItem_0;

		// Token: 0x0400024A RID: 586
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Match_0;

		// Token: 0x0400024B RID: 587
		private static readonly IntPtr NativeMethodInfoPtr_ObjectiveAt_Protected_Func_2_Context_Boolean_Int32_Int32_0;

		// Token: 0x0400024C RID: 588
		private static readonly IntPtr NativeMethodInfoPtr_ObjectiveAtOrGreater_Protected_Func_2_Context_Boolean_Int32_Int32_0;

		// Token: 0x0400024D RID: 589
		private static readonly IntPtr NativeMethodInfoPtr_ObjectiveCompleted_Protected_Func_2_Context_Boolean_Il2CppStructArray_1_Int32_0;

		// Token: 0x0400024E RID: 590
		private static readonly IntPtr NativeMethodInfoPtr_objectiveCheck_Protected_Event_Int32_Int32_0;

		// Token: 0x0400024F RID: 591
		private static readonly IntPtr NativeMethodInfoPtr_objectiveComplete_Protected_Event_Il2CppStructArray_1_Int32_0;

		// Token: 0x04000250 RID: 592
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__9_0_Private_List_1_Action_0;

		// Token: 0x04000251 RID: 593
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__9_1_Private_List_1_SelectionFilter_0;

		// Token: 0x04000252 RID: 594
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__9_2_Private_List_1_SelectionFilter_0;

		// Token: 0x04000253 RID: 595
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__9_3_Private_Dictionary_2_String_List_1_SelectionFilter_0;

		// Token: 0x02000283 RID: 643
		public enum FilterType
		{
			// Token: 0x0400116A RID: 4458
			Human,
			// Token: 0x0400116B RID: 4459
			AI
		}

		// Token: 0x02000284 RID: 644
		public enum TutorialItemType
		{
			// Token: 0x0400116D RID: 4461
			Action,
			// Token: 0x0400116E RID: 4462
			SelectionFilter
		}

		// Token: 0x02000285 RID: 645
		public class TutorialItem : Object
		{
			// Token: 0x06001B4F RID: 6991 RVA: 0x00083C68 File Offset: 0x00081E68
			// Note: this type is marked as 'beforefieldinit'.
			static TutorialItem()
			{
				Il2CppClassPointerStore<AdvancedTutorialScript.TutorialItem>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AdvancedTutorialScript>.NativeClassPtr, "TutorialItem");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AdvancedTutorialScript.TutorialItem>.NativeClassPtr);
				AdvancedTutorialScript.TutorialItem.NativeFieldInfoPtr__type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedTutorialScript.TutorialItem>.NativeClassPtr, "_type");
				AdvancedTutorialScript.TutorialItem.NativeFieldInfoPtr__action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedTutorialScript.TutorialItem>.NativeClassPtr, "_action");
				AdvancedTutorialScript.TutorialItem.NativeFieldInfoPtr_filterType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedTutorialScript.TutorialItem>.NativeClassPtr, "filterType");
				AdvancedTutorialScript.TutorialItem.NativeFieldInfoPtr__filter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedTutorialScript.TutorialItem>.NativeClassPtr, "_filter");
				AdvancedTutorialScript.TutorialItem.NativeFieldInfoPtr__identifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedTutorialScript.TutorialItem>.NativeClassPtr, "_identifier");
				AdvancedTutorialScript.TutorialItem.NativeMethodInfoPtr_GetActionOption_Public_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedTutorialScript.TutorialItem>.NativeClassPtr, 100664039);
				AdvancedTutorialScript.TutorialItem.NativeMethodInfoPtr_GetFilterOption_Public_IEnumerable_1_SelectionFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedTutorialScript.TutorialItem>.NativeClassPtr, 100664040);
				AdvancedTutorialScript.TutorialItem.NativeMethodInfoPtr_FromAction_Private_Static_TutorialItem_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedTutorialScript.TutorialItem>.NativeClassPtr, 100664041);
				AdvancedTutorialScript.TutorialItem.NativeMethodInfoPtr_op_Implicit_Public_Static_TutorialItem_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedTutorialScript.TutorialItem>.NativeClassPtr, 100664042);
				AdvancedTutorialScript.TutorialItem.NativeMethodInfoPtr_op_Implicit_Public_Static_Action_TutorialItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedTutorialScript.TutorialItem>.NativeClassPtr, 100664043);
				AdvancedTutorialScript.TutorialItem.NativeMethodInfoPtr_FromFilter_Private_Static_TutorialItem_ValueTuple_2_FilterType_SelectionFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedTutorialScript.TutorialItem>.NativeClassPtr, 100664044);
				AdvancedTutorialScript.TutorialItem.NativeMethodInfoPtr_FromFilter_Private_Static_TutorialItem_ValueTuple_3_FilterType_String_SelectionFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedTutorialScript.TutorialItem>.NativeClassPtr, 100664045);
				AdvancedTutorialScript.TutorialItem.NativeMethodInfoPtr_op_Implicit_Public_Static_TutorialItem_ValueTuple_2_FilterType_SelectionFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedTutorialScript.TutorialItem>.NativeClassPtr, 100664046);
				AdvancedTutorialScript.TutorialItem.NativeMethodInfoPtr_op_Implicit_Public_Static_TutorialItem_ValueTuple_3_FilterType_String_SelectionFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedTutorialScript.TutorialItem>.NativeClassPtr, 100664047);
				AdvancedTutorialScript.TutorialItem.NativeMethodInfoPtr_op_Implicit_Public_Static_SelectionFilter_TutorialItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedTutorialScript.TutorialItem>.NativeClassPtr, 100664048);
				AdvancedTutorialScript.TutorialItem.NativeMethodInfoPtr__ctor_Private_Void_TutorialItemType_Action_Nullable_1_FilterType_SelectionFilter_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedTutorialScript.TutorialItem>.NativeClassPtr, 100664049);
			}

			// Token: 0x06001B50 RID: 6992 RVA: 0x00083DD4 File Offset: 0x00081FD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 550000, XrefRangeEnd = 550009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<Canis.actions.Action> GetActionOption()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedTutorialScript.TutorialItem.NativeMethodInfoPtr_GetActionOption_Public_IEnumerable_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06001B51 RID: 6993 RVA: 0x00083E14 File Offset: 0x00082014
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 550018, RefRangeEnd = 550021, XrefRangeStart = 550009, XrefRangeEnd = 550018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<SelectionFilter> GetFilterOption()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedTutorialScript.TutorialItem.NativeMethodInfoPtr_GetFilterOption_Public_IEnumerable_1_SelectionFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<SelectionFilter>>(intPtr3) : null;
			}

			// Token: 0x06001B52 RID: 6994 RVA: 0x00083E54 File Offset: 0x00082054
			[CallerCount(259)]
			[CachedScanResults(RefRangeStart = 550029, RefRangeEnd = 550288, XrefRangeStart = 550021, XrefRangeEnd = 550029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static AdvancedTutorialScript.TutorialItem FromAction(Canis.actions.Action action)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedTutorialScript.TutorialItem.NativeMethodInfoPtr_FromAction_Private_Static_TutorialItem_Action_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AdvancedTutorialScript.TutorialItem>(intPtr3) : null;
				}
			}

			// Token: 0x06001B53 RID: 6995 RVA: 0x00083E98 File Offset: 0x00082098
			[CallerCount(259)]
			[CachedScanResults(RefRangeStart = 550029, RefRangeEnd = 550288, XrefRangeStart = 550029, XrefRangeEnd = 550288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static implicit operator AdvancedTutorialScript.TutorialItem(Canis.actions.Action action)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedTutorialScript.TutorialItem.NativeMethodInfoPtr_op_Implicit_Public_Static_TutorialItem_Action_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AdvancedTutorialScript.TutorialItem>(intPtr3) : null;
				}
			}

			// Token: 0x06001B54 RID: 6996 RVA: 0x00083EDC File Offset: 0x000820DC
			[CallerCount(0)]
			public unsafe static implicit operator Canis.actions.Action(AdvancedTutorialScript.TutorialItem ti)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ti);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedTutorialScript.TutorialItem.NativeMethodInfoPtr_op_Implicit_Public_Static_Action_TutorialItem_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06001B55 RID: 6997 RVA: 0x00083F20 File Offset: 0x00082120
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 550288, XrefRangeEnd = 550299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static AdvancedTutorialScript.TutorialItem FromFilter(ValueTuple<AdvancedTutorialScript.FilterType, SelectionFilter> filter)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(filter));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedTutorialScript.TutorialItem.NativeMethodInfoPtr_FromFilter_Private_Static_TutorialItem_ValueTuple_2_FilterType_SelectionFilter_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AdvancedTutorialScript.TutorialItem>(intPtr3) : null;
				}
			}

			// Token: 0x06001B56 RID: 6998 RVA: 0x00083F6C File Offset: 0x0008216C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 550299, XrefRangeEnd = 550308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static AdvancedTutorialScript.TutorialItem FromFilter(ValueTuple<AdvancedTutorialScript.FilterType, string, SelectionFilter> filter)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(filter));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedTutorialScript.TutorialItem.NativeMethodInfoPtr_FromFilter_Private_Static_TutorialItem_ValueTuple_3_FilterType_String_SelectionFilter_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AdvancedTutorialScript.TutorialItem>(intPtr3) : null;
				}
			}

			// Token: 0x06001B57 RID: 6999 RVA: 0x00083FB8 File Offset: 0x000821B8
			[CallerCount(77)]
			[CachedScanResults(RefRangeStart = 550319, RefRangeEnd = 550396, XrefRangeStart = 550308, XrefRangeEnd = 550319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static implicit operator AdvancedTutorialScript.TutorialItem(ValueTuple<AdvancedTutorialScript.FilterType, SelectionFilter> filter)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(filter));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedTutorialScript.TutorialItem.NativeMethodInfoPtr_op_Implicit_Public_Static_TutorialItem_ValueTuple_2_FilterType_SelectionFilter_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AdvancedTutorialScript.TutorialItem>(intPtr3) : null;
				}
			}

			// Token: 0x06001B58 RID: 7000 RVA: 0x00084004 File Offset: 0x00082204
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static implicit operator AdvancedTutorialScript.TutorialItem(ValueTuple<AdvancedTutorialScript.FilterType, string, SelectionFilter> filter)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(filter));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedTutorialScript.TutorialItem.NativeMethodInfoPtr_op_Implicit_Public_Static_TutorialItem_ValueTuple_3_FilterType_String_SelectionFilter_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AdvancedTutorialScript.TutorialItem>(intPtr3) : null;
				}
			}

			// Token: 0x06001B59 RID: 7001 RVA: 0x00084050 File Offset: 0x00082250
			[CallerCount(0)]
			public unsafe static implicit operator SelectionFilter(AdvancedTutorialScript.TutorialItem ti)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ti);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedTutorialScript.TutorialItem.NativeMethodInfoPtr_op_Implicit_Public_Static_SelectionFilter_TutorialItem_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<SelectionFilter>(intPtr3) : null;
				}
			}

			// Token: 0x06001B5A RID: 7002 RVA: 0x00084094 File Offset: 0x00082294
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 550396, XrefRangeEnd = 550400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TutorialItem(AdvancedTutorialScript.TutorialItemType type, Canis.actions.Action action = null, Nullable<AdvancedTutorialScript.FilterType> filterType = null, SelectionFilter filter = null, string identifier = "")
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AdvancedTutorialScript.TutorialItem>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref type;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(filterType));
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filter);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(identifier);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedTutorialScript.TutorialItem.NativeMethodInfoPtr__ctor_Private_Void_TutorialItemType_Action_Nullable_1_FilterType_SelectionFilter_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B5B RID: 7003 RVA: 0x0000D0DB File Offset: 0x0000B2DB
			public TutorialItem(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700063D RID: 1597
			// (get) Token: 0x06001B5C RID: 7004 RVA: 0x0008412C File Offset: 0x0008232C
			// (set) Token: 0x06001B5D RID: 7005 RVA: 0x0000D0E4 File Offset: 0x0000B2E4
			public unsafe AdvancedTutorialScript.TutorialItemType _type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedTutorialScript.TutorialItem.NativeFieldInfoPtr__type);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedTutorialScript.TutorialItem.NativeFieldInfoPtr__type)) = value;
				}
			}

			// Token: 0x1700063E RID: 1598
			// (get) Token: 0x06001B5E RID: 7006 RVA: 0x00084154 File Offset: 0x00082354
			// (set) Token: 0x06001B5F RID: 7007 RVA: 0x0000D0FF File Offset: 0x0000B2FF
			public unsafe Canis.actions.Action _action
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedTutorialScript.TutorialItem.NativeFieldInfoPtr__action);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedTutorialScript.TutorialItem.NativeFieldInfoPtr__action), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700063F RID: 1599
			// (get) Token: 0x06001B60 RID: 7008 RVA: 0x00084184 File Offset: 0x00082384
			// (set) Token: 0x06001B61 RID: 7009 RVA: 0x0000D11E File Offset: 0x0000B31E
			public Nullable<AdvancedTutorialScript.FilterType> filterType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedTutorialScript.TutorialItem.NativeFieldInfoPtr_filterType);
					return new Nullable<AdvancedTutorialScript.FilterType>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<AdvancedTutorialScript.FilterType>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedTutorialScript.TutorialItem.NativeFieldInfoPtr_filterType), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<AdvancedTutorialScript.FilterType>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000640 RID: 1600
			// (get) Token: 0x06001B62 RID: 7010 RVA: 0x000841B4 File Offset: 0x000823B4
			// (set) Token: 0x06001B63 RID: 7011 RVA: 0x0000D14C File Offset: 0x0000B34C
			public unsafe SelectionFilter _filter
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedTutorialScript.TutorialItem.NativeFieldInfoPtr__filter);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SelectionFilter>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedTutorialScript.TutorialItem.NativeFieldInfoPtr__filter), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000641 RID: 1601
			// (get) Token: 0x06001B64 RID: 7012 RVA: 0x000841E4 File Offset: 0x000823E4
			// (set) Token: 0x06001B65 RID: 7013 RVA: 0x0000D16B File Offset: 0x0000B36B
			public unsafe string _identifier
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedTutorialScript.TutorialItem.NativeFieldInfoPtr__identifier);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedTutorialScript.TutorialItem.NativeFieldInfoPtr__identifier), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400116F RID: 4463
			private static readonly IntPtr NativeFieldInfoPtr__type;

			// Token: 0x04001170 RID: 4464
			private static readonly IntPtr NativeFieldInfoPtr__action;

			// Token: 0x04001171 RID: 4465
			private static readonly IntPtr NativeFieldInfoPtr_filterType;

			// Token: 0x04001172 RID: 4466
			private static readonly IntPtr NativeFieldInfoPtr__filter;

			// Token: 0x04001173 RID: 4467
			private static readonly IntPtr NativeFieldInfoPtr__identifier;

			// Token: 0x04001174 RID: 4468
			private static readonly IntPtr NativeMethodInfoPtr_GetActionOption_Public_IEnumerable_1_Action_0;

			// Token: 0x04001175 RID: 4469
			private static readonly IntPtr NativeMethodInfoPtr_GetFilterOption_Public_IEnumerable_1_SelectionFilter_0;

			// Token: 0x04001176 RID: 4470
			private static readonly IntPtr NativeMethodInfoPtr_FromAction_Private_Static_TutorialItem_Action_0;

			// Token: 0x04001177 RID: 4471
			private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_TutorialItem_Action_0;

			// Token: 0x04001178 RID: 4472
			private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Action_TutorialItem_0;

			// Token: 0x04001179 RID: 4473
			private static readonly IntPtr NativeMethodInfoPtr_FromFilter_Private_Static_TutorialItem_ValueTuple_2_FilterType_SelectionFilter_0;

			// Token: 0x0400117A RID: 4474
			private static readonly IntPtr NativeMethodInfoPtr_FromFilter_Private_Static_TutorialItem_ValueTuple_3_FilterType_String_SelectionFilter_0;

			// Token: 0x0400117B RID: 4475
			private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_TutorialItem_ValueTuple_2_FilterType_SelectionFilter_0;

			// Token: 0x0400117C RID: 4476
			private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_TutorialItem_ValueTuple_3_FilterType_String_SelectionFilter_0;

			// Token: 0x0400117D RID: 4477
			private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_SelectionFilter_TutorialItem_0;

			// Token: 0x0400117E RID: 4478
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_TutorialItemType_Action_Nullable_1_FilterType_SelectionFilter_String_0;
		}

		// Token: 0x02000286 RID: 646
		[ObfuscatedName("Canis.tutorialScripts.AdvancedTutorialScript+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001B66 RID: 7014 RVA: 0x0008420C File Offset: 0x0008240C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<AdvancedTutorialScript.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AdvancedTutorialScript>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AdvancedTutorialScript.__c>.NativeClassPtr);
				AdvancedTutorialScript.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedTutorialScript.__c>.NativeClassPtr, "<>9");
				AdvancedTutorialScript.__c.NativeFieldInfoPtr___9__9_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedTutorialScript.__c>.NativeClassPtr, "<>9__9_4");
				AdvancedTutorialScript.__c.NativeFieldInfoPtr___9__9_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedTutorialScript.__c>.NativeClassPtr, "<>9__9_5");
				AdvancedTutorialScript.__c.NativeFieldInfoPtr___9__9_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedTutorialScript.__c>.NativeClassPtr, "<>9__9_6");
				AdvancedTutorialScript.__c.NativeFieldInfoPtr___9__9_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedTutorialScript.__c>.NativeClassPtr, "<>9__9_7");
				AdvancedTutorialScript.__c.NativeFieldInfoPtr___9__9_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedTutorialScript.__c>.NativeClassPtr, "<>9__9_8");
				AdvancedTutorialScript.__c.NativeFieldInfoPtr___9__9_12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedTutorialScript.__c>.NativeClassPtr, "<>9__9_12");
				AdvancedTutorialScript.__c.NativeFieldInfoPtr___9__9_9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedTutorialScript.__c>.NativeClassPtr, "<>9__9_9");
				AdvancedTutorialScript.__c.NativeFieldInfoPtr___9__9_10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedTutorialScript.__c>.NativeClassPtr, "<>9__9_10");
				AdvancedTutorialScript.__c.NativeFieldInfoPtr___9__9_11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedTutorialScript.__c>.NativeClassPtr, "<>9__9_11");
				AdvancedTutorialScript.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedTutorialScript.__c>.NativeClassPtr, 100664051);
				AdvancedTutorialScript.__c.NativeMethodInfoPtr___ctor_b__9_4_Internal_IEnumerable_1_Action_TutorialItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedTutorialScript.__c>.NativeClassPtr, 100664052);
				AdvancedTutorialScript.__c.NativeMethodInfoPtr___ctor_b__9_5_Internal_IEnumerable_1_SelectionFilter_TutorialItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedTutorialScript.__c>.NativeClassPtr, 100664053);
				AdvancedTutorialScript.__c.NativeMethodInfoPtr___ctor_b__9_6_Internal_IEnumerable_1_SelectionFilter_TutorialItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedTutorialScript.__c>.NativeClassPtr, 100664054);
				AdvancedTutorialScript.__c.NativeMethodInfoPtr___ctor_b__9_7_Internal_Boolean_TutorialItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedTutorialScript.__c>.NativeClassPtr, 100664055);
				AdvancedTutorialScript.__c.NativeMethodInfoPtr___ctor_b__9_8_Internal_String_TutorialItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedTutorialScript.__c>.NativeClassPtr, 100664056);
				AdvancedTutorialScript.__c.NativeMethodInfoPtr___ctor_b__9_9_Internal_KeyValuePair_2_String_List_1_SelectionFilter_IGrouping_2_String_TutorialItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedTutorialScript.__c>.NativeClassPtr, 100664057);
				AdvancedTutorialScript.__c.NativeMethodInfoPtr___ctor_b__9_12_Internal_IEnumerable_1_SelectionFilter_TutorialItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedTutorialScript.__c>.NativeClassPtr, 100664058);
				AdvancedTutorialScript.__c.NativeMethodInfoPtr___ctor_b__9_10_Internal_String_KeyValuePair_2_String_List_1_SelectionFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedTutorialScript.__c>.NativeClassPtr, 100664059);
				AdvancedTutorialScript.__c.NativeMethodInfoPtr___ctor_b__9_11_Internal_List_1_SelectionFilter_KeyValuePair_2_String_List_1_SelectionFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedTutorialScript.__c>.NativeClassPtr, 100664060);
			}

			// Token: 0x06001B67 RID: 7015 RVA: 0x000843C8 File Offset: 0x000825C8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AdvancedTutorialScript.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedTutorialScript.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B68 RID: 7016 RVA: 0x00084404 File Offset: 0x00082604
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 550400, XrefRangeEnd = 550410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<Canis.actions.Action> __ctor_b__9_4(AdvancedTutorialScript.TutorialItem _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedTutorialScript.__c.NativeMethodInfoPtr___ctor_b__9_4_Internal_IEnumerable_1_Action_TutorialItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Canis.actions.Action>>(intPtr3) : null;
				}
			}

			// Token: 0x06001B69 RID: 7017 RVA: 0x00084454 File Offset: 0x00082654
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 550410, XrefRangeEnd = 550417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<SelectionFilter> __ctor_b__9_5(AdvancedTutorialScript.TutorialItem _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedTutorialScript.__c.NativeMethodInfoPtr___ctor_b__9_5_Internal_IEnumerable_1_SelectionFilter_TutorialItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<SelectionFilter>>(intPtr3) : null;
				}
			}

			// Token: 0x06001B6A RID: 7018 RVA: 0x000844A4 File Offset: 0x000826A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 550417, XrefRangeEnd = 550424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<SelectionFilter> __ctor_b__9_6(AdvancedTutorialScript.TutorialItem _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedTutorialScript.__c.NativeMethodInfoPtr___ctor_b__9_6_Internal_IEnumerable_1_SelectionFilter_TutorialItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<SelectionFilter>>(intPtr3) : null;
				}
			}

			// Token: 0x06001B6B RID: 7019 RVA: 0x000844F4 File Offset: 0x000826F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 550424, XrefRangeEnd = 550428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool __ctor_b__9_7(AdvancedTutorialScript.TutorialItem _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedTutorialScript.__c.NativeMethodInfoPtr___ctor_b__9_7_Internal_Boolean_TutorialItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001B6C RID: 7020 RVA: 0x00084544 File Offset: 0x00082744
			[CallerCount(0)]
			public unsafe string __ctor_b__9_8(AdvancedTutorialScript.TutorialItem item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedTutorialScript.__c.NativeMethodInfoPtr___ctor_b__9_8_Internal_String_TutorialItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06001B6D RID: 7021 RVA: 0x0008458C File Offset: 0x0008278C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 550428, XrefRangeEnd = 550455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe KeyValuePair<string, List<SelectionFilter>> __ctor_b__9_9(IGrouping<string, AdvancedTutorialScript.TutorialItem> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedTutorialScript.__c.NativeMethodInfoPtr___ctor_b__9_9_Internal_KeyValuePair_2_String_List_1_SelectionFilter_IGrouping_2_String_TutorialItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new KeyValuePair<string, List<SelectionFilter>>(intPtr);
				}
			}

			// Token: 0x06001B6E RID: 7022 RVA: 0x000845D4 File Offset: 0x000827D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 550455, XrefRangeEnd = 550457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<SelectionFilter> __ctor_b__9_12(AdvancedTutorialScript.TutorialItem _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedTutorialScript.__c.NativeMethodInfoPtr___ctor_b__9_12_Internal_IEnumerable_1_SelectionFilter_TutorialItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<SelectionFilter>>(intPtr3) : null;
				}
			}

			// Token: 0x06001B6F RID: 7023 RVA: 0x00084624 File Offset: 0x00082824
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 550457, XrefRangeEnd = 550458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string __ctor_b__9_10(KeyValuePair<string, List<SelectionFilter>> grouping)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(grouping));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedTutorialScript.__c.NativeMethodInfoPtr___ctor_b__9_10_Internal_String_KeyValuePair_2_String_List_1_SelectionFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06001B70 RID: 7024 RVA: 0x00084674 File Offset: 0x00082874
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 550458, XrefRangeEnd = 550459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe List<SelectionFilter> __ctor_b__9_11(KeyValuePair<string, List<SelectionFilter>> grouping)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(grouping));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedTutorialScript.__c.NativeMethodInfoPtr___ctor_b__9_11_Internal_List_1_SelectionFilter_KeyValuePair_2_String_List_1_SelectionFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<SelectionFilter>>(intPtr3) : null;
				}
			}

			// Token: 0x06001B71 RID: 7025 RVA: 0x0000D18A File Offset: 0x0000B38A
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000642 RID: 1602
			// (get) Token: 0x06001B72 RID: 7026 RVA: 0x000846CC File Offset: 0x000828CC
			// (set) Token: 0x06001B73 RID: 7027 RVA: 0x0000D193 File Offset: 0x0000B393
			public unsafe static AdvancedTutorialScript.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AdvancedTutorialScript.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdvancedTutorialScript.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AdvancedTutorialScript.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000643 RID: 1603
			// (get) Token: 0x06001B74 RID: 7028 RVA: 0x000846F4 File Offset: 0x000828F4
			// (set) Token: 0x06001B75 RID: 7029 RVA: 0x0000D1A5 File Offset: 0x0000B3A5
			public unsafe static Func<AdvancedTutorialScript.TutorialItem, IEnumerable<Canis.actions.Action>> __9__9_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AdvancedTutorialScript.__c.NativeFieldInfoPtr___9__9_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AdvancedTutorialScript.TutorialItem, IEnumerable<Canis.actions.Action>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AdvancedTutorialScript.__c.NativeFieldInfoPtr___9__9_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000644 RID: 1604
			// (get) Token: 0x06001B76 RID: 7030 RVA: 0x0008471C File Offset: 0x0008291C
			// (set) Token: 0x06001B77 RID: 7031 RVA: 0x0000D1B7 File Offset: 0x0000B3B7
			public unsafe static Func<AdvancedTutorialScript.TutorialItem, IEnumerable<SelectionFilter>> __9__9_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AdvancedTutorialScript.__c.NativeFieldInfoPtr___9__9_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AdvancedTutorialScript.TutorialItem, IEnumerable<SelectionFilter>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AdvancedTutorialScript.__c.NativeFieldInfoPtr___9__9_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000645 RID: 1605
			// (get) Token: 0x06001B78 RID: 7032 RVA: 0x00084744 File Offset: 0x00082944
			// (set) Token: 0x06001B79 RID: 7033 RVA: 0x0000D1C9 File Offset: 0x0000B3C9
			public unsafe static Func<AdvancedTutorialScript.TutorialItem, IEnumerable<SelectionFilter>> __9__9_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AdvancedTutorialScript.__c.NativeFieldInfoPtr___9__9_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AdvancedTutorialScript.TutorialItem, IEnumerable<SelectionFilter>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AdvancedTutorialScript.__c.NativeFieldInfoPtr___9__9_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000646 RID: 1606
			// (get) Token: 0x06001B7A RID: 7034 RVA: 0x0008476C File Offset: 0x0008296C
			// (set) Token: 0x06001B7B RID: 7035 RVA: 0x0000D1DB File Offset: 0x0000B3DB
			public unsafe static Func<AdvancedTutorialScript.TutorialItem, bool> __9__9_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AdvancedTutorialScript.__c.NativeFieldInfoPtr___9__9_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AdvancedTutorialScript.TutorialItem, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AdvancedTutorialScript.__c.NativeFieldInfoPtr___9__9_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000647 RID: 1607
			// (get) Token: 0x06001B7C RID: 7036 RVA: 0x00084794 File Offset: 0x00082994
			// (set) Token: 0x06001B7D RID: 7037 RVA: 0x0000D1ED File Offset: 0x0000B3ED
			public unsafe static Func<AdvancedTutorialScript.TutorialItem, string> __9__9_8
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AdvancedTutorialScript.__c.NativeFieldInfoPtr___9__9_8, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AdvancedTutorialScript.TutorialItem, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AdvancedTutorialScript.__c.NativeFieldInfoPtr___9__9_8, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000648 RID: 1608
			// (get) Token: 0x06001B7E RID: 7038 RVA: 0x000847BC File Offset: 0x000829BC
			// (set) Token: 0x06001B7F RID: 7039 RVA: 0x0000D1FF File Offset: 0x0000B3FF
			public unsafe static Func<AdvancedTutorialScript.TutorialItem, IEnumerable<SelectionFilter>> __9__9_12
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AdvancedTutorialScript.__c.NativeFieldInfoPtr___9__9_12, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AdvancedTutorialScript.TutorialItem, IEnumerable<SelectionFilter>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AdvancedTutorialScript.__c.NativeFieldInfoPtr___9__9_12, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000649 RID: 1609
			// (get) Token: 0x06001B80 RID: 7040 RVA: 0x000847E4 File Offset: 0x000829E4
			// (set) Token: 0x06001B81 RID: 7041 RVA: 0x0000D211 File Offset: 0x0000B411
			public unsafe static Func<IGrouping<string, AdvancedTutorialScript.TutorialItem>, KeyValuePair<string, List<SelectionFilter>>> __9__9_9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AdvancedTutorialScript.__c.NativeFieldInfoPtr___9__9_9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IGrouping<string, AdvancedTutorialScript.TutorialItem>, KeyValuePair<string, List<SelectionFilter>>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AdvancedTutorialScript.__c.NativeFieldInfoPtr___9__9_9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700064A RID: 1610
			// (get) Token: 0x06001B82 RID: 7042 RVA: 0x0008480C File Offset: 0x00082A0C
			// (set) Token: 0x06001B83 RID: 7043 RVA: 0x0000D223 File Offset: 0x0000B423
			public unsafe static Func<KeyValuePair<string, List<SelectionFilter>>, string> __9__9_10
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AdvancedTutorialScript.__c.NativeFieldInfoPtr___9__9_10, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<string, List<SelectionFilter>>, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AdvancedTutorialScript.__c.NativeFieldInfoPtr___9__9_10, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700064B RID: 1611
			// (get) Token: 0x06001B84 RID: 7044 RVA: 0x00084834 File Offset: 0x00082A34
			// (set) Token: 0x06001B85 RID: 7045 RVA: 0x0000D235 File Offset: 0x0000B435
			public unsafe static Func<KeyValuePair<string, List<SelectionFilter>>, List<SelectionFilter>> __9__9_11
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AdvancedTutorialScript.__c.NativeFieldInfoPtr___9__9_11, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<string, List<SelectionFilter>>, List<SelectionFilter>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AdvancedTutorialScript.__c.NativeFieldInfoPtr___9__9_11, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400117F RID: 4479
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001180 RID: 4480
			private static readonly IntPtr NativeFieldInfoPtr___9__9_4;

			// Token: 0x04001181 RID: 4481
			private static readonly IntPtr NativeFieldInfoPtr___9__9_5;

			// Token: 0x04001182 RID: 4482
			private static readonly IntPtr NativeFieldInfoPtr___9__9_6;

			// Token: 0x04001183 RID: 4483
			private static readonly IntPtr NativeFieldInfoPtr___9__9_7;

			// Token: 0x04001184 RID: 4484
			private static readonly IntPtr NativeFieldInfoPtr___9__9_8;

			// Token: 0x04001185 RID: 4485
			private static readonly IntPtr NativeFieldInfoPtr___9__9_12;

			// Token: 0x04001186 RID: 4486
			private static readonly IntPtr NativeFieldInfoPtr___9__9_9;

			// Token: 0x04001187 RID: 4487
			private static readonly IntPtr NativeFieldInfoPtr___9__9_10;

			// Token: 0x04001188 RID: 4488
			private static readonly IntPtr NativeFieldInfoPtr___9__9_11;

			// Token: 0x04001189 RID: 4489
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400118A RID: 4490
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__9_4_Internal_IEnumerable_1_Action_TutorialItem_0;

			// Token: 0x0400118B RID: 4491
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__9_5_Internal_IEnumerable_1_SelectionFilter_TutorialItem_0;

			// Token: 0x0400118C RID: 4492
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__9_6_Internal_IEnumerable_1_SelectionFilter_TutorialItem_0;

			// Token: 0x0400118D RID: 4493
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__9_7_Internal_Boolean_TutorialItem_0;

			// Token: 0x0400118E RID: 4494
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__9_8_Internal_String_TutorialItem_0;

			// Token: 0x0400118F RID: 4495
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__9_9_Internal_KeyValuePair_2_String_List_1_SelectionFilter_IGrouping_2_String_TutorialItem_0;

			// Token: 0x04001190 RID: 4496
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__9_12_Internal_IEnumerable_1_SelectionFilter_TutorialItem_0;

			// Token: 0x04001191 RID: 4497
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__9_10_Internal_String_KeyValuePair_2_String_List_1_SelectionFilter_0;

			// Token: 0x04001192 RID: 4498
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__9_11_Internal_List_1_SelectionFilter_KeyValuePair_2_String_List_1_SelectionFilter_0;
		}

		// Token: 0x02000287 RID: 647
		[ObfuscatedName("Canis.tutorialScripts.AdvancedTutorialScript+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : Object
		{
			// Token: 0x06001B86 RID: 7046 RVA: 0x0008485C File Offset: 0x00082A5C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<AdvancedTutorialScript.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AdvancedTutorialScript>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AdvancedTutorialScript.__c__DisplayClass10_0>.NativeClassPtr);
				AdvancedTutorialScript.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedTutorialScript.__c__DisplayClass10_0>.NativeClassPtr, "<>4__this");
				AdvancedTutorialScript.__c__DisplayClass10_0.NativeFieldInfoPtr_objective = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedTutorialScript.__c__DisplayClass10_0>.NativeClassPtr, "objective");
				AdvancedTutorialScript.__c__DisplayClass10_0.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedTutorialScript.__c__DisplayClass10_0>.NativeClassPtr, "current");
				AdvancedTutorialScript.__c__DisplayClass10_0.NativeFieldInfoPtr___9__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedTutorialScript.__c__DisplayClass10_0>.NativeClassPtr, "<>9__1");
				AdvancedTutorialScript.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedTutorialScript.__c__DisplayClass10_0>.NativeClassPtr, 100664061);
				AdvancedTutorialScript.__c__DisplayClass10_0.NativeMethodInfoPtr__ObjectiveAt_b__0_Internal_Boolean_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedTutorialScript.__c__DisplayClass10_0>.NativeClassPtr, 100664062);
				AdvancedTutorialScript.__c__DisplayClass10_0.NativeMethodInfoPtr__ObjectiveAt_b__1_Internal_Boolean_Objective_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedTutorialScript.__c__DisplayClass10_0>.NativeClassPtr, 100664063);
			}

			// Token: 0x06001B87 RID: 7047 RVA: 0x00084914 File Offset: 0x00082B14
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AdvancedTutorialScript.__c__DisplayClass10_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedTutorialScript.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B88 RID: 7048 RVA: 0x00084950 File Offset: 0x00082B50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 550459, XrefRangeEnd = 550479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ObjectiveAt_b__0(Context context)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedTutorialScript.__c__DisplayClass10_0.NativeMethodInfoPtr__ObjectiveAt_b__0_Internal_Boolean_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001B89 RID: 7049 RVA: 0x000849A0 File Offset: 0x00082BA0
			[CallerCount(0)]
			public unsafe bool _ObjectiveAt_b__1(Objective o)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedTutorialScript.__c__DisplayClass10_0.NativeMethodInfoPtr__ObjectiveAt_b__1_Internal_Boolean_Objective_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001B8A RID: 7050 RVA: 0x0000D247 File Offset: 0x0000B447
			public __c__DisplayClass10_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700064C RID: 1612
			// (get) Token: 0x06001B8B RID: 7051 RVA: 0x000849F0 File Offset: 0x00082BF0
			// (set) Token: 0x06001B8C RID: 7052 RVA: 0x0000D250 File Offset: 0x0000B450
			public unsafe AdvancedTutorialScript __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedTutorialScript.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdvancedTutorialScript>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedTutorialScript.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700064D RID: 1613
			// (get) Token: 0x06001B8D RID: 7053 RVA: 0x00084A20 File Offset: 0x00082C20
			// (set) Token: 0x06001B8E RID: 7054 RVA: 0x0000D26F File Offset: 0x0000B46F
			public unsafe int objective
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedTutorialScript.__c__DisplayClass10_0.NativeFieldInfoPtr_objective);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedTutorialScript.__c__DisplayClass10_0.NativeFieldInfoPtr_objective)) = value;
				}
			}

			// Token: 0x1700064E RID: 1614
			// (get) Token: 0x06001B8F RID: 7055 RVA: 0x00084A48 File Offset: 0x00082C48
			// (set) Token: 0x06001B90 RID: 7056 RVA: 0x0000D28A File Offset: 0x0000B48A
			public unsafe int current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedTutorialScript.__c__DisplayClass10_0.NativeFieldInfoPtr_current);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedTutorialScript.__c__DisplayClass10_0.NativeFieldInfoPtr_current)) = value;
				}
			}

			// Token: 0x1700064F RID: 1615
			// (get) Token: 0x06001B91 RID: 7057 RVA: 0x00084A70 File Offset: 0x00082C70
			// (set) Token: 0x06001B92 RID: 7058 RVA: 0x0000D2A5 File Offset: 0x0000B4A5
			public unsafe Func<Objective, bool> __9__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedTutorialScript.__c__DisplayClass10_0.NativeFieldInfoPtr___9__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Objective, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedTutorialScript.__c__DisplayClass10_0.NativeFieldInfoPtr___9__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001193 RID: 4499
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001194 RID: 4500
			private static readonly IntPtr NativeFieldInfoPtr_objective;

			// Token: 0x04001195 RID: 4501
			private static readonly IntPtr NativeFieldInfoPtr_current;

			// Token: 0x04001196 RID: 4502
			private static readonly IntPtr NativeFieldInfoPtr___9__1;

			// Token: 0x04001197 RID: 4503
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001198 RID: 4504
			private static readonly IntPtr NativeMethodInfoPtr__ObjectiveAt_b__0_Internal_Boolean_Context_0;

			// Token: 0x04001199 RID: 4505
			private static readonly IntPtr NativeMethodInfoPtr__ObjectiveAt_b__1_Internal_Boolean_Objective_0;
		}

		// Token: 0x02000288 RID: 648
		[ObfuscatedName("Canis.tutorialScripts.AdvancedTutorialScript+<>c__DisplayClass11_0")]
		public sealed class __c__DisplayClass11_0 : Object
		{
			// Token: 0x06001B93 RID: 7059 RVA: 0x00084AA0 File Offset: 0x00082CA0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<AdvancedTutorialScript.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AdvancedTutorialScript>.NativeClassPtr, "<>c__DisplayClass11_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AdvancedTutorialScript.__c__DisplayClass11_0>.NativeClassPtr);
				AdvancedTutorialScript.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedTutorialScript.__c__DisplayClass11_0>.NativeClassPtr, "<>4__this");
				AdvancedTutorialScript.__c__DisplayClass11_0.NativeFieldInfoPtr_objective = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedTutorialScript.__c__DisplayClass11_0>.NativeClassPtr, "objective");
				AdvancedTutorialScript.__c__DisplayClass11_0.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedTutorialScript.__c__DisplayClass11_0>.NativeClassPtr, "current");
				AdvancedTutorialScript.__c__DisplayClass11_0.NativeFieldInfoPtr___9__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedTutorialScript.__c__DisplayClass11_0>.NativeClassPtr, "<>9__1");
				AdvancedTutorialScript.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedTutorialScript.__c__DisplayClass11_0>.NativeClassPtr, 100664064);
				AdvancedTutorialScript.__c__DisplayClass11_0.NativeMethodInfoPtr__ObjectiveAtOrGreater_b__0_Internal_Boolean_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedTutorialScript.__c__DisplayClass11_0>.NativeClassPtr, 100664065);
				AdvancedTutorialScript.__c__DisplayClass11_0.NativeMethodInfoPtr__ObjectiveAtOrGreater_b__1_Internal_Boolean_Objective_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedTutorialScript.__c__DisplayClass11_0>.NativeClassPtr, 100664066);
			}

			// Token: 0x06001B94 RID: 7060 RVA: 0x00084B58 File Offset: 0x00082D58
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AdvancedTutorialScript.__c__DisplayClass11_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedTutorialScript.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B95 RID: 7061 RVA: 0x00084B94 File Offset: 0x00082D94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 550479, XrefRangeEnd = 550499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ObjectiveAtOrGreater_b__0(Context context)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedTutorialScript.__c__DisplayClass11_0.NativeMethodInfoPtr__ObjectiveAtOrGreater_b__0_Internal_Boolean_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001B96 RID: 7062 RVA: 0x00084BE4 File Offset: 0x00082DE4
			[CallerCount(0)]
			public unsafe bool _ObjectiveAtOrGreater_b__1(Objective o)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedTutorialScript.__c__DisplayClass11_0.NativeMethodInfoPtr__ObjectiveAtOrGreater_b__1_Internal_Boolean_Objective_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001B97 RID: 7063 RVA: 0x0000D2C4 File Offset: 0x0000B4C4
			public __c__DisplayClass11_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000650 RID: 1616
			// (get) Token: 0x06001B98 RID: 7064 RVA: 0x00084C34 File Offset: 0x00082E34
			// (set) Token: 0x06001B99 RID: 7065 RVA: 0x0000D2CD File Offset: 0x0000B4CD
			public unsafe AdvancedTutorialScript __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedTutorialScript.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdvancedTutorialScript>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedTutorialScript.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000651 RID: 1617
			// (get) Token: 0x06001B9A RID: 7066 RVA: 0x00084C64 File Offset: 0x00082E64
			// (set) Token: 0x06001B9B RID: 7067 RVA: 0x0000D2EC File Offset: 0x0000B4EC
			public unsafe int objective
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedTutorialScript.__c__DisplayClass11_0.NativeFieldInfoPtr_objective);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedTutorialScript.__c__DisplayClass11_0.NativeFieldInfoPtr_objective)) = value;
				}
			}

			// Token: 0x17000652 RID: 1618
			// (get) Token: 0x06001B9C RID: 7068 RVA: 0x00084C8C File Offset: 0x00082E8C
			// (set) Token: 0x06001B9D RID: 7069 RVA: 0x0000D307 File Offset: 0x0000B507
			public unsafe int current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedTutorialScript.__c__DisplayClass11_0.NativeFieldInfoPtr_current);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedTutorialScript.__c__DisplayClass11_0.NativeFieldInfoPtr_current)) = value;
				}
			}

			// Token: 0x17000653 RID: 1619
			// (get) Token: 0x06001B9E RID: 7070 RVA: 0x00084CB4 File Offset: 0x00082EB4
			// (set) Token: 0x06001B9F RID: 7071 RVA: 0x0000D322 File Offset: 0x0000B522
			public unsafe Func<Objective, bool> __9__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedTutorialScript.__c__DisplayClass11_0.NativeFieldInfoPtr___9__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Objective, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedTutorialScript.__c__DisplayClass11_0.NativeFieldInfoPtr___9__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400119A RID: 4506
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400119B RID: 4507
			private static readonly IntPtr NativeFieldInfoPtr_objective;

			// Token: 0x0400119C RID: 4508
			private static readonly IntPtr NativeFieldInfoPtr_current;

			// Token: 0x0400119D RID: 4509
			private static readonly IntPtr NativeFieldInfoPtr___9__1;

			// Token: 0x0400119E RID: 4510
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400119F RID: 4511
			private static readonly IntPtr NativeMethodInfoPtr__ObjectiveAtOrGreater_b__0_Internal_Boolean_Context_0;

			// Token: 0x040011A0 RID: 4512
			private static readonly IntPtr NativeMethodInfoPtr__ObjectiveAtOrGreater_b__1_Internal_Boolean_Objective_0;
		}

		// Token: 0x02000289 RID: 649
		[ObfuscatedName("Canis.tutorialScripts.AdvancedTutorialScript+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : Object
		{
			// Token: 0x06001BA0 RID: 7072 RVA: 0x00084CE4 File Offset: 0x00082EE4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<AdvancedTutorialScript.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AdvancedTutorialScript>.NativeClassPtr, "<>c__DisplayClass12_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AdvancedTutorialScript.__c__DisplayClass12_0>.NativeClassPtr);
				AdvancedTutorialScript.__c__DisplayClass12_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedTutorialScript.__c__DisplayClass12_0>.NativeClassPtr, "<>4__this");
				AdvancedTutorialScript.__c__DisplayClass12_0.NativeFieldInfoPtr_objectives = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedTutorialScript.__c__DisplayClass12_0>.NativeClassPtr, "objectives");
				AdvancedTutorialScript.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedTutorialScript.__c__DisplayClass12_0>.NativeClassPtr, 100664067);
				AdvancedTutorialScript.__c__DisplayClass12_0.NativeMethodInfoPtr__ObjectiveCompleted_b__0_Internal_Boolean_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedTutorialScript.__c__DisplayClass12_0>.NativeClassPtr, 100664068);
			}

			// Token: 0x06001BA1 RID: 7073 RVA: 0x00084D60 File Offset: 0x00082F60
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AdvancedTutorialScript.__c__DisplayClass12_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedTutorialScript.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001BA2 RID: 7074 RVA: 0x00084D9C File Offset: 0x00082F9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 550499, XrefRangeEnd = 550527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ObjectiveCompleted_b__0(Context context)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedTutorialScript.__c__DisplayClass12_0.NativeMethodInfoPtr__ObjectiveCompleted_b__0_Internal_Boolean_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001BA3 RID: 7075 RVA: 0x0000D341 File Offset: 0x0000B541
			public __c__DisplayClass12_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000654 RID: 1620
			// (get) Token: 0x06001BA4 RID: 7076 RVA: 0x00084DEC File Offset: 0x00082FEC
			// (set) Token: 0x06001BA5 RID: 7077 RVA: 0x0000D34A File Offset: 0x0000B54A
			public unsafe AdvancedTutorialScript __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedTutorialScript.__c__DisplayClass12_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdvancedTutorialScript>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedTutorialScript.__c__DisplayClass12_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000655 RID: 1621
			// (get) Token: 0x06001BA6 RID: 7078 RVA: 0x00084E1C File Offset: 0x0008301C
			// (set) Token: 0x06001BA7 RID: 7079 RVA: 0x0000D369 File Offset: 0x0000B569
			public unsafe Il2CppStructArray<int> objectives
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedTutorialScript.__c__DisplayClass12_0.NativeFieldInfoPtr_objectives);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedTutorialScript.__c__DisplayClass12_0.NativeFieldInfoPtr_objectives), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040011A1 RID: 4513
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040011A2 RID: 4514
			private static readonly IntPtr NativeFieldInfoPtr_objectives;

			// Token: 0x040011A3 RID: 4515
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040011A4 RID: 4516
			private static readonly IntPtr NativeMethodInfoPtr__ObjectiveCompleted_b__0_Internal_Boolean_Context_0;
		}

		// Token: 0x0200028A RID: 650
		[ObfuscatedName("Canis.tutorialScripts.AdvancedTutorialScript+<>c__DisplayClass12_1")]
		public sealed class __c__DisplayClass12_1 : Object
		{
			// Token: 0x06001BA8 RID: 7080 RVA: 0x00084E4C File Offset: 0x0008304C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_1()
			{
				Il2CppClassPointerStore<AdvancedTutorialScript.__c__DisplayClass12_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AdvancedTutorialScript>.NativeClassPtr, "<>c__DisplayClass12_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AdvancedTutorialScript.__c__DisplayClass12_1>.NativeClassPtr);
				AdvancedTutorialScript.__c__DisplayClass12_1.NativeFieldInfoPtr_completed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedTutorialScript.__c__DisplayClass12_1>.NativeClassPtr, "completed");
				AdvancedTutorialScript.__c__DisplayClass12_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedTutorialScript.__c__DisplayClass12_1>.NativeClassPtr, 100664069);
				AdvancedTutorialScript.__c__DisplayClass12_1.NativeMethodInfoPtr__ObjectiveCompleted_b__1_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedTutorialScript.__c__DisplayClass12_1>.NativeClassPtr, 100664070);
			}

			// Token: 0x06001BA9 RID: 7081 RVA: 0x00084EB4 File Offset: 0x000830B4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AdvancedTutorialScript.__c__DisplayClass12_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedTutorialScript.__c__DisplayClass12_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001BAA RID: 7082 RVA: 0x00084EF0 File Offset: 0x000830F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 550527, XrefRangeEnd = 550530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ObjectiveCompleted_b__1(int obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref obj;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedTutorialScript.__c__DisplayClass12_1.NativeMethodInfoPtr__ObjectiveCompleted_b__1_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001BAB RID: 7083 RVA: 0x0000D388 File Offset: 0x0000B588
			public __c__DisplayClass12_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000656 RID: 1622
			// (get) Token: 0x06001BAC RID: 7084 RVA: 0x00084F3C File Offset: 0x0008313C
			// (set) Token: 0x06001BAD RID: 7085 RVA: 0x0000D391 File Offset: 0x0000B591
			public unsafe Il2CppStructArray<int> completed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedTutorialScript.__c__DisplayClass12_1.NativeFieldInfoPtr_completed);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedTutorialScript.__c__DisplayClass12_1.NativeFieldInfoPtr_completed), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040011A5 RID: 4517
			private static readonly IntPtr NativeFieldInfoPtr_completed;

			// Token: 0x040011A6 RID: 4518
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040011A7 RID: 4519
			private static readonly IntPtr NativeMethodInfoPtr__ObjectiveCompleted_b__1_Internal_Boolean_Int32_0;
		}
	}
}
