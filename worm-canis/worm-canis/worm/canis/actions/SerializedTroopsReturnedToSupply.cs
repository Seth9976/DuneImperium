using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.actions
{
	// Token: 0x020002A4 RID: 676
	public class SerializedTroopsReturnedToSupply : SerializedAction
	{
		// Token: 0x06001C12 RID: 7186 RVA: 0x000C5ED4 File Offset: 0x000C40D4
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedTroopsReturnedToSupply()
		{
			Il2CppClassPointerStore<SerializedTroopsReturnedToSupply>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "SerializedTroopsReturnedToSupply");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedTroopsReturnedToSupply>.NativeClassPtr);
			SerializedTroopsReturnedToSupply.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedTroopsReturnedToSupply>.NativeClassPtr, 100668997);
			SerializedTroopsReturnedToSupply.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedTroopsReturnedToSupply>.NativeClassPtr, 100668998);
		}

		// Token: 0x06001C13 RID: 7187 RVA: 0x000C5F2C File Offset: 0x000C412C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149499, XrefRangeEnd = 149503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedTroopsReturnedToSupply.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x06001C14 RID: 7188 RVA: 0x000C5F88 File Offset: 0x000C4188
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedTroopsReturnedToSupply()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedTroopsReturnedToSupply>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedTroopsReturnedToSupply.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C15 RID: 7189 RVA: 0x0000BF22 File Offset: 0x0000A122
		public SerializedTroopsReturnedToSupply(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001154 RID: 4436
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x04001155 RID: 4437
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
