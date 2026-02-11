using System;
using Canis.attributes;
using Canis.messages;
using Canis.utils.ids;
using Canis.utils.localization;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Networking.selection.messages
{
	// Token: 0x02000082 RID: 130
	public class SelectionMessage : GameMessage
	{
		// Token: 0x06000454 RID: 1108 RVA: 0x00011728 File Offset: 0x0000F928
		// Note: this type is marked as 'beforefieldinit'.
		static SelectionMessage()
		{
			Il2CppClassPointerStore<SelectionMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.selection.messages", "SelectionMessage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectionMessage>.NativeClassPtr);
			SelectionMessage.NativeFieldInfoPtr__PlayerAccountID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionMessage>.NativeClassPtr, "<PlayerAccountID>k__BackingField");
			SelectionMessage.NativeFieldInfoPtr_Counter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionMessage>.NativeClassPtr, "Counter");
			SelectionMessage.NativeFieldInfoPtr_Prompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionMessage>.NativeClassPtr, "Prompt");
			SelectionMessage.NativeFieldInfoPtr_OfferLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionMessage>.NativeClassPtr, "OfferLength");
			SelectionMessage.NativeFieldInfoPtr_Attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionMessage>.NativeClassPtr, "Attributes");
			SelectionMessage.NativeMethodInfoPtr_get_PlayerAccountID_Public_Virtual_Final_New_get_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionMessage>.NativeClassPtr, 100663575);
			SelectionMessage.NativeMethodInfoPtr_set_PlayerAccountID_Public_Virtual_Final_New_set_Void_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionMessage>.NativeClassPtr, 100663576);
			SelectionMessage.NativeMethodInfoPtr_GetCounter_Public_Virtual_Final_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionMessage>.NativeClassPtr, 100663577);
			SelectionMessage.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionMessage>.NativeClassPtr, 100663578);
			SelectionMessage.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionMessage>.NativeClassPtr, 100663579);
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x06000455 RID: 1109 RVA: 0x00011820 File Offset: 0x0000FA20
		// (set) Token: 0x06000456 RID: 1110 RVA: 0x00011860 File Offset: 0x0000FA60
		public unsafe virtual AccountID PlayerAccountID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionMessage.NativeMethodInfoPtr_get_PlayerAccountID_Public_Virtual_Final_New_get_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionMessage.NativeMethodInfoPtr_set_PlayerAccountID_Public_Virtual_Final_New_set_Void_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x000118A4 File Offset: 0x0000FAA4
		[CallerCount(0)]
		public unsafe virtual int GetCounter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionMessage.NativeMethodInfoPtr_GetCounter_Public_Virtual_Final_New_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x000118E0 File Offset: 0x0000FAE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194542, XrefRangeEnd = 1194551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectionMessage.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x00011924 File Offset: 0x0000FB24
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectionMessage()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectionMessage>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionMessage.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x00004AD7 File Offset: 0x00002CD7
		public SelectionMessage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x0600045B RID: 1115 RVA: 0x00011960 File Offset: 0x0000FB60
		// (set) Token: 0x0600045C RID: 1116 RVA: 0x00004AE0 File Offset: 0x00002CE0
		public unsafe AccountID _PlayerAccountID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionMessage.NativeFieldInfoPtr__PlayerAccountID_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionMessage.NativeFieldInfoPtr__PlayerAccountID_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x0600045D RID: 1117 RVA: 0x00011990 File Offset: 0x0000FB90
		// (set) Token: 0x0600045E RID: 1118 RVA: 0x00004AFF File Offset: 0x00002CFF
		public unsafe int Counter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionMessage.NativeFieldInfoPtr_Counter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionMessage.NativeFieldInfoPtr_Counter)) = value;
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x0600045F RID: 1119 RVA: 0x000119B8 File Offset: 0x0000FBB8
		// (set) Token: 0x06000460 RID: 1120 RVA: 0x00004B1A File Offset: 0x00002D1A
		public unsafe LocalizableTextVariables Prompt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionMessage.NativeFieldInfoPtr_Prompt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizableTextVariables>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionMessage.NativeFieldInfoPtr_Prompt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x06000461 RID: 1121 RVA: 0x000119E8 File Offset: 0x0000FBE8
		// (set) Token: 0x06000462 RID: 1122 RVA: 0x00004B39 File Offset: 0x00002D39
		public unsafe long OfferLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionMessage.NativeFieldInfoPtr_OfferLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionMessage.NativeFieldInfoPtr_OfferLength)) = value;
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x06000463 RID: 1123 RVA: 0x00011A10 File Offset: 0x0000FC10
		// (set) Token: 0x06000464 RID: 1124 RVA: 0x00004B54 File Offset: 0x00002D54
		public unsafe ReadOnlyAttributes Attributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionMessage.NativeFieldInfoPtr_Attributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttributes>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionMessage.NativeFieldInfoPtr_Attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400025A RID: 602
		private static readonly IntPtr NativeFieldInfoPtr__PlayerAccountID_k__BackingField;

		// Token: 0x0400025B RID: 603
		private static readonly IntPtr NativeFieldInfoPtr_Counter;

		// Token: 0x0400025C RID: 604
		private static readonly IntPtr NativeFieldInfoPtr_Prompt;

		// Token: 0x0400025D RID: 605
		private static readonly IntPtr NativeFieldInfoPtr_OfferLength;

		// Token: 0x0400025E RID: 606
		private static readonly IntPtr NativeFieldInfoPtr_Attributes;

		// Token: 0x0400025F RID: 607
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayerAccountID_Public_Virtual_Final_New_get_AccountID_0;

		// Token: 0x04000260 RID: 608
		private static readonly IntPtr NativeMethodInfoPtr_set_PlayerAccountID_Public_Virtual_Final_New_set_Void_AccountID_0;

		// Token: 0x04000261 RID: 609
		private static readonly IntPtr NativeMethodInfoPtr_GetCounter_Public_Virtual_Final_New_Int32_0;

		// Token: 0x04000262 RID: 610
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000263 RID: 611
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
