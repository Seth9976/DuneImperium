using System;
using dwd.core.ui.prompt.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace lotus
{
	// Token: 0x020000B3 RID: 179
	public class EmoteSelectPromptBehaviour : PromptBehaviour<EmoteSelectPrompt>
	{
		// Token: 0x06000911 RID: 2321 RVA: 0x0002DA64 File Offset: 0x0002BC64
		// Note: this type is marked as 'beforefieldinit'.
		static EmoteSelectPromptBehaviour()
		{
			Il2CppClassPointerStore<EmoteSelectPromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lotus", "EmoteSelectPromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EmoteSelectPromptBehaviour>.NativeClassPtr);
			EmoteSelectPromptBehaviour.NativeMethodInfoPtr_Event_SelectType_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmoteSelectPromptBehaviour>.NativeClassPtr, 100664714);
			EmoteSelectPromptBehaviour.NativeMethodInfoPtr_Event_SelectMessage_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmoteSelectPromptBehaviour>.NativeClassPtr, 100664715);
			EmoteSelectPromptBehaviour.NativeMethodInfoPtr_Event_Dismiss_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmoteSelectPromptBehaviour>.NativeClassPtr, 100664716);
			EmoteSelectPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmoteSelectPromptBehaviour>.NativeClassPtr, 100664717);
		}

		// Token: 0x06000912 RID: 2322 RVA: 0x0002DAE4 File Offset: 0x0002BCE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 992120, RefRangeEnd = 992121, XrefRangeStart = 992115, XrefRangeEnd = 992120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_SelectType(string emoteType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(emoteType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmoteSelectPromptBehaviour.NativeMethodInfoPtr_Event_SelectType_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000913 RID: 2323 RVA: 0x0002DB28 File Offset: 0x0002BD28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 992126, RefRangeEnd = 992127, XrefRangeStart = 992121, XrefRangeEnd = 992126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_SelectMessage(string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmoteSelectPromptBehaviour.NativeMethodInfoPtr_Event_SelectMessage_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000914 RID: 2324 RVA: 0x0002DB6C File Offset: 0x0002BD6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992127, XrefRangeEnd = 992132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Dismiss()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmoteSelectPromptBehaviour.NativeMethodInfoPtr_Event_Dismiss_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000915 RID: 2325 RVA: 0x0002DBA0 File Offset: 0x0002BDA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992132, XrefRangeEnd = 992135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EmoteSelectPromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EmoteSelectPromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmoteSelectPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000916 RID: 2326 RVA: 0x0000630D File Offset: 0x0000450D
		public EmoteSelectPromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400058E RID: 1422
		private static readonly IntPtr NativeMethodInfoPtr_Event_SelectType_Public_Void_String_0;

		// Token: 0x0400058F RID: 1423
		private static readonly IntPtr NativeMethodInfoPtr_Event_SelectMessage_Public_Void_String_0;

		// Token: 0x04000590 RID: 1424
		private static readonly IntPtr NativeMethodInfoPtr_Event_Dismiss_Public_Void_0;

		// Token: 0x04000591 RID: 1425
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
