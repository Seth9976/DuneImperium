using System;
using Canis.attributes;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.actions
{
	// Token: 0x020001DF RID: 479
	public class SerializedSequenceAction : SerializedWrappedAction
	{
		// Token: 0x0600144D RID: 5197 RVA: 0x0006B350 File Offset: 0x00069550
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedSequenceAction()
		{
			Il2CppClassPointerStore<SerializedSequenceAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "SerializedSequenceAction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedSequenceAction>.NativeClassPtr);
			SerializedSequenceAction.NativeFieldInfoPtr_SequenceName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedSequenceAction>.NativeClassPtr, "SequenceName");
			SerializedSequenceAction.NativeFieldInfoPtr_SequenceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedSequenceAction>.NativeClassPtr, "SequenceID");
			SerializedSequenceAction.NativeFieldInfoPtr_SequenceAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedSequenceAction>.NativeClassPtr, "SequenceAttributes");
			SerializedSequenceAction.NativeMethodInfoPtr_GenWrappedAction_Protected_Virtual_WrappedAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedSequenceAction>.NativeClassPtr, 100667755);
			SerializedSequenceAction.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedSequenceAction>.NativeClassPtr, 100667756);
		}

		// Token: 0x0600144E RID: 5198 RVA: 0x0006B3E4 File Offset: 0x000695E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 588811, XrefRangeEnd = 588842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override WrappedAction GenWrappedAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedSequenceAction.NativeMethodInfoPtr_GenWrappedAction_Protected_Virtual_WrappedAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WrappedAction>(intPtr3) : null;
			}
		}

		// Token: 0x0600144F RID: 5199 RVA: 0x0006B440 File Offset: 0x00069640
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedSequenceAction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedSequenceAction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedSequenceAction.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001450 RID: 5200 RVA: 0x00009E50 File Offset: 0x00008050
		public SerializedSequenceAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x06001451 RID: 5201 RVA: 0x0006B47C File Offset: 0x0006967C
		// (set) Token: 0x06001452 RID: 5202 RVA: 0x00009E59 File Offset: 0x00008059
		public unsafe string SequenceName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedSequenceAction.NativeFieldInfoPtr_SequenceName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedSequenceAction.NativeFieldInfoPtr_SequenceName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x06001453 RID: 5203 RVA: 0x0006B4A4 File Offset: 0x000696A4
		// (set) Token: 0x06001454 RID: 5204 RVA: 0x00009E78 File Offset: 0x00008078
		public unsafe SequenceID SequenceID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedSequenceAction.NativeFieldInfoPtr_SequenceID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedSequenceAction.NativeFieldInfoPtr_SequenceID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x06001455 RID: 5205 RVA: 0x0006B4D4 File Offset: 0x000696D4
		// (set) Token: 0x06001456 RID: 5206 RVA: 0x00009E97 File Offset: 0x00008097
		public unsafe MutableAttributes SequenceAttributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedSequenceAction.NativeFieldInfoPtr_SequenceAttributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MutableAttributes>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedSequenceAction.NativeFieldInfoPtr_SequenceAttributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D23 RID: 3363
		private static readonly IntPtr NativeFieldInfoPtr_SequenceName;

		// Token: 0x04000D24 RID: 3364
		private static readonly IntPtr NativeFieldInfoPtr_SequenceID;

		// Token: 0x04000D25 RID: 3365
		private static readonly IntPtr NativeFieldInfoPtr_SequenceAttributes;

		// Token: 0x04000D26 RID: 3366
		private static readonly IntPtr NativeMethodInfoPtr_GenWrappedAction_Protected_Virtual_WrappedAction_Match_0;

		// Token: 0x04000D27 RID: 3367
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
