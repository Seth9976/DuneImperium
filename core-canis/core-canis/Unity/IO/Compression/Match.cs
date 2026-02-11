using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.IO.Compression
{
	// Token: 0x0200007A RID: 122
	public class Match : Object
	{
		// Token: 0x0600091C RID: 2332 RVA: 0x00036E5C File Offset: 0x0003505C
		// Note: this type is marked as 'beforefieldinit'.
		static Match()
		{
			Il2CppClassPointerStore<Match>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "Unity.IO.Compression", "Match");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Match>.NativeClassPtr);
			Match.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match>.NativeClassPtr, "state");
			Match.NativeFieldInfoPtr_pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match>.NativeClassPtr, "pos");
			Match.NativeFieldInfoPtr_len = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match>.NativeClassPtr, "len");
			Match.NativeFieldInfoPtr_symbol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match>.NativeClassPtr, "symbol");
			Match.NativeMethodInfoPtr_get_State_Internal_get_MatchState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100664576);
			Match.NativeMethodInfoPtr_set_State_Internal_set_Void_MatchState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100664577);
			Match.NativeMethodInfoPtr_get_Position_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100664578);
			Match.NativeMethodInfoPtr_set_Position_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100664579);
			Match.NativeMethodInfoPtr_get_Length_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100664580);
			Match.NativeMethodInfoPtr_set_Length_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100664581);
			Match.NativeMethodInfoPtr_get_Symbol_Internal_get_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100664582);
			Match.NativeMethodInfoPtr_set_Symbol_Internal_set_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100664583);
			Match.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100664584);
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x0600091D RID: 2333 RVA: 0x00036F90 File Offset: 0x00035190
		// (set) Token: 0x0600091E RID: 2334 RVA: 0x00036FCC File Offset: 0x000351CC
		public unsafe MatchState State
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_get_State_Internal_get_MatchState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 307807, RefRangeEnd = 307812, XrefRangeStart = 307807, XrefRangeEnd = 307812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_set_State_Internal_set_Void_MatchState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x0600091F RID: 2335 RVA: 0x0003700C File Offset: 0x0003520C
		// (set) Token: 0x06000920 RID: 2336 RVA: 0x00037048 File Offset: 0x00035248
		public unsafe int Position
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_get_Position_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 310312, RefRangeEnd = 310318, XrefRangeStart = 310312, XrefRangeEnd = 310318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_set_Position_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06000921 RID: 2337 RVA: 0x00037088 File Offset: 0x00035288
		// (set) Token: 0x06000922 RID: 2338 RVA: 0x000370C4 File Offset: 0x000352C4
		public unsafe int Length
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_get_Length_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 311421, RefRangeEnd = 311423, XrefRangeStart = 311421, XrefRangeEnd = 311423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_set_Length_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x06000923 RID: 2339 RVA: 0x00037104 File Offset: 0x00035304
		// (set) Token: 0x06000924 RID: 2340 RVA: 0x00037140 File Offset: 0x00035340
		public unsafe byte Symbol
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_get_Symbol_Internal_get_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_set_Symbol_Internal_set_Void_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000925 RID: 2341 RVA: 0x00037180 File Offset: 0x00035380
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Match()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Match>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000926 RID: 2342 RVA: 0x00005237 File Offset: 0x00003437
		public Match(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06000927 RID: 2343 RVA: 0x000371BC File Offset: 0x000353BC
		// (set) Token: 0x06000928 RID: 2344 RVA: 0x00005240 File Offset: 0x00003440
		public unsafe MatchState state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr_state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr_state)) = value;
			}
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06000929 RID: 2345 RVA: 0x000371E4 File Offset: 0x000353E4
		// (set) Token: 0x0600092A RID: 2346 RVA: 0x0000525B File Offset: 0x0000345B
		public unsafe int pos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr_pos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr_pos)) = value;
			}
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x0600092B RID: 2347 RVA: 0x0003720C File Offset: 0x0003540C
		// (set) Token: 0x0600092C RID: 2348 RVA: 0x00005276 File Offset: 0x00003476
		public unsafe int len
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr_len);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr_len)) = value;
			}
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x0600092D RID: 2349 RVA: 0x00037234 File Offset: 0x00035434
		// (set) Token: 0x0600092E RID: 2350 RVA: 0x00005291 File Offset: 0x00003491
		public unsafe byte symbol
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr_symbol);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr_symbol)) = value;
			}
		}

		// Token: 0x040006CC RID: 1740
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x040006CD RID: 1741
		private static readonly IntPtr NativeFieldInfoPtr_pos;

		// Token: 0x040006CE RID: 1742
		private static readonly IntPtr NativeFieldInfoPtr_len;

		// Token: 0x040006CF RID: 1743
		private static readonly IntPtr NativeFieldInfoPtr_symbol;

		// Token: 0x040006D0 RID: 1744
		private static readonly IntPtr NativeMethodInfoPtr_get_State_Internal_get_MatchState_0;

		// Token: 0x040006D1 RID: 1745
		private static readonly IntPtr NativeMethodInfoPtr_set_State_Internal_set_Void_MatchState_0;

		// Token: 0x040006D2 RID: 1746
		private static readonly IntPtr NativeMethodInfoPtr_get_Position_Internal_get_Int32_0;

		// Token: 0x040006D3 RID: 1747
		private static readonly IntPtr NativeMethodInfoPtr_set_Position_Internal_set_Void_Int32_0;

		// Token: 0x040006D4 RID: 1748
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Internal_get_Int32_0;

		// Token: 0x040006D5 RID: 1749
		private static readonly IntPtr NativeMethodInfoPtr_set_Length_Internal_set_Void_Int32_0;

		// Token: 0x040006D6 RID: 1750
		private static readonly IntPtr NativeMethodInfoPtr_get_Symbol_Internal_get_Byte_0;

		// Token: 0x040006D7 RID: 1751
		private static readonly IntPtr NativeMethodInfoPtr_set_Symbol_Internal_set_Void_Byte_0;

		// Token: 0x040006D8 RID: 1752
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
