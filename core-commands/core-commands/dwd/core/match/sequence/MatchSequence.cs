using System;
using Canis.attributes;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.match.sequence
{
	// Token: 0x02000008 RID: 8
	public class MatchSequence : List<SequenceElement>
	{
		// Token: 0x06000025 RID: 37 RVA: 0x00004FE4 File Offset: 0x000031E4
		// Note: this type is marked as 'beforefieldinit'.
		static MatchSequence()
		{
			Il2CppClassPointerStore<MatchSequence>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-commands.dll", "dwd.core.match.sequence", "MatchSequence");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MatchSequence>.NativeClassPtr);
			MatchSequence.NativeFieldInfoPtr_SequenceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchSequence>.NativeClassPtr, "SequenceID");
			MatchSequence.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchSequence>.NativeClassPtr, "Name");
			MatchSequence.NativeFieldInfoPtr_Attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchSequence>.NativeClassPtr, "Attributes");
			MatchSequence.NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_ReadOnlyAttributes_IList_1_SequenceElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchSequence>.NativeClassPtr, 100663309);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00005064 File Offset: 0x00003264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1205851, XrefRangeEnd = 1205860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MatchSequence(SequenceID sequenceID, string name, ReadOnlyAttributes attributes, IList<SequenceElement> elements)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MatchSequence>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sequenceID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(elements);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchSequence.NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_ReadOnlyAttributes_IList_1_SequenceElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000021A6 File Offset: 0x000003A6
		public MatchSequence(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000028 RID: 40 RVA: 0x000050E8 File Offset: 0x000032E8
		// (set) Token: 0x06000029 RID: 41 RVA: 0x000021AF File Offset: 0x000003AF
		public unsafe SequenceID SequenceID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchSequence.NativeFieldInfoPtr_SequenceID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchSequence.NativeFieldInfoPtr_SequenceID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600002A RID: 42 RVA: 0x00005118 File Offset: 0x00003318
		// (set) Token: 0x0600002B RID: 43 RVA: 0x000021CE File Offset: 0x000003CE
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchSequence.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchSequence.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600002C RID: 44 RVA: 0x00005140 File Offset: 0x00003340
		// (set) Token: 0x0600002D RID: 45 RVA: 0x000021ED File Offset: 0x000003ED
		public unsafe ReadOnlyAttributes Attributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchSequence.NativeFieldInfoPtr_Attributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttributes>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchSequence.NativeFieldInfoPtr_Attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeFieldInfoPtr_SequenceID;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeFieldInfoPtr_Attributes;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_ReadOnlyAttributes_IList_1_SequenceElement_0;
	}
}
