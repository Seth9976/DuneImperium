using System;
using Canis.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.actions
{
	// Token: 0x0200018C RID: 396
	public class SerializedWhenOnceAction : SerializedWrappedAction
	{
		// Token: 0x0600114A RID: 4426 RVA: 0x0005F6C4 File Offset: 0x0005D8C4
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedWhenOnceAction()
		{
			Il2CppClassPointerStore<SerializedWhenOnceAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "SerializedWhenOnceAction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedWhenOnceAction>.NativeClassPtr);
			SerializedWhenOnceAction.NativeFieldInfoPtr_Event = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedWhenOnceAction>.NativeClassPtr, "Event");
			SerializedWhenOnceAction.NativeMethodInfoPtr_GenWrappedAction_Protected_Virtual_WrappedAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedWhenOnceAction>.NativeClassPtr, 100666913);
			SerializedWhenOnceAction.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedWhenOnceAction>.NativeClassPtr, 100666914);
		}

		// Token: 0x0600114B RID: 4427 RVA: 0x0005F730 File Offset: 0x0005D930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 583776, XrefRangeEnd = 583785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override WrappedAction GenWrappedAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedWhenOnceAction.NativeMethodInfoPtr_GenWrappedAction_Protected_Virtual_WrappedAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WrappedAction>(intPtr3) : null;
			}
		}

		// Token: 0x0600114C RID: 4428 RVA: 0x0005F78C File Offset: 0x0005D98C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 146959, RefRangeEnd = 146969, XrefRangeStart = 146959, XrefRangeEnd = 146969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedWhenOnceAction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedWhenOnceAction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedWhenOnceAction.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600114D RID: 4429 RVA: 0x00008A80 File Offset: 0x00006C80
		public SerializedWhenOnceAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x0600114E RID: 4430 RVA: 0x0005F7C8 File Offset: 0x0005D9C8
		// (set) Token: 0x0600114F RID: 4431 RVA: 0x00008A89 File Offset: 0x00006C89
		public unsafe SerializedEvent Event
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedWhenOnceAction.NativeFieldInfoPtr_Event);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializedEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedWhenOnceAction.NativeFieldInfoPtr_Event), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B54 RID: 2900
		private static readonly IntPtr NativeFieldInfoPtr_Event;

		// Token: 0x04000B55 RID: 2901
		private static readonly IntPtr NativeMethodInfoPtr_GenWrappedAction_Protected_Virtual_WrappedAction_Match_0;

		// Token: 0x04000B56 RID: 2902
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
