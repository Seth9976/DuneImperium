using System;
using System.Runtime.InteropServices;
using Canis.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.actions
{
	// Token: 0x0200018B RID: 395
	public class WhenOnceAction : WrappedAction
	{
		// Token: 0x06001142 RID: 4418 RVA: 0x0005F4E0 File Offset: 0x0005D6E0
		// Note: this type is marked as 'beforefieldinit'.
		static WhenOnceAction()
		{
			Il2CppClassPointerStore<WhenOnceAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "WhenOnceAction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WhenOnceAction>.NativeClassPtr);
			WhenOnceAction.NativeFieldInfoPtr_evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WhenOnceAction>.NativeClassPtr, "evt");
			WhenOnceAction.NativeMethodInfoPtr__ctor_Public_Void_SerializableEvent_Match_Il2CppReferenceArray_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WhenOnceAction>.NativeClassPtr, 100666910);
			WhenOnceAction.NativeMethodInfoPtr_PostAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WhenOnceAction>.NativeClassPtr, 100666911);
			WhenOnceAction.NativeMethodInfoPtr_MakeSerializedWrappedAction_Protected_Virtual_SerializedWrappedAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WhenOnceAction>.NativeClassPtr, 100666912);
		}

		// Token: 0x06001143 RID: 4419 RVA: 0x0005F560 File Offset: 0x0005D760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 583756, XrefRangeEnd = 583763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WhenOnceAction(SerializableEvent evt, Match m, [Optional] Il2CppReferenceArray<Action> actions)
		{
			if (actions == null)
			{
				actions = new Il2CppReferenceArray<Action>(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WhenOnceAction>.NativeClassPtr));
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(actions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WhenOnceAction.NativeMethodInfoPtr__ctor_Public_Void_SerializableEvent_Match_Il2CppReferenceArray_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001144 RID: 4420 RVA: 0x0005F5DC File Offset: 0x0005D7DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 583763, XrefRangeEnd = 583770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action PostAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WhenOnceAction.NativeMethodInfoPtr_PostAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x06001145 RID: 4421 RVA: 0x0005F638 File Offset: 0x0005D838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 583770, XrefRangeEnd = 583776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SerializedWrappedAction MakeSerializedWrappedAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WhenOnceAction.NativeMethodInfoPtr_MakeSerializedWrappedAction_Protected_Virtual_SerializedWrappedAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedWrappedAction>(intPtr3) : null;
			}
		}

		// Token: 0x06001146 RID: 4422 RVA: 0x00008A48 File Offset: 0x00006C48
		public WhenOnceAction(SerializableEvent evt, Match m, params Action[] actions)
			: this(evt, m, new Il2CppReferenceArray<Action>(actions))
		{
		}

		// Token: 0x06001147 RID: 4423 RVA: 0x00008A58 File Offset: 0x00006C58
		public WhenOnceAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06001148 RID: 4424 RVA: 0x0005F694 File Offset: 0x0005D894
		// (set) Token: 0x06001149 RID: 4425 RVA: 0x00008A61 File Offset: 0x00006C61
		public unsafe SerializableEvent evt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WhenOnceAction.NativeFieldInfoPtr_evt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WhenOnceAction.NativeFieldInfoPtr_evt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B50 RID: 2896
		private static readonly IntPtr NativeFieldInfoPtr_evt;

		// Token: 0x04000B51 RID: 2897
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializableEvent_Match_Il2CppReferenceArray_1_Action_0;

		// Token: 0x04000B52 RID: 2898
		private static readonly IntPtr NativeMethodInfoPtr_PostAction_Protected_Virtual_Action_Match_0;

		// Token: 0x04000B53 RID: 2899
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedWrappedAction_Protected_Virtual_SerializedWrappedAction_Match_0;
	}
}
