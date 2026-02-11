using System;
using dbgclient.input;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace tuber.client.match.ui
{
	// Token: 0x02000018 RID: 24
	public class TMPTuberReactivateInputFieldOnEnter : ReactivateInputFieldOnEnter
	{
		// Token: 0x060000D9 RID: 217 RVA: 0x00020328 File Offset: 0x0001E528
		// Note: this type is marked as 'beforefieldinit'.
		static TMPTuberReactivateInputFieldOnEnter()
		{
			Il2CppClassPointerStore<TMPTuberReactivateInputFieldOnEnter>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "tuber.client.match.ui", "TMPTuberReactivateInputFieldOnEnter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMPTuberReactivateInputFieldOnEnter>.NativeClassPtr);
			TMPTuberReactivateInputFieldOnEnter.NativeMethodInfoPtr_addListener_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPTuberReactivateInputFieldOnEnter>.NativeClassPtr, 100663458);
			TMPTuberReactivateInputFieldOnEnter.NativeMethodInfoPtr_removeListeners_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPTuberReactivateInputFieldOnEnter>.NativeClassPtr, 100663459);
			TMPTuberReactivateInputFieldOnEnter.NativeMethodInfoPtr_handleSubmit_Protected_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPTuberReactivateInputFieldOnEnter>.NativeClassPtr, 100663460);
			TMPTuberReactivateInputFieldOnEnter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPTuberReactivateInputFieldOnEnter>.NativeClassPtr, 100663461);
		}

		// Token: 0x060000DA RID: 218 RVA: 0x000203A8 File Offset: 0x0001E5A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 496048, XrefRangeEnd = 496059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void addListener()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMPTuberReactivateInputFieldOnEnter.NativeMethodInfoPtr_addListener_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000DB RID: 219 RVA: 0x000203E4 File Offset: 0x0001E5E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 496059, XrefRangeEnd = 496070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void removeListeners()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMPTuberReactivateInputFieldOnEnter.NativeMethodInfoPtr_removeListeners_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00020420 File Offset: 0x0001E620
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 496070, XrefRangeEnd = 496076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void handleSubmit(string finalText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(finalText);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMPTuberReactivateInputFieldOnEnter.NativeMethodInfoPtr_handleSubmit_Protected_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00020470 File Offset: 0x0001E670
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 496077, RefRangeEnd = 496274, XrefRangeStart = 496076, XrefRangeEnd = 496077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMPTuberReactivateInputFieldOnEnter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMPTuberReactivateInputFieldOnEnter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPTuberReactivateInputFieldOnEnter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x000025BC File Offset: 0x000007BC
		public TMPTuberReactivateInputFieldOnEnter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeMethodInfoPtr_addListener_Protected_Virtual_Void_0;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeMethodInfoPtr_removeListeners_Protected_Virtual_Void_0;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeMethodInfoPtr_handleSubmit_Protected_Virtual_Void_String_0;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
