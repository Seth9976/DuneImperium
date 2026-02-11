using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace boardgames.match
{
	// Token: 0x02000129 RID: 297
	public static class EventDeserialization : Object
	{
		// Token: 0x06000F9C RID: 3996 RVA: 0x000409EC File Offset: 0x0003EBEC
		// Note: this type is marked as 'beforefieldinit'.
		static EventDeserialization()
		{
			Il2CppClassPointerStore<EventDeserialization>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.match", "EventDeserialization");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventDeserialization>.NativeClassPtr);
			EventDeserialization.NativeFieldInfoPtr_CompressedCounterBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDeserialization>.NativeClassPtr, "CompressedCounterBytes");
			EventDeserialization.NativeFieldInfoPtr_BOMChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDeserialization>.NativeClassPtr, "BOMChar");
			EventDeserialization.NativeMethodInfoPtr_FixBOMIfNeeded_Private_Static_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDeserialization>.NativeClassPtr, 100665525);
			EventDeserialization.NativeMethodInfoPtr_DeflateDecompress_Private_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDeserialization>.NativeClassPtr, 100665526);
			EventDeserialization.NativeMethodInfoPtr_TryGetCompressedData_Private_Static_Boolean_Il2CppStructArray_1_Byte_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDeserialization>.NativeClassPtr, 100665527);
			EventDeserialization.NativeMethodInfoPtr_DeserializeMessage_Public_Static_ValueTuple_2_String_DWDEvent_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDeserialization>.NativeClassPtr, 100665528);
		}

		// Token: 0x06000F9D RID: 3997 RVA: 0x00040A94 File Offset: 0x0003EC94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool FixBOMIfNeeded(ref string str)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(str);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(EventDeserialization.NativeMethodInfoPtr_FixBOMIfNeeded_Private_Static_Boolean_byref_String_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				str = IL2CPP.Il2CppStringToManaged(intPtr);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06000F9E RID: 3998 RVA: 0x00040AE4 File Offset: 0x0003ECE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997933, XrefRangeEnd = 997959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> DeflateDecompress(Il2CppStructArray<byte> data)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDeserialization.NativeMethodInfoPtr_DeflateDecompress_Private_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06000F9F RID: 3999 RVA: 0x00040B28 File Offset: 0x0003ED28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 997974, RefRangeEnd = 997975, XrefRangeStart = 997959, XrefRangeEnd = 997974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetCompressedData(Il2CppStructArray<byte> data, out string dataString)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(EventDeserialization.NativeMethodInfoPtr_TryGetCompressedData_Private_Static_Boolean_Il2CppStructArray_1_Byte_byref_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			dataString = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000FA0 RID: 4000 RVA: 0x00040B84 File Offset: 0x0003ED84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997975, XrefRangeEnd = 998074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ValueTuple<string, DWDEvent> DeserializeMessage(Il2CppStructArray<byte> data)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDeserialization.NativeMethodInfoPtr_DeserializeMessage_Public_Static_ValueTuple_2_String_DWDEvent_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ValueTuple<string, DWDEvent>(intPtr);
			}
		}

		// Token: 0x06000FA1 RID: 4001 RVA: 0x0000949D File Offset: 0x0000769D
		public EventDeserialization(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x06000FA2 RID: 4002 RVA: 0x00040BC0 File Offset: 0x0003EDC0
		// (set) Token: 0x06000FA3 RID: 4003 RVA: 0x000094A6 File Offset: 0x000076A6
		public unsafe static Il2CppStructArray<byte> CompressedCounterBytes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EventDeserialization.NativeFieldInfoPtr_CompressedCounterBytes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EventDeserialization.NativeFieldInfoPtr_CompressedCounterBytes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x06000FA4 RID: 4004 RVA: 0x00040BE8 File Offset: 0x0003EDE8
		// (set) Token: 0x06000FA5 RID: 4005 RVA: 0x000094B8 File Offset: 0x000076B8
		public unsafe static char BOMChar
		{
			get
			{
				char c;
				IL2CPP.il2cpp_field_static_get_value(EventDeserialization.NativeFieldInfoPtr_BOMChar, (void*)(&c));
				return c;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EventDeserialization.NativeFieldInfoPtr_BOMChar, (void*)(&value));
			}
		}

		// Token: 0x0400097A RID: 2426
		private static readonly IntPtr NativeFieldInfoPtr_CompressedCounterBytes;

		// Token: 0x0400097B RID: 2427
		private static readonly IntPtr NativeFieldInfoPtr_BOMChar;

		// Token: 0x0400097C RID: 2428
		private static readonly IntPtr NativeMethodInfoPtr_FixBOMIfNeeded_Private_Static_Boolean_byref_String_0;

		// Token: 0x0400097D RID: 2429
		private static readonly IntPtr NativeMethodInfoPtr_DeflateDecompress_Private_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400097E RID: 2430
		private static readonly IntPtr NativeMethodInfoPtr_TryGetCompressedData_Private_Static_Boolean_Il2CppStructArray_1_Byte_byref_String_0;

		// Token: 0x0400097F RID: 2431
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeMessage_Public_Static_ValueTuple_2_String_DWDEvent_Il2CppStructArray_1_Byte_0;
	}
}
