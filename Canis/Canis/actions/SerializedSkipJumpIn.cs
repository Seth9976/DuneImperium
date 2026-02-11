using System;
using Canis.actions.serialized;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.actions
{
	// Token: 0x020001B2 RID: 434
	public class SerializedSkipJumpIn : SerializedAction
	{
		// Token: 0x06001282 RID: 4738 RVA: 0x000643C8 File Offset: 0x000625C8
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedSkipJumpIn()
		{
			Il2CppClassPointerStore<SerializedSkipJumpIn>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "SerializedSkipJumpIn");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedSkipJumpIn>.NativeClassPtr);
			SerializedSkipJumpIn.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedSkipJumpIn>.NativeClassPtr, 100667268);
			SerializedSkipJumpIn.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedSkipJumpIn>.NativeClassPtr, 100667269);
		}

		// Token: 0x06001283 RID: 4739 RVA: 0x00064420 File Offset: 0x00062620
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 585504, XrefRangeEnd = 585509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedSkipJumpIn.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x06001284 RID: 4740 RVA: 0x0006447C File Offset: 0x0006267C
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedSkipJumpIn()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedSkipJumpIn>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedSkipJumpIn.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001285 RID: 4741 RVA: 0x000091FD File Offset: 0x000073FD
		public SerializedSkipJumpIn(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C0C RID: 3084
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x04000C0D RID: 3085
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
