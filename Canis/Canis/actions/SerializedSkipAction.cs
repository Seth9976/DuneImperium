using System;
using Canis.actions.serialized;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.actions
{
	// Token: 0x020001EB RID: 491
	public class SerializedSkipAction : SerializedAction
	{
		// Token: 0x060014C0 RID: 5312 RVA: 0x0006CF58 File Offset: 0x0006B158
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedSkipAction()
		{
			Il2CppClassPointerStore<SerializedSkipAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "SerializedSkipAction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedSkipAction>.NativeClassPtr);
			SerializedSkipAction.NativeFieldInfoPtr_ToSkip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedSkipAction>.NativeClassPtr, "ToSkip");
			SerializedSkipAction.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedSkipAction>.NativeClassPtr, 100667885);
			SerializedSkipAction.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedSkipAction>.NativeClassPtr, 100667886);
		}

		// Token: 0x060014C1 RID: 5313 RVA: 0x0006CFC4 File Offset: 0x0006B1C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 589827, XrefRangeEnd = 589833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedSkipAction.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x060014C2 RID: 5314 RVA: 0x0006D020 File Offset: 0x0006B220
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedSkipAction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedSkipAction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedSkipAction.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014C3 RID: 5315 RVA: 0x0000A17C File Offset: 0x0000837C
		public SerializedSkipAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x060014C4 RID: 5316 RVA: 0x0006D05C File Offset: 0x0006B25C
		// (set) Token: 0x060014C5 RID: 5317 RVA: 0x0000A185 File Offset: 0x00008385
		public unsafe SerializedAction ToSkip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedSkipAction.NativeFieldInfoPtr_ToSkip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializedAction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedSkipAction.NativeFieldInfoPtr_ToSkip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D68 RID: 3432
		private static readonly IntPtr NativeFieldInfoPtr_ToSkip;

		// Token: 0x04000D69 RID: 3433
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x04000D6A RID: 3434
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
