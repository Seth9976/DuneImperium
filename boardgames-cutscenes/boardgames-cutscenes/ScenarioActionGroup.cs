using System;
using Canis;
using Canis.actions;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace lotus
{
	// Token: 0x02000016 RID: 22
	public class ScenarioActionGroup : ScenarioAction
	{
		// Token: 0x060000BD RID: 189 RVA: 0x000055AC File Offset: 0x000037AC
		// Note: this type is marked as 'beforefieldinit'.
		static ScenarioActionGroup()
		{
			Il2CppClassPointerStore<ScenarioActionGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames-cutscenes.dll", "lotus", "ScenarioActionGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScenarioActionGroup>.NativeClassPtr);
			ScenarioActionGroup.NativeFieldInfoPtr_disable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScenarioActionGroup>.NativeClassPtr, "disable");
			ScenarioActionGroup.NativeFieldInfoPtr_scenarioActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScenarioActionGroup>.NativeClassPtr, "scenarioActions");
			ScenarioActionGroup.NativeMethodInfoPtr_GetAction_Public_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScenarioActionGroup>.NativeClassPtr, 100663452);
			ScenarioActionGroup.NativeMethodInfoPtr_GetActions_Protected_List_1_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScenarioActionGroup>.NativeClassPtr, 100663453);
			ScenarioActionGroup.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScenarioActionGroup>.NativeClassPtr, 100663454);
			ScenarioActionGroup.NativeMethodInfoPtr_getHeader_Protected_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScenarioActionGroup>.NativeClassPtr, 100663455);
			ScenarioActionGroup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScenarioActionGroup>.NativeClassPtr, 100663456);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00005668 File Offset: 0x00003868
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1258552, RefRangeEnd = 1258554, XrefRangeStart = 1258547, XrefRangeEnd = 1258552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GetAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScenarioActionGroup.NativeMethodInfoPtr_GetAction_Public_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x060000BF RID: 191 RVA: 0x000056C4 File Offset: 0x000038C4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1258579, RefRangeEnd = 1258582, XrefRangeStart = 1258554, XrefRangeEnd = 1258579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Action> GetActions(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScenarioActionGroup.NativeMethodInfoPtr_GetActions_Protected_List_1_Action_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Action>>(intPtr3) : null;
			}
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00005714 File Offset: 0x00003914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258582, XrefRangeEnd = 1258606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScenarioActionGroup.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00005758 File Offset: 0x00003958
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258606, XrefRangeEnd = 1258608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string getHeader()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScenarioActionGroup.NativeMethodInfoPtr_getHeader_Protected_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x0000579C File Offset: 0x0000399C
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScenarioActionGroup()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScenarioActionGroup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScenarioActionGroup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x000024CE File Offset: 0x000006CE
		public ScenarioActionGroup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x000057D8 File Offset: 0x000039D8
		// (set) Token: 0x060000C5 RID: 197 RVA: 0x000024D7 File Offset: 0x000006D7
		public unsafe bool disable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScenarioActionGroup.NativeFieldInfoPtr_disable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScenarioActionGroup.NativeFieldInfoPtr_disable)) = value;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x00005800 File Offset: 0x00003A00
		// (set) Token: 0x060000C7 RID: 199 RVA: 0x000024F2 File Offset: 0x000006F2
		public unsafe List<ScenarioAction> scenarioActions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScenarioActionGroup.NativeFieldInfoPtr_scenarioActions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ScenarioAction>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScenarioActionGroup.NativeFieldInfoPtr_scenarioActions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeFieldInfoPtr_disable;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeFieldInfoPtr_scenarioActions;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeMethodInfoPtr_GetAction_Public_Virtual_Action_Match_0;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeMethodInfoPtr_GetActions_Protected_List_1_Action_Match_0;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeMethodInfoPtr_getHeader_Protected_Virtual_New_String_0;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
