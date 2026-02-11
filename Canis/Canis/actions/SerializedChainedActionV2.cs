using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.actions
{
	// Token: 0x0200019E RID: 414
	public class SerializedChainedActionV2 : SerializedWrappedAction
	{
		// Token: 0x06001200 RID: 4608 RVA: 0x00062420 File Offset: 0x00060620
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedChainedActionV2()
		{
			Il2CppClassPointerStore<SerializedChainedActionV2>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "SerializedChainedActionV2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedChainedActionV2>.NativeClassPtr);
			SerializedChainedActionV2.NativeMethodInfoPtr_GenWrappedAction_Protected_Virtual_WrappedAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedChainedActionV2>.NativeClassPtr, 100667111);
			SerializedChainedActionV2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedChainedActionV2>.NativeClassPtr, 100667112);
		}

		// Token: 0x06001201 RID: 4609 RVA: 0x00062478 File Offset: 0x00060678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 584768, XrefRangeEnd = 584772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override WrappedAction GenWrappedAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedChainedActionV2.NativeMethodInfoPtr_GenWrappedAction_Protected_Virtual_WrappedAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WrappedAction>(intPtr3) : null;
			}
		}

		// Token: 0x06001202 RID: 4610 RVA: 0x000624D4 File Offset: 0x000606D4
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 146959, RefRangeEnd = 146969, XrefRangeStart = 146959, XrefRangeEnd = 146969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedChainedActionV2()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedChainedActionV2>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedChainedActionV2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001203 RID: 4611 RVA: 0x00008EEC File Offset: 0x000070EC
		public SerializedChainedActionV2(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000BC5 RID: 3013
		private static readonly IntPtr NativeMethodInfoPtr_GenWrappedAction_Protected_Virtual_WrappedAction_Match_0;

		// Token: 0x04000BC6 RID: 3014
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
