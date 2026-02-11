using System;
using canis.Networking.game.messages;
using Canis.utils.ids;
using dbgclient.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using TMPro;

namespace dbgclient.dataRenderers
{
	// Token: 0x020000BB RID: 187
	public class MatchHistoryStatDataRenderer : Subscriber<MatchHistoryData>
	{
		// Token: 0x060007A9 RID: 1961 RVA: 0x000358AC File Offset: 0x00033AAC
		// Note: this type is marked as 'beforefieldinit'.
		static MatchHistoryStatDataRenderer()
		{
			Il2CppClassPointerStore<MatchHistoryStatDataRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.dataRenderers", "MatchHistoryStatDataRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MatchHistoryStatDataRenderer>.NativeClassPtr);
			MatchHistoryStatDataRenderer.NativeFieldInfoPtr_statKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchHistoryStatDataRenderer>.NativeClassPtr, "statKey");
			MatchHistoryStatDataRenderer.NativeFieldInfoPtr_statText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchHistoryStatDataRenderer>.NativeClassPtr, "statText");
			MatchHistoryStatDataRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchHistoryStatDataRenderer>.NativeClassPtr, 100664450);
			MatchHistoryStatDataRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchHistoryStatDataRenderer>.NativeClassPtr, 100664451);
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x0003592C File Offset: 0x00033B2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504488, XrefRangeEnd = 504508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void modelChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MatchHistoryStatDataRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x00035968 File Offset: 0x00033B68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504508, XrefRangeEnd = 504514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MatchHistoryStatDataRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MatchHistoryStatDataRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchHistoryStatDataRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x00005917 File Offset: 0x00003B17
		public MatchHistoryStatDataRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x060007AD RID: 1965 RVA: 0x000359A4 File Offset: 0x00033BA4
		// (set) Token: 0x060007AE RID: 1966 RVA: 0x00005920 File Offset: 0x00003B20
		public unsafe string statKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchHistoryStatDataRenderer.NativeFieldInfoPtr_statKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchHistoryStatDataRenderer.NativeFieldInfoPtr_statKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x060007AF RID: 1967 RVA: 0x000359CC File Offset: 0x00033BCC
		// (set) Token: 0x060007B0 RID: 1968 RVA: 0x0000593F File Offset: 0x00003B3F
		public unsafe TMP_Text statText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchHistoryStatDataRenderer.NativeFieldInfoPtr_statText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchHistoryStatDataRenderer.NativeFieldInfoPtr_statText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040004AD RID: 1197
		private static readonly IntPtr NativeFieldInfoPtr_statKey;

		// Token: 0x040004AE RID: 1198
		private static readonly IntPtr NativeFieldInfoPtr_statText;

		// Token: 0x040004AF RID: 1199
		private static readonly IntPtr NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0;

		// Token: 0x040004B0 RID: 1200
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000321 RID: 801
		[ObfuscatedName("dbgclient.dataRenderers.MatchHistoryStatDataRenderer+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Object
		{
			// Token: 0x060025C9 RID: 9673 RVA: 0x000997A4 File Offset: 0x000979A4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<MatchHistoryStatDataRenderer.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MatchHistoryStatDataRenderer>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MatchHistoryStatDataRenderer.__c__DisplayClass2_0>.NativeClassPtr);
				MatchHistoryStatDataRenderer.__c__DisplayClass2_0.NativeFieldInfoPtr_localAccount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchHistoryStatDataRenderer.__c__DisplayClass2_0>.NativeClassPtr, "localAccount");
				MatchHistoryStatDataRenderer.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchHistoryStatDataRenderer.__c__DisplayClass2_0>.NativeClassPtr, 100664452);
				MatchHistoryStatDataRenderer.__c__DisplayClass2_0.NativeMethodInfoPtr__modelChanged_b__0_Internal_Boolean_MatchHistoryResultDetail_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchHistoryStatDataRenderer.__c__DisplayClass2_0>.NativeClassPtr, 100664453);
			}

			// Token: 0x060025CA RID: 9674 RVA: 0x0009980C File Offset: 0x00097A0C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MatchHistoryStatDataRenderer.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchHistoryStatDataRenderer.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060025CB RID: 9675 RVA: 0x00099848 File Offset: 0x00097A48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504483, XrefRangeEnd = 504488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _modelChanged_b__0(MatchHistoryResultDetail p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchHistoryStatDataRenderer.__c__DisplayClass2_0.NativeMethodInfoPtr__modelChanged_b__0_Internal_Boolean_MatchHistoryResultDetail_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060025CC RID: 9676 RVA: 0x000139F3 File Offset: 0x00011BF3
			public __c__DisplayClass2_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A6B RID: 2667
			// (get) Token: 0x060025CD RID: 9677 RVA: 0x00099898 File Offset: 0x00097A98
			// (set) Token: 0x060025CE RID: 9678 RVA: 0x000139FC File Offset: 0x00011BFC
			public unsafe AccountID localAccount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchHistoryStatDataRenderer.__c__DisplayClass2_0.NativeFieldInfoPtr_localAccount);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchHistoryStatDataRenderer.__c__DisplayClass2_0.NativeFieldInfoPtr_localAccount), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040017B3 RID: 6067
			private static readonly IntPtr NativeFieldInfoPtr_localAccount;

			// Token: 0x040017B4 RID: 6068
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040017B5 RID: 6069
			private static readonly IntPtr NativeMethodInfoPtr__modelChanged_b__0_Internal_Boolean_MatchHistoryResultDetail_0;
		}
	}
}
