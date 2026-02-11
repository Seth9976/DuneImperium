using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace dwd.core.ui.prompt.behaviours
{
	// Token: 0x0200003C RID: 60
	public class PromptBehaviour<TPrompt> : PromptBehaviour where TPrompt : class
	{
		// Token: 0x06000236 RID: 566 RVA: 0x0000B0F0 File Offset: 0x000092F0
		// Note: this type is marked as 'beforefieldinit'.
		static PromptBehaviour()
		{
			Il2CppClassPointerStore<PromptBehaviour<TPrompt>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-prompter.dll", "dwd.core.ui.prompt.behaviours", "PromptBehaviour`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPrompt>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PromptBehaviour<TPrompt>>.NativeClassPtr);
			PromptBehaviour<TPrompt>.NativeMethodInfoPtr_get_Prompt_Public_get_TPrompt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromptBehaviour<TPrompt>>.NativeClassPtr, 100663565);
			PromptBehaviour<TPrompt>.NativeMethodInfoPtr_get_PromptInitialized_Public_Virtual_Final_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromptBehaviour<TPrompt>>.NativeClassPtr, 100663566);
			PromptBehaviour<TPrompt>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromptBehaviour<TPrompt>>.NativeClassPtr, 100663567);
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000237 RID: 567 RVA: 0x0000B198 File Offset: 0x00009398
		public unsafe TPrompt Prompt
		{
			[CallerCount(296)]
			[CachedScanResults(RefRangeStart = 1214463, RefRangeEnd = 1214759, XrefRangeStart = 1214460, XrefRangeEnd = 1214463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PromptBehaviour<TPrompt>.NativeMethodInfoPtr_get_Prompt_Public_get_TPrompt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TPrompt>(intPtr, false, true);
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000238 RID: 568 RVA: 0x0000B1D4 File Offset: 0x000093D4
		public unsafe override bool PromptInitialized
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1214759, XrefRangeEnd = 1214763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PromptBehaviour<TPrompt>.NativeMethodInfoPtr_get_PromptInitialized_Public_Virtual_Final_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000239 RID: 569 RVA: 0x0000B210 File Offset: 0x00009410
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 496077, RefRangeEnd = 496274, XrefRangeStart = 496077, XrefRangeEnd = 496274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PromptBehaviour<TPrompt>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PromptBehaviour<TPrompt>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600023A RID: 570 RVA: 0x000031F9 File Offset: 0x000013F9
		public PromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400013C RID: 316
		private static readonly IntPtr NativeMethodInfoPtr_get_Prompt_Public_get_TPrompt_0;

		// Token: 0x0400013D RID: 317
		private static readonly IntPtr NativeMethodInfoPtr_get_PromptInitialized_Public_Virtual_Final_get_Boolean_0;

		// Token: 0x0400013E RID: 318
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
