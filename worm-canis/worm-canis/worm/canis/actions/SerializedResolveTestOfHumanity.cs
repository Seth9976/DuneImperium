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
	// Token: 0x0200027D RID: 637
	[Serializable]
	public class SerializedResolveTestOfHumanity : SerializedAction
	{
		// Token: 0x06001AC1 RID: 6849 RVA: 0x000C0DA0 File Offset: 0x000BEFA0
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedResolveTestOfHumanity()
		{
			Il2CppClassPointerStore<SerializedResolveTestOfHumanity>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "SerializedResolveTestOfHumanity");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedResolveTestOfHumanity>.NativeClassPtr);
			SerializedResolveTestOfHumanity.NativeFieldInfoPtr_PlayerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedResolveTestOfHumanity>.NativeClassPtr, "PlayerID");
			SerializedResolveTestOfHumanity.NativeFieldInfoPtr_IntResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedResolveTestOfHumanity>.NativeClassPtr, "IntResponse");
			SerializedResolveTestOfHumanity.NativeFieldInfoPtr_Resolved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedResolveTestOfHumanity>.NativeClassPtr, "Resolved");
			SerializedResolveTestOfHumanity.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedResolveTestOfHumanity>.NativeClassPtr, 100668491);
			SerializedResolveTestOfHumanity.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedResolveTestOfHumanity>.NativeClassPtr, 100668492);
		}

		// Token: 0x06001AC2 RID: 6850 RVA: 0x000C0E34 File Offset: 0x000BF034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143911, XrefRangeEnd = 143912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedResolveTestOfHumanity.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x06001AC3 RID: 6851 RVA: 0x000C0E90 File Offset: 0x000BF090
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedResolveTestOfHumanity()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedResolveTestOfHumanity>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedResolveTestOfHumanity.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AC4 RID: 6852 RVA: 0x0000B7EE File Offset: 0x000099EE
		public SerializedResolveTestOfHumanity(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700091B RID: 2331
		// (get) Token: 0x06001AC5 RID: 6853 RVA: 0x000C0ECC File Offset: 0x000BF0CC
		// (set) Token: 0x06001AC6 RID: 6854 RVA: 0x0000B7F7 File Offset: 0x000099F7
		public unsafe AccountID PlayerID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedResolveTestOfHumanity.NativeFieldInfoPtr_PlayerID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedResolveTestOfHumanity.NativeFieldInfoPtr_PlayerID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700091C RID: 2332
		// (get) Token: 0x06001AC7 RID: 6855 RVA: 0x000C0EFC File Offset: 0x000BF0FC
		// (set) Token: 0x06001AC8 RID: 6856 RVA: 0x0000B816 File Offset: 0x00009A16
		public unsafe int IntResponse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedResolveTestOfHumanity.NativeFieldInfoPtr_IntResponse);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedResolveTestOfHumanity.NativeFieldInfoPtr_IntResponse)) = value;
			}
		}

		// Token: 0x1700091D RID: 2333
		// (get) Token: 0x06001AC9 RID: 6857 RVA: 0x000C0F24 File Offset: 0x000BF124
		// (set) Token: 0x06001ACA RID: 6858 RVA: 0x0000B831 File Offset: 0x00009A31
		public unsafe bool Resolved
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedResolveTestOfHumanity.NativeFieldInfoPtr_Resolved);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedResolveTestOfHumanity.NativeFieldInfoPtr_Resolved)) = value;
			}
		}

		// Token: 0x0400107F RID: 4223
		private static readonly IntPtr NativeFieldInfoPtr_PlayerID;

		// Token: 0x04001080 RID: 4224
		private static readonly IntPtr NativeFieldInfoPtr_IntResponse;

		// Token: 0x04001081 RID: 4225
		private static readonly IntPtr NativeFieldInfoPtr_Resolved;

		// Token: 0x04001082 RID: 4226
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x04001083 RID: 4227
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
