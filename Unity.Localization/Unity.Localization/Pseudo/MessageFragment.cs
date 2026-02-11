using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Text;

namespace UnityEngine.Localization.Pseudo
{
	// Token: 0x020000A2 RID: 162
	public class MessageFragment : Object
	{
		// Token: 0x060007FE RID: 2046 RVA: 0x00028174 File Offset: 0x00026374
		// Note: this type is marked as 'beforefieldinit'.
		static MessageFragment()
		{
			Il2CppClassPointerStore<MessageFragment>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Pseudo", "MessageFragment");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessageFragment>.NativeClassPtr);
			MessageFragment.NativeFieldInfoPtr_m_OriginalString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageFragment>.NativeClassPtr, "m_OriginalString");
			MessageFragment.NativeFieldInfoPtr_m_StartIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageFragment>.NativeClassPtr, "m_StartIndex");
			MessageFragment.NativeFieldInfoPtr_m_EndIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageFragment>.NativeClassPtr, "m_EndIndex");
			MessageFragment.NativeFieldInfoPtr_m_CachedToString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageFragment>.NativeClassPtr, "m_CachedToString");
			MessageFragment.NativeFieldInfoPtr__Message_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageFragment>.NativeClassPtr, "<Message>k__BackingField");
			MessageFragment.NativeMethodInfoPtr_get_Length_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageFragment>.NativeClassPtr, 100664721);
			MessageFragment.NativeMethodInfoPtr_get_Message_Public_get_Message_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageFragment>.NativeClassPtr, 100664722);
			MessageFragment.NativeMethodInfoPtr_set_Message_Private_set_Void_Message_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageFragment>.NativeClassPtr, 100664723);
			MessageFragment.NativeMethodInfoPtr_Initialize_Internal_Void_Message_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageFragment>.NativeClassPtr, 100664724);
			MessageFragment.NativeMethodInfoPtr_Initialize_Internal_Void_Message_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageFragment>.NativeClassPtr, 100664725);
			MessageFragment.NativeMethodInfoPtr_CreateTextFragment_Public_WritableMessageFragment_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageFragment>.NativeClassPtr, 100664726);
			MessageFragment.NativeMethodInfoPtr_CreateReadonlyTextFragment_Public_ReadOnlyMessageFragment_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageFragment>.NativeClassPtr, 100664727);
			MessageFragment.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageFragment>.NativeClassPtr, 100664728);
			MessageFragment.NativeMethodInfoPtr_BuildString_Internal_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageFragment>.NativeClassPtr, 100664729);
			MessageFragment.NativeMethodInfoPtr_get_Item_Public_get_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageFragment>.NativeClassPtr, 100664730);
			MessageFragment.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageFragment>.NativeClassPtr, 100664731);
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x060007FF RID: 2047 RVA: 0x000282E4 File Offset: 0x000264E4
		public unsafe int Length
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 1076003, RefRangeEnd = 1076011, XrefRangeStart = 1076003, XrefRangeEnd = 1076003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageFragment.NativeMethodInfoPtr_get_Length_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06000800 RID: 2048 RVA: 0x00028320 File Offset: 0x00026520
		// (set) Token: 0x06000801 RID: 2049 RVA: 0x00028360 File Offset: 0x00026560
		public unsafe Message Message
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageFragment.NativeMethodInfoPtr_get_Message_Public_get_Message_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Message>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageFragment.NativeMethodInfoPtr_set_Message_Private_set_Void_Message_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x000283A4 File Offset: 0x000265A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076011, XrefRangeEnd = 1076014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(Message parent, string original, int start, int end)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(original);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageFragment.NativeMethodInfoPtr_Initialize_Internal_Void_Message_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x00028414 File Offset: 0x00026614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076014, XrefRangeEnd = 1076017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(Message parent, string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageFragment.NativeMethodInfoPtr_Initialize_Internal_Void_Message_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000804 RID: 2052 RVA: 0x00028468 File Offset: 0x00026668
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1076027, RefRangeEnd = 1076029, XrefRangeStart = 1076017, XrefRangeEnd = 1076027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WritableMessageFragment CreateTextFragment(int start, int end)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageFragment.NativeMethodInfoPtr_CreateTextFragment_Public_WritableMessageFragment_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WritableMessageFragment>(intPtr3) : null;
		}

		// Token: 0x06000805 RID: 2053 RVA: 0x000284C4 File Offset: 0x000266C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1076039, RefRangeEnd = 1076040, XrefRangeStart = 1076029, XrefRangeEnd = 1076039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadOnlyMessageFragment CreateReadonlyTextFragment(int start, int end)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageFragment.NativeMethodInfoPtr_CreateReadonlyTextFragment_Public_ReadOnlyMessageFragment_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyMessageFragment>(intPtr3) : null;
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x00028520 File Offset: 0x00026720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076040, XrefRangeEnd = 1076042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MessageFragment.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000807 RID: 2055 RVA: 0x00028564 File Offset: 0x00026764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076042, XrefRangeEnd = 1076043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BuildString(StringBuilder builder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageFragment.NativeMethodInfoPtr_BuildString_Internal_Void_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000239 RID: 569
		public unsafe char this[int index]
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1076046, RefRangeEnd = 1076052, XrefRangeStart = 1076043, XrefRangeEnd = 1076046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageFragment.NativeMethodInfoPtr_get_Item_Public_get_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x000285F4 File Offset: 0x000267F4
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MessageFragment()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessageFragment>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageFragment.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600080A RID: 2058 RVA: 0x00005128 File Offset: 0x00003328
		public MessageFragment(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x0600080B RID: 2059 RVA: 0x00028630 File Offset: 0x00026830
		// (set) Token: 0x0600080C RID: 2060 RVA: 0x00005131 File Offset: 0x00003331
		public unsafe string m_OriginalString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageFragment.NativeFieldInfoPtr_m_OriginalString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageFragment.NativeFieldInfoPtr_m_OriginalString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x0600080D RID: 2061 RVA: 0x00028658 File Offset: 0x00026858
		// (set) Token: 0x0600080E RID: 2062 RVA: 0x00005150 File Offset: 0x00003350
		public unsafe int m_StartIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageFragment.NativeFieldInfoPtr_m_StartIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageFragment.NativeFieldInfoPtr_m_StartIndex)) = value;
			}
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x0600080F RID: 2063 RVA: 0x00028680 File Offset: 0x00026880
		// (set) Token: 0x06000810 RID: 2064 RVA: 0x0000516B File Offset: 0x0000336B
		public unsafe int m_EndIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageFragment.NativeFieldInfoPtr_m_EndIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageFragment.NativeFieldInfoPtr_m_EndIndex)) = value;
			}
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x06000811 RID: 2065 RVA: 0x000286A8 File Offset: 0x000268A8
		// (set) Token: 0x06000812 RID: 2066 RVA: 0x00005186 File Offset: 0x00003386
		public unsafe string m_CachedToString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageFragment.NativeFieldInfoPtr_m_CachedToString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageFragment.NativeFieldInfoPtr_m_CachedToString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x06000813 RID: 2067 RVA: 0x000286D0 File Offset: 0x000268D0
		// (set) Token: 0x06000814 RID: 2068 RVA: 0x000051A5 File Offset: 0x000033A5
		public unsafe Message _Message_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageFragment.NativeFieldInfoPtr__Message_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Message>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageFragment.NativeFieldInfoPtr__Message_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005BB RID: 1467
		private static readonly IntPtr NativeFieldInfoPtr_m_OriginalString;

		// Token: 0x040005BC RID: 1468
		private static readonly IntPtr NativeFieldInfoPtr_m_StartIndex;

		// Token: 0x040005BD RID: 1469
		private static readonly IntPtr NativeFieldInfoPtr_m_EndIndex;

		// Token: 0x040005BE RID: 1470
		private static readonly IntPtr NativeFieldInfoPtr_m_CachedToString;

		// Token: 0x040005BF RID: 1471
		private static readonly IntPtr NativeFieldInfoPtr__Message_k__BackingField;

		// Token: 0x040005C0 RID: 1472
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_get_Int32_0;

		// Token: 0x040005C1 RID: 1473
		private static readonly IntPtr NativeMethodInfoPtr_get_Message_Public_get_Message_0;

		// Token: 0x040005C2 RID: 1474
		private static readonly IntPtr NativeMethodInfoPtr_set_Message_Private_set_Void_Message_0;

		// Token: 0x040005C3 RID: 1475
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Internal_Void_Message_String_Int32_Int32_0;

		// Token: 0x040005C4 RID: 1476
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Internal_Void_Message_String_0;

		// Token: 0x040005C5 RID: 1477
		private static readonly IntPtr NativeMethodInfoPtr_CreateTextFragment_Public_WritableMessageFragment_Int32_Int32_0;

		// Token: 0x040005C6 RID: 1478
		private static readonly IntPtr NativeMethodInfoPtr_CreateReadonlyTextFragment_Public_ReadOnlyMessageFragment_Int32_Int32_0;

		// Token: 0x040005C7 RID: 1479
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040005C8 RID: 1480
		private static readonly IntPtr NativeMethodInfoPtr_BuildString_Internal_Void_StringBuilder_0;

		// Token: 0x040005C9 RID: 1481
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Char_Int32_0;

		// Token: 0x040005CA RID: 1482
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
