using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Networking.clientevents;

namespace Canis.clientEvents
{
	// Token: 0x0200015D RID: 349
	public class EnterSelectionWithPromptClientEvent : ClientEvent
	{
		// Token: 0x06000F67 RID: 3943 RVA: 0x00059184 File Offset: 0x00057384
		// Note: this type is marked as 'beforefieldinit'.
		static EnterSelectionWithPromptClientEvent()
		{
			Il2CppClassPointerStore<EnterSelectionWithPromptClientEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.clientEvents", "EnterSelectionWithPromptClientEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnterSelectionWithPromptClientEvent>.NativeClassPtr);
			EnterSelectionWithPromptClientEvent.NativeFieldInfoPtr_Prompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnterSelectionWithPromptClientEvent>.NativeClassPtr, "Prompt");
			EnterSelectionWithPromptClientEvent.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnterSelectionWithPromptClientEvent>.NativeClassPtr, 100666536);
		}

		// Token: 0x06000F68 RID: 3944 RVA: 0x000591DC File Offset: 0x000573DC
		[CallerCount(96)]
		[CachedScanResults(RefRangeStart = 230, RefRangeEnd = 326, XrefRangeStart = 230, XrefRangeEnd = 326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EnterSelectionWithPromptClientEvent(string prompt)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnterSelectionWithPromptClientEvent>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prompt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnterSelectionWithPromptClientEvent.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F69 RID: 3945 RVA: 0x00007D68 File Offset: 0x00005F68
		public EnterSelectionWithPromptClientEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06000F6A RID: 3946 RVA: 0x00059228 File Offset: 0x00057428
		// (set) Token: 0x06000F6B RID: 3947 RVA: 0x00007D71 File Offset: 0x00005F71
		public unsafe string Prompt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnterSelectionWithPromptClientEvent.NativeFieldInfoPtr_Prompt);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnterSelectionWithPromptClientEvent.NativeFieldInfoPtr_Prompt), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000A48 RID: 2632
		private static readonly IntPtr NativeFieldInfoPtr_Prompt;

		// Token: 0x04000A49 RID: 2633
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
