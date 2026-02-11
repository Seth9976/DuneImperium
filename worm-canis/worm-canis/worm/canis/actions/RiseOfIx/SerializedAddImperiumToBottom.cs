using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.actions.RiseOfIx
{
	// Token: 0x020002AE RID: 686
	public class SerializedAddImperiumToBottom : SerializedAction
	{
		// Token: 0x06001C4F RID: 7247 RVA: 0x000C6E90 File Offset: 0x000C5090
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedAddImperiumToBottom()
		{
			Il2CppClassPointerStore<SerializedAddImperiumToBottom>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions.RiseOfIx", "SerializedAddImperiumToBottom");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedAddImperiumToBottom>.NativeClassPtr);
			SerializedAddImperiumToBottom.NativeFieldInfoPtr_ArchID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedAddImperiumToBottom>.NativeClassPtr, "ArchID");
			SerializedAddImperiumToBottom.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedAddImperiumToBottom>.NativeClassPtr, 100669119);
			SerializedAddImperiumToBottom.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedAddImperiumToBottom>.NativeClassPtr, 100669120);
		}

		// Token: 0x06001C50 RID: 7248 RVA: 0x000C6EFC File Offset: 0x000C50FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150865, XrefRangeEnd = 150874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedAddImperiumToBottom.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x06001C51 RID: 7249 RVA: 0x000C6F58 File Offset: 0x000C5158
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedAddImperiumToBottom()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedAddImperiumToBottom>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedAddImperiumToBottom.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C52 RID: 7250 RVA: 0x0000C007 File Offset: 0x0000A207
		public SerializedAddImperiumToBottom(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000960 RID: 2400
		// (get) Token: 0x06001C53 RID: 7251 RVA: 0x000C6F94 File Offset: 0x000C5194
		// (set) Token: 0x06001C54 RID: 7252 RVA: 0x0000C010 File Offset: 0x0000A210
		public unsafe ArchetypeID ArchID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedAddImperiumToBottom.NativeFieldInfoPtr_ArchID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedAddImperiumToBottom.NativeFieldInfoPtr_ArchID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001178 RID: 4472
		private static readonly IntPtr NativeFieldInfoPtr_ArchID;

		// Token: 0x04001179 RID: 4473
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x0400117A RID: 4474
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
