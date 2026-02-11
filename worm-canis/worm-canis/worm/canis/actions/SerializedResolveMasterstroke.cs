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
	// Token: 0x02000277 RID: 631
	public class SerializedResolveMasterstroke : SerializedAction
	{
		// Token: 0x06001A93 RID: 6803 RVA: 0x000C029C File Offset: 0x000BE49C
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedResolveMasterstroke()
		{
			Il2CppClassPointerStore<SerializedResolveMasterstroke>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "SerializedResolveMasterstroke");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedResolveMasterstroke>.NativeClassPtr);
			SerializedResolveMasterstroke.NativeFieldInfoPtr_entityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedResolveMasterstroke>.NativeClassPtr, "entityID");
			SerializedResolveMasterstroke.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedResolveMasterstroke>.NativeClassPtr, 100668423);
			SerializedResolveMasterstroke.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedResolveMasterstroke>.NativeClassPtr, 100668424);
		}

		// Token: 0x06001A94 RID: 6804 RVA: 0x000C0308 File Offset: 0x000BE508
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143381, XrefRangeEnd = 143394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedResolveMasterstroke.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x06001A95 RID: 6805 RVA: 0x000C0364 File Offset: 0x000BE564
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedResolveMasterstroke()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedResolveMasterstroke>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedResolveMasterstroke.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A96 RID: 6806 RVA: 0x0000B6E7 File Offset: 0x000098E7
		public SerializedResolveMasterstroke(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000914 RID: 2324
		// (get) Token: 0x06001A97 RID: 6807 RVA: 0x000C03A0 File Offset: 0x000BE5A0
		// (set) Token: 0x06001A98 RID: 6808 RVA: 0x0000B6F0 File Offset: 0x000098F0
		public unsafe EntityID entityID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedResolveMasterstroke.NativeFieldInfoPtr_entityID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedResolveMasterstroke.NativeFieldInfoPtr_entityID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001064 RID: 4196
		private static readonly IntPtr NativeFieldInfoPtr_entityID;

		// Token: 0x04001065 RID: 4197
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x04001066 RID: 4198
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
