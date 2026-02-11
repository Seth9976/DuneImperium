using System;
using boardgames.match.selection;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections.Generic;

namespace lib.canis.match.selection
{
	// Token: 0x02000025 RID: 37
	public class DBGSelectIntegerPrompt : DBGSelectionPrompt
	{
		// Token: 0x0600015D RID: 349 RVA: 0x00022098 File Offset: 0x00020298
		// Note: this type is marked as 'beforefieldinit'.
		static DBGSelectIntegerPrompt()
		{
			Il2CppClassPointerStore<DBGSelectIntegerPrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "lib.canis.match.selection", "DBGSelectIntegerPrompt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGSelectIntegerPrompt>.NativeClassPtr);
			DBGSelectIntegerPrompt.NativeFieldInfoPtr_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGSelectIntegerPrompt>.NativeClassPtr, "Min");
			DBGSelectIntegerPrompt.NativeFieldInfoPtr_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGSelectIntegerPrompt>.NativeClassPtr, "Max");
			DBGSelectIntegerPrompt.NativeMethodInfoPtr__ctor_Public_Void_DataComposition_Boolean_IEnumerable_1_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectIntegerPrompt>.NativeClassPtr, 100663554);
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00022104 File Offset: 0x00020304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 497498, XrefRangeEnd = 497499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DBGSelectIntegerPrompt(DataComposition promptData, bool mayCancel, IEnumerable<string> prefabTags, int min, int max)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGSelectIntegerPrompt>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(promptData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mayCancel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(prefabTags);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectIntegerPrompt.NativeMethodInfoPtr__ctor_Public_Void_DataComposition_Boolean_IEnumerable_1_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00002888 File Offset: 0x00000A88
		public DBGSelectIntegerPrompt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000160 RID: 352 RVA: 0x0002218C File Offset: 0x0002038C
		// (set) Token: 0x06000161 RID: 353 RVA: 0x00002891 File Offset: 0x00000A91
		public unsafe int Min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectIntegerPrompt.NativeFieldInfoPtr_Min);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectIntegerPrompt.NativeFieldInfoPtr_Min)) = value;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000162 RID: 354 RVA: 0x000221B4 File Offset: 0x000203B4
		// (set) Token: 0x06000163 RID: 355 RVA: 0x000028AC File Offset: 0x00000AAC
		public unsafe int Max
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectIntegerPrompt.NativeFieldInfoPtr_Max);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectIntegerPrompt.NativeFieldInfoPtr_Max)) = value;
			}
		}

		// Token: 0x040000DB RID: 219
		private static readonly IntPtr NativeFieldInfoPtr_Min;

		// Token: 0x040000DC RID: 220
		private static readonly IntPtr NativeFieldInfoPtr_Max;

		// Token: 0x040000DD RID: 221
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DataComposition_Boolean_IEnumerable_1_String_Int32_Int32_0;
	}
}
