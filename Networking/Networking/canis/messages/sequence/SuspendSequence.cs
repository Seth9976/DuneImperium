using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.messages.sequence
{
	// Token: 0x02000040 RID: 64
	public class SuspendSequence : GameMessage
	{
		// Token: 0x06000227 RID: 551 RVA: 0x0000B690 File Offset: 0x00009890
		// Note: this type is marked as 'beforefieldinit'.
		static SuspendSequence()
		{
			Il2CppClassPointerStore<SuspendSequence>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Canis.messages.sequence", "SuspendSequence");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SuspendSequence>.NativeClassPtr);
			SuspendSequence.NativeFieldInfoPtr_SequenceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SuspendSequence>.NativeClassPtr, "SequenceID");
			SuspendSequence.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SuspendSequence>.NativeClassPtr, "Name");
			SuspendSequence.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SuspendSequence>.NativeClassPtr, 100663404);
			SuspendSequence.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SuspendSequence>.NativeClassPtr, 100663405);
		}

		// Token: 0x06000228 RID: 552 RVA: 0x0000B710 File Offset: 0x00009910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193732, XrefRangeEnd = 1193735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SuspendSequence.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000229 RID: 553 RVA: 0x0000B754 File Offset: 0x00009954
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SuspendSequence()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SuspendSequence>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SuspendSequence.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600022A RID: 554 RVA: 0x0000373F File Offset: 0x0000193F
		public SuspendSequence(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x0600022B RID: 555 RVA: 0x0000B790 File Offset: 0x00009990
		// (set) Token: 0x0600022C RID: 556 RVA: 0x00003748 File Offset: 0x00001948
		public unsafe SequenceID SequenceID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SuspendSequence.NativeFieldInfoPtr_SequenceID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SuspendSequence.NativeFieldInfoPtr_SequenceID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x0600022D RID: 557 RVA: 0x0000B7C0 File Offset: 0x000099C0
		// (set) Token: 0x0600022E RID: 558 RVA: 0x00003767 File Offset: 0x00001967
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SuspendSequence.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SuspendSequence.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400010E RID: 270
		private static readonly IntPtr NativeFieldInfoPtr_SequenceID;

		// Token: 0x0400010F RID: 271
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x04000110 RID: 272
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000111 RID: 273
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
