using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.messages.sequence
{
	// Token: 0x0200003F RID: 63
	public class StopSequence : GameMessage
	{
		// Token: 0x0600021F RID: 543 RVA: 0x0000B538 File Offset: 0x00009738
		// Note: this type is marked as 'beforefieldinit'.
		static StopSequence()
		{
			Il2CppClassPointerStore<StopSequence>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Canis.messages.sequence", "StopSequence");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StopSequence>.NativeClassPtr);
			StopSequence.NativeFieldInfoPtr_SequenceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StopSequence>.NativeClassPtr, "SequenceID");
			StopSequence.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StopSequence>.NativeClassPtr, "Name");
			StopSequence.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopSequence>.NativeClassPtr, 100663402);
			StopSequence.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopSequence>.NativeClassPtr, 100663403);
		}

		// Token: 0x06000220 RID: 544 RVA: 0x0000B5B8 File Offset: 0x000097B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193729, XrefRangeEnd = 1193732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StopSequence.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000221 RID: 545 RVA: 0x0000B5FC File Offset: 0x000097FC
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StopSequence()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StopSequence>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StopSequence.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000222 RID: 546 RVA: 0x000036F8 File Offset: 0x000018F8
		public StopSequence(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000223 RID: 547 RVA: 0x0000B638 File Offset: 0x00009838
		// (set) Token: 0x06000224 RID: 548 RVA: 0x00003701 File Offset: 0x00001901
		public unsafe SequenceID SequenceID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StopSequence.NativeFieldInfoPtr_SequenceID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StopSequence.NativeFieldInfoPtr_SequenceID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000225 RID: 549 RVA: 0x0000B668 File Offset: 0x00009868
		// (set) Token: 0x06000226 RID: 550 RVA: 0x00003720 File Offset: 0x00001920
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StopSequence.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StopSequence.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400010A RID: 266
		private static readonly IntPtr NativeFieldInfoPtr_SequenceID;

		// Token: 0x0400010B RID: 267
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x0400010C RID: 268
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400010D RID: 269
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
