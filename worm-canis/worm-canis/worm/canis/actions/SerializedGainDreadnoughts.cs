using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.actions
{
	// Token: 0x02000250 RID: 592
	public class SerializedGainDreadnoughts : SerializedAction
	{
		// Token: 0x06001996 RID: 6550 RVA: 0x000BC588 File Offset: 0x000BA788
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedGainDreadnoughts()
		{
			Il2CppClassPointerStore<SerializedGainDreadnoughts>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "SerializedGainDreadnoughts");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedGainDreadnoughts>.NativeClassPtr);
			SerializedGainDreadnoughts.NativeFieldInfoPtr_Amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedGainDreadnoughts>.NativeClassPtr, "Amount");
			SerializedGainDreadnoughts.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedGainDreadnoughts>.NativeClassPtr, 100667972);
			SerializedGainDreadnoughts.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedGainDreadnoughts>.NativeClassPtr, 100667973);
		}

		// Token: 0x06001997 RID: 6551 RVA: 0x000BC5F4 File Offset: 0x000BA7F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137580, XrefRangeEnd = 137586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedGainDreadnoughts.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x06001998 RID: 6552 RVA: 0x000BC650 File Offset: 0x000BA850
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedGainDreadnoughts()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedGainDreadnoughts>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedGainDreadnoughts.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001999 RID: 6553 RVA: 0x0000B0A6 File Offset: 0x000092A6
		public SerializedGainDreadnoughts(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008F1 RID: 2289
		// (get) Token: 0x0600199A RID: 6554 RVA: 0x000BC68C File Offset: 0x000BA88C
		// (set) Token: 0x0600199B RID: 6555 RVA: 0x0000B0AF File Offset: 0x000092AF
		public unsafe int Amount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGainDreadnoughts.NativeFieldInfoPtr_Amount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGainDreadnoughts.NativeFieldInfoPtr_Amount)) = value;
			}
		}

		// Token: 0x04000FCD RID: 4045
		private static readonly IntPtr NativeFieldInfoPtr_Amount;

		// Token: 0x04000FCE RID: 4046
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x04000FCF RID: 4047
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
