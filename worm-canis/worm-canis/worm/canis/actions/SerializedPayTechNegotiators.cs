using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.actions
{
	// Token: 0x0200028B RID: 651
	public class SerializedPayTechNegotiators : SerializedAction
	{
		// Token: 0x06001B3C RID: 6972 RVA: 0x000C2C5C File Offset: 0x000C0E5C
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedPayTechNegotiators()
		{
			Il2CppClassPointerStore<SerializedPayTechNegotiators>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "SerializedPayTechNegotiators");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedPayTechNegotiators>.NativeClassPtr);
			SerializedPayTechNegotiators.NativeFieldInfoPtr_Amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedPayTechNegotiators>.NativeClassPtr, "Amount");
			SerializedPayTechNegotiators.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedPayTechNegotiators>.NativeClassPtr, 100668682);
			SerializedPayTechNegotiators.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedPayTechNegotiators>.NativeClassPtr, 100668683);
		}

		// Token: 0x06001B3D RID: 6973 RVA: 0x000C2CC8 File Offset: 0x000C0EC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145956, XrefRangeEnd = 145960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedPayTechNegotiators.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x06001B3E RID: 6974 RVA: 0x000C2D24 File Offset: 0x000C0F24
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedPayTechNegotiators()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedPayTechNegotiators>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedPayTechNegotiators.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B3F RID: 6975 RVA: 0x0000BA4B File Offset: 0x00009C4B
		public SerializedPayTechNegotiators(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000932 RID: 2354
		// (get) Token: 0x06001B40 RID: 6976 RVA: 0x000C2D60 File Offset: 0x000C0F60
		// (set) Token: 0x06001B41 RID: 6977 RVA: 0x0000BA54 File Offset: 0x00009C54
		public unsafe int Amount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedPayTechNegotiators.NativeFieldInfoPtr_Amount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedPayTechNegotiators.NativeFieldInfoPtr_Amount)) = value;
			}
		}

		// Token: 0x040010CD RID: 4301
		private static readonly IntPtr NativeFieldInfoPtr_Amount;

		// Token: 0x040010CE RID: 4302
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x040010CF RID: 4303
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
