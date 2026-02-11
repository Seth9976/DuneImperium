using System;
using Canis;
using Canis.actions;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace lotus
{
	// Token: 0x0200001B RID: 27
	public class ScenarioWhenOnce : ScenarioActionGroup
	{
		// Token: 0x060000E4 RID: 228 RVA: 0x00005DCC File Offset: 0x00003FCC
		// Note: this type is marked as 'beforefieldinit'.
		static ScenarioWhenOnce()
		{
			Il2CppClassPointerStore<ScenarioWhenOnce>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames-cutscenes.dll", "lotus", "ScenarioWhenOnce");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScenarioWhenOnce>.NativeClassPtr);
			ScenarioWhenOnce.NativeFieldInfoPtr_eventName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScenarioWhenOnce>.NativeClassPtr, "eventName");
			ScenarioWhenOnce.NativeMethodInfoPtr_GetAction_Public_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScenarioWhenOnce>.NativeClassPtr, 100663467);
			ScenarioWhenOnce.NativeMethodInfoPtr_getHeader_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScenarioWhenOnce>.NativeClassPtr, 100663468);
			ScenarioWhenOnce.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScenarioWhenOnce>.NativeClassPtr, 100663469);
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00005E4C File Offset: 0x0000404C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258636, XrefRangeEnd = 1258642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GetAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScenarioWhenOnce.NativeMethodInfoPtr_GetAction_Public_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00005EA8 File Offset: 0x000040A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258642, XrefRangeEnd = 1258648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string getHeader()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScenarioWhenOnce.NativeMethodInfoPtr_getHeader_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00005EEC File Offset: 0x000040EC
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScenarioWhenOnce()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScenarioWhenOnce>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScenarioWhenOnce.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x000025C8 File Offset: 0x000007C8
		public ScenarioWhenOnce(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x00005F28 File Offset: 0x00004128
		// (set) Token: 0x060000EA RID: 234 RVA: 0x000025D1 File Offset: 0x000007D1
		public unsafe string eventName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScenarioWhenOnce.NativeFieldInfoPtr_eventName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScenarioWhenOnce.NativeFieldInfoPtr_eventName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeFieldInfoPtr_eventName;

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeMethodInfoPtr_GetAction_Public_Virtual_Action_Match_0;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeMethodInfoPtr_getHeader_Protected_Virtual_String_0;

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
