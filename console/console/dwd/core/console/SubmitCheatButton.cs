using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using UnityEngine;

namespace dwd.core.console
{
	// Token: 0x02000012 RID: 18
	public class SubmitCheatButton : MonoBehaviour
	{
		// Token: 0x060000EB RID: 235 RVA: 0x0000552C File Offset: 0x0000372C
		// Note: this type is marked as 'beforefieldinit'.
		static SubmitCheatButton()
		{
			Il2CppClassPointerStore<SubmitCheatButton>.NativeClassPtr = IL2CPP.GetIl2CppClass("console.dll", "dwd.core.console", "SubmitCheatButton");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubmitCheatButton>.NativeClassPtr);
			SubmitCheatButton.NativeFieldInfoPtr_inputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmitCheatButton>.NativeClassPtr, "inputField");
			SubmitCheatButton.NativeMethodInfoPtr_Event_RunCheat_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubmitCheatButton>.NativeClassPtr, 100663374);
			SubmitCheatButton.NativeMethodInfoPtr_Event_RunCheatFromEndEdit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubmitCheatButton>.NativeClassPtr, 100663375);
			SubmitCheatButton.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubmitCheatButton>.NativeClassPtr, 100663376);
		}

		// Token: 0x060000EC RID: 236 RVA: 0x000055AC File Offset: 0x000037AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1256143, XrefRangeEnd = 1256167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_RunCheat()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubmitCheatButton.NativeMethodInfoPtr_Event_RunCheat_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000ED RID: 237 RVA: 0x000055E0 File Offset: 0x000037E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1256167, XrefRangeEnd = 1256206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_RunCheatFromEndEdit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubmitCheatButton.NativeMethodInfoPtr_Event_RunCheatFromEndEdit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00005614 File Offset: 0x00003814
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SubmitCheatButton()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubmitCheatButton>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubmitCheatButton.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000EF RID: 239 RVA: 0x000028C2 File Offset: 0x00000AC2
		public SubmitCheatButton(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x00005650 File Offset: 0x00003850
		// (set) Token: 0x060000F1 RID: 241 RVA: 0x000028CB File Offset: 0x00000ACB
		public unsafe TMP_InputField inputField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmitCheatButton.NativeFieldInfoPtr_inputField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmitCheatButton.NativeFieldInfoPtr_inputField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeFieldInfoPtr_inputField;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeMethodInfoPtr_Event_RunCheat_Public_Void_0;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeMethodInfoPtr_Event_RunCheatFromEndEdit_Public_Void_0;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
