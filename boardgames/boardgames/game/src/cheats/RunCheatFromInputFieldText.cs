using System;
using dwd.core.cheats;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace game.src.cheats
{
	// Token: 0x02000033 RID: 51
	public class RunCheatFromInputFieldText : MonoBehaviour
	{
		// Token: 0x0600022E RID: 558 RVA: 0x00017FAC File Offset: 0x000161AC
		// Note: this type is marked as 'beforefieldinit'.
		static RunCheatFromInputFieldText()
		{
			Il2CppClassPointerStore<RunCheatFromInputFieldText>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "game.src.cheats", "RunCheatFromInputFieldText");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunCheatFromInputFieldText>.NativeClassPtr);
			RunCheatFromInputFieldText.NativeFieldInfoPtr_input = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunCheatFromInputFieldText>.NativeClassPtr, "input");
			RunCheatFromInputFieldText.NativeFieldInfoPtr_cheats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunCheatFromInputFieldText>.NativeClassPtr, "cheats");
			RunCheatFromInputFieldText.NativeMethodInfoPtr_Event_RunCheatFromInput_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunCheatFromInputFieldText>.NativeClassPtr, 100663713);
			RunCheatFromInputFieldText.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunCheatFromInputFieldText>.NativeClassPtr, 100663714);
		}

		// Token: 0x0600022F RID: 559 RVA: 0x0001802C File Offset: 0x0001622C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984752, XrefRangeEnd = 984761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_RunCheatFromInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunCheatFromInputFieldText.NativeMethodInfoPtr_Event_RunCheatFromInput_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00018060 File Offset: 0x00016260
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RunCheatFromInputFieldText()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunCheatFromInputFieldText>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunCheatFromInputFieldText.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00002F1B File Offset: 0x0000111B
		public RunCheatFromInputFieldText(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000232 RID: 562 RVA: 0x0001809C File Offset: 0x0001629C
		// (set) Token: 0x06000233 RID: 563 RVA: 0x00002F24 File Offset: 0x00001124
		public unsafe InputField input
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCheatFromInputFieldText.NativeFieldInfoPtr_input);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCheatFromInputFieldText.NativeFieldInfoPtr_input), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000234 RID: 564 RVA: 0x000180CC File Offset: 0x000162CC
		// (set) Token: 0x06000235 RID: 565 RVA: 0x00002F43 File Offset: 0x00001143
		public unsafe Cheats cheats
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCheatFromInputFieldText.NativeFieldInfoPtr_cheats);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Cheats>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCheatFromInputFieldText.NativeFieldInfoPtr_cheats), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000170 RID: 368
		private static readonly IntPtr NativeFieldInfoPtr_input;

		// Token: 0x04000171 RID: 369
		private static readonly IntPtr NativeFieldInfoPtr_cheats;

		// Token: 0x04000172 RID: 370
		private static readonly IntPtr NativeMethodInfoPtr_Event_RunCheatFromInput_Public_Void_0;

		// Token: 0x04000173 RID: 371
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
