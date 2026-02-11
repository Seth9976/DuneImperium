using System;
using canis.Networking.game.messages;
using Canis.utils.ids;
using dbgclient.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using TMPro;

namespace dbgclient.dataRenderers
{
	// Token: 0x020000BA RID: 186
	public class MatchHistoryDataRenderer : Subscriber<MatchHistoryData>
	{
		// Token: 0x06000798 RID: 1944 RVA: 0x00035554 File Offset: 0x00033754
		// Note: this type is marked as 'beforefieldinit'.
		static MatchHistoryDataRenderer()
		{
			Il2CppClassPointerStore<MatchHistoryDataRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.dataRenderers", "MatchHistoryDataRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MatchHistoryDataRenderer>.NativeClassPtr);
			MatchHistoryDataRenderer.NativeFieldInfoPtr_gameMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchHistoryDataRenderer>.NativeClassPtr, "gameMode");
			MatchHistoryDataRenderer.NativeFieldInfoPtr_date = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchHistoryDataRenderer>.NativeClassPtr, "date");
			MatchHistoryDataRenderer.NativeFieldInfoPtr_score = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchHistoryDataRenderer>.NativeClassPtr, "score");
			MatchHistoryDataRenderer.NativeFieldInfoPtr_placement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchHistoryDataRenderer>.NativeClassPtr, "placement");
			MatchHistoryDataRenderer.NativeFieldInfoPtr_opponents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchHistoryDataRenderer>.NativeClassPtr, "opponents");
			MatchHistoryDataRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchHistoryDataRenderer>.NativeClassPtr, 100664442);
			MatchHistoryDataRenderer.NativeMethodInfoPtr_SetGameSpecificValues_Protected_Virtual_New_Void_MatchHistoryResultDetail_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchHistoryDataRenderer>.NativeClassPtr, 100664443);
			MatchHistoryDataRenderer.NativeMethodInfoPtr_GetPlayerName_Protected_Virtual_New_String_MatchHistoryResultDetail_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchHistoryDataRenderer>.NativeClassPtr, 100664444);
			MatchHistoryDataRenderer.NativeMethodInfoPtr_GetScoreString_Protected_Virtual_New_String_MatchHistoryResultDetail_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchHistoryDataRenderer>.NativeClassPtr, 100664445);
			MatchHistoryDataRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchHistoryDataRenderer>.NativeClassPtr, 100664446);
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x0003564C File Offset: 0x0003384C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504399, XrefRangeEnd = 504464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void modelChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MatchHistoryDataRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x00035688 File Offset: 0x00033888
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetGameSpecificValues(MatchHistoryResultDetail detail)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(detail);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MatchHistoryDataRenderer.NativeMethodInfoPtr_SetGameSpecificValues_Protected_Virtual_New_Void_MatchHistoryResultDetail_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x000356D8 File Offset: 0x000338D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504464, XrefRangeEnd = 504468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetPlayerName(MatchHistoryResultDetail detail)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(detail);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MatchHistoryDataRenderer.NativeMethodInfoPtr_GetPlayerName_Protected_Virtual_New_String_MatchHistoryResultDetail_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x0003572C File Offset: 0x0003392C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504468, XrefRangeEnd = 504475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetScoreString(MatchHistoryResultDetail localDetails)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(localDetails);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MatchHistoryDataRenderer.NativeMethodInfoPtr_GetScoreString_Protected_Virtual_New_String_MatchHistoryResultDetail_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x00035780 File Offset: 0x00033980
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 504482, RefRangeEnd = 504483, XrefRangeStart = 504475, XrefRangeEnd = 504482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MatchHistoryDataRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MatchHistoryDataRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchHistoryDataRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x00005873 File Offset: 0x00003A73
		public MatchHistoryDataRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x0600079F RID: 1951 RVA: 0x000357BC File Offset: 0x000339BC
		// (set) Token: 0x060007A0 RID: 1952 RVA: 0x0000587C File Offset: 0x00003A7C
		public unsafe TMP_Text gameMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchHistoryDataRenderer.NativeFieldInfoPtr_gameMode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchHistoryDataRenderer.NativeFieldInfoPtr_gameMode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x060007A1 RID: 1953 RVA: 0x000357EC File Offset: 0x000339EC
		// (set) Token: 0x060007A2 RID: 1954 RVA: 0x0000589B File Offset: 0x00003A9B
		public unsafe TMP_Text date
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchHistoryDataRenderer.NativeFieldInfoPtr_date);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchHistoryDataRenderer.NativeFieldInfoPtr_date), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x060007A3 RID: 1955 RVA: 0x0003581C File Offset: 0x00033A1C
		// (set) Token: 0x060007A4 RID: 1956 RVA: 0x000058BA File Offset: 0x00003ABA
		public unsafe TMP_Text score
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchHistoryDataRenderer.NativeFieldInfoPtr_score);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchHistoryDataRenderer.NativeFieldInfoPtr_score), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x060007A5 RID: 1957 RVA: 0x0003584C File Offset: 0x00033A4C
		// (set) Token: 0x060007A6 RID: 1958 RVA: 0x000058D9 File Offset: 0x00003AD9
		public unsafe TMP_Text placement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchHistoryDataRenderer.NativeFieldInfoPtr_placement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchHistoryDataRenderer.NativeFieldInfoPtr_placement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x060007A7 RID: 1959 RVA: 0x0003587C File Offset: 0x00033A7C
		// (set) Token: 0x060007A8 RID: 1960 RVA: 0x000058F8 File Offset: 0x00003AF8
		public unsafe Il2CppReferenceArray<TMP_Text> opponents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchHistoryDataRenderer.NativeFieldInfoPtr_opponents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TMP_Text>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchHistoryDataRenderer.NativeFieldInfoPtr_opponents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040004A3 RID: 1187
		private static readonly IntPtr NativeFieldInfoPtr_gameMode;

		// Token: 0x040004A4 RID: 1188
		private static readonly IntPtr NativeFieldInfoPtr_date;

		// Token: 0x040004A5 RID: 1189
		private static readonly IntPtr NativeFieldInfoPtr_score;

		// Token: 0x040004A6 RID: 1190
		private static readonly IntPtr NativeFieldInfoPtr_placement;

		// Token: 0x040004A7 RID: 1191
		private static readonly IntPtr NativeFieldInfoPtr_opponents;

		// Token: 0x040004A8 RID: 1192
		private static readonly IntPtr NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0;

		// Token: 0x040004A9 RID: 1193
		private static readonly IntPtr NativeMethodInfoPtr_SetGameSpecificValues_Protected_Virtual_New_Void_MatchHistoryResultDetail_0;

		// Token: 0x040004AA RID: 1194
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayerName_Protected_Virtual_New_String_MatchHistoryResultDetail_0;

		// Token: 0x040004AB RID: 1195
		private static readonly IntPtr NativeMethodInfoPtr_GetScoreString_Protected_Virtual_New_String_MatchHistoryResultDetail_0;

		// Token: 0x040004AC RID: 1196
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000320 RID: 800
		[ObfuscatedName("dbgclient.dataRenderers.MatchHistoryDataRenderer+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : Object
		{
			// Token: 0x060025C2 RID: 9666 RVA: 0x0009961C File Offset: 0x0009781C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<MatchHistoryDataRenderer.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MatchHistoryDataRenderer>.NativeClassPtr, "<>c__DisplayClass5_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MatchHistoryDataRenderer.__c__DisplayClass5_0>.NativeClassPtr);
				MatchHistoryDataRenderer.__c__DisplayClass5_0.NativeFieldInfoPtr_localAccount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchHistoryDataRenderer.__c__DisplayClass5_0>.NativeClassPtr, "localAccount");
				MatchHistoryDataRenderer.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchHistoryDataRenderer.__c__DisplayClass5_0>.NativeClassPtr, 100664447);
				MatchHistoryDataRenderer.__c__DisplayClass5_0.NativeMethodInfoPtr__modelChanged_b__0_Internal_Boolean_MatchHistoryResultDetail_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchHistoryDataRenderer.__c__DisplayClass5_0>.NativeClassPtr, 100664448);
				MatchHistoryDataRenderer.__c__DisplayClass5_0.NativeMethodInfoPtr__modelChanged_b__1_Internal_Boolean_MatchHistoryResultDetail_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchHistoryDataRenderer.__c__DisplayClass5_0>.NativeClassPtr, 100664449);
			}

			// Token: 0x060025C3 RID: 9667 RVA: 0x00099698 File Offset: 0x00097898
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MatchHistoryDataRenderer.__c__DisplayClass5_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchHistoryDataRenderer.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060025C4 RID: 9668 RVA: 0x000996D4 File Offset: 0x000978D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504389, XrefRangeEnd = 504394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _modelChanged_b__0(MatchHistoryResultDetail p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchHistoryDataRenderer.__c__DisplayClass5_0.NativeMethodInfoPtr__modelChanged_b__0_Internal_Boolean_MatchHistoryResultDetail_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060025C5 RID: 9669 RVA: 0x00099724 File Offset: 0x00097924
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504394, XrefRangeEnd = 504399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _modelChanged_b__1(MatchHistoryResultDetail p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchHistoryDataRenderer.__c__DisplayClass5_0.NativeMethodInfoPtr__modelChanged_b__1_Internal_Boolean_MatchHistoryResultDetail_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060025C6 RID: 9670 RVA: 0x000139CB File Offset: 0x00011BCB
			public __c__DisplayClass5_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A6A RID: 2666
			// (get) Token: 0x060025C7 RID: 9671 RVA: 0x00099774 File Offset: 0x00097974
			// (set) Token: 0x060025C8 RID: 9672 RVA: 0x000139D4 File Offset: 0x00011BD4
			public unsafe AccountID localAccount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchHistoryDataRenderer.__c__DisplayClass5_0.NativeFieldInfoPtr_localAccount);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchHistoryDataRenderer.__c__DisplayClass5_0.NativeFieldInfoPtr_localAccount), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040017AF RID: 6063
			private static readonly IntPtr NativeFieldInfoPtr_localAccount;

			// Token: 0x040017B0 RID: 6064
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040017B1 RID: 6065
			private static readonly IntPtr NativeMethodInfoPtr__modelChanged_b__0_Internal_Boolean_MatchHistoryResultDetail_0;

			// Token: 0x040017B2 RID: 6066
			private static readonly IntPtr NativeMethodInfoPtr__modelChanged_b__1_Internal_Boolean_MatchHistoryResultDetail_0;
		}
	}
}
