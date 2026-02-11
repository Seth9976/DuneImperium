using System;
using Canis.messages;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.core.match.sequence
{
	// Token: 0x02000009 RID: 9
	public class SequenceElement : Object
	{
		// Token: 0x0600002E RID: 46 RVA: 0x00005170 File Offset: 0x00003370
		// Note: this type is marked as 'beforefieldinit'.
		static SequenceElement()
		{
			Il2CppClassPointerStore<SequenceElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-commands.dll", "dwd.core.match.sequence", "SequenceElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceElement>.NativeClassPtr);
			SequenceElement.NativeFieldInfoPtr_IsSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceElement>.NativeClassPtr, "IsSequence");
			SequenceElement.NativeFieldInfoPtr_sequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceElement>.NativeClassPtr, "sequence");
			SequenceElement.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceElement>.NativeClassPtr, "message");
			SequenceElement.NativeMethodInfoPtr__ctor_Public_Void_MatchSequence_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceElement>.NativeClassPtr, 100663310);
			SequenceElement.NativeMethodInfoPtr__ctor_Public_Void_IGameMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceElement>.NativeClassPtr, 100663311);
			SequenceElement.NativeMethodInfoPtr_get_AsSequence_Public_get_MatchSequence_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceElement>.NativeClassPtr, 100663312);
			SequenceElement.NativeMethodInfoPtr_get_AsMessage_Public_get_IGameMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceElement>.NativeClassPtr, 100663313);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x0000522C File Offset: 0x0000342C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1205863, RefRangeEnd = 1205865, XrefRangeStart = 1205860, XrefRangeEnd = 1205863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SequenceElement(MatchSequence sequence)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceElement>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sequence);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceElement.NativeMethodInfoPtr__ctor_Public_Void_MatchSequence_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00005278 File Offset: 0x00003478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1205865, XrefRangeEnd = 1205868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SequenceElement(IGameMessage message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceElement>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceElement.NativeMethodInfoPtr__ctor_Public_Void_IGameMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000031 RID: 49 RVA: 0x000052C4 File Offset: 0x000034C4
		public unsafe MatchSequence AsSequence
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceElement.NativeMethodInfoPtr_get_AsSequence_Public_get_MatchSequence_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MatchSequence>(intPtr3) : null;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000032 RID: 50 RVA: 0x00005304 File Offset: 0x00003504
		public unsafe IGameMessage AsMessage
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceElement.NativeMethodInfoPtr_get_AsMessage_Public_get_IGameMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IGameMessage>(intPtr3) : null;
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x0000220C File Offset: 0x0000040C
		public SequenceElement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000034 RID: 52 RVA: 0x00005344 File Offset: 0x00003544
		// (set) Token: 0x06000035 RID: 53 RVA: 0x00002215 File Offset: 0x00000415
		public unsafe bool IsSequence
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceElement.NativeFieldInfoPtr_IsSequence);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceElement.NativeFieldInfoPtr_IsSequence)) = value;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000036 RID: 54 RVA: 0x0000536C File Offset: 0x0000356C
		// (set) Token: 0x06000037 RID: 55 RVA: 0x00002230 File Offset: 0x00000430
		public unsafe MatchSequence sequence
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceElement.NativeFieldInfoPtr_sequence);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MatchSequence>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceElement.NativeFieldInfoPtr_sequence), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000038 RID: 56 RVA: 0x0000539C File Offset: 0x0000359C
		// (set) Token: 0x06000039 RID: 57 RVA: 0x0000224F File Offset: 0x0000044F
		public unsafe IGameMessage message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceElement.NativeFieldInfoPtr_message);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGameMessage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceElement.NativeFieldInfoPtr_message), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeFieldInfoPtr_IsSequence;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeFieldInfoPtr_sequence;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeFieldInfoPtr_message;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MatchSequence_0;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IGameMessage_0;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeMethodInfoPtr_get_AsSequence_Public_get_MatchSequence_0;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeMethodInfoPtr_get_AsMessage_Public_get_IGameMessage_0;
	}
}
