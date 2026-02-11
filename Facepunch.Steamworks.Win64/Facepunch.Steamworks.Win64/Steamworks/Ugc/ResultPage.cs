using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Steamworks.Data;

namespace Steamworks.Ugc
{
	// Token: 0x020000D5 RID: 213
	[StructLayout(2)]
	public struct ResultPage
	{
		// Token: 0x06000E54 RID: 3668 RVA: 0x00059C84 File Offset: 0x00057E84
		// Note: this type is marked as 'beforefieldinit'.
		static ResultPage()
		{
			Il2CppClassPointerStore<ResultPage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Ugc", "ResultPage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResultPage>.NativeClassPtr);
			ResultPage.NativeFieldInfoPtr_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultPage>.NativeClassPtr, "Handle");
			ResultPage.NativeFieldInfoPtr_ResultCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultPage>.NativeClassPtr, "ResultCount");
			ResultPage.NativeFieldInfoPtr_TotalCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultPage>.NativeClassPtr, "TotalCount");
			ResultPage.NativeFieldInfoPtr_CachedData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultPage>.NativeClassPtr, "CachedData");
			ResultPage.NativeFieldInfoPtr_ReturnsKeyValueTags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultPage>.NativeClassPtr, "ReturnsKeyValueTags");
			ResultPage.NativeFieldInfoPtr_ReturnsDefaultStats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultPage>.NativeClassPtr, "ReturnsDefaultStats");
			ResultPage.NativeFieldInfoPtr_ReturnsMetadata = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultPage>.NativeClassPtr, "ReturnsMetadata");
			ResultPage.NativeFieldInfoPtr_ReturnsChildren = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultPage>.NativeClassPtr, "ReturnsChildren");
			ResultPage.NativeFieldInfoPtr_ReturnsAdditionalPreviews = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultPage>.NativeClassPtr, "ReturnsAdditionalPreviews");
			ResultPage.NativeMethodInfoPtr_get_Entries_Public_get_IEnumerable_1_Item_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultPage>.NativeClassPtr, 100666674);
			ResultPage.NativeMethodInfoPtr_GetStat_Private_UInt64_UInt32_ItemStatistic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultPage>.NativeClassPtr, 100666675);
			ResultPage.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultPage>.NativeClassPtr, 100666676);
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x06000E55 RID: 3669 RVA: 0x00059DA4 File Offset: 0x00057FA4
		public unsafe IEnumerable<Item> Entries
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 949699, RefRangeEnd = 949700, XrefRangeStart = 949694, XrefRangeEnd = 949699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultPage.NativeMethodInfoPtr_get_Entries_Public_get_IEnumerable_1_Item_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Item>>(intPtr3) : null;
			}
		}

		// Token: 0x06000E56 RID: 3670 RVA: 0x00059DD8 File Offset: 0x00057FD8
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 949702, RefRangeEnd = 949715, XrefRangeStart = 949700, XrefRangeEnd = 949702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ulong GetStat(uint index, ItemStatistic stat)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultPage.NativeMethodInfoPtr_GetStat_Private_UInt64_UInt32_ItemStatistic_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E57 RID: 3671 RVA: 0x00059E24 File Offset: 0x00058024
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 949717, RefRangeEnd = 949718, XrefRangeStart = 949715, XrefRangeEnd = 949717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultPage.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E58 RID: 3672 RVA: 0x00003D45 File Offset: 0x00001F45
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ResultPage>.NativeClassPtr, ref this));
		}

		// Token: 0x0400146D RID: 5229
		private static readonly IntPtr NativeFieldInfoPtr_Handle;

		// Token: 0x0400146E RID: 5230
		private static readonly IntPtr NativeFieldInfoPtr_ResultCount;

		// Token: 0x0400146F RID: 5231
		private static readonly IntPtr NativeFieldInfoPtr_TotalCount;

		// Token: 0x04001470 RID: 5232
		private static readonly IntPtr NativeFieldInfoPtr_CachedData;

		// Token: 0x04001471 RID: 5233
		private static readonly IntPtr NativeFieldInfoPtr_ReturnsKeyValueTags;

		// Token: 0x04001472 RID: 5234
		private static readonly IntPtr NativeFieldInfoPtr_ReturnsDefaultStats;

		// Token: 0x04001473 RID: 5235
		private static readonly IntPtr NativeFieldInfoPtr_ReturnsMetadata;

		// Token: 0x04001474 RID: 5236
		private static readonly IntPtr NativeFieldInfoPtr_ReturnsChildren;

		// Token: 0x04001475 RID: 5237
		private static readonly IntPtr NativeFieldInfoPtr_ReturnsAdditionalPreviews;

		// Token: 0x04001476 RID: 5238
		private static readonly IntPtr NativeMethodInfoPtr_get_Entries_Public_get_IEnumerable_1_Item_0;

		// Token: 0x04001477 RID: 5239
		private static readonly IntPtr NativeMethodInfoPtr_GetStat_Private_UInt64_UInt32_ItemStatistic_0;

		// Token: 0x04001478 RID: 5240
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001479 RID: 5241
		[FieldOffset(0)]
		public UGCQueryHandle_t Handle;

		// Token: 0x0400147A RID: 5242
		[FieldOffset(8)]
		public int ResultCount;

		// Token: 0x0400147B RID: 5243
		[FieldOffset(12)]
		public int TotalCount;

		// Token: 0x0400147C RID: 5244
		[FieldOffset(16)]
		[MarshalAs(4)]
		public bool CachedData;

		// Token: 0x0400147D RID: 5245
		[FieldOffset(17)]
		[MarshalAs(4)]
		public bool ReturnsKeyValueTags;

		// Token: 0x0400147E RID: 5246
		[FieldOffset(18)]
		[MarshalAs(4)]
		public bool ReturnsDefaultStats;

		// Token: 0x0400147F RID: 5247
		[FieldOffset(19)]
		[MarshalAs(4)]
		public bool ReturnsMetadata;

		// Token: 0x04001480 RID: 5248
		[FieldOffset(20)]
		[MarshalAs(4)]
		public bool ReturnsChildren;

		// Token: 0x04001481 RID: 5249
		[FieldOffset(21)]
		[MarshalAs(4)]
		public bool ReturnsAdditionalPreviews;

		// Token: 0x02000298 RID: 664
		[ObfuscatedName("Steamworks.Ugc.ResultPage+<get_Entries>d__10")]
		public sealed class _get_Entries_d__10 : Object
		{
			// Token: 0x060021B5 RID: 8629 RVA: 0x00091E74 File Offset: 0x00090074
			// Note: this type is marked as 'beforefieldinit'.
			static _get_Entries_d__10()
			{
				Il2CppClassPointerStore<ResultPage._get_Entries_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResultPage>.NativeClassPtr, "<get_Entries>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResultPage._get_Entries_d__10>.NativeClassPtr);
				ResultPage._get_Entries_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultPage._get_Entries_d__10>.NativeClassPtr, "<>1__state");
				ResultPage._get_Entries_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultPage._get_Entries_d__10>.NativeClassPtr, "<>2__current");
				ResultPage._get_Entries_d__10.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultPage._get_Entries_d__10>.NativeClassPtr, "<>l__initialThreadId");
				ResultPage._get_Entries_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultPage._get_Entries_d__10>.NativeClassPtr, "<>4__this");
				ResultPage._get_Entries_d__10.NativeFieldInfoPtr___3____4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultPage._get_Entries_d__10>.NativeClassPtr, "<>3__<>4__this");
				ResultPage._get_Entries_d__10.NativeFieldInfoPtr__details_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultPage._get_Entries_d__10>.NativeClassPtr, "<details>5__2");
				ResultPage._get_Entries_d__10.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultPage._get_Entries_d__10>.NativeClassPtr, "<i>5__3");
				ResultPage._get_Entries_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultPage._get_Entries_d__10>.NativeClassPtr, 100666677);
				ResultPage._get_Entries_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultPage._get_Entries_d__10>.NativeClassPtr, 100666678);
				ResultPage._get_Entries_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultPage._get_Entries_d__10>.NativeClassPtr, 100666679);
				ResultPage._get_Entries_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Steamworks_Ugc_Item__get_Current_Private_Virtual_Final_New_get_Item_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultPage._get_Entries_d__10>.NativeClassPtr, 100666680);
				ResultPage._get_Entries_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultPage._get_Entries_d__10>.NativeClassPtr, 100666681);
				ResultPage._get_Entries_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultPage._get_Entries_d__10>.NativeClassPtr, 100666682);
				ResultPage._get_Entries_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Steamworks_Ugc_Item__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Item_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultPage._get_Entries_d__10>.NativeClassPtr, 100666683);
				ResultPage._get_Entries_d__10.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultPage._get_Entries_d__10>.NativeClassPtr, 100666684);
			}

			// Token: 0x060021B6 RID: 8630 RVA: 0x00091FCC File Offset: 0x000901CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949621, XrefRangeEnd = 949623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _get_Entries_d__10(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResultPage._get_Entries_d__10>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultPage._get_Entries_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060021B7 RID: 8631 RVA: 0x00092014 File Offset: 0x00090214
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultPage._get_Entries_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060021B8 RID: 8632 RVA: 0x00092048 File Offset: 0x00090248
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949623, XrefRangeEnd = 949679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultPage._get_Entries_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170008CA RID: 2250
			// (get) Token: 0x060021B9 RID: 8633 RVA: 0x00092084 File Offset: 0x00090284
			public unsafe Item System.Collections.Generic.IEnumerator<Steamworks.Ugc.Item>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultPage._get_Entries_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Steamworks_Ugc_Item__get_Current_Private_Virtual_Final_New_get_Item_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new Item(intPtr);
				}
			}

			// Token: 0x060021BA RID: 8634 RVA: 0x000920BC File Offset: 0x000902BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949679, XrefRangeEnd = 949684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultPage._get_Entries_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170008CB RID: 2251
			// (get) Token: 0x060021BB RID: 8635 RVA: 0x000920F0 File Offset: 0x000902F0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949684, XrefRangeEnd = 949687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultPage._get_Entries_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060021BC RID: 8636 RVA: 0x00092130 File Offset: 0x00090330
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949687, XrefRangeEnd = 949694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Item> System_Collections_Generic_IEnumerable_Steamworks_Ugc_Item__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultPage._get_Entries_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Steamworks_Ugc_Item__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Item_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Item>>(intPtr3) : null;
			}

			// Token: 0x060021BD RID: 8637 RVA: 0x00092170 File Offset: 0x00090370
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultPage._get_Entries_d__10.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060021BE RID: 8638 RVA: 0x0000D752 File Offset: 0x0000B952
			public _get_Entries_d__10(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008C3 RID: 2243
			// (get) Token: 0x060021BF RID: 8639 RVA: 0x000921B0 File Offset: 0x000903B0
			// (set) Token: 0x060021C0 RID: 8640 RVA: 0x0000D75B File Offset: 0x0000B95B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultPage._get_Entries_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultPage._get_Entries_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170008C4 RID: 2244
			// (get) Token: 0x060021C1 RID: 8641 RVA: 0x000921D8 File Offset: 0x000903D8
			// (set) Token: 0x060021C2 RID: 8642 RVA: 0x0000D776 File Offset: 0x0000B976
			public Item __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultPage._get_Entries_d__10.NativeFieldInfoPtr___2__current);
					return new Item(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Item>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultPage._get_Entries_d__10.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Item>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008C5 RID: 2245
			// (get) Token: 0x060021C3 RID: 8643 RVA: 0x00092208 File Offset: 0x00090408
			// (set) Token: 0x060021C4 RID: 8644 RVA: 0x0000D7A4 File Offset: 0x0000B9A4
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultPage._get_Entries_d__10.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultPage._get_Entries_d__10.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170008C6 RID: 2246
			// (get) Token: 0x060021C5 RID: 8645 RVA: 0x00092230 File Offset: 0x00090430
			// (set) Token: 0x060021C6 RID: 8646 RVA: 0x0000D7BF File Offset: 0x0000B9BF
			public unsafe ResultPage __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultPage._get_Entries_d__10.NativeFieldInfoPtr___4__this);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultPage._get_Entries_d__10.NativeFieldInfoPtr___4__this)) = value;
				}
			}

			// Token: 0x170008C7 RID: 2247
			// (get) Token: 0x060021C7 RID: 8647 RVA: 0x00092258 File Offset: 0x00090458
			// (set) Token: 0x060021C8 RID: 8648 RVA: 0x0000D7DA File Offset: 0x0000B9DA
			public unsafe ResultPage __3____4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultPage._get_Entries_d__10.NativeFieldInfoPtr___3____4__this);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultPage._get_Entries_d__10.NativeFieldInfoPtr___3____4__this)) = value;
				}
			}

			// Token: 0x170008C8 RID: 2248
			// (get) Token: 0x060021C9 RID: 8649 RVA: 0x00092280 File Offset: 0x00090480
			// (set) Token: 0x060021CA RID: 8650 RVA: 0x0000D7F5 File Offset: 0x0000B9F5
			public SteamUGCDetails_t _details_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultPage._get_Entries_d__10.NativeFieldInfoPtr__details_5__2);
					return new SteamUGCDetails_t(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultPage._get_Entries_d__10.NativeFieldInfoPtr__details_5__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008C9 RID: 2249
			// (get) Token: 0x060021CB RID: 8651 RVA: 0x000922B0 File Offset: 0x000904B0
			// (set) Token: 0x060021CC RID: 8652 RVA: 0x0000D823 File Offset: 0x0000BA23
			public unsafe uint _i_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultPage._get_Entries_d__10.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultPage._get_Entries_d__10.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x04002367 RID: 9063
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002368 RID: 9064
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04002369 RID: 9065
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400236A RID: 9066
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400236B RID: 9067
			private static readonly IntPtr NativeFieldInfoPtr___3____4__this;

			// Token: 0x0400236C RID: 9068
			private static readonly IntPtr NativeFieldInfoPtr__details_5__2;

			// Token: 0x0400236D RID: 9069
			private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x0400236E RID: 9070
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400236F RID: 9071
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002370 RID: 9072
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04002371 RID: 9073
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Steamworks_Ugc_Item__get_Current_Private_Virtual_Final_New_get_Item_0;

			// Token: 0x04002372 RID: 9074
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002373 RID: 9075
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002374 RID: 9076
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Steamworks_Ugc_Item__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Item_0;

			// Token: 0x04002375 RID: 9077
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
