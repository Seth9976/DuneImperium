using System;
using Canis;
using Canis.actions;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace lotus
{
	// Token: 0x02000015 RID: 21
	public class ScenarioAction : MonoBehaviour
	{
		// Token: 0x060000B9 RID: 185 RVA: 0x000054BC File Offset: 0x000036BC
		// Note: this type is marked as 'beforefieldinit'.
		static ScenarioAction()
		{
			Il2CppClassPointerStore<ScenarioAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames-cutscenes.dll", "lotus", "ScenarioAction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScenarioAction>.NativeClassPtr);
			ScenarioAction.NativeMethodInfoPtr_GetAction_Public_Virtual_New_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScenarioAction>.NativeClassPtr, 100663450);
			ScenarioAction.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScenarioAction>.NativeClassPtr, 100663451);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00005514 File Offset: 0x00003714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258541, XrefRangeEnd = 1258547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Action GetAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScenarioAction.NativeMethodInfoPtr_GetAction_Public_Virtual_New_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00005570 File Offset: 0x00003770
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScenarioAction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScenarioAction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScenarioAction.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x000024C5 File Offset: 0x000006C5
		public ScenarioAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeMethodInfoPtr_GetAction_Public_Virtual_New_Action_Match_0;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
