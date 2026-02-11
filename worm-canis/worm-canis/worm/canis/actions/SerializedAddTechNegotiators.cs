using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.actions
{
	// Token: 0x02000285 RID: 645
	public class SerializedAddTechNegotiators : SerializedAction
	{
		// Token: 0x06001B01 RID: 6913 RVA: 0x000C1E10 File Offset: 0x000C0010
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedAddTechNegotiators()
		{
			Il2CppClassPointerStore<SerializedAddTechNegotiators>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "SerializedAddTechNegotiators");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedAddTechNegotiators>.NativeClassPtr);
			SerializedAddTechNegotiators.NativeFieldInfoPtr_Amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedAddTechNegotiators>.NativeClassPtr, "Amount");
			SerializedAddTechNegotiators.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedAddTechNegotiators>.NativeClassPtr, 100668596);
			SerializedAddTechNegotiators.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedAddTechNegotiators>.NativeClassPtr, 100668597);
		}

		// Token: 0x06001B02 RID: 6914 RVA: 0x000C1E7C File Offset: 0x000C007C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145373, XrefRangeEnd = 145377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedAddTechNegotiators.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x06001B03 RID: 6915 RVA: 0x000C1ED8 File Offset: 0x000C00D8
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedAddTechNegotiators()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedAddTechNegotiators>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedAddTechNegotiators.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B04 RID: 6916 RVA: 0x0000B8FB File Offset: 0x00009AFB
		public SerializedAddTechNegotiators(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000926 RID: 2342
		// (get) Token: 0x06001B05 RID: 6917 RVA: 0x000C1F14 File Offset: 0x000C0114
		// (set) Token: 0x06001B06 RID: 6918 RVA: 0x0000B904 File Offset: 0x00009B04
		public unsafe int Amount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedAddTechNegotiators.NativeFieldInfoPtr_Amount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedAddTechNegotiators.NativeFieldInfoPtr_Amount)) = value;
			}
		}

		// Token: 0x040010A8 RID: 4264
		private static readonly IntPtr NativeFieldInfoPtr_Amount;

		// Token: 0x040010A9 RID: 4265
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x040010AA RID: 4266
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
