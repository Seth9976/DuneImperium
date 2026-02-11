using System;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace dwd.core.ui.prompt.behaviours
{
	// Token: 0x0200003F RID: 63
	public class SpinnerPromptBehaviour : PromptBehaviour<Spinner>
	{
		// Token: 0x06000252 RID: 594 RVA: 0x0000B71C File Offset: 0x0000991C
		// Note: this type is marked as 'beforefieldinit'.
		static SpinnerPromptBehaviour()
		{
			Il2CppClassPointerStore<SpinnerPromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-prompter.dll", "dwd.core.ui.prompt.behaviours", "SpinnerPromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpinnerPromptBehaviour>.NativeClassPtr);
			SpinnerPromptBehaviour.NativeFieldInfoPtr_onTextShown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpinnerPromptBehaviour>.NativeClassPtr, "onTextShown");
			SpinnerPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpinnerPromptBehaviour>.NativeClassPtr, 100663577);
			SpinnerPromptBehaviour.NativeMethodInfoPtr_Event_UnblockSpinner_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpinnerPromptBehaviour>.NativeClassPtr, 100663578);
			SpinnerPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpinnerPromptBehaviour>.NativeClassPtr, 100663579);
		}

		// Token: 0x06000253 RID: 595 RVA: 0x0000B79C File Offset: 0x0000999C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1214792, XrefRangeEnd = 1214811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpinnerPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000254 RID: 596 RVA: 0x0000B7D8 File Offset: 0x000099D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1214811, XrefRangeEnd = 1214814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_UnblockSpinner()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpinnerPromptBehaviour.NativeMethodInfoPtr_Event_UnblockSpinner_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000255 RID: 597 RVA: 0x0000B80C File Offset: 0x00009A0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1214814, XrefRangeEnd = 1214822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpinnerPromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpinnerPromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpinnerPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000256 RID: 598 RVA: 0x000032A3 File Offset: 0x000014A3
		public SpinnerPromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000257 RID: 599 RVA: 0x0000B848 File Offset: 0x00009A48
		// (set) Token: 0x06000258 RID: 600 RVA: 0x000032AC File Offset: 0x000014AC
		public unsafe UnityEventBool onTextShown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpinnerPromptBehaviour.NativeFieldInfoPtr_onTextShown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEventBool>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpinnerPromptBehaviour.NativeFieldInfoPtr_onTextShown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400014D RID: 333
		private static readonly IntPtr NativeFieldInfoPtr_onTextShown;

		// Token: 0x0400014E RID: 334
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0;

		// Token: 0x0400014F RID: 335
		private static readonly IntPtr NativeMethodInfoPtr_Event_UnblockSpinner_Public_Void_0;

		// Token: 0x04000150 RID: 336
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
