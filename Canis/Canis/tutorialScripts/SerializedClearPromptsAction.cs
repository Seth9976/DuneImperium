using System;
using Canis.actions;
using Canis.actions.serialized;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.tutorialScripts
{
	// Token: 0x02000039 RID: 57
	public class SerializedClearPromptsAction : SerializedAction
	{
		// Token: 0x06000388 RID: 904 RVA: 0x000279CC File Offset: 0x00025BCC
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedClearPromptsAction()
		{
			Il2CppClassPointerStore<SerializedClearPromptsAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.tutorialScripts", "SerializedClearPromptsAction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedClearPromptsAction>.NativeClassPtr);
			SerializedClearPromptsAction.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedClearPromptsAction>.NativeClassPtr, 100664085);
			SerializedClearPromptsAction.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedClearPromptsAction>.NativeClassPtr, 100664086);
		}

		// Token: 0x06000389 RID: 905 RVA: 0x00027A24 File Offset: 0x00025C24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 550893, XrefRangeEnd = 550897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedClearPromptsAction.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x0600038A RID: 906 RVA: 0x00027A80 File Offset: 0x00025C80
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedClearPromptsAction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedClearPromptsAction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedClearPromptsAction.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600038B RID: 907 RVA: 0x000038BD File Offset: 0x00001ABD
		public SerializedClearPromptsAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000257 RID: 599
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x04000258 RID: 600
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
