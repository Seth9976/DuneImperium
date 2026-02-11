using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Pool;

namespace UnityEngine.Localization.Pseudo
{
	// Token: 0x020000A5 RID: 165
	public class Message : Object
	{
		// Token: 0x06000822 RID: 2082 RVA: 0x00028968 File Offset: 0x00026B68
		// Note: this type is marked as 'beforefieldinit'.
		static Message()
		{
			Il2CppClassPointerStore<Message>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Pseudo", "Message");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Message>.NativeClassPtr);
			Message.NativeFieldInfoPtr_Pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Message>.NativeClassPtr, "Pool");
			Message.NativeFieldInfoPtr__Original_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Message>.NativeClassPtr, "<Original>k__BackingField");
			Message.NativeFieldInfoPtr__Fragments_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Message>.NativeClassPtr, "<Fragments>k__BackingField");
			Message.NativeMethodInfoPtr_get_Original_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Message>.NativeClassPtr, 100664745);
			Message.NativeMethodInfoPtr_set_Original_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Message>.NativeClassPtr, 100664746);
			Message.NativeMethodInfoPtr_get_Fragments_Public_get_List_1_MessageFragment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Message>.NativeClassPtr, 100664747);
			Message.NativeMethodInfoPtr_set_Fragments_Private_set_Void_List_1_MessageFragment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Message>.NativeClassPtr, 100664748);
			Message.NativeMethodInfoPtr_get_Length_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Message>.NativeClassPtr, 100664749);
			Message.NativeMethodInfoPtr_CreateTextFragment_Public_WritableMessageFragment_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Message>.NativeClassPtr, 100664750);
			Message.NativeMethodInfoPtr_CreateTextFragment_Public_WritableMessageFragment_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Message>.NativeClassPtr, 100664751);
			Message.NativeMethodInfoPtr_CreateReadonlyTextFragment_Public_ReadOnlyMessageFragment_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Message>.NativeClassPtr, 100664752);
			Message.NativeMethodInfoPtr_CreateReadonlyTextFragment_Public_ReadOnlyMessageFragment_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Message>.NativeClassPtr, 100664753);
			Message.NativeMethodInfoPtr_ReplaceFragment_Public_Void_MessageFragment_MessageFragment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Message>.NativeClassPtr, 100664754);
			Message.NativeMethodInfoPtr_ReleaseFragment_Public_Void_MessageFragment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Message>.NativeClassPtr, 100664755);
			Message.NativeMethodInfoPtr_CreateMessage_Internal_Static_Message_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Message>.NativeClassPtr, 100664756);
			Message.NativeMethodInfoPtr_Release_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Message>.NativeClassPtr, 100664757);
			Message.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Message>.NativeClassPtr, 100664758);
			Message.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Message>.NativeClassPtr, 100664759);
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06000823 RID: 2083 RVA: 0x00028B00 File Offset: 0x00026D00
		// (set) Token: 0x06000824 RID: 2084 RVA: 0x00028B38 File Offset: 0x00026D38
		public unsafe string Original
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Message.NativeMethodInfoPtr_get_Original_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Message.NativeMethodInfoPtr_set_Original_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x06000825 RID: 2085 RVA: 0x00028B7C File Offset: 0x00026D7C
		// (set) Token: 0x06000826 RID: 2086 RVA: 0x00028BBC File Offset: 0x00026DBC
		public unsafe List<MessageFragment> Fragments
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Message.NativeMethodInfoPtr_get_Fragments_Public_get_List_1_MessageFragment_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<MessageFragment>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Message.NativeMethodInfoPtr_set_Fragments_Private_set_Void_List_1_MessageFragment_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x06000827 RID: 2087 RVA: 0x00028C00 File Offset: 0x00026E00
		public unsafe int Length
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1076091, RefRangeEnd = 1076092, XrefRangeStart = 1076076, XrefRangeEnd = 1076091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Message.NativeMethodInfoPtr_get_Length_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000828 RID: 2088 RVA: 0x00028C3C File Offset: 0x00026E3C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1076102, RefRangeEnd = 1076106, XrefRangeStart = 1076092, XrefRangeEnd = 1076102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WritableMessageFragment CreateTextFragment(string original, int start, int end)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(original);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Message.NativeMethodInfoPtr_CreateTextFragment_Public_WritableMessageFragment_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WritableMessageFragment>(intPtr3) : null;
		}

		// Token: 0x06000829 RID: 2089 RVA: 0x00028CA8 File Offset: 0x00026EA8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1076116, RefRangeEnd = 1076120, XrefRangeStart = 1076106, XrefRangeEnd = 1076116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WritableMessageFragment CreateTextFragment(string original)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(original);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Message.NativeMethodInfoPtr_CreateTextFragment_Public_WritableMessageFragment_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WritableMessageFragment>(intPtr3) : null;
			}
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x00028CF8 File Offset: 0x00026EF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076120, XrefRangeEnd = 1076130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadOnlyMessageFragment CreateReadonlyTextFragment(string original, int start, int end)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(original);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Message.NativeMethodInfoPtr_CreateReadonlyTextFragment_Public_ReadOnlyMessageFragment_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyMessageFragment>(intPtr3) : null;
		}

		// Token: 0x0600082B RID: 2091 RVA: 0x00028D64 File Offset: 0x00026F64
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1076140, RefRangeEnd = 1076142, XrefRangeStart = 1076130, XrefRangeEnd = 1076140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadOnlyMessageFragment CreateReadonlyTextFragment(string original)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(original);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Message.NativeMethodInfoPtr_CreateReadonlyTextFragment_Public_ReadOnlyMessageFragment_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyMessageFragment>(intPtr3) : null;
			}
		}

		// Token: 0x0600082C RID: 2092 RVA: 0x00028DB4 File Offset: 0x00026FB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076142, XrefRangeEnd = 1076160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReplaceFragment(MessageFragment original, MessageFragment replacement)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(original);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(replacement);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Message.NativeMethodInfoPtr_ReplaceFragment_Public_Void_MessageFragment_MessageFragment_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600082D RID: 2093 RVA: 0x00028E08 File Offset: 0x00027008
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1076172, RefRangeEnd = 1076175, XrefRangeStart = 1076160, XrefRangeEnd = 1076172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReleaseFragment(MessageFragment fragment)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fragment);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Message.NativeMethodInfoPtr_ReleaseFragment_Public_Void_MessageFragment_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600082E RID: 2094 RVA: 0x00028E4C File Offset: 0x0002704C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1076198, RefRangeEnd = 1076199, XrefRangeStart = 1076175, XrefRangeEnd = 1076198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Message CreateMessage(string text)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Message.NativeMethodInfoPtr_CreateMessage_Internal_Static_Message_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Message>(intPtr3) : null;
			}
		}

		// Token: 0x0600082F RID: 2095 RVA: 0x00028E90 File Offset: 0x00027090
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1076223, RefRangeEnd = 1076224, XrefRangeStart = 1076199, XrefRangeEnd = 1076223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Message.NativeMethodInfoPtr_Release_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x00028EC4 File Offset: 0x000270C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076224, XrefRangeEnd = 1076251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Message.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000831 RID: 2097 RVA: 0x00028F08 File Offset: 0x00027108
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076251, XrefRangeEnd = 1076259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Message()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Message>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Message.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000832 RID: 2098 RVA: 0x000051FA File Offset: 0x000033FA
		public Message(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06000833 RID: 2099 RVA: 0x00028F44 File Offset: 0x00027144
		// (set) Token: 0x06000834 RID: 2100 RVA: 0x00005203 File Offset: 0x00003403
		public unsafe static ObjectPool<Message> Pool
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Message.NativeFieldInfoPtr_Pool, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<Message>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Message.NativeFieldInfoPtr_Pool, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000835 RID: 2101 RVA: 0x00028F6C File Offset: 0x0002716C
		// (set) Token: 0x06000836 RID: 2102 RVA: 0x00005215 File Offset: 0x00003415
		public unsafe string _Original_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Message.NativeFieldInfoPtr__Original_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Message.NativeFieldInfoPtr__Original_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06000837 RID: 2103 RVA: 0x00028F94 File Offset: 0x00027194
		// (set) Token: 0x06000838 RID: 2104 RVA: 0x00005234 File Offset: 0x00003434
		public unsafe List<MessageFragment> _Fragments_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Message.NativeFieldInfoPtr__Fragments_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MessageFragment>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Message.NativeFieldInfoPtr__Fragments_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005D2 RID: 1490
		private static readonly IntPtr NativeFieldInfoPtr_Pool;

		// Token: 0x040005D3 RID: 1491
		private static readonly IntPtr NativeFieldInfoPtr__Original_k__BackingField;

		// Token: 0x040005D4 RID: 1492
		private static readonly IntPtr NativeFieldInfoPtr__Fragments_k__BackingField;

		// Token: 0x040005D5 RID: 1493
		private static readonly IntPtr NativeMethodInfoPtr_get_Original_Public_get_String_0;

		// Token: 0x040005D6 RID: 1494
		private static readonly IntPtr NativeMethodInfoPtr_set_Original_Private_set_Void_String_0;

		// Token: 0x040005D7 RID: 1495
		private static readonly IntPtr NativeMethodInfoPtr_get_Fragments_Public_get_List_1_MessageFragment_0;

		// Token: 0x040005D8 RID: 1496
		private static readonly IntPtr NativeMethodInfoPtr_set_Fragments_Private_set_Void_List_1_MessageFragment_0;

		// Token: 0x040005D9 RID: 1497
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_get_Int32_0;

		// Token: 0x040005DA RID: 1498
		private static readonly IntPtr NativeMethodInfoPtr_CreateTextFragment_Public_WritableMessageFragment_String_Int32_Int32_0;

		// Token: 0x040005DB RID: 1499
		private static readonly IntPtr NativeMethodInfoPtr_CreateTextFragment_Public_WritableMessageFragment_String_0;

		// Token: 0x040005DC RID: 1500
		private static readonly IntPtr NativeMethodInfoPtr_CreateReadonlyTextFragment_Public_ReadOnlyMessageFragment_String_Int32_Int32_0;

		// Token: 0x040005DD RID: 1501
		private static readonly IntPtr NativeMethodInfoPtr_CreateReadonlyTextFragment_Public_ReadOnlyMessageFragment_String_0;

		// Token: 0x040005DE RID: 1502
		private static readonly IntPtr NativeMethodInfoPtr_ReplaceFragment_Public_Void_MessageFragment_MessageFragment_0;

		// Token: 0x040005DF RID: 1503
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseFragment_Public_Void_MessageFragment_0;

		// Token: 0x040005E0 RID: 1504
		private static readonly IntPtr NativeMethodInfoPtr_CreateMessage_Internal_Static_Message_String_0;

		// Token: 0x040005E1 RID: 1505
		private static readonly IntPtr NativeMethodInfoPtr_Release_Internal_Void_0;

		// Token: 0x040005E2 RID: 1506
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040005E3 RID: 1507
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000162 RID: 354
		[ObfuscatedName("UnityEngine.Localization.Pseudo.Message+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000F42 RID: 3906 RVA: 0x00041668 File Offset: 0x0003F868
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Message.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Message>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Message.__c>.NativeClassPtr);
				Message.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Message.__c>.NativeClassPtr, "<>9");
				Message.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Message.__c>.NativeClassPtr, 100664762);
				Message.__c.NativeMethodInfoPtr___cctor_b__21_0_Internal_Message_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Message.__c>.NativeClassPtr, 100664763);
			}

			// Token: 0x06000F43 RID: 3907 RVA: 0x000416D0 File Offset: 0x0003F8D0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Message.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Message.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000F44 RID: 3908 RVA: 0x0004170C File Offset: 0x0003F90C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076065, XrefRangeEnd = 1076076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Message __cctor_b__21_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Message.__c.NativeMethodInfoPtr___cctor_b__21_0_Internal_Message_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Message>(intPtr3) : null;
			}

			// Token: 0x06000F45 RID: 3909 RVA: 0x00008646 File Offset: 0x00006846
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700041D RID: 1053
			// (get) Token: 0x06000F46 RID: 3910 RVA: 0x0004174C File Offset: 0x0003F94C
			// (set) Token: 0x06000F47 RID: 3911 RVA: 0x0000864F File Offset: 0x0000684F
			public unsafe static Message.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Message.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Message.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Message.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000A70 RID: 2672
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000A71 RID: 2673
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000A72 RID: 2674
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__21_0_Internal_Message_0;
		}
	}
}
