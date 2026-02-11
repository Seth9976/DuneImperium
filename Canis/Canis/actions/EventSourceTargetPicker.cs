using System;
using Canis.actions.responseparsers;
using Canis.actions.serialized;
using Canis.entities;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.actions
{
	// Token: 0x02000190 RID: 400
	public class EventSourceTargetPicker : TargetPicker<Entity>
	{
		// Token: 0x06001189 RID: 4489 RVA: 0x000607B4 File Offset: 0x0005E9B4
		// Note: this type is marked as 'beforefieldinit'.
		static EventSourceTargetPicker()
		{
			Il2CppClassPointerStore<EventSourceTargetPicker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "EventSourceTargetPicker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventSourceTargetPicker>.NativeClassPtr);
			EventSourceTargetPicker.NativeMethodInfoPtr__ctor_Public_Void_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSourceTargetPicker>.NativeClassPtr, 100666976);
			EventSourceTargetPicker.NativeMethodInfoPtr_get_responseParser_Public_Virtual_get_ResponseParser_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSourceTargetPicker>.NativeClassPtr, 100666977);
			EventSourceTargetPicker.NativeMethodInfoPtr_PickTargets_Public_Virtual_SelectionRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSourceTargetPicker>.NativeClassPtr, 100666978);
			EventSourceTargetPicker.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSourceTargetPicker>.NativeClassPtr, 100666979);
		}

		// Token: 0x0600118A RID: 4490 RVA: 0x00060834 File Offset: 0x0005EA34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 584093, XrefRangeEnd = 584096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventSourceTargetPicker(Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventSourceTargetPicker>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSourceTargetPicker.NativeMethodInfoPtr__ctor_Public_Void_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x0600118B RID: 4491 RVA: 0x00060880 File Offset: 0x0005EA80
		public unsafe override ResponseParser<Entity> responseParser
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 584096, XrefRangeEnd = 584115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventSourceTargetPicker.NativeMethodInfoPtr_get_responseParser_Public_Virtual_get_ResponseParser_1_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResponseParser<Entity>>(intPtr3) : null;
			}
		}

		// Token: 0x0600118C RID: 4492 RVA: 0x000608CC File Offset: 0x0005EACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 584115, XrefRangeEnd = 584134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SelectionRequest PickTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventSourceTargetPicker.NativeMethodInfoPtr_PickTargets_Public_Virtual_SelectionRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SelectionRequest>(intPtr3) : null;
		}

		// Token: 0x0600118D RID: 4493 RVA: 0x00060918 File Offset: 0x0005EB18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 584134, XrefRangeEnd = 584154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SerializedAction MakeSerializedAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventSourceTargetPicker.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedAction>(intPtr3) : null;
			}
		}

		// Token: 0x0600118E RID: 4494 RVA: 0x00008BF8 File Offset: 0x00006DF8
		public EventSourceTargetPicker(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B81 RID: 2945
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Match_0;

		// Token: 0x04000B82 RID: 2946
		private static readonly IntPtr NativeMethodInfoPtr_get_responseParser_Public_Virtual_get_ResponseParser_1_Entity_0;

		// Token: 0x04000B83 RID: 2947
		private static readonly IntPtr NativeMethodInfoPtr_PickTargets_Public_Virtual_SelectionRequest_0;

		// Token: 0x04000B84 RID: 2948
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0;
	}
}
