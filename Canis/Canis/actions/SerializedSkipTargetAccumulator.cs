using System;
using Canis.actions.serialized;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.actions
{
	// Token: 0x020001DC RID: 476
	[Serializable]
	public class SerializedSkipTargetAccumulator : SerializedAction
	{
		// Token: 0x0600142E RID: 5166 RVA: 0x0006ABB8 File Offset: 0x00068DB8
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedSkipTargetAccumulator()
		{
			Il2CppClassPointerStore<SerializedSkipTargetAccumulator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "SerializedSkipTargetAccumulator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedSkipTargetAccumulator>.NativeClassPtr);
			SerializedSkipTargetAccumulator.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedSkipTargetAccumulator>.NativeClassPtr, 100667733);
			SerializedSkipTargetAccumulator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedSkipTargetAccumulator>.NativeClassPtr, 100667734);
		}

		// Token: 0x0600142F RID: 5167 RVA: 0x0006AC10 File Offset: 0x00068E10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 588624, XrefRangeEnd = 588628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedSkipTargetAccumulator.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x06001430 RID: 5168 RVA: 0x0006AC6C File Offset: 0x00068E6C
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedSkipTargetAccumulator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedSkipTargetAccumulator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedSkipTargetAccumulator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001431 RID: 5169 RVA: 0x00009D73 File Offset: 0x00007F73
		public SerializedSkipTargetAccumulator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D11 RID: 3345
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x04000D12 RID: 3346
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
