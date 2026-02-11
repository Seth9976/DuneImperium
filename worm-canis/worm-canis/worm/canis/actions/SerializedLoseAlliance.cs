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
	// Token: 0x02000261 RID: 609
	public class SerializedLoseAlliance : SerializedAction
	{
		// Token: 0x06001A0C RID: 6668 RVA: 0x000BE2F0 File Offset: 0x000BC4F0
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedLoseAlliance()
		{
			Il2CppClassPointerStore<SerializedLoseAlliance>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "SerializedLoseAlliance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedLoseAlliance>.NativeClassPtr);
			SerializedLoseAlliance.NativeFieldInfoPtr_FactionTrackID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedLoseAlliance>.NativeClassPtr, "FactionTrackID");
			SerializedLoseAlliance.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedLoseAlliance>.NativeClassPtr, 100668138);
			SerializedLoseAlliance.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedLoseAlliance>.NativeClassPtr, 100668139);
		}

		// Token: 0x06001A0D RID: 6669 RVA: 0x000BE35C File Offset: 0x000BC55C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139853, XrefRangeEnd = 139857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedLoseAlliance.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x06001A0E RID: 6670 RVA: 0x000BE3B8 File Offset: 0x000BC5B8
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedLoseAlliance()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedLoseAlliance>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedLoseAlliance.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A0F RID: 6671 RVA: 0x0000B347 File Offset: 0x00009547
		public SerializedLoseAlliance(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000905 RID: 2309
		// (get) Token: 0x06001A10 RID: 6672 RVA: 0x000BE3F4 File Offset: 0x000BC5F4
		// (set) Token: 0x06001A11 RID: 6673 RVA: 0x0000B350 File Offset: 0x00009550
		public unsafe EntityID FactionTrackID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedLoseAlliance.NativeFieldInfoPtr_FactionTrackID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedLoseAlliance.NativeFieldInfoPtr_FactionTrackID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001018 RID: 4120
		private static readonly IntPtr NativeFieldInfoPtr_FactionTrackID;

		// Token: 0x04001019 RID: 4121
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x0400101A RID: 4122
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
