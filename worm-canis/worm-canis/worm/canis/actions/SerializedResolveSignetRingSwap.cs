using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.actions
{
	// Token: 0x0200027B RID: 635
	public class SerializedResolveSignetRingSwap : SerializedAction
	{
		// Token: 0x06001AAC RID: 6828 RVA: 0x000C090C File Offset: 0x000BEB0C
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedResolveSignetRingSwap()
		{
			Il2CppClassPointerStore<SerializedResolveSignetRingSwap>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "SerializedResolveSignetRingSwap");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedResolveSignetRingSwap>.NativeClassPtr);
			SerializedResolveSignetRingSwap.NativeFieldInfoPtr_entityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedResolveSignetRingSwap>.NativeClassPtr, "entityID");
			SerializedResolveSignetRingSwap.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedResolveSignetRingSwap>.NativeClassPtr, 100668471);
			SerializedResolveSignetRingSwap.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedResolveSignetRingSwap>.NativeClassPtr, 100668472);
		}

		// Token: 0x06001AAD RID: 6829 RVA: 0x000C0978 File Offset: 0x000BEB78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143761, XrefRangeEnd = 143769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedResolveSignetRingSwap.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x06001AAE RID: 6830 RVA: 0x000C09D4 File Offset: 0x000BEBD4
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedResolveSignetRingSwap()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedResolveSignetRingSwap>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedResolveSignetRingSwap.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AAF RID: 6831 RVA: 0x0000B749 File Offset: 0x00009949
		public SerializedResolveSignetRingSwap(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000916 RID: 2326
		// (get) Token: 0x06001AB0 RID: 6832 RVA: 0x000C0A10 File Offset: 0x000BEC10
		// (set) Token: 0x06001AB1 RID: 6833 RVA: 0x0000B752 File Offset: 0x00009952
		public unsafe EntityID entityID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedResolveSignetRingSwap.NativeFieldInfoPtr_entityID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedResolveSignetRingSwap.NativeFieldInfoPtr_entityID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001073 RID: 4211
		private static readonly IntPtr NativeFieldInfoPtr_entityID;

		// Token: 0x04001074 RID: 4212
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x04001075 RID: 4213
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
