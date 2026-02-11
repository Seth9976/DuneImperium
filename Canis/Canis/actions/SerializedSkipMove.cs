using System;
using Canis.actions.serialized;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.actions
{
	// Token: 0x020001BE RID: 446
	[Serializable]
	public class SerializedSkipMove : SerializedAction
	{
		// Token: 0x060012F3 RID: 4851 RVA: 0x000660B0 File Offset: 0x000642B0
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedSkipMove()
		{
			Il2CppClassPointerStore<SerializedSkipMove>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "SerializedSkipMove");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedSkipMove>.NativeClassPtr);
			SerializedSkipMove.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedSkipMove>.NativeClassPtr, 100667357);
			SerializedSkipMove.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedSkipMove>.NativeClassPtr, 100667358);
		}

		// Token: 0x060012F4 RID: 4852 RVA: 0x00066108 File Offset: 0x00064308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 586149, XrefRangeEnd = 586154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedSkipMove.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x060012F5 RID: 4853 RVA: 0x00066164 File Offset: 0x00064364
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedSkipMove()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedSkipMove>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedSkipMove.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012F6 RID: 4854 RVA: 0x00009507 File Offset: 0x00007707
		public SerializedSkipMove(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C57 RID: 3159
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x04000C58 RID: 3160
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
