using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.actions
{
	// Token: 0x0200024E RID: 590
	public class SerializedGainSignetIcon : SerializedAction
	{
		// Token: 0x06001985 RID: 6533 RVA: 0x000BC0E8 File Offset: 0x000BA2E8
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedGainSignetIcon()
		{
			Il2CppClassPointerStore<SerializedGainSignetIcon>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "SerializedGainSignetIcon");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedGainSignetIcon>.NativeClassPtr);
			SerializedGainSignetIcon.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedGainSignetIcon>.NativeClassPtr, 100667929);
			SerializedGainSignetIcon.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedGainSignetIcon>.NativeClassPtr, 100667930);
		}

		// Token: 0x06001986 RID: 6534 RVA: 0x000BC140 File Offset: 0x000BA340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136799, XrefRangeEnd = 136803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedGainSignetIcon.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x06001987 RID: 6535 RVA: 0x000BC19C File Offset: 0x000BA39C
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedGainSignetIcon()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedGainSignetIcon>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedGainSignetIcon.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001988 RID: 6536 RVA: 0x0000B05E File Offset: 0x0000925E
		public SerializedGainSignetIcon(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000FC2 RID: 4034
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x04000FC3 RID: 4035
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
