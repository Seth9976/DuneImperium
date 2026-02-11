using System;
using Canis.actions.serialized;
using Canis.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.actions
{
	// Token: 0x0200018A RID: 394
	[Serializable]
	public class SerializedFireEventV2 : SerializedAction
	{
		// Token: 0x0600113C RID: 4412 RVA: 0x0005F3AC File Offset: 0x0005D5AC
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedFireEventV2()
		{
			Il2CppClassPointerStore<SerializedFireEventV2>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "SerializedFireEventV2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedFireEventV2>.NativeClassPtr);
			SerializedFireEventV2.NativeFieldInfoPtr_Event = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedFireEventV2>.NativeClassPtr, "Event");
			SerializedFireEventV2.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedFireEventV2>.NativeClassPtr, 100666908);
			SerializedFireEventV2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedFireEventV2>.NativeClassPtr, 100666909);
		}

		// Token: 0x0600113D RID: 4413 RVA: 0x0005F418 File Offset: 0x0005D618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 583749, XrefRangeEnd = 583756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedFireEventV2.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x0600113E RID: 4414 RVA: 0x0005F474 File Offset: 0x0005D674
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedFireEventV2()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedFireEventV2>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedFireEventV2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600113F RID: 4415 RVA: 0x00008A20 File Offset: 0x00006C20
		public SerializedFireEventV2(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06001140 RID: 4416 RVA: 0x0005F4B0 File Offset: 0x0005D6B0
		// (set) Token: 0x06001141 RID: 4417 RVA: 0x00008A29 File Offset: 0x00006C29
		public unsafe SerializedEvent Event
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedFireEventV2.NativeFieldInfoPtr_Event);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializedEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedFireEventV2.NativeFieldInfoPtr_Event), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B4D RID: 2893
		private static readonly IntPtr NativeFieldInfoPtr_Event;

		// Token: 0x04000B4E RID: 2894
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x04000B4F RID: 2895
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
