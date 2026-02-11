using System;
using Canis.actions.serialized;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.actions
{
	// Token: 0x02000227 RID: 551
	public class SerializedAssignLeader : SerializedAction
	{
		// Token: 0x06001851 RID: 6225 RVA: 0x000B76B0 File Offset: 0x000B58B0
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedAssignLeader()
		{
			Il2CppClassPointerStore<SerializedAssignLeader>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "SerializedAssignLeader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedAssignLeader>.NativeClassPtr);
			SerializedAssignLeader.NativeFieldInfoPtr_PlayerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedAssignLeader>.NativeClassPtr, "PlayerID");
			SerializedAssignLeader.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedAssignLeader>.NativeClassPtr, 100667453);
		}

		// Token: 0x06001852 RID: 6226 RVA: 0x000B7708 File Offset: 0x000B5908
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedAssignLeader()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedAssignLeader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedAssignLeader.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001853 RID: 6227 RVA: 0x0000A8D4 File Offset: 0x00008AD4
		public SerializedAssignLeader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008B4 RID: 2228
		// (get) Token: 0x06001854 RID: 6228 RVA: 0x000B7744 File Offset: 0x000B5944
		// (set) Token: 0x06001855 RID: 6229 RVA: 0x0000A8DD File Offset: 0x00008ADD
		public unsafe EntityID PlayerID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedAssignLeader.NativeFieldInfoPtr_PlayerID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedAssignLeader.NativeFieldInfoPtr_PlayerID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000F09 RID: 3849
		private static readonly IntPtr NativeFieldInfoPtr_PlayerID;

		// Token: 0x04000F0A RID: 3850
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
