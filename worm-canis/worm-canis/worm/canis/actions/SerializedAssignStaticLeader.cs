using System;
using Canis;
using Canis.actions;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.actions
{
	// Token: 0x02000229 RID: 553
	public class SerializedAssignStaticLeader : SerializedAssignLeader
	{
		// Token: 0x0600185E RID: 6238 RVA: 0x000B7A38 File Offset: 0x000B5C38
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedAssignStaticLeader()
		{
			Il2CppClassPointerStore<SerializedAssignStaticLeader>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "SerializedAssignStaticLeader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedAssignStaticLeader>.NativeClassPtr);
			SerializedAssignStaticLeader.NativeFieldInfoPtr_OptionID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedAssignStaticLeader>.NativeClassPtr, "OptionID");
			SerializedAssignStaticLeader.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedAssignStaticLeader>.NativeClassPtr, 100667468);
			SerializedAssignStaticLeader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedAssignStaticLeader>.NativeClassPtr, 100667469);
		}

		// Token: 0x0600185F RID: 6239 RVA: 0x000B7AA4 File Offset: 0x000B5CA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131928, XrefRangeEnd = 131940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedAssignStaticLeader.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x06001860 RID: 6240 RVA: 0x000B7B00 File Offset: 0x000B5D00
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedAssignStaticLeader()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedAssignStaticLeader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedAssignStaticLeader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001861 RID: 6241 RVA: 0x0000A905 File Offset: 0x00008B05
		public SerializedAssignStaticLeader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008B7 RID: 2231
		// (get) Token: 0x06001862 RID: 6242 RVA: 0x000B7B3C File Offset: 0x000B5D3C
		// (set) Token: 0x06001863 RID: 6243 RVA: 0x0000A90E File Offset: 0x00008B0E
		public unsafe ArchetypeID OptionID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedAssignStaticLeader.NativeFieldInfoPtr_OptionID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedAssignStaticLeader.NativeFieldInfoPtr_OptionID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000F11 RID: 3857
		private static readonly IntPtr NativeFieldInfoPtr_OptionID;

		// Token: 0x04000F12 RID: 3858
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x04000F13 RID: 3859
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
