using System;
using Canis;
using Canis.actions;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace lotus
{
	// Token: 0x02000018 RID: 24
	public class ScenarioRunOnePerEvent : ScenarioActionGroup
	{
		// Token: 0x060000CF RID: 207 RVA: 0x000059B4 File Offset: 0x00003BB4
		// Note: this type is marked as 'beforefieldinit'.
		static ScenarioRunOnePerEvent()
		{
			Il2CppClassPointerStore<ScenarioRunOnePerEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames-cutscenes.dll", "lotus", "ScenarioRunOnePerEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScenarioRunOnePerEvent>.NativeClassPtr);
			ScenarioRunOnePerEvent.NativeFieldInfoPtr_eventID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScenarioRunOnePerEvent>.NativeClassPtr, "eventID");
			ScenarioRunOnePerEvent.NativeMethodInfoPtr_GetAction_Public_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScenarioRunOnePerEvent>.NativeClassPtr, 100663460);
			ScenarioRunOnePerEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScenarioRunOnePerEvent>.NativeClassPtr, 100663461);
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00005A20 File Offset: 0x00003C20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258615, XrefRangeEnd = 1258620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GetAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScenarioRunOnePerEvent.NativeMethodInfoPtr_GetAction_Public_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00005A7C File Offset: 0x00003C7C
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScenarioRunOnePerEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScenarioRunOnePerEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScenarioRunOnePerEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00002539 File Offset: 0x00000739
		public ScenarioRunOnePerEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x00005AB8 File Offset: 0x00003CB8
		// (set) Token: 0x060000D4 RID: 212 RVA: 0x00002542 File Offset: 0x00000742
		public unsafe string eventID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScenarioRunOnePerEvent.NativeFieldInfoPtr_eventID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScenarioRunOnePerEvent.NativeFieldInfoPtr_eventID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeFieldInfoPtr_eventID;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeMethodInfoPtr_GetAction_Public_Virtual_Action_Match_0;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
