using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.actions
{
	// Token: 0x0200029C RID: 668
	public class SerializedSetLeaderDraw : SerializedAction
	{
		// Token: 0x06001BC5 RID: 7109 RVA: 0x000C4D14 File Offset: 0x000C2F14
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedSetLeaderDraw()
		{
			Il2CppClassPointerStore<SerializedSetLeaderDraw>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "SerializedSetLeaderDraw");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedSetLeaderDraw>.NativeClassPtr);
			SerializedSetLeaderDraw.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedSetLeaderDraw>.NativeClassPtr, 100668882);
			SerializedSetLeaderDraw.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedSetLeaderDraw>.NativeClassPtr, 100668883);
		}

		// Token: 0x06001BC6 RID: 7110 RVA: 0x000C4D6C File Offset: 0x000C2F6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147599, XrefRangeEnd = 147603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedSetLeaderDraw.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x06001BC7 RID: 7111 RVA: 0x000C4DC8 File Offset: 0x000C2FC8
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedSetLeaderDraw()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedSetLeaderDraw>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedSetLeaderDraw.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BC8 RID: 7112 RVA: 0x0000BD60 File Offset: 0x00009F60
		public SerializedSetLeaderDraw(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001125 RID: 4389
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x04001126 RID: 4390
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
