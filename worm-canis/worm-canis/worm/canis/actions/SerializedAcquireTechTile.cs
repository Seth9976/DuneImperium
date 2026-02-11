using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.actions
{
	// Token: 0x02000283 RID: 643
	public class SerializedAcquireTechTile : SerializedAction
	{
		// Token: 0x06001AF0 RID: 6896 RVA: 0x000C19AC File Offset: 0x000BFBAC
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedAcquireTechTile()
		{
			Il2CppClassPointerStore<SerializedAcquireTechTile>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "SerializedAcquireTechTile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedAcquireTechTile>.NativeClassPtr);
			SerializedAcquireTechTile.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedAcquireTechTile>.NativeClassPtr, 100668559);
			SerializedAcquireTechTile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedAcquireTechTile>.NativeClassPtr, 100668560);
		}

		// Token: 0x06001AF1 RID: 6897 RVA: 0x000C1A04 File Offset: 0x000BFC04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145066, XrefRangeEnd = 145070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedAcquireTechTile.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x06001AF2 RID: 6898 RVA: 0x000C1A60 File Offset: 0x000BFC60
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedAcquireTechTile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedAcquireTechTile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedAcquireTechTile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AF3 RID: 6899 RVA: 0x0000B8B3 File Offset: 0x00009AB3
		public SerializedAcquireTechTile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400109D RID: 4253
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x0400109E RID: 4254
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
