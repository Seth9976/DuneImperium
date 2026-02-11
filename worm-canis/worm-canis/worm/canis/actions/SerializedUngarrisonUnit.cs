using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.actions
{
	// Token: 0x020002A8 RID: 680
	public class SerializedUngarrisonUnit : SerializedAction
	{
		// Token: 0x06001C26 RID: 7206 RVA: 0x000C6454 File Offset: 0x000C4654
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedUngarrisonUnit()
		{
			Il2CppClassPointerStore<SerializedUngarrisonUnit>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "SerializedUngarrisonUnit");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedUngarrisonUnit>.NativeClassPtr);
			SerializedUngarrisonUnit.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedUngarrisonUnit>.NativeClassPtr, 100669041);
			SerializedUngarrisonUnit.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedUngarrisonUnit>.NativeClassPtr, 100669042);
		}

		// Token: 0x06001C27 RID: 7207 RVA: 0x000C64AC File Offset: 0x000C46AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149681, XrefRangeEnd = 149685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedUngarrisonUnit.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x06001C28 RID: 7208 RVA: 0x000C6508 File Offset: 0x000C4708
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedUngarrisonUnit()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedUngarrisonUnit>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedUngarrisonUnit.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C29 RID: 7209 RVA: 0x0000BF46 File Offset: 0x0000A146
		public SerializedUngarrisonUnit(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001160 RID: 4448
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x04001161 RID: 4449
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
