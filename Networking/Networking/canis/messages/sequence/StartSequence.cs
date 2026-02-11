using System;
using Canis.attributes;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.messages.sequence
{
	// Token: 0x0200003E RID: 62
	public class StartSequence : GameMessage
	{
		// Token: 0x06000215 RID: 533 RVA: 0x0000B39C File Offset: 0x0000959C
		// Note: this type is marked as 'beforefieldinit'.
		static StartSequence()
		{
			Il2CppClassPointerStore<StartSequence>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Canis.messages.sequence", "StartSequence");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StartSequence>.NativeClassPtr);
			StartSequence.NativeFieldInfoPtr_SequenceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartSequence>.NativeClassPtr, "SequenceID");
			StartSequence.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartSequence>.NativeClassPtr, "Name");
			StartSequence.NativeFieldInfoPtr_Attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartSequence>.NativeClassPtr, "Attributes");
			StartSequence.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartSequence>.NativeClassPtr, 100663400);
			StartSequence.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartSequence>.NativeClassPtr, 100663401);
		}

		// Token: 0x06000216 RID: 534 RVA: 0x0000B430 File Offset: 0x00009630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193726, XrefRangeEnd = 1193729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StartSequence.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000217 RID: 535 RVA: 0x0000B474 File Offset: 0x00009674
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StartSequence()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StartSequence>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartSequence.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00003692 File Offset: 0x00001892
		public StartSequence(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000219 RID: 537 RVA: 0x0000B4B0 File Offset: 0x000096B0
		// (set) Token: 0x0600021A RID: 538 RVA: 0x0000369B File Offset: 0x0000189B
		public unsafe SequenceID SequenceID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartSequence.NativeFieldInfoPtr_SequenceID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartSequence.NativeFieldInfoPtr_SequenceID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x0600021B RID: 539 RVA: 0x0000B4E0 File Offset: 0x000096E0
		// (set) Token: 0x0600021C RID: 540 RVA: 0x000036BA File Offset: 0x000018BA
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartSequence.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartSequence.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x0600021D RID: 541 RVA: 0x0000B508 File Offset: 0x00009708
		// (set) Token: 0x0600021E RID: 542 RVA: 0x000036D9 File Offset: 0x000018D9
		public unsafe ReadOnlyAttributes Attributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartSequence.NativeFieldInfoPtr_Attributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttributes>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartSequence.NativeFieldInfoPtr_Attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000105 RID: 261
		private static readonly IntPtr NativeFieldInfoPtr_SequenceID;

		// Token: 0x04000106 RID: 262
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x04000107 RID: 263
		private static readonly IntPtr NativeFieldInfoPtr_Attributes;

		// Token: 0x04000108 RID: 264
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000109 RID: 265
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
