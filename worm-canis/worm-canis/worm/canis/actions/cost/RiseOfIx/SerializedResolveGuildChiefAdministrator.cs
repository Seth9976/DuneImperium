using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.actions.cost.RiseOfIx
{
	// Token: 0x0200030D RID: 781
	public class SerializedResolveGuildChiefAdministrator : SerializedAction
	{
		// Token: 0x06001FF3 RID: 8179 RVA: 0x000D5F14 File Offset: 0x000D4114
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedResolveGuildChiefAdministrator()
		{
			Il2CppClassPointerStore<SerializedResolveGuildChiefAdministrator>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions.cost.RiseOfIx", "SerializedResolveGuildChiefAdministrator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedResolveGuildChiefAdministrator>.NativeClassPtr);
			SerializedResolveGuildChiefAdministrator.NativeFieldInfoPtr_DiscardCardID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedResolveGuildChiefAdministrator>.NativeClassPtr, "DiscardCardID");
			SerializedResolveGuildChiefAdministrator.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedResolveGuildChiefAdministrator>.NativeClassPtr, 100671056);
			SerializedResolveGuildChiefAdministrator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedResolveGuildChiefAdministrator>.NativeClassPtr, 100671057);
		}

		// Token: 0x06001FF4 RID: 8180 RVA: 0x000D5F80 File Offset: 0x000D4180
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174585, XrefRangeEnd = 174595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedResolveGuildChiefAdministrator.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x06001FF5 RID: 8181 RVA: 0x000D5FDC File Offset: 0x000D41DC
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedResolveGuildChiefAdministrator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedResolveGuildChiefAdministrator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedResolveGuildChiefAdministrator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FF6 RID: 8182 RVA: 0x0000D436 File Offset: 0x0000B636
		public SerializedResolveGuildChiefAdministrator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A0D RID: 2573
		// (get) Token: 0x06001FF7 RID: 8183 RVA: 0x000D6018 File Offset: 0x000D4218
		// (set) Token: 0x06001FF8 RID: 8184 RVA: 0x0000D43F File Offset: 0x0000B63F
		public unsafe EntityID DiscardCardID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedResolveGuildChiefAdministrator.NativeFieldInfoPtr_DiscardCardID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedResolveGuildChiefAdministrator.NativeFieldInfoPtr_DiscardCardID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001424 RID: 5156
		private static readonly IntPtr NativeFieldInfoPtr_DiscardCardID;

		// Token: 0x04001425 RID: 5157
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x04001426 RID: 5158
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
