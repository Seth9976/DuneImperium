using System;
using Canis;
using Canis.actions;
using Canis.entities;
using Canis.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.events
{
	// Token: 0x02000020 RID: 32
	public class WormEventReactor : SerializableEventReactor<WormMatch>
	{
		// Token: 0x060002EB RID: 747 RVA: 0x00074508 File Offset: 0x00072708
		// Note: this type is marked as 'beforefieldinit'.
		static WormEventReactor()
		{
			Il2CppClassPointerStore<WormEventReactor>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.events", "WormEventReactor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEventReactor>.NativeClassPtr);
			WormEventReactor.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventReactor>.NativeClassPtr, 100663926);
			WormEventReactor.NativeMethodInfoPtr_AppendUndo_Protected_Virtual_Boolean_UndoNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventReactor>.NativeClassPtr, 100663927);
			WormEventReactor.NativeMethodInfoPtr_FireEvent_Public_Virtual_Action_Event_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventReactor>.NativeClassPtr, 100663928);
			WormEventReactor.NativeMethodInfoPtr_FireEvent_Public_Virtual_New_Action_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventReactor>.NativeClassPtr, 100663929);
		}

		// Token: 0x060002EC RID: 748 RVA: 0x00074588 File Offset: 0x00072788
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 34518, RefRangeEnd = 34519, XrefRangeStart = 34515, XrefRangeEnd = 34518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormEventReactor(WormMatch match)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEventReactor>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventReactor.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002ED RID: 749 RVA: 0x000745D4 File Offset: 0x000727D4
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool AppendUndo(UndoNode undoNode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(undoNode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormEventReactor.NativeMethodInfoPtr_AppendUndo_Protected_Virtual_Boolean_UndoNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002EE RID: 750 RVA: 0x0007462C File Offset: 0x0007282C
		[CallerCount(0)]
		public unsafe override Action FireEvent(Event evt, Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormEventReactor.NativeMethodInfoPtr_FireEvent_Public_Virtual_Action_Event_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
		}

		// Token: 0x060002EF RID: 751 RVA: 0x0007469C File Offset: 0x0007289C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34519, XrefRangeEnd = 34597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Action FireEvent(Event evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormEventReactor.NativeMethodInfoPtr_FireEvent_Public_Virtual_New_Action_Event_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x000034FF File Offset: 0x000016FF
		public WormEventReactor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000208 RID: 520
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x04000209 RID: 521
		private static readonly IntPtr NativeMethodInfoPtr_AppendUndo_Protected_Virtual_Boolean_UndoNode_0;

		// Token: 0x0400020A RID: 522
		private static readonly IntPtr NativeMethodInfoPtr_FireEvent_Public_Virtual_Action_Event_Match_0;

		// Token: 0x0400020B RID: 523
		private static readonly IntPtr NativeMethodInfoPtr_FireEvent_Public_Virtual_New_Action_Event_0;
	}
}
