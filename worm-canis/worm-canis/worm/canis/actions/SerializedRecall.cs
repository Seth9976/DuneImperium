using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.actions
{
	// Token: 0x02000272 RID: 626
	public class SerializedRecall : SerializedAction
	{
		// Token: 0x06001A73 RID: 6771 RVA: 0x000BFB00 File Offset: 0x000BDD00
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedRecall()
		{
			Il2CppClassPointerStore<SerializedRecall>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "SerializedRecall");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedRecall>.NativeClassPtr);
			SerializedRecall.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedRecall>.NativeClassPtr, 100668359);
			SerializedRecall.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedRecall>.NativeClassPtr, 100668360);
		}

		// Token: 0x06001A74 RID: 6772 RVA: 0x000BFB58 File Offset: 0x000BDD58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142544, XrefRangeEnd = 142548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedRecall.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x06001A75 RID: 6773 RVA: 0x000BFBB4 File Offset: 0x000BDDB4
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedRecall()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedRecall>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedRecall.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A76 RID: 6774 RVA: 0x0000B646 File Offset: 0x00009846
		public SerializedRecall(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001052 RID: 4178
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x04001053 RID: 4179
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
