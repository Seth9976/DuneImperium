using System;
using Canis.attributes;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.messages.sequence
{
	// Token: 0x0200003C RID: 60
	public class ResumeSequence : GameMessage
	{
		// Token: 0x06000202 RID: 514 RVA: 0x0000B028 File Offset: 0x00009228
		// Note: this type is marked as 'beforefieldinit'.
		static ResumeSequence()
		{
			Il2CppClassPointerStore<ResumeSequence>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Canis.messages.sequence", "ResumeSequence");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResumeSequence>.NativeClassPtr);
			ResumeSequence.NativeFieldInfoPtr_SequenceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumeSequence>.NativeClassPtr, "SequenceID");
			ResumeSequence.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumeSequence>.NativeClassPtr, "Name");
			ResumeSequence.NativeFieldInfoPtr_Attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumeSequence>.NativeClassPtr, "Attributes");
			ResumeSequence.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumeSequence>.NativeClassPtr, 100663395);
			ResumeSequence.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumeSequence>.NativeClassPtr, 100663396);
		}

		// Token: 0x06000203 RID: 515 RVA: 0x0000B0BC File Offset: 0x000092BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193714, XrefRangeEnd = 1193717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResumeSequence.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000204 RID: 516 RVA: 0x0000B100 File Offset: 0x00009300
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResumeSequence()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResumeSequence>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumeSequence.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000205 RID: 517 RVA: 0x000035E5 File Offset: 0x000017E5
		public ResumeSequence(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000206 RID: 518 RVA: 0x0000B13C File Offset: 0x0000933C
		// (set) Token: 0x06000207 RID: 519 RVA: 0x000035EE File Offset: 0x000017EE
		public unsafe SequenceID SequenceID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumeSequence.NativeFieldInfoPtr_SequenceID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumeSequence.NativeFieldInfoPtr_SequenceID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000208 RID: 520 RVA: 0x0000B16C File Offset: 0x0000936C
		// (set) Token: 0x06000209 RID: 521 RVA: 0x0000360D File Offset: 0x0000180D
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumeSequence.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumeSequence.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x0600020A RID: 522 RVA: 0x0000B194 File Offset: 0x00009394
		// (set) Token: 0x0600020B RID: 523 RVA: 0x0000362C File Offset: 0x0000182C
		public unsafe ReadOnlyAttributes Attributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumeSequence.NativeFieldInfoPtr_Attributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttributes>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumeSequence.NativeFieldInfoPtr_Attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000FB RID: 251
		private static readonly IntPtr NativeFieldInfoPtr_SequenceID;

		// Token: 0x040000FC RID: 252
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x040000FD RID: 253
		private static readonly IntPtr NativeFieldInfoPtr_Attributes;

		// Token: 0x040000FE RID: 254
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040000FF RID: 255
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
