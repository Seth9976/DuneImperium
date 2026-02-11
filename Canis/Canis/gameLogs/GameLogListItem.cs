using System;
using Canis.utils.localization;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis.gameLogs
{
	// Token: 0x020000A1 RID: 161
	public class GameLogListItem : Object
	{
		// Token: 0x060007D4 RID: 2004 RVA: 0x00039154 File Offset: 0x00037354
		// Note: this type is marked as 'beforefieldinit'.
		static GameLogListItem()
		{
			Il2CppClassPointerStore<GameLogListItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.gameLogs", "GameLogListItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameLogListItem>.NativeClassPtr);
			GameLogListItem.NativeFieldInfoPtr_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameLogListItem>.NativeClassPtr, "Text");
			GameLogListItem.NativeFieldInfoPtr_Order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameLogListItem>.NativeClassPtr, "Order");
			GameLogListItem.NativeMethodInfoPtr_Combine_Public_Boolean_GameLogListItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLogListItem>.NativeClassPtr, 100664886);
			GameLogListItem.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLogListItem>.NativeClassPtr, 100664887);
			GameLogListItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLogListItem>.NativeClassPtr, 100664888);
		}

		// Token: 0x060007D5 RID: 2005 RVA: 0x000391E8 File Offset: 0x000373E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 558649, RefRangeEnd = 558650, XrefRangeStart = 558536, XrefRangeEnd = 558649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Combine(GameLogListItem other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameLogListItem.NativeMethodInfoPtr_Combine_Public_Boolean_GameLogListItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007D6 RID: 2006 RVA: 0x00039238 File Offset: 0x00037438
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 558651, RefRangeEnd = 558652, XrefRangeStart = 558650, XrefRangeEnd = 558651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameLogListItem.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060007D7 RID: 2007 RVA: 0x0003927C File Offset: 0x0003747C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameLogListItem()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameLogListItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameLogListItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x000050EE File Offset: 0x000032EE
		public GameLogListItem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x060007D9 RID: 2009 RVA: 0x000392B8 File Offset: 0x000374B8
		// (set) Token: 0x060007DA RID: 2010 RVA: 0x000050F7 File Offset: 0x000032F7
		public unsafe LocalizableTextVariables Text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameLogListItem.NativeFieldInfoPtr_Text);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizableTextVariables>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameLogListItem.NativeFieldInfoPtr_Text), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x060007DB RID: 2011 RVA: 0x000392E8 File Offset: 0x000374E8
		// (set) Token: 0x060007DC RID: 2012 RVA: 0x00005116 File Offset: 0x00003316
		public unsafe int Order
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameLogListItem.NativeFieldInfoPtr_Order);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameLogListItem.NativeFieldInfoPtr_Order)) = value;
			}
		}

		// Token: 0x04000562 RID: 1378
		private static readonly IntPtr NativeFieldInfoPtr_Text;

		// Token: 0x04000563 RID: 1379
		private static readonly IntPtr NativeFieldInfoPtr_Order;

		// Token: 0x04000564 RID: 1380
		private static readonly IntPtr NativeMethodInfoPtr_Combine_Public_Boolean_GameLogListItem_0;

		// Token: 0x04000565 RID: 1381
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000566 RID: 1382
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002E1 RID: 737
		[ObfuscatedName("Canis.gameLogs.GameLogListItem+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Object
		{
			// Token: 0x06001EC6 RID: 7878 RVA: 0x0008E7E4 File Offset: 0x0008C9E4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<GameLogListItem.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameLogListItem>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameLogListItem.__c__DisplayClass2_0>.NativeClassPtr);
				GameLogListItem.__c__DisplayClass2_0.NativeFieldInfoPtr_other = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameLogListItem.__c__DisplayClass2_0>.NativeClassPtr, "other");
				GameLogListItem.__c__DisplayClass2_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameLogListItem.__c__DisplayClass2_0>.NativeClassPtr, "<>4__this");
				GameLogListItem.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLogListItem.__c__DisplayClass2_0>.NativeClassPtr, 100664889);
				GameLogListItem.__c__DisplayClass2_0.NativeMethodInfoPtr__Combine_b__0_Internal_Boolean_KeyValuePair_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLogListItem.__c__DisplayClass2_0>.NativeClassPtr, 100664890);
				GameLogListItem.__c__DisplayClass2_0.NativeMethodInfoPtr__Combine_b__1_Internal_Boolean_KeyValuePair_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLogListItem.__c__DisplayClass2_0>.NativeClassPtr, 100664891);
			}

			// Token: 0x06001EC7 RID: 7879 RVA: 0x0008E874 File Offset: 0x0008CA74
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameLogListItem.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameLogListItem.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001EC8 RID: 7880 RVA: 0x0008E8B0 File Offset: 0x0008CAB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 558526, XrefRangeEnd = 558531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Combine_b__0(KeyValuePair<string, string> pair)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(pair));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameLogListItem.__c__DisplayClass2_0.NativeMethodInfoPtr__Combine_b__0_Internal_Boolean_KeyValuePair_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001EC9 RID: 7881 RVA: 0x0008E904 File Offset: 0x0008CB04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 558531, XrefRangeEnd = 558536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Combine_b__1(KeyValuePair<string, string> pair)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(pair));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameLogListItem.__c__DisplayClass2_0.NativeMethodInfoPtr__Combine_b__1_Internal_Boolean_KeyValuePair_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001ECA RID: 7882 RVA: 0x0000ECDE File Offset: 0x0000CEDE
			public __c__DisplayClass2_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000734 RID: 1844
			// (get) Token: 0x06001ECB RID: 7883 RVA: 0x0008E958 File Offset: 0x0008CB58
			// (set) Token: 0x06001ECC RID: 7884 RVA: 0x0000ECE7 File Offset: 0x0000CEE7
			public unsafe GameLogListItem other
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameLogListItem.__c__DisplayClass2_0.NativeFieldInfoPtr_other);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameLogListItem>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameLogListItem.__c__DisplayClass2_0.NativeFieldInfoPtr_other), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000735 RID: 1845
			// (get) Token: 0x06001ECD RID: 7885 RVA: 0x0008E988 File Offset: 0x0008CB88
			// (set) Token: 0x06001ECE RID: 7886 RVA: 0x0000ED06 File Offset: 0x0000CF06
			public unsafe GameLogListItem __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameLogListItem.__c__DisplayClass2_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameLogListItem>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameLogListItem.__c__DisplayClass2_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001371 RID: 4977
			private static readonly IntPtr NativeFieldInfoPtr_other;

			// Token: 0x04001372 RID: 4978
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001373 RID: 4979
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001374 RID: 4980
			private static readonly IntPtr NativeMethodInfoPtr__Combine_b__0_Internal_Boolean_KeyValuePair_2_String_String_0;

			// Token: 0x04001375 RID: 4981
			private static readonly IntPtr NativeMethodInfoPtr__Combine_b__1_Internal_Boolean_KeyValuePair_2_String_String_0;
		}
	}
}
