using System;
using Canis.entities;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis.obfuscation
{
	// Token: 0x02000066 RID: 102
	[Serializable]
	public class Visibility : Object
	{
		// Token: 0x060005A4 RID: 1444 RVA: 0x0002F7D4 File Offset: 0x0002D9D4
		// Note: this type is marked as 'beforefieldinit'.
		static Visibility()
		{
			Il2CppClassPointerStore<Visibility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.obfuscation", "Visibility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Visibility>.NativeClassPtr);
			Visibility.NativeFieldInfoPtr_DefaultHidden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Visibility>.NativeClassPtr, "DefaultHidden");
			Visibility.NativeFieldInfoPtr_OtherHidden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Visibility>.NativeClassPtr, "OtherHidden");
			Visibility.NativeFieldInfoPtr_Public = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Visibility>.NativeClassPtr, "Public");
			Visibility.NativeFieldInfoPtr_DeckStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Visibility>.NativeClassPtr, "DeckStyle");
			Visibility.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Visibility>.NativeClassPtr, 100664460);
			Visibility.NativeMethodInfoPtr_WithOtherVisibility_Public_Visibility_AccountID_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Visibility>.NativeClassPtr, 100664461);
			Visibility.NativeMethodInfoPtr_HiddenToPlayer_Public_Boolean_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Visibility>.NativeClassPtr, 100664462);
			Visibility.NativeMethodInfoPtr_HandStyle_Public_Static_Visibility_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Visibility>.NativeClassPtr, 100664463);
			Visibility.NativeMethodInfoPtr_EntityIsHidden_Public_Static_Boolean_Entity_AccountID_IEnumerable_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Visibility>.NativeClassPtr, 100664464);
			Visibility.NativeMethodInfoPtr_EntityChildrenHidden_Public_Static_Boolean_Entity_AccountID_IEnumerable_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Visibility>.NativeClassPtr, 100664465);
			Visibility.NativeMethodInfoPtr_NumChildrenHidden_Public_Static_Int32_Entity_AccountID_IEnumerable_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Visibility>.NativeClassPtr, 100664466);
			Visibility.NativeMethodInfoPtr_UsesNumChildren_Public_Static_Boolean_Entity_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Visibility>.NativeClassPtr, 100664467);
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x0002F8F4 File Offset: 0x0002DAF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 554987, XrefRangeEnd = 554988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Visibility(bool hidden)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Visibility>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hidden;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Visibility.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x0002F93C File Offset: 0x0002DB3C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 554998, RefRangeEnd = 555000, XrefRangeStart = 554988, XrefRangeEnd = 554998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Visibility WithOtherVisibility(AccountID accountID, bool hidden)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(accountID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hidden;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Visibility.NativeMethodInfoPtr_WithOtherVisibility_Public_Visibility_AccountID_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Visibility>(intPtr3) : null;
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x0002F99C File Offset: 0x0002DB9C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 555003, RefRangeEnd = 555005, XrefRangeStart = 555000, XrefRangeEnd = 555003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HiddenToPlayer(AccountID accountID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(accountID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Visibility.NativeMethodInfoPtr_HiddenToPlayer_Public_Boolean_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x0002F9EC File Offset: 0x0002DBEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 555010, RefRangeEnd = 555011, XrefRangeStart = 555005, XrefRangeEnd = 555010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Visibility HandStyle(AccountID accountID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(accountID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Visibility.NativeMethodInfoPtr_HandStyle_Public_Static_Visibility_AccountID_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Visibility>(intPtr3) : null;
			}
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x0002FA30 File Offset: 0x0002DC30
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 555029, RefRangeEnd = 555039, XrefRangeStart = 555011, XrefRangeEnd = 555029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool EntityIsHidden(Entity entity, AccountID perspective, IEnumerable<Entity> altAncestorChain = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(perspective);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(altAncestorChain);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Visibility.NativeMethodInfoPtr_EntityIsHidden_Public_Static_Boolean_Entity_AccountID_IEnumerable_1_Entity_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x0002FA98 File Offset: 0x0002DC98
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 555075, RefRangeEnd = 555077, XrefRangeStart = 555039, XrefRangeEnd = 555075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool EntityChildrenHidden(Entity entity, AccountID perspective, IEnumerable<Entity> altAncestorChain = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(perspective);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(altAncestorChain);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Visibility.NativeMethodInfoPtr_EntityChildrenHidden_Public_Static_Boolean_Entity_AccountID_IEnumerable_1_Entity_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x0002FB00 File Offset: 0x0002DD00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 555113, RefRangeEnd = 555114, XrefRangeStart = 555077, XrefRangeEnd = 555113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int NumChildrenHidden(Entity entity, AccountID perspective, IEnumerable<Entity> altAncestorChain = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(perspective);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(altAncestorChain);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Visibility.NativeMethodInfoPtr_NumChildrenHidden_Public_Static_Int32_Entity_AccountID_IEnumerable_1_Entity_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x0002FB68 File Offset: 0x0002DD68
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 555121, RefRangeEnd = 555126, XrefRangeStart = 555114, XrefRangeEnd = 555121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool UsesNumChildren(Entity entity, AccountID perspective)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(perspective);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Visibility.NativeMethodInfoPtr_UsesNumChildren_Public_Static_Boolean_Entity_AccountID_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x000046E7 File Offset: 0x000028E7
		public Visibility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x060005AE RID: 1454 RVA: 0x0002FBBC File Offset: 0x0002DDBC
		// (set) Token: 0x060005AF RID: 1455 RVA: 0x000046F0 File Offset: 0x000028F0
		public unsafe bool DefaultHidden
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Visibility.NativeFieldInfoPtr_DefaultHidden);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Visibility.NativeFieldInfoPtr_DefaultHidden)) = value;
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x060005B0 RID: 1456 RVA: 0x0002FBE4 File Offset: 0x0002DDE4
		// (set) Token: 0x060005B1 RID: 1457 RVA: 0x0000470B File Offset: 0x0000290B
		public unsafe Dictionary<AccountID, bool> OtherHidden
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Visibility.NativeFieldInfoPtr_OtherHidden);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<AccountID, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Visibility.NativeFieldInfoPtr_OtherHidden), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x060005B2 RID: 1458 RVA: 0x0002FC14 File Offset: 0x0002DE14
		// (set) Token: 0x060005B3 RID: 1459 RVA: 0x0000472A File Offset: 0x0000292A
		public unsafe static Visibility Public
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Visibility.NativeFieldInfoPtr_Public, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Visibility>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Visibility.NativeFieldInfoPtr_Public, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x060005B4 RID: 1460 RVA: 0x0002FC3C File Offset: 0x0002DE3C
		// (set) Token: 0x060005B5 RID: 1461 RVA: 0x0000473C File Offset: 0x0000293C
		public unsafe static Visibility DeckStyle
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Visibility.NativeFieldInfoPtr_DeckStyle, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Visibility>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Visibility.NativeFieldInfoPtr_DeckStyle, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000395 RID: 917
		private static readonly IntPtr NativeFieldInfoPtr_DefaultHidden;

		// Token: 0x04000396 RID: 918
		private static readonly IntPtr NativeFieldInfoPtr_OtherHidden;

		// Token: 0x04000397 RID: 919
		private static readonly IntPtr NativeFieldInfoPtr_Public;

		// Token: 0x04000398 RID: 920
		private static readonly IntPtr NativeFieldInfoPtr_DeckStyle;

		// Token: 0x04000399 RID: 921
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x0400039A RID: 922
		private static readonly IntPtr NativeMethodInfoPtr_WithOtherVisibility_Public_Visibility_AccountID_Boolean_0;

		// Token: 0x0400039B RID: 923
		private static readonly IntPtr NativeMethodInfoPtr_HiddenToPlayer_Public_Boolean_AccountID_0;

		// Token: 0x0400039C RID: 924
		private static readonly IntPtr NativeMethodInfoPtr_HandStyle_Public_Static_Visibility_AccountID_0;

		// Token: 0x0400039D RID: 925
		private static readonly IntPtr NativeMethodInfoPtr_EntityIsHidden_Public_Static_Boolean_Entity_AccountID_IEnumerable_1_Entity_0;

		// Token: 0x0400039E RID: 926
		private static readonly IntPtr NativeMethodInfoPtr_EntityChildrenHidden_Public_Static_Boolean_Entity_AccountID_IEnumerable_1_Entity_0;

		// Token: 0x0400039F RID: 927
		private static readonly IntPtr NativeMethodInfoPtr_NumChildrenHidden_Public_Static_Int32_Entity_AccountID_IEnumerable_1_Entity_0;

		// Token: 0x040003A0 RID: 928
		private static readonly IntPtr NativeMethodInfoPtr_UsesNumChildren_Public_Static_Boolean_Entity_AccountID_0;
	}
}
