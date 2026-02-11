using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.actions
{
	// Token: 0x0200026D RID: 621
	public class SerializedPaySignetIcon : SerializedAction
	{
		// Token: 0x06001A4B RID: 6731 RVA: 0x000BF188 File Offset: 0x000BD388
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedPaySignetIcon()
		{
			Il2CppClassPointerStore<SerializedPaySignetIcon>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "SerializedPaySignetIcon");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedPaySignetIcon>.NativeClassPtr);
			SerializedPaySignetIcon.NativeFieldInfoPtr_PayAll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedPaySignetIcon>.NativeClassPtr, "PayAll");
			SerializedPaySignetIcon.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedPaySignetIcon>.NativeClassPtr, 100668276);
			SerializedPaySignetIcon.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedPaySignetIcon>.NativeClassPtr, 100668277);
		}

		// Token: 0x06001A4C RID: 6732 RVA: 0x000BF1F4 File Offset: 0x000BD3F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140562, XrefRangeEnd = 140566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedPaySignetIcon.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x06001A4D RID: 6733 RVA: 0x000BF250 File Offset: 0x000BD450
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedPaySignetIcon()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedPaySignetIcon>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedPaySignetIcon.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A4E RID: 6734 RVA: 0x0000B544 File Offset: 0x00009744
		public SerializedPaySignetIcon(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000909 RID: 2313
		// (get) Token: 0x06001A4F RID: 6735 RVA: 0x000BF28C File Offset: 0x000BD48C
		// (set) Token: 0x06001A50 RID: 6736 RVA: 0x0000B54D File Offset: 0x0000974D
		public unsafe bool PayAll
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedPaySignetIcon.NativeFieldInfoPtr_PayAll);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedPaySignetIcon.NativeFieldInfoPtr_PayAll)) = value;
			}
		}

		// Token: 0x0400103B RID: 4155
		private static readonly IntPtr NativeFieldInfoPtr_PayAll;

		// Token: 0x0400103C RID: 4156
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x0400103D RID: 4157
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
