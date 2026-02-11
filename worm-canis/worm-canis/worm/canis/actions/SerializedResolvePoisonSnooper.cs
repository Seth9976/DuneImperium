using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.actions
{
	// Token: 0x02000279 RID: 633
	public class SerializedResolvePoisonSnooper : SerializedAction
	{
		// Token: 0x06001A9E RID: 6814 RVA: 0x000C0530 File Offset: 0x000BE730
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedResolvePoisonSnooper()
		{
			Il2CppClassPointerStore<SerializedResolvePoisonSnooper>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "SerializedResolvePoisonSnooper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedResolvePoisonSnooper>.NativeClassPtr);
			SerializedResolvePoisonSnooper.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedResolvePoisonSnooper>.NativeClassPtr, 100668441);
			SerializedResolvePoisonSnooper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedResolvePoisonSnooper>.NativeClassPtr, 100668442);
		}

		// Token: 0x06001A9F RID: 6815 RVA: 0x000C0588 File Offset: 0x000BE788
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143531, XrefRangeEnd = 143535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedResolvePoisonSnooper.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x06001AA0 RID: 6816 RVA: 0x000C05E4 File Offset: 0x000BE7E4
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedResolvePoisonSnooper()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedResolvePoisonSnooper>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedResolvePoisonSnooper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AA1 RID: 6817 RVA: 0x0000B718 File Offset: 0x00009918
		public SerializedResolvePoisonSnooper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400106A RID: 4202
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x0400106B RID: 4203
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
